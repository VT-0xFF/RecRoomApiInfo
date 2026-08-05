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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8265BB0", Offset = "0x8264FB0", VA = "0x188265BB0", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, DDJGNJLPCOM, FBNDMBMKCOM
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[BurstCompile]
		private struct KDOMPHKFIMG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> NGIAGNLBILI;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8265B30", Offset = "0x8264F30", VA = "0x188265B30", Slot = "4")]
			public void Execute(int NOEININIMIL, TransformAccess GANAIKEBLIG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private struct MMJJAAPFADH : IEquatable<MMJJAAPFADH>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort IBEDNGEGPNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type MFGFEIJNDGB;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8265C40", Offset = "0x8265040", VA = "0x188265C40", Slot = "4")]
			public bool Equals(MMJJAAPFADH LHDOHAKINKP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8265CC0", Offset = "0x82650C0", VA = "0x188265CC0", Slot = "0")]
			public override bool Equals(object DEJGDIIDCDN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8265DB0", Offset = "0x82651B0", VA = "0x188265DB0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class GGNNDJGBMAN<T> : NFMMJAFONHE, EHGILADCPJJ<T>, LPDOOAPPEAF where T : class, INHLNNHCEPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4F52700", Offset = "0x4F51B00", VA = "0x184F52700")]
			internal GGNNDJGBMAN(int AOCHNPLIPKH, float[] IODNHOPOFAJ, PADHAHMAMKK CHIGHBBKHAK = PADHAHMAMKK.PlayerHead, bool AJJILCFFLGG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4F526B0", Offset = "0x4F51AB0", VA = "0x184F526B0", Slot = "12")]
			public void KOBMLIBBKBO(T DEJGDIIDCDN, float FLMDAOGEKMO, LDGMPMKAKEN GKMFFJHCJFF = LDGMPMKAKEN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4F52680", Offset = "0x4F51A80", VA = "0x184F52680", Slot = "13")]
			public void KOBMLIBBKBO(T DEJGDIIDCDN, Transform AJMGKKHIJKI, float FLMDAOGEKMO, LDGMPMKAKEN GKMFFJHCJFF = LDGMPMKAKEN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4F52660", Offset = "0x4F51A60", VA = "0x184F52660", Slot = "14")]
			public void CBDHBFLGDII(T NOJJKJFNCDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4F526E0", Offset = "0x4F51AE0", VA = "0x184F526E0", Slot = "15")]
			public bool LOIJAPDHAPD(T DEJGDIIDCDN)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class NFMMJAFONHE : IDisposable, LPDOOAPPEAF
		{
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			private struct BNOELNDGKOO
			{
				[Cpp2IlInjected.Token(Token = "0x2000009")]
				public enum GLCPCFKEKIH : byte
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
				public INHLNNHCEPE HACCPIDBCFO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform MDOMHAEDEOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float LOJLBBEMLJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public LDGMPMKAKEN OKCBMDFGGIO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public GLCPCFKEKIH GBFFBDIJNIN;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public enum PADHAHMAMKK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class DNGGHKEMPKA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public INHLNNHCEPE HACCPIDBCFO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public LDGMPMKAKEN JFKDGIHCBCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action ODPPJLPMEKC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool MHDOBKBDMLJ;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
				public DNGGHKEMPKA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int CGIAPJBPOEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool AJJILCFFLGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool EGNOAKFAPLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup DJAFMEJKJGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] FOHLNOBBCEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly IHOLEIFCCHH LHIJBEJLBFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly PADHAHMAMKK CHIGHBBKHAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<INHLNNHCEPE, int> JEHPEPHGPLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, DNGGHKEMPKA> ODEJNCAEOPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray NIIMKJKFBDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> ADHPFEOBNEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<BNOELNDGKOO> JMBJEACBEJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool HPHOPBPANDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle EDPKGAKIIHD;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int PLKFJABLIGC
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int KDKOBEHJMDB
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xAC6FB0", Offset = "0xAC63B0", VA = "0x180AC6FB0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB508B0", Offset = "0xB4FCB0", VA = "0x180B508B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x82676B0", Offset = "0x8266AB0", VA = "0x1882676B0")]
			internal NFMMJAFONHE(int AOCHNPLIPKH, float[] IODNHOPOFAJ, PADHAHMAMKK CHIGHBBKHAK = PADHAHMAMKK.PlayerHead, bool AJJILCFFLGG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8266A60", Offset = "0x8265E60", VA = "0x188266A60")]
			public void JCNLKACICKH(bool OKGNONIDIOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8266B50", Offset = "0x8265F50", VA = "0x188266B50", Slot = "5")]
			public void KOBMLIBBKBO(INHLNNHCEPE DEJGDIIDCDN, float FLMDAOGEKMO, LDGMPMKAKEN GKMFFJHCJFF = LDGMPMKAKEN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8266C50", Offset = "0x8266050", VA = "0x188266C50", Slot = "10")]
			public void KOBMLIBBKBO(INHLNNHCEPE DEJGDIIDCDN, Transform AJMGKKHIJKI, float FLMDAOGEKMO, LDGMPMKAKEN GKMFFJHCJFF = LDGMPMKAKEN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8266140", Offset = "0x8265540", VA = "0x188266140")]
			private void DNBHKOFDFAK(INHLNNHCEPE DEJGDIIDCDN, Transform AJMGKKHIJKI, float FLMDAOGEKMO, LDGMPMKAKEN GKMFFJHCJFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8265ED0", Offset = "0x82652D0", VA = "0x188265ED0", Slot = "6")]
			public void CBDHBFLGDII(INHLNNHCEPE NOJJKJFNCDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8267010", Offset = "0x8266410", VA = "0x188267010")]
			private void NKIKGJHENFG(INHLNNHCEPE NOJJKJFNCDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8266DB0", Offset = "0x82661B0", VA = "0x188266DB0")]
			private void MAPCFLFBFDF(INHLNNHCEPE DEJGDIIDCDN, [Optional] float? FLMDAOGEKMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8266CF0", Offset = "0x82660F0", VA = "0x188266CF0", Slot = "11")]
			public bool LOIJAPDHAPD(INHLNNHCEPE DEJGDIIDCDN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
			public void DEIBGKOHLHL(INHLNNHCEPE DEJGDIIDCDN, LDGMPMKAKEN LPGLEJKEPJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8265E20", Offset = "0x8265220", VA = "0x188265E20")]
			private void AKCGFEDEONN(INHLNNHCEPE DEJGDIIDCDN, LDGMPMKAKEN LPGLEJKEPJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8266A90", Offset = "0x8265E90", VA = "0x188266A90")]
			public void JNIDDLEHMAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8265F30", Offset = "0x8265330", VA = "0x188265F30")]
			public void CHLMHCOBCHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8266770", Offset = "0x8265B70", VA = "0x188266770")]
			private void IMIDPCBMFAF(BNOELNDGKOO CHNNNFLKBNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8266610", Offset = "0x8265A10", VA = "0x188266610")]
			private void GIIFPEFIDBM(int PKLJCGFDBGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x82663E0", Offset = "0x82657E0", VA = "0x1882663E0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x82672F0", Offset = "0x82666F0", VA = "0x1882672F0")]
			private void NPMKBOFGGNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8266760", Offset = "0x8265B60", VA = "0x188266760")]
			private void ILKGGACEKIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8267470", Offset = "0x8266870", VA = "0x188267470")]
			private void PCOMFFKMENC(CullingGroupEvent IANNICEOKMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8267300", Offset = "0x8266700", VA = "0x188267300")]
			private void OHAHMBHHLOJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static AKNCNLDICPO CCLJCJDJCOE;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static AKNCNLDICPO PPKBLCHACOB;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float GOHDFPKAHIM = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float GPHDMNCHMHF = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float DDJDGCDEHKJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float HNGEJLAIFFG = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float ICNFLEOBABJ = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float ENAPNOMENNF = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float INPNGPMECIC = 500f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<MMJJAAPFADH, NFMMJAFONHE> HLGDLNGBHJA;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IDisposable NKDFGOHCNHO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDisposable LHNALCICAKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly OFFOKCJIMNI LMNFIHFOPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OFFOKCJIMNI FAAMIHNHJLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly OFFOKCJIMNI BFEHNPHOIGG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker KOGJAIDHFDA;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker EEKBBDJHCNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private LDBPABGAEKE PGPNKCAAGJK;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool OKGNONIDIOA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MDHGNPMONEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA702A0", Offset = "0xA6F6A0", VA = "0x180A702A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OFFOKCJIMNI CHBKEIKLENN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public OFFOKCJIMNI GOHIJKKBJJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public OFFOKCJIMNI LCLLMIPBECA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool PNFLMOLENDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA9B060", Offset = "0xA9A460", VA = "0x180A9B060", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool NIMEKEBDGII
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD31600", Offset = "0xD30A00", VA = "0x180D31600", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xE3FF90", Offset = "0xE3F390", VA = "0x180E3FF90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82646F0", Offset = "0x8263AF0", VA = "0x1882646F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8017E00", Offset = "0x8017200", VA = "0x188017E00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82652A0", Offset = "0x82646A0", VA = "0x1882652A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD1E460", Offset = "0xD1D860", VA = "0x180D1E460")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8264AF0", Offset = "0x8263EF0", VA = "0x188264AF0")]
		private void HKLHOIFPLAN(Scene CHBELKDGKBD, LoadSceneMode KLNPGHMOELH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82651C0", Offset = "0x82645C0", VA = "0x1882651C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8265560", Offset = "0x8264960", VA = "0x188265560")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8264CB0", Offset = "0x82640B0", VA = "0x188264CB0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8264B50", Offset = "0x8263F50", VA = "0x188264B50")]
		private void IJPIAKEKCFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82652C0", Offset = "0x82646C0", VA = "0x1882652C0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8265050", Offset = "0x8264450", VA = "0x188265050")]
		private void OIPLMAGALCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8264910", Offset = "0x8263D10", VA = "0x188264910")]
		public LPDOOAPPEAF GetOrCreateCullingGroup(Type JFFEKLIBPKH, int CDFOEJJMPBG, ushort FHAPHBGIEAB = 0, bool AJJILCFFLGG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5790", Offset = "0x3AE4B90", VA = "0x183AE5790")]
		public EHGILADCPJJ<T> GetOrCreateCullingGroup<T>(int CDFOEJJMPBG, ushort FHAPHBGIEAB = 0, bool AJJILCFFLGG = false) where T : class, INHLNNHCEPE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8264EC0", Offset = "0x82642C0", VA = "0x188264EC0")]
		private LPDOOAPPEAF OGPIFGAJNIE(Type JFFEKLIBPKH, int CDFOEJJMPBG, float[] IODNHOPOFAJ, ushort FHAPHBGIEAB = 0, bool AJJILCFFLGG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5840", Offset = "0x3AE4C40", VA = "0x183AE5840")]
		private EHGILADCPJJ<T> OGPIFGAJNIE<T>(int CDFOEJJMPBG, float[] IODNHOPOFAJ, ushort FHAPHBGIEAB = 0, bool AJJILCFFLGG = false) where T : class, INHLNNHCEPE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82647B0", Offset = "0x8263BB0", VA = "0x1882647B0")]
		public static IEEJIDPBMPL FindClosestDefaultUpdateLod(float KPFELFMGNBN)
		{
			return default(IEEJIDPBMPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C810", Offset = "0xA9BC10", VA = "0x180A9C810")]
		public static IEEJIDPBMPL MinUpdateLod(IEEJIDPBMPL NMOEAEGJNNN, IEEJIDPBMPL DIPHMFEBMNA)
		{
			return default(IEEJIDPBMPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8264EB0", Offset = "0x82642B0", VA = "0x188264EB0")]
		public static IEEJIDPBMPL MaxUpdateLod(IEEJIDPBMPL NMOEAEGJNNN, IEEJIDPBMPL DIPHMFEBMNA)
		{
			return default(IEEJIDPBMPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82659E0", Offset = "0x8264DE0", VA = "0x1882659E0")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA9B060", Offset = "0xA9A460", VA = "0x180A9B060", Slot = "11")]
		private bool CPFAEMKBANH()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IHOLEIFCCHH
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool ILJPLLAFBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera JCEIKNKKKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OFFOKCJIMNI COIOBIINMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LOBCKFGOAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	OFFOKCJIMNI BNONPIGBOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform IODNADJFHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LPDOOAPPEAF
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOBMLIBBKBO(INHLNNHCEPE DEJGDIIDCDN, float FLMDAOGEKMO, LDGMPMKAKEN GKMFFJHCJFF = LDGMPMKAKEN.Off);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBDHBFLGDII(INHLNNHCEPE NOJJKJFNCDL);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DEIBGKOHLHL(INHLNNHCEPE DEJGDIIDCDN, LDGMPMKAKEN ICKAFDCBFNF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EHGILADCPJJ<T> : LPDOOAPPEAF where T : class, INHLNNHCEPE
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOBMLIBBKBO(T DEJGDIIDCDN, float FLMDAOGEKMO, LDGMPMKAKEN GKMFFJHCJFF = LDGMPMKAKEN.Off);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOBMLIBBKBO(T DEJGDIIDCDN, Transform AJMGKKHIJKI, float FLMDAOGEKMO, LDGMPMKAKEN GKMFFJHCJFF = LDGMPMKAKEN.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CBDHBFLGDII(T NOJJKJFNCDL);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LOIJAPDHAPD(T DEJGDIIDCDN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface INHLNNHCEPE
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform GANAIKEBLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(IEEJIDPBMPL CNIHMDOKJPK, IEEJIDPBMPL LPBMCEDKMKA);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool NKIKDGHHLIL);
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
