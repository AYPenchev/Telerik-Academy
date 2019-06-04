namespace Task1
{
    using System;

    class GSMCallHistoryTest
    {
        public void GSMCallHistoryTesting()
        {
            GSM testGsm = new GSM("Nokia", "Telerik");

            testGsm.AddCall("+359873432142", 53);
            testGsm.AddCall("+359811432142", 123);
            testGsm.AddCall("+359872412142", 41);
            testGsm.AddCall("+359833332142", 72);
            testGsm.AddCall("+359614432142", 231);

            testGsm.ShowCallHistory();

            Console.WriteLine("Total call price: " + testGsm.TotalCallPrice());

            testGsm.DeleteCall(5);
            Console.WriteLine("Removed Longest call!");

            Console.WriteLine("Total call price: " + testGsm.TotalCallPrice());

            testGsm.ClearCallHistory();
            Console.WriteLine("Cleared call history!");

            testGsm.ShowCallHistory();
        }
    }
}
