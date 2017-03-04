namespace VidéoThèque
{
    internal class ObjetsDataGridView
    {
        /// <summary>
        ///     Variables films
        /// </summary>
        private string nomFilm;

        /// <summary>
        ///     Variables séries
        /// </summary>
        private string nomSerie;

        /// <summary>
        ///     Objets crées dans les class Json pour ensuite les afficher dans le DGV AffichagePrincipal
        /// </summary>
        /// <param name="nom">Nom du film ou de la série</param>
        /// <param name="genre">GenreSeries du film ou de la série</param>
        /// <param name="vote">Nombre de votes du film ou de la série</param>
        /// <param name="popularite">Popularité du film ou de la série</param>
        /// <param name="maxPage">Maximum de page pour les films ou les séries</param>
        /// <param name="id">id du film ou de la série</param>
        /// <param name="nombreResultat">Nombre total de films ou de séries</param>
        public ObjetsDataGridView(string nom, string genre, string vote, string popularite, string maxPage, string id,
            string nombreResultat)
        {
            NombreResultat = nombreResultat;
            Nom = nom;
            Genre = genre;
            Vote = vote;
            Popularite = popularite;
            MaxPage = maxPage;
            Id = id;
        }

        /// <summary>
        ///     Objets crées dans les class JsonResumeFilm pour ensuite les afficher dans le DGV AffichageResumeFilm
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
        public ObjetsDataGridView(string nom, string poster, string slogan, string titreOrigine, string dateDeSortie,
            string duree, string nombreDeVotes, string moyenneDesVotes, string budget, string revenue, string synopsis)
        {
            nomFilm = nom;
            Poster = poster;
            Slogan = slogan;
            TitreOrigine = titreOrigine;
            DateDeSortie = dateDeSortie;
            Duree = duree;
            NombreDeVotes = nombreDeVotes;
            MoyenneDesVotes = moyenneDesVotes;
            Budget = budget;
            Revenue = revenue;
            Synopsis = synopsis;
        }

        /// <summary>
        ///     Objets crées dans les class JsonResumeSerie pour ensuite les afficher dans le DGV AffichageResumeSerie
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
        public ObjetsDataGridView(string nomSerie, string titreOrigineSerie, string nombreDEpisodesSerie,
            string nombreDeSaisonsSerie, string enCoursDeProduction, string nombreDeVotesSerie,
            string moyenneDesVotesSerie, string posterSerie, string synopsisSerie)
        {
            this.nomSerie = nomSerie;
            TitreOrigineSerie = titreOrigineSerie;
            NombreDEpisodesSerie = nombreDEpisodesSerie;
            NombreDeSaisonsSerie = nombreDeSaisonsSerie;
            EnCoursDeProduction = enCoursDeProduction;
            NombreDeVotesSerie = nombreDeVotesSerie;
            MoyenneDesVotesSerie = moyenneDesVotesSerie;
            PosterSerie = posterSerie;
            SynopsisSerie = synopsisSerie;
        }

        #region get set

        public string Nom { get; set; }


        public string Genre { get; set; }

        public string Vote { get; set; }

        public string MaxPage { get; set; }

        public string Popularite { get; set; }

        public string Slogan { get; set; }

        public string TitreOrigine { get; set; }

        public string DateDeSortie { get; set; }

        public string Duree { get; set; }

        public string NombreDeVotes { get; set; }

        public string MoyenneDesVotes { get; set; }

        public string Budget { get; set; }

        public string Revenue { get; set; }

        public string Synopsis { get; set; }

        public string Id { get; set; }

        public string Poster { get; set; }

        public string Nom1
        {
            get { return nomFilm; }

            set { nomFilm = value; }
        }

        public string NombreResultat { get; set; }

        public string NomSerie
        {
            get { return nomSerie; }

            set { nomSerie = value; }
        }

        public string TitreOrigineSerie { get; set; }

        public string NombreDEpisodesSerie { get; set; }

        public string NombreDeSaisonsSerie { get; set; }

        public string EnCoursDeProduction { get; set; }

        public string NombreDeVotesSerie { get; set; }

        public string MoyenneDesVotesSerie { get; set; }

        public string PosterSerie { get; set; }

        public string SynopsisSerie { get; set; }

        #endregion
    }
}