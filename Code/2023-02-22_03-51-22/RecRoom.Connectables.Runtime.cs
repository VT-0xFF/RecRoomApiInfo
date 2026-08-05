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
public class LAGJGMHECOA : LDEDCBPMKCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Transform LJLOGOIJMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private GJLAMBHCAMH GOFJMPLGLAA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x38F1EB0", Offset = "0x38F10B0", VA = "0x1838F1EB0", Slot = "4")]
	public void BNACPANAOEJ(Transform LJLOGOIJMEM, GJLAMBHCAMH GOFJMPLGLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x556A9E0", Offset = "0x5569BE0", VA = "0x18556A9E0", Slot = "5")]
	public GJLAMBHCAMH JBNONCCLHCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public LAGJGMHECOA()
	{
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[MBALNPKLAGP(FOFKCKDBIPD.Connectables)]
	public sealed class OMConnectableManager : BENCAKADNKJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class PJNFOLLKDBB : IEnumerable<KCDMGONMFHO>, IEnumerable, IEnumerator<KCDMGONMFHO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private KCDMGONMFHO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private NFJEDPPAJMK localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public NFJEDPPAJMK <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public OMConnectableManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private NPFNHEGAPFJ <objects>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private KAANBEDLICJ.GNCBJOAJNHN <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private KCDMGONMFHO System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A90", Offset = "0x8A5C90", VA = "0x1808A6A90")]
			[DebuggerHidden]
			public PJNFOLLKDBB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x5577300", Offset = "0x5576500", VA = "0x185577300", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5576EE0", Offset = "0x55760E0", VA = "0x185576EE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x5577360", Offset = "0x5576560", VA = "0x185577360")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x55772C0", Offset = "0x55764C0", VA = "0x1855772C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5577210", Offset = "0x5576410", VA = "0x185577210", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KCDMGONMFHO> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5577210", Offset = "0x5576410", VA = "0x185577210", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly FADHLPPNOEF OAHDLJGMDKH;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly FADHLPPNOEF PONFPOEJHJD;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly FADHLPPNOEF MHMLNKCNMJE;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly FADHLPPNOEF KPOBELPDLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private KGOCHOHEAHM GFECAPKCLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private DJCLCEOJBJF FPAHGFEONEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private JLPDPLLCAKE FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private PEJNHEGAEGK AOCCCIOCKJL;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const int LKCOAEFNGDO = 0;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const int NPDALJINFHP = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MMAHKENHAHO KOKEGENGCAH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool ACLLOIKFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1074960", Offset = "0x1073B60", VA = "0x181074960", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x12D2ED0", Offset = "0x12D20D0", VA = "0x1812D2ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<KCDMGONMFHO, KCDMGONMFHO> GFKLHDGNJHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5572610", Offset = "0x5571810", VA = "0x185572610", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5571D00", Offset = "0x5570F00", VA = "0x185571D00", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<KCDMGONMFHO, KCDMGONMFHO> DHDLEAOLJID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x556FEE0", Offset = "0x556F0E0", VA = "0x18556FEE0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x556E530", Offset = "0x556D730", VA = "0x18556E530", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<KCDMGONMFHO, KCDMGONMFHO, KCDMGONMFHO> CDPPAEGLNJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x556EAB0", Offset = "0x556DCB0", VA = "0x18556EAB0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5570F00", Offset = "0x5570100", VA = "0x185570F00", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5572CF0", Offset = "0x5571EF0", VA = "0x185572CF0")]
		public OMConnectableManager(LECENBDGBAK LNELKNMCOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x556E5D0", Offset = "0x556D7D0", VA = "0x18556E5D0", Slot = "11")]
		public void BNACPANAOEJ(GameObject OOKBNBHDPPG, CIAMMKENILG ICPFGFCEIAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x556F900", Offset = "0x556EB00", VA = "0x18556F900", Slot = "26")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x555C010", Offset = "0x555B210", VA = "0x18555C010", Slot = "22")]
		public bool JFINCNNJAHO(MMMPFILOJAL CHHHJJOHKAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5572310", Offset = "0x5571510", VA = "0x185572310")]
		private void NLKABAFNKGA(NFJEDPPAJMK HOBBJEBJDAL, NFJEDPPAJMK OIEPABNELMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x55726B0", Offset = "0x55718B0", VA = "0x1855726B0")]
		private void NMDMLHMPIDN(NFJEDPPAJMK HOBBJEBJDAL, NFJEDPPAJMK IHHEONLAJNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x556FFE0", Offset = "0x556F1E0", VA = "0x18556FFE0")]
		private void HDDHBKAOPIM(NFJEDPPAJMK HOBBJEBJDAL, NFJEDPPAJMK IHHEONLAJNE, NFJEDPPAJMK OIEPABNELMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x556D980", Offset = "0x556CB80", VA = "0x18556D980")]
		private void AGBOKHIKJEH(NFJEDPPAJMK HOBBJEBJDAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "12")]
		public void KJAIMLDDOOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5571270", Offset = "0x5570470", VA = "0x185571270", Slot = "13")]
		public void KJDPCLCGNLB(KCDMGONMFHO DIFJCEEAAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5570B00", Offset = "0x556FD00", VA = "0x185570B00", Slot = "14")]
		public void JHPDLJNMECO(KCDMGONMFHO DIFJCEEAAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5571F80", Offset = "0x5571180", VA = "0x185571F80", Slot = "16")]
		public void NIGGGGOODMC(KCDMGONMFHO DIFJCEEAAOE, KCDMGONMFHO KMMHBIEKIAF, Vector3 HHJBJKMLAEE, Quaternion LLGKGFNMLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5571DA0", Offset = "0x5570FA0", VA = "0x185571DA0")]
		public void NIGGGGOODMC(NFJEDPPAJMK LKJGCNCCCDD, NFJEDPPAJMK KMMHBIEKIAF, Vector3 HHJBJKMLAEE, Quaternion LLGKGFNMLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x556EF00", Offset = "0x556E100", VA = "0x18556EF00", Slot = "17")]
		public void CFKDOCHAMNL(KCDMGONMFHO DGLMCOLLEFF, int BMOFKACNCFG, KCDMGONMFHO BGFPGNBPJJK, int CFAGOIELGCC, Vector3 HHJBJKMLAEE, Quaternion LLGKGFNMLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x556EE90", Offset = "0x556E090", VA = "0x18556EE90")]
		public void CFKDOCHAMNL(NFJEDPPAJMK LKJGCNCCCDD, NFJEDPPAJMK GPFONCECPBK, Vector3 HHJBJKMLAEE, Quaternion LLGKGFNMLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x55729C0", Offset = "0x5571BC0", VA = "0x1855729C0", Slot = "18")]
		public void PBOBDLAADAH(KCDMGONMFHO DIFJCEEAAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x556EB50", Offset = "0x556DD50", VA = "0x18556EB50", Slot = "19")]
		public bool CFBCMKLGOPM(KCDMGONMFHO DIFJCEEAAOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x556EC40", Offset = "0x556DE40", VA = "0x18556EC40")]
		public bool CFBCMKLGOPM(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5570FA0", Offset = "0x55701A0", VA = "0x185570FA0", Slot = "15")]
		public void KHEGLICJGCO(KCDMGONMFHO DIFJCEEAAOE, HashSet<KCDMGONMFHO> EEPGLOOMLHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "20")]
		public AEKAGMOPCFN PBEFMECFECB(bool IMIHPOHJHML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "21")]
		public AEKAGMOPCFN DBMLFGLKIJD(HashSet<Guid> MPMPECPKJPH, bool IMIHPOHJHML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5570490", Offset = "0x556F690", VA = "0x185570490", Slot = "23")]
		public void IFEABHMEHHC(AEKAGMOPCFN CCLEFJGBMLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5571900", Offset = "0x5570B00", VA = "0x185571900", Slot = "24")]
		public void NADBEFILHFG(AEKAGMOPCFN CCLEFJGBMLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x55718E0", Offset = "0x5570AE0", VA = "0x1855718E0", Slot = "25")]
		public void MOCIAACFFIH(AEKAGMOPCFN CCLEFJGBMLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5571970", Offset = "0x5570B70", VA = "0x185571970")]
		private void NCNLCNOGOIJ(NFJEDPPAJMK LKJGCNCCCDD, NFJEDPPAJMK GPFONCECPBK, Vector3 HHJBJKMLAEE, Quaternion LLGKGFNMLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x556E000", Offset = "0x556D200", VA = "0x18556E000")]
		private void AIOOCPCBCFL(NFJEDPPAJMK LKJGCNCCCDD, NFJEDPPAJMK DPPABCPODHG, Vector3 HHJBJKMLAEE, Quaternion LLGKGFNMLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x556DF30", Offset = "0x556D130", VA = "0x18556DF30")]
		private void AHNHLDHBFKP(NFJEDPPAJMK LKJGCNCCCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x556EA20", Offset = "0x556DC20", VA = "0x18556EA20")]
		[IteratorStateMachine(typeof(PJNFOLLKDBB))]
		public IEnumerable<KCDMGONMFHO> BOGMJOMIMOM(NFJEDPPAJMK OOGHONKGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x556FE60", Offset = "0x556F060", VA = "0x18556FE60")]
		internal KCDMGONMFHO FMFEKHOAIGE(NFJEDPPAJMK OOGHONKGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x55703A0", Offset = "0x556F5A0", VA = "0x1855703A0")]
		internal NFJEDPPAJMK HELPAPLNDJP(KCDMGONMFHO DIFJCEEAAOE)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x556F2D0", Offset = "0x556E4D0", VA = "0x18556F2D0")]
		private bool DOIOMGDIFJH(MMMPFILOJAL CHHHJJOHKAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x55722B0", Offset = "0x55714B0", VA = "0x1855722B0")]
		private bool NKOHPLNJLNH(MMMPFILOJAL CHHHJJOHKAH, out KCDMGONMFHO GPFONCECPBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x556FB00", Offset = "0x556ED00", VA = "0x18556FB00")]
		private KCDMGONMFHO FMFEKHOAIGE(MMMPFILOJAL CHHHJJOHKAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5571740", Offset = "0x5570940", VA = "0x185571740")]
		private KCDMGONMFHO MNGHNDHDGAF(MMMPFILOJAL CHHHJJOHKAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5570500", Offset = "0x556F700", VA = "0x185570500")]
		private KCDMGONMFHO IKAKBCOKOKH(MMMPFILOJAL CHHHJJOHKAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5565160", Offset = "0x5564360", VA = "0x185565160")]
		private static Guid AIPCCLBPJEP(MMMPFILOJAL CHHHJJOHKAH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x55721D0", Offset = "0x55713D0", VA = "0x1855721D0")]
		private string NKDNGEDDACN(MMMPFILOJAL CHHHJJOHKAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x55715B0", Offset = "0x55707B0", VA = "0x1855715B0")]
		private void LNBICKFIDEC(KCDMGONMFHO LKJGCNCCCDD, KCDMGONMFHO DPPABCPODHG, RigidTransform NDENFHFCEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5570690", Offset = "0x556F890", VA = "0x185570690")]
		private void ILDOCFLFEDG(KCDMGONMFHO DPPABCPODHG, KCDMGONMFHO LKJGCNCCCDD, RigidTransform NDENFHFCEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x556FF80", Offset = "0x556F180", VA = "0x18556FF80")]
		private void HADMBPPMNAD(KCDMGONMFHO CIPDAEPIOJL, KCDMGONMFHO LKJGCNCCCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x556F140", Offset = "0x556E340", VA = "0x18556F140")]
		private void DOEMDHKABHM(KCDMGONMFHO LKJGCNCCCDD, KCDMGONMFHO GPFONCECPBK, RigidTransform NDENFHFCEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5570820", Offset = "0x556FA20", VA = "0x185570820")]
		private void JCGEFHMFCLM(NFJEDPPAJMK OOGHONKGHEE, KCDMGONMFHO DIFJCEEAAOE, NFJEDPPAJMK IHHEONLAJNE, NFJEDPPAJMK OIEPABNELMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5570BE0", Offset = "0x556FDE0", VA = "0x185570BE0")]
		private void JPJKEGKLBFI(NFJEDPPAJMK OOGHONKGHEE, KCDMGONMFHO DIFJCEEAAOE, KCDMGONMFHO MDFEJCPBJME, KCDMGONMFHO KPJMALENPJM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JEPDMCOEFNN
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class EDDPALHGKFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public LECENBDGBAK container;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public EDDPALHGKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x555ED90", Offset = "0x555DF90", VA = "0x18555ED90")]
		internal OMConnectableManager <BindServices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x556A810", Offset = "0x5569A10", VA = "0x18556A810")]
	public static void NMJGKPKNMJC(LECENBDGBAK LNELKNMCOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x556A7A0", Offset = "0x55699A0", VA = "0x18556A7A0")]
	public static void ELBKKALMMIE(LECENBDGBAK LNELKNMCOEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class IBIEIDLFLHD : PGPDKIPNNIK, BANOAFJGLNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly RigidbodyEx LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly OMConnectableManager IKJOKIKEJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly FPAAGDKOCAD NPOOBDDDPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly AOENJMNMMJM FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly EDGOENOAGKD[] HFAEIOLCJGC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NFJEDPPAJMK KPJMLJDCDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x11A4660", Offset = "0x11A3860", VA = "0x1811A4660", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(NFJEDPPAJMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KCDMGONMFHO PHPKJJJGKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KCDMGONMFHO BGHNDKBOEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x556A1B0", Offset = "0x55693B0", VA = "0x18556A1B0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KCDMGONMFHO LBDHAGFOPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5568900", Offset = "0x5567B00", VA = "0x185568900", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 IBAEODLPFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5568510", Offset = "0x5567710", VA = "0x185568510", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Quaternion LFBDPHLCJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5569700", Offset = "0x5568900", VA = "0x185569700", Slot = "16")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool FKNDAADKGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x55688E0", Offset = "0x5567AE0", VA = "0x1855688E0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IEnumerable<KCDMGONMFHO> LMMJBJAKIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5568AB0", Offset = "0x5567CB0", VA = "0x185568AB0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Obsolete]
	public bool OICIGFEHMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1074960", Offset = "0x1073B60", VA = "0x181074960", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x12D2ED0", Offset = "0x12D20D0", VA = "0x1812D2ED0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Transform LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x556A3D0", Offset = "0x55695D0", VA = "0x18556A3D0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GameObject MNGKPNJJMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x556A140", Offset = "0x5569340", VA = "0x18556A140", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string COEOOBLBHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x556A160", Offset = "0x5569360", VA = "0x18556A160", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid GINEDABHDBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x556A2A0", Offset = "0x55694A0", VA = "0x18556A2A0", Slot = "37")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int AEPEDGHFCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x556A380", Offset = "0x5569580", VA = "0x18556A380", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool KNIFOHIDMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private bool MNIPOMAFJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5568890", Offset = "0x5567A90", VA = "0x185568890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event LGIPLCEJBKB LBACCAIBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5568720", Offset = "0x5567920", VA = "0x185568720", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5568D60", Offset = "0x5567F60", VA = "0x185568D60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event LGIPLCEJBKB OFFPPENCCCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x55685B0", Offset = "0x55677B0", VA = "0x1855685B0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5569610", Offset = "0x5568810", VA = "0x185569610", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event LGIPLCEJBKB JPOGBGPCKAO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x55695C0", Offset = "0x55687C0", VA = "0x1855695C0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5569820", Offset = "0x5568A20", VA = "0x185569820", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event ILALHGFHKIG FNNOCPMCPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x55687F0", Offset = "0x55679F0", VA = "0x1855687F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5569660", Offset = "0x5568860", VA = "0x185569660", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x556A060", Offset = "0x5569260", VA = "0x18556A060")]
	public IBIEIDLFLHD(NFJEDPPAJMK ONBAMHPEIDG, RigidbodyEx LDDCANHDBNB, FPAAGDKOCAD NPOOBDDDPOM, EDGOENOAGKD[] HFAEIOLCJGC, AOENJMNMMJM FGFPMOHFMOM, BENCAKADNKJ IKJOKIKEJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5568580", Offset = "0x5567780", VA = "0x185568580", Slot = "20")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "22")]
	public void BIHPBJMOKOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5568F50", Offset = "0x5568150", VA = "0x185568F50", Slot = "23")]
	public void IPPCPGGOGBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5569870", Offset = "0x5568A70", VA = "0x185569870", Slot = "21")]
	public void MKFHLJKEIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5569050", Offset = "0x5568250", VA = "0x185569050", Slot = "26")]
	public void JBIKPMDELLN(int PMODLFEGNFO, KCDMGONMFHO BGFPGNBPJJK, int EANACMHOFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5568770", Offset = "0x5567970", VA = "0x185568770", Slot = "27")]
	public void EMHIBEECMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5569D20", Offset = "0x5568F20", VA = "0x185569D20", Slot = "28")]
	public void PKMJKKHMPEB(int PMODLFEGNFO, KCDMGONMFHO DGLMCOLLEFF, int NKOFEDAIKLP, [Optional] Vector3? KMMGHCOAKBG, [Optional] Quaternion? KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5568600", Offset = "0x5567800", VA = "0x185568600", Slot = "29")]
	public void CPDLCOHAMFC(KCDMGONMFHO DGLMCOLLEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5569920", Offset = "0x5568B20", VA = "0x185569920", Slot = "32")]
	public void PBAANCHAMHK(Vector3 MMJDMILDEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x55692A0", Offset = "0x55684A0", VA = "0x1855692A0", Slot = "30")]
	public void JCOPJGAHCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5568DB0", Offset = "0x5567FB0", VA = "0x185568DB0", Slot = "31")]
	public void HKLJKJENPJA(int BELCAJFDAHD, Vector3 CLGJADBGBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5568C90", Offset = "0x5567E90", VA = "0x185568C90", Slot = "42")]
	public Vector3 GetConnectionSlotPosition(int PMODLFEGNFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5568B50", Offset = "0x5567D50", VA = "0x185568B50", Slot = "41")]
	public Vector3 GetConnectionSlotLocalPosition(int PMODLFEGNFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1411B60", Offset = "0x1410D60", VA = "0x181411B60", Slot = "43")]
	public Color GetConnectionSlotColor(int PMODLFEGNFO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5568680", Offset = "0x5567880", VA = "0x185568680", Slot = "44")]
	public bool CanConnectTo(int PMODLFEGNFO, KCDMGONMFHO NDNAIHBLOGK, int ACHABJHCHEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "45")]
	public void ParentChanged(int PMODLFEGNFO, KCDMGONMFHO GFGFCKNJBKB, int IMMIOIJJNCD, Vector3 EHGOCBIOEID, Quaternion PGPLHDDCOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "46")]
	public void ChildAdded(int PMODLFEGNFO, KCDMGONMFHO AEALPFHEJEC, int FFOGBGHPCLP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "47")]
	public void ChildRemoved(int PMODLFEGNFO, KCDMGONMFHO HBGGMMIAMIP, int NFNIBAEHLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "48")]
	public void ConnectionModified(int PMODLFEGNFO, KCDMGONMFHO BGFPGNBPJJK, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x556A040", Offset = "0x5569240", VA = "0x18556A040", Slot = "49")]
	public void RootChanged(KCDMGONMFHO APDFEOMGDFH, KCDMGONMFHO LNOPMEOFKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5569770", Offset = "0x5568970", VA = "0x185569770")]
	public bool MHAKOGLEHCF(KCDMGONMFHO IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x55698C0", Offset = "0x5568AC0", VA = "0x1855698C0", Slot = "24")]
	public void PAKGJIFJAAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x55689F0", Offset = "0x5567BF0", VA = "0x1855689F0", Slot = "25")]
	public void FGDKOKHMGEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5569560", Offset = "0x5568760", VA = "0x185569560")]
	private void JDCIOHHAIMF(bool BELMEEDKOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5568A50", Offset = "0x5567C50", VA = "0x185568A50")]
	private RigidbodyEx GFILHLHMIIA(KCDMGONMFHO NPOOBDDDPOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[LOJIIDJFKAI(typeof(FAJMNCCNMML), new string[] { })]
public class MNBNBFFHMDA : FAJMNCCNMML, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[IMNMHIBEIDL]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public object DADNBCFAMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x556D120", Offset = "0x556C320", VA = "0x18556D120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x556D1C0", Offset = "0x556C3C0", VA = "0x18556D1C0", Slot = "6")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x556D040", Offset = "0x556C240", VA = "0x18556D040", Slot = "5")]
	public void LAHLCHELKFI(KAANBEDLICJ LMPNJECPIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public MNBNBFFHMDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[LOJIIDJFKAI(typeof(BENCAKADNKJ), new string[] { "Ignore", "Mock" })]
public class HEDJFLLBMLD : BENCAKADNKJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool ACLLOIKFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<KCDMGONMFHO, KCDMGONMFHO> GFKLHDGNJHH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5568470", Offset = "0x5567670", VA = "0x185568470", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x55683D0", Offset = "0x55675D0", VA = "0x1855683D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<KCDMGONMFHO, KCDMGONMFHO> DHDLEAOLJID
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5568290", Offset = "0x5567490", VA = "0x185568290", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5568150", Offset = "0x5567350", VA = "0x185568150", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<KCDMGONMFHO, KCDMGONMFHO, KCDMGONMFHO> CDPPAEGLNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x55681F0", Offset = "0x55673F0", VA = "0x1855681F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5568330", Offset = "0x5567530", VA = "0x185568330", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "11")]
	public void BNACPANAOEJ(GameObject OOKBNBHDPPG, CIAMMKENILG ICPFGFCEIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "12")]
	public void KJAIMLDDOOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "13")]
	public void KJDPCLCGNLB(KCDMGONMFHO DIFJCEEAAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "14")]
	public void JHPDLJNMECO(KCDMGONMFHO DIFJCEEAAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "15")]
	public void KHEGLICJGCO(KCDMGONMFHO DIFJCEEAAOE, HashSet<KCDMGONMFHO> EEPGLOOMLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "16")]
	public void NIGGGGOODMC(KCDMGONMFHO DIFJCEEAAOE, KCDMGONMFHO KMMHBIEKIAF, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "17")]
	public void CFKDOCHAMNL(KCDMGONMFHO DIFJCEEAAOE, int OOIBADOIHJD, KCDMGONMFHO DPPABCPODHG, int IMMIOIJJNCD, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "18")]
	public void PBOBDLAADAH(KCDMGONMFHO DIFJCEEAAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "19")]
	public bool CFBCMKLGOPM(KCDMGONMFHO DIFJCEEAAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "20")]
	public AEKAGMOPCFN PBEFMECFECB(bool IMIHPOHJHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "21")]
	public AEKAGMOPCFN DBMLFGLKIJD(HashSet<Guid> MPMPECPKJPH, bool IMIHPOHJHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "22")]
	public bool JFINCNNJAHO(MMMPFILOJAL CHHHJJOHKAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "23")]
	public void IFEABHMEHHC(AEKAGMOPCFN CCLEFJGBMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "24")]
	public void NADBEFILHFG(AEKAGMOPCFN CCLEFJGBMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "25")]
	public void MOCIAACFFIH(AEKAGMOPCFN CCLEFJGBMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public HEDJFLLBMLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BJNELEIFBJG : BLAPAOLEOFC, GJLAMBHCAMH, IDisposable
{
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ConnectableLinkVisual : MonoBehaviour, BJNELEIFBJG, BLAPAOLEOFC, GJLAMBHCAMH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Entity MOGIDIJEPIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Entity AOAMDLBGHMH;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Entity EEKGMPKJENP
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120", Slot = "20")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x9F3000", Offset = "0x9F2200", VA = "0x1809F3000", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Entity HDOGIMOAGDP
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0", Slot = "11")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xEACBD0", Offset = "0xEABDD0", VA = "0x180EACBD0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x555D7D0", Offset = "0x555C9D0", VA = "0x18555D7D0", Slot = "4")]
		private void HGCLELEOGLD(KCDMGONMFHO BGFPGNBPJJK, OENOHHCNKCE LKJGCNCCCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x555D490", Offset = "0x555C690", VA = "0x18555D490", Slot = "5")]
		private void FNMBJBAICID(KCDMGONMFHO BGFPGNBPJJK, OENOHHCNKCE LKJGCNCCCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x555D910", Offset = "0x555CB10", VA = "0x18555D910", Slot = "6")]
		private void IOMPDJGOEHH(KCDMGONMFHO BGFPGNBPJJK, OENOHHCNKCE LKJGCNCCCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x555DB00", Offset = "0x555CD00", VA = "0x18555DB00", Slot = "7")]
		private void JPEDNNJPBMG(KCDMGONMFHO BGFPGNBPJJK, OENOHHCNKCE LKJGCNCCCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x555D890", Offset = "0x555CA90", VA = "0x18555D890", Slot = "8")]
		private BLAPAOLEOFC IEMDBBFMLKK(Transform LJLOGOIJMEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x555DCD0", Offset = "0x555CED0", VA = "0x18555DCD0", Slot = "9")]
		private void KFBNLFOBJBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x555D740", Offset = "0x555C940", VA = "0x18555D740")]
		private void HDECKBNAIGA(ref Entity OAOGLFGGBPI, Entity JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x555D2F0", Offset = "0x555C4F0", VA = "0x18555D2F0", Slot = "14")]
		private void EECJCBAJLCJ(float3 CLGJADBGBKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x555D280", Offset = "0x555C480", VA = "0x18555D280", Slot = "13")]
		private void BKPLELIMCBA(float3 CLGJADBGBKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x555D3C0", Offset = "0x555C5C0", VA = "0x18555D3C0", Slot = "15")]
		private void EOPAKENHPDM(out float3 IDCHKLCNMBN, out float3 HEGLMOCOEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x555DD30", Offset = "0x555CF30", VA = "0x18555DD30", Slot = "16")]
		private void MFOCIFJPMMJ(float3 IDCHKLCNMBN, float3 HEGLMOCOEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x555D360", Offset = "0x555C560", VA = "0x18555D360", Slot = "17")]
		private void EMIELLEPHIG(Color IDCHKLCNMBN, Color HEGLMOCOEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x555D750", Offset = "0x555C950", VA = "0x18555D750", Slot = "18")]
		private GJLAMBHCAMH HDICOLMHECP(Transform LJLOGOIJMEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x555DE00", Offset = "0x555D000", VA = "0x18555DE00", Slot = "19")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public ConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KCDMGONMFHO : BANOAFJGLNJ, IEquatable<KCDMGONMFHO>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BANOAFJGLNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	KCDMGONMFHO BGHNDKBOEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject MNGKPNJJMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string COEOOBLBHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid GINEDABHDBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int AEPEDGHFCKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NFJEDPPAJMK KPJMLJDCDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KNIFOHIDMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int PMODLFEGNFO);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int PMODLFEGNFO);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int PMODLFEGNFO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int PMODLFEGNFO, KCDMGONMFHO NDNAIHBLOGK, int OLCDHKBIEPF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int PMODLFEGNFO, KCDMGONMFHO GFGFCKNJBKB, int IMMIOIJJNCD, Vector3 EHGOCBIOEID, Quaternion PGPLHDDCOOD);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int PMODLFEGNFO, KCDMGONMFHO AEALPFHEJEC, int FFOGBGHPCLP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int PMODLFEGNFO, KCDMGONMFHO HBGGMMIAMIP, int NFNIBAEHLPK);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int PMODLFEGNFO, KCDMGONMFHO BGFPGNBPJJK, int LFNOFOBEPJF, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(KCDMGONMFHO APDFEOMGDFH, KCDMGONMFHO LNOPMEOFKAA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
public interface BENCAKADNKJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool ACLLOIKFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<KCDMGONMFHO, KCDMGONMFHO> GFKLHDGNJHH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<KCDMGONMFHO, KCDMGONMFHO> DHDLEAOLJID;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<KCDMGONMFHO, KCDMGONMFHO, KCDMGONMFHO> CDPPAEGLNJN;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BNACPANAOEJ(GameObject OOKBNBHDPPG, CIAMMKENILG ICPFGFCEIAG);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KJAIMLDDOOF();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KJDPCLCGNLB(KCDMGONMFHO DIFJCEEAAOE);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JHPDLJNMECO(KCDMGONMFHO DIFJCEEAAOE);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KHEGLICJGCO(KCDMGONMFHO DIFJCEEAAOE, HashSet<KCDMGONMFHO> EEPGLOOMLHP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NIGGGGOODMC(KCDMGONMFHO DIFJCEEAAOE, KCDMGONMFHO KMMHBIEKIAF, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CFKDOCHAMNL(KCDMGONMFHO DIFJCEEAAOE, int OOIBADOIHJD, KCDMGONMFHO DPPABCPODHG, int IMMIOIJJNCD, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PBOBDLAADAH(KCDMGONMFHO DIFJCEEAAOE);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CFBCMKLGOPM(KCDMGONMFHO DIFJCEEAAOE);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	AEKAGMOPCFN PBEFMECFECB(bool IMIHPOHJHML);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	AEKAGMOPCFN DBMLFGLKIJD(HashSet<Guid> MPMPECPKJPH, bool IMIHPOHJHML);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool JFINCNNJAHO(MMMPFILOJAL CHHHJJOHKAH);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IFEABHMEHHC(AEKAGMOPCFN CCLEFJGBMLL);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NADBEFILHFG(AEKAGMOPCFN CCLEFJGBMLL);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MOCIAACFFIH(AEKAGMOPCFN CCLEFJGBMLL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JLPDPLLCAKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GLOGKDDOBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KCDMGONMFHO IKAKBCOKOKH(int EJBPPPIJHBI);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KCDMGONMFHO MNGHNDHDGAF(Guid IODJCHDIHLI);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PIGMEDEBBOA(KCDMGONMFHO DIFJCEEAAOE, out Guid JHHPNHDNIID);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CLMKABDCCEL(KCDMGONMFHO DIFJCEEAAOE);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LCCDKDDJCLA();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GOGNEIOMNHN(KCDMGONMFHO NPOOBDDDPOM);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
public interface AOENJMNMMJM
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MNIPOMAFJMI(FPAAGDKOCAD NPOOBDDDPOM);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMKMHCBEFOJ(FPAAGDKOCAD NPOOBDDDPOM);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string KPEDCJCNFLM(FPAAGDKOCAD NPOOBDDDPOM);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid JJEAKCGBFFJ(FPAAGDKOCAD NPOOBDDDPOM);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NLDFPALDGBO(FPAAGDKOCAD NPOOBDDDPOM);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LJDHPPGFOCE(KCDMGONMFHO NPOOBDDDPOM, Action<EEKCDMCECLC> JMIGOLBAHDF);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PEANMLBNGOB(KCDMGONMFHO NPOOBDDDPOM, Action<EEKCDMCECLC> JMIGOLBAHDF);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IDHMGBOPDAL(FPAAGDKOCAD NPOOBDDDPOM);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KPIPOKGPFCB(FPAAGDKOCAD NPOOBDDDPOM);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GOGNEIOMNHN(FPAAGDKOCAD NPOOBDDDPOM);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IDBKKNHMJCA(FPAAGDKOCAD NPOOBDDDPOM, object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BPLEOILKCFF(FPAAGDKOCAD NPOOBDDDPOM, object AJDBKDIMOHA);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	RigidbodyEx GFILHLHMIIA(KCDMGONMFHO NPOOBDDDPOM);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LOFCLOJEBNB IDCADEOLMLH(FPAAGDKOCAD MAFDHEKFLMG, string EBOEHIFNNLM, bool EOBGHKICABG, NPFLPICFNOH BBBEPKHMHPD, Action IGAMPECHIKO);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BOPPCBDKGMH(PGPDKIPNNIK AKHLNFMNBKL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void LGIPLCEJBKB(KCDMGONMFHO DGLMCOLLEFF, int JPAKHFMGIOE, KCDMGONMFHO BGFPGNBPJJK, int IGJLOAJOCIF, [Optional] Vector3? KMMGHCOAKBG, [Optional] Quaternion? KEGLNCHNEIP);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void ILALHGFHKIG(KCDMGONMFHO APDFEOMGDFH, KCDMGONMFHO LNOPMEOFKAA);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool ABONDGFEGMF(int PMODLFEGNFO, KCDMGONMFHO NDNAIHBLOGK, int ACHABJHCHEI);
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FPAAGDKOCAD : KCDMGONMFHO, BANOAFJGLNJ, IEquatable<KCDMGONMFHO>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	PGPDKIPNNIK AJDCHLHALFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PGPDKIPNNIK : BANOAFJGLNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KCDMGONMFHO PHPKJJJGKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	KCDMGONMFHO LBDHAGFOPPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	IEnumerable<KCDMGONMFHO> LMMJBJAKIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Vector3 IBAEODLPFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	Quaternion LFBDPHLCJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool FKNDAADKGKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool OICIGFEHMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event LGIPLCEJBKB LBACCAIBCPK;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event LGIPLCEJBKB OFFPPENCCCD;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event LGIPLCEJBKB JPOGBGPCKAO;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event ILALHGFHKIG FNNOCPMCPNA;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BKOELLNKDDF();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MKFHLJKEIIJ();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BIHPBJMOKOP();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IPPCPGGOGBJ();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PAKGJIFJAAC();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FGDKOKHMGEI();

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JBIKPMDELLN(int PMODLFEGNFO, KCDMGONMFHO BGFPGNBPJJK, int EANACMHOFGP);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EMHIBEECMAP();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PKMJKKHMPEB(int PMODLFEGNFO, KCDMGONMFHO DGLMCOLLEFF, int NKOFEDAIKLP, [Optional] Vector3? KMMGHCOAKBG, [Optional] Quaternion? KEGLNCHNEIP);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CPDLCOHAMFC(KCDMGONMFHO DGLMCOLLEFF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JCOPJGAHCEJ();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HKLJKJENPJA(int BELCAJFDAHD, Vector3 CLGJADBGBKK);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PBAANCHAMHK(Vector3 MMJDMILDEKL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EDGOENOAGKD
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Vector3 FOHAPEAAGAE
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
public interface CIAMMKENILG
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool ILAIIGOECFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	BJNELEIFBJG DPCJBCMKGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	BJNELEIFBJG MENNJCOCMDJ
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
	public class ConnectableConfigData : ScriptableObject, CIAMMKENILG
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
			[Cpp2IlInjected.Address(RVA = "0x6E18D0", Offset = "0x6E0AD0", VA = "0x1806E18D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public BJNELEIFBJG LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public BJNELEIFBJG ObjectModelLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x555D190", Offset = "0x555C390", VA = "0x18555D190")]
		public static ConnectableConfigData CCCJKEPCPEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x555D230", Offset = "0x555C430", VA = "0x18555D230")]
		public ConnectableConfigData(ConnectableLinkVisual PNKEDDPCLEK, bool FLHJHGIHACP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OENOHHCNKCE : IEquatable<OENOHHCNKCE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public KCDMGONMFHO DIFJCEEAAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int GJBPJNDANMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int LFNOFOBEPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Vector3 KMMGHCOAKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Quaternion KEGLNCHNEIP;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x556D710", Offset = "0x556C910", VA = "0x18556D710")]
	public OENOHHCNKCE(KCDMGONMFHO DIFJCEEAAOE, int GJBPJNDANMA, int LFNOFOBEPJF, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x556D770", Offset = "0x556C970", VA = "0x18556D770")]
	public OENOHHCNKCE(KCDMGONMFHO DIFJCEEAAOE, int GJBPJNDANMA, int LFNOFOBEPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x556D6C0", Offset = "0x556C8C0", VA = "0x18556D6C0")]
	public OENOHHCNKCE(KCDMGONMFHO DIFJCEEAAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x556D210", Offset = "0x556C410", VA = "0x18556D210", Slot = "4")]
	public bool Equals(OENOHHCNKCE IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x556D2B0", Offset = "0x556C4B0", VA = "0x18556D2B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
public class ONJLFECAFBD : GABNPBMNFPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Transform LJLOGOIJMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BLAPAOLEOFC GOFJMPLGLAA;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x38F1EB0", Offset = "0x38F10B0", VA = "0x1838F1EB0", Slot = "4")]
	public void BNACPANAOEJ(Transform LJLOGOIJMEM, BLAPAOLEOFC GOFJMPLGLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5572DB0", Offset = "0x5571FB0", VA = "0x185572DB0", Slot = "5")]
	public BLAPAOLEOFC JBNONCCLHCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5572D60", Offset = "0x5571F60", VA = "0x185572D60", Slot = "6")]
	public void AIHAHKPGPHJ(BLAPAOLEOFC HAMDANFEEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public ONJLFECAFBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal class ENJIIHMCKFG : IDisposable, AOCFDPDFOFF
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class CHDBFONCDDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public KCDMGONMFHO oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public KCDMGONMFHO newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public CHDBFONCDDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x555B230", Offset = "0x555A430", VA = "0x18555B230")]
		internal bool <NotifyRootChangedRecurse>b__0(BLMAAOBFHNH node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly DLCNGHMIFDL ACEALOLGHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private COJJEDMDKJA EDPDCLMFPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private LOMMGLEEKKD IPILJEFIHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private bool FLHJHGIHACP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public BLMAAOBFHNH MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5561380", Offset = "0x5560580", VA = "0x185561380")]
	public bool MNCHDOBJPPA(in GBJBAGGMPBM ONIBEFDCPGD, bool CJIIAPFMNDP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5562340", Offset = "0x5561540", VA = "0x185562340")]
	private bool JLIFCCIFLHO(in GBJBAGGMPBM ONIBEFDCPGD, bool CJIIAPFMNDP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x55607D0", Offset = "0x555F9D0", VA = "0x1855607D0", Slot = "8")]
	public bool EFCGNJGFCDJ(KCDMGONMFHO BFGBCAKPHKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5563970", Offset = "0x5562B70", VA = "0x185563970")]
	private bool PECEAFDLCHO(KCDMGONMFHO CDBLPKECMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5560DD0", Offset = "0x555FFD0", VA = "0x185560DD0")]
	private static bool GDDJCFEHMOI(KCDMGONMFHO CDBLPKECMDA, DLCNGHMIFDL EPEDFPBJFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x555F4E0", Offset = "0x555E6E0", VA = "0x18555F4E0")]
	private void BDONEHNIHCP(Transform KJONMGIIPFL, DLCNGHMIFDL JFAAIFJMCGF, DLCNGHMIFDL[] DJDCPEKMCMP, KCDMGONMFHO MKBEAHPMFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x55611F0", Offset = "0x55603F0", VA = "0x1855611F0")]
	private OENOHHCNKCE HJAFAEKOHNP(Transform COJBCKOPGHM, OENOHHCNKCE MELAIAAPJMF)
	{
		return default(OENOHHCNKCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5560C20", Offset = "0x555FE20", VA = "0x185560C20")]
	private static bool FKEMHIDAOLL(DLCNGHMIFDL EPEDFPBJFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x55631B0", Offset = "0x55623B0", VA = "0x1855631B0")]
	private string KPEDCJCNFLM(KCDMGONMFHO DIFJCEEAAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5563900", Offset = "0x5562B00", VA = "0x185563900")]
	private string NLDFPALDGBO(KCDMGONMFHO DIFJCEEAAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5561D00", Offset = "0x5560F00", VA = "0x185561D00")]
	private void JJNCNPBNFDK(in GBJBAGGMPBM ONIBEFDCPGD, bool PKOGEGLMCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5561B20", Offset = "0x5560D20", VA = "0x185561B20")]
	private void IPACEBCGIJK(KCDMGONMFHO LKJGCNCCCDD, bool PKOGEGLMCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5560020", Offset = "0x555F220", VA = "0x185560020")]
	private void CLJACCFFKCN(KCDMGONMFHO HHAEEKHINMK, int NKOFEDAIKLP, KCDMGONMFHO DPPABCPODHG, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP, bool PKOGEGLMCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x55613D0", Offset = "0x55605D0", VA = "0x1855613D0")]
	private void IGCICLOJHLE(KCDMGONMFHO BPJOMCBACEF, int NKOFEDAIKLP, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP, bool JMDCFKOMDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5563280", Offset = "0x5562480", VA = "0x185563280", Slot = "9")]
	public bool LFKMKLAIEPG(KCDMGONMFHO BPJOMCBACEF, int NKOFEDAIKLP, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5562AE0", Offset = "0x5561CE0", VA = "0x185562AE0")]
	private bool KGIOGGNJKFO(KCDMGONMFHO BPJOMCBACEF, int NKOFEDAIKLP, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5560C50", Offset = "0x555FE50", VA = "0x185560C50")]
	private static void FNADFBNLADB(KCDMGONMFHO BPJOMCBACEF, int NKOFEDAIKLP, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP, DLCNGHMIFDL ENIMLFFPECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5563360", Offset = "0x5562560", VA = "0x185563360")]
	private void LNBICKFIDEC(KCDMGONMFHO HHAEEKHINMK, int OOIBADOIHJD, KCDMGONMFHO DPPABCPODHG, int IMMIOIJJNCD, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x55606F0", Offset = "0x555F8F0", VA = "0x1855606F0")]
	private void ECAAMHCBOPD(DLCNGHMIFDL MCFKDIFOJAH, KCDMGONMFHO MDFEJCPBJME, KCDMGONMFHO KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5560760", Offset = "0x555F960", VA = "0x185560760")]
	private void ECAAMHCBOPD(KCDMGONMFHO DIFJCEEAAOE, KCDMGONMFHO MDFEJCPBJME, KCDMGONMFHO KPJMALENPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x55628B0", Offset = "0x5561AB0", VA = "0x1855628B0")]
	private void JPJKEGKLBFI(KCDMGONMFHO DIFJCEEAAOE, KCDMGONMFHO MDFEJCPBJME, KCDMGONMFHO KPJMALENPJM, bool KAFNOLOBCFI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x55629D0", Offset = "0x5561BD0", VA = "0x1855629D0")]
	private void JPJKEGKLBFI(DLCNGHMIFDL LBGMPPHBAAC, KCDMGONMFHO MKBEAHPMFAM, KCDMGONMFHO LNOPMEOFKAA, bool KAFNOLOBCFI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5561A10", Offset = "0x5560C10", VA = "0x185561A10")]
	private void ILDOCFLFEDG(KCDMGONMFHO LKJGCNCCCDD, int NKOFEDAIKLP, KCDMGONMFHO DPPABCPODHG, int IMMIOIJJNCD, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5561090", Offset = "0x5560290", VA = "0x185561090")]
	private void HADMBPPMNAD(BLMAAOBFHNH GPFONCECPBK, BLMAAOBFHNH AHNAENODGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5563F50", Offset = "0x5563150", VA = "0x185563F50", Slot = "13")]
	public void PLHAGHMGGDN(KCDMGONMFHO DIFJCEEAAOE, out Vector3 KMMGHCOAKBG, out Quaternion KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x555F9A0", Offset = "0x555EBA0", VA = "0x18555F9A0", Slot = "14")]
	public KCDMGONMFHO CKNGGANKJIE(KCDMGONMFHO DIFJCEEAAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5562E70", Offset = "0x5562070", VA = "0x185562E70", Slot = "15")]
	public void KHEGLICJGCO(KCDMGONMFHO DIFJCEEAAOE, HashSet<KCDMGONMFHO> OENEHJOJPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5560E80", Offset = "0x5560080", VA = "0x185560E80", Slot = "16")]
	public List<KCDMGONMFHO> GPMDMIEMJEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5560620", Offset = "0x555F820", VA = "0x185560620")]
	protected BLMAAOBFHNH CMFBFFMJLCL(BLMAAOBFHNH MCFKDIFOJAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5560A90", Offset = "0x555FC90", VA = "0x185560A90")]
	protected DLCNGHMIFDL[] EKMHCFKJDCG(DLCNGHMIFDL EPEDFPBJFCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5563480", Offset = "0x5562680", VA = "0x185563480")]
	protected bool LNFJDNBBIEB(KCDMGONMFHO DIFJCEEAAOE, out DLCNGHMIFDL MCFKDIFOJAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5562D70", Offset = "0x5561F70", VA = "0x185562D70", Slot = "17")]
	public bool KHDKBBADGNN(KCDMGONMFHO DIFJCEEAAOE, out OENOHHCNKCE JGLOBHNBJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5563890", Offset = "0x5562A90", VA = "0x185563890")]
	protected DLCNGHMIFDL MCKNLHEMGCC(OENOHHCNKCE IDKKCGPKKEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5560B30", Offset = "0x555FD30", VA = "0x185560B30", Slot = "10")]
	public bool FFAJCFFCMOE(KCDMGONMFHO HHAEEKHINMK, int OOIBADOIHJD, KCDMGONMFHO DPPABCPODHG, int IMMIOIJJNCD, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x555FAD0", Offset = "0x555ECD0", VA = "0x18555FAD0")]
	private bool CKPLHNOKCFM(KCDMGONMFHO HHAEEKHINMK, int OOIBADOIHJD, KCDMGONMFHO DPPABCPODHG, int IMMIOIJJNCD, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x55609C0", Offset = "0x555FBC0", VA = "0x1855609C0")]
	private static bool EJLNLMOJCPK(DLCNGHMIFDL ONNDNDBMIGL, OENOHHCNKCE ILHNKIMKKLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5564080", Offset = "0x5563280", VA = "0x185564080")]
	public ENJIIHMCKFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x555F910", Offset = "0x555EB10", VA = "0x18555F910", Slot = "5")]
	public void BNACPANAOEJ(BENCAKADNKJ OBOKKBNADPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x55638D0", Offset = "0x5562AD0", VA = "0x1855638D0", Slot = "19")]
	public void NBKBDELINKL(PFHCDCLFGLE IGAMPECHIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5563550", Offset = "0x5562750", VA = "0x185563550", Slot = "12")]
	public void MAANNICOLLN(Func<KCDMGONMFHO, bool> LLPBHFPDMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5563560", Offset = "0x5562760", VA = "0x185563560")]
	private void MAANNICOLLN(DLCNGHMIFDL MCFKDIFOJAH, Func<KCDMGONMFHO, bool> LLPBHFPDMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x555F4C0", Offset = "0x555E6C0", VA = "0x18555F4C0", Slot = "11")]
	public void ANNJIEHOPIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5561380", Offset = "0x5560580", VA = "0x185561380", Slot = "7")]
	private bool HLDHBPOBMID(in GBJBAGGMPBM ONIBEFDCPGD, bool CJIIAPFMNDP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Preserve]
internal class CJLBMEMIIIB : BENCAKADNKJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly LECENBDGBAK LNELKNMCOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly LOMMGLEEKKD IPILJEFIHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly MHPDEDILEAP HKIGADKLEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly HCILHMCIJHB BDFANKEHIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly AOCFDPDFOFF CCLEFJGBMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal FHNBINJNCPP FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal GFJACPEBFPL LHLIGPNBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal COJJEDMDKJA DOAJFNOLIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal bool FLHJHGIHACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool APDCLNOGLIF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool FKBBHLFHHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x116E260", Offset = "0x116D460", VA = "0x18116E260")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xE573D0", Offset = "0xE565D0", VA = "0x180E573D0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ACLLOIKFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xB79EA0", Offset = "0xB790A0", VA = "0x180B79EA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1A3E980", Offset = "0x1A3DB80", VA = "0x181A3E980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<KCDMGONMFHO, KCDMGONMFHO> GFKLHDGNJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x555CC10", Offset = "0x555BE10", VA = "0x18555CC10", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x555C860", Offset = "0x555BA60", VA = "0x18555C860", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<KCDMGONMFHO, KCDMGONMFHO> DHDLEAOLJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x555BEC0", Offset = "0x555B0C0", VA = "0x18555BEC0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x555B420", Offset = "0x555A620", VA = "0x18555B420", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<KCDMGONMFHO, KCDMGONMFHO, KCDMGONMFHO> CDPPAEGLNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x555BA60", Offset = "0x555AC60", VA = "0x18555BA60", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x555C0E0", Offset = "0x555B2E0", VA = "0x18555C0E0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x555CE50", Offset = "0x555C050", VA = "0x18555CE50")]
	public CJLBMEMIIIB(LECENBDGBAK LNELKNMCOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x555B4E0", Offset = "0x555A6E0", VA = "0x18555B4E0", Slot = "11")]
	public void BNACPANAOEJ(GameObject OOKBNBHDPPG, CIAMMKENILG ICPFGFCEIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x555BE20", Offset = "0x555B020", VA = "0x18555BE20", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x555C380", Offset = "0x555B580", VA = "0x18555C380", Slot = "12")]
	public void KJAIMLDDOOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x555C3D0", Offset = "0x555B5D0", VA = "0x18555C3D0", Slot = "13")]
	public void KJDPCLCGNLB(KCDMGONMFHO DIFJCEEAAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x555BF20", Offset = "0x555B120", VA = "0x18555BF20", Slot = "14")]
	public void JHPDLJNMECO(KCDMGONMFHO DIFJCEEAAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x555C010", Offset = "0x555B210", VA = "0x18555C010", Slot = "22")]
	public bool JFINCNNJAHO(MMMPFILOJAL CHHHJJOHKAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x555C020", Offset = "0x555B220", VA = "0x18555C020")]
	internal bool JLIFCCIFLHO(in GBJBAGGMPBM ONIBEFDCPGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x555BC50", Offset = "0x555AE50", VA = "0x18555BC50")]
	internal bool CKPLHNOKCFM(in GBJBAGGMPBM ONIBEFDCPGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x555B480", Offset = "0x555A680", VA = "0x18555B480")]
	internal bool BGAAIELONMP(in GBJBAGGMPBM ONIBEFDCPGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x555C140", Offset = "0x555B340", VA = "0x18555C140")]
	internal bool KEJBGDKEKLF(in GBJBAGGMPBM ONIBEFDCPGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x555C450", Offset = "0x555B650", VA = "0x18555C450")]
	internal void LCEEGPCIIJM(KCDMGONMFHO DIFJCEEAAOE, int CELCFDEHGAB, bool CJIIAPFMNDP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x555BF20", Offset = "0x555B120", VA = "0x18555BF20")]
	internal bool HOOFFKHFCPN(KCDMGONMFHO BNCCAIGLJMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x555B2F0", Offset = "0x555A4F0", VA = "0x18555B2F0")]
	internal bool ALONHHPLHJL(KCDMGONMFHO BPJOMCBACEF, int NKOFEDAIKLP, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x555C280", Offset = "0x555B480", VA = "0x18555C280", Slot = "15")]
	public void KHEGLICJGCO(KCDMGONMFHO DIFJCEEAAOE, HashSet<KCDMGONMFHO> EEPGLOOMLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x555C8C0", Offset = "0x555BAC0", VA = "0x18555C8C0", Slot = "16")]
	public void NIGGGGOODMC(KCDMGONMFHO BPJOMCBACEF, KCDMGONMFHO KMMHBIEKIAF, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x555C720", Offset = "0x555B920", VA = "0x18555C720")]
	public void NFOJJLAMJPL(KCDMGONMFHO DGLMCOLLEFF, int NKOFEDAIKLP, KCDMGONMFHO BGFPGNBPJJK, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x555C3F0", Offset = "0x555B5F0", VA = "0x18555C3F0")]
	public void KOILKCICGEG(KCDMGONMFHO BFGBCAKPHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x555CAD0", Offset = "0x555BCD0", VA = "0x18555CAD0")]
	public void NIGGGGOODMC(KCDMGONMFHO BPJOMCBACEF, KCDMGONMFHO KMMHBIEKIAF, int NKOFEDAIKLP, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x555BB10", Offset = "0x555AD10", VA = "0x18555BB10", Slot = "17")]
	public void CFKDOCHAMNL(KCDMGONMFHO HHAEEKHINMK, int OOIBADOIHJD, KCDMGONMFHO DPPABCPODHG, int IMMIOIJJNCD, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x555CC90", Offset = "0x555BE90", VA = "0x18555CC90", Slot = "18")]
	public void PBOBDLAADAH(KCDMGONMFHO HHAEEKHINMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x555BAC0", Offset = "0x555ACC0", VA = "0x18555BAC0", Slot = "19")]
	public bool CFBCMKLGOPM(KCDMGONMFHO DIFJCEEAAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x555BD00", Offset = "0x555AF00", VA = "0x18555BD00")]
	public void DOONNGNKBPG([Optional] EEKCDMCECLC IFIIALGHELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x555BF80", Offset = "0x555B180", VA = "0x18555BF80", Slot = "23")]
	public void IFEABHMEHHC(AEKAGMOPCFN CCLEFJGBMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x555CC70", Offset = "0x555BE70", VA = "0x18555CC70", Slot = "20")]
	public AEKAGMOPCFN PBEFMECFECB(bool IMIHPOHJHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x555BCE0", Offset = "0x555AEE0", VA = "0x18555BCE0", Slot = "21")]
	public AEKAGMOPCFN DBMLFGLKIJD(HashSet<Guid> MPMPECPKJPH, bool IMIHPOHJHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x555C630", Offset = "0x555B830", VA = "0x18555C630", Slot = "25")]
	public void MOCIAACFFIH(AEKAGMOPCFN CCLEFJGBMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x555C670", Offset = "0x555B870", VA = "0x18555C670", Slot = "24")]
	public void NADBEFILHFG(AEKAGMOPCFN CCLEFJGBMLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class LOMMGLEEKKD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly global::NKKFEABOGLC<KCDMGONMFHO, KCDMGONMFHO> GFKLHDGNJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly global::NKKFEABOGLC<KCDMGONMFHO, KCDMGONMFHO> DHDLEAOLJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly global::FKFOHAFACOF<KCDMGONMFHO, KCDMGONMFHO, KCDMGONMFHO> CDPPAEGLNJN;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x556B3C0", Offset = "0x556A5C0", VA = "0x18556B3C0")]
	public LOMMGLEEKKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	public void BNACPANAOEJ(CJLBMEMIIIB OBOKKBNADPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x556B360", Offset = "0x556A560", VA = "0x18556B360")]
	public void MCHFCFOHAIM(KCDMGONMFHO GPFONCECPBK, KCDMGONMFHO LKJGCNCCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x556B280", Offset = "0x556A480", VA = "0x18556B280")]
	public void EEGACOAJKJC(KCDMGONMFHO GPFONCECPBK, KCDMGONMFHO LKJGCNCCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x556B2E0", Offset = "0x556A4E0", VA = "0x18556B2E0")]
	public void LKDNAMJIANI(KCDMGONMFHO CIPDAEPIOJL, KCDMGONMFHO DPPABCPODHG, KCDMGONMFHO LKJGCNCCCDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class MHPDEDILEAP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private CJLBMEMIIIB OBOKKBNADPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private GFJACPEBFPL LHLIGPNBLOF;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public MHPDEDILEAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x556CC50", Offset = "0x556BE50", VA = "0x18556CC50")]
	public void BNACPANAOEJ(CJLBMEMIIIB OBOKKBNADPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x556CD90", Offset = "0x556BF90", VA = "0x18556CD90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x556CE10", Offset = "0x556C010", VA = "0x18556CE10")]
	private void NENMOMIMOBB(EEKCDMCECLC AKGNOBJJLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x556CDA0", Offset = "0x556BFA0", VA = "0x18556CDA0")]
	private void JKALGAFEDGL(EEKCDMCECLC LLNLEHGIPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x556CE30", Offset = "0x556C030", VA = "0x18556CE30")]
	public void OELCANABOOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x556CF30", Offset = "0x556C130", VA = "0x18556CF30")]
	public void POEHALCCHAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class PMDMDKHFJPC
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EGCHEPCECOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public LECENBDGBAK container;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public EGCHEPCECOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x555EE30", Offset = "0x555E030", VA = "0x18555EE30")]
		internal CJLBMEMIIIB <BindServices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5577400", Offset = "0x5576600", VA = "0x185577400")]
	public static void NMJGKPKNMJC(LECENBDGBAK LNELKNMCOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5577380", Offset = "0x5576580", VA = "0x185577380")]
	public static void ELBKKALMMIE(LECENBDGBAK LNELKNMCOEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
internal class GDAOJBCPHEP : IDisposable, COJJEDMDKJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Dictionary<int, BLAPAOLEOFC> HLBCJMJABJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly PFHCDCLFGLE KKMIPPMCOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private GABNPBMNFPD MKDNHJOBKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private AOCFDPDFOFF CCLEFJGBMLL;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5564E90", Offset = "0x5564090", VA = "0x185564E90")]
	public GDAOJBCPHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x55645A0", Offset = "0x55637A0", VA = "0x1855645A0", Slot = "7")]
	public void BNACPANAOEJ(AOCFDPDFOFF CCLEFJGBMLL, GABNPBMNFPD MKDNHJOBKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5564C50", Offset = "0x5563E50", VA = "0x185564C50", Slot = "5")]
	public void MCMPLKFLNPB(BLMAAOBFHNH KELPLEEOFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5564430", Offset = "0x5563630", VA = "0x185564430", Slot = "9")]
	public void AFGKCBMNGDD(BLMAAOBFHNH EIIBGLFLMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5564AA0", Offset = "0x5563CA0", VA = "0x185564AA0", Slot = "8")]
	public void KPMCAPONKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5564780", Offset = "0x5563980", VA = "0x185564780", Slot = "10")]
	public void JBEPDABBDCI(BLMAAOBFHNH OJFMMGAJAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5564370", Offset = "0x5563570", VA = "0x185564370", Slot = "11")]
	public void AEDJEKDDPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x55645E0", Offset = "0x55637E0", VA = "0x1855645E0")]
	private bool GIOFFOCDCIC(BLMAAOBFHNH BCFFBCFIMGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class HCILHMCIJHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal struct ACFCBDHLCMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly DLCNGHMIFDL OLAPPDHCMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly HashSet<Guid> MPMPECPKJPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly MMMPFILOJAL FJMHFKBJAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly MMMPFILOJAL CLIHIBOJPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly bool IMIHPOHJHML;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private bool FOGKKELBCJP
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x555A840", Offset = "0x5559A40", VA = "0x18555A840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x555B090", Offset = "0x555A290", VA = "0x18555B090")]
		public ACFCBDHLCMA(DLCNGHMIFDL OLAPPDHCMOI, HashSet<Guid> MPMPECPKJPH, bool IMIHPOHJHML, [Optional] MMMPFILOJAL FJMHFKBJAIG, [Optional] MMMPFILOJAL CLIHIBOJPEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x555AC70", Offset = "0x5559E70", VA = "0x18555AC70")]
		public MMMPFILOJAL LMGAKHPBOLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x555AFD0", Offset = "0x555A1D0", VA = "0x18555AFD0")]
		private MMMPFILOJAL OGMDLEJDPFM(out MMMPFILOJAL HEBGHOLNMIF, out MMMPFILOJAL PJDHHINMKBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x555ADD0", Offset = "0x5559FD0", VA = "0x18555ADD0")]
		private MMMPFILOJAL OGDAOCEOBHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x555A950", Offset = "0x5559B50", VA = "0x18555A950")]
		private void HNKCNGPHOJC(MMMPFILOJAL EJBOPNKGCPP, MMMPFILOJAL IGDJJBJJDBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x555AAD0", Offset = "0x5559CD0", VA = "0x18555AAD0")]
		private void KNFOIJEJNMC(MMMPFILOJAL HEBGHOLNMIF, MMMPFILOJAL PJDHHINMKBO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private CJLBMEMIIIB OBOKKBNADPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private AOCFDPDFOFF CCLEFJGBMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private COJJEDMDKJA EDPDCLMFPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private GFJACPEBFPL LHLIGPNBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool BBFBLKOAPFL;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool COJEFPDKOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x55651A0", Offset = "0x55643A0", VA = "0x1855651A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool FKBBHLFHHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5566850", Offset = "0x5565A50", VA = "0x185566850")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x55661D0", Offset = "0x55653D0", VA = "0x1855661D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x55651F0", Offset = "0x55643F0", VA = "0x1855651F0")]
	public void BNACPANAOEJ(CJLBMEMIIIB OBOKKBNADPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x55675D0", Offset = "0x55667D0", VA = "0x1855675D0")]
	public AEKAGMOPCFN PBEFMECFECB(bool IMIHPOHJHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5565260", Offset = "0x5564460", VA = "0x185565260")]
	public AEKAGMOPCFN DBMLFGLKIJD(HashSet<Guid> MPMPECPKJPH, bool IMIHPOHJHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5566870", Offset = "0x5565A70", VA = "0x185566870")]
	public void IFEABHMEHHC(AEKAGMOPCFN CCLEFJGBMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5567160", Offset = "0x5566360", VA = "0x185567160")]
	public void NADBEFILHFG(AEKAGMOPCFN CCLEFJGBMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5567580", Offset = "0x5566780", VA = "0x185567580")]
	public void NMAGJJMJDMJ(AEKAGMOPCFN CCLEFJGBMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5566FD0", Offset = "0x55661D0", VA = "0x185566FD0")]
	private void LNCBDJMFPIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5567F70", Offset = "0x5567170", VA = "0x185567F70")]
	private MMMPFILOJAL POMCMHGNOLC(DLCNGHMIFDL MCFKDIFOJAH, bool IMIHPOHJHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5566D50", Offset = "0x5565F50", VA = "0x185566D50")]
	private static void JGDIDFBHHKO(DLCNGHMIFDL MCFKDIFOJAH, bool IMIHPOHJHML, MMMPFILOJAL CHHHJJOHKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5564F60", Offset = "0x5564160", VA = "0x185564F60")]
	private void AHJOEHIPBIP(DLCNGHMIFDL MCFKDIFOJAH, bool IMIHPOHJHML, MMMPFILOJAL CHHHJJOHKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x55661F0", Offset = "0x55653F0", VA = "0x1855661F0")]
	private MMMPFILOJAL FGCNPEINCCH(DLCNGHMIFDL OLAPPDHCMOI, HashSet<Guid> MPMPECPKJPH, bool IMIHPOHJHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x55665D0", Offset = "0x55657D0", VA = "0x1855665D0")]
	private bool HFNGJBPGBHG(AEKAGMOPCFN HFJAAOHIEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5565A20", Offset = "0x5564C20", VA = "0x185565A20")]
	private bool DOIOMGDIFJH(MMMPFILOJAL CHHHJJOHKAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x55675B0", Offset = "0x55667B0", VA = "0x1855675B0")]
	private bool OBKCPNHDKIF(AEKAGMOPCFN CCLEFJGBMLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5566060", Offset = "0x5565260", VA = "0x185566060")]
	private static bool EHJAPNAKLBE(MMMPFILOJAL CHHHJJOHKAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5566A90", Offset = "0x5565C90", VA = "0x185566A90")]
	public static bool JFINCNNJAHO(MMMPFILOJAL CHHHJJOHKAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5566280", Offset = "0x5565480", VA = "0x185566280")]
	private KCDMGONMFHO FMFEKHOAIGE(MMMPFILOJAL CHHHJJOHKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5566900", Offset = "0x5565B00", VA = "0x185566900")]
	private KCDMGONMFHO IKAKBCOKOKH(MMMPFILOJAL CHHHJJOHKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5567DF0", Offset = "0x5566FF0", VA = "0x185567DF0")]
	private KCDMGONMFHO PLNFPJJGJGH(MMMPFILOJAL CHHHJJOHKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5565160", Offset = "0x5564360", VA = "0x185565160")]
	private static Guid AIPCCLBPJEP(MMMPFILOJAL CHHHJJOHKAH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x55674A0", Offset = "0x55666A0", VA = "0x1855674A0")]
	private string NKDNGEDDACN(MMMPFILOJAL CHHHJJOHKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5567C90", Offset = "0x5566E90", VA = "0x185567C90")]
	private bool PHAJIHGCFKO(DLCNGHMIFDL MCFKDIFOJAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5567200", Offset = "0x5566400", VA = "0x185567200")]
	private static void NAFGJHDEOGI(DLCNGHMIFDL OLAPPDHCMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public HCILHMCIJHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class PJDFHNIEAPJ : PGPDKIPNNIK, BANOAFJGLNJ
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private const string KCKIEIHLPKL = "Parented";

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private const string PHBHJDBHOCF = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GameObject OOKBNBHDPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly BENCAKADNKJ IKJOKIKEJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly FPAAGDKOCAD NPOOBDDDPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly EDGOENOAGKD[] HFAEIOLCJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly AOENJMNMMJM FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<KCDMGONMFHO> CPBDEJHBMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private LOFCLOJEBNB EBEDKIDBNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private Vector3 MDEBOMLJOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Quaternion GNIFPJBCFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private bool CFGJMACKIHF;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public KCDMGONMFHO PHPKJJJGKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public KCDMGONMFHO BGHNDKBOEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6CDD80", Offset = "0x6CCF80", VA = "0x1806CDD80", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F10", Offset = "0x8D1110", VA = "0x1808D1F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Vector3 IBAEODLPFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x55731C0", Offset = "0x55723C0", VA = "0x1855731C0", Slot = "15")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x127CB00", Offset = "0x127BD00", VA = "0x18127CB00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Quaternion LFBDPHLCJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5575520", Offset = "0x5574720", VA = "0x185575520", Slot = "16")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1C6C790", Offset = "0x1C6B990", VA = "0x181C6C790")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool GMFKCCOHIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xBB02E0", Offset = "0xBAF4E0", VA = "0x180BB02E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xBB0880", Offset = "0xBAFA80", VA = "0x180BB0880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool FKNDAADKGKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5573E80", Offset = "0x5573080", VA = "0x185573E80", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public KCDMGONMFHO LBDHAGFOPPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7036A0", Offset = "0x7028A0", VA = "0x1807036A0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8D1530", Offset = "0x8D0730", VA = "0x1808D1530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private bool MNIPOMAFJMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5573C80", Offset = "0x5572E80", VA = "0x185573C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private RigidbodyEx CJKLNOGOBGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5573160", Offset = "0x5572360", VA = "0x185573160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<KCDMGONMFHO> LMMJBJAKIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6CE570", Offset = "0x6CD770", VA = "0x1806CE570", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool OICIGFEHMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5573480", Offset = "0x5572680", VA = "0x185573480", Slot = "18")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x55739E0", Offset = "0x5572BE0", VA = "0x1855739E0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Transform LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5576EC0", Offset = "0x55760C0", VA = "0x185576EC0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public GameObject MNGKPNJJMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string COEOOBLBHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5576C30", Offset = "0x5575E30", VA = "0x185576C30", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Guid GINEDABHDBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5576D90", Offset = "0x5575F90", VA = "0x185576D90", Slot = "37")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int AEPEDGHFCKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5576E70", Offset = "0x5576070", VA = "0x185576E70", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public NFJEDPPAJMK KPJMLJDCDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5576C80", Offset = "0x5575E80", VA = "0x185576C80", Slot = "39")]
		get
		{
			return default(NFJEDPPAJMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool KNIFOHIDMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event LGIPLCEJBKB LBACCAIBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5573AA0", Offset = "0x5572CA0", VA = "0x185573AA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x5574120", Offset = "0x5573320", VA = "0x185574120", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event LGIPLCEJBKB OFFPPENCCCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x55733E0", Offset = "0x55725E0", VA = "0x1855733E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x5575370", Offset = "0x5574570", VA = "0x185575370", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event LGIPLCEJBKB JPOGBGPCKAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x5575120", Offset = "0x5574320", VA = "0x185575120", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x5575630", Offset = "0x5574830", VA = "0x185575630", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event ILALHGFHKIG FNNOCPMCPNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x5573BE0", Offset = "0x5572DE0", VA = "0x185573BE0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x5575410", Offset = "0x5574610", VA = "0x185575410", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5573EB0", Offset = "0x55730B0", VA = "0x185573EB0")]
	private RigidbodyEx GFILHLHMIIA(KCDMGONMFHO NPOOBDDDPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5576B40", Offset = "0x5575D40", VA = "0x185576B40")]
	public PJDFHNIEAPJ(GameObject OOKBNBHDPPG, FPAAGDKOCAD NPOOBDDDPOM, EDGOENOAGKD[] HFAEIOLCJGC, AOENJMNMMJM FGFPMOHFMOM, BENCAKADNKJ IKJOKIKEJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5573290", Offset = "0x5572490", VA = "0x185573290", Slot = "20")]
	public void BKOELLNKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5573230", Offset = "0x5572430", VA = "0x185573230", Slot = "22")]
	public void BIHPBJMOKOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5574360", Offset = "0x5573560", VA = "0x185574360", Slot = "23")]
	public void IPPCPGGOGBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x55756D0", Offset = "0x55748D0", VA = "0x1855756D0", Slot = "21")]
	public void MKFHLJKEIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5573CD0", Offset = "0x5572ED0", VA = "0x185573CD0")]
	private void FAJPJGHGIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x55751C0", Offset = "0x55743C0", VA = "0x1855751C0")]
	private void KNJAFADCFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5575760", Offset = "0x5574960", VA = "0x185575760", Slot = "24")]
	public void PAKGJIFJAAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5573E90", Offset = "0x5573090", VA = "0x185573E90", Slot = "25")]
	public void FGDKOKHMGEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x55743E0", Offset = "0x55735E0", VA = "0x1855743E0", Slot = "26")]
	public void JBIKPMDELLN(int PMODLFEGNFO, KCDMGONMFHO BGFPGNBPJJK, int EANACMHOFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5573B40", Offset = "0x5572D40", VA = "0x185573B40", Slot = "27")]
	public void EMHIBEECMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5575BC0", Offset = "0x5574DC0", VA = "0x185575BC0", Slot = "28")]
	public void PKMJKKHMPEB(int PMODLFEGNFO, KCDMGONMFHO DGLMCOLLEFF, int NKOFEDAIKLP, [Optional] Vector3? KMMGHCOAKBG, [Optional] Quaternion? KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x55734D0", Offset = "0x55726D0", VA = "0x1855734D0", Slot = "29")]
	public void CPDLCOHAMFC(KCDMGONMFHO DGLMCOLLEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5574D30", Offset = "0x5573F30", VA = "0x185574D30")]
	private void JODGLLHEPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x55741C0", Offset = "0x55733C0", VA = "0x1855741C0", Slot = "31")]
	public void HKLJKJENPJA(int BELCAJFDAHD, Vector3 CLGJADBGBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5575780", Offset = "0x5574980", VA = "0x185575780", Slot = "32")]
	public void PBAANCHAMHK(Vector3 MMJDMILDEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5574650", Offset = "0x5573850", VA = "0x185574650", Slot = "30")]
	public void JCOPJGAHCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5574050", Offset = "0x5573250", VA = "0x185574050", Slot = "42")]
	public Vector3 GetConnectionSlotPosition(int PMODLFEGNFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5573F10", Offset = "0x5573110", VA = "0x185573F10", Slot = "41")]
	public Vector3 GetConnectionSlotLocalPosition(int PMODLFEGNFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x1411B60", Offset = "0x1410D60", VA = "0x181411B60", Slot = "43")]
	public Color GetConnectionSlotColor(int PMODLFEGNFO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5573570", Offset = "0x5572770", VA = "0x185573570", Slot = "44")]
	public bool CanConnectTo(int PMODLFEGNFO, KCDMGONMFHO NDNAIHBLOGK, int ACHABJHCHEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5575590", Offset = "0x5574790", VA = "0x185575590")]
	public bool MHAKOGLEHCF(KCDMGONMFHO IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5575F10", Offset = "0x5575110", VA = "0x185575F10", Slot = "45")]
	public void ParentChanged(int PMODLFEGNFO, KCDMGONMFHO GFGFCKNJBKB, int IMMIOIJJNCD, Vector3 EHGOCBIOEID, Quaternion PGPLHDDCOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5573610", Offset = "0x5572810", VA = "0x185573610", Slot = "46")]
	public void ChildAdded(int PMODLFEGNFO, KCDMGONMFHO AEALPFHEJEC, int FFOGBGHPCLP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x55737C0", Offset = "0x55729C0", VA = "0x1855737C0", Slot = "47")]
	public void ChildRemoved(int PMODLFEGNFO, KCDMGONMFHO HBGGMMIAMIP, int NFNIBAEHLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5573880", Offset = "0x5572A80", VA = "0x185573880", Slot = "48")]
	public void ConnectionModified(int PMODLFEGNFO, KCDMGONMFHO BGFPGNBPJJK, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5576AE0", Offset = "0x5575CE0", VA = "0x185576AE0", Slot = "49")]
	public void RootChanged(KCDMGONMFHO APDFEOMGDFH, KCDMGONMFHO LNOPMEOFKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x55754B0", Offset = "0x55746B0", VA = "0x1855754B0")]
	private void MAICGPCMDBM(EEKCDMCECLC JMIGOLBAHDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct GBJBAGGMPBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public KCDMGONMFHO LKJGCNCCCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public KCDMGONMFHO GPFONCECPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int NKOFEDAIKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public int EANACMHOFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Vector3 KMMGHCOAKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Quaternion KEGLNCHNEIP;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public OENOHHCNKCE PCKPILGMHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x55641F0", Offset = "0x55633F0", VA = "0x1855641F0")]
		get
		{
			return default(OENOHHCNKCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public OENOHHCNKCE GKGGIADIHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5564290", Offset = "0x5563490", VA = "0x185564290")]
		get
		{
			return default(OENOHHCNKCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5564300", Offset = "0x5563500", VA = "0x185564300")]
	public GBJBAGGMPBM(KCDMGONMFHO LKJGCNCCCDD, KCDMGONMFHO GPFONCECPBK, int NKOFEDAIKLP, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface AOCFDPDFOFF
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	BLMAAOBFHNH MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNACPANAOEJ(BENCAKADNKJ OBOKKBNADPB);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MNCHDOBJPPA(in GBJBAGGMPBM ONIBEFDCPGD, bool CJIIAPFMNDP = true);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EFCGNJGFCDJ(KCDMGONMFHO BFGBCAKPHKA);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LFKMKLAIEPG(KCDMGONMFHO BPJOMCBACEF, int NKOFEDAIKLP, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FFAJCFFCMOE(KCDMGONMFHO HHAEEKHINMK, int OOIBADOIHJD, KCDMGONMFHO DPPABCPODHG, int IMMIOIJJNCD, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ANNJIEHOPIA();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MAANNICOLLN(Func<KCDMGONMFHO, bool> LLPBHFPDMHK);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PLHAGHMGGDN(KCDMGONMFHO DIFJCEEAAOE, out Vector3 KMMGHCOAKBG, out Quaternion KEGLNCHNEIP);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KCDMGONMFHO CKNGGANKJIE(KCDMGONMFHO DIFJCEEAAOE);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KHEGLICJGCO(KCDMGONMFHO DIFJCEEAAOE, HashSet<KCDMGONMFHO> OENEHJOJPPD);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "11")]
	List<KCDMGONMFHO> GPMDMIEMJEH();

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KHDKBBADGNN(KCDMGONMFHO DIFJCEEAAOE, out OENOHHCNKCE JGLOBHNBJEB);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NBKBDELINKL(PFHCDCLFGLE IGAMPECHIKO);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal delegate bool PFHCDCLFGLE(BLMAAOBFHNH MCFKDIFOJAH);
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface BLMAAOBFHNH
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	KCDMGONMFHO PHPKJJJGKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int BEOKCDIJFJF
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int JEADKLBHDPC
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Vector3 LIIFOJALKEN
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Quaternion PFNBPHBNBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	BLMAAOBFHNH EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	BLMAAOBFHNH MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	OENOHHCNKCE CNLGOCGOPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool BNMAJOKFIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool FHJHHIHKEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NBKBDELINKL(PFHCDCLFGLE IGAMPECHIKO, bool KAFNOLOBCFI = true);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "16")]
	BLMAAOBFHNH MCKNLHEMGCC(OENOHHCNKCE LBDCOIGDEMM);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BLAPAOLEOFC
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBGEMGCKMHE(KCDMGONMFHO BGFPGNBPJJK, OENOHHCNKCE LKJGCNCCCDD);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFAIOKGPMIB(KCDMGONMFHO BGFPGNBPJJK, OENOHHCNKCE LKJGCNCCCDD);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PHIPDLLKGEK(KCDMGONMFHO BGFPGNBPJJK, OENOHHCNKCE LKJGCNCCCDD);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GAEBMBOFBDA(KCDMGONMFHO BGFPGNBPJJK, OENOHHCNKCE LKJGCNCCCDD);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BLAPAOLEOFC Instantiate(Transform LJLOGOIJMEM);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACJHDFNHANL();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GABNPBMNFPD
{
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNACPANAOEJ(Transform LJLOGOIJMEM, BLAPAOLEOFC GOFJMPLGLAA);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BLAPAOLEOFC JBNONCCLHCH();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIHAHKPGPHJ(BLAPAOLEOFC HAMDANFEEHA);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface FHNBINJNCPP : JLPDPLLCAKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PNDMCEHMLLA(Guid DBPLFMJCACN);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface COJJEDMDKJA
{
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCMPLKFLNPB(BLMAAOBFHNH KELPLEEOFEF);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNACPANAOEJ(AOCFDPDFOFF CCLEFJGBMLL, GABNPBMNFPD EJGAOLFNADB);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KPMCAPONKIP();

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AFGKCBMNGDD(BLMAAOBFHNH EIIBGLFLMCB);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JBEPDABBDCI(BLMAAOBFHNH OJFMMGAJAIO);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AEDJEKDDPMM();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal class DLCNGHMIFDL : BLMAAOBFHNH
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class BBKEFNCJJPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public OENOHHCNKCE nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public DLCNGHMIFDL foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public BBKEFNCJJPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x555B100", Offset = "0x555A300", VA = "0x18555B100")]
		internal bool <FindNode>b__0(BLMAAOBFHNH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private OENOHHCNKCE JGLOBHNBJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public LinkedList<DLCNGHMIFDL> LILCAAEDFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private DLCNGHMIFDL JPNENJALODP;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public OENOHHCNKCE CNLGOCGOPKH
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFF30", VA = "0x1809F0D30", Slot = "16")]
		get
		{
			return default(OENOHHCNKCE);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x555EA20", Offset = "0x555DC20", VA = "0x18555EA20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private DLCNGHMIFDL GPFONCECPBK
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6C70D0", Offset = "0x6C62D0", VA = "0x1806C70D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x555E030", Offset = "0x555D230", VA = "0x18555E030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public BLMAAOBFHNH EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6C70D0", Offset = "0x6C62D0", VA = "0x1806C70D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public KCDMGONMFHO PHPKJJJGKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6E7130", Offset = "0x6E6330", VA = "0x1806E7130", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int BEOKCDIJFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BD0", Offset = "0x6C7DD0", VA = "0x1806C8BD0", Slot = "6")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A610", VA = "0x18076B410", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int JEADKLBHDPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6E2C90", Offset = "0x6E1E90", VA = "0x1806E2C90", Slot = "8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x76B320", Offset = "0x76A520", VA = "0x18076B320", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 LIIFOJALKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x1811F80", Offset = "0x1811180", VA = "0x181811F80", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x14BCF00", Offset = "0x14BC100", VA = "0x1814BCF00", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Quaternion PFNBPHBNBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x25E5C30", Offset = "0x25E4E30", VA = "0x1825E5C30", Slot = "12")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3F561B0", Offset = "0x3F553B0", VA = "0x183F561B0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool BNMAJOKFIOG
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x92B9B0", Offset = "0x92ABB0", VA = "0x18092B9B0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool FHJHHIHKEIG
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x555E9D0", Offset = "0x555DBD0", VA = "0x18555E9D0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	protected DLCNGHMIFDL LBGMPPHBAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x555E900", Offset = "0x555DB00", VA = "0x18555E900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public BLMAAOBFHNH MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x555E900", Offset = "0x555DB00", VA = "0x18555E900", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x555ECF0", Offset = "0x555DEF0", VA = "0x18555ECF0")]
	public DLCNGHMIFDL(OENOHHCNKCE CEIDEJHBBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x555E500", Offset = "0x555D700", VA = "0x18555E500")]
	public DLCNGHMIFDL FIMHIJJNHNG(OENOHHCNKCE OGONBENFGNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x555E780", Offset = "0x555D980", VA = "0x18555E780")]
	public DLCNGHMIFDL HDCPLEDMHEJ(OENOHHCNKCE FHOLMKFFKHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x555DE60", Offset = "0x555D060", VA = "0x18555DE60")]
	public DLCNGHMIFDL BCBAFCFKBLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x555E640", Offset = "0x555D840", VA = "0x18555E640")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x555E920", Offset = "0x555DB20", VA = "0x18555E920")]
	public DLCNGHMIFDL JDDFNHLDIKN(OENOHHCNKCE DPPABCPODHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x555EBA0", Offset = "0x555DDA0", VA = "0x18555EBA0")]
	private static void NBKBDELINKL(DLCNGHMIFDL LCCNHJFJFMK, PFHCDCLFGLE GMFDMCMDPFN, bool DOPAKKDKILN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x555EB90", Offset = "0x555DD90", VA = "0x18555EB90", Slot = "19")]
	public void NBKBDELINKL(PFHCDCLFGLE IGAMPECHIKO, bool KAFNOLOBCFI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x555E110", Offset = "0x555D310", VA = "0x18555E110")]
	public static string ENCCFGOODIM(DLCNGHMIFDL LCCNHJFJFMK, int ELMCLGINMHD = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x555EB60", Offset = "0x555DD60", VA = "0x18555EB60", Slot = "20")]
	public BLMAAOBFHNH MCKNLHEMGCC(OENOHHCNKCE LBDCOIGDEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x555EA50", Offset = "0x555DC50", VA = "0x18555EA50")]
	public static DLCNGHMIFDL MCKNLHEMGCC(DLCNGHMIFDL LCCNHJFJFMK, OENOHHCNKCE LBDCOIGDEMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface GFJACPEBFPL
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool COJEFPDKOFB
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool GLOGKDDOBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event Action<EEKCDMCECLC> NENMOMIMOBB;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event Action<EEKCDMCECLC> JKALGAFEDGL;

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(CJLBMEMIIIB OBOKKBNADPB);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterConnectNodes(KCDMGONMFHO DGLMCOLLEFF, int NKOFEDAIKLP, KCDMGONMFHO BGFPGNBPJJK, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterDisconnectNode(KCDMGONMFHO BFGBCAKPHKA);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestMasterModifyNode(KCDMGONMFHO BPJOMCBACEF, KCDMGONMFHO KMMHBIEKIAF, int NKOFEDAIKLP, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void RequestMasterReparentNodes(KCDMGONMFHO HHAEEKHINMK, int OOIBADOIHJD, KCDMGONMFHO DPPABCPODHG, int IMMIOIJJNCD, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void RequestMasterReparentToRoot(KCDMGONMFHO HHAEEKHINMK);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void RequestDeserializeConnectableGraph(AEKAGMOPCFN FOMCMJANCNG, [Optional] EEKCDMCECLC IFIIALGHELF);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, GFJACPEBFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private CJLBMEMIIIB OBOKKBNADPB;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool COJEFPDKOFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x556CA60", Offset = "0x556BC60", VA = "0x18556CA60", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool GLOGKDDOBJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x556CAC0", Offset = "0x556BCC0", VA = "0x18556CAC0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<EEKCDMCECLC> NENMOMIMOBB
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x556C9C0", Offset = "0x556BBC0", VA = "0x18556C9C0", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x556CBB0", Offset = "0x556BDB0", VA = "0x18556CBB0", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<EEKCDMCECLC> JKALGAFEDGL
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x556C920", Offset = "0x556BB20", VA = "0x18556C920", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x556CB10", Offset = "0x556BD10", VA = "0x18556CB10", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6CE5A0", Offset = "0x6CD7A0", VA = "0x1806CE5A0", Slot = "22")]
		public void SetManager(CJLBMEMIIIB OBOKKBNADPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x556C8F0", Offset = "0x556BAF0", VA = "0x18556C8F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x556B5F0", Offset = "0x556A7F0", VA = "0x18556B5F0", Slot = "23")]
		public void RequestMasterConnectNodes(KCDMGONMFHO DGLMCOLLEFF, int NKOFEDAIKLP, KCDMGONMFHO BGFPGNBPJJK, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x556B720", Offset = "0x556A920", VA = "0x18556B720", Slot = "24")]
		public void RequestMasterDisconnectNode(KCDMGONMFHO BFGBCAKPHKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x556B7F0", Offset = "0x556A9F0", VA = "0x18556B7F0", Slot = "25")]
		public void RequestMasterModifyNode(KCDMGONMFHO BPJOMCBACEF, KCDMGONMFHO KMMHBIEKIAF, int NKOFEDAIKLP, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x556B920", Offset = "0x556AB20", VA = "0x18556B920", Slot = "26")]
		public void RequestMasterReparentNodes(KCDMGONMFHO HHAEEKHINMK, int OOIBADOIHJD, KCDMGONMFHO DPPABCPODHG, int IMMIOIJJNCD, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x556BA50", Offset = "0x556AC50", VA = "0x18556BA50", Slot = "27")]
		public void RequestMasterReparentToRoot(KCDMGONMFHO HHAEEKHINMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x556B4C0", Offset = "0x556A6C0", VA = "0x18556B4C0", Slot = "28")]
		public void RequestDeserializeConnectableGraph(AEKAGMOPCFN FOMCMJANCNG, [Optional] EEKCDMCECLC IFIIALGHELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x556BE40", Offset = "0x556B040", VA = "0x18556BE40")]
		[DLFBNJPHHGN]
		private void RpcMasterConnectNodes(KCDMGONMFHO DGLMCOLLEFF, int NKOFEDAIKLP, KCDMGONMFHO BGFPGNBPJJK, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x556C110", Offset = "0x556B310", VA = "0x18556C110")]
		[DLFBNJPHHGN]
		private void RpcMasterDisconnectNode(KCDMGONMFHO BFGBCAKPHKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x556C470", Offset = "0x556B670", VA = "0x18556C470")]
		[DLFBNJPHHGN]
		private void RpcMasterReparentNodes(KCDMGONMFHO HHAEEKHINMK, int OOIBADOIHJD, KCDMGONMFHO DPPABCPODHG, int IMMIOIJJNCD, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x556C260", Offset = "0x556B460", VA = "0x18556C260")]
		[DLFBNJPHHGN]
		private void RpcMasterModifyNode(KCDMGONMFHO BPJOMCBACEF, KCDMGONMFHO KMMHBIEKIAF, int NKOFEDAIKLP, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x556BC20", Offset = "0x556AE20", VA = "0x18556BC20")]
		[DLFBNJPHHGN]
		private void RpcConnectNodes(KCDMGONMFHO DGLMCOLLEFF, int NKOFEDAIKLP, KCDMGONMFHO BGFPGNBPJJK, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP, PIMCKNFHLGG KLHDMNALKJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x556BDB0", Offset = "0x556AFB0", VA = "0x18556BDB0")]
		[DLFBNJPHHGN]
		private void RpcDisconnectNode(KCDMGONMFHO BFGBCAKPHKA, PIMCKNFHLGG KLHDMNALKJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x556C7E0", Offset = "0x556B9E0", VA = "0x18556C7E0")]
		[DLFBNJPHHGN]
		private void RpcReparentNodes(KCDMGONMFHO HHAEEKHINMK, int OOIBADOIHJD, KCDMGONMFHO DPPABCPODHG, int IMMIOIJJNCD, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP, PIMCKNFHLGG KLHDMNALKJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x556C710", Offset = "0x556B910", VA = "0x18556C710")]
		[DLFBNJPHHGN]
		private void RpcModifyNode(KCDMGONMFHO BPJOMCBACEF, int NKOFEDAIKLP, int EANACMHOFGP, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP, PIMCKNFHLGG KLHDMNALKJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x556BD70", Offset = "0x556AF70", VA = "0x18556BD70")]
		[DLFBNJPHHGN]
		private void RpcDeserializeConnectableGraph(AEKAGMOPCFN CCLEFJGBMLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xF97880", Offset = "0xF96A80", VA = "0x180F97880")]
		public LegacyConnectableNetworking()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OKLHIPCDNDO
{
	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x29A4990", Offset = "0x29A3B90", VA = "0x1829A4990")]
	public static global::DIEFPKAPNKC<T> DAJPHPJHGIE<T>(this LECENBDGBAK LNELKNMCOEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface LOFCLOJEBNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLPNHBINJFC();

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HDECKBNAIGA(bool JFBPNBNBHOE);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class OKPDNBNAHCD : LOFCLOJEBNB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly global::IICGIBAOHPC<bool> PHLLDEOMGCD;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x556D8B0", Offset = "0x556CAB0", VA = "0x18556D8B0")]
	public OKPDNBNAHCD(DIODJLKJJHM MAFDHEKFLMG, string EBOEHIFNNLM, bool EOBGHKICABG, NPFLPICFNOH LGFFEAKPLLC, [Optional] Action IGAMPECHIKO, [Optional] GHILOBDJHNI NMAEJNLIKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x556D860", Offset = "0x556CA60", VA = "0x18556D860", Slot = "4")]
	public bool JLPNHBINJFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x556D800", Offset = "0x556CA00", VA = "0x18556D800", Slot = "5")]
	public void HDECKBNAIGA(bool JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x556D7E0", Offset = "0x556C9E0", VA = "0x18556D7E0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class EEKBEDMOBCI
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public const string FPLPHENDAPE = "The connectable subgraph being deserialized is corrupt.";

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public const string NNFFKBLEMLF = "The connectable subgraph failed to deserialize, even though it passed the corruption check.";
}
namespace RRAssemblyIndex.RecRoom.Connectables.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Preserve]
	internal class _RRAssemblyIndex : IIPLPEOFAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x5577680", Offset = "0x5576880", VA = "0x185577680", Slot = "6")]
		public sealed override void ABDNPPIKLOH(FJJGEPPJBDA IGAMPECHIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x5577800", Offset = "0x5576A00", VA = "0x185577800", Slot = "4")]
		public sealed override void FKBDNONAKOB()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x555EE90", Offset = "0x555E090", VA = "0x18555EE90")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x555EFA0", Offset = "0x555E1A0", VA = "0x18555EFA0")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
