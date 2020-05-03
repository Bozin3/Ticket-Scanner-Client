using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketDataHandler;
using TicketDataHandler.Models;
using TicketDataHandler.Responses;

namespace TicketScannerClient
{
    public partial class TicketScannerForm : Form
    {

        private TicketHandler ticketHandler;
    
        public TicketScannerForm()
        {
            InitializeComponent();
        }

        private void TicketScannerForm_Load(object sender, EventArgs e)
        {
            if (Core.Auth == null) {
                // no logged client
                this.Close();
            }
            else
            {
                SetupViews(Core.Event);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetCoreValues();
            ResetInfoViews();

            this.Close();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Core.Event == null)
            {
                MessageBox.Show("Please choose an event.");
            }
            else
            {
                var stats = new EventStatistics();
                stats.Show();
            }
        }

        private void chooseAnEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
            EventPicker eventPicker = new EventPicker();
            eventPicker.OnEventSave += OnEventChosen;
            eventPicker.Show();

        }

        private void OnEventChosen(Event chosenEvent)
        {
            if(chosenEvent != null)
            {
                Core.Event = chosenEvent;

                SetupViews(Core.Event);
                ticketHandler = new TicketHandler(Core.Event, Core.Auth.Token);
            }
        }

        private async void tbBarcodeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if(ticketHandler != null)
                {
                    var ticketResponse = await ticketHandler.CheckTicket(tbBarcodeInput.Text);
                    HandleTicketResponse(ticketResponse, tbBarcodeInput.Text);
                    tbBarcodeInput.Text = "";
                }
                else
                {
                    MessageBox.Show("Ticket handler is not initialized.");
                }
            }
        }

        private void HandleTicketResponse(TicketsResponse<Ticket> ticketResponse, string scannedBarcode)
        {
            if (ticketResponse.Error)
            {
                MessageBox.Show($"Error validating ticket: {ticketResponse.Message}");
            }
            else
            {
                lblBarcode.Text = scannedBarcode;
                if (ticketResponse.Ticket.IsActivated)
                {
                    colorPanel.BackColor = Color.Firebrick;
                    lblValid.Text = "INVALID";

                    string timeFormated = ticketResponse.Ticket.ActivatedAt != null ?
                                        DateTime.Parse(ticketResponse.Ticket.ActivatedAt).ToString("yyyy-MM-dd HH:mm:ss") : "";

                    lblActivatedAt.Text = "Activated at " + timeFormated;
                }
                else
                {
                    colorPanel.BackColor = Color.OliveDrab;
                    lblValid.Text = "VALID";
                    lblActivatedAt.Text = "Activating at " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    //UpdateStatsForm(ticketResponse.Ticket); // updating the statistics screen ( if its activated )
                }
            }
        }

        

        private void SetupViews(Event eventInfo)
        {
            // positions
            colorPanel.Width = this.Width;
            lblBarcode.Left = (this.Width - lblBarcode.Width) / 2;
            lblValid.Left = (this.Width - lblValid.Width) / 2;
            lblActivatedAt.Left = (this.Width - lblActivatedAt.Width) / 2;
            imgBarcode.Left = (this.Width - imgBarcode.Width) / 2;
            tbBarcodeInput.Left = (this.Width - tbBarcodeInput.Width) / 2;
            tbBarcodeInput.Visible = false;
            lblEventName.Text = "";
            lblEventDate.Text = "";

            //event data
            if (eventInfo != null)
            {
                lblEventName.Text = $"Event Name : {eventInfo.Name}";
                lblEventDate.Text = $"Event Date : {eventInfo.EventDate}";
                colorPanel.BackColor = Color.LightGray;
                lblBarcode.Text = "";
                lblValid.Text = "Scan a ticket";
                lblActivatedAt.Text = "";
                EnableBarcodeInput();
            }
            else
            {
                ResetInfoViews();
            }

            //auth data
            if (Core.Auth.Client != null)
            {
                lblClient.Text = Core.Auth.Client.Username;
            }
        }

        private void ResetInfoViews()
        {
            colorPanel.BackColor = Color.LightGray;
            lblBarcode.Text = "";
            lblValid.Text = "Choose an event.";
            lblActivatedAt.Text = "";
            tbBarcodeInput.Visible = false;
            lblEventName.Text = "";
            lblEventDate.Text = "";
        }

        private void ResetCoreValues()
        {
            Core.Event = null;
            Core.Auth = null;
            ticketHandler = null;
        }

        private void EnableBarcodeInput()
        {
            tbBarcodeInput.Visible = true;
            tbBarcodeInput.Focus();
        }
       
        //private void UpdateStatsForm(Ticket scannedTicket)
        //{
        //    if (stats != null && !stats.IsDisposed)
        //    {
        //        stats.OnTicketScanned(scannedTicket);
        //    }
        //}
    }
}
