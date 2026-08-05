using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Foundation
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public readonly struct LogForJob
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85AECC0", Offset = "0x85ADAC0", VA = "0x1885AECC0")]
		public static implicit operator LogForJob(Log log)
		{
			return default(LogForJob);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x85AEDA0", Offset = "0x85ADBA0", VA = "0x1885AEDA0")]
		public LogForJob(Log log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85AECE0", Offset = "0x85ADAE0", VA = "0x1885AECE0")]
		public void ZAKOHFVMPUT([In] FixedString128Bytes str)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class LQTEOEBHCWF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85AECC0", Offset = "0x85ADAC0", VA = "0x1885AECC0")]
		public static LogForJob NRLEIDUYCZW(this Log a)
		{
			return default(LogForJob);
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
