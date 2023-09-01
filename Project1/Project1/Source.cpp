#include <windows.h> //чтобы работать с графикой
#include < conio.h >
#include <iostream>  //библиотека ввода вывода
using namespace std;
int main() {
	double k = 0.1;
	int M = 3;
	int J = 1;
	double F;
	double W;
	HWND myconsole = GetConsoleWindow(); //HWND - класс окна консоли   myconsole - имя переменной   GetConsoleWindow() - извлекает маркер окна, используемый консолью, связанной с вызывающим процессом

	HDC mydc = GetDC(myconsole); //HDC - обработчик контекста устройства, использующийся для рисования в клиентской области окна  mydc - имя переменной  GetDC() - возвращает контекст устройства окна
	
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
	_getch(); //возвращает значение переменной (изображение после напечатывания не закроется)

	ReleaseDC(myconsole, mydc);
	return 0;
}