using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HNIADNGFNJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum MKBPPHOBNCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void HGFBAMAELPE(IntPtr DAFMLJPHFGN, int AGHIAPEPFJE, int EGIJFHMEJOH);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CFCCGGNHMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6279740", Offset = "0x6278940", VA = "0x186279740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x62797B0", Offset = "0x62789B0", VA = "0x1862797B0")]
	private static extern void JFNNGNNPIOG(HGFBAMAELPE GPGHCLCHGND);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6279840", Offset = "0x6278A40", VA = "0x186279840")]
	[MonoPInvokeCallback(typeof(HGFBAMAELPE))]
	private static void JGGBCECLOCH(IntPtr DAFMLJPHFGN, int AGHIAPEPFJE, int EGIJFHMEJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6279560", Offset = "0x6278760", VA = "0x186279560")]
	private static extern void CNOOLEDIEBH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x62795D0", Offset = "0x62787D0", VA = "0x1862795D0")]
	private static extern void ILAOAINHPEF();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6279740", Offset = "0x6278940", VA = "0x186279740")]
	private static extern int ONBOKLGFMHE();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6279460", Offset = "0x6278660", VA = "0x186279460")]
	private static extern int BIMCHJIAAJE(int IFAFPBGLEJO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x62796C0", Offset = "0x62788C0", VA = "0x1862796C0")]
	private static extern int HOEBKKMKLIF(int IFAFPBGLEJO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x62794E0", Offset = "0x62786E0", VA = "0x1862794E0")]
	private static extern int CBEAKPAKBEH(int IFAFPBGLEJO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6279640", Offset = "0x6278840", VA = "0x186279640")]
	private static extern int HHGMMFNKNCD(int IFAFPBGLEJO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6279940", Offset = "0x6278B40", VA = "0x186279940")]
	public HNIADNGFNJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62795D0", Offset = "0x62787D0", VA = "0x1862795D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6279270", Offset = "0x6278470", VA = "0x186279270")]
	public Rect AAKHCJMEJEO(int COFIGBEBIIL)
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
