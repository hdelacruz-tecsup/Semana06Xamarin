using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewGroup
{
	public partial class GroupedListXaml : ContentPage
	{
		private ObservableCollection<GroupedVeggieModel> grouped { get; set; }
		public GroupedListXaml()
		{
			InitializeComponent();
			grouped = new ObservableCollection<GroupedVeggieModel>();
			var veggieGroup = new GroupedVeggieModel() { LongName = "Animales", ShortName = "v" };
			var fruitGroup = new GroupedVeggieModel() { LongName = "Paises", ShortName = "f" };
			veggieGroup.Add(new VeggieModel() { Name = "Casa", IsReallyAVeggie = true, Comment = "Perro" });
			veggieGroup.Add(new VeggieModel() { Name = "Campo", IsReallyAVeggie = false, Comment = "Caballo" });
			veggieGroup.Add(new VeggieModel() { Name = "Granja", IsReallyAVeggie = true, Comment = "Gallinas" });
			veggieGroup.Add(new VeggieModel() { Name = "Jungla", IsReallyAVeggie = true, Comment = "Leon" });
			fruitGroup.Add(new VeggieModel() { Name = "Amerrica", IsReallyAVeggie = false, Comment = "Peru" });
			fruitGroup.Add(new VeggieModel() { Name = "Europa", IsReallyAVeggie = false, Comment = "Francia" });
			fruitGroup.Add(new VeggieModel() { Name = "Asia", IsReallyAVeggie = false, Comment = "Asia del Este" });
			fruitGroup.Add(new VeggieModel() { Name = "Africa", IsReallyAVeggie = false, Comment = "cabo Verde" });
			grouped.Add(veggieGroup); grouped.Add(fruitGroup);
			lstView.ItemsSource = grouped;
		}
	}
}