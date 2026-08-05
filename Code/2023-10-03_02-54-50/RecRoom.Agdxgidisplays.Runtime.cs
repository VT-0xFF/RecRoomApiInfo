using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BBMEFHGMGGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum DFJAJFABFJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void CAOIFDGJALA(IntPtr FDOGBBKMGKO, int NBNELMONDLK, int IAECFADECND);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LHOIKMEAIGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3030", Offset = "0x5BC1830", VA = "0x185BC3030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3210", Offset = "0x5BC1A10", VA = "0x185BC3210")]
	private static extern void GJLEDEGMHGL(CAOIFDGJALA ELLFKJCIDIE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3320", Offset = "0x5BC1B20", VA = "0x185BC3320")]
	[MonoPInvokeCallback(typeof(CAOIFDGJALA))]
	private static void IMDAPGNPONK(IntPtr FDOGBBKMGKO, int NBNELMONDLK, int IAECFADECND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3690", Offset = "0x5BC1E90", VA = "0x185BC3690")]
	private static extern void MJKJMKCCJMD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3120", Offset = "0x5BC1920", VA = "0x185BC3120")]
	private static extern void ANFJGIFIADM();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3030", Offset = "0x5BC1830", VA = "0x185BC3030")]
	private static extern int CKNMNOOMIPJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5BC30A0", Offset = "0x5BC18A0", VA = "0x185BC30A0")]
	private static extern int AGDAPMDKEGP(int LJHGKCLAIHG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3190", Offset = "0x5BC1990", VA = "0x185BC3190")]
	private static extern int EBMOLDPCDBG(int LJHGKCLAIHG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5BC32A0", Offset = "0x5BC1AA0", VA = "0x185BC32A0")]
	private static extern int HPOMKLHPMCF(int LJHGKCLAIHG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3420", Offset = "0x5BC1C20", VA = "0x185BC3420")]
	private static extern int IPIPKEEKDPB(int LJHGKCLAIHG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3700", Offset = "0x5BC1F00", VA = "0x185BC3700")]
	public BBMEFHGMGGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3120", Offset = "0x5BC1920", VA = "0x185BC3120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5BC34A0", Offset = "0x5BC1CA0", VA = "0x185BC34A0")]
	public Rect LGCJFJKNEGM(int EBJJNMBDBOH)
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
