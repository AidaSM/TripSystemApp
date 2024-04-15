using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripSystemApp.Interfaces;

namespace TripSystemApp.Helpers
{
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        protected void NotifyAll(object sender, EventArgs e)
        {
            foreach (var observer in observers)
            {
                observer.OnDataChanged(sender, e);
            }
            ShowNotification("The database was updated!");
        }
        protected void ShowNotification(string message)
        {
            MessageBox.Show(message, "Change made", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
