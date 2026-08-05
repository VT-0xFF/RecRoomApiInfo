using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, KFMPKLNJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class GNDFANJIGAC<T> : KGFBIAIBNNJ, ANJLJKAPDMB<T>, MKJPKEEDEAC where T : class, KJMHNCGJAFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3E388F0", Offset = "0x3E372F0", VA = "0x183E388F0")]
			internal GNDFANJIGAC(int LHDHAOKDPOM, float[] LMGLDCFJHPF, LONECFKCDBG KDCGODNLACD = LONECFKCDBG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3E38870", Offset = "0x3E37270", VA = "0x183E38870", Slot = "10")]
			public void EGHPKMGPEOO(T GIGIFGONEAO, float MNBMJJFKKCE, NFCFPCIBOBP FEKPCKPLONN = NFCFPCIBOBP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3E388A0", Offset = "0x3E372A0", VA = "0x183E388A0", Slot = "11")]
			public void EGHPKMGPEOO(T GIGIFGONEAO, Transform CCLJEEMHNGI, float MNBMJJFKKCE, NFCFPCIBOBP FEKPCKPLONN = NFCFPCIBOBP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3E388D0", Offset = "0x3E372D0", VA = "0x183E388D0", Slot = "12")]
			public void MIOFMOMIMDC(T CHAKKMKKIMA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class KGFBIAIBNNJ : IDisposable, MKJPKEEDEAC
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum LONECFKCDBG : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class MGGOOHGPCIP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public KJMHNCGJAFK CLHDDLICOFI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public NFCFPCIBOBP IHIMLACIAPK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action ICBJDLBKJEM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool JGBMAFAKPOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int MOMFAOPBBMD;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
				public MGGOOHGPCIP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class PFCJBOCHFDB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public KGFBIAIBNNJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public MGGOOHGPCIP trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
				public PFCJBOCHFDB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x6B799C0", Offset = "0x6B783C0", VA = "0x186B799C0")]
				internal void NJCIIIFIHJF()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int JPHCIPCDNDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int LHDHAOKDPOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int GPFHCNENELE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool PJOLCHEBHAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup NFMLELEHLNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] BGHLMMFGGDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] MIFCBLGBMKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly JJLEOKOBGAJ NAAJCHKOOEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<KJMHNCGJAFK, int> JJDNONAJJBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, MGGOOHGPCIP> NHKCMDONCOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly LONECFKCDBG KDCGODNLACD;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool EJAJNDJKEPJ
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x9ECCD0", Offset = "0x9EB6D0", VA = "0x1809ECCD0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x4687F60", Offset = "0x4686960", VA = "0x184687F60", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6B795B0", Offset = "0x6B77FB0", VA = "0x186B795B0")]
			internal KGFBIAIBNNJ(int LHDHAOKDPOM, float[] LMGLDCFJHPF, LONECFKCDBG KDCGODNLACD = LONECFKCDBG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6B77CC0", Offset = "0x6B766C0", VA = "0x186B77CC0")]
			public void COICKNDPKAI(bool IKMFDINAGHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6B783C0", Offset = "0x6B76DC0", VA = "0x186B783C0", Slot = "6")]
			public void EGHPKMGPEOO(KJMHNCGJAFK GIGIFGONEAO, float MNBMJJFKKCE, NFCFPCIBOBP FEKPCKPLONN = NFCFPCIBOBP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6B77FC0", Offset = "0x6B769C0", VA = "0x186B77FC0", Slot = "9")]
			public void EGHPKMGPEOO(KJMHNCGJAFK GIGIFGONEAO, Transform CCLJEEMHNGI, float MNBMJJFKKCE, NFCFPCIBOBP FEKPCKPLONN = NFCFPCIBOBP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6B786F0", Offset = "0x6B770F0", VA = "0x186B786F0")]
			public void IHKIKEGDDLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6B78450", Offset = "0x6B76E50", VA = "0x186B78450")]
			private void FDLKJFJMKGA(int EBDDHAPIAHH, [Optional] float? MNBMJJFKKCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6B78F90", Offset = "0x6B77990", VA = "0x186B78F90", Slot = "7")]
			public void MIOFMOMIMDC(KJMHNCGJAFK CHAKKMKKIMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6B794C0", Offset = "0x6B77EC0", VA = "0x186B794C0", Slot = "8")]
			public void PCKODLIBPHO(KJMHNCGJAFK GIGIFGONEAO, NFCFPCIBOBP BAONDEIPNAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6B77D00", Offset = "0x6B76700", VA = "0x186B77D00", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6B78C30", Offset = "0x6B77630", VA = "0x186B78C30")]
			private void LEOCGODKKEP(MGGOOHGPCIP FIOKNGNFGLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6B77A50", Offset = "0x6B76450", VA = "0x186B77A50")]
			private void CLHIFGPCIOB(MGGOOHGPCIP FIOKNGNFGLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6B78BC0", Offset = "0x6B775C0", VA = "0x186B78BC0")]
			private void KFMBGJKMHFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6B78B60", Offset = "0x6B77560", VA = "0x186B78B60")]
			private void KDOOLADJKNB(float OMPPDBKHEPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6B79380", Offset = "0x6B77D80", VA = "0x186B79380")]
			private void NLMOLICMCFM(MGGOOHGPCIP FIOKNGNFGLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6B77CF0", Offset = "0x6B766F0", VA = "0x186B77CF0")]
			private void DKMDNOKOKOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6B78C20", Offset = "0x6B77620", VA = "0x186B78C20")]
			private void LDHPLIMGFFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6B78840", Offset = "0x6B77240", VA = "0x186B78840")]
			private void JJAONHAKKBM(CullingGroupEvent MIACDDKLLFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6B78580", Offset = "0x6B76F80", VA = "0x186B78580")]
			private void GHOJEIMDJKI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct FPELBBCAAGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort KDIHEPEGNIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type FGPKADKODGI;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float DJBPMMGEIBI = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float NILLACKOGFJ = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float MAPGOJDPAIB = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NFIFDGOLAEA = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float CHJDMFMCHJO = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float JHBCFKBFELK = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float GCAPPCFJHJK = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<FPELBBCAAGI, KGFBIAIBNNJ> ALFBEFKEBCN;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable IGFOEOMNHBA;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable PAONJPNFGAJ;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static PLAJPLAPENK ABCDOFBJDPE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static PLAJPLAPENK GJLOGFDDCON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly PLAJPLAPENK HEOHDDEDBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly PLAJPLAPENK POCADACKNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PLAJPLAPENK NPECIHFDNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private DABMKCAGAIA IOHIEPDLJMB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool IKMFDINAGHE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public PLAJPLAPENK GBHMLJDDDIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public PLAJPLAPENK JHEIMMAHODM
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public PLAJPLAPENK NCHHPHJAPPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool FOLNLIGIDFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x14D76D0", Offset = "0x14D60D0", VA = "0x1814D76D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool AMEJHHEGJKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xB75510", Offset = "0xB73F10", VA = "0x180B75510", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xC622D0", Offset = "0xC60CD0", VA = "0x180C622D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B76810", Offset = "0x6B75210", VA = "0x186B76810", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6B772B0", Offset = "0x6B75CB0", VA = "0x186B772B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6B77290", Offset = "0x6B75C90", VA = "0x186B77290")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6B77140", Offset = "0x6B75B40", VA = "0x186B77140")]
		private void LJONEOJKACB(Scene MPCFINNNDLP, LoadSceneMode KLNNBBIAGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6B771B0", Offset = "0x6B75BB0", VA = "0x186B771B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6B77500", Offset = "0x6B75F00", VA = "0x186B77500")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6B76A30", Offset = "0x6B75430", VA = "0x186B76A30")]
		private void GDACCJEBGAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6B772D0", Offset = "0x6B75CD0", VA = "0x186B772D0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6B76FD0", Offset = "0x6B759D0", VA = "0x186B76FD0")]
		private void KDAGJJPGLIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6B76BD0", Offset = "0x6B755D0", VA = "0x186B76BD0")]
		public MKJPKEEDEAC GetOrCreateCullingGroup(Type DMJILKNGBBG, int HALBEKJCBMD, ushort CFOEMIMMCCC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1210", Offset = "0x2AEFC10", VA = "0x182AF1210")]
		public ANJLJKAPDMB<T> GetOrCreateCullingGroup<T>(int HALBEKJCBMD, ushort CFOEMIMMCCC = 0) where T : class, KJMHNCGJAFK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6B76DF0", Offset = "0x6B757F0", VA = "0x186B76DF0")]
		private MKJPKEEDEAC IKECHMJAFGI(Type DMJILKNGBBG, int HALBEKJCBMD, float[] LMGLDCFJHPF, ushort CFOEMIMMCCC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2AF12C0", Offset = "0x2AEFCC0", VA = "0x182AF12C0")]
		private ANJLJKAPDMB<T> IKECHMJAFGI<T>(int HALBEKJCBMD, float[] LMGLDCFJHPF, ushort CFOEMIMMCCC = 0) where T : class, KJMHNCGJAFK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6B768D0", Offset = "0x6B752D0", VA = "0x186B768D0")]
		public static JNKKEIFENFB FindClosestDefaultUpdateLod(float MMDALMBEPPB)
		{
			return default(JNKKEIFENFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B17B0", Offset = "0x8B01B0", VA = "0x1808B17B0")]
		public static JNKKEIFENFB MinUpdateLod(JNKKEIFENFB MODCABFKGPH, JNKKEIFENFB MENMLOAJMMN)
		{
			return default(JNKKEIFENFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6B771A0", Offset = "0x6B75BA0", VA = "0x186B771A0")]
		public static JNKKEIFENFB MaxUpdateLod(JNKKEIFENFB MODCABFKGPH, JNKKEIFENFB MENMLOAJMMN)
		{
			return default(JNKKEIFENFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B77950", Offset = "0x6B76350", VA = "0x186B77950")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JJLEOKOBGAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool NKHNJFAKHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera PIFDMFNKNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	PLAJPLAPENK BBGIIOBOJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IBELKJBANIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PLAJPLAPENK DLPGLCNPGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform MLHBMDHIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MKJPKEEDEAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool EJAJNDJKEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGHPKMGPEOO(KJMHNCGJAFK GIGIFGONEAO, float MNBMJJFKKCE, NFCFPCIBOBP FEKPCKPLONN = NFCFPCIBOBP.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIOFMOMIMDC(KJMHNCGJAFK CHAKKMKKIMA);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PCKODLIBPHO(KJMHNCGJAFK GIGIFGONEAO, NFCFPCIBOBP PLEMDNIJLHF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ANJLJKAPDMB<T> : MKJPKEEDEAC where T : class, KJMHNCGJAFK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGHPKMGPEOO(T GIGIFGONEAO, float MNBMJJFKKCE, NFCFPCIBOBP FEKPCKPLONN = NFCFPCIBOBP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGHPKMGPEOO(T GIGIFGONEAO, Transform CCLJEEMHNGI, float MNBMJJFKKCE, NFCFPCIBOBP FEKPCKPLONN = NFCFPCIBOBP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIOFMOMIMDC(T CHAKKMKKIMA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KJMHNCGJAFK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform JKDLLOIHFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(JNKKEIFENFB HEFFODHPBJF, JNKKEIFENFB CBKEBANDDJE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool ADIHFCNFDBL);
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
