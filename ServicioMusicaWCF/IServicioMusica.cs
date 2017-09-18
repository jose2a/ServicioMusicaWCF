using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMusicaWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioMusica" in both code and config file together.
    [ServiceContract]
    public interface IServicioMusica
    {
        [OperationContract]
        string ObtenerArtistas();

        [OperationContract]
        string BuscarArtista(int id);

        [OperationContract]
        string AgregarArtista(string nombre, string pais);

        [OperationContract]
        string ModificarArtista(int id, string nombre, string pais);

        [OperationContract]
        string EliminarArtista(int id);

        [OperationContract]
        string ObtenerCanciones();

        [OperationContract]
        string BuscarCancion(int id);

        [OperationContract]
        string AgregarCancion(string titulo, string duracion);

        [OperationContract]
        string ModificarCancion(int id, string titulo, string duracion);

        [OperationContract]
        string EliminarCancion(int id);

        [OperationContract]
        string ObtenerConciertos();

        [OperationContract]
        string BuscarConcierto(int id);

        [OperationContract]
        string AgregarConcierto(int idArtista, string lugar, DateTime fecha);

        [OperationContract]
        string ModificarConcierto(int id, int idArtista, string lugar, DateTime fecha);

        [OperationContract]
        string EliminarConcierto(int id);

        [OperationContract]
        string ObtenerDetallesConcierto(int idConcierto);

        [OperationContract]
        string AgregarDetalleConcierto(int idConcierto, int idCancion, int orden);

        [OperationContract]
        string ModificarDetalleConcierto(int idConcierto, int idCancion, int orden);

        [OperationContract]
        string EliminarDetalleConcierto(int idConcierto, int idCancion);
    }
}
