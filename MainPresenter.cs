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
          
            _view.ShowedRunnerStats += ShowRunnerStats;
            _view.ShowedPopulationStats += ShowPopulationStats;
        }
        public void Run()
        {
            _view.Show();
          
        
        }
       
        private void ShowRunnerStats()
        {

            List<List<string>> data = _model.GetData("dataBeg.csv");
            List<List<float>> dataChart = DataConverter.ConvertStringToFloat(data);
            _view.DrawData(data);
            _view.ClearGraphic();
            for (int i = 0; i < dataChart[0].Count; i++)
            {
                _view.DrawGraphic(GraphicCalculactor.CalculateGraphicDots(dataChart, i));
            }
        }
        private void ShowPopulationStats()
        {

            List<List<string>> data = _model.GetData("dataNaselenie.csv");
            _view.DrawData(data);
            _view.ClearGraphic();
            _view.DrawGraphic(GraphicCalculactor.CalculateGraphicDots(DataConverter.ConvertStringToFloat(data), 1));
        }
    }
}
