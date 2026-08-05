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
internal abstract class OCAGPIODFNK : global::ACDEPDHJGGO<Enum>, NCAIPEPNKLD, LJHKPFMMNNC, MNGLONKIDIP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool POCMLAAEKEH(Type BKGBGEHNCAE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x649E4B0", Offset = "0x649D8B0", VA = "0x18649E4B0")]
	protected OCAGPIODFNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class ACDEPDHJGGO<T> : LJHKPFMMNNC, MNGLONKIDIP where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void ALFOOHGGKGJ(Func<T> LABKAKGCNAK, Action<T> HMAHEBBHMNM, string LBEPPIIBMPA, AEOCECNOIKA JGMFKPLFFDI, Func<bool> IEDMMGIKCCE);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void KCKGICMEGCE(Func<int> LABKAKGCNAK, Action<int> HMAHEBBHMNM, string LBEPPIIBMPA, AEOCECNOIKA JGMFKPLFFDI, Func<bool> IEDMMGIKCCE);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class EOICHOMKJBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public HKMFMMPGOLI targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AEOCECNOIKA property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public EOICHOMKJBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x252AE80", Offset = "0x252A280", VA = "0x18252AE80")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x252AF60", Offset = "0x252A360", VA = "0x18252AF60")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x76D160", Offset = "0x76C560", VA = "0x18076D160")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class CFILFHEILAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::ACDEPDHJGGO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public LIMCAJDKPBN ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public CFILFHEILAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3B65060", Offset = "0x3B64460", VA = "0x183B65060")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, AEOCECNOIKA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CDKLLEBILML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public CDKLLEBILML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3B61F50", Offset = "0x3B61350", VA = "0x183B61F50")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3B621D0", Offset = "0x3B615D0", VA = "0x183B621D0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4945CF0", Offset = "0x49450F0", VA = "0x184945CF0")]
	protected ACDEPDHJGGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4945850", Offset = "0x4944C50", VA = "0x184945850", Slot = "5")]
	public virtual void PPCDGOFPKKM(HKMFMMPGOLI HIABBMOGMOA, AEOCECNOIKA JGMFKPLFFDI, LIMCAJDKPBN NEIJFPKLHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x49453D0", Offset = "0x49447D0", VA = "0x1849453D0", Slot = "6")]
	protected virtual ALFOOHGGKGJ AKAMAEPCDHI(LIMCAJDKPBN NEIJFPKLHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x49454D0", Offset = "0x49448D0", VA = "0x1849454D0", Slot = "7")]
	protected virtual KCKGICMEGCE BPGBMAMFNMH(LIMCAJDKPBN NEIJFPKLHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x49457D0", Offset = "0x4944BD0", VA = "0x1849457D0")]
	private static Enum OFDAIIBKGJL(HKMFMMPGOLI HIABBMOGMOA, AEOCECNOIKA JGMFKPLFFDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4945660", Offset = "0x4944A60", VA = "0x184945660")]
	private static void HLMNIIAFBOI(HKMFMMPGOLI HIABBMOGMOA, AEOCECNOIKA JGMFKPLFFDI, Enum FPLJCBGEJAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class HAFOJIHDGGB : ADFGAAIOAHE, MNGLONKIDIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private AEOCECNOIKA[] JBIDDICFEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private AEOCECNOIKA[] JFHHIJFELHM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AEOCECNOIKA[] MPCKBAPFNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public AEOCECNOIKA[] MDCEIHEEIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract BFOMGEBLKLE[] DCKBFDNECKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract BFOMGEBLKLE[] NCIIPHOHNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x64A12E0", Offset = "0x64A06E0", VA = "0x1864A12E0", Slot = "6")]
	public void HCLJCDJPJCB(MPCADNMEKPJ LFBDLGPFNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void PPCDGOFPKKM(HKMFMMPGOLI HIABBMOGMOA, LIMCAJDKPBN NEIJFPKLHNN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2DCC440", Offset = "0x2DCB840", VA = "0x182DCC440")]
	protected static T LDKHJJEDJLO<T>(HKMFMMPGOLI HIABBMOGMOA, AEOCECNOIKA JGMFKPLFFDI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2DCC370", Offset = "0x2DCB770", VA = "0x182DCC370")]
	protected static void BAKFMNEDAOM<T>(HKMFMMPGOLI HIABBMOGMOA, AEOCECNOIKA JGMFKPLFFDI, T FPLJCBGEJAP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	protected HAFOJIHDGGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class POGKDPHMGDO<T> : LJHKPFMMNNC, MNGLONKIDIP where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void KJJDLMPONGK(Func<T> LABKAKGCNAK, Action<T> HMAHEBBHMNM, string LBEPPIIBMPA, AEOCECNOIKA JGMFKPLFFDI, Func<bool> IEDMMGIKCCE);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JPGJNBICHNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public HKMFMMPGOLI targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AEOCECNOIKA property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public JPGJNBICHNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x39A6BA0", Offset = "0x39A5FA0", VA = "0x1839A6BA0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x39A6D10", Offset = "0x39A6110", VA = "0x1839A6D10")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x76D160", Offset = "0x76C560", VA = "0x18076D160")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x32E2910", Offset = "0x32E1D10", VA = "0x1832E2910")]
	protected POGKDPHMGDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x32E1C20", Offset = "0x32E1020", VA = "0x1832E1C20", Slot = "4")]
	public void PPCDGOFPKKM(HKMFMMPGOLI HIABBMOGMOA, AEOCECNOIKA JGMFKPLFFDI, LIMCAJDKPBN NEIJFPKLHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract KJJDLMPONGK AKAMAEPCDHI(LIMCAJDKPBN NEIJFPKLHNN);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x32E1490", Offset = "0x32E0890", VA = "0x1832E1490")]
	private static T LDKHJJEDJLO(HKMFMMPGOLI HIABBMOGMOA, AEOCECNOIKA JGMFKPLFFDI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x32E1380", Offset = "0x32E0780", VA = "0x1832E1380")]
	private static void BAKFMNEDAOM(HKMFMMPGOLI HIABBMOGMOA, AEOCECNOIKA JGMFKPLFFDI, T FPLJCBGEJAP)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[NAPHGBOEKGO(GPIMBHHJLKL.ConfigUI)]
	[AOJPGBJKDNL(typeof(CNGFAANKDDD), new string[] { })]
	internal class ConfigUIService : CNGFAANKDDD, NGENPNOGFON, CJFEEGPLPHA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[CPICBLLAMOM]
		private MPCADNMEKPJ LFBDLGPFNLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[CPICBLLAMOM]
		private MFJGLPLECEJ PHJPGHMKJGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[CPICBLLAMOM]
		private LIMCAJDKPBN FDDPKAFHAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private KFKDGOJHJML IPNNBHMMGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private HKMFMMPGOLI HIABBMOGMOA;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x649F7A0", Offset = "0x649EBA0", VA = "0x18649F7A0", Slot = "5")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x649EF30", Offset = "0x649E330", VA = "0x18649EF30", Slot = "6")]
		public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x649EE40", Offset = "0x649E240", VA = "0x18649EE40", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x649F230", Offset = "0x649E630", VA = "0x18649F230", Slot = "4")]
		public void MDNNFLJDHAL(HKMFMMPGOLI KECACKHGIMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x649ED80", Offset = "0x649E180", VA = "0x18649ED80")]
		private void CPOHEEGACIE(HKMFMMPGOLI KECACKHGIMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x649EE10", Offset = "0x649E210", VA = "0x18649EE10")]
		private void DENHFJHGLPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x649F830", Offset = "0x649EC30", VA = "0x18649F830")]
		private void PPCDGOFPKKM(IDNLBCDGHKB HIJHNJBFIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[GJMODPCGDIB(0)]
internal class DDCOPKFKNPH : OCAGPIODFNK
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x649FBF0", Offset = "0x649EFF0", VA = "0x18649FBF0", Slot = "9")]
	public override bool POCMLAAEKEH(Type BKGBGEHNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x649FB00", Offset = "0x649EF00", VA = "0x18649FB00", Slot = "6")]
	protected override ALFOOHGGKGJ AKAMAEPCDHI(LIMCAJDKPBN NEIJFPKLHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x649E4B0", Offset = "0x649D8B0", VA = "0x18649E4B0")]
	public DDCOPKFKNPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[GJMODPCGDIB(0)]
internal class APBCLDMMHOE : OCAGPIODFNK
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x649E400", Offset = "0x649D800", VA = "0x18649E400", Slot = "9")]
	public override bool POCMLAAEKEH(Type BKGBGEHNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x649E310", Offset = "0x649D710", VA = "0x18649E310", Slot = "6")]
	protected override ALFOOHGGKGJ AKAMAEPCDHI(LIMCAJDKPBN NEIJFPKLHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x649E4B0", Offset = "0x649D8B0", VA = "0x18649E4B0")]
	public APBCLDMMHOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[IPHCOOMFJIL(typeof(ABKIOCAMCDA), 1)]
internal class KGDHPGLOICO : global::ACDEPDHJGGO<ABKIOCAMCDA>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x64A33D0", Offset = "0x64A27D0", VA = "0x1864A33D0", Slot = "7")]
	protected override KCKGICMEGCE BPGBMAMFNMH(LIMCAJDKPBN NEIJFPKLHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x64A34C0", Offset = "0x64A28C0", VA = "0x1864A34C0")]
	public KGDHPGLOICO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MBPLLMINMNH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x64A3B20", Offset = "0x64A2F20", VA = "0x1864A3B20")]
	public static bool GNJICDEJINE(this AEOCECNOIKA JGMFKPLFFDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[IJDLIGDLAJE(2)]
internal class GFDJLJDCBKK : HAFOJIHDGGB
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class NBGJLIJKLFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public HKMFMMPGOLI targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public GFDJLJDCBKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public NBGJLIJKLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x64A4140", Offset = "0x64A3540", VA = "0x1864A4140")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x64A4270", Offset = "0x64A3670", VA = "0x1864A4270")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x76D160", Offset = "0x76C560", VA = "0x18076D160")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override BFOMGEBLKLE[] NCIIPHOHNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x64A0A10", Offset = "0x649FE10", VA = "0x1864A0A10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override BFOMGEBLKLE[] DCKBFDNECKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x64A0AF0", Offset = "0x649FEF0", VA = "0x1864A0AF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x64A0BD0", Offset = "0x649FFD0", VA = "0x1864A0BD0", Slot = "10")]
	public override void PPCDGOFPKKM(HKMFMMPGOLI HIABBMOGMOA, LIMCAJDKPBN NEIJFPKLHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public GFDJLJDCBKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[IPHCOOMFJIL(typeof(bool))]
internal class FGDOAGOEADK : global::POGKDPHMGDO<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x649FDA0", Offset = "0x649F1A0", VA = "0x18649FDA0", Slot = "5")]
	protected override KJJDLMPONGK AKAMAEPCDHI(LIMCAJDKPBN NEIJFPKLHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x649FE90", Offset = "0x649F290", VA = "0x18649FE90")]
	public FGDOAGOEADK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[IPHCOOMFJIL(typeof(FixedString32))]
internal class OBAJHIPMMLG : global::POGKDPHMGDO<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class MKAKDFKHCLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LIMCAJDKPBN ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public MKAKDFKHCLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x64A3C60", Offset = "0x64A3060", VA = "0x1864A3C60")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, AEOCECNOIKA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class IFGABAMDLBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public IFGABAMDLBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x64A19D0", Offset = "0x64A0DD0", VA = "0x1864A19D0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x64A1A40", Offset = "0x64A0E40", VA = "0x1864A1A40")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x64A4540", Offset = "0x64A3940", VA = "0x1864A4540", Slot = "5")]
	protected override KJJDLMPONGK AKAMAEPCDHI(LIMCAJDKPBN NEIJFPKLHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x64A4600", Offset = "0x64A3A00", VA = "0x1864A4600")]
	public OBAJHIPMMLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[IPHCOOMFJIL(typeof(FixedString64))]
internal class PNCFDFBDEJI : global::POGKDPHMGDO<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class CAKLCDGBGFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public LIMCAJDKPBN ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public CAKLCDGBGFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x649EBF0", Offset = "0x649DFF0", VA = "0x18649EBF0")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, AEOCECNOIKA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HNNNGFCMDBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public HNNNGFCMDBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x64A17F0", Offset = "0x64A0BF0", VA = "0x1864A17F0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x64A1880", Offset = "0x64A0C80", VA = "0x1864A1880")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x64A4640", Offset = "0x64A3A40", VA = "0x1864A4640", Slot = "5")]
	protected override KJJDLMPONGK AKAMAEPCDHI(LIMCAJDKPBN NEIJFPKLHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x64A4700", Offset = "0x64A3B00", VA = "0x1864A4700")]
	public PNCFDFBDEJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[IPHCOOMFJIL(typeof(float))]
internal class KMNHJDGKNGJ : global::POGKDPHMGDO<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x64A3910", Offset = "0x64A2D10", VA = "0x1864A3910", Slot = "5")]
	protected override KJJDLMPONGK AKAMAEPCDHI(LIMCAJDKPBN NEIJFPKLHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x64A3A00", Offset = "0x64A2E00", VA = "0x1864A3A00")]
	public KMNHJDGKNGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[IPHCOOMFJIL(typeof(int))]
internal class GIFJBNLHFIC : global::POGKDPHMGDO<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x64A0F90", Offset = "0x64A0390", VA = "0x1864A0F90", Slot = "5")]
	protected override KJJDLMPONGK AKAMAEPCDHI(LIMCAJDKPBN NEIJFPKLHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x64A1080", Offset = "0x64A0480", VA = "0x1864A1080")]
	public GIFJBNLHFIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[IPHCOOMFJIL(typeof(uint))]
internal class HHNGDKMOHNC : global::POGKDPHMGDO<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NCDNJLKLBLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public LIMCAJDKPBN ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public NCDNJLKLBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x64A4300", Offset = "0x64A3700", VA = "0x1864A4300")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, AEOCECNOIKA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HPIGBMLGHCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public HPIGBMLGHCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64A1920", Offset = "0x64A0D20", VA = "0x1864A1920")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64A1970", Offset = "0x64A0D70", VA = "0x1864A1970")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x64A16F0", Offset = "0x64A0AF0", VA = "0x1864A16F0", Slot = "5")]
	protected override KJJDLMPONGK AKAMAEPCDHI(LIMCAJDKPBN NEIJFPKLHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x64A17B0", Offset = "0x64A0BB0", VA = "0x1864A17B0")]
	public HHNGDKMOHNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[IPHCOOMFJIL(typeof(Vector3))]
internal class EJLJBMMJKJO : global::POGKDPHMGDO<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NAFCJBJJKPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public LIMCAJDKPBN ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public NAFCJBJJKPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x64A3DF0", Offset = "0x64A31F0", VA = "0x1864A3DF0")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, AEOCECNOIKA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GOBMANKINGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public GOBMANKINGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x64A10C0", Offset = "0x64A04C0", VA = "0x1864A10C0")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x64A1120", Offset = "0x64A0520", VA = "0x1864A1120")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x64A1130", Offset = "0x64A0530", VA = "0x1864A1130")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x64A1190", Offset = "0x64A0590", VA = "0x1864A1190")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x64A11A0", Offset = "0x64A05A0", VA = "0x1864A11A0")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x64A1200", Offset = "0x64A0600", VA = "0x1864A1200")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x649FCA0", Offset = "0x649F0A0", VA = "0x18649FCA0", Slot = "5")]
	protected override KJJDLMPONGK AKAMAEPCDHI(LIMCAJDKPBN NEIJFPKLHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x649FD60", Offset = "0x649F160", VA = "0x18649FD60")]
	public EJLJBMMJKJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct IDNLBCDGHKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int KDHNBGOINBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int IAFIPEOGBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int KJECNLJKDOP;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class LJEBLJJPNPM
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x64A3A40", Offset = "0x64A2E40", VA = "0x1864A3A40")]
	public static void LPADLNIABJO(Type DAINHFJOOIE, Type AHMBBHLACOF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct BPNJGKDLDBD
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x649E830", Offset = "0x649DC30", VA = "0x18649E830")]
	public static NativeList<int> LCHGAGKHHAN(HKMFMMPGOLI HIABBMOGMOA, MFJGLPLECEJ PHJPGHMKJGC)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x649EA10", Offset = "0x649DE10", VA = "0x18649EA10")]
	private static bool ONBAIHILOPI(AEOCECNOIKA JGMFKPLFFDI, HKMFMMPGOLI HIABBMOGMOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class GEMCEMNHMDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly MFJGLPLECEJ PHJPGHMKJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly MPCADNMEKPJ LFBDLGPFNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly LIMCAJDKPBN NEIJFPKLHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<IDNLBCDGHKB> NHCBAIDMAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<EFKIEBEBIKB> BBDDAKAOHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<EFKIEBEBIKB, List<IDNLBCDGHKB>> OEEOHNIMPGE;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x64A08F0", Offset = "0x649FCF0", VA = "0x1864A08F0")]
	public GEMCEMNHMDE(MFJGLPLECEJ PHJPGHMKJGC, MPCADNMEKPJ LFBDLGPFNLK, LIMCAJDKPBN NEIJFPKLHNN, Action<IDNLBCDGHKB> NHCBAIDMAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x649FF30", Offset = "0x649F330", VA = "0x18649FF30")]
	public void FBOCAEHPBJO(NativeList<IDNLBCDGHKB> DGDEHAGJIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x64A0730", Offset = "0x649FB30", VA = "0x1864A0730")]
	private void KOJELMEBCDC(EFKIEBEBIKB MLMPFJIEGOP, IDNLBCDGHKB HIJHNJBFIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x649FED0", Offset = "0x649F2D0", VA = "0x18649FED0")]
	public void CGOLKEOPKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x64A02B0", Offset = "0x649F6B0", VA = "0x1864A02B0")]
	private void HKIPKFCCNDC(EFKIEBEBIKB MLMPFJIEGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x64A0850", Offset = "0x649FC50", VA = "0x1864A0850")]
	private void PNHNNOCBJOC(EFKIEBEBIKB MLMPFJIEGOP)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[NAPHGBOEKGO(GPIMBHHJLKL.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class KGJLIOMAAAP : IEnumerable<AEOCECNOIKA>, IEnumerable, IEnumerator<AEOCECNOIKA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private AEOCECNOIKA <>2__current;

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
			private AEOCECNOIKA System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
			[DebuggerHidden]
			public KGJLIOMAAAP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x64A3840", Offset = "0x64A2C40", VA = "0x1864A3840", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x64A3500", Offset = "0x64A2900", VA = "0x1864A3500", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x64A38C0", Offset = "0x64A2CC0", VA = "0x1864A38C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x64A3800", Offset = "0x64A2C00", VA = "0x1864A3800", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x64A3750", Offset = "0x64A2B50", VA = "0x1864A3750", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AEOCECNOIKA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x64A3750", Offset = "0x64A2B50", VA = "0x1864A3750", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly MPCADNMEKPJ LFBDLGPFNLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> LDMGOEBGLCN;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x64A4920", Offset = "0x64A3D20", VA = "0x1864A4920")]
		public PropertiesByType(MPCADNMEKPJ LFBDLGPFNLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x64A4740", Offset = "0x64A3B40", VA = "0x1864A4740")]
		[IteratorStateMachine(typeof(KGJLIOMAAAP))]
		public IEnumerable<AEOCECNOIKA> ALPEFGHPCDH(Type BKGBGEHNCAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x64A4890", Offset = "0x64A3C90", VA = "0x1864A4890", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x64A47D0", Offset = "0x64A3BD0", VA = "0x1864A47D0")]
		private long BECKDPPLGGK(AEOCECNOIKA JGMFKPLFFDI)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x64A4850", Offset = "0x64A3C50", VA = "0x1864A4850")]
		private long BECKDPPLGGK(Type BKGBGEHNCAE)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct BGHNPCFNGPN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray IEMJCEAAHPI;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x649E7F0", Offset = "0x649DBF0", VA = "0x18649E7F0")]
	public BGHNPCFNGPN(int NDNADCNCIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x649E5E0", Offset = "0x649D9E0", VA = "0x18649E5E0")]
	public static BGHNPCFNGPN JOOLMCCOHCC(int NANBMPFBPOK, NativeArray<int> FIJECBKDHDI)
	{
		return default(BGHNPCFNGPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x649E5D0", Offset = "0x649D9D0", VA = "0x18649E5D0")]
	public bool JCADDNHHNDG(int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x649E4F0", Offset = "0x649D8F0", VA = "0x18649E4F0")]
	public void CODPHMBGNGD(int GABJOMFFJAI, bool FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x649E730", Offset = "0x649DB30", VA = "0x18649E730")]
	public bool MIJAIEFBBGF(AEOCECNOIKA[] FIJECBKDHDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x649E510", Offset = "0x649D910", VA = "0x18649E510")]
	public bool EEDELGJLEKA(AEOCECNOIKA[] FIJECBKDHDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x649E500", Offset = "0x649D900", VA = "0x18649E500", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class KFKDGOJHJML
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly BBHAOFNBCPD CDECIAPNKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MFJGLPLECEJ PHJPGHMKJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MPCADNMEKPJ LFBDLGPFNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<MNGLONKIDIP> AICKIMDJGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType LDMGOEBGLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> FDPKBBDAJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> CCPCJDDMKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<MNGLONKIDIP> KILOHAGAOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x64A3280", Offset = "0x64A2680", VA = "0x1864A3280")]
	public KFKDGOJHJML(MFJGLPLECEJ PHJPGHMKJGC, MPCADNMEKPJ LFBDLGPFNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x64A2C10", Offset = "0x64A2010", VA = "0x1864A2C10")]
	public void IDPLHJEPBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x64A2710", Offset = "0x64A1B10", VA = "0x1864A2710")]
	public void DJBDELHCFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x64A22B0", Offset = "0x64A16B0", VA = "0x1864A22B0")]
	public NativeList<IDNLBCDGHKB> CNIIEFDCBGL(NativeArray<int> FIJECBKDHDI)
	{
		return default(NativeList<IDNLBCDGHKB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x64A2B40", Offset = "0x64A1F40", VA = "0x1864A2B40")]
	private bool GKGGGCOKEDJ(MNGLONKIDIP LOJHNKFLIOG, BGHNPCFNGPN BFIOHAOFMAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x29665D0", Offset = "0x29659D0", VA = "0x1829665D0")]
	private void ODLBPDIOHBD<TInterface, TAttribute>(Action<TInterface, TAttribute> CLKPGIDAMFD) where TInterface : MNGLONKIDIP where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x64A2CE0", Offset = "0x64A20E0", VA = "0x1864A2CE0")]
	private void JHMFJNFOCJE(Type BKGBGEHNCAE, Type MNLEEAIIEIH, Type FBFJCFHJBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2966570", Offset = "0x2965970", VA = "0x182966570")]
	private TInterface KGDNJAFNBKD<TInterface>(Type BKGBGEHNCAE)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x64A2D10", Offset = "0x64A2110", VA = "0x1864A2D10")]
	private void KDIMDHOHKGF(MNGLONKIDIP LOJHNKFLIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x64A2210", Offset = "0x64A1610", VA = "0x1864A2210")]
	private int CGBOBBCABMI(MNGLONKIDIP GFCOCLEJPKI, int KJECNLJKDOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x64A2F80", Offset = "0x64A2380", VA = "0x1864A2F80")]
	private void PNLBPIINNBA(LJHKPFMMNNC LOJHNKFLIOG, IPHCOOMFJIL GDLDOMBMKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x64A2880", Offset = "0x64A1C80", VA = "0x1864A2880")]
	private void DNHDJMLEMAJ(NCAIPEPNKLD LOJHNKFLIOG, GJMODPCGDIB GDLDOMBMKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x64A2DE0", Offset = "0x64A21E0", VA = "0x1864A2DE0")]
	private void OAAKIOAPOKC(ADFGAAIOAHE LOJHNKFLIOG, IJDLIGDLAJE GDLDOMBMKLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct ILMDLFNEAFM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly MPCADNMEKPJ LFBDLGPFNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<MNGLONKIDIP> AICKIMDJGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<IDNLBCDGHKB> LFADLFEIAHO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<IDNLBCDGHKB> NEKIIKIAEIE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2A0", Offset = "0x7ED6A0", VA = "0x1807EE2A0")]
		get
		{
			return default(NativeList<IDNLBCDGHKB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x64A2190", Offset = "0x64A1590", VA = "0x1864A2190")]
	public ILMDLFNEAFM(MPCADNMEKPJ LFBDLGPFNLK, List<MNGLONKIDIP> AICKIMDJGFD, NativeArray<IDNLBCDGHKB> DGDEHAGJIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x64A1F90", Offset = "0x64A1390", VA = "0x1864A1F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x64A1B90", Offset = "0x64A0F90", VA = "0x1864A1B90")]
	private NativeList<IDNLBCDGHKB> DIJLAMMFAFJ(NativeArray<IDNLBCDGHKB> JFOMHACOHNP)
	{
		return default(NativeList<IDNLBCDGHKB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x64A1AC0", Offset = "0x64A0EC0", VA = "0x1864A1AC0")]
	private bool BPPMBLIEKME(MNGLONKIDIP LOJHNKFLIOG, BGHNPCFNGPN LKGPGJGOCCF, int IAFIPEOGBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x64A1FD0", Offset = "0x64A13D0", VA = "0x1864A1FD0")]
	private void POAGMHCMCGF(MNGLONKIDIP LOJHNKFLIOG, BGHNPCFNGPN IEMJCEAAHPI, int IAFIPEOGBCA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct NEMJNKLMBIH : IComparer<IDNLBCDGHKB>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x64A4530", Offset = "0x64A3930", VA = "0x1864A4530", Slot = "4")]
	public int Compare(IDNLBCDGHKB KEPOHMNFLGL, IDNLBCDGHKB CFEKEMJOJGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x64A44E0", Offset = "0x64A38E0", VA = "0x1864A44E0")]
	public static void AHBGFFIOFMJ(NativeList<IDNLBCDGHKB> DGDEHAGJIBJ)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : AOMBDDGFEEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x64A4DA0", Offset = "0x64A41A0", VA = "0x1864A4DA0", Slot = "6")]
		public sealed override void MOOHCJAEEBD(CDEIOGNPKKE KCKLDKHBENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x64A4C20", Offset = "0x64A4020", VA = "0x1864A4C20", Slot = "4")]
		public sealed override void IPAAHMOMIKO()
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
