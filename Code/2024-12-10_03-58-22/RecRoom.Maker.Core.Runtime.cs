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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C95A00", Offset = "0x6C94600", VA = "0x186C95A00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C95F40", Offset = "0x6C94B40", VA = "0x186C95F40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IHFJNAPECCN<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn DPKMJIOGHIC(TData PLAMADMDGIO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OEDNPNAMMMB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(FDJMGONEMMJ LFBBLOALAKK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData CGJNNJHBPPG, Collider EOIFOAAKKIF, FDJMGONEMMJ LFBBLOALAKK, [Optional] BLNKBACJIBE? IKMFCODHPKE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData CGJNNJHBPPG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider EOIFOAAKKIF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EJJMFCFIDPI<TData> : OHNKFCJDEHP, GHJHDLDEKHI<TData>, GAJFFPECGOE<TData>, OFCOHHOKEBM<TData>, POGKAPFJGGB, BIOJDHCOIHD<TData>, HKHIJOOMOFJ, EPHAGHBLOIF
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BIOJDHCOIHD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 NLLHBHEGIHB, Vector3 EJOHIEANBFL, float GHBEHFGEGMI, [Out] T PMFAMPBDBHF, [Out] Vector3 FNKPDPAAEGG, [Out] Collider EOIFOAAKKIF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 NLLHBHEGIHB, Vector3 EJOHIEANBFL, float CKCJEJJLHNO, float GHBEHFGEGMI, T[] IDJJLLGKJPG, [Out] Vector3 JDILAALDGDP, [Out] Collider ILJIHGLCCOK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 NLLHBHEGIHB, float CKCJEJJLHNO, Vector3 JLKJNNCEGIO, T[] IDJJLLGKJPG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider OBPELBJIGMM, [Out] T DEHHFPNPOGF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OHNKFCJDEHP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds OFJGDFLLPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform AKCDADJAMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds CCMKJKBEDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform HAJNLKGHCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 LJDDJJIIFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KHCJLDFOGOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool HFGDAEKLHAC = true, int HGFAPEGCHFN = 0);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool MNDFFKNELJE, object DGGGDIFONNG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EPHAGHBLOIF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DBHLBOFDKDO KMLGDBJEOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PEAONHPNPKF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool JGGHFJKJKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool PCANEDCLJHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool KCIFDHFLCGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> PLDDMOBKAJB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OFCOHHOKEBM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool AHLOAKPAKEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int FOFCBKKHPOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> FGHDFHGHNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData ANPIFEPGOLG);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData ANPIFEPGOLG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GHJHDLDEKHI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T PLAMADMDGIO, [Optional] BLNKBACJIBE? PBAGHGLELNF, bool JPLJGANAPKO = true);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int KNHHBEFLJAF, IEnumerable<T> LDPBKCPMNOA, bool JPLJGANAPKO = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int KNHHBEFLJAF, IEnumerable<T> LDPBKCPMNOA, BLNKBACJIBE PBAGHGLELNF, bool JPLJGANAPKO = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HKHIJOOMOFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface POGKAPFJGGB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool FAHJFMNGJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool FEGKIBLNFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool EPAHJJGCIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool KOGAHCAMDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class ICOFHLJDICE<TReceiver> : PIEDGOINFPD<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0AC0", Offset = "0x3DDF6C0", VA = "0x183DE0AC0")]
	public ICOFHLJDICE(TReceiver IMHHBHNOLMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class MACDLHJEMID<TReceiver, TFromTask> : PIEDGOINFPD<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0AC0", Offset = "0x3DDF6C0", VA = "0x183DE0AC0")]
	public MACDLHJEMID(TReceiver IMHHBHNOLMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class PIEDGOINFPD<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver IMHHBHNOLMB;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x488DFC0", Offset = "0x488CBC0", VA = "0x18488DFC0")]
	public PIEDGOINFPD(TReceiver IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute NPJFPNAECEE();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class OEODEANMCFG<TReceiver, TResult> : PIEDGOINFPD<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0AC0", Offset = "0x3DDF6C0", VA = "0x183DE0AC0")]
	public OEODEANMCFG(TReceiver IMHHBHNOLMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KBDALNBCALG<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup ELPCLNOBPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData DJLDNMPJBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> NGPPDCEJIAJ;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x204A9D0", Offset = "0x20495D0", VA = "0x18204A9D0")]
	public KBDALNBCALG(TGroup LHHCPOBIEPO, TData JKGKIGKANJI, IEnumerable<TData> HFNIAAFDIEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct EAMBEJEIEBD<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup ELPCLNOBPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> NGPPDCEJIAJ;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xC7E130", Offset = "0xC7CD30", VA = "0x180C7E130")]
	public EAMBEJEIEBD(TGroup LHHCPOBIEPO, IEnumerable<TData> HFNIAAFDIEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PGFKJLONMGI<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup ELPCLNOBPMA;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xAE4B40", Offset = "0xAE3740", VA = "0x180AE4B40")]
	public PGFKJLONMGI(TGroup LHHCPOBIEPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PDFEKPIGGDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<Guid> NGPPDCEJIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Guid NDHAMFBGOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool ELAKHNHAJEI;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C95A80", Offset = "0x6C94680", VA = "0x186C95A80")]
	public PDFEKPIGGDE(IEnumerable<Guid> HFNIAAFDIEE, Guid HAKCNELIGBD, bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KCEMEMJGLLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public Guid NDHAMFBGOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool ELAKHNHAJEI;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1BB9FB0", Offset = "0x1BB8BB0", VA = "0x181BB9FB0")]
	public KCEMEMJGLLN(Guid HAKCNELIGBD, bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HFNCJLJMBBH<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CAIPLMMPIEG NMNHBLLIMBL(KBDALNBCALG<TGroup, TData> HEFADMGNBMK);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CAIPLMMPIEG HMAKODGMHLC(KBDALNBCALG<TGroup, TData> HEFADMGNBMK);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CAIPLMMPIEG MPNNLOLCALO(EAMBEJEIEBD<TGroup, TData> HEFADMGNBMK);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CAIPLMMPIEG BGDBHCIICLK(PGFKJLONMGI<TGroup> HEFADMGNBMK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CJPEIDLPFLL
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CAIPLMMPIEG> NMNHBLLIMBL(PDFEKPIGGDE HEFADMGNBMK);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CAIPLMMPIEG> HMAKODGMHLC(KCEMEMJGLLN HEFADMGNBMK);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DIMDKJBLPNJ<TGroup, TData> : OEODEANMCFG<HFNCJLJMBBH<TGroup, TData>, CAIPLMMPIEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly EAMBEJEIEBD<TGroup, TData> HEFADMGNBMK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB3C0", Offset = "0x5AE9FC0", VA = "0x185AEB3C0")]
	public DIMDKJBLPNJ(TGroup LHHCPOBIEPO, IEnumerable<TData> HFNIAAFDIEE, HFNCJLJMBBH<TGroup, TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB2F0", Offset = "0x5AE9EF0", VA = "0x185AEB2F0", Slot = "4")]
	public override CAIPLMMPIEG NPJFPNAECEE()
	{
		return default(CAIPLMMPIEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OHKGAJAFLBM<TGroup, TData> : OEODEANMCFG<HFNCJLJMBBH<TGroup, TData>, CAIPLMMPIEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly KBDALNBCALG<TGroup, TData> HEFADMGNBMK;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x41F4970", Offset = "0x41F3570", VA = "0x1841F4970")]
	public OHKGAJAFLBM(TGroup LHHCPOBIEPO, TData OPIFNCNHJJA, IEnumerable<TData> HFNIAAFDIEE, HFNCJLJMBBH<TGroup, TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x47A8A60", Offset = "0x47A7660", VA = "0x1847A8A60", Slot = "4")]
	public override CAIPLMMPIEG NPJFPNAECEE()
	{
		return default(CAIPLMMPIEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ACHPJFFMCKH<TGroup, TData> : OEODEANMCFG<HFNCJLJMBBH<TGroup, TData>, CAIPLMMPIEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly PGFKJLONMGI<TGroup> HEFADMGNBMK;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3E9F380", Offset = "0x3E9DF80", VA = "0x183E9F380")]
	public ACHPJFFMCKH(TGroup LHHCPOBIEPO, HFNCJLJMBBH<TGroup, TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E9F2B0", Offset = "0x3E9DEB0", VA = "0x183E9F2B0", Slot = "4")]
	public override CAIPLMMPIEG NPJFPNAECEE()
	{
		return default(CAIPLMMPIEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JMNIGPAHFBO<TGroup, TData> : OEODEANMCFG<HFNCJLJMBBH<TGroup, TData>, CAIPLMMPIEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KBDALNBCALG<TGroup, TData> HEFADMGNBMK;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x41F4970", Offset = "0x41F3570", VA = "0x1841F4970")]
	public JMNIGPAHFBO(TGroup LHHCPOBIEPO, TData JKGKIGKANJI, IEnumerable<TData> HFNIAAFDIEE, HFNCJLJMBBH<TGroup, TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x41F4890", Offset = "0x41F3490", VA = "0x1841F4890", Slot = "4")]
	public override CAIPLMMPIEG NPJFPNAECEE()
	{
		return default(CAIPLMMPIEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MOIKGOLJFLA : MACDLHJEMID<CJPEIDLPFLL, CAIPLMMPIEG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct PPBBBGHMNHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<CAIPLMMPIEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public MOIKGOLJFLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<CAIPLMMPIEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C95C30", Offset = "0x6C94830", VA = "0x186C95C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6C95ED0", Offset = "0x6C94AD0", VA = "0x186C95ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PDFEKPIGGDE HEFADMGNBMK;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C95440", Offset = "0x6C94040", VA = "0x186C95440")]
	public MOIKGOLJFLA(IEnumerable<Guid> KIKFDNLJAGF, Guid HAKCNELIGBD, bool GFNMDFLJILL, CJPEIDLPFLL IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C95350", Offset = "0x6C93F50", VA = "0x186C95350", Slot = "4")]
	[AsyncStateMachine(typeof(PPBBBGHMNHE))]
	public override Task<CAIPLMMPIEG> NPJFPNAECEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class PNHKFDCPLFB : MACDLHJEMID<CJPEIDLPFLL, CAIPLMMPIEG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct DCMJPPAOLFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<CAIPLMMPIEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public PNHKFDCPLFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<CAIPLMMPIEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6C94490", Offset = "0x6C93090", VA = "0x186C94490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6C94730", Offset = "0x6C93330", VA = "0x186C94730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly KCEMEMJGLLN HEFADMGNBMK;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C95BB0", Offset = "0x6C947B0", VA = "0x186C95BB0")]
	public PNHKFDCPLFB(Guid HAKCNELIGBD, bool GFNMDFLJILL, CJPEIDLPFLL IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C95AC0", Offset = "0x6C946C0", VA = "0x186C95AC0", Slot = "4")]
	[AsyncStateMachine(typeof(DCMJPPAOLFC))]
	public override Task<CAIPLMMPIEG> NPJFPNAECEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct HKHCNBEKMGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly DBEBIGPJMAJ NDDIHJDBOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool ELAKHNHAJEI;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C94D30", Offset = "0x6C93930", VA = "0x186C94D30")]
	public HKHCNBEKMGK(DBEBIGPJMAJ KDMGMJENBIH, bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface OLIJAODBJMA<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> NPJFPNAECEE(HKHCNBEKMGK OMJCLLKDKBO);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MJMEBCCMMDA<TSpawnType> : MACDLHJEMID<OLIJAODBJMA<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct JPIGDDNEBGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MJMEBCCMMDA<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4203FB0", Offset = "0x4202BB0", VA = "0x184203FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B410", Offset = "0x3A5A010", VA = "0x183A5B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HKHCNBEKMGK OMJCLLKDKBO;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x45BFB80", Offset = "0x45BE780", VA = "0x1845BFB80")]
	public MJMEBCCMMDA(DBEBIGPJMAJ KDMGMJENBIH, bool GFNMDFLJILL, OLIJAODBJMA<TSpawnType> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x45BF980", Offset = "0x45BE580", VA = "0x1845BF980", Slot = "4")]
	[AsyncStateMachine(typeof(MJMEBCCMMDA<>.JPIGDDNEBGB))]
	public override Task<TSpawnType> NPJFPNAECEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct DBEBIGPJMAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly bool GNACGKMNDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Vector3 IHGGCBNMEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 FIKECJKJAAD;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C94420", Offset = "0x6C93020", VA = "0x186C94420")]
	public DBEBIGPJMAJ(Transform LHNBFKBIALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C943F0", Offset = "0x6C92FF0", VA = "0x186C943F0")]
	public DBEBIGPJMAJ(Vector3 DJCDKMIHKHG, Vector3 GKJAMFFKDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C94340", Offset = "0x6C92F40", VA = "0x186C94340")]
	public static DBEBIGPJMAJ JNOOFNDBBED()
	{
		return default(DBEBIGPJMAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C94370", Offset = "0x6C92F70", VA = "0x186C94370")]
	private DBEBIGPJMAJ(bool FINNGJLMDCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct AFAGOMOECLF<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TNode DLJKCDPOOHA;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3EA6E10", Offset = "0x3EA5A10", VA = "0x183EA6E10")]
	public AFAGOMOECLF(TNode DLJKCDPOOHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct MAIBMOCNLKM<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public TNode BHDOPDMFBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public TReparentOperations CABFFECCCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public EMMINMGOMAJ CLDLLLKICCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool ELAKHNHAJEI;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4581F10", Offset = "0x4580B10", VA = "0x184581F10")]
	public MAIBMOCNLKM(TNode BHDOPDMFBFG, TReparentOperations CABFFECCCLA, EMMINMGOMAJ CLDLLLKICCN, bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface IGDPLHBONGJ<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEMDICKELMI([In] AFAGOMOECLF<TNode> ABMJIOIOPEA);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IGJNEAIJMOG([In] MAIBMOCNLKM<TNode, TReparentOperations> HADILIFPFAA);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HDJILCAEPIF();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NLOIMPGGKIN<TNode, TReparentOperations> : ICOFHLJDICE<IGDPLHBONGJ<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0AC0", Offset = "0x3DDF6C0", VA = "0x183DE0AC0")]
	public NLOIMPGGKIN(IGDPLHBONGJ<TNode, TReparentOperations> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3F1E200", Offset = "0x3F1CE00", VA = "0x183F1E200", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class ALPFFGAEMEI<TNode, TReparentOperations> : ICOFHLJDICE<IGDPLHBONGJ<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly MAIBMOCNLKM<TNode, TReparentOperations> HADILIFPFAA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3F1BBC0", Offset = "0x3F1A7C0", VA = "0x183F1BBC0")]
	public ALPFFGAEMEI(TNode BHDOPDMFBFG, TReparentOperations CABFFECCCLA, EMMINMGOMAJ CLDLLLKICCN, IGDPLHBONGJ<TNode, TReparentOperations> IMHHBHNOLMB, bool GFNMDFLJILL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3F1BAF0", Offset = "0x3F1A6F0", VA = "0x183F1BAF0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class MBPBBGCFFKB<TNode, TReparentOperations> : ICOFHLJDICE<IGDPLHBONGJ<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly AFAGOMOECLF<TNode> ABMJIOIOPEA;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4585070", Offset = "0x4583C70", VA = "0x184585070")]
	public MBPBBGCFFKB(TNode CLPMFJJCKDK, IGDPLHBONGJ<TNode, TReparentOperations> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A0A0", Offset = "0x3A88CA0", VA = "0x183A8A0A0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct IOPIKDHIBFA<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TSpawnInfo HCKCJMGHHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector3 GKJAMFFKDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Quaternion EAGKGJHHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float IMPGFCOPLND;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x403CF00", Offset = "0x403BB00", VA = "0x18403CF00")]
	public IOPIKDHIBFA(TSpawnInfo HCKCJMGHHDD, Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, float IMPGFCOPLND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface MKMDEFPIKCF<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> BIICNEBDBBD([In] IOPIKDHIBFA<TSpawnInfo> HJIFCMAEILH, CancellationToken CKKFHABGBNL);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class ODGCAINIHHI<TSpawnType, TSpawnInfo> : MACDLHJEMID<MKMDEFPIKCF<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly IOPIKDHIBFA<TSpawnInfo> JIAHCJFCHOA;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x479DE50", Offset = "0x479CA50", VA = "0x18479DE50")]
	public ODGCAINIHHI(TSpawnInfo PEFPGOOAEDC, Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, float IMPGFCOPLND, MKMDEFPIKCF<TSpawnType, TSpawnInfo> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3EEDE10", Offset = "0x3EECA10", VA = "0x183EEDE10", Slot = "4")]
	public override Task<TSpawnType> NPJFPNAECEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct OOCCJICJHPN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IEnumerable<TData> NGPPDCEJIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool ELAKHNHAJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool DJNIFAMGMIM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x47D09E0", Offset = "0x47CF5E0", VA = "0x1847D09E0")]
	public OOCCJICJHPN(IEnumerable<TData> HFNIAAFDIEE, bool GFNMDFLJILL = false, bool FJOMFOMMGBN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface NMKFFBHEFLE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CAIPLMMPIEG> OBCEAGNDLDF([In] OOCCJICJHPN<TData> PCGCHGJCBFG, CancellationToken CKKFHABGBNL);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class GMBDBAAOGCE<TData> : MACDLHJEMID<NMKFFBHEFLE<TData>, CAIPLMMPIEG> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OOCCJICJHPN<TData> MMFCPJFHGHN;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3EEDEF0", Offset = "0x3EECAF0", VA = "0x183EEDEF0")]
	public GMBDBAAOGCE(IEnumerable<TData> HFNIAAFDIEE, bool GFNMDFLJILL, NMKFFBHEFLE<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3EEDE10", Offset = "0x3EECA10", VA = "0x183EEDE10", Slot = "4")]
	public override Task<CAIPLMMPIEG> NPJFPNAECEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct MEIFHLNFEJD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T CGJNNJHBPPG;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x42009D0", Offset = "0x41FF5D0", VA = "0x1842009D0")]
	public MEIFHLNFEJD(T ODOGNIKNEOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface LCNHLJDNKCN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEMDICKELMI([In] MEIFHLNFEJD<T> LJBBELNOCIM);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IGJNEAIJMOG();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface FOABKDPGIPN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPJFPNAECEE([In] NEBBOPNLJJB<T> ENFPCJLFFFM);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NEBBOPNLJJB<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T CGJNNJHBPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool CHCCLIFIOLL;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4656770", Offset = "0x4655370", VA = "0x184656770")]
	public NEBBOPNLJJB(T ODOGNIKNEOO, bool LHFEPIBEACO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class LIAJCCLDLLN<T> : ICOFHLJDICE<LCNHLJDNKCN<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0AC0", Offset = "0x3DDF6C0", VA = "0x183DE0AC0")]
	public LIAJCCLDLLN(LCNHLJDNKCN<T> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4379440", Offset = "0x4378040", VA = "0x184379440", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class IDFCBHHMBEF<T> : ICOFHLJDICE<LCNHLJDNKCN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly MEIFHLNFEJD<T> LJBBELNOCIM;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4017FA0", Offset = "0x4016BA0", VA = "0x184017FA0")]
	public IDFCBHHMBEF(T CGJNNJHBPPG, LCNHLJDNKCN<T> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A0A0", Offset = "0x3A88CA0", VA = "0x183A8A0A0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PDHMEFELLJP<T> : ICOFHLJDICE<FOABKDPGIPN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly NEBBOPNLJJB<T> ENFPCJLFFFM;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x48826D0", Offset = "0x48812D0", VA = "0x1848826D0")]
	public PDHMEFELLJP(T CGJNNJHBPPG, bool LHFEPIBEACO, FOABKDPGIPN<T> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A0A0", Offset = "0x3A88CA0", VA = "0x183A8A0A0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct GHLAGEJFMFO<TData> where TData : notnull, HBKNNDEAPEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IEnumerable<TData> NGPPDCEJIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool GLELIDICAIJ;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3EE87F0", Offset = "0x3EE73F0", VA = "0x183EE87F0")]
	public GHLAGEJFMFO(IEnumerable<TData> OEBLGOKMOLG, bool PFEOJOOCAGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct NNJLDMHBECF<TData> where TData : notnull, HBKNNDEAPEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public List<TData> NGPPDCEJIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public List<bool> DAGIFLDENGO;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x46B0BD0", Offset = "0x46AF7D0", VA = "0x1846B0BD0")]
	public NNJLDMHBECF(List<TData> OEBLGOKMOLG, List<bool> IFADNOIAENI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface HBKNNDEAPEH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool CGBMKOGBCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BMJEOBKODKK<TData> where TData : HBKNNDEAPEH
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPJFPNAECEE([In] GHLAGEJFMFO<TData> ACDMPDONKEC);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPJFPNAECEE([In] NNJLDMHBECF<TData> ACDMPDONKEC);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface AEDNDNBMJHI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EBAFJEBLBID(T CGJNNJHBPPG);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class NJKGDPFDKFJ<TData> : ICOFHLJDICE<BMJEOBKODKK<TData>> where TData : notnull, HBKNNDEAPEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly GHLAGEJFMFO<TData> ACDMPDONKEC;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4674FD0", Offset = "0x4673BD0", VA = "0x184674FD0")]
	public NJKGDPFDKFJ(List<TData> HFNIAAFDIEE, bool GLELIDICAIJ, BMJEOBKODKK<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A0A0", Offset = "0x3A88CA0", VA = "0x183A8A0A0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BAMAEPBMOLJ<TData> : ICOFHLJDICE<BMJEOBKODKK<TData>> where TData : notnull, HBKNNDEAPEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly NNJLDMHBECF<TData> ACDMPDONKEC;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5043FD0", Offset = "0x5042BD0", VA = "0x185043FD0")]
	public BAMAEPBMOLJ(List<TData> HFNIAAFDIEE, List<bool> DAGIFLDENGO, BMJEOBKODKK<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5043F10", Offset = "0x5042B10", VA = "0x185043F10", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface FDABOOMMHOH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CAIPLMMPIEG> NPJFPNAECEE(MBPCMFCBPKD<TData> GBJNCKHHCJM);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class PEMMBDJCHCJ<TData> : MACDLHJEMID<FDABOOMMHOH<TData>, CAIPLMMPIEG> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct HADGHENJMFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<CAIPLMMPIEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public PEMMBDJCHCJ<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<CAIPLMMPIEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CD90", Offset = "0x3F2B990", VA = "0x183F2CD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D070", Offset = "0x3F2BC70", VA = "0x183F2D070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly MBPCMFCBPKD<TData> IHDMEFMFGLA;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4882D30", Offset = "0x4881930", VA = "0x184882D30")]
	public PEMMBDJCHCJ(TData GHOOGNPAIND, IReadOnlyList<TData> CLCDCFDKKCE, bool GFNMDFLJILL, FDABOOMMHOH<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4882C30", Offset = "0x4881830", VA = "0x184882C30", Slot = "4")]
	[AsyncStateMachine(typeof(PEMMBDJCHCJ<>.HADGHENJMFJ))]
	public override Task<CAIPLMMPIEG> NPJFPNAECEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct MBPCMFCBPKD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData BFMCHHJLLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public IReadOnlyList<TData> LGMCLAJJKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool ELAKHNHAJEI;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4585100", Offset = "0x4583D00", VA = "0x184585100")]
	public MBPCMFCBPKD(TData GHOOGNPAIND, IReadOnlyList<TData> CLCDCFDKKCE, bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface GFJFJMMJMHF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPJFPNAECEE([In] PKEIPMNJJNB<TData> MGPACCBBKDG);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface ADPHHNNGLHI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPJFPNAECEE([In] DLBJIBDBJIN<TData> MGPACCBBKDG);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface EOFHDFPAIEI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KLKDOBFBLDK([In] GEFPJLMPECF<TData> MGPACCBBKDG);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGJNEAIJMOG();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class IJEMMPGDJKA<TData> : ICOFHLJDICE<GFJFJMMJMHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly PKEIPMNJJNB<TData> MGPACCBBKDG;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x402EE90", Offset = "0x402DA90", VA = "0x18402EE90")]
	public IJEMMPGDJKA(IEnumerable<TData> HFNIAAFDIEE, JJGANJGEFFL NKKLIFIFGAP, OICBHJLAMDI OFCNJEFMNEM, float JCPIPHBCGIA, bool GFNMDFLJILL, GFJFJMMJMHF<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A0A0", Offset = "0x3A88CA0", VA = "0x183A8A0A0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class JOJBKENPDED<TData> : ICOFHLJDICE<ADPHHNNGLHI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly DLBJIBDBJIN<TData> MGPACCBBKDG;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4202420", Offset = "0x4201020", VA = "0x184202420")]
	public JOJBKENPDED(TData[] HFNIAAFDIEE, JJGANJGEFFL[] NKKLIFIFGAP, OICBHJLAMDI[] OFCNJEFMNEM, float[] JCPIPHBCGIA, ADPHHNNGLHI<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4202280", Offset = "0x4200E80", VA = "0x184202280", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class KIPHECPPNKE<TData> : ICOFHLJDICE<EOFHDFPAIEI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0AC0", Offset = "0x3DDF6C0", VA = "0x183DE0AC0")]
	public KIPHECPPNKE(EOFHDFPAIEI<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x42BDD20", Offset = "0x42BC920", VA = "0x1842BDD20", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class NPAKAOFDHNM<TData> : ICOFHLJDICE<EOFHDFPAIEI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly GEFPJLMPECF<TData> MGPACCBBKDG;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x46B3820", Offset = "0x46B2420", VA = "0x1846B3820")]
	public NPAKAOFDHNM(IEnumerable<TData> HFNIAAFDIEE, JJGANJGEFFL NKKLIFIFGAP, OICBHJLAMDI OFCNJEFMNEM, float JCPIPHBCGIA, EOFHDFPAIEI<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4202280", Offset = "0x4200E80", VA = "0x184202280", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct PKEIPMNJJNB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public IEnumerable<TData> NGPPDCEJIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public JJGANJGEFFL KIGNICELNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public OICBHJLAMDI CLNADELPCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float JCPIPHBCGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool GFNMDFLJILL;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4894730", Offset = "0x4893330", VA = "0x184894730")]
	public PKEIPMNJJNB(IEnumerable<TData> HFNIAAFDIEE, JJGANJGEFFL NKKLIFIFGAP, OICBHJLAMDI OFCNJEFMNEM, float JCPIPHBCGIA, bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct DLBJIBDBJIN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public TData[] NGPPDCEJIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public JJGANJGEFFL[] KIGNICELNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public OICBHJLAMDI[] CLNADELPCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float[] JCPIPHBCGIA;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5B02000", Offset = "0x5B00C00", VA = "0x185B02000")]
	public DLBJIBDBJIN(TData[] HFNIAAFDIEE, JJGANJGEFFL[] NKKLIFIFGAP, OICBHJLAMDI[] OFCNJEFMNEM, float[] JCPIPHBCGIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct GEFPJLMPECF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public IEnumerable<TData> NGPPDCEJIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public JJGANJGEFFL KIGNICELNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public OICBHJLAMDI CLNADELPCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float JCPIPHBCGIA;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3ED9FF0", Offset = "0x3ED8BF0", VA = "0x183ED9FF0")]
	public GEFPJLMPECF(IEnumerable<TData> HFNIAAFDIEE, JJGANJGEFFL NKKLIFIFGAP, OICBHJLAMDI OFCNJEFMNEM, float JCPIPHBCGIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface GAJFFPECGOE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MPNNLOLCALO([In] FMLMINHKBPE<TData> PCGCHGJCBFG);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGDBHCIICLK([In] FMLMINHKBPE<TData> PCGCHGJCBFG);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEDNGAEEODN([In] bool ADADNNFOAOA);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AMJMNJMKMOG([In] FMLMINHKBPE<TData> PCGCHGJCBFG);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLAPBEMDEBN();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NOJCHEOOGPA([In] TData NPPJGEFAHJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class IFJAIFKBJDL<TData> : ICOFHLJDICE<GAJFFPECGOE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly FMLMINHKBPE<TData> PCGCHGJCBFG;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4026390", Offset = "0x4024F90", VA = "0x184026390")]
	public IFJAIFKBJDL(List<TData> AIOEIPPJKAA, GAJFFPECGOE<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A0A0", Offset = "0x3A88CA0", VA = "0x183A8A0A0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class KEDFJLDIGAC<TData> : ICOFHLJDICE<GAJFFPECGOE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0AC0", Offset = "0x3DDF6C0", VA = "0x183DE0AC0")]
	public KEDFJLDIGAC(GAJFFPECGOE<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x42B16C0", Offset = "0x42B02C0", VA = "0x1842B16C0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class EPOODINIAIH<TData> : ICOFHLJDICE<GAJFFPECGOE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly bool GFNMDFLJILL;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3A99A60", Offset = "0x3A98660", VA = "0x183A99A60")]
	public EPOODINIAIH(bool GFNMDFLJILL, GAJFFPECGOE<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3A99A00", Offset = "0x3A98600", VA = "0x183A99A00", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class DEEILPBADPG<TData> : ICOFHLJDICE<GAJFFPECGOE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly FMLMINHKBPE<TData> PCGCHGJCBFG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5AC2DA0", Offset = "0x5AC19A0", VA = "0x185AC2DA0")]
	public DEEILPBADPG(List<TData> AIOEIPPJKAA, bool GFNMDFLJILL, GAJFFPECGOE<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5043F10", Offset = "0x5042B10", VA = "0x185043F10", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class EECPCOKBKBD<TData> : ICOFHLJDICE<GAJFFPECGOE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TData NPPJGEFAHJJ;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A66010", Offset = "0x3A64C10", VA = "0x183A66010")]
	public EECPCOKBKBD(TData NPPJGEFAHJJ, GAJFFPECGOE<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A65F40", Offset = "0x3A64B40", VA = "0x183A65F40", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class EGGBODAEFKO<TData> : ICOFHLJDICE<GAJFFPECGOE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly FMLMINHKBPE<TData> PCGCHGJCBFG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F030", Offset = "0x3A6DC30", VA = "0x183A6F030")]
	public EGGBODAEFKO(IEnumerable<TData> AIOEIPPJKAA, GAJFFPECGOE<TData> IMHHBHNOLMB, bool GFNMDFLJILL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A6EF60", Offset = "0x3A6DB60", VA = "0x183A6EF60", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct FMLMINHKBPE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IEnumerable<TData> NGPPDCEJIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool GFNMDFLJILL;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3E12E40", Offset = "0x3E11A40", VA = "0x183E12E40")]
	public FMLMINHKBPE(IEnumerable<TData> OEBLGOKMOLG, bool LCIFAANMFPF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface GIJLKLGJGKI
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CAIPLMMPIEG> NPJFPNAECEE(FFJMCPJJDPE COIJDGCNEBI);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LNNNIOMFICN : MACDLHJEMID<GIJLKLGJGKI, CAIPLMMPIEG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct BFNPOKBCKOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<CAIPLMMPIEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public LNNNIOMFICN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<CAIPLMMPIEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C93F70", Offset = "0x6C92B70", VA = "0x186C93F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C941F0", Offset = "0x6C92DF0", VA = "0x186C941F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly FFJMCPJJDPE BDAFFJEOFOL;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C94E50", Offset = "0x6C93A50", VA = "0x186C94E50")]
	public LNNNIOMFICN(bool GFNMDFLJILL, GIJLKLGJGKI IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C94D60", Offset = "0x6C93960", VA = "0x186C94D60", Slot = "4")]
	[AsyncStateMachine(typeof(BFNPOKBCKOJ))]
	public override Task<CAIPLMMPIEG> NPJFPNAECEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct FFJMCPJJDPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool ELAKHNHAJEI;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2324190", Offset = "0x2322D90", VA = "0x182324190")]
	public FFJMCPJJDPE(bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct LADADCNGPAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool DGNLMAPJODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool LANPMFKLJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly bool IMPGFCOPLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool GFNMDFLJILL;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4EE71C0", Offset = "0x4EE5DC0", VA = "0x184EE71C0")]
	public LADADCNGPAD(bool DGNLMAPJODD, bool LANPMFKLJKF, bool IMPGFCOPLND, bool GFNMDFLJILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C94D50", Offset = "0x6C93950", VA = "0x186C94D50")]
	public LADADCNGPAD(bool LANPMFKLJKF, bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface DNOMIBNCLNN
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KKJELCKLFGD(LADADCNGPAD EDIEKLAMACC);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OPGMNNLINAC(LADADCNGPAD EDIEKLAMACC);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class CJGNHJOGENG : ICOFHLJDICE<DNOMIBNCLNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly LADADCNGPAD EDIEKLAMACC;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C942B0", Offset = "0x6C92EB0", VA = "0x186C942B0")]
	public CJGNHJOGENG(bool OHCKGBMFMEE, bool LANPMFKLJKF, bool IMPGFCOPLND, bool GFNMDFLJILL, DNOMIBNCLNN IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C94260", Offset = "0x6C92E60", VA = "0x186C94260", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class LPCMFBMGDIH : ICOFHLJDICE<DNOMIBNCLNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly LADADCNGPAD EDIEKLAMACC;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C94F00", Offset = "0x6C93B00", VA = "0x186C94F00")]
	public LPCMFBMGDIH(bool LANPMFKLJKF, bool GFNMDFLJILL, DNOMIBNCLNN IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C94EB0", Offset = "0x6C93AB0", VA = "0x186C94EB0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface LOMLGIEBJAA
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPJFPNAECEE([In] DGHJFJDLEDB CCAFOIEBLJD);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class NJMCEDMPGGE : ICOFHLJDICE<LOMLGIEBJAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly DGHJFJDLEDB CCAFOIEBLJD;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6C95820", Offset = "0x6C94420", VA = "0x186C95820")]
	public NJMCEDMPGGE(Guid[] PEMDBBLKIMA, Vector3[] EOBOMLMEGLK, Quaternion[] PKBOEBMEADC, float[] OLLHMFMCNNA, Dictionary<Guid, Vector3> DGLFMHPJKEA, LOMLGIEBJAA IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6C95770", Offset = "0x6C94370", VA = "0x186C95770", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface MJNCPDFAFDB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEMDICKELMI([In] BIBBCJGKDHA<TData> ABMJIOIOPEA);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KLKDOBFBLDK([In] FICDABLBCGK NLFJPAJBMGC);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KLKDOBFBLDK([In] AHFFKDANDLH NLFJPAJBMGC);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IGJNEAIJMOG();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class KAMHGHMEHFG<TData> : ICOFHLJDICE<MJNCPDFAFDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0AC0", Offset = "0x3DDF6C0", VA = "0x183DE0AC0")]
	public KAMHGHMEHFG(MJNCPDFAFDB<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x42A44D0", Offset = "0x42A30D0", VA = "0x1842A44D0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class EGNNJFHFOCE<TData> : ICOFHLJDICE<MJNCPDFAFDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly FICDABLBCGK MGLFOKACLHH;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3A70850", Offset = "0x3A6F450", VA = "0x183A70850")]
	public EGNNJFHFOCE(Vector3 HJMINJFMKGC, bool EKIMGHKNCPD, MJNCPDFAFDB<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A707F0", Offset = "0x3A6F3F0", VA = "0x183A707F0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class KPEDMGNEBKC<TData> : ICOFHLJDICE<MJNCPDFAFDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly AHFFKDANDLH MGLFOKACLHH;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x42E1F30", Offset = "0x42E0B30", VA = "0x1842E1F30")]
	public KPEDMGNEBKC(Guid LOHOAJJHAIL, int MFJLAMOCOBC, Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, float JLDCCBFCJGC, bool EKIMGHKNCPD, MJNCPDFAFDB<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x42E1ED0", Offset = "0x42E0AD0", VA = "0x1842E1ED0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class OMOEMFOACAF<TData> : ICOFHLJDICE<MJNCPDFAFDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly BIBBCJGKDHA<TData> MGLFOKACLHH;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x47CD280", Offset = "0x47CBE80", VA = "0x1847CD280")]
	public OMOEMFOACAF(TData CGJNNJHBPPG, bool GFNMDFLJILL, MJNCPDFAFDB<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A0A0", Offset = "0x3A88CA0", VA = "0x183A8A0A0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct FICDABLBCGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly Vector3 HJMINJFMKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly bool EKIMGHKNCPD;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6C94C00", Offset = "0x6C93800", VA = "0x186C94C00")]
	public FICDABLBCGK(Vector3 HJMINJFMKGC, bool EKIMGHKNCPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct AHFFKDANDLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Guid LOHOAJJHAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly int MFJLAMOCOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 GKJAMFFKDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly Quaternion EAGKGJHHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly float JLDCCBFCJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool EKIMGHKNCPD;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6C93F30", Offset = "0x6C92B30", VA = "0x186C93F30")]
	public AHFFKDANDLH(Guid LOHOAJJHAIL, int MFJLAMOCOBC, Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, float JLDCCBFCJGC, bool EKIMGHKNCPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct BIBBCJGKDHA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly TData CGJNNJHBPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool GFNMDFLJILL;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x50ACB20", Offset = "0x50AB720", VA = "0x1850ACB20")]
	public BIBBCJGKDHA(TData CGJNNJHBPPG, bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface GGKHJBFAKMD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPJFPNAECEE([In] DPGHNGJFECG<TData> EBAOEMDCBOK);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NPJFPNAECEE([In] KPOMBHJAIBN<TData> EBAOEMDCBOK);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface ALBMAEGKCFC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEMDICKELMI([In] ELDBDLNJBND<TData> CPEIEHJOPMN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KLKDOBFBLDK([In] LOJLEOIICFN NLFJPAJBMGC);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IGJNEAIJMOG();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class BJBGPGHGIKA<TData> : ICOFHLJDICE<GGKHJBFAKMD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly DPGHNGJFECG<TData> EBAOEMDCBOK;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x50AD9C0", Offset = "0x50AC5C0", VA = "0x1850AD9C0")]
	public BJBGPGHGIKA(IEnumerable<TData> HFNIAAFDIEE, Vector3 JMONCLNDPLL, bool GFNMDFLJILL, GGKHJBFAKMD<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A0A0", Offset = "0x3A88CA0", VA = "0x183A8A0A0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class JBBHCGADGNJ<TData> : ICOFHLJDICE<ALBMAEGKCFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0AC0", Offset = "0x3DDF6C0", VA = "0x183DE0AC0")]
	public JBBHCGADGNJ(ALBMAEGKCFC<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3F1E200", Offset = "0x3F1CE00", VA = "0x183F1E200", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class BGOPMKLOMFA<TData> : ICOFHLJDICE<ALBMAEGKCFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly ELDBDLNJBND<TData> EBAOEMDCBOK;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x50A9AD0", Offset = "0x50A86D0", VA = "0x1850A9AD0")]
	public BGOPMKLOMFA(IEnumerable<TData> HFNIAAFDIEE, bool GFNMDFLJILL, ALBMAEGKCFC<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A0A0", Offset = "0x3A88CA0", VA = "0x183A8A0A0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class BDKGLPGOJMI<TData> : ICOFHLJDICE<GGKHJBFAKMD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly KPOMBHJAIBN<TData> EBAOEMDCBOK;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x504E710", Offset = "0x504D310", VA = "0x18504E710")]
	public BDKGLPGOJMI(IEnumerable<TData> HFNIAAFDIEE, Vector3 JFIKMDELKPF, OBCPGJOPADM GPEPEGFDOFO, bool GFNMDFLJILL, GGKHJBFAKMD<TData> IMHHBHNOLMB, Space HOALOIIHFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3F1BAF0", Offset = "0x3F1A6F0", VA = "0x183F1BAF0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class GGGOILMNBJO<TData> : ICOFHLJDICE<ALBMAEGKCFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly LOJLEOIICFN EBAOEMDCBOK;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3EE58E0", Offset = "0x3EE44E0", VA = "0x183EE58E0")]
	public GGGOILMNBJO(Vector3 JMONCLNDPLL, ALBMAEGKCFC<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3A707F0", Offset = "0x3A6F3F0", VA = "0x183A707F0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct DPGHNGJFECG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly IEnumerable<TData> HFNIAAFDIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 JMONCLNDPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool GFNMDFLJILL;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5B14560", Offset = "0x5B13160", VA = "0x185B14560")]
	public DPGHNGJFECG(IEnumerable<TData> HFNIAAFDIEE, Vector3 JMONCLNDPLL, bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct ELDBDLNJBND<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly IEnumerable<TData> HFNIAAFDIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool GFNMDFLJILL;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3A893F0", Offset = "0x3A87FF0", VA = "0x183A893F0")]
	public ELDBDLNJBND(IEnumerable<TData> HFNIAAFDIEE, bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct KPOMBHJAIBN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly IEnumerable<TData> HFNIAAFDIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Vector3 JFIKMDELKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly OBCPGJOPADM GPEPEGFDOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool GFNMDFLJILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly Space HOALOIIHFFF;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x42E7F20", Offset = "0x42E6B20", VA = "0x1842E7F20")]
	public KPOMBHJAIBN(IEnumerable<TData> HFNIAAFDIEE, Vector3 JFIKMDELKPF, OBCPGJOPADM GPEPEGFDOFO, bool GFNMDFLJILL, Space HOALOIIHFFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct LOJLEOIICFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Vector3 JMONCLNDPLL;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2324480", Offset = "0x2323080", VA = "0x182324480")]
	public LOJLEOIICFN(Vector3 JMONCLNDPLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum OBCPGJOPADM
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
public interface LJFKLKHJHPL
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPJFPNAECEE([In] OPNIKCBCDBJ OBKPHPKFGDH);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class FKOLHKGEHND : ICOFHLJDICE<LJFKLKHJHPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly OPNIKCBCDBJ OBKPHPKFGDH;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6C94CD0", Offset = "0x6C938D0", VA = "0x186C94CD0")]
	public FKOLHKGEHND(bool GFNMDFLJILL, LJFKLKHJHPL IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6C94C20", Offset = "0x6C93820", VA = "0x186C94C20", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct OPNIKCBCDBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool GFNMDFLJILL;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2324190", Offset = "0x2322D90", VA = "0x182324190")]
	public OPNIKCBCDBJ(bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface KMBAMANIMGI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPJFPNAECEE([In] DFOGALLHEGI<TData> CLIKCPADMMM);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NPJFPNAECEE([In] IMNIIFLAJCM<TData> CLIKCPADMMM);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface HAHKMDFHGKF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEMDICKELMI([In] INMNLHDCKIE<TData> ABMJIOIOPEA);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KLKDOBFBLDK([In] LEDOAAALMDJ NLFJPAJBMGC);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IGJNEAIJMOG();
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class KFFAMEFBPKO<TData> : ICOFHLJDICE<KMBAMANIMGI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly DFOGALLHEGI<TData> CLIKCPADMMM;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x42B2550", Offset = "0x42B1150", VA = "0x1842B2550")]
	public KFFAMEFBPKO(IEnumerable<TData> HFNIAAFDIEE, Quaternion JMONCLNDPLL, Vector3? ANMHHONOKCB, bool JIHDLBCKAII, bool GFNMDFLJILL, KMBAMANIMGI<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A0A0", Offset = "0x3A88CA0", VA = "0x183A8A0A0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class AMPCFJIODPH<TData> : ICOFHLJDICE<HAHKMDFHGKF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0AC0", Offset = "0x3DDF6C0", VA = "0x183DE0AC0")]
	public AMPCFJIODPH(HAHKMDFHGKF<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3F1E200", Offset = "0x3F1CE00", VA = "0x183F1E200", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class ADBDJKCCBNB<TData> : ICOFHLJDICE<HAHKMDFHGKF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly INMNLHDCKIE<TData> CLIKCPADMMM;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3EA4170", Offset = "0x3EA2D70", VA = "0x183EA4170")]
	public ADBDJKCCBNB(IEnumerable<TData> HFNIAAFDIEE, bool GFNMDFLJILL, HAHKMDFHGKF<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A0A0", Offset = "0x3A88CA0", VA = "0x183A8A0A0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class KAOJBLNLENA<TData> : ICOFHLJDICE<KMBAMANIMGI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly IMNIIFLAJCM<TData> CLIKCPADMMM;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x42A4520", Offset = "0x42A3120", VA = "0x1842A4520")]
	public KAOJBLNLENA(IEnumerable<TData> HFNIAAFDIEE, Quaternion IDPJGBGADPE, OBCPGJOPADM IKAKLOIEDOL, Vector3? ANMHHONOKCB, bool JIHDLBCKAII, bool GFNMDFLJILL, Space HOALOIIHFFF, KMBAMANIMGI<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3F1BAF0", Offset = "0x3F1A6F0", VA = "0x183F1BAF0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class CDIGHCLOMGF<TData> : ICOFHLJDICE<HAHKMDFHGKF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly LEDOAAALMDJ CLIKCPADMMM;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x52404B0", Offset = "0x523F0B0", VA = "0x1852404B0")]
	public CDIGHCLOMGF(Quaternion JMONCLNDPLL, Vector3? ANMHHONOKCB, bool JIHDLBCKAII, HAHKMDFHGKF<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3A707F0", Offset = "0x3A6F3F0", VA = "0x183A707F0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct DFOGALLHEGI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly IEnumerable<TData> HFNIAAFDIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Quaternion JMONCLNDPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3? ANMHHONOKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool JIHDLBCKAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool GFNMDFLJILL;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE260", Offset = "0x5ACCE60", VA = "0x185ACE260")]
	public DFOGALLHEGI(IEnumerable<TData> HFNIAAFDIEE, Quaternion JMONCLNDPLL, Vector3? ANMHHONOKCB, bool JIHDLBCKAII, bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct INMNLHDCKIE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly IEnumerable<TData> HFNIAAFDIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly bool GFNMDFLJILL;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4037600", Offset = "0x4036200", VA = "0x184037600")]
	public INMNLHDCKIE(IEnumerable<TData> HFNIAAFDIEE, bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct IMNIIFLAJCM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly IEnumerable<TData> HFNIAAFDIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly Quaternion IDPJGBGADPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly OBCPGJOPADM IKAKLOIEDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3? ANMHHONOKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool JIHDLBCKAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool GFNMDFLJILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space HOALOIIHFFF;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4036DF0", Offset = "0x40359F0", VA = "0x184036DF0")]
	public IMNIIFLAJCM(IEnumerable<TData> HFNIAAFDIEE, Quaternion IDPJGBGADPE, OBCPGJOPADM IKAKLOIEDOL, Vector3? ANMHHONOKCB, bool JIHDLBCKAII, bool GFNMDFLJILL, Space HOALOIIHFFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct LEDOAAALMDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Quaternion JMONCLNDPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly Vector3? ANMHHONOKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool JIHDLBCKAII;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC780", Offset = "0x4EAB380", VA = "0x184EAC780")]
	public LEDOAAALMDJ(Quaternion JMONCLNDPLL, Vector3? ANMHHONOKCB, bool JIHDLBCKAII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface MIIMOBBNKIK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NEMDICKELMI([In] IFKKHFGFDBO<TData> ABMJIOIOPEA);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KLKDOBFBLDK([In] DGPHMJFPPDB NLFJPAJBMGC);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KLKDOBFBLDK([In] MHHCMPKBKAH NLFJPAJBMGC);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KLKDOBFBLDK([In] NBPLCAGCIIM NLFJPAJBMGC);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IGJNEAIJMOG();
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class DBPHLKBMNLM<TData> : ICOFHLJDICE<MIIMOBBNKIK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly NBPLCAGCIIM AIGAGJPOKHD;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5ABCE10", Offset = "0x5ABBA10", VA = "0x185ABCE10")]
	public DBPHLKBMNLM(Vector3 LMFFEKDKHIP, float GBKOKFCKMOC, Vector3 ANMHHONOKCB, bool ILMPACBOANI, bool ACHJNHHMEAA, MIIMOBBNKIK<TData> IMHHBHNOLMB, Space HOALOIIHFFF = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5ABCDB0", Offset = "0x5ABB9B0", VA = "0x185ABCDB0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class FJOCBOLLOPG<TData> : ICOFHLJDICE<MIIMOBBNKIK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0AC0", Offset = "0x3DDF6C0", VA = "0x183DE0AC0")]
	public FJOCBOLLOPG(MIIMOBBNKIK<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C340", Offset = "0x3E0AF40", VA = "0x183E0C340", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class ELHLJDECFLB<TData> : ICOFHLJDICE<MIIMOBBNKIK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly IFKKHFGFDBO<TData> AIGAGJPOKHD;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A160", Offset = "0x3A88D60", VA = "0x183A8A160")]
	public ELHLJDECFLB(IEnumerable<TData> HFNIAAFDIEE, bool GFNMDFLJILL, MIIMOBBNKIK<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A0A0", Offset = "0x3A88CA0", VA = "0x183A8A0A0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class MMKFEBDGOGJ<TData> : ICOFHLJDICE<MIIMOBBNKIK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly MHHCMPKBKAH AIGAGJPOKHD;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x45C9650", Offset = "0x45C8250", VA = "0x1845C9650")]
	public MMKFEBDGOGJ(float FOCKADLNDJK, bool PDJDKGKBJLM, Vector3 ANMHHONOKCB, MIIMOBBNKIK<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x45C9580", Offset = "0x45C8180", VA = "0x1845C9580", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class HOMPAOEKGAK<TData> : ICOFHLJDICE<MIIMOBBNKIK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly DGPHMJFPPDB AIGAGJPOKHD;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3F69450", Offset = "0x3F68050", VA = "0x183F69450")]
	public HOMPAOEKGAK(float GBKOKFCKMOC, Vector3 ANMHHONOKCB, MIIMOBBNKIK<TData> IMHHBHNOLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3A707F0", Offset = "0x3A6F3F0", VA = "0x183A707F0", Slot = "4")]
	public override bool NPJFPNAECEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct NBPLCAGCIIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 LMFFEKDKHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly float GBKOKFCKMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Vector3 ANMHHONOKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool EKIMGHKNCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Space HOALOIIHFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool ACHJNHHMEAA;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6C95730", Offset = "0x6C94330", VA = "0x186C95730")]
	public NBPLCAGCIIM(Vector3 LMFFEKDKHIP, float GBKOKFCKMOC, Vector3 ANMHHONOKCB, bool EKIMGHKNCPD, bool PFPFIJGIAFD, Space HOALOIIHFFF = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct IFKKHFGFDBO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly IEnumerable<TData> HFNIAAFDIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool GFNMDFLJILL;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x40267F0", Offset = "0x40253F0", VA = "0x1840267F0")]
	public IFKKHFGFDBO(IEnumerable<TData> HFNIAAFDIEE, bool GFNMDFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct MHHCMPKBKAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float FOCKADLNDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool PDJDKGKBJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Vector3 ANMHHONOKCB;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6C94F80", Offset = "0x6C93B80", VA = "0x186C94F80")]
	public MHHCMPKBKAH(float FOCKADLNDJK, bool PDJDKGKBJLM, Vector3 ANMHHONOKCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct DGPHMJFPPDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly float GBKOKFCKMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Vector3 ANMHHONOKCB;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4E59590", Offset = "0x4E58190", VA = "0x184E59590")]
	public DGPHMJFPPDB(float GBKOKFCKMOC, Vector3 ANMHHONOKCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct DGHJFJDLEDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly Guid[] HFNIAAFDIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool LLFHMLLIGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool LCPDOAPIEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool LJHIDLKNECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3[] EOBOMLMEGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion[] PKBOEBMEADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly float[] OLLHMFMCNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly Dictionary<Guid, Vector3> DGLFMHPJKEA;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6C94970", Offset = "0x6C93570", VA = "0x186C94970")]
	public DGHJFJDLEDB(Guid[] PEMDBBLKIMA, Vector3[] EOBOMLMEGLK, Quaternion[] PKBOEBMEADC, float[] OLLHMFMCNNA, Dictionary<Guid, Vector3> DGLFMHPJKEA, bool LLFHMLLIGDP = true, bool LCPDOAPIEEI = true, bool LJHIDLKNECD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6C947A0", Offset = "0x6C933A0", VA = "0x186C947A0")]
	private static void JCDLMANJICM(Dictionary<Guid, Vector3> DGLFMHPJKEA, int DJFKIPGDMJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class MKEGIIOPAPC
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private struct LDCGOIIGNEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public bool HEMAEIOIBJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public EAEKKMJPCLA FIAAOCLPAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public EAEKKMJPCLA JFFIKAKIDOA;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static LDCGOIIGNEG ALMHPHIIMFP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken POBGIDMLOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6C94FF0", Offset = "0x6C93BF0", VA = "0x186C94FF0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static EAEKKMJPCLA FIAAOCLPAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6C952B0", Offset = "0x6C93EB0", VA = "0x186C952B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6C95010", Offset = "0x6C93C10", VA = "0x186C95010")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6C951C0", Offset = "0x6C93DC0", VA = "0x186C951C0")]
	[BOLBLOCFHKO.HNILJJLDPFA]
	internal static void PLEEJGNKMDM(EAEKKMJPCLA OPMGEMNCKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6C95070", Offset = "0x6C93C70", VA = "0x186C95070")]
	public static void OMNFNMJPOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6C94FA0", Offset = "0x6C93BA0", VA = "0x186C94FA0")]
	private static EAEKKMJPCLA HFBMBFDIOPN(EAEKKMJPCLA GKALBEIHDCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class KAMFMNLFAOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum IKBFFPJAOBP
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2B90", Offset = "0x2EC1790", VA = "0x182EC2B90")]
	public static void PNGLNLGHOHE<T>(T CMIAKAKADAG, IKBFFPJAOBP FIFJJNIIAPF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2D00", Offset = "0x2EC1900", VA = "0x182EC2D00")]
	public static void PNGLNLGHOHE<T>(T CMIAKAKADAG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2A30", Offset = "0x2EC1630", VA = "0x182EC2A30")]
	public static void OGEKOHPKFCE<T>(T CMIAKAKADAG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2710", Offset = "0x2EC1310", VA = "0x182EC2710")]
	public static T IBIJBNAFKLE<T>(IKBFFPJAOBP FIFJJNIIAPF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2EC28E0", Offset = "0x2EC14E0", VA = "0x182EC28E0")]
	public static bool JMHMMLHCCPD<T>(IKBFFPJAOBP FIFJJNIIAPF, T? MKGCBEJLAJB, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T CHLNJMJJAFO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2AE0", Offset = "0x2EC16E0", VA = "0x182EC2AE0")]
	public static bool PDLKFHFOMPI<T>(IKBFFPJAOBP FIFJJNIIAPF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2EC27C0", Offset = "0x2EC13C0", VA = "0x182EC27C0")]
	public static T IBIJBNAFKLE<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2820", Offset = "0x2EC1420", VA = "0x182EC2820")]
	public static bool JMHMMLHCCPD<T>(T MKGCBEJLAJB, [Out] T CHLNJMJJAFO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2EC27C0", Offset = "0x2EC13C0", VA = "0x182EC27C0")]
	public static bool PDLKFHFOMPI<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal static class NABAMKMGMGK
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6C95500", Offset = "0x6C94100", VA = "0x186C95500")]
	public static void DFLLHAOEKFN(IEnumerable OAFHEBAAFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2F5CC40", Offset = "0x2F5B840", VA = "0x182F5CC40")]
	public static void DFLLHAOEKFN<T>(T[] BFDOCKABCPN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2F5CD30", Offset = "0x2F5B930", VA = "0x182F5CD30")]
	public static void DFLLHAOEKFN<T>(T DIBAENLMLKH) where T : notnull, Enum
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
