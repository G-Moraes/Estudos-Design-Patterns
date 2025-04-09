using System.Text;

namespace Exercises._3___Behavioral.Section_15___Interpreter
{
    /*
        You are asked to write an expression processor for simple numeric expressions with the following constraints:

        - Expressions use integral values (e.g., '13' ), single-letter variables defined in Variables, as well as + and - operators only
        - There is no need to support braces or any other operations
        - If a variable is not found in Variables (or if we encounter a variable with >1 letter, e.g. ab), the evaluator returns 0 (zero)
        - In case of any parsing failure, evaluator returns 0
        Example:

        - Calculate("1+2+3")  should return 6
        - Calculate("1+2+xy")  should return 0
        - Calculate("10-2-x")  when x=3 is in Variables should return 5

    */

    public interface IElement
    {
        int Value { get; }
    }

    public class Integer : IElement
    {
        public Integer(int value)
        {
            Value = value;
        }

        public int Value { get; }
    }

    public class Variable : IElement
    {
        public char Name;

        public Variable(char name)
        {
            Name = name;
        }

        public int Value { get; set; }
    }

    public class BinaryOperation : IElement
    {
        public enum Type
        {
            Addition, Subtraction
        }

        public Type myType;
        public IElement Left, Right;

        public int Value
        {
            get
            {
                switch (myType)
                {
                    case Type.Addition:
                        return Left.Value + Right.Value;
                    case Type.Subtraction:
                        return Left.Value - Right.Value;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }

    public class Token
    {
        public enum Type
        {
            Integer, Variable, Plus, Minus, LeftParenthesis, RightParenthesis
        }

        public Type MyType;
        public string Text;

        public Token(Type myType, string text)
        {
            MyType  = myType;
            Text    = text;
        }

        public override string ToString()
        {
            return $"\'{Text}\'";
        }
    }

    public class ExpressionProcessor
    {
        public Dictionary<char, int> Variables = new Dictionary<char, int>();

        static List<Token> Lex(string input)
        {
            List<Token> result = new List<Token>();

            for(int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '+':
                        result.Add(new Token(Token.Type.Plus, "+"));
                        break;
                    case '-':
                        result.Add(new Token(Token.Type.Minus, "-"));
                        break;
                    case '(':
                        result.Add(new Token(Token.Type.LeftParenthesis, "("));
                        break;
                    case ')':
                        result.Add(new Token(Token.Type.RightParenthesis, ")"));
                        break;
                    default:

                        if (char.IsLetter(input[i]))
                        {
                            result.Add(new Token(Token.Type.Variable, input[i].ToString()));
                            break;
                        }

                        StringBuilder sb = new StringBuilder(input[i].ToString());

                        if (i + 1 == input.Length)
                        {
                            result.Add(new Token(Token.Type.Integer, sb.ToString()));
                            break;
                        }

                        for (int j = i + 1; j < input.Length; ++j)
                        {
                            if (!char.IsDigit(input[j]))
                            {
                                break;
                            }

                            sb.Append(input[j]);
                            i++;
                        }

                        result.Add(new Token(Token.Type.Integer, sb.ToString()));
                        break;
                }
            }

            return result;
        }

        private IElement Parse(IReadOnlyList<Token> tokens, Dictionary<char, int> variables)
        {
            if(tokens.Count == 1)
            {
                switch (tokens[0].MyType)
                {
                    case Token.Type.Integer:
                        return new Integer(int.Parse(tokens[0].Text));
                    case Token.Type.Variable:

                        if (!variables.ContainsKey(char.Parse(tokens[0].Text)))
                        {
                            return null;
                        }

                        Variable variable = new Variable(char.Parse(tokens[0].Text));

                        variable.Value = variables[variable.Name];

                        return variable;
                }
            }

            int binaryOperationCount = tokens.Where(token => token.MyType == Token.Type.Plus || token.MyType == Token.Type.Minus).Count();
            int i = 0;
            List<BinaryOperation> binaryOperations = new List<BinaryOperation>();

            for (int binaryOpIndex = 0; binaryOpIndex < binaryOperationCount; binaryOpIndex++)
            {
                BinaryOperation binaryOp = new BinaryOperation();
                bool hasLeftHandSideBeenInitialized = binaryOperations.Count > 0 ? true : false;

                if (hasLeftHandSideBeenInitialized)
                {
                    binaryOp.Left = binaryOperations.Last();
                }

                for (; i < tokens.Count; i++)
                {
                    Token token = tokens[i];

                    switch (token.MyType)
                    {
                        case Token.Type.Integer:
                            Integer integer = new Integer(int.Parse(token.Text));

                            if (!hasLeftHandSideBeenInitialized)
                            {
                                binaryOp.Left = integer;
                                hasLeftHandSideBeenInitialized = true;
                                break;
                            }

                            binaryOp.Right = integer;
                            break;
                        case Token.Type.Plus:
                            binaryOp.myType = BinaryOperation.Type.Addition;
                            break;
                        case Token.Type.Minus:
                            binaryOp.myType = BinaryOperation.Type.Subtraction;
                            break;
                        case Token.Type.LeftParenthesis:
                            int j = i;

                            for (; j < tokens.Count; ++i)
                            {
                                if (tokens[j].MyType == Token.Type.RightParenthesis)
                                {
                                    break;
                                }
                            }

                            List<Token> subExpression = tokens.Skip(i + 1).Take(j - i - 1).ToList();

                            IElement element = Parse(subExpression, variables);

                            if (!hasLeftHandSideBeenInitialized)
                            {
                                binaryOp.Left = element;
                                hasLeftHandSideBeenInitialized = true;
                                break;
                            }

                            binaryOp.Right = element;
                            break;

                        case Token.Type.Variable:

                            if (!variables.ContainsKey(char.Parse(token.Text)) || 
                                (i + 1 < tokens.Count && tokens[i + 1].MyType == Token.Type.Variable))
                            {
                                return null;
                            }

                            Variable variable   = new Variable(char.Parse(token.Text));

                            variable.Value      = variables[variable.Name];

                            if (!hasLeftHandSideBeenInitialized)
                            {
                                binaryOp.Left = variable;
                                hasLeftHandSideBeenInitialized = true;
                                break;
                            }

                            binaryOp.Right = variable;
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    if(binaryOp.Right != null && binaryOp.Left != null)
                    {
                        i++;
                        break;
                    }
                }

                binaryOperations.Add(binaryOp);
            }            

            return binaryOperations.Last();
        }

        public int Calculate(string expression)
        {
            // Lexing the expression
            List<Token> tokens = Lex(expression);

            // Parsing the expression;
            IElement result = Parse(tokens, Variables);

            if(result == null)
            {
                return 0;
            }

            return result.Value;
        }
    }
}
