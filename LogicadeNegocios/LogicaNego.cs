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

        public Boolean InsertarCliente(Cliente Clien, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[5];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "namejson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = Clien.name
            };
            datos[1] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "ApPjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = Clien.ApP
            };
            datos[2] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "ApMjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = Clien.ApM
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "celjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = Clien.Cel
            };
            datos[4] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "correojson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = Clien.Correo
            };

            string sentence = "insert into Cliente values(@namejson,@ApPjson,@ApMjson,@celjson,@correojson);";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }

        public Boolean InsertarEntrePed(EntregaPedido EP, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[5];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "FPedjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = EP.F_pedido
            };
            datos[1] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "FPedjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = EP.F_repartidor
            };
            datos[2] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Salidajson",
                SqlDbType = SqlDbType.DateTime,
                Direction = ParameterDirection.Input,
                Value = EP.Salida
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Entrejson",
                SqlDbType = SqlDbType.DateTime,
                Direction = ParameterDirection.Input,
                Value = EP.Entregado
            };
            datos[4] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "estadojson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = EP.Estado
            };

            string sentence = "insert into Cliente values(@FPedjson,@FPedjson,@Salidajson,@Entrejson,@estadojson);";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }

        public Boolean InsertarPedido(Pedido ped, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[5];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Fechjson",
                SqlDbType = SqlDbType.DateTime,
                Direction = ParameterDirection.Input,
                Value = ped.FechaHra
            };
            datos[1] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "FClienjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = ped.F_cliente
            };
            datos[2] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "FCarnjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = ped.F_Carnicero
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Enviojson",
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Input,
                Value = ped.Envio
            };
            datos[4] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Pagojson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = ped.Pago
            };

            string sentence = "insert into Cliente values(@Fechjson,@FClienjson,@FCarnjson,@Enviojson,@Pagojson);";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }

        public Boolean InsertarProducto(Producto prod, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[6];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Fechjson",
                SqlDbType = SqlDbType.DateTime,
                Direction = ParameterDirection.Input,
                Value = prod.nameP
            };
            datos[1] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "FClienjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = prod.Peso
            };
            datos[2] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "FCarnjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = prod.Cantidad
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Enviojson",
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Input,
                Value = prod.PrecioF
            };
            datos[4] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Pagojson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = prod.Nota
            };
            datos[5] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Pagojson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = prod.f_pedido
            };

            string sentence = "insert into Producto values(@Fechjson,@FClienjson,@FCarnjson,@Enviojson,@Pagojson);";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }
    }// fin de logica de negocio
}// fin de namespace
