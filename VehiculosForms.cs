using DemoCV.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class VehiculosForms : Form
    {
        private string IdGlobal = string.Empty;  // Mejor inicialización

        public VehiculosForms()
        {
            InitializeComponent();
        }

        private void VehiculosForms_Load(object sender, EventArgs e)
        {
            InicializarVehiculosPredeterminados();

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("Id",0);
            listView1.Columns.Add("Marca", 100);
            listView1.Columns.Add("Modelo", 100);
            listView1.Columns.Add("Año", 70);
            listView1.Columns.Add("Kilometraje", 100);
            listView1.Columns.Add("Precio", 100);

            ListarVehiculos();
        }

        private void InicializarVehiculosPredeterminados()
        {
            if (GlobalVar.vehiculoss == null)
            {
                GlobalVar.vehiculoss = new List<Vehiculo>();
            }

            if (!GlobalVar.vehiculoss.Any())  // Verificación de vehículos predeterminados
            {
                GlobalVar.vehiculoss.Add(new Vehiculo { Marca = "Toyota", Modelo = "Corolla", Año = 2010, Kilometraje = 25000, Precio = 30000000 });
                GlobalVar.vehiculoss.Add(new Vehiculo { Marca = "Toyota", Modelo = "Supra", Año = 2010, Kilometraje = 25000, Precio = 50000000 });
                GlobalVar.vehiculoss.Add(new Vehiculo { Marca = "Toyota", Modelo = "Yaris", Año = 2010, Kilometraje = 25000, Precio = 15000000 });
            }
        }

        private void ListarVehiculos()
        {
            listView1.Items.Clear();
            if (GlobalVar.vehiculoss != null)
            {
                foreach (Vehiculo vehiculo in GlobalVar.vehiculoss)
                {
                    listView1.Items.Add(new ListViewItem(vehiculo.itemView()));
                }
            }
            else
            {
                MessageBox.Show("No hay vehículos disponibles.");
            }
        }

        private void btn_guardarVehiculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tx_marca.Text))
            {
                MessageBox.Show("Debes ingresar una marca.");
                tx_marca.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tx_modelo.Text))
            {
                MessageBox.Show("Debes ingresar un modelo.");
                tx_modelo.Focus();
                return;
            }

            if (!int.TryParse(tx_año.Text, out int año))
            {
                MessageBox.Show("Ingresa un año válido.");
                tx_año.Focus();
                return;
            }

            if (!int.TryParse(tx_km.Text, out int kilometraje))
            {
                MessageBox.Show("Ingresa un kilometraje válido.");
                tx_km.Focus();
                return;
            }

            if (!decimal.TryParse(txPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Ingresa un monto de precio válido.");
                txPrecio.Focus();
                return;
            }

            Vehiculo vehiculo = new Vehiculo()
            {
                Marca = tx_marca.Text,
                Modelo = tx_modelo.Text,
                Año = año,
                Kilometraje = kilometraje,
                Precio = precio
            };

            if (string.IsNullOrEmpty(IdGlobal))
            {
                GlobalVar.vehiculoss.Add(vehiculo);
                MessageBox.Show("Vehículo almacenado.");
            }
            else
            {
                var vehiculoModificar = GlobalVar.vehiculoss.FirstOrDefault(x => x.Id == IdGlobal);
                if (vehiculoModificar != null)
                {
                    vehiculoModificar.Marca = tx_marca.Text;
                    vehiculoModificar.Modelo = tx_modelo.Text;
                    vehiculoModificar.Año = año;
                    vehiculoModificar.Kilometraje = kilometraje;
                    vehiculoModificar.Precio = precio;

                    IdGlobal = string.Empty;
                    MessageBox.Show("Elemento Modificado");
                }
                else
                {
                    MessageBox.Show("Vehículo no encontrado.");
                }

                txPrecio.Text = "";
                tx_año.Text = "";
                tx_km.Text = "";
                tx_marca.Text = "";
                tx_modelo.Text = "";
            }

            ListarVehiculos();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string Id = listView1.SelectedItems[0].Text;
                var vehiculoEliminar = GlobalVar.vehiculoss.FirstOrDefault(x => x.Id == Id);
                if (vehiculoEliminar != null)
                {
                    GlobalVar.vehiculoss.Remove(vehiculoEliminar);
                    ListarVehiculos();
                    MessageBox.Show("Elemento eliminado");
                }
                else
                {
                    MessageBox.Show("Vehículo no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un vehículo para eliminar.");
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string Id = listView1.SelectedItems[0].Text;
                IdGlobal = Id;
                var vehiculoModificar = GlobalVar.vehiculoss.FirstOrDefault(x => x.Id == Id);
                if (vehiculoModificar != null)
                {
                    txPrecio.Text = Convert.ToString(vehiculoModificar.Precio);
                    tx_año.Text = Convert.ToString(vehiculoModificar.Año);
                    tx_km.Text = Convert.ToString(vehiculoModificar.Kilometraje);
                    tx_marca.Text = vehiculoModificar.Marca;
                    tx_modelo.Text = vehiculoModificar.Modelo;
                }
                else
                {
                    MessageBox.Show("Vehículo no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un vehículo para modificar.");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
