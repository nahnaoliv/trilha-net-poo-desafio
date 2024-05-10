using DesafioPOO.Models;
using System.Reflection;
using System;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine($"- Nokia Tijolão");

// Criar uma instância de Nokia
Nokia nokia = new Nokia("31975279430", "", "", 10);

nokia.Ligar();
// Instalar um aplicativo no Nokia
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine(" ");

Console.WriteLine($"- Iphone");

// Criar uma instância de iPhone
Iphone iphone = new Iphone("31975279430", "", "", 10);

iphone.Ligar();
iphone.ReceberLigacao();
// Instalar um aplicativo no iPhone
iphone.InstalarAplicativo("Instagram");

