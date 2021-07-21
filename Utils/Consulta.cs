using api_consulta_cnpj.Data.Repository;
using api_consulta_cnpj.Model;
using System;
using System.Net.Http;

namespace api_consulta_cnpj.Utils
{
    public class Consulta
    {
        private readonly repository_consultacnpj _rep;

        public Consulta(repository_consultacnpj _rep) => this._rep = _rep;

        public string Consultar(string cnpj)
        {
            consultacnpj consultacnpj = _rep.GetById(cnpj);

            if (consultacnpj == null)                                                                   //CNPJ Não existe na base
            {
                consultacnpj = ConsultarReceitaWS(cnpj);
                _rep.Insert(consultacnpj);
                _rep.Commit();
            }
            else if (string.IsNullOrEmpty(consultacnpj.dadoscnpj) ||
                     DateTime.Now.Date.Subtract(consultacnpj.dataultimaatualizacao.Date).Days > 20)     //Última consulta realizada a mais de 20 dias
            {
                consultacnpj = ConsultarReceitaWS(cnpj);
                _rep.Update(consultacnpj);
                _rep.Commit();
            }

            return consultacnpj.dadoscnpj;
        }

        private consultacnpj ConsultarReceitaWS(string cnpj)
        {
            using (HttpClient client = new HttpClient())
            {
                string resultado = client.GetStringAsync(string.Format("https://www.receitaws.com.br/v1/cnpj/{0}", cnpj)).Result;
                if (string.IsNullOrEmpty(resultado))
                    return new consultacnpj(cnpj, "", DateTime.Now);
                else return new consultacnpj(cnpj, resultado, DateTime.Now);
            }
        }
    }
}