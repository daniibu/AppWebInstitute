using System.ComponentModel.DataAnnotations;
namespace AppWebInstitut.DataAccess.Modelos
{
    public class Asignaturas
    {
        public int AsignaturaId{get;set;}
        public string? NombreAsignatura{get;set;}
        public int Curso{get;set;}
        public int Cursado{get;set;}
        public int Resolucion{get;set;}
    }
}