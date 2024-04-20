using LaboratorioProgra1.EjemploPolimorfismo;
using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio;

//static void EjemploPolimorfismo()
//{
   //  Animal[] animales = new Animal[3];
   // animales[0] = new Tortuga();
   // animales[1] = new Gato();
   // animales[2] = new Perro();
   // foreach (Animal animal in animales)
   // {
   //     animal.HacerSonido();
   // }
//}   

static void Laboratorio()
{
    VideoJuego videoJuego = new VideoJuego();
    videoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
    videoJuego.Desarrolladora = "Nintendo";
    videoJuego.Calificacion = 50;
    videoJuego.AnioLanzamiento = 2017;
    videoJuego.MostrarInformacion();


}

static void NBA2024()
{
    JuegoDeportes nba = new JuegoDeportes();
    nba.Titulo = "NBA 2024";
    nba.Desarrolladora = "2K Games";
    nba.Calificacion = 1000000;
    nba.AnioLanzamiento = 2024;
    nba.MostrarInformacion();
    nba.ConectarOnline();
}

static void Forza()
{
    JuegoCarreras Forza5 = new JuegoCarreras();
    Forza5.Titulo = "Forza Horizon 5";
    Forza5.Desarrolladora = "Xbox Game Studios";
    Forza5.Calificacion = 9999999999;
    Forza5.AnioLanzamiento = 2017;
    Forza5.MostrarInformacion();
    Forza5.Revasar();
}

NBA2024();
Forza();
Laboratorio();
VideoJuego.listaDeJuegos();



