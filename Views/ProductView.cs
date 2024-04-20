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
    public partial class ProductView : Form, IProductView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageProductsDetail);

            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNew.Click += delegate { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductsList);
                tabControl1.TabPages.Add(tabPageProductsDetail);
                tabPageProductsDetail.Text = "Add New Product";

            };

            BtnEdit.Click += delegate { 
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductsList);
                tabControl1.TabPages.Add(tabPageProductsDetail);
                tabPageProductsDetail.Text = "Edit Product";

            };

            BtnDelete.Click += delegate { 
                DeleteEvent?.Invoke(this, EventArgs.Empty);

                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Product",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };

            BtnSave.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageProductsDetail);
                    tabControl1.TabPages.Add(tabPageProductsList);
                }
                MessageBox.Show(Message);

            };

            BtnCancel.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductsDetail);
                tabControl1.TabPages.Add(tabPageProductsList);

            };

        }

        public string ProductId
        {
            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }
        }
        public string ProductName
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }
        }
        public string ProductObservation
        {
            get { return TxtProductObservation.Text; }
            set { TxtProductObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { Message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProductListBildingSource(BindingSource productList)
        {
            DgProduct.DataSource = productList;
        }

        private static ProductView instance;

        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}

