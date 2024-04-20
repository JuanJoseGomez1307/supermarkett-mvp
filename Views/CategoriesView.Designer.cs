namespace supermarkett_mvp.Views
{
    partial class CategoriesView
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCategoriesList = new TabPage();
            tabPageCategoriaDetail = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            DgCategorie = new DataGridView();
            BtnNew = new Button();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoriesList.SuspendLayout();
            tabPageCategoriaDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategorie).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.categories;
            pictureBox1.Location = new Point(29, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 31);
            label1.Name = "label1";
            label1.Size = new Size(224, 54);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoriesList);
            tabControl1.Controls.Add(tabPageCategoriaDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 325);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategoriesList
            // 
            tabPageCategoriesList.Controls.Add(BtnEdit);
            tabPageCategoriesList.Controls.Add(BtnDelete);
            tabPageCategoriesList.Controls.Add(BtnClose);
            tabPageCategoriesList.Controls.Add(BtnNew);
            tabPageCategoriesList.Controls.Add(DgCategorie);
            tabPageCategoriesList.Controls.Add(BtnSearch);
            tabPageCategoriesList.Controls.Add(TxtSearch);
            tabPageCategoriesList.Controls.Add(label2);
            tabPageCategoriesList.Location = new Point(4, 29);
            tabPageCategoriesList.Name = "tabPageCategoriesList";
            tabPageCategoriesList.Padding = new Padding(3);
            tabPageCategoriesList.Size = new Size(792, 292);
            tabPageCategoriesList.TabIndex = 0;
            tabPageCategoriesList.Text = "Categorie List";
            tabPageCategoriesList.UseVisualStyleBackColor = true;
            // 
            // tabPageCategoriaDetail
            // 
            tabPageCategoriaDetail.Controls.Add(BtnCancel);
            tabPageCategoriaDetail.Controls.Add(BtnSave);
            tabPageCategoriaDetail.Controls.Add(textBox3);
            tabPageCategoriaDetail.Controls.Add(textBox2);
            tabPageCategoriaDetail.Controls.Add(textBox1);
            tabPageCategoriaDetail.Controls.Add(label5);
            tabPageCategoriaDetail.Controls.Add(label4);
            tabPageCategoriaDetail.Controls.Add(label3);
            tabPageCategoriaDetail.Location = new Point(4, 29);
            tabPageCategoriaDetail.Name = "tabPageCategoriaDetail";
            tabPageCategoriaDetail.Padding = new Padding(3);
            tabPageCategoriaDetail.Size = new Size(792, 292);
            tabPageCategoriaDetail.TabIndex = 1;
            tabPageCategoriaDetail.Text = "Categorie Detail";
            tabPageCategoriaDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 14);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Categorie";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(22, 44);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(399, 27);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(453, 37);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(84, 41);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgCategorie
            // 
            DgCategorie.AllowUserToAddRows = false;
            DgCategorie.AllowUserToDeleteRows = false;
            DgCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategorie.Location = new Point(25, 87);
            DgCategorie.Name = "DgCategorie";
            DgCategorie.ReadOnly = true;
            DgCategorie.RowHeadersWidth = 51;
            DgCategorie.Size = new Size(512, 188);
            DgCategorie.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(607, 87);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(127, 41);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(607, 234);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(127, 41);
            BtnClose.TabIndex = 5;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(607, 185);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(127, 41);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(607, 136);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(127, 41);
            BtnEdit.TabIndex = 7;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 14);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 0;
            label3.Text = "Categorie id ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 80);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 1;
            label4.Text = "Categorie name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 141);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 2;
            label5.Text = "Categorie observation";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 103);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Categorie name";
            textBox2.Size = new Size(265, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(25, 164);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Categorie observation";
            textBox3.Size = new Size(401, 59);
            textBox3.TabIndex = 5;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(85, 238);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 46);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(254, 238);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 46);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "Categories Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategoriesList.ResumeLayout(false);
            tabPageCategoriesList.PerformLayout();
            tabPageCategoriaDetail.ResumeLayout(false);
            tabPageCategoriaDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategorie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageCategoriesList;
        private TabPage tabPageCategoriaDetail;
        private Label label2;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private DataGridView DgCategorie;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnClose;
        private Button BtnNew;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button BtnCancel;
        private Button BtnSave;
    }
}