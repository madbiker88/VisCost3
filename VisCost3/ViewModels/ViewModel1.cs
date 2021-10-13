using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace VisCost3.ViewModels
{
    class ViewModel1:ObservableRecipient
    {
        public string ViewTitle { get; set; }



        public ViewModel1()
        {
            ViewTitle = "View1 Title";
        }
    }


   
}
