public class Vehiculo
{
    public string Id {  get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }
    public int Kilometraje { get; set; }
    public decimal Precio { get; set; }

    public string[] itemView()
    {
        return new string[] { Id,Marca, Modelo, Año.ToString(), Kilometraje.ToString(), Precio.ToString() };
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Id:{Id}, Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Kilometraje: {Kilometraje}, Precio: {Precio}");
    }
    public Vehiculo()
    {
        Guid guid = Guid.NewGuid();
        Id = guid.ToString();
    }


    public override bool Equals(object obj)
    {
        if (obj is Vehiculo otroVehiculo)
        {
            return Id== otroVehiculo.Id &&
                   Marca == otroVehiculo.Marca &&
                   Modelo == otroVehiculo.Modelo &&
                   Año == otroVehiculo.Año &&
                   Kilometraje == otroVehiculo.Kilometraje &&
                   Precio == otroVehiculo.Precio;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id,Marca, Modelo, Año, Kilometraje, Precio);
    }
}
