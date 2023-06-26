using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carpinteria_alum
{
    public partial class Presupuestos_DANISA : Form
    {
        public Presupuestos_DANISA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TB_dolar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void RB_DVH5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_DVH4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_5mm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_4mm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CHCKB_VidPerso_CheckedChanged(object sender, EventArgs e)
        {
            if (CHCKB_VidPerso.Checked) {

                TB_anchoVID.Enabled = true;
                TB_altoVID.Enabled = true;

            }

            if (!CHCKB_VidPerso.Checked)
            {

                TB_anchoVID.Enabled = false;
                TB_altoVID.Enabled = false;

            }
        }

        private void B_Limpiar_Click(object sender, EventArgs e)
        {

            TB_alto.Text = "";
            TB_ancho.Text = "";
            TB_altoVID.Text = "";
            TB_anchoVID.Text = "";
            LB_Listado.Text = "";

        }

        //variable global (MOD)       
        string Descripcion = "";
        double agregar_al_presupuesto = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            Double mts2 = 0.0;
            if (Convert.ToInt64(TB_kglineal.Text) > 0)
            {

                var precio_lineal = Convert.ToInt64(TB_kglineal.Text);//controll de errores para q el usr no ingrese mierdas ;)

            }
            if ((Convert.ToInt32(TB_alto.Text) < 0))
            {
                MessageBox.Show("error!! ingrese el alto de la abertura correctamente");
            }
            else if ((Convert.ToInt32(TB_ancho.Text) < 0))
            {
                MessageBox.Show("error!! ingrese el ancho de la abertura correctamente");
            }
            else if ((Convert.ToInt32(TB_Cantidad.Text) > 0) & (Convert.ToInt32(TB_kglineal.Text) > 0))
            { //aca empieza el salseo
                var cantidad = Convert.ToDouble(TB_Cantidad.Text);


                //calculamos los Mts2 de la abertura
                mts2 = ((Convert.ToDouble(TB_ancho.Text)/1000) * (Convert.ToDouble(TB_alto.Text)/1000)) ;
                //-----------

                //string Descripcion = "";//variable global (MOD)



                Double mts2kg;
                mts2kg = 0.0;
                var indice = CB_ListadoProd.SelectedIndex;
                MessageBox.Show(Convert.ToString(indice));//esto funciona, el indice se toma bien
                //a comentar , es para testear
                LB_Listado.Text = Convert.ToString(indice);

                if (indice == 0)
                {

                    Descripcion = "Modena ventana corrediza 90°";
                    mts2kg = 8.9;
                }
                if (indice == 1)
                {
                    Descripcion = "Modena ventana corrediza 45°";
                    mts2kg = 12;
                }
                if (indice == 2)
                {
                    Descripcion = "Modena ventana de Paño Fijo";
                    mts2kg = 4.52;
                }
                if (indice == 3)
                {
                    Descripcion = "Modena ventana de rebatir";
                    mts2kg = 8.1;
                }
                if (indice == 4)
                {
                    Descripcion = "Modena puerta de rebatir";
                    mts2kg = 9.50;
                }
                if (indice == 5)
                {
                    Descripcion = "Vesta ventana de rebatir";
                    mts2kg = 6.88;
                }
                if (indice == 6)
                {
                    Descripcion = "Vesta Ventana Paño fijo";
                    mts2kg = 4.16;
                }
                if (indice == 7)
                {
                    Descripcion = "Vesta ventana de Corrediza ";
                    mts2kg = 9.44;
                }
                if (indice == 8)
                {
                    Descripcion = "Vesta Puerta de rebatir";
                    mts2kg = 7.56;
                }
                if (indice == 9)
                {
                    Descripcion = "Herrero Ventana corrediza";
                    mts2kg = 7.76;
                }
                if (indice == 10)
                {
                    Descripcion = "Herrero ventana Paño fijo";
                    mts2kg = 4.20;
                }
                if (indice == 11)
                {
                    Descripcion = "Herrero Puerta de Rebatir";
                    mts2kg = 6.25;
                }
                if (indice == 12)
                {
                    Descripcion = "30NEW Ventana Paño fijo";
                    mts2kg = 6.00;
                }
                if (indice == 13)
                {
                    Descripcion = "30NEW Ventana De Rebatir";
                    mts2kg = 10.60;
                }
                if (indice == 14)
                {
                    Descripcion = "30NEW Ventana Corrediza";
                    mts2kg = 14.00;
                }
                if (indice == 15)
                {
                    Descripcion = "30NEW Puerta de Rebatir";
                    mts2kg = 19.20;
                }
                //------------------ inicio Vidrios 
                double mts2vid = 0;

                if (!CHCKB_sinvidrio.Checked)//si tiene vidrio o no
                {

                    if (CHCKB_VidPerso.Checked)// si elige una medida personalizada
                    {
                        if ((Convert.ToInt32(TB_anchoVID.Text) > 0) & (Convert.ToInt32(TB_ancho.Text) > Convert.ToInt32(TB_anchoVID.Text)) 
                                & (Convert.ToInt32(TB_altoVID.Text) > 0) & (Convert.ToInt32(TB_alto.Text) > Convert.ToInt32(TB_altoVID.Text)))
                        {

                            // aca calculamos el costo del vidrio personalizado
                            mts2vid = ((Convert.ToDouble(TB_anchoVID.Text) / 1000) * ((Convert.ToDouble(TB_altoVID.Text)) / 1000)) ;
                        }
                        else
                        {
                            MessageBox.Show("error!! ingrese el ancho/alto de la abertura correctamente");
                        }
                    }
                    else
                    {
                        mts2vid = mts2;//si no eligio perso, los mts2 de la abertura van a ser igual a la del vidrio
                    }//endif checb vidrio perso
                }
                else
                {
                    mts2vid = 0;
                }
                //end if si tiene vidrio


                Double valor_vidrio = 0;
                if (RB_4mm.Checked)
                {
                    valor_vidrio = mts2vid * Convert.ToDouble(TB_precio4mm.Text);
                }
                // DE AQUI PARA ABAJOOOOOOOOOOOOOOOOOOOO FAAALLTAAA >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                if (RB_5mm.Checked)
                {
                    valor_vidrio = 1.4 * (mts2vid * Convert.ToDouble(TB_precio4mm));
                }
                if (RB_3mm.Checked)
                {
                    valor_vidrio = mts2vid * Convert.ToDouble(TB_precio4mm);
                }
                if (RB_DVH5.Checked)
                {
                    valor_vidrio = 1.4 * mts2vid * Convert.ToDouble(TB_precio4mm);
                }
                if (RB_DVH4.Checked)
                {
                    valor_vidrio = 1.4 * mts2vid * Convert.ToDouble(TB_precio4mm);
                }
                if (RB_Revestimiento.Checked)
                {
                    valor_vidrio = 1.4 * mts2vid * Convert.ToDouble(TB_precio4mm);
                }
                // chequear los vidrios

                // fin Vidrios




                if (CHCKB_Compacto.Checked)
                {
                    Descripcion = Descripcion + "con cajon compacto roller";
                    double alto = (Convert.ToDouble(TB_alto.Text) + 200) / 1000;
                    double checkeo = alto * (Convert.ToDouble(TB_ancho.Text) / 1000);
                    if (checkeo < 1.5)
                    {
                        mts2 = 1.5;

                    }


                }
                //
                // hacer el CHECK DEL MEC OSCILOVATIENTE Y el CHECK DE PREMARCO Y COLOCACION
                //
                //
                // hacer el CHECK DEL MEC OSCILOVATIENTE Y el CHECK DE PREMARCO Y COLOCACION
                //
                //
                // hacer el CHECK DEL MEC OSCILOVATIENTE Y el CHECK DE PREMARCO Y COLOCACION
                //
                //
                // hacer el CHECK DEL MEC OSCILOVATIENTE Y el CHECK DE PREMARCO Y COLOCACION
                //

                double subtotal;
                double canti;
                canti = Convert.ToDouble(TB_Cantidad.Text);


                subtotal = ((mts2 * mts2kg * Convert.ToDouble(TB_kglineal.Text)) + valor_vidrio) * canti;
                agregar_al_presupuesto = agregar_al_presupuesto + subtotal;
                Descripcion = Descripcion + "Cantidad : " + TB_Cantidad.Text + " |  Precio : " + Convert.ToString(subtotal);

                LB_Listado.Items.Add ( Descripcion);


            }//endif principal del control de datos














        }//fin del boton

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void TB_precio4mm_TextChanged(object sender, EventArgs e)

        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TB_altoVID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_anchoVID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void B_CerrarTKT_Click(object sender, EventArgs e)
        {
            
            Descripcion = Descripcion + "         TOTAL -----> " + Convert.ToString(agregar_al_presupuesto);

            LB_Listado.Items.Add(Descripcion);

            Descripcion = "";

            agregar_al_presupuesto = 0;


        }
    }


    

}
    

