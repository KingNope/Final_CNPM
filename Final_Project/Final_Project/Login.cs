﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Edt_name_Leave(object sender, EventArgs e)
        {
            if (Edt_name.Text == "")
            {
                Edt_name.Text = "Enter your name";
                Edt_name.ForeColor = Color.DarkGray;
            }
        }

        private void Edt_name_Enter(object sender, EventArgs e)
        {
            if(Edt_name.Text == "Enter your name")
            {
                Edt_name.Text = "";
                Edt_name.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if(Password.Text == "")
            {
                Password.Text = "Enter your password";
                Password.ForeColor = Color.DarkGray;
                Password.UseSystemPasswordChar = false;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Enter your password")
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
                Password.UseSystemPasswordChar = true;
            }
        }
    }
}
