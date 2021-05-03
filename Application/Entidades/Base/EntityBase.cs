using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Entidades.Base
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}