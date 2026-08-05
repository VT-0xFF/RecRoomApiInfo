using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, GHOJMPLOGCA, LCCLDLHOIOG
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct NBHMNHDEGAB : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> LJELDKAOCJM;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x75BD5F0", Offset = "0x75BC7F0", VA = "0x1875BD5F0", Slot = "4")]
			public void Execute(int KOOLKCPAFBB, TransformAccess LBAHEDDLOKA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct FBCFEKMLMAL : IEquatable<FBCFEKMLMAL>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort NNOFPHMHHAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type NAGDEFHHGJA;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x75BD410", Offset = "0x75BC610", VA = "0x1875BD410", Slot = "4")]
			public bool Equals(FBCFEKMLMAL LDKNLBHIGFL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x75BD490", Offset = "0x75BC690", VA = "0x1875BD490", Slot = "0")]
			public override bool Equals(object ONELFPFEALD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x75BD580", Offset = "0x75BC780", VA = "0x1875BD580", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class MBPMKGFDNFM<T> : BNCDMKNJBIC, AHKLCEEPIHP<T>, FKOBCEMDEIN where T : class, EALHLPODMHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4D8A780", Offset = "0x4D89980", VA = "0x184D8A780")]
			internal MBPMKGFDNFM(int HOFFJGCIFOH, float[] BHNBGCFLCLE, PEGDNONFCKE BPCAHGFFLCC = PEGDNONFCKE.PlayerHead, bool AAALLKOPJCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4D8A6E0", Offset = "0x4D898E0", VA = "0x184D8A6E0", Slot = "12")]
			public void OFEFHMDJLMD(T ONELFPFEALD, float LDCGEIMNGOD, DFMIAGBKIML GNEAKHFGFLC = DFMIAGBKIML.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4D8A710", Offset = "0x4D89910", VA = "0x184D8A710", Slot = "13")]
			public void OFEFHMDJLMD(T ONELFPFEALD, Transform ECHALNPNNOO, float LDCGEIMNGOD, DFMIAGBKIML GNEAKHFGFLC = DFMIAGBKIML.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4D8A740", Offset = "0x4D89940", VA = "0x184D8A740", Slot = "14")]
			public void OGPGHNCGHLC(T DMINEEDJFAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4D8A760", Offset = "0x4D89960", VA = "0x184D8A760", Slot = "15")]
			public bool OMADKIDACBN(T ONELFPFEALD)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class BNCDMKNJBIC : IDisposable, FKOBCEMDEIN
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct CKLOHBIPHNI
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum OKPOHKCDAJE : byte
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
				public EALHLPODMHD LLFABGIMMEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform FFFKHKBLIED;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float MOHEKKJJHAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public DFMIAGBKIML MBNLKKBBLIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public OKPOHKCDAJE FCLHHMOEMEB;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum PEGDNONFCKE : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class KFJNMNPELKP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public EALHLPODMHD LLFABGIMMEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public DFMIAGBKIML NKCCLLKCBIN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action FLEDLFPJKLP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool DMJKMMMNNIJ;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
				public KFJNMNPELKP()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int NNCKPODCGGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool AAALLKOPJCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool FEHOKBMGFLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup CGIDACDDFJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] GGGNBOPGCNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly OADDOFLCCDL EKJOCLHFECK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly PEGDNONFCKE BPCAHGFFLCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<EALHLPODMHD, int> NIDGPPAGPND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, KFJNMNPELKP> BPICNPLODMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray CIIBNNFOODH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> JCENEJBBHAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<CKLOHBIPHNI> POBPBBBHDKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool FBPEJFNOOAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle IBAHKKADFPN;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int APGMHCADLCG
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x971850", Offset = "0x970A50", VA = "0x180971850")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int NGACONPFEPN
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA8A290", Offset = "0xA89490", VA = "0x180A8A290", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB62C10", Offset = "0xB61E10", VA = "0x180B62C10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x75BBA60", Offset = "0x75BAC60", VA = "0x1875BBA60")]
			internal BNCDMKNJBIC(int HOFFJGCIFOH, float[] BHNBGCFLCLE, PEGDNONFCKE BPCAHGFFLCC = PEGDNONFCKE.PlayerHead, bool AAALLKOPJCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x75BAF30", Offset = "0x75BA130", VA = "0x1875BAF30")]
			public void JEKIHLDNIOJ(bool PPPFFGDDNGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x75BB3F0", Offset = "0x75BA5F0", VA = "0x1875BB3F0", Slot = "5")]
			public void OFEFHMDJLMD(EALHLPODMHD ONELFPFEALD, float LDCGEIMNGOD, DFMIAGBKIML GNEAKHFGFLC = DFMIAGBKIML.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x75BB4F0", Offset = "0x75BA6F0", VA = "0x1875BB4F0", Slot = "10")]
			public void OFEFHMDJLMD(EALHLPODMHD ONELFPFEALD, Transform ECHALNPNNOO, float LDCGEIMNGOD, DFMIAGBKIML GNEAKHFGFLC = DFMIAGBKIML.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x75B9EF0", Offset = "0x75B90F0", VA = "0x1875B9EF0")]
			private void CNLOBPCBION(EALHLPODMHD ONELFPFEALD, Transform ECHALNPNNOO, float LDCGEIMNGOD, DFMIAGBKIML GNEAKHFGFLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x75BB590", Offset = "0x75BA790", VA = "0x1875BB590", Slot = "6")]
			public void OGPGHNCGHLC(EALHLPODMHD DMINEEDJFAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x75BA680", Offset = "0x75B9880", VA = "0x1875BA680")]
			private void GDDBJFEKCDF(EALHLPODMHD DMINEEDJFAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x75BACD0", Offset = "0x75B9ED0", VA = "0x1875BACD0")]
			private void HOJOIMBJACH(EALHLPODMHD ONELFPFEALD, [Optional] float? LDCGEIMNGOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x75BB6A0", Offset = "0x75BA8A0", VA = "0x1875BB6A0", Slot = "11")]
			public bool OMADKIDACBN(EALHLPODMHD ONELFPFEALD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "7")]
			public void EAAIPHAPDHH(EALHLPODMHD ONELFPFEALD, DFMIAGBKIML OMPKMPGBEMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x75BB5F0", Offset = "0x75BA7F0", VA = "0x1875BB5F0")]
			private void OIDOIONOFEK(EALHLPODMHD ONELFPFEALD, DFMIAGBKIML OMPKMPGBEMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x75B9E20", Offset = "0x75B9020", VA = "0x1875B9E20")]
			public void BFJBKOEEAKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x75BAAC0", Offset = "0x75B9CC0", VA = "0x1875BAAC0")]
			public void GMIBILOLLDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x75BB760", Offset = "0x75BA960", VA = "0x1875BB760")]
			private void PODMEDAKHIA(CKLOHBIPHNI CPCFIJBFPJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x75BB290", Offset = "0x75BA490", VA = "0x1875BB290")]
			private void MKEENEGIOND(int KFOBHJHKBMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x75BA2E0", Offset = "0x75B94E0", VA = "0x1875BA2E0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x75BB3E0", Offset = "0x75BA5E0", VA = "0x1875BB3E0")]
			private void MKICOOKBBPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x75B9EE0", Offset = "0x75B90E0", VA = "0x1875B9EE0")]
			private void BHIBNHAKOCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x75BAF60", Offset = "0x75BA160", VA = "0x1875BAF60")]
			private void KKCBMHCHOAF(CullingGroupEvent JPPGHOEFIIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x75BA510", Offset = "0x75B9710", VA = "0x1875BA510")]
			private void GBKLPKEDIMH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float PMDALKFLDAO = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float BHHMLDDNOCB = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float FJLGNFOHCDM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float MJKBLONKLKP = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float CPNCIKAAKKH = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float GMABCGEFHII = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float JGKOKHJJHHK = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<FBCFEKMLMAL, BNCDMKNJBIC> EJABGEJGBEK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable AHOBFKEAEKO;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable DAPFAEMOGJH;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static MIOEGIOIKAG GDMCACIKGMA;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static MIOEGIOIKAG LKDCPAIGMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly MIOEGIOIKAG ALFOELCKMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MIOEGIOIKAG BPBJDOAKNOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MIOEGIOIKAG DMFJADGJIEJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker EOCHPKMFOIL;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker COPEOKCLLNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private PHFJKNHMAKK POMJIPCFACB;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool PPPFFGDDNGD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool HJKOOPCMMKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x964F10", Offset = "0x964110", VA = "0x180964F10", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x964F50", Offset = "0x964150", VA = "0x180964F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MIOEGIOIKAG CAJDBKKBGKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MIOEGIOIKAG MJPOBNMAJMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MIOEGIOIKAG DEHLEHOMLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool AFEOGAMCBBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x98F840", Offset = "0x98EA40", VA = "0x18098F840", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool CFNCCEALGAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB05420", Offset = "0xB04620", VA = "0x180B05420", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xBF5DE0", Offset = "0xBF4FE0", VA = "0x180BF5DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x75BBF40", Offset = "0x75BB140", VA = "0x1875BBF40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x75BCB30", Offset = "0x75BBD30", VA = "0x1875BCB30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1C8C680", Offset = "0x1C8B880", VA = "0x181C8C680")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAF5710", Offset = "0xAF4910", VA = "0x180AF5710")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x75BC860", Offset = "0x75BBA60", VA = "0x1875BC860")]
		private void NPDMKEGMJCE(Scene ILIEDPLAPMG, LoadSceneMode PCJPKAENIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x75BCA50", Offset = "0x75BBC50", VA = "0x1875BCA50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x75BCDE0", Offset = "0x75BBFE0", VA = "0x1875BCDE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75BC610", Offset = "0x75BB810", VA = "0x1875BC610")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x75BC000", Offset = "0x75BB200", VA = "0x1875BC000")]
		private void BGCJINDCPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75BCB50", Offset = "0x75BBD50", VA = "0x1875BCB50")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x75BC4A0", Offset = "0x75BB6A0", VA = "0x1875BC4A0")]
		private void IIIFBGCFEBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x75BC2C0", Offset = "0x75BB4C0", VA = "0x1875BC2C0")]
		public FKOBCEMDEIN GetOrCreateCullingGroup(Type FNGJAABCINB, int FGACDBIPBKK, ushort KFPFLNICBHM = 0, bool AAALLKOPJCK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x32BE1B0", Offset = "0x32BD3B0", VA = "0x1832BE1B0")]
		public AHKLCEEPIHP<T> GetOrCreateCullingGroup<T>(int FGACDBIPBKK, ushort KFPFLNICBHM = 0, bool AAALLKOPJCK = false) where T : class, EALHLPODMHD
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x75BC8C0", Offset = "0x75BBAC0", VA = "0x1875BC8C0")]
		private FKOBCEMDEIN OLOLIAFFEKO(Type FNGJAABCINB, int FGACDBIPBKK, float[] BHNBGCFLCLE, ushort KFPFLNICBHM = 0, bool AAALLKOPJCK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x32BE270", Offset = "0x32BD470", VA = "0x1832BE270")]
		private AHKLCEEPIHP<T> OLOLIAFFEKO<T>(int FGACDBIPBKK, float[] BHNBGCFLCLE, ushort KFPFLNICBHM = 0, bool AAALLKOPJCK = false) where T : class, EALHLPODMHD
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75BC160", Offset = "0x75BB360", VA = "0x1875BC160")]
		public static OJGJEEMDGCF FindClosestDefaultUpdateLod(float MHFAJNGONHD)
		{
			return default(OJGJEEMDGCF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x990230", Offset = "0x98F430", VA = "0x180990230")]
		public static OJGJEEMDGCF MinUpdateLod(OJGJEEMDGCF BOABBNCOBFC, OJGJEEMDGCF DGJKCGNLIJE)
		{
			return default(OJGJEEMDGCF);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x75BC850", Offset = "0x75BBA50", VA = "0x1875BC850")]
		public static OJGJEEMDGCF MaxUpdateLod(OJGJEEMDGCF BOABBNCOBFC, OJGJEEMDGCF DGJKCGNLIJE)
		{
			return default(OJGJEEMDGCF);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x75BD2C0", Offset = "0x75BC4C0", VA = "0x1875BD2C0")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x98F840", Offset = "0x98EA40", VA = "0x18098F840", Slot = "11")]
		private bool CMAJBKMNFCF()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OADDOFLCCDL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool FDLOLDLGEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera NDLLHBMGKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MIOEGIOIKAG GNOBKFGJENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool KCPJCFJJFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	MIOEGIOIKAG ACDMKOIOMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform FIGOKJCPKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FKOBCEMDEIN
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFEFHMDJLMD(EALHLPODMHD ONELFPFEALD, float LDCGEIMNGOD, DFMIAGBKIML GNEAKHFGFLC = DFMIAGBKIML.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGPGHNCGHLC(EALHLPODMHD DMINEEDJFAI);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EAAIPHAPDHH(EALHLPODMHD ONELFPFEALD, DFMIAGBKIML LLAEOFPAHMA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AHKLCEEPIHP<T> : FKOBCEMDEIN where T : class, EALHLPODMHD
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFEFHMDJLMD(T ONELFPFEALD, float LDCGEIMNGOD, DFMIAGBKIML GNEAKHFGFLC = DFMIAGBKIML.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFEFHMDJLMD(T ONELFPFEALD, Transform ECHALNPNNOO, float LDCGEIMNGOD, DFMIAGBKIML GNEAKHFGFLC = DFMIAGBKIML.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OGPGHNCGHLC(T DMINEEDJFAI);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OMADKIDACBN(T ONELFPFEALD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EALHLPODMHD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform LBAHEDDLOKA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(OJGJEEMDGCF HLCBPMGFKGN, OJGJEEMDGCF FGKKDPKFMGI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool BICMOCINKIA);
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
