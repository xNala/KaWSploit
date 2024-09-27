using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaWSploit
{
    public static class AttackServices
    {
        private static readonly HttpClient client = new HttpClient();


        public static bool finishedScout = false;
        public static bool finishedSteal = false;
        public static bool finishedAssassinate = false;
        public static bool finishedAttack = false;

        public static async Task Scout(long defenderId)
        {
            var url = "https://api.kingdomsatwar.com:443/game/fight/espionage/scout/";

            var tasks = new List<Task>();
            bool stopScouting = false;

            finishedScout = false;

            while (!stopScouting)
            {
                for (int i = 0; i < 10; i++)
                {
                    tasks.Add(Task.Run(async () =>
                    {
                        var formData = new FormUrlEncodedContent(new[]
                        {
                            new KeyValuePair<string, string>("defender_id", defenderId.ToString())
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

                            var jsonResponse = JObject.Parse(responseString);

                            // Check if the response contains "Defender is too weak" or "You are too strong for this opponent"
                            var exceptionMessage = jsonResponse["exception"]?.ToString();
                            if (exceptionMessage == "Not enough units" || exceptionMessage == "Defender is too weak" || exceptionMessage == "You are too strong for this opponent")
                            {
                                stopScouting = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle any exceptions here
                            //MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }));
                }

                // Wait for all 10 tasks to complete
                await Task.WhenAll(tasks);

                // Clear tasks for next set of requests
                tasks.Clear();
            }

            finishedScout = true;
        }

        public static async Task Assassinate(long defenderId)
        {
            var url = "https://api.kingdomsatwar.com:443/game/fight/espionage/assassinate/";

            var tasks = new List<Task>();
            bool stopAssassinating = false;

            finishedAssassinate = false;

            while (!stopAssassinating)
            {
                for (int i = 0; i < 10; i++)
                {
                    tasks.Add(Task.Run(async () =>
                    {
                        var formData = new FormUrlEncodedContent(new[]
                        {
                            new KeyValuePair<string, string>("defender_id", defenderId.ToString())
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

                            var jsonResponse = JObject.Parse(responseString);

                            // Check if the response contains "Defender is too weak" or "You are too strong for this opponent"
                            var exceptionMessage = jsonResponse["exception"]?.ToString();
                            if (exceptionMessage == "Not enough units" || exceptionMessage == "Defender is too weak" || exceptionMessage == "You are too strong for this opponent")
                            {
                                stopAssassinating = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle any exceptions here
                            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }));
                }

                // Wait for all 10 tasks to complete
                await Task.WhenAll(tasks);

                // Clear tasks for next set of requests
                tasks.Clear();
            }

            finishedAssassinate = true;
        }


        public static async Task Steal(long defenderId)
        {
            var url = "https://api.kingdomsatwar.com:443/game/fight/espionage/steal/";

            var tasks = new List<Task>();
            bool stopStealing = false;

            finishedSteal = false;

            while (!stopStealing)
            {
                for (int i = 0; i < 10; i++)
                {
                    tasks.Add(Task.Run(async () =>
                    {
                        var formData = new FormUrlEncodedContent(new[]
                        {
                        new KeyValuePair<string, string>("defender_id", defenderId.ToString())
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

                            var jsonResponse = JObject.Parse(responseString);

                            // Check if the response contains the stopping conditions
                            var exceptionMessage = jsonResponse["exception"]?.ToString();
                            if (exceptionMessage == "Not enough units" || exceptionMessage == "Defender is too weak" || exceptionMessage == "You are too strong for this opponent")
                            {
                                stopStealing = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle any exceptions here
                            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }));
                }

                // Wait for all 10 tasks to complete
                await Task.WhenAll(tasks);

                // Clear tasks for next set of requests
                tasks.Clear();
            }

            finishedSteal = true;
        }


        public static async Task Attack(long defenderId)
        {
            var url = "https://api.kingdomsatwar.com:443/game/fight/attack/";

            var tasks = new List<Task>();
            bool stopAttacking = false;

            finishedAttack = false;

            while (!stopAttacking)
            {
                for (int i = 0; i < 10; i++)
                {
                    tasks.Add(Task.Run(async () =>
                    {
                        var formData = new FormUrlEncodedContent(new[]
                        {
                        new KeyValuePair<string, string>("defender_id", defenderId.ToString())
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

                            var jsonResponse = JObject.Parse(responseString);

                            // Check if the response contains the stopping conditions
                            var exceptionMessage = jsonResponse["exception"]?.ToString();
                            if (exceptionMessage == "Not enough units" || exceptionMessage == "Defender is too weak" || exceptionMessage == "You are too strong for this opponent")
                            {
                                stopAttacking = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle any exceptions here
                            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }));
                }

                // Wait for all 10 tasks to complete
                await Task.WhenAll(tasks);

                // Clear tasks for next set of requests
                tasks.Clear();
            }

            finishedAttack = true;
        }

    }

}
