using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SGNUTRI
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            Txt_Senha.PasswordChar = '*';
            
        }



        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexaoBD = new MySqlConnection(Conect.strConect);
            conexaoBD.Open();
            MySqlCommand cmd = new MySqlCommand("select * from tbfuncionario where NOME= '" + Txt_Usuario.Text + "' and CARGO='" + Txt_Senha.Text + "'", conexaoBD);
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                if (Txt_Usuario.Text == reader.GetString("NOME"))
                {
                    if(Txt_Senha.Text == reader.GetString("CARGO"))
                    {
                        MessageBox.Show("Login realizado com sucesso");
                        Frm_Menu menu = new Frm_Menu();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login invalido");
                    }
                }
            }

            conexaoBD.Close();
        }

        private void Progress_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
