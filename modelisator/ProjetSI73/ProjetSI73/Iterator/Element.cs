﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Iterator
{
    public abstract class Element
{
  protected string description;

  public Element(string description)
  {
    this.description = description;
  }

  public bool motCleValide(string motCle)
  {
    return description.IndexOf(motCle) !=  -1;
  }
}

}
