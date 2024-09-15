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
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formcliente = new Form1();
            formcliente.MdiParent = this.MdiParent;
            formcliente.Show();





        }

        private void Principal_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "The quick brown fox. Jump!";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Alert!";
            notifyIcon1.ShowBalloonTip(2000);
            notifyIcon1.Visible = true;

            // Verificar si la lista de clientes está inicializada
            if (GlobalVar.clientes == null)
            {
                GlobalVar.clientes = new List<Cliente>();
            }

            // Solo agregar preclientes si la lista está vacía
            if (!GlobalVar.clientes.Any())
            {
                GlobalVar.clientes.Add(new Cliente { Nombre = "Juan", Apellidos = "Pérez", DineroDisponible = 15000m });
                GlobalVar.clientes.Add(new Cliente { Nombre = "Ana", Apellidos = "García", DineroDisponible = 20000m });
                GlobalVar.clientes.Add(new Cliente { Nombre = "Luis", Apellidos = "Martínez", DineroDisponible = 12000m });
            }

            // Verificar si la lista de vehículos está inicializada
            if (GlobalVar.vehiculoss == null)
            {
                GlobalVar.vehiculoss = new List<Vehiculo>();
            }

            // Solo agregar vehículos predeterminados si la lista está vacía
            if (!GlobalVar.vehiculoss.Any())
            {
                GlobalVar.vehiculoss.Add(new Vehiculo { Marca = "Toyota", Modelo = "Corolla", Año = 2010, Kilometraje = 25000, Precio = 30000000 });
                GlobalVar.vehiculoss.Add(new Vehiculo { Marca = "Toyota", Modelo = "Supra", Año = 2010, Kilometraje = 25000, Precio = 50000000 });
                GlobalVar.vehiculoss.Add(new Vehiculo { Marca = "Toyota", Modelo = "Yaris", Año = 2010, Kilometraje = 25000, Precio = 15000000 });
            }
        }

        private void crearVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas form = new Ventas();
            form.MdiParent = this.MdiParent;
            form.Show();

        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehiculosForms form = new VehiculosForms();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void mantenedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
