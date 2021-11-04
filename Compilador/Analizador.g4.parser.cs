using System;
using Antlr4.Runtime;

namespace Compilador
{
    partial class AnalizadorParser
    {
        public void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            throw new Exception("Error in parser at line " + ":" + e.OffendingToken.Column + e.OffendingToken.Line + e.Message);
        }
    }
}
