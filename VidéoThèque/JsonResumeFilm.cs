using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace VidéoThèque
{
    internal class JsonResumeFilm
    {
        private readonly RootObject ro;

        public List<RootObjectFilm> tttt;

        /// <summary>
        ///     Connexion à l'API pour afficher le résumé
        /// </summary>
        /// <param name="id">
        ///     ID du film
        /// </param>
        public JsonResumeFilm(string id)
        {
            Id = id;
            try
            {
                var wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                var json =
                    wc.DownloadString("https://api.themoviedb.org/3/movie/" + id +
                                      "?api_key=30666db2f7a024c11b30b58b88983362&language=fr-FR");

                Debug.Print(json);
                ro = JsonConvert.DeserializeObject<RootObject>(json.Replace(",\"runtime\":null", ",\"runtime\": 0").
                    Replace("\"overview\":null", "\"overview\":\"\"").
                    Replace("\"tagline\":null", "\"tagline\":\"\"").
                    Replace(",\"poster_path\":null", ",\"poster_path\":\"\"").
                    Replace("\"budget\":null", "\"budget\":0").
                    Replace("\"original_title\":null", "\"original_title\":\"\"").
                    Replace("\"release_date\":null", "\"release_date\":\"\"").
                    Replace("\"vote_count\":null", "\"vote_count\":0").
                    Replace("\"vote_average\":null", "\"vote_average\":0").
                    Replace("\"revenue\":null", "\"revenue\":0")
                );
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public JsonResumeFilm()
        {
        }

        public string Id { get; set; }

        /// <summary>
        ///     Création des objets pour ensuite les mettres dans AffichageResume
        /// </summary>
        /// <returns>Objet ObjetsDataGridView</returns>
        public ObjetsDataGridView creationDObjet()
        {
            var odgv = new ObjetsDataGridView(ro.title, ro.poster_path, ro.tagline, ro.original_title, ro.release_date,
                ro.runtime.ToString(), ro.vote_count.ToString(), ro.vote_average.ToString(), ro.budget.ToString(),
                ro.revenue.ToString(), ro.overview);
            return odgv;
        }

        /// <summary>
        ///     Sérialisation d'un objet pour le mettre dans un fichier json
        /// </summary>
        /// <param name="test">Objet "ObjetDataGridView</param>
        public void Serialisation(ObjetsDataGridView test)
        {
            Deserialiser();
            var s1 = JsonConvert.SerializeObject(test);
            var rrr = JsonConvert.DeserializeObject<RootObjectFilm>(s1);
            if (tttt == null)
                tttt = new List<RootObjectFilm>();
            tttt.Add(rrr);
            var s2 = JsonConvert.SerializeObject(tttt);
            var sw = new StreamWriter(@".\filmsFavoris.json", false);
            sw.WriteLine(s2);
            sw.Close();
        }

        /// <summary>
        ///     Désérialisation d'un fichier Json
        /// </summary>
        public void Deserialiser()
        {
            tttt = new List<RootObjectFilm>();
            var sr = new StreamReader(@".\filmsFavoris.json");
            var json = sr.ReadToEnd();
            sr.Close();

            tttt = JsonConvert.DeserializeObject<List<RootObjectFilm>>(json);
        }

        #region Objets Json désérialisation API

        public class RootObject
        {
            //public bool adult { get; set; }
            // public string backdrop_path { get; set; }
            // public object belongs_to_collection { get; set; }
            public int budget { get; set; }
            //public List<Genre> genres { get; set; }
            //public string homepage { get; set; }
            public int id { get; set; }
            //public string imdb_id { get; set; }
            //public string original_language { get; set; }
            public string original_title { get; set; }
            public string overview { get; set; }
            public double popularity { get; set; }
            public string poster_path { get; set; }
            //public List<ProductionCompany> production_companies { get; set; }
            //public List<ProductionCountry> production_countries { get; set; }
            public string release_date { get; set; }
            public long revenue { get; set; }
            public int runtime { get; set; }
            //public List<SpokenLanguage> spoken_languages { get; set; }
            public string status { get; set; }
            public string tagline { get; set; }
            public string title { get; set; }
            //public bool video { get; set; }
            public double vote_average { get; set; }
            public int vote_count { get; set; }
        }

        #endregion

        #region Objets Json sérialisation

        public class RootObjectFilm
        {
            public object Nom { get; set; }
            public object Genre { get; set; }
            public object Vote { get; set; }
            public object MaxPage { get; set; }
            public object Popularite { get; set; }
            public string Slogan { get; set; }
            public string TitreOrigine { get; set; }
            public string DateDeSortie { get; set; }
            public string Duree { get; set; }
            public string NombreDeVotes { get; set; }
            public string MoyenneDesVotes { get; set; }
            public string Budget { get; set; }
            public string Revenue { get; set; }
            public string Synopsis { get; set; }
            public object Id { get; set; }
            public string Poster { get; set; }
            public string Nom1 { get; set; }
            public object NombreResultat { get; set; }
            public object NomSerie { get; set; }
            public object TitreOrigineSerie { get; set; }
            public object NombreDEpisodesSerie { get; set; }
            public object NombreDeSaisonsSerie { get; set; }
            public object EnCoursDeProduction { get; set; }
            public object NombreDeVotesSerie { get; set; }
            public object MoyenneDesVotesSerie { get; set; }
            public object PosterSerie { get; set; }
            public object SynopsisSerie { get; set; }
        }

        #endregion
    }
}