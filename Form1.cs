using DemoCV.clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string IdGlobal = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializar clientes predeterminados
            InicializarClientesPredeterminados();

            // Configurar ListView
            listView1.View = View.Details;
            listView1.GridLines = true;

            // Agregar columnas al ListView
            listView1.Columns.Add("ID", 0);
            listView1.Columns.Add("Nombre", 100);
            listView1.Columns.Add("Apellido", 100);
            listView1.Columns.Add("Dinero", 100);


            // Cargar clientes en el ListView
            ListarClientes();
        }

        private void InicializarClientesPredeterminados()
        {
            // Asegurarse de que la lista de clientes esté inicializada
            if (GlobalVar.clientes == null)
            {
                GlobalVar.clientes = new List<Cliente>();
            }

            // Verificar si ya se han agregado clientes predeterminados
            if (GlobalVar.clientes.Count == 0)
            {
                // Agregar clientes predeterminados
                GlobalVar.clientes.Add(new Cliente { Nombre = "Juan", Apellidos = "Pérez", DineroDisponible = 15000m });
                GlobalVar.clientes.Add(new Cliente { Nombre = "Ana", Apellidos = "García", DineroDisponible = 20000m });
                GlobalVar.clientes.Add(new Cliente { Nombre = "Luis", Apellidos = "Martínez", DineroDisponible = 12000m });
            }
        }


        private void ListarClientes()
        {
            listView1.Items.Clear();
            if (GlobalVar.clientes != null)
            {
                foreach (Cliente cliente in GlobalVar.clientes)
                {
                    listView1.Items.Add(new ListViewItem(cliente.itemView()));
                }
            }
            else
            {
                MessageBox.Show("No hay clientes disponibles.");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (String.IsNullOrEmpty(tx_nombre.Text))
            {
                MessageBox.Show("Debes ingresar un nombre.");
                tx_nombre.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_apellido.Text))
            {
                MessageBox.Show("Debes ingresar un apellido.");
                tx_apellido.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_dinero.Text))
            {
                MessageBox.Show("Debes ingresar un dinero.");
                tx_dinero.Focus();
                return;
            }

            decimal lukas;
            bool isOk = decimal.TryParse(tx_dinero.Text, out lukas);
            if (!isOk)
            {
                MessageBox.Show("Ingresa un monto de dinero válido.");
                tx_dinero.Focus();
                return;
            }

            // Crear nuevo cliente
            Cliente cliente = new Cliente()
            {
                Nombre = tx_nombre.Text,
                Apellidos = tx_apellido.Text,
                DineroDisponible = lukas
            };

            if (String.IsNullOrEmpty(IdGlobal))
            {
                GlobalVar.clientes.Add(cliente);
                MessageBox.Show("Cliente almacenado.");
            }
            else
            {
                Cliente cliente_Modificar =
                GlobalVar.clientes.Where(x => x.Id == IdGlobal).FirstOrDefault()!;
                cliente_Modificar.Nombre = tx_nombre.Text;
                cliente_Modificar.Apellidos = tx_apellido.Text;
                cliente_Modificar.DineroDisponible = Convert.ToDecimal(tx_dinero.Text);
                IdGlobal = "";
                tx_nombre.Text = "";
                tx_apellido.Text = "";
                tx_dinero.Text = "";
                MessageBox.Show("Elemento Modificado");


            }

            ListarClientes();
                
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Id = listView1.SelectedItems[0].Text;
            Cliente cliente_eliminar = GlobalVar.clientes.Where(x => x.Id == Id).FirstOrDefault()!;
            GlobalVar.clientes.Remove(cliente_eliminar);
            ListarClientes();
            MessageBox.Show("Elemento eliminado");
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Id = listView1.SelectedItems[0].Text;
            IdGlobal=Id;
            Cliente cliente_Modificar = GlobalVar.clientes.Where(x => x.Id == Id).FirstOrDefault()!;
           tx_nombre.Text = cliente_Modificar.Nombre;
            tx_apellido.Text = cliente_Modificar.Apellidos;
            tx_dinero.Text = Convert.ToString(cliente_Modificar.DineroDisponible);

           

        }
    }
}
