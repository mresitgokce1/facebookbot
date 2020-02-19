using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class HomePageForm : DevExpress.XtraEditors.XtraForm
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBtn_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm();
            groupForm.Show();
            this.Hide();
        }

        private void pageBtn_Click(object sender, EventArgs e)
        {
            PageForm pageForm = new PageForm();
            pageForm.Show();
            this.Hide();
        }

        private void messengerBtn_Click(object sender, EventArgs e)
        {
            MessengerForm messengerForm = new MessengerForm();
            messengerForm.Show();
            this.Hide();
        }
    }
}
