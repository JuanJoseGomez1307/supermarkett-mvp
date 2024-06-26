﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarkett_mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
            BtnProducts.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
            BtnProviders.Click += delegate { ShowProvidersView?.Invoke(this, EventArgs.Empty); };
            BtnCategories.Click += delegate { ShowCategoriesView?.Invoke(this, EventArgs.Empty); };
            BtnExit.Click += delegate { this.Close(); };
        }

        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowProvidersView;
        public event EventHandler ShowCategoriesView;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
