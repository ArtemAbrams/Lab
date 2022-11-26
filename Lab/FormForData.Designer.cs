namespace Lab
{
    partial class formForData
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
            this.labelInformation = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.PublishingHouseIdBox = new System.Windows.Forms.TextBox();
            this.PublishingHouseIdLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelInformation.Location = new System.Drawing.Point(14, 11);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(0, 25);
            this.labelInformation.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 670F));
            this.tableLayoutPanel1.Controls.Add(this.AdressBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.NameBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.IdBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TitleBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PublishingHouseIdBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PublishingHouseIdLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.IdLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AdressLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TitleLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 104);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 192);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // AdressBox
            // 
            this.AdressBox.Location = new System.Drawing.Point(181, 154);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(664, 29);
            this.AdressBox.TabIndex = 16;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(181, 116);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(664, 29);
            this.NameBox.TabIndex = 15;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(181, 78);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(664, 29);
            this.IdBox.TabIndex = 14;
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(181, 42);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(664, 29);
            this.TitleBox.TabIndex = 13;
            // 
            // PublishingHouseIdBox
            // 
            this.PublishingHouseIdBox.Location = new System.Drawing.Point(181, 3);
            this.PublishingHouseIdBox.Name = "PublishingHouseIdBox";
            this.PublishingHouseIdBox.Size = new System.Drawing.Size(664, 29);
            this.PublishingHouseIdBox.TabIndex = 12;
            // 
            // PublishingHouseIdLabel
            // 
            this.PublishingHouseIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PublishingHouseIdLabel.AutoSize = true;
            this.PublishingHouseIdLabel.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PublishingHouseIdLabel.Location = new System.Drawing.Point(28, 7);
            this.PublishingHouseIdLabel.Name = "PublishingHouseIdLabel";
            this.PublishingHouseIdLabel.Size = new System.Drawing.Size(147, 24);
            this.PublishingHouseIdLabel.TabIndex = 0;
            this.PublishingHouseIdLabel.Text = "PublishingHouseId";
            this.PublishingHouseIdLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(150, 82);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(25, 24);
            this.IdLabel.TabIndex = 4;
            this.IdLabel.Text = "Id";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(123, 120);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 24);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // AdressLabel
            // 
            this.AdressLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdressLabel.Location = new System.Drawing.Point(117, 159);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(58, 24);
            this.AdressLabel.TabIndex = 3;
            this.AdressLabel.Text = "Adress";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(131, 45);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(44, 24);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Maroon;
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConfirmButton.Location = new System.Drawing.Point(206, 408);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(457, 78);
            this.ConfirmButton.TabIndex = 12;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // formForData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelInformation);
            this.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formForData";
            this.Text = "formForData";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInformation;
        private TableLayoutPanel tableLayoutPanel1;
        private Label PublishingHouseIdLabel;
        private Label TitleLabel;
        private Label IdLabel;
        private Label NameLabel;
        private Label AdressLabel;
        protected TextBox AdressBox;
        protected TextBox NameBox;
        protected TextBox IdBox;
        protected TextBox TitleBox;
        protected TextBox PublishingHouseIdBox;
        protected Button ConfirmButton;
    }
}