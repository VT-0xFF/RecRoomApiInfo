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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, BJPHJOMINEO
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class LOBMBABHNDE<T> : HOHHIKCKIIJ, BIKJMNMCIJJ<T>, BMACFOJPCPM where T : class, EDAFEFMMNAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3928FA0", Offset = "0x39277A0", VA = "0x183928FA0")]
			internal LOBMBABHNDE(int FONFALKDPAD, float[] BNAGIMJBMPD, FAKCGMKLKHK LBLCFOAIHBD = FAKCGMKLKHK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3928F20", Offset = "0x3927720", VA = "0x183928F20", Slot = "10")]
			public void BONJGFNEKBE(T CBBCDNDPNHF, float PNEBFNHCLKM, GOBOFKKAMEO EMAJDOKHHPB = GOBOFKKAMEO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3928F50", Offset = "0x3927750", VA = "0x183928F50", Slot = "11")]
			public void BONJGFNEKBE(T CBBCDNDPNHF, Transform BPOMEGPOGJN, float PNEBFNHCLKM, GOBOFKKAMEO EMAJDOKHHPB = GOBOFKKAMEO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3928F80", Offset = "0x3927780", VA = "0x183928F80", Slot = "12")]
			public void PJFBCFIPABD(T MJDHLMPNBLB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class HOHHIKCKIIJ : IDisposable, BMACFOJPCPM
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum FAKCGMKLKHK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class KBJNJLILFHK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public EDAFEFMMNAG IOCOFAMFJOP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public GOBOFKKAMEO BPGEADNPJJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action IBEBHGHGLNE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool GDMKEDBAHNO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int NEMCGPAIDHF;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
				public KBJNJLILFHK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class MBIEGDNBMFK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public HOHHIKCKIIJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public KBJNJLILFHK trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
				public MBIEGDNBMFK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5CA8590", Offset = "0x5CA6D90", VA = "0x185CA8590")]
				internal void DIBALJGHLCJ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int NOFHLFIJOKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int FONFALKDPAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int NCDCDGCBIJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool CBPCANBMLCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup FEINMOBOBHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] PFLPBIHJCAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] KLDLPMFFPII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly GEPDFCJOJGN HGOFPLJJILB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<EDAFEFMMNAG, int> KNEJPMHILMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, KBJNJLILFHK> AOIBJCGOPFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly FAKCGMKLKHK LBLCFOAIHBD;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool GCCBIPKFFMG
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x3B881D0", Offset = "0x3B869D0", VA = "0x183B881D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x36245E0", Offset = "0x3622DE0", VA = "0x1836245E0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5CA81A0", Offset = "0x5CA69A0", VA = "0x185CA81A0")]
			internal HOHHIKCKIIJ(int FONFALKDPAD, float[] BNAGIMJBMPD, FAKCGMKLKHK LBLCFOAIHBD = FAKCGMKLKHK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7940", Offset = "0x5CA6140", VA = "0x185CA7940")]
			public void JONONIFLLPH(bool FMGPAPMCAKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5CA6D80", Offset = "0x5CA5580", VA = "0x185CA6D80", Slot = "6")]
			public void BONJGFNEKBE(EDAFEFMMNAG CBBCDNDPNHF, float PNEBFNHCLKM, GOBOFKKAMEO EMAJDOKHHPB = GOBOFKKAMEO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5CA6990", Offset = "0x5CA5190", VA = "0x185CA6990", Slot = "9")]
			public void BONJGFNEKBE(EDAFEFMMNAG CBBCDNDPNHF, Transform BPOMEGPOGJN, float PNEBFNHCLKM, GOBOFKKAMEO EMAJDOKHHPB = GOBOFKKAMEO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5CA76F0", Offset = "0x5CA5EF0", VA = "0x185CA76F0")]
			public void GAADDIEOLKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7C90", Offset = "0x5CA6490", VA = "0x185CA7C90")]
			private void OAGBLADHMIC(int LFEFGCGCIAG, [Optional] float? PNEBFNHCLKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7DC0", Offset = "0x5CA65C0", VA = "0x185CA7DC0", Slot = "7")]
			public void PJFBCFIPABD(EDAFEFMMNAG MJDHLMPNBLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7850", Offset = "0x5CA6050", VA = "0x185CA7850", Slot = "8")]
			public void HJEOCMAAJJE(EDAFEFMMNAG CBBCDNDPNHF, GOBOFKKAMEO NMKLGGCGDPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7430", Offset = "0x5CA5C30", VA = "0x185CA7430", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5CA6600", Offset = "0x5CA4E00", VA = "0x185CA6600")]
			private void AKKPPENJKKP(KBJNJLILFHK PJBMENGFNCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7130", Offset = "0x5CA5930", VA = "0x185CA7130")]
			private void CNMJNNCJPNA(KBJNJLILFHK PJBMENGFNCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7C30", Offset = "0x5CA6430", VA = "0x185CA7C30")]
			private void NOGHDNOBBGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5CA73D0", Offset = "0x5CA5BD0", VA = "0x185CA73D0")]
			private void DHBPCCJFDLA(float OEPJOFDPCAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7AF0", Offset = "0x5CA62F0", VA = "0x185CA7AF0")]
			private void NNNMFPBCDPF(KBJNJLILFHK PJBMENGFNCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7970", Offset = "0x5CA6170", VA = "0x185CA7970")]
			private void KDPKGPPHAFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7840", Offset = "0x5CA6040", VA = "0x185CA7840")]
			private void HEEKHHAOMCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5CA6E10", Offset = "0x5CA5610", VA = "0x185CA6E10")]
			private void CLFDJPBHDMJ(CullingGroupEvent AANCPODNOHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7980", Offset = "0x5CA6180", VA = "0x185CA7980")]
			private void MGNCBGKBPKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct IOJPFOMPKMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort JLDLFPFALJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type NECLPPEDIBL;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float KBAKOMMAGKK = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float IJMCJPOPEJO = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float OLDCDNCFIJA = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float HKBLAMGCFKG = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float HJOIHFLEDNE = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float NNJPMBGDANK = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float KPBCNNJADAH = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<IOJPFOMPKMO, HOHHIKCKIIJ> BMCNINHDNNN;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable LPFBNFBBJEC;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable EHCACEPFMPK;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static BJPMGBAMGNN JDNHEFKCHOO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static BJPMGBAMGNN NBALGCKINMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly BJPMGBAMGNN IIHMBDGLJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly BJPMGBAMGNN PBIDDDNMAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly BJPMGBAMGNN OBBGGAMBGKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GCEJIALBLON DMAFEEOINAE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool FMGPAPMCAKG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public BJPMGBAMGNN IFFAFAEJLCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BJPMGBAMGNN MEALMOHGPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public BJPMGBAMGNN PGBMMELPNMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool FNCJLBNCPGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBB1440", Offset = "0xBAFC40", VA = "0x180BB1440", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool EEPJODLGEDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B7C00", Offset = "0x7B6400", VA = "0x1807B7C00", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7B8160", Offset = "0x7B6960", VA = "0x1807B8160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5500", Offset = "0x5CA3D00", VA = "0x185CA5500", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5E30", Offset = "0x5CA4630", VA = "0x185CA5E30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5E10", Offset = "0x5CA4610", VA = "0x185CA5E10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5AA0", Offset = "0x5CA42A0", VA = "0x185CA5AA0")]
		private void GAAKAEDDBGB(Scene AGEHAEDLOFL, LoadSceneMode FDFIAAFCBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5D30", Offset = "0x5CA4530", VA = "0x185CA5D30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA6090", Offset = "0x5CA4890", VA = "0x185CA6090")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CA55C0", Offset = "0x5CA3DC0", VA = "0x185CA55C0")]
		private void EHJOFLBGABF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5E50", Offset = "0x5CA4650", VA = "0x185CA5E50")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5380", Offset = "0x5CA3B80", VA = "0x185CA5380")]
		private void AEIPLMLEAGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5B00", Offset = "0x5CA4300", VA = "0x185CA5B00")]
		public BMACFOJPCPM GetOrCreateCullingGroup(Type GHHGFCJFAMO, int CKFIJCBFCGJ, ushort JDMPEMIPEIL = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x220EEA0", Offset = "0x220D6A0", VA = "0x18220EEA0")]
		public BIKJMNMCIJJ<T> GetOrCreateCullingGroup<T>(int CKFIJCBFCGJ, ushort JDMPEMIPEIL = 0) where T : class, EDAFEFMMNAG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5760", Offset = "0x5CA3F60", VA = "0x185CA5760")]
		private BMACFOJPCPM EJPKNPOEFHP(Type GHHGFCJFAMO, int CKFIJCBFCGJ, float[] BNAGIMJBMPD, ushort JDMPEMIPEIL = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x220EC30", Offset = "0x220D430", VA = "0x18220EC30")]
		private BIKJMNMCIJJ<T> EJPKNPOEFHP<T>(int CKFIJCBFCGJ, float[] BNAGIMJBMPD, ushort JDMPEMIPEIL = 0) where T : class, EDAFEFMMNAG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5940", Offset = "0x5CA4140", VA = "0x185CA5940")]
		public static LMALNIIPHAC FindClosestDefaultUpdateLod(float OIILHBKNHEC)
		{
			return default(LMALNIIPHAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x78FFF0", Offset = "0x78E7F0", VA = "0x18078FFF0")]
		public static LMALNIIPHAC MinUpdateLod(LMALNIIPHAC IKLGJIPIAAD, LMALNIIPHAC ODFHDLMLHMO)
		{
			return default(LMALNIIPHAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5D20", Offset = "0x5CA4520", VA = "0x185CA5D20")]
		public static LMALNIIPHAC MaxUpdateLod(LMALNIIPHAC IKLGJIPIAAD, LMALNIIPHAC ODFHDLMLHMO)
		{
			return default(LMALNIIPHAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CA6500", Offset = "0x5CA4D00", VA = "0x185CA6500")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GEPDFCJOJGN
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool CEMKMJEGPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera GBBOPMDLPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BJPMGBAMGNN NOAPOPGIELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool HJCIOKCLFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BJPMGBAMGNN JFDIDIMAOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform MAGIEDIMPID
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BMACFOJPCPM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool GCCBIPKFFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BONJGFNEKBE(EDAFEFMMNAG CBBCDNDPNHF, float PNEBFNHCLKM, GOBOFKKAMEO EMAJDOKHHPB = GOBOFKKAMEO.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJFBCFIPABD(EDAFEFMMNAG MJDHLMPNBLB);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HJEOCMAAJJE(EDAFEFMMNAG CBBCDNDPNHF, GOBOFKKAMEO IDBLKDBCFIJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BIKJMNMCIJJ<T> : BMACFOJPCPM where T : class, EDAFEFMMNAG
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BONJGFNEKBE(T CBBCDNDPNHF, float PNEBFNHCLKM, GOBOFKKAMEO EMAJDOKHHPB = GOBOFKKAMEO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BONJGFNEKBE(T CBBCDNDPNHF, Transform BPOMEGPOGJN, float PNEBFNHCLKM, GOBOFKKAMEO EMAJDOKHHPB = GOBOFKKAMEO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJFBCFIPABD(T MJDHLMPNBLB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EDAFEFMMNAG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform CPMBJLDHCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(LMALNIIPHAC ANBIOJLLMHI, LMALNIIPHAC BMJMPKJOAMG);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool GHGJICDKEHL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum GOBOFKKAMEO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum LMALNIIPHAC
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
