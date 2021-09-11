using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Meztli
{
    public class Part
    {
        public string number { get; set; }
        public string name { get; set; }

        public Part(string number, string name)
        {
            this.number = number;
            this.name = name;
        }
    }

    public class CollectionHandler
    {
        public Part FindPart(string number)
        {
            OleDbConnection con;
            OleDbCommand cmd;
            OleDbDataReader dr;

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=meztlidb.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Part WHERE number='"+ number + "'";
            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                Part part = new Part(dr["number"].ToString(), dr["name"].ToString());
                con.Close();
                return part;
            }
            return null;
        }
    }
}
