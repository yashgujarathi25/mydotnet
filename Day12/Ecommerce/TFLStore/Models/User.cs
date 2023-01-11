using System;
namespace TFLStore.Models;

[Serializable]
public class User {
    public string Name{get; set;}
    public string Email{get; set;}
    public string Password{ get; set; }
    public double Mobile {get; set;}
}