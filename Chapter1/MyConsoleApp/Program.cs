// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
byte num1 = 8; // byte here represent unsigned byte and it represnts 8 bytes _ _ _ _ _ _ _
sbyte num2 = -8; // here sbyte respersnt singned numbers with 8 bytes,
                 // if the MSB is 1 that means the number is nigative and vise vers
Console.WriteLine("Byte min: {0} Byte max: {1}",byte.MinValue,byte.MaxValue);
                                                //00000000 ->0   11111111 -> 255
Console.WriteLine("SByte min: {0} SByte max: {1}", sbyte.MinValue, sbyte.MaxValue);
//10000000 ->-128   01111111 -> 127
var BinNumber = new String[] {
        "00000000",//0
        "00001011", //Byte = 11, SByte = 11
        "10000000", //Byte = 128, SByte = -128
        "10000001", //Byte = 129, SByte = -127
        "10001111", //Byte = 128+15, SByte = -128+15
};
foreach (var item in BinNumber)
{
    byte number = Convert.ToByte(item,2);
    sbyte Snumber = Convert.ToSByte(item, 2);
    Console.WriteLine(item + " Byte:" + number+"-- SByte: "+Snumber);
}
Console.WriteLine(new String('=', 50));
Console.WriteLine();
Int16[] arr=new Int16[10];
Console.WriteLine("Max value 16 bit: {0} -- Min Value 16 bit: {1}",Int16.MaxValue,Int16.MinValue);//Singed numbers
Console.WriteLine("Max value Unsigned 16 bit: {0} -- Min Value Unsinged 16 bit: {1}", UInt16.MaxValue, UInt16.MinValue);//Usinged numbers
Console.WriteLine("Max value 32 bit: {0} -- Min Value 32 bit: {1}", Int32.MaxValue, Int32.MinValue);
Console.WriteLine("Max value 64 bit: {0} -- Min Value 64 bit: {1}", Int64.MaxValue, Int64.MinValue);
Console.ReadLine();