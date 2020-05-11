using ProyectoPAV.negocio.repository;
using ProyectoPAV.negocio.servicios;

namespace ProyectoPAV.entidades
{
    public class Camarote
    {
        int id;
        int idNavio;
        int numCubierta;
        int numCamarote;
        int idTipoCamarote;
        string ubicacion;
        int cantCamas;

        public Camarote(int id ,int idNavio, int numCubierta, int numCamarote, int tipoCamarote, string ubicacion, int cantCamas)
        {
            this.Id = id;
            this.idNavio = id;
            this.numCubierta = numCubierta;
            this.numCamarote = numCamarote;
            this.idTipoCamarote = tipoCamarote;
            this.ubicacion = ubicacion;
            this.cantCamas = cantCamas;
        }

        public Camarote(int idNavio, int numCubierta, int numCamarote, int idTipoCamarote, string ubicacion, int cantCamas)
        {
            this.idNavio = idNavio;
            this.numCubierta = numCubierta;
            this.numCamarote = numCamarote;
            this.idTipoCamarote = idTipoCamarote;
            this.ubicacion = ubicacion;
            this.cantCamas = cantCamas;
        }

        public int IdNavio { get => idNavio; set => idNavio = value; }
        public int NumCubierta { get => numCubierta; set => numCubierta = value; }
        public int NumCamarote { get => numCamarote; set => numCamarote = value; }
        public int IdTipoCamarote { get => idTipoCamarote; set => idTipoCamarote = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public int CantCamas { get => cantCamas; set => cantCamas = value; }
        public int Id { get => id; set => id = value; }

        public Navio getNavio()
        {
            NavioService navioService = new NavioService();

            return navioService.getById(this.idNavio);

        }

        public TipoCamarote getTipoCamarote()
        {
            TipoCamaroteService tipoCamaroteService = new TipoCamaroteService();

            return tipoCamaroteService.getById(this.idTipoCamarote);
        }
    }
}
