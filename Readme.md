These little examples attempt to explain how a variable can be captured, how to avoid this, when and what's the penalty cost.

# Closures

What are closures?

Closures allow you to encapsulate some behavior, pass it around like any other object, and still have access to the context in which they were first declared.

# Captured variables

 - Why does it happen: the closure still has access to the context
 - Sometimes it's the desired behavior: see filter
 - Sometimes it's not: see counter
 - Let's have a look at [low level code](https://sharplab.io/#v2:CYLg1APgAgTAjAWAFBQAwAIpwCwG5lqZwB0A4gDYD2ARgIbkCWAXrQC4OUB2+KGWArDwIBmTDHQBhZAG9k6eQ06sApgCdO9IgDZ0ASQAyDAM6sAPABUAfOgBiDcitUXLACgPGzV9EcoBXVQDGygA06AAKqsrADAFsys7oAA6R0bEqAJRy8rJI8nnoAG60qugAZvaOUYYm6AC86JzKAO7o1Z6u6Tz58qWUkbQBABboLuboDCoAtuOc3n6Bypm53Tnd+QylI8lRMXEuE8qT6Utreaun3eUOalUexACCwMD7U51ZpwC+73lfSN/yUAA7GUKjdgG0uvJfu9FI4NORtJhsOFVLC2s43OivD5/EETtl/mU+soBsNRuMpjM5rjFoTzqcsABOF6HN7LfK/H7IGFKNTwxFQZEAEWMiXItAAngB5agAK2UAVYLho8sVAH50JR8eh6XkNiNKHV6pxfORyNqzoT8kyXAAiE1m21stac7rKchGZR0q15KBaYgAJV8nBcLnSdWsNq1zu6rvQ0PZUFEgvQAFkw+9dfJ3CZTFhUNYjLRJmLlAB1PrAIx1dAAbVtAGUAv1JrbQrafJNlG30LbWKo/NRGJwAOY921NezkcdNStGceDWgFbvtoyJBUbXZmiXj0rB8eMViscgr3ue3mcILj2W0NW2gC6kOtcFQGv64MUyhrEi4PhPxF0ThAxJD9GjDJ89U2fYlGIcxVAlMJik9Fx30MRpQgkU1WH8ZRAN6ADOCKVFaCUTCHBw0I/FYGZqNnVRwWUUdWEGY5vXZNYczMfNrF8T1VAreijAg7oIh2NJ4m4pIUl2FRRHqA5plqawFOIfRGJHZj0FMeo6IYpjBmE/JeLUASqxrOxrlUFwixLE9TKMUJtlSOJhBjU4IjRDwXGM/i5zZH0iGZe1KBaSdNP4EAnUMvIAHoYsKYoGFoIcv04ShqKKchfC/WJEmwlIAt0tT9JrQQAp8+zzNBKybNLezHOk8TXOi+QPKUNpvL4+y3K5P52IBOAgp/YNHBAXsevkdEsBgawBnYX8a0aFoprgGbwMJXoSmg6iAj8XkSnqVBcHQXaRrULT0BfY7Tv2sAwAtAl+vyOaOE4IwHieUNwyUwKXBuxxjkMhM1ji9BzEGRj0GUAAPBVfBUdBmMODbiVJEZpvQF6uCpLG3oenUAtx9anuB7oRTXcVpTlBUlVxowJvQcmxUlGVVSVB1zSfX4PiAA=)
 - simple performance optimizations
 - ConcurrentDictionary and captured variables. See [Meziantou blog](https://www.meziantou.net/concurrentdictionary-closure.htm)

# Conclusion

Be aware when using closures with local variables because of unexpected consequences.

[IL Explanation](https://unicorn-dev.medium.com/how-to-capture-a-variable-in-c-and-not-to-shoot-yourself-in-the-foot-d169aa161aa6)
