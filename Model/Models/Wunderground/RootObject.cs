namespace Model.Models.Wunderground
{
    public class RootObject
    {
        public Response response { get; set; }
        public CurrentObservation current_observation { get; set; }
    }
}