using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.View
{
    public class ProductView
    {
        public void ShowInConsole(List<Product> lista){ // esse metodo vai criar uma outra lista que irá mostrar as informaçõse que estavam no Models
            Console.ForegroundColor = ConsoleColor.Green;
            foreach(Product item in lista){
                Console.WriteLine($"Produto: {item.Name} || Preço: {item.Price.ToString("N2")} reais || Código: {item.Code}");
            }
            Console.ResetColor();
        }

        public Product CadastrarProduto(){
            Product cadastrarProd = new Product();
            Console.WriteLine($"Digite o código do produto:");
            cadastrarProd.Code = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine($"Digite o nome do produto:");
            cadastrarProd.Name = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine($"Digite o preço do produto:");
            cadastrarProd.Price = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            
            return cadastrarProd;
        } 
    }
}