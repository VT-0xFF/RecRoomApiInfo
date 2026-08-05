using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LKFAIONCHCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum HOPEBKCPOFN
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void HNPIJPGPLAN(IntPtr BDKDFPBHDIC, int DKMFLNHKFDF, int KMABBNKEMPC);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EELLOBIJKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1480", Offset = "0x5FF0680", VA = "0x185FF1480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FF13F0", Offset = "0x5FF05F0", VA = "0x185FF13F0")]
	private static extern void BPNHLFIKCAO(HNPIJPGPLAN FPMNHFJNBFL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FF16E0", Offset = "0x5FF08E0", VA = "0x185FF16E0")]
	[MonoPInvokeCallback(typeof(HNPIJPGPLAN))]
	private static void DOKBLFLEPGC(IntPtr BDKDFPBHDIC, int DKMFLNHKFDF, int KMABBNKEMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1300", Offset = "0x5FF0500", VA = "0x185FF1300")]
	private static extern void AKCGAJHNOGB();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FF17E0", Offset = "0x5FF09E0", VA = "0x185FF17E0")]
	private static extern void PKAHBGNHIKB();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1480", Offset = "0x5FF0680", VA = "0x185FF1480")]
	private static extern int GKHLFNODGKO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5FF18D0", Offset = "0x5FF0AD0", VA = "0x185FF18D0")]
	private static extern int JEPMMIDGNCD(int EOHPLEHPKEN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1950", Offset = "0x5FF0B50", VA = "0x185FF1950")]
	private static extern int KIMFMAFOLHE(int EOHPLEHPKEN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1370", Offset = "0x5FF0570", VA = "0x185FF1370")]
	private static extern int BEPCLCOEPAJ(int EOHPLEHPKEN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1850", Offset = "0x5FF0A50", VA = "0x185FF1850")]
	private static extern int IDOHMAHDPDD(int EOHPLEHPKEN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5FF19D0", Offset = "0x5FF0BD0", VA = "0x185FF19D0")]
	public LKFAIONCHCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5FF17E0", Offset = "0x5FF09E0", VA = "0x185FF17E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FF14F0", Offset = "0x5FF06F0", VA = "0x185FF14F0")]
	public Rect CKHLEBNKILI(int MJEHANIDKKI)
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
