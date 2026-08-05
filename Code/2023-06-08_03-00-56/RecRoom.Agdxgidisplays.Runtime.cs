using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BKLNDPEEEFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum BKAFIAOELDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void MAOAMCKKILP(IntPtr IDLLMGEFFMF, int IBDNNEMEJLA, int GOBBBPGOPKA);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MIBEKHDFLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1942310", Offset = "0x1941110", VA = "0x181942310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1941FE0", Offset = "0x1940DE0", VA = "0x181941FE0")]
	private static extern void AAGFLAIPKFJ(MAOAMCKKILP IIPKIDOCHMK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x19420F0", Offset = "0x1940EF0", VA = "0x1819420F0")]
	[MonoPInvokeCallback(typeof(MAOAMCKKILP))]
	private static void CHMJMGBGOPB(IntPtr IDLLMGEFFMF, int IBDNNEMEJLA, int GOBBBPGOPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1942380", Offset = "0x1941180", VA = "0x181942380")]
	private static extern void HFKECJNCAPE();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1942220", Offset = "0x1941020", VA = "0x181942220")]
	private static extern void OADOBPMDOBN();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1942310", Offset = "0x1941110", VA = "0x181942310")]
	private static extern int HCMIEKLNBDO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x19423F0", Offset = "0x19411F0", VA = "0x1819423F0")]
	private static extern int KLCMOANMGGL(int PJCEAFJNLLG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1942290", Offset = "0x1941090", VA = "0x181942290")]
	private static extern int EDNMPBEKAMD(int PJCEAFJNLLG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1942470", Offset = "0x1941270", VA = "0x181942470")]
	private static extern int OBPCNAKEKDG(int PJCEAFJNLLG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1942070", Offset = "0x1940E70", VA = "0x181942070")]
	private static extern int CFHHIMKDMDJ(int PJCEAFJNLLG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x19426F0", Offset = "0x19414F0", VA = "0x1819426F0")]
	public BKLNDPEEEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1942220", Offset = "0x1941020", VA = "0x181942220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x19424F0", Offset = "0x19412F0", VA = "0x1819424F0")]
	public Rect OGMGKCEPCBO(int NGPJPPNLCPH)
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
