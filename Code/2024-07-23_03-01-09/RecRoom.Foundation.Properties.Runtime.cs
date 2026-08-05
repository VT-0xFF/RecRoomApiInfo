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
public sealed class FLIOGKDFLPI<TContainer, TField> : AFAFIFEJLDB<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3C10710", Offset = "0x3C0F910", VA = "0x183C10710")]
	public FLIOGKDFLPI(string BHFPKCCDEEC, MHKPBJKAEOL IDOOJPJNKLC, FieldInfo GNALKPBELNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3C102C0", Offset = "0x3C0F4C0", VA = "0x183C102C0", Slot = "25")]
	public override bool OLOHHMDPKEO(Entity IBKNLGIDEBH, JHKEOJJDFBK BOKHJAMHCIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class FOLGLCGBGCK<T> : AFAFIFEJLDB<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3C10710", Offset = "0x3C0F910", VA = "0x183C10710")]
	public FOLGLCGBGCK(string BHFPKCCDEEC, MHKPBJKAEOL IDOOJPJNKLC, FieldInfo GNALKPBELNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class AFAFIFEJLDB<T> : GEJHJJGGHBM, MGJEMJGMCNG<T>, IGFJFIIBDOJ<Entity, T>, GEAMBFFHPPA<Entity>, MCDMJOHLAHJ, IDisposable, FFENPHHDHJB, GNPCNPDIEFC where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool FIAJJFOMPJG(Entity IBKNLGIDEBH, [In] T BOKHJAMHCIH);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void FPLDOGOJNDK(Entity IBKNLGIDEBH, [In] T EGGHMOKFNFD, [In] T BOKHJAMHCIH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly MHKPBJKAEOL IDOOJPJNKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly FieldInfo GNALKPBELNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected readonly int ILLCBJEFNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	protected readonly int PENDBLHFGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int ECGAAJFODGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private FIAJJFOMPJG AGBOINALEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private FPLDOGOJNDK JBKCCHELPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private FPLDOGOJNDK MJPEHIGPDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World FIFOANMDKIF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type EPCABOEGHGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3C711B0", Offset = "0x3C703B0", VA = "0x183C711B0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override MHKPBJKAEOL KDMNFGPMMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855B40", VA = "0x180856940", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override GNPCNPDIEFC HLNCOJDLIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x920210", Offset = "0x91F410", VA = "0x180920210", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo KAFKLNKHNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x855DC0", VA = "0x180856BC0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int FMFNPNCBHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x870670", Offset = "0x86F870", VA = "0x180870670", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int NCEGMIEOAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8626D0", Offset = "0x8618D0", VA = "0x1808626D0", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager KLCONNELEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3C69340", Offset = "0x3C68540", VA = "0x183C69340")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C71480", Offset = "0x3C70680", VA = "0x183C71480")]
	internal AFAFIFEJLDB(string BHFPKCCDEEC, MHKPBJKAEOL IDOOJPJNKLC, FieldInfo GNALKPBELNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3C69490", Offset = "0x3C68690", VA = "0x183C69490", Slot = "29")]
	public override void HMCGAKKBHMB(EntityManager DIKLEKJGKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C6B9F0", Offset = "0x3C6ABF0", VA = "0x183C6B9F0")]
	public AFAFIFEJLDB<T> KPBLPCLNAJN(FIAJJFOMPJG AGBOINALEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C69360", Offset = "0x3C68560", VA = "0x183C69360")]
	public AFAFIFEJLDB<T> GHAGPBINIBO(FPLDOGOJNDK JBKCCHELPMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C68AD0", Offset = "0x3C67CD0", VA = "0x183C68AD0")]
	public AFAFIFEJLDB<T> BKGFKBKFKEF(FPLDOGOJNDK MJPEHIGPDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C6B300", Offset = "0x3C6A500", VA = "0x183C6B300", Slot = "31")]
	public T JMJOGDIBBHK(Entity IBKNLGIDEBH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3C6CE10", Offset = "0x3C6C010", VA = "0x183C6CE10")]
	public bool OLOHHMDPKEO(Entity IBKNLGIDEBH, [In] T BOKHJAMHCIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3C69380", Offset = "0x3C68580", VA = "0x183C69380")]
	public bool GKGIADFDLJP(Entity IBKNLGIDEBH, [In] T BOKHJAMHCIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3C6BCD0", Offset = "0x3C6AED0", VA = "0x183C6BCD0", Slot = "23")]
	public override bool LNFEOGNEOOI(Entity IBKNLGIDEBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A8F0", Offset = "0x3C69AF0", VA = "0x183C6A8F0", Slot = "24")]
	public override void JMJOGDIBBHK(Entity IBKNLGIDEBH, JBCMKOAFGAE JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D5F0", Offset = "0x3C6C7F0", VA = "0x183C6D5F0", Slot = "25")]
	public override bool OLOHHMDPKEO(Entity IBKNLGIDEBH, JHKEOJJDFBK BOKHJAMHCIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C69A30", Offset = "0x3C68C30", VA = "0x183C69A30", Slot = "26")]
	public override void IPNLIMNPFFJ(EOIGLOCPGFD KJMOKGIMGAD, [Optional] object CNBJCJOALNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3C69FF0", Offset = "0x3C691F0", VA = "0x183C69FF0", Slot = "27")]
	public override bool JGFBHDIGANM(Entity BCCFKHCCLFG, Entity HKKDPGGNNBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "28")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C68B50", Offset = "0x3C67D50", VA = "0x183C68B50", Slot = "30")]
	public override string DKCCILKAADO([In] JHKEOJJDFBK BMFCNOKKDAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3C6B990", Offset = "0x3C6AB90", VA = "0x183C6B990")]
	private bool KDJLOMMBFFK(T EGGHMOKFNFD, T BOKHJAMHCIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class GEJHJJGGHBM : NHAOFNOJEMI, FFENPHHDHJB, GEAMBFFHPPA<Entity>, MCDMJOHLAHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type EPCABOEGHGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract MHKPBJKAEOL KDMNFGPMMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract GNPCNPDIEFC HLNCOJDLIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851A90", VA = "0x180852890")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KMFNJHJINML
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9B0", Offset = "0x8CCBB0", VA = "0x1808CD9B0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8CD840", Offset = "0x8CCA40", VA = "0x1808CD840", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KNNCFDGOEJN<Entity> LPCFLPGJJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68FBD50", Offset = "0x68FAF50", VA = "0x1868FBD50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68FBE00", Offset = "0x68FB000", VA = "0x1868FBE00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract bool LNFEOGNEOOI(Entity IBKNLGIDEBH);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract void JMJOGDIBBHK(Entity IBKNLGIDEBH, JBCMKOAFGAE JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool OLOHHMDPKEO(Entity IBKNLGIDEBH, JHKEOJJDFBK BOKHJAMHCIH);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void IPNLIMNPFFJ(EOIGLOCPGFD KJMOKGIMGAD, [Optional] object CNBJCJOALNK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract bool JGFBHDIGANM(Entity BCCFKHCCLFG, Entity HKKDPGGNNBK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void HMCGAKKBHMB(EntityManager DIKLEKJGKDE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2B31000", Offset = "0x2B30200", VA = "0x182B31000")]
	protected void LNIFCDLLNDB<T>(Entity IBKNLGIDEBH, [In] T EGGHMOKFNFD, [In] T BOKHJAMHCIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract string DKCCILKAADO([In] JHKEOJJDFBK BMFCNOKKDAM);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	protected GEJHJJGGHBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FFENPHHDHJB : GEAMBFFHPPA<Entity>, MCDMJOHLAHJ, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MGJEMJGMCNG<T> : IGFJFIIBDOJ<Entity, T>, GEAMBFFHPPA<Entity>, MCDMJOHLAHJ, IDisposable, FFENPHHDHJB where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface NHAOFNOJEMI : FFENPHHDHJB, GEAMBFFHPPA<Entity>, MCDMJOHLAHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int KMFNJHJINML
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
public static class KGMLEBODKKF
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2C07350", Offset = "0x2C06550", VA = "0x182C07350")]
	public static T GJPKPNDNNIC<T>(this MGJEMJGMCNG<T> FMACLHMOMLJ, Entity IBKNLGIDEBH, [Optional] T LIAHLPBCKNO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2C07710", Offset = "0x2C06910", VA = "0x182C07710")]
	public static T POIMHEEJLCG<T>(this GEAMBFFHPPA<Entity> FMACLHMOMLJ, Entity IBKNLGIDEBH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C07560", Offset = "0x2C06760", VA = "0x182C07560")]
	public static bool HEOMLDPCKGB<T>(this GEAMBFFHPPA<Entity> FMACLHMOMLJ, Entity IBKNLGIDEBH, [In] T BOKHJAMHCIH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2C074C0", Offset = "0x2C066C0", VA = "0x182C074C0")]
	public static bool HEOMLDPCKGB<T>(this GEAMBFFHPPA<Entity> FMACLHMOMLJ, Entity IBKNLGIDEBH, NativeArray<T> BOKHJAMHCIH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void KNNCFDGOEJN<TKey>(TKey MEAFIMADMKA, [In] JHKEOJJDFBK EGGHMOKFNFD, [In] JHKEOJJDFBK BOKHJAMHCIH);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BJPBEEAPHIM
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x28D6680", Offset = "0x28D5880", VA = "0x1828D6680")]
	public static void APPOJKGPLJE<TKey, T>(this KNNCFDGOEJN<TKey> DAKLDBBBMLH, TKey MEAFIMADMKA, T EGGHMOKFNFD, T BOKHJAMHCIH) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EOIGLOCPGFD
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDGIMNEBPHL<TKey, T>(IGFJFIIBDOJ<TKey, T> FMACLHMOMLJ, [Optional] object CNBJCJOALNK) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PJNKEFKNNKE
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GNPCNPDIEFC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo OBCABAIIDEG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int FGGMJJKKBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int LIFKLMGEOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MCDMJOHLAHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type EPCABOEGHGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GNPCNPDIEFC HLNCOJDLIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MHKPBJKAEOL KDMNFGPMMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int KMFNJHJINML
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IPNLIMNPFFJ(EOIGLOCPGFD KJMOKGIMGAD, [Optional] object CNBJCJOALNK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GEAMBFFHPPA<TKey> : MCDMJOHLAHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event KNNCFDGOEJN<TKey> LPCFLPGJJLP;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LNFEOGNEOOI(TKey NDDCLPHCEEO);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMJOGDIBBHK(TKey NDDCLPHCEEO, JBCMKOAFGAE JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OLOHHMDPKEO(TKey NDDCLPHCEEO, JHKEOJJDFBK BOKHJAMHCIH);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JGFBHDIGANM(TKey BCCFKHCCLFG, TKey HKKDPGGNNBK);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string DKCCILKAADO([In] JHKEOJJDFBK JMDCGOKJIDA);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface IGFJFIIBDOJ<TKey, T> : GEAMBFFHPPA<TKey>, MCDMJOHLAHJ, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T JMJOGDIBBHK(TKey NDDCLPHCEEO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class MNIPJPLNIFL
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2C405F0", Offset = "0x2C3F7F0", VA = "0x182C405F0")]
	public static bool FFKNBABIJFJ<TKey, T>(this GEAMBFFHPPA<TKey> FMACLHMOMLJ, TKey NDDCLPHCEEO, [Out] T JMDCGOKJIDA) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2C40B50", Offset = "0x2C3FD50", VA = "0x182C40B50")]
	public static T JMJOGDIBBHK<T, TKey>(this GEAMBFFHPPA<TKey> FMACLHMOMLJ, TKey NDDCLPHCEEO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2C412A0", Offset = "0x2C404A0", VA = "0x182C412A0")]
	public static bool OLOHHMDPKEO<TKey, T>(this GEAMBFFHPPA<TKey> FMACLHMOMLJ, TKey NDDCLPHCEEO, T BOKHJAMHCIH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C41500", Offset = "0x2C40700", VA = "0x182C41500")]
	public static bool OLOHHMDPKEO<TKey, T>(this GEAMBFFHPPA<TKey> FMACLHMOMLJ, TKey NDDCLPHCEEO, NativeArray<T> BOKHJAMHCIH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface NNPEEOGONEA : IEnumerable<FFENPHHDHJB>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MHKPBJKAEOL
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int DGFJABGDMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int PPGCCPGBJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type HJHGDHHCGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	FFENPHHDHJB[] OLEHCIIPMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PJHDFDKAFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) GPKBJEJNHHG(Entity IBKNLGIDEBH);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BAMNKHOBOPD(Entity IBKNLGIDEBH, (uint order, uint change) DMDAEILPBHA);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class DJKNGPKNGDH : NNPEEOGONEA, IEnumerable<FFENPHHDHJB>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<FFENPHHDHJB> IGGGHJCMBDH;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x68FBC70", Offset = "0x68FAE70", VA = "0x1868FBC70", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public FFENPHHDHJB NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68FBCB0", Offset = "0x68FAEB0", VA = "0x1868FBCB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68FBD10", Offset = "0x68FAF10", VA = "0x1868FBD10")]
	public DJKNGPKNGDH(IEnumerable<MHKPBJKAEOL> HGKBHONGCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68FB7D0", Offset = "0x68FA9D0", VA = "0x1868FB7D0")]
	private List<FFENPHHDHJB> HKFIBHPBMKJ(IEnumerable<MHKPBJKAEOL> HGKBHONGCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68FB750", Offset = "0x68FA950", VA = "0x1868FB750", Slot = "4")]
	public IEnumerator<FFENPHHDHJB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68FB750", Offset = "0x68FA950", VA = "0x1868FB750", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IFOINEFCHDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type GJHDEKHGLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string BHFPKCCDEEC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xAB26B0", Offset = "0xAB18B0", VA = "0x180AB26B0")]
	public IFOINEFCHDG(Type GJHDEKHGLOH, string BHFPKCCDEEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct MNECACGPLAM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type GJHDEKHGLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string BHFPKCCDEEC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xAB26B0", Offset = "0xAB18B0", VA = "0x180AB26B0")]
	public MNECACGPLAM(Type GJHDEKHGLOH, string BHFPKCCDEEC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x44C1A70", Offset = "0x44C0C70", VA = "0x1844C1A70")]
	public static IFOINEFCHDG AANNKILDHLM(MNECACGPLAM<T> CJJOCFAPEJO)
	{
		return default(IFOINEFCHDG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum GJILGMOPJIF
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
public class FFCOGINOOIO
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public FFCOGINOOIO()
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
