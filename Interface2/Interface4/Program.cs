using Interface4;

var dC = new DerivedClass();
dC.Method();
dC.Method1();
dC.Method2();

var bC = new BaseClass();
bC.Method();

IInterface1 dC1 = dC as IInterface1;
dC1.Method1();

IInterface2 dc2 = dC as IInterface2;
dc2.Method2();

