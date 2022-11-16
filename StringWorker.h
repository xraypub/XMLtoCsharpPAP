#pragma once
#include <fstream>
#include <string>
#include <sstream>

using namespace std;

class StringWorker
{

public:

	void MethodStringToCsharpCode(string, string);
	string MathStringToCsharpMath(string);
	string StringReplace(string, string, string);

	//Konstruktor
	StringWorker();



private:

	//string trimResult;

};

