﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharkTrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //instanciar janela login
            MenuPrincipal janela = new MenuPrincipal();
            //mostrar a janela
            janela.ShowDialog();

            //fechar tudo ao fechar janela login
            Application.Exit();
        }
    }
}
