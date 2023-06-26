using System;

namespace BARBERIA
{
    partial class Barberia
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RTBMostrar = new System.Windows.Forms.RichTextBox();
            this.BListaTurnos = new System.Windows.Forms.Button();
            this.BGenerar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.MTBXhora = new System.Windows.Forms.MaskedTextBox();
            this.ChBxCorte = new System.Windows.Forms.CheckBox();
            this.ChBxLavado = new System.Windows.Forms.CheckBox();
            this.ChBxBarba = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RBSabado = new System.Windows.Forms.RadioButton();
            this.RBViernes = new System.Windows.Forms.RadioButton();
            this.RBJueves = new System.Windows.Forms.RadioButton();
            this.RBMiercoles = new System.Windows.Forms.RadioButton();
            this.RBMartes = new System.Windows.Forms.RadioButton();
            this.RBLunes = new System.Windows.Forms.RadioButton();
            this.CBCliente = new System.Windows.Forms.ComboBox();
            this.CBEmpleado = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BListado_produc = new System.Windows.Forms.Button();
            this.BVenta = new System.Windows.Forms.Button();
            this.BCompra = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.TBNombre_prod = new System.Windows.Forms.TextBox();
            this.GbPersonas = new System.Windows.Forms.GroupBox();
            this.Blistado = new System.Windows.Forms.Button();
            this.MktbFecha = new System.Windows.Forms.MaskedTextBox();
            this.TbEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBsueldo = new System.Windows.Forms.TextBox();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.TBdireccion = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.RBEmpleado = new System.Windows.Forms.RadioButton();
            this.RBCliente = new System.Windows.Forms.RadioButton();
            this.BAgregar = new System.Windows.Forms.Button();
            this.Bcerrar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GbPersonas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RTBMostrar);
            this.groupBox2.Controls.Add(this.BListaTurnos);
            this.groupBox2.Controls.Add(this.BGenerar);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.MTBXhora);
            this.groupBox2.Controls.Add(this.ChBxCorte);
            this.groupBox2.Controls.Add(this.ChBxLavado);
            this.groupBox2.Controls.Add(this.ChBxBarba);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.RBSabado);
            this.groupBox2.Controls.Add(this.RBViernes);
            this.groupBox2.Controls.Add(this.RBJueves);
            this.groupBox2.Controls.Add(this.RBMiercoles);
            this.groupBox2.Controls.Add(this.RBMartes);
            this.groupBox2.Controls.Add(this.RBLunes);
            this.groupBox2.Controls.Add(this.CBCliente);
            this.groupBox2.Controls.Add(this.CBEmpleado);
            this.groupBox2.Location = new System.Drawing.Point(417, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 396);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turnos";
            // 
            // RTBMostrar
            // 
            this.RTBMostrar.Location = new System.Drawing.Point(6, 137);
            this.RTBMostrar.Name = "RTBMostrar";
            this.RTBMostrar.Size = new System.Drawing.Size(393, 207);
            this.RTBMostrar.TabIndex = 17;
            this.RTBMostrar.Text = "";
            // 
            // BListaTurnos
            // 
            this.BListaTurnos.Enabled = false;
            this.BListaTurnos.Location = new System.Drawing.Point(183, 355);
            this.BListaTurnos.Name = "BListaTurnos";
            this.BListaTurnos.Size = new System.Drawing.Size(189, 27);
            this.BListaTurnos.TabIndex = 16;
            this.BListaTurnos.Text = "&Lista general de turnos";
            this.BListaTurnos.UseVisualStyleBackColor = true;
            this.BListaTurnos.Click += new System.EventHandler(this.BListaTurnos_Click);
            // 
            // BGenerar
            // 
            this.BGenerar.Location = new System.Drawing.Point(27, 355);
            this.BGenerar.Name = "BGenerar";
            this.BGenerar.Size = new System.Drawing.Size(124, 28);
            this.BGenerar.TabIndex = 15;
            this.BGenerar.Text = "&Generar Turno";
            this.BGenerar.UseVisualStyleBackColor = true;
            this.BGenerar.Click += new System.EventHandler(this.BGenerar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Hora:";
            // 
            // MTBXhora
            // 
            this.MTBXhora.Location = new System.Drawing.Point(76, 75);
            this.MTBXhora.Mask = "00:00";
            this.MTBXhora.Name = "MTBXhora";
            this.MTBXhora.Size = new System.Drawing.Size(51, 20);
            this.MTBXhora.TabIndex = 13;
            this.MTBXhora.ValidatingType = typeof(System.DateTime);
            // 
            // ChBxCorte
            // 
            this.ChBxCorte.AutoSize = true;
            this.ChBxCorte.Location = new System.Drawing.Point(259, 77);
            this.ChBxCorte.Name = "ChBxCorte";
            this.ChBxCorte.Size = new System.Drawing.Size(103, 17);
            this.ChBxCorte.TabIndex = 12;
            this.ChBxCorte.Text = "Corte de cabello";
            this.ChBxCorte.UseVisualStyleBackColor = true;
            // 
            // ChBxLavado
            // 
            this.ChBxLavado.AutoSize = true;
            this.ChBxLavado.Location = new System.Drawing.Point(259, 50);
            this.ChBxLavado.Name = "ChBxLavado";
            this.ChBxLavado.Size = new System.Drawing.Size(114, 17);
            this.ChBxLavado.TabIndex = 11;
            this.ChBxLavado.Text = "Lavado de cabello";
            this.ChBxLavado.UseVisualStyleBackColor = true;
            // 
            // ChBxBarba
            // 
            this.ChBxBarba.AutoSize = true;
            this.ChBxBarba.Location = new System.Drawing.Point(259, 27);
            this.ChBxBarba.Name = "ChBxBarba";
            this.ChBxBarba.Size = new System.Drawing.Size(54, 17);
            this.ChBxBarba.TabIndex = 10;
            this.ChBxBarba.Text = "Barba";
            this.ChBxBarba.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Coiffeur";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Cliente";
            // 
            // RBSabado
            // 
            this.RBSabado.AutoSize = true;
            this.RBSabado.Location = new System.Drawing.Point(340, 106);
            this.RBSabado.Name = "RBSabado";
            this.RBSabado.Size = new System.Drawing.Size(62, 17);
            this.RBSabado.TabIndex = 7;
            this.RBSabado.Text = "Sabado";
            this.RBSabado.UseVisualStyleBackColor = true;
            // 
            // RBViernes
            // 
            this.RBViernes.AutoSize = true;
            this.RBViernes.Location = new System.Drawing.Point(274, 106);
            this.RBViernes.Name = "RBViernes";
            this.RBViernes.Size = new System.Drawing.Size(60, 17);
            this.RBViernes.TabIndex = 6;
            this.RBViernes.Text = "Viernes";
            this.RBViernes.UseVisualStyleBackColor = true;
            // 
            // RBJueves
            // 
            this.RBJueves.AutoSize = true;
            this.RBJueves.Location = new System.Drawing.Point(209, 106);
            this.RBJueves.Name = "RBJueves";
            this.RBJueves.Size = new System.Drawing.Size(59, 17);
            this.RBJueves.TabIndex = 5;
            this.RBJueves.Text = "Jueves";
            this.RBJueves.UseVisualStyleBackColor = true;
            // 
            // RBMiercoles
            // 
            this.RBMiercoles.AutoSize = true;
            this.RBMiercoles.Location = new System.Drawing.Point(133, 106);
            this.RBMiercoles.Name = "RBMiercoles";
            this.RBMiercoles.Size = new System.Drawing.Size(70, 17);
            this.RBMiercoles.TabIndex = 4;
            this.RBMiercoles.Text = "Miercoles";
            this.RBMiercoles.UseVisualStyleBackColor = true;
            // 
            // RBMartes
            // 
            this.RBMartes.AutoSize = true;
            this.RBMartes.Location = new System.Drawing.Point(61, 106);
            this.RBMartes.Name = "RBMartes";
            this.RBMartes.Size = new System.Drawing.Size(57, 17);
            this.RBMartes.TabIndex = 3;
            this.RBMartes.Text = "Martes";
            this.RBMartes.UseVisualStyleBackColor = true;
            // 
            // RBLunes
            // 
            this.RBLunes.AutoSize = true;
            this.RBLunes.Checked = true;
            this.RBLunes.Location = new System.Drawing.Point(6, 106);
            this.RBLunes.Name = "RBLunes";
            this.RBLunes.Size = new System.Drawing.Size(54, 17);
            this.RBLunes.TabIndex = 2;
            this.RBLunes.TabStop = true;
            this.RBLunes.Text = "Lunes";
            this.RBLunes.UseVisualStyleBackColor = true;
            // 
            // CBCliente
            // 
            this.CBCliente.FormattingEnabled = true;
            this.CBCliente.Items.AddRange(new object[] {
            "De paso"});
            this.CBCliente.Location = new System.Drawing.Point(76, 23);
            this.CBCliente.Name = "CBCliente";
            this.CBCliente.Size = new System.Drawing.Size(106, 21);
            this.CBCliente.TabIndex = 1;
            // 
            // CBEmpleado
            // 
            this.CBEmpleado.FormattingEnabled = true;
            this.CBEmpleado.Location = new System.Drawing.Point(76, 48);
            this.CBEmpleado.Name = "CBEmpleado";
            this.CBEmpleado.Size = new System.Drawing.Size(106, 21);
            this.CBEmpleado.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BListado_produc);
            this.groupBox1.Controls.Add(this.BVenta);
            this.groupBox1.Controls.Add(this.BCompra);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TBCantidad);
            this.groupBox1.Controls.Add(this.TBPrecio);
            this.groupBox1.Controls.Add(this.TBNombre_prod);
            this.groupBox1.Location = new System.Drawing.Point(11, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 190);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // BListado_produc
            // 
            this.BListado_produc.Location = new System.Drawing.Point(48, 130);
            this.BListado_produc.Name = "BListado_produc";
            this.BListado_produc.Size = new System.Drawing.Size(308, 36);
            this.BListado_produc.TabIndex = 8;
            this.BListado_produc.Text = "&Listado/Stock disponible";
            this.BListado_produc.UseVisualStyleBackColor = true;
            this.BListado_produc.Click += new System.EventHandler(this.BListado_produc_Click_1);
            // 
            // BVenta
            // 
            this.BVenta.Location = new System.Drawing.Point(249, 68);
            this.BVenta.Name = "BVenta";
            this.BVenta.Size = new System.Drawing.Size(109, 24);
            this.BVenta.TabIndex = 7;
            this.BVenta.Text = "&Venta";
            this.BVenta.UseVisualStyleBackColor = true;
            this.BVenta.Click += new System.EventHandler(this.BVenta_Click_1);
            // 
            // BCompra
            // 
            this.BCompra.Location = new System.Drawing.Point(248, 24);
            this.BCompra.Name = "BCompra";
            this.BCompra.Size = new System.Drawing.Size(109, 24);
            this.BCompra.TabIndex = 6;
            this.BCompra.Text = "&Comprar";
            this.BCompra.UseVisualStyleBackColor = true;
            this.BCompra.Click += new System.EventHandler(this.BCompra_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre:";
            // 
            // TBCantidad
            // 
            this.TBCantidad.Location = new System.Drawing.Point(103, 71);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(88, 20);
            this.TBCantidad.TabIndex = 2;
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(103, 45);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(88, 20);
            this.TBPrecio.TabIndex = 1;
            // 
            // TBNombre_prod
            // 
            this.TBNombre_prod.Location = new System.Drawing.Point(103, 19);
            this.TBNombre_prod.Name = "TBNombre_prod";
            this.TBNombre_prod.Size = new System.Drawing.Size(88, 20);
            this.TBNombre_prod.TabIndex = 0;
            // 
            // GbPersonas
            // 
            this.GbPersonas.Controls.Add(this.Blistado);
            this.GbPersonas.Controls.Add(this.MktbFecha);
            this.GbPersonas.Controls.Add(this.TbEdad);
            this.GbPersonas.Controls.Add(this.label6);
            this.GbPersonas.Controls.Add(this.label5);
            this.GbPersonas.Controls.Add(this.label4);
            this.GbPersonas.Controls.Add(this.label3);
            this.GbPersonas.Controls.Add(this.label2);
            this.GbPersonas.Controls.Add(this.label1);
            this.GbPersonas.Controls.Add(this.TBsueldo);
            this.GbPersonas.Controls.Add(this.TBTelefono);
            this.GbPersonas.Controls.Add(this.TBdireccion);
            this.GbPersonas.Controls.Add(this.TBNombre);
            this.GbPersonas.Controls.Add(this.RBEmpleado);
            this.GbPersonas.Controls.Add(this.RBCliente);
            this.GbPersonas.Controls.Add(this.BAgregar);
            this.GbPersonas.Location = new System.Drawing.Point(8, 9);
            this.GbPersonas.Name = "GbPersonas";
            this.GbPersonas.Size = new System.Drawing.Size(404, 235);
            this.GbPersonas.TabIndex = 6;
            this.GbPersonas.TabStop = false;
            this.GbPersonas.Text = "Clientes y Personal";
            // 
            // Blistado
            // 
            this.Blistado.Location = new System.Drawing.Point(242, 188);
            this.Blistado.Name = "Blistado";
            this.Blistado.Size = new System.Drawing.Size(98, 32);
            this.Blistado.TabIndex = 17;
            this.Blistado.Text = "&Listado";
            this.Blistado.UseVisualStyleBackColor = true;
            this.Blistado.Click += new System.EventHandler(this.Blistado_Click_1);
            // 
            // MktbFecha
            // 
            this.MktbFecha.Location = new System.Drawing.Point(242, 146);
            this.MktbFecha.Mask = "99/99/9999";
            this.MktbFecha.Name = "MktbFecha";
            this.MktbFecha.Size = new System.Drawing.Size(116, 20);
            this.MktbFecha.TabIndex = 16;
            this.MktbFecha.ValidatingType = typeof(System.DateTime);
            // 
            // TbEdad
            // 
            this.TbEdad.Location = new System.Drawing.Point(63, 121);
            this.TbEdad.Name = "TbEdad";
            this.TbEdad.Size = new System.Drawing.Size(116, 20);
            this.TbEdad.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de ingreso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sueldo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre y apellido:";
            // 
            // TBsueldo
            // 
            this.TBsueldo.Enabled = false;
            this.TBsueldo.Location = new System.Drawing.Point(242, 120);
            this.TBsueldo.Name = "TBsueldo";
            this.TBsueldo.Size = new System.Drawing.Size(116, 20);
            this.TBsueldo.TabIndex = 6;
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(103, 70);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(116, 20);
            this.TBTelefono.TabIndex = 5;
            // 
            // TBdireccion
            // 
            this.TBdireccion.Location = new System.Drawing.Point(103, 44);
            this.TBdireccion.Name = "TBdireccion";
            this.TBdireccion.Size = new System.Drawing.Size(116, 20);
            this.TBdireccion.TabIndex = 2;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(103, 19);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(116, 20);
            this.TBNombre.TabIndex = 1;
            // 
            // RBEmpleado
            // 
            this.RBEmpleado.AutoSize = true;
            this.RBEmpleado.Location = new System.Drawing.Point(242, 96);
            this.RBEmpleado.Name = "RBEmpleado";
            this.RBEmpleado.Size = new System.Drawing.Size(61, 17);
            this.RBEmpleado.TabIndex = 2;
            this.RBEmpleado.Text = "Coiffeur";
            this.RBEmpleado.UseVisualStyleBackColor = true;
            this.RBEmpleado.CheckedChanged += new System.EventHandler(this.RBEmpleado_CheckedChanged);
            // 
            // RBCliente
            // 
            this.RBCliente.AutoSize = true;
            this.RBCliente.Checked = true;
            this.RBCliente.Location = new System.Drawing.Point(73, 96);
            this.RBCliente.Name = "RBCliente";
            this.RBCliente.Size = new System.Drawing.Size(62, 17);
            this.RBCliente.TabIndex = 1;
            this.RBCliente.TabStop = true;
            this.RBCliente.Text = "Clientes";
            this.RBCliente.UseVisualStyleBackColor = true;
            this.RBCliente.CheckedChanged += new System.EventHandler(this.RBCliente_CheckedChanged);
            // 
            // BAgregar
            // 
            this.BAgregar.Location = new System.Drawing.Point(25, 188);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(90, 32);
            this.BAgregar.TabIndex = 0;
            this.BAgregar.Text = "&Agregar";
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // Bcerrar
            // 
            this.Bcerrar.Location = new System.Drawing.Point(709, 412);
            this.Bcerrar.Name = "Bcerrar";
            this.Bcerrar.Size = new System.Drawing.Size(104, 29);
            this.Bcerrar.TabIndex = 5;
            this.Bcerrar.Text = "&Cerrar";
            this.Bcerrar.UseVisualStyleBackColor = true;
            this.Bcerrar.Click += new System.EventHandler(this.Bcerrar_Click_1);
            // 
            // Barberia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbPersonas);
            this.Controls.Add(this.Bcerrar);
            this.Name = "Barberia";
            this.Text = "Barberia Turn";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbPersonas.ResumeLayout(false);
            this.GbPersonas.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RTBMostrar;
        private System.Windows.Forms.Button BListaTurnos;
        private System.Windows.Forms.Button BGenerar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox MTBXhora;
        private System.Windows.Forms.CheckBox ChBxCorte;
        private System.Windows.Forms.CheckBox ChBxLavado;
        private System.Windows.Forms.CheckBox ChBxBarba;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton RBSabado;
        private System.Windows.Forms.RadioButton RBViernes;
        private System.Windows.Forms.RadioButton RBJueves;
        private System.Windows.Forms.RadioButton RBMiercoles;
        private System.Windows.Forms.RadioButton RBMartes;
        private System.Windows.Forms.RadioButton RBLunes;
        private System.Windows.Forms.ComboBox CBCliente;
        private System.Windows.Forms.ComboBox CBEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BListado_produc;
        private System.Windows.Forms.Button BVenta;
        private System.Windows.Forms.Button BCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBCantidad;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.TextBox TBNombre_prod;
        private System.Windows.Forms.GroupBox GbPersonas;
        private System.Windows.Forms.Button Blistado;
        private System.Windows.Forms.MaskedTextBox MktbFecha;
        private System.Windows.Forms.TextBox TbEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBsueldo;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.TextBox TBdireccion;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.RadioButton RBEmpleado;
        private System.Windows.Forms.RadioButton RBCliente;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button Bcerrar;
    }
}

