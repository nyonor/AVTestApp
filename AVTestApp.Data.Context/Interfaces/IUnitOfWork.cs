using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTestApp.Data.Model.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Commit changes
        /// </summary>
        void Commit();

        /// <summary>
        /// Reject not commited changes
        /// </summary>
        void Reject();
    }
}
