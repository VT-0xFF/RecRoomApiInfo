using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EOABGHLMAII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum BDJCHEBBLIP
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void DIHKAFBDHLN(IntPtr EJJHDDFDLOL, int JGDHMDLNCOL, int MPFKKILGAAL);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ICOLBLFPEHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4EE0", Offset = "0x5BF42E0", VA = "0x185BF4EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5BF50D0", Offset = "0x5BF44D0", VA = "0x185BF50D0")]
	private static extern void LIEFJAEGAMM(DIHKAFBDHLN AIBILCAOCLG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4F50", Offset = "0x5BF4350", VA = "0x185BF4F50")]
	[MonoPInvokeCallback(typeof(DIHKAFBDHLN))]
	private static void HEIBGNADJLO(IntPtr EJJHDDFDLOL, int JGDHMDLNCOL, int MPFKKILGAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5BF5260", Offset = "0x5BF4660", VA = "0x185BF5260")]
	private static extern void OMELHDOHHCI();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4C80", Offset = "0x5BF4080", VA = "0x185BF4C80")]
	private static extern void IHMNJKOHKPG();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4EE0", Offset = "0x5BF42E0", VA = "0x185BF4EE0")]
	private static extern int FNIHPNLGKKI();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5BF5050", Offset = "0x5BF4450", VA = "0x185BF5050")]
	private static extern int IDNJIMLCKGE(int KOJKDECJOKK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4C00", Offset = "0x5BF4000", VA = "0x185BF4C00")]
	private static extern int BOJLPECECEI(int KOJKDECJOKK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5BF5160", Offset = "0x5BF4560", VA = "0x185BF5160")]
	private static extern int NFDDDFACOKP(int KOJKDECJOKK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5BF51E0", Offset = "0x5BF45E0", VA = "0x185BF51E0")]
	private static extern int OJKCGFDHEHL(int KOJKDECJOKK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5BF52D0", Offset = "0x5BF46D0", VA = "0x185BF52D0")]
	public EOABGHLMAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4C80", Offset = "0x5BF4080", VA = "0x185BF4C80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4CF0", Offset = "0x5BF40F0", VA = "0x185BF4CF0")]
	public Rect EOANOPDCLEH(int CIFFLEMHGIG)
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
