using System.Collections.Generic;
using System.Linq;
using TddEbook.TypeReflection.Interfaces;

namespace TddEbook.TypeReflection.ImplementationDetails.ConstructorRetrievals
{
  public class InternalConstructorWithoutRecursionRetrieval : ConstructorRetrieval
  {
    private readonly ConstructorRetrieval _next;

    public InternalConstructorWithoutRecursionRetrieval(ConstructorRetrieval next)
    {
      _next = next;
    }

    public IEnumerable<IConstructorWrapper> RetrieveFrom(IConstructorQueries constructors)
    {
      var internalConstructors = constructors.TryToObtainInternalConstructorsWithoutRecursiveArguments();

      if (internalConstructors.Any())
      {
        return internalConstructors;
      }
      else
      {
        return _next.RetrieveFrom(constructors);
      }
    }
  }
}