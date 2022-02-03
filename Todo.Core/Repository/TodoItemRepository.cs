// TodoItemRepository

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Graph;
using Todo.Core.Model;
using TaskStatus = Microsoft.Graph.TaskStatus;

// Todo.Core.Repository
namespace Todo.Core.Repository
{

    // TodoItemRepository class
    public class TodoItemRepository : RepositoryBase, ITodoItemRepository
    {
        
        // TodoItemRepository
        public TodoItemRepository(IAuthenticationProvider authenticationProvider)
            : base(authenticationProvider)
        {
            //
        }

        // AddAsync
        public async Task AddAsync(TodoItem item)
        {
            var graphServiceClient = new GraphServiceClient(AuthenticationProvider);
            await graphServiceClient.Me.Outlook.Tasks.Request().AddAsync(new OutlookTask()
            {
                Subject = item.Subject
            });
        }//AddAsync


        // ListAsync
        public async Task<IEnumerable<TodoItem>> ListAsync(bool listAll)
        {
            var graphServiceClient = new GraphServiceClient(AuthenticationProvider);
            var request = graphServiceClient.Me.Outlook.Tasks.Request();
            if(!listAll)
            {
                request.Filter($"status ne '{TaskStatus.Completed.ToString().ToLower()}'");
            }
            var tasks = await request.GetAsync();
            
            return tasks.Select(task => new TodoItem() 
            { 
                Id = task.Id,
                Subject = task.Subject,
                IsCompleted = task.Status == TaskStatus.Completed
            });

        }//ListAsync


        // CompleteAsync
        public async Task CompleteAsync(TodoItem item)
        {
            var graphServiceClient = new GraphServiceClient(AuthenticationProvider);
            var requestUrl = graphServiceClient.Me.Outlook.Tasks.AppendSegmentToRequestUrl($"{item.Id}/complete");
            var builder = new OutlookTaskCompleteRequestBuilder(requestUrl, graphServiceClient);

            await builder.Request().PostAsync();

        }//CompleteAsync


        // DeleteAsync
        public async Task DeleteAsync(TodoItem item)
        {
            var graphServiceClient = new GraphServiceClient(AuthenticationProvider);
            var requestUrl = graphServiceClient.Me.Outlook.Tasks.AppendSegmentToRequestUrl($"{item.Id}");
            var builder = new OutlookTaskRequestBuilder(requestUrl, graphServiceClient);

            await builder.Request().DeleteAsync();

        }//DeleteAsync

    }
}
