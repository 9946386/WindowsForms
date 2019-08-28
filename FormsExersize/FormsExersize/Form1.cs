using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExersize
{
    public partial class Form1 : Form
    {
        List<Deets> people = new List<Deets>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Deets newPerson = new Deets();
            newPerson.Fname = txtFirstName.Text;
            newPerson.Lname = txtLastName.Text;
            newPerson.Age = int.Parse(txtAge.Text);
            people.Add(newPerson);

            txtAge.Text = null;
            txtFirstName.Text = null;
            txtLastName.Text = null;

            lblOutput.Text = "Record created";

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Displaying all records";

            foreach(var x in people)
            {
                listBox1.Items.Add(x.DisplayName());
                listBox1.Items.Add("Age: " + x.Age);
                listBox1.Items.Add("*----------------------*");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAge.Text = null;
            txtLastName.Text = null;
            txtFirstName.Text = null;
            lblOutput.Text = null;
            listBox1.Items.Clear();
        }
        
    }
}
