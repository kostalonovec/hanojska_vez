/*

menší tahák
Stack<string> numbers = new Stack<string>();
numbers.Push("one");
var x = numbers.Pop();
var x = numbers.Peek();
numbers.Clear();
bool c = numbers.Contains("one");
foreach( string number in numbers )
{
   Console.WriteLine(number);
}*/


namespace hanojska_vez{
class VezHanoi
{
   
   private Stack<int> _a;
   private Stack<int> _b;
   private Stack<int> _c;

   
   //můžeme udělat bezparametrický konstruktor, ale i normální
   public VezHanoi()
   {
      _a = new Stack<int>();
      _b = new Stack<int>();
      _c = new Stack<int>();
   }

   public void Vyres(int n)
   {
      for (int i = n; i > 0; i--)
      {
         _a.Push(i);
      }

      MoveDiscs(n, _a, _c, _b);
   }

   private void MoveDiscs(int n, Stack<int> a, Stack<int> c, Stack<int> b)
   {
      if (n > 0)
      {
         if (n % 2 == 0)
         {
            MoveDiscs(n - 1, a, b, c);
            MoveTopDisc(a, b);
            MoveDiscs(n - 1, b, c, a);
         }
         else
         {
            MoveDiscs(n - 1, a, c, b);
            MoveTopDisc(a, c);
            MoveDiscs(n - 1, c, b, a);
         }
      }
   }

   private void MoveTopDisc(Stack<int> a, Stack<int> c)
   {
      if(a.Count > 0){
         int disc = a.Pop();
         if (c.Count == 0 || c.Peek() > disc)
         {
            c.Push(disc);
         }
         else
         {
            Console.WriteLine("Nemůžeš dávat větší disk na menší");
         }
      }
   }

   
} }