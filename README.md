# CSharp.13.Encapsulation

determina cuanto acceso y cuanta restriccion tendra mi clase
ATTRIBUTE:  describe the status of the object
            information of an object
            1 object is diferent of other because of their attributes
            has two parts: Identifier and value
            
```csharp
private string _firstName;
private string _lastName;
```

PROPERTY:   give set and get methods to a private field: both of them can have business logic
            see timePeriod example
            
Expression Body definitions: single line statement, ver Person.cs
```csharp
public string GetName () => $"{_firstName} {_lastName}";
```

autoimplemented properties: 
```csharp
public type NameProperty { get; set; }
```

Access Modifiers: 

public: all objects can access, inherited, non inherited, outside of the assembly
private: only the object have access
internal: only the objects of the assembly can use
protected: same object and inherited objects
sealed: cant have childs
