// C# is an Object Oriented Programming language (OOP), based on C
// C# has specific syntax (rules) you need to follow
    // Case sensitive
    // ; acts as the end of a line

// Library is a bundle of prewritten code
//keyword "using" tells our script to look for code in that library.

using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

//a class is a container for variales and mothods
//classes can inherit from each other (*Polymorphism*)
// : to indidcate inheritance

public class MyScript : MonoBehaviour
{


    // variable is something thats stores data which we can comapre, change, copy
    // we must declare a variable beore we use it
    //public/private - whether or not a script can access a variable
    //data type - what kind of data the variable hold
    //name - how we call it in code

    [SerializeField] private int myHealthMax = 100;  //integer - whole number
    public Text textHealthMax;
    public float myFloat;
    public float myAddingFloat;
    //float
    //boolean
    //string

    //Runs once when the object spawns
    private void Start()
    {
        //we are changing/setting left to equal right
        //myHealthMax = myHealthMax + 1;
        //myHealthMax = myHealthMax(10) + 1
        //myHealthMax += 1;
        //myHealthMax++;
        AddOne();
        UpdateMaxHealthText();


    }

    //Methods let you manipulate and compare variables
    //you call methods inside other

    public void AddOne()
    {
        myHealthMax++;

    }

    public void Update()
    {
        UpdateMaxHealthText();

        //if (true)
        //DoSomething();
        //else
        //DoSomethingElse();

        if (Input.GetKeyDown(KeyCode.Space))
            IncreaseMyFloat(myAddingFloat);




        if (false) //we get hit
            TakeDamage(5);


        //KeyCode - an enum - a list of words assigned to numbers

    }
    
    public void UpdateMaxHealthText()
    {
        textHealthMax.text = myHealthMax.ToString();
    }

    public void IncreaseMyFloat(float number)
    {
        myFloat += number;
    }
    public void TakeDamage(int damage)
    {
        myHealthMax -= damage;
        //if the player is dead
        // do something
        //Particle effect
        //sound effect
    }

    
  

}
