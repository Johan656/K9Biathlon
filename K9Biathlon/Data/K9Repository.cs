using K9Biathlon.Data.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9Biathlon.Data
{
    public class K9Repository : IK9Repository
    {
        private readonly K9Context _ctx;
        private readonly ILogger<K9Repository> _logger;

        public K9Repository(K9Context ctx, ILogger<K9Repository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public IEnumerable<Anmalan> getAllAnmalningar()
        {
            try
            {
                _logger.LogInformation("getAllAnmalningar was called");

                return _ctx.Anmalningar
                        .OrderBy(a => a.AnmalningsDatum)
                        .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Faild to get anmalningar: {ex}");
                return null;
            }

        }

        public IEnumerable<Tavling> getAllTavlingar()
        {
            return _ctx.Tavlingar.ToList();
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
    }
}
