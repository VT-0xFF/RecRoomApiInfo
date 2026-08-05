using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IOABNFOCIEA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KAMPIGMKHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Camera DEKIKPAJMPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IOAJAPLOKEP FCIJMPECNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PJLGOABJBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IOAJAPLOKEP BNMOJKONNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Transform GIDLNFEPEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, AAMOEBEEMHP
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class BELJKJDFPEI<T> : JNPEOLNBECB, GMKJDBIOCHA<T>, LIENANGMHBE where T : class, GBKLBEOOIJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2513900", Offset = "0x2511F00", VA = "0x182513900")]
			internal BELJKJDFPEI(int COEIOOODDIJ, float[] BEPKJFPJIDJ, PDNFJNGCENK BAMLDIAIEEH = PDNFJNGCENK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x25138D0", Offset = "0x2511ED0", VA = "0x1825138D0", Slot = "10")]
			public void PDDBDHJNBOH(T NKFOPKJGBEM, float HDIPCMABEDD, FPJJHNAFLMG EKAMIBPDFFK = FPJJHNAFLMG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x25138A0", Offset = "0x2511EA0", VA = "0x1825138A0", Slot = "11")]
			public void PDDBDHJNBOH(T NKFOPKJGBEM, Transform KHJNMIDHPKB, float HDIPCMABEDD, FPJJHNAFLMG EKAMIBPDFFK = FPJJHNAFLMG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2513880", Offset = "0x2511E80", VA = "0x182513880", Slot = "12")]
			public void EIILGGCBFDG(T PLOLEIDLDFK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class JNPEOLNBECB : IDisposable, LIENANGMHBE
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public enum PDNFJNGCENK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private class POLBLFHMDJN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public GBKLBEOOIJI LKMDIOHLICO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public FPJJHNAFLMG MLDLDBIOCKO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action JMDNEDIEDGN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool OJIAGPLLONH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int FIFIFGFPIHM;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
				public POLBLFHMDJN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			[CompilerGenerated]
			private sealed class BCOAPCKGAMH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public JNPEOLNBECB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public POLBLFHMDJN trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
				public BCOAPCKGAMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x6F7C120", Offset = "0x6F7A720", VA = "0x186F7C120")]
				internal void EIAGAKPJLPA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int NKIDDAHKIBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int COEIOOODDIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int PHFNONJDNJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool IPAONFGPPJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup LJHCOEJGOJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] OFMBFDDCGDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] BGKFIKNKMEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly IOABNFOCIEA FOAHDAGNGDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<GBKLBEOOIJI, int> ONIHACNDHMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, POLBLFHMDJN> IHANJBLPFIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly PDNFJNGCENK BAMLDIAIEEH;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool CGFPCOMFHHP
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x2103290", Offset = "0x2101890", VA = "0x182103290")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x1F08650", Offset = "0x1F06C50", VA = "0x181F08650", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F7F1A0", Offset = "0x6F7D7A0", VA = "0x186F7F1A0")]
			internal JNPEOLNBECB(int COEIOOODDIJ, float[] BEPKJFPJIDJ, PDNFJNGCENK BAMLDIAIEEH = PDNFJNGCENK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E150", Offset = "0x6F7C750", VA = "0x186F7E150")]
			public void ICFBEJPMKEB(bool DAIMADMLNOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F7ECA0", Offset = "0x6F7D2A0", VA = "0x186F7ECA0", Slot = "6")]
			public void PDDBDHJNBOH(GBKLBEOOIJI NKFOPKJGBEM, float HDIPCMABEDD, FPJJHNAFLMG EKAMIBPDFFK = FPJJHNAFLMG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F7ED30", Offset = "0x6F7D330", VA = "0x186F7ED30", Slot = "9")]
			public void PDDBDHJNBOH(GBKLBEOOIJI NKFOPKJGBEM, Transform KHJNMIDHPKB, float HDIPCMABEDD, FPJJHNAFLMG EKAMIBPDFFK = FPJJHNAFLMG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F7DFC0", Offset = "0x6F7C5C0", VA = "0x186F7DFC0")]
			public void FKEBOBCMIMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F7D780", Offset = "0x6F7BD80", VA = "0x186F7D780")]
			private void DCMPACLBBDD(int OLGOBCPPPBB, [Optional] float? HDIPCMABEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F7DB90", Offset = "0x6F7C190", VA = "0x186F7DB90", Slot = "7")]
			public void EIILGGCBFDG(GBKLBEOOIJI PLOLEIDLDFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F7EBB0", Offset = "0x6F7D1B0", VA = "0x186F7EBB0", Slot = "8")]
			public void OGACEJEJGCM(GBKLBEOOIJI NKFOPKJGBEM, FPJJHNAFLMG JJLJMOPGMEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F7D8E0", Offset = "0x6F7BEE0", VA = "0x186F7D8E0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E500", Offset = "0x6F7CB00", VA = "0x186F7E500")]
			private void NIGBFDEKHPC(POLBLFHMDJN AAGJAFBPCCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F7D4F0", Offset = "0x6F7BAF0", VA = "0x186F7D4F0")]
			private void DCAOLNLODKP(POLBLFHMDJN AAGJAFBPCCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E310", Offset = "0x6F7C910", VA = "0x186F7E310")]
			private void KNIJPFHDHJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F7D480", Offset = "0x6F7BA80", VA = "0x186F7D480")]
			private void CBFJGKMICJD(float KKEKAHCHEND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E180", Offset = "0x6F7C780", VA = "0x186F7E180")]
			private void IOIOBAHJEBG(POLBLFHMDJN AAGJAFBPCCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E140", Offset = "0x6F7C740", VA = "0x186F7E140")]
			private void HLGNCJKCIKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E300", Offset = "0x6F7C900", VA = "0x186F7E300")]
			private void JJOHILBCECG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E870", Offset = "0x6F7CE70", VA = "0x186F7E870")]
			private void OBHDEOCFCKF(CullingGroupEvent DDEGEFCOOOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E380", Offset = "0x6F7C980", VA = "0x186F7E380")]
			private void MEBCDMFGIKF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private struct GODKOEHJKDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort ODOBCAFLAJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type LHHNDFBDNKE;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float FLAHKPFLIOP = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float CFGLFOMIPBH = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float FLHBMKJIDOM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float GLFPCGCPFNL = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float LOBPEHJBJDP = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float MHGAEBCPHKI = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float IPHHNGMGFHF = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<GODKOEHJKDL, JNPEOLNBECB> DHFAMDDKKOD;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable KAGAJHNANOE;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable GDGMLKOFGKB;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IOAJAPLOKEP BHFBJADBCKM;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IOAJAPLOKEP NNKPHEAMMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly IOAJAPLOKEP DFBBODJNAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly IOAJAPLOKEP BIFFNCPFPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IOAJAPLOKEP ABHKKLDEIHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private BDPNFFCBKDC LGICJNPPFBB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool DAIMADMLNOK;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IOAJAPLOKEP FCIOAPCAJJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IOAJAPLOKEP LBGLJAIMBEN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IOAJAPLOKEP ELDDPMPJLLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MBNKNEENGGN
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x10FEE80", Offset = "0x10FD480", VA = "0x1810FEE80", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EOLPHMELMJN
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA2E160", Offset = "0xA2C760", VA = "0x180A2E160", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA2DCC0", Offset = "0xA2C2C0", VA = "0x180A2DCC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C2B0", Offset = "0x6F7A8B0", VA = "0x186F7C2B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x19C6920", Offset = "0x19C4F20", VA = "0x1819C6920")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CD20", Offset = "0x6F7B320", VA = "0x186F7CD20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CA40", Offset = "0x6F7B040", VA = "0x186F7CA40")]
		private void HLIDDLIEILE(Scene GHAEGLKDDJL, LoadSceneMode CFNBBPIIFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CC40", Offset = "0x6F7B240", VA = "0x186F7CC40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CF70", Offset = "0x6F7B570", VA = "0x186F7CF70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C520", Offset = "0x6F7AB20", VA = "0x186F7C520")]
		private void FIMJNPEHNBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CD40", Offset = "0x6F7B340", VA = "0x186F7CD40")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CAC0", Offset = "0x6F7B0C0", VA = "0x186F7CAC0")]
		private void OJJCJNBKGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C850", Offset = "0x6F7AE50", VA = "0x186F7C850")]
		public LIENANGMHBE GetOrCreateCullingGroup(Type DBKPGNIKKCI, int ONDFMKNAABD, ushort NAICCABEGBO = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x24390F0", Offset = "0x24376F0", VA = "0x1824390F0")]
		public GMKJDBIOCHA<T> GetOrCreateCullingGroup<T>(int ONDFMKNAABD, ushort NAICCABEGBO = 0) where T : class, GBKLBEOOIJI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C380", Offset = "0x6F7A980", VA = "0x186F7C380")]
		private LIENANGMHBE DMLAKMJOACI(Type DBKPGNIKKCI, int ONDFMKNAABD, float[] BEPKJFPJIDJ, ushort NAICCABEGBO = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2438EC0", Offset = "0x24374C0", VA = "0x182438EC0")]
		private GMKJDBIOCHA<T> DMLAKMJOACI<T>(int ONDFMKNAABD, float[] BEPKJFPJIDJ, ushort NAICCABEGBO = 0) where T : class, GBKLBEOOIJI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C6C0", Offset = "0x6F7ACC0", VA = "0x186F7C6C0")]
		public static DBOALJMGPFL FindClosestDefaultUpdateLod(float IPGNEPCDBLF)
		{
			return default(DBOALJMGPFL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CAB0", Offset = "0x6F7B0B0", VA = "0x186F7CAB0")]
		public static DBOALJMGPFL MinUpdateLod(DBOALJMGPFL JANIGHGJLJO, DBOALJMGPFL DKPACKMPANC)
		{
			return default(DBOALJMGPFL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CAA0", Offset = "0x6F7B0A0", VA = "0x186F7CAA0")]
		public static DBOALJMGPFL MaxUpdateLod(DBOALJMGPFL JANIGHGJLJO, DBOALJMGPFL DKPACKMPANC)
		{
			return default(DBOALJMGPFL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D3A0", Offset = "0x6F7B9A0", VA = "0x186F7D3A0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DBOALJMGPFL
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GBKLBEOOIJI
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform DMECJMCKFAG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(DBOALJMGPFL PPJEODAFBKD, DBOALJMGPFL FFAOKGEEGLC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool NEDCLNHOJGB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LIENANGMHBE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool CGFPCOMFHHP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDDBDHJNBOH(GBKLBEOOIJI NKFOPKJGBEM, float HDIPCMABEDD, FPJJHNAFLMG EKAMIBPDFFK = FPJJHNAFLMG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIILGGCBFDG(GBKLBEOOIJI PLOLEIDLDFK);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OGACEJEJGCM(GBKLBEOOIJI NKFOPKJGBEM, FPJJHNAFLMG GCENGGEBMPL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GMKJDBIOCHA<T> : LIENANGMHBE where T : class, GBKLBEOOIJI
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDDBDHJNBOH(T NKFOPKJGBEM, float HDIPCMABEDD, FPJJHNAFLMG EKAMIBPDFFK = FPJJHNAFLMG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDDBDHJNBOH(T NKFOPKJGBEM, Transform KHJNMIDHPKB, float HDIPCMABEDD, FPJJHNAFLMG EKAMIBPDFFK = FPJJHNAFLMG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIILGGCBFDG(T PLOLEIDLDFK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FPJJHNAFLMG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Full
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
