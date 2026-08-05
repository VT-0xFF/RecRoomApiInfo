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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, MFABPFMFOOL
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class HFOJDGEFMDK<T> : CGGMFEDJAKA, global::OGFHLCIPFED<T>, KKMENLLDAPN where T : class, FLCKAICBODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x32E7B40", Offset = "0x32E6F40", VA = "0x1832E7B40")]
			internal HFOJDGEFMDK(int NOLMAMFJOEA, float[] HAAMLOCJKIM, MPCHPJPHOFA GEDKNKKDHOF = MPCHPJPHOFA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x32E7A40", Offset = "0x32E6E40", VA = "0x1832E7A40", Slot = "15")]
			public void AGMLDLCGDGN(T NBNOMDAKOCG, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x32E7A70", Offset = "0x32E6E70", VA = "0x1832E7A70", Slot = "16")]
			public void AGMLDLCGDGN(T NBNOMDAKOCG, Transform NNNEKOPBKOD, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x32E7AC0", Offset = "0x32E6EC0", VA = "0x1832E7AC0", Slot = "17")]
			public void BKNMIOLEDCJ(T NBNOMDAKOCG, [Optional] float? KHPBNPIIPMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x32E7AE0", Offset = "0x32E6EE0", VA = "0x1832E7AE0", Slot = "18")]
			public void FJEBMLODAAK(T LILGPDENNHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x32E7AA0", Offset = "0x32E6EA0", VA = "0x1832E7AA0", Slot = "19")]
			public FCDCKNBKJML BBCJDADENAF(T NBNOMDAKOCG)
			{
				return default(FCDCKNBKJML);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x32E7B00", Offset = "0x32E6F00", VA = "0x1832E7B00", Slot = "20")]
			public bool FJJDFBCKGOK(T NBNOMDAKOCG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x32E7B20", Offset = "0x32E6F20", VA = "0x1832E7B20", Slot = "21")]
			public void LJMKICNDLAI(T NBNOMDAKOCG, FJJLEAMIEBC GEIMPLCDGIJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class CGGMFEDJAKA : IDisposable, KKMENLLDAPN
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum MPCHPJPHOFA : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class FKEMIOANGAC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public FLCKAICBODN JELKDBJJLFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public FJJLEAMIEBC MPNKJPECBMA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action CCMDHPPKHJJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool MMDNPDDGKGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int CMHFEELAEBD;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
				public FKEMIOANGAC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class MFCPJGHLHBO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public CGGMFEDJAKA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public FKEMIOANGAC trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
				public MFCPJGHLHBO()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int GOJEIPJGMFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int NOLMAMFJOEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int BDGJGFLHFOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool AJCOIBJBODA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup EJCAONAAFLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] IABEMBFDBEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] HKOLIKMIGPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly IBMLPCIKHND NOHGMFJPJKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<FLCKAICBODN, int> GCINIHKOHED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, FKEMIOANGAC> ABHOALJMGNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly MPCHPJPHOFA GEDKNKKDHOF;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int MEHIPKALLPB
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x72B020", Offset = "0x72A420", VA = "0x18072B020", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int DMEAPIODOKJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x72B0E0", Offset = "0x72A4E0", VA = "0x18072B0E0", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x69D6C60", Offset = "0x69D6060", VA = "0x1869D6C60")]
			internal CGGMFEDJAKA(int NOLMAMFJOEA, float[] HAAMLOCJKIM, MPCHPJPHOFA GEDKNKKDHOF = MPCHPJPHOFA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x69D6370", Offset = "0x69D5770", VA = "0x1869D6370")]
			public void HNOEBFBOACF(bool KJDPMJJFOPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x69D6690", Offset = "0x69D5A90", VA = "0x1869D6690", Slot = "7")]
			public FCDCKNBKJML NGPFGLFICJL(float FLFEPFNINBJ)
			{
				return default(FCDCKNBKJML);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x69D4D80", Offset = "0x69D4180", VA = "0x1869D4D80", Slot = "8")]
			public void AGMLDLCGDGN(FLCKAICBODN NBNOMDAKOCG, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x69D4E10", Offset = "0x69D4210", VA = "0x1869D4E10", Slot = "9")]
			public void AGMLDLCGDGN(FLCKAICBODN NBNOMDAKOCG, Transform NNNEKOPBKOD, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x69D4C00", Offset = "0x69D4000", VA = "0x1869D4C00")]
			public void AFLLDBFCNFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x69D5370", Offset = "0x69D4770", VA = "0x1869D5370", Slot = "10")]
			public void BKNMIOLEDCJ(FLCKAICBODN NBNOMDAKOCG, [Optional] float? KHPBNPIIPMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x69D6210", Offset = "0x69D5610", VA = "0x1869D6210")]
			private void HNNMCBIGPPG(int EGNHJGKABLC, [Optional] float? KHPBNPIIPMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x69D5690", Offset = "0x69D4A90", VA = "0x1869D5690", Slot = "11")]
			public void FJEBMLODAAK(FLCKAICBODN LILGPDENNHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x69D5260", Offset = "0x69D4660", VA = "0x1869D5260", Slot = "12")]
			public FCDCKNBKJML BBCJDADENAF(FLCKAICBODN NBNOMDAKOCG)
			{
				return default(FCDCKNBKJML);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x69D5AC0", Offset = "0x69D4EC0", VA = "0x1869D5AC0", Slot = "13")]
			public bool FJJDFBCKGOK(FLCKAICBODN NBNOMDAKOCG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x69D65A0", Offset = "0x69D59A0", VA = "0x1869D65A0", Slot = "14")]
			public void LJMKICNDLAI(FLCKAICBODN NBNOMDAKOCG, FJJLEAMIEBC AHNJDBMDPKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x69D53F0", Offset = "0x69D47F0", VA = "0x1869D53F0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x69D6870", Offset = "0x69D5C70", VA = "0x1869D6870")]
			private void OIAMDHGKGLI(FKEMIOANGAC EPKAJCDDHEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x69D5F70", Offset = "0x69D5370", VA = "0x1869D5F70")]
			private void GEGAAFEEBFO(FKEMIOANGAC EPKAJCDDHEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x69D5BC0", Offset = "0x69D4FC0", VA = "0x1869D5BC0")]
			private void FJJFLBBDNPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x69D6530", Offset = "0x69D5930", VA = "0x1869D6530")]
			private void LFKLCPDNBOG(float FFHPDJCFLBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x69D6C30", Offset = "0x69D6030", VA = "0x1869D6C30")]
			private void PMBCCNJLKPI(FKEMIOANGAC EPKAJCDDHEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x69D6520", Offset = "0x69D5920", VA = "0x1869D6520")]
			private void LBKMGGOLJPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x69D6200", Offset = "0x69D5600", VA = "0x1869D6200")]
			private void GMLFNNNOELG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x69D5C30", Offset = "0x69D5030", VA = "0x1869D5C30")]
			private void FKJAMABMHGB(CullingGroupEvent GFMIHKIADCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x69D63A0", Offset = "0x69D57A0", VA = "0x1869D63A0")]
			private void IBDFNADBKDK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct FOOHFCGBLHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort PKOHECOCLNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type FFDOMIJHEOA;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float IMJNJNCFOIJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float ENKLNBLHPDB = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float AFKAOFKJNMK = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float CAAHJBKPAJB = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float LILOENGCKKA = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float FBDLHPPHDDE = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float HAEOMCIEMPE = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<FOOHFCGBLHP, CGGMFEDJAKA> PHPGCDNJLKK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable LFODJNOCAFA;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable BGFDIFPODMD;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static FNCKCCFNKKK ONMAFPOJCCG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static FNCKCCFNKKK HBJKHFOMLNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly FNCKCCFNKKK ACDAOILHOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly FNCKCCFNKKK NDEBMMNLPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly FNCKCCFNKKK LJHFDAMCBCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GNGMNANCADP NFHNMBBEBKI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool KJDPMJJFOPN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public FNCKCCFNKKK ODMCHCOEOBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public FNCKCCFNKKK OOABALNMOMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public FNCKCCFNKKK BFGKAOBLJCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72E670", VA = "0x18072F270", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool EKBEMIJIEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1820350", Offset = "0x181F750", VA = "0x181820350", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CHLKOMPNDEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9A6950", Offset = "0x9A5D50", VA = "0x1809A6950", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCCB670", Offset = "0xCCAA70", VA = "0x180CCB670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69D7020", Offset = "0x69D6420", VA = "0x1869D7020", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xFC56B0", Offset = "0xFC4AB0", VA = "0x180FC56B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69D7AA0", Offset = "0x69D6EA0", VA = "0x1869D7AA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69D7960", Offset = "0x69D6D60", VA = "0x1869D7960")]
		private void NEHELEEIEPG(Scene OOOMPFGDEEN, LoadSceneMode FLAGJIBPLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69D79C0", Offset = "0x69D6DC0", VA = "0x1869D79C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69D7CF0", Offset = "0x69D70F0", VA = "0x1869D7CF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69D77A0", Offset = "0x69D6BA0", VA = "0x1869D77A0")]
		private void JCDBCKDLLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x69D7AC0", Offset = "0x69D6EC0", VA = "0x1869D7AC0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69D7620", Offset = "0x69D6A20", VA = "0x1869D7620")]
		private void IBAIINALAGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69D7430", Offset = "0x69D6830", VA = "0x1869D7430")]
		public KKMENLLDAPN GetOrCreateCullingGroup(Type LIEBPIGKJGB, int JIGAKELLAMB, ushort DALOGAFPIOH = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x22C31B0", Offset = "0x22C25B0", VA = "0x1822C31B0")]
		public global::OGFHLCIPFED<T> GetOrCreateCullingGroup<T>(int JIGAKELLAMB, ushort DALOGAFPIOH = 0) where T : class, FLCKAICBODN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69D7290", Offset = "0x69D6690", VA = "0x1869D7290")]
		private KKMENLLDAPN GNGDKHBAKPP(Type LIEBPIGKJGB, int JIGAKELLAMB, float[] HAAMLOCJKIM, ushort DALOGAFPIOH = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x22C2F80", Offset = "0x22C2380", VA = "0x1822C2F80")]
		private global::OGFHLCIPFED<T> GNGDKHBAKPP<T>(int JIGAKELLAMB, float[] HAAMLOCJKIM, ushort DALOGAFPIOH = 0) where T : class, FLCKAICBODN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69D70F0", Offset = "0x69D64F0", VA = "0x1869D70F0")]
		public static FCDCKNBKJML FindClosestDefaultUpdateLod(float ACGBGOMNAMK)
		{
			return default(FCDCKNBKJML);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x69D7950", Offset = "0x69D6D50", VA = "0x1869D7950")]
		public static FCDCKNBKJML MinUpdateLod(FCDCKNBKJML DJJAGBOECJN, FCDCKNBKJML IPDCLPNNOLA)
		{
			return default(FCDCKNBKJML);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69D7940", Offset = "0x69D6D40", VA = "0x1869D7940")]
		public static FCDCKNBKJML MaxUpdateLod(FCDCKNBKJML DJJAGBOECJN, FCDCKNBKJML IPDCLPNNOLA)
		{
			return default(FCDCKNBKJML);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69D8120", Offset = "0x69D7520", VA = "0x1869D8120")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IBMLPCIKHND
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool JACNJKAOLCG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera PDKKIHHBEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FNCKCCFNKKK GFIEODFDAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool GCKKFIDELMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FNCKCCFNKKK KOMMOKMCIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform JEBNPOCNFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KKMENLLDAPN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int MEHIPKALLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int DMEAPIODOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FCDCKNBKJML NGPFGLFICJL(float FLFEPFNINBJ);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGMLDLCGDGN(FLCKAICBODN NBNOMDAKOCG, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGMLDLCGDGN(FLCKAICBODN NBNOMDAKOCG, Transform NNNEKOPBKOD, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BKNMIOLEDCJ(FLCKAICBODN NBNOMDAKOCG, [Optional] float? KHPBNPIIPMK);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FJEBMLODAAK(FLCKAICBODN LILGPDENNHI);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FCDCKNBKJML BBCJDADENAF(FLCKAICBODN NBNOMDAKOCG);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FJJDFBCKGOK(FLCKAICBODN NBNOMDAKOCG);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LJMKICNDLAI(FLCKAICBODN NBNOMDAKOCG, FJJLEAMIEBC GEIMPLCDGIJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OGFHLCIPFED<T> : KKMENLLDAPN where T : class, FLCKAICBODN
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGMLDLCGDGN(T NBNOMDAKOCG, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGMLDLCGDGN(T NBNOMDAKOCG, Transform NNNEKOPBKOD, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKNMIOLEDCJ(T NBNOMDAKOCG, [Optional] float? KHPBNPIIPMK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FJEBMLODAAK(T LILGPDENNHI);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FCDCKNBKJML BBCJDADENAF(T NBNOMDAKOCG);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FJJDFBCKGOK(T NBNOMDAKOCG);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LJMKICNDLAI(T NBNOMDAKOCG, FJJLEAMIEBC GEIMPLCDGIJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FLCKAICBODN
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform CACALPHNCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(FCDCKNBKJML NBPFLJDNNCH, FCDCKNBKJML ABBGLPJCAMC);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool FHFGDHHLCHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum FJJLEAMIEBC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FCDCKNBKJML
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
public class LFJFOIDGPJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private FCDCKNBKJML ONLKOJHBEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private FCDCKNBKJML JKHCMKCHKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, FCDCKNBKJML> DAMCMDBIAHI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool MJNHCKEGDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x69D88D0", Offset = "0x69D7CD0", VA = "0x1869D88D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FCDCKNBKJML DEEPIDEAAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x72B020", Offset = "0x72A420", VA = "0x18072B020")]
		get
		{
			return default(FCDCKNBKJML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FCDCKNBKJML DGLFKGJFDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x72B0E0", Offset = "0x72A4E0", VA = "0x18072B0E0")]
		get
		{
			return default(FCDCKNBKJML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69D8860", Offset = "0x69D7C60", VA = "0x1869D8860")]
	public bool CJNLKFPNHDF(object MIFCLBEAOPM, FCDCKNBKJML LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69D8A80", Offset = "0x69D7E80", VA = "0x1869D8A80")]
	public bool PBFPIEEMKFJ(object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69D8920", Offset = "0x69D7D20", VA = "0x1869D8920")]
	private bool LHJNLBEAPOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69D8AE0", Offset = "0x69D7EE0", VA = "0x1869D8AE0")]
	public LFJFOIDGPJH()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x69D8580", Offset = "0x69D7980", VA = "0x1869D8580")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69D8230", Offset = "0x69D7630", VA = "0x1869D8230")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
