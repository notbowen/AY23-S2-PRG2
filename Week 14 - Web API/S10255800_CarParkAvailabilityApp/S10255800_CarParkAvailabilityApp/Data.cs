namespace S10255800_CarParkAvailabilityApp;

public class Data
{
    public class RootObject
    {
        public Items[] items { get; set; }
    }

    public class Items
    {
        public DateTime timestamp { get; set; }
        public Carpark_data[] carpark_data { get; set; }
    }

    public class Carpark_data
    {
        public Carpark_info[] carpark_info { get; set; }
        public string carpark_number { get; set; }
        public DateTime update_datetime { get; set; }
    }

    public class Carpark_info
    {
        public string total_lots { get; set; }
        public string lot_type { get; set; }
        public string lots_available { get; set; }
    }
}