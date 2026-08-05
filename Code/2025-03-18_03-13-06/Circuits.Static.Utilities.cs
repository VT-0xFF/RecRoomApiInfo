using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class HKNLAMFOBDO<TData> : JMDJCEHKLNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string OHPLCOFMPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData GGCAPNOPJKL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
	public override string JBKGPNGEPEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x46B4F80", Offset = "0x46B4180", VA = "0x1846B4F80")]
	internal HKNLAMFOBDO(string DCEACFEGBDC, [In] TData LJELDKAOCJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JFFFPIOBKPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x262E330", Offset = "0x262D530", VA = "0x18262E330")]
	public static HKNLAMFOBDO<OJADAPCHIGK> PEFMILKIAFF(string DCEACFEGBDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3209070", Offset = "0x3208270", VA = "0x183209070")]
	public static HKNLAMFOBDO<TData> PEFMILKIAFF<TData>(string DCEACFEGBDC, [In] TData LJELDKAOCJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HPFHONOHICK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x34C1F00", Offset = "0x34C1100", VA = "0x1834C1F00")]
	public static CPEANPEHCAG<TOk, BBIMJBGJONM> MMKJBBAIHPA<TOk>([In] this CPEANPEHCAG<TOk, BBIMJBGJONM> NAELBAPCKEH, string DCEACFEGBDC)
	{
		return default(CPEANPEHCAG<TOk, BBIMJBGJONM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class JMDJCEHKLNJ : ILEHMOEGHGD, BBIMJBGJONM, GNOCHPEDIKN
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25ED3F0", Offset = "0x25EC5F0", VA = "0x1825ED3F0")]
	protected JMDJCEHKLNJ()
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
