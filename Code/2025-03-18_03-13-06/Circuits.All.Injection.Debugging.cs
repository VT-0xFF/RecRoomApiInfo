using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IAOCJMJBDLM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class EEHDPPAOOAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public KAIOHIEPLEK logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public EEHDPPAOOAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2560A20", Offset = "0x255FC20", VA = "0x182560A20")]
		internal bool HPEIOAMOLHF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2560C80", Offset = "0x255FE80", VA = "0x182560C80")]
		internal void NAHGCFKPBDF(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2560A70", Offset = "0x255FC70", VA = "0x182560A70")]
		internal bool LEJNJILEMOA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2560BD0", Offset = "0x255FDD0", VA = "0x182560BD0")]
		internal void MHKKIAMPFEL(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2560B20", Offset = "0x255FD20", VA = "0x182560B20")]
		internal bool MBIOIDKMOMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2560970", Offset = "0x255FB70", VA = "0x182560970")]
		internal void EDGGDPGNABB(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly EBPLOCIFBPO JLGHKLNHGNO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x25615F0", Offset = "0x25607F0", VA = "0x1825615F0")]
	private static NJFMBEPMDGP NOGFLFNMLEA(KAIOHIEPLEK HHHPGIELGDM)
	{
		return default(NJFMBEPMDGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2560D30", Offset = "0x255FF30", VA = "0x182560D30")]
	private static EBPLOCIFBPO CAMNMIIIAIG()
	{
		return default(EBPLOCIFBPO);
	}
}
namespace Cpp2IlInjected;

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
