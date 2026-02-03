using System;
using System.Collections.Generic;
using System.Text;

namespace SIGCora.ApplicationService.Commons.Dtos
{
    public class PaginationParametersDto
    {
        public string SortField { get; set; } = string.Empty;

        public int PageNumber { get; set; }

        public int PageSize { get; set; }
    }
}
