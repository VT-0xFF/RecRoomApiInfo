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
	[Cpp2IlInjected.Address(RVA = "0x3BE7060", Offset = "0x3BE5A60", VA = "0x183BE7060")]
	public FLIOGKDFLPI(string BHFPKCCDEEC, MHKPBJKAEOL IDOOJPJNKLC, FieldInfo GNALKPBELNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3BE6C10", Offset = "0x3BE5610", VA = "0x183BE6C10", Slot = "25")]
	public override bool OLOHHMDPKEO(Entity IBKNLGIDEBH, JHKEOJJDFBK BOKHJAMHCIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class FOLGLCGBGCK<T> : AFAFIFEJLDB<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7060", Offset = "0x3BE5A60", VA = "0x183BE7060")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C5E320", Offset = "0x3C5CD20", VA = "0x183C5E320", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override MHKPBJKAEOL KDMNFGPMMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855340", VA = "0x180856940", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override GNPCNPDIEFC HLNCOJDLIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x91F460", Offset = "0x91DE60", VA = "0x18091F460", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo KAFKLNKHNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8555C0", VA = "0x180856BC0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int FMFNPNCBHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x870760", Offset = "0x86F160", VA = "0x180870760", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int NCEGMIEOAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8626D0", Offset = "0x8610D0", VA = "0x1808626D0", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager KLCONNELEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3C564B0", Offset = "0x3C54EB0", VA = "0x183C564B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C5E5F0", Offset = "0x3C5CFF0", VA = "0x183C5E5F0")]
	internal AFAFIFEJLDB(string BHFPKCCDEEC, MHKPBJKAEOL IDOOJPJNKLC, FieldInfo GNALKPBELNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3C56600", Offset = "0x3C55000", VA = "0x183C56600", Slot = "29")]
	public override void HMCGAKKBHMB(EntityManager DIKLEKJGKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C58B60", Offset = "0x3C57560", VA = "0x183C58B60")]
	public AFAFIFEJLDB<T> KPBLPCLNAJN(FIAJJFOMPJG AGBOINALEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C564D0", Offset = "0x3C54ED0", VA = "0x183C564D0")]
	public AFAFIFEJLDB<T> GHAGPBINIBO(FPLDOGOJNDK JBKCCHELPMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C55C40", Offset = "0x3C54640", VA = "0x183C55C40")]
	public AFAFIFEJLDB<T> BKGFKBKFKEF(FPLDOGOJNDK MJPEHIGPDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C58470", Offset = "0x3C56E70", VA = "0x183C58470", Slot = "31")]
	public T JMJOGDIBBHK(Entity IBKNLGIDEBH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3C59F80", Offset = "0x3C58980", VA = "0x183C59F80")]
	public bool OLOHHMDPKEO(Entity IBKNLGIDEBH, [In] T BOKHJAMHCIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3C564F0", Offset = "0x3C54EF0", VA = "0x183C564F0")]
	public bool GKGIADFDLJP(Entity IBKNLGIDEBH, [In] T BOKHJAMHCIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3C58E40", Offset = "0x3C57840", VA = "0x183C58E40", Slot = "23")]
	public override bool LNFEOGNEOOI(Entity IBKNLGIDEBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3C57A60", Offset = "0x3C56460", VA = "0x183C57A60", Slot = "24")]
	public override void JMJOGDIBBHK(Entity IBKNLGIDEBH, JBCMKOAFGAE JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3C5A760", Offset = "0x3C59160", VA = "0x183C5A760", Slot = "25")]
	public override bool OLOHHMDPKEO(Entity IBKNLGIDEBH, JHKEOJJDFBK BOKHJAMHCIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C56BA0", Offset = "0x3C555A0", VA = "0x183C56BA0", Slot = "26")]
	public override void IPNLIMNPFFJ(EOIGLOCPGFD KJMOKGIMGAD, [Optional] object CNBJCJOALNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3C57160", Offset = "0x3C55B60", VA = "0x183C57160", Slot = "27")]
	public override bool JGFBHDIGANM(Entity BCCFKHCCLFG, Entity HKKDPGGNNBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "28")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C55CC0", Offset = "0x3C546C0", VA = "0x183C55CC0", Slot = "30")]
	public override string DKCCILKAADO([In] JHKEOJJDFBK BMFCNOKKDAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3C58B00", Offset = "0x3C57500", VA = "0x183C58B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851290", VA = "0x180852890")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KMFNJHJINML
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8CDB30", Offset = "0x8CC530", VA = "0x1808CDB30", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9C0", Offset = "0x8CC3C0", VA = "0x1808CD9C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KNNCFDGOEJN<Entity> LPCFLPGJJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68E1A60", Offset = "0x68E0460", VA = "0x1868E1A60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68E1B10", Offset = "0x68E0510", VA = "0x1868E1B10", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B22890", Offset = "0x2B21290", VA = "0x182B22890")]
	protected void LNIFCDLLNDB<T>(Entity IBKNLGIDEBH, [In] T EGGHMOKFNFD, [In] T BOKHJAMHCIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract string DKCCILKAADO([In] JHKEOJJDFBK BMFCNOKKDAM);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BF8940", Offset = "0x2BF7340", VA = "0x182BF8940")]
	public static T GJPKPNDNNIC<T>(this MGJEMJGMCNG<T> FMACLHMOMLJ, Entity IBKNLGIDEBH, [Optional] T LIAHLPBCKNO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2BF8D00", Offset = "0x2BF7700", VA = "0x182BF8D00")]
	public static T POIMHEEJLCG<T>(this GEAMBFFHPPA<Entity> FMACLHMOMLJ, Entity IBKNLGIDEBH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2BF8B50", Offset = "0x2BF7550", VA = "0x182BF8B50")]
	public static bool HEOMLDPCKGB<T>(this GEAMBFFHPPA<Entity> FMACLHMOMLJ, Entity IBKNLGIDEBH, [In] T BOKHJAMHCIH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2BF8AB0", Offset = "0x2BF74B0", VA = "0x182BF8AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x28C81D0", Offset = "0x28C6BD0", VA = "0x1828C81D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C31BE0", Offset = "0x2C305E0", VA = "0x182C31BE0")]
	public static bool FFKNBABIJFJ<TKey, T>(this GEAMBFFHPPA<TKey> FMACLHMOMLJ, TKey NDDCLPHCEEO, [Out] T JMDCGOKJIDA) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2C32140", Offset = "0x2C30B40", VA = "0x182C32140")]
	public static T JMJOGDIBBHK<T, TKey>(this GEAMBFFHPPA<TKey> FMACLHMOMLJ, TKey NDDCLPHCEEO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2C32890", Offset = "0x2C31290", VA = "0x182C32890")]
	public static bool OLOHHMDPKEO<TKey, T>(this GEAMBFFHPPA<TKey> FMACLHMOMLJ, TKey NDDCLPHCEEO, T BOKHJAMHCIH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C32AF0", Offset = "0x2C314F0", VA = "0x182C32AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68E1980", Offset = "0x68E0380", VA = "0x1868E1980", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public FFENPHHDHJB NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68E19C0", Offset = "0x68E03C0", VA = "0x1868E19C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68E1A20", Offset = "0x68E0420", VA = "0x1868E1A20")]
	public DJKNGPKNGDH(IEnumerable<MHKPBJKAEOL> HGKBHONGCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68E14E0", Offset = "0x68DFEE0", VA = "0x1868E14E0")]
	private List<FFENPHHDHJB> HKFIBHPBMKJ(IEnumerable<MHKPBJKAEOL> HGKBHONGCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68E1460", Offset = "0x68DFE60", VA = "0x1868E1460", Slot = "4")]
	public IEnumerator<FFENPHHDHJB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68E1460", Offset = "0x68DFE60", VA = "0x1868E1460", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0xAB1600", Offset = "0xAB0000", VA = "0x180AB1600")]
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
	[Cpp2IlInjected.Address(RVA = "0xAB1600", Offset = "0xAB0000", VA = "0x180AB1600")]
	public MNECACGPLAM(Type GJHDEKHGLOH, string BHFPKCCDEEC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x44AC2D0", Offset = "0x44AACD0", VA = "0x1844AC2D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
