using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG2Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadManager_CheckedChanged(object sender, EventArgs e)
        {
            NudBonus.Enabled = RadManager.Checked;
        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            string data = "";
            data += TxtName.Text + " " + txtLastName.Text + " Age: " + NudAge.Value + " Salary: $" + NudSalary.Value;
            if (RadManager.Checked)
            {
               data +=  " Bonus: $" + NudBonus.Value;
            }
            LstPeople.Items.Add(data);
        }

        private void LstPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LstPeople.SelectedIndex;
            btnRemove.Enabled = false;
            
            if (LstPeople.Items.Count != 0)
            {
                btnRemove.Enabled = true;
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (LstPeople.SelectedIndex != -1)
            {
                LstPeople.Items.RemoveAt(LstPeople.SelectedIndex);
                LstPeople.SelectedIndex = LstPeople.Items.Count - 1;
            }
            
        }
    }
}
