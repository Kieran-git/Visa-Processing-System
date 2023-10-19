# Using markdown to document the architecture decision records
Date: 01/10/2023
## Context and Problem Statement

The way architecture decision records are stored and then read by anyone viewing the documentation for the system needs to be consistent and clear.

## Considered Options

* Using a text processing software such as Microsoft Word/Google Docs
* Using a markdown format in plain text

## Decision Outcome

Chosen to use a markdown format, because although it can still be formatted well with Word or Google Docs this is not as accessible as markdown which can be read using any software and so users should not have any issue viewing this documentation.

### Consequences

* We have a more accessible document and we do not compromise on the readability and structure of the ADR.
* The ADR template can be very easily duplicated as it is simply markdown text and so will work anywhere it is used.
