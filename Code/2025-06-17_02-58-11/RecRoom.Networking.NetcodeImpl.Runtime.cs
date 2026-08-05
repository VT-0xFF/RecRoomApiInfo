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
		[Cpp2IlInjected.Address(RVA = "0x7E471E0", Offset = "0x7E45BE0", VA = "0x187E471E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LNPCCBKFFLK : ABEGIIDNPGF, AHDBNGNAHKJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DefaultMember("Item")]
	private class CCGKKCKMKIF : HCCHCCGILAH
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object OIPJADEMDCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7E3F940", Offset = "0x7E3E340", VA = "0x187E3F940", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public byte GELPCFHKOEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA97A50", Offset = "0xA96450", VA = "0x180A97A50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA979E0", Offset = "0xA963E0", VA = "0x180A979E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int DIKGDMMMELA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA627B0", Offset = "0xA611B0", VA = "0x180A627B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8FF0", Offset = "0xAB79F0", VA = "0x180AB8FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object CHFABLEDFEN
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x773FCD0", Offset = "0x773E6D0", VA = "0x18773FCD0")]
		public CCGKKCKMKIF(byte FDDOIFDLLNO, int GAMOJFHOMGC, object HPGIDELCODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F990", Offset = "0x7E3E390", VA = "0x187E3F990", Slot = "8")]
		public bool EHEIJGNBGFA(byte KJNEHANBOBO, [Out] object PCDAHJCDHHF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NetworkManager FGPBMLEKMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NOAABDNNCAE IBNBMBFJKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stopwatch DKNMCPLHMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int FKMOCEPIAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Deque<CCGKKCKMKIF> GKEBBNCFKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Deque<Action> MCACNNNDBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private BHBLLAPJCAP NKHBBLHBBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private MIDDGOMNHNB CBIOFCNMBBM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NetworkManager IELDMHOMBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E427C0", Offset = "0x7E411C0", VA = "0x187E427C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NOAABDNNCAE HFPJFCJDEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240", Slot = "4")]
		get
		{
			return default(NOAABDNNCAE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E42E80", Offset = "0x7E41880", VA = "0x187E42E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BAPDJMFHFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA155B0", Offset = "0xA13FB0", VA = "0x180A155B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public BHBLLAPJCAP IGOAGANFOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MIDDGOMNHNB FIGPJMCIBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private LPHAJBGNAJO DKBAMPMDKML
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BJLEFKIJJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7E42EB0", Offset = "0x7E418B0", VA = "0x187E42EB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool JCKDJLBFMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7E428F0", Offset = "0x7E412F0", VA = "0x187E428F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OBHIDFLPHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7E428F0", Offset = "0x7E412F0", VA = "0x187E428F0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool DGNNGGDMIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7E428F0", Offset = "0x7E412F0", VA = "0x187E428F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Exception DCIIBPDJBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA10560", Offset = "0xA0EF60", VA = "0x180A10560", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LNNIINIPGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FLBLJJAODCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7E44070", Offset = "0x7E42A70", VA = "0x187E44070", Slot = "17")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7E45950", Offset = "0x7E44350", VA = "0x187E45950", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool BACHOHNPMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xC930E0", Offset = "0xC91AE0", VA = "0x180C930E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xC92820", Offset = "0xC91220", VA = "0x180C92820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double MPFAODOCFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7E456F0", Offset = "0x7E440F0", VA = "0x187E456F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double LCNEHAGCAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7E42D00", Offset = "0x7E41700", VA = "0x187E42D00")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int IKIMEPANDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7E42C00", Offset = "0x7E41600", VA = "0x187E42C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string HKPECCALMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7E426E0", Offset = "0x7E410E0", VA = "0x187E426E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int HFKKODHKJNG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7E43A80", Offset = "0x7E42480", VA = "0x187E43A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public KBKKLBBPBEC MOFIOOKNECE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7E41500", Offset = "0x7E3FF00", VA = "0x187E41500", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string, long> EKDELKNBGEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7E44940", Offset = "0x7E43340", VA = "0x187E44940", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7E421E0", Offset = "0x7E40BE0", VA = "0x187E421E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<NOAABDNNCAE, NOAABDNNCAE> BNONNHPAAMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7E43DF0", Offset = "0x7E427F0", VA = "0x187E43DF0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7E42C50", Offset = "0x7E41650", VA = "0x187E42C50", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7E45D00", Offset = "0x7E44700", VA = "0x187E45D00")]
	public LNPCCBKFFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E451E0", Offset = "0x7E43BE0", VA = "0x187E451E0")]
	public bool ODKPFIKGMKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E41550", Offset = "0x7E3FF50", VA = "0x187E41550")]
	public bool BEBNMLALAHL(GBDECDHLMJN GKJDHMPBADP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E42BD0", Offset = "0x7E415D0", VA = "0x187E42BD0")]
	public bool GJBDKJGPNJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E421B0", Offset = "0x7E40BB0", VA = "0x187E421B0")]
	public void CKPFPHPEOLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E42180", Offset = "0x7E40B80", VA = "0x187E42180")]
	public void CHHDCAFGALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7E43B10", Offset = "0x7E42510", VA = "0x187E43B10")]
	public void JLLDDLJJMNC(List<object> IBKFNAMHILN, int OBKGKEGIECO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7E437E0", Offset = "0x7E421E0", VA = "0x187E437E0")]
	public void JFJJPDFFGCJ(int BLEDCECONDJ, object JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7E435C0", Offset = "0x7E41FC0", VA = "0x187E435C0")]
	public void JBPNKDNJAGI(IDictionary<object, object> COGBEMJPNIC, int BJBHFAMODGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7E45A70", Offset = "0x7E44470", VA = "0x187E45A70")]
	public void PGPOMLMDCHO(object OJDHMKOBKLD, NativeList<byte> JFCHKCFFFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E45980", Offset = "0x7E44380", VA = "0x187E45980")]
	public object PGEPBAPICDN(NativeArray<byte> AJHCLHGHINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7E44CD0", Offset = "0x7E436D0", VA = "0x187E44CD0")]
	public int NGAMGKHDEEG(HCCHCCGILAH JEMDJIEKJFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7E43210", Offset = "0x7E41C10", VA = "0x187E43210")]
	public bool IPNAMOAAKJD(byte FDDOIFDLLNO, object AHJCOCMFHID, AIJLKOBFKFM CMJDPJIOEOH, JOJLAKAOABL PPFPKPFAHFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7E41CD0", Offset = "0x7E406D0", VA = "0x187E41CD0")]
	public bool CFICCIJBGBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E45720", Offset = "0x7E44120", VA = "0x187E45720")]
	internal bool PACDKAGAECL([In] HLLAMGAIAAA APCCIGPAGFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E41670", Offset = "0x7E40070", VA = "0x187E41670")]
	internal bool CBJJGGLGFHP([In] MOMALLCJLEE NIAPBNPEIPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E43EA0", Offset = "0x7E428A0", VA = "0x187E43EA0")]
	public void ONKNBKABNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E43EA0", Offset = "0x7E428A0", VA = "0x187E43EA0")]
	public void KJDHDFALAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E45310", Offset = "0x7E43D10", VA = "0x187E45310")]
	private void OELFMOFNKDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E44EC0", Offset = "0x7E438C0", VA = "0x187E44EC0")]
	private void NKMEMALONDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7E42D30", Offset = "0x7E41730", VA = "0x187E42D30")]
	private void IDAABIJDDDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E440A0", Offset = "0x7E42AA0", VA = "0x187E440A0")]
	private void LOEPJAHIOGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7E42FB0", Offset = "0x7E419B0", VA = "0x187E42FB0")]
	private void IJDPEJONFCH(ulong FODHBPMMFKJ, FastBufferReader MJLDDLKFLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3B23F90", Offset = "0x3B22990", VA = "0x183B23F90")]
	private void DNJKEFJJLOL<T>(JNLKMKOKKEO FDDOIFDLLNO, FastBufferReader MJLDDLKFLAH) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7E44B80", Offset = "0x7E43580", VA = "0x187E44B80")]
	private void NCECGADEAPG(byte FDDOIFDLLNO, int GAMOJFHOMGC, object HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7E455E0", Offset = "0x7E43FE0", VA = "0x187E455E0")]
	private void OLNNGOPMAHP(ulong FODHBPMMFKJ, FastBufferReader MJLDDLKFLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7E44410", Offset = "0x7E42E10", VA = "0x187E44410")]
	private void MCIEPHAIFLC(CCGKKCKMKIF IPADIJEFNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7E42290", Offset = "0x7E40C90", VA = "0x187E42290")]
	private void FIHAACDLCNB(CCGKKCKMKIF IPADIJEFNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7E449F0", Offset = "0x7E433F0", VA = "0x187E449F0")]
	private void MOGPBHPICII(CCGKKCKMKIF IPADIJEFNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7E43EB0", Offset = "0x7E428B0", VA = "0x187E43EB0")]
	private void KJMPIKGEMOE(CCGKKCKMKIF IPADIJEFNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E42920", Offset = "0x7E41320", VA = "0x187E42920")]
	private void GGAGHJGNNJP(CCGKKCKMKIF IPADIJEFNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7E442F0", Offset = "0x7E42CF0", VA = "0x187E442F0")]
	private void MADAPJOMDMK(CCGKKCKMKIF IPADIJEFNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7E45490", Offset = "0x7E43E90", VA = "0x187E45490")]
	private void OLNNGOPMAHP(CCGKKCKMKIF IPADIJEFNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7E43D20", Offset = "0x7E42720", VA = "0x187E43D20")]
	private void JNDPOGPGDHH(ulong KKNDHFCJJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7E42EC0", Offset = "0x7E418C0", VA = "0x187E42EC0")]
	private void IHOKJHDFEIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7E418A0", Offset = "0x7E402A0", VA = "0x187E418A0")]
	private void CDPMHIPKMNJ(JBJFMFIIGLG ANDFNJEOMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7E41660", Offset = "0x7E40060", VA = "0x187E41660")]
	[CompilerGenerated]
	private void BLCBGDGCJLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BHBLLAPJCAP : GBDECDHLMJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LNPCCBKFFLK NJDAOHPINIG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static string EGEMLGEHLGK;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static Func<string, string> JGLNHDAOBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int FONADFJOOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private string GAANMJIJIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private ObscuredInt IPENFAPNBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool? JJICNGBGLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string BFLOGPICIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private ulong FNAKNBMBFLD;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int LPCINLOBNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool MCGFNEPBDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA99A60", Offset = "0xA98460", VA = "0x180A99A60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xDA7C20", Offset = "0xDA6620", VA = "0x180DA7C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool KLPDKNJILJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F580", Offset = "0x7E3DF80", VA = "0x187E3F580", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Dictionary<object, object> BOCMFHPFEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string PKOLLIDDIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F1B0", Offset = "0x7E3DBB0", VA = "0x187E3F1B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int IPMGELGFNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F060", Offset = "0x7E3DA60", VA = "0x187E3F060", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KCGLDMLNKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool COCNOAMDIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F6C0", Offset = "0x7E3E0C0", VA = "0x187E3F6C0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string KDKMKLIAKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F0B0", Offset = "0x7E3DAB0", VA = "0x187E3F0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string OAHKIDPJCFG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F150", Offset = "0x7E3DB50", VA = "0x187E3F150", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool PJNLLBPNAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public object KDDHNAFOIPO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA10560", Offset = "0xA0EF60", VA = "0x180A10560", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	internal ulong PILEHGNMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA10550", Offset = "0xA0EF50", VA = "0x180A10550")]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F780", Offset = "0x7E3E180", VA = "0x187E3F780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F900", Offset = "0x7E3E300", VA = "0x187E3F900")]
	internal BHBLLAPJCAP(LNPCCBKFFLK EACNBNHBDKI, bool FMAAHCDKFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F7A0", Offset = "0x7E3E1A0", VA = "0x187E3F7A0")]
	internal BHBLLAPJCAP(LNPCCBKFFLK EACNBNHBDKI, bool FMAAHCDKFEH, ulong KKNDHFCJJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F7E0", Offset = "0x7E3E1E0", VA = "0x187E3F7E0")]
	internal BHBLLAPJCAP(LNPCCBKFFLK EACNBNHBDKI, bool FMAAHCDKFEH, [In] HLLAMGAIAAA EDOOHKIDPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F610", Offset = "0x7E3E010", VA = "0x187E3F610", Slot = "16")]
	public bool MJDGBFNFDAD(Dictionary<object, object> JGKPIFCIJGJ, [Optional] Dictionary<object, object> BMBMMGFJMHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F2A0", Offset = "0x7E3DCA0", VA = "0x187E3F2A0")]
	internal void JELPPGDHGPA([In] HLLAMGAIAAA APCCIGPAGFE, bool HKADPOLPBGK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MIDDGOMNHNB : LPHAJBGNAJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private LNPCCBKFFLK NJDAOHPINIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Dictionary<object, object> CBFLIMDLHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal Dictionary<int, BHBLLAPJCAP> OMJEKBDPOBH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string HMKINKIIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7E46180", Offset = "0x7E44B80", VA = "0x187E46180", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public byte AADKJDGOLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7E467F0", Offset = "0x7E451F0", VA = "0x187E467F0", Slot = "5")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool FGHNFNIBNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Dictionary<object, object> BOCMFHPFEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public BHBLLAPJCAP[] BNAHJMJNPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public BHBLLAPJCAP[] BDDALNBKNIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA14650", Offset = "0xA13050", VA = "0x180A14650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public BHBLLAPJCAP[] KNOOOGFBHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA10D40", Offset = "0xA0F740", VA = "0x180A10D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public BHBLLAPJCAP[] KBMFMDDNBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7D0", Offset = "0xA091D0", VA = "0x180A0A7D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KNNPDJPHNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xF015A0", Offset = "0xEFFFA0", VA = "0x180F015A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xF029E0", Offset = "0xF013E0", VA = "0x180F029E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7E46EA0", Offset = "0x7E458A0", VA = "0x187E46EA0")]
	public MIDDGOMNHNB(LNPCCBKFFLK EACNBNHBDKI, [In] MOMALLCJLEE NIAPBNPEIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7E46340", Offset = "0x7E44D40", VA = "0x187E46340", Slot = "9")]
	public bool ELHBNFEDFDA(int KHNIMGKFPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7E46C50", Offset = "0x7E45650", VA = "0x187E46C50", Slot = "8")]
	public bool MJDGBFNFDAD(Dictionary<object, object> JGKPIFCIJGJ, [Optional] Dictionary<object, object> ECLKOAAEDOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E46CE0", Offset = "0x7E456E0", VA = "0x187E46CE0")]
	internal bool MLKIFAKPGFK([In] HLLAMGAIAAA APCCIGPAGFE, bool OCNMJOOCLHJ, [Out] BHBLLAPJCAP KPIDJKLDGJJ, bool HKADPOLPBGK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7E461B0", Offset = "0x7E44BB0", VA = "0x187E461B0")]
	internal void AKJNFFEDMAE(ulong KKNDHFCJJOK, [Out] BHBLLAPJCAP KPIDJKLDGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7E463A0", Offset = "0x7E44DA0", VA = "0x187E463A0")]
	internal void GLLBEELLEFC([In] MOMALLCJLEE NIAPBNPEIPM, bool HKADPOLPBGK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7E46840", Offset = "0x7E45240", VA = "0x187E46840")]
	private void MAODEIOIMOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KDLHHPEKMEL : EFOPLKHMDPM, ICKNPKBJODA, KPOIGOFACJG, PEKPECOOHHK, AHIDOPECKNN, OHJGNBHMELG, OJFODEFOOCG, AHDBNGNAHKJ, AIMJAGPELFN, FCOIKHLMBEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private LNPCCBKFFLK NJDAOHPINIG;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int IKIMEPANDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7E40980", Offset = "0x7E3F380", VA = "0x187E40980", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int FACIFGDMKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int NOHLPIGHFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7E40AA0", Offset = "0x7E3F4A0", VA = "0x187E40AA0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int BAPDJMFHFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7E41110", Offset = "0x7E3FB10", VA = "0x187E41110", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IEEGFDDGABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xC92820", Offset = "0xC91220", VA = "0x180C92820", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DKNMPAOCGIA NCICNNDBHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7E40200", Offset = "0x7E3EC00", VA = "0x187E40200", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public double MPFAODOCFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7E41320", Offset = "0x7E3FD20", VA = "0x187E41320", Slot = "36")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int DAMMFFLKPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7E404A0", Offset = "0x7E3EEA0", VA = "0x187E404A0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool OADECHMJMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6B755D0", Offset = "0x6B73FD0", VA = "0x186B755D0", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool JCKDJLBFMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7E40840", Offset = "0x7E3F240", VA = "0x187E40840", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool OBHIDFLPHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7E40840", Offset = "0x7E3F240", VA = "0x187E40840", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool PFAKPFFMJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1140FB0", Offset = "0x113F9B0", VA = "0x181140FB0", Slot = "46")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1140FD0", Offset = "0x113F9D0", VA = "0x181140FD0", Slot = "47")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool OFFLGANPGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool BJLEFKIJJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7E40A80", Offset = "0x7E3F480", VA = "0x187E40A80", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public object JLFMOAFFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA10510", Offset = "0xA0EF10", VA = "0x180A10510", Slot = "50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GBDECDHLMJN IGOAGANFOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7E40820", Offset = "0x7E3F220", VA = "0x187E40820", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int LDFEKHOEPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7E40F30", Offset = "0x7E3F930", VA = "0x187E40F30", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int PMIODMHHDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7E40D90", Offset = "0x7E3F790", VA = "0x187E40D90", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public GBDECDHLMJN JGEBLPFAMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7E40250", Offset = "0x7E3EC50", VA = "0x187E40250", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool AEEFIAPJAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7E402C0", Offset = "0x7E3ECC0", VA = "0x187E402C0", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int AADKJDGOLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7E40A00", Offset = "0x7E3F400", VA = "0x187E40A00", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string EGEMLGEHLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7E40080", Offset = "0x7E3EA80", VA = "0x187E40080", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Func<string, string> JGLNHDAOBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7E40E30", Offset = "0x7E3F830", VA = "0x187E40E30", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public KBKKLBBPBEC MOFIOOKNECE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7E3FD40", Offset = "0x7E3E740", VA = "0x187E3FD40", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override bool BACHOHNPMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7E401D0", Offset = "0x7E3EBD0", VA = "0x187E401D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7E40500", Offset = "0x7E3EF00", VA = "0x187E40500", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override float ACAIPJBKHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA25A60", Offset = "0xA24460", VA = "0x180A25A60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA35F70", Offset = "0xA34970", VA = "0x180A35F70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override ABEGIIDNPGF ILFAKFCKEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool EEAHGIBDGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string HKPECCALMPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E40520", Offset = "0x7E3EF20", VA = "0x187E40520", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public long DOJFFEMMFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7E40C60", Offset = "0x7E3F660", VA = "0x187E40C60", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public long PNNOOIAJLNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7E40870", Offset = "0x7E3F270", VA = "0x187E40870", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<ABEGIIDNPGF, ABEGIIDNPGF> MOBOBBOFMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E41130", Offset = "0x7E3FB30", VA = "0x187E41130", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7E413D0", Offset = "0x7E3FDD0", VA = "0x187E413D0", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<HCCHCCGILAH> PKPBOODOBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7E41230", Offset = "0x7E3FC30", VA = "0x187E41230", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E3FE00", Offset = "0x7E3E800", VA = "0x187E3FE00", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<GBDECDHLMJN> JIDLHFGGFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7E3FFD0", Offset = "0x7E3E9D0", VA = "0x187E3FFD0", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7E40E80", Offset = "0x7E3F880", VA = "0x187E40E80", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7E40BD0", Offset = "0x7E3F5D0", VA = "0x187E40BD0")]
	[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
	internal static void JGOIPALGEOO(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7E41480", Offset = "0x7E3FE80", VA = "0x187E41480")]
	[RecRoom.DataLayer.Attributes.Preserve]
	public KDLHHPEKMEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E40C40", Offset = "0x7E3F640", VA = "0x187E40C40", Slot = "21")]
	public void JLLDDLJJMNC(List<object> IBKFNAMHILN, int OBKGKEGIECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E40B80", Offset = "0x7E3F580", VA = "0x187E40B80", Slot = "23")]
	public void JBPNKDNJAGI(IDictionary<object, object> COGBEMJPNIC, int BJBHFAMODGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FBF0", Offset = "0x7E3E5F0", VA = "0x187E3FBF0", Slot = "27")]
	public void ADPFJOBFELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7E40F90", Offset = "0x7E3F990", VA = "0x187E40F90", Slot = "56")]
	public bool NAHJLKIGCKH(object LKNPPGBPPJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7E41370", Offset = "0x7E3FD70", VA = "0x187E41370", Slot = "29")]
	public object PGEPBAPICDN(NativeArray<byte> HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7E40CC0", Offset = "0x7E3F6C0", VA = "0x187E40CC0", Slot = "55")]
	public void KJDHDFALAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7E40BB0", Offset = "0x7E3F5B0", VA = "0x187E40BB0", Slot = "22")]
	public void JFJJPDFFGCJ(int BLEDCECONDJ, object JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E403C0", Offset = "0x7E3EDC0", VA = "0x187E403C0", Slot = "83")]
	public GBDECDHLMJN DPMEAONPLEO(int LIEFHLCIOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FD90", Offset = "0x7E3E790", VA = "0x187E3FD90", Slot = "82")]
	public GBDECDHLMJN AJIEBPGPDHN(int KJCCMAJJDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7E40720", Offset = "0x7E3F120", VA = "0x187E40720", Slot = "84")]
	public GBDECDHLMJN FNCKIJJKJPD(int KJCCMAJJDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7E411F0", Offset = "0x7E3FBF0", VA = "0x187E411F0", Slot = "18")]
	public bool OBKGLJFLNFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E408F0", Offset = "0x7E3F2F0", VA = "0x187E408F0", Slot = "85")]
	public IReadOnlyList<GBDECDHLMJN> HACFFNGHAME(bool JPLKHIANGNK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E40CE0", Offset = "0x7E3F6E0", VA = "0x187E40CE0", Slot = "86")]
	public IReadOnlyList<GBDECDHLMJN> KKHOBEAFHMC(bool JPLKHIANGNK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E40180", Offset = "0x7E3EB80", VA = "0x187E40180", Slot = "54")]
	public bool CFICCIJBGBJ(string CJNHPDLFGCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E412F0", Offset = "0x7E3FCF0", VA = "0x187E412F0", Slot = "53")]
	public bool ONKNBKABNMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E40C70", Offset = "0x7E3F670", VA = "0x187E40C70", Slot = "20")]
	public void JONJLLKONMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E40B50", Offset = "0x7E3F550", VA = "0x187E40B50", Slot = "70")]
	public bool IPNAMOAAKJD(byte FDDOIFDLLNO, object AHJCOCMFHID, AIJLKOBFKFM CMJDPJIOEOH, JOJLAKAOABL PPFPKPFAHFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E413A0", Offset = "0x7E3FDA0", VA = "0x187E413A0", Slot = "28")]
	public void PGPOMLMDCHO(object OJDHMKOBKLD, NativeList<byte> HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E410E0", Offset = "0x7E3FAE0", VA = "0x187E410E0", Slot = "30")]
	public int NGAMGKHDEEG(HCCHCCGILAH JEMDJIEKJFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "45")]
	public void LFAJILDNFDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FEB0", Offset = "0x7E3E8B0", VA = "0x187E3FEB0", Slot = "87")]
	public bool BEBNMLALAHL(GBDECDHLMJN MAMJPGLPJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "35")]
	public void LBFJIKCEOHK(string KMCEBDFLJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7E40890", Offset = "0x7E3F290", VA = "0x187E40890", Slot = "17")]
	public float GOPLPKEJKBF(bool KEEOABDKAML, int EILJCFEDMAA = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7E409D0", Offset = "0x7E3F3D0", VA = "0x187E409D0", Slot = "8")]
	public override void HFEHJDDGKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7E40610", Offset = "0x7E3F010", VA = "0x187E40610", Slot = "81")]
	public void FLGHPFFDPPM(string GBCFHNGPBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7E40980", Offset = "0x7E3F380", VA = "0x187E40980", Slot = "95")]
	public int JFPILEKEGBD()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7E41360", Offset = "0x7E3FD60", VA = "0x187E41360", Slot = "11")]
	private void OONNHLLCGOH(Action PCDAHJCDHHF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7E40CA0", Offset = "0x7E3F6A0", VA = "0x187E40CA0", Slot = "12")]
	private void KIKBPLFKPMN(Action PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7E40D70", Offset = "0x7E3F770", VA = "0x187E40D70", Slot = "25")]
	private void LMHKAEHNOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7E40CB0", Offset = "0x7E3F6B0", VA = "0x187E40CB0", Slot = "26")]
	private void KINLFCDPKKE()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7E40D80", Offset = "0x7E3F780", VA = "0x187E40D80", Slot = "31")]
	private void LMNCLGCCIKG(float PCDAHJCDHHF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FDF0", Offset = "0x7E3E7F0", VA = "0x187E3FDF0", Slot = "32")]
	private void APKOABMNOEP(float PCDAHJCDHHF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7E410D0", Offset = "0x7E3FAD0", VA = "0x187E410D0", Slot = "57")]
	private void NEECMOKMOCP(Action<bool> PCDAHJCDHHF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7E40A60", Offset = "0x7E3F460", VA = "0x187E40A60", Slot = "58")]
	private void HPGLCODMDCD(Action<bool> PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7E412E0", Offset = "0x7E3FCE0", VA = "0x187E412E0", Slot = "59")]
	private void OMJJICFHIKO(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7E40880", Offset = "0x7E3F280", VA = "0x187E40880", Slot = "60")]
	private void GMMPIHNHMAL(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7E411E0", Offset = "0x7E3FBE0", VA = "0x187E411E0", Slot = "61")]
	private void NPMJIKDPPOK(object BECBHDDLOHA, bool EIOLKALMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7E401E0", Offset = "0x7E3EBE0", VA = "0x187E401E0", Slot = "62")]
	private IDisposable CPMJPBLOJCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FD30", Offset = "0x7E3E730", VA = "0x187E3FD30", Slot = "63")]
	private bool AEBCHHMACOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7E40A70", Offset = "0x7E3F470", VA = "0x187E40A70", Slot = "64")]
	private void ICKMAEOGDCG(StringBuilder MLDFCHHLDNN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7E40B40", Offset = "0x7E3F540", VA = "0x187E40B40", Slot = "66")]
	private void IGJFBDGJCOO(Action<string, long> PCDAHJCDHHF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7E41100", Offset = "0x7E3FB00", VA = "0x187E41100", Slot = "67")]
	private void NGPOLOKCGNH(Action<string, long> PCDAHJCDHHF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7E40BA0", Offset = "0x7E3F5A0", VA = "0x187E40BA0", Slot = "88")]
	private void JENHCAMCJHG(Action PCDAHJCDHHF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7E401F0", Offset = "0x7E3EBF0", VA = "0x187E401F0", Slot = "89")]
	private void DEHDEMOIECN(Action PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7E404F0", Offset = "0x7E3EEF0", VA = "0x187E404F0", Slot = "90")]
	private void FBGMNEBACJN()
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
		public NfgoCommsNetwork EHJLNLEKJAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7E3F9E0", Offset = "0x7E3E3E0", VA = "0x187E3F9E0")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7E3FBA0", Offset = "0x7E3E5A0", VA = "0x187E3FBA0")]
		private void CFEGMIJPELL(NetworkManager CDCKGPOILHD, bool LDCEDBELOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E47040", Offset = "0x7E45A40", VA = "0x187E47040")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public NetworkManagerBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MDPKBANHPCH
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool CPLKLNMJIAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA97A50", Offset = "0xA96450", VA = "0x180A97A50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA979E0", Offset = "0xA963E0", VA = "0x180A979E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public NetworkManager IELDMHOMBAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public NetworkManager DAJNFCAOMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<NetworkManager, bool> CFEGMIJPELL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7E45F40", Offset = "0x7E44940", VA = "0x187E45F40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7E45FF0", Offset = "0x7E449F0", VA = "0x187E45FF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6C3A100", Offset = "0x6C38B00", VA = "0x186C3A100")]
	[RecRoom.NoEngine.Common.Preserve]
	public MDPKBANHPCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7E46110", Offset = "0x7E44B10", VA = "0x187E46110")]
	[CGLGNCLDKHN.CKJOAALDIOP]
	public static void IBILDGNPFFH(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7E460A0", Offset = "0x7E44AA0", VA = "0x187E460A0")]
	public void ECBKDGHPLOC(NetworkManager CDCKGPOILHD, bool LDCEDBELOIC)
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
