using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.View;

namespace MVC_Console.Controller
{
    public class ProductController
    {
        Product productModels = new Product();
        ProductView productView = new ProductView();

        public void Listar(){
            List<Product> lista = productModels.Ler(); // essa nova lista vai ser igual ao metodo "Ler" do Models, que também é uma lista
            productView.ShowInConsole(lista); // os dados da lista vão ser exibidos pelo View conforme aquele padrão de CWL que está no diretório View
        }
        public void Search(string termo){
            List<Product> lista = productModels.Ler().FindAll(x => x.Price == float.Parse(termo)); // aqui vai achar todos os itens da lista com o valor que o cliente buscar
            productView.ShowInConsole(productModels.Ler); // vai exibir no View
        }
    }
}