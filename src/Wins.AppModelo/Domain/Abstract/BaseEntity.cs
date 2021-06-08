using System;

namespace Wins.AppModelo.Domain.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public Guid TenantId { get; set; }
    }
}
