using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string PrefID { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public DateTime DOB { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }

        public List<UserModel> InMemoryUsers()
        {
            return new List<UserModel>()
            {
                new UserModel{ UserID=1,PrefID="B001",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=2,PrefID="B002",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=3,PrefID="B003",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=4,PrefID="B004",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=5,PrefID="B005",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=6,PrefID="B006",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=7,PrefID="B007",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=8,PrefID="B008",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=9,PrefID="B009",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=10,PrefID="B0010",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=11,PrefID="B0011",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=12,PrefID="B0012",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=13,PrefID="B0013",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=14,PrefID="B0014",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=15,PrefID="B0015",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=16,PrefID="B0016",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=17,PrefID="B0017",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"},
                new UserModel{ UserID=18,PrefID="B0018",Email="bandi.vamshi408@gmail.com",PhoneNo="9493736926",DOB= new DateTime(),FirstName="Vamshi",MiddleName="Krishna",LastName="Bandi",DisplayName="Vamshi .NET Developer"}
            };
        }
    }

}
