using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Datastructures_CullingGroupManager_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x841DB80", Offset = "0x841C180", VA = "0x18841DB80", Slot = "4")]
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
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, LGFFGBFJLCF, AAJMNAIDLEH
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[BurstCompile]
		private struct ELODOMJPDKJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> DAJAOHIJHHL;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x841BD90", Offset = "0x841A390", VA = "0x18841BD90", Slot = "4")]
			public void Execute(int LEPAEEGOBDO, TransformAccess JAHKFPBBGHB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private struct BMFJNDELNNK : IEquatable<BMFJNDELNNK>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort HHOGBNCEJEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type LOCNNAKAGDB;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x841A770", Offset = "0x8418D70", VA = "0x18841A770", Slot = "4")]
			public bool Equals(BMFJNDELNNK IBCMCOKAJEM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x841A7F0", Offset = "0x8418DF0", VA = "0x18841A7F0", Slot = "0")]
			public override bool Equals(object NDBJJGOPOFO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x841A8E0", Offset = "0x8418EE0", VA = "0x18841A8E0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class GCDCFMAKGJH<T> : IJAGPJECKAP, KADPDNCKMIN<T>, FNKHPMOHMOL where T : class, LNDEJGNNFBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4FD3880", Offset = "0x4FD1E80", VA = "0x184FD3880")]
			internal GCDCFMAKGJH(int IHOIGEDBANJ, float[] FGMLFDKOENJ, LGJGNGJDGMJ BFHJCJCAOML = LGJGNGJDGMJ.PlayerHead, bool ANGPAFEFBHK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4FD3850", Offset = "0x4FD1E50", VA = "0x184FD3850", Slot = "12")]
			public void KMLBEHGKDFG(T NDBJJGOPOFO, float OFHHJJPMNHK, MMEGJHMINAN CMEKFLJIBHK = MMEGJHMINAN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4FD3820", Offset = "0x4FD1E20", VA = "0x184FD3820", Slot = "13")]
			public void KMLBEHGKDFG(T NDBJJGOPOFO, Transform BFHKKAEMLDN, float OFHHJJPMNHK, MMEGJHMINAN CMEKFLJIBHK = MMEGJHMINAN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4FD37E0", Offset = "0x4FD1DE0", VA = "0x184FD37E0", Slot = "14")]
			public void HCDNAOEAAEJ(T LGFHAOHAOAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4FD3800", Offset = "0x4FD1E00", VA = "0x184FD3800", Slot = "15")]
			public bool KCKIJMELFMN(T NDBJJGOPOFO)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class IJAGPJECKAP : IDisposable, FNKHPMOHMOL
		{
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			private struct ADFKBJDOKKE
			{
				[Cpp2IlInjected.Token(Token = "0x2000009")]
				public enum FFGCOLHPMKO : byte
				{
					[Cpp2IlInjected.Token(Token = "0x4000031")]
					Add,
					[Cpp2IlInjected.Token(Token = "0x4000032")]
					UpdateRadius,
					[Cpp2IlInjected.Token(Token = "0x4000033")]
					UpdatePosition,
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					UpdateTrackRate,
					[Cpp2IlInjected.Token(Token = "0x4000035")]
					Remove
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public LNDEJGNNFBO JJLBJLPMOFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform ADNKINOHCOK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float ELLGGJLJFAI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public MMEGJHMINAN KFNKKIBHNLG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public FFGCOLHPMKO MONFNOPPPGA;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public enum LGJGNGJDGMJ : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class ILJIGEJBAFN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public LNDEJGNNFBO JJLBJLPMOFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public MMEGJHMINAN NCCCOCJIBJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action PBCAEKKJNAE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool JADLEOFCKLI;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
				public ILJIGEJBAFN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int FAFEDGNEKFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool ANGPAFEFBHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool JBOBNJDEDEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup EFJMHHPPEHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] BGGKHPPDONP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly CLEDPINIDDJ KEBEIAGOJJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly LGJGNGJDGMJ BFHJCJCAOML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<LNDEJGNNFBO, int> ELHJJGIHIJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, ILJIGEJBAFN> LGKBEMPHKEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray POBGCPBMMLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> LMOJGBLAEBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<ADFKBJDOKKE> MKIBODFJJGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool LEJKJNOIKIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle ELCAJJNPFBB;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int PCGNAAHOOHA
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int ALCBMKGAOLL
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xAEAAE0", Offset = "0xAE90E0", VA = "0x180AEAAE0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB91EF0", Offset = "0xB904F0", VA = "0x180B91EF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x841D6A0", Offset = "0x841BCA0", VA = "0x18841D6A0")]
			internal IJAGPJECKAP(int IHOIGEDBANJ, float[] FGMLFDKOENJ, LGJGNGJDGMJ BFHJCJCAOML = LGJGNGJDGMJ.PlayerHead, bool ANGPAFEFBHK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x841CD50", Offset = "0x841B350", VA = "0x18841CD50")]
			public void MODAFANKIEP(bool KBANPHBGLCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x841CAF0", Offset = "0x841B0F0", VA = "0x18841CAF0", Slot = "5")]
			public void KMLBEHGKDFG(LNDEJGNNFBO NDBJJGOPOFO, float OFHHJJPMNHK, MMEGJHMINAN CMEKFLJIBHK = MMEGJHMINAN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x841CBF0", Offset = "0x841B1F0", VA = "0x18841CBF0", Slot = "10")]
			public void KMLBEHGKDFG(LNDEJGNNFBO NDBJJGOPOFO, Transform BFHKKAEMLDN, float OFHHJJPMNHK, MMEGJHMINAN CMEKFLJIBHK = MMEGJHMINAN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x841D400", Offset = "0x841BA00", VA = "0x18841D400")]
			private void PKDACKFNJDK(LNDEJGNNFBO NDBJJGOPOFO, Transform BFHKKAEMLDN, float OFHHJJPMNHK, MMEGJHMINAN CMEKFLJIBHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x841C4C0", Offset = "0x841AAC0", VA = "0x18841C4C0", Slot = "6")]
			public void HCDNAOEAAEJ(LNDEJGNNFBO LGFHAOHAOAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x841D120", Offset = "0x841B720", VA = "0x18841D120")]
			private void PGHPFGKGBHF(LNDEJGNNFBO LGFHAOHAOAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x841BE10", Offset = "0x841A410", VA = "0x18841BE10")]
			private void AOHHCNHPECH(LNDEJGNNFBO NDBJJGOPOFO, [Optional] float? OFHHJJPMNHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x841CA30", Offset = "0x841B030", VA = "0x18841CA30", Slot = "11")]
			public bool KCKIJMELFMN(LNDEJGNNFBO NDBJJGOPOFO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
			public void OAOLPOBBJMC(LNDEJGNNFBO NDBJJGOPOFO, MMEGJHMINAN DHOFLEENILD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x841C070", Offset = "0x841A670", VA = "0x18841C070")]
			private void CHGIAFEEDGP(LNDEJGNNFBO NDBJJGOPOFO, MMEGJHMINAN DHOFLEENILD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x841CC90", Offset = "0x841B290", VA = "0x18841CC90")]
			public void MEEOMMNIJFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x841C520", Offset = "0x841AB20", VA = "0x18841C520")]
			public void IMKFFBNJCEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x841C740", Offset = "0x841AD40", VA = "0x18841C740")]
			private void KBDAMJIFEFG(ADFKBJDOKKE JNNOBIJIOOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x841CD90", Offset = "0x841B390", VA = "0x18841CD90")]
			private void OFKBADNDCOM(int NPBLGGNFAIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x841C120", Offset = "0x841A720", VA = "0x18841C120", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x841CD80", Offset = "0x841B380", VA = "0x18841CD80")]
			private void OAEFIPNOCBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x841C730", Offset = "0x841AD30", VA = "0x18841C730")]
			private void JKCNAHKFBBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x841CEE0", Offset = "0x841B4E0", VA = "0x18841CEE0")]
			private void OLPKPDJGPEG(CullingGroupEvent OEBFEOEGILH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x841C350", Offset = "0x841A950", VA = "0x18841C350")]
			private void GBGMGHAOBCJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static IDGHEFJHGEI FEFALLLFAGB;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static IDGHEFJHGEI CHIBMMIMCJH;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float HIINEHKGPMA = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float DLHNMGHHLHL = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float EMHDLLBKACI = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float KAAJDIAMLMN = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float BKBKEIMJFFO = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float NHENCNPEFPM = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float EBGOBJACANJ = 500f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<BMFJNDELNNK, IJAGPJECKAP> FBCHFFLBAEN;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IDisposable BBOPFDLHBJP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDisposable JKPPLPCOOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly HBPNKKOKOOA MEIMCEOMBPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HBPNKKOKOOA MDBEJGPCOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly HBPNKKOKOOA HFMHHPDABBI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker CCLCAHLCJDJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker DIEFALNCAHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private APLPOCKIJEJ JBNPIEHBDEG;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool KBANPHBGLCA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MLKJKKPIIAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA94FC0", Offset = "0xA935C0", VA = "0x180A94FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HBPNKKOKOOA KBNNGGLFGBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HBPNKKOKOOA HNENJAMDIIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public HBPNKKOKOOA LAGPDLJGOGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool PGPOIJGDKFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAC1BD0", Offset = "0xAC01D0", VA = "0x180AC1BD0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool FHAAPHDOBFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD946A0", Offset = "0xD92CA0", VA = "0x180D946A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xE83B20", Offset = "0xE82120", VA = "0x180E83B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x841A9B0", Offset = "0x8418FB0", VA = "0x18841A9B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81C9720", Offset = "0x81C7D20", VA = "0x1881C9720")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x841B500", Offset = "0x8419B00", VA = "0x18841B500")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD61360", Offset = "0xD5F960", VA = "0x180D61360")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x841A950", Offset = "0x8418F50", VA = "0x18841A950")]
		private void ALMICEOKCKB(Scene PDFMOBOALJB, LoadSceneMode JDJJDFOGKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x841B420", Offset = "0x8419A20", VA = "0x18841B420", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x841B7C0", Offset = "0x8419DC0", VA = "0x18841B7C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x841B0B0", Offset = "0x84196B0", VA = "0x18841B0B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x841B2C0", Offset = "0x84198C0", VA = "0x18841B2C0")]
		private void NNIHCCIKMNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x841B520", Offset = "0x8419B20", VA = "0x18841B520")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x841AD60", Offset = "0x8419360", VA = "0x18841AD60")]
		private void GCOIBOIFDJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x841AED0", Offset = "0x84194D0", VA = "0x18841AED0")]
		public FNKHPMOHMOL GetOrCreateCullingGroup(Type MHALFMGGJPN, int KOKPIDJJNDP, ushort IPDLIKMOEAE = 0, bool ANGPAFEFBHK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4500", Offset = "0x3BC2B00", VA = "0x183BC4500")]
		public KADPDNCKMIN<T> GetOrCreateCullingGroup<T>(int KOKPIDJJNDP, ushort IPDLIKMOEAE = 0, bool ANGPAFEFBHK = false) where T : class, LNDEJGNNFBO
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x841AA70", Offset = "0x8419070", VA = "0x18841AA70")]
		private FNKHPMOHMOL EBFIPDNAPEF(Type MHALFMGGJPN, int KOKPIDJJNDP, float[] FGMLFDKOENJ, ushort IPDLIKMOEAE = 0, bool ANGPAFEFBHK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3BC42D0", Offset = "0x3BC28D0", VA = "0x183BC42D0")]
		private KADPDNCKMIN<T> EBFIPDNAPEF<T>(int KOKPIDJJNDP, float[] FGMLFDKOENJ, ushort IPDLIKMOEAE = 0, bool ANGPAFEFBHK = false) where T : class, LNDEJGNNFBO
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x841AC00", Offset = "0x8419200", VA = "0x18841AC00")]
		public static JGCNGACGAAH FindClosestDefaultUpdateLod(float LDKNOEAIAHI)
		{
			return default(JGCNGACGAAH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAC3710", Offset = "0xAC1D10", VA = "0x180AC3710")]
		public static JGCNGACGAAH MinUpdateLod(JGCNGACGAAH ELENCAGNPOP, JGCNGACGAAH MIKPOOMONBO)
		{
			return default(JGCNGACGAAH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x841B2B0", Offset = "0x84198B0", VA = "0x18841B2B0")]
		public static JGCNGACGAAH MaxUpdateLod(JGCNGACGAAH ELENCAGNPOP, JGCNGACGAAH MIKPOOMONBO)
		{
			return default(JGCNGACGAAH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x841BC40", Offset = "0x841A240", VA = "0x18841BC40")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAC1BD0", Offset = "0xAC01D0", VA = "0x180AC1BD0", Slot = "11")]
		private bool AOHMGIEGEBD()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CLEDPINIDDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool AGGLJNHJCPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera OFBJLFCLLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HBPNKKOKOOA HHNEEEJMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool DNBGCKAOLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HBPNKKOKOOA APMGBCHMIIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform DGACGPKMJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FNKHPMOHMOL
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMLBEHGKDFG(LNDEJGNNFBO NDBJJGOPOFO, float OFHHJJPMNHK, MMEGJHMINAN CMEKFLJIBHK = MMEGJHMINAN.Off);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HCDNAOEAAEJ(LNDEJGNNFBO LGFHAOHAOAF);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OAOLPOBBJMC(LNDEJGNNFBO NDBJJGOPOFO, MMEGJHMINAN LMJEHDELBCD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KADPDNCKMIN<T> : FNKHPMOHMOL where T : class, LNDEJGNNFBO
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMLBEHGKDFG(T NDBJJGOPOFO, float OFHHJJPMNHK, MMEGJHMINAN CMEKFLJIBHK = MMEGJHMINAN.Off);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMLBEHGKDFG(T NDBJJGOPOFO, Transform BFHKKAEMLDN, float OFHHJJPMNHK, MMEGJHMINAN CMEKFLJIBHK = MMEGJHMINAN.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HCDNAOEAAEJ(T LGFHAOHAOAF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KCKIJMELFMN(T NDBJJGOPOFO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LNDEJGNNFBO
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform JAHKFPBBGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(JGCNGACGAAH OGFDBLBDNLG, JGCNGACGAAH IBPAHBGEPJC);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool BPEBLCNNACG);
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
