﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Administrador\Documents\Clases\Compiladores\Compilador\Compilador\Analizador.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Compilador {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class AnalizadorLexer : Lexer {
	public const int
		ACCESSM=1, PROGRAM=2, VAR=3, INT=4, PRINT=5, PLUS=6, SUBS=7, PROD=8, DIV=9, 
		AND=10, OR=11, NOT=12, GT=13, LT=14, GEQ=15, LEG=16, EQ=17, NEQ=18, ASSIGN=19, 
		PAREN_A=20, PAREN_C=21, LLAV_A=22, LLAV_C=23, CORCH_A=24, CORCH_C=25, 
		IDENTIFIER=26, INTEGERS=27, SEMICOLON=28, COLON=29, STRING=30, CHAR=31, 
		ESC_SEQ=32, Unknown=33, WS=34;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"ACCESSM", "PROGRAM", "VAR", "INT", "PRINT", "PLUS", "SUBS", "PROD", "DIV", 
		"AND", "OR", "NOT", "GT", "LT", "GEQ", "LEG", "EQ", "NEQ", "ASSIGN", "PAREN_A", 
		"PAREN_C", "LLAV_A", "LLAV_C", "CORCH_A", "CORCH_C", "IDENTIFIER", "INTEGERS", 
		"SEMICOLON", "COLON", "STRING", "CHAR", "ESC_SEQ", "Unknown", "WS"
	};


	    protected const int EOF = Eof;
	    protected const int HIDDEN = Hidden;


	public AnalizadorLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, null, "'program'", "'var'", "'int'", "'print'", "'+'", "'-'", "'*'", 
		"'/'", "'&&'", "'||'", "'!'", "'>'", "'<'", "'>='", "'<='", "'=='", "'!='", 
		"'='", "'('", "')'", "'{'", "'}'", "'['", "']'", null, null, "';'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, "ACCESSM", "PROGRAM", "VAR", "INT", "PRINT", "PLUS", "SUBS", "PROD", 
		"DIV", "AND", "OR", "NOT", "GT", "LT", "GEQ", "LEG", "EQ", "NEQ", "ASSIGN", 
		"PAREN_A", "PAREN_C", "LLAV_A", "LLAV_C", "CORCH_A", "CORCH_C", "IDENTIFIER", 
		"INTEGERS", "SEMICOLON", "COLON", "STRING", "CHAR", "ESC_SEQ", "Unknown", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Analizador.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2$\xFA\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3"+
		"\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2"+
		"\x3\x2\x3\x2\x5\x2^\n\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6"+
		"\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3"+
		"\v\x3\f\x3\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10"+
		"\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x14"+
		"\x3\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x18\x3\x18\x3\x19"+
		"\x3\x19\x3\x1A\x3\x1A\x3\x1B\x3\x1B\a\x1B\xA6\n\x1B\f\x1B\xE\x1B\xA9\v"+
		"\x1B\x3\x1C\x6\x1C\xAC\n\x1C\r\x1C\xE\x1C\xAD\x3\x1D\x3\x1D\x3\x1E\x3"+
		"\x1E\x3\x1F\x3\x1F\x3\x1F\a\x1F\xB7\n\x1F\f\x1F\xE\x1F\xBA\v\x1F\x3\x1F"+
		"\x3\x1F\x3 \x3 \x3 \x5 \xC1\n \x3 \x3 \x3!\x3!\x3!\x3\"\x3\"\x3\"\x3\""+
		"\x3\"\x6\"\xCD\n\"\r\"\xE\"\xCE\x3\"\x3\"\x6\"\xD3\n\"\r\"\xE\"\xD4\x3"+
		"\"\x6\"\xD8\n\"\r\"\xE\"\xD9\x3\"\x6\"\xDD\n\"\r\"\xE\"\xDE\x3\"\x6\""+
		"\xE2\n\"\r\"\xE\"\xE3\x3\"\x6\"\xE7\n\"\r\"\xE\"\xE8\x3\"\x6\"\xEC\n\""+
		"\r\"\xE\"\xED\x3\"\x6\"\xF1\n\"\r\"\xE\"\xF2\x5\"\xF5\n\"\x3#\x3#\x3#"+
		"\x3#\x2\x2\x2$\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t"+
		"\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F"+
		"\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19"+
		"\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?"+
		"\x2!\x41\x2\"\x43\x2#\x45\x2$\x3\x2\f\x5\x2\x43\\\x61\x61\x63|\x6\x2\x32"+
		";\x43\\\x61\x61\x63|\x3\x2\x32;\x4\x2$$^^\x4\x2))^^\n\x2$$))^^\x64\x64"+
		"hhppttvv\x6\x2``\x62\x62\x80\x80\xFFFF\xFFFF\x4\x2\x41\x41\xFFFF\xFFFF"+
		"\a\x2\x41\x41\x61\x61\x63\x63||\xFFFF\xFFFF\x4\x2\v\f\xF\xF\x10F\x2\x3"+
		"\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v"+
		"\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2"+
		"\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2"+
		"\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2"+
		"\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2"+
		"\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2"+
		"\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2"+
		"\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2"+
		"\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x3]\x3\x2\x2\x2\x5_\x3\x2\x2\x2"+
		"\ag\x3\x2\x2\x2\tk\x3\x2\x2\x2\vo\x3\x2\x2\x2\ru\x3\x2\x2\x2\xFw\x3\x2"+
		"\x2\x2\x11y\x3\x2\x2\x2\x13{\x3\x2\x2\x2\x15}\x3\x2\x2\x2\x17\x80\x3\x2"+
		"\x2\x2\x19\x83\x3\x2\x2\x2\x1B\x85\x3\x2\x2\x2\x1D\x87\x3\x2\x2\x2\x1F"+
		"\x89\x3\x2\x2\x2!\x8C\x3\x2\x2\x2#\x8F\x3\x2\x2\x2%\x92\x3\x2\x2\x2\'"+
		"\x95\x3\x2\x2\x2)\x97\x3\x2\x2\x2+\x99\x3\x2\x2\x2-\x9B\x3\x2\x2\x2/\x9D"+
		"\x3\x2\x2\x2\x31\x9F\x3\x2\x2\x2\x33\xA1\x3\x2\x2\x2\x35\xA3\x3\x2\x2"+
		"\x2\x37\xAB\x3\x2\x2\x2\x39\xAF\x3\x2\x2\x2;\xB1\x3\x2\x2\x2=\xB3\x3\x2"+
		"\x2\x2?\xBD\x3\x2\x2\x2\x41\xC4\x3\x2\x2\x2\x43\xF4\x3\x2\x2\x2\x45\xF6"+
		"\x3\x2\x2\x2GH\ar\x2\x2HI\aw\x2\x2IJ\a\x64\x2\x2JK\an\x2\x2KL\ak\x2\x2"+
		"L^\a\x65\x2\x2MN\ar\x2\x2NO\at\x2\x2OP\ak\x2\x2PQ\ax\x2\x2QR\a\x63\x2"+
		"\x2RS\av\x2\x2S^\ag\x2\x2TU\ar\x2\x2UV\at\x2\x2VW\aq\x2\x2WX\av\x2\x2"+
		"XY\ag\x2\x2YZ\a\x65\x2\x2Z[\av\x2\x2[\\\ag\x2\x2\\^\a\x66\x2\x2]G\x3\x2"+
		"\x2\x2]M\x3\x2\x2\x2]T\x3\x2\x2\x2^\x4\x3\x2\x2\x2_`\ar\x2\x2`\x61\at"+
		"\x2\x2\x61\x62\aq\x2\x2\x62\x63\ai\x2\x2\x63\x64\at\x2\x2\x64\x65\a\x63"+
		"\x2\x2\x65\x66\ao\x2\x2\x66\x6\x3\x2\x2\x2gh\ax\x2\x2hi\a\x63\x2\x2ij"+
		"\at\x2\x2j\b\x3\x2\x2\x2kl\ak\x2\x2lm\ap\x2\x2mn\av\x2\x2n\n\x3\x2\x2"+
		"\x2op\ar\x2\x2pq\at\x2\x2qr\ak\x2\x2rs\ap\x2\x2st\av\x2\x2t\f\x3\x2\x2"+
		"\x2uv\a-\x2\x2v\xE\x3\x2\x2\x2wx\a/\x2\x2x\x10\x3\x2\x2\x2yz\a,\x2\x2"+
		"z\x12\x3\x2\x2\x2{|\a\x31\x2\x2|\x14\x3\x2\x2\x2}~\a(\x2\x2~\x7F\a(\x2"+
		"\x2\x7F\x16\x3\x2\x2\x2\x80\x81\a~\x2\x2\x81\x82\a~\x2\x2\x82\x18\x3\x2"+
		"\x2\x2\x83\x84\a#\x2\x2\x84\x1A\x3\x2\x2\x2\x85\x86\a@\x2\x2\x86\x1C\x3"+
		"\x2\x2\x2\x87\x88\a>\x2\x2\x88\x1E\x3\x2\x2\x2\x89\x8A\a@\x2\x2\x8A\x8B"+
		"\a?\x2\x2\x8B \x3\x2\x2\x2\x8C\x8D\a>\x2\x2\x8D\x8E\a?\x2\x2\x8E\"\x3"+
		"\x2\x2\x2\x8F\x90\a?\x2\x2\x90\x91\a?\x2\x2\x91$\x3\x2\x2\x2\x92\x93\a"+
		"#\x2\x2\x93\x94\a?\x2\x2\x94&\x3\x2\x2\x2\x95\x96\a?\x2\x2\x96(\x3\x2"+
		"\x2\x2\x97\x98\a*\x2\x2\x98*\x3\x2\x2\x2\x99\x9A\a+\x2\x2\x9A,\x3\x2\x2"+
		"\x2\x9B\x9C\a}\x2\x2\x9C.\x3\x2\x2\x2\x9D\x9E\a\x7F\x2\x2\x9E\x30\x3\x2"+
		"\x2\x2\x9F\xA0\a]\x2\x2\xA0\x32\x3\x2\x2\x2\xA1\xA2\a_\x2\x2\xA2\x34\x3"+
		"\x2\x2\x2\xA3\xA7\t\x2\x2\x2\xA4\xA6\t\x3\x2\x2\xA5\xA4\x3\x2\x2\x2\xA6"+
		"\xA9\x3\x2\x2\x2\xA7\xA5\x3\x2\x2\x2\xA7\xA8\x3\x2\x2\x2\xA8\x36\x3\x2"+
		"\x2\x2\xA9\xA7\x3\x2\x2\x2\xAA\xAC\t\x4\x2\x2\xAB\xAA\x3\x2\x2\x2\xAC"+
		"\xAD\x3\x2\x2\x2\xAD\xAB\x3\x2\x2\x2\xAD\xAE\x3\x2\x2\x2\xAE\x38\x3\x2"+
		"\x2\x2\xAF\xB0\a=\x2\x2\xB0:\x3\x2\x2\x2\xB1\xB2\a.\x2\x2\xB2<\x3\x2\x2"+
		"\x2\xB3\xB8\a$\x2\x2\xB4\xB7\x5\x41!\x2\xB5\xB7\n\x5\x2\x2\xB6\xB4\x3"+
		"\x2\x2\x2\xB6\xB5\x3\x2\x2\x2\xB7\xBA\x3\x2\x2\x2\xB8\xB6\x3\x2\x2\x2"+
		"\xB8\xB9\x3\x2\x2\x2\xB9\xBB\x3\x2\x2\x2\xBA\xB8\x3\x2\x2\x2\xBB\xBC\a"+
		"$\x2\x2\xBC>\x3\x2\x2\x2\xBD\xC0\a)\x2\x2\xBE\xC1\x5\x41!\x2\xBF\xC1\n"+
		"\x6\x2\x2\xC0\xBE\x3\x2\x2\x2\xC0\xBF\x3\x2\x2\x2\xC1\xC2\x3\x2\x2\x2"+
		"\xC2\xC3\a)\x2\x2\xC3@\x3\x2\x2\x2\xC4\xC5\a^\x2\x2\xC5\xC6\t\a\x2\x2"+
		"\xC6\x42\x3\x2\x2\x2\xC7\xC8\a]\x2\x2\xC8\xC9\a>\x2\x2\xC9\xCA\a}\x2\x2"+
		"\xCA\xCB\a~\x2\x2\xCB\xCD\a_\x2\x2\xCC\xC7\x3\x2\x2\x2\xCD\xCE\x3\x2\x2"+
		"\x2\xCE\xCC\x3\x2\x2\x2\xCE\xCF\x3\x2\x2\x2\xCF\xF5\x3\x2\x2\x2\xD0\xF5"+
		"\t\b\x2\x2\xD1\xD3\a\x41\x2\x2\xD2\xD1\x3\x2\x2\x2\xD3\xD4\x3\x2\x2\x2"+
		"\xD4\xD2\x3\x2\x2\x2\xD4\xD5\x3\x2\x2\x2\xD5\xF5\x3\x2\x2\x2\xD6\xD8\a"+
		"\xFFFF\x2\x2\xD7\xD6\x3\x2\x2\x2\xD8\xD9\x3\x2\x2\x2\xD9\xD7\x3\x2\x2"+
		"\x2\xD9\xDA\x3\x2\x2\x2\xDA\xF5\x3\x2\x2\x2\xDB\xDD\t\t\x2\x2\xDC\xDB"+
		"\x3\x2\x2\x2\xDD\xDE\x3\x2\x2\x2\xDE\xDC\x3\x2\x2\x2\xDE\xDF\x3\x2\x2"+
		"\x2\xDF\xE1\x3\x2\x2\x2\xE0\xE2\t\t\x2\x2\xE1\xE0\x3\x2\x2\x2\xE2\xE3"+
		"\x3\x2\x2\x2\xE3\xE1\x3\x2\x2\x2\xE3\xE4\x3\x2\x2\x2\xE4\xF5\x3\x2\x2"+
		"\x2\xE5\xE7\a\xFFFF\x2\x2\xE6\xE5\x3\x2\x2\x2\xE7\xE8\x3\x2\x2\x2\xE8"+
		"\xE6\x3\x2\x2\x2\xE8\xE9\x3\x2\x2\x2\xE9\xF5\x3\x2\x2\x2\xEA\xEC\t\n\x2"+
		"\x2\xEB\xEA\x3\x2\x2\x2\xEC\xED\x3\x2\x2\x2\xED\xEB\x3\x2\x2\x2\xED\xEE"+
		"\x3\x2\x2\x2\xEE\xF5\x3\x2\x2\x2\xEF\xF1\t\n\x2\x2\xF0\xEF\x3\x2\x2\x2"+
		"\xF1\xF2\x3\x2\x2\x2\xF2\xF0\x3\x2\x2\x2\xF2\xF3\x3\x2\x2\x2\xF3\xF5\x3"+
		"\x2\x2\x2\xF4\xCC\x3\x2\x2\x2\xF4\xD0\x3\x2\x2\x2\xF4\xD2\x3\x2\x2\x2"+
		"\xF4\xD7\x3\x2\x2\x2\xF4\xDC\x3\x2\x2\x2\xF4\xE6\x3\x2\x2\x2\xF4\xEB\x3"+
		"\x2\x2\x2\xF4\xF0\x3\x2\x2\x2\xF5\x44\x3\x2\x2\x2\xF6\xF7\t\v\x2\x2\xF7"+
		"\xF8\x3\x2\x2\x2\xF8\xF9\b#\x2\x2\xF9\x46\x3\x2\x2\x2\x12\x2]\xA7\xAD"+
		"\xB6\xB8\xC0\xCE\xD4\xD9\xDE\xE3\xE8\xED\xF2\xF4\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Compilador