using System;
using LockCent.Encryption;
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
        // Token stored for Discord Webhook
        private readonly string token = "QqF8qfS4xHu2cEBLyg+HJVz/gJZAjGwF9qpwR5QbKDqH6WdJSCt+3XUwnJ1NTp2+812JZlDf2y+cmGLZXc04YnYHo2DYnaeIcN8APSsx6lMUND1wEd31Vw1u+D0KisBmHbvX+aqmkeSoF5L5QuTbqgNS1HRM3aY6ikMV8/nVk3E=";

        // The key
        private readonly byte[] key = { 0x12, 0x56, 0x14, 0x71, 0x0, 0x21, 0x9, 0x17, 0x66, 0x33, 0x56, 0x34, 0x10, 0x13, 0x11, 0x71 };

        // Function that sends Discord Logs about an App
        public void SendLogUserLog(string type, string data_username, string data)
        {
            // Discord Bot Username (sender name)
            string _bot_username = "LockCent Logger";

            // Creating a new HTTP Request
            WebRequest wr = (HttpWebRequest)WebRequest.Create(EFunctions.Decrypt(token, key));

            // Request content type
            wr.ContentType = "application/json";

            // Request Method
            wr.Method = "POST";

            string postDescription = $"Username: **{data_username}** \nTime Stamp: **{DateTime.Now.ToString()}**";
            string dataPostDescription = $"Username: **{data_username}** \n{data}\nTime Stamp: **{DateTime.Now.ToString()}**";

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
                                description = postDescription,
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
                                description = postDescription,
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
                                description = dataPostDescription,
                                title = "Setting changed",
                                color = "16763904"
                            }
                        }
                    });

                    sw.Write(json);
                }
            }

            // Saving a response in case of an error
            wr.GetResponse();

            // Aborting a request (request ended)
            wr.Abort();
        }
    }
}
