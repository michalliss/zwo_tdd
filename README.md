# TDD Money Demo (based on the example from the book)

## Problem description

A company WyCash needed to extend their services to support multiple currencies.
So far they've been using a class called `Dollar` only.

Before they produced the following type of reports:

| Instrument | Shares | Price | Total |
|------------|--------|-------|-------|
| IBM        | 1000   | 25    | 25000 |
| GE         | 400    | 100   | 40000 |
|            |        | Total | 65000 |

Now they need to produce reports such as this one:

| Instrument | Shares | Price   | Total     |
|------------|--------|---------|-----------|
| IBM        | 1000   | 25 USD  | 25000 USD |
| Novatris   | 400    | 150 CHF | 60000 CHF |
|            |        | Total   | 65000 USD |

| From | To  | Rate |
|------|-----|------|
| CHF  | USD | 1.5  |


The new implementation should support the following operations:

```
$5 + 10 CHF = $10 if rate is 2:1
$5 * 2 = $10 (this one is obvious but important)
```

## Sources Used and disclaimer

The entire example is based on the one described in detail in TDD by Example by Kent Beck.
We simply adapted it to C# in order to use during a live presentation for educational purposes.