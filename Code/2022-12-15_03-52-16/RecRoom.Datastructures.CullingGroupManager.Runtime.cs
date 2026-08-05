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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, CLNDCOMJDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class EJKJGFOBCNH<T> : LDHEJLNOFCL, global::NOFAIPLGDNK<T>, IPLAPPDCGPJ where T : class, KCLAPJNLDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2913980", Offset = "0x2912380", VA = "0x182913980")]
			internal EJKJGFOBCNH(int AMNIIPLIJMF, float[] DLIBGEDAOON, ELNBMPFHLNL DNMKNBGAALL = ELNBMPFHLNL.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2913930", Offset = "0x2912330", VA = "0x182913930", Slot = "15")]
			public void MFMCNFFMIAP(T LGKNNMGLNIA, float FFODLHNKOLL, CECCAGGGBNA BFKJAGEEEEO = CECCAGGGBNA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2913900", Offset = "0x2912300", VA = "0x182913900", Slot = "16")]
			public void MFMCNFFMIAP(T LGKNNMGLNIA, Transform BLBOCBHMNFG, float FFODLHNKOLL, CECCAGGGBNA BFKJAGEEEEO = CECCAGGGBNA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x29138E0", Offset = "0x29122E0", VA = "0x1829138E0", Slot = "17")]
			public void LECMNFFELEH(T LGKNNMGLNIA, [Optional] float? FFODLHNKOLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x29138C0", Offset = "0x29122C0", VA = "0x1829138C0", Slot = "18")]
			public void EMIFMEAGDDE(T MADBLMMGOPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x29138A0", Offset = "0x29122A0", VA = "0x1829138A0", Slot = "19")]
			public CEAPFNKIAFO DKPBJIEGAPJ(T LGKNNMGLNIA)
			{
				return default(CEAPFNKIAFO);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2913960", Offset = "0x2912360", VA = "0x182913960", Slot = "20")]
			public bool OEBKBHCCBKH(T LGKNNMGLNIA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2913880", Offset = "0x2912280", VA = "0x182913880", Slot = "21")]
			public void CJOGBMHCIKK(T LGKNNMGLNIA, CECCAGGGBNA NENHIJHKOLI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class LDHEJLNOFCL : IDisposable, IPLAPPDCGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum ELNBMPFHLNL : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class GHCLKPFCHCK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public KCLAPJNLDEK BDILHMAFPHD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public CECCAGGGBNA DMEGBOOKHKN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action DMJBOOKLOHK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool GFHLPPADNGI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int DNFPKCNMAKE;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
				public GHCLKPFCHCK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class AFLBLLJEBPC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public LDHEJLNOFCL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public GHCLKPFCHCK trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
				public AFLBLLJEBPC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int BAANMBMIJMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int AMNIIPLIJMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int PLJBLNIOMOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool GLPBIJFMILI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup LCMDEKCOFAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] BEAGDNMIKEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] FNCABCLKGEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly NKJDCEEFMAK NBJJAAKBODP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<KCLAPJNLDEK, int> LEADKOPNJLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, GHCLKPFCHCK> NDMEACOHNNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly ELNBMPFHLNL DNMKNBGAALL;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int LLFNNPACIND
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675A40", VA = "0x180677040", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int LOLMGFJPBPN
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x68D790", Offset = "0x68C190", VA = "0x18068D790", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x605A4B0", Offset = "0x6058EB0", VA = "0x18605A4B0")]
			internal LDHEJLNOFCL(int AMNIIPLIJMF, float[] DLIBGEDAOON, ELNBMPFHLNL DNMKNBGAALL = ELNBMPFHLNL.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x605A180", Offset = "0x6058B80", VA = "0x18605A180")]
			public void NGMCCGPCOPN(bool CNFIBAHADNG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x60598A0", Offset = "0x60582A0", VA = "0x1860598A0", Slot = "7")]
			public CEAPFNKIAFO HNHHADBNINI(float JDMNPNJKCII)
			{
				return default(CEAPFNKIAFO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6059F70", Offset = "0x6058970", VA = "0x186059F70", Slot = "8")]
			public void MFMCNFFMIAP(KCLAPJNLDEK LGKNNMGLNIA, float FFODLHNKOLL, CECCAGGGBNA BFKJAGEEEEO = CECCAGGGBNA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6059B20", Offset = "0x6058520", VA = "0x186059B20", Slot = "9")]
			public void MFMCNFFMIAP(KCLAPJNLDEK LGKNNMGLNIA, Transform BLBOCBHMNFG, float FFODLHNKOLL, CECCAGGGBNA BFKJAGEEEEO = CECCAGGGBNA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6058450", Offset = "0x6056E50", VA = "0x186058450")]
			public void BDFAFOODPHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6059AA0", Offset = "0x60584A0", VA = "0x186059AA0", Slot = "10")]
			public void LECMNFFELEH(KCLAPJNLDEK LGKNNMGLNIA, [Optional] float? FFODLHNKOLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x605A1B0", Offset = "0x6058BB0", VA = "0x18605A1B0")]
			private void NHHPDHDKMED(int EBBLFLFCHFB, [Optional] float? FFODLHNKOLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6058EA0", Offset = "0x60578A0", VA = "0x186058EA0", Slot = "11")]
			public void EMIFMEAGDDE(KCLAPJNLDEK MADBLMMGOPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6058AF0", Offset = "0x60574F0", VA = "0x186058AF0", Slot = "12")]
			public CEAPFNKIAFO DKPBJIEGAPJ(KCLAPJNLDEK LGKNNMGLNIA)
			{
				return default(CEAPFNKIAFO);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x605A340", Offset = "0x6058D40", VA = "0x18605A340", Slot = "13")]
			public bool OEBKBHCCBKH(KCLAPJNLDEK LGKNNMGLNIA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6058A00", Offset = "0x6057400", VA = "0x186058A00", Slot = "14")]
			public void CJOGBMHCIKK(KCLAPJNLDEK LGKNNMGLNIA, CECCAGGGBNA POOJONKABLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6058C00", Offset = "0x6057600", VA = "0x186058C00", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x60585D0", Offset = "0x6056FD0", VA = "0x1860585D0")]
			private void BPNIGOACLMG(GHCLKPFCHCK DGEHFILIIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6059610", Offset = "0x6058010", VA = "0x186059610")]
			private void HNDMFFIMHKE(GHCLKPFCHCK DGEHFILIIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6058990", Offset = "0x6057390", VA = "0x186058990")]
			private void CGONMFMCBKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x605A440", Offset = "0x6058E40", VA = "0x18605A440")]
			private void OFIHJOFACLI(float MNNKIKNAMKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x605A310", Offset = "0x6058D10", VA = "0x18605A310")]
			private void NMCBOHNGALO(GHCLKPFCHCK DGEHFILIIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6059A90", Offset = "0x6058490", VA = "0x186059A90")]
			private void JFPPFKACBMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6059A80", Offset = "0x6058480", VA = "0x186059A80")]
			private void JAIHIFHLABF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x60592D0", Offset = "0x6057CD0", VA = "0x1860592D0")]
			private void GNJAPGNLIIN(CullingGroupEvent ECFDCEGONBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x605A000", Offset = "0x6058A00", VA = "0x18605A000")]
			private void MKMBBDDEEOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct DHNMMOPCNJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort PLOABLDHDEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type IMOOLIOPHJA;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float JIHNCCOOPHB = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float DNIFGHBGJCP = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float HAIHAJEKNGB = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float DCNHCOHEDPM = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float NGKIHEJFPED = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float GDGLHJNFLFO = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float JKHNIHMCBPK = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<DHNMMOPCNJM, LDHEJLNOFCL> KJJPLPALEMJ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable JGCHHOAAODJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable NMJGFKNNEOP;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static FHIFKLKAEJA KNEJLHGBCEO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static FHIFKLKAEJA DCPHNLELBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly FHIFKLKAEJA CPBEOCNLHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly FHIFKLKAEJA AIGANIFGAFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly FHIFKLKAEJA AJJELBKMJDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private PFHLOLIKNNP EFGDOKJKFKG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool CNFIBAHADNG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public FHIFKLKAEJA OKEGIKGFJNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public FHIFKLKAEJA IDALGJCFHNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public FHIFKLKAEJA KLOOANNADKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool AGNKCFCGOPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x17CAD90", Offset = "0x17C9790", VA = "0x1817CAD90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BJDBKEAOKMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675A30", VA = "0x180677030", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x812720", Offset = "0x811120", VA = "0x180812720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x60570E0", Offset = "0x6055AE0", VA = "0x1860570E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xFECFE0", Offset = "0xFEB9E0", VA = "0x180FECFE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60579C0", Offset = "0x60563C0", VA = "0x1860579C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60571B0", Offset = "0x6055BB0", VA = "0x1860571B0")]
		private void FADLPLNODAD(Scene FMEDCFLNIMM, LoadSceneMode OLBBMHHLPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60578E0", Offset = "0x60562E0", VA = "0x1860578E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6057C10", Offset = "0x6056610", VA = "0x186057C10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60573B0", Offset = "0x6055DB0", VA = "0x1860573B0")]
		private void GEPMHGPGCMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60579E0", Offset = "0x60563E0", VA = "0x1860579E0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6057760", Offset = "0x6056160", VA = "0x186057760")]
		private void NHBJODOJFMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6057550", Offset = "0x6055F50", VA = "0x186057550")]
		public IPLAPPDCGPJ GetOrCreateCullingGroup(Type CHNIOECHFGA, int OAJHPCEENCA, ushort OAPBFCJJEPG = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1C46FD0", Offset = "0x1C459D0", VA = "0x181C46FD0")]
		public global::NOFAIPLGDNK<T> GetOrCreateCullingGroup<T>(int OAJHPCEENCA, ushort OAPBFCJJEPG = 0) where T : class, KCLAPJNLDEK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6056F40", Offset = "0x6055940", VA = "0x186056F40")]
		private IPLAPPDCGPJ AIPGIJNOLBD(Type CHNIOECHFGA, int OAJHPCEENCA, float[] DLIBGEDAOON, ushort OAPBFCJJEPG = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1C46DA0", Offset = "0x1C457A0", VA = "0x181C46DA0")]
		private global::NOFAIPLGDNK<T> AIPGIJNOLBD<T>(int OAJHPCEENCA, float[] DLIBGEDAOON, ushort OAPBFCJJEPG = 0) where T : class, KCLAPJNLDEK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6057210", Offset = "0x6055C10", VA = "0x186057210")]
		public static CEAPFNKIAFO FindClosestDefaultUpdateLod(float EOOOIHJBKKH)
		{
			return default(CEAPFNKIAFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6057750", Offset = "0x6056150", VA = "0x186057750")]
		public static CEAPFNKIAFO MinUpdateLod(CEAPFNKIAFO KKIEHJCGDHO, CEAPFNKIAFO PEINDGHBDIC)
		{
			return default(CEAPFNKIAFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6057740", Offset = "0x6056140", VA = "0x186057740")]
		public static CEAPFNKIAFO MaxUpdateLod(CEAPFNKIAFO KKIEHJCGDHO, CEAPFNKIAFO PEINDGHBDIC)
		{
			return default(CEAPFNKIAFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6058040", Offset = "0x6056A40", VA = "0x186058040")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NKJDCEEFMAK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BEOCNFKOGBN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera PILHKBDDCLO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FHIFKLKAEJA JJGKHCKIFKI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool LDOFABNPNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FHIFKLKAEJA CGLGGEEODKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform GPOGAPAKPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IPLAPPDCGPJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int LLFNNPACIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int LOLMGFJPBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CEAPFNKIAFO HNHHADBNINI(float JDMNPNJKCII);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MFMCNFFMIAP(KCLAPJNLDEK LGKNNMGLNIA, float FFODLHNKOLL, CECCAGGGBNA BFKJAGEEEEO = CECCAGGGBNA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MFMCNFFMIAP(KCLAPJNLDEK LGKNNMGLNIA, Transform BLBOCBHMNFG, float FFODLHNKOLL, CECCAGGGBNA BFKJAGEEEEO = CECCAGGGBNA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LECMNFFELEH(KCLAPJNLDEK LGKNNMGLNIA, [Optional] float? FFODLHNKOLL);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EMIFMEAGDDE(KCLAPJNLDEK MADBLMMGOPC);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CEAPFNKIAFO DKPBJIEGAPJ(KCLAPJNLDEK LGKNNMGLNIA);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OEBKBHCCBKH(KCLAPJNLDEK LGKNNMGLNIA);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CJOGBMHCIKK(KCLAPJNLDEK LGKNNMGLNIA, CECCAGGGBNA NENHIJHKOLI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NOFAIPLGDNK<T> : IPLAPPDCGPJ where T : class, KCLAPJNLDEK
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFMCNFFMIAP(T LGKNNMGLNIA, float FFODLHNKOLL, CECCAGGGBNA BFKJAGEEEEO = CECCAGGGBNA.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFMCNFFMIAP(T LGKNNMGLNIA, Transform BLBOCBHMNFG, float FFODLHNKOLL, CECCAGGGBNA BFKJAGEEEEO = CECCAGGGBNA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LECMNFFELEH(T LGKNNMGLNIA, [Optional] float? FFODLHNKOLL);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EMIFMEAGDDE(T MADBLMMGOPC);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CEAPFNKIAFO DKPBJIEGAPJ(T LGKNNMGLNIA);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OEBKBHCCBKH(T LGKNNMGLNIA);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CJOGBMHCIKK(T LGKNNMGLNIA, CECCAGGGBNA NENHIJHKOLI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KCLAPJNLDEK
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform HJLACGOIJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(CEAPFNKIAFO HPKJNHPLCPI, CEAPFNKIAFO FBLLAOEFGAF);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool MDMFNFBFLBD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum CECCAGGGBNA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum CEAPFNKIAFO
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
public class IPILBKCGDLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private CEAPFNKIAFO MJBMGGEOKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private CEAPFNKIAFO CGFBNEMNBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, CEAPFNKIAFO> LPAANALMCNO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool JBJJGGGFHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6058310", Offset = "0x6056D10", VA = "0x186058310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public CEAPFNKIAFO IPOLGCJMADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675A40", VA = "0x180677040")]
		get
		{
			return default(CEAPFNKIAFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public CEAPFNKIAFO HNPMIJGFALH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x68D790", Offset = "0x68C190", VA = "0x18068D790")]
		get
		{
			return default(CEAPFNKIAFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6058360", Offset = "0x6056D60", VA = "0x186058360")]
	public bool OGKJCDPEKGH(object HKLDIENGNNB, CEAPFNKIAFO MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6058150", Offset = "0x6056B50", VA = "0x186058150")]
	public bool BJHOJHPKHGP(object HKLDIENGNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60581B0", Offset = "0x6056BB0", VA = "0x1860581B0")]
	private bool NLDOLLHKHHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60583D0", Offset = "0x6056DD0", VA = "0x1860583D0")]
	public IPILBKCGDLL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x605ABC0", Offset = "0x60595C0", VA = "0x18605ABC0")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x605A870", Offset = "0x6059270", VA = "0x18605A870")]
	public static string FCKPDHOJNPG(byte[] PPJLGCLGPJE, bool KMFFDGBHCMI)
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
