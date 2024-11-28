using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceDiskLab_2
{
    public partial class ShowInfo : Form
    {
        public ShowInfo(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }
    }
}
