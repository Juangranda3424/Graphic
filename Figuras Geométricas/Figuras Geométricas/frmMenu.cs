using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figuras_Geométricas.Logic.Figures;

namespace Figuras_Geométricas
{
    public partial class frmMenu : Form
    {

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                assignEvent(item);
            }
        }

        private void assignEvent(ToolStripMenuItem item)
        {
            item.MouseEnter += mouseEnter;
            item.MouseLeave += mouseLeave;
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                changeColorWhiteBlack(item);
            }
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                changeColorBlackWhite(item);
            }

        }
        private void changeColorWhiteBlack(ToolStripMenuItem option)
        {
            option.BackColor = Color.White;
            option.ForeColor = Color.Black;
        }

        private void changeColorBlackWhite(ToolStripMenuItem option)
        {
            option.BackColor = Color.Black;
            option.ForeColor = Color.White;
        }


        private void starToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logic.Figures.Star form = new Logic.Figures.Star();
            form.Show();
        }

        private void deltoidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logic.Figures.Deltoid form = new Logic.Figures.Deltoid();
            form.Show();
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logic.Figures.Square form = new Logic.Figures.Square();
            form.Show();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logic.Figures.Triangle form = new Logic.Figures.Triangle();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logic.Figures.Rectangle form = new Logic.Figures.Rectangle();
            form.Show();
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logic.Figures.Circle form = new Logic.Figures.Circle();
            form.Show();
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logic.Figures.Ellipse form = new Logic.Figures.Ellipse();
            form.Show();
        }

        private void semicircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logic.Figures.Semicircle form = new Logic.Figures.Semicircle();
            form.Show();
        }

        private void trapezeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logic.Figures.Trapeze form = new Logic.Figures.Trapeze();
            form.Show();
        }

        private void trapeziumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logic.Figures.Trapezium form = new Logic.Figures.Trapezium();
            form.Show();
        }

        private void diamondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logic.Figures.Diamond form = new Logic.Figures.Diamond();
            form.Show();
        }

        private void rhomboidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logic.Figures.Rhomboid form = new Logic.Figures.Rhomboid();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
