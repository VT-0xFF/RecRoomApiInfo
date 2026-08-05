using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, ADIFEAAPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class MDKIIBJNKLK<T> : MKDMKDKEJFC, global::NBCPBJFLIKI<T>, OOGGPHHIOEI where T : class, NFBHMIKCNHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x30B2990", Offset = "0x30B1D90", VA = "0x1830B2990")]
			internal MDKIIBJNKLK(int DDMIKDPMAHE, float[] CJFDJMDBJEO, ALHHKGDAEOP JIFODJOGOMB = ALHHKGDAEOP.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x30B28B0", Offset = "0x30B1CB0", VA = "0x1830B28B0", Slot = "15")]
			public void GBJBCHALJOG(T AELIHOPICED, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x30B28E0", Offset = "0x30B1CE0", VA = "0x1830B28E0", Slot = "16")]
			public void GBJBCHALJOG(T AELIHOPICED, Transform ODGIIEPIGAJ, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x30B2930", Offset = "0x30B1D30", VA = "0x1830B2930", Slot = "17")]
			public void HPKOMPPMIMN(T AELIHOPICED, [Optional] float? ANAMGBGEMJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x30B2970", Offset = "0x30B1D70", VA = "0x1830B2970", Slot = "18")]
			public void PMMODKPOELK(T JCHEIJOMOGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x30B2950", Offset = "0x30B1D50", VA = "0x1830B2950", Slot = "19")]
			public GMJLIEJPOEJ MJPFNFLEHLA(T AELIHOPICED)
			{
				return default(GMJLIEJPOEJ);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x30B2910", Offset = "0x30B1D10", VA = "0x1830B2910", Slot = "20")]
			public bool HOOAGMBBGPL(T AELIHOPICED)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x30B2890", Offset = "0x30B1C90", VA = "0x1830B2890", Slot = "21")]
			public void BJBIJOPKCKP(T AELIHOPICED, LCKOHGIHFDM MLADFEEADKC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class MKDMKDKEJFC : IDisposable, OOGGPHHIOEI
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum ALHHKGDAEOP : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class BGEBFPFCKCI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public NFBHMIKCNHJ HJKKKHLKLHO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public LCKOHGIHFDM KEDCDCHHKMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action NCOKLBHAJCF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool NFKNLHFDCCB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int NOAKOLDJPCH;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
				public BGEBFPFCKCI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class JIJFLLGCIKM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public MKDMKDKEJFC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public BGEBFPFCKCI trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
				public JIJFLLGCIKM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int GNGEFEGAKMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int DDMIKDPMAHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int OOBCJODNMBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool LJINJAFAKDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup AMOCLAAKHIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] IOCEBMLLMBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] KJMPBDLBFCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly GBBOPGFIGAI JPJNJBPAHKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<NFBHMIKCNHJ, int> DCGMFEMEIMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, BGEBFPFCKCI> BHNBOONANGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly ALHHKGDAEOP JIFODJOGOMB;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int AIJNJANHJAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x6E0040", Offset = "0x6DF440", VA = "0x1806E0040", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int ACKDKGMHFHI
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x6F6790", Offset = "0x6F5B90", VA = "0x1806F6790", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x66D4600", Offset = "0x66D3A00", VA = "0x1866D4600")]
			internal MKDMKDKEJFC(int DDMIKDPMAHE, float[] CJFDJMDBJEO, ALHHKGDAEOP JIFODJOGOMB = ALHHKGDAEOP.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x66D3DD0", Offset = "0x66D31D0", VA = "0x1866D3DD0")]
			public void NAOAAEPNJFN(bool OFFNLCIAHNM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x66D3E70", Offset = "0x66D3270", VA = "0x1866D3E70", Slot = "7")]
			public GMJLIEJPOEJ PHAEAJEKMNM(float NGOKMEGFDGA)
			{
				return default(GMJLIEJPOEJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x66D3200", Offset = "0x66D2600", VA = "0x1866D3200", Slot = "8")]
			public void GBJBCHALJOG(NFBHMIKCNHJ AELIHOPICED, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x66D3290", Offset = "0x66D2690", VA = "0x1866D3290", Slot = "9")]
			public void GBJBCHALJOG(NFBHMIKCNHJ AELIHOPICED, Transform ODGIIEPIGAJ, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x66D2BE0", Offset = "0x66D1FE0", VA = "0x1866D2BE0")]
			public void EGJCCJOLJLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x66D3880", Offset = "0x66D2C80", VA = "0x1866D3880", Slot = "10")]
			public void HPKOMPPMIMN(NFBHMIKCNHJ AELIHOPICED, [Optional] float? ANAMGBGEMJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x66D2D60", Offset = "0x66D2160", VA = "0x1866D2D60")]
			private void ELLABLAHFEL(int EGBCAPEEJBF, [Optional] float? ANAMGBGEMJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x66D4050", Offset = "0x66D3450", VA = "0x1866D4050", Slot = "11")]
			public void PMMODKPOELK(NFBHMIKCNHJ JCHEIJOMOGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x66D3CC0", Offset = "0x66D30C0", VA = "0x1866D3CC0", Slot = "12")]
			public GMJLIEJPOEJ MJPFNFLEHLA(NFBHMIKCNHJ AELIHOPICED)
			{
				return default(GMJLIEJPOEJ);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x66D3780", Offset = "0x66D2B80", VA = "0x1866D3780", Slot = "13")]
			public bool HOOAGMBBGPL(NFBHMIKCNHJ AELIHOPICED)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x66D25A0", Offset = "0x66D19A0", VA = "0x1866D25A0", Slot = "14")]
			public void BJBIJOPKCKP(NFBHMIKCNHJ AELIHOPICED, LCKOHGIHFDM NJDBPEOOLEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x66D2920", Offset = "0x66D1D20", VA = "0x1866D2920", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x66D3900", Offset = "0x66D2D00", VA = "0x1866D3900")]
			private void LLLNADGIGBF(BGEBFPFCKCI PDILABFFGKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x66D2690", Offset = "0x66D1A90", VA = "0x1866D2690")]
			private void CFDCOGOHCIB(BGEBFPFCKCI PDILABFFGKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x66D36E0", Offset = "0x66D2AE0", VA = "0x1866D36E0")]
			private void GKPEFAHPHCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x66D3E00", Offset = "0x66D3200", VA = "0x1866D3E00")]
			private void OIOPOGCNAHI(float BOIHBMKHANN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x66D3750", Offset = "0x66D2B50", VA = "0x1866D3750")]
			private void GPKPNEEPBPL(BGEBFPFCKCI PDILABFFGKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x66D2BD0", Offset = "0x66D1FD0", VA = "0x1866D2BD0")]
			private void ECIBPKKCEKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x66D2BC0", Offset = "0x66D1FC0", VA = "0x1866D2BC0")]
			private void EALGMLNAGHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x66D2EC0", Offset = "0x66D22C0", VA = "0x1866D2EC0")]
			private void FOHJHCMJOGE(CullingGroupEvent BPBKGFMHHNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x66D4480", Offset = "0x66D3880", VA = "0x1866D4480")]
			private void PODMKIAPIPF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct DCNOANICKOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort EBAJELBAEPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type GJGCHNDPNJN;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float COLOMMFLEBK = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float BOOMLHOMKOL = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float HLGCDLNNLIO = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float GLPEFLPKCPL = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float JPJGLMADHCM = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float MBAIPAKBLIE = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float BPPGAGAOCAH = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<DCNOANICKOJ, MKDMKDKEJFC> HDFBGCCFBLK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable GLHDOLEFFDE;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable ABICNICPAKK;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static AMNHKKJOBOK KKLJIJBPGLH;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static AMNHKKJOBOK FPJAONBKIME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly AMNHKKJOBOK JOHKFJFPGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly AMNHKKJOBOK FMFKAJCEKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly AMNHKKJOBOK AFJFKGOIJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private ALMNDBMKBBN FFBCJJIKEEG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool OFFNLCIAHNM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AMNHKKJOBOK KOOIMBCOBEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public AMNHKKJOBOK COKNMJGIKDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public AMNHKKJOBOK IDABAANDBCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KGFFDKBPMDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x17712D0", Offset = "0x17706D0", VA = "0x1817712D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool INJIGLBOGBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6E0030", Offset = "0x6DF430", VA = "0x1806E0030", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA4A830", Offset = "0xA49C30", VA = "0x180A4A830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66D0A20", Offset = "0x66CFE20", VA = "0x1866D0A20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xF83490", Offset = "0xF82890", VA = "0x180F83490")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66D14A0", Offset = "0x66D08A0", VA = "0x1866D14A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66D1040", Offset = "0x66D0440", VA = "0x1866D1040")]
		private void NJAEGOPFPGE(Scene JLPOKIGCHBG, LoadSceneMode COAEGBJAHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x66D13C0", Offset = "0x66D07C0", VA = "0x1866D13C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x66D16F0", Offset = "0x66D0AF0", VA = "0x1866D16F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x66D0E80", Offset = "0x66D0280", VA = "0x1866D0E80")]
		private void JDGMHLALOLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x66D14C0", Offset = "0x66D08C0", VA = "0x1866D14C0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x66D10A0", Offset = "0x66D04A0", VA = "0x1866D10A0")]
		private void NPFJFPMHIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C90", Offset = "0x66D0090", VA = "0x1866D0C90")]
		public OOGGPHHIOEI GetOrCreateCullingGroup(Type DALCCIOOEAJ, int OIBDFJNPKNI, ushort ABAAMLPJNIJ = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x232CB90", Offset = "0x232BF90", VA = "0x18232CB90")]
		public global::NBCPBJFLIKI<T> GetOrCreateCullingGroup<T>(int OIBDFJNPKNI, ushort ABAAMLPJNIJ = 0) where T : class, NFBHMIKCNHJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x66D1220", Offset = "0x66D0620", VA = "0x1866D1220")]
		private OOGGPHHIOEI OBBKIDKKMBA(Type DALCCIOOEAJ, int OIBDFJNPKNI, float[] CJFDJMDBJEO, ushort ABAAMLPJNIJ = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x232CC40", Offset = "0x232C040", VA = "0x18232CC40")]
		private global::NBCPBJFLIKI<T> OBBKIDKKMBA<T>(int OIBDFJNPKNI, float[] CJFDJMDBJEO, ushort ABAAMLPJNIJ = 0) where T : class, NFBHMIKCNHJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x66D0AF0", Offset = "0x66CFEF0", VA = "0x1866D0AF0")]
		public static GMJLIEJPOEJ FindClosestDefaultUpdateLod(float OGGNBMOFOKN)
		{
			return default(GMJLIEJPOEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x66D1030", Offset = "0x66D0430", VA = "0x1866D1030")]
		public static GMJLIEJPOEJ MinUpdateLod(GMJLIEJPOEJ KEGIMAMEKEP, GMJLIEJPOEJ ALCHGJMEFNE)
		{
			return default(GMJLIEJPOEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x66D1020", Offset = "0x66D0420", VA = "0x1866D1020")]
		public static GMJLIEJPOEJ MaxUpdateLod(GMJLIEJPOEJ KEGIMAMEKEP, GMJLIEJPOEJ ALCHGJMEFNE)
		{
			return default(GMJLIEJPOEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x66D1B20", Offset = "0x66D0F20", VA = "0x1866D1B20")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GBBOPGFIGAI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool CCJCJFNHADM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera NOBBOPFOLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AMNHKKJOBOK NKEAACIFPEL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool EHCLGJNHFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AMNHKKJOBOK NAMKMJMHOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform DMNJKJGFNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OOGGPHHIOEI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int AIJNJANHJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int ACKDKGMHFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GMJLIEJPOEJ PHAEAJEKMNM(float NGOKMEGFDGA);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GBJBCHALJOG(NFBHMIKCNHJ AELIHOPICED, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBJBCHALJOG(NFBHMIKCNHJ AELIHOPICED, Transform ODGIIEPIGAJ, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HPKOMPPMIMN(NFBHMIKCNHJ AELIHOPICED, [Optional] float? ANAMGBGEMJA);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PMMODKPOELK(NFBHMIKCNHJ JCHEIJOMOGP);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GMJLIEJPOEJ MJPFNFLEHLA(NFBHMIKCNHJ AELIHOPICED);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HOOAGMBBGPL(NFBHMIKCNHJ AELIHOPICED);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BJBIJOPKCKP(NFBHMIKCNHJ AELIHOPICED, LCKOHGIHFDM MLADFEEADKC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NBCPBJFLIKI<T> : OOGGPHHIOEI where T : class, NFBHMIKCNHJ
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBJBCHALJOG(T AELIHOPICED, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBJBCHALJOG(T AELIHOPICED, Transform ODGIIEPIGAJ, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPKOMPPMIMN(T AELIHOPICED, [Optional] float? ANAMGBGEMJA);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PMMODKPOELK(T JCHEIJOMOGP);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GMJLIEJPOEJ MJPFNFLEHLA(T AELIHOPICED);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HOOAGMBBGPL(T AELIHOPICED);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BJBIJOPKCKP(T AELIHOPICED, LCKOHGIHFDM MLADFEEADKC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NFBHMIKCNHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform PKIKNDCFAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(GMJLIEJPOEJ BBGPNJDGJOJ, GMJLIEJPOEJ BDOHNKDFFHL);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool DPOEBCKBBJI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum LCKOHGIHFDM : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum GMJLIEJPOEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KMHPCMHHAMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private GMJLIEJPOEJ EKDCKLAKFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private GMJLIEJPOEJ IBFPNBPAEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, GMJLIEJPOEJ> MBKGGPOELHE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool GNKDLLKCMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x66D24D0", Offset = "0x66D18D0", VA = "0x1866D24D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GMJLIEJPOEJ EKCNGHKICCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6E0040", Offset = "0x6DF440", VA = "0x1806E0040")]
		get
		{
			return default(GMJLIEJPOEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GMJLIEJPOEJ KDEFKFOFHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6790", Offset = "0x6F5B90", VA = "0x1806F6790")]
		get
		{
			return default(GMJLIEJPOEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x66D2460", Offset = "0x66D1860", VA = "0x1866D2460")]
	public bool JPJHPPMDCBA(object JAKCBCDLMLB, GMJLIEJPOEJ KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x66D2400", Offset = "0x66D1800", VA = "0x1866D2400")]
	public bool FHGMKIKLJLK(object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x66D22A0", Offset = "0x66D16A0", VA = "0x1866D22A0")]
	private bool ADMEDMOFBKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x66D2520", Offset = "0x66D1920", VA = "0x1866D2520")]
	public KMHPCMHHAMN()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x66D1C30", Offset = "0x66D1030", VA = "0x1866D1C30")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x66D1D40", Offset = "0x66D1140", VA = "0x1866D1D40")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
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
