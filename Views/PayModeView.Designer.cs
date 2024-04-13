namespace supermarkett_mvp.Views
{
    partial class PayModeView
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
            tabPagePayModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPagePayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            label5 = new Label();
            label4 = new Label();
            TxtPayModeObservation = new TextBox();
            TxtPayModeName = new TextBox();
            TxtPayModeId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
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
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(26, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 34);
            label1.Name = "label1";
            label1.Size = new Size(211, 54);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 325);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Location = new Point(4, 29);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(792, 292);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackColor = Color.LightGray;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(585, 237);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(168, 47);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackColor = Color.LightGray;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(585, 181);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(168, 50);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.BackColor = Color.LightGray;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(585, 126);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(168, 51);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.BackColor = Color.LightGray;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(585, 66);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(168, 54);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(23, 66);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.Size = new Size(518, 218);
            DgPayMode.TabIndex = 3;
            DgPayMode.CellContentClick += DgPayMode_CellContentClick;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.BackColor = Color.LightGray;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(459, 18);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(82, 42);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = false;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(23, 31);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(412, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 7);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(label5);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Location = new Point(4, 29);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(792, 292);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.LightGray;
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(155, 220);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 49);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.LightGray;
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(23, 220);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 49);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 131);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 5;
            label5.Text = "Pay Mode Observation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 67);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 4;
            label4.Text = "Pay Mode Name";
            label4.Click += label4_Click;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(23, 156);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(335, 58);
            TxtPayModeObservation.TabIndex = 3;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(23, 93);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(296, 27);
            TxtPayModeName.TabIndex = 2;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(23, 32);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(158, 27);
            TxtPayModeId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 6);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPagePayModeDetail;
        private Button BtnSearch;
        private DataGridView DgPayMode;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtPayModeObservation;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeId;
        private Label label3;
        private Label label5;
        private Label label4;
        private Button BtnCancel;
        private Button BtnSave;
    }
}