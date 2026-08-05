using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GKMCEAOFIOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum OIAKELPOOOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void EDGLCHDICAO(IntPtr NEMAHPGAGLG, int IBMHAIHIDJJ, int JPBMJBFDLKM);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KPFFEHHAPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72B7160", Offset = "0x72B5760", VA = "0x1872B7160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72B71D0", Offset = "0x72B57D0", VA = "0x1872B71D0")]
	private static extern void JFOFPOEMNJG(EDGLCHDICAO IJCKFHFIADK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72B6C10", Offset = "0x72B5210", VA = "0x1872B6C10")]
	[MonoPInvokeCallback(typeof(EDGLCHDICAO))]
	private static void ANMJGAHENJF(IntPtr NEMAHPGAGLG, int IBMHAIHIDJJ, int JPBMJBFDLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72B70F0", Offset = "0x72B56F0", VA = "0x1872B70F0")]
	private static extern void HPHCPPKCEKM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72B6F80", Offset = "0x72B5580", VA = "0x1872B6F80")]
	private static extern void OBLKKOPGALD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72B7160", Offset = "0x72B5760", VA = "0x1872B7160")]
	private static extern int JHEELJOMPEM();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72B6FF0", Offset = "0x72B55F0", VA = "0x1872B6FF0")]
	private static extern int FFEMBPFDOND(int KGHCKLKGJKM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72B7260", Offset = "0x72B5860", VA = "0x1872B7260")]
	private static extern int LAPJACPKNOH(int KGHCKLKGJKM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72B6D10", Offset = "0x72B5310", VA = "0x1872B6D10")]
	private static extern int DHLGOPKKCFN(int KGHCKLKGJKM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72B7070", Offset = "0x72B5670", VA = "0x1872B7070")]
	private static extern int GDCIPEPFAFD(int KGHCKLKGJKM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72B72E0", Offset = "0x72B58E0", VA = "0x1872B72E0")]
	public GKMCEAOFIOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72B6F80", Offset = "0x72B5580", VA = "0x1872B6F80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72B6D90", Offset = "0x72B5390", VA = "0x1872B6D90")]
	public Rect DKBAPEIJNNJ(int BCGKGAJMHAE)
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
