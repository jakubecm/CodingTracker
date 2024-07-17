
namespace CodingTracker
{
    public class CodingSession
    {
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }
        private TimeSpan Duration { get; set; }

        public CodingSession(DateTime startTime, DateTime endTime, TimeSpan duration)
        {
            StartTime = startTime;
            EndTime = endTime;
            Duration = duration;
        }

        private TimeSpan CalculateDuration(DateTime start, DateTime end)
        {
            return end - start;
        }
    }
}
