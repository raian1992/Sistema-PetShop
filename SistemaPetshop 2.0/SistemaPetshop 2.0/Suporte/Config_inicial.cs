using SistemaPetshop_2._0.Suporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPetshop_2._0
{
    class Config_inicial
    {
        public static void tipo_maquina(int tipo_maq)
        {
            if (tipo_maq == 1)
            {
                Properties.Settings PRP = new Properties.Settings();
                PRP.TIPO_MAQ = "SERVER";
                PRP.Save();
            }
            if (tipo_maq == 2)
            {
                Properties.Settings PRP = new Properties.Settings();
                PRP.TIPO_MAQ = "ESTACAO";
                PRP.Save();
            }



        }

        public static void Criar_config_inicial()
        {
            using (var bd = new LOJA_PETEntities())
            {
                int id = bd.CONFIG.Count();
                if (id == 0)
                {
                    CONFIG config = new CONFIG();
                    config.AT_CHV = 0;
                    config.AT_ESTQ = false;
                    config.DT_INST = DateTime.Now.Date;
                    config.DT_VAL = DateTime.Now.AddDays(15).Date;
                    config.MOV_ESTOQUE = false;
                    config.UT_FIN = false;
                    config.UT_VENDA = true;
                    config.ATIVO = true;
                    bd.CONFIG.Add(config);
                    bd.SaveChanges();
                }

                id = bd.EMPRESA.Count();
                if (id == 0)
                {
                    EMPRESA estab = new EMPRESA();
                    estab.RAZAO_SOCIAL = "EMPRESA TESTE";
                    estab.FANTASIA = "EMPRESA TESTE";
                    estab.CNPJ_CPF = "00000000000";
                    estab.IE_RG = "ISENTO";
                    estab.CEP = "00000000";
                    estab.ENDERECO = "RUA TESTE";
                    estab.NUMERO = "0";
                    estab.COMPLEMENTO = "";
                    estab.BAIRRO = "CENTRO";
                    estab.CIDADE = "CACHOEIRO DE ITAPEMIRIM";
                    estab.ESTADO = "ES";
                    estab.PAIS = "BRASIL";
                    estab.TELEFONE = "0000000000000";
                    estab.CELULAR = "0000000000000";
                    estab.EMAIL = "NAO@TEM.COM.BR";
                    estab.Tipo_juros = "D";
                    estab.Cobr_juros = "S";
                    estab.P_juros = Convert.ToDecimal(0.00);
                    estab.P_MULTA = Convert.ToDecimal(0.00);
                    estab.CHV = ClassSerial.GerarSerialTrial();//CRIAR UM VINCULO DE CHAVE PELO COMPUTADOR DO SERVIDOR(APOS ISSO VALIDADR A DATA)
                    estab.ID_CONFIG = bd.CONFIG.Min(x => x.ID_CONFIG);
                    estab.ATIVO = true;
                    Conversão.conv_tipo_empresa_Numero("MATRIZ");
                    estab.TIPO_EMPRESA = Conversão.tipo_empresa;
                    tipo_maquina(1);
                    bd.EMPRESA.Add(estab);
                    bd.SaveChanges();
                }


                id = bd.PERFIL.Count();
                if (id == 0)
                {
                    PERFIL perfil = new PERFIL();
                    perfil.DESCRICAO = "ADMINISTRADOR";
                    bd.PERFIL.Add(perfil);

                    bd.SaveChanges();
                }

                id = bd.USUARIOS.Count();
                if (id == 0)
                {
                    USUARIOS user = new USUARIOS();
                    user.lOGIN = "ADMIN";
                    user.NOME = "ADMINISTRADOR";
                    user.SENHA = ClassCript.criptografarSenha("ADMIN");
                    user.CONTRA_SENHA = ClassCript.criptografarSenha("SENHA_ADMIN");
                    user.Email = "suporte@email.com";
                    user.ID_PERFIL = bd.PERFIL.Min(x => x.ID_PERFIL);
                    user.ATIVO = true;
                    bd.USUARIOS.Add(user);
                    bd.SaveChanges();
                }
                id = bd.EMPRESA_USUARIO.Count();
                if (id == 0)
                {
                    EMPRESA_USUARIO rel = new EMPRESA_USUARIO();
                    rel.ID_EMPRESA = bd.EMPRESA.Min(x => x.ID_EMPRESA);
                    rel.ID_USUARIO = bd.USUARIOS.Min(x => x.Id_USUARIO);
                    bd.EMPRESA_USUARIO.Add(rel);
                    bd.SaveChanges();
                }

            }
        }

    }
}
