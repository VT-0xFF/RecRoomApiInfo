using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OJFLOLCPJDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum GDDOCOGPBCG
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void BMAOBBFLOKO(IntPtr NJAMEFJLMOC, int GFFJJOEGODF, int HFAKHJGGBLC);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int APFLEPMPMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72CE9B0", Offset = "0x72CD9B0", VA = "0x1872CE9B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72CE690", Offset = "0x72CD690", VA = "0x1872CE690")]
	private static extern void BCAAGGNBNIM(BMAOBBFLOKO PAFCNGJPIGM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72CE790", Offset = "0x72CD790", VA = "0x1872CE790")]
	[MonoPInvokeCallback(typeof(BMAOBBFLOKO))]
	private static void HGKBJAFHLBN(IntPtr NJAMEFJLMOC, int GFFJJOEGODF, int HFAKHJGGBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72CE8C0", Offset = "0x72CD8C0", VA = "0x1872CE8C0")]
	private static extern void JFGMJMMFADK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72CE720", Offset = "0x72CD720", VA = "0x1872CE720")]
	private static extern void MHLIHDJHEMD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72CE9B0", Offset = "0x72CD9B0", VA = "0x1872CE9B0")]
	private static extern int OBAFNKGCMGH();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72CE610", Offset = "0x72CD610", VA = "0x1872CE610")]
	private static extern int ANFHDHKPOPH(int OACHBLHDAOM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72CECA0", Offset = "0x72CDCA0", VA = "0x1872CECA0")]
	private static extern int PFEFBDBIAKB(int OACHBLHDAOM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72CEA20", Offset = "0x72CDA20", VA = "0x1872CEA20")]
	private static extern int ODAOMAHPAHP(int OACHBLHDAOM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72CE930", Offset = "0x72CD930", VA = "0x1872CE930")]
	private static extern int NFHGDOIHIGA(int OACHBLHDAOM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72CED20", Offset = "0x72CDD20", VA = "0x1872CED20")]
	public OJFLOLCPJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72CE720", Offset = "0x72CD720", VA = "0x1872CE720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72CEAA0", Offset = "0x72CDAA0", VA = "0x1872CEAA0")]
	public Rect OIFENHJKGKP(int FBINFPAONHB)
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
