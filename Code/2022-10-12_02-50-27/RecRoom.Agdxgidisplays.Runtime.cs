using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KJIAPENFNDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum AJJCBKAEJAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void EOFOFOOKHMP(IntPtr ANHHADJHMBE, int FBPAKFCOLHM, int JFOPLPNGBCE);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ODGMHJPAKNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1ED4600", Offset = "0x1ED2E00", VA = "0x181ED4600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1ED4950", Offset = "0x1ED3150", VA = "0x181ED4950")]
	private static extern void FHHGMMKGIMD(EOFOFOOKHMP FNAODFKKBJA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1ED49E0", Offset = "0x1ED31E0", VA = "0x181ED49E0")]
	[MonoPInvokeCallback(typeof(EOFOFOOKHMP))]
	private static void HGODOCOFEEB(IntPtr ANHHADJHMBE, int FBPAKFCOLHM, int JFOPLPNGBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1ED4590", Offset = "0x1ED2D90", VA = "0x181ED4590")]
	private static extern void CDFKCHBFAME();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1ED4670", Offset = "0x1ED2E70", VA = "0x181ED4670")]
	private static extern void OMMHFPDGADL();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1ED4600", Offset = "0x1ED2E00", VA = "0x181ED4600")]
	private static extern int IOJIGECKJKF();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1ED4B90", Offset = "0x1ED3390", VA = "0x181ED4B90")]
	private static extern int OHFPMBHJMBH(int DGFBLJMJMFI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1ED48D0", Offset = "0x1ED30D0", VA = "0x181ED48D0")]
	private static extern int FHBODLAFNOM(int DGFBLJMJMFI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1ED4B10", Offset = "0x1ED3310", VA = "0x181ED4B10")]
	private static extern int JHDOKMCIFOF(int DGFBLJMJMFI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1ED4C10", Offset = "0x1ED3410", VA = "0x181ED4C10")]
	private static extern int PBHFOGHNPHH(int DGFBLJMJMFI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1ED4C90", Offset = "0x1ED3490", VA = "0x181ED4C90")]
	public KJIAPENFNDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1ED4670", Offset = "0x1ED2E70", VA = "0x181ED4670", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1ED46E0", Offset = "0x1ED2EE0", VA = "0x181ED46E0")]
	public Rect FEGBLIFMDBA(int PDBINFECGMC)
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
