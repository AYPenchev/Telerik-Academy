namespace Task1
{
    using System;

    class DefiningClasesPart1
    {
        static void Main()
        {
            GSMTest firstTest = new GSMTest();
            firstTest.TestingGSM();

            GSMCallHistoryTest callHistory = new GSMCallHistoryTest();
            callHistory.GSMCallHistoryTesting();
        }
    }
}
