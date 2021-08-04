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
        AccesoaDatos accesdataline = new AccesoaDatos(@"Data Source=DESKTOP-2RIAEJ3; Initial Catalog=PedidosCarniceria; Integrated Security = true;");
        // datos desde entity para hacfer muestras anti inyecciones
        PedidosCarniceriaEntities objEntity = new PedidosCarniceriaEntities();

        public Boolean InsertarCarnicero(EntCarnicero nuev, ref string smsexit) 
        {

            SqlParameter[] datos = new SqlParameter[4];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "namejson",
                SqlDbType = SqlDbType.VarChar,
                Size=60,
                Direction = ParameterDirection.Input,
                Value = nuev.name
            };
            datos[1] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "celjson",
                SqlDbType = SqlDbType.VarChar,
                Size = 12,
                Direction = ParameterDirection.Input,
                Value = nuev.cel
            };
            datos[2] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "emailjson",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
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

            exit = accesdataline.Modify(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit, datos);

            return exit;
        }


      
            public List<EntCliente> GetClientes(ref string msj_salida)
            {
                SqlConnection conex = null;

                string query = "select * from Cliente;";

                conex = accesdataline.AbrirConexion(ref msj_salida);

                SqlDataReader ObtenerDatos = null;

                ObtenerDatos = accesdataline.ConsultarReader(query, conex, ref msj_salida);

                List<EntCliente> lista = new List<EntCliente>();


                if (ObtenerDatos != null)
                {
                    while (ObtenerDatos.Read())
                    { 
                         lista.Add(new EntCliente
                        {
                             idclient = (int)ObtenerDatos[0],
                              name = (string)ObtenerDatos[1],
                             ApP = (string)ObtenerDatos[2],
                              ApM = (string)ObtenerDatos[3],
                              Cel = (string)ObtenerDatos[4],
                             Correo = (string)ObtenerDatos[5],
                            
                         
                        });
                    }
                }
                else
                {
                    lista = null;
                }
                conex.Close();
                conex.Dispose();

                return lista;

            }


        public List<EntPedido> GetPedidos(ref string msj_salida)
        {
            SqlConnection conex = null;

            string query = "select * from Pedido;";

            conex = accesdataline.AbrirConexion(ref msj_salida);

            SqlDataReader ObtenerDatos = null;

            ObtenerDatos = accesdataline.ConsultarReader(query, conex, ref msj_salida);

            List<EntPedido> lista = new List<EntPedido>();


            if (ObtenerDatos != null)
            {
                while (ObtenerDatos.Read())
                {
                    lista.Add(new EntPedido
                    {
                        id = (int)ObtenerDatos[0],
                        FechaHra = (DateTime)ObtenerDatos[1],
                        F_cliente = (int)ObtenerDatos[2],
                        F_Carnicero = (int)ObtenerDatos[3],
                        Envio = (bool)ObtenerDatos[4],
                        Pago = (string)ObtenerDatos[5],
                      
                    });
                }
            }
            else
            {
                lista = null;
            }
            conex.Close();
            conex.Dispose();

            return lista;

        }

        public List<EntCarnicero> GetCarniceros(ref string msj_salida)
        {
            SqlConnection conex = null;

            string query = "select * from Carnicero;";

            conex = accesdataline.AbrirConexion(ref msj_salida);

            SqlDataReader ObtenerDatos = null;

            ObtenerDatos = accesdataline.ConsultarReader(query, conex, ref msj_salida);

            List<EntCarnicero> lista = new List<EntCarnicero>();


            if (ObtenerDatos != null)
            {
                while (ObtenerDatos.Read())
                {
                    lista.Add(new EntCarnicero
                    {
                        idcarn = (int)ObtenerDatos[0],
                        name = (string)ObtenerDatos[1],
                        cel = (string)ObtenerDatos[2],
                        email = (string)ObtenerDatos[3],
                        exp = (short)ObtenerDatos[4],
    });
                }
            }
            else
            {
                lista = null;
            }
            conex.Close();
            conex.Dispose();

            return lista;

        }




        public Boolean InsertarCliente(EntCliente Clien, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[5];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "namejson",
                SqlDbType = SqlDbType.VarChar,
                Size = 90,
                Direction = ParameterDirection.Input,
                Value = Clien.name
            };
            datos[1] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "ApPjson",
                SqlDbType = SqlDbType.VarChar,
                Size = 90,
                Direction = ParameterDirection.Input,
                Value = Clien.ApP
            };
            datos[2] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "ApMjson",
                SqlDbType = SqlDbType.VarChar,
                Size = 90,
                Direction = ParameterDirection.Input,
                Value = Clien.ApM
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "celjson",
                SqlDbType = SqlDbType.VarChar,
                Size = 20,
                Direction = ParameterDirection.Input,
                Value = Clien.Cel
            };
            datos[4] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "correojson",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Direction = ParameterDirection.Input,
                Value = Clien.Correo
            };

            string sentence = "insert into Cliente values(@namejson,@ApPjson,@ApMjson,@celjson,@correojson);";

            Boolean exit = false;

            exit = accesdataline.Modify(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit, datos);

            return exit;
        }

        public Boolean InsertarEntrePed(EntEntregaPedido EP, ref string smsexit)
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

        public Boolean InsertarPedido(EntPedido ped, ref string smsexit)
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

            exit = accesdataline.Modify(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit, datos);

            return exit;
        }

        //mostrar pedidos
        public DataTable showPedidos(ref string msj)
        {
            string query = "select * from Pedido";

            DataSet obj_show = null;
            DataTable outtable = null;

            
            obj_show = accesdataline.ConsultaDS(query, accesdataline.AbrirConexion(ref msj), ref msj);

            if (obj_show != null)
            {
                outtable = obj_show.Tables[0];
            }

            return outtable;


        }
        //mostrar pedidos
        public DataTable showCarnicero(ref string msj)
        {
            string query = "select * from Carnicero";

            DataSet obj_show = null;
            DataTable outtable = null;


            obj_show = accesdataline.ConsultaDS(query, accesdataline.AbrirConexion(ref msj), ref msj);

            if (obj_show != null)
            {
                outtable = obj_show.Tables[0];
            }

            return outtable;


        }
        public DataTable showClients(ref string msj)
        {
            string query = "select * from Cliente";

            DataSet obj_show = null;
            DataTable outtable = null;


            obj_show = accesdataline.ConsultaDS(query, accesdataline.AbrirConexion(ref msj), ref msj);

            if (obj_show != null)
            {
                outtable = obj_show.Tables[0];
            }

            return outtable;


        }
        public DataTable showPedidosClient(string name, ref string msj)

        {
            //SqlParameter[] datos = new SqlParameter[5];

            //datos[0] = new SqlParameter
            //{
            //    // se crea tipo json para agrupar datos
            //    ParameterName = "name",
            //    SqlDbType = SqlDbType.NVarChar,
            //    Size = 100,
            //    Direction = ParameterDirection.Input,
            //    Value = name
            //};
            string query = "select cli.Nombre, cli.App, cli.ApM,ped.FechaHora, prod.NombreProd, prod.Peso, prod.Cantidad, prod.PrecioFinal from Cliente as cli inner join Pedido as ped on cli.id_Cliente = ped.F_Cliente inner join Producto as prod on ped.id_Pedido = prod.F_Pedido where cli.Nombre = '"+name+"'";

            DataSet obj_show = null;
            DataTable outtable = null;


            obj_show = accesdataline.ConsultaDS(query, accesdataline.AbrirConexion(ref msj), ref msj);

            if (obj_show != null)
            {
                outtable = obj_show.Tables[0];
                if (obj_show.Tables[0].Rows.Count == 0) {
                    outtable.Rows.Add(outtable.NewRow());
                }
               
            }

            return outtable;


        }

        public Boolean InsertarProducto(EntProducto prod, ref string smsexit)
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

            exit = accesdataline.Modify(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit, datos);

            return exit;
        }


        public Boolean InsertarRepartidor(Delivery rep, ref string smsexit)
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


        public Boolean InsertarUbicacion(EntUbicacion ubi, ref string smsexit)
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
        public Boolean ActualizarCarnicero(EntCarnicero nuev, ref string smsexit)
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
            datos[4] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "idcarn",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuev.idcarn
            };

            string sentence = "update Carnicero set Nombre=@namejson,Celular=@celjson, Correo=@emailjson,Exp_anios=@expjson where id_Carnicero = @idcarn;";

            Boolean exit = false;

            exit = accesdataline.Modify(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit, datos);

            return exit;
        }

        public Boolean ActualizarCliente(EntCliente nuev, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[6];

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
                ParameterName = "ApM",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = nuev.ApM
            };
            datos[3] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Cel",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = nuev.Cel
            };
            datos[4] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "Correo",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = nuev.Correo
            };
            datos[5] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "idclient",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuev.idclient
            };

            string sentence = "update Cliente set Nombre=@Nom,App=@ApP, ApM=@ApM, Celular=@Cel, Correo= @Correo where id_Cliente = @idclient;";

            Boolean exit = false;

            exit = accesdataline.Modify(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit, datos);

            return exit;
        }
       

        public Boolean ActualizarEntregaPedido(EntEntregaPedido nuev, int idselect, ref string smsexit)
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
        public Boolean ActualizarPedido(EntProducto nuev, int idselect, ref string smsexit)
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

        public Boolean ActualizarDelivery(Delivery nuev, int idselect, ref string smsexit)
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

        // Metodos de eliminar
        public Boolean EliminarCarni(int idCarn, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[1];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "IdCarnPjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = idCarn
            };

            string sentence = "delete from Carnicero where id_Carnicero = @IdCarnPjson;";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }

        public Boolean EliminarCliente(int idCliente, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[1];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "IdClienPjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = idCliente
            };

            string sentence = "delete from Cliente where id_Cliente = @IdClienPjson";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }

        public Boolean EliminarEntrePed(int idEntrega, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[1];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "IdEntrePjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = idEntrega
            };

            string sentence = "delete from EntregaPedido where id_Entrega = @IdEntrePjson;";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }


        public Boolean EliminarPed(int idPed, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[1];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "IdPedjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = idPed
            };

            string sentence = "delete from Pedido where id_Pedido = @IdPedjson;";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }

        public Boolean EliminarProd(int idProd, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[1];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "IdProdjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = idProd
            };

            string sentence = "delete from Producto where id_prod = @IdProdjson;";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }

        public Boolean EliminarRep(int idRep, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[1];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "IdRepjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = idRep
            };

            string sentence = "delete from Repartidor where id_Repartidor = @IdRepjson;";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }

        public Boolean EliminarUbi(int idUbi, ref string smsexit)
        {

            SqlParameter[] datos = new SqlParameter[1];

            datos[0] = new SqlParameter
            {
                // se crea tipo json para agrupar datos
                ParameterName = "IdUbiPjson",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = idUbi
            };

            string sentence = "delete from Ubicacion where id_ubicacion = @IdUbiPjson;";

            Boolean exit = false;

            exit = accesdataline.ModificaBDinsegura(sentence, accesdataline.AbrirConexion(ref smsexit), ref smsexit);

            return exit;
        }
    }// fin de logica de negocio
}// fin de namespace
