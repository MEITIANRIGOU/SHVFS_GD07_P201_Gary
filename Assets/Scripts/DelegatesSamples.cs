using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HackMan;

public class DelegatesSamples : MonoBehaviour
{
    public delegate void MyDelegate();

    public void OnEnable()
    {
        MyDelegate myDelegate = new MyDelegate(Foo);
        //myDelegate();
        MyDelegate myDelegate1 = Goo;
        //myDelegate1();
        MyDelegate myDelegate2 = Foo;
        MyDelegate myDelegate3 = Goo;
        //myDelegate2();
        myDelegate = myDelegate1;
        myDelegate += myDelegate2;
        myDelegate += myDelegate3;
        myDelegate();
        myDelegate -= new MyDelegate(Goo);
        myDelegate();
    }

    public void Foo()
    {
        Debug.Log("Foo");
    }
    public void Goo()
    {
        Debug.Log("Goo");
    }
}