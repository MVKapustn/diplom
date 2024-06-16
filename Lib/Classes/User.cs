namespace AdditionalLibrary.Classes
{
    public class User
    {
        public uint Id { get; set; }
        public uint LowTestResult { get; set; }
        public uint MedTestResult { get; set; }
        public uint HighTestResult { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
