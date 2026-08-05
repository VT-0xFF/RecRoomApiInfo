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
public sealed class ABLCPJMDDOD<TContainer, TField> : DAGGCLDNNGP<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3FB6A00", Offset = "0x3FB5E00", VA = "0x183FB6A00")]
	public ABLCPJMDDOD(string ACDGEPBIBHJ, BGPIECGIJBM NNHLGBCKJOM, FieldInfo IJDAKAKIJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3FB65B0", Offset = "0x3FB59B0", VA = "0x183FB65B0", Slot = "26")]
	public override bool NBJJIKECOBK(Entity FEMCIAKBEIF, EGAEOODFFBN DCGCMNFFOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3FB64C0", Offset = "0x3FB58C0", VA = "0x183FB64C0", Slot = "32")]
	public override LPLDPJOAOBK DHPJLCMHGKP(EntityManager HCOMKMNCEII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class IDOLFBNEBHN<T> : DAGGCLDNNGP<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3FB6A00", Offset = "0x3FB5E00", VA = "0x183FB6A00")]
	public IDOLFBNEBHN(string ACDGEPBIBHJ, BGPIECGIJBM NNHLGBCKJOM, FieldInfo IJDAKAKIJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4203590", Offset = "0x4202990", VA = "0x184203590", Slot = "32")]
	public override LPLDPJOAOBK DHPJLCMHGKP(EntityManager HCOMKMNCEII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class DAGGCLDNNGP<T> : JLKNDDBDJGJ, MJOFLAKNLPK<T>, EGLNJKOPMCD<Entity, T>, NELGGJEDFKP<Entity>, OEBJIIFLMHC, IDisposable, LPLDPJOAOBK, HAKPEOPIMFI where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool KEPAANKMGPL(Entity FEMCIAKBEIF, [In] T DCGCMNFFOJI);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void BKGMGKCCELN(Entity FEMCIAKBEIF, [In] T AKANKMMONNP, [In] T DCGCMNFFOJI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly BGPIECGIJBM NNHLGBCKJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	protected readonly FieldInfo IJDAKAKIJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly int NBFPJBGNDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int HHOJFKLGPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int JKIIGJDNBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private KEPAANKMGPL CENHKBDFNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private BKGMGKCCELN DGONCJAKNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private BKGMGKCCELN CJJEDLKGLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World CHOPEICJPDP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type LLHMNEIJLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5BD78B0", Offset = "0x5BD6CB0", VA = "0x185BD78B0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override BGPIECGIJBM GLHFMILCCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89EF10", Offset = "0x89E310", VA = "0x18089EF10", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override HAKPEOPIMFI NPPGLJLNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo MLLNOOKFCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int ECAHEHNKOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B9630", Offset = "0x8B8A30", VA = "0x1808B9630", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int EGPKLMAIPNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8AAEF0", Offset = "0x8AA2F0", VA = "0x1808AAEF0", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager KENJLABKECK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5BD30C0", Offset = "0x5BD24C0", VA = "0x185BD30C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5BD89C0", Offset = "0x5BD7DC0", VA = "0x185BD89C0")]
	internal DAGGCLDNNGP(string ACDGEPBIBHJ, BGPIECGIJBM NNHLGBCKJOM, FieldInfo IJDAKAKIJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5BD7010", Offset = "0x5BD6410", VA = "0x185BD7010", Slot = "30")]
	public override void NOCOEJHJFAP(EntityManager FINHDKAKKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5BD8400", Offset = "0x5BD7800", VA = "0x185BD8400")]
	public DAGGCLDNNGP<T> PEFBMHFCJCF(KEPAANKMGPL CENHKBDFNEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5BD1530", Offset = "0x5BD0930", VA = "0x185BD1530")]
	public DAGGCLDNNGP<T> AGKIELLEFMC(BKGMGKCCELN DGONCJAKNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5BD37D0", Offset = "0x5BD2BD0", VA = "0x185BD37D0")]
	public DAGGCLDNNGP<T> KLHCDALLPNC(BKGMGKCCELN CJJEDLKGLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5BD1CF0", Offset = "0x5BD10F0", VA = "0x185BD1CF0", Slot = "33")]
	public T GEKLBPFDDHO(Entity FEMCIAKBEIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5BD5BD0", Offset = "0x5BD4FD0", VA = "0x185BD5BD0")]
	public bool NBJJIKECOBK(Entity FEMCIAKBEIF, [In] T DCGCMNFFOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5BD26D0", Offset = "0x5BD1AD0", VA = "0x185BD26D0")]
	public bool HDHAIJEHKAL(Entity FEMCIAKBEIF, [In] T DCGCMNFFOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5BD2EB0", Offset = "0x5BD22B0", VA = "0x185BD2EB0", Slot = "24")]
	public override bool ICLDDBMHILA(Entity FEMCIAKBEIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5BD19C0", Offset = "0x5BD0DC0", VA = "0x185BD19C0", Slot = "25")]
	public override void GEKLBPFDDHO(Entity FEMCIAKBEIF, JKPIALGNEGL PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5BD4010", Offset = "0x5BD3410", VA = "0x185BD4010", Slot = "26")]
	public override bool NBJJIKECOBK(Entity FEMCIAKBEIF, EGAEOODFFBN DCGCMNFFOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3B7F390", Offset = "0x3B7E790", VA = "0x183B7F390", Slot = "27")]
	public override void MNOKDHFFPID(EABMDIJMHBH HFHBLJIEJIM, [Optional] object EPLPPJHJIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5BD8060", Offset = "0x5BD7460", VA = "0x185BD8060", Slot = "28")]
	public override bool OHDKAOHEEPM(Entity AMPDFCKEJKN, Entity DPJCEEDGHJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "29")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5BD32C0", Offset = "0x5BD26C0", VA = "0x185BD32C0", Slot = "31")]
	public override string JGJPFDJDMAP([In] EGAEOODFFBN MDENBEDAAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5BD1550", Offset = "0x5BD0950", VA = "0x185BD1550")]
	private bool FJPKBPAJEEC(T AKANKMMONNP, T DCGCMNFFOJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class JLKNDDBDJGJ : BABPJLNHHDB, LPLDPJOAOBK, NELGGJEDFKP<Entity>, OEBJIIFLMHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type LLHMNEIJLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract BGPIECGIJBM GLHFMILCCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract HAKPEOPIMFI NPPGLJLNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string MKBLEONOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x89CEC0", Offset = "0x89C2C0", VA = "0x18089CEC0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CFONMNPPIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9741A0", Offset = "0x9735A0", VA = "0x1809741A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAA25F0", Offset = "0xAA19F0", VA = "0x180AA25F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event GEKDEPLMKIC<Entity> BCPIEHEGKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D63270", Offset = "0x6D62670", VA = "0x186D63270", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6D631C0", Offset = "0x6D625C0", VA = "0x186D631C0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool ICLDDBMHILA(Entity FEMCIAKBEIF);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void GEKLBPFDDHO(Entity FEMCIAKBEIF, JKPIALGNEGL PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool NBJJIKECOBK(Entity FEMCIAKBEIF, EGAEOODFFBN DCGCMNFFOJI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void MNOKDHFFPID(EABMDIJMHBH HFHBLJIEJIM, [Optional] object EPLPPJHJIIM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool OHDKAOHEEPM(Entity AMPDFCKEJKN, Entity DPJCEEDGHJL);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void NOCOEJHJFAP(EntityManager FINHDKAKKGK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2F3E960", Offset = "0x2F3DD60", VA = "0x182F3E960")]
	protected void OFDGOKDFDLD<T>(Entity FEMCIAKBEIF, [In] T AKANKMMONNP, [In] T DCGCMNFFOJI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract string JGJPFDJDMAP([In] EGAEOODFFBN MDENBEDAAMN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract LPLDPJOAOBK DHPJLCMHGKP(EntityManager HCOMKMNCEII);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	protected JLKNDDBDJGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LPLDPJOAOBK : NELGGJEDFKP<Entity>, OEBJIIFLMHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LPLDPJOAOBK DHPJLCMHGKP(EntityManager HCOMKMNCEII);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MJOFLAKNLPK<T> : EGLNJKOPMCD<Entity, T>, NELGGJEDFKP<Entity>, OEBJIIFLMHC, IDisposable, LPLDPJOAOBK where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface BABPJLNHHDB : LPLDPJOAOBK, NELGGJEDFKP<Entity>, OEBJIIFLMHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int CFONMNPPIOK
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
public static class JCIEPMKGCEH
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2F04BB0", Offset = "0x2F03FB0", VA = "0x182F04BB0")]
	public static T LLMLCIBLEKE<T>(this MJOFLAKNLPK<T> BCPKEGMOEBD, Entity FEMCIAKBEIF, [Optional] T POOOEFHFGKB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2F04850", Offset = "0x2F03C50", VA = "0x182F04850")]
	public static T FFDPDONAMEJ<T>(this NELGGJEDFKP<Entity> BCPKEGMOEBD, Entity FEMCIAKBEIF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2F04A40", Offset = "0x2F03E40", VA = "0x182F04A40")]
	public static bool IICMCIBBOFF<T>(this NELGGJEDFKP<Entity> BCPKEGMOEBD, Entity FEMCIAKBEIF, [In] T DCGCMNFFOJI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2F04950", Offset = "0x2F03D50", VA = "0x182F04950")]
	public static bool IICMCIBBOFF<T>(this NELGGJEDFKP<Entity> BCPKEGMOEBD, Entity FEMCIAKBEIF, NativeArray<T> DCGCMNFFOJI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void GEKDEPLMKIC<TKey>(TKey FAKGLFFOLFI, [In] EGAEOODFFBN AKANKMMONNP, [In] EGAEOODFFBN DCGCMNFFOJI);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class KBKFDHEIBND
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2F63600", Offset = "0x2F62A00", VA = "0x182F63600")]
	public static void IIFNBMCHKOM<TKey, T>(this GEKDEPLMKIC<TKey> IFIGLHPCJIJ, TKey FAKGLFFOLFI, T AKANKMMONNP, T DCGCMNFFOJI) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EABMDIJMHBH
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNNDGGNMHAD<TKey, T>(EGLNJKOPMCD<TKey, T> BCPKEGMOEBD, [Optional] object EPLPPJHJIIM) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IGKKAAOOCBE
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HAKPEOPIMFI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo HPDIBJKPJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int GPBKFOICKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int INPFMBGIDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OEBJIIFLMHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string MKBLEONOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type LLHMNEIJLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	HAKPEOPIMFI NPPGLJLNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BGPIECGIJBM GLHFMILCCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int CFONMNPPIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MNOKDHFFPID(EABMDIJMHBH HFHBLJIEJIM, [Optional] object EPLPPJHJIIM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NELGGJEDFKP<TKey> : OEBJIIFLMHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event GEKDEPLMKIC<TKey> BCPIEHEGKIH;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ICLDDBMHILA(TKey PBFBBOFLBNL);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GEKLBPFDDHO(TKey PBFBBOFLBNL, JKPIALGNEGL PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NBJJIKECOBK(TKey PBFBBOFLBNL, EGAEOODFFBN DCGCMNFFOJI);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OHDKAOHEEPM(TKey AMPDFCKEJKN, TKey DPJCEEDGHJL);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string JGJPFDJDMAP([In] EGAEOODFFBN PFKKDHPJFEH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface EGLNJKOPMCD<TKey, T> : NELGGJEDFKP<TKey>, OEBJIIFLMHC, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T GEKLBPFDDHO(TKey PBFBBOFLBNL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OBEGOAEBEGG
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3084800", Offset = "0x3083C00", VA = "0x183084800")]
	public static bool IELONOIKEDC<TKey, T>(this NELGGJEDFKP<TKey> BCPKEGMOEBD, TKey PBFBBOFLBNL, [Out] T PFKKDHPJFEH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x30840D0", Offset = "0x30834D0", VA = "0x1830840D0")]
	public static T GEKLBPFDDHO<T, TKey>(this NELGGJEDFKP<TKey> BCPKEGMOEBD, TKey PBFBBOFLBNL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3084D50", Offset = "0x3084150", VA = "0x183084D50")]
	public static bool NBJJIKECOBK<TKey, T>(this NELGGJEDFKP<TKey> BCPKEGMOEBD, TKey PBFBBOFLBNL, T DCGCMNFFOJI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x30849C0", Offset = "0x3083DC0", VA = "0x1830849C0")]
	public static bool NBJJIKECOBK<TKey, T>(this NELGGJEDFKP<TKey> BCPKEGMOEBD, TKey PBFBBOFLBNL, NativeArray<T> DCGCMNFFOJI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface NGPEIOIMOLC : IEnumerable<LPLDPJOAOBK>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BGPIECGIJBM
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int KNDLECMFFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int NHFIIIELBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type BGBIMAFLKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	LPLDPJOAOBK[] DIPKPCNOBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool OGGINEMPIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) HMIGDNLOCPO(Entity FEMCIAKBEIF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class DPDBMIHMMHI : NGPEIOIMOLC, IEnumerable<LPLDPJOAOBK>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<LPLDPJOAOBK> MEPHCDGJCCD;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D62BD0", Offset = "0x6D61FD0", VA = "0x186D62BD0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LPLDPJOAOBK LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D63120", Offset = "0x6D62520", VA = "0x186D63120", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D63180", Offset = "0x6D62580", VA = "0x186D63180")]
	public DPDBMIHMMHI(IEnumerable<BGPIECGIJBM> MKHKCGNAJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6D62C90", Offset = "0x6D62090", VA = "0x186D62C90")]
	private List<LPLDPJOAOBK> KBEPLPLEMAF(IEnumerable<BGPIECGIJBM> MKHKCGNAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D62C10", Offset = "0x6D62010", VA = "0x186D62C10", Slot = "4")]
	public IEnumerator<LPLDPJOAOBK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6D62C10", Offset = "0x6D62010", VA = "0x186D62C10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct HCBEOCOMOFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type APHLOELHHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string ACDGEPBIBHJ;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xDEC7B0", Offset = "0xDEBBB0", VA = "0x180DEC7B0")]
	public HCBEOCOMOFA(Type APHLOELHHGG, string ACDGEPBIBHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct GBMKICFMLLM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type APHLOELHHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string ACDGEPBIBHJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xDEC7B0", Offset = "0xDEBBB0", VA = "0x180DEC7B0")]
	public GBMKICFMLLM(Type APHLOELHHGG, string ACDGEPBIBHJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4000DD0", Offset = "0x40001D0", VA = "0x184000DD0")]
	public static HCBEOCOMOFA BKDLHJCNIKF(GBMKICFMLLM<T> CCOCIOCMPFE)
	{
		return default(HCBEOCOMOFA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum AMKCOIMFKIE
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
public class DHPHBMGKPAN
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public DHPHBMGKPAN()
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
