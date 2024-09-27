using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace KaWSploit
{

    public class AuthenticationService
    {
        private static readonly HttpClient client = new HttpClient();
        public static string requestAuthToken = "";
        public static string fullAuthToken = "";
        public static bool needs2FA = false;
        public static int attemptsLeft = 10;
        public static bool loggedIn = false;
        public static bool incorrectCredentials = false;

        private static string androidId = "71ec17dffffc9daa";
        private static string advertisingId = "0aad45c2-b1f9-4950-a56a-c7ceb55d7400";
        private static string deviceId = "2da7202e-5204-9915-5f2f-82c3f0c9edfg";


        // Stackoverflow function because I'm hella lazy today - https://stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address
        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<PlayerPacket> Login(string email, string password)
        {
            var url = "https://api.kingdomsatwar.com:443/game/login/oauth/";

            var formData = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("channel_id", "16"),
                new KeyValuePair<string, string>("client_id", "ata.squid.kaw"),
                new KeyValuePair<string, string>("client_version", "324"),
                new KeyValuePair<string, string>("username", email),
                new KeyValuePair<string, string>("device_id", deviceId),
                new KeyValuePair<string, string>("scope", "[\"all\"]"),
                new KeyValuePair<string, string>("version", "186904"),
                new KeyValuePair<string, string>("client_secret", "n0ts0s3cr3t"),
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("client_information", "{\"android_advertising\":\"" + advertisingId + "\",\"android_id\":\"" + androidId + "\",\"app_set_id\":\"2da7202e-5204-9915-5f2f-82c3f0c9edfg\",\"bundle_id\":\"ata.squid.kaw\",\"country\":\"US\",\"dpi\":\"xxhdpi\",\"ether_map\":{\"1\":\"02:00:00:00:00:00\"},\"hardware_version\":\"Google | Nexus 4\",\"language\":\"en\",\"limit_ad_tracking\":false,\"locale\":\"en_US\",\"os_build\":\"Build\\/TQ2B.230505.005.A1\",\"os_name\":\"Android\",\"os_version\":\"13\",\"referrer\":\"utm_source=google-play&utm_medium=organic\",\"screen_size\":\"screen_normal\",\"user_agent\":\"Mozilla\\/5.0 (Linux; Android 13; Nexus 4 Build\\/TQ2B.230505.005.A1; wv) AppleWebKit\\/537.36 (KHTML, like Gecko) Version\\/4.0 Chrome\\/101.0.4951.61 Mobile Safari\\/537.36\",\"version_name\":\"4.83\"}")
            });


            var response = await client.PostAsync(url, formData);
            var responseString = await response.Content.ReadAsStringAsync();
            var jsonResponse = JObject.Parse(responseString);

            // Check if the exception field contains the error message
            if (jsonResponse["exception"] != null && jsonResponse["exception"].ToString() == "The account details you entered are incorrect.")
            {
                incorrectCredentials = true;
                return null;
            }

            var playerPacket = new PlayerPacket(responseString);

            // Check for the access token
            if (!string.IsNullOrEmpty(playerPacket.AccessToken))
            {
                loggedIn = true;
                fullAuthToken = playerPacket.AccessToken;
                return playerPacket;
            }
            else if (string.IsNullOrEmpty(playerPacket.AccessToken) && !string.IsNullOrEmpty(playerPacket.RequestAuthToken))
            {
                needs2FA = true;
                requestAuthToken = playerPacket.RequestAuthToken;
            }

            return null;
        }

        public static async Task<PlayerPacket> Authenticate(string authCode)
        {
            var url = "https://api.kingdomsatwar.com:443/game/login/oauth/";

            // Prepare the data as form data (key-value pairs)
            var formData = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("request_auth_token", requestAuthToken), // Previously saved 2FA token
                new KeyValuePair<string, string>("channel_id", "16"),
                new KeyValuePair<string, string>("client_id", "ata.squid.kaw"),
                new KeyValuePair<string, string>("verification_code", authCode),
                new KeyValuePair<string, string>("client_version", "324"),
                new KeyValuePair<string, string>("device_id", deviceId),
                new KeyValuePair<string, string>("scope", "[\"all\"]"),
                new KeyValuePair<string, string>("version", "186904"),
                new KeyValuePair<string, string>("client_secret", "n0ts0s3cr3t"),
                new KeyValuePair<string, string>("grant_type", "verification"),
                new KeyValuePair<string, string>("client_information", "{\"android_advertising\":\"" + advertisingId + "\",\"android_id\":\"" + androidId + "\",\"app_set_id\":\"2da7202e-5204-9915-5f2f-82c3f0c9edfg\",\"bundle_id\":\"ata.squid.kaw\",\"country\":\"US\",\"dpi\":\"xxhdpi\",\"ether_map\":{\"1\":\"02:00:00:00:00:00\"},\"hardware_version\":\"Google | Nexus 4\",\"language\":\"en\",\"limit_ad_tracking\":false,\"locale\":\"en_US\",\"os_build\":\"Build\\/TQ2B.230505.005.A1\",\"os_name\":\"Android\",\"os_version\":\"13\",\"referrer\":\"utm_source=google-play&utm_medium=organic\",\"screen_size\":\"screen_normal\",\"user_agent\":\"Mozilla\\/5.0 (Linux; Android 13; Nexus 4 Build\\/TQ2B.230505.005.A1; wv) AppleWebKit\\/537.36 (KHTML, like Gecko) Version\\/4.0 Chrome\\/101.0.4951.61 Mobile Safari\\/537.36\",\"version_name\":\"4.83\"}")
            });

            var response = await client.PostAsync(url, formData);
            var responseString = await response.Content.ReadAsStringAsync();
            var jsonResponse = JObject.Parse(responseString);

            // Check if the exception field contains the "Incorrect code" message
            if (jsonResponse["exception"] != null && jsonResponse["exception"].ToString().StartsWith("Incorrect code"))
            {
                // Extract the number of attempts left from the exception message
                var exceptionMessage = jsonResponse["exception"].ToString();
                var match = System.Text.RegularExpressions.Regex.Match(exceptionMessage, @"(\d+) attempts left");
                if (match.Success)
                {
                    attemptsLeft = int.Parse(match.Groups[1].Value); // Save attempts left
                    Console.WriteLine($"Incorrect code. {attemptsLeft} attempts left.");
                }

                return null; // Handle the incorrect code scenario
            }

            // Process the response
            var playerPacket = new PlayerPacket(responseString);

            // Check for the access token
            if (!string.IsNullOrEmpty(playerPacket.AccessToken))
            {
                loggedIn = true;
                fullAuthToken = playerPacket.AccessToken;
                return playerPacket;
            }

            // If authentication fails, reset the logged-in status and 2FA flag
            loggedIn = false;
            if(attemptsLeft == 0)
            {
                needs2FA = false;
            }
            else
            {
                needs2FA = true;
            }

            return null;
        }
    }

    public class PlayerPacket
    {
        public string AccessToken { get; set; }
        public string RequestAuthToken { get; set; }

        public PlayerPacket(string json)
        {
            var data = JObject.Parse(json);
            AccessToken = data["access_token"]?.ToString();
            RequestAuthToken = data["request_auth_token"]?.ToString();
        }
    }
}
