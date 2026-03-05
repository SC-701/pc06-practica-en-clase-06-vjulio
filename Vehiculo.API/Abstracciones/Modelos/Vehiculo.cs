using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Modelos
{
    public class VehiculoBase
    {
        [Required(ErrorMessage = "La propiedad placa es requerida")]
        [RegularExpression(@"[A-Za-z]{3}-[0-9]{3}")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "La propiedad color es requerida")]
        public string Color { get; set; }

        [Required(ErrorMessage = "La propiedad año es requerida")]
        public int Anio { get; set; }

        [Required(ErrorMessage = "La propiedad precio es requerida")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La propiedad correo es requerida")]
        public string CorreoPropietario { get; set; }

        [Required(ErrorMessage = "La propiedad teléfono es requerida")]
        public string Telefono { get; set; }
    }

    public class VehiculoRequest : VehiculoBase
    {
        public Guid IdModelo { get; set; }
    }

    public class VehiculoResponse : VehiculoBase
    {
        public Guid IdModelo { get; set;}
        public string Modelo   { get; set;}
        public string Marca     { get; set;}


    }
}
