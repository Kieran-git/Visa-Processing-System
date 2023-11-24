# 9. Data Model decision
Date: 06/11/2023
## Context and Problem Statement

What notation and diagram I will use to represent the data within my system.

## Considered Options

* Class Diagram
* Entity Relationship Diagram

## Decision Outcome
I have two types diagram which are appropriate for representing the Data within the system. 

An Entity relationship diagram is well suited for database design showing how the tables link and their relation to one another on  a basic level, it lacks the ability to represent relationships beyond (1 to 1, 1 to many, many to many, etc) and doesn't provide any insight into the type of relationship between entities.

Alternatively a class diagram is most suited to represent data in terms of classes and objects and how these interact with one another it focuses on object orientated programming and so you can also visualise concepts such as inheritance on the diagram providing a valuable resource for viewing the overall data structure of the project. Furthermore it can then also be used to easily build a database schema from using a technology such as .NET entity framework and so I beleive this is the best suited for this system.

### Consequences

* An easy to read diagram with details outlining the type of relations between classes.
* Simple to convert into a database schema for the actual prototype saving time in the long run.
