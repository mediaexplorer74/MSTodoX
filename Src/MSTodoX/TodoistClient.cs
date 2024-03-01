using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MSTodoX
{
    public class TodoistClient : IDisposable
    {
        public static class Items
        {
            public static async Task<IEnumerable<Item>> GetAsync()
            {
                throw new NotImplementedException();
            }

            internal static async Task CompleteAsync(CompleteItemArgument completeItemArgument)
            {
                throw new NotImplementedException();
            }
        }
        private string authKey;

        public TodoistClient(string authKey)
        {
            this.authKey = authKey;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}