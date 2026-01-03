using System;
using System.Data.Common;
using System.Collections;
class Mycollectoin : IEnumerable
{
  int[] data ={14,52,32};
  public IEnumerator GetEnumerator()
  {
    return data.GetEnumerator();
  }
}