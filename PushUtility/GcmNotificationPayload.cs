using System.Collections.Generic;
using Newtonsoft.Json;

namespace PushTest.Utility
{
    public class GcmNotificationPayload
    {
        public GcmNotificationPayload(string title, string body, int badge)
        {
            this.title = title;
            this.message = body;

            if (badge >= 0)
            {
                this.badge = badge;
                this.count = badge;
            }
        }

        public string message { get; set; }
        public string title { get; set; }
        public string style { get; set; }

        public int badge { get; set; }
        public int count { get; set; }

        public List<int> ledColor { get; set; } // white LED

        public string iconColor { get; set; }

        public string icon { get; set; }
        public string image { get; set; }

        public string summaryText => "There are %n% notifications";

        [JsonProperty(PropertyName = "content-available")]
        public string contentAvailable => customData != null ? "1" : null;

        public object customData { get; set; }

    }
}
