using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class COFNHNKDCAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum GMIJGCGAGJP
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void PJGBAIAMFHJ(IntPtr GKLLPHJPFFI, int LCJMNMLOPCJ, int FALBLLMJADO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LPICOIFBIJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x21E3FA0", Offset = "0x21E2DA0", VA = "0x1821E3FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x21E42A0", Offset = "0x21E30A0", VA = "0x1821E42A0")]
	private static extern void IFGBMMMPAHH(PJGBAIAMFHJ JAKHBAJPHJL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x21E4170", Offset = "0x21E2F70", VA = "0x1821E4170")]
	[MonoPInvokeCallback(typeof(PJGBAIAMFHJ))]
	private static void HAEGEEAMJKF(IntPtr GKLLPHJPFFI, int LCJMNMLOPCJ, int FALBLLMJADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x21E4100", Offset = "0x21E2F00", VA = "0x1821E4100")]
	private static extern void FKIENGHPLFJ();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x21E4090", Offset = "0x21E2E90", VA = "0x1821E4090")]
	private static extern void JMMNODDONBA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x21E3FA0", Offset = "0x21E2DA0", VA = "0x1821E3FA0")]
	private static extern int MNNCNEELHEE();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x21E45A0", Offset = "0x21E33A0", VA = "0x1821E45A0")]
	private static extern int MKNDKBPLDIL(int FCIFBDBBENJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x21E4620", Offset = "0x21E3420", VA = "0x1821E4620")]
	private static extern int PMFAPGBNBMN(int FCIFBDBBENJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x21E4010", Offset = "0x21E2E10", VA = "0x1821E4010")]
	private static extern int CGADMFJOKGE(int FCIFBDBBENJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x21E4520", Offset = "0x21E3320", VA = "0x1821E4520")]
	private static extern int MGHKJBCNJDP(int FCIFBDBBENJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x21E46A0", Offset = "0x21E34A0", VA = "0x1821E46A0")]
	public COFNHNKDCAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x21E4090", Offset = "0x21E2E90", VA = "0x1821E4090", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x21E4330", Offset = "0x21E3130", VA = "0x1821E4330")]
	public Rect LKICHFKGHHF(int DMLIPKJHIAI)
	{
		return default(Rect);
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
