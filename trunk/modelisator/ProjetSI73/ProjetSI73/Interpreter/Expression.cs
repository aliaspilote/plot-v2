using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Interpreter
{
    public abstract class Expression
{
  public abstract bool evalue(string description);

  // partie analyse syntaxique
  protected static string source;
  protected static int index;
  protected static string jeton;

  protected static void prochainJeton()
  {
    while ((index < source.Length) && (source[index] ==
      ' '))
      index++;
    if (index == source.Length)
      jeton = null;
    else if ((source[index] == '(') || (source[index] ==
      ')'))
    {
      jeton = source.Substring(index, 1);
      index++;
    }
    else
    {
      int debut = index;
      while ((index < source.Length) && (source[index] !=
        ' ') && (source[index] != ')'))
        index++;
      jeton = source.Substring(debut, index - debut);
    }
  }

  public static Expression analyse(string source)
  {
    Expression.source = source;
    index = 0;
    prochainJeton();
    return OperateurOu.parse();
  }

  public static Expression parse()
  {
    Expression resultat;
    if (jeton == "(")
    {
      prochainJeton();
      resultat = OperateurOu.parse();
      if (jeton == null)
        throw new Exception("Erreur de syntaxe");
      if (jeton != ")")
        throw new Exception("Erreur de syntaxe");
      prochainJeton();
    }
    else
      resultat = MotCle.parse();
    return resultat;
  }
}
}
