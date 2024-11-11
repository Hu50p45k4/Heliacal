
namespace Heliacal
{
    partial class oknoNapoveda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oknoNapoveda));
            this.textOznameni = new System.Windows.Forms.TextBox();
            this.video = new AxWMPLib.AxWindowsMediaPlayer();
            this.tlacitkoExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.zvuk = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zvuk)).BeginInit();
            this.SuspendLayout();
            // 
            // textOznameni
            // 
            this.textOznameni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(74)))));
            this.textOznameni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOznameni.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textOznameni.Font = new System.Drawing.Font("Space Bd BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOznameni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.textOznameni.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.textOznameni.Location = new System.Drawing.Point(529, 12);
            this.textOznameni.Multiline = true;
            this.textOznameni.Name = "textOznameni";
            this.textOznameni.ReadOnly = true;
            this.textOznameni.Size = new System.Drawing.Size(267, 231);
            this.textOznameni.TabIndex = 36;
            this.textOznameni.TabStop = false;
            this.textOznameni.Text = "Tvým úkolem je poskládat obrázek každé planety.\r\nTo udeláš posouváním polí kliknu" +
    "tím myši.\r\nPosunout lze jen to pole, vedle kterého je místo - to se po kliknutí " +
    "nahradí vybraným polem.";
            this.textOznameni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // video
            // 
            this.video.Enabled = true;
            this.video.Location = new System.Drawing.Point(9, 9);
            this.video.Margin = new System.Windows.Forms.Padding(0);
            this.video.Name = "video";
            this.video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video.OcxState")));
            this.video.Size = new System.Drawing.Size(517, 273);
            this.video.TabIndex = 37;
            this.video.TabStop = false;
            // 
            // tlacitkoExit
            // 
            this.tlacitkoExit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlacitkoExit.BackColor = System.Drawing.Color.Transparent;
            this.tlacitkoExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tlacitkoExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tlacitkoExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoExit.Font = new System.Drawing.Font("Space Bd BT", 15F);
            this.tlacitkoExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.tlacitkoExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlacitkoExit.Location = new System.Drawing.Point(672, 244);
            this.tlacitkoExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tlacitkoExit.Name = "tlacitkoExit";
            this.tlacitkoExit.Size = new System.Drawing.Size(110, 38);
            this.tlacitkoExit.TabIndex = 38;
            this.tlacitkoExit.Text = "Exit";
            this.tlacitkoExit.UseVisualStyleBackColor = false;
            this.tlacitkoExit.Click += new System.EventHandler(this.tlacitkoExit_Click);
            this.tlacitkoExit.MouseEnter += new System.EventHandler(this.tlacitkoExit_MouseEnter);
            this.tlacitkoExit.MouseLeave += new System.EventHandler(this.tlacitkoExit_MouseLeave);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Space Bd BT", 15F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(544, 244);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 39;
            this.button1.Text = "Znovu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // zvuk
            // 
            this.zvuk.Enabled = true;
            this.zvuk.Location = new System.Drawing.Point(755, 0);
            this.zvuk.Name = "zvuk";
            this.zvuk.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("zvuk.OcxState")));
            this.zvuk.Size = new System.Drawing.Size(41, 33);
            this.zvuk.TabIndex = 40;
            this.zvuk.Visible = false;
            // 
            // oknoNapoveda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(796, 294);
            this.Controls.Add(this.zvuk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tlacitkoExit);
            this.Controls.Add(this.video);
            this.Controls.Add(this.textOznameni);
            this.Font = new System.Drawing.Font("Space Bd BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "oknoNapoveda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "oknoNapoveda";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zvuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textOznameni;
        private AxWMPLib.AxWindowsMediaPlayer video;
        private System.Windows.Forms.Button tlacitkoExit;
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer zvuk;
    }
}