using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class IHKFEJFHFMO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum EKEONCDIEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void EFLBLINBMFH(IntPtr MLHMNLDOBPP, int JKNAAACFMKJ, int FHHKHIKBBMN);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LMLLHPMMJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5CE0", Offset = "0x5FC48E0", VA = "0x185FC5CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5700", Offset = "0x5FC4300", VA = "0x185FC5700")]
	private static extern void ALCNDKCPHAA(EFLBLINBMFH NLOLPKLGIBB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5BE0", Offset = "0x5FC47E0", VA = "0x185FC5BE0")]
	[MonoPInvokeCallback(typeof(EFLBLINBMFH))]
	private static void JADKOIMJBCE(IntPtr MLHMNLDOBPP, int JKNAAACFMKJ, int FHHKHIKBBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5980", Offset = "0x5FC4580", VA = "0x185FC5980")]
	private static extern void HAJAGMDCLHL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5890", Offset = "0x5FC4490", VA = "0x185FC5890")]
	private static extern void DNAOLGBBEEM();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5CE0", Offset = "0x5FC48E0", VA = "0x185FC5CE0")]
	private static extern int KEMPFCPNAGL();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5810", Offset = "0x5FC4410", VA = "0x185FC5810")]
	private static extern int BGHHFOMHCOC(int JPCJHDLLDBJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5900", Offset = "0x5FC4500", VA = "0x185FC5900")]
	private static extern int FLPFNLFFKKE(int JPCJHDLLDBJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5790", Offset = "0x5FC4390", VA = "0x185FC5790")]
	private static extern int BEOJNKAOIGM(int JPCJHDLLDBJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5D50", Offset = "0x5FC4950", VA = "0x185FC5D50")]
	private static extern int PFJKJLMNKEB(int JPCJHDLLDBJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5DD0", Offset = "0x5FC49D0", VA = "0x185FC5DD0")]
	public IHKFEJFHFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5890", Offset = "0x5FC4490", VA = "0x185FC5890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FC59F0", Offset = "0x5FC45F0", VA = "0x185FC59F0")]
	public Rect INAGIGEGHCP(int JHGHFCHACBN)
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
