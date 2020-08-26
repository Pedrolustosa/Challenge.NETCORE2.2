using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CadCORE2._2.Models
{
	public class User
	{
		//ID - Preenchido automaticamente.
		[Key]
		public int UserID { get; set; }
		

		//Nome Completo
		[Column(TypeName ="nvarchar(250)")]
		[Required(ErrorMessage ="Por favor preencha o Campo com seu Nome Completo.")]
		[DisplayName("Nome Completo")]
		public string  NomeCompleto { get; set; }
		

		//Nascimento
		[Column(TypeName = "varchar(250)")]
		[Required(ErrorMessage = "Por favor preencha o Campo com a data do seu Nascimento.")]
		[DisplayName("Nascimento")]
		public string Nascimento { get; set; }
		

		//Salário
		[Column(TypeName = "varchar(250)")]
		[Required(ErrorMessage = "Por favor preencha o Campo com o seu Salário.")]
		[DisplayName("Salário")]
		public string Salario { get; set; }
	}
}
