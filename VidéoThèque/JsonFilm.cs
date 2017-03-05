using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace VidéoThèque
{
    
    /// <summary>
    ///     Exploitation des données Json des films
    /// </summary>
    internal class JsonFilm
    {
        private RootObject1 ro;
        private string annee;
        private int page;

        /// <summary>
        ///     Se connecte à l'API pour extraire les séries
        /// </summary>
        /// <param name="annee">Année de sortie</param>
        /// <param name="page">Numéro de la page</param>
        /// <param name="lienApi">URL de l'API</param>
        public JsonFilm(string annee, int page, string lienApi)
        {
            this.annee = annee;
            this.page = page;
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var json = wc.DownloadString(
                lienApi + "&include_adult=false&include_video=false&page="
                + page + "&primary_release_year=" + annee);
            ro = JsonConvert.DeserializeObject<RootObject1>(json);
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
            //Téléchargement du texte Json avec tous les genres
            var json =
                wc1Client.DownloadString(
                    "https://api.themoviedb.org/3/genre/movie/list?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR");
            var rog = JsonConvert.DeserializeObject<RootObjectGenre>(json);
            for (var i = 0; i < ro.results.Count; i++)
            {
                var genreList = Genres(ro.results[i].genre_ids, rog);
                string genreString = null;
                for (var j = 0; j < genreList.Count; j++)
                    genreString += genreList[j] + ", ";
                if (genreString != null)
                    genreString = genreString.Substring(0, genreString.Length - 2);
                objetsDataGridView.Add(new ObjetsDataGridView(ro.results[i].original_title,
                    genreString, ro.results[i].vote_count.ToString(), ro.results[i].popularity.ToString(),
                    ro.total_pages.ToString(), ro.results[i].id.ToString(), ro.total_results.ToString()));
            }

            return objetsDataGridView;
        }

        /// <summary>
        ///     Création d'une liste pour afficher les genres d'une série
        /// </summary>
        /// <param name="i">int qui correspond au genre</param>
        /// <param name="rog">Objet json</param>
        /// <returns>Une liste avec les genres d'un film</returns>
        private List<string> Genres(List<int> listInt, RootObjectGenre rog)
        {
            var retour = new List<string>();
            for (var j = 0; j < listInt.Count; j++)
            for (var k = 0; k < rog.genres.Count; k++)
                if (listInt[j] == rog.genres[k].id)
                    retour.Add(rog.genres[k].name);
            return retour;
        }

        #region Objets Json

        public class Result
        {
            public string poster_path { get; set; }
            public bool adult { get; set; }
            public string overview { get; set; }
            public string release_date { get; set; }
            public List<int> genre_ids { get; set; }
            public int id { get; set; }
            public string original_title { get; set; }
            public string original_language { get; set; }
            public string title { get; set; }
            public string backdrop_path { get; set; }
            public double popularity { get; set; }
            public int vote_count { get; set; }
            public bool video { get; set; }
            public double vote_average { get; set; }
        }
        public class RootObject1
        {
            public int page { get; set; }
            public List<Result> results { get; set; }
            public int total_results { get; set; }
            public int total_pages { get; set; }
        }

        public class Genre
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class RootObjectGenre
        {
            public List<Genre> genres { get; set; }
        }

        #endregion
    }
}