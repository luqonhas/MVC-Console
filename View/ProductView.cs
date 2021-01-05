using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.View
{
    public class ProductView
    {
        public void ShowInConsole(List<Product> lista){ // esse metodo vai criar uma outra lista que irá mostrar as informaçõse que estavam no Models
            foreach(Product item in lista){
                Console.WriteLine($"Produto: {item.Name} || Preço: {item.Price.ToString("N2")} reais || Código: {item.Code}");
                
            }
        }

        internal void ShowInConsole(Func<List<Product>> ler)
        {
            throw new NotImplementedException();
        }
    }
}