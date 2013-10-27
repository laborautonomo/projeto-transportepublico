﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace nanoit.sptrans.hackatona.core.domain.entity
{
    [DataContract]
    public class LogSearch
    {
        public LogSearch()
        {
            Application = new Application();
            Device      = new Device();
        }
        
        [DataMember]
        public virtual int Id                           { get; set; }
        [DataMember]
        public virtual Application Application { get; set; }
        [DataMember]
        public virtual Device Device { get; set; }
        [DataMember]
        public virtual string Text { get; set; }
        [DataMember]
        public virtual DateTime DateTimeOfCreation { get; set; }
    }
}
