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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, DPLLONCBFPL, PFFMGCANADG
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct OBGDNHFHOHK : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> DHAOEHNLNON;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A690", Offset = "0x7C59890", VA = "0x187C5A690", Slot = "4")]
			public void Execute(int NIBICIJAIGM, TransformAccess PMPOHKBNMIB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct OPDPFMHLEBN : IEquatable<OPDPFMHLEBN>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort JBAHBNCIKDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type NFBENEIJOCA;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A800", Offset = "0x7C59A00", VA = "0x187C5A800", Slot = "4")]
			public bool Equals(OPDPFMHLEBN FNJGMJGALLH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A710", Offset = "0x7C59910", VA = "0x187C5A710", Slot = "0")]
			public override bool Equals(object DBCLNEGBNLN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A880", Offset = "0x7C59A80", VA = "0x187C5A880", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class ADPPIGEMIOI<T> : CADFOJJJIBP, KIGNPJHHHEM<T>, ILEMBOPEPIL where T : class, CLCFMGGCEKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4A7DD80", Offset = "0x4A7CF80", VA = "0x184A7DD80")]
			internal ADPPIGEMIOI(int LLAGHPOEBEI, float[] GHHEBFDEBBF, GLKDBPPGIEK EINIIJLLDOJ = GLKDBPPGIEK.PlayerHead, bool IAFOHDAFLKN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4A7DD50", Offset = "0x4A7CF50", VA = "0x184A7DD50", Slot = "12")]
			public void OOLDDNFEGEK(T DBCLNEGBNLN, float IHBIKJPLAHJ, PKLBDOAGHDH GKIOFNLDPJP = PKLBDOAGHDH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4A7DD20", Offset = "0x4A7CF20", VA = "0x184A7DD20", Slot = "13")]
			public void OOLDDNFEGEK(T DBCLNEGBNLN, Transform LCBCPFKBFIJ, float IHBIKJPLAHJ, PKLBDOAGHDH GKIOFNLDPJP = PKLBDOAGHDH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4A7DD00", Offset = "0x4A7CF00", VA = "0x184A7DD00", Slot = "14")]
			public void KKKHDEJPLIG(T MFEOOKEKIDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4A7DCE0", Offset = "0x4A7CEE0", VA = "0x184A7DCE0", Slot = "15")]
			public bool IEFLOKHPLDE(T DBCLNEGBNLN)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class CADFOJJJIBP : IDisposable, ILEMBOPEPIL
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct KJFCBAHGCEM
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum EGLDDONIBIK : byte
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
				public CLCFMGGCEKG OGBBAAKFDKA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform NBDDMFIBPFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float AMBCENEAEIN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public PKLBDOAGHDH CGGEDOELCKP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public EGLDDONIBIK AFGCMPJBOON;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum GLKDBPPGIEK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class CBDDLGCHHKF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public CLCFMGGCEKG OGBBAAKFDKA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public PKLBDOAGHDH JCDOKCICGOE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action NFDPLNMCCKJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool PCBGNAANIBM;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
				public CBDDLGCHHKF()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int AAJLDOONBPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool IAFOHDAFLKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool DJOMNIEOFJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup JHHLAHHFFFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] JCHIBCAGCGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly HANKMEHPMHB OIONFMJBFHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly GLKDBPPGIEK EINIIJLLDOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<CLCFMGGCEKG, int> OMHBFHDMCAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, CBDDLGCHHKF> AFBEENILCHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray AFPGBABGOHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> MNDJIJDHFLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<KJFCBAHGCEM> BFELDNOHCFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool OEFOFHCOHLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle EOJDBKLNAOP;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int KCBBPIIHDDL
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int PCKIHBENBMD
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xB834E0", Offset = "0xB826E0", VA = "0x180B834E0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xC65020", Offset = "0xC64220", VA = "0x180C65020")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7C58D00", Offset = "0x7C57F00", VA = "0x187C58D00")]
			internal CADFOJJJIBP(int LLAGHPOEBEI, float[] GHHEBFDEBBF, GLKDBPPGIEK EINIIJLLDOJ = GLKDBPPGIEK.PlayerHead, bool IAFOHDAFLKN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7C588F0", Offset = "0x7C57AF0", VA = "0x187C588F0")]
			public void MOMEAHAEKAH(bool PJIDDMKIDIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7C58930", Offset = "0x7C57B30", VA = "0x187C58930", Slot = "5")]
			public void OOLDDNFEGEK(CLCFMGGCEKG DBCLNEGBNLN, float IHBIKJPLAHJ, PKLBDOAGHDH GKIOFNLDPJP = PKLBDOAGHDH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7C58A30", Offset = "0x7C57C30", VA = "0x187C58A30", Slot = "10")]
			public void OOLDDNFEGEK(CLCFMGGCEKG DBCLNEGBNLN, Transform LCBCPFKBFIJ, float IHBIKJPLAHJ, PKLBDOAGHDH GKIOFNLDPJP = PKLBDOAGHDH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7C57950", Offset = "0x7C56B50", VA = "0x187C57950")]
			private void CNCODPEHCIJ(CLCFMGGCEKG DBCLNEGBNLN, Transform LCBCPFKBFIJ, float IHBIKJPLAHJ, PKLBDOAGHDH GKIOFNLDPJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7C58890", Offset = "0x7C57A90", VA = "0x187C58890", Slot = "6")]
			public void KKKHDEJPLIG(CLCFMGGCEKG MFEOOKEKIDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7C582D0", Offset = "0x7C574D0", VA = "0x187C582D0")]
			private void GOLLKEHALKP(CLCFMGGCEKG MFEOOKEKIDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7C573F0", Offset = "0x7C565F0", VA = "0x187C573F0")]
			private void CCCDMECMHBB(CLCFMGGCEKG DBCLNEGBNLN, [Optional] float? IHBIKJPLAHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7C58720", Offset = "0x7C57920", VA = "0x187C58720", Slot = "11")]
			public bool IEFLOKHPLDE(CLCFMGGCEKG DBCLNEGBNLN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
			public void BDBMDNOBBBD(CLCFMGGCEKG DBCLNEGBNLN, PKLBDOAGHDH MKEODAKMBJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7C587E0", Offset = "0x7C579E0", VA = "0x187C587E0")]
			private void JCNMDKJGMEE(CLCFMGGCEKG DBCLNEGBNLN, PKLBDOAGHDH MKEODAKMBJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7C58C40", Offset = "0x7C57E40", VA = "0x187C58C40")]
			public void PIFIMLNJMGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7C580C0", Offset = "0x7C572C0", VA = "0x187C580C0")]
			public void FIKEJNFDBKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7C57650", Offset = "0x7C56850", VA = "0x187C57650")]
			private void CKKCIDFIFJC(KJFCBAHGCEM FLCLDMGPCKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7C57F70", Offset = "0x7C57170", VA = "0x187C57F70")]
			private void EHIGCOIGALB(int BKPPPMFAFNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7C57D40", Offset = "0x7C56F40", VA = "0x187C57D40", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7C58920", Offset = "0x7C57B20", VA = "0x187C58920")]
			private void NBIDBFAIPJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7C58710", Offset = "0x7C57910", VA = "0x187C58710")]
			private void HDCELMMPMJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7C570C0", Offset = "0x7C562C0", VA = "0x187C570C0")]
			private void BLINBIKJKMP(CullingGroupEvent OIAMDAGMMMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7C58AD0", Offset = "0x7C57CD0", VA = "0x187C58AD0")]
			private void PBKEPIPMBPH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float PHKNGKOBODA = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float NEDBNLADIHA = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float BAHLKIJFDND = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float GJGFNJHOMMF = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float HACEKPLJEFA = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float JLPDKHKIDHA = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float ELOFPOCPBIL = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<OPDPFMHLEBN, CADFOJJJIBP> DFLAGOONLDJ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable EHMEGEOJGLL;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable MKKLCKEJIMB;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static JGNOJICCDHE OPLPLAFFGJD;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static JGNOJICCDHE DADAIBNANLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly JGNOJICCDHE EANEDFMGLIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly JGNOJICCDHE NPFHOMMODKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly JGNOJICCDHE BKDNEAILMBF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker GGIOFGJLDEL;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker DBODLMOIGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private PEFNPNHCEAP NKEAGKDJAGO;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool PJIDDMKIDIA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool HMKFKLBGGOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9F24F0", Offset = "0x9F16F0", VA = "0x1809F24F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JGNOJICCDHE EMPCNLGDJDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JGNOJICCDHE LAAGDAAPLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public JGNOJICCDHE KJBGHMDPMGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IFIPKLAKGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA1CDE0", Offset = "0xA1BFE0", VA = "0x180A1CDE0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DOLBCAHANKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xC1FDC0", Offset = "0xC1EFC0", VA = "0x180C1FDC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCF9F40", Offset = "0xCF9140", VA = "0x180CF9F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C591E0", Offset = "0x7C583E0", VA = "0x187C591E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7A3BAC0", Offset = "0x7A3ACC0", VA = "0x187A3BAC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E7D530", Offset = "0x1E7C730", VA = "0x181E7D530")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC0CE10", Offset = "0xC0C010", VA = "0x180C0CE10")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C59A40", Offset = "0x7C58C40", VA = "0x187C59A40")]
		private void IBMINNOHIPF(Scene IIPJDMFDDBF, LoadSceneMode BGIKBFMPDCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C59CF0", Offset = "0x7C58EF0", VA = "0x187C59CF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A060", Offset = "0x7C59260", VA = "0x187C5A060")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C59AA0", Offset = "0x7C58CA0", VA = "0x187C59AA0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C592A0", Offset = "0x7C584A0", VA = "0x187C592A0")]
		private void DLOHDIJPJDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C59DD0", Offset = "0x7C58FD0", VA = "0x187C59DD0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C598D0", Offset = "0x7C58AD0", VA = "0x187C598D0")]
		private void HNLDPGFLJEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C596F0", Offset = "0x7C588F0", VA = "0x187C596F0")]
		public ILEMBOPEPIL GetOrCreateCullingGroup(Type KBDBDDKNKEJ, int HMFFNADGPDO, ushort IGDBEPDINJP = 0, bool IAFOHDAFLKN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3660D60", Offset = "0x365FF60", VA = "0x183660D60")]
		public KIGNPJHHHEM<T> GetOrCreateCullingGroup<T>(int HMFFNADGPDO, ushort IGDBEPDINJP = 0, bool IAFOHDAFLKN = false) where T : class, CLCFMGGCEKG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C59400", Offset = "0x7C58600", VA = "0x187C59400")]
		private ILEMBOPEPIL EACPIHEFKOH(Type KBDBDDKNKEJ, int HMFFNADGPDO, float[] GHHEBFDEBBF, ushort IGDBEPDINJP = 0, bool IAFOHDAFLKN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3660B20", Offset = "0x365FD20", VA = "0x183660B20")]
		private KIGNPJHHHEM<T> EACPIHEFKOH<T>(int HMFFNADGPDO, float[] GHHEBFDEBBF, ushort IGDBEPDINJP = 0, bool IAFOHDAFLKN = false) where T : class, CLCFMGGCEKG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C59590", Offset = "0x7C58790", VA = "0x187C59590")]
		public static MIPMLGOBAHP FindClosestDefaultUpdateLod(float HBNCBJCKNPL)
		{
			return default(MIPMLGOBAHP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA1E450", Offset = "0xA1D650", VA = "0x180A1E450")]
		public static MIPMLGOBAHP MinUpdateLod(MIPMLGOBAHP EMJHPEEIDKO, MIPMLGOBAHP PGCCONJCEHC)
		{
			return default(MIPMLGOBAHP);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C59CE0", Offset = "0x7C58EE0", VA = "0x187C59CE0")]
		public static MIPMLGOBAHP MaxUpdateLod(MIPMLGOBAHP EMJHPEEIDKO, MIPMLGOBAHP PGCCONJCEHC)
		{
			return default(MIPMLGOBAHP);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A540", Offset = "0x7C59740", VA = "0x187C5A540")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA1CDE0", Offset = "0xA1BFE0", VA = "0x180A1CDE0", Slot = "11")]
		private bool IPNNAEAJLGL()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HANKMEHPMHB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool DFNNIEKPMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera ACPHDCOJALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JGNOJICCDHE CPKLELAGDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool HCFKAKGAGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	JGNOJICCDHE CCOAOIBMJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform EAKGJPONGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ILEMBOPEPIL
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOLDDNFEGEK(CLCFMGGCEKG DBCLNEGBNLN, float IHBIKJPLAHJ, PKLBDOAGHDH GKIOFNLDPJP = PKLBDOAGHDH.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKKHDEJPLIG(CLCFMGGCEKG MFEOOKEKIDL);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDBMDNOBBBD(CLCFMGGCEKG DBCLNEGBNLN, PKLBDOAGHDH AIEINDDFMCF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KIGNPJHHHEM<T> : ILEMBOPEPIL where T : class, CLCFMGGCEKG
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOLDDNFEGEK(T DBCLNEGBNLN, float IHBIKJPLAHJ, PKLBDOAGHDH GKIOFNLDPJP = PKLBDOAGHDH.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOLDDNFEGEK(T DBCLNEGBNLN, Transform LCBCPFKBFIJ, float IHBIKJPLAHJ, PKLBDOAGHDH GKIOFNLDPJP = PKLBDOAGHDH.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KKKHDEJPLIG(T MFEOOKEKIDL);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IEFLOKHPLDE(T DBCLNEGBNLN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CLCFMGGCEKG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform PMPOHKBNMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(MIPMLGOBAHP NHBOLBJANJI, MIPMLGOBAHP GFJPEKBBFEB);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool MNPKGGBNMNL);
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
