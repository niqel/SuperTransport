namespace CrmTcAPI.Models
{
    public class JsonResult
    {
        public object Data { get; set; }
        public string Mensaje { get; set; }

        public JsonResult(object data)
        {
            Data = data;
        }

        public JsonResult()
        {
        }
    }
}