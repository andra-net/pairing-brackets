using System.Collections.Generic;

namespace PairingBrackets
{
    public class BracketValidator
    {
        public bool Validate(string input)
        {
            var result = true;

            if (string.IsNullOrWhiteSpace(input))
            {
                return result;
            }

            var openBrackets = new Stack<char>();

            foreach (var character in input)
            {
                if (Bracket.BracketCollection.ContainsKey(character)) 
                {
                    openBrackets.Push(character);
                }

                if (Bracket.BracketCollection.ContainsValue(character))
                {
                    if (openBrackets.Count > 0)
                    {
                        var lastOpenBracket = openBrackets.Pop();
                        if (Bracket.BracketCollection[lastOpenBracket] != character)
                        {
                            result = false;
                            break;
                        }
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                    
                }
            }

            if (openBrackets.Count > 0)
            {
                result = false;
            }

            return result;
        }
    }
}
