using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Space3D
{
    public static class PathStorage
    {
        private const string FilePath = "..//..//paths.txt";

        // Methods
        public static void SavePath(Path path, bool append)
        {
            StreamWriter writer = new StreamWriter(FilePath, append);

            using (writer)
            {
                writer.WriteLine("--Path Start--");
                foreach (Point3D point in path)
                {
                    writer.WriteLine(point);   
                }
                writer.WriteLine("--Path End--");
            }
        }

        public static StringBuilder LoadPath()
        {
            StreamReader reader = new StreamReader(FilePath);
            StringBuilder paths = new StringBuilder();
            string pattern = @"(?<point_index>\d+)\((?<x>\d+)\,(?<y>\d+)\,(?<z>\d+)\)";
            int pathIndex = 0;
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (line == "--Path Start--")
                    {
                        pathIndex++;
                        paths.AppendLine(string.Format("--Path {0}--", pathIndex));
                    }
                    else if (line == "--Path End--")
                    {
                        paths.AppendLine();
                    }
                    else
                    {
                        MatchCollection matches = Regex.Matches(line, pattern);
                        foreach (Match match in matches)
                        {
                            paths.Append("Point " + match.Groups["point_index"].ToString() + "(");
                            paths.Append(match.Groups["x"].ToString() + ",");
                            paths.Append(match.Groups["y"].ToString() + ",");
                            paths.AppendLine(match.Groups["x"].ToString() + ")");
                        }
                    }
                    
                    line = reader.ReadLine();
                }
            }
            return paths;
        }
    }
}