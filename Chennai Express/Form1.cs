using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chennai_Express
{
    public partial class Form1 : Form
    {

        private List<string> sourceStations;
        private List<string> destinationStations;
        private ITrain chennaiExpress;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1LoadEventHandler(object sender, EventArgs e)
        {
            chennaiExpress = new ChennaiExpress();
            InitializeTrainDetails(chennaiExpress);
        }

        private void InitializeTrainDetails(ITrain train)
        {
            sourceStations = (List<string>)Extensions.Clone(train.Stations);
            destinationStations = (List<string>)Extensions.Clone(train.Stations);

            cbxSourceStations.DataSource = sourceStations;
            cbxDestinationStaions.DataSource = destinationStations;
        }

        private void btnPrintTicketClickHandler(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(cbxSourceStations.Text, cbxDestinationStaions.Text,24, 20);

            IFareCalculator fareCalculator = new FareCalculator(chennaiExpress);
            fareCalculator = new AgeFareCalculator(fareCalculator);
            fareCalculator = new LuggageFareCalculator(fareCalculator);

            double fare = fareCalculator.GetFare(ticket);

            MessageBox.Show(string.Format("Total Fare = {0}", fare));
        }
    }
}
