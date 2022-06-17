using System.ComponentModel.DataAnnotations;
namespace AppWebInstitut.DataAccess.Modelos
{
    public class TipoAsignatura
    {
        public int TipoAsignaturaId{get;set;}

        [RegularExpression(@"([A-Z])\w+")]
        public string? Nombre_TipoAsignatura{get;set;}   
    }
}