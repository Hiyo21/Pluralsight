# Command Pattern 

- Very widely used pattern!

## Intent
- Represent action as an object
- Decouple clients that execute the command from the details and dependencies of the command logic
- Enables delayed execution
  - Can queue commands for later execution
  - If command objects are also persistent, can delay across process restarts

## Also Known As
    - Action, transaction

## Appicable to
    - Logging
    - Validation
    - Undo
    - Web Application

## Consequences
    - Commands must be completely self contained
      - The client must not pass in any arguments
    - Easy to add new commands (open/closed principal)


