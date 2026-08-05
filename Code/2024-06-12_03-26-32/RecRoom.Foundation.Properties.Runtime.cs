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
public sealed class MDCGHBGCMAO<TContainer, TField> : JFJFDMKCMPI<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3806530", Offset = "0x3805130", VA = "0x183806530")]
	public MDCGHBGCMAO(string GFLNGGKHEOH, ICBIMKCLBMN ONIAHHAAJEH, FieldInfo MLHEFKGHNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x43E6970", Offset = "0x43E5570", VA = "0x1843E6970", Slot = "25")]
	public override bool CBGDEMCKLAL(Entity NGLCFDBCFFC, MDEDOBLHNPN CAGOIFBMMMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class DAMPAIGLGJK<T> : JFJFDMKCMPI<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3806530", Offset = "0x3805130", VA = "0x183806530")]
	public DAMPAIGLGJK(string GFLNGGKHEOH, ICBIMKCLBMN ONIAHHAAJEH, FieldInfo MLHEFKGHNHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class JFJFDMKCMPI<T> : BCEMEOBBBNN, CAMHNIFIIIP<T>, MPNHIAJCMOH<Entity, T>, KNNDAHEBDGA<Entity>, PMJEFJENCPC, IDisposable, DEPCKBDOBLK, IKKJGFAHMPN where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool NNDIBNCNHAD(Entity NGLCFDBCFFC, [In] T CAGOIFBMMMG);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void FDNOOOMPHFP(Entity NGLCFDBCFFC, [In] T CGDBBAILNNN, [In] T CAGOIFBMMMG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ICBIMKCLBMN ONIAHHAAJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly FieldInfo MLHEFKGHNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected readonly int CCJPPHADPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	protected readonly int MANKJHLJMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int AEOJMEBJNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NNDIBNCNHAD IDNKKCCOPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private FDNOOOMPHFP PEBNJHPAFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private FDNOOOMPHFP OGKBALCOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World BKIPEHEIIHC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type AJCKJIKGPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x402F5A0", Offset = "0x402E1A0", VA = "0x18402F5A0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override ICBIMKCLBMN JDIGKPHBDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override IKKJGFAHMPN JPOCEKCGMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo LPOIEFIDCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int MJFDHFICMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8615D0", Offset = "0x8601D0", VA = "0x1808615D0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int LAPEOBFICIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x853470", Offset = "0x852070", VA = "0x180853470", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager MNIGOFNGCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4030E50", Offset = "0x402FA50", VA = "0x184030E50")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4031BF0", Offset = "0x40307F0", VA = "0x184031BF0")]
	internal JFJFDMKCMPI(string GFLNGGKHEOH, ICBIMKCLBMN ONIAHHAAJEH, FieldInfo MLHEFKGHNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x402EEE0", Offset = "0x402DAE0", VA = "0x18402EEE0", Slot = "29")]
	public override void EHHLDMLDHNI(EntityManager NJHBFCFCNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4030E90", Offset = "0x402FA90", VA = "0x184030E90")]
	public JFJFDMKCMPI<T> MEOMFDMPOCK(NNDIBNCNHAD IDNKKCCOPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4030E70", Offset = "0x402FA70", VA = "0x184030E70")]
	public JFJFDMKCMPI<T> MAMDGLFABIO(FDNOOOMPHFP PEBNJHPAFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4029300", Offset = "0x4027F00", VA = "0x184029300")]
	public JFJFDMKCMPI<T> AFAPNNONDPK(FDNOOOMPHFP OGKBALCOPLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4030AC0", Offset = "0x402F6C0", VA = "0x184030AC0", Slot = "31")]
	public T HCNFCFFAFEI(Entity NGLCFDBCFFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x402AFF0", Offset = "0x4029BF0", VA = "0x18402AFF0")]
	public bool CBGDEMCKLAL(Entity NGLCFDBCFFC, [In] T CAGOIFBMMMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x402EBF0", Offset = "0x402D7F0", VA = "0x18402EBF0")]
	public bool CGFMGKIMNGI(Entity NGLCFDBCFFC, [In] T CAGOIFBMMMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4031600", Offset = "0x4030200", VA = "0x184031600", Slot = "23")]
	public override bool OKKJPEEAMCN(Entity NGLCFDBCFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x40304A0", Offset = "0x402F0A0", VA = "0x1840304A0", Slot = "24")]
	public override void HCNFCFFAFEI(Entity NGLCFDBCFFC, MLKBLKDDCDI GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x402A9F0", Offset = "0x40295F0", VA = "0x18402A9F0", Slot = "25")]
	public override bool CBGDEMCKLAL(Entity NGLCFDBCFFC, MDEDOBLHNPN CAGOIFBMMMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4031AD0", Offset = "0x40306D0", VA = "0x184031AD0", Slot = "26")]
	public override void PBMNIHKHHKM(LHMPJNKBOBD CDHPFFBOIEG, [Optional] object FBMKGECLCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x40299A0", Offset = "0x40285A0", VA = "0x1840299A0", Slot = "27")]
	public override bool AIIIFAEPLFO(Entity OPHLCCBBKLN, Entity AIFEMCDFFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "28")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x402EAF0", Offset = "0x402D6F0", VA = "0x18402EAF0", Slot = "30")]
	public override string CFHIAEOPNFJ([In] MDEDOBLHNPN FNGJEMBJAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4030EB0", Offset = "0x402FAB0", VA = "0x184030EB0")]
	private bool NKPGMPOIHJL(T CGDBBAILNNN, T CAGOIFBMMMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class BCEMEOBBBNN : AALFNDHKEGH, DEPCKBDOBLK, KNNDAHEBDGA<Entity>, PMJEFJENCPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type AJCKJIKGPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract ICBIMKCLBMN JDIGKPHBDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract IKKJGFAHMPN JPOCEKCGMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int EPEJOBGAFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEF0", Offset = "0x8B9AF0", VA = "0x1808BAEF0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9C0", Offset = "0x8B95C0", VA = "0x1808BA9C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event PKFGDHNMGIF<Entity> FBADBMJIGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68DAC70", Offset = "0x68D9870", VA = "0x1868DAC70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68DABC0", Offset = "0x68D97C0", VA = "0x1868DABC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract bool OKKJPEEAMCN(Entity NGLCFDBCFFC);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract void HCNFCFFAFEI(Entity NGLCFDBCFFC, MLKBLKDDCDI GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool CBGDEMCKLAL(Entity NGLCFDBCFFC, MDEDOBLHNPN CAGOIFBMMMG);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void PBMNIHKHHKM(LHMPJNKBOBD CDHPFFBOIEG, [Optional] object FBMKGECLCCA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract bool AIIIFAEPLFO(Entity OPHLCCBBKLN, Entity AIFEMCDFFGN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void EHHLDMLDHNI(EntityManager NJHBFCFCNCD);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2880C30", Offset = "0x287F830", VA = "0x182880C30")]
	protected void JKDMEIEFANH<T>(Entity NGLCFDBCFFC, [In] T CGDBBAILNNN, [In] T CAGOIFBMMMG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract string CFHIAEOPNFJ([In] MDEDOBLHNPN FNGJEMBJAID);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	protected BCEMEOBBBNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DEPCKBDOBLK : KNNDAHEBDGA<Entity>, PMJEFJENCPC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CAMHNIFIIIP<T> : MPNHIAJCMOH<Entity, T>, KNNDAHEBDGA<Entity>, PMJEFJENCPC, IDisposable, DEPCKBDOBLK where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface AALFNDHKEGH : DEPCKBDOBLK, KNNDAHEBDGA<Entity>, PMJEFJENCPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int EPEJOBGAFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class PJELMMFGHPE
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2CED760", Offset = "0x2CEC360", VA = "0x182CED760")]
	public static T PLGMBGFHHHD<T>(this CAMHNIFIIIP<T> LKOIJCCHEHO, Entity NGLCFDBCFFC, [Optional] T NJMAFDCOBGL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2CED480", Offset = "0x2CEC080", VA = "0x182CED480")]
	public static T BIKHNENFGLC<T>(this KNNDAHEBDGA<Entity> LKOIJCCHEHO, Entity NGLCFDBCFFC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2CED620", Offset = "0x2CEC220", VA = "0x182CED620")]
	public static bool MFIFNAPDHPO<T>(this KNNDAHEBDGA<Entity> LKOIJCCHEHO, Entity NGLCFDBCFFC, [In] T CAGOIFBMMMG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2CED560", Offset = "0x2CEC160", VA = "0x182CED560")]
	public static bool MFIFNAPDHPO<T>(this KNNDAHEBDGA<Entity> LKOIJCCHEHO, Entity NGLCFDBCFFC, NativeArray<T> CAGOIFBMMMG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void PKFGDHNMGIF<TKey>(TKey HAHECKLGOJC, [In] MDEDOBLHNPN CGDBBAILNNN, [In] MDEDOBLHNPN CAGOIFBMMMG);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class EMGFEFHLDGK
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2979550", Offset = "0x2978150", VA = "0x182979550")]
	public static void DOBCDLDNJAI<TKey, T>(this PKFGDHNMGIF<TKey> KFDNNGDEPJB, TKey HAHECKLGOJC, T CGDBBAILNNN, T CAGOIFBMMMG) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LHMPJNKBOBD
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFNEOIKLOCL<TKey, T>(MPNHIAJCMOH<TKey, T> LKOIJCCHEHO, [Optional] object FBMKGECLCCA) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LJALNNPMDGI
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IKKJGFAHMPN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo HOEHHPDLEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int OPIIJFJCLEC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int LBOCLAHFPED
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PMJEFJENCPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type AJCKJIKGPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IKKJGFAHMPN JPOCEKCGMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	ICBIMKCLBMN JDIGKPHBDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int EPEJOBGAFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PBMNIHKHHKM(LHMPJNKBOBD CDHPFFBOIEG, [Optional] object FBMKGECLCCA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KNNDAHEBDGA<TKey> : PMJEFJENCPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event PKFGDHNMGIF<TKey> FBADBMJIGMF;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OKKJPEEAMCN(TKey DPHIOKCFMFC);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HCNFCFFAFEI(TKey DPHIOKCFMFC, MLKBLKDDCDI GLMEMJNJKAN);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CBGDEMCKLAL(TKey DPHIOKCFMFC, MDEDOBLHNPN CAGOIFBMMMG);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AIIIFAEPLFO(TKey OPHLCCBBKLN, TKey AIFEMCDFFGN);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string CFHIAEOPNFJ([In] MDEDOBLHNPN GLMEMJNJKAN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface MPNHIAJCMOH<TKey, T> : KNNDAHEBDGA<TKey>, PMJEFJENCPC, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T HCNFCFFAFEI(TKey DPHIOKCFMFC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class AEOAIPOMKLL
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x31D9640", Offset = "0x31D8240", VA = "0x1831D9640")]
	public static bool KEKFKPJEKCC<TKey, T>(this KNNDAHEBDGA<TKey> LKOIJCCHEHO, TKey DPHIOKCFMFC, [Out] T GLMEMJNJKAN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x31D9020", Offset = "0x31D7C20", VA = "0x1831D9020")]
	public static T HCNFCFFAFEI<T, TKey>(this KNNDAHEBDGA<TKey> LKOIJCCHEHO, TKey DPHIOKCFMFC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x31D82F0", Offset = "0x31D6EF0", VA = "0x1831D82F0")]
	public static bool CBGDEMCKLAL<TKey, T>(this KNNDAHEBDGA<TKey> LKOIJCCHEHO, TKey DPHIOKCFMFC, T CAGOIFBMMMG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x31D8550", Offset = "0x31D7150", VA = "0x1831D8550")]
	public static bool CBGDEMCKLAL<TKey, T>(this KNNDAHEBDGA<TKey> LKOIJCCHEHO, TKey DPHIOKCFMFC, NativeArray<T> CAGOIFBMMMG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface OKKALPEEFFP : IEnumerable<DEPCKBDOBLK>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ICBIMKCLBMN
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int IJOPPGDCKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int AAAJILMMKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type DFKMNPPLBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	DEPCKBDOBLK[] CECAJGPIJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool AEEFOOEELEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) LMCECPBEMHL(Entity NGLCFDBCFFC);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DIAFLGECOHO(Entity NGLCFDBCFFC, (uint order, uint change) IDPOJNOELJM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class FOFGOCFBOFO : OKKALPEEFFP, IEnumerable<DEPCKBDOBLK>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<DEPCKBDOBLK> AJKMEBCLHAE;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x68DB2A0", Offset = "0x68D9EA0", VA = "0x1868DB2A0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public DEPCKBDOBLK ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68DADA0", Offset = "0x68D99A0", VA = "0x1868DADA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68DB2E0", Offset = "0x68D9EE0", VA = "0x1868DB2E0")]
	public FOFGOCFBOFO(IEnumerable<ICBIMKCLBMN> LHHCCEAELHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68DAE00", Offset = "0x68D9A00", VA = "0x1868DAE00")]
	private List<DEPCKBDOBLK> LACHBOGKLAM(IEnumerable<ICBIMKCLBMN> LHHCCEAELHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68DAD20", Offset = "0x68D9920", VA = "0x1868DAD20", Slot = "4")]
	public IEnumerator<DEPCKBDOBLK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68DAD20", Offset = "0x68D9920", VA = "0x1868DAD20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct EFPMEGLJAGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type EDAMDBJJJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string GFLNGGKHEOH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xA93C90", Offset = "0xA92890", VA = "0x180A93C90")]
	public EFPMEGLJAGG(Type EDAMDBJJJMM, string GFLNGGKHEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct GAFGIJDLHMM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type EDAMDBJJJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string GFLNGGKHEOH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xA93C90", Offset = "0xA92890", VA = "0x180A93C90")]
	public GAFGIJDLHMM(Type EDAMDBJJJMM, string GFLNGGKHEOH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3C68750", Offset = "0x3C67350", VA = "0x183C68750")]
	public static EFPMEGLJAGG EPDHMAMOHLH(GAFGIJDLHMM<T> JOKBGOINBCP)
	{
		return default(EFPMEGLJAGG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum GBJGNBGJOEO
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
public class MOPBIGCLMGE
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public MOPBIGCLMGE()
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
