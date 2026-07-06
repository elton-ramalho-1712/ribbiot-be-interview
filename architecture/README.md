# Section 3a: Architecture

**Time limit: 25 minutes**

## Task

Design the end-to-end @mentions system described in [PRD.md](../PRD.md).

These are examples, not requirements. Choose what you think best demonstrates your approach, or pick your own direction:

- Data model (where comments and mentions live)
- Service boundaries (which services own what)
- Permission checks (how you enforce visibility)
- Deep links (how notifications route to jobs and documents)
- Async notification path (SQS, email, push; design only)

Use the **Given environment** section in [PRD.md](../PRD.md) as your reference. Treat those constraints as fixed.

## Deliverables

Commit your architecture work to this folder. There is no required format or fixed artifact list. Use whatever helps you explain your design clearly.

These are examples, not requirements. Choose what you think best demonstrates your approach, or pick your own direction:

1. **Engineering design doc** (`DESIGN.md`): a short written doc covering your architecture decisions and key tradeoffs. Keep it concise; bullet points are fine.
2. **System context diagram**: clients, backend services, Supabase (Postgres + real-time), async pipeline
3. **One deep-dive diagram**: your choice (sequence diagram for mention creation, entity relationship diagram, component diagram, etc.)
4. **Architectural Decision Record** (`ADR-001-<topic>.md`): a short write-up of a key design decision and the alternatives you considered
5. **Work breakdown**: how you would ship this incrementally

## Tooling

- Use any tools you like — AI assistants, Excalidraw, Miro, Lucidchart, draw.io, etc. If your tool supports export, include both the **source file** (e.g., `.excalidraw`) and a **PNG or SVG** for easy review.