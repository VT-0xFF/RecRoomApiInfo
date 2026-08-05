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
		[Cpp2IlInjected.Address(RVA = "0x5E6A320", Offset = "0x5E68D20", VA = "0x185E6A320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A0A0", Offset = "0x5E68AA0", VA = "0x185E6A0A0")]
	private static extern void ANPCCGKKCGL(KEOCEGCNDKL DBIEPHLOFKD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A580", Offset = "0x5E68F80", VA = "0x185E6A580")]
	[MonoPInvokeCallback(typeof(KEOCEGCNDKL))]
	private static void KMLKJJHAHHN(IntPtr NCCHHGAPAOP, int BFFGCOIILMK, int LPINMKNOFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A680", Offset = "0x5E69080", VA = "0x185E6A680")]
	private static extern void NGFHLNOOHDK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A410", Offset = "0x5E68E10", VA = "0x185E6A410")]
	private static extern void NFEKLMCPNJP();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A320", Offset = "0x5E68D20", VA = "0x185E6A320")]
	private static extern int CABPIDNEGFF();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A500", Offset = "0x5E68F00", VA = "0x185E6A500")]
	private static extern int KBFHIOMKMGF(int PDDHPPHOJPD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A6F0", Offset = "0x5E690F0", VA = "0x185E6A6F0")]
	private static extern int OKOPHENHCLI(int PDDHPPHOJPD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A480", Offset = "0x5E68E80", VA = "0x185E6A480")]
	private static extern int FGFJMOGDLFH(int PDDHPPHOJPD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A390", Offset = "0x5E68D90", VA = "0x185E6A390")]
	private static extern int CDCEFJHJAKG(int PDDHPPHOJPD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A770", Offset = "0x5E69170", VA = "0x185E6A770")]
	public GKIPPEIIDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A410", Offset = "0x5E68E10", VA = "0x185E6A410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A130", Offset = "0x5E68B30", VA = "0x185E6A130")]
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
