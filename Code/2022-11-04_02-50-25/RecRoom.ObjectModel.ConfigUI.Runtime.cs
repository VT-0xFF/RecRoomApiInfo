using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.ObjectModel.ConfigUI;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal abstract class FPDCJBMPJBC : global::EMDABALLFOE<Enum>, JFAFJODIBPB, OEPJBOPELFD, OJKMNPBADAL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool GLLBPGLDCJC(Type NLAFPPIOFPG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F31AE0", Offset = "0x5F30EE0", VA = "0x185F31AE0")]
	protected FPDCJBMPJBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class EMDABALLFOE<T> : OEPJBOPELFD, OJKMNPBADAL where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void IOCHOAMGCCN(Func<T> BMMBGNONLLA, Action<T> FIIMOOOHHPE, string JODEBEIHAPC, GMLMCMNEFMA GIOGLFNEEJE, Func<bool> MOCMFMLGJCP);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void NKAKHKHKOJG(Func<int> BMMBGNONLLA, Action<int> FIIMOOOHHPE, string JODEBEIHAPC, GMLMCMNEFMA GIOGLFNEEJE, Func<bool> MOCMFMLGJCP);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class HKDJEGGEBHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public KEIDHOKKPCI targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public GMLMCMNEFMA property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public HKDJEGGEBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x38E1FC0", Offset = "0x38E13C0", VA = "0x1838E1FC0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x38E20A0", Offset = "0x38E14A0", VA = "0x1838E20A0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x66D030", Offset = "0x66C430", VA = "0x18066D030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class IPACMIOIBAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::EMDABALLFOE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public FHNOFLNAIDL ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public IPACMIOIBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x142F1A0", Offset = "0x142E5A0", VA = "0x18142F1A0")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, GMLMCMNEFMA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class EELBJFIMLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public EELBJFIMLPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28C0010", Offset = "0x28BF410", VA = "0x1828C0010")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28C00D0", Offset = "0x28BF4D0", VA = "0x1828C00D0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x40AF3B0", Offset = "0x40AE7B0", VA = "0x1840AF3B0")]
	protected EMDABALLFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x40AEB90", Offset = "0x40ADF90", VA = "0x1840AEB90", Slot = "5")]
	public virtual void DDHKGBEKGNB(KEIDHOKKPCI OJPKKMBJDKE, GMLMCMNEFMA GIOGLFNEEJE, FHNOFLNAIDL NMBDFKMJNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x40AEA90", Offset = "0x40ADE90", VA = "0x1840AEA90", Slot = "6")]
	protected virtual IOCHOAMGCCN BGJDJKAHPJP(FHNOFLNAIDL NMBDFKMJNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x40AF360", Offset = "0x40AE760", VA = "0x1840AF360", Slot = "7")]
	protected virtual NKAKHKHKOJG ODNHCDMNNBK(FHNOFLNAIDL NMBDFKMJNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x40AF290", Offset = "0x40AE690", VA = "0x1840AF290")]
	private static Enum NADBODPANAE(KEIDHOKKPCI OJPKKMBJDKE, GMLMCMNEFMA GIOGLFNEEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x40AF120", Offset = "0x40AE520", VA = "0x1840AF120")]
	private static void DILMDPJPHBL(KEIDHOKKPCI OJPKKMBJDKE, GMLMCMNEFMA GIOGLFNEEJE, Enum PKODKJLGOIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class BPJLCMAHEJJ : OIMGNMAKHAC, OJKMNPBADAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GMLMCMNEFMA[] FODFOIHGHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private GMLMCMNEFMA[] PBICGBKMONI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GMLMCMNEFMA[] DGGOGBGHBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public GMLMCMNEFMA[] HIENEEINAKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract DLDEFENJDPN[] KNCONGHLMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract DLDEFENJDPN[] PDBJNFKIMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5F2F5D0", Offset = "0x5F2E9D0", VA = "0x185F2F5D0", Slot = "6")]
	public void NGKBIODLKGD(DBALNFAKKBN CDECOLIGOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void DDHKGBEKGNB(KEIDHOKKPCI OJPKKMBJDKE, FHNOFLNAIDL NMBDFKMJNKH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2E76B90", Offset = "0x2E75F90", VA = "0x182E76B90")]
	protected static T DJKKGCBBMLO<T>(KEIDHOKKPCI OJPKKMBJDKE, GMLMCMNEFMA GIOGLFNEEJE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2E76BE0", Offset = "0x2E75FE0", VA = "0x182E76BE0")]
	protected static void MEPJMLBBELM<T>(KEIDHOKKPCI OJPKKMBJDKE, GMLMCMNEFMA GIOGLFNEEJE, T PKODKJLGOIN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	protected BPJLCMAHEJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class FKOEGMGPPGD<T> : OEPJBOPELFD, OJKMNPBADAL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void CPOJPFCLCCL(Func<T> BMMBGNONLLA, Action<T> FIIMOOOHHPE, string JODEBEIHAPC, GMLMCMNEFMA GIOGLFNEEJE, Func<bool> MOCMFMLGJCP);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GDFDFPINNMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public KEIDHOKKPCI targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public GMLMCMNEFMA property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public GDFDFPINNMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x32446E0", Offset = "0x3243AE0", VA = "0x1832446E0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x32448E0", Offset = "0x3243CE0", VA = "0x1832448E0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x66D030", Offset = "0x66C430", VA = "0x18066D030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF170", Offset = "0x2DAE570", VA = "0x182DAF170")]
	protected FKOEGMGPPGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2DADD70", Offset = "0x2DAD170", VA = "0x182DADD70", Slot = "4")]
	public void DDHKGBEKGNB(KEIDHOKKPCI OJPKKMBJDKE, GMLMCMNEFMA GIOGLFNEEJE, FHNOFLNAIDL NMBDFKMJNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract CPOJPFCLCCL BGJDJKAHPJP(FHNOFLNAIDL NMBDFKMJNKH);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE6B0", Offset = "0x2DADAB0", VA = "0x182DAE6B0")]
	private static T DJKKGCBBMLO(KEIDHOKKPCI OJPKKMBJDKE, GMLMCMNEFMA GIOGLFNEEJE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2DAECF0", Offset = "0x2DAE0F0", VA = "0x182DAECF0")]
	private static void MEPJMLBBELM(KEIDHOKKPCI OJPKKMBJDKE, GMLMCMNEFMA GIOGLFNEEJE, T PKODKJLGOIN)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AFAPMPFKDID(JCDEPCAPNFC.ConfigUI)]
	[BGGFAGPLFND(typeof(IBJJDAMDDHP), new string[] { })]
	internal class ConfigUIService : IBJJDAMDDHP, OIOAOEDFDMG, BIJJPFLHCDJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[GPKJCAPOIDC]
		private DBALNFAKKBN CDECOLIGOKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[GPKJCAPOIDC]
		private KAONIDNDOFG AIIHIHEOPDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[GPKJCAPOIDC]
		private FHNOFLNAIDL MLGDHCJIPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BIJEPEKKHNL MOAICMPECGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private KEIDHOKKPCI OJPKKMBJDKE;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5F31350", Offset = "0x5F30750", VA = "0x185F31350", Slot = "5")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5F30F90", Offset = "0x5F30390", VA = "0x185F30F90", Slot = "6")]
		public void EDMCHPFLFFO(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5F30EA0", Offset = "0x5F302A0", VA = "0x185F30EA0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5F306B0", Offset = "0x5F2FAB0", VA = "0x185F306B0", Slot = "4")]
		public void BKLIHIABLPD(KEIDHOKKPCI DCFNFBINGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5F312C0", Offset = "0x5F306C0", VA = "0x185F312C0")]
		private void GBDLMGCKAEK(KEIDHOKKPCI DCFNFBINGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5F31290", Offset = "0x5F30690", VA = "0x185F31290")]
		private void EPLJIOAMEEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5F30C20", Offset = "0x5F30020", VA = "0x185F30C20")]
		private void DDHKGBEKGNB(GGEPOOPCLJF KHDFOKLGNGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PAGOPJBMBIE(0)]
internal class OILKEFKNANI : FPDCJBMPJBC
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F33C20", Offset = "0x5F33020", VA = "0x185F33C20", Slot = "9")]
	public override bool GLLBPGLDCJC(Type NLAFPPIOFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5F33B30", Offset = "0x5F32F30", VA = "0x185F33B30", Slot = "6")]
	protected override IOCHOAMGCCN BGJDJKAHPJP(FHNOFLNAIDL NMBDFKMJNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5F31AE0", Offset = "0x5F30EE0", VA = "0x185F31AE0")]
	public OILKEFKNANI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[PAGOPJBMBIE(0)]
internal class KMEAELDBFGP : FPDCJBMPJBC
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5F32D40", Offset = "0x5F32140", VA = "0x185F32D40", Slot = "9")]
	public override bool GLLBPGLDCJC(Type NLAFPPIOFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5F32C50", Offset = "0x5F32050", VA = "0x185F32C50", Slot = "6")]
	protected override IOCHOAMGCCN BGJDJKAHPJP(FHNOFLNAIDL NMBDFKMJNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5F31AE0", Offset = "0x5F30EE0", VA = "0x185F31AE0")]
	public KMEAELDBFGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[KFJKMELLDLE(typeof(OHMDOGKJIBF), 1)]
internal class EDMKHFEDLKG : global::EMDABALLFOE<OHMDOGKJIBF>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5F31780", Offset = "0x5F30B80", VA = "0x185F31780", Slot = "7")]
	protected override NKAKHKHKOJG ODNHCDMNNBK(FHNOFLNAIDL NMBDFKMJNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5F31870", Offset = "0x5F30C70", VA = "0x185F31870")]
	public EDMKHFEDLKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MJCCEKOIFBF
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5F33810", Offset = "0x5F32C10", VA = "0x185F33810")]
	public static bool NEPIJFDCGMA(this GMLMCMNEFMA GIOGLFNEEJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[CONPMDJKEOA(2)]
internal class BCLAIMNNELF : BPJLCMAHEJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class LNAFBFHGBAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public KEIDHOKKPCI targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public BCLAIMNNELF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public LNAFBFHGBAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5F33200", Offset = "0x5F32600", VA = "0x185F33200")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5F33330", Offset = "0x5F32730", VA = "0x185F33330")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x66D030", Offset = "0x66C430", VA = "0x18066D030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override DLDEFENJDPN[] PDBJNFKIMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5F2DFE0", Offset = "0x5F2D3E0", VA = "0x185F2DFE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override DLDEFENJDPN[] KNCONGHLMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5F2E0C0", Offset = "0x5F2D4C0", VA = "0x185F2E0C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5F2DC20", Offset = "0x5F2D020", VA = "0x185F2DC20", Slot = "10")]
	public override void DDHKGBEKGNB(KEIDHOKKPCI OJPKKMBJDKE, FHNOFLNAIDL NMBDFKMJNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public BCLAIMNNELF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[KFJKMELLDLE(typeof(bool))]
internal class FJCNNAKIJIP : global::FKOEGMGPPGD<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5F318B0", Offset = "0x5F30CB0", VA = "0x185F318B0", Slot = "5")]
	protected override CPOJPFCLCCL BGJDJKAHPJP(FHNOFLNAIDL NMBDFKMJNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5F319A0", Offset = "0x5F30DA0", VA = "0x185F319A0")]
	public FJCNNAKIJIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KFJKMELLDLE(typeof(FixedString32))]
internal class MDEBMIBDCCA : global::FKOEGMGPPGD<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class CPJKDNINONF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public FHNOFLNAIDL ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public CPJKDNINONF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5F30520", Offset = "0x5F2F920", VA = "0x185F30520")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, GMLMCMNEFMA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PLLGICILOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public PLLGICILOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5F33E60", Offset = "0x5F33260", VA = "0x185F33E60")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5F33ED0", Offset = "0x5F332D0", VA = "0x185F33ED0")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5F333C0", Offset = "0x5F327C0", VA = "0x185F333C0", Slot = "5")]
	protected override CPOJPFCLCCL BGJDJKAHPJP(FHNOFLNAIDL NMBDFKMJNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5F33480", Offset = "0x5F32880", VA = "0x185F33480")]
	public MDEBMIBDCCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KFJKMELLDLE(typeof(FixedString64))]
internal class FJPIEFCFPHJ : global::FKOEGMGPPGD<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class OLIDPJPKPAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FHNOFLNAIDL ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public OLIDPJPKPAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5F33CD0", Offset = "0x5F330D0", VA = "0x185F33CD0")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, GMLMCMNEFMA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class IJPMOBIPAJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public IJPMOBIPAJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5F32760", Offset = "0x5F31B60", VA = "0x185F32760")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5F327F0", Offset = "0x5F31BF0", VA = "0x185F327F0")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5F319E0", Offset = "0x5F30DE0", VA = "0x185F319E0", Slot = "5")]
	protected override CPOJPFCLCCL BGJDJKAHPJP(FHNOFLNAIDL NMBDFKMJNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F31AA0", Offset = "0x5F30EA0", VA = "0x185F31AA0")]
	public FJPIEFCFPHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[KFJKMELLDLE(typeof(float))]
internal class BNIMCAAJGIL : global::FKOEGMGPPGD<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F2F4A0", Offset = "0x5F2E8A0", VA = "0x185F2F4A0", Slot = "5")]
	protected override CPOJPFCLCCL BGJDJKAHPJP(FHNOFLNAIDL NMBDFKMJNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5F2F590", Offset = "0x5F2E990", VA = "0x185F2F590")]
	public BNIMCAAJGIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[KFJKMELLDLE(typeof(int))]
internal class DMBANGMAIMP : global::FKOEGMGPPGD<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5F31650", Offset = "0x5F30A50", VA = "0x185F31650", Slot = "5")]
	protected override CPOJPFCLCCL BGJDJKAHPJP(FHNOFLNAIDL NMBDFKMJNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F31740", Offset = "0x5F30B40", VA = "0x185F31740")]
	public DMBANGMAIMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[KFJKMELLDLE(typeof(uint))]
internal class HPAIMOMPGCF : global::FKOEGMGPPGD<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class OCCCDGKJEOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FHNOFLNAIDL ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public OCCCDGKJEOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5F33950", Offset = "0x5F32D50", VA = "0x185F33950")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, GMLMCMNEFMA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HEHBLDNJKIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public HEHBLDNJKIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5F32270", Offset = "0x5F31670", VA = "0x185F32270")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5F322C0", Offset = "0x5F316C0", VA = "0x185F322C0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F32320", Offset = "0x5F31720", VA = "0x185F32320", Slot = "5")]
	protected override CPOJPFCLCCL BGJDJKAHPJP(FHNOFLNAIDL NMBDFKMJNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5F323E0", Offset = "0x5F317E0", VA = "0x185F323E0")]
	public HPAIMOMPGCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[KFJKMELLDLE(typeof(Vector3))]
internal class AMAMJCGAJOK : global::FKOEGMGPPGD<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MGAIMMKFANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public FHNOFLNAIDL ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public MGAIMMKFANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5F334C0", Offset = "0x5F328C0", VA = "0x185F334C0")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, GMLMCMNEFMA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DBGFJBJINKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public DBGFJBJINKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5F31430", Offset = "0x5F30830", VA = "0x185F31430")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5F31490", Offset = "0x5F30890", VA = "0x185F31490")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5F314A0", Offset = "0x5F308A0", VA = "0x185F314A0")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5F31500", Offset = "0x5F30900", VA = "0x185F31500")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5F31510", Offset = "0x5F30910", VA = "0x185F31510")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5F31570", Offset = "0x5F30970", VA = "0x185F31570")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5F2DB20", Offset = "0x5F2CF20", VA = "0x185F2DB20", Slot = "5")]
	protected override CPOJPFCLCCL BGJDJKAHPJP(FHNOFLNAIDL NMBDFKMJNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5F2DBE0", Offset = "0x5F2CFE0", VA = "0x185F2DBE0")]
	public AMAMJCGAJOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct GGEPOOPCLJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int GBLLDONKEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int JDDILDEJKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int EEEKCOJKIFK;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class BFMADJPBDAK
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5F2E1A0", Offset = "0x5F2D5A0", VA = "0x185F2E1A0")]
	public static void KHINNKAKJPP(Type NJDHNCNGGOJ, Type HNAJAFABOPE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct JDBCAJMLLJF
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5F32890", Offset = "0x5F31C90", VA = "0x185F32890")]
	public static NativeList<int> AGDIGCLBEBK(KEIDHOKKPCI OJPKKMBJDKE, KAONIDNDOFG AIIHIHEOPDH)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5F32A70", Offset = "0x5F31E70", VA = "0x185F32A70")]
	private static bool FOGIKLPAAJI(GMLMCMNEFMA GIOGLFNEEJE, KEIDHOKKPCI OJPKKMBJDKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class CFKPIPLKPFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly KAONIDNDOFG AIIHIHEOPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly DBALNFAKKBN CDECOLIGOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly FHNOFLNAIDL NMBDFKMJNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<GGEPOOPCLJF> LOIPDMMEKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<NKMFEBAPHJN> JCOOELLOKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<NKMFEBAPHJN, List<GGEPOOPCLJF>> GHDGGPNMDLG;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5F30400", Offset = "0x5F2F800", VA = "0x185F30400")]
	public CFKPIPLKPFM(KAONIDNDOFG AIIHIHEOPDH, DBALNFAKKBN CDECOLIGOKO, FHNOFLNAIDL NMBDFKMJNKH, Action<GGEPOOPCLJF> LOIPDMMEKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FE60", Offset = "0x5F2F260", VA = "0x185F2FE60")]
	public void CIOFJOCMCNO(NativeList<GGEPOOPCLJF> KMNDKMNDLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5F301E0", Offset = "0x5F2F5E0", VA = "0x185F301E0")]
	private void FCHJLIAAFFF(NKMFEBAPHJN JALFPKPFAON, GGEPOOPCLJF KHDFOKLGNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5F30300", Offset = "0x5F2F700", VA = "0x185F30300")]
	public void GAPBCMFLNCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5F2F9E0", Offset = "0x5F2EDE0", VA = "0x185F2F9E0")]
	private void AIEEJMKAJCC(NKMFEBAPHJN JALFPKPFAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5F30360", Offset = "0x5F2F760", VA = "0x185F30360")]
	private void HPLDHOAJMNK(NKMFEBAPHJN JALFPKPFAON)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[AFAPMPFKDID(JCDEPCAPNFC.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class LKKCBNJJBMM : IEnumerable<GMLMCMNEFMA>, IEnumerable, IEnumerator<GMLMCMNEFMA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private GMLMCMNEFMA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public PropertiesByType <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private Type type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Type <>3__type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private NativeMultiHashMap<long, int>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private GMLMCMNEFMA System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8DF410", Offset = "0x8DE810", VA = "0x1808DF410")]
			[DebuggerHidden]
			public LKKCBNJJBMM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5F33130", Offset = "0x5F32530", VA = "0x185F33130", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5F32DF0", Offset = "0x5F321F0", VA = "0x185F32DF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5F331B0", Offset = "0x5F325B0", VA = "0x185F331B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5F330F0", Offset = "0x5F324F0", VA = "0x185F330F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5F33040", Offset = "0x5F32440", VA = "0x185F33040", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GMLMCMNEFMA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5F33040", Offset = "0x5F32440", VA = "0x185F33040", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly DBALNFAKKBN CDECOLIGOKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> NMGKCPAEHPE;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5F34130", Offset = "0x5F33530", VA = "0x185F34130")]
		public PropertiesByType(DBALNFAKKBN CDECOLIGOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5F33F50", Offset = "0x5F33350", VA = "0x185F33F50")]
		[IteratorStateMachine(typeof(LKKCBNJJBMM))]
		public IEnumerable<GMLMCMNEFMA> ALDHEAJBKOI(Type NLAFPPIOFPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5F33FE0", Offset = "0x5F333E0", VA = "0x185F33FE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5F34020", Offset = "0x5F33420", VA = "0x185F34020")]
		private long JJMIBCEGOFD(GMLMCMNEFMA GIOGLFNEEJE)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5F340A0", Offset = "0x5F334A0", VA = "0x185F340A0")]
		private long JJMIBCEGOFD(Type NLAFPPIOFPG)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct IJOGNHOMAEH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray HCLHJGGCJIA;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5F32720", Offset = "0x5F31B20", VA = "0x185F32720")]
	public IJOGNHOMAEH(int EFJDLDLIAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5F32500", Offset = "0x5F31900", VA = "0x185F32500")]
	public static IJOGNHOMAEH GEDJNPMPBDA(int OIKPPNLJGJL, NativeArray<int> CKCKOLCCJBK)
	{
		return default(IJOGNHOMAEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5F32430", Offset = "0x5F31830", VA = "0x185F32430")]
	public bool EADGBDOIODD(int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5F32650", Offset = "0x5F31A50", VA = "0x185F32650")]
	public void JKDFMHKJMMK(int PGFOAHEHPOH, bool PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5F32660", Offset = "0x5F31A60", VA = "0x185F32660")]
	public bool PHMNLFNPAIG(GMLMCMNEFMA[] CKCKOLCCJBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5F32440", Offset = "0x5F31840", VA = "0x185F32440")]
	public bool FPIDIKEILLP(GMLMCMNEFMA[] CKCKOLCCJBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5F32420", Offset = "0x5F31820", VA = "0x185F32420", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class BIJEPEKKHNL
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly EHNHFGEGKKP PDHCNHGCAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly KAONIDNDOFG AIIHIHEOPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly DBALNFAKKBN CDECOLIGOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<OJKMNPBADAL> GNNEKJPNABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType NMGKCPAEHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> IEHJHALDOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> LPGMHFLABGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<OJKMNPBADAL> KPNABCKKHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5F2F2F0", Offset = "0x5F2E6F0", VA = "0x185F2F2F0")]
	public BIJEPEKKHNL(KAONIDNDOFG AIIHIHEOPDH, DBALNFAKKBN CDECOLIGOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5F2E280", Offset = "0x5F2D680", VA = "0x185F2E280")]
	public void ANGPDPCFPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5F2F060", Offset = "0x5F2E460", VA = "0x185F2F060")]
	public void LHELCMKAMJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5F2E7A0", Offset = "0x5F2DBA0", VA = "0x185F2E7A0")]
	public NativeList<GGEPOOPCLJF> HIODKMJKELM(NativeArray<int> CKCKOLCCJBK)
	{
		return default(NativeList<GGEPOOPCLJF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5F2ECD0", Offset = "0x5F2E0D0", VA = "0x185F2ECD0")]
	private bool KBOKFEPLFNG(OJKMNPBADAL OKAGOINDECA, IJOGNHOMAEH CELOAGCNOGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A29670", Offset = "0x2A28A70", VA = "0x182A29670")]
	private void CJHBLCACDPK<TInterface, TAttribute>(Action<TInterface, TAttribute> ONBPAADBCAN) where TInterface : OJKMNPBADAL where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5F2ECA0", Offset = "0x5F2E0A0", VA = "0x185F2ECA0")]
	private void INOPPBOMMIF(Type NLAFPPIOFPG, Type BJIBMFLEEGO, Type GFGPBBGBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2A29910", Offset = "0x2A28D10", VA = "0x182A29910")]
	private TInterface KBBIFAGNFKH<TInterface>(Type NLAFPPIOFPG)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5F2F1D0", Offset = "0x5F2E5D0", VA = "0x185F2F1D0")]
	private void PEJAHFHMEKL(OJKMNPBADAL OKAGOINDECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5F2EC00", Offset = "0x5F2E000", VA = "0x185F2EC00")]
	private int IBAPCLOEKNC(OJKMNPBADAL AGOOLBDAEKK, int EEEKCOJKIFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5F2E4F0", Offset = "0x5F2D8F0", VA = "0x185F2E4F0")]
	private void GKECFDKMDIJ(OEPJBOPELFD OKAGOINDECA, KFJKMELLDLE AJIAKKGHEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5F2EDA0", Offset = "0x5F2E1A0", VA = "0x185F2EDA0")]
	private void LCJGAPAJPGF(JFAFJODIBPB OKAGOINDECA, PAGOPJBMBIE AJIAKKGHEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5F2E350", Offset = "0x5F2D750", VA = "0x185F2E350")]
	private void FJFJAMKFHMM(OIMGNMAKHAC OKAGOINDECA, CONPMDJKEOA AJIAKKGHEHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct GKFNFJOLDJC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly DBALNFAKKBN CDECOLIGOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<OJKMNPBADAL> GNNEKJPNABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<GGEPOOPCLJF> LDCPBCJJHLD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<GGEPOOPCLJF> KJJBMFMEKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD9AD10", Offset = "0xD9A110", VA = "0x180D9AD10")]
		get
		{
			return default(NativeList<GGEPOOPCLJF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5F321F0", Offset = "0x5F315F0", VA = "0x185F321F0")]
	public GKFNFJOLDJC(DBALNFAKKBN CDECOLIGOKO, List<OJKMNPBADAL> GNNEKJPNABE, NativeArray<GGEPOOPCLJF> KMNDKMNDLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5F31B20", Offset = "0x5F30F20", VA = "0x185F31B20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5F31B60", Offset = "0x5F30F60", VA = "0x185F31B60")]
	private NativeList<GGEPOOPCLJF> FCCOLMALEPP(NativeArray<GGEPOOPCLJF> ACPFIMDCFII)
	{
		return default(NativeList<GGEPOOPCLJF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5F31F60", Offset = "0x5F31360", VA = "0x185F31F60")]
	private bool HCKHLJNFJPN(OJKMNPBADAL OKAGOINDECA, IJOGNHOMAEH DGEBNJEGBCE, int JDDILDEJKOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5F32030", Offset = "0x5F31430", VA = "0x185F32030")]
	private void IHIGCJOEHHM(OJKMNPBADAL OKAGOINDECA, IJOGNHOMAEH HCLHJGGCJIA, int JDDILDEJKOB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct BJKDBBOPLCC : IComparer<GGEPOOPCLJF>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5F2F440", Offset = "0x5F2E840", VA = "0x185F2F440", Slot = "4")]
	public int Compare(GGEPOOPCLJF ANJGLCCJFPO, GGEPOOPCLJF ABBMKKCGFBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5F2F450", Offset = "0x5F2E850", VA = "0x185F2F450")]
	public static void KAADNOLIHIH(NativeList<GGEPOOPCLJF> KMNDKMNDLBH)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : EFIPBPLGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5F345B0", Offset = "0x5F339B0", VA = "0x185F345B0", Slot = "6")]
		public sealed override void HGCIEPNFBCH(LDNEHEGKOKK EGLKIOCIBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5F34430", Offset = "0x5F33830", VA = "0x185F34430", Slot = "4")]
		public sealed override void AMKPAJEBOOH()
		{
		}
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
