using Delegates_Ivents;

Stock stock = new Stock();
Bank bank = new Bank("TD Bank", stock);
Broker broker = new Broker("Stepan Petrov", stock);
// имитация торгов
stock.Market();
// брокер прекращает наблюдать за торгами
broker.StopTrade();
// имитация торгов
stock.Market();

Console.Read();