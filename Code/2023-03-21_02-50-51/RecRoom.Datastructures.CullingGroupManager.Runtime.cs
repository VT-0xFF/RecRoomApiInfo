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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, EELELJHIFAH
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class DJAKJOHKGIM<T> : IPFJKMLJEPB, global::DNKDPHBLGNC<T>, JCEGNPJGMMH where T : class, PCOININKFBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4D40", Offset = "0x2BB3540", VA = "0x182BB4D40")]
			internal DJAKJOHKGIM(int CHJIBBHLCPC, float[] MOGIAENNNHK, EDHNIKMODAB GBOCMCAGPEB = EDHNIKMODAB.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4CA0", Offset = "0x2BB34A0", VA = "0x182BB4CA0", Slot = "15")]
			public void LGCDELLOPGJ(T BFHAMCLNCKB, float LFHCJFFBBNC, BCFIMCBGHIE LFEJGIPJJAO = BCFIMCBGHIE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4CD0", Offset = "0x2BB34D0", VA = "0x182BB4CD0", Slot = "16")]
			public void LGCDELLOPGJ(T BFHAMCLNCKB, Transform KAEEBKHEPFM, float LFHCJFFBBNC, BCFIMCBGHIE LFEJGIPJJAO = BCFIMCBGHIE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4D00", Offset = "0x2BB3500", VA = "0x182BB4D00", Slot = "17")]
			public void NJEDKBEDLCB(T BFHAMCLNCKB, [Optional] float? LFHCJFFBBNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4C40", Offset = "0x2BB3440", VA = "0x182BB4C40", Slot = "18")]
			public void ALIFOBNBCOA(T BGGPOFIMIJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4C60", Offset = "0x2BB3460", VA = "0x182BB4C60", Slot = "19")]
			public EPPGHKHCLCO EICOCBDDKML(T BFHAMCLNCKB)
			{
				return default(EPPGHKHCLCO);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4C80", Offset = "0x2BB3480", VA = "0x182BB4C80", Slot = "20")]
			public bool GDPCDBFINIE(T BFHAMCLNCKB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4D20", Offset = "0x2BB3520", VA = "0x182BB4D20", Slot = "21")]
			public void OKHGCKKGIBE(T BFHAMCLNCKB, BCFIMCBGHIE MCHCJHKAKAG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class IPFJKMLJEPB : IDisposable, JCEGNPJGMMH
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum EDHNIKMODAB : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class EJCLEDLJBIJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public PCOININKFBB DGHNMGFNHNE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public BCFIMCBGHIE MNDDNLANOIO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action KONBCENOINJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool MNHBKFLGMAO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int FPGJPBIHINK;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
				public EJCLEDLJBIJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class KDPILJPGEKC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public IPFJKMLJEPB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public EJCLEDLJBIJ trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
				public KDPILJPGEKC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int LNJGBCFLOJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int CHJIBBHLCPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int DKJBFNPJKJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool IFDCADIMIGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup MHBLDDDPEFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] GFEIHCJMPME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] GMMJDNNNLKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly MHJOFANHBIH GHFACKFNNLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<PCOININKFBB, int> EIFMIFJJFOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, EJCLEDLJBIJ> EHANOCGKELA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly EDHNIKMODAB GBOCMCAGPEB;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int PMFNKKPAPMP
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int COMGFFKMDLP
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x6EB790", Offset = "0x6E9F90", VA = "0x1806EB790", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x659B120", Offset = "0x6599920", VA = "0x18659B120")]
			internal IPFJKMLJEPB(int CHJIBBHLCPC, float[] MOGIAENNNHK, EDHNIKMODAB GBOCMCAGPEB = EDHNIKMODAB.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6599E70", Offset = "0x6598670", VA = "0x186599E70")]
			public void GFEJGJNJMLN(bool AGLFBINDKOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6599B90", Offset = "0x6598390", VA = "0x186599B90", Slot = "7")]
			public EPPGHKHCLCO FJBKKGADOAD(float HCLMBJIJBAH)
			{
				return default(EPPGHKHCLCO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x659AD70", Offset = "0x6599570", VA = "0x18659AD70", Slot = "8")]
			public void LGCDELLOPGJ(PCOININKFBB BFHAMCLNCKB, float LFHCJFFBBNC, BCFIMCBGHIE LFEJGIPJJAO = BCFIMCBGHIE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x659A920", Offset = "0x6599120", VA = "0x18659A920", Slot = "9")]
			public void LGCDELLOPGJ(PCOININKFBB BFHAMCLNCKB, Transform KAEEBKHEPFM, float LFHCJFFBBNC, BCFIMCBGHIE LFEJGIPJJAO = BCFIMCBGHIE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x659AE30", Offset = "0x6599630", VA = "0x18659AE30")]
			public void LPJMPCBHBKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x659AFB0", Offset = "0x65997B0", VA = "0x18659AFB0", Slot = "10")]
			public void NJEDKBEDLCB(PCOININKFBB BFHAMCLNCKB, [Optional] float? LFHCJFFBBNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x65994F0", Offset = "0x6597CF0", VA = "0x1865994F0")]
			private void BEGFCHMMAFA(int LHHBOCAHDEE, [Optional] float? LFHCJFFBBNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x65990C0", Offset = "0x65978C0", VA = "0x1865990C0", Slot = "11")]
			public void ALIFOBNBCOA(PCOININKFBB BGGPOFIMIJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6599A80", Offset = "0x6598280", VA = "0x186599A80", Slot = "12")]
			public EPPGHKHCLCO EICOCBDDKML(PCOININKFBB BFHAMCLNCKB)
			{
				return default(EPPGHKHCLCO);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6599D70", Offset = "0x6598570", VA = "0x186599D70", Slot = "13")]
			public bool GDPCDBFINIE(PCOININKFBB BFHAMCLNCKB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x659B030", Offset = "0x6599830", VA = "0x18659B030", Slot = "14")]
			public void OKHGCKKGIBE(PCOININKFBB BFHAMCLNCKB, BCFIMCBGHIE OIAFOFOFBAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x65997E0", Offset = "0x6597FE0", VA = "0x1865997E0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6599EA0", Offset = "0x65986A0", VA = "0x186599EA0")]
			private void HDKMEEBHNIF(EJCLEDLJBIJ MMJCMNHLOMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x659A610", Offset = "0x6598E10", VA = "0x18659A610")]
			private void IEGLAMMJOHM(EJCLEDLJBIJ MMJCMNHLOMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x659A8B0", Offset = "0x65990B0", VA = "0x18659A8B0")]
			private void KLGONJKDPGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x659A260", Offset = "0x6598A60", VA = "0x18659A260")]
			private void HEGMCIGHCOG(float JJJELGCEOLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x659AE00", Offset = "0x6599600", VA = "0x18659AE00")]
			private void LGOPNMLFNIM(EJCLEDLJBIJ MMJCMNHLOMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x659A8A0", Offset = "0x65990A0", VA = "0x18659A8A0")]
			private void JGPEEGJBGHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6599650", Offset = "0x6597E50", VA = "0x186599650")]
			private void DBPOJPMMIMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x659A2D0", Offset = "0x6598AD0", VA = "0x18659A2D0")]
			private void HOLGLIFCHOJ(CullingGroupEvent HPOMCMPHKBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6599660", Offset = "0x6597E60", VA = "0x186599660")]
			private void DNCJOAFPFGF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct DOCPBMNMFMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort PNGOMKAGEMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type FMLEAGLDFIM;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float BNNLNPCBCFM = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float PPEPCOMFNKD = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float EFOKIECOPFM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NEALNLFIPAN = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float DCFNGFBDCIE = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float NOFLEKNDNCK = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float GHKAMGDOFIL = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<DOCPBMNMFMM, IPFJKMLJEPB> HDIAFDGBDOO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable DCKNLGKLNAP;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable CJOLHFDCEBE;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IFEOEDLAFMF HKJHEOECEKD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IFEOEDLAFMF FCKMEJJLPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly IFEOEDLAFMF JJLBDKCBENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly IFEOEDLAFMF ODLAFNELGHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IFEOEDLAFMF JNGLMKEPCEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private BGFJNOHFIGD PDJJIBBMPOE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool AGLFBINDKOL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public IFEOEDLAFMF AJOKFJAAGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IFEOEDLAFMF AHJICKLGIFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IFEOEDLAFMF MGIHALPCBMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool PEHIDIOMFDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x17CC940", Offset = "0x17CB140", VA = "0x1817CC940", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CFKGNDGKENN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6D5030", Offset = "0x6D3830", VA = "0x1806D5030", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA3F830", Offset = "0xA3E030", VA = "0x180A3F830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6597EB0", Offset = "0x65966B0", VA = "0x186597EB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1082C00", Offset = "0x1081400", VA = "0x181082C00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6598930", Offset = "0x6597130", VA = "0x186598930")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6598650", Offset = "0x6596E50", VA = "0x186598650")]
		private void KALDHEFKJEP(Scene CHNAEAOJAGF, LoadSceneMode BCBFMICMNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6598850", Offset = "0x6597050", VA = "0x186598850", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6598B80", Offset = "0x6597380", VA = "0x186598B80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6597F80", Offset = "0x6596780", VA = "0x186597F80")]
		private void FEBICFHBJEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6598950", Offset = "0x6597150", VA = "0x186598950")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65986B0", Offset = "0x6596EB0", VA = "0x1865986B0")]
		private void KIJKNANDABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x65982C0", Offset = "0x6596AC0", VA = "0x1865982C0")]
		public JCEGNPJGMMH GetOrCreateCullingGroup(Type OGMIGPHGDAK, int JHKLENICFJJ, ushort AIKKMLKLNPL = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x22FA500", Offset = "0x22F8D00", VA = "0x1822FA500")]
		public global::DNKDPHBLGNC<T> GetOrCreateCullingGroup<T>(int JHKLENICFJJ, ushort AIKKMLKLNPL = 0) where T : class, PCOININKFBB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x65984B0", Offset = "0x6596CB0", VA = "0x1865984B0")]
		private JCEGNPJGMMH HODPBCANCJK(Type OGMIGPHGDAK, int JHKLENICFJJ, float[] MOGIAENNNHK, ushort AIKKMLKLNPL = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x22FA5B0", Offset = "0x22F8DB0", VA = "0x1822FA5B0")]
		private global::DNKDPHBLGNC<T> HODPBCANCJK<T>(int JHKLENICFJJ, float[] MOGIAENNNHK, ushort AIKKMLKLNPL = 0) where T : class, PCOININKFBB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6598120", Offset = "0x6596920", VA = "0x186598120")]
		public static EPPGHKHCLCO FindClosestDefaultUpdateLod(float LEICKPEFFHO)
		{
			return default(EPPGHKHCLCO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6598840", Offset = "0x6597040", VA = "0x186598840")]
		public static EPPGHKHCLCO MinUpdateLod(EPPGHKHCLCO GHKHFNMIDKP, EPPGHKHCLCO HCMOBPKPNGH)
		{
			return default(EPPGHKHCLCO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6598830", Offset = "0x6597030", VA = "0x186598830")]
		public static EPPGHKHCLCO MaxUpdateLod(EPPGHKHCLCO GHKHFNMIDKP, EPPGHKHCLCO HCMOBPKPNGH)
		{
			return default(EPPGHKHCLCO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6598FB0", Offset = "0x65977B0", VA = "0x186598FB0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MHJOFANHBIH
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool AJKEPAOBPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera FJBHEJANJOH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IFEOEDLAFMF GDCMCGBNBFB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool JGJGLHLHJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IFEOEDLAFMF DPAALMKFLKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform LCFCDPCPPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JCEGNPJGMMH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int PMFNKKPAPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int COMGFFKMDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EPPGHKHCLCO FJBKKGADOAD(float HCLMBJIJBAH);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LGCDELLOPGJ(PCOININKFBB BFHAMCLNCKB, float LFHCJFFBBNC, BCFIMCBGHIE LFEJGIPJJAO = BCFIMCBGHIE.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGCDELLOPGJ(PCOININKFBB BFHAMCLNCKB, Transform KAEEBKHEPFM, float LFHCJFFBBNC, BCFIMCBGHIE LFEJGIPJJAO = BCFIMCBGHIE.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NJEDKBEDLCB(PCOININKFBB BFHAMCLNCKB, [Optional] float? LFHCJFFBBNC);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ALIFOBNBCOA(PCOININKFBB BGGPOFIMIJL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EPPGHKHCLCO EICOCBDDKML(PCOININKFBB BFHAMCLNCKB);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GDPCDBFINIE(PCOININKFBB BFHAMCLNCKB);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OKHGCKKGIBE(PCOININKFBB BFHAMCLNCKB, BCFIMCBGHIE MCHCJHKAKAG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DNKDPHBLGNC<T> : JCEGNPJGMMH where T : class, PCOININKFBB
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGCDELLOPGJ(T BFHAMCLNCKB, float LFHCJFFBBNC, BCFIMCBGHIE LFEJGIPJJAO = BCFIMCBGHIE.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGCDELLOPGJ(T BFHAMCLNCKB, Transform KAEEBKHEPFM, float LFHCJFFBBNC, BCFIMCBGHIE LFEJGIPJJAO = BCFIMCBGHIE.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJEDKBEDLCB(T BFHAMCLNCKB, [Optional] float? LFHCJFFBBNC);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALIFOBNBCOA(T BGGPOFIMIJL);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EPPGHKHCLCO EICOCBDDKML(T BFHAMCLNCKB);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GDPCDBFINIE(T BFHAMCLNCKB);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OKHGCKKGIBE(T BFHAMCLNCKB, BCFIMCBGHIE MCHCJHKAKAG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PCOININKFBB
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform KPFEIMOAGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(EPPGHKHCLCO ALNGKHKCAAA, EPPGHKHCLCO DPKEJBNDNOC);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool KGCKPJMAMIH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum BCFIMCBGHIE : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum EPPGHKHCLCO
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
public class CCDAIFNPJLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EPPGHKHCLCO BPCHPMCLFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EPPGHKHCLCO HDHNBDLKAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, EPPGHKHCLCO> FGODMPKDOLM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool GFNAMFBPCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6597C80", Offset = "0x6596480", VA = "0x186597C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public EPPGHKHCLCO MBMLIEIFOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
		get
		{
			return default(EPPGHKHCLCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EPPGHKHCLCO IBGAKENCHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6EB790", Offset = "0x6E9F90", VA = "0x1806EB790")]
		get
		{
			return default(EPPGHKHCLCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6597C10", Offset = "0x6596410", VA = "0x186597C10")]
	public bool FENFGKNKPAA(object JPCLKLIDFBB, EPPGHKHCLCO NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6597BB0", Offset = "0x65963B0", VA = "0x186597BB0")]
	public bool EENKDCDPDEH(object JPCLKLIDFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6597CD0", Offset = "0x65964D0", VA = "0x186597CD0")]
	private bool PBALHPPEIKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6597E30", Offset = "0x6596630", VA = "0x186597E30")]
	public CCDAIFNPJLN()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x659B870", Offset = "0x659A070", VA = "0x18659B870")]
	private static string FEOGEGMPIMJ(byte[] JBKIIGINOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x659B520", Offset = "0x6599D20", VA = "0x18659B520")]
	public static string CIDKAEMCDOH(byte[] EBBNNMNMLOE, bool IGCCOAIPDPG)
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
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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
