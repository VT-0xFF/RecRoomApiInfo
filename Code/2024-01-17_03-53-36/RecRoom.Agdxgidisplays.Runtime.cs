using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NKHNDFLFCCP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum PAHJNKDCHOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void ELPEAEGBPME(IntPtr NNOFNOIFPML, int GENDLFFGOMM, int GIMFMNIAIMB);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BCIAPEGCOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E93F10", Offset = "0x5E92D10", VA = "0x185E93F10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E941F0", Offset = "0x5E92FF0", VA = "0x185E941F0")]
	private static extern void NJEOAJHFAIL(ELPEAEGBPME EAGOMMNFHFH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E93FF0", Offset = "0x5E92DF0", VA = "0x185E93FF0")]
	[MonoPInvokeCallback(typeof(ELPEAEGBPME))]
	private static void FAOHHOIMFLC(IntPtr NNOFNOIFPML, int GENDLFFGOMM, int GIMFMNIAIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E93EA0", Offset = "0x5E92CA0", VA = "0x185E93EA0")]
	private static extern void CGDOOEBPPMG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E93F80", Offset = "0x5E92D80", VA = "0x185E93F80")]
	private static extern void NMEMHGPPIFJ();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E93F10", Offset = "0x5E92D10", VA = "0x185E93F10")]
	private static extern int CJFPFNPACMJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E94170", Offset = "0x5E92F70", VA = "0x185E94170")]
	private static extern int MILKMHBFJFB(int JDEPDKNELPP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E94280", Offset = "0x5E93080", VA = "0x185E94280")]
	private static extern int OPCDHOMLHBD(int JDEPDKNELPP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E940F0", Offset = "0x5E92EF0", VA = "0x185E940F0")]
	private static extern int GPDDOGAMJAJ(int JDEPDKNELPP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E93E20", Offset = "0x5E92C20", VA = "0x185E93E20")]
	private static extern int CEHKJKLDPHF(int JDEPDKNELPP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E94300", Offset = "0x5E93100", VA = "0x185E94300")]
	public NKHNDFLFCCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E93F80", Offset = "0x5E92D80", VA = "0x185E93F80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E93C30", Offset = "0x5E92A30", VA = "0x185E93C30")]
	public Rect AEHKLLHDKJD(int NCJLNONECGK)
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
