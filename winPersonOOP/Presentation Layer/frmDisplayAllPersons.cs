using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winPersonOOP.Presentation_Layer
{
    public partial class frmDisplayAllPersons : Form
    {
        public frmDisplayAllPersons()
        {
            InitializeComponent();
        }
        private void frmDisplayAllPersons_Load(object sender, EventArgs e)
        {
            grdDisplayAllPersons.DataSource = frmMain.PersonList;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
