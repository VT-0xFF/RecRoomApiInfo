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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, PDMOEEOGDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class MDEMMHGADME : IDisposable, NJCKEDDDPCG
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int IIFOMKJFCCM
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int DGJFMMDODCK
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
			public abstract void AGFIOMFIONA(bool COHGOHILHIK);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
			protected MDEMMHGADME()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class CCGNGEMHHND<T> : MDEMMHGADME, global::OKCLIFMKEAK<T>, NJCKEDDDPCG where T : HEDNHOOLNMM
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum IFEPHJKIOPN : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class EMMHHPBKFPC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T PDAPAELLFIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public KAKDDLABPMI DLLIHADOCFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action FCICOHDAGIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool ICEGHBDOBOB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int LCGDBDLDOIM;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
				public EMMHHPBKFPC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class HKGKJFNBLCP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public CCGNGEMHHND<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public EMMHHPBKFPC trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
				public HKGKJFNBLCP()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int FJFJIELKDKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int LNHEJOANKML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int FPNIFIMMJLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool ECJKNINNBDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup LHFNNLHFCLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] AFBCKACPAJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] FJLFEPABHDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly PLKIHOFDHID DNNIKIGPJAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> DEAPJBHNDLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, EMMHHPBKFPC> CGLJAAGLHHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly IFEPHJKIOPN KMCDAHBGNJH;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int IIFOMKJFCCM
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x55CED0", Offset = "0x55BAD0", VA = "0x18055CED0", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int DGJFMMDODCK
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x580710", Offset = "0x57F310", VA = "0x180580710", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1D01160", Offset = "0x1CFFD60", VA = "0x181D01160")]
			internal CCGNGEMHHND(int LNHEJOANKML, float[] EGLHGOKBKLH, IFEPHJKIOPN KMCDAHBGNJH = IFEPHJKIOPN.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1CFF3B0", Offset = "0x1CFDFB0", VA = "0x181CFF3B0", Slot = "10")]
			public override void AGFIOMFIONA(bool COHGOHILHIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1CFF3E0", Offset = "0x1CFDFE0", VA = "0x181CFF3E0", Slot = "11")]
			public KPBICPLKLNK CCFJHOEKGEA(float IOKKGPIILIL)
			{
				return default(KPBICPLKLNK);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1CFF9C0", Offset = "0x1CFE5C0", VA = "0x181CFF9C0", Slot = "12")]
			public void DNJODILJGAL(T NJBMHJCLPCJ, float IBEPHPLMAKH, KAKDDLABPMI JCOOGPIOKIC = KAKDDLABPMI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1CFF540", Offset = "0x1CFE140", VA = "0x181CFF540", Slot = "13")]
			public void DNJODILJGAL(T NJBMHJCLPCJ, Transform BBOJIGHOKNC, float IBEPHPLMAKH, KAKDDLABPMI JCOOGPIOKIC = KAKDDLABPMI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1D00180", Offset = "0x1CFED80", VA = "0x181D00180", Slot = "14")]
			public void FPKGLLHKHIP(T NJBMHJCLPCJ, [Optional] float? IBEPHPLMAKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1D00240", Offset = "0x1CFEE40", VA = "0x181D00240")]
			private void GJHNJFHOBFB(int PMMFOLCEJEJ, [Optional] float? IBEPHPLMAKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1D006D0", Offset = "0x1CFF2D0", VA = "0x181D006D0", Slot = "15")]
			public void JGCOEHFAOLL(T ECGMPCHFGLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1D00060", Offset = "0x1CFEC60", VA = "0x181D00060", Slot = "16")]
			public KPBICPLKLNK FFJGGHBGFIL(T NJBMHJCLPCJ)
			{
				return default(KPBICPLKLNK);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1CFF440", Offset = "0x1CFE040", VA = "0x181CFF440", Slot = "17")]
			public bool DDHPECIAFPC(T NJBMHJCLPCJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1D01050", Offset = "0x1CFFC50", VA = "0x181D01050", Slot = "18")]
			public void POBOCCLCMBE(T NJBMHJCLPCJ, KAKDDLABPMI OMJMMNJGDIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1CFFA60", Offset = "0x1CFE660", VA = "0x181CFFA60", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1D00CA0", Offset = "0x1CFF8A0", VA = "0x181D00CA0")]
			private void ONNMEJJCANO(EMMHHPBKFPC EODPPCNMPBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1CFFDE0", Offset = "0x1CFE9E0", VA = "0x181CFFDE0")]
			private void FCPFLJMBLLL(EMMHHPBKFPC EODPPCNMPBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1D00660", Offset = "0x1CFF260", VA = "0x181D00660")]
			private void HFNIENPAJME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1D00C30", Offset = "0x1CFF830", VA = "0x181D00C30")]
			private void OEIPMDAOMKI(float EPGPPMJAFDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1D00200", Offset = "0x1CFEE00", VA = "0x181D00200")]
			private void FPOKCOBKCFG(EMMHHPBKFPC EODPPCNMPBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1D00A70", Offset = "0x1CFF670", VA = "0x181D00A70")]
			private void KDDNJIBENIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1D00C00", Offset = "0x1CFF800", VA = "0x181D00C00")]
			private void NHCPJHADFJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1D003B0", Offset = "0x1CFEFB0", VA = "0x181D003B0")]
			private void GKEAKGKFFGO(CullingGroupEvent HODLCNNOCMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1D00A90", Offset = "0x1CFF690", VA = "0x181D00A90")]
			private void MHHLBFFCANB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct JCJOFBFINNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort FFNKHAGCEJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type IHIAEAKGNAC;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float HBJKLBAHKLL = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float KHLFHJPDMML = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float KHPMNDCHLOG = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float AJADBNPCPIG = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float GJFOOIPOCFK = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float JFFLPHDPMLF = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float BHNADFDDFOE = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<JCJOFBFINNG, MDEMMHGADME> MHFMPGBLNIC;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable FDKKDDMAHKI;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable AGDJAGAJFOO;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static APEBICLOKNP EFFOEKIGOEI;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static APEBICLOKNP DGIOJDMCAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly APEBICLOKNP PLOAFGAKPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly APEBICLOKNP DOMDIEKAOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly APEBICLOKNP JBBGACNIEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private HGNPLDPHFIE COEDMCBOGLO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool COHGOHILHIK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public APEBICLOKNP MHCLHOGJOCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public APEBICLOKNP BJEKOGPEEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x55EDF0", Offset = "0x55D9F0", VA = "0x18055EDF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public APEBICLOKNP BNNGMMLNJEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5850C0", Offset = "0x583CC0", VA = "0x1805850C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DEBNALHGLPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1524830", Offset = "0x1523430", VA = "0x181524830", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JIPMNIMHDGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x72F740", Offset = "0x72E340", VA = "0x18072F740", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x72F7C0", Offset = "0x72E3C0", VA = "0x18072F7C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4E279D0", Offset = "0x4E265D0", VA = "0x184E279D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD638B0", Offset = "0xD624B0", VA = "0x180D638B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4E27F90", Offset = "0x4E26B90", VA = "0x184E27F90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4E27A70", Offset = "0x4E26670", VA = "0x184E27A70")]
		private void EDFBOGNCDOA(Scene LPMGEDNJNNH, LoadSceneMode ODDGPNAKPIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4E27EE0", Offset = "0x4E26AE0", VA = "0x184E27EE0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4E27FB0", Offset = "0x4E26BB0", VA = "0x184E27FB0")]
		private void PDFMHGPGMFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4E28150", Offset = "0x4E26D50", VA = "0x184E28150")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4E27CC0", Offset = "0x4E268C0", VA = "0x184E27CC0")]
		private void JMCEKCPDIOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3670", Offset = "0x1DD2270", VA = "0x181DD3670")]
		public global::OKCLIFMKEAK<T> GetOrCreateCullingGroup<T>(int OLIFKBALMDK, ushort ABHAHGJEHPD = 0) where T : HEDNHOOLNMM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3720", Offset = "0x1DD2320", VA = "0x181DD3720")]
		private global::OKCLIFMKEAK<T> HLDJCAFFEOB<T>(int OLIFKBALMDK, float[] EGLHGOKBKLH, ushort ABHAHGJEHPD = 0) where T : HEDNHOOLNMM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4E27AD0", Offset = "0x4E266D0", VA = "0x184E27AD0")]
		public static KPBICPLKLNK FindClosestDefaultUpdateLod(float KMKAMFGHCMH)
		{
			return default(KPBICPLKLNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4E27E80", Offset = "0x4E26A80", VA = "0x184E27E80")]
		public static KPBICPLKLNK MinUpdateLod(KPBICPLKLNK LFLMMGDIOBH, KPBICPLKLNK NOOGMPAGFBH)
		{
			return default(KPBICPLKLNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4E27E20", Offset = "0x4E26A20", VA = "0x184E27E20")]
		public static KPBICPLKLNK MaxUpdateLod(KPBICPLKLNK LFLMMGDIOBH, KPBICPLKLNK NOOGMPAGFBH)
		{
			return default(KPBICPLKLNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4E284E0", Offset = "0x4E270E0", VA = "0x184E284E0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PLKIHOFDHID
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool PNAODICPKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera FINAJFEAPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	APEBICLOKNP CLIDAKNBFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool DGFPFKOCKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	APEBICLOKNP MBDHGEINMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform NCHMHNEHMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NJCKEDDDPCG
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int IIFOMKJFCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int DGJFMMDODCK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OKCLIFMKEAK<T> : NJCKEDDDPCG where T : HEDNHOOLNMM
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KPBICPLKLNK CCFJHOEKGEA(float IOKKGPIILIL);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNJODILJGAL(T NJBMHJCLPCJ, float IBEPHPLMAKH, KAKDDLABPMI JCOOGPIOKIC = KAKDDLABPMI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNJODILJGAL(T NJBMHJCLPCJ, Transform BBOJIGHOKNC, float IBEPHPLMAKH, KAKDDLABPMI JCOOGPIOKIC = KAKDDLABPMI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FPKGLLHKHIP(T NJBMHJCLPCJ, [Optional] float? IBEPHPLMAKH);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGCOEHFAOLL(T ECGMPCHFGLG);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KPBICPLKLNK FFJGGHBGFIL(T NJBMHJCLPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DDHPECIAFPC(T NJBMHJCLPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void POBOCCLCMBE(T NJBMHJCLPCJ, KAKDDLABPMI DFGDHBABMOG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HEDNHOOLNMM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform KOCHBOFCDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(KPBICPLKLNK NCBHGKEPCOC, KPBICPLKLNK FHHMNCDGJBD);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool AEEGCCFGJID);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum KAKDDLABPMI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum KPBICPLKLNK
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
public class JBIHMIABCLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private KPBICPLKLNK OCAJMDJLGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private KPBICPLKLNK DOMFGMBOICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, KPBICPLKLNK> HIIMCHAKKHG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool DKAKJEGLOFM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4E28E00", Offset = "0x4E27A00", VA = "0x184E28E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public KPBICPLKLNK BHPBDCCMGKN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x55CED0", Offset = "0x55BAD0", VA = "0x18055CED0")]
		get
		{
			return default(KPBICPLKLNK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public KPBICPLKLNK DEEKPONNIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x580710", Offset = "0x57F310", VA = "0x180580710")]
		get
		{
			return default(KPBICPLKLNK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4E28BC0", Offset = "0x4E277C0", VA = "0x184E28BC0")]
	public bool CEHHKEGBOJF(object FOKGBGEFHHH, KPBICPLKLNK ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4E28C30", Offset = "0x4E27830", VA = "0x184E28C30")]
	public bool CIIPMLIODHF(object FOKGBGEFHHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4E28C90", Offset = "0x4E27890", VA = "0x184E28C90")]
	private bool JDCNMGBFCOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4E28E50", Offset = "0x4E27A50", VA = "0x184E28E50")]
	public JBIHMIABCLL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HNGLDPHHCGI
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] HNCEJLIIPMJ;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int GPLDKCDHCAH;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int JHGLEHDFIPO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger ALPCFLGFGJH;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public HNGLDPHHCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4E285D0", Offset = "0x4E271D0", VA = "0x184E285D0")]
	private static string CHLEKPLKKKF(byte[] GONCOEMNHPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4E286D0", Offset = "0x4E272D0", VA = "0x184E286D0")]
	public static string KBPCOEPOAHA(byte[] EDEEEGMMOHA, bool EDDELBNCJAF)
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
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
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
