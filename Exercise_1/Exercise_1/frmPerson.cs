using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EX1_Library;
namespace Exercise_1
{
    public partial class frmPerson : Form
    {
        private Person person;
        public frmPerson()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (this.person is null)
            { 
                this.person = new Person();
                this.person.EventString += this.NotifyChange;
                this.person.Name = txtName.Text;
                this.person.LastName = txtLastName.Text;
                this.btnCreate.Text = "Update";
            }

            this.person.Name = txtName.Text;
            this.person.LastName = txtLastName.Text;
        }

        public void NotifyChange(string change) 
        {
            MessageBox.Show(change);
        }
    }
}
