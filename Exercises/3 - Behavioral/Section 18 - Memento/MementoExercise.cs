namespace Exercises._3___Behavioral.Section_18___Memento
{
    /*
    A TokenMachine is in charge of keeping tokens. Each Token is a reference type with a single numerical value. The machine supports adding tokens and, when it does, it returns a memento representing the state of that system at that given time.

    You are asked to fill in the gaps and implement the Memento design pattern for this scenario. Pay close attention to the situation where a token is fed in as a reference and its value is subsequently changed on that reference - you still need to return the correct system snapshot!
    */

    public class Token
    {
        public int Value = 0;

        public Token(int value)
        {
            this.Value = value;
        }
    }

    public class Memento
    {
        public List<Token> Tokens = new List<Token>();

        public Memento(List<Token> tokens)
        {
            // Deep Copy
            foreach(Token token in tokens)
            {
                Tokens.Add(new Token(token.Value));
            }
        }
    }

    public class TokenMachine
    {
        public List<Token> Tokens = new List<Token>();
        public int current = 0;

        public Memento AddToken(int value)
        {
            return AddToken(new Token(value));
        }

        public Memento AddToken(Token token)
        {
            Tokens.Insert(current++, token);

            return new Memento(Tokens);
        }

        public void Revert(Memento m)
        {
            current = m.Tokens.Count;
            Tokens  = new List<Token>(m.Tokens);
        }
    }
}
