using System.Collections.Generic;

namespace PushTest.Utility
{
    public class ApnsNotificationPayload
    {
        public Dictionary<string, dynamic> aps { get; }

        public ApnsNotificationPayload(string title, string body, int badge)
        {
            aps = new Dictionary<string, dynamic>();

            if (badge >= 0)
            {
                aps.Add("badge", badge);
            }

            if (!string.IsNullOrWhiteSpace(title)  && !string.IsNullOrWhiteSpace(body))
            {
                var alert = new Dictionary<string, dynamic>();
                alert.Add("title", title);
                alert.Add("body", body);

                aps.Add("alert", alert); // add alert only if title and body are present
                aps.Add("sound", "default");
            }
        }

        public ApnsNotificationPayload(string title, string body, int badge, object customData) : this(title, body, badge)
        {
            if (customData != null)
            {
                aps.Add("customData", customData);
                aps.Add("content-available", "1");
            }
        }
    }
}
