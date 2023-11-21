# 9. Data Model decision
Date: 06/11/2023
## Context and Problem Statement

What notation and diagram I will use to represent the data within my system.

## Considered Options

* 
* 

## Decision Outcome

I originally considered a Non-Relational database such as MongoDB to store the data for the visa processing system due to the need for high performance and fast queries to and from the database.

On the other hand a Relational Database would be highly suited to this system due to how our data can be considered as consistent and non-changing (we will not change user data once submitted) only new data will be created in terms of visa applications, this means we can take advantage of ACID properties and normalise our data to make it easier to handle and maintain.

The advantages of a Non-relational database do not provide a substantial enough benefit for the increase in complexity that implementing that technology would require therefore I have decided to use an SQL database.

### Consequences

* 
*
