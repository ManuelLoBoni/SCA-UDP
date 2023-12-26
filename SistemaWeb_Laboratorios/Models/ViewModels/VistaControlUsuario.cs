using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaWeb_Laboratorios.Models.ViewModels
{
    public class VistaControlUsuario
    {
        [Display(Name = "Registro")]
        public int IdRegistro { get; set; }

        [Display(Name = "Fecha")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime)]
        public DateTime? fecha { get; set; }

        [Display(Name = "Usuario")]
        public string IdUsuario { get; set; }
        [Display(Name = "Hora de Entrada")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        public TimeSpan? HoraEntrada { get; set; }
        [Display(Name = "Hora de Salida")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        public TimeSpan? HoraSalida { get; set; }
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
    }
}