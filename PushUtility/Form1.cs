using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PushSharp.Apple;
using PushSharp.Core;
using PushSharp.Google;

namespace PushTest.Utility
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbiOS.Checked)
                {
                    ApnsConfiguration config = new ApnsConfiguration(chkProduction.Checked ? ApnsConfiguration.ApnsServerEnvironment.Production : ApnsConfiguration.ApnsServerEnvironment.Sandbox, File.ReadAllBytes(txtCertFilename.Text), txtCertPassword.Text);
                    // Create a new broker
                    var apnsBroker = new ApnsServiceBroker(config);

                    // Wire up events
                    apnsBroker.OnNotificationFailed += (notification, aggregateEx) =>
                    {

                        aggregateEx.Handle(ex =>
                        {

                            // See what kind of exception it was to further diagnose
                            if (ex is ApnsNotificationException)
                            {
                                var notificationException = (ApnsNotificationException) ex;

                                // Deal with the failed notification
                                var apnsNotification = notificationException.Notification;
                                var statusCode = notificationException.ErrorStatusCode;

                                Console.WriteLine($"Apple Notification Failed: ID={apnsNotification.Identifier}, Code={statusCode}");

                            }
                            else
                            {
                                // Inner exception might hold more useful information like an ApnsConnectionException           
                                Console.WriteLine($"Apple Notification Failed for some unknown reason : {ex.InnerException}");
                            }

                            // Mark it as handled
                            return true;
                        });
                    };

                    apnsBroker.OnNotificationSucceeded += (notification) =>
                    {
                        Console.WriteLine("Apple Notification Sent!");
                    };

                    // Start the broker
                    apnsBroker.Start();
                    // Queue a notification to send
                    apnsBroker.QueueNotification(new ApnsNotification
                    {
                        DeviceToken = txtToken.Text,
                        Payload = JObject.Parse(JsonConvert.SerializeObject(CreateApnsNotificationPayload(txtTitle.Text, txtMessage.Text, int.Parse(txtBadgeCount.Text))))
                    });

                }
                else
                {
                    // Configuration
                    var config = new GcmConfiguration(txtGoogleApiKey.Text);

                    // Create a new broker
                    var gcmBroker = new GcmServiceBroker(config);

                    // Wire up events
                    gcmBroker.OnNotificationFailed += (notification, aggregateEx) =>
                    {

                        aggregateEx.Handle(ex =>
                        {

                            // See what kind of exception it was to further diagnose
                            if (ex is GcmNotificationException)
                            {
                                var notificationException = (GcmNotificationException) ex;

                                // Deal with the failed notification
                                var gcmNotification = notificationException.Notification;
                                var description = notificationException.Description;

                                Console.WriteLine($"GCM Notification Failed: ID={gcmNotification.MessageId}, Desc={description}");
                            }
                            else if (ex is GcmMulticastResultException)
                            {
                                var multicastException = (GcmMulticastResultException) ex;

                                foreach (var succeededNotification in multicastException.Succeeded)
                                {
                                    Console.WriteLine($"GCM Notification Failed: ID={succeededNotification.MessageId}");
                                }

                                foreach (var failedKvp in multicastException.Failed)
                                {
                                    var n = failedKvp.Key;
                                    Console.WriteLine($"GCM Notification Failed: ID={n.MessageId}, Desc={failedKvp.Value}");
                                }

                            }
                            else if (ex is DeviceSubscriptionExpiredException)
                            {
                                var expiredException = (DeviceSubscriptionExpiredException) ex;

                                var oldId = expiredException.OldSubscriptionId;
                                var newId = expiredException.NewSubscriptionId;

                                Console.WriteLine($"Device RegistrationId Expired: {oldId}");

                                if (!string.IsNullOrWhiteSpace(newId))
                                {
                                    // If this value isn't null, our subscription changed and we should update our database
                                    Console.WriteLine($"Device RegistrationId Changed To: {newId}");
                                }
                            }
                            else if (ex is RetryAfterException)
                            {
                                var retryException = (RetryAfterException) ex;
                                // If you get rate limited, you should stop sending messages until after the RetryAfterUtc date
                                Console.WriteLine($"GCM Rate Limited, don't send more until after {retryException.RetryAfterUtc}");
                            }
                            else
                            {
                                Console.WriteLine("GCM Notification Failed for some unknown reason");
                            }

                            // Mark it as handled
                            return true;
                        });
                    };

                    gcmBroker.OnNotificationSucceeded += (notification) =>
                    {
                        Console.WriteLine("GCM Notification Sent!");
                    };

                    // Start the broker
                    gcmBroker.Start();


                    // Queue a notification to send
                    gcmBroker.QueueNotification(new GcmNotification
                    {
                        RegistrationIds = new List<string> {txtToken.Text},
                        Data = JObject.Parse(JsonConvert.SerializeObject(CreateGcmNotificationPayload(txtMessage.Text, txtTitle.Text, int.Parse(txtBadgeCount.Text))))
                    });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static ApnsNotificationPayload CreateApnsNotificationPayload(string title, string body, int badge)
        {
            ApnsNotificationPayload payload = new ApnsNotificationPayload(title, body, badge);
            return payload;
        }

        private static GcmNotificationPayload CreateGcmNotificationPayload(string body, string title, int badge, string icon = null)
        {
            GcmNotificationPayload data = new GcmNotificationPayload(title, body, badge);

            data.ledColor = new List<int>() { 0, 255, 255, 255 }; // white
            data.style = "inbox";

            if (!string.IsNullOrWhiteSpace(icon))
                data.icon = icon;

            return data;
        }

        private void btnSelectCert_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "p12 certificate (.p12)|*.p12";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtCertFilename.Text = dialog.FileName;
            }
        }
    }
}
