namespace CalculadoraAPI.Services;

public class Validators
{
    public bool IsNumeric(string strNumber)
    {
        decimal decimalValue;

        bool isNumeric = decimal.TryParse(
            strNumber, 
            System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo, 
            out decimalValue);
        return isNumeric;
    }
}