#if XUNIT
using Xunit;
// NUnit aliases
using Test = Xunit.FactAttribute;
using OneTimeSetUp = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
// XUnit aliases
using Fact = NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

#if BENCHMARKDOTNET
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Attributes.Jobs;
#else
using Benchmark = HolisticWare.Core.Testing.BenchmarkTests.Benchmark;
using ShortRunJob = HolisticWare.Core.Testing.BenchmarkTests.ShortRunJob;
#endif

using System;
using System.Collections.Generic;
using System.Text;
using Core.Linq;
using System.Collections;
using System.Linq;

namespace Tests.CommonShared.Core.Linq
{
    public partial class UnitTestsMemory01
    {
        [Benchmark()]
        public IEnumerable<byte> Memory_Byte_OddDivision(Memory<byte> memory)
        {
            return memory.OddDivision();
        }

        [Test()]
        public void Memory_Byte_OddDivision_Test()
        {
            IEnumerable<byte> calculated_odd_byte = Memory_Byte_OddDivision(new Memory<byte>(data_array_byte));

            // Assert
            #if NUNIT
            CollectionAssert.AreEqual
                                    (
                                        calculated_odd_byte, 
                                        data_array_odd_result_actual_byte
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        calculated_odd_byte, 
                                        data_array_odd_result_actual_byte
                                    );
            #elif MSTEST
            CollectionAssert.AreEqual
                                    (
                                        calculated_odd_byte.ToList(),
                                        data_array_odd_result_actual_byte
                                    );
            #endif

            return;
        }

        [Benchmark()]
        public IEnumerable<short> Memory_Short_OddDivision(Memory<short> memory)
        {
            return memory.OddDivision();
        }

        [Test()]
        public void Memory_Short_OddDivision_Test()
        {
            IEnumerable<short> calculated_odd_short = Memory_Short_OddDivision(new Memory<short>(data_array_short));

            // Assert
            #if NUNIT
            CollectionAssert.AreEqual
                                    (
                                        calculated_odd_short, 
                                        data_array_odd_result_actual_short
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        calculated_odd_short, 
                                        data_array_odd_result_actual_short
                                    );
            #elif MSTEST
            CollectionAssert.AreEqual
                                    (
                                        calculated_odd_short.ToList(),
                                        data_array_odd_result_actual_short
                                    );
            #endif

            return;
        }

        [Benchmark()]
        public IEnumerable<ushort> Memory_UShort_OddDivision(Memory<ushort> memory)
        {
            return memory.OddDivision();
        }

        [Test()]
        public void Memory_UShort_OddDivision_Test()
        {
            IEnumerable<ushort> calculated_odd_ushort = Memory_UShort_OddDivision(new Memory<ushort>(data_array_ushort));

            // Assert
            #if NUNIT
            CollectionAssert.AreEqual
                                    (
                                        calculated_odd_ushort, 
                                        data_array_odd_result_actual_ushort
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        calculated_odd_ushort, 
                                        data_array_odd_result_actual_ushort
                                    );
            #elif MSTEST
            CollectionAssert.AreEqual
                                    (
                                        calculated_odd_ushort.ToList(),
                                        data_array_odd_result_actual_ushort
                                    );
            #endif

            return;
        }


        [Benchmark()]
        public IEnumerable<int> Memory_Int_OddDivision(Memory<int> memory)
        {
            return memory.OddDivision();
        }

        [Test()]
        public void Memory_Int_OddDivision_Test()
        {
            IEnumerable<int> calculated_odd_int = Memory_Int_OddDivision(new Memory<int>(data_array_int));

            // Assert
            #if NUNIT
            CollectionAssert.AreEqual
                                    (
                                        calculated_odd_int, 
                                        data_array_odd_result_actual_int
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        calculated_odd_int, 
                                        data_array_odd_result_actual_int
                                    );
            #elif MSTEST
            CollectionAssert.AreEqual
                                    (
                                        calculated_odd_int.ToList(),
                                        data_array_odd_result_actual_int
                                    );
            #endif

            return;
        }

        [Benchmark()]
        public IEnumerable<uint> Memory_UInt_OddDivision(Memory<uint> memory)
        {
            return memory.OddDivision();
        }

        [Test()]
        public void Memory_UInt_OddDivision_Test()
        {
            IEnumerable<uint> calculated_odd_uint = Memory_UInt_OddDivision(new Memory<uint>(data_array_uint));

            // Assert
            #if NUNIT
            CollectionAssert.AreEqual
                                    (
                                        calculated_odd_uint, 
                                        data_array_odd_result_actual_uint
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        calculated_odd_uint, 
                                        data_array_odd_result_actual_uint
                                    );
            #elif MSTEST
            CollectionAssert.AreEqual
                                    (
                                        calculated_odd_uint.ToList(),
                                        data_array_odd_result_actual_uint
                                    );
            #endif

            return;
        }

        [Benchmark()]
        public IEnumerable<long> Memory_Long_OddDivision(Memory<long> memory)
        {
            return memory.OddDivision();
        }

        [Test()]
        public void Memory_Long_OddDivision_Test()
        {
            IEnumerable<long> calculated_odd_long = Memory_Long_OddDivision(new Memory<long>(data_array_long));

            // Assert
            #if NUNIT
            CollectionAssert.AreEqual
                                    (
                                        calculated_odd_long, 
                                        data_array_odd_result_actual_long
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        calculated_odd_long, 
                                        data_array_odd_result_actual_long
                                    );
            #elif MSTEST
            CollectionAssert.AreEqual
                                    (
                                        calculated_odd_long.ToList(),
                                        data_array_odd_result_actual_long
                                    );
            #endif

            return;
        }

        [Benchmark()]
        public IEnumerable<ulong> Memory_ULong_OddDivision(Memory<ulong> memory)
        {
            return memory.OddDivision();
        }

        [Test()]
        public void Memory_ULong_OddDivision_Test()
        {
            IEnumerable<ulong> calculated_odd_ulong = Memory_ULong_OddDivision(data_array_ulong.AsMemory());

            // Assert
            #if NUNIT
            CollectionAssert.AreEqual
                                    (
                                        calculated_odd_ulong, 
                                        data_array_odd_result_actual_ulong
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        calculated_odd_ulong, 
                                        data_array_odd_result_actual_ulong
                                    );
            #elif MSTEST
            CollectionAssert.AreEqual
                                    (
                                        calculated_odd_ulong.ToList(),
                                        data_array_odd_result_actual_ulong
                                    );
            #endif

            return;
        }

    }
}