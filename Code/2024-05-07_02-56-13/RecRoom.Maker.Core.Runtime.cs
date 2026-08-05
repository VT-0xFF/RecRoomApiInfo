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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x622B220", Offset = "0x622A420", VA = "0x18622B220")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NAKLIKKFBMC<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn OFEDOJJANLA(TData JFJMICPDNDH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EMCNAEGOAMB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(IBEKJPGKKNB FNPHEBAPPNP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData IOCBLPNBBJM, Collider PEHJDKLHGFA, IBEKJPGKKNB FNPHEBAPPNP, [Optional] AAFKKJIDNGJ? OIKFFLJGNAF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData IOCBLPNBBJM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider PEHJDKLHGFA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HPHLBIOEPPK<TData> : GPKGOEIPOCK, NADHBKJFNEP<TData>, DIPHDIKGLJF<TData>, HOIBAGGCILL<TData>, JHEPDGEKBCD, LBNJNAGFFON<TData>, KHBMOBNOEIE, OMBPKNAJMCL
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LBNJNAGFFON<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 JJLFBACIKHP, Vector3 ILKFGPOHBIP, float HJPKMNIGHNC, [Out] T AHGHEKOEOEK, [Out] Vector3 LDIFDNLMKIN, [Out] Collider PEHJDKLHGFA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 JJLFBACIKHP, Vector3 ILKFGPOHBIP, float OKGKDCKCCDA, float HJPKMNIGHNC, T[] PMPLMIGILDG, [Out] Vector3 OPLOCJPGLBO, [Out] Collider HNNNFJGBMKM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 JJLFBACIKHP, float OKGKDCKCCDA, Vector3 MPNNMLJLDFN, T[] PMPLMIGILDG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider ENONIHHKHLG, [Out] T MNEMDMNGBBM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GPKGOEIPOCK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds GKKGNKIBPME
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform BJMFPKKCBBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds LAIKILGCIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform IKBMALPJKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 NGFLMGOACEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OMMKNLBMAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool AMECKAFBFKH = true, int AAIFMFADFFD = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool KMKPNMHPDAA, object FCKLPDKGPKE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OMBPKNAJMCL
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	AGKHEGBIBIG FCICJFGMHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IIPNLPLHLHE
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool LLPLEEDNGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool FIOJGKFACFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool ACMPAGGCGIB
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> JBKHLEMBGAH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HOIBAGGCILL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool DKGHBDFHHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int ECHEEPOKFAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> NPMIILIDFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData DMLEKJCHBDC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData DMLEKJCHBDC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NADHBKJFNEP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T JFJMICPDNDH, [Optional] AAFKKJIDNGJ? OBOFIGAGAMN, bool CDCIBEFFMLI = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int KIGJDGACGDD, IEnumerable<T> JOLHBAIGFNI, bool CDCIBEFFMLI = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int KIGJDGACGDD, IEnumerable<T> JOLHBAIGFNI, AAFKKJIDNGJ OBOFIGAGAMN, bool CDCIBEFFMLI = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KHBMOBNOEIE
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JHEPDGEKBCD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool CEHMEMCPGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool CNNCCIDLOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool ODABJGFNOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool AHDPNLOMAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class INKGOCPPFEB<TReceiver> : APNAKHJDBKM<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x34A6D60", Offset = "0x34A5F60", VA = "0x1834A6D60")]
	public INKGOCPPFEB(TReceiver LNCHGILPLKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class MKNKBHNFNBO<TReceiver, TFromTask> : APNAKHJDBKM<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x34A6D60", Offset = "0x34A5F60", VA = "0x1834A6D60")]
	public MKNKBHNFNBO(TReceiver LNCHGILPLKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class APNAKHJDBKM<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver LNCHGILPLKL;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3B07BA0", Offset = "0x3B06DA0", VA = "0x183B07BA0")]
	public APNAKHJDBKM(TReceiver LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute CHEEFNHIJMB();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class LBLMJPDPIOP<TReceiver, TResult> : APNAKHJDBKM<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x34A6D60", Offset = "0x34A5F60", VA = "0x1834A6D60")]
	public LBLMJPDPIOP(TReceiver LNCHGILPLKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct DLBHLGGGJFL<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup DAIOGKGNLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData OBMILMLOLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> AJFGAHBJKJP;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1B72450", Offset = "0x1B71650", VA = "0x181B72450")]
	public DLBHLGGGJFL(TGroup MDKBLKPENGB, TData JLODJMBCOBO, IEnumerable<TData> BFGHGPDGFOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct AOJBJADILPK<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup DAIOGKGNLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> AJFGAHBJKJP;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x947190", Offset = "0x946390", VA = "0x180947190")]
	public AOJBJADILPK(TGroup MDKBLKPENGB, IEnumerable<TData> BFGHGPDGFOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DJCOOEOAOJF<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup DAIOGKGNLCP;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
	public DJCOOEOAOJF(TGroup MDKBLKPENGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OIGMOLPMEDP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> AJFGAHBJKJP;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
	public OIGMOLPMEDP(IEnumerable<TData> BFGHGPDGFOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HBIAEFGHPKN<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HCHPNLFKFPJ LPAFBBFGCBM(DLBHLGGGJFL<TGroup, TData> MAIJDIMADAJ);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HCHPNLFKFPJ BELGKAMHALP(DLBHLGGGJFL<TGroup, TData> MAIJDIMADAJ);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HCHPNLFKFPJ CPOOABKKHGD(AOJBJADILPK<TGroup, TData> MAIJDIMADAJ);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HCHPNLFKFPJ GILMOKDAMGM(DJCOOEOAOJF<TGroup> MAIJDIMADAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BDLMMKBGGBI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HCHPNLFKFPJ> LPAFBBFGCBM(OIGMOLPMEDP<TData> MAIJDIMADAJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DAJMMJNEKDB<TGroup, TData> : LBLMJPDPIOP<HBIAEFGHPKN<TGroup, TData>, HCHPNLFKFPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly AOJBJADILPK<TGroup, TData> MAIJDIMADAJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x50FBFA0", Offset = "0x50FB1A0", VA = "0x1850FBFA0")]
	public DAJMMJNEKDB(TGroup MDKBLKPENGB, IEnumerable<TData> BFGHGPDGFOP, HBIAEFGHPKN<TGroup, TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x50FBED0", Offset = "0x50FB0D0", VA = "0x1850FBED0", Slot = "4")]
	public override HCHPNLFKFPJ CHEEFNHIJMB()
	{
		return default(HCHPNLFKFPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KMOKHGGFGNJ<TGroup, TData> : LBLMJPDPIOP<HBIAEFGHPKN<TGroup, TData>, HCHPNLFKFPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DLBHLGGGJFL<TGroup, TData> MAIJDIMADAJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x38818A0", Offset = "0x3880AA0", VA = "0x1838818A0")]
	public KMOKHGGFGNJ(TGroup MDKBLKPENGB, TData JHOKFGNHKCF, IEnumerable<TData> BFGHGPDGFOP, HBIAEFGHPKN<TGroup, TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4BD0", Offset = "0x3CB3DD0", VA = "0x183CB4BD0", Slot = "4")]
	public override HCHPNLFKFPJ CHEEFNHIJMB()
	{
		return default(HCHPNLFKFPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HDBNLAJAHFN<TGroup, TData> : LBLMJPDPIOP<HBIAEFGHPKN<TGroup, TData>, HCHPNLFKFPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly DJCOOEOAOJF<TGroup> MAIJDIMADAJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x389F090", Offset = "0x389E290", VA = "0x18389F090")]
	public HDBNLAJAHFN(TGroup MDKBLKPENGB, HBIAEFGHPKN<TGroup, TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x391DD60", Offset = "0x391CF60", VA = "0x18391DD60", Slot = "4")]
	public override HCHPNLFKFPJ CHEEFNHIJMB()
	{
		return default(HCHPNLFKFPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ADLEBNANAOC<TGroup, TData> : LBLMJPDPIOP<HBIAEFGHPKN<TGroup, TData>, HCHPNLFKFPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DLBHLGGGJFL<TGroup, TData> MAIJDIMADAJ;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x38818A0", Offset = "0x3880AA0", VA = "0x1838818A0")]
	public ADLEBNANAOC(TGroup MDKBLKPENGB, TData JLODJMBCOBO, IEnumerable<TData> BFGHGPDGFOP, HBIAEFGHPKN<TGroup, TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x38817C0", Offset = "0x38809C0", VA = "0x1838817C0", Slot = "4")]
	public override HCHPNLFKFPJ CHEEFNHIJMB()
	{
		return default(HCHPNLFKFPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GBLJLIAGLDE<TData> : MKNKBHNFNBO<BDLMMKBGGBI<TData>, HCHPNLFKFPJ> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct LDONNHKGMHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<HCHPNLFKFPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public GBLJLIAGLDE<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<HCHPNLFKFPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3D234D0", Offset = "0x3D226D0", VA = "0x183D234D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3D23770", Offset = "0x3D22970", VA = "0x183D23770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private OIGMOLPMEDP<TData> MAIJDIMADAJ;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x389F090", Offset = "0x389E290", VA = "0x18389F090")]
	public GBLJLIAGLDE(IEnumerable<TData> FOOAAEPEGNN, BDLMMKBGGBI<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x389EF90", Offset = "0x389E190", VA = "0x18389EF90", Slot = "4")]
	[AsyncStateMachine(typeof(GBLJLIAGLDE<>.LDONNHKGMHH))]
	public override Task<HCHPNLFKFPJ> CHEEFNHIJMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct JOBMAHLIGCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly JEOLPGJDPHB GKKJNNILMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool JICMENIJKBL;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x622B0C0", Offset = "0x622A2C0", VA = "0x18622B0C0")]
	public JOBMAHLIGCB(JEOLPGJDPHB EEMGDJHEODG, bool GKIPGKLCFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EHAKDPPAHJC<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> CHEEFNHIJMB(JOBMAHLIGCB NMBPMJDFIFB);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NECNNEJLNDG<TSpawnType> : MKNKBHNFNBO<EHAKDPPAHJC<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct CDBJLHHHKNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NECNNEJLNDG<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4B58660", Offset = "0x4B57860", VA = "0x184B58660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3459740", Offset = "0x3458940", VA = "0x183459740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly JOBMAHLIGCB NMBPMJDFIFB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4008770", Offset = "0x4007970", VA = "0x184008770")]
	public NECNNEJLNDG(JEOLPGJDPHB EEMGDJHEODG, bool GKIPGKLCFML, EHAKDPPAHJC<TSpawnType> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4008680", Offset = "0x4007880", VA = "0x184008680", Slot = "4")]
	[AsyncStateMachine(typeof(NECNNEJLNDG<>.CDBJLHHHKNJ))]
	public override Task<TSpawnType> CHEEFNHIJMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct JEOLPGJDPHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool NDIOELEKKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 GDFBIKCODFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 MFDMLPFPBCO;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x622B030", Offset = "0x622A230", VA = "0x18622B030")]
	public JEOLPGJDPHB(Transform EJGELAJLAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x622B000", Offset = "0x622A200", VA = "0x18622B000")]
	public JEOLPGJDPHB(Vector3 IAAOFHLOLIL, Vector3 DHMMMGDKPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x622AF50", Offset = "0x622A150", VA = "0x18622AF50")]
	public static JEOLPGJDPHB GJIFFJEBAAL()
	{
		return default(JEOLPGJDPHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x622AF80", Offset = "0x622A180", VA = "0x18622AF80")]
	private JEOLPGJDPHB(bool HHBHIGKFONI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct KBKCPGFNOPI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode MMHCOHHLHEF;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3C690A0", Offset = "0x3C682A0", VA = "0x183C690A0")]
	public KBKCPGFNOPI(TNode MMHCOHHLHEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct IPEFODAPCLP<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode EOENFJBONPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public PCECEFNCHKN EHIPJJLHBIN;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3A63310", Offset = "0x3A62510", VA = "0x183A63310")]
	public IPEFODAPCLP(TNode EOENFJBONPD, PCECEFNCHKN EHIPJJLHBIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface CAMKCKADGEN<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HDNNHINGOCJ([In] KBKCPGFNOPI<TNode> CKCNAMCJEMM);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NNHLIKCGNEP([In] IPEFODAPCLP<TNode> AEKILMDCJEA);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CABNLIKLBBL();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class GPPNABCEGOF<TNode> : INKGOCPPFEB<CAMKCKADGEN<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x34A6D60", Offset = "0x34A5F60", VA = "0x1834A6D60")]
	public GPPNABCEGOF(CAMKCKADGEN<TNode> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x34A6D10", Offset = "0x34A5F10", VA = "0x1834A6D10", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KFILPEONAPI<TNode> : INKGOCPPFEB<CAMKCKADGEN<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IPEFODAPCLP<TNode> AEKILMDCJEA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3C79690", Offset = "0x3C78890", VA = "0x183C79690")]
	public KFILPEONAPI(TNode EOENFJBONPD, PCECEFNCHKN EHIPJJLHBIN, CAMKCKADGEN<TNode> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3C795C0", Offset = "0x3C787C0", VA = "0x183C795C0", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class ODAANCGGAKN<TNode> : INKGOCPPFEB<CAMKCKADGEN<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly KBKCPGFNOPI<TNode> CKCNAMCJEMM;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x41336F0", Offset = "0x41328F0", VA = "0x1841336F0")]
	public ODAANCGGAKN(TNode MDJAFNKLAMP, CAMKCKADGEN<TNode> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x389F100", Offset = "0x389E300", VA = "0x18389F100", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct IEICJPAGJIP<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo BCBGHBFBBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 DHMMMGDKPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion HBCECKEGCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float EKCHLHLGOBO;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D190", Offset = "0x3A3C390", VA = "0x183A3D190")]
	public IEICJPAGJIP(TSpawnInfo BCBGHBFBBLP, Vector3 DHMMMGDKPCG, Quaternion HBCECKEGCGH, float EKCHLHLGOBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HMHBAMCKFJD<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> ELAOAIEEPMN([In] IEICJPAGJIP<TSpawnInfo> CPFMFJCAGCH, CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class HDELBLHPLBE<TSpawnType, TSpawnInfo> : MKNKBHNFNBO<HMHBAMCKFJD<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEICJPAGJIP<TSpawnInfo> JPEJCADBOCG;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x391EA00", Offset = "0x391DC00", VA = "0x18391EA00")]
	public HDELBLHPLBE(TSpawnInfo GOIKJIPGHFB, Vector3 DHMMMGDKPCG, Quaternion HBCECKEGCGH, float EKCHLHLGOBO, HMHBAMCKFJD<TSpawnType, TSpawnInfo> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x391E820", Offset = "0x391DA20", VA = "0x18391E820", Slot = "4")]
	public override Task<TSpawnType> CHEEFNHIJMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct GELFFCBLDAP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> AJFGAHBJKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool JICMENIJKBL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x38AE380", Offset = "0x38AD580", VA = "0x1838AE380")]
	public GELFFCBLDAP(IEnumerable<TData> BFGHGPDGFOP, bool GKIPGKLCFML = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface AKHAAHIBIGL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HCHPNLFKFPJ> PODPACJAOKP([In] GELFFCBLDAP<TData> NHLLLGLKFNA, CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class MOHFEOCGFLK<TData> : MKNKBHNFNBO<AKHAAHIBIGL<TData>, HCHPNLFKFPJ> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly GELFFCBLDAP<TData> EDBBOIOIFDP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3FA05E0", Offset = "0x3F9F7E0", VA = "0x183FA05E0")]
	public MOHFEOCGFLK(IEnumerable<TData> BFGHGPDGFOP, bool GKIPGKLCFML, AKHAAHIBIGL<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x391E820", Offset = "0x391DA20", VA = "0x18391E820", Slot = "4")]
	public override Task<HCHPNLFKFPJ> CHEEFNHIJMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct CPKAMDBOIMN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T IOCBLPNBBJM;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A170", Offset = "0x3C69370", VA = "0x183C6A170")]
	public CPKAMDBOIMN(T PIODIMJLEEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface OOPIMFDEELH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HDNNHINGOCJ([In] CPKAMDBOIMN<T> GOLPNIALJGF);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NNHLIKCGNEP();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface OGAGPCENHBN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHEEFNHIJMB([In] MLGFHOMNAJP<T> KFBAKAOHHNP);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct MLGFHOMNAJP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T IOCBLPNBBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool EMLMEPNEMPA;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3F7CD80", Offset = "0x3F7BF80", VA = "0x183F7CD80")]
	public MLGFHOMNAJP(T PIODIMJLEEM, bool GEJNOKIONJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class KBGHGALHLJJ<T> : INKGOCPPFEB<OOPIMFDEELH<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x34A6D60", Offset = "0x34A5F60", VA = "0x1834A6D60")]
	public KBGHGALHLJJ(OOPIMFDEELH<T> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3C679D0", Offset = "0x3C66BD0", VA = "0x183C679D0", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class DKOBMJGPOIL<T> : INKGOCPPFEB<OOPIMFDEELH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly CPKAMDBOIMN<T> GOLPNIALJGF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x512B1F0", Offset = "0x512A3F0", VA = "0x18512B1F0")]
	public DKOBMJGPOIL(T IOCBLPNBBJM, OOPIMFDEELH<T> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x389F100", Offset = "0x389E300", VA = "0x18389F100", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class BLBMBMDIBBM<T> : INKGOCPPFEB<OGAGPCENHBN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly MLGFHOMNAJP<T> KFBAKAOHHNP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x48A9390", Offset = "0x48A8590", VA = "0x1848A9390")]
	public BLBMBMDIBBM(T IOCBLPNBBJM, bool GEJNOKIONJM, OGAGPCENHBN<T> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x389F100", Offset = "0x389E300", VA = "0x18389F100", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NGPKOIJIPBF<TData> where TData : notnull, GHELFKEAPAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> AJFGAHBJKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool PMKGFAEAHKO;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4040EC0", Offset = "0x40400C0", VA = "0x184040EC0")]
	public NGPKOIJIPBF(IEnumerable<TData> GMDHCLNHMAN, bool DEBCBDNGDLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct HAOELOEEPGC<TData> where TData : notnull, GHELFKEAPAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> AJFGAHBJKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> OAJGBMPIKOH;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x39135F0", Offset = "0x39127F0", VA = "0x1839135F0")]
	public HAOELOEEPGC(List<TData> GMDHCLNHMAN, List<bool> JJHHLMGJJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface GHELFKEAPAC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool CFMPHBNKPNG
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
public interface GMKMDIFFJAJ<TData> where TData : GHELFKEAPAC
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHEEFNHIJMB([In] NGPKOIJIPBF<TData> ENMAGMLABJP);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHEEFNHIJMB([In] HAOELOEEPGC<TData> ENMAGMLABJP);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JBKIJDJILGL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPDCPNGFMJC(T IOCBLPNBBJM);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class DNIJMKDKKFC<TData> : INKGOCPPFEB<GMKMDIFFJAJ<TData>> where TData : notnull, GHELFKEAPAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly NGPKOIJIPBF<TData> ENMAGMLABJP;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5135A60", Offset = "0x5134C60", VA = "0x185135A60")]
	public DNIJMKDKKFC(List<TData> BFGHGPDGFOP, bool PMKGFAEAHKO, GMKMDIFFJAJ<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x389F100", Offset = "0x389E300", VA = "0x18389F100", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class IONIHEBGEIE<TData> : INKGOCPPFEB<GMKMDIFFJAJ<TData>> where TData : notnull, GHELFKEAPAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HAOELOEEPGC<TData> ENMAGMLABJP;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3A61F40", Offset = "0x3A61140", VA = "0x183A61F40")]
	public IONIHEBGEIE(List<TData> BFGHGPDGFOP, List<bool> OAJGBMPIKOH, GMKMDIFFJAJ<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3A61E80", Offset = "0x3A61080", VA = "0x183A61E80", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface LACKCMAMFED<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HCHPNLFKFPJ> CHEEFNHIJMB(JOGMBILOGJN<TData> OJDJJAHAEAL);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class HFPEDMGFAJO<TData> : MKNKBHNFNBO<LACKCMAMFED<TData>, HCHPNLFKFPJ> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct ELEFNHKIIBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<HCHPNLFKFPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public HFPEDMGFAJO<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<HCHPNLFKFPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x348BB90", Offset = "0x348AD90", VA = "0x18348BB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x348BE70", Offset = "0x348B070", VA = "0x18348BE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JOGMBILOGJN<TData> FGJLHFBEBJD;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3920E10", Offset = "0x3920010", VA = "0x183920E10")]
	public HFPEDMGFAJO(TData LFKPBKADJDD, IReadOnlyList<TData> OHPIFHFHDPB, bool GKIPGKLCFML, LACKCMAMFED<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3920D10", Offset = "0x391FF10", VA = "0x183920D10", Slot = "4")]
	[AsyncStateMachine(typeof(HFPEDMGFAJO<>.ELEFNHKIIBC))]
	public override Task<HCHPNLFKFPJ> CHEEFNHIJMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct JOGMBILOGJN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData LLAGHIGNLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> DOPOIOJPAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool JICMENIJKBL;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3C33E30", Offset = "0x3C33030", VA = "0x183C33E30")]
	public JOGMBILOGJN(TData LFKPBKADJDD, IReadOnlyList<TData> OHPIFHFHDPB, bool GKIPGKLCFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface DFNBPAEKCCM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHEEFNHIJMB([In] COLLCJDFMGH<TData> LOLGMFMAMGK);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface MLEJNGGLEMC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHEEFNHIJMB([In] ABFPODPEJDI<TData> LOLGMFMAMGK);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface GKKKIJBIKNE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEEICNBMHJO([In] EKMGNNCALPH<TData> LOLGMFMAMGK);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNHLIKCGNEP();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class NAGHLGMHNNJ<TData> : INKGOCPPFEB<DFNBPAEKCCM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly COLLCJDFMGH<TData> LOLGMFMAMGK;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3FE5950", Offset = "0x3FE4B50", VA = "0x183FE5950")]
	public NAGHLGMHNNJ(IEnumerable<TData> BFGHGPDGFOP, PKCCLILNAJO NHDAKDKKMHH, CCCIGOAJIIL PEGNOKKFPLO, float MNOPOJJJBED, bool GKIPGKLCFML, DFNBPAEKCCM<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x389F100", Offset = "0x389E300", VA = "0x18389F100", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class PAPKIJACPHA<TData> : INKGOCPPFEB<MLEJNGGLEMC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly ABFPODPEJDI<TData> LOLGMFMAMGK;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4257820", Offset = "0x4256A20", VA = "0x184257820")]
	public PAPKIJACPHA(TData[] BFGHGPDGFOP, PKCCLILNAJO[] NHDAKDKKMHH, CCCIGOAJIIL[] PEGNOKKFPLO, float[] MNOPOJJJBED, MLEJNGGLEMC<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x391F960", Offset = "0x391EB60", VA = "0x18391F960", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class BFBOAIIKEIL<TData> : INKGOCPPFEB<GKKKIJBIKNE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x34A6D60", Offset = "0x34A5F60", VA = "0x1834A6D60")]
	public BFBOAIIKEIL(GKKKIJBIKNE<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4894D70", Offset = "0x4893F70", VA = "0x184894D70", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class HEFCFODPPIJ<TData> : INKGOCPPFEB<GKKKIJBIKNE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly EKMGNNCALPH<TData> LOLGMFMAMGK;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x391FA20", Offset = "0x391EC20", VA = "0x18391FA20")]
	public HEFCFODPPIJ(IEnumerable<TData> BFGHGPDGFOP, PKCCLILNAJO NHDAKDKKMHH, CCCIGOAJIIL PEGNOKKFPLO, float MNOPOJJJBED, GKKKIJBIKNE<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x391F960", Offset = "0x391EB60", VA = "0x18391F960", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct COLLCJDFMGH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> AJFGAHBJKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public PKCCLILNAJO MKJPAJDIBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public CCCIGOAJIIL OHGAACDKLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float MNOPOJJJBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool GKIPGKLCFML;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4C3FA70", Offset = "0x4C3EC70", VA = "0x184C3FA70")]
	public COLLCJDFMGH(IEnumerable<TData> BFGHGPDGFOP, PKCCLILNAJO NHDAKDKKMHH, CCCIGOAJIIL PEGNOKKFPLO, float MNOPOJJJBED, bool GKIPGKLCFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct ABFPODPEJDI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] AJFGAHBJKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public PKCCLILNAJO[] MKJPAJDIBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public CCCIGOAJIIL[] OHGAACDKLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] MNOPOJJJBED;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x387A0C0", Offset = "0x38792C0", VA = "0x18387A0C0")]
	public ABFPODPEJDI(TData[] BFGHGPDGFOP, PKCCLILNAJO[] NHDAKDKKMHH, CCCIGOAJIIL[] PEGNOKKFPLO, float[] MNOPOJJJBED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct EKMGNNCALPH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> AJFGAHBJKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public PKCCLILNAJO MKJPAJDIBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public CCCIGOAJIIL OHGAACDKLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float MNOPOJJJBED;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x348B710", Offset = "0x348A910", VA = "0x18348B710")]
	public EKMGNNCALPH(IEnumerable<TData> BFGHGPDGFOP, PKCCLILNAJO NHDAKDKKMHH, CCCIGOAJIIL PEGNOKKFPLO, float MNOPOJJJBED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface DIPHDIKGLJF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CPOOABKKHGD([In] MPNNAOPONNO<TData> NHLLLGLKFNA);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GILMOKDAMGM([In] MPNNAOPONNO<TData> NHLLLGLKFNA);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIIPCFPENKG([In] bool OBGIHJDNOAI);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NLNFBNIGDEN([In] MPNNAOPONNO<TData> NHLLLGLKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OIHMPHCNJMH();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KHAGINMLACE([In] TData GBJHIGKOMJM);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class GBPJCCOFINF<TData> : INKGOCPPFEB<DIPHDIKGLJF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly MPNNAOPONNO<TData> NHLLLGLKFNA;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x389F250", Offset = "0x389E450", VA = "0x18389F250")]
	public GBPJCCOFINF(List<TData> NOIICBHICIJ, DIPHDIKGLJF<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x389F100", Offset = "0x389E300", VA = "0x18389F100", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class OOABKJJLKOO<TData> : INKGOCPPFEB<DIPHDIKGLJF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x34A6D60", Offset = "0x34A5F60", VA = "0x1834A6D60")]
	public OOABKJJLKOO(DIPHDIKGLJF<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x41CA9E0", Offset = "0x41C9BE0", VA = "0x1841CA9E0", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class HMKFPJIIDNB<TData> : INKGOCPPFEB<DIPHDIKGLJF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool GKIPGKLCFML;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x39880E0", Offset = "0x39872E0", VA = "0x1839880E0")]
	public HMKFPJIIDNB(bool GKIPGKLCFML, DIPHDIKGLJF<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3988080", Offset = "0x3987280", VA = "0x183988080", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class CCIJBIGKACC<TData> : INKGOCPPFEB<DIPHDIKGLJF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly MPNNAOPONNO<TData> NHLLLGLKFNA;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4B57DB0", Offset = "0x4B56FB0", VA = "0x184B57DB0")]
	public CCIJBIGKACC(List<TData> NOIICBHICIJ, bool GKIPGKLCFML, DIPHDIKGLJF<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3A61E80", Offset = "0x3A61080", VA = "0x183A61E80", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class AIABKFHMKDJ<TData> : INKGOCPPFEB<DIPHDIKGLJF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData GBJHIGKOMJM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3A02EA0", Offset = "0x3A020A0", VA = "0x183A02EA0")]
	public AIABKFHMKDJ(TData GBJHIGKOMJM, DIPHDIKGLJF<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3A02D20", Offset = "0x3A01F20", VA = "0x183A02D20", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PHHOJPBEOGN<TData> : INKGOCPPFEB<DIPHDIKGLJF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly MPNNAOPONNO<TData> NHLLLGLKFNA;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x426C410", Offset = "0x426B610", VA = "0x18426C410")]
	public PHHOJPBEOGN(IEnumerable<TData> NOIICBHICIJ, DIPHDIKGLJF<TData> LNCHGILPLKL, bool GKIPGKLCFML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x426C340", Offset = "0x426B540", VA = "0x18426C340", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct MPNNAOPONNO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> AJFGAHBJKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool GKIPGKLCFML;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3FAD120", Offset = "0x3FAC320", VA = "0x183FAD120")]
	public MPNNAOPONNO(IEnumerable<TData> GMDHCLNHMAN, bool ICLNDLCOLFK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface OOOGFJOAMMI
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HCHPNLFKFPJ> CHEEFNHIJMB(IGDKHKIOAGH EDGGLACADME);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class JAACIEAHPHA : MKNKBHNFNBO<OOOGFJOAMMI, HCHPNLFKFPJ>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct AGLAJGEPAJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<HCHPNLFKFPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public JAACIEAHPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<HCHPNLFKFPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6229C30", Offset = "0x6228E30", VA = "0x186229C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6229EB0", Offset = "0x62290B0", VA = "0x186229EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly IGDKHKIOAGH AOCDCHCCFHG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x622AEF0", Offset = "0x622A0F0", VA = "0x18622AEF0")]
	public JAACIEAHPHA(bool GKIPGKLCFML, OOOGFJOAMMI LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x622AE00", Offset = "0x622A000", VA = "0x18622AE00", Slot = "4")]
	[AsyncStateMachine(typeof(AGLAJGEPAJA))]
	public override Task<HCHPNLFKFPJ> CHEEFNHIJMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct IGDKHKIOAGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool JICMENIJKBL;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xCCE730", Offset = "0xCCD930", VA = "0x180CCE730")]
	public IGDKHKIOAGH(bool GKIPGKLCFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct OBKHMNLBLKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool BNJFMGABMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool HEMNNAFBGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool EKCHLHLGOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool GKIPGKLCFML;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4723B40", Offset = "0x4722D40", VA = "0x184723B40")]
	public OBKHMNLBLKP(bool BNJFMGABMJM, bool HEMNNAFBGCL, bool EKCHLHLGOBO, bool GKIPGKLCFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x622B2A0", Offset = "0x622A4A0", VA = "0x18622B2A0")]
	public OBKHMNLBLKP(bool HEMNNAFBGCL, bool GKIPGKLCFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface IJJNNBFJFMK
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HGPFNNDJFEK(OBKHMNLBLKP KLGPJCBPNIM);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KMAEDNMCIFK(OBKHMNLBLKP KLGPJCBPNIM);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class NPNNHKPIHDL : INKGOCPPFEB<IJJNNBFJFMK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly OBKHMNLBLKP KLGPJCBPNIM;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x622B190", Offset = "0x622A390", VA = "0x18622B190")]
	public NPNNHKPIHDL(bool GCDMIBEHAIO, bool HEMNNAFBGCL, bool EKCHLHLGOBO, bool GKIPGKLCFML, IJJNNBFJFMK LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x622B140", Offset = "0x622A340", VA = "0x18622B140", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class EHPHMHODNJC : INKGOCPPFEB<IJJNNBFJFMK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly OBKHMNLBLKP KLGPJCBPNIM;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x622A750", Offset = "0x6229950", VA = "0x18622A750")]
	public EHPHMHODNJC(bool HEMNNAFBGCL, bool GKIPGKLCFML, IJJNNBFJFMK LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x622A700", Offset = "0x6229900", VA = "0x18622A700", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface FOKEAAFGKGP
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHEEFNHIJMB([In] BJMKBADBIEH LCJNKBMAAAN);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class FKGIEDNAFHL : INKGOCPPFEB<FOKEAAFGKGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly BJMKBADBIEH LCJNKBMAAAN;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x622A880", Offset = "0x6229A80", VA = "0x18622A880")]
	public FKGIEDNAFHL(Guid[] FLNHAJGPABO, Vector3[] ECOLHBPHEMC, Quaternion[] JGCILLKAFJO, float[] IENEEAFAKEG, Dictionary<Guid, Vector3> NFKEPDFJKJD, FOKEAAFGKGP LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x622A7D0", Offset = "0x62299D0", VA = "0x18622A7D0", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface POOHIHGACKD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HDNNHINGOCJ([In] ICAEHLHACLJ<TData> CKCNAMCJEMM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AEEICNBMHJO([In] JJNCGCBJGGB AHPPMACOJPC);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AEEICNBMHJO([In] DJOMCBEMOKI AHPPMACOJPC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NNHLIKCGNEP();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MFBDOCEAHKJ<TData> : INKGOCPPFEB<POOHIHGACKD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x34A6D60", Offset = "0x34A5F60", VA = "0x1834A6D60")]
	public MFBDOCEAHKJ(POOHIHGACKD<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3F5AA80", Offset = "0x3F59C80", VA = "0x183F5AA80", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class PMFKHAHPPAF<TData> : INKGOCPPFEB<POOHIHGACKD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly JJNCGCBJGGB FDNAACLOKLG;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x42791D0", Offset = "0x42783D0", VA = "0x1842791D0")]
	public PMFKHAHPPAF(Vector3 NMIJPEGIJEG, bool LDAEMJBNECD, POOHIHGACKD<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3F7CCD0", Offset = "0x3F7BED0", VA = "0x183F7CCD0", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class CMFHBHOOLCD<TData> : INKGOCPPFEB<POOHIHGACKD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly DJOMCBEMOKI FDNAACLOKLG;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4C3B550", Offset = "0x4C3A750", VA = "0x184C3B550")]
	public CMFHBHOOLCD(Guid NJILDJDPPPJ, int HMFNCGHECPG, Vector3 DHMMMGDKPCG, Quaternion HBCECKEGCGH, float LJCANJNBLMD, bool LDAEMJBNECD, POOHIHGACKD<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4C3B4F0", Offset = "0x4C3A6F0", VA = "0x184C3B4F0", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class PBHMGKKCBHO<TData> : INKGOCPPFEB<POOHIHGACKD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly ICAEHLHACLJ<TData> FDNAACLOKLG;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4257CD0", Offset = "0x4256ED0", VA = "0x184257CD0")]
	public PBHMGKKCBHO(TData IOCBLPNBBJM, bool GKIPGKLCFML, POOHIHGACKD<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x389F100", Offset = "0x389E300", VA = "0x18389F100", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct JJNCGCBJGGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Vector3 NMIJPEGIJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool LDAEMJBNECD;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x622B0A0", Offset = "0x622A2A0", VA = "0x18622B0A0")]
	public JJNCGCBJGGB(Vector3 NMIJPEGIJEG, bool LDAEMJBNECD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct DJOMCBEMOKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Guid NJILDJDPPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int HMFNCGHECPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Vector3 DHMMMGDKPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Quaternion HBCECKEGCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly float LJCANJNBLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly bool LDAEMJBNECD;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x622A6C0", Offset = "0x62298C0", VA = "0x18622A6C0")]
	public DJOMCBEMOKI(Guid NJILDJDPPPJ, int HMFNCGHECPG, Vector3 DHMMMGDKPCG, Quaternion HBCECKEGCGH, float LJCANJNBLMD, bool LDAEMJBNECD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct ICAEHLHACLJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData IOCBLPNBBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly bool GKIPGKLCFML;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3A357A0", Offset = "0x3A349A0", VA = "0x183A357A0")]
	public ICAEHLHACLJ(TData IOCBLPNBBJM, bool GKIPGKLCFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface HOAMLKDKJHF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHEEFNHIJMB([In] OFKHPGILEBJ<TData> DMJNIDEBMLM);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CHEEFNHIJMB([In] JBJCLHFHMMH<TData> DMJNIDEBMLM);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface FGKPNFDNHCA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HDNNHINGOCJ([In] MBGKCGGIEDL<TData> KNDMIKDHIOE);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AEEICNBMHJO([In] HAELIBBOIKH AHPPMACOJPC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NNHLIKCGNEP();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class OCELCKAGNFM<TData> : INKGOCPPFEB<HOAMLKDKJHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly OFKHPGILEBJ<TData> DMJNIDEBMLM;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x412F0F0", Offset = "0x412E2F0", VA = "0x18412F0F0")]
	public OCELCKAGNFM(IEnumerable<TData> BFGHGPDGFOP, Vector3 AKPLNKDCNCL, bool GKIPGKLCFML, HOAMLKDKJHF<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x389F100", Offset = "0x389E300", VA = "0x18389F100", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class EPCNDIJNNPL<TData> : INKGOCPPFEB<FGKPNFDNHCA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x34A6D60", Offset = "0x34A5F60", VA = "0x1834A6D60")]
	public EPCNDIJNNPL(FGKPNFDNHCA<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x34A6D10", Offset = "0x34A5F10", VA = "0x1834A6D10", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class JCCOGMKDLGD<TData> : INKGOCPPFEB<FGKPNFDNHCA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MBGKCGGIEDL<TData> DMJNIDEBMLM;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3BFAA90", Offset = "0x3BF9C90", VA = "0x183BFAA90")]
	public JCCOGMKDLGD(IEnumerable<TData> BFGHGPDGFOP, bool GKIPGKLCFML, FGKPNFDNHCA<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x389F100", Offset = "0x389E300", VA = "0x18389F100", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class NPJEPBDAFHC<TData> : INKGOCPPFEB<HOAMLKDKJHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JBJCLHFHMMH<TData> DMJNIDEBMLM;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4084EC0", Offset = "0x40840C0", VA = "0x184084EC0")]
	public NPJEPBDAFHC(IEnumerable<TData> BFGHGPDGFOP, Vector3 JDAFHJCEAOG, OMNOFAPFGBM LDAGLPPHBPI, bool GKIPGKLCFML, HOAMLKDKJHF<TData> LNCHGILPLKL, Space AIICDEJOCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3C795C0", Offset = "0x3C787C0", VA = "0x183C795C0", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class MKPCNEMKPOE<TData> : INKGOCPPFEB<FGKPNFDNHCA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly HAELIBBOIKH DMJNIDEBMLM;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3F7CD30", Offset = "0x3F7BF30", VA = "0x183F7CD30")]
	public MKPCNEMKPOE(Vector3 AKPLNKDCNCL, FGKPNFDNHCA<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3F7CCD0", Offset = "0x3F7BED0", VA = "0x183F7CCD0", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct OFKHPGILEBJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly IEnumerable<TData> BFGHGPDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Vector3 AKPLNKDCNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly bool GKIPGKLCFML;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4180D00", Offset = "0x417FF00", VA = "0x184180D00")]
	public OFKHPGILEBJ(IEnumerable<TData> BFGHGPDGFOP, Vector3 AKPLNKDCNCL, bool GKIPGKLCFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct MBGKCGGIEDL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> BFGHGPDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool GKIPGKLCFML;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3F47A30", Offset = "0x3F46C30", VA = "0x183F47A30")]
	public MBGKCGGIEDL(IEnumerable<TData> BFGHGPDGFOP, bool GKIPGKLCFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct JBJCLHFHMMH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly IEnumerable<TData> BFGHGPDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 JDAFHJCEAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly OMNOFAPFGBM LDAGLPPHBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool GKIPGKLCFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Space AIICDEJOCID;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA6F0", Offset = "0x3BF98F0", VA = "0x183BFA6F0")]
	public JBJCLHFHMMH(IEnumerable<TData> BFGHGPDGFOP, Vector3 JDAFHJCEAOG, OMNOFAPFGBM LDAGLPPHBPI, bool GKIPGKLCFML, Space AIICDEJOCID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct HAELIBBOIKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Vector3 AKPLNKDCNCL;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2ED0", Offset = "0x1FE20D0", VA = "0x181FE2ED0")]
	public HAELIBBOIKH(Vector3 AKPLNKDCNCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum OMNOFAPFGBM
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
public interface EGFEFBICBGD
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHEEFNHIJMB([In] JPEGEFOAAIC CJCILBELPAA);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class BCMDPOCGHEN : INKGOCPPFEB<EGFEFBICBGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly JPEGEFOAAIC CJCILBELPAA;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6229FD0", Offset = "0x62291D0", VA = "0x186229FD0")]
	public BCMDPOCGHEN(bool GKIPGKLCFML, EGFEFBICBGD LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6229F20", Offset = "0x6229120", VA = "0x186229F20", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct JPEGEFOAAIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool GKIPGKLCFML;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xCCE730", Offset = "0xCCD930", VA = "0x180CCE730")]
	public JPEGEFOAAIC(bool GKIPGKLCFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface HCPNKCANAFA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHEEFNHIJMB([In] ELFKDGEBONO<TData> OGEEDABOJMK);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CHEEFNHIJMB([In] PBAKPDEAPFP<TData> OGEEDABOJMK);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface PGBIBEBPFII<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HDNNHINGOCJ([In] GFCIEKICLBH<TData> CKCNAMCJEMM);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AEEICNBMHJO([In] KAACBOBGNHL AHPPMACOJPC);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NNHLIKCGNEP();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class PGLCDAHAELK<TData> : INKGOCPPFEB<HCPNKCANAFA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly ELFKDGEBONO<TData> OGEEDABOJMK;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x426C240", Offset = "0x426B440", VA = "0x18426C240")]
	public PGLCDAHAELK(IEnumerable<TData> BFGHGPDGFOP, Quaternion AKPLNKDCNCL, Vector3? POBDAEMMDGD, bool JKCFOFOGNDE, bool GKIPGKLCFML, HCPNKCANAFA<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x389F100", Offset = "0x389E300", VA = "0x18389F100", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class MNOHNNFINNG<TData> : INKGOCPPFEB<PGBIBEBPFII<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x34A6D60", Offset = "0x34A5F60", VA = "0x1834A6D60")]
	public MNOHNNFINNG(PGBIBEBPFII<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x34A6D10", Offset = "0x34A5F10", VA = "0x1834A6D10", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class CHJEADFMFKO<TData> : INKGOCPPFEB<PGBIBEBPFII<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly GFCIEKICLBH<TData> OGEEDABOJMK;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4C30F70", Offset = "0x4C30170", VA = "0x184C30F70")]
	public CHJEADFMFKO(IEnumerable<TData> BFGHGPDGFOP, bool GKIPGKLCFML, PGBIBEBPFII<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x389F100", Offset = "0x389E300", VA = "0x18389F100", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class DJLEHGAIOBN<TData> : INKGOCPPFEB<HCPNKCANAFA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly PBAKPDEAPFP<TData> OGEEDABOJMK;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x511B4D0", Offset = "0x511A6D0", VA = "0x18511B4D0")]
	public DJLEHGAIOBN(IEnumerable<TData> BFGHGPDGFOP, Quaternion DLLLFKCMGGA, OMNOFAPFGBM HFAGGIIIBJJ, Vector3? POBDAEMMDGD, bool JKCFOFOGNDE, bool GKIPGKLCFML, Space AIICDEJOCID, HCPNKCANAFA<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3C795C0", Offset = "0x3C787C0", VA = "0x183C795C0", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class CLOLFEMEJDE<TData> : INKGOCPPFEB<PGBIBEBPFII<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly KAACBOBGNHL OGEEDABOJMK;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4C3AC50", Offset = "0x4C39E50", VA = "0x184C3AC50")]
	public CLOLFEMEJDE(Quaternion AKPLNKDCNCL, Vector3? POBDAEMMDGD, bool JKCFOFOGNDE, PGBIBEBPFII<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3F7CCD0", Offset = "0x3F7BED0", VA = "0x183F7CCD0", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct ELFKDGEBONO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly IEnumerable<TData> BFGHGPDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Quaternion AKPLNKDCNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3? POBDAEMMDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool JKCFOFOGNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool GKIPGKLCFML;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x348BEE0", Offset = "0x348B0E0", VA = "0x18348BEE0")]
	public ELFKDGEBONO(IEnumerable<TData> BFGHGPDGFOP, Quaternion AKPLNKDCNCL, Vector3? POBDAEMMDGD, bool JKCFOFOGNDE, bool GKIPGKLCFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct GFCIEKICLBH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> BFGHGPDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool GKIPGKLCFML;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x38AEA80", Offset = "0x38ADC80", VA = "0x1838AEA80")]
	public GFCIEKICLBH(IEnumerable<TData> BFGHGPDGFOP, bool GKIPGKLCFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct PBAKPDEAPFP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly IEnumerable<TData> BFGHGPDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Quaternion DLLLFKCMGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly OMNOFAPFGBM HFAGGIIIBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3? POBDAEMMDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool JKCFOFOGNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool GKIPGKLCFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Space AIICDEJOCID;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x42579A0", Offset = "0x4256BA0", VA = "0x1842579A0")]
	public PBAKPDEAPFP(IEnumerable<TData> BFGHGPDGFOP, Quaternion DLLLFKCMGGA, OMNOFAPFGBM HFAGGIIIBJJ, Vector3? POBDAEMMDGD, bool JKCFOFOGNDE, bool GKIPGKLCFML, Space AIICDEJOCID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct KAACBOBGNHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Quaternion AKPLNKDCNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3? POBDAEMMDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool JKCFOFOGNDE;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x46E9CD0", Offset = "0x46E8ED0", VA = "0x1846E9CD0")]
	public KAACBOBGNHL(Quaternion AKPLNKDCNCL, Vector3? POBDAEMMDGD, bool JKCFOFOGNDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface GPPMBEFNEKK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HDNNHINGOCJ([In] CENNAPHFDJJ<TData> CKCNAMCJEMM);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AEEICNBMHJO([In] NNEEIJIGDCD AHPPMACOJPC);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AEEICNBMHJO([In] MKPAANGCNAF AHPPMACOJPC);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AEEICNBMHJO([In] MFABMPPHBKM AHPPMACOJPC);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NNHLIKCGNEP();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class KCMJMHAAPHF<TData> : INKGOCPPFEB<GPPMBEFNEKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MFABMPPHBKM HHBLEAPLFIF;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3C69A90", Offset = "0x3C68C90", VA = "0x183C69A90")]
	public KCMJMHAAPHF(Vector3 IKIKGHNAEOJ, float FHNIBDNNPGA, Vector3 POBDAEMMDGD, bool IJKHGADPPOG, bool FOMNILCFLGK, GPPMBEFNEKK<TData> LNCHGILPLKL, Space AIICDEJOCID = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3C69A30", Offset = "0x3C68C30", VA = "0x183C69A30", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class BJJNMKPICHF<TData> : INKGOCPPFEB<GPPMBEFNEKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x34A6D60", Offset = "0x34A5F60", VA = "0x1834A6D60")]
	public BJJNMKPICHF(GPPMBEFNEKK<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x48A6A80", Offset = "0x48A5C80", VA = "0x1848A6A80", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class JPIEMJJEBHF<TData> : INKGOCPPFEB<GPPMBEFNEKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CENNAPHFDJJ<TData> HHBLEAPLFIF;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3C348B0", Offset = "0x3C33AB0", VA = "0x183C348B0")]
	public JPIEMJJEBHF(IEnumerable<TData> BFGHGPDGFOP, bool GKIPGKLCFML, GPPMBEFNEKK<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x389F100", Offset = "0x389E300", VA = "0x18389F100", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class LCAHEGLPMHB<TData> : INKGOCPPFEB<GPPMBEFNEKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly MKPAANGCNAF HHBLEAPLFIF;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3D1F460", Offset = "0x3D1E660", VA = "0x183D1F460")]
	public LCAHEGLPMHB(float EIENBGGCEAJ, bool OKGKPCNDPHO, Vector3 POBDAEMMDGD, GPPMBEFNEKK<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3D1F390", Offset = "0x3D1E590", VA = "0x183D1F390", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class ONBKANBLHKB<TData> : INKGOCPPFEB<GPPMBEFNEKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly NNEEIJIGDCD HHBLEAPLFIF;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x41C9FE0", Offset = "0x41C91E0", VA = "0x1841C9FE0")]
	public ONBKANBLHKB(float FHNIBDNNPGA, Vector3 POBDAEMMDGD, GPPMBEFNEKK<TData> LNCHGILPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3F7CCD0", Offset = "0x3F7BED0", VA = "0x183F7CCD0", Slot = "4")]
	public override bool CHEEFNHIJMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct MFABMPPHBKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 IKIKGHNAEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly float FHNIBDNNPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 POBDAEMMDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool LDAEMJBNECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space AIICDEJOCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly bool FOMNILCFLGK;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x622B0E0", Offset = "0x622A2E0", VA = "0x18622B0E0")]
	public MFABMPPHBKM(Vector3 IKIKGHNAEOJ, float FHNIBDNNPGA, Vector3 POBDAEMMDGD, bool LDAEMJBNECD, bool FDDOPFLALNE, Space AIICDEJOCID = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct CENNAPHFDJJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> BFGHGPDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool GKIPGKLCFML;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4B60D60", Offset = "0x4B5FF60", VA = "0x184B60D60")]
	public CENNAPHFDJJ(IEnumerable<TData> BFGHGPDGFOP, bool GKIPGKLCFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct MKPAANGCNAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly float EIENBGGCEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool OKGKPCNDPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly Vector3 POBDAEMMDGD;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x622B120", Offset = "0x622A320", VA = "0x18622B120")]
	public MKPAANGCNAF(float EIENBGGCEAJ, bool OKGKPCNDPHO, Vector3 POBDAEMMDGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct NNEEIJIGDCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly float FHNIBDNNPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 POBDAEMMDGD;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x46BF2B0", Offset = "0x46BE4B0", VA = "0x1846BF2B0")]
	public NNEEIJIGDCD(float FHNIBDNNPGA, Vector3 POBDAEMMDGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct BJMKBADBIEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Guid[] BFGHGPDGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly bool MDJPFADBFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool GBEJLCDAPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool DGIICIPAFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Vector3[] ECOLHBPHEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion[] JGCILLKAFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly float[] IENEEAFAKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Dictionary<Guid, Vector3> NFKEPDFJKJD;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x622A200", Offset = "0x6229400", VA = "0x18622A200")]
	public BJMKBADBIEH(Guid[] FLNHAJGPABO, Vector3[] ECOLHBPHEMC, Quaternion[] JGCILLKAFJO, float[] IENEEAFAKEG, Dictionary<Guid, Vector3> NFKEPDFJKJD, bool MDJPFADBFKM = true, bool GBEJLCDAPGC = true, bool DGIICIPAFIL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x622A030", Offset = "0x6229230", VA = "0x18622A030")]
	private static void PEEIMDFPIOG(Dictionary<Guid, Vector3> NFKEPDFJKJD, int IFNKNPEONNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class HCPLBGPJNKH
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct OJPLHGKPJGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool OCNNEGBDAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public LEHDPNIFNIH DHEGKKCFEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LEHDPNIFNIH PNMMBLHFFCB;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static OJPLHGKPJGC CKGFAHBEEKH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken MHFGINAPALI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x622AC50", Offset = "0x6229E50", VA = "0x18622AC50")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static LEHDPNIFNIH DHEGKKCFEAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x622AAC0", Offset = "0x6229CC0", VA = "0x18622AAC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x622AA60", Offset = "0x6229C60", VA = "0x18622AA60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x622AB60", Offset = "0x6229D60", VA = "0x18622AB60")]
	[KEFCCLBEAOJ(BDECECCJEGA.Room, CMEECPGEPNF.None)]
	private static void HOAPDFIGOHL(LEHDPNIFNIH BFJMAEEHJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x622ACC0", Offset = "0x6229EC0", VA = "0x18622ACC0")]
	public static void MNHGCJGIAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x622AC70", Offset = "0x6229E70", VA = "0x18622AC70")]
	private static LEHDPNIFNIH MCCDHACJEPI(LEHDPNIFNIH MPDCPFFFOEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class NPNGHCIFMKJ
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum EPCOJNDLANB
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2A18690", Offset = "0x2A17890", VA = "0x182A18690")]
	public static void GHDKKIIAIHP<T>(T JHPIMPOFIFB, EPCOJNDLANB FLPJMDMACMC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2A18630", Offset = "0x2A17830", VA = "0x182A18630")]
	public static void GHDKKIIAIHP<T>(T JHPIMPOFIFB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2A185C0", Offset = "0x2A177C0", VA = "0x182A185C0")]
	public static void FMLPPCLDPHG<T>(T JHPIMPOFIFB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2A187D0", Offset = "0x2A179D0", VA = "0x182A187D0")]
	public static T OLBNKGLEPPK<T>(EPCOJNDLANB FLPJMDMACMC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2A18490", Offset = "0x2A17690", VA = "0x182A18490")]
	public static bool FBKMABELHLO<T>(EPCOJNDLANB FLPJMDMACMC, T MIBJFPPDGOP, [Out] T GKIJDBHMMPO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2A18310", Offset = "0x2A17510", VA = "0x182A18310")]
	public static bool ALOLCKJBOOC<T>(EPCOJNDLANB FLPJMDMACMC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2A183B0", Offset = "0x2A175B0", VA = "0x182A183B0")]
	public static T OLBNKGLEPPK<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2A183F0", Offset = "0x2A175F0", VA = "0x182A183F0")]
	public static bool FBKMABELHLO<T>(T MIBJFPPDGOP, [Out] T GKIJDBHMMPO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2A183B0", Offset = "0x2A175B0", VA = "0x182A183B0")]
	public static bool ALOLCKJBOOC<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class CCNEPMMNLCG
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x622A490", Offset = "0x6229690", VA = "0x18622A490")]
	public static void FOEJHGCMEGK(IEnumerable HLFBNFGGACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2717020", Offset = "0x2716220", VA = "0x182717020")]
	public static void FOEJHGCMEGK<T>(T[] GEHAOEPMDJB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2717200", Offset = "0x2716400", VA = "0x182717200")]
	public static void FOEJHGCMEGK<T>(T LILHNKAIGNI) where T : notnull, Enum
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
