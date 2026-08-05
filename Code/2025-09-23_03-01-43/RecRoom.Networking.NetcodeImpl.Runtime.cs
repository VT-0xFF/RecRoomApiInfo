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
		[Cpp2IlInjected.Address(RVA = "0x8604190", Offset = "0x8602790", VA = "0x188604190", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ENCACBGKGPK : OHBJKFKAMJM, NFBOJFIGOOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DefaultMember("Item")]
	private class PAECKICGHII : NDDAOAIJPDM
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object LAJHLDAJFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8604070", Offset = "0x8602670", VA = "0x188604070", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public byte IMPKHAHNELP
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAFE8C0", Offset = "0xAFCEC0", VA = "0x180AFE8C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xB82B90", Offset = "0xB81190", VA = "0x180B82B90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int PBMONNHFCBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xB9FCB0", VA = "0x180BA16B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xBA16C0", Offset = "0xB9FCC0", VA = "0x180BA16C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object PKFLLHJFNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7E97D30", Offset = "0x7E96330", VA = "0x187E97D30")]
		public PAECKICGHII(byte NLMJOFNGIOJ, int OBAFOAGLIMM, object CDDIADBJAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8604020", Offset = "0x8602620", VA = "0x188604020", Slot = "8")]
		public bool DCJACLLMOIN(byte HAELBKGFDIJ, [Out] object KOPHBHGIACG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private DILFOBKEADN NHCOKLGKILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stopwatch FNDGLOOHJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int FKGFJAJINPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Deque<PAECKICGHII> OIDEONFEIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Deque<Action> GPKAANNJNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private CFFCOKPAIPK EMNFHFLGNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private HELKAMCFFGK IKGPOKELJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool JDPLENLEIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool DANCEOGFGKF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public INetworkManager JCEEGLCMPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LiteNetLibTransport ABLBAHNGOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85FD2C0", Offset = "0x85FB8C0", VA = "0x1885FD2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DILFOBKEADN DPPEHBACENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85FDC20", Offset = "0x85FC220", VA = "0x1885FDC20", Slot = "4")]
		get
		{
			return default(DILFOBKEADN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86007A0", Offset = "0x85FEDA0", VA = "0x1886007A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int CNHBLGKNIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA70A0", Offset = "0xAA56A0", VA = "0x180AA70A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CFFCOKPAIPK KPFDOFKDHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HELKAMCFFGK BIJIOBEBKAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private FHLBLEADILO CGJONGABGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DMOJCIPDMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85FF410", Offset = "0x85FDA10", VA = "0x1885FF410", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JBHPEMNBKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85FCB60", Offset = "0x85FB160", VA = "0x1885FCB60", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool KNGJNLHKGBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85FCB60", Offset = "0x85FB160", VA = "0x1885FCB60", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PNGBBNHAECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85FCB60", Offset = "0x85FB160", VA = "0x1885FCB60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool CFEEBCNFDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xB2DC60", Offset = "0xB2C260", VA = "0x180B2DC60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85FBFE0", Offset = "0x85FA5E0", VA = "0x1885FBFE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Exception BJMCBCIAFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAA54C0", Offset = "0xAA3AC0", VA = "0x180AA54C0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAA5570", Offset = "0xAA3B70", VA = "0x180AA5570", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int EMDLACEOEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool DIGNMMNMAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85FD8B0", Offset = "0x85FBEB0", VA = "0x1885FD8B0", Slot = "17")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85FE030", Offset = "0x85FC630", VA = "0x1885FE030", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool BNDDKBMBBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAA5550", Offset = "0xAA3B50", VA = "0x180AA5550")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAA5500", Offset = "0xAA3B00", VA = "0x180AA5500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double COHKBGGHDBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85FCD30", Offset = "0x85FB330", VA = "0x1885FCD30")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double JJMBFAEONPF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85FC100", Offset = "0x85FA700", VA = "0x1885FC100")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int ALMFAKMOCLC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85FCCE0", Offset = "0x85FB2E0", VA = "0x1885FCCE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string NCCDKPFKLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85FE370", Offset = "0x85FC970", VA = "0x1885FE370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int LLGIHDFIJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85FE470", Offset = "0x85FCA70", VA = "0x1885FE470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public APNPJIHONFB NCJODLKCFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8600140", Offset = "0x85FE740", VA = "0x188600140", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AEGKNAAJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xDCE570", Offset = "0xDCCB70", VA = "0x180DCE570")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85FCBB0", Offset = "0x85FB1B0", VA = "0x1885FCBB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string, long> FNLMEOJMHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85FBAE0", Offset = "0x85FA0E0", VA = "0x1885FBAE0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85FD800", Offset = "0x85FBE00", VA = "0x1885FD800", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<DILFOBKEADN, DILFOBKEADN> EOHHHFFDOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85FEE40", Offset = "0x85FD440", VA = "0x1885FEE40", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85FF270", Offset = "0x85FD870", VA = "0x1885FF270", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8601010", Offset = "0x85FF610", VA = "0x188601010")]
	public ENCACBGKGPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x85FF9C0", Offset = "0x85FDFC0", VA = "0x1885FF9C0")]
	public bool NOEFOBHBBMA(object HDOBFKICCHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x85FE5D0", Offset = "0x85FCBD0", VA = "0x1885FE5D0")]
	private void LIPDCLDEGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x85FF960", Offset = "0x85FDF60", VA = "0x1885FF960")]
	private void NOAAOGKOHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8600A80", Offset = "0x85FF080", VA = "0x188600A80")]
	public bool PFNCPLADJAN(MEINMPIOLGA KEDGBKADGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x85FC360", Offset = "0x85FA960", VA = "0x1885FC360")]
	public bool BGIDCBAFIDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85FD270", Offset = "0x85FB870", VA = "0x1885FD270")]
	public void DPDHFJFOKEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x85FF350", Offset = "0x85FD950", VA = "0x1885FF350")]
	public void NCNAIEEFJAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x85FC150", Offset = "0x85FA750", VA = "0x1885FC150")]
	public void BEIKDCLJKAD(List<object> BBBJHCKNPGO, int NDMFOILAFKD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85FC8C0", Offset = "0x85FAEC0", VA = "0x1885FC8C0")]
	public void CCAKJHLMEAK(int EAHHAHHANOL, object CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x86005B0", Offset = "0x85FEBB0", VA = "0x1886005B0")]
	public void PACPCFGNADO(object EKHHBKLNJDE, int JPKKOPNBEKB, bool FNNCBALLFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x85FBD50", Offset = "0x85FA350", VA = "0x1885FBD50")]
	public void ANHNANMIGBP(object MPIDDJPOOMJ, NativeList<byte> PNIFNEJPPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85FEC00", Offset = "0x85FD200", VA = "0x1885FEC00")]
	public object LPNJIHLFELG(NativeArray<byte> PPEFJKBNOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x85FEEF0", Offset = "0x85FD4F0", VA = "0x1885FEEF0")]
	public int MGNOCJDGOCF(NDDAOAIJPDM CBIMJBOHKKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x85FFCE0", Offset = "0x85FE2E0", VA = "0x1885FFCE0")]
	public bool OCGDKHDBJGH(byte NLMJOFNGIOJ, object EJBPFCPIDKI, CIJKFJMOGHC KNBPPAKDDHK, OFKCPCBBNAB AFKPOIFBEPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85FC3B0", Offset = "0x85FA9B0", VA = "0x1885FC3B0")]
	public bool BHABAIMDJBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x85FCD80", Offset = "0x85FB380", VA = "0x1885FCD80")]
	internal bool DLBFDLPMGHH([In] EKAAHKPONCN HPAABCEOCGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x85FCFD0", Offset = "0x85FB5D0", VA = "0x1885FCFD0")]
	internal bool DNGODBKDEOC([In] DIGAFHBKOAE PGEPJKBFLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8600190", Offset = "0x85FE790", VA = "0x188600190")]
	private void OIEEMJJHBAP(bool DANCEOGFGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x85FD260", Offset = "0x85FB860", VA = "0x1885FD260")]
	public void DOHINIGMAHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x85FE5C0", Offset = "0x85FCBC0", VA = "0x1885FE5C0")]
	public void LILDAAPKGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x85FF0F0", Offset = "0x85FD6F0", VA = "0x1885FF0F0")]
	private void MKAHIDGKEGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x85FD900", Offset = "0x85FBF00", VA = "0x1885FD900")]
	private void HJIFLPAPECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8600BA0", Offset = "0x85FF1A0", VA = "0x188600BA0")]
	private void PFPKNGNJGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x85FE090", Offset = "0x85FC690", VA = "0x1885FE090")]
	private void JJFMLOHCIAG(bool IPMMJBOMDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x85FD570", Offset = "0x85FBB70", VA = "0x1885FD570")]
	private void HBKBBLGMICA(ulong EKLHAOJIGNN, FastBufferReader CAAOHFFEHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3C657C0", Offset = "0x3C63DC0", VA = "0x183C657C0")]
	private void BJFEFECEAGG<T>(PHKNCGEAODL NLMJOFNGIOJ, FastBufferReader CAAOHFFEHLC) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x85FECF0", Offset = "0x85FD2F0", VA = "0x1885FECF0")]
	private void MAPPPPFNDOK(byte NLMJOFNGIOJ, int OBAFOAGLIMM, object CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8600350", Offset = "0x85FE950", VA = "0x188600350")]
	private void OPDNOMPPPOH(ulong EKLHAOJIGNN, FastBufferReader CAAOHFFEHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85FF320", Offset = "0x85FD920", VA = "0x1885FF320")]
	private void MPIBHEELFAC(byte NLMJOFNGIOJ, object CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x85FF440", Offset = "0x85FDA40", VA = "0x1885FF440")]
	private void NKBNLEODBFH(PAECKICGHII DONNKKDINIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x85FDD20", Offset = "0x85FC320", VA = "0x1885FDD20")]
	private void IAODMOHFOII(PAECKICGHII DONNKKDINIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8600C90", Offset = "0x85FF290", VA = "0x188600C90")]
	private void PPOCDMEAIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x85FD3E0", Offset = "0x85FB9E0", VA = "0x1885FD3E0")]
	private void EOOCMMCFDBM(PAECKICGHII DONNKKDINIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x85FBB90", Offset = "0x85FA190", VA = "0x1885FBB90")]
	private void AMGEEHDBFHG(PAECKICGHII DONNKKDINIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86007D0", Offset = "0x85FEDD0", VA = "0x1886007D0")]
	private void PBADHKMKINE(PAECKICGHII DONNKKDINIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x85FE4A0", Offset = "0x85FCAA0", VA = "0x1885FE4A0")]
	private void LCNDDLNGLGD(PAECKICGHII DONNKKDINIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8600460", Offset = "0x85FEA60", VA = "0x188600460")]
	private void OPDNOMPPPOH(PAECKICGHII DONNKKDINIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x85FDC40", Offset = "0x85FC240", VA = "0x1885FDC40")]
	private void HNNAJEOLFAI(ulong NCJELIFCHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x85FCBE0", Offset = "0x85FB1E0", VA = "0x1885FCBE0")]
	private void DCKJDJHFGDF(bool IPMMJBOMDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x85FE800", Offset = "0x85FCE00", VA = "0x1885FE800")]
	private void LKBIOAGLHDM(OICMCACPHPN DELJFKJCHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x85FF0E0", Offset = "0x85FD6E0", VA = "0x1885FF0E0")]
	[CompilerGenerated]
	private void MHGADEGDFIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CFFCOKPAIPK : MEINMPIOLGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private ENCACBGKGPK CAHLGNEHJOD;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static string MGNHNKMFPCC;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static Func<string, string> KHHDJBGKKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int KBLFCGHMNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private string ODNJHICABKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private ObscuredInt GONPDCPKDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool? GGNPMGBBJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private string FBFLKNBGHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private ulong NKMEHHHLOGO;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int KKBADBMJDMC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool JBDGPDFFIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xB76A30", Offset = "0xB75030", VA = "0x180B76A30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xEC44B0", Offset = "0xEC2AB0", VA = "0x180EC44B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EBGFHIHPFEL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x85FAD80", Offset = "0x85F9380", VA = "0x1885FAD80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Dictionary<object, object> PMGMFDIEHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public string DADCDJCMLBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x85FB250", Offset = "0x85F9850", VA = "0x1885FB250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int PHHEDFPIBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x85FABE0", Offset = "0x85F91E0", VA = "0x1885FABE0", Slot = "9")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x85FB1C0", Offset = "0x85F97C0", VA = "0x1885FB1C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool KKPCNLMFFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x19D4810", Offset = "0x19D2E10", VA = "0x1819D4810", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x19DAEA0", Offset = "0x19D94A0", VA = "0x1819DAEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool MLLOIJAAECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x85FAE10", Offset = "0x85F9410", VA = "0x1885FAE10", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string DBEABLGCAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x85FACE0", Offset = "0x85F92E0", VA = "0x1885FACE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public string CKPDMHPNJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x85FB340", Offset = "0x85F9940", VA = "0x1885FB340", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool PEMLBLAOONH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public object PEPDGGFCIBD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAA5710", Offset = "0xAA3D10", VA = "0x180AA5710", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAA5590", Offset = "0xAA3B90", VA = "0x180AA5590", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	internal ulong GMPNALFGIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAA54C0", Offset = "0xAA3AC0", VA = "0x180AA54C0")]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x85FB230", Offset = "0x85F9830", VA = "0x1885FB230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x85FB4C0", Offset = "0x85F9AC0", VA = "0x1885FB4C0")]
	internal CFFCOKPAIPK(ENCACBGKGPK LKLGCCANBKL, bool FLHNEAKLKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85FB500", Offset = "0x85F9B00", VA = "0x1885FB500")]
	internal CFFCOKPAIPK(ENCACBGKGPK LKLGCCANBKL, bool FLHNEAKLKFM, ulong NCJELIFCHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x85FB3A0", Offset = "0x85F99A0", VA = "0x1885FB3A0")]
	internal CFFCOKPAIPK(ENCACBGKGPK LKLGCCANBKL, bool FLHNEAKLKFM, [In] EKAAHKPONCN GENHGNMMKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x85FAC30", Offset = "0x85F9230", VA = "0x1885FAC30", Slot = "16")]
	public bool DMMIENPNIIO(Dictionary<object, object> AKJBNGKHJDD, [Optional] Dictionary<object, object> MIAJIOLEJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x85FAAC0", Offset = "0x85F90C0", VA = "0x1885FAAC0")]
	public EKAAHKPONCN BDLDHIBOPDP()
	{
		return default(EKAAHKPONCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x85FAED0", Offset = "0x85F94D0", VA = "0x1885FAED0")]
	internal void JOKBNLJCLPP([In] EKAAHKPONCN HPAABCEOCGP, bool JJEFJCFNJAI = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HELKAMCFFGK : FHLBLEADILO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private ENCACBGKGPK CAHLGNEHJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private Dictionary<object, object> GEKIABIPNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal Dictionary<int, CFFCOKPAIPK> OBOEIEHDCJM;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string EEABAFMMHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8601C40", Offset = "0x8600240", VA = "0x188601C40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte DCBGDKBHDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8601250", Offset = "0x85FF850", VA = "0x188601250", Slot = "5")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool MDNNPMECNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xB268D0", Offset = "0xB24ED0", VA = "0x180B268D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Dictionary<object, object> PMGMFDIEHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public CFFCOKPAIPK[] HDHJNCJDEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public CFFCOKPAIPK[] KEJCDJJLHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAA56F0", Offset = "0xAA3CF0", VA = "0x180AA56F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public CFFCOKPAIPK[] PPHCLGKPLBF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAA5640", Offset = "0xAA3C40", VA = "0x180AA5640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public CFFCOKPAIPK[] BJGMEALHFKP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xAA57F0", Offset = "0xAA3DF0", VA = "0x180AA57F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int GDPPDLCMKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xEC0BF0", Offset = "0xEBF1F0", VA = "0x180EC0BF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x101EFC0", Offset = "0x101D5C0", VA = "0x18101EFC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8601FD0", Offset = "0x86005D0", VA = "0x188601FD0")]
	public HELKAMCFFGK(ENCACBGKGPK LKLGCCANBKL, [In] DIGAFHBKOAE PGEPJKBFLOM, bool BGEAEGENGOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8601BE0", Offset = "0x86001E0", VA = "0x188601BE0", Slot = "9")]
	public bool IAPNEPHBBJD(int NMILEMOAODL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x86016F0", Offset = "0x85FFCF0", VA = "0x1886016F0", Slot = "8")]
	public bool DMMIENPNIIO(Dictionary<object, object> AKJBNGKHJDD, [Optional] Dictionary<object, object> GNDHGPGMPPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8601C70", Offset = "0x8600270", VA = "0x188601C70")]
	internal bool IKNJKOEHOND([In] EKAAHKPONCN HPAABCEOCGP, bool PDFAIPMMCNN, [Out] CFFCOKPAIPK AGIMJJDFEAF, bool JJEFJCFNJAI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8601E30", Offset = "0x8600430", VA = "0x188601E30")]
	internal void PDHKKBFPEOD(ulong NCJELIFCHMF, [Out] CFFCOKPAIPK AGIMJJDFEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x86012A0", Offset = "0x85FF8A0", VA = "0x1886012A0")]
	internal void CEOIIOLAGBK([In] DIGAFHBKOAE PGEPJKBFLOM, bool JJEFJCFNJAI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x86017A0", Offset = "0x85FFDA0", VA = "0x1886017A0")]
	private void FBPBALFGHDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JIMJCIFFONK : DPFMLLLOMLB, NAICMPCIHAH, AHLBFLGEMBG, CEFAIAFEDDC, LHELGJDFGCA, IDOMFCOODOJ, LMDECLFEPME, NFBOJFIGOOE, HJCADCECDLB, PPDMNHJDNPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private ENCACBGKGPK CAHLGNEHJOD;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int ALMFAKMOCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8602AB0", Offset = "0x86010B0", VA = "0x188602AB0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int HMCHAHBAEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int ACIEEJKEAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8603580", Offset = "0x8601B80", VA = "0x188603580", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int CNHBLGKNIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x86039D0", Offset = "0x8601FD0", VA = "0x1886039D0", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool DMKEKGNGEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xD77FF0", Offset = "0xD765F0", VA = "0x180D77FF0", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public double COHKBGGHDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8602C50", Offset = "0x8601250", VA = "0x188602C50", Slot = "35")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int FGDJOPOONMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8602840", Offset = "0x8600E40", VA = "0x188602840", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool CHKNHCOCIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7280F70", Offset = "0x727F570", VA = "0x187280F70", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool JBHPEMNBKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8602CB0", Offset = "0x86012B0", VA = "0x188602CB0", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool KNGJNLHKGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8602CB0", Offset = "0x86012B0", VA = "0x188602CB0", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool CFEEBCNFDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x86038F0", Offset = "0x8601EF0", VA = "0x1886038F0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8602820", Offset = "0x8600E20", VA = "0x188602820", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GNPPGGBCCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8603090", Offset = "0x8601690", VA = "0x188603090", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool DMOJCIPDMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8603AF0", Offset = "0x86020F0", VA = "0x188603AF0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public object HOINAFKFKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAAAED0", Offset = "0xAA94D0", VA = "0x180AAAED0", Slot = "50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MEINMPIOLGA KPFDOFKDHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8603A20", Offset = "0x8602020", VA = "0x188603A20", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int KBBLEKKGKIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8603520", Offset = "0x8601B20", VA = "0x188603520", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int PACGCBGHHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8602B50", Offset = "0x8601150", VA = "0x188602B50", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public MEINMPIOLGA PFCGDMMCNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8603420", Offset = "0x8601A20", VA = "0x188603420", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool OPHODICPLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8602480", Offset = "0x8600A80", VA = "0x188602480", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int DCBGDKBHDHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8602A30", Offset = "0x8601030", VA = "0x188602A30", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string MGNHNKMFPCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8602710", Offset = "0x8600D10", VA = "0x188602710", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Func<string, string> KHHDJBGKKOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8602BF0", Offset = "0x86011F0", VA = "0x188602BF0", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public APNPJIHONFB NCJODLKCFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8603B90", Offset = "0x8602190", VA = "0x188603B90", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override bool BNDDKBMBBCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8603300", Offset = "0x8601900", VA = "0x188603300", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8603B40", Offset = "0x8602140", VA = "0x188603B40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override float GNEFBJCGICE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAC2220", Offset = "0xAC0820", VA = "0x180AC2220", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAD1C00", Offset = "0xAD0200", VA = "0x180AD1C00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public override OHBJKFKAMJM MGOKIAEJCMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xAA5730", Offset = "0xAA3D30", VA = "0x180AA5730", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool AEGKNAAJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x86039F0", Offset = "0x8601FF0", VA = "0x1886039F0", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8602B10", Offset = "0x8601110", VA = "0x188602B10", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string NCCDKPFKLAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8603620", Offset = "0x8601C20", VA = "0x188603620", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public long FGPAFPDBJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x86038B0", Offset = "0x8601EB0", VA = "0x1886038B0", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public long HNMLGLHIDOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x86032F0", Offset = "0x86018F0", VA = "0x1886032F0", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<OHBJKFKAMJM, OHBJKFKAMJM> MMCLCBFHCEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8602F70", Offset = "0x8601570", VA = "0x188602F70", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x86025A0", Offset = "0x8600BA0", VA = "0x1886025A0", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<NDDAOAIJPDM> OIDCBMIFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8602D40", Offset = "0x8601340", VA = "0x188602D40", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8602960", Offset = "0x8600F60", VA = "0x188602960", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<MEINMPIOLGA> MCIFEABBMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8603100", Offset = "0x8601700", VA = "0x188603100", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8603A40", Offset = "0x8602040", VA = "0x188603A40", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8603020", Offset = "0x8601620", VA = "0x188603020")]
	[EGNICHGEFDG.KHJDAJHJKCM.GHFDKJOPLIL]
	internal static void FBMOEFONPBI(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8603EB0", Offset = "0x86024B0", VA = "0x188603EB0")]
	[RecRoom.DataLayer.Attributes.Preserve]
	public JIMJCIFFONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x86028C0", Offset = "0x8600EC0", VA = "0x1886028C0", Slot = "21")]
	public void BEIKDCLJKAD(List<object> BBBJHCKNPGO, int NDMFOILAFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8603C00", Offset = "0x8602200", VA = "0x188603C00", Slot = "23")]
	public void PACPCFGNADO(object EKHHBKLNJDE, int JPKKOPNBEKB, bool FNNCBALLFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8603C30", Offset = "0x8602230", VA = "0x188603C30", Slot = "27")]
	public void PEBAJADHGPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x86032B0", Offset = "0x86018B0", VA = "0x1886032B0", Slot = "56")]
	public bool GJGLHDFOBIA(object HDOBFKICCHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8603910", Offset = "0x8601F10", VA = "0x188603910", Slot = "29")]
	public object LPNJIHLFELG(NativeArray<byte> CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x86038C0", Offset = "0x8601EC0", VA = "0x1886038C0", Slot = "55")]
	public void LILDAAPKGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8602A10", Offset = "0x8601010", VA = "0x188602A10", Slot = "22")]
	public void CCAKJHLMEAK(int EAHHAHHANOL, object CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8603330", Offset = "0x8601930", VA = "0x188603330", Slot = "83")]
	public MEINMPIOLGA IAFNOHJJOGN(int NODOENPBIEC, bool INDECHPKAEO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8603740", Offset = "0x8601D40", VA = "0x188603740", Slot = "82")]
	public MEINMPIOLGA JPENGCFJFPO(int NMBBIDCMGIO, bool INDECHPKAEO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x86031B0", Offset = "0x86017B0", VA = "0x1886031B0", Slot = "84")]
	public MEINMPIOLGA GJEHMLGEOPE(int NMBBIDCMGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8602DF0", Offset = "0x86013F0", VA = "0x188602DF0", Slot = "18")]
	public bool ENPEKLKNGPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8602680", Offset = "0x8600C80", VA = "0x188602680", Slot = "85")]
	public IReadOnlyList<MEINMPIOLGA> AOBKCBCGJCI(bool INDECHPKAEO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8603490", Offset = "0x8601A90", VA = "0x188603490", Slot = "86")]
	public IReadOnlyList<MEINMPIOLGA> IFBEAPPPNEM(bool INDECHPKAEO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x86028E0", Offset = "0x8600EE0", VA = "0x1886028E0", Slot = "54")]
	public bool BHABAIMDJBA(string NDLDAJEDFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8602D10", Offset = "0x8601310", VA = "0x188602D10", Slot = "53")]
	public bool DOHINIGMAHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x86037D0", Offset = "0x8601DD0", VA = "0x1886037D0", Slot = "20")]
	public void KGBAMNIJMIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8603B60", Offset = "0x8602160", VA = "0x188603B60", Slot = "70")]
	public bool OCGDKHDBJGH(byte NLMJOFNGIOJ, object EJBPFCPIDKI, CIJKFJMOGHC KNBPPAKDDHK, OFKCPCBBNAB AFKPOIFBEPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8602650", Offset = "0x8600C50", VA = "0x188602650", Slot = "28")]
	public void ANHNANMIGBP(object MPIDDJPOOMJ, NativeList<byte> CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x86039B0", Offset = "0x8601FB0", VA = "0x1886039B0", Slot = "30")]
	public int MGNOCJDGOCF(NDDAOAIJPDM CBIMJBOHKKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "45")]
	public void MGNLFNMEBEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8603D70", Offset = "0x8602370", VA = "0x188603D70", Slot = "87")]
	public bool PFNCPLADJAN(MEINMPIOLGA GJLDAIKCCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "34")]
	public void DOLHFNNIBOJ(string NHDBEANECII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8603940", Offset = "0x8601F40", VA = "0x188603940", Slot = "17")]
	public float MDOJBNGHPMF(bool POONFKAOGBG, int BIKKHMAEGMH = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x86035C0", Offset = "0x8601BC0", VA = "0x1886035C0", Slot = "8")]
	public override void JBDBHBCAPKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8602E50", Offset = "0x8601450", VA = "0x188602E50", Slot = "81")]
	public void EOEBEPDJCEL(string NDIENANOGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8602AB0", Offset = "0x86010B0", VA = "0x188602AB0", Slot = "95")]
	public int COKKGJOKJCH()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x86030E0", Offset = "0x86016E0", VA = "0x1886030E0", Slot = "11")]
	private void FMMIFDGPHPD(Action KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8603BF0", Offset = "0x86021F0", VA = "0x188603BF0", Slot = "12")]
	private void OKDHDJMCPGP(Action KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8603A10", Offset = "0x8602010", VA = "0x188603A10", Slot = "25")]
	private void NBDPCKACPPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8603320", Offset = "0x8601920", VA = "0x188603320", Slot = "26")]
	private void HNHNOBLEMOO()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8602F60", Offset = "0x8601560", VA = "0x188602F60", Slot = "31")]
	private void FAEOAOCAFFM(float KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8603310", Offset = "0x8601910", VA = "0x188603310", Slot = "32")]
	private void HLNGCMAJKFA(float KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x86032D0", Offset = "0x86018D0", VA = "0x1886032D0", Slot = "57")]
	private void GLIIIIBCGDI(Action<bool> KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x86037B0", Offset = "0x8601DB0", VA = "0x1886037B0", Slot = "58")]
	private void KDEDLMOHJEB(Action<bool> KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x86030F0", Offset = "0x86016F0", VA = "0x1886030F0", Slot = "59")]
	private void FOLAPABGMEA(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x86037C0", Offset = "0x8601DC0", VA = "0x1886037C0", Slot = "60")]
	private void KENGEKLOGFH(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x86032E0", Offset = "0x86018E0", VA = "0x1886032E0", Slot = "61")]
	private void GNECOODPAEC(object INEEADCBMPK, bool KBFGPLLMDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8602A90", Offset = "0x8601090", VA = "0x188602A90", Slot = "62")]
	private IDisposable CGCJDCOCDKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8603EA0", Offset = "0x86024A0", VA = "0x188603EA0", Slot = "63")]
	private bool PMICECEHCEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8603BE0", Offset = "0x86021E0", VA = "0x188603BE0", Slot = "64")]
	private void OEGPPIBLLPB(StringBuilder HPKPMAMMCIB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8603E90", Offset = "0x8602490", VA = "0x188603E90", Slot = "66")]
	private void PGFGJFLLOLC(Action<string, long> KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8603A00", Offset = "0x8602000", VA = "0x188603A00", Slot = "67")]
	private void MNGLNPHFNKL(Action<string, long> KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x86038A0", Offset = "0x8601EA0", VA = "0x1886038A0", Slot = "88")]
	private void KIPHPKLGCDN(Action KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x86030D0", Offset = "0x86016D0", VA = "0x1886030D0", Slot = "89")]
	private void FLJPPGNJNLO(Action KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8602AA0", Offset = "0x86010A0", VA = "0x188602AA0", Slot = "90")]
	private void CMFLNIGMGLG()
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
		public NfgoCommsNetwork DMMGJFOGMEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85FB8D0", Offset = "0x85F9ED0", VA = "0x1885FB8D0")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x85FBA90", Offset = "0x85FA090", VA = "0x1885FBA90")]
		private void CALOIHEDOLM(NetworkManager KCNFDFMBIGI, bool GABAIHEPNMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
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
		[Cpp2IlInjected.Address(RVA = "0x8603F30", Offset = "0x8602530", VA = "0x188603F30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public NetworkManagerBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HGMDKFAINJB
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool PHBIFHNEKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xAFE8C0", Offset = "0xAFCEC0", VA = "0x180AFE8C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xB82B90", Offset = "0xB81190", VA = "0x180B82B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public NetworkManager JCEEGLCMPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public NetworkManager JBFFMPMPLIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public INetworkManager ANKBFDOMGDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<NetworkManager, bool> CALOIHEDOLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8602230", Offset = "0x8600830", VA = "0x188602230")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8602180", Offset = "0x8600780", VA = "0x188602180")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x86023C0", Offset = "0x86009C0", VA = "0x1886023C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HGMDKFAINJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x86022E0", Offset = "0x86008E0", VA = "0x1886022E0")]
	[EGNICHGEFDG.KHJDAJHJKCM]
	public static void FIFLHNBHMAH(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8602350", Offset = "0x8600950", VA = "0x188602350")]
	public void MDJIOAFLOCA(NetworkManager KCNFDFMBIGI, bool GABAIHEPNMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CNGLDMIMOJM : INetworkManager, INetworkUpdateSystem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private float DHFGMFEKCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private CustomMessagingManager.HandleNamedMessageDelegate OJKLIEFIGGN;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public ulong BDCGIBBCJPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xC4FA70", Offset = "0xC4E070", VA = "0x180C4FA70", Slot = "8")]
		get
		{
			return default(ulong);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool OAKLPODAMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAA5700", Offset = "0xAA3D00", VA = "0x180AA5700", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xAA54D0", Offset = "0xAA3AD0", VA = "0x180AA54D0", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool JKFEEBHJKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<ulong> PPDMJLNCMOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x85FB630", Offset = "0x85F9C30", VA = "0x1885FB630", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x85FB780", Offset = "0x85F9D80", VA = "0x1885FB780", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action MLANNEKONEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x85FB6E0", Offset = "0x85F9CE0", VA = "0x1885FB6E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x85FB830", Offset = "0x85F9E30", VA = "0x1885FB830", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x85FB540", Offset = "0x85F9B40", VA = "0x1885FB540", Slot = "12")]
	public double GetLocalTime()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x85FB540", Offset = "0x85F9B40", VA = "0x1885FB540", Slot = "13")]
	public double GetServerTime()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "14")]
	public int GetRoundTripTime()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "15")]
	public NetworkConfig GetNetworkConfig()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "16")]
	public void SendAllOutgoingMessages(bool JNPALOFBGJH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "17")]
	public void ClearOutgoingMessages(bool JCIBJLBNNND = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "18")]
	public void ProcessIncommingMessages()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x85FB5C0", Offset = "0x85F9BC0", VA = "0x1885FB5C0")]
	public CNGLDMIMOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x85FB560", Offset = "0x85F9B60", VA = "0x1885FB560", Slot = "22")]
	public void NetworkUpdate(NetworkUpdateStage BJDFPPJLINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x85FB580", Offset = "0x85F9B80", VA = "0x1885FB580", Slot = "19")]
	public void RegisterNamedMessageHandler(NamedMessageType NDIENANOGEK, CustomMessagingManager.HandleNamedMessageDelegate LAOAAOBGDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x85FB5A0", Offset = "0x85F9BA0", VA = "0x1885FB5A0", Slot = "20")]
	public void UnregisterNamedMessageHandler(NamedMessageType NDIENANOGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "21")]
	public void SendCustomMessage(NamedMessageType EPGGGKPOKPJ, ulong NCJELIFCHMF, FastBufferWriter KENFFENCLHP, NetworkDelivery AFKPOIFBEPB)
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
