using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class MNGLIEDCLEF<TContainer, TField> : ELHCJGNJFBA<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3B54F50", Offset = "0x3B54350", VA = "0x183B54F50")]
	public MNGLIEDCLEF(string DDDHPCNFCEK, MIFFGJNEJJB OACLGAKONPN, FieldInfo CFDGJIKNHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4852FE0", Offset = "0x48523E0", VA = "0x184852FE0", Slot = "26")]
	public override bool MCAKFOHFDBM(Entity KFLBPHJAJJL, NMBPLOPJKJI JFKJABAPEAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4852D70", Offset = "0x4852170", VA = "0x184852D70", Slot = "32")]
	public override CNDMFFBIJGK AFFJNMKNCCG(EntityManager LILPFPEKBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class EECDEPBHFMO<T> : ELHCJGNJFBA<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B54F50", Offset = "0x3B54350", VA = "0x183B54F50")]
	public EECDEPBHFMO(string DDDHPCNFCEK, MIFFGJNEJJB OACLGAKONPN, FieldInfo CFDGJIKNHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B54E60", Offset = "0x3B54260", VA = "0x183B54E60", Slot = "32")]
	public override CNDMFFBIJGK AFFJNMKNCCG(EntityManager LILPFPEKBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class ELHCJGNJFBA<T> : GDNNCGAHLMP, HNIKIGENBIM<T>, KIEMIBJKEGG<Entity, T>, DBPOIKCPHGA<Entity>, MEKBBDHIBKK, IDisposable, CNDMFFBIJGK, DALDPAPNNPA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool CCDJCJKFNBP(Entity KFLBPHJAJJL, [In] T JFKJABAPEAB);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void EHDGBJDOCGP(Entity KFLBPHJAJJL, [In] T FDICBHCLKHM, [In] T JFKJABAPEAB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly MIFFGJNEJJB OACLGAKONPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	protected readonly FieldInfo CFDGJIKNHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly int HPIFEIGNDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int OLMEFNCLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int IKJKAFPPDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CCDJCJKFNBP FDLPMEMJBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EHDGBJDOCGP NEPLMENGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private EHDGBJDOCGP FCOFAACNPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World NNBFJMEFHAJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type NKDPEDOOFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3B945B0", Offset = "0x3B939B0", VA = "0x183B945B0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override MIFFGJNEJJB OAJJKHOCKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AD890", Offset = "0x8ACC90", VA = "0x1808AD890", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override DALDPAPNNPA KOEBAPALFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo IDOIFBJACBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int EOEJMKOKMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C7930", Offset = "0x8C6D30", VA = "0x1808C7930", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int IKFHNGFEBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8B9060", Offset = "0x8B8460", VA = "0x1808B9060", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager EFHGOOFKIED
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3B9B8F0", Offset = "0x3B9ACF0", VA = "0x183B9B8F0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3B9CA20", Offset = "0x3B9BE20", VA = "0x183B9CA20")]
	internal ELHCJGNJFBA(string DDDHPCNFCEK, MIFFGJNEJJB OACLGAKONPN, FieldInfo CFDGJIKNHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3B961B0", Offset = "0x3B955B0", VA = "0x183B961B0", Slot = "30")]
	public override void CGCFJDLGJFP(EntityManager BIDAOIBGIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3B965D0", Offset = "0x3B959D0", VA = "0x183B965D0")]
	public ELHCJGNJFBA<T> FJKGAPDGNAI(CCDJCJKFNBP FDLPMEMJBAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3B96660", Offset = "0x3B95A60", VA = "0x183B96660")]
	public ELHCJGNJFBA<T> HPCCPDOBFPO(EHDGBJDOCGP NEPLMENGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3B94730", Offset = "0x3B93B30", VA = "0x183B94730")]
	public ELHCJGNJFBA<T> BMGCELCLAGP(EHDGBJDOCGP FCOFAACNPGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3B95390", Offset = "0x3B94790", VA = "0x183B95390", Slot = "33")]
	public T CADKKGPFCDD(Entity KFLBPHJAJJL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3B97F40", Offset = "0x3B97340", VA = "0x183B97F40")]
	public bool MCAKFOHFDBM(Entity KFLBPHJAJJL, [In] T JFKJABAPEAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3B96680", Offset = "0x3B95A80", VA = "0x183B96680")]
	public bool KMCLFHNJHFF(Entity KFLBPHJAJJL, [In] T JFKJABAPEAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3B93A40", Offset = "0x3B92E40", VA = "0x183B93A40", Slot = "24")]
	public override bool AJEFCBIPMCP(Entity KFLBPHJAJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3B949E0", Offset = "0x3B93DE0", VA = "0x183B949E0", Slot = "25")]
	public override void CADKKGPFCDD(Entity KFLBPHJAJJL, NJIHLEJAJJC EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3B98C40", Offset = "0x3B98040", VA = "0x183B98C40", Slot = "26")]
	public override bool MCAKFOHFDBM(Entity KFLBPHJAJJL, NMBPLOPJKJI JFKJABAPEAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C360", Offset = "0x3B9B760", VA = "0x183B9C360", Slot = "27")]
	public override void PKMGBPHCJBE(DKOLICIMNKH LNEBLEOFBJI, [Optional] object OMHMFLHBNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3B9BE90", Offset = "0x3B9B290", VA = "0x183B9BE90", Slot = "28")]
	public override bool OOIHJHLMILI(Entity CJFFIHKDKOL, Entity CEMFCPJEKHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "29")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3B96F20", Offset = "0x3B96320", VA = "0x183B96F20", Slot = "31")]
	public override string LLEKPCCFIAB([In] NMBPLOPJKJI KHLOHMIGKOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3B965F0", Offset = "0x3B959F0", VA = "0x183B965F0")]
	private bool GEGIDKJPCIO(T FDICBHCLKHM, T JFKJABAPEAB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class GDNNCGAHLMP : PICLJLJICEB, CNDMFFBIJGK, DBPOIKCPHGA<Entity>, MEKBBDHIBKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type NKDPEDOOFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract MIFFGJNEJJB OAJJKHOCKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract DALDPAPNNPA KOEBAPALFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8A8970", Offset = "0x8A7D70", VA = "0x1808A8970")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KJOBEHBFKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x92A830", Offset = "0x929C30", VA = "0x18092A830", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA39D70", Offset = "0xA39170", VA = "0x180A39D70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event CFMJFPHKLCG<Entity> HNOKCPNKPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8BA0", Offset = "0x6DE7FA0", VA = "0x186DE8BA0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8AF0", Offset = "0x6DE7EF0", VA = "0x186DE8AF0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool AJEFCBIPMCP(Entity KFLBPHJAJJL);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void CADKKGPFCDD(Entity KFLBPHJAJJL, NJIHLEJAJJC EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool MCAKFOHFDBM(Entity KFLBPHJAJJL, NMBPLOPJKJI JFKJABAPEAB);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void PKMGBPHCJBE(DKOLICIMNKH LNEBLEOFBJI, [Optional] object OMHMFLHBNDJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool OOIHJHLMILI(Entity CJFFIHKDKOL, Entity CEMFCPJEKHI);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void CGCFJDLGJFP(EntityManager BIDAOIBGIKA);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A040", Offset = "0x2E59440", VA = "0x182E5A040")]
	protected void LFFLPIBJAPP<T>(Entity KFLBPHJAJJL, [In] T FDICBHCLKHM, [In] T JFKJABAPEAB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract string LLEKPCCFIAB([In] NMBPLOPJKJI KHLOHMIGKOJ);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract CNDMFFBIJGK AFFJNMKNCCG(EntityManager LILPFPEKBOH);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	protected GDNNCGAHLMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CNDMFFBIJGK : DBPOIKCPHGA<Entity>, MEKBBDHIBKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CNDMFFBIJGK AFFJNMKNCCG(EntityManager LILPFPEKBOH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HNIKIGENBIM<T> : KIEMIBJKEGG<Entity, T>, DBPOIKCPHGA<Entity>, MEKBBDHIBKK, IDisposable, CNDMFFBIJGK where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface PICLJLJICEB : CNDMFFBIJGK, DBPOIKCPHGA<Entity>, MEKBBDHIBKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int KJOBEHBFKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JKFGMMPPADJ
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4AE0", Offset = "0x2EB3EE0", VA = "0x182EB4AE0")]
	public static T KAGMKJDDCCL<T>(this HNIKIGENBIM<T> ECJEGOAKEPN, Entity KFLBPHJAJJL, [Optional] T BMLEAJPEFAD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4C60", Offset = "0x2EB4060", VA = "0x182EB4C60")]
	public static T KNHFAJNBGBJ<T>(this DBPOIKCPHGA<Entity> ECJEGOAKEPN, Entity KFLBPHJAJJL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2EB49A0", Offset = "0x2EB3DA0", VA = "0x182EB49A0")]
	public static bool HDIAEBCMCGC<T>(this DBPOIKCPHGA<Entity> ECJEGOAKEPN, Entity KFLBPHJAJJL, [In] T JFKJABAPEAB) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2EB48B0", Offset = "0x2EB3CB0", VA = "0x182EB48B0")]
	public static bool HDIAEBCMCGC<T>(this DBPOIKCPHGA<Entity> ECJEGOAKEPN, Entity KFLBPHJAJJL, NativeArray<T> JFKJABAPEAB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void CFMJFPHKLCG<TKey>(TKey FMAFBHGACNM, [In] NMBPLOPJKJI FDICBHCLKHM, [In] NMBPLOPJKJI JFKJABAPEAB);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LPEOANGNCBN
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2F17B10", Offset = "0x2F16F10", VA = "0x182F17B10")]
	public static void NCEDFJEFMFN<TKey, T>(this CFMJFPHKLCG<TKey> LGMNIMKDFON, TKey FMAFBHGACNM, T FDICBHCLKHM, T JFKJABAPEAB) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DKOLICIMNKH
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAPNFMBODHG<TKey, T>(KIEMIBJKEGG<TKey, T> ECJEGOAKEPN, [Optional] object OMHMFLHBNDJ) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BPCBJPOAFBD
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DALDPAPNNPA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo OEKKACPGMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int NLMHBLNBBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int GDNEEEAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MEKBBDHIBKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type NKDPEDOOFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DALDPAPNNPA KOEBAPALFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MIFFGJNEJJB OAJJKHOCKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int KJOBEHBFKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PKMGBPHCJBE(DKOLICIMNKH LNEBLEOFBJI, [Optional] object OMHMFLHBNDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DBPOIKCPHGA<TKey> : MEKBBDHIBKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event CFMJFPHKLCG<TKey> HNOKCPNKPJM;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AJEFCBIPMCP(TKey OEOMDKHBDFI);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CADKKGPFCDD(TKey OEOMDKHBDFI, NJIHLEJAJJC EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MCAKFOHFDBM(TKey OEOMDKHBDFI, NMBPLOPJKJI JFKJABAPEAB);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OOIHJHLMILI(TKey CJFFIHKDKOL, TKey CEMFCPJEKHI);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string LLEKPCCFIAB([In] NMBPLOPJKJI EEPLCHCGAIN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface KIEMIBJKEGG<TKey, T> : DBPOIKCPHGA<TKey>, MEKBBDHIBKK, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T CADKKGPFCDD(TKey OEOMDKHBDFI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FNBDHBCMCGC
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E50F30", Offset = "0x2E50330", VA = "0x182E50F30")]
	public static bool FAKKNFFMHEG<TKey, T>(this DBPOIKCPHGA<TKey> ECJEGOAKEPN, TKey OEOMDKHBDFI, [Out] T EEPLCHCGAIN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2E50460", Offset = "0x2E4F860", VA = "0x182E50460")]
	public static T CADKKGPFCDD<T, TKey>(this DBPOIKCPHGA<TKey> ECJEGOAKEPN, TKey OEOMDKHBDFI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2E510F0", Offset = "0x2E504F0", VA = "0x182E510F0")]
	public static bool MCAKFOHFDBM<TKey, T>(this DBPOIKCPHGA<TKey> ECJEGOAKEPN, TKey OEOMDKHBDFI, T JFKJABAPEAB) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E51220", Offset = "0x2E50620", VA = "0x182E51220")]
	public static bool MCAKFOHFDBM<TKey, T>(this DBPOIKCPHGA<TKey> ECJEGOAKEPN, TKey OEOMDKHBDFI, NativeArray<T> JFKJABAPEAB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface PCGLLNNOEPH : IEnumerable<CNDMFFBIJGK>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MIFFGJNEJJB
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int EFANFNNKBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int NOMEBGCKOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type NDBGBGIIPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	CNDMFFBIJGK[] DMKECDOMAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool GGFKNLGHHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) OHOKOJNBFBN(Entity KFLBPHJAJJL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class FNAFPIIPBLH : PCGLLNNOEPH, IEnumerable<CNDMFFBIJGK>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<CNDMFFBIJGK> PBKKMDEAOIK;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8590", Offset = "0x6DE7990", VA = "0x186DE8590", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CNDMFFBIJGK MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8A50", Offset = "0x6DE7E50", VA = "0x186DE8A50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8AB0", Offset = "0x6DE7EB0", VA = "0x186DE8AB0")]
	public FNAFPIIPBLH(IEnumerable<MIFFGJNEJJB> IKEEKGHANCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6DE85D0", Offset = "0x6DE79D0", VA = "0x186DE85D0")]
	private List<CNDMFFBIJGK> LIKHDPIPNLF(IEnumerable<MIFFGJNEJJB> IKEEKGHANCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8510", Offset = "0x6DE7910", VA = "0x186DE8510", Slot = "4")]
	public IEnumerator<CNDMFFBIJGK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8510", Offset = "0x6DE7910", VA = "0x186DE8510", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KMEIGJEGBBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type OBFCCEEEOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string DDDHPCNFCEK;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xD74C00", Offset = "0xD74000", VA = "0x180D74C00")]
	public KMEIGJEGBBB(Type OBFCCEEEOPN, string DDDHPCNFCEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct IDCMBOLHKPN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type OBFCCEEEOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string DDDHPCNFCEK;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xD74C00", Offset = "0xD74000", VA = "0x180D74C00")]
	public IDCMBOLHKPN(Type OBFCCEEEOPN, string DDDHPCNFCEK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4235760", Offset = "0x4234B60", VA = "0x184235760")]
	public static KMEIGJEGBBB ACIMPJEHMPA(IDCMBOLHKPN<T> CLBFKLGDOCF)
	{
		return default(KMEIGJEGBBB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum DILBOHHCFDF
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	CreateObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DestroyObject = -3,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	BeginTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	EndTransaction = -5,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	External = -6
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JHDCDGCMADC
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public JHDCDGCMADC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
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
