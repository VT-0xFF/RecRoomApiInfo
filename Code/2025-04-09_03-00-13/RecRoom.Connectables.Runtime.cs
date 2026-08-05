using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x78022B0", Offset = "0x78016B0", VA = "0x1878022B0", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7806FA0", Offset = "0x78063A0", VA = "0x187806FA0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7806AF0", Offset = "0x7805EF0", VA = "0x187806AF0")]
		private void CJALBJKGDPB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7806980", Offset = "0x7805D80", VA = "0x187806980")]
		private void AGDLJELKAMH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7806C60", Offset = "0x7806060", VA = "0x187806C60", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7806FE0", Offset = "0x78063E0", VA = "0x187806FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class AIJKLJDBOCC : JHEGFBAFKGM, PIEEAAJKAEB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class CKODBIMAAGP : IEnumerable<GIALOMBGGLA>, IEnumerable, IEnumerator<GIALOMBGGLA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private GIALOMBGGLA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private ENLBBCIDMLB localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public ENLBBCIDMLB <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AIJKLJDBOCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private FFMBAKBAEBH <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OJJAIKMKHDC <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private OJJAIKMKHDC.DPLFKKDNIHH <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private GIALOMBGGLA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xDEB050", Offset = "0xDEA450", VA = "0x180DEB050")]
		[DebuggerHidden]
		public CKODBIMAAGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x77F9B80", Offset = "0x77F8F80", VA = "0x1877F9B80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x77F96E0", Offset = "0x77F8AE0", VA = "0x1877F96E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x77F9A60", Offset = "0x77F8E60", VA = "0x1877F9A60")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x77F9A40", Offset = "0x77F8E40", VA = "0x1877F9A40")]
		private void NIIFAIKAHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x77F9B30", Offset = "0x77F8F30", VA = "0x1877F9B30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x77F9A80", Offset = "0x77F8E80", VA = "0x1877F9A80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GIALOMBGGLA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x77F9A80", Offset = "0x77F8E80", VA = "0x1877F9A80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class HELIFOCCKBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AIJKLJDBOCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public PGGPHIEPECH nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public HELIFOCCKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x77FEA30", Offset = "0x77FDE30", VA = "0x1877FEA30")]
		internal object FBDPHACGKIM(PGGPHIEPECH x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FPNKBFMMJPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public PGGPHIEPECH child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public HELIFOCCKBM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FPNKBFMMJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x77FC150", Offset = "0x77FB550", VA = "0x1877FC150")]
		internal object IPMIHCFJNEI((PGGPHIEPECH child, PGGPHIEPECH nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly GBHBOJAPDOA GMCBKLEAPOG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly GBHBOJAPDOA OGMLKKDMNPF;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly GBHBOJAPDOA EAPGJHFMFFK;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly GBHBOJAPDOA FFGCPBHEDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private JOKEFFGLMOB HBHIFBCHHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BDMGGDMEGBA DJIDDNDFIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private PFILDGPEHDE JNADIGGKGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private PEMBGADACLH IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private AFLOFIEGNCI AMKOHDPAPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly ACCHLPBBDHM BJPDKNNBBOE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MPMNNGFDLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xB4CF00", Offset = "0xB4C300", VA = "0x180B4CF00", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB4CBF0", Offset = "0xB4BFF0", VA = "0x180B4CBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PBIHHMGAACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA> MPBGJFNEJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77F4930", Offset = "0x77F3D30", VA = "0x1877F4930", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x77F63E0", Offset = "0x77F57E0", VA = "0x1877F63E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA> CAJFMPCMEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x77F5A70", Offset = "0x77F4E70", VA = "0x1877F5A70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x77F41C0", Offset = "0x77F35C0", VA = "0x1877F41C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA, GIALOMBGGLA> BOLEENGKJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x77F6190", Offset = "0x77F5590", VA = "0x1877F6190", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77F4600", Offset = "0x77F3A00", VA = "0x1877F4600", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x77F87F0", Offset = "0x77F7BF0", VA = "0x1877F87F0")]
	public AIJKLJDBOCC(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x77F4F70", Offset = "0x77F4370", VA = "0x1877F4F70", Slot = "12")]
	public void GDCNGOALEGL(GameObject GIIGFIAPGGB, PPCNEMNACEB EKJGAENMCCM, EIEDNOCIOIA ILKMGMIJKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x77F7540", Offset = "0x77F6940", VA = "0x1877F7540", Slot = "26")]
	public void NLAAFKHBPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x77F4A40", Offset = "0x77F3E40", VA = "0x1877F4A40", Slot = "22")]
	public bool EAKELEHMBLK(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x77F4720", Offset = "0x77F3B20", VA = "0x1877F4720")]
	private void DGMIMHJEICD(ENLBBCIDMLB AJGKJJKELJK, ENLBBCIDMLB FKJDBBEFDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x77F6490", Offset = "0x77F5890", VA = "0x1877F6490")]
	private void LHDCEBKNIKM(ENLBBCIDMLB AJGKJJKELJK, ENLBBCIDMLB BPDNKJGPPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x77F5D20", Offset = "0x77F5120", VA = "0x1877F5D20")]
	private void IMIADFBBBPJ(ENLBBCIDMLB AJGKJJKELJK, ENLBBCIDMLB BPDNKJGPPKG, ENLBBCIDMLB FKJDBBEFDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x77F8220", Offset = "0x77F7620", VA = "0x1877F8220")]
	private void ONLJEPJEKEH(ENLBBCIDMLB AJGKJJKELJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "13")]
	public void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x77F51E0", Offset = "0x77F45E0", VA = "0x1877F51E0", Slot = "14")]
	public void GEAMIGHEOPG(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "15")]
	public void CHIPMKBMMMB(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x77F4060", Offset = "0x77F3460", VA = "0x1877F4060", Slot = "17")]
	public void BCOABLGKKBE(GIALOMBGGLA PAHILCDKBDF, GIALOMBGGLA LDBKLKGEHOP, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x77F3F20", Offset = "0x77F3320", VA = "0x1877F3F20")]
	public void BCOABLGKKBE(ENLBBCIDMLB MKPPIPAJFEO, ENLBBCIDMLB LDBKLKGEHOP, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x77F4D70", Offset = "0x77F4170", VA = "0x1877F4D70")]
	public void FDKDIEGDIFK(GIALOMBGGLA PAHILCDKBDF, float NBBPCMCINPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77F4270", Offset = "0x77F3670", VA = "0x1877F4270", Slot = "18")]
	public void CHOHECMKAFC(GIALOMBGGLA HHPGOECMGIF, int HDHIMHPGGKM, GIALOMBGGLA AJMKLPHBAIP, int JKIENKNKEDK, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x77F3E70", Offset = "0x77F3270", VA = "0x1877F3E70")]
	private float AMMEEIIAPBA(ENLBBCIDMLB MKPPIPAJFEO, ENLBBCIDMLB KLDFHLFOOFN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x77F43D0", Offset = "0x77F37D0", VA = "0x1877F43D0")]
	public void CHOHECMKAFC(ENLBBCIDMLB MKPPIPAJFEO, ENLBBCIDMLB KLDFHLFOOFN, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF, bool CDGHOMMCPFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x77F4E00", Offset = "0x77F4200", VA = "0x1877F4E00", Slot = "19")]
	public void FPCIFJKFKHJ(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x77F5F80", Offset = "0x77F5380", VA = "0x1877F5F80", Slot = "16")]
	public void JIFJKGNBLJB(GIALOMBGGLA PAHILCDKBDF, HashSet<GIALOMBGGLA> NHBDOBDDCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "20")]
	public BLLECNEFLJH EHPGLEGLOAK(bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "21")]
	public BLLECNEFLJH NJKCDLGBHAL(HashSet<Guid> KLLKBAEOAOD, bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x77F46B0", Offset = "0x77F3AB0", VA = "0x1877F46B0", Slot = "23")]
	public void DDNNPDDLBDB(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x77F8630", Offset = "0x77F7A30", VA = "0x1877F8630", Slot = "24")]
	public void PMOKCKDLFEM(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x77F3E50", Offset = "0x77F3250", VA = "0x1877F3E50", Slot = "25")]
	public void AGLNGCIBICA(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x77F66B0", Offset = "0x77F5AB0", VA = "0x1877F66B0")]
	private void LMEBFGIGNPN(ENLBBCIDMLB MKPPIPAJFEO, ENLBBCIDMLB KLDFHLFOOFN, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF, float NBBPCMCINPH, bool CDGHOMMCPFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x77F7770", Offset = "0x77F6B70", VA = "0x1877F7770")]
	private void OBCOCFFAFFP(ENLBBCIDMLB MKPPIPAJFEO, ENLBBCIDMLB BBFFOKPDHFL, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x77F5B20", Offset = "0x77F4F20", VA = "0x1877F5B20")]
	private void IIGOMFDFAAJ(ENLBBCIDMLB MKPPIPAJFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x77F6240", Offset = "0x77F5640", VA = "0x1877F6240")]
	[IteratorStateMachine(typeof(CKODBIMAAGP))]
	public IEnumerable<GIALOMBGGLA> KHGCHBLIABI(ENLBBCIDMLB KJCJJFGLKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x77F6EB0", Offset = "0x77F62B0", VA = "0x1877F6EB0")]
	internal GIALOMBGGLA MMNFCPGDLGB(ENLBBCIDMLB KJCJJFGLKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x77F6D20", Offset = "0x77F6120", VA = "0x1877F6D20")]
	internal ENLBBCIDMLB MHPJLBDMDDM(GIALOMBGGLA PAHILCDKBDF)
	{
		return default(ENLBBCIDMLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x77F54E0", Offset = "0x77F48E0", VA = "0x1877F54E0")]
	private bool HGFEJMMPJKC(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x77F49E0", Offset = "0x77F3DE0", VA = "0x1877F49E0")]
	private bool DPHENHIEBLN(PGGPHIEPECH INAPFKLHCFN, [Out] GIALOMBGGLA KLDFHLFOOFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x77F6FE0", Offset = "0x77F63E0", VA = "0x1877F6FE0")]
	private GIALOMBGGLA MMNFCPGDLGB(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x77F6A10", Offset = "0x77F5E10", VA = "0x1877F6A10")]
	private GIALOMBGGLA MALMHBJGBDC(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x77F7370", Offset = "0x77F6770", VA = "0x1877F7370")]
	private GIALOMBGGLA MPJLIFDLMIP(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x77F7730", Offset = "0x77F6B30", VA = "0x1877F7730")]
	private static Guid NNLKJPOJEPO(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x77F4510", Offset = "0x77F3910", VA = "0x1877F4510")]
	private string CKHLKEGHJGO(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x77F6B90", Offset = "0x77F5F90", VA = "0x1877F6B90")]
	private void MGKEDJFEANM(GIALOMBGGLA MKPPIPAJFEO, GIALOMBGGLA BBFFOKPDHFL, RigidTransform HFKGBGNDKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x77F5B90", Offset = "0x77F4F90", VA = "0x1877F5B90")]
	private void ILBGMHGGONG(GIALOMBGGLA BBFFOKPDHFL, GIALOMBGGLA MKPPIPAJFEO, RigidTransform HFKGBGNDKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x77F4D10", Offset = "0x77F4110", VA = "0x1877F4D10")]
	private void EKBKBFPGCLN(GIALOMBGGLA JDOJOJLKALI, GIALOMBGGLA MKPPIPAJFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x77F8090", Offset = "0x77F7490", VA = "0x1877F8090")]
	private void OFDLKDMPIHL(GIALOMBGGLA MKPPIPAJFEO, GIALOMBGGLA KLDFHLFOOFN, RigidTransform HFKGBGNDKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x77F62D0", Offset = "0x77F56D0", VA = "0x1877F62D0")]
	private void KMJGMFCMECK(ENLBBCIDMLB KJCJJFGLKEE, GIALOMBGGLA PAHILCDKBDF, ENLBBCIDMLB BPDNKJGPPKG, ENLBBCIDMLB FKJDBBEFDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x77F4A90", Offset = "0x77F3E90", VA = "0x1877F4A90")]
	private void EIHAPBCMKOE(ENLBBCIDMLB KJCJJFGLKEE, GIALOMBGGLA PAHILCDKBDF, GIALOMBGGLA FHCFNDDNEKA, GIALOMBGGLA PLHEJCLJJDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KGAPJBOKOFA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GPJJMLBMAKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DHLGDCALOEP container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public GPJJMLBMAKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x77FE980", Offset = "0x77FDD80", VA = "0x1877FE980")]
		internal AIJKLJDBOCC DKPACFEEPGB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x77FF280", Offset = "0x77FE680", VA = "0x1877FF280")]
	public static void JDALAJCPJLE(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x77FF400", Offset = "0x77FE800", VA = "0x1877FF400")]
	public static void MFHPFJJDEGA(DHLGDCALOEP NKMJDOBLHGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class AHIJABPPCNA : IIJFOMINEJM, FELFKOBGHDF
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly RigidbodyEx LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly AIJKLJDBOCC IFGMBGAKGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly DLOIAGHLIFH HOOCOMAKEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BPJFGBGHFEO IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly MPFCDGNPHIB[] PEIGFAJECPL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ENLBBCIDMLB HIMBPBKIEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(ENLBBCIDMLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GIALOMBGGLA DPAOENJIOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x77F3C30", Offset = "0x77F3030", VA = "0x1877F3C30", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GIALOMBGGLA DOGJJMGPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x77F2450", Offset = "0x77F1850", VA = "0x1877F2450", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 LCLHFNBCLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x77F2780", Offset = "0x77F1B80", VA = "0x1877F2780", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion HABABIJIFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x77F2E40", Offset = "0x77F2240", VA = "0x1877F2E40", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NAEDIFJIPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x77F2290", Offset = "0x77F1690", VA = "0x1877F2290", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<GIALOMBGGLA> BCGDLAEHJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x77F2830", Offset = "0x77F1C30", VA = "0x1877F2830", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool KMKHJCJJDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xB5F7F0", Offset = "0xB5EBF0", VA = "0x180B5F7F0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xBAC750", Offset = "0xBABB50", VA = "0x180BAC750", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform IGBFJKOBHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x77F3E30", Offset = "0x77F3230", VA = "0x1877F3E30", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject ANCELBFINAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2CBCD60", Offset = "0x2CBC160", VA = "0x182CBCD60", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x77F3B70", Offset = "0x77F2F70", VA = "0x1877F3B70", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid FDADKBOIOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x77F3C90", Offset = "0x77F3090", VA = "0x1877F3C90", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EKPHFMGBMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x77F3D70", Offset = "0x77F3170", VA = "0x1877F3D70", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MAPLKBKDIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool IOIPHKPMBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x77F3860", Offset = "0x77F2C60", VA = "0x1877F3860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event FENLKPMOLCC DADOOIOJIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x77F32B0", Offset = "0x77F26B0", VA = "0x1877F32B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x77F3910", Offset = "0x77F2D10", VA = "0x1877F3910", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FENLKPMOLCC MALPFDBDPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x77F23F0", Offset = "0x77F17F0", VA = "0x1877F23F0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x77F38B0", Offset = "0x77F2CB0", VA = "0x1877F38B0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event FENLKPMOLCC BIOMJBLAKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x77F3970", Offset = "0x77F2D70", VA = "0x1877F3970", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x77F2510", Offset = "0x77F1910", VA = "0x1877F2510", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event DBLGPEDIELO JOPEOHCKPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x77F2080", Offset = "0x77F1480", VA = "0x1877F2080", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x77F21F0", Offset = "0x77F15F0", VA = "0x1877F21F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x77F3A70", Offset = "0x77F2E70", VA = "0x1877F3A70")]
	public AHIJABPPCNA(ENLBBCIDMLB DAIIJGMPMAD, RigidbodyEx LPNNCKGGDEC, DLOIAGHLIFH HOOCOMAKEHG, MPFCDGNPHIB[] PEIGFAJECPL, BPJFGBGHFEO IAPHFNOPBJO, JHEGFBAFKGM IFGMBGAKGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x77F3500", Offset = "0x77F2900", VA = "0x1877F3500", Slot = "19")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "21")]
	public void MFADMNIEKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7595950", Offset = "0x7594D50", VA = "0x187595950", Slot = "22")]
	public void BCIDKLDCFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x77F27E0", Offset = "0x77F1BE0", VA = "0x1877F27E0", Slot = "20")]
	public void FMCLIDDFJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x77F2570", Offset = "0x77F1970", VA = "0x1877F2570", Slot = "25")]
	public void EOLEHOMDFGM(int KNDNMJHEIJG, GIALOMBGGLA AJMKLPHBAIP, int NPBBMEFNMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x77F2120", Offset = "0x77F1520", VA = "0x1877F2120", Slot = "26")]
	public void AMGMNHGOGLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x77F3530", Offset = "0x77F2930", VA = "0x1877F3530", Slot = "27")]
	public void NFFNKLEOOFP(int KNDNMJHEIJG, GIALOMBGGLA HHPGOECMGIF, int PCNNCEPBCFO, [Optional] Vector3? LJELLFALGOA, [Optional] Quaternion? LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x77F2DC0", Offset = "0x77F21C0", VA = "0x1877F2DC0", Slot = "28")]
	public void IPPLCOAPNAO(GIALOMBGGLA HHPGOECMGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x77F2EA0", Offset = "0x77F22A0", VA = "0x1877F2EA0", Slot = "31")]
	public void JMNLFFAJING(Vector3 JBKJHPKGPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x77F2AB0", Offset = "0x77F1EB0", VA = "0x1877F2AB0", Slot = "29")]
	public void HLCECCAFMMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x77F3310", Offset = "0x77F2710", VA = "0x1877F3310", Slot = "30")]
	public void KEMCLHBEKCM(int CJFNAFNJJLB, Vector3 HDCIJLICBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x77F29E0", Offset = "0x77F1DE0", VA = "0x1877F29E0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int KNDNMJHEIJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x77F28B0", Offset = "0x77F1CB0", VA = "0x1877F28B0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int KNDNMJHEIJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xB3D400", Offset = "0xB3C800", VA = "0x180B3D400", Slot = "42")]
	public Color GetConnectionSlotColor(int KNDNMJHEIJG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x77F2300", Offset = "0x77F1700", VA = "0x1877F2300", Slot = "43")]
	public bool CanConnectTo(int KNDNMJHEIJG, GIALOMBGGLA FPAHCDEONKC, int JLDJDCFODLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "44")]
	public void ParentChanged(int KNDNMJHEIJG, GIALOMBGGLA AAFFKHKGNLF, int NJFHGHINMLA, Vector3 OEMFCBOPDKN, Quaternion HLANAFIOHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "45")]
	public void ChildAdded(int KNDNMJHEIJG, GIALOMBGGLA GFLPBOLFPEE, int HKIJMHIECJJ, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "46")]
	public void ChildRemoved(int KNDNMJHEIJG, GIALOMBGGLA GAGEDOMKMCE, int JADBMGOKNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "47")]
	public void ConnectionModified(int KNDNMJHEIJG, GIALOMBGGLA AJMKLPHBAIP, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x77F39D0", Offset = "0x77F2DD0", VA = "0x1877F39D0", Slot = "48")]
	public void RootChanged(GIALOMBGGLA KCBCNFANGGK, GIALOMBGGLA IDAFMIJJHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x77F23A0", Offset = "0x77F17A0", VA = "0x1877F23A0", Slot = "23")]
	public void DCAOCCOJMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x77F3810", Offset = "0x77F2C10", VA = "0x1877F3810", Slot = "24")]
	public void NFPFHGNGIIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x77F2860", Offset = "0x77F1C60", VA = "0x1877F2860")]
	private void GJDJJEMEBPI(bool BEHJEINGLJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(BHJDBAMBLHI), new string[] { })]
public class CKBODJPLAJH : BHJDBAMBLHI, KKLCFFMBMBE, KKJGFIPLMOM
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class JNHGEGNGDIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public JNHGEGNGDIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[DependsOn]
	private EHKOFDACJCI CJADGLGGCKK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object OPIPGNMGGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x77F95E0", Offset = "0x77F89E0", VA = "0x1877F95E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x77F9590", Offset = "0x77F8990", VA = "0x1877F9590", Slot = "5")]
	private void AMIFDGGMEHF(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1047140", Offset = "0x1046540", VA = "0x181047140", Slot = "6")]
	private void PBLPDJGLCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public CKBODJPLAJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(JHEGFBAFKGM), new string[] { "Ignore", "Mock" })]
public class HMFFOHGEFMJ : JHEGFBAFKGM, PIEEAAJKAEB
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MPMNNGFDLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PBIHHMGAACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA> MPBGJFNEJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x77FEC00", Offset = "0x77FE000", VA = "0x1877FEC00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x77FEE10", Offset = "0x77FE210", VA = "0x1877FEE10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA> CAJFMPCMEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x77FECB0", Offset = "0x77FE0B0", VA = "0x1877FECB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x77FEAA0", Offset = "0x77FDEA0", VA = "0x1877FEAA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA, GIALOMBGGLA> BOLEENGKJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x77FED60", Offset = "0x77FE160", VA = "0x1877FED60", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x77FEB50", Offset = "0x77FDF50", VA = "0x1877FEB50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "26")]
	public void NLAAFKHBPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "12")]
	public void GDCNGOALEGL(GameObject GIIGFIAPGGB, PPCNEMNACEB EKJGAENMCCM, EIEDNOCIOIA FOKEILAMLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "13")]
	public void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "14")]
	public void GEAMIGHEOPG(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "15")]
	public void CHIPMKBMMMB(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "16")]
	public void JIFJKGNBLJB(GIALOMBGGLA PAHILCDKBDF, HashSet<GIALOMBGGLA> NHBDOBDDCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "17")]
	public void BCOABLGKKBE(GIALOMBGGLA PAHILCDKBDF, GIALOMBGGLA LDBKLKGEHOP, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "18")]
	public void CHOHECMKAFC(GIALOMBGGLA PAHILCDKBDF, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "19")]
	public void FPCIFJKFKHJ(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "20")]
	public BLLECNEFLJH EHPGLEGLOAK(bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "21")]
	public BLLECNEFLJH NJKCDLGBHAL(HashSet<Guid> KLLKBAEOAOD, bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "22")]
	public bool EAKELEHMBLK(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "23")]
	public void DDNNPDDLBDB(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "24")]
	public void PMOKCKDLFEM(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "25")]
	public void AGLNGCIBICA(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public HMFFOHGEFMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GIALOMBGGLA : FELFKOBGHDF, IEquatable<GIALOMBGGLA>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FELFKOBGHDF
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	GIALOMBGGLA DPAOENJIOBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform IGBFJKOBHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject ANCELBFINAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid FDADKBOIOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int EKPHFMGBMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	ENLBBCIDMLB HIMBPBKIEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool MAPLKBKDIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int KNDNMJHEIJG);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int KNDNMJHEIJG);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int KNDNMJHEIJG);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int KNDNMJHEIJG, GIALOMBGGLA FPAHCDEONKC, int DHECLNNMKED);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int KNDNMJHEIJG, GIALOMBGGLA AAFFKHKGNLF, int NJFHGHINMLA, Vector3 OEMFCBOPDKN, Quaternion HLANAFIOHBJ);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int KNDNMJHEIJG, GIALOMBGGLA GFLPBOLFPEE, int HKIJMHIECJJ, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int KNDNMJHEIJG, GIALOMBGGLA GAGEDOMKMCE, int JADBMGOKNBL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int KNDNMJHEIJG, GIALOMBGGLA AJMKLPHBAIP, int CMMALJOJMPM, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(GIALOMBGGLA KCBCNFANGGK, GIALOMBGGLA IDAFMIJJHBF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JHEGFBAFKGM : PIEEAAJKAEB
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MPMNNGFDLEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool PBIHHMGAACF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<GIALOMBGGLA, GIALOMBGGLA> MPBGJFNEJPP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<GIALOMBGGLA, GIALOMBGGLA> CAJFMPCMEAK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<GIALOMBGGLA, GIALOMBGGLA, GIALOMBGGLA> BOLEENGKJMG;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GDCNGOALEGL(GameObject GIIGFIAPGGB, PPCNEMNACEB EKJGAENMCCM, EIEDNOCIOIA EAOHCPLNDKC);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ODNOMLGNGJI();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GEAMIGHEOPG(GIALOMBGGLA PAHILCDKBDF);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CHIPMKBMMMB(GIALOMBGGLA PAHILCDKBDF);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JIFJKGNBLJB(GIALOMBGGLA PAHILCDKBDF, HashSet<GIALOMBGGLA> NHBDOBDDCMP);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BCOABLGKKBE(GIALOMBGGLA PAHILCDKBDF, GIALOMBGGLA LDBKLKGEHOP, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CHOHECMKAFC(GIALOMBGGLA PAHILCDKBDF, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FPCIFJKFKHJ(GIALOMBGGLA PAHILCDKBDF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	BLLECNEFLJH EHPGLEGLOAK(bool GDPNNIPIDKK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	BLLECNEFLJH NJKCDLGBHAL(HashSet<Guid> KLLKBAEOAOD, bool GDPNNIPIDKK);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool EAKELEHMBLK(PGGPHIEPECH INAPFKLHCFN);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DDNNPDDLBDB(BLLECNEFLJH CHEHNOIOMFH);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PMOKCKDLFEM(BLLECNEFLJH CHEHNOIOMFH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AGLNGCIBICA(BLLECNEFLJH CHEHNOIOMFH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PEMBGADACLH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool LADPAGIBFDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GIALOMBGGLA MPJLIFDLMIP(int MPMIOODMBHB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GIALOMBGGLA MALMHBJGBDC(Guid MLDHOINKEDB);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KMPGLPMIAKH(GIALOMBGGLA PAHILCDKBDF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KCIBEDHDJAP();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PONIGIEPEFL(GIALOMBGGLA HOOCOMAKEHG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface BPJFGBGHFEO
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IOIPHKPMBFJ(DLOIAGHLIFH HOOCOMAKEHG);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EGOCOJCLHGH(DLOIAGHLIFH HOOCOMAKEHG);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string PHIOGKBMNFK(DLOIAGHLIFH HOOCOMAKEHG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid OCKGIEENHJE(DLOIAGHLIFH HOOCOMAKEHG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LNFCEKMJIGL(DLOIAGHLIFH HOOCOMAKEHG);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AEECKFBDFOB(DLOIAGHLIFH HOOCOMAKEHG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void FENLKPMOLCC(GIALOMBGGLA HHPGOECMGIF, int JHDIFLJPLNP, GIALOMBGGLA AJMKLPHBAIP, int GDHDEPANELF, [Optional] Vector3? LJELLFALGOA, [Optional] Quaternion? LGDKIOFOOMD);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void DBLGPEDIELO(GIALOMBGGLA KCBCNFANGGK, GIALOMBGGLA IDAFMIJJHBF);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DLOIAGHLIFH : GIALOMBGGLA, FELFKOBGHDF, IEquatable<GIALOMBGGLA>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IIJFOMINEJM : FELFKOBGHDF
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	GIALOMBGGLA DOGJJMGPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<GIALOMBGGLA> BCGDLAEHJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 LCLHFNBCLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion HABABIJIFLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool NAEDIFJIPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool KMKHJCJJDJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event FENLKPMOLCC DADOOIOJIHC;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event FENLKPMOLCC MALPFDBDPLP;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event FENLKPMOLCC BIOMJBLAKHA;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event DBLGPEDIELO JOPEOHCKPLC;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MNNJMFNPKAP();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FMCLIDDFJAP();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MFADMNIEKMB();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BCIDKLDCFJL();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DCAOCCOJMLN();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NFPFHGNGIIA();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void EOLEHOMDFGM(int KNDNMJHEIJG, GIALOMBGGLA AJMKLPHBAIP, int NPBBMEFNMOA);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void AMGMNHGOGLP();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void NFFNKLEOOFP(int KNDNMJHEIJG, GIALOMBGGLA HHPGOECMGIF, int PCNNCEPBCFO, [Optional] Vector3? LJELLFALGOA, [Optional] Quaternion? LGDKIOFOOMD);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IPPLCOAPNAO(GIALOMBGGLA HHPGOECMGIF);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HLCECCAFMMH();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KEMCLHBEKCM(int CJFNAFNJJLB, Vector3 HDCIJLICBPE);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JMNLFFAJING(Vector3 JBKJHPKGPCM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MPFCDGNPHIB
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 KJNEPAPJMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PPCNEMNACEB
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool GAJAJAOCLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	BFAEJFGLAMG LNJBMEDDJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, PPCNEMNACEB
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[FormerlySerializedAs("linkVisualPrefab")]
		[SerializeField]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA11750", Offset = "0xA10B50", VA = "0x180A11750", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public BFAEJFGLAMG LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x77F9C60", Offset = "0x77F9060", VA = "0x1877F9C60")]
		public static ConnectableConfigData PPFMNFLHCIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x77F9D20", Offset = "0x77F9120", VA = "0x1877F9D20")]
		public ConnectableConfigData(LegacyConnectableLinkVisual DHPFACCBDJD, bool CKDDGALEAAP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BLMLJOJDCDB : IEquatable<BLMLJOJDCDB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public GIALOMBGGLA PAHILCDKBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int KAJDCINBCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int CMMALJOJMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 LJELLFALGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion LGDKIOFOOMD;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x77F92D0", Offset = "0x77F86D0", VA = "0x1877F92D0")]
	public BLMLJOJDCDB(GIALOMBGGLA PAHILCDKBDF, int KAJDCINBCAB, int CMMALJOJMPM, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x77F9230", Offset = "0x77F8630", VA = "0x1877F9230")]
	public BLMLJOJDCDB(GIALOMBGGLA PAHILCDKBDF, int KAJDCINBCAB, int CMMALJOJMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x77F91B0", Offset = "0x77F85B0", VA = "0x1877F91B0")]
	public BLMLJOJDCDB(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x77F8D40", Offset = "0x77F8140", VA = "0x1877F8D40", Slot = "4")]
	public bool Equals(BLMLJOJDCDB KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x77F8DF0", Offset = "0x77F81F0", VA = "0x1877F8DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class OLMNNEGANDO : LKBAKKOJKCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform KHDOKFIGIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private BFAEJFGLAMG LJGIAAILBNH;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x721D190", Offset = "0x721C590", VA = "0x18721D190", Slot = "4")]
	public void GDCNGOALEGL(Transform KHDOKFIGIID, BFAEJFGLAMG LJGIAAILBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7802590", Offset = "0x7801990", VA = "0x187802590", Slot = "5")]
	public BFAEJFGLAMG FMHEMKKGNOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7802650", Offset = "0x7801A50", VA = "0x187802650", Slot = "6")]
	public void JHBEOKNDOEB(BFAEJFGLAMG JCFCBLLGGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public OLMNNEGANDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class PHCECDEGAEG : IDisposable, AIKNCDHHADG
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AKGBPJONPPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GIALOMBGGLA oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GIALOMBGGLA newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public AKGBPJONPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x77F8860", Offset = "0x77F7C60", VA = "0x1877F8860")]
		internal bool PDCLEEKENHA(PAPAPHPEFDL node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly POAIIKBONGE JICGPLPGFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EDPMFIHIMCK KJLMMNNEIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private CBAEHCHDBBH JIHGMCPNOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool CKDDGALEAAP;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly GBHBOJAPDOA JOAMLCMELNE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public PAPAPHPEFDL HLJCJLLDIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7803C80", Offset = "0x7803080", VA = "0x187803C80")]
	public bool HDGIMKJMCKA([In] NCKKDALILNC HPMNBNLACCC, bool JKEAAPJIEEP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x78036C0", Offset = "0x7802AC0", VA = "0x1878036C0")]
	private bool FAFNBKPGBFN([In] NCKKDALILNC HPMNBNLACCC, bool JKEAAPJIEEP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7805A70", Offset = "0x7804E70", VA = "0x187805A70")]
	public PHCECDEGAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7803C90", Offset = "0x7803090", VA = "0x187803C90", Slot = "5")]
	public void GDCNGOALEGL(JHEGFBAFKGM HEKFIEJNOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7805980", Offset = "0x7804D80", VA = "0x187805980", Slot = "17")]
	public void OCCKFCLFPLA(NALNABLIIOP ADLKPPBLCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x78041C0", Offset = "0x78035C0", VA = "0x1878041C0", Slot = "12")]
	public void IPBLCOHEIEP(Func<GIALOMBGGLA, bool> DKJICCMMFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7804090", Offset = "0x7803490", VA = "0x187804090")]
	private void IPBLCOHEIEP(POAIIKBONGE BLGGFHHEDNC, Func<GIALOMBGGLA, bool> DKJICCMMFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7805250", Offset = "0x7804650", VA = "0x187805250", Slot = "11")]
	public void MLLJMJBBEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x78026C0", Offset = "0x7801AC0", VA = "0x1878026C0", Slot = "8")]
	public bool AAJDACGLJCB(GIALOMBGGLA MJLLNIBDMFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7804680", Offset = "0x7803A80", VA = "0x187804680")]
	private bool KBDCODHONKE(GIALOMBGGLA ENJEEAOCKLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7803D40", Offset = "0x7803140", VA = "0x187803D40")]
	private static bool GDIPDJEMALE(GIALOMBGGLA ENJEEAOCKLB, POAIIKBONGE JOCLJNODKCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7805590", Offset = "0x7804990", VA = "0x187805590")]
	private void OAOBNJFILII(Transform POGHLMICDEO, POAIIKBONGE DJCGDODEGPJ, POAIIKBONGE[] HAILNIMNHMG, GIALOMBGGLA JBNKDICFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x78026D0", Offset = "0x7801AD0", VA = "0x1878026D0")]
	private BLMLJOJDCDB ACDJIMNBHBL(Transform HIJPDNBBCJF, BLMLJOJDCDB NDMEPLPFAPG)
	{
		return default(BLMLJOJDCDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x78053D0", Offset = "0x78047D0", VA = "0x1878053D0")]
	private static bool NNIILJPDJFE(POAIIKBONGE JOCLJNODKCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7804DC0", Offset = "0x78041C0", VA = "0x187804DC0", Slot = "9")]
	public bool LHFBCKCDOJC(GIALOMBGGLA FINNEBDLIKE, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7802C00", Offset = "0x7802000", VA = "0x187802C00")]
	private bool DIFNMOHOGFK(GIALOMBGGLA FINNEBDLIKE, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7803DF0", Offset = "0x78031F0", VA = "0x187803DF0")]
	private static void GMALAHKHHNI(GIALOMBGGLA FINNEBDLIKE, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD, POAIIKBONGE DNHFFDOIIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7805130", Offset = "0x7804530", VA = "0x187805130")]
	private void MGKEDJFEANM(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7802820", Offset = "0x7801C20", VA = "0x187802820")]
	private void AMJHGKLKLAF(POAIIKBONGE BLGGFHHEDNC, GIALOMBGGLA FHCFNDDNEKA, GIALOMBGGLA PLHEJCLJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7802890", Offset = "0x7801C90", VA = "0x187802890")]
	private void AMJHGKLKLAF(GIALOMBGGLA PAHILCDKBDF, GIALOMBGGLA FHCFNDDNEKA, GIALOMBGGLA PLHEJCLJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x78033F0", Offset = "0x78027F0", VA = "0x1878033F0")]
	private void EIHAPBCMKOE(GIALOMBGGLA PAHILCDKBDF, GIALOMBGGLA FHCFNDDNEKA, GIALOMBGGLA PLHEJCLJJDJ, bool CGMCNLNMBNF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7803460", Offset = "0x7802860", VA = "0x187803460")]
	private void EIHAPBCMKOE(POAIIKBONGE BKHMOJGGBFN, GIALOMBGGLA JBNKDICFKBE, GIALOMBGGLA IDAFMIJJHBF, bool CGMCNLNMBNF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7803F70", Offset = "0x7803370", VA = "0x187803F70")]
	private void ILBGMHGGONG(GIALOMBGGLA MKPPIPAJFEO, int PCNNCEPBCFO, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7803560", Offset = "0x7802960", VA = "0x187803560")]
	private void EKBKBFPGCLN(PAPAPHPEFDL KLDFHLFOOFN, PAPAPHPEFDL KBDENKJGOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7805270", Offset = "0x7804670", VA = "0x187805270", Slot = "18")]
	public GIALOMBGGLA MPEAPEEELOG(GIALOMBGGLA PAHILCDKBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x78042E0", Offset = "0x78036E0", VA = "0x1878042E0", Slot = "13")]
	public void JIFJKGNBLJB(GIALOMBGGLA PAHILCDKBDF, HashSet<GIALOMBGGLA> OPENNKPKNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7804E20", Offset = "0x7804220", VA = "0x187804E20", Slot = "14")]
	public List<GIALOMBGGLA> LIHNKGMNHFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7805060", Offset = "0x7804460", VA = "0x187805060")]
	protected PAPAPHPEFDL MEOJGCHLLPI(PAPAPHPEFDL BLGGFHHEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7802A90", Offset = "0x7801E90", VA = "0x187802A90")]
	protected POAIIKBONGE[] CIILNFJOHOA(POAIIKBONGE JOCLJNODKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x78041D0", Offset = "0x78035D0", VA = "0x1878041D0")]
	protected bool JAPDCNHGNCM(GIALOMBGGLA PAHILCDKBDF, [Out] POAIIKBONGE BLGGFHHEDNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7802960", Offset = "0x7801D60", VA = "0x187802960", Slot = "15")]
	public bool BLANFHCCKFL(GIALOMBGGLA PAHILCDKBDF, [Out] BLMLJOJDCDB GDFPKNKMINE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7804D80", Offset = "0x7804180", VA = "0x187804D80")]
	protected POAIIKBONGE KEDKFHHOJJL(BLMLJOJDCDB KMGJEBJAAHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7802900", Offset = "0x7801D00", VA = "0x187802900", Slot = "10")]
	public bool ANHJFMELCCG(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7802E50", Offset = "0x7802250", VA = "0x187802E50")]
	private bool EDJMCCKAEMH(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7802B30", Offset = "0x7801F30", VA = "0x187802B30")]
	private static bool CLPGIKAACEA(POAIIKBONGE NHHCAODJMJJ, BLMLJOJDCDB IMEMOIBIIMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7803C80", Offset = "0x7803080", VA = "0x187803C80", Slot = "7")]
	private bool GBECPLJLFGP([In] NCKKDALILNC HPMNBNLACCC, bool JKEAAPJIEEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class EGLNCLDIOAJ : JHEGFBAFKGM, PIEEAAJKAEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly DHLGDCALOEP NKMJDOBLHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly CBAEHCHDBBH JIHGMCPNOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly BHNNLMNELNJ DGJPLACFIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly KLIGKPLAINF FDHJJFJAOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly AIKNCDHHADG CHEHNOIOMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal OICLCDMGPBH IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal HFPJKEOFMLI BOGAODIGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal EDPMFIHIMCK LDMFIMJNDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool CKDDGALEAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool BJHBNAJCBGL;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool ILCFMAHFMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xB45770", Offset = "0xB44B70", VA = "0x180B45770")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1171630", Offset = "0x1170A30", VA = "0x181171630")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MPMNNGFDLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xE683B0", Offset = "0xE677B0", VA = "0x180E683B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x246E080", Offset = "0x246D480", VA = "0x18246E080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool PBIHHMGAACF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA> MPBGJFNEJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x77FA410", Offset = "0x77F9810", VA = "0x1877FA410", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x77FB510", Offset = "0x77FA910", VA = "0x1877FB510", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA> CAJFMPCMEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x77FB360", Offset = "0x77FA760", VA = "0x1877FB360", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x77FA180", Offset = "0x77F9580", VA = "0x1877FA180", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA, GIALOMBGGLA> BOLEENGKJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x77FB4B0", Offset = "0x77FA8B0", VA = "0x1877FB4B0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x77FA320", Offset = "0x77F9720", VA = "0x1877FA320", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x77FBBA0", Offset = "0x77FAFA0", VA = "0x1877FBBA0")]
	public EGLNCLDIOAJ(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x77FAAF0", Offset = "0x77F9EF0", VA = "0x1877FAAF0", Slot = "12")]
	public void GDCNGOALEGL(GameObject GIIGFIAPGGB, PPCNEMNACEB EKJGAENMCCM, EIEDNOCIOIA EAOHCPLNDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x77FB710", Offset = "0x77FAB10", VA = "0x1877FB710", Slot = "26")]
	public void NLAAFKHBPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x77FBA70", Offset = "0x77FAE70", VA = "0x1877FBA70", Slot = "13")]
	public void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x77FB0F0", Offset = "0x77FA4F0", VA = "0x1877FB0F0", Slot = "14")]
	public void GEAMIGHEOPG(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x77F9F10", Offset = "0x77F9310", VA = "0x1877F9F10", Slot = "15")]
	public void CHIPMKBMMMB(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x77FA470", Offset = "0x77F9870", VA = "0x1877FA470", Slot = "22")]
	public bool EAKELEHMBLK(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x77FA4C0", Offset = "0x77F98C0", VA = "0x1877FA4C0")]
	internal bool EDJMCCKAEMH([In] NCKKDALILNC HPMNBNLACCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x77FB920", Offset = "0x77FAD20", VA = "0x1877FB920")]
	internal bool NMFNKLDDJPM([In] NCKKDALILNC HPMNBNLACCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x77FA5D0", Offset = "0x77F99D0", VA = "0x1877FA5D0")]
	internal void EGPAOMAHMNN(GIALOMBGGLA PAHILCDKBDF, int AKKHBDOGNOA, bool JKEAAPJIEEP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x77F9F10", Offset = "0x77F9310", VA = "0x1877F9F10")]
	internal bool AKBMIJFOOGH(GIALOMBGGLA OBAMHGICKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x77FB7E0", Offset = "0x77FABE0", VA = "0x1877FB7E0")]
	internal bool NLGOLBMMODP(GIALOMBGGLA FINNEBDLIKE, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x77FB3C0", Offset = "0x77FA7C0", VA = "0x1877FB3C0", Slot = "16")]
	public void JIFJKGNBLJB(GIALOMBGGLA PAHILCDKBDF, HashSet<GIALOMBGGLA> NHBDOBDDCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x77F9F70", Offset = "0x77F9370", VA = "0x1877F9F70", Slot = "17")]
	public void BCOABLGKKBE(GIALOMBGGLA FINNEBDLIKE, GIALOMBGGLA LDBKLKGEHOP, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x77FA1E0", Offset = "0x77F95E0", VA = "0x1877FA1E0", Slot = "18")]
	public void CHOHECMKAFC(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x77FA930", Offset = "0x77F9D30", VA = "0x1877FA930", Slot = "19")]
	public void FPCIFJKFKHJ(GIALOMBGGLA IKMNICINOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x77FB110", Offset = "0x77FA510", VA = "0x1877FB110")]
	public void HIHLMFGNFIM([Optional] EJNOMEECLJP MMLKDIBMELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x77FA380", Offset = "0x77F9780", VA = "0x1877FA380", Slot = "23")]
	public void DDNNPDDLBDB(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x77FA7B0", Offset = "0x77F9BB0", VA = "0x1877FA7B0", Slot = "20")]
	public BLLECNEFLJH EHPGLEGLOAK(bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x77FB570", Offset = "0x77FA970", VA = "0x1877FB570", Slot = "21")]
	public BLLECNEFLJH NJKCDLGBHAL(HashSet<Guid> KLLKBAEOAOD, bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x77F9ED0", Offset = "0x77F92D0", VA = "0x1877F9ED0", Slot = "25")]
	public void AGLNGCIBICA(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x77FBAF0", Offset = "0x77FAEF0", VA = "0x1877FBAF0", Slot = "24")]
	public void PMOKCKDLFEM(BLLECNEFLJH CHEHNOIOMFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class CBAEHCHDBBH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly APHAPGEAMFF<GIALOMBGGLA, GIALOMBGGLA> MPBGJFNEJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly APHAPGEAMFF<GIALOMBGGLA, GIALOMBGGLA> CAJFMPCMEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly CJBDHFJKABF<GIALOMBGGLA, GIALOMBGGLA, GIALOMBGGLA> BOLEENGKJMG;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x77F9470", Offset = "0x77F8870", VA = "0x1877F9470")]
	public CBAEHCHDBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	public void GDCNGOALEGL(EGLNCLDIOAJ HEKFIEJNOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x77F9410", Offset = "0x77F8810", VA = "0x1877F9410")]
	public void ONGAPEGFIOK(GIALOMBGGLA KLDFHLFOOFN, GIALOMBGGLA MKPPIPAJFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x77F9330", Offset = "0x77F8730", VA = "0x1877F9330")]
	public void BNDEHBLNGHD(GIALOMBGGLA KLDFHLFOOFN, GIALOMBGGLA MKPPIPAJFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x77F9390", Offset = "0x77F8790", VA = "0x1877F9390")]
	public void EBBOJKDIOEG(GIALOMBGGLA JDOJOJLKALI, GIALOMBGGLA BBFFOKPDHFL, GIALOMBGGLA MKPPIPAJFEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class BHNNLMNELNJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private EGLNCLDIOAJ HEKFIEJNOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HFPJKEOFMLI BOGAODIGBEK;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public BHNNLMNELNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x77F8AF0", Offset = "0x77F7EF0", VA = "0x1877F8AF0")]
	public void GDCNGOALEGL(EGLNCLDIOAJ HEKFIEJNOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x77F8AA0", Offset = "0x77F7EA0", VA = "0x1877F8AA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x77F8AB0", Offset = "0x77F7EB0", VA = "0x1877F8AB0")]
	private void FBACCNCBHAN(OLEMOLOENHO LGLPENFMNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x77F8A30", Offset = "0x77F7E30", VA = "0x1877F8A30")]
	private void DIJINAIGFDH(EJNOMEECLJP NECMOJEKHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x77F8C30", Offset = "0x77F8030", VA = "0x1877F8C30")]
	public void MANOMJIGPED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x77F8920", Offset = "0x77F7D20", VA = "0x1877F8920")]
	public void ADOOEHEMJJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KCOFAKDLADD
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DFENJMFHFKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public DHLGDCALOEP container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DFENJMFHFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x77F9D70", Offset = "0x77F9170", VA = "0x1877F9D70")]
		internal EGLNCLDIOAJ DKPACFEEPGB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x77FF000", Offset = "0x77FE400", VA = "0x1877FF000")]
	public static void JDALAJCPJLE(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x77FF200", Offset = "0x77FE600", VA = "0x1877FF200")]
	public static void MFHPFJJDEGA(DHLGDCALOEP NKMJDOBLHGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class GIJGNEEAJAH : IDisposable, EDPMFIHIMCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, BFAEJFGLAMG> CJAGADFLGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly NALNABLIIOP JBLNEBAMKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private LKBAKKOJKCC CFONGFHMKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private AIKNCDHHADG CHEHNOIOMFH;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static ProfilerMarker ACNHCGJNJDC;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x77FD060", Offset = "0x77FC460", VA = "0x1877FD060")]
	public GIJGNEEAJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x77FC880", Offset = "0x77FBC80", VA = "0x1877FC880", Slot = "7")]
	public void GDCNGOALEGL(AIKNCDHHADG CHEHNOIOMFH, LKBAKKOJKCC CFONGFHMKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x77FC8C0", Offset = "0x77FBCC0", VA = "0x1877FC8C0", Slot = "5")]
	public void MJCJPKJMNCB(PAPAPHPEFDL LBFGPCDLOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x77FC710", Offset = "0x77FBB10", VA = "0x1877FC710", Slot = "9")]
	public void FOHPINHNAHP(PAPAPHPEFDL FHCFIMCAOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x77FC3A0", Offset = "0x77FB7A0", VA = "0x1877FC3A0", Slot = "8")]
	public void BIPINLOMDFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x77FCCB0", Offset = "0x77FC0B0", VA = "0x1877FCCB0", Slot = "10")]
	public void PFBNEMKOOIK(PAPAPHPEFDL OFJJJGMEJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x77FC560", Offset = "0x77FB960", VA = "0x1877FC560", Slot = "11")]
	public void EOLAKAPJDGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x77FCB00", Offset = "0x77FBF00", VA = "0x1877FCB00")]
	private bool MKJKGPDOGEG(PAPAPHPEFDL AHDECIMNHGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class KLIGKPLAINF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct GLHCGGHFAAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly POAIIKBONGE NAFLECONHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HashSet<Guid> KLLKBAEOAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly PGGPHIEPECH DGFPILPOBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly PGGPHIEPECH LAKDAEGACEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly bool GDPNNIPIDKK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool JABOJFCLBFI
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x77FE280", Offset = "0x77FD680", VA = "0x1877FE280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x77FE910", Offset = "0x77FDD10", VA = "0x1877FE910")]
		public GLHCGGHFAAN(POAIIKBONGE NAFLECONHBK, HashSet<Guid> KLLKBAEOAOD, bool GDPNNIPIDKK, [Optional] PGGPHIEPECH DGFPILPOBID, [Optional] PGGPHIEPECH LAKDAEGACEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x77FE770", Offset = "0x77FDB70", VA = "0x1877FE770")]
		public PGGPHIEPECH PELCBGJOJPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x77FE050", Offset = "0x77FD450", VA = "0x1877FE050")]
		private PGGPHIEPECH AHOFCOLGGFF([Out] PGGPHIEPECH GPANIOAIEED, [Out] PGGPHIEPECH JLKAONHCJED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x77FE550", Offset = "0x77FD950", VA = "0x1877FE550")]
		private PGGPHIEPECH OJPJLJNIEPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x77FE110", Offset = "0x77FD510", VA = "0x1877FE110")]
		private void GPNNAMEHOKD(PGGPHIEPECH AIAFHAIGJMH, PGGPHIEPECH AKKFBFLHBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x77FE390", Offset = "0x77FD790", VA = "0x1877FE390")]
		private void MBLIMEDLNEJ(PGGPHIEPECH GPANIOAIEED, PGGPHIEPECH JLKAONHCJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private EGLNCLDIOAJ HEKFIEJNOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private AIKNCDHHADG CHEHNOIOMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private EDPMFIHIMCK KJLMMNNEIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private HFPJKEOFMLI BOGAODIGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool GJLLIDPGKLC;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool KMMECOGHKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x77FFC00", Offset = "0x77FF000", VA = "0x1877FFC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool ILCFMAHFMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7800EA0", Offset = "0x78002A0", VA = "0x187800EA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7800770", Offset = "0x77FFB70", VA = "0x187800770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x77FFE40", Offset = "0x77FF240", VA = "0x1877FFE40")]
	public void GDCNGOALEGL(EGLNCLDIOAJ HEKFIEJNOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x77FFA90", Offset = "0x77FEE90", VA = "0x1877FFA90")]
	public BLLECNEFLJH EHPGLEGLOAK(bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7801640", Offset = "0x7800A40", VA = "0x187801640")]
	public BLLECNEFLJH NJKCDLGBHAL(HashSet<Guid> KLLKBAEOAOD, bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x77FF660", Offset = "0x77FEA60", VA = "0x1877FF660")]
	public void DDNNPDDLBDB(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7801990", Offset = "0x7800D90", VA = "0x187801990")]
	public void PMOKCKDLFEM(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x77FF450", Offset = "0x77FE850", VA = "0x1877FF450")]
	public void BDDKDEHIEDF(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7800A40", Offset = "0x77FFE40", VA = "0x187800A40")]
	private void JPHIMGMIFFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x77FF570", Offset = "0x77FE970", VA = "0x1877FF570")]
	private PGGPHIEPECH CPDDEKEGBAD(POAIIKBONGE BLGGFHHEDNC, bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7800790", Offset = "0x77FFB90", VA = "0x187800790")]
	private static void JMAOMFKEBFF(POAIIKBONGE BLGGFHHEDNC, bool GDPNNIPIDKK, PGGPHIEPECH INAPFKLHCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7800EC0", Offset = "0x78002C0", VA = "0x187800EC0")]
	private void MFAEPDNHHIE(POAIIKBONGE BLGGFHHEDNC, bool GDPNNIPIDKK, PGGPHIEPECH INAPFKLHCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x78015B0", Offset = "0x78009B0", VA = "0x1878015B0")]
	private PGGPHIEPECH NENFLDDJGJB(POAIIKBONGE NAFLECONHBK, HashSet<Guid> KLLKBAEOAOD, bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7800C20", Offset = "0x7800020", VA = "0x187800C20")]
	private bool KAJLKCNCDFD(BLLECNEFLJH ODLECLOBCAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x77FFEB0", Offset = "0x77FF2B0", VA = "0x1877FFEB0")]
	private bool HGFEJMMPJKC(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x78017E0", Offset = "0x7800BE0", VA = "0x1878017E0")]
	private bool ONODCFBMECI(BLLECNEFLJH CHEHNOIOMFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x77FF6F0", Offset = "0x77FEAF0", VA = "0x1877FF6F0")]
	private static bool DEKDIKCKFEB(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x77FF800", Offset = "0x77FEC00", VA = "0x1877FF800")]
	public static bool EAKELEHMBLK(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x78010E0", Offset = "0x78004E0", VA = "0x1878010E0")]
	private GIALOMBGGLA MMNFCPGDLGB(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7801430", Offset = "0x7800830", VA = "0x187801430")]
	private GIALOMBGGLA MPJLIFDLMIP(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7801800", Offset = "0x7800C00", VA = "0x187801800")]
	private GIALOMBGGLA PMAFMMMPNFK(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x77F7730", Offset = "0x77F6B30", VA = "0x1877F7730")]
	private static Guid NNLKJPOJEPO(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x77FF480", Offset = "0x77FE880", VA = "0x1877FF480")]
	private string CKHLKEGHJGO(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x77FFC50", Offset = "0x77FF050", VA = "0x1877FFC50")]
	private bool EMGBPAABPBC(POAIIKBONGE BLGGFHHEDNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7800510", Offset = "0x77FF910", VA = "0x187800510")]
	private static void IGKCHNIMAOK(POAIIKBONGE NAFLECONHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public KLIGKPLAINF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct NCKKDALILNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public GIALOMBGGLA MKPPIPAJFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public GIALOMBGGLA KLDFHLFOOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int PCNNCEPBCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int NPBBMEFNMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector3 LJELLFALGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Quaternion LGDKIOFOOMD;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public BLMLJOJDCDB OIDDEKIDIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7802450", Offset = "0x7801850", VA = "0x187802450")]
		get
		{
			return default(BLMLJOJDCDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BLMLJOJDCDB EFPJDEOIFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x78024F0", Offset = "0x78018F0", VA = "0x1878024F0")]
		get
		{
			return default(BLMLJOJDCDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7802520", Offset = "0x7801920", VA = "0x187802520")]
	public NCKKDALILNC(GIALOMBGGLA MKPPIPAJFEO, GIALOMBGGLA KLDFHLFOOFN, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface AIKNCDHHADG
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PAPAPHPEFDL HLJCJLLDIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDCNGOALEGL(JHEGFBAFKGM HEKFIEJNOCO);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HDGIMKJMCKA([In] NCKKDALILNC HPMNBNLACCC, bool JKEAAPJIEEP = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AAJDACGLJCB(GIALOMBGGLA MJLLNIBDMFJ);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LHFBCKCDOJC(GIALOMBGGLA FINNEBDLIKE, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ANHJFMELCCG(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MLLJMJBBEDJ();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IPBLCOHEIEP(Func<GIALOMBGGLA, bool> DKJICCMMFAC);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JIFJKGNBLJB(GIALOMBGGLA PAHILCDKBDF, HashSet<GIALOMBGGLA> OPENNKPKNKE);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<GIALOMBGGLA> LIHNKGMNHFG();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BLANFHCCKFL(GIALOMBGGLA PAHILCDKBDF, [Out] BLMLJOJDCDB GDFPKNKMINE);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OCCKFCLFPLA(NALNABLIIOP ADLKPPBLCIG);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool NALNABLIIOP(PAPAPHPEFDL BLGGFHHEDNC);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface PAPAPHPEFDL
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	GIALOMBGGLA FCBAHDJNKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	PAPAPHPEFDL HBBFFDLJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	BLMLJOJDCDB NOEMCJLNBON
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool EGALAAOJBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface BFAEJFGLAMG
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BECHPFCMIHE(GIALOMBGGLA AJMKLPHBAIP, BLMLJOJDCDB MKPPIPAJFEO);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCEOIIFAGIP(GIALOMBGGLA AJMKLPHBAIP, BLMLJOJDCDB MKPPIPAJFEO);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DEDMPHFMHBJ(GIALOMBGGLA AJMKLPHBAIP, BLMLJOJDCDB MKPPIPAJFEO);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HEANBGBEEBK(GIALOMBGGLA AJMKLPHBAIP, BLMLJOJDCDB MKPPIPAJFEO);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BFAEJFGLAMG Instantiate(Transform KHDOKFIGIID);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OAHDOECNNKP();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface LKBAKKOJKCC
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDCNGOALEGL(Transform KHDOKFIGIID, BFAEJFGLAMG LJGIAAILBNH);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BFAEJFGLAMG FMHEMKKGNOH();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHBEOKNDOEB(BFAEJFGLAMG JCFCBLLGGKO);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface OICLCDMGPBH : PEMBGADACLH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCKMBIGJEAK();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNIBHPDMJPI(Guid OAGBMEMFNEC);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface EDPMFIHIMCK
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJCJPKJMNCB(PAPAPHPEFDL LBFGPCDLOKF);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GDCNGOALEGL(AIKNCDHHADG CHEHNOIOMFH, LKBAKKOJKCC ECOJAKMJOHC);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BIPINLOMDFA();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOHPINHNAHP(PAPAPHPEFDL FHCFIMCAOMM);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PFBNEMKOOIK(PAPAPHPEFDL OFJJJGMEJID);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EOLAKAPJDGO();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class POAIIKBONGE : PAPAPHPEFDL
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JLKAHGACOHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public BLMLJOJDCDB nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public POAIIKBONGE foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public JLKAHGACOHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x77FEEC0", Offset = "0x77FE2C0", VA = "0x1877FEEC0")]
		internal bool DDGKLECPCMF(PAPAPHPEFDL x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private BLMLJOJDCDB GDFPKNKMINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LinkedList<POAIIKBONGE> GHOJKGPMAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private POAIIKBONGE FCBDIMHLLFK;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BLMLJOJDCDB NOEMCJLNBON
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1171350", Offset = "0x1170750", VA = "0x181171350", Slot = "6")]
		get
		{
			return default(BLMLJOJDCDB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1171030", Offset = "0x1170430", VA = "0x181171030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private POAIIKBONGE KLDFHLFOOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9AA390", Offset = "0x9A9790", VA = "0x1809AA390")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x78060E0", Offset = "0x78054E0", VA = "0x1878060E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public PAPAPHPEFDL HBBFFDLJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9AA390", Offset = "0x9A9790", VA = "0x1809AA390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GIALOMBGGLA FCBAHDJNKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool EGALAAOJBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7806530", Offset = "0x7805930", VA = "0x187806530", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LKPLCFFDACE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7805D90", Offset = "0x7805190", VA = "0x187805D90", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected POAIIKBONGE BKHMOJGGBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x78060C0", Offset = "0x78054C0", VA = "0x1878060C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x78066C0", Offset = "0x7805AC0", VA = "0x1878066C0")]
	public POAIIKBONGE(BLMLJOJDCDB JHINHPGOMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x78063E0", Offset = "0x78057E0", VA = "0x1878063E0")]
	public POAIIKBONGE OEHIFBKDANM(BLMLJOJDCDB FDBIDLLACFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7806540", Offset = "0x7805940", VA = "0x187806540")]
	public POAIIKBONGE PCLCNOCBMLH(BLMLJOJDCDB LPOPNLLKHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7805DE0", Offset = "0x78051E0", VA = "0x187805DE0")]
	public POAIIKBONGE JEBJOEBLLEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7805C40", Offset = "0x7805040", VA = "0x187805C40")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x78061C0", Offset = "0x78055C0", VA = "0x1878061C0")]
	public POAIIKBONGE NJADOLHOJJF(BLMLJOJDCDB BBFFOKPDHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7806270", Offset = "0x7805670", VA = "0x187806270")]
	private static void OCCKFCLFPLA(POAIIKBONGE PJJLHHFNOPJ, NALNABLIIOP EKJBIEIFIHC, bool LGEBPACBNGE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x78063D0", Offset = "0x78057D0", VA = "0x1878063D0", Slot = "9")]
	public void OCCKFCLFPLA(NALNABLIIOP ADLKPPBLCIG, bool CGMCNLNMBNF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7805FC0", Offset = "0x78053C0", VA = "0x187805FC0")]
	public static POAIIKBONGE KEDKFHHOJJL(POAIIKBONGE PJJLHHFNOPJ, BLMLJOJDCDB MHDEOJGAHGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface HFPJKEOFMLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool KMMECOGHKMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool LADPAGIBFDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<OLEMOLOENHO> FBACCNCBHAN;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<EJNOMEECLJP> DIJINAIGFDH;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BECHPFCMIHE(EGLNCLDIOAJ HEKFIEJNOCO, EIEDNOCIOIA FOKEILAMLCI);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BCOABLGKKBE(GIALOMBGGLA FINNEBDLIKE, GIALOMBGGLA LDBKLKGEHOP, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CHOHECMKAFC(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FHMMEMEDNLG(BLLECNEFLJH PCDALIBGMOA, [Optional] EJNOMEECLJP MMLKDIBMELD);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EEGLAPHHFCG
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type KAFGKIIBACB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x77F9DE0", Offset = "0x77F91E0", VA = "0x1877F9DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object DNEPPKLGBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x77F9E90", Offset = "0x77F9290", VA = "0x1877F9E90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x77F9E40", Offset = "0x77F9240", VA = "0x1877F9E40")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class GJOJBBILNGM : HFPJKEOFMLI, IDisposable, PPJPICJPBMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private EGLNCLDIOAJ HEKFIEJNOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private EIEDNOCIOIA EAOHCPLNDKC;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool KMMECOGHKMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x77FD510", Offset = "0x77FC910", VA = "0x1877FD510", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool LADPAGIBFDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x77FD870", Offset = "0x77FCC70", VA = "0x1877FD870", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private PhotonView CODLDKPDACB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x77FD8B0", Offset = "0x77FCCB0", VA = "0x1877FD8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<OLEMOLOENHO> FBACCNCBHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x77FD300", Offset = "0x77FC700", VA = "0x1877FD300", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x77FD6A0", Offset = "0x77FCAA0", VA = "0x1877FD6A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<EJNOMEECLJP> DIJINAIGFDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x77FD730", Offset = "0x77FCB30", VA = "0x1877FD730", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x77FD7D0", Offset = "0x77FCBD0", VA = "0x1877FD7D0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x77FD270", Offset = "0x77FC670", VA = "0x1877FD270", Slot = "10")]
	public void BECHPFCMIHE(EGLNCLDIOAJ HEKFIEJNOCO, EIEDNOCIOIA EAOHCPLNDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x77FD4C0", Offset = "0x77FC8C0", VA = "0x1877FD4C0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x77FD140", Offset = "0x77FC540", VA = "0x1877FD140", Slot = "11")]
	public void BCOABLGKKBE(GIALOMBGGLA FINNEBDLIKE, GIALOMBGGLA LDBKLKGEHOP, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x77FD390", Offset = "0x77FC790", VA = "0x1877FD390", Slot = "12")]
	public void CHOHECMKAFC(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x77FD570", Offset = "0x77FC970", VA = "0x1877FD570", Slot = "13")]
	public void FHMMEMEDNLG(BLLECNEFLJH PCDALIBGMOA, [Optional] EJNOMEECLJP MMLKDIBMELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x77FDB80", Offset = "0x77FCF80", VA = "0x1877FDB80")]
	[JKGLLPCKFPN]
	private void RpcMasterReparentNodes(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x77FD980", Offset = "0x77FCD80", VA = "0x1877FD980")]
	[JKGLLPCKFPN]
	private void RpcMasterModifyNode(GIALOMBGGLA FINNEBDLIKE, GIALOMBGGLA LDBKLKGEHOP, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x77FDF50", Offset = "0x77FD350", VA = "0x1877FDF50")]
	[JKGLLPCKFPN]
	private void RpcReparentNodes(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD, KPLGNFFIKML LHHPHCOCHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x77FDE90", Offset = "0x77FD290", VA = "0x1877FDE90")]
	[JKGLLPCKFPN]
	private void RpcModifyNode(GIALOMBGGLA FINNEBDLIKE, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD, KPLGNFFIKML LHHPHCOCHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x77FD940", Offset = "0x77FCD40", VA = "0x1877FD940")]
	[JKGLLPCKFPN]
	private void RpcDeserializeConnectableGraph(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public GJOJBBILNGM()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, BFAEJFGLAMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7801C00", Offset = "0x7801000", VA = "0x187801C00", Slot = "4")]
		private void IBHIGNEEECN(GIALOMBGGLA AJMKLPHBAIP, BLMLJOJDCDB MKPPIPAJFEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7801FE0", Offset = "0x78013E0", VA = "0x187801FE0", Slot = "5")]
		private void MBOKALCOAHA(GIALOMBGGLA AJMKLPHBAIP, BLMLJOJDCDB MKPPIPAJFEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7801AA0", Offset = "0x7800EA0", VA = "0x187801AA0", Slot = "6")]
		private void AMPBCMLCKMC(GIALOMBGGLA AJMKLPHBAIP, BLMLJOJDCDB MKPPIPAJFEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7801D80", Offset = "0x7801180", VA = "0x187801D80", Slot = "7")]
		private void IOJGEBPHANO(GIALOMBGGLA AJMKLPHBAIP, BLMLJOJDCDB MKPPIPAJFEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7801F70", Offset = "0x7801370", VA = "0x187801F70", Slot = "8")]
		private BFAEJFGLAMG JFPDJKNDIPK(Transform KHDOKFIGIID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7802250", Offset = "0x7801650", VA = "0x187802250", Slot = "9")]
		private void PDACOHOHAPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class ONDDGOCPLPD
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3817290", Offset = "0x3816690", VA = "0x183817290")]
	public static OMICDECFGLI<T> MIAFHOKLPBN<T>(this DHLGDCALOEP NKMJDOBLHGP)
	{
		return null;
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
