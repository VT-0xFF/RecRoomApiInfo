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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84B8650", Offset = "0x84B6C50", VA = "0x1884B8650", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, HDFLEBKKIDM, AKDIJPFDGAK
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[BurstCompile]
		private struct OBOLOLONMFA : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> CDDIADBJAOB;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x84B86E0", Offset = "0x84B6CE0", VA = "0x1884B86E0", Slot = "4")]
			public void Execute(int PMIGBJGNLLP, TransformAccess CCHLCEHOKAD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private struct KKJBJDGBLCP : IEquatable<KKJBJDGBLCP>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort ALFMGBGCAFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type CPFEKFKAHDP;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x84B8470", Offset = "0x84B6A70", VA = "0x1884B8470", Slot = "4")]
			public bool Equals(KKJBJDGBLCP AAGCKLPFJME)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x84B84F0", Offset = "0x84B6AF0", VA = "0x1884B84F0", Slot = "0")]
			public override bool Equals(object MPIDDJPOOMJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x84B85E0", Offset = "0x84B6BE0", VA = "0x1884B85E0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class HHCNNMPBGNL<T> : PJFJMOOPCEO, IFJFEOMFEAG<T>, MDOCJAJDFJB where T : class, JCEDEPBPGKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5163CC0", Offset = "0x51622C0", VA = "0x185163CC0")]
			internal HHCNNMPBGNL(int GJNKIAJHLNE, float[] HJMIHEJMGLB, CPPIJADGLKP JKOJJJOBIFC = CPPIJADGLKP.PlayerHead, bool MHAOLKGBGMO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5163C90", Offset = "0x5162290", VA = "0x185163C90", Slot = "12")]
			public void MEFAAGOGBHI(T MPIDDJPOOMJ, float JPNOJNLEGJO, FLIFMIOEKDE OHLOCCPNKCM = FLIFMIOEKDE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5163C60", Offset = "0x5162260", VA = "0x185163C60", Slot = "13")]
			public void MEFAAGOGBHI(T MPIDDJPOOMJ, Transform OHFHALMKGCF, float JPNOJNLEGJO, FLIFMIOEKDE OHLOCCPNKCM = FLIFMIOEKDE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5163C20", Offset = "0x5162220", VA = "0x185163C20", Slot = "14")]
			public void CBELOMAGFLH(T NBMPFDOBNJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5163C40", Offset = "0x5162240", VA = "0x185163C40", Slot = "15")]
			public bool GHALIFGEOLG(T MPIDDJPOOMJ)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class PJFJMOOPCEO : IDisposable, MDOCJAJDFJB
		{
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			private struct KGFBNIFHFKD
			{
				[Cpp2IlInjected.Token(Token = "0x2000009")]
				public enum LKLPKBHLHEA : byte
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
				public JCEDEPBPGKA JGMAPBOCLOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform JJKHGJPALLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float MNAJFFMBOKL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public FLIFMIOEKDE BDGLLMOODOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public LKLPKBHLHEA HIKNDMJOAGH;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public enum CPPIJADGLKP : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class NEMMDDDNEEH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public JCEDEPBPGKA JGMAPBOCLOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public FLIFMIOEKDE KKFBDANOPPJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action DNKMIOJEEDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool HIJOKMOJKBI;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
				public NEMMDDDNEEH()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int PFDNBMJFENE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool MHAOLKGBGMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool AHFHMNIBLBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup CJGPABPPAKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] PONOEBIJHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly HNHHBLALNAA OHPHIKCFIBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly CPPIJADGLKP JKOJJJOBIFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<JCEDEPBPGKA, int> BLDEJCKHADL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, NEMMDDDNEEH> BJEDEBFLHJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray NMIGJIDLKGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> NJGIBLDIAGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<KGFBNIFHFKD> EGOKBGLICAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool CKBHHPHPFNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle BJFLKGBEEDK;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int OOEPLGCJDKB
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int HPGKJNHLDPF
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xB9FCB0", VA = "0x180BA16B0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xBA16C0", Offset = "0xB9FCC0", VA = "0x180BA16C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x84B9FF0", Offset = "0x84B85F0", VA = "0x1884B9FF0")]
			internal PJFJMOOPCEO(int GJNKIAJHLNE, float[] HJMIHEJMGLB, CPPIJADGLKP JKOJJJOBIFC = CPPIJADGLKP.PlayerHead, bool MHAOLKGBGMO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x84B8820", Offset = "0x84B6E20", VA = "0x1884B8820")]
			public void BAEFDCDCKCF(bool KBFGPLLMDFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x84B9AD0", Offset = "0x84B80D0", VA = "0x1884B9AD0", Slot = "5")]
			public void MEFAAGOGBHI(JCEDEPBPGKA MPIDDJPOOMJ, float JPNOJNLEGJO, FLIFMIOEKDE OHLOCCPNKCM = FLIFMIOEKDE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x84B9BD0", Offset = "0x84B81D0", VA = "0x1884B9BD0", Slot = "10")]
			public void MEFAAGOGBHI(JCEDEPBPGKA MPIDDJPOOMJ, Transform OHFHALMKGCF, float JPNOJNLEGJO, FLIFMIOEKDE OHLOCCPNKCM = FLIFMIOEKDE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x84B8850", Offset = "0x84B6E50", VA = "0x1884B8850")]
			private void BKGDGHLBOLF(JCEDEPBPGKA MPIDDJPOOMJ, Transform OHFHALMKGCF, float JPNOJNLEGJO, FLIFMIOEKDE OHLOCCPNKCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x84B8DE0", Offset = "0x84B73E0", VA = "0x1884B8DE0", Slot = "6")]
			public void CBELOMAGFLH(JCEDEPBPGKA NBMPFDOBNJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x84B97E0", Offset = "0x84B7DE0", VA = "0x1884B97E0")]
			private void JHOEDEIDFHP(JCEDEPBPGKA NBMPFDOBNJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x84B92B0", Offset = "0x84B78B0", VA = "0x1884B92B0")]
			private void EEMPDGDMCGM(JCEDEPBPGKA MPIDDJPOOMJ, [Optional] float? JPNOJNLEGJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x84B9660", Offset = "0x84B7C60", VA = "0x1884B9660", Slot = "11")]
			public bool GHALIFGEOLG(JCEDEPBPGKA MPIDDJPOOMJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
			public void FJJCIOGJCPE(JCEDEPBPGKA MPIDDJPOOMJ, FLIFMIOEKDE GEIHPHCMNOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x84B9730", Offset = "0x84B7D30", VA = "0x1884B9730")]
			private void IOKJJHNNJEL(JCEDEPBPGKA MPIDDJPOOMJ, FLIFMIOEKDE GEIHPHCMNOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x84B8760", Offset = "0x84B6D60", VA = "0x1884B8760")]
			public void ALGJHEPHDFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x84B9C70", Offset = "0x84B8270", VA = "0x1884B9C70")]
			public void MHMDGBFHOPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x84B8AF0", Offset = "0x84B70F0", VA = "0x1884B8AF0")]
			private void BMDBLFAFJBO(KGFBNIFHFKD KGDLOJHDMHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84B9510", Offset = "0x84B7B10", VA = "0x1884B9510")]
			private void EKEPOAKKKEI(int AILCJIPBLFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x84B9080", Offset = "0x84B7680", VA = "0x1884B9080", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x84B9720", Offset = "0x84B7D20", VA = "0x1884B9720")]
			private void IIBMIIKFNHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x84B9AC0", Offset = "0x84B80C0", VA = "0x1884B9AC0")]
			private void MBGBMOLDKKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x84B8E40", Offset = "0x84B7440", VA = "0x1884B8E40")]
			private void CLLKJODHAAB(CullingGroupEvent EPDDAGJBIOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x84B9E80", Offset = "0x84B8480", VA = "0x1884B9E80")]
			private void OAKMLMALBGP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static IPHNFELODMJ AMCHCCAPJNG;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static IPHNFELODMJ OKLHOFHIFPJ;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float PHMLAOLBHPF = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float EFDKFNALNMF = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float KBEJDNODCCC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float JKDOPINMCLG = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float CFOKMNIKGNK = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float KCBGKGHHBNI = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float EOELFCIHINH = 500f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<KKJBJDGBLCP, PJFJMOOPCEO> KFDCHIADMNH;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IDisposable NGFLDFMJEPP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDisposable CCNABJLGDGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly HLLOFHFLNHG GMAPPHDLMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HLLOFHFLNHG DNKFPJJCPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly HLLOFHFLNHG KMJKNPOEPBA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker EOFPAOLNNOD;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker NEJCFMFIGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private FAKIPBKLGEB IDMIPNPAIPI;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool KBFGPLLMDFG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MEGELOEHMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA5700", Offset = "0xAA3D00", VA = "0x180AA5700", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xAA54D0", Offset = "0xAA3AD0", VA = "0x180AA54D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HLLOFHFLNHG LBCNHBNGMMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HLLOFHFLNHG PLIILEHMBJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public HLLOFHFLNHG KEGBCHDFOLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FCHLNIMHOMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAD3D60", Offset = "0xAD2360", VA = "0x180AD3D60", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool FGDKNMIJDMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xDB20D0", Offset = "0xDB06D0", VA = "0x180DB20D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xE9F2B0", Offset = "0xE9D8B0", VA = "0x180E9F2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84B7030", Offset = "0x84B5630", VA = "0x1884B7030", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8253880", Offset = "0x8251E80", VA = "0x188253880")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84B7BE0", Offset = "0x84B61E0", VA = "0x1884B7BE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD7DFD0", Offset = "0xD7C5D0", VA = "0x180D7DFD0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84B70F0", Offset = "0x84B56F0", VA = "0x1884B70F0")]
		private void CJAPPLCNNAL(Scene BLFJNFOGIPN, LoadSceneMode IBLGEJEKAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84B7B00", Offset = "0x84B6100", VA = "0x1884B7B00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84B7EA0", Offset = "0x84B64A0", VA = "0x1884B7EA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84B7780", Offset = "0x84B5D80", VA = "0x1884B7780")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84B7150", Offset = "0x84B5750", VA = "0x1884B7150")]
		private void COACNLOPNJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84B7C00", Offset = "0x84B6200", VA = "0x1884B7C00")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84B7980", Offset = "0x84B5F80", VA = "0x1884B7980")]
		private void MPGGJKKIGMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84B7410", Offset = "0x84B5A10", VA = "0x1884B7410")]
		public MDOCJAJDFJB GetOrCreateCullingGroup(Type DAABOGAPOFM, int FBNHEIFHDCE, ushort HOPDILNCCHP = 0, bool MHAOLKGBGMO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3C18980", Offset = "0x3C16F80", VA = "0x183C18980")]
		public IFJFEOMFEAG<T> GetOrCreateCullingGroup<T>(int FBNHEIFHDCE, ushort HOPDILNCCHP = 0, bool MHAOLKGBGMO = false) where T : class, JCEDEPBPGKA
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84B75F0", Offset = "0x84B5BF0", VA = "0x1884B75F0")]
		private MDOCJAJDFJB JFOEIEPGKFJ(Type DAABOGAPOFM, int FBNHEIFHDCE, float[] HJMIHEJMGLB, ushort HOPDILNCCHP = 0, bool MHAOLKGBGMO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3C18A30", Offset = "0x3C17030", VA = "0x183C18A30")]
		private IFJFEOMFEAG<T> JFOEIEPGKFJ<T>(int FBNHEIFHDCE, float[] HJMIHEJMGLB, ushort HOPDILNCCHP = 0, bool MHAOLKGBGMO = false) where T : class, JCEDEPBPGKA
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84B72B0", Offset = "0x84B58B0", VA = "0x1884B72B0")]
		public static AHNGGBKKFOE FindClosestDefaultUpdateLod(float OBMNDGAIIJA)
		{
			return default(AHNGGBKKFOE);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4610", Offset = "0xAD2C10", VA = "0x180AD4610")]
		public static AHNGGBKKFOE MinUpdateLod(AHNGGBKKFOE ODHLEKBLPID, AHNGGBKKFOE HBCPCCJNMLM)
		{
			return default(AHNGGBKKFOE);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84B7AF0", Offset = "0x84B60F0", VA = "0x1884B7AF0")]
		public static AHNGGBKKFOE MaxUpdateLod(AHNGGBKKFOE ODHLEKBLPID, AHNGGBKKFOE HBCPCCJNMLM)
		{
			return default(AHNGGBKKFOE);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84B8320", Offset = "0x84B6920", VA = "0x1884B8320")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAD3D60", Offset = "0xAD2360", VA = "0x180AD3D60", Slot = "11")]
		private bool IPGDOMHPEAO()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HNHHBLALNAA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GIEKMGLAGAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera GNGMAJHKGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HLLOFHFLNHG JPAOIJKGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LBHALGDEAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HLLOFHFLNHG NOEKMLFDEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform CAINOIJNIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MDOCJAJDFJB
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEFAAGOGBHI(JCEDEPBPGKA MPIDDJPOOMJ, float JPNOJNLEGJO, FLIFMIOEKDE OHLOCCPNKCM = FLIFMIOEKDE.Off);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBELOMAGFLH(JCEDEPBPGKA NBMPFDOBNJP);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FJJCIOGJCPE(JCEDEPBPGKA MPIDDJPOOMJ, FLIFMIOEKDE JAFMJBKDLNC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IFJFEOMFEAG<T> : MDOCJAJDFJB where T : class, JCEDEPBPGKA
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEFAAGOGBHI(T MPIDDJPOOMJ, float JPNOJNLEGJO, FLIFMIOEKDE OHLOCCPNKCM = FLIFMIOEKDE.Off);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEFAAGOGBHI(T MPIDDJPOOMJ, Transform OHFHALMKGCF, float JPNOJNLEGJO, FLIFMIOEKDE OHLOCCPNKCM = FLIFMIOEKDE.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CBELOMAGFLH(T NBMPFDOBNJP);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GHALIFGEOLG(T MPIDDJPOOMJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JCEDEPBPGKA
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform CCHLCEHOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(AHNGGBKKFOE EAPJKOLGGJL, AHNGGBKKFOE KNILLMPDFKN);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool IOELFDJBDEL);
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
