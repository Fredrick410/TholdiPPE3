using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THOLDI.IHM
{
    public partial class Declaration : Form
    {
        public Declaration()
        {
            InitializeComponent();
        }

        private void Declaration_Load(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Declaration log = new Declaration();
            this.Close();
        }

        private void RedirectionInspection(object sender, EventArgs e)
        {
            this.Hide();
            Inspection form = new Inspection();
            form.ShowDialog();
        }

        private void RedirectionContainer(object sender, EventArgs e)
        {
            this.Hide();
            Container form = new Container();
            form.ShowDialog();
        }

    }
}
