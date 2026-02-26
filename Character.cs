class Character
{
    public UInt64 Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Species { get; set; } = string.Empty;
    public string First_Appearance { get; set; } = string.Empty;
    public string Year_Created { get; set; } = string.Empty;


    public string Display()
    {
        return $"Id: {Id}\nName: {Name}\nDescription: {Description}\nSpecies: {Species}\nFirst Appearance: {First_Appearance}\nYear Created {Year_Created}\n";
    }
}