using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.View
{
    public class UserView
    {
        public void ShowInConsole(List<User> lista){ // esse metodo vai criar uma outra lista que irá mostrar as informaçõse que estavam no Models
            Console.ForegroundColor = ConsoleColor.Green;
            foreach(User item in lista){
                Console.WriteLine($"Cliente: {item.Name} || Email: {item.Email} || CPF: {item.CPF}");
                Console.WriteLine("");
            }
            Console.ResetColor();
        }

        public User CadastrarCliente(){
            User cadastrarClient = new User();
            Console.WriteLine($"Digite o nome do cliente:");
            cadastrarClient.Name = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine($"Digite o e-mail do cliente:");
            cadastrarClient.Email = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine($"Digite o CPF do cliente:");
            cadastrarClient.CPF = Console.ReadLine();
            Console.WriteLine("");
            
            return cadastrarClient;
        }
    }
}