

using MediatorDesignPattern;

var callCenter = new CabCallCenter();
var Passenger1 = new Passenger("Passenger 1" ," 123 street", 10);
var Passenger2 = new Passenger("Passenger 2", " 456 street", 10);

var cab1 = new Cab("Cab1", 11, true);
var cab2 =new Cab("Cab2",22, false);

callCenter.Register(cab1);
callCenter.Register(cab2);

callCenter.BookCab(Passenger1);
callCenter.BookCab(Passenger2);

Console.ReadLine();
