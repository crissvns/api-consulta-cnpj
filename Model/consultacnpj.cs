using System;
using System.ComponentModel.DataAnnotations;

namespace api_consulta_cnpj.Model
{
    public class consultacnpj
    {
        public consultacnpj() { }

        public consultacnpj(string cnpj, string dadoscnpj, DateTime dataultimaatualizacao)
        {
            this.cnpj = cnpj;
            this.dadoscnpj = dadoscnpj;
            this.dataultimaatualizacao = dataultimaatualizacao;
        }

        [Key]
        public string cnpj { get; set; }

        [Required]
        public string dadoscnpj { get; set; }

        [Required]
        public DateTime dataultimaatualizacao { get; set; }
    }
}