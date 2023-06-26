namespace carpinteria_alum
{
    partial class Presupuestos_DANISA
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_ListadoProd = new System.Windows.Forms.ComboBox();
            this.TB_kglineal = new System.Windows.Forms.TextBox();
            this.TB_alto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TB_ancho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RB_colorNEG = new System.Windows.Forms.RadioButton();
            this.RB_colorAN = new System.Windows.Forms.RadioButton();
            this.RB_colorBLAN = new System.Windows.Forms.RadioButton();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.B_Limpiar = new System.Windows.Forms.Button();
            this.B_CerrarTKT = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LB_Listado = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CHCKB_sinvidrio = new System.Windows.Forms.CheckBox();
            this.RB_Revestimiento = new System.Windows.Forms.RadioButton();
            this.RB_3mm = new System.Windows.Forms.RadioButton();
            this.RB_DVH5 = new System.Windows.Forms.RadioButton();
            this.RB_DVH4 = new System.Windows.Forms.RadioButton();
            this.RB_5mm = new System.Windows.Forms.RadioButton();
            this.RB_4mm = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_precio4mm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_altoVID = new System.Windows.Forms.TextBox();
            this.TB_anchoVID = new System.Windows.Forms.TextBox();
            this.CHCKB_VidPerso = new System.Windows.Forms.CheckBox();
            this.TB_Cantidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.B_Agregar = new System.Windows.Forms.Button();
            this.CHCKB_Colocacion = new System.Windows.Forms.CheckBox();
            this.CHCKB_Compacto = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CHCKB_Mec_osc = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(727, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CB_ListadoProd);
            this.groupBox1.Controls.Add(this.TB_kglineal);
            this.groupBox1.Controls.Add(this.TB_alto);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.TB_ancho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "cotizacion y caracteristicas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prestacion :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CB_ListadoProd
            // 
            this.CB_ListadoProd.FormattingEnabled = true;
            this.CB_ListadoProd.Items.AddRange(new object[] {
            "Modena Ventana Corrediza 90° kg: 8.9",
            "Modena Ventana Corrediza 45° kg: 12",
            "Modena Ventana Paño fijo kg: 4.52",
            "Modena Ventana Rebatir kg: 8.1",
            "Modena Puerta de Rebatir kg: 9.5",
            "Vesta Ventana de Rebatir kg: 6.88 ",
            "Vesta Ventana de Paño fijo kg: 4.16",
            "Vesta Ventana de Rebatir2 kg: 9.44",
            "Vesta Puerta de Rebatir kg: 7.56",
            "Herrero Ventana Corrediza kg: 7.76 ",
            "Herrero Ventana Paño fijo kg: 4.20",
            "Herrero Puerta de Rebatir kg: 6.25",
            "30 new Ventana Paño fijo kg: 6.00",
            "30 new Ventana de Rebatir kg: 10.00",
            "30 new Ventana Corrediza Kg: 14.00",
            "30 new Puerta de Rebatir  Kg : 19.20"});
            this.CB_ListadoProd.Location = new System.Drawing.Point(26, 120);
            this.CB_ListadoProd.Name = "CB_ListadoProd";
            this.CB_ListadoProd.Size = new System.Drawing.Size(283, 21);
            this.CB_ListadoProd.TabIndex = 0;
            // 
            // TB_kglineal
            // 
            this.TB_kglineal.Location = new System.Drawing.Point(108, 17);
            this.TB_kglineal.Name = "TB_kglineal";
            this.TB_kglineal.Size = new System.Drawing.Size(46, 20);
            this.TB_kglineal.TabIndex = 8;
            this.TB_kglineal.Text = "933";
            this.TB_kglineal.TextChanged += new System.EventHandler(this.TB_dolar_TextChanged);
            // 
            // TB_alto
            // 
            this.TB_alto.Location = new System.Drawing.Point(154, 49);
            this.TB_alto.Name = "TB_alto";
            this.TB_alto.Size = new System.Drawing.Size(46, 20);
            this.TB_alto.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(258, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 6;
            // 
            // TB_ancho
            // 
            this.TB_ancho.Location = new System.Drawing.Point(63, 48);
            this.TB_ancho.Name = "TB_ancho";
            this.TB_ancho.Size = new System.Drawing.Size(46, 20);
            this.TB_ancho.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ancho :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alto :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MTS2 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(81, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ingrese las medidas en milimetros";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio kg Lineal: ";
            // 
            // RB_colorNEG
            // 
            this.RB_colorNEG.AutoSize = true;
            this.RB_colorNEG.Location = new System.Drawing.Point(136, 31);
            this.RB_colorNEG.Name = "RB_colorNEG";
            this.RB_colorNEG.Size = new System.Drawing.Size(54, 17);
            this.RB_colorNEG.TabIndex = 12;
            this.RB_colorNEG.Text = "Negro";
            this.RB_colorNEG.UseVisualStyleBackColor = true;
            // 
            // RB_colorAN
            // 
            this.RB_colorAN.AutoSize = true;
            this.RB_colorAN.Location = new System.Drawing.Point(240, 31);
            this.RB_colorAN.Name = "RB_colorAN";
            this.RB_colorAN.Size = new System.Drawing.Size(75, 17);
            this.RB_colorAN.TabIndex = 11;
            this.RB_colorAN.Text = "Anodizado";
            this.RB_colorAN.UseVisualStyleBackColor = true;
            // 
            // RB_colorBLAN
            // 
            this.RB_colorBLAN.AutoSize = true;
            this.RB_colorBLAN.Checked = true;
            this.RB_colorBLAN.Location = new System.Drawing.Point(19, 31);
            this.RB_colorBLAN.Name = "RB_colorBLAN";
            this.RB_colorBLAN.Size = new System.Drawing.Size(58, 17);
            this.RB_colorBLAN.TabIndex = 9;
            this.RB_colorBLAN.TabStop = true;
            this.RB_colorBLAN.Text = "Blanco";
            this.RB_colorBLAN.UseVisualStyleBackColor = true;
            this.RB_colorBLAN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.label15);
            this.groupbox2.Controls.Add(this.B_Limpiar);
            this.groupbox2.Controls.Add(this.B_CerrarTKT);
            this.groupbox2.Controls.Add(this.label14);
            this.groupbox2.Controls.Add(this.label13);
            this.groupbox2.Controls.Add(this.LB_Listado);
            this.groupbox2.Location = new System.Drawing.Point(390, 13);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(470, 594);
            this.groupbox2.TabIndex = 2;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "Presupuesto";
            this.groupbox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(243, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Cantidad";
            // 
            // B_Limpiar
            // 
            this.B_Limpiar.Location = new System.Drawing.Point(316, 499);
            this.B_Limpiar.Name = "B_Limpiar";
            this.B_Limpiar.Size = new System.Drawing.Size(136, 30);
            this.B_Limpiar.TabIndex = 18;
            this.B_Limpiar.Text = "&Limpiar";
            this.B_Limpiar.UseVisualStyleBackColor = true;
            this.B_Limpiar.Click += new System.EventHandler(this.B_Limpiar_Click);
            // 
            // B_CerrarTKT
            // 
            this.B_CerrarTKT.Location = new System.Drawing.Point(15, 499);
            this.B_CerrarTKT.Name = "B_CerrarTKT";
            this.B_CerrarTKT.Size = new System.Drawing.Size(136, 30);
            this.B_CerrarTKT.TabIndex = 17;
            this.B_CerrarTKT.Text = "Cerrar &Tiquet";
            this.B_CerrarTKT.UseVisualStyleBackColor = true;
            this.B_CerrarTKT.Click += new System.EventHandler(this.B_CerrarTKT_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(357, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Subtotal";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Descripcion";
            // 
            // LB_Listado
            // 
            this.LB_Listado.FormattingEnabled = true;
            this.LB_Listado.Location = new System.Drawing.Point(6, 56);
            this.LB_Listado.Name = "LB_Listado";
            this.LB_Listado.Size = new System.Drawing.Size(458, 433);
            this.LB_Listado.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RB_colorAN);
            this.groupBox3.Controls.Add(this.RB_colorNEG);
            this.groupBox3.Controls.Add(this.RB_colorBLAN);
            this.groupBox3.Location = new System.Drawing.Point(28, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 55);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color del aluminio";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CHCKB_sinvidrio);
            this.groupBox4.Controls.Add(this.RB_Revestimiento);
            this.groupBox4.Controls.Add(this.RB_3mm);
            this.groupBox4.Controls.Add(this.RB_DVH5);
            this.groupBox4.Controls.Add(this.RB_DVH4);
            this.groupBox4.Controls.Add(this.RB_5mm);
            this.groupBox4.Controls.Add(this.RB_4mm);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.TB_precio4mm);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.TB_altoVID);
            this.groupBox4.Controls.Add(this.TB_anchoVID);
            this.groupBox4.Controls.Add(this.CHCKB_VidPerso);
            this.groupBox4.Location = new System.Drawing.Point(26, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 193);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vidrios y Accesorios";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // CHCKB_sinvidrio
            // 
            this.CHCKB_sinvidrio.AutoSize = true;
            this.CHCKB_sinvidrio.Location = new System.Drawing.Point(26, 28);
            this.CHCKB_sinvidrio.Name = "CHCKB_sinvidrio";
            this.CHCKB_sinvidrio.Size = new System.Drawing.Size(72, 17);
            this.CHCKB_sinvidrio.TabIndex = 14;
            this.CHCKB_sinvidrio.Text = "Sin vidrio ";
            this.CHCKB_sinvidrio.UseVisualStyleBackColor = true;
            // 
            // RB_Revestimiento
            // 
            this.RB_Revestimiento.AutoSize = true;
            this.RB_Revestimiento.Location = new System.Drawing.Point(24, 169);
            this.RB_Revestimiento.Name = "RB_Revestimiento";
            this.RB_Revestimiento.Size = new System.Drawing.Size(92, 17);
            this.RB_Revestimiento.TabIndex = 13;
            this.RB_Revestimiento.TabStop = true;
            this.RB_Revestimiento.Text = "Revestimiento";
            this.RB_Revestimiento.UseVisualStyleBackColor = true;
            // 
            // RB_3mm
            // 
            this.RB_3mm.AutoSize = true;
            this.RB_3mm.Location = new System.Drawing.Point(221, 122);
            this.RB_3mm.Name = "RB_3mm";
            this.RB_3mm.Size = new System.Drawing.Size(92, 17);
            this.RB_3mm.TabIndex = 12;
            this.RB_3mm.Text = "Laminado 3+3";
            this.RB_3mm.UseVisualStyleBackColor = true;
            // 
            // RB_DVH5
            // 
            this.RB_DVH5.AutoSize = true;
            this.RB_DVH5.Location = new System.Drawing.Point(220, 169);
            this.RB_DVH5.Name = "RB_DVH5";
            this.RB_DVH5.Size = new System.Drawing.Size(81, 17);
            this.RB_DVH5.TabIndex = 11;
            this.RB_DVH5.Text = "DVH 5+9+4";
            this.RB_DVH5.UseVisualStyleBackColor = true;
            this.RB_DVH5.CheckedChanged += new System.EventHandler(this.RB_DVH5_CheckedChanged);
            // 
            // RB_DVH4
            // 
            this.RB_DVH4.AutoSize = true;
            this.RB_DVH4.Location = new System.Drawing.Point(221, 146);
            this.RB_DVH4.Name = "RB_DVH4";
            this.RB_DVH4.Size = new System.Drawing.Size(87, 17);
            this.RB_DVH4.TabIndex = 10;
            this.RB_DVH4.Text = "DVH 4+12+4";
            this.RB_DVH4.UseVisualStyleBackColor = true;
            this.RB_DVH4.CheckedChanged += new System.EventHandler(this.RB_DVH4_CheckedChanged);
            // 
            // RB_5mm
            // 
            this.RB_5mm.AutoSize = true;
            this.RB_5mm.Location = new System.Drawing.Point(24, 146);
            this.RB_5mm.Name = "RB_5mm";
            this.RB_5mm.Size = new System.Drawing.Size(73, 17);
            this.RB_5mm.TabIndex = 9;
            this.RB_5mm.Text = "Float 5mm";
            this.RB_5mm.UseVisualStyleBackColor = true;
            this.RB_5mm.CheckedChanged += new System.EventHandler(this.RB_5mm_CheckedChanged);
            // 
            // RB_4mm
            // 
            this.RB_4mm.AutoSize = true;
            this.RB_4mm.Checked = true;
            this.RB_4mm.Location = new System.Drawing.Point(24, 123);
            this.RB_4mm.Name = "RB_4mm";
            this.RB_4mm.Size = new System.Drawing.Size(73, 17);
            this.RB_4mm.TabIndex = 8;
            this.RB_4mm.TabStop = true;
            this.RB_4mm.Text = "Float 4mm";
            this.RB_4mm.UseVisualStyleBackColor = true;
            this.RB_4mm.CheckedChanged += new System.EventHandler(this.RB_4mm_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(117, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tipo de Vidrio: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Precio Vidrio 4mm :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TB_precio4mm
            // 
            this.TB_precio4mm.Location = new System.Drawing.Point(131, 65);
            this.TB_precio4mm.Name = "TB_precio4mm";
            this.TB_precio4mm.Size = new System.Drawing.Size(61, 20);
            this.TB_precio4mm.TabIndex = 5;
            this.TB_precio4mm.Text = "2600";
            this.TB_precio4mm.TextChanged += new System.EventHandler(this.TB_precio4mm_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Alto: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ancho: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TB_altoVID
            // 
            this.TB_altoVID.Enabled = false;
            this.TB_altoVID.Location = new System.Drawing.Point(258, 79);
            this.TB_altoVID.Name = "TB_altoVID";
            this.TB_altoVID.Size = new System.Drawing.Size(61, 20);
            this.TB_altoVID.TabIndex = 2;
            this.TB_altoVID.TextChanged += new System.EventHandler(this.TB_altoVID_TextChanged);
            // 
            // TB_anchoVID
            // 
            this.TB_anchoVID.Enabled = false;
            this.TB_anchoVID.Location = new System.Drawing.Point(258, 53);
            this.TB_anchoVID.Name = "TB_anchoVID";
            this.TB_anchoVID.Size = new System.Drawing.Size(61, 20);
            this.TB_anchoVID.TabIndex = 1;
            this.TB_anchoVID.TextChanged += new System.EventHandler(this.TB_anchoVID_TextChanged);
            // 
            // CHCKB_VidPerso
            // 
            this.CHCKB_VidPerso.AutoSize = true;
            this.CHCKB_VidPerso.Location = new System.Drawing.Point(158, 28);
            this.CHCKB_VidPerso.Name = "CHCKB_VidPerso";
            this.CHCKB_VidPerso.Size = new System.Drawing.Size(174, 17);
            this.CHCKB_VidPerso.TabIndex = 0;
            this.CHCKB_VidPerso.Text = "Medida del vidrio personalizado";
            this.CHCKB_VidPerso.UseVisualStyleBackColor = true;
            this.CHCKB_VidPerso.CheckedChanged += new System.EventHandler(this.CHCKB_VidPerso_CheckedChanged);
            // 
            // TB_Cantidad
            // 
            this.TB_Cantidad.Location = new System.Drawing.Point(153, 104);
            this.TB_Cantidad.Name = "TB_Cantidad";
            this.TB_Cantidad.Size = new System.Drawing.Size(35, 20);
            this.TB_Cantidad.TabIndex = 19;
            this.TB_Cantidad.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(79, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "CANTIDAD: ";
            // 
            // B_Agregar
            // 
            this.B_Agregar.Location = new System.Drawing.Point(7, 138);
            this.B_Agregar.Name = "B_Agregar";
            this.B_Agregar.Size = new System.Drawing.Size(322, 30);
            this.B_Agregar.TabIndex = 17;
            this.B_Agregar.Text = "&Agregar al presupuesto";
            this.B_Agregar.UseVisualStyleBackColor = true;
            this.B_Agregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // CHCKB_Colocacion
            // 
            this.CHCKB_Colocacion.AutoSize = true;
            this.CHCKB_Colocacion.Location = new System.Drawing.Point(18, 82);
            this.CHCKB_Colocacion.Name = "CHCKB_Colocacion";
            this.CHCKB_Colocacion.Size = new System.Drawing.Size(137, 17);
            this.CHCKB_Colocacion.TabIndex = 16;
            this.CHCKB_Colocacion.Text = " Premarco y colocacion";
            this.CHCKB_Colocacion.UseVisualStyleBackColor = true;
            // 
            // CHCKB_Compacto
            // 
            this.CHCKB_Compacto.AutoSize = true;
            this.CHCKB_Compacto.Location = new System.Drawing.Point(203, 47);
            this.CHCKB_Compacto.Name = "CHCKB_Compacto";
            this.CHCKB_Compacto.Size = new System.Drawing.Size(104, 17);
            this.CHCKB_Compacto.TabIndex = 15;
            this.CHCKB_Compacto.Text = "Cajon Compacto";
            this.CHCKB_Compacto.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(117, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "ADICIONALES: ";
            // 
            // CHCKB_Mec_osc
            // 
            this.CHCKB_Mec_osc.AutoSize = true;
            this.CHCKB_Mec_osc.Location = new System.Drawing.Point(18, 47);
            this.CHCKB_Mec_osc.Name = "CHCKB_Mec_osc";
            this.CHCKB_Mec_osc.Size = new System.Drawing.Size(150, 17);
            this.CHCKB_Mec_osc.TabIndex = 13;
            this.CHCKB_Mec_osc.Text = "Mecanismo Oscilovatiente";
            this.CHCKB_Mec_osc.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TB_Cantidad);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.CHCKB_Mec_osc);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.CHCKB_Compacto);
            this.groupBox5.Controls.Add(this.CHCKB_Colocacion);
            this.groupBox5.Controls.Add(this.B_Agregar);
            this.groupBox5.Location = new System.Drawing.Point(26, 473);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(341, 176);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Accesorios y adicionales";
            // 
            // Presupuestos_DANISA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(872, 652);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Presupuestos_DANISA";
            this.Text = "Sistema de presupuesto DANISA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TB_kglineal;
        private System.Windows.Forms.TextBox TB_alto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TB_ancho;
        private System.Windows.Forms.RadioButton RB_colorNEG;
        private System.Windows.Forms.RadioButton RB_colorAN;
        private System.Windows.Forms.RadioButton RB_colorBLAN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_altoVID;
        private System.Windows.Forms.TextBox TB_anchoVID;
        private System.Windows.Forms.CheckBox CHCKB_VidPerso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_precio4mm;
        private System.Windows.Forms.RadioButton RB_DVH5;
        private System.Windows.Forms.RadioButton RB_DVH4;
        private System.Windows.Forms.RadioButton RB_5mm;
        private System.Windows.Forms.RadioButton RB_4mm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton RB_3mm;
        private System.Windows.Forms.CheckBox CHCKB_Mec_osc;
        private System.Windows.Forms.CheckBox CHCKB_Compacto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox CHCKB_Colocacion;
        private System.Windows.Forms.ComboBox CB_ListadoProd;
        private System.Windows.Forms.TextBox TB_Cantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button B_Agregar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button B_Limpiar;
        private System.Windows.Forms.Button B_CerrarTKT;
        private System.Windows.Forms.ListBox LB_Listado;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton RB_Revestimiento;
        private System.Windows.Forms.CheckBox CHCKB_sinvidrio;
    }
}

