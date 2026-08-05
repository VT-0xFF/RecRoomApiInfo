using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8377F30", Offset = "0x8376530", VA = "0x188377F30", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x23A8580", Offset = "0x23A6B80", VA = "0x1823A8580", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83830D0", Offset = "0x83816D0", VA = "0x1883830D0")]
		private void DHALDHDBNEP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8383240", Offset = "0x8381840", VA = "0x188383240")]
		private void FAEKOOMPDOO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83833B0", Offset = "0x83819B0", VA = "0x1883833B0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83836F0", Offset = "0x8381CF0", VA = "0x1883836F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class NFCBBBNCGLP : CDBBJJFMOLB, LKJPKMELKMK
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class OBMDHJGOJII : IEnumerable<IIGHBLCNCNA>, IEnumerable, IEnumerator<IIGHBLCNCNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IIGHBLCNCNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private JPDMABGMGFC localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public JPDMABGMGFC <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NFCBBBNCGLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OBECOIDGDPJ <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private KBNDPJOLEPO <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private KBNDPJOLEPO.BLLHFLPDGAJ <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private IIGHBLCNCNA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x101AE80", Offset = "0x1019480", VA = "0x18101AE80")]
		[DebuggerHidden]
		public OBMDHJGOJII(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x837D740", Offset = "0x837BD40", VA = "0x18837D740", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x837D2C0", Offset = "0x837B8C0", VA = "0x18837D2C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x837D620", Offset = "0x837BC20", VA = "0x18837D620")]
		private void OFOMAIJNFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x837D2A0", Offset = "0x837B8A0", VA = "0x18837D2A0")]
		private void LGNDDFAIONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x837D6F0", Offset = "0x837BCF0", VA = "0x18837D6F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x837D640", Offset = "0x837BC40", VA = "0x18837D640", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IIGHBLCNCNA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x837D640", Offset = "0x837BC40", VA = "0x18837D640", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class COCOFGKOPJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public NFCBBBNCGLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CMAGLMFPMPA nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public COCOFGKOPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8372180", Offset = "0x8370780", VA = "0x188372180")]
		internal object OMFBHNOGOMI(CMAGLMFPMPA x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NPOFAKLIMNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public CMAGLMFPMPA child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public COCOFGKOPJM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public NPOFAKLIMNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x837D050", Offset = "0x837B650", VA = "0x18837D050")]
		internal object IADOMEOJPBJ((CMAGLMFPMPA child, CMAGLMFPMPA nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly IDGHEFJHGEI DLELGBKJNDN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly IDGHEFJHGEI CNPMPCAFOGG;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly IDGHEFJHGEI AMOHCLJMACN;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly IDGHEFJHGEI EHNFNJKHFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private LCOKMAMHPKO OMPFPBCIGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private PJMIJJNNDLG OFEABOHNFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private CMLIPCHHEFN MKHJKMPBFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private JKNKBHHCPFH KEBEIAGOJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private BKHALAPJAAA JIFMDBMKDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private ACGCFACLMIE NIHCLMKPBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly EFOHDDHICHK MMELACBKGMD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AFNNFFJLAHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA99370", Offset = "0xA97970", VA = "0x180A99370", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA99260", Offset = "0xA97860", VA = "0x180A99260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MAJOCFFOAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<IIGHBLCNCNA, IIGHBLCNCNA> POGDGFMMAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x837C330", Offset = "0x837A930", VA = "0x18837C330", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x837B060", Offset = "0x8379660", VA = "0x18837B060", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<IIGHBLCNCNA, IIGHBLCNCNA> AJNMKPGNDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x837C7B0", Offset = "0x837ADB0", VA = "0x18837C7B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x837B8B0", Offset = "0x8379EB0", VA = "0x18837B8B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<IIGHBLCNCNA, IIGHBLCNCNA, IIGHBLCNCNA> DIDDGGKIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8379A80", Offset = "0x8378080", VA = "0x188379A80", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8378800", Offset = "0x8376E00", VA = "0x188378800", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x837CFE0", Offset = "0x837B5E0", VA = "0x18837CFE0")]
	public NFCBBBNCGLP(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x837C030", Offset = "0x837A630", VA = "0x18837C030", Slot = "12")]
	public void LJDCNOCKLGC(GameObject EGMHLHLEIMH, DPCKNPAAMHC PBGOOAKMMJG, EOBHCIBIAGN MFKMLFFHCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x837C860", Offset = "0x837AE60", VA = "0x18837C860", Slot = "26")]
	public void PILPLNBAOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x83787B0", Offset = "0x8376DB0", VA = "0x1883787B0", Slot = "22")]
	public bool BPKAAKHCHOH(CMAGLMFPMPA EBEOEHAALNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x837CC60", Offset = "0x837B260", VA = "0x18837CC60")]
	private void POPKHBKENGN(JPDMABGMGFC FOEFDCGHIEB, JPDMABGMGFC KFIJMOLBOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x837B960", Offset = "0x8379F60", VA = "0x18837B960")]
	private void IOGGHCHCPAN(JPDMABGMGFC FOEFDCGHIEB, JPDMABGMGFC PAEBPAHGPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x837B110", Offset = "0x8379710", VA = "0x18837B110")]
	private void IGLNIGFJFEM(JPDMABGMGFC FOEFDCGHIEB, JPDMABGMGFC PAEBPAHGPFO, JPDMABGMGFC KFIJMOLBOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8379150", Offset = "0x8377750", VA = "0x188379150")]
	private void CCFBCAEHGID(JPDMABGMGFC FOEFDCGHIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "13")]
	public void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8378E50", Offset = "0x8377450", VA = "0x188378E50", Slot = "14")]
	public void CBPAAEAGBMC(IIGHBLCNCNA MDFAACGKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "15")]
	public void EEAAOMNILHP(IIGHBLCNCNA MDFAACGKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x83797E0", Offset = "0x8377DE0", VA = "0x1883797E0", Slot = "17")]
	public void EFCCPFPOBEA(IIGHBLCNCNA MDFAACGKJPJ, IIGHBLCNCNA EKGIILBOMMM, Vector3 AEDFHMKGLON, Quaternion IOCPNAEAJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8379940", Offset = "0x8377F40", VA = "0x188379940")]
	public void EFCCPFPOBEA(JPDMABGMGFC OGHJJFPEOAI, JPDMABGMGFC EKGIILBOMMM, Vector3 AEDFHMKGLON, Quaternion IOCPNAEAJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8378530", Offset = "0x8376B30", VA = "0x188378530")]
	public void ABAEBIHGNDP(IIGHBLCNCNA MDFAACGKJPJ, float FHGHMAANLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x837B610", Offset = "0x8379C10", VA = "0x18837B610", Slot = "18")]
	public void IMJALKNJIPA(IIGHBLCNCNA KFBOADKBPNL, int PNHLMLELFEG, IIGHBLCNCNA KILOAOLHHCP, int ICHAFMACBDM, Vector3 AEDFHMKGLON, Quaternion IOCPNAEAJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8379D10", Offset = "0x8378310", VA = "0x188379D10")]
	private float FNKOAEANBDE(JPDMABGMGFC OGHJJFPEOAI, JPDMABGMGFC IGDHFGFJBMG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x837B770", Offset = "0x8379D70", VA = "0x18837B770")]
	public void IMJALKNJIPA(JPDMABGMGFC OGHJJFPEOAI, JPDMABGMGFC IGDHFGFJBMG, Vector3 AEDFHMKGLON, Quaternion IOCPNAEAJJE, bool BOBFACILGFA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x837BD30", Offset = "0x837A330", VA = "0x18837BD30", Slot = "19")]
	public void LDIANHCICCM(IIGHBLCNCNA MDFAACGKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x837CA50", Offset = "0x837B050", VA = "0x18837CA50", Slot = "16")]
	public void PJLGPCDKOGD(IIGHBLCNCNA MDFAACGKJPJ, HashSet<IIGHBLCNCNA> HOBNALNHKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "20")]
	public GFDCAABEMHM IKDKHJPILEP(bool PMCBCINGJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "21")]
	public GFDCAABEMHM EJJNODIJKJC(HashSet<Guid> ONDDCGNNKEJ, bool PMCBCINGJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8378740", Offset = "0x8376D40", VA = "0x188378740", Slot = "23")]
	public void BJFOMPCOFHA(GFDCAABEMHM OHEEMHHMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x837C2C0", Offset = "0x837A8C0", VA = "0x18837C2C0", Slot = "24")]
	public void LJMPPEPJCKN(GFDCAABEMHM OHEEMHHMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x837BB80", Offset = "0x837A180", VA = "0x18837BB80", Slot = "25")]
	public void JABMBIAPMLD(GFDCAABEMHM OHEEMHHMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x837AC60", Offset = "0x8379260", VA = "0x18837AC60")]
	private void IABBOIGMHHN(JPDMABGMGFC OGHJJFPEOAI, JPDMABGMGFC IGDHFGFJBMG, Vector3 AEDFHMKGLON, Quaternion IOCPNAEAJJE, float FHGHMAANLMC, bool BOBFACILGFA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x837A350", Offset = "0x8378950", VA = "0x18837A350")]
	private void HHHJCBJBBGD(JPDMABGMGFC OGHJJFPEOAI, JPDMABGMGFC GHOEBAIBIJA, Vector3 AEDFHMKGLON, Quaternion IOCPNAEAJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8379DC0", Offset = "0x83783C0", VA = "0x188379DC0")]
	private void GGJIMDGKLKG(JPDMABGMGFC OGHJJFPEOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8379560", Offset = "0x8377B60", VA = "0x188379560")]
	[IteratorStateMachine(typeof(OBMDHJGOJII))]
	public IEnumerable<IIGHBLCNCNA> COLHEFDFLMG(JPDMABGMGFC DLICMGKJENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8379E70", Offset = "0x8378470", VA = "0x188379E70")]
	internal IIGHBLCNCNA HGCBBANNIDF(JPDMABGMGFC DLICMGKJENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x837B370", Offset = "0x8379970", VA = "0x18837B370")]
	internal JPDMABGMGFC IKAGPECJIDK(IIGHBLCNCNA MDFAACGKJPJ)
	{
		return default(JPDMABGMGFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x83788B0", Offset = "0x8376EB0", VA = "0x1883788B0")]
	private bool CBAPDJDODBJ(CMAGLMFPMPA EBEOEHAALNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x837C660", Offset = "0x837AC60", VA = "0x18837C660")]
	private bool OHGJIJEDCHJ(CMAGLMFPMPA EBEOEHAALNF, [Out] IIGHBLCNCNA IGDHFGFJBMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8379FA0", Offset = "0x83785A0", VA = "0x188379FA0")]
	private IIGHBLCNCNA HGCBBANNIDF(CMAGLMFPMPA EBEOEHAALNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x83785C0", Offset = "0x8376BC0", VA = "0x1883785C0")]
	private IIGHBLCNCNA ADIKMEKOJJN(CMAGLMFPMPA EBEOEHAALNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8379B30", Offset = "0x8378130", VA = "0x188379B30")]
	private IIGHBLCNCNA FDJEIGAHJBO(CMAGLMFPMPA EBEOEHAALNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8379E30", Offset = "0x8378430", VA = "0x188379E30")]
	private static Guid GJEHOODAOGJ(CMAGLMFPMPA EBEOEHAALNF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x837C6C0", Offset = "0x837ACC0", VA = "0x18837C6C0")]
	private string OLNJIDAKNAK(CMAGLMFPMPA EBEOEHAALNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x837BEA0", Offset = "0x837A4A0", VA = "0x18837BEA0")]
	private void LDNAKFKIIJE(IIGHBLCNCNA OGHJJFPEOAI, IIGHBLCNCNA GHOEBAIBIJA, RigidTransform CDOMFLOAMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x83795F0", Offset = "0x8377BF0", VA = "0x1883795F0")]
	private void DFFEDEHLLBP(IIGHBLCNCNA GHOEBAIBIJA, IIGHBLCNCNA OGHJJFPEOAI, RigidTransform CDOMFLOAMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8379780", Offset = "0x8377D80", VA = "0x188379780")]
	private void DNDOAMONGEI(IIGHBLCNCNA AMAKHBDINOP, IIGHBLCNCNA OGHJJFPEOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x837BBA0", Offset = "0x837A1A0", VA = "0x18837BBA0")]
	private void KPGPLJEIBMD(IIGHBLCNCNA OGHJJFPEOAI, IIGHBLCNCNA IGDHFGFJBMG, RigidTransform CDOMFLOAMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x837B500", Offset = "0x8379B00", VA = "0x18837B500")]
	private void ILAIEFOGMFD(JPDMABGMGFC DLICMGKJENE, IIGHBLCNCNA MDFAACGKJPJ, JPDMABGMGFC PAEBPAHGPFO, JPDMABGMGFC KFIJMOLBOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x837C3E0", Offset = "0x837A9E0", VA = "0x18837C3E0")]
	private void NNHEACHDHPE(JPDMABGMGFC DLICMGKJENE, IIGHBLCNCNA MDFAACGKJPJ, IIGHBLCNCNA FIKFPMIKOFD, IIGHBLCNCNA PMBAFINBOGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ODKLBKMCBFH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HDPBGAAIBBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CFPMHDJNIAH container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public HDPBGAAIBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8374750", Offset = "0x8372D50", VA = "0x188374750")]
		internal NFCBBBNCGLP GLECFDJKOND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x837D820", Offset = "0x837BE20", VA = "0x18837D820")]
	public static void BHEMFLFCLAO(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x837D9A0", Offset = "0x837BFA0", VA = "0x18837D9A0")]
	public static void GAIEDPHGGHP(CFPMHDJNIAH LOLOEONEEKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JHIECAPKJGH : PCCIFJNDNHP, MNLCALMNEKH
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly NFCBBBNCGLP JPFBPPJJBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly CHGPELGBKBO EGCJDBMLGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly PNBNNPNFKDH KEBEIAGOJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly CNLFHCBNPPO[] COGIDPLJNBB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IIGHBLCNCNA JDIKKFFKJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8376610", Offset = "0x8374C10", VA = "0x188376610", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IIGHBLCNCNA FPAIDIDCJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x83755D0", Offset = "0x8373BD0", VA = "0x1883755D0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 NCLNPCJGAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8374FB0", Offset = "0x83735B0", VA = "0x188374FB0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion MJBBODPOENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x83756E0", Offset = "0x8373CE0", VA = "0x1883756E0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BCADMGPOHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8375740", Offset = "0x8373D40", VA = "0x188375740", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<IIGHBLCNCNA> MJHIEFDNBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8374B90", Offset = "0x8373190", VA = "0x188374B90", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool IHJMHOBAEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xD94690", Offset = "0xD92C90", VA = "0x180D94690", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xDB03D0", Offset = "0xDAE9D0", VA = "0x180DB03D0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform ADNKINOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8376810", Offset = "0x8374E10", VA = "0x188376810", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject OKIANKCJMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8376530", Offset = "0x8374B30", VA = "0x188376530", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8376550", Offset = "0x8374B50", VA = "0x188376550", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid IDIPFPAPFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8376670", Offset = "0x8374C70", VA = "0x188376670", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GOIAKMIFKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8376750", Offset = "0x8374D50", VA = "0x188376750", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool KEEBPOECDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool COEELAHHOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83762E0", Offset = "0x83748E0", VA = "0x1883762E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event HNNKPEJNAHI DPLMGDNMFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8375A00", Offset = "0x8374000", VA = "0x188375A00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8374AD0", Offset = "0x83730D0", VA = "0x188374AD0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HNNKPEJNAHI KEMCFKHEEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8375880", Offset = "0x8373E80", VA = "0x188375880", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8376220", Offset = "0x8374820", VA = "0x188376220", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HNNKPEJNAHI HEODIEJBFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8374B30", Offset = "0x8373130", VA = "0x188374B30", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8376280", Offset = "0x8374880", VA = "0x188376280", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event GNCIPJCJFHD LOHGMEHHMOO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8375960", Offset = "0x8373F60", VA = "0x188375960", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8375E70", Offset = "0x8374470", VA = "0x188375E70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8376430", Offset = "0x8374A30", VA = "0x188376430")]
	public JHIECAPKJGH(JPDMABGMGFC IEIKHLNDANP, RigidbodyEx IJBOEHJOLPI, CHGPELGBKBO EGCJDBMLGHD, CNLFHCBNPPO[] COGIDPLJNBB, PNBNNPNFKDH KEBEIAGOJJF, CDBBJJFMOLB JPFBPPJJBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x83755A0", Offset = "0x8373BA0", VA = "0x1883755A0", Slot = "19")]
	public void IPAAAFNGFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "21")]
	public void GKHNJPCNPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x808C960", Offset = "0x808AF60", VA = "0x18808C960", Slot = "22")]
	public void GEDHLAHHOPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8375690", Offset = "0x8373C90", VA = "0x188375690", Slot = "20")]
	public void JKGHENBEODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8375340", Offset = "0x8373940", VA = "0x188375340", Slot = "25")]
	public void ICIAGCJMAAG(int EJMIMPEFPMI, IIGHBLCNCNA KILOAOLHHCP, int FFLELLPDBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x83757B0", Offset = "0x8373DB0", VA = "0x1883757B0", Slot = "26")]
	public void LGHFGONGMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8375010", Offset = "0x8373610", VA = "0x188375010", Slot = "27")]
	public void IANBIPKDODN(int EJMIMPEFPMI, IIGHBLCNCNA KFBOADKBPNL, int AIGOGADNONM, [Optional] Vector3? LHFBMPAOFLB, [Optional] Quaternion? IOLHEIDKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x83758E0", Offset = "0x8373EE0", VA = "0x1883758E0", Slot = "28")]
	public void MEHLGEKCGKP(IIGHBLCNCNA KFBOADKBPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8375A60", Offset = "0x8374060", VA = "0x188375A60", Slot = "31")]
	public void NHFBGKDBHBN(Vector3 GPBGIKGFGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8375F10", Offset = "0x8374510", VA = "0x188375F10", Slot = "29")]
	public void ODGMPPMKKBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8374DC0", Offset = "0x83733C0", VA = "0x188374DC0", Slot = "30")]
	public void HOBEPKCHBBC(int LEPAEEGOBDO, Vector3 DPLNHDFCMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8374CF0", Offset = "0x83732F0", VA = "0x188374CF0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int EJMIMPEFPMI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8374BC0", Offset = "0x83731C0", VA = "0x188374BC0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int EJMIMPEFPMI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xB15E40", Offset = "0xB14440", VA = "0x180B15E40", Slot = "42")]
	public Color GetConnectionSlotColor(int EJMIMPEFPMI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8374A30", Offset = "0x8373030", VA = "0x188374A30", Slot = "43")]
	public bool CanConnectTo(int EJMIMPEFPMI, IIGHBLCNCNA MLNBMDDMMPP, int GFNLDKFJGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "44")]
	public void ParentChanged(int EJMIMPEFPMI, IIGHBLCNCNA NJMDBNIGLMF, int HKIIHLKJHAD, Vector3 CAHMOIMLGGK, Quaternion CBCMBMAOPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "45")]
	public void ChildAdded(int EJMIMPEFPMI, IIGHBLCNCNA IEFBKGAMBGO, int PJCMGHLINFL, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "46")]
	public void ChildRemoved(int EJMIMPEFPMI, IIGHBLCNCNA ILLFFOCANLC, int FAFNLOKBJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "47")]
	public void ConnectionModified(int EJMIMPEFPMI, IIGHBLCNCNA KILOAOLHHCP, int FFLELLPDBPD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8376380", Offset = "0x8374980", VA = "0x188376380", Slot = "48")]
	public void RootChanged(IIGHBLCNCNA PHGPNIICMOK, IIGHBLCNCNA GHLOHKDEPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x83752F0", Offset = "0x83738F0", VA = "0x1883752F0", Slot = "23")]
	public void IBNEGOHOCIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8376330", Offset = "0x8374930", VA = "0x188376330", Slot = "24")]
	public void PPDBEEIHBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8375550", Offset = "0x8373B50", VA = "0x188375550")]
	private void IEIJFIJGNLA(bool DEGDDPIDPND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(EACLJNGLLNL), new string[] { })]
public class FEDGNHFBCJK : EACLJNGLLNL, FCOEENGBKBM, CEJIANFMEIL
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class APKPPACONLD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public APKPPACONLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private LHABKLEDKNO AEAKONLNGGP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object FMNGNGFCJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83736B0", Offset = "0x8371CB0", VA = "0x1883736B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8373660", Offset = "0x8371C60", VA = "0x188373660", Slot = "5")]
	private void BFPDDFBJGNA(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1316140", Offset = "0x1314740", VA = "0x181316140", Slot = "6")]
	private void KMJKAGKKLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FEDGNHFBCJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(CDBBJJFMOLB), new string[] { "Ignore", "Mock" })]
public class DFMCIMNCPLC : CDBBJJFMOLB, LKJPKMELKMK
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool AFNNFFJLAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MAJOCFFOAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<IIGHBLCNCNA, IIGHBLCNCNA> POGDGFMMAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83725C0", Offset = "0x8370BC0", VA = "0x1883725C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8372460", Offset = "0x8370A60", VA = "0x188372460", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<IIGHBLCNCNA, IIGHBLCNCNA> AJNMKPGNDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8372670", Offset = "0x8370C70", VA = "0x188372670", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8372510", Offset = "0x8370B10", VA = "0x188372510", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<IIGHBLCNCNA, IIGHBLCNCNA, IIGHBLCNCNA> DIDDGGKIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x83723B0", Offset = "0x83709B0", VA = "0x1883723B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8372300", Offset = "0x8370900", VA = "0x188372300", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "26")]
	public void PILPLNBAOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "12")]
	public void LJDCNOCKLGC(GameObject EGMHLHLEIMH, DPCKNPAAMHC PBGOOAKMMJG, EOBHCIBIAGN JMAJHFFOBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "13")]
	public void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "14")]
	public void CBPAAEAGBMC(IIGHBLCNCNA MDFAACGKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "15")]
	public void EEAAOMNILHP(IIGHBLCNCNA MDFAACGKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "16")]
	public void PJLGPCDKOGD(IIGHBLCNCNA MDFAACGKJPJ, HashSet<IIGHBLCNCNA> HOBNALNHKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "17")]
	public void EFCCPFPOBEA(IIGHBLCNCNA MDFAACGKJPJ, IIGHBLCNCNA EKGIILBOMMM, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "18")]
	public void IMJALKNJIPA(IIGHBLCNCNA MDFAACGKJPJ, int MPCCGJMGOBP, IIGHBLCNCNA GHOEBAIBIJA, int HKIIHLKJHAD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "19")]
	public void LDIANHCICCM(IIGHBLCNCNA MDFAACGKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "20")]
	public GFDCAABEMHM IKDKHJPILEP(bool PMCBCINGJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "21")]
	public GFDCAABEMHM EJJNODIJKJC(HashSet<Guid> ONDDCGNNKEJ, bool PMCBCINGJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "22")]
	public bool BPKAAKHCHOH(CMAGLMFPMPA EBEOEHAALNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "23")]
	public void BJFOMPCOFHA(GFDCAABEMHM OHEEMHHMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "24")]
	public void LJMPPEPJCKN(GFDCAABEMHM OHEEMHHMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "25")]
	public void JABMBIAPMLD(GFDCAABEMHM OHEEMHHMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public DFMCIMNCPLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IIGHBLCNCNA : MNLCALMNEKH, IEquatable<IIGHBLCNCNA>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MNLCALMNEKH
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	IIGHBLCNCNA JDIKKFFKJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform ADNKINOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject OKIANKCJMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid IDIPFPAPFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int GOIAKMIFKDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KEEBPOECDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int EJMIMPEFPMI);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int EJMIMPEFPMI);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int EJMIMPEFPMI);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int EJMIMPEFPMI, IIGHBLCNCNA MLNBMDDMMPP, int LPLHOPDCGJJ);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int EJMIMPEFPMI, IIGHBLCNCNA NJMDBNIGLMF, int HKIIHLKJHAD, Vector3 CAHMOIMLGGK, Quaternion CBCMBMAOPNO);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int EJMIMPEFPMI, IIGHBLCNCNA IEFBKGAMBGO, int PJCMGHLINFL, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int EJMIMPEFPMI, IIGHBLCNCNA ILLFFOCANLC, int FAFNLOKBJNA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int EJMIMPEFPMI, IIGHBLCNCNA KILOAOLHHCP, int GGNMCMIHOCK, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(IIGHBLCNCNA PHGPNIICMOK, IIGHBLCNCNA GHLOHKDEPIL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CDBBJJFMOLB : LKJPKMELKMK
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool AFNNFFJLAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MAJOCFFOAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<IIGHBLCNCNA, IIGHBLCNCNA> POGDGFMMAJE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<IIGHBLCNCNA, IIGHBLCNCNA> AJNMKPGNDHB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<IIGHBLCNCNA, IIGHBLCNCNA, IIGHBLCNCNA> DIDDGGKIMNL;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LJDCNOCKLGC(GameObject EGMHLHLEIMH, DPCKNPAAMHC PBGOOAKMMJG, EOBHCIBIAGN MNDLJJPPILO);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FLHPFKIPOFF();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CBPAAEAGBMC(IIGHBLCNCNA MDFAACGKJPJ);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EEAAOMNILHP(IIGHBLCNCNA MDFAACGKJPJ);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PJLGPCDKOGD(IIGHBLCNCNA MDFAACGKJPJ, HashSet<IIGHBLCNCNA> HOBNALNHKAF);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EFCCPFPOBEA(IIGHBLCNCNA MDFAACGKJPJ, IIGHBLCNCNA EKGIILBOMMM, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IMJALKNJIPA(IIGHBLCNCNA MDFAACGKJPJ, int MPCCGJMGOBP, IIGHBLCNCNA GHOEBAIBIJA, int HKIIHLKJHAD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LDIANHCICCM(IIGHBLCNCNA MDFAACGKJPJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	GFDCAABEMHM IKDKHJPILEP(bool PMCBCINGJML);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	GFDCAABEMHM EJJNODIJKJC(HashSet<Guid> ONDDCGNNKEJ, bool PMCBCINGJML);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool BPKAAKHCHOH(CMAGLMFPMPA EBEOEHAALNF);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BJFOMPCOFHA(GFDCAABEMHM OHEEMHHMAGD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LJMPPEPJCKN(GFDCAABEMHM OHEEMHHMAGD);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JABMBIAPMLD(GFDCAABEMHM OHEEMHHMAGD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JKNKBHHCPFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DOGCGDIFJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IIGHBLCNCNA FDJEIGAHJBO(int MMPGCDHOELA);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IIGHBLCNCNA ADIKMEKOJJN(Guid BLAMCOLBMKE);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OOGFJPHIAIH(IIGHBLCNCNA MDFAACGKJPJ);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KMDLEMGGIOP();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LPLFDJKCJOP(IIGHBLCNCNA EGCJDBMLGHD);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface PNBNNPNFKDH
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool COEELAHHOIC(CHGPELGBKBO EGCJDBMLGHD);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EEJKPOAGCBN(CHGPELGBKBO EGCJDBMLGHD);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string LDCEJGJNHPG(CHGPELGBKBO EGCJDBMLGHD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PGENPGJPCCF(CHGPELGBKBO EGCJDBMLGHD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FMNABBABCPJ(CHGPELGBKBO EGCJDBMLGHD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FNCEBBCHHII(CHGPELGBKBO EGCJDBMLGHD);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void HNNKPEJNAHI(IIGHBLCNCNA KFBOADKBPNL, int PKNODKBHHFC, IIGHBLCNCNA KILOAOLHHCP, int BLGPNOOIEOK, [Optional] Vector3? LHFBMPAOFLB, [Optional] Quaternion? IOLHEIDKEPJ);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void GNCIPJCJFHD(IIGHBLCNCNA PHGPNIICMOK, IIGHBLCNCNA GHLOHKDEPIL);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CHGPELGBKBO : IIGHBLCNCNA, MNLCALMNEKH, IEquatable<IIGHBLCNCNA>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PCCIFJNDNHP : MNLCALMNEKH
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IIGHBLCNCNA FPAIDIDCJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<IIGHBLCNCNA> MJHIEFDNBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 NCLNPCJGAGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion MJBBODPOENA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool BCADMGPOHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool IHJMHOBAEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event HNNKPEJNAHI DPLMGDNMFGP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event HNNKPEJNAHI KEMCFKHEEKB;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event HNNKPEJNAHI HEODIEJBFMF;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event GNCIPJCJFHD LOHGMEHHMOO;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IPAAAFNGFFP();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JKGHENBEODP();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GKHNJPCNPGC();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GEDHLAHHOPE();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IBNEGOHOCIG();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PPDBEEIHBPP();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ICIAGCJMAAG(int EJMIMPEFPMI, IIGHBLCNCNA KILOAOLHHCP, int FFLELLPDBPD);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LGHFGONGMJF();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void IANBIPKDODN(int EJMIMPEFPMI, IIGHBLCNCNA KFBOADKBPNL, int AIGOGADNONM, [Optional] Vector3? LHFBMPAOFLB, [Optional] Quaternion? IOLHEIDKEPJ);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MEHLGEKCGKP(IIGHBLCNCNA KFBOADKBPNL);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void ODGMPPMKKBK();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HOBEPKCHBBC(int LEPAEEGOBDO, Vector3 DPLNHDFCMOI);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NHFBGKDBHBN(Vector3 GPBGIKGFGNM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CNLFHCBNPPO
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 BKDMLMMHPPD
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
public interface DPCKNPAAMHC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool KCLHMMPJOEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FNNJLMJJNEI MABHFNLDLOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, DPCKNPAAMHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[FormerlySerializedAs("linkVisualPrefab")]
		[SerializeField]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAEAC60", Offset = "0xAE9260", VA = "0x180AEAC60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public FNNJLMJJNEI LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x83721F0", Offset = "0x83707F0", VA = "0x1883721F0")]
		public static ConnectableConfigData LCMOAGNOBKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x83722B0", Offset = "0x83708B0", VA = "0x1883722B0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual AAGPFPGKLDM, bool LPDHKOLOALN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct EMDPGDILFHJ : IEquatable<EMDPGDILFHJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IIGHBLCNCNA MDFAACGKJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int JLKLAKIGBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int GGNMCMIHOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 LHFBMPAOFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion IOLHEIDKEPJ;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8372CD0", Offset = "0x83712D0", VA = "0x188372CD0")]
	public EMDPGDILFHJ(IIGHBLCNCNA MDFAACGKJPJ, int JLKLAKIGBEB, int GGNMCMIHOCK, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8372C30", Offset = "0x8371230", VA = "0x188372C30")]
	public EMDPGDILFHJ(IIGHBLCNCNA MDFAACGKJPJ, int JLKLAKIGBEB, int GGNMCMIHOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8372BA0", Offset = "0x83711A0", VA = "0x188372BA0")]
	public EMDPGDILFHJ(IIGHBLCNCNA MDFAACGKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8372720", Offset = "0x8370D20", VA = "0x188372720", Slot = "4")]
	public bool Equals(EMDPGDILFHJ IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x83727D0", Offset = "0x8370DD0", VA = "0x1883727D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class JIJCENCOPOO : DMAKIHEBOCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform JAHKFPBBGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private FNNJLMJJNEI MONCKMMJHAL;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7CF6DA0", Offset = "0x7CF53A0", VA = "0x187CF6DA0", Slot = "4")]
	public void LJDCNOCKLGC(Transform JAHKFPBBGHB, FNNJLMJJNEI MONCKMMJHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8376830", Offset = "0x8374E30", VA = "0x188376830", Slot = "5")]
	public FNNJLMJJNEI HNAENMOCANK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x83768F0", Offset = "0x8374EF0", VA = "0x1883768F0", Slot = "6")]
	public void KIGEJCHNGKD(FNNJLMJJNEI BCDFHNNAFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public JIJCENCOPOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class CCNHAFDCLHC : IDisposable, KOAPPHJCLFL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MGEKMHLOGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public IIGHBLCNCNA oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public IIGHBLCNCNA newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public MGEKMHLOGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x83780D0", Offset = "0x83766D0", VA = "0x1883780D0")]
		internal bool PJNHFKNIAJJ(ELJFLKNDCLJ node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly JLFEPMOIKHK GHFBGNOCLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private EKKOALHGBJP FHHLJKGPPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private NEKPCLDIILO GKACGEGLCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool LPDHKOLOALN;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly IDGHEFJHGEI IHBJENJFLDC;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public ELJFLKNDCLJ KFENKPOKOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x836ED00", Offset = "0x836D300", VA = "0x18836ED00")]
	public bool HKMDOEGDPIF([In] MMLILGEPACD DAJAOHIJHHL, bool HNAKMFKOIDJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x836FD90", Offset = "0x836E390", VA = "0x18836FD90")]
	private bool LABNDKDIHME([In] MMLILGEPACD DAJAOHIJHHL, bool HNAKMFKOIDJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8371EB0", Offset = "0x83704B0", VA = "0x188371EB0")]
	public CCNHAFDCLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8370470", Offset = "0x836EA70", VA = "0x188370470", Slot = "5")]
	public void LJDCNOCKLGC(CDBBJJFMOLB BIAJFLEJGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x836F850", Offset = "0x836DE50", VA = "0x18836F850", Slot = "17")]
	public void JMLHPJIHIPA(CHKLIGMKFPB GDMDDGECOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x836F8E0", Offset = "0x836DEE0", VA = "0x18836F8E0", Slot = "12")]
	public void KIAHPEJMBJJ(Func<IIGHBLCNCNA, bool> AKFODCOHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x836F8F0", Offset = "0x836DEF0", VA = "0x18836F8F0")]
	private void KIAHPEJMBJJ(JLFEPMOIKHK CFHHNIJODJI, Func<IIGHBLCNCNA, bool> AKFODCOHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8370D50", Offset = "0x836F350", VA = "0x188370D50", Slot = "11")]
	public void NHEFPPFNOKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x836ED10", Offset = "0x836D310", VA = "0x18836ED10", Slot = "8")]
	public bool CDHNCNNCGAC(IIGHBLCNCNA FMMLPFJFLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8370F40", Offset = "0x836F540", VA = "0x188370F40")]
	private bool OCPOIEKJLPF(IIGHBLCNCNA MJLNJEHAIIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x836F3F0", Offset = "0x836D9F0", VA = "0x18836F3F0")]
	private static bool IJFFLECDCGB(IIGHBLCNCNA MJLNJEHAIIF, JLFEPMOIKHK JPNOJEKFHNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8371640", Offset = "0x836FC40", VA = "0x188371640")]
	private void OELPHEEONDG(Transform CIBBACFPMLB, JLFEPMOIKHK OBFALGNPJAI, JLFEPMOIKHK[] IOAGFNKAMDA, IIGHBLCNCNA NIHMPPPOHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x836EBB0", Offset = "0x836D1B0", VA = "0x18836EBB0")]
	private EMDPGDILFHJ BJHMHODKKMH(Transform HJDLKEBJKME, EMDPGDILFHJ IPFHFGDAAIO)
	{
		return default(EMDPGDILFHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8370520", Offset = "0x836EB20", VA = "0x188370520")]
	private static bool MFNBMKJKLNL(JLFEPMOIKHK JPNOJEKFHNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8370EE0", Offset = "0x836F4E0", VA = "0x188370EE0", Slot = "9")]
	public bool OBHMAPDGOEE(IIGHBLCNCNA JBIFIJGOMHF, int AIGOGADNONM, int FFLELLPDBPD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x836F600", Offset = "0x836DC00", VA = "0x18836F600")]
	private bool JJDNOIIMGGM(IIGHBLCNCNA JBIFIJGOMHF, int AIGOGADNONM, int FFLELLPDBPD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x836ED20", Offset = "0x836D320", VA = "0x18836ED20")]
	private static void CONOEHLAKAB(IIGHBLCNCNA JBIFIJGOMHF, int AIGOGADNONM, int FFLELLPDBPD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ, JLFEPMOIKHK GHBOCNHDDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8370350", Offset = "0x836E950", VA = "0x188370350")]
	private void LDNAKFKIIJE(IIGHBLCNCNA BBECJKJMFLO, int MPCCGJMGOBP, IIGHBLCNCNA GHOEBAIBIJA, int HKIIHLKJHAD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x836F380", Offset = "0x836D980", VA = "0x18836F380")]
	private void IDKGKPNMJHJ(JLFEPMOIKHK CFHHNIJODJI, IIGHBLCNCNA FIKFPMIKOFD, IIGHBLCNCNA PMBAFINBOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x836F310", Offset = "0x836D910", VA = "0x18836F310")]
	private void IDKGKPNMJHJ(IIGHBLCNCNA MDFAACGKJPJ, IIGHBLCNCNA FIKFPMIKOFD, IIGHBLCNCNA PMBAFINBOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8370D70", Offset = "0x836F370", VA = "0x188370D70")]
	private void NNHEACHDHPE(IIGHBLCNCNA MDFAACGKJPJ, IIGHBLCNCNA FIKFPMIKOFD, IIGHBLCNCNA PMBAFINBOGP, bool CBFBMGJOGPH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8370DE0", Offset = "0x836F3E0", VA = "0x188370DE0")]
	private void NNHEACHDHPE(JLFEPMOIKHK PPOKNBNEDHM, IIGHBLCNCNA NIHMPPPOHOJ, IIGHBLCNCNA GHLOHKDEPIL, bool CBFBMGJOGPH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x836EEA0", Offset = "0x836D4A0", VA = "0x18836EEA0")]
	private void DFFEDEHLLBP(IIGHBLCNCNA OGHJJFPEOAI, int AIGOGADNONM, IIGHBLCNCNA GHOEBAIBIJA, int HKIIHLKJHAD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x836F000", Offset = "0x836D600", VA = "0x18836F000")]
	private void DNDOAMONGEI(ELJFLKNDCLJ IGDHFGFJBMG, ELJFLKNDCLJ BGJKPNIEBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x836F4A0", Offset = "0x836DAA0", VA = "0x18836F4A0", Slot = "18")]
	public IIGHBLCNCNA JAAAPLFMBBP(IIGHBLCNCNA MDFAACGKJPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8371A30", Offset = "0x8370030", VA = "0x188371A30", Slot = "13")]
	public void PJLGPCDKOGD(IIGHBLCNCNA MDFAACGKJPJ, HashSet<IIGHBLCNCNA> CJJGDIPIODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x836FB50", Offset = "0x836E150", VA = "0x18836FB50", Slot = "14")]
	public List<IIGHBLCNCNA> KPICAANONBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8370C80", Offset = "0x836F280", VA = "0x188370C80")]
	protected ELJFLKNDCLJ NDCGDBOBMOE(ELJFLKNDCLJ CFHHNIJODJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x836F160", Offset = "0x836D760", VA = "0x18836F160")]
	protected JLFEPMOIKHK[] EKHDDAFEIPA(JLFEPMOIKHK JPNOJEKFHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x836F200", Offset = "0x836D800", VA = "0x18836F200")]
	protected bool HLJBEFDKGKL(IIGHBLCNCNA MDFAACGKJPJ, [Out] JLFEPMOIKHK CFHHNIJODJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x836FA20", Offset = "0x836E020", VA = "0x18836FA20", Slot = "15")]
	public bool KKBNJOPIKJI(IIGHBLCNCNA MDFAACGKJPJ, [Out] EMDPGDILFHJ IDEPMJFPPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x836EFC0", Offset = "0x836D5C0", VA = "0x18836EFC0")]
	protected JLFEPMOIKHK DHOLFDENBPA(EMDPGDILFHJ BCCIBANHNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x836F880", Offset = "0x836DE80", VA = "0x18836F880", Slot = "10")]
	public bool JPDDCCJHBOP(IIGHBLCNCNA BBECJKJMFLO, int MPCCGJMGOBP, IIGHBLCNCNA GHOEBAIBIJA, int HKIIHLKJHAD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x83706E0", Offset = "0x836ECE0", VA = "0x1883706E0")]
	private bool MOEMBMANMEN(IIGHBLCNCNA BBECJKJMFLO, int MPCCGJMGOBP, IIGHBLCNCNA GHOEBAIBIJA, int HKIIHLKJHAD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x836EAE0", Offset = "0x836D0E0", VA = "0x18836EAE0")]
	private static bool BECEENDNAJI(JLFEPMOIKHK AAHDKOBMKME, EMDPGDILFHJ CIPOMMOJCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x836ED00", Offset = "0x836D300", VA = "0x18836ED00", Slot = "7")]
	private bool BJJJMGNOINF([In] MMLILGEPACD DAJAOHIJHHL, bool HNAKMFKOIDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class PKHBJPLKPLL : CDBBJJFMOLB, LKJPKMELKMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly CFPMHDJNIAH LOLOEONEEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly NEKPCLDIILO GKACGEGLCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly ALEBNDEEHKB MDPKAOBOPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly PMNEBDALGJL NJAOKACMMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly KOAPPHJCLFL OHEEMHHMAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal AHBLGGADLGJ KEBEIAGOJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal EABFCFAFJJN AKPCIDNDKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal EKKOALHGBJP CALHJKHGAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool LPDHKOLOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool EJMGBBOKDEJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GGBBNFNGAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xAEA8A0", Offset = "0xAE8EA0", VA = "0x180AEA8A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAEA8B0", Offset = "0xAE8EB0", VA = "0x180AEA8B0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool AFNNFFJLAHK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xB19E80", Offset = "0xB18480", VA = "0x180B19E80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xB19EB0", Offset = "0xB184B0", VA = "0x180B19EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MAJOCFFOAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<IIGHBLCNCNA, IIGHBLCNCNA> POGDGFMMAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x837FFE0", Offset = "0x837E5E0", VA = "0x18837FFE0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x837EF00", Offset = "0x837D500", VA = "0x18837EF00", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<IIGHBLCNCNA, IIGHBLCNCNA> AJNMKPGNDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8380220", Offset = "0x837E820", VA = "0x188380220", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x837F220", Offset = "0x837D820", VA = "0x18837F220", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<IIGHBLCNCNA, IIGHBLCNCNA, IIGHBLCNCNA> DIDDGGKIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x837EE20", Offset = "0x837D420", VA = "0x18837EE20", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x837E980", Offset = "0x837CF80", VA = "0x18837E980", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8380440", Offset = "0x837EA40", VA = "0x188380440")]
	public PKHBJPLKPLL(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x837F6D0", Offset = "0x837DCD0", VA = "0x18837F6D0", Slot = "12")]
	public void LJDCNOCKLGC(GameObject EGMHLHLEIMH, DPCKNPAAMHC PBGOOAKMMJG, EOBHCIBIAGN MNDLJJPPILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8380280", Offset = "0x837E880", VA = "0x188380280", Slot = "26")]
	public void PILPLNBAOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x837EE80", Offset = "0x837D480", VA = "0x18837EE80", Slot = "13")]
	public void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x837E9E0", Offset = "0x837CFE0", VA = "0x18837E9E0", Slot = "14")]
	public void CBPAAEAGBMC(IIGHBLCNCNA MDFAACGKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x837EA00", Offset = "0x837D000", VA = "0x18837EA00", Slot = "15")]
	public void EEAAOMNILHP(IIGHBLCNCNA MDFAACGKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x837E930", Offset = "0x837CF30", VA = "0x18837E930", Slot = "22")]
	public bool BPKAAKHCHOH(CMAGLMFPMPA EBEOEHAALNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x837FED0", Offset = "0x837E4D0", VA = "0x18837FED0")]
	internal bool MOEMBMANMEN([In] MMLILGEPACD DAJAOHIJHHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x837FD80", Offset = "0x837E380", VA = "0x18837FD80")]
	internal bool MKIPCFOALFP([In] MMLILGEPACD DAJAOHIJHHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x8380040", Offset = "0x837E640", VA = "0x188380040")]
	internal void ONEJANNKOGL(IIGHBLCNCNA MDFAACGKJPJ, int KDIBOKAIADN, bool HNAKMFKOIDJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x837EA00", Offset = "0x837D000", VA = "0x18837EA00")]
	internal bool LINFAOJJDGJ(IIGHBLCNCNA LGFHAOHAOAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x837E760", Offset = "0x837CD60", VA = "0x18837E760")]
	internal bool BAGIAKGJLNL(IIGHBLCNCNA JBIFIJGOMHF, int AIGOGADNONM, int FFLELLPDBPD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8380350", Offset = "0x837E950", VA = "0x188380350", Slot = "16")]
	public void PJLGPCDKOGD(IIGHBLCNCNA MDFAACGKJPJ, HashSet<IIGHBLCNCNA> HOBNALNHKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x837EA60", Offset = "0x837D060", VA = "0x18837EA60", Slot = "17")]
	public void EFCCPFPOBEA(IIGHBLCNCNA JBIFIJGOMHF, IIGHBLCNCNA EKGIILBOMMM, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x837F0E0", Offset = "0x837D6E0", VA = "0x18837F0E0", Slot = "18")]
	public void IMJALKNJIPA(IIGHBLCNCNA BBECJKJMFLO, int MPCCGJMGOBP, IIGHBLCNCNA GHOEBAIBIJA, int HKIIHLKJHAD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x837F510", Offset = "0x837DB10", VA = "0x18837F510", Slot = "19")]
	public void LDIANHCICCM(IIGHBLCNCNA BBECJKJMFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x837F2C0", Offset = "0x837D8C0", VA = "0x18837F2C0")]
	public void KCDGDAMHKHH([Optional] NGPBJJLAELK BMPPNDDDCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x837E8A0", Offset = "0x837CEA0", VA = "0x18837E8A0", Slot = "23")]
	public void BJFOMPCOFHA(GFDCAABEMHM OHEEMHHMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x837EF60", Offset = "0x837D560", VA = "0x18837EF60", Slot = "20")]
	public GFDCAABEMHM IKDKHJPILEP(bool PMCBCINGJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x837EC70", Offset = "0x837D270", VA = "0x18837EC70", Slot = "21")]
	public GFDCAABEMHM EJJNODIJKJC(HashSet<Guid> ONDDCGNNKEJ, bool PMCBCINGJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x837F280", Offset = "0x837D880", VA = "0x18837F280", Slot = "25")]
	public void JABMBIAPMLD(GFDCAABEMHM OHEEMHHMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x837FCD0", Offset = "0x837E2D0", VA = "0x18837FCD0", Slot = "24")]
	public void LJMPPEPJCKN(GFDCAABEMHM OHEEMHHMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class NEKPCLDIILO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly NCECCJAFPPJ<IIGHBLCNCNA, IIGHBLCNCNA> POGDGFMMAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly NCECCJAFPPJ<IIGHBLCNCNA, IIGHBLCNCNA> AJNMKPGNDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly FENKKBHLGFH<IIGHBLCNCNA, IIGHBLCNCNA, IIGHBLCNCNA> DIDDGGKIMNL;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8378410", Offset = "0x8376A10", VA = "0x188378410")]
	public NEKPCLDIILO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	public void LJDCNOCKLGC(PKHBJPLKPLL BIAJFLEJGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x83783B0", Offset = "0x83769B0", VA = "0x1883783B0")]
	public void LCENBNHCAPP(IIGHBLCNCNA IGDHFGFJBMG, IIGHBLCNCNA OGHJJFPEOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x83782D0", Offset = "0x83768D0", VA = "0x1883782D0")]
	public void DKPJOGAGJNJ(IIGHBLCNCNA IGDHFGFJBMG, IIGHBLCNCNA OGHJJFPEOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8378330", Offset = "0x8376930", VA = "0x188378330")]
	public void ELJGBIDGICF(IIGHBLCNCNA AMAKHBDINOP, IIGHBLCNCNA GHOEBAIBIJA, IIGHBLCNCNA OGHJJFPEOAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class ALEBNDEEHKB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private PKHBJPLKPLL BIAJFLEJGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private EABFCFAFJJN AKPCIDNDKGF;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public ALEBNDEEHKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x836E890", Offset = "0x836CE90", VA = "0x18836E890")]
	public void LJDCNOCKLGC(PKHBJPLKPLL BIAJFLEJGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x836E700", Offset = "0x836CD00", VA = "0x18836E700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x836E6C0", Offset = "0x836CCC0", VA = "0x18836E6C0")]
	private void APFCBGIHELJ(NAPCGDBANAF PDIOIHNCAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x836E820", Offset = "0x836CE20", VA = "0x18836E820")]
	private void IGFDBOAGOKE(NGPBJJLAELK IDACCMFAENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x836E9D0", Offset = "0x836CFD0", VA = "0x18836E9D0")]
	public void NMBDBJMCIKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x836E710", Offset = "0x836CD10", VA = "0x18836E710")]
	public void ENJEGAFDKMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KIMJMHHPFKA
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IGBKOGKJHCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public CFPMHDJNIAH container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public IGBKOGKJHCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x83749C0", Offset = "0x8372FC0", VA = "0x1883749C0")]
		internal PKHBJPLKPLL GLECFDJKOND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8377490", Offset = "0x8375A90", VA = "0x188377490")]
	public static void BHEMFLFCLAO(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8377690", Offset = "0x8375C90", VA = "0x188377690")]
	public static void GAIEDPHGGHP(CFPMHDJNIAH LOLOEONEEKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class OHBJNHGANNL : IDisposable, EKKOALHGBJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, FNNJLMJJNEI> PHMOKHLIHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly CHKLIGMKFPB PFGHFCHAEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private DMAKIHEBOCA NAOLNBDNHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private KOAPPHJCLFL OHEEMHHMAGD;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker HNPLDNOAOMA;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x837E680", Offset = "0x837CC80", VA = "0x18837E680")]
	public OHBJNHGANNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x837E290", Offset = "0x837C890", VA = "0x18837E290", Slot = "7")]
	public void LJDCNOCKLGC(KOAPPHJCLFL OHEEMHHMAGD, DMAKIHEBOCA NAOLNBDNHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x837E050", Offset = "0x837C650", VA = "0x18837E050", Slot = "5")]
	public void LINBECGLJLI(ELJFLKNDCLJ MNNAJDDNKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x837DD30", Offset = "0x837C330", VA = "0x18837DD30", Slot = "9")]
	public void IDEJGNDKJFB(ELJFLKNDCLJ EAGILLBFJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x837D9F0", Offset = "0x837BFF0", VA = "0x18837D9F0", Slot = "8")]
	public void FAOEGAOAGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x837E2D0", Offset = "0x837C8D0", VA = "0x18837E2D0", Slot = "10")]
	public void PDDHOPMNAGH(ELJFLKNDCLJ LEHJPLNHGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x837DBB0", Offset = "0x837C1B0", VA = "0x18837DBB0", Slot = "11")]
	public void GBKALOPBBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x837DEA0", Offset = "0x837C4A0", VA = "0x18837DEA0")]
	private bool KENEIDJLMOD(ELJFLKNDCLJ IODKHMMPFHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class PMNEBDALGJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct FCBMCNBLFCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly JLFEPMOIKHK HHLNNAMNMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> ONDDCGNNKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly CMAGLMFPMPA EHAEIDBJKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly CMAGLMFPMPA KEDKHILOCDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool PMCBCINGJML;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool MBKNPDOMFKA
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x83731B0", Offset = "0x83717B0", VA = "0x1883731B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x83735F0", Offset = "0x8371BF0", VA = "0x1883735F0")]
		public FCBMCNBLFCB(JLFEPMOIKHK HHLNNAMNMBA, HashSet<Guid> ONDDCGNNKEJ, bool PMCBCINGJML, [Optional] CMAGLMFPMPA EHAEIDBJKHC, [Optional] CMAGLMFPMPA KEDKHILOCDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8372D30", Offset = "0x8371330", VA = "0x188372D30")]
		public CMAGLMFPMPA CAELEDFILEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x83730F0", Offset = "0x83716F0", VA = "0x1883730F0")]
		private CMAGLMFPMPA FKBFOEGACPD([Out] CMAGLMFPMPA LBDLMBHPEDJ, [Out] CMAGLMFPMPA MBKJMEHPCLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8372ED0", Offset = "0x83714D0", VA = "0x188372ED0")]
		private CMAGLMFPMPA DHOJLDEHIBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8373480", Offset = "0x8371A80", VA = "0x188373480")]
		private void MEFAOGAFJLA(CMAGLMFPMPA AEELICGLFFN, CMAGLMFPMPA GPFLLDBCILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x83732C0", Offset = "0x83718C0", VA = "0x1883732C0")]
		private void KEBPGNEKINI(CMAGLMFPMPA LBDLMBHPEDJ, CMAGLMFPMPA MBKJMEHPCLI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PKHBJPLKPLL BIAJFLEJGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private KOAPPHJCLFL OHEEMHHMAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private EKKOALHGBJP FHHLJKGPPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EABFCFAFJJN AKPCIDNDKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool LABIHKFPAFE;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool OLCIHIMCEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x83828E0", Offset = "0x8380EE0", VA = "0x1883828E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool GGBBNFNGAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8382930", Offset = "0x8380F30", VA = "0x188382930")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8382A40", Offset = "0x8381040", VA = "0x188382A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x83827A0", Offset = "0x8380DA0", VA = "0x1883827A0")]
	public void LJDCNOCKLGC(PKHBJPLKPLL BIAJFLEJGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8382540", Offset = "0x8380B40", VA = "0x188382540")]
	public GFDCAABEMHM IKDKHJPILEP(bool PMCBCINGJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8381AE0", Offset = "0x83800E0", VA = "0x188381AE0")]
	public GFDCAABEMHM EJJNODIJKJC(HashSet<Guid> ONDDCGNNKEJ, bool PMCBCINGJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x83809C0", Offset = "0x837EFC0", VA = "0x1883809C0")]
	public void BJFOMPCOFHA(GFDCAABEMHM OHEEMHHMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8382810", Offset = "0x8380E10", VA = "0x188382810")]
	public void LJMPPEPJCKN(GFDCAABEMHM OHEEMHHMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x83828B0", Offset = "0x8380EB0", VA = "0x1883828B0")]
	public void NBEJPBNDCGD(GFDCAABEMHM OHEEMHHMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8382360", Offset = "0x8380960", VA = "0x188382360")]
	private void HIPDKAFFDIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x83826B0", Offset = "0x8380CB0", VA = "0x1883826B0")]
	private CMAGLMFPMPA KHAMEPOLKNJ(JLFEPMOIKHK CFHHNIJODJI, bool PMCBCINGJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8381830", Offset = "0x837FE30", VA = "0x188381830")]
	private static void DLFCMBJILFO(JLFEPMOIKHK CFHHNIJODJI, bool PMCBCINGJML, CMAGLMFPMPA EBEOEHAALNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x8382A60", Offset = "0x8381060", VA = "0x188382A60")]
	private void PCIIGIBNANB(JLFEPMOIKHK CFHHNIJODJI, bool PMCBCINGJML, CMAGLMFPMPA EBEOEHAALNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8382DA0", Offset = "0x83813A0", VA = "0x188382DA0")]
	private CMAGLMFPMPA POJNDMOPGNN(JLFEPMOIKHK HHLNNAMNMBA, HashSet<Guid> ONDDCGNNKEJ, bool PMCBCINGJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8381350", Offset = "0x837F950", VA = "0x188381350")]
	private bool DBKJPKDEGIP(GFDCAABEMHM MFPOPAFEABH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8380CE0", Offset = "0x837F2E0", VA = "0x188380CE0")]
	private bool CBAPDJDODBJ(CMAGLMFPMPA EBEOEHAALNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8381FF0", Offset = "0x83805F0", VA = "0x188381FF0")]
	private bool GKEJFLLNCMF(GFDCAABEMHM OHEEMHHMAGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x8382C80", Offset = "0x8381280", VA = "0x188382C80")]
	private static bool PNICGBBLGFN(CMAGLMFPMPA EBEOEHAALNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8380A50", Offset = "0x837F050", VA = "0x188380A50")]
	public static bool BPKAAKHCHOH(CMAGLMFPMPA EBEOEHAALNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8382010", Offset = "0x8380610", VA = "0x188382010")]
	private IIGHBLCNCNA HGCBBANNIDF(CMAGLMFPMPA EBEOEHAALNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x8381E70", Offset = "0x8380470", VA = "0x188381E70")]
	private IIGHBLCNCNA FDJEIGAHJBO(CMAGLMFPMPA EBEOEHAALNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8380830", Offset = "0x837EE30", VA = "0x188380830")]
	private IIGHBLCNCNA AGFLBNDNDEN(CMAGLMFPMPA EBEOEHAALNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8379E30", Offset = "0x8378430", VA = "0x188379E30")]
	private static Guid GJEHOODAOGJ(CMAGLMFPMPA EBEOEHAALNF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8382950", Offset = "0x8380F50", VA = "0x188382950")]
	private string OLNJIDAKNAK(CMAGLMFPMPA EBEOEHAALNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x8381C80", Offset = "0x8380280", VA = "0x188381C80")]
	private bool FDBKABGNBIE(JLFEPMOIKHK CFHHNIJODJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x83815D0", Offset = "0x837FBD0", VA = "0x1883815D0")]
	private static void DLCFHHDNNJO(JLFEPMOIKHK HHLNNAMNMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public PMNEBDALGJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct MMLILGEPACD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public IIGHBLCNCNA OGHJJFPEOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public IIGHBLCNCNA IGDHFGFJBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int AIGOGADNONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int FFLELLPDBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 LHFBMPAOFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion IOLHEIDKEPJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public EMDPGDILFHJ AHMEEOGGIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x83781C0", Offset = "0x83767C0", VA = "0x1883781C0")]
		get
		{
			return default(EMDPGDILFHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public EMDPGDILFHJ OMPMINLKNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8378190", Offset = "0x8376790", VA = "0x188378190")]
		get
		{
			return default(EMDPGDILFHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8378260", Offset = "0x8376860", VA = "0x188378260")]
	public MMLILGEPACD(IIGHBLCNCNA OGHJJFPEOAI, IIGHBLCNCNA IGDHFGFJBMG, int AIGOGADNONM, int FFLELLPDBPD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface KOAPPHJCLFL
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	ELJFLKNDCLJ KFENKPOKOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJDCNOCKLGC(CDBBJJFMOLB BIAJFLEJGFD);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HKMDOEGDPIF([In] MMLILGEPACD DAJAOHIJHHL, bool HNAKMFKOIDJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CDHNCNNCGAC(IIGHBLCNCNA FMMLPFJFLMA);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OBHMAPDGOEE(IIGHBLCNCNA JBIFIJGOMHF, int AIGOGADNONM, int FFLELLPDBPD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JPDDCCJHBOP(IIGHBLCNCNA BBECJKJMFLO, int MPCCGJMGOBP, IIGHBLCNCNA GHOEBAIBIJA, int HKIIHLKJHAD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NHEFPPFNOKD();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KIAHPEJMBJJ(Func<IIGHBLCNCNA, bool> AKFODCOHNEJ);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PJLGPCDKOGD(IIGHBLCNCNA MDFAACGKJPJ, HashSet<IIGHBLCNCNA> CJJGDIPIODJ);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<IIGHBLCNCNA> KPICAANONBI();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KKBNJOPIKJI(IIGHBLCNCNA MDFAACGKJPJ, [Out] EMDPGDILFHJ IDEPMJFPPOF);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JMLHPJIHIPA(CHKLIGMKFPB GDMDDGECOJI);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool CHKLIGMKFPB(ELJFLKNDCLJ CFHHNIJODJI);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface ELJFLKNDCLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	IIGHBLCNCNA JDJFONMMFGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	ELJFLKNDCLJ DHPGFGLBJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	EMDPGDILFHJ IKGGMBCCAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool LFMILAIKCKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FNNJLMJJNEI
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNHKIAJGEDI(IIGHBLCNCNA KILOAOLHHCP, EMDPGDILFHJ OGHJJFPEOAI);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HCEFKFEHIJE(IIGHBLCNCNA KILOAOLHHCP, EMDPGDILFHJ OGHJJFPEOAI);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOFPGBJGBOB(IIGHBLCNCNA KILOAOLHHCP, EMDPGDILFHJ OGHJJFPEOAI);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GIPGDFPMEIO(IIGHBLCNCNA KILOAOLHHCP, EMDPGDILFHJ OGHJJFPEOAI);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FNNJLMJJNEI Instantiate(Transform JAHKFPBBGHB);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LOMEBHIDOPA();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface DMAKIHEBOCA
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJDCNOCKLGC(Transform JAHKFPBBGHB, FNNJLMJJNEI MONCKMMJHAL);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FNNJLMJJNEI HNAENMOCANK();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KIGEJCHNGKD(FNNJLMJJNEI BCDFHNNAFKK);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface AHBLGGADLGJ : JKNKBHHCPFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FDEMCHFIMMI();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CKLMFNKECEJ(Guid DEMDENAPFGM);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface EKKOALHGBJP
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LINBECGLJLI(ELJFLKNDCLJ MNNAJDDNKHA);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LJDCNOCKLGC(KOAPPHJCLFL OHEEMHHMAGD, DMAKIHEBOCA NOCDEHHHKEO);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FAOEGAOAGCA();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDEJGNDKJFB(ELJFLKNDCLJ EAGILLBFJIK);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PDDHOPMNAGH(ELJFLKNDCLJ LEHJPLNHGAL);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GBKALOPBBFI();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class JLFEPMOIKHK : ELJFLKNDCLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class ACLGEFNKPOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public EMDPGDILFHJ nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public JLFEPMOIKHK foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public ACLGEFNKPOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x836E580", Offset = "0x836CB80", VA = "0x18836E580")]
		internal bool MOFFIBAMCLF(ELJFLKNDCLJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private EMDPGDILFHJ IDEPMJFPPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<JLFEPMOIKHK> CKHLPOACJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private JLFEPMOIKHK MGIJGBLHDNN;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public EMDPGDILFHJ IKGGMBCCAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x15339F0", Offset = "0x1531FF0", VA = "0x1815339F0", Slot = "6")]
		get
		{
			return default(EMDPGDILFHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1533D50", Offset = "0x1532350", VA = "0x181533D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private JLFEPMOIKHK IGDHFGFJBMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x83770B0", Offset = "0x83756B0", VA = "0x1883770B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ELJFLKNDCLJ DHPGFGLBJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IIGHBLCNCNA JDJFONMMFGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LFMILAIKCKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8376960", Offset = "0x8374F60", VA = "0x188376960", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LMDGPIIKAAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x83772E0", Offset = "0x83758E0", VA = "0x1883772E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected JLFEPMOIKHK PPOKNBNEDHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8376DA0", Offset = "0x83753A0", VA = "0x188376DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x83773E0", Offset = "0x83759E0", VA = "0x1883773E0")]
	public JLFEPMOIKHK(EMDPGDILFHJ NCCMPOMMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x8376970", Offset = "0x8374F70", VA = "0x188376970")]
	public JLFEPMOIKHK CIHCHEDEEEJ(EMDPGDILFHJ NCNOKKIDAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x8376F30", Offset = "0x8375530", VA = "0x188376F30")]
	public JLFEPMOIKHK NANBKOGNMFF(EMDPGDILFHJ ODKLLGDPPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8376BC0", Offset = "0x83751C0", VA = "0x188376BC0")]
	public JLFEPMOIKHK HCDNAOEAAEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8377190", Offset = "0x8375790", VA = "0x188377190")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8377330", Offset = "0x8375930", VA = "0x188377330")]
	public JLFEPMOIKHK PNALAIGLKAE(EMDPGDILFHJ GHOEBAIBIJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8376DD0", Offset = "0x83753D0", VA = "0x188376DD0")]
	private static void JMLHPJIHIPA(JLFEPMOIKHK HIKMFBDFACK, CHKLIGMKFPB DCPFGDLGCCM, bool CMLLDPAHJIG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8376DC0", Offset = "0x83753C0", VA = "0x188376DC0", Slot = "9")]
	public void JMLHPJIHIPA(CHKLIGMKFPB GDMDDGECOJI, bool CBFBMGJOGPH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8376AC0", Offset = "0x83750C0", VA = "0x188376AC0")]
	public static JLFEPMOIKHK DHOLFDENBPA(JLFEPMOIKHK HIKMFBDFACK, EMDPGDILFHJ KIJMCOEMAHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface EABFCFAFJJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool OLCIHIMCEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool DOGCGDIFJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<NAPCGDBANAF> APFCBGIHELJ;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<NGPBJJLAELK> IGFDBOAGOKE;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PNHKIAJGEDI(PKHBJPLKPLL BIAJFLEJGFD, EOBHCIBIAGN JMAJHFFOBJA);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EFCCPFPOBEA(IIGHBLCNCNA JBIFIJGOMHF, IIGHBLCNCNA EKGIILBOMMM, int AIGOGADNONM, int FFLELLPDBPD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IMJALKNJIPA(IIGHBLCNCNA BBECJKJMFLO, int MPCCGJMGOBP, IIGHBLCNCNA GHOEBAIBIJA, int HKIIHLKJHAD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KBEEGFMJCNC(GFDCAABEMHM KHJFIKFNFIC, [Optional] NGPBJJLAELK BMPPNDDDCDE);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class CNFIKKKEGIB
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type MONFNOPPPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x83720C0", Offset = "0x83706C0", VA = "0x1883720C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object DOBPPELCKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8372080", Offset = "0x8370680", VA = "0x188372080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8372120", Offset = "0x8370720", VA = "0x188372120")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class GOBJBLFJDPA : EABFCFAFJJN, IDisposable, CFFOJIANONK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private PKHBJPLKPLL BIAJFLEJGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private EOBHCIBIAGN MNDLJJPPILO;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool OLCIHIMCEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8373E50", Offset = "0x8372450", VA = "0x188373E50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool DOGCGDIFJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8373A70", Offset = "0x8372070", VA = "0x188373A70", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView NDAFNMIAPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8373EB0", Offset = "0x83724B0", VA = "0x188373EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<NAPCGDBANAF> APFCBGIHELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x83739D0", Offset = "0x8371FD0", VA = "0x1883739D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8373AB0", Offset = "0x83720B0", VA = "0x188373AB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<NGPBJJLAELK> IGFDBOAGOKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x83737B0", Offset = "0x8371DB0", VA = "0x1883737B0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8373C80", Offset = "0x8372280", VA = "0x188373C80", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8373F50", Offset = "0x8372550", VA = "0x188373F50", Slot = "10")]
	public void PNHKIAJGEDI(PKHBJPLKPLL BIAJFLEJGFD, EOBHCIBIAGN MNDLJJPPILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8373850", Offset = "0x8371E50", VA = "0x188373850", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x83738A0", Offset = "0x8371EA0", VA = "0x1883738A0", Slot = "11")]
	public void EFCCPFPOBEA(IIGHBLCNCNA JBIFIJGOMHF, IIGHBLCNCNA EKGIILBOMMM, int AIGOGADNONM, int FFLELLPDBPD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8373B50", Offset = "0x8372150", VA = "0x188373B50", Slot = "12")]
	public void IMJALKNJIPA(IIGHBLCNCNA BBECJKJMFLO, int MPCCGJMGOBP, IIGHBLCNCNA GHOEBAIBIJA, int HKIIHLKJHAD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8373D20", Offset = "0x8372320", VA = "0x188373D20", Slot = "13")]
	public void KBEEGFMJCNC(GFDCAABEMHM KHJFIKFNFIC, [Optional] NGPBJJLAELK BMPPNDDDCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8374220", Offset = "0x8372820", VA = "0x188374220")]
	[DNODEMNIJIG]
	private void RpcMasterReparentNodes(IIGHBLCNCNA BBECJKJMFLO, int MPCCGJMGOBP, IIGHBLCNCNA GHOEBAIBIJA, int HKIIHLKJHAD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8374020", Offset = "0x8372620", VA = "0x188374020")]
	[DNODEMNIJIG]
	private void RpcMasterModifyNode(IIGHBLCNCNA JBIFIJGOMHF, IIGHBLCNCNA EKGIILBOMMM, int AIGOGADNONM, int FFLELLPDBPD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8374620", Offset = "0x8372C20", VA = "0x188374620")]
	[DNODEMNIJIG]
	private void RpcReparentNodes(IIGHBLCNCNA BBECJKJMFLO, int MPCCGJMGOBP, IIGHBLCNCNA GHOEBAIBIJA, int HKIIHLKJHAD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ, HGNFDBOJKMF EGLMBAJILMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8374530", Offset = "0x8372B30", VA = "0x188374530")]
	[DNODEMNIJIG]
	private void RpcModifyNode(IIGHBLCNCNA JBIFIJGOMHF, int AIGOGADNONM, int FFLELLPDBPD, Vector3 LHFBMPAOFLB, Quaternion IOLHEIDKEPJ, HGNFDBOJKMF EGLMBAJILMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8373FE0", Offset = "0x83725E0", VA = "0x188373FE0")]
	[DNODEMNIJIG]
	private void RpcDeserializeConnectableGraph(GFDCAABEMHM OHEEMHHMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GOBJBLFJDPA()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, FNNJLMJJNEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8377DB0", Offset = "0x83763B0", VA = "0x188377DB0", Slot = "4")]
		private void MGCEJNDFHAN(IIGHBLCNCNA KILOAOLHHCP, EMDPGDILFHJ OGHJJFPEOAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8377770", Offset = "0x8375D70", VA = "0x188377770", Slot = "5")]
		private void CAPDPKEDGLA(IIGHBLCNCNA KILOAOLHHCP, EMDPGDILFHJ OGHJJFPEOAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8377BE0", Offset = "0x83761E0", VA = "0x188377BE0", Slot = "6")]
		private void GBIKAKAODKH(IIGHBLCNCNA KILOAOLHHCP, EMDPGDILFHJ OGHJJFPEOAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x83779F0", Offset = "0x8375FF0", VA = "0x1883779F0", Slot = "7")]
		private void EONNMDCEMJP(IIGHBLCNCNA KILOAOLHHCP, EMDPGDILFHJ OGHJJFPEOAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8377D40", Offset = "0x8376340", VA = "0x188377D40", Slot = "8")]
		private FNNJLMJJNEI HOGMJKKCKCA(Transform JAHKFPBBGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8377710", Offset = "0x8375D10", VA = "0x188377710", Slot = "9")]
		private void BJODFAJJNPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class IDPFCIFJCLL
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3E02E00", Offset = "0x3E01400", VA = "0x183E02E00")]
	public static HLFCHLGNHLL<T> NOHDEJFGEBG<T>(this CFPMHDJNIAH LOLOEONEEKB)
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
