using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS677Project
{
    public partial class NeighborPage : Form
    {
        public NeighborPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Goals().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Rewards().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Schedule().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
