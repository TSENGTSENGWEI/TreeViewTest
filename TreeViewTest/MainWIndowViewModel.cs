using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TreeViewTest
{
    [INotifyPropertyChanged]
    internal partial class MainWIndowViewModel
    {

        public MainWIndowViewModel() 
        {
            nodetests = new ObservableCollection<TreeNodeTest>
            {
                new TreeNodeTest(){Title="Page1",Targatepage=new Page1()  },
                new TreeNodeTest(){Title="Page2",Targatepage=new Page2()  },
                new TreeNodeTest(){Title="Page3",Targatepage=new Page3()  },
            };
        }


        [ObservableProperty]
        private ObservableCollection<TreeNodeTest>? nodetests;

        [ObservableProperty]
        private Frame? sourceframe;

        [RelayCommand]
        private void ProgramLoaded(Window window)
        {
            if (window != null)
                sourceframe=window.FindName("frame1") as Frame; 
            if(sourceframe!=null)
            {
                Nodetests[0].Sourceframe= sourceframe;
                Nodetests[1].Sourceframe = sourceframe;
                Nodetests[2].Sourceframe = sourceframe;
            }
        }
    }
}
