using System;
using Newtonsoft.Json;

namespace AMIMobile
{

    public class LoginItemsModel
    {
        [JsonProperty("userid")]
        public long Userid { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public object Password { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("roleid")]
        public long Roleid { get; set; }

        [JsonProperty("role")]
        public object Role { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("logfail")]
        public object Logfail { get; set; }

        [JsonProperty("expire")]
        public string Expire { get; set; }

        [JsonProperty("lastlog")]
        public string Lastlog { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("visiblp")]
        public string Visiblp { get; set; }
        [JsonProperty("peaid")]
        public object Peaid { get; set; }

        [JsonProperty("posifull")]
        public object Posifull { get; set; }

        [JsonProperty("posiabbr")]
        public object Posiabbr { get; set; }

        [JsonProperty("deptfull")]
        public object Deptfull { get; set; }

        [JsonProperty("deptabbr")]
        public object Deptabbr { get; set; }

        [JsonProperty("deptarea")]
        public object Deptarea { get; set; }

        [JsonProperty("accesstoken")]
        public string Accesstoken { get; set; }

        [JsonProperty("clientinfo")]
        public object Clientinfo { get; set; }

        [JsonProperty("devicename")]
        public object Devicename { get; set; }

        [JsonProperty("platform")]
        public object Platform { get; set; }

        [JsonProperty("iS_REMEMBERME")]
        public bool ISRememberme { get; set; }

        [JsonProperty("magerror")]
        public string Magerror { get; set; }

        [JsonProperty("statuscode")]
        public long Statuscode { get; set; }

        [JsonProperty("iS_ERRORSTATUS")]
        public bool ISErrorstatus { get; set; }
    }


}





