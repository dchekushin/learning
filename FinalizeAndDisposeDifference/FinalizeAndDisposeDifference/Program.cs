using System;

namespace FinalizeAndDisposeDifference
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();

            for (int i = 1; i <= 5; i++)
            {
                using (MyDisposableClass x = new MyDisposableClass(i))
                {
                    
                }
            }
        }
    }

    public class MyDisposableClass : IDisposable
    {
        public MyDisposableClass(int id)
        {
            Id = id;
            Console.WriteLine($"Call Constructor {Id}");
        }

        private int Id { get; }
        
        ~MyDisposableClass()
        {
            ReleaseUnmanagedResources();
        }

        private void ReleaseUnmanagedResources()
        {
            Console.WriteLine($"Call Finalize {Id}");
        }

        public void Dispose()
        {
            Console.WriteLine($"Call Dispose {Id}");
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }
    }
    
}