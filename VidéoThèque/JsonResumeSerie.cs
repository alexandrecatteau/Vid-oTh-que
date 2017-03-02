using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

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
        private RootObjectFilms ros;

        public JsonResumeSerie()
        {
            
        }
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

        public void Serialisation(ObjetsDataGridView test)
        {
            Deserialiser();
            if (ros.list != null)
            {
                string s = JsonConvert.SerializeObject(test);
                ros.list.Add(JsonConvert.DeserializeObject<List>(s));
                string ecrire = JsonConvert.SerializeObject(ros);
                StreamWriter sw = new StreamWriter(@".\Serialisation\seriesFavoris.json", false);
                sw.Write(ecrire);
                sw.Close();
            }
            else
            {
                string s = JsonConvert.SerializeObject(test);
                StreamWriter sw = new StreamWriter(@".\Serialisation\seriesFavoris.json", false);
                sw.Write(s);
                sw.Close();
            }
            
        }

        public void Deserialiser()
        {

            StreamReader sr = new StreamReader(@".\Serialisation\seriesFavoris.json");
            string test = sr.ReadToEnd();
            Debug.Print(test);
            sr.Close();
            if (test == "{\"Nom\":null,\"Genre\":null,\"Vote\":null,\"MaxPage\":null,\"Popularite\":null,\"Slogan\":null,\"TitreOrigine\":null,\"DateDeSortie\":null,\"Duree\":null,\"NombreDeVotes\":null,\"MoyenneDesVotes\":null,\"Budget\":null,\"Revenue\":null,\"Synopsis\":null,\"Id\":null,\"Poster\":null,\"Nom1\":null,\"NombreResultat\":null,\"NomSerie\":\"Kördüğüm\",\"TitreOrigineSerie\":\"Kördüğüm\",\"NombreDEpisodesSerie\":\"3\",\"NombreDeSaisonsSerie\":\"2\",\"EnCoursDeProduction\":\"Production terminée\",\"NombreDeVotesSerie\":\"0\",\"MoyenneDesVotesSerie\":\"0\",\"PosterSerie\":\"/fPuLlGnh4IaZRnsrKg2KijXLzuF.jpg\",\"SynopsisSerie\":null}")
            {
                ros = null;
            }
            else
            {
                ros = JsonConvert.DeserializeObject<RootObjectFilms>(test);
            }
        }
        #region Objets Json sérialisation

        public class List
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

        public class RootObjectFilms
        {
            public List<List> list { get; set; }
        }

        #endregion
    }
}
