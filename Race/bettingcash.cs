namespace RacetrackSimulator
{
    public class bettingcash
    {
        public betters amount;
        public int cash;
        public int car;
        

       
        public string casbetmoney(betters bets)
        {
            amount = bets;
            if (cash > 0)
            {
                return $@"{amount.name} places a bet ${cash} on Racer {car}";
            }
            return $@"{amount.name} neet to place a bet yet";
        }

        public int cashbet(int carfirst)
        {
            if (car == carfirst)
            {
                return cash;
            }
            return cash * -1;
        }
    }
}