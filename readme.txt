

Travel insurance quote engine

A new quote engine is required that will take the details of a customer's insurance requirements and output a premium along with a breakdown of how that premium was obtained.

There are two types of travel insurance: single trip and annual.  In order to get a valid quote, the customer's age, sex and destination of travel must be provided.  For single trip insurance the period of travel must also be provided.  The information will be input in the form of a single string containing name/value pairs, separated by a colon, with each name/value pair on its own line. (e.g. Age:27)

The output should consist of a string detailing the premium calculations, with a line for each premium calculation step with the reason for the step, the change to the premium and the accumulated premium (e.g. Age (-12.51): 64.87).  When outputting numbers they should be shown to two decimal places, but the underlying values should not be rounded. 

Insurance premium tax of 5% should be added at the end.  The final premium should be rounded down to 2 decimal places.  At the end of the output should be a single line detailing the total premium (e.g. Total Premium: 97.29)

The rating tables below should be used to calculate the premium.  Apart from the base premium, the premium should be multiplied by the rating given to calculate the premium.  If the risk falls into a category labelled DECLINE then the quote engine must output only the string DECLINE: with the criterion that caused the decline (e.g. DECLINE:Age).

IMPORTANT NOTES

•	Input is not validate.
•	Ratings values are hard-coded in the code.   
•	Quote Engine is delivered as a class library and expose an entry point that takes a single string as input and returns a string E.g. public string ProduceQuote(string input). The method will be called once per scenario, the whole of the input will be passed as the parameter. 





Rating Tables
                       	        	Single Trip  	Annual
Base Premium            	£20.00        	£80.00

Age                     	0-18   19-45   46-55   56-65   66-70   71+
Rating                  	1.2      1.0      1.2       1.8        2.0       DECLINE
   
Sex                     	Male   Female
Rating                  	1.2      0.9

Destination             	UK     Europe   Worldwide
Rating                      	0.6    1.0          1.4

Period of travel (days) 	1-7    8-14   15-30   31+
Rating                          	0.5    0.9     1.2        DECLINE


Sample Inputs
-------------
1:

Type:SingleTrip
Age:20
Sex:Male
Destination:UK
PeriodOfTravel:10

2:

Type:Annual
Age:67
Sex:Female
Destination:Worldwide

3:

Type:SingleTrip
Age:76
Sex:Male
Destination:Worldwide
PeriodOfTravel:21


Expected Outputs
----------------
1:

BasePremium (20.00): 20.00
Age (0.00): 20.00
Sex (4.00): 24.00
Destination (-9.60): 14.40
PeriodOfTravel (-1.44): 12.96
Tax (0.65): 13.61
Total Premium: 13.60

2:

BasePremium (80.00): 80.00
Age (80.00): 160.00
Sex (-16.00): 144.00
Destination (57.60): 201.60
Tax (10.08): 211.68
Total Premium: 211.68

3:

DECLINE:Age
