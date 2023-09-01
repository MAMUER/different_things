#include <windows.h> 
#include < conio.h >
#include <iostream>  
using namespace std;
int main() {
	double k = (double)1/10;
	int M = 3;
	int J = 1;
	double F;
	double W;
	HWND myconsole = GetConsoleWindow(); 
	HDC mydc = GetDC(myconsole); 
	COLORREF COLOR1 = RGB(255, 0, 255);
	COLORREF COLOR2 = RGB(0, 255, 0);
	COLORREF COLOR3 = RGB(255, 255, 255);
	for (int t = 0; t <= 1000; t++) {
		if (t * k < M) {
			F = 0;
			W = 0;
		}
		else {			
			W = (k * t - M) * t / J;
			F = (W * t) / 2;
		}
		SetPixel(mydc, t+400, -F + 400, COLOR1);
		SetPixel(mydc, t+400, -W + 400, COLOR2);
		SetPixel(mydc, t, 400, COLOR3);
		SetPixel(mydc, 400, t, COLOR3);
	}
	_getch(); 
	ReleaseDC(myconsole, mydc);
	return 0;
}
