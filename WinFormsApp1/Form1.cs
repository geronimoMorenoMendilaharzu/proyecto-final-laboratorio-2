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

namespace WinFormsApp1
{
    public partial class Frm1 : Form
    {
        CN_productos objectoCN = new CN_productos();
        double precio = 0;

        public Frm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblPrueba_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            lblPrecio.Text = "$";
            precio = 0;
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lb1.Items.RemoveAt(lb1.SelectedIndex);     
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm2 nuevaVentana = new Frm2(lblPrecio.Text);
            nuevaVentana.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if(txtDescuento.Text == "10")
            {
                precio = precio - (precio * 0.1);
                lblPrecio.Text = "$" + precio.ToString();
            }
            if (txtDescuento.Text == "15")
            {
                precio = precio - (precio * 0.15);
                lblPrecio.Text = "$" + precio.ToString();
            }
        }

        private void cbHamburguesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            double precioHamburguesa = 0;
            if(cbHamburguesas.SelectedItem == "McNifica")
            {
                precioHamburguesa = 850;
                lb1.Items.Add("McNifica");
                precio = precio + precioHamburguesa;
                lblPrecio.Text = "$" + precio.ToString();
            }
            if (cbHamburguesas.SelectedItem == "Big Mac")
            {
                precioHamburguesa = 850;
                lb1.Items.Add("Big Mac");
                precio = precio + precioHamburguesa;
                lblPrecio.Text = "$" + precio.ToString();
            }
            if (cbHamburguesas.SelectedItem == "Cuarto de Libra")
            {
                precioHamburguesa = 850;
                lb1.Items.Add("Cuarto de Libra");
                precio = precio + precioHamburguesa;
                lblPrecio.Text = "$" + precio.ToString();
            }
            if (cbHamburguesas.SelectedItem == "D. Cuarto de Libra")
            {
                precioHamburguesa = 850;
                lb1.Items.Add("D. Cuarto de Libra");
                precio = precio + precioHamburguesa;
                lblPrecio.Text = "$" + precio.ToString();
            }
            if (cbHamburguesas.SelectedItem == "McBacon")
            {
                precioHamburguesa = 850;
                lb1.Items.Add("McBacon");
                precio = precio + precioHamburguesa;
                lblPrecio.Text = "$" + precio.ToString();
            }
            if (cbHamburguesas.SelectedItem == "McPollo Crispy")
            {
                precioHamburguesa = 850;
                lb1.Items.Add("McPollo");
                precio = precio + precioHamburguesa;
                lblPrecio.Text = "$" + precio.ToString();
            }

        }

        private void cbCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            double precioCombo = 0;
            if (cbCombo.SelectedItem == "Combo Pequeño")
            {
                precioCombo = 50;
                lb1.Items.Add("Combo Pequeño");
                precio = precio - precioCombo;
                lblPrecio.Text = "$" + precio.ToString();
            }
            if (cbCombo.SelectedItem == "Combo Grande")
            {
                precioCombo = 50;
                lb1.Items.Add("Combo Grande");
                precio = precio + precioCombo;
                lblPrecio.Text = "$" + precio.ToString();
            }
        }

        private void txtGaseosa_TextChanged(object sender, EventArgs e)
        {
            if(txtGaseosa.Text == "coca cola")
            {
                lb1.Items.Add("Coca Cola");
            }
            if (txtGaseosa.Text == "coca zero")
            {
                lb1.Items.Add("Coca Cola Zero");
            }
            if (txtGaseosa.Text == "fanta")
            {
                lb1.Items.Add("Fanta");
            }
            if (txtGaseosa.Text == "sprite")
            {
                lb1.Items.Add("Sprite");
            }
            if (txtGaseosa.Text == "agua")
            {
                lb1.Items.Add("Agua");
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPepino.Checked)
            {
                lb1.Items.Add("Sin Pepino");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMostaza.Checked)
            {
                lb1.Items.Add("Sin Mostaza");
            }
        }

        private void rbMayo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMayo.Checked)
            {
                lb1.Items.Add("Sin Mayonesa");
            }
        }

        private void rbKetchup_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKetchup.Checked)
            {
                lb1.Items.Add("Sin Ketchup");
            }
        }

        private void rbCebolla_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCebolla.Checked)
            {
                lb1.Items.Add("Sin Cebolla");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblDia_Click(object sender, EventArgs e)
        {
            lblDia.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDia.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvCombos.DataSource = objectoCN.mostrarProd();
        }

        private void dgvCombos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCombos.DataSource = objectoCN.mostrarProd();
        }
    }
}
