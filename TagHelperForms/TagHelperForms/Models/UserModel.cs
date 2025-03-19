namespace TagHelperForms.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Batch { get; set; }

        public int Age { get; set; }

        public string Married { get; set; }

        public Gender Gender { get; set; }

        

    }
    public enum Gender
    {
        Male, Female
    }
}
