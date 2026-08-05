using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LDLBIMBONJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum HNEALFIECJP
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void ADMKOHEPEFF(IntPtr EPNHPDGPFKK, int NBGGIOPLKBE, int ACEMENGIBHL);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DKNIOBGLAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1254C90", Offset = "0x1253490", VA = "0x181254C90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1255090", Offset = "0x1253890", VA = "0x181255090")]
	private static extern void PBONKEFNPEH(ADMKOHEPEFF HNMFGPCGPOH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1254D00", Offset = "0x1253500", VA = "0x181254D00")]
	[MonoPInvokeCallback(typeof(ADMKOHEPEFF))]
	private static void JHAPMFMFGFD(IntPtr EPNHPDGPFKK, int NBGGIOPLKBE, int ACEMENGIBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1254A30", Offset = "0x1253230", VA = "0x181254A30")]
	private static extern void CDGCMJJMEMA();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1254B20", Offset = "0x1253320", VA = "0x181254B20")]
	private static extern void IKDJOMJDPLB();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1254C90", Offset = "0x1253490", VA = "0x181254C90")]
	private static extern int HCKJCBBKHPD();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1254AA0", Offset = "0x12532A0", VA = "0x181254AA0")]
	private static extern int DLMOIEMGNED(int BKOGMFPFOOA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1254C10", Offset = "0x1253410", VA = "0x181254C10")]
	private static extern int GOEOAPCGFFE(int BKOGMFPFOOA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1255010", Offset = "0x1253810", VA = "0x181255010")]
	private static extern int OIGJCBHKAHD(int BKOGMFPFOOA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1254B90", Offset = "0x1253390", VA = "0x181254B90")]
	private static extern int FFDHLPKDBGN(int BKOGMFPFOOA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1255120", Offset = "0x1253920", VA = "0x181255120")]
	public LDLBIMBONJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1254B20", Offset = "0x1253320", VA = "0x181254B20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1254E20", Offset = "0x1253620", VA = "0x181254E20")]
	public Rect MLCAPLFAPEJ(int ABEIPENEDKG)
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
