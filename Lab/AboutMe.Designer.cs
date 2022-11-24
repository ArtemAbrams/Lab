using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

namespace Lab
{
    partial class AboutMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMe));
            this.labelWho = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWho
            // 
            this.labelWho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWho.AutoSize = true;
            this.labelWho.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelWho.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelWho.Location = new System.Drawing.Point(0, 0);
            this.labelWho.Name = "labelWho";
            this.labelWho.Size = new System.Drawing.Size(776, 35);
            this.labelWho.TabIndex = 0;
            this.labelWho.Text = "Performed lab work Artem Barysh the student of K-27 gruop, 2022 year";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(12, 49);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(758, 207);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = resources.GetString("InfoLabel.Text");
            // 
            // AboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.labelWho);
            this.Name = "AboutMe";
            this.Text = "AboutMe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelWho;
        private Label InfoLabel;
    }
}