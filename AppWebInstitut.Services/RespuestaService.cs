using System;
using System.Collections.Generic;
namespace AppWebInstitut.Services
{
    //EL NOMBRE GENERALMENTE SE PONE EN INGLES Y ES PARA QUE ESTE ESCRITO SEA MÁS UNIVERSAL
    //ResponseServices
    public class RespuestaService <T>//Eso es una clase Generica
//para que una clase sea generica le informo que debe recibir un dato de cualquier tipo, <T>
    {
        //esta clase va a recibir un dato de algun tipo, a ese dato lo declaro un objeto
        public T? Objeto{get;set;}//declaro un objeto que reciba datos de tipo alumno, si llega un dato tipo localidad
        //el ? acepta valores nulos, objetos trabaja con los datos que llegan con la base de datos
        //si hay un error en la base de datos, objeto no tendra datos por eso lo hacemos como nulo ?
        public string?Error {get;set;}//aqui guardo el error que se está produciendo
        public int Status {get;set;}//aqui guardo el numero del errore
        public bool Successful {get;set;}//ta bien :D


        //ahora creamos un metodo que se va a llamar respuesta de servicio que va a devolver en status
        //el valor 200
        public  RespuestaService(){//es el constructor
            Status = 200;//OK.
            Successful=true;
        }

        public void AddBadResquest(string message){
        //el void va agregar una respuesta mala, va a recibir el string que puede ser un mensaje de error personalizado
            Status=400;//Argumento no válido o solicitud
            Error=message;
        }
        public void AddInternalServerError(string message){
            //error interno del servidor
            Status=500;//Error del servidor interno
            Error=message;
        }
         
    }
}