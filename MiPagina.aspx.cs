using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Negocio;

namespace Numero
{
    public partial class MiPagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ///------------------------PARA OBTENER EL VALOR DE LAS LETRAS DEL NOMBRE / APELLIDO ---------------------------------------
            Console.WriteLine("Ingresa hasta 3 nombres separados por un espacio:");
            string input = tbNombre.Text.ToLower().Trim();

            // Dividir la cadena en nombres individuales
            string[] nombres = input.Split(' ');

            // Variables para contar la frecuencia de cada letra de la "a" a la "z"
            int[] frecuenciaLetras = new int[26];

            // Variables para calcular el número de vibración del reto
            int primerVocal = -1;
            int ultimaVocal = -1;

            // Variable para calcular el número de vibración de la capsula
            int PrimerasLetras = 0;

            for (int aux = 0; aux < frecuenciaLetras.Length; aux++)
            {
                frecuenciaLetras[aux] = 0;
            }

            // Verificar si se ingresaron hasta 3 nombres
            if (nombres.Length <= 3)
            {
                // Iterar sobre cada nombre
                foreach (string nombre in nombres)
                {
                    /// MessageBox.Show($"Letras del nombre {nombre}:", "Mensaje");
                    char primerletra = nombre[0];
                    int indiceLetra1 = (int)primerletra - 97;
                    PrimerasLetras += indiceLetra1 + 1; // es +1 porque quiero el valor real 

                    foreach (var letra in nombre)
                    {
                        int indicereal = (int)letra - 97;
                        frecuenciaLetras[indicereal]++;
                        MessageBox.Show("La letra es :" + letra);

                        if (indicereal == 0 || indicereal == 4 || indicereal == 8 || indicereal == 14 || indicereal == 20)
                        {
                            if (primerVocal == -1)
                            {
                                primerVocal = indicereal + 1;
                            }
                            ///ultimaVocal = indicereal + 1;
                        }
                    }
                    ///  MessageBox.Show($"Total de letras en {nombre}: {nombre.Length}", "Mensaje");
                }

                ///-------------------------------HERENCIA --------------------------------
                ///SUMAMOS LOS 2 APELLIDOS Y LOS REDUCIMOS, VYDRA + MAIDANA
                string input2 = tbApellidos.Text.ToLower().Trim();
                string[] Apellidos = input2.Split(' ');
                int[] frecuenciaLetras2 = new int[26];

                if (Apellidos.Length <= 2)
                {
                    // Iterar sobre cada nombre
                    foreach (string apellido in Apellidos)
                    {
                        /// MessageBox.Show($"Letras del nombre {nombre}:", "Mensaje");
                        char primerletra = apellido[0];
                        int indiceLetra1 = (int)primerletra - 97;
                        PrimerasLetras += indiceLetra1 + 1; // es +1 porque quiero el valor real 

                        foreach (var letra in apellido)
                        {
                            int indicereal = (int)letra - 97;
                            frecuenciaLetras[indicereal]++;
                            MessageBox.Show("La letra es :" + letra);

                            if (indicereal == 0 || indicereal == 4 || indicereal == 8 || indicereal == 14 || indicereal == 20)
                            {
                                ultimaVocal = indicereal + 1;
                            }
                        }
                    }

                    for (int aux = 0; aux < frecuenciaLetras.Length; aux++)
                    {
                        frecuenciaLetras[aux] += frecuenciaLetras2[aux];
                        if (frecuenciaLetras[aux] != 0)
                        {
                            lblResultado.Text += "La letra: " + (char)(aux + 97) + " Se repite:" + frecuenciaLetras[aux] + " Veces <br/> ";
                        }
                    }

                    lblResultado.Text += $"El Número de la primer vocal es: {primerVocal} <br/>";
                    lblResultado.Text += $"El Número de la ultima vocal es: {ultimaVocal} <br/>";

                    // Calcular el número de vibración del reto
                    int numeroVibracionReto = Math.Abs(primerVocal - ultimaVocal);
                    lblResultado.Text += $"Número de vibración del reto: {numeroVibracionReto} <br/>";

                    // Calcular el número de cápsula
                    lblResultado.Text += $"Número de cápsula: {ReducirADigito(PrimerasLetras)} <br/>";
                }
                else
                {
                    MessageBox.Show("Has ingresado mas de 2 apellidos  Por favor, intenta nuevamente.", "Mensaje");
                }
            }
            else
            {
                MessageBox.Show("Has ingresado mas de 3 nombres Por favor, intenta nuevamente.", "Mensaje");
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            ///----------------------- PARA OBTENER LOS DATOS A TRAVES DE LA FECHA DE NACIMIENTO ---------------------------------
            // Obtener la fecha ingresada
            string fechaIngresada = txtFecha.Text;

            // Dividir la fecha en día, mes y año
            string[] partesFecha = fechaIngresada.Split('/');

            if (partesFecha.Length == 3)
            {
                // Convertir a números enteros
                int dia = Convert.ToInt32(partesFecha[0]);
                int mes = Convert.ToInt32(partesFecha[1]);
                int anio = Convert.ToInt32(partesFecha[2]);

                // Por ejemplo, mostrarlos en la consola para verificar
                ///MessageBox.Show($"Día: {dia}, Mes: {mes}, Año: {anio}","Mensaje");
                int añopersonal = dia + mes + anio;

                /// --------------------NUMERO DE ALMA----------------------------
                int sumaDigitos = SumarDigitos(dia) + SumarDigitos(mes) + SumarDigitos(anio);

                ///ACA ES DONDE SALE EL NUMERO MAESTRO
                MessageBox.Show($"Suma de digitos - POSIBLE NUMERO MAESTRO:" + sumaDigitos, "Mensaje");

                // Reducir la suma a un solo dígito - NUMERO DE ALMA
                int resultadoFinal = ReducirADigito(sumaDigitos);

                // Mostrar el resultado en la consola para verificar
                MessageBox.Show($"Resultado Final: " + resultadoFinal, "Mensaje");

                ///------------------AÑO, MES Y DIA PERSONAL ---------------------------------
                ///// Calcular la suma de día, mes y año sin reducir (Año Personal)
                int anoPersonal = dia + mes + anio;

                // Calcular el Mes Personal
                int mesPersonal = anoPersonal + mes;

                // Calcular el Día Personal
                int diaPersonal = anoPersonal + mesPersonal + dia;

                ///--------------- DESAFIOS DE LA VIDA ----------------------
                ///1ER Desafio 0-28 anios - 2DO Desafio 29-34 anios - 3ER Desafio 35-49 anios - 4TO Desafio 50-final xd
                ///// Calcular el 1er Desafío

                int primerDesafio = Math.Abs(ReducirADigito(mes) - ReducirADigito(dia));
                MessageBox.Show("Primer Desafio:" + primerDesafio, "Mensaje");
                // Calcular el 2do Desafío
                int segundoDesafio = Math.Abs(ReducirADigito(dia) - ReducirADigito(ReducirADigito(anio)));
                MessageBox.Show("Segundo Desafio:" + segundoDesafio, "Mensaje");
                // Calcular el 3er Desafío
                int tercerDesafio = Math.Abs(primerDesafio - segundoDesafio);
                MessageBox.Show("Tercer Desafio:" + tercerDesafio, "Mensaje");
                // Calcular el 4to Desafío
                int cuartoDesafio = Math.Abs(ReducirADigito(mes) - ReducirADigito(ReducirADigito(anio)));
                MessageBox.Show("Cuarto Desafio:" + cuartoDesafio, "Mensaje");

                // Calcular el 1er Pináculo
                int primerPinaculo = ReducirADigito(mes + dia);

                // Calcular el Rango de Edad para el 1er Pináculo
                int rangoEdadPrimerPinaculo = 36 - resultadoFinal;

                // Calcular el 2do Pináculo
                int segundoPinaculo = ReducirADigito(dia + ReducirADigito(anio));

                // Calcular el Rango de Edad para el 2do Pináculo
                int rangoEdadSegundoPinaculo = rangoEdadPrimerPinaculo + 9;

                // Calcular el 3er Pináculo
                int tercerPinaculo = ReducirADigito(primerPinaculo + segundoPinaculo);

                // Calcular el Rango de Edad para el 3er Pináculo
                int rangoEdadTercerPinaculo = rangoEdadSegundoPinaculo + 9;

                // Calcular el 4to Pináculo
                int cuartoPinaculo = ReducirADigito(mes + ReducirADigito(anio));

                // Calcular el Rango de Edad para el 4to Pináculo
                int rangoEdadCuartoPinaculo = rangoEdadTercerPinaculo + 9;

                // Mostrar los resultados en la consola para verificar
                MessageBox.Show($"1er Pináculo: {primerPinaculo}" + $" / Rango de Edad para 1er Pináculo: {rangoEdadPrimerPinaculo}", "Mensaje");
                MessageBox.Show($"2do Pináculo: {segundoPinaculo}" + $" / Rango de Edad para 2do Pináculo: {rangoEdadSegundoPinaculo}", "Mensaje");
                MessageBox.Show($"3er Pináculo: {tercerPinaculo}" + $" / Rango de Edad para 3er Pináculo: {rangoEdadTercerPinaculo}", "Mensaje");
                MessageBox.Show($"4to Pináculo: {cuartoPinaculo}" + $" / Rango de Edad para 4to Pináculo: {rangoEdadCuartoPinaculo}", "Mensaje");

                // Puedes usar estos valores en otras operaciones según tus necesidades
                /// TABLA DE PERIODOS ANUALES
                /// ENERO 31
                /// FEBRERO 28 - 29(BISIESTO)
                /// MARZO 31
                /// ABRIL 30
                /// MAYO 31
                /// JUNIO 30 
                /// JULIO 31
                /// AGOSTO 31
                /// SEPTIEMBRE 30
                /// OCTUBRE 31
                /// NOVIEMBRE 30
                /// DICIEMBRE 31
                ///  Y ES PERIODO DE 52 DIAS DESDE EL DIA QUE NACEMOS ES EL 0 SUMANDO DE A 52 DIAS PARA SEPARAR LOS PERIODOS
                ///  

                string fechaNacimientoStr = txtFecha.Text;

                if (DateTime.TryParseExact(fechaNacimientoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
                {
                    // Variables para almacenar los periodos
                    DateTime[] fechasInicio = new DateTime[7];
                    DateTime[] fechasFin = new DateTime[7];
                    // Define la duración de un periodo en días
                    int duracionPeriodo = 52;

                    // Calcula los periodos
                    for (int i = 0; i < 7; i++)
                    {
                        // Calcula la fecha de inicio del periodo
                        fechasInicio[i] = fechaNacimiento.AddDays(i * duracionPeriodo);
                        // Calcula la fecha de fin del periodo (sumando 52 días y ajustando por años bisiestos)
                        fechasFin[i] = fechasInicio[i].AddDays(duracionPeriodo);

                        if (EsBisiesto(fechasFin[i].Year) && fechasInicio[i].Month == 2 && fechasInicio[i].Day == 29)
                        {
                            fechasFin[i] = fechasFin[i].AddDays(1);
                        }
                        // Muestra los resultados
                        MessageBox.Show($"Periodo {i + 1}: Desde {fechasInicio[i].ToString("dd/MM/yyyy")} hasta {fechasFin[i].ToString("dd/MM/yyyy")}", "Mensaje");
                    }
                }
                else
                {
                    MessageBox.Show("Formato de fecha no válido. Por favor, ingresa la fecha en formato DD/MM/AAAA.", "Mensaje");
                }
            }
        }

        static bool EsBisiesto(int año)
        {
            return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
        }

        // Función para sumar los dígitos de un número
        private int SumarDigitos(int numero)
        {
            int suma = 0;

            while (numero > 0)
            {
                suma += numero % 10;
                numero /= 10;
            }
            return suma;
        }

        // Función para reducir un número a un solo dígito
        private int ReducirADigito(int numero)
        {
            while (numero >= 10)
            {
                numero = SumarDigitos(numero);
            }
            return numero;
        }

        protected void btnCalcularCasa_Click(object sender, EventArgs e)
        {
            string input2 = tbCasas.Text.ToLower().Trim();
            // Dividir la cadena en nombres y números
            string[] nombresYNumeros = input2.Split(' ');
            // Variables para contar la frecuencia de cada letra de la "a" a la "z"
            int[] frecuenciaLetras2 = new int[26];
            // Variables para contar la frecuencia de números del 1 al 9
            int[] frecuenciaNumeros2 = new int[9];

            foreach (string nombreONumero in nombresYNumeros)
            {
                foreach (var caracter in nombreONumero)
                {
                    if (char.IsLetter(caracter))
                    {
                        // Si es una letra, calcular el índice correspondiente y actualizar la frecuencia
                        int indiceLetra = (int)caracter - 97;
                        frecuenciaLetras2[indiceLetra]++;
                    }
                    else if (char.IsDigit(caracter))
                    {
                        int indicereal = (int)caracter - 49;
                        if (indicereal != -1)
                        {
                            frecuenciaNumeros2[indicereal]++;
                            MessageBox.Show("El numero es :" + (indicereal + 1));
                        }
                        else
                        {
                            MessageBox.Show("El numero es :" + (indicereal + 1)); // SI USO EL 0 SE VA DE RANGO EL indice en el vector 
                        }
                    }
                }
            }

            // Calcular la vibración total de las letras
            int totalLetras = 0;
            for (int i = 0; i < frecuenciaLetras2.Length; i++)
            {
                totalLetras += frecuenciaLetras2[i] * (i + 1);
            }

            // Calcular la vibración total de los números
            int totalNumeros = 0;
            for (int i = 0; i < frecuenciaNumeros2.Length; i++)
            {
                totalNumeros += frecuenciaNumeros2[i] * (i + 1);
            }

            // Mostrar resultados
            MessageBox.Show($"Vibración total de las letras: {totalLetras}", "Mensaje");
            MessageBox.Show($"Vibración total de los números: {totalNumeros}", "Mensaje");
            MessageBox.Show($"Vibración total de las casas: {totalLetras + totalNumeros}", "Mensaje");
            int totalfinal = totalLetras + totalNumeros;
            MessageBox.Show($"Y SU Vibración total  FINAL de las casas: " + ReducirADigito(totalfinal), "Mensaje");
        }

        protected void lblVibracionAnual_Click(object sender, EventArgs e)
        {
            //Ingresar fecha de nacimiento, nombre y apellido
            string fechaNacimientoStr = txtFecha.Text.ToLower().Trim();
            string nombreCompleto = tbNombre.Text.ToLower().Trim() + " " + tbApellidos.Text.ToLower().Trim();

            int IndiTrans = 0;
            int Column = 0;
            string[] nombres = nombreCompleto.Split(' ');

            int CantNombres = nombres.Length;
            // Variables para almacenar las vibraciones anuales sin reducir
            int[,] vibracionesAnuales = new int[300, CantNombres]; // Matriz de 100 filas y 26 columnas
            int[] vibracionAnualFinal = new int[300];

            // Dividir la fecha en día, mes y año
            string[] partesFecha = fechaNacimientoStr.Split('/');

            // Convertir a números enteros
            int dia = Convert.ToInt32(partesFecha[0]);
            int mes = Convert.ToInt32(partesFecha[1]);
            int anio = Convert.ToInt32(partesFecha[2]);


            // Inicializar la matriz a cero
            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < CantNombres; j++)
                {
                    vibracionesAnuales[i, j] = 0;
                }
            }

            // Inicializar el vector a cero
            for (int i = 0; i < 300; i++)
            {
                vibracionAnualFinal[i] = 0;
            }

            if (DateTime.TryParseExact(fechaNacimientoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
            {

                // Obtener el año de nacimiento
                int añoNacimiento = fechaNacimiento.Year;
                foreach (string nom in nombres)
                {

                    foreach (char letra in nom)
                    {
                        /// MessageBox.Show($"Letras del nombre {nombre}:", "Mensaje");
                        char primerletra = letra;
                        int indiceLetra1 = (int)primerletra - 96;

                        for (int i = 0; i < indiceLetra1; i++)
                        {
                            vibracionesAnuales[IndiTrans, Column] = indiceLetra1;
                            IndiTrans++;//me guardo el indice que sigue en la letra 
                        }

                    }
                    Column++;///cambio de nombre
                    IndiTrans = 0;
                }

                ///esto es para que vuelva a reescribir cada nombre en cada una de las columnas de la matriz para hacer mas años, sino llego a los 50 nomas
                Column = 0;
                int aux = -1;
                int primerCero = -1;

                foreach (string nom in nombres)
                {

                    foreach (char letra in nom)
                    {
                        /// MessageBox.Show($"Letras del nombre {nombre}:", "Mensaje");
                        char primerletra = letra;
                        int indiceLetra1 = (int)primerletra - 96;

                        for (int i = 0; i < 100; i++)
                        {

                            if (vibracionesAnuales[i, Column] == 0)
                            {
                                if (aux == -1)
                                {
                                    primerCero = i;
                                    vibracionesAnuales[primerCero, Column] = indiceLetra1;
                                    aux++;
                                }
                            }

                        }


                        for (int i = 0; i < indiceLetra1; i++)
                        {

                            vibracionesAnuales[primerCero, Column] = indiceLetra1;
                            primerCero++;//me guardo el indice que sigue en la letra 
                        }

                    }
                    Column++;///cambio de nombre
                    aux = -1;
                }


            }
            else
            {
                MessageBox.Show("Formato de fecha no válido. Por favor, ingresa la fecha en formato DD/MM/AAAA.", "Mensaje");
            }

            for (int i = 0; i < 300; i++)
            {
                int sumaFila = 0;

                for (int j = 0; j < CantNombres; j++)
                {
                    sumaFila += vibracionesAnuales[i, j];
                }

                vibracionAnualFinal[i] = sumaFila;
            }

            for (int i = 0; i < 300; i++)
            {
                if (vibracionAnualFinal[i] != 0)
                {
                    int edad = i + 1;
                    int vibracionFinal = vibracionAnualFinal[i];

                    MessageBox.Show($"Año {anio + i + 1}: Edad = {edad}, Vibración Anual Final = {vibracionFinal}", "Información");
                }
            }
        }

        protected void btnAuto_Click(object sender, EventArgs e)
        {

            //Ingresar nombre
            string nombreCompleto = tbNombre.Text.ToLower().Trim() + " " + tbApellidos.Text.ToLower().Trim();
            string[] nombres = nombreCompleto.Split(' ');
            int CantNombres = nombres.Length;

           
            // Variables para calcular el número de vibración del reto
            int primerVocal = -1;
            int ultimaVocal = -1;
            int PrimerConso = -1;
            int UltimaConso = -1;

            // Variables para contar la frecuencia de cada letra de la "a" a la "z"
            int[,] frecuenciaLetras1 = new int[26, CantNombres];

            // Inicializar la matriz a cero
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < CantNombres; j++)
                {
                    frecuenciaLetras1[i, j] = 0;
                }
            }

       
            int aux1 = 0;
            // Iterar sobre cada nombre
            int SumaConso = 0;
            int SumaVoc = 0;
            int SumaTot = 0;
     
            int[] SumaVocales= new int [CantNombres];
            for (int i = 0; i < CantNombres; i++)
            {
                    SumaVocales[i] = 0;
            }

            foreach (string nombre in nombres)
            {

                foreach (var letra in nombre)
                {
                    //LA MATRIZ ME GUARDA EN CADA COLUMNA LAS LETRAS QUE APARECEN EN EL NOMBRE REPARTIDAS EN EL ABECEDARIO
                    // SUMANDO UNO EN LA POSICION CORRESPONDIENTE LLEGANDO A 26 
                    int indicereal = (int)letra - 97;
                    frecuenciaLetras1[indicereal, aux1]++;
                    MessageBox.Show("La letra es :" + letra);

                    if (indicereal == 0 || indicereal == 4 || indicereal == 8 || indicereal == 14 || indicereal == 20)
                    {
                        if (primerVocal == -1)
                        {
                            primerVocal = indicereal + 1;
                        }
                        ultimaVocal = indicereal + 1;
                        SumaVoc += (indicereal + 1);
                        SumaVocales[aux1] += indicereal + 1;
                    }
                    else
                    {
                        if (PrimerConso == -1)
                        {
                            PrimerConso = indicereal + 1;
                        }
                        UltimaConso = indicereal + 1;
                        SumaConso += (indicereal + 1);
                    }
                    
                }
                aux1++;
                
                ///ACA QUERRIA QUE ME MUESTRE TODOS LAS LETRAS DE CADA UNO DE LOS NOMBRES O ME LOS GUARDE
                ///  MessageBox.Show($"Total de letras en {nombre}: {nombre.Length}", "Mensaje");
            }
            SumaTot = SumaVoc + SumaConso;
            int VocRed = ReducirADigito(SumaVoc);
            int ConsoRed = ReducirADigito(SumaConso);
            int TotRed=ReducirADigito(SumaTot);

            ///PERSONALIDAD INTERNA (AUTO MOTIVACION)
            ///PERSONALIDAD EXTERNA (AUTO IMAGEN)
            ///TALENTO AUTO EXPRESION
            MessageBox.Show($"SUMA VOCALES {SumaVoc}  VOCALES REDUCIDAS{VocRed}", "Mensaje");
            MessageBox.Show($"SUMA CONSO {SumaConso}  CONSO REDUCIDAS{ConsoRed}", "Mensaje");
            MessageBox.Show($"SUMA TOT {SumaTot}  TOT REDUCIDAS{TotRed}", "Mensaje");

            ///Reto Auto motivacion Primer vocal - Ultima vocal
            ///Reto Auto imagen  primer conso - Ultima conso 
            ///Reto de Auto expresion suma de los 2 anteriores. 
            int RetoMoti = Math.Abs(ReducirADigito(primerVocal - ultimaVocal));
            int RetoIma = Math.Abs(ReducirADigito(PrimerConso - UltimaConso));
            int RetoExp = ReducirADigito(RetoMoti + RetoIma);
            MessageBox.Show($"Reto motivacion {RetoMoti}  ", "Mensaje");
            MessageBox.Show($"Reto Imagen {RetoIma}  ", "Mensaje");
            MessageBox.Show($"Reto Expresion {RetoExp}  ", "Mensaje");

            for (int i = 0; i < CantNombres; i++)
            {
                MessageBox.Show($"SUMA DE LAS VOCALES DEL NOMBRE/APELLIDO EN LA POSICION {i+1}   YA REDUCIDO DA:{ReducirADigito(SumaVocales[i])}  ", "Mensaje");
            }

        }

        protected void btn_Aspectos_Click(object sender, EventArgs e)
        {

            NegocioAspecto negocio = new Negocio.NegocioAspecto();
            char A = 'A';
            gvAspectodelasletras.DataSource = negocio.ObtenerAspectodelasletrass(A);
            gvAspectodelasletras.DataBind();
        }

        protected void btn_Autoexpresion_Click(object sender, EventArgs e)
        { //Ingresar nombre
            string nombreCompleto = tbNombre.Text.ToLower().Trim() + " " + tbApellidos.Text.ToLower().Trim();
            string[] nombres = nombreCompleto.Split(' ');
            int CantNombres = nombres.Length;


            // Variables para calcular el número de vibración del reto
            int primerVocal = -1;
            int ultimaVocal = -1;
            int PrimerConso = -1;
            int UltimaConso = -1;

            // Variables para contar la frecuencia de cada letra de la "a" a la "z"
            int[,] frecuenciaLetras1 = new int[26, CantNombres];

            // Inicializar la matriz a cero
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < CantNombres; j++)
                {
                    frecuenciaLetras1[i, j] = 0;
                }
            }


            int aux1 = 0;
            // Iterar sobre cada nombre
            int SumaConso = 0;
            int SumaVoc = 0;
            int SumaTot = 0;

            int[] SumaVocales = new int[CantNombres];
            for (int i = 0; i < CantNombres; i++)
            {
                SumaVocales[i] = 0;
            }

            foreach (string nombre in nombres)
            {

                foreach (var letra in nombre)
                {
                    //LA MATRIZ ME GUARDA EN CADA COLUMNA LAS LETRAS QUE APARECEN EN EL NOMBRE REPARTIDAS EN EL ABECEDARIO
                    // SUMANDO UNO EN LA POSICION CORRESPONDIENTE LLEGANDO A 26 
                    int indicereal = (int)letra - 97;
                    frecuenciaLetras1[indicereal, aux1]++;
                    ///MessageBox.Show("La letra es :" + letra);

                    if (indicereal == 0 || indicereal == 4 || indicereal == 8 || indicereal == 14 || indicereal == 20)
                    {
                        if (primerVocal == -1)
                        {
                            primerVocal = indicereal + 1;
                        }
                        ultimaVocal = indicereal + 1;
                        SumaVoc += (indicereal + 1);
                        SumaVocales[aux1] += indicereal + 1;
                    }
                    else
                    {
                        if (PrimerConso == -1)
                        {
                            PrimerConso = indicereal + 1;
                        }
                        UltimaConso = indicereal + 1;
                        SumaConso += (indicereal + 1);
                    }

                }
                aux1++;

                ///ACA QUERRIA QUE ME MUESTRE TODOS LAS LETRAS DE CADA UNO DE LOS NOMBRES O ME LOS GUARDE
                ///  MessageBox.Show($"Total de letras en {nombre}: {nombre.Length}", "Mensaje");
            }
            SumaTot = SumaVoc + SumaConso;
            int VocRed = ReducirADigito(SumaVoc);
            int ConsoRed = ReducirADigito(SumaConso);
            int TotRed = ReducirADigito(SumaTot);

            ///PERSONALIDAD INTERNA (AUTO MOTIVACION)
            ///PERSONALIDAD EXTERNA (AUTO IMAGEN)
            ///TALENTO AUTO EXPRESION
            ///
            /*
            MessageBox.Show($"SUMA VOCALES {SumaVoc}  VOCALES REDUCIDAS{VocRed}", "Mensaje");
            MessageBox.Show($"SUMA CONSO {SumaConso}  CONSO REDUCIDAS{ConsoRed}", "Mensaje");
            MessageBox.Show($"SUMA TOT {SumaTot}  TOT REDUCIDAS{TotRed}", "Mensaje");
            */
            ///Reto Auto motivacion Primer vocal - Ultima vocal
            ///Reto Auto imagen  primer conso - Ultima conso 
            ///Reto de Auto expresion suma de los 2 anteriores. 

            NegocioExpresion expre = new NegocioExpresion();
            NegocioImagen ima = new NegocioImagen();
            NegocioMotivacion moti = new NegocioMotivacion();

            int RetoMoti = Math.Abs(ReducirADigito(primerVocal - ultimaVocal));
            int Ima = Math.Abs(PrimerConso - UltimaConso);
            int RetoIma = ReducirADigito(Ima);
            int RetoExp = ReducirADigito(RetoMoti + RetoIma);

            MessageBox.Show($"Reto Expresion {RetoExp}  ", "Mensaje");
            MessageBox.Show($"Reto motivacion {RetoMoti}  ", "Mensaje");
            MessageBox.Show($"Reto Imagen {RetoIma}  ", "Mensaje");

            gvAutoexpresion.DataSource = expre.ObtenerAutoExpresionn(RetoExp);
            gvAutoexpresion.DataBind();
            gvAutoimagen.DataSource = ima.ObtenerAutoImagenn(RetoIma);
            gvAutoimagen.DataBind();
            gvAutomotivacion.DataSource = moti.ObtenerAutoMotivacionn(RetoMoti);
            gvAutomotivacion.DataBind();

            /*
            MessageBox.Show($"Reto motivacion {RetoMoti}  ", "Mensaje");
            MessageBox.Show($"Reto Imagen {RetoIma}  ", "Mensaje");
            MessageBox.Show($"Reto Expresion {RetoExp}  ", "Mensaje");
            
            for (int i = 0; i < CantNombres; i++)
            {

                MessageBox.Show($"SUMA DE LAS VOCALES DEL NOMBRE/APELLIDO EN LA POSICION {i + 1}   YA REDUCIDO DA:{ReducirADigito(SumaVocales[i])}  ", "Mensaje");
            }
            */
        }
    }
}