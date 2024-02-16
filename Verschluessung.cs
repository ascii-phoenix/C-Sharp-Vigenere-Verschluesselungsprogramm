using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace vigenère_verschlüsselungO
{


    public class Verschluessung
    {
        public Verschluessung ()
        {
            alphabetToNummbre = Enumerable.Range('a', 26).Select(asciCode => (char)asciCode).ToArray();
        }
    public string key
        {
            set
            {
                this.inputKeyInt = this.stringToNumberList(value);
                if (_clearText != "")
                    clearText = _clearText;
                else if (_codedText != "")
                    codedText = _codedText;
            }
        }
        public string clearText
        {
            get
            {
                return _clearText;
            }
            set
            {
                _clearText = value;
                _codedText = encrypt();
            }
        }
        private string _clearText = "";
        public string codedText
        {
            get
            {
                return _codedText;
            }
            set
            {
                _codedText = value;
                _clearText = decrypt();
            }
        }

        private string _codedText = "";

        private List<int> inputKeyInt;
        protected char[] alphabetToNummbre;
        private List<int> stringToNumberList(string inputString)
        {
            char[] inputList = (this.StringChar(inputString));
            List<int> modifiedList = new List<int>();

            for (int i = 0; i < inputList.Length; i++)
            {
                int I = alphabetToNummbre.Length;
                while (inputList[i] != alphabetToNummbre[--I])
                {
                    if (I == 0)
                        break;
                }
                modifiedList.Add(I);
            }

            return modifiedList;
        }
        protected virtual char[] StringChar(string inputstring)
        {
            char[] modifiedArray = new char[inputstring.Length];
            for (int i = 0; i < inputstring.Length; i++)
            {
                if (inputstring[i] != ' ')
                {
                    modifiedArray[i] = inputstring.ToLower()[i];

                    if (inputstring[i] > 128)
                    {
                        modifiedArray[i] = 'a';
                    }
                }
            }
            return modifiedArray;
        }


        private string encrypt()
        {
            return crypting(1, _clearText);
        }
        private string decrypt()
        {
            return crypting(-1, _codedText);
        }
        private string crypting(int sign, string transformString)
        {
            if ((inputKeyInt == null) || (inputKeyInt.Count == 0) || (transformString == ""))
            {
                return "";
            }

            List<int> transformCode = stringToNumberList(transformString);
            List<int> outputList = new List<int>();
            for (int i = 0; i < transformCode.Count; i++)
            {
                int outputCode = (transformCode[i] + sign * inputKeyInt[i % inputKeyInt.Count]) % alphabetToNummbre.Length;
                outputList.Add((outputCode >= 0) ? outputCode : outputCode + alphabetToNummbre.Length);
            }
            char[] output = new char[outputList.Count];
            for (int i = 0; i < outputList.Count; i++)
            {
                output[i] = alphabetToNummbre[outputList[i]];
            }

            return new string(output);
        }
    }

    public class VerschluessungFullAscii : Verschluessung 
    {
        public VerschluessungFullAscii()
        {
            alphabetToNummbre = Enumerable.Range(' ', 91).Select(asciCode => (char)asciCode).ToArray();
        }
        protected override char[] StringChar(string inputstring)
        {
            char[] modifiedArray = new char[inputstring.Length];
            for (int i = 0; i < inputstring.Length; i++)
            {
                modifiedArray[i] = inputstring[i];

                if (inputstring[i] > 128)
                {
                    modifiedArray[i] = 'a';
                }
            }
            return modifiedArray;
        }
    }

}

