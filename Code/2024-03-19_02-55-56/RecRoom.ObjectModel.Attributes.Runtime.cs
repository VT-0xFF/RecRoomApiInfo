using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DOGHIPMMFGG : MCJPEDFJCPC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7CB100", Offset = "0x7CA100", VA = "0x1807CB100")]
	public DOGHIPMMFGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct NOPMNHIANLF : IEquatable<NOPMNHIANLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly ulong ADACBBLDADO;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6242720", Offset = "0x6241720", VA = "0x186242720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x18479B0", Offset = "0x18469B0", VA = "0x1818479B0", Slot = "4")]
	public bool Equals(NOPMNHIANLF PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6242690", Offset = "0x6241690", VA = "0x186242690", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22742A0", Offset = "0x22732A0", VA = "0x1822742A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AGNHFEDIHIP : AlwaysUpdateSystemAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7CB100", Offset = "0x7CA100", VA = "0x1807CB100")]
	public AGNHFEDIHIP()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LCCIMHLHFIH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public LCCIMHLHFIH()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
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
