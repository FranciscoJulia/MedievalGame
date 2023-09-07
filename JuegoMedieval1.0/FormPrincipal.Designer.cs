namespace JuegoMedieval1._0
{
    partial class FormPrincipal
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
            this.pbhambre = new System.Windows.Forms.ProgressBar();
            this.lblHambre = new System.Windows.Forms.Label();
            this.pbJugador = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMuestraVida = new System.Windows.Forms.Label();
            this.pbVida = new System.Windows.Forms.ProgressBar();
            this.lblVida = new System.Windows.Forms.Label();
            this.lblMuestraHambre = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblObjetos = new System.Windows.Forms.Label();
            this.lbObjetos = new System.Windows.Forms.ListBox();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.lbComida = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantMonedas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExplorar = new System.Windows.Forms.Button();
            this.btnTrabajar = new System.Windows.Forms.Button();
            this.btnComerciar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblCantExperiencia = new System.Windows.Forms.Label();
            this.lblcantDias = new System.Windows.Forms.Label();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.rtbDescComida = new System.Windows.Forms.RichTextBox();
            this.btnComer = new System.Windows.Forms.Button();
            this.pbComidas = new System.Windows.Forms.PictureBox();
            this.pbObjetos = new System.Windows.Forms.PictureBox();
            this.btnPasarDia = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnUsar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObjetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pbhambre
            // 
            this.pbhambre.Location = new System.Drawing.Point(208, 377);
            this.pbhambre.Maximum = 20;
            this.pbhambre.Name = "pbhambre";
            this.pbhambre.Size = new System.Drawing.Size(82, 20);
            this.pbhambre.TabIndex = 17;
            this.pbhambre.Value = 20;
            // 
            // lblHambre
            // 
            this.lblHambre.AutoSize = true;
            this.lblHambre.BackColor = System.Drawing.Color.DarkGray;
            this.lblHambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblHambre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHambre.Location = new System.Drawing.Point(294, 377);
            this.lblHambre.Name = "lblHambre";
            this.lblHambre.Size = new System.Drawing.Size(61, 18);
            this.lblHambre.TabIndex = 18;
            this.lblHambre.Text = "Hambre";
            // 
            // pbJugador
            // 
            this.pbJugador.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbJugador.Location = new System.Drawing.Point(150, 127);
            this.pbJugador.Name = "pbJugador";
            this.pbJugador.Size = new System.Drawing.Size(260, 280);
            this.pbJugador.TabIndex = 0;
            this.pbJugador.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::JuegoMedieval1._0.Properties.Resources.OIG_09ESSn4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblMuestraVida);
            this.panel1.Controls.Add(this.pbVida);
            this.panel1.Controls.Add(this.lblVida);
            this.panel1.Location = new System.Drawing.Point(164, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 233);
            this.panel1.TabIndex = 21;
            // 
            // lblMuestraVida
            // 
            this.lblMuestraVida.AutoSize = true;
            this.lblMuestraVida.BackColor = System.Drawing.Color.Transparent;
            this.lblMuestraVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMuestraVida.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMuestraVida.Location = new System.Drawing.Point(176, 189);
            this.lblMuestraVida.Name = "lblMuestraVida";
            this.lblMuestraVida.Size = new System.Drawing.Size(60, 18);
            this.lblMuestraVida.TabIndex = 22;
            this.lblMuestraVida.Text = "100/100";
            // 
            // pbVida
            // 
            this.pbVida.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbVida.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbVida.Location = new System.Drawing.Point(101, 210);
            this.pbVida.Name = "pbVida";
            this.pbVida.Size = new System.Drawing.Size(127, 18);
            this.pbVida.Step = 1;
            this.pbVida.TabIndex = 22;
            this.pbVida.Value = 100;
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.BackColor = System.Drawing.Color.Transparent;
            this.lblVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblVida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVida.Location = new System.Drawing.Point(64, 208);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(36, 18);
            this.lblVida.TabIndex = 22;
            this.lblVida.Text = "Vida";
            // 
            // lblMuestraHambre
            // 
            this.lblMuestraHambre.AutoSize = true;
            this.lblMuestraHambre.BackColor = System.Drawing.Color.DarkGray;
            this.lblMuestraHambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMuestraHambre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMuestraHambre.Location = new System.Drawing.Point(164, 378);
            this.lblMuestraHambre.Name = "lblMuestraHambre";
            this.lblMuestraHambre.Size = new System.Drawing.Size(44, 18);
            this.lblMuestraHambre.TabIndex = 22;
            this.lblMuestraHambre.Text = "20/20";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(151, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(105, 30);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre";
            // 
            // lblObjetos
            // 
            this.lblObjetos.AutoSize = true;
            this.lblObjetos.BackColor = System.Drawing.Color.Transparent;
            this.lblObjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblObjetos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblObjetos.Location = new System.Drawing.Point(15, 70);
            this.lblObjetos.Name = "lblObjetos";
            this.lblObjetos.Size = new System.Drawing.Size(60, 18);
            this.lblObjetos.TabIndex = 24;
            this.lblObjetos.Text = "Objetos";
            // 
            // lbObjetos
            // 
            this.lbObjetos.BackColor = System.Drawing.Color.Gray;
            this.lbObjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbObjetos.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbObjetos.FormattingEnabled = true;
            this.lbObjetos.ItemHeight = 15;
            this.lbObjetos.Location = new System.Drawing.Point(16, 98);
            this.lbObjetos.Name = "lbObjetos";
            this.lbObjetos.Size = new System.Drawing.Size(106, 169);
            this.lbObjetos.TabIndex = 25;
            this.lbObjetos.SelectedIndexChanged += new System.EventHandler(this.lbObjetos_SelectedIndexChanged);
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.BackColor = System.Drawing.Color.Silver;
            this.rtbDescripcion.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.rtbDescripcion.Location = new System.Drawing.Point(17, 267);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.ReadOnly = true;
            this.rtbDescripcion.Size = new System.Drawing.Size(104, 51);
            this.rtbDescripcion.TabIndex = 26;
            this.rtbDescripcion.Text = "";
            this.rtbDescripcion.Visible = false;
            // 
            // lbComida
            // 
            this.lbComida.BackColor = System.Drawing.Color.Gray;
            this.lbComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbComida.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbComida.FormattingEnabled = true;
            this.lbComida.ItemHeight = 15;
            this.lbComida.Location = new System.Drawing.Point(17, 361);
            this.lbComida.Name = "lbComida";
            this.lbComida.Size = new System.Drawing.Size(106, 94);
            this.lbComida.TabIndex = 27;
            this.lbComida.SelectedIndexChanged += new System.EventHandler(this.lbComida_SelectedIndexChanged);
            this.lbComida.DoubleClick += new System.EventHandler(this.btnComer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Comida";
            // 
            // lblCantMonedas
            // 
            this.lblCantMonedas.AutoSize = true;
            this.lblCantMonedas.BackColor = System.Drawing.Color.Transparent;
            this.lblCantMonedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantMonedas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantMonedas.Location = new System.Drawing.Point(220, 417);
            this.lblCantMonedas.Name = "lblCantMonedas";
            this.lblCantMonedas.Size = new System.Drawing.Size(142, 25);
            this.lblCantMonedas.TabIndex = 29;
            this.lblCantMonedas.Text = "cantMonedas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::JuegoMedieval1._0.Properties.Resources.coins_clipart_for_teachers_medieval_coin_6;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(184, 413);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btnExplorar
            // 
            this.btnExplorar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnExplorar.Font = new System.Drawing.Font("Perpetua", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplorar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExplorar.Location = new System.Drawing.Point(422, 127);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(147, 55);
            this.btnExplorar.TabIndex = 31;
            this.btnExplorar.Text = "Explorar";
            this.btnExplorar.UseVisualStyleBackColor = false;
            this.btnExplorar.Click += new System.EventHandler(this.btnExplorar_Click);
            // 
            // btnTrabajar
            // 
            this.btnTrabajar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnTrabajar.Font = new System.Drawing.Font("Perpetua", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTrabajar.Location = new System.Drawing.Point(422, 188);
            this.btnTrabajar.Name = "btnTrabajar";
            this.btnTrabajar.Size = new System.Drawing.Size(147, 55);
            this.btnTrabajar.TabIndex = 32;
            this.btnTrabajar.Text = "Trabajar";
            this.btnTrabajar.UseVisualStyleBackColor = false;
            this.btnTrabajar.Click += new System.EventHandler(this.btnTrabajar_Click);
            // 
            // btnComerciar
            // 
            this.btnComerciar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnComerciar.Font = new System.Drawing.Font("Perpetua", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComerciar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnComerciar.Location = new System.Drawing.Point(421, 249);
            this.btnComerciar.Name = "btnComerciar";
            this.btnComerciar.Size = new System.Drawing.Size(147, 55);
            this.btnComerciar.TabIndex = 33;
            this.btnComerciar.Text = "Comerciar";
            this.btnComerciar.UseVisualStyleBackColor = false;
            this.btnComerciar.Click += new System.EventHandler(this.btnComerciar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FloralWhite;
            this.btnSalir.Font = new System.Drawing.Font("Perpetua", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSalir.Location = new System.Drawing.Point(451, 524);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 48);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGuardar.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGuardar.Location = new System.Drawing.Point(324, 524);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 48);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnActualizar.Font = new System.Drawing.Font("Perpetua", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnActualizar.Location = new System.Drawing.Point(156, 523);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(162, 48);
            this.btnActualizar.TabIndex = 36;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblCantExperiencia
            // 
            this.lblCantExperiencia.AutoSize = true;
            this.lblCantExperiencia.BackColor = System.Drawing.Color.Transparent;
            this.lblCantExperiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantExperiencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantExperiencia.Location = new System.Drawing.Point(220, 459);
            this.lblCantExperiencia.Name = "lblCantExperiencia";
            this.lblCantExperiencia.Size = new System.Drawing.Size(166, 25);
            this.lblCantExperiencia.TabIndex = 37;
            this.lblCantExperiencia.Text = "cantExperiencia";
            // 
            // lblcantDias
            // 
            this.lblcantDias.AutoSize = true;
            this.lblcantDias.BackColor = System.Drawing.Color.Transparent;
            this.lblcantDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantDias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcantDias.Location = new System.Drawing.Point(213, 30);
            this.lblcantDias.Name = "lblcantDias";
            this.lblcantDias.Size = new System.Drawing.Size(93, 42);
            this.lblcantDias.TabIndex = 38;
            this.lblcantDias.Text = "Días";
            // 
            // pbInfo
            // 
            this.pbInfo.BackColor = System.Drawing.Color.Transparent;
            this.pbInfo.BackgroundImage = global::JuegoMedieval1._0.Properties.Resources.information_icon;
            this.pbInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInfo.Location = new System.Drawing.Point(535, 9);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(40, 40);
            this.pbInfo.TabIndex = 39;
            this.pbInfo.TabStop = false;
            this.pbInfo.Click += new System.EventHandler(this.pbInfo_Click);
            // 
            // rtbDescComida
            // 
            this.rtbDescComida.BackColor = System.Drawing.Color.Silver;
            this.rtbDescComida.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbDescComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.rtbDescComida.Location = new System.Drawing.Point(18, 455);
            this.rtbDescComida.Name = "rtbDescComida";
            this.rtbDescComida.ReadOnly = true;
            this.rtbDescComida.Size = new System.Drawing.Size(104, 36);
            this.rtbDescComida.TabIndex = 26;
            this.rtbDescComida.Text = "";
            this.rtbDescComida.Visible = false;
            // 
            // btnComer
            // 
            this.btnComer.BackColor = System.Drawing.Color.FloralWhite;
            this.btnComer.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnComer.Location = new System.Drawing.Point(20, 460);
            this.btnComer.Name = "btnComer";
            this.btnComer.Size = new System.Drawing.Size(103, 31);
            this.btnComer.TabIndex = 40;
            this.btnComer.Text = "Comer";
            this.btnComer.UseVisualStyleBackColor = false;
            this.btnComer.Click += new System.EventHandler(this.btnComer_Click);
            // 
            // pbComidas
            // 
            this.pbComidas.BackColor = System.Drawing.Color.Transparent;
            this.pbComidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbComidas.Location = new System.Drawing.Point(84, 325);
            this.pbComidas.Name = "pbComidas";
            this.pbComidas.Size = new System.Drawing.Size(35, 35);
            this.pbComidas.TabIndex = 41;
            this.pbComidas.TabStop = false;
            this.pbComidas.Visible = false;
            // 
            // pbObjetos
            // 
            this.pbObjetos.BackColor = System.Drawing.Color.Transparent;
            this.pbObjetos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbObjetos.Location = new System.Drawing.Point(83, 61);
            this.pbObjetos.Name = "pbObjetos";
            this.pbObjetos.Size = new System.Drawing.Size(35, 35);
            this.pbObjetos.TabIndex = 42;
            this.pbObjetos.TabStop = false;
            this.pbObjetos.Visible = false;
            // 
            // btnPasarDia
            // 
            this.btnPasarDia.BackColor = System.Drawing.Color.FloralWhite;
            this.btnPasarDia.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarDia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPasarDia.Location = new System.Drawing.Point(353, 36);
            this.btnPasarDia.Name = "btnPasarDia";
            this.btnPasarDia.Size = new System.Drawing.Size(109, 35);
            this.btnPasarDia.TabIndex = 43;
            this.btnPasarDia.Text = "Dormir";
            this.btnPasarDia.UseVisualStyleBackColor = false;
            this.btnPasarDia.Click += new System.EventHandler(this.btnPasarDia_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::JuegoMedieval1._0.Properties.Resources.estrellaXP;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(184, 454);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.TabIndex = 95;
            this.pictureBox5.TabStop = false;
            // 
            // btnUsar
            // 
            this.btnUsar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnUsar.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUsar.Location = new System.Drawing.Point(17, 18);
            this.btnUsar.Name = "btnUsar";
            this.btnUsar.Size = new System.Drawing.Size(103, 31);
            this.btnUsar.TabIndex = 96;
            this.btnUsar.Text = "Usar";
            this.btnUsar.UseVisualStyleBackColor = false;
            this.btnUsar.Visible = false;
            this.btnUsar.Click += new System.EventHandler(this.btnUsar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoMedieval1._0.Properties.Resources.casa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 584);
            this.ControlBox = false;
            this.Controls.Add(this.btnUsar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnPasarDia);
            this.Controls.Add(this.pbObjetos);
            this.Controls.Add(this.pbComidas);
            this.Controls.Add(this.btnComer);
            this.Controls.Add(this.rtbDescComida);
            this.Controls.Add(this.pbInfo);
            this.Controls.Add(this.lblcantDias);
            this.Controls.Add(this.lblCantExperiencia);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnComerciar);
            this.Controls.Add(this.btnTrabajar);
            this.Controls.Add(this.btnExplorar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCantMonedas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbComida);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.lbObjetos);
            this.Controls.Add(this.lblObjetos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMuestraHambre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHambre);
            this.Controls.Add(this.pbhambre);
            this.Controls.Add(this.pbJugador);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObjetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbJugador;
        private System.Windows.Forms.ProgressBar pbhambre;
        private System.Windows.Forms.Label lblHambre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMuestraVida;
        private System.Windows.Forms.ProgressBar pbVida;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Label lblMuestraHambre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblObjetos;
        private System.Windows.Forms.ListBox lbObjetos;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.ListBox lbComida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantMonedas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.Button btnTrabajar;
        private System.Windows.Forms.Button btnComerciar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblCantExperiencia;
        private System.Windows.Forms.Label lblcantDias;
        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.RichTextBox rtbDescComida;
        private System.Windows.Forms.Button btnComer;
        private System.Windows.Forms.PictureBox pbComidas;
        private System.Windows.Forms.PictureBox pbObjetos;
        private System.Windows.Forms.Button btnPasarDia;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnUsar;
    }
}