using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPetshop_2._0.Adicionais
{
    class ClassPermissoes
    {
        //Liberações Feita na Configuração do sistema
        public static bool Mov_estoque { get; set; }
        public static bool Utiliza_financeiro { get; set; }
        public static bool Valida_cpf { get; set; }
        public static bool Banho_tosa { get; set; }
        public static bool Menu_venda { get; set; }

    }
    class Class_usuarios
    {
        public int Id_usuario { get; set; }
        public int Id_perfil { get; set; }
    }
    class Permissoes_grupo
    {

    }
}
