using System.Text;

namespace Logic
{
    public class LogicObj
    {
        public async static Task<string> GenerateText(int stringsCount)
        {
            string saveText = string.Empty;
            for (int i = 0; i < stringsCount; i++)
            {
                await Task.Delay(1);
                saveText += "[" + i + "] Тестовая строка\n";
            }
            return saveText;
        }

        public async static Task SetPhrace(string text)
        {
            string path1 = "1.txt";

            var srcEncoding = Encoding.GetEncoding("UTF-8");
            using (StreamWriter writer = new StreamWriter(path1, false, encoding: srcEncoding))
            {
                await writer.WriteLineAsync(text);
            }
           
        }
        public async static Task<string> GetPhrace()
        {
            string path1 = "1.txt";
            string text = "";
            var srcEncoding = Encoding.GetEncoding("UTF-8");
            using (StreamReader reader = new StreamReader(path1, encoding: srcEncoding))
            {
                await Task.Delay(1);
                text += reader.ReadToEnd();
            }
            return text;
        }
    }
}