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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F89910", Offset = "0x5F88D10", VA = "0x185F89910")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C8560", Offset = "0x7C7960", VA = "0x1807C8560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C85A0", Offset = "0x7C79A0", VA = "0x1807C85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KKEOHCCKPGJ<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn INHCKDBOGKH(TData MBCPMMHPENP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DMGKCEAMGEH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(GGDKHGHLMMD IELEOOOCNGO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData DAPOBFHGAGK, Collider CABDPLJKHIE, GGDKHGHLMMD IELEOOOCNGO, [Optional] PNAKLNMDHCF? PMAHHGMCMFB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData DAPOBFHGAGK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider CABDPLJKHIE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MAKECMINMHI<TData> : KCNLDPDJCMA, LCANPCFJAAL<TData>, IJMFPCLOOGK<TData>, GMNFMMCJNMN<TData>, ACFMBMAGCCH, CPOGHPOFNND<TData>, EOLFFMLADJD, PFJADFFKFCK
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CPOGHPOFNND<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 OBPFNHMCCMM, Vector3 HLJLNEHEKPN, float KHEIIGEIBGI, [Out] T NEDPEDOKHMK, [Out] Vector3 IIMHCLOGJME, [Out] Collider CABDPLJKHIE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 OBPFNHMCCMM, Vector3 HLJLNEHEKPN, float GJLKEFEKAJD, float KHEIIGEIBGI, T[] ODKGIMAGKAG, [Out] Vector3 AGPHDHCDCOE, [Out] Collider KIAEKCEKAMO);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 OBPFNHMCCMM, float GJLKEFEKAJD, Vector3 MEHOKALONNH, T[] ODKGIMAGKAG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider GEAGIMEEIEK, [Out] T ONBMGGDNGCA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KCNLDPDJCMA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds HFNICMBHCNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform CABLBMPGELK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds MPBBBCOGCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform PDJDOEJOLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 HJHLIKHKGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JBAAJDGEECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool BPDMKGNKFJA = true, int OLLBJECOPME = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool PFEMCJBKMJF, object FACMOGNGACN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PFJADFFKFCK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	KKEEGFAPLDK MIEAAKNPLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IOJCOMPONDK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PPLDJIJAECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool LCHNGHJODEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IOJGCJNEFHE
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> GMKEKPDCFIA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GMNFMMCJNMN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool JJBJJDOMMEA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int NBKIDHGIPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> PFAJLLNBMJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData ELCFHMHMPMJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData ELCFHMHMPMJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LCANPCFJAAL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T MBCPMMHPENP, [Optional] PNAKLNMDHCF? KJDBNOPJOLM, bool DKHJLKMMLDJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int DPBEIPGOMHN, IEnumerable<T> AIEAHONEFEF, bool DKHJLKMMLDJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int DPBEIPGOMHN, IEnumerable<T> AIEAHONEFEF, PNAKLNMDHCF KJDBNOPJOLM, bool DKHJLKMMLDJ = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EOLFFMLADJD
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ACFMBMAGCCH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HFCLHCIOICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool ABLMDDLAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool BIINFMKMNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool GLMFBBPGIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class CDLLPHMDLIN<TReceiver> : CPAGMKDCBBM<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x31CD680", Offset = "0x31CCA80", VA = "0x1831CD680")]
	public CDLLPHMDLIN(TReceiver KEHMNIODKBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class KDLLNFEBJHI<TReceiver, TFromTask> : CPAGMKDCBBM<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x31CD680", Offset = "0x31CCA80", VA = "0x1831CD680")]
	public KDLLNFEBJHI(TReceiver KEHMNIODKBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class CPAGMKDCBBM<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver KEHMNIODKBI;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E9F0", Offset = "0x4A2DDF0", VA = "0x184A2E9F0")]
	public CPAGMKDCBBM(TReceiver KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute AJPMKBDPCCA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class NGAJFKHCLIC<TReceiver, TResult> : CPAGMKDCBBM<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x31CD680", Offset = "0x31CCA80", VA = "0x1831CD680")]
	public NGAJFKHCLIC(TReceiver KEHMNIODKBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct AJFAOCKAKDH<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup IFBAGKCFOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData EGHHACAIPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> OMNJBIGMHOA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1A31300", Offset = "0x1A30700", VA = "0x181A31300")]
	public AJFAOCKAKDH(TGroup KBENDGMKEDN, TData GIJFEDBIJGF, IEnumerable<TData> FOIGBKBEFFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct OJAJLOFIBHN<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup IFBAGKCFOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> OMNJBIGMHOA;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8833F0", Offset = "0x8827F0", VA = "0x1808833F0")]
	public OJAJLOFIBHN(TGroup KBENDGMKEDN, IEnumerable<TData> FOIGBKBEFFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DIPOPHHKGNL<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup IFBAGKCFOFD;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF70", Offset = "0x8BB370", VA = "0x1808BBF70")]
	public DIPOPHHKGNL(TGroup KBENDGMKEDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DMOIABNEPHO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> OMNJBIGMHOA;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF70", Offset = "0x8BB370", VA = "0x1808BBF70")]
	public DMOIABNEPHO(IEnumerable<TData> FOIGBKBEFFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ELMHALJOAGG<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FICCLMDNABN GFAELLKMKDJ(AJFAOCKAKDH<TGroup, TData> EDCPAKPCBKP);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FICCLMDNABN IEPKIIBPLMM(AJFAOCKAKDH<TGroup, TData> EDCPAKPCBKP);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FICCLMDNABN MKFGMHCIIFM(OJAJLOFIBHN<TGroup, TData> EDCPAKPCBKP);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FICCLMDNABN DNJMDOFOCCA(DIPOPHHKGNL<TGroup> EDCPAKPCBKP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CNKBMJEPKPE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FICCLMDNABN> GFAELLKMKDJ(DMOIABNEPHO<TData> EDCPAKPCBKP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EFMDMFAPDDH<TGroup, TData> : NGAJFKHCLIC<ELMHALJOAGG<TGroup, TData>, FICCLMDNABN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly OJAJLOFIBHN<TGroup, TData> EDCPAKPCBKP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x31DF600", Offset = "0x31DEA00", VA = "0x1831DF600")]
	public EFMDMFAPDDH(TGroup KBENDGMKEDN, IEnumerable<TData> FOIGBKBEFFJ, ELMHALJOAGG<TGroup, TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x31DF530", Offset = "0x31DE930", VA = "0x1831DF530", Slot = "4")]
	public override FICCLMDNABN AJPMKBDPCCA()
	{
		return default(FICCLMDNABN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CAOJPGFPKPH<TGroup, TData> : NGAJFKHCLIC<ELMHALJOAGG<TGroup, TData>, FICCLMDNABN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly AJFAOCKAKDH<TGroup, TData> EDCPAKPCBKP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3E02420", Offset = "0x3E01820", VA = "0x183E02420")]
	public CAOJPGFPKPH(TGroup KBENDGMKEDN, TData PODAJBAHBLG, IEnumerable<TData> FOIGBKBEFFJ, ELMHALJOAGG<TGroup, TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x47864B0", Offset = "0x47858B0", VA = "0x1847864B0", Slot = "4")]
	public override FICCLMDNABN AJPMKBDPCCA()
	{
		return default(FICCLMDNABN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KEDDOEJMGDB<TGroup, TData> : NGAJFKHCLIC<ELMHALJOAGG<TGroup, TData>, FICCLMDNABN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly DIPOPHHKGNL<TGroup> EDCPAKPCBKP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x357C4B0", Offset = "0x357B8B0", VA = "0x18357C4B0")]
	public KEDDOEJMGDB(TGroup KBENDGMKEDN, ELMHALJOAGG<TGroup, TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3A64AB0", Offset = "0x3A63EB0", VA = "0x183A64AB0", Slot = "4")]
	public override FICCLMDNABN AJPMKBDPCCA()
	{
		return default(FICCLMDNABN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NJMOAMBGJFP<TGroup, TData> : NGAJFKHCLIC<ELMHALJOAGG<TGroup, TData>, FICCLMDNABN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly AJFAOCKAKDH<TGroup, TData> EDCPAKPCBKP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E02420", Offset = "0x3E01820", VA = "0x183E02420")]
	public NJMOAMBGJFP(TGroup KBENDGMKEDN, TData GIJFEDBIJGF, IEnumerable<TData> FOIGBKBEFFJ, ELMHALJOAGG<TGroup, TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E02340", Offset = "0x3E01740", VA = "0x183E02340", Slot = "4")]
	public override FICCLMDNABN AJPMKBDPCCA()
	{
		return default(FICCLMDNABN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FGDIGLNHACB<TData> : KDLLNFEBJHI<CNKBMJEPKPE<TData>, FICCLMDNABN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct AKNAIEGPNIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<FICCLMDNABN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FGDIGLNHACB<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<FICCLMDNABN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x365D520", Offset = "0x365C920", VA = "0x18365D520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x365D7C0", Offset = "0x365CBC0", VA = "0x18365D7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private DMOIABNEPHO<TData> EDCPAKPCBKP;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x357C4B0", Offset = "0x357B8B0", VA = "0x18357C4B0")]
	public FGDIGLNHACB(IEnumerable<TData> OKGOHICACAH, CNKBMJEPKPE<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x357C3B0", Offset = "0x357B7B0", VA = "0x18357C3B0", Slot = "4")]
	[AsyncStateMachine(typeof(FGDIGLNHACB<>.AKNAIEGPNIB))]
	public override Task<FICCLMDNABN> AJPMKBDPCCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct DAJBJLJGOMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly MEDMJHBJEGN MNHNLFPEDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool PHBLIMHIMCF;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5F88DE0", Offset = "0x5F881E0", VA = "0x185F88DE0")]
	public DAJBJLJGOMO(MEDMJHBJEGN LIJMOHIKNCD, bool MOJKOFEPLCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DOHPIPJMNAK<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> AJPMKBDPCCA(DAJBJLJGOMO DJJDEBKAFMD);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MHLLGAHDMHI<TSpawnType> : KDLLNFEBJHI<DOHPIPJMNAK<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct LAADCEMBNJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MHLLGAHDMHI<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3B10930", Offset = "0x3B0FD30", VA = "0x183B10930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3B110F0", Offset = "0x3B104F0", VA = "0x183B110F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly DAJBJLJGOMO DJJDEBKAFMD;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D55F70", Offset = "0x3D55370", VA = "0x183D55F70")]
	public MHLLGAHDMHI(MEDMJHBJEGN LIJMOHIKNCD, bool MOJKOFEPLCL, DOHPIPJMNAK<TSpawnType> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D55D70", Offset = "0x3D55170", VA = "0x183D55D70", Slot = "4")]
	[AsyncStateMachine(typeof(MHLLGAHDMHI<>.LAADCEMBNJK))]
	public override Task<TSpawnType> AJPMKBDPCCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct MEDMJHBJEGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool GFFCCDKLIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 KIOOKMJBFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 FFAIKMBLIMK;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5F89780", Offset = "0x5F88B80", VA = "0x185F89780")]
	public MEDMJHBJEGN(Transform BBEJALEDEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5F897F0", Offset = "0x5F88BF0", VA = "0x185F897F0")]
	public MEDMJHBJEGN(Vector3 GKJEHHDBDOI, Vector3 HGKJDOIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5F896C0", Offset = "0x5F88AC0", VA = "0x185F896C0")]
	public static MEDMJHBJEGN GOIMIPPOIPI()
	{
		return default(MEDMJHBJEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5F896F0", Offset = "0x5F88AF0", VA = "0x185F896F0")]
	private MEDMJHBJEGN(bool ECJJLPCJADE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct EEIDAHIKLCE<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode KNHHNAMLEIA;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x31DBA20", Offset = "0x31DAE20", VA = "0x1831DBA20")]
	public EEIDAHIKLCE(TNode KNHHNAMLEIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct HOHFNBKPCCP<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode KAGIEGAILAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public PEHJCCMFICG ECCDGACFELL;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3702BF0", Offset = "0x3701FF0", VA = "0x183702BF0")]
	public HOHFNBKPCCP(TNode KAGIEGAILAG, PEHJCCMFICG ECCDGACFELL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BIAMNALKJJH<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEDDJCLMKHA([In] EEIDAHIKLCE<TNode> ECIAEDCAEHN);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CFGJIFLKBCE([In] HOHFNBKPCCP<TNode> BPLLJPBOENH);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ILDAPBENIJJ();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class BONNGGKEAIK<TNode> : CDLLPHMDLIN<BIAMNALKJJH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x31CD680", Offset = "0x31CCA80", VA = "0x1831CD680")]
	public BONNGGKEAIK(BIAMNALKJJH<TNode> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3B4A5C0", Offset = "0x3B499C0", VA = "0x183B4A5C0", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class IMOAGOGMHCP<TNode> : CDLLPHMDLIN<BIAMNALKJJH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HOHFNBKPCCP<TNode> BPLLJPBOENH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x37CD6D0", Offset = "0x37CCAD0", VA = "0x1837CD6D0")]
	public IMOAGOGMHCP(TNode KAGIEGAILAG, PEHJCCMFICG ECCDGACFELL, BIAMNALKJJH<TNode> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3205680", Offset = "0x3204A80", VA = "0x183205680", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DJJKILJNDBI<TNode> : CDLLPHMDLIN<BIAMNALKJJH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly EEIDAHIKLCE<TNode> ECIAEDCAEHN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5E30", Offset = "0x4EA5230", VA = "0x184EA5E30")]
	public DJJKILJNDBI(TNode KBDAACBGKLD, BIAMNALKJJH<TNode> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3632470", Offset = "0x3631870", VA = "0x183632470", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct HOOPBGEIMLM<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo GMLFNKNDPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 HGKJDOIPDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion PGPLGEJKHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float CMIJAKFGAEH;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x37037D0", Offset = "0x3702BD0", VA = "0x1837037D0")]
	public HOOPBGEIMLM(TSpawnInfo GMLFNKNDPNC, Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI, float CMIJAKFGAEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LEJIHDEPLIM<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> NNBNILCLIBJ([In] HOOPBGEIMLM<TSpawnInfo> PLOMMFAAOBM, CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class MFBDDLKEDGP<TSpawnType, TSpawnInfo> : KDLLNFEBJHI<LEJIHDEPLIM<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly HOOPBGEIMLM<TSpawnInfo> AHLEFKCGEBC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3D4C4D0", Offset = "0x3D4B8D0", VA = "0x183D4C4D0")]
	public MFBDDLKEDGP(TSpawnInfo BJKOKMDDKGL, Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI, float CMIJAKFGAEH, LEJIHDEPLIM<TSpawnType, TSpawnInfo> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3D37F00", Offset = "0x3D37300", VA = "0x183D37F00", Slot = "4")]
	public override Task<TSpawnType> AJPMKBDPCCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct HNLHKKPFFMO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> OMNJBIGMHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool PHBLIMHIMCF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x37016D0", Offset = "0x3700AD0", VA = "0x1837016D0")]
	public HNLHKKPFFMO(IEnumerable<TData> FOIGBKBEFFJ, bool MOJKOFEPLCL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface IGIBPCADCFK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FICCLMDNABN> POBDNFLKGKG([In] HNLHKKPFFMO<TData> DEEAIJOECLC, CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class MCHJKCJLDKD<TData> : KDLLNFEBJHI<IGIBPCADCFK<TData>, FICCLMDNABN> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HNLHKKPFFMO<TData> JOCJEPHFMGH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3D38070", Offset = "0x3D37470", VA = "0x183D38070")]
	public MCHJKCJLDKD(IEnumerable<TData> FOIGBKBEFFJ, bool MOJKOFEPLCL, IGIBPCADCFK<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3D37F00", Offset = "0x3D37300", VA = "0x183D37F00", Slot = "4")]
	public override Task<FICCLMDNABN> AJPMKBDPCCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct DAPHBCCFOAA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T DAPOBFHGAGK;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3B72B90", Offset = "0x3B71F90", VA = "0x183B72B90")]
	public DAPHBCCFOAA(T ICCODGIHNBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FNIFLCCDLOA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEDDJCLMKHA([In] DAPHBCCFOAA<T> CMJFGAEMDNN);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CFGJIFLKBCE();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MFOECFBBGHI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJPMKBDPCCA([In] ONAFBHFLPNL<T> OILGJHICOCB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct ONAFBHFLPNL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T DAPOBFHGAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool EKFDFBFNLBD;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3EFCD10", Offset = "0x3EFC110", VA = "0x183EFCD10")]
	public ONAFBHFLPNL(T ICCODGIHNBB, bool EOBPFEJDEMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class HOGDBOJLIBO<T> : CDLLPHMDLIN<FNIFLCCDLOA<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x31CD680", Offset = "0x31CCA80", VA = "0x1831CD680")]
	public HOGDBOJLIBO(FNIFLCCDLOA<T> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x37029E0", Offset = "0x3701DE0", VA = "0x1837029E0", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class NOCHLDCJIPJ<T> : CDLLPHMDLIN<FNIFLCCDLOA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly DAPHBCCFOAA<T> CMJFGAEMDNN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3E12AC0", Offset = "0x3E11EC0", VA = "0x183E12AC0")]
	public NOCHLDCJIPJ(T DAPOBFHGAGK, FNIFLCCDLOA<T> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3632470", Offset = "0x3631870", VA = "0x183632470", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JCFPHNDCKGO<T> : CDLLPHMDLIN<MFOECFBBGHI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly ONAFBHFLPNL<T> OILGJHICOCB;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x395E8E0", Offset = "0x395DCE0", VA = "0x18395E8E0")]
	public JCFPHNDCKGO(T DAPOBFHGAGK, bool EOBPFEJDEMA, MFOECFBBGHI<T> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3632470", Offset = "0x3631870", VA = "0x183632470", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct POODIMDADFN<TData> where TData : notnull, PCCLJPHJGOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> OMNJBIGMHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool LOIOIJGFJEK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3FDE7D0", Offset = "0x3FDDBD0", VA = "0x183FDE7D0")]
	public POODIMDADFN(IEnumerable<TData> DBLDPIKPGGA, bool PNLEBJKAJAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct AIFCOKOBBIC<TData> where TData : notnull, PCCLJPHJGOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> OMNJBIGMHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> FFDLHDALNMM;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x364C010", Offset = "0x364B410", VA = "0x18364C010")]
	public AIFCOKOBBIC(List<TData> DBLDPIKPGGA, List<bool> GMMCFOPICPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface PCCLJPHJGOG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool GJHJHNIOJKF
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
public interface JEJNGPDKFKG<TData> where TData : PCCLJPHJGOG
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJPMKBDPCCA([In] POODIMDADFN<TData> DFKFPNMIPNP);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJPMKBDPCCA([In] AIFCOKOBBIC<TData> DFKFPNMIPNP);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface OLMNHEPCDDM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KIGIIAFJJAE(T DAPOBFHGAGK);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class JIKMIPICPFM<TData> : CDLLPHMDLIN<JEJNGPDKFKG<TData>> where TData : notnull, PCCLJPHJGOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly POODIMDADFN<TData> DFKFPNMIPNP;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x39E0110", Offset = "0x39DF510", VA = "0x1839E0110")]
	public JIKMIPICPFM(List<TData> FOIGBKBEFFJ, bool LOIOIJGFJEK, JEJNGPDKFKG<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3632470", Offset = "0x3631870", VA = "0x183632470", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class DHKMBPLFPLN<TData> : CDLLPHMDLIN<JEJNGPDKFKG<TData>> where TData : notnull, PCCLJPHJGOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly AIFCOKOBBIC<TData> DFKFPNMIPNP;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4E8EA40", Offset = "0x4E8DE40", VA = "0x184E8EA40")]
	public DHKMBPLFPLN(List<TData> FOIGBKBEFFJ, List<bool> FFDLHDALNMM, JEJNGPDKFKG<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x395E700", Offset = "0x395DB00", VA = "0x18395E700", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface CEHOLGBNDCI : PCCLJPHJGOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface JAEKDEDJNLM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FICCLMDNABN> AJPMKBDPCCA(NJBNCMKJCNN<TData> OEFMBGLACDL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class ECMBBEDHEEA<TData> : KDLLNFEBJHI<JAEKDEDJNLM<TData>, FICCLMDNABN> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct PFOAMGLPANN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<FICCLMDNABN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public ECMBBEDHEEA<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<FICCLMDNABN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3FA3960", Offset = "0x3FA2D60", VA = "0x183FA3960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3FA3C50", Offset = "0x3FA3050", VA = "0x183FA3C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NJBNCMKJCNN<TData> DOAJKHOAAMI;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x31D6E60", Offset = "0x31D6260", VA = "0x1831D6E60")]
	public ECMBBEDHEEA(TData KHKBLDPOEGP, IReadOnlyList<TData> HLJIGLJKJPJ, bool MOJKOFEPLCL, JAEKDEDJNLM<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x31D6D60", Offset = "0x31D6160", VA = "0x1831D6D60", Slot = "4")]
	[AsyncStateMachine(typeof(ECMBBEDHEEA<>.PFOAMGLPANN))]
	public override Task<FICCLMDNABN> AJPMKBDPCCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct NJBNCMKJCNN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData COCMCMDFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> AEPIDCNNGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool PHBLIMHIMCF;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3E010E0", Offset = "0x3E004E0", VA = "0x183E010E0")]
	public NJBNCMKJCNN(TData KHKBLDPOEGP, IReadOnlyList<TData> HLJIGLJKJPJ, bool MOJKOFEPLCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface KMLNBNHAGIC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJPMKBDPCCA([In] NKHHNNFJDPH<TData> DFJCKEDODNM);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface KDEDBIJDJGH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJPMKBDPCCA([In] IHBDHIBDPJP<TData> DFJCKEDODNM);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface JLBJMJDFNCA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DLENIAONHOH([In] FKJIELCALAN<TData> DFJCKEDODNM);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CFGJIFLKBCE();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NDICOMAFLBB<TData> : CDLLPHMDLIN<KMLNBNHAGIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly NKHHNNFJDPH<TData> DFJCKEDODNM;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3DFA2C0", Offset = "0x3DF96C0", VA = "0x183DFA2C0")]
	public NDICOMAFLBB(IEnumerable<TData> FOIGBKBEFFJ, OIEDBBAJKGM IKNGOAKEJAP, OADCHAEGGGG OODGJPECLJK, float EFPBIAHHGCJ, bool MOJKOFEPLCL, KMLNBNHAGIC<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3632470", Offset = "0x3631870", VA = "0x183632470", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class BCCOLGMAJNC<TData> : CDLLPHMDLIN<KDEDBIJDJGH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly IHBDHIBDPJP<TData> DFJCKEDODNM;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x45E0820", Offset = "0x45DFC20", VA = "0x1845E0820")]
	public BCCOLGMAJNC(TData[] FOIGBKBEFFJ, OIEDBBAJKGM[] IKNGOAKEJAP, OADCHAEGGGG[] OODGJPECLJK, float[] EFPBIAHHGCJ, KDEDBIJDJGH<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3A48370", Offset = "0x3A47770", VA = "0x183A48370", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class JACHFENINHL<TData> : CDLLPHMDLIN<JLBJMJDFNCA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x31CD680", Offset = "0x31CCA80", VA = "0x1831CD680")]
	public JACHFENINHL(JLBJMJDFNCA<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3958510", Offset = "0x3957910", VA = "0x183958510", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class KBDCHIHMAHP<TData> : CDLLPHMDLIN<JLBJMJDFNCA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly FKJIELCALAN<TData> DFJCKEDODNM;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3A48430", Offset = "0x3A47830", VA = "0x183A48430")]
	public KBDCHIHMAHP(IEnumerable<TData> FOIGBKBEFFJ, OIEDBBAJKGM IKNGOAKEJAP, OADCHAEGGGG OODGJPECLJK, float EFPBIAHHGCJ, JLBJMJDFNCA<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3A48370", Offset = "0x3A47770", VA = "0x183A48370", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct NKHHNNFJDPH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> OMNJBIGMHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public OIEDBBAJKGM IBKABMHFCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public OADCHAEGGGG KCEDECNMLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float EFPBIAHHGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool MOJKOFEPLCL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3E02B40", Offset = "0x3E01F40", VA = "0x183E02B40")]
	public NKHHNNFJDPH(IEnumerable<TData> FOIGBKBEFFJ, OIEDBBAJKGM IKNGOAKEJAP, OADCHAEGGGG OODGJPECLJK, float EFPBIAHHGCJ, bool MOJKOFEPLCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct IHBDHIBDPJP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] OMNJBIGMHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public OIEDBBAJKGM[] IBKABMHFCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public OADCHAEGGGG[] KCEDECNMLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] EFPBIAHHGCJ;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x379FD50", Offset = "0x379F150", VA = "0x18379FD50")]
	public IHBDHIBDPJP(TData[] FOIGBKBEFFJ, OIEDBBAJKGM[] IKNGOAKEJAP, OADCHAEGGGG[] OODGJPECLJK, float[] EFPBIAHHGCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct FKJIELCALAN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> OMNJBIGMHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public OIEDBBAJKGM IBKABMHFCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public OADCHAEGGGG KCEDECNMLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float EFPBIAHHGCJ;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x358F020", Offset = "0x358E420", VA = "0x18358F020")]
	public FKJIELCALAN(IEnumerable<TData> FOIGBKBEFFJ, OIEDBBAJKGM IKNGOAKEJAP, OADCHAEGGGG OODGJPECLJK, float EFPBIAHHGCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface IJMFPCLOOGK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MKFGMHCIIFM([In] JEKGKHOAHIG<TData> DEEAIJOECLC);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNJMDOFOCCA([In] JEKGKHOAHIG<TData> DEEAIJOECLC);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMOLHCDJMKN([In] bool CHNNEADNAFM);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HELECMIKNMF([In] JEKGKHOAHIG<TData> DEEAIJOECLC);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PHJCGLAJDKH();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PGGGEKCEBOG([In] TData FHHPJALIMBG);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class BAJHOEPBJLP<TData> : CDLLPHMDLIN<IJMFPCLOOGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly JEKGKHOAHIG<TData> DEEAIJOECLC;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x45DB9C0", Offset = "0x45DADC0", VA = "0x1845DB9C0")]
	public BAJHOEPBJLP(List<TData> NBBGPGGFMPG, IJMFPCLOOGK<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3632470", Offset = "0x3631870", VA = "0x183632470", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class EFKDANHODFA<TData> : CDLLPHMDLIN<IJMFPCLOOGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x31CD680", Offset = "0x31CCA80", VA = "0x1831CD680")]
	public EFKDANHODFA(IJMFPCLOOGK<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x31DF350", Offset = "0x31DE750", VA = "0x1831DF350", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class MBEPANKBMKL<TData> : CDLLPHMDLIN<IJMFPCLOOGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool MOJKOFEPLCL;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3D2E950", Offset = "0x3D2DD50", VA = "0x183D2E950")]
	public MBEPANKBMKL(bool MOJKOFEPLCL, IJMFPCLOOGK<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3D2E8F0", Offset = "0x3D2DCF0", VA = "0x183D2E8F0", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class JCDABBIFBOF<TData> : CDLLPHMDLIN<IJMFPCLOOGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly JEKGKHOAHIG<TData> DEEAIJOECLC;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x395E7C0", Offset = "0x395DBC0", VA = "0x18395E7C0")]
	public JCDABBIFBOF(List<TData> NBBGPGGFMPG, bool MOJKOFEPLCL, IJMFPCLOOGK<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x395E700", Offset = "0x395DB00", VA = "0x18395E700", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class ICAJPLABFDF<TData> : CDLLPHMDLIN<IJMFPCLOOGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData FHHPJALIMBG;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3790F40", Offset = "0x3790340", VA = "0x183790F40")]
	public ICAJPLABFDF(TData FHHPJALIMBG, IJMFPCLOOGK<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3790DC0", Offset = "0x37901C0", VA = "0x183790DC0", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class JPLAMBLDAKC<TData> : CDLLPHMDLIN<IJMFPCLOOGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly JEKGKHOAHIG<TData> DEEAIJOECLC;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3A18900", Offset = "0x3A17D00", VA = "0x183A18900")]
	public JPLAMBLDAKC(IEnumerable<TData> NBBGPGGFMPG, IJMFPCLOOGK<TData> KEHMNIODKBI, bool MOJKOFEPLCL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3A18790", Offset = "0x3A17B90", VA = "0x183A18790", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct JEKGKHOAHIG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> OMNJBIGMHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool MOJKOFEPLCL;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x39706D0", Offset = "0x396FAD0", VA = "0x1839706D0")]
	public JEKGKHOAHIG(IEnumerable<TData> DBLDPIKPGGA, bool GJJNJCJGEJC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface HJAFFLFNCBM
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FICCLMDNABN> AJPMKBDPCCA(DLNOJLACBHA KNPLJMDCPMA);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class ODDOCLOACKF : KDLLNFEBJHI<HJAFFLFNCBM, FICCLMDNABN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct IAPJPOCCAJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<FICCLMDNABN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public ODDOCLOACKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<FICCLMDNABN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5F890A0", Offset = "0x5F884A0", VA = "0x185F890A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5F89320", Offset = "0x5F88720", VA = "0x185F89320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly DLNOJLACBHA HFPILGOJKNC;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5F89A80", Offset = "0x5F88E80", VA = "0x185F89A80")]
	public ODDOCLOACKF(bool MOJKOFEPLCL, HJAFFLFNCBM KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5F89990", Offset = "0x5F88D90", VA = "0x185F89990", Slot = "4")]
	[AsyncStateMachine(typeof(IAPJPOCCAJF))]
	public override Task<FICCLMDNABN> AJPMKBDPCCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct DLNOJLACBHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool PHBLIMHIMCF;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xC46BA0", Offset = "0xC45FA0", VA = "0x180C46BA0")]
	public DLNOJLACBHA(bool MOJKOFEPLCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct GCIOJDLIHGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool LCPOEKIIDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool OMBENPFMBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool CMIJAKFGAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool MOJKOFEPLCL;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4486100", Offset = "0x4485500", VA = "0x184486100")]
	public GCIOJDLIHGO(bool LCPOEKIIDBP, bool OMBENPFMBON, bool CMIJAKFGAEH, bool MOJKOFEPLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5F88E00", Offset = "0x5F88200", VA = "0x185F88E00")]
	public GCIOJDLIHGO(bool OMBENPFMBON, bool MOJKOFEPLCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface EAKAFGNIJCE
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBIKLEGCJGC(GCIOJDLIHGO EFOMBLIMEHK);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OKCJFAFFHIE(GCIOJDLIHGO EFOMBLIMEHK);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class KJCCGJOEAEF : CDLLPHMDLIN<EAKAFGNIJCE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GCIOJDLIHGO EFOMBLIMEHK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5F89610", Offset = "0x5F88A10", VA = "0x185F89610")]
	public KJCCGJOEAEF(bool AOOGIIEBLDG, bool OMBENPFMBON, bool CMIJAKFGAEH, bool MOJKOFEPLCL, EAKAFGNIJCE KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5F895C0", Offset = "0x5F889C0", VA = "0x185F895C0", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class NIFAEIDCOFB : CDLLPHMDLIN<EAKAFGNIJCE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly GCIOJDLIHGO EFOMBLIMEHK;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5F89890", Offset = "0x5F88C90", VA = "0x185F89890")]
	public NIFAEIDCOFB(bool OMBENPFMBON, bool MOJKOFEPLCL, EAKAFGNIJCE KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5F89840", Offset = "0x5F88C40", VA = "0x185F89840", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface MHBMGKDEEIM
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJPMKBDPCCA([In] ALOKKIHIFIF JEPCIBAIEPL);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class HMDCICFKOIE : CDLLPHMDLIN<MHBMGKDEEIM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly ALOKKIHIFIF JEPCIBAIEPL;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5F88EC0", Offset = "0x5F882C0", VA = "0x185F88EC0")]
	public HMDCICFKOIE(Guid[] CCMICJLJHFJ, Vector3[] IPAMDKNANEB, Quaternion[] NLAGHEDMCOE, float[] PHDPGMONPID, Dictionary<Guid, Vector3> AIPIELCDIFI, MHBMGKDEEIM KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5F88E10", Offset = "0x5F88210", VA = "0x185F88E10", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface MKNHJCAPIFC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEDDJCLMKHA([In] PIHCBHKNFCP<TData> ECIAEDCAEHN);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DLENIAONHOH([In] LMGBGFAHNDK BONCAJNEDML);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DLENIAONHOH([In] PAFGDDAJGGB BONCAJNEDML);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CFGJIFLKBCE();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class KDHKFDGIHCF<TData> : CDLLPHMDLIN<MKNHJCAPIFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x31CD680", Offset = "0x31CCA80", VA = "0x1831CD680")]
	public KDHKFDGIHCF(MKNHJCAPIFC<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A64910", Offset = "0x3A63D10", VA = "0x183A64910", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class PAHGCFEDMON<TData> : CDLLPHMDLIN<MKNHJCAPIFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly LMGBGFAHNDK IDMFLFBJAMH;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3F82BC0", Offset = "0x3F81FC0", VA = "0x183F82BC0")]
	public PAHGCFEDMON(Vector3 IIMEBLGIPJJ, bool KABLGPHGDGK, MKNHJCAPIFC<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x362FE90", Offset = "0x362F290", VA = "0x18362FE90", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class IDLMGGADEAN<TData> : CDLLPHMDLIN<MKNHJCAPIFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly PAFGDDAJGGB IDMFLFBJAMH;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3798790", Offset = "0x3797B90", VA = "0x183798790")]
	public IDLMGGADEAN(Guid OBKJKJMEBIM, int OJANCMLFDOJ, Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI, float NLAEHEEAFBH, bool KABLGPHGDGK, MKNHJCAPIFC<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3798730", Offset = "0x3797B30", VA = "0x183798730", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class LGFMMKGAFFF<TData> : CDLLPHMDLIN<MKNHJCAPIFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly PIHCBHKNFCP<TData> IDMFLFBJAMH;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D650", Offset = "0x3B4CA50", VA = "0x183B4D650")]
	public LGFMMKGAFFF(TData DAPOBFHGAGK, bool MOJKOFEPLCL, MKNHJCAPIFC<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3632470", Offset = "0x3631870", VA = "0x183632470", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct LMGBGFAHNDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Vector3 IIMEBLGIPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool KABLGPHGDGK;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F896A0", Offset = "0x5F88AA0", VA = "0x185F896A0")]
	public LMGBGFAHNDK(Vector3 IIMEBLGIPJJ, bool KABLGPHGDGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct PAFGDDAJGGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Guid OBKJKJMEBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int OJANCMLFDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Vector3 HGKJDOIPDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Quaternion PGPLGEJKHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly float NLAEHEEAFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly bool KABLGPHGDGK;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F89AE0", Offset = "0x5F88EE0", VA = "0x185F89AE0")]
	public PAFGDDAJGGB(Guid OBKJKJMEBIM, int OJANCMLFDOJ, Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI, float NLAEHEEAFBH, bool KABLGPHGDGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct PIHCBHKNFCP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData DAPOBFHGAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly bool MOJKOFEPLCL;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3FC55D0", Offset = "0x3FC49D0", VA = "0x183FC55D0")]
	public PIHCBHKNFCP(TData DAPOBFHGAGK, bool MOJKOFEPLCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface CPOGPAHIELH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJPMKBDPCCA([In] EBKAONEPGIA<TData> MOHBAKIIALL);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJPMKBDPCCA([In] AGADFCGFLFD<TData> MOHBAKIIALL);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface KCAIJEAJPHJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEDDJCLMKHA([In] FIGJGPPNEEB<TData> KPJLJMDPPMN);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DLENIAONHOH([In] BDHDKDCNNDC BONCAJNEDML);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CFGJIFLKBCE();
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class CHKMIACAEHP<TData> : CDLLPHMDLIN<CPOGPAHIELH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly EBKAONEPGIA<TData> MOHBAKIIALL;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4959A00", Offset = "0x4958E00", VA = "0x184959A00")]
	public CHKMIACAEHP(IEnumerable<TData> FOIGBKBEFFJ, Vector3 AMJIBOHHAFB, bool MOJKOFEPLCL, CPOGPAHIELH<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3632470", Offset = "0x3631870", VA = "0x183632470", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class LBPKGBAFOMA<TData> : CDLLPHMDLIN<KCAIJEAJPHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x31CD680", Offset = "0x31CCA80", VA = "0x1831CD680")]
	public LBPKGBAFOMA(KCAIJEAJPHJ<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3B4A5C0", Offset = "0x3B499C0", VA = "0x183B4A5C0", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class LBIMOGGBDHE<TData> : CDLLPHMDLIN<KCAIJEAJPHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly FIGJGPPNEEB<TData> MOHBAKIIALL;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3B16930", Offset = "0x3B15D30", VA = "0x183B16930")]
	public LBIMOGGBDHE(IEnumerable<TData> FOIGBKBEFFJ, bool MOJKOFEPLCL, KCAIJEAJPHJ<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3632470", Offset = "0x3631870", VA = "0x183632470", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class FBALDEOMBNA<TData> : CDLLPHMDLIN<CPOGPAHIELH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly AGADFCGFLFD<TData> MOHBAKIIALL;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3573AD0", Offset = "0x3572ED0", VA = "0x183573AD0")]
	public FBALDEOMBNA(IEnumerable<TData> FOIGBKBEFFJ, Vector3 PPFCFJBBLBL, FAJOAPHNPHK FJAAMMEMBID, bool MOJKOFEPLCL, CPOGPAHIELH<TData> KEHMNIODKBI, Space OMOCJCMEMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3205680", Offset = "0x3204A80", VA = "0x183205680", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class DMEBEIDJFBC<TData> : CDLLPHMDLIN<KCAIJEAJPHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly BDHDKDCNNDC MOHBAKIIALL;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5820", Offset = "0x4EB4C20", VA = "0x184EB5820")]
	public DMEBEIDJFBC(Vector3 AMJIBOHHAFB, KCAIJEAJPHJ<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x362FE90", Offset = "0x362F290", VA = "0x18362FE90", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct EBKAONEPGIA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly IEnumerable<TData> FOIGBKBEFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Vector3 AMJIBOHHAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly bool MOJKOFEPLCL;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x31D4ED0", Offset = "0x31D42D0", VA = "0x1831D4ED0")]
	public EBKAONEPGIA(IEnumerable<TData> FOIGBKBEFFJ, Vector3 AMJIBOHHAFB, bool MOJKOFEPLCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct FIGJGPPNEEB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> FOIGBKBEFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool MOJKOFEPLCL;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x358BDA0", Offset = "0x358B1A0", VA = "0x18358BDA0")]
	public FIGJGPPNEEB(IEnumerable<TData> FOIGBKBEFFJ, bool MOJKOFEPLCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct AGADFCGFLFD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly IEnumerable<TData> FOIGBKBEFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 PPFCFJBBLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly FAJOAPHNPHK FJAAMMEMBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool MOJKOFEPLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Space OMOCJCMEMPH;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3635410", Offset = "0x3634810", VA = "0x183635410")]
	public AGADFCGFLFD(IEnumerable<TData> FOIGBKBEFFJ, Vector3 PPFCFJBBLBL, FAJOAPHNPHK FJAAMMEMBID, bool MOJKOFEPLCL, Space OMOCJCMEMPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct BDHDKDCNNDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Vector3 AMJIBOHHAFB;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1EB36C0", Offset = "0x1EB2AC0", VA = "0x181EB36C0")]
	public BDHDKDCNNDC(Vector3 AMJIBOHHAFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum FAJOAPHNPHK
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
public interface EPDFMBBAHJK
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJPMKBDPCCA([In] BKALELPEDOB HMKIPGBNMJL);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class PFKEHFDECAF : CDLLPHMDLIN<EPDFMBBAHJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly BKALELPEDOB HMKIPGBNMJL;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5F89FA0", Offset = "0x5F893A0", VA = "0x185F89FA0")]
	public PFKEHFDECAF(bool MOJKOFEPLCL, EPDFMBBAHJK KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5F89EF0", Offset = "0x5F892F0", VA = "0x185F89EF0", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct BKALELPEDOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool MOJKOFEPLCL;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xC46BA0", Offset = "0xC45FA0", VA = "0x180C46BA0")]
	public BKALELPEDOB(bool MOJKOFEPLCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface GDPPINGCKLG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJPMKBDPCCA([In] LHOMJJDHFNG<TData> HJPJMPLGODE);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJPMKBDPCCA([In] MEFOOKHJHGH<TData> HJPJMPLGODE);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface HFEHMEECNIJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEDDJCLMKHA([In] KIKGCPLJBCA<TData> ECIAEDCAEHN);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DLENIAONHOH([In] BIOLIEPCMMK BONCAJNEDML);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CFGJIFLKBCE();
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class HGOHKJJGCHH<TData> : CDLLPHMDLIN<GDPPINGCKLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly LHOMJJDHFNG<TData> HJPJMPLGODE;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x36ECDE0", Offset = "0x36EC1E0", VA = "0x1836ECDE0")]
	public HGOHKJJGCHH(IEnumerable<TData> FOIGBKBEFFJ, Quaternion AMJIBOHHAFB, Vector3? ALABLCDIJNM, bool IOLBFMBOCJC, bool MOJKOFEPLCL, GDPPINGCKLG<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3632470", Offset = "0x3631870", VA = "0x183632470", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class DEPFNMMMCKE<TData> : CDLLPHMDLIN<HFEHMEECNIJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x31CD680", Offset = "0x31CCA80", VA = "0x1831CD680")]
	public DEPFNMMMCKE(HFEHMEECNIJ<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3B4A5C0", Offset = "0x3B499C0", VA = "0x183B4A5C0", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class AFAPPCILKMM<TData> : CDLLPHMDLIN<HFEHMEECNIJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly KIKGCPLJBCA<TData> HJPJMPLGODE;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x36325C0", Offset = "0x36319C0", VA = "0x1836325C0")]
	public AFAPPCILKMM(IEnumerable<TData> FOIGBKBEFFJ, bool MOJKOFEPLCL, HFEHMEECNIJ<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3632470", Offset = "0x3631870", VA = "0x183632470", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class ELNHNFDPNOE<TData> : CDLLPHMDLIN<GDPPINGCKLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MEFOOKHJHGH<TData> HJPJMPLGODE;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3205750", Offset = "0x3204B50", VA = "0x183205750")]
	public ELNHNFDPNOE(IEnumerable<TData> FOIGBKBEFFJ, Quaternion GFPKBNCOCLC, FAJOAPHNPHK CADFOMNPPDA, Vector3? ALABLCDIJNM, bool IOLBFMBOCJC, bool MOJKOFEPLCL, Space OMOCJCMEMPH, GDPPINGCKLG<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3205680", Offset = "0x3204A80", VA = "0x183205680", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class ACDKKHFKMEB<TData> : CDLLPHMDLIN<HFEHMEECNIJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly BIOLIEPCMMK HJPJMPLGODE;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x362FEF0", Offset = "0x362F2F0", VA = "0x18362FEF0")]
	public ACDKKHFKMEB(Quaternion AMJIBOHHAFB, Vector3? ALABLCDIJNM, bool IOLBFMBOCJC, HFEHMEECNIJ<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x362FE90", Offset = "0x362F290", VA = "0x18362FE90", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct LHOMJJDHFNG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly IEnumerable<TData> FOIGBKBEFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Quaternion AMJIBOHHAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3? ALABLCDIJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool IOLBFMBOCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool MOJKOFEPLCL;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3B59E00", Offset = "0x3B59200", VA = "0x183B59E00")]
	public LHOMJJDHFNG(IEnumerable<TData> FOIGBKBEFFJ, Quaternion AMJIBOHHAFB, Vector3? ALABLCDIJNM, bool IOLBFMBOCJC, bool MOJKOFEPLCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct KIKGCPLJBCA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> FOIGBKBEFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool MOJKOFEPLCL;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3A73D30", Offset = "0x3A73130", VA = "0x183A73D30")]
	public KIKGCPLJBCA(IEnumerable<TData> FOIGBKBEFFJ, bool MOJKOFEPLCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct MEFOOKHJHGH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly IEnumerable<TData> FOIGBKBEFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Quaternion GFPKBNCOCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly FAJOAPHNPHK CADFOMNPPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3? ALABLCDIJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool IOLBFMBOCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool MOJKOFEPLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Space OMOCJCMEMPH;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3D47CC0", Offset = "0x3D470C0", VA = "0x183D47CC0")]
	public MEFOOKHJHGH(IEnumerable<TData> FOIGBKBEFFJ, Quaternion GFPKBNCOCLC, FAJOAPHNPHK CADFOMNPPDA, Vector3? ALABLCDIJNM, bool IOLBFMBOCJC, bool MOJKOFEPLCL, Space OMOCJCMEMPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct BIOLIEPCMMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Quaternion AMJIBOHHAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3? ALABLCDIJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool IOLBFMBOCJC;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x444A300", Offset = "0x4449700", VA = "0x18444A300")]
	public BIOLIEPCMMK(Quaternion AMJIBOHHAFB, Vector3? ALABLCDIJNM, bool IOLBFMBOCJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface GJAKHAJIDFI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEDDJCLMKHA([In] HPCAFMKONLH<TData> ECIAEDCAEHN);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DLENIAONHOH([In] KKNCKPJFFAD BONCAJNEDML);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DLENIAONHOH([In] NHHANOJIBLF BONCAJNEDML);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DLENIAONHOH([In] AGFOPIPJCEL BONCAJNEDML);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CFGJIFLKBCE();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class KFJJBMHEKCK<TData> : CDLLPHMDLIN<GJAKHAJIDFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly AGFOPIPJCEL ACLMGKAIPLI;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A678F0", Offset = "0x3A66CF0", VA = "0x183A678F0")]
	public KFJJBMHEKCK(Vector3 PLJJMNIOIJD, float NJPICGCBCBG, Vector3 ALABLCDIJNM, bool IBAHIJDLDIL, bool EBJCOAJHFOH, GJAKHAJIDFI<TData> KEHMNIODKBI, Space OMOCJCMEMPH = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A67890", Offset = "0x3A66C90", VA = "0x183A67890", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class NBEONHCGPIA<TData> : CDLLPHMDLIN<GJAKHAJIDFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x31CD680", Offset = "0x31CCA80", VA = "0x1831CD680")]
	public NBEONHCGPIA(GJAKHAJIDFI<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3DDED60", Offset = "0x3DDE160", VA = "0x183DDED60", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class NAJFDHJIKHK<TData> : CDLLPHMDLIN<GJAKHAJIDFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HPCAFMKONLH<TData> ACLMGKAIPLI;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE3A0", Offset = "0x3DDD7A0", VA = "0x183DDE3A0")]
	public NAJFDHJIKHK(IEnumerable<TData> FOIGBKBEFFJ, bool MOJKOFEPLCL, GJAKHAJIDFI<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3632470", Offset = "0x3631870", VA = "0x183632470", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class ANDPJJCOGPD<TData> : CDLLPHMDLIN<GJAKHAJIDFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly NHHANOJIBLF ACLMGKAIPLI;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3672420", Offset = "0x3671820", VA = "0x183672420")]
	public ANDPJJCOGPD(float JLHAIGIMMDC, bool OMIMDGCPLGJ, Vector3 ALABLCDIJNM, GJAKHAJIDFI<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3672350", Offset = "0x3671750", VA = "0x183672350", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class OENKLDOKGOP<TData> : CDLLPHMDLIN<GJAKHAJIDFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly KKNCKPJFFAD ACLMGKAIPLI;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3EED040", Offset = "0x3EEC440", VA = "0x183EED040")]
	public OENKLDOKGOP(float NJPICGCBCBG, Vector3 ALABLCDIJNM, GJAKHAJIDFI<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x362FE90", Offset = "0x362F290", VA = "0x18362FE90", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct AGFOPIPJCEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 PLJJMNIOIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly float NJPICGCBCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 ALABLCDIJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool KABLGPHGDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space OMOCJCMEMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly bool EBJCOAJHFOH;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5F88940", Offset = "0x5F87D40", VA = "0x185F88940")]
	public AGFOPIPJCEL(Vector3 PLJJMNIOIJD, float NJPICGCBCBG, Vector3 ALABLCDIJNM, bool KABLGPHGDGK, bool JHCHBKEMHHB, Space OMOCJCMEMPH = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct HPCAFMKONLH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> FOIGBKBEFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool MOJKOFEPLCL;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3703860", Offset = "0x3702C60", VA = "0x183703860")]
	public HPCAFMKONLH(IEnumerable<TData> FOIGBKBEFFJ, bool MOJKOFEPLCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct NHHANOJIBLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly float JLHAIGIMMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool OMIMDGCPLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly Vector3 ALABLCDIJNM;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5F89820", Offset = "0x5F88C20", VA = "0x185F89820")]
	public NHHANOJIBLF(float JLHAIGIMMDC, bool OMIMDGCPLGJ, Vector3 ALABLCDIJNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct KKNCKPJFFAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly float NJPICGCBCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 ALABLCDIJNM;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x441C920", Offset = "0x441BD20", VA = "0x18441C920")]
	public KKNCKPJFFAD(float NJPICGCBCBG, Vector3 ALABLCDIJNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct ALOKKIHIFIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Guid[] FOIGBKBEFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly bool MPNBJCHLNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool FEADENBGBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool FJOEKHKEEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Vector3[] IPAMDKNANEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion[] NLAGHEDMCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly float[] PHDPGMONPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Dictionary<Guid, Vector3> AIPIELCDIFI;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5F88B50", Offset = "0x5F87F50", VA = "0x185F88B50")]
	public ALOKKIHIFIF(Guid[] CCMICJLJHFJ, Vector3[] IPAMDKNANEB, Quaternion[] NLAGHEDMCOE, float[] PHDPGMONPID, Dictionary<Guid, Vector3> AIPIELCDIFI, bool MPNBJCHLNEE = true, bool FEADENBGBPE = true, bool FJOEKHKEEJN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5F88980", Offset = "0x5F87D80", VA = "0x185F88980")]
	private static void GGNCMECAEIA(Dictionary<Guid, Vector3> AIPIELCDIFI, int ABLPKKDKPEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class PFGCJANDHKD
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct IFNLHHIFGGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool APPGEFJHLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public BHJKECHLECD KDFDFOMHCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public BHJKECHLECD MCKPLCOIGGK;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static IFNLHHIFGGN CKCAJAKAMCC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken DNFKPHMCMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5F89B20", Offset = "0x5F88F20", VA = "0x185F89B20")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static BHJKECHLECD KDFDFOMHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5F89B40", Offset = "0x5F88F40", VA = "0x185F89B40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5F89E80", Offset = "0x5F89280", VA = "0x185F89E80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5F89D30", Offset = "0x5F89130", VA = "0x185F89D30")]
	[NEHHKLCIMGL(DIKIGLGFNNP.Room, OJLOCLENGNC.None)]
	private static void LFKEMOGPHEB(BHJKECHLECD LEJOHNHIFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5F89BE0", Offset = "0x5F88FE0", VA = "0x185F89BE0")]
	public static void KECAPFPCLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5F89E30", Offset = "0x5F89230", VA = "0x185F89E30")]
	private static BHJKECHLECD MHNOGNEFBJC(BHJKECHLECD FAHHHGHBKDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class MAIBPLNCLBC
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum JPFFJDNOAFP
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x27034C0", Offset = "0x27028C0", VA = "0x1827034C0")]
	public static void DGMHNEIDPGH<T>(T CONPDDCOPOE, JPFFJDNOAFP ADAMDPHPFAA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2703460", Offset = "0x2702860", VA = "0x182703460")]
	public static void DGMHNEIDPGH<T>(T CONPDDCOPOE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x27038B0", Offset = "0x2702CB0", VA = "0x1827038B0")]
	public static void LGEIOHKPECB<T>(T CONPDDCOPOE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2703810", Offset = "0x2702C10", VA = "0x182703810")]
	public static T JNDPLHMHPON<T>(JPFFJDNOAFP ADAMDPHPFAA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x27036E0", Offset = "0x2702AE0", VA = "0x1827036E0")]
	public static bool GMKMIFOLGPA<T>(JPFFJDNOAFP ADAMDPHPFAA, T NAHJKOHBKGB, [Out] T KECLMELLBAK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2703640", Offset = "0x2702A40", VA = "0x182703640")]
	public static bool EGCJDMIDHNE<T>(JPFFJDNOAFP ADAMDPHPFAA) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2703600", Offset = "0x2702A00", VA = "0x182703600")]
	public static T JNDPLHMHPON<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2703600", Offset = "0x2702A00", VA = "0x182703600")]
	public static bool EGCJDMIDHNE<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class IJDLONLLMJP
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5F89390", Offset = "0x5F88790", VA = "0x185F89390")]
	public static void KOLGCPGPINP(IEnumerable AEKBCONJICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2676170", Offset = "0x2675570", VA = "0x182676170")]
	public static void KOLGCPGPINP<T>(T[] NIKMHLBDDHG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2676260", Offset = "0x2675660", VA = "0x182676260")]
	public static void KOLGCPGPINP<T>(T EPPCBJOAABF) where T : notnull, Enum
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
