using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NBCPMLKJJLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum GGIOHJNDDEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void KFBOHCBMMKA(IntPtr MGDDHKPDDMF, int MBCLCCPKDLG, int GFBBIBKEHHO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GDMFDCCMEML
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6641630", Offset = "0x6640430", VA = "0x186641630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6641BA0", Offset = "0x66409A0", VA = "0x186641BA0")]
	private static extern void KOCKBPFHKMN(KFBOHCBMMKA JDLJMIHPPKE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6641980", Offset = "0x6640780", VA = "0x186641980")]
	[MonoPInvokeCallback(typeof(KFBOHCBMMKA))]
	private static void EBHBMHKBGIK(IntPtr MGDDHKPDDMF, int MBCLCCPKDLG, int GFBBIBKEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6641AB0", Offset = "0x66408B0", VA = "0x186641AB0")]
	private static extern void GIHONBOCKDC();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6641910", Offset = "0x6640710", VA = "0x186641910")]
	private static extern void JJFFABMPLGP();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6641630", Offset = "0x6640430", VA = "0x186641630")]
	private static extern int MGJNGGKBLDB();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6641CB0", Offset = "0x6640AB0", VA = "0x186641CB0")]
	private static extern int PPMHFKIOBIH(int NEMDNBLCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6641C30", Offset = "0x6640A30", VA = "0x186641C30")]
	private static extern int NAFFAIMLAFP(int NEMDNBLCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x66416A0", Offset = "0x66404A0", VA = "0x1866416A0")]
	private static extern int AMGECGMHFFJ(int NEMDNBLCKKH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6641B20", Offset = "0x6640920", VA = "0x186641B20")]
	private static extern int JJNGBEOCMMK(int NEMDNBLCKKH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6641D30", Offset = "0x6640B30", VA = "0x186641D30")]
	public NBCPMLKJJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6641910", Offset = "0x6640710", VA = "0x186641910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6641720", Offset = "0x6640520", VA = "0x186641720")]
	public Rect CEAONGPINGK(int HCJEOPGDADN)
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
