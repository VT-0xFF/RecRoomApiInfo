using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EFBGMEKNCEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum DDPEEHGPGHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void DGCCDLOPKNN(IntPtr IHHJPAMNDBP, int MPLHLKNKHIM, int FBNBNPHNAHO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NBJFGDJFJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A11B60", Offset = "0x6A10560", VA = "0x186A11B60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A11FC0", Offset = "0x6A109C0", VA = "0x186A11FC0")]
	private static extern void LFFGKEOPCKC(DGCCDLOPKNN DKOPNCNMOIF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A11C50", Offset = "0x6A10650", VA = "0x186A11C50")]
	[MonoPInvokeCallback(typeof(DGCCDLOPKNN))]
	private static void GJMLOENLPPM(IntPtr IHHJPAMNDBP, int MPLHLKNKHIM, int FBNBNPHNAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A12050", Offset = "0x6A10A50", VA = "0x186A12050")]
	private static extern void PCEEADECCDH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A11A70", Offset = "0x6A10470", VA = "0x186A11A70")]
	private static extern void KADMJLGBLIA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A11B60", Offset = "0x6A10560", VA = "0x186A11B60")]
	private static extern int FEKJCPFHHNM();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A11AE0", Offset = "0x6A104E0", VA = "0x186A11AE0")]
	private static extern int EKMOGCJIMEN(int KFBALBFDDFF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A11D50", Offset = "0x6A10750", VA = "0x186A11D50")]
	private static extern int HEHEDLMNPOI(int KFBALBFDDFF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A119F0", Offset = "0x6A103F0", VA = "0x186A119F0")]
	private static extern int BELMADDPHME(int KFBALBFDDFF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A11BD0", Offset = "0x6A105D0", VA = "0x186A11BD0")]
	private static extern int GHCFNELOEPL(int KFBALBFDDFF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A120C0", Offset = "0x6A10AC0", VA = "0x186A120C0")]
	public EFBGMEKNCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A11A70", Offset = "0x6A10470", VA = "0x186A11A70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A11DD0", Offset = "0x6A107D0", VA = "0x186A11DD0")]
	public Rect KHCLKLDPJGB(int EPBIMCAFEOA)
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
