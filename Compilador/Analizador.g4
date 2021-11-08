grammar Analizador;

@parser::members
{
    protected const int EOF = Eof;
}
@lexer::members
{
    protected const int EOF = Eof;
    protected const int HIDDEN = Hidden;
}
/*
 * Parser Rules
 */

/*DEFINIENDO LA ESTRUCTURA DE NUESTRO PROGRAMA.*/

/* GRAMATICA LIBRE DE CONTEXTO */

/*
* En este gramatica vamos a soportar por el momento
* La declaracion de variables, asignacion de valores e impresion por pantalla.
*/

/* Nuestro programa tendra una estructura basica.
*   program IDENTIFICADOR
*   {
*		SENTENCIAS
*	}
*/
program : PROGRAM IDENTIFIER 
			LLAV_A 
				expresion+ 
			LLAV_C;

//Una expresion o sentencia en este caso se compone de una declaracion de variable, 
//o de una asignacion de variable, o de una operacion matematica o una impresion por pantalla.
expresion : dec_var | asing_var | dec_asing_var | println	;


//Una declaracion de variable esta compuesta por. VAR IDENTIFICADOR ;
dec_var : VAR IDENTIFIER COLON |
		  INT IDENTIFIER COLON;



asing_var : IDENTIFIER ASSIGN INTEGERS COLON	|
			 IDENTIFIER ASSIGN STRING COLON |
			IDENTIFIER ASSIGN ops |
			IDENTIFIER ASSIGN ops_variables ;

dec_asing_var : VAR IDENTIFIER ASSIGN INTEGERS COLON |
				  VAR IDENTIFIER ASSIGN ops |
				  VAR IDENTIFIER ASSIGN STRING COLON |
				  INT IDENTIFIER ASSIGN INTEGERS COLON |
				  INT IDENTIFIER ASSIGN ops;


ops : INTEGERS PROD INTEGERS COLON|
	  INTEGERS PLUS INTEGERS COLON |
	  INTEGERS SUBS INTEGERS  COLON|
	  INTEGERS DIV INTEGERS COLON |
      ;

ops_variables : IDENTIFIER PROD IDENTIFIER COLON|
	  IDENTIFIER PLUS IDENTIFIER COLON |
	  IDENTIFIER SUBS IDENTIFIER  COLON|
	  IDENTIFIER DIV IDENTIFIER COLON;

println : PRINT IDENTIFIER COLON;

condicion_if: IF condicion (ELSE IF condicion)* (ELSE stat_block)?;

condicion: expr stat_block;

stat_block: condicion_if|
			OTHER {System.err.println("cadena desconocida:"+ $OTHER.text);};


expr: expr POW<assoc=right> expr|
	  SUBS expr|
	  NOT expr
	  expr AND expr|
	  expr OR expr|
	  atomico|
	  expr op=(PROD|DIV|MOD) expr|
	  expr op=(PLUS|SUBS) expr|
	  expr op=(GT|LT|GEQ|LEG) expr|
	  expr op=(EQ|NEQ) expr;

atomico: PAREN_A expr PAREN_C  #atomexpr|
		INTEGERS #intatom|
		(TRUE|FALSE) #booleanatom|
		IDENTIFIER #idatom|
		STRING #stringatom;




		
	  	
/*
 * Lexer Rules
 */
OTHER:.;
//boolean
TRUE: 'true';
FALSE: 'false';
//Palabras reservadas.
ACCESSM : ('public' | 'private' | 'protected');
PROGRAM : 'program';
VAR : 'var';
INT : 'int';
PRINT : 'print';
IF: 'if';
//Operadores
PLUS : '+';
SUBS : '-';
PROD: '*';
DIV: '/';
//Operadores logicos
AND : '&&';
OR : '||';
NOT : '!';
//Comparadores
GT : '>';
LT : '<';
GEQ : '>=';
LEG : '<=';
EQ : '==';
NEQ : '!=';
POW: '^';
MOD: '%';
//Asignacion
ASSIGN : '=';
// llaves, corchetes y parentesis
PAREN_A : '(';
PAREN_C : ')';
LLAV_A : '{';
LLAV_C : '}';
CORCH_A : '[';
CORCH_C : ']';
//Identificadores
IDENTIFIER : ('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*;
//Enteros
INTEGERS : [0-9]+;
//Punto y coma
SEMICOLON : ';';
COLON : ',';
STRING
    :  '"' ( ESC_SEQ | ~('\\'|'"') )* '"'
    ;

CHAR:  '\'' ( ESC_SEQ | ~('\''|'\\') ) '\''
    ;
ESC_SEQ
    :   '\\' ('b'|'t'|'n'|'f'|'r'|'\"'|'\''|'\\')
    ;
//Simbolos considerados desconocidos.
Unknown : '[<{|]'+ 
			|'´'|'~'|'`'|'?'+|'¿'+|[¿?]+[?¿]+|'¨'+|[a_z¿?]+|[¿?a_z]+;
//Obviamos la tabulacion, salto de linea y espacios.
WS:	[\t\n\r] -> skip;