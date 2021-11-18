namespace Graficacion_Noé_Sicairos
{
    partial class ErickSicairos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErickSicairos));
            this.ptbLienzo = new System.Windows.Forms.PictureBox();
            this.mnsHerramientas = new System.Windows.Forms.MenuStrip();
            this.herrm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPunto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsLinea = new System.Windows.Forms.ToolStripMenuItem();
            this.lineaPoligonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSelectorDeColoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCirculo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsElipse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPoligonoIrregular = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLadosPoligono = new System.Windows.Forms.ToolStripTextBox();
            this.mnsPoligonoRegular = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTriangulo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCuadrado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPentagono = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsHexagono = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsOctagono = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsNonagono = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsDecagono = new System.Windows.Forms.ToolStripMenuItem();
            this.paletColor = new System.Windows.Forms.ColorDialog();
            this.coordenadas = new System.Windows.Forms.GroupBox();
            this.CoorY = new System.Windows.Forms.Label();
            this.CoorX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.gbColores = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnColorBlue = new System.Windows.Forms.Button();
            this.btnColorGreen = new System.Windows.Forms.Button();
            this.btnColorWhite = new System.Windows.Forms.Button();
            this.btnColorGray = new System.Windows.Forms.Button();
            this.btnColorRed = new System.Windows.Forms.Button();
            this.btnColorPink = new System.Windows.Forms.Button();
            this.btnColorBlack = new System.Windows.Forms.Button();
            this.btnColorYellow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnPaletColor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEscalamientoPositivo = new System.Windows.Forms.Button();
            this.btnEscalamientoNegativo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGRadosMas = new System.Windows.Forms.Button();
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.btnRotación = new System.Windows.Forms.Button();
            this.btnGradosMenos = new System.Windows.Forms.Button();
            this.btnTraslacion = new System.Windows.Forms.Button();
            this.btnMonoNieve = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEstiloPorSegmentos = new System.Windows.Forms.Button();
            this.btnEstiloNormal = new System.Windows.Forms.Button();
            this.btnEstiloPunteado = new System.Windows.Forms.Button();
            this.btnRellenar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTamañoGrande = new System.Windows.Forms.Button();
            this.btnTamañoPequeño = new System.Windows.Forms.Button();
            this.btnTamañoMediano = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLienzo)).BeginInit();
            this.mnsHerramientas.SuspendLayout();
            this.coordenadas.SuspendLayout();
            this.gbColores.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbLienzo
            // 
            resources.ApplyResources(this.ptbLienzo, "ptbLienzo");
            this.ptbLienzo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptbLienzo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ptbLienzo.Name = "ptbLienzo";
            this.ptbLienzo.TabStop = false;
            this.ptbLienzo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptbLienzo_MouseClick);
            this.ptbLienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbLienzo_MouseMove);
            // 
            // mnsHerramientas
            // 
            resources.ApplyResources(this.mnsHerramientas, "mnsHerramientas");
            this.mnsHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herrm,
            this.formas});
            this.mnsHerramientas.Name = "mnsHerramientas";
            this.mnsHerramientas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // herrm
            // 
            this.herrm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsPunto,
            this.mnsLinea,
            this.lineaPoligonalToolStripMenuItem,
            this.mnsSelectorDeColoresToolStripMenuItem});
            resources.ApplyResources(this.herrm, "herrm");
            this.herrm.Name = "herrm";
            // 
            // mnsPunto
            // 
            this.mnsPunto.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this.mnsPunto, "mnsPunto");
            this.mnsPunto.Name = "mnsPunto";
            this.mnsPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // mnsLinea
            // 
            resources.ApplyResources(this.mnsLinea, "mnsLinea");
            this.mnsLinea.Name = "mnsLinea";
            this.mnsLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // lineaPoligonalToolStripMenuItem
            // 
            resources.ApplyResources(this.lineaPoligonalToolStripMenuItem, "lineaPoligonalToolStripMenuItem");
            this.lineaPoligonalToolStripMenuItem.Name = "lineaPoligonalToolStripMenuItem";
            this.lineaPoligonalToolStripMenuItem.Click += new System.EventHandler(this.lineaPoligonalToolStripMenuItem_Click);
            // 
            // mnsSelectorDeColoresToolStripMenuItem
            // 
            resources.ApplyResources(this.mnsSelectorDeColoresToolStripMenuItem, "mnsSelectorDeColoresToolStripMenuItem");
            this.mnsSelectorDeColoresToolStripMenuItem.Name = "mnsSelectorDeColoresToolStripMenuItem";
            this.mnsSelectorDeColoresToolStripMenuItem.Click += new System.EventHandler(this.selectorDeColoresToolStripMenuItem_Click);
            // 
            // formas
            // 
            this.formas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCirculo,
            this.mnsElipse,
            this.mnsPoligonoIrregular,
            this.mnsPoligonoRegular});
            resources.ApplyResources(this.formas, "formas");
            this.formas.Name = "formas";
            // 
            // btnCirculo
            // 
            resources.ApplyResources(this.btnCirculo, "btnCirculo");
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // mnsElipse
            // 
            resources.ApplyResources(this.mnsElipse, "mnsElipse");
            this.mnsElipse.Name = "mnsElipse";
            this.mnsElipse.Click += new System.EventHandler(this.mnsElipse_Click);
            // 
            // mnsPoligonoIrregular
            // 
            this.mnsPoligonoIrregular.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtLadosPoligono});
            resources.ApplyResources(this.mnsPoligonoIrregular, "mnsPoligonoIrregular");
            this.mnsPoligonoIrregular.Name = "mnsPoligonoIrregular";
            this.mnsPoligonoIrregular.Click += new System.EventHandler(this.mnsPoligonoIrregular_Click);
            // 
            // txtLadosPoligono
            // 
            resources.ApplyResources(this.txtLadosPoligono, "txtLadosPoligono");
            this.txtLadosPoligono.Name = "txtLadosPoligono";
            // 
            // mnsPoligonoRegular
            // 
            this.mnsPoligonoRegular.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsTriangulo,
            this.mnsCuadrado,
            this.mnsPentagono,
            this.mnsHexagono,
            this.mnsOctagono,
            this.mnsNonagono,
            this.mnsDecagono});
            resources.ApplyResources(this.mnsPoligonoRegular, "mnsPoligonoRegular");
            this.mnsPoligonoRegular.Name = "mnsPoligonoRegular";
            this.mnsPoligonoRegular.Click += new System.EventHandler(this.mnsPoligonoRegular_Click);
            // 
            // mnsTriangulo
            // 
            resources.ApplyResources(this.mnsTriangulo, "mnsTriangulo");
            this.mnsTriangulo.Name = "mnsTriangulo";
            this.mnsTriangulo.Click += new System.EventHandler(this.mnsTriangulo_Click);
            // 
            // mnsCuadrado
            // 
            resources.ApplyResources(this.mnsCuadrado, "mnsCuadrado");
            this.mnsCuadrado.Name = "mnsCuadrado";
            this.mnsCuadrado.Click += new System.EventHandler(this.mnsCuadrado_Click);
            // 
            // mnsPentagono
            // 
            resources.ApplyResources(this.mnsPentagono, "mnsPentagono");
            this.mnsPentagono.Name = "mnsPentagono";
            this.mnsPentagono.Click += new System.EventHandler(this.mnsPentagono_Click);
            // 
            // mnsHexagono
            // 
            resources.ApplyResources(this.mnsHexagono, "mnsHexagono");
            this.mnsHexagono.Name = "mnsHexagono";
            this.mnsHexagono.Click += new System.EventHandler(this.mnsHexagono_Click);
            // 
            // mnsOctagono
            // 
            resources.ApplyResources(this.mnsOctagono, "mnsOctagono");
            this.mnsOctagono.Name = "mnsOctagono";
            this.mnsOctagono.Click += new System.EventHandler(this.mnsOctagono_Click);
            // 
            // mnsNonagono
            // 
            resources.ApplyResources(this.mnsNonagono, "mnsNonagono");
            this.mnsNonagono.Name = "mnsNonagono";
            this.mnsNonagono.Click += new System.EventHandler(this.mnsNonagono_Click);
            // 
            // mnsDecagono
            // 
            resources.ApplyResources(this.mnsDecagono, "mnsDecagono");
            this.mnsDecagono.Name = "mnsDecagono";
            this.mnsDecagono.Click += new System.EventHandler(this.mnsDecagono_Click);
            // 
            // coordenadas
            // 
            resources.ApplyResources(this.coordenadas, "coordenadas");
            this.coordenadas.Controls.Add(this.CoorY);
            this.coordenadas.Controls.Add(this.CoorX);
            this.coordenadas.Controls.Add(this.label2);
            this.coordenadas.Controls.Add(this.label1);
            this.coordenadas.Name = "coordenadas";
            this.coordenadas.TabStop = false;
            // 
            // CoorY
            // 
            resources.ApplyResources(this.CoorY, "CoorY");
            this.CoorY.Name = "CoorY";
            // 
            // CoorX
            // 
            resources.ApplyResources(this.CoorX, "CoorX");
            this.CoorX.Name = "CoorX";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnAyuda
            // 
            resources.ApplyResources(this.btnAyuda, "btnAyuda");
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // gbColores
            // 
            resources.ApplyResources(this.gbColores, "gbColores");
            this.gbColores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbColores.Controls.Add(this.label4);
            this.gbColores.Controls.Add(this.btnColorBlue);
            this.gbColores.Controls.Add(this.btnColorGreen);
            this.gbColores.Controls.Add(this.btnColorWhite);
            this.gbColores.Controls.Add(this.btnColorGray);
            this.gbColores.Controls.Add(this.btnColorRed);
            this.gbColores.Controls.Add(this.btnColorPink);
            this.gbColores.Controls.Add(this.btnColorBlack);
            this.gbColores.Controls.Add(this.btnColorYellow);
            this.gbColores.Controls.Add(this.label3);
            this.gbColores.Controls.Add(this.btnColor);
            this.gbColores.Controls.Add(this.btnPaletColor);
            this.gbColores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbColores.Name = "gbColores";
            this.gbColores.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnColorBlue
            // 
            this.btnColorBlue.BackColor = System.Drawing.Color.Blue;
            this.btnColorBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnColorBlue, "btnColorBlue");
            this.btnColorBlue.Name = "btnColorBlue";
            this.btnColorBlue.UseVisualStyleBackColor = false;
            this.btnColorBlue.Click += new System.EventHandler(this.btnColorBlue_Click);
            // 
            // btnColorGreen
            // 
            this.btnColorGreen.BackColor = System.Drawing.Color.Green;
            this.btnColorGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnColorGreen, "btnColorGreen");
            this.btnColorGreen.Name = "btnColorGreen";
            this.btnColorGreen.UseVisualStyleBackColor = false;
            this.btnColorGreen.Click += new System.EventHandler(this.btnColorGreen_Click);
            // 
            // btnColorWhite
            // 
            this.btnColorWhite.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnColorWhite, "btnColorWhite");
            this.btnColorWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorWhite.Name = "btnColorWhite";
            this.btnColorWhite.UseVisualStyleBackColor = false;
            this.btnColorWhite.Click += new System.EventHandler(this.btnColorWhite_Click);
            // 
            // btnColorGray
            // 
            this.btnColorGray.BackColor = System.Drawing.Color.Gray;
            this.btnColorGray.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnColorGray, "btnColorGray");
            this.btnColorGray.Name = "btnColorGray";
            this.btnColorGray.UseVisualStyleBackColor = false;
            this.btnColorGray.Click += new System.EventHandler(this.ptbColorGray_Click);
            // 
            // btnColorRed
            // 
            this.btnColorRed.BackColor = System.Drawing.Color.Red;
            this.btnColorRed.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnColorRed, "btnColorRed");
            this.btnColorRed.Name = "btnColorRed";
            this.btnColorRed.UseVisualStyleBackColor = false;
            this.btnColorRed.Click += new System.EventHandler(this.btnColorRed_Click);
            // 
            // btnColorPink
            // 
            this.btnColorPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnColorPink.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnColorPink, "btnColorPink");
            this.btnColorPink.Name = "btnColorPink";
            this.btnColorPink.UseVisualStyleBackColor = false;
            this.btnColorPink.Click += new System.EventHandler(this.btnColorPink_Click);
            // 
            // btnColorBlack
            // 
            this.btnColorBlack.BackColor = System.Drawing.Color.Black;
            this.btnColorBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnColorBlack, "btnColorBlack");
            this.btnColorBlack.Name = "btnColorBlack";
            this.btnColorBlack.UseVisualStyleBackColor = false;
            this.btnColorBlack.Click += new System.EventHandler(this.btnColorBlack_Click);
            // 
            // btnColorYellow
            // 
            this.btnColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnColorYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnColorYellow, "btnColorYellow");
            this.btnColorYellow.Name = "btnColorYellow";
            this.btnColorYellow.UseVisualStyleBackColor = false;
            this.btnColorYellow.Click += new System.EventHandler(this.btnColorYellow_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnColor, "btnColor");
            this.btnColor.Name = "btnColor";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click_1);
            // 
            // btnPaletColor
            // 
            this.btnPaletColor.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnPaletColor, "btnPaletColor");
            this.btnPaletColor.Name = "btnPaletColor";
            this.btnPaletColor.UseVisualStyleBackColor = true;
            this.btnPaletColor.Click += new System.EventHandler(this.btnPaletColor_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnTraslacion);
            this.panel1.Controls.Add(this.btnMonoNieve);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnRellenar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.mnsHerramientas);
            this.panel1.Controls.Add(this.coordenadas);
            this.panel1.Controls.Add(this.gbColores);
            this.panel1.Name = "panel1";
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.btnEscalamientoPositivo);
            this.groupBox4.Controls.Add(this.btnEscalamientoNegativo);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // btnEscalamientoPositivo
            // 
            resources.ApplyResources(this.btnEscalamientoPositivo, "btnEscalamientoPositivo");
            this.btnEscalamientoPositivo.Name = "btnEscalamientoPositivo";
            this.btnEscalamientoPositivo.UseVisualStyleBackColor = true;
            this.btnEscalamientoPositivo.Click += new System.EventHandler(this.btnEscalamientoPositivo_Click);
            // 
            // btnEscalamientoNegativo
            // 
            resources.ApplyResources(this.btnEscalamientoNegativo, "btnEscalamientoNegativo");
            this.btnEscalamientoNegativo.Name = "btnEscalamientoNegativo";
            this.btnEscalamientoNegativo.UseVisualStyleBackColor = true;
            this.btnEscalamientoNegativo.Click += new System.EventHandler(this.btnEscalamientoNegativo_Click);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.btnGRadosMas);
            this.groupBox3.Controls.Add(this.txtGrados);
            this.groupBox3.Controls.Add(this.btnRotación);
            this.groupBox3.Controls.Add(this.btnGradosMenos);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btnGRadosMas
            // 
            resources.ApplyResources(this.btnGRadosMas, "btnGRadosMas");
            this.btnGRadosMas.Name = "btnGRadosMas";
            this.btnGRadosMas.UseVisualStyleBackColor = true;
            this.btnGRadosMas.Click += new System.EventHandler(this.btnGRadosMas_Click);
            // 
            // txtGrados
            // 
            resources.ApplyResources(this.txtGrados, "txtGrados");
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.TextChanged += new System.EventHandler(this.txtGrados_TextChanged);
            // 
            // btnRotación
            // 
            resources.ApplyResources(this.btnRotación, "btnRotación");
            this.btnRotación.Name = "btnRotación";
            this.btnRotación.UseVisualStyleBackColor = true;
            this.btnRotación.Click += new System.EventHandler(this.btnRotación_Click);
            // 
            // btnGradosMenos
            // 
            resources.ApplyResources(this.btnGradosMenos, "btnGradosMenos");
            this.btnGradosMenos.Name = "btnGradosMenos";
            this.btnGradosMenos.UseVisualStyleBackColor = true;
            this.btnGradosMenos.Click += new System.EventHandler(this.btnGradosMenos_Click);
            // 
            // btnTraslacion
            // 
            resources.ApplyResources(this.btnTraslacion, "btnTraslacion");
            this.btnTraslacion.Name = "btnTraslacion";
            this.btnTraslacion.UseVisualStyleBackColor = true;
            this.btnTraslacion.Click += new System.EventHandler(this.btnTraslacion_Click_1);
            // 
            // btnMonoNieve
            // 
            this.btnMonoNieve.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnMonoNieve, "btnMonoNieve");
            this.btnMonoNieve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonoNieve.Name = "btnMonoNieve";
            this.btnMonoNieve.UseVisualStyleBackColor = false;
            this.btnMonoNieve.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.btnEstiloPorSegmentos);
            this.groupBox2.Controls.Add(this.btnEstiloNormal);
            this.groupBox2.Controls.Add(this.btnEstiloPunteado);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnEstiloPorSegmentos
            // 
            this.btnEstiloPorSegmentos.BackColor = System.Drawing.Color.White;
            this.btnEstiloPorSegmentos.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnEstiloPorSegmentos, "btnEstiloPorSegmentos");
            this.btnEstiloPorSegmentos.Name = "btnEstiloPorSegmentos";
            this.btnEstiloPorSegmentos.UseVisualStyleBackColor = false;
            this.btnEstiloPorSegmentos.Click += new System.EventHandler(this.btnEstiloPorSegmentos_Click);
            // 
            // btnEstiloNormal
            // 
            this.btnEstiloNormal.BackColor = System.Drawing.Color.White;
            this.btnEstiloNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstiloNormal.FlatAppearance.BorderSize = 0;
            this.btnEstiloNormal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnEstiloNormal, "btnEstiloNormal");
            this.btnEstiloNormal.Name = "btnEstiloNormal";
            this.btnEstiloNormal.UseVisualStyleBackColor = false;
            this.btnEstiloNormal.Click += new System.EventHandler(this.btnEstiloNormal_Click);
            // 
            // btnEstiloPunteado
            // 
            this.btnEstiloPunteado.BackColor = System.Drawing.Color.White;
            this.btnEstiloPunteado.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnEstiloPunteado, "btnEstiloPunteado");
            this.btnEstiloPunteado.Name = "btnEstiloPunteado";
            this.btnEstiloPunteado.UseVisualStyleBackColor = false;
            this.btnEstiloPunteado.Click += new System.EventHandler(this.btnEstiloPunteado_Click);
            // 
            // btnRellenar
            // 
            resources.ApplyResources(this.btnRellenar, "btnRellenar");
            this.btnRellenar.BackColor = System.Drawing.Color.White;
            this.btnRellenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.UseVisualStyleBackColor = false;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnTamañoGrande);
            this.groupBox1.Controls.Add(this.btnTamañoPequeño);
            this.groupBox1.Controls.Add(this.btnTamañoMediano);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnTamañoGrande
            // 
            this.btnTamañoGrande.BackColor = System.Drawing.Color.White;
            this.btnTamañoGrande.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTamañoGrande, "btnTamañoGrande");
            this.btnTamañoGrande.Name = "btnTamañoGrande";
            this.btnTamañoGrande.UseVisualStyleBackColor = false;
            this.btnTamañoGrande.Click += new System.EventHandler(this.btnTamañoGrande_Click);
            // 
            // btnTamañoPequeño
            // 
            this.btnTamañoPequeño.BackColor = System.Drawing.Color.White;
            this.btnTamañoPequeño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTamañoPequeño.FlatAppearance.BorderSize = 0;
            this.btnTamañoPequeño.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnTamañoPequeño, "btnTamañoPequeño");
            this.btnTamañoPequeño.Name = "btnTamañoPequeño";
            this.btnTamañoPequeño.UseVisualStyleBackColor = false;
            this.btnTamañoPequeño.Click += new System.EventHandler(this.btnTamañoPixel_Click);
            // 
            // btnTamañoMediano
            // 
            this.btnTamañoMediano.BackColor = System.Drawing.Color.White;
            this.btnTamañoMediano.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTamañoMediano, "btnTamañoMediano");
            this.btnTamañoMediano.Name = "btnTamañoMediano";
            this.btnTamañoMediano.UseVisualStyleBackColor = false;
            this.btnTamañoMediano.Click += new System.EventHandler(this.btnTamañoPixel1_Click);
            // 
            // btnLimpiar
            // 
            resources.ApplyResources(this.btnLimpiar, "btnLimpiar");
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripTextBox1
            // 
            resources.ApplyResources(this.toolStripTextBox1, "toolStripTextBox1");
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            // 
            // ErickSicairos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbLienzo);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErickSicairos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ptbLienzo)).EndInit();
            this.mnsHerramientas.ResumeLayout(false);
            this.mnsHerramientas.PerformLayout();
            this.coordenadas.ResumeLayout(false);
            this.coordenadas.PerformLayout();
            this.gbColores.ResumeLayout(false);
            this.gbColores.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbLienzo;
        private System.Windows.Forms.MenuStrip mnsHerramientas;
        private System.Windows.Forms.ToolStripMenuItem herrm;
        private System.Windows.Forms.ToolStripMenuItem mnsPunto;
        private System.Windows.Forms.ToolStripMenuItem mnsLinea;
        private System.Windows.Forms.ToolStripMenuItem formas;
        private System.Windows.Forms.ToolStripMenuItem btnCirculo;
        private System.Windows.Forms.ColorDialog paletColor;
        private System.Windows.Forms.GroupBox coordenadas;
        private System.Windows.Forms.Label CoorY;
        private System.Windows.Forms.Label CoorX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbColores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnPaletColor;
        private System.Windows.Forms.Button btnColorBlack;
        private System.Windows.Forms.Button btnColorRed;
        private System.Windows.Forms.Button btnColorBlue;
        private System.Windows.Forms.Button btnColorGreen;
        private System.Windows.Forms.Button btnColorWhite;
        private System.Windows.Forms.Button btnColorGray;
        private System.Windows.Forms.Button btnColorPink;
        private System.Windows.Forms.Button btnColorYellow;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTamañoMediano;
        private System.Windows.Forms.Button btnTamañoPequeño;
        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.Button btnTamañoGrande;
        private System.Windows.Forms.ToolStripMenuItem mnsSelectorDeColoresToolStripMenuItem;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEstiloPorSegmentos;
        private System.Windows.Forms.Button btnEstiloNormal;
        private System.Windows.Forms.Button btnEstiloPunteado;
        private System.Windows.Forms.ToolStripMenuItem mnsPoligonoIrregular;
        private System.Windows.Forms.ToolStripTextBox txtLadosPoligono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem lineaPoligonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsPoligonoRegular;
        private System.Windows.Forms.ToolStripMenuItem mnsTriangulo;
        private System.Windows.Forms.ToolStripMenuItem mnsCuadrado;
        private System.Windows.Forms.ToolStripMenuItem mnsPentagono;
        private System.Windows.Forms.ToolStripMenuItem mnsHexagono;
        private System.Windows.Forms.ToolStripMenuItem mnsOctagono;
        private System.Windows.Forms.ToolStripMenuItem mnsNonagono;
        private System.Windows.Forms.ToolStripMenuItem mnsDecagono;
        private System.Windows.Forms.ToolStripMenuItem mnsElipse;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMonoNieve;
        private System.Windows.Forms.Button btnTraslacion;
        private System.Windows.Forms.Button btnRotación;
        private System.Windows.Forms.TextBox txtGrados;
        private System.Windows.Forms.Button btnGradosMenos;
        private System.Windows.Forms.Button btnGRadosMas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEscalamientoPositivo;
        private System.Windows.Forms.Button btnEscalamientoNegativo;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

