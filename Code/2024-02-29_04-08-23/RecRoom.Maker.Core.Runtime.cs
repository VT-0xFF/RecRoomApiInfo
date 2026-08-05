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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6033BB0", Offset = "0x60329B0", VA = "0x186033BB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KCPFGHPBBMN<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn EOEIMNLELBG(TData NHLNHJGAONN);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NNBGLCDDPPJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(EGOCGFBGMLJ OFDJPHFEJBB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData KAKJJOAALHM, Collider HDIINGHGHEF, EGOCGFBGMLJ OFDJPHFEJBB, [Optional] LPOKNNAKEAE? EHCKKOLILKH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData KAKJJOAALHM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider HDIINGHGHEF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FIIKBNCLDJE<TData> : IIHHEPOMDCO, IIHBGBBDDCP<TData>, PNLAKJGGMMF<TData>, HAHHHJPOCOP<TData>, KJBPPLEHIAP, BOAHMCNKNPI<TData>, HOIAIHKHPDA, EMPJIFPMGLL
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BOAHMCNKNPI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 HDDLJEHAKEP, Vector3 LLMNHBKBLPP, float ABEPJPPAIOB, [Out] T LGOHAAKPHHB, [Out] Vector3 GLOOPMDIAHF, [Out] Collider HDIINGHGHEF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 HDDLJEHAKEP, Vector3 LLMNHBKBLPP, float HAEAELLJNLO, float ABEPJPPAIOB, T[] NAAJHNCECBK, [Out] Vector3 GGONHLDHLGF, [Out] Collider GCGDDNMIKGC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 HDDLJEHAKEP, float HAEAELLJNLO, Vector3 BJEBJNLFLAM, T[] NAAJHNCECBK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider ABKAPOJFHND, [Out] T LEDAGKOEDFA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IIHHEPOMDCO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds ADCNBEOHFEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform CAKPMMPFKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds FLDNDKGLAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform DIOMHLNGNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 PLFBLJCJCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JANNGBLDIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool EPHNIBPNBJF = true, int JHENAACKCHJ = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool JLGPNFLLMJL, object NBGOKNOECBH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EMPJIFPMGLL
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BHHPLLLFBGO CFEBCMFBHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EGBCFAJLIAA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool CPLDIAIFGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool IHNDICLKIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IJPOKHCHDOG
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> OJFBPEABHMO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HAHHHJPOCOP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KBDJABGHPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int BHHNEEHIHOC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> DKDEHPDCHGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData PEFIMPHEJCD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData PEFIMPHEJCD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IIHBGBBDDCP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T NHLNHJGAONN, [Optional] LPOKNNAKEAE? KKDBAKJEPPA, bool BMIKOEKKLHD = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int BPFMGMBDOBA, IEnumerable<T> FNEIOBDLJKM, bool BMIKOEKKLHD = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int BPFMGMBDOBA, IEnumerable<T> FNEIOBDLJKM, LPOKNNAKEAE KKDBAKJEPPA, bool BMIKOEKKLHD = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HOIAIHKHPDA
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KJBPPLEHIAP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool FBFGJHKEDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool AHACNEJPMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool NHPMHACLJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool MPGPMNJENIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class NNJEKPHEOHP<TReceiver> : JBIHMOENLFG<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x323A030", Offset = "0x3238E30", VA = "0x18323A030")]
	public NNJEKPHEOHP(TReceiver KKEOLOLGJJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class BOONJICBLPL<TReceiver, TFromTask> : JBIHMOENLFG<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x323A030", Offset = "0x3238E30", VA = "0x18323A030")]
	public BOONJICBLPL(TReceiver KKEOLOLGJJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class JBIHMOENLFG<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver KKEOLOLGJJJ;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3A1EED0", Offset = "0x3A1DCD0", VA = "0x183A1EED0")]
	public JBIHMOENLFG(TReceiver KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute PDKGJAINHLN();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class KKMBJIHJJJD<TReceiver, TResult> : JBIHMOENLFG<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x323A030", Offset = "0x3238E30", VA = "0x18323A030")]
	public KKMBJIHJJJD(TReceiver KKEOLOLGJJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KIJADFEAMLJ<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup BCCOEPJONII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData FAENAMNGAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> GHFECHLIJKP;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1A5D790", Offset = "0x1A5C590", VA = "0x181A5D790")]
	public KIJADFEAMLJ(TGroup JMLGDJNKEPG, TData MOAKKGAFHFG, IEnumerable<TData> PKPKHOOLFGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BPBIFCHFMNF<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup BCCOEPJONII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> GHFECHLIJKP;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x89F0F0", Offset = "0x89DEF0", VA = "0x18089F0F0")]
	public BPBIFCHFMNF(TGroup JMLGDJNKEPG, IEnumerable<TData> PKPKHOOLFGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DPHKBKPEIJJ<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup BCCOEPJONII;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A60", Offset = "0x8D3860", VA = "0x1808D4A60")]
	public DPHKBKPEIJJ(TGroup JMLGDJNKEPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LMBLPAGKPLJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> GHFECHLIJKP;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A60", Offset = "0x8D3860", VA = "0x1808D4A60")]
	public LMBLPAGKPLJ(IEnumerable<TData> PKPKHOOLFGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LOMCKBDFDGB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LPDFJOLHNHB EFNOMMOFHIO(KIJADFEAMLJ<TGroup, TData> PJFBBCHNHJF);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LPDFJOLHNHB PCEJCFIMGGA(KIJADFEAMLJ<TGroup, TData> PJFBBCHNHJF);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LPDFJOLHNHB JLLEGJPMIGH(BPBIFCHFMNF<TGroup, TData> PJFBBCHNHJF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LPDFJOLHNHB COOABAPGCLK(DPHKBKPEIJJ<TGroup> PJFBBCHNHJF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HAEDIFCFGAC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LPDFJOLHNHB> EFNOMMOFHIO(LMBLPAGKPLJ<TData> PJFBBCHNHJF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MBPLPGCLHGL<TGroup, TData> : KKMBJIHJJJD<LOMCKBDFDGB<TGroup, TData>, LPDFJOLHNHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly BPBIFCHFMNF<TGroup, TData> PJFBBCHNHJF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3DD70B0", Offset = "0x3DD5EB0", VA = "0x183DD70B0")]
	public MBPLPGCLHGL(TGroup JMLGDJNKEPG, IEnumerable<TData> PKPKHOOLFGD, LOMCKBDFDGB<TGroup, TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6FE0", Offset = "0x3DD5DE0", VA = "0x183DD6FE0", Slot = "4")]
	public override LPDFJOLHNHB PDKGJAINHLN()
	{
		return default(LPDFJOLHNHB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BEIJPENHPGM<TGroup, TData> : KKMBJIHJJJD<LOMCKBDFDGB<TGroup, TData>, LPDFJOLHNHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly KIJADFEAMLJ<TGroup, TData> PJFBBCHNHJF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3A1FBC0", Offset = "0x3A1E9C0", VA = "0x183A1FBC0")]
	public BEIJPENHPGM(TGroup JMLGDJNKEPG, TData IBFAJJJFCNH, IEnumerable<TData> PKPKHOOLFGD, LOMCKBDFDGB<TGroup, TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x46747B0", Offset = "0x46735B0", VA = "0x1846747B0", Slot = "4")]
	public override LPDFJOLHNHB PDKGJAINHLN()
	{
		return default(LPDFJOLHNHB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AEIMHJNNEGN<TGroup, TData> : KKMBJIHJJJD<LOMCKBDFDGB<TGroup, TData>, LPDFJOLHNHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly DPHKBKPEIJJ<TGroup> PJFBBCHNHJF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x35D94E0", Offset = "0x35D82E0", VA = "0x1835D94E0")]
	public AEIMHJNNEGN(TGroup JMLGDJNKEPG, LOMCKBDFDGB<TGroup, TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3675150", Offset = "0x3673F50", VA = "0x183675150", Slot = "4")]
	public override LPDFJOLHNHB PDKGJAINHLN()
	{
		return default(LPDFJOLHNHB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JEEBDCPEHDK<TGroup, TData> : KKMBJIHJJJD<LOMCKBDFDGB<TGroup, TData>, LPDFJOLHNHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KIJADFEAMLJ<TGroup, TData> PJFBBCHNHJF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3A1FBC0", Offset = "0x3A1E9C0", VA = "0x183A1FBC0")]
	public JEEBDCPEHDK(TGroup JMLGDJNKEPG, TData MOAKKGAFHFG, IEnumerable<TData> PKPKHOOLFGD, LOMCKBDFDGB<TGroup, TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3A1FAE0", Offset = "0x3A1E8E0", VA = "0x183A1FAE0", Slot = "4")]
	public override LPDFJOLHNHB PDKGJAINHLN()
	{
		return default(LPDFJOLHNHB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FKOICAGPHJD<TData> : BOONJICBLPL<HAEDIFCFGAC<TData>, LPDFJOLHNHB> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct FOECPAHCBDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<LPDFJOLHNHB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FKOICAGPHJD<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<LPDFJOLHNHB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x35E1480", Offset = "0x35E0280", VA = "0x1835E1480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x35E1720", Offset = "0x35E0520", VA = "0x1835E1720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private LMBLPAGKPLJ<TData> PJFBBCHNHJF;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x35D94E0", Offset = "0x35D82E0", VA = "0x1835D94E0")]
	public FKOICAGPHJD(IEnumerable<TData> LKMCIIGEOPL, HAEDIFCFGAC<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35D93E0", Offset = "0x35D81E0", VA = "0x1835D93E0", Slot = "4")]
	[AsyncStateMachine(typeof(FKOICAGPHJD<>.FOECPAHCBDP))]
	public override Task<LPDFJOLHNHB> PDKGJAINHLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct BNDABCGAHGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly CGIMANGLCGE EGOAKGNEBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool LKPDOIPEADH;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6032FB0", Offset = "0x6031DB0", VA = "0x186032FB0")]
	public BNDABCGAHGO(CGIMANGLCGE KJPEGLGGMHL, bool HLFJIJDMILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KGEODGJOCNI<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> PDKGJAINHLN(BNDABCGAHGO GKIDGMBHKAF);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class JMOMEAIJILJ<TSpawnType> : BOONJICBLPL<KGEODGJOCNI<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct HBOFFPDHGDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JMOMEAIJILJ<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x37036B0", Offset = "0x37024B0", VA = "0x1837036B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3703AC0", Offset = "0x37028C0", VA = "0x183703AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly BNDABCGAHGO GKIDGMBHKAF;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3A60A70", Offset = "0x3A5F870", VA = "0x183A60A70")]
	public JMOMEAIJILJ(CGIMANGLCGE KJPEGLGGMHL, bool HLFJIJDMILN, KGEODGJOCNI<TSpawnType> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3A60870", Offset = "0x3A5F670", VA = "0x183A60870", Slot = "4")]
	[AsyncStateMachine(typeof(JMOMEAIJILJ<>.HBOFFPDHGDD))]
	public override Task<TSpawnType> PDKGJAINHLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct CGIMANGLCGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool EFKFAJMEDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 OAJANCKGLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 CDFOMBDMAPH;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6033090", Offset = "0x6031E90", VA = "0x186033090")]
	public CGIMANGLCGE(Transform BFJGMHAIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6033100", Offset = "0x6031F00", VA = "0x186033100")]
	public CGIMANGLCGE(Vector3 NPJIMHPPOGG, Vector3 JCOIMLJCHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6032FD0", Offset = "0x6031DD0", VA = "0x186032FD0")]
	public static CGIMANGLCGE CGCPFECLPOJ()
	{
		return default(CGIMANGLCGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6033000", Offset = "0x6031E00", VA = "0x186033000")]
	private CGIMANGLCGE(bool GPAPNAMLPHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct BDDGFBDBFNL<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode EABGAJPIJMP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x46639A0", Offset = "0x46627A0", VA = "0x1846639A0")]
	public BDDGFBDBFNL(TNode EABGAJPIJMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct FEHCGKEDJMG<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode MOBMFOOKHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NMEGMDOLDAC KHNNKNKIKMP;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x35AC9C0", Offset = "0x35AB7C0", VA = "0x1835AC9C0")]
	public FEHCGKEDJMG(TNode MOBMFOOKHPE, NMEGMDOLDAC KHNNKNKIKMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface CEAMOHPBKCK<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGGOLKPGBEO([In] BDDGFBDBFNL<TNode> NKHOEPMCHHD);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ENGCLPBFBGI([In] FEHCGKEDJMG<TNode> MDEGNAOAEEL);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HNKLIAPHHII();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DECDLANDNIJ<TNode> : NNJEKPHEOHP<CEAMOHPBKCK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x323A030", Offset = "0x3238E30", VA = "0x18323A030")]
	public DECDLANDNIJ(CEAMOHPBKCK<TNode> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4F25720", Offset = "0x4F24520", VA = "0x184F25720", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KINMGOMLALM<TNode> : NNJEKPHEOHP<CEAMOHPBKCK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly FEHCGKEDJMG<TNode> MDEGNAOAEEL;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3ACA220", Offset = "0x3AC9020", VA = "0x183ACA220")]
	public KINMGOMLALM(TNode MOBMFOOKHPE, NMEGMDOLDAC KHNNKNKIKMP, CEAMOHPBKCK<TNode> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x321CCF0", Offset = "0x321BAF0", VA = "0x18321CCF0", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BHEBGFDCFHJ<TNode> : NNJEKPHEOHP<CEAMOHPBKCK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly BDDGFBDBFNL<TNode> NKHOEPMCHHD;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x468E110", Offset = "0x468CF10", VA = "0x18468E110")]
	public BHEBGFDCFHJ(TNode PFAEBGLGOKL, CEAMOHPBKCK<TNode> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3254540", Offset = "0x3253340", VA = "0x183254540", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct PKFLDJMGABL<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo ACIAOGHLAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 JCOIMLJCHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion GJMDICOFEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float NANBGKEHFBG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4049B10", Offset = "0x4048910", VA = "0x184049B10")]
	public PKFLDJMGABL(TSpawnInfo ACIAOGHLAPH, Vector3 JCOIMLJCHFJ, Quaternion GJMDICOFEBG, float NANBGKEHFBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OJPMELFFGLM<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> EMIJDPOLHAC([In] PKFLDJMGABL<TSpawnInfo> CHMJBBMKGEP, CancellationToken HHBHDBLGMFA);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class LJGCFKENLPA<TSpawnType, TSpawnInfo> : BOONJICBLPL<OJPMELFFGLM<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly PKFLDJMGABL<TSpawnInfo> BBFBHKMAMKC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3BF7350", Offset = "0x3BF6150", VA = "0x183BF7350")]
	public LJGCFKENLPA(TSpawnInfo DGIPCCPBJHK, Vector3 JCOIMLJCHFJ, Quaternion GJMDICOFEBG, float NANBGKEHFBG, OJPMELFFGLM<TSpawnType, TSpawnInfo> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3BF6BB0", Offset = "0x3BF59B0", VA = "0x183BF6BB0", Slot = "4")]
	public override Task<TSpawnType> PDKGJAINHLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct NEGJNBIECBK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> GHFECHLIJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool LKPDOIPEADH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3E62DB0", Offset = "0x3E61BB0", VA = "0x183E62DB0")]
	public NEGJNBIECBK(IEnumerable<TData> PKPKHOOLFGD, bool HLFJIJDMILN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface NOKFDIPKAPO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LPDFJOLHNHB> BNMFIFIJLDE([In] NEGJNBIECBK<TData> HDCFAIDIOCO, CancellationToken HHBHDBLGMFA);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LIPDIDODJDK<TData> : BOONJICBLPL<NOKFDIPKAPO<TData>, LPDFJOLHNHB> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly NEGJNBIECBK<TData> GDGLECBDIDN;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3BF6C90", Offset = "0x3BF5A90", VA = "0x183BF6C90")]
	public LIPDIDODJDK(IEnumerable<TData> PKPKHOOLFGD, bool HLFJIJDMILN, NOKFDIPKAPO<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3BF6BB0", Offset = "0x3BF59B0", VA = "0x183BF6BB0", Slot = "4")]
	public override Task<LPDFJOLHNHB> PDKGJAINHLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct CBBCCNCGEBC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T KAKJJOAALHM;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3A5E710", Offset = "0x3A5D510", VA = "0x183A5E710")]
	public CBBCCNCGEBC(T JJMDFEOOGHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FPHJLGJKNIM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGGOLKPGBEO([In] CBBCCNCGEBC<T> KAAPPGIMPAH);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ENGCLPBFBGI();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface AJMEBJPLMNN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDKGJAINHLN([In] ABBGOEMPHFI<T> FHCAPDIILDA);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct ABBGOEMPHFI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T KAKJJOAALHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool CPDECJGGMOO;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3662C60", Offset = "0x3661A60", VA = "0x183662C60")]
	public ABBGOEMPHFI(T JJMDFEOOGHD, bool HDAJCCLPFFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class JHMEJCDBNNG<T> : NNJEKPHEOHP<FPHJLGJKNIM<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x323A030", Offset = "0x3238E30", VA = "0x18323A030")]
	public JHMEJCDBNNG(FPHJLGJKNIM<T> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3A2E5F0", Offset = "0x3A2D3F0", VA = "0x183A2E5F0", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class HJHIPFGNFFO<T> : NNJEKPHEOHP<FPHJLGJKNIM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly CBBCCNCGEBC<T> KAAPPGIMPAH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x378B020", Offset = "0x3789E20", VA = "0x18378B020")]
	public HJHIPFGNFFO(T KAKJJOAALHM, FPHJLGJKNIM<T> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3254540", Offset = "0x3253340", VA = "0x183254540", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class GCDNLLIEMNO<T> : NNJEKPHEOHP<AJMEBJPLMNN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly ABBGOEMPHFI<T> FHCAPDIILDA;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3690C60", Offset = "0x368FA60", VA = "0x183690C60")]
	public GCDNLLIEMNO(T KAKJJOAALHM, bool HDAJCCLPFFI, AJMEBJPLMNN<T> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3254540", Offset = "0x3253340", VA = "0x183254540", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct JDDKCGGIKEJ<TData> where TData : notnull, CJNPKLNONKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> GHFECHLIJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool EFBJFMGCADC;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3A1F790", Offset = "0x3A1E590", VA = "0x183A1F790")]
	public JDDKCGGIKEJ(IEnumerable<TData> PELEMHMGECB, bool KALFLAPHAEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct MCIDKPEMEEC<TData> where TData : notnull, CJNPKLNONKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> GHFECHLIJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> IOOMAPDBOJJ;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA440", Offset = "0x3DD9240", VA = "0x183DDA440")]
	public MCIDKPEMEEC(List<TData> PELEMHMGECB, List<bool> CNCDBBBBKKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface CJNPKLNONKD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool HAEKMBCFPGD
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
public interface GHKEMFKCBME<TData> where TData : CJNPKLNONKD
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDKGJAINHLN([In] JDDKCGGIKEJ<TData> AKEMBJKNDLI);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDKGJAINHLN([In] MCIDKPEMEEC<TData> AKEMBJKNDLI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface GELBLACGBLF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KLDAOHCIBBF(T KAKJJOAALHM);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class CNONEKALDCC<TData> : NNJEKPHEOHP<GHKEMFKCBME<TData>> where TData : notnull, CJNPKLNONKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly JDDKCGGIKEJ<TData> AKEMBJKNDLI;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F270", Offset = "0x4A5E070", VA = "0x184A5F270")]
	public CNONEKALDCC(List<TData> PKPKHOOLFGD, bool EFBJFMGCADC, GHKEMFKCBME<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3254540", Offset = "0x3253340", VA = "0x183254540", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class AGJLDECADAK<TData> : NNJEKPHEOHP<GHKEMFKCBME<TData>> where TData : notnull, CJNPKLNONKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly MCIDKPEMEEC<TData> AKEMBJKNDLI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3679D40", Offset = "0x3678B40", VA = "0x183679D40")]
	public AGJLDECADAK(List<TData> PKPKHOOLFGD, List<bool> IOOMAPDBOJJ, GHKEMFKCBME<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3224C00", Offset = "0x3223A00", VA = "0x183224C00", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface AICJHGLFCOD : CJNPKLNONKD
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface FOPLCPALBGN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LPDFJOLHNHB> PDKGJAINHLN(KPCEAJLGPDK<TData> JAPHMJODDCI);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class LCAHCJPCCPE<TData> : BOONJICBLPL<FOPLCPALBGN<TData>, LPDFJOLHNHB> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct AIIGDAOJHDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<LPDFJOLHNHB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public LCAHCJPCCPE<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<LPDFJOLHNHB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3722400", Offset = "0x3721200", VA = "0x183722400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x37226F0", Offset = "0x37214F0", VA = "0x1837226F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KPCEAJLGPDK<TData> JKLIBMGGFBJ;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3200", Offset = "0x3BA2000", VA = "0x183BA3200")]
	public LCAHCJPCCPE(TData JEEGEOJJMEJ, IReadOnlyList<TData> IEJJJAOFOJM, bool HLFJIJDMILN, FOPLCPALBGN<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3100", Offset = "0x3BA1F00", VA = "0x183BA3100", Slot = "4")]
	[AsyncStateMachine(typeof(LCAHCJPCCPE<>.AIIGDAOJHDE))]
	public override Task<LPDFJOLHNHB> PDKGJAINHLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct KPCEAJLGPDK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData BMBIJGEOCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> PINMBKEIBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool LKPDOIPEADH;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3B17BD0", Offset = "0x3B169D0", VA = "0x183B17BD0")]
	public KPCEAJLGPDK(TData JEEGEOJJMEJ, IReadOnlyList<TData> IEJJJAOFOJM, bool HLFJIJDMILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface PINGOLDPLPN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDKGJAINHLN([In] MIMEBGLILAE<TData> OHLFDPELICM);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface IGPLIPLECEC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDKGJAINHLN([In] JIPAGNCAEII<TData> OHLFDPELICM);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface ILOGAEOJPNC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHCNKAIHCBI([In] APJIPFJMFNP<TData> OHLFDPELICM);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENGCLPBFBGI();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class CEFAOHOKPOJ<TData> : NNJEKPHEOHP<PINGOLDPLPN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly MIMEBGLILAE<TData> OHLFDPELICM;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x497C3A0", Offset = "0x497B1A0", VA = "0x18497C3A0")]
	public CEFAOHOKPOJ(IEnumerable<TData> PKPKHOOLFGD, OAEIMDOBIAE OLDELFAHHJB, FCKJPJLMAPE CMHHFEPJBNC, float LIIDLIFGALG, bool HLFJIJDMILN, PINGOLDPLPN<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3254540", Offset = "0x3253340", VA = "0x183254540", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class PJACLCHJILA<TData> : NNJEKPHEOHP<IGPLIPLECEC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly JIPAGNCAEII<TData> OHLFDPELICM;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4046600", Offset = "0x4045400", VA = "0x184046600")]
	public PJACLCHJILA(TData[] PKPKHOOLFGD, OAEIMDOBIAE[] OLDELFAHHJB, FCKJPJLMAPE[] CMHHFEPJBNC, float[] LIIDLIFGALG, IGPLIPLECEC<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x386F4B0", Offset = "0x386E2B0", VA = "0x18386F4B0", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class FHELJCFJBCM<TData> : NNJEKPHEOHP<ILOGAEOJPNC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x323A030", Offset = "0x3238E30", VA = "0x18323A030")]
	public FHELJCFJBCM(ILOGAEOJPNC<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x35C99B0", Offset = "0x35C87B0", VA = "0x1835C99B0", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class IMEAGMFPJIJ<TData> : NNJEKPHEOHP<ILOGAEOJPNC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly APJIPFJMFNP<TData> OHLFDPELICM;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x386F570", Offset = "0x386E370", VA = "0x18386F570")]
	public IMEAGMFPJIJ(IEnumerable<TData> PKPKHOOLFGD, OAEIMDOBIAE OLDELFAHHJB, FCKJPJLMAPE CMHHFEPJBNC, float LIIDLIFGALG, ILOGAEOJPNC<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x386F4B0", Offset = "0x386E2B0", VA = "0x18386F4B0", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct MIMEBGLILAE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> GHFECHLIJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public OAEIMDOBIAE BDGDBNCMBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public FCKJPJLMAPE NLLGBGNAADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float LIIDLIFGALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool HLFJIJDMILN;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8230", Offset = "0x3DE7030", VA = "0x183DE8230")]
	public MIMEBGLILAE(IEnumerable<TData> PKPKHOOLFGD, OAEIMDOBIAE OLDELFAHHJB, FCKJPJLMAPE CMHHFEPJBNC, float LIIDLIFGALG, bool HLFJIJDMILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct JIPAGNCAEII<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] GHFECHLIJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public OAEIMDOBIAE[] BDGDBNCMBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public FCKJPJLMAPE[] NLLGBGNAADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] LIIDLIFGALG;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3A390E0", Offset = "0x3A37EE0", VA = "0x183A390E0")]
	public JIPAGNCAEII(TData[] PKPKHOOLFGD, OAEIMDOBIAE[] OLDELFAHHJB, FCKJPJLMAPE[] CMHHFEPJBNC, float[] LIIDLIFGALG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct APJIPFJMFNP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> GHFECHLIJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public OAEIMDOBIAE BDGDBNCMBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public FCKJPJLMAPE NLLGBGNAADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float LIIDLIFGALG;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x38516F0", Offset = "0x38504F0", VA = "0x1838516F0")]
	public APJIPFJMFNP(IEnumerable<TData> PKPKHOOLFGD, OAEIMDOBIAE OLDELFAHHJB, FCKJPJLMAPE CMHHFEPJBNC, float LIIDLIFGALG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface PNLAKJGGMMF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLLEGJPMIGH([In] BKCCAOPMOKC<TData> HDCFAIDIOCO);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COOABAPGCLK([In] BKCCAOPMOKC<TData> HDCFAIDIOCO);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDBKMJNHEGJ([In] bool LNBOFIOPNMN);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GKOGDAMMOAI([In] BKCCAOPMOKC<TData> HDCFAIDIOCO);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCINBGPMOIP();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CIGNMBCDOLO([In] TData EAMANOHKILB);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class ELLOFCBEHCM<TData> : NNJEKPHEOHP<PNLAKJGGMMF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly BKCCAOPMOKC<TData> HDCFAIDIOCO;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3254690", Offset = "0x3253490", VA = "0x183254690")]
	public ELLOFCBEHCM(List<TData> CHPHEMNFCNL, PNLAKJGGMMF<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3254540", Offset = "0x3253340", VA = "0x183254540", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class IEHALJIMLNH<TData> : NNJEKPHEOHP<PNLAKJGGMMF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x323A030", Offset = "0x3238E30", VA = "0x18323A030")]
	public IEHALJIMLNH(PNLAKJGGMMF<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x384A9F0", Offset = "0x38497F0", VA = "0x18384A9F0", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class FGEAGEMMNLF<TData> : NNJEKPHEOHP<PNLAKJGGMMF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool HLFJIJDMILN;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x35C90D0", Offset = "0x35C7ED0", VA = "0x1835C90D0")]
	public FGEAGEMMNLF(bool HLFJIJDMILN, PNLAKJGGMMF<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x35C9070", Offset = "0x35C7E70", VA = "0x1835C9070", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ECCDODEMGBO<TData> : NNJEKPHEOHP<PNLAKJGGMMF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly BKCCAOPMOKC<TData> HDCFAIDIOCO;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3224CC0", Offset = "0x3223AC0", VA = "0x183224CC0")]
	public ECCDODEMGBO(List<TData> CHPHEMNFCNL, bool HLFJIJDMILN, PNLAKJGGMMF<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3224C00", Offset = "0x3223A00", VA = "0x183224C00", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class AEKKBGKJHGJ<TData> : NNJEKPHEOHP<PNLAKJGGMMF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData EAMANOHKILB;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x36752F0", Offset = "0x36740F0", VA = "0x1836752F0")]
	public AEKKBGKJHGJ(TData EAMANOHKILB, PNLAKJGGMMF<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3675220", Offset = "0x3674020", VA = "0x183675220", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class MHGFGHNIMLI<TData> : NNJEKPHEOHP<PNLAKJGGMMF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly BKCCAOPMOKC<TData> HDCFAIDIOCO;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5F20", Offset = "0x3DE4D20", VA = "0x183DE5F20")]
	public MHGFGHNIMLI(IEnumerable<TData> CHPHEMNFCNL, PNLAKJGGMMF<TData> KKEOLOLGJJJ, bool HLFJIJDMILN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5E20", Offset = "0x3DE4C20", VA = "0x183DE5E20", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct BKCCAOPMOKC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> GHFECHLIJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool HLFJIJDMILN;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x46A95B0", Offset = "0x46A83B0", VA = "0x1846A95B0")]
	public BKCCAOPMOKC(IEnumerable<TData> PELEMHMGECB, bool CPEENBNHLJP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface EHHMJJPHFEP
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LPDFJOLHNHB> PDKGJAINHLN(MKPAJEMPFMG GHJKDINFNLK);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class NFIKEBBCMFM : BOONJICBLPL<EHHMJJPHFEP, LPDFJOLHNHB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct GDPMIOKJNPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<LPDFJOLHNHB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NFIKEBBCMFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<LPDFJOLHNHB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6033180", Offset = "0x6031F80", VA = "0x186033180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6033400", Offset = "0x6032200", VA = "0x186033400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly MKPAJEMPFMG KLGEIHNHBBI;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6033920", Offset = "0x6032720", VA = "0x186033920")]
	public NFIKEBBCMFM(bool HLFJIJDMILN, EHHMJJPHFEP KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6033830", Offset = "0x6032630", VA = "0x186033830", Slot = "4")]
	[AsyncStateMachine(typeof(GDPMIOKJNPB))]
	public override Task<LPDFJOLHNHB> PDKGJAINHLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct MKPAJEMPFMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool LKPDOIPEADH;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xC37340", Offset = "0xC36140", VA = "0x180C37340")]
	public MKPAJEMPFMG(bool HLFJIJDMILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct DGIIKDDPGHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool NDKFEMNBHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool KEIGHPBCALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool NANBGKEHFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool HLFJIJDMILN;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x44F99C0", Offset = "0x44F87C0", VA = "0x1844F99C0")]
	public DGIIKDDPGHM(bool NDKFEMNBHGK, bool KEIGHPBCALF, bool NANBGKEHFBG, bool HLFJIJDMILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6033130", Offset = "0x6031F30", VA = "0x186033130")]
	public DGIIKDDPGHM(bool KEIGHPBCALF, bool HLFJIJDMILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface JAJHMJGPHIF
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OADKNHIGJJC(DGIIKDDPGHM CGBHOLNLGAM);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JEPCPJBOHBI(DGIIKDDPGHM CGBHOLNLGAM);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class ONLEFEGEPNI : NNJEKPHEOHP<JAJHMJGPHIF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly DGIIKDDPGHM CGBHOLNLGAM;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6033C80", Offset = "0x6032A80", VA = "0x186033C80")]
	public ONLEFEGEPNI(bool PFIKOEBPDGA, bool KEIGHPBCALF, bool NANBGKEHFBG, bool HLFJIJDMILN, JAJHMJGPHIF KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6033C30", Offset = "0x6032A30", VA = "0x186033C30", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class JOMDNHKIGLC : NNJEKPHEOHP<JAJHMJGPHIF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly DGIIKDDPGHM CGBHOLNLGAM;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x60337B0", Offset = "0x60325B0", VA = "0x1860337B0")]
	public JOMDNHKIGLC(bool KEIGHPBCALF, bool HLFJIJDMILN, JAJHMJGPHIF KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6033760", Offset = "0x6032560", VA = "0x186033760", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface DFABBACLKNK
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDKGJAINHLN([In] ACKJAAENCBL JKECNLHEAHJ);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class ILGGMCEDIPH : NNJEKPHEOHP<DFABBACLKNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly ACKJAAENCBL JKECNLHEAHJ;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6033560", Offset = "0x6032360", VA = "0x186033560")]
	public ILGGMCEDIPH(Guid[] HCDJLCNHPJC, Vector3[] JKLHALOCLPP, Quaternion[] PKOOHOIOFNM, float[] GHPKNNBJCPN, Dictionary<Guid, Vector3> EPFHLAOGJBK, DFABBACLKNK KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x60334B0", Offset = "0x60322B0", VA = "0x1860334B0", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface OBBNLMIGELB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGGOLKPGBEO([In] MPBINJHLPHK<TData> NKHOEPMCHHD);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHCNKAIHCBI([In] JJBBNOCJCLF EOEGNJDOLKC);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NHCNKAIHCBI([In] IIJPFMLPLKK EOEGNJDOLKC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ENGCLPBFBGI();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class JMJEJJOBKII<TData> : NNJEKPHEOHP<OBBNLMIGELB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x323A030", Offset = "0x3238E30", VA = "0x18323A030")]
	public JMJEJJOBKII(OBBNLMIGELB<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A5FE50", Offset = "0x3A5EC50", VA = "0x183A5FE50", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class FLGMHEGNLAA<TData> : NNJEKPHEOHP<OBBNLMIGELB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly JJBBNOCJCLF HKDBJMGHJJI;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x35D9870", Offset = "0x35D8670", VA = "0x1835D9870")]
	public FLGMHEGNLAA(Vector3 IEJLBDPAADD, bool FHCFDOEFAHN, OBBNLMIGELB<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x359EE40", Offset = "0x359DC40", VA = "0x18359EE40", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class PLJGMIJFFEN<TData> : NNJEKPHEOHP<OBBNLMIGELB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly IIJPFMLPLKK HKDBJMGHJJI;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4052EB0", Offset = "0x4051CB0", VA = "0x184052EB0")]
	public PLJGMIJFFEN(Guid CHOLHBIOFJN, int ENPOKNEMOMH, Vector3 JCOIMLJCHFJ, Quaternion GJMDICOFEBG, float LLPCJKICLFP, bool FHCFDOEFAHN, OBBNLMIGELB<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4052E50", Offset = "0x4051C50", VA = "0x184052E50", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class IFHFIOJCIDF<TData> : NNJEKPHEOHP<OBBNLMIGELB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly MPBINJHLPHK<TData> HKDBJMGHJJI;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x384B910", Offset = "0x384A710", VA = "0x18384B910")]
	public IFHFIOJCIDF(TData KAKJJOAALHM, bool HLFJIJDMILN, OBBNLMIGELB<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3254540", Offset = "0x3253340", VA = "0x183254540", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct JJBBNOCJCLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Vector3 IEJLBDPAADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool FHCFDOEFAHN;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6033740", Offset = "0x6032540", VA = "0x186033740")]
	public JJBBNOCJCLF(Vector3 IEJLBDPAADD, bool FHCFDOEFAHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct IIJPFMLPLKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Guid CHOLHBIOFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int ENPOKNEMOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Vector3 JCOIMLJCHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Quaternion GJMDICOFEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly float LLPCJKICLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly bool FHCFDOEFAHN;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6033470", Offset = "0x6032270", VA = "0x186033470")]
	public IIJPFMLPLKK(Guid CHOLHBIOFJN, int ENPOKNEMOMH, Vector3 JCOIMLJCHFJ, Quaternion GJMDICOFEBG, float LLPCJKICLFP, bool FHCFDOEFAHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct MPBINJHLPHK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData KAKJJOAALHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly bool HLFJIJDMILN;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3E00410", Offset = "0x3DFF210", VA = "0x183E00410")]
	public MPBINJHLPHK(TData KAKJJOAALHM, bool HLFJIJDMILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface LOCFOABPKPE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDKGJAINHLN([In] KDEKOAGCFDJ<TData> PKIFJCKFLHK);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PDKGJAINHLN([In] INFJFPKAGMI<TData> PKIFJCKFLHK);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface FGEJNPMGEIE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGGOLKPGBEO([In] AJIJJDLEKKE<TData> PECDBJGFPEJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHCNKAIHCBI([In] MKANLFHEAFH EOEGNJDOLKC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ENGCLPBFBGI();
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class CPNKAFLDFNF<TData> : NNJEKPHEOHP<LOCFOABPKPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly KDEKOAGCFDJ<TData> PKIFJCKFLHK;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4A6A100", Offset = "0x4A68F00", VA = "0x184A6A100")]
	public CPNKAFLDFNF(IEnumerable<TData> PKPKHOOLFGD, Vector3 PNBMFLDCCGL, bool HLFJIJDMILN, LOCFOABPKPE<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3254540", Offset = "0x3253340", VA = "0x183254540", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class HEMCJPBABPP<TData> : NNJEKPHEOHP<FGEJNPMGEIE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x323A030", Offset = "0x3238E30", VA = "0x18323A030")]
	public HEMCJPBABPP(FGEJNPMGEIE<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3780CC0", Offset = "0x377FAC0", VA = "0x183780CC0", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class BJACBIJLKCH<TData> : NNJEKPHEOHP<FGEJNPMGEIE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly AJIJJDLEKKE<TData> PKIFJCKFLHK;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x46A4280", Offset = "0x46A3080", VA = "0x1846A4280")]
	public BJACBIJLKCH(IEnumerable<TData> PKPKHOOLFGD, bool HLFJIJDMILN, FGEJNPMGEIE<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3254540", Offset = "0x3253340", VA = "0x183254540", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class EAJAKGLBHGO<TData> : NNJEKPHEOHP<LOCFOABPKPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly INFJFPKAGMI<TData> PKIFJCKFLHK;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x321CDC0", Offset = "0x321BBC0", VA = "0x18321CDC0")]
	public EAJAKGLBHGO(IEnumerable<TData> PKPKHOOLFGD, Vector3 APGBECNLKMN, MLILFMCAKBH ICILAGELKOE, bool HLFJIJDMILN, LOCFOABPKPE<TData> KKEOLOLGJJJ, Space IDOABHBCPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x321CCF0", Offset = "0x321BAF0", VA = "0x18321CCF0", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class FACADLLGLFA<TData> : NNJEKPHEOHP<FGEJNPMGEIE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly MKANLFHEAFH PKIFJCKFLHK;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x359EEA0", Offset = "0x359DCA0", VA = "0x18359EEA0")]
	public FACADLLGLFA(Vector3 PNBMFLDCCGL, FGEJNPMGEIE<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x359EE40", Offset = "0x359DC40", VA = "0x18359EE40", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct KDEKOAGCFDJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly IEnumerable<TData> PKPKHOOLFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Vector3 PNBMFLDCCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly bool HLFJIJDMILN;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0500", Offset = "0x3A9F300", VA = "0x183AA0500")]
	public KDEKOAGCFDJ(IEnumerable<TData> PKPKHOOLFGD, Vector3 PNBMFLDCCGL, bool HLFJIJDMILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct AJIJJDLEKKE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> PKPKHOOLFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool HLFJIJDMILN;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x372AEE0", Offset = "0x3729CE0", VA = "0x18372AEE0")]
	public AJIJJDLEKKE(IEnumerable<TData> PKPKHOOLFGD, bool HLFJIJDMILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct INFJFPKAGMI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly IEnumerable<TData> PKPKHOOLFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 APGBECNLKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly MLILFMCAKBH ICILAGELKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool HLFJIJDMILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Space IDOABHBCPKF;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x38762A0", Offset = "0x38750A0", VA = "0x1838762A0")]
	public INFJFPKAGMI(IEnumerable<TData> PKPKHOOLFGD, Vector3 APGBECNLKMN, MLILFMCAKBH ICILAGELKOE, bool HLFJIJDMILN, Space IDOABHBCPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct MKANLFHEAFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Vector3 PNBMFLDCCGL;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1EE3F20", Offset = "0x1EE2D20", VA = "0x181EE3F20")]
	public MKANLFHEAFH(Vector3 PNBMFLDCCGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum MLILFMCAKBH
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
public interface KMKFGHJODKL
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDKGJAINHLN([In] DMGHGBIGDCK BMLCCFEPONG);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class PPHMOJGLDBO : NNJEKPHEOHP<KMKFGHJODKL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly DMGHGBIGDCK BMLCCFEPONG;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6033DC0", Offset = "0x6032BC0", VA = "0x186033DC0")]
	public PPHMOJGLDBO(bool HLFJIJDMILN, KMKFGHJODKL KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6033D10", Offset = "0x6032B10", VA = "0x186033D10", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct DMGHGBIGDCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool HLFJIJDMILN;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xC37340", Offset = "0xC36140", VA = "0x180C37340")]
	public DMGHGBIGDCK(bool HLFJIJDMILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface PIJBNJLNOKF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDKGJAINHLN([In] IKPEOOOBJJC<TData> BGDJHMFAIOJ);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PDKGJAINHLN([In] MAHGNLMODDL<TData> BGDJHMFAIOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface NIKLKJECKBO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGGOLKPGBEO([In] MFGJOBNPAIE<TData> NKHOEPMCHHD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHCNKAIHCBI([In] IMFKECMJFOD EOEGNJDOLKC);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ENGCLPBFBGI();
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class OKNMLMPGPHO<TData> : NNJEKPHEOHP<PIJBNJLNOKF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly IKPEOOOBJJC<TData> BGDJHMFAIOJ;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3F7A630", Offset = "0x3F79430", VA = "0x183F7A630")]
	public OKNMLMPGPHO(IEnumerable<TData> PKPKHOOLFGD, Quaternion PNBMFLDCCGL, Vector3? LBDKKMDGNMC, bool BHMNOGACEMP, bool HLFJIJDMILN, PIJBNJLNOKF<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3254540", Offset = "0x3253340", VA = "0x183254540", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class KHCNAHHONAH<TData> : NNJEKPHEOHP<NIKLKJECKBO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x323A030", Offset = "0x3238E30", VA = "0x18323A030")]
	public KHCNAHHONAH(NIKLKJECKBO<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3780CC0", Offset = "0x377FAC0", VA = "0x183780CC0", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class KPJAGAJIDGG<TData> : NNJEKPHEOHP<NIKLKJECKBO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly MFGJOBNPAIE<TData> BGDJHMFAIOJ;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3B17CB0", Offset = "0x3B16AB0", VA = "0x183B17CB0")]
	public KPJAGAJIDGG(IEnumerable<TData> PKPKHOOLFGD, bool HLFJIJDMILN, NIKLKJECKBO<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3254540", Offset = "0x3253340", VA = "0x183254540", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class INBFDMCJGCC<TData> : NNJEKPHEOHP<PIJBNJLNOKF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MAHGNLMODDL<TData> BGDJHMFAIOJ;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3876160", Offset = "0x3874F60", VA = "0x183876160")]
	public INBFDMCJGCC(IEnumerable<TData> PKPKHOOLFGD, Quaternion IKFEFBOKAPA, MLILFMCAKBH FKPPKMHFBFP, Vector3? LBDKKMDGNMC, bool BHMNOGACEMP, bool HLFJIJDMILN, Space IDOABHBCPKF, PIJBNJLNOKF<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x321CCF0", Offset = "0x321BAF0", VA = "0x18321CCF0", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class OJBJKNAACHJ<TData> : NNJEKPHEOHP<NIKLKJECKBO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly IMFKECMJFOD BGDJHMFAIOJ;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3F6AF40", Offset = "0x3F69D40", VA = "0x183F6AF40")]
	public OJBJKNAACHJ(Quaternion PNBMFLDCCGL, Vector3? LBDKKMDGNMC, bool BHMNOGACEMP, NIKLKJECKBO<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x359EE40", Offset = "0x359DC40", VA = "0x18359EE40", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct IKPEOOOBJJC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly IEnumerable<TData> PKPKHOOLFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Quaternion PNBMFLDCCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3? LBDKKMDGNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool BHMNOGACEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool HLFJIJDMILN;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x386B1C0", Offset = "0x3869FC0", VA = "0x18386B1C0")]
	public IKPEOOOBJJC(IEnumerable<TData> PKPKHOOLFGD, Quaternion PNBMFLDCCGL, Vector3? LBDKKMDGNMC, bool BHMNOGACEMP, bool HLFJIJDMILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct MFGJOBNPAIE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> PKPKHOOLFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool HLFJIJDMILN;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3DDCE40", Offset = "0x3DDBC40", VA = "0x183DDCE40")]
	public MFGJOBNPAIE(IEnumerable<TData> PKPKHOOLFGD, bool HLFJIJDMILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct MAHGNLMODDL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly IEnumerable<TData> PKPKHOOLFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Quaternion IKFEFBOKAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly MLILFMCAKBH FKPPKMHFBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3? LBDKKMDGNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool BHMNOGACEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool HLFJIJDMILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Space IDOABHBCPKF;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3DD31D0", Offset = "0x3DD1FD0", VA = "0x183DD31D0")]
	public MAHGNLMODDL(IEnumerable<TData> PKPKHOOLFGD, Quaternion IKFEFBOKAPA, MLILFMCAKBH FKPPKMHFBFP, Vector3? LBDKKMDGNMC, bool BHMNOGACEMP, bool HLFJIJDMILN, Space IDOABHBCPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct IMFKECMJFOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Quaternion PNBMFLDCCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3? LBDKKMDGNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool BHMNOGACEMP;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x44CC000", Offset = "0x44CAE00", VA = "0x1844CC000")]
	public IMFKECMJFOD(Quaternion PNBMFLDCCGL, Vector3? LBDKKMDGNMC, bool BHMNOGACEMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface KJKMKMABBAB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGGOLKPGBEO([In] MDMOMONAJEK<TData> NKHOEPMCHHD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHCNKAIHCBI([In] BJELLCKNNOE EOEGNJDOLKC);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NHCNKAIHCBI([In] AFFFABJNFLO EOEGNJDOLKC);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NHCNKAIHCBI([In] DJAJKNABGBD EOEGNJDOLKC);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ENGCLPBFBGI();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class FNFKKMOGMJE<TData> : NNJEKPHEOHP<KJKMKMABBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly DJAJKNABGBD ODBAJJBHGKN;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x35DD440", Offset = "0x35DC240", VA = "0x1835DD440")]
	public FNFKKMOGMJE(Vector3 GMGCHFALHJE, float HPMOKOMLGDA, Vector3 LBDKKMDGNMC, bool AKMIFDFHJIA, bool EFLDGAAJGAA, KJKMKMABBAB<TData> KKEOLOLGJJJ, Space IDOABHBCPKF = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x35DD3E0", Offset = "0x35DC1E0", VA = "0x1835DD3E0", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class APJOHMIIFBJ<TData> : NNJEKPHEOHP<KJKMKMABBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x323A030", Offset = "0x3238E30", VA = "0x18323A030")]
	public APJOHMIIFBJ(KJKMKMABBAB<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3851800", Offset = "0x3850600", VA = "0x183851800", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class HGBDHANPHBN<TData> : NNJEKPHEOHP<KJKMKMABBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly MDMOMONAJEK<TData> ODBAJJBHGKN;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3783D80", Offset = "0x3782B80", VA = "0x183783D80")]
	public HGBDHANPHBN(IEnumerable<TData> PKPKHOOLFGD, bool HLFJIJDMILN, KJKMKMABBAB<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3254540", Offset = "0x3253340", VA = "0x183254540", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class EKIKENNLDIM<TData> : NNJEKPHEOHP<KJKMKMABBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly AFFFABJNFLO ODBAJJBHGKN;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x324C780", Offset = "0x324B580", VA = "0x18324C780")]
	public EKIKENNLDIM(float IPKHOKMHBPN, bool GCKNBDMOOCN, Vector3 LBDKKMDGNMC, KJKMKMABBAB<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x324C6B0", Offset = "0x324B4B0", VA = "0x18324C6B0", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class CGBCBKIPEKN<TData> : NNJEKPHEOHP<KJKMKMABBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly BJELLCKNNOE ODBAJJBHGKN;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x497D1C0", Offset = "0x497BFC0", VA = "0x18497D1C0")]
	public CGBCBKIPEKN(float HPMOKOMLGDA, Vector3 LBDKKMDGNMC, KJKMKMABBAB<TData> KKEOLOLGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x359EE40", Offset = "0x359DC40", VA = "0x18359EE40", Slot = "4")]
	public override bool PDKGJAINHLN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct DJAJKNABGBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 GMGCHFALHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly float HPMOKOMLGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 LBDKKMDGNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool FHCFDOEFAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space IDOABHBCPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly bool EFLDGAAJGAA;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6033140", Offset = "0x6031F40", VA = "0x186033140")]
	public DJAJKNABGBD(Vector3 GMGCHFALHJE, float HPMOKOMLGDA, Vector3 LBDKKMDGNMC, bool FHCFDOEFAHN, bool PGJPKCDENPA, Space IDOABHBCPKF = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct MDMOMONAJEK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> PKPKHOOLFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool HLFJIJDMILN;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC280", Offset = "0x3DDB080", VA = "0x183DDC280")]
	public MDMOMONAJEK(IEnumerable<TData> PKPKHOOLFGD, bool HLFJIJDMILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct AFFFABJNFLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly float IPKHOKMHBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool GCKNBDMOOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly Vector3 LBDKKMDGNMC;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6032BC0", Offset = "0x60319C0", VA = "0x186032BC0")]
	public AFFFABJNFLO(float IPKHOKMHBPN, bool GCKNBDMOOCN, Vector3 LBDKKMDGNMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct BJELLCKNNOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly float HPMOKOMLGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 LBDKKMDGNMC;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x449BD40", Offset = "0x449AB40", VA = "0x18449BD40")]
	public BJELLCKNNOE(float HPMOKOMLGDA, Vector3 LBDKKMDGNMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct ACKJAAENCBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Guid[] PKPKHOOLFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly bool HLNJAPLBBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool HEPABJIFLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool BNBCAPNHPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Vector3[] JKLHALOCLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion[] PKOOHOIOFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly float[] GHPKNNBJCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Dictionary<Guid, Vector3> EPFHLAOGJBK;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6032930", Offset = "0x6031730", VA = "0x186032930")]
	public ACKJAAENCBL(Guid[] HCDJLCNHPJC, Vector3[] JKLHALOCLPP, Quaternion[] PKOOHOIOFNM, float[] GHPKNNBJCPN, Dictionary<Guid, Vector3> EPFHLAOGJBK, bool HLNJAPLBBHK = true, bool HEPABJIFLCB = true, bool BNBCAPNHPEG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6032760", Offset = "0x6031560", VA = "0x186032760")]
	private static void AMIKGEAANEJ(Dictionary<Guid, Vector3> EPFHLAOGJBK, int JAAMOALFGDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class AIDNCIOMGGL
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct NIJKKIGHLEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool CGOOEHKGIJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public IBPIJCMLLGH FKABBJPEBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public IBPIJCMLLGH MICGIMFKJLC;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static NIJKKIGHLEF EDDAAMBHLOH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken LDAEPLDKKFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6032C50", Offset = "0x6031A50", VA = "0x186032C50")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static IBPIJCMLLGH FKABBJPEBID
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6032C70", Offset = "0x6031A70", VA = "0x186032C70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6032BE0", Offset = "0x60319E0", VA = "0x186032BE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6032EB0", Offset = "0x6031CB0", VA = "0x186032EB0")]
	[NAAAALLPNIA(KMIEHGCCHON.Room, PBKIGNPNCFO.None)]
	private static void OCPPHKOHOLM(IBPIJCMLLGH OLODLHFDFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6032D10", Offset = "0x6031B10", VA = "0x186032D10")]
	public static void MNGHADJNDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6032E60", Offset = "0x6031C60", VA = "0x186032E60")]
	private static IBPIJCMLLGH NFDPCKPLHGB(IBPIJCMLLGH AAMJLCHCCEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class IMKONCEFJEA
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum EPABJLGFGPE
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2743430", Offset = "0x2742230", VA = "0x182743430")]
	public static void NNMCAEFKCAB<T>(T NNOMIIGCPPJ, EPABJLGFGPE HFFNCGFKMBJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2743570", Offset = "0x2742370", VA = "0x182743570")]
	public static void NNMCAEFKCAB<T>(T NNOMIIGCPPJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2743670", Offset = "0x2742470", VA = "0x182743670")]
	public static void PEHGAFHJGGL<T>(T NNOMIIGCPPJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2743350", Offset = "0x2742150", VA = "0x182743350")]
	public static T IKJEAFPPDKF<T>(EPABJLGFGPE HFFNCGFKMBJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2743180", Offset = "0x2741F80", VA = "0x182743180")]
	public static bool HPFCNKHIJLK<T>(EPABJLGFGPE HFFNCGFKMBJ, T HAPCIOLAINI, [Out] T BEJJEBDPLDI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x27435D0", Offset = "0x27423D0", VA = "0x1827435D0")]
	public static bool OIMEAPOGEAK<T>(EPABJLGFGPE HFFNCGFKMBJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x27433F0", Offset = "0x27421F0", VA = "0x1827433F0")]
	public static T IKJEAFPPDKF<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x27432B0", Offset = "0x27420B0", VA = "0x1827432B0")]
	public static bool HPFCNKHIJLK<T>(T HAPCIOLAINI, [Out] T BEJJEBDPLDI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x27433F0", Offset = "0x27421F0", VA = "0x1827433F0")]
	public static bool OIMEAPOGEAK<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class NOCLHBGEFCF
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6033980", Offset = "0x6032780", VA = "0x186033980")]
	public static void LKHGLGJEAHM(IEnumerable BGODMJFMGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2835930", Offset = "0x2834730", VA = "0x182835930")]
	public static void LKHGLGJEAHM<T>(T[] AAKJIOEDOGA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2835B10", Offset = "0x2834910", VA = "0x182835B10")]
	public static void LKHGLGJEAHM<T>(T BLFMPLMBDLD) where T : notnull, Enum
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
