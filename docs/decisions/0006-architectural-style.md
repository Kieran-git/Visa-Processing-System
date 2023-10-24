# 6. Architectural Style Decision
Date: 24/10/2023
## Context and Problem Statement

It is necessary to choose an architectural style that fits as many functional requirements as possible for our project.

## Considered Options

* Layered
* Service Oriented
* Event Driven

## Decision Outcome

Chosen to use a Service Oriented style as this should provide an easy to maintain system via the separation of concerns. This separation means if one fails everything else should not be impacted. This also has a direct impact on availiblity as less time spent repairing the system means more up-time.

### Consequences

* We have a flexible and reliable system architecture without a single point of failure.
* We have a highly scalable system architecture as we can simply add more services as the business expands.
