using System.Collections.Generic;

namespace PairingBrackets
{
    public static class Bracket
    {
        private static Dictionary<char, char> bracketCollection;
        public static Dictionary<char, char> BracketCollection 
        {
            get
            {
                if (bracketCollection == null)
                {
                    bracketCollection = new Dictionary<char, char>()
                    {

                        { '{', '}' },
                        { '[', ']' },
                        { '(', ')' }
                    };
                }

                return bracketCollection;
            }
        }
    }
}
