﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using microwf.Execution;
using microwf.tests.WorkflowDefinitions;
using microwf.tests.Workflows;
using System.Collections.Generic;
using System.Linq;

namespace microwf.tests.Execution
{
  [TestClass]
  public class WorkflowExecutionTest
  {
    [TestMethod]
    public void GetTriggers_InitialStateIsOff_TriggerNameIsSwitchOn()
    {
      // Arrange
      Switcher switcher = new Switcher
      {
        Type = OnOffWorkflow.NAME
      };

      WorkflowExecution execution = new WorkflowExecution(new OnOffWorkflow());

      // Act
      IEnumerable<TriggerResult> result = execution.GetTriggers(switcher);

      // Assert
      Assert.IsNotNull(result);
      Assert.AreEqual(1, result.Count());
      Assert.AreEqual("SwitchOn", result.First().TriggerName);
    }

    [TestMethod]
    public void Trigger_InitialStateIsOff_StateIsOn()
    {
      // Arrange
      Switcher switcher = new Switcher
      {
        Type = OnOffWorkflow.NAME
      };
      WorkflowExecution execution = new WorkflowExecution(new OnOffWorkflow());

      // Act
      TriggerResult result = execution.Trigger(new TriggerParam("SwitchOn", switcher));

      // Assert
      Assert.IsNotNull(switcher);
      Assert.AreEqual("On", switcher.State);

      Assert.IsNotNull(result);
      Assert.AreEqual("SwitchOn", result.TriggerName);
    }
  }
}
