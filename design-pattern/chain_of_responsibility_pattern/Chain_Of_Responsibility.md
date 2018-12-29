# Chain of Responsibility

- Sender is aware of only the first receiver in "chain of responsibility" 
- Each receiver should be only aware of the next receiver, not every one in the chain.
- Sender should not know who received the message.
- The order of sender - receiver list is important.
- separates the scope of concern. 
- Somewhat like ddd?