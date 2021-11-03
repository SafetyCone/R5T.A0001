using System;


namespace R5T.A0001
{
    public static class IHostServiceActionAggregrationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IHostServiceActionAggregration other)
            where T : IHostServiceActionAggregration
        {
            (aggregation as IHostServiceActionAggregrationIncrement).FilFrom(other);

            return aggregation;
        }
    }
}
