using Microsoft.ML.Runtime.Api;
namespace _3._0TaxiFarePredictor
{
    public class TaxiTripFarePrediction
    {
        [ColumnName("Score")]
        public float fare_amount;
    }
}