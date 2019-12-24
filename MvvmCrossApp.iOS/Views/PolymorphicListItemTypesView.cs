using System;
using System.Collections.Generic;
using UIKit;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossApp.Core.Models.Dogs;
using MvvmCrossApp.Core.Models.Kittens;
using MvvmCrossApp.iOS.Views.Cells;

namespace MvvmCrossApp.iOS.Views
{
    [Register("PolymorphicListItemTypesView")]
    public class PolymorphicListItemTypesView : MvxTableViewController
    {
        public PolymorphicListItemTypesView()
        {
            Title = "Poly List";
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var source = new PolyTableSource(TableView)
            {
                UseAnimations = true,
                AddAnimation = UITableViewRowAnimation.Left,
                RemoveAnimation = UITableViewRowAnimation.Right
            };

            this.AddBindings(new Dictionary<object, string>
            {
                {source,"ItemsSource Animals" }
            });

            TableView.Source = source;
            TableView.RowHeight = 100f;
            TableView.ReloadData();
        }

        public class PolyTableSource : MvxTableViewSource
        {
            public PolyTableSource(UITableView tableView) : base(tableView)
            {
                tableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;

                tableView.RegisterClassForCellReuse(typeof(KittenTableViewCell), nameof(KittenTableViewCell));
                tableView.RegisterClassForCellReuse(typeof(DogTableViewCell), nameof(DogTableViewCell));
            }

            protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
            {
                string cellIdentifier;
                if (item is Kitten)
                {
                    cellIdentifier = nameof(KittenTableViewCell);
                }
                else if (item is Dog)
                {
                    cellIdentifier = nameof(DogTableViewCell);
                }
                else
                {
                    throw new ArgumentException($"Unknown animal of type {item.GetType().Name}");
                }

                return (UITableViewCell)TableView.DequeueReusableCell(cellIdentifier, indexPath);
            }


        }
    }
}