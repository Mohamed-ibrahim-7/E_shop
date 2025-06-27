namespace E_shop.ViewModels
{
    public class PersonalInfoVM
    {
        public int Age { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<string> Skills { get; set; } = new();

    }
}
