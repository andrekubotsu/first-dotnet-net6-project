# Class 03

## 1. Variable types

### a. Value Types

- value types variables has its own data directly;
- each variable has its own data copy and it is not possible that the operations affect another variable (except paramaters variables like `ref` and `out`);
- types:
  - Numerics: sbyte, short, int, long, byte, ushort, uint, ulong;
  - Unicode: char;
  - Floating points: float, doube, decimal
  - Boolean: bool
  - enum, struct and nullable types ('int?')

### b. Reference types

- reference types stores data references;
- it is possible that two variables do reference to the same object and operations in one variable affects the other one;
- types:
  - class types: class, object, string
  - array types: int[], int[,], etc
  - interface, delegate

## 2. Instructions

- program actions are expressed using instructions;
- it is delimited by `{ block with several instructions in contexts }`
- as instructions we have:
  - variables declarations
  - if
  - switch
  - while
  - do
  - for
  - foreach
  - break
  - continue
  - return
  - throw
  - try, catch, finally
  - using

## 3. Arrays

- reference types;
- it could be unidimensional
- multidimensional (matrix)
