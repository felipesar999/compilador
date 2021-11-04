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
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class AnalizadorParser : Parser {
	public const int
		ACCESSM=1, PROGRAM=2, VAR=3, INT=4, PRINT=5, PLUS=6, SUBS=7, PROD=8, DIV=9, 
		AND=10, OR=11, NOT=12, GT=13, LT=14, GEQ=15, LEG=16, EQ=17, NEQ=18, ASSIGN=19, 
		PAREN_A=20, PAREN_C=21, LLAV_A=22, LLAV_C=23, CORCH_A=24, CORCH_C=25, 
		IDENTIFIER=26, INTEGERS=27, SEMICOLON=28, COLON=29, STRING=30, CHAR=31, 
		ESC_SEQ=32, Unknown=33, WS=34, SUB=35;
	public const int
		RULE_program = 0, RULE_expresion = 1, RULE_dec_var = 2, RULE_asing_var = 3, 
		RULE_dec_asing_var = 4, RULE_ops = 5, RULE_ops_variables = 6, RULE_println = 7;
	public static readonly string[] ruleNames = {
		"program", "expresion", "dec_var", "asing_var", "dec_asing_var", "ops", 
		"ops_variables", "println"
	};

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
		"WS", "SUB"
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

	public override string SerializedAtn { get { return _serializedATN; } }


	    protected const int EOF = Eof;

	public AnalizadorParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ProgramContext : ParserRuleContext {
		public ITerminalNode PROGRAM() { return GetToken(AnalizadorParser.PROGRAM, 0); }
		public ITerminalNode IDENTIFIER() { return GetToken(AnalizadorParser.IDENTIFIER, 0); }
		public ITerminalNode LLAV_A() { return GetToken(AnalizadorParser.LLAV_A, 0); }
		public ITerminalNode LLAV_C() { return GetToken(AnalizadorParser.LLAV_C, 0); }
		public ExpresionContext[] expresion() {
			return GetRuleContexts<ExpresionContext>();
		}
		public ExpresionContext expresion(int i) {
			return GetRuleContext<ExpresionContext>(i);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.EnterProgram(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.ExitProgram(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAnalizadorVisitor<TResult> typedVisitor = visitor as IAnalizadorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProgram(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_program);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 16; Match(PROGRAM);
			State = 17; Match(IDENTIFIER);
			State = 18; Match(LLAV_A);
			State = 20;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 19; expresion();
				}
				}
				State = 22;
				_errHandler.Sync(this);
				_la = _input.La(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << VAR) | (1L << INT) | (1L << PRINT) | (1L << IDENTIFIER))) != 0) );
			State = 24; Match(LLAV_C);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpresionContext : ParserRuleContext {
		public Dec_varContext dec_var() {
			return GetRuleContext<Dec_varContext>(0);
		}
		public Asing_varContext asing_var() {
			return GetRuleContext<Asing_varContext>(0);
		}
		public Dec_asing_varContext dec_asing_var() {
			return GetRuleContext<Dec_asing_varContext>(0);
		}
		public PrintlnContext println() {
			return GetRuleContext<PrintlnContext>(0);
		}
		public ExpresionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expresion; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.EnterExpresion(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.ExitExpresion(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAnalizadorVisitor<TResult> typedVisitor = visitor as IAnalizadorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpresion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpresionContext expresion() {
		ExpresionContext _localctx = new ExpresionContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_expresion);
		try {
			State = 30;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,1,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 26; dec_var();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 27; asing_var();
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 28; dec_asing_var();
				}
				break;

			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 29; println();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Dec_varContext : ParserRuleContext {
		public ITerminalNode VAR() { return GetToken(AnalizadorParser.VAR, 0); }
		public ITerminalNode IDENTIFIER() { return GetToken(AnalizadorParser.IDENTIFIER, 0); }
		public ITerminalNode COLON() { return GetToken(AnalizadorParser.COLON, 0); }
		public ITerminalNode INT() { return GetToken(AnalizadorParser.INT, 0); }
		public Dec_varContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dec_var; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.EnterDec_var(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.ExitDec_var(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAnalizadorVisitor<TResult> typedVisitor = visitor as IAnalizadorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDec_var(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Dec_varContext dec_var() {
		Dec_varContext _localctx = new Dec_varContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_dec_var);
		try {
			State = 38;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case VAR:
				EnterOuterAlt(_localctx, 1);
				{
				State = 32; Match(VAR);
				State = 33; Match(IDENTIFIER);
				State = 34; Match(COLON);
				}
				break;
			case INT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 35; Match(INT);
				State = 36; Match(IDENTIFIER);
				State = 37; Match(COLON);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Asing_varContext : ParserRuleContext {
		public ITerminalNode IDENTIFIER() { return GetToken(AnalizadorParser.IDENTIFIER, 0); }
		public ITerminalNode ASSIGN() { return GetToken(AnalizadorParser.ASSIGN, 0); }
		public ITerminalNode INTEGERS() { return GetToken(AnalizadorParser.INTEGERS, 0); }
		public ITerminalNode COLON() { return GetToken(AnalizadorParser.COLON, 0); }
		public ITerminalNode STRING() { return GetToken(AnalizadorParser.STRING, 0); }
		public OpsContext ops() {
			return GetRuleContext<OpsContext>(0);
		}
		public Ops_variablesContext ops_variables() {
			return GetRuleContext<Ops_variablesContext>(0);
		}
		public Asing_varContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_asing_var; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.EnterAsing_var(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.ExitAsing_var(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAnalizadorVisitor<TResult> typedVisitor = visitor as IAnalizadorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAsing_var(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Asing_varContext asing_var() {
		Asing_varContext _localctx = new Asing_varContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_asing_var);
		try {
			State = 54;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,3,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 40; Match(IDENTIFIER);
				State = 41; Match(ASSIGN);
				State = 42; Match(INTEGERS);
				State = 43; Match(COLON);
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 44; Match(IDENTIFIER);
				State = 45; Match(ASSIGN);
				State = 46; Match(STRING);
				State = 47; Match(COLON);
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 48; Match(IDENTIFIER);
				State = 49; Match(ASSIGN);
				State = 50; ops();
				}
				break;

			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 51; Match(IDENTIFIER);
				State = 52; Match(ASSIGN);
				State = 53; ops_variables();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Dec_asing_varContext : ParserRuleContext {
		public ITerminalNode VAR() { return GetToken(AnalizadorParser.VAR, 0); }
		public ITerminalNode IDENTIFIER() { return GetToken(AnalizadorParser.IDENTIFIER, 0); }
		public ITerminalNode ASSIGN() { return GetToken(AnalizadorParser.ASSIGN, 0); }
		public ITerminalNode INTEGERS() { return GetToken(AnalizadorParser.INTEGERS, 0); }
		public ITerminalNode COLON() { return GetToken(AnalizadorParser.COLON, 0); }
		public OpsContext ops() {
			return GetRuleContext<OpsContext>(0);
		}
		public ITerminalNode STRING() { return GetToken(AnalizadorParser.STRING, 0); }
		public ITerminalNode INT() { return GetToken(AnalizadorParser.INT, 0); }
		public Dec_asing_varContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dec_asing_var; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.EnterDec_asing_var(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.ExitDec_asing_var(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAnalizadorVisitor<TResult> typedVisitor = visitor as IAnalizadorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDec_asing_var(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Dec_asing_varContext dec_asing_var() {
		Dec_asing_varContext _localctx = new Dec_asing_varContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_dec_asing_var);
		try {
			State = 79;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,4,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 56; Match(VAR);
				State = 57; Match(IDENTIFIER);
				State = 58; Match(ASSIGN);
				State = 59; Match(INTEGERS);
				State = 60; Match(COLON);
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 61; Match(VAR);
				State = 62; Match(IDENTIFIER);
				State = 63; Match(ASSIGN);
				State = 64; ops();
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 65; Match(VAR);
				State = 66; Match(IDENTIFIER);
				State = 67; Match(ASSIGN);
				State = 68; Match(STRING);
				State = 69; Match(COLON);
				}
				break;

			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 70; Match(INT);
				State = 71; Match(IDENTIFIER);
				State = 72; Match(ASSIGN);
				State = 73; Match(INTEGERS);
				State = 74; Match(COLON);
				}
				break;

			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 75; Match(INT);
				State = 76; Match(IDENTIFIER);
				State = 77; Match(ASSIGN);
				State = 78; ops();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OpsContext : ParserRuleContext {
		public ITerminalNode[] INTEGERS() { return GetTokens(AnalizadorParser.INTEGERS); }
		public ITerminalNode INTEGERS(int i) {
			return GetToken(AnalizadorParser.INTEGERS, i);
		}
		public ITerminalNode PROD() { return GetToken(AnalizadorParser.PROD, 0); }
		public ITerminalNode COLON() { return GetToken(AnalizadorParser.COLON, 0); }
		public ITerminalNode PLUS() { return GetToken(AnalizadorParser.PLUS, 0); }
		public ITerminalNode SUB() { return GetToken(AnalizadorParser.SUB, 0); }
		public ITerminalNode DIV() { return GetToken(AnalizadorParser.DIV, 0); }
		public OpsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ops; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.EnterOps(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.ExitOps(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAnalizadorVisitor<TResult> typedVisitor = visitor as IAnalizadorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOps(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public OpsContext ops() {
		OpsContext _localctx = new OpsContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_ops);
		try {
			State = 98;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,5,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 81; Match(INTEGERS);
				State = 82; Match(PROD);
				State = 83; Match(INTEGERS);
				State = 84; Match(COLON);
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 85; Match(INTEGERS);
				State = 86; Match(PLUS);
				State = 87; Match(INTEGERS);
				State = 88; Match(COLON);
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 89; Match(INTEGERS);
				State = 90; Match(SUB);
				State = 91; Match(INTEGERS);
				State = 92; Match(COLON);
				}
				break;

			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 93; Match(INTEGERS);
				State = 94; Match(DIV);
				State = 95; Match(INTEGERS);
				State = 96; Match(COLON);
				}
				break;

			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Ops_variablesContext : ParserRuleContext {
		public ITerminalNode[] IDENTIFIER() { return GetTokens(AnalizadorParser.IDENTIFIER); }
		public ITerminalNode IDENTIFIER(int i) {
			return GetToken(AnalizadorParser.IDENTIFIER, i);
		}
		public ITerminalNode PROD() { return GetToken(AnalizadorParser.PROD, 0); }
		public ITerminalNode COLON() { return GetToken(AnalizadorParser.COLON, 0); }
		public ITerminalNode PLUS() { return GetToken(AnalizadorParser.PLUS, 0); }
		public ITerminalNode SUB() { return GetToken(AnalizadorParser.SUB, 0); }
		public ITerminalNode DIV() { return GetToken(AnalizadorParser.DIV, 0); }
		public Ops_variablesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ops_variables; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.EnterOps_variables(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.ExitOps_variables(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAnalizadorVisitor<TResult> typedVisitor = visitor as IAnalizadorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOps_variables(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Ops_variablesContext ops_variables() {
		Ops_variablesContext _localctx = new Ops_variablesContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_ops_variables);
		try {
			State = 116;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,6,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 100; Match(IDENTIFIER);
				State = 101; Match(PROD);
				State = 102; Match(IDENTIFIER);
				State = 103; Match(COLON);
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 104; Match(IDENTIFIER);
				State = 105; Match(PLUS);
				State = 106; Match(IDENTIFIER);
				State = 107; Match(COLON);
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 108; Match(IDENTIFIER);
				State = 109; Match(SUB);
				State = 110; Match(IDENTIFIER);
				State = 111; Match(COLON);
				}
				break;

			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 112; Match(IDENTIFIER);
				State = 113; Match(DIV);
				State = 114; Match(IDENTIFIER);
				State = 115; Match(COLON);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PrintlnContext : ParserRuleContext {
		public ITerminalNode PRINT() { return GetToken(AnalizadorParser.PRINT, 0); }
		public ITerminalNode IDENTIFIER() { return GetToken(AnalizadorParser.IDENTIFIER, 0); }
		public ITerminalNode COLON() { return GetToken(AnalizadorParser.COLON, 0); }
		public PrintlnContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_println; } }
		public override void EnterRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.EnterPrintln(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IAnalizadorListener typedListener = listener as IAnalizadorListener;
			if (typedListener != null) typedListener.ExitPrintln(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAnalizadorVisitor<TResult> typedVisitor = visitor as IAnalizadorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPrintln(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PrintlnContext println() {
		PrintlnContext _localctx = new PrintlnContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_println);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 118; Match(PRINT);
			State = 119; Match(IDENTIFIER);
			State = 120; Match(COLON);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3%}\x4\x2\t\x2\x4"+
		"\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t\t\x3"+
		"\x2\x3\x2\x3\x2\x3\x2\x6\x2\x17\n\x2\r\x2\xE\x2\x18\x3\x2\x3\x2\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x5\x3!\n\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x5"+
		"\x4)\n\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\x39\n\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6"+
		"\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3"+
		"\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x5\x6R\n\x6\x3\a\x3\a\x3\a\x3"+
		"\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x5"+
		"\a\x65\n\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b"+
		"\x3\b\x3\b\x3\b\x3\b\x5\bw\n\b\x3\t\x3\t\x3\t\x3\t\x3\t\x2\x2\x2\n\x2"+
		"\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2\x2\x2\x87\x2\x12\x3\x2\x2"+
		"\x2\x4 \x3\x2\x2\x2\x6(\x3\x2\x2\x2\b\x38\x3\x2\x2\x2\nQ\x3\x2\x2\x2\f"+
		"\x64\x3\x2\x2\x2\xEv\x3\x2\x2\x2\x10x\x3\x2\x2\x2\x12\x13\a\x4\x2\x2\x13"+
		"\x14\a\x1C\x2\x2\x14\x16\a\x18\x2\x2\x15\x17\x5\x4\x3\x2\x16\x15\x3\x2"+
		"\x2\x2\x17\x18\x3\x2\x2\x2\x18\x16\x3\x2\x2\x2\x18\x19\x3\x2\x2\x2\x19"+
		"\x1A\x3\x2\x2\x2\x1A\x1B\a\x19\x2\x2\x1B\x3\x3\x2\x2\x2\x1C!\x5\x6\x4"+
		"\x2\x1D!\x5\b\x5\x2\x1E!\x5\n\x6\x2\x1F!\x5\x10\t\x2 \x1C\x3\x2\x2\x2"+
		" \x1D\x3\x2\x2\x2 \x1E\x3\x2\x2\x2 \x1F\x3\x2\x2\x2!\x5\x3\x2\x2\x2\""+
		"#\a\x5\x2\x2#$\a\x1C\x2\x2$)\a\x1F\x2\x2%&\a\x6\x2\x2&\'\a\x1C\x2\x2\'"+
		")\a\x1F\x2\x2(\"\x3\x2\x2\x2(%\x3\x2\x2\x2)\a\x3\x2\x2\x2*+\a\x1C\x2\x2"+
		"+,\a\x15\x2\x2,-\a\x1D\x2\x2-\x39\a\x1F\x2\x2./\a\x1C\x2\x2/\x30\a\x15"+
		"\x2\x2\x30\x31\a \x2\x2\x31\x39\a\x1F\x2\x2\x32\x33\a\x1C\x2\x2\x33\x34"+
		"\a\x15\x2\x2\x34\x39\x5\f\a\x2\x35\x36\a\x1C\x2\x2\x36\x37\a\x15\x2\x2"+
		"\x37\x39\x5\xE\b\x2\x38*\x3\x2\x2\x2\x38.\x3\x2\x2\x2\x38\x32\x3\x2\x2"+
		"\x2\x38\x35\x3\x2\x2\x2\x39\t\x3\x2\x2\x2:;\a\x5\x2\x2;<\a\x1C\x2\x2<"+
		"=\a\x15\x2\x2=>\a\x1D\x2\x2>R\a\x1F\x2\x2?@\a\x5\x2\x2@\x41\a\x1C\x2\x2"+
		"\x41\x42\a\x15\x2\x2\x42R\x5\f\a\x2\x43\x44\a\x5\x2\x2\x44\x45\a\x1C\x2"+
		"\x2\x45\x46\a\x15\x2\x2\x46G\a \x2\x2GR\a\x1F\x2\x2HI\a\x6\x2\x2IJ\a\x1C"+
		"\x2\x2JK\a\x15\x2\x2KL\a\x1D\x2\x2LR\a\x1F\x2\x2MN\a\x6\x2\x2NO\a\x1C"+
		"\x2\x2OP\a\x15\x2\x2PR\x5\f\a\x2Q:\x3\x2\x2\x2Q?\x3\x2\x2\x2Q\x43\x3\x2"+
		"\x2\x2QH\x3\x2\x2\x2QM\x3\x2\x2\x2R\v\x3\x2\x2\x2ST\a\x1D\x2\x2TU\a\n"+
		"\x2\x2UV\a\x1D\x2\x2V\x65\a\x1F\x2\x2WX\a\x1D\x2\x2XY\a\b\x2\x2YZ\a\x1D"+
		"\x2\x2Z\x65\a\x1F\x2\x2[\\\a\x1D\x2\x2\\]\a%\x2\x2]^\a\x1D\x2\x2^\x65"+
		"\a\x1F\x2\x2_`\a\x1D\x2\x2`\x61\a\v\x2\x2\x61\x62\a\x1D\x2\x2\x62\x65"+
		"\a\x1F\x2\x2\x63\x65\x3\x2\x2\x2\x64S\x3\x2\x2\x2\x64W\x3\x2\x2\x2\x64"+
		"[\x3\x2\x2\x2\x64_\x3\x2\x2\x2\x64\x63\x3\x2\x2\x2\x65\r\x3\x2\x2\x2\x66"+
		"g\a\x1C\x2\x2gh\a\n\x2\x2hi\a\x1C\x2\x2iw\a\x1F\x2\x2jk\a\x1C\x2\x2kl"+
		"\a\b\x2\x2lm\a\x1C\x2\x2mw\a\x1F\x2\x2no\a\x1C\x2\x2op\a%\x2\x2pq\a\x1C"+
		"\x2\x2qw\a\x1F\x2\x2rs\a\x1C\x2\x2st\a\v\x2\x2tu\a\x1C\x2\x2uw\a\x1F\x2"+
		"\x2v\x66\x3\x2\x2\x2vj\x3\x2\x2\x2vn\x3\x2\x2\x2vr\x3\x2\x2\x2w\xF\x3"+
		"\x2\x2\x2xy\a\a\x2\x2yz\a\x1C\x2\x2z{\a\x1F\x2\x2{\x11\x3\x2\x2\x2\t\x18"+
		" (\x38Q\x64v";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Compilador
