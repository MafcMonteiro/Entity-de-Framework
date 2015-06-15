using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OficinaEF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private OficinaEntities ctx = new OficinaEntities();

        private void listarTodosVeiculosPorClienteButton_Click(object sender, EventArgs e)
        {
            dadosListBox.Items.Clear();

            try
            {
                var listaClientes = from c in ctx.Cliente
                                    orderby c.Nome_cli
                                    select c;

                //foreach (var c in ctx.Cliente.OrderBy(cli => cli.Nome_cli))
                //foreach (var c in ctx.Cliente) 
                foreach (var c in listaClientes)
                {
                    dadosListBox.Items.Add(string.Format("CÓD: {0} - {1}",
                                                    c.Codigo_cli,
                                                    c.Nome_cli));

                    dadosListBox.Items.Add(new string('-', 30));

                    foreach (var v in c.Veiculo)
                    {
                        dadosListBox.Items.Add(string.Format("\t{0} - {1}",
                                                        v.Placa_vei,
                                                        v.Modelo_vei));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void veiculosDoClienteButton_Click(object sender, EventArgs e)
        {
            if (codigoLabel.Text == "")
            {
                MessageBox.Show("Pesquise por um cliente ANTES de listar veículos!");
                return;
            }

            dadosListBox.Items.Clear();

            try
            {
                var codigo = Convert.ToInt32(codigoLabel.Text);

                var cliente = ctx.Cliente.Where(c => c.Codigo_cli == codigo)
                    .SingleOrDefault();

                if (cliente == null)
                {
                    MessageBox.Show("Cliente não localizado!");
                    return;
                }

                dadosListBox.Items.Add(string.Format("CÓD: {0} - {1}",
                                                cliente.Codigo_cli,
                                                cliente.Nome_cli));
                if (cliente.Veiculo.Count() == 0)
                {
                    dadosListBox.Items.Add("**** CLIENTE SEM VEÍCULOS! ***");
                }

                foreach (var v in cliente.Veiculo)
                {
                    dadosListBox.Items.Add(string.Format("\t{0} - {1}",
                                                v.Placa_vei, v.Modelo_vei));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pesquisarPorCodigoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var codigo = Convert.ToInt32(codigoTextBox.Text);

                //var cliente = (from c in ctx.Cliente
                //               where c.Codigo_cli == codigo
                //               select c).SingleOrDefault();

                //var clientes = ctx.Cliente.Where(c => c.Codigo_cli == codigo).ToList()[0];  // POC!!!!
                var cliente = ctx.Cliente.Where(c => c.Codigo_cli == codigo).SingleOrDefault();

                if (cliente == null)
                {
                    MessageBox.Show("Código não localizado!");
                    return;
                }

                codigoLabel.Text = cliente.Codigo_cli.ToString();
                nomeTextBox.Text = cliente.Nome_cli;
                emailTextBox.Text = cliente.Email_cli;
                nascimentoTextBox.Text = cliente.Nascimento_cli.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            try
            {
                //ctx.Cliente.Add(new Cliente
                //                {
                //                    Nome_cli = nomeTextBox.Text,
                //                    Email_cli = emailTextBox.Text,
                //                    Nascimento_cli = Convert.ToDateTime(nascimentoTextBox.Text)
                //                });
                var novoCliente = new Cliente
                {
                    Nome_cli = nomeTextBox.Text,
                    Email_cli = emailTextBox.Text,
                    Nascimento_cli = Convert.ToDateTime(nascimentoTextBox.Text)
                };

                ctx.Cliente.Add(novoCliente);
                ctx.SaveChanges();
                codigoLabel.Text = novoCliente.Codigo_cli.ToString();
                MessageBox.Show("Cliente cadastrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void atualizarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoLabel.Text == "")
                {
                    MessageBox.Show("Pesquise por um cliente ANTES de alterar!");
                    return;
                }
                var codigo = Convert.ToInt32(codigoLabel.Text);
                var clienteExistente = ctx.Cliente
                                        .Where(c => c.Codigo_cli == codigo)
                                            .SingleOrDefault();

                clienteExistente.Nome_cli = nomeTextBox.Text;
                clienteExistente.Email_cli = emailTextBox.Text;
                clienteExistente.Nascimento_cli =
                                    Convert.ToDateTime(nascimentoTextBox.Text);

                ctx.SaveChanges();
                MessageBox.Show("Cliente alterado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoLabel.Text == "")
                {
                    MessageBox.Show("Pesquise por um cliente ANTES de excluir!");
                    return;
                }

                var codigo = Convert.ToInt32(codigoLabel.Text);
                var clienteExistente = ctx.Cliente
                                        .Where(c => c.Codigo_cli == codigo)
                                            .SingleOrDefault();
                ctx.Cliente.Remove(clienteExistente);
                ctx.SaveChanges();
                MessageBox.Show("Cliente excluído!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


