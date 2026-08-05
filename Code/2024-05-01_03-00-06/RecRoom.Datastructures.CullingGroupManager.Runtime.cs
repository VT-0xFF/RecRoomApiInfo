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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, PJINDEFEPHD
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class DFBHLAOCIMK<T> : KKHHCOGENOL, EGFPCJIDALI<T>, BALFFALPJCK where T : class, PABHKGMPHOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x513B6B0", Offset = "0x513A4B0", VA = "0x18513B6B0")]
			internal DFBHLAOCIMK(int COHIACJHNLE, float[] FNIOCKDAANE, PCHMCOIBDEK DKBPLBDLECF = PCHMCOIBDEK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x513B680", Offset = "0x513A480", VA = "0x18513B680", Slot = "10")]
			public void HDCMKJKDALC(T EIFMADKIHON, float KOHJDCIMHLK, KCLBDKBPBDN NEHAENNMDNI = KCLBDKBPBDN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x513B650", Offset = "0x513A450", VA = "0x18513B650", Slot = "11")]
			public void HDCMKJKDALC(T EIFMADKIHON, Transform KAGOEINJGEJ, float KOHJDCIMHLK, KCLBDKBPBDN NEHAENNMDNI = KCLBDKBPBDN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x513B630", Offset = "0x513A430", VA = "0x18513B630", Slot = "12")]
			public void BOIJHFOIOPE(T FNMCEEBOJEC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class KKHHCOGENOL : IDisposable, BALFFALPJCK
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum PCHMCOIBDEK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class HHMIDMFAKKL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public PABHKGMPHOH IFPHJFPGDLM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public KCLBDKBPBDN CCGILKJDLIK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action NKBAPKHDAIL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool EEPIIKFEOMD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int PCBIBNEPCKE;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
				public HHMIDMFAKKL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class IBPBJHHAEHE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public KKHHCOGENOL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public HHMIDMFAKKL trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
				public IBPBJHHAEHE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x61E3BD0", Offset = "0x61E29D0", VA = "0x1861E3BD0")]
				internal void JDFKGCPADGH()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int DEGGMNNLGFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int COHIACJHNLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int PMLCCAFBPDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool KJIMDOIMIPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup BDMEHNNPAND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] ONPINIPMOBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] LPGNGLKGOFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly PEHDLKIOMEC EEEILKJFPBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<PABHKGMPHOH, int> FFECJFKAGOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, HHMIDMFAKKL> LEGAHHFLILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly PCHMCOIBDEK DKBPLBDLECF;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool DOOABOEIFAO
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xDECA10", Offset = "0xDEB810", VA = "0x180DECA10")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3FEBCF0", Offset = "0x3FEAAF0", VA = "0x183FEBCF0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x61E5880", Offset = "0x61E4680", VA = "0x1861E5880")]
			internal KKHHCOGENOL(int COHIACJHNLE, float[] FNIOCKDAANE, PCHMCOIBDEK DKBPLBDLECF = PCHMCOIBDEK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x61E3D20", Offset = "0x61E2B20", VA = "0x1861E3D20")]
			public void ABCOADHKCNO(bool ACBKMGMNLJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x61E4C40", Offset = "0x61E3A40", VA = "0x1861E4C40", Slot = "6")]
			public void HDCMKJKDALC(PABHKGMPHOH EIFMADKIHON, float KOHJDCIMHLK, KCLBDKBPBDN NEHAENNMDNI = KCLBDKBPBDN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x61E4CD0", Offset = "0x61E3AD0", VA = "0x1861E4CD0", Slot = "9")]
			public void HDCMKJKDALC(PABHKGMPHOH EIFMADKIHON, Transform KAGOEINJGEJ, float KOHJDCIMHLK, KCLBDKBPBDN NEHAENNMDNI = KCLBDKBPBDN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x61E47D0", Offset = "0x61E35D0", VA = "0x1861E47D0")]
			public void ECMNLOJOHOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x61E5580", Offset = "0x61E4380", VA = "0x1861E5580")]
			private void LKOIGGLIPHC(int AELAKOMEEDP, [Optional] float? KOHJDCIMHLK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x61E40B0", Offset = "0x61E2EB0", VA = "0x1861E40B0", Slot = "7")]
			public void BOIJHFOIOPE(PABHKGMPHOH FNMCEEBOJEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x61E5490", Offset = "0x61E4290", VA = "0x1861E5490", Slot = "8")]
			public void LINHKKNKIAI(PABHKGMPHOH EIFMADKIHON, KCLBDKBPBDN HEEKIAOAFDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x61E4510", Offset = "0x61E3310", VA = "0x1861E4510", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x61E3D50", Offset = "0x61E2B50", VA = "0x1861E3D50")]
			private void BKGELBCMBDD(HHMIDMFAKKL OOIKAEMIKIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x61E5220", Offset = "0x61E4020", VA = "0x1861E5220")]
			private void LGFHGEJEKIG(HHMIDMFAKKL OOIKAEMIKIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x61E56B0", Offset = "0x61E44B0", VA = "0x1861E56B0")]
			private void NPKBAMADFNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x61E44A0", Offset = "0x61E32A0", VA = "0x1861E44A0")]
			private void CABFJEEGMLA(float KAFHCFGLIGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x61E50E0", Offset = "0x61E3EE0", VA = "0x1861E50E0")]
			private void KFHMMGLNLMF(HHMIDMFAKKL OOIKAEMIKIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x61E50D0", Offset = "0x61E3ED0", VA = "0x1861E50D0")]
			private void JGINFPGKCIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x61E4500", Offset = "0x61E3300", VA = "0x1861E4500")]
			private void DHHKEBBJOED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x61E4920", Offset = "0x61E3720", VA = "0x1861E4920")]
			private void EDJMGLLLJAP(CullingGroupEvent PJIGKIBAJBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x61E5710", Offset = "0x61E4510", VA = "0x1861E5710")]
			private void PALDEDGKKIN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct NDJKMFOFKGC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort OBHOKMIBHAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type DHLHKLHGDGD;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float EDHHNABFOBE = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float DHPFMHJDMBJ = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float KJLHJFMNHMC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float DOAKHMAALHI = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float BFMDOIPDIFH = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float IDEAKPPJLLN = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float FDLMONPCAJD = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<NDJKMFOFKGC, KKHHCOGENOL> JKHFNEFOANL;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable KFIJONMFJEN;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable DBJBKCPNFPD;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static BFNGIAHHPKE GDHHHHHMOAN;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static BFNGIAHHPKE FGMPFBHEIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly BFNGIAHHPKE MELIMMDAHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly BFNGIAHHPKE NGLBENOIHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly BFNGIAHHPKE LGOKHMOMBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private DPFFPCFAMJN BFAGAODLLNJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool ACBKMGMNLJG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public BFNGIAHHPKE DLEAPCHMDOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BFNGIAHHPKE PBOGFCAHGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public BFNGIAHHPKE MDACIIEMGFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool NIGBENPLMGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD643F0", Offset = "0xD631F0", VA = "0x180D643F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool HPHBIHNOPFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x87B210", Offset = "0x87A010", VA = "0x18087B210", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9592F0", Offset = "0x9580F0", VA = "0x1809592F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x61E2990", Offset = "0x61E1790", VA = "0x1861E2990", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x61E3430", Offset = "0x61E2230", VA = "0x1861E3430")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61E3410", Offset = "0x61E2210", VA = "0x1861E3410")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61E32D0", Offset = "0x61E20D0", VA = "0x1861E32D0")]
		private void NHABLFHLLNO(Scene JBCGCLHCBFD, LoadSceneMode JLLJLOICEHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61E3330", Offset = "0x61E2130", VA = "0x1861E3330", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61E3680", Offset = "0x61E2480", VA = "0x1861E3680")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61E2BB0", Offset = "0x61E19B0", VA = "0x1861E2BB0")]
		private void GFNNILDOPGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61E3450", Offset = "0x61E2250", VA = "0x1861E3450")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61E2F70", Offset = "0x61E1D70", VA = "0x1861E2F70")]
		private void HIPEENPNHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61E2D50", Offset = "0x61E1B50", VA = "0x1861E2D50")]
		public BALFFALPJCK GetOrCreateCullingGroup(Type EBFLNBLCOJL, int LNFKHDBEMID, ushort OJBKGCCJBNP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x273ECD0", Offset = "0x273DAD0", VA = "0x18273ECD0")]
		public EGFPCJIDALI<T> GetOrCreateCullingGroup<T>(int LNFKHDBEMID, ushort OJBKGCCJBNP = 0) where T : class, PABHKGMPHOH
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x61E30E0", Offset = "0x61E1EE0", VA = "0x1861E30E0")]
		private BALFFALPJCK IONBGOIKOCB(Type EBFLNBLCOJL, int LNFKHDBEMID, float[] FNIOCKDAANE, ushort OJBKGCCJBNP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x273ED70", Offset = "0x273DB70", VA = "0x18273ED70")]
		private EGFPCJIDALI<T> IONBGOIKOCB<T>(int LNFKHDBEMID, float[] FNIOCKDAANE, ushort OJBKGCCJBNP = 0) where T : class, PABHKGMPHOH
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x61E2A50", Offset = "0x61E1850", VA = "0x1861E2A50")]
		public static LJIBDJGPFIC FindClosestDefaultUpdateLod(float PAIELCHFGEE)
		{
			return default(LJIBDJGPFIC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3E0", Offset = "0x7DC1E0", VA = "0x1807DD3E0")]
		public static LJIBDJGPFIC MinUpdateLod(LJIBDJGPFIC DBGMINIAJFA, LJIBDJGPFIC GILFBBACCAD)
		{
			return default(LJIBDJGPFIC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x61E32C0", Offset = "0x61E20C0", VA = "0x1861E32C0")]
		public static LJIBDJGPFIC MaxUpdateLod(LJIBDJGPFIC DBGMINIAJFA, LJIBDJGPFIC GILFBBACCAD)
		{
			return default(LJIBDJGPFIC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x61E3AD0", Offset = "0x61E28D0", VA = "0x1861E3AD0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PEHDLKIOMEC
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool JCGCPJPCHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera KOEOHLBEAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BFNGIAHHPKE PKLKIIJEDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool KHCGEMEOKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BFNGIAHHPKE NGMHMMLDLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform ODNGGLKHHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BALFFALPJCK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool DOOABOEIFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HDCMKJKDALC(PABHKGMPHOH EIFMADKIHON, float KOHJDCIMHLK, KCLBDKBPBDN NEHAENNMDNI = KCLBDKBPBDN.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOIJHFOIOPE(PABHKGMPHOH FNMCEEBOJEC);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LINHKKNKIAI(PABHKGMPHOH EIFMADKIHON, KCLBDKBPBDN BKEGMDDKANK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EGFPCJIDALI<T> : BALFFALPJCK where T : class, PABHKGMPHOH
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDCMKJKDALC(T EIFMADKIHON, float KOHJDCIMHLK, KCLBDKBPBDN NEHAENNMDNI = KCLBDKBPBDN.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HDCMKJKDALC(T EIFMADKIHON, Transform KAGOEINJGEJ, float KOHJDCIMHLK, KCLBDKBPBDN NEHAENNMDNI = KCLBDKBPBDN.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOIJHFOIOPE(T FNMCEEBOJEC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PABHKGMPHOH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform AFOLJDADEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(LJIBDJGPFIC OEMIAGMILEE, LJIBDJGPFIC LODCBDFPENG);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool MGIKOAEGEPK);
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
