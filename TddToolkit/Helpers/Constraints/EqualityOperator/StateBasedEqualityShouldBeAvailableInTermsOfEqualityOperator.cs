﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TddEbook.TddToolkit.ImplementationDetails.ConstraintAssertions;
using FluentAssertions;

namespace TddEbook.TddToolkit.Helpers.Constraints.EqualityOperator
{
  public class StateBasedEqualityShouldBeAvailableInTermsOfEqualityOperator<T> 
    : IConstraint where T : class
  {
    public void CheckAndRecord(ConstraintsViolations violations)
    {
 	    XAssert.IsEqualityOperatorDefinedFor<T>();
    }
}
}