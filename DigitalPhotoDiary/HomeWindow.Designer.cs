
namespace DigitalPhotoDiary
{
    partial class HomeWindow
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
            this.backHomePageButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.youWantToCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backHomePageButton
            // 
            this.backHomePageButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backHomePageButton.Location = new System.Drawing.Point(359, 225);
            this.backHomePageButton.Name = "backHomePageButton";
            this.backHomePageButton.Size = new System.Drawing.Size(125, 35);
            this.backHomePageButton.TabIndex = 29;
            this.backHomePageButton.Text = "Back";
            this.backHomePageButton.UseVisualStyleBackColor = true;
            this.backHomePageButton.Click += new System.EventHandler(this.backHomePageButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youWantToCreateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 30);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // youWantToCreateToolStripMenuItem
            // 
            this.youWantToCreateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEventToolStripMenuItem,
            this.existingEventToolStripMenuItem});
            this.youWantToCreateToolStripMenuItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youWantToCreateToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.youWantToCreateToolStripMenuItem.Name = "youWantToCreateToolStripMenuItem";
            this.youWantToCreateToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.youWantToCreateToolStripMenuItem.Text = "You want to ";
            // 
            // createEventToolStripMenuItem
            // 
            this.createEventToolStripMenuItem.Name = "createEventToolStripMenuItem";
            this.createEventToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.createEventToolStripMenuItem.Text = "Create an event";
            this.createEventToolStripMenuItem.Click += new System.EventHandler(this.createEventToolStripMenuItem_Click);
            // 
            // existingEventToolStripMenuItem
            // 
            this.existingEventToolStripMenuItem.Name = "existingEventToolStripMenuItem";
            this.existingEventToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.existingEventToolStripMenuItem.Text = "Open an existing event";
            this.existingEventToolStripMenuItem.Click += new System.EventHandler(this.existingEventToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(29, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "Digital Photo Diary";
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backHomePageButton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button backHomePageButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem youWantToCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existingEventToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}