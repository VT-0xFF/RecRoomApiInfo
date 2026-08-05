using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MMHNCOPJFFL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KMLGIDFAPCN(string DOGOCHIINFI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DNKAAEJJKLI(string DOGOCHIINFI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum EILGOOJKBJK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class INIMOJNKOEG : MMHNCOPJFFL
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> HEAGNDNGMAF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] BFDCDHCNOMG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] HCLLCEOLCAF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] JGNDAMELGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6208FF0", Offset = "0x6207FF0", VA = "0x186208FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] AIMMGFGCHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6209000", Offset = "0x6208000", VA = "0x186209000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x62092F0", Offset = "0x62082F0", VA = "0x1862092F0")]
	[ILJDPBHFAFI(ENLFMENACGP.Root, DIDBPCEENMM.GameOnly)]
	private static void LJGEHEAHHOL(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6208E30", Offset = "0x6207E30", VA = "0x186208E30")]
	internal static string[] DDPIGNBLKJN(string[] ALMMGCCBDJL, string[] DBCHJDCAPBM, List<string> GOFACMOMLMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6209250", Offset = "0x6208250", VA = "0x186209250", Slot = "4")]
	private string LHDKCPOAJMD(string DOGOCHIINFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x62091B0", Offset = "0x62081B0", VA = "0x1862091B0")]
	public static string KMLGIDFAPCN(string DOGOCHIINFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x62093F0", Offset = "0x62083F0", VA = "0x1862093F0", Slot = "5")]
	private bool NDANAFMFMBI(string DOGOCHIINFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6208F50", Offset = "0x6207F50", VA = "0x186208F50")]
	public static bool DNKAAEJJKLI(string DOGOCHIINFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public INIMOJNKOEG()
	{
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
