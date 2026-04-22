using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleFormApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string age = txtAge.Text;
            string roll = txtRoll.Text;

            MessageBox.Show(
                "Name: " + name +
                "\nAge: " + age +
                "\nRoll Number: " + roll,
                "Student Details"
            );
        }
    }
}