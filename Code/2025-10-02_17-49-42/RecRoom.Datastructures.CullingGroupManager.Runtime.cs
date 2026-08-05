using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Datastructures_CullingGroupManager_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84B03F0", Offset = "0x84AEDF0", VA = "0x1884B03F0", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, MPNBHGLOEOL, GBAIPNMDKIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[BurstCompile]
		private struct LEAEOKLMELB : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> BLPDDGCLNPE;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x84B0370", Offset = "0x84AED70", VA = "0x1884B0370", Slot = "4")]
			public void Execute(int KABGMIEBEFC, TransformAccess HALOMIKDIAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private struct KCKOLCALAJM : IEquatable<KCKOLCALAJM>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort GAFJNPLJLCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type DIMPHPMKCCL;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x84B0280", Offset = "0x84AEC80", VA = "0x1884B0280", Slot = "4")]
			public bool Equals(KCKOLCALAJM GOCNHGEHNFD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x84B0190", Offset = "0x84AEB90", VA = "0x1884B0190", Slot = "0")]
			public override bool Equals(object PMNHIPACJLN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x84B0300", Offset = "0x84AED00", VA = "0x1884B0300", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class DJMIOBOGKJO<T> : IEAFIFKJHMJ, JPLAFIDIIOO<T>, APPPHJAKOPF where T : class, MFMLODIOEBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x45FB620", Offset = "0x45FA020", VA = "0x1845FB620")]
			internal DJMIOBOGKJO(int CNHJOCKECCB, float[] LEAIAJCLBJO, COIJIBHIBKF IILFDMDACLA = COIJIBHIBKF.PlayerHead, bool OKAFNPFHOFP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x45FB5A0", Offset = "0x45F9FA0", VA = "0x1845FB5A0", Slot = "12")]
			public void HMDNMGBNKIA(T PMNHIPACJLN, float JBOIDCJHBGG, FMHNBNKGEEA BGAHDBKIBLE = FMHNBNKGEEA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x45FB5D0", Offset = "0x45F9FD0", VA = "0x1845FB5D0", Slot = "13")]
			public void HMDNMGBNKIA(T PMNHIPACJLN, Transform IFMOICEDEHC, float JBOIDCJHBGG, FMHNBNKGEEA BGAHDBKIBLE = FMHNBNKGEEA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x45FB600", Offset = "0x45FA000", VA = "0x1845FB600", Slot = "14")]
			public void MCKODPOBNPM(T JJLACJPCILE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x45FB580", Offset = "0x45F9F80", VA = "0x1845FB580", Slot = "15")]
			public bool DMFPALDEFKL(T PMNHIPACJLN)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class IEAFIFKJHMJ : IDisposable, APPPHJAKOPF
		{
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			private struct KCGEGACMGIH
			{
				[Cpp2IlInjected.Token(Token = "0x2000009")]
				public enum CMALHFIMKLA : byte
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
				public MFMLODIOEBD NACEDJEFALG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform AJEDGAAHNKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float HNJLIBKLAMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public FMHNBNKGEEA NJJIPHJNIEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public CMALHFIMKLA EMHLKEMKMPE;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public enum COIJIBHIBKF : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class NEKLONIJCGP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public MFMLODIOEBD NACEDJEFALG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public FMHNBNKGEEA MMNAHNMJAFM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action LDNALDHCPIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool CLFEIBKMOBN;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
				public NEKLONIJCGP()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int AHBOODEOAJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool OKAFNPFHOFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool ICPNMNBNLKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup CJHFIJOKNOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] DDPLFDPEFNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly MELNGJAAFKF ADCMGLPBECA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly COIJIBHIBKF IILFDMDACLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<MFMLODIOEBD, int> HDOLODBGOMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, NEKLONIJCGP> EIOJEANAECN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray PIEKHLOCEOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> BOFKHIEMGAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<KCGEGACMGIH> IGIOMGAAMPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool DMDLPLGMEDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle EDFFJEFOFGN;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int GKHEOMMMGDA
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int IGDMAIDHOIM
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xBAD7D0", Offset = "0xBAC1D0", VA = "0x180BAD7D0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xBAD7E0", Offset = "0xBAC1E0", VA = "0x180BAD7E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x84AFCB0", Offset = "0x84AE6B0", VA = "0x1884AFCB0")]
			internal IEAFIFKJHMJ(int CNHJOCKECCB, float[] LEAIAJCLBJO, COIJIBHIBKF IILFDMDACLA = COIJIBHIBKF.PlayerHead, bool OKAFNPFHOFP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x84AEE00", Offset = "0x84AD800", VA = "0x1884AEE00")]
			public void FDEHJGCMFBF(bool PNBIMDNKJEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x84AEF80", Offset = "0x84AD980", VA = "0x1884AEF80", Slot = "5")]
			public void HMDNMGBNKIA(MFMLODIOEBD PMNHIPACJLN, float JBOIDCJHBGG, FMHNBNKGEEA BGAHDBKIBLE = FMHNBNKGEEA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x84AF080", Offset = "0x84ADA80", VA = "0x1884AF080", Slot = "10")]
			public void HMDNMGBNKIA(MFMLODIOEBD PMNHIPACJLN, Transform IFMOICEDEHC, float JBOIDCJHBGG, FMHNBNKGEEA BGAHDBKIBLE = FMHNBNKGEEA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x84AE630", Offset = "0x84AD030", VA = "0x1884AE630")]
			private void CDOFJNLPCJN(MFMLODIOEBD PMNHIPACJLN, Transform IFMOICEDEHC, float JBOIDCJHBGG, FMHNBNKGEEA BGAHDBKIBLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x84AF410", Offset = "0x84ADE10", VA = "0x1884AF410", Slot = "6")]
			public void MCKODPOBNPM(MFMLODIOEBD JJLACJPCILE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x84AF130", Offset = "0x84ADB30", VA = "0x1884AF130")]
			private void KNCELBADGKP(MFMLODIOEBD JJLACJPCILE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x84AF8E0", Offset = "0x84AE2E0", VA = "0x1884AF8E0")]
			private void OOIALAIFJOJ(MFMLODIOEBD PMNHIPACJLN, [Optional] float? JBOIDCJHBGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x84AE8D0", Offset = "0x84AD2D0", VA = "0x1884AE8D0", Slot = "11")]
			public bool DMFPALDEFKL(MFMLODIOEBD PMNHIPACJLN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
			public void JMBJFBGHMLB(MFMLODIOEBD PMNHIPACJLN, FMHNBNKGEEA OMMELKKFEHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x84AF470", Offset = "0x84ADE70", VA = "0x1884AF470")]
			private void MMJJKEMHLEL(MFMLODIOEBD PMNHIPACJLN, FMHNBNKGEEA OMMELKKFEHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x84AF810", Offset = "0x84AE210", VA = "0x1884AF810")]
			public void NGGMFAMPFDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x84AE420", Offset = "0x84ACE20", VA = "0x1884AE420")]
			public void ADFGLPCGLAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x84AF520", Offset = "0x84ADF20", VA = "0x1884AF520")]
			private void NCEHKFHKJNK(KCGEGACMGIH DMCCCPMAFCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84AEE30", Offset = "0x84AD830", VA = "0x1884AEE30")]
			private void GCHJMPMBFDE(int EILKOCKAPJJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x84AE990", Offset = "0x84AD390", VA = "0x1884AE990", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x84AF120", Offset = "0x84ADB20", VA = "0x1884AF120")]
			private void IKEKNMKDFBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x84AF8D0", Offset = "0x84AE2D0", VA = "0x1884AF8D0")]
			private void OKNOKBHBBMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x84AEBC0", Offset = "0x84AD5C0", VA = "0x1884AEBC0")]
			private void EECIIIFJMJJ(CullingGroupEvent HDIAOGMLKLH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x84AFB40", Offset = "0x84AE540", VA = "0x1884AFB40")]
			private void PCFOPAJMHOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static OLFEOKKCIEG JHGFKLHHPJD;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static OLFEOKKCIEG EJAKHDHBLOK;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float KLDGGNOBJGN = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float DEBFIDHKKEJ = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float DFCIFLODOLO = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float BFCJBFLFCLB = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float GHFALIODJMH = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float JAJNDNIBLPN = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float EFNENHKADDB = 500f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<KCKOLCALAJM, IEAFIFKJHMJ> AHEDDMBAKEA;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IDisposable ALOPCOGGAPA;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDisposable ENHLODIOEEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly EBDGCEEEFPM LHNDDMFIEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EBDGCEEEFPM BFAMCJFALLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly EBDGCEEEFPM HIHJJKMGHMG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker GIAGCFBKEAA;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker JPJCLNODOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private LCOHCCBKPLJ GEGNOLHEEBO;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool PNBIMDNKJEI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool GKHDDIPMIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C80", Offset = "0xAB4680", VA = "0x180AB5C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EBDGCEEEFPM LFBACKAIHJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EBDGCEEEFPM APBNJNCCDBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public EBDGCEEEFPM AONNAAFKCEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DCFOKHDKMJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xADAB70", Offset = "0xAD9570", VA = "0x180ADAB70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool JODFPGCPBBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xDB85B0", Offset = "0xDB6FB0", VA = "0x180DB85B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xEA4E70", Offset = "0xEA3870", VA = "0x180EA4E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84AD150", Offset = "0x84ABB50", VA = "0x1884AD150", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x824A270", Offset = "0x8248C70", VA = "0x18824A270")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84ADB90", Offset = "0x84AC590", VA = "0x1884ADB90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD82590", Offset = "0xD80F90", VA = "0x180D82590")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84AD6B0", Offset = "0x84AC0B0", VA = "0x1884AD6B0")]
		private void LIKKPMDGBKL(Scene LDEJAMJEHAA, LoadSceneMode GDIJNLEACAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84ADAB0", Offset = "0x84AC4B0", VA = "0x1884ADAB0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84ADE50", Offset = "0x84AC850", VA = "0x1884ADE50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84AD710", Offset = "0x84AC110", VA = "0x1884AD710")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84AD210", Offset = "0x84ABC10", VA = "0x1884AD210")]
		private void CABHEDODEMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84ADBB0", Offset = "0x84AC5B0", VA = "0x1884ADBB0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84ACFE0", Offset = "0x84AB9E0", VA = "0x1884ACFE0")]
		private void AONADKADADE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84AD4D0", Offset = "0x84ABED0", VA = "0x1884AD4D0")]
		public APPPHJAKOPF GetOrCreateCullingGroup(Type BGMINOLINGM, int AMANOJODMJC, ushort FKAEPLCCEJC = 0, bool OKAFNPFHOFP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3BC82D0", Offset = "0x3BC6CD0", VA = "0x183BC82D0")]
		public JPLAFIDIIOO<T> GetOrCreateCullingGroup<T>(int AMANOJODMJC, ushort FKAEPLCCEJC = 0, bool OKAFNPFHOFP = false) where T : class, MFMLODIOEBD
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84AD910", Offset = "0x84AC310", VA = "0x1884AD910")]
		private APPPHJAKOPF MACBJPMEKII(Type BGMINOLINGM, int AMANOJODMJC, float[] LEAIAJCLBJO, ushort FKAEPLCCEJC = 0, bool OKAFNPFHOFP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8370", Offset = "0x3BC6D70", VA = "0x183BC8370")]
		private JPLAFIDIIOO<T> MACBJPMEKII<T>(int AMANOJODMJC, float[] LEAIAJCLBJO, ushort FKAEPLCCEJC = 0, bool OKAFNPFHOFP = false) where T : class, MFMLODIOEBD
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84AD370", Offset = "0x84ABD70", VA = "0x1884AD370")]
		public static ACOJACDAJIP FindClosestDefaultUpdateLod(float DKCJFKIFJCE)
		{
			return default(ACOJACDAJIP);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xADB3F0", Offset = "0xAD9DF0", VA = "0x180ADB3F0")]
		public static ACOJACDAJIP MinUpdateLod(ACOJACDAJIP KMHHKGDFLBL, ACOJACDAJIP KKLBLCHKNHI)
		{
			return default(ACOJACDAJIP);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84ADAA0", Offset = "0x84AC4A0", VA = "0x1884ADAA0")]
		public static ACOJACDAJIP MaxUpdateLod(ACOJACDAJIP KMHHKGDFLBL, ACOJACDAJIP KKLBLCHKNHI)
		{
			return default(ACOJACDAJIP);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84AE2D0", Offset = "0x84ACCD0", VA = "0x1884AE2D0")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xADAB70", Offset = "0xAD9570", VA = "0x180ADAB70", Slot = "11")]
		private bool NNIBCAIEOLK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MELNGJAAFKF
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool FGMIMHOMFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera APIKMINLPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EBDGCEEEFPM KENBNPAEFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool MLNDKOGMFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	EBDGCEEEFPM PEFLIOMFIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform MNMKDFNMCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface APPPHJAKOPF
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMDNMGBNKIA(MFMLODIOEBD PMNHIPACJLN, float JBOIDCJHBGG, FMHNBNKGEEA BGAHDBKIBLE = FMHNBNKGEEA.Off);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MCKODPOBNPM(MFMLODIOEBD JJLACJPCILE);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMBJFBGHMLB(MFMLODIOEBD PMNHIPACJLN, FMHNBNKGEEA EELKHDEBBFM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JPLAFIDIIOO<T> : APPPHJAKOPF where T : class, MFMLODIOEBD
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMDNMGBNKIA(T PMNHIPACJLN, float JBOIDCJHBGG, FMHNBNKGEEA BGAHDBKIBLE = FMHNBNKGEEA.Off);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMDNMGBNKIA(T PMNHIPACJLN, Transform IFMOICEDEHC, float JBOIDCJHBGG, FMHNBNKGEEA BGAHDBKIBLE = FMHNBNKGEEA.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MCKODPOBNPM(T JJLACJPCILE);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DMFPALDEFKL(T PMNHIPACJLN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MFMLODIOEBD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform HALOMIKDIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(ACOJACDAJIP KBLNLHCDNNB, ACOJACDAJIP GHJCHGJCFJK);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool JCIGGBOEPEM);
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
