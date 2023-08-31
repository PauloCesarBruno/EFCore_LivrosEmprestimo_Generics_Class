using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace LivrariaControleEmprestimo.WEB.Models
{
    public class ModelLogin
    {
        public String Id { get; set; }

        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório !")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="O Email não possui um formato válido")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório !")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public Boolean ValidarLogin()
        {
            try
            {
                DAL objDal = new DAL();
                objDal.LimparParametros();
                string sql = $"Select Id, Nome From Login Where Email = '{Email}' And Senha = '{Senha}'";
                DataTable dt = objDal.RetDatatable(sql);

                if(dt.Rows.Count == 1)
                {
                    Id = dt.Rows[0]["Id"].ToString();
                    Nome = dt.Rows[0]["Nome"].ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
