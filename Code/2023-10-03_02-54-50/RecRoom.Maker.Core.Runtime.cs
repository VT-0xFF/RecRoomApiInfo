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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CCAEE0", Offset = "0x5CC96E0", VA = "0x185CCAEE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C320", Offset = "0x78AB20", VA = "0x18078C320")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C360", Offset = "0x78AB60", VA = "0x18078C360")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KKEEGEHOLIL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(NGKNDOONIKN GLMMCHDMFOG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData HBMBMELELPF, Collider BKEKMBOGLHH, NGKNDOONIKN GLMMCHDMFOG, [Optional] PFCOBFLEOJA? OCJOLFPIEKI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData HBMBMELELPF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OABJBOFHPFD<TData> : BDFCHEFLMIL, HBGDOKHOKCE<TData>, JHHNPAMLMPG<TData>, ODJBEOHHPII<TData>, LFNBADFCFEC, AOIJDJIDKII<TData>, GHPHGCMEMJF, LMLOBFNILHJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AOIJDJIDKII<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 JAKDKBMGPIO, Vector3 CFFFGOJOPLK, float NCCGMAJNKDF, [Out] T BAIHKHMHDJD, [Out] Vector3 EKLKIJEILFI, [Out] Collider BKEKMBOGLHH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 JAKDKBMGPIO, Vector3 CFFFGOJOPLK, float HPJCBDPPAID, float NCCGMAJNKDF, T[] BOOLJPOFMDA, [Out] Vector3 ILAKAKJLLFF, [Out] Collider PHDAIELJAHH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 JAKDKBMGPIO, float HPJCBDPPAID, Vector3 HBIPMILGLJL, T[] BOOLJPOFMDA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BDFCHEFLMIL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds BOLJBCJAFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform MCFKIBCCJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds IOMAGBAMNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform BOILJFCNKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 DCKHANGDIKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool BOKGCFCECJH = true, int AGDMHJLCNBB = 0);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool PPMKMBKHDNM, object PIPCHJCEPPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LMLOBFNILHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CAPEMHJDAJL INFFFCNIBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ODJBEOHHPII<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool BLJFNJGMANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int ICCLKLMAFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<TData> GPOACDCHCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData AKPEBFBEHGM);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData AKPEBFBEHGM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HBGDOKHOKCE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T ELOCHLKHPBP, [Optional] PFCOBFLEOJA? JMCPMFFLLGB, bool AAIAMFEAKPN = true);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int JEDNJDDHFHB, IEnumerable<T> DNIKHGLHFGC, bool AAIAMFEAKPN = true);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int JEDNJDDHFHB, IEnumerable<T> DNIKHGLHFGC, PFCOBFLEOJA JMCPMFFLLGB, bool AAIAMFEAKPN = true);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GHPHGCMEMJF
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LFNBADFCFEC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool DKDDJLLDDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool ANKMMCAHMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PCHCAECJNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NONJBAAOAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class DLLGAALENCE<TReceiver> : HIFMAHJCOED<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x301C590", Offset = "0x301AD90", VA = "0x18301C590")]
	public DLLGAALENCE(TReceiver PFENHEANOBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class HMHOCOAPFHP<TReceiver, TFromTask> : HIFMAHJCOED<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x301C590", Offset = "0x301AD90", VA = "0x18301C590")]
	public HMHOCOAPFHP(TReceiver PFENHEANOBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class HIFMAHJCOED<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver PFENHEANOBF;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3537A10", Offset = "0x3536210", VA = "0x183537A10")]
	public HIFMAHJCOED(TReceiver PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute KDJJLACMJLH();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct DBJGNBPBPPD<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TNode INGBBAOODKM;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4CAEF90", Offset = "0x4CAD790", VA = "0x184CAEF90")]
	public DBJGNBPBPPD(TNode INGBBAOODKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct NEFLCBLGLJH<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TNode EECKAPALHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public BONDOOHHPEA BKKIGHNMLJI;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3C9FCC0", Offset = "0x3C9E4C0", VA = "0x183C9FCC0")]
	public NEFLCBLGLJH(TNode EECKAPALHGD, BONDOOHHPEA BKKIGHNMLJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MBKANJMKPGE<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEAHONLMMLP([In] DBJGNBPBPPD<TNode> LAPKICGIDKH);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AOGFDLPCLON([In] NEFLCBLGLJH<TNode> BCGIAAIGILA);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JGEFAPOGBFP();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KMHIPDMDEPC<TNode> : DLLGAALENCE<MBKANJMKPGE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x301C590", Offset = "0x301AD90", VA = "0x18301C590")]
	public KMHIPDMDEPC(MBKANJMKPGE<TNode> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x301C540", Offset = "0x301AD40", VA = "0x18301C540", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IKCHCFIGMCK<TNode> : DLLGAALENCE<MBKANJMKPGE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly NEFLCBLGLJH<TNode> BCGIAAIGILA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x36661B0", Offset = "0x36649B0", VA = "0x1836661B0")]
	public IKCHCFIGMCK(TNode EECKAPALHGD, BONDOOHHPEA BKKIGHNMLJI, MBKANJMKPGE<TNode> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3516910", Offset = "0x3515110", VA = "0x183516910", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HJADIONDGJK<TNode> : DLLGAALENCE<MBKANJMKPGE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly DBJGNBPBPPD<TNode> LAPKICGIDKH;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3537D20", Offset = "0x3536520", VA = "0x183537D20")]
	public HJADIONDGJK(TNode GMIOLHJBELL, MBKANJMKPGE<TNode> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3038D50", Offset = "0x3037550", VA = "0x183038D50", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GKFKEEOIBJD<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TSpawnInfo GNPDAJHHGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public Vector3 OBAACBLACLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Quaternion AHLHKGGFBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float CDLIHEJMBGO;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xD31010", Offset = "0xD2F810", VA = "0x180D31010")]
	public GKFKEEOIBJD(TSpawnInfo GNPDAJHHGPH, Vector3 OBAACBLACLC, Quaternion AHLHKGGFBGH, float CDLIHEJMBGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GJIOMEDGMKB<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GPJFOOMFNHL([In] GKFKEEOIBJD<TSpawnInfo> GLKOOEPJNGN, CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CEFBIPGKNLF<TSpawnType, TSpawnInfo> : HMHOCOAPFHP<GJIOMEDGMKB<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly GKFKEEOIBJD<TSpawnInfo> DDNMEJONMEK;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4A4D5C0", Offset = "0x4A4BDC0", VA = "0x184A4D5C0")]
	public CEFBIPGKNLF(TSpawnInfo HGNODFJBIIF, Vector3 OBAACBLACLC, Quaternion AHLHKGGFBGH, float CDLIHEJMBGO, GJIOMEDGMKB<TSpawnType, TSpawnInfo> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x38EC170", Offset = "0x38EA970", VA = "0x1838EC170", Slot = "4")]
	public override Task<TSpawnType> KDJJLACMJLH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct DPEIGJMAEGL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly IEnumerable<TData> CMECMJGCDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly bool ENOGPMGKFOG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4CEB810", Offset = "0x4CEA010", VA = "0x184CEB810")]
	public DPEIGJMAEGL(IEnumerable<TData> BGNFOMBECCL, bool PINLJEAGLIE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ABOPCIIGMBJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PBLPEAFOBEK> OHFKNPHKAOB([In] DPEIGJMAEGL<TData> CHNIPNEFGPO, CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KNLFLHEFJMG<TData> : HMHOCOAPFHP<ABOPCIIGMBJ<TData>, PBLPEAFOBEK> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DPEIGJMAEGL<TData> JKAILHMPOPA;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x38EC2E0", Offset = "0x38EAAE0", VA = "0x1838EC2E0")]
	public KNLFLHEFJMG(IEnumerable<TData> BGNFOMBECCL, bool PINLJEAGLIE, ABOPCIIGMBJ<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x38EC170", Offset = "0x38EA970", VA = "0x1838EC170", Slot = "4")]
	public override Task<PBLPEAFOBEK> KDJJLACMJLH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KFDIFABIAHK<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly T HBMBMELELPF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x35379F0", Offset = "0x35361F0", VA = "0x1835379F0")]
	public KFDIFABIAHK(T OKACNBHILML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface ACFFDLINJIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEAHONLMMLP([In] KFDIFABIAHK<T> IIBPLJGBMOE);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AOGFDLPCLON();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EHONHJLFMJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDJJLACMJLH([In] JOEHIFFKJIJ<T> NKEPGEKNCMF);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct JOEHIFFKJIJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly T HBMBMELELPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool GLLEPLNDFBF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x385D2F0", Offset = "0x385BAF0", VA = "0x18385D2F0")]
	public JOEHIFFKJIJ(T OKACNBHILML, bool HGJGCPMFIGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JINIPFMEJNF<T> : DLLGAALENCE<ACFFDLINJIE<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x301C590", Offset = "0x301AD90", VA = "0x18301C590")]
	public JINIPFMEJNF(ACFFDLINJIE<T> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3856D90", Offset = "0x3855590", VA = "0x183856D90", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BBADNAKOMEH<T> : DLLGAALENCE<ACFFDLINJIE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly KFDIFABIAHK<T> IIBPLJGBMOE;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x44DAD40", Offset = "0x44D9540", VA = "0x1844DAD40")]
	public BBADNAKOMEH(T HBMBMELELPF, ACFFDLINJIE<T> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3038D50", Offset = "0x3037550", VA = "0x183038D50", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class OJKIDOBOOBL<T> : DLLGAALENCE<EHONHJLFMJH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly JOEHIFFKJIJ<T> NKEPGEKNCMF;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0560", Offset = "0x3DBED60", VA = "0x183DC0560")]
	public OJKIDOBOOBL(T HBMBMELELPF, bool HGJGCPMFIGJ, EHONHJLFMJH<T> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3038D50", Offset = "0x3037550", VA = "0x183038D50", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct PKFDDDHBNJP<TData> where TData : notnull, AKDONLEEDFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public IEnumerable<TData> CMECMJGCDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool MHMCOFADMIB;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E88E10", Offset = "0x3E87610", VA = "0x183E88E10")]
	public PKFDDDHBNJP(IEnumerable<TData> MMHJHCAFFHB, bool COCLIHPEAEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct IJNDFHHCJNK<TData> where TData : notnull, AKDONLEEDFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public List<TData> CMECMJGCDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public List<bool> BPPAIANCDDG;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x36659B0", Offset = "0x36641B0", VA = "0x1836659B0")]
	public IJNDFHHCJNK(List<TData> MMHJHCAFFHB, List<bool> ABBOGONDBAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface AKDONLEEDFD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool IPKHINIBHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HGJFNOKAJIG<TData> where TData : AKDONLEEDFD
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDJJLACMJLH([In] PKFDDDHBNJP<TData> IMNBIIPELDO);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDJJLACMJLH([In] IJNDFHHCJNK<TData> IMNBIIPELDO);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KGHJANBDBGO<TData> : DLLGAALENCE<HGJFNOKAJIG<TData>> where TData : notnull, AKDONLEEDFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly PKFDDDHBNJP<TData> IMNBIIPELDO;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x38D4690", Offset = "0x38D2E90", VA = "0x1838D4690")]
	public KGHJANBDBGO(List<TData> BGNFOMBECCL, bool MHMCOFADMIB, HGJFNOKAJIG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3038D50", Offset = "0x3037550", VA = "0x183038D50", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KOEJNMHHLFC<TData> : DLLGAALENCE<HGJFNOKAJIG<TData>> where TData : notnull, AKDONLEEDFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly IJNDFHHCJNK<TData> IMNBIIPELDO;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x39064F0", Offset = "0x3904CF0", VA = "0x1839064F0")]
	public KOEJNMHHLFC(List<TData> BGNFOMBECCL, List<bool> BPPAIANCDDG, HGJFNOKAJIG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3906430", Offset = "0x3904C30", VA = "0x183906430", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LCMCALOPACJ : AKDONLEEDFD
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface ABHGIMGNBOL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PBLPEAFOBEK> KDJJLACMJLH(JPEBCPMDMEB<TData> FCFFJOAAJNM);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class AKEKLHHCBKG<TData> : HMHOCOAPFHP<ABHGIMGNBOL<TData>, PBLPEAFOBEK> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct GPGKNBGGHLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<PBLPEAFOBEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AKEKLHHCBKG<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<PBLPEAFOBEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x34DF5B0", Offset = "0x34DDDB0", VA = "0x1834DF5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x34DF8A0", Offset = "0x34DE0A0", VA = "0x1834DF8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly JPEBCPMDMEB<TData> FCBIFLKOICI;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x36C17F0", Offset = "0x36BFFF0", VA = "0x1836C17F0")]
	public AKEKLHHCBKG(TData JJCAEBCNBBF, IReadOnlyList<TData> OBAJAAFNPEM, bool PINLJEAGLIE, ABHGIMGNBOL<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x36C16F0", Offset = "0x36BFEF0", VA = "0x1836C16F0", Slot = "4")]
	[AsyncStateMachine(typeof(AKEKLHHCBKG<>.GPGKNBGGHLN))]
	public override Task<PBLPEAFOBEK> KDJJLACMJLH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct JPEBCPMDMEB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TData HHHOFICFPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public IReadOnlyList<TData> BNJOPNOPHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool ENOGPMGKFOG;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x385DAB0", Offset = "0x385C2B0", VA = "0x18385DAB0")]
	public JPEBCPMDMEB(TData JJCAEBCNBBF, IReadOnlyList<TData> OBAJAAFNPEM, bool PINLJEAGLIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface MANJFLDBHPE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDJJLACMJLH([In] DBCOCHFFDFO<TData> IMFODBAFAJH);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface OFCGPEPMAMK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDJJLACMJLH([In] HLCNOJNBEOL<TData> IMFODBAFAJH);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface EIBHEJFAKDG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PPLBOLFHMKC([In] FPHCCCDMDIJ<TData> IMFODBAFAJH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOGFDLPCLON();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class CDGCNLGFKDL<TData> : DLLGAALENCE<MANJFLDBHPE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly DBCOCHFFDFO<TData> IMFODBAFAJH;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4A49FC0", Offset = "0x4A487C0", VA = "0x184A49FC0")]
	public CDGCNLGFKDL(IEnumerable<TData> BGNFOMBECCL, BEDEGOOCNBJ JFJPGCGPBNP, BGHPHHADMEG LGHJCFHBOJC, float ALLJFNOBLGI, bool PINLJEAGLIE, MANJFLDBHPE<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3038D50", Offset = "0x3037550", VA = "0x183038D50", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class OJPGHMDLMCL<TData> : DLLGAALENCE<OFCGPEPMAMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HLCNOJNBEOL<TData> IMFODBAFAJH;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3DC06C0", Offset = "0x3DBEEC0", VA = "0x183DC06C0")]
	public OJPGHMDLMCL(TData[] BGNFOMBECCL, BEDEGOOCNBJ[] JFJPGCGPBNP, BGHPHHADMEG[] LGHJCFHBOJC, float[] ALLJFNOBLGI, OFCGPEPMAMK<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3673C90", Offset = "0x3672490", VA = "0x183673C90", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class JNEGDDBCLMK<TData> : DLLGAALENCE<EIBHEJFAKDG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x301C590", Offset = "0x301AD90", VA = "0x18301C590")]
	public JNEGDDBCLMK(EIBHEJFAKDG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x385C350", Offset = "0x385AB50", VA = "0x18385C350", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class IOHBKMLIPNJ<TData> : DLLGAALENCE<EIBHEJFAKDG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly FPHCCCDMDIJ<TData> IMFODBAFAJH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3673D50", Offset = "0x3672550", VA = "0x183673D50")]
	public IOHBKMLIPNJ(IEnumerable<TData> BGNFOMBECCL, BEDEGOOCNBJ JFJPGCGPBNP, BGHPHHADMEG LGHJCFHBOJC, float ALLJFNOBLGI, EIBHEJFAKDG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3673C90", Offset = "0x3672490", VA = "0x183673C90", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct DBCOCHFFDFO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public IEnumerable<TData> CMECMJGCDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public BEDEGOOCNBJ LNHOIGGNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public BGHPHHADMEG DOGHILBAHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public float ALLJFNOBLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public bool PINLJEAGLIE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4CAEB20", Offset = "0x4CAD320", VA = "0x184CAEB20")]
	public DBCOCHFFDFO(IEnumerable<TData> BGNFOMBECCL, BEDEGOOCNBJ JFJPGCGPBNP, BGHPHHADMEG LGHJCFHBOJC, float ALLJFNOBLGI, bool PINLJEAGLIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct HLCNOJNBEOL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TData[] CMECMJGCDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public BEDEGOOCNBJ[] LNHOIGGNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public BGHPHHADMEG[] DOGHILBAHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float[] ALLJFNOBLGI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x353E960", Offset = "0x353D160", VA = "0x18353E960")]
	public HLCNOJNBEOL(TData[] BGNFOMBECCL, BEDEGOOCNBJ[] JFJPGCGPBNP, BGHPHHADMEG[] LGHJCFHBOJC, float[] ALLJFNOBLGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FPHCCCDMDIJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> CMECMJGCDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public BEDEGOOCNBJ LNHOIGGNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public BGHPHHADMEG DOGHILBAHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float ALLJFNOBLGI;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x33B9880", Offset = "0x33B8080", VA = "0x1833B9880")]
	public FPHCCCDMDIJ(IEnumerable<TData> BGNFOMBECCL, BEDEGOOCNBJ JFJPGCGPBNP, BGHPHHADMEG LGHJCFHBOJC, float ALLJFNOBLGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface JHHNPAMLMPG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLKOILAIODO([In] KFBBIICMLAE<TData> CHNIPNEFGPO);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGGIOPFJGMI([In] KFBBIICMLAE<TData> CHNIPNEFGPO);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PDBIKAJJPFJ([In] bool PEODOGEHLCN);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LPJGDBFOCGL([In] KFBBIICMLAE<TData> CHNIPNEFGPO);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNBDJMLJMGB();

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DNKIKJBHMFN([In] TData KPOLELABEPI);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class CCNJJFKNPEL<TData> : DLLGAALENCE<JHHNPAMLMPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly KFBBIICMLAE<TData> CHNIPNEFGPO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4A49910", Offset = "0x4A48110", VA = "0x184A49910")]
	public CCNJJFKNPEL(List<TData> GBFGDEFHEJO, JHHNPAMLMPG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3038D50", Offset = "0x3037550", VA = "0x183038D50", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CPHJAJEGGMD<TData> : DLLGAALENCE<JHHNPAMLMPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x301C590", Offset = "0x301AD90", VA = "0x18301C590")]
	public CPHJAJEGGMD(JHHNPAMLMPG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4B013D0", Offset = "0x4AFFBD0", VA = "0x184B013D0", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class GJNEEGFJBHM<TData> : DLLGAALENCE<JHHNPAMLMPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly bool PINLJEAGLIE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x34ADF10", Offset = "0x34AC710", VA = "0x1834ADF10")]
	public GJNEEGFJBHM(bool PINLJEAGLIE, JHHNPAMLMPG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x34ADEB0", Offset = "0x34AC6B0", VA = "0x1834ADEB0", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class PEIIAFCDFNB<TData> : DLLGAALENCE<JHHNPAMLMPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KFBBIICMLAE<TData> CHNIPNEFGPO;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3E73EC0", Offset = "0x3E726C0", VA = "0x183E73EC0")]
	public PEIIAFCDFNB(List<TData> GBFGDEFHEJO, bool PINLJEAGLIE, JHHNPAMLMPG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3906430", Offset = "0x3904C30", VA = "0x183906430", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class AMLHGKOIALJ<TData> : DLLGAALENCE<JHHNPAMLMPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly TData KPOLELABEPI;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x36CD2E0", Offset = "0x36CBAE0", VA = "0x1836CD2E0")]
	public AMLHGKOIALJ(TData KPOLELABEPI, JHHNPAMLMPG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x36CD160", Offset = "0x36CB960", VA = "0x1836CD160", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class KGCKFBIPGJE<TData> : DLLGAALENCE<JHHNPAMLMPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly KFBBIICMLAE<TData> CHNIPNEFGPO;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x38D4600", Offset = "0x38D2E00", VA = "0x1838D4600")]
	public KGCKFBIPGJE(List<TData> GBFGDEFHEJO, JHHNPAMLMPG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x38D44A0", Offset = "0x38D2CA0", VA = "0x1838D44A0", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct KFBBIICMLAE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public IEnumerable<TData> CMECMJGCDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool PINLJEAGLIE;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x38D31E0", Offset = "0x38D19E0", VA = "0x1838D31E0")]
	public KFBBIICMLAE(IEnumerable<TData> MMHJHCAFFHB, bool HIDEGJPEMOG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface IJIEPPEBJNM
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PBLPEAFOBEK> KDJJLACMJLH(MOOLLNPPPDG HEHJALCJMEH);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MABDCHGBIPF : HMHOCOAPFHP<IJIEPPEBJNM, PBLPEAFOBEK>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct ABDEBJKDHFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<PBLPEAFOBEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public MABDCHGBIPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter<PBLPEAFOBEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5CCA420", Offset = "0x5CC8C20", VA = "0x185CCA420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5CCA6A0", Offset = "0x5CC8EA0", VA = "0x185CCA6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly MOOLLNPPPDG PDAGBOFBDHG;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAE40", Offset = "0x5CC9640", VA = "0x185CCAE40")]
	public MABDCHGBIPF(bool PINLJEAGLIE, IJIEPPEBJNM PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAD50", Offset = "0x5CC9550", VA = "0x185CCAD50", Slot = "4")]
	[AsyncStateMachine(typeof(ABDEBJKDHFL))]
	public override Task<PBLPEAFOBEK> KDJJLACMJLH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct MOOLLNPPPDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool ENOGPMGKFOG;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xB30410", Offset = "0xB2EC10", VA = "0x180B30410")]
	public MOOLLNPPPDG(bool PINLJEAGLIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface DCEHPEEMOLP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEAHONLMMLP([In] GBLGMMPKGJF<TData> LAPKICGIDKH);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PPLBOLFHMKC([In] AMIMDKCBMDO ACJLPOIOCPP);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PPLBOLFHMKC([In] NCJGGDMILHG ACJLPOIOCPP);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AOGFDLPCLON();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class NBLOPKEOOBG<TData> : DLLGAALENCE<DCEHPEEMOLP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x301C590", Offset = "0x301AD90", VA = "0x18301C590")]
	public NBLOPKEOOBG(DCEHPEEMOLP<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3C8EDB0", Offset = "0x3C8D5B0", VA = "0x183C8EDB0", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class PAHBJFEMJLJ<TData> : DLLGAALENCE<DCEHPEEMOLP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly AMIMDKCBMDO FKBNIFIDMDN;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3E5C020", Offset = "0x3E5A820", VA = "0x183E5C020")]
	public PAHBJFEMJLJ(Vector3 GFIBDGINKPK, bool FBJCFIHMKPL, DCEHPEEMOLP<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3996020", Offset = "0x3994820", VA = "0x183996020", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class CGLHBDAPKHN<TData> : DLLGAALENCE<DCEHPEEMOLP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly NCJGGDMILHG FKBNIFIDMDN;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4A56BA0", Offset = "0x4A553A0", VA = "0x184A56BA0")]
	public CGLHBDAPKHN(Guid NPBDOEPGKBJ, int ADMJKDLHPCI, Vector3 OBAACBLACLC, Quaternion AHLHKGGFBGH, float KPOEIGEKNFE, bool FBJCFIHMKPL, DCEHPEEMOLP<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4A56B40", Offset = "0x4A55340", VA = "0x184A56B40", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GOMHFEDPOLH<TData> : DLLGAALENCE<DCEHPEEMOLP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly GBLGMMPKGJF<TData> FKBNIFIDMDN;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x34CC3D0", Offset = "0x34CABD0", VA = "0x1834CC3D0")]
	public GOMHFEDPOLH(TData HBMBMELELPF, bool PINLJEAGLIE, DCEHPEEMOLP<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3038D50", Offset = "0x3037550", VA = "0x183038D50", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct AMIMDKCBMDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly Vector3 GFIBDGINKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool FBJCFIHMKPL;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA710", Offset = "0x5CC8F10", VA = "0x185CCA710")]
	public AMIMDKCBMDO(Vector3 GFIBDGINKPK, bool FBJCFIHMKPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct NCJGGDMILHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly Guid NPBDOEPGKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly int ADMJKDLHPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly Vector3 OBAACBLACLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly Quaternion AHLHKGGFBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly float KPOEIGEKNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool FBJCFIHMKPL;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAEA0", Offset = "0x5CC96A0", VA = "0x185CCAEA0")]
	public NCJGGDMILHG(Guid NPBDOEPGKBJ, int ADMJKDLHPCI, Vector3 OBAACBLACLC, Quaternion AHLHKGGFBGH, float KPOEIGEKNFE, bool FBJCFIHMKPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct GBLGMMPKGJF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly TData HBMBMELELPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly bool PINLJEAGLIE;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3448410", Offset = "0x3446C10", VA = "0x183448410")]
	public GBLGMMPKGJF(TData HBMBMELELPF, bool PINLJEAGLIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface LCANEIDJIEN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDJJLACMJLH([In] HNLBOPFLBFF<TData> BNGMNHDBBEJ);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KDJJLACMJLH([In] ELKPCCMIFPN<TData> BNGMNHDBBEJ);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface ELMCADLMLNB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEAHONLMMLP([In] CKPPAIMIDNE<TData> CLJIOPHLCDF);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PPLBOLFHMKC([In] MCCKENKBNMK ACJLPOIOCPP);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AOGFDLPCLON();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class NMNFDBDJJDL<TData> : DLLGAALENCE<LCANEIDJIEN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly HNLBOPFLBFF<TData> BNGMNHDBBEJ;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3CBAF40", Offset = "0x3CB9740", VA = "0x183CBAF40")]
	public NMNFDBDJJDL(IEnumerable<TData> BGNFOMBECCL, Vector3 EOACAJCEJCJ, bool PINLJEAGLIE, LCANEIDJIEN<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3038D50", Offset = "0x3037550", VA = "0x183038D50", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class MIOGOCJHLCH<TData> : DLLGAALENCE<ELMCADLMLNB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x301C590", Offset = "0x301AD90", VA = "0x18301C590")]
	public MIOGOCJHLCH(ELMCADLMLNB<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x301C540", Offset = "0x301AD40", VA = "0x18301C540", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class IHAOCMHDIGE<TData> : DLLGAALENCE<ELMCADLMLNB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly CKPPAIMIDNE<TData> BNGMNHDBBEJ;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3662BB0", Offset = "0x36613B0", VA = "0x183662BB0")]
	public IHAOCMHDIGE(IEnumerable<TData> BGNFOMBECCL, bool PINLJEAGLIE, ELMCADLMLNB<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3038D50", Offset = "0x3037550", VA = "0x183038D50", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class LCKAMIOKLFF<TData> : DLLGAALENCE<LCANEIDJIEN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly ELKPCCMIFPN<TData> BNGMNHDBBEJ;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x397C4B0", Offset = "0x397ACB0", VA = "0x18397C4B0")]
	public LCKAMIOKLFF(IEnumerable<TData> BGNFOMBECCL, Vector3 EIBFFLEMDID, EAGOFAPIBOK NHMEDKOPDBN, bool PINLJEAGLIE, LCANEIDJIEN<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3516910", Offset = "0x3515110", VA = "0x183516910", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class LEBFIPBONBP<TData> : DLLGAALENCE<ELMCADLMLNB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly MCCKENKBNMK BNGMNHDBBEJ;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3996080", Offset = "0x3994880", VA = "0x183996080")]
	public LEBFIPBONBP(Vector3 EOACAJCEJCJ, ELMCADLMLNB<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3996020", Offset = "0x3994820", VA = "0x183996020", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct HNLBOPFLBFF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly IEnumerable<TData> BGNFOMBECCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly Vector3 EOACAJCEJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool PINLJEAGLIE;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3596CE0", Offset = "0x35954E0", VA = "0x183596CE0")]
	public HNLBOPFLBFF(IEnumerable<TData> BGNFOMBECCL, Vector3 EOACAJCEJCJ, bool PINLJEAGLIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct CKPPAIMIDNE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly IEnumerable<TData> BGNFOMBECCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool PINLJEAGLIE;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4A62620", Offset = "0x4A60E20", VA = "0x184A62620")]
	public CKPPAIMIDNE(IEnumerable<TData> BGNFOMBECCL, bool PINLJEAGLIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct ELKPCCMIFPN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly IEnumerable<TData> BGNFOMBECCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly Vector3 EIBFFLEMDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly EAGOFAPIBOK NHMEDKOPDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool PINLJEAGLIE;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x30160D0", Offset = "0x30148D0", VA = "0x1830160D0")]
	public ELKPCCMIFPN(IEnumerable<TData> BGNFOMBECCL, Vector3 EIBFFLEMDID, EAGOFAPIBOK NHMEDKOPDBN, bool PINLJEAGLIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct MCCKENKBNMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Vector3 EOACAJCEJCJ;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1EFAC20", Offset = "0x1EF9420", VA = "0x181EFAC20")]
	public MCCKENKBNMK(Vector3 EOACAJCEJCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum EAGOFAPIBOK
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface DCFPCFAIAOL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDJJLACMJLH([In] DOJHJMFBLME<TData> LMELCEHPLHA);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KDJJLACMJLH([In] HGNGCNPMIEJ<TData> LMELCEHPLHA);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface GMMNIOOOHOO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEAHONLMMLP([In] JPPMMMFELEI<TData> LAPKICGIDKH);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PPLBOLFHMKC([In] AEANPLFCABD ACJLPOIOCPP);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AOGFDLPCLON();
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class DDEAIOMJCOK<TData> : DLLGAALENCE<DCFPCFAIAOL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly DOJHJMFBLME<TData> LMELCEHPLHA;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4CB23C0", Offset = "0x4CB0BC0", VA = "0x184CB23C0")]
	public DDEAIOMJCOK(IEnumerable<TData> BGNFOMBECCL, Quaternion EOACAJCEJCJ, Vector3? IJFJAKBGBIK, bool AAJCAHFCBEA, bool PINLJEAGLIE, DCFPCFAIAOL<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3038D50", Offset = "0x3037550", VA = "0x183038D50", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class EMMAODCDGEI<TData> : DLLGAALENCE<GMMNIOOOHOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x301C590", Offset = "0x301AD90", VA = "0x18301C590")]
	public EMMAODCDGEI(GMMNIOOOHOO<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x301C540", Offset = "0x301AD40", VA = "0x18301C540", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class EPIJHMFKMOB<TData> : DLLGAALENCE<GMMNIOOOHOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly JPPMMMFELEI<TData> LMELCEHPLHA;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3038EA0", Offset = "0x30376A0", VA = "0x183038EA0")]
	public EPIJHMFKMOB(IEnumerable<TData> BGNFOMBECCL, bool PINLJEAGLIE, GMMNIOOOHOO<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3038D50", Offset = "0x3037550", VA = "0x183038D50", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class HCIBOKPDKPC<TData> : DLLGAALENCE<DCFPCFAIAOL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly HGNGCNPMIEJ<TData> LMELCEHPLHA;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x35169E0", Offset = "0x35151E0", VA = "0x1835169E0")]
	public HCIBOKPDKPC(IEnumerable<TData> BGNFOMBECCL, Quaternion LJANKHOPMLN, EAGOFAPIBOK ECOFEFHFBPB, Vector3? IJFJAKBGBIK, bool AAJCAHFCBEA, bool PINLJEAGLIE, DCFPCFAIAOL<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3516910", Offset = "0x3515110", VA = "0x183516910", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class PIOCFAOBPIP<TData> : DLLGAALENCE<GMMNIOOOHOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly AEANPLFCABD LMELCEHPLHA;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3E863C0", Offset = "0x3E84BC0", VA = "0x183E863C0")]
	public PIOCFAOBPIP(Quaternion EOACAJCEJCJ, Vector3? IJFJAKBGBIK, bool AAJCAHFCBEA, GMMNIOOOHOO<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3996020", Offset = "0x3994820", VA = "0x183996020", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct DOJHJMFBLME<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly IEnumerable<TData> BGNFOMBECCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Quaternion EOACAJCEJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Vector3? IJFJAKBGBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool AAJCAHFCBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly bool PINLJEAGLIE;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4CEB050", Offset = "0x4CE9850", VA = "0x184CEB050")]
	public DOJHJMFBLME(IEnumerable<TData> BGNFOMBECCL, Quaternion EOACAJCEJCJ, Vector3? IJFJAKBGBIK, bool AAJCAHFCBEA, bool PINLJEAGLIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct JPPMMMFELEI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly IEnumerable<TData> BGNFOMBECCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly bool PINLJEAGLIE;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3860890", Offset = "0x385F090", VA = "0x183860890")]
	public JPPMMMFELEI(IEnumerable<TData> BGNFOMBECCL, bool PINLJEAGLIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct HGNGCNPMIEJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly IEnumerable<TData> BGNFOMBECCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly Quaternion LJANKHOPMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly EAGOFAPIBOK ECOFEFHFBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly Vector3? IJFJAKBGBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly bool AAJCAHFCBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly bool PINLJEAGLIE;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3536E50", Offset = "0x3535650", VA = "0x183536E50")]
	public HGNGCNPMIEJ(IEnumerable<TData> BGNFOMBECCL, Quaternion LJANKHOPMLN, EAGOFAPIBOK ECOFEFHFBPB, Vector3? IJFJAKBGBIK, bool AAJCAHFCBEA, bool PINLJEAGLIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct AEANPLFCABD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly Quaternion EOACAJCEJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Vector3? IJFJAKBGBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly bool AAJCAHFCBEA;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4317000", Offset = "0x4315800", VA = "0x184317000")]
	public AEANPLFCABD(Quaternion EOACAJCEJCJ, Vector3? IJFJAKBGBIK, bool AAJCAHFCBEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface KILGGNAFDHG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEAHONLMMLP([In] PKMKHFCBIEM<TData> LAPKICGIDKH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PPLBOLFHMKC([In] FMHCOCNOCJI ACJLPOIOCPP);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PPLBOLFHMKC([In] LGDHMDFLBIK ACJLPOIOCPP);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PPLBOLFHMKC([In] AANIBLHIKNK ACJLPOIOCPP);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AOGFDLPCLON();
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class GAJAOJCOCJP<TData> : DLLGAALENCE<KILGGNAFDHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly AANIBLHIKNK JJNGMHKOOAP;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x34480E0", Offset = "0x34468E0", VA = "0x1834480E0")]
	public GAJAOJCOCJP(Vector3 DAAOCKLKMCF, float IAKMCFMIMFD, Vector3 IJFJAKBGBIK, bool PBOOPGMPFNL, KILGGNAFDHG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3448080", Offset = "0x3446880", VA = "0x183448080", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MMLFGAFLDIG<TData> : DLLGAALENCE<KILGGNAFDHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x301C590", Offset = "0x301AD90", VA = "0x18301C590")]
	public MMLFGAFLDIG(KILGGNAFDHG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3BD17D0", Offset = "0x3BCFFD0", VA = "0x183BD17D0", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class PDAEEBKNGHE<TData> : DLLGAALENCE<KILGGNAFDHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly PKMKHFCBIEM<TData> JJNGMHKOOAP;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3E729E0", Offset = "0x3E711E0", VA = "0x183E729E0")]
	public PDAEEBKNGHE(IEnumerable<TData> BGNFOMBECCL, bool PINLJEAGLIE, KILGGNAFDHG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3038D50", Offset = "0x3037550", VA = "0x183038D50", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class CHEBHDFPGNF<TData> : DLLGAALENCE<KILGGNAFDHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly LGDHMDFLBIK JJNGMHKOOAP;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4A57E10", Offset = "0x4A56610", VA = "0x184A57E10")]
	public CHEBHDFPGNF(float BBICDMBLPEB, bool BPJOOKHPGHC, Vector3 IJFJAKBGBIK, KILGGNAFDHG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4A57D40", Offset = "0x4A56540", VA = "0x184A57D40", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class LFMMKFJNLNE<TData> : DLLGAALENCE<KILGGNAFDHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly FMHCOCNOCJI JJNGMHKOOAP;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x399A130", Offset = "0x3998930", VA = "0x18399A130")]
	public LFMMKFJNLNE(float IAKMCFMIMFD, Vector3 IJFJAKBGBIK, KILGGNAFDHG<TData> PFENHEANOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3996020", Offset = "0x3994820", VA = "0x183996020", Slot = "4")]
	public override bool KDJJLACMJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct AANIBLHIKNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 DAAOCKLKMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly float IAKMCFMIMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly Vector3 IJFJAKBGBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool FBJCFIHMKPL;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA3F0", Offset = "0x5CC8BF0", VA = "0x185CCA3F0")]
	public AANIBLHIKNK(Vector3 DAAOCKLKMCF, float IAKMCFMIMFD, Vector3 IJFJAKBGBIK, bool FBJCFIHMKPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct PKMKHFCBIEM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly IEnumerable<TData> BGNFOMBECCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly bool PINLJEAGLIE;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3E939D0", Offset = "0x3E921D0", VA = "0x183E939D0")]
	public PKMKHFCBIEM(IEnumerable<TData> BGNFOMBECCL, bool PINLJEAGLIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct LGDHMDFLBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly float BBICDMBLPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool BPJOOKHPGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly Vector3 IJFJAKBGBIK;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAD30", Offset = "0x5CC9530", VA = "0x185CCAD30")]
	public LGDHMDFLBIK(float BBICDMBLPEB, bool BPJOOKHPGHC, Vector3 IJFJAKBGBIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct FMHCOCNOCJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly float IAKMCFMIMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Vector3 IJFJAKBGBIK;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x42F8810", Offset = "0x42F7010", VA = "0x1842F8810")]
	public FMHCOCNOCJI(float IAKMCFMIMFD, Vector3 IJFJAKBGBIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class BDJGIBCOAJG
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct KOMADBOEBPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool LJMOEOANGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public MPCHBJGCNBP PKDHIHLHEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public MPCHBJGCNBP CINBJOJPNGK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static KOMADBOEBPG DGDBIKMKGFH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static CancellationToken FGEHNDAGFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5CCAA40", Offset = "0x5CC9240", VA = "0x185CCAA40")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	internal static MPCHBJGCNBP PKDHIHLHEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5CCAA60", Offset = "0x5CC9260", VA = "0x185CCAA60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5CCA880", Offset = "0x5CC9080", VA = "0x185CCA880")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA730", Offset = "0x5CC8F30", VA = "0x185CCA730")]
	[OPPPCFMOGOO(CODKNAAEMCD.Room, OIAOEFLOJIJ.None)]
	private static void AGIAADHOABA(MPCHBJGCNBP ALAFGIDEHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA8F0", Offset = "0x5CC90F0", VA = "0x185CCA8F0")]
	public static void HCOIPAFLDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA830", Offset = "0x5CC9030", VA = "0x185CCA830")]
	private static MPCHBJGCNBP EBDAPBIFBLO(MPCHBJGCNBP GNIFGHPMHGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class DHCGEABOLIO
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public enum DABLFGBGDID
	{
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x222A150", Offset = "0x2228950", VA = "0x18222A150")]
	public static void IKJGIGHODIG<T>(T AOCDGMDEJCJ, DABLFGBGDID BJKOKHNAAID) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x222A290", Offset = "0x2228A90", VA = "0x18222A290")]
	public static void IKJGIGHODIG<T>(T AOCDGMDEJCJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x222A2F0", Offset = "0x2228AF0", VA = "0x18222A2F0")]
	public static void OLACHIAKLHA<T>(T AOCDGMDEJCJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x222A0B0", Offset = "0x22288B0", VA = "0x18222A0B0")]
	public static T BCFBOGKIONB<T>(DABLFGBGDID BJKOKHNAAID) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x222A070", Offset = "0x2228870", VA = "0x18222A070")]
	public static T BCFBOGKIONB<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x222A070", Offset = "0x2228870", VA = "0x18222A070")]
	public static bool LJOLENHEJDB<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class FJBINGJNNJK
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAB00", Offset = "0x5CC9300", VA = "0x185CCAB00")]
	public static void LJMBELCDIEF(IEnumerable COFKECFDOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2370EF0", Offset = "0x236F6F0", VA = "0x182370EF0")]
	public static void LJMBELCDIEF<T>(T[] JMHHCKCLFBI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2370FE0", Offset = "0x236F7E0", VA = "0x182370FE0")]
	public static void LJMBELCDIEF<T>(T CGJOJNFDJBM) where T : notnull, Enum
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
