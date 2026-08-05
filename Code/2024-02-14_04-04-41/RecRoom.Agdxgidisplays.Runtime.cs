using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GKIPPEIIDGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum FEGAIHMGIPF
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void KEOCEGCNDKL(IntPtr NCCHHGAPAOP, int BFFGCOIILMK, int LPINMKNOFIN);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KHODAMPFIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DF1210", Offset = "0x5DF0610", VA = "0x185DF1210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0F90", Offset = "0x5DF0390", VA = "0x185DF0F90")]
	private static extern void ANPCCGKKCGL(KEOCEGCNDKL DBIEPHLOFKD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1470", Offset = "0x5DF0870", VA = "0x185DF1470")]
	[MonoPInvokeCallback(typeof(KEOCEGCNDKL))]
	private static void KMLKJJHAHHN(IntPtr NCCHHGAPAOP, int BFFGCOIILMK, int LPINMKNOFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1570", Offset = "0x5DF0970", VA = "0x185DF1570")]
	private static extern void NGFHLNOOHDK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1300", Offset = "0x5DF0700", VA = "0x185DF1300")]
	private static extern void NFEKLMCPNJP();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1210", Offset = "0x5DF0610", VA = "0x185DF1210")]
	private static extern int CABPIDNEGFF();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5DF13F0", Offset = "0x5DF07F0", VA = "0x185DF13F0")]
	private static extern int KBFHIOMKMGF(int PDDHPPHOJPD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DF15E0", Offset = "0x5DF09E0", VA = "0x185DF15E0")]
	private static extern int OKOPHENHCLI(int PDDHPPHOJPD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1370", Offset = "0x5DF0770", VA = "0x185DF1370")]
	private static extern int FGFJMOGDLFH(int PDDHPPHOJPD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1280", Offset = "0x5DF0680", VA = "0x185DF1280")]
	private static extern int CDCEFJHJAKG(int PDDHPPHOJPD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1660", Offset = "0x5DF0A60", VA = "0x185DF1660")]
	public GKIPPEIIDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1300", Offset = "0x5DF0700", VA = "0x185DF1300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1020", Offset = "0x5DF0420", VA = "0x185DF1020")]
	public Rect BMPNIJEOPKO(int DIHAKIJBJBP)
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
