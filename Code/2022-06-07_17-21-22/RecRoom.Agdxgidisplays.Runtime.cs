using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HJIHAELMLCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum CFLNHKBBPGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void AIPMAAAKEOM(IntPtr ANHMAOHNMJC, int DDMFGCPNLGN, int PINBJPPFECI);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PKPHANGNLCF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4F051F0", Offset = "0x4F039F0", VA = "0x184F051F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4F04F80", Offset = "0x4F03780", VA = "0x184F04F80")]
	private static extern void APACECMACEP(AIPMAAAKEOM IJOJDDBGAPC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4F05550", Offset = "0x4F03D50", VA = "0x184F05550")]
	[MonoPInvokeCallback(typeof(AIPMAAAKEOM))]
	private static void PJJHBEINLCH(IntPtr ANHMAOHNMJC, int DDMFGCPNLGN, int PINBJPPFECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4F05180", Offset = "0x4F03980", VA = "0x184F05180")]
	private static extern void EMFGCIHFDBD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4F05090", Offset = "0x4F03890", VA = "0x184F05090")]
	private static extern void JOCOGJJNCAL();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4F051F0", Offset = "0x4F039F0", VA = "0x184F051F0")]
	private static extern int OLPNOHHMPDN();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4F05260", Offset = "0x4F03A60", VA = "0x184F05260")]
	private static extern int GHNIDOKIGIN(int DDEJHPOCOHL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4F052E0", Offset = "0x4F03AE0", VA = "0x184F052E0")]
	private static extern int GJIBANGCKDL(int DDEJHPOCOHL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4F05010", Offset = "0x4F03810", VA = "0x184F05010")]
	private static extern int DHBBILEMNHJ(int DDEJHPOCOHL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4F05100", Offset = "0x4F03900", VA = "0x184F05100")]
	private static extern int EGEGKNENNEB(int DDEJHPOCOHL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4F05670", Offset = "0x4F03E70", VA = "0x184F05670")]
	public HJIHAELMLCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4F05090", Offset = "0x4F03890", VA = "0x184F05090", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4F05360", Offset = "0x4F03B60", VA = "0x184F05360")]
	public Rect OIEDFOICELF(int BPFGLODNGKJ)
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
