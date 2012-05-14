using System;
using System.Reflection;
using Spring.Context.Support;
using System.IO;

namespace PersonalPage.Library.Helpers
{
    public static class ContextHelper
    {
        /// <summary>
        /// Return context used for production (release).
        /// </summary>
        /// <returns>Return context used for production (release).</returns>
        public static XmlApplicationContext GetProductionContext()
        {
            var codeBase = Assembly.GetExecutingAssembly().GetName().CodeBase;
            var localPath = new Uri(codeBase).LocalPath;
            var directoryName = Path.GetDirectoryName(localPath);

            string[] filePaths = Directory.GetFiles(directoryName + @"\Context\", "*.xml");
             
            for (int i = 0; i < filePaths.Length; i++)
            {
                filePaths[i] = "file://" + filePaths[i];
            }

            //we are using context aware, so we can reach any object in context we want. Helpfull when testing.
            return new XmlApplicationContext(filePaths);

        }

    }
}