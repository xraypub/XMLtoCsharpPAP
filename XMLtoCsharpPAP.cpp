// XMLtoCsharpPAP.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
// derzeit keine Eingabe über argv[] z.B. XML-PAP Dateiname -> direkt im Programm!! 
//
#include "CsharpWriter.h"
#include "StringWorker.h"
#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <vector>
#include <regex>





using namespace std;

    int main()
    {
        string xmlFilename = "Lohnsteuer2022.xml.xhtml"; //BMF PAP XML-Datei
        string xmlLine = ""; 

        string propertyName = "";
        string propertyType = "";
        string propertyValue = "";

        string fieldName = "";
        string fieldType = "";
        string fieldValue = "";

        string constantName = "";
        string constantType = "";
        string constantValue = "";
        string constantSubMatchString = "";

        string matchstring;
        string methodName = "";


        string comment = "";

        bool check = false;
        bool checkMethodBegin = false;
        bool checkMethodEnd = false;

        bool isInputComment = true;
        string inputComment = "// INPUT Properties -----------------------";
        bool isOutputComment = true;
        string outputComment = "// OUTPUT Properties ---------------------";
        bool isFieldComment = true;
        string fieldComment = "// INTERNAL Fields ------------------------";
        bool isConstantsComment = true;
        string constantsComment = "// CONSTANTS --------------------------";

        ifstream xmlSource;
        xmlSource.exceptions(ifstream::failbit | ifstream::badbit);   // logischer I/O Fehler | read/write Fehler

        

        //REGEX für INPUT - OUTPUT Properties / INTERNAL FIelds / CONSTANTS:
        regex regxINPUT ("^\\s*(<INPUT ).*$");
        regex regxOUTPUT("^\\s*(<OUTPUT ).*$");
        regex regxINTERNAL("\\s*(<INTERNAL ).*$");
        regex regxCONSTANT("^\\s*(<CONSTANT ).*$");
        regex regxCONSTANT_SubMatch(".*(value=.*)");
        regex extractName("name=\"(.*?)\".");
        regex extractType("type=\"(.*?)\".");
        regex extractValue("default=\"(.*?)\".");
        regex extractValueCONSTANTS("(\\d*\\.?\\d+)|BigDecimal\\.ONE");   
        regex methodBegin("^\\s*<METHOD name=\"(.*)\".*");
        regex methodEnd(".*METHOD>.*$");
        // regex extractAnyOther .....
                   
        smatch match, sub_match,  ex_matches, matchMethodName, matchMethodEnd;

        CsharpWriter CsharpWrite;
        StringWorker Worker;

        try
        {
            // Properties etc. aus XML File
            cout << xmlFilename << "\n\nConverting Properties - INPUT, OUTPUT - Internals - Constants ...." << endl;

            xmlSource.open(xmlFilename);
            CsharpWrite.csharpFilePrepare("clear");
            CsharpWrite.csharpFilePrepare("begin");

            

            while (xmlSource.good()) {
                check = false;
                getline(xmlSource, xmlLine);
                

                // INPUT Properties aus XML File ---------------------------------------------------

                check = regex_match(xmlLine, match, regxINPUT);         
                if (check) {

                    
                    check = false;
                    check = regex_search(xmlLine, ex_matches, extractName);   // INPUT Property.Name
                    if(check) {

                        propertyName = ex_matches[1];
                        //cout << "name= " << propertyName << endl;
                        
                    }
                    else
                    {
                        propertyName = "null";
                        //cout << "name= " << propertyName << endl;

                    }

                    check = false;
                    check = regex_search(xmlLine, ex_matches, extractType);   // INPUT Property.Type
                    if (check) {

                        propertyType = ex_matches[1];
                        //cout << "type= " << propertyType << endl;

                    }
                    else
                    {
                        propertyType = "null";
                        //cout << "type= " << propertyType << endl;

                    }

                    check = false;
                    check = regex_search(xmlLine, ex_matches, extractValue);   // INPUT Property.Value
                    if (check) {

                        propertyValue = ex_matches[1];
                        //cout << "value= " << propertyValue << endl;

                    }
                    else
                    {
                        propertyValue = "null";
                        //cout << "value= " << propertyValue << endl;

                    }

                    
                    //PropWrite.testOut(propertyName, propertyType, propertyValue);
                    
                    CsharpWrite.writePropToFile(propertyName, propertyType, propertyValue, isInputComment, inputComment);
                    isInputComment = false;
                    
                } //regex INPUT Ende



                 // OUTPUT Properties aus XML File ---------------------------------------------------

                check = regex_match(xmlLine, match, regxOUTPUT);
                if (check) {


                    check = false;
                    check = regex_search(xmlLine, ex_matches, extractName);   // OUTPUT Property.Name
                    if (check) {

                        propertyName = ex_matches[1];
                        //cout << "name= " << propertyName << endl;

                    }
                    else
                    {
                        propertyName = "null";
                        //cout << "name= " << propertyName << endl;

                    }

                    check = false;
                    check = regex_search(xmlLine, ex_matches, extractType);   // OUTPUT Property.Type
                    if (check) {

                        propertyType = ex_matches[1];
                        //cout << "type= " << propertyType << endl;

                    }
                    else
                    {
                        propertyType = "null";
                        //cout << "type= " << propertyType << endl;

                    }

                    check = false;
                    check = regex_search(xmlLine, ex_matches, extractValue);   // OUTPUT Property.Value
                    if (check) {

                        propertyValue = ex_matches[1];
                        //cout << "value= " << propertyValue << endl;

                    }
                    else
                    {
                        propertyValue = "null";
                        //cout << "value= " << propertyValue << endl;

                    }


                    
                    
                    CsharpWrite.writePropToFile(propertyName, propertyType, propertyValue, isOutputComment, outputComment);
                    isOutputComment = false;

                } //regex OUTPUT Ende


                // INTERNAL Fields aus XML File ---------------------------------------------------
               
                check = regex_match(xmlLine, match, regxINTERNAL);
                if (check) {


                    check = false;
                    check = regex_search(xmlLine, ex_matches, extractName);   // INTERNAL Field.Name
                    if (check) {

                        fieldName = ex_matches[1];
                        //cout << "name= " << fieldName << endl;

                    }
                    else
                    {
                        fieldName = "null";
                        //cout << "name= " << fieldName << endl;

                    }

                    check = false;
                    check = regex_search(xmlLine, ex_matches, extractType);   // INTERNAL Field.Type
                    if (check) {

                        fieldType = ex_matches[1];
                        //cout << "type= " << fieldType << endl;

                    }
                    else
                    {
                        fieldType = "null";
                        //cout << "type= " << fieldType << endl;

                    }

                    check = false;
                    check = regex_search(xmlLine, ex_matches, extractValue);   // INTERNAL Field.Value
                    if (check) {

                        fieldValue = ex_matches[1];
                        //cout << "value= " << fieldValue << endl;

                    }
                    else
                    {
                        fieldValue = "null";
                        //cout << "value= " << fieldValue << endl;

                    }


                    

                    CsharpWrite.writeFieldToFile(fieldName, fieldType, fieldValue, isFieldComment, fieldComment);
                    isFieldComment = false;
                } //regex INTERNAL Ende

                // CONSTANTS aus XML File ---------------------------------------------------

                check = regex_match(xmlLine, match, regxCONSTANT);
                if (check) {


                    
                    check = false;
                    check = regex_search(xmlLine, ex_matches, extractName);   // CONSTANT.Name
                    if (check) {

                        constantName = ex_matches[1];
                        //cout << "name= " << constantName << endl;

                    }
                    else
                    {
                        constantName = "null";
                        //cout << "name= " << constantName << endl;

                    }

                    check = false;
                    check = regex_search(xmlLine, ex_matches, extractType);   // CONSTANT.Type
                    if (check) {

                        constantType = ex_matches[1];
                        //cout << "type= " << constantType << endl;

                    }
                    else
                    {
                        constantType = "null";
                        //cout << "type= " << constantType << endl;

                    }

                    check = false;
                    check = regex_match(xmlLine, sub_match, regxCONSTANT_SubMatch);        // CONSTANT.Value
                    constantSubMatchString = sub_match.str(1);
                    vector<string> constantValues;
                    
                    if (check) {

                        int i = 0;
                        regex_iterator<string::iterator> iter_matches(constantSubMatchString.begin(), constantSubMatchString.end(), extractValueCONSTANTS);
                        regex_iterator<string::iterator> end;
                        while (iter_matches != end)
                        {
                            //cout << "Match: " << iter_matches->str() << "  Match-Length:  " << i << endl;
                            constantValues.push_back(iter_matches->str());
                           
                            ++iter_matches;
                            i++;
                        }


                        //constantValue = ex_matches[1];
                        //cout << "value= " << constantValue << endl;

                    }
                    else
                    {
                        constantValue = "null";
                        //cout << "value= " << constantValue << endl;

                    }




                    CsharpWrite.writeConstantToFile(constantName, constantType, constantValues, isConstantsComment, constantsComment);
                    isConstantsComment = false;
                } //regex CONSTANTS Ende

              
                


            } //while XML sourceFile getline Ende

            xmlSource.close();

            //Methoden aus XML File
            cout << "\nConverting Methods .... " << endl;

            xmlSource.open(xmlFilename);
            matchstring.clear();
            check = false;

            while (xmlSource.good()) {

                
                getline(xmlSource, xmlLine);
                checkMethodBegin = regex_match(xmlLine, matchMethodName, methodBegin);
                checkMethodEnd = regex_match(xmlLine, matchMethodEnd, methodEnd);


                if (checkMethodBegin)
                {
                    check = true;
                    //cout << matchName.str(1) << endl;
                    methodName = matchMethodName.str(1);
                    
                }
                if (check)
                {
                   //cout << "check OK" << endl;
                    
                    matchstring += xmlLine;
                    
                    //cout << matchstring << endl;
                }
                if (checkMethodEnd)
                {
                    //cout << "check: " << check << " Matchstring: " << matchstring << endl;
                    
                    Worker.MethodStringToCsharpCode( matchstring, methodName);
                    
                    matchstring.clear();
                    methodName = "";
                    check = false;
                }
                
            }




            CsharpWrite.csharpFilePrepare("end");
            xmlSource.close();
        }
        catch (const std::exception& e)
        {
            cerr << e.what() << "\n\nBefindet sich die XML PAP Datei im Verzeichnis?" << "\n\n\nEnter for End ...." << endl;
            xmlSource.close();
            while (cin.get() != '\n')
            {
                
            }
            return -1;
        }

        cout << "\nWork done!! - Filename: " << CsharpWrite.filename << "\n\n\nEnter for End ...." << endl;
        while (cin.get() != '\n')
        {

        }
        return 0;
    }



