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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, NIEOJLEHPGM
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class KODFHPHNFKG : IDisposable, APKHKBCEJJB
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int NCIIDDHGKOD
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int GODAFKMALMC
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(Slot = "9")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void Dispose();

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void GDDNLCKAHLF(bool BCLHDPJJAMC);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
			protected KODFHPHNFKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class HBCBECNOFKC<T> : KODFHPHNFKG, global::ONKNECGIPHB<T>, APKHKBCEJJB where T : DICCKHJDMDJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum GCGMJPMBEIJ : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class EEPONKNNPNG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T ODMNJCEONDC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public PJMOFIHCHFB PHCGLLGAGJJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action PCIIPKJIHAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool DFNKOLNGKNO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int NBBAFHCPDPA;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
				public EEPONKNNPNG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class KNFFOMJHICM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public HBCBECNOFKC<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public EEPONKNNPNG trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
				public KNFFOMJHICM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int LBJFBEGGFBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int MEOBGNJPAAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int PKEDONBOCAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool KMDCHDFHKAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup JFJKECIJECB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] EJKAOGGNPEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] JFKELIEIAGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly JKLEOAHAGCP LJFGGELDADC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> JBKDOBKNMDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, EEPONKNNPNG> INHNDFFIAGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly GCGMJPMBEIJ KKAOGOGAJHK;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int NCIIDDHGKOD
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x58CED0", Offset = "0x58BED0", VA = "0x18058CED0", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int GODAFKMALMC
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x5B0710", Offset = "0x5AF710", VA = "0x1805B0710", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1E45BB0", Offset = "0x1E44BB0", VA = "0x181E45BB0")]
			internal HBCBECNOFKC(int MEOBGNJPAAH, float[] IOLLENIKOOM, GCGMJPMBEIJ KKAOGOGAJHK = GCGMJPMBEIJ.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1E44A90", Offset = "0x1E43A90", VA = "0x181E44A90", Slot = "10")]
			public override void GDDNLCKAHLF(bool BCLHDPJJAMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1E458D0", Offset = "0x1E448D0", VA = "0x181E458D0", Slot = "11")]
			public JGCOHINBIPD PHDFANJMOJI(float OAFICANANKF)
			{
				return default(JGCOHINBIPD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1E457C0", Offset = "0x1E447C0", VA = "0x181E457C0", Slot = "12")]
			public void NJFAMEHLCGO(T OOJKHPLJJMJ, float PBIHCCGIOHI, PJMOFIHCHFB PNADMPHKIJE = PJMOFIHCHFB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1E45340", Offset = "0x1E44340", VA = "0x181E45340", Slot = "13")]
			public void NJFAMEHLCGO(T OOJKHPLJJMJ, Transform DHILNGHPABG, float PBIHCCGIOHI, PJMOFIHCHFB PNADMPHKIJE = PJMOFIHCHFB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1E44D60", Offset = "0x1E43D60", VA = "0x181E44D60", Slot = "14")]
			public void IIEKFGCNMBA(T OOJKHPLJJMJ, [Optional] float? PBIHCCGIOHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1E45180", Offset = "0x1E44180", VA = "0x181E45180")]
			private void JBIBPEPGDJF(int FBOCJCCNMND, [Optional] float? PBIHCCGIOHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1E44DE0", Offset = "0x1E43DE0", VA = "0x181E44DE0", Slot = "15")]
			public void INAIIIEHGLD(T EMDIAHLGDLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1E44C40", Offset = "0x1E43C40", VA = "0x181E44C40", Slot = "16")]
			public JGCOHINBIPD IGKNGKOGIEH(T OOJKHPLJJMJ)
			{
				return default(JGCOHINBIPD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1E44990", Offset = "0x1E43990", VA = "0x181E44990", Slot = "17")]
			public bool FJJPMKIOJEN(T OOJKHPLJJMJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1E44B30", Offset = "0x1E43B30", VA = "0x181E44B30", Slot = "18")]
			public void HEKIAPCLBIM(T OOJKHPLJJMJ, PJMOFIHCHFB IMJBCGIKFLK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1E44220", Offset = "0x1E43220", VA = "0x181E44220", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1E445A0", Offset = "0x1E435A0", VA = "0x181E445A0")]
			private void FANDAMBDHBP(EEPONKNNPNG IODKNIFAOPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1E45930", Offset = "0x1E44930", VA = "0x181E45930")]
			private void POIOHOOPEHF(EEPONKNNPNG IODKNIFAOPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1E45860", Offset = "0x1E44860", VA = "0x181E45860")]
			private void OCFDNOPBCKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1E44AC0", Offset = "0x1E43AC0", VA = "0x181E44AC0")]
			private void GHLJHLCCNJE(float IEBFJHJEJCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1E44950", Offset = "0x1E43950", VA = "0x181E44950")]
			private void FGCMDLIFAKA(EEPONKNNPNG IODKNIFAOPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1E45320", Offset = "0x1E44320", VA = "0x181E45320")]
			private void MLCFAOBBGMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1E452F0", Offset = "0x1E442F0", VA = "0x181E452F0")]
			private void JMDMGDCOEFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1E43F70", Offset = "0x1E42F70", VA = "0x181E43F70")]
			private void CPIJKKBBHDG(CullingGroupEvent BGNBOBJALLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1E43E00", Offset = "0x1E42E00", VA = "0x181E43E00")]
			private void CGCPBAKLPKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct MHIFOJGHCPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort LEHBEOJEIEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type CHIJEDDNNFA;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float CBKDPJDGGGD = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float EEKOMCIKKCK = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float HGMELILECOI = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float HAAKJFIKCPN = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float FICOONGKBEA = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float NCEGPCLLLIA = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float GNLAGLBBFDI = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<MHIFOJGHCPD, KODFHPHNFKG> MDOLNKJGHBO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable KNOMEDDEIIE;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable CBEFNPDMHOP;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IPAFKFONBKE KAIGKOINFGP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IPAFKFONBKE IPCACNKJGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly IPAFKFONBKE JJFPOLCMIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly IPAFKFONBKE KBFKAICGMNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IPAFKFONBKE IAPGJFNCJLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private DMIEKLLPPEA JGAHDLGDGNE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool BCLHDPJJAMC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public IPAFKFONBKE HJDKKHJFJCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IPAFKFONBKE NNADHFBIIII
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x58EDF0", Offset = "0x58DDF0", VA = "0x18058EDF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IPAFKFONBKE OCJKKEGCNDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5B50C0", Offset = "0x5B40C0", VA = "0x1805B50C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool HICNGEIPNGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x12B23F0", Offset = "0x12B13F0", VA = "0x1812B23F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ABALPIJOKCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x77DB70", Offset = "0x77CB70", VA = "0x18077DB70", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x77DBF0", Offset = "0x77CBF0", VA = "0x18077DBF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x51F91F0", Offset = "0x51F81F0", VA = "0x1851F91F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE56970", Offset = "0xE55970", VA = "0x180E56970")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x51F98F0", Offset = "0x51F88F0", VA = "0x1851F98F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x51F9910", Offset = "0x51F8910", VA = "0x1851F9910")]
		private void PJOANMFOJDN(Scene HMHKGPEHPDL, LoadSceneMode NLPCHIBFNAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x51F9840", Offset = "0x51F8840", VA = "0x1851F9840", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x51F9290", Offset = "0x51F8290", VA = "0x1851F9290")]
		private void ECFNDLAAPHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x51F9970", Offset = "0x51F8970", VA = "0x1851F9970")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x51F96E0", Offset = "0x51F86E0", VA = "0x1851F96E0")]
		private void ODHIFIJLOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2282AA0", Offset = "0x2281AA0", VA = "0x182282AA0")]
		public global::ONKNECGIPHB<T> GetOrCreateCullingGroup<T>(int BBGCONNOLBA, ushort JPECFJKEKEO = 0) where T : DICCKHJDMDJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2282B50", Offset = "0x2281B50", VA = "0x182282B50")]
		private global::ONKNECGIPHB<T> PFOLLIDLHEE<T>(int BBGCONNOLBA, float[] IOLLENIKOOM, ushort JPECFJKEKEO = 0) where T : DICCKHJDMDJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x51F9430", Offset = "0x51F8430", VA = "0x1851F9430")]
		public static JGCOHINBIPD FindClosestDefaultUpdateLod(float JOLONAABLOB)
		{
			return default(JGCOHINBIPD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x51F9680", Offset = "0x51F8680", VA = "0x1851F9680")]
		public static JGCOHINBIPD MinUpdateLod(JGCOHINBIPD HMADBBAENBP, JGCOHINBIPD PNDCNMDMHBL)
		{
			return default(JGCOHINBIPD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x51F9620", Offset = "0x51F8620", VA = "0x1851F9620")]
		public static JGCOHINBIPD MaxUpdateLod(JGCOHINBIPD HMADBBAENBP, JGCOHINBIPD PNDCNMDMHBL)
		{
			return default(JGCOHINBIPD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x51F9D00", Offset = "0x51F8D00", VA = "0x1851F9D00")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JKLEOAHAGCP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GKKDCBEALGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera KCAGJPFECGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IPAFKFONBKE MIMLGCCLNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool ODPPBPHHDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IPAFKFONBKE AEEONEICDPM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform IJOONHJOKOF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface APKHKBCEJJB
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int NCIIDDHGKOD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int GODAFKMALMC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ONKNECGIPHB<T> : APKHKBCEJJB where T : DICCKHJDMDJ
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JGCOHINBIPD PHDFANJMOJI(float OAFICANANKF);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJFAMEHLCGO(T OOJKHPLJJMJ, float PBIHCCGIOHI, PJMOFIHCHFB PNADMPHKIJE = PJMOFIHCHFB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJFAMEHLCGO(T OOJKHPLJJMJ, Transform DHILNGHPABG, float PBIHCCGIOHI, PJMOFIHCHFB PNADMPHKIJE = PJMOFIHCHFB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IIEKFGCNMBA(T OOJKHPLJJMJ, [Optional] float? PBIHCCGIOHI);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void INAIIIEHGLD(T EMDIAHLGDLN);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JGCOHINBIPD IGKNGKOGIEH(T OOJKHPLJJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FJJPMKIOJEN(T OOJKHPLJJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HEKIAPCLBIM(T OOJKHPLJJMJ, PJMOFIHCHFB CJNLLAPGOAD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DICCKHJDMDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform BIIKDGKEDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(JGCOHINBIPD CJAAAIAEHIF, JGCOHINBIPD PHAMHFKBMOP);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool DMANJPLPEJD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum PJMOFIHCHFB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum JGCOHINBIPD
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
public class EIADKJCAFPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JGCOHINBIPD JIPMMAPKNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JGCOHINBIPD KJMOBOIFGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, JGCOHINBIPD> OMEMCOEIMCG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool HDAGGNGDAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x51F9FD0", Offset = "0x51F8FD0", VA = "0x1851F9FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public JGCOHINBIPD CGFBGMKFCEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x58CED0", Offset = "0x58BED0", VA = "0x18058CED0")]
		get
		{
			return default(JGCOHINBIPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public JGCOHINBIPD BPCMOBBDFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5B0710", Offset = "0x5AF710", VA = "0x1805B0710")]
		get
		{
			return default(JGCOHINBIPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x51F9F60", Offset = "0x51F8F60", VA = "0x1851F9F60")]
	public bool GLIJNCAGDLH(object DLNBPAAGBNI, JGCOHINBIPD BMNJAHFFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x51FA020", Offset = "0x51F9020", VA = "0x1851FA020")]
	public bool HNEMFBJMDHE(object DLNBPAAGBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x51F9DF0", Offset = "0x51F8DF0", VA = "0x1851F9DF0")]
	private bool CKEFHGFALNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x51FA080", Offset = "0x51F9080", VA = "0x1851FA080")]
	public EIADKJCAFPF()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FIEGLPKEOLP
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] KGMNFGCKGCC;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int PACKDELFILO;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int EAEPHMJCION;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger BEBMPCAFPLJ;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public FIEGLPKEOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x51FA100", Offset = "0x51F9100", VA = "0x1851FA100")]
	private static string EHOHANMBAEF(byte[] PEAHMNEGGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x51FA200", Offset = "0x51F9200", VA = "0x1851FA200")]
	public static string GFDPFHBIGNB(byte[] KCNDJOGONOI, bool LFHPFEDNDMG)
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

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
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
