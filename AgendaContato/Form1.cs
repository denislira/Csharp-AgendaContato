using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgendaContato
{
    public partial class Form1 : Form
    {

        //Variáveis e conexão

        const string connLocal = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Denis André\C# Sharp\BANCOS\CONTATO.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

       string nome, telefone, celular, descricao, Vsql;
       int cod;

       SqlConnection connSQL = null;
       SqlCommand commSQL = null;

        //MOVER JANELA
       int X = 0;
       int Y = 0;
        // ---

        public Form1()
        {
            InitializeComponent(); 
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            bt_normal.Visible = false;
            pnl_inserir.Dock = DockStyle.Fill;
           
        }
        //MOVER JANELA
        private void Form1_MouseDown(object sender, MouseEventArgs e)
           {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
           }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
          {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
          }
        //FIM MOVER

        //Métodos
        public void Inserir()
        {
            connSQL = new SqlConnection(connLocal);
            commSQL = new SqlCommand();

            try
            {
                nome = tb_nome.Text;
                telefone = mtb_tel.Text;
                celular = mtb_cel.Text;
                descricao = tb_desc.Text;

                Vsql = "INSERT INTO CONTATO (NOME, TELEFONE, CELULAR, DESCRICAO) VALUES('" +
                        nome + "','" + telefone + "','" + celular + "','" + descricao + "')";

                commSQL.CommandText = Vsql;
                commSQL.Connection = connSQL;
                connSQL.Open();
                commSQL.ExecuteNonQuery();
                connSQL.Close();
                MessageBox.Show("Cadastrado com Sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show(e + "\n" + "Erro ao cadastrar");
            }


        }

        public void Editar()
        {
            connSQL = new SqlConnection(connLocal);
            commSQL = new SqlCommand();

            try
            {
                cod = int.Parse(tb_cod_editar.Text);
                nome = tb_nome_editar.Text;
                telefone = mtb_tel_editar.Text;
                celular = mtb_cel_editar.Text;
                descricao = tb_desc_editar.Text;

                Vsql = "UPDATE CONTATO SET NOME      ='" + nome + "'," +
                                          "TELEFONE  ='" + telefone + "'," +
                                          "CELULAR   ='" + celular + "'," +
                                          "DESCRICAO ='" + descricao + "' WHERE ID =" + cod;

                commSQL.CommandText = Vsql;
                commSQL.Connection = connSQL;
                connSQL.Open();
                commSQL.ExecuteNonQuery();
                connSQL.Close();
                MessageBox.Show("Editado com Sucesso!");
            }
            catch (SqlException e)
            {
                MessageBox.Show(e + "\n" + "Erro ao Editar");
            }
        }

        public void Excluir()
        {
            connSQL = new SqlConnection(connLocal);
            commSQL = new SqlCommand();

            try
            {

                cod = int.Parse(tb_cod_excluir.Text);

                Vsql = "DELETE FROM CONTATO WHERE ID = " + cod;


            }
            catch (SqlException e)
            {
                MessageBox.Show(e + "  Erro ao Excluir");
            }

            commSQL.CommandText = Vsql;
            commSQL.Connection = connSQL;
            connSQL.Open();
            commSQL.ExecuteNonQuery();
            connSQL.Close();

            MessageBox.Show("Excluido com Sucesso!");
        }

        public void Sair()
        {
            if (MessageBox.Show("Deseja Sair da Agenda?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }

        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {
            Inserir();
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void tsb_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair da Agenda?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Sair();
            }
        }

        private void tsb_excluir_Click(object sender, EventArgs e)
        {
            pnl_deletar.Visible = true;
            pnl_deletar.Dock = DockStyle.Fill;

            pnl_inserir.Visible = false;
            pnl_editar.Visible = false;

        }

        private void tsb_editar_Click(object sender, EventArgs e)
        {
            pnl_editar.Visible = true;
            pnl_editar.Dock = DockStyle.Fill;

            pnl_inserir.Visible = false;
            pnl_deletar.Visible = false;
        }

        private void tsb_inserir_Click(object sender, EventArgs e)
        {
            pnl_inserir.Visible = true;
            pnl_inserir.Dock = DockStyle.Fill;

            pnl_deletar.Visible = false;
            pnl_editar.Visible = false;
        }

        private void bt_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void bt_maximizar_Click(object sender, EventArgs e)
        {
            bt_normal.Visible = true;
            bt_maximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;

        }

        private void bt_normal_Click(object sender, EventArgs e)
        {
            bt_maximizar.Visible = true;
            bt_normal.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
        }


    }//fim
}
