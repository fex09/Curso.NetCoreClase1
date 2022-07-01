// See https://aka.ms/new-console-template for more information
//using Introduccion.Acoplamiento;

//*******************************************************************
//Ejemplo Acoplamiento
//*******************************************************************
//Proceso p = new Proceso();
//p.Ejecutar();

using Introduccion.DI;

EscritorMensaje escritor = new EscritorMensaje();

Proceso p = new Proceso(escritor);
p.Ejecutar();

Console.ReadLine();
