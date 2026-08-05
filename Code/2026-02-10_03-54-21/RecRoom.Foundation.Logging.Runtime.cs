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
		[Cpp2IlInjected.Address(RVA = "0x84526D0", Offset = "0x84518D0", VA = "0x1884526D0")]
		public static implicit operator LogForJob(Log log)
		{
			return default(LogForJob);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84526B0", Offset = "0x84518B0", VA = "0x1884526B0")]
		public LogForJob(Log log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84525F0", Offset = "0x84517F0", VA = "0x1884525F0")]
		public void SIWEPCCUJZK([In] FixedString128Bytes str)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class YSUTLRXCZSK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84526D0", Offset = "0x84518D0", VA = "0x1884526D0")]
		public static LogForJob QOGKYTQYTLV(this Log a)
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
