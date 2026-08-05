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
			[Cpp2IlInjected.Address(RVA = "0x3E5E940", Offset = "0x3E5D340", VA = "0x183E5E940")]
			internal HFOJDGEFMDK(int NOLMAMFJOEA, float[] HAAMLOCJKIM, MPCHPJPHOFA GEDKNKKDHOF = MPCHPJPHOFA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3E5E840", Offset = "0x3E5D240", VA = "0x183E5E840", Slot = "15")]
			public void AGMLDLCGDGN(T NBNOMDAKOCG, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3E5E870", Offset = "0x3E5D270", VA = "0x183E5E870", Slot = "16")]
			public void AGMLDLCGDGN(T NBNOMDAKOCG, Transform NNNEKOPBKOD, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3E5E8C0", Offset = "0x3E5D2C0", VA = "0x183E5E8C0", Slot = "17")]
			public void BKNMIOLEDCJ(T NBNOMDAKOCG, [Optional] float? KHPBNPIIPMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3E5E8E0", Offset = "0x3E5D2E0", VA = "0x183E5E8E0", Slot = "18")]
			public void FJEBMLODAAK(T LILGPDENNHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x3E5E8A0", Offset = "0x3E5D2A0", VA = "0x183E5E8A0", Slot = "19")]
			public FCDCKNBKJML BBCJDADENAF(T NBNOMDAKOCG)
			{
				return default(FCDCKNBKJML);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3E5E900", Offset = "0x3E5D300", VA = "0x183E5E900", Slot = "20")]
			public bool FJJDFBCKGOK(T NBNOMDAKOCG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3E5E920", Offset = "0x3E5D320", VA = "0x183E5E920", Slot = "21")]
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
				[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
				[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
				[Cpp2IlInjected.Address(RVA = "0x727020", Offset = "0x725A20", VA = "0x180727020", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int DMEAPIODOKJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x7270E0", Offset = "0x725AE0", VA = "0x1807270E0", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x69B14C0", Offset = "0x69AFEC0", VA = "0x1869B14C0")]
			internal CGGMFEDJAKA(int NOLMAMFJOEA, float[] HAAMLOCJKIM, MPCHPJPHOFA GEDKNKKDHOF = MPCHPJPHOFA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x69B0BD0", Offset = "0x69AF5D0", VA = "0x1869B0BD0")]
			public void HNOEBFBOACF(bool KJDPMJJFOPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x69B0EF0", Offset = "0x69AF8F0", VA = "0x1869B0EF0", Slot = "7")]
			public FCDCKNBKJML NGPFGLFICJL(float FLFEPFNINBJ)
			{
				return default(FCDCKNBKJML);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x69AF5E0", Offset = "0x69ADFE0", VA = "0x1869AF5E0", Slot = "8")]
			public void AGMLDLCGDGN(FLCKAICBODN NBNOMDAKOCG, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x69AF670", Offset = "0x69AE070", VA = "0x1869AF670", Slot = "9")]
			public void AGMLDLCGDGN(FLCKAICBODN NBNOMDAKOCG, Transform NNNEKOPBKOD, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x69AF460", Offset = "0x69ADE60", VA = "0x1869AF460")]
			public void AFLLDBFCNFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x69AFBD0", Offset = "0x69AE5D0", VA = "0x1869AFBD0", Slot = "10")]
			public void BKNMIOLEDCJ(FLCKAICBODN NBNOMDAKOCG, [Optional] float? KHPBNPIIPMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x69B0A70", Offset = "0x69AF470", VA = "0x1869B0A70")]
			private void HNNMCBIGPPG(int EGNHJGKABLC, [Optional] float? KHPBNPIIPMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x69AFEF0", Offset = "0x69AE8F0", VA = "0x1869AFEF0", Slot = "11")]
			public void FJEBMLODAAK(FLCKAICBODN LILGPDENNHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x69AFAC0", Offset = "0x69AE4C0", VA = "0x1869AFAC0", Slot = "12")]
			public FCDCKNBKJML BBCJDADENAF(FLCKAICBODN NBNOMDAKOCG)
			{
				return default(FCDCKNBKJML);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x69B0320", Offset = "0x69AED20", VA = "0x1869B0320", Slot = "13")]
			public bool FJJDFBCKGOK(FLCKAICBODN NBNOMDAKOCG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x69B0E00", Offset = "0x69AF800", VA = "0x1869B0E00", Slot = "14")]
			public void LJMKICNDLAI(FLCKAICBODN NBNOMDAKOCG, FJJLEAMIEBC AHNJDBMDPKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x69AFC50", Offset = "0x69AE650", VA = "0x1869AFC50", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x69B10D0", Offset = "0x69AFAD0", VA = "0x1869B10D0")]
			private void OIAMDHGKGLI(FKEMIOANGAC EPKAJCDDHEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x69B07D0", Offset = "0x69AF1D0", VA = "0x1869B07D0")]
			private void GEGAAFEEBFO(FKEMIOANGAC EPKAJCDDHEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x69B0420", Offset = "0x69AEE20", VA = "0x1869B0420")]
			private void FJJFLBBDNPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x69B0D90", Offset = "0x69AF790", VA = "0x1869B0D90")]
			private void LFKLCPDNBOG(float FFHPDJCFLBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x69B1490", Offset = "0x69AFE90", VA = "0x1869B1490")]
			private void PMBCCNJLKPI(FKEMIOANGAC EPKAJCDDHEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x69B0D80", Offset = "0x69AF780", VA = "0x1869B0D80")]
			private void LBKMGGOLJPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x69B0A60", Offset = "0x69AF460", VA = "0x1869B0A60")]
			private void GMLFNNNOELG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x69B0490", Offset = "0x69AEE90", VA = "0x1869B0490")]
			private void FKJAMABMHGB(CullingGroupEvent GFMIHKIADCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x69B0C00", Offset = "0x69AF600", VA = "0x1869B0C00")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public FNCKCCFNKKK OOABALNMOMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public FNCKCCFNKKK BFGKAOBLJCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool EKBEMIJIEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x18AE860", Offset = "0x18AD260", VA = "0x1818AE860", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CHLKOMPNDEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA4DB90", Offset = "0xA4C590", VA = "0x180A4DB90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA4DC10", Offset = "0xA4C610", VA = "0x180A4DC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69B1880", Offset = "0x69B0280", VA = "0x1869B1880", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xF3C840", Offset = "0xF3B240", VA = "0x180F3C840")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69B2300", Offset = "0x69B0D00", VA = "0x1869B2300")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69B21C0", Offset = "0x69B0BC0", VA = "0x1869B21C0")]
		private void NEHELEEIEPG(Scene OOOMPFGDEEN, LoadSceneMode FLAGJIBPLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69B2220", Offset = "0x69B0C20", VA = "0x1869B2220", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69B2550", Offset = "0x69B0F50", VA = "0x1869B2550")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69B2000", Offset = "0x69B0A00", VA = "0x1869B2000")]
		private void JCDBCKDLLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x69B2320", Offset = "0x69B0D20", VA = "0x1869B2320")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69B1E80", Offset = "0x69B0880", VA = "0x1869B1E80")]
		private void IBAIINALAGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69B1C90", Offset = "0x69B0690", VA = "0x1869B1C90")]
		public KKMENLLDAPN GetOrCreateCullingGroup(Type LIEBPIGKJGB, int JIGAKELLAMB, ushort DALOGAFPIOH = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x289E9E0", Offset = "0x289D3E0", VA = "0x18289E9E0")]
		public global::OGFHLCIPFED<T> GetOrCreateCullingGroup<T>(int JIGAKELLAMB, ushort DALOGAFPIOH = 0) where T : class, FLCKAICBODN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69B1AF0", Offset = "0x69B04F0", VA = "0x1869B1AF0")]
		private KKMENLLDAPN GNGDKHBAKPP(Type LIEBPIGKJGB, int JIGAKELLAMB, float[] HAAMLOCJKIM, ushort DALOGAFPIOH = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x289E7B0", Offset = "0x289D1B0", VA = "0x18289E7B0")]
		private global::OGFHLCIPFED<T> GNGDKHBAKPP<T>(int JIGAKELLAMB, float[] HAAMLOCJKIM, ushort DALOGAFPIOH = 0) where T : class, FLCKAICBODN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69B1950", Offset = "0x69B0350", VA = "0x1869B1950")]
		public static FCDCKNBKJML FindClosestDefaultUpdateLod(float ACGBGOMNAMK)
		{
			return default(FCDCKNBKJML);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x69B21B0", Offset = "0x69B0BB0", VA = "0x1869B21B0")]
		public static FCDCKNBKJML MinUpdateLod(FCDCKNBKJML DJJAGBOECJN, FCDCKNBKJML IPDCLPNNOLA)
		{
			return default(FCDCKNBKJML);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69B21A0", Offset = "0x69B0BA0", VA = "0x1869B21A0")]
		public static FCDCKNBKJML MaxUpdateLod(FCDCKNBKJML DJJAGBOECJN, FCDCKNBKJML IPDCLPNNOLA)
		{
			return default(FCDCKNBKJML);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69B2980", Offset = "0x69B1380", VA = "0x1869B2980")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B3130", Offset = "0x69B1B30", VA = "0x1869B3130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FCDCKNBKJML DEEPIDEAAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x727020", Offset = "0x725A20", VA = "0x180727020")]
		get
		{
			return default(FCDCKNBKJML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FCDCKNBKJML DGLFKGJFDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7270E0", Offset = "0x725AE0", VA = "0x1807270E0")]
		get
		{
			return default(FCDCKNBKJML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69B30C0", Offset = "0x69B1AC0", VA = "0x1869B30C0")]
	public bool CJNLKFPNHDF(object MIFCLBEAOPM, FCDCKNBKJML LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69B32E0", Offset = "0x69B1CE0", VA = "0x1869B32E0")]
	public bool PBFPIEEMKFJ(object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69B3180", Offset = "0x69B1B80", VA = "0x1869B3180")]
	private bool LHJNLBEAPOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69B3340", Offset = "0x69B1D40", VA = "0x1869B3340")]
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
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x69B2DE0", Offset = "0x69B17E0", VA = "0x1869B2DE0")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69B2A90", Offset = "0x69B1490", VA = "0x1869B2A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
