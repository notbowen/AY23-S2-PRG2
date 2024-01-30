namespace S10255800_WebAPIClient;

public class Data
{
    public class RootObject
    {
        public Items[] items { get; set; }
        public Api_info api_info { get; set; }
    }

    public class Items
    {
        public string update_timestamp { get; set; }
        public string timestamp { get; set; }
        public Valid_period valid_period { get; set; }
        public General general { get; set; }
        public Periods[] periods { get; set; }
    }

    public class Valid_period
    {
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }

    public class General
    {
        public string forecast { get; set; }
        public Relative_humidity relative_humidity { get; set; }
        public Temperature temperature { get; set; }
        public Wind wind { get; set; }
    }

    public class Relative_humidity
    {
        public int low { get; set; }
        public int high { get; set; }
    }

    public class Temperature
    {
        public int low { get; set; }
        public int high { get; set; }
    }

    public class Wind
    {
        public Speed speed { get; set; }
        public string direction { get; set; }
    }

    public class Speed
    {
        public int low { get; set; }
        public int high { get; set; }
    }

    public class Periods
    {
        public Time time { get; set; }
        public Regions regions { get; set; }
    }

    public class Time
    {
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }

    public class Regions
    {
        public string west { get; set; }
        public string east { get; set; }
        public string central { get; set; }
        public string south { get; set; }
        public string north { get; set; }
    }

    public class Api_info
    {
        public string status { get; set; }
    }
}