using System.Collections.Generic;
using K9Biathlon.Data.Entities;

namespace K9Biathlon.Data
{
    public interface IK9Repository
    {
        IEnumerable<Anmalan> getAllAnmalningar();
        IEnumerable<Tavling> getAllTavlingar();
        bool SaveAll();
    }
}