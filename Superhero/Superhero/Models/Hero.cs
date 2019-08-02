using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Superhero.Models
{
    public class Hero
    {
        // name, alter ego, primary superhero ability, secondary superhero ability, and catchphrase.
        [Key]
        public int HeroId { get; set; }
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string Catchphrase { get; set; }
    }
}