namespace JuegoMedieval1._0
{
    partial class FormInfo
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.rtbSobreJuego = new System.Windows.Forms.RichTextBox();
            this.lblProgramador = new System.Windows.Forms.Label();
            this.rtbProgramador = new System.Windows.Forms.RichTextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(139, 24);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Sobre el juego:";
            // 
            // rtbSobreJuego
            // 
            this.rtbSobreJuego.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtbSobreJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSobreJuego.Location = new System.Drawing.Point(14, 45);
            this.rtbSobreJuego.Name = "rtbSobreJuego";
            this.rtbSobreJuego.ReadOnly = true;
            this.rtbSobreJuego.Size = new System.Drawing.Size(318, 205);
            this.rtbSobreJuego.TabIndex = 1;
            this.rtbSobreJuego.Text = "";
            this.rtbSobreJuego.TextChanged += new System.EventHandler(this.rtbSobreJuego_TextChanged);
            // 
            // lblProgramador
            // 
            this.lblProgramador.AutoSize = true;
            this.lblProgramador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramador.Location = new System.Drawing.Point(12, 273);
            this.lblProgramador.Name = "lblProgramador";
            this.lblProgramador.Size = new System.Drawing.Size(200, 24);
            this.lblProgramador.TabIndex = 2;
            this.lblProgramador.Text = "Sobre el programador:";
            // 
            // rtbProgramador
            // 
            this.rtbProgramador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtbProgramador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbProgramador.Location = new System.Drawing.Point(14, 309);
            this.rtbProgramador.Name = "rtbProgramador";
            this.rtbProgramador.ReadOnly = true;
            this.rtbProgramador.Size = new System.Drawing.Size(318, 57);
            this.rtbProgramador.TabIndex = 3;
            this.rtbProgramador.Text = "";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(16, 399);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 39);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.rtbProgramador);
            this.Controls.Add(this.lblProgramador);
            this.Controls.Add(this.rtbSobreJuego);
            this.Controls.Add(this.lbl1);
            this.MaximumSize = new System.Drawing.Size(362, 466);
            this.MinimumSize = new System.Drawing.Size(362, 466);
            this.Name = "FormInfo";
            this.Load += new System.EventHandler(this.FormInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RichTextBox rtbSobreJuego;
        private System.Windows.Forms.Label lblProgramador;
        private System.Windows.Forms.RichTextBox rtbProgramador;
        private System.Windows.Forms.Button btnVolver;
    }
}