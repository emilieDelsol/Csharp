namespace ConsoleAppQueteResFull
{
	public class Comments
	{
		public int PostId {get; set;}
		public int id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Body { get; set; }
		public override string ToString()
		{
			return ($" \t NOM: {Name} EMAIL: {Email} \n\t\tCONTENU: {Body}\n");
		}
	}
}