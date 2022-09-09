using Interface5;

var cC = new ConcretClass();
var cC1 = cC as IInterface1;
cC1.Method1();
var cC2 = cC as IInterface2;
cC2.Method2();

IInterface1 interface1 = new ConcretClass();
IInterface2 interface2 = new ConcretClass();