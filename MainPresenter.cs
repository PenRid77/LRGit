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
            float sum = 0;
            for (int i = 1; i < data.Count; i++)
            {
                if (data[i][data[i].Count-1] == "Суббота" || data[i][data[i].Count - 1] == "Воскресенье")
                {
                    sum += dataChart[i-1][1];
                }


            }
            _view.DrawData(data, sum);
            _view.ClearGraphic();
            for (int i = 0; i < dataChart[0].Count; i++)
            {
                _view.DrawGraphic(GraphicCalculactor.CalculateGraphicDots(dataChart, i));
            }
        }
        private void ShowPopulationStats()
        {

            List<List<string>> data = _model.GetData("dataNaselenie.csv");
            List<List<float>> dataChart = DataConverter.ConvertStringToFloat(data);
            Console.WriteLine(dataChart[0][0]);
            float middle = 0;
            float sum = 0;
            for (int i = 2;i < dataChart.Count; i++)
            {
                sum += (dataChart[i-1][1] - dataChart[i - 2][1]); 
            }
            middle = sum / dataChart.Count;
            _view.DrawData(data, middle);
            _view.ClearGraphic();
            _view.DrawGraphic(GraphicCalculactor.CalculateGraphicDots(DataConverter.ConvertStringToFloat(data), 1));
        }
    }
}
