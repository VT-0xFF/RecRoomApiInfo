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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, PPNLLFDFCCO, BEPIEELIFLK
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct HJNECOBFDFJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> DFPGGEDGGGN;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x78CCC90", Offset = "0x78CB690", VA = "0x1878CCC90", Slot = "4")]
			public void Execute(int DOAKEFBOPIA, TransformAccess GBIMAJCBFCJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct FDOCONPFEBB : IEquatable<FDOCONPFEBB>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort JEFGDJMMLLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type NEICAFBGNOK;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x78CCAB0", Offset = "0x78CB4B0", VA = "0x1878CCAB0", Slot = "4")]
			public bool Equals(FDOCONPFEBB OLKLGHOAKNE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x78CCB30", Offset = "0x78CB530", VA = "0x1878CCB30", Slot = "0")]
			public override bool Equals(object OIIGDBLKEDN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x78CCC20", Offset = "0x78CB620", VA = "0x1878CCC20", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class IOLAMAGLPLJ<T> : CDJKFLLKBDE, PLDODOEPLBB<T>, KMDJIMFKBFI where T : class, IGCNAGLMNLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4AA9C60", Offset = "0x4AA8660", VA = "0x184AA9C60")]
			internal IOLAMAGLPLJ(int NMKFELBPBMO, float[] LOCFPHKMEKI, BFLEJACBGID ALFKCJBFDKF = BFLEJACBGID.PlayerHead, bool CJPDIKKAMPI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4AA9C00", Offset = "0x4AA8600", VA = "0x184AA9C00", Slot = "12")]
			public void HEHCILJMFIP(T OIIGDBLKEDN, float OAIHKLDEKFL, JFFGEHLFDPP HPFOHCCCKGN = JFFGEHLFDPP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4AA9C30", Offset = "0x4AA8630", VA = "0x184AA9C30", Slot = "13")]
			public void HEHCILJMFIP(T OIIGDBLKEDN, Transform KDGEKEJNBHP, float OAIHKLDEKFL, JFFGEHLFDPP HPFOHCCCKGN = JFFGEHLFDPP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4AA9BC0", Offset = "0x4AA85C0", VA = "0x184AA9BC0", Slot = "14")]
			public void CBCJJMKDJJC(T POOAMIKBAHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4AA9BE0", Offset = "0x4AA85E0", VA = "0x184AA9BE0", Slot = "15")]
			public bool DAACOAAPKDI(T OIIGDBLKEDN)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class CDJKFLLKBDE : IDisposable, KMDJIMFKBFI
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct KENLJIKJNFN
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum HJMAENHMLAK : byte
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
				public IGCNAGLMNLD IBFGPMEBEHN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform GKBGOMKDLDP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float OLOBPPGFKCK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public JFFGEHLFDPP NBGPHALJGBK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public HJMAENHMLAK ABBLELNBDOD;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum BFLEJACBGID : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class MNAFKJFFICA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public IGCNAGLMNLD IBFGPMEBEHN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public JFFGEHLFDPP NJJBIJDBFPI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action PEIPFJPANBH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool GBFEDHPNFLE;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
				public MNAFKJFFICA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int AOMFOMGHHBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool CJPDIKKAMPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool AGGPBOPKIOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup PKLNBFJFJNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] IGJDFGHBCAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly MJBPKPLHBKL MPDODANMFLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly BFLEJACBGID ALFKCJBFDKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<IGCNAGLMNLD, int> HIGHENFJMEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, MNAFKJFFICA> LFIMANFKDIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray IFLANGJODLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> LCJAGLLHEFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<KENLJIKJNFN> BDFBIBCOKIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool LKOIBBOAMGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle GDFPJOCLDKE;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int GJPAGJNJKII
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x9B9180", Offset = "0x9B7B80", VA = "0x1809B9180")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int NBKMEAJCDAK
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xB16BF0", Offset = "0xB155F0", VA = "0x180B16BF0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xC01120", Offset = "0xBFFB20", VA = "0x180C01120")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x78CB100", Offset = "0x78C9B00", VA = "0x1878CB100")]
			internal CDJKFLLKBDE(int NMKFELBPBMO, float[] LOCFPHKMEKI, BFLEJACBGID ALFKCJBFDKF = BFLEJACBGID.PlayerHead, bool CJPDIKKAMPI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x78CAB90", Offset = "0x78C9590", VA = "0x1878CAB90")]
			public void NCLJDECMIOE(bool CDHBPJNHGDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x78CA6D0", Offset = "0x78C90D0", VA = "0x1878CA6D0", Slot = "5")]
			public void HEHCILJMFIP(IGCNAGLMNLD OIIGDBLKEDN, float OAIHKLDEKFL, JFFGEHLFDPP HPFOHCCCKGN = JFFGEHLFDPP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x78CA630", Offset = "0x78C9030", VA = "0x1878CA630", Slot = "10")]
			public void HEHCILJMFIP(IGCNAGLMNLD OIIGDBLKEDN, Transform KDGEKEJNBHP, float OAIHKLDEKFL, JFFGEHLFDPP HPFOHCCCKGN = JFFGEHLFDPP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x78CAD10", Offset = "0x78C9710", VA = "0x1878CAD10")]
			private void OOEGAOPNHEA(IGCNAGLMNLD OIIGDBLKEDN, Transform KDGEKEJNBHP, float OAIHKLDEKFL, JFFGEHLFDPP HPFOHCCCKGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x78C9EA0", Offset = "0x78C88A0", VA = "0x1878C9EA0", Slot = "6")]
			public void CBCJJMKDJJC(IGCNAGLMNLD POOAMIKBAHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x78C9A60", Offset = "0x78C8460", VA = "0x1878C9A60")]
			private void BJAJAPAJHPP(IGCNAGLMNLD POOAMIKBAHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x78C9800", Offset = "0x78C8200", VA = "0x1878C9800")]
			private void AOJCEGBBEBN(IGCNAGLMNLD OIIGDBLKEDN, [Optional] float? OAIHKLDEKFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x78C9F00", Offset = "0x78C8900", VA = "0x1878C9F00", Slot = "11")]
			public bool DAACOAAPKDI(IGCNAGLMNLD OIIGDBLKEDN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
			public void BHDMDLHMEPE(IGCNAGLMNLD OIIGDBLKEDN, JFFGEHLFDPP KBLKKGJLHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x78CA410", Offset = "0x78C8E10", VA = "0x1878CA410")]
			private void GADMBEMLBIC(IGCNAGLMNLD OIIGDBLKEDN, JFFGEHLFDPP KBLKKGJLHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x78CAAD0", Offset = "0x78C94D0", VA = "0x1878CAAD0")]
			public void MMOIFIFKICC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x78C9FD0", Offset = "0x78C89D0", VA = "0x1878C9FD0")]
			public void DGNINGEHFKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x78CA7D0", Offset = "0x78C91D0", VA = "0x1878CA7D0")]
			private void HONBFEMFOIF(KENLJIKJNFN LHJMDMLADDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x78CABC0", Offset = "0x78C95C0", VA = "0x1878CABC0")]
			private void OJJCINIOPKN(int ICEDJPMOMJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x78CA1E0", Offset = "0x78C8BE0", VA = "0x1878CA1E0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x78C94C0", Offset = "0x78C7EC0", VA = "0x1878C94C0")]
			private void AMGKBLNAEFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x78C9FC0", Offset = "0x78C89C0", VA = "0x1878C9FC0")]
			private void DAIDIHLDOCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x78C94D0", Offset = "0x78C7ED0", VA = "0x1878C94D0")]
			private void ANLKMKELGLO(CullingGroupEvent JIOGMBNEKGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x78CA4C0", Offset = "0x78C8EC0", VA = "0x1878CA4C0")]
			private void GHLCANLPLHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float DNIMDNPCJCM = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float LAJDCCPLBFL = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float HCPJCFDHGKI = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float AEECFKKHNML = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float PCFHOHNPFDD = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float LGCLAAEMJJB = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float KEBAKJALCOF = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<FDOCONPFEBB, CDJKFLLKBDE> MCDHOCHBPHE;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable HAKGKCIPDKJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable HEIBJAIJAEN;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static COOFKGJALFM CDDPBDLBBEH;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static COOFKGJALFM IKEJAFPIPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly COOFKGJALFM GFNJHOMJDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly COOFKGJALFM JBFIMGHHOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly COOFKGJALFM EIPLPNLNOEI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker JKEOABIJGAP;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker AFGHNLFFJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private NBLJJLKPDOF ICGJADPEHIP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool CDHBPJNHGDD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NDDOGAFPPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9AED90", Offset = "0x9AD790", VA = "0x1809AED90", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9AED70", Offset = "0x9AD770", VA = "0x1809AED70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public COOFKGJALFM MAPGGPNAAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public COOFKGJALFM MILMDLDEPBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public COOFKGJALFM MPFFGEIPKEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JBINHBCMJBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9DAAE0", Offset = "0x9D94E0", VA = "0x1809DAAE0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool EINNNKIAGHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xBAD060", Offset = "0xBABA60", VA = "0x180BAD060", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xC78470", Offset = "0xC76E70", VA = "0x180C78470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x78CB5E0", Offset = "0x78C9FE0", VA = "0x1878CB5E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x78CC040", Offset = "0x78CAA40", VA = "0x1878CC040")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1D78C70", Offset = "0x1D77670", VA = "0x181D78C70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB5F310", Offset = "0xB5DD10", VA = "0x180B5F310")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x78CBCB0", Offset = "0x78CA6B0", VA = "0x1878CBCB0")]
		private void HIAAEJPBGMD(Scene FHMFNFPPKKJ, LoadSceneMode NDELDEDNMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x78CBF60", Offset = "0x78CA960", VA = "0x1878CBF60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x78CC480", Offset = "0x78CAE80", VA = "0x1878CC480")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78CBD10", Offset = "0x78CA710", VA = "0x1878CBD10")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78CB6A0", Offset = "0x78CA0A0", VA = "0x1878CB6A0")]
		private void EIJECDBPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x78CC1F0", Offset = "0x78CABF0", VA = "0x1878CC1F0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x78CB960", Offset = "0x78CA360", VA = "0x1878CB960")]
		private void GINJPDGIDAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x78CBAD0", Offset = "0x78CA4D0", VA = "0x1878CBAD0")]
		public KMDJIMFKBFI GetOrCreateCullingGroup(Type CDGKGANKCNI, int GPMECLFOKHM, ushort IFKALHELMGJ = 0, bool CJPDIKKAMPI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x345A630", Offset = "0x3459030", VA = "0x18345A630")]
		public PLDODOEPLBB<T> GetOrCreateCullingGroup<T>(int GPMECLFOKHM, ushort IFKALHELMGJ = 0, bool CJPDIKKAMPI = false) where T : class, IGCNAGLMNLD
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x78CC060", Offset = "0x78CAA60", VA = "0x1878CC060")]
		private KMDJIMFKBFI PGIIJKGHHHM(Type CDGKGANKCNI, int GPMECLFOKHM, float[] LOCFPHKMEKI, ushort IFKALHELMGJ = 0, bool CJPDIKKAMPI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x345A6F0", Offset = "0x34590F0", VA = "0x18345A6F0")]
		private PLDODOEPLBB<T> PGIIJKGHHHM<T>(int GPMECLFOKHM, float[] LOCFPHKMEKI, ushort IFKALHELMGJ = 0, bool CJPDIKKAMPI = false) where T : class, IGCNAGLMNLD
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x78CB800", Offset = "0x78CA200", VA = "0x1878CB800")]
		public static HNIGDDENMGF FindClosestDefaultUpdateLod(float JLLAHHDGAPI)
		{
			return default(HNIGDDENMGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9DB050", Offset = "0x9D9A50", VA = "0x1809DB050")]
		public static HNIGDDENMGF MinUpdateLod(HNIGDDENMGF IOGCPOEMBEJ, HNIGDDENMGF LJCPIAAOIEK)
		{
			return default(HNIGDDENMGF);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x78CBF50", Offset = "0x78CA950", VA = "0x1878CBF50")]
		public static HNIGDDENMGF MaxUpdateLod(HNIGDDENMGF IOGCPOEMBEJ, HNIGDDENMGF LJCPIAAOIEK)
		{
			return default(HNIGDDENMGF);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x78CC960", Offset = "0x78CB360", VA = "0x1878CC960")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9DAAE0", Offset = "0x9D94E0", VA = "0x1809DAAE0", Slot = "11")]
		private bool PGJKCKIKBII()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MJBPKPLHBKL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool AHNLOEONAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera IGLIJHNHEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	COOFKGJALFM IAGCAFKONAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool CBENNKGBGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	COOFKGJALFM FLACBEIKAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform DHHHDINHOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KMDJIMFKBFI
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEHCILJMFIP(IGCNAGLMNLD OIIGDBLKEDN, float OAIHKLDEKFL, JFFGEHLFDPP HPFOHCCCKGN = JFFGEHLFDPP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBCJJMKDJJC(IGCNAGLMNLD POOAMIKBAHP);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHDMDLHMEPE(IGCNAGLMNLD OIIGDBLKEDN, JFFGEHLFDPP ECEFHLCNLLG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PLDODOEPLBB<T> : KMDJIMFKBFI where T : class, IGCNAGLMNLD
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEHCILJMFIP(T OIIGDBLKEDN, float OAIHKLDEKFL, JFFGEHLFDPP HPFOHCCCKGN = JFFGEHLFDPP.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEHCILJMFIP(T OIIGDBLKEDN, Transform KDGEKEJNBHP, float OAIHKLDEKFL, JFFGEHLFDPP HPFOHCCCKGN = JFFGEHLFDPP.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CBCJJMKDJJC(T POOAMIKBAHP);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DAACOAAPKDI(T OIIGDBLKEDN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IGCNAGLMNLD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform GBIMAJCBFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(HNIGDDENMGF MEFBKDGPDKJ, HNIGDDENMGF FBHGGEBAIBM);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool BJNPGOKOJIA);
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
