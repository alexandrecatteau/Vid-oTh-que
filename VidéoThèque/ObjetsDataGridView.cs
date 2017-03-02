using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidéoThèque
{
    class ObjetsDataGridView
    {
        private string nom;
        private string genre;
        private string vote;
        private string popularite;
        private string maxPage;
        private string id;
        private string nombreResultat;

        #region get set
        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }
        

        public string Genre
        {
            get
            {
                return genre;
            }

            set
            {
                genre = value;
            }
        }

        public string Vote
        {
            get
            {
                return vote;
            }

            set
            {
                vote = value;
            }
        }

        public string MaxPage
        {
            get
            {
                return maxPage;
            }

            set
            {
                maxPage = value;
            }
        }

        public string Popularite
        {
            get
            {
                return popularite;
            }

            set
            {
                popularite = value;
            }
        }

        public string Slogan
        {
            get
            {
                return slogan;
            }

            set
            {
                slogan = value;
            }
        }

        public string TitreOrigine
        {
            get
            {
                return titreOrigine;
            }

            set
            {
                titreOrigine = value;
            }
        }

        public string DateDeSortie
        {
            get
            {
                return dateDeSortie;
            }

            set
            {
                dateDeSortie = value;
            }
        }

        public string Duree
        {
            get
            {
                return duree;
            }

            set
            {
                duree = value;
            }
        }

        public string NombreDeVotes
        {
            get
            {
                return nombreDeVotes;
            }

            set
            {
                nombreDeVotes = value;
            }
        }

        public string MoyenneDesVotes
        {
            get
            {
                return moyenneDesVotes;
            }

            set
            {
                moyenneDesVotes = value;
            }
        }

        public string Budget
        {
            get
            {
                return budget;
            }

            set
            {
                budget = value;
            }
        }

        public string Revenue
        {
            get
            {
                return revenue;
            }

            set
            {
                revenue = value;
            }
        }

        public string Synopsis
        {
            get
            {
                return synopsis;
            }

            set
            {
                synopsis = value;
            }
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

        public string Poster
        {
            get
            {
                return poster;
            }

            set
            {
                poster = value;
            }
        }

        public string Nom1
        {
            get
            {
                return nomFilm;
            }

            set
            {
                nomFilm = value;
            }
        }

        public string NombreResultat
        {
            get
            {
                return nombreResultat;
            }

            set
            {
                nombreResultat = value;
            }
        }

        public string NomSerie
        {
            get
            {
                return nomSerie;
            }

            set
            {
                nomSerie = value;
            }
        }

        public string TitreOrigineSerie
        {
            get
            {
                return titreOrigineSerie;
            }

            set
            {
                titreOrigineSerie = value;
            }
        }

        public string NombreDEpisodesSerie
        {
            get
            {
                return nombreDEpisodesSerie;
            }

            set
            {
                nombreDEpisodesSerie = value;
            }
        }

        public string NombreDeSaisonsSerie
        {
            get
            {
                return nombreDeSaisonsSerie;
            }

            set
            {
                nombreDeSaisonsSerie = value;
            }
        }

        public string EnCoursDeProduction
        {
            get
            {
                return enCoursDeProduction;
            }

            set
            {
                enCoursDeProduction = value;
            }
        }

        public string NombreDeVotesSerie
        {
            get
            {
                return nombreDeVotesSerie;
            }

            set
            {
                nombreDeVotesSerie = value;
            }
        }

        public string MoyenneDesVotesSerie
        {
            get
            {
                return moyenneDesVotesSerie;
            }

            set
            {
                moyenneDesVotesSerie = value;
            }
        }

        public string PosterSerie
        {
            get
            {
                return posterSerie;
            }

            set
            {
                posterSerie = value;
            }
        }

        public string SynopsisSerie
        {
            get
            {
                return synopsisSerie;
            }

            set
            {
                synopsisSerie = value;
            }
        }
        #endregion
        /// <summary>
        /// Objets crées dans les class Json pour ensuite les afficher dans le DGV AffichagePrincipal
        /// </summary>
        /// <param name="nom">Nom du film ou de la série</param>
        /// <param name="genre">Genre du film ou de la série</param>
        /// <param name="vote">Nombre de votes du film ou de la série</param>
        /// <param name="popularite">Popularité du film ou de la série</param>
        /// <param name="maxPage">Maximum de page pour les films ou les séries</param>
        /// <param name="id">id du film ou de la série</param>
        /// <param name="nombreResultat">Nombre total de films ou de séries</param>
        public ObjetsDataGridView(string nom, string genre, string vote,string popularite, string maxPage, string id, string nombreResultat)
        {
            this.nombreResultat = nombreResultat;
            this.nom = nom;
            this.genre = genre;
            this.vote = vote;
            this.popularite = popularite;
            this.maxPage = maxPage;
            this.id = id;
        }
        /// <summary>
        /// Objets crées dans les class JsonResumeFilm pour ensuite les afficher dans le DGV AffichageResumeFilm
        /// </summary>
        /// <param name="nom">Nom du film</param>
        /// <param name="poster">Affiche du film</param>
        /// <param name="slogan">Slogan du film</param>
        /// <param name="titreOrigine">Titre original  du film</param>
        /// <param name="dateDeSortie">Date de sortie  du film</param>
        /// <param name="duree">Durée en minutes du film</param>
        /// <param name="nombreDeVotes">Nombre de vote du film</param>
        /// <param name="moyenneDesVotes">Notes moyennes des votes du film</param>
        /// <param name="budget">Budjet du film</param>
        /// <param name="revenue">Revenue du film</param>
        /// <param name="synopsis">Synopsi du film</param>
        public ObjetsDataGridView(string nom, string poster, string slogan, string titreOrigine, string dateDeSortie, string duree, string nombreDeVotes, string moyenneDesVotes, string budget, string revenue, string synopsis)
        {
            this.nomFilm = nom;
            this.poster = poster;
            this.slogan = slogan;
            this.titreOrigine = titreOrigine;
            this.dateDeSortie = dateDeSortie;
            this.duree = duree;
            this.nombreDeVotes = nombreDeVotes;
            this.moyenneDesVotes = moyenneDesVotes;
            this.budget = budget;
            this.revenue = revenue;
            this.synopsis = synopsis;
        }
        /// <summary>
        /// Objets crées dans les class JsonResumeSerie pour ensuite les afficher dans le DGV AffichageResumeSerie
        /// </summary>
        /// <param name="nomSerie">Nom de la série</param>
        /// <param name="titreOrigineSerie">Titre original du film</param>
        /// <param name="nombreDEpisodesSerie">Nombre total d'épisodes</param>
        /// <param name="nombreDeSaisonsSerie">Nombre total de saisons</param>
        /// <param name="enCoursDeProduction">En cours de production oui/non</param>
        /// <param name="nombreDeVotesSerie">Nombre de votes</param>
        /// <param name="moyenneDesVotesSerie">Moyenne des votes</param>
        /// <param name="posterSerie">Poster de la série</param>
        /// <param name="synopsisSerie">Synopsis de la série</param>
        public ObjetsDataGridView(string nomSerie, string titreOrigineSerie, string nombreDEpisodesSerie, string nombreDeSaisonsSerie, string enCoursDeProduction, string nombreDeVotesSerie, string moyenneDesVotesSerie, string posterSerie, string synopsisSerie)
        {
            this.nomSerie = nomSerie;
            this.titreOrigineSerie = titreOrigineSerie;
            this.nombreDEpisodesSerie = nombreDEpisodesSerie;
            this.nombreDeSaisonsSerie = nombreDeSaisonsSerie;
            this.enCoursDeProduction = enCoursDeProduction;
            this.nombreDeVotesSerie = nombreDeVotesSerie;
            this.moyenneDesVotesSerie = moyenneDesVotesSerie;
            this.posterSerie = posterSerie;
            this.synopsisSerie = synopsisSerie;
        }

        /// <summary>
        /// Variables films
        /// </summary>
        private string nomFilm;
        private string slogan;
        private string titreOrigine;
        private string dateDeSortie;
        private string duree;
        private string nombreDeVotes;
        private string moyenneDesVotes;
        private string budget;
        private string revenue;
        private string synopsis;
        private string poster;
        /// <summary>
        /// Variables séries
        /// </summary>
        private string nomSerie;
        private string titreOrigineSerie;
        private string nombreDEpisodesSerie;
        private string nombreDeSaisonsSerie;
        private string enCoursDeProduction;
        private string nombreDeVotesSerie;
        private string moyenneDesVotesSerie;
        private string posterSerie;
        private string synopsisSerie;

    }
}