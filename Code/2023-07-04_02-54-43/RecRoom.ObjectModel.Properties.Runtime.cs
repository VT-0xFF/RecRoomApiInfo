using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
public interface BIEPOFHIHEI : IEnumerable<PKJHJMAHAIO>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PKJHJMAHAIO : AJDIOEGOOJG<Entity>, NBIFMCDOFDB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DHJOLBGJFBM<T> : MFDDLGLKMCP<Entity, T>, AJDIOEGOOJG<Entity>, NBIFMCDOFDB, IDisposable, PKJHJMAHAIO where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface EDBGKPBAHIB : PKJHJMAHAIO, AJDIOEGOOJG<Entity>, NBIFMCDOFDB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	new int HMJKGAFBEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CMNNLDAOAJA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x16AA780", Offset = "0x16A8D80", VA = "0x1816AA780")]
	public static T MCHBAPBDDIO<T>(this DHJOLBGJFBM<T> OMEMEFEKGAP, Entity PEKCJMKIHGK, [Optional] T LLDPFOJMFMC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x16AA8E0", Offset = "0x16A8EE0", VA = "0x1816AA8E0")]
	public static T ODJMIGNPKED<T>(this AJDIOEGOOJG<Entity> OMEMEFEKGAP, Entity PEKCJMKIHGK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x16AA5F0", Offset = "0x16A8BF0", VA = "0x1816AA5F0")]
	public static bool BHPLEEDKOEH<T>(this AJDIOEGOOJG<Entity> OMEMEFEKGAP, Entity PEKCJMKIHGK, in T ABBAPCAIMDJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NKNEAONODKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int ECJBDNEAOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int DABLBPLHFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Type IMMFPADKGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	PKJHJMAHAIO[] KHJAKIBCAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) FPHMOFKIKCK(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ANNIJOIHIAC(Entity PEKCJMKIHGK, (uint order, uint change) BOBBHCFAPPK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class NFHBPGBJLBJ : EDBGKPBAHIB, PKJHJMAHAIO, AJDIOEGOOJG<Entity>, NBIFMCDOFDB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type KBBBDODNMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract NKNEAONODKJ KLDGEIJFAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract KGIOGKMMCDC MBHEELLGHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string NHAFHGAJCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x920EA0", Offset = "0x91F4A0", VA = "0x180920EA0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HMJKGAFBEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9B80A0", Offset = "0x9B66A0", VA = "0x1809B80A0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD60", Offset = "0xA3B360", VA = "0x180A3CD60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event LLHEJLILDGA<Entity> AOHLCMGPNCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7268780", Offset = "0x7266D80", VA = "0x187268780", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72686E0", Offset = "0x7266CE0", VA = "0x1872686E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool PFAIEHOFDHF(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool HFFEKHNIFMP(Entity PEKCJMKIHGK, in object ABBAPCAIMDJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void PIDCPOPDLLJ(Entity PEKCJMKIHGK, in FOLHPMBKIGD FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool PCICHOODFHC(Entity PEKCJMKIHGK, in IGCFDMLBPPM ABBAPCAIMDJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract bool IOAKBHBLOJG(Entity NAJDAPHOGEH, in IGCFDMLBPPM ABBAPCAIMDJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void DPEBGIDOBOG(PECLEJOEEND EPGFAAAAECD, [Optional] object JHAKINLMMJL);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract bool JOKLDHADBPL(Entity PBFCNGOCEEJ, Entity FDDHIMHLJAI);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	public abstract void KGHKJOCLFMF(EntityManager BJBBKAHIPJF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2717350", Offset = "0x2715950", VA = "0x182717350")]
	protected void NEPBBGPPDKL<T>(Entity PEKCJMKIHGK, in T BGBLNMDAKNB, in T ABBAPCAIMDJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	public abstract string JGOFLMDGPDI(in IGCFDMLBPPM EBELHNPCIOG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	protected NFHBPGBJLBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class FPKIHONPOPN<T> : NFHBPGBJLBJ, DHJOLBGJFBM<T>, MFDDLGLKMCP<Entity, T>, AJDIOEGOOJG<Entity>, NBIFMCDOFDB, IDisposable, PKJHJMAHAIO, KGIOGKMMCDC where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate bool MNOBMMBLHED(Entity PEKCJMKIHGK, in T ABBAPCAIMDJ);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void JAPNFLOPDMM(Entity PEKCJMKIHGK, in T BGBLNMDAKNB, in T ABBAPCAIMDJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NKNEAONODKJ LIKCDKHGNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo JJPCONIBGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int BODNDJCNKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int BIKMMIGFKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int BMEHIBKNEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private MNOBMMBLHED IIBJJCGFFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private JAPNFLOPDMM JFFDEPBMBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private JAPNFLOPDMM ECBKCALJKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World MDGIABLFKGC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override Type KBBBDODNMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B626C0", Offset = "0x2B60CC0", VA = "0x182B626C0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override NKNEAONODKJ KLDGEIJFAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86F230", Offset = "0x86D830", VA = "0x18086F230", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override KGIOGKMMCDC MBHEELLGHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FieldInfo IGBMKKPOAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private int BMOADBBCHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x942BC0", Offset = "0x9411C0", VA = "0x180942BC0", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int MAJIDNOAGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA75460", Offset = "0xA73A60", VA = "0x180A75460", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EntityManager IKKIOEAOHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B64B30", Offset = "0x2B63130", VA = "0x182B64B30")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B696F0", Offset = "0x2B67CF0", VA = "0x182B696F0")]
	public FPKIHONPOPN(string HNPIEGONNBC, NKNEAONODKJ LIKCDKHGNEB, FieldInfo JJPCONIBGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B64B00", Offset = "0x2B63100", VA = "0x182B64B00", Slot = "33")]
	public override void KGHKJOCLFMF(EntityManager BJBBKAHIPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2B62BC0", Offset = "0x2B611C0", VA = "0x182B62BC0")]
	public FPKIHONPOPN<T> ELEPHJFLBDC(MNOBMMBLHED IIBJJCGFFKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B62340", Offset = "0x2B60940", VA = "0x182B62340")]
	public FPKIHONPOPN<T> APBLDKIHGNF(JAPNFLOPDMM JFFDEPBMBHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2B62B40", Offset = "0x2B61140", VA = "0x182B62B40")]
	public FPKIHONPOPN<T> CALCGFGDMOG(JAPNFLOPDMM ECBKCALJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2B69010", Offset = "0x2B67610", VA = "0x182B69010", Slot = "35")]
	public T PIDCPOPDLLJ(Entity PEKCJMKIHGK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2B673E0", Offset = "0x2B659E0", VA = "0x182B673E0")]
	public bool PCICHOODFHC(Entity PEKCJMKIHGK, in T ABBAPCAIMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2B633B0", Offset = "0x2B619B0", VA = "0x182B633B0")]
	public bool IOAKBHBLOJG(Entity PEKCJMKIHGK, in T ABBAPCAIMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2B688E0", Offset = "0x2B66EE0", VA = "0x182B688E0", Slot = "25")]
	public override bool PFAIEHOFDHF(Entity PEKCJMKIHGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2B62CE0", Offset = "0x2B612E0", VA = "0x182B62CE0", Slot = "26")]
	public override bool HFFEKHNIFMP(Entity PEKCJMKIHGK, in object ABBAPCAIMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2B68A10", Offset = "0x2B67010", VA = "0x182B68A10", Slot = "27")]
	public override void PIDCPOPDLLJ(Entity PEKCJMKIHGK, in FOLHPMBKIGD FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2B655B0", Offset = "0x2B63BB0", VA = "0x182B655B0", Slot = "28")]
	public override bool PCICHOODFHC(Entity PEKCJMKIHGK, in IGCFDMLBPPM ABBAPCAIMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2B633F0", Offset = "0x2B619F0", VA = "0x182B633F0", Slot = "29")]
	public override bool IOAKBHBLOJG(Entity PEKCJMKIHGK, in IGCFDMLBPPM ABBAPCAIMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2B62B90", Offset = "0x2B61190", VA = "0x182B62B90", Slot = "30")]
	public override void DPEBGIDOBOG(PECLEJOEEND EPGFAAAAECD, [Optional] object JHAKINLMMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2B64300", Offset = "0x2B62900", VA = "0x182B64300", Slot = "31")]
	public override bool JOKLDHADBPL(Entity PBFCNGOCEEJ, Entity FDDHIMHLJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "32")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2B64050", Offset = "0x2B62650", VA = "0x182B64050", Slot = "34")]
	public override string JGOFLMDGPDI(in IGCFDMLBPPM EBELHNPCIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B62BE0", Offset = "0x2B611E0", VA = "0x182B62BE0")]
	private bool FCJJJAFBLNE(ref T BGBLNMDAKNB, ref T ABBAPCAIMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2B68940", Offset = "0x2B66F40", VA = "0x182B68940", Slot = "36")]
	private bool PGKALKOCJGE(Entity NAJDAPHOGEH, in T ABBAPCAIMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2B62B60", Offset = "0x2B61160", VA = "0x182B62B60", Slot = "37")]
	private bool DFNEOHLICGD(Entity NAJDAPHOGEH, in T ABBAPCAIMDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void LLHEJLILDGA<TKey>(TKey IAMEECMGPIF, in IGCFDMLBPPM BGBLNMDAKNB, in IGCFDMLBPPM ABBAPCAIMDJ);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BCJBNAHEEOB
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1D07400", Offset = "0x1D05A00", VA = "0x181D07400")]
	public static void HDLCFALLNOK<TKey, T>(this LLHEJLILDGA<TKey> LNBMEBPIDEB, TKey IAMEECMGPIF, T BGBLNMDAKNB, T ABBAPCAIMDJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PECLEJOEEND
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMBPBHDCPCP<TKey, T>(MFDDLGLKMCP<TKey, T> OMEMEFEKGAP, [Optional] object JHAKINLMMJL) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CENAEHLLKAI
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMBPBHDCPCP(NBIFMCDOFDB OMEMEFEKGAP, in IGCFDMLBPPM FEBHELIDNED, [Optional] object JHAKINLMMJL);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KGIOGKMMCDC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FieldInfo GJHPCCIKHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int EAPFBGNMJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int MFIPBJCKMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NBIFMCDOFDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string NHAFHGAJCFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Type KBBBDODNMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	KGIOGKMMCDC MBHEELLGHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	NKNEAONODKJ KLDGEIJFAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int HMJKGAFBEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DPEBGIDOBOG(PECLEJOEEND EPGFAAAAECD, [Optional] object JHAKINLMMJL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AJDIOEGOOJG<TKey> : NBIFMCDOFDB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event LLHEJLILDGA<TKey> AOHLCMGPNCK;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PFAIEHOFDHF(TKey NAJDAPHOGEH);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HFFEKHNIFMP(TKey NAJDAPHOGEH, in object ABBAPCAIMDJ);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PIDCPOPDLLJ(TKey NAJDAPHOGEH, in FOLHPMBKIGD FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PCICHOODFHC(TKey NAJDAPHOGEH, in IGCFDMLBPPM ABBAPCAIMDJ);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IOAKBHBLOJG(TKey NAJDAPHOGEH, in IGCFDMLBPPM ABBAPCAIMDJ);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JOKLDHADBPL(TKey PBFCNGOCEEJ, TKey FDDHIMHLJAI);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string JGOFLMDGPDI(in IGCFDMLBPPM FEBHELIDNED);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface MFDDLGLKMCP<TKey, T> : AJDIOEGOOJG<TKey>, NBIFMCDOFDB, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T PIDCPOPDLLJ(TKey NAJDAPHOGEH);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PCICHOODFHC(TKey NAJDAPHOGEH, in T ABBAPCAIMDJ);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IOAKBHBLOJG(TKey NAJDAPHOGEH, in T ABBAPCAIMDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ANOJAGEGBOM
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1024C80", Offset = "0x1023280", VA = "0x181024C80")]
	public static bool HNEMDLLFNLP<TKey, T>(this AJDIOEGOOJG<TKey> OMEMEFEKGAP, TKey NAJDAPHOGEH, out T FEBHELIDNED) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1025D00", Offset = "0x1024300", VA = "0x181025D00")]
	public static T PIDCPOPDLLJ<T, TKey>(this AJDIOEGOOJG<TKey> OMEMEFEKGAP, TKey NAJDAPHOGEH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x10254A0", Offset = "0x1023AA0", VA = "0x1810254A0")]
	public static bool PCICHOODFHC<TKey, T>(this AJDIOEGOOJG<TKey> OMEMEFEKGAP, TKey NAJDAPHOGEH, T ABBAPCAIMDJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1024E10", Offset = "0x1023410", VA = "0x181024E10")]
	public static bool IOAKBHBLOJG<TKey, T>(this AJDIOEGOOJG<TKey> OMEMEFEKGAP, TKey NAJDAPHOGEH, T ABBAPCAIMDJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CLLJMNNCKMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly Type LFBJHCMDIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly string HNPIEGONNBC;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xBBF9D0", Offset = "0xBBDFD0", VA = "0x180BBF9D0")]
	public CLLJMNNCKMG(Type LFBJHCMDIAE, string HNPIEGONNBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct JGHGJDHNFBJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly Type LFBJHCMDIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly string HNPIEGONNBC;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xBBF9D0", Offset = "0xBBDFD0", VA = "0x180BBF9D0")]
	public JGHGJDHNFBJ(Type LFBJHCMDIAE, string HNPIEGONNBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2A09C00", Offset = "0x2A08200", VA = "0x182A09C00")]
	public static CLLJMNNCKMG FCDPLNAGMAN(JGHGJDHNFBJ<T> AEGHEEOOJKD)
	{
		return default(CLLJMNNCKMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum KBFMECIEFGL
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	CreateObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DestroyObject = -3,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	BeginTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	EndTransaction = -5,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	External = -6
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class NDOKJICJJBP : BIEPOFHIHEI, IEnumerable<PKJHJMAHAIO>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<PKJHJMAHAIO> CFAKJICPELL;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7268660", Offset = "0x7266C60", VA = "0x187268660", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PKJHJMAHAIO KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7268580", Offset = "0x7266B80", VA = "0x187268580", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x72686A0", Offset = "0x7266CA0", VA = "0x1872686A0")]
	public NDOKJICJJBP(IEnumerable<NKNEAONODKJ> AAILGMBJLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7268090", Offset = "0x7266690", VA = "0x187268090")]
	private List<PKJHJMAHAIO> AABJJOFEGAJ(IEnumerable<NKNEAONODKJ> AAILGMBJLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x72685E0", Offset = "0x7266BE0", VA = "0x1872685E0", Slot = "4")]
	public IEnumerator<PKJHJMAHAIO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x72685E0", Offset = "0x7266BE0", VA = "0x1872685E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
