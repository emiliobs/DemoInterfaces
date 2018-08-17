namespace BLL
{
    using System;
    public class ErrorEventArgs:EventArgs
    {
        public string Message { get; set; }

        public ErrorEventArgs(string message)
        {
            Message = message;
        }     
    }
}