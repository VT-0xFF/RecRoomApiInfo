using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Dissonance.Integrations.Unity_NFGO;
using Nito.Collections;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Networking_NetcodeImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x809E770", Offset = "0x809CF70", VA = "0x18809E770", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BAPHACNAKDL : LNJGFMPIPIM, ANCMLMHJJCG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DefaultMember("Item")]
	private class IOJDOBKEPJP : IIBEMPIBOEO
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object NOJAFKJLFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x809DC50", Offset = "0x809C450", VA = "0x18809DC50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public byte GJKKOAKOCAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA9E9A0", Offset = "0xA9D1A0", VA = "0x180A9E9A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA9E9B0", Offset = "0xA9D1B0", VA = "0x180A9E9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int DGFEGJFLMJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA76460", Offset = "0xA74C60", VA = "0x180A76460", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xABDC60", Offset = "0xABC460", VA = "0x180ABDC60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object DALPEALLFLO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x79BF3C0", Offset = "0x79BDBC0", VA = "0x1879BF3C0")]
		public IOJDOBKEPJP(byte IDIIIALCIOG, int OHCFIGMIAEM, object IMINNNCPCJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x809DCA0", Offset = "0x809C4A0", VA = "0x18809DCA0", Slot = "8")]
		public bool PLBNMDLFKAN(byte MNMCNOJCKAF, [Out] object MGONBEDEDON)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NetworkManager GPHGMJEOGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NMFABPNHMKD KMGKLCLNJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stopwatch CKBEPBJLONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int MEMDKHALIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Deque<IOJDOBKEPJP> CGEDDGPEAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Deque<Action> JBEIJJHMMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private NENJIFLKIBO FCOBCGFFCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CGJLILJNEOG DGMGLOEHPNB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NetworkManager IMFGBFINLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8098190", Offset = "0x8096990", VA = "0x188098190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NMFABPNHMKD PCFJJFOLGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80", Slot = "4")]
		get
		{
			return default(NMFABPNHMKD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8099A50", Offset = "0x8098250", VA = "0x188099A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DJHBOCLICNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NENJIFLKIBO AAIEKHMDGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CGJLILJNEOG HJOHBMLGKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private NPAEOLAKJHE JIJODOJOBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KACIJDMIGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8099970", Offset = "0x8098170", VA = "0x188099970", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HJDFJHLAAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80987F0", Offset = "0x8096FF0", VA = "0x1880987F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IJMMGFNOKHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80987F0", Offset = "0x8096FF0", VA = "0x1880987F0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LKAMGBDKMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80987F0", Offset = "0x8096FF0", VA = "0x1880987F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Exception EEGCECDGEKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA27520", Offset = "0xA25D20", VA = "0x180A27520", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BHAIMDIJALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool GIEJBAAOGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x809B6A0", Offset = "0x8099EA0", VA = "0x18809B6A0", Slot = "17")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8099230", Offset = "0x8097A30", VA = "0x188099230", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool HGBBLNGEOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xC84660", Offset = "0xC82E60", VA = "0x180C84660")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xC839B0", Offset = "0xC821B0", VA = "0x180C839B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double KFGDBBGOMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x809A670", Offset = "0x8098E70", VA = "0x18809A670")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double JCEFDGMIBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x809B850", Offset = "0x809A050", VA = "0x18809B850")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KICKEIMNLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80987A0", Offset = "0x8096FA0", VA = "0x1880987A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string NFMGLPHFHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8099980", Offset = "0x8098180", VA = "0x188099980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int PJBBBNBGNAI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x809B610", Offset = "0x8099E10", VA = "0x18809B610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public APHIGGECGKN HMOOOMALDMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x809B3B0", Offset = "0x8099BB0", VA = "0x18809B3B0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string, long> BPKKKAIGFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x80998C0", Offset = "0x80980C0", VA = "0x1880998C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x809B400", Offset = "0x8099C00", VA = "0x18809B400", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<NMFABPNHMKD, NMFABPNHMKD> KFDFOEGPFIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x809C240", Offset = "0x809AA40", VA = "0x18809C240", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80982C0", Offset = "0x8096AC0", VA = "0x1880982C0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x809C700", Offset = "0x809AF00", VA = "0x18809C700")]
	public BAPHACNAKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x809B4B0", Offset = "0x8099CB0", VA = "0x18809B4B0")]
	public bool KAAAKEEMNFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x809C440", Offset = "0x809AC40", VA = "0x18809C440")]
	public bool PEEGCCOCKCL(EIGONBNGIIK LJBMHOEFMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x809B380", Offset = "0x8099B80", VA = "0x18809B380")]
	public bool IHKEFBIOODN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x809AFA0", Offset = "0x80997A0", VA = "0x18809AFA0")]
	public void HJIIDCBFLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x809B5E0", Offset = "0x8099DE0", VA = "0x18809B5E0")]
	public void KEINKBKGNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x80996A0", Offset = "0x8097EA0", VA = "0x1880996A0")]
	public void DEMMGMMEHMI(List<object> NFJJCCDFOPE, int COEFDMIBPJJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8098830", Offset = "0x8097030", VA = "0x188098830")]
	public void BGKOEDAOPHI(int FMJAILJAADG, object NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x809A1C0", Offset = "0x80989C0", VA = "0x18809A1C0")]
	public void GIKJDHNPMOC(IDictionary<object, object> JKBGANBHBMG, int FIOLDALLLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x809A3E0", Offset = "0x8098BE0", VA = "0x18809A3E0")]
	public void GJCNJFECIPF(object HPLLAPMNIJF, NativeList<byte> JENCPANOOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x809C150", Offset = "0x809A950", VA = "0x18809C150")]
	public object OLFGCACBCKJ(NativeArray<byte> GJKNNKIANJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8099DA0", Offset = "0x80985A0", VA = "0x188099DA0")]
	public int FBDEKCHJIBC(IIBEMPIBOEO NPLHFNMEMBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x809AFD0", Offset = "0x80997D0", VA = "0x18809AFD0")]
	public bool HPFHOOPLKHJ(byte IDIIIALCIOG, object BMKIAGNKJFP, IKNIODLHFBI OLAJFDBFNIB, IFLICBOELMF CNCFGMMNIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x809A6A0", Offset = "0x8098EA0", VA = "0x18809A6A0")]
	public bool HDJCBGHIHJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x809BF20", Offset = "0x809A720", VA = "0x18809BF20")]
	internal bool OJBIPHAOJBI([In] PCBOKNMLGAK ODHFNHCMJLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8099F90", Offset = "0x8098790", VA = "0x188099F90")]
	internal bool FNHNDAIBGFG([In] PIFHADJEHJB JPCNIAHCHAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8098820", Offset = "0x8097020", VA = "0x188098820")]
	public void CNIEPACJKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8098820", Offset = "0x8097020", VA = "0x188098820")]
	public void BFCHMHAIHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x809BDA0", Offset = "0x809A5A0", VA = "0x18809BDA0")]
	private void OAPMKBJIGED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8099380", Offset = "0x8097B80", VA = "0x188099380")]
	private void DANKJLFAGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x809C2F0", Offset = "0x809AAF0", VA = "0x18809C2F0")]
	private void OPJPCHBOBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8098AD0", Offset = "0x80972D0", VA = "0x188098AD0")]
	private void BIELMAKPPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8097F30", Offset = "0x8096730", VA = "0x188097F30")]
	private void AAABAMGOJAB(ulong PEDJIFKPALI, FastBufferReader BAKGDFIBIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x372A140", Offset = "0x3728940", VA = "0x18372A140")]
	private void ENANJEIMGHF<T>(NMKAIANFDNN IDIIIALCIOG, FastBufferReader BAKGDFIBIND) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8099B60", Offset = "0x8098360", VA = "0x188099B60")]
	private void EMPEHJEBJCM(byte IDIIIALCIOG, int OHCFIGMIAEM, object IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8098E70", Offset = "0x8097670", VA = "0x188098E70")]
	private void BPACPPIBBIA(ulong PEDJIFKPALI, FastBufferReader BAKGDFIBIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x809B880", Offset = "0x809A080", VA = "0x18809B880")]
	private void OAMBENLALBM(IOJDOBKEPJP CJJAIJHHKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x809AB50", Offset = "0x8099350", VA = "0x18809AB50")]
	private void HHGPDNANNMJ(IOJDOBKEPJP CJJAIJHHKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x809B6D0", Offset = "0x8099ED0", VA = "0x18809B6D0")]
	private void MIDFLEEEMJB(IOJDOBKEPJP CJJAIJHHKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x809C550", Offset = "0x809AD50", VA = "0x18809C550")]
	private void PHCCKEJOGCP(IOJDOBKEPJP CJJAIJHHKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8098F80", Offset = "0x8097780", VA = "0x188098F80")]
	private void CAPCJALOAMF(IOJDOBKEPJP CJJAIJHHKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8099260", Offset = "0x8097A60", VA = "0x188099260")]
	private void CJEKFNIAHMN(IOJDOBKEPJP CJJAIJHHKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8098D20", Offset = "0x8097520", VA = "0x188098D20")]
	private void BPACPPIBBIA(IOJDOBKEPJP CJJAIJHHKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8099A90", Offset = "0x8098290", VA = "0x188099A90")]
	private void ELNPEMPIHFE(ulong MAGIPLDDFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8099CB0", Offset = "0x80984B0", VA = "0x188099CB0")]
	private void ENKHJKJEKMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8098370", Offset = "0x8096B70", VA = "0x188098370")]
	private void AENJGFBILNJ(NCGNCPFHELC KKDMEHJOOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8099A80", Offset = "0x8098280", VA = "0x188099A80")]
	[CompilerGenerated]
	private void DPECMKGLICK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NENJIFLKIBO : EIGONBNGIIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private BAPHACNAKDL MJOMJBACEHJ;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static string CJGMCHMOACD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static Func<string, string> GFOEAMLKCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int PKAICCBOBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private string EBGHBPIOIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private ObscuredInt PFDOPBLKGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool? CNHHIMILJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string GKANFADEHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private ulong GFLOCENEKAN;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int DEPNEKDPIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool MHCOJNAJLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA78BE0", Offset = "0xA773E0", VA = "0x180A78BE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xD9DF30", Offset = "0xD9C730", VA = "0x180D9DF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool JAOEDGBPNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x809E190", Offset = "0x809C990", VA = "0x18809E190", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Dictionary<object, object> CNKCOIMOKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string CIGHFCIGCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x809E2E0", Offset = "0x809CAE0", VA = "0x18809E2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HDACOGCCPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x809E090", Offset = "0x809C890", VA = "0x18809E090", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool AGJFHMHBJKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool MELPONKKFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x809DCF0", Offset = "0x809C4F0", VA = "0x18809DCF0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string IBOIILNBDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x809E220", Offset = "0x809CA20", VA = "0x18809E220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string OMAMOEOHIAB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x809E3D0", Offset = "0x809CBD0", VA = "0x18809E3D0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool BKLHNHEJLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public object GFLIKJAGMJP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA27520", Offset = "0xA25D20", VA = "0x180A27520", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	internal ulong OPBPNMMOPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA27530", Offset = "0xA25D30", VA = "0x180A27530")]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x809E2C0", Offset = "0x809CAC0", VA = "0x18809E2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x809E550", Offset = "0x809CD50", VA = "0x18809E550")]
	internal NENJIFLKIBO(BAPHACNAKDL PFBDBGNJMNP, bool DBOEKIJEKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x809E590", Offset = "0x809CD90", VA = "0x18809E590")]
	internal NENJIFLKIBO(BAPHACNAKDL PFBDBGNJMNP, bool DBOEKIJEKEP, ulong MAGIPLDDFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x809E430", Offset = "0x809CC30", VA = "0x18809E430")]
	internal NENJIFLKIBO(BAPHACNAKDL PFBDBGNJMNP, bool DBOEKIJEKEP, [In] PCBOKNMLGAK NPGDCKGOBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x809E0E0", Offset = "0x809C8E0", VA = "0x18809E0E0", Slot = "16")]
	public bool FCIPPGPLNJE(Dictionary<object, object> CDLJALPEFOJ, [Optional] Dictionary<object, object> PFKMJFBIFNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x809DDB0", Offset = "0x809C5B0", VA = "0x18809DDB0")]
	internal void COBGPGMGGKC([In] PCBOKNMLGAK ODHFNHCMJLL, bool FMIAIKDNGJB = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CGJLILJNEOG : NPAEOLAKJHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private BAPHACNAKDL MJOMJBACEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Dictionary<object, object> NPBHEMLGAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal Dictionary<int, NENJIFLKIBO> INJBLKKKLEH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x809CBC0", Offset = "0x809B3C0", VA = "0x18809CBC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public byte IKFFONJFPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x809D040", Offset = "0x809B840", VA = "0x18809D040", Slot = "5")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool HIOBNACHPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Dictionary<object, object> CNKCOIMOKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NENJIFLKIBO[] NPOBGENHDIH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public NENJIFLKIBO[] OIGNDFBJMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public NENJIFLKIBO[] NPAFEMDBHIP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public NENJIFLKIBO[] EDHODEFEHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int IGFMBGPNGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xEE5350", Offset = "0xEE3B50", VA = "0x180EE5350")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xEF8180", Offset = "0xEF6980", VA = "0x180EF8180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x809D660", Offset = "0x809BE60", VA = "0x18809D660")]
	public CGJLILJNEOG(BAPHACNAKDL PFBDBGNJMNP, [In] PIFHADJEHJB JPCNIAHCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x809C940", Offset = "0x809B140", VA = "0x18809C940", Slot = "9")]
	public bool CHGOODIJNIP(int EBHOIBHGECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x809CB30", Offset = "0x809B330", VA = "0x18809CB30", Slot = "8")]
	public bool FCIPPGPLNJE(Dictionary<object, object> CDLJALPEFOJ, [Optional] Dictionary<object, object> CELDENHDIGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x809D4A0", Offset = "0x809BCA0", VA = "0x18809D4A0")]
	internal bool MJCGGBFJECI([In] PCBOKNMLGAK ODHFNHCMJLL, bool LNCBCMICOFA, [Out] NENJIFLKIBO OINLJEGCCDI, bool FMIAIKDNGJB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x809C9A0", Offset = "0x809B1A0", VA = "0x18809C9A0")]
	internal void EJFNEOHCPHD(ulong MAGIPLDDFJB, [Out] NENJIFLKIBO OINLJEGCCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x809CBF0", Offset = "0x809B3F0", VA = "0x18809CBF0")]
	internal void HBDPGLFNDMI([In] PIFHADJEHJB JPCNIAHCHAA, bool FMIAIKDNGJB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x809D090", Offset = "0x809B890", VA = "0x18809D090")]
	private void KGFMOFCBHJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ABHMLJJPLGG : FAFDHONEADA, KIFHCLNMNON, EOGNLCLMPEC, OGBKAHNOBEK, EINHJDEHCCO, NDPGEKOEOMO, OCMCHKKDNBL, ANCMLMHJJCG, EPIHHCLCIAM, JFHHMGBMDLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private BAPHACNAKDL MJOMJBACEHJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int KICKEIMNLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8096780", Offset = "0x8094F80", VA = "0x188096780", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int KCIICHKPAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int DLELEGJFPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8097560", Offset = "0x8095D60", VA = "0x188097560", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int DJHBOCLICNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8097990", Offset = "0x8096190", VA = "0x188097990", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool PAGCGONHNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xC839B0", Offset = "0xC821B0", VA = "0x180C839B0", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public BFMOKJLHFFM NFHEEFGPOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8096A10", Offset = "0x8095210", VA = "0x188096A10", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public double KFGDBBGOMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x80972B0", Offset = "0x8095AB0", VA = "0x1880972B0", Slot = "36")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int PCIAIMFFOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8096C40", Offset = "0x8095440", VA = "0x188096C40", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool GDFMPGDCPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6E013E0", Offset = "0x6DFFBE0", VA = "0x186E013E0", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool HJDFJHLAAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8097180", Offset = "0x8095980", VA = "0x188097180", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool IJMMGFNOKHM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8097180", Offset = "0x8095980", VA = "0x188097180", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool ONAKMGNIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1128190", Offset = "0x1126990", VA = "0x181128190", Slot = "46")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x11281A0", Offset = "0x11269A0", VA = "0x1811281A0", Slot = "47")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool ACMAJMJJHPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool KACIJDMIGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8096DE0", Offset = "0x80955E0", VA = "0x188096DE0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public object KALNNAODLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA274E0", Offset = "0xA25CE0", VA = "0x180A274E0", Slot = "50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EIGONBNGIIK AAIEKHMDGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8097C50", Offset = "0x8096450", VA = "0x188097C50", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int EMFDHCEPDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8097020", Offset = "0x8095820", VA = "0x188097020", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int IIJBNKMEAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8096B90", Offset = "0x8095390", VA = "0x188096B90", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public EIGONBNGIIK HEIMHINEGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8097E30", Offset = "0x8096630", VA = "0x188097E30", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool IHCLLIGFBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8096A60", Offset = "0x8095260", VA = "0x188096A60", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int IKFFONJFPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8097340", Offset = "0x8095B40", VA = "0x188097340", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string CJGMCHMOACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x80975F0", Offset = "0x8095DF0", VA = "0x1880975F0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Func<string, string> GFOEAMLKCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x80973D0", Offset = "0x8095BD0", VA = "0x1880973D0", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public APHIGGECGKN HMOOOMALDMB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x80977F0", Offset = "0x8095FF0", VA = "0x1880977F0", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override bool HGBBLNGEOGB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8097A50", Offset = "0x8096250", VA = "0x188097A50", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8097700", Offset = "0x8095F00", VA = "0x188097700", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override float BPMJCKFKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA43AB0", Offset = "0xA422B0", VA = "0x180A43AB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA53A00", Offset = "0xA52200", VA = "0x180A53A00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override LNJGFMPIPIM CPEFBJOENED
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool NIODOHDPHFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string NFMGLPHFHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8096E00", Offset = "0x8095600", VA = "0x188096E00", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public long PACAPBOGEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8097A40", Offset = "0x8096240", VA = "0x188097A40", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public long DBJELONEBAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8096D20", Offset = "0x8095520", VA = "0x188096D20", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<LNJGFMPIPIM, LNJGFMPIPIM> GMDGALNAHJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x80970D0", Offset = "0x80958D0", VA = "0x1880970D0", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8097730", Offset = "0x8095F30", VA = "0x188097730", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<IIBEMPIBOEO> DOPODGBLLMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8096940", Offset = "0x8095140", VA = "0x188096940", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x80971B0", Offset = "0x80959B0", VA = "0x1880971B0", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<EIGONBNGIIK> NCFLGNMOMLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x80967D0", Offset = "0x8094FD0", VA = "0x1880967D0", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8097A60", Offset = "0x8096260", VA = "0x188097A60", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x80968D0", Offset = "0x80950D0", VA = "0x1880968D0")]
	[NOOFMBJKOEL.LBENCLOPAFN.ODLCBGDPONC]
	internal static void BGEJLCAAPFF(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8097EB0", Offset = "0x80966B0", VA = "0x188097EB0")]
	[RecRoom.DataLayer.Attributes.Preserve]
	public ABHMLJJPLGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8096D30", Offset = "0x8095530", VA = "0x188096D30", Slot = "21")]
	public void DEMMGMMEHMI(List<object> NFJJCCDFOPE, int COEFDMIBPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8097260", Offset = "0x8095A60", VA = "0x188097260", Slot = "23")]
	public void GIKJDHNPMOC(IDictionary<object, object> JKBGANBHBMG, int FIOLDALLLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8097B10", Offset = "0x8096310", VA = "0x188097B10", Slot = "27")]
	public void ODOIMBABJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8096640", Offset = "0x8094E40", VA = "0x188096640", Slot = "56")]
	public bool ADGNIENDMBN(object JAKNJANFBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8097C70", Offset = "0x8096470", VA = "0x188097C70", Slot = "29")]
	public object OLFGCACBCKJ(NativeArray<byte> IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x80968B0", Offset = "0x80950B0", VA = "0x1880968B0", Slot = "55")]
	public void BFCHMHAIHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x80969F0", Offset = "0x80951F0", VA = "0x1880969F0", Slot = "22")]
	public void BGKOEDAOPHI(int FMJAILJAADG, object NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8097480", Offset = "0x8095C80", VA = "0x188097480", Slot = "83")]
	public EIGONBNGIIK IFCONGIFOKK(int DJKBOHPOLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8096C90", Offset = "0x8095490", VA = "0x188096C90", Slot = "82")]
	public EIGONBNGIIK CJBMKANACPI(int NLAPHBJBIHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8097860", Offset = "0x8096060", VA = "0x188097860", Slot = "84")]
	public EIGONBNGIIK LAGBMLCMEAH(int NLAPHBJBIHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8097DF0", Offset = "0x80965F0", VA = "0x188097DF0", Slot = "18")]
	public bool PKJDOPGOPLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8096D50", Offset = "0x8095550", VA = "0x188096D50", Slot = "85")]
	public IReadOnlyList<EIGONBNGIIK> DGELPEKBPOK(bool PLGNMPAKDLM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x80979B0", Offset = "0x80961B0", VA = "0x1880979B0", Slot = "86")]
	public IReadOnlyList<EIGONBNGIIK> MNKPIGMNFNJ(bool PLGNMPAKDLM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x80972F0", Offset = "0x8095AF0", VA = "0x1880972F0", Slot = "54")]
	public bool HDJCBGHIHJK(string LEDBCIOHIBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8096CF0", Offset = "0x80954F0", VA = "0x188096CF0", Slot = "53")]
	public bool CNIEPACJKGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8097080", Offset = "0x8095880", VA = "0x188097080", Slot = "20")]
	public void FADEOOEHCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x80973A0", Offset = "0x8095BA0", VA = "0x1880973A0", Slot = "70")]
	public bool HPFHOOPLKHJ(byte IDIIIALCIOG, object BMKIAGNKJFP, IKNIODLHFBI OLAJFDBFNIB, IFLICBOELMF CNCFGMMNIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8097280", Offset = "0x8095A80", VA = "0x188097280", Slot = "28")]
	public void GJCNJFECIPF(object HPLLAPMNIJF, NativeList<byte> IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x80970B0", Offset = "0x80958B0", VA = "0x1880970B0", Slot = "30")]
	public int FBDEKCHJIBC(IIBEMPIBOEO NPLHFNMEMBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "45")]
	public void GOBOHHJAHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8097CA0", Offset = "0x80964A0", VA = "0x188097CA0", Slot = "87")]
	public bool PEEGCCOCKCL(EIGONBNGIIK LAGPABGGGFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "35")]
	public void LOGBAJOOEIF(string BIOCLFBKCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8097420", Offset = "0x8095C20", VA = "0x188097420", Slot = "17")]
	public float ICCKDGADBNE(bool AAJMDKCHNPM, int DPBGHJOIDCH = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8097DC0", Offset = "0x80965C0", VA = "0x188097DC0", Slot = "8")]
	public override void PHBIFGIMGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8096F00", Offset = "0x8095700", VA = "0x188096F00", Slot = "81")]
	public void EDIANKPHPNC(string HPANEBBHGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8096780", Offset = "0x8094F80", VA = "0x188096780", Slot = "95")]
	public int DOAHLBBMAHP()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8097970", Offset = "0x8096170", VA = "0x188097970", Slot = "11")]
	private void LMINDFPHJMK(Action MGONBEDEDON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x80977E0", Offset = "0x8095FE0", VA = "0x1880977E0", Slot = "12")]
	private void JKMNPDELFOC(Action MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8096B70", Offset = "0x8095370", VA = "0x188096B70", Slot = "25")]
	private void CCGNJELBPHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8097980", Offset = "0x8096180", VA = "0x188097980", Slot = "26")]
	private void MFICNCCPBHF()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8097EA0", Offset = "0x80966A0", VA = "0x188097EA0", Slot = "31")]
	private void PPPMEGAIAIN(float MGONBEDEDON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8097720", Offset = "0x8095F20", VA = "0x188097720", Slot = "32")]
	private void ILPGOHKKJIK(float MGONBEDEDON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8096890", Offset = "0x8095090", VA = "0x188096890", Slot = "57")]
	private void AMPBJDGIPOA(Action<bool> MGONBEDEDON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8096EF0", Offset = "0x80956F0", VA = "0x188096EF0", Slot = "58")]
	private void DJCBJMFHLCL(Action<bool> MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x80968A0", Offset = "0x80950A0", VA = "0x1880968A0", Slot = "59")]
	private void AOEEPGBAJPB(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8096880", Offset = "0x8095080", VA = "0x188096880", Slot = "60")]
	private void AMKOCGLDIAJ(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8097850", Offset = "0x8096050", VA = "0x188097850", Slot = "61")]
	private void LABMEMCOPJM(object KAJENDFCCBJ, bool FNEFOMNCPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8097840", Offset = "0x8096040", VA = "0x188097840", Slot = "62")]
	private IDisposable KEENLIBFBPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8096C30", Offset = "0x8095430", VA = "0x188096C30", Slot = "63")]
	private bool CDJOKJIJCOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8097010", Offset = "0x8095810", VA = "0x188097010", Slot = "64")]
	private void EGNDKNFAKDJ(StringBuilder LOJNECLIFBG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x80976F0", Offset = "0x8095EF0", VA = "0x1880976F0", Slot = "66")]
	private void IJOKEBAPIID(Action<string, long> MGONBEDEDON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8097960", Offset = "0x8096160", VA = "0x188097960", Slot = "67")]
	private void LJKKICAPHNN(Action<string, long> MGONBEDEDON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8096630", Offset = "0x8094E30", VA = "0x188096630", Slot = "88")]
	private void ABPMBGHGHKH(Action MGONBEDEDON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8096B80", Offset = "0x8095380", VA = "0x188096B80", Slot = "89")]
	private void CCINIOAJCDP(Action MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8096B60", Offset = "0x8095360", VA = "0x188096B60", Slot = "90")]
	private void BNDHJHJHAJL()
	{
	}
}
namespace NetcodeImpl
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class DissonanceNetworkManagerInjector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private NfgoCommsNetwork nfgoCommsNetwork;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public NfgoCommsNetwork PIOLOHJCNNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x809DA40", Offset = "0x809C240", VA = "0x18809DA40")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x809DC00", Offset = "0x809C400", VA = "0x18809DC00")]
		private void MECHKEMGGBE(NetworkManager DALEPMPADKP, bool GEKEGLDGPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public DissonanceNetworkManagerInjector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class NetworkManagerBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private NetworkManager networkManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private NetworkManager secondaryNetworkManager;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x809E5D0", Offset = "0x809CDD0", VA = "0x18809E5D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public NetworkManagerBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class COGJCNGNLLN
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool BOKNEKEAPFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9A0", Offset = "0xA9D1A0", VA = "0x180A9E9A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9B0", Offset = "0xA9D1B0", VA = "0x180A9E9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public NetworkManager IMFGBFINLCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public NetworkManager GJJCHAOLLON
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<NetworkManager, bool> MECHKEMGGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x809D990", Offset = "0x809C190", VA = "0x18809D990")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x809D8E0", Offset = "0x809C0E0", VA = "0x18809D8E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6EC53E0", Offset = "0x6EC3BE0", VA = "0x186EC53E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public COGJCNGNLLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x809D800", Offset = "0x809C000", VA = "0x18809D800")]
	[NOOFMBJKOEL.LBENCLOPAFN]
	public static void GPHCJJIBHKD(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x809D870", Offset = "0x809C070", VA = "0x18809D870")]
	public void JNNFKLFCBIG(NetworkManager DALEPMPADKP, bool GEKEGLDGPNJ)
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
