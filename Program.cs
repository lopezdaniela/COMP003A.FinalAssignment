/*
* Author: Daniela Lopez
* Course: COMP003A
* Purpose: code for final client intake form  
*/




using System.Text.RegularExpressions;
namespace COMP003A.Assignment1
{
  class Program
  {
      static void Main(string[] args)
      {
          Console.WriteLine("".PadRight(18, '-'));
          Console.WriteLine("Client Intake Form");
          Console.WriteLine("".PadRight(18, '-'));




          string first;
          do
          {
              Console.WriteLine("\nWhat is your first name: ");
              first = Console.ReadLine();
          if(!IsValidName(first))
          {
                  Console.WriteLine("Invalid Name");
          }
          }
          while(!IsValidName(first));
        


          string last ;
          do
          {
              Console.WriteLine ("\nWhat is your last name: ");
              last = Console.ReadLine ();
        
          if (!IsValidName(last))
          {
              Console.WriteLine ("Invalid Name");
          }
          }
          while (!IsValidName(last));




          string year ;
          do
          {
              Console.WriteLine ("\nWhat year were you born: ");
              year = Console.ReadLine ();
        
          if (!ValidYear(year))
          {
              Console.WriteLine ("Invalid Year");
          }
          }
          while (!ValidYear(year));
          int yearBorn = 2023 - Convert.ToInt32(year);


          try
          {
           int number = Int32.Parse(year);
          }
          catch (FormatException)
          {
           Console.WriteLine ("Error: not in year format");
          }


          string gender ;
          do
          {
              Console.WriteLine ("\nGender: (M), (F), or (O) ");
              gender = Console.ReadLine ();
        
          if (!ValidGender(gender))
          {
              Console.WriteLine ("Invalid Input");
          }
          }
          while (!ValidGender(gender));






          string address ;
          do
          {
              Console.WriteLine ("\nPrimary Address:");
              address = Console.ReadLine ();
        
          if (!IsValidCharacter(address))
          {
              Console.WriteLine ("Invalid Input");
          }
          }
          while (!IsValidCharacter(address));








          string city ;
          do
          {
              Console.WriteLine ("\nCity: ");
              city = Console.ReadLine ();
        
          if (!IsValidName(city))
          {
              Console.WriteLine ("Invalid Input");
          }
          }
          while (!IsValidName(city));








          string state ;
          do
          {
              Console.WriteLine ("\nState: ");
              state = Console.ReadLine ();
        
          if (!IsValidName(state))
          {
              Console.WriteLine ("Invalid Input");
          }
          }
          while (!IsValidName(state));








          string zip ;
          do
          {
              Console.WriteLine ("\nZip: ");
              zip = Console.ReadLine ();
        
          if (!IsValidZip(zip))
          {
              Console.WriteLine ("Invalid Input");
          }
          }
          while (!IsValidZip(zip));








          string cell ;
          do
          {
              Console.WriteLine ("\nCell Phone Number: ");
              cell = Console.ReadLine ();
        
          if (!IsValidPhone(cell))
          {
              Console.WriteLine ("Invalid Input");
          }
          }
          while (!IsValidPhone(cell));








          string occupation ;
          do
          {
              Console.WriteLine ("\nOccupation: ");
              occupation = Console.ReadLine ();
        
          if (!IsValidCharacter(occupation))
          {
              Console.WriteLine ("Invalid Input");
          }
          }
          while (!IsValidCharacter(occupation));








          string education ;
          do
          {
              Console.WriteLine ("\nEducation/Degree(s) Obtained: ");
              education = Console.ReadLine ();
        
          if (!IsValidCharacter(education))
          {
              Console.WriteLine ("Invalid Input");
          }
          }
          while (!IsValidCharacter(education));






          string emergency ;
          do
          {
              Console.WriteLine ("\nName of person to contact in an emergency: ");
              emergency = Console.ReadLine ();
        
          if (!IsValidName(emergency))
          {
              Console.WriteLine ("Invalid Input");
          }
          }
          while (!IsValidName(emergency));








          string relationship ;
          do
          {
              Console.WriteLine ("\nRelationship:");
              relationship = Console.ReadLine ();
        
          if (!IsValidName(relationship))
          {
              Console.WriteLine ("Invalid Input");
          }
          }
          while (!IsValidName(relationship));








          string contact ;
          do
          {
              Console.WriteLine ("\nContact Phone Number:");
              contact = Console.ReadLine ();
        
          if (!IsValidPhone(contact))
          {
              Console.WriteLine ("Invalid Input");
          }
          }
          while (!IsValidPhone(contact));
        




         List<String> responses = new List<String>();
         responses.Add("\nPrimary Adress:");
         responses.Add(address);
         responses.Add("\nCity: ");
         responses.Add(city);
         responses.Add("\nState: ");
         responses.Add(state);
         responses.Add("\nZip: ");
         responses.Add(zip);
         responses.Add("\nCell Phone Number: ");
         responses.Add(cell);
         responses.Add("\nOccupation: ");
         responses.Add(occupation);
         responses.Add("\nEducation/Degree(s) Obtained: ");
         responses.Add(education);
         responses.Add("\nName of person to contact in an emergency: ");
         responses.Add(emergency);
         responses.Add("\nRelationship:");
         responses.Add(relationship);
         responses.Add("\nContact Phone Number:");
         responses.Add(contact);




          Console.WriteLine("".PadRight(7, '-'));
          Console.WriteLine("Review");
          Console.WriteLine("".PadRight(7, '-'));




          Console.WriteLine($"Hello {first} {last}!");
          Console.WriteLine($"You are {yearBorn} years old.");
          Console.WriteLine($"You identify as {gender}");
          TraverseList (responses);




      }


       /// <summary> Validation Methods </summary>
       /// <param name="first"> alphabetic input </param>
       /// <returns></returns>
      static bool IsValidName(string first)
      {
          string pattern = @"[a-zA-Z]+";
          if (Regex.IsMatch(first, pattern))
          {
              return true;
          }
          else
          {
              return false;
          }
      }




       /// <summary> validating user input for any year input </summary>
       /// <param name="year"> string year input </param>
       /// <returns></returns>
      static bool ValidYear(string year)
      {
          string pattern = @"19[0-9]{2}|20[01][0-9]|202[0-3]";
          if (Regex.IsMatch(year, pattern))
          {
              return true;
          }
          else
          {
              return false;
          }
      }




       /// <summary> validating user input for gender </summary>
       /// <param name="gender"> string gender input </param>
       /// <returns></returns>
      static bool ValidGender(string gender)
      {
          string pattern = @"(?:m|M|F|f|o|O)$";
          if (Regex.IsMatch(gender, pattern))
          {
              return true;
          }
          else
          {
              return false;
          }
      }




       /// <summary> validating user input for any number sequence </summary>
       /// <param name="zip"> number input </param>
       /// <returns></returns>
      static bool IsValidZip(string zip)
      {
          string pattern = @"[0-9]";
          if (Regex.IsMatch(zip, pattern))
          {
              return true;
          }
          else
          {
              return false;
          }
      }




       /// <summary> validating user input for any input containing a combination of numbers and letters </summary>
       /// <param name="education"> character input </param>
       /// <returns></returns>
      static bool IsValidCharacter(string education)
      {
          string pattern = @"[a-zA-Z,0-9]";
          if (Regex.IsMatch(education, pattern))
          {
              return true;
          }
          else
          {
              return false;
          }
      }




       /// <summary> validating user input for any phone number sequence </summary>
       /// <param name="contact"> phone number input </param>
       /// <returns></returns>
      static bool IsValidPhone(string contact)
      {
          string pattern = @"[0-9,-]";
          if (Regex.IsMatch(contact, pattern))
          {
              return true;
          }
          else
          {
              return false;
          }
      }




       /// <summary> list traversal using a foreach loop </summary>
       /// <param name="list"> questions and user input list </param>
       /// <returns></returns>
   static void TraverseList (List<string>list)
   {
       foreach (string item in list)
       {
       Console.WriteLine (item);
       }
   }
}
}






