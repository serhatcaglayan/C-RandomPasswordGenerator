using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPasswordGenerator
{
    
    class RandomPasswordGenerator
    {
        private const string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string smallLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string digit = "0123456789";
        private const string specialChars = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";
        private const string allChars = capitalLetters + smallLetters + digit + specialChars;

        public static ArrayList arrayList = new ArrayList();
        public static Random random = new Random();
       

         private static string RandomPassword = "";

        public static string RandomPassword1 { get => RandomPassword; set => RandomPassword = value; }




        // 2 metod oluştur , karekter seç , pozisyona ata 

        private static void selectCharRandomly(string selectCharType, int numberOfChar)
        {



            if (selectCharType.Equals(allChars))
            {
                for (int i = 0; i < numberOfChar; i++)
                {


                    arrayList.Add(selectCharType[(random.Next(selectCharType.Length))]);
                }
                
            }
            else if (selectCharType.Equals(capitalLetters))
            {
                for (int i = 0; i < numberOfChar; i++)
                {


                    arrayList.Add(selectCharType[(random.Next(selectCharType.Length))]);
                }

            }
            else if (selectCharType.Equals(smallLetters))
            {
                for (int i = 0; i < numberOfChar; i++)
                {


                    arrayList.Add(selectCharType[(random.Next(selectCharType.Length))]);
                }

            }
            else if (selectCharType.Equals(digit))
            {
                for (int i = 0; i < numberOfChar; i++)
                {


                    arrayList.Add(selectCharType[(random.Next(selectCharType.Length))]);
                }

            }
            else if (selectCharType.Equals(specialChars))
            {
                for (int i = 0; i < numberOfChar; i++)
                {


                    arrayList.Add(selectCharType[(random.Next(selectCharType.Length))]);
                }

            }



        }

        public static void mixArray(ArrayList array)
        {
            Random random = new Random();
            int n = array.Count;

            for (int i = n - 1; i > 0; i--)
            {
                int r = random.Next(i + 1);

                // Elemanların indekslerini değiştirme
                object temp = array[i];
                array[i] = array[r];
                array[r] = temp;
            }
        }

        public static void assignChar()
        {
         
            StringBuilder strbuild = new StringBuilder(RandomPassword1);

            mixArray(arrayList);
            
            for (int i = 0; i < arrayList.Count; i++)
            {
                strbuild.Append(arrayList[i]);

            }
            RandomPassword1 = strbuild.ToString();

         
        }



        static void Main(string[] args)
        {

            // selectCharRandomly(allChars, 15);
            selectCharRandomly(smallLetters,3);
            selectCharRandomly(capitalLetters, 2);
            selectCharRandomly(specialChars, 5);
            selectCharRandomly(digit,4);
            assignChar();

            Console.WriteLine("PASSWORD  : " + RandomPassword1  );

           
            Console.ReadKey();
         }
    }
    
  





}
            
             

    



