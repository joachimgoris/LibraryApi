using System;

namespace Library.Domain
{
    public class Entity
    {
        public Guid Id { get; set; } = System.Guid.NewGuid();
    }
}
