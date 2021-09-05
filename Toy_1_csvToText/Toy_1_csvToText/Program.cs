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
            //File클래스 생성
            //FileStream fs = File.Create("test.txt");
            //폴더 내의 파일 리스트 얻기.
            FileUtil fu = new FileUtil();
            Console.WriteLine("FilePath : " + Dic.FilePath);
            Console.WriteLine("ConnectString : " + Dic.ConnectionString);
            FileInfo[] fileInfoInDir = fu.getFileList(Dic.FilePath);
            string result = fu.ReadFileToString(fileInfoInDir, "TestFile.CSV");
            Console.WriteLine(result);
            fu.WriteTextInTxtFile(fileInfoInDir,"Testresult.txt",result);
            //파일 리스트를 바탕으로 .csv파일 내 data 가공하여 string[]로 반환
            //string[] 의 내용을 가공하여 .txt로 export

        }
    }
}
