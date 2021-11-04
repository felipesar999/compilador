using System;
using System.Collections.Generic;
using Antlr4.Runtime;

namespace Compilador
{
    class AnalisisLexico
    {
        public List<string> GetUnkownTokens(IList<IToken> Tokens)
        {
            var Source = 0;
            List<string> tempList = new List<string>();
            for (int i = 0; i < Tokens.Count; i++)
            {
                Source = Tokens[i].Type;
                if (Source == 32)
                {
                    tempList.Add("Simbolo desconocido: " + Tokens[i].Text);
                }
            }
            return tempList;
        }

    }

    class AnalisisSintactico
    {
        public static string Arbol { get; set; }
    }

    public class AnalisisSintacticoErrores : IAntlrErrorListener<IToken>
    {
        public static string GetSyntaxError { get; set; }

        public void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            //throw new Exception(msg + " en la linea: " + line + "; en la posicion: " + charPositionInLine);
            Console.WriteLine(msg + " en la linea: " + line + "; en la posición: " + charPositionInLine);
            GetSyntaxError = (string.Format("Expresion invalida: {0} en la linea: {1}, en la posición: {2} ", msg.Replace("no viable alternative at input", string.Empty), line, charPositionInLine));

        }
    }

    public class AnalisisSemanticoSimbolos
    {
        public string tipodato { get; set; }

        public string identificador { get; set; }

        public string valor { get; set; }
    }
}
