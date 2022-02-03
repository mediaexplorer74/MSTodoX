// RepositoryBase

using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Text;

// Todo.Core.Repository
namespace Todo.Core.Repository
{

    // RepositoryBase class
    public abstract class RepositoryBase
    {
        //
        protected IAuthenticationProvider AuthenticationProvider { get; }


        //
        public RepositoryBase(IAuthenticationProvider authenticationProvider)
        {
            AuthenticationProvider = authenticationProvider;
        }

    }//RepositoryBase class
}
