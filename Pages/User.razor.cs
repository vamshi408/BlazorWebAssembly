using BlazorWebAssembly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Pages
{
    public partial class User
    {
        private List<UserModel> employeeList;
        private List<UserModel> selectedEmployees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            UserModel userModel = new UserModel();
            employeeList = userModel.InMemoryUsers();
            await base.OnInitializedAsync();
        }
    }
}
