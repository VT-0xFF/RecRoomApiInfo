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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x637A210", Offset = "0x6378C10", VA = "0x18637A210")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CKELHHBKNHH<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn HMGDJGODMOP(TData COMOOAEHALC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GPOCKBLBLLN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(LLOJAAGNDBH EGECDMMIPAN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData PJDANIPAHEH, Collider MFLCLEJCFEE, LLOJAAGNDBH EGECDMMIPAN, [Optional] EFHPIJLIOIK? OJAPLJIIPEL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData PJDANIPAHEH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider MFLCLEJCFEE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LCFCCFPKNIL<TData> : MFMPFLCOLAE, BBGKILJLAPA<TData>, KNGNHBOBJPC<TData>, BLPLGACOGJK<TData>, KHHCPBLNEEA, EAJJLENAFJI<TData>, ICKFDGNLLNP, JEEMNAKKOHM
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EAJJLENAFJI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 FIMOJJMIEFE, Vector3 COKBJHHCBCI, float EHAOBONCKIL, [Out] T JDLMDLFGEBP, [Out] Vector3 JKFMNOEPJFF, [Out] Collider MFLCLEJCFEE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 FIMOJJMIEFE, Vector3 COKBJHHCBCI, float HAKENKHEHFL, float EHAOBONCKIL, T[] NBLEBJMFJAJ, [Out] Vector3 NILKILJIHIJ, [Out] Collider IDKGDCIEAML);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 FIMOJJMIEFE, float HAKENKHEHFL, Vector3 NKNDDCPPDIJ, T[] NBLEBJMFJAJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider INFBHHFPGMA, [Out] T GHENFDJEECA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MFMPFLCOLAE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds DBIAKGCOBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform GPNIHOHDIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds BACMIFIFLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform GACMHEBLHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 IGHMMGJKPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CDFIGCNALOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool GKMHGPELFJK = true, int FFACDDLNFDK = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool BAACJPBMMOB, object AIDIDMJCFEK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JEEMNAKKOHM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	KMHDPFOFGLH HPLMILOPMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IFJGEHBBLAI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool JMHBLGFIMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool IEDENEMOAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool PDKJDGKBIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> HGEMHDBILLJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BLPLGACOGJK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CMDMDIPEKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int OGAODPDKDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> IAKHNGBJGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData ODDGLLCBILG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData ODDGLLCBILG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BBGKILJLAPA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T COMOOAEHALC, [Optional] EFHPIJLIOIK? EJPJPMIOAKL, bool AJLEMMKDMJP = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int GBACAOOHJGH, IEnumerable<T> DGLGKGIPKDI, bool AJLEMMKDMJP = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int GBACAOOHJGH, IEnumerable<T> DGLGKGIPKDI, EFHPIJLIOIK EJPJPMIOAKL, bool AJLEMMKDMJP = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ICKFDGNLLNP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KHHCPBLNEEA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool MMMIFHJEGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool IEGONDAIEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool FBMMJHPDHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool KJILFDPLPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class CMOGOIBCPNC<TReceiver> : AALCFKGDICO<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x34D3220", Offset = "0x34D1C20", VA = "0x1834D3220")]
	public CMOGOIBCPNC(TReceiver PENEHNLEHJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class NOHOCMJPFIH<TReceiver, TFromTask> : AALCFKGDICO<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x34D3220", Offset = "0x34D1C20", VA = "0x1834D3220")]
	public NOHOCMJPFIH(TReceiver PENEHNLEHJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class AALCFKGDICO<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver PENEHNLEHJA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x392B210", Offset = "0x3929C10", VA = "0x18392B210")]
	public AALCFKGDICO(TReceiver PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute AJCCCONLIKP();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ECFPBGFAHHB<TReceiver, TResult> : AALCFKGDICO<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x34D3220", Offset = "0x34D1C20", VA = "0x1834D3220")]
	public ECFPBGFAHHB(TReceiver PENEHNLEHJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct NEIPGHBFMCJ<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup IIOGGEGFFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData GIHIAOCKOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> CFMKLDJGCEM;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1BA7590", Offset = "0x1BA5F90", VA = "0x181BA7590")]
	public NEIPGHBFMCJ(TGroup AACBJIMJEIA, TData PELCMAEFLHJ, IEnumerable<TData> FIFPHDINGFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BOKLOPKOHDE<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup IIOGGEGFFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> CFMKLDJGCEM;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x95C330", Offset = "0x95AD30", VA = "0x18095C330")]
	public BOKLOPKOHDE(TGroup AACBJIMJEIA, IEnumerable<TData> FIFPHDINGFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct JLBPHKNIANK<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup IIOGGEGFFNA;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
	public JLBPHKNIANK(TGroup AACBJIMJEIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GBMGNGIPJEE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> CFMKLDJGCEM;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
	public GBMGNGIPJEE(IEnumerable<TData> FIFPHDINGFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LGHPIDLJGJM<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CDFKNEFHHIO NGMEEDNAKMC(NEIPGHBFMCJ<TGroup, TData> PGCMBKLJANJ);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CDFKNEFHHIO GOHMNCHNFMM(NEIPGHBFMCJ<TGroup, TData> PGCMBKLJANJ);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CDFKNEFHHIO JGNHCFKKMCA(BOKLOPKOHDE<TGroup, TData> PGCMBKLJANJ);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CDFKNEFHHIO GIHOFPANGCP(JLBPHKNIANK<TGroup> PGCMBKLJANJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JAKEEPJOKCM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CDFKNEFHHIO> NGMEEDNAKMC(GBMGNGIPJEE<TData> PGCMBKLJANJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BBAKNDDFLPL<TGroup, TData> : ECFPBGFAHHB<LGHPIDLJGJM<TGroup, TData>, CDFKNEFHHIO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly BOKLOPKOHDE<TGroup, TData> PGCMBKLJANJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4927C00", Offset = "0x4926600", VA = "0x184927C00")]
	public BBAKNDDFLPL(TGroup AACBJIMJEIA, IEnumerable<TData> FIFPHDINGFM, LGHPIDLJGJM<TGroup, TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4927B30", Offset = "0x4926530", VA = "0x184927B30", Slot = "4")]
	public override CDFKNEFHHIO AJCCCONLIKP()
	{
		return default(CDFKNEFHHIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GCLPODCMIBM<TGroup, TData> : ECFPBGFAHHB<LGHPIDLJGJM<TGroup, TData>, CDFKNEFHHIO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly NEIPGHBFMCJ<TGroup, TData> PGCMBKLJANJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3959300", Offset = "0x3957D00", VA = "0x183959300")]
	public GCLPODCMIBM(TGroup AACBJIMJEIA, TData NAGFBCDBLLF, IEnumerable<TData> FIFPHDINGFM, LGHPIDLJGJM<TGroup, TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3959230", Offset = "0x3957C30", VA = "0x183959230", Slot = "4")]
	public override CDFKNEFHHIO AJCCCONLIKP()
	{
		return default(CDFKNEFHHIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MKBBEPLDIKP<TGroup, TData> : ECFPBGFAHHB<LGHPIDLJGJM<TGroup, TData>, CDFKNEFHHIO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly JLBPHKNIANK<TGroup> PGCMBKLJANJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x400C920", Offset = "0x400B320", VA = "0x18400C920")]
	public MKBBEPLDIKP(TGroup AACBJIMJEIA, LGHPIDLJGJM<TGroup, TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4046EC0", Offset = "0x40458C0", VA = "0x184046EC0", Slot = "4")]
	public override CDFKNEFHHIO AJCCCONLIKP()
	{
		return default(CDFKNEFHHIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LDHCLMBIFFK<TGroup, TData> : ECFPBGFAHHB<LGHPIDLJGJM<TGroup, TData>, CDFKNEFHHIO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NEIPGHBFMCJ<TGroup, TData> PGCMBKLJANJ;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3959300", Offset = "0x3957D00", VA = "0x183959300")]
	public LDHCLMBIFFK(TGroup AACBJIMJEIA, TData PELCMAEFLHJ, IEnumerable<TData> FIFPHDINGFM, LGHPIDLJGJM<TGroup, TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E2B9C0", Offset = "0x3E2A3C0", VA = "0x183E2B9C0", Slot = "4")]
	public override CDFKNEFHHIO AJCCCONLIKP()
	{
		return default(CDFKNEFHHIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MBGMCLNAKMF<TData> : NOHOCMJPFIH<JAKEEPJOKCM<TData>, CDFKNEFHHIO> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct NAHIEMKNFGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<CDFKNEFHHIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public MBGMCLNAKMF<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<CDFKNEFHHIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x40C1750", Offset = "0x40C0150", VA = "0x1840C1750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x40C19F0", Offset = "0x40C03F0", VA = "0x1840C19F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private GBMGNGIPJEE<TData> PGCMBKLJANJ;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x400C920", Offset = "0x400B320", VA = "0x18400C920")]
	public MBGMCLNAKMF(IEnumerable<TData> FIKOHOEBEKB, JAKEEPJOKCM<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x400C820", Offset = "0x400B220", VA = "0x18400C820", Slot = "4")]
	[AsyncStateMachine(typeof(MBGMCLNAKMF<>.NAHIEMKNFGA))]
	public override Task<CDFKNEFHHIO> AJCCCONLIKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct LKPFNNIGCMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly NHCHFAPAJBO PPIINAAANAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool AIEHPPONHCG;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6379FC0", Offset = "0x63789C0", VA = "0x186379FC0")]
	public LKPFNNIGCMN(NHCHFAPAJBO KAKHEHLPHOB, bool IKJOLIBEGHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CMOBEIMDEEE<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> AJCCCONLIKP(LKPFNNIGCMN GBCFHEFNPMI);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class JBHDDDNHAHF<TSpawnType> : NOHOCMJPFIH<CMOBEIMDEEE<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct DHELKBDJOIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JBHDDDNHAHF<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x524EF70", Offset = "0x524D970", VA = "0x18524EF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x495A800", Offset = "0x4959200", VA = "0x18495A800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly LKPFNNIGCMN GBCFHEFNPMI;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3C64A50", Offset = "0x3C63450", VA = "0x183C64A50")]
	public JBHDDDNHAHF(NHCHFAPAJBO KAKHEHLPHOB, bool IKJOLIBEGHM, CMOBEIMDEEE<TSpawnType> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C64870", Offset = "0x3C63270", VA = "0x183C64870", Slot = "4")]
	[AsyncStateMachine(typeof(JBHDDDNHAHF<>.DHELKBDJOIN))]
	public override Task<TSpawnType> AJCCCONLIKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct NHCHFAPAJBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool MDLDECCFLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 ACHFGAEIKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 LDHIOGOHNGO;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x637A110", Offset = "0x6378B10", VA = "0x18637A110")]
	public NHCHFAPAJBO(Transform KCJLBLHDJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x637A0E0", Offset = "0x6378AE0", VA = "0x18637A0E0")]
	public NHCHFAPAJBO(Vector3 AMMBIDJOPFP, Vector3 DGOJEOCFHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x637A0B0", Offset = "0x6378AB0", VA = "0x18637A0B0")]
	public static NHCHFAPAJBO JCNCJJKPAFA()
	{
		return default(NHCHFAPAJBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x637A180", Offset = "0x6378B80", VA = "0x18637A180")]
	private NHCHFAPAJBO(bool INEOFLBBKPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct GMAJLPEMFAE<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode MAIEKPBHDAM;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x39AE5E0", Offset = "0x39ACFE0", VA = "0x1839AE5E0")]
	public GMAJLPEMFAE(TNode MAIEKPBHDAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct ENPOIJDIEJA<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode NPANNNFADFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public BFPJOOCCOCL BDCPKNEIKEI;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3523060", Offset = "0x3521A60", VA = "0x183523060")]
	public ENPOIJDIEJA(TNode NPANNNFADFF, BFPJOOCCOCL BDCPKNEIKEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface GLBPNCOLMLE<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAGCEOKHOIJ([In] GMAJLPEMFAE<TNode> ENOGLJIKJMA);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JABHIELFENE([In] ENPOIJDIEJA<TNode> BKBIBLGBONB);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AKFBPPEAOPF();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HBBPGHKEFAG<TNode> : CMOGOIBCPNC<GLBPNCOLMLE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x34D3220", Offset = "0x34D1C20", VA = "0x1834D3220")]
	public HBBPGHKEFAG(GLBPNCOLMLE<TNode> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x39E0480", Offset = "0x39DEE80", VA = "0x1839E0480", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FAGLJJKPDCN<TNode> : CMOGOIBCPNC<GLBPNCOLMLE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly ENPOIJDIEJA<TNode> BKBIBLGBONB;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3869950", Offset = "0x3868350", VA = "0x183869950")]
	public FAGLJJKPDCN(TNode NPANNNFADFF, BFPJOOCCOCL BDCPKNEIKEI, GLBPNCOLMLE<TNode> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3869890", Offset = "0x3868290", VA = "0x183869890", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DBIGPLMMEFJ<TNode> : CMOGOIBCPNC<GLBPNCOLMLE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly GMAJLPEMFAE<TNode> ENOGLJIKJMA;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5232AF0", Offset = "0x52314F0", VA = "0x185232AF0")]
	public DBIGPLMMEFJ(TNode DKIPAGNOKPG, GLBPNCOLMLE<TNode> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x38BEFC0", Offset = "0x38BD9C0", VA = "0x1838BEFC0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NIGALMACFOD<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo KIMOEAKNHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 DGOJEOCFHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion DMBBOEJIOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float LFNFJOFKAIK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x40D5D00", Offset = "0x40D4700", VA = "0x1840D5D00")]
	public NIGALMACFOD(TSpawnInfo KIMOEAKNHFA, Vector3 DGOJEOCFHHN, Quaternion DMBBOEJIOJM, float LFNFJOFKAIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LBBMPHEEDNM<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> OLJLCBBKODF([In] NIGALMACFOD<TSpawnInfo> LCFOCPBGNJO, CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class APIJCGMJPDL<TSpawnType, TSpawnInfo> : NOHOCMJPFIH<LBBMPHEEDNM<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly NIGALMACFOD<TSpawnInfo> CADHKPGCKBL;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E910", Offset = "0x3A6D310", VA = "0x183A6E910")]
	public APIJCGMJPDL(TSpawnInfo LCPLPDIFMGD, Vector3 DGOJEOCFHHN, Quaternion DMBBOEJIOJM, float LFNFJOFKAIK, LBBMPHEEDNM<TSpawnType, TSpawnInfo> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E730", Offset = "0x3A6D130", VA = "0x183A6E730", Slot = "4")]
	public override Task<TSpawnType> AJCCCONLIKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct NLKKKOPCHFJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> CFMKLDJGCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool AIEHPPONHCG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x40E3A90", Offset = "0x40E2490", VA = "0x1840E3A90")]
	public NLKKKOPCHFJ(IEnumerable<TData> FIFPHDINGFM, bool IKJOLIBEGHM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface EBKNLOIBHBK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CDFKNEFHHIO> JCMAPDCGHBB([In] NLKKKOPCHFJ<TData> AKACCKKKEDL, CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NNCINJPLAFG<TData> : NOHOCMJPFIH<EBKNLOIBHBK<TData>, CDFKNEFHHIO> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly NLKKKOPCHFJ<TData> ILDIECIEHEA;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x40E6460", Offset = "0x40E4E60", VA = "0x1840E6460")]
	public NNCINJPLAFG(IEnumerable<TData> FIFPHDINGFM, bool IKJOLIBEGHM, EBKNLOIBHBK<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E730", Offset = "0x3A6D130", VA = "0x183A6E730", Slot = "4")]
	public override Task<CDFKNEFHHIO> AJCCCONLIKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct GEDNKPLKFJJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T PJDANIPAHEH;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3961A30", Offset = "0x3960430", VA = "0x183961A30")]
	public GEDNKPLKFJJ(T OEPKCNFGPIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface LLAHIAAJDCJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAGCEOKHOIJ([In] GEDNKPLKFJJ<T> KOOCBJCMAAA);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JABHIELFENE();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface EBHONGHBPPK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJCCCONLIKP([In] MDCGBCDKODD<T> EEHOHMEEGNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct MDCGBCDKODD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T PJDANIPAHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool AFPIHNEMKIL;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x400D8D0", Offset = "0x400C2D0", VA = "0x18400D8D0")]
	public MDCGBCDKODD(T OEPKCNFGPIB, bool KLIHAJDFBNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class KJHDGLPNINB<T> : CMOGOIBCPNC<LLAHIAAJDCJ<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x34D3220", Offset = "0x34D1C20", VA = "0x1834D3220")]
	public KJHDGLPNINB(LLAHIAAJDCJ<T> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3D6AF90", Offset = "0x3D69990", VA = "0x183D6AF90", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class OEPALLCIFLG<T> : CMOGOIBCPNC<LLAHIAAJDCJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly GEDNKPLKFJJ<T> KOOCBJCMAAA;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4208500", Offset = "0x4206F00", VA = "0x184208500")]
	public OEPALLCIFLG(T PJDANIPAHEH, LLAHIAAJDCJ<T> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x38BEFC0", Offset = "0x38BD9C0", VA = "0x1838BEFC0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class HNODNFNLEDH<T> : CMOGOIBCPNC<EBHONGHBPPK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly MDCGBCDKODD<T> EEHOHMEEGNJ;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3A0BCD0", Offset = "0x3A0A6D0", VA = "0x183A0BCD0")]
	public HNODNFNLEDH(T PJDANIPAHEH, bool KLIHAJDFBNA, EBHONGHBPPK<T> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x38BEFC0", Offset = "0x38BD9C0", VA = "0x1838BEFC0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BMBJDBCGCPL<TData> where TData : notnull, IIFEGKDJDPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> CFMKLDJGCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool CKHFEELDJOP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x495AC50", Offset = "0x4959650", VA = "0x18495AC50")]
	public BMBJDBCGCPL(IEnumerable<TData> OHJDCKKFKKA, bool DELPDGLEEEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct KNKLMNIPMFP<TData> where TData : notnull, IIFEGKDJDPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> CFMKLDJGCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> LCGDMCPIGNA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3D87F10", Offset = "0x3D86910", VA = "0x183D87F10")]
	public KNKLMNIPMFP(List<TData> OHJDCKKFKKA, List<bool> FGDKEHJFNIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IIFEGKDJDPF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool EBIEGCHLDMM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface HHLLFDHDANK<TData> where TData : IIFEGKDJDPF
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJCCCONLIKP([In] BMBJDBCGCPL<TData> DCBAMOMOEBL);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJCCCONLIKP([In] KNKLMNIPMFP<TData> DCBAMOMOEBL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JJJDGMGJPFF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEPKHFODFGH(T PJDANIPAHEH);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class JLIKKDPFKCC<TData> : CMOGOIBCPNC<HHLLFDHDANK<TData>> where TData : notnull, IIFEGKDJDPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly BMBJDBCGCPL<TData> DCBAMOMOEBL;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3C824A0", Offset = "0x3C80EA0", VA = "0x183C824A0")]
	public JLIKKDPFKCC(List<TData> FIFPHDINGFM, bool CKHFEELDJOP, HHLLFDHDANK<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x38BEFC0", Offset = "0x38BD9C0", VA = "0x1838BEFC0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class FCDAPOOINLP<TData> : CMOGOIBCPNC<HHLLFDHDANK<TData>> where TData : notnull, IIFEGKDJDPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly KNKLMNIPMFP<TData> DCBAMOMOEBL;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3870AC0", Offset = "0x386F4C0", VA = "0x183870AC0")]
	public FCDAPOOINLP(List<TData> FIFPHDINGFM, List<bool> LCGDMCPIGNA, HHLLFDHDANK<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3870A00", Offset = "0x386F400", VA = "0x183870A00", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GCDGFDLEKHG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CDFKNEFHHIO> AJCCCONLIKP(CEKAFEOCPHJ<TData> GDEEIPFPAAM);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class CPLFEJAFMKA<TData> : NOHOCMJPFIH<GCDGFDLEKHG<TData>, CDFKNEFHHIO> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct BCCDPKMFNMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<CDFKNEFHHIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CPLFEJAFMKA<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<CDFKNEFHHIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4928100", Offset = "0x4926B00", VA = "0x184928100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x49283E0", Offset = "0x4926DE0", VA = "0x1849283E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CEKAFEOCPHJ<TData> LLFNDGAOLEN;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4E455E0", Offset = "0x4E43FE0", VA = "0x184E455E0")]
	public CPLFEJAFMKA(TData ONIOCIHNNCN, IReadOnlyList<TData> CAMHEIGDBIF, bool IKJOLIBEGHM, GCDGFDLEKHG<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4E454E0", Offset = "0x4E43EE0", VA = "0x184E454E0", Slot = "4")]
	[AsyncStateMachine(typeof(CPLFEJAFMKA<>.BCCDPKMFNMB))]
	public override Task<CDFKNEFHHIO> AJCCCONLIKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct CEKAFEOCPHJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData KOKNHFIJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> IEHJNOKOMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool AIEHPPONHCG;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x47AF370", Offset = "0x47ADD70", VA = "0x1847AF370")]
	public CEKAFEOCPHJ(TData ONIOCIHNNCN, IReadOnlyList<TData> CAMHEIGDBIF, bool IKJOLIBEGHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface FAEDPIOAKDH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJCCCONLIKP([In] OLKIPGHPPIO<TData> NPBKKOAFHFI);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface BONPLDNLBBO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJCCCONLIKP([In] BOCDOLPJCCB<TData> NPBKKOAFHFI);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface KCEINMBDPFA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGPOLLAENPI([In] KLDCKCCPJHG<TData> NPBKKOAFHFI);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JABHIELFENE();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class ADJFEMAKGOA<TData> : CMOGOIBCPNC<FAEDPIOAKDH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly OLKIPGHPPIO<TData> NPBKKOAFHFI;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x392D9E0", Offset = "0x392C3E0", VA = "0x18392D9E0")]
	public ADJFEMAKGOA(IEnumerable<TData> FIFPHDINGFM, GLILLNDJLFB GLALCIBBONF, HNHHCMALDIM FEIOCBKHAFO, float BNKHEPPCCMN, bool IKJOLIBEGHM, FAEDPIOAKDH<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x38BEFC0", Offset = "0x38BD9C0", VA = "0x1838BEFC0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class DFJOOLIOMEF<TData> : CMOGOIBCPNC<BONPLDNLBBO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly BOCDOLPJCCB<TData> NPBKKOAFHFI;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5248950", Offset = "0x5247350", VA = "0x185248950")]
	public DFJOOLIOMEF(TData[] FIFPHDINGFM, GLILLNDJLFB[] GLALCIBBONF, HNHHCMALDIM[] FEIOCBKHAFO, float[] BNKHEPPCCMN, BONPLDNLBBO<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x34CD500", Offset = "0x34CBF00", VA = "0x1834CD500", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class KJHMJPJJGHN<TData> : CMOGOIBCPNC<KCEINMBDPFA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x34D3220", Offset = "0x34D1C20", VA = "0x1834D3220")]
	public KJHMJPJJGHN(KCEINMBDPFA<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E7A0", Offset = "0x3D6D1A0", VA = "0x183D6E7A0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class EABDCEPBFBJ<TData> : CMOGOIBCPNC<KCEINMBDPFA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly KLDCKCCPJHG<TData> NPBKKOAFHFI;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x34CD5C0", Offset = "0x34CBFC0", VA = "0x1834CD5C0")]
	public EABDCEPBFBJ(IEnumerable<TData> FIFPHDINGFM, GLILLNDJLFB GLALCIBBONF, HNHHCMALDIM FEIOCBKHAFO, float BNKHEPPCCMN, KCEINMBDPFA<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x34CD500", Offset = "0x34CBF00", VA = "0x1834CD500", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct OLKIPGHPPIO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> CFMKLDJGCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public GLILLNDJLFB LLKBDMEOKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public HNHHCMALDIM JFAIEMENCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float BNKHEPPCCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool IKJOLIBEGHM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x421AD30", Offset = "0x4219730", VA = "0x18421AD30")]
	public OLKIPGHPPIO(IEnumerable<TData> FIFPHDINGFM, GLILLNDJLFB GLALCIBBONF, HNHHCMALDIM FEIOCBKHAFO, float BNKHEPPCCMN, bool IKJOLIBEGHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct BOCDOLPJCCB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] CFMKLDJGCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GLILLNDJLFB[] LLKBDMEOKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public HNHHCMALDIM[] JFAIEMENCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] BNKHEPPCCMN;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4971640", Offset = "0x4970040", VA = "0x184971640")]
	public BOCDOLPJCCB(TData[] FIFPHDINGFM, GLILLNDJLFB[] GLALCIBBONF, HNHHCMALDIM[] FEIOCBKHAFO, float[] BNKHEPPCCMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct KLDCKCCPJHG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> CFMKLDJGCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public GLILLNDJLFB LLKBDMEOKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public HNHHCMALDIM JFAIEMENCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float BNKHEPPCCMN;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3D72FA0", Offset = "0x3D719A0", VA = "0x183D72FA0")]
	public KLDCKCCPJHG(IEnumerable<TData> FIFPHDINGFM, GLILLNDJLFB GLALCIBBONF, HNHHCMALDIM FEIOCBKHAFO, float BNKHEPPCCMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface KNGNHBOBJPC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGNHCFKKMCA([In] OCGBNDLDHDD<TData> AKACCKKKEDL);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIHOFPANGCP([In] OCGBNDLDHDD<TData> AKACCKKKEDL);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNIPEOMPNKM([In] bool EEOGFJHPFFN);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AFJANLLBOAN([In] OCGBNDLDHDD<TData> AKACCKKKEDL);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AIIIPJIINJC();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NDGDPMLEIJJ([In] TData AILOFKCMPAO);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class AIBFIFIFGFH<TData> : CMOGOIBCPNC<KNGNHBOBJPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly OCGBNDLDHDD<TData> AKACCKKKEDL;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3974270", Offset = "0x3972C70", VA = "0x183974270")]
	public AIBFIFIFGFH(List<TData> APNNJDENMKO, KNGNHBOBJPC<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x38BEFC0", Offset = "0x38BD9C0", VA = "0x1838BEFC0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class KBELGMDKOAN<TData> : CMOGOIBCPNC<KNGNHBOBJPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x34D3220", Offset = "0x34D1C20", VA = "0x1834D3220")]
	public KBELGMDKOAN(KNGNHBOBJPC<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3D50D80", Offset = "0x3D4F780", VA = "0x183D50D80", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class PHFGINHGAIM<TData> : CMOGOIBCPNC<KNGNHBOBJPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool IKJOLIBEGHM;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4300110", Offset = "0x42FEB10", VA = "0x184300110")]
	public PHFGINHGAIM(bool IKJOLIBEGHM, KNGNHBOBJPC<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x43000B0", Offset = "0x42FEAB0", VA = "0x1843000B0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class OMLINPFCFGF<TData> : CMOGOIBCPNC<KNGNHBOBJPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OCGBNDLDHDD<TData> AKACCKKKEDL;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4224120", Offset = "0x4222B20", VA = "0x184224120")]
	public OMLINPFCFGF(List<TData> APNNJDENMKO, bool IKJOLIBEGHM, KNGNHBOBJPC<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3870A00", Offset = "0x386F400", VA = "0x183870A00", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ILJNOLJPEII<TData> : CMOGOIBCPNC<KNGNHBOBJPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData AILOFKCMPAO;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3ACDA20", Offset = "0x3ACC420", VA = "0x183ACDA20")]
	public ILJNOLJPEII(TData AILOFKCMPAO, KNGNHBOBJPC<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3ACD960", Offset = "0x3ACC360", VA = "0x183ACD960", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PICOICBDHGA<TData> : CMOGOIBCPNC<KNGNHBOBJPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly OCGBNDLDHDD<TData> AKACCKKKEDL;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4302DB0", Offset = "0x43017B0", VA = "0x184302DB0")]
	public PICOICBDHGA(IEnumerable<TData> APNNJDENMKO, KNGNHBOBJPC<TData> PENEHNLEHJA, bool IKJOLIBEGHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4302CF0", Offset = "0x43016F0", VA = "0x184302CF0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct OCGBNDLDHDD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> CFMKLDJGCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool IKJOLIBEGHM;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x41FF530", Offset = "0x41FDF30", VA = "0x1841FF530")]
	public OCGBNDLDHDD(IEnumerable<TData> OHJDCKKFKKA, bool MCEDKCLNPEA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface KDAJPHAFECO
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CDFKNEFHHIO> AJCCCONLIKP(PBJPKKEJMOP PGIDCOMNDGH);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class AANJDMAHLFP : NOHOCMJPFIH<KDAJPHAFECO, CDFKNEFHHIO>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct DDBBNBNKIKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<CDFKNEFHHIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AANJDMAHLFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<CDFKNEFHHIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x63794D0", Offset = "0x6377ED0", VA = "0x1863794D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6379750", Offset = "0x6378150", VA = "0x186379750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly PBJPKKEJMOP BKNALENKMDJ;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6378E10", Offset = "0x6377810", VA = "0x186378E10")]
	public AANJDMAHLFP(bool IKJOLIBEGHM, KDAJPHAFECO PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6378D20", Offset = "0x6377720", VA = "0x186378D20", Slot = "4")]
	[AsyncStateMachine(typeof(DDBBNBNKIKJ))]
	public override Task<CDFKNEFHHIO> AJCCCONLIKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct PBJPKKEJMOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool AIEHPPONHCG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xCE6180", Offset = "0xCE4B80", VA = "0x180CE6180")]
	public PBJPKKEJMOP(bool IKJOLIBEGHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct GJDMNDCEHMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool DONFBIAABCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool IILGLHLAHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool LFNFJOFKAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool IKJOLIBEGHM;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x47E1970", Offset = "0x47E0370", VA = "0x1847E1970")]
	public GJDMNDCEHMD(bool DONFBIAABCD, bool IILGLHLAHGG, bool LFNFJOFKAIK, bool IKJOLIBEGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x63798A0", Offset = "0x63782A0", VA = "0x1863798A0")]
	public GJDMNDCEHMD(bool IILGLHLAHGG, bool IKJOLIBEGHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JGHNNOCBALD
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNPKMPDIOKM(GJDMNDCEHMD ICINACPPBJF);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KCBEFKGBPBD(GJDMNDCEHMD ICINACPPBJF);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class FGEMKGOOKFO : CMOGOIBCPNC<JGHNNOCBALD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GJDMNDCEHMD ICINACPPBJF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6379810", Offset = "0x6378210", VA = "0x186379810")]
	public FGEMKGOOKFO(bool OEIDOHJNAOK, bool IILGLHLAHGG, bool LFNFJOFKAIK, bool IKJOLIBEGHM, JGHNNOCBALD PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x63797C0", Offset = "0x63781C0", VA = "0x1863797C0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class MADPBOLILNP : CMOGOIBCPNC<JGHNNOCBALD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly GJDMNDCEHMD ICINACPPBJF;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x637A030", Offset = "0x6378A30", VA = "0x18637A030")]
	public MADPBOLILNP(bool IILGLHLAHGG, bool IKJOLIBEGHM, JGHNNOCBALD PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6379FE0", Offset = "0x63789E0", VA = "0x186379FE0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface PIKFPPMJAOO
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJCCCONLIKP([In] HKEACMOHLFG NFPMCJDNMOC);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class ADOGDINBIPA : CMOGOIBCPNC<PIKFPPMJAOO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly HKEACMOHLFG NFPMCJDNMOC;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6378F20", Offset = "0x6377920", VA = "0x186378F20")]
	public ADOGDINBIPA(Guid[] KPHNKEODHPO, Vector3[] HEDBGGKMMHP, Quaternion[] KOGOLPJGANL, float[] MJENMFDCOFF, Dictionary<Guid, Vector3> MHHGPEABKBO, PIKFPPMJAOO PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6378E70", Offset = "0x6377870", VA = "0x186378E70", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface GAPALEOFIDO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAGCEOKHOIJ([In] GLOFCFADOJG<TData> ENOGLJIKJMA);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LGPOLLAENPI([In] PDGIAGCKAIB PEEHNJDICLA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LGPOLLAENPI([In] JPMLCIMBJEG PEEHNJDICLA);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JABHIELFENE();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class BOOFEIPMHJG<TData> : CMOGOIBCPNC<GAPALEOFIDO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x34D3220", Offset = "0x34D1C20", VA = "0x1834D3220")]
	public BOOFEIPMHJG(GAPALEOFIDO<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4972730", Offset = "0x4971130", VA = "0x184972730", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class PFJCFFNIJIB<TData> : CMOGOIBCPNC<GAPALEOFIDO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly PDGIAGCKAIB KPGAKHDPGJE;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x42FA240", Offset = "0x42F8C40", VA = "0x1842FA240")]
	public PFJCFFNIJIB(Vector3 PCNMLKMPELO, bool KJMCHIOCJEA, GAPALEOFIDO<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x34CF790", Offset = "0x34CE190", VA = "0x1834CF790", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class ECKDICCHEHF<TData> : CMOGOIBCPNC<GAPALEOFIDO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly JPMLCIMBJEG KPGAKHDPGJE;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x34D3380", Offset = "0x34D1D80", VA = "0x1834D3380")]
	public ECKDICCHEHF(Guid BINFNLCOEPK, int ABBNIPHGMGH, Vector3 DGOJEOCFHHN, Quaternion DMBBOEJIOJM, float JMJINJAJLIO, bool KJMCHIOCJEA, GAPALEOFIDO<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x34D3320", Offset = "0x34D1D20", VA = "0x1834D3320", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DIEHAIDOPIH<TData> : CMOGOIBCPNC<GAPALEOFIDO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly GLOFCFADOJG<TData> KPGAKHDPGJE;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5250700", Offset = "0x524F100", VA = "0x185250700")]
	public DIEHAIDOPIH(TData PJDANIPAHEH, bool IKJOLIBEGHM, GAPALEOFIDO<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x38BEFC0", Offset = "0x38BD9C0", VA = "0x1838BEFC0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct PDGIAGCKAIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Vector3 PCNMLKMPELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool KJMCHIOCJEA;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x637A290", Offset = "0x6378C90", VA = "0x18637A290")]
	public PDGIAGCKAIB(Vector3 PCNMLKMPELO, bool KJMCHIOCJEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct JPMLCIMBJEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Guid BINFNLCOEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int ABBNIPHGMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Vector3 DGOJEOCFHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Quaternion DMBBOEJIOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly float JMJINJAJLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly bool KJMCHIOCJEA;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6379F80", Offset = "0x6378980", VA = "0x186379F80")]
	public JPMLCIMBJEG(Guid BINFNLCOEPK, int ABBNIPHGMGH, Vector3 DGOJEOCFHHN, Quaternion DMBBOEJIOJM, float JMJINJAJLIO, bool KJMCHIOCJEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct GLOFCFADOJG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData PJDANIPAHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly bool IKJOLIBEGHM;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x39AE3F0", Offset = "0x39ACDF0", VA = "0x1839AE3F0")]
	public GLOFCFADOJG(TData PJDANIPAHEH, bool IKJOLIBEGHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface OIFALAONJKE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJCCCONLIKP([In] EDLFGGMLEPH<TData> EFDMBEAFCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJCCCONLIKP([In] JJNBHHBEPOO<TData> EFDMBEAFCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface BDFPOJLJFEO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAGCEOKHOIJ([In] BNPPCNELPLA<TData> HHEKIHGIPHM);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LGPOLLAENPI([In] BKMGJBCKOFF PEEHNJDICLA);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JABHIELFENE();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class DFFHPAMGNOP<TData> : CMOGOIBCPNC<OIFALAONJKE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly EDLFGGMLEPH<TData> EFDMBEAFCDJ;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x52487C0", Offset = "0x52471C0", VA = "0x1852487C0")]
	public DFFHPAMGNOP(IEnumerable<TData> FIFPHDINGFM, Vector3 FOMLFNHMJAE, bool IKJOLIBEGHM, OIFALAONJKE<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x38BEFC0", Offset = "0x38BD9C0", VA = "0x1838BEFC0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class AKJMCMHBLAA<TData> : CMOGOIBCPNC<BDFPOJLJFEO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x34D3220", Offset = "0x34D1C20", VA = "0x1834D3220")]
	public AKJMCMHBLAA(BDFPOJLJFEO<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x39798F0", Offset = "0x39782F0", VA = "0x1839798F0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FJHLEAKIAII<TData> : CMOGOIBCPNC<BDFPOJLJFEO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly BNPPCNELPLA<TData> EFDMBEAFCDJ;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x38BF080", Offset = "0x38BDA80", VA = "0x1838BF080")]
	public FJHLEAKIAII(IEnumerable<TData> FIFPHDINGFM, bool IKJOLIBEGHM, BDFPOJLJFEO<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x38BEFC0", Offset = "0x38BD9C0", VA = "0x1838BEFC0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class DHEDOACAHMH<TData> : CMOGOIBCPNC<OIFALAONJKE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JJNBHHBEPOO<TData> EFDMBEAFCDJ;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x524EE90", Offset = "0x524D890", VA = "0x18524EE90")]
	public DHEDOACAHMH(IEnumerable<TData> FIFPHDINGFM, Vector3 LNHMEHECDEE, AJJICCHDPPO AGEKEHJBIHF, bool IKJOLIBEGHM, OIFALAONJKE<TData> PENEHNLEHJA, Space KGCMBNPBJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3869890", Offset = "0x3868290", VA = "0x183869890", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class INICPHCDGCK<TData> : CMOGOIBCPNC<BDFPOJLJFEO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly BKMGJBCKOFF EFDMBEAFCDJ;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3AD4DE0", Offset = "0x3AD37E0", VA = "0x183AD4DE0")]
	public INICPHCDGCK(Vector3 FOMLFNHMJAE, BDFPOJLJFEO<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x34CF790", Offset = "0x34CE190", VA = "0x1834CF790", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct EDLFGGMLEPH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly IEnumerable<TData> FIFPHDINGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Vector3 FOMLFNHMJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly bool IKJOLIBEGHM;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x34D5250", Offset = "0x34D3C50", VA = "0x1834D5250")]
	public EDLFGGMLEPH(IEnumerable<TData> FIFPHDINGFM, Vector3 FOMLFNHMJAE, bool IKJOLIBEGHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct BNPPCNELPLA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> FIFPHDINGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool IKJOLIBEGHM;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4971340", Offset = "0x496FD40", VA = "0x184971340")]
	public BNPPCNELPLA(IEnumerable<TData> FIFPHDINGFM, bool IKJOLIBEGHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct JJNBHHBEPOO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly IEnumerable<TData> FIFPHDINGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 LNHMEHECDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly AJJICCHDPPO AGEKEHJBIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool IKJOLIBEGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Space KGCMBNPBJIP;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3C7F8B0", Offset = "0x3C7E2B0", VA = "0x183C7F8B0")]
	public JJNBHHBEPOO(IEnumerable<TData> FIFPHDINGFM, Vector3 LNHMEHECDEE, AJJICCHDPPO AGEKEHJBIHF, bool IKJOLIBEGHM, Space KGCMBNPBJIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct BKMGJBCKOFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Vector3 FOMLFNHMJAE;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x201A5E0", Offset = "0x2018FE0", VA = "0x18201A5E0")]
	public BKMGJBCKOFF(Vector3 FOMLFNHMJAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum AJJICCHDPPO
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface DAMEJPPKCGE
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJCCCONLIKP([In] NIAOCCHFCGD EBMANFKANIN);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class AAJEGGNPPPJ : CMOGOIBCPNC<DAMEJPPKCGE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly NIAOCCHFCGD EBMANFKANIN;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6378CC0", Offset = "0x63776C0", VA = "0x186378CC0")]
	public AAJEGGNPPPJ(bool IKJOLIBEGHM, DAMEJPPKCGE PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6378C10", Offset = "0x6377610", VA = "0x186378C10", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct NIAOCCHFCGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool IKJOLIBEGHM;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xCE6180", Offset = "0xCE4B80", VA = "0x180CE6180")]
	public NIAOCCHFCGD(bool IKJOLIBEGHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface IICNFJMFFGA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJCCCONLIKP([In] MKCDFHBBOHL<TData> KHHOCKEFFHB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJCCCONLIKP([In] JMLLOOALEFH<TData> KHHOCKEFFHB);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface KNBEFPCJNAE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAGCEOKHOIJ([In] BADKJDLKPIM<TData> ENOGLJIKJMA);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LGPOLLAENPI([In] EHKFFAJMDOD PEEHNJDICLA);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JABHIELFENE();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class MMDEMMFIKDI<TData> : CMOGOIBCPNC<IICNFJMFFGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly MKCDFHBBOHL<TData> KHHOCKEFFHB;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x404E1E0", Offset = "0x404CBE0", VA = "0x18404E1E0")]
	public MMDEMMFIKDI(IEnumerable<TData> FIFPHDINGFM, Quaternion FOMLFNHMJAE, Vector3? EICJGNOHILF, bool CKHNFCFONDE, bool IKJOLIBEGHM, IICNFJMFFGA<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x38BEFC0", Offset = "0x38BD9C0", VA = "0x1838BEFC0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class KKMAOHMCIDG<TData> : CMOGOIBCPNC<KNBEFPCJNAE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x34D3220", Offset = "0x34D1C20", VA = "0x1834D3220")]
	public KKMAOHMCIDG(KNBEFPCJNAE<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x39798F0", Offset = "0x39782F0", VA = "0x1839798F0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class NPINGHKNIIK<TData> : CMOGOIBCPNC<KNBEFPCJNAE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly BADKJDLKPIM<TData> KHHOCKEFFHB;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x40EBDC0", Offset = "0x40EA7C0", VA = "0x1840EBDC0")]
	public NPINGHKNIIK(IEnumerable<TData> FIFPHDINGFM, bool IKJOLIBEGHM, KNBEFPCJNAE<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x38BEFC0", Offset = "0x38BD9C0", VA = "0x1838BEFC0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class LGLBDJAJBEJ<TData> : CMOGOIBCPNC<IICNFJMFFGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly JMLLOOALEFH<TData> KHHOCKEFFHB;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3E3FCF0", Offset = "0x3E3E6F0", VA = "0x183E3FCF0")]
	public LGLBDJAJBEJ(IEnumerable<TData> FIFPHDINGFM, Quaternion KGABFOJCJIH, AJJICCHDPPO KCMFDMDGCIB, Vector3? EICJGNOHILF, bool CKHNFCFONDE, bool IKJOLIBEGHM, Space KGCMBNPBJIP, IICNFJMFFGA<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3869890", Offset = "0x3868290", VA = "0x183869890", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class EAPJKBMLLIB<TData> : CMOGOIBCPNC<KNBEFPCJNAE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly EHKFFAJMDOD KHHOCKEFFHB;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x34CF7F0", Offset = "0x34CE1F0", VA = "0x1834CF7F0")]
	public EAPJKBMLLIB(Quaternion FOMLFNHMJAE, Vector3? EICJGNOHILF, bool CKHNFCFONDE, KNBEFPCJNAE<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x34CF790", Offset = "0x34CE190", VA = "0x1834CF790", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct MKCDFHBBOHL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly IEnumerable<TData> FIFPHDINGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Quaternion FOMLFNHMJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3? EICJGNOHILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool CKHNFCFONDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool IKJOLIBEGHM;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4046F80", Offset = "0x4045980", VA = "0x184046F80")]
	public MKCDFHBBOHL(IEnumerable<TData> FIFPHDINGFM, Quaternion FOMLFNHMJAE, Vector3? EICJGNOHILF, bool CKHNFCFONDE, bool IKJOLIBEGHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct BADKJDLKPIM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> FIFPHDINGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool IKJOLIBEGHM;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x491DB40", Offset = "0x491C540", VA = "0x18491DB40")]
	public BADKJDLKPIM(IEnumerable<TData> FIFPHDINGFM, bool IKJOLIBEGHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct JMLLOOALEFH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly IEnumerable<TData> FIFPHDINGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Quaternion KGABFOJCJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly AJJICCHDPPO KCMFDMDGCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3? EICJGNOHILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool CKHNFCFONDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool IKJOLIBEGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Space KGCMBNPBJIP;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3C87B80", Offset = "0x3C86580", VA = "0x183C87B80")]
	public JMLLOOALEFH(IEnumerable<TData> FIFPHDINGFM, Quaternion KGABFOJCJIH, AJJICCHDPPO KCMFDMDGCIB, Vector3? EICJGNOHILF, bool CKHNFCFONDE, bool IKJOLIBEGHM, Space KGCMBNPBJIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct EHKFFAJMDOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Quaternion FOMLFNHMJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3? EICJGNOHILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool CKHNFCFONDE;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4794E90", Offset = "0x4793890", VA = "0x184794E90")]
	public EHKFFAJMDOD(Quaternion FOMLFNHMJAE, Vector3? EICJGNOHILF, bool CKHNFCFONDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface DJFBLGGCBLK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAGCEOKHOIJ([In] LMHDPJEKHCI<TData> ENOGLJIKJMA);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LGPOLLAENPI([In] ICLKLIHCKIN PEEHNJDICLA);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LGPOLLAENPI([In] PPBAEEKPOAC PEEHNJDICLA);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LGPOLLAENPI([In] HDGHLDCCLMJ PEEHNJDICLA);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JABHIELFENE();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class AMJEIELNAAB<TData> : CMOGOIBCPNC<DJFBLGGCBLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly HDGHLDCCLMJ LNKEBOEDLHB;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x397B9C0", Offset = "0x397A3C0", VA = "0x18397B9C0")]
	public AMJEIELNAAB(Vector3 JMGJAOFIAKA, float BFAOHJDJGOF, Vector3 EICJGNOHILF, bool LDBPEPOLHOB, bool NEBEHHIIOLG, DJFBLGGCBLK<TData> PENEHNLEHJA, Space KGCMBNPBJIP = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x397B960", Offset = "0x397A360", VA = "0x18397B960", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class LCLNMFMEPMF<TData> : CMOGOIBCPNC<DJFBLGGCBLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x34D3220", Offset = "0x34D1C20", VA = "0x1834D3220")]
	public LCLNMFMEPMF(DJFBLGGCBLK<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3E28030", Offset = "0x3E26A30", VA = "0x183E28030", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class LJNGHBFBPNA<TData> : CMOGOIBCPNC<DJFBLGGCBLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly LMHDPJEKHCI<TData> LNKEBOEDLHB;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3E50080", Offset = "0x3E4EA80", VA = "0x183E50080")]
	public LJNGHBFBPNA(IEnumerable<TData> FIFPHDINGFM, bool IKJOLIBEGHM, DJFBLGGCBLK<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x38BEFC0", Offset = "0x38BD9C0", VA = "0x1838BEFC0", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class GGCENIDHHOC<TData> : CMOGOIBCPNC<DJFBLGGCBLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly PPBAEEKPOAC LNKEBOEDLHB;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x39812D0", Offset = "0x397FCD0", VA = "0x1839812D0")]
	public GGCENIDHHOC(float EBANODNEOPI, bool IECBDMGGCLH, Vector3 EICJGNOHILF, DJFBLGGCBLK<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3981210", Offset = "0x397FC10", VA = "0x183981210", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class BFAINJLFCPE<TData> : CMOGOIBCPNC<DJFBLGGCBLK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly ICLKLIHCKIN LNKEBOEDLHB;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4940D80", Offset = "0x493F780", VA = "0x184940D80")]
	public BFAINJLFCPE(float BFAOHJDJGOF, Vector3 EICJGNOHILF, DJFBLGGCBLK<TData> PENEHNLEHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x34CF790", Offset = "0x34CE190", VA = "0x1834CF790", Slot = "4")]
	public override bool AJCCCONLIKP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct HDGHLDCCLMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 JMGJAOFIAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly float BFAOHJDJGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 EICJGNOHILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool KJMCHIOCJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space KGCMBNPBJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly bool NEBEHHIIOLG;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6379AE0", Offset = "0x63784E0", VA = "0x186379AE0")]
	public HDGHLDCCLMJ(Vector3 JMGJAOFIAKA, float BFAOHJDJGOF, Vector3 EICJGNOHILF, bool KJMCHIOCJEA, bool LEHGEMEPHCE, Space KGCMBNPBJIP = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct LMHDPJEKHCI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> FIFPHDINGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool IKJOLIBEGHM;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3E54230", Offset = "0x3E52C30", VA = "0x183E54230")]
	public LMHDPJEKHCI(IEnumerable<TData> FIFPHDINGFM, bool IKJOLIBEGHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct PPBAEEKPOAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly float EBANODNEOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool IECBDMGGCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly Vector3 EICJGNOHILF;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x637A2B0", Offset = "0x6378CB0", VA = "0x18637A2B0")]
	public PPBAEEKPOAC(float EBANODNEOPI, bool IECBDMGGCLH, Vector3 EICJGNOHILF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct ICLKLIHCKIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly float BFAOHJDJGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 EICJGNOHILF;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4769270", Offset = "0x4767C70", VA = "0x184769270")]
	public ICLKLIHCKIN(float BFAOHJDJGOF, Vector3 EICJGNOHILF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct HKEACMOHLFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Guid[] FIFPHDINGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly bool BIIFGEKLIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool GDDGHJIKJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool BLAHEMDGANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Vector3[] HEDBGGKMMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion[] KOGOLPJGANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly float[] MJENMFDCOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Dictionary<Guid, Vector3> MHHGPEABKBO;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6379CF0", Offset = "0x63786F0", VA = "0x186379CF0")]
	public HKEACMOHLFG(Guid[] KPHNKEODHPO, Vector3[] HEDBGGKMMHP, Quaternion[] KOGOLPJGANL, float[] MJENMFDCOFF, Dictionary<Guid, Vector3> MHHGPEABKBO, bool BIIFGEKLIOA = true, bool GDDGHJIKJLB = true, bool BLAHEMDGANN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6379B20", Offset = "0x6378520", VA = "0x186379B20")]
	private static void LCEPMPHPLFG(Dictionary<Guid, Vector3> MHHGPEABKBO, int HPCCGIDOCEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class CKBNOLNKFLN
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct NHAHNCOPCGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool JLJBPLCDMEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public ICKBMMGCCPN BKLGPGPAEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public ICKBMMGCCPN BLBFGMLANLJ;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static NHAHNCOPCGC HOBJPGDHGCP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken AFLNKCOGPJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6379340", Offset = "0x6377D40", VA = "0x186379340")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static ICKBMMGCCPN BKLGPGPAEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x63792A0", Offset = "0x6377CA0", VA = "0x1863792A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6379360", Offset = "0x6377D60", VA = "0x186379360")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x63793D0", Offset = "0x6377DD0", VA = "0x1863793D0")]
	[JCOMPLNHMEG(EEKBGOJGGBC.Room, AOHDMBIABEL.None)]
	private static void PPNLMJNBNPK(ICKBMMGCCPN CCIDFIDBIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6379100", Offset = "0x6377B00", VA = "0x186379100")]
	public static void EMPGGONCJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6379250", Offset = "0x6377C50", VA = "0x186379250")]
	private static ICKBMMGCCPN GIHKNFHGDOJ(ICKBMMGCCPN BILADBMKLJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class NDEPOLOMDLN
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum BICNFMEBMPK
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CFA0", Offset = "0x2A7B9A0", VA = "0x182A7CFA0")]
	public static void IIOCNBBJHAM<T>(T CCFMNFKDGPF, BICNFMEBMPK CGEOAHHPHHK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D0E0", Offset = "0x2A7BAE0", VA = "0x182A7D0E0")]
	public static void IIOCNBBJHAM<T>(T CCFMNFKDGPF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CF30", Offset = "0x2A7B930", VA = "0x182A7CF30")]
	public static void CBOBCACJEDP<T>(T CCFMNFKDGPF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D310", Offset = "0x2A7BD10", VA = "0x182A7D310")]
	public static T OIFPBAJNOAG<T>(BICNFMEBMPK CGEOAHHPHHK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D1E0", Offset = "0x2A7BBE0", VA = "0x182A7D1E0")]
	public static bool NLEJDEABFNF<T>(BICNFMEBMPK CGEOAHHPHHK, T OMGHMMBJEDD, [Out] T OEEANIMJPFP) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CE90", Offset = "0x2A7B890", VA = "0x182A7CE90")]
	public static bool BKDIJCLPJLB<T>(BICNFMEBMPK CGEOAHHPHHK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CE50", Offset = "0x2A7B850", VA = "0x182A7CE50")]
	public static T OIFPBAJNOAG<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D140", Offset = "0x2A7BB40", VA = "0x182A7D140")]
	public static bool NLEJDEABFNF<T>(T OMGHMMBJEDD, [Out] T OEEANIMJPFP) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CE50", Offset = "0x2A7B850", VA = "0x182A7CE50")]
	public static bool BKDIJCLPJLB<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class GPOLGDBNGCK
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x63798B0", Offset = "0x63782B0", VA = "0x1863798B0")]
	public static void AKPIHGNMLAF(IEnumerable LDDLHDBJFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2963600", Offset = "0x2962000", VA = "0x182963600")]
	public static void AKPIHGNMLAF<T>(T[] KKAKPOKBAHF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x29637E0", Offset = "0x29621E0", VA = "0x1829637E0")]
	public static void AKPIHGNMLAF<T>(T OPIDCOCFJHF) where T : notnull, Enum
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
