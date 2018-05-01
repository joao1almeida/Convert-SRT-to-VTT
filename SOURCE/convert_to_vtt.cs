using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_SRT_to_VTT
{
    class convert_to_vtt
    {
        public static string convert(string[] file)
        {
            string converted_file = "WEBVTT" + Environment.NewLine;
            bool next_line_convert = false; //if next line is to convert
            int n; //necessary variable to detect if line is track number

            foreach (string line in file)
            {
                if (next_line_convert)
                {
                    //string converted_line = line.Replace(",", ".");
                    converted_file = converted_file + Environment.NewLine + line.Replace(",", ".");
                    next_line_convert = false;
                }
                else
                {
                    //reads if line is number
                    bool isNumeric = int.TryParse(line, out n);

                    //if lines is number, means next line will be somthing like "00:00:07.630 --> 00:00:09.800" and should be converted
                    if (isNumeric)
                    {
                        next_line_convert = true;
                    }
                    converted_file = converted_file + Environment.NewLine + line;
                }
            }

            return converted_file;
        }
    }
}
