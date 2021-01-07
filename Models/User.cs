using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }
        private const string PATH = "Database/User.csv";
        public User(){
            string pasta = PATH.Split("/")[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }

        public List<User> Ler(){

            List<User> users = new List<User>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach(var item in linhas){
                string[] dados = item.Split(";");

                User us = new User();
                us.Name = dados[0];
                us.Email = dados[1];
                us.CPF = int.Parse(dados[2]);
                
                users.Add(us);
            }
            return users;
        }

        public void Inserir(User usuario){ // vai inserir as linhas no formato do método de baixo
            
            // array de linhas para inserir no CSV
            string[] linhas = {PrepararLinhasCSV(usuario)};

            // inserir linhas no arquivo
            File.AppendAllLines(PATH, linhas); // vai inserir (o AppendAllLines vai incrementar as linhas no CSV) no caminho (PATH) as informações do "linhas" (do método PrepararLinhasCSV)
        }
        public string PrepararLinhasCSV(User usuario){ // irá ser o formato no arquivo CSV linhas como se fosse as que foram colocadas manualmente (esse é será um sistema automático para o cliente cadastrar)
            System.Console.WriteLine("");
            return $"{usuario.Name};{usuario.Email};{usuario.CPF}";
        }
    }
}