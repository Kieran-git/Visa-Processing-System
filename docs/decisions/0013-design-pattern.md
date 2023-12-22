# 13. Code Design Pattern Decision
Date: 27/11/2023
## Context and Problem Statement

What code design pattern to implement into the system in order to make sure the system is scalable and can handle feature implementations in the future as the system grows.

## Considered Options

* Behavioural pattern
   - Observer
* Creational pattern
  - Factory

## Decision Outcome

The main benefits of the behavioural pattern observer is that I can notify several other components of when the visa application reaches several stages as the object itself will go on a journey from creation to review to submission to the authorities and it is necessary to notify. However I don't feel this design pattern is necessary neither applicable in the case of my system as it will add unnecessary complexity in subscribing all of my objects to the events and when to trigger them.

On the other hand I do beleive the creational pattern factory is applicable to my system especially when I intend to implement Visa as an umbrella class which is implemented by the types of Visa (work, business, etc) allowing them to have differing functions but still inherit the main functions a visa should have from their superclass. The only disadvantage I see with this pattern is the potenital for a huge amount of subclasses as the system grows in size and more visa types are introduced.

### Consequences

* Adhering to the single responsibility principle and I can introduce new visa types with ease using the factory pattern. (Refactoring Guru. (n.d.))
* Compliments the idea of an architecture that is ready for scaling the system up to more countries as intended to do with the system.

### References

Refactoring Guru. (n.d.). Refactoring and Design Patterns. Retrieved December 22, 2023, from https://refactoring.guru/
