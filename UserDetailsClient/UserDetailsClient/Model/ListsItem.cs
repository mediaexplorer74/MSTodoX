using System;
using System.Collections.Generic;
using System.Text;
//using Microsoft.Graph;
using Newtonsoft.Json.Serialization;


namespace UserDetailsClient.Model
{
    // Sample:
    // "@odata.type": "#microsoft.graph.todoTaskList",
    //"id": "AAMkADIyAAAAABrJAAA=",
    //"displayName": "Tasks",
    //"isOwner": true,
    //"isShared": false,
    //"wellknownListName": "defaultList"
    public class ListsItem
    {
        public List<ListItem> value { get; set; }
        //public string value { get; set; }
        //["@odata.type"]
        //public string @odata.type { get; set; }
        //["id"]
       


    }


    public class ListItem
    {
        public string id { get; set; }
        //["displayName"]
        public string displayName { get; set; }

        //["isOwner"]
        public bool isOwner { get; set; }

        //["isShared"]
        public bool isShared { get; set; }

        //public override string ToString() => Subject;
        public string wellknownListName { get; set; }
    }
}
