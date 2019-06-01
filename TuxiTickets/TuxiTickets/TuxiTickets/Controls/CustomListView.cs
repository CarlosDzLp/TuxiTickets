using System.Windows.Input;
using Xamarin.Forms;

namespace TuxiTickets.Controls
{
    public class CustomListView : ListView
    {
        public static BindableProperty SelectedItemCommandProperty = BindableProperty.Create(nameof(SelectedItemCommand), typeof(ICommand), typeof(CustomListView), null);

        public ICommand SelectedItemCommand
        {
            get
            {
                return (ICommand)this.GetValue(SelectedItemCommandProperty);
            }
            set
            {
                this.SetValue(SelectedItemCommandProperty, value);
            }
        }

        public CustomListView()
        {
            this.ItemTapped += OnItemTapped;
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                SelectedItemCommand?.Execute(e.Item);
                SelectedItem = null;
            }
        }
    }
}
