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
		[Cpp2IlInjected.Address(RVA = "0x81B9C10", Offset = "0x81B8A10", VA = "0x1881B9C10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HDBBFBKJFLI : CPJLNGDAGBF, OPAAHFOBOJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DefaultMember("Item")]
	private class LFBDJPJBOHM : BNHAMMLICHE
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object CBMLGEIEAGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x81B9A10", Offset = "0x81B8810", VA = "0x1881B9A10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public byte DAKKGIPNOCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xB2CDD0", Offset = "0xB2BBD0", VA = "0x180B2CDD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xB2CE40", Offset = "0xB2BC40", VA = "0x180B2CE40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int IHPIJHOJMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAAA750", Offset = "0xAA9550", VA = "0x180AAA750", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB28270", Offset = "0xB27070", VA = "0x180B28270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object JGAMFNLHNIE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7A9C4D0", Offset = "0x7A9B2D0", VA = "0x187A9C4D0")]
		public LFBDJPJBOHM(byte PDHHKJCHAJA, int DFODLDMBKGD, object BOIPFNOKGBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x81B99C0", Offset = "0x81B87C0", VA = "0x1881B99C0", Slot = "8")]
		public bool BNILIKGEJAF(byte MAHBBBBCDEL, [Out] object BNECONOIKOE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NetworkManager JCEHEMKGMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ILCNLGIIPEB AIEIFGIBFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stopwatch AEPAFAHKDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int GDPBPNPDCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Deque<LFBDJPJBOHM> HIEOEHIBOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Deque<Action> EDNECCGOLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private DLMPABDBBJM IEOIKEEKMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private FFMIMPPMBNP FNPMDPKFBNG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NetworkManager HLOBHODACMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x81B4480", Offset = "0x81B3280", VA = "0x1881B4480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public ILCNLGIIPEB DLDBOMMMBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620", Slot = "4")]
		get
		{
			return default(ILCNLGIIPEB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81B5770", Offset = "0x81B4570", VA = "0x1881B5770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int OAHODONCFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA5A420", Offset = "0xA59220", VA = "0x180A5A420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public DLMPABDBBJM MJGODKHPGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4F0", Offset = "0xA5B2F0", VA = "0x180A5C4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FFMIMPPMBNP PBIJCPHLAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA604A0", Offset = "0xA5F2A0", VA = "0x180A604A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private DIHIMKCCGKN CCNDPEGEFGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA604A0", Offset = "0xA5F2A0", VA = "0x180A604A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NAHHPGMFNBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81B6320", Offset = "0x81B5120", VA = "0x1881B6320", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NOIMKFJOLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81B3A50", Offset = "0x81B2850", VA = "0x1881B3A50", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LIDHMMPDJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81B3A50", Offset = "0x81B2850", VA = "0x1881B3A50", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool FCMLANFFHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81B3A50", Offset = "0x81B2850", VA = "0x1881B3A50", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Exception GOAFLKPDJKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F360", Offset = "0xA5E160", VA = "0x180A5F360", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3A0", Offset = "0xA5E1A0", VA = "0x180A5F3A0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JJIGJAHEODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool HODFGAGHBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x81B4830", Offset = "0x81B3630", VA = "0x1881B4830", Slot = "17")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81B5E90", Offset = "0x81B4C90", VA = "0x1881B5E90", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool OGFOBHKBACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD10C20", Offset = "0xD0FA20", VA = "0x180D10C20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD10040", Offset = "0xD0EE40", VA = "0x180D10040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double AKMLMBPHIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81B6330", Offset = "0x81B5130", VA = "0x1881B6330")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double GNAALNMOBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x81B4220", Offset = "0x81B3020", VA = "0x1881B4220")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int IDPPEIEPNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x81B47E0", Offset = "0x81B35E0", VA = "0x1881B47E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string HPAHAFNOGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81B51B0", Offset = "0x81B3FB0", VA = "0x1881B51B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int NCNEBDOHOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81B5990", Offset = "0x81B4790", VA = "0x1881B5990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public FJAIJAJKHFG LCJNHJJBAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81B6F80", Offset = "0x81B5D80", VA = "0x1881B6F80", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string, long> IADDKLIFMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81B6640", Offset = "0x81B5440", VA = "0x1881B6640", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81B3BE0", Offset = "0x81B29E0", VA = "0x1881B3BE0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<ILCNLGIIPEB, ILCNLGIIPEB> LFPCICDKFEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81B7B70", Offset = "0x81B6970", VA = "0x1881B7B70", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x81B4250", Offset = "0x81B3050", VA = "0x1881B4250", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x81B7C20", Offset = "0x81B6A20", VA = "0x1881B7C20")]
	public HDBBFBKJFLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x81B5080", Offset = "0x81B3E80", VA = "0x1881B5080")]
	public bool FPLNMAMJNDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x81B5280", Offset = "0x81B4080", VA = "0x1881B5280")]
	public bool GIBCAOLOBGD(CDKFIILELLC LLBLGOOBCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x81B6450", Offset = "0x81B5250", VA = "0x1881B6450")]
	public bool KJJGJBECFMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x81B6480", Offset = "0x81B5280", VA = "0x1881B6480")]
	public void LGBOCOOKBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x81B3C90", Offset = "0x81B2A90", VA = "0x1881B3C90")]
	public void CAHILKGDOKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x81B5A20", Offset = "0x81B4820", VA = "0x1881B5A20")]
	public void IIELLNMFOFA(List<object> ECEBLBALENP, int HBNCFIPENFO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x81B78D0", Offset = "0x81B66D0", VA = "0x1881B78D0")]
	public void ONJGFBCKFIJ(int OHLPJOJPIDL, object IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x81B5550", Offset = "0x81B4350", VA = "0x1881B5550")]
	public void HDALMNFEABP(IDictionary<object, object> MDOGLHGIMLE, int DGOGGKOBPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x81B6CF0", Offset = "0x81B5AF0", VA = "0x1881B6CF0")]
	public void NEJFHFKCOKJ(object MKPNGAKJFMP, NativeList<byte> EGALMGGHIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x81B6360", Offset = "0x81B5160", VA = "0x1881B6360")]
	public object KIDJPDKJMHF(NativeArray<byte> GGCHDPHENOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x81B57A0", Offset = "0x81B45A0", VA = "0x1881B57A0")]
	public int HHAGGLCDGOE(BNHAMMLICHE IHKPBFJODHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x81B33E0", Offset = "0x81B21E0", VA = "0x1881B33E0")]
	public bool ABAIPAFDLHL(byte PDHHKJCHAJA, object DJDGPPAEEBM, EIIAJLFMPKP AHDDAHBPIGH, CEHPMOIPPMO JOBCJCEJNOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x81B7410", Offset = "0x81B6210", VA = "0x1881B7410")]
	public bool OKHOBCHCJAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x81B45B0", Offset = "0x81B33B0", VA = "0x1881B45B0")]
	internal bool DMMGBJDCLNH([In] NFJALHEMGLM CNKGEHPKHAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x81B4990", Offset = "0x81B3790", VA = "0x1881B4990")]
	internal bool FACHADCEIKP([In] KJNGDIFGICO JBNEABKLADH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x81B4E20", Offset = "0x81B3C20", VA = "0x1881B4E20")]
	public void FICLGNDECFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x81B4E20", Offset = "0x81B3C20", VA = "0x1881B4E20")]
	public void JCGEKJAIEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x81B4300", Offset = "0x81B3100", VA = "0x1881B4300")]
	private void DDHNBBLBBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x81B3F00", Offset = "0x81B2D00", VA = "0x1881B3F00")]
	private void CJPGJEMOFKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x81B3CC0", Offset = "0x81B2AC0", VA = "0x1881B3CC0")]
	private void CCOGCLEAAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x81B4E30", Offset = "0x81B3C30", VA = "0x1881B4E30")]
	private void FJDOAONPMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x81B5C30", Offset = "0x81B4A30", VA = "0x1881B5C30")]
	private void IPPADGJDCNM(ulong OBLHJKHHAHH, FastBufferReader IEDIHGHFEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3B9EA50", Offset = "0x3B9D850", VA = "0x183B9EA50")]
	private void EDBCDHALKPM<T>(BDAGCLKBJJB PDHHKJCHAJA, FastBufferReader IEDIHGHFEKD) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x81B3A80", Offset = "0x81B2880", VA = "0x1881B3A80")]
	private void BHPMCKENINF(byte PDHHKJCHAJA, int DFODLDMBKGD, object BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x81B4D10", Offset = "0x81B3B10", VA = "0x1881B4D10")]
	private void FEILLECBLBE(ulong OBLHJKHHAHH, FastBufferReader IEDIHGHFEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x81B67C0", Offset = "0x81B55C0", VA = "0x1881B67C0")]
	private void MGOGMFFJOAC(LFBDJPJBOHM BKMCGGEFFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x81B5EC0", Offset = "0x81B4CC0", VA = "0x1881B5EC0")]
	private void JGJEHONPPAC(LFBDJPJBOHM BKMCGGEFFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x81B64B0", Offset = "0x81B52B0", VA = "0x1881B64B0")]
	private void LMBEMAKPJLB(LFBDJPJBOHM BKMCGGEFFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x81B5390", Offset = "0x81B4190", VA = "0x1881B5390")]
	private void HAPBILACPMA(LFBDJPJBOHM BKMCGGEFFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x81B3790", Offset = "0x81B2590", VA = "0x1881B3790")]
	private void ACJENBCDMBI(LFBDJPJBOHM BKMCGGEFFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x81B4860", Offset = "0x81B3660", VA = "0x1881B4860")]
	private void ELBNGMNKBEE(LFBDJPJBOHM BKMCGGEFFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x81B4BC0", Offset = "0x81B39C0", VA = "0x1881B4BC0")]
	private void FEILLECBLBE(LFBDJPJBOHM BKMCGGEFFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x81B66F0", Offset = "0x81B54F0", VA = "0x1881B66F0")]
	private void MAEAOEPGEHF(ulong KLGOHLFABCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x81B3E10", Offset = "0x81B2C10", VA = "0x1881B3E10")]
	private void CGLGCLEBOFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x81B6FD0", Offset = "0x81B5DD0", VA = "0x1881B6FD0")]
	private void OHKFENKKCOB(CMNFMNABDHH DIIJENKMGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x81B3BD0", Offset = "0x81B29D0", VA = "0x1881B3BD0")]
	[CompilerGenerated]
	private void BIFIIKANGCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DLMPABDBBJM : CDKFIILELLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private HDBBFBKJFLI PGEHJEAKJNP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static string DLLNHBGOKEE;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static Func<string, string> HHBCCJPDNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int JHNFOHMLJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private string LCBFKKAIOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private ObscuredInt FBFBLOGLBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool? MMBLBHHCIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string CPBOKDIMCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private ulong IGDPHNNHLDE;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int IBBIDJIGOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool MPPFHFHCAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xB0D250", Offset = "0xB0C050", VA = "0x180B0D250", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xE42BA0", Offset = "0xE419A0", VA = "0x180E42BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool PPIEILJKDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x81B1A60", Offset = "0x81B0860", VA = "0x1881B1A60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Dictionary<object, object> DBHBGBCBPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string IBOIBGHBENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x81B1DD0", Offset = "0x81B0BD0", VA = "0x1881B1DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int MPBOFFCJKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x81B1A10", Offset = "0x81B0810", VA = "0x1881B1A10", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GNICHOAEJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool NBAFEHAJADE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x81B1EC0", Offset = "0x81B0CC0", VA = "0x1881B1EC0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string KEDGENGBEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA604A0", Offset = "0xA5F2A0", VA = "0x180A604A0", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x81B1FE0", Offset = "0x81B0DE0", VA = "0x1881B1FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string IBGCILEFLOE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x81B1F80", Offset = "0x81B0D80", VA = "0x1881B1F80", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool CBIHOBKOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public object MEFHBMKJAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F360", Offset = "0xA5E160", VA = "0x180A5F360", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3A0", Offset = "0xA5E1A0", VA = "0x180A5F3A0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	internal ulong ODPJOEKKOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA5F330", Offset = "0xA5E130", VA = "0x180A5F330")]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x81B19F0", Offset = "0x81B07F0", VA = "0x1881B19F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x81B2290", Offset = "0x81B1090", VA = "0x1881B2290")]
	internal DLMPABDBBJM(HDBBFBKJFLI DNNGMHNAHKG, bool NHIOAFMOPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x81B2130", Offset = "0x81B0F30", VA = "0x1881B2130")]
	internal DLMPABDBBJM(HDBBFBKJFLI DNNGMHNAHKG, bool NHIOAFMOPIC, ulong KLGOHLFABCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x81B2170", Offset = "0x81B0F70", VA = "0x1881B2170")]
	internal DLMPABDBBJM(HDBBFBKJFLI DNNGMHNAHKG, bool NHIOAFMOPIC, [In] NFJALHEMGLM OMCDDJFGHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x81B2080", Offset = "0x81B0E80", VA = "0x1881B2080", Slot = "16")]
	public bool PJDJKDOLJAO(Dictionary<object, object> HLJCHNFCJNK, [Optional] Dictionary<object, object> IPMAPGANMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x81B1AF0", Offset = "0x81B08F0", VA = "0x1881B1AF0")]
	internal void HNOEJMFJPMJ([In] NFJALHEMGLM CNKGEHPKHAG, bool FAGCAOIIENN = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FFMIMPPMBNP : DIHIMKCCGKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private HDBBFBKJFLI PGEHJEAKJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Dictionary<object, object> IGAKPKHOOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal Dictionary<int, DLMPABDBBJM> PKDGFJPNMGA;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string OFMLOIDKMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x81B2FE0", Offset = "0x81B1DE0", VA = "0x1881B2FE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public byte JEONCIPDDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x81B2920", Offset = "0x81B1720", VA = "0x1881B2920", Slot = "5")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool LCOLGNFCGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Dictionary<object, object> DBHBGBCBPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public DLMPABDBBJM[] KJDKPHJMHML
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA59830", Offset = "0xA58630", VA = "0x180A59830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public DLMPABDBBJM[] NENGACBBNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA59890", Offset = "0xA58690", VA = "0x180A59890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public DLMPABDBBJM[] KBLNLGBAIHK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA604F0", Offset = "0xA5F2F0", VA = "0x180A604F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public DLMPABDBBJM[] HACIMCNIJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4F0", Offset = "0xA5B2F0", VA = "0x180A5C4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA5C310", Offset = "0xA5B110", VA = "0x180A5C310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BGKCOIIMBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xACBC40", Offset = "0xACAA40", VA = "0x180ACBC40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xF881E0", Offset = "0xF86FE0", VA = "0x180F881E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x81B3240", Offset = "0x81B2040", VA = "0x1881B3240")]
	public FFMIMPPMBNP(HDBBFBKJFLI DNNGMHNAHKG, [In] KJNGDIFGICO JBNEABKLADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x81B2970", Offset = "0x81B1770", VA = "0x1881B2970", Slot = "9")]
	public bool FIPPBCJIOAH(int PPPFBKMGIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x81B31B0", Offset = "0x81B1FB0", VA = "0x1881B31B0", Slot = "8")]
	public bool PJDJKDOLJAO(Dictionary<object, object> HLJCHNFCJNK, [Optional] Dictionary<object, object> CDOAECFNCGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x81B29D0", Offset = "0x81B17D0", VA = "0x1881B29D0")]
	internal bool GEKHJHNFEGC([In] NFJALHEMGLM CNKGEHPKHAG, bool KGGCMNDILEM, [Out] DLMPABDBBJM IFADLDJHCLA, bool FAGCAOIIENN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x81B3010", Offset = "0x81B1E10", VA = "0x1881B3010")]
	internal void NJCPODEFFAD(ulong KLGOHLFABCA, [Out] DLMPABDBBJM IFADLDJHCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x81B2B90", Offset = "0x81B1990", VA = "0x1881B2B90")]
	internal void JDBLKPLKPDH([In] KJNGDIFGICO JBNEABKLADH, bool FAGCAOIIENN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x81B24E0", Offset = "0x81B12E0", VA = "0x1881B24E0")]
	private void AODIIGGFPEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KJKIKCAIEKC : BCLJMHGPDBF, GLOINHDCCCK, DHAHCLFAPFA, EOJHGHGPFPI, LDHNAFBKDEA, JMFPGPLHDPA, ADIAHLJLKIO, OPAAHFOBOJE, EHBOHPGOIAN, CEHAECEOKIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private HDBBFBKJFLI PGEHJEAKJNP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int IDPPEIEPNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x81B86E0", Offset = "0x81B74E0", VA = "0x1881B86E0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int BCAFJBLGPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int LMLIGJHLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x81B8190", Offset = "0x81B6F90", VA = "0x1881B8190", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int OAHODONCFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x81B8E50", Offset = "0x81B7C50", VA = "0x1881B8E50", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool BBODGPDPOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xD10040", Offset = "0xD0EE40", VA = "0x180D10040", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MIMLHNDICHP DBIGIFBFNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x81B8B90", Offset = "0x81B7990", VA = "0x1881B8B90", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public double AKMLMBPHIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x81B91F0", Offset = "0x81B7FF0", VA = "0x1881B91F0", Slot = "36")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int FBPFALFLPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x81B8860", Offset = "0x81B7660", VA = "0x1881B8860", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool IAHNJICMNLM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6EC2060", Offset = "0x6EC0E60", VA = "0x186EC2060", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool NOIMKFJOLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x81B9000", Offset = "0x81B7E00", VA = "0x1881B9000", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool LIDHMMPDJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x81B9000", Offset = "0x81B7E00", VA = "0x1881B9000", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool JGMPFJHBDML
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x11F9290", Offset = "0x11F8090", VA = "0x1811F9290", Slot = "46")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x11F92B0", Offset = "0x11F80B0", VA = "0x1811F92B0", Slot = "47")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool LADGFNPHHOO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool NAHHPGMFNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x81B91D0", Offset = "0x81B7FD0", VA = "0x1881B91D0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public object FAGOAHMLAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA5F350", Offset = "0xA5E150", VA = "0x180A5F350", Slot = "50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public CDKFIILELLC MJGODKHPGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x81B92F0", Offset = "0x81B80F0", VA = "0x1881B92F0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int FAPMOAFEKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x81B8CD0", Offset = "0x81B7AD0", VA = "0x1881B8CD0", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int AFKDEMJKGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x81B8630", Offset = "0x81B7430", VA = "0x1881B8630", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public CDKFIILELLC KHOJCOJCEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x81B8B20", Offset = "0x81B7920", VA = "0x1881B8B20", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool FIGMIMCIHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x81B83E0", Offset = "0x81B71E0", VA = "0x1881B83E0", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int JEONCIPDDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x81B87F0", Offset = "0x81B75F0", VA = "0x1881B87F0", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string DLLNHBGOKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x81B88D0", Offset = "0x81B76D0", VA = "0x1881B88D0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Func<string, string> HHBCCJPDNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x81B8230", Offset = "0x81B7030", VA = "0x1881B8230", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public FJAIJAJKHFG LCJNHJJBAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x81B9800", Offset = "0x81B8600", VA = "0x1881B9800", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override bool OGFOBHKBACH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x81B9560", Offset = "0x81B8360", VA = "0x1881B9560", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x81B8E70", Offset = "0x81B7C70", VA = "0x1881B8E70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override float HMOGIKDGOJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA73970", Offset = "0xA72770", VA = "0x180A73970", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA83D60", Offset = "0xA82B60", VA = "0x180A83D60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override CPJLNGDAGBF MCDEPDOPBIP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E190", VA = "0x180A5F390", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool LDKMONLCEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string HPAHAFNOGKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x81B8BE0", Offset = "0x81B79E0", VA = "0x1881B8BE0", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public long IBIOEHJMPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x81B8850", Offset = "0x81B7650", VA = "0x1881B8850", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public long AFJEMEBGFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x81B83D0", Offset = "0x81B71D0", VA = "0x1881B83D0", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<CPJLNGDAGBF, CPJLNGDAGBF> GEDEKJOBMNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x81B80D0", Offset = "0x81B6ED0", VA = "0x1881B80D0", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x81B8740", Offset = "0x81B7540", VA = "0x1881B8740", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<BNHAMMLICHE> IPHPMBONNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x81B9570", Offset = "0x81B8370", VA = "0x1881B9570", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x81B9480", Offset = "0x81B8280", VA = "0x1881B9480", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<CDKFIILELLC> CGBHEFOCDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x81B9650", Offset = "0x81B8450", VA = "0x1881B9650", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x81B8580", Offset = "0x81B7380", VA = "0x1881B8580", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x81B9790", Offset = "0x81B8590", VA = "0x1881B9790")]
	[ONLJNMLDJBD.KDDDMPKOLFO.GACHHHHOLBP]
	internal static void NPDNKFNEHEP(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x81B9940", Offset = "0x81B8740", VA = "0x1881B9940")]
	[RecRoom.DataLayer.Attributes.Preserve]
	public KJKIKCAIEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x81B9030", Offset = "0x81B7E30", VA = "0x1881B9030", Slot = "21")]
	public void IIELLNMFOFA(List<object> ECEBLBALENP, int HBNCFIPENFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x81B8E90", Offset = "0x81B7C90", VA = "0x1881B8E90", Slot = "23")]
	public void HDALMNFEABP(IDictionary<object, object> MDOGLHGIMLE, int DGOGGKOBPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x81B8290", Offset = "0x81B7090", VA = "0x1881B8290", Slot = "27")]
	public void ANALPCHCPDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x81B9340", Offset = "0x81B8140", VA = "0x1881B9340", Slot = "56")]
	public bool LEKEFCMFPDG(object NGKKNOEFOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x81B92C0", Offset = "0x81B80C0", VA = "0x1881B92C0", Slot = "29")]
	public object KIDJPDKJMHF(NativeArray<byte> BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x81B9190", Offset = "0x81B7F90", VA = "0x1881B9190", Slot = "55")]
	public void JCGEKJAIEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x81B98F0", Offset = "0x81B86F0", VA = "0x1881B98F0", Slot = "22")]
	public void ONJGFBCKFIJ(int OHLPJOJPIDL, object IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x81B9050", Offset = "0x81B7E50", VA = "0x1881B9050", Slot = "83")]
	public CDKFIILELLC IOLEOBNOIFI(int ADHDKEKHIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x81B9130", Offset = "0x81B7F30", VA = "0x1881B9130", Slot = "82")]
	public CDKFIILELLC JADMFPFBEGO(int KBOFJIFLEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x81B8EB0", Offset = "0x81B7CB0", VA = "0x1881B8EB0", Slot = "84")]
	public CDKFIILELLC HDOFDBCLPAD(int KBOFJIFLEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x81B9850", Offset = "0x81B8650", VA = "0x1881B9850", Slot = "18")]
	public bool OIFEDKKEPKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x81B9230", Offset = "0x81B8030", VA = "0x1881B9230", Slot = "85")]
	public IReadOnlyList<CDKFIILELLC> JPIEBONGCDC(bool CNEBLAHDCNB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x81B84E0", Offset = "0x81B72E0", VA = "0x1881B84E0", Slot = "86")]
	public IReadOnlyList<CDKFIILELLC> BHMCFIBJKMP(bool CNEBLAHDCNB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x81B9890", Offset = "0x81B8690", VA = "0x1881B9890", Slot = "54")]
	public bool OKHOBCHCJAC(string ICEMEMOCFCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x81B89E0", Offset = "0x81B77E0", VA = "0x1881B89E0", Slot = "53")]
	public bool FICLGNDECFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x81B9530", Offset = "0x81B8330", VA = "0x1881B9530", Slot = "20")]
	public void LJDLCALCAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x81B80A0", Offset = "0x81B6EA0", VA = "0x1881B80A0", Slot = "70")]
	public bool ABAIPAFDLHL(byte PDHHKJCHAJA, object DJDGPPAEEBM, EIIAJLFMPKP AHDDAHBPIGH, CEHPMOIPPMO JOBCJCEJNOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x81B9620", Offset = "0x81B8420", VA = "0x1881B9620", Slot = "28")]
	public void NEJFHFKCOKJ(object MKPNGAKJFMP, NativeList<byte> BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x81B8FB0", Offset = "0x81B7DB0", VA = "0x1881B8FB0", Slot = "30")]
	public int HHAGGLCDGOE(BNHAMMLICHE IHKPBFJODHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "45")]
	public void OIAOCLJPLGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x81B8D30", Offset = "0x81B7B30", VA = "0x1881B8D30", Slot = "87")]
	public bool GIBCAOLOBGD(CDKFIILELLC OEKEOJLNJFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "35")]
	public void MAPGFGHAJCP(string NFDIHIIAFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x81B9730", Offset = "0x81B8530", VA = "0x1881B9730", Slot = "17")]
	public float NMJJNGGIJOH(bool MFMEBCJBONP, int OPNJKDEMFDP = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x81B8FD0", Offset = "0x81B7DD0", VA = "0x1881B8FD0", Slot = "8")]
	public override void HNIFPNHHMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x81B8A10", Offset = "0x81B7810", VA = "0x1881B8A10", Slot = "81")]
	public void FJEKKPEHOEO(string GGDFKFACHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x81B86E0", Offset = "0x81B74E0", VA = "0x1881B86E0", Slot = "95")]
	public int CMFIGGFOIMP()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x81B8220", Offset = "0x81B7020", VA = "0x1881B8220", Slot = "11")]
	private void AJKHOCBEBOO(Action BNECONOIKOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x81B8570", Offset = "0x81B7370", VA = "0x1881B8570", Slot = "12")]
	private void BJLCPDIDDPB(Action BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x81B9920", Offset = "0x81B8720", VA = "0x1881B9920", Slot = "25")]
	private void PBIEEFECMAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x81B88C0", Offset = "0x81B76C0", VA = "0x1881B88C0", Slot = "26")]
	private void FCEEKAHPCME()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x81B9720", Offset = "0x81B8520", VA = "0x1881B9720", Slot = "31")]
	private void NHECNLDMDPC(float BNECONOIKOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x81B9910", Offset = "0x81B8710", VA = "0x1881B9910", Slot = "32")]
	private void OOOIAMFBIHJ(float BNECONOIKOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x81B8180", Offset = "0x81B6F80", VA = "0x1881B8180", Slot = "57")]
	private void AFCAHKEKHJP(Action<bool> BNECONOIKOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x81B8730", Offset = "0x81B7530", VA = "0x1881B8730", Slot = "58")]
	private void DBBEIBBDLDJ(Action<bool> BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x81B9310", Offset = "0x81B8110", VA = "0x1881B9310", Slot = "59")]
	private void KLHIGEBOJDI(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x81B9930", Offset = "0x81B8730", VA = "0x1881B9930", Slot = "60")]
	private void PCKHFMFGOON(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x81B91C0", Offset = "0x81B7FC0", VA = "0x1881B91C0", Slot = "61")]
	private void JFPOAFGKIPM(object OCGDLEBGIMO, bool EKEBHDLGILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x81B91B0", Offset = "0x81B7FB0", VA = "0x1881B91B0", Slot = "62")]
	private IDisposable JDMJMPCLKGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x81B88B0", Offset = "0x81B76B0", VA = "0x1881B88B0", Slot = "63")]
	private bool EMOEAFLGOCN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x81B9330", Offset = "0x81B8130", VA = "0x1881B9330", Slot = "64")]
	private void KPMFBAOEAKA(StringBuilder DEPPELPLLGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x81B9710", Offset = "0x81B8510", VA = "0x1881B9710", Slot = "66")]
	private void NFMOKEMALKF(Action<string, long> BNECONOIKOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x81B9700", Offset = "0x81B8500", VA = "0x1881B9700", Slot = "67")]
	private void NFINKNNNFMH(Action<string, long> BNECONOIKOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x81B9320", Offset = "0x81B8120", VA = "0x1881B9320", Slot = "88")]
	private void KNCEMEFIFKH(Action BNECONOIKOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x81B98E0", Offset = "0x81B86E0", VA = "0x1881B98E0", Slot = "89")]
	private void OLDBBCNGJKC(Action BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x81B86D0", Offset = "0x81B74D0", VA = "0x1881B86D0", Slot = "90")]
	private void CGEOAKENEFF()
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
		public NfgoCommsNetwork ALPIBJFOLJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x81B22D0", Offset = "0x81B10D0", VA = "0x1881B22D0")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x81B2490", Offset = "0x81B1290", VA = "0x1881B2490")]
		private void HEEKFBNOKND(NetworkManager ENFMAKKMJIP, bool JELHCLAPDNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
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
		[Cpp2IlInjected.Address(RVA = "0x81B9A60", Offset = "0x81B8860", VA = "0x1881B9A60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public NetworkManagerBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HNLCMCOICAN
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool FDAOENHILMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xB2CDD0", Offset = "0xB2BBD0", VA = "0x180B2CDD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xB2CE40", Offset = "0xB2BC40", VA = "0x180B2CE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public NetworkManager HLOBHODACMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public NetworkManager KDMGIJAFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA59830", Offset = "0xA58630", VA = "0x180A59830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<NetworkManager, bool> HEEKFBNOKND
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x81B7F40", Offset = "0x81B6D40", VA = "0x1881B7F40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x81B7FF0", Offset = "0x81B6DF0", VA = "0x1881B7FF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F873A0", Offset = "0x6F861A0", VA = "0x186F873A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HNLCMCOICAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x81B7E60", Offset = "0x81B6C60", VA = "0x1881B7E60")]
	[ONLJNMLDJBD.KDDDMPKOLFO]
	public static void AJNEFMAOKGA(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x81B7ED0", Offset = "0x81B6CD0", VA = "0x1881B7ED0")]
	public void EKBGNGBCMLI(NetworkManager ENFMAKKMJIP, bool JELHCLAPDNA)
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
