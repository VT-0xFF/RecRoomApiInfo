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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6911810", Offset = "0x6910410", VA = "0x186911810")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BOALICMPGEP<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn FGHJIECPKLB(TData HAHECKLGOJC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FHKFIDDFFFB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(BLFADNMHOLO AJACKEJGABF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData PJIFCLGMLOL, Collider PJBKCKGLLLK, BLFADNMHOLO AJACKEJGABF, [Optional] MHJGHFLMOAG? LNHOCHABGCE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData PJIFCLGMLOL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider PJBKCKGLLLK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NHCLJCJFEDA<TData> : BFHHJPJMOKK, DJEAONJMGKF<TData>, JFFGLINEGEC<TData>, FIFJFBNCHLD<TData>, DKDLPFPNALH, GFPIBNDKLKA<TData>, ECGEIMHOIFL, BGBLMOHEHEM
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GFPIBNDKLKA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 JJNNAHKJEAK, Vector3 ALGFLILJAIC, float CEGICKHHGEL, [Out] T PFLHFNGDIIH, [Out] Vector3 GGCKAHGJGNM, [Out] Collider PJBKCKGLLLK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 JJNNAHKJEAK, Vector3 ALGFLILJAIC, float OLNAOMHJPBA, float CEGICKHHGEL, T[] BCEHJNNMGCC, [Out] Vector3 IFBNOOHNIBJ, [Out] Collider LNONEGBHOJC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 JJNNAHKJEAK, float OLNAOMHJPBA, Vector3 BCLHBPJNHJM, T[] BCEHJNNMGCC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider FJEKLDBPJED, [Out] T HEDCNPDNHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BFHHJPJMOKK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds OMEGDOPKPKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform GHOKAJLOMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds GHLEPFKNOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform JGMIDEEIBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 DFHJLLHIEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IDAEHPNEOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool DJNAPNINMGB = true, int KGOGACNNFHK = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool PGFHIOICKPM, object FGIAGALCIAP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BGBLMOHEHEM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DEHOLECDIJP LNDADMKLFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JBOOOOOFJBC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GFHFBCBMFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool ADOGOOIJMPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool PPLDKIJOEKN
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> PEDIBPFJPOJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FIFJFBNCHLD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool AIIBLHIOGLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int HOEGHONFKKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> HFKHJBMNIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData LBACBPHHKAE);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData LBACBPHHKAE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DJEAONJMGKF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T HAHECKLGOJC, [Optional] MHJGHFLMOAG? AGFHCGHHMOJ, bool EPFBGPMEAHN = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int HDFABDCMCAG, IEnumerable<T> KHFMAIAPCOA, bool EPFBGPMEAHN = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int HDFABDCMCAG, IEnumerable<T> KHFMAIAPCOA, MHJGHFLMOAG AGFHCGHHMOJ, bool EPFBGPMEAHN = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ECGEIMHOIFL
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DKDLPFPNALH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool JPMPBIOODEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool CIAFDMAFOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool AOMOKEFDPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool PJIOFAJOKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class AJJPDPGLPEH<TReceiver> : KHNAMALGEKO<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x37B6CC0", Offset = "0x37B58C0", VA = "0x1837B6CC0")]
	public AJJPDPGLPEH(TReceiver PPFPKNPFHFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class PALGAFPPMDD<TReceiver, TFromTask> : KHNAMALGEKO<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x37B6CC0", Offset = "0x37B58C0", VA = "0x1837B6CC0")]
	public PALGAFPPMDD(TReceiver PPFPKNPFHFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class KHNAMALGEKO<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver PPFPKNPFHFN;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4151590", Offset = "0x4150190", VA = "0x184151590")]
	public KHNAMALGEKO(TReceiver PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute FLADJOFCMKI();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class MJKGDKGPIJO<TReceiver, TResult> : KHNAMALGEKO<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x37B6CC0", Offset = "0x37B58C0", VA = "0x1837B6CC0")]
	public MJKGDKGPIJO(TReceiver PPFPKNPFHFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct OPNIEAFGKHA<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup LFCKAJFBJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData IGEGMPHDIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> GNFIIPFHAME;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E79650", Offset = "0x1E78250", VA = "0x181E79650")]
	public OPNIEAFGKHA(TGroup NAJNGLNMOLF, TData KLNAMIDIANC, IEnumerable<TData> DFMADHDIPEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BJDGIAGCHNL<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup LFCKAJFBJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> GNFIIPFHAME;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA93C90", Offset = "0xA92890", VA = "0x180A93C90")]
	public BJDGIAGCHNL(TGroup NAJNGLNMOLF, IEnumerable<TData> DFMADHDIPEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CFPMCNEGPHK<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup LFCKAJFBJGN;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
	public CFPMCNEGPHK(TGroup NAJNGLNMOLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PGBPOAIPPCC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> GNFIIPFHAME;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
	public PGBPOAIPPCC(IEnumerable<TData> DFMADHDIPEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OKHONIJKPMF<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IMEKCHIMAAN HBJKJIFCGHI(OPNIEAFGKHA<TGroup, TData> JBLIOEMEIAG);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IMEKCHIMAAN CIFKIJLBHIE(OPNIEAFGKHA<TGroup, TData> JBLIOEMEIAG);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IMEKCHIMAAN KAFGMCBGADI(BJDGIAGCHNL<TGroup, TData> JBLIOEMEIAG);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IMEKCHIMAAN IPANGMIEMKP(CFPMCNEGPHK<TGroup> JBLIOEMEIAG);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FEBMPBGJGDM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IMEKCHIMAAN> HBJKJIFCGHI(PGBPOAIPPCC<TData> JBLIOEMEIAG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EINIKMDPEJG<TGroup, TData> : MJKGDKGPIJO<OKHONIJKPMF<TGroup, TData>, IMEKCHIMAAN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly BJDGIAGCHNL<TGroup, TData> JBLIOEMEIAG;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x37FB4F0", Offset = "0x37FA0F0", VA = "0x1837FB4F0")]
	public EINIKMDPEJG(TGroup NAJNGLNMOLF, IEnumerable<TData> DFMADHDIPEM, OKHONIJKPMF<TGroup, TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x37FB420", Offset = "0x37FA020", VA = "0x1837FB420", Slot = "4")]
	public override IMEKCHIMAAN FLADJOFCMKI()
	{
		return default(IMEKCHIMAAN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NHFCNMBHINL<TGroup, TData> : MJKGDKGPIJO<OKHONIJKPMF<TGroup, TData>, IMEKCHIMAAN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly OPNIEAFGKHA<TGroup, TData> JBLIOEMEIAG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x43F1F60", Offset = "0x43F0B60", VA = "0x1843F1F60")]
	public NHFCNMBHINL(TGroup NAJNGLNMOLF, TData AEAKALGBOHF, IEnumerable<TData> DFMADHDIPEM, OKHONIJKPMF<TGroup, TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x44900B0", Offset = "0x448ECB0", VA = "0x1844900B0", Slot = "4")]
	public override IMEKCHIMAAN FLADJOFCMKI()
	{
		return default(IMEKCHIMAAN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NMIIHCNGMGO<TGroup, TData> : MJKGDKGPIJO<OKHONIJKPMF<TGroup, TData>, IMEKCHIMAAN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CFPMCNEGPHK<TGroup> JBLIOEMEIAG;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3E74270", Offset = "0x3E72E70", VA = "0x183E74270")]
	public NMIIHCNGMGO(TGroup NAJNGLNMOLF, OKHONIJKPMF<TGroup, TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x449F360", Offset = "0x449DF60", VA = "0x18449F360", Slot = "4")]
	public override IMEKCHIMAAN FLADJOFCMKI()
	{
		return default(IMEKCHIMAAN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MFKGGOIJMOF<TGroup, TData> : MJKGDKGPIJO<OKHONIJKPMF<TGroup, TData>, IMEKCHIMAAN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OPNIEAFGKHA<TGroup, TData> JBLIOEMEIAG;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x43F1F60", Offset = "0x43F0B60", VA = "0x1843F1F60")]
	public MFKGGOIJMOF(TGroup NAJNGLNMOLF, TData KLNAMIDIANC, IEnumerable<TData> DFMADHDIPEM, OKHONIJKPMF<TGroup, TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x43F1E80", Offset = "0x43F0A80", VA = "0x1843F1E80", Slot = "4")]
	public override IMEKCHIMAAN FLADJOFCMKI()
	{
		return default(IMEKCHIMAAN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BDOKGBEFPNN<TData> : PALGAFPPMDD<FEBMPBGJGDM<TData>, IMEKCHIMAAN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct DBMPLAPNDMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<IMEKCHIMAAN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BDOKGBEFPNN<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<IMEKCHIMAAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x57C3AF0", Offset = "0x57C26F0", VA = "0x1857C3AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x57C3D90", Offset = "0x57C2990", VA = "0x1857C3D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private PGBPOAIPPCC<TData> JBLIOEMEIAG;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3E74270", Offset = "0x3E72E70", VA = "0x183E74270")]
	public BDOKGBEFPNN(IEnumerable<TData> OFHKLOENPOA, FEBMPBGJGDM<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4E44A70", Offset = "0x4E43670", VA = "0x184E44A70", Slot = "4")]
	[AsyncStateMachine(typeof(BDOKGBEFPNN<>.DBMPLAPNDMK))]
	public override Task<IMEKCHIMAAN> FLADJOFCMKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct CLHCACOIDKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly IPMKHLIOJPN BFGHEAEIDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool GOAAPNJAGON;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6910B10", Offset = "0x690F710", VA = "0x186910B10")]
	public CLHCACOIDKF(IPMKHLIOJPN JNPFKDAPHAC, bool LLJMLECIEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LOMCPAMCIJB<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> FLADJOFCMKI(CLHCACOIDKF AFODNDFFOJN);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BEHOHGAJIPJ<TSpawnType> : PALGAFPPMDD<LOMCPAMCIJB<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct DKKCMJEGECJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public BEHOHGAJIPJ<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x57ED640", Offset = "0x57EC240", VA = "0x1857ED640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x537C870", Offset = "0x537B470", VA = "0x18537C870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly CLHCACOIDKF AFODNDFFOJN;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4E52B30", Offset = "0x4E51730", VA = "0x184E52B30")]
	public BEHOHGAJIPJ(IPMKHLIOJPN JNPFKDAPHAC, bool LLJMLECIEDD, LOMCPAMCIJB<TSpawnType> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4E52830", Offset = "0x4E51430", VA = "0x184E52830", Slot = "4")]
	[AsyncStateMachine(typeof(BEHOHGAJIPJ<>.DKKCMJEGECJ))]
	public override Task<TSpawnType> FLADJOFCMKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct IPMKHLIOJPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool KAKKAAILBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 LDJLGOFDCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 KJEIHCPEBJE;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6911210", Offset = "0x690FE10", VA = "0x186911210")]
	public IPMKHLIOJPN(Transform OBDBFOJICMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x69111E0", Offset = "0x690FDE0", VA = "0x1869111E0")]
	public IPMKHLIOJPN(Vector3 KLEPCPADMKG, Vector3 DFPHDEDIHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x69111B0", Offset = "0x690FDB0", VA = "0x1869111B0")]
	public static IPMKHLIOJPN KLPACBHCBJJ()
	{
		return default(IPMKHLIOJPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6911280", Offset = "0x690FE80", VA = "0x186911280")]
	private IPMKHLIOJPN(bool LPGENHPJFNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct AGLBDIEPPMC<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode EPGHKEDGOBE;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2EE0", Offset = "0x3CD1AE0", VA = "0x183CD2EE0")]
	public AGLBDIEPPMC(TNode EPGHKEDGOBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct EJJKAMEMNGG<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode GMFNANECDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public HDPLIJGLGFG GLKLIPLJLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool GOAAPNJAGON;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x37FD190", Offset = "0x37FBD90", VA = "0x1837FD190")]
	public EJJKAMEMNGG(TNode GMFNANECDKL, HDPLIJGLGFG GLKLIPLJLHK, bool LLJMLECIEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LKLKKALIMEF<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEACFDGPOID([In] AGLBDIEPPMC<TNode> PEEFMEIFFLK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EFLJPONDNGE([In] EJJKAMEMNGG<TNode> KFEGCHIMNIG);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IAINJCHIHKP();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class FGMCDEENGFM<TNode> : AJJPDPGLPEH<LKLKKALIMEF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x37B6CC0", Offset = "0x37B58C0", VA = "0x1837B6CC0")]
	public FGMCDEENGFM(LKLKKALIMEF<TNode> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2ED0", Offset = "0x3BA1AD0", VA = "0x183BA2ED0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class IEAIACGGHPC<TNode> : AJJPDPGLPEH<LKLKKALIMEF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly EJJKAMEMNGG<TNode> KFEGCHIMNIG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3E24D90", Offset = "0x3E23990", VA = "0x183E24D90")]
	public IEAIACGGHPC(TNode GMFNANECDKL, HDPLIJGLGFG GLKLIPLJLHK, LKLKKALIMEF<TNode> PPFPKNPFHFN, bool LLJMLECIEDD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3CE76D0", Offset = "0x3CE62D0", VA = "0x183CE76D0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class OGOLKEJAKMF<TNode> : AJJPDPGLPEH<LKLKKALIMEF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly AGLBDIEPPMC<TNode> PEEFMEIFFLK;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4588560", Offset = "0x4587160", VA = "0x184588560")]
	public OGOLKEJAKMF(TNode NINPNCNEGJJ, LKLKKALIMEF<TNode> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3CC27C0", Offset = "0x3CC13C0", VA = "0x183CC27C0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct KINIGFAFJLG<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo CFKJANOOHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 DFPHDEDIHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion DELGPMLKBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float IADPMFLONGE;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4151D90", Offset = "0x4150990", VA = "0x184151D90")]
	public KINIGFAFJLG(TSpawnInfo CFKJANOOHFD, Vector3 DFPHDEDIHFK, Quaternion DELGPMLKBMI, float IADPMFLONGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface BMMPCOGJGPB<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> FLGGHHFKFPL([In] KINIGFAFJLG<TSpawnInfo> LJAHOIJLOOH, CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class POFBEHFAOFG<TSpawnType, TSpawnInfo> : PALGAFPPMDD<BMMPCOGJGPB<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly KINIGFAFJLG<TSpawnInfo> LLJCEPGKLEC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x47832F0", Offset = "0x4781EF0", VA = "0x1847832F0")]
	public POFBEHFAOFG(TSpawnInfo OKOKIHOLIEP, Vector3 DFPHDEDIHFK, Quaternion DELGPMLKBMI, float IADPMFLONGE, BMMPCOGJGPB<TSpawnType, TSpawnInfo> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4783100", Offset = "0x4781D00", VA = "0x184783100", Slot = "4")]
	public override Task<TSpawnType> FLADJOFCMKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct NJHMGECDCKD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> GNFIIPFHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool GOAAPNJAGON;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4498170", Offset = "0x4496D70", VA = "0x184498170")]
	public NJHMGECDCKD(IEnumerable<TData> DFMADHDIPEM, bool LLJMLECIEDD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface PEOFMLIPCIO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IMEKCHIMAAN> PJOBHDEPHCB([In] NJHMGECDCKD<TData> KHBJDPNHBLM, CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class CNOCOMIONKK<TData> : PALGAFPPMDD<PEOFMLIPCIO<TData>, IMEKCHIMAAN> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly NJHMGECDCKD<TData> FOHMMNHKDAE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5382350", Offset = "0x5380F50", VA = "0x185382350")]
	public CNOCOMIONKK(IEnumerable<TData> DFMADHDIPEM, bool LLJMLECIEDD, PEOFMLIPCIO<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4783100", Offset = "0x4781D00", VA = "0x184783100", Slot = "4")]
	public override Task<IMEKCHIMAAN> FLADJOFCMKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct HKHNJFNFPLC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T PJIFCLGMLOL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3D552B0", Offset = "0x3D53EB0", VA = "0x183D552B0")]
	public HKHNJFNFPLC(T EBANNKBFLNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FLLPKEMOJMA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEACFDGPOID([In] HKHNJFNFPLC<T> LKIPBJAEGOJ);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EFLJPONDNGE();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface GNGPAELBOAG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLADJOFCMKI([In] POHAKADEAMA<T> HIFNONEOKHL);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct POHAKADEAMA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T PJIFCLGMLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool CPAEDDLGHOO;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x47833F0", Offset = "0x4781FF0", VA = "0x1847833F0")]
	public POHAKADEAMA(T EBANNKBFLNO, bool DJOCINOAHMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class IJPLJLEDGFA<T> : AJJPDPGLPEH<FLLPKEMOJMA<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x37B6CC0", Offset = "0x37B58C0", VA = "0x1837B6CC0")]
	public IJPLJLEDGFA(FLLPKEMOJMA<T> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3E391E0", Offset = "0x3E37DE0", VA = "0x183E391E0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class IMACFAJBKNP<T> : AJJPDPGLPEH<FLLPKEMOJMA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly HKHNJFNFPLC<T> LKIPBJAEGOJ;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3E742F0", Offset = "0x3E72EF0", VA = "0x183E742F0")]
	public IMACFAJBKNP(T PJIFCLGMLOL, FLLPKEMOJMA<T> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3CC27C0", Offset = "0x3CC13C0", VA = "0x183CC27C0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class CDILHJOBCNO<T> : AJJPDPGLPEH<GNGPAELBOAG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly POHAKADEAMA<T> HIFNONEOKHL;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x51A92C0", Offset = "0x51A7EC0", VA = "0x1851A92C0")]
	public CDILHJOBCNO(T PJIFCLGMLOL, bool DJOCINOAHMA, GNGPAELBOAG<T> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3CC27C0", Offset = "0x3CC13C0", VA = "0x183CC27C0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct EGHHJNBJDAM<TData> where TData : notnull, NJJAPPMKJPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> GNFIIPFHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool FDIAANDPPHP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x37EE9C0", Offset = "0x37ED5C0", VA = "0x1837EE9C0")]
	public EGHHJNBJDAM(IEnumerable<TData> OEBJCCADOMF, bool HHIHMBKGBLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct OFEAGKNBPLJ<TData> where TData : notnull, NJJAPPMKJPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> GNFIIPFHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> FCGNCMNHGPB;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4583180", Offset = "0x4581D80", VA = "0x184583180")]
	public OFEAGKNBPLJ(List<TData> OEBJCCADOMF, List<bool> BIGJEFILLBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface NJJAPPMKJPD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool LGAEBILNCHJ
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
public interface EPCIAGDJEJI<TData> where TData : NJJAPPMKJPD
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLADJOFCMKI([In] EGHHJNBJDAM<TData> EJGHODNNNKP);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLADJOFCMKI([In] OFEAGKNBPLJ<TData> EJGHODNNNKP);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface NHHCDIDPLNN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LIBEHOJLAKJ(T PJIFCLGMLOL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class HEKPDKAPDNB<TData> : AJJPDPGLPEH<EPCIAGDJEJI<TData>> where TData : notnull, NJJAPPMKJPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly EGHHJNBJDAM<TData> EJGHODNNNKP;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3D30770", Offset = "0x3D2F370", VA = "0x183D30770")]
	public HEKPDKAPDNB(List<TData> DFMADHDIPEM, bool FDIAANDPPHP, EPCIAGDJEJI<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3CC27C0", Offset = "0x3CC13C0", VA = "0x183CC27C0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class PCPDGINHHJI<TData> : AJJPDPGLPEH<EPCIAGDJEJI<TData>> where TData : notnull, NJJAPPMKJPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OFEAGKNBPLJ<TData> EJGHODNNNKP;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x46F2B60", Offset = "0x46F1760", VA = "0x1846F2B60")]
	public PCPDGINHHJI(List<TData> DFMADHDIPEM, List<bool> FCGNCMNHGPB, EPCIAGDJEJI<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3C73BD0", Offset = "0x3C727D0", VA = "0x183C73BD0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HLNDOIDLBHA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IMEKCHIMAAN> FLADJOFCMKI(GIKCPBKHCMJ<TData> IKDFKBLBMAG);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class FCHDEHNOAOD<TData> : PALGAFPPMDD<HLNDOIDLBHA<TData>, IMEKCHIMAAN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct KMFCAKFPDKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<IMEKCHIMAAN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public FCHDEHNOAOD<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IMEKCHIMAAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4158A90", Offset = "0x4157690", VA = "0x184158A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4158D70", Offset = "0x4157970", VA = "0x184158D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly GIKCPBKHCMJ<TData> PDAMIKJJDHD;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DF10", Offset = "0x3B7CB10", VA = "0x183B7DF10")]
	public FCHDEHNOAOD(TData JGKDFICHIND, IReadOnlyList<TData> KAIFCILCFGP, bool LLJMLECIEDD, HLNDOIDLBHA<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DE10", Offset = "0x3B7CA10", VA = "0x183B7DE10", Slot = "4")]
	[AsyncStateMachine(typeof(FCHDEHNOAOD<>.KMFCAKFPDKJ))]
	public override Task<IMEKCHIMAAN> FLADJOFCMKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct GIKCPBKHCMJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData LAIEBBHBGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> BPHECNJAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool GOAAPNJAGON;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3CA6280", Offset = "0x3CA4E80", VA = "0x183CA6280")]
	public GIKCPBKHCMJ(TData JGKDFICHIND, IReadOnlyList<TData> KAIFCILCFGP, bool LLJMLECIEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface IKGNKNDIDOI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLADJOFCMKI([In] MCANEMAMPBA<TData> NKGIBLKGKFG);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface JOJFFFCKAIF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLADJOFCMKI([In] JIOIOBCNJOC<TData> NKGIBLKGKFG);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface HAAGMFMIHPI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FCABEPCAPKJ([In] KFNDOOBJEJC<TData> NKGIBLKGKFG);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFLJPONDNGE();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class CAEFOLGDKCJ<TData> : AJJPDPGLPEH<IKGNKNDIDOI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly MCANEMAMPBA<TData> NKGIBLKGKFG;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x50C05D0", Offset = "0x50BF1D0", VA = "0x1850C05D0")]
	public CAEFOLGDKCJ(IEnumerable<TData> DFMADHDIPEM, IEKJABEGPBP BFOBNFFGJIL, NLGCJIKDINI MBCOMNNFJFG, float FEGFKMKOKJI, bool LLJMLECIEDD, IKGNKNDIDOI<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3CC27C0", Offset = "0x3CC13C0", VA = "0x183CC27C0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NCFNJFKOJON<TData> : AJJPDPGLPEH<JOJFFFCKAIF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly JIOIOBCNJOC<TData> NKGIBLKGKFG;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4481CD0", Offset = "0x44808D0", VA = "0x184481CD0")]
	public NCFNJFKOJON(TData[] DFMADHDIPEM, IEKJABEGPBP[] BFOBNFFGJIL, NLGCJIKDINI[] MBCOMNNFJFG, float[] FEGFKMKOKJI, JOJFFFCKAIF<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4481C10", Offset = "0x4480810", VA = "0x184481C10", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class GPFFDMGEAFA<TData> : AJJPDPGLPEH<HAAGMFMIHPI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x37B6CC0", Offset = "0x37B58C0", VA = "0x1837B6CC0")]
	public GPFFDMGEAFA(HAAGMFMIHPI<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7680", Offset = "0x3CE6280", VA = "0x183CE7680", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class CPELNLAEBNA<TData> : AJJPDPGLPEH<HAAGMFMIHPI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly KFNDOOBJEJC<TData> NKGIBLKGKFG;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x545FE90", Offset = "0x545EA90", VA = "0x18545FE90")]
	public CPELNLAEBNA(IEnumerable<TData> DFMADHDIPEM, IEKJABEGPBP BFOBNFFGJIL, NLGCJIKDINI MBCOMNNFJFG, float FEGFKMKOKJI, HAAGMFMIHPI<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4481C10", Offset = "0x4480810", VA = "0x184481C10", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct MCANEMAMPBA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> GNFIIPFHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public IEKJABEGPBP IFLIDIAMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public NLGCJIKDINI AFDBCPGONJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float FEGFKMKOKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool LLJMLECIEDD;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x43E4850", Offset = "0x43E3450", VA = "0x1843E4850")]
	public MCANEMAMPBA(IEnumerable<TData> DFMADHDIPEM, IEKJABEGPBP BFOBNFFGJIL, NLGCJIKDINI MBCOMNNFJFG, float FEGFKMKOKJI, bool LLJMLECIEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct JIOIOBCNJOC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] GNFIIPFHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public IEKJABEGPBP[] IFLIDIAMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NLGCJIKDINI[] AFDBCPGONJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] FEGFKMKOKJI;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4063CE0", Offset = "0x40628E0", VA = "0x184063CE0")]
	public JIOIOBCNJOC(TData[] DFMADHDIPEM, IEKJABEGPBP[] BFOBNFFGJIL, NLGCJIKDINI[] MBCOMNNFJFG, float[] FEGFKMKOKJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct KFNDOOBJEJC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> GNFIIPFHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public IEKJABEGPBP IFLIDIAMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NLGCJIKDINI AFDBCPGONJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float FEGFKMKOKJI;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x414A210", Offset = "0x4148E10", VA = "0x18414A210")]
	public KFNDOOBJEJC(IEnumerable<TData> DFMADHDIPEM, IEKJABEGPBP BFOBNFFGJIL, NLGCJIKDINI MBCOMNNFJFG, float FEGFKMKOKJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface JFFGLINEGEC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KAFGMCBGADI([In] JPGLFKBAAKB<TData> KHBJDPNHBLM);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPANGMIEMKP([In] JPGLFKBAAKB<TData> KHBJDPNHBLM);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GPAPCCCNIFG([In] bool OJHONLCJNDP);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MBNIPPDAMJH([In] JPGLFKBAAKB<TData> KHBJDPNHBLM);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PFGOEAMJDPC();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HJOAGMPDPKF([In] TData MKHOGPICHAE);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class ACOOFEJCJMD<TData> : AJJPDPGLPEH<JFFGLINEGEC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly JPGLFKBAAKB<TData> KHBJDPNHBLM;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2880", Offset = "0x3CC1480", VA = "0x183CC2880")]
	public ACOOFEJCJMD(List<TData> PLHBCCDAKBC, JFFGLINEGEC<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3CC27C0", Offset = "0x3CC13C0", VA = "0x183CC27C0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class EEFAPOEFNHK<TData> : AJJPDPGLPEH<JFFGLINEGEC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x37B6CC0", Offset = "0x37B58C0", VA = "0x1837B6CC0")]
	public EEFAPOEFNHK(JFFGLINEGEC<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x37B6C70", Offset = "0x37B5870", VA = "0x1837B6C70", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class CGMJMDLEDLJ<TData> : AJJPDPGLPEH<JFFGLINEGEC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool LLJMLECIEDD;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x51B4730", Offset = "0x51B3330", VA = "0x1851B4730")]
	public CGMJMDLEDLJ(bool LLJMLECIEDD, JFFGLINEGEC<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x51B46D0", Offset = "0x51B32D0", VA = "0x1851B46D0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class GEBNPMFIPKL<TData> : AJJPDPGLPEH<JFFGLINEGEC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly JPGLFKBAAKB<TData> KHBJDPNHBLM;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3C73C90", Offset = "0x3C72890", VA = "0x183C73C90")]
	public GEBNPMFIPKL(List<TData> PLHBCCDAKBC, bool LLJMLECIEDD, JFFGLINEGEC<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3C73BD0", Offset = "0x3C727D0", VA = "0x183C73BD0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class HBCIFFFFDHK<TData> : AJJPDPGLPEH<JFFGLINEGEC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData MKHOGPICHAE;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3D0F540", Offset = "0x3D0E140", VA = "0x183D0F540")]
	public HBCIFFFFDHK(TData MKHOGPICHAE, JFFGLINEGEC<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3D0F480", Offset = "0x3D0E080", VA = "0x183D0F480", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GBFGGMCJCMF<TData> : AJJPDPGLPEH<JFFGLINEGEC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly JPGLFKBAAKB<TData> KHBJDPNHBLM;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3C703C0", Offset = "0x3C6EFC0", VA = "0x183C703C0")]
	public GBFGGMCJCMF(IEnumerable<TData> PLHBCCDAKBC, JFFGLINEGEC<TData> PPFPKNPFHFN, bool LLJMLECIEDD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3C70300", Offset = "0x3C6EF00", VA = "0x183C70300", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct JPGLFKBAAKB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> GNFIIPFHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool LLJMLECIEDD;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4079D80", Offset = "0x4078980", VA = "0x184079D80")]
	public JPGLFKBAAKB(IEnumerable<TData> OEBJCCADOMF, bool GCMIBNGJOFN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface DNOPEPKCKGO
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IMEKCHIMAAN> FLADJOFCMKI(DIAHGPIFGPE MDPNHBHKAEP);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class LGOKIMNLFHH : PALGAFPPMDD<DNOPEPKCKGO, IMEKCHIMAAN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct EJKCCIPCEBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<IMEKCHIMAAN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public LGOKIMNLFHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<IMEKCHIMAAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6910B30", Offset = "0x690F730", VA = "0x186910B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6910DB0", Offset = "0x690F9B0", VA = "0x186910DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DIAHGPIFGPE OFBLCKMIIJI;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6911520", Offset = "0x6910120", VA = "0x186911520")]
	public LGOKIMNLFHH(bool LLJMLECIEDD, DNOPEPKCKGO PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6911430", Offset = "0x6910030", VA = "0x186911430", Slot = "4")]
	[AsyncStateMachine(typeof(EJKCCIPCEBP))]
	public override Task<IMEKCHIMAAN> FLADJOFCMKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct DIAHGPIFGPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool GOAAPNJAGON;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xE21B70", Offset = "0xE20770", VA = "0x180E21B70")]
	public DIAHGPIFGPE(bool LLJMLECIEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct FJNNPLLBJND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool HLIPMIHPOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool BFCFDACCNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool IADPMFLONGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool LLJMLECIEDD;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4C98290", Offset = "0x4C96E90", VA = "0x184C98290")]
	public FJNNPLLBJND(bool HLIPMIHPOLP, bool BFCFDACCNPH, bool IADPMFLONGE, bool LLJMLECIEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6910EA0", Offset = "0x690FAA0", VA = "0x186910EA0")]
	public FJNNPLLBJND(bool BFCFDACCNPH, bool LLJMLECIEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface PPFLGDGFMAG
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KODFNOBOFMJ(FJNNPLLBJND AALEKBHMIOD);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IPGPJLJIEMA(FJNNPLLBJND AALEKBHMIOD);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class LFCFELBIEGA : AJJPDPGLPEH<PPFLGDGFMAG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly FJNNPLLBJND AALEKBHMIOD;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x69113A0", Offset = "0x690FFA0", VA = "0x1869113A0")]
	public LFCFELBIEGA(bool KHIOEALLADK, bool BFCFDACCNPH, bool IADPMFLONGE, bool LLJMLECIEDD, PPFLGDGFMAG PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6911350", Offset = "0x690FF50", VA = "0x186911350", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class GFINFBEEELN : AJJPDPGLPEH<PPFLGDGFMAG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly FJNNPLLBJND AALEKBHMIOD;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6910F00", Offset = "0x690FB00", VA = "0x186910F00")]
	public GFINFBEEELN(bool BFCFDACCNPH, bool LLJMLECIEDD, PPFLGDGFMAG PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6910EB0", Offset = "0x690FAB0", VA = "0x186910EB0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface EKDODIPLGKL
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLADJOFCMKI([In] ODMGBJJDNFO BIIJCJDCCOF);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class MJOBPINPJHH : AJJPDPGLPEH<EKDODIPLGKL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly ODMGBJJDNFO BIIJCJDCCOF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6911630", Offset = "0x6910230", VA = "0x186911630")]
	public MJOBPINPJHH(Guid[] BJJEPEKGCBL, Vector3[] AEDMAPHFDAE, Quaternion[] ADFAGBPLNEG, float[] LOFHDKOFNNA, Dictionary<Guid, Vector3> KPADLEDBLBJ, EKDODIPLGKL PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6911580", Offset = "0x6910180", VA = "0x186911580", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface BGACDFDELLP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEACFDGPOID([In] LGOLBJFGIGH<TData> PEEFMEIFFLK);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FCABEPCAPKJ([In] JEAILLJOFPP PKKCOFKCMEJ);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FCABEPCAPKJ([In] EJNOOOMNCID PKKCOFKCMEJ);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EFLJPONDNGE();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KIEIMAPCFMD<TData> : AJJPDPGLPEH<BGACDFDELLP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x37B6CC0", Offset = "0x37B58C0", VA = "0x1837B6CC0")]
	public KIEIMAPCFMD(BGACDFDELLP<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4151740", Offset = "0x4150340", VA = "0x184151740", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class HFFOHKDHJIL<TData> : AJJPDPGLPEH<BGACDFDELLP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly JEAILLJOFPP EFNHCEOMIAN;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3D33530", Offset = "0x3D32130", VA = "0x183D33530")]
	public HFFOHKDHJIL(Vector3 NCMHABILAFB, bool BLNHBMFIILE, BGACDFDELLP<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x37ED240", Offset = "0x37EBE40", VA = "0x1837ED240", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class OOPNBPFIDPE<TData> : AJJPDPGLPEH<BGACDFDELLP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly EJNOOOMNCID EFNHCEOMIAN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4655B00", Offset = "0x4654700", VA = "0x184655B00")]
	public OOPNBPFIDPE(Guid DADKJJFACFK, int OPDMGNJCACB, Vector3 DFPHDEDIHFK, Quaternion DELGPMLKBMI, float HNLLDLBIGBG, bool BLNHBMFIILE, BGACDFDELLP<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4655AA0", Offset = "0x46546A0", VA = "0x184655AA0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class CKDNJBBLGGD<TData> : AJJPDPGLPEH<BGACDFDELLP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly LGOLBJFGIGH<TData> EFNHCEOMIAN;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x529C690", Offset = "0x529B290", VA = "0x18529C690")]
	public CKDNJBBLGGD(TData PJIFCLGMLOL, bool LLJMLECIEDD, BGACDFDELLP<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3CC27C0", Offset = "0x3CC13C0", VA = "0x183CC27C0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct JEAILLJOFPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 NCMHABILAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool BLNHBMFIILE;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6911310", Offset = "0x690FF10", VA = "0x186911310")]
	public JEAILLJOFPP(Vector3 NCMHABILAFB, bool BLNHBMFIILE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct EJNOOOMNCID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid DADKJJFACFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int OPDMGNJCACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 DFPHDEDIHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion DELGPMLKBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float HNLLDLBIGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool BLNHBMFIILE;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6910E20", Offset = "0x690FA20", VA = "0x186910E20")]
	public EJNOOOMNCID(Guid DADKJJFACFK, int OPDMGNJCACB, Vector3 DFPHDEDIHFK, Quaternion DELGPMLKBMI, float HNLLDLBIGBG, bool BLNHBMFIILE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct LGOLBJFGIGH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData PJIFCLGMLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool LLJMLECIEDD;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x41FD410", Offset = "0x41FC010", VA = "0x1841FD410")]
	public LGOLBJFGIGH(TData PJIFCLGMLOL, bool LLJMLECIEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface DGLAGJECGFO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLADJOFCMKI([In] MDEKDPIDHDI<TData> BAFIPKLCEMF);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FLADJOFCMKI([In] HGNKNOLJDBN<TData> BAFIPKLCEMF);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface IHLAFELJLFG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEACFDGPOID([In] AJACFJLBFFI<TData> BMHIOLIDNAI);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FCABEPCAPKJ([In] DFMIBNCIOBN PKKCOFKCMEJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EFLJPONDNGE();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class IJDLJDEKFKM<TData> : AJJPDPGLPEH<DGLAGJECGFO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MDEKDPIDHDI<TData> BAFIPKLCEMF;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3E35BC0", Offset = "0x3E347C0", VA = "0x183E35BC0")]
	public IJDLJDEKFKM(IEnumerable<TData> DFMADHDIPEM, Vector3 NGPCEGOMKCF, bool LLJMLECIEDD, DGLAGJECGFO<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3CC27C0", Offset = "0x3CC13C0", VA = "0x183CC27C0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class GADMFKNLGEK<TData> : AJJPDPGLPEH<IHLAFELJLFG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x37B6CC0", Offset = "0x37B58C0", VA = "0x1837B6CC0")]
	public GADMFKNLGEK(IHLAFELJLFG<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3C684C0", Offset = "0x3C670C0", VA = "0x183C684C0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class JHLFDEOFHAH<TData> : AJJPDPGLPEH<IHLAFELJLFG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly AJACFJLBFFI<TData> BAFIPKLCEMF;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4063480", Offset = "0x4062080", VA = "0x184063480")]
	public JHLFDEOFHAH(IEnumerable<TData> DFMADHDIPEM, bool LLJMLECIEDD, IHLAFELJLFG<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3CC27C0", Offset = "0x3CC13C0", VA = "0x183CC27C0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JEKIJDJFIPM<TData> : AJJPDPGLPEH<DGLAGJECGFO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly HGNKNOLJDBN<TData> BAFIPKLCEMF;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x401F280", Offset = "0x401DE80", VA = "0x18401F280")]
	public JEKIJDJFIPM(IEnumerable<TData> DFMADHDIPEM, Vector3 HNGGHJHJPOC, OGLJGMPEODO JGOJGPKNGLG, bool LLJMLECIEDD, DGLAGJECGFO<TData> PPFPKNPFHFN, Space MLPKAHBKLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3CE76D0", Offset = "0x3CE62D0", VA = "0x183CE76D0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class EFMFJMCJMEI<TData> : AJJPDPGLPEH<IHLAFELJLFG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly DFMIBNCIOBN BAFIPKLCEMF;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x37ED2A0", Offset = "0x37EBEA0", VA = "0x1837ED2A0")]
	public EFMFJMCJMEI(Vector3 NGPCEGOMKCF, IHLAFELJLFG<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x37ED240", Offset = "0x37EBE40", VA = "0x1837ED240", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct MDEKDPIDHDI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> DFMADHDIPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 NGPCEGOMKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool LLJMLECIEDD;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x43E6DC0", Offset = "0x43E59C0", VA = "0x1843E6DC0")]
	public MDEKDPIDHDI(IEnumerable<TData> DFMADHDIPEM, Vector3 NGPCEGOMKCF, bool LLJMLECIEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct AJACFJLBFFI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> DFMADHDIPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool LLJMLECIEDD;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3DD19F0", Offset = "0x3DD05F0", VA = "0x183DD19F0")]
	public AJACFJLBFFI(IEnumerable<TData> DFMADHDIPEM, bool LLJMLECIEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct HGNKNOLJDBN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> DFMADHDIPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 HNGGHJHJPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly OGLJGMPEODO JGOJGPKNGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool LLJMLECIEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space MLPKAHBKLFJ;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3D3DB60", Offset = "0x3D3C760", VA = "0x183D3DB60")]
	public HGNKNOLJDBN(IEnumerable<TData> DFMADHDIPEM, Vector3 HNGGHJHJPOC, OGLJGMPEODO JGOJGPKNGLG, bool LLJMLECIEDD, Space MLPKAHBKLFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct DFMIBNCIOBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 NGPCEGOMKCF;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x21468D0", Offset = "0x21454D0", VA = "0x1821468D0")]
	public DFMIBNCIOBN(Vector3 NGPCEGOMKCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum OGLJGMPEODO
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface MAAPNAGCFED
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLADJOFCMKI([In] HHIBGEAIIKD MHPJGFJANPA);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class AEAANDKCJLI : AJJPDPGLPEH<MAAPNAGCFED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly HHIBGEAIIKD MHPJGFJANPA;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6910AB0", Offset = "0x690F6B0", VA = "0x186910AB0")]
	public AEAANDKCJLI(bool LLJMLECIEDD, MAAPNAGCFED PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6910A00", Offset = "0x690F600", VA = "0x186910A00", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct HHIBGEAIIKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool LLJMLECIEDD;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xE21B70", Offset = "0xE20770", VA = "0x180E21B70")]
	public HHIBGEAIIKD(bool LLJMLECIEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface BOCONGJKBCH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLADJOFCMKI([In] DJKPJMAMJHI<TData> ECAAPFOPJNK);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FLADJOFCMKI([In] FKMPCHPGMID<TData> ECAAPFOPJNK);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface LGFAFAAEKPD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEACFDGPOID([In] LHHOMHDDMJK<TData> PEEFMEIFFLK);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FCABEPCAPKJ([In] IDJGGFONIBE PKKCOFKCMEJ);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EFLJPONDNGE();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class DMJKOHKIPGE<TData> : AJJPDPGLPEH<BOCONGJKBCH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly DJKPJMAMJHI<TData> ECAAPFOPJNK;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x57F3470", Offset = "0x57F2070", VA = "0x1857F3470")]
	public DMJKOHKIPGE(IEnumerable<TData> DFMADHDIPEM, Quaternion NGPCEGOMKCF, Vector3? BCPCKHBDKDJ, bool BIJCNBOHNIK, bool LLJMLECIEDD, BOCONGJKBCH<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3CC27C0", Offset = "0x3CC13C0", VA = "0x183CC27C0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class BCNLLGAGIID<TData> : AJJPDPGLPEH<LGFAFAAEKPD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x37B6CC0", Offset = "0x37B58C0", VA = "0x1837B6CC0")]
	public BCNLLGAGIID(LGFAFAAEKPD<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3C684C0", Offset = "0x3C670C0", VA = "0x183C684C0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class DGFMKNONEIK<TData> : AJJPDPGLPEH<LGFAFAAEKPD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly LHHOMHDDMJK<TData> ECAAPFOPJNK;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x57CEA70", Offset = "0x57CD670", VA = "0x1857CEA70")]
	public DGFMKNONEIK(IEnumerable<TData> DFMADHDIPEM, bool LLJMLECIEDD, LGFAFAAEKPD<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3CC27C0", Offset = "0x3CC13C0", VA = "0x183CC27C0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class GPFKFLGEMLE<TData> : AJJPDPGLPEH<BOCONGJKBCH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly FKMPCHPGMID<TData> ECAAPFOPJNK;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7790", Offset = "0x3CE6390", VA = "0x183CE7790")]
	public GPFKFLGEMLE(IEnumerable<TData> DFMADHDIPEM, Quaternion BGKNPGABJGE, OGLJGMPEODO CPEINFJMFNN, Vector3? BCPCKHBDKDJ, bool BIJCNBOHNIK, bool LLJMLECIEDD, Space MLPKAHBKLFJ, BOCONGJKBCH<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3CE76D0", Offset = "0x3CE62D0", VA = "0x183CE76D0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class HAEGGMGBCKE<TData> : AJJPDPGLPEH<LGFAFAAEKPD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly IDJGGFONIBE ECAAPFOPJNK;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C3D0", Offset = "0x3D0AFD0", VA = "0x183D0C3D0")]
	public HAEGGMGBCKE(Quaternion NGPCEGOMKCF, Vector3? BCPCKHBDKDJ, bool BIJCNBOHNIK, LGFAFAAEKPD<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x37ED240", Offset = "0x37EBE40", VA = "0x1837ED240", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct DJKPJMAMJHI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> DFMADHDIPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion NGPCEGOMKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? BCPCKHBDKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool BIJCNBOHNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool LLJMLECIEDD;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x57DE630", Offset = "0x57DD230", VA = "0x1857DE630")]
	public DJKPJMAMJHI(IEnumerable<TData> DFMADHDIPEM, Quaternion NGPCEGOMKCF, Vector3? BCPCKHBDKDJ, bool BIJCNBOHNIK, bool LLJMLECIEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct LHHOMHDDMJK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> DFMADHDIPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool LLJMLECIEDD;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x42004F0", Offset = "0x41FF0F0", VA = "0x1842004F0")]
	public LHHOMHDDMJK(IEnumerable<TData> DFMADHDIPEM, bool LLJMLECIEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct FKMPCHPGMID<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> DFMADHDIPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion BGKNPGABJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly OGLJGMPEODO CPEINFJMFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? BCPCKHBDKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool BIJCNBOHNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool LLJMLECIEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space MLPKAHBKLFJ;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAC70", Offset = "0x3BA9870", VA = "0x183BAAC70")]
	public FKMPCHPGMID(IEnumerable<TData> DFMADHDIPEM, Quaternion BGKNPGABJGE, OGLJGMPEODO CPEINFJMFNN, Vector3? BCPCKHBDKDJ, bool BIJCNBOHNIK, bool LLJMLECIEDD, Space MLPKAHBKLFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct IDJGGFONIBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion NGPCEGOMKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? BCPCKHBDKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool BIJCNBOHNIK;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4C5D490", Offset = "0x4C5C090", VA = "0x184C5D490")]
	public IDJGGFONIBE(Quaternion NGPCEGOMKCF, Vector3? BCPCKHBDKDJ, bool BIJCNBOHNIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface BNBJLJFFBHE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEACFDGPOID([In] DJGAOBCBNPK<TData> PEEFMEIFFLK);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FCABEPCAPKJ([In] NNPPIICDLDB PKKCOFKCMEJ);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FCABEPCAPKJ([In] KPEKNFIMKAO PKKCOFKCMEJ);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FCABEPCAPKJ([In] FEEBINEJALN PKKCOFKCMEJ);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EFLJPONDNGE();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class HKBICBPNCEI<TData> : AJJPDPGLPEH<BNBJLJFFBHE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly FEEBINEJALN JFNOANNBEIN;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3D54CF0", Offset = "0x3D538F0", VA = "0x183D54CF0")]
	public HKBICBPNCEI(Vector3 MFEGKNHJCIH, float EIHPNDPLKCM, Vector3 BCPCKHBDKDJ, bool LEDKKBLPPPA, bool OKDDMNMFCNK, BNBJLJFFBHE<TData> PPFPKNPFHFN, Space MLPKAHBKLFJ = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3D54C90", Offset = "0x3D53890", VA = "0x183D54C90", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class ODNIKFBPGAL<TData> : AJJPDPGLPEH<BNBJLJFFBHE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x37B6CC0", Offset = "0x37B58C0", VA = "0x1837B6CC0")]
	public ODNIKFBPGAL(BNBJLJFFBHE<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x45764D0", Offset = "0x45750D0", VA = "0x1845764D0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class AMNHEBGCMON<TData> : AJJPDPGLPEH<BNBJLJFFBHE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly DJGAOBCBNPK<TData> JFNOANNBEIN;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3DEC730", Offset = "0x3DEB330", VA = "0x183DEC730")]
	public AMNHEBGCMON(IEnumerable<TData> DFMADHDIPEM, bool LLJMLECIEDD, BNBJLJFFBHE<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3CC27C0", Offset = "0x3CC13C0", VA = "0x183CC27C0", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class LKIDACDNNHA<TData> : AJJPDPGLPEH<BNBJLJFFBHE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly KPEKNFIMKAO JFNOANNBEIN;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4212300", Offset = "0x4210F00", VA = "0x184212300")]
	public LKIDACDNNHA(float LHHHBOHCPFN, bool BMNOLKLIGAM, Vector3 BCPCKHBDKDJ, BNBJLJFFBHE<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4212240", Offset = "0x4210E40", VA = "0x184212240", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class PPMFCLJNHBI<TData> : AJJPDPGLPEH<BNBJLJFFBHE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NNPPIICDLDB JFNOANNBEIN;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4783840", Offset = "0x4782440", VA = "0x184783840")]
	public PPMFCLJNHBI(float EIHPNDPLKCM, Vector3 BCPCKHBDKDJ, BNBJLJFFBHE<TData> PPFPKNPFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x37ED240", Offset = "0x37EBE40", VA = "0x1837ED240", Slot = "4")]
	public override bool FLADJOFCMKI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct FEEBINEJALN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 MFEGKNHJCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float EIHPNDPLKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 BCPCKHBDKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool BLNHBMFIILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space MLPKAHBKLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool OKDDMNMFCNK;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6910E60", Offset = "0x690FA60", VA = "0x186910E60")]
	public FEEBINEJALN(Vector3 MFEGKNHJCIH, float EIHPNDPLKCM, Vector3 BCPCKHBDKDJ, bool BLNHBMFIILE, bool KBMIIJIHNCH, Space MLPKAHBKLFJ = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct DJGAOBCBNPK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> DFMADHDIPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool LLJMLECIEDD;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x57DE000", Offset = "0x57DCC00", VA = "0x1857DE000")]
	public DJGAOBCBNPK(IEnumerable<TData> DFMADHDIPEM, bool LLJMLECIEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct KPEKNFIMKAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float LHHHBOHCPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool BMNOLKLIGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 BCPCKHBDKDJ;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6911330", Offset = "0x690FF30", VA = "0x186911330")]
	public KPEKNFIMKAO(float LHHHBOHCPFN, bool BMNOLKLIGAM, Vector3 BCPCKHBDKDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct NNPPIICDLDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float EIHPNDPLKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 BCPCKHBDKDJ;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4C346E0", Offset = "0x4C332E0", VA = "0x184C346E0")]
	public NNPPIICDLDB(float EIHPNDPLKCM, Vector3 BCPCKHBDKDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct ODMGBJJDNFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] DFMADHDIPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool KAIHAKBCIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool EEPEMJCOGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool KKNFBDFJCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] AEDMAPHFDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] ADFAGBPLNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] LOFHDKOFNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> KPADLEDBLBJ;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6911A60", Offset = "0x6910660", VA = "0x186911A60")]
	public ODMGBJJDNFO(Guid[] BJJEPEKGCBL, Vector3[] AEDMAPHFDAE, Quaternion[] ADFAGBPLNEG, float[] LOFHDKOFNNA, Dictionary<Guid, Vector3> KPADLEDBLBJ, bool KAIHAKBCIHA = true, bool EEPEMJCOGFP = true, bool KKNFBDFJCKD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6911890", Offset = "0x6910490", VA = "0x186911890")]
	private static void HPIFMJFLMKD(Dictionary<Guid, Vector3> KPADLEDBLBJ, int GGOKIHCPDDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class ONCOBEMINEK
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct NCKJFDAEGDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool HAPDGOPAKLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LLIMAHMFNLB AKMPFPHGEOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public LLIMAHMFNLB CHMKJCPIOGA;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static NCKJFDAEGDK NCOEKDAEMIO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken DENFOMHEOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6911CF0", Offset = "0x69108F0", VA = "0x186911CF0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static LLIMAHMFNLB AKMPFPHGEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6911F60", Offset = "0x6910B60", VA = "0x186911F60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6912050", Offset = "0x6910C50", VA = "0x186912050")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6911E60", Offset = "0x6910A60", VA = "0x186911E60")]
	[FJJFAIMPJIC(AMDAGODFNAF.Room, JBEKPLNNIEC.None)]
	private static void CNGOBDBKALM(LLIMAHMFNLB PJPAGDGANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6911D10", Offset = "0x6910910", VA = "0x186911D10")]
	public static void CJMFGDFICPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6912000", Offset = "0x6910C00", VA = "0x186912000")]
	private static LLIMAHMFNLB ENPMOGIHJBG(LLIMAHMFNLB DAIMANBCFHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class EPNIMFJNIJP
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum HICIBCGGOBH
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x29824B0", Offset = "0x29810B0", VA = "0x1829824B0")]
	public static void HFGJPOKCCKA<T>(T HFEGKIPECIL, HICIBCGGOBH NCNNODEFPOG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2982610", Offset = "0x2981210", VA = "0x182982610")]
	public static void HFGJPOKCCKA<T>(T HFEGKIPECIL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2982350", Offset = "0x2980F50", VA = "0x182982350")]
	public static void HBMENFOJHPC<T>(T HFEGKIPECIL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2982400", Offset = "0x2981000", VA = "0x182982400")]
	public static T HCNFCFFAFEI<T>(HICIBCGGOBH NCNNODEFPOG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2982680", Offset = "0x2981280", VA = "0x182982680")]
	public static bool KEKFKPJEKCC<T>(HICIBCGGOBH NCNNODEFPOG, T? PBKBHBHIHKL, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T HEAEPDCAKCB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2982240", Offset = "0x2980E40", VA = "0x182982240")]
	public static bool GJNMDGHINNC<T>(HICIBCGGOBH NCNNODEFPOG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x29822F0", Offset = "0x2980EF0", VA = "0x1829822F0")]
	public static T HCNFCFFAFEI<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x29827D0", Offset = "0x29813D0", VA = "0x1829827D0")]
	public static bool KEKFKPJEKCC<T>(T PBKBHBHIHKL, [Out] T HEAEPDCAKCB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x29822F0", Offset = "0x2980EF0", VA = "0x1829822F0")]
	public static bool GJNMDGHINNC<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class IHAOPFEMKML
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6910F80", Offset = "0x690FB80", VA = "0x186910F80")]
	public static void MNPJJHNELOH(IEnumerable CEOKLKGJMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2B6BA90", Offset = "0x2B6A690", VA = "0x182B6BA90")]
	public static void MNPJJHNELOH<T>(T[] CHPEIOMPEEH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2B6BC70", Offset = "0x2B6A870", VA = "0x182B6BC70")]
	public static void MNPJJHNELOH<T>(T APNFGFBFBNA) where T : notnull, Enum
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
