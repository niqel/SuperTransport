using CrmTcAPI.Models;
using Microsoft.Graph;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace Core.Api.BLL.Other
{
    public class AuthenticationAD
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private readonly IHttpClientFactory _clientFactory;        
        private readonly string clientId = "67787513-7d98-4dfe-b8fd-a8933b6a4176";
        private readonly string clientsecret = "6QX1psQZLA6df-~vIUQ3e.JvH16.5K9_IJ";

        public AuthenticationAD(IHttpClientFactory clientFactory)
        {
            _clientFactory =  clientFactory;
        }
        public AuthenticationAD()
        {            
        }

        public async Task<ADObject> getUserAndRole(string usuario, string contrasena)
        {
            string rol = "";            
            var token = await AcquireTokenAsync( usuario, contrasena);
            ADObject objActiveDirectoryInfo = new ADObject();
            objActiveDirectoryInfo.rol = "";
            objActiveDirectoryInfo.nombreUsuario = "";
            objActiveDirectoryInfo.idError = -1;
            if (token.Length > 0)
            {
                var userGraphServiceClient = getGraphServiceClient(token, "bearer");
                try
                {                    
                    var objGraph = await userGraphServiceClient.Me.Request().GetAsync().ConfigureAwait(false);
                    rol = objGraph.JobTitle;
                    objActiveDirectoryInfo.rol = rol;
                    objActiveDirectoryInfo.nombreUsuario = objGraph.DisplayName;
                    objActiveDirectoryInfo.idError = 0;
                }
                catch (Exception ex)
                {
                    string ex2 = ex.ToString();
                    objActiveDirectoryInfo.idError = -1;
                    objActiveDirectoryInfo.mensajeError = ex2;
                }
            }
            return objActiveDirectoryInfo;
        }
        private async Task<string> AcquireTokenAsync(string username, string password)
        {            
            string tokenEndpoint = "https://login.microsoftonline.com/common/oauth2/token";
           
            string autorize = "https://graph.microsoft.com";

            var body = $"resource={autorize}&client_id={clientId}&grant_type=password&username={HttpUtility.UrlEncode(username)}&password={HttpUtility.UrlEncode(password)}&client_secret={clientsecret}";

            using (var stringContent = new StringContent(body, Encoding.UTF8, "application/x-www-form-urlencoded"))
            {

                var result = await httpClient.PostAsync(tokenEndpoint, stringContent).ContinueWith((response) =>
                {
                    return response.Result.Content.ReadAsStringAsync().Result;
                }).ConfigureAwait(false);

                var tokenResult = System.Text.Json.JsonSerializer.Deserialize<JsonElement>(result);
                string token = string.Empty;
                try
                {
                    token = tokenResult.GetProperty("access_token").GetString();
                }
                catch (Exception ex)
                {
                    token = "";
                }

                return token;
            }
        }

        GraphServiceClient getGraphServiceClient(string token, string Bearer)
        {
                        
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://graph.microsoft.com/v1.0");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            GraphServiceClient graphClient = new GraphServiceClient(client)
            {
                AuthenticationProvider = new DelegateAuthenticationProvider(async (requestMessage) =>
                {
                    requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
                })
            };

            graphClient.BaseUrl = "https://graph.microsoft.com/v1.0";
            return graphClient;

        }

    }
}