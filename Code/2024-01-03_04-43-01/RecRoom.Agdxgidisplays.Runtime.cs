using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LHAGGAFCLMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum PBJLIKHPPHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void LEEGEJJJAIB(IntPtr NFAAJOAMBMN, int JIGGJNDJAAO, int JKPDFEBEMEM);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MPBIJLGJPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D0D460", Offset = "0x5D0C060", VA = "0x185D0D460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D8B0", Offset = "0x5D0C4B0", VA = "0x185D0D8B0")]
	private static extern void HICFIFHMPDG(LEEGEJJJAIB FCFEFDOJHCD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D7B0", Offset = "0x5D0C3B0", VA = "0x185D0D7B0")]
	[MonoPInvokeCallback(typeof(LEEGEJJJAIB))]
	private static void HELDADLLNHC(IntPtr NFAAJOAMBMN, int JIGGJNDJAAO, int JKPDFEBEMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D940", Offset = "0x5D0C540", VA = "0x185D0D940")]
	private static extern void JMCKLNABHHJ();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D6C0", Offset = "0x5D0C2C0", VA = "0x185D0D6C0")]
	private static extern void GBMPNHFICMJ();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D460", Offset = "0x5D0C060", VA = "0x185D0D460")]
	private static extern int KMOMHHMAPEB();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DA30", Offset = "0x5D0C630", VA = "0x185D0DA30")]
	private static extern int MCDJGMGPHOA(int HLINMGJJNHD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D9B0", Offset = "0x5D0C5B0", VA = "0x185D0D9B0")]
	private static extern int KGOMFGIFPPL(int HLINMGJJNHD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DAB0", Offset = "0x5D0C6B0", VA = "0x185D0DAB0")]
	private static extern int OMKGINCMLEO(int HLINMGJJNHD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D730", Offset = "0x5D0C330", VA = "0x185D0D730")]
	private static extern int EOGDPBOMAAG(int HLINMGJJNHD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DB30", Offset = "0x5D0C730", VA = "0x185D0DB30")]
	public LHAGGAFCLMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D6C0", Offset = "0x5D0C2C0", VA = "0x185D0D6C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D4D0", Offset = "0x5D0C0D0", VA = "0x185D0D4D0")]
	public Rect DJFHDOAFNCJ(int LCKOJMJPCGI)
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
