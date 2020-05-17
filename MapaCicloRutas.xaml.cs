using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace IngenieriaParcial3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapaCicloRutas : ContentPage
    {
        public MapaCicloRutas()
        {
            InitializeComponent();

			MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(6.246561, -75.577241), Distance.FromKilometers(20)));

			GenerarPins();
		}

		private void GenerarPins()
		{
			var pins = new List<Pin>
			{
				new Pin { Type = PinType.Place, Label = "Calle 29", Address =" Calle 29", Position = new Position(6.229169, -75.571239) },
				new Pin { Type = PinType.Place, Label = "Carrera 65", Address = "Ciclorruta Carrera 65", Position = new Position(6.260256, -75.579712) },
				new Pin { Type = PinType.Place, Label = "Ciclorruta Fase 3", Address = "Ciclorruta Fase 3", Position = new Position(6.232570, -75.597400) },
				new Pin { Type = PinType.Place, Label = "Ciclorruta Fase 3", Address = "Ciclorruta Fase 3", Position = new Position(6.232570, -75.598400) },
				new Pin { Type = PinType.Place, Label = "Calle 30A", Address = "Calle 30A", Position = new Position(6.232470, -75.595400) },
				new Pin { Type = PinType.Place, Label = "Carrera 70", Address = "Carrera 70", Position = new Position(6.249848, -75.588780) },
				new Pin { Type = PinType.Place, Label = "Diagonal 74B", Address = "Diagonal 74B", Position = new Position(6.236651, -75.592712) },
				new Pin { Type = PinType.Place, Label = "Calle 46", Address = "Ciclorruta Fase 2", Position = new Position(6.2365651, -75.5978712) },
				new Pin { Type = PinType.Place, Label = "Calle 73", Address = "Calle 73", Position = new Position(6.151944, -75.618479) },
				new Pin { Type = PinType.Place, Label = "Carrera 70", Address = "Carrera 70", Position = new Position(6.249774, -75.588437) },
				new Pin { Type = PinType.Place, Label = "Carrera 66B", Address = "Carrera 66B", Position = new Position(6.237243, -75.587497) },
				new Pin { Type = PinType.Place, Label = "Carrera 69", Address = "Carrera 69", Position = new Position(6.234908, -75.590995) },
				new Pin { Type = PinType.Place, Label = "Calle 12 Sur", Address = "Calle 12 Sur", Position = new Position(6.197070, -75.592921) },
				new Pin { Type = PinType.Place, Label = "Calle 6 Sur", Address = "Calle 6 Sur", Position = new Position(6.201872, -75.581230) },
				new Pin { Type = PinType.Place, Label = "Calle 20 - 19", Address = "Calle 20 - 19", Position = new Position(6.224408, -75.596237) },
				new Pin { Type = PinType.Place, Label = "Cerro Nutibara", Address = "Cerro Nutibara", Position = new Position(6.235889, -75.579837) },
				new Pin { Type = PinType.Place, Label = "Calle 65", Address = "Calle 65", Position = new Position(6.257406, -75.551435) },
				new Pin { Type = PinType.Place, Label = "Calle 59A", Address = "Calle 59A", Position = new Position(6.251599, -75.548266) },
				new Pin { Type = PinType.Place, Label = "Calle 78", Address = "Calle 78", Position = new Position(6.282887, -75.586751) },
				new Pin { Type = PinType.Place, Label = "Calle 73", Address = "Calle 73", Position = new Position(6.151944, -75.618479) },
				new Pin { Type = PinType.Place, Label = "Carrera 52", Address = "Carrera 52", Position = new Position(6.232099, -75.578145) },
				new Pin { Type = PinType.Place, Label = "Calle 41", Address = "Calle 41", Position = new Position(6.241827, -75.570938) },
				new Pin { Type = PinType.Place, Label = "Calle 77", Address = "Calle 77", Position = new Position(6.285838, -75.591799) },
				new Pin { Type = PinType.Place, Label = "Carrera 62", Address = "Carrera 62", Position = new Position(6.302900, -75.557906) },
				new Pin { Type = PinType.Place, Label = "Calle 72", Address = "Calle 72", Position = new Position(6.272609, -75.575847) },
				new Pin { Type = PinType.Place, Label = "Parque Juanes", Address = "Parque Juanes", Position = new Position(6.290374, -75.569489) },
				new Pin { Type = PinType.Place, Label = "Carrera 83", Address = "Carrera 83", Position = new Position(6.290469, -75.584761) },
				new Pin { Type = PinType.Place, Label = "Calle 71", Address = "Calle 71", Position = new Position(6.272090, -75.578001) },
				new Pin { Type = PinType.Place, Label = "Ciclocarril", Address = "Calle 51 - 53", Position = new Position(6.251671, -75.570403) },
				new Pin { Type = PinType.Place, Label = "Ciclocarril", Address = "Carrera 79", Position = new Position(6.257283, -75.597465) },
				new Pin { Type = PinType.Place, Label = "Ciclocarril", Address = "Calle 65", Position = new Position(6.286716, -75.605705) },
				new Pin { Type = PinType.Place, Label = "Ciclocarril", Address = "Calle 59A", Position = new Position(6.251599, -75.548266) },
				new Pin { Type = PinType.Place, Label = "Carrera 43A", Address = "Carrera 43A", Position = new Position(6.181244, -75.582815) },
				new Pin { Type = PinType.Place, Label = "Ruta de Campeones", Address = "Ruta de Campeones", Position = new Position(6.245500, -75.569873) },
				new Pin { Type = PinType.Place, Label = "Carrera 74", Address = "Carrera 74", Position = new Position(6.261045, -75.589790) },
				new Pin { Type = PinType.Place, Label = "Av. del Río", Address = "c", Position = new Position(6.261290, -75.589801) },
				new Pin { Type = PinType.Place, Label = "Carrera 62", Address = "Ciclorruta Parque del Río", Position = new Position(6.261290, -75.589801) },
				new Pin { Type = PinType.Place, Label = "Carrera 50A - 51", Address = "Carrera 51", Position = new Position(6.255787, -75.567261) },
				new Pin { Type = PinType.Place, Label = "Carrera 77B", Address = "Carrera 77B", Position = new Position(6.261584, -75.593574) },
				new Pin { Type = PinType.Place, Label = "Municipio de Sabaneta", Address = "Ciclorrutas propuestas municipios AMVA", Position = new Position(6.264584, -75.596574) },
				new Pin { Type = PinType.Place, Label = "Carrera 48A - 49", Address = "Carrera 48A - 49", Position = new Position(6.269035, -75.557631) },
				new Pin { Type = PinType.Place, Label = "Carrera 65G", Address = "Carrera 65G", Position = new Position(6.222463, -75.586070) },
				new Pin { Type = PinType.Place, Label = "Carrera 66B", Address = "Carrera 66B", Position = new Position(6.237211, -75.587486) },
				new Pin { Type = PinType.Place, Label = "Calle 31A - 32 - 32F", Address = "Calle 32", Position = new Position(6.234570, -75.596643) },
				new Pin { Type = PinType.Place, Label = "Calle 29 - 28", Address = "Calle 29 - 28", Position = new Position(6.230643, -75.592680) },
				new Pin { Type = PinType.Place, Label = "Carrera 84", Address = "Carrera 84", Position = new Position(6.241496, -75.607911) },
				new Pin { Type = PinType.Place, Label = "Calle 35 - 37", Address = "Calle 35 - 37", Position = new Position(6.243499, -75.602497) },
				new Pin { Type = PinType.Place, Label = "Carrera 53", Address = "Carrera 53", Position = new Position(6.237642, -75.575585) },
				new Pin { Type = PinType.Place, Label = "Calle 47D", Address = "Calle 47D", Position = new Position(6.254368, -75.592469) },
				new Pin { Type = PinType.Place, Label = "Carrera 78", Address = "Carrera 78", Position = new Position(6.265121, -75.593869) },
				new Pin { Type = PinType.Place, Label = "Carrera 48A", Address = "Carrera 48A", Position = new Position(6.196314, -75.580570) },
				new Pin { Type = PinType.Place, Label = "Vía a Piedra Blancas", Address = "Via al Tambo Mazo - Piedra Gorda El Placer", Position = new Position(6.279403, -75.497103) },
				new Pin { Type = PinType.Place, Label = "Carretera al Mar", Address = "Carretera al Mar", Position = new Position(6.258219, -75.585067) },
				new Pin { Type = PinType.Place, Label = "Via Santa Elena", Address = "Via a Santa Elena", Position = new Position(6.231312, -75.536380) },
				new Pin { Type = PinType.Place, Label = "Longitudinal Oriental", Address = "Longitudinal Oriental", Position = new Position(6.249410, -75.564757) },
				new Pin { Type = PinType.Place, Label = "Carrera 9 -10", Address = "Carrera 9 -10", Position = new Position(6.230942, -75.542323) },
				new Pin { Type = PinType.Place, Label = "Calle 77A", Address = "Calle 77A", Position = new Position(6.291361, -75.592631) },
				new Pin { Type = PinType.Place, Label = "Carrera 53", Address = "Avenida Ferrocarril", Position = new Position(6.257215, -75.572162) },
				new Pin { Type = PinType.Place, Label = "Calle 49", Address = "Calle 49", Position = new Position(6.244448, -75.558087) },
				new Pin { Type = PinType.Place, Label = "Calle 10", Address = "Calle 10", Position = new Position(6.211528, -75.572530) },
				new Pin { Type = PinType.Place, Label = "Carrera 53", Address = "Carrera 53", Position = new Position(6.177024, -75.605796) },
				new Pin { Type = PinType.Place, Label = "Calle 80", Address = "Calle 80", Position = new Position(6.273026, -75.553901) },
				new Pin { Type = PinType.Place, Label = "Calle 95 - 95A", Address = "Calle 95 - 95A", Position = new Position(6.288141, -75.553274) },
				new Pin { Type = PinType.Place, Label = "Carrera 43A", Address = "Carrera 43A", Position = new Position(6.181244, -75.582815) },
				new Pin { Type = PinType.Place, Label = "Calle 94", Address = "Calle 94", Position = new Position(6.285968, -75.555371) }
			};

			foreach (var pin in pins)
			{
				MapView.Pins.Add(pin);
			}
		}

		private void Street_OnClicked(object sender, EventArgs e)
		{
			MapView.MapType = MapType.Street;
		}


		private void Hybrid_OnClicked(object sender, EventArgs e)
		{
			MapView.MapType = MapType.Hybrid;
		}

		private void Satellite_OnClicked(object sender, EventArgs e)
		{
			MapView.MapType = MapType.Satellite;
		}
	}
}