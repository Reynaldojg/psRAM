namespace psRAM_View
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1()); // Aquí se abre tu Form1
        }
    }
}