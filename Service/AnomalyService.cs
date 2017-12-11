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
    public class AnomalyService:Service<Anomaly>
    {
        private static DatabaseFactory df = new DatabaseFactory();
        private static UnitOfWork uf = new UnitOfWork(df);
        public  AnomalyService():base(uf)
        {
        }
    }
}
