#pragma once
#include <iostream>
#include <fstream>
#include <string>
#include <vector>

using namespace std;

class CsharpWriter
{
public:

    string filename;

	void testOut(string name, string type, string value);
	void csharpFilePrepare(string);      //    string: "begin" -> write Header | string: "end" -> write Namespace und Class End-Tags "}"
	void writePropToFile(string name, string type, string value, bool iscomment, string comment);
	void writeFieldToFile(string name, string type, string value, bool iscomment, string comment);
	void writeConstantToFile(string name, string type, vector<string> value, bool iscomment, string comment);

	//Konstruktor
	CsharpWriter();
	

private:

	string propName;
	string propType;
	string propValue;

	string fieldName;
	string fieldType;
	string fieldValue;

	string constantName;
	string constantType;
	vector<string> constantValue;

	bool isComment;
	string Comment;


};

