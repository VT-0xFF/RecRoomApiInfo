using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using Photon.Pun;
using RecRoom;
using RecRoom.ObjectModel.Connectables;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Preserve]
public class PBCJFLAIDND : GEHPDDMLKCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Transform FLCFNMLPAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private AKFIDAIPMLM INPOEMAHJFA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x372FBD0", Offset = "0x372EBD0", VA = "0x18372FBD0", Slot = "4")]
	public void NAGCBALDEME(Transform FLCFNMLPAML, AKFIDAIPMLM INPOEMAHJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5277150", Offset = "0x5276150", VA = "0x185277150", Slot = "5")]
	public AKFIDAIPMLM COEMJLAHNEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public PBCJFLAIDND()
	{
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[LMNMHFHDONH(IPKPBIMLPOB.Connectables)]
	public sealed class OMConnectableManager : BPFKJIFDLLM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class PIENGMOABNC : IEnumerable<KPMKOHNCKIH>, IEnumerable, IEnumerator<KPMKOHNCKIH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private KPMKOHNCKIH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private PMFFIMLMCEJ localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PMFFIMLMCEJ <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public OMConnectableManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private JEAKCMCJOBO <objects>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private CIMNJIOJIIP.HAAIJLKHOLN <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private KPMKOHNCKIH System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
			[DebuggerHidden]
			public PIENGMOABNC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x5277EB0", Offset = "0x5276EB0", VA = "0x185277EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5277A90", Offset = "0x5276A90", VA = "0x185277A90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x5277F10", Offset = "0x5276F10", VA = "0x185277F10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5277E70", Offset = "0x5276E70", VA = "0x185277E70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5277DC0", Offset = "0x5276DC0", VA = "0x185277DC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KPMKOHNCKIH> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5277DC0", Offset = "0x5276DC0", VA = "0x185277DC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly FBNJDMKEPCN CFAHDMKBKDE;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly FBNJDMKEPCN JMLOKDDBJFE;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly FBNJDMKEPCN PJPCBBINAMK;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly FBNJDMKEPCN KIJPGEPAAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private DACMFIPKNDK BGONJHEABPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private BCIOKJKBEBJ NJHJPKKCNJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private GGKOKFAIBOJ ACNDHAIKGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private CPAGJJIMMGO PKLLBBDOLLM;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const int HCCPGACGMKG = 0;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const int CBBEFHPBJIE = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HEGPOCOMKLM GNDGFHCLBLF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NMMHNMGCMPC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x969290", Offset = "0x968290", VA = "0x180969290", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x969430", Offset = "0x968430", VA = "0x180969430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<KPMKOHNCKIH, KPMKOHNCKIH> KHEHPEBECLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x52736E0", Offset = "0x52726E0", VA = "0x1852736E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5275880", Offset = "0x5274880", VA = "0x185275880", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<KPMKOHNCKIH, KPMKOHNCKIH> HDCDKKEOCMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x5276960", Offset = "0x5275960", VA = "0x185276960", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x52744A0", Offset = "0x52734A0", VA = "0x1852744A0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<KPMKOHNCKIH, KPMKOHNCKIH, KPMKOHNCKIH> PIDOKNIFJEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5276570", Offset = "0x5275570", VA = "0x185276570", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5276610", Offset = "0x5275610", VA = "0x185276610", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x52770E0", Offset = "0x52760E0", VA = "0x1852770E0")]
		public OMConnectableManager(GBDCKFPNAEP FOIOPKEONKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5275D40", Offset = "0x5274D40", VA = "0x185275D40", Slot = "11")]
		public void NAGCBALDEME(GameObject NCAOMIEGHPA, DLCALFALNAH BNLBBLEEPCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5272F60", Offset = "0x5271F60", VA = "0x185272F60", Slot = "26")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x52708E0", Offset = "0x526F8E0", VA = "0x1852708E0", Slot = "22")]
		public bool LCJIJIJFMOM(JGDCJMONMPI GGCLNKGONMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5271E70", Offset = "0x5270E70", VA = "0x185271E70")]
		private void ADFBKEMPIFG(PMFFIMLMCEJ JKMIIAPKNNK, PMFFIMLMCEJ KAKGJMHAAEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5276190", Offset = "0x5275190", VA = "0x185276190")]
		private void NKMOPOOMBEO(PMFFIMLMCEJ JKMIIAPKNNK, PMFFIMLMCEJ PIKABCPMIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5273780", Offset = "0x5272780", VA = "0x185273780")]
		private void EOPNFFALNGO(PMFFIMLMCEJ JKMIIAPKNNK, PMFFIMLMCEJ PIKABCPMIJO, PMFFIMLMCEJ KAKGJMHAAEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5276A00", Offset = "0x5275A00", VA = "0x185276A00")]
		private void PNCONAKGIBL(PMFFIMLMCEJ JKMIIAPKNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "12")]
		public void PGLCEDHDGGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5275A00", Offset = "0x5274A00", VA = "0x185275A00", Slot = "13")]
		public void MNFGPLMIANE(KPMKOHNCKIH CHCLCLFDGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5275920", Offset = "0x5274920", VA = "0x185275920", Slot = "14")]
		public void MFJOMNDPBAP(KPMKOHNCKIH CHCLCLFDGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x52752F0", Offset = "0x52742F0", VA = "0x1852752F0", Slot = "16")]
		public void JJELGLHNKGB(KPMKOHNCKIH CHCLCLFDGOH, KPMKOHNCKIH FCOKOFOLAAM, Vector3 CEKGMIFMNMB, Quaternion OBFOOPGJBOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5275110", Offset = "0x5274110", VA = "0x185275110")]
		public void JJELGLHNKGB(PMFFIMLMCEJ ELFIACEEOOA, PMFFIMLMCEJ FCOKOFOLAAM, Vector3 CEKGMIFMNMB, Quaternion OBFOOPGJBOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x52766B0", Offset = "0x52756B0", VA = "0x1852766B0", Slot = "17")]
		public void PGGPPACHFKF(KPMKOHNCKIH IDNMHKLJHMO, int BCAINFFCKOE, KPMKOHNCKIH MBIJENMAKIB, int DAFAJOCODMH, Vector3 CEKGMIFMNMB, Quaternion OBFOOPGJBOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x52768F0", Offset = "0x52758F0", VA = "0x1852768F0")]
		public void PGGPPACHFKF(PMFFIMLMCEJ ELFIACEEOOA, PMFFIMLMCEJ ICMEPOIJCJO, Vector3 CEKGMIFMNMB, Quaternion OBFOOPGJBOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x52734F0", Offset = "0x52724F0", VA = "0x1852734F0", Slot = "18")]
		public void ELMBMIBKAAE(KPMKOHNCKIH CHCLCLFDGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5275790", Offset = "0x5274790", VA = "0x185275790", Slot = "19")]
		public bool KCJKPJNBNDI(KPMKOHNCKIH CHCLCLFDGOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5275540", Offset = "0x5274540", VA = "0x185275540")]
		public bool KCJKPJNBNDI(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5273B40", Offset = "0x5272B40", VA = "0x185273B40", Slot = "15")]
		public void FAAOOAHHFAL(KPMKOHNCKIH CHCLCLFDGOH, HashSet<KPMKOHNCKIH> DMGDMCIDCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x685170", Offset = "0x684170", VA = "0x180685170", Slot = "20")]
		public BGCFIBNNBIF FFMGIEJHAKP(bool OKGLNPCPFOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x685170", Offset = "0x684170", VA = "0x180685170", Slot = "21")]
		public BGCFIBNNBIF IIIAIHGHLMM(HashSet<Guid> JNBOEEGMNBF, bool OKGLNPCPFOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x52740F0", Offset = "0x52730F0", VA = "0x1852740F0", Slot = "23")]
		public void GNMJKLDDDJL(BGCFIBNNBIF CCICHMPIDIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5276500", Offset = "0x5275500", VA = "0x185276500", Slot = "24")]
		public void OIKMJENJPCB(BGCFIBNNBIF CCICHMPIDIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5274480", Offset = "0x5273480", VA = "0x185274480", Slot = "25")]
		public void IGKMOHFCKNP(BGCFIBNNBIF CCICHMPIDIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5273160", Offset = "0x5272160", VA = "0x185273160")]
		private void ELKEOHEOCBL(PMFFIMLMCEJ ELFIACEEOOA, PMFFIMLMCEJ ICMEPOIJCJO, Vector3 CEKGMIFMNMB, Quaternion OBFOOPGJBOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5274BE0", Offset = "0x5273BE0", VA = "0x185274BE0")]
		private void JHLLANGLLHF(PMFFIMLMCEJ ELFIACEEOOA, PMFFIMLMCEJ LCCGHHJFGDE, Vector3 CEKGMIFMNMB, Quaternion OBFOOPGJBOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5274540", Offset = "0x5273540", VA = "0x185274540")]
		private void IOJDHMIEEKG(PMFFIMLMCEJ ELFIACEEOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5272300", Offset = "0x5271300", VA = "0x185272300")]
		[IteratorStateMachine(typeof(PIENGMOABNC))]
		public IEnumerable<KPMKOHNCKIH> ADNOAIJEDAK(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5274B00", Offset = "0x5273B00", VA = "0x185274B00")]
		internal KPMKOHNCKIH JEBPCJLJMHL(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5271D80", Offset = "0x5270D80", VA = "0x185271D80")]
		internal PMFFIMLMCEJ ABIIJDLPNOE(KPMKOHNCKIH CHCLCLFDGOH)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5272390", Offset = "0x5271390", VA = "0x185272390")]
		private bool AINKHODEAOD(JGDCJMONMPI GGCLNKGONMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5274B80", Offset = "0x5273B80", VA = "0x185274B80")]
		private bool JGPHIFFFOHJ(JGDCJMONMPI GGCLNKGONMF, out KPMKOHNCKIH ICMEPOIJCJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x52747A0", Offset = "0x52737A0", VA = "0x1852747A0")]
		private KPMKOHNCKIH JEBPCJLJMHL(JGDCJMONMPI GGCLNKGONMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5272DC0", Offset = "0x5271DC0", VA = "0x185272DC0")]
		private KPMKOHNCKIH DNJCALAMJIA(JGDCJMONMPI GGCLNKGONMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5274610", Offset = "0x5273610", VA = "0x185274610")]
		private KPMKOHNCKIH JCLJLIDOMLC(JGDCJMONMPI GGCLNKGONMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x526A360", Offset = "0x5269360", VA = "0x18526A360")]
		private static Guid MJHHOKPDPIF(JGDCJMONMPI GGCLNKGONMF)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5272B50", Offset = "0x5271B50", VA = "0x185272B50")]
		private string CJECPIIHOLE(JGDCJMONMPI GGCLNKGONMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5272C30", Offset = "0x5271C30", VA = "0x185272C30")]
		private void DMBHMCDLCIC(KPMKOHNCKIH ELFIACEEOOA, KPMKOHNCKIH LCCGHHJFGDE, RigidTransform MLIDICHNJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5272170", Offset = "0x5271170", VA = "0x185272170")]
		private void ADJMGEHGKBO(KPMKOHNCKIH LCCGHHJFGDE, KPMKOHNCKIH ELFIACEEOOA, RigidTransform MLIDICHNJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x52764A0", Offset = "0x52754A0", VA = "0x1852764A0")]
		private void NNCBDNAGKDN(KPMKOHNCKIH KFGEJHIJBGK, KPMKOHNCKIH ELFIACEEOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x52729C0", Offset = "0x52719C0", VA = "0x1852729C0")]
		private void BEJDIAAMLCK(KPMKOHNCKIH ELFIACEEOOA, KPMKOHNCKIH ICMEPOIJCJO, RigidTransform MLIDICHNJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5273E10", Offset = "0x5272E10", VA = "0x185273E10")]
		private void FMPAKHPJGGB(PMFFIMLMCEJ GMOMNBJDADO, KPMKOHNCKIH CHCLCLFDGOH, PMFFIMLMCEJ PIKABCPMIJO, PMFFIMLMCEJ KAKGJMHAAEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5274160", Offset = "0x5273160", VA = "0x185274160")]
		private void ICHCDBOEHEO(PMFFIMLMCEJ GMOMNBJDADO, KPMKOHNCKIH CHCLCLFDGOH, KPMKOHNCKIH EFFFJAGCGFO, KPMKOHNCKIH DLELHOLCDPK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IIPBFHFKLPC
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class PCAHPDDJGJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public GBDCKFPNAEP container;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public PCAHPDDJGJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x52771A0", Offset = "0x52761A0", VA = "0x1852771A0")]
		internal OMConnectableManager <BindServices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x526B7F0", Offset = "0x526A7F0", VA = "0x18526B7F0")]
	public static void KIBCKHDFOPA(GBDCKFPNAEP FOIOPKEONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x526B9C0", Offset = "0x526A9C0", VA = "0x18526B9C0")]
	public static void MHDMIJKNFIM(GBDCKFPNAEP FOIOPKEONKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class HBPMENEHJPO : KKOBPPBAAKK, GECHFEJJMIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly RigidbodyEx MFNIBBKJICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly OMConnectableManager ACKDPDBNMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly BKMBCINBMPC HHCINEKAPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly GANLAMOBBBK ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly FBELOBIKDEA[] MGIKBAAHNMC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public PMFFIMLMCEJ KCKCDBCKCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x12770C0", Offset = "0x12760C0", VA = "0x1812770C0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(PMFFIMLMCEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KPMKOHNCKIH HAEAHMFNCKH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KPMKOHNCKIH HMHIHGPONEB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x525E960", Offset = "0x525D960", VA = "0x18525E960", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KPMKOHNCKIH MNEBHADCJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x525E550", Offset = "0x525D550", VA = "0x18525E550", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 IFKCDBNFANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x525D660", Offset = "0x525C660", VA = "0x18525D660", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Quaternion INKCJINFIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x525DFD0", Offset = "0x525CFD0", VA = "0x18525DFD0", Slot = "16")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool DLEHBLMJBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x525E480", Offset = "0x525D480", VA = "0x18525E480", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IEnumerable<KPMKOHNCKIH> PCLAAEOMOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x525DB70", Offset = "0x525CB70", VA = "0x18525DB70", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Obsolete]
	public bool KAOEENDHPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x969290", Offset = "0x968290", VA = "0x180969290", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x969430", Offset = "0x968430", VA = "0x180969430", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Transform DNKMJKOCMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x525EB80", Offset = "0x525DB80", VA = "0x18525EB80", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GameObject NAAHLJGFEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x525E8F0", Offset = "0x525D8F0", VA = "0x18525E8F0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string ADMEEJPABPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x525E910", Offset = "0x525D910", VA = "0x18525E910", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid PKNIIMKILEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x525EA50", Offset = "0x525DA50", VA = "0x18525EA50", Slot = "37")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int AAGACMAFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x525EB30", Offset = "0x525DB30", VA = "0x18525EB30", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MNAKGMMKOAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private bool PAFALICHBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x525E1F0", Offset = "0x525D1F0", VA = "0x18525E1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event PCNBHGACMBC CAPJNOBCNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x525E100", Offset = "0x525D100", VA = "0x18525E100", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x525DB20", Offset = "0x525CB20", VA = "0x18525DB20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event PCNBHGACMBC KCCBKANODHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x525DA30", Offset = "0x525CA30", VA = "0x18525DA30", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x525DE20", Offset = "0x525CE20", VA = "0x18525DE20", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PCNBHGACMBC PMLJIKDOLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x525DAD0", Offset = "0x525CAD0", VA = "0x18525DAD0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x525E6C0", Offset = "0x525D6C0", VA = "0x18525E6C0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event ILCFPEBAIBE KKIJPLMBFPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x525E150", Offset = "0x525D150", VA = "0x18525E150", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x525E3E0", Offset = "0x525D3E0", VA = "0x18525E3E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x525E810", Offset = "0x525D810", VA = "0x18525E810")]
	public HBPMENEHJPO(PMFFIMLMCEJ ALJACNMOIMH, RigidbodyEx MFNIBBKJICM, BKMBCINBMPC HHCINEKAPLC, FBELOBIKDEA[] MGIKBAAHNMC, GANLAMOBBBK ACNDHAIKGGB, BPFKJIFDLLM ACKDPDBNMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x525D3E0", Offset = "0x525C3E0", VA = "0x18525D3E0", Slot = "20")]
	public void BOCFGCJGKDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "22")]
	public void EOHGIKEPFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x525DED0", Offset = "0x525CED0", VA = "0x18525DED0", Slot = "23")]
	public void IJCONFGHCFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x525DA80", Offset = "0x525CA80", VA = "0x18525DA80", Slot = "21")]
	public void DBEFHDBAOPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x525D410", Offset = "0x525C410", VA = "0x18525D410", Slot = "26")]
	public void BOCPGLLIIGH(int DMNKBPKHFMI, KPMKOHNCKIH MBIJENMAKIB, int NPLLHDENIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x525E640", Offset = "0x525D640", VA = "0x18525E640", Slot = "27")]
	public void OGFDNFLFBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x525CCC0", Offset = "0x525BCC0", VA = "0x18525CCC0", Slot = "28")]
	public void BILIPIJGFAI(int DMNKBPKHFMI, KPMKOHNCKIH IDNMHKLJHMO, int HJKPFEDNMNJ, [Optional] Vector3? NFGBMNLOFOC, [Optional] Quaternion? AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x525E710", Offset = "0x525D710", VA = "0x18525E710", Slot = "29")]
	public void PIPOKHJMHGL(KPMKOHNCKIH IDNMHKLJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x525CFE0", Offset = "0x525BFE0", VA = "0x18525CFE0", Slot = "32")]
	public void BIOLLOCKHDL(Vector3 FHGCNDAAIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x525D6D0", Offset = "0x525C6D0", VA = "0x18525D6D0", Slot = "30")]
	public void CCMCDMHLLMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x525E240", Offset = "0x525D240", VA = "0x18525E240", Slot = "31")]
	public void LNCOKHMFDBD(int NPDGHPHAKDK, Vector3 NJAOOECBFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x525DD50", Offset = "0x525CD50", VA = "0x18525DD50", Slot = "42")]
	public Vector3 GetConnectionSlotPosition(int DMNKBPKHFMI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x525DC10", Offset = "0x525CC10", VA = "0x18525DC10", Slot = "41")]
	public Vector3 GetConnectionSlotLocalPosition(int DMNKBPKHFMI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x166BBA0", Offset = "0x166ABA0", VA = "0x18166BBA0", Slot = "43")]
	public Color GetConnectionSlotColor(int DMNKBPKHFMI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x525D990", Offset = "0x525C990", VA = "0x18525D990", Slot = "44")]
	public bool CanConnectTo(int DMNKBPKHFMI, KPMKOHNCKIH BOBEAHBBKHP, int FLPEOOIMCIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "45")]
	public void ParentChanged(int DMNKBPKHFMI, KPMKOHNCKIH ALOKGKABFDN, int DGMDADCGMCM, Vector3 IEPIDBHDIGG, Quaternion BAOCKMCLHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "46")]
	public void ChildAdded(int DMNKBPKHFMI, KPMKOHNCKIH GHEHIKACJLN, int MELOAOONLFA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "47")]
	public void ChildRemoved(int DMNKBPKHFMI, KPMKOHNCKIH AOHMKPFAPPH, int IONEMEOJOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "48")]
	public void ConnectionModified(int DMNKBPKHFMI, KPMKOHNCKIH MBIJENMAKIB, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x525E7F0", Offset = "0x525D7F0", VA = "0x18525E7F0", Slot = "49")]
	public void RootChanged(KPMKOHNCKIH GIPDHGHHJND, KPMKOHNCKIH PIOELDJFACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x525E4A0", Offset = "0x525D4A0", VA = "0x18525E4A0")]
	public bool NOHLHLNDIHM(KPMKOHNCKIH KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x525E790", Offset = "0x525D790", VA = "0x18525E790", Slot = "24")]
	public void PKCKPIMLADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x525E040", Offset = "0x525D040", VA = "0x18525E040", Slot = "25")]
	public void JIFCEJLJNHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x525DE70", Offset = "0x525CE70", VA = "0x18525DE70")]
	private void IAGNHLLEPKM(bool MJBBECAOCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x525E0A0", Offset = "0x525D0A0", VA = "0x18525E0A0")]
	private RigidbodyEx JIIKFJBHOBO(KPMKOHNCKIH HHCINEKAPLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DEJAKMDKDPE(typeof(HOOGGJCBAFC), new string[] { })]
public class OGFCJIAKGMO : HOOGGJCBAFC, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[GNFGKNINDPI]
	private ALAPBINNPIH ACNDHAIKGGB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public object LLGNMKNGGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5271AF0", Offset = "0x5270AF0", VA = "0x185271AF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5271B90", Offset = "0x5270B90", VA = "0x185271B90", Slot = "6")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5271BE0", Offset = "0x5270BE0", VA = "0x185271BE0", Slot = "5")]
	public void PMDDEOMLKOH(CIMNJIOJIIP FLOFPLIMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public OGFCJIAKGMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DEJAKMDKDPE(typeof(BPFKJIFDLLM), new string[] { "Ignore", "Mock" })]
public class ECBNADIDFIC : BPFKJIFDLLM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NMMHNMGCMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<KPMKOHNCKIH, KPMKOHNCKIH> KHEHPEBECLP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x525C590", Offset = "0x525B590", VA = "0x18525C590", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x525C6D0", Offset = "0x525B6D0", VA = "0x18525C6D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<KPMKOHNCKIH, KPMKOHNCKIH> HDCDKKEOCMG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x525C8B0", Offset = "0x525B8B0", VA = "0x18525C8B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x525C630", Offset = "0x525B630", VA = "0x18525C630", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<KPMKOHNCKIH, KPMKOHNCKIH, KPMKOHNCKIH> PIDOKNIFJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x525C770", Offset = "0x525B770", VA = "0x18525C770", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x525C810", Offset = "0x525B810", VA = "0x18525C810", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "11")]
	public void NAGCBALDEME(GameObject NCAOMIEGHPA, DLCALFALNAH BNLBBLEEPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "12")]
	public void PGLCEDHDGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "13")]
	public void MNFGPLMIANE(KPMKOHNCKIH CHCLCLFDGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "14")]
	public void MFJOMNDPBAP(KPMKOHNCKIH CHCLCLFDGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "15")]
	public void FAAOOAHHFAL(KPMKOHNCKIH CHCLCLFDGOH, HashSet<KPMKOHNCKIH> DMGDMCIDCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "16")]
	public void JJELGLHNKGB(KPMKOHNCKIH CHCLCLFDGOH, KPMKOHNCKIH FCOKOFOLAAM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "17")]
	public void PGGPPACHFKF(KPMKOHNCKIH CHCLCLFDGOH, int EJDIPMJMLEK, KPMKOHNCKIH LCCGHHJFGDE, int DGMDADCGMCM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "18")]
	public void ELMBMIBKAAE(KPMKOHNCKIH CHCLCLFDGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00", Slot = "19")]
	public bool KCJKPJNBNDI(KPMKOHNCKIH CHCLCLFDGOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x685170", Offset = "0x684170", VA = "0x180685170", Slot = "20")]
	public BGCFIBNNBIF FFMGIEJHAKP(bool OKGLNPCPFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x685170", Offset = "0x684170", VA = "0x180685170", Slot = "21")]
	public BGCFIBNNBIF IIIAIHGHLMM(HashSet<Guid> JNBOEEGMNBF, bool OKGLNPCPFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00", Slot = "22")]
	public bool LCJIJIJFMOM(JGDCJMONMPI GGCLNKGONMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "23")]
	public void GNMJKLDDDJL(BGCFIBNNBIF CCICHMPIDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "24")]
	public void OIKMJENJPCB(BGCFIBNNBIF CCICHMPIDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "25")]
	public void IGKMOHFCKNP(BGCFIBNNBIF CCICHMPIDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public ECBNADIDFIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HHBIKCHMBFH : LMGGLMPMLOP, AKFIDAIPMLM, IDisposable
{
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ConnectableLinkVisual : MonoBehaviour, HHBIKCHMBFH, LMGGLMPMLOP, AKFIDAIPMLM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Entity LMCIODJPIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Entity KFDBMMENHCC;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Entity MMMFCABBCIB
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120", Slot = "20")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xFE6B60", Offset = "0xFE5B60", VA = "0x180FE6B60", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Entity FMOIEHPNAKN
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0", Slot = "11")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xE50520", Offset = "0xE4F520", VA = "0x180E50520", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x525BBA0", Offset = "0x525ABA0", VA = "0x18525BBA0", Slot = "4")]
		private void CGJPNLMAIBH(KPMKOHNCKIH MBIJENMAKIB, APANAOMEIDB ELFIACEEOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x525BC60", Offset = "0x525AC60", VA = "0x18525BC60", Slot = "5")]
		private void EBPMPOKJEKM(KPMKOHNCKIH MBIJENMAKIB, APANAOMEIDB ELFIACEEOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x525B9B0", Offset = "0x525A9B0", VA = "0x18525B9B0", Slot = "6")]
		private void CFEEECCLPAO(KPMKOHNCKIH MBIJENMAKIB, APANAOMEIDB ELFIACEEOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x525C360", Offset = "0x525B360", VA = "0x18525C360", Slot = "7")]
		private void PAGOAOLDGBL(KPMKOHNCKIH MBIJENMAKIB, APANAOMEIDB ELFIACEEOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x525C140", Offset = "0x525B140", VA = "0x18525C140", Slot = "8")]
		private LMGGLMPMLOP IEAAPMLGGPL(Transform FLCFNMLPAML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x525C0E0", Offset = "0x525B0E0", VA = "0x18525C0E0", Slot = "9")]
		private void GGLHOHJPCLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x525BF80", Offset = "0x525AF80", VA = "0x18525BF80")]
		private void FAFPJPFNCCD(ref Entity IEFFOCOBJJI, Entity DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x525C290", Offset = "0x525B290", VA = "0x18525C290", Slot = "14")]
		private void NIBFJKPOAPF(float3 NJAOOECBFPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x525BF10", Offset = "0x525AF10", VA = "0x18525BF10", Slot = "13")]
		private void ELEGPPLAIIF(float3 NJAOOECBFPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x525BF90", Offset = "0x525AF90", VA = "0x18525BF90", Slot = "15")]
		private void FLMMLECCOBG(out float3 FHGIIAKFJFF, out float3 APIEJLBIMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x525C1C0", Offset = "0x525B1C0", VA = "0x18525C1C0", Slot = "16")]
		private void NCCCFFKNEAD(float3 FHGIIAKFJFF, float3 APIEJLBIMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x525C300", Offset = "0x525B300", VA = "0x18525C300", Slot = "17")]
		private void OAPJGJCACEE(Color FHGIIAKFJFF, Color APIEJLBIMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x525C060", Offset = "0x525B060", VA = "0x18525C060", Slot = "18")]
		private AKFIDAIPMLM GAOFJKOLDIG(Transform FLCFNMLPAML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x525C530", Offset = "0x525B530", VA = "0x18525C530", Slot = "19")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
		public ConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KPMKOHNCKIH : GECHFEJJMIP, IEquatable<KPMKOHNCKIH>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GECHFEJJMIP
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	KPMKOHNCKIH HMHIHGPONEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform DNKMJKOCMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject NAAHLJGFEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string ADMEEJPABPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid PKNIIMKILEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int AAGACMAFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	PMFFIMLMCEJ KCKCDBCKCEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool MNAKGMMKOAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int DMNKBPKHFMI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int DMNKBPKHFMI);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int DMNKBPKHFMI);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int DMNKBPKHFMI, KPMKOHNCKIH BOBEAHBBKHP, int FBBNFPNOBKF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int DMNKBPKHFMI, KPMKOHNCKIH ALOKGKABFDN, int DGMDADCGMCM, Vector3 IEPIDBHDIGG, Quaternion BAOCKMCLHJO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int DMNKBPKHFMI, KPMKOHNCKIH GHEHIKACJLN, int MELOAOONLFA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int DMNKBPKHFMI, KPMKOHNCKIH AOHMKPFAPPH, int IONEMEOJOAK);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int DMNKBPKHFMI, KPMKOHNCKIH MBIJENMAKIB, int KLNEJPFNAMP, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(KPMKOHNCKIH GIPDHGHHJND, KPMKOHNCKIH PIOELDJFACJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
public interface BPFKJIFDLLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NMMHNMGCMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<KPMKOHNCKIH, KPMKOHNCKIH> KHEHPEBECLP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<KPMKOHNCKIH, KPMKOHNCKIH> HDCDKKEOCMG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<KPMKOHNCKIH, KPMKOHNCKIH, KPMKOHNCKIH> PIDOKNIFJEE;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NAGCBALDEME(GameObject NCAOMIEGHPA, DLCALFALNAH BNLBBLEEPCO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PGLCEDHDGGL();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MNFGPLMIANE(KPMKOHNCKIH CHCLCLFDGOH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MFJOMNDPBAP(KPMKOHNCKIH CHCLCLFDGOH);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FAAOOAHHFAL(KPMKOHNCKIH CHCLCLFDGOH, HashSet<KPMKOHNCKIH> DMGDMCIDCIL);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JJELGLHNKGB(KPMKOHNCKIH CHCLCLFDGOH, KPMKOHNCKIH FCOKOFOLAAM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PGGPPACHFKF(KPMKOHNCKIH CHCLCLFDGOH, int EJDIPMJMLEK, KPMKOHNCKIH LCCGHHJFGDE, int DGMDADCGMCM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ELMBMIBKAAE(KPMKOHNCKIH CHCLCLFDGOH);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool KCJKPJNBNDI(KPMKOHNCKIH CHCLCLFDGOH);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	BGCFIBNNBIF FFMGIEJHAKP(bool OKGLNPCPFOP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	BGCFIBNNBIF IIIAIHGHLMM(HashSet<Guid> JNBOEEGMNBF, bool OKGLNPCPFOP);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool LCJIJIJFMOM(JGDCJMONMPI GGCLNKGONMF);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GNMJKLDDDJL(BGCFIBNNBIF CCICHMPIDIO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OIKMJENJPCB(BGCFIBNNBIF CCICHMPIDIO);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IGKMOHFCKNP(BGCFIBNNBIF CCICHMPIDIO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GGKOKFAIBOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool NFCFBKFCBOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KPMKOHNCKIH JCLJLIDOMLC(int BCGEJGIGJCJ);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KPMKOHNCKIH DNJCALAMJIA(Guid ODACDPGHBIM);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KMPEDOPNEOJ(KPMKOHNCKIH CHCLCLFDGOH, out Guid FBKLHONPMNF);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JFMELLNKOLC(KPMKOHNCKIH CHCLCLFDGOH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NHKEFKKHKPF();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DFLFDIILPEJ(KPMKOHNCKIH HHCINEKAPLC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[LGHOGGGGJFL(KHFGEOAKOKD.Application)]
public interface GANLAMOBBBK
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PAFALICHBEH(BKMBCINBMPC HHCINEKAPLC);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LCNBDBACPBG(BKMBCINBMPC HHCINEKAPLC);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string OBEJBNLCOLL(BKMBCINBMPC HHCINEKAPLC);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid GFGONAKGCFN(BKMBCINBMPC HHCINEKAPLC);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int JAHKIEEMKEA(BKMBCINBMPC HHCINEKAPLC);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PDOGNHINBBN(KPMKOHNCKIH HHCINEKAPLC, Action<LEBJFIIAEDE> KAOMDFGLGCE);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DGGOOOEENLK(KPMKOHNCKIH HHCINEKAPLC, Action<LEBJFIIAEDE> KAOMDFGLGCE);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PGOCHDDGKHC(BKMBCINBMPC HHCINEKAPLC);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AHDNEILEDEG(BKMBCINBMPC HHCINEKAPLC);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DFLFDIILPEJ(BKMBCINBMPC HHCINEKAPLC);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JMBEDBNALPJ(BKMBCINBMPC HHCINEKAPLC, object KCCFEDJJGAN);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ECHNEHIIGJK(BKMBCINBMPC HHCINEKAPLC, object KCCFEDJJGAN);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	RigidbodyEx JIIKFJBHOBO(KPMKOHNCKIH HHCINEKAPLC);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MGLKHALMBDN OMBCPAFNPBI(BKMBCINBMPC KPJEGNGKPOH, string PIIJMEAKDGO, bool PGBDPKDFJME, GCOJLBAOHJF KNBHBEFNIKP, Action KDDLOKAHKOL);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HDADMBKMKLH(KKOBPPBAAKK NGHNMICFNCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void PCNBHGACMBC(KPMKOHNCKIH IDNMHKLJHMO, int OANKLIJABOA, KPMKOHNCKIH MBIJENMAKIB, int EBJIALCBIDB, [Optional] Vector3? NFGBMNLOFOC, [Optional] Quaternion? AELLGGHNCPI);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void ILCFPEBAIBE(KPMKOHNCKIH GIPDHGHHJND, KPMKOHNCKIH PIOELDJFACJ);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool KENHBHBBDFM(int DMNKBPKHFMI, KPMKOHNCKIH BOBEAHBBKHP, int FLPEOOIMCIB);
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BKMBCINBMPC : KPMKOHNCKIH, GECHFEJJMIP, IEquatable<KPMKOHNCKIH>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	KKOBPPBAAKK MHHPNCOAAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KKOBPPBAAKK : GECHFEJJMIP
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KPMKOHNCKIH HAEAHMFNCKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	KPMKOHNCKIH MNEBHADCJOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	IEnumerable<KPMKOHNCKIH> PCLAAEOMOCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Vector3 IFKCDBNFANA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	Quaternion INKCJINFIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool DLEHBLMJBFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool KAOEENDHPMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event PCNBHGACMBC CAPJNOBCNEH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event PCNBHGACMBC KCCBKANODHP;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event PCNBHGACMBC PMLJIKDOLFP;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event ILCFPEBAIBE KKIJPLMBFPC;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BOCFGCJGKDH();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DBEFHDBAOPI();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EOHGIKEPFJI();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IJCONFGHCFD();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PKCKPIMLADK();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JIFCEJLJNHL();

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BOCPGLLIIGH(int DMNKBPKHFMI, KPMKOHNCKIH MBIJENMAKIB, int NPLLHDENIEA);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void OGFDNFLFBKI();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BILIPIJGFAI(int DMNKBPKHFMI, KPMKOHNCKIH IDNMHKLJHMO, int HJKPFEDNMNJ, [Optional] Vector3? NFGBMNLOFOC, [Optional] Quaternion? AELLGGHNCPI);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void PIPOKHJMHGL(KPMKOHNCKIH IDNMHKLJHMO);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CCMCDMHLLMH();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LNCOKHMFDBD(int NPDGHPHAKDK, Vector3 NJAOOECBFPE);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BIOLLOCKHDL(Vector3 FHGCNDAAIOI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FBELOBIKDEA
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Vector3 NGKPOMNIDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DLCALFALNAH
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool GLNCNLNMOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	HHBIKCHMBFH FKAFBLEIFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	HHBIKCHMBFH BMNLPFFBMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CreateAssetMenu]
	public class ConnectableConfigData : ScriptableObject, DLCALFALNAH
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		[FormerlySerializedAs("linkVisualPrefab")]
		private ConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private ConnectableLinkVisual objectModelLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x6988D0", Offset = "0x6978D0", VA = "0x1806988D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public HHBIKCHMBFH LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HHBIKCHMBFH ObjectModelLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x525B8C0", Offset = "0x525A8C0", VA = "0x18525B8C0")]
		public static ConnectableConfigData JKDLFHIKAAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x525B960", Offset = "0x525A960", VA = "0x18525B960")]
		public ConnectableConfigData(ConnectableLinkVisual IDOCHOLCNEG, bool MNHLGCPIOMD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct APANAOMEIDB : IEquatable<APANAOMEIDB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public KPMKOHNCKIH CHCLCLFDGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int CIHAFBNOKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int KLNEJPFNAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Vector3 NFGBMNLOFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Quaternion AELLGGHNCPI;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x525B400", Offset = "0x525A400", VA = "0x18525B400")]
	public APANAOMEIDB(KPMKOHNCKIH CHCLCLFDGOH, int CIHAFBNOKMD, int KLNEJPFNAMP, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x525B390", Offset = "0x525A390", VA = "0x18525B390")]
	public APANAOMEIDB(KPMKOHNCKIH CHCLCLFDGOH, int CIHAFBNOKMD, int KLNEJPFNAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x525B340", Offset = "0x525A340", VA = "0x18525B340")]
	public APANAOMEIDB(KPMKOHNCKIH CHCLCLFDGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x525AE90", Offset = "0x5259E90", VA = "0x18525AE90", Slot = "4")]
	public bool Equals(APANAOMEIDB KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x525AF30", Offset = "0x5259F30", VA = "0x18525AF30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
public class CGPPBCJKJLL : NGHELCNOLNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Transform FLCFNMLPAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private LMGGLMPMLOP INPOEMAHJFA;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x372FBD0", Offset = "0x372EBD0", VA = "0x18372FBD0", Slot = "4")]
	public void NAGCBALDEME(Transform FLCFNMLPAML, LMGGLMPMLOP INPOEMAHJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x525B460", Offset = "0x525A460", VA = "0x18525B460", Slot = "5")]
	public LMGGLMPMLOP COEMJLAHNEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x525B4B0", Offset = "0x525A4B0", VA = "0x18525B4B0", Slot = "6")]
	public void HIGGIECAHDI(LMGGLMPMLOP PGBEHMDABBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public CGPPBCJKJLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal class HJGKNMFMEKI : IDisposable, DHEBCONPKIF
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class OLJCDDJJJMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public KPMKOHNCKIH oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public KPMKOHNCKIH newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public OLJCDDJJJMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5271CC0", Offset = "0x5270CC0", VA = "0x185271CC0")]
		internal bool <NotifyRootChangedRecurse>b__0(JJAEGKNNBID node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IMJHFECKHBA JKHKMMKGJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private KJBEOLLHNJE JLJGAMCGJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private FIPDBDFIOFE PGEAEBLBOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private bool MNHLGCPIOMD;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public JJAEGKNNBID GHOIKAHCODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x52634E0", Offset = "0x52624E0", VA = "0x1852634E0")]
	public bool BPHNEIHGOPP(in ODHNNINODBN FILAKGLBGGA, bool IPCMJCEPDKB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x52666F0", Offset = "0x52656F0", VA = "0x1852666F0")]
	private bool KPIJNGFMPFA(in ODHNNINODBN FILAKGLBGGA, bool IPCMJCEPDKB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x52671C0", Offset = "0x52661C0", VA = "0x1852671C0", Slot = "8")]
	public bool PEIGHKJAOGF(KPMKOHNCKIH PCBNGCNCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5263600", Offset = "0x5262600", VA = "0x185263600")]
	private bool CALPMBDCKLO(KPMKOHNCKIH BNCBNALGOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5265470", Offset = "0x5264470", VA = "0x185265470")]
	private static bool IJMNDNIEOGF(KPMKOHNCKIH BNCBNALGOOI, IMJHFECKHBA PMPBMGKPHEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5264500", Offset = "0x5263500", VA = "0x185264500")]
	private void FGLPILNBNNN(Transform NKPBMLNLGOF, IMJHFECKHBA AEBEKBMKDAC, IMJHFECKHBA[] OMOEIBDFJGC, KPMKOHNCKIH LGCNNENDCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5267030", Offset = "0x5266030", VA = "0x185267030")]
	private APANAOMEIDB PDPIMCNBOGB(Transform CJIJJFGJFAC, APANAOMEIDB BBJPMICIDII)
	{
		return default(APANAOMEIDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5266DD0", Offset = "0x5265DD0", VA = "0x185266DD0")]
	private static bool NLGFNIEFADO(IMJHFECKHBA PMPBMGKPHEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5266F60", Offset = "0x5265F60", VA = "0x185266F60")]
	private string OBEJBNLCOLL(KPMKOHNCKIH CHCLCLFDGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5265B60", Offset = "0x5264B60", VA = "0x185265B60")]
	private string JAHKIEEMKEA(KPMKOHNCKIH CHCLCLFDGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5262A30", Offset = "0x5261A30", VA = "0x185262A30")]
	private void AKIHGHCFINB(in ODHNNINODBN FILAKGLBGGA, bool CDAAFMCMHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x52631E0", Offset = "0x52621E0", VA = "0x1852631E0")]
	private void BEGICFEGIED(KPMKOHNCKIH ELFIACEEOOA, bool CDAAFMCMHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5264930", Offset = "0x5263930", VA = "0x185264930")]
	private void FIHPPAGMGCJ(KPMKOHNCKIH PDBBNEHABLO, int HJKPFEDNMNJ, KPMKOHNCKIH LCCGHHJFGDE, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI, bool CDAAFMCMHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5265520", Offset = "0x5264520", VA = "0x185265520")]
	private void INABEMPMOLD(KPMKOHNCKIH AMEGHIFMHKK, int HJKPFEDNMNJ, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI, bool CCEDBFCAGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x52640E0", Offset = "0x52630E0", VA = "0x1852640E0", Slot = "9")]
	public bool EMALIIFENNA(KPMKOHNCKIH AMEGHIFMHKK, int HJKPFEDNMNJ, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5266120", Offset = "0x5265120", VA = "0x185266120")]
	private bool JPHBIDDJPKO(KPMKOHNCKIH AMEGHIFMHKK, int HJKPFEDNMNJ, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5263F30", Offset = "0x5262F30", VA = "0x185263F30")]
	private static void DMPBCGBKMCO(KPMKOHNCKIH AMEGHIFMHKK, int HJKPFEDNMNJ, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI, IMJHFECKHBA HCBEAKJJHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5263E10", Offset = "0x5262E10", VA = "0x185263E10")]
	private void DMBHMCDLCIC(KPMKOHNCKIH PDBBNEHABLO, int EJDIPMJMLEK, KPMKOHNCKIH LCCGHHJFGDE, int DGMDADCGMCM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5266CD0", Offset = "0x5265CD0", VA = "0x185266CD0")]
	private void MMNBJLDCGNL(IMJHFECKHBA ABKPGPJAFGM, KPMKOHNCKIH EFFFJAGCGFO, KPMKOHNCKIH DLELHOLCDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5266C60", Offset = "0x5265C60", VA = "0x185266C60")]
	private void MMNBJLDCGNL(KPMKOHNCKIH CHCLCLFDGOH, KPMKOHNCKIH EFFFJAGCGFO, KPMKOHNCKIH DLELHOLCDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5265350", Offset = "0x5264350", VA = "0x185265350")]
	private void ICHCDBOEHEO(KPMKOHNCKIH CHCLCLFDGOH, KPMKOHNCKIH EFFFJAGCGFO, KPMKOHNCKIH DLELHOLCDPK, bool CCDLJLHECME = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5265240", Offset = "0x5264240", VA = "0x185265240")]
	private void ICHCDBOEHEO(IMJHFECKHBA JMLKLPJONJN, KPMKOHNCKIH LGCNNENDCBP, KPMKOHNCKIH PIOELDJFACJ, bool CCDLJLHECME = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5262920", Offset = "0x5261920", VA = "0x185262920")]
	private void ADJMGEHGKBO(KPMKOHNCKIH ELFIACEEOOA, int HJKPFEDNMNJ, KPMKOHNCKIH LCCGHHJFGDE, int DGMDADCGMCM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5266E00", Offset = "0x5265E00", VA = "0x185266E00")]
	private void NNCBDNAGKDN(JJAEGKNNBID ICMEPOIJCJO, JJAEGKNNBID AECDIOOBDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x52633B0", Offset = "0x52623B0", VA = "0x1852633B0", Slot = "13")]
	public void BHJKBDEJFMM(KPMKOHNCKIH CHCLCLFDGOH, out Vector3 NFGBMNLOFOC, out Quaternion AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5263CE0", Offset = "0x5262CE0", VA = "0x185263CE0", Slot = "14")]
	public KPMKOHNCKIH DKCDGKDHBGE(KPMKOHNCKIH CHCLCLFDGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x52641C0", Offset = "0x52631C0", VA = "0x1852641C0", Slot = "15")]
	public void FAAOOAHHFAL(KPMKOHNCKIH CHCLCLFDGOH, HashSet<KPMKOHNCKIH> MLIFLOCHADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5264F40", Offset = "0x5263F40", VA = "0x185264F40", Slot = "16")]
	public List<KPMKOHNCKIH> GBPDNAJKEBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5263110", Offset = "0x5262110", VA = "0x185263110")]
	protected JJAEGKNNBID APNCMMEMPIA(JJAEGKNNBID ABKPGPJAFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5263070", Offset = "0x5262070", VA = "0x185263070")]
	protected IMJHFECKHBA[] APAJKGGPDOB(IMJHFECKHBA PMPBMGKPHEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5263530", Offset = "0x5262530", VA = "0x185263530")]
	protected bool CAIEBPLPHFO(KPMKOHNCKIH CHCLCLFDGOH, out IMJHFECKHBA ABKPGPJAFGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5263BE0", Offset = "0x5262BE0", VA = "0x185263BE0", Slot = "17")]
	public bool CDGDNLLMEBP(KPMKOHNCKIH CHCLCLFDGOH, out APANAOMEIDB HBILENHKDCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x52673A0", Offset = "0x52663A0", VA = "0x1852673A0")]
	protected IMJHFECKHBA PFINJBCMECN(APANAOMEIDB OOJKAGKDKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5265150", Offset = "0x5264150", VA = "0x185265150", Slot = "10")]
	public bool HKFOKMGHJCO(KPMKOHNCKIH PDBBNEHABLO, int EJDIPMJMLEK, KPMKOHNCKIH LCCGHHJFGDE, int DGMDADCGMCM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5265BD0", Offset = "0x5264BD0", VA = "0x185265BD0")]
	private bool JJIDGFIJMGP(KPMKOHNCKIH PDBBNEHABLO, int EJDIPMJMLEK, KPMKOHNCKIH LCCGHHJFGDE, int DGMDADCGMCM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x52673E0", Offset = "0x52663E0", VA = "0x1852673E0")]
	private static bool PPLHINKEPAE(IMJHFECKHBA JJFALFICLPH, APANAOMEIDB AJLFPCLDMLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x52674B0", Offset = "0x52664B0", VA = "0x1852674B0")]
	public HJGKNMFMEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5266D40", Offset = "0x5265D40", VA = "0x185266D40", Slot = "5")]
	public void NAGCBALDEME(BPFKJIFDLLM CLAEEJIDJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x52640B0", Offset = "0x52630B0", VA = "0x1852640B0", Slot = "19")]
	public void EAMOMPNGLDD(CONAAFDNKIG KDDLOKAHKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x52663B0", Offset = "0x52653B0", VA = "0x1852663B0", Slot = "12")]
	public void KEHBBPBLJEM(Func<KPMKOHNCKIH, bool> AMFBLPOGNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x52663C0", Offset = "0x52653C0", VA = "0x1852663C0")]
	private void KEHBBPBLJEM(IMJHFECKHBA ABKPGPJAFGM, Func<KPMKOHNCKIH, bool> AMFBLPOGNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5264F20", Offset = "0x5263F20", VA = "0x185264F20", Slot = "11")]
	public void FJKLKALBMMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x52634E0", Offset = "0x52624E0", VA = "0x1852634E0", Slot = "7")]
	private bool IKJJJGEJACN(in ODHNNINODBN FILAKGLBGGA, bool IPCMJCEPDKB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Preserve]
internal class MOEOOJDABNB : BPFKJIFDLLM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly GBDCKFPNAEP FOIOPKEONKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly FIPDBDFIOFE PGEAEBLBOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly HJNHMCPIKMA KBMJBDKIJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly IBFNLOHOCEI OLPNBPCMPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly DHEBCONPKIF CCICHMPIDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal IOHKJBMAPKK ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal HJEKPMDDOHL GNPHKIFHPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal KJBEOLLHNJE KODMFBONEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal bool MNHLGCPIOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool ELDGFJIFKOM;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool NJHAKHGIBMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x109C6B0", Offset = "0x109B6B0", VA = "0x18109C6B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xDA3620", Offset = "0xDA2620", VA = "0x180DA3620")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool NMMHNMGCMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xAFA550", Offset = "0xAF9550", VA = "0x180AFA550", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x109C6C0", Offset = "0x109B6C0", VA = "0x18109C6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<KPMKOHNCKIH, KPMKOHNCKIH> KHEHPEBECLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x526FEC0", Offset = "0x526EEC0", VA = "0x18526FEC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x52708F0", Offset = "0x526F8F0", VA = "0x1852708F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<KPMKOHNCKIH, KPMKOHNCKIH> HDCDKKEOCMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x52715D0", Offset = "0x52705D0", VA = "0x1852715D0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5270270", Offset = "0x526F270", VA = "0x185270270", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<KPMKOHNCKIH, KPMKOHNCKIH, KPMKOHNCKIH> PIDOKNIFJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5271380", Offset = "0x5270380", VA = "0x185271380", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x52713E0", Offset = "0x52703E0", VA = "0x1852713E0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5271630", Offset = "0x5270630", VA = "0x185271630")]
	public MOEOOJDABNB(GBDCKFPNAEP FOIOPKEONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5270A30", Offset = "0x526FA30", VA = "0x185270A30", Slot = "11")]
	public void NAGCBALDEME(GameObject NCAOMIEGHPA, DLCALFALNAH BNLBBLEEPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x526FC60", Offset = "0x526EC60", VA = "0x18526FC60", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5271580", Offset = "0x5270580", VA = "0x185271580", Slot = "12")]
	public void PGLCEDHDGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5270A10", Offset = "0x526FA10", VA = "0x185270A10", Slot = "13")]
	public void MNFGPLMIANE(KPMKOHNCKIH CHCLCLFDGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x52709B0", Offset = "0x526F9B0", VA = "0x1852709B0", Slot = "14")]
	public void MFJOMNDPBAP(KPMKOHNCKIH CHCLCLFDGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x52708E0", Offset = "0x526F8E0", VA = "0x1852708E0", Slot = "22")]
	public bool LCJIJIJFMOM(JGDCJMONMPI GGCLNKGONMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5270820", Offset = "0x526F820", VA = "0x185270820")]
	internal bool KPIJNGFMPFA(in ODHNNINODBN FILAKGLBGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5270740", Offset = "0x526F740", VA = "0x185270740")]
	internal bool JJIDGFIJMGP(in ODHNNINODBN FILAKGLBGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5270950", Offset = "0x526F950", VA = "0x185270950")]
	internal bool MCJPBIMHMNG(in ODHNNINODBN FILAKGLBGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5270130", Offset = "0x526F130", VA = "0x185270130")]
	internal bool IKBOGJCEODO(in ODHNNINODBN FILAKGLBGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5270FB0", Offset = "0x526FFB0", VA = "0x185270FB0")]
	internal void NJMGPFKBBHD(KPMKOHNCKIH CHCLCLFDGOH, int JJOCOFBIHBB, bool IPCMJCEPDKB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x52709B0", Offset = "0x526F9B0", VA = "0x1852709B0")]
	internal bool MKKCFDGBPCM(KPMKOHNCKIH KHLMKNFPJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x526FAD0", Offset = "0x526EAD0", VA = "0x18526FAD0")]
	internal bool BIHCEKFLBII(KPMKOHNCKIH AMEGHIFMHKK, int HJKPFEDNMNJ, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x526FF20", Offset = "0x526EF20", VA = "0x18526FF20", Slot = "15")]
	public void FAAOOAHHFAL(KPMKOHNCKIH CHCLCLFDGOH, HashSet<KPMKOHNCKIH> DMGDMCIDCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5270530", Offset = "0x526F530", VA = "0x185270530", Slot = "16")]
	public void JJELGLHNKGB(KPMKOHNCKIH AMEGHIFMHKK, KPMKOHNCKIH FCOKOFOLAAM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5271190", Offset = "0x5270190", VA = "0x185271190")]
	public void NPILMBAKPGN(KPMKOHNCKIH IDNMHKLJHMO, int HJKPFEDNMNJ, KPMKOHNCKIH MBIJENMAKIB, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x526FC00", Offset = "0x526EC00", VA = "0x18526FC00")]
	public void CADCGPOHLPA(KPMKOHNCKIH PCBNGCNCOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x52703F0", Offset = "0x526F3F0", VA = "0x1852703F0")]
	public void JJELGLHNKGB(KPMKOHNCKIH AMEGHIFMHKK, KPMKOHNCKIH FCOKOFOLAAM, int HJKPFEDNMNJ, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5271440", Offset = "0x5270440", VA = "0x185271440", Slot = "17")]
	public void PGGPPACHFKF(KPMKOHNCKIH PDBBNEHABLO, int EJDIPMJMLEK, KPMKOHNCKIH LCCGHHJFGDE, int DGMDADCGMCM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x526FD00", Offset = "0x526ED00", VA = "0x18526FD00", Slot = "18")]
	public void ELMBMIBKAAE(KPMKOHNCKIH PDBBNEHABLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x52707D0", Offset = "0x526F7D0", VA = "0x1852707D0", Slot = "19")]
	public bool KCJKPJNBNDI(KPMKOHNCKIH CHCLCLFDGOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x52702D0", Offset = "0x526F2D0", VA = "0x1852702D0")]
	public void IPAGLEFFAEI([Optional] LEBJFIIAEDE KGMMBGCDCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5270040", Offset = "0x526F040", VA = "0x185270040", Slot = "23")]
	public void GNMJKLDDDJL(BGCFIBNNBIF CCICHMPIDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5270020", Offset = "0x526F020", VA = "0x185270020", Slot = "20")]
	public BGCFIBNNBIF FFMGIEJHAKP(bool OKGLNPCPFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5270110", Offset = "0x526F110", VA = "0x185270110", Slot = "21")]
	public BGCFIBNNBIF IIIAIHGHLMM(HashSet<Guid> JNBOEEGMNBF, bool OKGLNPCPFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x52700D0", Offset = "0x526F0D0", VA = "0x1852700D0", Slot = "25")]
	public void IGKMOHFCKNP(BGCFIBNNBIF CCICHMPIDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x52712D0", Offset = "0x52702D0", VA = "0x1852712D0", Slot = "24")]
	public void OIKMJENJPCB(BGCFIBNNBIF CCICHMPIDIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class FIPDBDFIOFE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly global::BKNNAJHBPLG<KPMKOHNCKIH, KPMKOHNCKIH> KHEHPEBECLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly global::BKNNAJHBPLG<KPMKOHNCKIH, KPMKOHNCKIH> HDCDKKEOCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly global::OEHJHDHJDOL<KPMKOHNCKIH, KPMKOHNCKIH, KPMKOHNCKIH> PIDOKNIFJEE;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x525CA90", Offset = "0x525BA90", VA = "0x18525CA90")]
	public FIPDBDFIOFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public void NAGCBALDEME(MOEOOJDABNB CLAEEJIDJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x525CA30", Offset = "0x525BA30", VA = "0x18525CA30")]
	public void IOPILBGJBIJ(KPMKOHNCKIH ICMEPOIJCJO, KPMKOHNCKIH ELFIACEEOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x525C950", Offset = "0x525B950", VA = "0x18525C950")]
	public void CMNPHHJKIMF(KPMKOHNCKIH ICMEPOIJCJO, KPMKOHNCKIH ELFIACEEOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x525C9B0", Offset = "0x525B9B0", VA = "0x18525C9B0")]
	public void GNCAJNFAGLK(KPMKOHNCKIH KFGEJHIJBGK, KPMKOHNCKIH LCCGHHJFGDE, KPMKOHNCKIH ELFIACEEOOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class HJNHMCPIKMA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private MOEOOJDABNB CLAEEJIDJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private HJEKPMDDOHL GNPHKIFHPOM;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public HJNHMCPIKMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x52678D0", Offset = "0x52668D0", VA = "0x1852678D0")]
	public void NAGCBALDEME(MOEOOJDABNB CLAEEJIDJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5267620", Offset = "0x5266620", VA = "0x185267620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x52678B0", Offset = "0x52668B0", VA = "0x1852678B0")]
	private void GJDNJJBAAKD(LEBJFIIAEDE JMJDGCPGKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5267840", Offset = "0x5266840", VA = "0x185267840")]
	private void GGMHBPKJMJF(LEBJFIIAEDE AMBOEHLAAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5267740", Offset = "0x5266740", VA = "0x185267740")]
	public void FMGNOICIEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5267630", Offset = "0x5266630", VA = "0x185267630")]
	public void FALLEGGIHIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class LOKOLOLBBOA
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class COGFLEJKNPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GBDCKFPNAEP container;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public COGFLEJKNPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x525B500", Offset = "0x525A500", VA = "0x18525B500")]
		internal MOEOOJDABNB <BindServices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x526D660", Offset = "0x526C660", VA = "0x18526D660")]
	public static void KIBCKHDFOPA(GBDCKFPNAEP FOIOPKEONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x526D860", Offset = "0x526C860", VA = "0x18526D860")]
	public static void MHDMIJKNFIM(GBDCKFPNAEP FOIOPKEONKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
internal class ICGELMNHFEF : IDisposable, KJBEOLLHNJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Dictionary<int, LMGGLMPMLOP> NIFNHPEPNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly CONAAFDNKIG DNKIKLCICAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private NGHELCNOLNH POMNPEGOOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private DHEBCONPKIF CCICHMPIDIO;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x526B720", Offset = "0x526A720", VA = "0x18526B720")]
	public ICGELMNHFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x526B3C0", Offset = "0x526A3C0", VA = "0x18526B3C0", Slot = "7")]
	public void NAGCBALDEME(DHEBCONPKIF CCICHMPIDIO, NGHELCNOLNH POMNPEGOOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x526AE60", Offset = "0x5269E60", VA = "0x18526AE60", Slot = "5")]
	public void GNDIECJBMGL(JJAEGKNNBID GHEOIAGEGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x526B0A0", Offset = "0x526A0A0", VA = "0x18526B0A0", Slot = "9")]
	public void HMBPHCFMGOD(JJAEGKNNBID GDKCFGKKNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x526B210", Offset = "0x526A210", VA = "0x18526B210", Slot = "8")]
	public void HPGNEGEPGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x526B400", Offset = "0x526A400", VA = "0x18526B400", Slot = "10")]
	public void PMKNCDCPIDL(JJAEGKNNBID AMEDDHBPGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x526ADA0", Offset = "0x5269DA0", VA = "0x18526ADA0", Slot = "11")]
	public void DDDINIEIDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x526AC00", Offset = "0x5269C00", VA = "0x18526AC00")]
	private bool CGOJHMMFPBD(JJAEGKNNBID HOHFMJFIEBG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class IBFNLOHOCEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal struct MHBOKJCBAFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly IMJHFECKHBA HJOLDEHKEKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly HashSet<Guid> JNBOEEGMNBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly JGDCJMONMPI NLDPDCMHLGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly JGDCJMONMPI NMOGBNLAGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly bool OKGLNPCPFOP;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private bool MDBBDPDPMJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x526F2D0", Offset = "0x526E2D0", VA = "0x18526F2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x526F8C0", Offset = "0x526E8C0", VA = "0x18526F8C0")]
		public MHBOKJCBAFJ(IMJHFECKHBA HJOLDEHKEKP, HashSet<Guid> JNBOEEGMNBF, bool OKGLNPCPFOP, [Optional] JGDCJMONMPI NLDPDCMHLGD, [Optional] JGDCJMONMPI NMOGBNLAGIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x526F760", Offset = "0x526E760", VA = "0x18526F760")]
		public JGDCJMONMPI PNKNJNLKBEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x526F070", Offset = "0x526E070", VA = "0x18526F070")]
		private JGDCJMONMPI ADFHPCABEFG(out JGDCJMONMPI PACMIPOHAFG, out JGDCJMONMPI NFPNPBGFIFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x526F3E0", Offset = "0x526E3E0", VA = "0x18526F3E0")]
		private JGDCJMONMPI NJNDOKJGEEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x526F5E0", Offset = "0x526E5E0", VA = "0x18526F5E0")]
		private void NNAADDACINK(JGDCJMONMPI JDNBEIMGDJL, JGDCJMONMPI HAKHJLDEFPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x526F130", Offset = "0x526E130", VA = "0x18526F130")]
		private void EGKFGMEDGJD(JGDCJMONMPI PACMIPOHAFG, JGDCJMONMPI NFPNPBGFIFA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private MOEOOJDABNB CLAEEJIDJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private DHEBCONPKIF CCICHMPIDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private KJBEOLLHNJE JLJGAMCGJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private HJEKPMDDOHL GNPHKIFHPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool HEKGLCEAOKK;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool OFIGFFFGGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5268EF0", Offset = "0x5267EF0", VA = "0x185268EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool NJHAKHGIBMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5268ED0", Offset = "0x5267ED0", VA = "0x185268ED0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x5269980", Offset = "0x5268980", VA = "0x185269980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x526A3A0", Offset = "0x52693A0", VA = "0x18526A3A0")]
	public void NAGCBALDEME(MOEOOJDABNB CLAEEJIDJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5268580", Offset = "0x5267580", VA = "0x185268580")]
	public BGCFIBNNBIF FFMGIEJHAKP(bool OKGLNPCPFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x52691C0", Offset = "0x52681C0", VA = "0x1852691C0")]
	public BGCFIBNNBIF IIIAIHGHLMM(HashSet<Guid> JNBOEEGMNBF, bool OKGLNPCPFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5268E40", Offset = "0x5267E40", VA = "0x185268E40")]
	public void GNMJKLDDDJL(BGCFIBNNBIF CCICHMPIDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x526A870", Offset = "0x5269870", VA = "0x18526A870")]
	public void OIKMJENJPCB(BGCFIBNNBIF CCICHMPIDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x526A070", Offset = "0x5269070", VA = "0x18526A070")]
	public void KOLJGKIEION(BGCFIBNNBIF CCICHMPIDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x52683F0", Offset = "0x52673F0", VA = "0x1852683F0")]
	private void EOMALEGPJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x526A410", Offset = "0x5269410", VA = "0x18526A410")]
	private JGDCJMONMPI NOCAOLGNDKE(IMJHFECKHBA ABKPGPJAFGM, bool OKGLNPCPFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5268F40", Offset = "0x5267F40", VA = "0x185268F40")]
	private static void HLFKELMFFDI(IMJHFECKHBA ABKPGPJAFGM, bool OKGLNPCPFOP, JGDCJMONMPI GGCLNKGONMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5268C40", Offset = "0x5267C40", VA = "0x185268C40")]
	private void GGMKMGLMOMJ(IMJHFECKHBA ABKPGPJAFGM, bool OKGLNPCPFOP, JGDCJMONMPI GGCLNKGONMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5269E80", Offset = "0x5268E80", VA = "0x185269E80")]
	private JGDCJMONMPI JMPLMHJOFNO(IMJHFECKHBA HJOLDEHKEKP, HashSet<Guid> JNBOEEGMNBF, bool OKGLNPCPFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x526A5F0", Offset = "0x52695F0", VA = "0x18526A5F0")]
	private bool OENEEOODDAF(BGCFIBNNBIF MEDNOHMHDIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5267A10", Offset = "0x5266A10", VA = "0x185267A10")]
	private bool AINKHODEAOD(JGDCJMONMPI GGCLNKGONMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5268050", Offset = "0x5267050", VA = "0x185268050")]
	private bool BLJMEAJIEMM(BGCFIBNNBIF CCICHMPIDIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x526AA90", Offset = "0x5269A90", VA = "0x18526AA90")]
	private static bool PIECBGMLPFA(JGDCJMONMPI GGCLNKGONMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x526A0A0", Offset = "0x52690A0", VA = "0x18526A0A0")]
	public static bool LCJIJIJFMOM(JGDCJMONMPI GGCLNKGONMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5269B30", Offset = "0x5268B30", VA = "0x185269B30")]
	private KPMKOHNCKIH JEBPCJLJMHL(JGDCJMONMPI GGCLNKGONMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x52699A0", Offset = "0x52689A0", VA = "0x1852699A0")]
	private KPMKOHNCKIH JCLJLIDOMLC(JGDCJMONMPI GGCLNKGONMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x526A910", Offset = "0x5269910", VA = "0x18526A910")]
	private KPMKOHNCKIH PAEIOMODCBJ(JGDCJMONMPI GGCLNKGONMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x526A360", Offset = "0x5269360", VA = "0x18526A360")]
	private static Guid MJHHOKPDPIF(JGDCJMONMPI GGCLNKGONMF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5268070", Offset = "0x5267070", VA = "0x185268070")]
	private string CJECPIIHOLE(JGDCJMONMPI GGCLNKGONMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5269F10", Offset = "0x5268F10", VA = "0x185269F10")]
	private bool KJICMDABKBD(IMJHFECKHBA ABKPGPJAFGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5268150", Offset = "0x5267150", VA = "0x185268150")]
	private static void EMIOKNFKLGC(IMJHFECKHBA HJOLDEHKEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public IBFNLOHOCEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class HIGNFPPECLE : KKOBPPBAAKK, GECHFEJJMIP
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private const string OHHDNAJLLNE = "Parented";

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private const string IJJJLHJGFCD = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GameObject NCAOMIEGHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly BPFKJIFDLLM ACKDPDBNMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly BKMBCINBMPC HHCINEKAPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly FBELOBIKDEA[] MGIKBAAHNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly GANLAMOBBBK ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<KPMKOHNCKIH> PCGPHEJNDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private MGLKHALMBDN PAIJMOPLGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private Vector3 GHGPLGJKICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Quaternion JNALDPENEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private bool NIDDECCCKDM;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public KPMKOHNCKIH HAEAHMFNCKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public KPMKOHNCKIH HMHIHGPONEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x684D80", Offset = "0x683D80", VA = "0x180684D80", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x885B50", Offset = "0x884B50", VA = "0x180885B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Vector3 IFKCDBNFANA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x525F6F0", Offset = "0x525E6F0", VA = "0x18525F6F0", Slot = "15")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x10B2AE0", Offset = "0x10B1AE0", VA = "0x1810B2AE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Quaternion INKCJINFIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5260CF0", Offset = "0x525FCF0", VA = "0x185260CF0", Slot = "16")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x17A4550", Offset = "0x17A3550", VA = "0x1817A4550")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool NGNCFEFDCNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xB309E0", Offset = "0xB2F9E0", VA = "0x180B309E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xB30F80", Offset = "0xB2FF80", VA = "0x180B30F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DLEHBLMJBFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5261270", Offset = "0x5260270", VA = "0x185261270", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public KPMKOHNCKIH MNEBHADCJOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6A0", Offset = "0x6B96A0", VA = "0x1806BA6A0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x885170", Offset = "0x884170", VA = "0x180885170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private bool PAFALICHBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5260FE0", Offset = "0x525FFE0", VA = "0x185260FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private RigidbodyEx ACAMBOIMLED
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5261280", Offset = "0x5260280", VA = "0x185261280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<KPMKOHNCKIH> PCLAAEOMOCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x685570", Offset = "0x684570", VA = "0x180685570", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool KAOEENDHPMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5260C20", Offset = "0x525FC20", VA = "0x185260C20", Slot = "18")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5260D60", Offset = "0x525FD60", VA = "0x185260D60", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Transform DNKMJKOCMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5262900", Offset = "0x5261900", VA = "0x185262900", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public GameObject NAAHLJGFEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string ADMEEJPABPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5262670", Offset = "0x5261670", VA = "0x185262670", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Guid PKNIIMKILEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x52627D0", Offset = "0x52617D0", VA = "0x1852627D0", Slot = "37")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int AAGACMAFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x52628B0", Offset = "0x52618B0", VA = "0x1852628B0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public PMFFIMLMCEJ KCKCDBCKCEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x52626C0", Offset = "0x52616C0", VA = "0x1852626C0", Slot = "39")]
		get
		{
			return default(PMFFIMLMCEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool MNAKGMMKOAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event PCNBHGACMBC CAPJNOBCNEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5260EA0", Offset = "0x525FEA0", VA = "0x185260EA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x5260480", Offset = "0x525F480", VA = "0x185260480", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event PCNBHGACMBC KCCBKANODHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x52602B0", Offset = "0x525F2B0", VA = "0x1852602B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x5260B80", Offset = "0x525FB80", VA = "0x185260B80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event PCNBHGACMBC PMLJIKDOLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x52603E0", Offset = "0x525F3E0", VA = "0x1852603E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x5261640", Offset = "0x5260640", VA = "0x185261640", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event ILCFPEBAIBE KKIJPLMBFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x5260F40", Offset = "0x525FF40", VA = "0x185260F40", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x52611D0", Offset = "0x52601D0", VA = "0x1852611D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5260E40", Offset = "0x525FE40", VA = "0x185260E40")]
	private RigidbodyEx JIIKFJBHOBO(KPMKOHNCKIH HHCINEKAPLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5262580", Offset = "0x5261580", VA = "0x185262580")]
	public HIGNFPPECLE(GameObject NCAOMIEGHPA, BKMBCINBMPC HHCINEKAPLC, FBELOBIKDEA[] MGIKBAAHNMC, GANLAMOBBBK ACNDHAIKGGB, BPFKJIFDLLM ACKDPDBNMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x525F330", Offset = "0x525E330", VA = "0x18525F330", Slot = "20")]
	public void BOCFGCJGKDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5260520", Offset = "0x525F520", VA = "0x185260520", Slot = "22")]
	public void EOHGIKEPFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5260C70", Offset = "0x525FC70", VA = "0x185260C70", Slot = "23")]
	public void IJCONFGHCFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5260350", Offset = "0x525F350", VA = "0x185260350", Slot = "21")]
	public void DBEFHDBAOPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x52612E0", Offset = "0x52602E0", VA = "0x1852612E0")]
	private void NFDJMOAIFAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x52616E0", Offset = "0x52606E0", VA = "0x1852616E0")]
	private void PGHAFDFBLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5261930", Offset = "0x5260930", VA = "0x185261930", Slot = "24")]
	public void PKCKPIMLADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5260E20", Offset = "0x525FE20", VA = "0x185260E20", Slot = "25")]
	public void JIFCEJLJNHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x525F480", Offset = "0x525E480", VA = "0x18525F480", Slot = "26")]
	public void BOCPGLLIIGH(int DMNKBPKHFMI, KPMKOHNCKIH MBIJENMAKIB, int NPLLHDENIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x52615A0", Offset = "0x52605A0", VA = "0x1852615A0", Slot = "27")]
	public void OGFDNFLFBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x525EBA0", Offset = "0x525DBA0", VA = "0x18525EBA0", Slot = "28")]
	public void BILIPIJGFAI(int DMNKBPKHFMI, KPMKOHNCKIH IDNMHKLJHMO, int HJKPFEDNMNJ, [Optional] Vector3? NFGBMNLOFOC, [Optional] Quaternion? AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5261890", Offset = "0x5260890", VA = "0x185261890", Slot = "29")]
	public void PIPOKHJMHGL(KPMKOHNCKIH IDNMHKLJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5260580", Offset = "0x525F580", VA = "0x185260580")]
	private void FPJACPAPJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5261030", Offset = "0x5260030", VA = "0x185261030", Slot = "31")]
	public void LNCOKHMFDBD(int NPDGHPHAKDK, Vector3 NJAOOECBFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x525EEF0", Offset = "0x525DEF0", VA = "0x18525EEF0", Slot = "32")]
	public void BIOLLOCKHDL(Vector3 FHGCNDAAIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x525F760", Offset = "0x525E760", VA = "0x18525F760", Slot = "30")]
	public void CCMCDMHLLMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5260AB0", Offset = "0x525FAB0", VA = "0x185260AB0", Slot = "42")]
	public Vector3 GetConnectionSlotPosition(int DMNKBPKHFMI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5260970", Offset = "0x525F970", VA = "0x185260970", Slot = "41")]
	public Vector3 GetConnectionSlotLocalPosition(int DMNKBPKHFMI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x166BBA0", Offset = "0x166ABA0", VA = "0x18166BBA0", Slot = "43")]
	public Color GetConnectionSlotColor(int DMNKBPKHFMI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x525FE40", Offset = "0x525EE40", VA = "0x18525FE40", Slot = "44")]
	public bool CanConnectTo(int DMNKBPKHFMI, KPMKOHNCKIH BOBEAHBBKHP, int FLPEOOIMCIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5261500", Offset = "0x5260500", VA = "0x185261500")]
	public bool NOHLHLNDIHM(KPMKOHNCKIH KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5261950", Offset = "0x5260950", VA = "0x185261950", Slot = "45")]
	public void ParentChanged(int DMNKBPKHFMI, KPMKOHNCKIH ALOKGKABFDN, int DGMDADCGMCM, Vector3 IEPIDBHDIGG, Quaternion BAOCKMCLHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x525FEE0", Offset = "0x525EEE0", VA = "0x18525FEE0", Slot = "46")]
	public void ChildAdded(int DMNKBPKHFMI, KPMKOHNCKIH GHEHIKACJLN, int MELOAOONLFA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5260090", Offset = "0x525F090", VA = "0x185260090", Slot = "47")]
	public void ChildRemoved(int DMNKBPKHFMI, KPMKOHNCKIH AOHMKPFAPPH, int IONEMEOJOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5260150", Offset = "0x525F150", VA = "0x185260150", Slot = "48")]
	public void ConnectionModified(int DMNKBPKHFMI, KPMKOHNCKIH MBIJENMAKIB, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5262520", Offset = "0x5261520", VA = "0x185262520", Slot = "49")]
	public void RootChanged(KPMKOHNCKIH GIPDHGHHJND, KPMKOHNCKIH PIOELDJFACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5261490", Offset = "0x5260490", VA = "0x185261490")]
	private void NIFLCICJAPK(LEBJFIIAEDE KAOMDFGLGCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct ODHNNINODBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public KPMKOHNCKIH ELFIACEEOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public KPMKOHNCKIH ICMEPOIJCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int HJKPFEDNMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public int NPLLHDENIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Vector3 NFGBMNLOFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Quaternion AELLGGHNCPI;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public APANAOMEIDB BPNCNANDOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x52719E0", Offset = "0x52709E0", VA = "0x1852719E0")]
		get
		{
			return default(APANAOMEIDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public APANAOMEIDB HBNGHHMMIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5271970", Offset = "0x5270970", VA = "0x185271970")]
		get
		{
			return default(APANAOMEIDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5271A80", Offset = "0x5270A80", VA = "0x185271A80")]
	public ODHNNINODBN(KPMKOHNCKIH ELFIACEEOOA, KPMKOHNCKIH ICMEPOIJCJO, int HJKPFEDNMNJ, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface DHEBCONPKIF
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	JJAEGKNNBID GHOIKAHCODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NAGCBALDEME(BPFKJIFDLLM CLAEEJIDJEI);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BPHNEIHGOPP(in ODHNNINODBN FILAKGLBGGA, bool IPCMJCEPDKB = true);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PEIGHKJAOGF(KPMKOHNCKIH PCBNGCNCOBE);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EMALIIFENNA(KPMKOHNCKIH AMEGHIFMHKK, int HJKPFEDNMNJ, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HKFOKMGHJCO(KPMKOHNCKIH PDBBNEHABLO, int EJDIPMJMLEK, KPMKOHNCKIH LCCGHHJFGDE, int DGMDADCGMCM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FJKLKALBMMA();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KEHBBPBLJEM(Func<KPMKOHNCKIH, bool> AMFBLPOGNMC);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BHJKBDEJFMM(KPMKOHNCKIH CHCLCLFDGOH, out Vector3 NFGBMNLOFOC, out Quaternion AELLGGHNCPI);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KPMKOHNCKIH DKCDGKDHBGE(KPMKOHNCKIH CHCLCLFDGOH);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FAAOOAHHFAL(KPMKOHNCKIH CHCLCLFDGOH, HashSet<KPMKOHNCKIH> MLIFLOCHADA);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "11")]
	List<KPMKOHNCKIH> GBPDNAJKEBG();

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CDGDNLLMEBP(KPMKOHNCKIH CHCLCLFDGOH, out APANAOMEIDB HBILENHKDCE);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EAMOMPNGLDD(CONAAFDNKIG KDDLOKAHKOL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal delegate bool CONAAFDNKIG(JJAEGKNNBID ABKPGPJAFGM);
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface JJAEGKNNBID
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	KPMKOHNCKIH HAEAHMFNCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int LNLKHDBLIGO
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int HMECMAIOGLE
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Vector3 OCFMLCOCMBG
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Quaternion GFFNIJJHDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	JJAEGKNNBID JAGJOAIDNHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	JJAEGKNNBID GHOIKAHCODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	APANAOMEIDB HIPAGMCBKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool GEDCDHNADFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool MNOMAPIBMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EAMOMPNGLDD(CONAAFDNKIG KDDLOKAHKOL, bool CCDLJLHECME = true);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "16")]
	JJAEGKNNBID PFINJBCMECN(APANAOMEIDB JGMPJKHJEIC);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface LMGGLMPMLOP
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGMOEBJPLEH(KPMKOHNCKIH MBIJENMAKIB, APANAOMEIDB ELFIACEEOOA);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NEMLNLIGFFD(KPMKOHNCKIH MBIJENMAKIB, APANAOMEIDB ELFIACEEOOA);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJELIGAEBJO(KPMKOHNCKIH MBIJENMAKIB, APANAOMEIDB ELFIACEEOOA);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CJMPPHIDJPI(KPMKOHNCKIH MBIJENMAKIB, APANAOMEIDB ELFIACEEOOA);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LMGGLMPMLOP Instantiate(Transform FLCFNMLPAML);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KGNKLNCMPDI();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface NGHELCNOLNH
{
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NAGCBALDEME(Transform FLCFNMLPAML, LMGGLMPMLOP INPOEMAHJFA);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LMGGLMPMLOP COEMJLAHNEM();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HIGGIECAHDI(LMGGLMPMLOP PGBEHMDABBA);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface IOHKJBMAPKK : GGKOKFAIBOJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LNDKJKHNBCN(Guid JAJBGBHJFOB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface KJBEOLLHNJE
{
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNDIECJBMGL(JJAEGKNNBID GHEOIAGEGLO);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NAGCBALDEME(DHEBCONPKIF CCICHMPIDIO, NGHELCNOLNH GPPOJGGBBGP);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HPGNEGEPGHM();

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HMBPHCFMGOD(JJAEGKNNBID GDKCFGKKNDI);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PMKNCDCPIDL(JJAEGKNNBID AMEDDHBPGMM);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DDDINIEIDAN();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal class IMJHFECKHBA : JJAEGKNNBID
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class GDNOKEIALIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public APANAOMEIDB nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public IMJHFECKHBA foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public GDNOKEIALIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x525CB90", Offset = "0x525BB90", VA = "0x18525CB90")]
		internal bool <FindNode>b__0(JJAEGKNNBID x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private APANAOMEIDB HBILENHKDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public LinkedList<IMJHFECKHBA> OAIKOAKHGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IMJHFECKHBA PFCNHINMPHD;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public APANAOMEIDB HIPAGMCBKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2E1B530", Offset = "0x2E1A530", VA = "0x182E1B530", Slot = "16")]
		get
		{
			return default(APANAOMEIDB);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x526CB00", Offset = "0x526BB00", VA = "0x18526CB00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private IMJHFECKHBA ICMEPOIJCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x67E0D0", Offset = "0x67D0D0", VA = "0x18067E0D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x526C9D0", Offset = "0x526B9D0", VA = "0x18526C9D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public JJAEGKNNBID JAGJOAIDNHF
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x67E0D0", Offset = "0x67D0D0", VA = "0x18067E0D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public KPMKOHNCKIH HAEAHMFNCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x69E130", Offset = "0x69D130", VA = "0x18069E130", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int LNLKHDBLIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x67FBD0", Offset = "0x67EBD0", VA = "0x18067FBD0", Slot = "6")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x722410", Offset = "0x721410", VA = "0x180722410", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int HMECMAIOGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x699C90", Offset = "0x698C90", VA = "0x180699C90", Slot = "8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x722320", Offset = "0x721320", VA = "0x180722320", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 OCFMLCOCMBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x14DA420", Offset = "0x14D9420", VA = "0x1814DA420", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x14DA440", Offset = "0x14D9440", VA = "0x1814DA440", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Quaternion GFFNIJJHDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x12A4990", Offset = "0x12A3990", VA = "0x1812A4990", Slot = "12")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x4CD3700", Offset = "0x4CD2700", VA = "0x184CD3700", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool GEDCDHNADFC
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF580", Offset = "0x8DE580", VA = "0x1808DF580", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool MNOMAPIBMML
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x526CAB0", Offset = "0x526BAB0", VA = "0x18526CAB0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	protected IMJHFECKHBA JMLKLPJONJN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x526BDE0", Offset = "0x526ADE0", VA = "0x18526BDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public JJAEGKNNBID GHOIKAHCODP
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x526BDE0", Offset = "0x526ADE0", VA = "0x18526BDE0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x526CC70", Offset = "0x526BC70", VA = "0x18526CC70")]
	public IMJHFECKHBA(APANAOMEIDB OGGGBLFOHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x526C320", Offset = "0x526B320", VA = "0x18526C320")]
	public IMJHFECKHBA HLPNFHFHFFD(APANAOMEIDB IILOJIAGAND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x526C850", Offset = "0x526B850", VA = "0x18526C850")]
	public IMJHFECKHBA LIKLDAPOEHA(APANAOMEIDB NNBIADOMPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x526C150", Offset = "0x526B150", VA = "0x18526C150")]
	public IMJHFECKHBA FAHLDBEBGON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x526C010", Offset = "0x526B010", VA = "0x18526C010")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x526BF60", Offset = "0x526AF60", VA = "0x18526BF60")]
	public IMJHFECKHBA EGDDBOBGBMK(APANAOMEIDB LCCGHHJFGDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x526BE10", Offset = "0x526AE10", VA = "0x18526BE10")]
	private static void EAMOMPNGLDD(IMJHFECKHBA BHMMFKCOJLO, CONAAFDNKIG HMHJFDAOLEM, bool MMMAKHFCPOF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x526BE00", Offset = "0x526AE00", VA = "0x18526BE00", Slot = "19")]
	public void EAMOMPNGLDD(CONAAFDNKIG KDDLOKAHKOL, bool CCDLJLHECME = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x526C460", Offset = "0x526B460", VA = "0x18526C460")]
	public static string KMKNAAEDLGP(IMJHFECKHBA BHMMFKCOJLO, int HFAPDGCFEDI = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x526CC40", Offset = "0x526BC40", VA = "0x18526CC40", Slot = "20")]
	public JJAEGKNNBID PFINJBCMECN(APANAOMEIDB JGMPJKHJEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x526CB30", Offset = "0x526BB30", VA = "0x18526CB30")]
	public static IMJHFECKHBA PFINJBCMECN(IMJHFECKHBA BHMMFKCOJLO, APANAOMEIDB JGMPJKHJEIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface HJEKPMDDOHL
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool OFIGFFFGGDO
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool NFCFBKFCBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event Action<LEBJFIIAEDE> GJDNJJBAAKD;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event Action<LEBJFIIAEDE> GGMHBPKJMJF;

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(MOEOOJDABNB CLAEEJIDJEI);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterConnectNodes(KPMKOHNCKIH IDNMHKLJHMO, int HJKPFEDNMNJ, KPMKOHNCKIH MBIJENMAKIB, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterDisconnectNode(KPMKOHNCKIH PCBNGCNCOBE);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestMasterModifyNode(KPMKOHNCKIH AMEGHIFMHKK, KPMKOHNCKIH FCOKOFOLAAM, int HJKPFEDNMNJ, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void RequestMasterReparentNodes(KPMKOHNCKIH PDBBNEHABLO, int EJDIPMJMLEK, KPMKOHNCKIH LCCGHHJFGDE, int DGMDADCGMCM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void RequestMasterReparentToRoot(KPMKOHNCKIH PDBBNEHABLO);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void RequestDeserializeConnectableGraph(BGCFIBNNBIF HBKDICONLAM, [Optional] LEBJFIIAEDE KGMMBGCDCJF);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, HJEKPMDDOHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private MOEOOJDABNB CLAEEJIDJEI;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool OFIGFFFGGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x526EE80", Offset = "0x526DE80", VA = "0x18526EE80", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool NFCFBKFCBOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x526EEE0", Offset = "0x526DEE0", VA = "0x18526EEE0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<LEBJFIIAEDE> GJDNJJBAAKD
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x526EDE0", Offset = "0x526DDE0", VA = "0x18526EDE0", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x526EFD0", Offset = "0x526DFD0", VA = "0x18526EFD0", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<LEBJFIIAEDE> GGMHBPKJMJF
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x526ED40", Offset = "0x526DD40", VA = "0x18526ED40", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x526EF30", Offset = "0x526DF30", VA = "0x18526EF30", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6855A0", Offset = "0x6845A0", VA = "0x1806855A0", Slot = "22")]
		public void SetManager(MOEOOJDABNB CLAEEJIDJEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x526ED10", Offset = "0x526DD10", VA = "0x18526ED10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x526DA10", Offset = "0x526CA10", VA = "0x18526DA10", Slot = "23")]
		public void RequestMasterConnectNodes(KPMKOHNCKIH IDNMHKLJHMO, int HJKPFEDNMNJ, KPMKOHNCKIH MBIJENMAKIB, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x526DB40", Offset = "0x526CB40", VA = "0x18526DB40", Slot = "24")]
		public void RequestMasterDisconnectNode(KPMKOHNCKIH PCBNGCNCOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x526DC10", Offset = "0x526CC10", VA = "0x18526DC10", Slot = "25")]
		public void RequestMasterModifyNode(KPMKOHNCKIH AMEGHIFMHKK, KPMKOHNCKIH FCOKOFOLAAM, int HJKPFEDNMNJ, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x526DD40", Offset = "0x526CD40", VA = "0x18526DD40", Slot = "26")]
		public void RequestMasterReparentNodes(KPMKOHNCKIH PDBBNEHABLO, int EJDIPMJMLEK, KPMKOHNCKIH LCCGHHJFGDE, int DGMDADCGMCM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x526DE70", Offset = "0x526CE70", VA = "0x18526DE70", Slot = "27")]
		public void RequestMasterReparentToRoot(KPMKOHNCKIH PDBBNEHABLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x526D8E0", Offset = "0x526C8E0", VA = "0x18526D8E0", Slot = "28")]
		public void RequestDeserializeConnectableGraph(BGCFIBNNBIF HBKDICONLAM, [Optional] LEBJFIIAEDE KGMMBGCDCJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x526E260", Offset = "0x526D260", VA = "0x18526E260")]
		[GPJKKJHCAOK]
		private void RpcMasterConnectNodes(KPMKOHNCKIH IDNMHKLJHMO, int HJKPFEDNMNJ, KPMKOHNCKIH MBIJENMAKIB, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x526E530", Offset = "0x526D530", VA = "0x18526E530")]
		[GPJKKJHCAOK]
		private void RpcMasterDisconnectNode(KPMKOHNCKIH PCBNGCNCOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x526E890", Offset = "0x526D890", VA = "0x18526E890")]
		[GPJKKJHCAOK]
		private void RpcMasterReparentNodes(KPMKOHNCKIH PDBBNEHABLO, int EJDIPMJMLEK, KPMKOHNCKIH LCCGHHJFGDE, int DGMDADCGMCM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x526E680", Offset = "0x526D680", VA = "0x18526E680")]
		[GPJKKJHCAOK]
		private void RpcMasterModifyNode(KPMKOHNCKIH AMEGHIFMHKK, KPMKOHNCKIH FCOKOFOLAAM, int HJKPFEDNMNJ, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x526E040", Offset = "0x526D040", VA = "0x18526E040")]
		[GPJKKJHCAOK]
		private void RpcConnectNodes(KPMKOHNCKIH IDNMHKLJHMO, int HJKPFEDNMNJ, KPMKOHNCKIH MBIJENMAKIB, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI, GKNBKDKFKLF ELMIPCPCFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x526E1D0", Offset = "0x526D1D0", VA = "0x18526E1D0")]
		[GPJKKJHCAOK]
		private void RpcDisconnectNode(KPMKOHNCKIH PCBNGCNCOBE, GKNBKDKFKLF ELMIPCPCFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x526EC00", Offset = "0x526DC00", VA = "0x18526EC00")]
		[GPJKKJHCAOK]
		private void RpcReparentNodes(KPMKOHNCKIH PDBBNEHABLO, int EJDIPMJMLEK, KPMKOHNCKIH LCCGHHJFGDE, int DGMDADCGMCM, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI, GKNBKDKFKLF ELMIPCPCFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x526EB30", Offset = "0x526DB30", VA = "0x18526EB30")]
		[GPJKKJHCAOK]
		private void RpcModifyNode(KPMKOHNCKIH AMEGHIFMHKK, int HJKPFEDNMNJ, int NPLLHDENIEA, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI, GKNBKDKFKLF ELMIPCPCFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x526E190", Offset = "0x526D190", VA = "0x18526E190")]
		[GPJKKJHCAOK]
		private void RpcDeserializeConnectableGraph(BGCFIBNNBIF CCICHMPIDIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xE64520", Offset = "0xE63520", VA = "0x180E64520")]
		public LegacyConnectableNetworking()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MAKEJFBMAME
{
	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x257F040", Offset = "0x257E040", VA = "0x18257F040")]
	public static global::LOAPFJAKMPE<T> ADFIBPCCEON<T>(this GBDCKFPNAEP FOIOPKEONKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MGLKHALMBDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CIGAFCHFFML();

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAFPJPFNCCD(bool DFEOJBAFBHE);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class MHHAONNCBBL : MGLKHALMBDN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly global::LBAMDKILHNJ<bool> HFNDODGNHIE;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x526FA00", Offset = "0x526EA00", VA = "0x18526FA00")]
	public MHHAONNCBBL(CONIMBOKOMD KPJEGNGKPOH, string PIIJMEAKDGO, bool PGBDPKDFJME, GCOJLBAOHJF FJHNCLPDOME, [Optional] Action KDDLOKAHKOL, [Optional] HMHJFMOJOEJ INBACINDEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x526F930", Offset = "0x526E930", VA = "0x18526F930", Slot = "4")]
	public bool CIGAFCHFFML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x526F9A0", Offset = "0x526E9A0", VA = "0x18526F9A0", Slot = "5")]
	public void FAFPJPFNCCD(bool DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x526F980", Offset = "0x526E980", VA = "0x18526F980", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class GEKIFEJDBEN
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public const string OFKILKDLOHO = "The connectable subgraph being deserialized is corrupt.";

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public const string OPHPFEPIMGM = "The connectable subgraph failed to deserialize, even though it passed the corruption check.";
}
namespace RRAssemblyIndex.RecRoom.Connectables.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Preserve]
	internal class _RRAssemblyIndex : GDNMPNNPIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x5277FB0", Offset = "0x5276FB0", VA = "0x185277FB0", Slot = "6")]
		public sealed override void EFMBJNCKONM(GEJJOANAKLE KDDLOKAHKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x5278130", Offset = "0x5277130", VA = "0x185278130", Slot = "4")]
		public sealed override void JJOFCNGHIKE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x526D380", Offset = "0x526C380", VA = "0x18526D380")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x526D030", Offset = "0x526C030", VA = "0x18526D030")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
