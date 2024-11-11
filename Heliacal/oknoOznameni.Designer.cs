
namespace Heliacal
{
    partial class oknoOznameni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oknoOznameni));
            this.tlacitkoOK = new System.Windows.Forms.Button();
            this.obrazekKosmonaut = new System.Windows.Forms.PictureBox();
            this.labelSkore = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.zvuk = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelTahy = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelCas = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.obrazekKosmonaut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zvuk)).BeginInit();
            this.SuspendLayout();
            // 
            // tlacitkoOK
            // 
            this.tlacitkoOK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlacitkoOK.BackColor = System.Drawing.Color.Transparent;
            this.tlacitkoOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tlacitkoOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tlacitkoOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoOK.Font = new System.Drawing.Font("Space Bd BT", 15F);
            this.tlacitkoOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.tlacitkoOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlacitkoOK.Location = new System.Drawing.Point(559, 141);
            this.tlacitkoOK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tlacitkoOK.Name = "tlacitkoOK";
            this.tlacitkoOK.Size = new System.Drawing.Size(52, 38);
            this.tlacitkoOK.TabIndex = 17;
            this.tlacitkoOK.Text = "OK";
            this.tlacitkoOK.UseVisualStyleBackColor = false;
            this.tlacitkoOK.Click += new System.EventHandler(this.tlacitkoOK_Click);
            this.tlacitkoOK.MouseEnter += new System.EventHandler(this.tlacitkoOK_MouseEnter);
            this.tlacitkoOK.MouseLeave += new System.EventHandler(this.tlacitkoOK_MouseLeave);
            // 
            // obrazekKosmonaut
            // 
            this.obrazekKosmonaut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obrazekKosmonaut.BackgroundImage")));
            this.obrazekKosmonaut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.obrazekKosmonaut.Location = new System.Drawing.Point(12, 12);
            this.obrazekKosmonaut.Name = "obrazekKosmonaut";
            this.obrazekKosmonaut.Size = new System.Drawing.Size(176, 167);
            this.obrazekKosmonaut.TabIndex = 5;
            this.obrazekKosmonaut.TabStop = false;
            // 
            // labelSkore
            // 
            this.labelSkore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(74)))));
            this.labelSkore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelSkore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelSkore.Font = new System.Drawing.Font("Space Bd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.labelSkore.Location = new System.Drawing.Point(375, 125);
            this.labelSkore.Multiline = true;
            this.labelSkore.Name = "labelSkore";
            this.labelSkore.ReadOnly = true;
            this.labelSkore.Size = new System.Drawing.Size(175, 36);
            this.labelSkore.TabIndex = 19;
            this.labelSkore.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(74)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Space Bd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.textBox1.Location = new System.Drawing.Point(194, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(175, 36);
            this.textBox1.TabIndex = 18;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Tvoje skóre:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zvuk
            // 
            this.zvuk.Enabled = true;
            this.zvuk.Location = new System.Drawing.Point(570, 12);
            this.zvuk.Name = "zvuk";
            this.zvuk.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("zvuk.OcxState")));
            this.zvuk.Size = new System.Drawing.Size(41, 33);
            this.zvuk.TabIndex = 38;
            this.zvuk.Visible = false;
            // 
            // labelTahy
            // 
            this.labelTahy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(74)))));
            this.labelTahy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelTahy.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelTahy.Font = new System.Drawing.Font("Space Bd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTahy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.labelTahy.Location = new System.Drawing.Point(375, 83);
            this.labelTahy.Multiline = true;
            this.labelTahy.Name = "labelTahy";
            this.labelTahy.ReadOnly = true;
            this.labelTahy.Size = new System.Drawing.Size(175, 36);
            this.labelTahy.TabIndex = 40;
            this.labelTahy.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(74)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Font = new System.Drawing.Font("Space Bd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.textBox3.Location = new System.Drawing.Point(194, 83);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(175, 36);
            this.textBox3.TabIndex = 39;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Tahy:";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCas
            // 
            this.labelCas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(74)))));
            this.labelCas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelCas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelCas.Font = new System.Drawing.Font("Space Bd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.labelCas.Location = new System.Drawing.Point(375, 41);
            this.labelCas.Multiline = true;
            this.labelCas.Name = "labelCas";
            this.labelCas.ReadOnly = true;
            this.labelCas.Size = new System.Drawing.Size(175, 36);
            this.labelCas.TabIndex = 42;
            this.labelCas.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(74)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Font = new System.Drawing.Font("Space Bd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.textBox5.Location = new System.Drawing.Point(194, 41);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(175, 36);
            this.textBox5.TabIndex = 41;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Čas:";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // oknoOznameni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(622, 193);
            this.Controls.Add(this.labelCas);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.labelTahy);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.zvuk);
            this.Controls.Add(this.labelSkore);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tlacitkoOK);
            this.Controls.Add(this.obrazekKosmonaut);
            this.Font = new System.Drawing.Font("Space Bd BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "oknoOznameni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "oknoOznameni";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.obrazekKosmonaut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zvuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tlacitkoOK;
        private System.Windows.Forms.PictureBox obrazekKosmonaut;
        private System.Windows.Forms.TextBox labelSkore;
        private System.Windows.Forms.TextBox textBox1;
        private AxWMPLib.AxWindowsMediaPlayer zvuk;
        private System.Windows.Forms.TextBox labelTahy;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox labelCas;
        private System.Windows.Forms.TextBox textBox5;
    }
}