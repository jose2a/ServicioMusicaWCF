﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicaWCFTest.ServiceMusica {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMusica.IServicioMusica")]
    public interface IServicioMusica {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ObtenerArtistas", ReplyAction="http://tempuri.org/IServicioMusica/ObtenerArtistasResponse")]
        string ObtenerArtistas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ObtenerArtistas", ReplyAction="http://tempuri.org/IServicioMusica/ObtenerArtistasResponse")]
        System.Threading.Tasks.Task<string> ObtenerArtistasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/BuscarArtista", ReplyAction="http://tempuri.org/IServicioMusica/BuscarArtistaResponse")]
        string BuscarArtista(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/BuscarArtista", ReplyAction="http://tempuri.org/IServicioMusica/BuscarArtistaResponse")]
        System.Threading.Tasks.Task<string> BuscarArtistaAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/AgregarArtista", ReplyAction="http://tempuri.org/IServicioMusica/AgregarArtistaResponse")]
        string AgregarArtista(string nombre, string pais);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/AgregarArtista", ReplyAction="http://tempuri.org/IServicioMusica/AgregarArtistaResponse")]
        System.Threading.Tasks.Task<string> AgregarArtistaAsync(string nombre, string pais);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ModificarArtista", ReplyAction="http://tempuri.org/IServicioMusica/ModificarArtistaResponse")]
        string ModificarArtista(int id, string nombre, string pais);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ModificarArtista", ReplyAction="http://tempuri.org/IServicioMusica/ModificarArtistaResponse")]
        System.Threading.Tasks.Task<string> ModificarArtistaAsync(int id, string nombre, string pais);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/EliminarArtista", ReplyAction="http://tempuri.org/IServicioMusica/EliminarArtistaResponse")]
        string EliminarArtista(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/EliminarArtista", ReplyAction="http://tempuri.org/IServicioMusica/EliminarArtistaResponse")]
        System.Threading.Tasks.Task<string> EliminarArtistaAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ObtenerCanciones", ReplyAction="http://tempuri.org/IServicioMusica/ObtenerCancionesResponse")]
        string ObtenerCanciones();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ObtenerCanciones", ReplyAction="http://tempuri.org/IServicioMusica/ObtenerCancionesResponse")]
        System.Threading.Tasks.Task<string> ObtenerCancionesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/BuscarCancion", ReplyAction="http://tempuri.org/IServicioMusica/BuscarCancionResponse")]
        string BuscarCancion(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/BuscarCancion", ReplyAction="http://tempuri.org/IServicioMusica/BuscarCancionResponse")]
        System.Threading.Tasks.Task<string> BuscarCancionAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/AgregarCancion", ReplyAction="http://tempuri.org/IServicioMusica/AgregarCancionResponse")]
        string AgregarCancion(string titulo, string duracion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/AgregarCancion", ReplyAction="http://tempuri.org/IServicioMusica/AgregarCancionResponse")]
        System.Threading.Tasks.Task<string> AgregarCancionAsync(string titulo, string duracion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ModificarCancion", ReplyAction="http://tempuri.org/IServicioMusica/ModificarCancionResponse")]
        string ModificarCancion(int id, string titulo, string duracion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ModificarCancion", ReplyAction="http://tempuri.org/IServicioMusica/ModificarCancionResponse")]
        System.Threading.Tasks.Task<string> ModificarCancionAsync(int id, string titulo, string duracion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/EliminarCancion", ReplyAction="http://tempuri.org/IServicioMusica/EliminarCancionResponse")]
        string EliminarCancion(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/EliminarCancion", ReplyAction="http://tempuri.org/IServicioMusica/EliminarCancionResponse")]
        System.Threading.Tasks.Task<string> EliminarCancionAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ObtenerConciertos", ReplyAction="http://tempuri.org/IServicioMusica/ObtenerConciertosResponse")]
        string ObtenerConciertos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ObtenerConciertos", ReplyAction="http://tempuri.org/IServicioMusica/ObtenerConciertosResponse")]
        System.Threading.Tasks.Task<string> ObtenerConciertosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/BuscarConcierto", ReplyAction="http://tempuri.org/IServicioMusica/BuscarConciertoResponse")]
        string BuscarConcierto(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/BuscarConcierto", ReplyAction="http://tempuri.org/IServicioMusica/BuscarConciertoResponse")]
        System.Threading.Tasks.Task<string> BuscarConciertoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/AgregarConcierto", ReplyAction="http://tempuri.org/IServicioMusica/AgregarConciertoResponse")]
        string AgregarConcierto(int idArtista, string lugar, System.DateTime fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/AgregarConcierto", ReplyAction="http://tempuri.org/IServicioMusica/AgregarConciertoResponse")]
        System.Threading.Tasks.Task<string> AgregarConciertoAsync(int idArtista, string lugar, System.DateTime fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ModificarConcierto", ReplyAction="http://tempuri.org/IServicioMusica/ModificarConciertoResponse")]
        string ModificarConcierto(int id, int idArtista, string lugar, System.DateTime fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ModificarConcierto", ReplyAction="http://tempuri.org/IServicioMusica/ModificarConciertoResponse")]
        System.Threading.Tasks.Task<string> ModificarConciertoAsync(int id, int idArtista, string lugar, System.DateTime fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/EliminarConcierto", ReplyAction="http://tempuri.org/IServicioMusica/EliminarConciertoResponse")]
        string EliminarConcierto(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/EliminarConcierto", ReplyAction="http://tempuri.org/IServicioMusica/EliminarConciertoResponse")]
        System.Threading.Tasks.Task<string> EliminarConciertoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ObtenerDetallesConcierto", ReplyAction="http://tempuri.org/IServicioMusica/ObtenerDetallesConciertoResponse")]
        string ObtenerDetallesConcierto(int idConcierto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ObtenerDetallesConcierto", ReplyAction="http://tempuri.org/IServicioMusica/ObtenerDetallesConciertoResponse")]
        System.Threading.Tasks.Task<string> ObtenerDetallesConciertoAsync(int idConcierto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/AgregarDetalleConcierto", ReplyAction="http://tempuri.org/IServicioMusica/AgregarDetalleConciertoResponse")]
        string AgregarDetalleConcierto(int idConcierto, int idCancion, int orden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/AgregarDetalleConcierto", ReplyAction="http://tempuri.org/IServicioMusica/AgregarDetalleConciertoResponse")]
        System.Threading.Tasks.Task<string> AgregarDetalleConciertoAsync(int idConcierto, int idCancion, int orden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ModificarDetalleConcierto", ReplyAction="http://tempuri.org/IServicioMusica/ModificarDetalleConciertoResponse")]
        string ModificarDetalleConcierto(int idConcierto, int idCancion, int orden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/ModificarDetalleConcierto", ReplyAction="http://tempuri.org/IServicioMusica/ModificarDetalleConciertoResponse")]
        System.Threading.Tasks.Task<string> ModificarDetalleConciertoAsync(int idConcierto, int idCancion, int orden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/EliminarDetalleConcierto", ReplyAction="http://tempuri.org/IServicioMusica/EliminarDetalleConciertoResponse")]
        string EliminarDetalleConcierto(int idConcierto, int idCancion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioMusica/EliminarDetalleConcierto", ReplyAction="http://tempuri.org/IServicioMusica/EliminarDetalleConciertoResponse")]
        System.Threading.Tasks.Task<string> EliminarDetalleConciertoAsync(int idConcierto, int idCancion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioMusicaChannel : MusicaWCFTest.ServiceMusica.IServicioMusica, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioMusicaClient : System.ServiceModel.ClientBase<MusicaWCFTest.ServiceMusica.IServicioMusica>, MusicaWCFTest.ServiceMusica.IServicioMusica {
        
        public ServicioMusicaClient() {
        }
        
        public ServicioMusicaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioMusicaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioMusicaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioMusicaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ObtenerArtistas() {
            return base.Channel.ObtenerArtistas();
        }
        
        public System.Threading.Tasks.Task<string> ObtenerArtistasAsync() {
            return base.Channel.ObtenerArtistasAsync();
        }
        
        public string BuscarArtista(int id) {
            return base.Channel.BuscarArtista(id);
        }
        
        public System.Threading.Tasks.Task<string> BuscarArtistaAsync(int id) {
            return base.Channel.BuscarArtistaAsync(id);
        }
        
        public string AgregarArtista(string nombre, string pais) {
            return base.Channel.AgregarArtista(nombre, pais);
        }
        
        public System.Threading.Tasks.Task<string> AgregarArtistaAsync(string nombre, string pais) {
            return base.Channel.AgregarArtistaAsync(nombre, pais);
        }
        
        public string ModificarArtista(int id, string nombre, string pais) {
            return base.Channel.ModificarArtista(id, nombre, pais);
        }
        
        public System.Threading.Tasks.Task<string> ModificarArtistaAsync(int id, string nombre, string pais) {
            return base.Channel.ModificarArtistaAsync(id, nombre, pais);
        }
        
        public string EliminarArtista(int id) {
            return base.Channel.EliminarArtista(id);
        }
        
        public System.Threading.Tasks.Task<string> EliminarArtistaAsync(int id) {
            return base.Channel.EliminarArtistaAsync(id);
        }
        
        public string ObtenerCanciones() {
            return base.Channel.ObtenerCanciones();
        }
        
        public System.Threading.Tasks.Task<string> ObtenerCancionesAsync() {
            return base.Channel.ObtenerCancionesAsync();
        }
        
        public string BuscarCancion(int id) {
            return base.Channel.BuscarCancion(id);
        }
        
        public System.Threading.Tasks.Task<string> BuscarCancionAsync(int id) {
            return base.Channel.BuscarCancionAsync(id);
        }
        
        public string AgregarCancion(string titulo, string duracion) {
            return base.Channel.AgregarCancion(titulo, duracion);
        }
        
        public System.Threading.Tasks.Task<string> AgregarCancionAsync(string titulo, string duracion) {
            return base.Channel.AgregarCancionAsync(titulo, duracion);
        }
        
        public string ModificarCancion(int id, string titulo, string duracion) {
            return base.Channel.ModificarCancion(id, titulo, duracion);
        }
        
        public System.Threading.Tasks.Task<string> ModificarCancionAsync(int id, string titulo, string duracion) {
            return base.Channel.ModificarCancionAsync(id, titulo, duracion);
        }
        
        public string EliminarCancion(int id) {
            return base.Channel.EliminarCancion(id);
        }
        
        public System.Threading.Tasks.Task<string> EliminarCancionAsync(int id) {
            return base.Channel.EliminarCancionAsync(id);
        }
        
        public string ObtenerConciertos() {
            return base.Channel.ObtenerConciertos();
        }
        
        public System.Threading.Tasks.Task<string> ObtenerConciertosAsync() {
            return base.Channel.ObtenerConciertosAsync();
        }
        
        public string BuscarConcierto(int id) {
            return base.Channel.BuscarConcierto(id);
        }
        
        public System.Threading.Tasks.Task<string> BuscarConciertoAsync(int id) {
            return base.Channel.BuscarConciertoAsync(id);
        }
        
        public string AgregarConcierto(int idArtista, string lugar, System.DateTime fecha) {
            return base.Channel.AgregarConcierto(idArtista, lugar, fecha);
        }
        
        public System.Threading.Tasks.Task<string> AgregarConciertoAsync(int idArtista, string lugar, System.DateTime fecha) {
            return base.Channel.AgregarConciertoAsync(idArtista, lugar, fecha);
        }
        
        public string ModificarConcierto(int id, int idArtista, string lugar, System.DateTime fecha) {
            return base.Channel.ModificarConcierto(id, idArtista, lugar, fecha);
        }
        
        public System.Threading.Tasks.Task<string> ModificarConciertoAsync(int id, int idArtista, string lugar, System.DateTime fecha) {
            return base.Channel.ModificarConciertoAsync(id, idArtista, lugar, fecha);
        }
        
        public string EliminarConcierto(int id) {
            return base.Channel.EliminarConcierto(id);
        }
        
        public System.Threading.Tasks.Task<string> EliminarConciertoAsync(int id) {
            return base.Channel.EliminarConciertoAsync(id);
        }
        
        public string ObtenerDetallesConcierto(int idConcierto) {
            return base.Channel.ObtenerDetallesConcierto(idConcierto);
        }
        
        public System.Threading.Tasks.Task<string> ObtenerDetallesConciertoAsync(int idConcierto) {
            return base.Channel.ObtenerDetallesConciertoAsync(idConcierto);
        }
        
        public string AgregarDetalleConcierto(int idConcierto, int idCancion, int orden) {
            return base.Channel.AgregarDetalleConcierto(idConcierto, idCancion, orden);
        }
        
        public System.Threading.Tasks.Task<string> AgregarDetalleConciertoAsync(int idConcierto, int idCancion, int orden) {
            return base.Channel.AgregarDetalleConciertoAsync(idConcierto, idCancion, orden);
        }
        
        public string ModificarDetalleConcierto(int idConcierto, int idCancion, int orden) {
            return base.Channel.ModificarDetalleConcierto(idConcierto, idCancion, orden);
        }
        
        public System.Threading.Tasks.Task<string> ModificarDetalleConciertoAsync(int idConcierto, int idCancion, int orden) {
            return base.Channel.ModificarDetalleConciertoAsync(idConcierto, idCancion, orden);
        }
        
        public string EliminarDetalleConcierto(int idConcierto, int idCancion) {
            return base.Channel.EliminarDetalleConcierto(idConcierto, idCancion);
        }
        
        public System.Threading.Tasks.Task<string> EliminarDetalleConciertoAsync(int idConcierto, int idCancion) {
            return base.Channel.EliminarDetalleConciertoAsync(idConcierto, idCancion);
        }
    }
}