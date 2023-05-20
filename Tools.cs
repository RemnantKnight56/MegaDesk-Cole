using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Data.Common;
using Newtonsoft.Json;

namespace MegaDesk_Cole
{
    internal class Tools
    {

        public Tools(){
            if (File.Exists(getDir())){
                fileExist = true;
            }
            }
        private string dirPath = "C:\\MegaDesk\\";
        private string fileName = "MegaDeskDataSource.json";
        public bool fileExist = false;
        private string GenerateJson(List<DeskQuote> deskQ)
        {
            return JsonConvert.SerializeObject(deskQ.Where(c => c != null));
        }
        public void SaveFile(List<DeskQuote> deskQ)
        {
            FileStream fParameter = new FileStream(getDir(), FileMode.Create, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write(GenerateJson(deskQ));
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
        }

        public List<DeskQuote> LoadFile()
        {
            if (!Directory.Exists(dirPath)){
                Directory.CreateDirectory(dirPath);
            }

            if (File.Exists(getDir()))
            {
                using StreamReader m_ReaderParameter = new(getDir());
                var json = m_ReaderParameter.ReadToEnd();
                m_ReaderParameter.Close();
                return JsonConvert.DeserializeObject<List<DeskQuote>>(json);
            }
            return null;

        }

        private string getDir()
        {
            return dirPath+fileName;
        }

    }

}
