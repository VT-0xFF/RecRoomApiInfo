using System;
using System.Collections;
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
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6816A50", Offset = "0x6815C50", VA = "0x186816A50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7018E0", Offset = "0x700AE0", VA = "0x1807018E0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x701910", Offset = "0x700B10", VA = "0x180701910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DDLEHONFEBP<TData> : AINHEFJAEPG, global::EOCHBHDFJOM<TData>, global::CJOLMILKEEG<TData>, global::AIGGMOPIIKJ<TData>, global::GLEADKGGNKA<TData>, MAGMDAGMOMO
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GLEADKGGNKA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 EDGHCIEJHLG, Vector3 HLFIBIDOLEF, float GKJHODLJDHD, out T PBKOJJOJGMB, out Vector3 HJODBKHINKL, out Collider LPGAJGPGKFM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 EDGHCIEJHLG, Vector3 HLFIBIDOLEF, float CHFEMIAABLG, float GKJHODLJDHD, T[] LDOJHNNMHGI, out Vector3 FELHKDHHAOE, out Collider KKIFJDLKMKG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 EDGHCIEJHLG, float CHFEMIAABLG, Vector3 IMOPEMBMCBM, T[] LDOJHNNMHGI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AINHEFJAEPG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds OHDOCHDODKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform IIFIIIGFOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds LPJHDNBKHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform FBAFFJIGIGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 NLMNAAMBJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AIGGMOPIIKJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ANMPNCGALOM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int JCNFHGNALDA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<TData> GADHAAFCGAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool HDODENIHIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool NFPFMOEFNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData ONCGIPFNENB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData ONCGIPFNENB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EOCHBHDFJOM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T ICHBECDKHOJ, [Optional] LMKFOACECEG? IEMMIFODLAI, bool CNDNAIPCEGH = true);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int BFFJHKFEFPP, IEnumerable<T> HJHCHKNIJAF, bool CNDNAIPCEGH = true);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int BFFJHKFEFPP, IEnumerable<T> HJHCHKNIJAF, LMKFOACECEG IEMMIFODLAI, bool CNDNAIPCEGH = true);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MAGMDAGMOMO
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct AKMNLMHOFCE<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TNode OKLIJIFPONF;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x31DED40", Offset = "0x31DDF40", VA = "0x1831DED40")]
	public AKMNLMHOFCE(TNode OKLIJIFPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NHJCCGOHOGG<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TNode APIPBBLDKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public EBNPGOBCABE IFEOGBCJEBI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x27807D0", Offset = "0x277F9D0", VA = "0x1827807D0")]
	public NHJCCGOHOGG(TNode APIPBBLDKFG, EBNPGOBCABE IFEOGBCJEBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JAHIGCAMOEO<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLBHJGMBJKO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x605040", Offset = "0x604440")] in global::AKMNLMHOFCE<TNode?> KJMNGAAODAM);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FKLKKKDHFHM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6050B0", Offset = "0x6044B0")] in global::NHJCCGOHOGG<TNode?> EFBMEFDHNEN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EEOHPONENGE();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x605120", Offset = "0x604520")]
public class IMEMJFBPDPJ<TNode> : global::KOLLJJNLGBL<global::JAHIGCAMOEO<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x892680", Offset = "0x891880", VA = "0x180892680")]
	public IMEMJFBPDPJ(global::JAHIGCAMOEO<TNode> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x892620", Offset = "0x891820", VA = "0x180892620", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x605190", Offset = "0x604590")]
public class NMLJCCEAKKM<TNode> : global::KOLLJJNLGBL<global::JAHIGCAMOEO<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x605200", Offset = "0x604600")]
	private readonly global::NHJCCGOHOGG<TNode> EFBMEFDHNEN;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x23F0F20", Offset = "0x23F0120", VA = "0x1823F0F20")]
	public NMLJCCEAKKM(TNode APIPBBLDKFG, EBNPGOBCABE IFEOGBCJEBI, global::JAHIGCAMOEO<TNode> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x23F0E50", Offset = "0x23F0050", VA = "0x1823F0E50", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x605260", Offset = "0x604660")]
public class IJNAAGKPJCM<TNode> : global::KOLLJJNLGBL<global::JAHIGCAMOEO<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6052D0", Offset = "0x6046D0")]
	private readonly global::AKMNLMHOFCE<TNode> KJMNGAAODAM;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1B37280", Offset = "0x1B36480", VA = "0x181B37280")]
	public IJNAAGKPJCM(TNode EHOHEFOACBF, global::JAHIGCAMOEO<TNode> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1B371C0", Offset = "0x1B363C0", VA = "0x181B371C0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct ECCACJMFPMK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> DKJEDFMFMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool LOFEDLIEEJD;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x238EB30", Offset = "0x238DD30", VA = "0x18238EB30")]
	public ECCACJMFPMK(IEnumerable<TData> MDMHLFBPAPD, bool ILLJIBICNOG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ENDMHNLLGFN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPINEAANGIG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x605330", Offset = "0x604730")] in global::ECCACJMFPMK<TData?> LCCJICGEEAF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6053A0", Offset = "0x6047A0")]
public class MHNJEENMEBI<TData> : global::KOLLJJNLGBL<global::ENDMHNLLGFN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x605410", Offset = "0x604810")]
	private readonly global::ECCACJMFPMK<TData> IHADBGDLJKA;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2629290", Offset = "0x2628490", VA = "0x182629290")]
	public MHNJEENMEBI(List<TData> JNAAHMPCPAB, bool LOFEDLIEEJD, global::ENDMHNLLGFN<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x21C71A0", Offset = "0x21C63A0", VA = "0x1821C71A0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct GFEGMOFKLEN<TData> where TData : notnull, MGPMJALOCBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> DKJEDFMFMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public bool IOFLAJLLCLH;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2FEC700", Offset = "0x2FEB900", VA = "0x182FEC700")]
	public GFEGMOFKLEN(IEnumerable<TData> MDMHLFBPAPD, bool FBCCKAOLIKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct AGPLBIICLOE<TData> where TData : notnull, MGPMJALOCBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public List<TData> DKJEDFMFMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public List<bool> CKDNFADHOGG;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x29F1A80", Offset = "0x29F0C80", VA = "0x1829F1A80")]
	public AGPLBIICLOE(List<TData> MDMHLFBPAPD, List<bool> LNEOJBJIFME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MGPMJALOCBB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KKMEMHIMMEL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HJIKCMILJMA<TData> where TData : MGPMJALOCBB
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJFONCHDJDL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x603CD0", Offset = "0x6030D0")] in global::GFEGMOFKLEN<TData> EGOMBNOFBCH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJFONCHDJDL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x603D40", Offset = "0x603140")] in global::AGPLBIICLOE<TData> EGOMBNOFBCH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x603DB0", Offset = "0x6031B0")]
public class JFDMNAHJJFG<TData> : global::KOLLJJNLGBL<global::HJIKCMILJMA<TData>> where TData : notnull, MGPMJALOCBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x603E20", Offset = "0x603220")]
	private readonly global::GFEGMOFKLEN<TData> EGOMBNOFBCH;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2BDC2F0", Offset = "0x2BDB4F0", VA = "0x182BDC2F0")]
	public JFDMNAHJJFG(List<TData> AAGLHJMICLO, bool IOFLAJLLCLH, global::HJIKCMILJMA<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1B371C0", Offset = "0x1B363C0", VA = "0x181B371C0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x603E80", Offset = "0x603280")]
public class HMJOFKIIIOP<TData> : global::KOLLJJNLGBL<global::HJIKCMILJMA<TData>> where TData : notnull, MGPMJALOCBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x603EF0", Offset = "0x6032F0")]
	private readonly global::AGPLBIICLOE<TData> EGOMBNOFBCH;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2C752C0", Offset = "0x2C744C0", VA = "0x182C752C0")]
	public HMJOFKIIIOP(List<TData> AAGLHJMICLO, List<bool> CKDNFADHOGG, global::HJIKCMILJMA<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1BA68F0", Offset = "0x1BA5AF0", VA = "0x181BA68F0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface JKKPILGMECP : MGPMJALOCBB
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x603F50", Offset = "0x603350")]
public abstract class KOLLJJNLGBL<TReceiver> : global::BIENHCENEPD<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x892680", Offset = "0x891880", VA = "0x180892680")]
	public KOLLJJNLGBL(TReceiver HHOOFBDANAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class BIENHCENEPD<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected TReceiver HHOOFBDANAJ;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x21C39B0", Offset = "0x21C2BB0", VA = "0x1821C39B0")]
	public BIENHCENEPD(TReceiver HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute EJFONCHDJDL();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface JNKPGKLPGFB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJFONCHDJDL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604000", Offset = "0x603400")] in global::ADAJLIPOFKI<TData?> FOIJJNFCPFH);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OCGHADNNOCP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJFONCHDJDL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604070", Offset = "0x603470")] in global::KJDDMCPOILH<TData?> FOIJJNFCPFH);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface AGNNPIOFKPK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KIPLFFJJIJB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6040E0", Offset = "0x6034E0")] in global::OEIICBOPOEH<TData?> FOIJJNFCPFH);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKLKKKDHFHM();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604150", Offset = "0x603550")]
public class FFGHBBAOCBE<TData> : global::KOLLJJNLGBL<global::JNKPGKLPGFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6041C0", Offset = "0x6035C0")]
	private readonly global::ADAJLIPOFKI<TData> FOIJJNFCPFH;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1B608D0", Offset = "0x1B5FAD0", VA = "0x181B608D0")]
	public FFGHBBAOCBE(IEnumerable<TData> AAGLHJMICLO, JLHLKDMLBPK HMCAFGCGFJF, MJGMBIJIKFH PMPDPBDKGPF, float PALJJNGJNBE, bool LOFEDLIEEJD, global::JNKPGKLPGFB<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1B371C0", Offset = "0x1B363C0", VA = "0x181B371C0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604220", Offset = "0x603620")]
public class JIFEJKCCOML<TData> : global::KOLLJJNLGBL<global::OCGHADNNOCP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604290", Offset = "0x603690")]
	private readonly global::KJDDMCPOILH<TData> FOIJJNFCPFH;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x233E760", Offset = "0x233D960", VA = "0x18233E760")]
	public JIFEJKCCOML(TData[] AAGLHJMICLO, JLHLKDMLBPK[] HMCAFGCGFJF, MJGMBIJIKFH[] PMPDPBDKGPF, float[] PALJJNGJNBE, global::OCGHADNNOCP<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x21C71A0", Offset = "0x21C63A0", VA = "0x1821C71A0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6042F0", Offset = "0x6036F0")]
public class PJFGNKIPBLK<TData> : global::KOLLJJNLGBL<global::AGNNPIOFKPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x892680", Offset = "0x891880", VA = "0x180892680")]
	public PJFGNKIPBLK(global::AGNNPIOFKPK<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC040", Offset = "0x2BEB240", VA = "0x182BEC040", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604360", Offset = "0x603760")]
public class BLKJJPGFOJI<TData> : global::KOLLJJNLGBL<global::AGNNPIOFKPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6043D0", Offset = "0x6037D0")]
	private readonly global::OEIICBOPOEH<TData> FOIJJNFCPFH;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x21C7260", Offset = "0x21C6460", VA = "0x1821C7260")]
	public BLKJJPGFOJI(IEnumerable<TData> AAGLHJMICLO, JLHLKDMLBPK HMCAFGCGFJF, MJGMBIJIKFH PMPDPBDKGPF, float PALJJNGJNBE, global::AGNNPIOFKPK<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x21C71A0", Offset = "0x21C63A0", VA = "0x1821C71A0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct ADAJLIPOFKI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> DKJEDFMFMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public JLHLKDMLBPK OHPPOFOLCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public MJGMBIJIKFH LJDLKAAOHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float PALJJNGJNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool LOFEDLIEEJD;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1BA9BB0", Offset = "0x1BA8DB0", VA = "0x181BA9BB0")]
	public ADAJLIPOFKI(IEnumerable<TData> AAGLHJMICLO, JLHLKDMLBPK HMCAFGCGFJF, MJGMBIJIKFH PMPDPBDKGPF, float PALJJNGJNBE, bool LOFEDLIEEJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct KJDDMCPOILH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public TData[] DKJEDFMFMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public JLHLKDMLBPK[] OHPPOFOLCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public MJGMBIJIKFH[] LJDLKAAOHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float[] PALJJNGJNBE;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0590", Offset = "0x1FBF790", VA = "0x181FC0590")]
	public KJDDMCPOILH(TData[] AAGLHJMICLO, JLHLKDMLBPK[] HMCAFGCGFJF, MJGMBIJIKFH[] PMPDPBDKGPF, float[] PALJJNGJNBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct OEIICBOPOEH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public IEnumerable<TData> DKJEDFMFMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public JLHLKDMLBPK OHPPOFOLCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public MJGMBIJIKFH LJDLKAAOHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public float PALJJNGJNBE;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F280", Offset = "0x2A2E480", VA = "0x182A2F280")]
	public OEIICBOPOEH(IEnumerable<TData> AAGLHJMICLO, JLHLKDMLBPK HMCAFGCGFJF, MJGMBIJIKFH PMPDPBDKGPF, float PALJJNGJNBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface CJOLMILKEEG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKOHPOJALAF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604470", Offset = "0x603870")] in global::DNMKBCIPELF<TData> LCCJICGEEAF);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EDOHPNELGIN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6044E0", Offset = "0x6038E0")] in global::DNMKBCIPELF<TData> LCCJICGEEAF);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MJEMOBIJDMF(in bool NMOFKNOCJLK);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OLHOGMOIBOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604550", Offset = "0x603950")] in global::DNMKBCIPELF<TData> LCCJICGEEAF);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HODDDECDLPM();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HHNNECOGAMB(in TData DDGPLGMGCML);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6045C0", Offset = "0x6039C0")]
public class AMAGBCMNNMB<TData> : global::KOLLJJNLGBL<global::CJOLMILKEEG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604630", Offset = "0x603A30")]
	private readonly global::DNMKBCIPELF<TData> LCCJICGEEAF;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x31DEEA0", Offset = "0x31DE0A0", VA = "0x1831DEEA0")]
	public AMAGBCMNNMB(List<TData> JNAAHMPCPAB, global::CJOLMILKEEG<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1B371C0", Offset = "0x1B363C0", VA = "0x181B371C0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604690", Offset = "0x603A90")]
public class PECHHGOKEDN<TData> : global::KOLLJJNLGBL<global::CJOLMILKEEG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x892680", Offset = "0x891880", VA = "0x180892680")]
	public PECHHGOKEDN(global::CJOLMILKEEG<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x30C30A0", Offset = "0x30C22A0", VA = "0x1830C30A0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604700", Offset = "0x603B00")]
public class OAJBIIFHFJK<TData> : global::KOLLJJNLGBL<global::CJOLMILKEEG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly bool LOFEDLIEEJD;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C270", Offset = "0x2A1B470", VA = "0x182A1C270")]
	public OAJBIIFHFJK(bool LOFEDLIEEJD, global::CJOLMILKEEG<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C200", Offset = "0x2A1B400", VA = "0x182A1C200", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604770", Offset = "0x603B70")]
public class ABCDNHPPCFB<TData> : global::KOLLJJNLGBL<global::CJOLMILKEEG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6047E0", Offset = "0x603BE0")]
	private readonly global::DNMKBCIPELF<TData> LCCJICGEEAF;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1BA6A60", Offset = "0x1BA5C60", VA = "0x181BA6A60")]
	public ABCDNHPPCFB(List<TData> JNAAHMPCPAB, bool LOFEDLIEEJD, global::CJOLMILKEEG<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1BA68F0", Offset = "0x1BA5AF0", VA = "0x181BA68F0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604840", Offset = "0x603C40")]
public class IPNKANANHFM<TData> : global::KOLLJJNLGBL<global::CJOLMILKEEG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly TData DDGPLGMGCML;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4500", Offset = "0x2CF3700", VA = "0x182CF4500")]
	public IPNKANANHFM(TData DDGPLGMGCML, global::CJOLMILKEEG<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4430", Offset = "0x2CF3630", VA = "0x182CF4430", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6048B0", Offset = "0x603CB0")]
public class EKIPEDJEHJP<TData> : global::KOLLJJNLGBL<global::CJOLMILKEEG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604920", Offset = "0x603D20")]
	private readonly global::DNMKBCIPELF<TData> LCCJICGEEAF;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x27EC590", Offset = "0x27EB790", VA = "0x1827EC590")]
	public EKIPEDJEHJP(List<TData> JNAAHMPCPAB, global::CJOLMILKEEG<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27EC4C0", Offset = "0x27EB6C0", VA = "0x1827EC4C0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct DNMKBCIPELF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public IEnumerable<TData> DKJEDFMFMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool LOFEDLIEEJD;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3C130A0", Offset = "0x3C122A0", VA = "0x183C130A0")]
	public DNMKBCIPELF(IEnumerable<TData> MDMHLFBPAPD, bool ILLJIBICNOG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface ANEBEINLICG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJFONCHDJDL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604980", Offset = "0x603D80")] in global::PCDAGPAILFA<TData?> CIIIHKEOONE);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface ONMIGJKMOIP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLBHJGMBJKO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6049F0", Offset = "0x603DF0")] in global::CGNKLPAGFJA<TData?> BCEENHBAKAF);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KIPLFFJJIJB(in OKEOHOJLDAN KPKMBKGABJJ);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FKLKKKDHFHM();
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604A60", Offset = "0x603E60")]
public class AIHALFJPFPI<TData> : global::KOLLJJNLGBL<global::ANEBEINLICG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604AD0", Offset = "0x603ED0")]
	private readonly global::PCDAGPAILFA<TData> CIIIHKEOONE;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x31D9880", Offset = "0x31D8A80", VA = "0x1831D9880")]
	public AIHALFJPFPI(IEnumerable<TData> AAGLHJMICLO, Vector3 GHBLBGFLEBE, bool LOFEDLIEEJD, global::ANEBEINLICG<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1B371C0", Offset = "0x1B363C0", VA = "0x181B371C0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604B30", Offset = "0x603F30")]
public class GAFEIIKFKKN<TData> : global::KOLLJJNLGBL<global::ONMIGJKMOIP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x892680", Offset = "0x891880", VA = "0x180892680")]
	public GAFEIIKFKKN(global::ONMIGJKMOIP<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x892620", Offset = "0x891820", VA = "0x180892620", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604BA0", Offset = "0x603FA0")]
public class MADEKHHCJDC<TData> : global::KOLLJJNLGBL<global::ONMIGJKMOIP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604C10", Offset = "0x604010")]
	private readonly global::CGNKLPAGFJA<TData> CIIIHKEOONE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE4D0", Offset = "0x2DCD6D0", VA = "0x182DCE4D0")]
	public MADEKHHCJDC(IEnumerable<TData> AAGLHJMICLO, bool LOFEDLIEEJD, global::ONMIGJKMOIP<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1B371C0", Offset = "0x1B363C0", VA = "0x181B371C0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604C70", Offset = "0x604070")]
public class FFPOCNIJEIG<TData> : global::KOLLJJNLGBL<global::ONMIGJKMOIP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly OKEOHOJLDAN CIIIHKEOONE;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1B60E00", Offset = "0x1B60000", VA = "0x181B60E00")]
	public FFPOCNIJEIG(Vector3 GHBLBGFLEBE, global::ONMIGJKMOIP<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1B60D90", Offset = "0x1B5FF90", VA = "0x181B60D90", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct PCDAGPAILFA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly IEnumerable<TData> AAGLHJMICLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly Vector3 GHBLBGFLEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool LOFEDLIEEJD;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x33EF6E0", Offset = "0x33EE8E0", VA = "0x1833EF6E0")]
	public PCDAGPAILFA(IEnumerable<TData> AAGLHJMICLO, Vector3 GHBLBGFLEBE, bool LOFEDLIEEJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct CGNKLPAGFJA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly IEnumerable<TData> AAGLHJMICLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool LOFEDLIEEJD;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F540", Offset = "0x2C1E740", VA = "0x182C1F540")]
	public CGNKLPAGFJA(IEnumerable<TData> AAGLHJMICLO, bool LOFEDLIEEJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct OKEOHOJLDAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly Vector3 GHBLBGFLEBE;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x26F0E20", Offset = "0x26F0020", VA = "0x1826F0E20")]
	public OKEOHOJLDAN(Vector3 GHBLBGFLEBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface BHDCFHIHABO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJFONCHDJDL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604CE0", Offset = "0x6040E0")] in global::LJAAKHJNKPD<TData?> LDDCLBPOGGK);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface LIKLLLAINCP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLBHJGMBJKO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604D50", Offset = "0x604150")] in global::BMPBIHEKJDL<TData?> KJMNGAAODAM);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KIPLFFJJIJB(in GGDPKIJKHJD KPKMBKGABJJ);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FKLKKKDHFHM();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604DC0", Offset = "0x6041C0")]
public class JCEBBONANFM<TData> : global::KOLLJJNLGBL<global::BHDCFHIHABO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604E30", Offset = "0x604230")]
	private readonly global::LJAAKHJNKPD<TData> LDDCLBPOGGK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2BD6D70", Offset = "0x2BD5F70", VA = "0x182BD6D70")]
	public JCEBBONANFM(IEnumerable<TData> AAGLHJMICLO, Quaternion GHBLBGFLEBE, Vector3? CDOJOBEAINO, bool GFAKJHENEEM, bool LOFEDLIEEJD, global::BHDCFHIHABO<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1B371C0", Offset = "0x1B363C0", VA = "0x181B371C0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604E90", Offset = "0x604290")]
public class EPMNIJLIMPM<TData> : global::KOLLJJNLGBL<global::LIKLLLAINCP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x892680", Offset = "0x891880", VA = "0x180892680")]
	public EPMNIJLIMPM(global::LIKLLLAINCP<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x892620", Offset = "0x891820", VA = "0x180892620", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604F00", Offset = "0x604300")]
public class FEDOBPFNHHD<TData> : global::KOLLJJNLGBL<global::LIKLLLAINCP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604F70", Offset = "0x604370")]
	private readonly global::BMPBIHEKJDL<TData> LDDCLBPOGGK;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1B5EFF0", Offset = "0x1B5E1F0", VA = "0x181B5EFF0")]
	public FEDOBPFNHHD(IEnumerable<TData> AAGLHJMICLO, bool LOFEDLIEEJD, global::LIKLLLAINCP<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1B371C0", Offset = "0x1B363C0", VA = "0x181B371C0", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x604FD0", Offset = "0x6043D0")]
public class DLFKOPCKNEF<TData> : global::KOLLJJNLGBL<global::LIKLLLAINCP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly GGDPKIJKHJD LDDCLBPOGGK;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x23C51C0", Offset = "0x23C43C0", VA = "0x1823C51C0")]
	public DLFKOPCKNEF(Quaternion GHBLBGFLEBE, Vector3? CDOJOBEAINO, bool GFAKJHENEEM, global::LIKLLLAINCP<TData> HHOOFBDANAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1B60D90", Offset = "0x1B5FF90", VA = "0x181B60D90", Slot = "4")]
	public override bool EJFONCHDJDL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct LJAAKHJNKPD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IEnumerable<TData> AAGLHJMICLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly Quaternion GHBLBGFLEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly Vector3? CDOJOBEAINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly bool GFAKJHENEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool LOFEDLIEEJD;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x21A67A0", Offset = "0x21A59A0", VA = "0x1821A67A0")]
	public LJAAKHJNKPD(IEnumerable<TData> AAGLHJMICLO, Quaternion GHBLBGFLEBE, Vector3? CDOJOBEAINO, bool GFAKJHENEEM, bool LOFEDLIEEJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct BMPBIHEKJDL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly IEnumerable<TData> AAGLHJMICLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool LOFEDLIEEJD;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1EB9D00", Offset = "0x1EB8F00", VA = "0x181EB9D00")]
	public BMPBIHEKJDL(IEnumerable<TData> AAGLHJMICLO, bool LOFEDLIEEJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct GGDPKIJKHJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly Quaternion GHBLBGFLEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly Vector3? CDOJOBEAINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly bool GFAKJHENEEM;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x57CC0F0", Offset = "0x57CB2F0", VA = "0x1857CC0F0")]
	public GGDPKIJKHJD(Quaternion GHBLBGFLEBE, Vector3? CDOJOBEAINO, bool GFAKJHENEEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal static class IAJDGJLBDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x68167E0", Offset = "0x68159E0", VA = "0x1868167E0")]
	public static void ODEIDHCODLL(IEnumerable IECEJGBNFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x227ABD0", Offset = "0x2279DD0", VA = "0x18227ABD0")]
	public static void ODEIDHCODLL<T>(T[] HAHPMNMCEBD) where T : notnull
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
