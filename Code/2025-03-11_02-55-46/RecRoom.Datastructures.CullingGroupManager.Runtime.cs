using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, MDLJCBDCMCN, PCDEJAOCFEP
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct GPNJDKEOMCJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> MJFOKKFMONL;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x75A9160", Offset = "0x75A8560", VA = "0x1875A9160", Slot = "4")]
			public void Execute(int FFCBHHABFJN, TransformAccess NCNOHDPHPJB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct OMENMCBIAFB : IEquatable<OMENMCBIAFB>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort CABDAMKNMKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type MKMEBLNEFMA;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x75AB3F0", Offset = "0x75AA7F0", VA = "0x1875AB3F0", Slot = "4")]
			public bool Equals(OMENMCBIAFB MNALNBMKJLK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x75AB300", Offset = "0x75AA700", VA = "0x1875AB300", Slot = "0")]
			public override bool Equals(object NBAMGPFDMIB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x75AB470", Offset = "0x75AA870", VA = "0x1875AB470", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class JELHKIOJPDH<T> : HLMKJFEEABB, ELCDGNBLOMF<T>, KAMDAKFNHGJ where T : class, KBEGLFMBMJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4A0B290", Offset = "0x4A0A690", VA = "0x184A0B290")]
			internal JELHKIOJPDH(int GDPEECICGJD, float[] NCKDGPBGNBC, HLCGMFNCKMD BOCLEHMJDGH = HLCGMFNCKMD.PlayerHead, bool CGNBPPPMDPJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4A0B220", Offset = "0x4A0A620", VA = "0x184A0B220", Slot = "12")]
			public void KAAHFJDOOLK(T NBAMGPFDMIB, float EJOLINDBPPE, MGFGMPBMECL EBNGJONJFCP = MGFGMPBMECL.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4A0B1F0", Offset = "0x4A0A5F0", VA = "0x184A0B1F0", Slot = "13")]
			public void KAAHFJDOOLK(T NBAMGPFDMIB, Transform OHGGGELEGCD, float EJOLINDBPPE, MGFGMPBMECL EBNGJONJFCP = MGFGMPBMECL.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4A0B270", Offset = "0x4A0A670", VA = "0x184A0B270", Slot = "14")]
			public void PBIACPFCCPC(T FGKGCDENGOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4A0B250", Offset = "0x4A0A650", VA = "0x184A0B250", Slot = "15")]
			public bool MIAIKGBHPEJ(T NBAMGPFDMIB)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class HLMKJFEEABB : IDisposable, KAMDAKFNHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct OKKBFCEBIFD
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum EJCADIJFGND : byte
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
				public KBEGLFMBMJL DPIDLKACMMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform KCFIKHGOCAF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float AAEBALPFOGL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public MGFGMPBMECL AEEHENBAKPK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public EJCADIJFGND ELLKCGJJEKP;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum HLCGMFNCKMD : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class BDJCOBLBIIP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public KBEGLFMBMJL DPIDLKACMMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public MGFGMPBMECL FIGIJNNBOKJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action BBJLKCICIIA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool INIPFHLKHNA;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
				public BDJCOBLBIIP()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int HFNDDLFCAFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool CGNBPPPMDPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool JBOKBJOADDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup LJDEHHPEBAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] BPIEFJEMACB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly CNHMNLDCLPI DCHKFKLALGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly HLCGMFNCKMD BOCLEHMJDGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<KBEGLFMBMJL, int> PLMINHGKOGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, BDJCOBLBIIP> FPHHKAHOAJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray CHFGKEGNDMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> KHMPEHPJHPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<OKKBFCEBIFD> IFKKPDAGFDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool BLHGLOELNIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle EJAJPPCPDCM;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int GKLIPKEMNCM
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x9641A0", Offset = "0x9635A0", VA = "0x1809641A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x968380", Offset = "0x967780", VA = "0x180968380")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int CKOINOMDHIO
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA80880", Offset = "0xA7FC80", VA = "0x180A80880", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB70020", Offset = "0xB6F420", VA = "0x180B70020")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x75AAE20", Offset = "0x75AA220", VA = "0x1875AAE20")]
			internal HLMKJFEEABB(int GDPEECICGJD, float[] NCKDGPBGNBC, HLCGMFNCKMD BOCLEHMJDGH = HLCGMFNCKMD.PlayerHead, bool CGNBPPPMDPJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x75A9830", Offset = "0x75A8C30", VA = "0x1875A9830")]
			public void HGBCDPAPFFF(bool NDIDHEFBMLH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x75AA070", Offset = "0x75A9470", VA = "0x1875AA070", Slot = "5")]
			public void KAAHFJDOOLK(KBEGLFMBMJL NBAMGPFDMIB, float EJOLINDBPPE, MGFGMPBMECL EBNGJONJFCP = MGFGMPBMECL.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x75AA170", Offset = "0x75A9570", VA = "0x1875AA170", Slot = "10")]
			public void KAAHFJDOOLK(KBEGLFMBMJL NBAMGPFDMIB, Transform OHGGGELEGCD, float EJOLINDBPPE, MGFGMPBMECL EBNGJONJFCP = MGFGMPBMECL.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x75AA9D0", Offset = "0x75A9DD0", VA = "0x1875AA9D0")]
			private void OBOKMBOHIEO(KBEGLFMBMJL NBAMGPFDMIB, Transform OHGGGELEGCD, float EJOLINDBPPE, MGFGMPBMECL EBNGJONJFCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x75AADC0", Offset = "0x75AA1C0", VA = "0x1875AADC0", Slot = "6")]
			public void PBIACPFCCPC(KBEGLFMBMJL FGKGCDENGOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x75A9C30", Offset = "0x75A9030", VA = "0x1875A9C30")]
			private void JGBAECIDNDC(KBEGLFMBMJL FGKGCDENGOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x75A99D0", Offset = "0x75A8DD0", VA = "0x1875A99D0")]
			private void IOFPNIHNMDM(KBEGLFMBMJL NBAMGPFDMIB, [Optional] float? EJOLINDBPPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x75AA610", Offset = "0x75A9A10", VA = "0x1875AA610", Slot = "11")]
			public bool MIAIKGBHPEJ(KBEGLFMBMJL NBAMGPFDMIB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "7")]
			public void AFAMFMAAMEH(KBEGLFMBMJL NBAMGPFDMIB, MGFGMPBMECL OCIGHABPLJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x75A91E0", Offset = "0x75A85E0", VA = "0x1875A91E0")]
			private void CCJMMGFJPOC(KBEGLFMBMJL NBAMGPFDMIB, MGFGMPBMECL OCIGHABPLJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x75AA550", Offset = "0x75A9950", VA = "0x1875AA550")]
			public void LLBIKOAGNNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x75A94D0", Offset = "0x75A88D0", VA = "0x1875A94D0")]
			public void GKLJNKLANDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x75AA6D0", Offset = "0x75A9AD0", VA = "0x1875AA6D0")]
			private void MMBMMNBEPEJ(OKKBFCEBIFD FBGCPEAGLNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x75A96E0", Offset = "0x75A8AE0", VA = "0x1875A96E0")]
			private void HCHNKECDOGK(int LANNFHODPJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x75A9290", Offset = "0x75A8690", VA = "0x1875A9290", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x75AA540", Offset = "0x75A9940", VA = "0x1875AA540")]
			private void KMGCOANDBDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x75A94C0", Offset = "0x75A88C0", VA = "0x1875A94C0")]
			private void FBGILANBIIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x75AA210", Offset = "0x75A9610", VA = "0x1875AA210")]
			private void KFHDMHMLLNF(CullingGroupEvent DLPOLGPNCDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x75A9860", Offset = "0x75A8C60", VA = "0x1875A9860")]
			private void IKJIOKFDNMG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float LGBBGOGAAIJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float LJBECJMHJBJ = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float INMACJMBACL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float IEIIHOHMHNM = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float CPCAPBBDNOC = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float CLDELOOGHCM = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float ILHLFCFJPAP = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<OMENMCBIAFB, HLMKJFEEABB> JNMPMFJLGOG;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable OIFBIPHOCEN;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable MKEHMDNOFBL;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static EBGLFEEDNOA HFOMDBFNIBD;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static EBGLFEEDNOA GKEMADGEOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly EBGLFEEDNOA BJLCAEGBPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EBGLFEEDNOA LNCPJEKNBHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly EBGLFEEDNOA AJAGLMEDONG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker DENGJCKPADE;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker BMAGPPLHNOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private DCOKPPOHOJG OLNMFOINMAI;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool NDIDHEFBMLH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OPONMODNLPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x96A750", Offset = "0x969B50", VA = "0x18096A750", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x96A740", Offset = "0x969B40", VA = "0x18096A740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EBGLFEEDNOA HBKCNPBNAFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EBGLFEEDNOA BJNIJGBMJNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public EBGLFEEDNOA EMKPCKCNEDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool EOHEKOPBPIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x991AF0", Offset = "0x990EF0", VA = "0x180991AF0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool PAADDBIJABF
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB07F10", Offset = "0xB07310", VA = "0x180B07F10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xBF6490", Offset = "0xBF5890", VA = "0x180BF6490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x75A7C90", Offset = "0x75A7090", VA = "0x1875A7C90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x75A8820", Offset = "0x75A7C20", VA = "0x1875A8820")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1C8BBB0", Offset = "0x1C8AFB0", VA = "0x181C8BBB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAF89E0", Offset = "0xAF7DE0", VA = "0x180AF89E0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x75A8840", Offset = "0x75A7C40", VA = "0x1875A8840")]
		private void PEJCKEADKHK(Scene CFICENCPFGI, LoadSceneMode PMFPMLHADKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x75A8740", Offset = "0x75A7B40", VA = "0x1875A8740", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x75A8B30", Offset = "0x75A7F30", VA = "0x1875A8B30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75A8380", Offset = "0x75A7780", VA = "0x1875A8380")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x75A7EE0", Offset = "0x75A72E0", VA = "0x1875A7EE0")]
		private void CKEKGOFJINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75A88A0", Offset = "0x75A7CA0", VA = "0x1875A88A0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x75A85D0", Offset = "0x75A79D0", VA = "0x1875A85D0")]
		private void OKNCFJBIAKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x75A81A0", Offset = "0x75A75A0", VA = "0x1875A81A0")]
		public KAMDAKFNHGJ GetOrCreateCullingGroup(Type MHEDKLIKPKK, int HELKMPPFAED, ushort JPBFNEDKNGJ = 0, bool CGNBPPPMDPJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x32C8EA0", Offset = "0x32C82A0", VA = "0x1832C8EA0")]
		public ELCDGNBLOMF<T> GetOrCreateCullingGroup<T>(int HELKMPPFAED, ushort JPBFNEDKNGJ = 0, bool CGNBPPPMDPJ = false) where T : class, KBEGLFMBMJL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x75A7D50", Offset = "0x75A7150", VA = "0x1875A7D50")]
		private KAMDAKFNHGJ CEEOOECGBJN(Type MHEDKLIKPKK, int HELKMPPFAED, float[] NCKDGPBGNBC, ushort JPBFNEDKNGJ = 0, bool CGNBPPPMDPJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x32C8C60", Offset = "0x32C8060", VA = "0x1832C8C60")]
		private ELCDGNBLOMF<T> CEEOOECGBJN<T>(int HELKMPPFAED, float[] NCKDGPBGNBC, ushort JPBFNEDKNGJ = 0, bool CGNBPPPMDPJ = false) where T : class, KBEGLFMBMJL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75A8040", Offset = "0x75A7440", VA = "0x1875A8040")]
		public static BJOOMCLMBJJ FindClosestDefaultUpdateLod(float KBJKBIJMMOJ)
		{
			return default(BJOOMCLMBJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x993270", Offset = "0x992670", VA = "0x180993270")]
		public static BJOOMCLMBJJ MinUpdateLod(BJOOMCLMBJJ HDCGCOPPDNB, BJOOMCLMBJJ IMMMJKNNOAN)
		{
			return default(BJOOMCLMBJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x75A85C0", Offset = "0x75A79C0", VA = "0x1875A85C0")]
		public static BJOOMCLMBJJ MaxUpdateLod(BJOOMCLMBJJ HDCGCOPPDNB, BJOOMCLMBJJ IMMMJKNNOAN)
		{
			return default(BJOOMCLMBJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x75A9010", Offset = "0x75A8410", VA = "0x1875A9010")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x991AF0", Offset = "0x990EF0", VA = "0x180991AF0", Slot = "11")]
		private bool EDMNCKJLANA()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CNHMNLDCLPI
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool JJOIFPIEKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera DHHMNBANPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EBGLFEEDNOA DNIJJGCHAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool DLCIGAIFJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	EBGLFEEDNOA JHOGBGOKELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform LFMDALBIFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KAMDAKFNHGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAAHFJDOOLK(KBEGLFMBMJL NBAMGPFDMIB, float EJOLINDBPPE, MGFGMPBMECL EBNGJONJFCP = MGFGMPBMECL.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBIACPFCCPC(KBEGLFMBMJL FGKGCDENGOG);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFAMFMAAMEH(KBEGLFMBMJL NBAMGPFDMIB, MGFGMPBMECL DNBGPNLEGNH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ELCDGNBLOMF<T> : KAMDAKFNHGJ where T : class, KBEGLFMBMJL
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAAHFJDOOLK(T NBAMGPFDMIB, float EJOLINDBPPE, MGFGMPBMECL EBNGJONJFCP = MGFGMPBMECL.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAAHFJDOOLK(T NBAMGPFDMIB, Transform OHGGGELEGCD, float EJOLINDBPPE, MGFGMPBMECL EBNGJONJFCP = MGFGMPBMECL.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBIACPFCCPC(T FGKGCDENGOG);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MIAIKGBHPEJ(T NBAMGPFDMIB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KBEGLFMBMJL
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform NCNOHDPHPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(BJOOMCLMBJJ KDIDMJBHAMD, BJOOMCLMBJJ KAJKOEDAAFH);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool FHNENDPEOIN);
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
