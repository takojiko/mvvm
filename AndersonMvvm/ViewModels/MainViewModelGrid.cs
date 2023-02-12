using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonMvvm.ViewModels
{
    public sealed class MainViewModelGrid 
    {
        public MainViewModelGrid(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; }
        public string Name { get; set; }
    }
}
