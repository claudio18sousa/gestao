using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao
{
    internal class Globais
    {
       public static string versao="1.0";
        public static Boolean logado=false;
       public static int nivel=0;//nivel 1:Usuário básico; Nivel 2:Gerente; Nivel 3:Administrador
        public static string caminho=System.Environment.CurrentDirectory;
        public static string nomeBanco = "base_dados.db";
        public static string caminhoBanco = caminho+ @"\Base_dados\";
        /*
         
       nome
        username
        senha
        status
        nivel
         */

    }
}
