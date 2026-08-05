using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MBBEIFLIIKN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MAEEJHBHLJC AHACCIMFGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	MAEEJHBHLJC KHOKHKCJDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MAEEJHBHLJC GLNAMPKOLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MADJCGNNCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GBMMBPDKDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GAGJCGDODGC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GFIGKKNJOIH.OAGKLGIDJML OEFDBJJLHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float NFLFDNIEDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BJKCGKNMDGA();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AOHPGJMACLH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GAGJCGDODGC FAECONBGCBO(GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GAGJCGDODGC FFMJINCILOH(float IDOGEAIEEHG, GFIGKKNJOIH.OAGKLGIDJML JHCFIOBHJPD = GFIGKKNJOIH.OAGKLGIDJML.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GAGJCGDODGC MGAJDNDCHBN(Func<bool> INONAOBJCGH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CDFDGMPDAEL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GBMMBPDKDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BLKCKFJNHGD Run(IEnumerator<GAGJCGDODGC> LCDHEMAOHBE);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BLKCKFJNHGD Run(Behaviour MEFIPNMPAKF, IEnumerator<GAGJCGDODGC> LCDHEMAOHBE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BLKCKFJNHGD : HPCHDIGGLNN, MLALFLMLHEI, IEnumerator, GAGJCGDODGC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BOGJPMPBIMP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float JPBHHHMNFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float KADMIMMNGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double BEGKFIINKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GFIGKKNJOIH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CJPFIGGNBFP]
	public enum OAGKLGIDJML
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
	private sealed class FNHKBFLNCLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public MLALFLMLHEI promise;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
		public FNHKBFLNCLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3F9E580", Offset = "0x3F9D780", VA = "0x183F9E580")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static AOHPGJMACLH OKCMMDEHIEG;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<AOHPGJMACLH> LFALKJOBDOK;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BOGJPMPBIMP EPHIGMNNKIB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<BOGJPMPBIMP> FPLJNPMBDOF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static AOHPGJMACLH BLACLAFINJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3F9EE40", Offset = "0x3F9E040", VA = "0x183F9EE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static BOGJPMPBIMP IGLLANOIGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3F9F460", Offset = "0x3F9E660", VA = "0x183F9F460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static GAGJCGDODGC FAECONBGCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3F9F0F0", Offset = "0x3F9E2F0", VA = "0x183F9F0F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3F9E630", Offset = "0x3F9D830", VA = "0x183F9E630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static GAGJCGDODGC EPEGMHIMKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3F9F4C0", Offset = "0x3F9E6C0", VA = "0x183F9F4C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3F9F400", Offset = "0x3F9E600", VA = "0x183F9F400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static GAGJCGDODGC CHIIOBNCFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3F9F210", Offset = "0x3F9E410", VA = "0x183F9F210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3F9F3A0", Offset = "0x3F9E5A0", VA = "0x183F9F3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static GAGJCGDODGC CCONHPFAJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3F9F1B0", Offset = "0x3F9E3B0", VA = "0x183F9F1B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3F9F150", Offset = "0x3F9E350", VA = "0x183F9F150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static GAGJCGDODGC HBEGBOEOFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3F9EEA0", Offset = "0x3F9E0A0", VA = "0x183F9EEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3F9F5F0", Offset = "0x3F9E7F0", VA = "0x183F9F5F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F060", Offset = "0x3F9E260", VA = "0x183F9F060")]
	public static void GEHKEKFBAGP(AOHPGJMACLH AGGNEKKBJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3F9EFD0", Offset = "0x3F9E1D0", VA = "0x183F9EFD0")]
	public static void FLBAHBBELOB(BOGJPMPBIMP DBECKACJEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3F9E690", Offset = "0x3F9D890", VA = "0x183F9E690")]
	private static void BEOLJHBICAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3F9EF00", Offset = "0x3F9E100", VA = "0x183F9EF00")]
	public static GAGJCGDODGC FFMJINCILOH(float IDOGEAIEEHG, OAGKLGIDJML JHCFIOBHJPD = OAGKLGIDJML.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F520", Offset = "0x3F9E720", VA = "0x183F9F520")]
	public static GAGJCGDODGC ODKEHMDPAFO(float IDOGEAIEEHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F270", Offset = "0x3F9E470", VA = "0x183F9F270")]
	public static GAGJCGDODGC MGAJDNDCHBN(Func<bool> INONAOBJCGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3F9EC80", Offset = "0x3F9DE80", VA = "0x183F9EC80")]
	public static GAGJCGDODGC DHJHOEMIEJI(MLALFLMLHEI BAEPNLBPEOA)
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
