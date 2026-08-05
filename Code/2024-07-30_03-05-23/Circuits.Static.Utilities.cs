using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class BAMMIHCPBKA<TData> : IFONDHBKBCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string NGFLOAALGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData GDPGJFHLHOH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
	public override string AFLHKEIDPKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE230", Offset = "0x4EBC830", VA = "0x184EBE230")]
	internal BAMMIHCPBKA(string ELIMFPDKMPD, [In] TData MMDLBEBNCGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ACBFMBIBABG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2063A30", Offset = "0x2062030", VA = "0x182063A30")]
	public static BAMMIHCPBKA<COKMANPFJNC> ENFOKLPNHAF(string ELIMFPDKMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x29A5D90", Offset = "0x29A4390", VA = "0x1829A5D90")]
	public static BAMMIHCPBKA<TData> ENFOKLPNHAF<TData>(string ELIMFPDKMPD, [In] TData MMDLBEBNCGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EMDMOKNDMKI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B7F0", Offset = "0x2A39DF0", VA = "0x182A3B7F0")]
	public static CBDPDIPONCF<TOk, FBDDJIHDMAI> CLFGPNEMHFC<TOk>([In] this CBDPDIPONCF<TOk, FBDDJIHDMAI> HLIDMKMINHN, string ELIMFPDKMPD)
	{
		return default(CBDPDIPONCF<TOk, FBDDJIHDMAI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class IFONDHBKBCD : PJDAENIABGC, FBDDJIHDMAI, GJMJCOBOHDO
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x20236F0", Offset = "0x2021CF0", VA = "0x1820236F0")]
	protected IFONDHBKBCD()
	{
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
