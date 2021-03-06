using MaintenanceDashboard.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MaintenanceDashboard.Data.Api
{
    public sealed class RegisterToolContext : IDisposable, IRegisterToolContext
    {
        private readonly DataContext context;

        private bool disposed;

        public RegisterToolContext()
        {
            context = new DataContext();
        }

        public DataContext DataContext
        {
            get { return context; }
        }


        public void CreateRegisterTool(RegisterTool registerTool)
        {
            CheckValue.RequireString(registerTool.ToolName);

            context.RegisterTools.Add(registerTool);
            context.SaveChanges();
        }


        public void UpdateRegisterTool(RegisterTool registerTool)
        {
            var entity = context.RegisterTools.Find(registerTool.Id);

            if (entity == null)
            {
                throw new NotImplementedException("Handle appropriately for your API design. ");
            }

            context.Entry(entity).CurrentValues.SetValues(registerTool);

            context.SaveChanges();
        }

        public void DeleteRegisterTool(RegisterTool registerTool)
        {
            context.RegisterTools.Remove(registerTool);
            context.SaveChanges();
        }

        public ICollection<RegisterTool> GetRegisterToolList()
        {
            return context.RegisterTools.OrderBy(p => p.Id).ToArray();
        }


        #region IDisposable Members
        public void Dispose()
        {
            //Free all object here            
            Dispose(true);

            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SupressFinalize to
            // take this object off the finalization queue
            // and prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            //Check to see if Dispose has already been called.
            if (disposed || !disposing)
                return;

            if (context != null)
                context.Dispose(); //Free any unmenaged object here

            disposed = true; // Note disposing has been done.
        }

        #endregion
    }
}
