using DataAccess.Database.TRUEMONEY;
using DataAccess.Entities.Context.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.Entities.Context
{
    public partial class TrueMoneyEntities : DbContext, ITrueMoneyEntities
    {
        public TrueMoneyEntities(DbContextOptions<TrueMoneyEntities> options)
            : base(options)
        {

        }

        public virtual DbSet<S_AdminUsers> S_AdminUsers { get; set; }
        public virtual DbSet<D_Wallets> D_Wallets { get; set; }
    }
}
