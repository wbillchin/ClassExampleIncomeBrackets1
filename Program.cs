// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;

double inputIncome = 148000;
double upperTaxBracketCutOff = 75000;
double upperTaxBracketTaxRate = 0.30;
double lowerTaxBracketTaxRate = 0.08;

// if you make over 50,000, your tax rate is 25%
// and tax rate for 50,000 and below is 10%
// calculate total taxes

double taxesOwed = 0.0;

if ( inputIncome > upperTaxBracketCutOff )
{
    /*
     * calculate the amount of taxes owed in the upper tax bracket
     */
    double upperBracketIncome = inputIncome - upperTaxBracketCutOff;

    Console.WriteLine("it appears you have income over " + upperTaxBracketCutOff);
    Console.WriteLine("the amount subject to upper bracket taxes is " + upperBracketIncome);

    double upperBracketTaxes = upperBracketIncome * upperTaxBracketTaxRate;

    Console.WriteLine("upper bracket tax owed is " + upperBracketTaxes);

    taxesOwed = upperBracketTaxes;
    // inputIncome = inputIncome - upperBracketIncome;
    inputIncome -= upperBracketIncome;
}
else
{
    Console.WriteLine("your income of {0} is not sufficient to pay taxes in the upper tax bracket",
        inputIncome);
}

/*
 * calculate the lower bracket taxes
 */
Console.WriteLine("lower bracket income is {0}", inputIncome);

taxesOwed += inputIncome * lowerTaxBracketTaxRate;

Console.WriteLine("your total taxes owed is {0} and the upper tax bracket tax rate is {1}",
    taxesOwed, upperTaxBracketTaxRate);



