using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Conditional("UNITY_EDITOR")]
[AttributeUsage(AttributeTargets.Method)]
public class LGDDHNLCIIP : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BMDKANPPHIN
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CFDCGBDKGOG : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2189610", Offset = "0x2188810", VA = "0x182189610")]
	public CFDCGBDKGOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct JHJFDNKBJLP : IEquatable<JHJFDNKBJLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly ulong LFLEGEJLLKE;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7DFC660", Offset = "0x7DFB860", VA = "0x187DFC660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x22758D0", Offset = "0x2274AD0", VA = "0x1822758D0", Slot = "4")]
	public bool Equals(JHJFDNKBJLP CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7DFC5D0", Offset = "0x7DFB7D0", VA = "0x187DFC5D0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2F3F1F0", Offset = "0x2F3E3F0", VA = "0x182F3F1F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EPOBOCCNAMD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
	public EPOBOCCNAMD()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JIMOOFOMAIG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public JIMOOFOMAIG()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
