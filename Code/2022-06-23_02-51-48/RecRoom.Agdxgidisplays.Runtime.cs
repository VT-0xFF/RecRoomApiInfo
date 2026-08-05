using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LHIIOBJJGAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum JEDBBINMCDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void AACHPKFHAIP(IntPtr JENMNBIOPFE, int GKFHLIDAILA, int PIMPIDDAFMN);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JGKCDEEHDFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4FF5B60", Offset = "0x4FF4D60", VA = "0x184FF5B60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5DC0", Offset = "0x4FF4FC0", VA = "0x184FF5DC0")]
	private static extern void OOGCODOCEKJ(AACHPKFHAIP KMEGFPKBBHD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4FF59D0", Offset = "0x4FF4BD0", VA = "0x184FF59D0")]
	[MonoPInvokeCallback(typeof(AACHPKFHAIP))]
	private static void DIDFCALCGJA(IntPtr JENMNBIOPFE, int GKFHLIDAILA, int PIMPIDDAFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5C50", Offset = "0x4FF4E50", VA = "0x184FF5C50")]
	private static extern void GDDEOJNJOEM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5AF0", Offset = "0x4FF4CF0", VA = "0x184FF5AF0")]
	private static extern void FEFDCPBLBAF();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5B60", Offset = "0x4FF4D60", VA = "0x184FF5B60")]
	private static extern int FIFGOPAJEPA();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5D40", Offset = "0x4FF4F40", VA = "0x184FF5D40")]
	private static extern int MHOBHIBLKFP(int HAMKLMCJFNP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5950", Offset = "0x4FF4B50", VA = "0x184FF5950")]
	private static extern int CALCHEMPNND(int HAMKLMCJFNP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5BD0", Offset = "0x4FF4DD0", VA = "0x184FF5BD0")]
	private static extern int FNOJGLMJJCC(int HAMKLMCJFNP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5CC0", Offset = "0x4FF4EC0", VA = "0x184FF5CC0")]
	private static extern int JHBMDDLBIHK(int HAMKLMCJFNP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5E50", Offset = "0x4FF5050", VA = "0x184FF5E50")]
	public LHIIOBJJGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5AF0", Offset = "0x4FF4CF0", VA = "0x184FF5AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5760", Offset = "0x4FF4960", VA = "0x184FF5760")]
	public Rect BFDJOBICKJI(int OEBGFMFKCNO)
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
