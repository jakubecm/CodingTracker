
namespace CodingTracker
{
    public class CodingSession
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }

        public CodingSession(DateTime startTime, DateTime endTime, TimeSpan? duration = null)
        {
            StartTime = startTime;
            EndTime = endTime;

            if (duration != null)
            {
                Duration = duration.Value;
            }
            else
            {
                Duration = this.CalculateDuration(StartTime, EndTime);
            }
        }

        private TimeSpan CalculateDuration(DateTime start, DateTime end)
        {
            return end - start;
        }
    }
}
