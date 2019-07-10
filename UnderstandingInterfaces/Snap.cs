namespace UnderstandingInterfaces
{
    public class Snap
    {
        public int SnapId { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }

        public override string ToString()
        {
            return string.Format("SnapId: {0},\tSnap Lat: {1}, \tSnap Lon: {2}", SnapId, Lat, Lon);
        }
    }
}