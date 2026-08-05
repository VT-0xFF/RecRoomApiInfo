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
using Netcode.Transports.LiteNetLib;
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
		[Cpp2IlInjected.Address(RVA = "0x85F9EE0", Offset = "0x85F88E0", VA = "0x1885F9EE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GPFHCPHLIFG : BJKLMHEPCLO, IIMNCAIMGCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DefaultMember("Item")]
	private class CPHADCLLMJL : PJCAKALKNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object PCCJLFHFGOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x85F0C00", Offset = "0x85EF600", VA = "0x1885F0C00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public byte CGKLPFAGDGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAFB540", Offset = "0xAF9F40", VA = "0x180AFB540", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xB8BA80", Offset = "0xB8A480", VA = "0x180B8BA80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int HFGLGEFIHFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xBAD7D0", Offset = "0xBAC1D0", VA = "0x180BAD7D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xBAD7E0", Offset = "0xBAC1E0", VA = "0x180BAD7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object LIKGFPBPMOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7E903A0", Offset = "0x7E8EDA0", VA = "0x187E903A0")]
		public CPHADCLLMJL(byte DMJFIGMGCMF, int FPJMIEGHFGE, object BLPDDGCLNPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x85F0BB0", Offset = "0x85EF5B0", VA = "0x1885F0BB0", Slot = "8")]
		public bool BMFHANOLGIO(byte HPFHOBCPNEF, [Out] object KMAFNKGMDCF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private DMACAFBGIPF MIGEDPOLHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stopwatch MCKFCODDKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int INCJPINPHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Deque<CPHADCLLMJL> LEDABCFBDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Deque<Action> MBHMHFIEICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private NLNJLPOLNAJ FFAPMKKAFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private EOPIODNPIOB PHCMEFMGJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool GKCHPDLIGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool MNJLBBHOIDO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public INetworkManager OMCMCOEIDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LiteNetLibTransport OPINDJHKCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85F74A0", Offset = "0x85F5EA0", VA = "0x1885F74A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DMACAFBGIPF EMLDAGBBEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85F47D0", Offset = "0x85F31D0", VA = "0x1885F47D0", Slot = "4")]
		get
		{
			return default(DMACAFBGIPF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85F6940", Offset = "0x85F5340", VA = "0x1885F6940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KOKBCONHIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NLNJLPOLNAJ OPIAAKOABFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EOPIODNPIOB DEBNAMCNBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private DFBDLHJHAKP HMDMCPECOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NIDBLCGELDA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85F6360", Offset = "0x85F4D60", VA = "0x1885F6360", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MNLFPPPNCMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85F3050", Offset = "0x85F1A50", VA = "0x1885F3050", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool IBIKAAOHHLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85F3050", Offset = "0x85F1A50", VA = "0x1885F3050", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool CCBHKIOPEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85F3050", Offset = "0x85F1A50", VA = "0x1885F3050", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool DPMNCDPBCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7F0", Offset = "0xB2E1F0", VA = "0x180B2F7F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85F3750", Offset = "0x85F2150", VA = "0x1885F3750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Exception PLIBAKIKGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAB4800", Offset = "0xAB3200", VA = "0x180AB4800", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int INBCLNPIMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool DLOCLPHMMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85F66C0", Offset = "0x85F50C0", VA = "0x1885F66C0", Slot = "17")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85F3D90", Offset = "0x85F2790", VA = "0x1885F3D90", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool KEFKLPMLLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xABA770", Offset = "0xAB9170", VA = "0x180ABA770")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xABA920", Offset = "0xAB9320", VA = "0x180ABA920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double IBJIMPNBLHE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85F31C0", Offset = "0x85F1BC0", VA = "0x1885F31C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double NJKMNPDFJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85F6970", Offset = "0x85F5370", VA = "0x1885F6970")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int BIHNMIFEOFO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85F3210", Offset = "0x85F1C10", VA = "0x1885F3210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string GJFPOCALNKD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85F4960", Offset = "0x85F3360", VA = "0x1885F4960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int OBFHKBOGPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85F6130", Offset = "0x85F4B30", VA = "0x1885F6130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GHOJGMIPGGO NNGKKHHDLED
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85F4800", Offset = "0x85F3200", VA = "0x1885F4800", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EPCHAIBICHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xDD49D0", Offset = "0xDD33D0", VA = "0x180DD49D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85F6330", Offset = "0x85F4D30", VA = "0x1885F6330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string, long> IJOLGFOAPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85F33F0", Offset = "0x85F1DF0", VA = "0x1885F33F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85F4850", Offset = "0x85F3250", VA = "0x1885F4850", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<DMACAFBGIPF, DMACAFBGIPF> BHDKFNNMNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85F69C0", Offset = "0x85F53C0", VA = "0x1885F69C0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85F2340", Offset = "0x85F0D40", VA = "0x1885F2340", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x85F75B0", Offset = "0x85F5FB0", VA = "0x1885F75B0")]
	public GPFHCPHLIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x85F4A60", Offset = "0x85F3460", VA = "0x1885F4A60")]
	public bool IODAEJNKHNE(object NLEILGKGNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x85F6710", Offset = "0x85F5110", VA = "0x1885F6710")]
	private void NCCCNAPCOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x85F4900", Offset = "0x85F3300", VA = "0x1885F4900")]
	private void IFOMNAHKCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x85F2850", Offset = "0x85F1250", VA = "0x1885F2850")]
	public bool ALKOBMOMHBA(FNAEIBBBBBE ABEOEBEFJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x85F4180", Offset = "0x85F2B80", VA = "0x1885F4180")]
	public bool GEKKDMCHOGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85F6390", Offset = "0x85F4D90", VA = "0x1885F6390")]
	public void MFNABGLOOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x85F2280", Offset = "0x85F0C80", VA = "0x1885F2280")]
	public void AHFCCPGIEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x85F2B30", Offset = "0x85F1530", VA = "0x1885F2B30")]
	public void BJOANPGEBAO(List<object> GBEHGKLEJFE, int MHADOGLMBLF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85F5520", Offset = "0x85F3F20", VA = "0x1885F5520")]
	public void KIDGHHPCADD(int AJDKDOCHCDB, object PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x85F2090", Offset = "0x85F0A90", VA = "0x1885F2090")]
	public void AELHLFDGEMI(object CKKGCGIJFBK, int MCNJLDELGIJ, bool EEBDOKMMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x85F3DF0", Offset = "0x85F27F0", VA = "0x1885F3DF0")]
	public void GCGCKFHBJPB(object PMNHIPACJLN, NativeList<byte> BHDBAJPOPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85F6040", Offset = "0x85F4A40", VA = "0x1885F6040")]
	public object LEOAOCFGODA(NativeArray<byte> KGCMICBGABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x85F50A0", Offset = "0x85F3AA0", VA = "0x1885F50A0")]
	public int JNHPHOIDPKC(PJCAKALKNLJ PPGGMEFFGDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x85F23F0", Offset = "0x85F0DF0", VA = "0x1885F23F0")]
	public bool AJMCEANPHKH(byte DMJFIGMGCMF, object KNFKFJIPOBJ, LAAOOMKIIJB IAJLLBCOKMJ, DFHGKHIBBFL EDMBENGILFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85F6F90", Offset = "0x85F5990", VA = "0x1885F6F90")]
	public bool PKOPEODCNCN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x85F41D0", Offset = "0x85F2BD0", VA = "0x1885F41D0")]
	internal bool GOCCELFALFB([In] EOALOEPEOPM ILFDPMAFBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x85F5DB0", Offset = "0x85F47B0", VA = "0x1885F5DB0")]
	internal bool KPCBJEEGBKK([In] MBDNFBNELBA KALMEDGIGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x85F2970", Offset = "0x85F1370", VA = "0x1885F2970")]
	private void APPGLHFNMNI(bool MNJLBBHOIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x85F3260", Offset = "0x85F1C60", VA = "0x1885F3260")]
	public void DNFOJMPPCAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x85F3D80", Offset = "0x85F2780", VA = "0x1885F3D80")]
	public void FJIMPEDAFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x85F3270", Offset = "0x85F1C70", VA = "0x1885F3270")]
	private void EADDGOFEOKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x85F4D80", Offset = "0x85F3780", VA = "0x1885F4D80")]
	private void JJFGPOBHMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x85F6240", Offset = "0x85F4C40", VA = "0x1885F6240")]
	private void LKCLFMLKDPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x85F63E0", Offset = "0x85F4DE0", VA = "0x1885F63E0")]
	private void NAFPPGKJHIA(bool BJIHMNPKHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x85F5290", Offset = "0x85F3C90", VA = "0x1885F5290")]
	private void KHDLNDLPIMI(ulong KKDMAKPEFJJ, FastBufferReader GMCGJHIHDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA7C0", Offset = "0x3DB91C0", VA = "0x183DBA7C0")]
	private void KELNMAALINI<T>(CKGOBLHCBGP DMJFIGMGCMF, FastBufferReader GMCGJHIHDCD) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x85F4680", Offset = "0x85F3080", VA = "0x1885F4680")]
	private void HADCLIBCBDP(byte DMJFIGMGCMF, int FPJMIEGHFGE, object BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x85F4570", Offset = "0x85F2F70", VA = "0x1885F4570")]
	private void HACIFDEBANE(ulong KKDMAKPEFJJ, FastBufferReader GMCGJHIHDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85F5980", Offset = "0x85F4380", VA = "0x1885F5980")]
	private void KLEDIGLLACE(byte DMJFIGMGCMF, object BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x85F6A70", Offset = "0x85F5470", VA = "0x1885F6A70")]
	private void PDCAHFFLLEL(CPHADCLLMJL DHNILGMCEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x85F2D40", Offset = "0x85F1740", VA = "0x1885F2D40")]
	private void CBNDCLDBGLE(CPHADCLLMJL DHNILGMCEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x85F3A00", Offset = "0x85F2400", VA = "0x1885F3A00")]
	private void FJHDHEFKABP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x85F3870", Offset = "0x85F2270", VA = "0x1885F3870")]
	private void FBLEEJPBBLK(CPHADCLLMJL DHNILGMCEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x85F57C0", Offset = "0x85F41C0", VA = "0x1885F57C0")]
	private void KJKGJEKIBDG(CPHADCLLMJL DHNILGMCEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x85F34A0", Offset = "0x85F1EA0", VA = "0x1885F34A0")]
	private void EOKJPNABFID(CPHADCLLMJL DHNILGMCEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x85F30A0", Offset = "0x85F1AA0", VA = "0x1885F30A0")]
	private void COBMAKEADPM(CPHADCLLMJL DHNILGMCEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x85F4420", Offset = "0x85F2E20", VA = "0x1885F4420")]
	private void HACIFDEBANE(CPHADCLLMJL DHNILGMCEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x85F6160", Offset = "0x85F4B60", VA = "0x1885F6160")]
	private void LHEPMPPNIAH(ulong KAJNACGJJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x85F4080", Offset = "0x85F2A80", VA = "0x1885F4080")]
	private void GDHGGODOHPM(bool BJIHMNPKHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x85F59B0", Offset = "0x85F43B0", VA = "0x1885F59B0")]
	private void KOCNACFGGDA(NHLJKPJALOB OCPBLKDBBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x85F47F0", Offset = "0x85F31F0", VA = "0x1885F47F0")]
	[CompilerGenerated]
	private void HJEPCOHNKFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NLNJLPOLNAJ : FNAEIBBBBBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private GPFHCPHLIFG HJNICLFKGGJ;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static string MACMGPHDDIM;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static Func<string, string> CEGLKGFBICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int IJIKLILPLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private string MJLFDPCMNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private ObscuredInt LCJMHNFCPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool? LNIPPHMJKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private string NMKAJBHPIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private ulong GFHDOABCAAM;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int JINNHDPFDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool DMADDMDAFPN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xB7AFD0", Offset = "0xB799D0", VA = "0x180B7AFD0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xEC7F80", Offset = "0xEC6980", VA = "0x180EC7F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PBDECKHLLLD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x85F9390", Offset = "0x85F7D90", VA = "0x1885F9390", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Dictionary<object, object> HBMCPOCMFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public string CDGJAMPNPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x85F92A0", Offset = "0x85F7CA0", VA = "0x1885F92A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int HNINNMIFECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x85F9760", Offset = "0x85F8160", VA = "0x1885F9760", Slot = "9")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x85F9420", Offset = "0x85F7E20", VA = "0x1885F9420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool PEGNIJAPJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x19D98C0", Offset = "0x19D82C0", VA = "0x1819D98C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x19F8950", Offset = "0x19F7350", VA = "0x1819F8950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool BHLEMNNIMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x85F97B0", Offset = "0x85F81B0", VA = "0x1885F97B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string LGOBMAEDMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x85F96C0", Offset = "0x85F80C0", VA = "0x1885F96C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public string DEFJGELMDDF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x85F95B0", Offset = "0x85F7FB0", VA = "0x1885F95B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool JIEPBNPFEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public object JPBACGEAAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	internal ulong ICJGOMFPHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x85F9B60", Offset = "0x85F8560", VA = "0x1885F9B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x85F9BC0", Offset = "0x85F85C0", VA = "0x1885F9BC0")]
	internal NLNJLPOLNAJ(GPFHCPHLIFG JJKGNBHNOOC, bool OIENONFCDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85F9B80", Offset = "0x85F8580", VA = "0x1885F9B80")]
	internal NLNJLPOLNAJ(GPFHCPHLIFG JJKGNBHNOOC, bool OIENONFCDKD, ulong KAJNACGJJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x85F9C00", Offset = "0x85F8600", VA = "0x1885F9C00")]
	internal NLNJLPOLNAJ(GPFHCPHLIFG JJKGNBHNOOC, bool OIENONFCDKD, [In] EOALOEPEOPM MENEHAIMEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x85F9610", Offset = "0x85F8010", VA = "0x1885F9610", Slot = "16")]
	public bool EHLBACOHMGH(Dictionary<object, object> EDLNMJEFDGK, [Optional] Dictionary<object, object> PBGHKIFOBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x85F9490", Offset = "0x85F7E90", VA = "0x1885F9490")]
	public EOALOEPEOPM CJDHAHLOHBM()
	{
		return default(EOALOEPEOPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x85F9870", Offset = "0x85F8270", VA = "0x1885F9870")]
	internal void MKLKAMCKECM([In] EOALOEPEOPM ILFDPMAFBIL, bool LEADLCOOOCJ = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EOPIODNPIOB : DFBDLHJHAKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private GPFHCPHLIFG HJNICLFKGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private Dictionary<object, object> JDFPKECBAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal Dictionary<int, NLNJLPOLNAJ> MCEBBJFOCMH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85F1CA0", Offset = "0x85F06A0", VA = "0x1885F1CA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte GMODFLLNLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85F1E90", Offset = "0x85F0890", VA = "0x1885F1E90", Slot = "5")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool BGCCNINLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xB36DB0", Offset = "0xB357B0", VA = "0x180B36DB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Dictionary<object, object> HBMCPOCMFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public NLNJLPOLNAJ[] HGJEBGAKMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public NLNJLPOLNAJ[] DIOHJNLIALL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public NLNJLPOLNAJ[] PIBHACILEEC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public NLNJLPOLNAJ[] DKIBKACDDLB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int HBDJCBFLOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xECFBA0", Offset = "0xECE5A0", VA = "0x180ECFBA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1026A90", Offset = "0x1025490", VA = "0x181026A90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x85F1EE0", Offset = "0x85F08E0", VA = "0x1885F1EE0")]
	public EOPIODNPIOB(GPFHCPHLIFG JJKGNBHNOOC, [In] MBDNFBNELBA KALMEDGIGPJ, bool CJIBNDHAKHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x85F1C40", Offset = "0x85F0640", VA = "0x1885F1C40", Slot = "9")]
	public bool FCECNFONBKG(int NMAIBBDGPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x85F1B90", Offset = "0x85F0590", VA = "0x1885F1B90", Slot = "8")]
	public bool EHLBACOHMGH(Dictionary<object, object> EDLNMJEFDGK, [Optional] Dictionary<object, object> NEPHHFFPGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x85F1CD0", Offset = "0x85F06D0", VA = "0x1885F1CD0")]
	internal bool LJHLJFJBOOO([In] EOALOEPEOPM ILFDPMAFBIL, bool CCDFEMAAIBO, [Out] NLNJLPOLNAJ BLHNDOLLIDD, bool LEADLCOOOCJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x85F19F0", Offset = "0x85F03F0", VA = "0x1885F19F0")]
	internal void EDIAENEDMAO(ulong KAJNACGJJJD, [Out] NLNJLPOLNAJ BLHNDOLLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x85F15A0", Offset = "0x85EFFA0", VA = "0x1885F15A0")]
	internal void BOJCAEJLKHA([In] MBDNFBNELBA KALMEDGIGPJ, bool LEADLCOOOCJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x85F1160", Offset = "0x85EFB60", VA = "0x1885F1160")]
	private void BJMBLKCGGKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HKLHHPAOLCA : OMIIFFJNBOK, HJKBCKDIADL, JPHKCLGGIJI, CKHBACPBGOP, DJNKJPOENBH, GKOBHHCNMBJ, MJINEADEAIK, IIMNCAIMGCM, HMIEKFILILP, LIBCLKKBGAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private GPFHCPHLIFG HJNICLFKGGJ;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int BIHNMIFEOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x85F7CF0", Offset = "0x85F66F0", VA = "0x1885F7CF0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int IAIHEMFNAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int GLPOHBGFIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x85F86E0", Offset = "0x85F70E0", VA = "0x1885F86E0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int KOKBCONHIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x85F88C0", Offset = "0x85F72C0", VA = "0x1885F88C0", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool MAGEPJECJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xD7D250", Offset = "0xD7BC50", VA = "0x180D7D250", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public double IBJIMPNBLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x85F7C90", Offset = "0x85F6690", VA = "0x1885F7C90", Slot = "35")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int MPDLGMADCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x85F8AE0", Offset = "0x85F74E0", VA = "0x1885F8AE0", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool NKOPIKADNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x727C920", Offset = "0x727B320", VA = "0x18727C920", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool MNLFPPPNCMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x85F7C20", Offset = "0x85F6620", VA = "0x1885F7C20", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool IBIKAAOHHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x85F7C20", Offset = "0x85F6620", VA = "0x1885F7C20", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DPMNCDPBCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85F88E0", Offset = "0x85F72E0", VA = "0x1885F88E0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85F8050", Offset = "0x85F6A50", VA = "0x1885F8050", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool DKFHHLKKIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x85F8D10", Offset = "0x85F7710", VA = "0x1885F8D10", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NIDBLCGELDA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x85F8CB0", Offset = "0x85F76B0", VA = "0x1885F8CB0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public object FEAAKOPPOKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAB47F0", Offset = "0xAB31F0", VA = "0x180AB47F0", Slot = "50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public FNAEIBBBBBE OPIAAKOABFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85F7E80", Offset = "0x85F6880", VA = "0x1885F7E80", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int LJPALJGINMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x85F7F80", Offset = "0x85F6980", VA = "0x1885F7F80", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int PFDCHAAKNAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x85F8E60", Offset = "0x85F7860", VA = "0x1885F8E60", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FNAEIBBBBBE NLCLELPBFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x85F7AF0", Offset = "0x85F64F0", VA = "0x1885F7AF0", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool DGEAHJMLCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x85F7D60", Offset = "0x85F6760", VA = "0x1885F7D60", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int GMODFLLNLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x85F8B70", Offset = "0x85F7570", VA = "0x1885F8B70", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string MACMGPHDDIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85F8F20", Offset = "0x85F7920", VA = "0x1885F8F20", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Func<string, string> CEGLKGFBICN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x85F8320", Offset = "0x85F6D20", VA = "0x1885F8320", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public GHOJGMIPGGO NNGKKHHDLED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x85F84D0", Offset = "0x85F6ED0", VA = "0x1885F84D0", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override bool KEFKLPMLLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x85F7C80", Offset = "0x85F6680", VA = "0x1885F7C80", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x85F8C90", Offset = "0x85F7690", VA = "0x1885F8C90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override float MKJOCLLLBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAC8600", Offset = "0xAC7000", VA = "0x180AC8600", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAD89E0", Offset = "0xAD73E0", VA = "0x180AD89E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public override BJKLMHEPCLO NHJGOBAPCLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool EPCHAIBICHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x85F8070", Offset = "0x85F6A70", VA = "0x1885F8070", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x85F8BE0", Offset = "0x85F75E0", VA = "0x1885F8BE0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string GJFPOCALNKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x85F8520", Offset = "0x85F6F20", VA = "0x1885F8520", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public long OEAPBEJDMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x85F8AD0", Offset = "0x85F74D0", VA = "0x1885F8AD0", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public long LLPDNGIFKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x85F8040", Offset = "0x85F6A40", VA = "0x1885F8040", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<BJKLMHEPCLO, BJKLMHEPCLO> GGHKMNLDMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x85F77F0", Offset = "0x85F61F0", VA = "0x1885F77F0", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x85F7B60", Offset = "0x85F6560", VA = "0x1885F7B60", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<PJCAKALKNLJ> AFHNFOLIALG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x85F90F0", Offset = "0x85F7AF0", VA = "0x1885F90F0", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x85F9040", Offset = "0x85F7A40", VA = "0x1885F9040", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<FNAEIBBBBBE> LBGOLLLEDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x85F8200", Offset = "0x85F6C00", VA = "0x1885F8200", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x85F7900", Offset = "0x85F6300", VA = "0x1885F7900", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x85F82B0", Offset = "0x85F6CB0", VA = "0x1885F82B0")]
	[DMKNBLIJJON.EGFDFBOLNDK.IOMGPCDPIJG]
	internal static void HFPMPAAENFC(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x85F9220", Offset = "0x85F7C20", VA = "0x1885F9220")]
	[RecRoom.DataLayer.Attributes.Preserve]
	public HKLHHPAOLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x85F7AD0", Offset = "0x85F64D0", VA = "0x1885F7AD0", Slot = "21")]
	public void BJOANPGEBAO(List<object> GBEHGKLEJFE, int MHADOGLMBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x85F78A0", Offset = "0x85F62A0", VA = "0x1885F78A0", Slot = "23")]
	public void AELHLFDGEMI(object CKKGCGIJFBK, int MCNJLDELGIJ, bool EEBDOKMMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x85F8390", Offset = "0x85F6D90", VA = "0x1885F8390", Slot = "27")]
	public void ICJFDANGLKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x85F8F00", Offset = "0x85F7900", VA = "0x1885F8F00", Slot = "56")]
	public bool NPDBBMJHCIJ(object NLEILGKGNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x85F8A90", Offset = "0x85F7490", VA = "0x1885F8A90", Slot = "29")]
	public object LEOAOCFGODA(NativeArray<byte> BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x85F8080", Offset = "0x85F6A80", VA = "0x1885F8080", Slot = "55")]
	public void FJIMPEDAFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x85F88A0", Offset = "0x85F72A0", VA = "0x1885F88A0", Slot = "22")]
	public void KIDGHHPCADD(int AJDKDOCHCDB, object PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x85F8110", Offset = "0x85F6B10", VA = "0x1885F8110", Slot = "83")]
	public FNAEIBBBBBE GNGFGILOIAK(int KPCCLFNHPJC, bool JPNDNIPFNOO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x85F8900", Offset = "0x85F7300", VA = "0x1885F8900", Slot = "82")]
	public FNAEIBBBBBE LBPOMOEKJJO(int AKCNDIOJIBG, bool JPNDNIPFNOO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x85F8D50", Offset = "0x85F7750", VA = "0x1885F8D50", Slot = "84")]
	public FNAEIBBBBBE NJLEKKMOKPG(int AKCNDIOJIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x85F8720", Offset = "0x85F7120", VA = "0x1885F8720", Slot = "18")]
	public bool JLDADNKELIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x85F7EF0", Offset = "0x85F68F0", VA = "0x1885F7EF0", Slot = "85")]
	public IReadOnlyList<FNAEIBBBBBE> EAHLEHBCINN(bool JPNDNIPFNOO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x85F8640", Offset = "0x85F7040", VA = "0x1885F8640", Slot = "86")]
	public IReadOnlyList<FNAEIBBBBBE> IKKOGALDJEA(bool JPNDNIPFNOO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x85F91A0", Offset = "0x85F7BA0", VA = "0x1885F91A0", Slot = "54")]
	public bool PKOPEODCNCN(string ALELBGJEGPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x85F7EB0", Offset = "0x85F68B0", VA = "0x1885F7EB0", Slot = "53")]
	public bool DNFOJMPPCAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x85F87C0", Offset = "0x85F71C0", VA = "0x1885F87C0", Slot = "20")]
	public void KBGNGIDOKIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x85F78D0", Offset = "0x85F62D0", VA = "0x1885F78D0", Slot = "70")]
	public bool AJMCEANPHKH(byte DMJFIGMGCMF, object KNFKFJIPOBJ, LAAOOMKIIJB IAJLLBCOKMJ, DFHGKHIBBFL EDMBENGILFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x85F80B0", Offset = "0x85F6AB0", VA = "0x1885F80B0", Slot = "28")]
	public void GCGCKFHBJPB(object PMNHIPACJLN, NativeList<byte> BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x85F8780", Offset = "0x85F7180", VA = "0x1885F8780", Slot = "30")]
	public int JNHPHOIDPKC(PJCAKALKNLJ PPGGMEFFGDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "45")]
	public void PINLJNEOKBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x85F79B0", Offset = "0x85F63B0", VA = "0x1885F79B0", Slot = "87")]
	public bool ALKOBMOMHBA(FNAEIBBBBBE NMJFGDKALHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "34")]
	public void KLKKGMKBHON(string GFEKPKAAFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x85F8C20", Offset = "0x85F7620", VA = "0x1885F8C20", Slot = "17")]
	public float MECPCLMBJEF(bool IJPAFOGBOLE, int FLKEJIBFIAJ = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x85F7FE0", Offset = "0x85F69E0", VA = "0x1885F7FE0", Slot = "8")]
	public override void EFHMDKJKIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x85F8970", Offset = "0x85F7370", VA = "0x1885F8970", Slot = "81")]
	public void LDGHDHGLOIL(string IELIBBNCJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x85F7CF0", Offset = "0x85F66F0", VA = "0x1885F7CF0", Slot = "95")]
	public int OKPLFHJGHAN()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x85F7EE0", Offset = "0x85F68E0", VA = "0x1885F7EE0", Slot = "11")]
	private void DOICFBIMCOE(Action KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x85F8380", Offset = "0x85F6D80", VA = "0x1885F8380", Slot = "12")]
	private void ICFLPBLIEMP(Action KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x85F8100", Offset = "0x85F6B00", VA = "0x1885F8100", Slot = "25")]
	private void GFMONBOOKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x85F9030", Offset = "0x85F7A30", VA = "0x1885F9030", Slot = "26")]
	private void ODOGJIMBDFO()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x85F80F0", Offset = "0x85F6AF0", VA = "0x1885F80F0", Slot = "31")]
	private void GDEEKKBKBOL(float KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x85F87B0", Offset = "0x85F71B0", VA = "0x1885F87B0", Slot = "32")]
	private void KADOMGNFPBC(float KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x85F7C10", Offset = "0x85F6610", VA = "0x1885F7C10", Slot = "57")]
	private void CEHJFIOGLBB(Action<bool> KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x85F7D50", Offset = "0x85F6750", VA = "0x1885F7D50", Slot = "58")]
	private void DEFCAACMBMB(Action<bool> KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x85F8E50", Offset = "0x85F7850", VA = "0x1885F8E50", Slot = "59")]
	private void NKPKIMJGBMP(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x85F80E0", Offset = "0x85F6AE0", VA = "0x1885F80E0", Slot = "60")]
	private void GDDJOHAGFAN(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x85F8D00", Offset = "0x85F7700", VA = "0x1885F8D00", Slot = "61")]
	private void MGBBEEGGFNA(object MFKHKDDANII, bool PNBIMDNKJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x85F8A80", Offset = "0x85F7480", VA = "0x1885F8A80", Slot = "62")]
	private IDisposable LEGENMCHDNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x85F8890", Offset = "0x85F7290", VA = "0x1885F8890", Slot = "63")]
	private bool KEOIAIGPJBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x85F8BD0", Offset = "0x85F75D0", VA = "0x1885F8BD0", Slot = "64")]
	private void MAJFEKIEKKL(StringBuilder LCJDGNFDCBJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x85F8B60", Offset = "0x85F7560", VA = "0x1885F8B60", Slot = "66")]
	private void LNMODMDKOKK(Action<string, long> KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x85F8AC0", Offset = "0x85F74C0", VA = "0x1885F8AC0", Slot = "67")]
	private void LKIFPNFLELH(Action<string, long> KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x85F87A0", Offset = "0x85F71A0", VA = "0x1885F87A0", Slot = "88")]
	private void JNLAICCBMEL(Action KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x85F86D0", Offset = "0x85F70D0", VA = "0x1885F86D0", Slot = "89")]
	private void IPDHHBCOFJJ(Action KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x85F7EA0", Offset = "0x85F68A0", VA = "0x1885F7EA0", Slot = "90")]
	private void DMKPNLNAPGJ()
	{
	}
}
namespace NetcodeImpl
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class DissonanceNetworkManagerInjector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private NfgoCommsNetwork nfgoCommsNetwork;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public NfgoCommsNetwork JKBDJLKLGGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C50", Offset = "0x85EF650", VA = "0x1885F0C50")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x85F0E10", Offset = "0x85EF810", VA = "0x1885F0E10")]
		private void MAIGNLEGDCF(NetworkManager OGJEKIBPJFL, bool ICFJDJILLLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public DissonanceNetworkManagerInjector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class NetworkManagerBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private NetworkManager networkManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private NetworkManager secondaryNetworkManager;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x85F9D20", Offset = "0x85F8720", VA = "0x1885F9D20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public NetworkManagerBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EHNHOBKCIKI
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool NLIKCFJMIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xAFB540", Offset = "0xAF9F40", VA = "0x180AFB540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA80", Offset = "0xB8A480", VA = "0x180B8BA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public NetworkManager OMCMCOEIDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public NetworkManager IDNHDJODPIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public INetworkManager KNEOOEJPMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<NetworkManager, bool> MAIGNLEGDCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x85F0E60", Offset = "0x85EF860", VA = "0x1885F0E60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x85F0FF0", Offset = "0x85EF9F0", VA = "0x1885F0FF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x85F10A0", Offset = "0x85EFAA0", VA = "0x1885F10A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EHNHOBKCIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x85F0F80", Offset = "0x85EF980", VA = "0x1885F0F80")]
	[DMKNBLIJJON.EGFDFBOLNDK]
	public static void NHHMPHHOCME(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x85F0F10", Offset = "0x85EF910", VA = "0x1885F0F10")]
	public void IJOOHDEOHGB(NetworkManager OGJEKIBPJFL, bool ICFJDJILLLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ADFBGAEGEOB : INetworkManager, INetworkUpdateSystem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private float CPNMJEPLLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private CustomMessagingManager.HandleNamedMessageDelegate FNIKCOIMBFC;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public ulong LBBIDDPMKMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xC43520", Offset = "0xC41F20", VA = "0x180C43520", Slot = "8")]
		get
		{
			return default(ulong);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool MMBJCPNLDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C80", Offset = "0xAB4680", VA = "0x180AB5C80", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool AALKFLEJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<ulong> GDKDEBLJDJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x85F0910", Offset = "0x85EF310", VA = "0x1885F0910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x85F0A60", Offset = "0x85EF460", VA = "0x1885F0A60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action KIDGMCOHFGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x85F09C0", Offset = "0x85EF3C0", VA = "0x1885F09C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x85F0B10", Offset = "0x85EF510", VA = "0x1885F0B10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x85F0820", Offset = "0x85EF220", VA = "0x1885F0820", Slot = "12")]
	public double GetLocalTime()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x85F0820", Offset = "0x85EF220", VA = "0x1885F0820", Slot = "13")]
	public double GetServerTime()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "14")]
	public int GetRoundTripTime()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "15")]
	public NetworkConfig GetNetworkConfig()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "16")]
	public void SendAllOutgoingMessages(bool GGLEBFPKGLC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "17")]
	public void ClearOutgoingMessages(bool HMHFDOHJFPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "18")]
	public void ProcessIncommingMessages()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x85F08A0", Offset = "0x85EF2A0", VA = "0x1885F08A0")]
	public ADFBGAEGEOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x85F0840", Offset = "0x85EF240", VA = "0x1885F0840", Slot = "22")]
	public void NetworkUpdate(NetworkUpdateStage HODNJDDHKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x85F0860", Offset = "0x85EF260", VA = "0x1885F0860", Slot = "19")]
	public void RegisterNamedMessageHandler(NamedMessageType IELIBBNCJAC, CustomMessagingManager.HandleNamedMessageDelegate AEPCPKCINPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x85F0880", Offset = "0x85EF280", VA = "0x1885F0880", Slot = "20")]
	public void UnregisterNamedMessageHandler(NamedMessageType IELIBBNCJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "21")]
	public void SendCustomMessage(NamedMessageType APEAJKLAJFN, ulong KAJNACGJJJD, FastBufferWriter PLCMMFFOOBE, NetworkDelivery EDMBENGILFI)
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
