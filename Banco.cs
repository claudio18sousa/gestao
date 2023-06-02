using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Gestao
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        //Funções genéricas



        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source ="+Globais.caminhoBanco+Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }
        public static DataTable dql(string sql)//Data query linguage
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try

            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.ToString());
                throw;
            }

        }






        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand(); 
                
                    cmd.CommandText = "Select* from usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                
            }catch(Exception ex)
            {
                MessageBox.Show("Erro "+ex.ToString());
                throw;
            }
            
        }
        public static void dml(string sql, string msgOK=null,string msgERRO=null)//Data Manipulation Linguage (Insert, Delete, Update)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgERRO != null)
                {
                    MessageBox.Show(msgOK);
                }

            }
            catch (Exception ex)
            {
                if (msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                MessageBox.Show("Erro " + ex.ToString());
                throw;
            }


        }


        ///Funções do form Gestao

        public static DataTable ObterUsuariosIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "Select id as 'ID USUÁRIOS', nome as 'NOME DOS USUÁRIOS' from usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.ToString());
                throw;
            }

        }
        public static DataTable ObterDadosUsuarios(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "Select *FROM usuarios where id="+id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.ToString());
                throw;
            }

        }
        public static  void AtualizarUsuario(Usuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "UPDATE usuarios SET nome ='"+u.nome+"', username='"+u.username+"',senha='"+u.senha+"',status='"+u.status+"',nivel="+u.nivel+"  WHERE id="+u.id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
           

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.ToString());
                throw;
            }

        }
        //Botão excluir elemento da base de dados
        public static void Exluir(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText =  " delete  from usuarios  WHERE id=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.ToString());
                throw;
            }

        }


        //Fim
        ///Funções do form do usuario


        public static void NovoUsuario(Usuario u)
        {
            if (existeUsername(u)==true)
            {
                MessageBox.Show("Username já existe");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO usuarios (nome, username, senha, status,nivel) values (@nome, @username,@senha,@status,@nivel)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Usuário cadastrado com sucesso");
                vcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuário");
                
            }
        }

    
        /// fim das funções
       
        /// Rotinas Gerais
        
        public static bool existeUsername(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT username from usuarios where username='" + u.username + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt); 

            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }


    }
}
