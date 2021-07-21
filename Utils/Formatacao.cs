using System.Text.RegularExpressions;

namespace api_consulta_cnpj.Utils
{
    public static class Formatacao
    {
        public static string ExtrairNumeros(string str) => Regex.Replace(str ?? string.Empty, @"\D", "");
    }
}