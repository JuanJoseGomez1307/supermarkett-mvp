namespace supermarkett_mvp.Views
{
    partial class MainView
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
            BtnProviders = new Button();
            BtnExit = new Button();
            pictureBox1 = new PictureBox();
            BtnPayMode = new Button();
            BtnProducts = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnProducts);
            panel1.Controls.Add(BtnProviders);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BtnPayMode);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 612);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BtnProviders
            // 
            BtnProviders.BackgroundImage = Properties.Resources.providers;
            BtnProviders.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProviders.Location = new Point(3, 286);
            BtnProviders.Name = "BtnProviders";
            BtnProviders.Size = new Size(244, 114);
            BtnProviders.TabIndex = 4;
            BtnProviders.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.salida;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 510);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(250, 102);
            BtnExit.TabIndex = 3;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(0, 68);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(247, 102);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // BtnProducts
            // 
            BtnProducts.BackgroundImage = Properties.Resources.products;
            BtnProducts.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProducts.Location = new Point(3, 176);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(244, 104);
            BtnProducts.TabIndex = 5;
            BtnProducts.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 612);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnProviders;
        private Button BtnProducts;
    }
}