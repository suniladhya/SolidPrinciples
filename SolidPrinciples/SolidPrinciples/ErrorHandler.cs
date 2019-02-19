using System;
using System.IO;

namespace SolidPrinciples
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
    public class ErrorHandler : IErrorHandler
    {
        public void HandleError(Exception ex)
        {
            File.WriteAllText("path", ex.Message);
        }
    }

    public class EventViewer : IErrorHandler
    {
        public void HandleError(Exception ex)
        {
          //Handle error in event viewer
        }
    }
}