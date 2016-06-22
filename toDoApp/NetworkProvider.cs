using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace toDoApp

{
    class NetworkProvider
    {

        private const string API_URL = "http://windowsphoneuam.azurewebsites.net/";
        private const string REST_PATH = "api/todotasks/";
        private const string OWNER_SEARCH_PATH = "?OwnerId=";

        public object DataContext { get; private set; }

        // obsługa API 

        //GET
        public async void getTasks(MyViewModel DataContext)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync(API_URL + "/" + REST_PATH);
                var items = await result.Content.ReadAsStringAsync();
                DataContext.ItemsCollection = JsonConvert.DeserializeObject<ObservableCollection<Task>>(items);
            }
        }
        //GET po ownerId
        public async void getOwnerTasks(MyViewModel DataContext)
        {
            using (HttpClient client = new HttpClient()){
                var result = await client.GetAsync(API_URL + "/" + REST_PATH + OWNER_SEARCH_PATH + DataContext.OwnerId);
                var items = await result.Content.ReadAsStringAsync();
                DataContext.ItemsCollection = JsonConvert.DeserializeObject<ObservableCollection<Task>>(items);
                DataContext.AllTasks = true;
               }
        }

        //POST
        public async void postTask(Task myTask)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(API_URL);
                client.DefaultRequestHeaders
                    .Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, REST_PATH);
                request.Content = new StringContent(myTask.SerializeTask(), Encoding.UTF8, "application/json");
                await client.SendAsync(request);
            }
        }

        //PUT
        public async void updateTask(Task myTask)
        {
            myTask.createdAt = DateTime.Now.ToString("dd'-'MM'-'yyyy HH:mm:ss");
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(API_URL);
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, REST_PATH + myTask.id);
                request.Content = new StringContent(myTask.SerializeTask(), Encoding.UTF8, "application/json");
                await client.SendAsync(request);
            }
        }

        //DELETE task by id
        public async void deleteTask(Task myTask)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(API_URL);
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, REST_PATH + myTask.id);
                await client.SendAsync(request);
            }
        }
    }
}