using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HCNLOONEBMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly FIBFEFFONHN LKGCCNDNPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long EKCLJKKLOHJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EIFNGDADEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x66645D0", Offset = "0x66639D0", VA = "0x1866645D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66645E0", Offset = "0x66639E0", VA = "0x1866645E0")]
	public HCNLOONEBMC(FIBFEFFONHN ANIEEDIHIEE, long CBPPKGAPPDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GJOIBCOGMKO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	HiddenWhenNone,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Hidden,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	AlwaysVisibleOnceOwned,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	AlwaysVisible
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KIDHNEIGEJE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	DICJLHNIKOO PPJKFMCKECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	EPDOKNAGJLN<NCEEMKEJFAH> GFJBLNBFJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	EPDOKNAGJLN<Guid> DOCMJBDFIPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BDNCPNIGOBB<ANPMFNGIDKO, int> DHJAGAGOIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DICJLHNIKOO EDKPCEAPPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IAPKJCHKLLD<NCEEMKEJFAH, string>> BOOPHLJIGIH(long KKFMPNCGPKO, string GFBABMFGHOJ, string LAKEPEDEOJL, string GALKOCCKJLH, RoomInventoryItemProperties LOFNNPAJGEF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<IAPKJCHKLLD<NCEEMKEJFAH, string>> BIIFHINMKMH(Guid NEJFCNMMIFP, [Optional] string GFBABMFGHOJ, [Optional] string LAKEPEDEOJL, [Optional] string GALKOCCKJLH, [Optional] RoomInventoryItemProperties LOFNNPAJGEF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<IAPKJCHKLLD<bool, string>> KEBOJKBNGLI(Guid NEJFCNMMIFP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IReadOnlyList<NCEEMKEJFAH> PHKCFIBCBFD();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<NCEEMKEJFAH> PFDEKKMHJNO();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NAJICCPOAKM();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool LFCDFJNNONK(Guid NEJFCNMMIFP, [Out] NCEEMKEJFAH PGILAGIAHLI);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool LNPJFJGBOLJ(string FBCFHMKBNNE, [Out] NCEEMKEJFAH PGILAGIAHLI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool FNIKPBLNGDB(Guid NEJFCNMMIFP, [Out] ANPMFNGIDKO HLADELGLMBD);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<int> AHLIELFGPMF(KFLCLHKINNK FKOLNPOECGI, Guid NEJFCNMMIFP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<HCNLOONEBMC> EHBLJEOLKAC(KFLCLHKINNK FKOLNPOECGI, Guid NEJFCNMMIFP, int LBOHBLKMJHE);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	string EHGCOAMECGC(FIBFEFFONHN ANIEEDIHIEE);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool IDFAIHKCLJB();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ECCFIACFDIN : KIDHNEIGEJE
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NAGACEIMHNN(IEnumerable<PFKAKPCCNDF> DJGLBPGDAMM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ANPMFNGIDKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid LALCCNAIEEH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x66644B0", Offset = "0x66638B0", VA = "0x1866644B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EIFNGDADEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6664240", Offset = "0x6663640", VA = "0x186664240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long JFFKPJJBEHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7A59F0", Offset = "0x7A4DF0", VA = "0x1807A59F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long AIOAFEMEEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7A4970", Offset = "0x7A3D70", VA = "0x1807A4970")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7A43D0", Offset = "0x7A37D0", VA = "0x1807A43D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Guid? MBDEOHCEHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCD0", Offset = "0x7AB0D0", VA = "0x1807ABCD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCB0", Offset = "0x7AB0B0", VA = "0x1807ABCB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool JJPMLPPEMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83D430", Offset = "0x83C830", VA = "0x18083D430")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x19BC0C0", Offset = "0x19BB4C0", VA = "0x1819BC0C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x66644C0", Offset = "0x66638C0", VA = "0x1866644C0")]
	public ANPMFNGIDKO(PFKAKPCCNDF DLNFADPKCPN, bool FCJOMFDBIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1A81360", Offset = "0x1A80760", VA = "0x181A81360")]
	public ANPMFNGIDKO(Guid NEJFCNMMIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x66642C0", Offset = "0x66636C0", VA = "0x1866642C0")]
	internal bool NEPLKJNDANP(PFKAKPCCNDF DLNFADPKCPN, long AMAHEPHGKDI, Action<ANPMFNGIDKO, int> HALFKJOEBKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6664260", Offset = "0x6663660", VA = "0x186664260")]
	internal void MOBPNBPBIGH(long LPFLHBPEIII, Action<ANPMFNGIDKO, int> HALFKJOEBKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NCEEMKEJFAH : IEquatable<NCEEMKEJFAH>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int OIIENOIIOBG = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int JOIABCDCHLC = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int DNPCAANMINN = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int HJJILGMPIED = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid LALCCNAIEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB51610", Offset = "0xB50A10", VA = "0x180B51610")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1BCBFB0", Offset = "0x1BCB3B0", VA = "0x181BCBFB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long IBHBBJILKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xE47C60", Offset = "0xE47060", VA = "0x180E47C60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string GAOODFEKINE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7A26F0", Offset = "0x7A1AF0", VA = "0x1807A26F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7A26A0", Offset = "0x7A1AA0", VA = "0x1807A26A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string EEOFHEPCPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7A26B0", Offset = "0x7A1AB0", VA = "0x1807A26B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string ONEKDNOLHGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7A4970", Offset = "0x7A3D70", VA = "0x1807A4970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A10", Offset = "0x7A4E10", VA = "0x1807A5A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime NHLPDEPDABD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7A47A0", Offset = "0x7A3BA0", VA = "0x1807A47A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x19985F0", Offset = "0x19979F0", VA = "0x1819985F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DateTime ECEGKNPJKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x79E7C0", Offset = "0x79DBC0", VA = "0x18079E7C0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x19B2BF0", Offset = "0x19B1FF0", VA = "0x1819B2BF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public RoomInventoryItemProperties ELKOJPELCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7A6790", Offset = "0x7A5B90", VA = "0x1807A6790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7A67C0", Offset = "0x7A5BC0", VA = "0x1807A67C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6664A60", Offset = "0x6663E60", VA = "0x186664A60")]
	public NCEEMKEJFAH(LMPIHACDFKO DLNFADPKCPN, [Optional] RoomInventoryItemProperties LOFNNPAJGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6664620", Offset = "0x6663A20", VA = "0x186664620", Slot = "4")]
	public bool Equals(NCEEMKEJFAH KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x66647A0", Offset = "0x6663BA0", VA = "0x1866647A0", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6664980", Offset = "0x6663D80", VA = "0x186664980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AKFNEMJOLIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private ANPMFNGIDKO HLADELGLMBD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public NCEEMKEJFAH LMOEFIIDKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7A26E0", Offset = "0x7A1AE0", VA = "0x1807A26E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ANPMFNGIDKO JIJIAACLIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6663E60", Offset = "0x6663260", VA = "0x186663E60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7A2700", Offset = "0x7A1B00", VA = "0x1807A2700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6663EF0", Offset = "0x66632F0", VA = "0x186663EF0")]
	public AKFNEMJOLIK(NCEEMKEJFAH PGILAGIAHLI, [Optional] ANPMFNGIDKO HLADELGLMBD)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6664CC0", Offset = "0x66640C0", VA = "0x186664CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x79E180", Offset = "0x79D580", VA = "0x18079E180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7ABCF0", Offset = "0x7AB0F0", VA = "0x1807ABCF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x912190", Offset = "0x911590", VA = "0x180912190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9121A0", Offset = "0x9115A0", VA = "0x1809121A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public GJOIBCOGMKO Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x79E7B0", Offset = "0x79DBB0", VA = "0x18079E7B0")]
			[CompilerGenerated]
			get
			{
				return default(GJOIBCOGMKO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7A8DD0", Offset = "0x7A81D0", VA = "0x1807A8DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6664B80", Offset = "0x6663F80", VA = "0x186664B80", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6664BC0", Offset = "0x6663FC0", VA = "0x186664BC0")]
		public static RoomInventoryItemProperties IDKMHHLNFJD(RoomInventoryItemProperties LOFNNPAJGEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1A1EEA0", Offset = "0x1A1E2A0", VA = "0x181A1EEA0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class CBAEABPCFHC
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6664570", Offset = "0x6663970", VA = "0x186664570")]
	public static int LMDGFFCBAEB(long NLGPAPDCPAG)
	{
		return default(int);
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
