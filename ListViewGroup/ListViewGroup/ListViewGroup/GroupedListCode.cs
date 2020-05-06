using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Text;

namespace ListViewGroup
{
		public class GroupedListCode : ContentPage
		{
			private ObservableCollection<GroupedVeggieModel> grouped { get; set; }

			public GroupedListCode()
			{
				var lstView = new ListView();
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

			grouped.Add(veggieGroup);
				grouped.Add(fruitGroup);

				lstView.ItemsSource = grouped;
				lstView.IsGroupingEnabled = true;
				lstView.GroupDisplayBinding = new Binding("LongName");
				lstView.GroupShortNameBinding = new Binding("ShortName");

				lstView.ItemTemplate = new DataTemplate(typeof(TextCell));
				lstView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
				//			lstView.ItemTemplate.SetBinding (TextCell.DetailProperty, "Comment");
				Content = lstView;
			}
		}
}
