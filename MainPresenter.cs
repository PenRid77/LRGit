using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
     class MainPresenter : IPresenter
    {
        private readonly IMainView _view;
        private readonly IMainModel _model;
        

        public MainPresenter(IMainView view, IMainModel model)
        {
            _view = view;
            _model = model;
          
        }
        public void Run()
        {
            _view.Show();
          
        
        }
       
    }
}
