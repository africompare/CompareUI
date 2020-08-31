using System;
using System.Collections.Generic;
using System.Text;

namespace ApiHandshake
{
    public class ItemResponseObj<T>
    {
        public long ItemId { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public List<T> Items { get; set; } = new List<T>();
    }
}
