
namespace Heliacal
{
    partial class oknoVitaci
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oknoVitaci));
            this.labelNazevVitaci = new System.Windows.Forms.Label();
            this.tlacitkoSpustit = new System.Windows.Forms.Button();
            this.tlacitkoUkoncit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNazevVitaci
            // 
            this.labelNazevVitaci.AutoSize = true;
            this.labelNazevVitaci.BackColor = System.Drawing.Color.Transparent;
            this.labelNazevVitaci.Font = new System.Drawing.Font("Space Bd BT", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazevVitaci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.labelNazevVitaci.Location = new System.Drawing.Point(113, 83);
            this.labelNazevVitaci.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.labelNazevVitaci.Name = "labelNazevVitaci";
            this.labelNazevVitaci.Size = new System.Drawing.Size(389, 111);
            this.labelNazevVitaci.TabIndex = 1;
            this.labelNazevVitaci.Text = "Heliacal";
            // 
            // tlacitkoSpustit
            // 
            this.tlacitkoSpustit.BackColor = System.Drawing.Color.Transparent;
            this.tlacitkoSpustit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.tlacitkoSpustit.FlatAppearance.BorderSize = 0;
            this.tlacitkoSpustit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(103)))), ((int)(((byte)(159)))));
            this.tlacitkoSpustit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tlacitkoSpustit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tlacitkoSpustit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoSpustit.Font = new System.Drawing.Font("Space Bd BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlacitkoSpustit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.tlacitkoSpustit.Location = new System.Drawing.Point(250, 197);
            this.tlacitkoSpustit.Name = "tlacitkoSpustit";
            this.tlacitkoSpustit.Size = new System.Drawing.Size(100, 40);
            this.tlacitkoSpustit.TabIndex = 2;
            this.tlacitkoSpustit.Text = "Spustit";
            this.tlacitkoSpustit.UseVisualStyleBackColor = false;
            this.tlacitkoSpustit.Click += new System.EventHandler(this.tlacitkoSpustit_Click);
            this.tlacitkoSpustit.MouseEnter += new System.EventHandler(this.tlacitkoSpustit_MouseEnter);
            this.tlacitkoSpustit.MouseLeave += new System.EventHandler(this.tlacitkoSpustit_MouseLeave);
            // 
            // tlacitkoUkoncit
            // 
            this.tlacitkoUkoncit.BackColor = System.Drawing.Color.Transparent;
            this.tlacitkoUkoncit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.tlacitkoUkoncit.FlatAppearance.BorderSize = 0;
            this.tlacitkoUkoncit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(103)))), ((int)(((byte)(159)))));
            this.tlacitkoUkoncit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tlacitkoUkoncit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tlacitkoUkoncit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlacitkoUkoncit.Font = new System.Drawing.Font("Space Bd BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlacitkoUkoncit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.tlacitkoUkoncit.Location = new System.Drawing.Point(354, 197);
            this.tlacitkoUkoncit.Name = "tlacitkoUkoncit";
            this.tlacitkoUkoncit.Size = new System.Drawing.Size(100, 40);
            this.tlacitkoUkoncit.TabIndex = 3;
            this.tlacitkoUkoncit.Text = "Ukončit";
            this.tlacitkoUkoncit.UseVisualStyleBackColor = false;
            this.tlacitkoUkoncit.Click += new System.EventHandler(this.tlacitkoUkoncit_Click);
            this.tlacitkoUkoncit.MouseEnter += new System.EventHandler(this.tlacitkoUkoncit_MouseEnter);
            this.tlacitkoUkoncit.MouseLeave += new System.EventHandler(this.tlacitkoUkoncit_MouseLeave);
            // 
            // oknoVitaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(610, 300);
            this.ControlBox = false;
            this.Controls.Add(this.tlacitkoUkoncit);
            this.Controls.Add(this.tlacitkoSpustit);
            this.Controls.Add(this.labelNazevVitaci);
            this.Font = new System.Drawing.Font("Space Bd BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(610, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 300);
            this.Name = "oknoVitaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heliacal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNazevVitaci;
        private System.Windows.Forms.Button tlacitkoSpustit;
        private System.Windows.Forms.Button tlacitkoUkoncit;
    }
}

