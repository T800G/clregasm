﻿// Program.cs
// (c) 2016, Charles Lechasseur
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace CL.RegAsm
{
    /// <summary>
    /// Class containing the main body of the CLRegAsm program.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Main body of CLRegAsm. Simply calls the <see cref="CLRegAsm.Core"/>
        /// class to perform tasks.
        /// </summary>
        /// <param name="args">Program arguments.</param>
        /// <returns>Program exit code. 0 if everything went well.</returns>
        static int Main(string[] args)
        {
            return Core.Run(args);
        }
    }
}
