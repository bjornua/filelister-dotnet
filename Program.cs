// Todo:
// Print out a list of current dir
// Recursively print out directory entries
// Take command line argument



namespace filelister_dotnet
{


    class Program
    {
        static public System.Collections.Generic.IEnumerator<string> RecursiveFileEnumerator(string startDirectory)
        {
            var remaining_dirs = new System.Collections.Generic.Stack<string>();
            remaining_dirs.Push(startDirectory);

            while (true)
            {
                var directory = remaining_dirs.Pop();
            }

        }

        static void Main(string[] args)
        {
            // System.Console.WriteLine(item);

        }
    }
}


