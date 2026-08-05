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
		[Cpp2IlInjected.Address(RVA = "0x7D535C0", Offset = "0x7D527C0", VA = "0x187D535C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FJBNFFPCCKP : BKDNIFFCBID, DPGGAKNDDPF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DefaultMember("Item")]
	private class GNPEGLOFOBP : HIPDGMOFECH
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object HAHLLCOCBCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7D50FB0", Offset = "0x7D501B0", VA = "0x187D50FB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public byte PDGHMKFJMJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA75190", Offset = "0xA74390", VA = "0x180A75190", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA75210", Offset = "0xA74410", VA = "0x180A75210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int MJAAKMGHDNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA90990", Offset = "0xA8FB90", VA = "0x180A90990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA909F0", Offset = "0xA8FBF0", VA = "0x180A909F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object CECAADHHAGD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7659EF0", Offset = "0x76590F0", VA = "0x187659EF0")]
		public GNPEGLOFOBP(byte HADNLMBOMNH, int GCPKMNCMKPP, object CAIGHLKIDBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7D50F60", Offset = "0x7D50160", VA = "0x187D50F60", Slot = "8")]
		public bool FBLKJFCBGPJ(byte MHDODBCCAJB, [Out] object KJIOHKMJAPE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NetworkManager ALBDKGDFKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NMJOPFNONGB MOIMMJOBOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stopwatch LBNPGPMICFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int GKKHCDLHMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Deque<GNPEGLOFOBP> FANIAMKJHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Deque<Action> FMCLALFLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private HACNDOBHKDB HGDKMHNFGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private EFIHBIPIBND MNKHNJNMACK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NetworkManager NHIMMMKMMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D4C530", Offset = "0x7D4B730", VA = "0x187D4C530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NMJOPFNONGB GLHAIPHKAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790", Slot = "4")]
		get
		{
			return default(NMJOPFNONGB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D630", Offset = "0x7D4C830", VA = "0x187D4D630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CPIHOJIBIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA036F0", Offset = "0xA028F0", VA = "0x180A036F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HACNDOBHKDB NDGKEBACOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EFIHBIPIBND GPLNOPECBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private IAPIDDAAGHG AIFBJKOKLPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LGFCLALOGNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7D50AC0", Offset = "0x7D4FCC0", VA = "0x187D50AC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AMJMLGFHMPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D4E2A0", Offset = "0x7D4D4A0", VA = "0x187D4E2A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LHPIPKLPFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D4E2A0", Offset = "0x7D4D4A0", VA = "0x187D4E2A0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool FFBAFBMHNKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7D4E2A0", Offset = "0x7D4D4A0", VA = "0x187D4E2A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Exception OODNECBGMOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA00360", Offset = "0x9FF560", VA = "0x180A00360", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA003E0", Offset = "0x9FF5E0", VA = "0x180A003E0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HOEOLBBGJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DJJGKKIOIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D3F0", Offset = "0x7D4C5F0", VA = "0x187D4D3F0", Slot = "17")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7D4DD10", Offset = "0x7D4CF10", VA = "0x187D4DD10", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool FOPOGAHOCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xC656A0", Offset = "0xC648A0", VA = "0x180C656A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xC64C90", Offset = "0xC63E90", VA = "0x180C64C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double FGHKDAFDFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D4F4E0", Offset = "0x7D4E6E0", VA = "0x187D4F4E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double JABELMBJDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7D50AD0", Offset = "0x7D4FCD0", VA = "0x187D50AD0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int IHPBPJMNCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D4FCD0", Offset = "0x7D4EED0", VA = "0x187D4FCD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string EGKFLAKLNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7D4FDB0", Offset = "0x7D4EFB0", VA = "0x187D4FDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int GKGCKCFFIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7D4FD20", Offset = "0x7D4EF20", VA = "0x187D4FD20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NMJNLDGKANB JANAJGHIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7D4F480", Offset = "0x7D4E680", VA = "0x187D4F480", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string, long> MCEAFMEMKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7D4E2D0", Offset = "0x7D4D4D0", VA = "0x187D4E2D0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7D4FC20", Offset = "0x7D4EE20", VA = "0x187D4FC20", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<NMJOPFNONGB, NMJOPFNONGB> DONFJDDFKCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D580", Offset = "0x7D4C780", VA = "0x187D4D580", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7D4E730", Offset = "0x7D4D930", VA = "0x187D4E730", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D50D20", Offset = "0x7D4FF20", VA = "0x187D50D20")]
	public FJBNFFPCCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D4EE50", Offset = "0x7D4E050", VA = "0x187D4EE50")]
	public bool HDAGGGDMJEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D50220", Offset = "0x7D4F420", VA = "0x187D50220")]
	public bool NFFANMOLIFJ(BNFABCHNBCL AHEOAPACCIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7D4F050", Offset = "0x7D4E250", VA = "0x187D4F050")]
	public bool HGICKKCAFFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D4DFD0", Offset = "0x7D4D1D0", VA = "0x187D4DFD0")]
	public void FAEPICADAFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D4F9C0", Offset = "0x7D4EBC0", VA = "0x187D4F9C0")]
	public void JOCPIEMFFAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7D4F270", Offset = "0x7D4E470", VA = "0x187D4F270")]
	public void HKNNMBJHLHG(List<object> CFFEIIKPOPD, int KOKMPCAPCJD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D4E000", Offset = "0x7D4D200", VA = "0x187D4E000")]
	public void FDBMOAKKLOH(int BLKBKPJFHAB, object ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D50B00", Offset = "0x7D4FD00", VA = "0x187D50B00")]
	public void PLBLADIGEKO(IDictionary<object, object> GFKOIMIAEOH, int LPGODJOFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7D4DD40", Offset = "0x7D4CF40", VA = "0x187D4DD40")]
	public void ELKKKBEIKKA(object KFMNDOMPAMC, NativeList<byte> DLFLCCPEBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C820", Offset = "0x7D4BA20", VA = "0x187D4C820")]
	public object BHIBMPPAILM(NativeArray<byte> LMDCFNDMKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D4F080", Offset = "0x7D4E280", VA = "0x187D4F080")]
	public int HJEICJEDGBI(HIPDGMOFECH ODLIDIMANGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D4E380", Offset = "0x7D4D580", VA = "0x187D4E380")]
	public bool GJELHJLMOHL(byte HADNLMBOMNH, object FAONOPFFPFN, FLEPBPAFMND GMFBDIONGGP, BMEOONJFDHA DHAAPHEFKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D4F510", Offset = "0x7D4E710", VA = "0x187D4F510")]
	public bool JHJLDIBKECB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D4EB00", Offset = "0x7D4DD00", VA = "0x187D4EB00")]
	internal bool GMPJIOMPMKG([In] DFOJPDEMLFA GHGOIFANHIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D4F9F0", Offset = "0x7D4EBF0", VA = "0x187D4F9F0")]
	internal bool KFKIEANNHHM([In] JJBHDAGGEGO JCFOMPGDMKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D4D570", Offset = "0x7D4C770", VA = "0x187D4D570")]
	public void DCKICKLAMJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D4D570", Offset = "0x7D4C770", VA = "0x187D4D570")]
	public void IOGJEEFFPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7D4D660", Offset = "0x7D4C860", VA = "0x187D4D660")]
	private void DIAEFINJMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D4E7E0", Offset = "0x7D4D9E0", VA = "0x187D4E7E0")]
	private void GMOKKCEONHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D4D420", Offset = "0x7D4C620", VA = "0x187D4D420")]
	private void DBDEKGLGAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D4FFD0", Offset = "0x7D4F1D0", VA = "0x187D4FFD0")]
	private void NCFGANPONDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D50330", Offset = "0x7D4F530", VA = "0x187D50330")]
	private void NHIACPEIAHH(ulong LPCODDNBCOM, FastBufferReader MDCBLIHFBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x39EBB80", Offset = "0x39EAD80", VA = "0x1839EBB80")]
	private void FAFHHGOHKLE<T>(LJGKGDCKBLE HADNLMBOMNH, FastBufferReader MDCBLIHFBGJ) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7D4FE80", Offset = "0x7D4F080", VA = "0x187D4FE80")]
	private void NAMNHHDLNAJ(byte HADNLMBOMNH, int GCPKMNCMKPP, object CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D4CE90", Offset = "0x7D4C090", VA = "0x187D4CE90")]
	private void BLADFGLCEMP(ulong LPCODDNBCOM, FastBufferReader MDCBLIHFBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7D50590", Offset = "0x7D4F790", VA = "0x187D50590")]
	private void ODOCLDDDINP(GNPEGLOFOBP HEAHMHOMOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D4CFA0", Offset = "0x7D4C1A0", VA = "0x187D4CFA0")]
	private void BOIMDCEMIKA(GNPEGLOFOBP HEAHMHOMOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7D4D8D0", Offset = "0x7D4CAD0", VA = "0x187D4D8D0")]
	private void EABFBPFEAJP(GNPEGLOFOBP HEAHMHOMOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C660", Offset = "0x7D4B860", VA = "0x187D4C660")]
	private void BGECIPFEGBI(GNPEGLOFOBP HEAHMHOMOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D4DA60", Offset = "0x7D4CC60", VA = "0x187D4DA60")]
	private void EKABPJLKADJ(GNPEGLOFOBP HEAHMHOMOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D4ED30", Offset = "0x7D4DF30", VA = "0x187D4ED30")]
	private void GNGFDHOOMMC(GNPEGLOFOBP HEAHMHOMOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D4CD40", Offset = "0x7D4BF40", VA = "0x187D4CD40")]
	private void BLADFGLCEMP(GNPEGLOFOBP HEAHMHOMOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7D4EF80", Offset = "0x7D4E180", VA = "0x187D4EF80")]
	private void HFJPFGKLOFM(ulong JFOBNAKMELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7D4D7E0", Offset = "0x7D4C9E0", VA = "0x187D4D7E0")]
	private void DMMCPPILKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C910", Offset = "0x7D4BB10", VA = "0x187D4C910")]
	private void BKNJBONPBAM(OLKMJBHOEAD GJJADCBOFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7D4F4D0", Offset = "0x7D4E6D0", VA = "0x187D4F4D0")]
	[CompilerGenerated]
	private void IDCONIBEOMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HACNDOBHKDB : BNFABCHNBCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private FJBNFFPCCKP KPFFPGPBHHF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static string JLIFHFHIKMC;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static Func<string, string> PGNOKLFAGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int IAJMAKCMPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private string LHGJPDKFDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private ObscuredInt IMLNKBDCLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool? EKCGCDMIOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string KHJJFPEMLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private ulong GDJJPANFEID;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int BNKBPPLDFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool PDBMHAIGDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA52350", Offset = "0xA51550", VA = "0x180A52350", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xD7FF60", Offset = "0xD7F160", VA = "0x180D7FF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool LOLMEHHCHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7D516B0", Offset = "0x7D508B0", VA = "0x187D516B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Dictionary<object, object> NIGLFINPOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string EECONMCHGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7D51050", Offset = "0x7D50250", VA = "0x187D51050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OKNPLADIOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7D51000", Offset = "0x7D50200", VA = "0x187D51000", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DBAJDBONCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AOMJOBJGNJC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7D51160", Offset = "0x7D50360", VA = "0x187D51160", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string KJBKGPKNLHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7D515B0", Offset = "0x7D507B0", VA = "0x187D515B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string CIGODKCADIE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7D51650", Offset = "0x7D50850", VA = "0x187D51650", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool LMFKKAMNLNB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public object LJDHLOJBBAD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA00360", Offset = "0x9FF560", VA = "0x180A00360", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA003E0", Offset = "0x9FF5E0", VA = "0x180A003E0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	internal ulong CNBBBAJFLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA00350", Offset = "0x9FF550", VA = "0x180A00350")]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7D51140", Offset = "0x7D50340", VA = "0x187D51140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7D51780", Offset = "0x7D50980", VA = "0x187D51780")]
	internal HACNDOBHKDB(FJBNFFPCCKP MMHOIGBMNBB, bool CLLKENFLECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D51740", Offset = "0x7D50940", VA = "0x187D51740")]
	internal HACNDOBHKDB(FJBNFFPCCKP MMHOIGBMNBB, bool CLLKENFLECJ, ulong JFOBNAKMELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7D517C0", Offset = "0x7D509C0", VA = "0x187D517C0")]
	internal HACNDOBHKDB(FJBNFFPCCKP MMHOIGBMNBB, bool CLLKENFLECJ, [In] DFOJPDEMLFA EKEHELLMFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D51500", Offset = "0x7D50700", VA = "0x187D51500", Slot = "16")]
	public bool IHGBFOJDNDN(Dictionary<object, object> DODEDANNPKL, [Optional] Dictionary<object, object> FAPOJLHEIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7D51220", Offset = "0x7D50420", VA = "0x187D51220")]
	internal void IEENEINIKML([In] DFOJPDEMLFA GHGOIFANHIE, bool KMGFLDLCJCD = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EFIHBIPIBND : IAPIDDAAGHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private FJBNFFPCCKP KPFFPGPBHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Dictionary<object, object> KOGHPICCOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal Dictionary<int, HACNDOBHKDB> AAIPEAMMFOM;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string KGCJIDMKOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7D4BF00", Offset = "0x7D4B100", VA = "0x187D4BF00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public byte IKHGDNGBACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7D4BF30", Offset = "0x7D4B130", VA = "0x187D4BF30", Slot = "5")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool EIAPFBFAGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Dictionary<object, object> NIGLFINPOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public HACNDOBHKDB[] ABLIANKBKNA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA00D60", Offset = "0x9FFF60", VA = "0x180A00D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public HACNDOBHKDB[] LOLKNDBELJC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA09EE0", Offset = "0xA090E0", VA = "0x180A09EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public HACNDOBHKDB[] KHKFJAGNNMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3E0", Offset = "0xA0C5E0", VA = "0x180A0D3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public HACNDOBHKDB[] FENLKLFCEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA00BC0", Offset = "0x9FFDC0", VA = "0x180A00BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int IHELFJLPKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xECFF00", Offset = "0xECF100", VA = "0x180ECFF00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xECFF90", Offset = "0xECF190", VA = "0x180ECFF90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C390", Offset = "0x7D4B590", VA = "0x187D4C390")]
	public EFIHBIPIBND(FJBNFFPCCKP MMHOIGBMNBB, [In] JJBHDAGGEGO JCFOMPGDMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BC80", Offset = "0x7D4AE80", VA = "0x187D4BC80", Slot = "9")]
	public bool HLOIHNLCMEP(int APBCLGNDGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BCE0", Offset = "0x7D4AEE0", VA = "0x187D4BCE0", Slot = "8")]
	public bool IHGBFOJDNDN(Dictionary<object, object> DODEDANNPKL, [Optional] Dictionary<object, object> GMFJJNGKDIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B670", Offset = "0x7D4A870", VA = "0x187D4B670")]
	internal bool FMBNBNLNAKG([In] DFOJPDEMLFA GHGOIFANHIE, bool PMCLMLOHEEL, [Out] HACNDOBHKDB NLIBDKKPKLB, bool KMGFLDLCJCD = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BD70", Offset = "0x7D4AF70", VA = "0x187D4BD70")]
	internal void KHPKIGIGEKE(ulong JFOBNAKMELF, [Out] HACNDOBHKDB NLIBDKKPKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B830", Offset = "0x7D4AA30", VA = "0x187D4B830")]
	internal void HFDMDOCEDNF([In] JJBHDAGGEGO JCFOMPGDMKN, bool KMGFLDLCJCD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BF80", Offset = "0x7D4B180", VA = "0x187D4BF80")]
	private void PAFEGHIMEHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KKMDHLHOBPF : CDKDFHJLFHA, AGONIDGIFFK, FCICEBKLCIJ, OEHCLHIPBJL, CMJOIEPIJJK, CBJOBDJGPPE, OEEIPIIFMJI, DPGGAKNDDPF, GHNBCGHOJNC, PEHLHCAHFOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private FJBNFFPCCKP KPFFPGPBHHF;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int IHPBPJMNCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7D525B0", Offset = "0x7D517B0", VA = "0x187D525B0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int DIBPMMJMHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int DHGABJJCDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7D52470", Offset = "0x7D51670", VA = "0x187D52470", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int CPIHOJIBIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7D52AF0", Offset = "0x7D51CF0", VA = "0x187D52AF0", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool AKLLEADKCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xC64C90", Offset = "0xC63E90", VA = "0x180C64C90", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public OLPNEEDGLOG PCEGKAAAGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7D51A50", Offset = "0x7D50C50", VA = "0x187D51A50", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public double FGHKDAFDFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7D526A0", Offset = "0x7D518A0", VA = "0x187D526A0", Slot = "36")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int OAENOIOJFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7D51F40", Offset = "0x7D51140", VA = "0x187D51F40", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool CPGBIPKEOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6A90850", Offset = "0x6A8FA50", VA = "0x186A90850", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool AMJMLGFHMPO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7D52150", Offset = "0x7D51350", VA = "0x187D52150", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool LHPIPKLPFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7D52150", Offset = "0x7D51350", VA = "0x187D52150", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool GHLCEIMPKHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x110ED60", Offset = "0x110DF60", VA = "0x18110ED60", Slot = "46")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x110ED70", Offset = "0x110DF70", VA = "0x18110ED70", Slot = "47")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool LKCNMJONJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LGFCLALOGNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7D53020", Offset = "0x7D52220", VA = "0x187D53020", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public object HMKGICKHLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA003A0", Offset = "0x9FF5A0", VA = "0x180A003A0", Slot = "50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public BNFABCHNBCL NDGKEBACOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7D53000", Offset = "0x7D52200", VA = "0x187D53000", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int HBMHPKDEAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7D51B00", Offset = "0x7D50D00", VA = "0x187D51B00", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int DDOLIPMONHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7D52310", Offset = "0x7D51510", VA = "0x187D52310", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public BNFABCHNBCL FAKLMIENPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7D519E0", Offset = "0x7D50BE0", VA = "0x187D519E0", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool LNOIDHHPFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7D52F00", Offset = "0x7D52100", VA = "0x187D52F00", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int IKHGDNGBACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7D52EA0", Offset = "0x7D520A0", VA = "0x187D52EA0", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string JLIFHFHIKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7D526F0", Offset = "0x7D518F0", VA = "0x187D526F0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Func<string, string> PGNOKLFAGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7D521B0", Offset = "0x7D513B0", VA = "0x187D521B0", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public NMJNLDGKANB JANAJGHIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7D52650", Offset = "0x7D51850", VA = "0x187D52650", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override bool FOPOGAHOCGM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7D52140", Offset = "0x7D51340", VA = "0x187D52140", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7D52120", Offset = "0x7D51320", VA = "0x187D52120", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override float PJOJEPHKMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C920", Offset = "0xA1BB20", VA = "0x180A1C920", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA2CC40", Offset = "0xA2BE40", VA = "0x180A2CC40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override BKDNIFFCBID IIFADFPOKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA003C0", Offset = "0x9FF5C0", VA = "0x180A003C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KKLNJBGPMNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string EGKFLAKLNHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7D52B10", Offset = "0x7D51D10", VA = "0x187D52B10", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public long KLLOMNCCIHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7D51B80", Offset = "0x7D50D80", VA = "0x187D51B80", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public long GCHHOGPFJPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7D52900", Offset = "0x7D51B00", VA = "0x187D52900", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<BKDNIFFCBID, BKDNIFFCBID> AHNAEOAFAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7D52C10", Offset = "0x7D51E10", VA = "0x187D52C10", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7D52500", Offset = "0x7D51700", VA = "0x187D52500", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<HIPDGMOFECH> PPGKLDLOIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7D51E90", Offset = "0x7D51090", VA = "0x187D51E90", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D52A40", Offset = "0x7D51C40", VA = "0x187D52A40", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<BNFABCHNBCL> PONJHEFHAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7D51B90", Offset = "0x7D50D90", VA = "0x187D51B90", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7D53080", Offset = "0x7D52280", VA = "0x187D53080", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7D51DF0", Offset = "0x7D50FF0", VA = "0x187D51DF0")]
	[MGCKGAIBEHC.PCMIGKEOIEO.MAPPJIPMPIK]
	internal static void CNMFKDBOHKK(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7D53160", Offset = "0x7D52360", VA = "0x187D53160")]
	[RecRoom.DataLayer.Attributes.Preserve]
	public KKMDHLHOBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D52630", Offset = "0x7D51830", VA = "0x187D52630", Slot = "21")]
	public void HKNNMBJHLHG(List<object> CFFEIIKPOPD, int KOKMPCAPCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7D53140", Offset = "0x7D52340", VA = "0x187D53140", Slot = "23")]
	public void PLBLADIGEKO(IDictionary<object, object> GFKOIMIAEOH, int LPGODJOFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7D51CB0", Offset = "0x7D50EB0", VA = "0x187D51CB0", Slot = "27")]
	public void CJBHEDDMHLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D51FC0", Offset = "0x7D511C0", VA = "0x187D51FC0", Slot = "56")]
	public bool FAPDMAGLINC(object FLAPANBLPDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D51AD0", Offset = "0x7D50CD0", VA = "0x187D51AD0", Slot = "29")]
	public object BHIBMPPAILM(NativeArray<byte> CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D528E0", Offset = "0x7D51AE0", VA = "0x187D528E0", Slot = "55")]
	public void IOGJEEFFPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7D52100", Offset = "0x7D51300", VA = "0x187D52100", Slot = "22")]
	public void FDBMOAKKLOH(int BLKBKPJFHAB, object ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D527F0", Offset = "0x7D519F0", VA = "0x187D527F0", Slot = "83")]
	public BNFABCHNBCL IJFPHDJFBFP(int LJKLNEIKJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D52970", Offset = "0x7D51B70", VA = "0x187D52970", Slot = "82")]
	public BNFABCHNBCL JIGDLBCECOK(int CBKLGKPCDOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7D518E0", Offset = "0x7D50AE0", VA = "0x187D518E0", Slot = "84")]
	public BNFABCHNBCL AFAPGKBNDHO(int CBKLGKPCDOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7D53040", Offset = "0x7D52240", VA = "0x187D53040", Slot = "18")]
	public bool OKMJMBDPGIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D52CE0", Offset = "0x7D51EE0", VA = "0x187D52CE0", Slot = "85")]
	public IReadOnlyList<BNFABCHNBCL> MONOPOACAIF(bool ABMLPAFGNAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D523E0", Offset = "0x7D515E0", VA = "0x187D523E0", Slot = "86")]
	public IReadOnlyList<BNFABCHNBCL> GJIHCLCIMCP(bool ABMLPAFGNAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D52920", Offset = "0x7D51B20", VA = "0x187D52920", Slot = "54")]
	public bool JHJLDIBKECB(string HJODPMFLDHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D51E60", Offset = "0x7D51060", VA = "0x187D51E60", Slot = "53")]
	public bool DCKICKLAMJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D52180", Offset = "0x7D51380", VA = "0x187D52180", Slot = "20")]
	public void FJOLDACCLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7D523B0", Offset = "0x7D515B0", VA = "0x187D523B0", Slot = "70")]
	public bool GJELHJLMOHL(byte HADNLMBOMNH, object FAONOPFFPFN, FLEPBPAFMND GMFBDIONGGP, BMEOONJFDHA DHAAPHEFKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D51F90", Offset = "0x7D51190", VA = "0x187D51F90", Slot = "28")]
	public void ELKKKBEIKKA(object KFMNDOMPAMC, NativeList<byte> CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D52600", Offset = "0x7D51800", VA = "0x187D52600", Slot = "30")]
	public int HJEICJEDGBI(HIPDGMOFECH ODLIDIMANGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "45")]
	public void CCPNNNOBADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D52D70", Offset = "0x7D51F70", VA = "0x187D52D70", Slot = "87")]
	public bool NFFANMOLIFJ(BNFABCHNBCL IBGMFKKIGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "35")]
	public void HKHDAAPFAEH(string EOLAGLNDNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D51C40", Offset = "0x7D50E40", VA = "0x187D51C40", Slot = "17")]
	public float CELHMLBNKJA(bool LENEBIHJAON, int GCKPOJOONJN = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D529D0", Offset = "0x7D51BD0", VA = "0x187D529D0", Slot = "8")]
	public override void JKGCKACPBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D52200", Offset = "0x7D51400", VA = "0x187D52200", Slot = "81")]
	public void GBNMLLMKILO(string GBOCGPJOEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D525B0", Offset = "0x7D517B0", VA = "0x187D525B0", Slot = "95")]
	public int HGCNJEFJIKH()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D51CA0", Offset = "0x7D50EA0", VA = "0x187D51CA0", Slot = "11")]
	private void CGMIOPLGMDC(Action KJIOHKMJAPE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7D52910", Offset = "0x7D51B10", VA = "0x187D52910", Slot = "12")]
	private void JAIAFFGDPCE(Action KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D52A10", Offset = "0x7D51C10", VA = "0x187D52A10", Slot = "25")]
	private void KAJHMGEDFEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7D52A20", Offset = "0x7D51C20", VA = "0x187D52A20", Slot = "26")]
	private void LADKDGDNOPM()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D528D0", Offset = "0x7D51AD0", VA = "0x187D528D0", Slot = "31")]
	private void IMOOMFFEDHD(float KJIOHKMJAPE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7D52A30", Offset = "0x7D51C30", VA = "0x187D52A30", Slot = "32")]
	private void LEGLGLDCHDH(float KJIOHKMJAPE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7D52A00", Offset = "0x7D51C00", VA = "0x187D52A00", Slot = "57")]
	private void JOEDIIPLBFC(Action<bool> KJIOHKMJAPE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D51AB0", Offset = "0x7D50CB0", VA = "0x187D51AB0", Slot = "58")]
	private void BDOHLNGEBHC(Action<bool> KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D53130", Offset = "0x7D52330", VA = "0x187D53130", Slot = "59")]
	private void PAHMOPAJLDB(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D51B60", Offset = "0x7D50D60", VA = "0x187D51B60", Slot = "60")]
	private void BOPCFKAFEML(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7D52620", Offset = "0x7D51820", VA = "0x187D52620", Slot = "61")]
	private void HKFGELCALFD(object CCLFNPCGNED, bool HPDDMCOBLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7D52C00", Offset = "0x7D51E00", VA = "0x187D52C00", Slot = "62")]
	private IDisposable LLEMMIGMJLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7D51AC0", Offset = "0x7D50CC0", VA = "0x187D51AC0", Slot = "63")]
	private bool BHBFKPKLFOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7D52E90", Offset = "0x7D52090", VA = "0x187D52E90", Slot = "64")]
	private void NGFDNFLNCPJ(StringBuilder EBDMNFPBBKI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7D52CD0", Offset = "0x7D51ED0", VA = "0x187D52CD0", Slot = "66")]
	private void MMFDCCECCEF(Action<string, long> KJIOHKMJAPE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7D51AA0", Offset = "0x7D50CA0", VA = "0x187D51AA0", Slot = "67")]
	private void APHAMLGJIOD(Action<string, long> KJIOHKMJAPE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7D52CC0", Offset = "0x7D51EC0", VA = "0x187D52CC0", Slot = "88")]
	private void MKILBILPHDO(Action KJIOHKMJAPE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7D526E0", Offset = "0x7D518E0", VA = "0x187D526E0", Slot = "89")]
	private void IEODBEIAKAH(Action KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7D51B70", Offset = "0x7D50D70", VA = "0x187D51B70", Slot = "90")]
	private void CBDOBKHBEOP()
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
		public NfgoCommsNetwork EINGHAMFLAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B460", Offset = "0x7D4A660", VA = "0x187D4B460")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B620", Offset = "0x7D4A820", VA = "0x187D4B620")]
		private void FOCCGGBMFJE(NetworkManager DMNAILPFDAC, bool CJDHJNNFIFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D53420", Offset = "0x7D52620", VA = "0x187D53420")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public NetworkManagerBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NBDBECOKJAP
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool LAMNHKKOCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA75190", Offset = "0xA74390", VA = "0x180A75190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA75210", Offset = "0xA74410", VA = "0x180A75210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public NetworkManager NHIMMMKMMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public NetworkManager JCFCPJNMBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA00D60", Offset = "0x9FFF60", VA = "0x180A00D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<NetworkManager, bool> FOCCGGBMFJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7D53370", Offset = "0x7D52570", VA = "0x187D53370")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D532C0", Offset = "0x7D524C0", VA = "0x187D532C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6B55310", Offset = "0x6B54510", VA = "0x186B55310")]
	[RecRoom.NoEngine.Common.Preserve]
	public NBDBECOKJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D531E0", Offset = "0x7D523E0", VA = "0x187D531E0")]
	[MGCKGAIBEHC.PCMIGKEOIEO]
	public static void ADNEOGJDLPG(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D53250", Offset = "0x7D52450", VA = "0x187D53250")]
	public void CLJIAKGPLKH(NetworkManager DMNAILPFDAC, bool CJDHJNNFIFM)
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
