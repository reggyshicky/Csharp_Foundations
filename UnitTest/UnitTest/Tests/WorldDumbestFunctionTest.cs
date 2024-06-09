namespace UnitTest.Tests
{
    public static class WorldDumbestFunctionTest
    {
        //Naming Convention - ClassName_MethodName_ExpectedResult
        public static void WorldDumbestFunction_ReturnsPikachuIfzero_ReturnString()
        {
            try
            {
                //Arrange - Go get your variables, whatever you need, your classes, go get your functions
                int num = 0;
                WorldDumbestFunction w = new WorldDumbestFunction();

                //Act - - Execute this function
                string result = w.ReturnsPikachuIfzero(num);


                //Assert -whatever is returned is it what you want
                if (result == "PIKACHU!")
                {
                    Console.WriteLine("PASSED: WorldDumbestFunction.ReturnsPikachuIfzero_ReturnsString");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
