﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class MyMDIForm : Form
    {
        public MyMDIForm()
        {
            InitializeComponent();
        }

        void ChildForm(Form childForm)
        {
            this.Width = childForm.Width + 25;
            this.Height = childForm.Height + 60;
            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text==childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum==false)
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
        }
        private void tsmSiparisOlustur_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());
        }

        private void tsmSiparisBilgileri_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());
        }

        private void tsmMenuEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }

        private void tsmEkstraEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MyMDIForm_Load(object sender, EventArgs e)
        {

        }
    }
}
