using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SGNUTRI {
    public partial class Frm_Login : Form {
        public Frm_Login() {
            InitializeComponent();
            Txt_Senha.PasswordChar = '*';

        }



        private void Btn_Sair_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja realmente Sair?", "Mensagem Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }


        }

        private void Txt_Senha_TextChanged(object sender, EventArgs e) {

        }

        private void Txt_Usuario_TextChanged(object sender, EventArgs e) {

        }

        private void Btn_Entrar_Click(object sender, EventArgs e) {
            MySqlConnection conexaoBD = new MySqlConnection(Conect.strConect);
            conexaoBD.Open();
            MySqlCommand cmd = new MySqlCommand("select * from tbfuncionario where NOME= '" + Txt_Usuario.Text + "' and CARGO='" + Txt_Senha.Text + "'", conexaoBD);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                if (Txt_Usuario.Text == reader.GetString("NOME")) {


                    if (Txt_Senha.Text == reader.GetString("CARGO")) {
                        MessageBox.Show("Login realizado com sucesso");
                        Frm_Menu menu = new Frm_Menu();
                        menu.Show();
                    }
                    else {
                        MessageBox.Show("Login invalido");
                    }
                }
            }

            conexaoBD.Close();
        }

        private void Progress_Login_Click(object sender, EventArgs e) {

        }

        private void Frm_Login_Load(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void Lbl_Usuario_Click(object sender, EventArgs e) {

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        
        private void pictureBox3_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja realmente Sair?", "Mensagem Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja realmente Sair?", "Mensagem Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }

        }
    }
}




