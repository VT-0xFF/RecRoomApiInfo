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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72CDFC0", Offset = "0x72CCDC0", VA = "0x1872CDFC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
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
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72CE330", Offset = "0x72CD130", VA = "0x1872CE330", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OKBLLOLOLPB<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn JDPJBONKDIE(TData JOOHPPHJKMI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GINMEDELNIB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(ELICGFMBAFI HLECICDDCCN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData OBIPBFFAILK, Collider OFCLIMBNIME, ELICGFMBAFI HLECICDDCCN, [Optional] IIDEEAJADIF? NLIMBAPMOPO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData OBIPBFFAILK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider OFCLIMBNIME);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DJEBFEKKHDH<TData> : PLLHIEMGLJL, ABPOOLNFBBA<TData>, FGFFKJMNEEJ<TData>, CDNHKAGGJGB<TData>, BHAOOFEPFON, LGALPBHBNCM<TData>, ODIGJIEFGIA, KDNDIANKPJC
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LGALPBHBNCM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 JBEADJDOHMN, Vector3 GGAAGAFEPHJ, float HKMCFNGLEFP, [Out] T ODNJKMBGAHJ, [Out] Vector3 JCJOGJFJILM, [Out] Collider OFCLIMBNIME);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 JBEADJDOHMN, Vector3 GGAAGAFEPHJ, float DDCFOLFKDDM, float HKMCFNGLEFP, T[] KIBPLDGNOHN, [Out] Vector3 KPCEIOJAEBD, [Out] Collider FOOIBMNIBCP);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 JBEADJDOHMN, float DDCFOLFKDDM, Vector3 PJGHEKJDCPG, T[] KIBPLDGNOHN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider LOHANPKBMOF, [Out] T JCGFEKGPOKL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PLLHIEMGLJL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds FKHJLLLPMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform DKDKNALAPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds GKPMCOLPOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform NONOFEKGPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 FFAKIFGMOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool GNFCGCLAOAD
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
	void SetSelectionBoundsDirty(bool PAICMELFKLF = true, int MBBGPNNLHAF = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool NCGOCGMHHIA, object HACFGBHNOCC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KDNDIANKPJC
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GAMKKEJCIBM DMGLCIAKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FDCAMLAKBEL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NFDIIKEMDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool JAIEAHAHMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool DIIAOKNOCML
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> BAEJIDHCGDK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CDNHKAGGJGB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool AIOJCGIDEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int ABHIKANEEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> MIFFPFGCADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData MJONLBMPPCK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData MJONLBMPPCK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ABPOOLNFBBA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T JOOHPPHJKMI, [Optional] IIDEEAJADIF? NCIPABHIJLA, bool BJAGHCDLJDE = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int BMGBDLLODJK, IEnumerable<T> LOMECELICFD, bool BJAGHCDLJDE = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int BMGBDLLODJK, IEnumerable<T> LOMECELICFD, IIDEEAJADIF NCIPABHIJLA, bool BJAGHCDLJDE = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ODIGJIEFGIA
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BHAOOFEPFON
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool PNLCBBDJFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool JOOHGKDEBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool CAILFGBANMA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool ALABNAJJHHO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class JNEGNBPLJOE<TReceiver> : MOFOHCFKMFA<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x437A670", Offset = "0x4379470", VA = "0x18437A670")]
	public JNEGNBPLJOE(TReceiver MGPKLMAHHGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class IBHKANEAMGF<TReceiver, TFromTask> : MOFOHCFKMFA<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x437A670", Offset = "0x4379470", VA = "0x18437A670")]
	public IBHKANEAMGF(TReceiver MGPKLMAHHGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class MOFOHCFKMFA<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver MGPKLMAHHGI;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4CC4A40", Offset = "0x4CC3840", VA = "0x184CC4A40")]
	public MOFOHCFKMFA(TReceiver MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute JEMOGMDLBLA();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class MOPILPFKCIM<TReceiver, TResult> : MOFOHCFKMFA<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x437A670", Offset = "0x4379470", VA = "0x18437A670")]
	public MOPILPFKCIM(TReceiver MGPKLMAHHGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct OCFMDKOJGHO<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup LMEIOFKLCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData EENHGKCHBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> IJJMEOFFNNB;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2419D20", Offset = "0x2418B20", VA = "0x182419D20")]
	public OCFMDKOJGHO(TGroup KOMBIPFJOAE, TData FHGJDFHLFDC, IEnumerable<TData> FBJOMFELGNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IBDFFOLHOBC<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup LMEIOFKLCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> IJJMEOFFNNB;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x956F00", Offset = "0x955D00", VA = "0x180956F00")]
	public IBDFFOLHOBC(TGroup KOMBIPFJOAE, IEnumerable<TData> FBJOMFELGNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PIHPGEPDIDE<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup LMEIOFKLCFE;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
	public PIHPGEPDIDE(TGroup KOMBIPFJOAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DPDIGALCFOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<Guid> IJJMEOFFNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Guid IAAONFOIMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool KDIABNLLGGN;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x72CC7B0", Offset = "0x72CB5B0", VA = "0x1872CC7B0")]
	public DPDIGALCFOD(IEnumerable<Guid> FBJOMFELGNP, Guid NGJLPFOIIME, bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LHNELOEGCEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public Guid IAAONFOIMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool KDIABNLLGGN;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2292D70", Offset = "0x2291B70", VA = "0x182292D70")]
	public LHNELOEGCEO(Guid NGJLPFOIIME, bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface KJKDBDKKGLP<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EFLLIDNLPAK EBMOGFFKPDD(OCFMDKOJGHO<TGroup, TData> PHOBFBJOBMB);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EFLLIDNLPAK MOOOHIGMOEN(OCFMDKOJGHO<TGroup, TData> PHOBFBJOBMB);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EFLLIDNLPAK EAOIAMFPCJE(IBDFFOLHOBC<TGroup, TData> PHOBFBJOBMB);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EFLLIDNLPAK AMJEICPINEF(PIHPGEPDIDE<TGroup> PHOBFBJOBMB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface OBBEAJACFOM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EFLLIDNLPAK> EBMOGFFKPDD(DPDIGALCFOD PHOBFBJOBMB);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<EFLLIDNLPAK> MOOOHIGMOEN(LHNELOEGCEO PHOBFBJOBMB);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AMAEEPKCKIE<TGroup, TData> : MOPILPFKCIM<KJKDBDKKGLP<TGroup, TData>, EFLLIDNLPAK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly IBDFFOLHOBC<TGroup, TData> PHOBFBJOBMB;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4527370", Offset = "0x4526170", VA = "0x184527370")]
	public AMAEEPKCKIE(TGroup KOMBIPFJOAE, IEnumerable<TData> FBJOMFELGNP, KJKDBDKKGLP<TGroup, TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x45272B0", Offset = "0x45260B0", VA = "0x1845272B0", Slot = "4")]
	public override EFLLIDNLPAK JEMOGMDLBLA()
	{
		return default(EFLLIDNLPAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KFDMOMNDLGP<TGroup, TData> : MOPILPFKCIM<KJKDBDKKGLP<TGroup, TData>, EFLLIDNLPAK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OCFMDKOJGHO<TGroup, TData> PHOBFBJOBMB;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x48C9850", Offset = "0x48C8650", VA = "0x1848C9850")]
	public KFDMOMNDLGP(TGroup KOMBIPFJOAE, TData FBDBBFNFPMG, IEnumerable<TData> FBJOMFELGNP, KJKDBDKKGLP<TGroup, TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x49A96D0", Offset = "0x49A84D0", VA = "0x1849A96D0", Slot = "4")]
	public override EFLLIDNLPAK JEMOGMDLBLA()
	{
		return default(EFLLIDNLPAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DJILBLNMJPP<TGroup, TData> : MOPILPFKCIM<KJKDBDKKGLP<TGroup, TData>, EFLLIDNLPAK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly PIHPGEPDIDE<TGroup> PHOBFBJOBMB;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4E2DD40", Offset = "0x4E2CB40", VA = "0x184E2DD40")]
	public DJILBLNMJPP(TGroup KOMBIPFJOAE, KJKDBDKKGLP<TGroup, TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x610D980", Offset = "0x610C780", VA = "0x18610D980", Slot = "4")]
	public override EFLLIDNLPAK JEMOGMDLBLA()
	{
		return default(EFLLIDNLPAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JIPKDOGLCFE<TGroup, TData> : MOPILPFKCIM<KJKDBDKKGLP<TGroup, TData>, EFLLIDNLPAK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OCFMDKOJGHO<TGroup, TData> PHOBFBJOBMB;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x48C9850", Offset = "0x48C8650", VA = "0x1848C9850")]
	public JIPKDOGLCFE(TGroup KOMBIPFJOAE, TData FHGJDFHLFDC, IEnumerable<TData> FBJOMFELGNP, KJKDBDKKGLP<TGroup, TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x48C9770", Offset = "0x48C8570", VA = "0x1848C9770", Slot = "4")]
	public override EFLLIDNLPAK JEMOGMDLBLA()
	{
		return default(EFLLIDNLPAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LPJALNENGFC : IBHKANEAMGF<OBBEAJACFOM, EFLLIDNLPAK>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct BPFHIJCJLGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<EFLLIDNLPAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LPJALNENGFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<EFLLIDNLPAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x72CC4B0", Offset = "0x72CB2B0", VA = "0x1872CC4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x72CC740", Offset = "0x72CB540", VA = "0x1872CC740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private DPDIGALCFOD PHOBFBJOBMB;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72CD9C0", Offset = "0x72CC7C0", VA = "0x1872CD9C0")]
	public LPJALNENGFC(IEnumerable<Guid> PCPMCPCAHDJ, Guid NGJLPFOIIME, bool HCPJGHIBJAD, OBBEAJACFOM MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72CD8D0", Offset = "0x72CC6D0", VA = "0x1872CD8D0", Slot = "4")]
	[AsyncStateMachine(typeof(BPFHIJCJLGD))]
	public override Task<EFLLIDNLPAK> JEMOGMDLBLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class PJDAPLGPAIH : IBHKANEAMGF<OBBEAJACFOM, EFLLIDNLPAK>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct MEPCMDDIANC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<EFLLIDNLPAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public PJDAPLGPAIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<EFLLIDNLPAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x72CDA80", Offset = "0x72CC880", VA = "0x1872CDA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x72CDD20", Offset = "0x72CCB20", VA = "0x1872CDD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly LHNELOEGCEO PHOBFBJOBMB;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x72CE2B0", Offset = "0x72CD0B0", VA = "0x1872CE2B0")]
	public PJDAPLGPAIH(Guid NGJLPFOIIME, bool HCPJGHIBJAD, OBBEAJACFOM MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72CE1C0", Offset = "0x72CCFC0", VA = "0x1872CE1C0", Slot = "4")]
	[AsyncStateMachine(typeof(MEPCMDDIANC))]
	public override Task<EFLLIDNLPAK> JEMOGMDLBLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct JAMAHGJOFHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly EECNJBGLIDN GECFFNJMOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool KDIABNLLGGN;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x72CCEE0", Offset = "0x72CBCE0", VA = "0x1872CCEE0")]
	public JAMAHGJOFHH(EECNJBGLIDN NGLBPEAJFCM, bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface NPHKEMBBDMA<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> JEMOGMDLBLA(JAMAHGJOFHH IPDABNODKHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class IAKPEKAJGEG<TSpawnType> : IBHKANEAMGF<NPHKEMBBDMA<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct FGKEAJKEAPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public IAKPEKAJGEG<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4398B90", Offset = "0x4397990", VA = "0x184398B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3FDD4F0", Offset = "0x3FDC2F0", VA = "0x183FDD4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly JAMAHGJOFHH IPDABNODKHJ;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x46C8A40", Offset = "0x46C7840", VA = "0x1846C8A40")]
	public IAKPEKAJGEG(EECNJBGLIDN NGLBPEAJFCM, bool HCPJGHIBJAD, NPHKEMBBDMA<TSpawnType> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x46C8940", Offset = "0x46C7740", VA = "0x1846C8940", Slot = "4")]
	[AsyncStateMachine(typeof(IAKPEKAJGEG<>.FGKEAJKEAPA))]
	public override Task<TSpawnType> JEMOGMDLBLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct EECNJBGLIDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly bool EKJJEKACJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Vector3 IHCJOJAHMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 FJDJKDCINHA;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x72CC8E0", Offset = "0x72CB6E0", VA = "0x1872CC8E0")]
	public EECNJBGLIDN(Transform NOFDOCBLHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x72CC820", Offset = "0x72CB620", VA = "0x1872CC820")]
	public EECNJBGLIDN(Vector3 FOPIBLDPFFK, Vector3 AKEODPFBHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x72CC7F0", Offset = "0x72CB5F0", VA = "0x1872CC7F0")]
	public static EECNJBGLIDN KPIDJMMGJOI()
	{
		return default(EECNJBGLIDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x72CC850", Offset = "0x72CB650", VA = "0x1872CC850")]
	private EECNJBGLIDN(bool LFOIHGLDFGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct OOANJBMGBLK<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TNode JGKDIILEIHG;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4E57C80", Offset = "0x4E56A80", VA = "0x184E57C80")]
	public OOANJBMGBLK(TNode JGKDIILEIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct JNLKJCEBIKM<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public TNode LBHGBIKGJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public TReparentOperations HPFJLHHCJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public BBMONGBPDAC ODDBEIKOLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool KDIABNLLGGN;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x48EDBB0", Offset = "0x48EC9B0", VA = "0x1848EDBB0")]
	public JNLKJCEBIKM(TNode LBHGBIKGJAC, TReparentOperations HPFJLHHCJCO, BBMONGBPDAC ODDBEIKOLIP, bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface JEDIGMFMILE<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICPLHACACCB([In] OOANJBMGBLK<TNode> DLIFLBKFCPE);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FPFIMKPAIEF([In] JNLKJCEBIKM<TNode, TReparentOperations> DGEHACCKDKJ);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BBHAPJGMPGC();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class GDNONNPNPNH<TNode, TReparentOperations> : JNEGNBPLJOE<JEDIGMFMILE<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x437A670", Offset = "0x4379470", VA = "0x18437A670")]
	public GDNONNPNPNH(JEDIGMFMILE<TNode, TReparentOperations> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x44AD850", Offset = "0x44AC650", VA = "0x1844AD850", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JGEHMOAGICF<TNode, TReparentOperations> : JNEGNBPLJOE<JEDIGMFMILE<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly JNLKJCEBIKM<TNode, TReparentOperations> DGEHACCKDKJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x48BE3B0", Offset = "0x48BD1B0", VA = "0x1848BE3B0")]
	public JGEHMOAGICF(TNode LBHGBIKGJAC, TReparentOperations HPFJLHHCJCO, BBMONGBPDAC ODDBEIKOLIP, JEDIGMFMILE<TNode, TReparentOperations> MGPKLMAHHGI, bool HCPJGHIBJAD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x44A0F30", Offset = "0x449FD30", VA = "0x1844A0F30", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class EEIAFKOLADE<TNode, TReparentOperations> : JNEGNBPLJOE<JEDIGMFMILE<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly OOANJBMGBLK<TNode> DLIFLBKFCPE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6C90", Offset = "0x3FA5A90", VA = "0x183FA6C90")]
	public EEIAFKOLADE(TNode KKFDOALAKAJ, JEDIGMFMILE<TNode, TReparentOperations> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6BE0", Offset = "0x3FA59E0", VA = "0x183FA6BE0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct DJGFEJADLCK<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TSpawnInfo OHNHGCGCLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector3 AKEODPFBHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Quaternion CKABIAOPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float KFHMJCONBDC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x610D7F0", Offset = "0x610C5F0", VA = "0x18610D7F0")]
	public DJGFEJADLCK(TSpawnInfo OHNHGCGCLAF, Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, float KFHMJCONBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface LFFFFEPLHNJ<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> NPKJKNOGBIH([In] DJGFEJADLCK<TSpawnInfo> CMANDEDMEEH, CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class FKNOINGEJLF<TSpawnType, TSpawnInfo> : IBHKANEAMGF<LFFFFEPLHNJ<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly DJGFEJADLCK<TSpawnInfo> EHEEIKICBAM;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x43CBA40", Offset = "0x43CA840", VA = "0x1843CBA40")]
	public FKNOINGEJLF(TSpawnInfo ICNJFIBBNIE, Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, float KFHMJCONBDC, LFFFFEPLHNJ<TSpawnType, TSpawnInfo> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3FF44F0", Offset = "0x3FF32F0", VA = "0x183FF44F0", Slot = "4")]
	public override Task<TSpawnType> JEMOGMDLBLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct JCGFBIFNCLH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IEnumerable<TData> IJJMEOFFNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool KDIABNLLGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool MMKLAKJNACG;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x48B7790", Offset = "0x48B6590", VA = "0x1848B7790")]
	public JCGFBIFNCLH(IEnumerable<TData> FBJOMFELGNP, bool HCPJGHIBJAD = false, bool CNGFLAOOADE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface DHDPHDIKBNE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EFLLIDNLPAK> MOEJAAHPKCB([In] JCGFBIFNCLH<TData> GNDGPEEJBHC, CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class EKDMGCFFJGF<TData> : IBHKANEAMGF<DHDPHDIKBNE<TData>, EFLLIDNLPAK> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JCGFBIFNCLH<TData> PLAFOGOMBKJ;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3FF45D0", Offset = "0x3FF33D0", VA = "0x183FF45D0")]
	public EKDMGCFFJGF(IEnumerable<TData> FBJOMFELGNP, bool HCPJGHIBJAD, DHDPHDIKBNE<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3FF44F0", Offset = "0x3FF32F0", VA = "0x183FF44F0", Slot = "4")]
	public override Task<EFLLIDNLPAK> JEMOGMDLBLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct GBAHIHHGILK<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T OBIPBFFAILK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x44A1E80", Offset = "0x44A0C80", VA = "0x1844A1E80")]
	public GBAHIHHGILK(T HDDAKANHBDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface OHIJFJOMFJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICPLHACACCB([In] GBAHIHHGILK<T> MFBNGLFJCNA);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FPFIMKPAIEF();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface FHKPLEAPKJK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEMOGMDLBLA([In] MHEKPJGIFLP<T> ADFKEEIFEMK);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct MHEKPJGIFLP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T OBIPBFFAILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool EFMOOADGNBB;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4C989A0", Offset = "0x4C977A0", VA = "0x184C989A0")]
	public MHEKPJGIFLP(T HDDAKANHBDI, bool FGHEDCBOKOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class DHNOHGLMCEK<T> : JNEGNBPLJOE<OHIJFJOMFJJ<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x437A670", Offset = "0x4379470", VA = "0x18437A670")]
	public DHNOHGLMCEK(OHIJFJOMFJJ<T> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x61005B0", Offset = "0x60FF3B0", VA = "0x1861005B0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class OCHJBGKDMIC<T> : JNEGNBPLJOE<OHIJFJOMFJJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly GBAHIHHGILK<T> MFBNGLFJCNA;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4E2DCB0", Offset = "0x4E2CAB0", VA = "0x184E2DCB0")]
	public OCHJBGKDMIC(T OBIPBFFAILK, OHIJFJOMFJJ<T> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6BE0", Offset = "0x3FA59E0", VA = "0x183FA6BE0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NACOECHOJIM<T> : JNEGNBPLJOE<FHKPLEAPKJK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly MHEKPJGIFLP<T> ADFKEEIFEMK;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4D15990", Offset = "0x4D14790", VA = "0x184D15990")]
	public NACOECHOJIM(T OBIPBFFAILK, bool FGHEDCBOKOI, FHKPLEAPKJK<T> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6BE0", Offset = "0x3FA59E0", VA = "0x183FA6BE0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct POKANHMAJPD<TData> where TData : notnull, KPFFIIMNNMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IEnumerable<TData> IJJMEOFFNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool GFJMGJOJGLJ;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4F3DDB0", Offset = "0x4F3CBB0", VA = "0x184F3DDB0")]
	public POKANHMAJPD(IEnumerable<TData> NCLLDJENAMO, bool HKDBPMMCMMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct JFFHEENBODE<TData> where TData : notnull, KPFFIIMNNMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public List<TData> IJJMEOFFNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public List<bool> JAKDHDDKAOK;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x48BDD80", Offset = "0x48BCB80", VA = "0x1848BDD80")]
	public JFFHEENBODE(List<TData> NCLLDJENAMO, List<bool> CNLDIHJPEOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface KPFFIIMNNMP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool DPHBMMGPJDE
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
public interface HLGDHPPBKNP<TData> where TData : KPFFIIMNNMP
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEMOGMDLBLA([In] POKANHMAJPD<TData> FJCBICHIFNE);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEMOGMDLBLA([In] JFFHEENBODE<TData> FJCBICHIFNE);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface LFALIJOKJDB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BHFFMLMACCB(T OBIPBFFAILK);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class IKNPPKAOAOL<TData> : JNEGNBPLJOE<HLGDHPPBKNP<TData>> where TData : notnull, KPFFIIMNNMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly POKANHMAJPD<TData> FJCBICHIFNE;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x46E9450", Offset = "0x46E8250", VA = "0x1846E9450")]
	public IKNPPKAOAOL(List<TData> FBJOMFELGNP, bool GFJMGJOJGLJ, HLGDHPPBKNP<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6BE0", Offset = "0x3FA59E0", VA = "0x183FA6BE0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class LNGGKIPMLFP<TData> : JNEGNBPLJOE<HLGDHPPBKNP<TData>> where TData : notnull, KPFFIIMNNMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly JFFHEENBODE<TData> FJCBICHIFNE;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4AADCB0", Offset = "0x4AACAB0", VA = "0x184AADCB0")]
	public LNGGKIPMLFP(List<TData> FBJOMFELGNP, List<bool> JAKDHDDKAOK, HLGDHPPBKNP<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x49A1F90", Offset = "0x49A0D90", VA = "0x1849A1F90", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface KJKONIHFJBA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EFLLIDNLPAK> JEMOGMDLBLA(IFKNGLIALAN<TData> IIGLNDHFFCF);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class GFGPHHKGKGC<TData> : IBHKANEAMGF<KJKONIHFJBA<TData>, EFLLIDNLPAK> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct OGNJNDBEBJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<EFLLIDNLPAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GFGPHHKGKGC<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<EFLLIDNLPAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4E425C0", Offset = "0x4E413C0", VA = "0x184E425C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4E428A0", Offset = "0x4E416A0", VA = "0x184E428A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly IFKNGLIALAN<TData> HFJGFAMOCEL;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x44B54A0", Offset = "0x44B42A0", VA = "0x1844B54A0")]
	public GFGPHHKGKGC(TData JFFNMFFAACK, IReadOnlyList<TData> JEGKOINDDOP, bool HCPJGHIBJAD, KJKONIHFJBA<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x44B53A0", Offset = "0x44B41A0", VA = "0x1844B53A0", Slot = "4")]
	[AsyncStateMachine(typeof(GFGPHHKGKGC<>.OGNJNDBEBJD))]
	public override Task<EFLLIDNLPAK> JEMOGMDLBLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct IFKNGLIALAN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData DMGKJHNHMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public IReadOnlyList<TData> FANOJCHJGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool KDIABNLLGGN;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x46DB730", Offset = "0x46DA530", VA = "0x1846DB730")]
	public IFKNGLIALAN(TData JFFNMFFAACK, IReadOnlyList<TData> JEGKOINDDOP, bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface NAJGJLGCPAH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEMOGMDLBLA([In] OKOPPLLJAPE<TData> GECPFOOKOLO);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface KNPBGBIEMKA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEMOGMDLBLA([In] HIBNBJDKDOI<TData> GECPFOOKOLO);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface PMOAHBKKOKO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFHDDEAGPOJ([In] MNFINEBHLJH<TData> GECPFOOKOLO);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPFIMKPAIEF();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class FMPHIDDNFJE<TData> : JNEGNBPLJOE<NAJGJLGCPAH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OKOPPLLJAPE<TData> GECPFOOKOLO;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x43D0860", Offset = "0x43CF660", VA = "0x1843D0860")]
	public FMPHIDDNFJE(IEnumerable<TData> FBJOMFELGNP, BDCLPCNFFNI EDAHAPFCLBP, OPLNEGJOKGG FAGGGCGAPOE, float FGOEMOFGMDG, bool HCPJGHIBJAD, NAJGJLGCPAH<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6BE0", Offset = "0x3FA59E0", VA = "0x183FA6BE0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class ODFCKAHBJEP<TData> : JNEGNBPLJOE<KNPBGBIEMKA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly HIBNBJDKDOI<TData> GECPFOOKOLO;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4E2FB20", Offset = "0x4E2E920", VA = "0x184E2FB20")]
	public ODFCKAHBJEP(TData[] FBJOMFELGNP, BDCLPCNFFNI[] EDAHAPFCLBP, OPLNEGJOKGG[] FAGGGCGAPOE, float[] FGOEMOFGMDG, KNPBGBIEMKA<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x48BF920", Offset = "0x48BE720", VA = "0x1848BF920", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class NJHNPICGCNH<TData> : JNEGNBPLJOE<PMOAHBKKOKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x437A670", Offset = "0x4379470", VA = "0x18437A670")]
	public NJHNPICGCNH(PMOAHBKKOKO<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4D2DCA0", Offset = "0x4D2CAA0", VA = "0x184D2DCA0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class JHGAFJDIDCB<TData> : JNEGNBPLJOE<PMOAHBKKOKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly MNFINEBHLJH<TData> GECPFOOKOLO;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x48BF9D0", Offset = "0x48BE7D0", VA = "0x1848BF9D0")]
	public JHGAFJDIDCB(IEnumerable<TData> FBJOMFELGNP, BDCLPCNFFNI EDAHAPFCLBP, OPLNEGJOKGG FAGGGCGAPOE, float FGOEMOFGMDG, PMOAHBKKOKO<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x48BF920", Offset = "0x48BE720", VA = "0x1848BF920", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct OKOPPLLJAPE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public IEnumerable<TData> IJJMEOFFNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public BDCLPCNFFNI AMMOEPOKKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public OPLNEGJOKGG CELLCPCCNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float FGOEMOFGMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool HCPJGHIBJAD;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4E4C340", Offset = "0x4E4B140", VA = "0x184E4C340")]
	public OKOPPLLJAPE(IEnumerable<TData> FBJOMFELGNP, BDCLPCNFFNI EDAHAPFCLBP, OPLNEGJOKGG FAGGGCGAPOE, float FGOEMOFGMDG, bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct HIBNBJDKDOI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public TData[] IJJMEOFFNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public BDCLPCNFFNI[] AMMOEPOKKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public OPLNEGJOKGG[] CELLCPCCNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float[] FGOEMOFGMDG;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x45731D0", Offset = "0x4571FD0", VA = "0x1845731D0")]
	public HIBNBJDKDOI(TData[] FBJOMFELGNP, BDCLPCNFFNI[] EDAHAPFCLBP, OPLNEGJOKGG[] FAGGGCGAPOE, float[] FGOEMOFGMDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct MNFINEBHLJH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public IEnumerable<TData> IJJMEOFFNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public BDCLPCNFFNI AMMOEPOKKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public OPLNEGJOKGG CELLCPCCNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float FGOEMOFGMDG;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4CC41D0", Offset = "0x4CC2FD0", VA = "0x184CC41D0")]
	public MNFINEBHLJH(IEnumerable<TData> FBJOMFELGNP, BDCLPCNFFNI EDAHAPFCLBP, OPLNEGJOKGG FAGGGCGAPOE, float FGOEMOFGMDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface FGFFKJMNEEJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EAOIAMFPCJE([In] AHDLADCMHIM<TData> GNDGPEEJBHC);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMJEICPINEF([In] AHDLADCMHIM<TData> GNDGPEEJBHC);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LHKBDMIFBHO([In] bool NMEBJOLBLOH);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PNLEBLAPDAI([In] AHDLADCMHIM<TData> GNDGPEEJBHC);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ILHJICLGLLF();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FHLIMGIOMFL([In] TData CDELNNJIFDP);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class CLCEANFGCJN<TData> : JNEGNBPLJOE<FGFFKJMNEEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AHDLADCMHIM<TData> GNDGPEEJBHC;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x596A960", Offset = "0x5969760", VA = "0x18596A960")]
	public CLCEANFGCJN(List<TData> CMEOIDEONPB, FGFFKJMNEEJ<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x596A860", Offset = "0x5969660", VA = "0x18596A860", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PBCIFAFMIBD<TData> : JNEGNBPLJOE<FGFFKJMNEEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x437A670", Offset = "0x4379470", VA = "0x18437A670")]
	public PBCIFAFMIBD(FGFFKJMNEEJ<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4F02500", Offset = "0x4F01300", VA = "0x184F02500", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class CKHCJEDFHOK<TData> : JNEGNBPLJOE<FGFFKJMNEEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly bool HCPJGHIBJAD;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5967D80", Offset = "0x5966B80", VA = "0x185967D80")]
	public CKHCJEDFHOK(bool HCPJGHIBJAD, FGFFKJMNEEJ<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5967D20", Offset = "0x5966B20", VA = "0x185967D20", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class KDBPIECFIJM<TData> : JNEGNBPLJOE<FGFFKJMNEEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly AHDLADCMHIM<TData> GNDGPEEJBHC;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x49A2040", Offset = "0x49A0E40", VA = "0x1849A2040")]
	public KDBPIECFIJM(List<TData> CMEOIDEONPB, bool HCPJGHIBJAD, FGFFKJMNEEJ<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x49A1F90", Offset = "0x49A0D90", VA = "0x1849A1F90", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class CIOAPHAKLEE<TData> : JNEGNBPLJOE<FGFFKJMNEEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TData CDELNNJIFDP;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5964E00", Offset = "0x5963C00", VA = "0x185964E00")]
	public CIOAPHAKLEE(TData CDELNNJIFDP, FGFFKJMNEEJ<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5964D40", Offset = "0x5963B40", VA = "0x185964D40", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class CKIFNBLAKBP<TData> : JNEGNBPLJOE<FGFFKJMNEEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly AHDLADCMHIM<TData> GNDGPEEJBHC;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5967EF0", Offset = "0x5966CF0", VA = "0x185967EF0")]
	public CKIFNBLAKBP(IEnumerable<TData> CMEOIDEONPB, FGFFKJMNEEJ<TData> MGPKLMAHHGI, bool HCPJGHIBJAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5967DE0", Offset = "0x5966BE0", VA = "0x185967DE0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct AHDLADCMHIM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IEnumerable<TData> IJJMEOFFNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool HCPJGHIBJAD;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4484580", Offset = "0x4483380", VA = "0x184484580")]
	public AHDLADCMHIM(IEnumerable<TData> NCLLDJENAMO, bool PCBLCLHIBLO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface ECEFCBBLPIA
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EFLLIDNLPAK> JEMOGMDLBLA(BCIPFCCKJEF MPIBEPMHJHJ);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class PDLGIDLPEOE : IBHKANEAMGF<ECEFCBBLPIA, EFLLIDNLPAK>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct LNJONFIKNND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<EFLLIDNLPAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public PDLGIDLPEOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<EFLLIDNLPAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x72CD5F0", Offset = "0x72CC3F0", VA = "0x1872CD5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x72CD860", Offset = "0x72CC660", VA = "0x1872CD860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly BCIPFCCKJEF HGDAALKEPMJ;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x72CE130", Offset = "0x72CCF30", VA = "0x1872CE130")]
	public PDLGIDLPEOE(bool HCPJGHIBJAD, ECEFCBBLPIA MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x72CE040", Offset = "0x72CCE40", VA = "0x1872CE040", Slot = "4")]
	[AsyncStateMachine(typeof(LNJONFIKNND))]
	public override Task<EFLLIDNLPAK> JEMOGMDLBLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct BCIPFCCKJEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool KDIABNLLGGN;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x271F930", Offset = "0x271E730", VA = "0x18271F930")]
	public BCIPFCCKJEF(bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct PECJJKFGJLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool FBNOODJOHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool GIJDMIIKELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly bool KFHMJCONBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool HCPJGHIBJAD;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x54C45D0", Offset = "0x54C33D0", VA = "0x1854C45D0")]
	public PECJJKFGJLM(bool FBNOODJOHFO, bool GIJDMIIKELJ, bool KFHMJCONBDC, bool HCPJGHIBJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x72CE1B0", Offset = "0x72CCFB0", VA = "0x1872CE1B0")]
	public PECJJKFGJLM(bool GIJDMIIKELJ, bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface PNILMFHNOKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFEOGODFJFD(PECJJKFGJLM EFNKLGJLBDL);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DIOHMMENJME(PECJJKFGJLM EFNKLGJLBDL);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class AEMJOLABMNA : JNEGNBPLJOE<PNILMFHNOKJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly PECJJKFGJLM EFNKLGJLBDL;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x72CC350", Offset = "0x72CB150", VA = "0x1872CC350")]
	public AEMJOLABMNA(bool KAEMFHJNGPI, bool GIJDMIIKELJ, bool KFHMJCONBDC, bool HCPJGHIBJAD, PNILMFHNOKJ MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x72CC300", Offset = "0x72CB100", VA = "0x1872CC300", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class BCGKHMMOBJI : JNEGNBPLJOE<PNILMFHNOKJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly PECJJKFGJLM EFNKLGJLBDL;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x72CC430", Offset = "0x72CB230", VA = "0x1872CC430")]
	public BCGKHMMOBJI(bool GIJDMIIKELJ, bool HCPJGHIBJAD, PNILMFHNOKJ MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x72CC3E0", Offset = "0x72CB1E0", VA = "0x1872CC3E0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface CFLFMKJEPBF
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEMOGMDLBLA([In] JBLLPPCNFIH ELLOOIHLHAL);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class LGBCKJHGGJO : JNEGNBPLJOE<CFLFMKJEPBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly JBLLPPCNFIH ELLOOIHLHAL;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x72CD410", Offset = "0x72CC210", VA = "0x1872CD410")]
	public LGBCKJHGGJO(Guid[] MNLGGAKFDKB, Vector3[] PCDNOGADEIP, Quaternion[] PNJOLNAPMPA, float[] AEJKPHCLCDN, Dictionary<Guid, Vector3> IPAKJEALKHI, CFLFMKJEPBF MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x72CD360", Offset = "0x72CC160", VA = "0x1872CD360", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface JIAGLPBFDIH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICPLHACACCB([In] OEDNEJOBCBJ<TData> DLIFLBKFCPE);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EFHDDEAGPOJ([In] FAIILDMAILN FNOPMDDGNHC);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EFHDDEAGPOJ([In] IKBDIKPHJBG FNOPMDDGNHC);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FPFIMKPAIEF();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class JLFLKGGBFCN<TData> : JNEGNBPLJOE<JIAGLPBFDIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x437A670", Offset = "0x4379470", VA = "0x18437A670")]
	public JLFLKGGBFCN(JIAGLPBFDIH<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x48D1B80", Offset = "0x48D0980", VA = "0x1848D1B80", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class IBKKFBADNEO<TData> : JNEGNBPLJOE<JIAGLPBFDIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly FAIILDMAILN OPIPKHEJHFG;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x46CB700", Offset = "0x46CA500", VA = "0x1846CB700")]
	public IBKKFBADNEO(Vector3 MFIANGIDGII, bool PLLCBHGJPJE, JIAGLPBFDIH<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x43D06D0", Offset = "0x43CF4D0", VA = "0x1843D06D0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MNDCIPCNLFD<TData> : JNEGNBPLJOE<JIAGLPBFDIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly IKBDIKPHJBG OPIPKHEJHFG;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4CC4090", Offset = "0x4CC2E90", VA = "0x184CC4090")]
	public MNDCIPCNLFD(Guid OFOOAIKJPCP, int KNCPCNBMDNF, Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, float HCPBBIGLAFG, bool PLLCBHGJPJE, JIAGLPBFDIH<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4CC4030", Offset = "0x4CC2E30", VA = "0x184CC4030", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class JKDNJCCKENC<TData> : JNEGNBPLJOE<JIAGLPBFDIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly OEDNEJOBCBJ<TData> OPIPKHEJHFG;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x48CB110", Offset = "0x48C9F10", VA = "0x1848CB110")]
	public JKDNJCCKENC(TData OBIPBFFAILK, bool HCPJGHIBJAD, JIAGLPBFDIH<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6BE0", Offset = "0x3FA59E0", VA = "0x183FA6BE0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct FAIILDMAILN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly Vector3 MFIANGIDGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly bool PLLCBHGJPJE;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x72CCD30", Offset = "0x72CBB30", VA = "0x1872CCD30")]
	public FAIILDMAILN(Vector3 MFIANGIDGII, bool PLLCBHGJPJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct IKBDIKPHJBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Guid OFOOAIKJPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly int KNCPCNBMDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 AKEODPFBHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly Quaternion CKABIAOPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly float HCPBBIGLAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool PLLCBHGJPJE;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x72CCD90", Offset = "0x72CBB90", VA = "0x1872CCD90")]
	public IKBDIKPHJBG(Guid OFOOAIKJPCP, int KNCPCNBMDNF, Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, float HCPBBIGLAFG, bool PLLCBHGJPJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct OEDNEJOBCBJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly TData OBIPBFFAILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool HCPJGHIBJAD;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4E328E0", Offset = "0x4E316E0", VA = "0x184E328E0")]
	public OEDNEJOBCBJ(TData OBIPBFFAILK, bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface PHEKJMFELCH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEMOGMDLBLA([In] CAICGELBFDM<TData> HNIENHCDAFC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JEMOGMDLBLA([In] FDBGCFMLIGJ<TData> HNIENHCDAFC);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface DOBAECLAELH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICPLHACACCB([In] OLKPNFEPMLO<TData> OPEBPCHKEJI);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EFHDDEAGPOJ([In] PPPIKBMMHJF FNOPMDDGNHC);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FPFIMKPAIEF();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class HBGJMCCMICO<TData> : JNEGNBPLJOE<PHEKJMFELCH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly CAICGELBFDM<TData> HNIENHCDAFC;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x454F2A0", Offset = "0x454E0A0", VA = "0x18454F2A0")]
	public HBGJMCCMICO(IEnumerable<TData> FBJOMFELGNP, Vector3 IFNKANDPFON, bool HCPJGHIBJAD, PHEKJMFELCH<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6BE0", Offset = "0x3FA59E0", VA = "0x183FA6BE0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class PNCDMHHBJGF<TData> : JNEGNBPLJOE<DOBAECLAELH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x437A670", Offset = "0x4379470", VA = "0x18437A670")]
	public PNCDMHHBJGF(DOBAECLAELH<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x44AD850", Offset = "0x44AC650", VA = "0x1844AD850", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class OJNBHJJBNMM<TData> : JNEGNBPLJOE<DOBAECLAELH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly OLKPNFEPMLO<TData> HNIENHCDAFC;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4E4B820", Offset = "0x4E4A620", VA = "0x184E4B820")]
	public OJNBHJJBNMM(IEnumerable<TData> FBJOMFELGNP, bool HCPJGHIBJAD, DOBAECLAELH<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6BE0", Offset = "0x3FA59E0", VA = "0x183FA6BE0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class PPKKMFJLPJI<TData> : JNEGNBPLJOE<PHEKJMFELCH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly FDBGCFMLIGJ<TData> HNIENHCDAFC;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4F3EBA0", Offset = "0x4F3D9A0", VA = "0x184F3EBA0")]
	public PPKKMFJLPJI(IEnumerable<TData> FBJOMFELGNP, Vector3 LOJAEMNDMEO, FFHFECGKEOC BCOLCBHJHOO, bool HCPJGHIBJAD, PHEKJMFELCH<TData> MGPKLMAHHGI, Space ANJIOANBFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x44A0F30", Offset = "0x449FD30", VA = "0x1844A0F30", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class OPMMJFOGMGD<TData> : JNEGNBPLJOE<DOBAECLAELH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly PPPIKBMMHJF HNIENHCDAFC;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AC80", Offset = "0x4E59A80", VA = "0x184E5AC80")]
	public OPMMJFOGMGD(Vector3 IFNKANDPFON, DOBAECLAELH<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x43D06D0", Offset = "0x43CF4D0", VA = "0x1843D06D0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct CAICGELBFDM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly IEnumerable<TData> FBJOMFELGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 IFNKANDPFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool HCPJGHIBJAD;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x576AFD0", Offset = "0x5769DD0", VA = "0x18576AFD0")]
	public CAICGELBFDM(IEnumerable<TData> FBJOMFELGNP, Vector3 IFNKANDPFON, bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct OLKPNFEPMLO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly IEnumerable<TData> FBJOMFELGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool HCPJGHIBJAD;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4E4C920", Offset = "0x4E4B720", VA = "0x184E4C920")]
	public OLKPNFEPMLO(IEnumerable<TData> FBJOMFELGNP, bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct FDBGCFMLIGJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly IEnumerable<TData> FBJOMFELGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Vector3 LOJAEMNDMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly FFHFECGKEOC BCOLCBHJHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool HCPJGHIBJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly Space ANJIOANBFBH;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x438A360", Offset = "0x4389160", VA = "0x18438A360")]
	public FDBGCFMLIGJ(IEnumerable<TData> FBJOMFELGNP, Vector3 LOJAEMNDMEO, FFHFECGKEOC BCOLCBHJHOO, bool HCPJGHIBJAD, Space ANJIOANBFBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct PPPIKBMMHJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Vector3 IFNKANDPFON;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x27211F0", Offset = "0x271FFF0", VA = "0x1827211F0")]
	public PPPIKBMMHJF(Vector3 IFNKANDPFON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum FFHFECGKEOC
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
public interface MLFLBGHGKND
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEMOGMDLBLA([In] DLEKBCIJKCM JBLHKCMMCJF);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class INBMCOKKMGP : JNEGNBPLJOE<MLFLBGHGKND>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly DLEKBCIJKCM JBLHKCMMCJF;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x72CCE80", Offset = "0x72CBC80", VA = "0x1872CCE80")]
	public INBMCOKKMGP(bool HCPJGHIBJAD, MLFLBGHGKND MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x72CCDD0", Offset = "0x72CBBD0", VA = "0x1872CCDD0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct DLEKBCIJKCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool HCPJGHIBJAD;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x271F930", Offset = "0x271E730", VA = "0x18271F930")]
	public DLEKBCIJKCM(bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface PGCMNFIOCIK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEMOGMDLBLA([In] AKDHBLKKJDM<TData> EDIDFLAMIFB);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JEMOGMDLBLA([In] OCEPLNDAPAO<TData> EDIDFLAMIFB);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface HGFKLNKBFAN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICPLHACACCB([In] AHKJPPJKJFO<TData> DLIFLBKFCPE);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EFHDDEAGPOJ([In] JCKJHIGOHPD FNOPMDDGNHC);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FPFIMKPAIEF();
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class KKALOAOHOHK<TData> : JNEGNBPLJOE<PGCMNFIOCIK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AKDHBLKKJDM<TData> EDIDFLAMIFB;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x49C54C0", Offset = "0x49C42C0", VA = "0x1849C54C0")]
	public KKALOAOHOHK(IEnumerable<TData> FBJOMFELGNP, Quaternion IFNKANDPFON, Vector3? PLJPILPDLPB, bool OHINIHKMJDJ, bool HCPJGHIBJAD, PGCMNFIOCIK<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6BE0", Offset = "0x3FA59E0", VA = "0x183FA6BE0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class JEPEKAFBPGK<TData> : JNEGNBPLJOE<HGFKLNKBFAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x437A670", Offset = "0x4379470", VA = "0x18437A670")]
	public JEPEKAFBPGK(HGFKLNKBFAN<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x44AD850", Offset = "0x44AC650", VA = "0x1844AD850", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class AFCMMIILJKP<TData> : JNEGNBPLJOE<HGFKLNKBFAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly AHKJPPJKJFO<TData> EDIDFLAMIFB;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x447FDC0", Offset = "0x447EBC0", VA = "0x18447FDC0")]
	public AFCMMIILJKP(IEnumerable<TData> FBJOMFELGNP, bool HCPJGHIBJAD, HGFKLNKBFAN<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6BE0", Offset = "0x3FA59E0", VA = "0x183FA6BE0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class GAMCGFBDHIO<TData> : JNEGNBPLJOE<PGCMNFIOCIK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OCEPLNDAPAO<TData> EDIDFLAMIFB;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x44A0FF0", Offset = "0x449FDF0", VA = "0x1844A0FF0")]
	public GAMCGFBDHIO(IEnumerable<TData> FBJOMFELGNP, Quaternion DCGJKAKNEMG, FFHFECGKEOC MHMAIPAAPCA, Vector3? PLJPILPDLPB, bool OHINIHKMJDJ, bool HCPJGHIBJAD, Space ANJIOANBFBH, PGCMNFIOCIK<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x44A0F30", Offset = "0x449FD30", VA = "0x1844A0F30", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class AECILOKELAJ<TData> : JNEGNBPLJOE<HGFKLNKBFAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly JCKJHIGOHPD EDIDFLAMIFB;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x447F470", Offset = "0x447E270", VA = "0x18447F470")]
	public AECILOKELAJ(Quaternion IFNKANDPFON, Vector3? PLJPILPDLPB, bool OHINIHKMJDJ, HGFKLNKBFAN<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x43D06D0", Offset = "0x43CF4D0", VA = "0x1843D06D0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct AKDHBLKKJDM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly IEnumerable<TData> FBJOMFELGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Quaternion IFNKANDPFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3? PLJPILPDLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool OHINIHKMJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool HCPJGHIBJAD;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4493950", Offset = "0x4492750", VA = "0x184493950")]
	public AKDHBLKKJDM(IEnumerable<TData> FBJOMFELGNP, Quaternion IFNKANDPFON, Vector3? PLJPILPDLPB, bool OHINIHKMJDJ, bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct AHKJPPJKJFO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly IEnumerable<TData> FBJOMFELGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly bool HCPJGHIBJAD;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4489020", Offset = "0x4487E20", VA = "0x184489020")]
	public AHKJPPJKJFO(IEnumerable<TData> FBJOMFELGNP, bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct OCEPLNDAPAO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly IEnumerable<TData> FBJOMFELGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly Quaternion DCGJKAKNEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly FFHFECGKEOC MHMAIPAAPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3? PLJPILPDLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool OHINIHKMJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool HCPJGHIBJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space ANJIOANBFBH;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D8D0", Offset = "0x4E2C6D0", VA = "0x184E2D8D0")]
	public OCEPLNDAPAO(IEnumerable<TData> FBJOMFELGNP, Quaternion DCGJKAKNEMG, FFHFECGKEOC MHMAIPAAPCA, Vector3? PLJPILPDLPB, bool OHINIHKMJDJ, bool HCPJGHIBJAD, Space ANJIOANBFBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct JCKJHIGOHPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Quaternion IFNKANDPFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly Vector3? PLJPILPDLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool OHINIHKMJDJ;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5471DF0", Offset = "0x5470BF0", VA = "0x185471DF0")]
	public JCKJHIGOHPD(Quaternion IFNKANDPFON, Vector3? PLJPILPDLPB, bool OHINIHKMJDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface PNAAELGPCDM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICPLHACACCB([In] DOEHCEODAFM<TData> DLIFLBKFCPE);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EFHDDEAGPOJ([In] KMPHEJMHHJG FNOPMDDGNHC);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EFHDDEAGPOJ([In] PDMFFBIJKFF FNOPMDDGNHC);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EFHDDEAGPOJ([In] FOMILAFLOMB FNOPMDDGNHC);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FPFIMKPAIEF();
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class ODLJHLGDADH<TData> : JNEGNBPLJOE<PNAAELGPCDM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly FOMILAFLOMB LGGHJNCCBLA;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4E2FC60", Offset = "0x4E2EA60", VA = "0x184E2FC60")]
	public ODLJHLGDADH(Vector3 ELOHNLJJOMP, float GCBKKLKKPFG, Vector3 PLJPILPDLPB, bool FEGHAPECKJM, bool IGMCFBLEHMK, PNAAELGPCDM<TData> MGPKLMAHHGI, Space ANJIOANBFBH = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4E2FC00", Offset = "0x4E2EA00", VA = "0x184E2FC00", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class MEAGFJEANKJ<TData> : JNEGNBPLJOE<PNAAELGPCDM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x437A670", Offset = "0x4379470", VA = "0x18437A670")]
	public MEAGFJEANKJ(PNAAELGPCDM<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4C89E70", Offset = "0x4C88C70", VA = "0x184C89E70", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class MJLPMDMMLGM<TData> : JNEGNBPLJOE<PNAAELGPCDM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly DOEHCEODAFM<TData> LGGHJNCCBLA;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4CA79D0", Offset = "0x4CA67D0", VA = "0x184CA79D0")]
	public MJLPMDMMLGM(IEnumerable<TData> FBJOMFELGNP, bool HCPJGHIBJAD, PNAAELGPCDM<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6BE0", Offset = "0x3FA59E0", VA = "0x183FA6BE0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class LJJLPHKDHCE<TData> : JNEGNBPLJOE<PNAAELGPCDM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly PDMFFBIJKFF LGGHJNCCBLA;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4A986F0", Offset = "0x4A974F0", VA = "0x184A986F0")]
	public LJJLPHKDHCE(float AMIJFHINFBJ, bool BNBEFAALMPB, Vector3 PLJPILPDLPB, PNAAELGPCDM<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4A98630", Offset = "0x4A97430", VA = "0x184A98630", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class FMOAEAAIEGO<TData> : JNEGNBPLJOE<PNAAELGPCDM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly KMPHEJMHHJG LGGHJNCCBLA;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x43D0730", Offset = "0x43CF530", VA = "0x1843D0730")]
	public FMOAEAAIEGO(float GCBKKLKKPFG, Vector3 PLJPILPDLPB, PNAAELGPCDM<TData> MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x43D06D0", Offset = "0x43CF4D0", VA = "0x1843D06D0", Slot = "4")]
	public override bool JEMOGMDLBLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct FOMILAFLOMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 ELOHNLJJOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly float GCBKKLKKPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Vector3 PLJPILPDLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool PLLCBHGJPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Space ANJIOANBFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool IGMCFBLEHMK;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x72CCD50", Offset = "0x72CBB50", VA = "0x1872CCD50")]
	public FOMILAFLOMB(Vector3 ELOHNLJJOMP, float GCBKKLKKPFG, Vector3 PLJPILPDLPB, bool PLLCBHGJPJE, bool DHLNFBFHLBL, Space ANJIOANBFBH = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct DOEHCEODAFM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly IEnumerable<TData> FBJOMFELGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool HCPJGHIBJAD;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x612B460", Offset = "0x612A260", VA = "0x18612B460")]
	public DOEHCEODAFM(IEnumerable<TData> FBJOMFELGNP, bool HCPJGHIBJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct PDMFFBIJKFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float AMIJFHINFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool BNBEFAALMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Vector3 PLJPILPDLPB;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x72CE190", Offset = "0x72CCF90", VA = "0x1872CE190")]
	public PDMFFBIJKFF(float AMIJFHINFBJ, bool BNBEFAALMPB, Vector3 PLJPILPDLPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct KMPHEJMHHJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly float GCBKKLKKPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Vector3 PLJPILPDLPB;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x544E3A0", Offset = "0x544D1A0", VA = "0x18544E3A0")]
	public KMPHEJMHHJG(float GCBKKLKKPFG, Vector3 PLJPILPDLPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct JBLLPPCNFIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly Guid[] FBJOMFELGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool BJOPJEGHDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool MCLDIOBPJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool CAEKIHGPFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3[] PCDNOGADEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion[] PNJOLNAPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly float[] AEJKPHCLCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly Dictionary<Guid, Vector3> IPAKJEALKHI;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x72CD0D0", Offset = "0x72CBED0", VA = "0x1872CD0D0")]
	public JBLLPPCNFIH(Guid[] MNLGGAKFDKB, Vector3[] PCDNOGADEIP, Quaternion[] PNJOLNAPMPA, float[] AEJKPHCLCDN, Dictionary<Guid, Vector3> IPAKJEALKHI, bool BJOPJEGHDFK = true, bool MCLDIOBPJKD = true, bool CAEKIHGPFFI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x72CCF00", Offset = "0x72CBD00", VA = "0x1872CCF00")]
	private static void JFEABPBOGBI(Dictionary<Guid, Vector3> IPAKJEALKHI, int LCOBDDBJDKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class ENLFEKADNDB
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private struct EDCGEDGFABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public bool CJKOKEOGNKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public IEPIHLKICIO FIBLJBHNAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public IEPIHLKICIO BEIIFNGIFID;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static EDCGEDGFABC PHGLNCIMOHB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken PGMDPJPDGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x72CCC70", Offset = "0x72CBA70", VA = "0x1872CCC70")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static IEPIHLKICIO FIBLJBHNAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x72CCC90", Offset = "0x72CBA90", VA = "0x1872CCC90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x72CCB00", Offset = "0x72CB900", VA = "0x1872CCB00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x72CCB70", Offset = "0x72CB970", VA = "0x1872CCB70")]
	[FOLINPJCBJN.OMHALDBFHHH]
	internal static void OGLOOKLDEDN(IEPIHLKICIO KPCOLOGKPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x72CC9A0", Offset = "0x72CB7A0", VA = "0x1872CC9A0")]
	public static void GCNCDDFOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x72CC950", Offset = "0x72CB750", VA = "0x1872CC950")]
	private static IEPIHLKICIO FNICFPBMNPE(IEPIHLKICIO MBHFIPEOKPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class PJJLLIBJMPN
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum DNILONJADLI
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x34A0940", Offset = "0x349F740", VA = "0x1834A0940")]
	public static void GOOGKFIEHCK<T>(T PMGDCKPCODN, DNILONJADLI OBDHBADPJNM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x34A08D0", Offset = "0x349F6D0", VA = "0x1834A08D0")]
	public static void GOOGKFIEHCK<T>(T PMGDCKPCODN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x34A0CB0", Offset = "0x349FAB0", VA = "0x1834A0CB0")]
	public static void OELPBILGAHL<T>(T PMGDCKPCODN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x34A0770", Offset = "0x349F570", VA = "0x1834A0770")]
	public static T ANFJBBFMPMK<T>(DNILONJADLI OBDHBADPJNM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x34A0B60", Offset = "0x349F960", VA = "0x1834A0B60")]
	public static bool KFIFLGLFIGE<T>(DNILONJADLI OBDHBADPJNM, T? CKNLEDJAEDF, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T CPDGBDABHJK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x34A0820", Offset = "0x349F620", VA = "0x1834A0820")]
	public static bool CLBLMINNIAK<T>(DNILONJADLI OBDHBADPJNM) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x34A0710", Offset = "0x349F510", VA = "0x1834A0710")]
	public static T ANFJBBFMPMK<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x34A0AA0", Offset = "0x349F8A0", VA = "0x1834A0AA0")]
	public static bool KFIFLGLFIGE<T>(T CKNLEDJAEDF, [Out] T CPDGBDABHJK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x34A0710", Offset = "0x349F510", VA = "0x1834A0710")]
	public static bool CLBLMINNIAK<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal static class MKIPDBNEEBH
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x72CDD90", Offset = "0x72CCB90", VA = "0x1872CDD90")]
	public static void CEEEGMKHLBJ(IEnumerable BENNKCBKMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x33C7F90", Offset = "0x33C6D90", VA = "0x1833C7F90")]
	public static void CEEEGMKHLBJ<T>(T[] EOOCBMPNEML) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x33C8170", Offset = "0x33C6F70", VA = "0x1833C8170")]
	public static void CEEEGMKHLBJ<T>(T LJGAMICHBPH) where T : notnull, Enum
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
