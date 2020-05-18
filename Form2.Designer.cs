namespace TiendaVirtualHardware
{
    partial class FrmAcces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcces));
            this.TxtUs = new System.Windows.Forms.TextBox();
            this.LblUs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCon = new System.Windows.Forms.TextBox();
            this.BtnAce = new System.Windows.Forms.Button();
            this.BtnCan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtUs
            // 
            this.TxtUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUs.Location = new System.Drawing.Point(194, 28);
            this.TxtUs.Name = "TxtUs";
            this.TxtUs.Size = new System.Drawing.Size(273, 31);
            this.TxtUs.TabIndex = 0;
            this.TxtUs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblUs
            // 
            this.LblUs.AutoSize = true;
            this.LblUs.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUs.ForeColor = System.Drawing.Color.DarkRed;
            this.LblUs.Location = new System.Drawing.Point(54, 28);
            this.LblUs.Name = "LblUs";
            this.LblUs.Size = new System.Drawing.Size(117, 33);
            this.LblUs.TabIndex = 1;
            this.LblUs.Text = "Usuario :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña :";
            // 
            // TxtCon
            // 
            this.TxtCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCon.Location = new System.Drawing.Point(194, 92);
            this.TxtCon.Name = "TxtCon";
            this.TxtCon.PasswordChar = '♠';
            this.TxtCon.Size = new System.Drawing.Size(273, 31);
            this.TxtCon.TabIndex = 3;
            // 
            // BtnAce
            // 
            this.BtnAce.Location = new System.Drawing.Point(523, 46);
            this.BtnAce.Name = "BtnAce";
            this.BtnAce.Size = new System.Drawing.Size(110, 60);
            this.BtnAce.TabIndex = 4;
            this.BtnAce.Text = "Aceptar";
            this.BtnAce.UseVisualStyleBackColor = true;
            this.BtnAce.Click += new System.EventHandler(this.BtnAce_Click);
            // 
            // BtnCan
            // 
            this.BtnCan.Location = new System.Drawing.Point(657, 46);
            this.BtnCan.Name = "BtnCan";
            this.BtnCan.Size = new System.Drawing.Size(110, 60);
            this.BtnCan.TabIndex = 5;
            this.BtnCan.Text = "Cancelar";
            this.BtnCan.UseVisualStyleBackColor = true;
            this.BtnCan.Click += new System.EventHandler(this.BtnCan_Click);
            // 
            // FrmAcces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCan);
            this.Controls.Add(this.BtnAce);
            this.Controls.Add(this.TxtCon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblUs);
            this.Controls.Add(this.TxtUs);
            this.Name = "FrmAcces";
            this.Text = " Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUs;
        private System.Windows.Forms.Label LblUs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCon;
        private System.Windows.Forms.Button BtnAce;
        private System.Windows.Forms.Button BtnCan;
    }
}