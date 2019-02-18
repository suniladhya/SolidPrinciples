using System;
using System.IO;

namespace SolidPrinciples
{
    public class ErrorHandler
    {
        public void HandleError(Exception ex)
        {
            File.WriteAllText("path", ex.Message);
        }
    }
}