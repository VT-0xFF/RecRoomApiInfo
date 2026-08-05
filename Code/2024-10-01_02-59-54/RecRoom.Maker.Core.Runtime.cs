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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E31E40", Offset = "0x6E31240", VA = "0x186E31E40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
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
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E32340", Offset = "0x6E31740", VA = "0x186E32340", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IPFFJIALNGM<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn ACPIPJCEJBJ(TData PBAACPJGKNP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FCHEKBBMEOO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(IILMAIKLAPA IGCFCMOCCFH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData ANHPPPBDANF, Collider NMKLBFOLIAN, IILMAIKLAPA IGCFCMOCCFH, [Optional] MHIAMIGKIGC? BFDLCKGLIFO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData ANHPPPBDANF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider NMKLBFOLIAN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KGCFMNNLHML<TData> : BCJJCIDDKHG, HAHPOPADOBD<TData>, INCJEKKKOHC<TData>, FHCKDMIKAHG<TData>, HLCBLEOLOOL, FGBMEOJMJKM<TData>, OELBNHGDFOC, NFCNOMCMLIB
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FGBMEOJMJKM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 ONLDCANPGJN, Vector3 NLEBNOPPEID, float MALFDDNHAMM, [Out] T CLMJKCNNGEB, [Out] Vector3 ANPFNHHGDMO, [Out] Collider NMKLBFOLIAN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 ONLDCANPGJN, Vector3 NLEBNOPPEID, float NGMOEEEAAEG, float MALFDDNHAMM, T[] FIBJGLBOBJE, [Out] Vector3 DIGFBEMHOMN, [Out] Collider ICKKBHGPGCD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 ONLDCANPGJN, float NGMOEEEAAEG, Vector3 MPDFCKICKLA, T[] FIBJGLBOBJE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider JIJHGGMKEMF, [Out] T EEMAJLGJMPP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BCJJCIDDKHG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds KHLCPNDBIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform ENJCACDBEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds AFHKHMKCMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform IAIICMINIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 ADDBFEACNCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool APMBGPPMBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool CPDPFBGAFGJ = true, int DIKJLBEHMKE = 0);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool CCLKDEBBNFF, object FDAIGOGAKMH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NFCNOMCMLIB
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LKILNMKOKHH GOKCIOMDNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ABLLJCIJEIA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool MPPJGNHLDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool KPGNPHIJIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool EMAKGLADAOM
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> GCLNIJPGPGE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FHCKDMIKAHG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BJBPIAPELFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int JAKPBLOMNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> FIEIIOGBPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData BNDEDHKBDGD);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData BNDEDHKBDGD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HAHPOPADOBD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T PBAACPJGKNP, [Optional] MHIAMIGKIGC? GIBLAOMCIOC, bool NPJAAGEEBBF = true);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int MGEMHICLKEP, IEnumerable<T> OPELMMBFLGD, bool NPJAAGEEBBF = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int MGEMHICLKEP, IEnumerable<T> OPELMMBFLGD, MHIAMIGKIGC GIBLAOMCIOC, bool NPJAAGEEBBF = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OELBNHGDFOC
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HLCBLEOLOOL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool IOIJHAAHMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool EGDBPPHEHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool GOHCPPKJBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool LBBCNKFNFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class NBEAIMELMPL<TReceiver> : BDJFCNGDJAG<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0DF0", Offset = "0x3EE01F0", VA = "0x183EE0DF0")]
	public NBEAIMELMPL(TReceiver HBMDFELGEPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class JFHGKEEMEGF<TReceiver, TFromTask> : BDJFCNGDJAG<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0DF0", Offset = "0x3EE01F0", VA = "0x183EE0DF0")]
	public JFHGKEEMEGF(TReceiver HBMDFELGEPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class BDJFCNGDJAG<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver HBMDFELGEPK;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x525FF80", Offset = "0x525F380", VA = "0x18525FF80")]
	public BDJFCNGDJAG(TReceiver HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute DOPLNLJCLAM();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class PJKIEOFFMOB<TReceiver, TResult> : BDJFCNGDJAG<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0DF0", Offset = "0x3EE01F0", VA = "0x183EE0DF0")]
	public PJKIEOFFMOB(TReceiver HBMDFELGEPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct GJPLPNODHKJ<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup MJODEJCODJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData KDDMHMBHADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> AHDMCIGBDOE;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x21161D0", Offset = "0x21155D0", VA = "0x1821161D0")]
	public GJPLPNODHKJ(TGroup PDOIMNGBODA, TData BCHELBDEOJF, IEnumerable<TData> LOAJEDIBJBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FHLECAKDNLP<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup MJODEJCODJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> AHDMCIGBDOE;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xDCF0A0", Offset = "0xDCE4A0", VA = "0x180DCF0A0")]
	public FHLECAKDNLP(TGroup PDOIMNGBODA, IEnumerable<TData> LOAJEDIBJBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JBEMJPONNOL<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup MJODEJCODJG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
	public JBEMJPONNOL(TGroup PDOIMNGBODA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct MBDBOLAAKPG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> AHDMCIGBDOE;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
	public MBDBOLAAKPG(IEnumerable<TData> LOAJEDIBJBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AGBAJDJFLCB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KKAEJNABHIP JCGELPJFAOP(GJPLPNODHKJ<TGroup, TData> ENJGNKILCBP);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KKAEJNABHIP OADHLPAGKNM(GJPLPNODHKJ<TGroup, TData> ENJGNKILCBP);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KKAEJNABHIP HPAPFHEMLMG(FHLECAKDNLP<TGroup, TData> ENJGNKILCBP);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KKAEJNABHIP MAJGFHPIFNC(JBEMJPONNOL<TGroup> ENJGNKILCBP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface KJELMKHBDMN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KKAEJNABHIP> JCGELPJFAOP(MBDBOLAAKPG<TData> ENJGNKILCBP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MJILNDAEFLC<TGroup, TData> : PJKIEOFFMOB<AGBAJDJFLCB<TGroup, TData>, KKAEJNABHIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly FHLECAKDNLP<TGroup, TData> ENJGNKILCBP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4820480", Offset = "0x481F880", VA = "0x184820480")]
	public MJILNDAEFLC(TGroup PDOIMNGBODA, IEnumerable<TData> LOAJEDIBJBB, AGBAJDJFLCB<TGroup, TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x48203B0", Offset = "0x481F7B0", VA = "0x1848203B0", Slot = "4")]
	public override KKAEJNABHIP DOPLNLJCLAM()
	{
		return default(KKAEJNABHIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GABJHFFEOFE<TGroup, TData> : PJKIEOFFMOB<AGBAJDJFLCB<TGroup, TData>, KKAEJNABHIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GJPLPNODHKJ<TGroup, TData> ENJGNKILCBP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3FCE9E0", Offset = "0x3FCDDE0", VA = "0x183FCE9E0")]
	public GABJHFFEOFE(TGroup PDOIMNGBODA, TData GIFODDFGEBL, IEnumerable<TData> LOAJEDIBJBB, AGBAJDJFLCB<TGroup, TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3FCE910", Offset = "0x3FCDD10", VA = "0x183FCE910", Slot = "4")]
	public override KKAEJNABHIP DOPLNLJCLAM()
	{
		return default(KKAEJNABHIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HFHGHICCBDL<TGroup, TData> : PJKIEOFFMOB<AGBAJDJFLCB<TGroup, TData>, KKAEJNABHIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly JBEMJPONNOL<TGroup> ENJGNKILCBP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4088080", Offset = "0x4087480", VA = "0x184088080")]
	public HFHGHICCBDL(TGroup PDOIMNGBODA, AGBAJDJFLCB<TGroup, TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4087FC0", Offset = "0x40873C0", VA = "0x184087FC0", Slot = "4")]
	public override KKAEJNABHIP DOPLNLJCLAM()
	{
		return default(KKAEJNABHIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BMDDEALIDAE<TGroup, TData> : PJKIEOFFMOB<AGBAJDJFLCB<TGroup, TData>, KKAEJNABHIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GJPLPNODHKJ<TGroup, TData> ENJGNKILCBP;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3FCE9E0", Offset = "0x3FCDDE0", VA = "0x183FCE9E0")]
	public BMDDEALIDAE(TGroup PDOIMNGBODA, TData BCHELBDEOJF, IEnumerable<TData> LOAJEDIBJBB, AGBAJDJFLCB<TGroup, TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x527C720", Offset = "0x527BB20", VA = "0x18527C720", Slot = "4")]
	public override KKAEJNABHIP DOPLNLJCLAM()
	{
		return default(KKAEJNABHIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DHDCFKGJDIG<TData> : JFHGKEEMEGF<KJELMKHBDMN<TData>, KKAEJNABHIP> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct MCOKJPLNHMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<KKAEJNABHIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DHDCFKGJDIG<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<KKAEJNABHIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x480CF80", Offset = "0x480C380", VA = "0x18480CF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x480D220", Offset = "0x480C620", VA = "0x18480D220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MBDBOLAAKPG<TData> ENJGNKILCBP;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4088080", Offset = "0x4087480", VA = "0x184088080")]
	public DHDCFKGJDIG(IEnumerable<TData> BGNNIDBCJJE, KJELMKHBDMN<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5C2C530", Offset = "0x5C2B930", VA = "0x185C2C530", Slot = "4")]
	[AsyncStateMachine(typeof(DHDCFKGJDIG<>.MCOKJPLNHMC))]
	public override Task<KKAEJNABHIP> DOPLNLJCLAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct FBBILNANELM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly MFAFCCKNJNM ILBGNGBHHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool EHIJIFNKIMO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E31060", Offset = "0x6E30460", VA = "0x186E31060")]
	public FBBILNANELM(MFAFCCKNJNM HHGAGNBDKIH, bool BNMOOKFDIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface DNAMKBGMGBB<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> DOPLNLJCLAM(FBBILNANELM IMOGNNANDCN);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class HMGKFOCEOIM<TSpawnType> : JFHGKEEMEGF<DNAMKBGMGBB<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct EEBMLPCCJHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HMGKFOCEOIM<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3B28A70", Offset = "0x3B27E70", VA = "0x183B28A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3B28E70", Offset = "0x3B28270", VA = "0x183B28E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly FBBILNANELM IMOGNNANDCN;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x40B7DB0", Offset = "0x40B71B0", VA = "0x1840B7DB0")]
	public HMGKFOCEOIM(MFAFCCKNJNM HHGAGNBDKIH, bool BNMOOKFDIIG, DNAMKBGMGBB<TSpawnType> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x40B7B90", Offset = "0x40B6F90", VA = "0x1840B7B90", Slot = "4")]
	[AsyncStateMachine(typeof(HMGKFOCEOIM<>.EEBMLPCCJHO))]
	public override Task<TSpawnType> DOPLNLJCLAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct MFAFCCKNJNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool DCOBBKPIHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 FMOFMIPIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 KHBHMHPABCH;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E31C40", Offset = "0x6E31040", VA = "0x186E31C40")]
	public MFAFCCKNJNM(Transform NEKAAKNIPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E31CB0", Offset = "0x6E310B0", VA = "0x186E31CB0")]
	public MFAFCCKNJNM(Vector3 JNKEFPKOLCG, Vector3 MBJNFCDOKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E31C10", Offset = "0x6E31010", VA = "0x186E31C10")]
	public static MFAFCCKNJNM KPKMHMCCNAE()
	{
		return default(MFAFCCKNJNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E31CE0", Offset = "0x6E310E0", VA = "0x186E31CE0")]
	private MFAFCCKNJNM(bool LEHKCHKKOOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct OCKDKJNNGLB<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode GMFFDGFHFLB;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4A5A8B0", Offset = "0x4A59CB0", VA = "0x184A5A8B0")]
	public OCKDKJNNGLB(TNode GMFFDGFHFLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct INAOCBDPPKD<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode CEFLIJJPDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public MLHJEAGBIEL AGBHNOMCADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool EHIJIFNKIMO;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4211390", Offset = "0x4210790", VA = "0x184211390")]
	public INAOCBDPPKD(TNode CEFLIJJPDKH, MLHJEAGBIEL AGBHNOMCADJ, bool BNMOOKFDIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface OHNMFHMFEOO<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADHLNAIMEOI([In] OCKDKJNNGLB<TNode> DGJIHOMCDDK);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LCPMMPCBJOH([In] INAOCBDPPKD<TNode> CBKBFHPCBHE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NJICEIIMFOB();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CJCELGJLNFG<TNode> : NBEAIMELMPL<OHNMFHMFEOO<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0DF0", Offset = "0x3EE01F0", VA = "0x183EE0DF0")]
	public CJCELGJLNFG(OHNMFHMFEOO<TNode> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x420BED0", Offset = "0x420B2D0", VA = "0x18420BED0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NICLBPCGNKP<TNode> : NBEAIMELMPL<OHNMFHMFEOO<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly INAOCBDPPKD<TNode> CBKBFHPCBHE;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x48BE350", Offset = "0x48BD750", VA = "0x1848BE350")]
	public NICLBPCGNKP(TNode CEFLIJJPDKH, MLHJEAGBIEL AGBHNOMCADJ, OHNMFHMFEOO<TNode> HBMDFELGEPK, bool BNMOOKFDIIG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4061E20", Offset = "0x4061220", VA = "0x184061E20", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NHNHIJIKBAL<TNode> : NBEAIMELMPL<OHNMFHMFEOO<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly OCKDKJNNGLB<TNode> DGJIHOMCDDK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x48B8070", Offset = "0x48B7470", VA = "0x1848B8070")]
	public NHNHIJIKBAL(TNode CPHAPBBIDGJ, OHNMFHMFEOO<TNode> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3F129D0", Offset = "0x3F11DD0", VA = "0x183F129D0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct MCCMHDPNJOD<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo FNKOOLGHGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 MBJNFCDOKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion EFFHGIJAIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float BJGGPAGHNPO;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4805820", Offset = "0x4804C20", VA = "0x184805820")]
	public MCCMHDPNJOD(TSpawnInfo FNKOOLGHGEP, Vector3 MBJNFCDOKCE, Quaternion EFFHGIJAIIE, float BJGGPAGHNPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface IGELIJKIAPA<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> KJPIOCOMLMA([In] MCCMHDPNJOD<TSpawnInfo> OJMIAENPDFB, CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class DMLJLIFLJGP<TSpawnType, TSpawnInfo> : JFHGKEEMEGF<IGELIJKIAPA<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly MCCMHDPNJOD<TSpawnInfo> HJEECPNIDIG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5C60FF0", Offset = "0x5C603F0", VA = "0x185C60FF0")]
	public DMLJLIFLJGP(TSpawnInfo FKEGELBHHHF, Vector3 MBJNFCDOKCE, Quaternion EFFHGIJAIIE, float BJGGPAGHNPO, IGELIJKIAPA<TSpawnType, TSpawnInfo> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x41D8830", Offset = "0x41D7C30", VA = "0x1841D8830", Slot = "4")]
	public override Task<TSpawnType> DOPLNLJCLAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct BAHDAOKFPBH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> AHDMCIGBDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool EHIJIFNKIMO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x52537F0", Offset = "0x5252BF0", VA = "0x1852537F0")]
	public BAHDAOKFPBH(IEnumerable<TData> LOAJEDIBJBB, bool BNMOOKFDIIG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface IENAMDIPHHB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KKAEJNABHIP> DBJGGGELJPI([In] BAHDAOKFPBH<TData> JLHMNNPEILD, CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class IECKGABLNNF<TData> : JFHGKEEMEGF<IENAMDIPHHB<TData>, KKAEJNABHIP> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly BAHDAOKFPBH<TData> NLOEMEHIMGJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x41D8910", Offset = "0x41D7D10", VA = "0x1841D8910")]
	public IECKGABLNNF(IEnumerable<TData> LOAJEDIBJBB, bool BNMOOKFDIIG, IENAMDIPHHB<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x41D8830", Offset = "0x41D7C30", VA = "0x1841D8830", Slot = "4")]
	public override Task<KKAEJNABHIP> DOPLNLJCLAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct KDPELDFGPCP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T ANHPPPBDANF;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x452A570", Offset = "0x4529970", VA = "0x18452A570")]
	public KDPELDFGPCP(T NDFMHMOBGCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface GJIMPMFJFOO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADHLNAIMEOI([In] KDPELDFGPCP<T> NPNJEFNFOBP);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LCPMMPCBJOH();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JPHMGGNCDLL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOPLNLJCLAM([In] PJKEDMPONAI<T> JGGPFFFIBKG);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct PJKEDMPONAI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T ANHPPPBDANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool AACNACMNFAF;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4B6B070", Offset = "0x4B6A470", VA = "0x184B6B070")]
	public PJKEDMPONAI(T NDFMHMOBGCB, bool BPMIJKBHHFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class MOLONMACOBP<T> : NBEAIMELMPL<GJIMPMFJFOO<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0DF0", Offset = "0x3EE01F0", VA = "0x183EE0DF0")]
	public MOLONMACOBP(GJIMPMFJFOO<T> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x484E910", Offset = "0x484DD10", VA = "0x18484E910", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class BDBNFLFAMOO<T> : NBEAIMELMPL<GJIMPMFJFOO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly KDPELDFGPCP<T> NPNJEFNFOBP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x525F380", Offset = "0x525E780", VA = "0x18525F380")]
	public BDBNFLFAMOO(T ANHPPPBDANF, GJIMPMFJFOO<T> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3F129D0", Offset = "0x3F11DD0", VA = "0x183F129D0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class DEEHPLNICGI<T> : NBEAIMELMPL<JPHMGGNCDLL<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly PJKEDMPONAI<T> JGGPFFFIBKG;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5C28C30", Offset = "0x5C28030", VA = "0x185C28C30")]
	public DEEHPLNICGI(T ANHPPPBDANF, bool BPMIJKBHHFH, JPHMGGNCDLL<T> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3F129D0", Offset = "0x3F11DD0", VA = "0x183F129D0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct HOGMKPBNFBL<TData> where TData : notnull, FNDNBDEFLKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> AHDMCIGBDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool FDMGPGPOCEE;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x40BE220", Offset = "0x40BD620", VA = "0x1840BE220")]
	public HOGMKPBNFBL(IEnumerable<TData> AKAIGOLMOFJ, bool LCHBEPONJIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct MHHDBCKJHIN<TData> where TData : notnull, FNDNBDEFLKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> AHDMCIGBDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> CAKPDHIGJCI;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x481CE20", Offset = "0x481C220", VA = "0x18481CE20")]
	public MHHDBCKJHIN(List<TData> AKAIGOLMOFJ, List<bool> HHFMFHBEBCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface FNDNBDEFLKD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool OBNALGGEGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface CJONKEJKBKL<TData> where TData : FNDNBDEFLKD
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOPLNLJCLAM([In] HOGMKPBNFBL<TData> CIPGDHINCND);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOPLNLJCLAM([In] MHHDBCKJHIN<TData> CIPGDHINCND);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface LMFOIMOIHOG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IDPELFKMPJG(T ANHPPPBDANF);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class FGJLOHNNLOK<TData> : NBEAIMELMPL<CJONKEJKBKL<TData>> where TData : notnull, FNDNBDEFLKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HOGMKPBNFBL<TData> CIPGDHINCND;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3F12A90", Offset = "0x3F11E90", VA = "0x183F12A90")]
	public FGJLOHNNLOK(List<TData> LOAJEDIBJBB, bool FDMGPGPOCEE, CJONKEJKBKL<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3F129D0", Offset = "0x3F11DD0", VA = "0x183F129D0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class ALAFIOIJOFJ<TData> : NBEAIMELMPL<CJONKEJKBKL<TData>> where TData : notnull, FNDNBDEFLKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly MHHDBCKJHIN<TData> CIPGDHINCND;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x402D970", Offset = "0x402CD70", VA = "0x18402D970")]
	public ALAFIOIJOFJ(List<TData> LOAJEDIBJBB, List<bool> CAKPDHIGJCI, CJONKEJKBKL<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x402D8B0", Offset = "0x402CCB0", VA = "0x18402D8B0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface HEJJHJDNLJG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KKAEJNABHIP> DOPLNLJCLAM(ODFHPCECHMJ<TData> IPOIAMBGCAD);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class CFCIMHJKKBL<TData> : JFHGKEEMEGF<HEJJHJDNLJG<TData>, KKAEJNABHIP> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct MMALIPDJDAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<KKAEJNABHIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CFCIMHJKKBL<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<KKAEJNABHIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4849920", Offset = "0x4848D20", VA = "0x184849920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4849C00", Offset = "0x4849000", VA = "0x184849C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly ODFHPCECHMJ<TData> AMJAGLDBNNK;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x530FFE0", Offset = "0x530F3E0", VA = "0x18530FFE0")]
	public CFCIMHJKKBL(TData INGGMHCGBEJ, IReadOnlyList<TData> LKMGDEGCMLI, bool BNMOOKFDIIG, HEJJHJDNLJG<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x530FEE0", Offset = "0x530F2E0", VA = "0x18530FEE0", Slot = "4")]
	[AsyncStateMachine(typeof(CFCIMHJKKBL<>.MMALIPDJDAG))]
	public override Task<KKAEJNABHIP> DOPLNLJCLAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct ODFHPCECHMJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData PPJAMIPGPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> KCPMKAKOHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool EHIJIFNKIMO;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4A5AC60", Offset = "0x4A5A060", VA = "0x184A5AC60")]
	public ODFHPCECHMJ(TData INGGMHCGBEJ, IReadOnlyList<TData> LKMGDEGCMLI, bool BNMOOKFDIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface OIOCPBLFLGL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOPLNLJCLAM([In] AOMOKAMEGMJ<TData> AJKPHBMICEL);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface GLFBAMBJAJG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOPLNLJCLAM([In] KBPNDOMLGGI<TData> AJKPHBMICEL);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface DEIMGDACAPK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GKLKAJGNEMN([In] EBHLNCBBMGB<TData> AJKPHBMICEL);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCPMMPCBJOH();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class MCKCFOGCNJK<TData> : NBEAIMELMPL<OIOCPBLFLGL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly AOMOKAMEGMJ<TData> AJKPHBMICEL;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x480CB20", Offset = "0x480BF20", VA = "0x18480CB20")]
	public MCKCFOGCNJK(IEnumerable<TData> LOAJEDIBJBB, APKAPDGLGCH DFKHKPKCOFI, ADLKLKHIHDG LBOPCEJDNFN, float EJHEHHMHEOP, bool BNMOOKFDIIG, OIOCPBLFLGL<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3F129D0", Offset = "0x3F11DD0", VA = "0x183F129D0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class KOEFNJKCFMF<TData> : NBEAIMELMPL<GLFBAMBJAJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly KBPNDOMLGGI<TData> AJKPHBMICEL;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x455B810", Offset = "0x455AC10", VA = "0x18455B810")]
	public KOEFNJKCFMF(TData[] LOAJEDIBJBB, APKAPDGLGCH[] DFKHKPKCOFI, ADLKLKHIHDG[] LBOPCEJDNFN, float[] EJHEHHMHEOP, GLFBAMBJAJG<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4545230", Offset = "0x4544630", VA = "0x184545230", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class DBFPNLICBFB<TData> : NBEAIMELMPL<DEIMGDACAPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0DF0", Offset = "0x3EE01F0", VA = "0x183EE0DF0")]
	public DBFPNLICBFB(DEIMGDACAPK<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2B90", Offset = "0x5BF1F90", VA = "0x185BF2B90", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class KKAHOEKNOHO<TData> : NBEAIMELMPL<DEIMGDACAPK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly EBHLNCBBMGB<TData> AJKPHBMICEL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x45452F0", Offset = "0x45446F0", VA = "0x1845452F0")]
	public KKAHOEKNOHO(IEnumerable<TData> LOAJEDIBJBB, APKAPDGLGCH DFKHKPKCOFI, ADLKLKHIHDG LBOPCEJDNFN, float EJHEHHMHEOP, DEIMGDACAPK<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4545230", Offset = "0x4544630", VA = "0x184545230", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct AOMOKAMEGMJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> AHDMCIGBDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public APKAPDGLGCH LCIPJNBIBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public ADLKLKHIHDG OHHFCMHKMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float EJHEHHMHEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool BNMOOKFDIIG;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x412CA80", Offset = "0x412BE80", VA = "0x18412CA80")]
	public AOMOKAMEGMJ(IEnumerable<TData> LOAJEDIBJBB, APKAPDGLGCH DFKHKPKCOFI, ADLKLKHIHDG LBOPCEJDNFN, float EJHEHHMHEOP, bool BNMOOKFDIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct KBPNDOMLGGI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] AHDMCIGBDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public APKAPDGLGCH[] LCIPJNBIBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public ADLKLKHIHDG[] OHHFCMHKMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] EJHEHHMHEOP;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x451FD50", Offset = "0x451F150", VA = "0x18451FD50")]
	public KBPNDOMLGGI(TData[] LOAJEDIBJBB, APKAPDGLGCH[] DFKHKPKCOFI, ADLKLKHIHDG[] LBOPCEJDNFN, float[] EJHEHHMHEOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct EBHLNCBBMGB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> AHDMCIGBDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public APKAPDGLGCH LCIPJNBIBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public ADLKLKHIHDG OHHFCMHKMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float EJHEHHMHEOP;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E850", Offset = "0x3B1DC50", VA = "0x183B1E850")]
	public EBHLNCBBMGB(IEnumerable<TData> LOAJEDIBJBB, APKAPDGLGCH DFKHKPKCOFI, ADLKLKHIHDG LBOPCEJDNFN, float EJHEHHMHEOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface INCJEKKKOHC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPAPFHEMLMG([In] PALENIGEGDM<TData> JLHMNNPEILD);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAJGFHPIFNC([In] PALENIGEGDM<TData> JLHMNNPEILD);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJDPPOPEEBG([In] bool DEJGEIGAKMP);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IAOHFBNDNHO([In] PALENIGEGDM<TData> JLHMNNPEILD);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLGMKKLKOMJ();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MJMBOFBOBCE([In] TData MCEHDLPAJKF);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class DNGLJCNIHPP<TData> : NBEAIMELMPL<INCJEKKKOHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly PALENIGEGDM<TData> JLHMNNPEILD;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5C9C960", Offset = "0x5C9BD60", VA = "0x185C9C960")]
	public DNGLJCNIHPP(List<TData> AAKOLIDMFPJ, INCJEKKKOHC<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3F129D0", Offset = "0x3F11DD0", VA = "0x183F129D0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class KMOGMMJCCKP<TData> : NBEAIMELMPL<INCJEKKKOHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0DF0", Offset = "0x3EE01F0", VA = "0x183EE0DF0")]
	public KMOGMMJCCKP(INCJEKKKOHC<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4558AC0", Offset = "0x4557EC0", VA = "0x184558AC0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class AELPPGMCJAP<TData> : NBEAIMELMPL<INCJEKKKOHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool BNMOOKFDIIG;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3FA55A0", Offset = "0x3FA49A0", VA = "0x183FA55A0")]
	public AELPPGMCJAP(bool BNMOOKFDIIG, INCJEKKKOHC<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3FA5540", Offset = "0x3FA4940", VA = "0x183FA5540", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class PGFLJCEALGJ<TData> : NBEAIMELMPL<INCJEKKKOHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly PALENIGEGDM<TData> JLHMNNPEILD;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4B5E5F0", Offset = "0x4B5D9F0", VA = "0x184B5E5F0")]
	public PGFLJCEALGJ(List<TData> AAKOLIDMFPJ, bool BNMOOKFDIIG, INCJEKKKOHC<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x402D8B0", Offset = "0x402CCB0", VA = "0x18402D8B0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class HFDNLMBOBAI<TData> : NBEAIMELMPL<INCJEKKKOHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData MCEHDLPAJKF;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4086750", Offset = "0x4085B50", VA = "0x184086750")]
	public HFDNLMBOBAI(TData MCEHDLPAJKF, INCJEKKKOHC<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x40865D0", Offset = "0x40859D0", VA = "0x1840865D0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class FJKNIPCLIJJ<TData> : NBEAIMELMPL<INCJEKKKOHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly PALENIGEGDM<TData> JLHMNNPEILD;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3F2D530", Offset = "0x3F2C930", VA = "0x183F2D530")]
	public FJKNIPCLIJJ(IEnumerable<TData> AAKOLIDMFPJ, INCJEKKKOHC<TData> HBMDFELGEPK, bool BNMOOKFDIIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3F2D3C0", Offset = "0x3F2C7C0", VA = "0x183F2D3C0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct PALENIGEGDM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> AHDMCIGBDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool BNMOOKFDIIG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4B4AD60", Offset = "0x4B4A160", VA = "0x184B4AD60")]
	public PALENIGEGDM(IEnumerable<TData> AKAIGOLMOFJ, bool LPFCPFOGOLA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface FPLJHHGIGBI
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KKAEJNABHIP> DOPLNLJCLAM(LOJAIMMPOGI LDEHPIOPEIL);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class PHPMELBKPJK : JFHGKEEMEGF<FPLJHHGIGBI, KKAEJNABHIP>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct OBGBBKBLDCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<KKAEJNABHIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public PHPMELBKPJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<KKAEJNABHIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6E31EC0", Offset = "0x6E312C0", VA = "0x186E31EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E32140", Offset = "0x6E31540", VA = "0x186E32140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly LOJAIMMPOGI KALNIBDPJEG;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6E322E0", Offset = "0x6E316E0", VA = "0x186E322E0")]
	public PHPMELBKPJK(bool BNMOOKFDIIG, FPLJHHGIGBI HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6E321F0", Offset = "0x6E315F0", VA = "0x186E321F0", Slot = "4")]
	[AsyncStateMachine(typeof(OBGBBKBLDCG))]
	public override Task<KKAEJNABHIP> DOPLNLJCLAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct LOJAIMMPOGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool EHIJIFNKIMO;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x23EC4C0", Offset = "0x23EB8C0", VA = "0x1823EC4C0")]
	public LOJAIMMPOGI(bool BNMOOKFDIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct GJENJJEODBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool DPKHJEIDOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool PKEJJEICCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool BJGGPAGHNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool BNMOOKFDIIG;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x51231D0", Offset = "0x51225D0", VA = "0x1851231D0")]
	public GJENJJEODBM(bool DPKHJEIDOJL, bool PKEJJEICCMN, bool BJGGPAGHNPO, bool BNMOOKFDIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6E31080", Offset = "0x6E30480", VA = "0x186E31080")]
	public GJENJJEODBM(bool PKEJJEICCMN, bool BNMOOKFDIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface GCIDDEFFOBH
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJINAKDFJHB(GJENJJEODBM BJPBBMLMOME);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDBDLBJAKLC(GJENJJEODBM BJPBBMLMOME);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class NADHGIDCDJJ : NBEAIMELMPL<GCIDDEFFOBH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly GJENJJEODBM BJPBBMLMOME;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E31DB0", Offset = "0x6E311B0", VA = "0x186E31DB0")]
	public NADHGIDCDJJ(bool ADJOLMKPBJM, bool PKEJJEICCMN, bool BJGGPAGHNPO, bool BNMOOKFDIIG, GCIDDEFFOBH HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E31D60", Offset = "0x6E31160", VA = "0x186E31D60", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class JOFJFBEMAEP : NBEAIMELMPL<GCIDDEFFOBH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly GJENJJEODBM BJPBBMLMOME;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E316D0", Offset = "0x6E30AD0", VA = "0x186E316D0")]
	public JOFJFBEMAEP(bool PKEJJEICCMN, bool BNMOOKFDIIG, GCIDDEFFOBH HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E31680", Offset = "0x6E30A80", VA = "0x186E31680", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface HGCFDEKPBIN
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOPLNLJCLAM([In] KLAKDCLOGIA JCFMFIMLCFC);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class IPAKEJJOGOF : NBEAIMELMPL<HGCFDEKPBIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly KLAKDCLOGIA JCFMFIMLCFC;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6E314A0", Offset = "0x6E308A0", VA = "0x186E314A0")]
	public IPAKEJJOGOF(Guid[] NEPLPOJBEII, Vector3[] MPCMBJJFAMG, Quaternion[] DLOOMCOKLEH, float[] JDGPLOMCGPM, Dictionary<Guid, Vector3> EAHJONHHOEN, HGCFDEKPBIN HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6E313F0", Offset = "0x6E307F0", VA = "0x186E313F0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface JAHJLAIGBGG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADHLNAIMEOI([In] LJDPCKDHPFL<TData> DGJIHOMCDDK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GKLKAJGNEMN([In] HNMEJHCALHJ HOCEBJDAGDN);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GKLKAJGNEMN([In] OJJJDIKNMBN HOCEBJDAGDN);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LCPMMPCBJOH();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class GKBHAHPGLCJ<TData> : NBEAIMELMPL<JAHJLAIGBGG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0DF0", Offset = "0x3EE01F0", VA = "0x183EE0DF0")]
	public GKBHAHPGLCJ(JAHJLAIGBGG<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3FF9C90", Offset = "0x3FF9090", VA = "0x183FF9C90", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class IPAOPMKLGAL<TData> : NBEAIMELMPL<JAHJLAIGBGG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly HNMEJHCALHJ ABPDEJDJFLB;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x423D680", Offset = "0x423CA80", VA = "0x18423D680")]
	public IPAOPMKLGAL(Vector3 AFEFOPGILPG, bool DPJEFKAABNB, JAHJLAIGBGG<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3F31B30", Offset = "0x3F30F30", VA = "0x183F31B30", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class LILGHOIEENH<TData> : NBEAIMELMPL<JAHJLAIGBGG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly OJJJDIKNMBN ABPDEJDJFLB;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4611B80", Offset = "0x4610F80", VA = "0x184611B80")]
	public LILGHOIEENH(Guid FMPDOABJEOE, int AEAHMAMPNLO, Vector3 MBJNFCDOKCE, Quaternion EFFHGIJAIIE, float MINBCCGNENH, bool DPJEFKAABNB, JAHJLAIGBGG<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4611B20", Offset = "0x4610F20", VA = "0x184611B20", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class GHJNAJPAHLE<TData> : NBEAIMELMPL<JAHJLAIGBGG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly LJDPCKDHPFL<TData> ABPDEJDJFLB;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3FF1F50", Offset = "0x3FF1350", VA = "0x183FF1F50")]
	public GHJNAJPAHLE(TData ANHPPPBDANF, bool BNMOOKFDIIG, JAHJLAIGBGG<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3F129D0", Offset = "0x3F11DD0", VA = "0x183F129D0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct HNMEJHCALHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 AFEFOPGILPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool DPJEFKAABNB;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E312C0", Offset = "0x6E306C0", VA = "0x186E312C0")]
	public HNMEJHCALHJ(Vector3 AFEFOPGILPG, bool DPJEFKAABNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct OJJJDIKNMBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid FMPDOABJEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int AEAHMAMPNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 MBJNFCDOKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion EFFHGIJAIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float MINBCCGNENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool DPJEFKAABNB;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E321B0", Offset = "0x6E315B0", VA = "0x186E321B0")]
	public OJJJDIKNMBN(Guid FMPDOABJEOE, int AEAHMAMPNLO, Vector3 MBJNFCDOKCE, Quaternion EFFHGIJAIIE, float MINBCCGNENH, bool DPJEFKAABNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct LJDPCKDHPFL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData ANHPPPBDANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool BNMOOKFDIIG;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4612CB0", Offset = "0x46120B0", VA = "0x184612CB0")]
	public LJDPCKDHPFL(TData ANHPPPBDANF, bool BNMOOKFDIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface JLEGNAOBGJI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOPLNLJCLAM([In] LDBAPNGIJNL<TData> OBHMBJHEIFE);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOPLNLJCLAM([In] IPKACIGAPPI<TData> OBHMBJHEIFE);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface AGPCOJFKMJI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADHLNAIMEOI([In] MMCLOFENHPP<TData> ECDOMOODEFO);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GKLKAJGNEMN([In] JNDIHBFJOAO HOCEBJDAGDN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LCPMMPCBJOH();
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class FIGBKMMAAJO<TData> : NBEAIMELMPL<JLEGNAOBGJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LDBAPNGIJNL<TData> OBHMBJHEIFE;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3F28EB0", Offset = "0x3F282B0", VA = "0x183F28EB0")]
	public FIGBKMMAAJO(IEnumerable<TData> LOAJEDIBJBB, Vector3 MJCHNFEENKJ, bool BNMOOKFDIIG, JLEGNAOBGJI<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3F129D0", Offset = "0x3F11DD0", VA = "0x183F129D0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class IJIEKPKHNLC<TData> : NBEAIMELMPL<AGPCOJFKMJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0DF0", Offset = "0x3EE01F0", VA = "0x183EE0DF0")]
	public IJIEKPKHNLC(AGPCOJFKMJI<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x420BED0", Offset = "0x420B2D0", VA = "0x18420BED0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class MKGECLKPEKG<TData> : NBEAIMELMPL<AGPCOJFKMJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly MMCLOFENHPP<TData> OBHMBJHEIFE;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x48248E0", Offset = "0x4823CE0", VA = "0x1848248E0")]
	public MKGECLKPEKG(IEnumerable<TData> LOAJEDIBJBB, bool BNMOOKFDIIG, AGPCOJFKMJI<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3F129D0", Offset = "0x3F11DD0", VA = "0x183F129D0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class HAENIEIKMJP<TData> : NBEAIMELMPL<JLEGNAOBGJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly IPKACIGAPPI<TData> OBHMBJHEIFE;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4061EE0", Offset = "0x40612E0", VA = "0x184061EE0")]
	public HAENIEIKMJP(IEnumerable<TData> LOAJEDIBJBB, Vector3 PNFIGKABNHI, MGDLDGPNFKA JAKMFMGFAKO, bool BNMOOKFDIIG, JLEGNAOBGJI<TData> HBMDFELGEPK, Space PGDGLABFFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4061E20", Offset = "0x4061220", VA = "0x184061E20", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class FLPIGKHJEKK<TData> : NBEAIMELMPL<AGPCOJFKMJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly JNDIHBFJOAO OBHMBJHEIFE;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3F31B90", Offset = "0x3F30F90", VA = "0x183F31B90")]
	public FLPIGKHJEKK(Vector3 MJCHNFEENKJ, AGPCOJFKMJI<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3F31B30", Offset = "0x3F30F30", VA = "0x183F31B30", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct LDBAPNGIJNL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> LOAJEDIBJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 MJCHNFEENKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool BNMOOKFDIIG;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x45D4550", Offset = "0x45D3950", VA = "0x1845D4550")]
	public LDBAPNGIJNL(IEnumerable<TData> LOAJEDIBJBB, Vector3 MJCHNFEENKJ, bool BNMOOKFDIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct MMCLOFENHPP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> LOAJEDIBJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool BNMOOKFDIIG;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4849C70", Offset = "0x4849070", VA = "0x184849C70")]
	public MMCLOFENHPP(IEnumerable<TData> LOAJEDIBJBB, bool BNMOOKFDIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct IPKACIGAPPI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> LOAJEDIBJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 PNFIGKABNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly MGDLDGPNFKA JAKMFMGFAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool BNMOOKFDIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space PGDGLABFFEJ;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x424B840", Offset = "0x424AC40", VA = "0x18424B840")]
	public IPKACIGAPPI(IEnumerable<TData> LOAJEDIBJBB, Vector3 PNFIGKABNHI, MGDLDGPNFKA JAKMFMGFAKO, bool BNMOOKFDIIG, Space PGDGLABFFEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct JNDIHBFJOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 MJCHNFEENKJ;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x23E9340", Offset = "0x23E8740", VA = "0x1823E9340")]
	public JNDIHBFJOAO(Vector3 MJCHNFEENKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum MGDLDGPNFKA
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
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface DBCMANMLFEM
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOPLNLJCLAM([In] PEIJIHKPOHH DLOAPJMMEGH);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class IHJLDMKHDLA : NBEAIMELMPL<DBCMANMLFEM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly PEIJIHKPOHH DLOAPJMMEGH;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6E31390", Offset = "0x6E30790", VA = "0x186E31390")]
	public IHJLDMKHDLA(bool BNMOOKFDIIG, DBCMANMLFEM HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6E312E0", Offset = "0x6E306E0", VA = "0x186E312E0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct PEIJIHKPOHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool BNMOOKFDIIG;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x23EC4C0", Offset = "0x23EB8C0", VA = "0x1823EC4C0")]
	public PEIJIHKPOHH(bool BNMOOKFDIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface BPLLFNCMNGB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOPLNLJCLAM([In] POEGCFJOFHO<TData> PNEHGOLHOIE);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOPLNLJCLAM([In] ONOIOFPDDOG<TData> PNEHGOLHOIE);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface EIDIBHKEPEK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADHLNAIMEOI([In] KBEOCOPECLM<TData> DGJIHOMCDDK);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GKLKAJGNEMN([In] JCGIEHICOCP HOCEBJDAGDN);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LCPMMPCBJOH();
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class HEHKDNDFPMF<TData> : NBEAIMELMPL<BPLLFNCMNGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly POEGCFJOFHO<TData> PNEHGOLHOIE;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x40855C0", Offset = "0x40849C0", VA = "0x1840855C0")]
	public HEHKDNDFPMF(IEnumerable<TData> LOAJEDIBJBB, Quaternion MJCHNFEENKJ, Vector3? KEPKMDFNLHG, bool AMPDMBDOPDO, bool BNMOOKFDIIG, BPLLFNCMNGB<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3F129D0", Offset = "0x3F11DD0", VA = "0x183F129D0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class DPDGDAPMJAA<TData> : NBEAIMELMPL<EIDIBHKEPEK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0DF0", Offset = "0x3EE01F0", VA = "0x183EE0DF0")]
	public DPDGDAPMJAA(EIDIBHKEPEK<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x420BED0", Offset = "0x420B2D0", VA = "0x18420BED0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class NENAPFIEPMJ<TData> : NBEAIMELMPL<EIDIBHKEPEK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly KBEOCOPECLM<TData> PNEHGOLHOIE;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x48A1EE0", Offset = "0x48A12E0", VA = "0x1848A1EE0")]
	public NENAPFIEPMJ(IEnumerable<TData> LOAJEDIBJBB, bool BNMOOKFDIIG, EIDIBHKEPEK<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3F129D0", Offset = "0x3F11DD0", VA = "0x183F129D0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class MKOFLONJDMA<TData> : NBEAIMELMPL<BPLLFNCMNGB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly ONOIOFPDDOG<TData> PNEHGOLHOIE;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4826A20", Offset = "0x4825E20", VA = "0x184826A20")]
	public MKOFLONJDMA(IEnumerable<TData> LOAJEDIBJBB, Quaternion ACJPMEEMBMI, MGDLDGPNFKA JFOFCFALHFO, Vector3? KEPKMDFNLHG, bool AMPDMBDOPDO, bool BNMOOKFDIIG, Space PGDGLABFFEJ, BPLLFNCMNGB<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4061E20", Offset = "0x4061220", VA = "0x184061E20", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class ADKEAFCHPFM<TData> : NBEAIMELMPL<EIDIBHKEPEK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly JCGIEHICOCP PNEHGOLHOIE;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3FA2AF0", Offset = "0x3FA1EF0", VA = "0x183FA2AF0")]
	public ADKEAFCHPFM(Quaternion MJCHNFEENKJ, Vector3? KEPKMDFNLHG, bool AMPDMBDOPDO, EIDIBHKEPEK<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3F31B30", Offset = "0x3F30F30", VA = "0x183F31B30", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct POEGCFJOFHO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> LOAJEDIBJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion MJCHNFEENKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? KEPKMDFNLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool AMPDMBDOPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool BNMOOKFDIIG;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4B78080", Offset = "0x4B77480", VA = "0x184B78080")]
	public POEGCFJOFHO(IEnumerable<TData> LOAJEDIBJBB, Quaternion MJCHNFEENKJ, Vector3? KEPKMDFNLHG, bool AMPDMBDOPDO, bool BNMOOKFDIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct KBEOCOPECLM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> LOAJEDIBJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool BNMOOKFDIIG;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x451D420", Offset = "0x451C820", VA = "0x18451D420")]
	public KBEOCOPECLM(IEnumerable<TData> LOAJEDIBJBB, bool BNMOOKFDIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct ONOIOFPDDOG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> LOAJEDIBJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion ACJPMEEMBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly MGDLDGPNFKA JFOFCFALHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? KEPKMDFNLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool AMPDMBDOPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool BNMOOKFDIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space PGDGLABFFEJ;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4AB1030", Offset = "0x4AB0430", VA = "0x184AB1030")]
	public ONOIOFPDDOG(IEnumerable<TData> LOAJEDIBJBB, Quaternion ACJPMEEMBMI, MGDLDGPNFKA JFOFCFALHFO, Vector3? KEPKMDFNLHG, bool AMPDMBDOPDO, bool BNMOOKFDIIG, Space PGDGLABFFEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct JCGIEHICOCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion MJCHNFEENKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? KEPKMDFNLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool AMPDMBDOPDO;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x50BD890", Offset = "0x50BCC90", VA = "0x1850BD890")]
	public JCGIEHICOCP(Quaternion MJCHNFEENKJ, Vector3? KEPKMDFNLHG, bool AMPDMBDOPDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface OAGJGFAPJLC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADHLNAIMEOI([In] DJMNGEPAGHI<TData> DGJIHOMCDDK);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GKLKAJGNEMN([In] NILKJFAFOIH HOCEBJDAGDN);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GKLKAJGNEMN([In] LIBJKLLNEEK HOCEBJDAGDN);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GKLKAJGNEMN([In] LKGFJODBINA HOCEBJDAGDN);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LCPMMPCBJOH();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class GJPNGICMAKL<TData> : NBEAIMELMPL<OAGJGFAPJLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly LKGFJODBINA MOJMJJMOBFI;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3FF9B70", Offset = "0x3FF8F70", VA = "0x183FF9B70")]
	public GJPNGICMAKL(Vector3 EFNPLLGKOKG, float EGIABFGPJJA, Vector3 KEPKMDFNLHG, bool PNJCBLCCIGE, bool AGBFHLAJAOJ, OAGJGFAPJLC<TData> HBMDFELGEPK, Space PGDGLABFFEJ = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3FF9B10", Offset = "0x3FF8F10", VA = "0x183FF9B10", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class PMHIOAEEBEO<TData> : NBEAIMELMPL<OAGJGFAPJLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0DF0", Offset = "0x3EE01F0", VA = "0x183EE0DF0")]
	public PMHIOAEEBEO(OAGJGFAPJLC<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4B76540", Offset = "0x4B75940", VA = "0x184B76540", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class GAGCCGKHPAH<TData> : NBEAIMELMPL<OAGJGFAPJLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly DJMNGEPAGHI<TData> MOJMJJMOBFI;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3FD2A60", Offset = "0x3FD1E60", VA = "0x183FD2A60")]
	public GAGCCGKHPAH(IEnumerable<TData> LOAJEDIBJBB, bool BNMOOKFDIIG, OAGJGFAPJLC<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3F129D0", Offset = "0x3F11DD0", VA = "0x183F129D0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class ACNEDGEIODG<TData> : NBEAIMELMPL<OAGJGFAPJLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly LIBJKLLNEEK MOJMJJMOBFI;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3F86E90", Offset = "0x3F86290", VA = "0x183F86E90")]
	public ACNEDGEIODG(float NAKOKLPMKNJ, bool IFLMDEBJJLH, Vector3 KEPKMDFNLHG, OAGJGFAPJLC<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3F86DD0", Offset = "0x3F861D0", VA = "0x183F86DD0", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class JMFDGACDLNF<TData> : NBEAIMELMPL<OAGJGFAPJLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NILKJFAFOIH MOJMJJMOBFI;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4443510", Offset = "0x4442910", VA = "0x184443510")]
	public JMFDGACDLNF(float EGIABFGPJJA, Vector3 KEPKMDFNLHG, OAGJGFAPJLC<TData> HBMDFELGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3F31B30", Offset = "0x3F30F30", VA = "0x183F31B30", Slot = "4")]
	public override bool DOPLNLJCLAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct LKGFJODBINA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 EFNPLLGKOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float EGIABFGPJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 KEPKMDFNLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool DPJEFKAABNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space PGDGLABFFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool AGBFHLAJAOJ;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6E31BD0", Offset = "0x6E30FD0", VA = "0x186E31BD0")]
	public LKGFJODBINA(Vector3 EFNPLLGKOKG, float EGIABFGPJJA, Vector3 KEPKMDFNLHG, bool DPJEFKAABNB, bool GLIBFPAONIL, Space PGDGLABFFEJ = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct DJMNGEPAGHI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> LOAJEDIBJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool BNMOOKFDIIG;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5C34410", Offset = "0x5C33810", VA = "0x185C34410")]
	public DJMNGEPAGHI(IEnumerable<TData> LOAJEDIBJBB, bool BNMOOKFDIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct LIBJKLLNEEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float NAKOKLPMKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool IFLMDEBJJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 KEPKMDFNLHG;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6E31BB0", Offset = "0x6E30FB0", VA = "0x186E31BB0")]
	public LIBJKLLNEEK(float NAKOKLPMKNJ, bool IFLMDEBJJLH, Vector3 KEPKMDFNLHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct NILKJFAFOIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float EGIABFGPJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 KEPKMDFNLHG;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x507E8B0", Offset = "0x507DCB0", VA = "0x18507E8B0")]
	public NILKJFAFOIH(float EGIABFGPJJA, Vector3 KEPKMDFNLHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct KLAKDCLOGIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] LOAJEDIBJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool KANNJNJPHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool LBCIKAJAPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool NBHPKNMHJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] MPCMBJJFAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] DLOOMCOKLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] JDGPLOMCGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> EAHJONHHOEN;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E31920", Offset = "0x6E30D20", VA = "0x186E31920")]
	public KLAKDCLOGIA(Guid[] NEPLPOJBEII, Vector3[] MPCMBJJFAMG, Quaternion[] DLOOMCOKLEH, float[] JDGPLOMCGPM, Dictionary<Guid, Vector3> EAHJONHHOEN, bool KANNJNJPHFC = true, bool LBCIKAJAPKB = true, bool NBHPKNMHJPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E31750", Offset = "0x6E30B50", VA = "0x186E31750")]
	private static void LLBMGLOCNMK(Dictionary<Guid, Vector3> EAHJONHHOEN, int POJGNMIECHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class AHIDKGJKLMD
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct JIJIKJBEGOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool JMEKEBJJABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public ACFNHMKNHLL CJFBDCDDAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public ACFNHMKNHLL JDDLGLFIBOL;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static JIJIKJBEGOG MNEMDGOIIKO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken PLCFFPJIEOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6E30F00", Offset = "0x6E30300", VA = "0x186E30F00")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static ACFNHMKNHLL CJFBDCDDAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6E30E60", Offset = "0x6E30260", VA = "0x186E30E60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6E30E00", Offset = "0x6E30200", VA = "0x186E30E00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6E30F70", Offset = "0x6E30370", VA = "0x186E30F70")]
	[FHFMOACGLML.FCMFIOLNDJB]
	internal static void PGACNHLPKNC(ACFNHMKNHLL JDJJJGFPPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6E30CC0", Offset = "0x6E300C0", VA = "0x186E30CC0")]
	public static void AEAEDDMNDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6E30F20", Offset = "0x6E30320", VA = "0x186E30F20")]
	private static ACFNHMKNHLL OGFLEEKHBKE(ACFNHMKNHLL GLFNOJJKPGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class AMNJODCHLKK
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum EPDLHCLBHMB
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x35762E0", Offset = "0x35756E0", VA = "0x1835762E0")]
	public static void MNAHFPMBJOO<T>(T FECLIDFMLKB, EPDLHCLBHMB LGJDMOCCBDP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3576270", Offset = "0x3575670", VA = "0x183576270")]
	public static void MNAHFPMBJOO<T>(T FECLIDFMLKB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3576440", Offset = "0x3575840", VA = "0x183576440")]
	public static void NEFHLBECMAO<T>(T FECLIDFMLKB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x35761C0", Offset = "0x35755C0", VA = "0x1835761C0")]
	public static T JEMJOLBMCNL<T>(EPDLHCLBHMB LGJDMOCCBDP) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3575F60", Offset = "0x3575360", VA = "0x183575F60")]
	public static bool CPMADEOKHEK<T>(EPDLHCLBHMB LGJDMOCCBDP, T? LHFAALHKKED, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T JBHKHMIAFLL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3576110", Offset = "0x3575510", VA = "0x183576110")]
	public static bool HGBMKMHELHA<T>(EPDLHCLBHMB LGJDMOCCBDP) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x35760B0", Offset = "0x35754B0", VA = "0x1835760B0")]
	public static T JEMJOLBMCNL<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3575EA0", Offset = "0x35752A0", VA = "0x183575EA0")]
	public static bool CPMADEOKHEK<T>(T LHFAALHKKED, [Out] T JBHKHMIAFLL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x35760B0", Offset = "0x35754B0", VA = "0x1835760B0")]
	public static bool HGBMKMHELHA<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class HMPBJMMLPKE
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6E31090", Offset = "0x6E30490", VA = "0x186E31090")]
	public static void LCMMAIABPLJ(IEnumerable HGFDBGLHPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2E893F0", Offset = "0x2E887F0", VA = "0x182E893F0")]
	public static void LCMMAIABPLJ<T>(T[] AFBDFGIDJPF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2E894E0", Offset = "0x2E888E0", VA = "0x182E894E0")]
	public static void LCMMAIABPLJ<T>(T CCLPDLLIEKA) where T : notnull, Enum
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
