using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class TestingScript : MonoBehaviour
{

    public delegate void TestDelegate();
    public delegate bool TestBooleanDelegate(int a);
    private TestDelegate testDelegateFunction;
    private TestBooleanDelegate testBooleanDelegateFunction;
    private Action testAction;
    private Action<int,int> testParameterizedAction;
    private Func<int> FuncTestCase;
    // Start is called before the first frame update
    void Start()
    {
        int a = 1;
        testDelegateFunction = delegate () { Debug.Log("anonymous vote"); };
        testDelegateFunction += ()=> { Debug.Log("Lambda expression!"); };
        testDelegateFunction();

        //testDelegateFunction -= SyntheticTestingFunction;
        //testDelegateFunction();

        testParameterizedAction = (int i, int f) => { Debug.Log("Utilizing overloaded action"); };
        testParameterizedAction(a,a);

        FuncTestCase = () => { return 5; };
        Debug.Log(FuncTestCase());

    }

    private void ActualTestingFunction()
    {
        Debug.Log("This is a random testing placeholder");
    }

    private void SyntheticTestingFunction()
    {
        Debug.Log("This is a prosthetic!");
    }

    private bool AcutalBooleanFunction(int i)
    {
        return (i == 1);
    }
   
}
