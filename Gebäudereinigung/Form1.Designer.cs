
namespace Gebäudereinigung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Fenster = new CustomControls.RJControls.RJButton();
            this.btn_gesamt = new CustomControls.RJControls.RJButton();
            this.btn_boden = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_anzahl = new CustomControls.RJControls.RJTextBox();
            this.tb_kunde = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dp_datum = new CustomControls.RJControls.RJDatePicker();
            this.SuspendLayout();
            // 
            // btn_Fenster
            // 
            this.btn_Fenster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fenster.BackColor = System.Drawing.Color.Teal;
            this.btn_Fenster.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_Fenster.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Fenster.BorderRadius = 5;
            this.btn_Fenster.BorderSize = 2;
            this.btn_Fenster.FlatAppearance.BorderSize = 0;
            this.btn_Fenster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fenster.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fenster.ForeColor = System.Drawing.Color.White;
            this.btn_Fenster.Location = new System.Drawing.Point(152, 408);
            this.btn_Fenster.Name = "btn_Fenster";
            this.btn_Fenster.Size = new System.Drawing.Size(324, 171);
            this.btn_Fenster.TabIndex = 0;
            this.btn_Fenster.Text = "Fensterreinigung";
            this.btn_Fenster.TextColor = System.Drawing.Color.White;
            this.btn_Fenster.UseVisualStyleBackColor = false;
            // 
            // btn_gesamt
            // 
            this.btn_gesamt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gesamt.BackColor = System.Drawing.Color.Teal;
            this.btn_gesamt.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_gesamt.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btn_gesamt.BorderRadius = 5;
            this.btn_gesamt.BorderSize = 2;
            this.btn_gesamt.FlatAppearance.BorderSize = 0;
            this.btn_gesamt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gesamt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gesamt.ForeColor = System.Drawing.Color.White;
            this.btn_gesamt.Location = new System.Drawing.Point(490, 408);
            this.btn_gesamt.Name = "btn_gesamt";
            this.btn_gesamt.Size = new System.Drawing.Size(340, 171);
            this.btn_gesamt.TabIndex = 1;
            this.btn_gesamt.Text = "Gesamtreinigung";
            this.btn_gesamt.TextColor = System.Drawing.Color.White;
            this.btn_gesamt.UseVisualStyleBackColor = false;
            // 
            // btn_boden
            // 
            this.btn_boden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_boden.BackColor = System.Drawing.Color.Teal;
            this.btn_boden.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_boden.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btn_boden.BorderRadius = 5;
            this.btn_boden.BorderSize = 2;
            this.btn_boden.FlatAppearance.BorderSize = 0;
            this.btn_boden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_boden.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_boden.ForeColor = System.Drawing.Color.White;
            this.btn_boden.Location = new System.Drawing.Point(841, 408);
            this.btn_boden.Name = "btn_boden";
            this.btn_boden.Size = new System.Drawing.Size(331, 171);
            this.btn_boden.TabIndex = 2;
            this.btn_boden.Text = "Bodenreinigung";
            this.btn_boden.TextColor = System.Drawing.Color.White;
            this.btn_boden.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reinigung";
            // 
            // tb_anzahl
            // 
            this.tb_anzahl.BackColor = System.Drawing.SystemColors.Window;
            this.tb_anzahl.BorderColor = System.Drawing.Color.Teal;
            this.tb_anzahl.BorderFocusColor = System.Drawing.Color.SkyBlue;
            this.tb_anzahl.BorderRadius = 0;
            this.tb_anzahl.BorderSize = 2;
            this.tb_anzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_anzahl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_anzahl.Location = new System.Drawing.Point(152, 313);
            this.tb_anzahl.Margin = new System.Windows.Forms.Padding(4);
            this.tb_anzahl.Multiline = false;
            this.tb_anzahl.Name = "tb_anzahl";
            this.tb_anzahl.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_anzahl.PasswordChar = false;
            this.tb_anzahl.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_anzahl.PlaceholderText = "Anzahl Fenster";
            this.tb_anzahl.Size = new System.Drawing.Size(442, 52);
            this.tb_anzahl.TabIndex = 4;
            this.tb_anzahl.Texts = "";
            this.tb_anzahl.UnderlinedStyle = true;
            // 
            // tb_kunde
            // 
            this.tb_kunde.BackColor = System.Drawing.SystemColors.Window;
            this.tb_kunde.BorderColor = System.Drawing.Color.Teal;
            this.tb_kunde.BorderFocusColor = System.Drawing.Color.SkyBlue;
            this.tb_kunde.BorderRadius = 0;
            this.tb_kunde.BorderSize = 2;
            this.tb_kunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kunde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_kunde.Location = new System.Drawing.Point(429, 228);
            this.tb_kunde.Margin = new System.Windows.Forms.Padding(4);
            this.tb_kunde.Multiline = false;
            this.tb_kunde.Name = "tb_kunde";
            this.tb_kunde.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_kunde.PasswordChar = false;
            this.tb_kunde.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_kunde.PlaceholderText = "Kunde";
            this.tb_kunde.Size = new System.Drawing.Size(442, 52);
            this.tb_kunde.TabIndex = 5;
            this.tb_kunde.Texts = "";
            this.tb_kunde.UnderlinedStyle = true;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.Teal;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.SkyBlue;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(699, 313);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "Boden in m²";
            this.rjTextBox1.Size = new System.Drawing.Size(442, 52);
            this.rjTextBox1.TabIndex = 6;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(636, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "/";
            // 
            // dp_datum
            // 
            this.dp_datum.BorderColor = System.Drawing.Color.White;
            this.dp_datum.BorderSize = 0;
            this.dp_datum.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_datum.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_datum.Location = new System.Drawing.Point(429, 151);
            this.dp_datum.MinimumSize = new System.Drawing.Size(0, 35);
            this.dp_datum.Name = "dp_datum";
            this.dp_datum.Size = new System.Drawing.Size(442, 38);
            this.dp_datum.SkinColor = System.Drawing.Color.Teal;
            this.dp_datum.TabIndex = 8;
            this.dp_datum.TextColor = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1324, 641);
            this.Controls.Add(this.dp_datum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.tb_kunde);
            this.Controls.Add(this.tb_anzahl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_boden);
            this.Controls.Add(this.btn_gesamt);
            this.Controls.Add(this.btn_Fenster);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btn_Fenster;
        private CustomControls.RJControls.RJButton btn_gesamt;
        private CustomControls.RJControls.RJButton btn_boden;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox tb_anzahl;
        private CustomControls.RJControls.RJTextBox tb_kunde;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJDatePicker dp_datum;
    }
}

