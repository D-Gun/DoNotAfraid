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
                string parentDirPath = fileInfo[0].DirectoryName;
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
                    tmp = File.ReadAllText(parentDirPath + "\\" + fileName);
                    File.Delete(parentDirPath + "\\FailFlag");
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return tmp;
        }

        public FileInfo[] getFileList(string filepath)
        {
            DirectoryInfo di = new DirectoryInfo(filepath);
            FileInfo[] fileInfo = di.GetFiles();
            return fileInfo;
        }
    }
}
