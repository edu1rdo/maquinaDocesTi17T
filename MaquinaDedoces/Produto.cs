using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDedoces
{
    class Produto
    {
        // definição de variaveis
        private int codigo;
        private string nome;
        private string descricao;
        private double preco;
        private int quantidade;
        private DateTime dtValidade;
        private Boolean situacao;

        //metodo construtor 
        public Produto()
        {
            codigo = 0;
            nome = "";
            descricao = "";
            preco = 0;
            quantidade = 0;
            dtValidade = new DateTime();//0000/00/00 00:00:00
            situacao = false;

        } // fim do metodo constutor 

    
        public Produto(int codigo, string nome, string descricao, double preco,
            int quantidade, DateTime dtValidade, Boolean situacao)
        {
            ModificarCodigo = codigo;
            ModificarNome = nome;
            ModificarDescricao = descricao;
        ModificarDataValidade= dtValidade;
        ModificarSituacao  = situacao;
   
    }//fim do metodo construtor com parametro

    //metodos get set
    //metodo de acesso e modificacao
    public int modificarcodigo
        {
            get { return codigo; }
            set { codigo = value; }
               
           
            
      }//fim do get - retornar codigo

           
            
           
      
        
       public string MdificarNome
        {

            get { return nome; }    
            set { nome = value; }
             
        
        
       
        
        }
    
        
        public  double Modificarpreco
        {
            get { return preco; }   
            set { preco = value; }

            

        }
    
    
        public int ModificarQuantidade
        {
            get { return this.quantidade; }
            set { this.quantidade = value; }


        }


        public  int modificardtvalidade
        { 
            get { return this.dtValidade;}
            set { this.dtValidade = value; }
        
        
        
        
        }

        //metodo cadastrar produto
        public void CadastrarProduto(
            int codigo,
            string nome,
            string descricao,
            double preco,
            int quantidade,
            DateTime dtValidade,
            Boolean situacao
            
            )
        {
            modificarcodigo =codigo;
           
            ModificarDescricao = descricao;
            Modificarpreco = preco;
            ModificarQuantidade= quantidade;
            ModificarDataValidade = dtValidade;
            ModificarSituacao  = situacao;

        }//fim do metodo cadastrarprodutos


        //consultar produto
        public string ConsultarProduto(int codigo)
        {

            string msg = "";//criando uma variavel local
            if(modificarcodigo == codigo)
            {

                msg = "codigo: " + modificarcodigo +
                    "/nNome: " + modificarNome +
                    "/nNdescricao: " + ModificarDescricao +
                   "/nPreco: "+modificarpreco +
                    "/nQuantidade: "modificarQuantidade +
                    "/nData de validade: "  modificardtvalidade +
                    "/nSituacao: "  modificarSituacao;
            {  
            else
                    {
                        msg = " o codigo digitado nao existe!";

                    }
        }//fim do metodo






    }// fim da classe 
}// fim do projeto
