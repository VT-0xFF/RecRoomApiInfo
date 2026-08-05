using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class IDCLNFPGCMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum ANJPHFHBIOH
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void NEIGENBECJE(IntPtr KJIGJPAKKLM, int OOJNMIFKLKI, int EMLEANMOKAN);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GEKEJMOFFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x10FFAC0", Offset = "0x10FE4C0", VA = "0x1810FFAC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x10FFFB0", Offset = "0x10FE9B0", VA = "0x1810FFFB0")]
	private static extern void ODNAPPPBKFM(NEIGENBECJE OPOGBFLEIMD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x10FFCA0", Offset = "0x10FE6A0", VA = "0x1810FFCA0")]
	[MonoPInvokeCallback(typeof(NEIGENBECJE))]
	private static void JJGBEOKJOJO(IntPtr KJIGJPAKKLM, int OOJNMIFKLKI, int EMLEANMOKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x11000C0", Offset = "0x10FEAC0", VA = "0x1811000C0")]
	private static extern void OFPKKKHDKOD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x10FFB30", Offset = "0x10FE530", VA = "0x1810FFB30")]
	private static extern void BDNOCEMNAMK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x10FFAC0", Offset = "0x10FE4C0", VA = "0x1810FFAC0")]
	private static extern int APMCNKPBAKH();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1100040", Offset = "0x10FEA40", VA = "0x181100040")]
	private static extern int OEPHMMEIAMD(int EKIIKIKCLJI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x10FFBA0", Offset = "0x10FE5A0", VA = "0x1810FFBA0")]
	private static extern int HOMONIPJGEA(int EKIIKIKCLJI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x10FFA40", Offset = "0x10FE440", VA = "0x1810FFA40")]
	private static extern int AIIEIOJIMOG(int EKIIKIKCLJI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x10FFC20", Offset = "0x10FE620", VA = "0x1810FFC20")]
	private static extern int IPHNMNIGBFK(int EKIIKIKCLJI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1100130", Offset = "0x10FEB30", VA = "0x181100130")]
	public IDCLNFPGCMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x10FFB30", Offset = "0x10FE530", VA = "0x1810FFB30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x10FFDC0", Offset = "0x10FE7C0", VA = "0x1810FFDC0")]
	public Rect KMBGIKHHABL(int JJNNPJBLBHG)
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
