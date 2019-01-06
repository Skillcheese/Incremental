using System;

public class Character
{
    public String name;
    public CLASSES characterClass;
    public bool isFemale;

	public Character()
	{

	}

    public Character(String _name, CLASSES _characterClass, bool _isFemale)
    {
        name = _name;
        characterClass = _characterClass;
        isFemale = _isFemale;
    }
}

public enum CLASSES
{
    MAGE = "Mage",
    ROGUE = "Rogue",
    CLERIC = "Cleric",
    PALADIN = "Paladin"
}