using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7044610", Offset = "0x7043A10", VA = "0x187044610")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Maker_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7044800", Offset = "0x7043C00", VA = "0x187044800", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LIKBKOMEHGC<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn LECKCGMNEFA(TData NCHBKHMIMGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HNIOIHENGLG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(CBCMFFMJHEB IDFIIOCAHLL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData MGPMAFDHMLC, Collider FPBGIJBEDHO, CBCMFFMJHEB IDFIIOCAHLL, [Optional] BLEKIMGBKEH? BMNONKFHLJO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData MGPMAFDHMLC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider FPBGIJBEDHO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IIKOAJDNHED<TData> : GFDFNBDFABA, JIAMAOLHEOE<TData>, DDACCAIHBOO<TData>, DIMLOINJHMI<TData>, LOKHKCMNEDM, NPDDLJCPBKA<TData>, HBJPIEBCDLG, FHDHJJDKOJD
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NPDDLJCPBKA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 KJLHJAKALDP, Vector3 LIDLBHGKPBN, float KIECEDCFNCJ, [Out] T CGEFDDFLJFK, [Out] Vector3 LOHDOHKBFKB, [Out] Collider FPBGIJBEDHO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 KJLHJAKALDP, Vector3 LIDLBHGKPBN, float GAFGKGNDEOF, float KIECEDCFNCJ, T[] KNJCMJOPGPL, [Out] Vector3 KNFOEEPEJFK, [Out] Collider BNKAKKHBHNK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 KJLHJAKALDP, float GAFGKGNDEOF, Vector3 BCKAJBIHFIL, T[] KNJCMJOPGPL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider DALFGDJANJG, [Out] T IAHDCEPFLPM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GFDFNBDFABA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds CIJBECBAGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform AAHPAPMEIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds APOHJNJMLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform DJBCOBLHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 NKBOIBFEJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NNHGLCIFJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void UpdateLocalSelectionBounds();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetSelectionBoundsDirty(bool NEHAJHCAHPD = true, int LAAKDBENAKE = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool HPKOFPMOIEI, object CMNJCPJBHGE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FHDHJJDKOJD
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MIPKPFFHABJ OOFCPCAKFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HBIHOOMCAFN
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DFIIEDHHHKD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool DNIFDNOMFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool FEPNINBANKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> HHAKIPGOFDI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DIMLOINJHMI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool ODJJGEGFBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int LDBCKMFJCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> IKBGLFGMONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData FKIFNEPLBJJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData FKIFNEPLBJJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JIAMAOLHEOE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T NCHBKHMIMGJ, [Optional] BLEKIMGBKEH? OLOMMHLDCCH, bool DLNDFHJJAID = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int ABPDJOGPHFP, IEnumerable<T> LCKABDAHLKO, bool DLNDFHJJAID = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int ABPDJOGPHFP, IEnumerable<T> LCKABDAHLKO, BLEKIMGBKEH OLOMMHLDCCH, bool DLNDFHJJAID = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HBJPIEBCDLG
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LOKHKCMNEDM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool NGPBKGENNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool BADLEOOIEHK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool IIOBEPIMBMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool KIDNPKCCGDD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class OOADPMCLKNP<TReceiver> : LGGDJGOLLAI<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x40476D0", Offset = "0x4046AD0", VA = "0x1840476D0")]
	public OOADPMCLKNP(TReceiver NCFNENNCOJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class GAPDDFBENFM<TReceiver, TFromTask> : LGGDJGOLLAI<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x40476D0", Offset = "0x4046AD0", VA = "0x1840476D0")]
	public GAPDDFBENFM(TReceiver NCFNENNCOJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class LGGDJGOLLAI<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver NCFNENNCOJO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x47C8C00", Offset = "0x47C8000", VA = "0x1847C8C00")]
	public LGGDJGOLLAI(TReceiver NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute POOMJEGGIFP();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class KDHOJAFHJMC<TReceiver, TResult> : LGGDJGOLLAI<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x40476D0", Offset = "0x4046AD0", VA = "0x1840476D0")]
	public KDHOJAFHJMC(TReceiver NCFNENNCOJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DLMEAJGJCCE<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup NNLNNHKFDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData DMBAHKHAEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> IHELNDFIDMD;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x22114B0", Offset = "0x22108B0", VA = "0x1822114B0")]
	public DLMEAJGJCCE(TGroup JJLHDLDOKIJ, TData JKMJBCGKCDJ, IEnumerable<TData> LADGDNIBDEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FJEBODGFCEF<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup NNLNNHKFDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> IHELNDFIDMD;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xE8EEE0", Offset = "0xE8E2E0", VA = "0x180E8EEE0")]
	public FJEBODGFCEF(TGroup JJLHDLDOKIJ, IEnumerable<TData> LADGDNIBDEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EGBJOAPKKNI<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup NNLNNHKFDID;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
	public EGBJOAPKKNI(TGroup JJLHDLDOKIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct MCAICKEGBEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<Guid> IHELNDFIDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Guid NCDHIAOMFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool JGIAPGFMEPD;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x70445D0", Offset = "0x70439D0", VA = "0x1870445D0")]
	public MCAICKEGBEB(IEnumerable<Guid> LADGDNIBDEA, Guid NFAELOKOANI, bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CDJBIOAJKNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public Guid NCDHIAOMFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool JGIAPGFMEPD;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1EC12C0", Offset = "0x1EC06C0", VA = "0x181EC12C0")]
	public CDJBIOAJKNF(Guid NFAELOKOANI, bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface COLFHFNFFPB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GKHCGAIKHFH DLCKPDLEOJN(DLMEAJGJCCE<TGroup, TData> FOKFAIEKLFM);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GKHCGAIKHFH DKGDJJGHHJM(DLMEAJGJCCE<TGroup, TData> FOKFAIEKLFM);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GKHCGAIKHFH OECDGBHNBJG(FJEBODGFCEF<TGroup, TData> FOKFAIEKLFM);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GKHCGAIKHFH FAGEDOIJKPH(EGBJOAPKKNI<TGroup> FOKFAIEKLFM);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface AELBHDHPKPN
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GKHCGAIKHFH> DLCKPDLEOJN(MCAICKEGBEB FOKFAIEKLFM);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GKHCGAIKHFH> DKGDJJGHHJM(CDJBIOAJKNF FOKFAIEKLFM);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KCFPIMDPKPP<TGroup, TData> : KDHOJAFHJMC<COLFHFNFFPB<TGroup, TData>, GKHCGAIKHFH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FJEBODGFCEF<TGroup, TData> FOKFAIEKLFM;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x465DA70", Offset = "0x465CE70", VA = "0x18465DA70")]
	public KCFPIMDPKPP(TGroup JJLHDLDOKIJ, IEnumerable<TData> LADGDNIBDEA, COLFHFNFFPB<TGroup, TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x465D9A0", Offset = "0x465CDA0", VA = "0x18465D9A0", Slot = "4")]
	public override GKHCGAIKHFH POOMJEGGIFP()
	{
		return default(GKHCGAIKHFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FKILDOLKJKF<TGroup, TData> : KDHOJAFHJMC<COLFHFNFFPB<TGroup, TData>, GKHCGAIKHFH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DLMEAJGJCCE<TGroup, TData> FOKFAIEKLFM;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x40A4E30", Offset = "0x40A4230", VA = "0x1840A4E30")]
	public FKILDOLKJKF(TGroup JJLHDLDOKIJ, TData JIFMMJDMGAB, IEnumerable<TData> LADGDNIBDEA, COLFHFNFFPB<TGroup, TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x40A4D60", Offset = "0x40A4160", VA = "0x1840A4D60", Slot = "4")]
	public override GKHCGAIKHFH POOMJEGGIFP()
	{
		return default(GKHCGAIKHFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AACCFJBKMMM<TGroup, TData> : KDHOJAFHJMC<COLFHFNFFPB<TGroup, TData>, GKHCGAIKHFH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly EGBJOAPKKNI<TGroup> FOKFAIEKLFM;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x412BA40", Offset = "0x412AE40", VA = "0x18412BA40")]
	public AACCFJBKMMM(TGroup JJLHDLDOKIJ, COLFHFNFFPB<TGroup, TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x412B980", Offset = "0x412AD80", VA = "0x18412B980", Slot = "4")]
	public override GKHCGAIKHFH POOMJEGGIFP()
	{
		return default(GKHCGAIKHFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CIIPNDJADAB<TGroup, TData> : KDHOJAFHJMC<COLFHFNFFPB<TGroup, TData>, GKHCGAIKHFH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly DLMEAJGJCCE<TGroup, TData> FOKFAIEKLFM;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x40A4E30", Offset = "0x40A4230", VA = "0x1840A4E30")]
	public CIIPNDJADAB(TGroup JJLHDLDOKIJ, TData JKMJBCGKCDJ, IEnumerable<TData> LADGDNIBDEA, COLFHFNFFPB<TGroup, TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x58FDA40", Offset = "0x58FCE40", VA = "0x1858FDA40", Slot = "4")]
	public override GKHCGAIKHFH POOMJEGGIFP()
	{
		return default(GKHCGAIKHFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LFLCPOOBEIN : GAPDDFBENFM<AELBHDHPKPN, GKHCGAIKHFH>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct LIDMIMAECHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<GKHCGAIKHFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LFLCPOOBEIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<GKHCGAIKHFH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7044010", Offset = "0x7043410", VA = "0x187044010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x70442A0", Offset = "0x70436A0", VA = "0x1870442A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MCAICKEGBEB FOKFAIEKLFM;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7043E00", Offset = "0x7043200", VA = "0x187043E00")]
	public LFLCPOOBEIN(IEnumerable<Guid> GLLCJHDGJPB, Guid NFAELOKOANI, bool AAABJBFJLLC, AELBHDHPKPN NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7043D10", Offset = "0x7043110", VA = "0x187043D10", Slot = "4")]
	[AsyncStateMachine(typeof(LIDMIMAECHG))]
	public override Task<GKHCGAIKHFH> POOMJEGGIFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MAJKOBEMIKG : GAPDDFBENFM<AELBHDHPKPN, GKHCGAIKHFH>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct CMAEBDJLLMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<GKHCGAIKHFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public MAJKOBEMIKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<GKHCGAIKHFH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7042E30", Offset = "0x7042230", VA = "0x187042E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x70430D0", Offset = "0x70424D0", VA = "0x1870430D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly CDJBIOAJKNF FOKFAIEKLFM;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7044400", Offset = "0x7043800", VA = "0x187044400")]
	public MAJKOBEMIKG(Guid NFAELOKOANI, bool AAABJBFJLLC, AELBHDHPKPN NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7044310", Offset = "0x7043710", VA = "0x187044310", Slot = "4")]
	[AsyncStateMachine(typeof(CMAEBDJLLMB))]
	public override Task<GKHCGAIKHFH> POOMJEGGIFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct LCNJGDPKCLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly LHDJLHPNBEH OKDNLJEIBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool JGIAPGFMEPD;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7043CF0", Offset = "0x70430F0", VA = "0x187043CF0")]
	public LCNJGDPKCLK(LHDJLHPNBEH LJLFHICDEOM, bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GJJLICPGOBI<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> POOMJEGGIFP(LCNJGDPKCLK HOKPILGHOIL);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KGHFECLNCBJ<TSpawnType> : GAPDDFBENFM<GJJLICPGOBI<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct KEIJEMPEHLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public KGHFECLNCBJ<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4662C80", Offset = "0x4662080", VA = "0x184662C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4080810", Offset = "0x407FC10", VA = "0x184080810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly LCNJGDPKCLK HOKPILGHOIL;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4666A20", Offset = "0x4665E20", VA = "0x184666A20")]
	public KGHFECLNCBJ(LHDJLHPNBEH LJLFHICDEOM, bool AAABJBFJLLC, GJJLICPGOBI<TSpawnType> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4666800", Offset = "0x4665C00", VA = "0x184666800", Slot = "4")]
	[AsyncStateMachine(typeof(KGHFECLNCBJ<>.KEIJEMPEHLA))]
	public override Task<TSpawnType> POOMJEGGIFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct LHDJLHPNBEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly bool OKINMPCGKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Vector3 HKJHMINMEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 FGALHLKMLDD;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7043EF0", Offset = "0x70432F0", VA = "0x187043EF0")]
	public LHDJLHPNBEH(Transform PAIHEAHJIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7043FE0", Offset = "0x70433E0", VA = "0x187043FE0")]
	public LHDJLHPNBEH(Vector3 ADDIIGBEIBA, Vector3 CPGMOBFHDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7043EC0", Offset = "0x70432C0", VA = "0x187043EC0")]
	public static LHDJLHPNBEH EIBGMEMLIIJ()
	{
		return default(LHDJLHPNBEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7043F60", Offset = "0x7043360", VA = "0x187043F60")]
	private LHDJLHPNBEH(bool CGOGPMOHALA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct EFIILJGDKOD<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TNode MECFOIPLANA;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3CC1330", Offset = "0x3CC0730", VA = "0x183CC1330")]
	public EFIILJGDKOD(TNode MECFOIPLANA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct KNODMIDLBMB<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public TNode GMBFAGBJMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public TReparentOperations ENHCBFGCCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public EMBKKFIEOMM NCPLPLGBLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool JGIAPGFMEPD;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x472B790", Offset = "0x472AB90", VA = "0x18472B790")]
	public KNODMIDLBMB(TNode GMBFAGBJMIG, TReparentOperations ENHCBFGCCJH, EMBKKFIEOMM NCPLPLGBLIN, bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface IDCMEGLHIPM<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELFBOLHDMBI([In] EFIILJGDKOD<TNode> NKGGCNDGILO);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BELBHECIPIL([In] KNODMIDLBMB<TNode, TReparentOperations> FCDAKBAHFCL);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CFNKNGPEKAE();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HLNKOFMNPKO<TNode, TReparentOperations> : OOADPMCLKNP<IDCMEGLHIPM<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x40476D0", Offset = "0x4046AD0", VA = "0x1840476D0")]
	public HLNKOFMNPKO(IDCMEGLHIPM<TNode, TReparentOperations> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x407E3D0", Offset = "0x407D7D0", VA = "0x18407E3D0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class AOBODPACNCL<TNode, TReparentOperations> : OOADPMCLKNP<IDCMEGLHIPM<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly KNODMIDLBMB<TNode, TReparentOperations> FCDAKBAHFCL;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x42F9040", Offset = "0x42F8440", VA = "0x1842F9040")]
	public AOBODPACNCL(TNode GMBFAGBJMIG, TReparentOperations ENHCBFGCCJH, EMBKKFIEOMM NCPLPLGBLIN, IDCMEGLHIPM<TNode, TReparentOperations> NCFNENNCOJO, bool AAABJBFJLLC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB340", Offset = "0x3CBA740", VA = "0x183CBB340", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IOAGOHPNIOG<TNode, TReparentOperations> : OOADPMCLKNP<IDCMEGLHIPM<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly EFIILJGDKOD<TNode> NKGGCNDGILO;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x435DF80", Offset = "0x435D380", VA = "0x18435DF80")]
	public IOAGOHPNIOG(TNode GPOOMGEDEKG, IDCMEGLHIPM<TNode, TReparentOperations> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3C20", Offset = "0x3CE3020", VA = "0x183CE3C20", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct HBGADJDDDNM<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TSpawnInfo NHIMJJHOPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector3 CPGMOBFHDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Quaternion CBCAIPELAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float BMGLFPFGJFF;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x420B310", Offset = "0x420A710", VA = "0x18420B310")]
	public HBGADJDDDNM(TSpawnInfo NHIMJJHOPLM, Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, float BMGLFPFGJFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface OMBFCFJIAHP<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> PEPOGGIACMJ([In] HBGADJDDDNM<TSpawnInfo> CPPBEIFJPHH, CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class PMFAPMFKFMM<TSpawnType, TSpawnInfo> : GAPDDFBENFM<OMBFCFJIAHP<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly HBGADJDDDNM<TSpawnInfo> DCNLGGHAIIP;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4CA8E20", Offset = "0x4CA8220", VA = "0x184CA8E20")]
	public PMFAPMFKFMM(TSpawnInfo IAPIECMHEGK, Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, float BMGLFPFGJFF, OMBFCFJIAHP<TSpawnType, TSpawnInfo> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4CA8D40", Offset = "0x4CA8140", VA = "0x184CA8D40", Slot = "4")]
	public override Task<TSpawnType> POOMJEGGIFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct CDPEJJMILEL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IEnumerable<TData> IHELNDFIDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool JGIAPGFMEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool DIBOIOIOOBI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x56FAC00", Offset = "0x56FA000", VA = "0x1856FAC00")]
	public CDPEJJMILEL(IEnumerable<TData> LADGDNIBDEA, bool AAABJBFJLLC = false, bool PJOIDCHNFAF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface BJCCLKEDEPF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GKHCGAIKHFH> BJAFAOHEGIG([In] CDPEJJMILEL<TData> LDMIBNHBCBE, CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class DEEOHBFGENN<TData> : GAPDDFBENFM<BJCCLKEDEPF<TData>, GKHCGAIKHFH> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CDPEJJMILEL<TData> NFGNMJHNCIN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B170", Offset = "0x5E5A570", VA = "0x185E5B170")]
	public DEEOHBFGENN(IEnumerable<TData> LADGDNIBDEA, bool AAABJBFJLLC, BJCCLKEDEPF<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4CA8D40", Offset = "0x4CA8140", VA = "0x184CA8D40", Slot = "4")]
	public override Task<GKHCGAIKHFH> POOMJEGGIFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct OIGJEHAGAFE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T MGPMAFDHMLC;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB1A0", Offset = "0x3CBA5A0", VA = "0x183CBB1A0")]
	public OIGJEHAGAFE(T HCNBGBNLJBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface AGFHDFOOHCF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELFBOLHDMBI([In] OIGJEHAGAFE<T> LIEBOJIOECA);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BELBHECIPIL();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface NEOILPCPFEC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POOMJEGGIFP([In] APOKLJIHAFP<T> HOFOGKEIALN);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct APOKLJIHAFP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T MGPMAFDHMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool JLKHDPLAABO;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4300A50", Offset = "0x42FFE50", VA = "0x184300A50")]
	public APOKLJIHAFP(T HCNBGBNLJBD, bool BBPNLPCGJAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class GBOBJLMEPLP<T> : OOADPMCLKNP<AGFHDFOOHCF<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x40476D0", Offset = "0x4046AD0", VA = "0x1840476D0")]
	public GBOBJLMEPLP(AGFHDFOOHCF<T> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4186120", Offset = "0x4185520", VA = "0x184186120", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class KIONOJPDHGJ<T> : OOADPMCLKNP<AGFHDFOOHCF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly OIGJEHAGAFE<T> LIEBOJIOECA;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4691500", Offset = "0x4690900", VA = "0x184691500")]
	public KIONOJPDHGJ(T MGPMAFDHMLC, AGFHDFOOHCF<T> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3C20", Offset = "0x3CE3020", VA = "0x183CE3C20", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PBFCHCOEMNI<T> : OOADPMCLKNP<NEOILPCPFEC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly APOKLJIHAFP<T> HOFOGKEIALN;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4C45F80", Offset = "0x4C45380", VA = "0x184C45F80")]
	public PBFCHCOEMNI(T MGPMAFDHMLC, bool BBPNLPCGJAK, NEOILPCPFEC<T> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3C20", Offset = "0x3CE3020", VA = "0x183CE3C20", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct FOENOODGNNO<TData> where TData : notnull, KPEMMOPMAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IEnumerable<TData> IHELNDFIDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool BKILBJJIMKD;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x40B0E00", Offset = "0x40B0200", VA = "0x1840B0E00")]
	public FOENOODGNNO(IEnumerable<TData> GAOPNEOAHME, bool NJAMFAPCCBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct BOOHMFIFCGI<TData> where TData : notnull, KPEMMOPMAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public List<TData> IHELNDFIDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public List<bool> CNLANJHDKDE;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5428A40", Offset = "0x5427E40", VA = "0x185428A40")]
	public BOOHMFIFCGI(List<TData> GAOPNEOAHME, List<bool> BHNONHECOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface KPEMMOPMAEL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool GLIDELAJCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PFEIFEDLLEP<TData> where TData : KPEMMOPMAEL
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POOMJEGGIFP([In] FOENOODGNNO<TData> PILPKDMDPEB);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POOMJEGGIFP([In] BOOHMFIFCGI<TData> PILPKDMDPEB);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface OCMLHJDOPFA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMHGPIKALLH(T MGPMAFDHMLC);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PBCBAKHGCCF<TData> : OOADPMCLKNP<PFEIFEDLLEP<TData>> where TData : notnull, KPEMMOPMAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly FOENOODGNNO<TData> PILPKDMDPEB;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4C455A0", Offset = "0x4C449A0", VA = "0x184C455A0")]
	public PBCBAKHGCCF(List<TData> LADGDNIBDEA, bool BKILBJJIMKD, PFEIFEDLLEP<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3C20", Offset = "0x3CE3020", VA = "0x183CE3C20", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class KMAEJLBOIDL<TData> : OOADPMCLKNP<PFEIFEDLLEP<TData>> where TData : notnull, KPEMMOPMAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly BOOHMFIFCGI<TData> PILPKDMDPEB;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x46A1620", Offset = "0x46A0A20", VA = "0x1846A1620")]
	public KMAEJLBOIDL(List<TData> LADGDNIBDEA, List<bool> CNLANJHDKDE, PFEIFEDLLEP<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x45968D0", Offset = "0x4595CD0", VA = "0x1845968D0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface EAPLMEHAHBH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GKHCGAIKHFH> POOMJEGGIFP(DABLPBNNHEE<TData> LBOJFJCBOFP);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class MNEAIDAAIIE<TData> : GAPDDFBENFM<EAPLMEHAHBH<TData>, GKHCGAIKHFH> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct JKDAOAPLONN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<GKHCGAIKHFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public MNEAIDAAIIE<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<GKHCGAIKHFH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x458A690", Offset = "0x4589A90", VA = "0x18458A690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x458A970", Offset = "0x4589D70", VA = "0x18458A970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly DABLPBNNHEE<TData> OIBLINPLDHH;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4A15A60", Offset = "0x4A14E60", VA = "0x184A15A60")]
	public MNEAIDAAIIE(TData BKIEJBNOGPB, IReadOnlyList<TData> NFHEHAKCLAJ, bool AAABJBFJLLC, EAPLMEHAHBH<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4A15960", Offset = "0x4A14D60", VA = "0x184A15960", Slot = "4")]
	[AsyncStateMachine(typeof(MNEAIDAAIIE<>.JKDAOAPLONN))]
	public override Task<GKHCGAIKHFH> POOMJEGGIFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct DABLPBNNHEE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData GJHMIICGHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public IReadOnlyList<TData> PLOIALLOOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool JGIAPGFMEPD;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5210690", Offset = "0x520FA90", VA = "0x185210690")]
	public DABLPBNNHEE(TData BKIEJBNOGPB, IReadOnlyList<TData> NFHEHAKCLAJ, bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface MCKBAMDCPAA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POOMJEGGIFP([In] CMPDMIJDJKH<TData> FDEBLJFBEGL);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface MIBCAGOOHAM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POOMJEGGIFP([In] JFFMMDELNHP<TData> FDEBLJFBEGL);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface ICMEKOMCDND<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IHNOGHBDEEO([In] IOANDBFGFOG<TData> FDEBLJFBEGL);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BELBHECIPIL();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class EOPJKAGJAJA<TData> : OOADPMCLKNP<MCKBAMDCPAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly CMPDMIJDJKH<TData> FDEBLJFBEGL;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3CE0", Offset = "0x3CE30E0", VA = "0x183CE3CE0")]
	public EOPJKAGJAJA(IEnumerable<TData> LADGDNIBDEA, FLEIDECPCLB IGJDLCJEHCH, HDEGMGMJOHI BEDNCOELNMN, float OJGIOHLAJPI, bool AAABJBFJLLC, MCKBAMDCPAA<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3C20", Offset = "0x3CE3020", VA = "0x183CE3C20", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class IAOFANPLMHL<TData> : OOADPMCLKNP<MIBCAGOOHAM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly JFFMMDELNHP<TData> FDEBLJFBEGL;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4328700", Offset = "0x4327B00", VA = "0x184328700")]
	public IAOFANPLMHL(TData[] LADGDNIBDEA, FLEIDECPCLB[] IGJDLCJEHCH, HDEGMGMJOHI[] BEDNCOELNMN, float[] OJGIOHLAJPI, MIBCAGOOHAM<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x41922F0", Offset = "0x41916F0", VA = "0x1841922F0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class HMLPNIBGIBD<TData> : OOADPMCLKNP<ICMEKOMCDND<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x40476D0", Offset = "0x4046AD0", VA = "0x1840476D0")]
	public HMLPNIBGIBD(ICMEKOMCDND<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x426FEB0", Offset = "0x426F2B0", VA = "0x18426FEB0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class GFBHJKHJNCL<TData> : OOADPMCLKNP<ICMEKOMCDND<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly IOANDBFGFOG<TData> FDEBLJFBEGL;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x41923B0", Offset = "0x41917B0", VA = "0x1841923B0")]
	public GFBHJKHJNCL(IEnumerable<TData> LADGDNIBDEA, FLEIDECPCLB IGJDLCJEHCH, HDEGMGMJOHI BEDNCOELNMN, float OJGIOHLAJPI, ICMEKOMCDND<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x41922F0", Offset = "0x41916F0", VA = "0x1841922F0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct CMPDMIJDJKH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public IEnumerable<TData> IHELNDFIDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public FLEIDECPCLB FHAKFMIMKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public HDEGMGMJOHI DPDBIOCNEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float OJGIOHLAJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool AAABJBFJLLC;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5903400", Offset = "0x5902800", VA = "0x185903400")]
	public CMPDMIJDJKH(IEnumerable<TData> LADGDNIBDEA, FLEIDECPCLB IGJDLCJEHCH, HDEGMGMJOHI BEDNCOELNMN, float OJGIOHLAJPI, bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct JFFMMDELNHP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public TData[] IHELNDFIDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public FLEIDECPCLB[] FHAKFMIMKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public HDEGMGMJOHI[] DPDBIOCNEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float[] OJGIOHLAJPI;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4581290", Offset = "0x4580690", VA = "0x184581290")]
	public JFFMMDELNHP(TData[] LADGDNIBDEA, FLEIDECPCLB[] IGJDLCJEHCH, HDEGMGMJOHI[] BEDNCOELNMN, float[] OJGIOHLAJPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct IOANDBFGFOG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public IEnumerable<TData> IHELNDFIDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public FLEIDECPCLB FHAKFMIMKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public HDEGMGMJOHI DPDBIOCNEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float OJGIOHLAJPI;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x435E020", Offset = "0x435D420", VA = "0x18435E020")]
	public IOANDBFGFOG(IEnumerable<TData> LADGDNIBDEA, FLEIDECPCLB IGJDLCJEHCH, HDEGMGMJOHI BEDNCOELNMN, float OJGIOHLAJPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface DDACCAIHBOO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OECDGBHNBJG([In] PIKFFABCNOB<TData> LDMIBNHBCBE);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAGEDOIJKPH([In] PIKFFABCNOB<TData> LDMIBNHBCBE);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONILNGDBHJF([In] bool DGPBJEBIOHK);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AMIPONNLADI([In] PIKFFABCNOB<TData> LDMIBNHBCBE);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JANNHJCEPLN();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AHGJHLGLMGG([In] TData FIGGNNJPHIG);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class PIJEFAKPCOF<TData> : OOADPMCLKNP<DDACCAIHBOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PIKFFABCNOB<TData> LDMIBNHBCBE;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4C6E560", Offset = "0x4C6D960", VA = "0x184C6E560")]
	public PIJEFAKPCOF(List<TData> KNHLIMDEMDB, DDACCAIHBOO<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3C20", Offset = "0x3CE3020", VA = "0x183CE3C20", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NBEEICCHDLB<TData> : OOADPMCLKNP<DDACCAIHBOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x40476D0", Offset = "0x4046AD0", VA = "0x1840476D0")]
	public NBEEICCHDLB(DDACCAIHBOO<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4A65600", Offset = "0x4A64A00", VA = "0x184A65600", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class DLGCMDIGACD<TData> : OOADPMCLKNP<DDACCAIHBOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly bool AAABJBFJLLC;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5E82490", Offset = "0x5E81890", VA = "0x185E82490")]
	public DLGCMDIGACD(bool AAABJBFJLLC, DDACCAIHBOO<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E82430", Offset = "0x5E81830", VA = "0x185E82430", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class JMJFNECMIHJ<TData> : OOADPMCLKNP<DDACCAIHBOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly PIKFFABCNOB<TData> LDMIBNHBCBE;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4596A40", Offset = "0x4595E40", VA = "0x184596A40")]
	public JMJFNECMIHJ(List<TData> KNHLIMDEMDB, bool AAABJBFJLLC, DDACCAIHBOO<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x45968D0", Offset = "0x4595CD0", VA = "0x1845968D0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class JBAEFDAAJIJ<TData> : OOADPMCLKNP<DDACCAIHBOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TData FIGGNNJPHIG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x45718E0", Offset = "0x4570CE0", VA = "0x1845718E0")]
	public JBAEFDAAJIJ(TData FIGGNNJPHIG, DDACCAIHBOO<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4571820", Offset = "0x4570C20", VA = "0x184571820", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class ILIOFNCICGL<TData> : OOADPMCLKNP<DDACCAIHBOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly PIKFFABCNOB<TData> LDMIBNHBCBE;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4357E90", Offset = "0x4357290", VA = "0x184357E90")]
	public ILIOFNCICGL(IEnumerable<TData> KNHLIMDEMDB, DDACCAIHBOO<TData> NCFNENNCOJO, bool AAABJBFJLLC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4357DD0", Offset = "0x43571D0", VA = "0x184357DD0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct PIKFFABCNOB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IEnumerable<TData> IHELNDFIDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool AAABJBFJLLC;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4C6E9C0", Offset = "0x4C6DDC0", VA = "0x184C6E9C0")]
	public PIKFFABCNOB(IEnumerable<TData> GAOPNEOAHME, bool OLLKIGNCODJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface FDIJHJNGPAC
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GKHCGAIKHFH> POOMJEGGIFP(POOEGCCGHJJ INECJNMCLCH);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class MANPLKNNNPM : GAPDDFBENFM<FDIJHJNGPAC, GKHCGAIKHFH>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct CBACIHOPHPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<GKHCGAIKHFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public MANPLKNNNPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<GKHCGAIKHFH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7042A40", Offset = "0x7041E40", VA = "0x187042A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7042CB0", Offset = "0x70420B0", VA = "0x187042CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly POOEGCCGHJJ MJBAHEBHNJM;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7044570", Offset = "0x7043970", VA = "0x187044570")]
	public MANPLKNNNPM(bool AAABJBFJLLC, FDIJHJNGPAC NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7044480", Offset = "0x7043880", VA = "0x187044480", Slot = "4")]
	[AsyncStateMachine(typeof(CBACIHOPHPI))]
	public override Task<GKHCGAIKHFH> POOMJEGGIFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct POOEGCCGHJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool JGIAPGFMEPD;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2508F90", Offset = "0x2508390", VA = "0x182508F90")]
	public POOEGCCGHJJ(bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct FGAAPFPFIPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool JGEOGPOKOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool LDKACINDMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly bool BMGLFPFGJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool AAABJBFJLLC;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x52352B0", Offset = "0x52346B0", VA = "0x1852352B0")]
	public FGAAPFPFIPN(bool JGEOGPOKOMC, bool LDKACINDMPB, bool BMGLFPFGJFF, bool AAABJBFJLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7043A30", Offset = "0x7042E30", VA = "0x187043A30")]
	public FGAAPFPFIPN(bool LDKACINDMPB, bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface OIEHFDIDDIF
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPCIAOLEEAC(FGAAPFPFIPN HEFLLKPAMMK);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FPKPJLCMEIL(FGAAPFPFIPN HEFLLKPAMMK);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class FEDCKBIMBEB : OOADPMCLKNP<OIEHFDIDDIF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly FGAAPFPFIPN HEFLLKPAMMK;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x70439A0", Offset = "0x7042DA0", VA = "0x1870439A0")]
	public FEDCKBIMBEB(bool KELFOJAPBEF, bool LDKACINDMPB, bool BMGLFPFGJFF, bool AAABJBFJLLC, OIEHFDIDDIF NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7043950", Offset = "0x7042D50", VA = "0x187043950", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class PFKBCEPAJLN : OOADPMCLKNP<OIEHFDIDDIF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly FGAAPFPFIPN HEFLLKPAMMK;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7044740", Offset = "0x7043B40", VA = "0x187044740")]
	public PFKBCEPAJLN(bool LDKACINDMPB, bool AAABJBFJLLC, OIEHFDIDDIF NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x70446F0", Offset = "0x7043AF0", VA = "0x1870446F0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface KGKFCMKJFCD
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POOMJEGGIFP([In] DJFGCMKAOPF BAFHBNHDHEG);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class INADKEGBCDO : OOADPMCLKNP<KGKFCMKJFCD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly DJFGCMKAOPF BAFHBNHDHEG;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7043B10", Offset = "0x7042F10", VA = "0x187043B10")]
	public INADKEGBCDO(Guid[] MGDJADPKAEP, Vector3[] DIKPOHJEHCK, Quaternion[] DHHAHPIDILD, float[] LDNJCMHJHKP, Dictionary<Guid, Vector3> HAPMJFFFFAL, KGKFCMKJFCD NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7043A60", Offset = "0x7042E60", VA = "0x187043A60", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface HOFPIIDHKHF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELFBOLHDMBI([In] GPALKGAOJNF<TData> NKGGCNDGILO);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IHNOGHBDEEO([In] PAEFLIEHDPL PBNANFBBHOM);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IHNOGHBDEEO([In] PMMEMHBIAJG PBNANFBBHOM);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BELBHECIPIL();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class AHDLJFEBFBH<TData> : OOADPMCLKNP<HOFPIIDHKHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x40476D0", Offset = "0x4046AD0", VA = "0x1840476D0")]
	public AHDLJFEBFBH(HOFPIIDHKHF<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x41D5600", Offset = "0x41D4A00", VA = "0x1841D5600", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class GOKFPFMFBBJ<TData> : OOADPMCLKNP<HOFPIIDHKHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly PAEFLIEHDPL APHOACNMFJC;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x41B6350", Offset = "0x41B5750", VA = "0x1841B6350")]
	public GOKFPFMFBBJ(Vector3 JHIJNLKIHFF, bool FGLNKMJIJIM, HOFPIIDHKHF<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x41B62F0", Offset = "0x41B56F0", VA = "0x1841B62F0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class DLMLAFKDNHO<TData> : OOADPMCLKNP<HOFPIIDHKHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly PMMEMHBIAJG APHOACNMFJC;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E82A20", Offset = "0x5E81E20", VA = "0x185E82A20")]
	public DLMLAFKDNHO(Guid IJGPOLEOKBM, int IIACLAMOIEE, Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, float NCJKDICMFFP, bool FGLNKMJIJIM, HOFPIIDHKHF<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E829C0", Offset = "0x5E81DC0", VA = "0x185E829C0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class JKEOCPHMLBO<TData> : OOADPMCLKNP<HOFPIIDHKHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GPALKGAOJNF<TData> APHOACNMFJC;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x458AA90", Offset = "0x4589E90", VA = "0x18458AA90")]
	public JKEOCPHMLBO(TData MGPMAFDHMLC, bool AAABJBFJLLC, HOFPIIDHKHF<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3C20", Offset = "0x3CE3020", VA = "0x183CE3C20", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct PAEFLIEHDPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly Vector3 JHIJNLKIHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly bool FGLNKMJIJIM;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7044690", Offset = "0x7043A90", VA = "0x187044690")]
	public PAEFLIEHDPL(Vector3 JHIJNLKIHFF, bool FGLNKMJIJIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct PMMEMHBIAJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Guid IJGPOLEOKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly int IIACLAMOIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 CPGMOBFHDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly Quaternion CBCAIPELAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly float NCJKDICMFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool FGLNKMJIJIM;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x70447C0", Offset = "0x7043BC0", VA = "0x1870447C0")]
	public PMMEMHBIAJG(Guid IJGPOLEOKBM, int IIACLAMOIEE, Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, float NCJKDICMFFP, bool FGLNKMJIJIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct GPALKGAOJNF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly TData MGPMAFDHMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool AAABJBFJLLC;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x41B7110", Offset = "0x41B6510", VA = "0x1841B7110")]
	public GPALKGAOJNF(TData MGPMAFDHMLC, bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface MCPLCBGKICL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POOMJEGGIFP([In] GAIKFKNHKIK<TData> LMKGCFCNOIB);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool POOMJEGGIFP([In] AJKJEMBOAFP<TData> LMKGCFCNOIB);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface JJIMIOOGNBM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELFBOLHDMBI([In] JCPJFHAOCPD<TData> HEILPPJOGPF);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IHNOGHBDEEO([In] ECLLOMBPGNB PBNANFBBHOM);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BELBHECIPIL();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class JFLIFDPKDGE<TData> : OOADPMCLKNP<MCPLCBGKICL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly GAIKFKNHKIK<TData> LMKGCFCNOIB;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4581ED0", Offset = "0x45812D0", VA = "0x184581ED0")]
	public JFLIFDPKDGE(IEnumerable<TData> LADGDNIBDEA, Vector3 JNOPPAIAPII, bool AAABJBFJLLC, MCPLCBGKICL<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3C20", Offset = "0x3CE3020", VA = "0x183CE3C20", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class FGDNPGACMEK<TData> : OOADPMCLKNP<JJIMIOOGNBM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x40476D0", Offset = "0x4046AD0", VA = "0x1840476D0")]
	public FGDNPGACMEK(JJIMIOOGNBM<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x407E3D0", Offset = "0x407D7D0", VA = "0x18407E3D0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class CBEGAPFBPLG<TData> : OOADPMCLKNP<JJIMIOOGNBM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly JCPJFHAOCPD<TData> LMKGCFCNOIB;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5608A30", Offset = "0x5607E30", VA = "0x185608A30")]
	public CBEGAPFBPLG(IEnumerable<TData> LADGDNIBDEA, bool AAABJBFJLLC, JJIMIOOGNBM<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3C20", Offset = "0x3CE3020", VA = "0x183CE3C20", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class EDDAHBGHEFE<TData> : OOADPMCLKNP<MCPLCBGKICL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly AJKJEMBOAFP<TData> LMKGCFCNOIB;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB400", Offset = "0x3CBA800", VA = "0x183CBB400")]
	public EDDAHBGHEFE(IEnumerable<TData> LADGDNIBDEA, Vector3 HBCIFCIKLNP, EJFEMBCBFDE AFJEKDAEOCF, bool AAABJBFJLLC, MCPLCBGKICL<TData> NCFNENNCOJO, Space INLNEDNKOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB340", Offset = "0x3CBA740", VA = "0x183CBB340", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class IKONHNOGLJL<TData> : OOADPMCLKNP<JJIMIOOGNBM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly ECLLOMBPGNB LMKGCFCNOIB;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4355500", Offset = "0x4354900", VA = "0x184355500")]
	public IKONHNOGLJL(Vector3 JNOPPAIAPII, JJIMIOOGNBM<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x41B62F0", Offset = "0x41B56F0", VA = "0x1841B62F0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct GAIKFKNHKIK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly IEnumerable<TData> LADGDNIBDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 JNOPPAIAPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool AAABJBFJLLC;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x414A360", Offset = "0x4149760", VA = "0x18414A360")]
	public GAIKFKNHKIK(IEnumerable<TData> LADGDNIBDEA, Vector3 JNOPPAIAPII, bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct JCPJFHAOCPD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly IEnumerable<TData> LADGDNIBDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool AAABJBFJLLC;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4574B30", Offset = "0x4573F30", VA = "0x184574B30")]
	public JCPJFHAOCPD(IEnumerable<TData> LADGDNIBDEA, bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct AJKJEMBOAFP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly IEnumerable<TData> LADGDNIBDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Vector3 HBCIFCIKLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly EJFEMBCBFDE AFJEKDAEOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool AAABJBFJLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly Space INLNEDNKOCA;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x41E1B50", Offset = "0x41E0F50", VA = "0x1841E1B50")]
	public AJKJEMBOAFP(IEnumerable<TData> LADGDNIBDEA, Vector3 HBCIFCIKLNP, EJFEMBCBFDE AFJEKDAEOCF, bool AAABJBFJLLC, Space INLNEDNKOCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct ECLLOMBPGNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Vector3 JNOPPAIAPII;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2509540", Offset = "0x2508940", VA = "0x182509540")]
	public ECLLOMBPGNB(Vector3 JNOPPAIAPII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum EJFEMBCBFDE
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface BJPNMLELDJJ
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POOMJEGGIFP([In] ENDFDDIPBMH AGHHJNPOFJL);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class CHIMFLJHFGF : OOADPMCLKNP<BJPNMLELDJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly ENDFDDIPBMH AGHHJNPOFJL;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7042DD0", Offset = "0x70421D0", VA = "0x187042DD0")]
	public CHIMFLJHFGF(bool AAABJBFJLLC, BJPNMLELDJJ NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7042D20", Offset = "0x7042120", VA = "0x187042D20", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct ENDFDDIPBMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool AAABJBFJLLC;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2508F90", Offset = "0x2508390", VA = "0x182508F90")]
	public ENDFDDIPBMH(bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface KJLLNOEJBOA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POOMJEGGIFP([In] OJGHLOOMKIO<TData> EDKICGCGIIL);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool POOMJEGGIFP([In] PCMFALEGHJP<TData> EDKICGCGIIL);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface FIKIKMOMHJL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELFBOLHDMBI([In] JAELMBNIIDP<TData> NKGGCNDGILO);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IHNOGHBDEEO([In] MDAFEIMJGPK PBNANFBBHOM);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BELBHECIPIL();
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class JFCLJIEJJEF<TData> : OOADPMCLKNP<KJLLNOEJBOA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly OJGHLOOMKIO<TData> EDKICGCGIIL;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4580840", Offset = "0x457FC40", VA = "0x184580840")]
	public JFCLJIEJJEF(IEnumerable<TData> LADGDNIBDEA, Quaternion JNOPPAIAPII, Vector3? KPEIAFKLKOA, bool AHPLPGMIFIC, bool AAABJBFJLLC, KJLLNOEJBOA<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3C20", Offset = "0x3CE3020", VA = "0x183CE3C20", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class DLNOKIENNBL<TData> : OOADPMCLKNP<FIKIKMOMHJL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x40476D0", Offset = "0x4046AD0", VA = "0x1840476D0")]
	public DLNOKIENNBL(FIKIKMOMHJL<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x407E3D0", Offset = "0x407D7D0", VA = "0x18407E3D0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class JGMCDAJCMLL<TData> : OOADPMCLKNP<FIKIKMOMHJL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly JAELMBNIIDP<TData> EDKICGCGIIL;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x45844D0", Offset = "0x45838D0", VA = "0x1845844D0")]
	public JGMCDAJCMLL(IEnumerable<TData> LADGDNIBDEA, bool AAABJBFJLLC, FIKIKMOMHJL<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3C20", Offset = "0x3CE3020", VA = "0x183CE3C20", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class DJLNBOJAMPH<TData> : OOADPMCLKNP<KJLLNOEJBOA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly PCMFALEGHJP<TData> EDKICGCGIIL;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A220", Offset = "0x5E79620", VA = "0x185E7A220")]
	public DJLNBOJAMPH(IEnumerable<TData> LADGDNIBDEA, Quaternion BPMBEAOBAND, EJFEMBCBFDE AFHAEPJHNFC, Vector3? KPEIAFKLKOA, bool AHPLPGMIFIC, bool AAABJBFJLLC, Space INLNEDNKOCA, KJLLNOEJBOA<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB340", Offset = "0x3CBA740", VA = "0x183CBB340", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class LEBNAJGDPPB<TData> : OOADPMCLKNP<FIKIKMOMHJL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MDAFEIMJGPK EDKICGCGIIL;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x47BE8D0", Offset = "0x47BDCD0", VA = "0x1847BE8D0")]
	public LEBNAJGDPPB(Quaternion JNOPPAIAPII, Vector3? KPEIAFKLKOA, bool AHPLPGMIFIC, FIKIKMOMHJL<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x41B62F0", Offset = "0x41B56F0", VA = "0x1841B62F0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct OJGHLOOMKIO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly IEnumerable<TData> LADGDNIBDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Quaternion JNOPPAIAPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3? KPEIAFKLKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool AHPLPGMIFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool AAABJBFJLLC;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4B8BA10", Offset = "0x4B8AE10", VA = "0x184B8BA10")]
	public OJGHLOOMKIO(IEnumerable<TData> LADGDNIBDEA, Quaternion JNOPPAIAPII, Vector3? KPEIAFKLKOA, bool AHPLPGMIFIC, bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct JAELMBNIIDP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly IEnumerable<TData> LADGDNIBDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly bool AAABJBFJLLC;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x456FAA0", Offset = "0x456EEA0", VA = "0x18456FAA0")]
	public JAELMBNIIDP(IEnumerable<TData> LADGDNIBDEA, bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct PCMFALEGHJP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly IEnumerable<TData> LADGDNIBDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly Quaternion BPMBEAOBAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly EJFEMBCBFDE AFHAEPJHNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3? KPEIAFKLKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool AHPLPGMIFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool AAABJBFJLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space INLNEDNKOCA;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4C598B0", Offset = "0x4C58CB0", VA = "0x184C598B0")]
	public PCMFALEGHJP(IEnumerable<TData> LADGDNIBDEA, Quaternion BPMBEAOBAND, EJFEMBCBFDE AFHAEPJHNFC, Vector3? KPEIAFKLKOA, bool AHPLPGMIFIC, bool AAABJBFJLLC, Space INLNEDNKOCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct MDAFEIMJGPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Quaternion JNOPPAIAPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly Vector3? KPEIAFKLKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool AHPLPGMIFIC;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x51FC850", Offset = "0x51FBC50", VA = "0x1851FC850")]
	public MDAFEIMJGPK(Quaternion JNOPPAIAPII, Vector3? KPEIAFKLKOA, bool AHPLPGMIFIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface GFHNOAMCGIC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELFBOLHDMBI([In] FGJBFNDLBBD<TData> NKGGCNDGILO);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IHNOGHBDEEO([In] EKKLMFGFGCB PBNANFBBHOM);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IHNOGHBDEEO([In] FJFLGGGBOOL PBNANFBBHOM);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IHNOGHBDEEO([In] PDEKOJGGACB PBNANFBBHOM);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BELBHECIPIL();
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class KKGHFOKHAJM<TData> : OOADPMCLKNP<GFHNOAMCGIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly PDEKOJGGACB MFOPBEBEEKE;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x469B4D0", Offset = "0x469A8D0", VA = "0x18469B4D0")]
	public KKGHFOKHAJM(Vector3 MMKILCOOPOF, float MPACBOHCOML, Vector3 KPEIAFKLKOA, bool FNDPKNLMDJC, bool LMFKBBPMIIA, GFHNOAMCGIC<TData> NCFNENNCOJO, Space INLNEDNKOCA = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x469B470", Offset = "0x469A870", VA = "0x18469B470", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class DAPGKACMBPI<TData> : OOADPMCLKNP<GFHNOAMCGIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x40476D0", Offset = "0x4046AD0", VA = "0x1840476D0")]
	public DAPGKACMBPI(GFHNOAMCGIC<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B310", Offset = "0x5E4A710", VA = "0x185E4B310", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class JDCOKCNKAJI<TData> : OOADPMCLKNP<GFHNOAMCGIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly FGJBFNDLBBD<TData> MFOPBEBEEKE;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4575240", Offset = "0x4574640", VA = "0x184575240")]
	public JDCOKCNKAJI(IEnumerable<TData> LADGDNIBDEA, bool AAABJBFJLLC, GFHNOAMCGIC<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3C20", Offset = "0x3CE3020", VA = "0x183CE3C20", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class DMHILIECDPE<TData> : OOADPMCLKNP<GFHNOAMCGIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly FJFLGGGBOOL MFOPBEBEEKE;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E82E60", Offset = "0x5E82260", VA = "0x185E82E60")]
	public DMHILIECDPE(float BJFKONLFDCF, bool CIGJKLBICAN, Vector3 KPEIAFKLKOA, GFHNOAMCGIC<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E82DA0", Offset = "0x5E821A0", VA = "0x185E82DA0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class IGDGEDJHKAC<TData> : OOADPMCLKNP<GFHNOAMCGIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly EKKLMFGFGCB MFOPBEBEEKE;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4336010", Offset = "0x4335410", VA = "0x184336010")]
	public IGDGEDJHKAC(float MPACBOHCOML, Vector3 KPEIAFKLKOA, GFHNOAMCGIC<TData> NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x41B62F0", Offset = "0x41B56F0", VA = "0x1841B62F0", Slot = "4")]
	public override bool POOMJEGGIFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct PDEKOJGGACB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 MMKILCOOPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly float MPACBOHCOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Vector3 KPEIAFKLKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool FGLNKMJIJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Space INLNEDNKOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool LMFKBBPMIIA;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x70446B0", Offset = "0x7043AB0", VA = "0x1870446B0")]
	public PDEKOJGGACB(Vector3 MMKILCOOPOF, float MPACBOHCOML, Vector3 KPEIAFKLKOA, bool FGLNKMJIJIM, bool CPOFEGEIKMH, Space INLNEDNKOCA = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct FGJBFNDLBBD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly IEnumerable<TData> LADGDNIBDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool AAABJBFJLLC;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x407E8B0", Offset = "0x407DCB0", VA = "0x18407E8B0")]
	public FGJBFNDLBBD(IEnumerable<TData> LADGDNIBDEA, bool AAABJBFJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct FJFLGGGBOOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float BJFKONLFDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool CIGJKLBICAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Vector3 KPEIAFKLKOA;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7043A40", Offset = "0x7042E40", VA = "0x187043A40")]
	public FJFLGGGBOOL(float BJFKONLFDCF, bool CIGJKLBICAN, Vector3 KPEIAFKLKOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct EKKLMFGFGCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly float MPACBOHCOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Vector3 KPEIAFKLKOA;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x51BD0A0", Offset = "0x51BC4A0", VA = "0x1851BD0A0")]
	public EKKLMFGFGCB(float MPACBOHCOML, Vector3 KPEIAFKLKOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct DJFGCMKAOPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly Guid[] LADGDNIBDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool PHKMLPOBFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool ELCLHCDHBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool HJKKLPMNAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3[] DIKPOHJEHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion[] DHHAHPIDILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly float[] LDNJCMHJHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly Dictionary<Guid, Vector3> HAPMJFFFFAL;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x70436C0", Offset = "0x7042AC0", VA = "0x1870436C0")]
	public DJFGCMKAOPF(Guid[] MGDJADPKAEP, Vector3[] DIKPOHJEHCK, Quaternion[] DHHAHPIDILD, float[] LDNJCMHJHKP, Dictionary<Guid, Vector3> HAPMJFFFFAL, bool PHKMLPOBFDL = true, bool ELCLHCDHBLH = true, bool HJKKLPMNAAK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x70434F0", Offset = "0x70428F0", VA = "0x1870434F0")]
	private static void MBDEDJCDIFM(Dictionary<Guid, Vector3> HAPMJFFFFAL, int CDBFMLJGGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class CPBJKNAFOCL
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private struct HACAMCPAHFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public bool KGLJPFGJGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public CGJHFFGEHKC NKLJCGFGLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public CGJHFFGEHKC FLFFPCBLHAI;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static HACAMCPAHFB FLFHCBJGGNN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken GGAGHGDLNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x70434D0", Offset = "0x70428D0", VA = "0x1870434D0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static CGJHFFGEHKC NKLJCGFGLHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7043140", Offset = "0x7042540", VA = "0x187043140")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7043330", Offset = "0x7042730", VA = "0x187043330")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7043390", Offset = "0x7042790", VA = "0x187043390")]
	[AGCFNMIICNN.EOJADANDAPN]
	internal static void FAMCDKJJNOL(CGJHFFGEHKC PLBLCOBMOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x70431E0", Offset = "0x70425E0", VA = "0x1870431E0")]
	public static void CALNFFOLFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7043480", Offset = "0x7042880", VA = "0x187043480")]
	private static CGJHFFGEHKC JEMMLPOPHJF(CGJHFFGEHKC BGCFKAPEFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class NKGGKKLKKAD
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum FFMPDFDHOMG
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x31E15A0", Offset = "0x31E09A0", VA = "0x1831E15A0")]
	public static void GOIKKKFECLI<T>(T JHHLONNMNDJ, FFMPDFDHOMG IFBDJLKPHIG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x31E1530", Offset = "0x31E0930", VA = "0x1831E1530")]
	public static void GOIKKKFECLI<T>(T JHHLONNMNDJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x31E1480", Offset = "0x31E0880", VA = "0x1831E1480")]
	public static void BCPHDNPEKAC<T>(T JHHLONNMNDJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x31E1120", Offset = "0x31E0520", VA = "0x1831E1120")]
	public static T AFFELPLAAIM<T>(FFMPDFDHOMG IFBDJLKPHIG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x31E1280", Offset = "0x31E0680", VA = "0x1831E1280")]
	public static bool BBKOOAPFEDD<T>(FFMPDFDHOMG IFBDJLKPHIG, T? MLFCOOPJFDI, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T PNIDMJDFKGL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x31E11D0", Offset = "0x31E05D0", VA = "0x1831E11D0")]
	public static bool AMNIFDIPNFM<T>(FFMPDFDHOMG IFBDJLKPHIG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x31E10C0", Offset = "0x31E04C0", VA = "0x1831E10C0")]
	public static T AFFELPLAAIM<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x31E13D0", Offset = "0x31E07D0", VA = "0x1831E13D0")]
	public static bool BBKOOAPFEDD<T>(T MLFCOOPJFDI, [Out] T PNIDMJDFKGL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x31E10C0", Offset = "0x31E04C0", VA = "0x1831E10C0")]
	public static bool AMNIFDIPNFM<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal static class AJLJIBEGFKH
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7042810", Offset = "0x7041C10", VA = "0x187042810")]
	public static void ILLJKIFDAHC(IEnumerable JEMNFEFNBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x372C340", Offset = "0x372B740", VA = "0x18372C340")]
	public static void ILLJKIFDAHC<T>(T[] CHDCMIMONFN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x372C520", Offset = "0x372B920", VA = "0x18372C520")]
	public static void ILLJKIFDAHC<T>(T GAADACALPOM) where T : notnull, Enum
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
