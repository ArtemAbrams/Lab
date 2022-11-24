namespace Lab
{
    partial class SearchForm
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
            this.Edit = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonPreviously = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SeacrhButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Maroon;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Edit.Location = new System.Drawing.Point(66, 430);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(752, 57);
            this.Edit.TabIndex = 6;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Maroon;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteButton.Location = new System.Drawing.Point(66, 493);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(752, 57);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(484, 58);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 125;
            this.dataGridView.RowTemplate.Height = 65;
            this.dataGridView.Size = new System.Drawing.Size(484, 339);
            this.dataGridView.TabIndex = 8;
            // 
            // buttonPreviously
            // 
            this.buttonPreviously.BackColor = System.Drawing.Color.Teal;
            this.buttonPreviously.Location = new System.Drawing.Point(534, 12);
            this.buttonPreviously.Name = "buttonPreviously";
            this.buttonPreviously.Size = new System.Drawing.Size(91, 40);
            this.buttonPreviously.TabIndex = 9;
            this.buttonPreviously.Text = "Previously";
            this.buttonPreviously.UseVisualStyleBackColor = false;
            this.buttonPreviously.Click += new System.EventHandler(this.buttonPreviously_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Teal;
            this.buttonNext.Location = new System.Drawing.Point(785, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(91, 40);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // SeacrhButton
            // 
            this.SeacrhButton.BackColor = System.Drawing.Color.Maroon;
            this.SeacrhButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeacrhButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SeacrhButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SeacrhButton.Location = new System.Drawing.Point(48, 231);
            this.SeacrhButton.Name = "SeacrhButton";
            this.SeacrhButton.Size = new System.Drawing.Size(179, 57);
            this.SeacrhButton.TabIndex = 11;
            this.SeacrhButton.Text = "Search";
            this.SeacrhButton.UseVisualStyleBackColor = false;
            this.SeacrhButton.Click += new System.EventHandler(this.SeacrhButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Typing the value to find the the house ";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdressLabel.Location = new System.Drawing.Point(8, 172);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(63, 23);
            this.AdressLabel.TabIndex = 13;
            this.AdressLabel.Text = "Adress";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(8, 121);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(25, 23);
            this.IdLabel.TabIndex = 14;
            this.IdLabel.Text = "Id";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(8, 72);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(51, 23);
            this.TitleLabel.TabIndex = 15;
            this.TitleLabel.Text = "Title";
            // 
            // AdressBox
            // 
            this.AdressBox.Location = new System.Drawing.Point(77, 168);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(256, 27);
            this.AdressBox.TabIndex = 16;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(76, 117);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(257, 27);
            this.IdBox.TabIndex = 17;
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(76, 68);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(257, 27);
            this.TitleBox.TabIndex = 18;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 553);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.AdressBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeacrhButton);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPreviously);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Edit);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Edit;
        private Button DeleteButton;
        private DataGridView dataGridView;
        private Button buttonPreviously;
        private Button buttonNext;
        private Button SeacrhButton;
        private Label label1;
        private Label AdressLabel;
        private Label IdLabel;
        private Label TitleLabel;
        private TextBox AdressBox;
        private TextBox IdBox;
        private TextBox TitleBox;
    }
}