using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ADNCLODLDGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum LOMODJCHMND
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void ICMJGLBKBCP(IntPtr AJNIDCPPJGC, int JIAHBEIKEJF, int LLIIAEIEHOC);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BFHHANGGCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E5C0", Offset = "0x6F2CDC0", VA = "0x186F2E5C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E820", Offset = "0x6F2D020", VA = "0x186F2E820")]
	private static extern void HJOLJIAHOCL(ICMJGLBKBCP JJFOLBCEJBD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E8B0", Offset = "0x6F2D0B0", VA = "0x186F2E8B0")]
	[MonoPInvokeCallback(typeof(ICMJGLBKBCP))]
	private static void JBEDLHPKKBM(IntPtr AJNIDCPPJGC, int JIAHBEIKEJF, int LLIIAEIEHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E550", Offset = "0x6F2CD50", VA = "0x186F2E550")]
	private static extern void BDCEDMLOOPD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E6B0", Offset = "0x6F2CEB0", VA = "0x186F2E6B0")]
	private static extern void PLGPMOAOFJD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E5C0", Offset = "0x6F2CDC0", VA = "0x186F2E5C0")]
	private static extern int MJKMLODEFME();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E720", Offset = "0x6F2CF20", VA = "0x186F2E720")]
	private static extern int GHINAPBEEEO(int BMKPPKKOMAH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E7A0", Offset = "0x6F2CFA0", VA = "0x186F2E7A0")]
	private static extern int GNIMOBOGAKH(int BMKPPKKOMAH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E630", Offset = "0x6F2CE30", VA = "0x186F2E630")]
	private static extern int DOLJFOIMFNB(int BMKPPKKOMAH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F2EBE0", Offset = "0x6F2D3E0", VA = "0x186F2EBE0")]
	private static extern int KPKJJGIKOJC(int BMKPPKKOMAH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F2EC60", Offset = "0x6F2D460", VA = "0x186F2EC60")]
	public ADNCLODLDGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E6B0", Offset = "0x6F2CEB0", VA = "0x186F2E6B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E9E0", Offset = "0x6F2D1E0", VA = "0x186F2E9E0")]
	public Rect JIMFPHKFACN(int KBIPDMDPPOH)
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
