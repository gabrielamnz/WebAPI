using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [Table("Tarefas")]
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50,ErrorMessage ="O Título deve ter até 50 caracteres.")]
        public string Titulo { get; set; }

        [MaxLength(200,ErrorMessage ="A descrição deve ter até 200 caracteres.")]
        public string Descricao { get; set; }
    }
}