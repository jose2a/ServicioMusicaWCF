﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicioMusicaWCF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MusicaEntities : DbContext
    {
        public MusicaEntities()
            : base("name=MusicaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Artistas> Artistas { get; set; }
        public virtual DbSet<Canciones> Canciones { get; set; }
        public virtual DbSet<Conciertos> Conciertos { get; set; }
        public virtual DbSet<DetallesConcierto> DetallesConcierto { get; set; }
    
        public virtual int Procedimiento_AgregarArtista(string nombre, string pais, ObjectParameter mensaje)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var paisParameter = pais != null ?
                new ObjectParameter("Pais", pais) :
                new ObjectParameter("Pais", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Procedimiento_AgregarArtista", nombreParameter, paisParameter, mensaje);
        }
    
        public virtual int Procedimiento_AgregarCancion(string titulo, string duracion, ObjectParameter mensaje)
        {
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var duracionParameter = duracion != null ?
                new ObjectParameter("Duracion", duracion) :
                new ObjectParameter("Duracion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Procedimiento_AgregarCancion", tituloParameter, duracionParameter, mensaje);
        }
    
        public virtual int Procedimiento_AgregarConcierto(Nullable<int> idArtista, string lugar, Nullable<System.DateTime> fecha, ObjectParameter mensaje)
        {
            var idArtistaParameter = idArtista.HasValue ?
                new ObjectParameter("IdArtista", idArtista) :
                new ObjectParameter("IdArtista", typeof(int));
    
            var lugarParameter = lugar != null ?
                new ObjectParameter("Lugar", lugar) :
                new ObjectParameter("Lugar", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Procedimiento_AgregarConcierto", idArtistaParameter, lugarParameter, fechaParameter, mensaje);
        }
    
        public virtual int Procedimiento_AgregarDetalleConcierto(Nullable<int> idConcierto, Nullable<int> idCancion, Nullable<int> orden, ObjectParameter mensaje)
        {
            var idConciertoParameter = idConcierto.HasValue ?
                new ObjectParameter("IdConcierto", idConcierto) :
                new ObjectParameter("IdConcierto", typeof(int));
    
            var idCancionParameter = idCancion.HasValue ?
                new ObjectParameter("IdCancion", idCancion) :
                new ObjectParameter("IdCancion", typeof(int));
    
            var ordenParameter = orden.HasValue ?
                new ObjectParameter("Orden", orden) :
                new ObjectParameter("Orden", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Procedimiento_AgregarDetalleConcierto", idConciertoParameter, idCancionParameter, ordenParameter, mensaje);
        }
    
        public virtual ObjectResult<Artistas> Procedimiento_BuscarArtista(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Artistas>("Procedimiento_BuscarArtista", idParameter);
        }
    
        public virtual ObjectResult<Artistas> Procedimiento_BuscarArtista(Nullable<int> id, MergeOption mergeOption)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Artistas>("Procedimiento_BuscarArtista", mergeOption, idParameter);
        }
    
        public virtual ObjectResult<Canciones> Procedimiento_BuscarCancion(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Canciones>("Procedimiento_BuscarCancion", idParameter);
        }
    
        public virtual ObjectResult<Canciones> Procedimiento_BuscarCancion(Nullable<int> id, MergeOption mergeOption)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Canciones>("Procedimiento_BuscarCancion", mergeOption, idParameter);
        }
    
        public virtual ObjectResult<Conciertos> Procedimiento_BuscarConcierto(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Conciertos>("Procedimiento_BuscarConcierto", idParameter);
        }
    
        public virtual ObjectResult<Conciertos> Procedimiento_BuscarConcierto(Nullable<int> id, MergeOption mergeOption)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Conciertos>("Procedimiento_BuscarConcierto", mergeOption, idParameter);
        }
    
        public virtual int Procedimiento_EliminarArtista(Nullable<int> id, ObjectParameter mensaje)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Procedimiento_EliminarArtista", idParameter, mensaje);
        }
    
        public virtual int Procedimiento_EliminarCancion(Nullable<int> id, ObjectParameter mensaje)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Procedimiento_EliminarCancion", idParameter, mensaje);
        }
    
        public virtual int Procedimiento_EliminarConcierto(Nullable<int> id, ObjectParameter mensaje)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Procedimiento_EliminarConcierto", idParameter, mensaje);
        }
    
        public virtual int Procedimiento_EliminarDetalleConcierto(Nullable<int> idConcierto, Nullable<int> idCancion, ObjectParameter mensaje)
        {
            var idConciertoParameter = idConcierto.HasValue ?
                new ObjectParameter("IdConcierto", idConcierto) :
                new ObjectParameter("IdConcierto", typeof(int));
    
            var idCancionParameter = idCancion.HasValue ?
                new ObjectParameter("IdCancion", idCancion) :
                new ObjectParameter("IdCancion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Procedimiento_EliminarDetalleConcierto", idConciertoParameter, idCancionParameter, mensaje);
        }
    
        public virtual int Procedimiento_ModificarArtista(Nullable<int> id, string nombre, string pais, ObjectParameter mensaje)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var paisParameter = pais != null ?
                new ObjectParameter("Pais", pais) :
                new ObjectParameter("Pais", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Procedimiento_ModificarArtista", idParameter, nombreParameter, paisParameter, mensaje);
        }
    
        public virtual int Procedimiento_ModificarCancion(Nullable<int> id, string titulo, string duracion, ObjectParameter mensaje)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var duracionParameter = duracion != null ?
                new ObjectParameter("Duracion", duracion) :
                new ObjectParameter("Duracion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Procedimiento_ModificarCancion", idParameter, tituloParameter, duracionParameter, mensaje);
        }
    
        public virtual int Procedimiento_ModificarConcierto(Nullable<int> id, Nullable<int> idArtista, string lugar, Nullable<System.DateTime> fecha, ObjectParameter mensaje)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var idArtistaParameter = idArtista.HasValue ?
                new ObjectParameter("IdArtista", idArtista) :
                new ObjectParameter("IdArtista", typeof(int));
    
            var lugarParameter = lugar != null ?
                new ObjectParameter("Lugar", lugar) :
                new ObjectParameter("Lugar", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Procedimiento_ModificarConcierto", idParameter, idArtistaParameter, lugarParameter, fechaParameter, mensaje);
        }
    
        public virtual int Procedimiento_ModificarDetalleConcierto(Nullable<int> idConcierto, Nullable<int> idCancion, Nullable<int> orden, ObjectParameter mensaje)
        {
            var idConciertoParameter = idConcierto.HasValue ?
                new ObjectParameter("IdConcierto", idConcierto) :
                new ObjectParameter("IdConcierto", typeof(int));
    
            var idCancionParameter = idCancion.HasValue ?
                new ObjectParameter("IdCancion", idCancion) :
                new ObjectParameter("IdCancion", typeof(int));
    
            var ordenParameter = orden.HasValue ?
                new ObjectParameter("Orden", orden) :
                new ObjectParameter("Orden", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Procedimiento_ModificarDetalleConcierto", idConciertoParameter, idCancionParameter, ordenParameter, mensaje);
        }
    
        public virtual ObjectResult<Artistas> Procedimiento_ObtenerArtistas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Artistas>("Procedimiento_ObtenerArtistas");
        }
    
        public virtual ObjectResult<Artistas> Procedimiento_ObtenerArtistas(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Artistas>("Procedimiento_ObtenerArtistas", mergeOption);
        }
    
        public virtual ObjectResult<Canciones> Procedimiento_ObtenerCanciones()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Canciones>("Procedimiento_ObtenerCanciones");
        }
    
        public virtual ObjectResult<Canciones> Procedimiento_ObtenerCanciones(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Canciones>("Procedimiento_ObtenerCanciones", mergeOption);
        }
    
        public virtual ObjectResult<Conciertos> Procedimiento_ObtenerConciertos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Conciertos>("Procedimiento_ObtenerConciertos");
        }
    
        public virtual ObjectResult<Conciertos> Procedimiento_ObtenerConciertos(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Conciertos>("Procedimiento_ObtenerConciertos", mergeOption);
        }
    
        public virtual ObjectResult<DetallesConcierto> Procedimiento_ObtenerDetallesConcierto(Nullable<int> idConcierto)
        {
            var idConciertoParameter = idConcierto.HasValue ?
                new ObjectParameter("IdConcierto", idConcierto) :
                new ObjectParameter("IdConcierto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DetallesConcierto>("Procedimiento_ObtenerDetallesConcierto", idConciertoParameter);
        }
    
        public virtual ObjectResult<DetallesConcierto> Procedimiento_ObtenerDetallesConcierto(Nullable<int> idConcierto, MergeOption mergeOption)
        {
            var idConciertoParameter = idConcierto.HasValue ?
                new ObjectParameter("IdConcierto", idConcierto) :
                new ObjectParameter("IdConcierto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DetallesConcierto>("Procedimiento_ObtenerDetallesConcierto", mergeOption, idConciertoParameter);
        }
    }
}
