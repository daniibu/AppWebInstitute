using System.ComponentModel.DataAnnotations;
namespace AppWebInstitut.DataAccess.Modelos //el namespace me permite organizar el codigo en el entorno que estoy programando
{
    public class Localidad
    {
        public int LocalidadId { get; set; }

        [StringLength(50,MinimumLength =3,ErrorMessage ="El largo máximo es de 50 caracteres")]
        [RegularExpression(@"([A-Z])\w+")]
        public string? LocalidadName { get; set; }

        [StringLength(5,MinimumLength =2,ErrorMessage ="Ingrese su código postal")]
        public string? CodPost { get; set; }

        public int ProvinciaId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DateUpgrate { get; set; }
    }
}