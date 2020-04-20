namespace GUI
{
    class TableToString
    {
        string[] headers = new string[] { };
        string[][] columns = new string[][] { };

        public TableToString(string[] headers, string[][] columns)
        {
            this.headers = headers;
            this.columns = columns;
        }

        public string GetResult()
        {
            int[] maxColumnLength = GetColumnsLength();

            var resultString = "";

            { // build header
                for (var i = 0; i < headers.Length; i++)
                {
                    resultString += "+" + "-".PadRight(maxColumnLength[i], '-');

                    if (i == headers.Length - 1)
                    {
                        resultString += "+";
                    }
                }

                resultString += System.Environment.NewLine;

                for (var i = 0; i < headers.Length; i++)
                {
                    resultString += "|" + headers[i].PadRight(maxColumnLength[i]);

                    if (i == headers.Length - 1)
                    {
                        resultString += "|";
                    }
                }

                resultString += System.Environment.NewLine;

                for (var i = 0; i < headers.Length; i++)
                {
                    resultString += "+" + "-".PadRight(maxColumnLength[i], '-');

                    if (i == headers.Length - 1)
                    {
                        resultString += "+";
                    }
                }

                resultString += System.Environment.NewLine;
            }

            { // build rows
                for (var i = 0; i < columns.Length; i++)
                {
                    for (var j = 0; j < headers.Length; j++)
                    {
                        resultString += "|" + columns[i][j].PadRight(maxColumnLength[j]);

                        if (j == headers.Length - 1)
                        {
                            resultString += "|";
                        }
                    }

                    resultString += System.Environment.NewLine;

                    for (var j = 0; j < headers.Length; j++)
                    {
                        resultString += "+" + "-".PadRight(maxColumnLength[j], '-');

                        if (j == headers.Length - 1)
                        {
                            resultString += "+";
                        }
                    }

                    resultString += System.Environment.NewLine;
                }
            }

            return resultString;
        }

        private int[] GetColumnsLength()
        {
            int[] maxColumnLength = new int[headers.Length];

            for (int i = 0; i < maxColumnLength.Length; i++)
            {
                maxColumnLength[i] = 0;
            }

            for (int i = 0; i < headers.Length; i++)
            {
                if (maxColumnLength[i] < headers[i].Length)
                {
                    maxColumnLength[i] = headers[i].Length;
                }
            }

            for (int j = 0; j < columns.Length; j++)
            {
                for (int i = 0; i < headers.Length; i++)
                {
                    if (maxColumnLength[i] < columns[j][i].Length)
                    {
                        maxColumnLength[i] = columns[j][i].Length;
                    }
                }
            }

            return maxColumnLength;
        }
    }
}
