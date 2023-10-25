using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
  HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
        response.Content = CreateJsonContent("{\"message\": \"Hello World\"}");
        return response;
}
