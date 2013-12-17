using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglApi.Models
{
    public class User : ITogglModel
    {
        public int id { get; set; }
        public string api_token { get; set; }
        public int default_wid { get; set; }
        public string email { get; set; }
        public string fullname { get; set; }
        public string jquery_timeofday_format { get; set; }
        public string jquery_date_format { get; set; }
        public string timeofday_format { get; set; }
        public string date_format { get; set; }
        public bool store_start_and_stop_time { get; set; }
        public int beginning_of_week { get; set; }
        public string language { get; set; }
        public string image_url { get; set; }
        public bool sidebar_piechart { get; set; }
        public string at { get; set; }
        public string created_at { get; set; }
        public int retention { get; set; }
        public bool record_timeline { get; set; }
        public bool render_timeline { get; set; }
        public bool timeline_enabled { get; set; }
        public bool timeline_experiment { get; set; }
        public bool manual_mode { get; set; }
        public BlogPost new_blog_post { get; set; }
        public bool should_upgrade { get; set; }
        public bool show_offer { get; set; }
        public bool share_experiment { get; set; }
        public bool achievements_enabled { get; set; }
        public string timezone { get; set; }
        public bool openid_enabled { get; set; }
        public bool send_product_emails { get; set; }
        public bool send_weekly_report { get; set; }
        public bool send_timer_notifications { get; set; }
        public Invitation invitation { get; set; }
        public List<Project> projects { get; set; }
        public List<TimeEntry> time_entries { get; set; }
        public List<Workspace> workspaces { get; set; }
        public List<Client> clients { get; set; }
        public bool used_next { get; set; }

        #region Overrides

        public override string ToString()
        {
            var str = String.Format("Name: {0}. Email: {1}. ID: {2}.", this.fullname, this.email, this.id);
            return str;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is User))
                return false;

            User u = obj as User;
            return this.id == u.id;
        }

        #endregion
    }
}
