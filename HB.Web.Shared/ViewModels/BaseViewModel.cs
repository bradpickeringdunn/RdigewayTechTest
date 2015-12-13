using Backbone.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.Web.Shared.ViewModels
{
    public class BaseViewModel<T> where T : class
    {
        public NotificationCollection Notifications { get; set; }

        public T Payload { get; set; }

        public BaseViewModel()
        {
            this.Notifications = new NotificationCollection();
        }
    }
}
