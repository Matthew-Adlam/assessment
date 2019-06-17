using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessment
{
    public partial class Form1 : Form
    {
        Graphics g;

        int score = 0;
        int lives = 0;
        int x = 20;
        int y = 20;

        Rectangle areaRobber;
        Rectangle[] area = new Rectangle[7];

        public Form1()
        {
            InitializeComponent();
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
