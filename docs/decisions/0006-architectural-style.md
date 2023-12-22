# 6. Architectural Style Decision
Date: 24/10/2023
## Context and Problem Statement

It is necessary to choose an architectural style that fits as many functional requirements as possible for our project.

## Considered Options

* Layered
* Service Oriented
* Event Driven

## Decision Outcome

A Service Oriented style as this would provide an easy to maintain system via the separation of code. This separation means if one fails everything else should not be impacted. However this a lot more difficult system architecture to apply and the advantages of maintenance ease can be outweighed by the complexity resulting in a longer time to fix certain aspects of code.

Likewise event driven can also be considered as a complex style as it lends itself to restful API which is a difficult concept to get right, furthermore if implemented incorrectly the time sending API requests and if the payloads sent back and forth between front end and back end are unoptimised this can result in a very slow application.

Therefore I am opting to use layered architecture but also incorporating some aspects of service oriented architecture, this means that code will be split into services but not necessarily running on different servers. Via this method I should still achieve an arhiteture that is easy to maintain but simple and secure in nature. The layered architecture should integrate well with my security by locking down access to the different layered of the application.

### Consequences

* We have a flexible and reliable system architecture that can be easily maintained.
* We have a highly scalable system architecture as we can simply add more services as the business expands.
* The layered architecture provides security by locking off aspects of the system to those unauthorised.
