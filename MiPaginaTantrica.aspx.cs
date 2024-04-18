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
    public partial class MiPaginaTantrica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IntroducciónNumerologiaTantrica.Text = "Los números han sido un tema de gran interés a lo largo de la historia. En un nivel espiritual, la numerología se ha desarrollado en distintas culturas del mundo como una herramienta que puede orientar a las personas en su camino y facilitar diversos procesos de sanación y crecimiento. Entre las ramas de numerología más conocidas encontramos a la numerología Pitagórica, la Cabalística y la Tántrica. En el caso de la numerología tántrica, ésta tiene sus raíces en antiguas enseñanzas yóguicas y tántricas en India. Uno de los significados del concepto “tantra” corresponde a “tejer”, por lo que la numerología tántrica nos enseña el camino y vida que cada persona viene a tejer o construir.  ¿Cómo se expande la numerología tántrica desde oriente? Yogi Bhajan(1929 - 2004) fue un maestro y yogui que introdujo el Kundalini Yoga y la Numerología Tántrica en Occidente. Según Yogi Bhajan, la numerología es una herramienta para la liberación interior y para que el alma encuentre su propósito de vida. La numerología tántrica es utilizada para iluminar el camino, las habilidades y la naturaleza del alma. ,¿Cómo funciona? Los números que constituyen la base de esta numerología van del 1 al 11, y los principales dígitos a analizar son los que corresponden a la fecha de nacimiento de la persona, incluyendo día, mes y año. Cada número tiene su propio significado e interpretación. Con ellos, podemos identificar números que nos indican talentos, herramientas, misión de vida, karma, entre otros. A lo anterior se suma que la numerología tántrica también considera la existencia de 10 cuerpos espirituales que se estudian a través de los números, entre los que encontramos al alma, los cuerpos mentales, el cuerpo físico, el aura, y varios más. Es posible identificar bloqueos energéticos en estos cuerpos de acuerdo a los números y sus configuraciones en la fecha de nacimiento y de acuerdo al análisis que se realice es posible detener aquellos desequilibrios. Yogui Bhajan afirmaba que, si conocemos nuestros números, podemos dirigir nuestra vida con más seguridad, claridad y paz. A mi parecer, entre las distintas ramas de numerología que existen hasta el día de hoy, la numerología tántrica se destaca por su enfoque profundamente espiritual que nos impulsa a la liberación, la expansión y el autoconocimiento de forma integral y compasiva. Si la espiritualidad y el crecimiento son temas con los que resuenas o últimamente te han llamado la atención, te aconsejo cultivar esa curiosidad con una mente abierta y dispuesta a aprender. ";
                IntroducciónAlmaTantrica.Text = "NÚMEROS DEL ALMA: El factor alma representa ese aspecto del ser que determina en gran medida la conexión con el alma y, consecuentemente, la paz espiritual. Nuestra paz espiritual depende en la relación que tengamos con nuestra alma. Nuestra alma no es otra cosa que la manifestación de Dios en nosotros. El proceso de evolución consiste en trabajar en la unión de nuestra conciencia finita con la conciencia infinita. El primer paso que hay que dar es el reconocimiento de la manifestación de este proceso en nosotros. Nuestra alma vive en nosotros. No es nuestro ego ni nuestra personalidad. Nuestra alma no tiene nombre, forma, ocupación, profesión; no tiene nada de todo esto. Nuestra alma no se define por tener una buena voz para cantar o ser inteligente en matemáticas. Todo esto está aquí contigo aquí y ahora; pero, de hecho, no tiene nada que ver con nuestra alma. Nuestra alma es la energía más pura que poseemos, es la fuente de amor, paz y sabiduría que reside dentro de nosotros y no tiene nada que ver con la estructura que hemos agregado a ella externamente. Nos adherimos a nuestro ego, al mundo externo, a nuestra personalidad, a nuestros títulos, a nuestra profesión, a nuestro sufrimiento, a muchas cosas, pero ninguna de estas es duradera, todo va, todo es temporal, todo cambia, desaparece. La única cosa que está aquí, que estuvo aquí y estará aquí, es nuestra alma. El agotamiento siempre está involucrado con el cuerpo espiritual del alma, que es uno de los aspectos más importantes que debe ser conquistado o superado. El significado de la entrega es la montaña más alta que debemos escalar para alcanzar la meta final de todos nuestros traumas psicológicos que hemos tenido a lo largo de nuestras vidas. De esta manera, seremos capaces de superar el cansancio y el sentimiento de que nuestra alma es importante. El alma es nuestro único amigo, cuanto más profunda es la relación y cuanto más conscientes somos de esto, no nos importará lo que suceda, el alma estará con nosotros para darnos fuerza espiritual como seres humanos. El alma se define como profunda paz interna. Representa aquello a lo que conscientemente trabajamos para lograr una relación profunda con el alma, para poder descubrirla o conectarnos con ella. Porque el alma es eterna, no cambia, va más allá del tiempo y el espacio.";
                IntroducciónDharmTantrica.Text = "LOS NÚMEROS DEL REGALO DIVINO: Este factor indica el significado que cada número tiene como recurso espiritual dado a nosotros en esta vida, como una virtud que ahora poseemos y que no teníamos en existencias anteriores. Es algo en lo que podemos confiar, la base de nuestra fortaleza, un regalo y una bendición divina. El REGALO DIVINO es una energía celestial y sublime que nos acompaña desde el momento en que nacemos hasta que morimos. Contiene la fuerza de la experiencia espiritual y nos llena, nutre, guía y orienta. Esta energía celestial está siempre a nuestro servicio, y nosotros debemos servirla en todo momento de nuestra vida. Tenemos el derecho y la obligación de beneficiarnos y utilizarla. Cuando nuestra alma deja este cuerpo físico, esta energía debe extinguirse, y si no sucede así, es porque no hemos seguido las reglas del juego y no hemos permitido que la energía divina continúe su ciclo. Permitirlo sería una falta de respeto hacia la energía universal y hacia el alma divina. El REGALO DIVINO es uno de los dos pilares que nos ayudan y apoyan en nuestro proceso de evolución espiritual. Es una característica muy especial. Mientras que los factores del ALMA y el KARMA deben trabajarse intensamente, en el regalo no es necesario; se dice que es el contenido de la energía de cada uno de los cuerpos espirituales que trabajan para nosotros. Muchas personas no saben o no quieren aceptar este regalo, ni saben cómo hacerlo en esta vida, y al no aceptarlo, están rechazando lo que Dios les ha dado de manera directa y personal. Es importante aceptar y utilizar este regalo, ya que es una cualidad real y muy importante. Al menospreciar nuestras cualidades internas, estamos actuando con ego, y debemos aceptarlas con satisfacción, honestidad y generosidad, lo cual es verdadera humildad.";
                IntroducciónKarmaTantrica.Text = "NÚMEROS DEL KARMA: El factor del karma representa el conflicto externo con el mundo y también la armonía externa que debe prevalecer. Representa en qué debes trabajar, qué debes perfeccionar en ti mismo para sentirte espiritualmente en el camino correcto dentro del mundo. Todas nuestras acciones, todos nuestros pensamientos crean una onda de energía, una vibración. Es como cuando una piedra cae en el agua y causa ondas concéntricas que se expanden más allá de la piedra: el karma tiene este mismo efecto. Cada acción, cada pensamiento crea ondas que nos afectan a nosotros y a nuestro entorno y a todas las personas que nos rodean. Constantemente se afectan mutua y directamente o indirectamente. El karma es el proceso de acción y reacción, representa que todo lo que se hace, que se piensa, se multiplicará por diez: cada pensamiento o acción consciente, amable, útil, compasivo, palabra, positiva, también nos será devuelto. Diez veces y con la misma energía; También recibiremos manifestaciones negativas diez veces y con la misma energía. Esta es una ley cósmica y es la ley del karma. La vida es como una rueda, es un proceso continuo de reencarnaciones: nacemos, crecemos, envejecemos, morimos y nos reencarnamos nuevamente. En cada vida que vivimos estamos sujetos a lo que hemos traído de vidas pasadas y a las consecuencias de la vida actual. Todo esto crea karma para la próxima reencarnación. La razón por la que vivimos en este planeta es trabajar conscientemente para liberarnos del karma para no tener que estar sujetos a este proceso de acción y reacción de no tener que seguir atados a la Rueda de la Vida. Para poder separarnos de este proceso, debemos seguir lo que se llama el Dharma, que literalmente significa el camino de la rectitud o la acción correcta. Es el camino espiritual. Puede ser cualquier camino, ya sea católico, judío, yogui, budista o sin dar ningún nombre, pero el camino espiritual cuando se vive conscientemente es el Dharma. Las escrituras dicen que donde hay Dharma no hay karma. Esto es lo que nos libera del karma o la rueda de la vida. Todos estamos nadando en el océano de nuestras vidas tratando de alcanzar la otra orilla; El Dharma es como un bote que nos recoge y nos transporta. Si vivimos conscientemente este camino, dejaremos de estar sujetos a nuestras acciones porque serán cada vez más correctas, nuestras intenciones serán más puras y así podremos controlar nuestro karma. Nunca debemos olvidar que dependiendo de cuáles sean nuestras acciones y / o pensamientos, determinarán nuestro karma, tanto instantánea como futuramente. Por eso vivimos vidas, porque en cada una estamos aprendiendo y evolucionando internamente. Por todo esto, cada uno de los números. Integrado dentro del factor del karma, nos indicará en qué estamos atascados y qué tenemos que hacer para liberarnos, para poder sentirnos en el camino espiritual y no estar sujetos a la fuerza de la acción y reacción; sabiendo cómo actuar conscientemente de los resultados de nuestros pensamientos y acciones, seguir el camino del Dharma. El karma determina la relación con el mundo externo, representa la relación con los demás, cómo nos tratan y cómo los tratamos, cómo vivimos aquí y ahora.";
                IntroducciónMisionTantrica.Text = "Números de vida, misión: Aquellos representan lo que debe ser trabajado y experimentado en esta vida para lograr nuestra realización espiritual. Tiene que ser protegido. Este es el factor de cumplimiento que debemos lograr en esta vida; la verdadera realización se experimenta cuando podemos sentirnos divinos. Como trabajamos en el balance de los factores del alma y el karma, con el regalo divino y el conocimiento del destino, profundizamos y perfeccionamos esto. Así es como evolucionamos interna y externamente, y estamos empoderados para comprender el factor de la vida. Hemos venido a esta vida para manifestar, completar y perfeccionar el significado del número de vida. En el momento en que nos damos cuenta de que hemos dominado este número, sentiremos que estamos haciendo exactamente lo que debemos hacer, como si fuéramos el eje que nos une con el cosmos. Entonces, entendemos el significado de haber llegado al plano terrestre del universo. Miramos la calidad que representa y las claves de esta piedra de toque para lograr nuestro objetivo en esta vida. Cuando dominamos el cuerpo espiritual que este número representa, nuestra divinidad comenzará a fluir y dará frutos en el proceso espiritual. Este es el factor de plenitud, de nuestra satisfacción espiritual; es el momento de transmitir nuestra propia energía espiritual porque hemos alcanzado nuestra paz interna.";
                IntroducciónLos10CuerposEspirituales.Text = "LOS DIEZ CUERPOS ESPIRITUALES: No somos solo un cuerpo físico. Además del cuerpo físico, estamos formados por DIEZ CUERPOS ESPIRITUALES.Cada uno de estos diez cuerpos afecta la marcha energética del ser humano.Los obstáculos que se encuentran en el proceso de evolución de nuestra vida, ya sea a nivel físico, mental o espiritual, siempre están vinculados a estos diez Cuerpos Espirituales. La verdad del comienzo de cada enfermedad se encuentra primero a nivel espiritual, luego penetra a nivel mental y desde allí se manifiesta en un examen físico. Si no descubrimos qué está funcionando mal en cada uno de estos cuerpos espirituales, no seremos capaces de tener un diagnóstico real de la enfermedad. El estudio de estos diez cuerpos(que no podemos ver con nuestros propios ojos), hará que sea más fácil, de forma detallada, saber dónde está el problema y cómo determinan nuestra personalidad. El ser humano es comparado a un diamante. El diamante es carbono puro que, en su estado natural, a través de muchos años de presión y altas temperaturas, cristaliza, pero aún está en estado crudo hasta que un lapidario artesano lo talla, lo pule y lo moldea en una preciosa piedra. Asimismo, el ser humano, que está compuesto por cinco elementos: tierra, agua, fuego, aire y éter, también nace en su forma cruda hasta que, a través de la gracia del Creador, el ser aprende a superarse a sí mismo y encuentra a este maestro(artesano) que le enseña un camino, le da pautas a seguir, transforma sus instintos primarios(brutos) y lo convierte en como el diamante, en un estado limpio, pulido e ilimitado ser. Trabajar estos diez cuerpos es parte de este proceso de pulido.Cuando estos diez cuerpos están armonizados, es decir, es cuando nos encontramos en el más alto estado de conciencia y existencia. ";
                IntroducciónVidasPasadasTantrica.Text = "El factor destino representa lo que hemos experimentado en vidas pasadas, lo que hemos trabajado y desarrollado en ellas. Puede ser tanto positivo como negativo, e incluso una combinación de ambos. A veces, hay tendencias o cualidades que mostramos con frecuencia y facilidad, lo que indica que las hemos trabajado a lo largo de múltiples vidas. Estas cualidades han sido adquiridas con esfuerzo y dedicación. Si las llevamos con nosotros en esta vida, es porque aún estamos en proceso de evolución y necesitamos trabajar constantemente para utilizarlas adecuadamente. Cuando hacemos el esfuerzo necesario y aprovechamos las particularidades de nuestro destino, nos damos cuenta de que tenemos cierta facilidad para manifestarlas, ya que nuestras almas las conocen bien. El factor destino también se manifiesta en cómo los demás nos perciben en nuestras interacciones y actitudes. Es el segundo pilar que nos sostiene en nuestro proceso de crecimiento y evolución espiritual.";
                NegocioCuerposEspirituales espi = new NegocioCuerposEspirituales();
                string consulta = "SELECT Cuerpo_Espiritual, Info FROM CuerposEspirituales WHERE ";

                for (int x = 0; x < 11; x++)
                {

                        consulta += $"Cuerpo_Espiritual = {x + 1} OR ";

                }

                // Eliminar la última "OR" y ejecutar la consulta solo si hay condiciones
                if (!string.IsNullOrEmpty(consulta))
                {
                    consulta = consulta.Substring(0, consulta.Length - 4); // Eliminar la última " OR "
                    gv10CuerposEspirituales.DataSource = espi.ObtenerCuerposEspiritualess(consulta);
                    gv10CuerposEspirituales.DataBind();
                }
               

            }
        }

        protected void btnAlma_Click(object sender, EventArgs e)
        {
            ///----------------------- PARA OBTENER LOS DATOS A TRAVES DE LA FECHA DE NACIMIENTO ---------------------------------
            // Obtener la fecha ingresada
            string fechaIngresada = txtFechaTantrica.Text;

            // Dividir la fecha en día, mes y año
            string[] partesFecha = fechaIngresada.Split('/');

            if (partesFecha.Length == 3)
            {
                /// ALMA = DIA
                // Convertir a números enteros
                int dia = Convert.ToInt32(partesFecha[0]);
                int mes = Convert.ToInt32(partesFecha[1]);
                int anio = Convert.ToInt32(partesFecha[2]);
                int diaa = ReducirADigito(dia);

              //  MessageBox.Show($"el ALMA normal es:{dia}  el ALMA reducido es: {diaa} ","info");

                NegocioAlma alma = new NegocioAlma();
                gvAlma.DataSource = alma.ObtenerAlmaa(diaa);
                gvAlma.DataBind();
            }
        }

        protected void btnKarma_Click(object sender, EventArgs e)
        {
            ///----------------------- PARA OBTENER LOS DATOS A TRAVES DE LA FECHA DE NACIMIENTO ---------------------------------
            // Obtener la fecha ingresada
            string fechaIngresada = txtFechaTantrica.Text;
            // Dividir la fecha en día, mes y año
            string[] partesFecha = fechaIngresada.Split('/');

            if (partesFecha.Length == 3)
            {
                ///KARMA ES EL MES
                // Convertir a números enteros
                int dia = Convert.ToInt32(partesFecha[0]);
                int mes = Convert.ToInt32(partesFecha[1]);
                int anio = Convert.ToInt32(partesFecha[2]);
                int mess = ReducirADigito(mes);

              //  MessageBox.Show($"el karma normal es:{mes}  el karma reducido es: {mess} ", "info");

                NegocioKarma karma = new NegocioKarma();
                gvKarma.DataSource = karma.ObtenerKarmaa(mess);
                gvKarma.DataBind();
            }
        }

        protected void btnDharma_Click(object sender, EventArgs e)
        {
            ///----------------------- PARA OBTENER LOS DATOS A TRAVES DE LA FECHA DE NACIMIENTO ---------------------------------
            // Obtener la fecha ingresada
            string fechaIngresada = txtFechaTantrica.Text;
            // Dividir la fecha en día, mes y año
            string[] partesFecha = fechaIngresada.Split('/');

            if (partesFecha.Length == 3)
            { // EL DHARMA SON LOS ULTIMOS 2 DIGITOS DEL AÑO 
                // Convertir a números enteros
                int dia = Convert.ToInt32(partesFecha[0]);
                int mes = Convert.ToInt32(partesFecha[1]);
                int anio = Convert.ToInt32(partesFecha[2]);
                int dharmareal = anio % 100;
                int dharma = ReducirADigito(dharmareal);
                int dharmaa = ReducirADigito(dharma);

               // MessageBox.Show($"el karma normal es:{dharma}  el karma reducido es: {dharmaa} ", "info");

                NegocioDharma dharm = new NegocioDharma();
                gvDharma.DataSource = dharm.ObtenerDharmaa(dharmaa);
                gvDharma.DataBind();
            }
        }

        protected void btnDestino_Click(object sender, EventArgs e)
        {
            ///----------------------- PARA OBTENER LOS DATOS A TRAVES DE LA FECHA DE NACIMIENTO ---------------------------------
            // Obtener la fecha ingresada
            string fechaIngresada = txtFechaTantrica.Text;
            // Dividir la fecha en día, mes y año
            string[] partesFecha = fechaIngresada.Split('/');

            if (partesFecha.Length == 3)
            {
                //  VIDAS PASADAS O DESTINO SE SUMA LOS DIGITOS DEL  AÑO 
                // Convertir a números enteros
                int dia = Convert.ToInt32(partesFecha[0]);
                int mes = Convert.ToInt32(partesFecha[1]);
                int anio = Convert.ToInt32(partesFecha[2]);

                int año = ReducirADigito(anio);
                int añoreducido = ReducirADigito(año);

               // MessageBox.Show($"el vidasPasadas normal es:{año}  el VidasPasadas reducido es: {añoreducido} ", "info");

                NegocioVidasPasadas destino = new NegocioVidasPasadas();
                gvDestino.DataSource = destino.ObtenerVidasPasadass(añoreducido);
                gvDestino.DataBind();
            }
        }

        protected void btnVida_Click(object sender, EventArgs e)
        {
            ///----------------------- PARA OBTENER LOS DATOS A TRAVES DE LA FECHA DE NACIMIENTO ---------------------------------
            // Obtener la fecha ingresada
            string fechaIngresada = txtFechaTantrica.Text;

            // Dividir la fecha en día, mes y año
            string[] partesFecha = fechaIngresada.Split('/');

            if (partesFecha.Length == 3)
            {   //NUMERO DE MISION O VIDA
                // Convertir a números enteros

                int dia = Convert.ToInt32(partesFecha[0]);
                int mes = Convert.ToInt32(partesFecha[1]);
                int anio = Convert.ToInt32(partesFecha[2]);
                int diaa = ReducirADigito(dia);
                int mess = ReducirADigito(mes);
                int anioo = SumarDigitos(anio);
                int vida = diaa + mess + anioo;
                int vidareducida = ReducirADigito(vida);
              //  MessageBox.Show($"dia: {dia}  mes:{mes} anio: {anio} ", "info");
              //  MessageBox.Show($"diaa: {diaa}  mess:{mess} anioo: {anioo} ", "info");
              //  MessageBox.Show($"el Mision normal es:{vida}  el Mision reducido es: {vidareducida} ", "info");

                NegocioMisionVida vid = new NegocioMisionVida();
                gvVida.DataSource = vid.ObtenerMisionn(vidareducida);
                gvVida.DataBind();
            }
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

    }
}