using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Net.TMDb;
using System.Threading;

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
        #region Objets Json
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
        #endregion
        /// <summary>
        /// Se connecte à l'API pour extraire les séries
        /// </summary>
        /// <param name="annee">Année de sortie</param>
        /// <param name="page">Numéro de la page</param>
        /// <param name="lienApi">URL de l'API</param>
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

        /// <summary>
        /// Création des objets pour mettre dans la DGV
        /// </summary>
        /// <returns>Une liste d'objets</returns>
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
                objetsDataGridView.Add(new ObjetsDataGridView(ro.results[i].name.ToString(), genreString, ro.results[i].vote_average.ToString(),ro.results[i].popularity.ToString(), ro.total_pages.ToString(), ro.results[i].id.ToString(), ro.total_results.ToString()));
            }
            return objetsDataGridView;
        }
        /// <summary>
        /// Création d'une liste pour afficher les genres d'une série
        /// </summary>
        /// <param name="i">int qui correspond on genre</param>
        /// <param name="rog">Objet json</param>
        /// <returns>Une liste avec les genres d'une série</returns>
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
    }
}
