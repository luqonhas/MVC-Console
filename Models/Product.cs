using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        private const string PATH = "Database/Product.csv";
        // indice:                       0         1
        public Product(){
            // Conferir se o diretório existe:

            string pasta = PATH.Split("/")[0]; // o nome da pasta vai ser do lado do indice 0
            if(!Directory.Exists(pasta)){ // se não existir um diretório com o nome do indice 0, vai criar
                Directory.CreateDirectory((pasta));
            }


            // Conferir se o arquivo existe:

            if(!File.Exists(PATH)){ // o local do arquivo vai estar dentro da Database
                File.Create(PATH).Close();
            }
        }

        public List<Product> Ler(){ // lista para ler as coisas do .csv

            List<Product> products = new List<Product>();
            string[] linhas = File.ReadAllLines(PATH); // todas as linhas do arquivo "Product.csv" vão ser lidas e transformadas em array


            foreach (var linha in linhas){ // vai ler linha(item) por linha dentro da string linhas(array)
                string[] dados = linha.Split(";"); // vai transformar todos os itens de dentro do array "linhas" e separa-los pelo ";"

                Product prods = new Product();
                prods.Code = int.Parse(dados[0]);
                prods.Name = dados[1];
                prods.Price = float.Parse(dados[2]);

                products.Add(prods);
            }

            return products;
        }

        public void Inserir(Product prod){ // vai inserir as linhas no formato do método de baixo
            
            // array de linhas para inserir no CSV
            string[] linhas = {PrepararLinhasCSV(prod)};

            // inserir linhas no arquivo
            File.AppendAllLines(PATH, linhas); // vai inserir (o AppendAllLines vai incrementar as linhas no CSV) no caminho (PATH) as informações do "linhas" (do método PrepararLinhasCSV)
        }
        public string PrepararLinhasCSV(Product prod){ // irá ser o formato no arquivo CSV linhas como se fosse as que foram colocadas manualmente (esse é será um sistema automático para o cliente cadastrar)
            System.Console.WriteLine("");
            return $"{prod.Code};{prod.Name};{prod.Price}";
        }
    }
}