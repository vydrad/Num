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
            IntroducciónAVibraciónDeLasCasas.Text = "Numeros de la casa: el número de su casa, mas el número de su calle, dan un significado completo a su hogar, pero el numero de la casa, tiene una influencia más fuerte.";
            IntroducciónADesafio.Text = "El número de desafío es uno de los más importantes en la vida de una persona, ya que representa la manera en que abordará su destino, es decir como utilizará sus instintos" +
                " y talentos naturales, además la forma de como se expresará con la gente y las experiencias.";
            IntroducciónAPinaculos.Text = "Son las pruebas a las que debemos aceptar y enfrentar sin poderlas eludir, estudiar estos pinaculos nos permitirá comprender los cambios" +
                " de caracter y actitutdes, tambien los altibajos en general, que todos tenemos.";
            IntroducciónARetoAutoExpresion.Text = "Describe nuestros puntos debiles en el talento.";
            IntroducciónARetoAutoImagen.Text = "En este caso habla de las cualidades que nos faltan y que debemos adquirir para no dar una impresión negativa.";
            IntroducciónARetoAutoMotivacion.Text = "Habla de los defectos internos a superar para lograr nuestros propositos para lograr nuestras ambiciones o nuestros sueños.";
            IntroducciónAVibracionesAnuales.Text = "En esta Tabla de Vibraciones Anuales en referencia nuestro nombre debemos trabajar con la TABLA de Aspectos de los Numeros y ver que LETRA se encuentra en que PLANO y asi obtener como trabajan esas letras en ese año una vez que hayan cumplido los años y además la vibración total reducida de las letras como vibración Anual debe buscarse el número en la información que está abajo de esta Tabla de Vibraciones Anuales las cuales nos marcan ciclios que indican tendencias.";
            lbl_Planos.Text = "Plano Mental: Este nos indicara cómo funciona su mente a través de los pensamientos. Cuando está equilibrado tendremos, fuerza de voluntad, capacidad para razonar, analítica y por manejo de grandes empresas, emprendimiento ";
            lbl_Planos.Text += "<br> <br> Plano físico: En este plano encontramos la fuerza física, el sexo y la concreción en el plano material. Cuando hay excesivos números indica que el sexo ocupa un lugar muy importante, cuesta la concentración. Cuando hay pocas números, hay falta de voluntad, objetividad y practicidad.";
            lbl_Planos.Text += "<br><br>Plano Emotivo: Aquí vemos el manejo de nuestros sentimientos, muchos números revelan que es compasivo y sentimental, suele estar enfrascado en ideas, sueños sin poderlos concretar. Pocos números indican la dificultad para expresar sus sentimientos falta de orientación y sensibilidad. <br> ";
            lbl_Planos.Text += " <br> Plano Intuitivo: Se relaciona con la fe, creencia e intuición. Muchos números indican capacidad literaria, religiones e inventiva. Pocos números indican falta de fe. <br> <br> ";
            lbl_Planos.Text += " <br> <br>1: Indica al pensador, al líder, Independiente.<br> 8: Tiene capacidad de mando, deseos de poder, orgullo y lucha por mejorar siempre. " +
                        "<br> <br> 4: Son responsables, trabajadores, eficientes, pero no aceptan ideas renovadoras y les cuesta mucho la creatividad, son muy estructuradas. <br> " +
                        "5: Indica que son prácticos, se adaptan a los cambios, evitan caer en la rutina. " +
                        "<br> <br> 2: Representa el sentimiento y la imaginación, también el miedo, la preocupación y la espiritualidad.<br> " +
                        "3: El talento artístico, la creatividad y el impulso. <br> " +
                        "6: Son responsables, necesitan del hogar y la familia, son exigentes y dominantes. " +
                        "<br> <br> 7: Analíticas intuitivas, refinados, reservados, perfeccionistas, críticos bucean en las fuerzas ocultas.<br> " +
                        "9: Pensadores, pueden trabajar con todo el mundo. Les gusta ser admirados, pero con humildad, son tolerantes, compasivos y desinteresados.";
            IntroducciónAAutoexpresion.Text = "Autoexpresión: La autoexpresión, representada por un número en la numerología pitagórica, es una indicación de cómo te comunicas con el mundo exterior y cómo te muestras a ti mismo. Este número refleja tus habilidades creativas, tu capacidad para comunicarte de manera efectiva y cómo expresas tu personalidad única a través de diferentes medios. Esencialmente, tu número de autoexpresión revela cómo te relacionas con los demás y cómo utilizas tus talentos y habilidades para expresar quién eres verdaderamente.";
            IntroducciónAAutoimagen.Text = "Autoimagen: El número de autoimagen en numerología pitagórica es una representación numérica de cómo te percibes a ti mismo y cómo deseas ser percibido por los demás. Este número refleja tu sentido de identidad, tu confianza en ti mismo y la imagen que deseas proyectar en el mundo. Describe cómo te visualizas logrando tus metas, cómo te sientes en relación con tu posición en la vida y cómo te ves a ti mismo en términos de éxito, poder y autoridad.";
            IntroducciónAAutomotivacion.Text = "Automotivación: El número de automotivación en numerología pitagórica es una representación numérica de tu impulso interno y tu deseo fundamental de alcanzar tus metas y aspiraciones. Este número refleja tu capacidad para motivarte a ti mismo, tu determinación y tu fuerza de voluntad para seguir adelante incluso en tiempos difíciles. Esencialmente, tu número de automotivación revela qué te impulsa a actuar y perseguir tus metas, así como tu nivel de determinación para superar obstáculos y lograr el éxito en la vida.";
            IntroducciónACapsula.Text = "La capsula, es el número que me permite desde muchos enfoques, hacer frente a una situación, en un momento o en un lapso de tiempo. La idea es no permanecer demasiado tiempo en esta vibración sin el aprendizaje.";
            IntroducciónAPeriodos52Dias.Text = "SISTEMA PREVENTIVO: Favorable y desfavorable Plazos: 52 días. Tiene un leve error ya que 52x7 = 364 y nos faltaría un día.";
            IntroducciónAHerencia.Text = "Son las cualidades Heredadas de nuestros padres. ";
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

        /// ASPECTO DE LAS LETRAS
        protected void btn_Aspectos_Click(object sender, EventArgs e)
        {
            ///LETRA - FISICO - AFECTIVO - ESPIRITUAL
            NegocioAspecto negocio = new Negocio.NegocioAspecto();
            char A = 'A';
            gvAspectodelasletras.DataSource = negocio.ObtenerAspectodelasletrass(A);
            gvAspectodelasletras.DataBind();
        }

        ///AUTO EXPRESION, AUTO MOTIVACION, AUTO IMAGEN
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

            int instintosPracticos = 0; ///son la suma de las vocales del primer nombre
            int instintosEmocionales = 0; // son la suma de las vocales del segundo nombre
            int instintosEspirituales = 0; //son la suma de las vocales del 3er wea
            int cont = 0;
            foreach (string nombre in nombres)
            {
                cont++;
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

                        if (cont == 1)
                        {
                            instintosPracticos += (indicereal + 1);
                        }
                        if (cont == 2)
                        {
                            instintosEmocionales += (indicereal + 1);
                        }
                        if (cont == 3)
                        {
                            instintosEspirituales += (indicereal + 1);
                        }
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
            int RetoMoti = Math.Abs(ReducirADigito(primerVocal - ultimaVocal));
            int RetoIma = Math.Abs(ReducirADigito(PrimerConso-UltimaConso));
            int RetoImaRed = ReducirADigito(RetoIma);
            int RetoExpre = ReducirADigito(RetoMoti+RetoIma);

            if (RetoMoti == 0)

            SumaTot = SumaVoc + SumaConso;
            int MotiAdicional = SumaVoc;
            int VocRed = ReducirADigito(SumaVoc);

            int ImaAdicional = SumarDigitos(SumaConso);
            int ConsoRed = ReducirADigito(SumaConso);

            int ExpAdicional = SumarDigitos(SumaVoc + SumaConso);
            int TotRed = ReducirADigito(SumaTot);

          /*  MessageBox.Show($"Vocales Reducidas {VocRed} SINO {MotiAdicional} ", "Mensaje");
            MessageBox.Show($"Consonantes Reducidas {ConsoRed}  SINO {ImaAdicional} ", "Mensaje");
            MessageBox.Show($"Total Reducido {TotRed} SINO {ExpAdicional} ", "Mensaje");*/
          
            MessageBox.Show($"Imagen ES: sumaconso {SumaConso} "+$"Conso Red  {ConsoRed}", "Mensaje");
            MessageBox.Show($"Motivacion ES: sumavoc  {SumaVoc}" + $"o voc red {VocRed} ", "Mensaje");
            MessageBox.Show($"Exprsion ES: sumatot {SumaTot} "+ $"o Tot red  {TotRed}  ", "Mensaje");
            /// NO SE SI TENGO LA INFO DE ESTO PERO ESTÁ BIEN SACADO, PERO SIN REDUCIR 
           // MessageBox.Show($"Instintos practicos {instintosPracticos} Instintos Emocionales {instintosEmocionales}  Instintos Espirituales{instintosEspirituales}", "Mensaje");
            NegocioExpresion expre = new NegocioExpresion();
            NegocioImagen ima = new NegocioImagen();
            NegocioMotivacion moti = new NegocioMotivacion();

            NegocioRetoExpresion expree = new NegocioRetoExpresion();
            NegocioRetoImagen imaa = new NegocioRetoImagen();
            NegocioRetoMotivacion motii = new NegocioRetoMotivacion();

            gvAutoMotivacion.DataSource = moti.ObtenerAutoMotivacionn(VocRed);
            gvAutoMotivacion.DataBind();
            gvAutoImagen.DataSource = ima.ObtenerAutoImagenn(ConsoRed);
            gvAutoImagen.DataBind();
            gvAutoExpresion.DataSource = expre.ObtenerAutoExpresionn(TotRed);
            gvAutoExpresion.DataBind();
            
            gvRetoAutoMotivacionAdicional.DataSource = motii.ObtenerRetoAutoMotivacionn(RetoMoti);
            gvRetoAutoMotivacionAdicional.DataBind();
            gvRetoAutoImagenAdicional.DataSource = imaa.ObtenerRetoAutoImagenn(RetoImaRed);
            gvRetoAutoImagenAdicional.DataBind();
            gvRetoExpresionAdicional.DataSource = expree.ObtenerRetoAutoExpresionn(RetoExpre);
            gvRetoExpresionAdicional.DataBind();
        }

        ///NUMERO DE ALMA
        protected void btn_Numeroalma_Click(object sender, EventArgs e)
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

                NegocioDestino desti = new NegocioDestino();
                gvNumerodealma.DataSource = desti.ObtenerDestinoo(resultadoFinal);
                gvNumerodealma.DataBind();

                // Mostrar el resultado en la consola para verificar
                MessageBox.Show($"Resultado Final: " + resultadoFinal, "Mensaje");
            }
        }

        protected void btnDesafios_Click(object sender, EventArgs e)
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

                ///--------------- DESAFIOS DE LA VIDA ----------------------
                ///1ER Desafio 0-28 anios - 2DO Desafio 29-34 anios - 3ER Desafio 35-49 anios - 4TO Desafio 50-final xd
                ///// Calcular el 1er Desafío
                int primerDesafio = Math.Abs(ReducirADigito(mes) - ReducirADigito(dia));
                // MessageBox.Show("Primer Desafio:" + primerDesafio, "Mensaje");
                // Calcular el 2do Desafío
                int segundoDesafio = Math.Abs(ReducirADigito(dia) - ReducirADigito(ReducirADigito(anio)));
                // MessageBox.Show("Segundo Desafio:" + segundoDesafio, "Mensaje");
                // Calcular el 3er Desafío
                int tercerDesafio = Math.Abs(primerDesafio - segundoDesafio);
                // MessageBox.Show("Tercer Desafio:" + tercerDesafio, "Mensaje");
                // Calcular el 4to Desafío
                int cuartoDesafio = Math.Abs(ReducirADigito(mes) - ReducirADigito(ReducirADigito(anio)));
                // MessageBox.Show("Cuarto Desafio:" + cuartoDesafio, "Mensaje");
                lbl_Rangodesafio1.Text = " <br> El rango del primer desafio es de 0 años a 28 años";
                lbl_Rangodesafio2.Text = " <br> El rango del segundo desafio es de 29 años a 34 años";
                lbl_Rangodesafio3.Text = " <br> El rango del tercer desafio es de 35 años a 49 años";
                lbl_Rangodesafio4.Text = " <br> El rango del cuarto desafio es de 50 años a hasta el final";

                NegocioDesafio desa = new NegocioDesafio();
                gvPrimerdesafio.DataSource = desa.ObtenerDesafioo(primerDesafio);
                gvPrimerdesafio.DataBind();
                gvSegundodesafio.DataSource = desa.ObtenerDesafioo(segundoDesafio);
                gvSegundodesafio.DataBind();
                gvTercerdesafio.DataSource = desa.ObtenerDesafioo(tercerDesafio);
                gvTercerdesafio.DataBind();
                gvCuartodesafio.DataSource = desa.ObtenerDesafioo(cuartoDesafio);
                gvCuartodesafio.DataBind();
            }
        }

        protected void btnPinaculos_Click(object sender, EventArgs e)
        {
            ///----------------------- PARA OBTENER LOS DATOS A TRAVES DE LA FECHA DE NACIMIENTO ---------------------------------
            string fechaIngresada = txtFecha.Text;
            string[] partesFecha = fechaIngresada.Split('/');

            if (partesFecha.Length == 3)
            {
                // Convertir a números enteros
                int dia = Convert.ToInt32(partesFecha[0]);
                int mes = Convert.ToInt32(partesFecha[1]);
                int anio = Convert.ToInt32(partesFecha[2]);

                int añopersonal = dia + mes + anio;

                /// --------------------NUMERO DE ALMA----------------------------
                int sumaDigitos = SumarDigitos(dia) + SumarDigitos(mes) + SumarDigitos(anio);

                // Reducir la suma a un solo dígito - NUMERO DE ALMA
                int resultadoFinal = ReducirADigito(sumaDigitos);

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
                lbl_Rangopinaculo1.Text = $" <br> El rango del primer pinaculo es de {rangoEdadPrimerPinaculo} años a los {rangoEdadPrimerPinaculo + 9} años";
                lbl_Rangopinaculo2.Text = $" <br> El rango del segundo pinaculo es de {rangoEdadPrimerPinaculo + 10} años a los {rangoEdadSegundoPinaculo} años";
                lbl_Rangopinaculo3.Text = $" <br> El rango del tercer pinaculo es de {rangoEdadSegundoPinaculo + 1} años a los {rangoEdadSegundoPinaculo + 9} años";
                lbl_Rangopinaculo4.Text = $" <br> El rango del cuarto y ultimo pinaculo es de {rangoEdadSegundoPinaculo + 10} años a los {tercerPinaculo} años";

                //  Mostrar los resultados en la consola para verificar
                //  MessageBox.Show($"1er Pináculo: {primerPinaculo}" + $" / Rango de Edad para 1er Pináculo: {rangoEdadPrimerPinaculo}", "Mensaje");
                //  MessageBox.Show($"2do Pináculo: {segundoPinaculo}" + $" / Rango de Edad para 2do Pináculo: {rangoEdadSegundoPinaculo}", "Mensaje");
                //  MessageBox.Show($"3er Pináculo: {tercerPinaculo}" + $" / Rango de Edad para 3er Pináculo: {rangoEdadTercerPinaculo}", "Mensaje");
                //  MessageBox.Show($"4to Pináculo: {cuartoPinaculo}" + $" / Rango de Edad para 4to Pináculo: {rangoEdadCuartoPinaculo}", "Mensaje");
                NegocioPinaculo pina = new NegocioPinaculo();
                gvPrimerpinaculo.DataSource = pina.ObtenerPinaculoo(primerPinaculo);
                gvPrimerpinaculo.DataBind();
                gvSegundopinaculo.DataSource = pina.ObtenerPinaculoo(segundoPinaculo);
                gvSegundopinaculo.DataBind();
                gvTercerpinaculo.DataSource = pina.ObtenerPinaculoo(tercerPinaculo);
                gvTercerpinaculo.DataBind();
                gvCuartopinaculo.DataSource = pina.ObtenerPinaculoo(cuartoPinaculo);
                gvCuartopinaculo.DataBind();
            }
        }

        protected void btnPersonal_Click(object sender, EventArgs e)
        {

            string fechaIngresada = txtFecha.Text;
            string[] partesFecha = fechaIngresada.Split('/');

            if (partesFecha.Length == 3)
            {
                // Convertir a números enteros
                int dia = ReducirADigito(Convert.ToInt32(partesFecha[0]));
                int mes = ReducirADigito(Convert.ToInt32(partesFecha[1]));
                int anio = ReducirADigito(Convert.ToInt32(partesFecha[2]));
                // MessageBox.Show($"dia mes anio :" + dia + " " + mes + " " + anio, "Mensaje");
                ///------------------AÑO, MES Y DIA PERSONAL ---------------------------------
                ///// Calcular la suma de día, mes y año sin reducir (Año Personal)
                int anoPersonal = ReducirADigito(dia + mes + anio);

                // Calcular el Mes Personal
                int mesPersonal = ReducirADigito(anoPersonal + mes);

                // Calcular el Día Personal
                int diaPersonal = ReducirADigito(anoPersonal + mesPersonal + dia);
                // MessageBox.Show($"diaP mesP anioP :" + diaPersonal + " " + mesPersonal + " " + anoPersonal, "Mensaje");
                NegocioDiaPersonal diaP = new NegocioDiaPersonal();
                NegocioMesPersonal mesP = new NegocioMesPersonal();
                NegocioAnioPersonal anioP = new NegocioAnioPersonal();

                gvDiapersonal.DataSource = diaP.ObtenerDiaPersonall(diaPersonal);
                gvDiapersonal.DataBind();
                gvMespersonal.DataSource = mesP.ObtenerMesPersonall(mesPersonal);
                gvMespersonal.DataBind();
                gvAniopersonal.DataSource = anioP.ObtenerAnioPersonall(anoPersonal);
                gvAniopersonal.DataBind();
            }
        }
        
                protected void btn_Periodo52_Click(object sender, EventArgs e)
                {
                    string fechaNacimientoStr = txtFecha.Text;

                    if (DateTime.TryParseExact(fechaNacimientoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
                    {
                        // Variables para almacenar los periodos
                        DateTime[] fechasInicio = new DateTime[7];
                        DateTime[] fechasFin = new DateTime[7];
                        DateTime[] fechasInicioMas1 = new DateTime[7];
                        // Define la duración de un periodo en días
                        int duracionPeriodo = 52;

                        // Calcula los periodos
                        for (int i = 0; i < 7; i++)
                        {
                            // Calcula la fecha de inicio del periodo
                            fechasInicio[i] = fechaNacimiento.AddDays(i * duracionPeriodo);
                            fechasInicioMas1[i] = fechaNacimiento.AddDays(i * duracionPeriodo);
                            fechasInicioMas1[i].AddDays(2);
                            // Calcula la fecha de fin del periodo (sumando 52 días y ajustando por años bisiestos)
                            fechasFin[i] = fechasInicio[i].AddDays(duracionPeriodo);

                            if (EsBisiesto(fechasFin[i].Year) && fechasInicio[i].Month == 2 && fechasInicio[i].Day == 29)
                            {
                                fechasFin[i] = fechasFin[i].AddDays(1);

                            }

                            // Muestra los resultados
                            ///MessageBox.Show($"Periodo {i + 1}: Desde {fechasInicio[i].ToString("dd/MM/yyyy")} hasta {fechasFin[i].ToString("dd/MM/yyyy")}", "Mensaje");
                            if (i == 0)
                            {
                                lbl_Periodos52.Text += $"Periodo {i + 1}: Desde {fechasInicio[i].ToString("dd/MM/yyyy")} hasta {fechasFin[i].ToString("dd/MM/yyyy")} <br>";
                            }
                            else
                            {
                                lbl_Periodos52.Text += $"Periodo {i + 1}: Desde {fechasInicio[i].ToString("dd/MM/yyyy")} hasta {fechasFin[i].ToString("dd/MM/yyyy")} <br>";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Formato de fecha no válido. Por favor, ingresa la fecha en formato DD/MM/AAAA.", "Mensaje");
                    }
                }
        
        protected void btnVibracionCasas_Click(object sender, EventArgs e)
        {
            string input2 = tbCasas.Text.ToLower().Trim();
            // Dividir la cadena en nombres y números
            string[] nombresYNumeros = input2.Split(' ');
            // Variables para contar la frecuencia de cada letra de la "a" a la "z"
            int[] frecuenciaLetras2 = new int[26];
            // Variables para contar la frecuencia de números del 1 al 9
            int[] frecuenciaNumeros2 = new int[9];

            int totalLetras = 0;
            int TotalNumeros = 0;
            int Total = 0;

            foreach (string nombreONumero in nombresYNumeros)
            {
                foreach (var caracter in nombreONumero)
                {
                    if (char.IsLetter(caracter))
                    {
                        // Si es una letra, calcular el índice correspondiente y actualizar la frecuencia
                        int indiceLetra = (int)caracter - 97;
                        frecuenciaLetras2[indiceLetra]++;
                        totalLetras += indiceLetra + 1;
                    }
                    else if (char.IsDigit(caracter))
                    {
                        int indicereal = (int)caracter - 49;
                        if (indicereal != -1)
                        {
                            frecuenciaNumeros2[indicereal]++;
                            TotalNumeros += indicereal + 1;
                            /// MessageBox.Show("El numero es :" + (indicereal + 1));
                        }
                        else
                        {
                            ///MessageBox.Show("El numero es :" + (indicereal + 1)); // SI USO EL 0 SE VA DE RANGO EL indice en el vector 
                        }
                    }
                }
            }
            int numeros = ReducirADigito(TotalNumeros);
            int letras = ReducirADigito(totalLetras);
            Total = ReducirADigito(numeros + letras);
            NegocioVibracionCasa casa = new NegocioVibracionCasa();

            gvVibracionCasas.DataSource = casa.ObtenerVibracionCasaPlanetaa(Total);
            gvVibracionCasas.DataBind();
        }

        protected void btnHerencia_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Ingresa hasta 3 nombres separados por un espacio:");
            string input = tbNombre.Text.ToLower().Trim();
            string[] nombres = input.Split(' ');
            int[] frecuenciaLetras = new int[26];


            int PrimerasLetras = 0;
            for (int aux = 0; aux < frecuenciaLetras.Length; aux++)
            {
                frecuenciaLetras[aux] = 0;
            }
            ///-------------------------------HERENCIA --------------------------------
            ///SUMAMOS LOS 2 APELLIDOS Y LOS REDUCIMOS, VYDRA + MAIDANA
            string input2 = tbApellidos.Text.ToLower().Trim();
            string[] Apellidos = input2.Split(' ');
            int[] frecuenciaLetras2 = new int[26];
            int Here = 0;

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
                        Here += indicereal + 1;
                        //     MessageBox.Show("La letra es :" + letra);

                    }
                }

                int Heren = ReducirADigito(Here);

                NegocioHerencia here = new NegocioHerencia();
                gvHerencia.DataSource = here.ObtenerHerenciaa(Heren);
                gvHerencia.DataBind();
                lblResultado.Text += $"{Heren} <br/> ";

            }
            else
            {
                MessageBox.Show("Has ingresado mas de 2 apellidos  Por favor, intenta nuevamente.", "Mensaje");
            }

        }

        protected void btnRetoCapsula_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Ingresa hasta 3 nombres separados por un espacio:");
            string input = tbNombre.Text.ToLower().Trim();
            string[] nombres = input.Split(' ');
            int[] frecuenciaLetras = new int[26];
            int primerVocal = -1;
            int ultimaVocal = -1;

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
                        //MessageBox.Show("La letra es :" + letra);

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
                            // MessageBox.Show("La letra es :" + letra);

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
                    int numeroVibracionRetoAutoMotivacion = Math.Abs(primerVocal - ultimaVocal);
                    int numeroVibracionRetoAutoImagen = Math.Abs(primerVocal - ultimaVocal);
                    int numeroVibracionRetoAutoExpresion = Math.Abs(primerVocal - ultimaVocal);
                    lblResultado.Text += $"Número de vibración del reto: {numeroVibracionRetoAutoMotivacion} <br/>";
                    int Capsu = ReducirADigito(PrimerasLetras);
                    // Calcular el número de cápsula
                    lblResultado.Text += $"Número de cápsula: {ReducirADigito(PrimerasLetras)} <br/>";

                    MessageBox.Show("Capsula es :" + Capsu);

                    NegocioCapsula capsu = new NegocioCapsula();
                    gvCapsula.DataSource = capsu.ObtenerCapsulaa(Capsu);
                    gvCapsula.DataBind();


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

        protected void btn_VibracionesAnuales_Click(object sender, EventArgs e)
        {

            //Ingresar fecha de nacimiento, nombre y apellido
            string fechaNacimientoStr = txtFecha.Text.ToLower().Trim();
            string nombreCompleto = tbNombre.Text.ToLower().Trim() + " " + tbApellidos.Text.ToLower().Trim();

            int IndiTrans = 0;
            int Column = 0;
            string[] nombres = nombreCompleto.Split(' ');

            int CantNombres = nombres.Length;
            // Variables para almacenar las vibraciones anuales sin reducir
            int[,] vibracionesAnuales = new int[600, CantNombres]; // Matriz de 100 filas y 26 columnas
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
            MessageBox.Show($"Cantidad de nombres: {CantNombres}:", "Mensaje");
            if (DateTime.TryParseExact(fechaNacimientoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
            {

                // Obtener el año de nacimiento
                int añoNacimiento = fechaNacimiento.Year;
                ///ESCRIBIO EL NOMBRE Y APELLIDO EN CADA FILA EMPZANDO DEL 0
                foreach (string nom in nombres)
                {

                    foreach (char letra in nom)
                    {
                        char primerletra = letra;
                        int indiceLetra1 = (int)primerletra - 96;

                        for (int i = 0; i < indiceLetra1; i++)
                        {
                            vibracionesAnuales[IndiTrans, Column] = indiceLetra1;
                            IndiTrans++;//me guardo el indice que sigue en la letra 
                            /// PONGO EL NOMBRE EN CADA COLUMNA UNA VEZ
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
                                    //// BUSCO EL PRIMER CERO
                                    primerCero = i;
                                    vibracionesAnuales[primerCero, Column] = indiceLetra1;
                                    aux++;
                                }
                            }

                        }

                        if (primerCero != -1)
                        {
                            ////////////////// ACA SE ROMPE CON 2 NOMBRES
                            for (int i = 0; i < indiceLetra1; i++)
                            {

                                vibracionesAnuales[primerCero, Column] = indiceLetra1;
                                primerCero++;//me guardo el indice que sigue en la letra 
                            }
                        }

                    }
                    Column++;///cambio de nombre
                    aux = -1;
                }

                /// VUELVO A REESCRIBIR LOS VALORES PORQUE David 2 veces llegaba a 80 años nomas, asi que necesito reescribir una vez mas
                Column = 0;
                int aux1 = -1;
                int primerCero2 = -1;

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
                                if (aux1 == -1)
                                {
                                    primerCero2 = i;
                                    vibracionesAnuales[primerCero2, Column] = indiceLetra1;
                                    aux1++;
                                }
                            }

                        }

                        if (primerCero2 != -1)
                        {

                            for (int i = 0; i < indiceLetra1; i++)
                            {
                                ///MessageBox.Show($"Primer Cero 2 {primerCero2}. Columna {Column},  indice {indiceLetra1}", "Mensaje");
                                vibracionesAnuales[primerCero2, Column] = indiceLetra1;///  SE VA DE RANGO
                                primerCero2++;//me guardo el indice que sigue en la letra 
                            }
                        }

                    }
                    primerCero2 = -1;
                    Column++;///cambio de nombre
                    aux1 = -1;
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

            int planoF = -1;
            int planoEmo = -1;
            int planoEsp = -1;
            int planoAdicional = -1;
            int[] NumerosAnuales = new int[110];



            for (int i = 0; i < 100; i++)
            {

                for (int j = 0; j < CantNombres; j++)
                {
                    /* int vibracionFinal = vibracionAnualFinal[i];
                     int edad = i + 1;
                    */
                    if (j == 0)
                    {
                        planoF = vibracionesAnuales[i, 0];
                        planoEmo = vibracionesAnuales[i, 1];
                    }
                    if (CantNombres == 3)
                    {
                        planoEsp = vibracionesAnuales[i, 2];
                    }

                    if(CantNombres == 4)
                    {
                        planoEsp = vibracionesAnuales[i, 2];
                        planoAdicional =vibracionesAnuales[i,3];
                    }

                }
                int edad = i + 1;
                char plaF = (char)(planoF + 64);
                char plaEm = (char)(planoEmo + 64);
                char plaEs = (char)(planoEsp + 64);
                char plaAD = (char)(planoAdicional + 64);
                if (NumerosAnuales[vibracionAnualFinal[i] - 1] == 0)
                {
                    NumerosAnuales[vibracionAnualFinal[i] - 1] = 1; ///ACA MARCO LOS NUMEROS QUE APARECEN AUNQUE SEA UNA VEZ
                }

                lbl_VibracionesAnuales.Text += $"Año {anio + i + 1} ~ Edad = {edad} ~ Plano físico: {plaF} ~ Plano Emocional: {plaEm} ~ Plano Espiritual: {plaEs} ~ Adicional: {plaAD}~ Vibración Anual Final = {vibracionAnualFinal[i]} <br>";
            }

            NegocioaAnualPersonal anu = new NegocioaAnualPersonal();
            string consulta = "SELECT Vibracion_Anual, Info FROM VibracionAnual WHERE ";
            for (int k =0; k< 15; k++)
            {
                consulta += $"Vibracion_Anual = {k + 1} OR ";
            }

            for (int x = 0; x < NumerosAnuales.Length; x++)
            {
                if (NumerosAnuales[x] != 0)
                {
                    consulta += $"Vibracion_Anual = {x + 1} OR ";
                }
            }

            // Eliminar la última "OR" y ejecutar la consulta solo si hay condiciones
            if (!string.IsNullOrEmpty(consulta))
            {
                consulta = consulta.Substring(0, consulta.Length - 4); // Eliminar la última " OR "
                gvVibracionAnualPersonal.DataSource = anu.ObtenerAnualPersonall(consulta);
                gvVibracionAnualPersonal.DataBind();
            }


        }

        protected void btnPlanos_Click(object sender, EventArgs e)
        {
            ///------------------------PARA OBTENER EL VALOR DE LAS LETRAS DEL NOMBRE / APELLIDO ---------------------------------------
            Console.WriteLine("Ingresa hasta 3 nombres separados por un espacio:");
            string input = tbNombre.Text.ToLower().Trim();

            // Dividir la cadena en nombres individuales
            string[] nombres = input.Split(' ');

            // Variables para contar la frecuencia de cada letra de la "a" a la "z"
            int[] frecuenciaLetras = new int[26];

            // Variables para calcular el número de vibración del reto

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

                    foreach (var letra in nombre)
                    {
                        int indicereal = (int)letra - 97;
                        int ind = ReducirADigito(indicereal);
                        if (indicereal == 20)
                        {
                            ind = 1;
                        }
                        if (indicereal  == 18)
                        {
                            ind = 0;
                        }

                        frecuenciaLetras[ind]++;
               
                        //MessageBox.Show("La letra nombre es :" + ind);

                    }
                    ///  MessageBox.Show($"Total de letras en {nombre}: {nombre.Length}", "Mensaje");
                }

                ///-------------------------------HERENCIA --------------------------------
                ///SUMAMOS LOS 2 APELLIDOS Y LOS REDUCIMOS, VYDRA + MAIDANA
                string input2 = tbApellidos.Text.ToLower().Trim();
                string[] Apellidos = input2.Split(' ');


                if (Apellidos.Length <= 2)
                {
                    // Iterar sobre cada nombre
                    foreach (string apellido in Apellidos)
                    {
                        /// MessageBox.Show($"Letras del nombre {nombre}:", "Mensaje");
                        foreach (var letra in apellido)
                        {
                            int indicereal = (int)letra - 97;
                            int indi = ReducirADigito(indicereal);
                            if (indicereal == 20)
                            {
                                indi = 1;
                            }

                            if (indicereal == 18)
                            {
                                indi = 0;
                            }

                            frecuenciaLetras[indi]++;
                           // MessageBox.Show("La letra apellido :" + indi);

                        }
                    }

                            lblResultado.Text += $"El Plano Fisico: Numero 4 Se repite {frecuenciaLetras[3]} veces <br/> ";
                            lblResultado.Text += $"El Plano Fisico: Numero 5 Se repite {frecuenciaLetras[4]} veces <br/><br/>  ";

                            lblResultado.Text += $"El Plano Emotivo: Numero 2 Se repite {frecuenciaLetras[1]} veces <br/> ";
                            lblResultado.Text += $"El Plano Emotivo: Numero 3 Se repite {frecuenciaLetras[2]} veces <br/> ";
                            lblResultado.Text += $"El Plano Emotivo: Numero 6 Se repite {frecuenciaLetras[5]} veces <br/> <br/> ";

                            lblResultado.Text += $"El Plano Mental: Numero 1 Se repite {frecuenciaLetras[0]} veces <br/> ";
                            lblResultado.Text += $"El Plano Mental: Numero 8 Se repite {frecuenciaLetras[7]} veces <br/><br/>  ";

                            lblResultado.Text += $"El Plano Intuitivo: Numero 7 Se repite {frecuenciaLetras[6]} veces <br/> ";
                            lblResultado.Text += $"El Plano Intuitivo: Numero 9 Se repite {frecuenciaLetras[8]} veces <br/> ";

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fechaIngresada = txtFecha.Text;
            string[] partesFecha = fechaIngresada.Split('/');

        
                // Convertir a números enteros
                int dia = Convert.ToInt32(partesFecha[0]);
                int mes = Convert.ToInt32(partesFecha[1]);
                int anio = Convert.ToInt32(partesFecha[2]);

            int diared = ReducirADigito(dia);
            int mesred = ReducirADigito(mes);

            NegocioInfluenciaDia Influ = new NegocioInfluenciaDia();
            NegocioInfluenciaMes Influ2 = new NegocioInfluenciaMes();

            gvInfluenciaDia.DataSource = Influ.ObtenerInfluenciaDiaa(diared);
            gvInfluenciaDia.DataBind();

            gvInfluenciaMes.DataSource = Influ2.ObtenerInfluenciaMess(mesred);
            gvInfluenciaMes.DataBind();


        }
    }
}