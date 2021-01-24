using System;
using System.Collections.Generic;
using System.Text;

namespace HW.Domain
{
    public class EntityBase
    {
        protected Guid id;
        protected string source;
        protected DateTime data;

        public Guid Id
        {
            get
            {
                if (id == Guid.Empty)
                {
                    id = Guid.NewGuid();
                }
                return id;
            }
            set => id = Guid.NewGuid();
        }
        public string Source
        {
            get
            {
                if (string.IsNullOrEmpty(source))
                {
                    source = System.Reflection.Assembly.GetEntryAssembly()?.GetName().Name;
                }
                return source;
            }
            set => source = value;
        }

        public DateTime Data
        {
            get
            {
                if (data == DateTime.MinValue)
                {
                    data = DateTime.Now;
                }
                return data;
            }
            set => data = value;
        }
    }
}
