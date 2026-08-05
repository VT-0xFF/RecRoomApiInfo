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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x618DD80", Offset = "0x618CF80", VA = "0x18618DD80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C40", Offset = "0x7E4E40", VA = "0x1807E5C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5C80", Offset = "0x7E4E80", VA = "0x1807E5C80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GBHMMDEMHJD<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn DBNDKEIIOMO(TData MFLACBLODGN);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EGHLPDBPOPI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(KLKJIPAFEOJ KLALOPDFCGO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData MJBOJGOCOJL, Collider CMBECBBCLEA, KLKJIPAFEOJ KLALOPDFCGO, [Optional] NEDDNDGOEJK? CGBKNHCDOPL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData MJBOJGOCOJL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider CMBECBBCLEA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DABJLFCGJED<TData> : PMBFJENHDJM, HIMBPGLPHBE<TData>, AHFCIGPNNOJ<TData>, BIMILFNLFBL<TData>, HDNKEAFNAGK, FJPOBMFFLBG<TData>, LLLKBFJMLKM, IBIDPNIIOPE
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FJPOBMFFLBG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 PLIBFDJEHAI, Vector3 LFOLBKGLLGP, float IIGADGFPKHC, [Out] T IKPCBJMMKOK, [Out] Vector3 FEHJHHBNHGK, [Out] Collider CMBECBBCLEA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 PLIBFDJEHAI, Vector3 LFOLBKGLLGP, float OAINBONMOEN, float IIGADGFPKHC, T[] FGAKIFFECCD, [Out] Vector3 KKCOCAEHMBM, [Out] Collider NBFEOFJEMBB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 PLIBFDJEHAI, float OAINBONMOEN, Vector3 JGGPFMAIBGK, T[] FGAKIFFECCD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider PLFLKMAOELH, [Out] T EJFIGCKIFNO);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PMBFJENHDJM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds PHLEACJPOCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform JLEAACHHCII
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds KFFIALDAMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform PCGNECFMHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 HGLNAEKDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EOEGBCLLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool MAPBHDHKAIB = true, int IFODBADOMGK = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool BMKJPADMFJE, object COAGHPOILPB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IBIDPNIIOPE
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DIKKIJJDOON MDAOACNKNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DBLPLLBJPHM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GIDNDJAEDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool BFKAHMHALMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MCGDKBOHGJL
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> JCPMPKLAGOH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BIMILFNLFBL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NDEIMFDJCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int KADGJPLBGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> POHPNCJHOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData BCCLIJMKECF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData BCCLIJMKECF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HIMBPGLPHBE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T MFLACBLODGN, [Optional] NEDDNDGOEJK? LDLAEEMJMHF, bool OHECBKGJEGE = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int BNPJLEJJKIB, IEnumerable<T> NCPJLAIJPPJ, bool OHECBKGJEGE = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int BNPJLEJJKIB, IEnumerable<T> NCPJLAIJPPJ, NEDDNDGOEJK LDLAEEMJMHF, bool OHECBKGJEGE = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LLLKBFJMLKM
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HDNKEAFNAGK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HPBAHNMNJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool JLFDBIKMALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool DKAFFDFFIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool DHAIACAPGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class PJCGHODLLLF<TReceiver> : BFGBBGNBDID<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x32DB010", Offset = "0x32DA210", VA = "0x1832DB010")]
	public PJCGHODLLLF(TReceiver CJEFKAMCPLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class DHJKFMNFEMB<TReceiver, TFromTask> : BFGBBGNBDID<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32DB010", Offset = "0x32DA210", VA = "0x1832DB010")]
	public DHJKFMNFEMB(TReceiver CJEFKAMCPLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class BFGBBGNBDID<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver CJEFKAMCPLH;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4796E40", Offset = "0x4796040", VA = "0x184796E40")]
	public BFGBBGNBDID(TReceiver CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute PABGJEDHKFF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class HAEPOFDIOGJ<TReceiver, TResult> : BFGBBGNBDID<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x32DB010", Offset = "0x32DA210", VA = "0x1832DB010")]
	public HAEPOFDIOGJ(TReceiver CJEFKAMCPLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct OLFGNFDEKMO<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup NNHKEEPNBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData JOBPOGKGBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> MNOOMIJBBPF;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1AED9E0", Offset = "0x1AECBE0", VA = "0x181AED9E0")]
	public OLFGNFDEKMO(TGroup CBBJAKFMBPI, TData LJEIPPBEOJD, IEnumerable<TData> DEHNHNLLKOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct IMEJBHJFAID<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup NNHKEEPNBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> MNOOMIJBBPF;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x90CFA0", Offset = "0x90C1A0", VA = "0x18090CFA0")]
	public IMEJBHJFAID(TGroup CBBJAKFMBPI, IEnumerable<TData> DEHNHNLLKOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ADHNDCJFFEH<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup NNHKEEPNBKL;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x947980", Offset = "0x946B80", VA = "0x180947980")]
	public ADHNDCJFFEH(TGroup CBBJAKFMBPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FBFPPCLJKGI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> MNOOMIJBBPF;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x947980", Offset = "0x946B80", VA = "0x180947980")]
	public FBFPPCLJKGI(IEnumerable<TData> DEHNHNLLKOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NKFPOAMFFJB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGFCHIANHLN KCAPLIHJDBF(OLFGNFDEKMO<TGroup, TData> DBDIEJLBCNC);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FGFCHIANHLN HCJODCIHIGM(OLFGNFDEKMO<TGroup, TData> DBDIEJLBCNC);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FGFCHIANHLN OGNKPILCBGD(IMEJBHJFAID<TGroup, TData> DBDIEJLBCNC);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FGFCHIANHLN LJAGHEOAJNF(ADHNDCJFFEH<TGroup> DBDIEJLBCNC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DMPMEDOIKPF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FGFCHIANHLN> KCAPLIHJDBF(FBFPPCLJKGI<TData> DBDIEJLBCNC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GACICJOIKFN<TGroup, TData> : HAEPOFDIOGJ<NKFPOAMFFJB<TGroup, TData>, FGFCHIANHLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly IMEJBHJFAID<TGroup, TData> DBDIEJLBCNC;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3723620", Offset = "0x3722820", VA = "0x183723620")]
	public GACICJOIKFN(TGroup CBBJAKFMBPI, IEnumerable<TData> DEHNHNLLKOD, NKFPOAMFFJB<TGroup, TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3723550", Offset = "0x3722750", VA = "0x183723550", Slot = "4")]
	public override FGFCHIANHLN PABGJEDHKFF()
	{
		return default(FGFCHIANHLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EKNJMOGJBEP<TGroup, TData> : HAEPOFDIOGJ<NKFPOAMFFJB<TGroup, TData>, FGFCHIANHLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly OLFGNFDEKMO<TGroup, TData> DBDIEJLBCNC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x32C37C0", Offset = "0x32C29C0", VA = "0x1832C37C0")]
	public EKNJMOGJBEP(TGroup CBBJAKFMBPI, TData AMDLGFCBBGJ, IEnumerable<TData> DEHNHNLLKOD, NKFPOAMFFJB<TGroup, TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x32C36E0", Offset = "0x32C28E0", VA = "0x1832C36E0", Slot = "4")]
	public override FGFCHIANHLN PABGJEDHKFF()
	{
		return default(FGFCHIANHLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NECNGPJCJAG<TGroup, TData> : HAEPOFDIOGJ<NKFPOAMFFJB<TGroup, TData>, FGFCHIANHLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly ADHNDCJFFEH<TGroup> DBDIEJLBCNC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x379E6E0", Offset = "0x379D8E0", VA = "0x18379E6E0")]
	public NECNGPJCJAG(TGroup CBBJAKFMBPI, NKFPOAMFFJB<TGroup, TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3F1A0A0", Offset = "0x3F192A0", VA = "0x183F1A0A0", Slot = "4")]
	public override FGFCHIANHLN PABGJEDHKFF()
	{
		return default(FGFCHIANHLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KEPMAFOJGMD<TGroup, TData> : HAEPOFDIOGJ<NKFPOAMFFJB<TGroup, TData>, FGFCHIANHLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OLFGNFDEKMO<TGroup, TData> DBDIEJLBCNC;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x32C37C0", Offset = "0x32C29C0", VA = "0x1832C37C0")]
	public KEPMAFOJGMD(TGroup CBBJAKFMBPI, TData LJEIPPBEOJD, IEnumerable<TData> DEHNHNLLKOD, NKFPOAMFFJB<TGroup, TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D6F0", Offset = "0x3B4C8F0", VA = "0x183B4D6F0", Slot = "4")]
	public override FGFCHIANHLN PABGJEDHKFF()
	{
		return default(FGFCHIANHLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MJPCBADMMPO<TData> : DHJKFMNFEMB<DMPMEDOIKPF<TData>, FGFCHIANHLN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct AIJPPBNNGLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<FGFCHIANHLN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public MJPCBADMMPO<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<FGFCHIANHLN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x37A5370", Offset = "0x37A4570", VA = "0x1837A5370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x37A5610", Offset = "0x37A4810", VA = "0x1837A5610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private FBFPPCLJKGI<TData> DBDIEJLBCNC;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x379E6E0", Offset = "0x379D8E0", VA = "0x18379E6E0")]
	public MJPCBADMMPO(IEnumerable<TData> AOIILOMODPI, DMPMEDOIKPF<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E7AEE0", Offset = "0x3E7A0E0", VA = "0x183E7AEE0", Slot = "4")]
	[AsyncStateMachine(typeof(MJPCBADMMPO<>.AIJPPBNNGLD))]
	public override Task<FGFCHIANHLN> PABGJEDHKFF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct JKABOCGANEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly ILJGNGFHPKB KPNGODPDAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool JCANICNIPIF;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x618D990", Offset = "0x618CB90", VA = "0x18618D990")]
	public JKABOCGANEP(ILJGNGFHPKB DMPFCMGODBN, bool BEECMAJNHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface GFKNEMNJPGP<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> PABGJEDHKFF(JKABOCGANEP LEMBEOMMNIH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OKDHNBFNCCB<TSpawnType> : DHJKFMNFEMB<GFKNEMNJPGP<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct EIANAHNGAMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public OKDHNBFNCCB<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x32B9490", Offset = "0x32B8690", VA = "0x1832B9490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x32B9C50", Offset = "0x32B8E50", VA = "0x1832B9C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly JKABOCGANEP LEMBEOMMNIH;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4077380", Offset = "0x4076580", VA = "0x184077380")]
	public OKDHNBFNCCB(ILJGNGFHPKB DMPFCMGODBN, bool BEECMAJNHBN, GFKNEMNJPGP<TSpawnType> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4077180", Offset = "0x4076380", VA = "0x184077180", Slot = "4")]
	[AsyncStateMachine(typeof(OKDHNBFNCCB<>.EIANAHNGAMP))]
	public override Task<TSpawnType> PABGJEDHKFF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct ILJGNGFHPKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool BLHMEEPNJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 JPFFAFOAGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 PNLEOOLJLEF;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x618D910", Offset = "0x618CB10", VA = "0x18618D910")]
	public ILJGNGFHPKB(Transform PHELEHNHLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x618D850", Offset = "0x618CA50", VA = "0x18618D850")]
	public ILJGNGFHPKB(Vector3 NNFMJLGEBBE, Vector3 HBEJPCPOKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x618D820", Offset = "0x618CA20", VA = "0x18618D820")]
	public static ILJGNGFHPKB OIJLLNDPLBD()
	{
		return default(ILJGNGFHPKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x618D880", Offset = "0x618CA80", VA = "0x18618D880")]
	private ILJGNGFHPKB(bool KBDHECDFJDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct AAJHMPHOICG<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode DLDJIJGKOEG;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x36F01B0", Offset = "0x36EF3B0", VA = "0x1836F01B0")]
	public AAJHMPHOICG(TNode DLDJIJGKOEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct IGMCDNPLNOD<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode AOFNPPJAMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public CCFMIBLDBKE OHJLMNLFIEK;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3895700", Offset = "0x3894900", VA = "0x183895700")]
	public IGMCDNPLNOD(TNode AOFNPPJAMCG, CCFMIBLDBKE OHJLMNLFIEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BBPIBJIAMKG<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOKJLONIOCA([In] AAJHMPHOICG<TNode> CGNJECLHADB);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PDGKFKJNNNG([In] IGMCDNPLNOD<TNode> PEGDHFEPLBA);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NHDMCPCOCLD();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class JPGDNCBAFDI<TNode> : PJCGHODLLLF<BBPIBJIAMKG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x32DB010", Offset = "0x32DA210", VA = "0x1832DB010")]
	public JPGDNCBAFDI(BBPIBJIAMKG<TNode> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x38B3BF0", Offset = "0x38B2DF0", VA = "0x1838B3BF0", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HDCJBMBICCM<TNode> : PJCGHODLLLF<BBPIBJIAMKG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IGMCDNPLNOD<TNode> PEGDHFEPLBA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x37BFAC0", Offset = "0x37BECC0", VA = "0x1837BFAC0")]
	public HDCJBMBICCM(TNode AOFNPPJAMCG, CCFMIBLDBKE OHJLMNLFIEK, BBPIBJIAMKG<TNode> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3790520", Offset = "0x378F720", VA = "0x183790520", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class FKJLHMJJOMC<TNode> : PJCGHODLLLF<BBPIBJIAMKG<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly AAJHMPHOICG<TNode> CGNJECLHADB;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3653B50", Offset = "0x3652D50", VA = "0x183653B50")]
	public FKJLHMJJOMC(TNode KPIDMGBJMCL, BBPIBJIAMKG<TNode> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E80", Offset = "0x32D1080", VA = "0x1832D1E80", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct FNOOFNIGMEC<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo ABENENHICHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 HBEJPCPOKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion KIIONLKEIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float LNFDMKEIMFC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x366B900", Offset = "0x366AB00", VA = "0x18366B900")]
	public FNOOFNIGMEC(TSpawnInfo ABENENHICHP, Vector3 HBEJPCPOKJI, Quaternion KIIONLKEIBO, float LNFDMKEIMFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GCAJGPJCAFH<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> HLIHKEBPNEM([In] FNOOFNIGMEC<TSpawnInfo> IDDGACLILJG, CancellationToken OBNOJDAGGOE);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class FMKBDLDAMCG<TSpawnType, TSpawnInfo> : DHJKFMNFEMB<GCAJGPJCAFH<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly FNOOFNIGMEC<TSpawnInfo> KFIENCBOEKJ;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3666480", Offset = "0x3665680", VA = "0x183666480")]
	public FMKBDLDAMCG(TSpawnInfo CFACAINLKGG, Vector3 HBEJPCPOKJI, Quaternion KIIONLKEIBO, float LNFDMKEIMFC, GCAJGPJCAFH<TSpawnType, TSpawnInfo> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x36662A0", Offset = "0x36654A0", VA = "0x1836662A0", Slot = "4")]
	public override Task<TSpawnType> PABGJEDHKFF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct BAGJPJBPBGJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> MNOOMIJBBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool JCANICNIPIF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4779A60", Offset = "0x4778C60", VA = "0x184779A60")]
	public BAGJPJBPBGJ(IEnumerable<TData> DEHNHNLLKOD, bool BEECMAJNHBN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KLBEBGPEJAP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FGFCHIANHLN> AIILPKLEIAG([In] BAGJPJBPBGJ<TData> EJMDDNHFHDD, CancellationToken OBNOJDAGGOE);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class ABMNFMGEAJB<TData> : DHJKFMNFEMB<KLBEBGPEJAP<TData>, FGFCHIANHLN> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BAGJPJBPBGJ<TData> KPAPNDCPKMN;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x37055D0", Offset = "0x37047D0", VA = "0x1837055D0")]
	public ABMNFMGEAJB(IEnumerable<TData> DEHNHNLLKOD, bool BEECMAJNHBN, KLBEBGPEJAP<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x36662A0", Offset = "0x36654A0", VA = "0x1836662A0", Slot = "4")]
	public override Task<FGFCHIANHLN> PABGJEDHKFF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct NBOOJJGOPDB<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T MJBOJGOCOJL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x32DA520", Offset = "0x32D9720", VA = "0x1832DA520")]
	public NBOOJJGOPDB(T HLDDKBDABFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface HICFKIFOJHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOKJLONIOCA([In] NBOOJJGOPDB<T> ELFCIOBGDAN);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PDGKFKJNNNG();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface KBIFLAHAHEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PABGJEDHKFF([In] LOIAPJLFFHA<T> AGOODLDICCA);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct LOIAPJLFFHA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T MJBOJGOCOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool KMHABIGEIMM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3CA6FF0", Offset = "0x3CA61F0", VA = "0x183CA6FF0")]
	public LOIAPJLFFHA(T HLDDKBDABFB, bool AFHPJEDJFDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class BKFOLLGNIJN<T> : PJCGHODLLLF<HICFKIFOJHL<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x32DB010", Offset = "0x32DA210", VA = "0x1832DB010")]
	public BKFOLLGNIJN(HICFKIFOJHL<T> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x47AEA10", Offset = "0x47ADC10", VA = "0x1847AEA10", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class HCIAPKBGFIL<T> : PJCGHODLLLF<HICFKIFOJHL<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly NBOOJJGOPDB<T> ELFCIOBGDAN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x379E660", Offset = "0x379D860", VA = "0x18379E660")]
	public HCIAPKBGFIL(T MJBOJGOCOJL, HICFKIFOJHL<T> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E80", Offset = "0x32D1080", VA = "0x1832D1E80", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class NEIGIDKOKCE<T> : PJCGHODLLLF<KBIFLAHAHEH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly LOIAPJLFFHA<T> AGOODLDICCA;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3F1B7D0", Offset = "0x3F1A9D0", VA = "0x183F1B7D0")]
	public NEIGIDKOKCE(T MJBOJGOCOJL, bool AFHPJEDJFDN, KBIFLAHAHEH<T> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E80", Offset = "0x32D1080", VA = "0x1832D1E80", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct GOHHHCDNFOP<TData> where TData : notnull, MHDKPFNMEEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> MNOOMIJBBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool EHHFNCCPCBG;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3766360", Offset = "0x3765560", VA = "0x183766360")]
	public GOHHHCDNFOP(IEnumerable<TData> INEOOJPMNIF, bool MFCMIPHOJDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct BJIKDLPDMPH<TData> where TData : notnull, MHDKPFNMEEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> MNOOMIJBBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> JBLHALNBJAK;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x47AD730", Offset = "0x47AC930", VA = "0x1847AD730")]
	public BJIKDLPDMPH(List<TData> INEOOJPMNIF, List<bool> OGBBFFDAHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface MHDKPFNMEEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool PDJBJFGJHNN
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
public interface KCGJDLNPKCN<TData> where TData : MHDKPFNMEEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PABGJEDHKFF([In] GOHHHCDNFOP<TData> MEBOADBFMHJ);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PABGJEDHKFF([In] BJIKDLPDMPH<TData> MEBOADBFMHJ);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface LMFMDKOJDNK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IPJLNJOKGEN(T MJBOJGOCOJL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class JDCFADNLMHK<TData> : PJCGHODLLLF<KCGJDLNPKCN<TData>> where TData : notnull, MHDKPFNMEEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly GOHHHCDNFOP<TData> MEBOADBFMHJ;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3A70270", Offset = "0x3A6F470", VA = "0x183A70270")]
	public JDCFADNLMHK(List<TData> DEHNHNLLKOD, bool EHHFNCCPCBG, KCGJDLNPKCN<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E80", Offset = "0x32D1080", VA = "0x1832D1E80", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class HGNDHHOMFIC<TData> : PJCGHODLLLF<KCGJDLNPKCN<TData>> where TData : notnull, MHDKPFNMEEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly BJIKDLPDMPH<TData> MEBOADBFMHJ;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x37EDC00", Offset = "0x37ECE00", VA = "0x1837EDC00")]
	public HGNDHHOMFIC(List<TData> DEHNHNLLKOD, List<bool> JBLHALNBJAK, KCGJDLNPKCN<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x37EDB40", Offset = "0x37ECD40", VA = "0x1837EDB40", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface IIGEJHJHHGG : MHDKPFNMEEJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface HFECJPDMPOJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FGFCHIANHLN> PABGJEDHKFF(KHGBFFHOKPP<TData> ACGKKJEDLAG);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class OALKPNAMBCC<TData> : DHJKFMNFEMB<HFECJPDMPOJ<TData>, FGFCHIANHLN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct HIJFIAKNBEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<FGFCHIANHLN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public OALKPNAMBCC<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<FGFCHIANHLN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x37F46B0", Offset = "0x37F38B0", VA = "0x1837F46B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x37F49A0", Offset = "0x37F3BA0", VA = "0x1837F49A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KHGBFFHOKPP<TData> FNNBKPJLJIP;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x403EC40", Offset = "0x403DE40", VA = "0x18403EC40")]
	public OALKPNAMBCC(TData LIBBGAGNJJE, IReadOnlyList<TData> LIGLEMNDJAA, bool BEECMAJNHBN, HFECJPDMPOJ<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x403EB40", Offset = "0x403DD40", VA = "0x18403EB40", Slot = "4")]
	[AsyncStateMachine(typeof(OALKPNAMBCC<>.HIJFIAKNBEE))]
	public override Task<FGFCHIANHLN> PABGJEDHKFF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct KHGBFFHOKPP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData LMFPJAHLONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> NIEEMAMHPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool JCANICNIPIF;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3B63480", Offset = "0x3B62680", VA = "0x183B63480")]
	public KHGBFFHOKPP(TData LIBBGAGNJJE, IReadOnlyList<TData> LIGLEMNDJAA, bool BEECMAJNHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface DNGOLNOJOFJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PABGJEDHKFF([In] NEIBECBPEEL<TData> KMNDEPHNDCE);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface OGLEHHDBFGF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PABGJEDHKFF([In] HAFNGIPJJND<TData> KMNDEPHNDCE);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface FHKDMBLIEIL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFCCMBLBKOK([In] KNGBAPLEMDC<TData> KMNDEPHNDCE);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDGKFKJNNNG();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class GPMGGPFCODH<TData> : PJCGHODLLLF<DNGOLNOJOFJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly NEIBECBPEEL<TData> KMNDEPHNDCE;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x37687C0", Offset = "0x37679C0", VA = "0x1837687C0")]
	public GPMGGPFCODH(IEnumerable<TData> DEHNHNLLKOD, EBKCFCJOEEA DKDNEEAJCMI, DEHILCHFMOJ FCJNMBKENDK, float HHKJMNMDJBB, bool BEECMAJNHBN, DNGOLNOJOFJ<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E80", Offset = "0x32D1080", VA = "0x1832D1E80", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class GPNBBLICACF<TData> : PJCGHODLLLF<OGLEHHDBFGF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HAFNGIPJJND<TData> KMNDEPHNDCE;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3768960", Offset = "0x3767B60", VA = "0x183768960")]
	public GPNBBLICACF(TData[] DEHNHNLLKOD, EBKCFCJOEEA[] DKDNEEAJCMI, DEHILCHFMOJ[] FCJNMBKENDK, float[] HHKJMNMDJBB, OGLEHHDBFGF<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x37688A0", Offset = "0x3767AA0", VA = "0x1837688A0", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class HBMKLKDKLGC<TData> : PJCGHODLLLF<FHKDMBLIEIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x32DB010", Offset = "0x32DA210", VA = "0x1832DB010")]
	public HBMKLKDKLGC(FHKDMBLIEIL<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3790730", Offset = "0x378F930", VA = "0x183790730", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class PPLDGGHBGBM<TData> : PJCGHODLLLF<FHKDMBLIEIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly KNGBAPLEMDC<TData> KMNDEPHNDCE;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x415B320", Offset = "0x415A520", VA = "0x18415B320")]
	public PPLDGGHBGBM(IEnumerable<TData> DEHNHNLLKOD, EBKCFCJOEEA DKDNEEAJCMI, DEHILCHFMOJ FCJNMBKENDK, float HHKJMNMDJBB, FHKDMBLIEIL<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x37688A0", Offset = "0x3767AA0", VA = "0x1837688A0", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct NEIBECBPEEL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> MNOOMIJBBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public EBKCFCJOEEA ONEIJGNKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public DEHILCHFMOJ CDNFDPFEBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float HHKJMNMDJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool BEECMAJNHBN;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3F1B6B0", Offset = "0x3F1A8B0", VA = "0x183F1B6B0")]
	public NEIBECBPEEL(IEnumerable<TData> DEHNHNLLKOD, EBKCFCJOEEA DKDNEEAJCMI, DEHILCHFMOJ FCJNMBKENDK, float HHKJMNMDJBB, bool BEECMAJNHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct HAFNGIPJJND<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] MNOOMIJBBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public EBKCFCJOEEA[] ONEIJGNKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public DEHILCHFMOJ[] CDNFDPFEBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] HHKJMNMDJBB;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x378D920", Offset = "0x378CB20", VA = "0x18378D920")]
	public HAFNGIPJJND(TData[] DEHNHNLLKOD, EBKCFCJOEEA[] DKDNEEAJCMI, DEHILCHFMOJ[] FCJNMBKENDK, float[] HHKJMNMDJBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct KNGBAPLEMDC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> MNOOMIJBBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public EBKCFCJOEEA ONEIJGNKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public DEHILCHFMOJ CDNFDPFEBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float HHKJMNMDJBB;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B9A810", Offset = "0x3B99A10", VA = "0x183B9A810")]
	public KNGBAPLEMDC(IEnumerable<TData> DEHNHNLLKOD, EBKCFCJOEEA DKDNEEAJCMI, DEHILCHFMOJ FCJNMBKENDK, float HHKJMNMDJBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface AHFCIGPNNOJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OGNKPILCBGD([In] KMMGEIDJFHP<TData> EJMDDNHFHDD);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJAGHEOAJNF([In] KMMGEIDJFHP<TData> EJMDDNHFHDD);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PPFPDDFEACF([In] bool MPECGKCNBIP);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PCMMBNFAFNB([In] KMMGEIDJFHP<TData> EJMDDNHFHDD);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PEMOAOMFGJL();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CPBHKHELNOL([In] TData DNHLMMEPAHC);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class EMAIGDHDFGD<TData> : PJCGHODLLLF<AHFCIGPNNOJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly KMMGEIDJFHP<TData> EJMDDNHFHDD;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x32D1F40", Offset = "0x32D1140", VA = "0x1832D1F40")]
	public EMAIGDHDFGD(List<TData> CDNFLDEAOKG, AHFCIGPNNOJ<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E80", Offset = "0x32D1080", VA = "0x1832D1E80", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class JMAGBLHGEOI<TData> : PJCGHODLLLF<AHFCIGPNNOJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x32DB010", Offset = "0x32DA210", VA = "0x1832DB010")]
	public JMAGBLHGEOI(AHFCIGPNNOJ<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3AC5B20", Offset = "0x3AC4D20", VA = "0x183AC5B20", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class GBPFGHBOPPB<TData> : PJCGHODLLLF<AHFCIGPNNOJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool BEECMAJNHBN;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x372A400", Offset = "0x3729600", VA = "0x18372A400")]
	public GBPFGHBOPPB(bool BEECMAJNHBN, AHFCIGPNNOJ<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x372A3A0", Offset = "0x37295A0", VA = "0x18372A3A0", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class LGCNMJHHBNH<TData> : PJCGHODLLLF<AHFCIGPNNOJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly KMMGEIDJFHP<TData> EJMDDNHFHDD;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3C425A0", Offset = "0x3C417A0", VA = "0x183C425A0")]
	public LGCNMJHHBNH(List<TData> CDNFLDEAOKG, bool BEECMAJNHBN, AHFCIGPNNOJ<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x37EDB40", Offset = "0x37ECD40", VA = "0x1837EDB40", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GLKANBFFPNI<TData> : PJCGHODLLLF<AHFCIGPNNOJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData DNHLMMEPAHC;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x375C730", Offset = "0x375B930", VA = "0x18375C730")]
	public GLKANBFFPNI(TData DNHLMMEPAHC, AHFCIGPNNOJ<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x375C5B0", Offset = "0x375B7B0", VA = "0x18375C5B0", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class NEALDKFGDKN<TData> : PJCGHODLLLF<AHFCIGPNNOJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly KMMGEIDJFHP<TData> EJMDDNHFHDD;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3F170B0", Offset = "0x3F162B0", VA = "0x183F170B0")]
	public NEALDKFGDKN(IEnumerable<TData> CDNFLDEAOKG, AHFCIGPNNOJ<TData> CJEFKAMCPLH, bool BEECMAJNHBN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3F16FE0", Offset = "0x3F161E0", VA = "0x183F16FE0", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct KMMGEIDJFHP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> MNOOMIJBBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool BEECMAJNHBN;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3B99E50", Offset = "0x3B99050", VA = "0x183B99E50")]
	public KMMGEIDJFHP(IEnumerable<TData> INEOOJPMNIF, bool AGFLOLBDJJE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface KCAKHMDEIGH
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FGFCHIANHLN> PABGJEDHKFF(KGCANPODPHP GGGPPLCENHO);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class FOLOAJHNCFG : DHJKFMNFEMB<KCAKHMDEIGH, FGFCHIANHLN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct AKENFNMIEOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<FGFCHIANHLN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public FOLOAJHNCFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<FGFCHIANHLN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x618CBE0", Offset = "0x618BDE0", VA = "0x18618CBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x618CE60", Offset = "0x618C060", VA = "0x18618CE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly KGCANPODPHP MDNOELDMKIG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x618D130", Offset = "0x618C330", VA = "0x18618D130")]
	public FOLOAJHNCFG(bool BEECMAJNHBN, KCAKHMDEIGH CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x618D040", Offset = "0x618C240", VA = "0x18618D040", Slot = "4")]
	[AsyncStateMachine(typeof(AKENFNMIEOO))]
	public override Task<FGFCHIANHLN> PABGJEDHKFF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct KGCANPODPHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool JCANICNIPIF;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xCC2970", Offset = "0xCC1B70", VA = "0x180CC2970")]
	public KGCANPODPHP(bool BEECMAJNHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct JHKGHJOOLKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool MFAIOECFBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool HJGEOIFNJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool LNFDMKEIMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool BEECMAJNHBN;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4603720", Offset = "0x4602920", VA = "0x184603720")]
	public JHKGHJOOLKI(bool MFAIOECFBNK, bool HJGEOIFNJHI, bool LNFDMKEIMFC, bool BEECMAJNHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x618D980", Offset = "0x618CB80", VA = "0x18618D980")]
	public JHKGHJOOLKI(bool HJGEOIFNJHI, bool BEECMAJNHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface CJMMGOPLBEC
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CPPMNCIGLIC(JHKGHJOOLKI GNJILFBIMIP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BDGKNOJOMOJ(JHKGHJOOLKI GNJILFBIMIP);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class OKMGBGDGCHL : PJCGHODLLLF<CJMMGOPLBEC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly JHKGHJOOLKI GNJILFBIMIP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x618DE50", Offset = "0x618D050", VA = "0x18618DE50")]
	public OKMGBGDGCHL(bool ABJBIFMIENO, bool HJGEOIFNJHI, bool LNFDMKEIMFC, bool BEECMAJNHBN, CJMMGOPLBEC CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x618DE00", Offset = "0x618D000", VA = "0x18618DE00", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class ONIBHJBDKIA : PJCGHODLLLF<CJMMGOPLBEC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly JHKGHJOOLKI GNJILFBIMIP;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x618DF50", Offset = "0x618D150", VA = "0x18618DF50")]
	public ONIBHJBDKIA(bool HJGEOIFNJHI, bool BEECMAJNHBN, CJMMGOPLBEC CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x618DF00", Offset = "0x618D100", VA = "0x18618DF00", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface ALCDFFADEJJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PABGJEDHKFF([In] GPBABOAPGHP CAJKPEOPILD);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class ACDIHGKNEIH : PJCGHODLLLF<ALCDFFADEJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly GPBABOAPGHP CAJKPEOPILD;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x618C9C0", Offset = "0x618BBC0", VA = "0x18618C9C0")]
	public ACDIHGKNEIH(Guid[] MHFAFFPKEND, Vector3[] MECJMNODAGD, Quaternion[] HJDNJACPCIC, float[] OPJBNOBLGKL, Dictionary<Guid, Vector3> NFHDEIBFJMJ, ALCDFFADEJJ CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x618C910", Offset = "0x618BB10", VA = "0x18618C910", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface FLHGHKNEFOM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOKJLONIOCA([In] CFDBBPDCNJI<TData> CGNJECLHADB);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFCCMBLBKOK([In] DEFEJKJKOBB JAFNLOPJJGN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KFCCMBLBKOK([In] ACNKELDHPBG JAFNLOPJJGN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PDGKFKJNNNG();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class DNNOEDMDHFC<TData> : PJCGHODLLLF<FLHGHKNEFOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x32DB010", Offset = "0x32DA210", VA = "0x1832DB010")]
	public DNNOEDMDHFC(FLHGHKNEFOM<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x508C2B0", Offset = "0x508B4B0", VA = "0x18508C2B0", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class GJBMLFDMEFK<TData> : PJCGHODLLLF<FLHGHKNEFOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly DEFEJKJKOBB FFHNCMFMKDD;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x37595B0", Offset = "0x37587B0", VA = "0x1837595B0")]
	public GJBMLFDMEFK(Vector3 PHFAFLLFJKI, bool FHAJENDIKMK, FLHGHKNEFOM<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3759550", Offset = "0x3758750", VA = "0x183759550", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class HBICNFOHAJM<TData> : PJCGHODLLLF<FLHGHKNEFOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly ACNKELDHPBG FFHNCMFMKDD;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x37903D0", Offset = "0x378F5D0", VA = "0x1837903D0")]
	public HBICNFOHAJM(Guid IBFJBHHKNBB, int ILNNGHKJMBD, Vector3 HBEJPCPOKJI, Quaternion KIIONLKEIBO, float AEKGFLEECNO, bool FHAJENDIKMK, FLHGHKNEFOM<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3790370", Offset = "0x378F570", VA = "0x183790370", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class NEPPIDNEIJE<TData> : PJCGHODLLLF<FLHGHKNEFOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CFDBBPDCNJI<TData> FFHNCMFMKDD;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3F1C660", Offset = "0x3F1B860", VA = "0x183F1C660")]
	public NEPPIDNEIJE(TData MJBOJGOCOJL, bool BEECMAJNHBN, FLHGHKNEFOM<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E80", Offset = "0x32D1080", VA = "0x1832D1E80", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct DEFEJKJKOBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Vector3 PHFAFLLFJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool FHAJENDIKMK;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x618D020", Offset = "0x618C220", VA = "0x18618D020")]
	public DEFEJKJKOBB(Vector3 PHFAFLLFJKI, bool FHAJENDIKMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct ACNKELDHPBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Guid IBFJBHHKNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int ILNNGHKJMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Vector3 HBEJPCPOKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Quaternion KIIONLKEIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly float AEKGFLEECNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly bool FHAJENDIKMK;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x618CBA0", Offset = "0x618BDA0", VA = "0x18618CBA0")]
	public ACNKELDHPBG(Guid IBFJBHHKNBB, int ILNNGHKJMBD, Vector3 HBEJPCPOKJI, Quaternion KIIONLKEIBO, float AEKGFLEECNO, bool FHAJENDIKMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct CFDBBPDCNJI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData MJBOJGOCOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly bool BEECMAJNHBN;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x49D2030", Offset = "0x49D1230", VA = "0x1849D2030")]
	public CFDBBPDCNJI(TData MJBOJGOCOJL, bool BEECMAJNHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface LENGKOOPIKO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PABGJEDHKFF([In] ODAEOCAALHA<TData> GGBADMCIDGI);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PABGJEDHKFF([In] NKEAEDMOJPH<TData> GGBADMCIDGI);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface LLDNFFCKCCD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOKJLONIOCA([In] LAEFMDGNKEN<TData> GGADGELKOOG);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFCCMBLBKOK([In] AELAOLKAJKD JAFNLOPJJGN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PDGKFKJNNNG();
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class IMIIFDEGGBC<TData> : PJCGHODLLLF<LENGKOOPIKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly ODAEOCAALHA<TData> GGBADMCIDGI;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x38B2580", Offset = "0x38B1780", VA = "0x1838B2580")]
	public IMIIFDEGGBC(IEnumerable<TData> DEHNHNLLKOD, Vector3 KFJKKBPDFMP, bool BEECMAJNHBN, LENGKOOPIKO<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E80", Offset = "0x32D1080", VA = "0x1832D1E80", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class INIJJADIAAM<TData> : PJCGHODLLLF<LLDNFFCKCCD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x32DB010", Offset = "0x32DA210", VA = "0x1832DB010")]
	public INIJJADIAAM(LLDNFFCKCCD<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x38B3BF0", Offset = "0x38B2DF0", VA = "0x1838B3BF0", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class BBCLGNDLEBC<TData> : PJCGHODLLLF<LLDNFFCKCCD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LAEFMDGNKEN<TData> GGBADMCIDGI;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x477D270", Offset = "0x477C470", VA = "0x18477D270")]
	public BBCLGNDLEBC(IEnumerable<TData> DEHNHNLLKOD, bool BEECMAJNHBN, LLDNFFCKCCD<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E80", Offset = "0x32D1080", VA = "0x1832D1E80", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class DAGCJIDIPEJ<TData> : PJCGHODLLLF<LENGKOOPIKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly NKEAEDMOJPH<TData> GGBADMCIDGI;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5060C80", Offset = "0x505FE80", VA = "0x185060C80")]
	public DAGCJIDIPEJ(IEnumerable<TData> DEHNHNLLKOD, Vector3 LEMIHEMAEBH, KKIDDAPECEM MGJJKLPODKI, bool BEECMAJNHBN, LENGKOOPIKO<TData> CJEFKAMCPLH, Space BLMIPGDEPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3790520", Offset = "0x378F720", VA = "0x183790520", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class AGLCHCEOOPB<TData> : PJCGHODLLLF<LLDNFFCKCCD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly AELAOLKAJKD GGBADMCIDGI;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x37A24E0", Offset = "0x37A16E0", VA = "0x1837A24E0")]
	public AGLCHCEOOPB(Vector3 KFJKKBPDFMP, LLDNFFCKCCD<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3759550", Offset = "0x3758750", VA = "0x183759550", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct ODAEOCAALHA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly IEnumerable<TData> DEHNHNLLKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Vector3 KFJKKBPDFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly bool BEECMAJNHBN;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x405CE70", Offset = "0x405C070", VA = "0x18405CE70")]
	public ODAEOCAALHA(IEnumerable<TData> DEHNHNLLKOD, Vector3 KFJKKBPDFMP, bool BEECMAJNHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct LAEFMDGNKEN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> DEHNHNLLKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool BEECMAJNHBN;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3C045F0", Offset = "0x3C037F0", VA = "0x183C045F0")]
	public LAEFMDGNKEN(IEnumerable<TData> DEHNHNLLKOD, bool BEECMAJNHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct NKEAEDMOJPH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly IEnumerable<TData> DEHNHNLLKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 LEMIHEMAEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly KKIDDAPECEM MGJJKLPODKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool BEECMAJNHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Space BLMIPGDEPOO;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3F5EC10", Offset = "0x3F5DE10", VA = "0x183F5EC10")]
	public NKEAEDMOJPH(IEnumerable<TData> DEHNHNLLKOD, Vector3 LEMIHEMAEBH, KKIDDAPECEM MGJJKLPODKI, bool BEECMAJNHBN, Space BLMIPGDEPOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct AELAOLKAJKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Vector3 KFJKKBPDFMP;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F38AD0", Offset = "0x1F37CD0", VA = "0x181F38AD0")]
	public AELAOLKAJKD(Vector3 KFJKKBPDFMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum KKIDDAPECEM
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
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface AGCKCPJJIOM
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PABGJEDHKFF([In] OFBJHEHAJHK ODPLJCKBONF);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class BCDEBNPPMGK : PJCGHODLLLF<AGCKCPJJIOM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly OFBJHEHAJHK ODPLJCKBONF;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x618CF80", Offset = "0x618C180", VA = "0x18618CF80")]
	public BCDEBNPPMGK(bool BEECMAJNHBN, AGCKCPJJIOM CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x618CED0", Offset = "0x618C0D0", VA = "0x18618CED0", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct OFBJHEHAJHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool BEECMAJNHBN;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xCC2970", Offset = "0xCC1B70", VA = "0x180CC2970")]
	public OFBJHEHAJHK(bool BEECMAJNHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface IPCHFAEHDJD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PABGJEDHKFF([In] DEHPPMDOPLG<TData> OOOAJMJBKNF);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PABGJEDHKFF([In] LAONCBMINBA<TData> OOOAJMJBKNF);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface PFGEPIJNJLE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOKJLONIOCA([In] OPHEGIGIFHN<TData> CGNJECLHADB);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFCCMBLBKOK([In] IJDLIKKGIPN JAFNLOPJJGN);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PDGKFKJNNNG();
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class HAGMBLEOKJG<TData> : PJCGHODLLLF<IPCHFAEHDJD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly DEHPPMDOPLG<TData> OOOAJMJBKNF;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x378E460", Offset = "0x378D660", VA = "0x18378E460")]
	public HAGMBLEOKJG(IEnumerable<TData> DEHNHNLLKOD, Quaternion KFJKKBPDFMP, Vector3? MFNJIMEFOMC, bool BKEGHNILBJI, bool BEECMAJNHBN, IPCHFAEHDJD<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E80", Offset = "0x32D1080", VA = "0x1832D1E80", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class MMCECMPBPOJ<TData> : PJCGHODLLLF<PFGEPIJNJLE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x32DB010", Offset = "0x32DA210", VA = "0x1832DB010")]
	public MMCECMPBPOJ(PFGEPIJNJLE<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x38B3BF0", Offset = "0x38B2DF0", VA = "0x1838B3BF0", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class GJKGMGJFENG<TData> : PJCGHODLLLF<PFGEPIJNJLE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly OPHEGIGIFHN<TData> OOOAJMJBKNF;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x375B110", Offset = "0x375A310", VA = "0x18375B110")]
	public GJKGMGJFENG(IEnumerable<TData> DEHNHNLLKOD, bool BEECMAJNHBN, PFGEPIJNJLE<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E80", Offset = "0x32D1080", VA = "0x1832D1E80", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class HBKEKNMJKAI<TData> : PJCGHODLLLF<IPCHFAEHDJD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly LAONCBMINBA<TData> OOOAJMJBKNF;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x37905F0", Offset = "0x378F7F0", VA = "0x1837905F0")]
	public HBKEKNMJKAI(IEnumerable<TData> DEHNHNLLKOD, Quaternion JIPOGPBKKFD, KKIDDAPECEM CLADPNOMFCP, Vector3? MFNJIMEFOMC, bool BKEGHNILBJI, bool BEECMAJNHBN, Space BLMIPGDEPOO, IPCHFAEHDJD<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3790520", Offset = "0x378F720", VA = "0x183790520", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class LEFKIHIMDIM<TData> : PJCGHODLLLF<PFGEPIJNJLE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly IJDLIKKGIPN OOOAJMJBKNF;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3C15A40", Offset = "0x3C14C40", VA = "0x183C15A40")]
	public LEFKIHIMDIM(Quaternion KFJKKBPDFMP, Vector3? MFNJIMEFOMC, bool BKEGHNILBJI, PFGEPIJNJLE<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3759550", Offset = "0x3758750", VA = "0x183759550", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct DEHPPMDOPLG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly IEnumerable<TData> DEHNHNLLKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Quaternion KFJKKBPDFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3? MFNJIMEFOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool BKEGHNILBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool BEECMAJNHBN;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5066DB0", Offset = "0x5065FB0", VA = "0x185066DB0")]
	public DEHPPMDOPLG(IEnumerable<TData> DEHNHNLLKOD, Quaternion KFJKKBPDFMP, Vector3? MFNJIMEFOMC, bool BKEGHNILBJI, bool BEECMAJNHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct OPHEGIGIFHN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> DEHNHNLLKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool BEECMAJNHBN;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4093D10", Offset = "0x4092F10", VA = "0x184093D10")]
	public OPHEGIGIFHN(IEnumerable<TData> DEHNHNLLKOD, bool BEECMAJNHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct LAONCBMINBA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly IEnumerable<TData> DEHNHNLLKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Quaternion JIPOGPBKKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly KKIDDAPECEM CLADPNOMFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3? MFNJIMEFOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool BKEGHNILBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool BEECMAJNHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Space BLMIPGDEPOO;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3C10040", Offset = "0x3C0F240", VA = "0x183C10040")]
	public LAONCBMINBA(IEnumerable<TData> DEHNHNLLKOD, Quaternion JIPOGPBKKFD, KKIDDAPECEM CLADPNOMFCP, Vector3? MFNJIMEFOMC, bool BKEGHNILBJI, bool BEECMAJNHBN, Space BLMIPGDEPOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct IJDLIKKGIPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Quaternion KFJKKBPDFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3? MFNJIMEFOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool BKEGHNILBJI;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x45BD590", Offset = "0x45BC790", VA = "0x1845BD590")]
	public IJDLIKKGIPN(Quaternion KFJKKBPDFMP, Vector3? MFNJIMEFOMC, bool BKEGHNILBJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface CEGIEHDGGJA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOKJLONIOCA([In] LEHONGIPKLL<TData> CGNJECLHADB);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFCCMBLBKOK([In] HFKACPKIHPE JAFNLOPJJGN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KFCCMBLBKOK([In] OMJKNMCLDHM JAFNLOPJJGN);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KFCCMBLBKOK([In] CILCLNKGGOE JAFNLOPJJGN);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PDGKFKJNNNG();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class JPJNMLHBFMK<TData> : PJCGHODLLLF<CEGIEHDGGJA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly CILCLNKGGOE ICKPDBNHENG;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3ACDDF0", Offset = "0x3ACCFF0", VA = "0x183ACDDF0")]
	public JPJNMLHBFMK(Vector3 GFAAAJPCJCL, float KCFKDECNACC, Vector3 MFNJIMEFOMC, bool IGOEIMNJAJI, bool BGMIOGKOHPM, CEGIEHDGGJA<TData> CJEFKAMCPLH, Space BLMIPGDEPOO = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3ACDD90", Offset = "0x3ACCF90", VA = "0x183ACDD90", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class PJKMJFFMDPC<TData> : PJCGHODLLLF<CEGIEHDGGJA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x32DB010", Offset = "0x32DA210", VA = "0x1832DB010")]
	public PJKMJFFMDPC(CEGIEHDGGJA<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4142C50", Offset = "0x4141E50", VA = "0x184142C50", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class FHAIMLOMPMI<TData> : PJCGHODLLLF<CEGIEHDGGJA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly LEHONGIPKLL<TData> ICKPDBNHENG;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3619A40", Offset = "0x3618C40", VA = "0x183619A40")]
	public FHAIMLOMPMI(IEnumerable<TData> DEHNHNLLKOD, bool BEECMAJNHBN, CEGIEHDGGJA<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E80", Offset = "0x32D1080", VA = "0x1832D1E80", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class MLOJHDKDBMH<TData> : PJCGHODLLLF<CEGIEHDGGJA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly OMJKNMCLDHM ICKPDBNHENG;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3E85540", Offset = "0x3E84740", VA = "0x183E85540")]
	public MLOJHDKDBMH(float JPJGEBLJPAB, bool KOPEIPLPKOK, Vector3 MFNJIMEFOMC, CEGIEHDGGJA<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3E85470", Offset = "0x3E84670", VA = "0x183E85470", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class HMGDNNEDPMN<TData> : PJCGHODLLLF<CEGIEHDGGJA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly HFKACPKIHPE ICKPDBNHENG;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x37FF130", Offset = "0x37FE330", VA = "0x1837FF130")]
	public HMGDNNEDPMN(float KCFKDECNACC, Vector3 MFNJIMEFOMC, CEGIEHDGGJA<TData> CJEFKAMCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3759550", Offset = "0x3758750", VA = "0x183759550", Slot = "4")]
	public override bool PABGJEDHKFF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct CILCLNKGGOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 GFAAAJPCJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly float KCFKDECNACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 MFNJIMEFOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool FHAJENDIKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space BLMIPGDEPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly bool BGMIOGKOHPM;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x618CFE0", Offset = "0x618C1E0", VA = "0x18618CFE0")]
	public CILCLNKGGOE(Vector3 GFAAAJPCJCL, float KCFKDECNACC, Vector3 MFNJIMEFOMC, bool FHAJENDIKMK, bool BGHOOOEFFMK, Space BLMIPGDEPOO = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct LEHONGIPKLL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> DEHNHNLLKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool BEECMAJNHBN;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3C16CF0", Offset = "0x3C15EF0", VA = "0x183C16CF0")]
	public LEHONGIPKLL(IEnumerable<TData> DEHNHNLLKOD, bool BEECMAJNHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct OMJKNMCLDHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly float JPJGEBLJPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool KOPEIPLPKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly Vector3 MFNJIMEFOMC;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x618DEE0", Offset = "0x618D0E0", VA = "0x18618DEE0")]
	public OMJKNMCLDHM(float JPJGEBLJPAB, bool KOPEIPLPKOK, Vector3 MFNJIMEFOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct HFKACPKIHPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly float KCFKDECNACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 MFNJIMEFOMC;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x459F020", Offset = "0x459E220", VA = "0x18459F020")]
	public HFKACPKIHPE(float KCFKDECNACC, Vector3 MFNJIMEFOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct GPBABOAPGHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Guid[] DEHNHNLLKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly bool PFFLFBOHDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool IMHMONGADNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool HBOBKFAPJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Vector3[] MECJMNODAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion[] HJDNJACPCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly float[] OPJBNOBLGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Dictionary<Guid, Vector3> NFHDEIBFJMJ;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x618D360", Offset = "0x618C560", VA = "0x18618D360")]
	public GPBABOAPGHP(Guid[] MHFAFFPKEND, Vector3[] MECJMNODAGD, Quaternion[] HJDNJACPCIC, float[] OPJBNOBLGKL, Dictionary<Guid, Vector3> NFHDEIBFJMJ, bool PFFLFBOHDCM = true, bool IMHMONGADNI = true, bool HBOBKFAPJGL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x618D190", Offset = "0x618C390", VA = "0x18618D190")]
	private static void JPEFAPKEKNO(Dictionary<Guid, Vector3> NFHDEIBFJMJ, int KIENADDOCOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class NCICLDLFIPJ
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct LFAGNIGCIDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool FDFJKLOJJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public IAIHJGNDPNA OMOBHDDOHBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public IAIHJGNDPNA DCCJBFHJPGI;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static LFAGNIGCIDM JLKJIOPCNIL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken IOONFPAJIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x618DCC0", Offset = "0x618CEC0", VA = "0x18618DCC0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static IAIHJGNDPNA OMOBHDDOHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x618DCE0", Offset = "0x618CEE0", VA = "0x18618DCE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x618DC50", Offset = "0x618CE50", VA = "0x18618DC50")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x618DA00", Offset = "0x618CC00", VA = "0x18618DA00")]
	[JKGCDNJCKNE(MDFHPBOGAKL.Room, LIEILBDPEFI.None)]
	private static void FMKOLHGJHEH(IAIHJGNDPNA PELNHOPINJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x618DB00", Offset = "0x618CD00", VA = "0x18618DB00")]
	public static void HBHCINBKNHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x618D9B0", Offset = "0x618CBB0", VA = "0x18618D9B0")]
	private static IAIHJGNDPNA BAEIIGAJBGC(IAIHJGNDPNA BCFAEHPOPNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class NFGLEHPCMEM
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum LIPPKPCOOMC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x28A88B0", Offset = "0x28A7AB0", VA = "0x1828A88B0")]
	public static void KEPOCJGCGDH<T>(T PHLEALHFEPH, LIPPKPCOOMC DMEGHACCPAC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x28A89F0", Offset = "0x28A7BF0", VA = "0x1828A89F0")]
	public static void KEPOCJGCGDH<T>(T PHLEALHFEPH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x28A8A50", Offset = "0x28A7C50", VA = "0x1828A8A50")]
	public static void NKMPPNEHHNP<T>(T PHLEALHFEPH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x28A8730", Offset = "0x28A7930", VA = "0x1828A8730")]
	public static T EOIPIOCNLEH<T>(LIPPKPCOOMC DMEGHACCPAC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x28A8560", Offset = "0x28A7760", VA = "0x1828A8560")]
	public static bool DLKDMALJFAF<T>(LIPPKPCOOMC DMEGHACCPAC, T CJDELFDJBPG, [Out] T MAMJDBKIGBH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x28A8810", Offset = "0x28A7A10", VA = "0x1828A8810")]
	public static bool JMDLDBKIFAL<T>(LIPPKPCOOMC DMEGHACCPAC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x28A87D0", Offset = "0x28A79D0", VA = "0x1828A87D0")]
	public static T EOIPIOCNLEH<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x28A8690", Offset = "0x28A7890", VA = "0x1828A8690")]
	public static bool DLKDMALJFAF<T>(T CJDELFDJBPG, [Out] T MAMJDBKIGBH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x28A87D0", Offset = "0x28A79D0", VA = "0x1828A87D0")]
	public static bool JMDLDBKIFAL<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class HPKKJMDFLNC
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x618D5F0", Offset = "0x618C7F0", VA = "0x18618D5F0")]
	public static void FENLCJHIIBK(IEnumerable FELJJIAMOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x27A9E00", Offset = "0x27A9000", VA = "0x1827A9E00")]
	public static void FENLCJHIIBK<T>(T[] NPPGGGEFJIJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x27A9EF0", Offset = "0x27A90F0", VA = "0x1827A9EF0")]
	public static void FENLCJHIIBK<T>(T INAFIMGOJNH) where T : notnull, Enum
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
