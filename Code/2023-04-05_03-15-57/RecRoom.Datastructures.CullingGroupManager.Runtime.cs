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
			[Cpp2IlInjected.Address(RVA = "0x31D6C80", Offset = "0x31D5C80", VA = "0x1831D6C80")]
			internal MDKIIBJNKLK(int DDMIKDPMAHE, float[] CJFDJMDBJEO, ALHHKGDAEOP JIFODJOGOMB = ALHHKGDAEOP.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x31D6BA0", Offset = "0x31D5BA0", VA = "0x1831D6BA0", Slot = "15")]
			public void GBJBCHALJOG(T AELIHOPICED, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x31D6BD0", Offset = "0x31D5BD0", VA = "0x1831D6BD0", Slot = "16")]
			public void GBJBCHALJOG(T AELIHOPICED, Transform ODGIIEPIGAJ, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x31D6C20", Offset = "0x31D5C20", VA = "0x1831D6C20", Slot = "17")]
			public void HPKOMPPMIMN(T AELIHOPICED, [Optional] float? ANAMGBGEMJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x31D6C60", Offset = "0x31D5C60", VA = "0x1831D6C60", Slot = "18")]
			public void PMMODKPOELK(T JCHEIJOMOGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x31D6C40", Offset = "0x31D5C40", VA = "0x1831D6C40", Slot = "19")]
			public GMJLIEJPOEJ MJPFNFLEHLA(T AELIHOPICED)
			{
				return default(GMJLIEJPOEJ);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x31D6C00", Offset = "0x31D5C00", VA = "0x1831D6C00", Slot = "20")]
			public bool HOOAGMBBGPL(T AELIHOPICED)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x31D6B80", Offset = "0x31D5B80", VA = "0x1831D6B80", Slot = "21")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x6DF040", Offset = "0x6DE040", VA = "0x1806DF040", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int ACKDKGMHFHI
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x6F5790", Offset = "0x6F4790", VA = "0x1806F5790", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6655D60", Offset = "0x6654D60", VA = "0x186655D60")]
			internal MKDMKDKEJFC(int DDMIKDPMAHE, float[] CJFDJMDBJEO, ALHHKGDAEOP JIFODJOGOMB = ALHHKGDAEOP.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6655530", Offset = "0x6654530", VA = "0x186655530")]
			public void NAOAAEPNJFN(bool OFFNLCIAHNM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x66555D0", Offset = "0x66545D0", VA = "0x1866555D0", Slot = "7")]
			public GMJLIEJPOEJ PHAEAJEKMNM(float NGOKMEGFDGA)
			{
				return default(GMJLIEJPOEJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6654960", Offset = "0x6653960", VA = "0x186654960", Slot = "8")]
			public void GBJBCHALJOG(NFBHMIKCNHJ AELIHOPICED, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x66549F0", Offset = "0x66539F0", VA = "0x1866549F0", Slot = "9")]
			public void GBJBCHALJOG(NFBHMIKCNHJ AELIHOPICED, Transform ODGIIEPIGAJ, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6654340", Offset = "0x6653340", VA = "0x186654340")]
			public void EGJCCJOLJLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6654FE0", Offset = "0x6653FE0", VA = "0x186654FE0", Slot = "10")]
			public void HPKOMPPMIMN(NFBHMIKCNHJ AELIHOPICED, [Optional] float? ANAMGBGEMJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x66544C0", Offset = "0x66534C0", VA = "0x1866544C0")]
			private void ELLABLAHFEL(int EGBCAPEEJBF, [Optional] float? ANAMGBGEMJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x66557B0", Offset = "0x66547B0", VA = "0x1866557B0", Slot = "11")]
			public void PMMODKPOELK(NFBHMIKCNHJ JCHEIJOMOGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6655420", Offset = "0x6654420", VA = "0x186655420", Slot = "12")]
			public GMJLIEJPOEJ MJPFNFLEHLA(NFBHMIKCNHJ AELIHOPICED)
			{
				return default(GMJLIEJPOEJ);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6654EE0", Offset = "0x6653EE0", VA = "0x186654EE0", Slot = "13")]
			public bool HOOAGMBBGPL(NFBHMIKCNHJ AELIHOPICED)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6653D00", Offset = "0x6652D00", VA = "0x186653D00", Slot = "14")]
			public void BJBIJOPKCKP(NFBHMIKCNHJ AELIHOPICED, LCKOHGIHFDM NJDBPEOOLEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6654080", Offset = "0x6653080", VA = "0x186654080", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6655060", Offset = "0x6654060", VA = "0x186655060")]
			private void LLLNADGIGBF(BGEBFPFCKCI PDILABFFGKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6653DF0", Offset = "0x6652DF0", VA = "0x186653DF0")]
			private void CFDCOGOHCIB(BGEBFPFCKCI PDILABFFGKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6654E40", Offset = "0x6653E40", VA = "0x186654E40")]
			private void GKPEFAHPHCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6655560", Offset = "0x6654560", VA = "0x186655560")]
			private void OIOPOGCNAHI(float BOIHBMKHANN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6654EB0", Offset = "0x6653EB0", VA = "0x186654EB0")]
			private void GPKPNEEPBPL(BGEBFPFCKCI PDILABFFGKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6654330", Offset = "0x6653330", VA = "0x186654330")]
			private void ECIBPKKCEKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6654320", Offset = "0x6653320", VA = "0x186654320")]
			private void EALGMLNAGHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6654620", Offset = "0x6653620", VA = "0x186654620")]
			private void FOHJHCMJOGE(CullingGroupEvent BPBKGFMHHNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6655BE0", Offset = "0x6654BE0", VA = "0x186655BE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public AMNHKKJOBOK COKNMJGIKDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public AMNHKKJOBOK IDABAANDBCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KGFFDKBPMDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x13E9300", Offset = "0x13E8300", VA = "0x1813E9300", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool INJIGLBOGBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6DF030", Offset = "0x6DE030", VA = "0x1806DF030", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA49830", Offset = "0xA48830", VA = "0x180A49830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6652180", Offset = "0x6651180", VA = "0x186652180", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x10B9EF0", Offset = "0x10B8EF0", VA = "0x1810B9EF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6652C00", Offset = "0x6651C00", VA = "0x186652C00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66527A0", Offset = "0x66517A0", VA = "0x1866527A0")]
		private void NJAEGOPFPGE(Scene JLPOKIGCHBG, LoadSceneMode COAEGBJAHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6652B20", Offset = "0x6651B20", VA = "0x186652B20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6652E50", Offset = "0x6651E50", VA = "0x186652E50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x66525E0", Offset = "0x66515E0", VA = "0x1866525E0")]
		private void JDGMHLALOLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6652C20", Offset = "0x6651C20", VA = "0x186652C20")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6652800", Offset = "0x6651800", VA = "0x186652800")]
		private void NPFJFPMHIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x66523F0", Offset = "0x66513F0", VA = "0x1866523F0")]
		public OOGGPHHIOEI GetOrCreateCullingGroup(Type DALCCIOOEAJ, int OIBDFJNPKNI, ushort ABAAMLPJNIJ = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x212CB20", Offset = "0x212BB20", VA = "0x18212CB20")]
		public global::NBCPBJFLIKI<T> GetOrCreateCullingGroup<T>(int OIBDFJNPKNI, ushort ABAAMLPJNIJ = 0) where T : class, NFBHMIKCNHJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6652980", Offset = "0x6651980", VA = "0x186652980")]
		private OOGGPHHIOEI OBBKIDKKMBA(Type DALCCIOOEAJ, int OIBDFJNPKNI, float[] CJFDJMDBJEO, ushort ABAAMLPJNIJ = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x212CBD0", Offset = "0x212BBD0", VA = "0x18212CBD0")]
		private global::NBCPBJFLIKI<T> OBBKIDKKMBA<T>(int OIBDFJNPKNI, float[] CJFDJMDBJEO, ushort ABAAMLPJNIJ = 0) where T : class, NFBHMIKCNHJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6652250", Offset = "0x6651250", VA = "0x186652250")]
		public static GMJLIEJPOEJ FindClosestDefaultUpdateLod(float OGGNBMOFOKN)
		{
			return default(GMJLIEJPOEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6652790", Offset = "0x6651790", VA = "0x186652790")]
		public static GMJLIEJPOEJ MinUpdateLod(GMJLIEJPOEJ KEGIMAMEKEP, GMJLIEJPOEJ ALCHGJMEFNE)
		{
			return default(GMJLIEJPOEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6652780", Offset = "0x6651780", VA = "0x186652780")]
		public static GMJLIEJPOEJ MaxUpdateLod(GMJLIEJPOEJ KEGIMAMEKEP, GMJLIEJPOEJ ALCHGJMEFNE)
		{
			return default(GMJLIEJPOEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6653280", Offset = "0x6652280", VA = "0x186653280")]
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
		[Cpp2IlInjected.Address(RVA = "0x6653C30", Offset = "0x6652C30", VA = "0x186653C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GMJLIEJPOEJ EKCNGHKICCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6DF040", Offset = "0x6DE040", VA = "0x1806DF040")]
		get
		{
			return default(GMJLIEJPOEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GMJLIEJPOEJ KDEFKFOFHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5790", Offset = "0x6F4790", VA = "0x1806F5790")]
		get
		{
			return default(GMJLIEJPOEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6653BC0", Offset = "0x6652BC0", VA = "0x186653BC0")]
	public bool JPJHPPMDCBA(object JAKCBCDLMLB, GMJLIEJPOEJ KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6653B60", Offset = "0x6652B60", VA = "0x186653B60")]
	public bool FHGMKIKLJLK(object JAKCBCDLMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6653A00", Offset = "0x6652A00", VA = "0x186653A00")]
	private bool ADMEDMOFBKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6653C80", Offset = "0x6652C80", VA = "0x186653C80")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6653390", Offset = "0x6652390", VA = "0x186653390")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x66534A0", Offset = "0x66524A0", VA = "0x1866534A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
