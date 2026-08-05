using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OMEKAHHJOLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum OFPPMOGIOBH
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void GGBAGAFCOIB(IntPtr GOAJPHFIKLF, int DDIMFHFNGHG, int FELICCCCNKC);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DJFAPKGMHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E930A0", Offset = "0x5E91AA0", VA = "0x185E930A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E93660", Offset = "0x5E92060", VA = "0x185E93660")]
	private static extern void OBPIKDOEKOB(GGBAGAFCOIB MKEOIOPNPIL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E934E0", Offset = "0x5E91EE0", VA = "0x185E934E0")]
	[MonoPInvokeCallback(typeof(GGBAGAFCOIB))]
	private static void NCDMAHKJKIP(IntPtr GOAJPHFIKLF, int DDIMFHFNGHG, int FELICCCCNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E93200", Offset = "0x5E91C00", VA = "0x185E93200")]
	private static extern void IAMMEFBKIFH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E93110", Offset = "0x5E91B10", VA = "0x185E93110")]
	private static extern void GCINHCCGNNJ();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E930A0", Offset = "0x5E91AA0", VA = "0x185E930A0")]
	private static extern int BGAFKKABAAJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E935E0", Offset = "0x5E91FE0", VA = "0x185E935E0")]
	private static extern int NNACHJFAAGI(int KABOEEEDCAB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E93180", Offset = "0x5E91B80", VA = "0x185E93180")]
	private static extern int HEOBCMHFEJO(int KABOEEEDCAB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E93020", Offset = "0x5E91A20", VA = "0x185E93020")]
	private static extern int BEIFFBCJBDB(int KABOEEEDCAB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E93460", Offset = "0x5E91E60", VA = "0x185E93460")]
	private static extern int MFAGEABGGLF(int KABOEEEDCAB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E936F0", Offset = "0x5E920F0", VA = "0x185E936F0")]
	public OMEKAHHJOLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E93110", Offset = "0x5E91B10", VA = "0x185E93110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E93270", Offset = "0x5E91C70", VA = "0x185E93270")]
	public Rect IJDNAGNICOG(int HDLGJOLHONK)
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
