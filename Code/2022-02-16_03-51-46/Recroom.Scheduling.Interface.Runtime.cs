using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BOFBKAOKBGK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JCOGEPDMPJF EEMJNCINPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	JCOGEPDMPJF ILCEOPIGBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	JCOGEPDMPJF CLNNALJEJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FDDNHDMEOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JOPGBFCDGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AAPMNJMBGEO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JFFPMPEEBJD.PIDJAKONCNG OCIACKFPAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float DKFELMGFGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NCPDHCMAAIB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ODLMGCEECOG
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AAPMNJMBGEO MNGGIKIBLHH(JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AAPMNJMBGEO FOIKAJKOOGK(float DFNJJNIDPFH, JFFPMPEEBJD.PIDJAKONCNG FEEFFCNAHOA = JFFPMPEEBJD.PIDJAKONCNG.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AAPMNJMBGEO BAKCBFBOBFF(float DFNJJNIDPFH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AAPMNJMBGEO DPBBHMDPBBL(Func<bool> ODJIFODEFBD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GMFIOIJLBAL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool JOPGBFCDGLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JEOMIDCJMHN Run(IEnumerator<AAPMNJMBGEO> EDNDNGDMENI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JEOMIDCJMHN Run(Behaviour OJAOPEPLKMN, IEnumerator<AAPMNJMBGEO> EDNDNGDMENI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JEOMIDCJMHN : OGFAMIOFHHH, LFPFPAAINHE, IEnumerator, AAPMNJMBGEO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EHMBKCMMNDP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float OBEGEBOIBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float IAOFHGFOHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double HFEDDANBICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JFFPMPEEBJD
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[JNPIFCHJLEA]
	public enum PIDJAKONCNG
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
	private sealed class JGNODJGFPKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public LFPFPAAINHE promise;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public JGNODJGFPKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1BC3700", Offset = "0x1BC1F00", VA = "0x181BC3700")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static ODLMGCEECOG EGCDLJHNNNH;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<ODLMGCEECOG> GLMKMNKHMJF;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static EHMBKCMMNDP IMDLLFLPKMF;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<EHMBKCMMNDP> IDNJGBJGPOD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static ODLMGCEECOG PIFIGDDPEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1BC2910", Offset = "0x1BC1110", VA = "0x181BC2910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static EHMBKCMMNDP GGALNJNKLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1BC2610", Offset = "0x1BC0E10", VA = "0x181BC2610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static AAPMNJMBGEO MNGGIKIBLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1BC2CE0", Offset = "0x1BC14E0", VA = "0x181BC2CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1BC35F0", Offset = "0x1BC1DF0", VA = "0x181BC35F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static AAPMNJMBGEO LOLMNADIILK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1BC2780", Offset = "0x1BC0F80", VA = "0x181BC2780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1BC2C70", Offset = "0x1BC1470", VA = "0x181BC2C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static AAPMNJMBGEO PIDOFHBEIEM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1BC3590", Offset = "0x1BC1D90", VA = "0x181BC3590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1BC2DA0", Offset = "0x1BC15A0", VA = "0x181BC2DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static AAPMNJMBGEO BALOGJDAFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1BC2E10", Offset = "0x1BC1610", VA = "0x181BC2E10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1BC2710", Offset = "0x1BC0F10", VA = "0x181BC2710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static AAPMNJMBGEO AGHOJMCJODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1BC2D40", Offset = "0x1BC1540", VA = "0x181BC2D40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1BC25A0", Offset = "0x1BC0DA0", VA = "0x181BC25A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1BC2670", Offset = "0x1BC0E70", VA = "0x181BC2670")]
	public static void CFJDDLKAHCD(ODLMGCEECOG FIAJJBKCNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1BC2E70", Offset = "0x1BC1670", VA = "0x181BC2E70")]
	public static void NDILHCCDHBO(EHMBKCMMNDP NHFEFAJLDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1BC2F10", Offset = "0x1BC1710", VA = "0x181BC2F10")]
	private static void PHGJPKCHNPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1BC2B30", Offset = "0x1BC1330", VA = "0x181BC2B30")]
	public static AAPMNJMBGEO FOIKAJKOOGK(float DFNJJNIDPFH, PIDJAKONCNG FEEFFCNAHOA = PIDJAKONCNG.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1BC2470", Offset = "0x1BC0C70", VA = "0x181BC2470")]
	public static AAPMNJMBGEO BAKCBFBOBFF(float DFNJJNIDPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1BC27E0", Offset = "0x1BC0FE0", VA = "0x181BC27E0")]
	public static AAPMNJMBGEO DPBBHMDPBBL(Func<bool> ODJIFODEFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1BC2970", Offset = "0x1BC1170", VA = "0x181BC2970")]
	public static AAPMNJMBGEO FKABNCOCGFM(LFPFPAAINHE CDJCNKAFMIO)
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
