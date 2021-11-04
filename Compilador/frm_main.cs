using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Compilador
{
    public partial class frm_main : Form
    {
        /// <summary>
        ///     Función donde se realiza la verificación de las tres areas del Compilador, Lexico, Sintactico y Semantico.
        /// </summary>
        /// <param name="Fuente"></param>
        /// <param name="Tipo"></param>
        public void Instancia_LSS(string Fuente, int Tipo)
        {
            AntlrInputStream input = new AntlrInputStream(Fuente);
            AnalizadorLexer lexer = new AnalizadorLexer(input);
            lexer.RemoveErrorListeners();
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            AnalizadorParser parser = new AnalizadorParser(tokens);
            //Console.WriteLine(parser);
            switch (Tipo)
            {
                case 1:
                    SubTitle.Text = " >> Análisis Léxico";
                    if (!VerificarTextoInicial())
                    {
                        LlenarGrid(lexer);
                    }
                    break;
                default:

                    parser.RemoveErrorListeners();
                    parser.AddErrorListener(new AnalisisSintacticoErrores());
                    IParseTree tree = parser.program();
                    AnalisisSintactico.Arbol = tree.ToStringTree(parser);
                    switch (Tipo)
                    {

                        case 2:
                            SubTitle.Text = " >> Análisis Sintáctico";
                            var parserResult2 = AnalisisSintacticoErrores.GetSyntaxError;
                            if (parserResult2 == null)
                            {
                                txtOutput.Text += "\n<CA> Análisis Sintáctico finalizado correctamente...";

                                AnalisisSintactico.Arbol = tree.ToStringTree(parser);
                                txtSintactico.Text = AnalisisSintactico.Arbol;
                            }
                            else
                            {
                                txtOutput.Text = parserResult2;
                                AnalisisSintacticoErrores.GetSyntaxError = null;
                                txtSintactico.Text = "No se ha podido realizar el proceso de validación correctamente...";
                            }


                            break;
                        case 3:

                            SubTitle.Text = " >> Analisis Semántico";
                            var parserResult3 = AnalisisSintacticoErrores.GetSyntaxError;
                            if (parserResult3 == null)
                            {
                                txtOutput.Text += "\n<CA> Análisis Léxico finalizado correctamente...";
                                txtOutput.Text += "\n<CA> Análisis Sintáctico finalizado correctamente...";
                                Analizador visitor = new Analizador();
                                var result = visitor.Visit(tree);
                                txtOutput.Text += "\n<CA> Análisis Semántico finalizado correctamente...";
                            }
                            else
                            {
                                txtOutput.Text = parserResult3;
                                AnalisisSintacticoErrores.GetSyntaxError = null;
                            }
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        ///     Método para llenar la tabla de resultados
        /// </summary>
        /// <param name="Lexer"></param>
        public void LlenarGrid(AnalizadorLexer Lexer)
        {
            //Obtenemos todos los tokens luego del analisis lexico.
            var tokens = Lexer.GetAllTokens();

            try
            {
                //Añadimos el mismo numero de filas como de tokens.
                dgvTokens.RowCount = tokens.Count;
                Console.WriteLine("El contador es" + dgvTokens.RowCount);
                for (int i = 0; i < tokens.Count; i++)
                {
                    //Mostramos los simbolos conocidos 
                    if (tokens[i].Type != 32)
                    {
                        //En esta columna mostramos el RuleName o el TOKEN que se encuentra en el archivo de gramatica.
                        dgvTokens.Rows[i].Cells[0].Value = Lexer.RuleNames[tokens[i].Type - 1].ToString();
                        //En esta columna mostramos el valor de cada token que se extrae del texto de entrada por el usuario.
                        dgvTokens.Rows[i].Cells[1].Value = tokens[i].Text;
                    }
                    else //Mostramos los simbolos desconocidos por el usuario.
                    {
                        AnalisisLexico lexico = new AnalisisLexico();
                        if (i > 0)
                        {
                            txtOutput.Text += "\n" + lexico.GetUnkownTokens(tokens)[i - i];
                        }
                        else
                        {
                            txtOutput.Text += "\n" + lexico.GetUnkownTokens(tokens)[i];
                        }
                    }
                }
                //Mostramos un mensaje :DA
                txtOutput.Text += "\n<CA> Analisis lexico correctamente...";
            }
            catch (Exception ex)
            {
                //Para que la aplicación no congele, manejamos los errores con el mensaje generado.
                txtOutput.Text += "\n<CA> {0}" + ex.Message;
                txtOutput.Find("\n<CA> " + ex.Message);
                txtOutput.SelectionColor = Color.Red;
            }
        }
        /// <summary>
        ///     Metodo para verificar el texto inicial en la consola.
        /// </summary>
        /// <returns></returns>
        bool VerificarTextoInicial()
        {
            bool res = false;
            string Text = txtConsola.Text;

            if (Text.Contains("<CA> Consola lista para analizar...")) //Verificamos si se encuentra el DEFAULT
            {
                txtConsola.Text += "\n<CA> Debe limpiar la consola para agregar texto";
                res = true;
            }
            else if (string.IsNullOrEmpty(txtConsola.Text)) //Verificamos si la consola esta vacia.
            {
                txtConsola.Text += "\n<CA> Consala limpia... Ingresa algo para realizar el analisis.";
                res = true;
            }

            return res;
        }


        public frm_main()
        {
            InitializeComponent();
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            txtConsola.Clear();
            txtConsola.Text = "program OurScript" +
                            "\n{" +
                            "\n      var Mensaje," +
                            "\n       var x," +
                            "\n      var y = 5*400," +
                            "\n    int z," +
                            "\n     Mensaje = \"Hola Mundo\" ," +
                            "\n       z =17," +
                            "\n       x=y+z," +
                            "\n     print Mensaje," +
                            "\n     print x," +
                            "\n}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtConsola.Clear();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            Instancia_LSS(txtConsola.Text, 1); //Realizar prueba del aspecto Léxico
            Instancia_LSS(txtConsola.Text, 2); //Realizar prueba del aspecto Sintáctico
            Instancia_LSS(txtConsola.Text, 3); //Realizar prueba del aspecto Semántico
        }

        private void btnLexico_Click(object sender, EventArgs e)
        {
            Instancia_LSS(txtConsola.Text, 1);
        }

        private void btnSintactico_Click(object sender, EventArgs e)
        {
            Instancia_LSS(txtConsola.Text, 2);
        }

        private void btnSemantico_Click(object sender, EventArgs e)
        {
            Instancia_LSS(txtConsola.Text, 3);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            frm_manual manual_form = new frm_manual();
            manual_form.Show();
        }
    }
}
