using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayModeTests {

    /// <summary>
    /// Tests the creation of a GameObject
    /// </summary>
    [UnityTest]
    public IEnumerator Test_GameObject_Creation() {
        var obj = new GameObject("TestObject");
        yield return null;
        Assert.IsNotNull(obj);
        Assert.AreEqual("TestObject", obj.name);
        Object.Destroy(obj);
    }

    /// <summary>
    /// Tests the position of a GameObject
    /// </summary>
    [UnityTest]
    public IEnumerator Test_GameObject_Position() {
        var obj = new GameObject("TestObject");
        var position = new Vector3(10, 0, 0);
        obj.transform.position = new Vector3(5, 0, 0);
        yield return null;
        Assert.AreEqual(position, obj.transform.position);
        Object.Destroy(obj);
    }

    /// <summary>
    /// Tests the addition of a component to a GameObject
    /// </summary>
    [UnityTest]
    public IEnumerator Test_Component_Addition() {
        var obj = new GameObject("TestObject");
        var rb = obj.AddComponent<Rigidbody>();
        yield return new WaitForFixedUpdate();
        Assert.IsNotNull(rb);
        Assert.IsTrue(obj.TryGetComponent<Rigidbody>(out _));
        Object.Destroy(obj);
    }
}
