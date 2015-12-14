using Backbone.Logging;
using Backbone.Repository;
using Backbone.Services.Results;
using Backbone.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.Services
{
    public class ServiceBase : IDisposable
    {
        public ILogger Logger { get; set; }

        public IRepository Repository;

        public ServiceBase(ILogger logger, IRepository repository)
        {
            Guardian.ArgumentNotNull(logger, "logger");
            Guardian.ArgumentNotNull(repository, "repository");

            this.Logger = logger;
            this.Repository = repository;
        }

        public T Execute<T>(Action<T> action) where T : GenericServiceResult, new()
        {
            var result = new T();

            try
            {
                action(result);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);

            }

            return result;
        }

        public void Dispose()
        {
        }
    }
}
