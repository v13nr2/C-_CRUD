namespace msAccess
{
    partial class Form1
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
            this.bt_retrieve = new System.Windows.Forms.Button();
            this.mListView = new System.Windows.Forms.ListView();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_propelan = new System.Windows.Forms.Label();
            this.lbl_destination = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_propelan = new System.Windows.Forms.TextBox();
            this.txt_destination = new System.Windows.Forms.TextBox();
            this.bt_tambah = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_retrieve
            // 
            this.bt_retrieve.Location = new System.Drawing.Point(517, 28);
            this.bt_retrieve.Name = "bt_retrieve";
            this.bt_retrieve.Size = new System.Drawing.Size(75, 23);
            this.bt_retrieve.TabIndex = 0;
            this.bt_retrieve.Text = "Tampilkan";
            this.bt_retrieve.UseVisualStyleBackColor = true;
            this.bt_retrieve.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mListView
            // 
            this.mListView.Location = new System.Drawing.Point(12, 12);
            this.mListView.Name = "mListView";
            this.mListView.Size = new System.Drawing.Size(444, 245);
            this.mListView.TabIndex = 1;
            this.mListView.UseCompatibleStateImageBehavior = false;
            this.mListView.SelectedIndexChanged += new System.EventHandler(this.MListView_SelectedIndexChanged_1);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(514, 68);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            this.lbl_name.Click += new System.EventHandler(this.Lbl_name_Click);
            // 
            // lbl_propelan
            // 
            this.lbl_propelan.AutoSize = true;
            this.lbl_propelan.Location = new System.Drawing.Point(514, 101);
            this.lbl_propelan.Name = "lbl_propelan";
            this.lbl_propelan.Size = new System.Drawing.Size(49, 13);
            this.lbl_propelan.TabIndex = 3;
            this.lbl_propelan.Text = "Propelan";
            // 
            // lbl_destination
            // 
            this.lbl_destination.AutoSize = true;
            this.lbl_destination.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_destination.Location = new System.Drawing.Point(514, 145);
            this.lbl_destination.Name = "lbl_destination";
            this.lbl_destination.Size = new System.Drawing.Size(60, 13);
            this.lbl_destination.TabIndex = 4;
            this.lbl_destination.Text = "Destination";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(630, 60);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 5;
            // 
            // txt_propelan
            // 
            this.txt_propelan.Location = new System.Drawing.Point(630, 101);
            this.txt_propelan.Name = "txt_propelan";
            this.txt_propelan.Size = new System.Drawing.Size(100, 20);
            this.txt_propelan.TabIndex = 6;
            // 
            // txt_destination
            // 
            this.txt_destination.Location = new System.Drawing.Point(630, 145);
            this.txt_destination.Name = "txt_destination";
            this.txt_destination.Size = new System.Drawing.Size(100, 20);
            this.txt_destination.TabIndex = 7;
            // 
            // bt_tambah
            // 
            this.bt_tambah.Location = new System.Drawing.Point(517, 190);
            this.bt_tambah.Name = "bt_tambah";
            this.bt_tambah.Size = new System.Drawing.Size(75, 23);
            this.bt_tambah.TabIndex = 8;
            this.bt_tambah.Text = "Tambah";
            this.bt_tambah.UseVisualStyleBackColor = true;
            this.bt_tambah.Click += new System.EventHandler(this.Bt_tambah_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(598, 190);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 9;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.Bt_update_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(679, 190);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 10;
            this.bt_delete.Text = "Hapus";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.Bt_delete_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(607, 28);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 11;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.Bt_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_tambah);
            this.Controls.Add(this.txt_destination);
            this.Controls.Add(this.txt_propelan);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_destination);
            this.Controls.Add(this.lbl_propelan);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.mListView);
            this.Controls.Add(this.bt_retrieve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_retrieve;
        private System.Windows.Forms.ListView mListView;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_propelan;
        private System.Windows.Forms.Label lbl_destination;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_propelan;
        private System.Windows.Forms.TextBox txt_destination;
        private System.Windows.Forms.Button bt_tambah;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_clear;
    }
}

