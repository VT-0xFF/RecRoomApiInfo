using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ADFIGDICAPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum JNGJDNKAIDC
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void AKDNNEAHKPD(IntPtr JNKDPLJLFBG, int IJHNFJCHOAD, int ELKIHDOBIDO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KHODGLDLKKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4DBA4A0", Offset = "0x4DB98A0", VA = "0x184DBA4A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4DBA680", Offset = "0x4DB9A80", VA = "0x184DBA680")]
	private static extern void PGGIFIOAJJH(AKDNNEAHKPD BKKOCCDDHJN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4DBA0A0", Offset = "0x4DB94A0", VA = "0x184DBA0A0")]
	[MonoPInvokeCallback(typeof(AKDNNEAHKPD))]
	private static void AKDPEPPHLNE(IntPtr JNKDPLJLFBG, int IJHNFJCHOAD, int ELKIHDOBIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4DBA510", Offset = "0x4DB9910", VA = "0x184DBA510")]
	private static extern void JBPGKBOBEDK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4DBA240", Offset = "0x4DB9640", VA = "0x184DBA240")]
	private static extern void DGPPCJNOGAH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4DBA4A0", Offset = "0x4DB98A0", VA = "0x184DBA4A0")]
	private static extern int IGIGBGFIPCM();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4DBA580", Offset = "0x4DB9980", VA = "0x184DBA580")]
	private static extern int MEHOOEJOAIE(int MGMHKIPIHKD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4DBA600", Offset = "0x4DB9A00", VA = "0x184DBA600")]
	private static extern int MGIMOKJKLOB(int MGMHKIPIHKD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4DBA1C0", Offset = "0x4DB95C0", VA = "0x184DBA1C0")]
	private static extern int DFOMNMIPBAK(int MGMHKIPIHKD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4DBA020", Offset = "0x4DB9420", VA = "0x184DBA020")]
	private static extern int AFPINBKOEJD(int MGMHKIPIHKD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4DBA710", Offset = "0x4DB9B10", VA = "0x184DBA710")]
	public ADFIGDICAPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4DBA240", Offset = "0x4DB9640", VA = "0x184DBA240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4DBA2B0", Offset = "0x4DB96B0", VA = "0x184DBA2B0")]
	public Rect HPCDNCPCKHO(int GJGODNMDEKC)
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
