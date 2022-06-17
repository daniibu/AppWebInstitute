using System.ComponentModel.DataAnnotations;
namespace AppWebInstitut.DataAccess.Modelos
{
    public class Domicilio
    {
        public int DomicilioId { get; set; }

        [StringLength(50,MinimumLength =3,ErrorMessage ="El largo máximo es de 50 caracteres")]
        [RegularExpression(@"([A-Z])\w+")]
        public string? Calle { get; set; }

        [StringLength(5,MinimumLength =2,ErrorMessage ="El largo máximo es de 50 caracteres")]
        public int Numero { get; set; }

        [StringLength(5,MinimumLength =2,ErrorMessage ="El largo máximo es de 50 caracteres")]
        public string? Departamento { get; set; }

        [StringLength(5,MinimumLength =2,ErrorMessage ="El largo máximo es de 50 caracteres")]
        public int Piso { get; set; }

        [StringLength(50,MinimumLength =3,ErrorMessage ="El largo máximo es de 50 caracteres")]
        [RegularExpression(@"([A-Z])\w+")]
        public string? Barrio { get; set; }

        [StringLength(5,MinimumLength =2,ErrorMessage ="El largo máximo es de 50 caracteres")]
        public string? Manzana { get; set; }

        [StringLength(5,MinimumLength =2,ErrorMessage ="El largo máximo es de 50 caracteres")]
        public int Casa { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DateUpdate { get; set; }
    }
}