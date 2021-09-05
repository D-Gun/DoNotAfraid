using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_1_csvToText
{
    class Program
    {
        static void Main(string[] args)
        {
            //FilePath check
            Console.WriteLine("FilePath : " + Dic.FilePath);
            //ConnectionString check
            Console.WriteLine("ConnectString : " + Dic.ConnectionString);
            
            //getFileList From FilePath
            FileInfo[] fileInfoInDir = FileUtil.GetFileList(Dic.FilePath);
            string result = FileUtil.ReadFileToString(fileInfoInDir, "TestFile.CSV");
            Console.WriteLine("Read Text : \r\n" + result);
            //FileUtil.WriteTextInTxtFile(fileInfoInDir,"Testresult.txt",result);
            DBUtil.InsertData(Dic.ConnectionString, result);

        }
    }
}
