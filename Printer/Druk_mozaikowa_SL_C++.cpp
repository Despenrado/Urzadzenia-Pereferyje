// Druk_mozaikowa_SL_C++.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <fstream>
#include <string>
#include <Windows.h>
#include <vector>
#include <math.h>


using namespace std;

char esc = 27;

vector<char> m;

void printerDefault(fstream &fStream) {
	fStream << esc << "h" << (char)0;
	fStream << esc << "l" << (char)0;
}

void printer(fstream &fStream) {
	fStream << esc << "x1" << "---------------------------------------------------------------" << endl;
	cout << "quality test" << endl;
	fStream << esc << "x0" << "Draft text" << endl;
	fStream << esc << "x1" << "Letter text" << endl;

	fStream << esc << "x1" << "---------------------------------------------------------------" << endl;
	cout << "font test" << endl;
	fStream << esc << "k0" << esc << "x1" << "Roman Font" << endl;
	fStream << esc << "k1" << esc << "x1" << "Sanserif Font" << endl;
	fStream << esc << "k2" << esc << "x1" << "Courier Font" << endl;
	fStream << esc << "k3" << esc << "x1" << "Prestige Font" << endl;
	fStream << esc << "k4" << esc << "x1" << "Script Font" << endl;

	fStream << esc << "x1" << "---------------------------------------------------------------" << endl;
	cout << "line spacing test" << endl;
	fStream << esc << "0" << esc << "k0" << esc << "x1" << "1/8 inch line space" << endl;
	fStream << esc << "1" << esc << "k0" << esc << "x1" << "7/60 inch line space" << endl;
	fStream << esc << "2" << esc << "k0" << esc << "x1" << "1/6 inch line space" << endl;
	fStream << esc << "3" << (char)5 << esc << "k0" << esc << "x1" << "5/360 inch line space" << endl;

	fStream << esc << "x1" << "---------------------------------------------------------------" << endl;
	cout << "horizontal left test" << endl;
	fStream << esc << "l" << (char)76 << esc << "k0" << esc << "x1" << "Pica left space" << endl;
	fStream << esc << "l" << (char)91 << "k0" << esc << "x1" << "Elite line space" << endl;
	fStream << esc << "l" << (char)114 << "k0" << esc << "x1" << "Semi-condensed line space" << endl;

	fStream << esc << "x1" << "---------------------------------------------------------------" << endl;
	cout << "horizontal right test" << endl;
	fStream << esc << "Q" << (char)80 << esc << "k0" << esc << "x1" << "Pica left space" << endl;
	fStream << esc << "Q" << (char)96 << "k0" << esc << "x1" << "Elite line space" << endl;
	fStream << esc << "Q" << (char)120 << "k0" << esc << "x1" << "Semi-condensed line space" << endl;
}

void printImage(fstream &fStream) {

			fStream << esc << 'K' << (char)m.size() << (char)0;
			for (int i2 = 0; i2 < m.size(); i2++)
			{
				fStream << (char)m[i2];
				//cout << m[i2];
			}
			//cout << endl;
			fStream << endl;

}

void loadFile() {
	m.clear();
	ifstream fin;
	fin.open("grafika_printer.txt");
	if (fin.is_open())
	{
		int i = 0;
		while (!fin.eof()) {
			string s = "";
			fin >> s;
			for (int i2 = 0; i2 < s.length(); i2++) {
			m.push_back(0);
				if (s.at(i2) == 'o') {
					m[i2] += 2^i;
				}
			}
			i++;
		}
	}
	else
	{
		cout << "file error" << endl;
	}
}

int main()
{
	fstream f;
	string s = "lpt3";
	do {
		cout << "port name:\n$ ";
		//cin >> s;
		f.open(s, ios::out);
	} while (!f.is_open());
	cout << "PORT IS OPEN" << endl;
	//printerDefault(f);
	f << "---------------------------------------------------------------" << endl;
	//printer(f);
	loadFile();
	printImage(f);
	if (f.is_open()) {
		f.clear();
		f.close();
	}
	cin >> s;
	return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
