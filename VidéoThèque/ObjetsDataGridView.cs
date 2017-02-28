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
                return nom1;
            }

            set
            {
                nom1 = value;
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
        #endregion
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

        public ObjetsDataGridView(string nom, string poster, string slogan, string titreOrigine, string dateDeSortie, string duree, string nombreDeVotes, string moyenneDesVotes, string budget, string revenue, string synopsis)
        {
            this.nom1 = nom;
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
        private string nom1;
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
    }
}