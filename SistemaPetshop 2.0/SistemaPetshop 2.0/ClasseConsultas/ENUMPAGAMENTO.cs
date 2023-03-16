using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPetshop_2._0
{
    public class TIPO_PAG
    {
        public int ID_PAG { get; set; }
        public string NOME_PAG { get; set; }
        public string DESCRICAO_PAG { get; set; }

    }

    class ENUMPAGAMENTO
    {
        public static List<TIPO_PAG> PAG = new List<TIPO_PAG>();

        public static void carregardadospag()
        {
            TIPO_PAG _PAG = new TIPO_PAG();

            //dinheiro
            _PAG.ID_PAG = 1;
            _PAG.NOME_PAG = "Dinheiro";
            _PAG.DESCRICAO_PAG = "Dinheiro";
            PAG.Add(_PAG);
            _PAG = new TIPO_PAG();

            //cheque
            _PAG.ID_PAG = 2;
            _PAG.NOME_PAG = "Cheque";
            _PAG.DESCRICAO_PAG = "Cheque";
            PAG.Add(_PAG);
            _PAG = new TIPO_PAG();

            //Cartão credito
            _PAG.ID_PAG = 3;
            _PAG.NOME_PAG = "Cartao de credito";
            _PAG.DESCRICAO_PAG = "Cartão de Credito";
            PAG.Add(_PAG);
            _PAG = new TIPO_PAG();

            //cartão debito
            _PAG.ID_PAG = 4;
            _PAG.NOME_PAG = "Cartao de debito";
            _PAG.DESCRICAO_PAG = "Cartão de Debito";
            PAG.Add(_PAG);
            _PAG = new TIPO_PAG();

            //Credito Loja
            _PAG.ID_PAG = 5;
            _PAG.NOME_PAG = "Credito Loja";
            _PAG.DESCRICAO_PAG = "Credito Loja";
            PAG.Add(_PAG);
            _PAG = new TIPO_PAG();

            //Vale alimentação
            _PAG.ID_PAG = 10;
            _PAG.NOME_PAG = "Vale Alimentacao";
            _PAG.DESCRICAO_PAG = "Vale Alimentação";
            PAG.Add(_PAG);
            _PAG = new TIPO_PAG();

            //Vale Refeição
            _PAG.ID_PAG = 11;
            _PAG.NOME_PAG = "Vale Refeição";
            _PAG.DESCRICAO_PAG = "Vale Refeição";
            PAG.Add(_PAG);
            _PAG = new TIPO_PAG();

            //Vale Presente
            _PAG.ID_PAG = 12;
            _PAG.NOME_PAG = "Vale Presente";
            _PAG.DESCRICAO_PAG = "Vale Presente";
            PAG.Add(_PAG);
            _PAG = new TIPO_PAG();

            //Vale Combustivel
            _PAG.ID_PAG = 13;
            _PAG.NOME_PAG = "Vale Combustivel";
            _PAG.DESCRICAO_PAG = "Vale Combustivel";
            PAG.Add(_PAG);
            _PAG = new TIPO_PAG();

            //Boleto Bancario
            _PAG.ID_PAG = 15;
            _PAG.NOME_PAG = "Boleto Bancario";
            _PAG.DESCRICAO_PAG = "Boleto Bancario";
            PAG.Add(_PAG);
            _PAG = new TIPO_PAG();

            //Sem Pagamento
            _PAG.ID_PAG = 90;
            _PAG.NOME_PAG = "Sem Pagamento";
            _PAG.DESCRICAO_PAG = "Sem Pagamento";
            PAG.Add(_PAG);
            _PAG = new TIPO_PAG();

            //Outros
            _PAG.ID_PAG = 99;
            _PAG.NOME_PAG = "Outros";
            _PAG.DESCRICAO_PAG = "Outros";
            PAG.Add(_PAG);
            _PAG = new TIPO_PAG();

        }

        public string tipo_pagamento(int codigo)
        {
            string retorno = "";
            switch (codigo)
            {
                case 01:
                    retorno = "Dinheiro";
                    break;
                case 02:
                    retorno = "Cheque";
                    break;
                case 03:
                    retorno = "Cartão de Credito";
                    break;
                case 04:
                    retorno = "Cartão de Debito";
                    break;
                case 05:
                    retorno = "Credito Loja";
                    break;
                case 10:
                    retorno = "Vale Alimentação";
                    break;
                case 11:
                    retorno = "Vale Refeição";
                    break;
                case 12:
                    retorno = "Vale Presente";
                    break;
                case 13:
                    retorno = "Vale Combustivel";
                    break;
                case 15:
                    retorno = "Boleto Bancario";
                    break;
                case 90:
                    retorno = "Sem Pagamento";
                    break;
                case 99:
                    retorno = "Outros";
                    break;
                default:
                    retorno = "";
                    break;
            }
            return retorno;
        }
    }
}
