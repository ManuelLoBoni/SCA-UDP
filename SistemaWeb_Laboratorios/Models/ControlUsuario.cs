//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaWeb_Laboratorios.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ControlUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ControlUsuario()
        {
            this.Bitacora = new HashSet<Bitacora>();
        }

        [Display(Name = "Registro")]
        [ScaffoldColumn(false)]
        public int IdRegistro { get; set; }
        [Display(Name = "Fecha")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime)]
        public Nullable<System.DateTime> fecha { get; set; }
        [Display(Name = "Usuario")]
        public string IdUsuario { get; set; }
        [Display(Name = "Hora de Entrada")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        public Nullable<System.TimeSpan> HoraEntrada { get; set; }
        [Display(Name = "Hora de Salida")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        public Nullable<System.TimeSpan> HoraSalida { get; set; }
        [Display(Name = "Actividad")]
        public string TipoActividad { get; set; }
        [Display(Name = "Alumnos")]
        public int CantidadAlumnos { get; set; }
        [Display(Name = "Semestre")]
        public int Semestre { get; set; }
        [Display(Name = "Carrera")]
        public int IdCarrera { get; set; }
        [Display(Name = "Area")]
        public int Area { get; set; }

        public virtual Areas Areas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bitacora> Bitacora { get; set; }
        public virtual Carreras Carreras { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
