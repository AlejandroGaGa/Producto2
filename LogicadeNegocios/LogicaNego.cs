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

            string sentence = "insert into EntregaPedido values(@FPedjson,@FPedjson,@Salidajson,@Entrejson,@estadojson);";

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

            string sentence = "insert into Pedido values(@Fechjson,@FClienjson,@FCarnjson,@Enviojson,@Pagojson);";

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
                ParameterName = "NamePjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = prod.nameP
            };
            datos[1] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Pesojson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = prod.Peso
            };
            datos[2] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Cantjson",
                SqlDbType = SqlDbType.SmallInt,
                Direction = ParameterDirection.Input,
                Value = prod.Cantidad
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "PrecioFjson",
                SqlDbType = SqlDbType.Float,
                Direction = ParameterDirection.Input,
                Value = prod.PrecioF
            };
            datos[4] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Notajson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = prod.Nota
            };
            datos[5] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "FPedjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = prod.f_pedido
            };

            string sentence = "insert into Producto values(@NamePjson,@Pesojson,@Cantjson,@PrecioFjson,@Notajson,@FPedjson);";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }


        public Boolean InsertarRepartidor(Repartidor rep, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[3];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "NamePjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = rep.name
            };
            datos[1] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Celjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = rep.cel
            };
            datos[2] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Licenjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = rep.Licencia
            };
            

            string sentence = "insert into Repartidor values(@NamePjson,@Celjson,@Licenjson);";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }


        public Boolean InsertarUbicacion(Ubicacion ubi, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[8];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "ColoniaPjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = ubi.colonia
            };
            datos[1] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "CalNumjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = ubi.calleNum
            };
            datos[2] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Munjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = ubi.Municipio
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Ciudjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = ubi.Ciudad
            };
            datos[4] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Refjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = ubi.reference
            };
            datos[5] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Caracjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = ubi.Carac
            };
            datos[6] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "CPjson",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = ubi.CP
            };
            datos[7] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "FClienjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = ubi.f_cliente
            };
            string sentence = "insert into Ubicacion values(@ColoniaPjson,@CalNumjson,@Munjson,@Ciudjson,@Refjson,@Caracjson,@CPjson,@FClienjson);";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }

        //inicio de actualizaciones
        public Boolean ActualizarCarnicero(Carnicero nuev, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[5];

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
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "idcarn",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuev.idcarn
            };

            string sentence = "update Carnicero set Nombre=@namejson,Celular=@celjson, Correo=@emailjson,Exp_anios=@expjson where id_Carnicero = @idcarn;";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }

        public Boolean ActualizarCliente(Cliente nuev, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[5];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Nom",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = nuev.name
            };
            datos[1] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "ApP",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = nuev.ApP
            };
            datos[2] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Cel",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = nuev.Cel
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Correo",
                SqlDbType = SqlDbType.SmallInt,
                Direction = ParameterDirection.Input,
                Value = nuev.Correo
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "idcarn",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuev.idclient
            };

            string sentence = "update Cliente set Nombre=@Nom,App=@ApP, ApM=@ApM, Celular=@Cel, Correo= @Correo where id_Cliente = @idclient;";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }
       

        public Boolean ActualizarEntregaPedido(EntregaPedido nuev, int idselect, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[5];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "F_pedido",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuev.F_pedido
            };
            datos[1] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "F_repartidor",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuev.F_repartidor
            };
            datos[2] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Salida",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = nuev.Salida
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Entregado",
                SqlDbType = SqlDbType.SmallInt,
                Direction = ParameterDirection.Input,
                Value = nuev.Entregado
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Estado",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuev.Estado
            };
           datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Estado",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuev.Estado
            };
            datos[4] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "idEnt",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = idselect
            };
            string sentence = "update EntregaPedido set F_Pedido=@Fped, F_Repartidor=@fRep,Salida=@FechSalida,SeEntrego=@FechEntre, Estado=@Estado where id_Entrega = @idEnt;";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }
        public Boolean ActualizarPedido(Producto nuev, int idselect, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[6];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "NomProd",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuev.nameP
            };
            datos[1] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Peso",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuev.Peso
            };
            datos[2] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Cant",
                SqlDbType = SqlDbType.SmallInt,
                Direction = ParameterDirection.Input,
                Value = nuev.Cantidad
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "PrecioF",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuev.PrecioF
            };
            datos[4] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Nota",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuev.Nota
            };
            datos[5] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "idped",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = idselect
            };
            string sentence = "update Producto set NombreProd=@NomProd, Peso=@Peso,Cantidad=@Cant,PrecioFinal=@Preciofin, NotaEspecial=@Nota, F_Pedido= @fPed where id_prod = @idped;";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }

        public Boolean ActualizarDelivery(Repartidor nuev, int idselect, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[6];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "NomProd",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuev.name
            };
            datos[1] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Peso",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuev.cel
            };
            datos[2] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Cant",
                SqlDbType = SqlDbType.SmallInt,
                Direction = ParameterDirection.Input,
                Value = nuev.Licencia
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "idselect",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = idselect
            };
            
            string sentence = "update Producto set NombreProd=@NomProd, Peso=@Peso,Cantidad=@Cant,PrecioFinal=@Preciofin, NotaEspecial=@Nota, F_Pedido= @fPed where id_prod = @idselect;";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }
    }// fin de logica de negocio
}// fin de namespace
