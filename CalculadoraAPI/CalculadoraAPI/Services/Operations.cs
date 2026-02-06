namespace CalculadoraAPI.Services;

public class Operations
{
    private readonly Validators _validators;
    private readonly Converter _converter;

    public Operations(Validators validators, Converter converter)
    {
        _validators = validators;
        _converter = converter;
    }

    public decimal Sum(string FirstNumber, string SecondNumber)
    {
        if (_validators.IsNumeric(FirstNumber) && _validators.IsNumeric(SecondNumber))
        {
            decimal sum = _converter.ConvertToDecimal(FirstNumber) + _converter.ConvertToDecimal(SecondNumber);
            return sum;
        }
        return 0;
    }

    public decimal Substract(string FirstNumber, string SecondNumber)
    {
        if (_validators.IsNumeric(FirstNumber) && _validators.IsNumeric(SecondNumber))
        {
            decimal substract = _converter.ConvertToDecimal(FirstNumber) - _converter.ConvertToDecimal(SecondNumber);
            return substract;
        }
        return 0;
    }

    public decimal Multiply(string FirstNumber, string SecondNumber)
    {
        if (_validators.IsNumeric(FirstNumber) && _validators.IsNumeric(SecondNumber))
        {
            decimal multiply = _converter.ConvertToDecimal(FirstNumber) * _converter.ConvertToDecimal(SecondNumber);
            return multiply;
        }
        return 0;
    }

    public decimal Divide(string FirstNumber, string SecondNumber)
    {
        if (_validators.IsNumeric(FirstNumber) && _validators.IsNumeric(SecondNumber))
        {
            var divide = _converter.ConvertToDecimal(FirstNumber) / _converter.ConvertToDecimal(SecondNumber);
            return divide;
        }
        return 0;
    }

    public decimal Average(string FirstNumber, string SecondNumber)
    {
        if (_validators.IsNumeric(FirstNumber) && _validators.IsNumeric(SecondNumber))
        {
            var average = (_converter.ConvertToDecimal(FirstNumber) + _converter.ConvertToDecimal(SecondNumber)) / 2;
            return average;
        }
        return 0;
    }
}