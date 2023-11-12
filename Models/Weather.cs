namespace lr9.Models
{
    public class Weather
    {
        public Main Main { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public Sys Sys { get; set; }
        public Wind Wind { get; set; }
    }

    public class Main
    {
        public float Temp { get; set; }
        public float Feels_like { get; set; }
        public float Humidity { get; set; }
    }

    public class Sys
    {
        public string Country { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
    }
}