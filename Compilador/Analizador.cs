using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime.Misc;

namespace Compilador
{
    class Analizador: AnalizadorBaseVisitor<string>
    {
        List<AnalisisSemanticoSimbolos> Simbolos = new List<AnalisisSemanticoSimbolos>();

        public override string VisitOps(AnalizadorParser.OpsContext context)
        {
            Console.WriteLine("SE ESTA REALIZANDO UNA OPERACION");
            return "finalizo";
        }

        public override string VisitProgram([NotNull] AnalizadorParser.ProgramContext context)
        {
            Console.WriteLine("SE HA CREADO UN SCRIPT LLAMADO {0}.", context.children[1]);
            return base.VisitProgram(context);
        }

        public override string VisitDec_var([NotNull] AnalizadorParser.Dec_varContext context)
        {
            //Agregamos la variable nueva a la tabla de simbolos.

            //Verificamos de que no exista.
            var res = Simbolos.Find(x => x.identificador.Equals(context.children[1].ToString()));
            if (res != null)
            {
                Console.WriteLine("\n:::::::  LA VARIABLE {0} YA ESTA EN USO. :::::::\n", res.identificador);
            }
            else //Si no existe la creamos.
            {
                Console.WriteLine("\n SE HA DECLARADO UNA VARIABLE");
                Console.Write("  --  TIPO DE DATO: {0}\n  --  IDENTIFICADOR: {1}\n  --  VALOR: NULL \n\n", context.children[0], context.children[1]);
                Simbolos.Add(new AnalisisSemanticoSimbolos { identificador = context.children[1].ToString(), valor = null, tipodato = context.children[0].ToString() });
            }
            return base.VisitDec_var(context);
        }

        public override string VisitAsing_var([NotNull] AnalizadorParser.Asing_varContext context)
        {
            int RS = 0;
            bool RSR = false;

            int A = 0;
            int B = 0;

            Console.WriteLine("SE HA REALIZADO UNA ASIGNACION A UNA VARIABLE");

            var valor = context.children[2];
            string resultado_op = string.Empty;
            if (valor.ChildCount > 1)
            {
                try
                {
                    A = int.Parse(valor.GetChild(0).ToString());
                    B = int.Parse(valor.GetChild(2).ToString());
                }
                catch (Exception ex)
                {
                    if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                    {

                        var AS = Simbolos.Find(x => x.identificador == valor.GetChild(0).ToString());
                        var BS = Simbolos.Find(x => x.identificador == valor.GetChild(2).ToString());
                        if (AS == null && BS == null)
                        {
                            Console.WriteLine(":::::::  LAS VARIABLES {0}, {1} NO ESTAN DEFINIDAS  :::::::", valor.GetChild(0).ToString(), valor.GetChild(2).ToString());
                        }
                        else if (AS == null)
                        {
                            Console.WriteLine(":::::::  LA VARIABLE {0} NO ESTA DEFINIDA  :::::::", valor.GetChild(0).ToString());
                        }
                        else if (BS == null)
                        {
                            Console.WriteLine(":::::::  LA VARIABLE {0} NO ESTA DEFINIDA  :::::::", valor.GetChild(2).ToString());
                        }
                        else
                        {
                            try
                            {
                                A = int.Parse(AS.valor);
                                B = int.Parse(BS.valor);
                            }
                            catch (Exception exp)
                            {
                                if (exp.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                                {
                                    Console.WriteLine(":::::::  NO SE PUEDE OPERAR DATOS STRINGS:::::::");
                                }
                            }
                        }

                    }
                }
                string op = valor.GetChild(1).ToString();
                if (op.Equals("+"))
                {
                    resultado_op = (A + B).ToString();
                }
                else if (op.Equals("-"))
                {
                    resultado_op = (A - B).ToString();
                }
                else if (op.Equals("*"))
                {
                    resultado_op = (A * B).ToString();
                }
                else
                {
                    if (B == 0)
                    {
                        Console.WriteLine(":::::::\n  DIVISION POR CERO  :::::::");
                    }
                    else
                    {
                        resultado_op = (A / B).ToString();
                    }
                }

            }
            else
            {
                resultado_op = valor.ToString();
                try
                {
                    RS = int.Parse(resultado_op);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("La cadena de entrada no tiene el formato correcto."))
                    {
                        RSR = true;
                    }
                }
            }
            var result = Simbolos.Find(x => x.identificador.Equals(context.children[0].ToString()));
            if (result.tipodato.Equals("int") && RSR)
            {
                Console.WriteLine("  --  NO SE PUEDEN DECLARAR STRINGS EN TIPO DE DATOS ENTERO\n");
            }
            else
            {
                Simbolos.Where(x => x.identificador == result.identificador).ToList().ForEach(x => x.valor = resultado_op.ToString());
                Console.Write("  --  IDENTIFICADOR: {0}\n  --  VALOR: {1}\n\n", context.children[0], resultado_op);
            }
            return base.VisitAsing_var(context);
        }

        public override string VisitDec_asing_var([NotNull] AnalizadorParser.Dec_asing_varContext context)
        {
            var res = Simbolos.Find(x => x.identificador.Equals(context.children[1].ToString()));
            if (res != null)
            {
                Console.WriteLine("\n:::::::  LA VARIABLE {0} YA ESTA EN USO. :::::::\n", res.identificador);
            }
            else
            {
                var valor = context.children[3];
                string resultado_op = string.Empty;
                if (valor.ChildCount > 1)
                {
                    int A = int.Parse(valor.GetChild(0).ToString());
                    int B = int.Parse(valor.GetChild(2).ToString());
                    string op = valor.GetChild(1).ToString();
                    if (op.Equals("+"))
                    {
                        resultado_op = (A + B).ToString();
                    }
                    else if (op.Equals("-"))
                    {
                        resultado_op = (A - B).ToString();
                    }
                    else if (op.Equals("*"))
                    {
                        resultado_op = (A * B).ToString();
                    }
                    else
                    {
                        if (B == 0)
                        {
                            Console.WriteLine(":::::::\n  DIVISION POR CERO  :::::::");
                        }
                        else
                        {
                            resultado_op = (A / B).ToString();
                        }
                    }

                }
                else
                {
                    resultado_op = valor.ToString();
                }
                Console.WriteLine("SE HA DECLARADO UNA VARIABLE CON ASIGNACION.");
                Console.Write("  --  TIPO DE DATO: {0}\n  --  IDENTIFICADOR: {1}\n  --  VALOR: {2}\n\n", context.children[0], context.children[1], resultado_op);
                Simbolos.Add(new AnalisisSemanticoSimbolos { identificador = context.children[1].ToString(), valor = resultado_op });
            }

            return base.VisitDec_asing_var(context);
        }

        public override string VisitPrintln([NotNull] AnalizadorParser.PrintlnContext context)
        {
            Console.WriteLine("\nSE ESTA REALIZANDO UNA IMPRESION POR PANTALLA.");
            var result = Simbolos.Find(x => x.identificador.Equals(context.children[1].ToString()));
            Console.Write("\nRESULTADO: {0}\n", result.valor);
            return base.VisitPrintln(context);
        }
    }
}
