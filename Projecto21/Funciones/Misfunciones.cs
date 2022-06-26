using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Hosting;
using Projecto21.Models;
namespace Projecto21.Funciones
{
    public class Misfunciones
    {
        string Ruta = HostingEnvironment.MapPath("~") + "App_Data/BD.txt";
        public void Escribir(Visitante Data)
        {
          StreamWriter Escribir = new StreamWriter(Ruta, true);
          Escribir.WriteLine(Data.id+"|" +Data.Nombre + "|" + Data.Comentario);
          Escribir.Close();
        }
    }
}