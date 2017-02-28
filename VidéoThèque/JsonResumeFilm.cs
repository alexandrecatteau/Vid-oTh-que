using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Net;
using Newtonsoft.Json;

namespace VidéoThèque
{
    class JsonResumeFilm
    {
        private string id;
        private RootObject ro;
        public JsonResumeFilm(string id)
        {
            this.id = id;
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            string json =
                wc.DownloadString("https://api.themoviedb.org/3/movie/" + id +
                                  "?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR");
            ro = JsonConvert.DeserializeObject<RootObject>(json);

        }

        public ObjetsDataGridView creationDObjet()
        {
            ObjetsDataGridView odgv = new ObjetsDataGridView(ro.title.ToString(), ro.poster_path.ToString(), ro.tagline.ToString(), ro.original_title.ToString(), ro.release_date.ToString(), ro.runtime.ToString(), ro.vote_count.ToString(), ro.vote_average.ToString(), ro.budget.ToString(), ro.revenue.ToString(), ro.overview.ToString());
            return odgv;
        }


        public class Genre
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class ProductionCompany
        {
            public string name { get; set; }
            public int id { get; set; }
        }

        public class ProductionCountry
        {
            public string iso_3166_1 { get; set; }
            public string name { get; set; }
        }

        public class SpokenLanguage
        {
            public string iso_639_1 { get; set; }
            public string name { get; set; }
        }

        public class RootObject
        {
            public bool adult { get; set; }
            public string backdrop_path { get; set; }
            public object belongs_to_collection { get; set; }
            public int budget { get; set; }
            public List<Genre> genres { get; set; }
            public string homepage { get; set; }
            public int id { get; set; }
            public string imdb_id { get; set; }
            public string original_language { get; set; }
            public string original_title { get; set; }
            public string overview { get; set; }
            public double popularity { get; set; }
            public string poster_path { get; set; }
            public List<ProductionCompany> production_companies { get; set; }
            public List<ProductionCountry> production_countries { get; set; }
            public string release_date { get; set; }
            public int revenue { get; set; }
            public int runtime { get; set; }
            public List<SpokenLanguage> spoken_languages { get; set; }
            public string status { get; set; }
            public string tagline { get; set; }
            public string title { get; set; }
            public bool video { get; set; }
            public double vote_average { get; set; }
            public int vote_count { get; set; }
        }


        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
