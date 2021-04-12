using System;
using System.Collections.Generic;
using System.Text;

namespace AR.DTO.Results
{
    public class ResultErrorDTO : ResultDTO
    {
        public List<string> Errors { get; set; }
    }
}
