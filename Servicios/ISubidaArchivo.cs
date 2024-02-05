using Microsoft.AspNetCore.Components.Forms;

namespace BlazorServerBienesRaices.Servicios
{
    public interface ISubidaArchivo
    {   //Seleccionar archivo de tipo file y subirlo
        Task<string> SubirArchivo(IBrowserFile archivo);
        bool BorrarArchivo(string nombreArchivo);
    }
}
