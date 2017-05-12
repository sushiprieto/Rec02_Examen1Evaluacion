using System;
using System.ComponentModel.DataAnnotations;

namespace ENT
{
    public class clsPersona
    {

        //atributos
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        public string apellidos { get; set; }  
            
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime fechaNac { get; set; }

        [Display(Name = "Dirección")]
        public string direccion { get; set; }

        [Display(Name = "Teléfono")]
        public string telefono { get; set; }

        //constructores
        public clsPersona()
        {
            id = 0;
            nombre = "";
            apellidos = "";
            fechaNac = new DateTime();
            direccion = "";
            telefono = "";
        }

        public clsPersona(int id, string nombre, string apellidos, DateTime fechaNac, string direccion, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.direccion = direccion;
            this.telefono = telefono;
        }

    }
}
