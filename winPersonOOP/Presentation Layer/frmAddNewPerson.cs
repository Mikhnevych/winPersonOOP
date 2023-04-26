using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winPersonOOP.Buisness_Layer;

namespace winPersonOOP.Presentation_Layer
{
    public partial class frmAddNewPerson : Form
    {
        public frmAddNewPerson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Person tempPerson = new Person();
            tempPerson.Name = txtName.Text;
            tempPerson.Address = txtAddress.Text;
            tempPerson.Age = Convert.ToInt32(txtAge.Text);

            frmMain.PersonList.Add(tempPerson);

            txtName.Text = frmMain.PersonList.Count().ToString();
            txtAddress.Text = "";
            txtAge.Text = "";

            MessageBox.Show("The information was successfully saved", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        
        
    }
}
