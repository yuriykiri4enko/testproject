using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestSkill.Core.API.Models
{
    public class BaseEntity
    {

        [AutoIncrement]
        [JsonIgnore][PrimaryKey]
        public Guid? LocalId { get; set; }


    }
}
