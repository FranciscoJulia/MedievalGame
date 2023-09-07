namespace JuegoMedieval1._0
{
    partial class FormCrearJugador
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbDificultad = new System.Windows.Forms.TrackBar();
            this.lblFacil = new System.Windows.Forms.Label();
            this.lblMedio = new System.Windows.Forms.Label();
            this.lblDificil = new System.Windows.Forms.Label();
            this.lblDificultad = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDificultad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FloralWhite;
            this.btnCrear.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCrear.Location = new System.Drawing.Point(333, 220);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(146, 62);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(27, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(111, 33);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbNombre.Location = new System.Drawing.Point(137, 37);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(128, 20);
            this.tbNombre.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 118);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tbDificultad
            // 
            this.tbDificultad.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbDificultad.Location = new System.Drawing.Point(42, 155);
            this.tbDificultad.Maximum = 3;
            this.tbDificultad.Minimum = 1;
            this.tbDificultad.Name = "tbDificultad";
            this.tbDificultad.Size = new System.Drawing.Size(214, 45);
            this.tbDificultad.TabIndex = 16;
            this.tbDificultad.Value = 1;
            this.tbDificultad.Scroll += new System.EventHandler(this.tbDificultad_Scroll);
            this.tbDificultad.ValueChanged += new System.EventHandler(this.tbDificultad_ValueChanged);
            // 
            // lblFacil
            // 
            this.lblFacil.AutoSize = true;
            this.lblFacil.BackColor = System.Drawing.SystemColors.Control;
            this.lblFacil.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFacil.Location = new System.Drawing.Point(46, 122);
            this.lblFacil.Name = "lblFacil";
            this.lblFacil.Size = new System.Drawing.Size(58, 31);
            this.lblFacil.TabIndex = 17;
            this.lblFacil.Text = "Fácil";
            // 
            // lblMedio
            // 
            this.lblMedio.AutoSize = true;
            this.lblMedio.BackColor = System.Drawing.SystemColors.Control;
            this.lblMedio.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMedio.Location = new System.Drawing.Point(109, 122);
            this.lblMedio.Name = "lblMedio";
            this.lblMedio.Size = new System.Drawing.Size(69, 28);
            this.lblMedio.TabIndex = 18;
            this.lblMedio.Text = "Medio";
            // 
            // lblDificil
            // 
            this.lblDificil.AutoSize = true;
            this.lblDificil.BackColor = System.Drawing.SystemColors.Control;
            this.lblDificil.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDificil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDificil.Location = new System.Drawing.Point(183, 122);
            this.lblDificil.Name = "lblDificil";
            this.lblDificil.Size = new System.Drawing.Size(67, 28);
            this.lblDificil.TabIndex = 19;
            this.lblDificil.Text = "Difícil";
            // 
            // lblDificultad
            // 
            this.lblDificultad.AutoSize = true;
            this.lblDificultad.BackColor = System.Drawing.SystemColors.Control;
            this.lblDificultad.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDificultad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDificultad.Location = new System.Drawing.Point(95, 84);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(99, 28);
            this.lblDificultad.TabIndex = 20;
            this.lblDificultad.Text = "Dificultad";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Location = new System.Drawing.Point(42, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 10);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::JuegoMedieval1._0.Properties.Resources.OIG_09ESSn4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(287, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 185);
            this.panel1.TabIndex = 22;
            // 
            // FormCrearJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoMedieval1._0.Properties.Resources.Textura_madera_6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(490, 297);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDificultad);
            this.Controls.Add(this.lblDificil);
            this.Controls.Add(this.lblMedio);
            this.Controls.Add(this.lblFacil);
            this.Controls.Add(this.tbDificultad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCrear);
            this.Name = "FormCrearJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCrearJugador_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDificultad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar tbDificultad;
        private System.Windows.Forms.Label lblFacil;
        private System.Windows.Forms.Label lblMedio;
        private System.Windows.Forms.Label lblDificil;
        private System.Windows.Forms.Label lblDificultad;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}