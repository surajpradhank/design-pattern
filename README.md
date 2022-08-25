Design patterns are typical solutions to commonly occurring problems in software design.
They are kind of blue print or template for recurring design problem in your code .

It is a general concept for solving a particular problem and can be implemented in any language.

Type of design pattern that are mainly used in software industry -

**Creational patterns** provide object creation mechanisms that increase flexibility and reuse of existing code.

**Structural patterns** explain how to assemble objects and classes into larger structures, while keeping these structures flexible and efficient.The structural design patterns simplifies the structure by identifying the relationships.
These patterns focus on, how the classes inherit from each other and how they are composed from other classes.

**Behavioral patterns** take care of effective communication and the assignment of responsibilities between objects.

**Factory**

*Factory Pattern* is a creational design pattern that provides an interface for creating objects in a parent or base class, but allows subclasses to alter the type of objects that will be created.
This is done by creating objects by calling a factory method—either specified in an interface and implemented by child classes, or implemented in a base class and optionally overridden by derived classes.

We need to choose Factory Pattern when 
1)The Object needs to be extended to subclasses
2)The Classes doesn’t know what exact sub-classes it has to create
3)The Product implementation tend to change over time and the Client remains unchanged

