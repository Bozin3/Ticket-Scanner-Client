using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketDataHandler;
using TicketDataHandler.Models;
using TicketDataHandler.Responses;

namespace TicketScannerClient
{
    public partial class EventStatistics : Form
    {

        private List<Ticket> activatedTickets;
        private List<Ticket> filterActivatedTickets;
        private List<Ticket> inActivatedTickets;
        private List<Ticket> filterInActivatedTickets = new List<Ticket>();

        private System.Threading.Timer timer;

        public EventStatistics()
        {
            InitializeComponent();

            //if the parameter lists are null, assign them an empty list
            this.activatedTickets = new List<Ticket>();
            this.filterActivatedTickets = new List<Ticket>();

            this.inActivatedTickets = new List<Ticket>();
            this.filterInActivatedTickets = new List<Ticket>();
        }

        private async void EventStatistics_Load(object sender, EventArgs e)
        {
            await DownloadTickets();

            StartTimer();
        }

        private void SetupViews(Event eventInfo)
        {
            lblEventName.Text = eventInfo.Name;
            lblEventDate.Text = $"Event date : {eventInfo.EventDate}";

            lblActivatedTickets.Text = $"Checked tickets: {activatedTickets.Count}";
            UpdateActivatedTicketsList();

            lblInActiveTickets.Text = $"Available tickets: {inActivatedTickets.Count}";
            UpdateInActivatedTicketsList();

            lblTotalTickets.Text = $"Total tickets: {activatedTickets.Count + inActivatedTickets.Count}";

        }

        private void fillActivatedTickets(List<Ticket> activatedTickets)
        {
            listActivatedTickets.Items.Clear();
            foreach (Ticket ticket in activatedTickets)
            {
                var listItem = new ListViewItem(ticket.Barcode);

                listItem.SubItems.Add(ticket.ActivatedAt.FormatDate("yyyy-MM-dd HH:mm:ss"));
                listActivatedTickets.Items.Add(listItem);
            }
        }

        private void fillInActivatedTickets(List<Ticket> inActivatedTickets)
        {
            listInActivatedTickets.Items.Clear();
            foreach (Ticket ticket in inActivatedTickets)
            {
                var listItem = new ListViewItem(ticket.Barcode);

                listInActivatedTickets.Items.Add(listItem);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //await DownloadTickets();
            //SetupViews(Core.Event);
            StopTimer();
            StartTimer();
        }

        private void tbSearchActiveTcs_TextChanged(object sender, EventArgs e)
        {
            UpdateActivatedTicketsList();
        }

        private void UpdateActivatedTicketsList()
        {
            if (tbSearchActiveTcs.Text.Equals(""))
            {
                fillActivatedTickets(activatedTickets);
            }
            else
            {
                filterActivatedTickets.Clear();
                //filtering the tickets
                filterActivatedTickets = FilterTickets(tbSearchActiveTcs.Text, "activated");
                fillActivatedTickets(filterActivatedTickets);
            }
        }

        private void tbSearchInActiveTcs_TextChanged(object sender, EventArgs e)
        {
            UpdateInActivatedTicketsList();
        }

        private void UpdateInActivatedTicketsList()
        {
            if (tbSearchInActiveTcs.Text.Equals(""))
            {
                fillInActivatedTickets(inActivatedTickets);
            }
            else
            {
                filterInActivatedTickets.Clear();
                //filtering the tickets
                filterInActivatedTickets = FilterTickets(tbSearchInActiveTcs.Text, "inActivated");
                fillInActivatedTickets(filterInActivatedTickets);
            }
        }

        private List<Ticket> FilterTickets(string filter, string type)
        {
            if (type.Equals("activated"))
            {
                foreach (Ticket ticket in activatedTickets)
                {
                    if (ticket.Barcode.Contains(filter))
                    {
                        filterActivatedTickets.Add(ticket);
                    }
                }
                return filterActivatedTickets;
            }
            else
            {
                foreach (Ticket ticket in inActivatedTickets)
                {
                    if (ticket.Barcode.Contains(filter))
                    {
                        filterInActivatedTickets.Add(ticket);
                    }
                }
                return filterInActivatedTickets;
            }

        }

        public void OnTicketScanned(Ticket ticket)
        {
            // updating the listviews
            inActivatedTickets.Remove(ticket);
            activatedTickets.Add(ticket);
            fillActivatedTickets(activatedTickets);
            fillInActivatedTickets(inActivatedTickets);
        }

        private async Task DownloadTickets()
        {
            Console.WriteLine("Downloading tickets.");
            var ticketHandler = new TicketHandler(Core.Event, Core.Auth.Token);
            var activeTicketsResp = await TicketsDownloader.DownloadTickets(ticketHandler, "active");
            if (activeTicketsResp != null)
            {
                // getting the actived tickets from the response
                activatedTickets = activeTicketsResp.Ticket;
            }

            var inActiveTicketsResp = await TicketsDownloader.DownloadTickets(ticketHandler, "inactive");
            if (inActiveTicketsResp != null)
            {
                // getting the inactived tickets from the response
                inActivatedTickets = inActiveTicketsResp.Ticket;
            }

            //update the UI
            this.Invoke((MethodInvoker)delegate ()
            {
                SetupViews(Core.Event);
            });
            
        }

        private void EventStatistics_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopTimer();
        }

        private void StartTimer()
        {
            timer = new System.Threading.Timer(
            e => DownloadTickets(),
            null,
            TimeSpan.Zero,
            TimeSpan.FromSeconds(10));
        }

        private void StopTimer()
        {
            if (timer != null)
            {
                timer.Dispose();
            }
        }
    }
}
