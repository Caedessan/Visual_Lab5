namespace Visual_Lab5
{

    public class ParticipantInfo
    {
        public string? Country { get; set; }
        public string? Name { get; set; }
        public string? TeamName { get; set; }
        public string? Number { get; set; }
        public DateTime BirthDate { get; set; } = DateTime.UtcNow;
        public int? Height { get; set; }
        public int? Weight { get; set; }
    }
    internal static class Program
    {
        public static List<ParticipantInfo> Participants = new List<ParticipantInfo>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
