using DocsBr;

namespace api_consulta_cnpj.Utils
{
    public static class Validacao
    {
        public static bool ValidarCnpj(string cnpj)
        {
            bool ret = false;
            cnpj = Formatacao.ExtrairNumeros(cnpj);

            if (!string.IsNullOrEmpty(cnpj))
                if (new CNPJ(cnpj).IsValid())
                    ret = true;

            return ret;
        }
    }
}