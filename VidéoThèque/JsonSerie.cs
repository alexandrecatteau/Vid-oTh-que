using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace VidéoThèque
{
    #region Objets Json

    public class GenreSeries
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class RootObjectGenreSeries
    {
        public List<GenreSeries> genres { get; set; }
    }

    public class ResultSeries
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
    /// <summary>
    /// test
    /// </summary>
    public class RootObjectSeries
    {
        public RootObjectSeries()
        {

        }
        public int page { get; set; }
        public List<ResultSeries> results { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
    }

    #endregion
    internal class JsonSerie
    {
        private RootObjectSeries ro;
        private RootObjectGenreSeries gs;
        private string lienAPI;

        /// <summary>
        ///     Se connecte à l'API pour extraire les séries
        /// </summary>
        /// <param name="annee">Année de sortie</param>
        /// <param name="page">Numéro de la page</param>
        /// <param name="lienApi">URL de l'API</param>
        public JsonSerie(string annee, int page, string lienApi)
        {
            lienAPI = lienApi;
            Annee = annee;
            Page = page;
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var json = wc.DownloadString(
                lienApi + "&first_air_date_year=" + annee + "&page=" + page);
            ro = JsonConvert.DeserializeObject<RootObjectSeries>(json);
        }

        /// <summary>
        ///     Création des objets pour mettre dans la DGV
        /// </summary>
        /// <returns>Une liste d'objets</returns>
        public List<ObjetsDataGridView> CreationObjets()
        {
            var objetsDataGridView = new List<ObjetsDataGridView>();
            var wc1Client = new WebClient();
            wc1Client.Encoding = Encoding.UTF8;
            var json =
                wc1Client.DownloadString(
                    "https://api.themoviedb.org/3/genre/movie/list?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR");
            var rog = JsonConvert.DeserializeObject<RootObjectGenreSeries>(json);
            for (var i = 0; i < ro.results.Count; i++)
            {
                var genreList = Genres(ro.results[i].genre_ids, rog);
                string genreString = null;
                for (var j = 0; j < genreList.Count; j++)
                    genreString += genreList[j] + ", ";
                objetsDataGridView.Add(new ObjetsDataGridView(ro.results[i].name, genreString,
                    ro.results[i].vote_average.ToString(), ro.results[i].popularity.ToString(),
                    ro.total_pages.ToString(), ro.results[i].id.ToString(), ro.total_results.ToString()));
            }
            return objetsDataGridView;
        }

        /// <summary>
        ///     Création d'une liste pour afficher les genres d'une série
        /// </summary>
        /// <param name="i">int qui correspond on genre</param>
        /// <param name="rog">Objet json</param>
        /// <returns>Une liste avec les genres d'une série</returns>
        public List<string> Genres(List<int> i, RootObjectGenreSeries rog)
        {
            var retour = new List<string>();

            for (var j = 0; j < i.Count; j++)
            for (var k = 0; k < rog.genres.Count; k++)
                if (i[j] == rog.genres[k].id)
                    retour.Add(rog.genres[k].name);
            return retour;
        }

        #region GetSet

        public string Annee { get; set; }

        public int Page { get; set; }

        public RootObjectSeries Ro
        {
            get
            {
                return ro;
            }

            set
            {
                ro = value;
            }
        }

        public RootObjectGenreSeries Gs
        {
            get
            {
                return gs;
            }

            set
            {
                gs = value;
            }
        }

        #endregion


    }
}