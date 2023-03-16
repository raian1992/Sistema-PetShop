using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetshop_2._0.Adicionais
{
    class ClassInfTemp
    {
        public static bool listveterinario;
        public static bool listempresa;
        public static bool listproprietario;
        public static bool listpet;
        //public static bool listcliente;

        public static bool bdconn=true;
        public static void control_open(string form)
        {
            switch (form)
            {
                case "LISTVET":
                    if (Application.OpenForms.OfType<FormListVet>().Count() > 0)
                    {
                        Application.OpenForms.OfType<FormListVet>().First().Focus();
                    }
                    else
                    {
                        FormListVet frmNomeDoForm = new FormListVet();
                        frmNomeDoForm.Show();
                    }
                    break;

                case "LISTEMPRESA":
                    if (Application.OpenForms.OfType<FormListEmpresa>().Count() > 0)
                    {
                        Application.OpenForms.OfType<FormListEmpresa>().First().Focus();
                    }
                    else
                    {
                        FormListEmpresa frmNomeDoForm = new FormListEmpresa();
                        frmNomeDoForm.Show();
                    }
                    break;

                case "LISTPROPRIETARIO":
                    if (Application.OpenForms.OfType<FormListProprietario>().Count() > 0)
                    {
                        Application.OpenForms.OfType<FormListProprietario>().First().Focus();
                    }
                    else
                    {
                        FormListProprietario frmNomeDoForm = new FormListProprietario();
                        frmNomeDoForm.Show();
                    }
                    break;

                case "LISTPET":
                    if (Application.OpenForms.OfType<FormListPet>().Count() > 0)
                    {
                        Application.OpenForms.OfType<FormListPet>().First().Focus();
                    }
                    else
                    {
                        FormListPet frmNomeDoForm = new FormListPet();
                        frmNomeDoForm.Show();
                    }
                    break;

                case "LISTSERVICO":
                    if (Application.OpenForms.OfType<FormListServico>().Count() > 0)
                    {
                        Application.OpenForms.OfType<FormListServico>().First().Focus();
                    }
                    else
                    {
                        FormListServico frmNomeDoForm = new FormListServico();
                        frmNomeDoForm.Show();
                    }
                    break;

                case "SOBRE":
                    if (Application.OpenForms.OfType<FormSobre>().Count() > 0)
                    {
                        Application.OpenForms.OfType<FormSobre>().First().Focus();
                    }
                    else
                    {
                        FormSobre frmNomeDoForm = new FormSobre();
                        frmNomeDoForm.Show();
                    }
                    break;

                case "LISTUSUARIO":
                    if (Application.OpenForms.OfType<FormListUsuario>().Count() > 0)
                    {
                        Application.OpenForms.OfType<FormListUsuario>().First().Focus();
                    }
                    else
                    {
                        FormListUsuario frmNomeDoForm = new FormListUsuario();
                        frmNomeDoForm.Show();
                    }
                    break;

                case "AGENDA":
                    if (Application.OpenForms.OfType<FormAgenda>().Count() > 0)
                    {
                        Application.OpenForms.OfType<FormAgenda>().First().Focus();
                    }
                    else
                    {
                        FormAgenda frmNomeDoForm = new FormAgenda();
                        frmNomeDoForm.Show();
                    }
                    break;

                case "LISTTAXAS":
                    if (Application.OpenForms.OfType<FormListTaxas>().Count() > 0)
                    {
                        Application.OpenForms.OfType<FormListTaxas>().First().Focus();
                    }
                    else
                    {
                        FormListTaxas frmNomeDoForm = new FormListTaxas();
                        frmNomeDoForm.Show();
                    }
                    break;

                case "LISTPAGAMENTO":
                    if (Application.OpenForms.OfType<FormListPagamento>().Count() > 0)
                    {
                        Application.OpenForms.OfType<FormListPagamento>().First().Focus();
                    }
                    else
                    {
                        FormListPagamento frmNomeDoForm = new FormListPagamento();
                        frmNomeDoForm.Show();
                    }
                    break;

                case "ATENDIMENTOVET":
                    if (Application.OpenForms.OfType<FormCadAtendimento>().Count() > 0)
                    {
                        Application.OpenForms.OfType<FormCadAtendimento>().First().Focus();
                    }
                    else
                    {
                        FormCadAtendimento frmNomeDoForm = new FormCadAtendimento();
                        frmNomeDoForm.Show();
                    }
                    break;
            }


        }
    }
}
