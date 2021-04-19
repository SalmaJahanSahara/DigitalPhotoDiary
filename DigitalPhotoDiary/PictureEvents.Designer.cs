
namespace DigitalPhotoDiary
{
    partial class PictureEvents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureEventsListView = new System.Windows.Forms.ListView();
            this.eventNamePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureListLabel = new System.Windows.Forms.Label();
            this.backExixtingEventButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.importanceLabel = new System.Windows.Forms.Label();
            this.modifiedDateLabel = new System.Windows.Forms.Label();
            this.createdDateLabel = new System.Windows.Forms.Label();
            this.pictureStoryLabel = new System.Windows.Forms.Label();
            this.dPDLabel = new System.Windows.Forms.Label();
            this.peImportanceLabel = new System.Windows.Forms.Label();
            this.peCreatedDateLabel = new System.Windows.Forms.Label();
            this.peModifiedDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventNamePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureEventsListView
            // 
            this.pictureEventsListView.HideSelection = false;
            this.pictureEventsListView.Location = new System.Drawing.Point(32, 46);
            this.pictureEventsListView.Name = "pictureEventsListView";
            this.pictureEventsListView.Size = new System.Drawing.Size(949, 104);
            this.pictureEventsListView.TabIndex = 1;
            this.pictureEventsListView.UseCompatibleStateImageBehavior = false;
            this.pictureEventsListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.pictureEventsListView_ItemSelectionChanged);
            this.pictureEventsListView.SelectedIndexChanged += new System.EventHandler(this.pictureEventsListView_SelectedIndexChanged);
            // 
            // eventNamePictureBox
            // 
            this.eventNamePictureBox.Location = new System.Drawing.Point(282, 191);
            this.eventNamePictureBox.Name = "eventNamePictureBox";
            this.eventNamePictureBox.Size = new System.Drawing.Size(454, 279);
            this.eventNamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eventNamePictureBox.TabIndex = 2;
            this.eventNamePictureBox.TabStop = false;
            // 
            // pictureListLabel
            // 
            this.pictureListLabel.AutoSize = true;
            this.pictureListLabel.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureListLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureListLabel.Location = new System.Drawing.Point(789, 153);
            this.pictureListLabel.Name = "pictureListLabel";
            this.pictureListLabel.Size = new System.Drawing.Size(192, 27);
            this.pictureListLabel.TabIndex = 3;
            this.pictureListLabel.Text = "List of Pictures";
            // 
            // backExixtingEventButton
            // 
            this.backExixtingEventButton.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backExixtingEventButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backExixtingEventButton.Location = new System.Drawing.Point(863, 7);
            this.backExixtingEventButton.Name = "backExixtingEventButton";
            this.backExixtingEventButton.Size = new System.Drawing.Size(118, 32);
            this.backExixtingEventButton.TabIndex = 39;
            this.backExixtingEventButton.Text = "Back";
            this.backExixtingEventButton.UseVisualStyleBackColor = true;
            this.backExixtingEventButton.Click += new System.EventHandler(this.backExixtingEventButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modifyButton.Location = new System.Drawing.Point(763, 361);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(113, 30);
            this.modifyButton.TabIndex = 42;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.eventNameLabel.Location = new System.Drawing.Point(27, 9);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(155, 27);
            this.eventNameLabel.TabIndex = 43;
            this.eventNameLabel.Text = "Event Name";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addButton.Location = new System.Drawing.Point(763, 241);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(113, 30);
            this.addButton.TabIndex = 49;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.removeButton.Location = new System.Drawing.Point(763, 303);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(113, 30);
            this.removeButton.TabIndex = 50;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // importanceLabel
            // 
            this.importanceLabel.AutoSize = true;
            this.importanceLabel.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importanceLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.importanceLabel.Location = new System.Drawing.Point(28, 191);
            this.importanceLabel.Name = "importanceLabel";
            this.importanceLabel.Size = new System.Drawing.Size(131, 23);
            this.importanceLabel.TabIndex = 54;
            this.importanceLabel.Text = "Importance";
            // 
            // modifiedDateLabel
            // 
            this.modifiedDateLabel.AutoSize = true;
            this.modifiedDateLabel.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifiedDateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modifiedDateLabel.Location = new System.Drawing.Point(28, 387);
            this.modifiedDateLabel.Name = "modifiedDateLabel";
            this.modifiedDateLabel.Size = new System.Drawing.Size(159, 23);
            this.modifiedDateLabel.TabIndex = 55;
            this.modifiedDateLabel.Text = "Modified Date";
            // 
            // createdDateLabel
            // 
            this.createdDateLabel.AutoSize = true;
            this.createdDateLabel.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdDateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createdDateLabel.Location = new System.Drawing.Point(28, 294);
            this.createdDateLabel.Name = "createdDateLabel";
            this.createdDateLabel.Size = new System.Drawing.Size(147, 23);
            this.createdDateLabel.TabIndex = 56;
            this.createdDateLabel.Text = "Created Date";
            // 
            // pictureStoryLabel
            // 
            this.pictureStoryLabel.AutoSize = true;
            this.pictureStoryLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureStoryLabel.ForeColor = System.Drawing.Color.DimGray;
            this.pictureStoryLabel.Location = new System.Drawing.Point(276, 483);
            this.pictureStoryLabel.Name = "pictureStoryLabel";
            this.pictureStoryLabel.Size = new System.Drawing.Size(200, 31);
            this.pictureStoryLabel.TabIndex = 57;
            this.pictureStoryLabel.Text = "Picture Story";
            // 
            // dPDLabel
            // 
            this.dPDLabel.AutoSize = true;
            this.dPDLabel.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dPDLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dPDLabel.Location = new System.Drawing.Point(722, 520);
            this.dPDLabel.Name = "dPDLabel";
            this.dPDLabel.Size = new System.Drawing.Size(283, 39);
            this.dPDLabel.TabIndex = 58;
            this.dPDLabel.Text = "Digital Photo Diary";
            // 
            // peImportanceLabel
            // 
            this.peImportanceLabel.AutoSize = true;
            this.peImportanceLabel.Font = new System.Drawing.Font("Lucida Bright", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peImportanceLabel.Location = new System.Drawing.Point(28, 230);
            this.peImportanceLabel.Name = "peImportanceLabel";
            this.peImportanceLabel.Size = new System.Drawing.Size(101, 19);
            this.peImportanceLabel.TabIndex = 59;
            this.peImportanceLabel.Text = "Imporance";
            // 
            // peCreatedDateLabel
            // 
            this.peCreatedDateLabel.AutoSize = true;
            this.peCreatedDateLabel.Font = new System.Drawing.Font("Lucida Bright", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peCreatedDateLabel.Location = new System.Drawing.Point(28, 330);
            this.peCreatedDateLabel.Name = "peCreatedDateLabel";
            this.peCreatedDateLabel.Size = new System.Drawing.Size(121, 19);
            this.peCreatedDateLabel.TabIndex = 60;
            this.peCreatedDateLabel.Text = "Created Date";
            // 
            // peModifiedDateLabel
            // 
            this.peModifiedDateLabel.AutoSize = true;
            this.peModifiedDateLabel.Font = new System.Drawing.Font("Lucida Bright", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peModifiedDateLabel.Location = new System.Drawing.Point(28, 422);
            this.peModifiedDateLabel.Name = "peModifiedDateLabel";
            this.peModifiedDateLabel.Size = new System.Drawing.Size(128, 19);
            this.peModifiedDateLabel.TabIndex = 61;
            this.peModifiedDateLabel.Text = "Modified Date";
            // 
            // PictureEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 568);
            this.Controls.Add(this.peModifiedDateLabel);
            this.Controls.Add(this.peCreatedDateLabel);
            this.Controls.Add(this.peImportanceLabel);
            this.Controls.Add(this.dPDLabel);
            this.Controls.Add(this.pictureStoryLabel);
            this.Controls.Add(this.createdDateLabel);
            this.Controls.Add(this.modifiedDateLabel);
            this.Controls.Add(this.importanceLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.eventNameLabel);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.backExixtingEventButton);
            this.Controls.Add(this.pictureListLabel);
            this.Controls.Add(this.eventNamePictureBox);
            this.Controls.Add(this.pictureEventsListView);
            this.Name = "PictureEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureEvents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PictureEvents_FormClosing);
            this.Load += new System.EventHandler(this.PictureEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventNamePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ListView pictureEventsListView;
        public System.Windows.Forms.PictureBox eventNamePictureBox;
        public System.Windows.Forms.Label pictureListLabel;
        public System.Windows.Forms.Button backExixtingEventButton;
        public System.Windows.Forms.Button modifyButton;
        public System.Windows.Forms.Label eventNameLabel;
        public System.Windows.Forms.Button addButton;
        public System.Windows.Forms.Button removeButton;
        public System.Windows.Forms.Label importanceLabel;
        public System.Windows.Forms.Label modifiedDateLabel;
        public System.Windows.Forms.Label createdDateLabel;
        public System.Windows.Forms.Label pictureStoryLabel;
        public System.Windows.Forms.Label dPDLabel;
        public System.Windows.Forms.Label peImportanceLabel;
        public System.Windows.Forms.Label peCreatedDateLabel;
        public System.Windows.Forms.Label peModifiedDateLabel;
    }
}
