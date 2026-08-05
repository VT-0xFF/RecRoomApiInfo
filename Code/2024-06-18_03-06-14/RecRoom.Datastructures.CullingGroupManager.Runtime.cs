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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, GIBAHFOFMFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class KFFBBEKFLNM<T> : HCPLPOHCDAO, PDKAODOKGCA<T>, OJMFLMFAEEI where T : class, JBPMFOFDJCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x41BFF10", Offset = "0x41BE910", VA = "0x1841BFF10")]
			internal KFFBBEKFLNM(int CBLJFOEIBDG, float[] OJCPBJKBIJP, MECICOBGIPK DBFNOJJHLII = MECICOBGIPK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x41BFEC0", Offset = "0x41BE8C0", VA = "0x1841BFEC0", Slot = "10")]
			public void KODKNHDNNHA(T GKHPLGCJCPF, float EHEGOIJKGEH, ALFJCHGPFEB FJMPFBILKCP = ALFJCHGPFEB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x41BFE90", Offset = "0x41BE890", VA = "0x1841BFE90", Slot = "11")]
			public void KODKNHDNNHA(T GKHPLGCJCPF, Transform NDNIDMMNEDG, float EHEGOIJKGEH, ALFJCHGPFEB FJMPFBILKCP = ALFJCHGPFEB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x41BFEF0", Offset = "0x41BE8F0", VA = "0x1841BFEF0", Slot = "12")]
			public void PLMGPBLKDNE(T COCCPJPDJCM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class HCPLPOHCDAO : IDisposable, OJMFLMFAEEI
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum MECICOBGIPK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class OFIHAMJOKHA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public JBPMFOFDJCF OGIEGFFHDCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public ALFJCHGPFEB BKMIKDOEKPE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action DHGHPKLMILN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool NHOAFGFAOAM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int JCLKIAMNLIO;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
				public OFIHAMJOKHA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class AHBKBBHDEOH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public HCPLPOHCDAO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public OFIHAMJOKHA trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
				public AHBKBBHDEOH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x6896150", Offset = "0x6894B50", VA = "0x186896150")]
				internal void CAHDODPLCOC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int ACLOPOBEMPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int CBLJFOEIBDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int KPGKJLKABIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool HEPHGBKCGHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup GOIEJEGINBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] OJLMCJELELK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] GFPAODEGILM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly AGKEIFGFLLB GLFIGPDLPBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<JBPMFOFDJCF, int> DALLEIJKJEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, OFIHAMJOKHA> EKOAGDCLNKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly MECICOBGIPK DBFNOJJHLII;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool JDFNNPDJPCC
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xF356F0", Offset = "0xF340F0", VA = "0x180F356F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x44C0110", Offset = "0x44BEB10", VA = "0x1844C0110", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x68990E0", Offset = "0x6897AE0", VA = "0x1868990E0")]
			internal HCPLPOHCDAO(int CBLJFOEIBDG, float[] OJCPBJKBIJP, MECICOBGIPK DBFNOJJHLII = MECICOBGIPK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6897840", Offset = "0x6896240", VA = "0x186897840")]
			public void CPBFMCBIEBJ(bool EJIHAKFCFBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6898730", Offset = "0x6897130", VA = "0x186898730", Slot = "6")]
			public void KODKNHDNNHA(JBPMFOFDJCF GKHPLGCJCPF, float EHEGOIJKGEH, ALFJCHGPFEB FJMPFBILKCP = ALFJCHGPFEB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6898330", Offset = "0x6896D30", VA = "0x186898330", Slot = "9")]
			public void KODKNHDNNHA(JBPMFOFDJCF GKHPLGCJCPF, Transform NDNIDMMNEDG, float EHEGOIJKGEH, ALFJCHGPFEB FJMPFBILKCP = ALFJCHGPFEB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x68980A0", Offset = "0x6896AA0", VA = "0x1868980A0")]
			public void JFKJAKMKCDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6898BC0", Offset = "0x68975C0", VA = "0x186898BC0")]
			private void MLNCELMPPCF(int ILOCEPPJPDO, [Optional] float? EHEGOIJKGEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6898CF0", Offset = "0x68976F0", VA = "0x186898CF0", Slot = "7")]
			public void PLMGPBLKDNE(JBPMFOFDJCF COCCPJPDJCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6897B10", Offset = "0x6896510", VA = "0x186897B10", Slot = "8")]
			public void DLLEIKFGAJE(JBPMFOFDJCF GKHPLGCJCPF, ALFJCHGPFEB PJNAMKEJNIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6897C00", Offset = "0x6896600", VA = "0x186897C00", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6898830", Offset = "0x6897230", VA = "0x186898830")]
			private void MDJFLELDMHD(OFIHAMJOKHA INIGDLFJIPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6897870", Offset = "0x6896270", VA = "0x186897870")]
			private void DGKEHEHHKCP(OFIHAMJOKHA INIGDLFJIPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6897EC0", Offset = "0x68968C0", VA = "0x186897EC0")]
			private void FHBJHIIIOJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x68987C0", Offset = "0x68971C0", VA = "0x1868987C0")]
			private void LADJOCKFBPO(float ECCGJGJKLJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x68981F0", Offset = "0x6896BF0", VA = "0x1868981F0")]
			private void KBDBMFCJLKB(OFIHAMJOKHA INIGDLFJIPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6898820", Offset = "0x6897220", VA = "0x186898820")]
			private void LOCPAEAIMKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6898090", Offset = "0x6896A90", VA = "0x186898090")]
			private void IKJGIOIMLOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6897520", Offset = "0x6895F20", VA = "0x186897520")]
			private void BECBKGOGION(CullingGroupEvent MOBJLDOIOCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6897F20", Offset = "0x6896920", VA = "0x186897F20")]
			private void IKAJKJKDDDK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct FAICIBNANGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort GLEIKGINAFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type KOOFCPIBJIC;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float MCCBPADJFOG = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float NNNKOAFCFPH = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float AMCNLKEHOEI = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float BDPIEANFJGM = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float HEAGIJOLPIA = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float LPEFEBFDBOH = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float BLDBIDPNNMD = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<FAICIBNANGG, HCPLPOHCDAO> FMMNEKHELII;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable CEMKNBHIKLN;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable OANCNKPLGIK;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static MNIMPDIHNFL GGLJHJCHOFG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static MNIMPDIHNFL KPMENIELCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly MNIMPDIHNFL PJHHHODLLCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly MNIMPDIHNFL HNHIFPBFGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MNIMPDIHNFL MEFELBCHCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private JLKEMPIKEGF MLOAJBJGKOI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool EJIHAKFCFBI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MNIMPDIHNFL MCAJJBEABCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MNIMPDIHNFL BEMAAMJBADN
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MNIMPDIHNFL NELOHJLLHAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool FLHFOMDOONC
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xF77890", Offset = "0xF76290", VA = "0x180F77890", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LNLDJJEBMFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A80", Offset = "0x9B6480", VA = "0x1809B7A80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA07480", Offset = "0xA05E80", VA = "0x180A07480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x68962A0", Offset = "0x6894CA0", VA = "0x1868962A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6896D50", Offset = "0x6895750", VA = "0x186896D50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6896D30", Offset = "0x6895730", VA = "0x186896D30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6896BF0", Offset = "0x68955F0", VA = "0x186896BF0")]
		private void OAEEEOHAIDN(Scene GLJMOLNEMGJ, LoadSceneMode MBMNLIPEPEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6896C50", Offset = "0x6895650", VA = "0x186896C50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6896FB0", Offset = "0x68959B0", VA = "0x186896FB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6896360", Offset = "0x6894D60", VA = "0x186896360")]
		private void EOHNDNNENIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6896D70", Offset = "0x6895770", VA = "0x186896D70")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6896A60", Offset = "0x6895460", VA = "0x186896A60")]
		private void JBKMJGBPAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6896840", Offset = "0x6895240", VA = "0x186896840")]
		public OJMFLMFAEEI GetOrCreateCullingGroup(Type CPDGJNGMHFP, int NLALAAAHKJI, ushort LCJMBEAGDCM = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x295BE00", Offset = "0x295A800", VA = "0x18295BE00")]
		public PDKAODOKGCA<T> GetOrCreateCullingGroup<T>(int NLALAAAHKJI, ushort LCJMBEAGDCM = 0) where T : class, JBPMFOFDJCF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6896660", Offset = "0x6895060", VA = "0x186896660")]
		private OJMFLMFAEEI GFPCMALNCGJ(Type CPDGJNGMHFP, int NLALAAAHKJI, float[] OJCPBJKBIJP, ushort LCJMBEAGDCM = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x295BB70", Offset = "0x295A570", VA = "0x18295BB70")]
		private PDKAODOKGCA<T> GFPCMALNCGJ<T>(int NLALAAAHKJI, float[] OJCPBJKBIJP, ushort LCJMBEAGDCM = 0) where T : class, JBPMFOFDJCF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6896500", Offset = "0x6894F00", VA = "0x186896500")]
		public static KFIHHKNEBMF FindClosestDefaultUpdateLod(float NBKOFBMMEBA)
		{
			return default(KFIHHKNEBMF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x87A240", Offset = "0x878C40", VA = "0x18087A240")]
		public static KFIHHKNEBMF MinUpdateLod(KFIHHKNEBMF OPLKFJGGCHJ, KFIHHKNEBMF EJBBFNIEDOF)
		{
			return default(KFIHHKNEBMF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6896BE0", Offset = "0x68955E0", VA = "0x186896BE0")]
		public static KFIHHKNEBMF MaxUpdateLod(KFIHHKNEBMF OPLKFJGGCHJ, KFIHHKNEBMF EJBBFNIEDOF)
		{
			return default(KFIHHKNEBMF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6897420", Offset = "0x6895E20", VA = "0x186897420")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AGKEIFGFLLB
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool MELPHCLHECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera BDCOMJGCOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	MNIMPDIHNFL PDBEMCHKGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IKNHHPJJDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MNIMPDIHNFL CIMKPIGOKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform AIJKHADJBLE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OJMFLMFAEEI
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool JDFNNPDJPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KODKNHDNNHA(JBPMFOFDJCF GKHPLGCJCPF, float EHEGOIJKGEH, ALFJCHGPFEB FJMPFBILKCP = ALFJCHGPFEB.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLMGPBLKDNE(JBPMFOFDJCF COCCPJPDJCM);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DLLEIKFGAJE(JBPMFOFDJCF GKHPLGCJCPF, ALFJCHGPFEB LFGJHPJKMOM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PDKAODOKGCA<T> : OJMFLMFAEEI where T : class, JBPMFOFDJCF
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KODKNHDNNHA(T GKHPLGCJCPF, float EHEGOIJKGEH, ALFJCHGPFEB FJMPFBILKCP = ALFJCHGPFEB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KODKNHDNNHA(T GKHPLGCJCPF, Transform NDNIDMMNEDG, float EHEGOIJKGEH, ALFJCHGPFEB FJMPFBILKCP = ALFJCHGPFEB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLMGPBLKDNE(T COCCPJPDJCM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JBPMFOFDJCF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform OFGHBAGNEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(KFIHHKNEBMF EJCBBMLGPKI, KFIHHKNEBMF DFLILBDBGAC);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool MHOIIAGFKCN);
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
