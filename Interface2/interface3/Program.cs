
using Interface3;

var instance = new DerivedClass();

var interface1 = instance as IInterface1;
interface1.Method();
var interface2 = instance as IInterface2;
interface2.Method();