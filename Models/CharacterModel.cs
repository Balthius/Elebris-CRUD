
using Elebris.Database.Manager;
using Elebris.Tooling.Blazor.Server.AnnotationAttributes;
using Elebris.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Elebris.CRUD.Models
{
    public class CharacterModel
    {
        public int Id { get; set; } = -1;

        [DisplayName("First Name")]
        [MinLength(2)]
        [MaxLength(20)]
        [Required]
        public string FirstName { get; set; }


        [DisplayName("Last Name")]
        [MinLength(2)]
        [MaxLength(20)]
        [Required]
        public string LastName { get; set; }

        [Range(3, 20, ErrorMessage = "This is outside an acceptable bound")]
        public int Strength { get; set; } = 10;

        [Range(3, 20, ErrorMessage = "This is outside an acceptable bound")]
        public int Constitution { get; set; } = 10;

        [Range(3, 20, ErrorMessage = "This is outside an acceptable bound")]
        public int Agility { get; set; } = 10;

        [Range(3, 20, ErrorMessage = "This is outside an acceptable bound")]
        public int Expertise { get; set; } = 10;

        [Range(3, 20, ErrorMessage = "This is outside an acceptable bound")]
        public int Wisdom { get; set; } = 10;

        [Range(3, 20, ErrorMessage = "This is outside an acceptable bound")]
        public int Intelligence { get; set; } = 10;

        public int CalculateAttributeTotal
        {
            get
            {
                return Strength + Constitution + Agility + Expertise + Wisdom + Intelligence;
            }
        }

        [MustBeTrue(ErrorMessage = "This is outside an acceptable bound")]
        public bool ValidAttributeTotal
        {
            get
            {
                return CalculateAttributeTotal == CharacterConfig.DEFAULT_MAX_TOTAL_VALUE;
            }
        }
    }
}
