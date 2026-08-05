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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, EKBGNJNPMMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class LCEGEDCKKLL : IDisposable, DKMNFMFAHDI
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int IGLJOOABPKD
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(Slot = "9")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int KEOILNMDNIJ
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void Dispose();

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void CCJNEPMOMEG();

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void ANMLNOFMOGE(bool DJKLPNFDCBF);

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			protected LCEGEDCKKLL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class DBCCMNCIIJI<T> : LCEGEDCKKLL, global::JNEDMHCPCHH<T>, DKMNFMFAHDI where T : HKGKBLNBNHN
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum GPNILAPNAJP : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class INIFKMHGGMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T BDNPBKKLIGK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public POOALKPGOII HLIBMPLFNCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action PNAKHEKPMGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool BJNEHMJPABC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int PAOIHHHPKNO;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
				public INIFKMHGGMH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class GIDLGCDPFJA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public DBCCMNCIIJI<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public INIFKMHGGMH trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
				public GIDLGCDPFJA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int NFNECOOLJKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int PCJDJPMEMOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int BEMMAFOHLHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool KNBPMOOFAFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup CPLPJNOEOJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] BKJIEOFGHMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] EHBIMDFPJLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly MPJCKLAHNBC NOMIILNDOJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> GPCDJHNNIHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, INIFKMHGGMH> KDACJHKAHED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly GPNILAPNAJP FFKPKMFOOAM;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int IGLJOOABPKD
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x5ECED0", Offset = "0x5EBAD0", VA = "0x1805ECED0", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int KEOILNMDNIJ
			{
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x610710", Offset = "0x60F310", VA = "0x180610710", Slot = "10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2191870", Offset = "0x2190470", VA = "0x182191870")]
			internal DBCCMNCIIJI(int PCJDJPMEMOP, float[] OLBPKPBEBPC, GPNILAPNAJP FFKPKMFOOAM = GPNILAPNAJP.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x218FA80", Offset = "0x218E680", VA = "0x18218FA80", Slot = "11")]
			public override void ANMLNOFMOGE(bool DJKLPNFDCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2190350", Offset = "0x218EF50", VA = "0x182190350", Slot = "12")]
			public OOHMGLKECOD JKICAIBDKCB(float GJLJKEEJFCK)
			{
				return default(OOHMGLKECOD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2190FA0", Offset = "0x218FBA0", VA = "0x182190FA0", Slot = "13")]
			public void LFMPFEAFMAL(T EBMPLNBFAKM, float CNFMGLHCLHK, POOALKPGOII BPCHLKOEKGD = POOALKPGOII.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2190B20", Offset = "0x218F720", VA = "0x182190B20", Slot = "14")]
			public void LFMPFEAFMAL(T EBMPLNBFAKM, Transform IDGCCCAHKON, float CNFMGLHCLHK, POOALKPGOII BPCHLKOEKGD = POOALKPGOII.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x218FBF0", Offset = "0x218E7F0", VA = "0x18218FBF0", Slot = "8")]
			public override void CCJNEPMOMEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x21901D0", Offset = "0x218EDD0", VA = "0x1821901D0", Slot = "15")]
			public void HNPIKAFEICA(T EBMPLNBFAKM, [Optional] float? CNFMGLHCLHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x218FAB0", Offset = "0x218E6B0", VA = "0x18218FAB0")]
			private void CBPLHFEAIHH(int HIANDEDCLIF, [Optional] float? CNFMGLHCLHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x21903B0", Offset = "0x218EFB0", VA = "0x1821903B0", Slot = "16")]
			public void JNIHJKFEBJI(T ABBABIFMGAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2191350", Offset = "0x218FF50", VA = "0x182191350", Slot = "17")]
			public OOHMGLKECOD OFBIIAGOMFD(T EBMPLNBFAKM)
			{
				return default(OOHMGLKECOD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2190250", Offset = "0x218EE50", VA = "0x182190250", Slot = "18")]
			public bool IEPEFFOBANP(T EBMPLNBFAKM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2191470", Offset = "0x2190070", VA = "0x182191470", Slot = "19")]
			public void OJOBLGHKKFD(T EBMPLNBFAKM, POOALKPGOII MLDLDKMHDNM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x218FD70", Offset = "0x218E970", VA = "0x18218FD70", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2190770", Offset = "0x218F370", VA = "0x182190770")]
			private void LFMGDMBHNKM(INIFKMHGGMH BGOHLLEMNNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x2191580", Offset = "0x2190180", VA = "0x182191580")]
			private void OOIDGJAIAGL(INIFKMHGGMH BGOHLLEMNNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x21900F0", Offset = "0x218ECF0", VA = "0x1821900F0")]
			private void HBLKOOJLCOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2191800", Offset = "0x2190400", VA = "0x182191800")]
			private void PAJODKHFNIK(float NEPPBJKDPEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2190190", Offset = "0x218ED90", VA = "0x182190190")]
			private void HHIFGIEBGCN(INIFKMHGGMH BGOHLLEMNNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2190750", Offset = "0x218F350", VA = "0x182190750")]
			private void LBOOELHJLAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2190160", Offset = "0x218ED60", VA = "0x182190160")]
			private void HDEGEEBJCPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2191040", Offset = "0x218FC40", VA = "0x182191040")]
			private void NLEPPINDIJA(CullingGroupEvent JPHNPKOBDNG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x218F910", Offset = "0x218E510", VA = "0x18218F910")]
			private void AFFCEJAKODH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct OKJMDBADKMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort ADFFGKEKGAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type GMAJMKFGOMN;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float LJNDAIHFFJK = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float OFJJCJADLKB = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float LGIBIBOOCGC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float CLFLCJAPDOI = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float MLFJEFNDLAO = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float JNAELKBLCEI = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float BMACKPPGKKM = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<OKJMDBADKMI, LCEGEDCKKLL> NDEJKGPPALO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable IOFHJBJPHGA;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable OOMKJOBHNGA;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static DJNHHHNCJAC GGPMEHHCIHH;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static DJNHHHNCJAC CMLEEDPLOKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly DJNHHHNCJAC DHLFDPEAGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DJNHHHNCJAC MDEAOIKOKPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DJNHHHNCJAC KPDHPOMHLFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GECAAOLGCPI LGEMEOJCECO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool DJKLPNFDCBF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DJNHHHNCJAC OEDKAKMGFCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public DJNHHHNCJAC HLIBHJMHOMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DJNHHHNCJAC BIPKGGPKMMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool GDCGIJHJOCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x16A9590", Offset = "0x16A8190", VA = "0x1816A9590", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool EEBACHPNCLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7DDE70", Offset = "0x7DCA70", VA = "0x1807DDE70", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7DDEF0", Offset = "0x7DCAF0", VA = "0x1807DDEF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5893D40", Offset = "0x5892940", VA = "0x185893D40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE74370", Offset = "0xE72F70", VA = "0x180E74370")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x58944A0", Offset = "0x58930A0", VA = "0x1858944A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5893FD0", Offset = "0x5892BD0", VA = "0x185893FD0")]
		private void LAFDCCMANDN(Scene CKMHEJALMFP, LoadSceneMode FALFKKIACAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x58943F0", Offset = "0x5892FF0", VA = "0x1858943F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5894720", Offset = "0x5893320", VA = "0x185894720")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5894250", Offset = "0x5892E50", VA = "0x185894250")]
		private void OJPJDNNENEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x58944C0", Offset = "0x58930C0", VA = "0x1858944C0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x58940F0", Offset = "0x5892CF0", VA = "0x1858940F0")]
		private void NCFJGJLIFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x20C4F70", Offset = "0x20C3B70", VA = "0x1820C4F70")]
		public global::JNEDMHCPCHH<T> GetOrCreateCullingGroup<T>(int HLHBCEKFBCH, ushort ANGOHNFPEOI = 0) where T : HKGKBLNBNHN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x20C5020", Offset = "0x20C3C20", VA = "0x1820C5020")]
		private global::JNEDMHCPCHH<T> NHOAOADGLIC<T>(int HLHBCEKFBCH, float[] OLBPKPBEBPC, ushort ANGOHNFPEOI = 0) where T : HKGKBLNBNHN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5893DE0", Offset = "0x58929E0", VA = "0x185893DE0")]
		public static OOHMGLKECOD FindClosestDefaultUpdateLod(float LMMGHFGDCDP)
		{
			return default(OOHMGLKECOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5894090", Offset = "0x5892C90", VA = "0x185894090")]
		public static OOHMGLKECOD MinUpdateLod(OOHMGLKECOD ENODBCOBBON, OOHMGLKECOD FKCILPHEPHM)
		{
			return default(OOHMGLKECOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5894030", Offset = "0x5892C30", VA = "0x185894030")]
		public static OOHMGLKECOD MaxUpdateLod(OOHMGLKECOD ENODBCOBBON, OOHMGLKECOD FKCILPHEPHM)
		{
			return default(OOHMGLKECOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x58949A0", Offset = "0x58935A0", VA = "0x1858949A0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MPJCKLAHNBC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CBABLFGPJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera DMAFNDENOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DJNHHHNCJAC BCPFPGPHKEC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool GOABLJGDAOE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	DJNHHHNCJAC LFNPNDMLMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform GPEEMFGIJKP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DKMNFMFAHDI
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int IGLJOOABPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int KEOILNMDNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JNEDMHCPCHH<T> : DKMNFMFAHDI where T : HKGKBLNBNHN
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OOHMGLKECOD JKICAIBDKCB(float GJLJKEEJFCK);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFMPFEAFMAL(T EBMPLNBFAKM, float CNFMGLHCLHK, POOALKPGOII BPCHLKOEKGD = POOALKPGOII.Off);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFMPFEAFMAL(T EBMPLNBFAKM, Transform IDGCCCAHKON, float CNFMGLHCLHK, POOALKPGOII BPCHLKOEKGD = POOALKPGOII.Off);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNPIKAFEICA(T EBMPLNBFAKM, [Optional] float? CNFMGLHCLHK);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNIHJKFEBJI(T ABBABIFMGAM);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OOHMGLKECOD OFBIIAGOMFD(T EBMPLNBFAKM);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IEPEFFOBANP(T EBMPLNBFAKM);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OJOBLGHKKFD(T EBMPLNBFAKM, POOALKPGOII FLGNEABDAFL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HKGKBLNBNHN
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform BHPNFBEEMHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(OOHMGLKECOD HNCLMLCCILE, OOHMGLKECOD PDDFFFBGIFH);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool GDHKFNDONIB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum POOALKPGOII : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum OOHMGLKECOD
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
public class BIBHBMMLAJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private OOHMGLKECOD BBPNPMFNJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private OOHMGLKECOD PFDMIIOLPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, OOHMGLKECOD> DIPDALMFPIC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool AHFDEKHIGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5893C70", Offset = "0x5892870", VA = "0x185893C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public OOHMGLKECOD KPEOMBEKFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECED0", Offset = "0x5EBAD0", VA = "0x1805ECED0")]
		get
		{
			return default(OOHMGLKECOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public OOHMGLKECOD JOINDKGIBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x610710", Offset = "0x60F310", VA = "0x180610710")]
		get
		{
			return default(OOHMGLKECOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5893A30", Offset = "0x5892630", VA = "0x185893A30")]
	public bool GDKIADOKKKE(object KJKNLGILOFJ, OOHMGLKECOD KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5893C10", Offset = "0x5892810", VA = "0x185893C10")]
	public bool HNCEHIKFEKB(object KJKNLGILOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5893AA0", Offset = "0x58926A0", VA = "0x185893AA0")]
	private bool GEKODADFELA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5893CC0", Offset = "0x58928C0", VA = "0x185893CC0")]
	public BIBHBMMLAJL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GGMACBOFMDA
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] HNILJCLIGCF;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int MHDNNHPLAAF;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int JKLLCIMILJG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger JLHIBEKHFGK;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GGMACBOFMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5894DC0", Offset = "0x58939C0", VA = "0x185894DC0")]
	private static string PBMOEILNFIF(byte[] EDLPJGEPJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5894A90", Offset = "0x5893690", VA = "0x185894A90")]
	public static string EICDLCDOCAE(byte[] IAIFCDOPKGE, bool LFDDCGMHEMH)
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
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
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
