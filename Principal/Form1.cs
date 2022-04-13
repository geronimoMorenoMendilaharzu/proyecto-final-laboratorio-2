using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;
using CapaDatos;



namespace Principal
{
    public partial class Form1 : Form
    {
        CN_productos objectoCN = new CN_productos();
        CN_productos objectoCN1 = new CN_productos();
        private string idProducto = null;
        private bool Editar = false;
        double PrecionHa = 0;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarProductos();
        }
        private void mostrarProductos()
        {
            
            dgvVentas.DataSource = objectoCN.mostrarProd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = objectoCN.mostrarProd();
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbHamburguesas.SelectedItem == "McNifica")
            {
                PrecionHa = 800;
                txtPrecio.Text =  PrecionHa.ToString();
            }
            if (cbHamburguesas.SelectedItem == "Big Mac")
            {
                PrecionHa = 700;
                txtPrecio.Text =  PrecionHa.ToString();
            }
            if (cbHamburguesas.SelectedItem == "Cuarto de Libra")
            {
                PrecionHa = 760;
                txtPrecio.Text =  PrecionHa.ToString();
            }
            if (cbHamburguesas.SelectedItem == "D. Cuarto de Libra")
            {
                PrecionHa = 860;
                txtPrecio.Text =  PrecionHa.ToString();
            }
            if (cbHamburguesas.SelectedItem == "McBacon")
            {
                PrecionHa = 900;
                txtPrecio.Text =   PrecionHa.ToString();
            }
            if (cbHamburguesas.SelectedItem == "McPollo Crispy")
            {
                PrecionHa = 880;
                txtPrecio.Text =  PrecionHa.ToString();
            }
        }
        CD_productos cd = new CD_productos();
        private void Form1_Load(object sender, EventArgs e)
        {

            //Hamburguesas
             cbHamburguesas.Items.Add("McNifica");
             cbHamburguesas.Items.Add("Big Mac");
             cbHamburguesas.Items.Add("Cuarto de Libra");
             cbHamburguesas.Items.Add("D. Cuarto de Libra");
             cbHamburguesas.Items.Add("McBacon");
             cbHamburguesas.Items.Add("McPollo Crispy");
             //Tamaño
            cbTamaño.Items.Add("Combo Pequeño");
             cbTamaño.Items.Add("Combo Regular");
             cbTamaño.Items.Add("Combo Grande");
            //Bebidas
            cbBebidas.DataSource = cd.CargarCombo();
            cbBebidas.DisplayMember = "Nombre";
            cbBebidas.ValueMember = "Id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = objectoCN1.mostrarProd1();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objectoCN.InsertarPRod(txtPrecio.Text, cbHamburguesas.Text, cbTamaño.Text, cbBebidas.Text);
                    MessageBox.Show("Los datos Fueron Ingresados Correctamente");
                    objectoCN.mostrarProd();
                   
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }

            if (Editar == true)
            {
                try
                {
                    objectoCN.EditarPRod(txtPrecio.Text, cbHamburguesas.Text, cbTamaño.Text, cbBebidas.Text,idProducto);
                    MessageBox.Show("Los datos Fueron Ingresados Correctamente");
                    objectoCN.mostrarProd();
                                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }

        }

       private  void btnEditar_Click(object sender, EventArgs e)
        {
            {
                if (dgvVentas.SelectedRows.Count > 0)
                {
                   Editar = true;
                   txtPrecio.Text = dgvVentas.CurrentRow.Cells["Precio"].Value.ToString();
                   cbHamburguesas.Text = dgvVentas.CurrentRow.Cells["Nombre"].Value.ToString();
                   cbTamaño.Text = dgvVentas.CurrentRow.Cells["Tamaño"].Value.ToString();
                   cbBebidas.Text = dgvVentas.CurrentRow.Cells["Bebidas"].Value.ToString();
                   idProducto = dgvVentas.CurrentRow.Cells["Id"].Value.ToString();
                }
                else
                    MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

           
        }

        private void cbTamaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTamaño.SelectedItem == "Combo Pequeño")
            {
                PrecionHa = PrecionHa - 50;
                txtPrecio.Text =  PrecionHa.ToString();
            }
            if (cbTamaño.SelectedItem == "Combo Grande")
            {
                PrecionHa = PrecionHa + 50;
                txtPrecio.Text =  PrecionHa.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Total = 0;
            for (int i = 0; i < dgvVentas.RowCount; i++)
            {
                Total += Convert.ToInt32(dgvVentas.Rows[i].Cells[1].Value);
            }
            MessageBox.Show("Total del dia:  $" + Total.ToString());
            }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Creditos nuevaVentana = new Creditos(cbBebidas.Text);
            nuevaVentana.Show();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        { 

            if (dgvVentas.SelectedRows.Count > 0)
            {
                idProducto = dgvVentas.CurrentRow.Cells["Id"].Value.ToString();
                objectoCN.EliminarPRod(idProducto);
                MessageBox.Show("Eliminado correctamente");
                dgvProductos.DataSource = objectoCN1.mostrarProd();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            {
                if (dgvVentas.SelectedRows.Count > 0)
                {
                    Editar = true;
                    txtPrecio.Text = dgvVentas.CurrentRow.Cells["Precio"].Value.ToString();
                    cbHamburguesas.Text = dgvVentas.CurrentRow.Cells["Nombre"].Value.ToString();
                    cbTamaño.Text = dgvVentas.CurrentRow.Cells["Tamaño"].Value.ToString();
                    cbBebidas.Text = dgvVentas.CurrentRow.Cells["bebidas"].Value.ToString();
                    idProducto = dgvVentas.CurrentRow.Cells["Id"].Value.ToString();
                }
                else
                    MessageBox.Show("seleccione una fila por favor");
            }
        }

        
    }
}
