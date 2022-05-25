namespace KC_20_Gimalova_project_manager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.btnTasks);
            this.panelMenu.Controls.Add(this.btnProjects);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 636);
            this.panelMenu.TabIndex = 0;
            // 
            // btnTasks
            // 
            this.btnTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTasks.FlatAppearance.BorderSize = 0;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnTasks.Image")));
            this.btnTasks.Location = new System.Drawing.Point(0, 172);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(267, 72);
            this.btnTasks.TabIndex = 4;
            this.btnTasks.Text = " Задачи";
            this.btnTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjects.FlatAppearance.BorderSize = 0;
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjects.Image = ((System.Drawing.Image)(resources.GetObject("btnProjects.Image")));
            this.btnProjects.Location = new System.Drawing.Point(0, 100);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(267, 72);
            this.btnProjects.TabIndex = 3;
            this.btnProjects.Text = " Проекты";
            this.btnProjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(33)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(267, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vizion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(33)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(267, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(895, 64);
            this.panelTitleBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(388, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Домашняя страница";
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(10, 7);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(58, 47);
            this.btnCloseChildForm.TabIndex = 0;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // desktopPanel
            // 
            this.desktopPanel.BackColor = System.Drawing.Color.Transparent;
            this.desktopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(267, 64);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(895, 572);
            this.desktopPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 636);
            this.Controls.Add(this.desktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel desktopPanel;
    }
}

