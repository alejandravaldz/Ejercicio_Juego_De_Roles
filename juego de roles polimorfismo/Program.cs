// See https://aka.ms/new-console-template for more information
using juego_de_roles_polimorfismo;
Console.WriteLine("Juegos de roles");
Console.WriteLine();
Console.WriteLine();



Mago merlin = new Mago();
merlin.Nombre = "Merlín";
merlin.Nivel = 10;
merlin.PuntosMagia = 100;
merlin.PuntosTransformación = 50;
merlin.Presentarse();
merlin.LanzarHechizo();
merlin.Transformarce();
Console.WriteLine();
Console.WriteLine();

Guerrero Saimon = new Guerrero();
Saimon.Nombre = "Saimon";
Saimon.Nivel = 10;
Saimon.Arma = "Espada!";
Saimon.Armadura = " Escudo de acero!";

Saimon.Presentarse();
Saimon.Atacar();
Saimon.Protegerlaspersonas();

Console.ReadLine();