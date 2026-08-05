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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, MIEHNNCPNFL, PJNLDGODMKB
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct KMPODFDBNBM : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NativeArray<BoundingSphere> BFLLAIFBMAJ;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6C0B520", Offset = "0x6C0A120", VA = "0x186C0B520", Slot = "4")]
			public void Execute(int MFJLAMOCOBC, TransformAccess OHCKGBMFMEE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct KAHEJOFBHOO : IEquatable<KAHEJOFBHOO>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public ushort LIMALEOHDCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Type OCJDNGNAMNL;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6C0B430", Offset = "0x6C0A030", VA = "0x186C0B430", Slot = "4")]
			public bool Equals(KAHEJOFBHOO FDOEIPBMJJM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6C0B340", Offset = "0x6C09F40", VA = "0x186C0B340", Slot = "0")]
			public override bool Equals(object PLAMADMDGIO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6C0B4B0", Offset = "0x6C0A0B0", VA = "0x186C0B4B0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class DOJNKAAAJOH<T> : MIBPJAFAGPJ, FLNDNAOJKIM<T>, CPHKHNFBFLI where T : class, OKBBFGNKAGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5B13580", Offset = "0x5B12180", VA = "0x185B13580")]
			internal DOJNKAAAJOH(int PCLHFBBCJIM, float[] KJELHGJCHNE, DNOHOADDABC KNGALCHGMHL = DNOHOADDABC.PlayerHead, bool PBACBMGKBGE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5B13530", Offset = "0x5B12130", VA = "0x185B13530", Slot = "12")]
			public void CMCAIIEBGOH(T PLAMADMDGIO, float JLDCCBFCJGC, MJNMIJLCBLF CPFFMBLAMJP = MJNMIJLCBLF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5B13500", Offset = "0x5B12100", VA = "0x185B13500", Slot = "13")]
			public void CMCAIIEBGOH(T PLAMADMDGIO, Transform HLFDPCBPDLC, float JLDCCBFCJGC, MJNMIJLCBLF CPFFMBLAMJP = MJNMIJLCBLF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5B134E0", Offset = "0x5B120E0", VA = "0x185B134E0", Slot = "14")]
			public void CEFMELNJEMA(T NKOABHPBGDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5B13560", Offset = "0x5B12160", VA = "0x185B13560", Slot = "15")]
			public bool EKMNCJFLCCB(T PLAMADMDGIO)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class MIBPJAFAGPJ : IDisposable, CPHKHNFBFLI
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct ODKDIKAJHOI
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum NHAJPJPEJHC : byte
				{
					[Cpp2IlInjected.Token(Token = "0x4000032")]
					Add,
					[Cpp2IlInjected.Token(Token = "0x4000033")]
					UpdateRadius,
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					UpdatePosition,
					[Cpp2IlInjected.Token(Token = "0x4000035")]
					UpdateTrackRate,
					[Cpp2IlInjected.Token(Token = "0x4000036")]
					Remove
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public OKBBFGNKAGE NDBMEFNOAMP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public Transform DJCNFDBJOLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public float CGGKMNAGOAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public MJNMIJLCBLF GDENFFDFFCB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public NHAJPJPEJHC LBAEOCJIFPD;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum DNOHOADDABC : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class EKPGDPHFONH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public OKBBFGNKAGE NDBMEFNOAMP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public MJNMIJLCBLF PMNPMFEICDB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public Action OBHNNFLONPD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				public bool POOALANLAKC;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
				public EKPGDPHFONH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class JDDIAGGLPKC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public MIBPJAFAGPJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003F")]
				public EKPGDPHFONH trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
				public JDDIAGGLPKC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x6C0B2C0", Offset = "0x6C09EC0", VA = "0x186C0B2C0")]
				internal void BLEPJAGNIMP()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly int GLJHBGHNEOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool PBACBMGKBGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private bool IMLFLKFFANH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly CullingGroup BEFJOFIPGFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private BoundingSphere[] HCHAABOMOPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly FNEKAOGDHEK CPKOIOKIGEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly DNOHOADDABC KNGALCHGMHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<OKBBFGNKAGE, int> BOJFBFBBJJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly Dictionary<int, EKPGDPHFONH> CLBDLEIDDKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TransformAccessArray PJPEKAJMEGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private NativeList<BoundingSphere> LBNMONBJCNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<ODKDIKAJHOI> OLBMMBKIODM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private bool NGAEEHHALFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private JobHandle PJNBMNEECAJ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int EKHJMHLBMPF
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x8871A0", Offset = "0x885DA0", VA = "0x1808871A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x88FB90", Offset = "0x88E790", VA = "0x18088FB90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int OJDBGHCJEHI
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x917870", Offset = "0x916470", VA = "0x180917870", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x916BE0", Offset = "0x9157E0", VA = "0x180916BE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6C0DCC0", Offset = "0x6C0C8C0", VA = "0x186C0DCC0")]
			internal MIBPJAFAGPJ(int PCLHFBBCJIM, float[] KJELHGJCHNE, DNOHOADDABC KNGALCHGMHL = DNOHOADDABC.PlayerHead, bool PBACBMGKBGE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6C0B5A0", Offset = "0x6C0A1A0", VA = "0x186C0B5A0")]
			public void AHEEBFNHAIE(bool BNFJEOJPMAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6C0BD30", Offset = "0x6C0A930", VA = "0x186C0BD30", Slot = "5")]
			public void CMCAIIEBGOH(OKBBFGNKAGE PLAMADMDGIO, float JLDCCBFCJGC, MJNMIJLCBLF CPFFMBLAMJP = MJNMIJLCBLF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6C0BC90", Offset = "0x6C0A890", VA = "0x186C0BC90", Slot = "10")]
			public void CMCAIIEBGOH(OKBBFGNKAGE PLAMADMDGIO, Transform HLFDPCBPDLC, float JLDCCBFCJGC, MJNMIJLCBLF CPFFMBLAMJP = MJNMIJLCBLF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6C0D210", Offset = "0x6C0BE10", VA = "0x186C0D210")]
			private void LNKFAEFMHNG(OKBBFGNKAGE PLAMADMDGIO, Transform HLFDPCBPDLC, float JLDCCBFCJGC, MJNMIJLCBLF CPFFMBLAMJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6C0BC30", Offset = "0x6C0A830", VA = "0x186C0BC30", Slot = "6")]
			public void CEFMELNJEMA(OKBBFGNKAGE NKOABHPBGDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6C0C160", Offset = "0x6C0AD60", VA = "0x186C0C160")]
			private void EEBCNDKMOGA(OKBBFGNKAGE NKOABHPBGDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6C0D610", Offset = "0x6C0C210", VA = "0x186C0D610")]
			private void NCFHKGKIHKC(OKBBFGNKAGE PLAMADMDGIO, [Optional] float? JLDCCBFCJGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6C0C5C0", Offset = "0x6C0B1C0", VA = "0x186C0C5C0", Slot = "11")]
			public bool EKMNCJFLCCB(OKBBFGNKAGE PLAMADMDGIO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6C0D850", Offset = "0x6C0C450", VA = "0x186C0D850", Slot = "7")]
			public void NOLGFGBJKLO(OKBBFGNKAGE PLAMADMDGIO, MJNMIJLCBLF LLGJLNFKJGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6C0CF10", Offset = "0x6C0BB10", VA = "0x186C0CF10")]
			private void LBGFOHHADMF(OKBBFGNKAGE PLAMADMDGIO, MJNMIJLCBLF LLGJLNFKJGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6C0C910", Offset = "0x6C0B510", VA = "0x186C0C910")]
			public void GBCGDNKBEIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6C0CCF0", Offset = "0x6C0B8F0", VA = "0x186C0CCF0")]
			public void JBMBEKOAGLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6C0B900", Offset = "0x6C0A500", VA = "0x186C0B900")]
			private void BEAHLAJNOCK(ODKDIKAJHOI NPAFKDGAFPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6C0CBA0", Offset = "0x6C0B7A0", VA = "0x186C0CBA0")]
			private void IHLDNPOBLNN(int BKLEJPHGIKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6C0BE30", Offset = "0x6C0AA30", VA = "0x186C0BE30", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6C0D920", Offset = "0x6C0C520", VA = "0x186C0D920")]
			private void OJAPHGEDCEO(EKPGDPHFONH BNEDKKNCFHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6C0C680", Offset = "0x6C0B280", VA = "0x186C0C680")]
			private static void FAKLEHFNHED(EKPGDPHFONH BNEDKKNCFHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6C0CB30", Offset = "0x6C0B730", VA = "0x186C0CB30")]
			private void HOCGIDGIJIN(EKPGDPHFONH BNEDKKNCFHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6C0D1B0", Offset = "0x6C0BDB0", VA = "0x186C0D1B0")]
			private static void LNHFICEJINI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6C0D150", Offset = "0x6C0BD50", VA = "0x186C0D150")]
			private static void LMAIOMNGGGF(float EOJDMAMGKKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6C0C5B0", Offset = "0x6C0B1B0", VA = "0x186C0C5B0")]
			private void EEDGAMIMFAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6C0CF00", Offset = "0x6C0BB00", VA = "0x186C0CF00")]
			private void KGHNCOEMKMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6C0B5D0", Offset = "0x6C0A1D0", VA = "0x186C0B5D0")]
			private void BANGACGIHOL(CullingGroupEvent ODFLAANOIAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6C0CFE0", Offset = "0x6C0BBE0", VA = "0x186C0CFE0")]
			private void LLAPDJPPOOH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float GFIALKJNNJO = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float FLPJCOJOJCJ = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float MLINNPOLLPC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float JLFCADDDLNB = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float PCENIHKOLBO = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float FKJACIFELEL = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float PCEHPONMDLK = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<KAHEJOFBHOO, MIBPJAFAGPJ> MPMKKBGMNCC;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable JCCHPBGOLGP;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable AFKALDFEECH;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static DBHLBOFDKDO ILOOJIFAJDJ;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static DBHLBOFDKDO NDCDDDDOCKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DBHLBOFDKDO AHFMGMMDBEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DBHLBOFDKDO MDEOLICCCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly DBHLBOFDKDO NEJCEFMDENG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static bool UseJobs;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker FAOPDOEMCMM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static ProfilerMarker AGEJJGDIMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private EIIBBDFHPAD IMJHAKFJNFD;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static bool BNFJEOJPMAK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LEOLOCPNFLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x88C770", Offset = "0x88B370", VA = "0x18088C770", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x88C5E0", Offset = "0x88B1E0", VA = "0x18088C5E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public DBHLBOFDKDO ELAPCNKMMHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DBHLBOFDKDO EIEBLMHODJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public DBHLBOFDKDO OEEEFAONOCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DDPOPPDPKPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8B57E0", Offset = "0x8B43E0", VA = "0x1808B57E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IAKHKCLLBNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x908600", Offset = "0x907200", VA = "0x180908600", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x908610", Offset = "0x907210", VA = "0x180908610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A0B0", Offset = "0x6C08CB0", VA = "0x186C0A0B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0AB30", Offset = "0x6C09730", VA = "0x186C0AB30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1574DD0", Offset = "0x15739D0", VA = "0x181574DD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBACE60", Offset = "0xBABA60", VA = "0x180BACE60")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A4B0", Offset = "0x6C090B0", VA = "0x186C0A4B0")]
		private void HHPPNDEGHOF(Scene DCLJEHJGEFC, LoadSceneMode DCNHCLKJAMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C0AA50", Offset = "0x6C09650", VA = "0x186C0AA50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C0AD70", Offset = "0x6C09970", VA = "0x186C0AD70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A6A0", Offset = "0x6C092A0", VA = "0x186C0A6A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A8F0", Offset = "0x6C094F0", VA = "0x186C0A8F0")]
		private void OEBMBAACBIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C0AB50", Offset = "0x6C09750", VA = "0x186C0AB50")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6C09F40", Offset = "0x6C08B40", VA = "0x186C09F40")]
		private void AKCFIFHBFHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A2D0", Offset = "0x6C08ED0", VA = "0x186C0A2D0")]
		public CPHKHNFBFLI GetOrCreateCullingGroup(Type KKBMIMHPBJC, int BJDLALEGLOD, ushort GCIBGHOOEBM = 0, bool PBACBMGKBGE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2C35490", Offset = "0x2C34090", VA = "0x182C35490")]
		public FLNDNAOJKIM<T> GetOrCreateCullingGroup<T>(int BJDLALEGLOD, ushort GCIBGHOOEBM = 0, bool PBACBMGKBGE = false) where T : class, OKBBFGNKAGE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A510", Offset = "0x6C09110", VA = "0x186C0A510")]
		private CPHKHNFBFLI LGBHAECEEPB(Type KKBMIMHPBJC, int BJDLALEGLOD, float[] KJELHGJCHNE, ushort GCIBGHOOEBM = 0, bool PBACBMGKBGE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2C35550", Offset = "0x2C34150", VA = "0x182C35550")]
		private FLNDNAOJKIM<T> LGBHAECEEPB<T>(int BJDLALEGLOD, float[] KJELHGJCHNE, ushort GCIBGHOOEBM = 0, bool PBACBMGKBGE = false) where T : class, OKBBFGNKAGE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A170", Offset = "0x6C08D70", VA = "0x186C0A170")]
		public static PFKPGFLKLMF FindClosestDefaultUpdateLod(float JJCKOMPMFAA)
		{
			return default(PFKPGFLKLMF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8B6070", Offset = "0x8B4C70", VA = "0x1808B6070")]
		public static PFKPGFLKLMF MinUpdateLod(PFKPGFLKLMF JKPFIJMNLLA, PFKPGFLKLMF GFLELOKIIJG)
		{
			return default(PFKPGFLKLMF);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A8E0", Offset = "0x6C094E0", VA = "0x186C0A8E0")]
		public static PFKPGFLKLMF MaxUpdateLod(PFKPGFLKLMF JKPFIJMNLLA, PFKPGFLKLMF GFLELOKIIJG)
		{
			return default(PFKPGFLKLMF);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C0B170", Offset = "0x6C09D70", VA = "0x186C0B170")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8B57E0", Offset = "0x8B43E0", VA = "0x1808B57E0", Slot = "11")]
		private bool OHGACKONIMH()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FNEKAOGDHEK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool NJEIHHMDDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera HMEEHKBADAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DBHLBOFDKDO CPOCDIPBOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool GNHIKFEHDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	DBHLBOFDKDO NLMJLFHEJNN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform LJEJDLOKPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CPHKHNFBFLI
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMCAIIEBGOH(OKBBFGNKAGE PLAMADMDGIO, float JLDCCBFCJGC, MJNMIJLCBLF CPFFMBLAMJP = MJNMIJLCBLF.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEFMELNJEMA(OKBBFGNKAGE NKOABHPBGDC);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NOLGFGBJKLO(OKBBFGNKAGE PLAMADMDGIO, MJNMIJLCBLF ENNFIOMNHFA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FLNDNAOJKIM<T> : CPHKHNFBFLI where T : class, OKBBFGNKAGE
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMCAIIEBGOH(T PLAMADMDGIO, float JLDCCBFCJGC, MJNMIJLCBLF CPFFMBLAMJP = MJNMIJLCBLF.Off);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMCAIIEBGOH(T PLAMADMDGIO, Transform HLFDPCBPDLC, float JLDCCBFCJGC, MJNMIJLCBLF CPFFMBLAMJP = MJNMIJLCBLF.Off);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CEFMELNJEMA(T NKOABHPBGDC);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EKMNCJFLCCB(T PLAMADMDGIO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OKBBFGNKAGE
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform OHCKGBMFMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(PFKPGFLKLMF KHDFLEEHMMA, PFKPGFLKLMF KMLDFOBGIAA);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool GJPNLIHNAHA);
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
