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
public interface KKBAONGPNLN : IEnumerable<PDHNEODNMGH>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PDHNEODNMGH : MPKLCNEHKHD<Entity>, FHDDOGHNDOM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NGJFHDHNHOF<T> : HHLAEAEOPLH<Entity, T>, MPKLCNEHKHD<Entity>, FHDDOGHNDOM, IDisposable, PDHNEODNMGH where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface KCBLAIMHKLN : PDHNEODNMGH, MPKLCNEHKHD<Entity>, FHDDOGHNDOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	new int ABBFGAAHDHB
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
public static class AJKMDDFOFAG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A30D40", Offset = "0x2A2FD40", VA = "0x182A30D40")]
	public static T FAEFMOGHDHA<T>(this NGJFHDHNHOF<T> FJCNAJDOIIE, Entity OIDNDCEGFCN, [Optional] T AFGLNBMEDLH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A30C40", Offset = "0x2A2FC40", VA = "0x182A30C40")]
	public static T CHKCIEMLHMA<T>(this MPKLCNEHKHD<Entity> FJCNAJDOIIE, Entity OIDNDCEGFCN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A30EA0", Offset = "0x2A2FEA0", VA = "0x182A30EA0")]
	public static bool GGOJLLGJIAD<T>(this MPKLCNEHKHD<Entity> FJCNAJDOIIE, Entity OIDNDCEGFCN, in T MNIFIBOADMC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AOIEHFJMOLK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int COOFDOJEGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int NHGLEOPBBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Type OKKGJLJGJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	PDHNEODNMGH[] EFALADHKMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) FMDCDKABMBO(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FHNLJNFGLBO(Entity OIDNDCEGFCN, (uint order, uint change) DFLAEIEBLPA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class GCEHPFDBNEG : KCBLAIMHKLN, PDHNEODNMGH, MPKLCNEHKHD<Entity>, FHDDOGHNDOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type FHOHNKIJHHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract AOIEHFJMOLK DEOOHBLEEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract KDKGMHHCLML EGBGJLPAEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string EDEDJHKMHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x92E3F0", Offset = "0x92D3F0", VA = "0x18092E3F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ABBFGAAHDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA74E00", Offset = "0xA73E00", VA = "0x180A74E00", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xBE6AC0", Offset = "0xBE5AC0", VA = "0x180BE6AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event JDKKBIILPAB<Entity> LFECNCFLJKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72C4930", Offset = "0x72C3930", VA = "0x1872C4930", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72C49D0", Offset = "0x72C39D0", VA = "0x1872C49D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool GDIDPFMABMA(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool MCPBCLCEEIM(Entity OIDNDCEGFCN, in object MNIFIBOADMC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void EAOPAIAIDNN(Entity OIDNDCEGFCN, LJMGEKAHOAN CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool FNPACIDIMCD(Entity OIDNDCEGFCN, HJFPGFBDEEK MNIFIBOADMC);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract bool GOFENOMCKGB(Entity CDBHHMNALJL, HJFPGFBDEEK MNIFIBOADMC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void DINLJJHOGIF(DPKDHFMGAHC FMEKJKNILLB, [Optional] object HBLIBBFCHOD);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract bool ICJGLKHKIDI(Entity OPPNHDACHEH, Entity GDILAPBOMGI);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	public abstract void JFGMJMMFADK(EntityManager DKCFIIHAPKN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x13ED610", Offset = "0x13EC610", VA = "0x1813ED610")]
	protected void CIFFEFKIGCM<T>(Entity OIDNDCEGFCN, in T GCOKPOEHMJB, in T MNIFIBOADMC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	public abstract string GKHONALHKPP(in HJFPGFBDEEK EPGOGIOOMIG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	protected GCEHPFDBNEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class GHGAIGEBNGH<T> : GCEHPFDBNEG, NGJFHDHNHOF<T>, HHLAEAEOPLH<Entity, T>, MPKLCNEHKHD<Entity>, FHDDOGHNDOM, IDisposable, PDHNEODNMGH, KDKGMHHCLML where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate bool HGGHPBLMDLA(Entity OIDNDCEGFCN, in T MNIFIBOADMC);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void AFLNCAHEONL(Entity OIDNDCEGFCN, in T GCOKPOEHMJB, in T MNIFIBOADMC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly AOIEHFJMOLK KAMALCLMCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo DBAELCMMNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int BKAKEAMNOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int OBKOEDDJOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int GFFJJOEGODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HGGHPBLMDLA AIIHHDFIJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private AFLNCAHEONL JDMGBHHKOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AFLNCAHEONL KGLOKIGCIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World JMDHEINCIFM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override Type FHOHNKIJHHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5C686B0", Offset = "0x5C676B0", VA = "0x185C686B0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override AOIEHFJMOLK DEOOHBLEEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x91FD50", Offset = "0x91ED50", VA = "0x18091FD50", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override KDKGMHHCLML EGBGJLPAEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xACC050", Offset = "0xACB050", VA = "0x180ACC050", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FieldInfo KEPDOEDLBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private int PPPHOPGKOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCE0F00", Offset = "0xCDFF00", VA = "0x180CE0F00", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int PEJCBCOEJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xADE620", Offset = "0xADD620", VA = "0x180ADE620", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EntityManager DDMBMPJOHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x343B1E0", Offset = "0x343A1E0", VA = "0x18343B1E0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C6FCD0", Offset = "0x5C6ECD0", VA = "0x185C6FCD0")]
	public GHGAIGEBNGH(string OKONKHNEMOO, AOIEHFJMOLK KAMALCLMCAH, FieldInfo DBAELCMMNEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x343B000", Offset = "0x343A000", VA = "0x18343B000", Slot = "33")]
	public override void JFGMJMMFADK(EntityManager DKCFIIHAPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3439ED0", Offset = "0x3438ED0", VA = "0x183439ED0")]
	public GHGAIGEBNGH<T> CBNGJFEINCH(HGGHPBLMDLA AIIHHDFIJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x343B030", Offset = "0x343A030", VA = "0x18343B030")]
	public GHGAIGEBNGH<T> KAALHCAOPFC(AFLNCAHEONL JDMGBHHKOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x343A170", Offset = "0x3439170", VA = "0x18343A170")]
	public GHGAIGEBNGH<T> FNJDKECMJOA(AFLNCAHEONL KGLOKIGCIGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3439FA0", Offset = "0x3438FA0", VA = "0x183439FA0", Slot = "35")]
	public T EAOPAIAIDNN(Entity OIDNDCEGFCN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5C6BA00", Offset = "0x5C6AA00", VA = "0x185C6BA00")]
	public bool FNPACIDIMCD(Entity OIDNDCEGFCN, in T MNIFIBOADMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x343ACB0", Offset = "0x3439CB0", VA = "0x18343ACB0")]
	public bool GOFENOMCKGB(Entity OIDNDCEGFCN, in T MNIFIBOADMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x343AAB0", Offset = "0x3439AB0", VA = "0x18343AAB0", Slot = "25")]
	public override bool GDIDPFMABMA(Entity OIDNDCEGFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x343B050", Offset = "0x343A050", VA = "0x18343B050", Slot = "26")]
	public override bool MCPBCLCEEIM(Entity OIDNDCEGFCN, in object MNIFIBOADMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x343A0F0", Offset = "0x34390F0", VA = "0x18343A0F0", Slot = "27")]
	public override void EAOPAIAIDNN(Entity OIDNDCEGFCN, LJMGEKAHOAN CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x343AA20", Offset = "0x3439A20", VA = "0x18343AA20", Slot = "28")]
	public override bool FNPACIDIMCD(Entity OIDNDCEGFCN, HJFPGFBDEEK MNIFIBOADMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x343ACF0", Offset = "0x3439CF0", VA = "0x18343ACF0", Slot = "29")]
	public override bool GOFENOMCKGB(Entity OIDNDCEGFCN, HJFPGFBDEEK MNIFIBOADMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3439EF0", Offset = "0x3438EF0", VA = "0x183439EF0", Slot = "30")]
	public override void DINLJJHOGIF(DPKDHFMGAHC FMEKJKNILLB, [Optional] object HBLIBBFCHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x343AED0", Offset = "0x3439ED0", VA = "0x18343AED0", Slot = "31")]
	public override bool ICJGLKHKIDI(Entity OPPNHDACHEH, Entity GDILAPBOMGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "32")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5C6E2C0", Offset = "0x5C6D2C0", VA = "0x185C6E2C0", Slot = "34")]
	public override string GKHONALHKPP(in HJFPGFBDEEK EPGOGIOOMIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x343AFB0", Offset = "0x3439FB0", VA = "0x18343AFB0")]
	private bool IFDICNKLMIJ(ref T GCOKPOEHMJB, ref T MNIFIBOADMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x343B200", Offset = "0x343A200", VA = "0x18343B200", Slot = "36")]
	private bool MHNKJLDGLHA(Entity CDBHHMNALJL, in T MNIFIBOADMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x343B230", Offset = "0x343A230", VA = "0x18343B230", Slot = "37")]
	private bool ONFBFGNDJDL(Entity CDBHHMNALJL, in T MNIFIBOADMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void JDKKBIILPAB<TKey>(TKey DCGPCJKHCOO, in HJFPGFBDEEK GCOKPOEHMJB, in HJFPGFBDEEK MNIFIBOADMC);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FBBHINOOHKP
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1E17160", Offset = "0x1E16160", VA = "0x181E17160")]
	public static void GEHFLMKLAJC<TKey, T>(this JDKKBIILPAB<TKey> KHGAJAOMHOH, TKey DCGPCJKHCOO, T GCOKPOEHMJB, T MNIFIBOADMC) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DPKDHFMGAHC
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IDFAAGDMHKP<TKey, T>(HHLAEAEOPLH<TKey, T> FJCNAJDOIIE, [Optional] object HBLIBBFCHOD) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OKPNBONOMMN
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IDFAAGDMHKP(FHDDOGHNDOM FJCNAJDOIIE, in HJFPGFBDEEK CKMKMNKGMMC, [Optional] object HBLIBBFCHOD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KDKGMHHCLML
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FieldInfo KOPHJGIJOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int JGOONMMKCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int JELHAAPPBKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FHDDOGHNDOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string EDEDJHKMHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Type FHOHNKIJHHO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	KDKGMHHCLML EGBGJLPAEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	AOIEHFJMOLK DEOOHBLEEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int ABBFGAAHDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DINLJJHOGIF(DPKDHFMGAHC FMEKJKNILLB, [Optional] object HBLIBBFCHOD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MPKLCNEHKHD<TKey> : FHDDOGHNDOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event JDKKBIILPAB<TKey> LFECNCFLJKF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GDIDPFMABMA(TKey CDBHHMNALJL);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MCPBCLCEEIM(TKey CDBHHMNALJL, in object MNIFIBOADMC);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EAOPAIAIDNN(TKey CDBHHMNALJL, LJMGEKAHOAN CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FNPACIDIMCD(TKey CDBHHMNALJL, HJFPGFBDEEK MNIFIBOADMC);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GOFENOMCKGB(TKey CDBHHMNALJL, HJFPGFBDEEK MNIFIBOADMC);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ICJGLKHKIDI(TKey OPPNHDACHEH, TKey GDILAPBOMGI);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string GKHONALHKPP(in HJFPGFBDEEK CKMKMNKGMMC);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface HHLAEAEOPLH<TKey, T> : MPKLCNEHKHD<TKey>, FHDDOGHNDOM, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T EAOPAIAIDNN(TKey CDBHHMNALJL);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNPACIDIMCD(TKey CDBHHMNALJL, in T MNIFIBOADMC);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GOFENOMCKGB(TKey CDBHHMNALJL, in T MNIFIBOADMC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OCKEKNLNBJO
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x29277B0", Offset = "0x29267B0", VA = "0x1829277B0")]
	public static bool PPJKMMAHKMD<TKey, T>(this MPKLCNEHKHD<TKey> FJCNAJDOIIE, TKey CDBHHMNALJL, out T CKMKMNKGMMC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2925B90", Offset = "0x2924B90", VA = "0x182925B90")]
	public static T EAOPAIAIDNN<T, TKey>(this MPKLCNEHKHD<TKey> FJCNAJDOIIE, TKey CDBHHMNALJL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29267B0", Offset = "0x29257B0", VA = "0x1829267B0")]
	public static bool FNPACIDIMCD<TKey, T>(this MPKLCNEHKHD<TKey> FJCNAJDOIIE, TKey CDBHHMNALJL, T MNIFIBOADMC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29270B0", Offset = "0x29260B0", VA = "0x1829270B0")]
	public static bool GOFENOMCKGB<TKey, T>(this MPKLCNEHKHD<TKey> FJCNAJDOIIE, TKey CDBHHMNALJL, T MNIFIBOADMC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct EOOMHOMHJOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly Type PAAIPMKHLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly string OKONKHNEMOO;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xB2E3C0", Offset = "0xB2D3C0", VA = "0x180B2E3C0")]
	public EOOMHOMHJOF(Type PAAIPMKHLAH, string OKONKHNEMOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BNAHOABKGKK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly Type PAAIPMKHLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly string OKONKHNEMOO;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xB2E3C0", Offset = "0xB2D3C0", VA = "0x180B2E3C0")]
	public BNAHOABKGKK(Type PAAIPMKHLAH, string OKONKHNEMOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2640770", Offset = "0x263F770", VA = "0x182640770")]
	public static EOOMHOMHJOF DAADMCHNDNG(BNAHOABKGKK<T> EGHHOHEPHAA)
	{
		return default(EOOMHOMHJOF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum PBHEJOGCIML
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
public class NPEHKOEEIIL : KKBAONGPNLN, IEnumerable<PDHNEODNMGH>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<PDHNEODNMGH> ENODPKBJJOL;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72C4AD0", Offset = "0x72C3AD0", VA = "0x1872C4AD0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PDHNEODNMGH IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72C4A70", Offset = "0x72C3A70", VA = "0x1872C4A70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x72C5080", Offset = "0x72C4080", VA = "0x1872C5080")]
	public NPEHKOEEIIL(IEnumerable<AOIEHFJMOLK> DEPOGKIILMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72C4B10", Offset = "0x72C3B10", VA = "0x1872C4B10")]
	private List<PDHNEODNMGH> GMLIONECFMG(IEnumerable<AOIEHFJMOLK> DEPOGKIILMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x72C5000", Offset = "0x72C4000", VA = "0x1872C5000", Slot = "4")]
	public IEnumerator<PDHNEODNMGH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x72C5000", Offset = "0x72C4000", VA = "0x1872C5000", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
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
