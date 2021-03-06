using System.Collections.Generic;

namespace DataGov_API_Intro.Models
{
    public class Rootobject
    {
        public int totalHits { get; set; }
        public int currentPage { get; set; }
        public int totalPages { get; set; }
        public int[] pageList { get; set; }
        public List<Foodnutrient> data { get; set; }
        public Foodsearchcriteria foodSearchCriteria { get; set; }
        public Food[] foods { get; set; }
        public Foodnutrient[] foodNutrients { get; set; }
        public Aggregations aggregations { get; set; }
    }

    public class Foodsearchcriteria
    {
        public int pageNumber { get; set; }
        public int numberOfResultsPerPage { get; set; }
        public int pageSize { get; set; }
        public bool requireAllWords { get; set; }
    }

    public class Aggregations
    {
        public Datatype dataType { get; set; }
        public Nutrients nutrients { get; set; }
    }

    public class Datatype
    {
        public int Branded { get; set; }
        public int SRLegacy { get; set; }
        public int SurveyFNDDS { get; set; }
        public int Foundation { get; set; }
        public int Experimental { get; set; }
    }

    public class Nutrients
    {
    }

    public class Food
    {
        public int fdcId { get; set; }
        public string description { get; set; }
        public string lowercaseDescription { get; set; }
        public string commonNames { get; set; }
        public string additionalDescriptions { get; set; }
        public string dataType { get; set; }
        public string ingredients { get; set; }
        public int foodCode { get; set; }
        public string publishedDate { get; set; }
        public string foodCategory { get; set; }
        public int foodCategoryId { get; set; }
        public string allHighlightFields { get; set; }
        public float score { get; set; }
        public Foodnutrient[] foodNutrients { get; set; }
        public Finalfoodinputfood[] finalFoodInputFoods { get; set; }
        public Foodmeasure[] foodMeasures { get; set; }
        public object[] foodAttributes { get; set; }
        public Foodattributetype[] foodAttributeTypes { get; set; }
        public object[] foodVersionIds { get; set; }
        public string scientificName { get; set; }
        public int ndbNumber { get; set; }
    }

    public class Foodnutrient
    {
        public int nutrientId { get; set; }
        public string nutrientName { get; set; }
        public string nutrientNumber { get; set; }
        public string unitName { get; set; }
        public float value { get; set; }
        public int rank { get; set; }
        public int indentLevel { get; set; }
        public int foodNutrientId { get; set; }
        public string derivationCode { get; set; }
        public string derivationDescription { get; set; }
        public int derivationId { get; set; }
        public int foodNutrientSourceId { get; set; }
        public string foodNutrientSourceCode { get; set; }
        public string foodNutrientSourceDescription { get; set; }
        public int dataPoints { get; set; }
        public float min { get; set; }
        public float max { get; set; }
    }

    public class Finalfoodinputfood
    {
        public string foodDescription { get; set; }
        public float gramWeight { get; set; }
        public int id { get; set; }
        public string portionCode { get; set; }
        public string portionDescription { get; set; }
        public string unit { get; set; }
        public int rank { get; set; }
        public int srCode { get; set; }
        public float value { get; set; }
    }

    public class Foodmeasure
    {
        public string disseminationText { get; set; }
        public float gramWeight { get; set; }
        public int id { get; set; }
        public string modifier { get; set; }
        public int rank { get; set; }
        public string measureUnitAbbreviation { get; set; }
        public string measureUnitName { get; set; }
        public int measureUnitId { get; set; }
    }

    public class Foodattributetype
    {
        public string name { get; set; }
        public string description { get; set; }
        public int id { get; set; }
        public Foodattribute[] foodAttributes { get; set; }
    }

    public class Foodattribute
    {
        public string value { get; set; }
        public int id { get; set; }
        public int sequenceNumber { get; set; }
        public string name { get; set; }
    }
}