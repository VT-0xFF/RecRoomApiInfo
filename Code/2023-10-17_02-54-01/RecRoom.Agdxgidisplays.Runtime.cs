using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LMNDMNPLBNL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum KPMILLCGJNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void PCIAOHPOEEK(IntPtr LJEEHJLDFLC, int ALCHALOFNIJ, int FEPGGPGGOBD);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IJINPLOOONG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5BDBDF0", Offset = "0x5BDA5F0", VA = "0x185BDBDF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC2C0", Offset = "0x5BDAAC0", VA = "0x185BDC2C0")]
	private static extern void GKCPBBKFGEO(PCIAOHPOEEK ABCKGGDLEKO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBF50", Offset = "0x5BDA750", VA = "0x185BDBF50")]
	[MonoPInvokeCallback(typeof(PCIAOHPOEEK))]
	private static void EMILHJJBONB(IntPtr LJEEHJLDFLC, int ALCHALOFNIJ, int FEPGGPGGOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC350", Offset = "0x5BDAB50", VA = "0x185BDC350")]
	private static extern void GLJEDCMMNGN();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBEE0", Offset = "0x5BDA6E0", VA = "0x185BDBEE0")]
	private static extern void HCMCPHDEMHH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBDF0", Offset = "0x5BDA5F0", VA = "0x185BDBDF0")]
	private static extern int AOCMNEOBOHK();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC050", Offset = "0x5BDA850", VA = "0x185BDC050")]
	private static extern int FNMOIFPEOAF(int NENKFFLNHCE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBE60", Offset = "0x5BDA660", VA = "0x185BDBE60")]
	private static extern int BGAAHHOLAKL(int NENKFFLNHCE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC3C0", Offset = "0x5BDABC0", VA = "0x185BDC3C0")]
	private static extern int LHKBBIINPDK(int NENKFFLNHCE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC440", Offset = "0x5BDAC40", VA = "0x185BDC440")]
	private static extern int MBJMCOIEMAE(int NENKFFLNHCE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC4C0", Offset = "0x5BDACC0", VA = "0x185BDC4C0")]
	public LMNDMNPLBNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBEE0", Offset = "0x5BDA6E0", VA = "0x185BDBEE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC0D0", Offset = "0x5BDA8D0", VA = "0x185BDC0D0")]
	public Rect GBMFIGJMHGA(int FLDMIMDJCEB)
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
