using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20170225_WinFormsEventsDemo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            int n = 10;
            int m = 20;

            MyButton[,] fields = new MyButton[n, m];
            for (int i = 0; i < fields.GetLength(0); i++)
            {
                for (int j = 0; j < fields.GetLength(1); j++)
                {
                    MyButton newButton = new MyButton();

                    newButton.Location = new System.Drawing.Point((j+1)*30, (i+1)*30);
                    newButton.Name = "button1";
                    newButton.Size = new System.Drawing.Size(20, 20);
                   // newButton.TabIndex = 2;
                    //newButton.Text = "button1";
                    newButton.PosX = i;
                    newButton.PosY = j;
                    newButton.UseVisualStyleBackColor = true;
                    newButton.Click += field_Click;

                    Controls.Add(newButton);

                    fields[i, j] = newButton;
                }
            }
        }

        private void field_Click(object sender, EventArgs e)
        {
            MyButton btnSender = sender as MyButton;

            if (btnSender != null)
            {
                MessageBox.Show(string.Format("Click ({0}, {1})!", btnSender.PosX, btnSender.PosY));
            }
            else
            {
                MessageBox.Show("Click!");
            }            
        }

        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            lblFist.Text = string.Format("({0}, {1})", e.X, e.Y);
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (_fControl)
            {
                lblSecond.Text = string.Format("({0}, {1})", e.X, e.Y);
            }
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            _fControl = true;
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            _fControl = false;
        }

        private bool _fControl = false;

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
