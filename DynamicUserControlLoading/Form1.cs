using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicUserControlLoading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void module1Button_Click(object sender, EventArgs e)
        {
            if (!panMain.Controls.Contains(ucModule1.Instance))
            {
                panMain.Controls.Add(ucModule1.Instance);
                ucModule1.Instance.Dock = DockStyle.Fill;
                ucModule1.Instance.BringToFront();
            }
            else
                ucModule1.Instance.BringToFront();

        }

        private void module2Button_Click(object sender, EventArgs e)
        {
            if (!panMain.Controls.Contains(ucModule2.Instance))
            {
                panMain.Controls.Add(ucModule2.Instance);
                ucModule2.Instance.Dock = DockStyle.Fill;
                ucModule2.Instance.BringToFront();
            }
            else
                ucModule2.Instance.BringToFront();
        }

        private void module3Button_Click(object sender, EventArgs e)
        {
            if (!panMain.Controls.Contains(ucModule3.Instance))
            {
                panMain.Controls.Add(ucModule3.Instance);
                ucModule3.Instance.Dock = DockStyle.Fill;
                ucModule3.Instance.BringToFront();
            }
            else
                ucModule3.Instance.BringToFront();
        }
    }
}
