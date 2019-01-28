using System.Collections.Generic;

namespace CarRent.Services
{
    public class ServiceResult
    {
        public ServiceResultStatus ResultStatus { get; set; }

        public ICollection<string> Messages { get; set; }

        public ServiceResult()
        {
            ResultStatus = ServiceResultStatus.Success;
            Messages = new List<string>();
        }
    }
}