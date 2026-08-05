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
		[Cpp2IlInjected.Address(RVA = "0x77B5B50", Offset = "0x77B4F50", VA = "0x1877B5B50", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
			[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x77BA8B0", Offset = "0x77B9CB0", VA = "0x1877BA8B0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x77BA400", Offset = "0x77B9800", VA = "0x1877BA400")]
		private void CJALBJKGDPB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x77BA290", Offset = "0x77B9690", VA = "0x1877BA290")]
		private void AGDLJELKAMH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x77BA570", Offset = "0x77B9970", VA = "0x1877BA570", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x77BA8F0", Offset = "0x77B9CF0", VA = "0x1877BA8F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xDE6750", Offset = "0xDE5B50", VA = "0x180DE6750")]
		[DebuggerHidden]
		public CKODBIMAAGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x77AD2D0", Offset = "0x77AC6D0", VA = "0x1877AD2D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x77ACE30", Offset = "0x77AC230", VA = "0x1877ACE30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x77AD1B0", Offset = "0x77AC5B0", VA = "0x1877AD1B0")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x77AD190", Offset = "0x77AC590", VA = "0x1877AD190")]
		private void NIIFAIKAHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x77AD280", Offset = "0x77AC680", VA = "0x1877AD280", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x77AD1D0", Offset = "0x77AC5D0", VA = "0x1877AD1D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GIALOMBGGLA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x77AD1D0", Offset = "0x77AC5D0", VA = "0x1877AD1D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public HELIFOCCKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x77B2210", Offset = "0x77B1610", VA = "0x1877B2210")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public FPNKBFMMJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x77AF900", Offset = "0x77AED00", VA = "0x1877AF900")]
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
		[Cpp2IlInjected.Address(RVA = "0xB459B0", Offset = "0xB44DB0", VA = "0x180B459B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB45690", Offset = "0xB44A90", VA = "0x180B45690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PBIHHMGAACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA> MPBGJFNEJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77A7FB0", Offset = "0x77A73B0", VA = "0x1877A7FB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x77A9A80", Offset = "0x77A8E80", VA = "0x1877A9A80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA> CAJFMPCMEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x77A9110", Offset = "0x77A8510", VA = "0x1877A9110", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x77A7840", Offset = "0x77A6C40", VA = "0x1877A7840", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA, GIALOMBGGLA> BOLEENGKJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x77A9830", Offset = "0x77A8C30", VA = "0x1877A9830", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77A7C80", Offset = "0x77A7080", VA = "0x1877A7C80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x77ABF30", Offset = "0x77AB330", VA = "0x1877ABF30")]
	public AIJKLJDBOCC(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x77A85F0", Offset = "0x77A79F0", VA = "0x1877A85F0", Slot = "12")]
	public void GDCNGOALEGL(GameObject GIIGFIAPGGB, PPCNEMNACEB EKJGAENMCCM, EIEDNOCIOIA ILKMGMIJKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x77AAC50", Offset = "0x77AA050", VA = "0x1877AAC50", Slot = "26")]
	public void NLAAFKHBPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x77A80C0", Offset = "0x77A74C0", VA = "0x1877A80C0", Slot = "22")]
	public bool EAKELEHMBLK(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x77A7DA0", Offset = "0x77A71A0", VA = "0x1877A7DA0")]
	private void DGMIMHJEICD(ENLBBCIDMLB AJGKJJKELJK, ENLBBCIDMLB FKJDBBEFDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x77A9B30", Offset = "0x77A8F30", VA = "0x1877A9B30")]
	private void LHDCEBKNIKM(ENLBBCIDMLB AJGKJJKELJK, ENLBBCIDMLB BPDNKJGPPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x77A93C0", Offset = "0x77A87C0", VA = "0x1877A93C0")]
	private void IMIADFBBBPJ(ENLBBCIDMLB AJGKJJKELJK, ENLBBCIDMLB BPDNKJGPPKG, ENLBBCIDMLB FKJDBBEFDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x77AB940", Offset = "0x77AAD40", VA = "0x1877AB940")]
	private void ONLJEPJEKEH(ENLBBCIDMLB AJGKJJKELJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "13")]
	public void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x77A8860", Offset = "0x77A7C60", VA = "0x1877A8860", Slot = "14")]
	public void GEAMIGHEOPG(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "15")]
	public void CHIPMKBMMMB(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x77A76E0", Offset = "0x77A6AE0", VA = "0x1877A76E0", Slot = "17")]
	public void BCOABLGKKBE(GIALOMBGGLA PAHILCDKBDF, GIALOMBGGLA LDBKLKGEHOP, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x77A75A0", Offset = "0x77A69A0", VA = "0x1877A75A0")]
	public void BCOABLGKKBE(ENLBBCIDMLB MKPPIPAJFEO, ENLBBCIDMLB LDBKLKGEHOP, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x77A83F0", Offset = "0x77A77F0", VA = "0x1877A83F0")]
	public void FDKDIEGDIFK(GIALOMBGGLA PAHILCDKBDF, float NBBPCMCINPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77A78F0", Offset = "0x77A6CF0", VA = "0x1877A78F0", Slot = "18")]
	public void CHOHECMKAFC(GIALOMBGGLA HHPGOECMGIF, int HDHIMHPGGKM, GIALOMBGGLA AJMKLPHBAIP, int JKIENKNKEDK, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x77A74F0", Offset = "0x77A68F0", VA = "0x1877A74F0")]
	private float AMMEEIIAPBA(ENLBBCIDMLB MKPPIPAJFEO, ENLBBCIDMLB KLDFHLFOOFN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x77A7A50", Offset = "0x77A6E50", VA = "0x1877A7A50")]
	public void CHOHECMKAFC(ENLBBCIDMLB MKPPIPAJFEO, ENLBBCIDMLB KLDFHLFOOFN, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF, bool CDGHOMMCPFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x77A8480", Offset = "0x77A7880", VA = "0x1877A8480", Slot = "19")]
	public void FPCIFJKFKHJ(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x77A9620", Offset = "0x77A8A20", VA = "0x1877A9620", Slot = "16")]
	public void JIFJKGNBLJB(GIALOMBGGLA PAHILCDKBDF, HashSet<GIALOMBGGLA> NHBDOBDDCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "20")]
	public BLLECNEFLJH EHPGLEGLOAK(bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "21")]
	public BLLECNEFLJH NJKCDLGBHAL(HashSet<Guid> KLLKBAEOAOD, bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x77A7D30", Offset = "0x77A7130", VA = "0x1877A7D30", Slot = "23")]
	public void DDNNPDDLBDB(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x77ABD50", Offset = "0x77AB150", VA = "0x1877ABD50", Slot = "24")]
	public void PMOKCKDLFEM(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x77A74D0", Offset = "0x77A68D0", VA = "0x1877A74D0", Slot = "25")]
	public void AGLNGCIBICA(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x77A9D50", Offset = "0x77A9150", VA = "0x1877A9D50")]
	private void LMEBFGIGNPN(ENLBBCIDMLB MKPPIPAJFEO, ENLBBCIDMLB KLDFHLFOOFN, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF, float NBBPCMCINPH, bool CDGHOMMCPFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x77AAE80", Offset = "0x77AA280", VA = "0x1877AAE80")]
	private void OBCOCFFAFFP(ENLBBCIDMLB MKPPIPAJFEO, ENLBBCIDMLB BBFFOKPDHFL, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x77A91C0", Offset = "0x77A85C0", VA = "0x1877A91C0")]
	private void IIGOMFDFAAJ(ENLBBCIDMLB MKPPIPAJFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x77A98E0", Offset = "0x77A8CE0", VA = "0x1877A98E0")]
	[IteratorStateMachine(typeof(CKODBIMAAGP))]
	public IEnumerable<GIALOMBGGLA> KHGCHBLIABI(ENLBBCIDMLB KJCJJFGLKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x77AA580", Offset = "0x77A9980", VA = "0x1877AA580")]
	internal GIALOMBGGLA MMNFCPGDLGB(ENLBBCIDMLB KJCJJFGLKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x77AA3E0", Offset = "0x77A97E0", VA = "0x1877AA3E0")]
	internal ENLBBCIDMLB MHPJLBDMDDM(GIALOMBGGLA PAHILCDKBDF)
	{
		return default(ENLBBCIDMLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x77A8B70", Offset = "0x77A7F70", VA = "0x1877A8B70")]
	private bool HGFEJMMPJKC(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x77A8060", Offset = "0x77A7460", VA = "0x1877A8060")]
	private bool DPHENHIEBLN(PGGPHIEPECH INAPFKLHCFN, [Out] GIALOMBGGLA KLDFHLFOOFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x77AA6C0", Offset = "0x77A9AC0", VA = "0x1877AA6C0")]
	private GIALOMBGGLA MMNFCPGDLGB(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x77AA0C0", Offset = "0x77A94C0", VA = "0x1877AA0C0")]
	private GIALOMBGGLA MALMHBJGBDC(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x77AAA70", Offset = "0x77A9E70", VA = "0x1877AAA70")]
	private GIALOMBGGLA MPJLIFDLMIP(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x77AAE40", Offset = "0x77AA240", VA = "0x1877AAE40")]
	private static Guid NNLKJPOJEPO(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x77A7B90", Offset = "0x77A6F90", VA = "0x1877A7B90")]
	private string CKHLKEGHJGO(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x77AA250", Offset = "0x77A9650", VA = "0x1877AA250")]
	private void MGKEDJFEANM(GIALOMBGGLA MKPPIPAJFEO, GIALOMBGGLA BBFFOKPDHFL, RigidTransform HFKGBGNDKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x77A9230", Offset = "0x77A8630", VA = "0x1877A9230")]
	private void ILBGMHGGONG(GIALOMBGGLA BBFFOKPDHFL, GIALOMBGGLA MKPPIPAJFEO, RigidTransform HFKGBGNDKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x77A8390", Offset = "0x77A7790", VA = "0x1877A8390")]
	private void EKBKBFPGCLN(GIALOMBGGLA JDOJOJLKALI, GIALOMBGGLA MKPPIPAJFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x77AB7B0", Offset = "0x77AABB0", VA = "0x1877AB7B0")]
	private void OFDLKDMPIHL(GIALOMBGGLA MKPPIPAJFEO, GIALOMBGGLA KLDFHLFOOFN, RigidTransform HFKGBGNDKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x77A9970", Offset = "0x77A8D70", VA = "0x1877A9970")]
	private void KMJGMFCMECK(ENLBBCIDMLB KJCJJFGLKEE, GIALOMBGGLA PAHILCDKBDF, ENLBBCIDMLB BPDNKJGPPKG, ENLBBCIDMLB FKJDBBEFDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x77A8110", Offset = "0x77A7510", VA = "0x1877A8110")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public GPJJMLBMAKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x77B2160", Offset = "0x77B1560", VA = "0x1877B2160")]
		internal AIJKLJDBOCC DKPACFEEPGB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x77B2A60", Offset = "0x77B1E60", VA = "0x1877B2A60")]
	public static void JDALAJCPJLE(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x77B2BE0", Offset = "0x77B1FE0", VA = "0x1877B2BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0", Slot = "38")]
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
		[Cpp2IlInjected.Address(RVA = "0x77A72A0", Offset = "0x77A66A0", VA = "0x1877A72A0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GIALOMBGGLA DOGJJMGPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x77A5A90", Offset = "0x77A4E90", VA = "0x1877A5A90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 LCLHFNBCLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x77A5DC0", Offset = "0x77A51C0", VA = "0x1877A5DC0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion HABABIJIFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x77A6480", Offset = "0x77A5880", VA = "0x1877A6480", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NAEDIFJIPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x77A58D0", Offset = "0x77A4CD0", VA = "0x1877A58D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<GIALOMBGGLA> BCGDLAEHJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x77A5E70", Offset = "0x77A5270", VA = "0x1877A5E70", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0xB583D0", Offset = "0xB577D0", VA = "0x180B583D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xBA5330", Offset = "0xBA4730", VA = "0x180BA5330", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform IGBFJKOBHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x77A74B0", Offset = "0x77A68B0", VA = "0x1877A74B0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject ANCELBFINAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2CC21A0", Offset = "0x2CC15A0", VA = "0x182CC21A0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x77A71D0", Offset = "0x77A65D0", VA = "0x1877A71D0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid FDADKBOIOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x77A7300", Offset = "0x77A6700", VA = "0x1877A7300", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EKPHFMGBMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x77A73E0", Offset = "0x77A67E0", VA = "0x1877A73E0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MAPLKBKDIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool IOIPHKPMBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x77A6EB0", Offset = "0x77A62B0", VA = "0x1877A6EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event FENLKPMOLCC DADOOIOJIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x77A68F0", Offset = "0x77A5CF0", VA = "0x1877A68F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x77A6F60", Offset = "0x77A6360", VA = "0x1877A6F60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FENLKPMOLCC MALPFDBDPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x77A5A30", Offset = "0x77A4E30", VA = "0x1877A5A30", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x77A6F00", Offset = "0x77A6300", VA = "0x1877A6F00", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event FENLKPMOLCC BIOMJBLAKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x77A6FC0", Offset = "0x77A63C0", VA = "0x1877A6FC0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x77A5B50", Offset = "0x77A4F50", VA = "0x1877A5B50", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event DBLGPEDIELO JOPEOHCKPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x77A56C0", Offset = "0x77A4AC0", VA = "0x1877A56C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x77A5830", Offset = "0x77A4C30", VA = "0x1877A5830", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x77A70D0", Offset = "0x77A64D0", VA = "0x1877A70D0")]
	public AHIJABPPCNA(ENLBBCIDMLB DAIIJGMPMAD, RigidbodyEx LPNNCKGGDEC, DLOIAGHLIFH HOOCOMAKEHG, MPFCDGNPHIB[] PEIGFAJECPL, BPJFGBGHFEO IAPHFNOPBJO, JHEGFBAFKGM IFGMBGAKGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x77A6B50", Offset = "0x77A5F50", VA = "0x1877A6B50", Slot = "19")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "21")]
	public void MFADMNIEKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x75502C0", Offset = "0x754F6C0", VA = "0x1875502C0", Slot = "22")]
	public void BCIDKLDCFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x77A5E20", Offset = "0x77A5220", VA = "0x1877A5E20", Slot = "20")]
	public void FMCLIDDFJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x77A5BB0", Offset = "0x77A4FB0", VA = "0x1877A5BB0", Slot = "25")]
	public void EOLEHOMDFGM(int KNDNMJHEIJG, GIALOMBGGLA AJMKLPHBAIP, int NPBBMEFNMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x77A5760", Offset = "0x77A4B60", VA = "0x1877A5760", Slot = "26")]
	public void AMGMNHGOGLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x77A6B80", Offset = "0x77A5F80", VA = "0x1877A6B80", Slot = "27")]
	public void NFFNKLEOOFP(int KNDNMJHEIJG, GIALOMBGGLA HHPGOECMGIF, int PCNNCEPBCFO, [Optional] Vector3? LJELLFALGOA, [Optional] Quaternion? LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x77A6400", Offset = "0x77A5800", VA = "0x1877A6400", Slot = "28")]
	public void IPPLCOAPNAO(GIALOMBGGLA HHPGOECMGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x77A64E0", Offset = "0x77A58E0", VA = "0x1877A64E0", Slot = "31")]
	public void JMNLFFAJING(Vector3 JBKJHPKGPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x77A60F0", Offset = "0x77A54F0", VA = "0x1877A60F0", Slot = "29")]
	public void HLCECCAFMMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x77A6950", Offset = "0x77A5D50", VA = "0x1877A6950", Slot = "30")]
	public void KEMCLHBEKCM(int CJFNAFNJJLB, Vector3 HDCIJLICBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x77A6020", Offset = "0x77A5420", VA = "0x1877A6020", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int KNDNMJHEIJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x77A5EF0", Offset = "0x77A52F0", VA = "0x1877A5EF0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int KNDNMJHEIJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xB35CE0", Offset = "0xB350E0", VA = "0x180B35CE0", Slot = "42")]
	public Color GetConnectionSlotColor(int KNDNMJHEIJG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x77A5940", Offset = "0x77A4D40", VA = "0x1877A5940", Slot = "43")]
	public bool CanConnectTo(int KNDNMJHEIJG, GIALOMBGGLA FPAHCDEONKC, int JLDJDCFODLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "44")]
	public void ParentChanged(int KNDNMJHEIJG, GIALOMBGGLA AAFFKHKGNLF, int NJFHGHINMLA, Vector3 OEMFCBOPDKN, Quaternion HLANAFIOHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "45")]
	public void ChildAdded(int KNDNMJHEIJG, GIALOMBGGLA GFLPBOLFPEE, int HKIJMHIECJJ, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "46")]
	public void ChildRemoved(int KNDNMJHEIJG, GIALOMBGGLA GAGEDOMKMCE, int JADBMGOKNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "47")]
	public void ConnectionModified(int KNDNMJHEIJG, GIALOMBGGLA AJMKLPHBAIP, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x77A7020", Offset = "0x77A6420", VA = "0x1877A7020", Slot = "48")]
	public void RootChanged(GIALOMBGGLA KCBCNFANGGK, GIALOMBGGLA IDAFMIJJHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x77A59E0", Offset = "0x77A4DE0", VA = "0x1877A59E0", Slot = "23")]
	public void DCAOCCOJMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x77A6E60", Offset = "0x77A6260", VA = "0x1877A6E60", Slot = "24")]
	public void NFPFHGNGIIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x77A5EA0", Offset = "0x77A52A0", VA = "0x1877A5EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x77ACD30", Offset = "0x77AC130", VA = "0x1877ACD30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x77ACCE0", Offset = "0x77AC0E0", VA = "0x1877ACCE0", Slot = "5")]
	private void AMIFDGGMEHF(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1053D90", Offset = "0x1053190", VA = "0x181053D90", Slot = "6")]
	private void PBLPDJGLCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PBIHHMGAACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA> MPBGJFNEJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x77B23E0", Offset = "0x77B17E0", VA = "0x1877B23E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x77B25F0", Offset = "0x77B19F0", VA = "0x1877B25F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA> CAJFMPCMEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x77B2490", Offset = "0x77B1890", VA = "0x1877B2490", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x77B2280", Offset = "0x77B1680", VA = "0x1877B2280", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA, GIALOMBGGLA> BOLEENGKJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x77B2540", Offset = "0x77B1940", VA = "0x1877B2540", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x77B2330", Offset = "0x77B1730", VA = "0x1877B2330", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "26")]
	public void NLAAFKHBPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "12")]
	public void GDCNGOALEGL(GameObject GIIGFIAPGGB, PPCNEMNACEB EKJGAENMCCM, EIEDNOCIOIA FOKEILAMLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "13")]
	public void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "14")]
	public void GEAMIGHEOPG(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "15")]
	public void CHIPMKBMMMB(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "16")]
	public void JIFJKGNBLJB(GIALOMBGGLA PAHILCDKBDF, HashSet<GIALOMBGGLA> NHBDOBDDCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "17")]
	public void BCOABLGKKBE(GIALOMBGGLA PAHILCDKBDF, GIALOMBGGLA LDBKLKGEHOP, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "18")]
	public void CHOHECMKAFC(GIALOMBGGLA PAHILCDKBDF, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "19")]
	public void FPCIFJKFKHJ(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "20")]
	public BLLECNEFLJH EHPGLEGLOAK(bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "21")]
	public BLLECNEFLJH NJKCDLGBHAL(HashSet<Guid> KLLKBAEOAOD, bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "22")]
	public bool EAKELEHMBLK(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "23")]
	public void DDNNPDDLBDB(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "24")]
	public void PMOKCKDLFEM(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "25")]
	public void AGLNGCIBICA(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FB880", Offset = "0x9FAC80", VA = "0x1809FB880", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public BFAEJFGLAMG LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x77AD3B0", Offset = "0x77AC7B0", VA = "0x1877AD3B0")]
		public static ConnectableConfigData PPFMNFLHCIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x77AD470", Offset = "0x77AC870", VA = "0x1877AD470")]
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
	[Cpp2IlInjected.Address(RVA = "0x77ACA20", Offset = "0x77ABE20", VA = "0x1877ACA20")]
	public BLMLJOJDCDB(GIALOMBGGLA PAHILCDKBDF, int KAJDCINBCAB, int CMMALJOJMPM, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x77AC980", Offset = "0x77ABD80", VA = "0x1877AC980")]
	public BLMLJOJDCDB(GIALOMBGGLA PAHILCDKBDF, int KAJDCINBCAB, int CMMALJOJMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x77AC8F0", Offset = "0x77ABCF0", VA = "0x1877AC8F0")]
	public BLMLJOJDCDB(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x77AC480", Offset = "0x77AB880", VA = "0x1877AC480", Slot = "4")]
	public bool Equals(BLMLJOJDCDB KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x77AC530", Offset = "0x77AB930", VA = "0x1877AC530", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x71CA960", Offset = "0x71C9D60", VA = "0x1871CA960", Slot = "4")]
	public void GDCNGOALEGL(Transform KHDOKFIGIID, BFAEJFGLAMG LJGIAAILBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x77B5E30", Offset = "0x77B5230", VA = "0x1877B5E30", Slot = "5")]
	public BFAEJFGLAMG FMHEMKKGNOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x77B5F00", Offset = "0x77B5300", VA = "0x1877B5F00", Slot = "6")]
	public void JHBEOKNDOEB(BFAEJFGLAMG JCFCBLLGGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public AKGBPJONPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x77ABFA0", Offset = "0x77AB3A0", VA = "0x1877ABFA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x77B7550", Offset = "0x77B6950", VA = "0x1877B7550")]
	public bool HDGIMKJMCKA([In] NCKKDALILNC HPMNBNLACCC, bool JKEAAPJIEEP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x77B6F80", Offset = "0x77B6380", VA = "0x1877B6F80")]
	private bool FAFNBKPGBFN([In] NCKKDALILNC HPMNBNLACCC, bool JKEAAPJIEEP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x77B9360", Offset = "0x77B8760", VA = "0x1877B9360")]
	public PHCECDEGAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x77B7560", Offset = "0x77B6960", VA = "0x1877B7560", Slot = "5")]
	public void GDCNGOALEGL(JHEGFBAFKGM HEKFIEJNOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x77B9260", Offset = "0x77B8660", VA = "0x1877B9260", Slot = "17")]
	public void OCCKFCLFPLA(NALNABLIIOP ADLKPPBLCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x77B7A90", Offset = "0x77B6E90", VA = "0x1877B7A90", Slot = "12")]
	public void IPBLCOHEIEP(Func<GIALOMBGGLA, bool> DKJICCMMFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x77B7960", Offset = "0x77B6D60", VA = "0x1877B7960")]
	private void IPBLCOHEIEP(POAIIKBONGE BLGGFHHEDNC, Func<GIALOMBGGLA, bool> DKJICCMMFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x77B8B30", Offset = "0x77B7F30", VA = "0x1877B8B30", Slot = "11")]
	public void MLLJMJBBEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x77B5F70", Offset = "0x77B5370", VA = "0x1877B5F70", Slot = "8")]
	public bool AAJDACGLJCB(GIALOMBGGLA MJLLNIBDMFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x77B7F60", Offset = "0x77B7360", VA = "0x1877B7F60")]
	private bool KBDCODHONKE(GIALOMBGGLA ENJEEAOCKLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x77B7610", Offset = "0x77B6A10", VA = "0x1877B7610")]
	private static bool GDIPDJEMALE(GIALOMBGGLA ENJEEAOCKLB, POAIIKBONGE JOCLJNODKCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x77B8E70", Offset = "0x77B8270", VA = "0x1877B8E70")]
	private void OAOBNJFILII(Transform POGHLMICDEO, POAIIKBONGE DJCGDODEGPJ, POAIIKBONGE[] HAILNIMNHMG, GIALOMBGGLA JBNKDICFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x77B5F80", Offset = "0x77B5380", VA = "0x1877B5F80")]
	private BLMLJOJDCDB ACDJIMNBHBL(Transform HIJPDNBBCJF, BLMLJOJDCDB NDMEPLPFAPG)
	{
		return default(BLMLJOJDCDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x77B8CB0", Offset = "0x77B80B0", VA = "0x1877B8CB0")]
	private static bool NNIILJPDJFE(POAIIKBONGE JOCLJNODKCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x77B86A0", Offset = "0x77B7AA0", VA = "0x1877B86A0", Slot = "9")]
	public bool LHFBCKCDOJC(GIALOMBGGLA FINNEBDLIKE, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x77B64B0", Offset = "0x77B58B0", VA = "0x1877B64B0")]
	private bool DIFNMOHOGFK(GIALOMBGGLA FINNEBDLIKE, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x77B76C0", Offset = "0x77B6AC0", VA = "0x1877B76C0")]
	private static void GMALAHKHHNI(GIALOMBGGLA FINNEBDLIKE, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD, POAIIKBONGE DNHFFDOIIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x77B8A10", Offset = "0x77B7E10", VA = "0x1877B8A10")]
	private void MGKEDJFEANM(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x77B60D0", Offset = "0x77B54D0", VA = "0x1877B60D0")]
	private void AMJHGKLKLAF(POAIIKBONGE BLGGFHHEDNC, GIALOMBGGLA FHCFNDDNEKA, GIALOMBGGLA PLHEJCLJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x77B6140", Offset = "0x77B5540", VA = "0x1877B6140")]
	private void AMJHGKLKLAF(GIALOMBGGLA PAHILCDKBDF, GIALOMBGGLA FHCFNDDNEKA, GIALOMBGGLA PLHEJCLJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x77B6CB0", Offset = "0x77B60B0", VA = "0x1877B6CB0")]
	private void EIHAPBCMKOE(GIALOMBGGLA PAHILCDKBDF, GIALOMBGGLA FHCFNDDNEKA, GIALOMBGGLA PLHEJCLJJDJ, bool CGMCNLNMBNF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x77B6D20", Offset = "0x77B6120", VA = "0x1877B6D20")]
	private void EIHAPBCMKOE(POAIIKBONGE BKHMOJGGBFN, GIALOMBGGLA JBNKDICFKBE, GIALOMBGGLA IDAFMIJJHBF, bool CGMCNLNMBNF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x77B7840", Offset = "0x77B6C40", VA = "0x1877B7840")]
	private void ILBGMHGGONG(GIALOMBGGLA MKPPIPAJFEO, int PCNNCEPBCFO, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x77B6E20", Offset = "0x77B6220", VA = "0x1877B6E20")]
	private void EKBKBFPGCLN(PAPAPHPEFDL KLDFHLFOOFN, PAPAPHPEFDL KBDENKJGOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x77B8B50", Offset = "0x77B7F50", VA = "0x1877B8B50", Slot = "18")]
	public GIALOMBGGLA MPEAPEEELOG(GIALOMBGGLA PAHILCDKBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x77B7BB0", Offset = "0x77B6FB0", VA = "0x1877B7BB0", Slot = "13")]
	public void JIFJKGNBLJB(GIALOMBGGLA PAHILCDKBDF, HashSet<GIALOMBGGLA> OPENNKPKNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x77B8700", Offset = "0x77B7B00", VA = "0x1877B8700", Slot = "14")]
	public List<GIALOMBGGLA> LIHNKGMNHFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x77B8940", Offset = "0x77B7D40", VA = "0x1877B8940")]
	protected PAPAPHPEFDL MEOJGCHLLPI(PAPAPHPEFDL BLGGFHHEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x77B6340", Offset = "0x77B5740", VA = "0x1877B6340")]
	protected POAIIKBONGE[] CIILNFJOHOA(POAIIKBONGE JOCLJNODKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x77B7AA0", Offset = "0x77B6EA0", VA = "0x1877B7AA0")]
	protected bool JAPDCNHGNCM(GIALOMBGGLA PAHILCDKBDF, [Out] POAIIKBONGE BLGGFHHEDNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x77B6210", Offset = "0x77B5610", VA = "0x1877B6210", Slot = "15")]
	public bool BLANFHCCKFL(GIALOMBGGLA PAHILCDKBDF, [Out] BLMLJOJDCDB GDFPKNKMINE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x77B8660", Offset = "0x77B7A60", VA = "0x1877B8660")]
	protected POAIIKBONGE KEDKFHHOJJL(BLMLJOJDCDB KMGJEBJAAHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x77B61B0", Offset = "0x77B55B0", VA = "0x1877B61B0", Slot = "10")]
	public bool ANHJFMELCCG(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x77B6700", Offset = "0x77B5B00", VA = "0x1877B6700")]
	private bool EDJMCCKAEMH(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x77B63E0", Offset = "0x77B57E0", VA = "0x1877B63E0")]
	private static bool CLPGIKAACEA(POAIIKBONGE NHHCAODJMJJ, BLMLJOJDCDB IMEMOIBIIMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x77B7550", Offset = "0x77B6950", VA = "0x1877B7550", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3E1E0", Offset = "0xB3D5E0", VA = "0x180B3E1E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x116B970", Offset = "0x116AD70", VA = "0x18116B970")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MPMNNGFDLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1042FA0", Offset = "0x10423A0", VA = "0x181042FA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x24619B0", Offset = "0x2460DB0", VA = "0x1824619B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool PBIHHMGAACF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA> MPBGJFNEJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x77ADB70", Offset = "0x77ACF70", VA = "0x1877ADB70", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x77AECB0", Offset = "0x77AE0B0", VA = "0x1877AECB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA> CAJFMPCMEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x77AEAF0", Offset = "0x77ADEF0", VA = "0x1877AEAF0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x77AD8E0", Offset = "0x77ACCE0", VA = "0x1877AD8E0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<GIALOMBGGLA, GIALOMBGGLA, GIALOMBGGLA> BOLEENGKJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x77AEC50", Offset = "0x77AE050", VA = "0x1877AEC50", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x77ADA80", Offset = "0x77ACE80", VA = "0x1877ADA80", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x77AF350", Offset = "0x77AE750", VA = "0x1877AF350")]
	public EGLNCLDIOAJ(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x77AE260", Offset = "0x77AD660", VA = "0x1877AE260", Slot = "12")]
	public void GDCNGOALEGL(GameObject GIIGFIAPGGB, PPCNEMNACEB EKJGAENMCCM, EIEDNOCIOIA EAOHCPLNDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x77AEEC0", Offset = "0x77AE2C0", VA = "0x1877AEEC0", Slot = "26")]
	public void NLAAFKHBPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x77AF220", Offset = "0x77AE620", VA = "0x1877AF220", Slot = "13")]
	public void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x77AE870", Offset = "0x77ADC70", VA = "0x1877AE870", Slot = "14")]
	public void GEAMIGHEOPG(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x77AD670", Offset = "0x77ACA70", VA = "0x1877AD670", Slot = "15")]
	public void CHIPMKBMMMB(GIALOMBGGLA PAHILCDKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x77ADBD0", Offset = "0x77ACFD0", VA = "0x1877ADBD0", Slot = "22")]
	public bool EAKELEHMBLK(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x77ADC20", Offset = "0x77AD020", VA = "0x1877ADC20")]
	internal bool EDJMCCKAEMH([In] NCKKDALILNC HPMNBNLACCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x77AF0D0", Offset = "0x77AE4D0", VA = "0x1877AF0D0")]
	internal bool NMFNKLDDJPM([In] NCKKDALILNC HPMNBNLACCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x77ADD30", Offset = "0x77AD130", VA = "0x1877ADD30")]
	internal void EGPAOMAHMNN(GIALOMBGGLA PAHILCDKBDF, int AKKHBDOGNOA, bool JKEAAPJIEEP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x77AD670", Offset = "0x77ACA70", VA = "0x1877AD670")]
	internal bool AKBMIJFOOGH(GIALOMBGGLA OBAMHGICKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x77AEF90", Offset = "0x77AE390", VA = "0x1877AEF90")]
	internal bool NLGOLBMMODP(GIALOMBGGLA FINNEBDLIKE, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x77AEB50", Offset = "0x77ADF50", VA = "0x1877AEB50", Slot = "16")]
	public void JIFJKGNBLJB(GIALOMBGGLA PAHILCDKBDF, HashSet<GIALOMBGGLA> NHBDOBDDCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x77AD6D0", Offset = "0x77ACAD0", VA = "0x1877AD6D0", Slot = "17")]
	public void BCOABLGKKBE(GIALOMBGGLA FINNEBDLIKE, GIALOMBGGLA LDBKLKGEHOP, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x77AD940", Offset = "0x77ACD40", VA = "0x1877AD940", Slot = "18")]
	public void CHOHECMKAFC(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x77AE090", Offset = "0x77AD490", VA = "0x1877AE090", Slot = "19")]
	public void FPCIFJKFKHJ(GIALOMBGGLA IKMNICINOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x77AE890", Offset = "0x77ADC90", VA = "0x1877AE890")]
	public void HIHLMFGNFIM([Optional] EJNOMEECLJP MMLKDIBMELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x77ADAE0", Offset = "0x77ACEE0", VA = "0x1877ADAE0", Slot = "23")]
	public void DDNNPDDLBDB(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x77ADF10", Offset = "0x77AD310", VA = "0x1877ADF10", Slot = "20")]
	public BLLECNEFLJH EHPGLEGLOAK(bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x77AED10", Offset = "0x77AE110", VA = "0x1877AED10", Slot = "21")]
	public BLLECNEFLJH NJKCDLGBHAL(HashSet<Guid> KLLKBAEOAOD, bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x77AD630", Offset = "0x77ACA30", VA = "0x1877AD630", Slot = "25")]
	public void AGLNGCIBICA(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x77AF2A0", Offset = "0x77AE6A0", VA = "0x1877AF2A0", Slot = "24")]
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
	[Cpp2IlInjected.Address(RVA = "0x77ACBC0", Offset = "0x77ABFC0", VA = "0x1877ACBC0")]
	public CBAEHCHDBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	public void GDCNGOALEGL(EGLNCLDIOAJ HEKFIEJNOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x77ACB60", Offset = "0x77ABF60", VA = "0x1877ACB60")]
	public void ONGAPEGFIOK(GIALOMBGGLA KLDFHLFOOFN, GIALOMBGGLA MKPPIPAJFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x77ACA80", Offset = "0x77ABE80", VA = "0x1877ACA80")]
	public void BNDEHBLNGHD(GIALOMBGGLA KLDFHLFOOFN, GIALOMBGGLA MKPPIPAJFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x77ACAE0", Offset = "0x77ABEE0", VA = "0x1877ACAE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public BHNNLMNELNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x77AC230", Offset = "0x77AB630", VA = "0x1877AC230")]
	public void GDCNGOALEGL(EGLNCLDIOAJ HEKFIEJNOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x77AC1E0", Offset = "0x77AB5E0", VA = "0x1877AC1E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x77AC1F0", Offset = "0x77AB5F0", VA = "0x1877AC1F0")]
	private void FBACCNCBHAN(OLEMOLOENHO LGLPENFMNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x77AC170", Offset = "0x77AB570", VA = "0x1877AC170")]
	private void DIJINAIGFDH(EJNOMEECLJP NECMOJEKHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x77AC370", Offset = "0x77AB770", VA = "0x1877AC370")]
	public void MANOMJIGPED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x77AC060", Offset = "0x77AB460", VA = "0x1877AC060")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public DFENJMFHFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x77AD4C0", Offset = "0x77AC8C0", VA = "0x1877AD4C0")]
		internal EGLNCLDIOAJ DKPACFEEPGB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x77B27E0", Offset = "0x77B1BE0", VA = "0x1877B27E0")]
	public static void JDALAJCPJLE(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x77B29E0", Offset = "0x77B1DE0", VA = "0x1877B29E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x77B07E0", Offset = "0x77AFBE0", VA = "0x1877B07E0")]
	public GIJGNEEAJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x77B0000", Offset = "0x77AF400", VA = "0x1877B0000", Slot = "7")]
	public void GDCNGOALEGL(AIKNCDHHADG CHEHNOIOMFH, LKBAKKOJKCC CFONGFHMKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x77B0040", Offset = "0x77AF440", VA = "0x1877B0040", Slot = "5")]
	public void MJCJPKJMNCB(PAPAPHPEFDL LBFGPCDLOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x77AFE90", Offset = "0x77AF290", VA = "0x1877AFE90", Slot = "9")]
	public void FOHPINHNAHP(PAPAPHPEFDL FHCFIMCAOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x77AFB50", Offset = "0x77AEF50", VA = "0x1877AFB50", Slot = "8")]
	public void BIPINLOMDFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x77B0430", Offset = "0x77AF830", VA = "0x1877B0430", Slot = "10")]
	public void PFBNEMKOOIK(PAPAPHPEFDL OFJJJGMEJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x77AFD10", Offset = "0x77AF110", VA = "0x1877AFD10", Slot = "11")]
	public void EOLAKAPJDGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x77B0280", Offset = "0x77AF680", VA = "0x1877B0280")]
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
			[Cpp2IlInjected.Address(RVA = "0x77B1A50", Offset = "0x77B0E50", VA = "0x1877B1A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x77B20F0", Offset = "0x77B14F0", VA = "0x1877B20F0")]
		public GLHCGGHFAAN(POAIIKBONGE NAFLECONHBK, HashSet<Guid> KLLKBAEOAOD, bool GDPNNIPIDKK, [Optional] PGGPHIEPECH DGFPILPOBID, [Optional] PGGPHIEPECH LAKDAEGACEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x77B1F50", Offset = "0x77B1350", VA = "0x1877B1F50")]
		public PGGPHIEPECH PELCBGJOJPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x77B1820", Offset = "0x77B0C20", VA = "0x1877B1820")]
		private PGGPHIEPECH AHOFCOLGGFF([Out] PGGPHIEPECH GPANIOAIEED, [Out] PGGPHIEPECH JLKAONHCJED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x77B1D30", Offset = "0x77B1130", VA = "0x1877B1D30")]
		private PGGPHIEPECH OJPJLJNIEPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x77B18E0", Offset = "0x77B0CE0", VA = "0x1877B18E0")]
		private void GPNNAMEHOKD(PGGPHIEPECH AIAFHAIGJMH, PGGPHIEPECH AKKFBFLHBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x77B1B70", Offset = "0x77B0F70", VA = "0x1877B1B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x77B3530", Offset = "0x77B2930", VA = "0x1877B3530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool ILCFMAHFMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x77B4740", Offset = "0x77B3B40", VA = "0x1877B4740")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x77B4050", Offset = "0x77B3450", VA = "0x1877B4050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x77B3710", Offset = "0x77B2B10", VA = "0x1877B3710")]
	public void GDCNGOALEGL(EGLNCLDIOAJ HEKFIEJNOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x77B33C0", Offset = "0x77B27C0", VA = "0x1877B33C0")]
	public BLLECNEFLJH EHPGLEGLOAK(bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x77B4EE0", Offset = "0x77B42E0", VA = "0x1877B4EE0")]
	public BLLECNEFLJH NJKCDLGBHAL(HashSet<Guid> KLLKBAEOAOD, bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x77B2F80", Offset = "0x77B2380", VA = "0x1877B2F80")]
	public void DDNNPDDLBDB(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x77B5230", Offset = "0x77B4630", VA = "0x1877B5230")]
	public void PMOKCKDLFEM(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x77B2C30", Offset = "0x77B2030", VA = "0x1877B2C30")]
	public void BDDKDEHIEDF(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x77B42C0", Offset = "0x77B36C0", VA = "0x1877B42C0")]
	private void JPHIMGMIFFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x77B2D50", Offset = "0x77B2150", VA = "0x1877B2D50")]
	private PGGPHIEPECH CPDDEKEGBAD(POAIIKBONGE BLGGFHHEDNC, bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x77B4070", Offset = "0x77B3470", VA = "0x1877B4070")]
	private static void JMAOMFKEBFF(POAIIKBONGE BLGGFHHEDNC, bool GDPNNIPIDKK, PGGPHIEPECH INAPFKLHCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x77B4760", Offset = "0x77B3B60", VA = "0x1877B4760")]
	private void MFAEPDNHHIE(POAIIKBONGE BLGGFHHEDNC, bool GDPNNIPIDKK, PGGPHIEPECH INAPFKLHCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x77B4E50", Offset = "0x77B4250", VA = "0x1877B4E50")]
	private PGGPHIEPECH NENFLDDJGJB(POAIIKBONGE NAFLECONHBK, HashSet<Guid> KLLKBAEOAOD, bool GDPNNIPIDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x77B44B0", Offset = "0x77B38B0", VA = "0x1877B44B0")]
	private bool KAJLKCNCDFD(BLLECNEFLJH ODLECLOBCAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x77B3780", Offset = "0x77B2B80", VA = "0x1877B3780")]
	private bool HGFEJMMPJKC(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x77B5080", Offset = "0x77B4480", VA = "0x1877B5080")]
	private bool ONODCFBMECI(BLLECNEFLJH CHEHNOIOMFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x77B3010", Offset = "0x77B2410", VA = "0x1877B3010")]
	private static bool DEKDIKCKFEB(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x77B3130", Offset = "0x77B2530", VA = "0x1877B3130")]
	public static bool EAKELEHMBLK(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x77B4980", Offset = "0x77B3D80", VA = "0x1877B4980")]
	private GIALOMBGGLA MMNFCPGDLGB(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x77B4CD0", Offset = "0x77B40D0", VA = "0x1877B4CD0")]
	private GIALOMBGGLA MPJLIFDLMIP(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x77B50A0", Offset = "0x77B44A0", VA = "0x1877B50A0")]
	private GIALOMBGGLA PMAFMMMPNFK(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x77AAE40", Offset = "0x77AA240", VA = "0x1877AAE40")]
	private static Guid NNLKJPOJEPO(PGGPHIEPECH INAPFKLHCFN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x77B2C60", Offset = "0x77B2060", VA = "0x1877B2C60")]
	private string CKHLKEGHJGO(PGGPHIEPECH INAPFKLHCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x77B3580", Offset = "0x77B2980", VA = "0x1877B3580")]
	private bool EMGBPAABPBC(POAIIKBONGE BLGGFHHEDNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x77B3DF0", Offset = "0x77B31F0", VA = "0x1877B3DF0")]
	private static void IGKCHNIMAOK(POAIIKBONGE NAFLECONHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x77B5CF0", Offset = "0x77B50F0", VA = "0x1877B5CF0")]
		get
		{
			return default(BLMLJOJDCDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BLMLJOJDCDB EFPJDEOIFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x77B5D90", Offset = "0x77B5190", VA = "0x1877B5D90")]
		get
		{
			return default(BLMLJOJDCDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x77B5DC0", Offset = "0x77B51C0", VA = "0x1877B5DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public JLKAHGACOHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x77B26A0", Offset = "0x77B1AA0", VA = "0x1877B26A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x116B690", Offset = "0x116AA90", VA = "0x18116B690", Slot = "6")]
		get
		{
			return default(BLMLJOJDCDB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x116B370", Offset = "0x116A770", VA = "0x18116B370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private POAIIKBONGE KLDFHLFOOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9943C0", Offset = "0x9937C0", VA = "0x1809943C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x77B99D0", Offset = "0x77B8DD0", VA = "0x1877B99D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public PAPAPHPEFDL HBBFFDLJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9943C0", Offset = "0x9937C0", VA = "0x1809943C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GIALOMBGGLA FCBAHDJNKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool EGALAAOJBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x77B9E20", Offset = "0x77B9220", VA = "0x1877B9E20", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LKPLCFFDACE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x77B9680", Offset = "0x77B8A80", VA = "0x1877B9680", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected POAIIKBONGE BKHMOJGGBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x77B99B0", Offset = "0x77B8DB0", VA = "0x1877B99B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x77B9FB0", Offset = "0x77B93B0", VA = "0x1877B9FB0")]
	public POAIIKBONGE(BLMLJOJDCDB JHINHPGOMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x77B9CD0", Offset = "0x77B90D0", VA = "0x1877B9CD0")]
	public POAIIKBONGE OEHIFBKDANM(BLMLJOJDCDB FDBIDLLACFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x77B9E30", Offset = "0x77B9230", VA = "0x1877B9E30")]
	public POAIIKBONGE PCLCNOCBMLH(BLMLJOJDCDB LPOPNLLKHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x77B96D0", Offset = "0x77B8AD0", VA = "0x1877B96D0")]
	public POAIIKBONGE JEBJOEBLLEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x77B9530", Offset = "0x77B8930", VA = "0x1877B9530")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x77B9AB0", Offset = "0x77B8EB0", VA = "0x1877B9AB0")]
	public POAIIKBONGE NJADOLHOJJF(BLMLJOJDCDB BBFFOKPDHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x77B9B60", Offset = "0x77B8F60", VA = "0x1877B9B60")]
	private static void OCCKFCLFPLA(POAIIKBONGE PJJLHHFNOPJ, NALNABLIIOP EKJBIEIFIHC, bool LGEBPACBNGE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x77B9CC0", Offset = "0x77B90C0", VA = "0x1877B9CC0", Slot = "9")]
	public void OCCKFCLFPLA(NALNABLIIOP ADLKPPBLCIG, bool CGMCNLNMBNF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x77B98B0", Offset = "0x77B8CB0", VA = "0x1877B98B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x77AD530", Offset = "0x77AC930", VA = "0x1877AD530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object DNEPPKLGBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x77AD5F0", Offset = "0x77AC9F0", VA = "0x1877AD5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x77AD590", Offset = "0x77AC990", VA = "0x1877AD590")]
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
		[Cpp2IlInjected.Address(RVA = "0x77B0CA0", Offset = "0x77B00A0", VA = "0x1877B0CA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool LADPAGIBFDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x77B1030", Offset = "0x77B0430", VA = "0x1877B1030", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private PhotonView CODLDKPDACB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x77B1070", Offset = "0x77B0470", VA = "0x1877B1070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<OLEMOLOENHO> FBACCNCBHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x77B0A80", Offset = "0x77AFE80", VA = "0x1877B0A80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x77B0E30", Offset = "0x77B0230", VA = "0x1877B0E30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<EJNOMEECLJP> DIJINAIGFDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x77B0ED0", Offset = "0x77B02D0", VA = "0x1877B0ED0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x77B0F80", Offset = "0x77B0380", VA = "0x1877B0F80", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x77B09F0", Offset = "0x77AFDF0", VA = "0x1877B09F0", Slot = "10")]
	public void BECHPFCMIHE(EGLNCLDIOAJ HEKFIEJNOCO, EIEDNOCIOIA EAOHCPLNDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x77B0C50", Offset = "0x77B0050", VA = "0x1877B0C50", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x77B08C0", Offset = "0x77AFCC0", VA = "0x1877B08C0", Slot = "11")]
	public void BCOABLGKKBE(GIALOMBGGLA FINNEBDLIKE, GIALOMBGGLA LDBKLKGEHOP, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x77B0B20", Offset = "0x77AFF20", VA = "0x1877B0B20", Slot = "12")]
	public void CHOHECMKAFC(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x77B0D00", Offset = "0x77B0100", VA = "0x1877B0D00", Slot = "13")]
	public void FHMMEMEDNLG(BLLECNEFLJH PCDALIBGMOA, [Optional] EJNOMEECLJP MMLKDIBMELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x77B1350", Offset = "0x77B0750", VA = "0x1877B1350")]
	[JKGLLPCKFPN]
	private void RpcMasterReparentNodes(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x77B1150", Offset = "0x77B0550", VA = "0x1877B1150")]
	[JKGLLPCKFPN]
	private void RpcMasterModifyNode(GIALOMBGGLA FINNEBDLIKE, GIALOMBGGLA LDBKLKGEHOP, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x77B1720", Offset = "0x77B0B20", VA = "0x1877B1720")]
	[JKGLLPCKFPN]
	private void RpcReparentNodes(GIALOMBGGLA IKMNICINOEJ, int HDPJBCKDLME, GIALOMBGGLA BBFFOKPDHFL, int NJFHGHINMLA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD, KPLGNFFIKML LHHPHCOCHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x77B1660", Offset = "0x77B0A60", VA = "0x1877B1660")]
	[JKGLLPCKFPN]
	private void RpcModifyNode(GIALOMBGGLA FINNEBDLIKE, int PCNNCEPBCFO, int NPBBMEFNMOA, Vector3 LJELLFALGOA, Quaternion LGDKIOFOOMD, KPLGNFFIKML LHHPHCOCHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x77B1110", Offset = "0x77B0510", VA = "0x1877B1110")]
	[JKGLLPCKFPN]
	private void RpcDeserializeConnectableGraph(BLLECNEFLJH CHEHNOIOMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x77B54A0", Offset = "0x77B48A0", VA = "0x1877B54A0", Slot = "4")]
		private void IBHIGNEEECN(GIALOMBGGLA AJMKLPHBAIP, BLMLJOJDCDB MKPPIPAJFEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x77B5880", Offset = "0x77B4C80", VA = "0x1877B5880", Slot = "5")]
		private void MBOKALCOAHA(GIALOMBGGLA AJMKLPHBAIP, BLMLJOJDCDB MKPPIPAJFEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x77B5340", Offset = "0x77B4740", VA = "0x1877B5340", Slot = "6")]
		private void AMPBCMLCKMC(GIALOMBGGLA AJMKLPHBAIP, BLMLJOJDCDB MKPPIPAJFEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x77B5620", Offset = "0x77B4A20", VA = "0x1877B5620", Slot = "7")]
		private void IOJGEBPHANO(GIALOMBGGLA AJMKLPHBAIP, BLMLJOJDCDB MKPPIPAJFEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x77B5810", Offset = "0x77B4C10", VA = "0x1877B5810", Slot = "8")]
		private BFAEJFGLAMG JFPDJKNDIPK(Transform KHDOKFIGIID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x77B5AF0", Offset = "0x77B4EF0", VA = "0x1877B5AF0", Slot = "9")]
		private void PDACOHOHAPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class ONDDGOCPLPD
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3803DB0", Offset = "0x38031B0", VA = "0x183803DB0")]
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
