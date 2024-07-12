using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        private string idProducto = null;
        private bool Editar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }
        private void MostrarProductos()
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void btnGuaradar_Click(object sender, EventArgs e)
        {
            //todo INSERTAR
            if (Editar == false)
            {

                try
                {
                    objetoCN.InsertarPRod(txtNombre.Text, txtDesc.Text, txtmarca.Text, txtPrecio.Text, txtStock.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarProductos();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //todo EDITAR
            if (Editar == true)
            {

                try
                {
                    objetoCN.EditarProd(txtNombre.Text, txtDesc.Text, txtmarca.Text, txtPrecio.Text, txtStock.Text, idProducto);
                    MessageBox.Show("se edito correctamente");
                    MostrarProductos();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo esitar datos por: " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                txtmarca.Text = dataGridView1.CurrentRow.Cells["marca"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }

        private void limpiarForm()
        {
            txtNombre.Clear();
            txtDesc.Clear();
            txtmarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                objetoCN.EliminarProd(idProducto);
                MessageBox.Show("Eliminado Correctamente");
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
