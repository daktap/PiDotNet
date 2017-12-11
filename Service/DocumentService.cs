using Data.Infrastructure;
using Data.Models;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DocumentService : Service<document>
    {
        private static DatabaseFactory df = new DatabaseFactory();
        private static UnitOfWork uf = new UnitOfWork(df);
        public DocumentService() : base(uf)
        {
        }
    }
}