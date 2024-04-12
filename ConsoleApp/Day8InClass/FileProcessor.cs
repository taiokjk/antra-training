using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8InClass
{
    internal class FileProcessor
    {
        public void ProcessFile(string FileName)
        {
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream("something.txt", FileMode.Open);
            }
            catch (IOException ex)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                    fileStream.Dispose();
                    fileStream = null;
                }                
            }
        }
    }
}
