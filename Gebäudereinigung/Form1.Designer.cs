namespace Gebäudereinigung
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
            this.btn_fenster = new CustomControls.RJControls.RJButton();
            this.btn_gesamt = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.tb_fensteranzahl = new CustomControls.RJControls.RJTextBox();
            this.tb_bodengröße = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kunde = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dp_datum = new CustomControls.RJControls.RJDatePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_fenster
            // 
            this.btn_fenster.BackColor = System.Drawing.Color.Teal;
            this.btn_fenster.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_fenster.BorderColor = System.Drawing.Color.Teal;
            this.btn_fenster.BorderRadius = 10;
            this.btn_fenster.BorderSize = 5;
            this.btn_fenster.FlatAppearance.BorderSize = 0;
            this.btn_fenster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fenster.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fenster.ForeColor = System.Drawing.Color.White;
            this.btn_fenster.Location = new System.Drawing.Point(62, 304);
            this.btn_fenster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_fenster.Name = "btn_fenster";
            this.btn_fenster.Size = new System.Drawing.Size(236, 74);
            this.btn_fenster.TabIndex = 0;
            this.btn_fenster.Text = "Fensterreinigung";
            this.btn_fenster.TextColor = System.Drawing.Color.White;
            this.btn_fenster.UseVisualStyleBackColor = false;
            this.btn_fenster.Click += new System.EventHandler(this.btn_fenster_Click);
            // 
            // btn_gesamt
            // 
            this.btn_gesamt.BackColor = System.Drawing.Color.Teal;
            this.btn_gesamt.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_gesamt.BorderColor = System.Drawing.Color.Teal;
            this.btn_gesamt.BorderRadius = 10;
            this.btn_gesamt.BorderSize = 5;
            this.btn_gesamt.FlatAppearance.BorderSize = 0;
            this.btn_gesamt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gesamt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gesamt.ForeColor = System.Drawing.Color.White;
            this.btn_gesamt.Location = new System.Drawing.Point(325, 304);
            this.btn_gesamt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_gesamt.Name = "btn_gesamt";
            this.btn_gesamt.Size = new System.Drawing.Size(236, 74);
            this.btn_gesamt.TabIndex = 1;
            this.btn_gesamt.Text = "Gesamtreinigung";
            this.btn_gesamt.TextColor = System.Drawing.Color.White;
            this.btn_gesamt.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Teal;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Teal;
            this.rjButton2.BorderColor = System.Drawing.Color.Teal;
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 5;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(581, 304);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(236, 74);
            this.rjButton2.TabIndex = 2;
            this.rjButton2.Text = "Bodenreinigung";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // tb_fensteranzahl
            // 
            this.tb_fensteranzahl.BackColor = System.Drawing.SystemColors.Window;
            this.tb_fensteranzahl.BorderColor = System.Drawing.Color.Teal;
            this.tb_fensteranzahl.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.tb_fensteranzahl.BorderRadius = 0;
            this.tb_fensteranzahl.BorderSize = 3;
            this.tb_fensteranzahl.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fensteranzahl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_fensteranzahl.Location = new System.Drawing.Point(62, 248);
            this.tb_fensteranzahl.Multiline = false;
            this.tb_fensteranzahl.Name = "tb_fensteranzahl";
            this.tb_fensteranzahl.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tb_fensteranzahl.PasswordChar = false;
            this.tb_fensteranzahl.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_fensteranzahl.PlaceholderText = "Anzahl der Fenster";
            this.tb_fensteranzahl.Size = new System.Drawing.Size(345, 41);
            this.tb_fensteranzahl.TabIndex = 3;
            this.tb_fensteranzahl.Texts = "";
            this.tb_fensteranzahl.UnderlinedStyle = true;
            this.tb_fensteranzahl._TextChanged += new System.EventHandler(this.tb_fensteranzahl__TextChanged);
            // 
            // tb_bodengröße
            // 
            this.tb_bodengröße.BackColor = System.Drawing.SystemColors.Window;
            this.tb_bodengröße.BorderColor = System.Drawing.Color.Teal;
            this.tb_bodengröße.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.tb_bodengröße.BorderRadius = 0;
            this.tb_bodengröße.BorderSize = 3;
            this.tb_bodengröße.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bodengröße.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_bodengröße.Location = new System.Drawing.Point(467, 248);
            this.tb_bodengröße.Multiline = false;
            this.tb_bodengröße.Name = "tb_bodengröße";
            this.tb_bodengröße.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tb_bodengröße.PasswordChar = false;
            this.tb_bodengröße.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_bodengröße.PlaceholderText = "Boden in m²";
            this.tb_bodengröße.Size = new System.Drawing.Size(350, 41);
            this.tb_bodengröße.TabIndex = 4;
            this.tb_bodengröße.Texts = "";
            this.tb_bodengröße.UnderlinedStyle = true;
            this.tb_bodengröße._TextChanged += new System.EventHandler(this.tb_bodengröße__TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "/";
            // 
            // btn_kunde
            // 
            this.btn_kunde.BackColor = System.Drawing.SystemColors.Window;
            this.btn_kunde.BorderColor = System.Drawing.Color.Teal;
            this.btn_kunde.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.btn_kunde.BorderRadius = 0;
            this.btn_kunde.BorderSize = 3;
            this.btn_kunde.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kunde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_kunde.Location = new System.Drawing.Point(281, 137);
            this.btn_kunde.Multiline = false;
            this.btn_kunde.Name = "btn_kunde";
            this.btn_kunde.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn_kunde.PasswordChar = false;
            this.btn_kunde.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.btn_kunde.PlaceholderText = "Kunde";
            this.btn_kunde.Size = new System.Drawing.Size(345, 41);
            this.btn_kunde.TabIndex = 7;
            this.btn_kunde.Texts = "";
            this.btn_kunde.UnderlinedStyle = true;
            this.btn_kunde._TextChanged += new System.EventHandler(this.btn_kunde__TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(357, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reinigung";
            // 
            // dp_datum
            // 
            this.dp_datum.BorderColor = System.Drawing.Color.Teal;
            this.dp_datum.BorderSize = 3;
            this.dp_datum.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_datum.Location = new System.Drawing.Point(281, 197);
            this.dp_datum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dp_datum.MinimumSize = new System.Drawing.Size(4, 35);
            this.dp_datum.Name = "dp_datum";
            this.dp_datum.Size = new System.Drawing.Size(347, 35);
            this.dp_datum.SkinColor = System.Drawing.Color.Teal;
            this.dp_datum.TabIndex = 9;
            this.dp_datum.TextColor = System.Drawing.Color.White;
            this.dp_datum.ValueChanged += new System.EventHandler(this.dp_datum_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 92);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dp_datum);
            this.Controls.Add(this.btn_kunde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_bodengröße);
            this.Controls.Add(this.tb_fensteranzahl);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.btn_gesamt);
            this.Controls.Add(this.btn_fenster);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btn_fenster;
        private CustomControls.RJControls.RJButton btn_gesamt;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJTextBox tb_fensteranzahl;
        private CustomControls.RJControls.RJTextBox tb_bodengröße;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox btn_kunde;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJDatePicker dp_datum;
        private System.Windows.Forms.Panel panel1;
    }
}