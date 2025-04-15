namespace FamilyTree
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var tree = FamilyTree.Models.GenerateTestData.GenerateFamilyTree(10);

            tree.PrintFullTree();
            var firstPerson = tree.GetMemberById(1);
            tree.GetMemberById(3).GetPassportData();
            if (firstPerson != null)
            {
                tree.GetDescendants(firstPerson);
                tree.GetAncestors(firstPerson);
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}