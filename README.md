# Ribbiot Backend Technical Interview

Welcome! This repository contains Ribbiot’s backend technical evaluation.

In this exercise, you’ll architect and partially implement a hypothetical feature for the Ribbiot platform. The exercise is intentionally open ended and leaves room for interpretation. Its purpose is to help us understand how you approach feature development, solution design, and technical decision-making.

The timebox is intentionally tight. We do not expect you to complete the entire exercise or produce a polished, production-ready solution. Instead, focus on demonstrating as much of your technical and problem-solving ability as possible within the time available.

As you work, talk us through your reasoning, explain the tradeoffs you’re making, and communicate your decisions. We care more about how you think, prioritize, and approach problems than about shipping a perfect implementation.

## Agenda

The session is **65 minutes** total:

| Block | Time | Notes |
|-------|------|-------|
| Introduction | 5 min | Meet your interviewer, overview of the session |
| Read documentation | 10 min | Review this repo and [PRD.md](./PRD.md) |
| **3a: Architecture** | 25 min | Deliverables in [`architecture/`](./architecture/) |
| **3b: Coding** | 25 min | Deliverables in [`implementation/`](./implementation/) |

Both exercises are driven by **[PRD.md](./PRD.md)**. It includes the feature requirements and the platform constraints you should treat as given.

## Project Setup

1. **Clone this repository** and push it to a new repo on your personal GitHub account (see below).
2. Optionally skim the repo beforehand. You will have 10 minutes at the start of the session to read the documentation. No pre-work or pre-design is required.

### Set up your personal repo

```bash
git clone git@github.com:ribbiot/ribbiot-be-interview.git
cd ribbiot-be-interview
git remote rename origin ribbiot
gh repo create <your-username>/ribbiot-be-interview \
  --private \
  --source=. \
  --remote=origin \
  --push
```

Your interviewer will guide you through both sections. Work in your local clone and push to your personal GitHub repo as you go.

### Architecture (25 minutes)

Design the end-to-end @mentions system described in the PRD. See [architecture/README.md](./architecture/README.md) for details. There is no required format; use whatever best demonstrates your approach.

**Commit your artifacts to [`architecture/`](./architecture/).**

You will discuss your design live with the interviewer. This is not a rehearsed presentation.

### Coding (25 minutes)

Pick the **highest-value slice** of the PRD you can implement or sketch in 25 minutes. See [implementation/README.md](./implementation/README.md) for examples. Choose what best demonstrates your approach, or pick your own direction.

**Commit your work to [`implementation/`](./implementation/).**

**AI tools are explicitly allowed.**

Runnable code is optional. Well-annotated SQL migrations, Supabase RLS policies, pseudocode, sequence diagrams, or Architectural Decision Records are all valid deliverables.

## Submission

When both sections are complete:

1. Push all commits to your personal GitHub repo.
2. Send your interviewer the URL to your repo (e.g. `https://github.com/<your-username>/ribbiot-be-interview`).

### Commit your work

```bash
git checkout -b interview/<your-name>-<YYYY-MM-DD>

# After completing both sections:
git add architecture/ implementation/
git commit -m "Interview submission: @mentions architecture + implementation"
git push -u origin interview/<your-name>-<YYYY-MM-DD>
```

You can merge to `main` on your repo or leave the work on the branch. Just make sure your interviewer can find the latest commits.

## Repository structure

```
ribbiot-be-interview/
├── README.md              ← You are here
├── PRD.md                 ← Product requirements and platform constraints
├── assets/                ← UI screenshots for product context
├── architecture/          ← Your 3a deliverables (design doc, diagrams, ADRs)
└── implementation/        ← Your 3b deliverables (code, schemas, sketches)
```

## Questions?

Ask your interviewer during the session. Clarifying requirements is part of the exercise.
