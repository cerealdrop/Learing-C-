#include<iostream>
#include<fstream>
using namespace std;

class Encription {

	fstream file1;
	fstream file2;

public:
	Encription::Encription(char*filename1, char*filename2)
	{
		file1.open(filename1, ios::in | ios::out| ios::binary);
		file2.open(filename1, ios::out|ios::binary);

	}

	//Encript the file
	void Encrypt(void)
	{
		char currentByte;
		bool currentBit;

		int index = 0;
		file1.seekg(0, ios::beg);
		file2.seekp(0, ios::beg);

		file1.read(&currentByte, 1);
		while (file1.good())
		{
			for (int c = 0; c < 4;c++) 
			{
				currentBit = (int)((unsigned char)currentByte / 128);
				currentByte <<= 1;

				if (currentBit)
				{
					currentByte += 1;
				}

			}

			file2.write(&currentByte, 1);
			file1.seekg(++index);
			file2.seekp(index);

			file1.read(&currentByte, 1);

		}

	}
	void close(void)
	{
		file1.close();
		file2.close();
	}

};
int main()
{
	cout << "This is an encription program" <<endl;
	Encription dome("race.txt","output.txt");
	dome.Encrypt();
	dome.close();

	Encription tome("output.txt", "output2.txt");
	tome.Encrypt();
	tome.close();

	return 0;
}

