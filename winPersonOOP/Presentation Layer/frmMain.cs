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
    public partial class frmMain : Form
    {
        public static List<Person> PersonList = new List<Person>();

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddNewPerson addPerson = new frmAddNewPerson();
            addPerson.Show();
        }

        private void btnDisplayAllPersons_Click(object sender, EventArgs e)
        {
            frmDisplayAllPersons displayAllPersons= new frmDisplayAllPersons();
            displayAllPersons.Show();
         }
    }
}
