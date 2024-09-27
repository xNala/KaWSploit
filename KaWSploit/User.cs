using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaWSploit;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class UserProfileService
{
    private static readonly HttpClient client = new HttpClient();
    public static bool usernameFound = false;
    public static long? userId = null;

    public static async Task GetUserIDByUsername(string username)
    {
        var url = "https://api.kingdomsatwar.com:443/game/user/get_profile_by_username/";

        var formData = new FormUrlEncodedContent(new[]
        {
            new KeyValuePair<string, string>("profile_username", username)
        });

        var request = new HttpRequestMessage(HttpMethod.Post, url)
        {
            Content = formData
        };

        request.Headers.Add("Accept", "application/json");
        request.Headers.Add("Authorization", $"Bearer {AuthenticationService.fullAuthToken}");
        request.Headers.Add("User-Agent", "kawdroid/328");

        try
        {
            var response = await client.SendAsync(request);
            var responseString = await response.Content.ReadAsStringAsync();

            // Check the actual response string
            if (string.IsNullOrEmpty(responseString))
            {
                MessageBox.Show("Response was empty or null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Try parsing the JSON response
            try
            {
                var jsonResponse = JObject.Parse(responseString);

                // Set the userId
                userId = jsonResponse["user_id"]?.Value<long>();
                usernameFound = userId.HasValue;


            }
            catch (JsonReaderException ex)
            {
                // Catch JSON errors and show them in a MessageBox
                //MessageBox.Show($"JSON Parsing Error: {ex.Message}\nResponse: {responseString}", "JSON Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            // Catch any other errors and show them in a MessageBox
            //MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
