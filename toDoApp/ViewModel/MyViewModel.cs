using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace toDoApp
{
    class MyViewModel : ViewModel
    {
                    
        private const string LOCAL_SETT_OWNER = "Owner";

        private bool allTasks { get; set; } = false;
        public bool AllTasks { get { return allTasks; } set { allTasks = value; } }

        private string ownerId { get; set; }
        public string OwnerId {
            get { return ownerId; }
            set { ownerId = value; }
        }        

        private ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
        private static MyViewModel instance { get; set; }

        private Task currentObject { get; set; }
        public Task CurrentObject {
            get { return currentObject; }
            set { currentObject = value;
                OnPropertyChanged("CurrentObject"); }
        }

        private ObservableCollection<Task> itemsCollection;
        public ObservableCollection<Task> ItemsCollection {
            get { return itemsCollection; }
            set {
                itemsCollection = value;
                OnPropertyChanged("ItemsCollection");
            }
        }

        public static MyViewModel I() {
            if (instance == null) {
                instance = new MyViewModel();
            }
            return instance;
        }

        public MyViewModel(){}

       
        public void saveLocalSettings(String username) {
            localSettings.Values[LOCAL_SETT_OWNER] = username;
        }

        public void loadLocalSettings() {
            Object username = localSettings.Values[LOCAL_SETT_OWNER];
            if (username == null) {
                ownerId = "";
            } else {
                ownerId = username.ToString();
            }
        }

        public void removeLocalSettings() {
            localSettings.Values.Remove(LOCAL_SETT_OWNER);
            ownerId = "";
        }              

    }
}
