using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace VidéoThèque
{
    #region Objets Json

    public class CreatedBy
    {
        public int id { get; set; }
        public string name { get; set; }
        public string profile_path { get; set; }
    }

    public class Genre
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Network
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class ProductionCompany
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Season
    {
        public string air_date { get; set; }
        public int episode_count { get; set; }
        public int id { get; set; }
        public string poster_path { get; set; }
        public int season_number { get; set; }
    }

    public class RootObject
    {
        public string backdrop_path { get; set; }
        public List<CreatedBy> created_by { get; set; }
        public List<int> episode_run_time { get; set; }
        public string first_air_date { get; set; }
        public List<Genre> genres { get; set; }
        public string homepage { get; set; }
        public int id { get; set; }
        public bool in_production { get; set; }
        public List<string> languages { get; set; }
        public string last_air_date { get; set; }
        public string name { get; set; }
        public List<Network> networks { get; set; }
        public int number_of_episodes { get; set; }
        public int number_of_seasons { get; set; }
        public List<string> origin_country { get; set; }
        public string original_language { get; set; }
        public string original_name { get; set; }
        public string overview { get; set; }
        public double popularity { get; set; }
        public string poster_path { get; set; }
        public List<ProductionCompany> production_companies { get; set; }
        public List<Season> seasons { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }
    }

    #endregion
    class JsonResumeSerie
    {
        private string id;
        private RootObject ro;
        public JsonResumeSerie(string id)
        {
            this.id = id;
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            string json = wc.DownloadString("https://api.themoviedb.org/3/tv/" + id + "?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR").Replace("\"number_of_episodes\":null", "\"number_of_episodes\":0");
            ro = JsonConvert.DeserializeObject<RootObject>(json.Replace("\"number_of_episodes\":null", "\"number_of_episodes\":0"));
        }
        public ObjetsDataGridView CreationObjet()
        {
            string enCoursDeProduction = null;
            if (ro.in_production == true)
            {
                enCoursDeProduction = "En cours de production";
            }
            else
            {
                enCoursDeProduction = "Production terminée";
            }
            ObjetsDataGridView odgv = new ObjetsDataGridView(ro.name, ro.original_name, ro.number_of_episodes.ToString(), 
                ro.number_of_seasons.ToString(), enCoursDeProduction, ro.vote_count.ToString(), ro.vote_average.ToString(), ro.poster_path, ro.overview);
            return odgv;
        }

    }
}
