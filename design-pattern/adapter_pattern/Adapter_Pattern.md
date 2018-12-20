# Design Patterns are...
> General solutions to common problems we see in software design 

## Introduction to Design Patterns
#### Patterns deal with...
- Abstractions on top of code
- Problems that have existed before & has been already solved
- Relationships between classes or other "collaborators"

#### Patterns are not concerned with...
- Specific implementation, classes
- Algorithms

#### keyword
- Architectural **patterns** that can be recognized & be reused! 

#### Pattern organization
- Different scenarios, and formal design patterns you can apply to
- Patterns for OOP, patterns for FP, patterns for parallel programming, etc..

#### Why patterns matter
- Gives shared **vocab** for our profession. 
    - Provide a starting point for a solution.
    - can speed production in a team
    - "safeguard" for system quality and application design

#### Criticisms
- not a "go-to" solution for all problems in software design!
- Unncessary duplication
- some patterns have become anti-patterns
- **"patterns are workarounds for missing language features"**


## Adapter Pattern
- a client class that would be useful for your application which does not implement an interface. 
    - Client and component have un-matching "interface" but client nonetheless needs component's functionality.
    - Adapters in the Real world : Power outlet & plug have different voltage. <- get a travel adapter!

- Use adapter pattern when :
  - you want to use an existing class, but the interface doesn't match one
  - you create a reusable class that cooperates with unforeseen classes

- Client -> Adapter interface -> Adapter interface implementation -> Adaptee 
- Future-proofing client 

- Clients call operations on adapter interface -> adapter interface calls method on adaptee class

- a single adapter interface may work with many adaptees
- can be difficult to override Adaptee behavior ( with Object Adapter) --> where multiple inheritance is disable

### Adapter Pattern Implementaion Example
- ADO.NET IDataAdapter
    - DataAdapter
      - DbDataAdapter
      - OdbcDataAdapter
      - OleDbDataAdapter
      - SqlDataAdapter  