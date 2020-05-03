using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketDataHandler;
using TicketDataHandler.Models;

namespace TicketScannerClient
{
    public delegate void OnEventSave(Event chosenEvent);

    public partial class EventPicker : Form
    {
        private EventsHandler eventsHandler;
        private List<Event> events;

        public OnEventSave OnEventSave;

        public EventPicker()
        {
            eventsHandler = new EventsHandler(Core.Auth.Token);
            events = new List<Event>(); //default empty list
            InitializeComponent();
        }

        private async void EventPicker_Load(object sender, EventArgs e)
        {
            await GetEvents();
        }

        private async Task GetEvents()
        {
            var response = await eventsHandler.GetEvents("");
            if (response.Error)
            {
                MessageBox.Show("Error while downloading events, message: " + response.Message);
            }
            else
            {
                if(response.Events != null)
                {
                    events = response.Events;
                    listEvents.Items.Clear();

                    foreach(Event mEvent in events)
                    {
                        var listItem = new ListViewItem(mEvent.Name);
                        listItem.SubItems.Add(mEvent.EventDate.FormatDate("yyyy-MM-dd"));
                        listEvents.Items.Add(listItem);
                    }
                }
            }
        }

        private async void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await GetEvents();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanAndClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listEvents.SelectedItems.Count > 0)
            {
                var chosenEvent = events[listEvents.SelectedIndices[0]];
                chosenEvent.EventDate = chosenEvent.EventDate.FormatDate("yyy-MM-dd");
                OnEventSave?.Invoke(chosenEvent);
                OnEventSave = null;
                this.Close();
            }
            else {
                MessageBox.Show("Choose an event");
            }
        }

        private void CleanAndClose()
        {
            this.eventsHandler = null;
            this.Close();
        }
    }
}
