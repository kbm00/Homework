using HashTable;

namespace HashTable
{
    public class CheatKey
    {
        Action showmethemoney;
        Action thereisnocowlevel;
        public CheatKey()
        {
            showmethemoney += ShowMeTheMoney;
            thereisnocowlevel += ThereIsNoCowLevel;
            cheatDic = new Dictionary<string, Action>(2);
            cheatDic.Add("SHOWMETHTMONEY", showmethemoney);
            cheatDic.Add("THEREISNOCOWLEVEL", thereisnocowlevel);
        }

        private Dictionary<string, Action> cheatDic;

        public void Run(string cheatKey)
        {
            cheatDic.TryGetValue(cheatKey, out Action Value);
            Value();
        }

        public void ShowMeTheMoney()
        {
            Console.WriteLine("골드를 늘려주는 치트키 발동");
        }

        public void ThereIsNoCowLevel()
        {
            Console.WriteLine("바로 승리하는 치트키 발동");
        }
         
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            CheatKey cheatkey = new CheatKey();
            while (true)
            {
                string keyinput = Console.ReadLine();
                cheatkey.Run(keyinput);
            }
        }
    }
}


