using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class OOJAFOAIKGJ<TData> : CDMBCFNGLDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string IMLLLDFFNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData KJPNLGBHIKP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
	public override string GLHFGNJEPCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3DD1460", Offset = "0x3DCFC60", VA = "0x183DD1460")]
	internal OOJAFOAIKGJ(string LACIBLEADOC, [In] TData KOIMDAJNDOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DNMOKIHDNGB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1C791D0", Offset = "0x1C779D0", VA = "0x181C791D0")]
	public static OOJAFOAIKGJ<NLDGBPLBGDN> MJLGMKKAMEE(string LACIBLEADOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x21FD170", Offset = "0x21FB970", VA = "0x1821FD170")]
	public static OOJAFOAIKGJ<TData> MJLGMKKAMEE<TData>(string LACIBLEADOC, [In] TData KOIMDAJNDOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MHIFOONOHCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x246F1C0", Offset = "0x246D9C0", VA = "0x18246F1C0")]
	public static ENHODGJKDIF<TOk, HFHKAILBFCH> BLBFCJKFIAI<TOk>([In] this ENHODGJKDIF<TOk, HFHKAILBFCH> CLEGCKJMIEA, string LACIBLEADOC)
	{
		return default(ENHODGJKDIF<TOk, HFHKAILBFCH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CDMBCFNGLDJ : OFFEGPLAFGN, HFHKAILBFCH, OPCAMIHAIIG
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1C46C80", Offset = "0x1C45480", VA = "0x181C46C80")]
	protected CDMBCFNGLDJ()
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
