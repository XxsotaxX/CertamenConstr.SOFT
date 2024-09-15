using System.Collections.Generic;
using DemoCV.clases;

namespace WinFormsApp1
{
    public static class GlobalVar
    {
        public static Inventario Inventario = new Inventario();
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Vehiculo> vehiculoss = new List<Vehiculo>();

        public static bool ClientesAgregados = false; // Marca si los clientes predeterminados ya se agregaron
        public static bool VehiculosAgregados = false; // Marca si los vehículos predeterminados ya se agregaron

        // Agrega la propiedad concesionario si es necesaria
        public static Concesionario concesionario;
    }
}
