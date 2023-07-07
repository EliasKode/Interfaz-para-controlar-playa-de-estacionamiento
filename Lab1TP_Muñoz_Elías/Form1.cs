using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1TP_Muñoz_Elías
{
    public partial class Form1 : Form
    {
               //DECLARACION DE VARIABLES Y ARREGLOS DE CARÁCTER GLOBAL DURANTE EL USO DEL PROGRAMA
        public char[] Dom6;  //PARA EVALUAR PATENTE DE 6 VALORES
        public char[] Dom7;  // PARA EVALUAR PATENTE DE 7 VALORES
        float autoTaxmin = 2.5f; // TARIFAS PARA EL TIPO DE VEHICULO
        float UtilTaxmin = 3.0f;
        const int spaces = 50;    //LOS ESPACIOS PARA LA CREACIÓN DEL ARREGLO
        public int CantidadOcup = 0;     //CONTADOR DE LOS LUGARES OCUPADOS
        public int situ;              //VARIABLE UTILIZADA EN EVENTO Y PROCEDIMIENTOS RELACIONADOS A ESE EVENTO

               //DECLARACION DE LA ESTRUCTURA INGRESOS
        public struct INGRESOS
        {
            public string Dom;
            public string Tipo;
            public int Lugar;
            public DateTime HoraIn;
        };
              //DECLARACION DEL ARREGLO COMPUESTO POR ESTRUCTURAS DEL TIPO INGRESO
        public INGRESOS[] Ingresos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dom6= new char[5];
            Dom7= new char[6];
            Ingresos = new INGRESOS[spaces];
            for (int i = 1; i < 51; i++)
            {
                cboLugaresCoch.Items.Add(i);
            }
            for(int z =0; z < spaces; z++)
            {
                Ingresos[z].Dom = "";
                Ingresos[z].Tipo = "";
                Ingresos[z].Lugar = 0;
                Ingresos[z].HoraIn = DateTime.MinValue;
            }
            CantidadOcup = 0;
            cboTipoVehiculo.SelectedIndex = 0;
            btnIngresar.Enabled = false;
            btnBuscar.Enabled = false;
            btnEgresar.Enabled = false;
            txtMomentoIngreso.Text = "";
            txtDominio.Focus();
            limpiarEgresoLabel();
            grillDatosIng.Rows.Clear();
           
        }
        private void limpiarTodo()
        {
            for (int z = 0; z < spaces; z++)
            {
                Ingresos[z].Dom = "";
                Ingresos[z].Tipo = "";
                Ingresos[z].Lugar = 0;
                Ingresos[z].HoraIn = DateTime.MinValue;
            }
            actualizarCocheras();
            int f = 0;
            for (f = 0; f < grillDatosIng.RowCount; f++)
            {
                
                    grillDatosIng.Rows.RemoveAt(f);
               
            }
        }
           //PROCEDIMIENTO PARA HABILITAR EL BOTON INGRESAR
        private void habilitacionIngreso()
        {
            validarDominioIngreso();
            if (validarDominioIngreso() == true && cboLugaresCoch.SelectedIndex != -1)
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
                txtMomentoIngreso.Text = "";
            }
        }

            //PROCEDIMIENTO QUE SE ACTIVA AL EJECUTAR EL BOTON INGRESAR
        private void limpiarIngreso()
        {
            txtDominio.Text = "";
            cboTipoVehiculo.SelectedIndex = 0;
            btnIngresar.Enabled = false;
           cboLugaresCoch.SelectedIndex = -1;
            txtMomentoIngreso.Text = "";
        }

          //PROCEDIMIENTO QUE SE EJECUTA AL HACER UN INGRESO O UN EGRESO, MOSTRANDO LAS COCHERAS LIBRES
        private void actualizarCocheras()
        {
            cboLugaresCoch.Items.Clear();
            int i;
            int j;
            for (i = 1; i <= 50; i++)
            {
                for (j = 0; j < 50; j++)
                {
                    if (i == Ingresos[j].Lugar)
                    {
                        break;
                    }
                }
                if (j == 50)
                {
                    cboLugaresCoch.Items.Add(i);
                }
            }
        }

            //ESTE EVENTO CONTROLA INGRESOS VALIDOS POR TECLADO EN LA CAJA DE TEXTO DEL GRUPO INGRESO
        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }

            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

          //PROCEDIMIENTO QUE VALIDARÁ LOS FORMATOS DE PATENTE EN EL GRUPO INGRESO
        private bool validarDominioIngreso()
        {
            int control = 0;
            bool patente = false;

            //CONTROL DE DOMINIO DE 6 CARACTERES
            if (txtDominio.Text.Length == 6)
            {
                Dom6 = txtDominio.Text.ToCharArray();
                int i = 0;
                for (i = 0; i < 3; i++)
                {
                   if (Char.IsLetter(Dom6[i]))
                   {
                      control++;
                   }
                }  
                for (i = 3; i < 6; i++)
                {
                   if (Char.IsDigit(Dom6[i]))
                   {
                      control++;
                   }        
                }   
                if (control == 6)
                {
                    patente = true;
                }
            }

            //CONTROL DE DOMINIO DE 7 CARACTERES

            if (txtDominio.Text.Length == 7)
            {
                Dom7 = txtDominio.Text.ToCharArray();
                int i = 0;
                for (i = 0; i < 2; i++)
                {
                    if (Char.IsLetter(Dom7[i]))
                    {
                        control++;
                    }
                }
                for (i = 2; i < 5; i++)
                {
                    if (Char.IsDigit(Dom7[i]))
                    {
                        control++;
                    }
                }
                for (i = 5; i < 7; i++)
                {
                    if (Char.IsLetter(Dom7[i]))
                    {
                        control++;
                    }
                }
                if (control == 7)
                {
                    patente = true;
                }
            }
            return patente;
        }

            //POR MEDIO DE UN PROCEDIMIENTO, HABILITA EL BOTON INGRESAR
        private void txtDominio_TextChanged(object sender, EventArgs e)
        {
          habilitacionIngreso();
        }

           //EVENTO QUE CARGARÁ LOS DATOS AL ARREGO DE ESTRUCTURAS
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int i;
            for(i=0; i<50; i++)
            {
                if (Ingresos[i].Dom == "")
                {
                    Ingresos[i].Dom = txtDominio.Text;
                    Ingresos[i].Tipo = cboTipoVehiculo.Text;
                    Ingresos[i].Lugar = int.Parse(cboLugaresCoch.SelectedItem.ToString());
                    Ingresos[i].HoraIn = DateTime.Now;
                    grillDatosIng.Rows.Add(txtDominio.Text, cboTipoVehiculo.Text, cboLugaresCoch.SelectedItem.ToString(), DateTime.Now.ToString());
                    actualizarCocheras();
                    limpiarIngreso();
                    txtDominio.Focus();
                    CantidadOcup++;
                    break;
                }
            }
            

            if (CantidadOcup >= 50)
            {
                btnIngresar.Enabled = false;
                MessageBox.Show("Los lugares de estacionamiento están completos. Debe esperar un egreso para tener disponibilidad",
                               "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

                          // CONTROL DE LA ENTRADA DE DOMINIO EN EL GRUPO EGRESO
        private bool validarDominioEgreso() 
        {
                          //CONTROL DE DOMINIO DE 6 CARACTERES
            int control = 0;
            bool patente = false;
            if (txtDominioSearch.Text.Length == 6)
            {
                Dom6 = txtDominioSearch.Text.ToCharArray();
                int i = 0;
                for (i = 0; i < 3; i++)
                {
                    if (Char.IsLetter(Dom6[i]))
                    {
                        control++;
                    }
                }
                for (i = 3; i < 6; i++)
                {
                    if (Char.IsDigit(Dom6[i]))
                    {
                        control++;
                    }
                }
                if (control == 6)
                {
                    patente = true;
                }
            }

            //CONTROL DE DOMINIO DE 7 CARACTERES

            if (txtDominioSearch.Text.Length == 7)
            {
                Dom7 = txtDominioSearch.Text.ToCharArray();
                int i = 0;
                for (i = 0; i < 2; i++)
                {
                    if (Char.IsLetter(Dom7[i]))
                    {
                        control++;
                    }
                }
                for (i = 2; i < 5; i++)
                {
                    if (Char.IsDigit(Dom7[i]))
                    {
                        control++;
                    }
                }
                for (i = 5; i < 7; i++)
                {
                    if (Char.IsLetter(Dom7[i]))
                    {
                        control++;
                    }
                }
                if (control == 7)
                {
                    patente = true;
                }
            }
            return patente;
        }


        //VALIDACIÓN DE LOS INGRESOS POR TECLADO EN LA CAJA DE DOMINIO DEL GRUPO EGRESO,
        // ADEMAS DE MANEJAR LA HABILITACION DEL BOTON BUSCAR, SI LA CAJA DE TEXTO NO POSEE UN FORMATO VÁLIDO
        // LIMPIARÁ LAS CAJAS DE LABEL, PARA EVITAR CONFUCIONES CON DATOS ARROJADOS POR ALGUNA BUSQUEDA ANTERIOR 
        //PERO QUE SIN EMBARGO NO SE HAYA HECHO EL EGRESO
        private void txtDominioSearch_TextChanged(object sender, EventArgs e)
        {
            validarDominioEgreso();
            if (validarDominioEgreso() == true)
            {
                btnBuscar.Enabled = true;
              
            }
            else
            {
                btnBuscar.Enabled = false;
                limpiarEgresoLabel();
            }
        }

         //ARROJA LOS DATOS DE UN LUGAR CARGADO EN EL ARREGLO PARA MOSTRARLOS EN LOS LABEL DEL GRUPO EGRESO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            situ=0;
            for (situ = 0; situ < spaces; situ++)
            {
                if (Ingresos[situ].Dom.ToString() == txtDominioSearch.Text)
                {
                    lblTipoVehiculo.Text = Ingresos[situ].Tipo.ToString();
                    lblUbicacion.Text = Ingresos[situ].Lugar.ToString();
                    lblIngreso.Text = Ingresos[situ].HoraIn.ToString();
                    lblEgreso.Text = DateTime.Now.ToString();
                    calcularPeriodo();
                    break;
                }
            }
                if (situ >= spaces)
                {
                    MessageBox.Show("El dominio solicitado no se encuentra en la base de datos.",
                                                   "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiarEgresoLabel();
                    txtDominioSearch.Focus();
                }

            
        }

        //ESTE EVENTO CONTROLA INGRESOS VALIDOS POR TECLADO EN LA CAJA DE TEXTO DEL GRUPO EGRESO
        private void txtDominioSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }

            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

          //PERMITE VER LA HORA Y FECHA EN TIEMPO REAL JUSTO ANTES DEL INGRESO
        private void horaIngreso_Tick(object sender, EventArgs e)
        {
            if(btnIngresar.Enabled== true)
            txtMomentoIngreso.Text=DateTime.Now.ToLongTimeString();
        }

          //POR MEDIO DE UN PROCEDIMIENTO, HABILITA EL BOTON INGRESAR
        private void cboLugaresCoch_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitacionIngreso(); 
        }

            //PROCEDIMIENTO QUE CALCULA EL TIEMPO DE ESTADIA EN COCHERA Y ARROJA EL IMPORTE
            //INDIRECTAMENTE ESTABLECE LOS ESTADOS DEL BOTON EGRESAR POR LA PRESENCIA DE TEXTO EN EL IMPORTE
            //Y LA HABILITACION PREVIA DEL BOTON BUSCAR, SEGUN EL REQUERIMIENTO ESPECIFICADO
        private void calcularPeriodo()
        {
            TimeSpan periodo;
            periodo = DateTime.Now - Ingresos[situ].HoraIn;
            double minutos = periodo.TotalMinutes;
            float estadia = (float)minutos;
            if (Ingresos[situ].Tipo.ToString() == "Automóvil")
            {
                lblimporte.Text = (estadia * autoTaxmin).ToString("0.##");
                minutos = 0;
            }
            if (Ingresos[situ].Tipo.ToString() == "Utilitario")
            {
                lblimporte.Text = (estadia * UtilTaxmin).ToString("0.##");
                minutos = 0;
            }  
        }

          //PROCEDIMIENTO PARA LIMPIAR LOS LABEL DEL GRUPO EGRESO UTILIZADO EN EL BOTON BUSCAR, EVENTO TEXTCHANGED DE LA CAJA
          //DEL GRUPO EGRESO Y EN EL EVENTO QUE SE EJECUTA AL DAR CLICK EN EL BOTON EGRESAR
        private void limpiarEgresoLabel()
        {
            
            lblTipoVehiculo.Text = "";
            lblUbicacion.Text = "";
            lblIngreso.Text = "";
            lblEgreso.Text = "";
            lblimporte.Text = "";
            situ = 0;
        }

        //ESTE PROCEDIMIENTO SE UTILIZA PARA CONTROLAR LAS ACCIONES DEL BOTON EGRESAR
        private void egresarLimpiar()
        {
            actualizargrilla();

            for (int z = 0; z < spaces; z++)
            {
               if(Ingresos[z].Dom.ToString() == txtDominioSearch.Text)
                {
                    Ingresos[z].Dom = "";
                    Ingresos[z].Tipo = "";
                    Ingresos[z].Lugar = 0;
                    Ingresos[z].HoraIn = DateTime.MinValue;
                }
            }
           
            actualizarCocheras();
            limpiarEgresoLabel();
                limpiarIngreso();
                btnEgresar.Enabled = false;
                txtDominioSearch.Text = "";
                CantidadOcup--;
            
        }

         //EVENTO DEL BOTON EGRESAR
        private void btnEgresar_Click(object sender, EventArgs e)
        {
            egresarLimpiar();
           
        }
          //ESTE EVENTO SE EJECUTA SI Y SÓLO SI EL BOTON BUSCAR ES PRESIONADO, PARA LO CUAL DEBE ESTAR HABILITADO, ÉSTO
          //Y A SU VEZ, HABER UN IMPORTE A COBRAR, SE HABILITA EL BOTÓN EGRESAR
        private void lblimporte_TextChanged(object sender, EventArgs e)
        {
            if(lblimporte.Text != "")
            {
                btnEgresar.Enabled = true;
            }
            else
            {
                btnEgresar.Enabled=false;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizargrilla()
        {
            int f = 0;
            for(f =0; f < grillDatosIng.RowCount; f++)
            {
                if (grillDatosIng.Rows[f].Cells[0].Value.ToString() == txtDominioSearch.Text)
                {
                    grillDatosIng.Rows.RemoveAt(f);
                }
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }
    }
}