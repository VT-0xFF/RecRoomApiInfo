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
public class PHFDPBLAOLK : LBOODBLHBKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Transform CLHKPCIOCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private OILFFIBNFMI MNKKADGAMIE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2E62B60", Offset = "0x2E61560", VA = "0x182E62B60", Slot = "4")]
	public void JGKFDHOAMGH(Transform CLHKPCIOCGF, OILFFIBNFMI MNKKADGAMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x552D6D0", Offset = "0x552C0D0", VA = "0x18552D6D0", Slot = "5")]
	public OILFFIBNFMI DFNFJBENIEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public PHFDPBLAOLK()
	{
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Connectables)]
	public sealed class OMConnectableManager : LFLOFKNKOHK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class OGADPPDNEDL : IEnumerable<LHEHFGFGCOA>, IEnumerable, IEnumerator<LHEHFGFGCOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private LHEHFGFGCOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private DFKOJFHJBPL localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public DFKOJFHJBPL <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public OMConnectableManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private HGFGJIKNIPL <objects>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private EIIMNNHCANF.OAONHDOPCPC <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private LHEHFGFGCOA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
			[DebuggerHidden]
			public OGADPPDNEDL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x5527980", Offset = "0x5526380", VA = "0x185527980", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5527560", Offset = "0x5525F60", VA = "0x185527560", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x55279E0", Offset = "0x55263E0", VA = "0x1855279E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5527940", Offset = "0x5526340", VA = "0x185527940", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5527890", Offset = "0x5526290", VA = "0x185527890", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<LHEHFGFGCOA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5527890", Offset = "0x5526290", VA = "0x185527890", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly KGOHPJFJCLE IIIMMAMPAPG;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly KGOHPJFJCLE PMEKBLPMDFH;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly KGOHPJFJCLE DJHCIKBPMMH;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly KGOHPJFJCLE LCJNJEPLFPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private CPMCACBEBDN GMKCGHFBHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private LAIKDFLJMKI HKHMGAMGNMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DFGMEPIHEII EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private OFJGIHJMMMN PFMNHKDJLCE;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const int DNEINOLCCPI = 0;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const int IHAEEDAICFB = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IGIBMKFLGBD BKJAOJMOJPF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool JDCINNHHEGM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1068E10", Offset = "0x1067810", VA = "0x181068E10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x12E7210", Offset = "0x12E5C10", VA = "0x1812E7210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<LHEHFGFGCOA, LHEHFGFGCOA> LAFCHHLEOGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x552B040", Offset = "0x5529A40", VA = "0x18552B040", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5528510", Offset = "0x5526F10", VA = "0x185528510", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<LHEHFGFGCOA, LHEHFGFGCOA> AEIKDLAFHHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x552CAF0", Offset = "0x552B4F0", VA = "0x18552CAF0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5529E30", Offset = "0x5528830", VA = "0x185529E30", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<LHEHFGFGCOA, LHEHFGFGCOA, LHEHFGFGCOA> AHJMBPHDLGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x552CB90", Offset = "0x552B590", VA = "0x18552CB90", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5528470", Offset = "0x5526E70", VA = "0x185528470", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x552CD70", Offset = "0x552B770", VA = "0x18552CD70")]
		public OMConnectableManager(PLIBOCMCGIC KCKJCMPILDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x552AA00", Offset = "0x5529400", VA = "0x18552AA00", Slot = "11")]
		public void JGKFDHOAMGH(GameObject KEHOIMKGHCH, GADEDDGDLFN EOAAKGAPBDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5528F60", Offset = "0x5527960", VA = "0x185528F60", Slot = "26")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x55249C0", Offset = "0x55233C0", VA = "0x1855249C0", Slot = "22")]
		public bool CEDJCCGBKED(ECFNNHBBONE GOADIACIEED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x552A230", Offset = "0x5528C30", VA = "0x18552A230")]
		private void HICPNJHKLFM(DFKOJFHJBPL PBKKDGBGABP, DFKOJFHJBPL NLCBBNKAPNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5527B70", Offset = "0x5526570", VA = "0x185527B70")]
		private void APEGHPBJNPO(DFKOJFHJBPL PBKKDGBGABP, DFKOJFHJBPL PJBEPGAMKGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5529A70", Offset = "0x5528470", VA = "0x185529A70")]
		private void FDBPPIFNEDJ(DFKOJFHJBPL PBKKDGBGABP, DFKOJFHJBPL PJBEPGAMKGP, DFKOJFHJBPL NLCBBNKAPNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x552BE70", Offset = "0x552A870", VA = "0x18552BE70")]
		private void NOLIODPDGIG(DFKOJFHJBPL PBKKDGBGABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "12")]
		public void BBFMMOJDOFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x552C420", Offset = "0x552AE20", VA = "0x18552C420", Slot = "13")]
		public void OGMDKKEHOIN(LHEHFGFGCOA MMKMHECDHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5528AE0", Offset = "0x55274E0", VA = "0x185528AE0", Slot = "14")]
		public void DDIDMMIANOF(LHEHFGFGCOA MMKMHECDHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5529680", Offset = "0x5528080", VA = "0x185529680", Slot = "16")]
		public void EKDAKCONHHM(LHEHFGFGCOA MMKMHECDHFO, LHEHFGFGCOA IKDGDLOPOKG, Vector3 GBGEGEKJOFF, Quaternion HLMPNEAIKDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x55294A0", Offset = "0x5527EA0", VA = "0x1855294A0")]
		public void EKDAKCONHHM(DFKOJFHJBPL DDLMBHAEKGH, DFKOJFHJBPL IKDGDLOPOKG, Vector3 GBGEGEKJOFF, Quaternion HLMPNEAIKDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5528D20", Offset = "0x5527720", VA = "0x185528D20", Slot = "17")]
		public void DIGADINJLAG(LHEHFGFGCOA ANABKFNBCHO, int DPDLCAFMJGE, LHEHFGFGCOA FILEOABIGBM, int CGCAIINBAAH, Vector3 GBGEGEKJOFF, Quaternion HLMPNEAIKDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5528CB0", Offset = "0x55276B0", VA = "0x185528CB0")]
		public void DIGADINJLAG(DFKOJFHJBPL DDLMBHAEKGH, DFKOJFHJBPL ELGBIOMPEHN, Vector3 GBGEGEKJOFF, Quaternion HLMPNEAIKDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x552BC80", Offset = "0x552A680", VA = "0x18552BC80", Slot = "18")]
		public void NMGLOPAPJNN(LHEHFGFGCOA MMKMHECDHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x552A530", Offset = "0x5528F30", VA = "0x18552A530", Slot = "19")]
		public bool HIOMLOPFMMF(LHEHFGFGCOA MMKMHECDHFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x552A620", Offset = "0x5529020", VA = "0x18552A620")]
		public bool HIOMLOPFMMF(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5527E80", Offset = "0x5526880", VA = "0x185527E80", Slot = "15")]
		public void BFPBHCLHJMC(LHEHFGFGCOA MMKMHECDHFO, HashSet<LHEHFGFGCOA> EDMNKADLJFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "20")]
		public GJKMJOMCFOL BENJAEINCCI(bool MLIFFPFMKCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "21")]
		public GJKMJOMCFOL PAABNOFEHCA(HashSet<Guid> PKPLNKLEMOL, bool MLIFFPFMKCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5527B00", Offset = "0x5526500", VA = "0x185527B00", Slot = "23")]
		public void AOKDLCEEPCA(GJKMJOMCFOL NFPBNLAEKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5527A00", Offset = "0x5526400", VA = "0x185527A00", Slot = "24")]
		public void ABAHCOGPMLF(GJKMJOMCFOL NFPBNLAEKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5529ED0", Offset = "0x55288D0", VA = "0x185529ED0", Slot = "25")]
		public void GOOCFDMDCLH(GJKMJOMCFOL NFPBNLAEKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x552C760", Offset = "0x552B160", VA = "0x18552C760")]
		private void OKFBFIDBCNB(DFKOJFHJBPL DDLMBHAEKGH, DFKOJFHJBPL ELGBIOMPEHN, Vector3 GBGEGEKJOFF, Quaternion HLMPNEAIKDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x55285B0", Offset = "0x5526FB0", VA = "0x1855285B0")]
		private void CLLICEEOJAN(DFKOJFHJBPL DDLMBHAEKGH, DFKOJFHJBPL DILGNCFGGHK, Vector3 GBGEGEKJOFF, Quaternion HLMPNEAIKDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x552A160", Offset = "0x5528B60", VA = "0x18552A160")]
		private void HENHLIMNBEG(DFKOJFHJBPL DDLMBHAEKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5527A70", Offset = "0x5526470", VA = "0x185527A70")]
		[IteratorStateMachine(typeof(OGADPPDNEDL))]
		public IEnumerable<LHEHFGFGCOA> AEFLJKDHMFL(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x552B440", Offset = "0x5529E40", VA = "0x18552B440")]
		internal LHEHFGFGCOA LODALHBBFND(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5528BC0", Offset = "0x55275C0", VA = "0x185528BC0")]
		internal DFKOJFHJBPL DHDNGOHCFIF(LHEHFGFGCOA MMKMHECDHFO)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x552B650", Offset = "0x552A050", VA = "0x18552B650")]
		private bool NEOHGPHJAKD(ECFNNHBBONE GOADIACIEED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x552AE50", Offset = "0x5529850", VA = "0x18552AE50")]
		private bool JLNKHPBEBDF(ECFNNHBBONE GOADIACIEED, out LHEHFGFGCOA ELGBIOMPEHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x552B0E0", Offset = "0x5529AE0", VA = "0x18552B0E0")]
		private LHEHFGFGCOA LODALHBBFND(ECFNNHBBONE GOADIACIEED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x55298D0", Offset = "0x55282D0", VA = "0x1855298D0")]
		private LHEHFGFGCOA EOBINPJMJAL(ECFNNHBBONE GOADIACIEED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5529FD0", Offset = "0x55289D0", VA = "0x185529FD0")]
		private LHEHFGFGCOA HEEPIBKEHPK(ECFNNHBBONE GOADIACIEED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x55142C0", Offset = "0x5512CC0", VA = "0x1855142C0")]
		private static Guid ILOOEEBOMPA(ECFNNHBBONE GOADIACIEED)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5529EF0", Offset = "0x55288F0", VA = "0x185529EF0")]
		private string HDJJPCBMBEG(ECFNNHBBONE GOADIACIEED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x552B4C0", Offset = "0x5529EC0", VA = "0x18552B4C0")]
		private void LONPGCCJBOI(LHEHFGFGCOA DDLMBHAEKGH, LHEHFGFGCOA DILGNCFGGHK, RigidTransform BLCFJOFFEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x552A870", Offset = "0x5529270", VA = "0x18552A870")]
		private void JBFAHEFCONI(LHEHFGFGCOA DILGNCFGGHK, LHEHFGFGCOA DDLMBHAEKGH, RigidTransform BLCFJOFFEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5529440", Offset = "0x5527E40", VA = "0x185529440")]
		private void EELKEBPLNDH(LHEHFGFGCOA PMJEABCAKDM, LHEHFGFGCOA DDLMBHAEKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x552AEB0", Offset = "0x55298B0", VA = "0x18552AEB0")]
		private void JMDBAONFMBC(LHEHFGFGCOA DDLMBHAEKGH, LHEHFGFGCOA ELGBIOMPEHN, RigidTransform BLCFJOFFEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5529160", Offset = "0x5527B60", VA = "0x185529160")]
		private void EANCNOCNJIJ(DFKOJFHJBPL PMMCMCPNCLD, LHEHFGFGCOA MMKMHECDHFO, DFKOJFHJBPL PJBEPGAMKGP, DFKOJFHJBPL NLCBBNKAPNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5528150", Offset = "0x5526B50", VA = "0x185528150")]
		private void BLBKGAFFCCB(DFKOJFHJBPL PMMCMCPNCLD, LHEHFGFGCOA MMKMHECDHFO, LHEHFGFGCOA NJBJKLIJDDA, LHEHFGFGCOA MCCGBMECIAB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EMHKGBPKGBG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class OEEEMOFBCFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public PLIBOCMCGIC container;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public OEEEMOFBCFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x55274C0", Offset = "0x5525EC0", VA = "0x1855274C0")]
		internal OMConnectableManager <BindServices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5516F60", Offset = "0x5515960", VA = "0x185516F60")]
	public static void BDMDPGPGNDK(PLIBOCMCGIC KCKJCMPILDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5517130", Offset = "0x5515B30", VA = "0x185517130")]
	public static void OFEIBCGGBKG(PLIBOCMCGIC KCKJCMPILDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class POEOLOGBJHN : GJCADCMMOKB, KPDKADGFAPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly RigidbodyEx MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly OMConnectableManager OHIIILCCCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly JEMIICPINJD JDBCCMFOKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly INNEIOIKCEH EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly IBCGGLCHCHC[] MPCFBFOGFDO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x124B0E0", Offset = "0x1249AE0", VA = "0x18124B0E0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LHEHFGFGCOA PGLJHEOHBKC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LHEHFGFGCOA CEICFCIOKED
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x552F3C0", Offset = "0x552DDC0", VA = "0x18552F3C0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LHEHFGFGCOA PHLNNFFEGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x552DE80", Offset = "0x552C880", VA = "0x18552DE80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 NGGFMHOLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x552E560", Offset = "0x552CF60", VA = "0x18552E560", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Quaternion DHGEFGCKOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x552F1E0", Offset = "0x552DBE0", VA = "0x18552F1E0", Slot = "16")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool PLLPIOAEHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x552D9B0", Offset = "0x552C3B0", VA = "0x18552D9B0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IEnumerable<LHEHFGFGCOA> NNKNBBHLJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x552E5D0", Offset = "0x552CFD0", VA = "0x18552E5D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Obsolete]
	public bool KCPGHEBLKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1068E10", Offset = "0x1067810", VA = "0x181068E10", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x12E7210", Offset = "0x12E5C10", VA = "0x1812E7210", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Transform ONMPEEDNICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x552F5E0", Offset = "0x552DFE0", VA = "0x18552F5E0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GameObject AKKLNJDLHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x552F350", Offset = "0x552DD50", VA = "0x18552F350", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string AECGGMKOOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x552F370", Offset = "0x552DD70", VA = "0x18552F370", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid HNBBGALPNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x552F4B0", Offset = "0x552DEB0", VA = "0x18552F4B0", Slot = "37")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int MHIBCCOLPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x552F590", Offset = "0x552DF90", VA = "0x18552F590", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BJCFBLIPPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private bool OKOCBEFJACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x552D720", Offset = "0x552C120", VA = "0x18552D720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event IHMADODKHKN GKCGBFIOLBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x552DDD0", Offset = "0x552C7D0", VA = "0x18552DDD0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x552E260", Offset = "0x552CC60", VA = "0x18552E260", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event IHMADODKHKN FGMJLHPOOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x552D7F0", Offset = "0x552C1F0", VA = "0x18552D7F0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x552E670", Offset = "0x552D070", VA = "0x18552E670", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event IHMADODKHKN CLEOCKLJJCB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x552EA80", Offset = "0x552D480", VA = "0x18552EA80", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x552D770", Offset = "0x552C170", VA = "0x18552D770", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event IPFEJGABLKG MECPNCMNGMG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x552EDF0", Offset = "0x552D7F0", VA = "0x18552EDF0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x552E6C0", Offset = "0x552D0C0", VA = "0x18552E6C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x552F270", Offset = "0x552DC70", VA = "0x18552F270")]
	public POEOLOGBJHN(DFKOJFHJBPL EFHLICFAAGO, RigidbodyEx MPLGHJJKMAH, JEMIICPINJD JDBCCMFOKKJ, IBCGGLCHCHC[] MPCFBFOGFDO, INNEIOIKCEH EDFOBNPNANH, LFLOFKNKOHK OHIIILCCCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x552D7C0", Offset = "0x552C1C0", VA = "0x18552D7C0", Slot = "20")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "22")]
	public void KHHMCGIJFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x552EE90", Offset = "0x552D890", VA = "0x18552EE90", Slot = "23")]
	public void PLHKJHNPHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x552D960", Offset = "0x552C360", VA = "0x18552D960", Slot = "21")]
	public void DAFLDHNIGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x552EF90", Offset = "0x552D990", VA = "0x18552EF90", Slot = "26")]
	public void PLJLJIMAFMA(int PACLGCIADGA, LHEHFGFGCOA FILEOABIGBM, int MJGOGEOBFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x552E1E0", Offset = "0x552CBE0", VA = "0x18552E1E0", Slot = "27")]
	public void HOOPOBIFLBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x552EAD0", Offset = "0x552D4D0", VA = "0x18552EAD0", Slot = "28")]
	public void MMALMFEHHKH(int PACLGCIADGA, LHEHFGFGCOA ANABKFNBCHO, int NIAFHAFBKPN, [Optional] Vector3? LNCOLOGFNJN, [Optional] Quaternion? DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x552D840", Offset = "0x552C240", VA = "0x18552D840", Slot = "29")]
	public void CNLCACPJOGN(LHEHFGFGCOA ANABKFNBCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x552D9D0", Offset = "0x552C3D0", VA = "0x18552D9D0", Slot = "32")]
	public void FCEGKHCIOMA(Vector3 PDKMIJPIGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x552E760", Offset = "0x552D160", VA = "0x18552E760", Slot = "30")]
	public void KMDPAECIDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x552E3C0", Offset = "0x552CDC0", VA = "0x18552E3C0", Slot = "31")]
	public void IHMFDCBGKPH(int GFDMFLGCBKB, Vector3 LGGBCCHKBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x552E0B0", Offset = "0x552CAB0", VA = "0x18552E0B0", Slot = "42")]
	public Vector3 GetConnectionSlotPosition(int PACLGCIADGA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x552DF70", Offset = "0x552C970", VA = "0x18552DF70", Slot = "41")]
	public Vector3 GetConnectionSlotLocalPosition(int PACLGCIADGA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x17FA510", Offset = "0x17F8F10", VA = "0x1817FA510", Slot = "43")]
	public Color GetConnectionSlotColor(int PACLGCIADGA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x552D8C0", Offset = "0x552C2C0", VA = "0x18552D8C0", Slot = "44")]
	public bool CanConnectTo(int PACLGCIADGA, LHEHFGFGCOA OOLAJGAJNNN, int OJPFPAKOICG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "45")]
	public void ParentChanged(int PACLGCIADGA, LHEHFGFGCOA LOJDAINCFHP, int KLOPGBAGEFI, Vector3 MEBKAIMJEKP, Quaternion IFFDCCIBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "46")]
	public void ChildAdded(int PACLGCIADGA, LHEHFGFGCOA ABEBIPPGHNO, int BPADFAIHIIG, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "47")]
	public void ChildRemoved(int PACLGCIADGA, LHEHFGFGCOA KBCFMLNEFMC, int PNOFEIBPCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "48")]
	public void ConnectionModified(int PACLGCIADGA, LHEHFGFGCOA FILEOABIGBM, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x552F250", Offset = "0x552DC50", VA = "0x18552F250", Slot = "49")]
	public void RootChanged(LHEHFGFGCOA GOECFNEKPNN, LHEHFGFGCOA DHALEBLPIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x552E310", Offset = "0x552CD10", VA = "0x18552E310")]
	public bool IHGPCKFDMJE(LHEHFGFGCOA DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x552DE20", Offset = "0x552C820", VA = "0x18552DE20", Slot = "24")]
	public void FLBBJOCKOHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x552E180", Offset = "0x552CB80", VA = "0x18552E180", Slot = "25")]
	public void HLMJMKDGAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x552EA20", Offset = "0x552D420", VA = "0x18552EA20")]
	private void KOGFLHNCOKL(bool CKHAAEIBMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x552E2B0", Offset = "0x552CCB0", VA = "0x18552E2B0")]
	private RigidbodyEx IEMJOENIJEM(LHEHFGFGCOA JDBCCMFOKKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DNOPHNKOHLA(typeof(EMFKELAKBNJ), new string[] { })]
public class HLOKBOBGFKA : EMFKELAKBNJ, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[JIFPDEDMPGC]
	private LFIFNADKAEF EDFOBNPNANH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public object FICMOFNJKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x551C3A0", Offset = "0x551ADA0", VA = "0x18551C3A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x551C350", Offset = "0x551AD50", VA = "0x18551C350", Slot = "6")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x551C440", Offset = "0x551AE40", VA = "0x18551C440", Slot = "5")]
	public void ODNLJFIDJAE(EIIMNNHCANF BPPOAHFNBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public HLOKBOBGFKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DNOPHNKOHLA(typeof(LFLOFKNKOHK), new string[] { "Ignore", "Mock" })]
public class FOECAKOJCAO : LFLOFKNKOHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool JDCINNHHEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<LHEHFGFGCOA, LHEHFGFGCOA> LAFCHHLEOGK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x551C170", Offset = "0x551AB70", VA = "0x18551C170", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x551C030", Offset = "0x551AA30", VA = "0x18551C030", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<LHEHFGFGCOA, LHEHFGFGCOA> AEIKDLAFHHM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x551C210", Offset = "0x551AC10", VA = "0x18551C210", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x551C0D0", Offset = "0x551AAD0", VA = "0x18551C0D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<LHEHFGFGCOA, LHEHFGFGCOA, LHEHFGFGCOA> AHJMBPHDLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x551C2B0", Offset = "0x551ACB0", VA = "0x18551C2B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x551BF90", Offset = "0x551A990", VA = "0x18551BF90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "11")]
	public void JGKFDHOAMGH(GameObject KEHOIMKGHCH, GADEDDGDLFN EOAAKGAPBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "12")]
	public void BBFMMOJDOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "13")]
	public void OGMDKKEHOIN(LHEHFGFGCOA MMKMHECDHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "14")]
	public void DDIDMMIANOF(LHEHFGFGCOA MMKMHECDHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "15")]
	public void BFPBHCLHJMC(LHEHFGFGCOA MMKMHECDHFO, HashSet<LHEHFGFGCOA> EDMNKADLJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "16")]
	public void EKDAKCONHHM(LHEHFGFGCOA MMKMHECDHFO, LHEHFGFGCOA IKDGDLOPOKG, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "17")]
	public void DIGADINJLAG(LHEHFGFGCOA MMKMHECDHFO, int CHLFBCEPEAJ, LHEHFGFGCOA DILGNCFGGHK, int KLOPGBAGEFI, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "18")]
	public void NMGLOPAPJNN(LHEHFGFGCOA MMKMHECDHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "19")]
	public bool HIOMLOPFMMF(LHEHFGFGCOA MMKMHECDHFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "20")]
	public GJKMJOMCFOL BENJAEINCCI(bool MLIFFPFMKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "21")]
	public GJKMJOMCFOL PAABNOFEHCA(HashSet<Guid> PKPLNKLEMOL, bool MLIFFPFMKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "22")]
	public bool CEDJCCGBKED(ECFNNHBBONE GOADIACIEED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "23")]
	public void AOKDLCEEPCA(GJKMJOMCFOL NFPBNLAEKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "24")]
	public void ABAHCOGPMLF(GJKMJOMCFOL NFPBNLAEKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "25")]
	public void GOOCFDMDCLH(GJKMJOMCFOL NFPBNLAEKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public FOECAKOJCAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DEBDFGMFDBB : PNOGGKDMNGE, OILFFIBNFMI, IDisposable
{
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ConnectableLinkVisual : MonoBehaviour, DEBDFGMFDBB, PNOGGKDMNGE, OILFFIBNFMI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Entity EPPABMKEFFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Entity KCHEMIKFJPH;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Entity OKIJCMMIHGK
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "20")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x9ECFA0", Offset = "0x9EB9A0", VA = "0x1809ECFA0", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Entity ABNHJDJIAMD
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0", Slot = "11")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xEA7040", Offset = "0xEA5A40", VA = "0x180EA7040", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5515A80", Offset = "0x5514480", VA = "0x185515A80", Slot = "4")]
		private void ELJHOMIDFFP(LHEHFGFGCOA FILEOABIGBM, PCNHCFNNABC DDLMBHAEKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5515E00", Offset = "0x5514800", VA = "0x185515E00", Slot = "5")]
		private void FNECFCEAENB(LHEHFGFGCOA FILEOABIGBM, PCNHCFNNABC DDLMBHAEKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5515B40", Offset = "0x5514540", VA = "0x185515B40", Slot = "6")]
		private void ENLNKKEANNB(LHEHFGFGCOA FILEOABIGBM, PCNHCFNNABC DDLMBHAEKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5516260", Offset = "0x5514C60", VA = "0x185516260", Slot = "7")]
		private void MMLCFHJJNCD(LHEHFGFGCOA FILEOABIGBM, PCNHCFNNABC DDLMBHAEKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5515930", Offset = "0x5514330", VA = "0x185515930", Slot = "8")]
		private PNOGGKDMNGE BBGIFKHMEOI(Transform CLHKPCIOCGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5516190", Offset = "0x5514B90", VA = "0x185516190", Slot = "9")]
		private void KPAEKKKLFDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5516430", Offset = "0x5514E30", VA = "0x185516430")]
		private void NLANNFAIKGA(ref Entity GOANOLJBHPF, Entity MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x55161F0", Offset = "0x5514BF0", VA = "0x1855161F0", Slot = "14")]
		private void LJLNCAKPAEI(float3 LGGBCCHKBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5516440", Offset = "0x5514E40", VA = "0x185516440", Slot = "13")]
		private void PLNFBOHCEDC(float3 LGGBCCHKBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5515D30", Offset = "0x5514730", VA = "0x185515D30", Slot = "15")]
		private void FJEDALLDIJP(out float3 AGNHLFMCFOJ, out float3 PGDLDMBJJEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x55159B0", Offset = "0x55143B0", VA = "0x1855159B0", Slot = "16")]
		private void EGBNMNFKJCI(float3 AGNHLFMCFOJ, float3 PGDLDMBJJEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x55160B0", Offset = "0x5514AB0", VA = "0x1855160B0", Slot = "17")]
		private void HEEBECNNPLN(Color AGNHLFMCFOJ, Color PGDLDMBJJEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5516110", Offset = "0x5514B10", VA = "0x185516110", Slot = "18")]
		private OILFFIBNFMI HJMBJKOBKGO(Transform CLHKPCIOCGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x55164B0", Offset = "0x5514EB0", VA = "0x1855164B0", Slot = "19")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public ConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LHEHFGFGCOA : KPDKADGFAPJ, IEquatable<LHEHFGFGCOA>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KPDKADGFAPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	LHEHFGFGCOA CEICFCIOKED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform ONMPEEDNICF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject AKKLNJDLHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string AECGGMKOOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid HNBBGALPNMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int MHIBCCOLPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BJCFBLIPPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int PACLGCIADGA);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int PACLGCIADGA);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int PACLGCIADGA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int PACLGCIADGA, LHEHFGFGCOA OOLAJGAJNNN, int KLPCJJHBCEJ);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int PACLGCIADGA, LHEHFGFGCOA LOJDAINCFHP, int KLOPGBAGEFI, Vector3 MEBKAIMJEKP, Quaternion IFFDCCIBJJJ);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int PACLGCIADGA, LHEHFGFGCOA ABEBIPPGHNO, int BPADFAIHIIG, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int PACLGCIADGA, LHEHFGFGCOA KBCFMLNEFMC, int PNOFEIBPCLE);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int PACLGCIADGA, LHEHFGFGCOA FILEOABIGBM, int PBAAPGEJPIM, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(LHEHFGFGCOA GOECFNEKPNN, LHEHFGFGCOA DHALEBLPIMI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface LFLOFKNKOHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool JDCINNHHEGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<LHEHFGFGCOA, LHEHFGFGCOA> LAFCHHLEOGK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<LHEHFGFGCOA, LHEHFGFGCOA> AEIKDLAFHHM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<LHEHFGFGCOA, LHEHFGFGCOA, LHEHFGFGCOA> AHJMBPHDLGG;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JGKFDHOAMGH(GameObject KEHOIMKGHCH, GADEDDGDLFN EOAAKGAPBDB);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BBFMMOJDOFP();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OGMDKKEHOIN(LHEHFGFGCOA MMKMHECDHFO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DDIDMMIANOF(LHEHFGFGCOA MMKMHECDHFO);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BFPBHCLHJMC(LHEHFGFGCOA MMKMHECDHFO, HashSet<LHEHFGFGCOA> EDMNKADLJFI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EKDAKCONHHM(LHEHFGFGCOA MMKMHECDHFO, LHEHFGFGCOA IKDGDLOPOKG, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DIGADINJLAG(LHEHFGFGCOA MMKMHECDHFO, int CHLFBCEPEAJ, LHEHFGFGCOA DILGNCFGGHK, int KLOPGBAGEFI, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NMGLOPAPJNN(LHEHFGFGCOA MMKMHECDHFO);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool HIOMLOPFMMF(LHEHFGFGCOA MMKMHECDHFO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	GJKMJOMCFOL BENJAEINCCI(bool MLIFFPFMKCE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	GJKMJOMCFOL PAABNOFEHCA(HashSet<Guid> PKPLNKLEMOL, bool MLIFFPFMKCE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool CEDJCCGBKED(ECFNNHBBONE GOADIACIEED);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void AOKDLCEEPCA(GJKMJOMCFOL NFPBNLAEKIF);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ABAHCOGPMLF(GJKMJOMCFOL NFPBNLAEKIF);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GOOCFDMDCLH(GJKMJOMCFOL NFPBNLAEKIF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DFGMEPIHEII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool LLHDPIAHEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LHEHFGFGCOA HEEPIBKEHPK(int FBLKIJLAAFL);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LHEHFGFGCOA EOBINPJMJAL(Guid IJFINNBBKNM);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JODDMKPLIBG(LHEHFGFGCOA MMKMHECDHFO, out Guid CKAFGMOJCKA);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DFPOLOHHFOH(LHEHFGFGCOA MMKMHECDHFO);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ENLKFHEJMOM();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KPLHOAGOFLA(LHEHFGFGCOA JDBCCMFOKKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public interface INNEIOIKCEH
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OKOCBEFJACG(JEMIICPINJD JDBCCMFOKKJ);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHJLPDIEKME(JEMIICPINJD JDBCCMFOKKJ);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string FPDPEEPJPKJ(JEMIICPINJD JDBCCMFOKKJ);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PFBPJDFBAHF(JEMIICPINJD JDBCCMFOKKJ);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int HFFFDBBFEIL(JEMIICPINJD JDBCCMFOKKJ);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DGHKAIGOKDM(LHEHFGFGCOA JDBCCMFOKKJ, Action<LLFLMPPMGID> HEBGAFADEPB);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EOAPAPDLHOG(LHEHFGFGCOA JDBCCMFOKKJ, Action<LLFLMPPMGID> HEBGAFADEPB);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BOPIKDDNPDP(JEMIICPINJD JDBCCMFOKKJ);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CNDHHLBPFIJ(JEMIICPINJD JDBCCMFOKKJ);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KPLHOAGOFLA(JEMIICPINJD JDBCCMFOKKJ);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CKHNMOAIKKF(JEMIICPINJD JDBCCMFOKKJ, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AFOJJCPKDKC(JEMIICPINJD JDBCCMFOKKJ, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	RigidbodyEx IEMJOENIJEM(LHEHFGFGCOA JDBCCMFOKKJ);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MLAIABPOALE KILCCHNNNKO(JEMIICPINJD CGFEOLDGFLJ, string AJPNMLHDHNM, bool OGDNNKNPNAO, LFKEJHLOGBH ANPGHBCNJID, Action JOIALDGLEAK);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JOGKOKLNKEK(GJCADCMMOKB EAABOIEABMA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void IHMADODKHKN(LHEHFGFGCOA ANABKFNBCHO, int PNOGILKKOKN, LHEHFGFGCOA FILEOABIGBM, int LOANAFJJHNI, [Optional] Vector3? LNCOLOGFNJN, [Optional] Quaternion? DBMPKDBKHPD);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void IPFEJGABLKG(LHEHFGFGCOA GOECFNEKPNN, LHEHFGFGCOA DHALEBLPIMI);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool PAKGBEKINFC(int PACLGCIADGA, LHEHFGFGCOA OOLAJGAJNNN, int OJPFPAKOICG);
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JEMIICPINJD : LHEHFGFGCOA, KPDKADGFAPJ, IEquatable<LHEHFGFGCOA>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	GJCADCMMOKB GCDBCKCLBIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GJCADCMMOKB : KPDKADGFAPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LHEHFGFGCOA PGLJHEOHBKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	LHEHFGFGCOA PHLNNFFEGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	IEnumerable<LHEHFGFGCOA> NNKNBBHLJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Vector3 NGGFMHOLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	Quaternion DHGEFGCKOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool PLLPIOAEHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool KCPGHEBLKNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event IHMADODKHKN GKCGBFIOLBK;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event IHMADODKHKN FGMJLHPOOMF;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event IHMADODKHKN CLEOCKLJJCB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event IPFEJGABLKG MECPNCMNGMG;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AKHIMNHIOOI();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DAFLDHNIGKO();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KHHMCGIJFAP();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PLHKJHNPHBM();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FLBBJOCKOHB();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HLMJMKDGAJM();

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PLJLJIMAFMA(int PACLGCIADGA, LHEHFGFGCOA FILEOABIGBM, int MJGOGEOBFGF);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void HOOPOBIFLBA();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MMALMFEHHKH(int PACLGCIADGA, LHEHFGFGCOA ANABKFNBCHO, int NIAFHAFBKPN, [Optional] Vector3? LNCOLOGFNJN, [Optional] Quaternion? DBMPKDBKHPD);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CNLCACPJOGN(LHEHFGFGCOA ANABKFNBCHO);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KMDPAECIDMC();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IHMFDCBGKPH(int GFDMFLGCBKB, Vector3 LGGBCCHKBJD);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FCEGKHCIOMA(Vector3 PDKMIJPIGDP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IBCGGLCHCHC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Vector3 MIOLGAKDCNI
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
public interface GADEDDGDLFN
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool IKEBHLFBPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	DEBDFGMFDBB MOKKEFHGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	DEBDFGMFDBB CHGPFNAABMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ConnectableConfigData : ScriptableObject, GADEDDGDLFN
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
			[Cpp2IlInjected.Address(RVA = "0x6DB8D0", Offset = "0x6DA2D0", VA = "0x1806DB8D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public DEBDFGMFDBB LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public DEBDFGMFDBB ObjectModelLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5515840", Offset = "0x5514240", VA = "0x185515840")]
		public static ConnectableConfigData NPOLBJEHEDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x55158E0", Offset = "0x55142E0", VA = "0x1855158E0")]
		public ConnectableConfigData(ConnectableLinkVisual JEAFOKOPAKI, bool NOEMNJFFMNC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PCNHCFNNABC : IEquatable<PCNHCFNNABC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public LHEHFGFGCOA MMKMHECDHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int BDKJJALEGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int PBAAPGEJPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Vector3 LNCOLOGFNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Quaternion DBMPKDBKHPD;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x552D5B0", Offset = "0x552BFB0", VA = "0x18552D5B0")]
	public PCNHCFNNABC(LHEHFGFGCOA MMKMHECDHFO, int BDKJJALEGPD, int PBAAPGEJPIM, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x552D610", Offset = "0x552C010", VA = "0x18552D610")]
	public PCNHCFNNABC(LHEHFGFGCOA MMKMHECDHFO, int BDKJJALEGPD, int PBAAPGEJPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x552D680", Offset = "0x552C080", VA = "0x18552D680")]
	public PCNHCFNNABC(LHEHFGFGCOA MMKMHECDHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x552D100", Offset = "0x552BB00", VA = "0x18552D100", Slot = "4")]
	public bool Equals(PCNHCFNNABC DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x552D1A0", Offset = "0x552BBA0", VA = "0x18552D1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
public class NGOALAACMAN : HFLBBFOEAII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Transform CLHKPCIOCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private PNOGGKDMNGE MNKKADGAMIE;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2E62B60", Offset = "0x2E61560", VA = "0x182E62B60", Slot = "4")]
	public void JGKFDHOAMGH(Transform CLHKPCIOCGF, PNOGGKDMNGE MNKKADGAMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x55264F0", Offset = "0x5524EF0", VA = "0x1855264F0", Slot = "5")]
	public PNOGGKDMNGE DFNFJBENIEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5526540", Offset = "0x5524F40", VA = "0x185526540", Slot = "6")]
	public void LDGKHHPCMPE(PNOGGKDMNGE JPDPEOMFMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public NGOALAACMAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal class FKJNNBLBHNL : IDisposable, LFBNOIOAFDP
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class EOOILNNHMPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public LHEHFGFGCOA oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public LHEHFGFGCOA newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public EOOILNNHMPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x55171A0", Offset = "0x5515BA0", VA = "0x1855171A0")]
		internal bool <NotifyRootChangedRecurse>b__0(KANMCHKABGP node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly NMEKAABHIBE BMHFJJIABCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private GEANCBAFLDI HPEGHDNONKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EIMBIBHJIFP KJBMIMOPDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private bool NOEMNJFFMNC;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public KANMCHKABGP PMIOODBJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5517F80", Offset = "0x5516980", VA = "0x185517F80")]
	public bool ILCAPFKJBNH(in MFAFPEGLAMD NIPBPKPBPPP, bool GPLKPAJIFCP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5517260", Offset = "0x5515C60", VA = "0x185517260")]
	private bool BAMMIIHNNCA(in MFAFPEGLAMD NIPBPKPBPPP, bool GPLKPAJIFCP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5519270", Offset = "0x5517C70", VA = "0x185519270", Slot = "8")]
	public bool HKHHEIGDEBN(LHEHFGFGCOA NPFPDEEOOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x551B200", Offset = "0x5519C00", VA = "0x18551B200")]
	private bool PEIGPMDEBHA(LHEHFGFGCOA PBINBGONFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x551A7D0", Offset = "0x55191D0", VA = "0x18551A7D0")]
	private static bool LECFOKJHIPJ(LHEHFGFGCOA PBINBGONFCN, NMEKAABHIBE LJFCJOMEHBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x551ADD0", Offset = "0x55197D0", VA = "0x18551ADD0")]
	private void PCGHGCHNJCO(Transform KNGMLDCNPJG, NMEKAABHIBE IJPGODAHLHN, NMEKAABHIBE[] HKJOBAICLLB, LHEHFGFGCOA DECJKBBHPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x551AA40", Offset = "0x5519440", VA = "0x18551AA40")]
	private PCNHCFNNABC OJIJJFNPCAP(Transform NOFNCAHFIEF, PCNHCFNNABC ACDKLDCPCAF)
	{
		return default(PCNHCFNNABC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5519490", Offset = "0x5517E90", VA = "0x185519490")]
	private static bool IJOCCOBHFAA(NMEKAABHIBE LJFCJOMEHBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5519050", Offset = "0x5517A50", VA = "0x185519050")]
	private string FPDPEEPJPKJ(LHEHFGFGCOA MMKMHECDHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5519200", Offset = "0x5517C00", VA = "0x185519200")]
	private string HFFFDBBFEIL(LHEHFGFGCOA MMKMHECDHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x551B7E0", Offset = "0x551A1E0", VA = "0x18551B7E0")]
	private void PMOFLDPFFOL(in MFAFPEGLAMD NIPBPKPBPPP, bool CHBAEKGGGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x551ABF0", Offset = "0x55195F0", VA = "0x18551ABF0")]
	private void PCEKALHEMIF(LHEHFGFGCOA DDLMBHAEKGH, bool CHBAEKGGGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5518130", Offset = "0x5516B30", VA = "0x185518130")]
	private void EFAGLHADBCG(LHEHFGFGCOA ADFMGEDLFLH, int NIAFHAFBKPN, LHEHFGFGCOA DILGNCFGGHK, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD, bool CHBAEKGGGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5519D10", Offset = "0x5518710", VA = "0x185519D10")]
	private void JKGGKDKOCJP(LHEHFGFGCOA CBOGNNELBNC, int NIAFHAFBKPN, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD, bool OECJAALELDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5519C30", Offset = "0x5518630", VA = "0x185519C30", Slot = "9")]
	public bool JJKCBKMGNKO(LHEHFGFGCOA CBOGNNELBNC, int NIAFHAFBKPN, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x55199A0", Offset = "0x55183A0", VA = "0x1855199A0")]
	private bool JJJMKDJPIHJ(LHEHFGFGCOA CBOGNNELBNC, int NIAFHAFBKPN, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x551A440", Offset = "0x5518E40", VA = "0x18551A440")]
	private static void KGMDJGHEDJD(LHEHFGFGCOA CBOGNNELBNC, int NIAFHAFBKPN, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD, NMEKAABHIBE FODBLHPDMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x551A920", Offset = "0x5519320", VA = "0x18551A920")]
	private void LONPGCCJBOI(LHEHFGFGCOA ADFMGEDLFLH, int CHLFBCEPEAJ, LHEHFGFGCOA DILGNCFGGHK, int KLOPGBAGEFI, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5519190", Offset = "0x5517B90", VA = "0x185519190")]
	private void GBOOEAHANDH(NMEKAABHIBE MMAGBLNBOEG, LHEHFGFGCOA NJBJKLIJDDA, LHEHFGFGCOA MCCGBMECIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5519120", Offset = "0x5517B20", VA = "0x185519120")]
	private void GBOOEAHANDH(LHEHFGFGCOA MMKMHECDHFO, LHEHFGFGCOA NJBJKLIJDDA, LHEHFGFGCOA MCCGBMECIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5517D10", Offset = "0x5516710", VA = "0x185517D10")]
	private void BLBKGAFFCCB(LHEHFGFGCOA MMKMHECDHFO, LHEHFGFGCOA NJBJKLIJDDA, LHEHFGFGCOA MCCGBMECIAB, bool HNONKJJDNKE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5517E30", Offset = "0x5516830", VA = "0x185517E30")]
	private void BLBKGAFFCCB(NMEKAABHIBE OFMDHDILEHM, LHEHFGFGCOA DECJKBBHPHN, LHEHFGFGCOA DHALEBLPIMI, bool HNONKJJDNKE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x55194C0", Offset = "0x5517EC0", VA = "0x1855194C0")]
	private void JBFAHEFCONI(LHEHFGFGCOA DDLMBHAEKGH, int NIAFHAFBKPN, LHEHFGFGCOA DILGNCFGGHK, int KLOPGBAGEFI, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5517FD0", Offset = "0x55169D0", VA = "0x185517FD0")]
	private void EELKEBPLNDH(KANMCHKABGP ELGBIOMPEHN, KANMCHKABGP IENEENKANMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5517BE0", Offset = "0x55165E0", VA = "0x185517BE0", Slot = "13")]
	public void BGLOIGJNFCC(LHEHFGFGCOA MMKMHECDHFO, out Vector3 LNCOLOGFNJN, out Quaternion DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5518F20", Offset = "0x5517920", VA = "0x185518F20", Slot = "14")]
	public LHEHFGFGCOA FGLKCNAFHKP(LHEHFGFGCOA MMKMHECDHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x55177D0", Offset = "0x55161D0", VA = "0x1855177D0", Slot = "15")]
	public void BFPBHCLHJMC(LHEHFGFGCOA MMKMHECDHFO, HashSet<LHEHFGFGCOA> NFNHEIJEPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x551A5C0", Offset = "0x5518FC0", VA = "0x18551A5C0", Slot = "16")]
	public List<LHEHFGFGCOA> KLMODIAGAHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5518730", Offset = "0x5517130", VA = "0x185518730")]
	protected KANMCHKABGP EGNMHDPBCIF(KANMCHKABGP MMAGBLNBOEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x551A880", Offset = "0x5519280", VA = "0x18551A880")]
	protected NMEKAABHIBE[] LNMMLIMGFCA(NMEKAABHIBE LJFCJOMEHBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5518800", Offset = "0x5517200", VA = "0x185518800")]
	protected bool ENNFAENGINB(LHEHFGFGCOA MMKMHECDHFO, out NMEKAABHIBE MMAGBLNBOEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x55188D0", Offset = "0x55172D0", VA = "0x1855188D0", Slot = "17")]
	public bool FCNHEEKDAFC(LHEHFGFGCOA MMKMHECDHFO, out PCNHCFNNABC HMLOIANJCGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5517F40", Offset = "0x5516940", VA = "0x185517F40")]
	protected NMEKAABHIBE DFCAFFMLFBA(PCNHCFNNABC GBNOMNHNBCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x551A350", Offset = "0x5518D50", VA = "0x18551A350", Slot = "10")]
	public bool KCCGDMEGFBJ(LHEHFGFGCOA ADFMGEDLFLH, int CHLFBCEPEAJ, LHEHFGFGCOA DILGNCFGGHK, int KLOPGBAGEFI, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x55189D0", Offset = "0x55173D0", VA = "0x1855189D0")]
	private bool FGHNNOEACHA(LHEHFGFGCOA ADFMGEDLFLH, int CHLFBCEPEAJ, LHEHFGFGCOA DILGNCFGGHK, int KLOPGBAGEFI, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5517B10", Offset = "0x5516510", VA = "0x185517B10")]
	private static bool BGIKJGPIHAF(NMEKAABHIBE HONOGABJBBP, PCNHCFNNABC GCIOHPDLKBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x551BE20", Offset = "0x551A820", VA = "0x18551BE20")]
	public FKJNNBLBHNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5519910", Offset = "0x5518310", VA = "0x185519910", Slot = "5")]
	public void JGKFDHOAMGH(LFLOFKNKOHK MPEBEBMNLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5519460", Offset = "0x5517E60", VA = "0x185519460", Slot = "19")]
	public void HPLICJANLIN(LHFJJMHBDBG JOIALDGLEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x55195D0", Offset = "0x5517FD0", VA = "0x1855195D0", Slot = "12")]
	public void JFDCPOMGCBK(Func<LHEHFGFGCOA, bool> NAHBKCHPDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x55195E0", Offset = "0x5517FE0", VA = "0x1855195E0")]
	private void JFDCPOMGCBK(NMEKAABHIBE MMAGBLNBOEG, Func<LHEHFGFGCOA, bool> NAHBKCHPDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x551ABD0", Offset = "0x55195D0", VA = "0x18551ABD0", Slot = "11")]
	public void PAPJMIEDBKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5517F80", Offset = "0x5516980", VA = "0x185517F80", Slot = "7")]
	private bool DLPGCOCPLJL(in MFAFPEGLAMD NIPBPKPBPPP, bool GPLKPAJIFCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Preserve]
internal class NADIOJEHPLA : LFLOFKNKOHK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly PLIBOCMCGIC KCKJCMPILDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly EIMBIBHJIFP KJBMIMOPDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly EBOGNIFCHNN IJJNFDLPJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly ABNNOLFIHFN JAINECODPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly LFBNOIOAFDP NFPBNLAEKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal DFHJHGFLPCB EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal BKILGOMMNMA LNMHPEDOLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal GEANCBAFLDI LNAEMHADNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal bool NOEMNJFFMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool KFJPABEDKEP;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool AFJDAKHEANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x111B340", Offset = "0x1119D40", VA = "0x18111B340")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xE517E0", Offset = "0xE501E0", VA = "0x180E517E0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JDCINNHHEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xB73E40", Offset = "0xB72840", VA = "0x180B73E40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x12E7250", Offset = "0x12E5C50", VA = "0x1812E7250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<LHEHFGFGCOA, LHEHFGFGCOA> LAFCHHLEOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5525D70", Offset = "0x5524770", VA = "0x185525D70", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5524A90", Offset = "0x5523490", VA = "0x185524A90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<LHEHFGFGCOA, LHEHFGFGCOA> AEIKDLAFHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5525FD0", Offset = "0x55249D0", VA = "0x185525FD0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5525520", Offset = "0x5523F20", VA = "0x185525520", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<LHEHFGFGCOA, LHEHFGFGCOA, LHEHFGFGCOA> AHJMBPHDLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5526030", Offset = "0x5524A30", VA = "0x185526030", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5524A30", Offset = "0x5523430", VA = "0x185524A30", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x55261B0", Offset = "0x5524BB0", VA = "0x1855261B0")]
	public NADIOJEHPLA(PLIBOCMCGIC KCKJCMPILDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5525610", Offset = "0x5524010", VA = "0x185525610", Slot = "11")]
	public void JGKFDHOAMGH(GameObject KEHOIMKGHCH, GADEDDGDLFN EOAAKGAPBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5524E20", Offset = "0x5523820", VA = "0x185524E20", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5524850", Offset = "0x5523250", VA = "0x185524850", Slot = "12")]
	public void BBFMMOJDOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5525F90", Offset = "0x5524990", VA = "0x185525F90", Slot = "13")]
	public void OGMDKKEHOIN(LHEHFGFGCOA MMKMHECDHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5524AF0", Offset = "0x55234F0", VA = "0x185524AF0", Slot = "14")]
	public void DDIDMMIANOF(LHEHFGFGCOA MMKMHECDHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x55249C0", Offset = "0x55233C0", VA = "0x1855249C0", Slot = "22")]
	public bool CEDJCCGBKED(ECFNNHBBONE GOADIACIEED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5524790", Offset = "0x5523190", VA = "0x185524790")]
	internal bool BAMMIIHNNCA(in MFAFPEGLAMD NIPBPKPBPPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5525350", Offset = "0x5523D50", VA = "0x185525350")]
	internal bool FGHNNOEACHA(in MFAFPEGLAMD NIPBPKPBPPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5524C90", Offset = "0x5523690", VA = "0x185524C90")]
	internal bool DJFEFPBMBPF(in MFAFPEGLAMD NIPBPKPBPPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x55253E0", Offset = "0x5523DE0", VA = "0x1855253E0")]
	internal bool FMEFHNCHJIF(in MFAFPEGLAMD NIPBPKPBPPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5525B90", Offset = "0x5524590", VA = "0x185525B90")]
	internal void JKGPKKEGDBM(LHEHFGFGCOA MMKMHECDHFO, int JHMFNFLJACA, bool GPLKPAJIFCP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5524AF0", Offset = "0x55234F0", VA = "0x185524AF0")]
	internal bool KKFBHCEDGFH(LHEHFGFGCOA IEIILDHIHCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5524CF0", Offset = "0x55236F0", VA = "0x185524CF0")]
	internal bool DMOOGGAELGN(LHEHFGFGCOA CBOGNNELBNC, int NIAFHAFBKPN, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x55248C0", Offset = "0x55232C0", VA = "0x1855248C0", Slot = "15")]
	public void BFPBHCLHJMC(LHEHFGFGCOA MMKMHECDHFO, HashSet<LHEHFGFGCOA> EDMNKADLJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5525000", Offset = "0x5523A00", VA = "0x185525000", Slot = "16")]
	public void EKDAKCONHHM(LHEHFGFGCOA CBOGNNELBNC, LHEHFGFGCOA IKDGDLOPOKG, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5525210", Offset = "0x5523C10", VA = "0x185525210")]
	public void FEFHAEEDLLP(LHEHFGFGCOA ANABKFNBCHO, int NIAFHAFBKPN, LHEHFGFGCOA FILEOABIGBM, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x55249D0", Offset = "0x55233D0", VA = "0x1855249D0")]
	public void CEFIBABPIEL(LHEHFGFGCOA NPFPDEEOOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5524EC0", Offset = "0x55238C0", VA = "0x185524EC0")]
	public void EKDAKCONHHM(LHEHFGFGCOA CBOGNNELBNC, LHEHFGFGCOA IKDGDLOPOKG, int NIAFHAFBKPN, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5524B50", Offset = "0x5523550", VA = "0x185524B50", Slot = "17")]
	public void DIGADINJLAG(LHEHFGFGCOA ADFMGEDLFLH, int CHLFBCEPEAJ, LHEHFGFGCOA DILGNCFGGHK, int KLOPGBAGEFI, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5525DD0", Offset = "0x55247D0", VA = "0x185525DD0", Slot = "18")]
	public void NMGLOPAPJNN(LHEHFGFGCOA ADFMGEDLFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x55255C0", Offset = "0x5523FC0", VA = "0x1855255C0", Slot = "19")]
	public bool HIOMLOPFMMF(LHEHFGFGCOA MMKMHECDHFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5526090", Offset = "0x5524A90", VA = "0x185526090")]
	public void PNGKPKILICF([Optional] LLFLMPPMGID GCPFNNBAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5524700", Offset = "0x5523100", VA = "0x185524700", Slot = "23")]
	public void AOKDLCEEPCA(GJKMJOMCFOL NFPBNLAEKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x55248A0", Offset = "0x55232A0", VA = "0x1855248A0", Slot = "20")]
	public GJKMJOMCFOL BENJAEINCCI(bool MLIFFPFMKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5525FB0", Offset = "0x55249B0", VA = "0x185525FB0", Slot = "21")]
	public GJKMJOMCFOL PAABNOFEHCA(HashSet<Guid> PKPLNKLEMOL, bool MLIFFPFMKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5525580", Offset = "0x5523F80", VA = "0x185525580", Slot = "25")]
	public void GOOCFDMDCLH(GJKMJOMCFOL NFPBNLAEKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5524650", Offset = "0x5523050", VA = "0x185524650", Slot = "24")]
	public void ABAHCOGPMLF(GJKMJOMCFOL NFPBNLAEKIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class EIMBIBHJIFP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly global::OMHDGNNJAPI<LHEHFGFGCOA, LHEHFGFGCOA> LAFCHHLEOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly global::OMHDGNNJAPI<LHEHFGFGCOA, LHEHFGFGCOA> AEIKDLAFHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly global::BIKJMNNNOIL<LHEHFGFGCOA, LHEHFGFGCOA, LHEHFGFGCOA> AHJMBPHDLGG;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5516E60", Offset = "0x5515860", VA = "0x185516E60")]
	public EIMBIBHJIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	public void JGKFDHOAMGH(NADIOJEHPLA MPEBEBMNLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5516D80", Offset = "0x5515780", VA = "0x185516D80")]
	public void KDCHIAALMGF(LHEHFGFGCOA ELGBIOMPEHN, LHEHFGFGCOA DDLMBHAEKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5516D20", Offset = "0x5515720", VA = "0x185516D20")]
	public void BKNMKOAPGIH(LHEHFGFGCOA ELGBIOMPEHN, LHEHFGFGCOA DDLMBHAEKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5516DE0", Offset = "0x55157E0", VA = "0x185516DE0")]
	public void NMIANELOPDG(LHEHFGFGCOA PMJEABCAKDM, LHEHFGFGCOA DILGNCFGGHK, LHEHFGFGCOA DDLMBHAEKGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class EBOGNIFCHNN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private NADIOJEHPLA MPEBEBMNLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private BKILGOMMNMA LNMHPEDOLKI;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public EBOGNIFCHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5516A70", Offset = "0x5515470", VA = "0x185516A70")]
	public void JGKFDHOAMGH(NADIOJEHPLA MPEBEBMNLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5516A40", Offset = "0x5515440", VA = "0x185516A40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5516A50", Offset = "0x5515450", VA = "0x185516A50")]
	private void FAGBLINEJDM(LLFLMPPMGID CALNIJNFDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5516CB0", Offset = "0x55156B0", VA = "0x185516CB0")]
	private void LLHNFGGPJMM(LLFLMPPMGID OABPEPNAJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5516BB0", Offset = "0x55155B0", VA = "0x185516BB0")]
	public void KEPFMJPMMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5516930", Offset = "0x5515330", VA = "0x185516930")]
	public void DAMANPOJLPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class DFNJBNMBIKK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MIANLJKPEPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public PLIBOCMCGIC container;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public MIANLJKPEPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5520870", Offset = "0x551F270", VA = "0x185520870")]
		internal NADIOJEHPLA <BindServices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5516510", Offset = "0x5514F10", VA = "0x185516510")]
	public static void BDMDPGPGNDK(PLIBOCMCGIC KCKJCMPILDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5516710", Offset = "0x5515110", VA = "0x185516710")]
	public static void OFEIBCGGBKG(PLIBOCMCGIC KCKJCMPILDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
internal class IOLGFEFABJD : IDisposable, GEANCBAFLDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Dictionary<int, PNOGGKDMNGE> NJNHDBDFAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly LHFJJMHBDBG GBEBBKBHCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HFLBBFOEAII ONNNJCPGIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private LFBNOIOAFDP NFPBNLAEKIF;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x551E150", Offset = "0x551CB50", VA = "0x18551E150")]
	public IOLGFEFABJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x551DF60", Offset = "0x551C960", VA = "0x18551DF60", Slot = "7")]
	public void JGKFDHOAMGH(LFBNOIOAFDP NFPBNLAEKIF, HFLBBFOEAII ONNNJCPGIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x551DC60", Offset = "0x551C660", VA = "0x18551DC60", Slot = "5")]
	public void HOECGGADNKA(KANMCHKABGP DMFNEEGDMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x551DAF0", Offset = "0x551C4F0", VA = "0x18551DAF0", Slot = "9")]
	public void EOFIDKOIKLP(KANMCHKABGP JAFOAIEGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x551DFA0", Offset = "0x551C9A0", VA = "0x18551DFA0", Slot = "8")]
	public void KINMMIMFCIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x551D7D0", Offset = "0x551C1D0", VA = "0x18551D7D0", Slot = "10")]
	public void EGPOELMLOCO(KANMCHKABGP NONLCODHJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x551DEA0", Offset = "0x551C8A0", VA = "0x18551DEA0", Slot = "11")]
	public void ILHCJLBEFBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x551D630", Offset = "0x551C030", VA = "0x18551D630")]
	private bool ECJHMHENHEA(KANMCHKABGP DMOPMBKFMFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class ABNNOLFIHFN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal struct IGJIKAPCPFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly NMEKAABHIBE MLJCKOCBGBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly HashSet<Guid> PKPLNKLEMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly ECFNNHBBONE GKAFJMHCPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ECFNNHBBONE KDNKOOOPCIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly bool MLIFFPFMKCE;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private bool KBIAGNGKKDC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x551CC60", Offset = "0x551B660", VA = "0x18551CC60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x551CD70", Offset = "0x551B770", VA = "0x18551CD70")]
		public IGJIKAPCPFC(NMEKAABHIBE MLJCKOCBGBE, HashSet<Guid> PKPLNKLEMOL, bool MLIFFPFMKCE, [Optional] ECFNNHBBONE GKAFJMHCPFG, [Optional] ECFNNHBBONE KDNKOOOPCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x551C980", Offset = "0x551B380", VA = "0x18551C980")]
		public ECFNNHBBONE JHPOCMCIPNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x551C720", Offset = "0x551B120", VA = "0x18551C720")]
		private ECFNNHBBONE DIEBOFIGLJG(out ECFNNHBBONE BIDFFNNCGMC, out ECFNNHBBONE ADFIAGKNILJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x551C520", Offset = "0x551AF20", VA = "0x18551C520")]
		private ECFNNHBBONE BFDMAJOOAFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x551CAE0", Offset = "0x551B4E0", VA = "0x18551CAE0")]
		private void MHBABDHOCCF(ECFNNHBBONE CKNICPEKGKH, ECFNNHBBONE PNJHBMGBJPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x551C7E0", Offset = "0x551B1E0", VA = "0x18551C7E0")]
		private void JHCPOANHKBO(ECFNNHBBONE BIDFFNNCGMC, ECFNNHBBONE ADFIAGKNILJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private NADIOJEHPLA MPEBEBMNLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private LFBNOIOAFDP NFPBNLAEKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private GEANCBAFLDI HPEGHDNONKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private BKILGOMMNMA LNMHPEDOLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool BADJFGPDDFP;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool KGLMJPNJMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5514270", Offset = "0x5512C70", VA = "0x185514270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool AFJDAKHEANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5514300", Offset = "0x5512D00", VA = "0x185514300")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x5514320", Offset = "0x5512D20", VA = "0x185514320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5514340", Offset = "0x5512D40", VA = "0x185514340")]
	public void JGKFDHOAMGH(NADIOJEHPLA MPEBEBMNLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5512650", Offset = "0x5511050", VA = "0x185512650")]
	public GJKMJOMCFOL BENJAEINCCI(bool MLIFFPFMKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5514EC0", Offset = "0x55138C0", VA = "0x185514EC0")]
	public GJKMJOMCFOL PAABNOFEHCA(HashSet<Guid> PKPLNKLEMOL, bool MLIFFPFMKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x55125C0", Offset = "0x5510FC0", VA = "0x1855125C0")]
	public void AOKDLCEEPCA(GJKMJOMCFOL NFPBNLAEKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5512520", Offset = "0x5510F20", VA = "0x185512520")]
	public void ABAHCOGPMLF(GJKMJOMCFOL NFPBNLAEKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5513150", Offset = "0x5511B50", VA = "0x185513150")]
	public void CGCBFAPCIIN(GJKMJOMCFOL NFPBNLAEKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5513560", Offset = "0x5511F60", VA = "0x185513560")]
	private void FBDIIMLCGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5513380", Offset = "0x5511D80", VA = "0x185513380")]
	private ECFNNHBBONE EKABCJKDJHJ(NMEKAABHIBE MMAGBLNBOEG, bool MLIFFPFMKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5513860", Offset = "0x5512260", VA = "0x185513860")]
	private static void HBJPJCKPHJK(NMEKAABHIBE MMAGBLNBOEG, bool MLIFFPFMKCE, ECFNNHBBONE GOADIACIEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5513180", Offset = "0x5511B80", VA = "0x185513180")]
	private void CNNFLMKFMCM(NMEKAABHIBE MMAGBLNBOEG, bool MLIFFPFMKCE, ECFNNHBBONE GOADIACIEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5515680", Offset = "0x5514080", VA = "0x185515680")]
	private ECFNNHBBONE PBCJPENMJHG(NMEKAABHIBE MLJCKOCBGBE, HashSet<Guid> PKPLNKLEMOL, bool MLIFFPFMKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5513FF0", Offset = "0x55129F0", VA = "0x185513FF0")]
	private bool IEOCPNAKAAG(GJKMJOMCFOL KKGIIBDBNFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5514860", Offset = "0x5513260", VA = "0x185514860")]
	private bool NEOHGPHJAKD(ECFNNHBBONE GOADIACIEED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5514EA0", Offset = "0x55138A0", VA = "0x185514EA0")]
	private bool OANJJJKKHMG(GJKMJOMCFOL NFPBNLAEKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x55136F0", Offset = "0x55120F0", VA = "0x1855136F0")]
	private static bool FPNMANAMLFB(ECFNNHBBONE GOADIACIEED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5512E90", Offset = "0x5511890", VA = "0x185512E90")]
	public static bool CEDJCCGBKED(ECFNNHBBONE GOADIACIEED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x55143B0", Offset = "0x5512DB0", VA = "0x1855143B0")]
	private LHEHFGFGCOA LODALHBBFND(ECFNNHBBONE GOADIACIEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5513BC0", Offset = "0x55125C0", VA = "0x185513BC0")]
	private LHEHFGFGCOA HEEPIBKEHPK(ECFNNHBBONE GOADIACIEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5512D10", Offset = "0x5511710", VA = "0x185512D10")]
	private LHEHFGFGCOA BGNNDEABLLP(ECFNNHBBONE GOADIACIEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x55142C0", Offset = "0x5512CC0", VA = "0x1855142C0")]
	private static Guid ILOOEEBOMPA(ECFNNHBBONE GOADIACIEED)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5513AE0", Offset = "0x55124E0", VA = "0x185513AE0")]
	private string HDJJPCBMBEG(ECFNNHBBONE GOADIACIEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5514700", Offset = "0x5513100", VA = "0x185514700")]
	private bool NEFEKNPGMNO(NMEKAABHIBE MMAGBLNBOEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5513D50", Offset = "0x5512750", VA = "0x185513D50")]
	private static void IAJNNMDABNI(NMEKAABHIBE MLJCKOCBGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public ABNNOLFIHFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class MKFOGGPLEAC : GJCADCMMOKB, KPDKADGFAPJ
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private const string HALEFGBBMKI = "Parented";

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private const string KAOHNKFLPFB = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GameObject KEHOIMKGHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly LFLOFKNKOHK OHIIILCCCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly JEMIICPINJD JDBCCMFOKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly IBCGGLCHCHC[] MPCFBFOGFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly INNEIOIKCEH EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<LHEHFGFGCOA> DCCKMINJFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private MLAIABPOALE LAGBFKKJCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private Vector3 BPPCKLBLMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Quaternion AKGFEKMGOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private bool ALCGLJHHAFI;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public LHEHFGFGCOA PGLJHEOHBKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LHEHFGFGCOA CEICFCIOKED
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D80", Offset = "0x6C6780", VA = "0x1806C7D80", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8CBEB0", Offset = "0x8CA8B0", VA = "0x1808CBEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Vector3 NGGFMHOLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5521F40", Offset = "0x5520940", VA = "0x185521F40", Slot = "15")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1339D10", Offset = "0x1338710", VA = "0x181339D10")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Quaternion DHGEFGCKOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5523610", Offset = "0x5522010", VA = "0x185523610", Slot = "16")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1CB2900", Offset = "0x1CB1300", VA = "0x181CB2900")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool JHOHPHOKJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xBAA280", Offset = "0xBA8C80", VA = "0x180BAA280")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xBAA820", Offset = "0xBA9220", VA = "0x180BAA820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool PLLPIOAEHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5521270", Offset = "0x551FC70", VA = "0x185521270", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public LHEHFGFGCOA PHLNNFFEGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6A0", Offset = "0x6FC0A0", VA = "0x1806FD6A0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8CB4D0", Offset = "0x8C9ED0", VA = "0x1808CB4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private bool OKOCBEFJACG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x55208D0", Offset = "0x551F2D0", VA = "0x1855208D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private RigidbodyEx KMCNGKJKBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5521210", Offset = "0x551FC10", VA = "0x185521210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<LHEHFGFGCOA> NNKNBBHLJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool KCPGHEBLKNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5520C20", Offset = "0x551F620", VA = "0x185520C20", Slot = "18")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5522CC0", Offset = "0x55216C0", VA = "0x185522CC0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Transform ONMPEEDNICF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5524630", Offset = "0x5523030", VA = "0x185524630", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public GameObject AKKLNJDLHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string AECGGMKOOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x55243A0", Offset = "0x5522DA0", VA = "0x1855243A0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Guid HNBBGALPNMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5524500", Offset = "0x5522F00", VA = "0x185524500", Slot = "37")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int MHIBCCOLPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x55245E0", Offset = "0x5522FE0", VA = "0x1855245E0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x55243F0", Offset = "0x5522DF0", VA = "0x1855243F0", Slot = "39")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool BJCFBLIPPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event IHMADODKHKN GKCGBFIOLBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x55216C0", Offset = "0x55200C0", VA = "0x1855216C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x5521A50", Offset = "0x5520450", VA = "0x185521A50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event IHMADODKHKN FGMJLHPOOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x5520B80", Offset = "0x551F580", VA = "0x185520B80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x55223A0", Offset = "0x5520DA0", VA = "0x1855223A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event IHMADODKHKN CLEOCKLJJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x5522C20", Offset = "0x5521620", VA = "0x185522C20", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x5520920", Offset = "0x551F320", VA = "0x185520920", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event IPFEJGABLKG MECPNCMNGMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x5523280", Offset = "0x5521C80", VA = "0x185523280", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x55224A0", Offset = "0x5520EA0", VA = "0x1855224A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5521AF0", Offset = "0x55204F0", VA = "0x185521AF0")]
	private RigidbodyEx IEMJOENIJEM(LHEHFGFGCOA JDBCCMFOKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x55242B0", Offset = "0x5522CB0", VA = "0x1855242B0")]
	public MKFOGGPLEAC(GameObject KEHOIMKGHCH, JEMIICPINJD JDBCCMFOKKJ, IBCGGLCHCHC[] MPCFBFOGFDO, INNEIOIKCEH EDFOBNPNANH, LFLOFKNKOHK OHIIILCCCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x55209C0", Offset = "0x551F3C0", VA = "0x1855209C0", Slot = "20")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5522440", Offset = "0x5520E40", VA = "0x185522440", Slot = "22")]
	public void KHHMCGIJFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5523320", Offset = "0x5521D20", VA = "0x185523320", Slot = "23")]
	public void PLHKJHNPHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5521180", Offset = "0x551FB80", VA = "0x185521180", Slot = "21")]
	public void DAFLDHNIGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5521D90", Offset = "0x5520790", VA = "0x185521D90")]
	private void IHPJPKADDNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x55230D0", Offset = "0x5521AD0", VA = "0x1855230D0")]
	private void OGDENBOKDMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5521760", Offset = "0x5520160", VA = "0x185521760", Slot = "24")]
	public void FLBBJOCKOHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5521990", Offset = "0x5520390", VA = "0x185521990", Slot = "25")]
	public void HLMJMKDGAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x55233A0", Offset = "0x5521DA0", VA = "0x1855233A0", Slot = "26")]
	public void PLJLJIMAFMA(int PACLGCIADGA, LHEHFGFGCOA FILEOABIGBM, int MJGOGEOBFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x55219B0", Offset = "0x55203B0", VA = "0x1855219B0", Slot = "27")]
	public void HOOPOBIFLBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5522D80", Offset = "0x5521780", VA = "0x185522D80", Slot = "28")]
	public void MMALMFEHHKH(int PACLGCIADGA, LHEHFGFGCOA ANABKFNBCHO, int NIAFHAFBKPN, [Optional] Vector3? LNCOLOGFNJN, [Optional] Quaternion? DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5520C70", Offset = "0x551F670", VA = "0x185520C70", Slot = "29")]
	public void CNLCACPJOGN(LHEHFGFGCOA ANABKFNBCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5521FB0", Offset = "0x55209B0", VA = "0x185521FB0")]
	private void KAGPHEHIALO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5521BF0", Offset = "0x55205F0", VA = "0x185521BF0", Slot = "31")]
	public void IHMFDCBGKPH(int GFDMFLGCBKB, Vector3 LGGBCCHKBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5521280", Offset = "0x551FC80", VA = "0x185521280", Slot = "32")]
	public void FCEGKHCIOMA(Vector3 PDKMIJPIGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5522540", Offset = "0x5520F40", VA = "0x185522540", Slot = "30")]
	public void KMDPAECIDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x55218C0", Offset = "0x55202C0", VA = "0x1855218C0", Slot = "42")]
	public Vector3 GetConnectionSlotPosition(int PACLGCIADGA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5521780", Offset = "0x5520180", VA = "0x185521780", Slot = "41")]
	public Vector3 GetConnectionSlotLocalPosition(int PACLGCIADGA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x17FA510", Offset = "0x17F8F10", VA = "0x1817FA510", Slot = "43")]
	public Color GetConnectionSlotColor(int PACLGCIADGA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5520D10", Offset = "0x551F710", VA = "0x185520D10", Slot = "44")]
	public bool CanConnectTo(int PACLGCIADGA, LHEHFGFGCOA OOLAJGAJNNN, int OJPFPAKOICG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5521B50", Offset = "0x5520550", VA = "0x185521B50")]
	public bool IHGPCKFDMJE(LHEHFGFGCOA DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5523680", Offset = "0x5522080", VA = "0x185523680", Slot = "45")]
	public void ParentChanged(int PACLGCIADGA, LHEHFGFGCOA LOJDAINCFHP, int KLOPGBAGEFI, Vector3 MEBKAIMJEKP, Quaternion IFFDCCIBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5520DB0", Offset = "0x551F7B0", VA = "0x185520DB0", Slot = "46")]
	public void ChildAdded(int PACLGCIADGA, LHEHFGFGCOA ABEBIPPGHNO, int BPADFAIHIIG, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5520F60", Offset = "0x551F960", VA = "0x185520F60", Slot = "47")]
	public void ChildRemoved(int PACLGCIADGA, LHEHFGFGCOA KBCFMLNEFMC, int PNOFEIBPCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5521020", Offset = "0x551FA20", VA = "0x185521020", Slot = "48")]
	public void ConnectionModified(int PACLGCIADGA, LHEHFGFGCOA FILEOABIGBM, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5524250", Offset = "0x5522C50", VA = "0x185524250", Slot = "49")]
	public void RootChanged(LHEHFGFGCOA GOECFNEKPNN, LHEHFGFGCOA DHALEBLPIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5520B10", Offset = "0x551F510", VA = "0x185520B10")]
	private void AOEHKGPDDLG(LLFLMPPMGID HEBGAFADEPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct MFAFPEGLAMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LHEHFGFGCOA DDLMBHAEKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LHEHFGFGCOA ELGBIOMPEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int NIAFHAFBKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public int MJGOGEOBFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Vector3 LNCOLOGFNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Quaternion DBMPKDBKHPD;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public PCNHCFNNABC CIDHODCKMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5520760", Offset = "0x551F160", VA = "0x185520760")]
		get
		{
			return default(PCNHCFNNABC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public PCNHCFNNABC LDLOEJABAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x55206F0", Offset = "0x551F0F0", VA = "0x1855206F0")]
		get
		{
			return default(PCNHCFNNABC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5520800", Offset = "0x551F200", VA = "0x185520800")]
	public MFAFPEGLAMD(LHEHFGFGCOA DDLMBHAEKGH, LHEHFGFGCOA ELGBIOMPEHN, int NIAFHAFBKPN, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface LFBNOIOAFDP
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	KANMCHKABGP PMIOODBJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGKFDHOAMGH(LFLOFKNKOHK MPEBEBMNLLA);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ILCAPFKJBNH(in MFAFPEGLAMD NIPBPKPBPPP, bool GPLKPAJIFCP = true);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HKHHEIGDEBN(LHEHFGFGCOA NPFPDEEOOFK);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JJKCBKMGNKO(LHEHFGFGCOA CBOGNNELBNC, int NIAFHAFBKPN, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KCCGDMEGFBJ(LHEHFGFGCOA ADFMGEDLFLH, int CHLFBCEPEAJ, LHEHFGFGCOA DILGNCFGGHK, int KLOPGBAGEFI, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PAPJMIEDBKF();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JFDCPOMGCBK(Func<LHEHFGFGCOA, bool> NAHBKCHPDKB);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BGLOIGJNFCC(LHEHFGFGCOA MMKMHECDHFO, out Vector3 LNCOLOGFNJN, out Quaternion DBMPKDBKHPD);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LHEHFGFGCOA FGLKCNAFHKP(LHEHFGFGCOA MMKMHECDHFO);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BFPBHCLHJMC(LHEHFGFGCOA MMKMHECDHFO, HashSet<LHEHFGFGCOA> NFNHEIJEPFK);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "11")]
	List<LHEHFGFGCOA> KLMODIAGAHF();

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FCNHEEKDAFC(LHEHFGFGCOA MMKMHECDHFO, out PCNHCFNNABC HMLOIANJCGJ);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HPLICJANLIN(LHFJJMHBDBG JOIALDGLEAK);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal delegate bool LHFJJMHBDBG(KANMCHKABGP MMAGBLNBOEG);
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface KANMCHKABGP
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	LHEHFGFGCOA PGLJHEOHBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int NFEGBBKOHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int PLHJNPBAGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Vector3 LFKHNCNFHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Quaternion NPCFOFMGGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	KANMCHKABGP NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	KANMCHKABGP PMIOODBJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	PCNHCFNNABC MJNMLNIMOJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool NBCBNCLNGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool OKGIGDIOGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HPLICJANLIN(LHFJJMHBDBG JOIALDGLEAK, bool HNONKJJDNKE = true);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KANMCHKABGP DFCAFFMLFBA(PCNHCFNNABC ALJBDDGKIAJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface PNOGGKDMNGE
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAKOKLHEDIO(LHEHFGFGCOA FILEOABIGBM, PCNHCFNNABC DDLMBHAEKGH);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MMKGGECJBFG(LHEHFGFGCOA FILEOABIGBM, PCNHCFNNABC DDLMBHAEKGH);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KLFIOAJOOPK(LHEHFGFGCOA FILEOABIGBM, PCNHCFNNABC DDLMBHAEKGH);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMMKLBNOHDG(LHEHFGFGCOA FILEOABIGBM, PCNHCFNNABC DDLMBHAEKGH);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PNOGGKDMNGE Instantiate(Transform CLHKPCIOCGF);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NJKFKCNNMGK();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HFLBBFOEAII
{
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGKFDHOAMGH(Transform CLHKPCIOCGF, PNOGGKDMNGE MNKKADGAMIE);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PNOGGKDMNGE DFNFJBENIEB();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LDGKHHPCMPE(PNOGGKDMNGE JPDPEOMFMMA);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface DFHJHGFLPCB : DFGMEPIHEII, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JAPFNDHECOC(Guid AINMPCPLNKP);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface GEANCBAFLDI
{
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HOECGGADNKA(KANMCHKABGP DMFNEEGDMJG);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGKFDHOAMGH(LFBNOIOAFDP NFPBNLAEKIF, HFLBBFOEAII HGFPAICCLKL);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KINMMIMFCIL();

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EOFIDKOIKLP(KANMCHKABGP JAFOAIEGHIJ);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EGPOELMLOCO(KANMCHKABGP NONLCODHJEH);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ILHCJLBEFBI();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal class NMEKAABHIBE : KANMCHKABGP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CHMPJCKEPJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public PCNHCFNNABC nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public NMEKAABHIBE foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public CHMPJCKEPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x5515710", Offset = "0x5514110", VA = "0x185515710")]
		internal bool <FindNode>b__0(KANMCHKABGP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private PCNHCFNNABC HMLOIANJCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public LinkedList<NMEKAABHIBE> DLHGIFABMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NMEKAABHIBE DMILCOKJOLO;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public PCNHCFNNABC MJNMLNIMOJP
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E96D0", VA = "0x1809EACD0", Slot = "16")]
		get
		{
			return default(PCNHCFNNABC);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x55269A0", Offset = "0x55253A0", VA = "0x1855269A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private NMEKAABHIBE ELGBIOMPEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6C10D0", Offset = "0x6BFAD0", VA = "0x1806C10D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5526F30", Offset = "0x5525930", VA = "0x185526F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public KANMCHKABGP NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6C10D0", Offset = "0x6BFAD0", VA = "0x1806C10D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public LHEHFGFGCOA PGLJHEOHBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6DFB30", VA = "0x1806E1130", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int NFEGBBKOHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BD0", Offset = "0x6C15D0", VA = "0x1806C2BD0", Slot = "6")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x765410", Offset = "0x763E10", VA = "0x180765410", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int PLHJNPBAGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6DCC90", Offset = "0x6DB690", VA = "0x1806DCC90", Slot = "8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x765320", Offset = "0x763D20", VA = "0x180765320", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 LFKHNCNFHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x1BDCCE0", Offset = "0x1BDB6E0", VA = "0x181BDCCE0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x1BDCDB0", Offset = "0x1BDB7B0", VA = "0x181BDCDB0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Quaternion NPCFOFMGGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2570710", Offset = "0x256F110", VA = "0x182570710", Slot = "12")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3E19F80", Offset = "0x3E18980", VA = "0x183E19F80", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool NBCBNCLNGPA
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x925950", Offset = "0x924350", VA = "0x180925950", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool OKGIGDIOGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5527320", Offset = "0x5525D20", VA = "0x185527320", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	protected NMEKAABHIBE OFMDHDILEHM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5526980", Offset = "0x5525380", VA = "0x185526980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public KANMCHKABGP PMIOODBJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5526980", Offset = "0x5525380", VA = "0x185526980", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x5527420", Offset = "0x5525E20", VA = "0x185527420")]
	public NMEKAABHIBE(PCNHCFNNABC DHGLJMJAIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x5526DF0", Offset = "0x55257F0", VA = "0x185526DF0")]
	public NMEKAABHIBE IBAFGGCIFCB(PCNHCFNNABC KDCOHAJJDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x5526B10", Offset = "0x5525510", VA = "0x185526B10")]
	public NMEKAABHIBE GFNOILKOJGN(PCNHCFNNABC JKNCNBAIJCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x5527150", Offset = "0x5525B50", VA = "0x185527150")]
	public NMEKAABHIBE OLCIACFECIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x5527010", Offset = "0x5525A10", VA = "0x185527010")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5527370", Offset = "0x5525D70", VA = "0x185527370")]
	public NMEKAABHIBE PBLAPOIHGJH(PCNHCFNNABC DILGNCFGGHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x5526C90", Offset = "0x5525690", VA = "0x185526C90")]
	private static void HPLICJANLIN(NMEKAABHIBE NGDCDFDGPMM, LHFJJMHBDBG LDDMJCCAAEJ, bool MOMKNEHLAOA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x5526DE0", Offset = "0x55257E0", VA = "0x185526DE0", Slot = "19")]
	public void HPLICJANLIN(LHFJJMHBDBG JOIALDGLEAK, bool HNONKJJDNKE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x5526590", Offset = "0x5524F90", VA = "0x185526590")]
	public static string ACNDEKJFKHH(NMEKAABHIBE NGDCDFDGPMM, int GLPDCHNEBJK = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x5526AE0", Offset = "0x55254E0", VA = "0x185526AE0", Slot = "20")]
	public KANMCHKABGP DFCAFFMLFBA(PCNHCFNNABC ALJBDDGKIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x55269D0", Offset = "0x55253D0", VA = "0x1855269D0")]
	public static NMEKAABHIBE DFCAFFMLFBA(NMEKAABHIBE NGDCDFDGPMM, PCNHCFNNABC ALJBDDGKIAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface BKILGOMMNMA
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool KGLMJPNJMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool LLHDPIAHEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event Action<LLFLMPPMGID> FAGBLINEJDM;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event Action<LLFLMPPMGID> LLHNFGGPJMM;

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(NADIOJEHPLA MPEBEBMNLLA);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterConnectNodes(LHEHFGFGCOA ANABKFNBCHO, int NIAFHAFBKPN, LHEHFGFGCOA FILEOABIGBM, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterDisconnectNode(LHEHFGFGCOA NPFPDEEOOFK);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestMasterModifyNode(LHEHFGFGCOA CBOGNNELBNC, LHEHFGFGCOA IKDGDLOPOKG, int NIAFHAFBKPN, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void RequestMasterReparentNodes(LHEHFGFGCOA ADFMGEDLFLH, int CHLFBCEPEAJ, LHEHFGFGCOA DILGNCFGGHK, int KLOPGBAGEFI, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void RequestMasterReparentToRoot(LHEHFGFGCOA ADFMGEDLFLH);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void RequestDeserializeConnectableGraph(GJKMJOMCFOL PKFLOKGIIHB, [Optional] LLFLMPPMGID GCPFNNBAFDE);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, BKILGOMMNMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private NADIOJEHPLA MPEBEBMNLLA;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool KGLMJPNJMHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x5520500", Offset = "0x551EF00", VA = "0x185520500", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool LLHDPIAHEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x5520560", Offset = "0x551EF60", VA = "0x185520560", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<LLFLMPPMGID> FAGBLINEJDM
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x5520460", Offset = "0x551EE60", VA = "0x185520460", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x5520650", Offset = "0x551F050", VA = "0x185520650", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<LLFLMPPMGID> LLHNFGGPJMM
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x55203C0", Offset = "0x551EDC0", VA = "0x1855203C0", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x55205B0", Offset = "0x551EFB0", VA = "0x1855205B0", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6C85A0", Offset = "0x6C6FA0", VA = "0x1806C85A0", Slot = "22")]
		public void SetManager(NADIOJEHPLA MPEBEBMNLLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5520390", Offset = "0x551ED90", VA = "0x185520390")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x551F090", Offset = "0x551DA90", VA = "0x18551F090", Slot = "23")]
		public void RequestMasterConnectNodes(LHEHFGFGCOA ANABKFNBCHO, int NIAFHAFBKPN, LHEHFGFGCOA FILEOABIGBM, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x551F1C0", Offset = "0x551DBC0", VA = "0x18551F1C0", Slot = "24")]
		public void RequestMasterDisconnectNode(LHEHFGFGCOA NPFPDEEOOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x551F290", Offset = "0x551DC90", VA = "0x18551F290", Slot = "25")]
		public void RequestMasterModifyNode(LHEHFGFGCOA CBOGNNELBNC, LHEHFGFGCOA IKDGDLOPOKG, int NIAFHAFBKPN, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x551F3C0", Offset = "0x551DDC0", VA = "0x18551F3C0", Slot = "26")]
		public void RequestMasterReparentNodes(LHEHFGFGCOA ADFMGEDLFLH, int CHLFBCEPEAJ, LHEHFGFGCOA DILGNCFGGHK, int KLOPGBAGEFI, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x551F4F0", Offset = "0x551DEF0", VA = "0x18551F4F0", Slot = "27")]
		public void RequestMasterReparentToRoot(LHEHFGFGCOA ADFMGEDLFLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x551EF60", Offset = "0x551D960", VA = "0x18551EF60", Slot = "28")]
		public void RequestDeserializeConnectableGraph(GJKMJOMCFOL PKFLOKGIIHB, [Optional] LLFLMPPMGID GCPFNNBAFDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x551F8E0", Offset = "0x551E2E0", VA = "0x18551F8E0")]
		[KMDONJPBAIA]
		private void RpcMasterConnectNodes(LHEHFGFGCOA ANABKFNBCHO, int NIAFHAFBKPN, LHEHFGFGCOA FILEOABIGBM, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x551FBB0", Offset = "0x551E5B0", VA = "0x18551FBB0")]
		[KMDONJPBAIA]
		private void RpcMasterDisconnectNode(LHEHFGFGCOA NPFPDEEOOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x551FF10", Offset = "0x551E910", VA = "0x18551FF10")]
		[KMDONJPBAIA]
		private void RpcMasterReparentNodes(LHEHFGFGCOA ADFMGEDLFLH, int CHLFBCEPEAJ, LHEHFGFGCOA DILGNCFGGHK, int KLOPGBAGEFI, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x551FD00", Offset = "0x551E700", VA = "0x18551FD00")]
		[KMDONJPBAIA]
		private void RpcMasterModifyNode(LHEHFGFGCOA CBOGNNELBNC, LHEHFGFGCOA IKDGDLOPOKG, int NIAFHAFBKPN, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x551F6C0", Offset = "0x551E0C0", VA = "0x18551F6C0")]
		[KMDONJPBAIA]
		private void RpcConnectNodes(LHEHFGFGCOA ANABKFNBCHO, int NIAFHAFBKPN, LHEHFGFGCOA FILEOABIGBM, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD, IMKANHHHNKA MKADKKLIMKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x551F850", Offset = "0x551E250", VA = "0x18551F850")]
		[KMDONJPBAIA]
		private void RpcDisconnectNode(LHEHFGFGCOA NPFPDEEOOFK, IMKANHHHNKA MKADKKLIMKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x5520280", Offset = "0x551EC80", VA = "0x185520280")]
		[KMDONJPBAIA]
		private void RpcReparentNodes(LHEHFGFGCOA ADFMGEDLFLH, int CHLFBCEPEAJ, LHEHFGFGCOA DILGNCFGGHK, int KLOPGBAGEFI, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD, IMKANHHHNKA MKADKKLIMKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x55201B0", Offset = "0x551EBB0", VA = "0x1855201B0")]
		[KMDONJPBAIA]
		private void RpcModifyNode(LHEHFGFGCOA CBOGNNELBNC, int NIAFHAFBKPN, int MJGOGEOBFGF, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD, IMKANHHHNKA MKADKKLIMKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x551F810", Offset = "0x551E210", VA = "0x18551F810")]
		[KMDONJPBAIA]
		private void RpcDeserializeConnectableGraph(GJKMJOMCFOL NFPBNLAEKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xF42A80", Offset = "0xF41480", VA = "0x180F42A80")]
		public LegacyConnectableNetworking()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IAEEFCFEDKF
{
	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x2233990", Offset = "0x2232390", VA = "0x182233990")]
	public static global::GCCOKKECIKO<T> DGNPOJLOOPI<T>(this PLIBOCMCGIC KCKJCMPILDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MLAIABPOALE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGGAFJIIBKL();

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLANNFAIKGA(bool MNIAGKNOHEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class DKEIHCIJJIJ : MLAIABPOALE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly global::NGKPAGFKBDK<bool> GJHDHFKKAMH;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5516860", Offset = "0x5515260", VA = "0x185516860")]
	public DKEIHCIJJIJ(FDIIBGLOKCI CGFEOLDGFLJ, string AJPNMLHDHNM, bool OGDNNKNPNAO, LFKEJHLOGBH EEBKDHOGOFA, [Optional] Action JOIALDGLEAK, [Optional] GKOOIJHBDIH KMFOPPKHBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x5516790", Offset = "0x5515190", VA = "0x185516790", Slot = "4")]
	public bool AGGAFJIIBKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x5516800", Offset = "0x5515200", VA = "0x185516800", Slot = "5")]
	public void NLANNFAIKGA(bool MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x55167E0", Offset = "0x55151E0", VA = "0x1855167E0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class KIHJLBBFMBA
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public const string DPHHBCJOGNG = "The connectable subgraph being deserialized is corrupt.";

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public const string KFIHMGOHLEI = "The connectable subgraph failed to deserialize, even though it passed the corruption check.";
}
namespace RRAssemblyIndex.RecRoom.Connectables.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Preserve]
	internal class _RRAssemblyIndex : NMOBLBLJIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x552F6E0", Offset = "0x552E0E0", VA = "0x18552F6E0", Slot = "6")]
		public sealed override void EPCHFMECFAE(HCFBHIJDBLF JOIALDGLEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x552F680", Offset = "0x552E080", VA = "0x18552F680", Slot = "4")]
		public sealed override void DBHAPDCLOEH()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x551E920", Offset = "0x551D320", VA = "0x18551E920")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x551E5D0", Offset = "0x551CFD0", VA = "0x18551E5D0")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
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
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
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
