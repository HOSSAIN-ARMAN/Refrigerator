using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        Refrigerator refrigerator = new Refrigerator();
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            refrigerator.MaxiMumWeight = Convert.ToDouble(maxWeightTakeTextBox.Text);

            //refrigerator = new Refrigerator(Convert.ToDouble(maxWeightTakeTextBox.Text));
            maxWeightTakeTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            refrigerator.Items = Convert.ToDouble(itemTextBox.Text);
            refrigerator.ItemWeight = Convert.ToDouble(weightTextBox.Text);

            //refrigerator.GetItem(Convert.ToDouble(itemTextBox.Text));
            //refrigerator.GetItemWeight(Convert.ToDouble(weightTextBox.Text));
            itemTextBox.Clear();
            weightTextBox.Clear();
            if(refrigerator.GetCurrentWeight() > refrigerator.MaxiMumWeight)
            {
                MessageBox.Show("CurrentWeight is OverFlow the maximum weight");
            }
            else
            {
                currentWeightTextBox.Text = refrigerator.GetCurrentWeight().ToString();
                remainingWeightTextBox.Text = refrigerator.GetRemainingWeight().ToString();

                richTextBox.Text +=  refrigerator.GetItemList().ToString() + ",  "+
                                    refrigerator.GetItemWeightList().ToString() + ",  " +
                                    refrigerator.GetCurrentWeight().ToString()+"\n";
            }


        }
    }
}
