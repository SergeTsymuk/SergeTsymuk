using Interface6;

ConcretClass cC = new ConcretClass();
var cC1 = cC as IInterface1;
cC1.Method();
var cC2 = cC as IInterface2;
cC2.Method();

IInterface1 interface1 = new ConcretClass();
interface1.Method();

IInterface2 interface2 = new ConcretClass();
interface2.Method();