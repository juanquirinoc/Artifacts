using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
  return new HttpResponseMessage(HttpStatusCode.OK);
}
