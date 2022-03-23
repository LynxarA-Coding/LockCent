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
    class DiscordLog
    {
        public void SendLogUserLog(string type, string data_username, string data)
        {
            string token = "https://discord.com/api/webhooks/956218527688327208/yKrxzSymFaVPYWphGCKzpfrBj34bIoYDVaD__F24LG24I6ZbODrYynkKFe_b4Ndbm7Mq";

            string _bot_username = "LockCent Logger";

            WebRequest wr = (HttpWebRequest)WebRequest.Create(token);

            wr.ContentType = "application/json";

            wr.Method = "POST";
            string json;

            using (var sw = new StreamWriter(wr.GetRequestStream()))
            {
                if (type == "login")
                {
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
                else if (type == "logout")
                {
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
                else if (type == "setting")
                {
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
            var response = (HttpWebResponse)wr.GetResponse();
            wr.Abort();
        }
    }
}
