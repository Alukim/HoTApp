using Newtonsoft.Json;
using susziMobilne;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using susziMobilne.Model;
using System.Net.Http.Headers;

namespace susziMobilne
{
   
    public class RestService:IRestService
    {
        HttpClient client;
        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<Schedule> GetSchedule(int UserID)
        {
            Schedule schedule = new Schedule();
            var uri = new Uri(Constants.StudentController);
            client.BaseAddress = uri;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, "schedule");
                string json = JsonConvert.SerializeObject(new { userid=UserID });
                StringContent cont = new StringContent(json,
                    Encoding.UTF8, "application/json");
                message.Content = cont;
                var response = await client.SendAsync(message);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    schedule = JsonConvert.DeserializeObject<Schedule>(content);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }

            return schedule;
        }

        public async Task<ScheduleLine> GetScheduleLine(int ScheduleLine)
        {
            ScheduleLine line = new ScheduleLine();
            var uri = new Uri(Constants.StudentController);
            client.BaseAddress = uri;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, "scheduleline");
                string json = JsonConvert.SerializeObject(new { scheduleline= ScheduleLine});
                StringContent cont = new StringContent(json,
                    Encoding.UTF8, "application/json");
                message.Content = cont;
                var response = await client.SendAsync(message);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    line = JsonConvert.DeserializeObject<ScheduleLine>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return line;
        }

        public async Task<Student> GetStudent (int studentid)
        {
            Student student = new Student();
            var uri=new Uri(Constants.StudentController);
            client.BaseAddress = uri;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, "scheduleline");
                string json = JsonConvert.SerializeObject(new { id = studentid });
                StringContent cont = new StringContent(json,
                    Encoding.UTF8, "application/json");
                message.Content = cont;
                var response = await client.SendAsync(message);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    student = JsonConvert.DeserializeObject<Student>(content);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return student;
        }

        public async Task<Subject> GetSubject(int subjectid)
        {
            Subject student = new Subject();
            var uri = new Uri(Constants.StudentController);
            client.BaseAddress = uri;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, "scheduleline");
                string json = JsonConvert.SerializeObject(new { id = subjectid });
                StringContent cont = new StringContent(json,
                    Encoding.UTF8, "application/json");
                message.Content = cont;
                var response = await client.SendAsync(message);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    student = JsonConvert.DeserializeObject<Subject>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return student;
        }

        public class Test
        {
            Guid id { get; set; }
        }
        public async Task<User> GetUser(string login, string password)
        {
            string login1 = login;
            string password1 = password;
            User user = new User();
            var uri = new Uri(string.Format(Constants.StudentController));
            client.BaseAddress = uri;
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, "login");
                string json = JsonConvert.SerializeObject(new { login = login1, password = password1 });
                StringContent cont= new StringContent(json,
                    Encoding.UTF8, "application/json");
                message.Content = cont;
                var response =await client.SendAsync(message);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    user= JsonConvert.DeserializeObject<User>(content);

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }

            return user;
        }

        public async Task<Group> GetGroup (string groupdid)
        {
            Group group = new Group();
            var uri = new Uri(Constants.StudentController);
            client.BaseAddress = uri;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, "scheduleline");
                string json = JsonConvert.SerializeObject(new { id = groupdid });
                StringContent cont = new StringContent(json,
                    Encoding.UTF8, "application/json");
                message.Content = cont;
                var response = await client.SendAsync(message);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    group = JsonConvert.DeserializeObject<Group>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return group;
        }

        public async Task<Teacher> GetTeacher(int teacherid)
        {
            Teacher teacher = new Teacher();
            var uri = new Uri(Constants.StudentController);
            client.BaseAddress = uri;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, "scheduleline");
                string json = JsonConvert.SerializeObject(new { id = teacherid });
                StringContent cont = new StringContent(json,
                    Encoding.UTF8, "application/json");
                message.Content = cont;
                var response = await client.SendAsync(message);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    teacher = JsonConvert.DeserializeObject<Teacher>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return teacher;
        }
    }
}
