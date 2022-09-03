namespace WebApplication1.Models;

public class Cars
{
    
    public long Id { get; set; }
    private string Name { get; set; }
    private string Model { get; set; }
    private string Color { get; set; }
    
    
    public Cars(string name, string model, string color)
    {
        Name = name;
        Model = model;
        Color = color;
    }
    
    public Cars()
    {
        
    }
    
    public string GetName()
    {
        return Name;
    }
    
    public string GetModel()
    {
        return Model;
    }
    
    public string GetColor()
    {
        return Color;
    }
    
    public void SetName(string name)
    {
        Name = name;
    }
    
    
    public void SetModel(string model)
    {
        Model = model;
    }
    
    public void SetColor(string color)
    {
        Color = color;
    }
    
    public override string ToString()
    {
        return "Name: " + Name + " Model: " + Model + " Color: " + Color;
    }
    
    
    
}