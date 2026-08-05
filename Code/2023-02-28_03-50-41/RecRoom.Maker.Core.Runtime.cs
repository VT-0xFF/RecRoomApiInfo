using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xEB0210", Offset = "0xEAEC10", VA = "0x180EB0210")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6F0", Offset = "0x6DB0F0", VA = "0x1806DC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x90B660", Offset = "0x90A060", VA = "0x18090B660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EFHGJKOBKNO<TData> : JLHFEPEOGFL, global::KEGMFJBGEEB<TData>, global::EGJGHOCCKEF<TData>, global::AKGAPLLKBIC<TData>, global::HHNFKAPMPOL<TData>
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HHNFKAPMPOL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 DKLFBNALGBC, Vector3 PANBGKEJNBF, float OEPBPFIFMKK, out T JLDDMHCIKJP, out Vector3 IAPLAGEEIKL, out Collider NMALHELEGAH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 DKLFBNALGBC, Vector3 PANBGKEJNBF, float EFKGFGJDHBK, float OEPBPFIFMKK, T[] HPBLEHCKKCC, out Vector3 JEFNDOKIJFE, out Collider AILLGCNMEHG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 DKLFBNALGBC, float EFKGFGJDHBK, Vector3 AMLOEIDBBJL, T[] HPBLEHCKKCC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JLHFEPEOGFL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds BBLBALOBJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform DHPEDGEGFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds DNAJPJDCLML
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform PCAEKNOOOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 CJKLHJFOEIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AKGAPLLKBIC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LAGFPEKHMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int DKMIKNAHHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<TData> OHBHPKEDANF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData DBLPBNJOGMM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KEGMFJBGEEB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T LAFPICAOEAI, [Optional] BDFOGDLNFAP? GIKLJDACLBE, bool BCHPGMEGGCB = true);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int JOBJIONNEHK, IEnumerable<T> JBEHLAHMLFK, bool BCHPGMEGGCB = true);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int JOBJIONNEHK, IEnumerable<T> JBEHLAHMLFK, BDFOGDLNFAP GIKLJDACLBE, bool BCHPGMEGGCB = true);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct PPOAINPPBFM<TData> where TData : notnull, ADECADKEHAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public IEnumerable<TData> DDDEEHMOLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool AECDOCJFMJE;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2762F90", Offset = "0x2761990", VA = "0x182762F90")]
	public PPOAINPPBFM(IEnumerable<TData> PJOEPHDGNDP, bool KEDEGBLBDBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JOPEILDLIHO<TData> where TData : notnull, ADECADKEHAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public List<TData> DDDEEHMOLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<bool> ILKKOECHPFM;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x33FD5F0", Offset = "0x33FBFF0", VA = "0x1833FD5F0")]
	public JOPEILDLIHO(List<TData> PJOEPHDGNDP, List<bool> GNBDNPMGCBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ADECADKEHAP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool ADKEIDIFENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CLHHOBNBDDI<TData> where TData : ADECADKEHAP
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBEMIBMPEAM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x687110", Offset = "0x686510")] in global::PPOAINPPBFM<TData> JONAMEFJHCD);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBEMIBMPEAM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x687180", Offset = "0x686580")] in global::JOPEILDLIHO<TData> JONAMEFJHCD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6871F0", Offset = "0x6865F0")]
public class LKAOJPPCLDD<TData> : global::KPNELBPLCED<global::CLHHOBNBDDI<TData>> where TData : notnull, ADECADKEHAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x687260", Offset = "0x686660")]
	private readonly global::PPOAINPPBFM<TData> JONAMEFJHCD;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2561740", Offset = "0x2560140", VA = "0x182561740")]
	public LKAOJPPCLDD(List<TData> NFMPJBDAMKJ, bool AECDOCJFMJE, global::CLHHOBNBDDI<TData> FCPMCFDJJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2561680", Offset = "0x2560080", VA = "0x182561680", Slot = "4")]
	public override bool PBEMIBMPEAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6872C0", Offset = "0x6866C0")]
public class MIAOLOLKIPG<TData> : global::KPNELBPLCED<global::CLHHOBNBDDI<TData>> where TData : notnull, ADECADKEHAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x687330", Offset = "0x686730")]
	private readonly global::JOPEILDLIHO<TData> JONAMEFJHCD;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2B18E00", Offset = "0x2B17800", VA = "0x182B18E00")]
	public MIAOLOLKIPG(List<TData> NFMPJBDAMKJ, List<bool> ILKKOECHPFM, global::CLHHOBNBDDI<TData> FCPMCFDJJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2A82CA0", Offset = "0x2A816A0", VA = "0x182A82CA0", Slot = "4")]
	public override bool PBEMIBMPEAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AHMKOAEIEBB : ADECADKEHAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class KPNELBPLCED<TReceiver> where TReceiver : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected TReceiver FCPMCFDJJFJ;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3B7CEA0", Offset = "0x3B7B8A0", VA = "0x183B7CEA0")]
	public KPNELBPLCED(TReceiver FCPMCFDJJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool PBEMIBMPEAM();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EGJGHOCCKEF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGKMIPIJHMB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x687390", Offset = "0x686790")] in global::MMGHEKFKJMF<TData> LJCDBOHPBFH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLJONEJEILJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x687400", Offset = "0x686800")] in global::MMGHEKFKJMF<TData> LJCDBOHPBFH);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBPBGLJBGLK(in bool PGFOKKLPDDK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ELOGIJFIHFJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x687470", Offset = "0x686870")] in global::MMGHEKFKJMF<TData> LJCDBOHPBFH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IOCCMBAFJHK();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MODEFNDHGAK(TData GGCPCIEHNNF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6874E0", Offset = "0x6868E0")]
public class DNGCMCBBPNO<TData> : global::KPNELBPLCED<global::EGJGHOCCKEF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x687550", Offset = "0x686950")]
	private readonly global::MMGHEKFKJMF<TData> LJCDBOHPBFH;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x329FA60", Offset = "0x329E460", VA = "0x18329FA60")]
	public DNGCMCBBPNO(List<TData> AHKJLELOIMD, global::EGJGHOCCKEF<TData> FCPMCFDJJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2561680", Offset = "0x2560080", VA = "0x182561680", Slot = "4")]
	public override bool PBEMIBMPEAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x686DE0", Offset = "0x6861E0")]
public class NCPLABECHLE<TData> : global::KPNELBPLCED<global::EGJGHOCCKEF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x17A0E00", Offset = "0x179F800", VA = "0x1817A0E00")]
	public NCPLABECHLE(global::EGJGHOCCKEF<TData> FCPMCFDJJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2305260", Offset = "0x2303C60", VA = "0x182305260", Slot = "4")]
	public override bool PBEMIBMPEAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x686E50", Offset = "0x686250")]
public class JEDMADKMEPB<TData> : global::KPNELBPLCED<global::EGJGHOCCKEF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool HPKJMHBLCDI;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x30B9F30", Offset = "0x30B8930", VA = "0x1830B9F30")]
	public JEDMADKMEPB(bool HPKJMHBLCDI, global::EGJGHOCCKEF<TData> FCPMCFDJJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x30B9EC0", Offset = "0x30B88C0", VA = "0x1830B9EC0", Slot = "4")]
	public override bool PBEMIBMPEAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x686EC0", Offset = "0x6862C0")]
public class GDHLNBBDMDB<TData> : global::KPNELBPLCED<global::EGJGHOCCKEF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x686F30", Offset = "0x686330")]
	private readonly global::MMGHEKFKJMF<TData> LJCDBOHPBFH;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2A82D70", Offset = "0x2A81770", VA = "0x182A82D70")]
	public GDHLNBBDMDB(List<TData> AHKJLELOIMD, bool HPKJMHBLCDI, global::EGJGHOCCKEF<TData> FCPMCFDJJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2A82CA0", Offset = "0x2A816A0", VA = "0x182A82CA0", Slot = "4")]
	public override bool PBEMIBMPEAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x686F90", Offset = "0x686390")]
public class MBCGIGFGJPB<TData> : global::KPNELBPLCED<global::EGJGHOCCKEF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly TData GGCPCIEHNNF;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x37ADD20", Offset = "0x37AC720", VA = "0x1837ADD20")]
	public MBCGIGFGJPB(TData GGCPCIEHNNF, global::EGJGHOCCKEF<TData> FCPMCFDJJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x37ADC50", Offset = "0x37AC650", VA = "0x1837ADC50", Slot = "4")]
	public override bool PBEMIBMPEAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x687000", Offset = "0x686400")]
public class EBBLLMOCFMM<TData> : global::KPNELBPLCED<global::EGJGHOCCKEF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x687070", Offset = "0x686470")]
	private readonly global::MMGHEKFKJMF<TData> LJCDBOHPBFH;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2A9ADC0", Offset = "0x2A997C0", VA = "0x182A9ADC0")]
	public EBBLLMOCFMM(List<TData> AHKJLELOIMD, global::EGJGHOCCKEF<TData> FCPMCFDJJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2A9ACF0", Offset = "0x2A996F0", VA = "0x182A9ACF0", Slot = "4")]
	public override bool PBEMIBMPEAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct MMGHEKFKJMF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public IEnumerable<TData> DDDEEHMOLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public bool HPKJMHBLCDI;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2B27400", Offset = "0x2B25E00", VA = "0x182B27400")]
	public MMGHEKFKJMF(IEnumerable<TData> PJOEPHDGNDP, bool CJBPOOIDCNH = false)
	{
	}
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
