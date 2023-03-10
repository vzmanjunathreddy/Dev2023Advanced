namespace UtitlityLibrary
{
    // Extension Method
    // Extending the functionality of a type
    // Static Class with Static Method and pass param of type what you are extending with this keyword
    //"Fruit" " fruit"
    public  static class WordLibrary
    {
        public static bool StartswithUpperchar(this string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return false;
            }
            return char.IsUpper(word[0]);              
         
        }

        public static bool StartswithLowerchar(this string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return false;
            }
            return char.IsLower(word[0]);

        }
    }
}