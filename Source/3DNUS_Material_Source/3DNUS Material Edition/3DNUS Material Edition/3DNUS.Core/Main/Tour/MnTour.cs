﻿using MaterialSkin.Controls;
using System;

namespace _3DNUS.Core.Tour
{
    public partial class dev_tour : MaterialForm
    {
        public dev_tour()
        {
            InitializeComponent();
        }

        private void b_next_Click(object sender, EventArgs e)
        {
            dev_tour_setup f = new dev_tour_setup();
            f.Show();
            Close();
        }
    }
}