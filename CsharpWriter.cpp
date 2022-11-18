#include "CsharpWriter.h"
#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <time.h>


using namespace std;

void CsharpWriter::csharpFilePrepare(string writetag) {

	string csharpFileHeader = "\n\nusing System;\nusing System.Collections.Generic;\nusing System.ComponentModel;\nusing System.Linq;\nusing System.Runtime.CompilerServices;\nusing System.Text;\nusing System.Threading.Tasks;\n\n\n";
	string csharpNamespace = "namespace YourNamespaceHere\n{\n\n";
	string csharpClassName = "internal class PAP2022Data\n{\n\n";
	string PAP_FileMainComment = "\n\n/* <!-- PROGRAMMABLAUFPLAN, PAP Seite 14 -->\n    < MAIN >\n      <EXECUTE method = \"MPARA\" / >\n      <EXECUTE method = \"MRE4JL\" / >\n       <EVAL exec = \"VBEZBSO= BigDecimal.ZERO\" / >\n       <EVAL exec = \"KENNVMT= 0\" / >\n       <EXECUTE method = \"MRE4\" / >\n       <EXECUTE method = \"MRE4ABZ\" / >\n       <EXECUTE method = \"MBERECH\" / >\n       <EXECUTE method = \"MSONST\" / >\n       <EXECUTE method = \"MVMT\" / >\n    < / MAIN> */\n\n";

	filename = "CsharpPAP2022.cs";

	

	ofstream csharpOut;
	csharpOut.exceptions(ofstream::failbit | ofstream::badbit);

	try
	{
		if (writetag == "clear")
		{
			csharpOut.open(filename, ofstream::out | ofstream::trunc);
			csharpOut.close();
		}


		csharpOut.open(filename, ofstream::out | ofstream::app);

		if (writetag == "begin") {

			struct tm newTime;
			__time64_t timeNow;
			_time64(&timeNow);
			char buffer[26];
			_localtime64_s(&newTime, &timeNow);
			asctime_s(buffer, 26, &newTime);

			
			csharpOut << "// -- Version-Datetime: "  << buffer << csharpFileHeader << csharpNamespace << csharpClassName << PAP_FileMainComment;



		}
		if (writetag == "end") csharpOut << "\n\n}  //End class\n}  //End namespace";


		csharpOut.close();
	}
	catch (const std::exception& e)
	{

		cerr << e.what() << endl;
		csharpOut.close();

	}



}

void CsharpWriter::writePropToFile(string name, string type, string value, bool iscomment, string comment) {

	isComment = iscomment;
	Comment = comment;

    propName = name;

	if (type == "BigDecimal") {

		propType = "decimal";
	}
	else
	{
		propType = type;
	}


	if (value == "null") {

		propValue = "";

	}
	else
	{
		if (value == "new BigDecimal(0)") {

			propValue = " = 0.00000m";

			}
		if (value == "BigDecimal.Zero") {

			propValue = " = 0.00000m";
		}

		if (type == "int") {

			propValue = " = " + value;
		}

		if (type == "double") {

			propValue = " = " + value + "d";
		}

	}


	
    string filename = "CsharpPAP2022.cs";

	ofstream csharpOut;
	csharpOut.exceptions(ofstream::failbit | ofstream::badbit);

	try
	{

		csharpOut.open(filename, ofstream::out | ofstream::app);

		if (isComment)
		{
			csharpOut << "\n" << Comment << "\n";
			isComment = false;
			Comment = "";
		}
		csharpOut << "\n" << "private  " << propType << "  _" << propName << propValue << ";\n\n";
		csharpOut << "public   " << propType << " " << propName << "\n        {\n          get { return _" << propName << ";  }\n          set {\n\n          if ( _" << propName << " != value) {\n"
			      << "               _" << propName << " = value;\n            }\n          }\n        }\n";
		


		csharpOut.close();
	}
	catch (const std::exception& e)
	{

		cerr << e.what() << endl;
		csharpOut.close();
		
	}



}


void CsharpWriter::writeFieldToFile(string name, string type, string value, bool iscomment, string comment) {

    isComment = iscomment;
    Comment = comment;
	
	fieldName = name;


	if (type == "BigDecimal") {

		fieldType = "decimal";
	}
	else
	{
		fieldType = type;
	}


	if (value == "null") {

		fieldValue = "";

	}
	else
	{
		if (value == "new BigDecimal(0)") {

			fieldValue = " = 0.00000m";

		}
		if (value == "BigDecimal.Zero") {

			fieldValue = " = 0.00000m";
		}

		if (type == "int") {

			fieldValue = " = " + value;
		}

		if (type == "double") {

			fieldValue = " = " + value + "d";
		}

	}



	string filename = "CsharpPAP2022.cs";

	ofstream csharpOut;
	csharpOut.exceptions(ofstream::failbit | ofstream::badbit);

	try
	{

		csharpOut.open(filename, ofstream::out | ofstream::app);

		if (isComment)
		{
			csharpOut << "\n" << Comment << "\n";
			isComment = false;
			Comment = "";
		}
		csharpOut << "\n" << "public  " << fieldType << "  " << fieldName << fieldValue << ";\n\n";
		


		csharpOut.close();
	}
	catch (const std::exception& e)
	{

		cerr << e.what() << endl;
		csharpOut.close();

	}



}


void CsharpWriter::writeConstantToFile(string name, string type, vector<string> value, bool iscomment, string comment) {

	isComment = iscomment;
	Comment = comment;
	constantValue.clear();
	constantName = name;

	
	if (type == "BigDecimal") {

		constantType = "decimal";
	}
	else
	{
		if (type == "BigDecimal[]") {
			 
			constantType = "List<decimal>";

		}
	
		constantType = type;
	}

	
	if (value.size() == 0) {

		constantValue.push_back("NoValue? ....");

	}
	else
	{
		
		for (auto iter = value.begin(); iter != value.end(); iter++)
		{
			if (*iter == "BigDecimal.ONE")
			{
				constantValue.push_back("1");
			}
			else
			{
				constantValue.push_back(*iter);
			}


		}	

	}
	
	//cout << constantValue.size() << endl;

	string filename = "CsharpPAP2022.cs";

	ofstream csharpOut;
	csharpOut.exceptions(ofstream::failbit | ofstream::badbit);

	try
	{

		csharpOut.open(filename, ofstream::out | ofstream::app);

		if (isComment)
		{
			csharpOut << "\n" << Comment << "\n";
			isComment = false;
			Comment = "";
		}


		csharpOut << "\n" << "public readonly  ";
		
		if (constantValue.size() == 1)
		{
			csharpOut << "decimal " << constantName << " = ";
		}
		else
		{
			csharpOut << "List<decimal> " << constantName << " = new() { ";
		}

		if (constantValue.size() == 1)
		{
			csharpOut << constantValue[0] << "m;\n";
		}
		else
		{
			for (auto iter = constantValue.begin(); iter != constantValue.end(); iter++)
			{
				
				csharpOut << *iter << "m";
				if (iter != constantValue.end()-1)
				{
					csharpOut << ", ";
				}
				else
				{
					csharpOut << " };\n";
				}


			}

			
		}




		csharpOut.close();
	}
	catch (const std::exception& e)
	{

		cerr << e.what() << endl;
		csharpOut.close();

	}



}



void CsharpWriter::testOut(string name, string type, string value) {

	cout << name << " " << type << " = " << value << ";" << endl;

}



//Konstruktor

CsharpWriter::CsharpWriter() {

	isComment = false;


}
