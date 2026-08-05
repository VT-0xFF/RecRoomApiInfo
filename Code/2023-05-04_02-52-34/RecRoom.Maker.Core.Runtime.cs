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
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A43E80", Offset = "0x6A43280", VA = "0x186A43E80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x730090", Offset = "0x72F490", VA = "0x180730090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9CC120", Offset = "0x9CB520", VA = "0x1809CC120")]
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
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4D00", Offset = "0x6E4100")]
public abstract class ICJEOOBOBAL<TReceiver> : global::KKNFLHIJEBN<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x161EF90", Offset = "0x161E390", VA = "0x18161EF90")]
	public ICJEOOBOBAL(TReceiver ELFHKLDIPNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4D70", Offset = "0x6E4170")]
public abstract class HKBPNBEPANL<TReceiver, TFromTask> : global::KKNFLHIJEBN<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x161EF90", Offset = "0x161E390", VA = "0x18161EF90")]
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
	[Cpp2IlInjected.Address(RVA = "0x3399430", Offset = "0x3398830", VA = "0x183399430")]
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
	[Cpp2IlInjected.Address(RVA = "0x310EEF0", Offset = "0x310E2F0", VA = "0x18310EEF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x32F07C0", Offset = "0x32EFBC0", VA = "0x1832F07C0")]
	public HJONPEKNILN(TNode AKGPBEKMAML, ILDNIENHAGD CFJKJBLJEHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EOGIJHGIEGK<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFJBJLGDADD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3630", Offset = "0x6E2A30")] in global::GDMJCOGJHEH<TNode?> NFCKIHMENFI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NNHOJLKAFGF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E36A0", Offset = "0x6E2AA0")] in global::HJONPEKNILN<TNode?> DOAKADLOLFO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEPEIDPJIFO();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3710", Offset = "0x6E2B10")]
public class NPOJPEBONED<TNode> : global::ICJEOOBOBAL<global::EOGIJHGIEGK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x161EF90", Offset = "0x161E390", VA = "0x18161EF90")]
	public NPOJPEBONED(global::EOGIJHGIEGK<TNode> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3435480", Offset = "0x3434880", VA = "0x183435480", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3780", Offset = "0x6E2B80")]
public class NJHNCCLGIJF<TNode> : global::ICJEOOBOBAL<global::EOGIJHGIEGK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E37F0", Offset = "0x6E2BF0")]
	private readonly global::HJONPEKNILN<TNode> DOAKADLOLFO;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x349E3A0", Offset = "0x349D7A0", VA = "0x18349E3A0")]
	public NJHNCCLGIJF(TNode AKGPBEKMAML, ILDNIENHAGD CFJKJBLJEHO, global::EOGIJHGIEGK<TNode> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x349E2D0", Offset = "0x349D6D0", VA = "0x18349E2D0", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3850", Offset = "0x6E2C50")]
public class AIIAPIMHKDF<TNode> : global::ICJEOOBOBAL<global::EOGIJHGIEGK<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E38C0", Offset = "0x6E2CC0")]
	private readonly global::GDMJCOGJHEH<TNode> NFCKIHMENFI;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2BA76E0", Offset = "0x2BA6AE0", VA = "0x182BA76E0")]
	public AIIAPIMHKDF(TNode DLLHGMFDFGB, global::EOGIJHGIEGK<TNode> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x223D180", Offset = "0x223C580", VA = "0x18223D180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3116920", Offset = "0x3115D20", VA = "0x183116920")]
	public GGIACMIAHNF(IEnumerable<TData> NAIHPCNGKAD, bool LABNDPDDKCM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KBKMIAMEJAL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BFLOBLIHCNH> AFEALANIACJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3920", Offset = "0x6E2D20")] in global::GGIACMIAHNF<TData> OFFNIGNEPBP, CancellationToken OIMNLGJCBEC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3990", Offset = "0x6E2D90")]
public class PPBHDJJFJFM<TData> : global::HKBPNBEPANL<global::KBKMIAMEJAL<TData>, BFLOBLIHCNH> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3A00", Offset = "0x6E2E00")]
	private readonly global::GGIACMIAHNF<TData> GKCPPDCCHCD;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x250D130", Offset = "0x250C530", VA = "0x18250D130")]
	public PPBHDJJFJFM(IEnumerable<TData> BJOALNIEBDH, bool DIBDBGHFKKM, global::KBKMIAMEJAL<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x250D050", Offset = "0x250C450", VA = "0x18250D050", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF8D9D0", Offset = "0xF8CDD0", VA = "0x180F8D9D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3BEE330", Offset = "0x3BED730", VA = "0x183BEE330")]
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
	bool JIPFIFODDAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3A60", Offset = "0x6E2E60")] in global::EPIONKFONAB<TData> FDNOPMNLBHI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIPFIFODDAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3AD0", Offset = "0x6E2ED0")] in global::JABPJAMDLLO<TData> FDNOPMNLBHI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3B40", Offset = "0x6E2F40")]
public class NNFGJGPOOPC<TData> : global::ICJEOOBOBAL<global::BNFBGHCDCAH<TData>> where TData : notnull, KHDEPDDPLLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3BB0", Offset = "0x6E2FB0")]
	private readonly global::EPIONKFONAB<TData> FDNOPMNLBHI;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A360", Offset = "0x2D99760", VA = "0x182D9A360")]
	public NNFGJGPOOPC(List<TData> BJOALNIEBDH, bool JCEBHJLKNPN, global::BNFBGHCDCAH<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x223D180", Offset = "0x223C580", VA = "0x18223D180", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3C10", Offset = "0x6E3010")]
public class PPPMGELDKMM<TData> : global::ICJEOOBOBAL<global::BNFBGHCDCAH<TData>> where TData : notnull, KHDEPDDPLLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3C80", Offset = "0x6E3080")]
	private readonly global::JABPJAMDLLO<TData> FDNOPMNLBHI;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x250DC10", Offset = "0x250D010", VA = "0x18250DC10")]
	public PPPMGELDKMM(List<TData> BJOALNIEBDH, List<bool> PPNCFFNJLKK, global::BNFBGHCDCAH<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x250DB40", Offset = "0x250CF40", VA = "0x18250DB40", Slot = "4")]
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
	bool JIPFIFODDAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3CE0", Offset = "0x6E30E0")] in global::KBNKCINJJJI<TData?> CKBEBNMLNOM);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GBFILDLEAEG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIPFIFODDAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3D50", Offset = "0x6E3150")] in global::LJKBFBJKCKL<TData?> CKBEBNMLNOM);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface POCBLGBGFIF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PJGJHDLCGHI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3DC0", Offset = "0x6E31C0")] in global::BLKJNJLLIJI<TData?> CKBEBNMLNOM);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNHOJLKAFGF();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3E30", Offset = "0x6E3230")]
public class BFNLNNMJMAA<TData> : global::ICJEOOBOBAL<global::JPCIAFAJDIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3EA0", Offset = "0x6E32A0")]
	private readonly global::KBNKCINJJJI<TData> CKBEBNMLNOM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x223D240", Offset = "0x223C640", VA = "0x18223D240")]
	public BFNLNNMJMAA(IEnumerable<TData> BJOALNIEBDH, IAKPGHMJHAJ HAFGGBNGKBN, DPGOAOHOKGO NIFEJPCAIBK, float PHNHDEICGEC, bool DIBDBGHFKKM, global::JPCIAFAJDIC<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x223D180", Offset = "0x223C580", VA = "0x18223D180", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3F00", Offset = "0x6E3300")]
public class HKIIPPDAPNK<TData> : global::ICJEOOBOBAL<global::GBFILDLEAEG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3F70", Offset = "0x6E3370")]
	private readonly global::LJKBFBJKCKL<TData> CKBEBNMLNOM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3AA7090", Offset = "0x3AA6490", VA = "0x183AA7090")]
	public HKIIPPDAPNK(TData[] BJOALNIEBDH, IAKPGHMJHAJ[] HAFGGBNGKBN, DPGOAOHOKGO[] NIFEJPCAIBK, float[] PHNHDEICGEC, global::GBFILDLEAEG<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x33CBCD0", Offset = "0x33CB0D0", VA = "0x1833CBCD0", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3FD0", Offset = "0x6E33D0")]
public class IDKJNELGPLM<TData> : global::ICJEOOBOBAL<global::POCBLGBGFIF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x161EF90", Offset = "0x161E390", VA = "0x18161EF90")]
	public IDKJNELGPLM(global::POCBLGBGFIF<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x16227A0", Offset = "0x1621BA0", VA = "0x1816227A0", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4040", Offset = "0x6E3440")]
public class LGKFPIKCAAD<TData> : global::ICJEOOBOBAL<global::POCBLGBGFIF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E40B0", Offset = "0x6E34B0")]
	private readonly global::BLKJNJLLIJI<TData> CKBEBNMLNOM;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x33CBD90", Offset = "0x33CB190", VA = "0x1833CBD90")]
	public LGKFPIKCAAD(IEnumerable<TData> BJOALNIEBDH, IAKPGHMJHAJ HAFGGBNGKBN, DPGOAOHOKGO NIFEJPCAIBK, float PHNHDEICGEC, global::POCBLGBGFIF<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x33CBCD0", Offset = "0x33CB0D0", VA = "0x1833CBCD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3127280", Offset = "0x3126680", VA = "0x183127280")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F89490", Offset = "0x1F88890", VA = "0x181F89490")]
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
	[Cpp2IlInjected.Address(RVA = "0x20B5440", Offset = "0x20B4840", VA = "0x1820B5440")]
	public BLKJNJLLIJI(IEnumerable<TData> BJOALNIEBDH, IAKPGHMJHAJ HAFGGBNGKBN, DPGOAOHOKGO NIFEJPCAIBK, float PHNHDEICGEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KHMPFNDGHBL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDJBJGEDLFM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4110", Offset = "0x6E3510")] in global::PHIGBMKKJFC<TData> OFFNIGNEPBP);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKMIDJEBBOF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4180", Offset = "0x6E3580")] in global::PHIGBMKKJFC<TData> OFFNIGNEPBP);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PIOGICIJNHO(in bool HOHBOFEENDK);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PLKNOCMLLIP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E41F0", Offset = "0x6E35F0")] in global::PHIGBMKKJFC<TData> OFFNIGNEPBP);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LDCINIDPCGN();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EOMDHILJHAE(in TData PKIMDBNNCKC);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4260", Offset = "0x6E3660")]
public class DACGJINBPLP<TData> : global::ICJEOOBOBAL<global::KHMPFNDGHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E42D0", Offset = "0x6E36D0")]
	private readonly global::PHIGBMKKJFC<TData> OFFNIGNEPBP;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2993F30", Offset = "0x2993330", VA = "0x182993F30")]
	public DACGJINBPLP(List<TData> AABKFFENABM, global::KHMPFNDGHBL<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x223D180", Offset = "0x223C580", VA = "0x18223D180", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4330", Offset = "0x6E3730")]
public class MPPHBECMHCK<TData> : global::ICJEOOBOBAL<global::KHMPFNDGHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x161EF90", Offset = "0x161E390", VA = "0x18161EF90")]
	public MPPHBECMHCK(global::KHMPFNDGHBL<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2B2E580", Offset = "0x2B2D980", VA = "0x182B2E580", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E43A0", Offset = "0x6E37A0")]
public class DLLGGFJCDPP<TData> : global::ICJEOOBOBAL<global::KHMPFNDGHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly bool DIBDBGHFKKM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x313A4B0", Offset = "0x31398B0", VA = "0x18313A4B0")]
	public DLLGGFJCDPP(bool DIBDBGHFKKM, global::KHMPFNDGHBL<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x313A440", Offset = "0x3139840", VA = "0x18313A440", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4410", Offset = "0x6E3810")]
public class ECELFAJBPEK<TData> : global::ICJEOOBOBAL<global::KHMPFNDGHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4480", Offset = "0x6E3880")]
	private readonly global::PHIGBMKKJFC<TData> OFFNIGNEPBP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x342C170", Offset = "0x342B570", VA = "0x18342C170")]
	public ECELFAJBPEK(List<TData> AABKFFENABM, bool DIBDBGHFKKM, global::KHMPFNDGHBL<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x250DB40", Offset = "0x250CF40", VA = "0x18250DB40", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E44E0", Offset = "0x6E38E0")]
public class NMNAMHDPKFD<TData> : global::ICJEOOBOBAL<global::KHMPFNDGHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly TData PKIMDBNNCKC;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2D988B0", Offset = "0x2D97CB0", VA = "0x182D988B0")]
	public NMNAMHDPKFD(TData PKIMDBNNCKC, global::KHMPFNDGHBL<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2D98740", Offset = "0x2D97B40", VA = "0x182D98740", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4550", Offset = "0x6E3950")]
public class IBIGAKJEDIE<TData> : global::ICJEOOBOBAL<global::KHMPFNDGHBL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E45C0", Offset = "0x6E39C0")]
	private readonly global::PHIGBMKKJFC<TData> OFFNIGNEPBP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x16154E0", Offset = "0x16148E0", VA = "0x1816154E0")]
	public IBIGAKJEDIE(List<TData> AABKFFENABM, global::KHMPFNDGHBL<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1615410", Offset = "0x1614810", VA = "0x181615410", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x262F180", Offset = "0x262E580", VA = "0x18262F180")]
	public PHIGBMKKJFC(IEnumerable<TData> NAIHPCNGKAD, bool LABNDPDDKCM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface LBEHFPBPNNN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIPFIFODDAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4620", Offset = "0x6E3A20")] in global::EPGMPCOEMDO<TData?> GHCPNPGNFMB);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface CICNFJNMPGK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFJBJLGDADD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4690", Offset = "0x6E3A90")] in global::GDDHDGONAOD<TData?> CGHHKKDDEJF);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJGJHDLCGHI(in AENFKCALOCP OGOMHPLNLHP);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NNHOJLKAFGF();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4700", Offset = "0x6E3B00")]
public class CBCHKGIFGML<TData> : global::ICJEOOBOBAL<global::LBEHFPBPNNN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4770", Offset = "0x6E3B70")]
	private readonly global::EPGMPCOEMDO<TData> GHCPNPGNFMB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3668590", Offset = "0x3667990", VA = "0x183668590")]
	public CBCHKGIFGML(IEnumerable<TData> BJOALNIEBDH, Vector3 PMIMHIGKBPN, bool DIBDBGHFKKM, global::LBEHFPBPNNN<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x223D180", Offset = "0x223C580", VA = "0x18223D180", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E47D0", Offset = "0x6E3BD0")]
public class CGLAIGFJIKC<TData> : global::ICJEOOBOBAL<global::CICNFJNMPGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x161EF90", Offset = "0x161E390", VA = "0x18161EF90")]
	public CGLAIGFJIKC(global::CICNFJNMPGK<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3435480", Offset = "0x3434880", VA = "0x183435480", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4840", Offset = "0x6E3C40")]
public class CCHMJMKDFKJ<TData> : global::ICJEOOBOBAL<global::CICNFJNMPGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E48B0", Offset = "0x6E3CB0")]
	private readonly global::GDDHDGONAOD<TData> GHCPNPGNFMB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x366A270", Offset = "0x3669670", VA = "0x18366A270")]
	public CCHMJMKDFKJ(IEnumerable<TData> BJOALNIEBDH, bool DIBDBGHFKKM, global::CICNFJNMPGK<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x223D180", Offset = "0x223C580", VA = "0x18223D180", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4910", Offset = "0x6E3D10")]
public class AKBCNLDLAJN<TData> : global::ICJEOOBOBAL<global::CICNFJNMPGK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly AENFKCALOCP GHCPNPGNFMB;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8440", Offset = "0x2BA7840", VA = "0x182BA8440")]
	public AKBCNLDLAJN(Vector3 PMIMHIGKBPN, global::CICNFJNMPGK<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2BA83D0", Offset = "0x2BA77D0", VA = "0x182BA83D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF8D6F0", Offset = "0xF8CAF0", VA = "0x180F8D6F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3109F30", Offset = "0x3109330", VA = "0x183109F30")]
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
	[Cpp2IlInjected.Address(RVA = "0xC52F00", Offset = "0xC52300", VA = "0x180C52F00")]
	public AENFKCALOCP(Vector3 PMIMHIGKBPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface OLEBHDOLMHN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIPFIFODDAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4980", Offset = "0x6E3D80")] in global::GPKGHNAABIG<TData?> MIJEOENENPF);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface EHMINGCEDEI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFJBJLGDADD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E49F0", Offset = "0x6E3DF0")] in global::PHLLLCLJJJJ<TData?> NFCKIHMENFI);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJGJHDLCGHI(in PGMDDAMHPLD OGOMHPLNLHP);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NNHOJLKAFGF();
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4A60", Offset = "0x6E3E60")]
public class DCCJNPFOLAH<TData> : global::ICJEOOBOBAL<global::OLEBHDOLMHN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4AD0", Offset = "0x6E3ED0")]
	private readonly global::GPKGHNAABIG<TData> MIJEOENENPF;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x299B0A0", Offset = "0x299A4A0", VA = "0x18299B0A0")]
	public DCCJNPFOLAH(IEnumerable<TData> BJOALNIEBDH, Quaternion PMIMHIGKBPN, Vector3? CAEAHKDOOLP, bool AAHMOIHAKME, bool DIBDBGHFKKM, global::OLEBHDOLMHN<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x223D180", Offset = "0x223C580", VA = "0x18223D180", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4B30", Offset = "0x6E3F30")]
public class EDEFEEADNEA<TData> : global::ICJEOOBOBAL<global::EHMINGCEDEI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x161EF90", Offset = "0x161E390", VA = "0x18161EF90")]
	public EDEFEEADNEA(global::EHMINGCEDEI<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3435480", Offset = "0x3434880", VA = "0x183435480", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4BA0", Offset = "0x6E3FA0")]
public class OBHJJCCAGBG<TData> : global::ICJEOOBOBAL<global::EHMINGCEDEI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4C10", Offset = "0x6E4010")]
	private readonly global::PHLLLCLJJJJ<TData> MIJEOENENPF;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8490", Offset = "0x2CA7890", VA = "0x182CA8490")]
	public OBHJJCCAGBG(IEnumerable<TData> BJOALNIEBDH, bool DIBDBGHFKKM, global::EHMINGCEDEI<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x223D180", Offset = "0x223C580", VA = "0x18223D180", Slot = "4")]
	public override bool JIPFIFODDAL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4C70", Offset = "0x6E4070")]
public class DNIMEKDJPLJ<TData> : global::ICJEOOBOBAL<global::EHMINGCEDEI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly PGMDDAMHPLD MIJEOENENPF;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3141AF0", Offset = "0x3140EF0", VA = "0x183141AF0")]
	public DNIMEKDJPLJ(Quaternion PMIMHIGKBPN, Vector3? CAEAHKDOOLP, bool AAHMOIHAKME, global::EHMINGCEDEI<TData> ELFHKLDIPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2BA83D0", Offset = "0x2BA77D0", VA = "0x182BA83D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E9EFD0", Offset = "0x2E9E3D0", VA = "0x182E9EFD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2630FC0", Offset = "0x26303C0", VA = "0x182630FC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5C85160", Offset = "0x5C84560", VA = "0x185C85160")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A43AE0", Offset = "0x6A42EE0", VA = "0x186A43AE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6A43A10", Offset = "0x6A42E10", VA = "0x186A43A10")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static CancellationToken GHJHAKAKGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6A43B70", Offset = "0x6A42F70", VA = "0x186A43B70")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A43A60", Offset = "0x6A42E60", VA = "0x186A43A60")]
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
	[Cpp2IlInjected.Address(RVA = "0x24361F0", Offset = "0x24355F0", VA = "0x1824361F0")]
	public static void IABDEIIHAPA<T>(T MLLKBCFLFJE, EEJKCIAIPLD OGILDIMGIOH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2436170", Offset = "0x2435570", VA = "0x182436170")]
	public static void IABDEIIHAPA<T>(T MLLKBCFLFJE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2436390", Offset = "0x2435790", VA = "0x182436390")]
	public static T MKLBNKEKMJE<T>(EEJKCIAIPLD OGILDIMGIOH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2436430", Offset = "0x2435830", VA = "0x182436430")]
	public static T MKLBNKEKMJE<T>() where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class HGEMEOLEOEJ
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6A43C10", Offset = "0x6A43010", VA = "0x186A43C10")]
	public static void KGAMOAPJPHC(IEnumerable GPBFFBAAOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x29FBF60", Offset = "0x29FB360", VA = "0x1829FBF60")]
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
