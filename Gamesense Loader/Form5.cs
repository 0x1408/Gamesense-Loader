﻿using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SimpleLoader
{
    public partial class Form5 : Form
    {
        public string question,
            info;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Form5()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
            Random rnd = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            this.Text = new string(
                Enumerable
                    .Repeat(chars, rnd.Next(10, 20))
                    .Select(s => s[rnd.Next(s.Length)])
                    .ToArray()
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void Form5_Load(object sender, EventArgs e)
        {
            await Task.Delay(10000);
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
        }

        private void next_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void next_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        int r = 219;
        int g = 219;
        int b = 219;
        bool inv = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (r == 15 && g == 15 && b == 15)
            {
                inv = false;
            }
            if (r == 219 && g == 219 && b == 219)
            {
                inv = true;
            }
            if (inv)
            {
                r--;
                g--;
                b--;
                label4.ForeColor = Color.FromArgb(r, g, b);
                r--;
                g--;
                b--;
                label4.ForeColor = Color.FromArgb(r, g, b);
            }
            else
            {
                r++;
                g++;
                b++;
                label4.ForeColor = Color.FromArgb(r, g, b);
                r++;
                g++;
                b++;
                label4.ForeColor = Color.FromArgb(r, g, b);
            }
        }
    }
}
