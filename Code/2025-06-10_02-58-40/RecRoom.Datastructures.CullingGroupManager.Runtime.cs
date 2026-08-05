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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, HILNFMOEKON, DJNFGEJICJL
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct FMEAKBCJOBP : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> CAIGHLKIDBF;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7C152C0", Offset = "0x7C144C0", VA = "0x187C152C0", Slot = "4")]
			public void Execute(int CMDFFDAPDIB, TransformAccess JGOMLHGOKKB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct FLOLGHINOMI : IEquatable<FLOLGHINOMI>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort OFHCBINJHFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type BEDHBGJACBN;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7C150E0", Offset = "0x7C142E0", VA = "0x187C150E0", Slot = "4")]
			public bool Equals(FLOLGHINOMI CMOCFNBHPLJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7C15160", Offset = "0x7C14360", VA = "0x187C15160", Slot = "0")]
			public override bool Equals(object KFMNDOMPAMC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7C15250", Offset = "0x7C14450", VA = "0x187C15250", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class LAIDFGGHGLM<T> : NFJIDNAFCCN, NNMEHOKDECM<T>, JPIDDDBCPEO where T : class, DNCJIBHBDAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x51D91A0", Offset = "0x51D83A0", VA = "0x1851D91A0")]
			internal LAIDFGGHGLM(int KLOBGBJADIK, float[] BEMNHGOCHKO, GHLPOOEFOHN CAPAGAMHCMG = GHLPOOEFOHN.PlayerHead, bool FDBKLGILANH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x51D9120", Offset = "0x51D8320", VA = "0x1851D9120", Slot = "12")]
			public void LHOMNBOIMGH(T KFMNDOMPAMC, float DKGEGBLOEHH, CMFBMPLFPMI DLKPCJPPMBG = CMFBMPLFPMI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x51D9150", Offset = "0x51D8350", VA = "0x1851D9150", Slot = "13")]
			public void LHOMNBOIMGH(T KFMNDOMPAMC, Transform EHDGFJNIKGE, float DKGEGBLOEHH, CMFBMPLFPMI DLKPCJPPMBG = CMFBMPLFPMI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x51D9180", Offset = "0x51D8380", VA = "0x1851D9180", Slot = "14")]
			public void PKCJOLGDFLO(T CEFFOBKGKDI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x51D9100", Offset = "0x51D8300", VA = "0x1851D9100", Slot = "15")]
			public bool ABBEBNEAAAL(T KFMNDOMPAMC)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class NFJIDNAFCCN : IDisposable, JPIDDDBCPEO
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct BCOBAJJNMEM
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum GBOODEHBPDD : byte
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
				public DNCJIBHBDAC CGNKBCKBMIC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform DEGAIHEEOBC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float NLABEFHONMO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public CMFBMPLFPMI FDPBLHJMEHJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public GBOODEHBPDD BGLOFMKFAEA;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum GHLPOOEFOHN : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class LJIDOCEANID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public DNCJIBHBDAC CGNKBCKBMIC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public CMFBMPLFPMI FNMJFCELNKD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action GCKJIODEKGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool EPDENKHPBJO;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
				public LJIDOCEANID()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int LJPOFFHOCIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool FDBKLGILANH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool OLFOBLPNEEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup BKMHAFDKHBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] KGLOKCOJOMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly AFMLFLCLKLJ PLKEMCOOOMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly GHLPOOEFOHN CAPAGAMHCMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<DNCJIBHBDAC, int> EJDGDGJGLCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, LJIDOCEANID> DGNOBLJOAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray PDBDOAEGEDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> AJNDPBIKOIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<BCOBAJJNMEM> LCNOFNLDBBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool DCAEEICFPGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle KHHGIDEGAOE;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int GICHPLFANJA
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0xA00110", Offset = "0x9FF310", VA = "0x180A00110", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0xA03700", Offset = "0xA02900", VA = "0x180A03700")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int MDHJBIKFMJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA90990", Offset = "0xA8FB90", VA = "0x180A90990", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xA909F0", Offset = "0xA8FBF0", VA = "0x180A909F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7C16F70", Offset = "0x7C16170", VA = "0x187C16F70")]
			internal NFJIDNAFCCN(int KLOBGBJADIK, float[] BEMNHGOCHKO, GHLPOOEFOHN CAPAGAMHCMG = GHLPOOEFOHN.PlayerHead, bool FDBKLGILANH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7C16EE0", Offset = "0x7C160E0", VA = "0x187C16EE0")]
			public void PKCJEKGLOOP(bool HPDDMCOBLGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7C16BD0", Offset = "0x7C15DD0", VA = "0x187C16BD0", Slot = "5")]
			public void LHOMNBOIMGH(DNCJIBHBDAC KFMNDOMPAMC, float DKGEGBLOEHH, CMFBMPLFPMI DLKPCJPPMBG = CMFBMPLFPMI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7C16CD0", Offset = "0x7C15ED0", VA = "0x187C16CD0", Slot = "10")]
			public void LHOMNBOIMGH(DNCJIBHBDAC KFMNDOMPAMC, Transform EHDGFJNIKGE, float DKGEGBLOEHH, CMFBMPLFPMI DLKPCJPPMBG = CMFBMPLFPMI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7C161C0", Offset = "0x7C153C0", VA = "0x187C161C0")]
			private void JHIEDBDFAIO(DNCJIBHBDAC KFMNDOMPAMC, Transform EHDGFJNIKGE, float DKGEGBLOEHH, CMFBMPLFPMI DLKPCJPPMBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7C16F10", Offset = "0x7C16110", VA = "0x187C16F10", Slot = "6")]
			public void PKCJOLGDFLO(DNCJIBHBDAC CEFFOBKGKDI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7C15850", Offset = "0x7C14A50", VA = "0x187C15850")]
			private void GBJGADEEDIO(DNCJIBHBDAC CEFFOBKGKDI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7C15D50", Offset = "0x7C14F50", VA = "0x187C15D50")]
			private void GJAGODKIJAN(DNCJIBHBDAC KFMNDOMPAMC, [Optional] float? DKGEGBLOEHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7C15340", Offset = "0x7C14540", VA = "0x187C15340", Slot = "11")]
			public bool ABBEBNEAAAL(DNCJIBHBDAC KFMNDOMPAMC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
			public void LGELDOEBBCJ(DNCJIBHBDAC KFMNDOMPAMC, CMFBMPLFPMI EANNLHIBFDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7C15420", Offset = "0x7C14620", VA = "0x187C15420")]
			private void BIKGKEDEPHC(DNCJIBHBDAC KFMNDOMPAMC, CMFBMPLFPMI EANNLHIBFDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7C15C90", Offset = "0x7C14E90", VA = "0x187C15C90")]
			public void GGEIMFJHPFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7C15FB0", Offset = "0x7C151B0", VA = "0x187C15FB0")]
			public void HKOLIDGJINK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7C165B0", Offset = "0x7C157B0", VA = "0x187C165B0")]
			private void JJMHPKGOGLL(BCOBAJJNMEM NAGHCPKAEOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7C15700", Offset = "0x7C14900", VA = "0x187C15700")]
			private void GAGJNPMOGKJ(int MCOHDLKOKCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7C154D0", Offset = "0x7C146D0", VA = "0x187C154D0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7C15400", Offset = "0x7C14600", VA = "0x187C15400")]
			private void APAJNPODBOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7C15410", Offset = "0x7C14610", VA = "0x187C15410")]
			private void BGAMABPHFLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7C168A0", Offset = "0x7C15AA0", VA = "0x187C168A0")]
			private void KALLBFKKOPH(CullingGroupEvent MIHAIHCMEKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7C16D70", Offset = "0x7C15F70", VA = "0x187C16D70")]
			private void LICNIFILFPO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float OBJKAJGLCLN = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float AKPPIPDNCKB = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float DLNLDEPCCAL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float CFCDHHLKADB = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float MANCBLDMBFB = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float BINKNDOMFFL = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float OHMIMJDFOED = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<FLOLGHINOMI, NFJIDNAFCCN> MIKBFLCIFGF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable BJPEFHOOKEF;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable IGNHHGANOCL;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static EPHHEFDKGKL GPGCLKIGGJP;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static EPHHEFDKGKL ACLCLIOLEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly EPHHEFDKGKL IFFAMEIOLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EPHHEFDKGKL FJOBDGKLHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly EPHHEFDKGKL DOHCGPDEHPG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker JADMLFCBNAJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker HHPFJBOLEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private AFABIGEDGFJ PHMLKABBCCP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool HPDDMCOBLGI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool GNLOCEOGNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA0D3F0", Offset = "0xA0C5F0", VA = "0x180A0D3F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xA0D640", Offset = "0xA0C840", VA = "0x180A0D640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EPHHEFDKGKL KBLKJFDIFJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EPHHEFDKGKL FGLLAONBBEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public EPHHEFDKGKL FFOFFKDDNEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool PFBHMOCNPKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA2DEE0", Offset = "0xA2D0E0", VA = "0x180A2DEE0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool KCOODAFDHLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xC777C0", Offset = "0xC769C0", VA = "0x180C777C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD714B0", Offset = "0xD706B0", VA = "0x180D714B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C13C10", Offset = "0x7C12E10", VA = "0x187C13C10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x79E6D30", Offset = "0x79E5F30", VA = "0x1879E6D30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C14800", Offset = "0x7C13A00", VA = "0x187C14800")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC66930", Offset = "0xC65B30", VA = "0x180C66930")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C13CD0", Offset = "0x7C12ED0", VA = "0x187C13CD0")]
		private void DCDKCMELFOP(Scene FFNEFMEEJGM, LoadSceneMode CPNALAHLBCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C14720", Offset = "0x7C13920", VA = "0x187C14720", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C14AB0", Offset = "0x7C13CB0", VA = "0x187C14AB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C14340", Offset = "0x7C13540", VA = "0x187C14340")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C13D30", Offset = "0x7C12F30", VA = "0x187C13D30")]
		private void EIOOIHOJHLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C14820", Offset = "0x7C13A20", VA = "0x187C14820")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C141D0", Offset = "0x7C133D0", VA = "0x187C141D0")]
		private void LIMEICADNLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C13FF0", Offset = "0x7C131F0", VA = "0x187C13FF0")]
		public JPIDDDBCPEO GetOrCreateCullingGroup(Type EMMGGJLHJAO, int GMLOGIDOACN, ushort BAHDGCDNAFN = 0, bool FDBKLGILANH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x382E100", Offset = "0x382D300", VA = "0x18382E100")]
		public NNMEHOKDECM<T> GetOrCreateCullingGroup<T>(int GMLOGIDOACN, ushort BAHDGCDNAFN = 0, bool FDBKLGILANH = false) where T : class, DNCJIBHBDAC
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C14590", Offset = "0x7C13790", VA = "0x187C14590")]
		private JPIDDDBCPEO ONNIDPFHHOL(Type EMMGGJLHJAO, int GMLOGIDOACN, float[] BEMNHGOCHKO, ushort BAHDGCDNAFN = 0, bool FDBKLGILANH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x382E1A0", Offset = "0x382D3A0", VA = "0x18382E1A0")]
		private NNMEHOKDECM<T> ONNIDPFHHOL<T>(int GMLOGIDOACN, float[] BEMNHGOCHKO, ushort BAHDGCDNAFN = 0, bool FDBKLGILANH = false) where T : class, DNCJIBHBDAC
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C13E90", Offset = "0x7C13090", VA = "0x187C13E90")]
		public static DLGGNNMFNFI FindClosestDefaultUpdateLod(float IJDPCJIPOCK)
		{
			return default(DLGGNNMFNFI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA2F620", Offset = "0xA2E820", VA = "0x180A2F620")]
		public static DLGGNNMFNFI MinUpdateLod(DLGGNNMFNFI OMOENIOMFND, DLGGNNMFNFI LIMKIIDHDPP)
		{
			return default(DLGGNNMFNFI);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C14580", Offset = "0x7C13780", VA = "0x187C14580")]
		public static DLGGNNMFNFI MaxUpdateLod(DLGGNNMFNFI OMOENIOMFND, DLGGNNMFNFI LIMKIIDHDPP)
		{
			return default(DLGGNNMFNFI);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7C14F90", Offset = "0x7C14190", VA = "0x187C14F90")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA2DEE0", Offset = "0xA2D0E0", VA = "0x180A2DEE0", Slot = "11")]
		private bool DEFMALGKJBC()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AFMLFLCLKLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool ILFFOIBFLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera DAENMIOHLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EPHHEFDKGKL NFBMDAAGNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PCMEMNIAICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	EPHHEFDKGKL JHCMNACPLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform KJPIDGBAMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JPIDDDBCPEO
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHOMNBOIMGH(DNCJIBHBDAC KFMNDOMPAMC, float DKGEGBLOEHH, CMFBMPLFPMI DLKPCJPPMBG = CMFBMPLFPMI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKCJOLGDFLO(DNCJIBHBDAC CEFFOBKGKDI);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LGELDOEBBCJ(DNCJIBHBDAC KFMNDOMPAMC, CMFBMPLFPMI OFLBNCDLMMN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NNMEHOKDECM<T> : JPIDDDBCPEO where T : class, DNCJIBHBDAC
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHOMNBOIMGH(T KFMNDOMPAMC, float DKGEGBLOEHH, CMFBMPLFPMI DLKPCJPPMBG = CMFBMPLFPMI.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHOMNBOIMGH(T KFMNDOMPAMC, Transform EHDGFJNIKGE, float DKGEGBLOEHH, CMFBMPLFPMI DLKPCJPPMBG = CMFBMPLFPMI.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PKCJOLGDFLO(T CEFFOBKGKDI);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ABBEBNEAAAL(T KFMNDOMPAMC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DNCJIBHBDAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform JGOMLHGOKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(DLGGNNMFNFI JNHOBJPEMBA, DLGGNNMFNFI CMNOOBANDID);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool PEMMPDNFBBF);
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
