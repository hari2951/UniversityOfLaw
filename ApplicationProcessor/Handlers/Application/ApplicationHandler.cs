using Ulaw.ApplicationProcessor.Entities.Application;

namespace Ulaw.ApplicationProcessor.Handler.Application
{
    public abstract class ApplicationHandler //Can use interface in C#8+
    {
        protected ApplicationHandler successor;

        public void SetSuccessor(ApplicationHandler successor)
        {
            this.successor = successor;
        }

        public virtual string HandleRequest(IApplication application)
        {
            if (successor != null)
            {
                return successor.HandleRequest(application);
            }

            return string.Empty;
        }
    }
}