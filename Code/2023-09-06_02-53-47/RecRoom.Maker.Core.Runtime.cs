using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B460", Offset = "0x6F99A60", VA = "0x186F9B460")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x986BA0", Offset = "0x9851A0", VA = "0x180986BA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x11F2200", Offset = "0x11F0800", VA = "0x1811F2200")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1340", Offset = "0x6E0740")]
public class FFKFAOBKLGF<TData> : GPCKIPPOCMK<GKECBANLAMC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly LKHLIEDNHOB JDJIBOIEBLH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x50B28B0", Offset = "0x50B0EB0", VA = "0x1850B28B0")]
	public FFKFAOBKLGF(Vector3 JNJOIMLOINC, bool PIIPBEBIJOD, GKECBANLAMC<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x26360F0", Offset = "0x26346F0", VA = "0x1826360F0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E13B0", Offset = "0x6E07B0")]
public class BBDOOLLKCPM<TSpawnType, TSpawnInfo> : CGNNDDJJHDP<KEBBLMACGHG<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1420", Offset = "0x6E0820")]
	private readonly PDKGGJFMMND<TSpawnInfo> CHPIMGNELOI;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA880", Offset = "0x2FE8E80", VA = "0x182FEA880")]
	public BBDOOLLKCPM(TSpawnInfo DBMNEGKKINF, Vector3 POOFJFBIOJJ, Quaternion MEHKCJCIOOL, float CHAPNJAEPMG, KEBBLMACGHG<TSpawnType, TSpawnInfo> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA310", Offset = "0x2FE8910", VA = "0x182FEA310", Slot = "4")]
	public override Task<TSpawnType> DMAOLGACNOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct NDJDKKMCPBE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public IEnumerable<TData> AEJNMEEBKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public bool HOIFEANCLED;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2783CD0", Offset = "0x27822D0", VA = "0x182783CD0")]
	public NDJDKKMCPBE(IEnumerable<TData> ODOALMAHJOA, bool OKKJDIKACHJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KEAHALGEEKO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOKNMGKBLEC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E14C0", Offset = "0x6E08C0")] in NCDLFPCJAFA<TData?> JJBIDAONJJH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NEPELJIHNOM(in ENMDHKPOIPJ OHKICOIHEHF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NEPELJIHNOM(in AMIIHKEDANA OHKICOIHEHF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NEPELJIHNOM(in NKCNNPEGKIH OHKICOIHEHF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MAHBABHKEAC();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct DGGDPGEFNOC<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TNode ENCGHEGEPFM;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2BD6600", Offset = "0x2BD4C00", VA = "0x182BD6600")]
	public DGGDPGEFNOC(TNode ENCGHEGEPFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FFFHJEKGEPH<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TNode LCHFCPPPBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public EHILAKFDIBP BKDFIECODHK;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x50B04D0", Offset = "0x50AEAD0", VA = "0x1850B04D0")]
	public FFFHJEKGEPH(TNode LCHFCPPPBEK, EHILAKFDIBP BKDFIECODHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1530", Offset = "0x6E0930")]
public class OLOBKNDFADA<TData> : GPCKIPPOCMK<DLLGPELKLML<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E15A0", Offset = "0x6E09A0")]
	private readonly NDJDKKMCPBE<TData> BONAGMCMHBL;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2912800", Offset = "0x2910E00", VA = "0x182912800")]
	public OLOBKNDFADA(List<TData> PBLKKAHMFFL, DLLGPELKLML<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2912700", Offset = "0x2910D00", VA = "0x182912700", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NJDEPNEIGIF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMAOLGACNOI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1600", Offset = "0x6E0A00")] in PHKCDJAIKAN<TData?> JENMJAMAHOH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DMAOLGACNOI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1670", Offset = "0x6E0A70")] in HHKOKBONHGD<TData?> JENMJAMAHOH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HCCOOFCIFGL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> AEJNMEEBKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public OLPMNJBPGMK CEEHBGNNGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public EACNCCAKGKB BKDCNLEINMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float FBHLMAOAOID;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x458D920", Offset = "0x458BF20", VA = "0x18458D920")]
	public HCCOOFCIFGL(IEnumerable<TData> DIHGMENIDFP, OLPMNJBPGMK CMDNLIJPJJE, EACNCCAKGKB FMBPBGHJJDD, float FBHLMAOAOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal static class BCOOOPIBBNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F9AD80", Offset = "0x6F99380", VA = "0x186F9AD80")]
	public static void HINKJBNHJBJ(IEnumerable KOGJJIFAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x19F40B0", Offset = "0x19F26B0", VA = "0x1819F40B0")]
	public static void HINKJBNHJBJ<T>(T[] IACDCADJJAN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x19F4260", Offset = "0x19F2860", VA = "0x1819F4260")]
	public static void HINKJBNHJBJ<T>(T KEFANKKKDEM) where T : notnull, Enum
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ECJGHBGBOCP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMAOLGACNOI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E16E0", Offset = "0x6E0AE0")] in NEGMKOECGIA<T?> FEIAMPJAPOA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BOMKHOFLKNL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public TData[] AEJNMEEBKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public OLPMNJBPGMK[] CEEHBGNNGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public EACNCCAKGKB[] BKDCNLEINMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float[] FBHLMAOAOID;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E6C640", Offset = "0x1E6AC40", VA = "0x181E6C640")]
	public BOMKHOFLKNL(TData[] DIHGMENIDFP, OLPMNJBPGMK[] CMDNLIJPJJE, EACNCCAKGKB[] FMBPBGHJJDD, float[] FBHLMAOAOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KIKDFKECHPO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PEOGGICBFIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FLPPKODEDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PNOJHMBBHPI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IGIEIMNAKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LEMLJOONHBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Guid EOIEIHMCAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int OLGOBCPPPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Vector3 POOFJFBIOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly Quaternion MEHKCJCIOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float HDIPCMABEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly bool PIIPBEBIJOD;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B3D0", Offset = "0x6F999D0", VA = "0x186F9B3D0")]
	public LEMLJOONHBF(Guid EOIEIHMCAOI, int OLGOBCPPPBB, Vector3 POOFJFBIOJJ, Quaternion MEHKCJCIOOL, float HDIPCMABEDD, bool PIIPBEBIJOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EKEPJNPDHEI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOKNMGKBLEC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1790", Offset = "0x6E0B90")] in EIBNLGHAKNH<TData?> JJBIDAONJJH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NEPELJIHNOM(in LBHAPPEEFHK OHKICOIHEHF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MAHBABHKEAC();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum AHJODJJCKGO
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct ENMDHKPOIPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly float MNOGCBMJIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Vector3 KOFANLGAIKF;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4CC74D0", Offset = "0x4CC5AD0", VA = "0x184CC74D0")]
	public ENMDHKPOIPJ(float MNOGCBMJIKG, Vector3 KOFANLGAIKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NKCNNPEGKIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly Vector3 GKDHBIMDNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly float MNOGCBMJIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly Vector3 KOFANLGAIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool PIIPBEBIJOD;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B430", Offset = "0x6F99A30", VA = "0x186F9B430")]
	public NKCNNPEGKIH(Vector3 GKDHBIMDNKM, float MNOGCBMJIKG, Vector3 KOFANLGAIKF, bool PIIPBEBIJOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1800", Offset = "0x6E0C00")]
public class EGFIJLNOKOH<TData> : GPCKIPPOCMK<CFECFNKALHB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1870", Offset = "0x6E0C70")]
	private readonly ECPACAMPIOM<TData> PMPMKMOMICC;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x23E3220", Offset = "0x23E1820", VA = "0x1823E3220")]
	public EGFIJLNOKOH(IEnumerable<TData> DIHGMENIDFP, Vector3 HDABNHCMJKE, AHJODJJCKGO CABGABJILLH, bool HOIFEANCLED, CFECFNKALHB<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2192770", Offset = "0x2190D70", VA = "0x182192770", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MCELNOMCCJF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FFGFMGNNPOF> DMAOLGACNOI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E18D0", Offset = "0x6E0CD0")] MNJAANFABIF<TData> LKKEDBGLGAH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1930", Offset = "0x6E0D30")]
public class LHDPIEDKOMN<TData> : GPCKIPPOCMK<BPHHCJMCHJD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly DBMPEBHFILK PMPMKMOMICC;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2636160", Offset = "0x2634760", VA = "0x182636160")]
	public LHDPIEDKOMN(Vector3 DANGHPKLOJO, BPHHCJMCHJD<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x26360F0", Offset = "0x26346F0", VA = "0x1826360F0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E19A0", Offset = "0x6E0DA0")]
public class OGBOGHJPANM<TData> : GPCKIPPOCMK<KEAHALGEEKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly AMIIHKEDANA HNJCLODNMLH;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2F2BFA0", Offset = "0x2F2A5A0", VA = "0x182F2BFA0")]
	public OGBOGHJPANM(float NHJBLNOJLIB, bool ONKKIBNEJLC, Vector3 KOFANLGAIKF, KEAHALGEEKO<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2F2BEE0", Offset = "0x2F2A4E0", VA = "0x182F2BEE0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface OOAKBEGFDLJ<TData> where TData : CFOOOPBLCJB
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMAOLGACNOI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1A10", Offset = "0x6E0E10")] in FPGBDEDELKF<TData> PNKAAHAPFHN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMAOLGACNOI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1A80", Offset = "0x6E0E80")] in ANFFPBJDDNC<TData> PNKAAHAPFHN);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FNLAIDCMJDL
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum MCLOCJLEPEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1C66FE0", Offset = "0x1C655E0", VA = "0x181C66FE0")]
	public static void JDMKJNGMMDA<T>(T DFKGLOBLDNJ, MCLOCJLEPEF KLGGKKGCLHM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1C67160", Offset = "0x1C65760", VA = "0x181C67160")]
	public static void JDMKJNGMMDA<T>(T DFKGLOBLDNJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1C66F30", Offset = "0x1C65530", VA = "0x181C66F30")]
	public static void HDMMKLEDOJA<T>(T DFKGLOBLDNJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1C67260", Offset = "0x1C65860", VA = "0x181C67260")]
	public static T MBNHJLNEIKL<T>(MCLOCJLEPEF KLGGKKGCLHM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1C671F0", Offset = "0x1C657F0", VA = "0x181C671F0")]
	public static T MBNHJLNEIKL<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1C66EC0", Offset = "0x1C654C0", VA = "0x181C66EC0")]
	public static bool BNJAGEMKDHG<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1AF0", Offset = "0x6E0EF0")]
public class HKOEGNJPCMJ<TData> : GPCKIPPOCMK<DLLGPELKLML<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1D489A0", Offset = "0x1D46FA0", VA = "0x181D489A0")]
	public HKOEGNJPCMJ(DLLGPELKLML<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2EF8710", Offset = "0x2EF6D10", VA = "0x182EF8710", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NJMEICJPIDK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 AAPGOMMDCAJ, Vector3 MAMJCPDDLBH, float JOJFLKALKOE, out T LFKAMGKIPFH, out Vector3 FOLNHFJBKEN, out Collider GIJILAICHMH);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 AAPGOMMDCAJ, Vector3 MAMJCPDDLBH, float GJBIIJNGMNL, float JOJFLKALKOE, T[] HAOIJHCPFLJ, out Vector3 PLNOGMBDAMI, out Collider IAMBNAALBBA);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 AAPGOMMDCAJ, float GJBIIJNGMNL, Vector3 PNAJFCFBNDK, T[] HAOIJHCPFLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class KHPDCHIBNLB<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	protected TReceiver BAJMCEMGHIM;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2657C30", Offset = "0x2656230", VA = "0x182657C30")]
	public KHPDCHIBNLB(TReceiver BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute DMAOLGACNOI();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DGLILANICLM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FFGFMGNNPOF> DMAOLGACNOI(JIGAKCKOPHO JOLKGDGBPKH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1B60", Offset = "0x6E0F60")]
public class ICPEPHLAMEC<TData> : GPCKIPPOCMK<NIOMEBFBAKE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1BD0", Offset = "0x6E0FD0")]
	private readonly NMMGGJNBBAF<TData> KPLGHHCLPAN;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1CE20A0", Offset = "0x1CE06A0", VA = "0x181CE20A0")]
	public ICPEPHLAMEC(IEnumerable<TData> DIHGMENIDFP, OLPMNJBPGMK CMDNLIJPJJE, EACNCCAKGKB FMBPBGHJJDD, float FBHLMAOAOID, bool HOIFEANCLED, NIOMEBFBAKE<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1EA0", Offset = "0x1CE04A0", VA = "0x181CE1EA0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1C30", Offset = "0x6E1030")]
public class HBBFHOADFNA<TData> : GPCKIPPOCMK<GKECBANLAMC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1D489A0", Offset = "0x1D46FA0", VA = "0x181D489A0")]
	public HBBFHOADFNA(GKECBANLAMC<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4581E60", Offset = "0x4580460", VA = "0x184581E60", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1CA0", Offset = "0x6E10A0")]
public class KEFKAAHKOPH<TData> : GPCKIPPOCMK<CFECFNKALHB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1D10", Offset = "0x6E1110")]
	private readonly ACPAHHAJDDE<TData> PMPMKMOMICC;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2653480", Offset = "0x2651A80", VA = "0x182653480")]
	public KEFKAAHKOPH(IEnumerable<TData> DIHGMENIDFP, Vector3 DANGHPKLOJO, bool HOIFEANCLED, CFECFNKALHB<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1EA0", Offset = "0x1CE04A0", VA = "0x181CE1EA0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct ACPAHHAJDDE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly IEnumerable<TData> DIHGMENIDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly Vector3 DANGHPKLOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly bool HOIFEANCLED;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2C51BB0", Offset = "0x2C501B0", VA = "0x182C51BB0")]
	public ACPAHHAJDDE(IEnumerable<TData> DIHGMENIDFP, Vector3 DANGHPKLOJO, bool HOIFEANCLED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CFECFNKALHB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMAOLGACNOI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1D70", Offset = "0x6E1170")] in ACPAHHAJDDE<TData?> PMPMKMOMICC);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DMAOLGACNOI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1DE0", Offset = "0x6E11E0")] in ECPACAMPIOM<TData?> PMPMKMOMICC);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1E50", Offset = "0x6E1250")]
public class GJNPBCGOGBI<TData> : GPCKIPPOCMK<DLLGPELKLML<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly bool HOIFEANCLED;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x400CF50", Offset = "0x400B550", VA = "0x18400CF50")]
	public GJNPBCGOGBI(bool HOIFEANCLED, DLLGPELKLML<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x400CEE0", Offset = "0x400B4E0", VA = "0x18400CEE0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface MBDEAPFNMLJ<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOKNMGKBLEC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1EC0", Offset = "0x6E12C0")] in DGGDPGEFNOC<TNode?> JJBIDAONJJH);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MAHBABHKEAC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1F30", Offset = "0x6E1330")] in FFFHJEKGEPH<TNode?> OJDOEJEDJFJ);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PGFFLLGMPJA();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1FA0", Offset = "0x6E13A0")]
public class CHNFLMDLCAM<TNode> : GPCKIPPOCMK<MBDEAPFNMLJ<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1D489A0", Offset = "0x1D46FA0", VA = "0x181D489A0")]
	public CHNFLMDLCAM(MBDEAPFNMLJ<TNode> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x24D7B10", Offset = "0x24D6110", VA = "0x1824D7B10", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface AOJHKOKDJHJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMAOLGACNOI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2010", Offset = "0x6E1410")] in BOMKHOFLKNL<TData?> KPLGHHCLPAN);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class ANFMDHFLJFC
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private struct AOKKLKJJNGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public bool MEAJCGOAALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public HOKFDAHMIPF ABJJGFGGGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public HOKFDAHMIPF IFBNPEHNEKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static AOKKLKJJNGO KIDHNHLICNA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CancellationToken DGGGBEAGMGG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6F9AB20", Offset = "0x6F99120", VA = "0x186F9AB20")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal static HOKFDAHMIPF ABJJGFGGGPB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A990", Offset = "0x6F98F90", VA = "0x186F9A990")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6F9ACC0", Offset = "0x6F992C0", VA = "0x186F9ACC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F9AA70", Offset = "0x6F99070", VA = "0x186F9AA70")]
	[HFALCAKMDCP(DGHGCOPCCJK.Room, BFPOMPMIJIJ.None)]
	private static void DPJPPHFDAJD(HOKFDAHMIPF AKJLBECPGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6F9AB80", Offset = "0x6F99180", VA = "0x186F9AB80")]
	public static void KINBCCGCMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A940", Offset = "0x6F98F40", VA = "0x186F9A940")]
	private static HOKFDAHMIPF CEGCFDKFBOF(HOKFDAHMIPF ALOEGFLKEEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface EFBFEHBBMHI<TData> : BMBAJDKEKHM, NBGNEMINLHG<TData>, DLLGPELKLML<TData>, KLCIDPHEKNB<TData>, KIKDFKECHPO, NJMEICJPIDK<TData>, BNPOBABFCIC, LCMOGAOEEKM
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct PHKCDJAIKAN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IEnumerable<TData> DIHGMENIDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly Quaternion DANGHPKLOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly Vector3? KOFANLGAIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly bool KECPDABDLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool HOIFEANCLED;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x22AF5B0", Offset = "0x22ADBB0", VA = "0x1822AF5B0")]
	public PHKCDJAIKAN(IEnumerable<TData> DIHGMENIDFP, Quaternion DANGHPKLOJO, Vector3? KOFANLGAIKF, bool KECPDABDLKE, bool HOIFEANCLED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E20A0", Offset = "0x6E14A0")]
public class JOPKPHDAGHD<T> : GPCKIPPOCMK<ECJGHBGBOCP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2110", Offset = "0x6E1510")]
	private readonly NEGMKOECGIA<T> FEIAMPJAPOA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3417610", Offset = "0x3415C10", VA = "0x183417610")]
	public JOPKPHDAGHD(T LIGIEJOGFAH, bool OHEHOJADCKH, ECJGHBGBOCP<T> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1EA0", Offset = "0x1CE04A0", VA = "0x181CE1EA0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct NMMGGJNBBAF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public IEnumerable<TData> AEJNMEEBKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public OLPMNJBPGMK CEEHBGNNGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public EACNCCAKGKB BKDCNLEINMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float FBHLMAOAOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public bool HOIFEANCLED;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2726430", Offset = "0x2724A30", VA = "0x182726430")]
	public NMMGGJNBBAF(IEnumerable<TData> DIHGMENIDFP, OLPMNJBPGMK CMDNLIJPJJE, EACNCCAKGKB FMBPBGHJJDD, float FBHLMAOAOID, bool HOIFEANCLED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2170", Offset = "0x6E1570")]
public class BLMFCBDEDOD<TData> : GPCKIPPOCMK<KEAHALGEEKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly NKCNNPEGKIH HNJCLODNMLH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E65BC0", Offset = "0x1E641C0", VA = "0x181E65BC0")]
	public BLMFCBDEDOD(Vector3 GKDHBIMDNKM, float MNOGCBMJIKG, Vector3 KOFANLGAIKF, bool GDEPFGACBEA, KEAHALGEEKO<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E65B50", Offset = "0x1E64150", VA = "0x181E65B50", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct JAPHMNFADCF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T LIGIEJOGFAH;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x226EAC0", Offset = "0x226D0C0", VA = "0x18226EAC0")]
	public JAPHMNFADCF(T ILMMGBIEBEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct AMIIHKEDANA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly float NHJBLNOJLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly bool ONKKIBNEJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly Vector3 KOFANLGAIKF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A920", Offset = "0x6F98F20", VA = "0x186F9A920")]
	public AMIIHKEDANA(float NHJBLNOJLIB, bool ONKKIBNEJLC, Vector3 KOFANLGAIKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E21E0", Offset = "0x6E15E0")]
public class OOFLNIKGNGD<TData> : GPCKIPPOCMK<DLLGPELKLML<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2250", Offset = "0x6E1650")]
	private readonly NDJDKKMCPBE<TData> BONAGMCMHBL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2917F00", Offset = "0x2916500", VA = "0x182917F00")]
	public OOFLNIKGNGD(List<TData> PBLKKAHMFFL, DLLGPELKLML<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2917E90", Offset = "0x2916490", VA = "0x182917E90", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct FENJHPBDIJM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly IEnumerable<TData> AEJNMEEBKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool IJGKOKOMHHJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x50AD9B0", Offset = "0x50ABFB0", VA = "0x1850AD9B0")]
	public FENJHPBDIJM(IEnumerable<TData> DIHGMENIDFP, bool HOIFEANCLED = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface LCMOGAOEEKM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IOAJAPLOKEP OEHMLJGANDA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E22F0", Offset = "0x6E16F0")]
public class ODAIBHEGINB<TData> : GPCKIPPOCMK<DLLGPELKLML<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2360", Offset = "0x6E1760")]
	private readonly NDJDKKMCPBE<TData> BONAGMCMHBL;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E180", Offset = "0x2F1C780", VA = "0x182F1E180")]
	public ODAIBHEGINB(List<TData> PBLKKAHMFFL, bool HOIFEANCLED, DLLGPELKLML<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8970", Offset = "0x2CF6F70", VA = "0x182CF8970", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct JIGAKCKOPHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool IJGKOKOMHHJ;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xB96E70", Offset = "0xB95470", VA = "0x180B96E70")]
	public JIGAKCKOPHO(bool HOIFEANCLED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface NBGNEMINLHG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T NKFOPKJGBEM, [Optional] FFJIFBOEBED? FNMLENPPFFG, bool FKDAOFMEKBI = true);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int FJLPCOJGEJP, IEnumerable<T> DGMLEAEOENE, bool FKDAOFMEKBI = true);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int FJLPCOJGEJP, IEnumerable<T> DGMLEAEOENE, FFJIFBOEBED FNMLENPPFFG, bool FKDAOFMEKBI = true);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct HHKOKBONHGD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> DIHGMENIDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly Quaternion FNFFBBKOFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly AHJODJJCKGO KGOEHOPNAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly Vector3? KOFANLGAIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly bool KECPDABDLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly bool HOIFEANCLED;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x218C680", Offset = "0x218AC80", VA = "0x18218C680")]
	public HHKOKBONHGD(IEnumerable<TData> DIHGMENIDFP, Quaternion FNFFBBKOFHF, AHJODJJCKGO KGOEHOPNAJK, Vector3? KOFANLGAIKF, bool KECPDABDLKE, bool HOIFEANCLED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct NCDLFPCJAFA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly IEnumerable<TData> DIHGMENIDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly bool HOIFEANCLED;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x277E250", Offset = "0x277C850", VA = "0x18277E250")]
	public NCDLFPCJAFA(IEnumerable<TData> DIHGMENIDFP, bool HOIFEANCLED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E23C0", Offset = "0x6E17C0")]
public class FGOEFFBLGDM<TData> : CGNNDDJJHDP<LHCIIPLMJFF<TData>, FFGFMGNNPOF> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2430", Offset = "0x6E1830")]
	private readonly FENJHPBDIJM<TData> KJCENCNAELH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x50B5450", Offset = "0x50B3A50", VA = "0x1850B5450")]
	public FGOEFFBLGDM(IEnumerable<TData> DIHGMENIDFP, bool HOIFEANCLED, LHCIIPLMJFF<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x50B5210", Offset = "0x50B3810", VA = "0x1850B5210", Slot = "4")]
	public override Task<FFGFMGNNPOF> DMAOLGACNOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2490", Offset = "0x6E1890")]
public class FBDIFNLBPBO<TData> : GPCKIPPOCMK<GKECBANLAMC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2500", Offset = "0x6E1900")]
	private readonly MEFPJGCCGCD<TData> JDJIBOIEBLH;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x225CEA0", Offset = "0x225B4A0", VA = "0x18225CEA0")]
	public FBDIFNLBPBO(TData LIGIEJOGFAH, bool HOIFEANCLED, GKECBANLAMC<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1EA0", Offset = "0x1CE04A0", VA = "0x181CE1EA0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct MEFPJGCCGCD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly TData LIGIEJOGFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool HOIFEANCLED;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x33B5330", Offset = "0x33B3930", VA = "0x1833B5330")]
	public MEFPJGCCGCD(TData LIGIEJOGFAH, bool HOIFEANCLED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct OOOBMNLMIIM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly IEnumerable<TData> DIHGMENIDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool HOIFEANCLED;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2918AB0", Offset = "0x29170B0", VA = "0x182918AB0")]
	public OOOBMNLMIIM(IEnumerable<TData> DIHGMENIDFP, bool HOIFEANCLED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2560", Offset = "0x6E1960")]
public class ABDJFHMPNHO<T> : GPCKIPPOCMK<PCBHHGPIJPD<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1D489A0", Offset = "0x1D46FA0", VA = "0x181D489A0")]
	public ABDJFHMPNHO(PCBHHGPIJPD<T> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x24D7AB0", Offset = "0x24D60B0", VA = "0x1824D7AB0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E25D0", Offset = "0x6E19D0")]
public class OEKBPOAIPHG<TData> : GPCKIPPOCMK<KEAHALGEEKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly ENMDHKPOIPJ HNJCLODNMLH;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2F283E0", Offset = "0x2F269E0", VA = "0x182F283E0")]
	public OEKBPOAIPHG(float MNOGCBMJIKG, Vector3 KOFANLGAIKF, KEAHALGEEKO<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x26360F0", Offset = "0x26346F0", VA = "0x1826360F0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2640", Offset = "0x6E1A40")]
public class FPFICHAPMDL<TData> : GPCKIPPOCMK<EKEPJNPDHEI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1D489A0", Offset = "0x1D46FA0", VA = "0x181D489A0")]
	public FPFICHAPMDL(EKEPJNPDHEI<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1D48940", Offset = "0x1D46F40", VA = "0x181D48940", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E26B0", Offset = "0x6E1AB0")]
public class BIMPJIOEIAO<TData> : GPCKIPPOCMK<EKEPJNPDHEI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2720", Offset = "0x6E1B20")]
	private readonly EIBNLGHAKNH<TData> JENMJAMAHOH;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2521050", Offset = "0x251F650", VA = "0x182521050")]
	public BIMPJIOEIAO(IEnumerable<TData> DIHGMENIDFP, bool HOIFEANCLED, EKEPJNPDHEI<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1EA0", Offset = "0x1CE04A0", VA = "0x181CE1EA0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2780", Offset = "0x6E1B80")]
public class BDKJHPBHIDK<TNode> : GPCKIPPOCMK<MBDEAPFNMLJ<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E27F0", Offset = "0x6E1BF0")]
	private readonly DGGDPGEFNOC<TNode> JJBIDAONJJH;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2512660", Offset = "0x2510C60", VA = "0x182512660")]
	public BDKJHPBHIDK(TNode CKOJHFLHHBE, MBDEAPFNMLJ<TNode> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1EA0", Offset = "0x1CE04A0", VA = "0x181CE1EA0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2850", Offset = "0x6E1C50")]
public class ICNHBIPBDDI<TData> : GPCKIPPOCMK<BPHHCJMCHJD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E28C0", Offset = "0x6E1CC0")]
	private readonly OOOBMNLMIIM<TData> PMPMKMOMICC;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2000", Offset = "0x1CE0600", VA = "0x181CE2000")]
	public ICNHBIPBDDI(IEnumerable<TData> DIHGMENIDFP, bool HOIFEANCLED, BPHHCJMCHJD<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1EA0", Offset = "0x1CE04A0", VA = "0x181CE1EA0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct EIBNLGHAKNH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly IEnumerable<TData> DIHGMENIDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool HOIFEANCLED;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x33D4DE0", Offset = "0x33D33E0", VA = "0x1833D4DE0")]
	public EIBNLGHAKNH(IEnumerable<TData> DIHGMENIDFP, bool HOIFEANCLED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2920", Offset = "0x6E1D20")]
public class KDMEBPBCKPA<TNode> : GPCKIPPOCMK<MBDEAPFNMLJ<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2990", Offset = "0x6E1D90")]
	private readonly FFFHJEKGEPH<TNode> OJDOEJEDJFJ;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x264F210", Offset = "0x264D810", VA = "0x18264F210")]
	public KDMEBPBCKPA(TNode LCHFCPPPBEK, EHILAKFDIBP BKDFIECODHK, MBDEAPFNMLJ<TNode> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2192770", Offset = "0x2190D70", VA = "0x182192770", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface LHCIIPLMJFF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FFGFMGNNPOF> LGKNFOEPEJD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E29F0", Offset = "0x6E1DF0")] in FENJHPBDIJM<TData> BONAGMCMHBL, CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2A60", Offset = "0x6E1E60")]
public class GEKKMFJBKIP : CGNNDDJJHDP<DGLILANICLM, FFGFMGNNPOF>
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class KAPALCBAHBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<FFGFMGNNPOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public GEKKMFJBKIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private FFGFMGNNPOF <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter<FFGFMGNNPOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KAPALCBAHBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B190", Offset = "0x6F99790", VA = "0x186F9B190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly JIGAKCKOPHO BFLNEBBNBDC;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B130", Offset = "0x6F99730", VA = "0x186F9B130")]
	public GEKKMFJBKIP(bool HOIFEANCLED, DGLILANICLM BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F9AFE0", Offset = "0x6F995E0", VA = "0x186F9AFE0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KAPALCBAHBC))]
	public override Task<FFGFMGNNPOF> DMAOLGACNOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface DLLGPELKLML<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JAFEAGDDBIB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2B40", Offset = "0x6E1F40")] in NDJDKKMCPBE<TData> BONAGMCMHBL);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PEAPHIABMJH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2BB0", Offset = "0x6E1FB0")] in NDJDKKMCPBE<TData> BONAGMCMHBL);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MOGBBAIGKCE(in bool JOLHFDCHJJL);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BJIINLKKDLN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2C20", Offset = "0x6E2020")] in NDJDKKMCPBE<TData> BONAGMCMHBL);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MOACBCJKNNE();

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NPKCAFOHKOG(in TData CFBAAHHDNOH);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct LBHAPPEEFHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Quaternion DANGHPKLOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3? KOFANLGAIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool KECPDABDLKE;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5757610", Offset = "0x5755C10", VA = "0x185757610")]
	public LBHAPPEEFHK(Quaternion DANGHPKLOJO, Vector3? KOFANLGAIKF, bool KECPDABDLKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface GKECBANLAMC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOKNMGKBLEC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2C90", Offset = "0x6E2090")] in MEFPJGCCGCD<TData?> JJBIDAONJJH);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NEPELJIHNOM(in LKHLIEDNHOB OHKICOIHEHF);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NEPELJIHNOM(in LEMLJOONHBF OHKICOIHEHF);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MAHBABHKEAC();
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct DBMPEBHFILK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Vector3 DANGHPKLOJO;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public DBMPEBHFILK(Vector3 DANGHPKLOJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2D00", Offset = "0x6E2100")]
public class NMPKKEOCOKC<T> : GPCKIPPOCMK<PCBHHGPIJPD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2D70", Offset = "0x6E2170")]
	private readonly JAPHMNFADCF<T> NHMHIEOJINF;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2726540", Offset = "0x2724B40", VA = "0x182726540")]
	public NMPKKEOCOKC(T LIGIEJOGFAH, PCBHHGPIJPD<T> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1EA0", Offset = "0x1CE04A0", VA = "0x181CE1EA0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2DD0", Offset = "0x6E21D0")]
public class HDCINOEKKKK<TData> : GPCKIPPOCMK<NJDEPNEIGIF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2E40", Offset = "0x6E2240")]
	private readonly PHKCDJAIKAN<TData> JENMJAMAHOH;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2181420", Offset = "0x217FA20", VA = "0x182181420")]
	public HDCINOEKKKK(IEnumerable<TData> DIHGMENIDFP, Quaternion DANGHPKLOJO, Vector3? KOFANLGAIKF, bool KECPDABDLKE, bool HOIFEANCLED, NJDEPNEIGIF<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1EA0", Offset = "0x1CE04A0", VA = "0x181CE1EA0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2EA0", Offset = "0x6E22A0")]
public class OBJLPJHENHM<TData> : GPCKIPPOCMK<KEAHALGEEKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1D489A0", Offset = "0x1D46FA0", VA = "0x181D489A0")]
	public OBJLPJHENHM(KEAHALGEEKO<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F0A0", Offset = "0x2F0D6A0", VA = "0x182F0F0A0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2F10", Offset = "0x6E2310")]
public class HBDKJCBCKFL<TData> : GPCKIPPOCMK<EKEPJNPDHEI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly LBHAPPEEFHK JENMJAMAHOH;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4581EC0", Offset = "0x45804C0", VA = "0x184581EC0")]
	public HBDKJCBCKFL(Quaternion DANGHPKLOJO, Vector3? KOFANLGAIKF, bool KECPDABDLKE, EKEPJNPDHEI<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x26360F0", Offset = "0x26346F0", VA = "0x1826360F0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2F80", Offset = "0x6E2380")]
public class OLIOFHMBKFD<TData> : GPCKIPPOCMK<AOJHKOKDJHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2FF0", Offset = "0x6E23F0")]
	private readonly BOMKHOFLKNL<TData> KPLGHHCLPAN;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2905C80", Offset = "0x2904280", VA = "0x182905C80")]
	public OLIOFHMBKFD(TData[] DIHGMENIDFP, OLPMNJBPGMK[] CMDNLIJPJJE, EACNCCAKGKB[] FMBPBGHJJDD, float[] FBHLMAOAOID, AOJHKOKDJHJ<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2905AF0", Offset = "0x29040F0", VA = "0x182905AF0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3050", Offset = "0x6E2450")]
public class JLCOMIMDGPO<TData> : GPCKIPPOCMK<OOAKBEGFDLJ<TData>> where TData : notnull, CFOOOPBLCJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E30C0", Offset = "0x6E24C0")]
	private readonly ANFFPBJDDNC<TData> PNKAAHAPFHN;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8A30", Offset = "0x2CF7030", VA = "0x182CF8A30")]
	public JLCOMIMDGPO(List<TData> DIHGMENIDFP, List<bool> GEBGNNGHBAC, OOAKBEGFDLJ<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8970", Offset = "0x2CF6F70", VA = "0x182CF8970", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3120", Offset = "0x6E2520")]
public class LAMGDEAFMEE<TData> : GPCKIPPOCMK<BPHHCJMCHJD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1D489A0", Offset = "0x1D46FA0", VA = "0x181D489A0")]
	public LAMGDEAFMEE(BPHHCJMCHJD<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1D48940", Offset = "0x1D46F40", VA = "0x181D48940", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct LKHLIEDNHOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly Vector3 JNJOIMLOINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool PIIPBEBIJOD;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B410", Offset = "0x6F99A10", VA = "0x186F9B410")]
	public LKHLIEDNHOB(Vector3 JNJOIMLOINC, bool PIIPBEBIJOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct NEGMKOECGIA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly T LIGIEJOGFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly bool IPOALPHOPLG;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2784BF0", Offset = "0x27831F0", VA = "0x182784BF0")]
	public NEGMKOECGIA(T ILMMGBIEBEL, bool OHEHOJADCKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface NBIJENFLMIH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEPELJIHNOM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3190", Offset = "0x6E2590")] in HCCOOFCIFGL<TData?> KPLGHHCLPAN);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAHBABHKEAC();
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3200", Offset = "0x6E2600")]
public class KNKCGFNHJCO<TData> : GPCKIPPOCMK<NBIJENFLMIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3270", Offset = "0x6E2670")]
	private readonly HCCOOFCIFGL<TData> KPLGHHCLPAN;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x353E3E0", Offset = "0x353C9E0", VA = "0x18353E3E0")]
	public KNKCGFNHJCO(IEnumerable<TData> DIHGMENIDFP, OLPMNJBPGMK CMDNLIJPJJE, EACNCCAKGKB FMBPBGHJJDD, float FBHLMAOAOID, NBIJENFLMIH<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2905AF0", Offset = "0x29040F0", VA = "0x182905AF0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface KEBBLMACGHG<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> LOHPDGMEDHE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E32D0", Offset = "0x6E26D0")] in PDKGGJFMMND<TSpawnInfo> NMPCGGHJFHO, CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct PDKGGJFMMND<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public TSpawnInfo JKNNBOBJAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Vector3 POOFJFBIOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Quaternion MEHKCJCIOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float CHAPNJAEPMG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xF08EB0", Offset = "0xF074B0", VA = "0x180F08EB0")]
	public PDKGGJFMMND(TSpawnInfo JKNNBOBJAEP, Vector3 POOFJFBIOJJ, Quaternion MEHKCJCIOOL, float CHAPNJAEPMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface CFOOOPBLCJB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FOEHLBAKNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3340", Offset = "0x6E2740")]
public class KFFALFBCBNF<TData> : GPCKIPPOCMK<GKECBANLAMC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly LEMLJOONHBF JDJIBOIEBLH;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x26556E0", Offset = "0x2653CE0", VA = "0x1826556E0")]
	public KFFALFBCBNF(Guid EOIEIHMCAOI, int OLGOBCPPPBB, Vector3 POOFJFBIOJJ, Quaternion MEHKCJCIOOL, float HDIPCMABEDD, bool PIIPBEBIJOD, GKECBANLAMC<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2655670", Offset = "0x2653C70", VA = "0x182655670", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct MNJAANFABIF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public TData JINKJJJPODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IReadOnlyList<TData> ALOJDOOPLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public bool IJGKOKOMHHJ;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2415360", Offset = "0x2413960", VA = "0x182415360")]
	public MNJAANFABIF(TData LLDAELHOPDF, IReadOnlyList<TData> PMBGGELBLMA, bool HOIFEANCLED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface GJAPHMJMMHH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(DBGHHACDEDJ NPGPDMBNKNJ);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData LIGIEJOGFAH, Collider GIJILAICHMH, DBGHHACDEDJ NPGPDMBNKNJ, [Optional] FFJIFBOEBED? JJLGCEOPNKD);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget(out TData LIGIEJOGFAH);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E33B0", Offset = "0x6E27B0")]
public class OEMOJDPCENO<TData> : GPCKIPPOCMK<OOAKBEGFDLJ<TData>> where TData : notnull, CFOOOPBLCJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3420", Offset = "0x6E2820")]
	private readonly FPGBDEDELKF<TData> PNKAAHAPFHN;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2F28470", Offset = "0x2F26A70", VA = "0x182F28470")]
	public OEMOJDPCENO(List<TData> DIHGMENIDFP, bool PDEDGDKMMOJ, OOAKBEGFDLJ<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1EA0", Offset = "0x1CE04A0", VA = "0x181CE1EA0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3480", Offset = "0x6E2880")]
public class JEPPHIGAAGL<TData> : GPCKIPPOCMK<DLLGPELKLML<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly TData CFBAAHHDNOH;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x219FF00", Offset = "0x219E500", VA = "0x18219FF00")]
	public JEPPHIGAAGL(TData CFBAAHHDNOH, DLLGPELKLML<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x219FE40", Offset = "0x219E440", VA = "0x18219FE40", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct ECPACAMPIOM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly IEnumerable<TData> DIHGMENIDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 HDABNHCMJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly AHJODJJCKGO CABGABJILLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool HOIFEANCLED;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x23D9550", Offset = "0x23D7B50", VA = "0x1823D9550")]
	public ECPACAMPIOM(IEnumerable<TData> DIHGMENIDFP, Vector3 HDABNHCMJKE, AHJODJJCKGO CABGABJILLH, bool HOIFEANCLED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E34F0", Offset = "0x6E28F0")]
public class PAAAHMODBPH<TData> : CGNNDDJJHDP<MCELNOMCCJF<TData>, FFGFMGNNPOF> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class JFCFHMGKPOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder<FFGFMGNNPOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public PAAAHMODBPH<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private FFGFMGNNPOF <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<FFGFMGNNPOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public JFCFHMGKPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x21A0DD0", Offset = "0x219F3D0", VA = "0x1821A0DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3560", Offset = "0x6E2960")]
	private readonly MNJAANFABIF<TData> KBINNFKLAAD;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x300C4E0", Offset = "0x300AAE0", VA = "0x18300C4E0")]
	public PAAAHMODBPH(TData LLDAELHOPDF, IReadOnlyList<TData> PMBGGELBLMA, bool HOIFEANCLED, MCELNOMCCJF<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x300C370", Offset = "0x300A970", VA = "0x18300C370", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PAAAHMODBPH<>.JFCFHMGKPOL))]
	public override Task<FFGFMGNNPOF> DMAOLGACNOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3630", Offset = "0x6E2A30")]
public abstract class GPCKIPPOCMK<TReceiver> : KHPDCHIBNLB<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1D489A0", Offset = "0x1D46FA0", VA = "0x181D489A0")]
	public GPCKIPPOCMK(TReceiver BAJMCEMGHIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface BMBAJDKEKHM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Bounds PKBGLANMHGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Transform NFMAMDIPOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Bounds MBCFIDAMHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform HMLILJJNOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Vector3 KJCDKEEPMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool HGJIMCJACMI = true, int LMADIJCOEKI = 0);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool BJGLDAFNDPG, object DCEGGIJLHGI);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct FPGBDEDELKF<TData> where TData : notnull, CFOOOPBLCJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public IEnumerable<TData> AEJNMEEBKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public bool PDEDGDKMMOJ;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x31D1F30", Offset = "0x31D0530", VA = "0x1831D1F30")]
	public FPGBDEDELKF(IEnumerable<TData> ODOALMAHJOA, bool LPJOBALILBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct ANFFPBJDDNC<TData> where TData : notnull, CFOOOPBLCJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public List<TData> AEJNMEEBKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public List<bool> GEBGNNGHBAC;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2082D50", Offset = "0x2081350", VA = "0x182082D50")]
	public ANFFPBJDDNC(List<TData> ODOALMAHJOA, List<bool> NKKFCGFKFDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface KLCIDPHEKNB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool NOPIEEPBFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int NCLJAIGHDLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	IEnumerable<TData> CMACOMKEMEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData MDCAOIKFJBP);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData MDCAOIKFJBP);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface BNPOBABFCIC
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface BPHHCJMCHJD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOKNMGKBLEC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E36A0", Offset = "0x6E2AA0")] in OOOBMNLMIIM<TData?> POAKOJFMIEH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NEPELJIHNOM(in DBMPEBHFILK OHKICOIHEHF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MAHBABHKEAC();
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3710", Offset = "0x6E2B10")]
public class ONHFFKJOIAH<TData> : GPCKIPPOCMK<NBIJENFLMIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1D489A0", Offset = "0x1D46FA0", VA = "0x181D489A0")]
	public ONHFFKJOIAH(NBIJENFLMIH<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2917410", Offset = "0x2915A10", VA = "0x182917410", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface DKDNKMPGFEH : CFOOOPBLCJB
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3780", Offset = "0x6E2B80")]
public abstract class CGNNDDJJHDP<TReceiver, TFromTask> : KHPDCHIBNLB<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1D489A0", Offset = "0x1D46FA0", VA = "0x181D489A0")]
	public CGNNDDJJHDP(TReceiver BAJMCEMGHIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface PCBHHGPIJPD<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOKNMGKBLEC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E37F0", Offset = "0x6E2BF0")] in JAPHMNFADCF<T?> NHMHIEOJINF);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MAHBABHKEAC();
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3860", Offset = "0x6E2C60")]
public class HJMNLLNEHCN<TData> : GPCKIPPOCMK<NJDEPNEIGIF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E38D0", Offset = "0x6E2CD0")]
	private readonly HHKOKBONHGD<TData> JENMJAMAHOH;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2192830", Offset = "0x2190E30", VA = "0x182192830")]
	public HJMNLLNEHCN(IEnumerable<TData> DIHGMENIDFP, Quaternion FNFFBBKOFHF, AHJODJJCKGO KGOEHOPNAJK, Vector3? KOFANLGAIKF, bool KECPDABDLKE, bool HOIFEANCLED, NJDEPNEIGIF<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2192770", Offset = "0x2190D70", VA = "0x182192770", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3930", Offset = "0x6E2D30")]
public class FONPIFEDKFG<TData> : GPCKIPPOCMK<KEAHALGEEKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E39A0", Offset = "0x6E2DA0")]
	private readonly NCDLFPCJAFA<TData> HNJCLODNMLH;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x31D1E90", Offset = "0x31D0490", VA = "0x1831D1E90")]
	public FONPIFEDKFG(IEnumerable<TData> DIHGMENIDFP, bool HOIFEANCLED, KEAHALGEEKO<TData> BAJMCEMGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1EA0", Offset = "0x1CE04A0", VA = "0x181CE1EA0", Slot = "4")]
	public override bool DMAOLGACNOI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface NIOMEBFBAKE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMAOLGACNOI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3A00", Offset = "0x6E2E00")] in NMMGGJNBBAF<TData?> KPLGHHCLPAN);
}
namespace Cpp2IlInjected
{
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
}
