using System.Collections.Generic;
public class FoodModel

namespace DataGov_API_Intro.Models
{
public class FoodModel

{

public int FoodModelID { get; set; };

public List<Food> foods { get; set; };

}

public class Food

{

public int foodsID { get; set; };

public int fdcId { get; set; };

public int dataPoints { get; set; };

public int min { get; set; };

public int max { get; set; };

public string dataType { get; set; };

public string description { get; set; };

public string foodCode { get; set; };

public int score { get; set; };

public int nutrientId { get; set; };

public int nutrientNumber { get; set; };

public string nutrientName { get; set; };

public int rank { get; set; };

public string unitName { get; set; };

public string foodDescription { get; set; };

public string dataType { get; set; };

}
}
