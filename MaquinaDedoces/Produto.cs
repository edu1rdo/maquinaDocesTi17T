using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
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
            ModificarDataValidade = dtValidade;
            ModificarSituacao = situacao;




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


        public double Modificarpreco
        {
            get { return preco; }
            set { preco = value; }



        }


        public int ModificarQuantidade
        {
            get { return this.quantidade; }
            set { this.quantidade = value; }


        }


        public int modificarDataValidade
        {
            get { return this.modificarDataValidade; }
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
            modificarcodigo = codigo;

            ModificarDescricao = descricao;
            Modificarpreco = preco;
            ModificarQuantidade = quantidade;
            ModificarDataValidade = dtValidade;
            ModificarSituacao = situacao;

        }//fim do metodo cadastrarprodutos


        //consultar produto
        public string ConsultarProduto(int codigo)
        {

            string msg = "";//criando uma variavel local
            if (modificarcodigo == codigo)
            {

                msg = "codigo: " + modificarcodigo +
                    "/nNome: " + modificarNome +
                    "/nNdescricao: " + ModificarDescricao +
                   "/nPreco: " + modificarpreco +
                    "/nQuantidade: "modificarQuantidade +
                    "/nData de validade: "  modificardtvalidade +
                    "/nSituacao: "  modificarSituacao;
                {
            else
                    {
                        msg = " o codigo digitado nao existe!";

                    }
                    return msg;
                }//fim do metodo



                public AtualizarProduto(int codigo, string campo, string
               {
                    if (modificarcodigo == codigo)
                    {
                        switch (campo)
                        {
                            case 1:
                                modificarnome = novoDado;
                                break;

                            case 2:
                                ModificarDescricao = NovoDado;
                                break;
                            case 3:
                                Modificarpreco = Convert.ToDouble(novoDado);
                                break;

                            case 4:
                                ModificarQuantidade = Convert.ToInt32(novoDado);
                                break;
                            case 5
                                modificarValidade = Convert.ToDateTime(novoDado);
                                break;
                            case 6
                                modificarSituacao = Convert.ToBoolean(novoDado);
                                break;
                            default:
                                break;



                        }//fim escolha
                        return flag;



                    }//fim do atualizarProduto


                    public void desativarProduto(int codigo)

                    {
                        Boolean flag = false;
                        if (modificarcodigo == codigo)
                        {
                            if (modificarSituacao == true)
                            {
                                modificarSituacao = false;


                            }
                            else
                            {
                                Modificacao = true;
                            }//fim do modificarSituacao
                            flag = true;


                        }



                    }//fim do desativar codigo

                    //solicitar produtos
                    public Boolean SolicitarProduto()
                    {
                       if (modificarcodigo == codigo)
                        { 
                               
                        
                        if(ModificarQuantidade <= 3)
                        {
                            return false;


                        }// fim do if

                    }//fim do solicitar produto

            


    }// fim da classe 
}// fim do projeto
