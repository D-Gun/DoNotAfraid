using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Toy_1_csvToText
{
    class FileUtil
    {
        public string ReadFileToString(FileInfo[] fileInfo, string fileName)
        {
            string tmp = "";
            try
            {
                //
                string parentDirPath = fileInfo[0].DirectoryName;
                using (StreamReader sr = new StreamReader(parentDirPath + "\\" + fileName, Encoding.Default, true))
                {
                    //파일 없으면 텍스트 파일 생성
                    if (!File.Exists(parentDirPath + "\\" + fileName))
                    {
                        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " There Is No File\r\n" + "msg.txt File Created");
                        File.WriteAllText(parentDirPath + "\\msg.txt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " There Is No File");
                        File.Create(parentDirPath + "\\FailFlag");
                    }
                    //있다면 파일 읽어오기
                    else
                    {
                        tmp = sr.ReadToEnd();
                        File.Delete(parentDirPath + "\\FailFlag");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return tmp;
        }

        public void WriteTextInTxtFile(FileInfo[] fileInfo, string fileName, string resultTxt)
        {
            try
            {
                //FileInfo 객체를 이용해서 Directory Path string 으로 받기
                string parentDirPath = fileInfo[0].DirectoryName;
                using (StreamWriter sw = new StreamWriter(parentDirPath + "\\" + fileName, false, Encoding.Default))
                {
                    //파일 없으면 result 텍스트 파일 생성
                    if (!File.Exists(parentDirPath + "\\" + fileName))
                    {
                        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " There Is No File\r\n" + fileName + " File Created");
                        //File.WriteAllText(parentDirPath + "\\" + fileName, resultTxt);
                        File.Create(parentDirPath + "\\" + fileName);
                        sw.Write(resultTxt);
                    }
                    //있다면 파일에 string 값 쓰기
                    else
                    {
                        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " Write Success");
                        //File.WriteAllText(parentDirPath + "\\" + fileName, resultTxt);
                        sw.Write(resultTxt);
                        File.Delete(parentDirPath + "\\FailFlag");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public FileInfo[] getFileList(string filepath)
        {
            DirectoryInfo di = new DirectoryInfo(filepath);
            FileInfo[] fileInfo = di.GetFiles();
            return fileInfo;
        }
    }
}
