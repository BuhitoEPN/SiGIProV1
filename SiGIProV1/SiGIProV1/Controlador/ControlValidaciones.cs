﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SiGIProV1.Controlador
{
    class ControlValidaciones
    {

        public Boolean validarCamposNumericosCadena(string ruc)
        {
            char[] cadena = ruc.ToCharArray(0, ruc.Length);

            for (int i = 0; i < ruc.Length; i++)
            {
                if (!(cadena[i] == 13 || (cadena[i] > 47 && cadena[i] < 58) || cadena[i] == 127 || cadena[i] == 8 || cadena[i] > 16 && cadena[i] < 21))
                {
                    return true;
                }
            }

            return false;
        }
        public void validarCamposNumericosKeyUp(KeyEventArgs evt, TextBox ruc)
        {
            char cadena = (char)evt.KeyValue;
            if (!(cadena == 13 || (cadena > 47 && cadena < 58) || cadena == 127 || cadena == 8 || cadena > 16 && cadena < 21))
            {
                MessageBox.Show("Solo se permiten números.");
                ruc.Text = "";
            }
        }

        public void validarCamposNumericos(KeyPressEventArgs evt)
        {
            char cadena = evt.KeyChar;
            if (!(cadena == 13 || (cadena > 47 && cadena < 58) || cadena == 127 || cadena == 8 || cadena > 16 && cadena < 21))
            {
                evt.Handled = true;
                MessageBox.Show("Solo se permiten números.");
            }
        }


        public void validarCamposTexto(KeyPressEventArgs evt)
        {
            char c = evt.KeyChar;
            if (!(c == 13 || (c > 64 && c < 91) || (c > 96 && c < 123) || (c > 159 && c < 166) || c == 130 || c == 127 || c >= 0 && c < 33 || c == 193 || c == 201 || c == 205 || c == 211 || c == 218 || c == 'Ñ' || c == 'ñ' || (c > 224 && c < 251)))
            {
                evt.Handled = true;
                MessageBox.Show("Nombre del proveedor ingresado incorrectamente.");
            }
        }

        public Boolean validarCorreo(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public Boolean verificarCedula(String identificacion)
        {
            bool estado = false;
            char[] valced = new char[13];
            int provincia;
            if (identificacion.Length >= 10)
            {
                valced = identificacion.Trim().ToCharArray();
                provincia = int.Parse((valced[0].ToString() + valced[1].ToString()));
                if (provincia > 0 && provincia < 25)
                {
                    if (int.Parse(valced[2].ToString()) < 6)
                    {
                        estado = VerificaCedula(valced);
                    }
                    else if (int.Parse(valced[2].ToString()) == 6)
                    {
                        estado = VerificaSectorPublico(valced);
                    }
                    else if (int.Parse(valced[2].ToString()) == 9)
                    {
                        estado = VerificaPersonaJuridica(valced);
                    }
                }
            }
            return estado;

        }

        private bool VerificaCedula(char[] validarCedula)
        {
            int aux = 0, par = 0, impar = 0, verifi;
            for (int i = 0; i < 9; i += 2)
            {
                aux = 2 * int.Parse(validarCedula[i].ToString());
                if (aux > 9)
                    aux -= 9;
                par += aux;
            }
            for (int i = 1; i < 9; i += 2)
            {
                impar += int.Parse(validarCedula[i].ToString());
            }

            aux = par + impar;
            if (aux % 10 != 0)
            {
                verifi = 10 - (aux % 10);
            }
            else
                verifi = 0;
            if (verifi == int.Parse(validarCedula[9].ToString()))
                return true;
            else
                return false;
        }

        private bool VerificaPersonaJuridica(char[] validarCedula)
        {
            int aux = 0, prod, veri;
            veri = int.Parse(validarCedula[10].ToString()) + int.Parse(validarCedula[11].ToString()) + int.Parse(validarCedula[12].ToString());
            if (veri > 0)
            {
                int[] coeficiente = new int[9] { 4, 3, 2, 7, 6, 5, 4, 3, 2 };
                for (int i = 0; i < 9; i++)
                {
                    prod = int.Parse(validarCedula[i].ToString()) * coeficiente[i];
                    aux += prod;
                }
                if (aux % 11 == 0)
                {
                    veri = 0;
                }
                else if (aux % 11 == 1)
                {
                    return false;
                }
                else
                {
                    aux = aux % 11;
                    veri = 11 - aux;
                }

                if (veri == int.Parse(validarCedula[9].ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool VerificaSectorPublico(char[] validarCedula)
        {
            int aux = 0, prod, veri;
            veri = int.Parse(validarCedula[9].ToString()) + int.Parse(validarCedula[10].ToString()) + int.Parse(validarCedula[11].ToString()) + int.Parse(validarCedula[12].ToString());
            if (veri > 0)
            {
                int[] coeficiente = new int[8] { 3, 2, 7, 6, 5, 4, 3, 2 };

                for (int i = 0; i < 8; i++)
                {
                    prod = int.Parse(validarCedula[i].ToString()) * coeficiente[i];
                    aux += prod;
                }

                if (aux % 11 == 0)
                {
                    veri = 0;
                }
                else if (aux % 11 == 1)
                {
                    return false;
                }
                else
                {
                    aux = aux % 11;
                    veri = 11 - aux;
                }

                if (veri == int.Parse(validarCedula[8].ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }



    }
}
