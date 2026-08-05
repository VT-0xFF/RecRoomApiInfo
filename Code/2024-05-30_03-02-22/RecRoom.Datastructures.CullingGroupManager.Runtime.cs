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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, OKLILHAGNLK
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class NNJOLPPMMPA<T> : FFEHJKJALLA, CEMFIBCFEII<T>, CJELFLNLFHN where T : class, FOINJLNNCBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x41D0010", Offset = "0x41CF210", VA = "0x1841D0010")]
			internal NNJOLPPMMPA(int OGPPFCADDKF, float[] HPLCLNBNOEE, ICGCBHKLCPB APBOHDHAENC = ICGCBHKLCPB.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x41CFFE0", Offset = "0x41CF1E0", VA = "0x1841CFFE0", Slot = "10")]
			public void LGLNKEHGBKE(T CDJAKLIPEBF, float HMEOAAPKBEC, HLACIDOJOGN PAPCDOOOLDM = HLACIDOJOGN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x41CFFB0", Offset = "0x41CF1B0", VA = "0x1841CFFB0", Slot = "11")]
			public void LGLNKEHGBKE(T CDJAKLIPEBF, Transform FCFFBMHOOHC, float HMEOAAPKBEC, HLACIDOJOGN PAPCDOOOLDM = HLACIDOJOGN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x41CFF90", Offset = "0x41CF190", VA = "0x1841CFF90", Slot = "12")]
			public void BIFLKBKPGJE(T GGJKDCADJDI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class FFEHJKJALLA : IDisposable, CJELFLNLFHN
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum ICGCBHKLCPB : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class BNLPPPNGAJC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public FOINJLNNCBD FNJNMMOAFKA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public HLACIDOJOGN KKPHFPOLKNC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action FPOPDIOFIGL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool IHHMHFBJMAA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int DMDPAHAMEGP;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
				public BNLPPPNGAJC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class BBOJFFIMOJE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public FFEHJKJALLA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public BNLPPPNGAJC trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
				public BBOJFFIMOJE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x63C8D60", Offset = "0x63C7F60", VA = "0x1863C8D60")]
				internal void FCHNMGDNJNO()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int FIDGBMKAPIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int OGPPFCADDKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int OFCOBKFBGFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool NHFBHKGIGAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup KAALDMGHBEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] EBABNEBMIJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] NIHNLOLAAJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly APPFCIJCFFB BJEABGEEHGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<FOINJLNNCBD, int> KEEMNPNFNJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, BNLPPPNGAJC> KIKLBGNFCDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly ICGCBHKLCPB APBOHDHAENC;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool OJKCAIHOAFG
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xE89BD0", Offset = "0xE88DD0", VA = "0x180E89BD0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x4186B60", Offset = "0x4185D60", VA = "0x184186B60", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x63CBCF0", Offset = "0x63CAEF0", VA = "0x1863CBCF0")]
			internal FFEHJKJALLA(int OGPPFCADDKF, float[] HPLCLNBNOEE, ICGCBHKLCPB APBOHDHAENC = ICGCBHKLCPB.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x63CBCC0", Offset = "0x63CAEC0", VA = "0x1863CBCC0")]
			public void PMCAPDFKPLD(bool KKOIPJMEKLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x63CB980", Offset = "0x63CAB80", VA = "0x1863CB980", Slot = "6")]
			public void LGLNKEHGBKE(FOINJLNNCBD CDJAKLIPEBF, float HMEOAAPKBEC, HLACIDOJOGN PAPCDOOOLDM = HLACIDOJOGN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x63CB580", Offset = "0x63CA780", VA = "0x1863CB580", Slot = "9")]
			public void LGLNKEHGBKE(FOINJLNNCBD CDJAKLIPEBF, Transform FCFFBMHOOHC, float HMEOAAPKBEC, HLACIDOJOGN PAPCDOOOLDM = HLACIDOJOGN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x63CBB10", Offset = "0x63CAD10", VA = "0x1863CBB10")]
			public void NOPHOHAAHML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x63CACC0", Offset = "0x63C9EC0", VA = "0x1863CACC0")]
			private void FBBFNKHCKEK(int PMNHOLIPOMJ, [Optional] float? HMEOAAPKBEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x63CA280", Offset = "0x63C9480", VA = "0x1863CA280", Slot = "7")]
			public void BIFLKBKPGJE(FOINJLNNCBD GGJKDCADJDI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63CBA20", Offset = "0x63CAC20", VA = "0x1863CBA20", Slot = "8")]
			public void NJLKAEAMEBO(FOINJLNNCBD CDJAKLIPEBF, HLACIDOJOGN IFLIOBCNMGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x63CAA00", Offset = "0x63C9C00", VA = "0x1863CAA00", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x63CA670", Offset = "0x63C9870", VA = "0x1863CA670")]
			private void DEMGBMDKKKJ(BNLPPPNGAJC DKGDONDNPAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x63CB110", Offset = "0x63CA310", VA = "0x1863CB110")]
			private void HDKNMPIFJPD(BNLPPPNGAJC DKGDONDNPAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x63CB3B0", Offset = "0x63CA5B0", VA = "0x1863CB3B0")]
			private void HHHOFPMFMNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x63CBC60", Offset = "0x63CAE60", VA = "0x1863CBC60")]
			private void PGCLIIFLCHC(float ADBEIAHCPGL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63CA140", Offset = "0x63C9340", VA = "0x1863CA140")]
			private void AKNAHKAFNDH(BNLPPPNGAJC DKGDONDNPAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x63CA130", Offset = "0x63C9330", VA = "0x1863CA130")]
			private void AANNOMEFECD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x63CBA10", Offset = "0x63CAC10", VA = "0x1863CBA10")]
			private void MCCLECNELAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x63CADF0", Offset = "0x63C9FF0", VA = "0x1863CADF0")]
			private void FBCEEBLGEIA(CullingGroupEvent LBKJIGHJPJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x63CB410", Offset = "0x63CA610", VA = "0x1863CB410")]
			private void HNLIBBAIJBB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct ONFPLJKCIGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort IKAGDIMOKBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type NLCEHKNCNLI;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float PKFCGJDMDBA = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float FGKKLMIAHFI = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float CONHOEPLCGA = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float FEIACEFALNI = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float JHJMGKKGDEE = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float DHIKLHFFMNP = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float NKMCDCFHPNF = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<ONFPLJKCIGA, FFEHJKJALLA> ENMJFMLCOFI;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable OFILAPDPBGK;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable LFOAAKEDNBB;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static OJHEJHCKNBB CCPKIEKCALI;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static OJHEJHCKNBB GFJCDKGMGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly OJHEJHCKNBB AHHDMLPFLPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly OJHEJHCKNBB FOHIENFJDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OJHEJHCKNBB FLOADKJPFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private MGBJAGNHOEE EOIFICCIHPH;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool KKOIPJMEKLC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public OJHEJHCKNBB BOEGPGHFENM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OJHEJHCKNBB DBFFMAOLNKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public OJHEJHCKNBB PGDJBGMHPON
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CKHCAAFJNJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xF038A0", Offset = "0xF02AA0", VA = "0x180F038A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BOMMNFGODAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x91A950", Offset = "0x919B50", VA = "0x18091A950", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x99DF40", Offset = "0x99D140", VA = "0x18099DF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x63C8EB0", Offset = "0x63C80B0", VA = "0x1863C8EB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x63C9960", Offset = "0x63C8B60", VA = "0x1863C9960")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x63C9940", Offset = "0x63C8B40", VA = "0x1863C9940")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x63C97F0", Offset = "0x63C89F0", VA = "0x1863C97F0")]
		private void MMHFNJIEHPO(Scene FOBJGNMALAM, LoadSceneMode CKIGLEMFOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x63C9860", Offset = "0x63C8A60", VA = "0x1863C9860", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x63C9BC0", Offset = "0x63C8DC0", VA = "0x1863C9BC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x63C94D0", Offset = "0x63C86D0", VA = "0x1863C94D0")]
		private void JNKFEFNFCDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63C9980", Offset = "0x63C8B80", VA = "0x1863C9980")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x63C9670", Offset = "0x63C8870", VA = "0x1863C9670")]
		private void LNBMANCNMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x63C90D0", Offset = "0x63C82D0", VA = "0x1863C90D0")]
		public CJELFLNLFHN GetOrCreateCullingGroup(Type NNFDCOCLIAA, int DFAOHFBIIEL, ushort FDALIGKCLOL = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x27FC410", Offset = "0x27FB610", VA = "0x1827FC410")]
		public CEMFIBCFEII<T> GetOrCreateCullingGroup<T>(int DFAOHFBIIEL, ushort FDALIGKCLOL = 0) where T : class, FOINJLNNCBD
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x63C92F0", Offset = "0x63C84F0", VA = "0x1863C92F0")]
		private CJELFLNLFHN HAJILPDGFPK(Type NNFDCOCLIAA, int DFAOHFBIIEL, float[] HPLCLNBNOEE, ushort FDALIGKCLOL = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x27FC4B0", Offset = "0x27FB6B0", VA = "0x1827FC4B0")]
		private CEMFIBCFEII<T> HAJILPDGFPK<T>(int DFAOHFBIIEL, float[] HPLCLNBNOEE, ushort FDALIGKCLOL = 0) where T : class, FOINJLNNCBD
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x63C8F70", Offset = "0x63C8170", VA = "0x1863C8F70")]
		public static IEIKJHNHGAC FindClosestDefaultUpdateLod(float IKHOMAJJMKC)
		{
			return default(IEIKJHNHGAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7F65C0", Offset = "0x7F57C0", VA = "0x1807F65C0")]
		public static IEIKJHNHGAC MinUpdateLod(IEIKJHNHGAC AEDLLPPMPEC, IEIKJHNHGAC BKENILKFEGD)
		{
			return default(IEIKJHNHGAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x63C9850", Offset = "0x63C8A50", VA = "0x1863C9850")]
		public static IEIKJHNHGAC MaxUpdateLod(IEIKJHNHGAC AEDLLPPMPEC, IEIKJHNHGAC BKENILKFEGD)
		{
			return default(IEIKJHNHGAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x63CA030", Offset = "0x63C9230", VA = "0x1863CA030")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface APPFCIJCFFB
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool DPDAMDIPLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera BMKCKIBCFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	OJHEJHCKNBB AAMONBPFAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BGCAHLKGILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OJHEJHCKNBB DNGLIFPOPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform PJMBOPGPFDM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CJELFLNLFHN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool OJKCAIHOAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGLNKEHGBKE(FOINJLNNCBD CDJAKLIPEBF, float HMEOAAPKBEC, HLACIDOJOGN PAPCDOOOLDM = HLACIDOJOGN.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BIFLKBKPGJE(FOINJLNNCBD GGJKDCADJDI);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NJLKAEAMEBO(FOINJLNNCBD CDJAKLIPEBF, HLACIDOJOGN PGMKOEGJICC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CEMFIBCFEII<T> : CJELFLNLFHN where T : class, FOINJLNNCBD
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGLNKEHGBKE(T CDJAKLIPEBF, float HMEOAAPKBEC, HLACIDOJOGN PAPCDOOOLDM = HLACIDOJOGN.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGLNKEHGBKE(T CDJAKLIPEBF, Transform FCFFBMHOOHC, float HMEOAAPKBEC, HLACIDOJOGN PAPCDOOOLDM = HLACIDOJOGN.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BIFLKBKPGJE(T GGJKDCADJDI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FOINJLNNCBD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform HANHCEFMJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(IEIKJHNHGAC DMFJEJONEHK, IEIKJHNHGAC JLJIKMDBAFL);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool NPGCEAJJJDI);
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
