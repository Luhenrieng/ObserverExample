// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ObserverExample.Controllers;
using ObserverExample.Models;

var email = new Email();

var controladorEmail = new ControladorEmail(email);

var usuarioA = new UsuarioA(controladorEmail);
var usuarioB = new UsuarioB(controladorEmail);
var usuarioC = new UsuarioC(controladorEmail);

Console.WriteLine("Os usuários A, B e C se cadastaram para receber as promoções. \n");

Console.WriteLine("Enviando email para os usuários cadastrados...\n");

controladorEmail.EnviarEmail();

Console.WriteLine("O usuárioA resolveu cancelar a assinatura e não irá mais receber email. \n");

usuarioA.Dispose();

Console.WriteLine("Enviando email para os usuários cadastrados...\n");

controladorEmail.EnviarEmail();

Console.ReadKey();
