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
    public partial class MapaAccidentabilidad : ContentPage
    {
        public MapaAccidentabilidad()
        {
            InitializeComponent();

            MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(6.246561, -75.577241), Distance.FromKilometers(20)));

			GenerarPins();
		}

		private void GenerarPins()
		{
			var pins = new List<Pin>
			{
			new Pin { Type = PinType.Place, Label = "Palenque", Address = "CL 68 CR 87", Position = new Position(6.278596, -75.594975) },
			new Pin { Type = PinType.Place, Label = "Campo Alegre", Address = "CL 44 CR 93", Position = new Position(6.254420, -75.610577) },
			new Pin { Type = PinType.Place, Label = "Villatina", Address = "CR 16 CL 56", Position = new Position(6.238351, -75.539421) },
			new Pin { Type = PinType.Place, Label = "Las Granjas", Address = "CR 41 CL 85", Position = new Position(6.169312, -75.586778) },
			new Pin { Type = PinType.Place, Label = "Kennedy", Address = "CR 76 CL 91", Position = new Position(6.287773, -75.582009) },
			new Pin { Type = PinType.Place, Label = "Villa Hermosa", Address = "CR 39 CL 66", Position = new Position(6.340756, -75.572077) },
			new Pin { Type = PinType.Place, Label = "Miranda", Address = "CR 52 CL 82", Position = new Position(6.005609, -74.813865) },
			new Pin { Type = PinType.Place, Label = "Centro Administrativo", Address = "CR 55 CL 41", Position = new Position(6.242711, -75.575294) },
			new Pin { Type = PinType.Place, Label = "Manrique Oriental", Address = "CR 41 CL 72", Position = new Position(6.268029, -75.552424) },
			new Pin { Type = PinType.Place, Label = "Manrique Oriental", Address = "CR 36 A CL 68", Position = new Position(6.263230, -75.547871) },
			new Pin { Type = PinType.Place, Label = "Boston", Address = "CL 56 CR 41", Position = new Position(6.250728, -75.559210) },
			new Pin { Type = PinType.Place, Label = "Santander", Address = "CR 80 CL 102", Position = new Position(6.302582, -75.578610) },
			new Pin { Type = PinType.Place, Label = "Villatina", Address = "CL 52 CR 19", Position = new Position(4.640621, -74.070845) },
			new Pin { Type = PinType.Place, Label = "Cabecera San Antonio de Prado", Address = "CL 39 D sur CR 66 A", Position = new Position(6.250966, -75.573960) },
			new Pin { Type = PinType.Place, Label = "Veinte de Julio", Address = "CL 39 CR 96", Position = new Position(6.254359, -75.615326) },
			new Pin { Type = PinType.Place, Label = "Loreto", Address = "CR 27 CL 38", Position = new Position(6.258689, -75.603460) },
			new Pin { Type = PinType.Place, Label = "Los Conquistadores", Address = "CR 62 CL 32", Position = new Position(6.164423, -75.621851) },
			new Pin { Type = PinType.Place, Label = "B. Cerro  El Volador", Address = "CL 59 CR 65", Position = new Position(6.259686, -75.580043) },
			new Pin { Type = PinType.Place, Label = "Aures No.1", Address = "CL 77 A CR 88", Position = new Position(6.284516, -75.591612) },
			new Pin { Type = PinType.Place, Label = "La Mansión", Address = "CR 41 A CL 66", Position = new Position(6.181238, -75.599162) },
			new Pin { Type = PinType.Place, Label = "Girardot", Address = "CR 65 CL 98", Position = new Position(4.688396, -74.069716) },
			new Pin { Type = PinType.Place, Label = "Campo Valdés No. 2", Address = "CL 79 CR 41", Position = new Position(6.284651, -75.587058) },
			new Pin { Type = PinType.Place, Label = "El Rincón", Address = "CR 79 CL 3", Position = new Position(6.213439, -75.602523) }
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