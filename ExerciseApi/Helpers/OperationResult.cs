namespace ExerciseApi.Helpers
{
    public class OperationResult<T> where T : class?
    {
        public string Message { get; }
        public OperationStatus Status { get; }
        public T Result { get; }
        public OperationResult(OperationStatus status, string message, T result)
        {
            Message = message;
            Status = status;
            Result = result;
        }
    }
}
