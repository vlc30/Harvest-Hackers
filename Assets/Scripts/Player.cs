using UnityEngine;

public class Player : MonoBehaviour
{
  public Inventory inventory;

  private voide Awake()
    {
        inventory = new Inventory(21);
    }
}
