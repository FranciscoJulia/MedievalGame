namespace JuegoMedieval1._0
{
    partial class FormJuegoClick
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lblCantMonedas = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.FloralWhite;
            this.btnClick.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClick.Location = new System.Drawing.Point(72, 90);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(250, 197);
            this.btnClick.TabIndex = 32;
            this.btnClick.Text = "Click aqui para empezar a trabajar...";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblCantMonedas
            // 
            this.lblCantMonedas.AutoSize = true;
            this.lblCantMonedas.BackColor = System.Drawing.Color.Transparent;
            this.lblCantMonedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.lblCantMonedas.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCantMonedas.Location = new System.Drawing.Point(108, 296);
            this.lblCantMonedas.Name = "lblCantMonedas";
            this.lblCantMonedas.Size = new System.Drawing.Size(118, 30);
            this.lblCantMonedas.TabIndex = 33;
            this.lblCantMonedas.Text = "Monedas";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FloralWhite;
            this.btnVolver.Font = new System.Drawing.Font("Perpetua", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnVolver.Location = new System.Drawing.Point(130, 26);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(134, 45);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::JuegoMedieval1._0.Properties.Resources.coins_clipart_for_teachers_medieval_coin_6;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(72, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // FormJuegoClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoMedieval1._0.Properties.Resources.OIP;
            this.ClientSize = new System.Drawing.Size(397, 371);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblCantMonedas);
            this.Controls.Add(this.btnClick);
            this.MaximumSize = new System.Drawing.Size(413, 387);
            this.MinimumSize = new System.Drawing.Size(413, 387);
            this.Name = "FormJuegoClick";
            this.Load += new System.EventHandler(this.FormJugarClick_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblCantMonedas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}