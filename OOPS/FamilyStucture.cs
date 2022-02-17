

namespace OOPS
{
    public class FamilyStucture
    {
        public string? Grandfather { get; set; }
        public string? Grandmother { get; set; }
    }
    public class RealMotherFather : FamilyStucture
    {
        public string? Father { get; set; }
        public string? FatherMother { get; set; }
    }

    public class Children : RealMotherFather
    {
        
        int ? ChildrenCount { get; set; } = 0;
    }

}
    


