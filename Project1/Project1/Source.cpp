#include <windows.h> //����� �������� � ��������
#include < conio.h >
#include <iostream>  //���������� ����� ������
using namespace std;
int main() {
	double k = 0.1;
	int M = 3;
	int J = 1;
	double F;
	double W;
	HWND myconsole = GetConsoleWindow(); //HWND - ����� ���� �������   myconsole - ��� ����������   GetConsoleWindow() - ��������� ������ ����, ������������ ��������, ��������� � ���������� ���������

	HDC mydc = GetDC(myconsole); //HDC - ���������� ��������� ����������, �������������� ��� ��������� � ���������� ������� ����  mydc - ��� ����������  GetDC() - ���������� �������� ���������� ����
	
	COLORREF COLOR1 = RGB(255, 0, 0);
	COLORREF COLOR2 = RGB(0, 255, 0);
	for (int t = 0; t <=1000; t++) {
		if (t * k < M) {
			F = 0;
			W = 0;
		}
		else {
			F = ((k * t - M) * t * t) / (J * 2);
			W = F / t;
		}
		for (int x = 500; x <= 1000; x++) {
			SetPixel(mydc, t, F, COLOR1);
			SetPixel(mydc, t, W, COLOR2);
		}
	}
	_getch(); //���������� �������� ���������� (����������� ����� ������������� �� ���������)

	ReleaseDC(myconsole, mydc);
	return 0;
}