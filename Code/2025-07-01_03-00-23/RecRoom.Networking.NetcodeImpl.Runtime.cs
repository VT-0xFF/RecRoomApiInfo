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
		[Cpp2IlInjected.Address(RVA = "0x80A80C0", Offset = "0x80A66C0", VA = "0x1880A80C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NOBDBGOECGC : EBBJHOMFMHH, HCMJLICOKOA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DefaultMember("Item")]
	private class EKMODAHNHII : FNFHFOLBALO
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object FCKKEJIGIAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x80A2900", Offset = "0x80A0F00", VA = "0x1880A2900", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public byte GHAPNAILIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAC2F90", Offset = "0xAC1590", VA = "0x180AC2F90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAC2F80", Offset = "0xAC1580", VA = "0x180AC2F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int BPEKBDECLLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA5D70", Offset = "0xAA4370", VA = "0x180AA5D70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAD8120", Offset = "0xAD6720", VA = "0x180AD8120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object MCBFLDFKJDI
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7991CB0", Offset = "0x79902B0", VA = "0x187991CB0")]
		public EKMODAHNHII(byte FHBJJABHKPG, int NDLIFLFKGJD, object ACJFHCNBBBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x80A2950", Offset = "0x80A0F50", VA = "0x1880A2950", Slot = "8")]
		public bool OMCPIMBCGII(byte BLIBAMJKLIA, [Out] object KKGBKLFKCPO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NetworkManager HKAACDNDKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private JDLMMOCIBOE LDBLBDIALEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stopwatch DPNMFEMJKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int GEBGBKPHBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Deque<EKMODAHNHII> KLGCFGPCNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Deque<Action> CCFDNLPHOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IOLCEGGDIDP HPMPELEMLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private AHPFNLKMDGC IHPPOGHEDKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NetworkManager GBIDCCDELJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x80A5520", Offset = "0x80A3B20", VA = "0x1880A5520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JDLMMOCIBOE MEFDKDCPCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0", Slot = "4")]
		get
		{
			return default(JDLMMOCIBOE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x80A4960", Offset = "0x80A2F60", VA = "0x1880A4960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BFOEENIPBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IOLCEGGDIDP BINJEDHCNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AHPFNLKMDGC CEDFJNCLFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private GEAJKOACMNI ILEGBFCNJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool HPIFIPBBDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80A5FF0", Offset = "0x80A45F0", VA = "0x1880A5FF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool ENFIEEAABJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80A3E70", Offset = "0x80A2470", VA = "0x1880A3E70", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool EGDAFFCAGKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80A3E70", Offset = "0x80A2470", VA = "0x1880A3E70", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool JOBJMFOCFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80A3E70", Offset = "0x80A2470", VA = "0x1880A3E70", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Exception HOHEHHLOIDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA449C0", Offset = "0xA42FC0", VA = "0x180A449C0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GIMPNKBFHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool EDHKGLOLAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80A3800", Offset = "0x80A1E00", VA = "0x1880A3800", Slot = "17")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80A79E0", Offset = "0x80A5FE0", VA = "0x1880A79E0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool NLGNHAFLMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCB76A0", Offset = "0xCB5CA0", VA = "0x180CB76A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCB6DE0", Offset = "0xCB53E0", VA = "0x180CB6DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double EDNAKNOMGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80A5650", Offset = "0x80A3C50", VA = "0x1880A5650")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double JDHCNOPMIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80A6000", Offset = "0x80A4600", VA = "0x1880A6000")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HLEJGGFHNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80A6CD0", Offset = "0x80A52D0", VA = "0x1880A6CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string HPPDDEICGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80A5440", Offset = "0x80A3A40", VA = "0x1880A5440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int BBDDHGLPNJL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x80A7C40", Offset = "0x80A6240", VA = "0x1880A7C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NMMDGPOLHAJ LLBBEPMKJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x80A5F70", Offset = "0x80A4570", VA = "0x1880A5F70", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string, long> DMGJFFIDKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x80A3960", Offset = "0x80A1F60", VA = "0x1880A3960", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x80A7930", Offset = "0x80A5F30", VA = "0x1880A7930", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<JDLMMOCIBOE, JDLMMOCIBOE> ONEDGMLCCCC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x80A4CD0", Offset = "0x80A32D0", VA = "0x1880A4CD0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80A5170", Offset = "0x80A3770", VA = "0x1880A5170", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x80A7CD0", Offset = "0x80A62D0", VA = "0x1880A7CD0")]
	public NOBDBGOECGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x80A3830", Offset = "0x80A1E30", VA = "0x1880A3830")]
	public bool AJCHJADPAEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x80A36F0", Offset = "0x80A1CF0", VA = "0x1880A36F0")]
	public bool AFPCFFFMDLB(KNOJHPOMDED BIMDGEMNEOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x80A5FC0", Offset = "0x80A45C0", VA = "0x1880A5FC0")]
	public bool KHKHNOLHEDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x80A6410", Offset = "0x80A4A10", VA = "0x1880A6410")]
	public void LKBPIELOIFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x80A3EB0", Offset = "0x80A24B0", VA = "0x1880A3EB0")]
	public void DFOJDMPKAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x80A3C60", Offset = "0x80A2260", VA = "0x1880A3C60")]
	public void BPPHLMNKIBG(List<object> BGGFBGFNIID, int IGHNHCKLCCN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x80A71E0", Offset = "0x80A57E0", VA = "0x1880A71E0")]
	public void MKLPFCMNKOO(int MEOLDLEBKEJ, object FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x80A5220", Offset = "0x80A3820", VA = "0x1880A5220")]
	public void IFBOHDBNLNK(IDictionary<object, object> BKADBAJOKKO, int HKLGEDHKAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x80A6030", Offset = "0x80A4630", VA = "0x1880A6030")]
	public void LGGJGPOGIBH(object ODCICEDDLMB, NativeList<byte> IAFIKCDBMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x80A4870", Offset = "0x80A2E70", VA = "0x1880A4870")]
	public object FJJOMODMCLM(NativeArray<byte> LFMKIINCPNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80A7740", Offset = "0x80A5D40", VA = "0x1880A7740")]
	public int NMKNOHKPMGG(FNFHFOLBALO FLDOIECLDLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x80A59B0", Offset = "0x80A3FB0", VA = "0x1880A59B0")]
	public bool JFEGKCBMLGB(byte FHBJJABHKPG, object HBPOJHGLIJD, JCLKAOOIHID JCIFHCCPGEJ, GMBKBHGPJMD PFJLCJLCCNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x80A6D20", Offset = "0x80A5320", VA = "0x1880A6D20")]
	public bool MHMBKEEMFBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x80A7A10", Offset = "0x80A6010", VA = "0x1880A7A10")]
	internal bool PMBLNBDFONP([In] KNDNLJHIGDB NHFKNHHFAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80A34C0", Offset = "0x80A1AC0", VA = "0x1880A34C0")]
	internal bool AEGJGFIOGGE([In] LMCDPNHGKJA MODBIBDJKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x80A7480", Offset = "0x80A5A80", VA = "0x1880A7480")]
	public void PJHCEGLIFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80A7480", Offset = "0x80A5A80", VA = "0x1880A7480")]
	public void MPKFLLBBFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x80A4990", Offset = "0x80A2F90", VA = "0x1880A4990")]
	private void GCMGDKIJJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x80A3EE0", Offset = "0x80A24E0", VA = "0x1880A3EE0")]
	private void DHPBFBJHKAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x80A4720", Offset = "0x80A2D20", VA = "0x1880A4720")]
	private void EPEHHJKFEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x80A3A10", Offset = "0x80A2010", VA = "0x1880A3A10")]
	private void BHJJBECLDPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x80A4F10", Offset = "0x80A3510", VA = "0x1880A4F10")]
	private void IDKBBPMIADP(ulong KPAEEAPNPHC, FastBufferReader JMFDJJMEGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0D80", Offset = "0x3CBF380", VA = "0x183CC0D80")]
	private void IGHGCAOFHCK<T>(NEKBOBLBKNP FHBJJABHKPG, FastBufferReader JMFDJJMEGCJ) where T : INetworkSerializable, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x80A62C0", Offset = "0x80A48C0", VA = "0x1880A62C0")]
	private void LJLPLBNCKKJ(byte FHBJJABHKPG, int NDLIFLFKGJD, object ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x80A58A0", Offset = "0x80A3EA0", VA = "0x1880A58A0")]
	private void JEGPFHLJKGB(ulong KPAEEAPNPHC, FastBufferReader JMFDJJMEGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x80A4200", Offset = "0x80A2800", VA = "0x1880A4200")]
	private void DJNNJHDGMHD(EKMODAHNHII OPFDLFBBADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x80A6440", Offset = "0x80A4A40", VA = "0x1880A6440")]
	private void LKLFHOBKFCI(EKMODAHNHII OPFDLFBBADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x80A4D80", Offset = "0x80A3380", VA = "0x1880A4D80")]
	private void IBPPBBLJOLP(EKMODAHNHII OPFDLFBBADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80A4B10", Offset = "0x80A3110", VA = "0x1880A4B10")]
	private void GGDAFOADHFD(EKMODAHNHII OPFDLFBBADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80A7490", Offset = "0x80A5A90", VA = "0x1880A7490")]
	private void NMKHGJIJMBI(EKMODAHNHII OPFDLFBBADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80A5E50", Offset = "0x80A4450", VA = "0x1880A5E50")]
	private void JMGBHIMJLDN(EKMODAHNHII OPFDLFBBADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80A5750", Offset = "0x80A3D50", VA = "0x1880A5750")]
	private void JEGPFHLJKGB(EKMODAHNHII OPFDLFBBADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x80A5680", Offset = "0x80A3C80", VA = "0x1880A5680")]
	private void INNKKOOAHPB(ulong AIEJLCEJPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x80A5D60", Offset = "0x80A4360", VA = "0x1880A5D60")]
	private void JFJNBNPKBGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x80A6890", Offset = "0x80A4E90", VA = "0x1880A6890")]
	private void LLIIBJCDKON(OAJNBKMEPPG DBEFHDJNDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x80A3EA0", Offset = "0x80A24A0", VA = "0x1880A3EA0")]
	[CompilerGenerated]
	private void CPLCGHIGNCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IOLCEGGDIDP : KNOJHPOMDED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private NOBDBGOECGC DFADLNABGKM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static string ECACLEPEAPL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static Func<string, string> HBCEKCNKJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int DAAJDFFPMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private string MFIDEMJABPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private ObscuredInt GHLNGFCIJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool? EAKDLGKLLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string HFDDKCFEDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private ulong NEDAHJMGGFE;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int JODAMNFOKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool DJNFELGABCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAA58D0", Offset = "0xAA3ED0", VA = "0x180AA58D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xDF4C20", Offset = "0xDF3220", VA = "0x180DF4C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool MMGEEPCOMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x80A2C60", Offset = "0x80A1260", VA = "0x1880A2C60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Dictionary<object, object> ODFEDLEMLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string LFCEHEBACOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x80A2A60", Offset = "0x80A1060", VA = "0x1880A2A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int JFHNCMMBIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x80A2FD0", Offset = "0x80A15D0", VA = "0x1880A2FD0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NEDAMLLLAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool HAHAOCNNAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x80A3020", Offset = "0x80A1620", VA = "0x1880A3020", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string CBAKGCGHJCH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x80A29A0", Offset = "0x80A0FA0", VA = "0x1880A29A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string GIPFKHBCMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x80A2B50", Offset = "0x80A1150", VA = "0x1880A2B50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool FMKNLPKKBPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public object IIMBFFLIACE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA449C0", Offset = "0xA42FC0", VA = "0x180A449C0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	internal ulong EAPDGHFBDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA44970", Offset = "0xA42F70", VA = "0x180A44970")]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x80A2A40", Offset = "0x80A1040", VA = "0x1880A2A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x80A30E0", Offset = "0x80A16E0", VA = "0x1880A30E0")]
	internal IOLCEGGDIDP(NOBDBGOECGC MMBEHPFPKIL, bool BOFMDAHMCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80A3120", Offset = "0x80A1720", VA = "0x1880A3120")]
	internal IOLCEGGDIDP(NOBDBGOECGC MMBEHPFPKIL, bool BOFMDAHMCCB, ulong AIEJLCEJPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x80A3160", Offset = "0x80A1760", VA = "0x1880A3160")]
	internal IOLCEGGDIDP(NOBDBGOECGC MMBEHPFPKIL, bool BOFMDAHMCCB, [In] KNDNLJHIGDB PBBPCJGOILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x80A2BB0", Offset = "0x80A11B0", VA = "0x1880A2BB0", Slot = "16")]
	public bool HDEJHLHFBKF(Dictionary<object, object> JPAEANMGHOB, [Optional] Dictionary<object, object> IDMDONAOMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x80A2CF0", Offset = "0x80A12F0", VA = "0x1880A2CF0")]
	internal void JHKHPFDJGJE([In] KNDNLJHIGDB NHFKNHHFAPA, bool PFKIHJCOKCK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AHPFNLKMDGC : GEAJKOACMNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private NOBDBGOECGC DFADLNABGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Dictionary<object, object> JCJOKNMBBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal Dictionary<int, IOLCEGGDIDP> LDGPKKFNJNO;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x80A0520", Offset = "0x809EB20", VA = "0x1880A0520", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public byte DDDIPAHOJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x80A0080", Offset = "0x809E680", VA = "0x1880A0080", Slot = "5")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NCKKGDNCOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Dictionary<object, object> ODFEDLEMLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IOLCEGGDIDP[] JEBBPKIMPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IOLCEGGDIDP[] MMPBNDLBHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public IOLCEGGDIDP[] MGNBKDLHHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IOLCEGGDIDP[] ONKOPMFHJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KKNCPAKGPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xF2CD40", Offset = "0xF2B340", VA = "0x180F2CD40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xF2E900", Offset = "0xF2CF00", VA = "0x180F2E900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x80A0C20", Offset = "0x809F220", VA = "0x1880A0C20")]
	public AHPFNLKMDGC(NOBDBGOECGC MMBEHPFPKIL, [In] LMCDPNHGKJA MODBIBDJKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x80A05E0", Offset = "0x809EBE0", VA = "0x1880A05E0", Slot = "9")]
	public bool KPJKLGCMCNG(int HLIPPIOIAJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x80A0550", Offset = "0x809EB50", VA = "0x1880A0550", Slot = "8")]
	public bool HDEJHLHFBKF(Dictionary<object, object> JPAEANMGHOB, [Optional] Dictionary<object, object> HIBNDHJMJAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x809FEC0", Offset = "0x809E4C0", VA = "0x18809FEC0")]
	internal bool AALIKNDAGEL([In] KNDNLJHIGDB NHFKNHHFAPA, bool EJAGFHDPLDB, [Out] IOLCEGGDIDP OPOGJMFOAFI, bool PFKIHJCOKCK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x80A0A80", Offset = "0x809F080", VA = "0x1880A0A80")]
	internal void MFHLLGBJHJK(ulong AIEJLCEJPCJ, [Out] IOLCEGGDIDP OPOGJMFOAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x80A00D0", Offset = "0x809E6D0", VA = "0x1880A00D0")]
	internal void CNOBBKECFBK([In] LMCDPNHGKJA MODBIBDJKOA, bool PFKIHJCOKCK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x80A0640", Offset = "0x809EC40", VA = "0x1880A0640")]
	private void LIGDKOKAJJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class APJKNNJIHFP : JBPHOMDJPLN, KEDGPMDLKIM, DCHBINOFFJA, KNPOGEIDBBM, IJDNGFHAHCO, EJGGMPEHJPP, LMOOPOFGDGI, HCMJLICOKOA, AEFDOLMJEPG, AGIEIIGGMMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NOBDBGOECGC DFADLNABGKM;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int HLEJGGFHNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x80A1D60", Offset = "0x80A0360", VA = "0x1880A1D60", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int LOFJJMFCJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int HDEKMOFIOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x80A1CB0", Offset = "0x80A02B0", VA = "0x1880A1CB0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int BFOEENIPBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x80A1430", Offset = "0x809FA30", VA = "0x1880A1430", Slot = "24")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool NJKAGPPLGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xCB6DE0", Offset = "0xCB53E0", VA = "0x180CB6DE0", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ODINAKJMICB IAIEHNCGKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x80A1800", Offset = "0x809FE00", VA = "0x1880A1800", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public double EDNAKNOMGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x80A19D0", Offset = "0x809FFD0", VA = "0x1880A19D0", Slot = "36")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int CKBOIDCLDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x80A1870", Offset = "0x809FE70", VA = "0x1880A1870", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool DMJBKCLAMLK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6DC1430", Offset = "0x6DBFA30", VA = "0x186DC1430", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool ENFIEEAABJK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x80A12A0", Offset = "0x809F8A0", VA = "0x1880A12A0", Slot = "43")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool EGDAFFCAGKO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x80A12A0", Offset = "0x809F8A0", VA = "0x1880A12A0", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool IPOEEOLGBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x118DBF0", Offset = "0x118C1F0", VA = "0x18118DBF0", Slot = "46")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x118DC10", Offset = "0x118C210", VA = "0x18118DC10", Slot = "47")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool ANOLHMHILAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool HPIFIPBBDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x80A1BA0", Offset = "0x80A01A0", VA = "0x1880A1BA0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public object DDHBCMNJGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA44950", Offset = "0xA42F50", VA = "0x180A44950", Slot = "50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KNOJHPOMDED BINJEDHCNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x80A22B0", Offset = "0x80A08B0", VA = "0x1880A22B0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int DILHBJCAKJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x80A10F0", Offset = "0x809F6F0", VA = "0x1880A10F0", Slot = "74")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int DFNHGFBMNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x80A1E40", Offset = "0x80A0440", VA = "0x1880A1E40", Slot = "75")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public KNOJHPOMDED AOCMHBHLIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x80A1C40", Offset = "0x80A0240", VA = "0x1880A1C40", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool PHFOHDOOMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x80A1460", Offset = "0x809FA60", VA = "0x1880A1460", Slot = "77")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int DDDIPAHOJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x80A0FF0", Offset = "0x809F5F0", VA = "0x1880A0FF0", Slot = "78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string ECACLEPEAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x80A1FD0", Offset = "0x80A05D0", VA = "0x1880A1FD0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Func<string, string> HBCEKCNKJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x80A24C0", Offset = "0x80A0AC0", VA = "0x1880A24C0", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public NMMDGPOLHAJ LLBBEPMKJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x80A1B40", Offset = "0x80A0140", VA = "0x1880A1B40", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override bool NLGNHAFLMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x80A1580", Offset = "0x809FB80", VA = "0x1880A1580", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x80A10B0", Offset = "0x809F6B0", VA = "0x1880A10B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override float NHGPGEENMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA607C0", Offset = "0xA5EDC0", VA = "0x180A607C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA70BB0", Offset = "0xA6F1B0", VA = "0x180A70BB0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override EBBJHOMFMHH MIOMHIHFGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA50E50", Offset = "0xA4F450", VA = "0x180A50E50", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool HKMFIDMKGHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string HPPDDEICGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x80A18E0", Offset = "0x809FEE0", VA = "0x1880A18E0", Slot = "92")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public long KPAANMFHJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x80A1FC0", Offset = "0x80A05C0", VA = "0x1880A1FC0", Slot = "93")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public long GPPLFADADAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x80A1150", Offset = "0x809F750", VA = "0x1880A1150", Slot = "94")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<EBBJHOMFMHH, EBBJHOMFMHH> IJNMLNBNMLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x80A20E0", Offset = "0x80A06E0", VA = "0x1880A20E0", Slot = "39")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x80A15F0", Offset = "0x809FBF0", VA = "0x1880A15F0", Slot = "40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<FNFHFOLBALO> MFOONIBONDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x80A2560", Offset = "0x80A0B60", VA = "0x1880A2560", Slot = "68")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x80A22D0", Offset = "0x80A08D0", VA = "0x1880A22D0", Slot = "69")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<KNOJHPOMDED> IMDOMLKACCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x80A16A0", Offset = "0x809FCA0", VA = "0x1880A16A0", Slot = "71")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x80A1F00", Offset = "0x80A0500", VA = "0x1880A1F00", Slot = "72")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x80A1750", Offset = "0x809FD50", VA = "0x1880A1750")]
	[BNHIEDNKDNA.MLFEBCDGLFC.CIEDAEOKGHH]
	internal static void GLAOIPJFGAH(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x80A2670", Offset = "0x80A0C70", VA = "0x1880A2670")]
	[RecRoom.DataLayer.Attributes.Preserve]
	public APJKNNJIHFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x80A10D0", Offset = "0x809F6D0", VA = "0x1880A10D0", Slot = "21")]
	public void BPPHLMNKIBG(List<object> BGGFBGFNIID, int IGHNHCKLCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x80A18C0", Offset = "0x809FEC0", VA = "0x1880A18C0", Slot = "23")]
	public void IFBOHDBNLNK(IDictionary<object, object> BKADBAJOKKO, int HKLGEDHKAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x80A12E0", Offset = "0x809F8E0", VA = "0x1880A12E0", Slot = "27")]
	public void DGGPPDAAJIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x80A1160", Offset = "0x809F760", VA = "0x1880A1160", Slot = "56")]
	public bool CJEBNMGCBCJ(object HMGOEIDKCEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x80A1590", Offset = "0x809FB90", VA = "0x1880A1590", Slot = "29")]
	public object FJJOMODMCLM(NativeArray<byte> ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x80A1EE0", Offset = "0x80A04E0", VA = "0x1880A1EE0", Slot = "55")]
	public void MPKFLLBBFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x80A1E10", Offset = "0x80A0410", VA = "0x1880A1E10", Slot = "22")]
	public void MKLPFCMNKOO(int MEOLDLEBKEJ, object FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x80A1A20", Offset = "0x80A0020", VA = "0x1880A1A20", Slot = "83")]
	public KNOJHPOMDED JENFDGKHDBJ(int DKGJDLCFPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x80A2610", Offset = "0x80A0C10", VA = "0x1880A2610", Slot = "82")]
	public KNOJHPOMDED PNNMCBEJHIK(int LPDADLLGOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x80A21B0", Offset = "0x80A07B0", VA = "0x1880A21B0", Slot = "84")]
	public KNOJHPOMDED NOHGHGCIFNN(int LPDADLLGOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x80A17C0", Offset = "0x809FDC0", VA = "0x1880A17C0", Slot = "18")]
	public bool HAOJBLJEEEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x80A2430", Offset = "0x80A0A30", VA = "0x1880A2430", Slot = "85")]
	public IReadOnlyList<KNOJHPOMDED> PADCFKADHOA(bool ABPOGIAJPII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x80A2390", Offset = "0x80A0990", VA = "0x1880A2390", Slot = "86")]
	public IReadOnlyList<KNOJHPOMDED> OOHPNCCGIHE(bool ABPOGIAJPII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x80A1DB0", Offset = "0x80A03B0", VA = "0x1880A1DB0", Slot = "54")]
	public bool MHMBKEEMFBH(string HDKICABIBJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x80A2530", Offset = "0x80A0B30", VA = "0x1880A2530", Slot = "53")]
	public bool PJHCEGLIFDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x80A15C0", Offset = "0x809FBC0", VA = "0x1880A15C0", Slot = "20")]
	public void GCGDOKMJAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x80A1B00", Offset = "0x80A0100", VA = "0x1880A1B00", Slot = "70")]
	public bool JFEGKCBMLGB(byte FHBJJABHKPG, object HBPOJHGLIJD, JCLKAOOIHID JCIFHCCPGEJ, GMBKBHGPJMD PFJLCJLCCNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x80A1C00", Offset = "0x80A0200", VA = "0x1880A1C00", Slot = "28")]
	public void LGGJGPOGIBH(object ODCICEDDLMB, NativeList<byte> ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x80A2190", Offset = "0x80A0790", VA = "0x1880A2190", Slot = "30")]
	public int NMKNOHKPMGG(FNFHFOLBALO FLDOIECLDLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "45")]
	public void LCADLGCEDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x80A0DC0", Offset = "0x809F3C0", VA = "0x1880A0DC0", Slot = "87")]
	public bool AFPCFFFMDLB(KNOJHPOMDED IIEPGCMOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "35")]
	public void EIKKCOIILLB(string CODLGOOMDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x80A1050", Offset = "0x809F650", VA = "0x1880A1050", Slot = "17")]
	public float BAFMMMJMBJJ(bool MIEOHJCOAAH, int JMBJOMJBINP = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x80A1BD0", Offset = "0x80A01D0", VA = "0x1880A1BD0", Slot = "8")]
	public override void LEAKPCFBGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x80A0EE0", Offset = "0x809F4E0", VA = "0x1880A0EE0", Slot = "81")]
	public void AGIGLJJJDMJ(string IEDAJGLJHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x80A1D60", Offset = "0x80A0360", VA = "0x1880A1D60", Slot = "95")]
	public int PLDMHDHIBEO()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x80A2380", Offset = "0x80A0980", VA = "0x1880A2380", Slot = "11")]
	private void ODGLGEEIJOC(Action KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x80A1E30", Offset = "0x80A0430", VA = "0x1880A1E30", Slot = "12")]
	private void MMEMLPCPGFG(Action KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x80A1BC0", Offset = "0x80A01C0", VA = "0x1880A1BC0", Slot = "25")]
	private void KJJHDBFHOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x80A1860", Offset = "0x809FE60", VA = "0x1880A1860", Slot = "26")]
	private void HJNOCICGMHG()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x80A1FB0", Offset = "0x80A05B0", VA = "0x1880A1FB0", Slot = "31")]
	private void NBFHGELHJBP(float KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x80A1C30", Offset = "0x80A0230", VA = "0x1880A1C30", Slot = "32")]
	private void LHHJEOHMHKJ(float KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x80A1450", Offset = "0x809FA50", VA = "0x1880A1450", Slot = "57")]
	private void EFADJILADDH(Action<bool> KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x80A12D0", Offset = "0x809F8D0", VA = "0x1880A12D0", Slot = "58")]
	private void CKMALGFGPEJ(Action<bool> KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x80A1420", Offset = "0x809FA20", VA = "0x1880A1420", Slot = "59")]
	private void DLPJFNBFHJB(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x80A2420", Offset = "0x80A0A20", VA = "0x1880A2420", Slot = "60")]
	private void OOOOPJAPBLI(object DKFMAIJGPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x80A1B30", Offset = "0x80A0130", VA = "0x1880A1B30", Slot = "61")]
	private void JGOAPPEOPCP(object DKFMAIJGPFL, bool BNCAKEBPMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x80A1570", Offset = "0x809FB70", VA = "0x1880A1570", Slot = "62")]
	private IDisposable EODKPLDHJOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x80A1850", Offset = "0x809FE50", VA = "0x1880A1850", Slot = "63")]
	private bool HIDBMBHLPEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x80A1E00", Offset = "0x80A0400", VA = "0x1880A1E00", Slot = "64")]
	private void MKLDKCEHGGF(StringBuilder ALFEMNGJGJJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x80A2520", Offset = "0x80A0B20", VA = "0x1880A2520", Slot = "66")]
	private void PIMCDBGINIC(Action<string, long> KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x80A1B90", Offset = "0x80A0190", VA = "0x1880A1B90", Slot = "67")]
	private void JOGMPJNMBLM(Action<string, long> KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x80A1D50", Offset = "0x80A0350", VA = "0x1880A1D50", Slot = "88")]
	private void MHJLNMJAIJJ(Action KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x80A1560", Offset = "0x809FB60", VA = "0x1880A1560", Slot = "89")]
	private void EIJOLKDPADF(Action KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x80A1A10", Offset = "0x80A0010", VA = "0x1880A1A10", Slot = "90")]
	private void ILOFKMCNNFP()
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
		public NfgoCommsNetwork PEIIFHOODBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x80A26F0", Offset = "0x80A0CF0", VA = "0x1880A26F0")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x80A28B0", Offset = "0x80A0EB0", VA = "0x1880A28B0")]
		private void BCAAPBFDECJ(NetworkManager IPIKGHELDDC, bool DKLKEOKHPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x80A7F10", Offset = "0x80A6510", VA = "0x1880A7F10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public NetworkManagerBinder()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MMADOEJJNDO
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool LGJKLDJCOPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F90", Offset = "0xAC1590", VA = "0x180AC2F90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F80", Offset = "0xAC1580", VA = "0x180AC2F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public NetworkManager GBIDCCDELJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public NetworkManager JOOMCHPOGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<NetworkManager, bool> BCAAPBFDECJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x80A3280", Offset = "0x80A1880", VA = "0x1880A3280")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x80A3330", Offset = "0x80A1930", VA = "0x1880A3330")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6E861A0", Offset = "0x6E847A0", VA = "0x186E861A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MMADOEJJNDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x80A3450", Offset = "0x80A1A50", VA = "0x1880A3450")]
	[BNHIEDNKDNA.MLFEBCDGLFC]
	public static void LEDEINFKJEI(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x80A33E0", Offset = "0x80A19E0", VA = "0x1880A33E0")]
	public void JAIMPEBEMIP(NetworkManager IPIKGHELDDC, bool DKLKEOKHPJN)
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
