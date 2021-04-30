﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion
{
    public partial class VistaMarcas : Form
    {
        public VistaMarcas()
        {
            InitializeComponent();
        }

        private void VistaMarcas_Load(object sender, EventArgs e)
        {
            cargarGrillaMarcas();
        }

        private void cargarGrillaMarcas()
        {
            MarcaNegocio marcas = new MarcaNegocio();
            try
            {
                List<Marca> lista = marcas.listar();
                dGVMarcas.DataSource = lista;
                //dGVMarcas.Columns["Nombre"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarMarca_Click(object sender, EventArgs e)
        {
            agregarMarca agregarMarca = new agregarMarca();
            agregarMarca.ShowDialog();

            cargarGrillaMarcas();
        }

        private void EliminarMarca_Click(object sender, EventArgs e)
        {
            Marca seleccionado = (Marca)dGVMarcas.CurrentRow.DataBoundItem;
            MarcaNegocio marcaN = new MarcaNegocio();
            
            MessageBox.Show("Esta seguro que sea desea eliminar la marca: " + seleccionado.Nombre + ".", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            marcaN.eliminar(seleccionado);

            cargarGrillaMarcas();
        }

        private void EditarMarca_Click(object sender, EventArgs e)
        {
            Marca seleccionado = (Marca)dGVMarcas.CurrentRow.DataBoundItem;
            modificarMarca modificarMarca = new modificarMarca(seleccionado);
            modificarMarca.ShowDialog();

            cargarGrillaMarcas();
        }
    }
}
