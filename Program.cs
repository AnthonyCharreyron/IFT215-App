namespace AppliBoursoBank
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static Compte compte;



        [STAThread]
        static void Main()
        {
            initData();
            var controleur = new Controleur();
           

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new Form1(controleur));
        }

        static void initData()
        {
            compte = new Compte(1, "John Doe", 200);

            compte.Deposer(new DateTime(2024, 10, 18), 1000, "Amazon", "Validé", Categorie.Loisirs, "Virement", "Achat d'un appareil photo");
            compte.Deposer(new DateTime(2024, 11, 19), 40, "Uniprix", "En cours", Categorie.Santé, "Carte bancaire", "Achat de médicaments");
            compte.Retirer(new DateTime(2024, 11, 12), 60, "Amazon", "Validé", Categorie.Loisirs, "Carte bancaire", "Retour produit");
            compte.Deposer(new DateTime(2024, 11, 21), 40, "Maxi", "Validé", Categorie.Alimentation, "Espèces", "Courses alimentaires");
            compte.Retirer(new DateTime(2024, 11, 27), 20, "STS", "En cours", Categorie.Transports, "Carte bancaire", "Achat d'un titre de transport");
        
        }
    }
}