
namespace SqlBenz
{
    partial class SqlEditor
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
            this.ListFoundbox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListFoundbox
            // 
            this.ListFoundbox.FormattingEnabled = true;
            this.ListFoundbox.ItemHeight = 31;
            this.ListFoundbox.Location = new System.Drawing.Point(52, 261);
            this.ListFoundbox.Name = "ListFoundbox";
            this.ListFoundbox.Size = new System.Drawing.Size(656, 283);
            this.ListFoundbox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(299, 97);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(187, 38);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(111, 103);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(140, 32);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Lastname";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(299, 185);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(135, 39);
            this.SearchTxt.TabIndex = 3;
            this.SearchTxt.Text = "Search";
            this.SearchTxt.UseVisualStyleBackColor = true;
            this.SearchTxt.Click += new System.EventHandler(this.SearchTxt_Click);
            // 
            // SqlEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 568);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.ListFoundbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SqlEditor";
            this.Text = "Sql";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListFoundbox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button SearchTxt;
    }
}

