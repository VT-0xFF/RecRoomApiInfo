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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, JBOJNOKAFDL, FHBMACKKPGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct HODJEKOAPGM : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> APDBNIMCPID;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7BF2EA0", Offset = "0x7BF14A0", VA = "0x187BF2EA0", Slot = "4")]
			public void Execute(int OHHMJGCBCKD, TransformAccess KOOMPFGMBLG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct NCCPJKEIMBD : IEquatable<NCCPJKEIMBD>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort IDDCJNANAKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type NDDOCDEMDLC;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7BF3010", Offset = "0x7BF1610", VA = "0x187BF3010", Slot = "4")]
			public bool Equals(NCCPJKEIMBD MIJLJBIHDMP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7BF2F20", Offset = "0x7BF1520", VA = "0x187BF2F20", Slot = "0")]
			public override bool Equals(object BOMDCGFKGKF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7BF3090", Offset = "0x7BF1690", VA = "0x187BF3090", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class CFBJFDPOKGI<T> : DNFINLNAIPO, ANMHCGIJIIH<T>, JGMGMHCDANN where T : class, CLLFLKHFPNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x67A98A0", Offset = "0x67A7EA0", VA = "0x1867A98A0")]
			internal CFBJFDPOKGI(int HIIJEBHJLAJ, float[] COAHPNFJHIF, DHFHAECOLII DGPHOGPLMIF = DHFHAECOLII.PlayerHead, bool EPPKCOCHJKO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x67A9870", Offset = "0x67A7E70", VA = "0x1867A9870", Slot = "12")]
			public void IIGLPCDPOEE(T BOMDCGFKGKF, float PIBKBDEFJIN, DINEBAHNNBA BPHEBEGLINB = DINEBAHNNBA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x67A9840", Offset = "0x67A7E40", VA = "0x1867A9840", Slot = "13")]
			public void IIGLPCDPOEE(T BOMDCGFKGKF, Transform ENHKNHIMMNB, float PIBKBDEFJIN, DINEBAHNNBA BPHEBEGLINB = DINEBAHNNBA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x67A9820", Offset = "0x67A7E20", VA = "0x1867A9820", Slot = "14")]
			public void GNAALOCCJEL(T PIPANKJNIHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x67A9800", Offset = "0x67A7E00", VA = "0x1867A9800", Slot = "15")]
			public bool GMDKMLECDLJ(T BOMDCGFKGKF)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class DNFINLNAIPO : IDisposable, JGMGMHCDANN
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct LECPHNDALJE
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum FLBGDOIBFLM : byte
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
				public CLLFLKHFPNF LAAONLPPGKG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform IOFGLPCMIME;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float KFCBCCPHPOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public DINEBAHNNBA EGHKNPEPGEC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public FLBGDOIBFLM KFIKOGBAHMD;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum DHFHAECOLII : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class JKMDPCDIDCI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public CLLFLKHFPNF LAAONLPPGKG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public DINEBAHNNBA KAMINLGLILM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action MENLKMKGDLH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool CMGDFBGNCFH;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
				public JKMDPCDIDCI()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int HNDEALABJHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool EPPKCOCHJKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool CIAFEFCBLPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup NOGAFAGCPOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] PBNGCJLEEFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly CEKDBFKEOBO DHJEDIPMPLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly DHFHAECOLII DGPHOGPLMIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<CLLFLKHFPNF, int> KEOOCMLFDIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, JKMDPCDIDCI> NKGABDJCABD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray CAIJHKDIADL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> BDEPAHLEEDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<LECPHNDALJE> BEIAJKEJEDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool BOJIKMFAOPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle GMNPCPDAADC;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int PDFLLNMBAOC
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int EEPIMNBGGMH
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xB76480", Offset = "0xB74A80", VA = "0x180B76480", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xC5E800", Offset = "0xC5CE00", VA = "0x180C5E800")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7BF29C0", Offset = "0x7BF0FC0", VA = "0x187BF29C0")]
			internal DNFINLNAIPO(int HIIJEBHJLAJ, float[] COAHPNFJHIF, DHFHAECOLII DGPHOGPLMIF = DHFHAECOLII.PlayerHead, bool EPPKCOCHJKO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7BF23B0", Offset = "0x7BF09B0", VA = "0x187BF23B0")]
			public void LKLDGBEBNID(bool OCMLCOPEGCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1B70", Offset = "0x7BF0170", VA = "0x187BF1B70", Slot = "5")]
			public void IIGLPCDPOEE(CLLFLKHFPNF BOMDCGFKGKF, float PIBKBDEFJIN, DINEBAHNNBA BPHEBEGLINB = DINEBAHNNBA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1AD0", Offset = "0x7BF00D0", VA = "0x187BF1AD0", Slot = "10")]
			public void IIGLPCDPOEE(CLLFLKHFPNF BOMDCGFKGKF, Transform ENHKNHIMMNB, float PIBKBDEFJIN, DINEBAHNNBA BPHEBEGLINB = DINEBAHNNBA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1460", Offset = "0x7BEFA60", VA = "0x187BF1460")]
			private void GIOCBPMDNLN(CLLFLKHFPNF BOMDCGFKGKF, Transform ENHKNHIMMNB, float PIBKBDEFJIN, DINEBAHNNBA BPHEBEGLINB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1A60", Offset = "0x7BF0060", VA = "0x187BF1A60", Slot = "6")]
			public void GNAALOCCJEL(CLLFLKHFPNF PIPANKJNIHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1C70", Offset = "0x7BF0270", VA = "0x187BF1C70")]
			private void KJDMCGJPJLI(CLLFLKHFPNF PIPANKJNIHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7BF2760", Offset = "0x7BF0D60", VA = "0x187BF2760")]
			private void OILNEAPAMDO(CLLFLKHFPNF BOMDCGFKGKF, [Optional] float? PIBKBDEFJIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7BF19A0", Offset = "0x7BEFFA0", VA = "0x187BF19A0", Slot = "11")]
			public bool GMDKMLECDLJ(CLLFLKHFPNF BOMDCGFKGKF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
			public void PMCKAGPCICM(CLLFLKHFPNF BOMDCGFKGKF, DINEBAHNNBA NKHGIOGJDGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7BF0D80", Offset = "0x7BEF380", VA = "0x187BF0D80")]
			private void CHJJFIBOLCL(CLLFLKHFPNF BOMDCGFKGKF, DINEBAHNNBA NKHGIOGJDGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1070", Offset = "0x7BEF670", VA = "0x187BF1070")]
			public void FHEFCGOLMJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7BF23E0", Offset = "0x7BF09E0", VA = "0x187BF23E0")]
			public void MBHEDCDEOBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7BF20B0", Offset = "0x7BF06B0", VA = "0x187BF20B0")]
			private void LHFILELCLEJ(LECPHNDALJE JKIBOICMIDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1850", Offset = "0x7BEFE50", VA = "0x187BF1850")]
			private void GKAHKJMEDDN(int DPJEJNADMDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7BF0E30", Offset = "0x7BEF430", VA = "0x187BF0E30", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1060", Offset = "0x7BEF660", VA = "0x187BF1060")]
			private void EFMDJKAHEII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1AC0", Offset = "0x7BF00C0", VA = "0x187BF1AC0")]
			private void HLBPOBBEOII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1130", Offset = "0x7BEF730", VA = "0x187BF1130")]
			private void GENAILOGBKM(CullingGroupEvent EKCLMPMOPHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7BF25F0", Offset = "0x7BF0BF0", VA = "0x187BF25F0")]
			private void OIAFNIOCDKA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float NGBEBAAFBOB = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float FHFEHBLFNIK = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float CMFJKNDELOC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float CJADFIDOOHF = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float FFKGOEAHEAG = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float IJBHDHNLLIA = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float AIHCCKNCIDI = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<NCCPJKEIMBD, DNFINLNAIPO> NAPCCLBBDNF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable AMIHNCAACGH;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable EPBLECAMNPE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static GCADBNOOJOM HGKHLLKHOMH;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static GCADBNOOJOM JNHHMBGJIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly GCADBNOOJOM FLPKLNJHBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly GCADBNOOJOM FKGLGNJMIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly GCADBNOOJOM PAIKGMLPOCO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker FLEIMNCPFDJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker CBHKEGAJJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OLILOOIADED AEHOJDDFKEK;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool OCMLCOPEGCM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OECNNBLFMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9EB530", Offset = "0x9E9B30", VA = "0x1809EB530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GCADBNOOJOM EAOELLLOEID
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public GCADBNOOJOM CJJJKLANLHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GCADBNOOJOM ODMFHIAAJFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool KBKGBFICNFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA17AF0", Offset = "0xA160F0", VA = "0x180A17AF0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool LMMPJBEEFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xC17800", Offset = "0xC15E00", VA = "0x180C17800", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCF1F40", Offset = "0xCF0540", VA = "0x180CF1F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BEF930", Offset = "0x7BEDF30", VA = "0x187BEF930", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x79D6A70", Offset = "0x79D5070", VA = "0x1879D6A70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E5E190", Offset = "0x1E5C790", VA = "0x181E5E190")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC06980", Offset = "0xC04F80", VA = "0x180C06980")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BEF8D0", Offset = "0x7BEDED0", VA = "0x187BEF8D0")]
		private void AMHPKDPFOHL(Scene CHJMGPBPDEK, LoadSceneMode MECLDBHCDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF03E0", Offset = "0x7BEE9E0", VA = "0x187BF03E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0750", Offset = "0x7BEED50", VA = "0x187BF0750")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0030", Offset = "0x7BEE630", VA = "0x187BF0030")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0280", Offset = "0x7BEE880", VA = "0x187BF0280")]
		private void OBCLCLFMLNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BF04C0", Offset = "0x7BEEAC0", VA = "0x187BF04C0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BEFEC0", Offset = "0x7BEE4C0", VA = "0x187BEFEC0")]
		private void LNLEOBCGNNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7BEFB50", Offset = "0x7BEE150", VA = "0x187BEFB50")]
		public JGMGMHCDANN GetOrCreateCullingGroup(Type INMELAGEDBG, int AMFBLJOEPCJ, ushort KKGDFLKBCBF = 0, bool EPPKCOCHJKO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x36AC5B0", Offset = "0x36AABB0", VA = "0x1836AC5B0")]
		public ANMHCGIJIIH<T> GetOrCreateCullingGroup<T>(int AMFBLJOEPCJ, ushort KKGDFLKBCBF = 0, bool EPPKCOCHJKO = false) where T : class, CLLFLKHFPNF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7BEFD30", Offset = "0x7BEE330", VA = "0x187BEFD30")]
		private JGMGMHCDANN LFMNGMBGDGC(Type INMELAGEDBG, int AMFBLJOEPCJ, float[] COAHPNFJHIF, ushort KKGDFLKBCBF = 0, bool EPPKCOCHJKO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x36AC670", Offset = "0x36AAC70", VA = "0x1836AC670")]
		private ANMHCGIJIIH<T> LFMNGMBGDGC<T>(int AMFBLJOEPCJ, float[] COAHPNFJHIF, ushort KKGDFLKBCBF = 0, bool EPPKCOCHJKO = false) where T : class, CLLFLKHFPNF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BEF9F0", Offset = "0x7BEDFF0", VA = "0x187BEF9F0")]
		public static MEACMOOJHJN FindClosestDefaultUpdateLod(float JEIEFLJICLG)
		{
			return default(MEACMOOJHJN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA18330", Offset = "0xA16930", VA = "0x180A18330")]
		public static MEACMOOJHJN MinUpdateLod(MEACMOOJHJN LJFACCBEAKI, MEACMOOJHJN BJELHGJJEKA)
		{
			return default(MEACMOOJHJN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0270", Offset = "0x7BEE870", VA = "0x187BF0270")]
		public static MEACMOOJHJN MaxUpdateLod(MEACMOOJHJN LJFACCBEAKI, MEACMOOJHJN BJELHGJJEKA)
		{
			return default(MEACMOOJHJN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0C30", Offset = "0x7BEF230", VA = "0x187BF0C30")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA17AF0", Offset = "0xA160F0", VA = "0x180A17AF0", Slot = "11")]
		private bool OAGFDLFCCPO()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CEKDBFKEOBO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool CBBPPPGLLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera ODOHAMONDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GCADBNOOJOM IFAGDDDIPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LNJFOGNFLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	GCADBNOOJOM NKDHLKCAAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform HDGPGEMEDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JGMGMHCDANN
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIGLPCDPOEE(CLLFLKHFPNF BOMDCGFKGKF, float PIBKBDEFJIN, DINEBAHNNBA BPHEBEGLINB = DINEBAHNNBA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNAALOCCJEL(CLLFLKHFPNF PIPANKJNIHI);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMCKAGPCICM(CLLFLKHFPNF BOMDCGFKGKF, DINEBAHNNBA JGHCBPMFOEA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ANMHCGIJIIH<T> : JGMGMHCDANN where T : class, CLLFLKHFPNF
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIGLPCDPOEE(T BOMDCGFKGKF, float PIBKBDEFJIN, DINEBAHNNBA BPHEBEGLINB = DINEBAHNNBA.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIGLPCDPOEE(T BOMDCGFKGKF, Transform ENHKNHIMMNB, float PIBKBDEFJIN, DINEBAHNNBA BPHEBEGLINB = DINEBAHNNBA.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNAALOCCJEL(T PIPANKJNIHI);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GMDKMLECDLJ(T BOMDCGFKGKF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CLLFLKHFPNF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform KOOMPFGMBLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(MEACMOOJHJN MMOFILFNFGF, MEACMOOJHJN NAOJMHGIKIF);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool MLHEEDKLBBC);
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
