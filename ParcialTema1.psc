Algoritmo ParcialCilindro
	
	Definir radio, altura, area, base, volumen Como Real;
	Definir CantidadCilindros Como Entero;
	
	CantidadCilindros <- 0;
	
	Escribir Sin Saltar "Ingrese el radio del cilindro:";
	leer radio;
	
	Escribir Sin Saltar "Ingrese la altura del cilindro:";
	Leer altura;
	
	Mientras radio <> 0 y altura <> 0
		base <- 3.1416*radio^2;
		area <- 2*3.1416*radio*(altura+radio);
		volumen <- base*altura;
		
		Escribir Sin Saltar "Area: ", area;
		
		Escribir "Volumen: ", volumen;
		
		CantidadCilindros <- CantidadCilindros+1;
		
		Escribir Sin Saltar "Ingrese el radio del siguiente cilindro: ";
		Leer radio;
		
		Escribir Sin Saltar "Ingrese la altura del siguiente cilindro: ";
		Leer altura;
		
	FinMientras
	
	Escribir Sin Saltar "Se ingresaron ", CantidadCilindros, " cilindros: ";
	
FinAlgoritmo
