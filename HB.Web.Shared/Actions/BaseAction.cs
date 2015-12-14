using Backbone.Logging;
using Backbone.Utilities;
using HB.Web.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.Web.Shared.Actions
{
    public abstract class BaseAction<T> where T : class
    {
        public ILogger Logger { get; set; }
        
        public BaseAction(ILogger logger)
        {
            Guardian.ArgumentNotNull(logger, "logger");
            this.Logger = logger;
        }
    }
}
