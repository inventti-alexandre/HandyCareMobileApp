using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using handycareappService.Controllers;
using handycareappService.DataObjects;

namespace handycareappService
{
    public static class Class1
    {
        public static async void agua()
        {
            var rnd = new Random();
            var foto = new Foto
            {
                FotCuidador = "61C59C6B-C588-42DF-BE78-D35036E6E6CC",
                FotoDescricao = "teste",
                Id = Guid.NewGuid().ToString(),
                FotoDados = new byte[50],

            };
            rnd.NextBytes(foto.FotoDados);
            var material = new Material
            {
                MatDescricao = "algo",
                MatQuantidade = 5,
                MatPacId = "D1B9FA65-553D-456B-A2B7-1AF77E637981"
            };
            var x = new MaterialController();
            x.Request = new HttpRequestMessage(HttpMethod.Post, Uri.UriSchemeHttps);
            await x.PostMaterial(material);
            //var a = new FotoController();
            //await a.PostFoto(foto);
        }
    }
}