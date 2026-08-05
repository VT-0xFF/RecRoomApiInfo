using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CBENEMJHJGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum PNDEMAOECCM
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void DMBBPJGGMMJ(IntPtr OHNONCFAIKH, int DFCCCGNJINK, int AHEMHOOHKCN);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LJHBEPIMPGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7DF19D0", Offset = "0x7DF07D0", VA = "0x187DF19D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1760", Offset = "0x7DF0560", VA = "0x187DF1760")]
	private static extern void ABHAADAMGPM(DMBBPJGGMMJ JCDKDANAIEK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1C30", Offset = "0x7DF0A30", VA = "0x187DF1C30")]
	[MonoPInvokeCallback(typeof(DMBBPJGGMMJ))]
	private static void LLHAFOPPJNH(IntPtr OHNONCFAIKH, int DFCCCGNJINK, int AHEMHOOHKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7DF18F0", Offset = "0x7DF06F0", VA = "0x187DF18F0")]
	private static extern void DGPDNICIDDD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1960", Offset = "0x7DF0760", VA = "0x187DF1960")]
	private static extern void OFLFEIEDALM();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7DF19D0", Offset = "0x7DF07D0", VA = "0x187DF19D0")]
	private static extern int EBPNJMFJCMP();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7DF17F0", Offset = "0x7DF05F0", VA = "0x187DF17F0")]
	private static extern int AOJGHAOHOKN(int PPPFBKMGIMA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1870", Offset = "0x7DF0670", VA = "0x187DF1870")]
	private static extern int AOPAMCIKHIL(int PPPFBKMGIMA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1D30", Offset = "0x7DF0B30", VA = "0x187DF1D30")]
	private static extern int NEMMOFBHCOL(int PPPFBKMGIMA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1DB0", Offset = "0x7DF0BB0", VA = "0x187DF1DB0")]
	private static extern int OPAMJAGMCPA(int PPPFBKMGIMA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1E30", Offset = "0x7DF0C30", VA = "0x187DF1E30")]
	public CBENEMJHJGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1960", Offset = "0x7DF0760", VA = "0x187DF1960", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1A40", Offset = "0x7DF0840", VA = "0x187DF1A40")]
	public Rect GPPFBHBEKCM(int HKHILKJPDPB)
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
