using System.Collections.Generic;

namespace Client;

public class Polynomial : List<int> {
  public Polynomial(int multiplier, IList<int> roots)
  {
    var power = roots.Count;
    var array = new int[power];
    for (var i = 0; i < power; i++) {
      FillValues(i);
    }
    Add(multiplier);
    foreach (var i in array) {
      multiplier *= -1;
      Add(i * multiplier);
    }
    
    return;

    void FillValues(int index, int value = 1, int layer = 0)
    {
      value *= roots[index];
      array[layer] += value;
      for (var i = index + 1; i < power; i++) {
        FillValues(i, value, layer + 1);
      }
    }
  }
}
