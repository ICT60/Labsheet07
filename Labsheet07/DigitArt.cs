using System;
using System.Collections.Generic;

namespace Labsheet07
{
    class DigitArt
    {
        const int WIDTH = 6;
        const int HEIGHT = 6;
        const int SPACE_BETWEEN_CHARACTER = 2;

        public Dictionary<char, string[]> Template => _template;
        Dictionary<char, string[]> _template;


        public DigitArt()
        {
            _initialize();
        }

        public void WriteLine(string value)
        {
            for (int row = 0; row < HEIGHT; row++)
            {
                var result = String.Empty;

                foreach (char character in value)
                {
                    for (int i = 0; i < SPACE_BETWEEN_CHARACTER; i++) {
                        result += " ";
                    }

                    var digitText = _template[character];
                    result += digitText[row];
                }

                Console.WriteLine(result);
            }
        }

        void _initialize()
        {
            _template = new Dictionary<char, string[]>();

            _template.Add('0', new string[HEIGHT]);
            _template['0'][0] = "  **  ";
            _template['0'][1] = "*    *";
            _template['0'][2] = "*    *";
            _template['0'][3] = "*    *";
            _template['0'][4] = "*    *";
            _template['0'][5] = "  **  ";

            _template.Add('1', new string[HEIGHT]);
            _template['1'][0] = "   *  ";
            _template['1'][1] = "  **  ";
            _template['1'][2] = " * *  ";
            _template['1'][3] = "   *  ";
            _template['1'][4] = "   *  ";
            _template['1'][5] = "   *  ";

            _template.Add('2', new string[HEIGHT]);
            _template['2'][0] = " *****";
            _template['2'][1] = "     *";
            _template['2'][2] = " *****";
            _template['2'][3] = "*     ";
            _template['2'][4] = "*     ";
            _template['2'][5] = "******";

            _template.Add('3', new string[HEIGHT]);
            _template['3'][0] = " *****";
            _template['3'][1] = "     *";
            _template['3'][2] = " *****";
            _template['3'][3] = "     *";
            _template['3'][4] = "     *";
            _template['3'][5] = " *****";

            _template.Add('4', new string[HEIGHT]);
            _template['4'][0] = " *    ";
            _template['4'][1] = " * *  ";
            _template['4'][2] = " *****";
            _template['4'][3] = "   *  ";
            _template['4'][4] = "   *  ";
            _template['4'][5] = "   *  ";

            _template.Add('5', new string[HEIGHT]);
            _template['5'][0] = " *****";
            _template['5'][1] = " *    ";
            _template['5'][2] = " *****";
            _template['5'][3] = "     *";
            _template['5'][4] = "     *";
            _template['5'][5] = " *****";

            _template.Add('6', new string[HEIGHT]);
            _template['6'][0] = " *****";
            _template['6'][1] = " *    ";
            _template['6'][2] = " *****";
            _template['6'][3] = " *   *";
            _template['6'][4] = " *   *";
            _template['6'][5] = " *****";

            _template.Add('7', new string[HEIGHT]);
            _template['7'][0] = " *****";
            _template['7'][1] = "     *";
            _template['7'][2] = "     *";
            _template['7'][3] = "     *";
            _template['7'][4] = "     *";
            _template['7'][5] = "     *";

            _template.Add('8', new string[HEIGHT]);
            _template['8'][0] = " *****";
            _template['8'][1] = " *   *";
            _template['8'][2] = " *****";
            _template['8'][3] = " *   *";
            _template['8'][4] = " *   *";
            _template['8'][5] = " *****";

            _template.Add('9', new string[HEIGHT]);
            _template['9'][0] = " *****";
            _template['9'][1] = " *   *";
            _template['9'][2] = " *****";
            _template['9'][3] = "     *";
            _template['9'][4] = "     *";
            _template['9'][5] = " *****";
        }
    }
}