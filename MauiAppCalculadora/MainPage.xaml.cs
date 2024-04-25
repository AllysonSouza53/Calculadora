namespace MauiAppCalculadora
{
    public partial class MainPage : ContentPage
    {
        String? operação = null;

        double MPreOp = 0;
        double MPostOp = 0;
        double V = 0;

        string MemV = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void removedor_de_sinais_no_visor()
        {
            if (MemV == "+" ||
                 MemV == "-" ||
                 MemV == "/" ||
                 MemV == "*")
            {
                MemV = "";
            }
        }
        private void Zerar_Clicked(object sender, EventArgs e)
        {
            visor.Text = "0";
            MemV = "";
            MPreOp = 0;
            MPostOp = 0;
            operação = null;
        }

        private void Maismenos_Clicked(object sender, EventArgs e)
        {
            V = Convert.ToDouble(MemV);
            V = V * -1;
            visor.Text = V.ToString() ;
        }

        private void Porcento_Clicked(object sender, EventArgs e)
        {
            V = Convert.ToDouble(MemV);
            V = V/100;
            visor.Text = V.ToString();
        }

        private void dividir_Clicked(object sender, EventArgs e)
        {

        }

        private void num7_Clicked(object sender, EventArgs e)
        {
            MemV = num7.Text;
            visor.Text= MemV;
        }

        private void num8_Clicked(object sender, EventArgs e)
        {
            MemV = num8.Text;
            visor.Text = MemV;
        }

        private void num9_Clicked(object sender, EventArgs e)
        {
            MemV = num9.Text;
            visor.Text = MemV;
        }

        private void multiplicacao_Clicked(object sender, EventArgs e)
        {

        }

        private void num4_Clicked(object sender, EventArgs e)
        {
            MemV = num4.Text;
            visor.Text = MemV;
        }

        private void num5_Clicked(object sender, EventArgs e)
        {
            MemV = num5.Text;
            visor.Text = MemV;
        }
        private void num6_Clicked(object sender, EventArgs e)
        {
            MemV = num6.Text;
            visor.Text = MemV;
        }

        private void menos_Clicked(object sender, EventArgs e)
        {

        }

        private void num_1_Clicked(object sender, EventArgs e)
        {
            MemV = num1.Text;
            visor.Text = MemV;
        }

        private void num_2_Clicked(object sender, EventArgs e)
        {
            MemV = num2.Text;
            visor.Text = MemV;
        }

        private void num_3_Clicked(object sender, EventArgs e)
        {
            MemV = num3.Text;
            visor.Text = MemV;
        }

        private void mais_Clicked(object sender, EventArgs e)
        {

        }

        private void num_0_Clicked(System.Object sender, System.EventArgs e)
        {
            MemV = num0.Text;
            visor.Text = MemV;
        }

        private void ponto_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void igual_Clicked(System.Object sender, System.EventArgs e)
        {

        }
    }

}
