using Microsoft.AspNetCore.Components.Forms;
using System.IO;

namespace BlazorServerBienesRaices.Servicios
{
    public class SubidaArchivo : ISubidaArchivo
    {
        private readonly IWebHostEnvironment _webHostEnviroment;
        private readonly IConfiguration _configuration;

        public SubidaArchivo (IWebHostEnvironment webHostEnvironment, IConfiguration configuration)
        {
            _webHostEnviroment= webHostEnvironment;
            _configuration= configuration; 
        }



        public bool BorrarArchivo(string nombreArchivo)
        {
            try
            {   //Carpeta raiz donde se almacena (wwwroot)
                var path = $"{_webHostEnviroment.WebRootPath}\\ImagenesPropiedades\\{nombreArchivo}";
                if (File.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> SubirArchivo(IBrowserFile archivo)
        {
            try
            {   //Carpeta raiz donde se almacena (wwwroot)
                FileInfo fileInfo = new FileInfo(archivo.Name);
                var fileName = Guid.NewGuid().ToString()+fileInfo.Extension;
                var folderDirectory = $"{_webHostEnviroment.WebRootPath}\\ImagenesPropiedades";
                var path = Path.Combine(_webHostEnviroment.WebRootPath, "ImagenesPropiedades", fileName);

                var memoryStream = new MemoryStream();
                //Se copia en memory
                await archivo.OpenReadStream().CopyToAsync(memoryStream);
                if (!Directory.Exists(folderDirectory))
                {   //Creara directorio(carpeta) en casa de no existir
                    Directory.CreateDirectory(folderDirectory);
                }
                await using (var fs = new FileStream(path, FileMode.Create,FileAccess.Write))
                {
                    memoryStream.WriteTo(fs);
                }

                var url = $"{_configuration.GetValue<string>("ServerUrl")}";
                var fullPath = $"{url}ImagenesPropiedades/{fileName}";
                return fullPath;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
