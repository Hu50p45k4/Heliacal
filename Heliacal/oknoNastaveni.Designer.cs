
namespace Heliacal
{
    partial class oknoNastaveni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oknoNastaveni));
            this.tlacitkoSkrytNastaveni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zvukoveEfekty = new System.Windows.Forms.CheckBox();
            this.hudba = new System.Windows.Forms.CheckBox();
            this.tlacitkoRestartovat = new System.Windows.Forms.Button();
            this.zvuk = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.zvuk)).BeginInit();
            this.SuspendLayout();
            // 
            // tlacitkoSkrytNastaveni
            // 
            this.tlacitkoSkrytNastaveni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlacitkoSkrytNastaveni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(74)))));
            this.tlacitkoSkrytNastaveni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(74)))));
            this.tlacitkoSkrytNastaveni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoSkrytNastaveni.Font = new System.Drawing.Font("Space Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlacitkoSkrytNastaveni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.tlacitkoSkrytNastaveni.Location = new System.Drawing.Point(251, 100);
            this.tlacitkoSkrytNastaveni.Name = "tlacitkoSkrytNastaveni";
            this.tlacitkoSkrytNastaveni.Size = new System.Drawing.Size(76, 37);
            this.tlacitkoSkrytNastaveni.TabIndex = 3;
            this.tlacitkoSkrytNastaveni.Text = "Exit";
            this.tlacitkoSkrytNastaveni.UseVisualStyleBackColor = true;
            this.tlacitkoSkrytNastaveni.Click += new System.EventHandler(this.tlacitkoSkrytNastaveni_Click);
            this.tlacitkoSkrytNastaveni.MouseEnter += new System.EventHandler(this.tlacitkoSkrytNastaveni_MouseEnter);
            this.tlacitkoSkrytNastaveni.MouseLeave += new System.EventHandler(this.tlacitkoSkrytNastaveni_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Space Bd BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(64, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zvukové efekty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Space Bd BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(151, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hudba";
            // 
            // zvukoveEfekty
            // 
            this.zvukoveEfekty.Appearance = System.Windows.Forms.Appearance.Button;
            this.zvukoveEfekty.Checked = true;
            this.zvukoveEfekty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zvukoveEfekty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.zvukoveEfekty.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.zvukoveEfekty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.zvukoveEfekty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.zvukoveEfekty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zvukoveEfekty.Font = new System.Drawing.Font("Space Bd BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zvukoveEfekty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.zvukoveEfekty.Location = new System.Drawing.Point(224, 19);
            this.zvukoveEfekty.Name = "zvukoveEfekty";
            this.zvukoveEfekty.Size = new System.Drawing.Size(20, 20);
            this.zvukoveEfekty.TabIndex = 39;
            this.zvukoveEfekty.TabStop = false;
            this.zvukoveEfekty.UseVisualStyleBackColor = false;
            this.zvukoveEfekty.CheckedChanged += new System.EventHandler(this.zvukoveEfekty_CheckedChanged);
            // 
            // hudba
            // 
            this.hudba.Appearance = System.Windows.Forms.Appearance.Button;
            this.hudba.Checked = true;
            this.hudba.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hudba.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.hudba.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.hudba.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.hudba.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.hudba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hudba.Font = new System.Drawing.Font("Space Bd BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.hudba.Location = new System.Drawing.Point(224, 64);
            this.hudba.Name = "hudba";
            this.hudba.Size = new System.Drawing.Size(20, 20);
            this.hudba.TabIndex = 40;
            this.hudba.TabStop = false;
            this.hudba.UseVisualStyleBackColor = false;
            this.hudba.CheckedChanged += new System.EventHandler(this.hudba_CheckedChanged);
            // 
            // tlacitkoRestartovat
            // 
            this.tlacitkoRestartovat.BackColor = System.Drawing.Color.Transparent;
            this.tlacitkoRestartovat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tlacitkoRestartovat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tlacitkoRestartovat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoRestartovat.Font = new System.Drawing.Font("Space Bd BT", 15F);
            this.tlacitkoRestartovat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.tlacitkoRestartovat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlacitkoRestartovat.Location = new System.Drawing.Point(11, 100);
            this.tlacitkoRestartovat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tlacitkoRestartovat.Name = "tlacitkoRestartovat";
            this.tlacitkoRestartovat.Size = new System.Drawing.Size(235, 37);
            this.tlacitkoRestartovat.TabIndex = 43;
            this.tlacitkoRestartovat.Text = "Restartovat hru";
            this.tlacitkoRestartovat.UseVisualStyleBackColor = false;
            this.tlacitkoRestartovat.Click += new System.EventHandler(this.tlacitkoRestartovat_Click);
            this.tlacitkoRestartovat.MouseEnter += new System.EventHandler(this.tlacitkoRestartovat_MouseEnter);
            this.tlacitkoRestartovat.MouseLeave += new System.EventHandler(this.tlacitkoRestartovat_MouseLeave);
            // 
            // zvuk
            // 
            this.zvuk.Enabled = true;
            this.zvuk.Location = new System.Drawing.Point(286, 6);
            this.zvuk.Name = "zvuk";
            this.zvuk.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("zvuk.OcxState")));
            this.zvuk.Size = new System.Drawing.Size(41, 33);
            this.zvuk.TabIndex = 44;
            this.zvuk.Visible = false;
            // 
            // oknoNastaveni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(339, 149);
            this.Controls.Add(this.zvuk);
            this.Controls.Add(this.tlacitkoSkrytNastaveni);
            this.Controls.Add(this.tlacitkoRestartovat);
            this.Controls.Add(this.hudba);
            this.Controls.Add(this.zvukoveEfekty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Space Bd BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "oknoNastaveni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "oknoNastaveni";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.zvuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tlacitkoSkrytNastaveni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox zvukoveEfekty;
        private System.Windows.Forms.CheckBox hudba;
        private System.Windows.Forms.Button tlacitkoRestartovat;
        private AxWMPLib.AxWindowsMediaPlayer zvuk;
    }
}