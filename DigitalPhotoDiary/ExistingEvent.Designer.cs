
namespace DigitalPhotoDiary
{
    partial class ExistingEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.existingEventComboBox = new System.Windows.Forms.ComboBox();
            this.selectEvent = new System.Windows.Forms.Label();
            this.backExixtingEventButton = new System.Windows.Forms.Button();
            this.existingEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "Digital Photo Diary";
            // 
            // existingEventComboBox
            // 
            this.existingEventComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingEventComboBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.existingEventComboBox.FormattingEnabled = true;
            this.existingEventComboBox.Location = new System.Drawing.Point(236, 89);
            this.existingEventComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.existingEventComboBox.Name = "existingEventComboBox";
            this.existingEventComboBox.Size = new System.Drawing.Size(288, 31);
            this.existingEventComboBox.TabIndex = 35;
            this.existingEventComboBox.SelectedIndexChanged += new System.EventHandler(this.existingEventComboBox_SelectedIndexChanged);
            // 
            // selectEvent
            // 
            this.selectEvent.AutoSize = true;
            this.selectEvent.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectEvent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectEvent.Location = new System.Drawing.Point(38, 91);
            this.selectEvent.Name = "selectEvent";
            this.selectEvent.Size = new System.Drawing.Size(152, 25);
            this.selectEvent.TabIndex = 36;
            this.selectEvent.Text = "Select an Event";
            // 
            // backExixtingEventButton
            // 
            this.backExixtingEventButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backExixtingEventButton.Location = new System.Drawing.Point(55, 495);
            this.backExixtingEventButton.Name = "backExixtingEventButton";
            this.backExixtingEventButton.Size = new System.Drawing.Size(216, 32);
            this.backExixtingEventButton.TabIndex = 38;
            this.backExixtingEventButton.Text = "Back";
            this.backExixtingEventButton.UseVisualStyleBackColor = true;
            this.backExixtingEventButton.Click += new System.EventHandler(this.backExixtingEventButton_Click);
            // 
            // existingEventButton
            // 
            this.existingEventButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingEventButton.Location = new System.Drawing.Point(277, 495);
            this.existingEventButton.Name = "existingEventButton";
            this.existingEventButton.Size = new System.Drawing.Size(255, 32);
            this.existingEventButton.TabIndex = 37;
            this.existingEventButton.Text = "Select Event";
            this.existingEventButton.UseVisualStyleBackColor = true;
            this.existingEventButton.Click += new System.EventHandler(this.existingEventButton_Click);
            // 
            // ExistingEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 562);
            this.Controls.Add(this.backExixtingEventButton);
            this.Controls.Add(this.existingEventButton);
            this.Controls.Add(this.selectEvent);
            this.Controls.Add(this.existingEventComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ExistingEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExistingEvent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExistingEvent_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox existingEventComboBox;
        private System.Windows.Forms.Label selectEvent;
        public System.Windows.Forms.Button backExixtingEventButton;
        private System.Windows.Forms.Button existingEventButton;
    }
}