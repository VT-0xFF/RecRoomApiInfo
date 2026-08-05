using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class APEABCGPLHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum BHNELLEBMMK
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void CBNKCIGMBPD(IntPtr AMCPIDBEGOH, int GINDFGEIJMJ, int OEPOCABMPFE);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EJJAHFDEGJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3D85A30", Offset = "0x3D84C30", VA = "0x183D85A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3D85810", Offset = "0x3D84A10", VA = "0x183D85810")]
	private static extern void BMEPFHLAEEG(CBNKCIGMBPD HMCGKHCFDKN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3D858A0", Offset = "0x3D84AA0", VA = "0x183D858A0")]
	[MonoPInvokeCallback(typeof(CBNKCIGMBPD))]
	private static void BNOMGELOBNG(IntPtr AMCPIDBEGOH, int GINDFGEIJMJ, int OEPOCABMPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3D857A0", Offset = "0x3D849A0", VA = "0x183D857A0")]
	private static extern void BKKFKNMFHPD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3D859C0", Offset = "0x3D84BC0", VA = "0x183D859C0")]
	private static extern void PMPAMIBBMAL();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D85A30", Offset = "0x3D84C30", VA = "0x183D85A30")]
	private static extern int ICIDHBJHECM();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D85720", Offset = "0x3D84920", VA = "0x183D85720")]
	private static extern int AALMMBLMIGL(int PPEJJBAPEIC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D85B20", Offset = "0x3D84D20", VA = "0x183D85B20")]
	private static extern int LNGBGNIOKJP(int PPEJJBAPEIC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D85D90", Offset = "0x3D84F90", VA = "0x183D85D90")]
	private static extern int OJIILGHMGAF(int PPEJJBAPEIC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D85AA0", Offset = "0x3D84CA0", VA = "0x183D85AA0")]
	private static extern int INKMBPMFHIK(int PPEJJBAPEIC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D85E10", Offset = "0x3D85010", VA = "0x183D85E10")]
	public APEABCGPLHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D859C0", Offset = "0x3D84BC0", VA = "0x183D859C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D85BA0", Offset = "0x3D84DA0", VA = "0x183D85BA0")]
	public Rect NGICKBGCNBL(int EBPNLGBOIJK)
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
