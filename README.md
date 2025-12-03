# Advent of Code 2025

Library of Advent of Code 2025 solutions with NUnit tests; run tests to compute and verify the answers.
Based on the reusable template at [borgoo/advent-of-code-template](https://github.com/borgoo/advent-of-code-template).

## Layout

```
AdventOfCode/
├── AdventOfCode.slnx
├── docs/                      # One markdown file per day
├── src/AdventOfCode.Core/     # Solution code (DayN.Part1/Part2)
└── tests/AdventOfCode.NUnit.Tests/  # NUnit tests and sample input files
```

## template.bat

`template.bat <day>` scaffolds a new day under `docs`, `src/AdventOfCode.Core`, and `tests/AdventOfCode.NUnit.Tests` (and `template.bat <day> -rf` resets that day).
