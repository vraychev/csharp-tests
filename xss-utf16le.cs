using System.Web;

public class XSSUtf16LE : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        string pageName = context.Request.QueryString["page"];
        context.Response.Write("Кирилица из нот дед. The page \"" + pageName + "\" was not found.");
    }
}