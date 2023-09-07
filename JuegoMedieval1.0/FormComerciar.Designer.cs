namespace JuegoMedieval1._0
{
    partial class FormComerciar
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
            this.lbComprarObjetos = new System.Windows.Forms.ListBox();
            this.lbVender = new System.Windows.Forms.ListBox();
            this.lbComprarComida = new System.Windows.Forms.ListBox();
            this.lblObjetos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbObjetos = new System.Windows.Forms.PictureBox();
            this.lblMuestraPrecio = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lbTuComida = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.pbVender = new System.Windows.Forms.PictureBox();
            this.lblcantDias = new System.Windows.Forms.Label();
            this.lblCantExperiencia = new System.Windows.Forms.Label();
            this.lblCantMonedas = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblMuestraVida = new System.Windows.Forms.Label();
            this.pbVida = new System.Windows.Forms.ProgressBar();
            this.lblVida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbObjetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbComprarObjetos
            // 
            this.lbComprarObjetos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbComprarObjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbComprarObjetos.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbComprarObjetos.FormattingEnabled = true;
            this.lbComprarObjetos.ItemHeight = 15;
            this.lbComprarObjetos.Location = new System.Drawing.Point(23, 55);
            this.lbComprarObjetos.Name = "lbComprarObjetos";
            this.lbComprarObjetos.Size = new System.Drawing.Size(116, 199);
            this.lbComprarObjetos.TabIndex = 27;
            this.lbComprarObjetos.SelectedIndexChanged += new System.EventHandler(this.lbComprarObjetos_SelectedIndexChanged);
            // 
            // lbVender
            // 
            this.lbVender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbVender.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbVender.FormattingEnabled = true;
            this.lbVender.ItemHeight = 15;
            this.lbVender.Location = new System.Drawing.Point(334, 55);
            this.lbVender.Name = "lbVender";
            this.lbVender.Size = new System.Drawing.Size(116, 214);
            this.lbVender.TabIndex = 28;
            this.lbVender.SelectedIndexChanged += new System.EventHandler(this.lbVender_SelectedIndexChanged);
            // 
            // lbComprarComida
            // 
            this.lbComprarComida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbComprarComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbComprarComida.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbComprarComida.FormattingEnabled = true;
            this.lbComprarComida.ItemHeight = 15;
            this.lbComprarComida.Location = new System.Drawing.Point(22, 289);
            this.lbComprarComida.Name = "lbComprarComida";
            this.lbComprarComida.Size = new System.Drawing.Size(116, 124);
            this.lbComprarComida.TabIndex = 29;
            this.lbComprarComida.SelectedIndexChanged += new System.EventHandler(this.lbComprarComida_SelectedIndexChanged);
            // 
            // lblObjetos
            // 
            this.lblObjetos.AutoSize = true;
            this.lblObjetos.BackColor = System.Drawing.Color.Transparent;
            this.lblObjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblObjetos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblObjetos.Location = new System.Drawing.Point(20, 25);
            this.lblObjetos.Name = "lblObjetos";
            this.lblObjetos.Size = new System.Drawing.Size(105, 18);
            this.lblObjetos.TabIndex = 30;
            this.lblObjetos.Text = "Tienda objetos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tienda comida";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnComprar.Enabled = false;
            this.btnComprar.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnComprar.Location = new System.Drawing.Point(160, 55);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(120, 43);
            this.btnComprar.TabIndex = 41;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(331, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Mis objetos";
            // 
            // pbObjetos
            // 
            this.pbObjetos.BackColor = System.Drawing.Color.Transparent;
            this.pbObjetos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbObjetos.Location = new System.Drawing.Point(164, 104);
            this.pbObjetos.Name = "pbObjetos";
            this.pbObjetos.Size = new System.Drawing.Size(110, 110);
            this.pbObjetos.TabIndex = 43;
            this.pbObjetos.TabStop = false;
            this.pbObjetos.Visible = false;
            // 
            // lblMuestraPrecio
            // 
            this.lblMuestraPrecio.AutoSize = true;
            this.lblMuestraPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblMuestraPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMuestraPrecio.ForeColor = System.Drawing.SystemColors.Info;
            this.lblMuestraPrecio.Location = new System.Drawing.Point(158, 222);
            this.lblMuestraPrecio.Name = "lblMuestraPrecio";
            this.lblMuestraPrecio.Size = new System.Drawing.Size(59, 18);
            this.lblMuestraPrecio.TabIndex = 44;
            this.lblMuestraPrecio.Text = "Precio: ";
            this.lblMuestraPrecio.Visible = false;
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblInfo1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo1.Location = new System.Drawing.Point(158, 242);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(40, 18);
            this.lblInfo1.TabIndex = 45;
            this.lblInfo1.Text = "Info1";
            this.lblInfo1.Visible = false;
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblInfo2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo2.Location = new System.Drawing.Point(158, 261);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(40, 18);
            this.lblInfo2.TabIndex = 46;
            this.lblInfo2.Text = "Info2";
            this.lblInfo2.Visible = false;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FloralWhite;
            this.btnVender.Enabled = false;
            this.btnVender.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnVender.Location = new System.Drawing.Point(466, 55);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(120, 43);
            this.btnVender.TabIndex = 47;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FloralWhite;
            this.btnVolver.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnVolver.Location = new System.Drawing.Point(492, 379);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 43);
            this.btnVolver.TabIndex = 48;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lbTuComida
            // 
            this.lbTuComida.BackColor = System.Drawing.Color.Gray;
            this.lbTuComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbTuComida.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbTuComida.FormattingEnabled = true;
            this.lbTuComida.ItemHeight = 15;
            this.lbTuComida.Location = new System.Drawing.Point(161, 319);
            this.lbTuComida.Name = "lbTuComida";
            this.lbTuComida.Size = new System.Drawing.Size(106, 94);
            this.lbTuComida.TabIndex = 49;
            this.lbTuComida.SelectedIndexChanged += new System.EventHandler(this.lbTuComida_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(153, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tus comestibles:";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblPrecioVenta.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPrecioVenta.Location = new System.Drawing.Point(465, 221);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(59, 18);
            this.lblPrecioVenta.TabIndex = 52;
            this.lblPrecioVenta.Text = "Precio: ";
            this.lblPrecioVenta.Visible = false;
            // 
            // pbVender
            // 
            this.pbVender.BackColor = System.Drawing.Color.Transparent;
            this.pbVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbVender.Location = new System.Drawing.Point(470, 105);
            this.pbVender.Name = "pbVender";
            this.pbVender.Size = new System.Drawing.Size(110, 110);
            this.pbVender.TabIndex = 51;
            this.pbVender.TabStop = false;
            this.pbVender.Visible = false;
            // 
            // lblcantDias
            // 
            this.lblcantDias.AutoSize = true;
            this.lblcantDias.BackColor = System.Drawing.Color.Transparent;
            this.lblcantDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantDias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcantDias.Location = new System.Drawing.Point(279, 386);
            this.lblcantDias.Name = "lblcantDias";
            this.lblcantDias.Size = new System.Drawing.Size(55, 25);
            this.lblcantDias.TabIndex = 93;
            this.lblcantDias.Text = "Días";
            // 
            // lblCantExperiencia
            // 
            this.lblCantExperiencia.AutoSize = true;
            this.lblCantExperiencia.BackColor = System.Drawing.Color.Transparent;
            this.lblCantExperiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantExperiencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantExperiencia.Location = new System.Drawing.Point(308, 310);
            this.lblCantExperiencia.Name = "lblCantExperiencia";
            this.lblCantExperiencia.Size = new System.Drawing.Size(166, 25);
            this.lblCantExperiencia.TabIndex = 92;
            this.lblCantExperiencia.Text = "cantExperiencia";
            // 
            // lblCantMonedas
            // 
            this.lblCantMonedas.AutoSize = true;
            this.lblCantMonedas.BackColor = System.Drawing.Color.Transparent;
            this.lblCantMonedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantMonedas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantMonedas.Location = new System.Drawing.Point(309, 283);
            this.lblCantMonedas.Name = "lblCantMonedas";
            this.lblCantMonedas.Size = new System.Drawing.Size(124, 24);
            this.lblCantMonedas.TabIndex = 91;
            this.lblCantMonedas.Text = "cantMonedas";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::JuegoMedieval1._0.Properties.Resources.coins_clipart_for_teachers_medieval_coin_6;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(284, 282);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 90;
            this.pictureBox4.TabStop = false;
            // 
            // lblMuestraVida
            // 
            this.lblMuestraVida.AutoSize = true;
            this.lblMuestraVida.BackColor = System.Drawing.Color.Transparent;
            this.lblMuestraVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMuestraVida.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMuestraVida.Location = new System.Drawing.Point(387, 348);
            this.lblMuestraVida.Name = "lblMuestraVida";
            this.lblMuestraVida.Size = new System.Drawing.Size(60, 18);
            this.lblMuestraVida.TabIndex = 89;
            this.lblMuestraVida.Text = "100/100";
            // 
            // pbVida
            // 
            this.pbVida.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbVida.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbVida.Location = new System.Drawing.Point(315, 348);
            this.pbVida.Name = "pbVida";
            this.pbVida.Size = new System.Drawing.Size(72, 18);
            this.pbVida.Step = 1;
            this.pbVida.TabIndex = 88;
            this.pbVida.Value = 100;
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.BackColor = System.Drawing.Color.Transparent;
            this.lblVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblVida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVida.Location = new System.Drawing.Point(281, 347);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(40, 18);
            this.lblVida.TabIndex = 87;
            this.lblVida.Text = "Vida:";
            // 
            // FormComerciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoMedieval1._0.Properties.Resources.FondoComercio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 434);
            this.ControlBox = false;
            this.Controls.Add(this.lblcantDias);
            this.Controls.Add(this.lblCantExperiencia);
            this.Controls.Add(this.lblCantMonedas);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblMuestraVida);
            this.Controls.Add(this.pbVida);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.pbVender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTuComida);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.lblMuestraPrecio);
            this.Controls.Add(this.pbObjetos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblObjetos);
            this.Controls.Add(this.lbComprarComida);
            this.Controls.Add(this.lbVender);
            this.Controls.Add(this.lbComprarObjetos);
            this.MaximumSize = new System.Drawing.Size(620, 450);
            this.MinimumSize = new System.Drawing.Size(620, 450);
            this.Name = "FormComerciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormComerciar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbObjetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbComprarObjetos;
        private System.Windows.Forms.ListBox lbVender;
        private System.Windows.Forms.ListBox lbComprarComida;
        private System.Windows.Forms.Label lblObjetos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbObjetos;
        private System.Windows.Forms.Label lblMuestraPrecio;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ListBox lbTuComida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.PictureBox pbVender;
        private System.Windows.Forms.Label lblcantDias;
        private System.Windows.Forms.Label lblCantExperiencia;
        private System.Windows.Forms.Label lblCantMonedas;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblMuestraVida;
        private System.Windows.Forms.ProgressBar pbVida;
        private System.Windows.Forms.Label lblVida;
    }
}