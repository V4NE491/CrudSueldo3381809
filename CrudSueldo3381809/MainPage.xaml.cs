namespace CrudSueldo3381809
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Obtener valores del Entry
            int horasTrabajadas = int.Parse(entryHoras.Text);
            decimal pagoPorHora = decimal.Parse(entryPago.Text);

            // Crear un objeto Trabajador y calcular el sueldo
            Trabajador trabajador = new Trabajador
            {
                HorasTrabajadas = horasTrabajadas,
                PagoPorHora = pagoPorHora
            };

            decimal sueldoSemanal = trabajador.CalcularSueldoSemanal();
            // Mostrar el resultado
            labelSueldo.Text = $"Sueldo Semanal: ${sueldoSemanal}";
        }
    }

}
