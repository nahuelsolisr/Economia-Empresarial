﻿using MaterialSkin;
using MaterialSkin.Controls;
using SistemaEE.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic.Logging;
using static SistemaEE.Formularios.Entrada;
using static System.Resources.ResXFileRef;
using SistemaEE.AccesoDatos;

namespace SistemaEE.Formularios
{
    public partial class Entrada : MaterialForm
    {

        private List<Producto> carrito = new List<Producto>();
        public static int unidadesE;
        public static decimal precioUE, precioGanancia;

        public Entrada()
        {
            InitializeComponent();
            //
            this.Size = new Size(1132, 601);
            this.Resize += (sender, e) => this.Size = new Size(1132, 601);
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = true;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            //
            if (Datos.modoOscuro)
            {
                EstiloOscuro();
            }
            else
            {
                EstiloClaro();


            }
        }
        public void EstiloClaro()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        public void EstiloOscuro()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; // Cambiar a tema oscuro
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE); // Ajustar colores para modo oscuro
        }
        //CLASE DEL PRODUCTO
        public class Producto
        {
            public string Id { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
            public decimal Ganancia { get; set; }
            public string nombre { get; set; }
        }

        //METODO PARA LIMPIAR
        public void Limpiar()
        {
            dgvCarrito.Rows.Clear();
            txt_precio.Text = "";
            txt_idproducto.Text = "";
            txt_nombreProducto.Text = "";
            txt_cantidad.Text = "";
            nud_ganancia.Value = 0;


        }

        //METODOS PARA OBTENER EL VALOR DE EXISTENCIA 
        //SI NO EXISTE LO TRANSFORMO EN 0  
        public static int ObtenerUnidadesExistentes()
        {

            string consulta = "SELECT SUM(UnidadesEx) FROM fichastock";
            SqlCommand comando = new SqlCommand(consulta, DB.ConexionConBD);
            object resultado = comando.ExecuteScalar();
            int unidadesExistentes = 0;

            if (resultado != null && !Convert.IsDBNull(resultado))
            {
                unidadesExistentes = Convert.ToInt32(resultado);
            }

            return unidadesExistentes;
        }
        public static decimal ObtenerPrecioUExistentes()
        {
            string consulta = "SELECT AVG(PrecioUEx) FROM fichastock";
            SqlCommand comando = new SqlCommand(consulta, DB.ConexionConBD);
            object resultado = comando.ExecuteScalar();
            decimal precioUExistente = 0;

            if (resultado != null && !Convert.IsDBNull(resultado))
            {
                precioUExistente = Convert.ToDecimal(resultado);
            }

            return precioUExistente;
        }

        public static decimal ObtenerTotalExistentes()
        {
            string consulta = "SELECT SUM(TotalEx) FROM fichastock";
            SqlCommand comando = new SqlCommand(consulta, DB.ConexionConBD);
            object resultado = comando.ExecuteScalar();
            decimal totalExistente = 0;

            if (resultado != null && !Convert.IsDBNull(resultado))
            {
                totalExistente = Convert.ToDecimal(resultado);
            }

            return totalExistente;
        }

        private void btn_traerProv_Click(object sender, EventArgs e)
        {
            MuestraProveedor muestraProveedor = new MuestraProveedor();
            muestraProveedor.ShowDialog();
            txt_cuit.Text = Datos.cuit_prov.ToString();
            txt_provNombre.Text = Datos.nom_prov;
        }

        private void btn_traerProduc_Click(object sender, EventArgs e)
        {
            MuestraProductos muestraProductos = new MuestraProductos();
            muestraProductos.ShowDialog();
            txt_idproducto.Text = Datos.idProducto.ToString();
            txt_nombreProducto.Text = Datos.nomProducto;
        }

        private void btn_agregarCarrito_Click(object sender, EventArgs e)
        {

            // Obtén los datos del producto del formulario
            string idProducto = txt_idproducto.Text;
            string nombreProducto = txt_nombreProducto.Text;
            decimal precio = Convert.ToDecimal(txt_precio.Text);
            int cantidad = Convert.ToInt32(txt_cantidad.Text);
            decimal ganancia = nud_ganancia.Value;

            // Crea un objeto Producto con los datos obtenidos
            Producto producto = new Producto
            {
                Id = idProducto,
                Precio = precio,
                Cantidad = cantidad,
                nombre = nombreProducto,
                Ganancia = (decimal)nud_ganancia.Value
            };

            // Agrega el producto al carrito
            carrito.Add(producto);
            // Agrega el producto a la DataGridView
            dgvCarrito.Rows.Add(nombreProducto, precio, cantidad, ganancia);
            btn_ConfirmarCompra.Visible = true;
        }

        private void btn_ConfirmarCompra_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de realizar esta compra?", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                ConectaDB.AbrirDB();
                foreach (Producto producto in carrito)
                {
                    int contador = 0;
                    string cant = $"Select cantidad from productos where id_producto = {producto.Id}";
                    int cantidadActual = 0;

                    // Realiza la lectura de la base de datos para obtener la cantidad actual del producto
                    using (var reader = ConectaDB.LecturaDB(cant))
                    {
                        if (reader.Read())
                        {
                            object cantidadObj = reader["cantidad"];
                            if (cantidadObj != DBNull.Value)
                            {
                                cantidadActual = Convert.ToInt32(cantidadObj);
                            }
                            else
                            {
                                // Valor nulo, maneja el caso según tus necesidades (por ejemplo, asignar un valor predeterminado)
                                cantidadActual = 0;
                            }
                        }
                    }
                    int cantidadNetaEntrada = cantidadActual + producto.Cantidad;
                    decimal total_stock = cantidadNetaEntrada * producto.Precio;
                    total_stock.ToString();
                    // Actualiza los datos del producto en la base de datos
                    string updateEntrada = $"UPDATE productos SET cantidad = '{cantidadNetaEntrada}', precio = '{producto.Precio}', porcentajeg = '{producto.Ganancia}' WHERE id_producto = {producto.Id}";
                    ConectaDB.CargarDB(updateEntrada);
                    //decimal totalEntrada = producto.Precio * producto.Cantidad;
                    //totalEntrada.ToString();

                    //Realiza el insert en la tabla "fichastock"
                    DateTime fechaActual = DateTime.Now;
                    string fechaActualString = fechaActual.ToString("dd/MM/yyyy");
                    unidadesE = producto.Cantidad;
                    precioUE = producto.Precio;
                    decimal totalE = producto.Cantidad * producto.Precio;
                    string unidadesEx = cantidadNetaEntrada.ToString();
                    string precioUEx = producto.Precio.ToString();
                    decimal totalEx = precioUE * cantidadNetaEntrada;
                    string concepto = "COMPRA";

                    //verifica si las unidades existentes son igual a 0 ahora pasan a ser las entradas sino se le suma las entradas mas las que ya tienen   


                    //hace el insert en stock
                    string insertStock = $"INSERT INTO fichastock (fecha, nombreProducto ,IdProducto, Concepto, UnidadesE, PrecioUE, TotalE, UnidadesEx, PrecioUEx, TotalEx) " +
                        $"VALUES ('{fechaActualString}' ,'{producto.nombre}', '{producto.Id}', '{concepto}', '{unidadesE}', '{precioUE}', '{totalE}', '{unidadesEx}', '{precioUEx}', '{totalEx}')";
                    ConectaDB.CargarDB(insertStock);

                }
                // Agrega 
                MessageBox.Show("Su compra ha sido realizada");
                ConectaDB.CerrarDB();
                Limpiar();
                carrito.Clear();
                nud_ganancia.Enabled = false;
                // ComprobanteCompra();
                lbl_precioVenta.Text = "";
            }
            else { }
        }
        public void ComprobanteCompra()
        {


        }

        private void Entrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            dgvCarrito.ClearSelection();
            Limpiar();
        }

        private void nud_ganancia_MouseCaptureChanged(object sender, EventArgs e)
        {
            // Obtener el valor del slider
            int valorSlider = (int)nud_ganancia.Value;

            // Calcular el porcentaje de ganancia
            decimal porcentajeGanancia = valorSlider / 100M;

            // Calcular el precio de venta
            decimal precioVenta = precioGanancia + (precioGanancia * porcentajeGanancia);

            // Formatear el precio de venta con separador de miles y mantener la coma como separador decimal
            string precioFormateado = precioVenta.ToString("#,##0.00");

            // Mostrar el resultado en lbl_precioVenta
            lbl_precioVenta.Text = precioFormateado + "$";
        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {




        }

        private void KeyPressValidarPrecio(object sender, KeyPressEventArgs e)
        {
            MaterialSkin.Controls.MaterialTextBox textBox = (MaterialSkin.Controls.MaterialTextBox)sender;
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_precio, "Solo se admiten numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();

            if (e.KeyChar >= 45 && e.KeyChar <= 47)
            {
                errorProvider1.SetError(txt_precio, "Solo se admiten comas");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();

            //Permitir números, comas y teclas de control(como retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Ignorar el carácter ingresado
            }

            // Permitir solo una coma en el campo
            if (e.KeyChar == ',' && textBox.Text.Contains(","))
            {
                e.Handled = true; // Ignorar la coma adicional
            }
        }

        private void KeyPressValidarCantidad(object sender, KeyPressEventArgs e)
        {
            MaterialSkin.Controls.MaterialTextBox textBox = (MaterialSkin.Controls.MaterialTextBox)sender;
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_cantidad, "Solo se admiten numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();

            if (e.KeyChar >= 45 && e.KeyChar <= 47)
            {
                errorProvider1.SetError(txt_cantidad, "Solo se admiten comas");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();

            //Permitir números, comas y teclas de control(como retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Ignorar el carácter ingresado
            }

            // Permitir solo una coma en el campo
            if (e.KeyChar == ',' && textBox.Text.Contains(","))
            {
                e.Handled = true; // Ignorar la coma adicional
            }
        }

        private void nud_ganancia_TextChanged(object sender, EventArgs e)
        {

        }

        private void nud_ganancia_Click(object sender, EventArgs e)
        {
            precioGanancia = Convert.ToDecimal(txt_precio.Text);
        }

        private void txt_cantidad_Click(object sender, EventArgs e)
        {
            nud_ganancia.Enabled = true;
        }
    }
}
