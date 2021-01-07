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
            Console.Clear();
            UserController user = new UserController();
            user.Cadastrar();
            user.Listar();
            ProductController product = new ProductController();
            product.Cadastrar();
            product.Listar();
        }
    }
}
