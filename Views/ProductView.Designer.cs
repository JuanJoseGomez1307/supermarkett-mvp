namespace supermarkett_mvp.Views
{
    partial class ProductView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPageProductsList = new TabPage();
            tabPageProductsDetail = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            dataGridView1 = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtProductId = new TextBox();
            TxtProductName = new TextBox();
            TxtProductObservation = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductsList.SuspendLayout();
            tabPageProductsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 34);
            label1.Name = "label1";
            label1.Size = new Size(190, 54);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(31, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductsList);
            tabControl1.Controls.Add(tabPageProductsDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 325);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductsList
            // 
            tabPageProductsList.Controls.Add(BtnClose);
            tabPageProductsList.Controls.Add(BtnDelete);
            tabPageProductsList.Controls.Add(BtnEdit);
            tabPageProductsList.Controls.Add(BtnNew);
            tabPageProductsList.Controls.Add(dataGridView1);
            tabPageProductsList.Controls.Add(BtnSearch);
            tabPageProductsList.Controls.Add(TxtSearch);
            tabPageProductsList.Controls.Add(label2);
            tabPageProductsList.Location = new Point(4, 29);
            tabPageProductsList.Name = "tabPageProductsList";
            tabPageProductsList.Padding = new Padding(3);
            tabPageProductsList.Size = new Size(792, 292);
            tabPageProductsList.TabIndex = 0;
            tabPageProductsList.Text = "Products List";
            tabPageProductsList.UseVisualStyleBackColor = true;
            // 
            // tabPageProductsDetail
            // 
            tabPageProductsDetail.Controls.Add(BtnCancel);
            tabPageProductsDetail.Controls.Add(BtnSave);
            tabPageProductsDetail.Controls.Add(TxtProductObservation);
            tabPageProductsDetail.Controls.Add(TxtProductName);
            tabPageProductsDetail.Controls.Add(TxtProductId);
            tabPageProductsDetail.Controls.Add(label5);
            tabPageProductsDetail.Controls.Add(label4);
            tabPageProductsDetail.Controls.Add(label3);
            tabPageProductsDetail.Location = new Point(4, 29);
            tabPageProductsDetail.Name = "tabPageProductsDetail";
            tabPageProductsDetail.Padding = new Padding(3);
            tabPageProductsDetail.Size = new Size(792, 292);
            tabPageProductsDetail.TabIndex = 1;
            tabPageProductsDetail.Text = "Products Detail";
            tabPageProductsDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 13);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Product";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(16, 43);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(391, 27);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(440, 37);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(80, 39);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(504, 188);
            dataGridView1.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(600, 85);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(130, 42);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(600, 132);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(130, 42);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(600, 182);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(130, 42);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(600, 231);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(130, 42);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 17);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 0;
            label3.Text = "Product Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 84);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 1;
            label4.Text = "Product Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 148);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 2;
            label5.Text = "Product Observation";
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(27, 46);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(125, 27);
            TxtProductId.TabIndex = 3;
            TxtProductId.Text = "Product id";
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(26, 107);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "Product name";
            TxtProductName.Size = new Size(271, 27);
            TxtProductName.TabIndex = 4;
            // 
            // TxtProductObservation
            // 
            TxtProductObservation.Location = new Point(26, 171);
            TxtProductObservation.Multiline = true;
            TxtProductObservation.Name = "TxtProductObservation";
            TxtProductObservation.PlaceholderText = "Product observation";
            TxtProductObservation.Size = new Size(394, 51);
            TxtProductObservation.TabIndex = 5;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(71, 240);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 44);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(245, 240);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 44);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Products Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductsList.ResumeLayout(false);
            tabPageProductsList.PerformLayout();
            tabPageProductsDetail.ResumeLayout(false);
            tabPageProductsDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageProductsList;
        private TabPage tabPageProductsDetail;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnSearch;
        private DataGridView dataGridView1;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label label3;
        private TextBox TxtProductObservation;
        private TextBox TxtProductName;
        private TextBox TxtProductId;
        private Label label5;
        private Label label4;
        private Button BtnCancel;
        private Button BtnSave;
    }
}