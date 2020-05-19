﻿using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
     public class ItinerarioDao
    {
        private static BE_acceso_BD accesoBD;

        public ItinerarioDao()
        {

            accesoBD = new BE_acceso_BD();

        }

        public Itinerario getById(int idItinerario)
        {
            string sql = "SELECT * FROM ITINERARIOS WHERE Cod_itinerario= " + idItinerario;
            DataTable dataTable = accesoBD.ejecutarConsulta(sql);

            int id = Convert.ToInt32(dataTable.Rows[0]["Cod_itinerario"].ToString());
            string descripcion = dataTable.Rows[0]["Descripcion"].ToString();
            string categoria = dataTable.Rows[0]["Categoria"].ToString();

            Itinerario itinerario = new Itinerario(id, descripcion, categoria);

            return itinerario;
        }



        public List<Itinerario> getAll()
        {
            string sql = "SELECT * FROM ITINERARIOS";
            DataTable dataTable = accesoBD.ejecutarConsulta(sql);
            List<Itinerario> itinerariosList = new List<Itinerario>();

            if (dataTable.Rows.Count != 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(dataTable.Rows[0]["Cod_itinerario"].ToString());
                    string descripcion = dataTable.Rows[0]["Descripcion"].ToString();
                    string categoria = dataTable.Rows[0]["Categoria"].ToString();

                    Itinerario itinerario = new Itinerario(id, descripcion, categoria);

                    itinerariosList.Add(itinerario);
                }
            }
            return itinerariosList;
        }


        internal bool create(Itinerario itinerario)
        {
            string strSQL = "INSERT INTO ITINERARIOS (Descripcion, Categoria) " +
                " VALUES (" +
                "'" + itinerario.Descripcion + "'" + "," +
                "'" + itinerario.Categoria + "'" + ")";

            BE_acceso_BD.estado_BE estado = accesoBD.insertar(strSQL);

            return verifyState(estado);
        }

        internal bool update(Itinerario itinerario)
        {
            string strSQL = "UPDATE ITINERARIOS " +
                             " SET Descripcion=" + "'" + itinerario.Descripcion + "'" + "," +
                             " Categoria=" + "'" + itinerario.Categoria + "'" + "," +
                             " WHERE Cod_itinerario=" + itinerario.IdItinerario;

            BE_acceso_BD.estado_BE estado = accesoBD.modificar(strSQL);

            return verifyState(estado);
            

        }

        internal bool delete(Itinerario itinerario)
        {
            return this.deleteById(itinerario.IdItinerario);
        }


        internal bool deleteById(int id)
        {
            string sql = "DELETE FROM ITINERARIOS WHERE Cod_itinerario = " + id;
            BE_acceso_BD.estado_BE estado = accesoBD.borrar(sql);

            return verifyState(estado);
        }

        private bool verifyState(BE_acceso_BD.estado_BE estado)
        {
            if (estado == BE_acceso_BD.estado_BE.correcto)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
        










            
              

       






