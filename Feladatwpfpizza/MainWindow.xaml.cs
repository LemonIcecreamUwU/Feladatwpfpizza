using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Feladatwpfpizza
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnRendel_Click(object sender, RoutedEventArgs e)
		{
			// Tészta kiválasztása
			string teszta = (lbTeszta.SelectedItem as ListBoxItem)?.Content.ToString() ?? "Nincs kiválasztva";

			// Méret kiválasztása
			string meret = (cbMeret.SelectedItem as ComboBoxItem)?.Content.ToString() ?? "Nincs kiválasztva";

			// Feltétek összegyűjtése
			List<string> feltetek = new List<string>();
			if (chSajt.IsChecked == true) feltetek.Add("Sajt");
			if (chSonka.IsChecked == true) feltetek.Add("Sonka");
			if (chGomba.IsChecked == true) feltetek.Add("Gomba");
			if (chOlivabogyo.IsChecked == true) feltetek.Add("Olívabogyó");
			if (chKukorica.IsChecked == true) feltetek.Add("Kukorica");

			string feltetSzoveg = feltetek.Count > 0 ? string.Join(", ", feltetek) : "Nincs feltét";

			// Átvétel módja
			string atvetel = rbHazhoz.IsChecked == true ? "Házhozszállítás"
							: rbSzemelyes.IsChecked == true ? "Személyes átvétel"
							: "Nincs kiválasztva";

			// Eredmény kiírása
			tbEredmeny.Text =
				$"--- Rendelés összegzése ---\n" +
				$"Tészta: {teszta}\n" +
				$"Méret: {meret}\n" +
				$"Feltétek: {feltetSzoveg}\n" +
				$"Átvétel módja: {atvetel}";
		}
	}
}