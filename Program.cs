using System;
using MVC_Console.Controller;
using MVC_Console.Models;
using MVC_Console.View;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductController prod = new ProductController();
            prod.Listar();
        }
    }
}
