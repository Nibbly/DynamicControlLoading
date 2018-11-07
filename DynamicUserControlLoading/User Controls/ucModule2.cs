using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicUserControlLoading
{
    public partial class ucModule2 : UserControl
    {
        private static ucModule2 _instance = null;

        public static ucModule2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucModule2();

                return _instance;
            }
        }

        public ucModule2()
        {
            InitializeComponent();
        }

        private void ucModule2_Load(object sender, EventArgs e)
        {

        }
    }
}
