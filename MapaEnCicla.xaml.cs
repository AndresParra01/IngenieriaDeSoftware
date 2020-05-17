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
    public partial class MapaEnCicla : ContentPage
    {
        public MapaEnCicla()
        {
            InitializeComponent();

			MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(6.246561, -75.577241), Distance.FromKilometers(20)));

			GenerarPins();
		}

		private void GenerarPins()
		{
			var pins = new List<Pin>
			{
				new Pin { Type = PinType.Place, Label = "Moravia", Address = "CALLE 82A # 52-29", Position = new Position(6.276585,-75.564804) },
				new Pin { Type = PinType.Place, Label = "Universidad", Address = "CALLE 73 # 52-2", Position = new Position(6.269267,-75.5653) },
				new Pin { Type = PinType.Place, Label = "Ruta N", Address = "CARRERA 52 # 67A-13", Position = new Position(6.265182,-75.566348) },
				new Pin { Type = PinType.Place, Label = "Punto Cero", Address = "CARRERA 64 # 65-59", Position = new Position(6.265161,-75.575066) },
				new Pin { Type = PinType.Place, Label = "Universidad Nacional", Address = "CALLE 59A # 64E-44", Position = new Position(6.259663,-75.578812) },
				new Pin { Type = PinType.Place, Label = "Colombia", Address = "CARRERA 65 # 50-29", Position = new Position(6.25649,-75.581024) },
				new Pin { Type = PinType.Place, Label = "Suramericana", Address = "CALLE 47D # 65-92", Position = new Position(6.253003,-75.582687) },
				new Pin { Type = PinType.Place, Label = "Estadio", Address = "CALLE 47D # 70-82", Position = new Position(6.253349,-75.587692) },
				new Pin { Type = PinType.Place, Label = "San Juan", Address = "CALLE 44 # 69-133", Position = new Position(6.249014,-75.588585) },
				new Pin { Type = PinType.Place, Label = "UPB", Address = "CARRERA 70 # CIRCULAR 1-50", Position = new Position(6.244998,-75.589188) },
				new Pin { Type = PinType.Place, Label = "Los Colores", Address = "CARRERA 70 # TRANSVERSAL 51A", Position = new Position(6.260004,-75.585136) },
				new Pin { Type = PinType.Place, Label = "Floresta", Address = "CALLE 48 # 79-46", Position = new Position(6.258628,-75.597366) },
				new Pin { Type = PinType.Place, Label = "Robledo", Address = "CARRERA 77B # 60-22", Position = new Position(6.271922,-75.591324) },
				new Pin { Type = PinType.Place, Label = "Plaza de La Libertad", Address = "CALLE 42C # 53A-24", Position = new Position(6.2434627,-75.5746534) },
				new Pin { Type = PinType.Place, Label = "Parque de Los Mangos", Address = "CARRERA 66B # 40-51", Position = new Position(6.245383,-75.584008) },
				new Pin { Type = PinType.Place, Label = "La 33", Address = "CARRERA 65 # 32F-12", Position = new Position(6.239151,-75.583073) },
				new Pin { Type = PinType.Place, Label = "Primer Parque de Laureles", Address = "CARRERA 639D # 73-95", Position = new Position(6.24597,-75.593812) },
				new Pin { Type = PinType.Place, Label = "Rosales", Address = "CARRERA 70 # 29-73", Position = new Position(6.231326,-75.591538) },
				new Pin { Type = PinType.Place, Label = "Maria Luisa Calle", Address = "CARRERA 70 # 3-138", Position = new Position(6.21553,-75.593096) },
				new Pin { Type = PinType.Place, Label = "Sabaneta Parque", Address = "CARRERA 65 # 50-29", Position = new Position(6.151631,-75.615623) },
				new Pin { Type = PinType.Place, Label = "Sabaneta Metro", Address = "CALLE 67sur - 49", Position = new Position(6.1568288,-75.616668) },
				new Pin { Type = PinType.Place, Label = "San Pedro y San Pablo", Address = "CALLE 48 CON CARRERA 77A", Position = new Position(6.258327,-75.594235) },
				new Pin { Type = PinType.Place, Label = "Pies Descalzos I", Address = "CARRERA 57A CON CALLE 42A", Position = new Position(6.245512,-75.577011) },
				new Pin { Type = PinType.Place, Label = "�rea Metropolitana", Address = "CALLE 41 CON CARRERA 53", Position = new Position(6.242481,-75.573872) },
				new Pin { Type = PinType.Place, Label = "Plaza Mayor", Address = "CALLE 41 # 55-80", Position = new Position(6.2426281,-75.5756351) },
				new Pin { Type = PinType.Place, Label = "Parque de Las Luces I", Address = "CALLE 44 # 52A-14", Position = new Position(6.246078,-75.571561) },
				new Pin { Type = PinType.Place, Label = "Pies Descalzos II", Address = "CARRERA 57A CON CALLE 42A", Position = new Position(6.245322,-75.576857) },
				new Pin { Type = PinType.Place, Label = "Segundo Parque de Laureles", Address = "Carrera 75 # 38-10", Position = new Position(6.245062,-75.597297) },
				new Pin { Type = PinType.Place, Label = "San Joaqu�n", Address = "CARRERA 66B CON CIRCULAR 2-1", Position = new Position(6.243337,-75.58609) },
				new Pin { Type = PinType.Place, Label = "Orqu�deas", Address = "CALLE 53 # 73-81", Position = new Position(6.262605,-75.58895) },
				new Pin { Type = PinType.Place, Label = "Parque de Las Luces II", Address = "CALLE 44 # 52A-14", Position = new Position(6.245594,-75.571763) },
				new Pin { Type = PinType.Place, Label = "Santa Teresita", Address = "CARRERA 76 # 34A-32", Position = new Position(6.242021,-75.596746) },
				new Pin { Type = PinType.Place, Label = "Cisneros - Unaula", Address = "Carrera 57 con Calle 48", Position = new Position(6.250576,-75.574814) },
				new Pin { Type = PinType.Place, Label = "La 65", Address = "CARRERA 65 # 44-41", Position = new Position(6.248949,-75.583459) },
				new Pin { Type = PinType.Place, Label = "Unidad Deportiva de Bel�n", Address = "CALLE 30A # 66B-18", Position = new Position(6.232526,-75.587564) },
				new Pin { Type = PinType.Place, Label = "Mar�a Mulata", Address = "CALLE 44A # 75-34", Position = new Position(6.250549,-75.594719) },
				new Pin { Type = PinType.Place, Label = "Circular Primera", Address = "TRANSVERSAL 39B # CIRCULAR 1-2 ", Position = new Position(6.241859,-75.591929) },
				new Pin { Type = PinType.Place, Label = "Batall�n", Address = "CALLE 49B #78A-2", Position = new Position(6.262189,-75.595039) },
				new Pin { Type = PinType.Place, Label = "Pedro Nel G�mez", Address = "CARRERA 76 # 39B-13", Position = new Position(6.246906,-75.596625) },
				new Pin { Type = PinType.Place, Label = "Estacion movil", Address = "CALLE 30 CON CARRERA 55", Position = new Position(6.149014,-75.580527) },
				new Pin { Type = PinType.Place, Label = "Cacique Candela", Address = "CIRCULAR 73B # 39-4", Position = new Position(6.243788,-75.595409) },
				new Pin { Type = PinType.Place, Label = "Florida Nueva", Address = "CALLE 47 # 72-21", Position = new Position(6.252601,-75.590333) },
				new Pin { Type = PinType.Place, Label = "Primavera", Address = "Calle 24 con Carrera 43F", Position = new Position(6.2253,-75.572449) },
				new Pin { Type = PinType.Place, Label = "SIU-UdeA", Address = "CARRERA 52 # 61-21", Position = new Position(6.260481,-75.567179) },
				new Pin { Type = PinType.Place, Label = "Industriales Metro", Address = "CARRERA 48 # 27-86", Position = new Position(6.23055,-75.574373) },
				new Pin { Type = PinType.Place, Label = "Nutibara", Address = "CARRERA 65 # 30-1", Position = new Position(6.231811,-75.582953) },
				new Pin { Type = PinType.Place, Label = "Parque San Joaqu�n", Address = "CARRERA 67A CON CIRCULAR 3", Position = new Position(6.245576,-75.586801) },
				new Pin { Type = PinType.Place, Label = "R�o Aburr�", Address = "CARRERA 48 # 27-4", Position = new Position(6.22851,-75.574658) },
				new Pin { Type = PinType.Place, Label = "Villa Carlota", Address = "CARRERA 48 # 18-100", Position = new Position(6.220012,-75.575431) },
				new Pin { Type = PinType.Place, Label = "Ciudad del R�o", Address = "CALLE 19A - CARRERA 43G", Position = new Position(6.222324,-75.572961) },
				new Pin { Type = PinType.Place, Label = "Otra Banda", Address = "CARRERA 64A CON CALLE 50", Position = new Position(6.255589,-75.579259) },
				new Pin { Type = PinType.Place, Label = "Palac�", Address = "CARRERA 50 CON CALLE 35", Position = new Position(6.236338,-75.573291) },
				new Pin { Type = PinType.Place, Label = "MAMM", Address = "CARRERA 48 # 19A-108", Position = new Position(6.22378,-75.574966) },
				new Pin { Type = PinType.Place, Label = "Juan Pablo II", Address = "CARRERA 70 # 16-18", Position = new Position(6.222392,-75.592235) },
				new Pin { Type = PinType.Place, Label = "Industriales Metropl�s", Address = "CARRERA 52 # 29B-138", Position = new Position(6.231406,-75.577222) },
				new Pin { Type = PinType.Place, Label = "Museo de Antioquia", Address = "CARRERA 52 # 52-36", Position = new Position(6.251826,-75.568796) },
				new Pin { Type = PinType.Place, Label = "Campus Nacional", Address = "CALLE 59A # 64E-44", Position = new Position(6.260703,-75.57858) },
				new Pin { Type = PinType.Place, Label = "M�laga", Address = "CARRERA 48 # 27-4", Position = new Position(6.24655,-75.569954) },
				new Pin { Type = PinType.Place, Label = "Calle 51 Los Colores", Address = "CALLE 51 con Cr 78B", Position = new Position(6.26337958,-75.59509188) },
				new Pin { Type = PinType.Place, Label = "Telemedell�n", Address = "CARRERA 43f - Cll 18", Position = new Position(6.22006,-75.5714) },
				new Pin { Type = PinType.Place, Label = "Parques del r�o", Address = "CALLE 42C - Cr 63B", Position = new Position(6.245546,-75.580543) },
				new Pin { Type = PinType.Place, Label = "Salazar y Herrera", Address = "CARRERA 71 - calle 52 -16", Position = new Position(6.26043075,-75.58616817) },
				new Pin { Type = PinType.Place, Label = "Calle 19A Villa Carlota", Address = "CALLE 19A con Cr 43f", Position = new Position(6.222081,-75.571117) },
				new Pin { Type = PinType.Place, Label = "San Antonio", Address = "CARRERA 51 entre Cll 46 y Cll 47", Position = new Position(6.24841132,-75.56905568) },
				new Pin { Type = PinType.Place, Label = "Parque Berrio", Address = "CARRERA 51 con Cll 50", Position = new Position(6.25004308,-75.56840926) },
				new Pin { Type = PinType.Place, Label = "Palacio de la Cultura", Address = "CARRERA  51 con Cll 51", Position = new Position(6.25066699,-75.56807131) },
				new Pin { Type = PinType.Place, Label = "Picacha con 76", Address = "CARRERA  76 con La Picacha", Position = new Position(6.23525042,-75.59647322) },
				new Pin { Type = PinType.Place, Label = "Unicentro", Address = "CALLE 34 entre Cr 65D y Cr 66A", Position = new Position(6.23988984,-75.58665901) },
				new Pin { Type = PinType.Place, Label = "Bulerias", Address = "DIAGONAL 74B con Cll 32F", Position = new Position(6.23857801,-75.59041411) },
				new Pin { Type = PinType.Place, Label = "Cafetero", Address = "CALLE  32F entre Cr 66B y Cr 65F", Position = new Position(6.23858334,-75.58617622) },
				new Pin { Type = PinType.Place, Label = "Distrito Creativo", Address = "CARRERA  46 # 34 - 46", Position = new Position(6.23461583,-75.57196051) }
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