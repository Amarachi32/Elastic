# Elastic Collection of Object🤷‍♀️


In this Project I used ExpandoObject to  implementation  dynamic object concept that 
enables getting, setting, and invoking members.
///Sample code for a class implementing Attribute

 ExpandoObject class also enables you to add and delete members of its instances at run time 
and also to set and get values of these members.
which enables you to use standard syntax like sampleObject.sampleMember instead of more 
complex syntax like sampleObject.GetAttribute("sampleMember").

Code Sample for Dynamic collection
***
	      List<ExpandoObject> list = new List<ExpandoObject>();

            dynamic obj1 = new ExpandoObject();
            obj1.Id = 30;
            obj1.Name = "John Doe";
           

            dynamic obj2 = new ExpandoObject();
            obj2.Id = 25;
            obj2.Name = "Samsung";
***

## Software Development Summary😃👓👓
* **Technology**: C#👓
* **Framework**: .NET6
* **Project Type**: Console
* **IDE**: Visual Studio (Version 2022)
* **Paradigm or pattern of programming**: Object-Oriented Programming (OOP)
* **Data**:Elastic Collection


**NOTE**:We have used the power of **expando Object  and dynamic keyword** in C# to make our code more flexible and easier to read than using reflection.











