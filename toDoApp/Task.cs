using Newtonsoft.Json;
using System;


namespace toDoApp
{
    class Task
    {
        public string id { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string ownerId { get; set; }
        public string createdAt { get; set; }

        public Task(string title, string text, string id)
        {
            this.title = title;
            this.text = text;
            this.ownerId = MyViewModel.I().OwnerId;
            if (id == "")
                this.id = "0";
            else
                this.id = id;
            this.createdAt = DateTime.Now.ToString();
        }

        public string SerializeTask()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
