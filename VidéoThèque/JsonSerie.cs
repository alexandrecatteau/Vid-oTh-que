using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace VidéoThèque
{
    class JsonSerie
    {
        private string annee;
        private int page;
        private RootObject ro;
        private string lienAPI;

        #region GetSet
        public string Annee
        {
            get
            {
                return annee;
            }

            set
            {
                annee = value;
            }
        }

        public int Page
        {
            get
            {
                return page;
            }

            set
            {
                page = value;
            }
        }
        #endregion
        public class Genre
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class RootObjectGenre
        {
            public List<Genre> genres { get; set; }
        }
        public class Result
        {
            public string poster_path { get; set; }
            public double popularity { get; set; }
            public int id { get; set; }
            public string backdrop_path { get; set; }
            public double vote_average { get; set; }
            public string overview { get; set; }
            public string first_air_date { get; set; }
            public List<string> origin_country { get; set; }
            public List<int> genre_ids { get; set; }
            public string original_language { get; set; }
            public int vote_count { get; set; }
            public string name { get; set; }
            public string original_name { get; set; }
        }
        public class RootObject
        {
            public int page { get; set; }
            public List<Result> results { get; set; }
            public int total_results { get; set; }
            public int total_pages { get; set; }
        }

        public JsonSerie(string annee, int page, string lienApi)
        {
            this.lienAPI = lienApi;
            this.annee = annee;
            this.page = page;
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            string json = wc.DownloadString(
                lienApi + "&first_air_date_year=" + annee + "&page=" + page);
            ro = JsonConvert.DeserializeObject<RootObject>(json);
        }
        
        public List<ObjetsDataGridView> CreationObjets()
        {
            WebClient wc1Client = new WebClient();
            wc1Client.Encoding = Encoding.UTF8;
            string json =
                wc1Client.DownloadString(
                    "https://api.themoviedb.org/3/genre/movie/list?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR");
            RootObjectGenre rog = JsonConvert.DeserializeObject<RootObjectGenre>(json);
            List<ObjetsDataGridView> objetsDataGridView = new List<ObjetsDataGridView>();
            for (int i = 0; i < ro.results.Count; i++)
            {
                List<string> genreList = Genres(ro.results[i].genre_ids, rog);
                string genreString = null;
                for (int j = 0; j < genreList.Count; j++)
                {
                    genreString += genreList[j] + ", ";
                }
                objetsDataGridView.Add(new ObjetsDataGridView(ro.results[i].name.ToString(), genreString, ro.results[i].vote_count.ToString(),ro.results[i].vote_count.ToString(), ro.total_pages.ToString(), ro.results[i].id.ToString(), ro.total_results.ToString()));
            }
            return objetsDataGridView;
        }

        public List<string> Genres(List<int> i, RootObjectGenre rog)
        {
            List<string> retour = new List<string>();

            for (int j = 0; j < i.Count; j++)
            {
                
                for (int k = 0; k < rog.genres.Count; k++)
                {
                    if (i[j] == rog.genres[k].id)
                    {
                        retour.Add(rog.genres[k].name);
                    }
                }
            }
            return retour;
        }
        private IEnumerable<ObjetsDataGridView> trieNombreDeVote()
        {
            List<ObjetsDataGridView> test = new List<ObjetsDataGridView>();
            for (int i = 1; i <= ro.total_pages; i++)
            {
                WebClient wc1Client = new WebClient();
                wc1Client.Encoding = Encoding.UTF8;
                if (i%39 == 0)
                {
                    System.Threading.Thread.Sleep(5000);
                }
                string json = wc1Client.DownloadString(lienAPI + "&first_air_date_year=" + annee + "&page=" + i.ToString());
                RootObject root = JsonConvert.DeserializeObject<RootObject>(json);


                //root.results.OrderBy(v => v.vote_count);

                for (int j = 0; j < root.results.Count; j++)
                {
                    test.Add(new ObjetsDataGridView( root.results[j].name.ToString(), root.results[j].genre_ids.ToString(), root.results[j].vote_count.ToString(), root.results[j].popularity.ToString(), root.total_pages.ToString(), root.results[j].id.ToString(), root.total_results.ToString()));
                }
            }
            IOrderedEnumerable<ObjetsDataGridView> test1 = test.OrderBy(v => Convert.ToInt32(v.Vote));
            IEnumerable<ObjetsDataGridView> test2 = test1.Reverse();
            foreach (var VARIABLE in test2)
            {
                Debug.Print(VARIABLE.Nom);
            }
            return test2;
        }
    }
}
