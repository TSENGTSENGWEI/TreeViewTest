using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TreeViewTest
{
    [INotifyPropertyChanged]   
    internal partial class TreeNodeTest
    {

        [ObservableProperty]
        internal string? title;

        [ObservableProperty]
        internal Frame? sourceframe;

        [ObservableProperty]
        internal Page? targatepage;

        [RelayCommand]
        internal void Tree_M_Click(TreeNodeTest selectpage)
        {
            if(sourceframe!=null) 
                sourceframe.Navigate(selectpage.Targatepage);
        }
    }
}
