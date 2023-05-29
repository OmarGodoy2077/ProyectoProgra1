using Proyect_Progra1PT1.Vehiculos;

namespace Proyect_Progra1PT1;

public partial class MainPage : ContentPage
{

    private IVehiculo vehiculoSeleccionado;

    public MainPage()
    {
        InitializeComponent();
        // Selecciona el vehiculo por defecto (en este caso, un PickUp)
        vehiculoSeleccionado = new PickUp("Ford", "F150", "Negro", 2023, "ABC123", "Diesel",100);
        pickerVehiculos.SelectedIndexChanged += PickerVehiculos_SelectedIndexChanged;




        buttonEncender.Clicked += ButtonEncender_Clicked;
        buttonApagar.Clicked += ButtonApagar_Clicked;
        buttonAcelerar.Clicked += ButtonAcelerar_Clicked;
        buttonFrenar.Clicked += ButtonFrenar_Clicked;
    }
    public IVehiculo VehiculoSeleccionado
    {
        get { return vehiculoSeleccionado; }
        set { vehiculoSeleccionado = value; }
    }

    private void OnButtonClick(object sender, EventArgs e)
    {
        // Navigate to the new page
        Navigation.PushAsync(new EditarVehiculoPage());
    }
    private async void EditarPropiedades_Clicked(object sender, EventArgs e)
    {
        EditarVehiculoPage editarVehiculoPage = new EditarVehiculoPage(vehiculoSeleccionado);
        editarVehiculoPage.Disappearing += (s, args) =>
        {
            ActualizarListaVehiculos(); // Actualiza los datos en la lista cuando la página de edición se cierre
        };
        await Navigation.PushAsync(editarVehiculoPage);
    }

    private void ActualizarListaVehiculos()
    {
        // Actualiza la lista de vehículos según corresponda
        // Puedes hacerlo volviendo a cargar los datos desde la fuente de datos, por ejemplo
        // Aquí solo se actualizan las propiedades del vehículo seleccionado

        labelMarca.Text = $"Marca: {vehiculoSeleccionado.Marca}";
        labelModelo.Text = $"Modelo: {vehiculoSeleccionado.Modelo}";
        labelColor.Text = $"Color: {vehiculoSeleccionado.Color}";
        labelAnio.Text = $"Año: {vehiculoSeleccionado.Anio}";
    }

    private void PickerVehiculos_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (pickerVehiculos.SelectedItem)
        {
            case "Sedan":
                vehiculoSeleccionado = new Sedan("Toyota", "Corolla", "Rojo", 2023, "XYZ456", "Gasolina", 200);
                break;
            case "CuatroPorCuatro":
                vehiculoSeleccionado = new CuatroPorCuatro("Jeep", "Wrangler", "Verde", 2023, "ABC123", "Diesel", 180);
                break;
            case "PickUp":
                vehiculoSeleccionado = new PickUp("Ford", "F150", "Negro", 2023, "ABC123", "Diesel", 100);
                break;
            case "SUV":
                vehiculoSeleccionado = new SUV("Tesla", "Model X", "Blanco", 2023, "DEF234", "Electricidad",100);
                break;
        }

        labelMarca.Text = $"Marca: {vehiculoSeleccionado.Marca}";
        labelModelo.Text = $"Modelo: {vehiculoSeleccionado.Modelo}";
        labelColor.Text = $"Color: {vehiculoSeleccionado.Color}";
        labelAnio.Text = $"Año: {vehiculoSeleccionado.Anio}";

        ActualizarListaVehiculos(); // Llama al método para actualizar los datos en la lista
    }


    // Crea un label para mostrar el estado del vehiculo



    private void ButtonEncender_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (!vehiculoSeleccionado.Encendido)
            {
                vehiculoSeleccionado.Encender();
                labelEstado.Text = "Estado: Encendido";

            }
            else
            {
                labelEstado.Text = "Estado: Ya está encendido";
            }
        }
        catch (Exception ex)
        {
            labelEstado.Text = "Error: " + ex.Message;

        }
    }

    private void ButtonApagar_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (vehiculoSeleccionado.Encendido)
            {
                vehiculoSeleccionado.Apagar();
                labelEstado.Text = "Estado: Apagado";
            }
            else
            {
                labelEstado.Text = "Estado: Ya está apagado";
            }
        }
        catch (Exception ex)
        {
            labelEstado.Text = "Error: " + ex.Message;
        }
    }


    private void ButtonAcelerar_Clicked(object sender, EventArgs e)
    {
        try
        {
            vehiculoSeleccionado.Acelerar(10); // Acelera en incrementos de 10
            labelEstado.Text = $"Estado: Acelerando a {vehiculoSeleccionado.VelocidadActual} km/h";
        }
        catch (Exception ex)
        {
            labelEstado.Text = "Error: " + ex.Message;
        }
    }

    private void ButtonFrenar_Clicked(object sender, EventArgs e)
    {
        try
        {
            vehiculoSeleccionado.Frenar(10); // Frena en incrementos de 10
            labelEstado.Text = $"Estado: Frenando a {vehiculoSeleccionado.VelocidadActual} km/h";
        }
        catch (Exception ex)
        {
            labelEstado.Text = "Error: " + ex.Message;
        }
    }
    private void OnCerrarClicked(object sender, EventArgs e)
    {
        // Código para finalizar la aplicación
        System.Environment.Exit(0);
    }
}




