using Microsoft.AspNetCore.Components;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace CallApi.Data
{
    public class GetInformation : IGetInformation
    {
 
        public async Task <List<MInformation>> GetInfo()
        {
            ////Install-Package Microsoft.AspNetCore.Blazor.HttpClient -Version 3.2.0-preview3.20168.3

            HttpClient http = new HttpClient();

            var data = await http.GetJsonAsync<ArrayList>("https://localhost:44387/api/Information");

            // List<MInformation> ms = await http.GetJsonAsync<List<MInformation>>
            //("https://localhost:44387/api/Information");

            List<MInformation> ms = new List<MInformation>();
            String x = "";

            return ms;
        }
        
    }
}
