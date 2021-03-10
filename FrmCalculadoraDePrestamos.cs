using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculadoraDePrestamos.CustomControl;
using CalculadoraDePrestamos.LogicLayers;

namespace CalculadoraDePrestamos
{
    public partial class FrmCalculadoraDePrestamos : Form
    {
       

        public FrmCalculadoraDePrestamos()
        {
            InitializeComponent();
        }

        private void LblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void FrmCalculadoraDePrestamos_Load(object sender, EventArgs e)
        {
            LoadComboBox1();
            LoadComboBox2();
        }

        /*Metodo Para cargar los Tipo de Prestamos*/
        private void LoadComboBox1()
        {
            

            ComboBoxItem1 OpcDefecto = new ComboBoxItem1
            {
                Text = "Seleccione una opcion",
                Value = null,
                
                
            };

            ComboBoxItem1 Personal = new ComboBoxItem1
            {
                Text = "Personal",
                Value = (int)EnumTipoDePrestamo.Personal
            };

            ComboBoxItem1 Automovil = new ComboBoxItem1
            {
                Text = "Automovil",
                Value = (int)EnumTipoDePrestamo.Automovil
            };

            ComboBoxItem1 Hipotecario = new ComboBoxItem1
            {
                Text = "Hipotecario",
                Value = (int)EnumTipoDePrestamo.Hipotecario
            };

            CbxTipoDePrestamo.Items.Add(OpcDefecto);
            CbxTipoDePrestamo.Items.Add(Personal);
            CbxTipoDePrestamo.Items.Add(Automovil);
            CbxTipoDePrestamo.Items.Add(Hipotecario);

            CbxTipoDePrestamo.SelectedItem = OpcDefecto;
        }



/*Metodo de Cuotas Mensuales*/
        private void LoadComboBox2()
        {
            ComboBoxItem1 Doce = new ComboBoxItem1
            {
                Text = "12",
                Value = 1
            };

            ComboBoxItem1 Dieciocho = new ComboBoxItem1
            {
                Text = "18",
                Value = 2
            };

            ComboBoxItem1 Veinticuatro = new ComboBoxItem1
            {
                Text = "24",
                Value = 3
            };

            ComboBoxItem1 Treinta = new ComboBoxItem1
            {
                Text = "30",
                Value = 4
            };

            ComboBoxItem1 TreintaySeis = new ComboBoxItem1
            {
                Text = "36",
                Value = 5
            };

            ComboBoxItem1 CuaretaYDos= new ComboBoxItem1
            {
                Text = "42",
                Value = 6
            };

            ComboBoxItem1 CuarentaYOcho = new ComboBoxItem1
            {
                Text = "48",
                Value = 7
            };

            ComboBoxItem1 CincuentaYCuatro = new ComboBoxItem1
            {
                Text = "54",
                Value = 8
            };

            ComboBoxItem1 Sesenta = new ComboBoxItem1
            {
                Text = "60",
                Value = 9
            };

            ComboBoxItem1 SesentaYSeis = new ComboBoxItem1
            {
                Text = "66",
                Value = 10
            };

            ComboBoxItem1 SetentaYDos = new ComboBoxItem1
            {
                Text = "72",
                Value = 11
            };

            ComboBoxItem1 SetentaYOcho = new ComboBoxItem1
            {
                Text = "78",
                Value = 12
            };

            ComboBoxItem1 OchentaYCuatro = new ComboBoxItem1
            {
                Text = "84",
                Value = 13
            };

            ComboBoxItem1 Noventa = new ComboBoxItem1
            {
                Text = "90",
                Value = 14
            };

            ComboBoxItem1 NoventaYSeis = new ComboBoxItem1
            {
                Text = "96",
                Value = 15
            };

            ComboBoxItem1 CientoDos = new ComboBoxItem1
            {
                Text = "102",
                Value = 16
            };

            ComboBoxItem1 CientoOcho = new ComboBoxItem1
            {
                Text = "108",
                Value = 17
            };

            ComboBoxItem1 CientoCatorce = new ComboBoxItem1
            {
                Text = "114",
                Value = 18
            };

            ComboBoxItem1 CientoVeinte = new ComboBoxItem1
            {
                Text = "120",
                Value = 19
            };

            CbxCantidadDeCuotas.Items.Add(Doce);
            CbxCantidadDeCuotas.Items.Add(Dieciocho);
            CbxCantidadDeCuotas.Items.Add(Veinticuatro);
            CbxCantidadDeCuotas.Items.Add(Treinta);
            CbxCantidadDeCuotas.Items.Add(TreintaySeis);
            CbxCantidadDeCuotas.Items.Add(CuaretaYDos);
            CbxCantidadDeCuotas.Items.Add(CuarentaYOcho);
            CbxCantidadDeCuotas.Items.Add(CincuentaYCuatro);
            CbxCantidadDeCuotas.Items.Add(Sesenta);
            CbxCantidadDeCuotas.Items.Add(SesentaYSeis);
            CbxCantidadDeCuotas.Items.Add(SetentaYDos);
            CbxCantidadDeCuotas.Items.Add(SetentaYOcho);
            CbxCantidadDeCuotas.Items.Add(OchentaYCuatro);
            CbxCantidadDeCuotas.Items.Add(Noventa);
            CbxCantidadDeCuotas.Items.Add(NoventaYSeis);
            CbxCantidadDeCuotas.Items.Add(CientoDos);
            CbxCantidadDeCuotas.Items.Add(CientoOcho);
            CbxCantidadDeCuotas.Items.Add(CientoCatorce);
            CbxCantidadDeCuotas.Items.Add(CientoVeinte);

            CbxCantidadDeCuotas.SelectedItem = Doce;
        }
/*Fin de Metodo Cuotas Mensuales*/


    private void LblMontoDelPrestamo_Click(object sender, EventArgs e)
        {

        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void CbxTipoDePrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            ComboBoxItem1 TipoDePrestamoSeleccionado = CbxTipoDePrestamo.SelectedItem as ComboBoxItem1;
            ComboBoxItem1 CantidadDeMesesSeleccionado = CbxCantidadDeCuotas.SelectedItem as ComboBoxItem1;
            

            if (TipoDePrestamoSeleccionado.Value == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de prestamo", "Ojo");
            }
            else if (CantidadDeMesesSeleccionado.Value == null)
            {
                MessageBox.Show("Debe seleccionar una cantidad de Meses", "Ojo");
            }
            else if (CbNumMontoDePrestamo.Value==0)
            {
                MessageBox.Show("Asegurese de introducir un Monto", "Ojo");
            }
            else
            {
                CalculadoraPrestamos calculadoraPrestamos = new CalculadoraPrestamos();
                

                int TipoDePrestamo = (int)TipoDePrestamoSeleccionado.Value;
                int CantidadDeCuotas = (int)CantidadDeMesesSeleccionado.Value;
                int MontoDePrestamo = (int)CbNumMontoDePrestamo.Value;
                int TasaDeInteres;

                if ((int)TipoDePrestamoSeleccionado.Value == 1)
                {
                    TasaDeInteres = 22;
                    string TasaPrint = "22%";
                    TxtTasaDeInteres.Text = TasaPrint;

                    double resultado = calculadoraPrestamos.Calcular(TipoDePrestamo, TasaDeInteres, CantidadDeCuotas, MontoDePrestamo);

                    TxtCuotaMensual.Text = Math.Round(resultado).ToString();
                }
                else if((int)TipoDePrestamoSeleccionado.Value == 2)
                {
                    TasaDeInteres = 12;
                    string TasaPrint = "12%";
                    TxtTasaDeInteres.Text = TasaPrint;

                    double resultado = calculadoraPrestamos.Calcular(TipoDePrestamo, TasaDeInteres, CantidadDeCuotas, MontoDePrestamo);

                    TxtCuotaMensual.Text = resultado.ToString();
                }
                else
                {
                    TasaDeInteres = 8;
                    string TasaPrint = "8%";
                    TxtTasaDeInteres.Text = TasaPrint;

                    double resultado = calculadoraPrestamos.Calcular(TipoDePrestamo, TasaDeInteres, CantidadDeCuotas, MontoDePrestamo);

                    TxtCuotaMensual.Text = resultado.ToString();
                }

            }
        }

        private void TxtTasaDeInteres_TextChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
