namespace panaderiaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Boolean cambiador = false;

            double cantidad_de_masa = 0;
            if (pizza260mtbx.Text != "" & pizza260mtbx.Text != "0")
            {

                int pizza260 = 0;
                pizza260 = Convert.ToInt32(pizza260mtbx.Text);
                cantidad_de_masa = cantidad_de_masa + (260 * pizza260);
                cambiador = true;

            }

            if (pizza360mtbx.Text != "" & pizza360mtbx.Text != "0")
            {

                int pizza360 = 0;
                pizza360 = Convert.ToInt32(pizza360mtbx.Text);
                cantidad_de_masa = cantidad_de_masa + (360 * pizza360);
                cambiador = true;

            }
            if (pizza320mtbx.Text != "" & pizza320mtbx.Text != "0")
            {

                int pizza320 = 0;
                pizza320 = Convert.ToInt32(pizza320mtbx.Text);
                cantidad_de_masa = cantidad_de_masa + (320 * pizza320);
                cambiador = true;
            }

            if (ciabat130mtbx.Text != "" & ciabat130mtbx.Text != "0")
            {

                int ciabatta130 = 0;
                ciabatta130 = Convert.ToInt32(ciabat130mtbx.Text);
                cantidad_de_masa = cantidad_de_masa + (130 * ciabatta130);
                cambiador = true;
            }
            if (ciabat170mtbx.Text != "" & ciabat170mtbx.Text != "0")
            {

                int ciabatta170 = 0;
                ciabatta170 = Convert.ToInt32(ciabat170mtbx.Text);
                cantidad_de_masa = cantidad_de_masa + (170 * ciabatta170);
                cambiador = true;
            }

            if (pancito50mtbx.Text != "" & pancito50mtbx.Text != "0")
            {

                int pan50 = 0;
                pan50 = Convert.ToInt32(pancito50mtbx.Text);
                cantidad_de_masa = cantidad_de_masa + (50 * pan50);
                cambiador = true;
            }
            if (indivi150mtbx.Text != "" & indivi150mtbx.Text != "0")
            {

                int indi150 = 0;
                indi150 = Convert.ToInt32(indivi150mtbx.Text);
                cantidad_de_masa = cantidad_de_masa + (150 * indi150);
                cambiador = true;
            }
            if (rectang210mtbx.Text != "" & rectang210mtbx.Text != "0")
            {

                int rect210 = 0;
                rect210 = Convert.ToInt32(rectang210mtbx.Text);
                cantidad_de_masa = cantidad_de_masa + (210 * rect210);
                cambiador = true;
            }
            if (rectang250mtbx.Text != "" & rectang250mtbx.Text != "0")
            {

                int rect250 = 0;
                rect250 = Convert.ToInt32(rectang250mtbx.Text);
                cantidad_de_masa = cantidad_de_masa + (250 * rect250);
                cambiador = true;
            }
            if (cambiador)
            {
                string cantmasa = "";

                cantmasa = Convert.ToString(cantidad_de_masa);
                double kgmasa = cantidad_de_masa / 1000;
                double kgharina = 0;
                kgharina = ((cantidad_de_masa / 1000) * 0.67);
                double agua = 0;
                agua = (cantidad_de_masa / 1000) * 0.3;
                double aceite = 0;
                aceite = (kgharina * 60);
                double sal = 0;
                sal = (kgharina * 28);
                double levadura = 0;
                levadura = kgharina * 30;
                ListaGB.Text = "cantidad de masa a utilizar:  " + Convert.ToString(kgmasa) + "kg"
                + System.Environment.NewLine + "KG harina:  " + Convert.ToString(kgharina) + "  Kg"
                + System.Environment.NewLine + "Agua:  " + Convert.ToString(agua) + "  litros"
                + System.Environment.NewLine + "Aceite:  " + Convert.ToString(aceite) + "  cm3"
                + System.Environment.NewLine + "Sal:  " + Convert.ToString(sal) + "  grms"
                + System.Environment.NewLine + "Levadura:  " + Convert.ToString(levadura) + "  grms"
                ;
            }
            else
            {
                MessageBox.Show("cargar bien los datos! ", "no te hagas el boludo escoces");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            pizza260mtbx.Text = "0";
            pizza360mtbx.Text = "0";
            pizza320mtbx.Text = "0";
            indivi150mtbx.Text = "0";
            rectang210mtbx.Text = "0";
            rectang250mtbx.Text = "0";
            pancito50mtbx.Text = "0";
            ciabat130mtbx.Text = "0";
            ciabat170mtbx.Text = "0";
            ListaGB.Text = "";
        }

        private void pizza320mtbx_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}