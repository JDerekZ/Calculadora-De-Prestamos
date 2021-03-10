using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraDePrestamos.LogicLayers;

namespace CalculadoraDePrestamos.LogicLayers
{
    public class CalculadoraPrestamos
    {
        public double Calcular(int TipoDePrestamo, double TasaDeInteres, int CantidadDeMeses, double MontoDePrestamo)
        {
            double MontoProcesado = 0;
            double Total;
            double Opc;

            switch (TipoDePrestamo)
            {
                case (int)EnumTipoDePrestamo.Personal:
                    switch (CantidadDeMeses)
                    {
                        case (int)EnumMes.Doce:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100)+MontoDePrestamo;
                            MontoProcesado = Opc / 12;
                            break;

                        case (int)EnumMes.DieciOCho:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 18;
                            break;

                        case (int)EnumMes.VeintiCuatro:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 24;
                            break;

                        case (int)EnumMes.Treinta:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 30;
                            break;

                        case (int)EnumMes.TreintaYSeis:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 36;
                            break;

                        case (int)EnumMes.CuarentaYDos:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 42;
                            break;

                        case (int)EnumMes.CuarentaYOcho:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 48;
                            break;

                        case (int)EnumMes.CincuentaYCuatro:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 54;
                            break;

                        case (int)EnumMes.Sesenta:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 60;
                            break;

                        case (int)EnumMes.SesentaYSeis:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 60;
                            break;

                        case (int)EnumMes.SetentaYDos:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 72;
                            break;

                        case (int)EnumMes.SetentaYOcho:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 78;
                            break;

                        case (int)EnumMes.OchentaYCuatro:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 84;
                            break;

                        case (int)EnumMes.Noventa:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 90;
                            break;

                        case (int)EnumMes.NoventaYSeis:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 96;
                            break;

                        case (int)EnumMes.CientoDos:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 102;
                            break;

                        case (int)EnumMes.CientoOCho:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 105;
                            break;

                        case (int)EnumMes.CientoCatorce:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 114;
                            break;

                        case (int)EnumMes.CientoVeinte:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 120;
                            break;

                    }
                    break;

                case (int)EnumTipoDePrestamo.Automovil:

                    switch (CantidadDeMeses) 
                    {
                        case (int)EnumMes.Doce:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 12;
                            break;

                        case (int)EnumMes.DieciOCho:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 18;
                            break;

                        case (int)EnumMes.VeintiCuatro:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 24;
                            break;

                        case (int)EnumMes.Treinta:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 30;
                            break;

                        case (int)EnumMes.TreintaYSeis:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 36;
                            break;

                        case (int)EnumMes.CuarentaYDos:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 42;
                            break;

                        case (int)EnumMes.CuarentaYOcho:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 48;
                            break;

                        case (int)EnumMes.CincuentaYCuatro:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 54;
                            break;

                        case (int)EnumMes.Sesenta:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 60;
                            break;

                        case (int)EnumMes.SesentaYSeis:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 60;
                            break;

                        case (int)EnumMes.SetentaYDos:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 72;
                            break;

                        case (int)EnumMes.SetentaYOcho:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 78;
                            break;

                        case (int)EnumMes.OchentaYCuatro:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 84;
                            break;

                        case (int)EnumMes.Noventa:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 90;
                            break;

                        case (int)EnumMes.NoventaYSeis:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 96;
                            break;

                        case (int)EnumMes.CientoDos:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 102;
                            break;

                        case (int)EnumMes.CientoOCho:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 105;
                            break;

                        case (int)EnumMes.CientoCatorce:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 114;
                            break;

                        case (int)EnumMes.CientoVeinte:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 120;
                            break;
                    }
                    break;


                case (int)EnumTipoDePrestamo.Hipotecario:
                    switch (CantidadDeMeses)
                    {
                        case (int)EnumMes.Doce:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 12;
                            break;

                        case (int)EnumMes.DieciOCho:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 18;
                            break;

                        case (int)EnumMes.VeintiCuatro:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 24;
                            break;

                        case (int)EnumMes.Treinta:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 30;
                            break;

                        case (int)EnumMes.TreintaYSeis:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 36;
                            break;

                        case (int)EnumMes.CuarentaYDos:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 42;
                            break;

                        case (int)EnumMes.CuarentaYOcho:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 48;
                            break;

                        case (int)EnumMes.CincuentaYCuatro:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 54;
                            break;

                        case (int)EnumMes.Sesenta:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 60;
                            break;

                        case (int)EnumMes.SesentaYSeis:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 60;
                            break;

                        case (int)EnumMes.SetentaYDos:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 72;
                            break;

                        case (int)EnumMes.SetentaYOcho:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 78;
                            break;

                        case (int)EnumMes.OchentaYCuatro:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 84;
                            break;

                        case (int)EnumMes.Noventa:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 90;
                            break;

                        case (int)EnumMes.NoventaYSeis:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 96;
                            break;

                        case (int)EnumMes.CientoDos:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 102;
                            break;

                        case (int)EnumMes.CientoOCho:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 105;
                            break;

                        case (int)EnumMes.CientoCatorce:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 114;
                            break;

                        case (int)EnumMes.CientoVeinte:
                            Opc = ((MontoDePrestamo * TasaDeInteres) / 100) + MontoDePrestamo;
                            MontoProcesado = Opc / 120;
                            break;
                    }
                    break;

                default:
                    MontoProcesado = MontoDePrestamo;
                    break;
            }

            return MontoProcesado;
        }
    }
}
