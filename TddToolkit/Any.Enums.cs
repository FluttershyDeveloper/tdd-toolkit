﻿using System;
using Ploeh.AutoFixture;

namespace TddEbook.TddToolkit
{
  public static partial class Any
  {
    public static T Of<T>() where T : struct, IConvertible
    {
      AssertDynamicEnumConstraintFor<T>();

      return Generator.Create<T>();
    }

    public static T Besides<T>(params T[] excludedValues) where T : struct, IConvertible
    {
      AssertDynamicEnumConstraintFor<T>();
      return ValueOtherThan(excludedValues);
    }
  }
}
