using System;
using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.View;

namespace MVC_Console.Controller
{
    public class UserController
    {
        User userModels = new User();
        UserView userView = new UserView();

        public void Listar(){
            List<User> lista = userModels.Ler();
            userView.ShowInConsole(lista);
        }

        public void Search(string termo){
            List<User> lista = userModels.Ler().FindAll(x => x.CPF == int.Parse(termo)); // aqui vai achar todos os itens da lista com o valor que o cliente buscar
            userView.ShowInConsole(lista); // vai exibir no View
        }

        public void Cadastrar(){
            userModels.Inserir(userView.CadastrarCliente()); // o Models vai inserir as informações no View as coisas que cadastrar
        }
    }
}