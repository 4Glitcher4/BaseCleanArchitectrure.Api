﻿namespace BaseCleanArchitectrure.Core.Commons.Bases
{
    public class BaseReponsePagination<T> : BaseReponseGeneric<T>
    {
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
        public bool HasPreviousPage => PageNumber > 1;
        public bool HasNextPage => PageNumber < TotalPages;
    }
}
