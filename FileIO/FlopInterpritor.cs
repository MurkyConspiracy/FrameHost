﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FileIO
{
    public class FlopInterpritor
    {
        
        private string AllText;
        private string FlopPath;

        public FlopInterpritor(string flopPath, string flopName)
        {

            FlopPath = flopPath + flopName + ".FLOP";
            Byte[] byteString;
            using (StreamReader file = File.OpenText(FlopPath))
            {
                string s = file.ReadToEnd();
                byteString = Encoding.UTF8.GetBytes(s);
                for (int i = 0; i < byteString.Length; i++)
                {

                    byteString[i] ^= 25;

                }

            }
            AllText = Encoding.UTF8.GetString(byteString);

        }

        public FlopInterpritor(string flopPath)
        {

            FlopPath = flopPath;
            Byte[] byteString;
            using (StreamReader file = File.OpenText(FlopPath))
            {
                string s = file.ReadToEnd();
                byteString = Encoding.UTF8.GetBytes(s);
                for (int i = 0; i < byteString.Length; i++)
                {

                    byteString[i] ^= 25;

                }

            }
            AllText = Encoding.UTF8.GetString(byteString);

        }

        public string ReadText()
        {
            return AllText;
        }

        public string FindValue(string key)
        {

            string ValueText, InternalValue;
            int numLength;

            if(AllText.Contains(key))
            {

                ValueText = AllText.Substring(AllText.IndexOf(key));
                numLength = ValueText.IndexOf("-s0");
                InternalValue = ValueText.Substring(key.Length + 1, numLength - key.Length-1);
                return InternalValue;

            }
            throw new NullReferenceException("This value does not exist in the current context\n" + FlopPath);
            

        }

        public static void CreateFlop(string newFlopPath, string fileName)
        {

            string fileToCreate = newFlopPath + "\\" + fileName + ".FLOP";
            File.Create(fileToCreate, 1).Close();

        }

        public static void CreateFlop(string newFlopPath, string fileName, string key, string value)
        {

            string fileToCreate = newFlopPath + "\\" + fileName + ".FLOP";
            File.Create(fileToCreate, 1).Close();

            using (StreamWriter sw = new StreamWriter(fileToCreate))
            {

                sw.WriteLine(key + "=" + value + "-s0");

            }

            Byte[] byteString;
            using (StreamReader file = File.OpenText(fileToCreate))
            {
                string s = file.ReadToEnd();
                byteString = Encoding.UTF8.GetBytes(s);
                for (int i = 0; i < byteString.Length; i++)
                {

                    byteString[i] ^= 25;

                }

            }

            File.WriteAllBytes(fileToCreate, byteString);

        }

        public void WriteToFlop(string newKey, string value)
        {

            AllText += newKey + "=" + value + "-s0\n";

            FlopXORSave();

        }

        public void ChangeValue(string key, string newValue)
        {

            string ValueText, OldValueText, Value;
            int numPlaceholder;

            if(AllText.Contains(key))
            {

                ValueText = AllText.Substring(AllText.IndexOf(key));
                ValueText = ValueText.Substring(0, ValueText.Length - 5);
                OldValueText = ValueText;

                numPlaceholder = ValueText.IndexOf('=') + 1;
                Value = ValueText.Substring(numPlaceholder);
                ValueText = ValueText.Replace(Value, newValue);
                AllText = AllText.Replace(OldValueText, ValueText);

            }

            FlopXORSave();

        }

        private void FlopXORSave()
        {

            Byte[] byteString;
            using (StreamReader file = File.OpenText(FlopPath))
            {
                string s = file.ReadToEnd();
                byteString = Encoding.UTF8.GetBytes(AllText);
                for (int i = 0; i < byteString.Length; i++)
                {

                    byteString[i] ^= 25;

                }

            }

            File.WriteAllBytes(FlopPath, byteString);

        }

        public string[,] GetAllValues()
        {

            string valueText, keyText, workingText, capturedText;
            int buffer;
            List<string> Values, Keys;
            string[,] ValuesMatrix;

            Values = new List<string>();
            Keys = new List<string>();
            workingText = AllText;

            while(workingText.Length > 0)
            {

                buffer = workingText.IndexOf("-s0");
                capturedText = workingText.Substring(0, buffer - 1);
                keyText = capturedText.Substring(0, capturedText.IndexOf('='));
                valueText = capturedText.Substring(capturedText.IndexOf('='), capturedText.Length-1);
                Values.Add(valueText);
                Keys.Add(keyText);
                capturedText = capturedText.Substring(buffer+3, capturedText.Length);

            }

            ValuesMatrix = new string[Values.Capacity, Keys.Capacity];
            for(int i = 0; i < Values.Capacity; i++)
            {

                ValuesMatrix[i, 0] = Values[i];

            }
            for(int i = 0; i < Keys.Capacity; i++)
            {

                ValuesMatrix[0, i] = Keys[i];

            }

            return ValuesMatrix;

        }

    }

}