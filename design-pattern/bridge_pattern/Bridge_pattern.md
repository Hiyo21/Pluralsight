# Bridge Pattern

- GOF --> "decouple an abstraction from its implementation"
- "Usually", "by default" abstraction is coupled to implementation. 
- put another layer of abstraction in between abstraction and implementation.
- Kinda similar to ScanResultStatusEvalEngine!

## Common Usages 
- User Interface
  - Shape
  - Drawing API
- Persistence
  - Object to Persist
  - Persistence Type
- .NET Provider Model

## How is this different from Adapter pattern? 
- Adapter is retrofitted (make things work after they're designed) / Bridge is designed up-front.
- Adapter is more of "make unrelated classes work together" and Bridge is "decoupling abstraction from implementation from design phase" so that it can better be prepared for additional patterns that may happen. 

