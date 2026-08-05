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
		[Cpp2IlInjected.Address(RVA = "0x13A9F20", Offset = "0x13A8B20", VA = "0x1813A9F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x13AA300", Offset = "0x13A8F00", VA = "0x1813AA300")]
	private static extern void OPKOIFPIAAB(OJENLNJOAGC IACLOIAOHJF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x13A9D70", Offset = "0x13A8970", VA = "0x1813A9D70")]
	[MonoPInvokeCallback(typeof(OJENLNJOAGC))]
	private static void BIIMAHFEKEP(IntPtr PAJPFFIMEFB, int GEFPLPIBMGI, int FJILHGIMMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x13AA390", Offset = "0x13A8F90", VA = "0x1813AA390")]
	private static extern void PBAELFIBGFO();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x13A9F90", Offset = "0x13A8B90", VA = "0x1813A9F90")]
	private static extern void OPOPNKAINMF();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x13A9F20", Offset = "0x13A8B20", VA = "0x1813A9F20")]
	private static extern int DBLMDGJKPCL();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x13AA200", Offset = "0x13A8E00", VA = "0x1813AA200")]
	private static extern int HHBNMBAOACI(int EDPPELMHBFA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x13A9CF0", Offset = "0x13A88F0", VA = "0x1813A9CF0")]
	private static extern int ACOEKHBCEDN(int EDPPELMHBFA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x13AA280", Offset = "0x13A8E80", VA = "0x1813AA280")]
	private static extern int OBCOOMCDNDL(int EDPPELMHBFA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x13A9EA0", Offset = "0x13A8AA0", VA = "0x1813A9EA0")]
	private static extern int CDOICAGBJKI(int EDPPELMHBFA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x13AA400", Offset = "0x13A9000", VA = "0x1813AA400")]
	public DAKEMDANIKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x13A9F90", Offset = "0x13A8B90", VA = "0x1813A9F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x13AA000", Offset = "0x13A8C00", VA = "0x1813AA000")]
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
