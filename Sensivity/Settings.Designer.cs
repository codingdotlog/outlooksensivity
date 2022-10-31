namespace Sensivity
{
    partial class Settings
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
            this.label4 = new System.Windows.Forms.Label();
            this.listView_domains = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_remove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_domain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Internal Domain Tanımlamaları";
            // 
            // listView_domains
            // 
            this.listView_domains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_domains.HideSelection = false;
            this.listView_domains.Location = new System.Drawing.Point(15, 105);
            this.listView_domains.Name = "listView_domains";
            this.listView_domains.Size = new System.Drawing.Size(773, 297);
            this.listView_domains.TabIndex = 10;
            this.listView_domains.UseCompatibleStateImageBehavior = false;
            this.listView_domains.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 400;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(15, 408);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(158, 23);
            this.button_remove.TabIndex = 12;
            this.button_remove.Text = "Seçileni Sil";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Yeni Internal Domain Ekle";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(382, 29);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 14;
            this.button_add.Text = "Ekle";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_domain
            // 
            this.textBox_domain.Location = new System.Drawing.Point(15, 30);
            this.textBox_domain.Name = "textBox_domain";
            this.textBox_domain.Size = new System.Drawing.Size(361, 22);
            this.textBox_domain.TabIndex = 13;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_domain);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView_domains);
            this.Name = "Settings";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView_domains;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_domain;
    }
}