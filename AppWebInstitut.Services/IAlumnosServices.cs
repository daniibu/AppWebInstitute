using AppWebInstitut.DataAccess.Modelos;
namespace AppWebInstitut.Services
{
    public interface IAlumnosServices
    {
         //debo de crear una nueva referencia, referencia para alumno
         //VAMOS A AGREGAR LAS TAREAS, las tareas es cuando el usuario entra a la página,
         //se ejecuta una tarea en el servidor, eso es un hilo de ejecucion
         //un hilo de ejecucion, el procesador sigue ejecutan algun icono por ejemplo, mientras ejecuta ese codigo
         //hay otro codigo ejecutandose.
         //mientras se ejecuta algo en la página web, hay otro programa que esta ejecutandose por "debajo" 
         //consultando en la base de datos
         Task<RespuestaService<List<Alumno>>> Listar();
         //tarea en base a la clase RespuestaService, que es del servicio de alumnos,
         //envia una lista de alumnos
         // a todo eso le pongo el listar
         //una lista es un tipo de dato que me permite a mi crear una lista de objetos del mismo tipo
         //cada objeto es como un registro en una base de datos
         //voy armando una tabla en la memoria
         //puedo manejar los datos dentro de la lista
         Task<RespuestaService<Alumno>> BuscarPorId(int id);
         Task<RespuestaService<Alumno>> Guardar(Alumno alumno);
         Task<RespuestaService<Alumno>> Actualizar(Alumno alumno);
         Task<RespuestaService<bool>> Eliminar(int id);
         //las tareas se pueden ejecutar de manera asincronicas: la ejecuto y puedo hacer otra cosa
         //y esa tarea se ejecuta en segundo plano
    }
}