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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6003160", Offset = "0x6001B60", VA = "0x186003160")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D25A0", Offset = "0x7D0FA0", VA = "0x1807D25A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x31FCEE0", Offset = "0x31FB8E0", VA = "0x1831FCEE0")]
	public CDLLPHMDLIN(TReceiver KEHMNIODKBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class KDLLNFEBJHI<TReceiver, TFromTask> : CPAGMKDCBBM<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x31FCEE0", Offset = "0x31FB8E0", VA = "0x1831FCEE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A2CA10", Offset = "0x4A2B410", VA = "0x184A2CA10")]
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
	[Cpp2IlInjected.Address(RVA = "0x31FCEE0", Offset = "0x31FB8E0", VA = "0x1831FCEE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1A4A020", Offset = "0x1A48A20", VA = "0x181A4A020")]
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
	[Cpp2IlInjected.Address(RVA = "0x88E8A0", Offset = "0x88D2A0", VA = "0x18088E8A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8C6B40", Offset = "0x8C5540", VA = "0x1808C6B40")]
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
	[Cpp2IlInjected.Address(RVA = "0x8C6B40", Offset = "0x8C5540", VA = "0x1808C6B40")]
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
	[Cpp2IlInjected.Address(RVA = "0x320EE60", Offset = "0x320D860", VA = "0x18320EE60")]
	public EFMDMFAPDDH(TGroup KBENDGMKEDN, IEnumerable<TData> FOIGBKBEFFJ, ELMHALJOAGG<TGroup, TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x320ED90", Offset = "0x320D790", VA = "0x18320ED90", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E38920", Offset = "0x3E37320", VA = "0x183E38920")]
	public CAOJPGFPKPH(TGroup KBENDGMKEDN, TData PODAJBAHBLG, IEnumerable<TData> FOIGBKBEFFJ, ELMHALJOAGG<TGroup, TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x484F4F0", Offset = "0x484DEF0", VA = "0x18484F4F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x35A7840", Offset = "0x35A6240", VA = "0x1835A7840")]
	public KEDDOEJMGDB(TGroup KBENDGMKEDN, ELMHALJOAGG<TGroup, TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3A8FB20", Offset = "0x3A8E520", VA = "0x183A8FB20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E38920", Offset = "0x3E37320", VA = "0x183E38920")]
	public NJMOAMBGJFP(TGroup KBENDGMKEDN, TData GIJFEDBIJGF, IEnumerable<TData> FOIGBKBEFFJ, ELMHALJOAGG<TGroup, TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E38840", Offset = "0x3E37240", VA = "0x183E38840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x36925D0", Offset = "0x3690FD0", VA = "0x1836925D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3692870", Offset = "0x3691270", VA = "0x183692870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private DMOIABNEPHO<TData> EDCPAKPCBKP;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x35A7840", Offset = "0x35A6240", VA = "0x1835A7840")]
	public FGDIGLNHACB(IEnumerable<TData> OKGOHICACAH, CNKBMJEPKPE<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35A7740", Offset = "0x35A6140", VA = "0x1835A7740", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6002630", Offset = "0x6001030", VA = "0x186002630")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B40710", Offset = "0x3B3F110", VA = "0x183B40710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3B40ED0", Offset = "0x3B3F8D0", VA = "0x183B40ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly DAJBJLJGOMO DJJDEBKAFMD;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D9C110", Offset = "0x3D9AB10", VA = "0x183D9C110")]
	public MHLLGAHDMHI(MEDMJHBJEGN LIJMOHIKNCD, bool MOJKOFEPLCL, DOHPIPJMNAK<TSpawnType> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D9BF10", Offset = "0x3D9A910", VA = "0x183D9BF10", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6002FD0", Offset = "0x60019D0", VA = "0x186002FD0")]
	public MEDMJHBJEGN(Transform BBEJALEDEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6003040", Offset = "0x6001A40", VA = "0x186003040")]
	public MEDMJHBJEGN(Vector3 GKJEHHDBDOI, Vector3 HGKJDOIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6002F10", Offset = "0x6001910", VA = "0x186002F10")]
	public static MEDMJHBJEGN GOIMIPPOIPI()
	{
		return default(MEDMJHBJEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6002F40", Offset = "0x6001940", VA = "0x186002F40")]
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
	[Cpp2IlInjected.Address(RVA = "0x320B280", Offset = "0x3209C80", VA = "0x18320B280")]
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
	[Cpp2IlInjected.Address(RVA = "0x37423A0", Offset = "0x3740DA0", VA = "0x1837423A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x31FCEE0", Offset = "0x31FB8E0", VA = "0x1831FCEE0")]
	public BONNGGKEAIK(BIAMNALKJJH<TNode> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3B7A3B0", Offset = "0x3B78DB0", VA = "0x183B7A3B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x38069D0", Offset = "0x38053D0", VA = "0x1838069D0")]
	public IMOAGOGMHCP(TNode KAGIEGAILAG, PEHJCCMFICG ECCDGACFELL, BIAMNALKJJH<TNode> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3234EE0", Offset = "0x32338E0", VA = "0x183234EE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F0FF10", Offset = "0x4F0E910", VA = "0x184F0FF10")]
	public DJJKILJNDBI(TNode KBDAACBGKLD, BIAMNALKJJH<TNode> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x36772B0", Offset = "0x3675CB0", VA = "0x1836772B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3742F80", Offset = "0x3741980", VA = "0x183742F80")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D92670", Offset = "0x3D91070", VA = "0x183D92670")]
	public MFBDDLKEDGP(TSpawnInfo BJKOKMDDKGL, Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI, float CMIJAKFGAEH, LEJIHDEPLIM<TSpawnType, TSpawnInfo> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3D7E540", Offset = "0x3D7CF40", VA = "0x183D7E540", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3740E80", Offset = "0x373F880", VA = "0x183740E80")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D7E6B0", Offset = "0x3D7D0B0", VA = "0x183D7E6B0")]
	public MCHJKCJLDKD(IEnumerable<TData> FOIGBKBEFFJ, bool MOJKOFEPLCL, IGIBPCADCFK<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3D7E540", Offset = "0x3D7CF40", VA = "0x183D7E540", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3BA27E0", Offset = "0x3BA11E0", VA = "0x183BA27E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F31AE0", Offset = "0x3F304E0", VA = "0x183F31AE0")]
	public ONAFBHFLPNL(T ICCODGIHNBB, bool EOBPFEJDEMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class HOGDBOJLIBO<T> : CDLLPHMDLIN<FNIFLCCDLOA<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x31FCEE0", Offset = "0x31FB8E0", VA = "0x1831FCEE0")]
	public HOGDBOJLIBO(FNIFLCCDLOA<T> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3742190", Offset = "0x3740B90", VA = "0x183742190", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E48FC0", Offset = "0x3E479C0", VA = "0x183E48FC0")]
	public NOCHLDCJIPJ(T DAPOBFHGAGK, FNIFLCCDLOA<T> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x36772B0", Offset = "0x3675CB0", VA = "0x1836772B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x398FA20", Offset = "0x398E420", VA = "0x18398FA20")]
	public JCFPHNDCKGO(T DAPOBFHGAGK, bool EOBPFEJDEMA, MFOECFBBGHI<T> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x36772B0", Offset = "0x3675CB0", VA = "0x1836772B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4022790", Offset = "0x4021190", VA = "0x184022790")]
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
	[Cpp2IlInjected.Address(RVA = "0x3680FC0", Offset = "0x367F9C0", VA = "0x183680FC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A29030", Offset = "0x3A27A30", VA = "0x183A29030")]
	public JIKMIPICPFM(List<TData> FOIGBKBEFFJ, bool LOIOIJGFJEK, JEJNGPDKFKG<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x36772B0", Offset = "0x3675CB0", VA = "0x1836772B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EF9180", Offset = "0x4EF7B80", VA = "0x184EF9180")]
	public DHKMBPLFPLN(List<TData> FOIGBKBEFFJ, List<bool> FFDLHDALNMM, JEJNGPDKFKG<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x398F840", Offset = "0x398E240", VA = "0x18398F840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FDA930", Offset = "0x3FD9330", VA = "0x183FDA930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3FDAC20", Offset = "0x3FD9620", VA = "0x183FDAC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NJBNCMKJCNN<TData> DOAJKHOAAMI;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x32066C0", Offset = "0x32050C0", VA = "0x1832066C0")]
	public ECMBBEDHEEA(TData KHKBLDPOEGP, IReadOnlyList<TData> HLJIGLJKJPJ, bool MOJKOFEPLCL, JAEKDEDJNLM<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x32065C0", Offset = "0x3204FC0", VA = "0x1832065C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E375E0", Offset = "0x3E35FE0", VA = "0x183E375E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E307D0", Offset = "0x3E2F1D0", VA = "0x183E307D0")]
	public NDICOMAFLBB(IEnumerable<TData> FOIGBKBEFFJ, OIEDBBAJKGM IKNGOAKEJAP, OADCHAEGGGG OODGJPECLJK, float EFPBIAHHGCJ, bool MOJKOFEPLCL, KMLNBNHAGIC<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x36772B0", Offset = "0x3675CB0", VA = "0x1836772B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x461A060", Offset = "0x4618A60", VA = "0x18461A060")]
	public BCCOLGMAJNC(TData[] FOIGBKBEFFJ, OIEDBBAJKGM[] IKNGOAKEJAP, OADCHAEGGGG[] OODGJPECLJK, float[] EFPBIAHHGCJ, KDEDBIJDJGH<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3A73320", Offset = "0x3A71D20", VA = "0x183A73320", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class JACHFENINHL<TData> : CDLLPHMDLIN<JLBJMJDFNCA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x31FCEE0", Offset = "0x31FB8E0", VA = "0x1831FCEE0")]
	public JACHFENINHL(JLBJMJDFNCA<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3989A50", Offset = "0x3988450", VA = "0x183989A50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A733E0", Offset = "0x3A71DE0", VA = "0x183A733E0")]
	public KBDCHIHMAHP(IEnumerable<TData> FOIGBKBEFFJ, OIEDBBAJKGM IKNGOAKEJAP, OADCHAEGGGG OODGJPECLJK, float EFPBIAHHGCJ, JLBJMJDFNCA<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3A73320", Offset = "0x3A71D20", VA = "0x183A73320", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E39040", Offset = "0x3E37A40", VA = "0x183E39040")]
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
	[Cpp2IlInjected.Address(RVA = "0x37D9040", Offset = "0x37D7A40", VA = "0x1837D9040")]
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
	[Cpp2IlInjected.Address(RVA = "0x35BBDA0", Offset = "0x35BA7A0", VA = "0x1835BBDA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4615200", Offset = "0x4613C00", VA = "0x184615200")]
	public BAJHOEPBJLP(List<TData> NBBGPGGFMPG, IJMFPCLOOGK<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x36772B0", Offset = "0x3675CB0", VA = "0x1836772B0", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class EFKDANHODFA<TData> : CDLLPHMDLIN<IJMFPCLOOGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x31FCEE0", Offset = "0x31FB8E0", VA = "0x1831FCEE0")]
	public EFKDANHODFA(IJMFPCLOOGK<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x320EBB0", Offset = "0x320D5B0", VA = "0x18320EBB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D74AF0", Offset = "0x3D734F0", VA = "0x183D74AF0")]
	public MBEPANKBMKL(bool MOJKOFEPLCL, IJMFPCLOOGK<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3D74A90", Offset = "0x3D73490", VA = "0x183D74A90", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x398F900", Offset = "0x398E300", VA = "0x18398F900")]
	public JCDABBIFBOF(List<TData> NBBGPGGFMPG, bool MOJKOFEPLCL, IJMFPCLOOGK<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x398F840", Offset = "0x398E240", VA = "0x18398F840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x37CA390", Offset = "0x37C8D90", VA = "0x1837CA390")]
	public ICAJPLABFDF(TData FHHPJALIMBG, IJMFPCLOOGK<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x37CA210", Offset = "0x37C8C10", VA = "0x1837CA210", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A43970", Offset = "0x3A42370", VA = "0x183A43970")]
	public JPLAMBLDAKC(IEnumerable<TData> NBBGPGGFMPG, IJMFPCLOOGK<TData> KEHMNIODKBI, bool MOJKOFEPLCL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3A43800", Offset = "0x3A42200", VA = "0x183A43800", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x39A1890", Offset = "0x39A0290", VA = "0x1839A1890")]
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
		[Cpp2IlInjected.Address(RVA = "0x60028F0", Offset = "0x60012F0", VA = "0x1860028F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6002B70", Offset = "0x6001570", VA = "0x186002B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly DLNOJLACBHA HFPILGOJKNC;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x60032D0", Offset = "0x6001CD0", VA = "0x1860032D0")]
	public ODDOCLOACKF(bool MOJKOFEPLCL, HJAFFLFNCBM KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x60031E0", Offset = "0x6001BE0", VA = "0x1860031E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xC53A40", Offset = "0xC52440", VA = "0x180C53A40")]
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
	[Cpp2IlInjected.Address(RVA = "0x44BEBC0", Offset = "0x44BD5C0", VA = "0x1844BEBC0")]
	public GCIOJDLIHGO(bool LCPOEKIIDBP, bool OMBENPFMBON, bool CMIJAKFGAEH, bool MOJKOFEPLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6002650", Offset = "0x6001050", VA = "0x186002650")]
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
	[Cpp2IlInjected.Address(RVA = "0x6002E60", Offset = "0x6001860", VA = "0x186002E60")]
	public KJCCGJOEAEF(bool AOOGIIEBLDG, bool OMBENPFMBON, bool CMIJAKFGAEH, bool MOJKOFEPLCL, EAKAFGNIJCE KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6002E10", Offset = "0x6001810", VA = "0x186002E10", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x60030E0", Offset = "0x6001AE0", VA = "0x1860030E0")]
	public NIFAEIDCOFB(bool OMBENPFMBON, bool MOJKOFEPLCL, EAKAFGNIJCE KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6003090", Offset = "0x6001A90", VA = "0x186003090", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6002710", Offset = "0x6001110", VA = "0x186002710")]
	public HMDCICFKOIE(Guid[] CCMICJLJHFJ, Vector3[] IPAMDKNANEB, Quaternion[] NLAGHEDMCOE, float[] PHDPGMONPID, Dictionary<Guid, Vector3> AIPIELCDIFI, MHBMGKDEEIM KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6002660", Offset = "0x6001060", VA = "0x186002660", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x31FCEE0", Offset = "0x31FB8E0", VA = "0x1831FCEE0")]
	public KDHKFDGIHCF(MKNHJCAPIFC<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A8F980", Offset = "0x3A8E380", VA = "0x183A8F980", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3FB9B90", Offset = "0x3FB8590", VA = "0x183FB9B90")]
	public PAHGCFEDMON(Vector3 IIMEBLGIPJJ, bool KABLGPHGDGK, MKNHJCAPIFC<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x36746B0", Offset = "0x36730B0", VA = "0x1836746B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x37D1B50", Offset = "0x37D0550", VA = "0x1837D1B50")]
	public IDLMGGADEAN(Guid OBKJKJMEBIM, int OJANCMLFDOJ, Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI, float NLAEHEEAFBH, bool KABLGPHGDGK, MKNHJCAPIFC<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x37D1AF0", Offset = "0x37D04F0", VA = "0x1837D1AF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3B7D440", Offset = "0x3B7BE40", VA = "0x183B7D440")]
	public LGFMMKGAFFF(TData DAPOBFHGAGK, bool MOJKOFEPLCL, MKNHJCAPIFC<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x36772B0", Offset = "0x3675CB0", VA = "0x1836772B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6002EF0", Offset = "0x60018F0", VA = "0x186002EF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6003330", Offset = "0x6001D30", VA = "0x186003330")]
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
	[Cpp2IlInjected.Address(RVA = "0x3FFC470", Offset = "0x3FFAE70", VA = "0x183FFC470")]
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
	[Cpp2IlInjected.Address(RVA = "0x4945350", Offset = "0x4943D50", VA = "0x184945350")]
	public CHKMIACAEHP(IEnumerable<TData> FOIGBKBEFFJ, Vector3 AMJIBOHHAFB, bool MOJKOFEPLCL, CPOGPAHIELH<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x36772B0", Offset = "0x3675CB0", VA = "0x1836772B0", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class LBPKGBAFOMA<TData> : CDLLPHMDLIN<KCAIJEAJPHJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x31FCEE0", Offset = "0x31FB8E0", VA = "0x1831FCEE0")]
	public LBPKGBAFOMA(KCAIJEAJPHJ<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3B7A3B0", Offset = "0x3B78DB0", VA = "0x183B7A3B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3B46720", Offset = "0x3B45120", VA = "0x183B46720")]
	public LBIMOGGBDHE(IEnumerable<TData> FOIGBKBEFFJ, bool MOJKOFEPLCL, KCAIJEAJPHJ<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x36772B0", Offset = "0x3675CB0", VA = "0x1836772B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x359EC70", Offset = "0x359D670", VA = "0x18359EC70")]
	public FBALDEOMBNA(IEnumerable<TData> FOIGBKBEFFJ, Vector3 PPFCFJBBLBL, FAJOAPHNPHK FJAAMMEMBID, bool MOJKOFEPLCL, CPOGPAHIELH<TData> KEHMNIODKBI, Space OMOCJCMEMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3234EE0", Offset = "0x32338E0", VA = "0x183234EE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F1F8D0", Offset = "0x4F1E2D0", VA = "0x184F1F8D0")]
	public DMEBEIDJFBC(Vector3 AMJIBOHHAFB, KCAIJEAJPHJ<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x36746B0", Offset = "0x36730B0", VA = "0x1836746B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3204730", Offset = "0x3203130", VA = "0x183204730")]
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
	[Cpp2IlInjected.Address(RVA = "0x35B6EA0", Offset = "0x35B58A0", VA = "0x1835B6EA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x367A250", Offset = "0x3678C50", VA = "0x18367A250")]
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
	[Cpp2IlInjected.Address(RVA = "0x1ECF700", Offset = "0x1ECE100", VA = "0x181ECF700")]
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
	[Cpp2IlInjected.Address(RVA = "0x60037F0", Offset = "0x60021F0", VA = "0x1860037F0")]
	public PFKEHFDECAF(bool MOJKOFEPLCL, EPDFMBBAHJK KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6003740", Offset = "0x6002140", VA = "0x186003740", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xC53A40", Offset = "0xC52440", VA = "0x180C53A40")]
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
	[Cpp2IlInjected.Address(RVA = "0x370AEB0", Offset = "0x37098B0", VA = "0x18370AEB0")]
	public HGOHKJJGCHH(IEnumerable<TData> FOIGBKBEFFJ, Quaternion AMJIBOHHAFB, Vector3? ALABLCDIJNM, bool IOLBFMBOCJC, bool MOJKOFEPLCL, GDPPINGCKLG<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x36772B0", Offset = "0x3675CB0", VA = "0x1836772B0", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class DEPFNMMMCKE<TData> : CDLLPHMDLIN<HFEHMEECNIJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x31FCEE0", Offset = "0x31FB8E0", VA = "0x1831FCEE0")]
	public DEPFNMMMCKE(HFEHMEECNIJ<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3B7A3B0", Offset = "0x3B78DB0", VA = "0x183B7A3B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3677400", Offset = "0x3675E00", VA = "0x183677400")]
	public AFAPPCILKMM(IEnumerable<TData> FOIGBKBEFFJ, bool MOJKOFEPLCL, HFEHMEECNIJ<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x36772B0", Offset = "0x3675CB0", VA = "0x1836772B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3234FB0", Offset = "0x32339B0", VA = "0x183234FB0")]
	public ELNHNFDPNOE(IEnumerable<TData> FOIGBKBEFFJ, Quaternion GFPKBNCOCLC, FAJOAPHNPHK CADFOMNPPDA, Vector3? ALABLCDIJNM, bool IOLBFMBOCJC, bool MOJKOFEPLCL, Space OMOCJCMEMPH, GDPPINGCKLG<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3234EE0", Offset = "0x32338E0", VA = "0x183234EE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3674710", Offset = "0x3673110", VA = "0x183674710")]
	public ACDKKHFKMEB(Quaternion AMJIBOHHAFB, Vector3? ALABLCDIJNM, bool IOLBFMBOCJC, HFEHMEECNIJ<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x36746B0", Offset = "0x36730B0", VA = "0x1836746B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3B89AB0", Offset = "0x3B884B0", VA = "0x183B89AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A9F1A0", Offset = "0x3A9DBA0", VA = "0x183A9F1A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D8DE60", Offset = "0x3D8C860", VA = "0x183D8DE60")]
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
	[Cpp2IlInjected.Address(RVA = "0x44845D0", Offset = "0x4482FD0", VA = "0x1844845D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A92960", Offset = "0x3A91360", VA = "0x183A92960")]
	public KFJJBMHEKCK(Vector3 PLJJMNIOIJD, float NJPICGCBCBG, Vector3 ALABLCDIJNM, bool IBAHIJDLDIL, bool EBJCOAJHFOH, GJAKHAJIDFI<TData> KEHMNIODKBI, Space OMOCJCMEMPH = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A92900", Offset = "0x3A91300", VA = "0x183A92900", Slot = "4")]
	public override bool AJPMKBDPCCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class NBEONHCGPIA<TData> : CDLLPHMDLIN<GJAKHAJIDFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x31FCEE0", Offset = "0x31FB8E0", VA = "0x1831FCEE0")]
	public NBEONHCGPIA(GJAKHAJIDFI<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3E15160", Offset = "0x3E13B60", VA = "0x183E15160", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E147A0", Offset = "0x3E131A0", VA = "0x183E147A0")]
	public NAJFDHJIKHK(IEnumerable<TData> FOIGBKBEFFJ, bool MOJKOFEPLCL, GJAKHAJIDFI<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x36772B0", Offset = "0x3675CB0", VA = "0x1836772B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x37211B0", Offset = "0x371FBB0", VA = "0x1837211B0")]
	public ANDPJJCOGPD(float JLHAIGIMMDC, bool OMIMDGCPLGJ, Vector3 ALABLCDIJNM, GJAKHAJIDFI<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x37210E0", Offset = "0x371FAE0", VA = "0x1837210E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F21D50", Offset = "0x3F20750", VA = "0x183F21D50")]
	public OENKLDOKGOP(float NJPICGCBCBG, Vector3 ALABLCDIJNM, GJAKHAJIDFI<TData> KEHMNIODKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x36746B0", Offset = "0x36730B0", VA = "0x1836746B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6002190", Offset = "0x6000B90", VA = "0x186002190")]
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
	[Cpp2IlInjected.Address(RVA = "0x3743010", Offset = "0x3741A10", VA = "0x183743010")]
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
	[Cpp2IlInjected.Address(RVA = "0x6003070", Offset = "0x6001A70", VA = "0x186003070")]
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
	[Cpp2IlInjected.Address(RVA = "0x4462DD0", Offset = "0x44617D0", VA = "0x184462DD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x60023A0", Offset = "0x6000DA0", VA = "0x1860023A0")]
	public ALOKKIHIFIF(Guid[] CCMICJLJHFJ, Vector3[] IPAMDKNANEB, Quaternion[] NLAGHEDMCOE, float[] PHDPGMONPID, Dictionary<Guid, Vector3> AIPIELCDIFI, bool MPNBJCHLNEE = true, bool FEADENBGBPE = true, bool FJOEKHKEEJN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x60021D0", Offset = "0x6000BD0", VA = "0x1860021D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6003370", Offset = "0x6001D70", VA = "0x186003370")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static BHJKECHLECD KDFDFOMHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6003390", Offset = "0x6001D90", VA = "0x186003390")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x60036D0", Offset = "0x60020D0", VA = "0x1860036D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6003580", Offset = "0x6001F80", VA = "0x186003580")]
	[NEHHKLCIMGL(DIKIGLGFNNP.Room, OJLOCLENGNC.None)]
	private static void LFKEMOGPHEB(BHJKECHLECD LEJOHNHIFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6003430", Offset = "0x6001E30", VA = "0x186003430")]
	public static void KECAPFPCLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6003680", Offset = "0x6002080", VA = "0x186003680")]
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
	[Cpp2IlInjected.Address(RVA = "0x275A4A0", Offset = "0x2758EA0", VA = "0x18275A4A0")]
	public static void DGMHNEIDPGH<T>(T CONPDDCOPOE, JPFFJDNOAFP ADAMDPHPFAA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x275A440", Offset = "0x2758E40", VA = "0x18275A440")]
	public static void DGMHNEIDPGH<T>(T CONPDDCOPOE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x275A930", Offset = "0x2759330", VA = "0x18275A930")]
	public static void LGEIOHKPECB<T>(T CONPDDCOPOE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x275A890", Offset = "0x2759290", VA = "0x18275A890")]
	public static T JNDPLHMHPON<T>(JPFFJDNOAFP ADAMDPHPFAA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x275A6C0", Offset = "0x27590C0", VA = "0x18275A6C0")]
	public static bool GMKMIFOLGPA<T>(JPFFJDNOAFP ADAMDPHPFAA, T NAHJKOHBKGB, [Out] T KECLMELLBAK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x275A620", Offset = "0x2759020", VA = "0x18275A620")]
	public static bool EGCJDMIDHNE<T>(JPFFJDNOAFP ADAMDPHPFAA) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x275A5E0", Offset = "0x2758FE0", VA = "0x18275A5E0")]
	public static T JNDPLHMHPON<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x275A7F0", Offset = "0x27591F0", VA = "0x18275A7F0")]
	public static bool GMKMIFOLGPA<T>(T NAHJKOHBKGB, [Out] T KECLMELLBAK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x275A5E0", Offset = "0x2758FE0", VA = "0x18275A5E0")]
	public static bool EGCJDMIDHNE<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class IJDLONLLMJP
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6002BE0", Offset = "0x60015E0", VA = "0x186002BE0")]
	public static void KOLGCPGPINP(IEnumerable AEKBCONJICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x26CAA70", Offset = "0x26C9470", VA = "0x1826CAA70")]
	public static void KOLGCPGPINP<T>(T[] NIKMHLBDDHG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x26CAB60", Offset = "0x26C9560", VA = "0x1826CAB60")]
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
