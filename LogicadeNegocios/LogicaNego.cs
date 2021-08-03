using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AccessData;
using Entidades;

namespace LogicadeNegocios
{
    public class LogicaNego
    {
        AccesoaDatos accesdataline = new AccesoaDatos(@"Data Source=DESKTOP-J97AN1I\SQLEXPRESS; Initial Catalog=PedidosCarniceria; Integrated Security = true;");


        public Boolean InsertarCarnicero(Carnicero nuev, ref string smsexit) 
        {

            SqlParameter[] datos = new SqlParameter[4];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "namejson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = nuev.name
            };
            datos[1] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "celjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = nuev.cel
            };
            datos[2] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "emailjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = nuev.email
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "expjson",
                SqlDbType = SqlDbType.SmallInt,
                Direction = ParameterDirection.Input,
                Value = nuev.exp
            };

            string sentence = "insert into Carnicero values(@namejson,@celjson,@emailjson,@expjson);";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }

    }// fin de logica de negocio
}// fin de namespace
