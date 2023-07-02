using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace maui_reactiveui_repro;

public partial class Page
{
    public Page()
    {
        InitializeComponent();

        this.WhenActivated(disposable =>
        {
            Console.WriteLine(ViewModel.N);
        });
    }
}