using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Home : Form
    {
        int moveScreen;
        int mPosX;
        int mPosY;

        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e) // Close the program
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e) // Minimise the program
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)   //whilst the mouse is held down, get the positions   
        {
             moveScreen = 1;
             mPosX = e.X;
             mPosY = e.Y;
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)  //  static screen, this is a non-moving state. 
        {
            moveScreen = 0;

        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)    //  moving the screen and updating the position on the screen.
        {
            if (moveScreen == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mPosX, MousePosition.Y - mPosY);
            }
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
            label2.BackColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
            label2.BackColor = Color.DodgerBlue;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label1.BackColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label1.BackColor = Color.DodgerBlue;
        }

    }
}
