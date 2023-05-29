using Proyect_Progra1PT1.Vehiculos;

namespace Proyect_Progra1PT1
{
    public partial class EditarVehiculoPage : ContentPage
    {
        private IVehiculo vehiculoSeleccionado;

        public EditarVehiculoPage()
        {
            InitializeComponent();
        }

        public EditarVehiculoPage(IVehiculo vehiculo)
        {
            InitializeComponent();
            vehiculoSeleccionado = vehiculo;

            BindingContext = vehiculoSeleccionado;
        }

        private void Guardar_Clicked(object sender, EventArgs e)
        {
            vehiculoSeleccionado.Marca = entryMarca.Text;
            vehiculoSeleccionado.Modelo = entryModelo.Text;
            vehiculoSeleccionado.Color = entryColor.Text;
            vehiculoSeleccionado.Anio = int.Parse(entryAnio.Text);

            // Obtiene la instancia de MainPage desde la pila de navegación
            MainPage mainPage = (App.Current.MainPage as NavigationPage)?.RootPage as MainPage;

            // Actualiza los datos del vehículo seleccionado en MainPage
            mainPage.VehiculoSeleccionado = vehiculoSeleccionado;

            Navigation.PopAsync();
        }
    }
}
