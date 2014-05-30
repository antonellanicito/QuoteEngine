using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuoteEngine.Contracts;
using QuoteEngine;
using QuoteEngine.Builder;
using QuoteEngine.Builder.Contracts;

namespace QuoteEngineApp
{
    public partial class InfoTravel : Form
    {
        public InfoTravel()
        {
            InitializeComponent();
        }

        private void cmbTripType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTripType.SelectedItem.ToString())
            {
                case "SingleTrip":
                    txtDays.Visible = true;
                    lblDays.Visible = true;
                    break;
                case "Annual":
                    txtDays.Visible = false;
                    lblDays.Visible = false;
                    break;

            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

            txtBox.Text = "";
            try
            {
                string input = createString();
                IBuilder builder = new Builder();
                IQuoteEngineProvider quoteProvider = new QuoteEngineProvider(builder);
                string quote = quoteProvider.ProduceQuote(input);
                txtBox.Text = quote;
            }

            catch { }

        }
        
        private string createString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Type:" + cmbTripType.SelectedItem.ToString());
            if (txtDays.Visible)
                sb.AppendLine("PeriodOfTravel:" + txtDays.Text.Trim());
            sb.AppendLine("Destination:" + cmbDestination.SelectedItem.ToString());
            sb.AppendLine("Age:" + txtAge.Text.Trim());
            sb.AppendLine("Sex:" + cmbSex.SelectedItem.ToString());
            return sb.ToString();

        }
    }
}
