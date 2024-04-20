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
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            BtnNew = new Button();
            DgCategorie = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategoriaDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCategorieObservation = new TextBox();
            TxtCategorieName = new TextBox();
            TxtCategorieId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoriesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategorie).BeginInit();
            tabPageCategoriaDetail.SuspendLayout();
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
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(607, 136);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(127, 41);
            BtnEdit.TabIndex = 7;
            BtnEdit.UseVisualStyleBackColor = true;
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
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(607, 234);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(127, 41);
            BtnClose.TabIndex = 5;
            BtnClose.UseVisualStyleBackColor = true;
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
            // DgCategorie
            // 
            DgCategorie.AllowUserToAddRows = false;
            DgCategorie.AllowUserToDeleteRows = false;
            DgCategorie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategorie.Location = new Point(25, 87);
            DgCategorie.Name = "DgCategorie";
            DgCategorie.ReadOnly = true;
            DgCategorie.RowHeadersWidth = 51;
            DgCategorie.Size = new Size(512, 188);
            DgCategorie.TabIndex = 3;
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
            // TxtSearch
            // 
            TxtSearch.Location = new Point(22, 44);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(399, 27);
            TxtSearch.TabIndex = 1;
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
            // tabPageCategoriaDetail
            // 
            tabPageCategoriaDetail.Controls.Add(BtnCancel);
            tabPageCategoriaDetail.Controls.Add(BtnSave);
            tabPageCategoriaDetail.Controls.Add(TxtCategorieObservation);
            tabPageCategoriaDetail.Controls.Add(TxtCategorieName);
            tabPageCategoriaDetail.Controls.Add(TxtCategorieId);
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
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(254, 238);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 46);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
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
            // TxtCategorieObservation
            // 
            TxtCategorieObservation.Location = new Point(25, 164);
            TxtCategorieObservation.Multiline = true;
            TxtCategorieObservation.Name = "TxtCategorieObservation";
            TxtCategorieObservation.PlaceholderText = "Categorie observation";
            TxtCategorieObservation.Size = new Size(401, 59);
            TxtCategorieObservation.TabIndex = 5;
            // 
            // TxtCategorieName
            // 
            TxtCategorieName.Location = new Point(25, 103);
            TxtCategorieName.Name = "TxtCategorieName";
            TxtCategorieName.PlaceholderText = "Categorie name";
            TxtCategorieName.Size = new Size(265, 27);
            TxtCategorieName.TabIndex = 4;
            // 
            // TxtCategorieId
            // 
            TxtCategorieId.Location = new Point(28, 43);
            TxtCategorieId.Name = "TxtCategorieId";
            TxtCategorieId.Size = new Size(158, 27);
            TxtCategorieId.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)DgCategorie).EndInit();
            tabPageCategoriaDetail.ResumeLayout(false);
            tabPageCategoriaDetail.PerformLayout();
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
        private TextBox TxtCategorieObservation;
        private TextBox TxtCategorieName;
        private TextBox TxtCategorieId;
        private Button BtnCancel;
        private Button BtnSave;
    }
}