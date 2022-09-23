# Get Enum Values

Functions for getting an enum value by index or an index by a value.

This is often done with casting:

  //Get value by index
  string value = (TestEnum)2;
  //Get index by enum
  int index = (int)TestEnum.lorem;

In this solutions however, casts were avoided.
