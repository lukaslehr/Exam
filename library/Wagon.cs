using System.ComponentModel.DataAnnotations;

namespace library
{


    public class Wagon
    {
        public int Id { get; set; }


        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public int LocomotiveID { get; set; }

        #nullable enable
        public Locomotive? Locomotive { get; set; }

    }

    public class Locomotive
    {
    }
}
