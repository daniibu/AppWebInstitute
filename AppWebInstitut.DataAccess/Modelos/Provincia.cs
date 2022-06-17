using System.ComponentModel.DataAnnotations;
namespace AppWebInstitut.DataAccess.Modelos
{
    public class Provincia
    {
        public int ProvinciaId { get; set; }

        [StringLength(50,MinimumLength =3,ErrorMessage ="El largo máximo es de 50 caracteres")]
        [RegularExpression(@"([A-Z])\w+")]
        public string? ProvinciaName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DateUpdate { get; set; }
        //el campo se crea implicitamente, el interprete va almacenar los datos de cada una de las propiedades
        //no estoy haciendo validacion
        //si necesito hacer una operacion con los datos, necesita hacer validacion
        
    }
}