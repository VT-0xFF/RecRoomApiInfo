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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, OGNGNKLAHIB, BBHLBLBMBEP
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct AGMAKOBNHID : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> NFNBKNAJBPN;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7AE6E10", Offset = "0x7AE5610", VA = "0x187AE6E10", Slot = "4")]
			public void Execute(int FPEOONOJHML, TransformAccess POFBAOBKAGL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct KEGPLHJFKGL : IEquatable<KEGPLHJFKGL>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort EGAFCGDAFLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type EBHHHHJHGPG;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7AE8430", Offset = "0x7AE6C30", VA = "0x187AE8430", Slot = "4")]
			public bool Equals(KEGPLHJFKGL PGPJMFPAKOO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7AE8340", Offset = "0x7AE6B40", VA = "0x187AE8340", Slot = "0")]
			public override bool Equals(object PNHCNFOFAFI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7AE84B0", Offset = "0x7AE6CB0", VA = "0x187AE84B0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class IKMLNAPCABF<T> : ONFDAHMPEIB, BELDHOKJDKG<T>, MKOALGGHCAA where T : class, BNDCELMPOLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4B82510", Offset = "0x4B80D10", VA = "0x184B82510")]
			internal IKMLNAPCABF(int LGKINEPPBJO, float[] EOPPKBAPCIH, AKJKGPNGEGG ALHMBCGGCGH = AKJKGPNGEGG.PlayerHead, bool FKPOLOPPCHM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4B824B0", Offset = "0x4B80CB0", VA = "0x184B824B0", Slot = "12")]
			public void OIHLAKEIFNH(T PNHCNFOFAFI, float BCDEDKPOOJB, LDLKAPLIJLM LHLLFKIKAGK = LDLKAPLIJLM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4B824E0", Offset = "0x4B80CE0", VA = "0x184B824E0", Slot = "13")]
			public void OIHLAKEIFNH(T PNHCNFOFAFI, Transform CBDNFDJONJP, float BCDEDKPOOJB, LDLKAPLIJLM LHLLFKIKAGK = LDLKAPLIJLM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4B82470", Offset = "0x4B80C70", VA = "0x184B82470", Slot = "14")]
			public void AHELLINFOCL(T DFGCBOKMFOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4B82490", Offset = "0x4B80C90", VA = "0x184B82490", Slot = "15")]
			public bool DOOPMBGFMMM(T PNHCNFOFAFI)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class ONFDAHMPEIB : IDisposable, MKOALGGHCAA
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct GAGGEIKOKNP
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum JHNJLEPCLOH : byte
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
				public BNDCELMPOLP LJJLPIHDEKJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform FCHHAJKLMDP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float FFLBHMOOMNL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public LDLKAPLIJLM FEDFMNMPACF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public JHNJLEPCLOH PALJBODIBGP;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum AKJKGPNGEGG : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class HHFMGHKCOMB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public BNDCELMPOLP LJJLPIHDEKJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public LDLKAPLIJLM FBNGJABLKMN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action NJLDLOLOBCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool MDDPEAAOALK;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
				public HHFMGHKCOMB()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int GCLDKHIFCPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool FKPOLOPPCHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool HGKGNONOPPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup DGMCDJLIEMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] PHEAJOPAACB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly MANHHOBPPLB LMJFACKNPAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly AKJKGPNGEGG ALHMBCGGCGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<BNDCELMPOLP, int> GAEFCOFGJMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, HHFMGHKCOMB> PMOADBDCHLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray IBLHODOBAAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> ICAAPCHGKAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<GAGGEIKOKNP> HGHFLNLKMIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool KMNDEJLKIDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle OHHKLKBFKLA;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int ADJODOMFBBF
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int PINANPLPKGK
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xB5FCA0", Offset = "0xB5E4A0", VA = "0x180B5FCA0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xC57CC0", Offset = "0xC564C0", VA = "0x180C57CC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7AEA160", Offset = "0x7AE8960", VA = "0x187AEA160")]
			internal ONFDAHMPEIB(int LGKINEPPBJO, float[] EOPPKBAPCIH, AKJKGPNGEGG ALHMBCGGCGH = AKJKGPNGEGG.PlayerHead, bool FKPOLOPPCHM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7AE8580", Offset = "0x7AE6D80", VA = "0x187AE8580")]
			public void AJOPGNKCMEE(bool PACEJFCJBID)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7AE9CC0", Offset = "0x7AE84C0", VA = "0x187AE9CC0", Slot = "5")]
			public void OIHLAKEIFNH(BNDCELMPOLP PNHCNFOFAFI, float BCDEDKPOOJB, LDLKAPLIJLM LHLLFKIKAGK = LDLKAPLIJLM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7AE9DC0", Offset = "0x7AE85C0", VA = "0x187AE9DC0", Slot = "10")]
			public void OIHLAKEIFNH(BNDCELMPOLP PNHCNFOFAFI, Transform CBDNFDJONJP, float BCDEDKPOOJB, LDLKAPLIJLM LHLLFKIKAGK = LDLKAPLIJLM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7AE95F0", Offset = "0x7AE7DF0", VA = "0x187AE95F0")]
			private void KIMPNIDEDHG(BNDCELMPOLP PNHCNFOFAFI, Transform CBDNFDJONJP, float BCDEDKPOOJB, LDLKAPLIJLM LHLLFKIKAGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7AE8520", Offset = "0x7AE6D20", VA = "0x187AE8520", Slot = "6")]
			public void AHELLINFOCL(BNDCELMPOLP DFGCBOKMFOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7AE8BD0", Offset = "0x7AE73D0", VA = "0x187AE8BD0")]
			private void EIECLCKLMAA(BNDCELMPOLP DFGCBOKMFOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7AE9180", Offset = "0x7AE7980", VA = "0x187AE9180")]
			private void GJFNJMLOLPB(BNDCELMPOLP PNHCNFOFAFI, [Optional] float? BCDEDKPOOJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7AE88E0", Offset = "0x7AE70E0", VA = "0x187AE88E0", Slot = "11")]
			public bool DOOPMBGFMMM(BNDCELMPOLP PNHCNFOFAFI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
			public void KNMKMHFLBKG(BNDCELMPOLP PNHCNFOFAFI, LDLKAPLIJLM DGODLAPCKGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7AE99F0", Offset = "0x7AE81F0", VA = "0x187AE99F0")]
			private void LILINIKDOPL(BNDCELMPOLP PNHCNFOFAFI, LDLKAPLIJLM DGODLAPCKGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7AE9BF0", Offset = "0x7AE83F0", VA = "0x187AE9BF0")]
			public void LOPLNHNNALB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7AE93E0", Offset = "0x7AE7BE0", VA = "0x187AE93E0")]
			public void IBNMDNEJFOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7AE9E60", Offset = "0x7AE8660", VA = "0x187AE9E60")]
			private void OLGEHHBNHKD(GAGGEIKOKNP JDLOGJMLBHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7AE9AA0", Offset = "0x7AE82A0", VA = "0x187AE9AA0")]
			private void LMPHJFHDIDN(int LAHDMNFPGEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7AE89A0", Offset = "0x7AE71A0", VA = "0x187AE89A0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7AE99E0", Offset = "0x7AE81E0", VA = "0x187AE99E0")]
			private void LBPCEGFEGAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7AE9CB0", Offset = "0x7AE84B0", VA = "0x187AE9CB0")]
			private void MJCFPANOFMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7AE85B0", Offset = "0x7AE6DB0", VA = "0x187AE85B0")]
			private void CCJBHGNEHKA(CullingGroupEvent MIAALIOCKAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7AE9010", Offset = "0x7AE7810", VA = "0x187AE9010")]
			private void FFPFLOHGDFI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float PJHEBFGEHPO = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float HLLJLBAIKFE = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float BGCHIMAIADG = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float COANOGOLOPE = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float MELKLDLEEDP = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float EDILJLLLJJE = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float LJJOPCMAOPG = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<KEGPLHJFKGL, ONFDAHMPEIB> LODMNADEFJN;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable PHPCEJOPAHL;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable ODJGMMDPGHP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static FIEKIAHLEMJ DJBAKOFJJHC;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static FIEKIAHLEMJ LAJAHAJGEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly FIEKIAHLEMJ AMNNDCHELBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly FIEKIAHLEMJ BNFGENDBCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly FIEKIAHLEMJ BFHOGFPBLLB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker KFOLGFBGLGN;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker OGGCCKCIIAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private KIJPFMOACHH OCMKDEMODIE;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool PACEJFCJBID;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool GJDHMDIAJII
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9E0E00", Offset = "0x9DF600", VA = "0x1809E0E00", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9E0E10", Offset = "0x9DF610", VA = "0x1809E0E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public FIEKIAHLEMJ PKHMDBNCHFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public FIEKIAHLEMJ ANDPOBIDGOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public FIEKIAHLEMJ CNDDJHNEHAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ILBDECIMLLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA0A8D0", Offset = "0xA090D0", VA = "0x180A0A8D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool OEOANFDELPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFC1F0", VA = "0x180BFD9F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCC7800", Offset = "0xCC6000", VA = "0x180CC7800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7AE6E90", Offset = "0x7AE5690", VA = "0x187AE6E90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x78CFCE0", Offset = "0x78CE4E0", VA = "0x1878CFCE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E1FDC0", Offset = "0x1E1E5C0", VA = "0x181E1FDC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBC8AD0", Offset = "0xBC72D0", VA = "0x180BC8AD0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7AE73F0", Offset = "0x7AE5BF0", VA = "0x187AE73F0")]
		private void IHCAHKPKPMD(Scene MGAACDLILLD, LoadSceneMode MGNGIPCHJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7830", Offset = "0x7AE6030", VA = "0x187AE7830", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7D10", Offset = "0x7AE6510", VA = "0x187AE7D10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AE75E0", Offset = "0x7AE5DE0", VA = "0x187AE75E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7AE6F50", Offset = "0x7AE5750", VA = "0x187AE6F50")]
		private void BBDPPCHMALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7A80", Offset = "0x7AE6280", VA = "0x187AE7A80")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7910", Offset = "0x7AE6110", VA = "0x187AE7910")]
		private void PPKBGAKAKBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7210", Offset = "0x7AE5A10", VA = "0x187AE7210")]
		public MKOALGGHCAA GetOrCreateCullingGroup(Type LFLIIJCENEC, int HLAAIODCJDD, ushort HBFNMPFKHMF = 0, bool FKPOLOPPCHM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x35CE020", Offset = "0x35CC820", VA = "0x1835CE020")]
		public BELDHOKJDKG<T> GetOrCreateCullingGroup<T>(int HLAAIODCJDD, ushort HBFNMPFKHMF = 0, bool FKPOLOPPCHM = false) where T : class, BNDCELMPOLP
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7450", Offset = "0x7AE5C50", VA = "0x187AE7450")]
		private MKOALGGHCAA KDCNIINAHGD(Type LFLIIJCENEC, int HLAAIODCJDD, float[] EOPPKBAPCIH, ushort HBFNMPFKHMF = 0, bool FKPOLOPPCHM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x35CE0E0", Offset = "0x35CC8E0", VA = "0x1835CE0E0")]
		private BELDHOKJDKG<T> KDCNIINAHGD<T>(int HLAAIODCJDD, float[] EOPPKBAPCIH, ushort HBFNMPFKHMF = 0, bool FKPOLOPPCHM = false) where T : class, BNDCELMPOLP
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7AE70B0", Offset = "0x7AE58B0", VA = "0x187AE70B0")]
		public static GLBLJMJHHNB FindClosestDefaultUpdateLod(float DGNOBPIBGIF)
		{
			return default(GLBLJMJHHNB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA0C060", Offset = "0xA0A860", VA = "0x180A0C060")]
		public static GLBLJMJHHNB MinUpdateLod(GLBLJMJHHNB JGOFONDEGON, GLBLJMJHHNB NCKLHMPIBKM)
		{
			return default(GLBLJMJHHNB);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7820", Offset = "0x7AE6020", VA = "0x187AE7820")]
		public static GLBLJMJHHNB MaxUpdateLod(GLBLJMJHHNB JGOFONDEGON, GLBLJMJHHNB NCKLHMPIBKM)
		{
			return default(GLBLJMJHHNB);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE81F0", Offset = "0x7AE69F0", VA = "0x187AE81F0")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A8D0", Offset = "0xA090D0", VA = "0x180A0A8D0", Slot = "11")]
		private bool CCGJAFGIMCA()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MANHHOBPPLB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool CNDIGGFJGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera ENOIEKJDPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FIEKIAHLEMJ GIEHFCICJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool OBGLEHIOIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	FIEKIAHLEMJ NNFFHEILOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform JNJPCHFAKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MKOALGGHCAA
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIHLAKEIFNH(BNDCELMPOLP PNHCNFOFAFI, float BCDEDKPOOJB, LDLKAPLIJLM LHLLFKIKAGK = LDLKAPLIJLM.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHELLINFOCL(BNDCELMPOLP DFGCBOKMFOJ);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KNMKMHFLBKG(BNDCELMPOLP PNHCNFOFAFI, LDLKAPLIJLM ODHNLEIACEK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BELDHOKJDKG<T> : MKOALGGHCAA where T : class, BNDCELMPOLP
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIHLAKEIFNH(T PNHCNFOFAFI, float BCDEDKPOOJB, LDLKAPLIJLM LHLLFKIKAGK = LDLKAPLIJLM.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIHLAKEIFNH(T PNHCNFOFAFI, Transform CBDNFDJONJP, float BCDEDKPOOJB, LDLKAPLIJLM LHLLFKIKAGK = LDLKAPLIJLM.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AHELLINFOCL(T DFGCBOKMFOJ);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DOOPMBGFMMM(T PNHCNFOFAFI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BNDCELMPOLP
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform POFBAOBKAGL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(GLBLJMJHHNB FHGCLIBHLLA, GLBLJMJHHNB OLMOEHOBPDO);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool POJMALAACLJ);
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
