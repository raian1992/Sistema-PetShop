using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetshop_2._0
{
    public partial class FormAgenda : Form
    {
        public FormAgenda()
        {
            InitializeComponent();
        }

        private void buscarcompromisso()
        {
            List<Compromissos> compdata = ClassCompromissos.Listar();
            foreach (Compromissos lista in compdata)
            {
                Calendario.AnnuallyBoldedDates = new DateTime[] { (DateTime)lista.Data };
            }
            List<Compromissos> compromissos = ClassCompromissos.Listar(Calendario.SelectionRange.Start);

            CompromissosDoDia.Items.Clear();

            foreach (Compromissos lista in compromissos)
            {
                ListViewItem item = new ListViewItem();

                item.Text = lista.Id.ToString();
                item.SubItems.Add(lista.Hora.ToString());
                item.SubItems.Add(lista.Descricao.ToUpper());
                item.SubItems.Add(lista.Concluido.ToString());

                if (lista.Data == DateTime.Now.Date && lista.Hora < DateTime.Now.TimeOfDay && lista.Concluido == false)
                {
                    item.BackColor = Color.Red;
                }
                if (lista.Data != DateTime.Now.Date && lista.Concluido == false)
                {
                    item.BackColor = Color.Purple;
                }
                if (lista.Hora < DateTime.Now.TimeOfDay && lista.Concluido == true && lista.Data == DateTime.Now)
                {
                    item.BackColor = Color.Green;
                }
                if (lista.Concluido == true && lista.Data != DateTime.Now)
                {
                    item.BackColor = Color.Green;
                }
                if (lista.Hora > DateTime.Now.TimeOfDay && lista.Concluido == true && lista.Data == DateTime.Now)
                {
                    item.BackColor = Color.Yellow;
                }

                CompromissosDoDia.Items.Add(item);
            }
        }
        private void btnconcluir_Click(object sender, EventArgs e)
        {

            if (CompromissosDoDia.SelectedItems.Count != 0)
            {
                int ID = Convert.ToInt32(CompromissosDoDia.FocusedItem.SubItems[0].Text);
                try
                {
                    if (CompromissosDoDia.SelectedItems[0].Selected && CompromissosDoDia.FocusedItem.SubItems[3].Text == "False")
                    {


                        ClassCompromissos.ConcluirCompromisso(ID);

                        MessageBox.Show("Compromisso concluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (CompromissosDoDia.SelectedItems[0].Selected && CompromissosDoDia.FocusedItem.SubItems[3].Text == "True")
                    {
                        MessageBox.Show("Compromisso ja concluido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {


                }
                buscarcompromisso();
            }
        }

        private void bneditarcompromisso_Click(object sender, EventArgs e)
        {

            if (CompromissosDoDia.SelectedItems.Count != 0)
            {
                int ID = Convert.ToInt32(CompromissosDoDia.FocusedItem.SubItems[0].Text);

                if (CompromissosDoDia.SelectedItems[0].Selected)
                {
                    string data = Calendario.SelectionRange.Start.ToString();
                    string hora = CompromissosDoDia.FocusedItem.SubItems[1].Text;
                    string descricao = CompromissosDoDia.FocusedItem.SubItems[2].Text;
                    bool concluido = Convert.ToBoolean(CompromissosDoDia.FocusedItem.SubItems[3].Text);
                    FormCompromissos formcomp = new FormCompromissos();
                    formcomp.carregadados(ID, data, hora, descricao, concluido);
                    formcomp.ShowDialog();
                    buscarcompromisso();
                }
            }
        }

        private void NovoCompromisso_Click(object sender, EventArgs e)
        {
            relogio.Enabled = false;

            FormCompromissos frmCompromisso = new FormCompromissos();
            frmCompromisso.ShowDialog();

            relogio.Enabled = true;

            Calendario_DateChanged(sender, null);
        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            buscarcompromisso();
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            ClassCompromissos.VerificaCompromissos();
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            Calendario_DateChanged(sender, null);
        }
        private void frmAgenda_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                //icone.Visible = true;
            }
        }
    }
}
