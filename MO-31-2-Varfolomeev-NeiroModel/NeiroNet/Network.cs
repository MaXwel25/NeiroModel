using System.Windows.Forms;

namespace MO_31_2_Varfolomeev_NeiroModel.NeiroNet
{
    class Network
    {
        // все слои сети
        private InputLayer input_layer = null;
        private HiddenLayer hidden_layer1 = new HiddenLayer(70, 15, NeironType.Hidden, nameof(hidden_layer1));
        private HiddenLayer hidden_layer2 = new HiddenLayer(32, 70, NeironType.Hidden, nameof(hidden_layer2));
        private OutputLayer output_layer = new OutputLayer(10, 32, NeironType.Output, nameof(output_layer));

        private double[] fact = new double[10];
        private double[] e_error_avr;

        // свойства
        public double[] Fact { get => fact; }
        // среднее значение энергии ошибки эпохи обучения
        public double[] E_errors_avr { get => e_error_avr; set => e_error_avr = value;  }

        // для инициализации всех слоёв
        public void InitializeLayers()
        {
            hidden_layer1 = new HiddenLayer(70, 15, NeironType.Hidden, nameof(hidden_layer1));
            hidden_layer2 = new HiddenLayer(32, 70, NeironType.Hidden, nameof(hidden_layer2));
            output_layer = new OutputLayer(10, 32, NeironType.Output, nameof(output_layer));
        }

        // конструктор
        public Network() { }
    }
}
