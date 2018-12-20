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
        List<Employee> employees;
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
            Employee n;
            string data = "";
            //data += TxtName.Text + " " + txtLastName.Text + " Age: " + NudAge.Value + " Salary: $" + NudSalary.Value;
            if (RadManager.Checked)
            {
               //data +=  " Bonus: $" + NudBonus.Value;
                n = new Manager(TxtName.Text, txtLastName.Text, (int)NudAge.Value, (int)NudSalary.Value, (int)NudBonus.Value);
                employees.Add(n);
            }
            else
            {
                n = new Employee(TxtName.Text, txtLastName.Text, (int)NudAge.Value, (int)NudSalary.Value);
                employees.Add(n);
            }
            LstPeople.Items.Add(n.Info());
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

        private void Form1_Load(object sender, EventArgs e)
        {
            employees = new List<Employee>();
        }
    }
}
