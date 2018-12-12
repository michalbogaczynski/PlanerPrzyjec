using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanistaPrzyjec
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty() { numberOfPeople = 5 };
            dinnerParty.CalculateCostOfDecorations(false);
            dinnerParty.SetHealthyOption(true);
            DisplayDinnerPartCost();
        }

        private void DisplayDinnerPartCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthyBox.Checked);
            costLabel.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerPartCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyBox.Checked);
            DisplayDinnerPartCost();
        }
    }
}
