// See https://aka.ms/new-console-template for more information
public class Calculadora{

private Calculo c;

public void setCalculo(Calculo c){
  this.c = c;
}

public void fazerCalculo(int a,int b){
  c.calcular(a,b);
}
}

public class Azul : Calculadora {}

public interface Calculo{

public abstract void calcular(int a, int b);
}

public class Somar{

public void calcular(int a,b){
  return a + b;
}
}

public class Subtrair{

public void calcular(int a,b){
  return a - b;
}
}

PSVM{
 Calculadora cal = Azul();

 Calculo c = new Somar();

 cal.setCalculo(c);

 c.fazerCalculo(2,2);
 
 c = new Subtrair();
  c.fazerCalculo(2,2);
}