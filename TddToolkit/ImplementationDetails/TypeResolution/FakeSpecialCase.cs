using System.Reflection;

namespace TddEbook.TddToolkit.ImplementationDetails.TypeResolution
{
  internal class FakeSpecialCase<T> : IResolution<T>
  {
    public bool Applies()
    {
      return 
        TypeOfType.Is<T>() || 
        typeof(T) == typeof(MethodInfo);
    }

    public T Apply()
    {
      return Any.ValueOf<T>();
    }
  }
}