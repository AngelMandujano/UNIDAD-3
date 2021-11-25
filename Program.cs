// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escribe el NUMERO de la opcion que deseas ver");
Console.WriteLine("1. Luis MIguel");
Console.WriteLine("2. Ñengo Flow");
Console.WriteLine("3. Cartel de Santa");
Console.WriteLine("4. Alejandro Fernandez");
Console.WriteLine("5. Artistas populares de la semana");
Console.WriteLine("6. Lanzamientos de La semana");
Console.WriteLine("7. Salir");
Console.WriteLine("Escribe una opción");
string operacion = Console.ReadLine();
switch (operacion)
{
    case "1":
        luisMiguel(args);
        break;
    case "2":
        ñengoFlow(args);
        break;
    case "3":
        CartelDeSanta(args);
        break;
    case "4":
        alejandroFernandez(args);
        break;
    case "5":
        artistaspopulares(args);
        break;
    case "6":
       NuevosLanzamientos(args);
        break;
    case "7":
        Console.WriteLine("Gracias por usar el programa");
        break;
    default:
        Console.WriteLine("No has escrito una opción correcta");
        break;
}







// luisMiguel(args);
// ñengoFlow(args);
// CartelDeSanta(args);
// alejandroFernandez(args);
// artistaspopulares(args);
// NuevosLanzamientos(args);
static void luisMiguel(string[] args)
{
    string album1 = "aries.";
    string cancion1 = "Suave.";
    string album2 = "Busca una mujer.";
    string cancion2 = "Fria como el viento.";
    string album3 = "Romance.";
    string cancion3 = "Inolvidable.";
    string album4 = "México en la piel.";
    string cancion4 = "Motivos.";
    string album5 = "Navidades de Luis Miguel.";
    string cancion5 = "Santa Claus Llego a La Ciudad.";
    string dato1 = "album: " + album1 + " cancion mas sonada: " + cancion1;
    string dato2 = "album: " + album2 + " cancion mas sonada: " + cancion2;
    string dato3 = "album: " + album3 + " cancion mas sonada: " + cancion3;
    string dato4 = "album: " + album4 + " cancion mas sonada: " + cancion4;
    string dato5 = "album: " + album5 + " cancion mas sonada: " + cancion5;
   
    Console.WriteLine(dato1);
    Console.WriteLine(dato2);
    Console.WriteLine(dato3);
    Console.WriteLine(dato4);
    Console.WriteLine(dato5);

}
//ñengo Flow
static void ñengoFlow(string[] args)
{
    string album1 = "Real G4 Life Vol 1.";
    string cancion1 = "En las noches Frias.";
    string album2 = "Real G4 Life Vol 2.";
    string cancion2 = "Solo una oportunidad.";
    string album3 = "Real G4 Life Vol 3.";
    string cancion3 = "Te extraño.";
    string album4 = "The Goat.";
    string cancion4 = "Sur y Norte.";
    string album5 = "Los reyes del Rap.";
    string cancion5 = "Entramos disparando.";
    string dato1 = "album: " + album1 + " cancion mas sonada: " + cancion1;
    string dato2 = "album: " + album2 + " cancion mas sonada: " + cancion2;
    string dato3 = "album: " + album3 + " cancion mas sonada: " + cancion3;
    string dato4 = "album: " + album4 + " cancion mas sonada: " + cancion4;
    string dato5 = "album: " + album5 + " cancion mas sonada: " + cancion5;
   
    Console.WriteLine(dato1);
    Console.WriteLine(dato2);
    Console.WriteLine(dato3);
    Console.WriteLine(dato4);
    Console.WriteLine(dato5);

}

static void CartelDeSanta(string[] args)
{
    string album1 = "Viejo Marihuano.";
    string cancion1 = "Volvio el Sensei.";
    string album2 = "Golpe Avisa.";
    string cancion2 = "Andamos Zumbados.";
    string album3 = "Sin Copa.";
    string cancion3 = "Subete y ya Veras. ";
    string album4 = "Cartel De Santa.";
    string cancion4 = "Todas Mueren Por Mi.";
    string album5 = "Volumen prohibido.";
    string cancion5 = "Mira quien Vuleve al 100.";
    string dato1 = "album: " + album1 + " cancion mas sonada: " + cancion1;
    string dato2 = "album: " + album2 + " cancion mas sonada: " + cancion2;
    string dato3 = "album: " + album3 + " cancion mas sonada: " + cancion3;
    string dato4 = "album: " + album4 + " cancion mas sonada: " + cancion4;
    string dato5 = "album: " + album5 + " cancion mas sonada: " + cancion5;
   
    Console.WriteLine(dato1);
    Console.WriteLine(dato2);
    Console.WriteLine(dato3);
    Console.WriteLine(dato4);
    Console.WriteLine(dato5);

}

static void alejandroFernandez(string[] args)
{
    string album1 = "Hecho en Mécxico (EDICION ESPECIAL).";
    string cancion1 = "A Que Sabe El Olvido.";
    string album2 = "Hecho en México.";
    string cancion2 = "Caballero.";
    string album3 = "Confidencias.";
    string cancion3 = "Cóncavo y Convexo.";
    string album4 = "Dos Mundos.";
    string cancion4 = "Me Haces Tanto Bien.";
    string album5 = "A Corazon Abierto.";
    string cancion5 = "Me Dedique a Perderte.";
    string dato1 = "album: " + album1 + " cancion mas sonada: " + cancion1;
    string dato2 = "album: " + album2 + " cancion mas sonada: " + cancion2;
    string dato3 = "album: " + album3 + " cancion mas sonada: " + cancion3;
    string dato4 = "album: " + album4 + " cancion mas sonada: " + cancion4;
    string dato5 = "album: " + album5 + " cancion mas sonada: " + cancion5;
   
    Console.WriteLine(dato1);
    Console.WriteLine(dato2);
    Console.WriteLine(dato3);
    Console.WriteLine(dato4);
    Console.WriteLine(dato5);

}

static void artistaspopulares(string[] args)
{
    Console.WriteLine("Los artistas mas populares de la semana: ");
    string Artista1 = "Bad Bunny";
    string Artista2 = "Rauw Alejandro";
    string Artista3 = "Santa Fe Klan";
    string Artista4 = "Grupo Firme";
    string Artista5 = "Luis Miguel";
    Console.WriteLine("TOP 1 " + Artista1);
    Console.WriteLine("TOP 2 " + Artista2);
    Console.WriteLine("TOP 3 " + Artista3);
    Console.WriteLine("TOP 4 " + Artista4);
    Console.WriteLine("TOP 5 " + Artista5);
}

static void NuevosLanzamientos(string[] args)
{
    Console.WriteLine("Nuevos lanzamientos de la semana: ");
    string lanzamiento1 = "(SUBELO) Sencillo de Anuel AA";
    string lanzamiento2 = "(NO FUN) Sencillo de Armin van Buren";
    string lanzamiento3 = "(MOST PEOPLE) Sencillo de R3HAB";
    string lanzamiento4 = "(SHIBA GANG) Sencillo de Mandragora";
    string lanzamiento5 = "(512) Sencillo de Paris Boy";
    Console.WriteLine(lanzamiento1);
    Console.WriteLine(lanzamiento2);
    Console.WriteLine(lanzamiento3);
    Console.WriteLine(lanzamiento4);
    Console.WriteLine(lanzamiento5);

}


