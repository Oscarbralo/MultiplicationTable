// TCTemplate.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <vector>
#include <iostream>
#include <sstream>

using namespace std;

class MultiplicationTable {
public:
	vector<string> generateTable(int number) {
		vector<string> table (number, "");
		int nn = number * number;
		stringstream ss;
		ss << nn;
		int spaces = ss.str().length() + 1;
		for(int i = 0; i < number; i++)
		{
			for(int j = 0; j < number; j++)
			{
				int temp = ((i + 1) * (j + 1));
				stringstream sTemp;
				sTemp << temp;
				table[i] += sTemp.str();
				for (int a = 0; a < spaces - sTemp.str().length(); a++)
                        table[i] += " ";
			}
		}
		return table;
	}
};

int main()
{
	MultiplicationTable x;
	int input = 0;
	cout << "Give me a number to generate the table" << endl;
	cin >> input;
	vector<string> v = x.generateTable(input);
	for (int i = 0; i < v.size(); i++)
		cout << v[i] << endl;
	return 0;
}

