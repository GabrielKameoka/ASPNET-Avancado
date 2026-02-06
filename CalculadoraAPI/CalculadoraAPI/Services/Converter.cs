namespace CalculadoraAPI.Services;

public class Converter
{
    public decimal ConvertToDecimal(string strNumber)
    {
        decimal decimalValue;

        if (decimal.TryParse(
                strNumber, 
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out decimalValue))
            return decimalValue;

        return 0;
    }
}