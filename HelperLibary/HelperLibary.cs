namespace HelperLibary
{
    public class Helper
    {
        public static string CreateBookCode(string name,int number)
        {
            string code = $"{char.ToUpper(name[0])}{char.ToUpper(name[1])}{number}";
            return code;
        }
    }
}
