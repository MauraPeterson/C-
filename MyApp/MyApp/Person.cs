public class Person
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string FullName
	{
		get { return FirstName + " " + LastName; }
	}
	public string GetFullName()
	{
		return FirstName + " " + LastName;
	}

	public bool isCoolGuy()
	{
		if(FullName == "Cool Guy")
		{
			return true;
		} else
		{
			return false;
		}
	}
}