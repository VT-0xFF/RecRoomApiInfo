using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MJMCBJDEMFF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DHPKBHAFIMD DNFMPJFHKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	DHPKBHAFIMD HFACHMKAPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DHPKBHAFIMD EKLGLOADPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BNBPKGKDKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PFAJNJNCBLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OPGJILMPEBL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	ECOBBIEENFC.CGEEIAJOLFB EJEOIOAPINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float BPCPAHJMCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MLCOCDFAJPL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FIJDAMFBHGA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OPGJILMPEBL IFGGAECBMFJ(ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OPGJILMPEBL JFAAAFCPGAE(float OPFFMGBDJEC, ECOBBIEENFC.CGEEIAJOLFB GPGAEHMOJKB = ECOBBIEENFC.CGEEIAJOLFB.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OPGJILMPEBL JJKPHDLINAG(Func<bool> OOKPGPEBHEP);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CEBFEHDFGNN
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PFAJNJNCBLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PMAFHAMHOLN Run(IEnumerator<OPGJILMPEBL> INNGNJMMCOM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PMAFHAMHOLN Run(Behaviour PFCNEODPHJH, IEnumerator<OPGJILMPEBL> INNGNJMMCOM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PMAFHAMHOLN : EGOMDMLEOFB, JFNFLBIAFDM, IEnumerator, OPGJILMPEBL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GOFODDKFNGM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float FDPONHBFKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float DPPEAMGLCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double KFBDLBLPFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ECOBBIEENFC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[MPFJFHKJIIG]
	public enum CGEEIAJOLFB
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		PreRender,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		EndOfFrame
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BHHJNPMBFDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JFNFLBIAFDM promise;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
		public BHHJNPMBFDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x450D470", Offset = "0x450BC70", VA = "0x18450D470")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static FIJDAMFBHGA FFBLDPDNMAG;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<FIJDAMFBHGA> HMNAPPDBPPD;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static GOFODDKFNGM PBDHFAGMBFJ;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<GOFODDKFNGM> GAACFMLFMDF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static FIJDAMFBHGA DMJLIJMHIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x450D580", Offset = "0x450BD80", VA = "0x18450D580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static GOFODDKFNGM KMDDEMKJLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x450E480", Offset = "0x450CC80", VA = "0x18450E480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static OPGJILMPEBL IFGGAECBMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x450E090", Offset = "0x450C890", VA = "0x18450E090")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x450DCF0", Offset = "0x450C4F0", VA = "0x18450DCF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static OPGJILMPEBL BPACDDKLOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x450D520", Offset = "0x450BD20", VA = "0x18450D520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x450DC30", Offset = "0x450C430", VA = "0x18450DC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static OPGJILMPEBL IOBANFBCDGD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x450DFA0", Offset = "0x450C7A0", VA = "0x18450DFA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x450DC90", Offset = "0x450C490", VA = "0x18450DC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static OPGJILMPEBL FBFEDLJIEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x450E3C0", Offset = "0x450CBC0", VA = "0x18450E3C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x450E4E0", Offset = "0x450CCE0", VA = "0x18450E4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static OPGJILMPEBL MKIDNCMPGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x450E420", Offset = "0x450CC20", VA = "0x18450E420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x450D5E0", Offset = "0x450BDE0", VA = "0x18450D5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x450E000", Offset = "0x450C800", VA = "0x18450E000")]
	public static void IHPCIIDGGGF(FIJDAMFBHGA PLKNJGBMACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x450DD50", Offset = "0x450C550", VA = "0x18450DD50")]
	public static void GPBEPFPCDKB(GOFODDKFNGM CDOFKDAMMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x450D640", Offset = "0x450BE40", VA = "0x18450D640")]
	private static void DEKGFEPCDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x450E0F0", Offset = "0x450C8F0", VA = "0x18450E0F0")]
	public static OPGJILMPEBL JFAAAFCPGAE(float OPFFMGBDJEC, CGEEIAJOLFB GPGAEHMOJKB = CGEEIAJOLFB.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x450E2F0", Offset = "0x450CAF0", VA = "0x18450E2F0")]
	public static OPGJILMPEBL JMDKOBBOJGE(float OPFFMGBDJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x450E1C0", Offset = "0x450C9C0", VA = "0x18450E1C0")]
	public static OPGJILMPEBL JJKPHDLINAG(Func<bool> OOKPGPEBHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x450DDE0", Offset = "0x450C5E0", VA = "0x18450DDE0")]
	public static OPGJILMPEBL HBGGLDCPOAF(JFNFLBIAFDM JCFDMLOHLFH)
	{
		return null;
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
