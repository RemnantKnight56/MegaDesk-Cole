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
    {   List<DeskQuote> deskQuoteList = new List<DeskQuote>();
        private string dirPath = "C:\\MegaDesk\\MegaDeskDataSource.json";
        private string GenerateJson(DeskQuote[] deskQ)
        {
            return JsonConvert.SerializeObject(deskQ.Where(c => c != null));
        }
        public void SaveFile(DeskQuote[] deskQ)
        {
            FileStream fParameter = new FileStream(dirPath, FileMode.Create, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write(GenerateJson(deskQ));
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
        }

        public DeskQuote[] LoadFile()
        {  
            using StreamReader m_ReaderParameter = new(dirPath);
            var json = m_ReaderParameter.ReadToEnd();
            m_ReaderParameter.Close();
            return JsonConvert.DeserializeObject<DeskQuote[]>(json);

        }

        public string getDir()
        {
            return dirPath;
        }

    }

}
