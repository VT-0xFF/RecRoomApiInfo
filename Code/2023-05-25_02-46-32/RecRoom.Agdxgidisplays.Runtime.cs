using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DAKEMDANIKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum FNAFOELCJEH
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void OJENLNJOAGC(IntPtr PAJPFFIMEFB, int GEFPLPIBMGI, int FJILHGIMMHO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OONPEGAGHPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1692A00", Offset = "0x1691200", VA = "0x181692A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1692DE0", Offset = "0x16915E0", VA = "0x181692DE0")]
	private static extern void OPKOIFPIAAB(OJENLNJOAGC IACLOIAOHJF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1692850", Offset = "0x1691050", VA = "0x181692850")]
	[MonoPInvokeCallback(typeof(OJENLNJOAGC))]
	private static void BIIMAHFEKEP(IntPtr PAJPFFIMEFB, int GEFPLPIBMGI, int FJILHGIMMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1692E70", Offset = "0x1691670", VA = "0x181692E70")]
	private static extern void PBAELFIBGFO();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1692A70", Offset = "0x1691270", VA = "0x181692A70")]
	private static extern void OPOPNKAINMF();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1692A00", Offset = "0x1691200", VA = "0x181692A00")]
	private static extern int DBLMDGJKPCL();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1692CE0", Offset = "0x16914E0", VA = "0x181692CE0")]
	private static extern int HHBNMBAOACI(int EDPPELMHBFA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x16927D0", Offset = "0x1690FD0", VA = "0x1816927D0")]
	private static extern int ACOEKHBCEDN(int EDPPELMHBFA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1692D60", Offset = "0x1691560", VA = "0x181692D60")]
	private static extern int OBCOOMCDNDL(int EDPPELMHBFA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1692980", Offset = "0x1691180", VA = "0x181692980")]
	private static extern int CDOICAGBJKI(int EDPPELMHBFA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1692EE0", Offset = "0x16916E0", VA = "0x181692EE0")]
	public DAKEMDANIKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1692A70", Offset = "0x1691270", VA = "0x181692A70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1692AE0", Offset = "0x16912E0", VA = "0x181692AE0")]
	public Rect FGNBOJOAPKK(int DCNHFOFLMMM)
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
