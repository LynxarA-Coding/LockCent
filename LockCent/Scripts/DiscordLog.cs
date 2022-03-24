using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace LockCent.Scripts
{
    /*
     LockCent @2022
     by LynxarA
    */
    class DiscordLog
    {
        // Function that sends Discord Logs about an App
        public void SendLogUserLog(string type, string data_username, string data)
        {
            // Token stored for Discord Webhook
            string token = "https://discord.com/api/webhooks/956218527688327208/yKrxzSymFaVPYWphGCKzpfrBj34bIoYDVaD__F24LG24I6ZbODrYynkKFe_b4Ndbm7Mq";

            // Discord Bot Username (sender name)
            string _bot_username = "LockCent Logger";

            // Creating a new HTTP Request
            WebRequest wr = (HttpWebRequest)WebRequest.Create(token);

            // Request content type
            wr.ContentType = "application/json";

            // Request Method
            wr.Method = "POST";

            // Creating an empty json
            string json;

            using (var sw = new StreamWriter(wr.GetRequestStream()))
            {
                // If log type is LogIn
                if (type == "login")
                {
                    // Embed constructor
                    json = JsonConvert.SerializeObject(new
                    {
                        username = _bot_username,
                        embeds = new[]
                        {
                            new
                            {
                                description = $"Username: **{data_username}** \nTime Stamp: **{DateTime.Now.ToString()}**",
                                title = "New Login",
                                color = "9424384"
                            }
                        }
                    });

                    sw.Write(json);
                }
                else if (type == "logout") // IF Log Type is LogOut
                {
                    // Embed constructor
                    json = JsonConvert.SerializeObject(new
                    {
                        username = _bot_username,
                        embeds = new[]
                        {
                            new
                            {
                                description = $"Username: **{data_username}** \nTime Stamp: **{DateTime.Now.ToString()}**",
                                title = "User Logged Out",
                                color = "16711680"
                            }
                        }
                    });

                    sw.Write(json);
                }
                else if (type == "setting") // If Log Type is Setting
                {
                    // Embed constructor
                    json = JsonConvert.SerializeObject(new
                    {
                        username = _bot_username,
                        embeds = new[]
                        {
                            new
                            {
                                description = $"Username: **{data_username}** \n{data}\nTime Stamp: **{DateTime.Now.ToString()}**",
                                title = "Setting changed",
                                color = "16763904"
                            }
                        }
                    });

                    sw.Write(json);
                }
            }

            // Saving a response in case of an error
            var response = (HttpWebResponse)wr.GetResponse();

            // Aborting a request (request ended)
            wr.Abort();
        }
    }
}
