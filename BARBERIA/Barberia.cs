using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaColecciones;

namespace BARBERIA
{
    public partial class Barberia : Form
    {
        int codigoCli = 0, codigoEmp = 0, codigoProd = 0;

        
        public Barberia()
        {
            InitializeComponent();
        }
       

        private void Bcerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea cerrar?") == DialogResult.Yes)
            {
                Close();
            }

        }

        private void RBEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (RBEmpleado.Checked)
            {
                TBsueldo.Enabled = true;
                MktbFecha.Enabled = true;
                TbEdad.Enabled = false;
            }
            else
            {
                TBsueldo.Enabled = false;
                MktbFecha.Enabled = false;
                TbEdad.Enabled = true;
            }
        }

        private void RBCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (RBCliente.Checked)
            {
                TBsueldo.Enabled = false;
                MktbFecha.Enabled = false;
                TbEdad.Enabled = true;
            }
            else
            {
                TBsueldo.Enabled = true;
                MktbFecha.Enabled = true;
                TbEdad.Enabled = false;
            }
        }

        /*private void GbPersonas_Enter(object sender, EventArgs e)
        {
            if ((TBNombre.Text != "") && (TBdireccion.Text != "") && (TBTelefono.Text != ""))
            {
                if ((TbEdad.Text != "") || ((TBsueldo.Text != "") && (MktbFecha.Text != "")))
                {
                    BAgregar.Enabled = true;
                }

            }

        }*/

        private void BListado_produc_Click(object sender, EventArgs e)
        {
            if (Program.colproductos.Cant_Productos() == 0)
            {
                MessageBox.Show("No hay productos en stock!!!");
            }
            else
            {
                Program.colproductos.Lista_de_stock();
            }
        }

        private void BVenta_Click(object sender, EventArgs e)
        {

            Boolean busqueda = false;
            if (TBNombre_prod.Text != "" && TBCantidad.Text != "")
            {

                busqueda = Program.colproductos.ExisteProducto(TBNombre_prod.Text);

                if (!busqueda)
                {
                    MessageBox.Show("El articulo no existe!");
                    TBNombre_prod.Focus();
                }
                else
                {
                    //Program.colproductos.Desconta_stock(TBCantidad.Text);//ACA NO SE Q PASA SI EL VOID EXISTE, NO LO DETECTA...
                }
            }
        }

        private void Blistado_Click(object sender, EventArgs e)
        {
            if (Program.colPersonas.Cant_Clientes() == 0)
            {
                MessageBox.Show("No hay Clientes Agregados  !!!");
                TBNombre.Focus();
            }
            else
            {
                if (RBCliente.Checked)
                {
                    Program.colPersonas.Solo_clientes();
                }
                else
                { Program.colPersonas.Solo_empleados(); }
            }
        }


        private void BGenerar_Click(object sender, EventArgs e)
        {
            int costoservicio = 0;

            string[] dias = new string[6] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };

            Turno objTurno;

            if (CBCliente.SelectedIndex != -1 && CBEmpleado.SelectedIndex != -1 && MTBXhora.Text != ""
                && (ChBxBarba.Checked || ChBxCorte.Checked || ChBxLavado.Checked))
            {
                if (ChBxBarba.Checked)
                {
                    costoservicio += 100;
                }
                if (ChBxCorte.Checked)
                {
                    costoservicio += 200;

                }
                if (ChBxLavado.Checked)
                {
                    costoservicio += 150;
                }
               
                if (RBLunes.Checked) { objTurno = new Turno(CBCliente.Text, CBEmpleado.Text, System.Convert.ToString(costoservicio), dias[0], MTBXhora.Text);
                MessageBox.Show(Convert.ToString(objTurno));}
                if (RBMartes.Checked) { objTurno = new Turno(CBCliente.Text, CBEmpleado.Text, System.Convert.ToString(costoservicio), dias[1], MTBXhora.Text);
                MessageBox.Show(Convert.ToString(objTurno));}
                if (RBMiercoles.Checked) { objTurno = new Turno(CBCliente.Text, CBEmpleado.Text, System.Convert.ToString(costoservicio), dias[2], MTBXhora.Text);
                MessageBox.Show(Convert.ToString(objTurno)) ;}
                if (RBJueves.Checked) { objTurno = new Turno(CBCliente.Text, CBEmpleado.Text, System.Convert.ToString(costoservicio), dias[3], MTBXhora.Text); 
                MessageBox.Show(Convert.ToString(objTurno));}
                if (RBViernes.Checked) { objTurno = new Turno(CBCliente.Text, CBEmpleado.Text, System.Convert.ToString(costoservicio), dias[4], MTBXhora.Text);
                    MessageBox.Show(Convert.ToString(objTurno));}
                if (RBSabado.Checked) { objTurno = new Turno(CBCliente.Text, CBEmpleado.Text, System.Convert.ToString(costoservicio), dias[5], MTBXhora.Text);
                MessageBox.Show(Convert.ToString(objTurno)) ;}
                BListaTurnos.Enabled = true;
            
            }
            else
            {
                MessageBox.Show("DAtos ingresados insuficientes!");
                CBCliente.Focus();
            }
        }

       /*private void BTurnos_Click(object sender, EventArgs e)
        {
            RTBMostrar.Text = System.Convert.ToString(Program.colTurnos.Listado_turnos_lunes()) +
                              System.Convert.ToString(Program.colTurnos.Listado_turnos_martes()) +
                              System.Convert.ToString(Program.colTurnos.Listado_turnos_miercoles()) +
                              System.Convert.ToString(Program.colTurnos.Listado_turnos_jueves()) +
                              System.Convert.ToString(Program.colTurnos.Listado_turnos_viernes()) +
                              System.Convert.ToString(Program.colTurnos.Listado_turnos_sabado());
        }*/

        private void Blistado_Click_1(object sender, EventArgs e)
        {
            if (Program.colPersonas.Cant_Clientes() == 0)
            {
                MessageBox.Show("No hay Clientes Agregados  !!!");
                TBNombre.Focus();
            }
            else
            {
                if (RBCliente.Checked)
                {
                    Program.colPersonas.Solo_clientes();
                }
                else
                { Program.colPersonas.Solo_empleados(); }
            }

        }

        private void BListado_produc_Click_1(object sender, EventArgs e)
        {
            if (Program.colproductos.Cant_Productos() == 0)
            {
                MessageBox.Show("No hay productos en stock!!!");
            }
            else
            {
                Program.colproductos.Lista_de_stock();
            }

        }

        private void BVenta_Click_1(object sender, EventArgs e)
        {
            Boolean busqueda = false;
            if (TBNombre_prod.Text != "" && TBCantidad.Text != "")
            {

                busqueda = Program.colproductos.ExisteProducto(TBNombre_prod.Text);

                if (!busqueda)
                {
                    MessageBox.Show("El articulo no existe!");
                    TBNombre_prod.Focus();
                }
                else
                {
                    //Program.colproductos.Desconta_stock(TBCantidad.Text);//ACA NO SE Q PASA SI EL VOID EXISTE, NO LO DETECTA...
                }
            }
        }

        private void Bcerrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea cerrar?") != DialogResult.No)
            {
                Close();
            }

        }

        private void BListaTurnos_Click(object sender, EventArgs e)
        {
            RTBMostrar.Text = System.Convert.ToString(Program.colTurnos.Listado_turnos_lunes()) +
                             System.Convert.ToString(Program.colTurnos.Listado_turnos_martes()) +
                             System.Convert.ToString(Program.colTurnos.Listado_turnos_miercoles()) +
                             System.Convert.ToString(Program.colTurnos.Listado_turnos_jueves()) +
                             System.Convert.ToString(Program.colTurnos.Listado_turnos_viernes()) +
                             System.Convert.ToString(Program.colTurnos.Listado_turnos_sabado());
        }

        private void BCompra_Click_1(object sender, EventArgs e)
        {

            Producto objProd;
            Boolean busqueda = false;
            busqueda = Program.colproductos.ExisteProducto(TBNombre_prod.Text);

            if (!busqueda)
            {

                if (MessageBox.Show("va a ingresar un nuevo producto: Desea continuar?", "Atencion") == DialogResult.Yes)
                {

                    codigoProd += 1;

                    objProd = new Producto(System.Convert.ToString(codigoProd),
                                            TBNombre_prod.Text,
                                            System.Convert.ToString(TBPrecio.Text),
                                            System.Convert.ToString(TBCantidad.Text));
                    MessageBox.Show(objProd.ToString());
                    Program.colproductos.Nuevo_producto(objProd);
                }
                else
                {
                    MessageBox.Show("No ingresado!");
                    TBNombre_prod.Focus();
                }
            }
            else
            {
                if (MessageBox.Show("desea agregar al stock?") == DialogResult.Yes)//tambien se puede modificar por precio... en este if anidando otro if
                {
                //         Program.colproductos.Reposicion_Productos(TBCantidad.Text); SIGUE SIN FUNCIONAR

                }
                else
                {
                    MessageBox.Show("no se realizo la operacion!");
                     TBNombre_prod.Focus();
                }



            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            Persona objPersona;
            Boolean busqueda = false;
            busqueda = Program.colPersonas.ExistePersona(TBNombre.Text);
            if ((TBNombre.Text != "") && (TBTelefono.Text != "") && (TBdireccion.Text != ""))
            {
                if (!busqueda)
                {

                    if (RBCliente.Checked && TbEdad.Text != "")
                    {
                        int CuentaC = 0;
                        codigoCli += 1;
                        CuentaC = 0;
                        objPersona = new Cliente(System.Convert.ToString(codigoCli), TBNombre.Text, TBdireccion.Text
                                               , TBTelefono.Text, CuentaC, System.Convert.ToInt16(TbEdad.Text));
                        CBCliente.Items.Add(TBNombre.Text + "\n");
                        //CBCliente.DataSource = Tablacli;//con esto armamos la lista de los combobx
                        MessageBox.Show(objPersona.ToString());
                        Program.colPersonas.AgregarPersona(objPersona);
                    }
                    else
                    {
                        if (MktbFecha.Text != "" && TBsueldo.Text != "")
                        {
                            DateTime Fecha_ingreso = DateTime.Parse(MktbFecha.Text);
                            codigoEmp += 1;
                            objPersona = new Empleado(TBNombre.Text, TBdireccion.Text, TBTelefono.Text,
                                              System.Convert.ToDecimal(TBsueldo.Text), Fecha_ingreso, System.Convert.ToString(codigoEmp));
                            CBEmpleado.Items.Add(TBNombre.Text + "\n");
                            //CBEmpleado.DataSource = Tablaemp;//con esto armamos la lista de los combobx
                            MessageBox.Show(objPersona.ToString());
                            Program.colPersonas.AgregarPersona(objPersona);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Persona ya existente");
                    TBNombre.Focus();
                }
            }
            else 
            {
                MessageBox.Show("Faltan datos a ingresar: ERROR");
                TBNombre.Focus();
            }
        }
    }
}
