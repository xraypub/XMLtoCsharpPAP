#include "StringWorker.h"
#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <regex>


using namespace std;


void StringWorker::MethodStringToCsharpCode(string matchstring, string name) {

	
	
	
	string tempString = "";

	string methodName = name;

	

	string result = StringWorker::StringReplace("&lt;", "<", matchstring);    //matchstring Aufbereitung!!
	result = StringWorker::StringReplace("&gt;", ">", result);
	result = StringWorker::StringReplace("&amp;", "&", result);
	result = StringReplace("BigDecimal\\.ZERO", "Decimal.Zero", result);
	result = StringReplace("compareTo", "CompareTo", result);
	//result = StringWorker::StringReplace("<-- Any --- >", " replace ", result);
	//cout << "\n\n" << result << endl;


	string codestring = result;


	string filename = "CsharpPAP2022.cs";

	ofstream csharpOut;
	csharpOut.exceptions(ofstream::failbit | ofstream::badbit);

	try
	{
		
		csharpOut.open(filename, ofstream::out | ofstream::app);

		csharpOut << "\n\n\n// Method Begin:  " << methodName << "--------------------------------------------------------\n" << endl;
		csharpOut << "\npublic void " << methodName << "()\n        {\n" << endl;
		
		for (size_t i = 0; i < codestring.length(); i++)
		{
			if (codestring[i] == '<' && codestring[i + 1] == 'I' && codestring[i + 2] == 'F' && codestring[i + 3] == ' ')   //Find IF
			{
				string tempExprString = "";
				bool isExprEnd = false;
				size_t j = i + 3;
				size_t exprBegin = 0;
				size_t exprEnd = 0;

				while (isExprEnd == false)  // FIND IF-CONDITION
				{
					if (codestring[j] == '=' && codestring[j + 1] == '"') exprBegin = j + 2;
					if (codestring[j] == '"' && codestring[j + 1] == '>') {
						exprEnd = j - 1;
						isExprEnd = true;
						for (size_t k = exprBegin; k <= exprEnd; k++)
						{
							tempExprString += codestring[k];
						}
					}
					j++;
				}

				//tempExprString extract - replace
			
				regex rgxBigDecimalIF("BigDecimal\\.valueOf.*\\(([0-9]*\\.?[0-9]*)\\)\\)");       
				smatch matchIf;

				regex_search(tempExprString, matchIf, rgxBigDecimalIF);				
				tempExprString = StringReplace("BigDecimal\\.valueOf.*\\([0-9]*\\.?[0-9]*\\)", matchIf.str(1) + "m", tempExprString);
				tempExprString = StringReplace("BigDecimal.ONE", "Decimal.One", tempExprString);
				tempExprString = StringReplace(".add", " + ", tempExprString);
				tempExprString = StringReplace(".subtract", " - ", tempExprString);
				tempExprString = StringReplace(".multiply", " * ", tempExprString);
				tempExprString = StringReplace(".divide", " / ", tempExprString);


				csharpOut << "         " << "if ( " << tempExprString;
				csharpOut << " ) \n" << endl;
				


			}
			/*if (codestring[i] == '/' && codestring[i + 1] == 'I' && codestring[i + 2] == 'F')    // Find IF-End
			{
				csharpOut << "            }\n" << endl;
			}*/
			if (codestring[i] == '<' && codestring[i + 1] == 'T' && codestring[i + 2] == 'H' && codestring[i + 3] == 'E' && codestring[i + 4] == 'N')   // Find THEN
			{
				csharpOut << "           {\n";
				csharpOut << "\n              //to do's\n" << endl;
				
			}
			if (codestring[i] == '<' && codestring[i + 1] == '/' && codestring[i + 2] == 'T' && codestring[i + 3] == 'H' && codestring[i + 4] == 'E' && codestring[i + 5] == 'N')   // Find THEN-End
			{
				csharpOut << "\n           }\n";

			}
			if (codestring[i] == '<' && codestring[i + 1] == 'E' && codestring[i + 2] == 'L' && codestring[i + 3] == 'S' && codestring[i + 4] == 'E')   // Find ELSE
			{
				csharpOut << "        \n         else\n            {\n";
				csharpOut << "              //to do's\n" << endl;

			}
			if (codestring[i] == '/' && codestring[i + 1] == 'E' && codestring[i + 2] == 'L' && codestring[i + 3] == 'S' && codestring[i + 4] == 'E')   // Find ELSE-End
			{
				csharpOut << "\n            }\n" << endl;
			}

			if (codestring[i] == '<' && codestring[i + 1] == 'E' && codestring[i + 2] == 'V' && codestring[i + 3] == 'A' && codestring[i + 4] == 'L')   //Find <EVAL .... /> 
			{
				string tempEvalString = "";
				string outEvalString = "";
				bool isEvalEnd = false;
				size_t j = i + 4;
				size_t evalBegin = i;
				size_t evalEnd = 0;

				while (isEvalEnd == false)
				{

					if (codestring[j] == '/' && codestring[j + 1] == '>') {
						evalEnd = j + 1;
						isEvalEnd = true;
						for (size_t k = evalBegin; k <= evalEnd; k++)
						{
							tempEvalString += codestring[k];
						}
					}
					j++;
				}

				// Math-String to C#-Math ?! -> call Method 
				outEvalString = MathStringToCsharpMath(tempEvalString);
				//outEvalString = tempEvalString;
				csharpOut << "\n               " << outEvalString << "\n" << endl;


			}


			if (codestring[i] == '<' && codestring[i + 1] == 'E' && codestring[i + 2] == 'X' && codestring[i + 3] == 'E' && codestring[i + 4] == 'C' && codestring[i + 5] == 'U'
				&& codestring[i + 6] == 'T' && codestring[i + 7] == 'E' && codestring[i + 8] == ' ')   // Find EXECUTE Method
			{

				string tempExecuteString = "";
				bool isExecuteEnd = false;
				size_t j = i + 8;
				size_t execBegin = 0;
				size_t execEnd = 0;

				while (isExecuteEnd == false)
				{
					if (codestring[j] == '=' && codestring[j + 1] == '"') execBegin = j + 2;
					if (codestring[j] == '"' && codestring[j + 1] == '/' && codestring[j + 2] == '>') {
						execEnd = j - 1;
						isExecuteEnd = true;
						for (size_t k = execBegin; k <= execEnd; k++)
						{
							tempExecuteString += codestring[k];
						}
					}
					j++;
				}


				csharpOut << "\n                " << tempExecuteString << "();\n" << endl;

			}


			if (codestring[i] == '<' && codestring[i + 1] == '/' && codestring[i + 2] == 'M' && codestring[i + 3] == 'E' && codestring[i + 4] == 'T' && codestring[i + 5] == 'H'
				&& codestring[i + 6] == 'O' && codestring[i + 7] == 'D' && codestring[i + 8] == '>')   // Find End of Method
			{
				csharpOut << "        }" << "// End of Method:  " << methodName << "\n\n" << endl;
			}


		}
		
		csharpOut.flush();
		csharpOut.close();
		
	}



	catch (const std::exception& e)
	{

		cerr << e.what() << " StringWorker Error " << endl;
		csharpOut.close();

	}


}


string StringWorker::MathStringToCsharpMath(string tempString){
	 
	bool checker = false;

	string evalString = tempString;
	string mathString = "";

	regex rgxBigDecimal("new BigDecimal\\((.*)\\)");
	regex rgxBigDecimalValueOfLong("BigDecimal\\.valueOf.*\\((.*)\\.longValue\\(\\)\\)");
	regex rgxBigDecimalBigDecimal("BigDecimal\\.valueOf.*\\(([0-9]*.?[0-9]*)\\).*BigDecimal\\.valueOf.*\\(([0-9]*.?[0-9]*)\\)");
	regex rgxBigDecimalValueOfAbisZ("BigDecimal\\.valueOf.?\\(([a-zA-Z]*)\\)");                
	regex rgxBigDecimalValueOf0bis9("BigDecimal\\.valueOf.?\\(([0-9]*?\\.?[0-9]*)\\)");   
	regex rgxBigDecimalDotValues("BigDecimal\\.valueOf.?(\\([a-zA-Z]*\\..*\\(?\\)?\\))");
	regex rgxBigDecimalAddSubEtc("BigDecimal\\.valueOf.?\\(([0-9]*\\.[0-9]*)(.)([0-9]*\\.?[0-9]*)\\)");  // BigDecimal.valueOf( x + y) etc.
	regex rgxDivideBigDecimalRoundDown0("=(.*).\\/.*?\\((.*),.0,.*BigDecimal\\.ROUND_DOWN\\)");
	regex rgxDivideBigDecimalRoundDown2("=(.*).\\/.*\\((ZAHL.*?),.2,.*BigDecimal\\.ROUND_DOWN\\)");
	regex rgxDivideBigDecimalRoundDown6("=(.*).\\/.*\\((ZAHL.*?),.6,.*BigDecimal\\.ROUND_DOWN\\)");
	regex rgxSetScaleDecimalRoundDown0("=(.*)\\.setScale.*\\(.*0.*,.*BigDecimal\\.ROUND_DOWN.*\\)");
	regex rgxSetScaleDecimalRoundDown2("=(.*)\\.setScale.*\\(.*2.*,.*BigDecimal\\.ROUND_DOWN.*\\)");
	regex rgxSetScaleDecimalRoundUP0("=(.*)\\.setScale.*\\(.*0.*,.*BigDecimal\\.ROUND_UP.*\\)");
	regex rgxSetScaleDecimalRoundUP2("=(.*)\\.setScale.*\\(.*2.*,.*BigDecimal\\.ROUND_UP.*\\)");
	
	smatch matches;                                                                              

	mathString = StringReplace("<EVAL exec=\"", " ", evalString);
	mathString = StringReplace("\"/>", ";", mathString);
	mathString = StringReplace("BigDecimal\\.valueOf\\([0]\\)", " 0m ", mathString);

	regex_search(mathString, matches, rgxBigDecimal);
	mathString = StringReplace("new BigDecimal\\(.*\\)", matches.str(1) + "m", mathString);

	regex_search(mathString, matches, rgxBigDecimalValueOfLong);
	mathString = StringReplace("BigDecimal\\.valueOf.*\\(.*\\.longValue\\(\\)\\)", " (decimal) Math.Truncate( " + matches.str(1) + " )", mathString);

	checker = regex_search(mathString, matches, rgxBigDecimalBigDecimal);
	//cout << "matches1: " << matches.str(1) << " matches2: " << matches.str(2) << endl;
	if (checker)
	{
		string temp1;
		temp1 = regex_replace(mathString, regex("BigDecimal\\.valueOf.*\\(" + matches.str(1) + "\\)"), matches.str(1)+"m ");
		mathString = regex_replace(temp1, regex("BigDecimal\\.valueOf.*\\(" + matches.str(2) + "\\)"), matches.str(2)+"m ");
		
		//cout << mathString << endl;
		
	}
	
	regex_search(mathString, matches, rgxBigDecimalValueOfAbisZ);
	mathString = StringReplace("BigDecimal\\.valueOf.?\\([a-zA-Z]*\\)", " (decimal) " + matches.str(1), mathString);
	regex_search(mathString, matches, rgxBigDecimalValueOf0bis9);
	mathString = StringReplace("BigDecimal\\.valueOf.?\\([0-9]*?\\.?[0-9]*\\)", matches.str(1) + "m", mathString);
	
	regex_search(mathString, matches, rgxBigDecimalAddSubEtc);
	mathString = StringReplace("BigDecimal\\.valueOf.?\\(.*\\)", matches.str(1) + "m " + matches.str(2) + " " + matches.str(3) + "m", mathString);
	
	
	mathString = StringReplace(".add", " + ", mathString);
	mathString = StringReplace(".subtract", " - ", mathString);
	mathString = StringReplace(".multiply", " * ", mathString);
	mathString = StringReplace(".divide", " / ", mathString);

	regex_search(mathString, matches, rgxDivideBigDecimalRoundDown0);
	mathString = StringReplace("=.*\\/.*?\\(*,.0,.*BigDecimal\\.ROUND_DOWN\\)", " = Decimal.Floor( (" + matches.str(1) + " / " + matches.str(2) + ")  )", mathString);

	regex_search(mathString, matches, rgxDivideBigDecimalRoundDown2);
	mathString = StringReplace("=.*\\/.*\\(ZAHL.*?,.2,.BigDecimal\\.ROUND_DOWN\\)", " = Decimal.Floor( (" + matches.str(1) + " / " + matches.str(2) + ") * 100m ) / 100m", mathString);

	regex_search(mathString, matches, rgxDivideBigDecimalRoundDown6);
	mathString = StringReplace("=.*\\/.*\\(ZAHL.*?,.6,.*BigDecimal\\.ROUND_DOWN\\)", " = Decimal.Floor( (" + matches.str(1) + " / " + matches.str(2) + ") * 1000000m ) / 1000000m", mathString);

	regex_search(mathString, matches, rgxSetScaleDecimalRoundDown0);
	mathString = StringReplace("=.*\\.setScale.*\\(.*0.*,.*BigDecimal\\.ROUND_DOWN.*\\)", " = Decimal.Floor(  " + matches.str(1) + "  ) ", mathString);
	
	regex_search(mathString, matches, rgxSetScaleDecimalRoundDown2);
	mathString = StringReplace("=.*\\.setScale.*\\(.*2.*,.*BigDecimal\\.ROUND_DOWN.*\\)", " = Decimal.Floor( ( " + matches.str(1) + " ) * 100m ) / 100m", mathString);

	regex_search(mathString, matches, rgxSetScaleDecimalRoundUP0);
	mathString = StringReplace("=.*\\.setScale.*\\(.*0.*,.*BigDecimal\\.ROUND_UP.*\\)", " = Decimal.Ceiling( ( " + matches.str(1) + " ) ) ", mathString);

	regex_search(mathString, matches, rgxSetScaleDecimalRoundUP2);
	mathString = StringReplace("=.*\\.setScale.*\\(.*2.*,.*BigDecimal\\.ROUND_UP.*\\)", " = Decimal.Ceiling( ( " + matches.str(1) + " ) * 100m ) / 100m", mathString);

	 return mathString;

	}


string StringWorker::StringReplace(string regX, string rePlace, string sourcestring) {

	string result;
	regex strrepl(regX);

	result = regex_replace(sourcestring, strrepl, rePlace);

	// evtl. weitere String-Operationen

	return result;
}






//Konstruktor
StringWorker::StringWorker() {


}