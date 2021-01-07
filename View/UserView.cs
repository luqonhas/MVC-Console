using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.View
{
    public class UserView
    {
        public void ShowInConsole(List<User> lista){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach(User item in lista){             
                Console.WriteLine($"Cliente: {item.Name} || E-mail: {item.Email} || CPF: {item.CPF}");
            }
            Console.ResetColor();
        }

        public User CadastrarCliente(){
            Console.WriteLine("Gostaria de cadastrar um cliente? s/n");
            string resposta = Console.ReadLine();

            User cadastrarUser = new User();
            Console.WriteLine($"Digite o código do produto:");
            cadastrarUser.Name = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine($"Digite o nome do produto:");
            cadastrarUser.Email = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine($"Digite o preço do produto:");
            cadastrarUser.CPF = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            return cadastrarUser;
        }
    }
}