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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, OLOCNFFOAIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class OGCKAIDLMIF<T> : HJKHHFCIKGF, KAOKCBOBEGL<T>, MLOEMGPHEAG where T : class, NECDNJPEKJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x4693C50", Offset = "0x4692850", VA = "0x184693C50")]
			internal OGCKAIDLMIF(int HBKKEJGHGEL, float[] NDKDPJILPHO, PJOCMKPAICI MMKHLLKMOKG = PJOCMKPAICI.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x4693BF0", Offset = "0x46927F0", VA = "0x184693BF0", Slot = "10")]
			public void LKPJOLMECIF(T APKAFMDACKK, float KBOADMDLFLD, LHFCBMFLLBG GGGELCGGOJN = LHFCBMFLLBG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x4693C20", Offset = "0x4692820", VA = "0x184693C20", Slot = "11")]
			public void LKPJOLMECIF(T APKAFMDACKK, Transform COLIANPCIOO, float KBOADMDLFLD, LHFCBMFLLBG GGGELCGGOJN = LHFCBMFLLBG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4693BD0", Offset = "0x46927D0", VA = "0x184693BD0", Slot = "12")]
			public void ECLBFOFCOFL(T DLMKCJJAKJI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class HJKHHFCIKGF : IDisposable, MLOEMGPHEAG
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum PJOCMKPAICI : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class KLMJPAJHIHB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public NECDNJPEKJG OAKDNPEENLF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public LHFCBMFLLBG NABLNDPBFPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action IDCKOHJEBHE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool EOLCONBFHJK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int ICIBDGPPAOE;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
				public KLMJPAJHIHB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class OJKOKNMEGPH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public HJKHHFCIKGF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public KLMJPAJHIHB trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
				public OJKOKNMEGPH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x699DE50", Offset = "0x699CA50", VA = "0x18699DE50")]
				internal void AKDKAFMMCHA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int GNIPEOPPNIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int HBKKEJGHGEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int FJFIKCNOKCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool KFHJMPBIANF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup JEOHGPDBGPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] BJGGGPDEDLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] NDDGDPBECNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly OLKFHFNOJNK JMKPKEHPNLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<NECDNJPEKJG, int> PLMFIOPGOIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, KLMJPAJHIHB> KLLGPEBOHPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly PJOCMKPAICI MMKHLLKMOKG;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool FLFBOEOLPMO
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xF5A540", Offset = "0xF59140", VA = "0x180F5A540")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x44D2CF0", Offset = "0x44D18F0", VA = "0x1844D2CF0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x699DA60", Offset = "0x699C660", VA = "0x18699DA60")]
			internal HJKHHFCIKGF(int HBKKEJGHGEL, float[] NDKDPJILPHO, PJOCMKPAICI MMKHLLKMOKG = PJOCMKPAICI.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x699C610", Offset = "0x699B210", VA = "0x18699C610")]
			public void DGHJAABBNIM(bool KFFCPJKPHBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x699D0E0", Offset = "0x699BCE0", VA = "0x18699D0E0", Slot = "6")]
			public void LKPJOLMECIF(NECDNJPEKJG APKAFMDACKK, float KBOADMDLFLD, LHFCBMFLLBG GGGELCGGOJN = LHFCBMFLLBG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x699D170", Offset = "0x699BD70", VA = "0x18699D170", Slot = "9")]
			public void LKPJOLMECIF(NECDNJPEKJG APKAFMDACKK, Transform COLIANPCIOO, float KBOADMDLFLD, LHFCBMFLLBG GGGELCGGOJN = LHFCBMFLLBG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x699D570", Offset = "0x699C170", VA = "0x18699D570")]
			public void MIKFHDJPHHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x699D6C0", Offset = "0x699C2C0", VA = "0x18699D6C0")]
			private void MKOJPOJBLNC(int BAEBMIBABAE, [Optional] float? KBOADMDLFLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x699C900", Offset = "0x699B500", VA = "0x18699C900", Slot = "7")]
			public void ECLBFOFCOFL(NECDNJPEKJG DLMKCJJAKJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x699D970", Offset = "0x699C570", VA = "0x18699D970", Slot = "8")]
			public void OONJINFOCDG(NECDNJPEKJG APKAFMDACKK, LHFCBMFLLBG FNPOELHOEGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x699C640", Offset = "0x699B240", VA = "0x18699C640", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x699BEA0", Offset = "0x699AAA0", VA = "0x18699BEA0")]
			private void ALFDODEJDKF(KLMJPAJHIHB COAHKOMKNPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x699C230", Offset = "0x699AE30", VA = "0x18699C230")]
			private void BHMNKIJNNJI(KLMJPAJHIHB COAHKOMKNPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x699D020", Offset = "0x699BC20", VA = "0x18699D020")]
			private void HMHHHFHGHGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x699D080", Offset = "0x699BC80", VA = "0x18699D080")]
			private void IIBFHENGFJP(float GFJHAHMFGFJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x699C4D0", Offset = "0x699B0D0", VA = "0x18699C4D0")]
			private void DELEOIPLCBF(KLMJPAJHIHB COAHKOMKNPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x699D960", Offset = "0x699C560", VA = "0x18699D960")]
			private void NIELOMKEODD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x699D010", Offset = "0x699BC10", VA = "0x18699D010")]
			private void HBDMNDCCIAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x699CCF0", Offset = "0x699B8F0", VA = "0x18699CCF0")]
			private void FOFDHAGMOFM(CullingGroupEvent FDDDGDDLOEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x699D7F0", Offset = "0x699C3F0", VA = "0x18699D7F0")]
			private void NBNOPLPPMJL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct IAAOGNLIANE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort IBNPOCCLGKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type MIBOKEBPIHL;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float NDCMKJMNDCJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float CCLBCMGNIKA = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float MHINOPJKBFO = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float GIFFOMBLLAC = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float FGMBCIAGMCA = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float IBPALKFDMCC = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float CJPACCKGMPA = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<IAAOGNLIANE, HJKHHFCIKGF> IJHNDFKCLBB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable JMDGBHJCGNJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable IFDGOELKDHG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static MMAIJBDFGNK CLEKPFHIJKH;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static MMAIJBDFGNK HAHNKFPHGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly MMAIJBDFGNK AHFKJNJMABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly MMAIJBDFGNK LBNBBGEIKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MMAIJBDFGNK HBHJEDOBDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NHMNIEJFONC CPADLGOIPPJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool KFFCPJKPHBF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MMAIJBDFGNK LPBEFCADFGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MMAIJBDFGNK LPIPPDPNHCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MMAIJBDFGNK DDLNFCMIKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JNDHGMBJHBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xF99010", Offset = "0xF97C10", VA = "0x180F99010", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DDOKPNFGBPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9D38C0", Offset = "0x9D24C0", VA = "0x1809D38C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA23060", Offset = "0xA21C60", VA = "0x180A23060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x699AC20", Offset = "0x6999820", VA = "0x18699AC20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x699B550", Offset = "0x699A150", VA = "0x18699B550")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x699B530", Offset = "0x699A130", VA = "0x18699B530")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x699B3E0", Offset = "0x6999FE0", VA = "0x18699B3E0")]
		private void KMMOBFKNLFJ(Scene FEDKAPNICJB, LoadSceneMode GIIHAKJPNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x699B450", Offset = "0x699A050", VA = "0x18699B450", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x699B930", Offset = "0x699A530", VA = "0x18699B930")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x699AEC0", Offset = "0x6999AC0", VA = "0x18699AEC0")]
		private void EFFCIEADPME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x699B6F0", Offset = "0x699A2F0", VA = "0x18699B6F0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x699B570", Offset = "0x699A170", VA = "0x18699B570")]
		private void PFONJODNCPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x699B1C0", Offset = "0x6999DC0", VA = "0x18699B1C0")]
		public MLOEMGPHEAG GetOrCreateCullingGroup(Type BBMICAJPHKE, int NKAIABKELEP, ushort BKIPKBIFMAJ = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x29872E0", Offset = "0x2985EE0", VA = "0x1829872E0")]
		public KAOKCBOBEGL<T> GetOrCreateCullingGroup<T>(int NKAIABKELEP, ushort BKIPKBIFMAJ = 0) where T : class, NECDNJPEKJG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x699ACE0", Offset = "0x69998E0", VA = "0x18699ACE0")]
		private MLOEMGPHEAG DJPDJCKMNEH(Type BBMICAJPHKE, int NKAIABKELEP, float[] NDKDPJILPHO, ushort BKIPKBIFMAJ = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2987060", Offset = "0x2985C60", VA = "0x182987060")]
		private KAOKCBOBEGL<T> DJPDJCKMNEH<T>(int NKAIABKELEP, float[] NDKDPJILPHO, ushort BKIPKBIFMAJ = 0) where T : class, NECDNJPEKJG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x699B060", Offset = "0x6999C60", VA = "0x18699B060")]
		public static IABFIAOBIIB FindClosestDefaultUpdateLod(float AKCFLMKFHAO)
		{
			return default(IABFIAOBIIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8932B0", Offset = "0x891EB0", VA = "0x1808932B0")]
		public static IABFIAOBIIB MinUpdateLod(IABFIAOBIIB GOFLLBLOADF, IABFIAOBIIB PHBIDMHMLOM)
		{
			return default(IABFIAOBIIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x699B440", Offset = "0x699A040", VA = "0x18699B440")]
		public static IABFIAOBIIB MaxUpdateLod(IABFIAOBIIB GOFLLBLOADF, IABFIAOBIIB PHBIDMHMLOM)
		{
			return default(IABFIAOBIIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x699BDA0", Offset = "0x699A9A0", VA = "0x18699BDA0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OLKFHFNOJNK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool DACEKMKPMPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera PMNHKHENGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	MMAIJBDFGNK MNCOCHALOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MOCAHNBHEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MMAIJBDFGNK KDEJHILJPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform HILPPHPELMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MLOEMGPHEAG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool FLFBOEOLPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKPJOLMECIF(NECDNJPEKJG APKAFMDACKK, float KBOADMDLFLD, LHFCBMFLLBG GGGELCGGOJN = LHFCBMFLLBG.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECLBFOFCOFL(NECDNJPEKJG DLMKCJJAKJI);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OONJINFOCDG(NECDNJPEKJG APKAFMDACKK, LHFCBMFLLBG LNLCNAMDJLP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KAOKCBOBEGL<T> : MLOEMGPHEAG where T : class, NECDNJPEKJG
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKPJOLMECIF(T APKAFMDACKK, float KBOADMDLFLD, LHFCBMFLLBG GGGELCGGOJN = LHFCBMFLLBG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKPJOLMECIF(T APKAFMDACKK, Transform COLIANPCIOO, float KBOADMDLFLD, LHFCBMFLLBG GGGELCGGOJN = LHFCBMFLLBG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECLBFOFCOFL(T DLMKCJJAKJI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NECDNJPEKJG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform MENBKJEFCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(IABFIAOBIIB AKLFKNMIKPD, IABFIAOBIIB FIJPEPLJMMO);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool DLFBAKFHOFN);
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
