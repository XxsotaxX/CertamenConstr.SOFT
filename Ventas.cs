using DemoCV.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Ventas_FormClosing);
        }


        private void Ventas_Load(object sender, EventArgs e)
        {
            cargaClientes();
            cargaVehiculos();
            CargarVentas(); // Cargar los datos del ListBox al iniciar
        }

        void cargaClientes()
        {
            cb_clientes.Items.Clear();
            if (GlobalVar.clientes != null)
            {
                cb_clientes.Items.AddRange(GlobalVar.clientes.ToArray());
            }
            else
            {
                MessageBox.Show("No hay clientes disponibles.");
            }

        }

        void cargaVehiculos()
        {
            cb_vehiculo.Items.Clear(); // Limpia el ComboBox

            if (GlobalVar.vehiculoss == null || !GlobalVar.vehiculoss.Any())
            {
                MessageBox.Show("No hay vehículos disponibles.");
                return;
            }

            cb_vehiculo.DisplayMember = "Display"; // Campo ficticio para mostrar la cadena personalizada
            cb_vehiculo.ValueMember = "Precio";    // Propiedad a usar como valor del ítem

            var vehiculosConDisplay = GlobalVar.vehiculoss.Select(v => new
            {
                Display = $"{v.Marca} {v.Modelo}",
                v.Precio
            }).ToList();

            cb_vehiculo.DataSource = vehiculosConDisplay;
        }



        private void cb_vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cb_vehiculo.SelectedItem as dynamic;
            if (selectedItem != null)
            {
                tx_precio.Text = selectedItem.Precio.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Validar si se ha seleccionado un cliente y un vehículo
            if (cb_clientes.SelectedItem == null || cb_vehiculo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente y un vehículo.");
                return;
            }

            Cliente clienteSeleccionado = cb_clientes.SelectedItem as Cliente;
            var selectedItem = cb_vehiculo.SelectedItem as dynamic;
            string vehiculoMarcaModelo = selectedItem?.Display;

            if (clienteSeleccionado == null || string.IsNullOrEmpty(vehiculoMarcaModelo))
            {
                MessageBox.Show("Error al obtener los datos seleccionados.");
                return;
            }

            // Registrar la venta
            Vehiculo vehiculoSeleccionado = GlobalVar.vehiculoss.FirstOrDefault(v => $"{v.Marca} {v.Modelo}" == vehiculoMarcaModelo);
            if (vehiculoSeleccionado != null)
            {
                GlobalVar.concesionario.RegistrarVenta(vehiculoSeleccionado, clienteSeleccionado);

                // Mostrar en el ListBox
                string ventaInfo = $"{clienteSeleccionado.Nombre} {clienteSeleccionado.Apellidos} - {vehiculoSeleccionado.Marca} {vehiculoSeleccionado.Modelo}";
                listBox1.Items.Add(ventaInfo);
            }
            else
            {
                MessageBox.Show("Vehículo no encontrado.");
            }
        }


        private void GuardarVentas()
        {
            var ventas = new StringBuilder();
            foreach (var item in listBox1.Items)
            {
                ventas.AppendLine(item.ToString());
            }
            System.IO.File.WriteAllText("ventas.txt", ventas.ToString());
        }

        private void CargarVentas()
        {
            if (System.IO.File.Exists("ventas.txt"))
            {
                var ventas = System.IO.File.ReadAllLines("ventas.txt");
                listBox1.Items.AddRange(ventas);
            }
        }


        private void cb_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx_precio_TextChanged(object sender, EventArgs e)
        {

        }


        private void Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarVentas(); // Guardar los datos del ListBox al cerrar el formulario
        }
    }
}
