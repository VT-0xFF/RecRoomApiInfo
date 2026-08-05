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
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E76C80", Offset = "0x1E75680", VA = "0x181E76C80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x847190", Offset = "0x845B90", VA = "0x180847190")]
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
		[Cpp2IlInjected.Address(RVA = "0x143BBF0", Offset = "0x143A5F0", VA = "0x18143BBF0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IBOIDEIAPAG<TData> : HHEEEGLKDKG, global::MHDOJJNKFPL<TData>, global::DFLNGJKDCDA<TData>, global::LLIDINDPNJP<TData>, global::LOPILBNLPNJ<TData>, MGJJFDFCBDF
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LOPILBNLPNJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 OCNOPGJFBCJ, Vector3 GNIANLFIOCO, float AGKAIFMKLLP, out T GHBLEKFOMJG, out Vector3 NFIGADANKFB, out Collider GDHALFKGBEP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 OCNOPGJFBCJ, Vector3 GNIANLFIOCO, float MLCGOBAANGM, float AGKAIFMKLLP, T[] APHMADHKOPP, out Vector3 FPHMHMFIPPG, out Collider AFMBLKJBIJD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 OCNOPGJFBCJ, float MLCGOBAANGM, Vector3 GOLGHCOFDED, T[] APHMADHKOPP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HHEEEGLKDKG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds AFLIOCBNEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform DNPOIKBIFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds ONNBKMIMJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform CHAJPGOAOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 FONDAMLDJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LLIDINDPNJP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HNHIDNLIKHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int IGGENMNNMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<TData> KPGCMBOLIJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool INDBIJMHFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LEHDEBDCJGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData FPEJLKINELB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData FPEJLKINELB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MHDOJJNKFPL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T OMHIFHKMIMJ, [Optional] IIFCEINCIPN? BLBGFDOJDFM, bool LOBMDPGOPNI = true);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int HGMGPFAJPJI, IEnumerable<T> PJLNFOKAGGK, bool LOBMDPGOPNI = true);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int HGMGPFAJPJI, IEnumerable<T> PJLNFOKAGGK, IIFCEINCIPN BLBGFDOJDFM, bool LOBMDPGOPNI = true);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MGJJFDFCBDF
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xEA250", Offset = "0xE9650")]
public abstract class BLKACCPBIFA<TReceiver> : global::EOCJPDHBLCD<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3283460", Offset = "0x3281E60", VA = "0x183283460")]
	public BLKACCPBIFA(TReceiver LFFLKCJEJDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xEA2C0", Offset = "0xE96C0")]
public abstract class CNFGPKBGCPP<TReceiver, TFromTask> : global::EOCJPDHBLCD<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3283460", Offset = "0x3281E60", VA = "0x183283460")]
	public CNFGPKBGCPP(TReceiver LFFLKCJEJDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class EOCJPDHBLCD<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver LFFLKCJEJDN;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3160630", Offset = "0x315F030", VA = "0x183160630")]
	public EOCJPDHBLCD(TReceiver LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute JJCDHEEDCJG();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LCDIKKCJAEN<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TNode LHFAAHHPDJI;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2A07830", Offset = "0x2A06230", VA = "0x182A07830")]
	public LCDIKKCJAEN(TNode LHFAAHHPDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct MIEDCDNKFME<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TNode FCENOJPMBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public PNHKOFPFMHG IBAIJKGABPA;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3AD4A60", Offset = "0x3AD3460", VA = "0x183AD4A60")]
	public MIEDCDNKFME(TNode FCENOJPMBDI, PNHKOFPFMHG IBAIJKGABPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JJIEKOJBLND<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJMCLEHLNIA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE8B30", Offset = "0xE7F30")] in global::LCDIKKCJAEN<TNode?> IDHPNAJPIIL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FJGHNKGDCND([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE8BA0", Offset = "0xE7FA0")] in global::MIEDCDNKFME<TNode?> BILOPDOOPNA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool INEEFAJOINJ();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE8C10", Offset = "0xE8010")]
public class PDOHFMACMAN<TNode> : global::BLKACCPBIFA<global::JJIEKOJBLND<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3283460", Offset = "0x3281E60", VA = "0x183283460")]
	public PDOHFMACMAN(global::JJIEKOJBLND<TNode> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3B89810", Offset = "0x3B88210", VA = "0x183B89810", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE8C80", Offset = "0xE8080")]
public class DLIDDGDGAKA<TNode> : global::BLKACCPBIFA<global::JJIEKOJBLND<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE8CF0", Offset = "0xE80F0")]
	private readonly global::MIEDCDNKFME<TNode> BILOPDOOPNA;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3B873F0", Offset = "0x3B85DF0", VA = "0x183B873F0")]
	public DLIDDGDGAKA(TNode FCENOJPMBDI, PNHKOFPFMHG IBAIJKGABPA, global::JJIEKOJBLND<TNode> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3B87320", Offset = "0x3B85D20", VA = "0x183B87320", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE8D50", Offset = "0xE8150")]
public class MGHMBAPPIMG<TNode> : global::BLKACCPBIFA<global::JJIEKOJBLND<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE8DC0", Offset = "0xE81C0")]
	private readonly global::LCDIKKCJAEN<TNode> IDHPNAJPIIL;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6CB0", Offset = "0x4EA56B0", VA = "0x184EA6CB0")]
	public MGHMBAPPIMG(TNode AAHFAMCFOMI, global::JJIEKOJBLND<TNode> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3611FE0", Offset = "0x36109E0", VA = "0x183611FE0", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct NNBIFEODAKG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public IEnumerable<TData> BKNOJPOGCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool LKAOCJPAMEL;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x32866E0", Offset = "0x32850E0", VA = "0x1832866E0")]
	public NNBIFEODAKG(IEnumerable<TData> ENDNMLCFFIF, bool GOLCNIBGDIF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface DCBJNBADLLI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LLDGHDBANCC> NLEJHNJDKKN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE8E20", Offset = "0xE8220")] in global::NNBIFEODAKG<TData> GEFOODCMHCN, CancellationToken FAPLHFKLMOL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE8E90", Offset = "0xE8290")]
public class GPBCCIICLIB<TData> : global::CNFGPKBGCPP<global::DCBJNBADLLI<TData>, LLDGHDBANCC> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE8F00", Offset = "0xE8300")]
	private readonly global::NNBIFEODAKG<TData> CNKAMIBDFGO;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x494D610", Offset = "0x494C010", VA = "0x18494D610")]
	public GPBCCIICLIB(IEnumerable<TData> EBADNMAAKAL, bool LKAOCJPAMEL, global::DCBJNBADLLI<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x494D530", Offset = "0x494BF30", VA = "0x18494D530", Slot = "4")]
	public override Task<LLDGHDBANCC> JJCDHEEDCJG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FIFBJIFAIMF<TData> where TData : notnull, FGEGBBOMLIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public IEnumerable<TData> BKNOJPOGCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool HFPIAFJAJJC;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4E49990", Offset = "0x4E48390", VA = "0x184E49990")]
	public FIFBJIFAIMF(IEnumerable<TData> ENDNMLCFFIF, bool CCMKAFAIJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HENCNJMBDEG<TData> where TData : notnull, FGEGBBOMLIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public List<TData> BKNOJPOGCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public List<bool> IOPBNOEICID;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4556C60", Offset = "0x4555660", VA = "0x184556C60")]
	public HENCNJMBDEG(List<TData> ENDNMLCFFIF, List<bool> PODNIEMPOIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FGEGBBOMLIN
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NGOGBDCLAHM
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
public interface CJFEJHJDHGN<TData> where TData : FGEGBBOMLIN
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JJCDHEEDCJG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE8F60", Offset = "0xE8360")] in global::FIFBJIFAIMF<TData> KOANHGEGLMM);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJCDHEEDCJG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE8FD0", Offset = "0xE83D0")] in global::HENCNJMBDEG<TData> KOANHGEGLMM);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9040", Offset = "0xE8440")]
public class CKGOEGHHJDJ<TData> : global::BLKACCPBIFA<global::CJFEJHJDHGN<TData>> where TData : notnull, FGEGBBOMLIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE90B0", Offset = "0xE84B0")]
	private readonly global::FIFBJIFAIMF<TData> KOANHGEGLMM;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x39B0BA0", Offset = "0x39AF5A0", VA = "0x1839B0BA0")]
	public CKGOEGHHJDJ(List<TData> EBADNMAAKAL, bool HFPIAFJAJJC, global::CJFEJHJDHGN<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3611FE0", Offset = "0x36109E0", VA = "0x183611FE0", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9110", Offset = "0xE8510")]
public class GDLFBBAGJFG<TData> : global::BLKACCPBIFA<global::CJFEJHJDHGN<TData>> where TData : notnull, FGEGBBOMLIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9180", Offset = "0xE8580")]
	private readonly global::HENCNJMBDEG<TData> KOANHGEGLMM;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x410BF90", Offset = "0x410A990", VA = "0x18410BF90")]
	public GDLFBBAGJFG(List<TData> EBADNMAAKAL, List<bool> IOPBNOEICID, global::CJFEJHJDHGN<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x410BEC0", Offset = "0x410A8C0", VA = "0x18410BEC0", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface HPKJNKLFPPA : FGEGBBOMLIN
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GJBBAPNKDBA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JJCDHEEDCJG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE91E0", Offset = "0xE85E0")] in global::PGBLIPKECJN<TData?> CGLFOMMFKCG);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DBNBPLHDNPA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJCDHEEDCJG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9250", Offset = "0xE8650")] in global::LOHCALAHNAI<TData?> CGLFOMMFKCG);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NDLPIKAGLMK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDHDFDAHFIN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE92C0", Offset = "0xE86C0")] in global::DEFEJLGGHHK<TData?> CGLFOMMFKCG);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJGHNKGDCND();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9330", Offset = "0xE8730")]
public class FLGECKLNGFI<TData> : global::BLKACCPBIFA<global::GJBBAPNKDBA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE93A0", Offset = "0xE87A0")]
	private readonly global::PGBLIPKECJN<TData> CGLFOMMFKCG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x36120A0", Offset = "0x3610AA0", VA = "0x1836120A0")]
	public FLGECKLNGFI(IEnumerable<TData> EBADNMAAKAL, EHJKHDJIHDA CPPINAHFMCO, AOKPFLMHALA NCNMCMAJCOL, float MCMDGJOGCAI, bool LKAOCJPAMEL, global::GJBBAPNKDBA<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3611FE0", Offset = "0x36109E0", VA = "0x183611FE0", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9400", Offset = "0xE8800")]
public class NLPDLOIFOME<TData> : global::BLKACCPBIFA<global::DBNBPLHDNPA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9470", Offset = "0xE8870")]
	private readonly global::LOHCALAHNAI<TData> CGLFOMMFKCG;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3280E00", Offset = "0x327F800", VA = "0x183280E00")]
	public NLPDLOIFOME(TData[] EBADNMAAKAL, EHJKHDJIHDA[] CPPINAHFMCO, AOKPFLMHALA[] NCNMCMAJCOL, float[] MCMDGJOGCAI, global::DBNBPLHDNPA<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3280C70", Offset = "0x327F670", VA = "0x183280C70", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE94D0", Offset = "0xE88D0")]
public class HBIPGLHBCEM<TData> : global::BLKACCPBIFA<global::NDLPIKAGLMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3283460", Offset = "0x3281E60", VA = "0x183283460")]
	public HBIPGLHBCEM(global::NDLPIKAGLMK<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4ABCF90", Offset = "0x4ABB990", VA = "0x184ABCF90", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9540", Offset = "0xE8940")]
public class JAFNEIGFFKH<TData> : global::BLKACCPBIFA<global::NDLPIKAGLMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE95B0", Offset = "0xE89B0")]
	private readonly global::DEFEJLGGHHK<TData> CGLFOMMFKCG;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4070F30", Offset = "0x406F930", VA = "0x184070F30")]
	public JAFNEIGFFKH(IEnumerable<TData> EBADNMAAKAL, EHJKHDJIHDA CPPINAHFMCO, AOKPFLMHALA NCNMCMAJCOL, float MCMDGJOGCAI, global::NDLPIKAGLMK<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3280C70", Offset = "0x327F670", VA = "0x183280C70", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct PGBLIPKECJN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> BKNOJPOGCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EHJKHDJIHDA BGBMACABLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public AOKPFLMHALA KMJECKDHOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float MCMDGJOGCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool LKAOCJPAMEL;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x43CEDA0", Offset = "0x43CD7A0", VA = "0x1843CEDA0")]
	public PGBLIPKECJN(IEnumerable<TData> EBADNMAAKAL, EHJKHDJIHDA CPPINAHFMCO, AOKPFLMHALA NCNMCMAJCOL, float MCMDGJOGCAI, bool LKAOCJPAMEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct LOHCALAHNAI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public TData[] BKNOJPOGCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EHJKHDJIHDA[] BGBMACABLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public AOKPFLMHALA[] KMJECKDHOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float[] MCMDGJOGCAI;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x44B4DB0", Offset = "0x44B37B0", VA = "0x1844B4DB0")]
	public LOHCALAHNAI(TData[] EBADNMAAKAL, EHJKHDJIHDA[] CPPINAHFMCO, AOKPFLMHALA[] NCNMCMAJCOL, float[] MCMDGJOGCAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct DEFEJLGGHHK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public IEnumerable<TData> BKNOJPOGCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EHJKHDJIHDA BGBMACABLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public AOKPFLMHALA KMJECKDHOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public float MCMDGJOGCAI;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x436B060", Offset = "0x4369A60", VA = "0x18436B060")]
	public DEFEJLGGHHK(IEnumerable<TData> EBADNMAAKAL, EHJKHDJIHDA CPPINAHFMCO, AOKPFLMHALA NCNMCMAJCOL, float MCMDGJOGCAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface DFLNGJKDCDA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FICNGAJIAOI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9610", Offset = "0xE8A10")] in global::JPLGDFIAONO<TData> GEFOODCMHCN);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFMEKBBPDBM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9680", Offset = "0xE8A80")] in global::JPLGDFIAONO<TData> GEFOODCMHCN);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBOFELLFCDK(in bool EHDHJHLBDBK);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CAHBONLLELA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE96F0", Offset = "0xE8AF0")] in global::JPLGDFIAONO<TData> GEFOODCMHCN);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DBPJGBKGEPF();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DKIIOJPIIHN(in TData JPPBKBLKJCH);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9760", Offset = "0xE8B60")]
public class AKGIPADDCNG<TData> : global::BLKACCPBIFA<global::DFLNGJKDCDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE97D0", Offset = "0xE8BD0")]
	private readonly global::JPLGDFIAONO<TData> GEFOODCMHCN;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3CA7430", Offset = "0x3CA5E30", VA = "0x183CA7430")]
	public AKGIPADDCNG(List<TData> FGILJLADPAP, global::DFLNGJKDCDA<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3611FE0", Offset = "0x36109E0", VA = "0x183611FE0", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9830", Offset = "0xE8C30")]
public class CJMAELMPGDK<TData> : global::BLKACCPBIFA<global::DFLNGJKDCDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3283460", Offset = "0x3281E60", VA = "0x183283460")]
	public CJMAELMPGDK(global::DFLNGJKDCDA<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4538AA0", Offset = "0x45374A0", VA = "0x184538AA0", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE98A0", Offset = "0xE8CA0")]
public class IFGGKNHKDCE<TData> : global::BLKACCPBIFA<global::DFLNGJKDCDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly bool LKAOCJPAMEL;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x36DEDA0", Offset = "0x36DD7A0", VA = "0x1836DEDA0")]
	public IFGGKNHKDCE(bool LKAOCJPAMEL, global::DFLNGJKDCDA<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x36DED30", Offset = "0x36DD730", VA = "0x1836DED30", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9910", Offset = "0xE8D10")]
public class GADDAMEHIFG<TData> : global::BLKACCPBIFA<global::DFLNGJKDCDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9980", Offset = "0xE8D80")]
	private readonly global::JPLGDFIAONO<TData> GEFOODCMHCN;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4CC7640", Offset = "0x4CC6040", VA = "0x184CC7640")]
	public GADDAMEHIFG(List<TData> FGILJLADPAP, bool LKAOCJPAMEL, global::DFLNGJKDCDA<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x410BEC0", Offset = "0x410A8C0", VA = "0x18410BEC0", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE99E0", Offset = "0xE8DE0")]
public class GIIMAOMBLHH<TData> : global::BLKACCPBIFA<global::DFLNGJKDCDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly TData JPPBKBLKJCH;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3FE43E0", Offset = "0x3FE2DE0", VA = "0x183FE43E0")]
	public GIIMAOMBLHH(TData JPPBKBLKJCH, global::DFLNGJKDCDA<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3FE4310", Offset = "0x3FE2D10", VA = "0x183FE4310", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9A50", Offset = "0xE8E50")]
public class MEDDFGHHGJF<TData> : global::BLKACCPBIFA<global::DFLNGJKDCDA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9AC0", Offset = "0xE8EC0")]
	private readonly global::JPLGDFIAONO<TData> GEFOODCMHCN;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x468B0D0", Offset = "0x4689AD0", VA = "0x18468B0D0")]
	public MEDDFGHHGJF(List<TData> FGILJLADPAP, global::DFLNGJKDCDA<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x468AF70", Offset = "0x4689970", VA = "0x18468AF70", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct JPLGDFIAONO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public IEnumerable<TData> BKNOJPOGCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool LKAOCJPAMEL;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3758040", Offset = "0x3756A40", VA = "0x183758040")]
	public JPLGDFIAONO(IEnumerable<TData> ENDNMLCFFIF, bool GOLCNIBGDIF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface AAEPMKCHHFB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JJCDHEEDCJG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9B20", Offset = "0xE8F20")] in global::JOPNPEJFHMO<TData?> COIDPIANEAD);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface AHNDDLNDPJF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJMCLEHLNIA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9B90", Offset = "0xE8F90")] in global::OEJFHMOBHGL<TData?> FJJMKKINHPH);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KDHDFDAHFIN(in FAELHAGGNDD PJOADOPKBHF);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FJGHNKGDCND();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9C00", Offset = "0xE9000")]
public class OPKKHPOEPGH<TData> : global::BLKACCPBIFA<global::AAEPMKCHHFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9C70", Offset = "0xE9070")]
	private readonly global::JOPNPEJFHMO<TData> COIDPIANEAD;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3B44B00", Offset = "0x3B43500", VA = "0x183B44B00")]
	public OPKKHPOEPGH(IEnumerable<TData> EBADNMAAKAL, Vector3 CEEPJJOBLOD, bool LKAOCJPAMEL, global::AAEPMKCHHFB<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3611FE0", Offset = "0x36109E0", VA = "0x183611FE0", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9CD0", Offset = "0xE90D0")]
public class OKFJFILCECL<TData> : global::BLKACCPBIFA<global::AHNDDLNDPJF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3283460", Offset = "0x3281E60", VA = "0x183283460")]
	public OKFJFILCECL(global::AHNDDLNDPJF<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3B89810", Offset = "0x3B88210", VA = "0x183B89810", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9D40", Offset = "0xE9140")]
public class JCGLBEMLFMO<TData> : global::BLKACCPBIFA<global::AHNDDLNDPJF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9DB0", Offset = "0xE91B0")]
	private readonly global::OEJFHMOBHGL<TData> COIDPIANEAD;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x40771F0", Offset = "0x4075BF0", VA = "0x1840771F0")]
	public JCGLBEMLFMO(IEnumerable<TData> EBADNMAAKAL, bool LKAOCJPAMEL, global::AHNDDLNDPJF<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3611FE0", Offset = "0x36109E0", VA = "0x183611FE0", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9E10", Offset = "0xE9210")]
public class AABOOIBOOKM<TData> : global::BLKACCPBIFA<global::AHNDDLNDPJF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly FAELHAGGNDD COIDPIANEAD;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x44FFFE0", Offset = "0x44FE9E0", VA = "0x1844FFFE0")]
	public AABOOIBOOKM(Vector3 CEEPJJOBLOD, global::AHNDDLNDPJF<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2A03BD0", Offset = "0x2A025D0", VA = "0x182A03BD0", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct JOPNPEJFHMO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly IEnumerable<TData> EBADNMAAKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly Vector3 CEEPJJOBLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool LKAOCJPAMEL;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3756210", Offset = "0x3754C10", VA = "0x183756210")]
	public JOPNPEJFHMO(IEnumerable<TData> EBADNMAAKAL, Vector3 CEEPJJOBLOD, bool LKAOCJPAMEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct OEJFHMOBHGL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly IEnumerable<TData> EBADNMAAKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool LKAOCJPAMEL;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2420", Offset = "0x3ED0E20", VA = "0x183ED2420")]
	public OEJFHMOBHGL(IEnumerable<TData> EBADNMAAKAL, bool LKAOCJPAMEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FAELHAGGNDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly Vector3 CEEPJJOBLOD;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8BB090", Offset = "0x8B9A90", VA = "0x1808BB090")]
	public FAELHAGGNDD(Vector3 CEEPJJOBLOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface ADAJIEFANON<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JJCDHEEDCJG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9E80", Offset = "0xE9280")] in global::CDOLHMLAGCJ<TData?> LHAEDACIBEP);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface HKAJOHNMHGO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJMCLEHLNIA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9EF0", Offset = "0xE92F0")] in global::DJNCKOOGHDO<TData?> IDHPNAJPIIL);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KDHDFDAHFIN(in POPBCEODPBH PJOADOPKBHF);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FJGHNKGDCND();
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9F60", Offset = "0xE9360")]
public class PGGKGJJAEGN<TData> : global::BLKACCPBIFA<global::ADAJIEFANON<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xE9FD0", Offset = "0xE93D0")]
	private readonly global::CDOLHMLAGCJ<TData> LHAEDACIBEP;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x43CEEB0", Offset = "0x43CD8B0", VA = "0x1843CEEB0")]
	public PGGKGJJAEGN(IEnumerable<TData> EBADNMAAKAL, Quaternion CEEPJJOBLOD, Vector3? CODAPPPINLD, bool LEOGNMONGAA, bool LKAOCJPAMEL, global::ADAJIEFANON<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3611FE0", Offset = "0x36109E0", VA = "0x183611FE0", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xEA030", Offset = "0xE9430")]
public class DMKJBLJMNFD<TData> : global::BLKACCPBIFA<global::HKAJOHNMHGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3283460", Offset = "0x3281E60", VA = "0x183283460")]
	public DMKJBLJMNFD(global::HKAJOHNMHGO<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3B89810", Offset = "0x3B88210", VA = "0x183B89810", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xEA0A0", Offset = "0xE94A0")]
public class JBDCCMKMMKF<TData> : global::BLKACCPBIFA<global::HKAJOHNMHGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xEA110", Offset = "0xE9510")]
	private readonly global::DJNCKOOGHDO<TData> LHAEDACIBEP;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x40718C0", Offset = "0x40702C0", VA = "0x1840718C0")]
	public JBDCCMKMMKF(IEnumerable<TData> EBADNMAAKAL, bool LKAOCJPAMEL, global::HKAJOHNMHGO<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3611FE0", Offset = "0x36109E0", VA = "0x183611FE0", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xEA170", Offset = "0xE9570")]
public class LBKMPFBDHEN<TData> : global::BLKACCPBIFA<global::HKAJOHNMHGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly POPBCEODPBH LHAEDACIBEP;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2A03C40", Offset = "0x2A02640", VA = "0x182A03C40")]
	public LBKMPFBDHEN(Quaternion CEEPJJOBLOD, Vector3? CODAPPPINLD, bool LEOGNMONGAA, global::HKAJOHNMHGO<TData> LFFLKCJEJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2A03BD0", Offset = "0x2A025D0", VA = "0x182A03BD0", Slot = "4")]
	public override bool JJCDHEEDCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct CDOLHMLAGCJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IEnumerable<TData> EBADNMAAKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly Quaternion CEEPJJOBLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly Vector3? CODAPPPINLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly bool LEOGNMONGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool LKAOCJPAMEL;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x41A1BB0", Offset = "0x41A05B0", VA = "0x1841A1BB0")]
	public CDOLHMLAGCJ(IEnumerable<TData> EBADNMAAKAL, Quaternion CEEPJJOBLOD, Vector3? CODAPPPINLD, bool LEOGNMONGAA, bool LKAOCJPAMEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct DJNCKOOGHDO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly IEnumerable<TData> EBADNMAAKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool LKAOCJPAMEL;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3B82120", Offset = "0x3B80B20", VA = "0x183B82120")]
	public DJNCKOOGHDO(IEnumerable<TData> EBADNMAAKAL, bool LKAOCJPAMEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct POPBCEODPBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly Quaternion CEEPJJOBLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly Vector3? CODAPPPINLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly bool LEOGNMONGAA;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1E76D10", Offset = "0x1E75710", VA = "0x181E76D10")]
	public POPBCEODPBH(Quaternion CEEPJJOBLOD, Vector3? CODAPPPINLD, bool LEOGNMONGAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class IOPOOOGPCEF
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static DPALDOJEBJE? KAGLBLKFNPG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal static DPALDOJEBJE KFFFHLBOMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1E76BF0", Offset = "0x1E755F0", VA = "0x181E76BF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1E76A80", Offset = "0x1E75480", VA = "0x181E76A80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static CancellationToken DNNJGKNAPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1E76B50", Offset = "0x1E75550", VA = "0x181E76B50")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1E76AD0", Offset = "0x1E754D0", VA = "0x181E76AD0")]
	[MBJLKJLIAAH(JLEIDHHFJDB.Room, JDACKNHLALI.None)]
	private static void FKMBOKDLDNI(DPALDOJEBJE EAOHGBIKKPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class GLNPFEMDJEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum GDJMMJKPKGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x30DA150", Offset = "0x30D8B50", VA = "0x1830DA150")]
	public static void OBHGAGNHGOK<T>(T JCJDNADEMKM, GDJMMJKPKGL EMKINACMDLO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x30DA2F0", Offset = "0x30D8CF0", VA = "0x1830DA2F0")]
	public static void OBHGAGNHGOK<T>(T JCJDNADEMKM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x30DA0B0", Offset = "0x30D8AB0", VA = "0x1830DA0B0")]
	public static T ABMJNALEGDK<T>(GDJMMJKPKGL EMKINACMDLO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x30DA070", Offset = "0x30D8A70", VA = "0x1830DA070")]
	public static T ABMJNALEGDK<T>() where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class IGBAOEJONOL
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1E76810", Offset = "0x1E75210", VA = "0x181E76810")]
	public static void NEHPAIOJFIB(IEnumerable GJJDBCFJNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3460E60", Offset = "0x345F860", VA = "0x183460E60")]
	public static void NEHPAIOJFIB<T>(T[] HPOICFFOIAP) where T : notnull
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
