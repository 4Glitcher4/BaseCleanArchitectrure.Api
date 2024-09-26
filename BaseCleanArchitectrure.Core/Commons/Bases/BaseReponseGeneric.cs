namespace BaseCleanArchitectrure.Core.Commons.Bases
{
    public class BaseReponseGeneric<T>
    {
        public bool IsSuccess {  get; set; }
        public T? Data { get; set; }
        public string? Message { get; set; }
        public IEnumerable<BaseError> Errors { get; set; }
    }
}
