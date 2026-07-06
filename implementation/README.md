# Section 3b: Coding

**Time limit: 25 minutes**

## Task

Pick the **highest-value slice** of the @mentions PRD you can implement or sketch in 25 minutes. Completeness is not the goal.

Read [PRD.md](../PRD.md) for requirements and platform constraints.

## Example slices

These are examples, not requirements. Choose what you think best demonstrates your approach, or pick your own direction:

| Slice | Example deliverable |
|-------|-------------------|
| **API layer** | Supabase RPC, Edge Function, or service handler sketch for creating a comment with @mentions |
| **Database schema** | Postgres migration for `comment` and `comment_mention` tables with RLS outline |
| **Permission filter** | Pseudocode or RLS policy showing how mention visibility is enforced |
| **Deep-link contract** | URL scheme spec + routing logic for jobs and documents |
| **Async notification** | SQS event payload schema + Lambda consumer sketch |
| **Mention parser** | Function that extracts `@displayName` / `@email` from comment text |

## Deliverables

Commit your work to this folder. There is no required format. These are examples of valid formats:

- TypeScript / JavaScript (runnable or annotated stubs)
- SQL migrations (`.sql`) with RLS policies
- Pseudocode with comments explaining intent
- Sequence diagrams or Architectural Decision Records specific to your implementation choices

**Runnable code is optional.** A clear, well-structured schema or pseudocode that you can walk through is a strong deliverable.

## Tooling

AI tools (Cursor, Copilot, ChatGPT, etc.) are **explicitly allowed**.