using System;
using System.Collections;
using System.Collections.Generic;
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
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D010", Offset = "0x6A1BA10", VA = "0x186A1D010")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72C090", Offset = "0x72AA90", VA = "0x18072C090")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA36880", Offset = "0xA35280", VA = "0x180A36880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DHMAPMPMCEH<TData> : NIFMJPLJPNC, global::KOMAPIIJELH<TData>, global::KHMPFNDGHBL<TData>, global::BIKHBIHDPMI<TData>, global::MIEHLICBPPL<TData>, KMAKOPPPIPC
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MIEHLICBPPL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 BCJDHFBOOBH, Vector3 MFKKMPGAJFI, float CBFODBDKBEK, out T IJENLCMHAGB, out Vector3 FJKDNEEGJOL, out Collider FPHHMHEJDJG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 BCJDHFBOOBH, Vector3 MFKKMPGAJFI, float LNBPOBKPDNE, float CBFODBDKBEK, T[] KKEPNBGPIJD, out Vector3 BKJJMFPBDPI, out Collider AAKOOAHNBCD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 BCJDHFBOOBH, float LNBPOBKPDNE, Vector3 JGKEGLJCGFA, T[] KKEPNBGPIJD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NIFMJPLJPNC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds MCFMIOBFECN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform MJAMEAHEOBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds GJEDCKGHNMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform FPEDJDGNAOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 OOOOHEDEJNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BIKHBIHDPMI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MCJPDEFGJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int DBNNHGAFHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<TData> ILGLPFLNECN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool MPOOANKHCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool KDMNCPMGJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData JPOBIIKLHON);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData JPOBIIKLHON);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KOMAPIIJELH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T NBNOMDAKOCG, [Optional] CCIJEMEMFDD? JIDALOJGNEM, bool LBGPJGIPKLO = true);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int EJMNNLNLAFJ, IEnumerable<T> BDDEAAJFJHC, bool LBGPJGIPKLO = true);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int EJMNNLNLAFJ, IEnumerable<T> BDDEAAJFJHC, CCIJEMEMFDD JIDALOJGNEM, bool LBGPJGIPKLO = true);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KMAKOPPPIPC
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2290", Offset = "0x6E1690")]
public abstract class ICJEOOBOBAL<TReceiver> : global::KKNFLHIJEBN<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2720E90", Offset = "0x271F890", VA = "0x182720E90")]
	public ICJEOOBOBAL(TReceiver ELFHKLDIPNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2300", Offset = "0x6E1700")]
public abstract class HKBPNBEPANL<TReceiver, TFromTask> : global::KKNFLHIJEBN<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2720E90", Offset = "0x271F890", VA = "0x182720E90")]
	public HKBPNBEPANL(TReceiver ELFHKLDIPNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class KKNFLHIJEBN<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver ELFHKLDIPNL;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x38F7340", Offset = "0x38F5D40", VA = "0x1838F7340")]
	public KKNFLHIJEBN(TReceiver ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute JIPFIFODDAL();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct GDMJCOGJHEH<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TNode JEODMJEDGJF;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32EE3F0", Offset = "0x32ECDF0", VA = "0x1832EE3F0")]
	public GDMJCOGJHEH(TNode JEODMJEDGJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct HJONPEKNILN<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TNode AKGPBEKMAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public ILDNIENHAGD CFJKJBLJEHO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3E67570", Offset = "0x3E65F70", VA = "0x183E67570")]
	public HJONPEKNILN(TNode AKGPBEKMAML, ILDNIENHAGD CFJKJBLJEHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EOGIJHGIEGK<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFJBJLGDADD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0BC0", Offset = "0x6DFFC0")] in global::GDMJCOGJHEH<TNode?> NFCKIHMENFI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NNHOJLKAFGF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0C30", Offset = "0x6E0030")] in global::HJONPEKNILN<TNode?> DOAKADLOLFO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEPEIDPJIFO();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0CA0", Offset = "0x6E00A0")]
public class NPOJPEBONED<TNode> : global::ICJEOOBOBAL<global::EOGIJHGIEGK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2720E90", Offset = "0x271F890", VA = "0x182720E90")]
	public NPOJPEBONED(global::EOGIJHGIEGK<TNode> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6C80", Offset = "0x2EF5680", VA = "0x182EF6C80", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0D10", Offset = "0x6E0110")]
public class NJHNCCLGIJF<TNode> : global::ICJEOOBOBAL<global::EOGIJHGIEGK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0D80", Offset = "0x6E0180")]
	private readonly global::HJONPEKNILN<TNode> DOAKADLOLFO;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x35A68B0", Offset = "0x35A52B0", VA = "0x1835A68B0")]
	public NJHNCCLGIJF(TNode AKGPBEKMAML, ILDNIENHAGD CFJKJBLJEHO, global::EOGIJHGIEGK<TNode> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x35A67E0", Offset = "0x35A51E0", VA = "0x1835A67E0", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0DE0", Offset = "0x6E01E0")]
public class AIIAPIMHKDF<TNode> : global::ICJEOOBOBAL<global::EOGIJHGIEGK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0E50", Offset = "0x6E0250")]
	private readonly global::GDMJCOGJHEH<TNode> NFCKIHMENFI;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x360FB60", Offset = "0x360E560", VA = "0x18360FB60")]
	public AIIAPIMHKDF(TNode DLLHGMFDFGB, global::EOGIJHGIEGK<TNode> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2309B40", Offset = "0x2308540", VA = "0x182309B40", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct GGIACMIAHNF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public IEnumerable<TData> CKJDGIDGCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool DIBDBGHFKKM;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x346C280", Offset = "0x346AC80", VA = "0x18346C280")]
	public GGIACMIAHNF(IEnumerable<TData> NAIHPCNGKAD, bool LABNDPDDKCM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KBKMIAMEJAL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BFLOBLIHCNH> AFEALANIACJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0EB0", Offset = "0x6E02B0")] in global::GGIACMIAHNF<TData> OFFNIGNEPBP, CancellationToken OIMNLGJCBEC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0F20", Offset = "0x6E0320")]
public class PPBHDJJFJFM<TData> : global::HKBPNBEPANL<global::KBKMIAMEJAL<TData>, BFLOBLIHCNH> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0F90", Offset = "0x6E0390")]
	private readonly global::GGIACMIAHNF<TData> GKCPPDCCHCD;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2640400", Offset = "0x263EE00", VA = "0x182640400")]
	public PPBHDJJFJFM(IEnumerable<TData> BJOALNIEBDH, bool DIBDBGHFKKM, global::KBKMIAMEJAL<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2640320", Offset = "0x263ED20", VA = "0x182640320", Slot = "4")]
	public override Task<BFLOBLIHCNH> JIPFIFODDAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EPIONKFONAB<TData> where TData : notnull, KHDEPDDPLLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public IEnumerable<TData> CKJDGIDGCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool JCEBHJLKNPN;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x22559D0", Offset = "0x22543D0", VA = "0x1822559D0")]
	public EPIONKFONAB(IEnumerable<TData> NAIHPCNGKAD, bool FJBFAKLOPPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct JABPJAMDLLO<TData> where TData : notnull, KHDEPDDPLLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public List<TData> CKJDGIDGCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public List<bool> PPNCFFNJLKK;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3917000", Offset = "0x3915A00", VA = "0x183917000")]
	public JABPJAMDLLO(List<TData> NAIHPCNGKAD, List<bool> MMICFGMFHJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KHDEPDDPLLP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool COILDMLCODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface BNFBGHCDCAH<TData> where TData : KHDEPDDPLLP
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIPFIFODDAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0FF0", Offset = "0x6E03F0")] in global::EPIONKFONAB<TData> FDNOPMNLBHI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIPFIFODDAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1060", Offset = "0x6E0460")] in global::JABPJAMDLLO<TData> FDNOPMNLBHI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E10D0", Offset = "0x6E04D0")]
public class NNFGJGPOOPC<TData> : global::ICJEOOBOBAL<global::BNFBGHCDCAH<TData>> where TData : notnull, KHDEPDDPLLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1140", Offset = "0x6E0540")]
	private readonly global::EPIONKFONAB<TData> FDNOPMNLBHI;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3989C40", Offset = "0x3988640", VA = "0x183989C40")]
	public NNFGJGPOOPC(List<TData> BJOALNIEBDH, bool JCEBHJLKNPN, global::BNFBGHCDCAH<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2309B40", Offset = "0x2308540", VA = "0x182309B40", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E11A0", Offset = "0x6E05A0")]
public class PPPMGELDKMM<TData> : global::ICJEOOBOBAL<global::BNFBGHCDCAH<TData>> where TData : notnull, KHDEPDDPLLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1210", Offset = "0x6E0610")]
	private readonly global::JABPJAMDLLO<TData> FDNOPMNLBHI;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2640EE0", Offset = "0x263F8E0", VA = "0x182640EE0")]
	public PPPMGELDKMM(List<TData> BJOALNIEBDH, List<bool> PPNCFFNJLKK, global::BNFBGHCDCAH<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2640E10", Offset = "0x263F810", VA = "0x182640E10", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OFADFNCMKMA : KHDEPDDPLLP
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JPCIAFAJDIC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIPFIFODDAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1270", Offset = "0x6E0670")] in global::KBNKCINJJJI<TData?> CKBEBNMLNOM);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GBFILDLEAEG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIPFIFODDAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E12E0", Offset = "0x6E06E0")] in global::LJKBFBJKCKL<TData?> CKBEBNMLNOM);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface POCBLGBGFIF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PJGJHDLCGHI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1350", Offset = "0x6E0750")] in global::BLKJNJLLIJI<TData?> CKBEBNMLNOM);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNHOJLKAFGF();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E13C0", Offset = "0x6E07C0")]
public class BFNLNNMJMAA<TData> : global::ICJEOOBOBAL<global::JPCIAFAJDIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1430", Offset = "0x6E0830")]
	private readonly global::KBNKCINJJJI<TData> CKBEBNMLNOM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2309C00", Offset = "0x2308600", VA = "0x182309C00")]
	public BFNLNNMJMAA(IEnumerable<TData> BJOALNIEBDH, IAKPGHMJHAJ HAFGGBNGKBN, DPGOAOHOKGO NIFEJPCAIBK, float PHNHDEICGEC, bool DIBDBGHFKKM, global::JPCIAFAJDIC<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2309B40", Offset = "0x2308540", VA = "0x182309B40", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1490", Offset = "0x6E0890")]
public class HKIIPPDAPNK<TData> : global::ICJEOOBOBAL<global::GBFILDLEAEG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1500", Offset = "0x6E0900")]
	private readonly global::LJKBFBJKCKL<TData> CKBEBNMLNOM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3E7BE00", Offset = "0x3E7A800", VA = "0x183E7BE00")]
	public HKIIPPDAPNK(TData[] BJOALNIEBDH, IAKPGHMJHAJ[] HAFGGBNGKBN, DPGOAOHOKGO[] NIFEJPCAIBK, float[] PHNHDEICGEC, global::GBFILDLEAEG<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x39CFD00", Offset = "0x39CE700", VA = "0x1839CFD00", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1560", Offset = "0x6E0960")]
public class IDKJNELGPLM<TData> : global::ICJEOOBOBAL<global::POCBLGBGFIF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2720E90", Offset = "0x271F890", VA = "0x182720E90")]
	public IDKJNELGPLM(global::POCBLGBGFIF<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3001A60", Offset = "0x3000460", VA = "0x183001A60", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E15D0", Offset = "0x6E09D0")]
public class LGKFPIKCAAD<TData> : global::ICJEOOBOBAL<global::POCBLGBGFIF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1640", Offset = "0x6E0A40")]
	private readonly global::BLKJNJLLIJI<TData> CKBEBNMLNOM;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x39CFDC0", Offset = "0x39CE7C0", VA = "0x1839CFDC0")]
	public LGKFPIKCAAD(IEnumerable<TData> BJOALNIEBDH, IAKPGHMJHAJ HAFGGBNGKBN, DPGOAOHOKGO NIFEJPCAIBK, float PHNHDEICGEC, global::POCBLGBGFIF<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x39CFD00", Offset = "0x39CE700", VA = "0x1839CFD00", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct KBNKCINJJJI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> CKJDGIDGCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public IAKPGHMJHAJ MNHMNLFIKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public DPGOAOHOKGO KCCLBOHIEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float PHNHDEICGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool DIBDBGHFKKM;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7860", Offset = "0x2DE6260", VA = "0x182DE7860")]
	public KBNKCINJJJI(IEnumerable<TData> BJOALNIEBDH, IAKPGHMJHAJ HAFGGBNGKBN, DPGOAOHOKGO NIFEJPCAIBK, float PHNHDEICGEC, bool DIBDBGHFKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct LJKBFBJKCKL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public TData[] CKJDGIDGCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public IAKPGHMJHAJ[] MNHMNLFIKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public DPGOAOHOKGO[] KCCLBOHIEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float[] PHNHDEICGEC;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x228C7A0", Offset = "0x228B1A0", VA = "0x18228C7A0")]
	public LJKBFBJKCKL(TData[] BJOALNIEBDH, IAKPGHMJHAJ[] HAFGGBNGKBN, DPGOAOHOKGO[] NIFEJPCAIBK, float[] PHNHDEICGEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct BLKJNJLLIJI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public IEnumerable<TData> CKJDGIDGCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IAKPGHMJHAJ MNHMNLFIKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public DPGOAOHOKGO KCCLBOHIEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public float PHNHDEICGEC;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x25A71E0", Offset = "0x25A5BE0", VA = "0x1825A71E0")]
	public BLKJNJLLIJI(IEnumerable<TData> BJOALNIEBDH, IAKPGHMJHAJ HAFGGBNGKBN, DPGOAOHOKGO NIFEJPCAIBK, float PHNHDEICGEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KHMPFNDGHBL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDJBJGEDLFM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E16A0", Offset = "0x6E0AA0")] in global::PHIGBMKKJFC<TData> OFFNIGNEPBP);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKMIDJEBBOF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1710", Offset = "0x6E0B10")] in global::PHIGBMKKJFC<TData> OFFNIGNEPBP);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PIOGICIJNHO(in bool HOHBOFEENDK);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PLKNOCMLLIP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1780", Offset = "0x6E0B80")] in global::PHIGBMKKJFC<TData> OFFNIGNEPBP);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LDCINIDPCGN();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EOMDHILJHAE(in TData PKIMDBNNCKC);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E17F0", Offset = "0x6E0BF0")]
public class DACGJINBPLP<TData> : global::ICJEOOBOBAL<global::KHMPFNDGHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1860", Offset = "0x6E0C60")]
	private readonly global::PHIGBMKKJFC<TData> OFFNIGNEPBP;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3376600", Offset = "0x3375000", VA = "0x183376600")]
	public DACGJINBPLP(List<TData> AABKFFENABM, global::KHMPFNDGHBL<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2309B40", Offset = "0x2308540", VA = "0x182309B40", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E18C0", Offset = "0x6E0CC0")]
public class MPPHBECMHCK<TData> : global::ICJEOOBOBAL<global::KHMPFNDGHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2720E90", Offset = "0x271F890", VA = "0x182720E90")]
	public MPPHBECMHCK(global::KHMPFNDGHBL<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x30356B0", Offset = "0x30340B0", VA = "0x1830356B0", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1930", Offset = "0x6E0D30")]
public class DLLGGFJCDPP<TData> : global::ICJEOOBOBAL<global::KHMPFNDGHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly bool DIBDBGHFKKM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E310", Offset = "0x2D0CD10", VA = "0x182D0E310")]
	public DLLGGFJCDPP(bool DIBDBGHFKKM, global::KHMPFNDGHBL<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E2A0", Offset = "0x2D0CCA0", VA = "0x182D0E2A0", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E19A0", Offset = "0x6E0DA0")]
public class ECELFAJBPEK<TData> : global::ICJEOOBOBAL<global::KHMPFNDGHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1A10", Offset = "0x6E0E10")]
	private readonly global::PHIGBMKKJFC<TData> OFFNIGNEPBP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2963E40", Offset = "0x2962840", VA = "0x182963E40")]
	public ECELFAJBPEK(List<TData> AABKFFENABM, bool DIBDBGHFKKM, global::KHMPFNDGHBL<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2640E10", Offset = "0x263F810", VA = "0x182640E10", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1A70", Offset = "0x6E0E70")]
public class NMNAMHDPKFD<TData> : global::ICJEOOBOBAL<global::KHMPFNDGHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly TData PKIMDBNNCKC;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E7C0", Offset = "0x2E1D1C0", VA = "0x182E1E7C0")]
	public NMNAMHDPKFD(TData PKIMDBNNCKC, global::KHMPFNDGHBL<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E650", Offset = "0x2E1D050", VA = "0x182E1E650", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1AE0", Offset = "0x6E0EE0")]
public class IBIGAKJEDIE<TData> : global::ICJEOOBOBAL<global::KHMPFNDGHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1B50", Offset = "0x6E0F50")]
	private readonly global::PHIGBMKKJFC<TData> OFFNIGNEPBP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2FF4D60", Offset = "0x2FF3760", VA = "0x182FF4D60")]
	public IBIGAKJEDIE(List<TData> AABKFFENABM, global::KHMPFNDGHBL<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2FF4C90", Offset = "0x2FF3690", VA = "0x182FF4C90", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct PHIGBMKKJFC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public IEnumerable<TData> CKJDGIDGCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool DIBDBGHFKKM;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2604430", Offset = "0x2602E30", VA = "0x182604430")]
	public PHIGBMKKJFC(IEnumerable<TData> NAIHPCNGKAD, bool LABNDPDDKCM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface LBEHFPBPNNN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIPFIFODDAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1BB0", Offset = "0x6E0FB0")] in global::EPGMPCOEMDO<TData?> GHCPNPGNFMB);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface CICNFJNMPGK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFJBJLGDADD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1C20", Offset = "0x6E1020")] in global::GDDHDGONAOD<TData?> CGHHKKDDEJF);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJGJHDLCGHI(in AENFKCALOCP OGOMHPLNLHP);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NNHOJLKAFGF();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1C90", Offset = "0x6E1090")]
public class CBCHKGIFGML<TData> : global::ICJEOOBOBAL<global::LBEHFPBPNNN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1D00", Offset = "0x6E1100")]
	private readonly global::EPGMPCOEMDO<TData> GHCPNPGNFMB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3A1D960", Offset = "0x3A1C360", VA = "0x183A1D960")]
	public CBCHKGIFGML(IEnumerable<TData> BJOALNIEBDH, Vector3 PMIMHIGKBPN, bool DIBDBGHFKKM, global::LBEHFPBPNNN<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2309B40", Offset = "0x2308540", VA = "0x182309B40", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1D60", Offset = "0x6E1160")]
public class CGLAIGFJIKC<TData> : global::ICJEOOBOBAL<global::CICNFJNMPGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2720E90", Offset = "0x271F890", VA = "0x182720E90")]
	public CGLAIGFJIKC(global::CICNFJNMPGK<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6C80", Offset = "0x2EF5680", VA = "0x182EF6C80", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1DD0", Offset = "0x6E11D0")]
public class CCHMJMKDFKJ<TData> : global::ICJEOOBOBAL<global::CICNFJNMPGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1E40", Offset = "0x6E1240")]
	private readonly global::GDDHDGONAOD<TData> GHCPNPGNFMB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3A1F640", Offset = "0x3A1E040", VA = "0x183A1F640")]
	public CCHMJMKDFKJ(IEnumerable<TData> BJOALNIEBDH, bool DIBDBGHFKKM, global::CICNFJNMPGK<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2309B40", Offset = "0x2308540", VA = "0x182309B40", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1EA0", Offset = "0x6E12A0")]
public class AKBCNLDLAJN<TData> : global::ICJEOOBOBAL<global::CICNFJNMPGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly AENFKCALOCP GHCPNPGNFMB;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x36108C0", Offset = "0x360F2C0", VA = "0x1836108C0")]
	public AKBCNLDLAJN(Vector3 PMIMHIGKBPN, global::CICNFJNMPGK<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3610850", Offset = "0x360F250", VA = "0x183610850", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct EPGMPCOEMDO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly IEnumerable<TData> BJOALNIEBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly Vector3 PMIMHIGKBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool DIBDBGHFKKM;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x22556F0", Offset = "0x22540F0", VA = "0x1822556F0")]
	public EPGMPCOEMDO(IEnumerable<TData> BJOALNIEBDH, Vector3 PMIMHIGKBPN, bool DIBDBGHFKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct GDDHDGONAOD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly IEnumerable<TData> BJOALNIEBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool DIBDBGHFKKM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x32E9430", Offset = "0x32E7E30", VA = "0x1832E9430")]
	public GDDHDGONAOD(IEnumerable<TData> BJOALNIEBDH, bool DIBDBGHFKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct AENFKCALOCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly Vector3 PMIMHIGKBPN;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x319E670", Offset = "0x319D070", VA = "0x18319E670")]
	public AENFKCALOCP(Vector3 PMIMHIGKBPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface OLEBHDOLMHN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIPFIFODDAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1F10", Offset = "0x6E1310")] in global::GPKGHNAABIG<TData?> MIJEOENENPF);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface EHMINGCEDEI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFJBJLGDADD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1F80", Offset = "0x6E1380")] in global::PHLLLCLJJJJ<TData?> NFCKIHMENFI);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJGJHDLCGHI(in PGMDDAMHPLD OGOMHPLNLHP);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NNHOJLKAFGF();
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1FF0", Offset = "0x6E13F0")]
public class DCCJNPFOLAH<TData> : global::ICJEOOBOBAL<global::OLEBHDOLMHN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2060", Offset = "0x6E1460")]
	private readonly global::GPKGHNAABIG<TData> MIJEOENENPF;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2CF06C0", Offset = "0x2CEF0C0", VA = "0x182CF06C0")]
	public DCCJNPFOLAH(IEnumerable<TData> BJOALNIEBDH, Quaternion PMIMHIGKBPN, Vector3? CAEAHKDOOLP, bool AAHMOIHAKME, bool DIBDBGHFKKM, global::OLEBHDOLMHN<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2309B40", Offset = "0x2308540", VA = "0x182309B40", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E20C0", Offset = "0x6E14C0")]
public class EDEFEEADNEA<TData> : global::ICJEOOBOBAL<global::EHMINGCEDEI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2720E90", Offset = "0x271F890", VA = "0x182720E90")]
	public EDEFEEADNEA(global::EHMINGCEDEI<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6C80", Offset = "0x2EF5680", VA = "0x182EF6C80", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2130", Offset = "0x6E1530")]
public class OBHJJCCAGBG<TData> : global::ICJEOOBOBAL<global::EHMINGCEDEI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E21A0", Offset = "0x6E15A0")]
	private readonly global::PHLLLCLJJJJ<TData> MIJEOENENPF;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CF30", Offset = "0x2D1B930", VA = "0x182D1CF30")]
	public OBHJJCCAGBG(IEnumerable<TData> BJOALNIEBDH, bool DIBDBGHFKKM, global::EHMINGCEDEI<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2309B40", Offset = "0x2308540", VA = "0x182309B40", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2200", Offset = "0x6E1600")]
public class DNIMEKDJPLJ<TData> : global::ICJEOOBOBAL<global::EHMINGCEDEI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly PGMDDAMHPLD MIJEOENENPF;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3BA4050", Offset = "0x3BA2A50", VA = "0x183BA4050")]
	public DNIMEKDJPLJ(Quaternion PMIMHIGKBPN, Vector3? CAEAHKDOOLP, bool AAHMOIHAKME, global::EHMINGCEDEI<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3610850", Offset = "0x360F250", VA = "0x183610850", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct GPKGHNAABIG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IEnumerable<TData> BJOALNIEBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly Quaternion PMIMHIGKBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly Vector3? CAEAHKDOOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly bool AAHMOIHAKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool DIBDBGHFKKM;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2ECF570", Offset = "0x2ECDF70", VA = "0x182ECF570")]
	public GPKGHNAABIG(IEnumerable<TData> BJOALNIEBDH, Quaternion PMIMHIGKBPN, Vector3? CAEAHKDOOLP, bool AAHMOIHAKME, bool DIBDBGHFKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct PHLLLCLJJJJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly IEnumerable<TData> BJOALNIEBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool DIBDBGHFKKM;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2606270", Offset = "0x2604C70", VA = "0x182606270")]
	public PHLLLCLJJJJ(IEnumerable<TData> BJOALNIEBDH, bool DIBDBGHFKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct PGMDDAMHPLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly Quaternion PMIMHIGKBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly Vector3? CAEAHKDOOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly bool AAHMOIHAKME;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5B9CFC0", Offset = "0x5B9B9C0", VA = "0x185B9CFC0")]
	public PGMDDAMHPLD(Quaternion PMIMHIGKBPN, Vector3? CAEAHKDOOLP, bool AAHMOIHAKME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class DOEGMGFAIEH
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static AOONKACGDKK? NMHGAJNLGLA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal static AOONKACGDKK LCNJLEALFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CC70", Offset = "0x6A1B670", VA = "0x186A1CC70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CBA0", Offset = "0x6A1B5A0", VA = "0x186A1CBA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static CancellationToken GHJHAKAKGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CD00", Offset = "0x6A1B700", VA = "0x186A1CD00")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A1CBF0", Offset = "0x6A1B5F0", VA = "0x186A1CBF0")]
	[JDDIJBKLPJE(JMBPMAGFLED.Room, GHILFLKBMBN.None)]
	private static void DAFMJECGFIM(AOONKACGDKK BMHLDEHOBJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class AOMOPGONHIE
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum EEJKCIAIPLD
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x10F91F0", Offset = "0x10F7BF0", VA = "0x1810F91F0")]
	public static void IABDEIIHAPA<T>(T MLLKBCFLFJE, EEJKCIAIPLD OGILDIMGIOH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x10F9170", Offset = "0x10F7B70", VA = "0x1810F9170")]
	public static void IABDEIIHAPA<T>(T MLLKBCFLFJE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x10F9390", Offset = "0x10F7D90", VA = "0x1810F9390")]
	public static T MKLBNKEKMJE<T>(EEJKCIAIPLD OGILDIMGIOH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x10F9430", Offset = "0x10F7E30", VA = "0x1810F9430")]
	public static T MKLBNKEKMJE<T>() where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class HGEMEOLEOEJ
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6A1CDA0", Offset = "0x6A1B7A0", VA = "0x186A1CDA0")]
	public static void KGAMOAPJPHC(IEnumerable GPBFFBAAOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x36C49B0", Offset = "0x36C33B0", VA = "0x1836C49B0")]
	public static void KGAMOAPJPHC<T>(T[] BGAKDGCGOMH) where T : notnull
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
