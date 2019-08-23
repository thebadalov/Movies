using Movie.Contract.Services;
using System;
using System.Collections.Generic;
using System.Text;
	

namespace Movie.Data.Services
{
    public class SeriesService : ISeriesService
    {
        public bool CreateSeries()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SeriesModel> GetSeries()
        {
           return System.Linq.Enumerable.Empty<SeriesModel>();
        }

    }
}
