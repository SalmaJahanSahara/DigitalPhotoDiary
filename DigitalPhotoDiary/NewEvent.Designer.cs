
namespace DigitalPhotoDiary
{
    partial class NewEvent
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
            this.backNewEventButton = new System.Windows.Forms.Button();
            this.createEventButton = new System.Windows.Forms.Button();
            this.newEventTextBox = new System.Windows.Forms.TextBox();
            this.createEvent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createEventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // backNewEventButton
            // 
            this.backNewEventButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backNewEventButton.Location = new System.Drawing.Point(17, 171);
            this.backNewEventButton.Name = "backNewEventButton";
            this.backNewEventButton.Size = new System.Drawing.Size(216, 32);
            this.backNewEventButton.TabIndex = 31;
            this.backNewEventButton.Text = "Back";
            this.backNewEventButton.UseVisualStyleBackColor = true;
            this.backNewEventButton.Click += new System.EventHandler(this.backNewEventButton_Click);
            // 
            // createEventButton
            // 
            this.createEventButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEventButton.Location = new System.Drawing.Point(239, 171);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(255, 32);
            this.createEventButton.TabIndex = 30;
            this.createEventButton.Text = "Create Event";
            this.createEventButton.UseVisualStyleBackColor = true;
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // newEventTextBox
            // 
            this.newEventTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEventTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.newEventTextBox.Location = new System.Drawing.Point(239, 125);
            this.newEventTextBox.Name = "newEventTextBox";
            this.newEventTextBox.Size = new System.Drawing.Size(255, 29);
            this.newEventTextBox.TabIndex = 29;
            // 
            // createEvent
            // 
            this.createEvent.AutoSize = true;
            this.createEvent.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEvent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createEvent.Location = new System.Drawing.Point(12, 129);
            this.createEvent.Name = "createEvent";
            this.createEvent.Size = new System.Drawing.Size(221, 25);
            this.createEvent.TabIndex = 32;
            this.createEvent.Text = "Enter your event name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(116, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 39);
            this.label1.TabIndex = 33;
            this.label1.Text = "Digital Photo Diary";
            // 
            // createEventDateTimePicker
            // 
            this.createEventDateTimePicker.Location = new System.Drawing.Point(368, 171);
            this.createEventDateTimePicker.Name = "createEventDateTimePicker";
            this.createEventDateTimePicker.Size = new System.Drawing.Size(10, 22);
            this.createEventDateTimePicker.TabIndex = 34;
            // 
            // NewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createEvent);
            this.Controls.Add(this.backNewEventButton);
            this.Controls.Add(this.createEventButton);
            this.Controls.Add(this.newEventTextBox);
            this.Controls.Add(this.createEventDateTimePicker);
            this.Name = "NewEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewEvent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewEvent_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button backNewEventButton;
        private System.Windows.Forms.Button createEventButton;
        private System.Windows.Forms.TextBox newEventTextBox;
        private System.Windows.Forms.Label createEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker createEventDateTimePicker;
    }
}