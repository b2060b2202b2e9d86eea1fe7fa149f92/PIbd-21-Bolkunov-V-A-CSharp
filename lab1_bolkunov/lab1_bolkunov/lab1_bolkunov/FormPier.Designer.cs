﻿namespace lab1_bolkunov
{
    partial class FormPier
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
			this.parkShipButton = new System.Windows.Forms.Button();
			this.pierPictureBox = new System.Windows.Forms.PictureBox();
			this.parkMotorShipButton = new System.Windows.Forms.Button();
			this.takeShipGroupBox = new System.Windows.Forms.GroupBox();
			this.takeShipButton = new System.Windows.Forms.Button();
			this.parkingPlaceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.placeLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pierNameTextBox = new System.Windows.Forms.TextBox();
			this.addPierButton = new System.Windows.Forms.Button();
			this.piersListBox = new System.Windows.Forms.ListBox();
			this.removePierButton = new System.Windows.Forms.Button();
			this.createShipButton = new System.Windows.Forms.Button();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pierPictureBox)).BeginInit();
			this.takeShipGroupBox.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// parkShipButton
			// 
			this.parkShipButton.Location = new System.Drawing.Point(1131, 564);
			this.parkShipButton.Name = "parkShipButton";
			this.parkShipButton.Size = new System.Drawing.Size(141, 23);
			this.parkShipButton.TabIndex = 2;
			this.parkShipButton.Text = "Припарковать корабль";
			this.parkShipButton.UseVisualStyleBackColor = true;
			this.parkShipButton.Visible = false;
			this.parkShipButton.Click += new System.EventHandler(this.ParkShipButton_Click);
			// 
			// pierPictureBox
			// 
			this.pierPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.pierPictureBox.Location = new System.Drawing.Point(0, 27);
			this.pierPictureBox.Name = "pierPictureBox";
			this.pierPictureBox.Size = new System.Drawing.Size(1113, 734);
			this.pierPictureBox.TabIndex = 1;
			this.pierPictureBox.TabStop = false;
			// 
			// parkMotorShipButton
			// 
			this.parkMotorShipButton.Location = new System.Drawing.Point(1131, 593);
			this.parkMotorShipButton.Name = "parkMotorShipButton";
			this.parkMotorShipButton.Size = new System.Drawing.Size(141, 23);
			this.parkMotorShipButton.TabIndex = 3;
			this.parkMotorShipButton.Text = "Припарковать теплоход";
			this.parkMotorShipButton.UseVisualStyleBackColor = true;
			this.parkMotorShipButton.Visible = false;
			this.parkMotorShipButton.Click += new System.EventHandler(this.ParkMotorShipButton_Click);
			// 
			// takeShipGroupBox
			// 
			this.takeShipGroupBox.Controls.Add(this.takeShipButton);
			this.takeShipGroupBox.Controls.Add(this.parkingPlaceMaskedTextBox);
			this.takeShipGroupBox.Controls.Add(this.placeLabel);
			this.takeShipGroupBox.Location = new System.Drawing.Point(1131, 660);
			this.takeShipGroupBox.Name = "takeShipGroupBox";
			this.takeShipGroupBox.Size = new System.Drawing.Size(141, 91);
			this.takeShipGroupBox.TabIndex = 4;
			this.takeShipGroupBox.TabStop = false;
			this.takeShipGroupBox.Text = "Забрать корабль";
			// 
			// takeShipButton
			// 
			this.takeShipButton.Location = new System.Drawing.Point(34, 51);
			this.takeShipButton.Name = "takeShipButton";
			this.takeShipButton.Size = new System.Drawing.Size(75, 23);
			this.takeShipButton.TabIndex = 5;
			this.takeShipButton.Text = "Забрать";
			this.takeShipButton.UseVisualStyleBackColor = true;
			this.takeShipButton.Click += new System.EventHandler(this.TakeShipButton_Click);
			// 
			// parkingPlaceMaskedTextBox
			// 
			this.parkingPlaceMaskedTextBox.Location = new System.Drawing.Point(79, 25);
			this.parkingPlaceMaskedTextBox.Mask = "00";
			this.parkingPlaceMaskedTextBox.Name = "parkingPlaceMaskedTextBox";
			this.parkingPlaceMaskedTextBox.Size = new System.Drawing.Size(29, 20);
			this.parkingPlaceMaskedTextBox.TabIndex = 1;
			this.parkingPlaceMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.parkingPlaceMaskedTextBox.ValidatingType = typeof(System.DateTime);
			// 
			// placeLabel
			// 
			this.placeLabel.AutoSize = true;
			this.placeLabel.Location = new System.Drawing.Point(31, 28);
			this.placeLabel.Name = "placeLabel";
			this.placeLabel.Size = new System.Drawing.Size(42, 13);
			this.placeLabel.TabIndex = 0;
			this.placeLabel.Text = "Место:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1173, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Пристани:";
			// 
			// pierNameTextBox
			// 
			this.pierNameTextBox.Location = new System.Drawing.Point(1131, 44);
			this.pierNameTextBox.Name = "pierNameTextBox";
			this.pierNameTextBox.Size = new System.Drawing.Size(141, 20);
			this.pierNameTextBox.TabIndex = 6;
			this.pierNameTextBox.TextChanged += new System.EventHandler(this.pierNameTextBox_TextChanged);
			// 
			// addPierButton
			// 
			this.addPierButton.Location = new System.Drawing.Point(1131, 70);
			this.addPierButton.Name = "addPierButton";
			this.addPierButton.Size = new System.Drawing.Size(141, 23);
			this.addPierButton.TabIndex = 7;
			this.addPierButton.Text = "Добавить пристань";
			this.addPierButton.UseVisualStyleBackColor = true;
			this.addPierButton.Click += new System.EventHandler(this.AddPierButton_Click);
			// 
			// piersListBox
			// 
			this.piersListBox.FormattingEnabled = true;
			this.piersListBox.Location = new System.Drawing.Point(1131, 99);
			this.piersListBox.Name = "piersListBox";
			this.piersListBox.Size = new System.Drawing.Size(141, 134);
			this.piersListBox.TabIndex = 8;
			this.piersListBox.SelectedIndexChanged += new System.EventHandler(this.PiersListBox_SelectedIndexChanged);
			// 
			// removePierButton
			// 
			this.removePierButton.Location = new System.Drawing.Point(1131, 239);
			this.removePierButton.Name = "removePierButton";
			this.removePierButton.Size = new System.Drawing.Size(141, 23);
			this.removePierButton.TabIndex = 9;
			this.removePierButton.Text = "Удалить пристань";
			this.removePierButton.UseVisualStyleBackColor = true;
			this.removePierButton.Click += new System.EventHandler(this.RemovePierButton_Click);
			// 
			// createShipButton
			// 
			this.createShipButton.Location = new System.Drawing.Point(1131, 622);
			this.createShipButton.Name = "createShipButton";
			this.createShipButton.Size = new System.Drawing.Size(141, 35);
			this.createShipButton.TabIndex = 10;
			this.createShipButton.Text = "Создать корабль";
			this.createShipButton.UseVisualStyleBackColor = true;
			this.createShipButton.Click += new System.EventHandler(this.createShipButton_Click);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1284, 24);
			this.menuStrip.TabIndex = 11;
			this.menuStrip.Text = "menuStrip1";
			// 
			// loadFileDialog
			// 
			this.loadFileDialog.FileName = "loadFileDialog";
			this.loadFileDialog.Filter = "txt file | *.txt";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem.Text = "Сохранить";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.loadToolStripMenuItem.Text = "Загрузить";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "txt file | *.txt";
			// 
			// FormPier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1284, 761);
			this.Controls.Add(this.createShipButton);
			this.Controls.Add(this.removePierButton);
			this.Controls.Add(this.piersListBox);
			this.Controls.Add(this.addPierButton);
			this.Controls.Add(this.pierNameTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.takeShipGroupBox);
			this.Controls.Add(this.parkMotorShipButton);
			this.Controls.Add(this.parkShipButton);
			this.Controls.Add(this.pierPictureBox);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "FormPier";
			this.Text = "FormPier";
			((System.ComponentModel.ISupportInitialize)(this.pierPictureBox)).EndInit();
			this.takeShipGroupBox.ResumeLayout(false);
			this.takeShipGroupBox.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pierPictureBox;
        private System.Windows.Forms.Button parkShipButton;
        private System.Windows.Forms.Button parkMotorShipButton;
        private System.Windows.Forms.GroupBox takeShipGroupBox;
        private System.Windows.Forms.Button takeShipButton;
        private System.Windows.Forms.MaskedTextBox parkingPlaceMaskedTextBox;
        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pierNameTextBox;
        private System.Windows.Forms.Button addPierButton;
        private System.Windows.Forms.ListBox piersListBox;
        private System.Windows.Forms.Button removePierButton;
        private System.Windows.Forms.Button createShipButton;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.OpenFileDialog loadFileDialog;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}