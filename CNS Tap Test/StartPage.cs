using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNS_Tap_Test
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
            start_btn.FlatStyle = FlatStyle.Flat;
            start_btn.FlatAppearance.BorderSize = 0;
            start_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            start_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            start_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
        }
    }
}
