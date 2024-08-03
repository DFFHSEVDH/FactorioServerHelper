using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioDataDemo.Model
{
    class FactorioSettings
    {
        public string name { get; set; }//服务器名称
        public string description { get; set; }//服务器描述
        public string[] tags { get; set; }//服务器tag
        public string _comment_max_players { get; set; }//
        public int max_players { get; set; }
        public string[] _comment_visibility { get; set; }
        public Visibility visibility { get; set; }
        public string _comment_credentials { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string _comment_token { get; set; }
        public string token { get; set; }
        public string game_password { get; set; }
        public string _comment_require_user_verification { get; set; }
        public bool require_user_verification { get; set; }
        public string _comment_max_upload_in_kilobytes_per_second { get; set; }
        public int max_upload_in_kilobytes_per_second { get; set; }
        public string _comment_max_upload_slots { get; set; }
        public int max_upload_slots { get; set; }
        public string _comment_minimum_latency_in_ticks { get; set; }
        public int minimum_latency_in_ticks { get; set; }
        public string _comment_max_heartbeats_per_second { get; set; }
        public int max_heartbeats_per_second { get; set; }
        public string _comment_ignore_player_limit_for_returning_players { get; set; }
        public bool ignore_player_limit_for_returning_players { get; set; }
        public string _comment_allow_commands { get; set; }
        public string allow_commands { get; set; }
        public string _comment_autosave_interval { get; set; }
        public int autosave_interval { get; set; }
        public string _comment_autosave_slots { get; set; }
        public int autosave_slots { get; set; }
        public string _comment_afk_autokick_interval { get; set; }
        public int afk_autokick_interval { get; set; }
        public string _comment_auto_pause { get; set; }
        public bool auto_pause { get; set; }
        public bool only_admins_can_pause_the_game { get; set; }
        public string _comment_autosave_only_on_server { get; set; }
        public bool autosave_only_on_server { get; set; }
        public string _comment_non_blocking_saving { get; set; }
        public bool non_blocking_saving { get; set; }
        public string _comment_segment_sizes { get; set; }
        public int minimum_segment_size { get; set; }
        public int minimum_segment_size_peer_count { get; set; }
        public int maximum_segment_size { get; set; }
        public int maximum_segment_size_peer_count { get; set; }
    }

    public class Visibility
    {
        public bool _public { get; set; }
        public bool lan { get; set; }
    }
}
