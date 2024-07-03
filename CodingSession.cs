
namespace CodingTracker
{
    public class CodingSession
    {
        private int SessionId { get; set; }
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }
        private TimeSpan Duration { get; set; }

        public CodingSession(int sessionId, DateTime startTime, DateTime endTime, TimeSpan duration)
        {
            SessionId = sessionId;
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
