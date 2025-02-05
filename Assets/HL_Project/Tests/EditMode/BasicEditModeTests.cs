using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class BasicEditModeTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void BasicEditModeTestsSimplePasses()
    {
        int expected = 1;
        int actual = 1;
        // Use the Assert class to test conditions

        Assert.AreEqual(expected, actual);
    }
}