
namespace Heliacal
{
    partial class oknoOtazka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oknoOtazka));
            this.tlacitkoAno = new System.Windows.Forms.Button();
            this.tlacitkoNe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.zvuk = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.zvuk)).BeginInit();
            this.SuspendLayout();
            // 
            // tlacitkoAno
            // 
            this.tlacitkoAno.BackColor = System.Drawing.Color.Transparent;
            this.tlacitkoAno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tlacitkoAno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tlacitkoAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoAno.Font = new System.Drawing.Font("Space Bd BT", 15F);
            this.tlacitkoAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.tlacitkoAno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlacitkoAno.Location = new System.Drawing.Point(73, 71);
            this.tlacitkoAno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tlacitkoAno.Name = "tlacitkoAno";
            this.tlacitkoAno.Size = new System.Drawing.Size(110, 40);
            this.tlacitkoAno.TabIndex = 29;
            this.tlacitkoAno.Text = "ANO";
            this.tlacitkoAno.UseVisualStyleBackColor = false;
            this.tlacitkoAno.Click += new System.EventHandler(this.tlacitkoAno_Click);
            this.tlacitkoAno.MouseEnter += new System.EventHandler(this.tlacitkoAno_MouseEnter);
            this.tlacitkoAno.MouseLeave += new System.EventHandler(this.tlacitkoAno_MouseLeave);
            // 
            // tlacitkoNe
            // 
            this.tlacitkoNe.BackColor = System.Drawing.Color.Transparent;
            this.tlacitkoNe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tlacitkoNe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tlacitkoNe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoNe.Font = new System.Drawing.Font("Space Bd BT", 15F);
            this.tlacitkoNe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.tlacitkoNe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlacitkoNe.Location = new System.Drawing.Point(216, 71);
            this.tlacitkoNe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tlacitkoNe.Name = "tlacitkoNe";
            this.tlacitkoNe.Size = new System.Drawing.Size(110, 40);
            this.tlacitkoNe.TabIndex = 30;
            this.tlacitkoNe.Text = "NE";
            this.tlacitkoNe.UseVisualStyleBackColor = false;
            this.tlacitkoNe.Click += new System.EventHandler(this.tlacitkoNe_Click);
            this.tlacitkoNe.MouseEnter += new System.EventHandler(this.tlacitkoNe_MouseEnter);
            this.tlacitkoNe.MouseLeave += new System.EventHandler(this.tlacitkoNe_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Space Bd BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 48);
            this.label2.TabIndex = 31;
            this.label2.Text = "Opravdu chceš restartovat hru? \r\nVšechen dosavadní postup bude ztracen!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zvuk
            // 
            this.zvuk.Enabled = true;
            this.zvuk.Location = new System.Drawing.Point(360, 91);
            this.zvuk.Name = "zvuk";
            this.zvuk.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("zvuk.OcxState")));
            this.zvuk.Size = new System.Drawing.Size(41, 33);
            this.zvuk.TabIndex = 38;
            this.zvuk.Visible = false;
            // 
            // oknoOtazka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(408, 123);
            this.Controls.Add(this.zvuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tlacitkoNe);
            this.Controls.Add(this.tlacitkoAno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "oknoOtazka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "oknoOtazka";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.zvuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tlacitkoAno;
        private System.Windows.Forms.Button tlacitkoNe;
        private System.Windows.Forms.Label label2;
        private AxWMPLib.AxWindowsMediaPlayer zvuk;
    }
}