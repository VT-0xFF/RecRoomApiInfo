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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, JMBKFDFNLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class DEOPDPHDPDB<T> : NHMBJJFEDCE, JHJFALGOKBO<T>, AIPACPAGJIN where T : class, AMAGPLIHPFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x4FC6570", Offset = "0x4FC5970", VA = "0x184FC6570")]
			internal DEOPDPHDPDB(int NFHLIOCLCGD, float[] ALLKFJMIBNM, EEAPILBFCHK APNBNMBCLPM = EEAPILBFCHK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x4FC6520", Offset = "0x4FC5920", VA = "0x184FC6520", Slot = "10")]
			public void AFPNFDHLNMK(T BHPOPDOKECN, float CABLJKKDANE, JFOJKLKDMBJ EPKGFLMNBNC = JFOJKLKDMBJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x4FC64F0", Offset = "0x4FC58F0", VA = "0x184FC64F0", Slot = "11")]
			public void AFPNFDHLNMK(T BHPOPDOKECN, Transform JJHIMECCKLC, float CABLJKKDANE, JFOJKLKDMBJ EPKGFLMNBNC = JFOJKLKDMBJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4FC6550", Offset = "0x4FC5950", VA = "0x184FC6550", Slot = "12")]
			public void JJHPGEAJNEC(T MNGGPGLJAEF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class NHMBJJFEDCE : IDisposable, AIPACPAGJIN
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum EEAPILBFCHK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class JDIILEMDIKJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public AMAGPLIHPFI CGKIHHOMJKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public JFOJKLKDMBJ JHOINOCKFGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action BOINAELCAOH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool KLKBPIIFEGO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int BLAEHDOLMPP;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
				public JDIILEMDIKJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class MFJDPBADEIP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public NHMBJJFEDCE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public JDIILEMDIKJ trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
				public MFJDPBADEIP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x6051750", Offset = "0x6050B50", VA = "0x186051750")]
				internal void HBMPCGIPKEB()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int HOINGFDCJAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int NFHLIOCLCGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int CKBMCCEJOMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool BDMHAMLDKKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup ODFLCHKNDBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] NMDEHOPMPEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] NGLGHMCMPIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly IOLJBHJIGFJ LBELJDFAMCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<AMAGPLIHPFI, int> PPGANKIBDCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, JDIILEMDIKJ> PFNAKBANCPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly EEAPILBFCHK APNBNMBCLPM;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool NPEEKMGJPCG
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD36FA0", VA = "0x180D37BA0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3E74720", Offset = "0x3E73B20", VA = "0x183E74720", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6053440", Offset = "0x6052840", VA = "0x186053440")]
			internal NHMBJJFEDCE(int NFHLIOCLCGD, float[] ALLKFJMIBNM, EEAPILBFCHK APNBNMBCLPM = EEAPILBFCHK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x60523E0", Offset = "0x60517E0", VA = "0x1860523E0")]
			public void DBNMEKFMIIC(bool LCAIEKGOEDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6051BC0", Offset = "0x6050FC0", VA = "0x186051BC0", Slot = "6")]
			public void AFPNFDHLNMK(AMAGPLIHPFI BHPOPDOKECN, float CABLJKKDANE, JFOJKLKDMBJ EPKGFLMNBNC = JFOJKLKDMBJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6051C50", Offset = "0x6051050", VA = "0x186051C50", Slot = "9")]
			public void AFPNFDHLNMK(AMAGPLIHPFI BHPOPDOKECN, Transform JJHIMECCKLC, float CABLJKKDANE, JFOJKLKDMBJ EPKGFLMNBNC = JFOJKLKDMBJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6052F90", Offset = "0x6052390", VA = "0x186052F90")]
			public void OKFOPGIFLOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6052BB0", Offset = "0x6051FB0", VA = "0x186052BB0")]
			private void LNINPDNOLJH(int AHDNEIKOMIB, [Optional] float? CABLJKKDANE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x60527D0", Offset = "0x6051BD0", VA = "0x1860527D0", Slot = "7")]
			public void JJHPGEAJNEC(AMAGPLIHPFI MNGGPGLJAEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x60526E0", Offset = "0x6051AE0", VA = "0x1860526E0", Slot = "8")]
			public void GHEABGEMCJA(AMAGPLIHPFI BHPOPDOKECN, JFOJKLKDMBJ CNPILLLHGLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6052420", Offset = "0x6051820", VA = "0x186052420", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6052040", Offset = "0x6051440", VA = "0x186052040")]
			private void CKGCGDECAPD(JDIILEMDIKJ FBKMMGJKICG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6053140", Offset = "0x6052540", VA = "0x186053140")]
			private void PHAKEDPFGEP(JDIILEMDIKJ FBKMMGJKICG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x60533E0", Offset = "0x60527E0", VA = "0x1860533E0")]
			private void PLHBOEPNHIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x60530E0", Offset = "0x60524E0", VA = "0x1860530E0")]
			private void OLEDCGCJIKF(float FANKMGPLGGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6052E50", Offset = "0x6052250", VA = "0x186052E50")]
			private void NDMNNKMOBGH(JDIILEMDIKJ FBKMMGJKICG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x60523D0", Offset = "0x60517D0", VA = "0x1860523D0")]
			private void CNLOBFJKAPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6052410", Offset = "0x6051810", VA = "0x186052410")]
			private void DJAEGBDBMOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x60518A0", Offset = "0x6050CA0", VA = "0x1860518A0")]
			private void ABLELBONAMO(CullingGroupEvent AACBNAEACLP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6052CE0", Offset = "0x60520E0", VA = "0x186052CE0")]
			private void MEHBBKPMKEP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct GFEBLIPJFFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort GJFPAMAANLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type NLFHDJCMHMH;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float LJFKOGJABKG = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float IPIPGOEHCLF = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float JMNBCKPMFHM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float MJHMAAJCAJL = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float HAOPGMFELMG = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float GEJBKIFHBPP = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float ALPDLDAJJAJ = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<GFEBLIPJFFO, NHMBJJFEDCE> BABKMEFFPNO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable EGGIGELCMPG;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable EKAJPOJCPEN;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static DICJLHNIKOO IMMBNGBKILB;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static DICJLHNIKOO NBDBAFEJAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly DICJLHNIKOO NKMHGNKAKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DICJLHNIKOO OGLLOFBGGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DICJLHNIKOO DHDIKAFBEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private ICANAFEODIJ KNEDMHEAKBL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool LCAIEKGOEDP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DICJLHNIKOO MCLIPDADCNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public DICJLHNIKOO AFJPIBEJJBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DICJLHNIKOO GEEIIFCDEMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7A26F0", Offset = "0x7A1AF0", VA = "0x1807A26F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DJGDFMNFDKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBF4110", Offset = "0xBF3510", VA = "0x180BF4110", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LBFCPIOFDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7EC380", Offset = "0x7EB780", VA = "0x1807EC380", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7EC910", Offset = "0x7EBD10", VA = "0x1807EC910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x60504D0", Offset = "0x604F8D0", VA = "0x1860504D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6050F80", Offset = "0x6050380", VA = "0x186050F80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6050F60", Offset = "0x6050360", VA = "0x186050F60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6050590", Offset = "0x604F990", VA = "0x186050590")]
		private void CIMHBIPLAHL(Scene BHBDGFHBFAK, LoadSceneMode JNDDDHJCEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6050E80", Offset = "0x6050280", VA = "0x186050E80", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60511E0", Offset = "0x60505E0", VA = "0x1860511E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6050CD0", Offset = "0x60500D0", VA = "0x186050CD0")]
		private void MCHGKPEHHGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6050FA0", Offset = "0x60503A0", VA = "0x186050FA0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6050B50", Offset = "0x604FF50", VA = "0x186050B50")]
		private void KCNDLCCDHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6050930", Offset = "0x604FD30", VA = "0x186050930")]
		public AIPACPAGJIN GetOrCreateCullingGroup(Type FIBBNNPELJC, int KHODFKKCBCH, ushort IIOMGCOMLFI = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2516310", Offset = "0x2515710", VA = "0x182516310")]
		public JHJFALGOKBO<T> GetOrCreateCullingGroup<T>(int KHODFKKCBCH, ushort IIOMGCOMLFI = 0) where T : class, AMAGPLIHPFI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x60505F0", Offset = "0x604F9F0", VA = "0x1860505F0")]
		private AIPACPAGJIN DDBOJODNHAJ(Type FIBBNNPELJC, int KHODFKKCBCH, float[] ALLKFJMIBNM, ushort IIOMGCOMLFI = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x25160A0", Offset = "0x25154A0", VA = "0x1825160A0")]
		private JHJFALGOKBO<T> DDBOJODNHAJ<T>(int KHODFKKCBCH, float[] ALLKFJMIBNM, ushort IIOMGCOMLFI = 0) where T : class, AMAGPLIHPFI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60507D0", Offset = "0x604FBD0", VA = "0x1860507D0")]
		public static MMMOHCNLPFL FindClosestDefaultUpdateLod(float LDBDLOJEFEE)
		{
			return default(MMMOHCNLPFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7CCFB0", Offset = "0x7CC3B0", VA = "0x1807CCFB0")]
		public static MMMOHCNLPFL MinUpdateLod(MMMOHCNLPFL KLGODHPNNKF, MMMOHCNLPFL JJCMJAGIJBL)
		{
			return default(MMMOHCNLPFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6050E70", Offset = "0x6050270", VA = "0x186050E70")]
		public static MMMOHCNLPFL MaxUpdateLod(MMMOHCNLPFL KLGODHPNNKF, MMMOHCNLPFL JJCMJAGIJBL)
		{
			return default(MMMOHCNLPFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6051650", Offset = "0x6050A50", VA = "0x186051650")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IOLJBHJIGFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool NCNMCFGKCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera PGMFAHDNDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DICJLHNIKOO ALKPEJEOKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JHEBBJDCAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DICJLHNIKOO IEODLBIMGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform AANIKODPGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AIPACPAGJIN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NPEEKMGJPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFPNFDHLNMK(AMAGPLIHPFI BHPOPDOKECN, float CABLJKKDANE, JFOJKLKDMBJ EPKGFLMNBNC = JFOJKLKDMBJ.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJHPGEAJNEC(AMAGPLIHPFI MNGGPGLJAEF);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GHEABGEMCJA(AMAGPLIHPFI BHPOPDOKECN, JFOJKLKDMBJ DPPDOIJEAJA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JHJFALGOKBO<T> : AIPACPAGJIN where T : class, AMAGPLIHPFI
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFPNFDHLNMK(T BHPOPDOKECN, float CABLJKKDANE, JFOJKLKDMBJ EPKGFLMNBNC = JFOJKLKDMBJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFPNFDHLNMK(T BHPOPDOKECN, Transform JJHIMECCKLC, float CABLJKKDANE, JFOJKLKDMBJ EPKGFLMNBNC = JFOJKLKDMBJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJHPGEAJNEC(T MNGGPGLJAEF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AMAGPLIHPFI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform NPBNAACKOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(MMMOHCNLPFL HCGCEJELFOB, MMMOHCNLPFL HDDDKPPGHOG);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool MPCCPHNCACM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum JFOJKLKDMBJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MMMOHCNLPFL
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Invalid = -1
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
