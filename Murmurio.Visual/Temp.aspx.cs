using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Text;
using System.Collections;

namespace Murmurio.Visual
{
    public partial class Temp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string teste;
            teste = "ola";
            string.Format("Error: {0}",teste);

           //Declarar e abrir a conexão;
            System.Data.OleDb.OleDbConnection Con = new System.Data.OleDb.OleDbConnection();
            Con.ConnectionString = @"aiusdfhoausdhofiahsdpifhaosdifha";
            Con.Open();

            OleDbCommand comando = new OleDbCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from tbUsuario";
            comando.Connection = Con;

            OleDbDataReader DR;
            DR = comando.ExecuteReader();
            if (DR.HasRows)
            {
                DR.Read();
                teste = Convert.ToString(DR[""]);
            }

            //----------------------------------------------------------------------------------------------

            decimal valor = 10;

            decimal[] valor2 = new decimal[20];
            valor2[0] = 10M;

            //------------------------------------
            //Sistema de arquivos

            System.IO.DriveInfo di = new System.IO.DriveInfo(@"c:/");
            teste = string(di.AvailableFreeSpace);
            System.IO.Directory dir;
            string[]ld = System.IO.Directory.GetLogicalDrives();
            foreach(string lista in ld)
            {
                teste += 1 + lista;
            }
            //---------------------------------------------------------------------------------------
            //Arquivos sequenciais

            System.IO.StreamReader vleitor = new System.IO.StreamReader("c:\caminho...");
            teste = vleitor.ReadToEnd();


            //------------------------------------
            DateTime dd ;
            dd = DateTime.Now;

            
            string nome, sobrenome;

            nome = "tiago";
            sobrenome = "Lima";

            string nomeCompleto;

            nomeCompleto = string.Concat(nome, " ",sobrenome);

            nomeCompleto = string.Format("{0} {1}", nome, sobrenome);

            
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1}", nome, sobrenome);

            nome = nome.Substring(0,4);

            sobrenome += sobrenome.Split(',');

            //--------------------------------------------------------------------

            string[,] array = new string[20,2];
            array[1,1] = "tiago";
            array[2,1] = "Lima";
            //------------------------------

            ArrayList nota = new ArrayList();

            nota.Add(10);
            nota.Add("t");
            nota.Contains(10);
            Queue lanches = new Queue();
            lanches.Enqueue("jose");


           


            //--------------------------------------------------------

            List<string> lista1 = coleção();
            var uf = from a in lista1
                     orderby a
                     select a;
          
        }



        public class Cliente
        {
            private string nome;

            public string Nome
            {
                get{ return nome;}
                set{nome = value;}
            }

            public Cliente(string Cnome)
            {
                nome = Cnome;
            }




        }

    }


    //Response.Redirect("../usuario.aspx");
    //textbox1.text = GridView1.SelectedRow.Cells[2].Text;






}