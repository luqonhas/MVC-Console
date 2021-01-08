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
            List<User> lista = userModels.Ler(); // essa nova lista vai ser igual ao metodo "Ler" do Models, que também é uma lista
            userView.ShowInConsole(lista); // os dados da lista vão ser exibidos pelo View conforme aquele padrão de CWL que está no diretório View
        }
        public void Search(string termo){
            List<User> lista = userModels.Ler().FindAll(x => x.CPF == termo); // aqui vai achar todos os itens da lista com o valor que o cliente buscar
            userView.ShowInConsole(lista); // vai exibir no View
        }

        public void Cadastrar(){
            userModels.Inserir(userView.CadastrarCliente()); // o Models vai inserir as informações no View as coisas que cadastrar
        }
    }
}