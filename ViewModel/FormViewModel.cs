using FreeezeDotNet.Model;

namespace FreeezeDotNet.ViewModel{
    public class FormViewModel{

        public string Name {get;set;}
        public FoodTypeEnum Type{get;set;}
        public FoodPortionEnum Portion{get;set;}
        public int Freezer{get;set;}
        public int Drawer{get;set;}
        public string Notes{get;set;}

    }
}

// {"name":"Uva","type":"Verdura","portion":"x2","freezer":"Cantina","drawer":"Cassetto1","notes":"nota"}
