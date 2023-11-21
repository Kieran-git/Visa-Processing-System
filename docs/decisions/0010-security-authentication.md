# 10. Authentication Decision
Date: 13/11/2023
## Context and Problem Statement

What technology I will use to implement authentication into my system (verifying who someone is)

## Considered Options

* Biometric authentication
* Two factor authentication (using an Email notification)

## Decision Outcome

I have considered two largely used methods for authentication which realistically both are implemented in modern applications. Especially with mobile applications biometric authentication through the use of fingerprint scanners on new mobile devices is very common this is especially effective as it is very difficult to breach. (Maayan, n.d.)

The main disadvantage of this is it is not a widespread solution and I would only be able to implent it into the mobile version of the site which is something I intend to only include as a responsive design and not a whole separate application.

Therefore it makes a lot more sense to implement a more universal solution such as two factor authentication which involves generating a code at the time the user logs in and then sending this via email or to another device the user owns. This prevents a lot of the most common ways account hacks occur and so I see it as the most suitable for my system. 

### Consequences

* Simple username and password based hacking attempts will be prevented.
* Also provides a method of recovering accounts in the event of forgetting passwords.
* A simple and effective method of authenticating the user to access the system.
