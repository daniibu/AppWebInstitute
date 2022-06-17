using System.ComponentModel.DataAnnotations;
namespace AppWebInstitut.DataAccess.Modelos
{
    public class DocentesXAsignatura
    {
        public int Docente{get;set;}

        [RegularExpression(@"([A-Z])\w+")]
        public string? Asignatura{get;set;}
    }
}