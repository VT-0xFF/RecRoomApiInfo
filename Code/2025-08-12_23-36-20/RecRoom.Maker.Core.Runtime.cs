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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x83E6DD0", Offset = "0x83E5BD0", VA = "0x1883E6DD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x83E7160", Offset = "0x83E5F60", VA = "0x1883E7160", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum OCIDHBFEOAN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ShowFreeInventionsInR2PaletteSearch
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum MBAHPIKFBIK
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	NameAZ,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	NameZA,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	InkCostAsc,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	InkCostDesc,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Newest
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HIBPGBNDMEL<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn NINMMPNEBPO(TData ALGAKMGCCLO);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ILBCOGBHNAF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(IHPOMKOECLM ECMIIPEAMAN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData BNIHAACOHPG, Collider JOJCJPMDBAA, IHPOMKOECLM ECMIIPEAMAN, [Optional] EHMIJFGJLBH? MBDDJGIJBJI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData BNIHAACOHPG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider JOJCJPMDBAA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AMBFPMHMNOM<TData> : MGCACGJPBHO, NMGDPJIGHFI<TData>, BIHBNOOCKLG<TData>, OMMCCGBBHEF<TData>, CPEMIGDHELH, JDIMLDBMDIC<TData>, LGKODCGGKLI, DGJKEPLHKMO
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JDIMLDBMDIC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 BPPDJECPPGM, Vector3 GHKIAFFJCCO, float AGKOFMHMOAG, [Out] T ODNPMOMIFFE, [Out] Vector3 NODABAGEMDM, [Out] Collider JOJCJPMDBAA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 BPPDJECPPGM, Vector3 GHKIAFFJCCO, float ICBCEKLFKHK, float AGKOFMHMOAG, T[] KECJOHPJNDD, [Out] Vector3 PMALMBDAEAJ, [Out] Collider JEFNJNLGHGD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 BPPDJECPPGM, float ICBCEKLFKHK, Vector3 FKMKKGPMIHM, T[] KECJOHPJNDD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider OJDDLOEFCAJ, [Out] T DNINBFFPPBN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MGCACGJPBHO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds CLNLPJNFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform JFHDMNHEIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds DOEIOPOKPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform AOCJHOGMNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 LKAADBMHCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool GFPBCKACHKM
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
	void SetSelectionBoundsDirty(bool DBOJPLEHJCA = true, int OGEPPDDLCMD = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool JNNFLDKNOAL, object OBGCPOCPFIJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DGJKEPLHKMO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MKAEDPHCCBC AELMEAHPHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JEAPJIOJGLI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool AEGKIGNDOPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool BPOJHLCOLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool NFOHBFNFDAK
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> APGMOPNNJED);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OMMCCGBBHEF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool HFFHJAOKFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int EDAOBBJNMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> IMGMMBNJLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData IIHDHELGAFA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData IIHDHELGAFA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NMGDPJIGHFI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T ALGAKMGCCLO, [Optional] EHMIJFGJLBH? FNIKNONFPHG, bool PBJLCOJMOHI = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int FFKCBONKOOM, IEnumerable<T> OKDBCONHNNO, bool PBJLCOJMOHI = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int FFKCBONKOOM, IEnumerable<T> OKDBCONHNNO, EHMIJFGJLBH FNIKNONFPHG, bool PBJLCOJMOHI = true);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LGKODCGGKLI
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CPEMIGDHELH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool CKJOHFHPFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool LBGLJDMEJOC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool GLDILFFJLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool NBNBHJHCHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FKEFHCMKNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool IDJHJILOLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? OEBMIPAGGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public float? EADDLIAOBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float? GNHKGHDCDEG;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct NGNIIEJJCKH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public IEnumerable<TData> CBKPMMHBGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public FKEFHCMKNDM CAHHJMNAFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool BCIHJBLGHHE;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5982BA0", Offset = "0x59819A0", VA = "0x185982BA0")]
	public NGNIIEJJCKH(IEnumerable<TData> CPPEAAHODOM, bool ELLEAKPFPGE, float? BCODHNJBPPM, float? JBEBIIPBGHG, float? ALHLDINKIKD, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IENFDFHNCNI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NACBKBJFHJC([In] NGNIIEJJCKH<TData> NPIEBNDMCBK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LCPDDCEIAOL<TData> : MFCEPHDDFHM<IENFDFHNCNI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NGNIIEJJCKH<TData> NPIEBNDMCBK;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x567C0F0", Offset = "0x567AEF0", VA = "0x18567C0F0")]
	public LCPDDCEIAOL(IEnumerable<TData> CPPEAAHODOM, bool ELLEAKPFPGE, float? BCODHNJBPPM, float? JBEBIIPBGHG, float? ALHLDINKIKD, bool BCIHJBLGHHE, IENFDFHNCNI<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3BC0", Offset = "0x4FF29C0", VA = "0x184FF3BC0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BLJENBNDFIG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> CBKPMMHBGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public string PHKHFNAGCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool GDBIIIBPFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool BCIHJBLGHHE;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68C04F0", Offset = "0x68BF2F0", VA = "0x1868C04F0")]
	public BLJENBNDFIG(IEnumerable<TData> CPPEAAHODOM, string ECFOLMEBCEO, bool LCFGPEJDPOG, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EFIJNCHHFJH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NACBKBJFHJC([In] BLJENBNDFIG<TData> NPIEBNDMCBK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HCLEIGEBLAF<TData> : MFCEPHDDFHM<EFIJNCHHFJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly BLJENBNDFIG<TData> NPIEBNDMCBK;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x507D230", Offset = "0x507C030", VA = "0x18507D230")]
	public HCLEIGEBLAF(IEnumerable<TData> CPPEAAHODOM, string ECFOLMEBCEO, bool LCFGPEJDPOG, bool BCIHJBLGHHE, EFIJNCHHFJH<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3BC0", Offset = "0x4FF29C0", VA = "0x184FF3BC0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class MFCEPHDDFHM<TReceiver> : JJDFGEIODFP<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C1C0", Offset = "0x4A3AFC0", VA = "0x184A3C1C0")]
	public MFCEPHDDFHM(TReceiver BIJLHPHALFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class ADFPNLEMBJE<TReceiver, TFromTask> : JJDFGEIODFP<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C1C0", Offset = "0x4A3AFC0", VA = "0x184A3C1C0")]
	public ADFPNLEMBJE(TReceiver BIJLHPHALFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class JJDFGEIODFP<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected TReceiver BIJLHPHALFD;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x54B0790", Offset = "0x54AF590", VA = "0x1854B0790")]
	public JJDFGEIODFP(TReceiver BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute NACBKBJFHJC();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class LNOEDEGNKLI<TReceiver, TResult> : JJDFGEIODFP<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C1C0", Offset = "0x4A3AFC0", VA = "0x184A3C1C0")]
	public LNOEDEGNKLI(TReceiver BIJLHPHALFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct IOJGCGILBEA<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public TGroup IKAPOFIFDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TData EHGLCHGFFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> CBKPMMHBGLN;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1E04580", Offset = "0x1E03380", VA = "0x181E04580")]
	public IOJGCGILBEA(TGroup IFNKIBOFAPF, TData HKHCMIHCAEL, IEnumerable<TData> CPPEAAHODOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GCNLINAIFDH<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup IKAPOFIFDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<TData> CBKPMMHBGLN;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xC55370", Offset = "0xC54170", VA = "0x180C55370")]
	public GCNLINAIFDH(TGroup IFNKIBOFAPF, IEnumerable<TData> CPPEAAHODOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct EELNPEFHCGE<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public TGroup IKAPOFIFDOK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xEA8530", Offset = "0xEA7330", VA = "0x180EA8530")]
	public EELNPEFHCGE(TGroup IFNKIBOFAPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct IDBCLKLJBMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IEnumerable<Guid> CBKPMMHBGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid ENGEGMFEHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool ENMJOFLMOJJ;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x83E6270", Offset = "0x83E5070", VA = "0x1883E6270")]
	public IDBCLKLJBMF(IEnumerable<Guid> CPPEAAHODOM, Guid PKHHECBGALP, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct NAGKELNLIII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Guid ENGEGMFEHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly bool ENMJOFLMOJJ;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x291CB30", Offset = "0x291B930", VA = "0x18291CB30")]
	public NAGKELNLIII(Guid PKHHECBGALP, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface HFEADICIKOC<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PDBJMFLPFAM MDGNAJFCIMM(IOJGCGILBEA<TGroup, TData> EHEJKPMEJGB);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PDBJMFLPFAM CNNMOHGJEOB(IOJGCGILBEA<TGroup, TData> EHEJKPMEJGB);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PDBJMFLPFAM JGIBBDNPHCB(GCNLINAIFDH<TGroup, TData> EHEJKPMEJGB);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PDBJMFLPFAM MJBIGBKJFPP(EELNPEFHCGE<TGroup> EHEJKPMEJGB);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface DIPDKFGPFLL
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PDBJMFLPFAM> MDGNAJFCIMM(IDBCLKLJBMF EHEJKPMEJGB);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<PDBJMFLPFAM> CNNMOHGJEOB(NAGKELNLIII EHEJKPMEJGB);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class CIPPNIKBGNL<TGroup, TData> : LNOEDEGNKLI<HFEADICIKOC<TGroup, TData>, PDBJMFLPFAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly GCNLINAIFDH<TGroup, TData> EHEJKPMEJGB;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C6D9B0", Offset = "0x6C6C7B0", VA = "0x186C6D9B0")]
	public CIPPNIKBGNL(TGroup IFNKIBOFAPF, IEnumerable<TData> CPPEAAHODOM, HFEADICIKOC<TGroup, TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C6D8E0", Offset = "0x6C6C6E0", VA = "0x186C6D8E0", Slot = "4")]
	public override PDBJMFLPFAM NACBKBJFHJC()
	{
		return default(PDBJMFLPFAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GBHDPHKJPHC<TGroup, TData> : LNOEDEGNKLI<HFEADICIKOC<TGroup, TData>, PDBJMFLPFAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IOJGCGILBEA<TGroup, TData> EHEJKPMEJGB;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4FCCB90", Offset = "0x4FCB990", VA = "0x184FCCB90")]
	public GBHDPHKJPHC(TGroup IFNKIBOFAPF, TData DJCFGHGMGND, IEnumerable<TData> CPPEAAHODOM, HFEADICIKOC<TGroup, TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4FCCAB0", Offset = "0x4FCB8B0", VA = "0x184FCCAB0", Slot = "4")]
	public override PDBJMFLPFAM NACBKBJFHJC()
	{
		return default(PDBJMFLPFAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class FLIIMIAELLF<TGroup, TData> : LNOEDEGNKLI<HFEADICIKOC<TGroup, TData>, PDBJMFLPFAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EELNPEFHCGE<TGroup> EHEJKPMEJGB;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4F25B10", Offset = "0x4F24910", VA = "0x184F25B10")]
	public FLIIMIAELLF(TGroup IFNKIBOFAPF, HFEADICIKOC<TGroup, TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4F25A40", Offset = "0x4F24840", VA = "0x184F25A40", Slot = "4")]
	public override PDBJMFLPFAM NACBKBJFHJC()
	{
		return default(PDBJMFLPFAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class GFMMKHMDIMK<TGroup, TData> : LNOEDEGNKLI<HFEADICIKOC<TGroup, TData>, PDBJMFLPFAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IOJGCGILBEA<TGroup, TData> EHEJKPMEJGB;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4FCCB90", Offset = "0x4FCB990", VA = "0x184FCCB90")]
	public GFMMKHMDIMK(TGroup IFNKIBOFAPF, TData HKHCMIHCAEL, IEnumerable<TData> CPPEAAHODOM, HFEADICIKOC<TGroup, TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4FDFC30", Offset = "0x4FDEA30", VA = "0x184FDFC30", Slot = "4")]
	public override PDBJMFLPFAM NACBKBJFHJC()
	{
		return default(PDBJMFLPFAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CBNINAJOBFF : ADFPNLEMBJE<DIPDKFGPFLL, PDBJMFLPFAM>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct NAIINOMMPGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<PDBJMFLPFAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public CBNINAJOBFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<PDBJMFLPFAM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83E6AC0", Offset = "0x83E58C0", VA = "0x1883E6AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83E6D60", Offset = "0x83E5B60", VA = "0x1883E6D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private IDBCLKLJBMF EHEJKPMEJGB;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x83E5560", Offset = "0x83E4360", VA = "0x1883E5560")]
	public CBNINAJOBFF(IEnumerable<Guid> HDIPMMJNGHN, Guid PKHHECBGALP, bool BCIHJBLGHHE, DIPDKFGPFLL BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x83E5470", Offset = "0x83E4270", VA = "0x1883E5470", Slot = "4")]
	[AsyncStateMachine(typeof(NAIINOMMPGG))]
	public override Task<PDBJMFLPFAM> NACBKBJFHJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class EGHCCBHBMFK : ADFPNLEMBJE<DIPDKFGPFLL, PDBJMFLPFAM>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct PNJDCJMDAOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<PDBJMFLPFAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public EGHCCBHBMFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<PDBJMFLPFAM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83E6E50", Offset = "0x83E5C50", VA = "0x1883E6E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83E70F0", Offset = "0x83E5EF0", VA = "0x1883E70F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly NAGKELNLIII EHEJKPMEJGB;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x83E5BA0", Offset = "0x83E49A0", VA = "0x1883E5BA0")]
	public EGHCCBHBMFK(Guid PKHHECBGALP, bool BCIHJBLGHHE, DIPDKFGPFLL BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x83E5AB0", Offset = "0x83E48B0", VA = "0x1883E5AB0", Slot = "4")]
	[AsyncStateMachine(typeof(PNJDCJMDAOC))]
	public override Task<PDBJMFLPFAM> NACBKBJFHJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct BBCCHHCLOBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly EGNMMPPJIFC GHKDPLEGGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool ENMJOFLMOJJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x83E5380", Offset = "0x83E4180", VA = "0x1883E5380")]
	public BBCCHHCLOBB(EGNMMPPJIFC OKGCIHEKAHC, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface JEOKAGCONJL<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> NACBKBJFHJC(BBCCHHCLOBB PLCLOHLKJEA);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DKIKHIMEJEH<TSpawnType> : ADFPNLEMBJE<JEOKAGCONJL<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct OLNNOJJKDDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DKIKHIMEJEH<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5B27610", Offset = "0x5B26410", VA = "0x185B27610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4530A70", Offset = "0x452F870", VA = "0x184530A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BBCCHHCLOBB PLCLOHLKJEA;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4572DA0", Offset = "0x4571BA0", VA = "0x184572DA0")]
	public DKIKHIMEJEH(EGNMMPPJIFC OKGCIHEKAHC, bool BCIHJBLGHHE, JEOKAGCONJL<TSpawnType> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4572CA0", Offset = "0x4571AA0", VA = "0x184572CA0", Slot = "4")]
	[AsyncStateMachine(typeof(DKIKHIMEJEH<>.OLNNOJJKDDL))]
	public override Task<TSpawnType> NACBKBJFHJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct EGNMMPPJIFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool DDEAHJPJIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly Vector3 FLOOKCHBPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly Vector3 FEDKKAIHHLC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x83E5C80", Offset = "0x83E4A80", VA = "0x1883E5C80")]
	public EGNMMPPJIFC(Transform FLFAPEOCDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x83E5C50", Offset = "0x83E4A50", VA = "0x1883E5C50")]
	public EGNMMPPJIFC(Vector3 INIBGDOOLID, Vector3 FLAPAOJCDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x83E5C20", Offset = "0x83E4A20", VA = "0x1883E5C20")]
	public static EGNMMPPJIFC BKCDCCJFPOM()
	{
		return default(EGNMMPPJIFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x83E5CF0", Offset = "0x83E4AF0", VA = "0x1883E5CF0")]
	private EGNMMPPJIFC(bool FKFNLEOBKGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct KLDDJENGCOH<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TNode CMLKNEHNJJE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x55EF590", Offset = "0x55EE390", VA = "0x1855EF590")]
	public KLDDJENGCOH(TNode CMLKNEHNJJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct DJDMHDEPOEG<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TNode NHKBINADCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TReparentOperations LMOHAGBIALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public OEJHHEOJFAC PECGFHLIHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool ENMJOFLMOJJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4553250", Offset = "0x4552050", VA = "0x184553250")]
	public DJDMHDEPOEG(TNode NHKBINADCML, TReparentOperations LMOHAGBIALP, OEJHHEOJFAC PECGFHLIHGM, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface EKKOLBNIIIA<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPGIDENJOPA([In] KLDDJENGCOH<TNode> OCLKPAECAHF);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BJJKGGAKENA([In] DJDMHDEPOEG<TNode, TReparentOperations> BCAJINHPLFO);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ENPBAFCLIKB();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class AKIOHGEAPKC<TNode, TReparentOperations> : MFCEPHDDFHM<EKKOLBNIIIA<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C1C0", Offset = "0x4A3AFC0", VA = "0x184A3C1C0")]
	public AKIOHGEAPKC(EKKOLBNIIIA<TNode, TReparentOperations> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C170", Offset = "0x4A3AF70", VA = "0x184A3C170", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class MCEHCMMLEIE<TNode, TReparentOperations> : MFCEPHDDFHM<EKKOLBNIIIA<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly DJDMHDEPOEG<TNode, TReparentOperations> BCAJINHPLFO;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5891450", Offset = "0x5890250", VA = "0x185891450")]
	public MCEHCMMLEIE(TNode NHKBINADCML, TReparentOperations LMOHAGBIALP, OEJHHEOJFAC PECGFHLIHGM, EKKOLBNIIIA<TNode, TReparentOperations> BIJLHPHALFD, bool BCIHJBLGHHE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x54BD090", Offset = "0x54BBE90", VA = "0x1854BD090", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class OIAPEPGEMEM<TNode, TReparentOperations> : MFCEPHDDFHM<EKKOLBNIIIA<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly KLDDJENGCOH<TNode> OCLKPAECAHF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5ACEE00", Offset = "0x5ACDC00", VA = "0x185ACEE00")]
	public OIAPEPGEMEM(TNode CFKLKKNMKGJ, EKKOLBNIIIA<TNode, TReparentOperations> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3BC0", Offset = "0x4FF29C0", VA = "0x184FF3BC0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FKBOLPMDDPF<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public TSpawnInfo OAGCDMBOKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector3 FLAPAOJCDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Quaternion GKEKGHNHKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float KBAEKIALOKB;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4F17C80", Offset = "0x4F16A80", VA = "0x184F17C80")]
	public FKBOLPMDDPF(TSpawnInfo OAGCDMBOKPM, Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, float KBAEKIALOKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface HOKAIILAHKJ<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> FDOOJPECHHH([In] FKBOLPMDDPF<TSpawnInfo> GKHMNFECBBE, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class OBEJGIDGAEF<TSpawnType, TSpawnInfo> : ADFPNLEMBJE<HOKAIILAHKJ<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly FKBOLPMDDPF<TSpawnInfo> NPIEBNDMCBK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6540", Offset = "0x5AB5340", VA = "0x185AB6540")]
	public OBEJGIDGAEF(TSpawnInfo MOIDKCLLKMO, Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, float KBAEKIALOKB, HOKAIILAHKJ<TSpawnType, TSpawnInfo> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x54BC950", Offset = "0x54BB750", VA = "0x1854BC950", Slot = "4")]
	public override Task<TSpawnType> NACBKBJFHJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct KKPOPGFHDNF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> CBKPMMHBGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool ENMJOFLMOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool JMDJIBBGNCM;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x55EEE20", Offset = "0x55EDC20", VA = "0x1855EEE20")]
	public KKPOPGFHDNF(IEnumerable<TData> CPPEAAHODOM, bool BCIHJBLGHHE = false, bool FBNMHFLBIBK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface AHNFLDPBDPM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PDBJMFLPFAM> BDKNGEDLJFK([In] KKPOPGFHDNF<TData> FPFFEKGJCGO, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class JOEAKGBOAGF<TData> : ADFPNLEMBJE<AHNFLDPBDPM<TData>, PDBJMFLPFAM> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly KKPOPGFHDNF<TData> HADNDDCEJMM;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x54BCAD0", Offset = "0x54BB8D0", VA = "0x1854BCAD0")]
	public JOEAKGBOAGF(IEnumerable<TData> CPPEAAHODOM, bool BCIHJBLGHHE, AHNFLDPBDPM<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x54BC950", Offset = "0x54BB750", VA = "0x1854BC950", Slot = "4")]
	public override Task<PDBJMFLPFAM> NACBKBJFHJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct OHOPNLMFIHM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T BNIHAACOHPG;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5ACEAD0", Offset = "0x5ACD8D0", VA = "0x185ACEAD0")]
	public OHOPNLMFIHM(T GMHCHLNGAIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PBKOEPDJPHD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPGIDENJOPA([In] OHOPNLMFIHM<T> AMNLDMMGPJD);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BJJKGGAKENA();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface EPAKDLFGHLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NACBKBJFHJC([In] IPCOIFOOECP<T> KJLGODHLCPL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct IPCOIFOOECP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T BNIHAACOHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool LHHMMDEIPCD;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5235750", Offset = "0x5234550", VA = "0x185235750")]
	public IPCOIFOOECP(T GMHCHLNGAIL, bool CLNMPNKCNEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FBGKIPAMEGG<T> : MFCEPHDDFHM<PBKOEPDJPHD<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C1C0", Offset = "0x4A3AFC0", VA = "0x184A3C1C0")]
	public FBGKIPAMEGG(PBKOEPDJPHD<T> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4EF72C0", Offset = "0x4EF60C0", VA = "0x184EF72C0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class GIBOPCPAGBH<T> : MFCEPHDDFHM<PBKOEPDJPHD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly OHOPNLMFIHM<T> AMNLDMMGPJD;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3C80", Offset = "0x4FF2A80", VA = "0x184FF3C80")]
	public GIBOPCPAGBH(T BNIHAACOHPG, PBKOEPDJPHD<T> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3BC0", Offset = "0x4FF29C0", VA = "0x184FF3BC0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class OKKHNNGHLMB<T> : MFCEPHDDFHM<EPAKDLFGHLI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly IPCOIFOOECP<T> KJLGODHLCPL;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7000", Offset = "0x5AD5E00", VA = "0x185AD7000")]
	public OKKHNNGHLMB(T BNIHAACOHPG, bool CLNMPNKCNEE, EPAKDLFGHLI<T> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3BC0", Offset = "0x4FF29C0", VA = "0x184FF3BC0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct BCOENHAKJON<TData> where TData : notnull, DKPOOLFNAIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> CBKPMMHBGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool DIDDPEBIEAL;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x66001F0", Offset = "0x65FEFF0", VA = "0x1866001F0")]
	public BCOENHAKJON(IEnumerable<TData> AKKNKCKGEEN, bool HFADFOELIIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct PMLEEEHKEFE<TData> where TData : notnull, DKPOOLFNAIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public List<TData> CBKPMMHBGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public List<bool> JMOCCMEMEJE;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5C100B0", Offset = "0x5C0EEB0", VA = "0x185C100B0")]
	public PMLEEEHKEFE(List<TData> AKKNKCKGEEN, List<bool> EPIEFBHNFOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface DKPOOLFNAIB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool MJPLPFFKIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface LGMPOKANIPM<TData> where TData : DKPOOLFNAIB
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NACBKBJFHJC([In] BCOENHAKJON<TData> OCICGOOFJFM);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NACBKBJFHJC([In] PMLEEEHKEFE<TData> OCICGOOFJFM);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface HBCLMKLJCHJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EPLHPEGNDJK(T BNIHAACOHPG);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class BJJPBLBPDKC<TData> : MFCEPHDDFHM<LGMPOKANIPM<TData>> where TData : notnull, DKPOOLFNAIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly BCOENHAKJON<TData> OCICGOOFJFM;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x66FA880", Offset = "0x66F9680", VA = "0x1866FA880")]
	public BJJPBLBPDKC(List<TData> CPPEAAHODOM, bool DIDDPEBIEAL, LGMPOKANIPM<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3BC0", Offset = "0x4FF29C0", VA = "0x184FF3BC0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class KEFALGKBMDB<TData> : MFCEPHDDFHM<LGMPOKANIPM<TData>> where TData : notnull, DKPOOLFNAIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PMLEEEHKEFE<TData> OCICGOOFJFM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x55D0A40", Offset = "0x55CF840", VA = "0x1855D0A40")]
	public KEFALGKBMDB(List<TData> CPPEAAHODOM, List<bool> JMOCCMEMEJE, LGMPOKANIPM<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x55D0980", Offset = "0x55CF780", VA = "0x1855D0980", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface PIJKIIJCALA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PDBJMFLPFAM> NACBKBJFHJC(FFAPELIKKBO<TData> GGPHAKFMCFN);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class LCGNGKALAKD<TData> : ADFPNLEMBJE<PIJKIIJCALA<TData>, PDBJMFLPFAM> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct NFJMJIAIJDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<PDBJMFLPFAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public LCGNGKALAKD<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter<PDBJMFLPFAM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x59708C0", Offset = "0x596F6C0", VA = "0x1859708C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5970BB0", Offset = "0x596F9B0", VA = "0x185970BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly FFAPELIKKBO<TData> JFJCGPHLAIF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x567A2C0", Offset = "0x56790C0", VA = "0x18567A2C0")]
	public LCGNGKALAKD(TData HNOODDEIFJK, IReadOnlyList<TData> PPBMKBEBNKA, bool BCIHJBLGHHE, PIJKIIJCALA<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x567A1C0", Offset = "0x5678FC0", VA = "0x18567A1C0", Slot = "4")]
	[AsyncStateMachine(typeof(LCGNGKALAKD<>.NFJMJIAIJDJ))]
	public override Task<PDBJMFLPFAM> NACBKBJFHJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct FFAPELIKKBO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public TData FJINKHAIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IReadOnlyList<TData> HLCJOKFBLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool ENMJOFLMOJJ;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3065C70", Offset = "0x3064A70", VA = "0x183065C70")]
	public FFAPELIKKBO(TData HNOODDEIFJK, IReadOnlyList<TData> PPBMKBEBNKA, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface CIANBEBFDGH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NACBKBJFHJC([In] KKEAPBLEIMP<TData> AOOJGEIAFJO);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface MDGPANHCELM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NACBKBJFHJC([In] NIFEMFBBEMD<TData> AOOJGEIAFJO);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface GNJOMMLLNOG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CGKHIFHACKM([In] IAGNNBIHOCI<TData> AOOJGEIAFJO);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJJKGGAKENA();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class HNOGMCIHLMI<TData> : MFCEPHDDFHM<CIANBEBFDGH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly KKEAPBLEIMP<TData> AOOJGEIAFJO;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x513B3B0", Offset = "0x513A1B0", VA = "0x18513B3B0")]
	public HNOGMCIHLMI(IEnumerable<TData> CPPEAAHODOM, BEIEMLGIDNI BGBIPHDMBPB, PFNNFGPAHBA GKIFPALLDIK, float IDDADLBOLCF, string? ECFOLMEBCEO, bool FPLDKKDBOHD, bool BCIHJBLGHHE, CIANBEBFDGH<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3BC0", Offset = "0x4FF29C0", VA = "0x184FF3BC0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class BKOGOFMJHMJ<TData> : MFCEPHDDFHM<MDGPANHCELM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NIFEMFBBEMD<TData> AOOJGEIAFJO;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x66FDE70", Offset = "0x66FCC70", VA = "0x1866FDE70")]
	public BKOGOFMJHMJ(TData[] CPPEAAHODOM, BEIEMLGIDNI[] BGBIPHDMBPB, PFNNFGPAHBA[] GKIFPALLDIK, float[] IDDADLBOLCF, MDGPANHCELM<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x55D0AD0", Offset = "0x55CF8D0", VA = "0x1855D0AD0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LIPICMAFNLO<TData> : MFCEPHDDFHM<GNJOMMLLNOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C1C0", Offset = "0x4A3AFC0", VA = "0x184A3C1C0")]
	public LIPICMAFNLO(GNJOMMLLNOG<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x56926D0", Offset = "0x56914D0", VA = "0x1856926D0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class KEFIPEMBJEA<TData> : MFCEPHDDFHM<GNJOMMLLNOG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly IAGNNBIHOCI<TData> AOOJGEIAFJO;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x55D0B90", Offset = "0x55CF990", VA = "0x1855D0B90")]
	public KEFIPEMBJEA(IEnumerable<TData> CPPEAAHODOM, BEIEMLGIDNI BGBIPHDMBPB, PFNNFGPAHBA GKIFPALLDIK, float IDDADLBOLCF, GNJOMMLLNOG<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x55D0AD0", Offset = "0x55CF8D0", VA = "0x1855D0AD0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct KKEAPBLEIMP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public IEnumerable<TData> CBKPMMHBGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public BEIEMLGIDNI MDANDEECNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public PFNNFGPAHBA FJEHDIIFJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float COJIMGECPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public string? PHKHFNAGCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool? NEFPCEDOJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool ENMJOFLMOJJ;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x55EE500", Offset = "0x55ED300", VA = "0x1855EE500")]
	public KKEAPBLEIMP(IEnumerable<TData> CPPEAAHODOM, BEIEMLGIDNI BGBIPHDMBPB, PFNNFGPAHBA GKIFPALLDIK, float IDDADLBOLCF, string? ECFOLMEBCEO, bool? FPLDKKDBOHD, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct NIFEMFBBEMD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public TData[] CBKPMMHBGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public BEIEMLGIDNI[] MDANDEECNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public PFNNFGPAHBA[] FJEHDIIFJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float[] IDDADLBOLCF;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5984CB0", Offset = "0x5983AB0", VA = "0x185984CB0")]
	public NIFEMFBBEMD(TData[] CPPEAAHODOM, BEIEMLGIDNI[] BGBIPHDMBPB, PFNNFGPAHBA[] GKIFPALLDIK, float[] IDDADLBOLCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct IAGNNBIHOCI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public IEnumerable<TData> CBKPMMHBGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public BEIEMLGIDNI MDANDEECNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public PFNNFGPAHBA FJEHDIIFJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float IDDADLBOLCF;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5205C40", Offset = "0x5204A40", VA = "0x185205C40")]
	public IAGNNBIHOCI(IEnumerable<TData> CPPEAAHODOM, BEIEMLGIDNI BGBIPHDMBPB, PFNNFGPAHBA GKIFPALLDIK, float IDDADLBOLCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface BIHBNOOCKLG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGIBBDNPHCB([In] FABKDFIABDJ<TData> FPFFEKGJCGO);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJBIGBKJFPP([In] FABKDFIABDJ<TData> FPFFEKGJCGO);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NKDBABACJEK([In] bool LFCOMGPIPKK);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JFOEGGAGMIB([In] FABKDFIABDJ<TData> FPFFEKGJCGO);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNAABCPMCLH();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KKCNLDAGFGB([In] TData EGFMBHDPLBP);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class OLNAEFPPBJB<TData> : MFCEPHDDFHM<BIHBNOOCKLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly FABKDFIABDJ<TData> FPFFEKGJCGO;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5B27010", Offset = "0x5B25E10", VA = "0x185B27010")]
	public OLNAEFPPBJB(List<TData> LJHCADEPBBK, BIHBNOOCKLG<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3BC0", Offset = "0x4FF29C0", VA = "0x184FF3BC0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class HHONKEJKKEM<TData> : MFCEPHDDFHM<BIHBNOOCKLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C1C0", Offset = "0x4A3AFC0", VA = "0x184A3C1C0")]
	public HHONKEJKKEM(BIHBNOOCKLG<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x50B0400", Offset = "0x50AF200", VA = "0x1850B0400", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class BNIFNOAADOL<TData> : MFCEPHDDFHM<BIHBNOOCKLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly bool BCIHJBLGHHE;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x68CDAF0", Offset = "0x68CC8F0", VA = "0x1868CDAF0")]
	public BNIFNOAADOL(bool BCIHJBLGHHE, BIHBNOOCKLG<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x68CDA90", Offset = "0x68CC890", VA = "0x1868CDA90", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class LHAEPFKFOGF<TData> : MFCEPHDDFHM<BIHBNOOCKLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly FABKDFIABDJ<TData> FPFFEKGJCGO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x56869C0", Offset = "0x56857C0", VA = "0x1856869C0")]
	public LHAEPFKFOGF(List<TData> LJHCADEPBBK, bool BCIHJBLGHHE, BIHBNOOCKLG<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x55D0980", Offset = "0x55CF780", VA = "0x1855D0980", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class DOFECCHECHJ<TData> : MFCEPHDDFHM<BIHBNOOCKLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly TData EGFMBHDPLBP;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x45B4A00", Offset = "0x45B3800", VA = "0x1845B4A00")]
	public DOFECCHECHJ(TData EGFMBHDPLBP, BIHBNOOCKLG<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x45B4930", Offset = "0x45B3730", VA = "0x1845B4930", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class LMAAGEGDJKK<TData> : MFCEPHDDFHM<BIHBNOOCKLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly FABKDFIABDJ<TData> FPFFEKGJCGO;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x569C9E0", Offset = "0x569B7E0", VA = "0x18569C9E0")]
	public LMAAGEGDJKK(IEnumerable<TData> LJHCADEPBBK, BIHBNOOCKLG<TData> BIJLHPHALFD, bool BCIHJBLGHHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x569C870", Offset = "0x569B670", VA = "0x18569C870", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct FABKDFIABDJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public IEnumerable<TData> CBKPMMHBGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public bool BCIHJBLGHHE;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4EE1950", Offset = "0x4EE0750", VA = "0x184EE1950")]
	public FABKDFIABDJ(IEnumerable<TData> AKKNKCKGEEN, bool HKPADAGKIHK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface JHHMLFEEPDA
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PDBJMFLPFAM> NACBKBJFHJC(DCLIKFCCAFN JPNKKNAPCOE);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class CMKCINMIFDL : ADFPNLEMBJE<JHHMLFEEPDA, PDBJMFLPFAM>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct DKGFKPCFALM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<PDBJMFLPFAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CMKCINMIFDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<PDBJMFLPFAM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83E57B0", Offset = "0x83E45B0", VA = "0x1883E57B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83E5A30", Offset = "0x83E4830", VA = "0x1883E5A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly DCLIKFCCAFN EGJDAKCMGCG;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x83E5750", Offset = "0x83E4550", VA = "0x1883E5750")]
	public CMKCINMIFDL(bool BCIHJBLGHHE, JHHMLFEEPDA BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x83E5660", Offset = "0x83E4460", VA = "0x1883E5660", Slot = "4")]
	[AsyncStateMachine(typeof(DKGFKPCFALM))]
	public override Task<PDBJMFLPFAM> NACBKBJFHJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct DCLIKFCCAFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool ENMJOFLMOJJ;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2D58AB0", Offset = "0x2D578B0", VA = "0x182D58AB0")]
	public DCLIKFCCAFN(bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct DNAJLBFGMOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool INMFDLOGJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool JHMLJAOGODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly bool KBAEKIALOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool BCIHJBLGHHE;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x628FA50", Offset = "0x628E850", VA = "0x18628FA50")]
	public DNAJLBFGMOE(bool INMFDLOGJAD, bool JHMLJAOGODL, bool KBAEKIALOKB, bool BCIHJBLGHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x83E5AA0", Offset = "0x83E48A0", VA = "0x1883E5AA0")]
	public DNAJLBFGMOE(bool JHMLJAOGODL, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface KGBHHIGDKPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMOKMNAOLPO(DNAJLBFGMOE NPMNKNKPFCI);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DHDJIAGKBCA(DNAJLBFGMOE NPMNKNKPFCI);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class GIHLGJBGPLN : MFCEPHDDFHM<KGBHHIGDKPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly DNAJLBFGMOE NPMNKNKPFCI;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x83E5EF0", Offset = "0x83E4CF0", VA = "0x1883E5EF0")]
	public GIHLGJBGPLN(bool DNNOOFELIOA, bool JHMLJAOGODL, bool KBAEKIALOKB, bool BCIHJBLGHHE, KGBHHIGDKPJ BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x83E5EA0", Offset = "0x83E4CA0", VA = "0x1883E5EA0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class BGBEAHLBDCG : MFCEPHDDFHM<KGBHHIGDKPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly DNAJLBFGMOE NPMNKNKPFCI;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x83E53F0", Offset = "0x83E41F0", VA = "0x1883E53F0")]
	public BGBEAHLBDCG(bool JHMLJAOGODL, bool BCIHJBLGHHE, KGBHHIGDKPJ BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x83E53A0", Offset = "0x83E41A0", VA = "0x1883E53A0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface FMCGKBGEHNI
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NACBKBJFHJC([In] LGIPKIJKBMJ BBLFKGKLEND);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GNLJAKGAJMJ : MFCEPHDDFHM<FMCGKBGEHNI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LGIPKIJKBMJ BBLFKGKLEND;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x83E6030", Offset = "0x83E4E30", VA = "0x1883E6030")]
	public GNLJAKGAJMJ(Guid[] OMLNNADMCCK, Vector3[] KAFJGKEFDLO, Quaternion[] JBGPJPNIHBE, float[] LJBBPOEBNKP, Dictionary<Guid, Vector3> IDCEOMBHIML, FMCGKBGEHNI BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x83E5F80", Offset = "0x83E4D80", VA = "0x1883E5F80", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface DGLHNJCNFOH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPGIDENJOPA([In] OFIIMFACDMH<TData> OCLKPAECAHF);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CGKHIFHACKM([In] HMGODCHIHDI BPLPKPBPGFL);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CGKHIFHACKM([In] HIEFFLFKMKL BPLPKPBPGFL);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BJJKGGAKENA();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class FHMJJGFLGFB<TData> : MFCEPHDDFHM<DGLHNJCNFOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C1C0", Offset = "0x4A3AFC0", VA = "0x184A3C1C0")]
	public FHMJJGFLGFB(DGLHNJCNFOH<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4F0BF30", Offset = "0x4F0AD30", VA = "0x184F0BF30", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class LLABOBIDIJE<TData> : MFCEPHDDFHM<DGLHNJCNFOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly HMGODCHIHDI GBBJEPEFFJC;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5699E60", Offset = "0x5698C60", VA = "0x185699E60")]
	public LLABOBIDIJE(Vector3 KBELKFOBEGH, bool HOGFHCFLEIH, DGLHNJCNFOH<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C430", Offset = "0x4A3B230", VA = "0x184A3C430", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class IAHJAANAICP<TData> : MFCEPHDDFHM<DGLHNJCNFOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly HIEFFLFKMKL GBBJEPEFFJC;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5205DB0", Offset = "0x5204BB0", VA = "0x185205DB0")]
	public IAHJAANAICP(Guid GKOBFLFIEAM, int JJJJBEGKNIN, Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, float GDMMFIOGDOL, bool HOGFHCFLEIH, DGLHNJCNFOH<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5205D50", Offset = "0x5204B50", VA = "0x185205D50", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class JEOMBFDIJLK<TData> : MFCEPHDDFHM<DGLHNJCNFOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly OFIIMFACDMH<TData> GBBJEPEFFJC;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x545DA60", Offset = "0x545C860", VA = "0x18545DA60")]
	public JEOMBFDIJLK(TData BNIHAACOHPG, bool BCIHJBLGHHE, DGLHNJCNFOH<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3BC0", Offset = "0x4FF29C0", VA = "0x184FF3BC0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct HMGODCHIHDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Vector3 KBELKFOBEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly bool HOGFHCFLEIH;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x83E6250", Offset = "0x83E5050", VA = "0x1883E6250")]
	public HMGODCHIHDI(Vector3 KBELKFOBEGH, bool HOGFHCFLEIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct HIEFFLFKMKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Guid GKOBFLFIEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly int JJJJBEGKNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Vector3 FLAPAOJCDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Quaternion GKEKGHNHKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly float GDMMFIOGDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool HOGFHCFLEIH;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x83E6210", Offset = "0x83E5010", VA = "0x1883E6210")]
	public HIEFFLFKMKL(Guid GKOBFLFIEAM, int JJJJBEGKNIN, Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, float GDMMFIOGDOL, bool HOGFHCFLEIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct OFIIMFACDMH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly TData BNIHAACOHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly bool BCIHJBLGHHE;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5ABFEA0", Offset = "0x5ABECA0", VA = "0x185ABFEA0")]
	public OFIIMFACDMH(TData BNIHAACOHPG, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface KIIAHEJLNPJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NACBKBJFHJC([In] FCEABMIGEJF<TData> KNLMCJIGNGO);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NACBKBJFHJC([In] KJCIBOHHPJP<TData> KNLMCJIGNGO);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface FKEOBFAMGIN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPGIDENJOPA([In] MGGCDAEGAEP<TData> NEANNNKKEAP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CGKHIFHACKM([In] FDGMFFHLGCK BPLPKPBPGFL);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BJJKGGAKENA();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class LBJNFAJDPOE<TData> : MFCEPHDDFHM<KIIAHEJLNPJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly FCEABMIGEJF<TData> KNLMCJIGNGO;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5676310", Offset = "0x5675110", VA = "0x185676310")]
	public LBJNFAJDPOE(IEnumerable<TData> CPPEAAHODOM, Vector3 GAHKEJLIHGF, bool BCIHJBLGHHE, KIIAHEJLNPJ<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3BC0", Offset = "0x4FF29C0", VA = "0x184FF3BC0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class LHLLPBKFEGC<TData> : MFCEPHDDFHM<FKEOBFAMGIN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C1C0", Offset = "0x4A3AFC0", VA = "0x184A3C1C0")]
	public LHLLPBKFEGC(FKEOBFAMGIN<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C170", Offset = "0x4A3AF70", VA = "0x184A3C170", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class OLEJMLGAAGA<TData> : MFCEPHDDFHM<FKEOBFAMGIN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MGGCDAEGAEP<TData> KNLMCJIGNGO;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8640", Offset = "0x5AD7440", VA = "0x185AD8640")]
	public OLEJMLGAAGA(IEnumerable<TData> CPPEAAHODOM, bool BCIHJBLGHHE, FKEOBFAMGIN<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3BC0", Offset = "0x4FF29C0", VA = "0x184FF3BC0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class JONOAPFFJLI<TData> : MFCEPHDDFHM<KIIAHEJLNPJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly KJCIBOHHPJP<TData> KNLMCJIGNGO;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x54BD160", Offset = "0x54BBF60", VA = "0x1854BD160")]
	public JONOAPFFJLI(IEnumerable<TData> CPPEAAHODOM, Vector3 CMBJIIFNKHE, HDIOPAFOJOE OFKJCKMPMNM, bool BCIHJBLGHHE, KIIAHEJLNPJ<TData> BIJLHPHALFD, Space DMDOFONNAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x54BD090", Offset = "0x54BBE90", VA = "0x1854BD090", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class HKLGIHJMGNE<TData> : MFCEPHDDFHM<FKEOBFAMGIN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly FDGMFFHLGCK KNLMCJIGNGO;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x50BAC60", Offset = "0x50B9A60", VA = "0x1850BAC60")]
	public HKLGIHJMGNE(Vector3 GAHKEJLIHGF, FKEOBFAMGIN<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C430", Offset = "0x4A3B230", VA = "0x184A3C430", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct FCEABMIGEJF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly IEnumerable<TData> CPPEAAHODOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3 GAHKEJLIHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool BCIHJBLGHHE;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4EF8440", Offset = "0x4EF7240", VA = "0x184EF8440")]
	public FCEABMIGEJF(IEnumerable<TData> CPPEAAHODOM, Vector3 GAHKEJLIHGF, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct MGGCDAEGAEP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly IEnumerable<TData> CPPEAAHODOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly bool BCIHJBLGHHE;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x58A75C0", Offset = "0x58A63C0", VA = "0x1858A75C0")]
	public MGGCDAEGAEP(IEnumerable<TData> CPPEAAHODOM, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct KJCIBOHHPJP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly IEnumerable<TData> CPPEAAHODOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 CMBJIIFNKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly HDIOPAFOJOE OFKJCKMPMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool BCIHJBLGHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Space DMDOFONNAPM;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x55EA4B0", Offset = "0x55E92B0", VA = "0x1855EA4B0")]
	public KJCIBOHHPJP(IEnumerable<TData> CPPEAAHODOM, Vector3 CMBJIIFNKHE, HDIOPAFOJOE OFKJCKMPMNM, bool BCIHJBLGHHE, Space DMDOFONNAPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct FDGMFFHLGCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Vector3 GAHKEJLIHGF;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2D56490", Offset = "0x2D55290", VA = "0x182D56490")]
	public FDGMFFHLGCK(Vector3 GAHKEJLIHGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public enum HDIOPAFOJOE
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface KLDKCOMOHJA
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NACBKBJFHJC([In] GLGPAKHKLMP ODBBLIMJGMG);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class FFPIKMIEIII : MFCEPHDDFHM<KLDKCOMOHJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly GLGPAKHKLMP ODBBLIMJGMG;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x83E5E40", Offset = "0x83E4C40", VA = "0x1883E5E40")]
	public FFPIKMIEIII(bool BCIHJBLGHHE, KLDKCOMOHJA BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x83E5D90", Offset = "0x83E4B90", VA = "0x1883E5D90", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct GLGPAKHKLMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly bool BCIHJBLGHHE;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D58AB0", Offset = "0x2D578B0", VA = "0x182D58AB0")]
	public GLGPAKHKLMP(bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface KBKNDFHJCNO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NACBKBJFHJC([In] GEOKPCHPJBK<TData> GGGLIGABCNI);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NACBKBJFHJC([In] IDAOKNOLIPJ<TData> GGGLIGABCNI);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface DJIIEBCBIIB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPGIDENJOPA([In] FKAMKFHNNEC<TData> OCLKPAECAHF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CGKHIFHACKM([In] LEJAEKMLHIM BPLPKPBPGFL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BJJKGGAKENA();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class PCHBAGNFONH<TData> : MFCEPHDDFHM<KBKNDFHJCNO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly GEOKPCHPJBK<TData> GGGLIGABCNI;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0DC0", Offset = "0x5BEFBC0", VA = "0x185BF0DC0")]
	public PCHBAGNFONH(IEnumerable<TData> CPPEAAHODOM, Quaternion GAHKEJLIHGF, Vector3? AEDCOLJNMIF, bool NKOHPLNEEKO, bool BCIHJBLGHHE, KBKNDFHJCNO<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3BC0", Offset = "0x4FF29C0", VA = "0x184FF3BC0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class EBLAJIAHGOD<TData> : MFCEPHDDFHM<DJIIEBCBIIB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C1C0", Offset = "0x4A3AFC0", VA = "0x184A3C1C0")]
	public EBLAJIAHGOD(DJIIEBCBIIB<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C170", Offset = "0x4A3AF70", VA = "0x184A3C170", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class AIAIKNHJGCH<TData> : MFCEPHDDFHM<DJIIEBCBIIB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly FKAMKFHNNEC<TData> GGGLIGABCNI;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x52A02A0", Offset = "0x529F0A0", VA = "0x1852A02A0")]
	public AIAIKNHJGCH(IEnumerable<TData> CPPEAAHODOM, bool BCIHJBLGHHE, DJIIEBCBIIB<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3BC0", Offset = "0x4FF29C0", VA = "0x184FF3BC0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class KCIOLMAIPEK<TData> : MFCEPHDDFHM<KBKNDFHJCNO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly IDAOKNOLIPJ<TData> GGGLIGABCNI;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x55C4010", Offset = "0x55C2E10", VA = "0x1855C4010")]
	public KCIOLMAIPEK(IEnumerable<TData> CPPEAAHODOM, Quaternion PEGNMJDADJL, HDIOPAFOJOE GIHFLCGHHBK, Vector3? AEDCOLJNMIF, bool NKOHPLNEEKO, bool BCIHJBLGHHE, Space DMDOFONNAPM, KBKNDFHJCNO<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x54BD090", Offset = "0x54BBE90", VA = "0x1854BD090", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class EDJPCCMDDGB<TData> : MFCEPHDDFHM<DJIIEBCBIIB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly LEJAEKMLHIM GGGLIGABCNI;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C490", Offset = "0x4A3B290", VA = "0x184A3C490")]
	public EDJPCCMDDGB(Quaternion GAHKEJLIHGF, Vector3? AEDCOLJNMIF, bool NKOHPLNEEKO, DJIIEBCBIIB<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C430", Offset = "0x4A3B230", VA = "0x184A3C430", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct GEOKPCHPJBK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly IEnumerable<TData> CPPEAAHODOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Quaternion GAHKEJLIHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3? AEDCOLJNMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool NKOHPLNEEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool BCIHJBLGHHE;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4FD9B90", Offset = "0x4FD8990", VA = "0x184FD9B90")]
	public GEOKPCHPJBK(IEnumerable<TData> CPPEAAHODOM, Quaternion GAHKEJLIHGF, Vector3? AEDCOLJNMIF, bool NKOHPLNEEKO, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct FKAMKFHNNEC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly IEnumerable<TData> CPPEAAHODOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool BCIHJBLGHHE;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4F17570", Offset = "0x4F16370", VA = "0x184F17570")]
	public FKAMKFHNNEC(IEnumerable<TData> CPPEAAHODOM, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct IDAOKNOLIPJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly IEnumerable<TData> CPPEAAHODOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Quaternion PEGNMJDADJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly HDIOPAFOJOE GIHFLCGHHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly Vector3? AEDCOLJNMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool NKOHPLNEEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool BCIHJBLGHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Space DMDOFONNAPM;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x520BE50", Offset = "0x520AC50", VA = "0x18520BE50")]
	public IDAOKNOLIPJ(IEnumerable<TData> CPPEAAHODOM, Quaternion PEGNMJDADJL, HDIOPAFOJOE GIHFLCGHHBK, Vector3? AEDCOLJNMIF, bool NKOHPLNEEKO, bool BCIHJBLGHHE, Space DMDOFONNAPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct LEJAEKMLHIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion GAHKEJLIHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Vector3? AEDCOLJNMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool NKOHPLNEEKO;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6256060", Offset = "0x6254E60", VA = "0x186256060")]
	public LEJAEKMLHIM(Quaternion GAHKEJLIHGF, Vector3? AEDCOLJNMIF, bool NKOHPLNEEKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface ODHPGBEFOOM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPGIDENJOPA([In] MMODEJEEKJK<TData> OCLKPAECAHF);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CGKHIFHACKM([In] EGKHJGNKHHH BPLPKPBPGFL);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CGKHIFHACKM([In] FEOCEMHJMDE BPLPKPBPGFL);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CGKHIFHACKM([In] CDIFACDDDLO BPLPKPBPGFL);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BJJKGGAKENA();
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class IHBIPLHJEPB<TData> : MFCEPHDDFHM<ODHPGBEFOOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly CDIFACDDDLO NKJFOEKIDMG;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5214880", Offset = "0x5213680", VA = "0x185214880")]
	public IHBIPLHJEPB(Vector3 LKBOPDKMJMM, float IMDFPOKEEGC, Vector3 AEDCOLJNMIF, bool MOFCINBJELB, bool EIBJPEKHHAC, ODHPGBEFOOM<TData> BIJLHPHALFD, Space DMDOFONNAPM = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5214820", Offset = "0x5213620", VA = "0x185214820", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class ENEOCOGNKCK<TData> : MFCEPHDDFHM<ODHPGBEFOOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C1C0", Offset = "0x4A3AFC0", VA = "0x184A3C1C0")]
	public ENEOCOGNKCK(ODHPGBEFOOM<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4A788D0", Offset = "0x4A776D0", VA = "0x184A788D0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class GMAMMLNJEIK<TData> : MFCEPHDDFHM<ODHPGBEFOOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly MMODEJEEKJK<TData> NKJFOEKIDMG;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5008A00", Offset = "0x5007800", VA = "0x185008A00")]
	public GMAMMLNJEIK(IEnumerable<TData> CPPEAAHODOM, bool BCIHJBLGHHE, ODHPGBEFOOM<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3BC0", Offset = "0x4FF29C0", VA = "0x184FF3BC0", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class BFLNKNHJIEB<TData> : MFCEPHDDFHM<ODHPGBEFOOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly FEOCEMHJMDE NKJFOEKIDMG;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x66E8800", Offset = "0x66E7600", VA = "0x1866E8800")]
	public BFLNKNHJIEB(float OMODHFAHFGB, bool DIOOOEFODBG, Vector3 AEDCOLJNMIF, ODHPGBEFOOM<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x66E8730", Offset = "0x66E7530", VA = "0x1866E8730", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class ONPLAMEEKJJ<TData> : MFCEPHDDFHM<ODHPGBEFOOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly EGKHJGNKHHH NKJFOEKIDMG;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5B2AC00", Offset = "0x5B29A00", VA = "0x185B2AC00")]
	public ONPLAMEEKJJ(float IMDFPOKEEGC, Vector3 AEDCOLJNMIF, ODHPGBEFOOM<TData> BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C430", Offset = "0x4A3B230", VA = "0x184A3C430", Slot = "4")]
	public override bool NACBKBJFHJC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct CDIFACDDDLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 LKBOPDKMJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float IMDFPOKEEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 AEDCOLJNMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool HOGFHCFLEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly Space DMDOFONNAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool EIBJPEKHHAC;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x83E5620", Offset = "0x83E4420", VA = "0x1883E5620")]
	public CDIFACDDDLO(Vector3 LKBOPDKMJMM, float IMDFPOKEEGC, Vector3 AEDCOLJNMIF, bool HOGFHCFLEIH, bool PDADHKPBEDK, Space DMDOFONNAPM = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct MMODEJEEKJK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly IEnumerable<TData> CPPEAAHODOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly bool BCIHJBLGHHE;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x58FFCA0", Offset = "0x58FEAA0", VA = "0x1858FFCA0")]
	public MMODEJEEKJK(IEnumerable<TData> CPPEAAHODOM, bool BCIHJBLGHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct FEOCEMHJMDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly float OMODHFAHFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly bool DIOOOEFODBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Vector3 AEDCOLJNMIF;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x83E5D70", Offset = "0x83E4B70", VA = "0x1883E5D70")]
	public FEOCEMHJMDE(float OMODHFAHFGB, bool DIOOOEFODBG, Vector3 AEDCOLJNMIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct EGKHJGNKHHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly float IMDFPOKEEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly Vector3 AEDCOLJNMIF;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6216B90", Offset = "0x6215990", VA = "0x186216B90")]
	public EGKHJGNKHHH(float IMDFPOKEEGC, Vector3 AEDCOLJNMIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct LGIPKIJKBMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly Guid[] CPPEAAHODOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly bool OGJHMDEIPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly bool LDFKOHOFPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly bool JCEJKHGFDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly Vector3[] KAFJGKEFDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Quaternion[] JBGPJPNIHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly float[] LJBBPOEBNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly Dictionary<Guid, Vector3> IDCEOMBHIML;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x83E6830", Offset = "0x83E5630", VA = "0x1883E6830")]
	public LGIPKIJKBMJ(Guid[] OMLNNADMCCK, Vector3[] KAFJGKEFDLO, Quaternion[] JBGPJPNIHBE, float[] LJBBPOEBNKP, Dictionary<Guid, Vector3> IDCEOMBHIML, bool OGJHMDEIPAL = true, bool LDFKOHOFPHM = true, bool JCEJKHGFDMI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x83E6660", Offset = "0x83E5460", VA = "0x1883E6660")]
	private static void CGDOGONLECC(Dictionary<Guid, Vector3> IDCEOMBHIML, int LPLHJAHBOEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class IHCKEPNJJOE
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct NKKNIGOAMGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool NOJPLPCECFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public HJFNEHLLJBB MCKFJKLOMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public HJFNEHLLJBB GGPMKPLIBLI;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static NKKNIGOAMGI IENDAGIBHCL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken BIKAJNDLCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x83E6310", Offset = "0x83E5110", VA = "0x1883E6310")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static HJFNEHLLJBB MCKFJKLOMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x83E6380", Offset = "0x83E5180", VA = "0x1883E6380")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x83E62B0", Offset = "0x83E50B0", VA = "0x1883E62B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x83E6570", Offset = "0x83E5370", VA = "0x1883E6570")]
	[NKOKDPHOKEP.KIGECJIBHBL]
	internal static void NCFBCDNFMCP(HJFNEHLLJBB JBOLEFNOICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x83E6420", Offset = "0x83E5220", VA = "0x1883E6420")]
	public static void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x83E6330", Offset = "0x83E5130", VA = "0x1883E6330")]
	private static HJFNEHLLJBB FMMLHEAFFJB(HJFNEHLLJBB GNJEHMEOCCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class EAAOBMNKIKB
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum CJCPBNHOGPF
	{
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3B75F00", Offset = "0x3B74D00", VA = "0x183B75F00")]
	public static void JCKMNAHKFMP<T>(T HNKFODIAFKO, CJCPBNHOGPF ADGMECOLKNH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3B76040", Offset = "0x3B74E40", VA = "0x183B76040")]
	public static void JCKMNAHKFMP<T>(T HNKFODIAFKO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3B75E20", Offset = "0x3B74C20", VA = "0x183B75E20")]
	public static void JCKMNAHKFMP<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3B760A0", Offset = "0x3B74EA0", VA = "0x183B760A0")]
	public static void MANFPIDOHMD<T>(T HNKFODIAFKO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3B75D80", Offset = "0x3B74B80", VA = "0x183B75D80")]
	public static T DPMBHNJHJDJ<T>(CJCPBNHOGPF ADGMECOLKNH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3B75BB0", Offset = "0x3B749B0", VA = "0x183B75BB0")]
	public static bool DDAKMEGCLEF<T>(CJCPBNHOGPF ADGMECOLKNH, T? FHMNLAOMLHG, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T BBBEMACEHBG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3B76110", Offset = "0x3B74F10", VA = "0x183B76110")]
	public static bool OJNJEJNGJBI<T>(CJCPBNHOGPF ADGMECOLKNH, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T OGEACDPDAOF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3B75B10", Offset = "0x3B74910", VA = "0x183B75B10")]
	public static bool BOIMNCHNDNL<T>(CJCPBNHOGPF ADGMECOLKNH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3B75AD0", Offset = "0x3B748D0", VA = "0x183B75AD0")]
	public static T DPMBHNJHJDJ<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3B75CE0", Offset = "0x3B74AE0", VA = "0x183B75CE0")]
	public static bool DDAKMEGCLEF<T>(T FHMNLAOMLHG, [Out] T BBBEMACEHBG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3B75AD0", Offset = "0x3B748D0", VA = "0x183B75AD0")]
	public static bool BOIMNCHNDNL<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal static class AKBDPJHFNOC
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x83E5150", Offset = "0x83E3F50", VA = "0x1883E5150")]
	public static void NEELAKDMDKG(IEnumerable LNMKEAJCKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3253960", Offset = "0x3252760", VA = "0x183253960")]
	public static void NEELAKDMDKG<T>(T[] ELLFIONNNHC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3253A50", Offset = "0x3252850", VA = "0x183253A50")]
	public static void NEELAKDMDKG<T>(T AGNBPCKNDIK) where T : notnull, Enum
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
