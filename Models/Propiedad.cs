﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerBienesRaices.Models
{
    public class Propiedad
    {
        [Key]
        public int IdPropiedad {get; set;}
        [Required]
        public string NombreP { get; set; }
        [Required]
        public string DescripcionP { get; set; }
        [Required]
        public int Area { get; set; }
        [Required]
        public int Habitaciones { get; set; }
        [Required]
        public int Banios { get; set; }
        [Required]
        public int Parking { get; set; }
        [Required]
        public double Precio { get; set; }
        [Required]
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaActualizacion { get; set; }

        //Relacion con modelo/tabla categoria
        public int CategoriaIDCategoria { get; set; }
        [ForeignKey("CategoriaIDCategoria")]
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<ImagenPropiedad> ImagenPropiedad { get; set; }
    }
}
