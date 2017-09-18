using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServicioMusicaWCF
{
    [Serializable]
    public class tblArtistas
    {
        [JsonIgnore]
        public virtual ICollection<Conciertos> Conciertos { get; set; }
    }

    [MetadataType(typeof(tblArtistas))]
    public partial class Artistas { }

    [Serializable]
    public class tblCanciones
    {
        [JsonIgnore]
        public virtual ICollection<DetallesConcierto> DetallesConcierto { get; set; }
    }

    [MetadataType(typeof(tblCanciones))]
    public partial class Canciones { }

    [Serializable]
    public class tblConciertos
    {
        [JsonIgnore]
        public virtual Artistas Artistas { get; set; }
        [JsonIgnore]
        public virtual ICollection<DetallesConcierto> DetallesConcierto { get; set; }
    }

    [MetadataType(typeof(tblConciertos))]
    public partial class Conciertos { }

    [Serializable]
    public class tblDetallesConcierto
    {
        [JsonIgnore]
        public virtual Canciones Canciones { get; set; }

        [JsonIgnore]
        public virtual Conciertos Conciertos { get; set; }
    }

    [MetadataType(typeof(tblDetallesConcierto))]
    public partial class DetallesConcierto { }
}