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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, ABLOOAILLEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class GKMJPKFGLBK : IDisposable, KAOPNLEHJPG
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int GDPKLPHNEGA
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(Slot = "9")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int IDHLCCDALBJ
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void Dispose();

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void GPNLHPDGJFE();

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void DCHBJLDIOJL(bool DIJGFPFOLJP);

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			protected GKMJPKFGLBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class BJEJPBHCFKP<T> : GKMJPKFGLBK, global::CPCJCJNLKIE<T>, KAOPNLEHJPG where T : HJIGAFLLHLD
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum JACJMECKAKK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class DBHFGFJEEIL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T JPJOKGKJCLO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public BAOGBFKFBPO JONCDMNOOHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action KJEJOJCCEOI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool CJJHFBGLPGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int KBBNJEDOENJ;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
				public DBHFGFJEEIL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class JIKDMPFJGDB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public BJEJPBHCFKP<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public DBHFGFJEEIL trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
				public JIKDMPFJGDB()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int HJPNDICGAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int MMHKDBGOFPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int OGCAGAMFCKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool JBNHMJHHOJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup ADPFBPADLJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] MDGKEEDGFDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] PBNFEFEDDFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly MFBIEAHPFIE BILODKHEIGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> FKBFGBNNJCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, DBHFGFJEEIL> DDPDKAKIHND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly JACJMECKAKK FLNLMOHDLNB;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int GDPKLPHNEGA
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x5E5ED0", Offset = "0x5E4ED0", VA = "0x1805E5ED0", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int IDHLCCDALBJ
			{
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x609710", Offset = "0x608710", VA = "0x180609710", Slot = "10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x30E4B20", Offset = "0x30E3B20", VA = "0x1830E4B20")]
			internal BJEJPBHCFKP(int MMHKDBGOFPI, float[] GCBOILBJAJC, JACJMECKAKK FLNLMOHDLNB = JACJMECKAKK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x30E2EB0", Offset = "0x30E1EB0", VA = "0x1830E2EB0", Slot = "11")]
			public override void DCHBJLDIOJL(bool DIJGFPFOLJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x30E4160", Offset = "0x30E3160", VA = "0x1830E4160", Slot = "12")]
			public ALKCBINMCPO LKDFOMMGKGK(float POAJALCIBKF)
			{
				return default(ALKCBINMCPO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x30E4600", Offset = "0x30E3600", VA = "0x1830E4600", Slot = "13")]
			public void PPCBFHPPBHE(T MDAEAKFNGDG, float JGMAHEPKPHA, BAOGBFKFBPO BJBPLKCNFGG = BAOGBFKFBPO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x30E46A0", Offset = "0x30E36A0", VA = "0x1830E46A0", Slot = "14")]
			public void PPCBFHPPBHE(T MDAEAKFNGDG, Transform DBELLHGEAED, float JGMAHEPKPHA, BAOGBFKFBPO BJBPLKCNFGG = BAOGBFKFBPO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x30E3FE0", Offset = "0x30E2FE0", VA = "0x1830E3FE0", Slot = "8")]
			public override void GPNLHPDGJFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x30E32C0", Offset = "0x30E22C0", VA = "0x1830E32C0", Slot = "15")]
			public void DLFDLJBKBLE(T MDAEAKFNGDG, [Optional] float? JGMAHEPKPHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x30E2BC0", Offset = "0x30E1BC0", VA = "0x1830E2BC0")]
			private void AGFKMMFLILP(int IIHEDPBOLFE, [Optional] float? JGMAHEPKPHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x30E2F20", Offset = "0x30E1F20", VA = "0x1830E2F20", Slot = "16")]
			public void DKCILJPFPEA(T JIPIMFMHGLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x30E3930", Offset = "0x30E2930", VA = "0x1830E3930", Slot = "17")]
			public ALKCBINMCPO FOMAKNENLKC(T MDAEAKFNGDG)
			{
				return default(ALKCBINMCPO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x30E3830", Offset = "0x30E2830", VA = "0x1830E3830", Slot = "18")]
			public bool FODPPKNECCL(T MDAEAKFNGDG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x30E2D00", Offset = "0x30E1D00", VA = "0x1830E2D00", Slot = "19")]
			public void AMAEAEKPDJG(T MDAEAKFNGDG, BAOGBFKFBPO CFNEJOLGGDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x30E3340", Offset = "0x30E2340", VA = "0x1830E3340", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x30E4230", Offset = "0x30E3230", VA = "0x1830E4230")]
			private void NGPEAKFAOAJ(DBHFGFJEEIL OGBFEIIJADJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x30E3D60", Offset = "0x30E2D60", VA = "0x1830E3D60")]
			private void GPNHCOBFFJL(DBHFGFJEEIL OGBFEIIJADJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x30E2E40", Offset = "0x30E1E40", VA = "0x1830E2E40")]
			private void CIMKCMDPKOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x30E41C0", Offset = "0x30E31C0", VA = "0x1830E41C0")]
			private void MGOBKDKDHMI(float CIHMBOMCHIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x30E2EE0", Offset = "0x30E1EE0", VA = "0x1830E2EE0")]
			private void DFMPNDLNIMG(DBHFGFJEEIL OGBFEIIJADJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x30E45E0", Offset = "0x30E35E0", VA = "0x1830E45E0")]
			private void PGDNMLKNGEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x30E2E10", Offset = "0x30E1E10", VA = "0x1830E2E10")]
			private void BNAHBGJOCBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x30E3A50", Offset = "0x30E2A50", VA = "0x1830E3A50")]
			private void GMJDMFNPPDH(CullingGroupEvent MHDCCDKGILK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x30E36C0", Offset = "0x30E26C0", VA = "0x1830E36C0")]
			private void FBIKFGIECBA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct JAAKEAINDLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort GFIFJMJGPED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type IHACKAAJEKH;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float DNKJLLNPKAF = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float MDMLFEIMIJO = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float GGNFMOBFCEG = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float DNOIMDMJOFI = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float OOPKLBDAKHL = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float GDCGOMFKAIK = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float ALLGIBHKGJN = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<JAAKEAINDLD, GKMJPKFGLBK> LEFCNAJEMKO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable NCGNHKHGPJJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable PPBCFAEMBAJ;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static GNEFPHEGBGJ HDGKKLKGOFA;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static GNEFPHEGBGJ IKODHHBGKEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly GNEFPHEGBGJ HGCDOFMJDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly GNEFPHEGBGJ JPJEOKBPNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly GNEFPHEGBGJ FBJPPDNLKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private JLELHLFHMNH HKPDEEOJLAL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool DIJGFPFOLJP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public GNEFPHEGBGJ EJEJCKMJGMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GNEFPHEGBGJ PBHMDCFOJMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public GNEFPHEGBGJ KEHDAPHCAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool PDGPBCMBGID
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1667530", Offset = "0x1666530", VA = "0x181667530", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FCMPHABLCLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7D6E70", Offset = "0x7D5E70", VA = "0x1807D6E70", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7D6EF0", Offset = "0x7D5EF0", VA = "0x1807D6EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x583B4C0", Offset = "0x583A4C0", VA = "0x18583B4C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xEAE270", Offset = "0xEAD270", VA = "0x180EAE270")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x583BA80", Offset = "0x583AA80", VA = "0x18583BA80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x583B970", Offset = "0x583A970", VA = "0x18583B970")]
		private void NBDIAHCDLAD(Scene EGFKPLNKIAI, LoadSceneMode DJPEOPIHMGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x583B9D0", Offset = "0x583A9D0", VA = "0x18583B9D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x583BD00", Offset = "0x583AD00", VA = "0x18583BD00")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x583B320", Offset = "0x583A320", VA = "0x18583B320")]
		private void APOFKHBGIHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x583BAA0", Offset = "0x583AAA0", VA = "0x18583BAA0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x583B750", Offset = "0x583A750", VA = "0x18583B750")]
		private void GAOBACNDDMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x237E580", Offset = "0x237D580", VA = "0x18237E580")]
		public global::CPCJCJNLKIE<T> GetOrCreateCullingGroup<T>(int EHJLDHNJEAB, ushort FBLLOGPAKDE = 0) where T : HJIGAFLLHLD
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x237E630", Offset = "0x237D630", VA = "0x18237E630")]
		private global::CPCJCJNLKIE<T> LPEDHBBNHGM<T>(int EHJLDHNJEAB, float[] GCBOILBJAJC, ushort FBLLOGPAKDE = 0) where T : HJIGAFLLHLD
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x583B560", Offset = "0x583A560", VA = "0x18583B560")]
		public static ALKCBINMCPO FindClosestDefaultUpdateLod(float BPPCHHAKJNO)
		{
			return default(ALKCBINMCPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x583B910", Offset = "0x583A910", VA = "0x18583B910")]
		public static ALKCBINMCPO MinUpdateLod(ALKCBINMCPO ELALGKPDDJI, ALKCBINMCPO NLMHNLGGLIE)
		{
			return default(ALKCBINMCPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x583B8B0", Offset = "0x583A8B0", VA = "0x18583B8B0")]
		public static ALKCBINMCPO MaxUpdateLod(ALKCBINMCPO ELALGKPDDJI, ALKCBINMCPO NLMHNLGGLIE)
		{
			return default(ALKCBINMCPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x583BF80", Offset = "0x583AF80", VA = "0x18583BF80")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MFBIEAHPFIE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JOEKDLKCFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera BIPHELDLBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GNEFPHEGBGJ OMJDAIEIOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool KPOBNKKDMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GNEFPHEGBGJ DLCFJHMOMFF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform KEECKDPCGNL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KAOPNLEHJPG
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int GDPKLPHNEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int IDHLCCDALBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CPCJCJNLKIE<T> : KAOPNLEHJPG where T : HJIGAFLLHLD
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ALKCBINMCPO LKDFOMMGKGK(float POAJALCIBKF);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPCBFHPPBHE(T MDAEAKFNGDG, float JGMAHEPKPHA, BAOGBFKFBPO BJBPLKCNFGG = BAOGBFKFBPO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PPCBFHPPBHE(T MDAEAKFNGDG, Transform DBELLHGEAED, float JGMAHEPKPHA, BAOGBFKFBPO BJBPLKCNFGG = BAOGBFKFBPO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DLFDLJBKBLE(T MDAEAKFNGDG, [Optional] float? JGMAHEPKPHA);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DKCILJPFPEA(T JIPIMFMHGLG);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ALKCBINMCPO FOMAKNENLKC(T MDAEAKFNGDG);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FODPPKNECCL(T MDAEAKFNGDG);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AMAEAEKPDJG(T MDAEAKFNGDG, BAOGBFKFBPO HBEHFOBFNPL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HJIGAFLLHLD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform BCLIDGMJFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(ALKCBINMCPO MIBBJPMNFLK, ALKCBINMCPO JAAKNEBILDA);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool OHGBMLFDFCI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum BAOGBFKFBPO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum ALKCBINMCPO
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
public class EJNIEJCGJBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private ALKCBINMCPO PPBBNEGBIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private ALKCBINMCPO HGPCJMNKPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, ALKCBINMCPO> GIJNFFPAOPO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool CCEMNEGJHKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x583C730", Offset = "0x583B730", VA = "0x18583C730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ALKCBINMCPO AMKFLGAFLDC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5E5ED0", Offset = "0x5E4ED0", VA = "0x1805E5ED0")]
		get
		{
			return default(ALKCBINMCPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public ALKCBINMCPO BIDEFJMOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x609710", Offset = "0x608710", VA = "0x180609710")]
		get
		{
			return default(ALKCBINMCPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x583C660", Offset = "0x583B660", VA = "0x18583C660")]
	public bool BINADFEEINP(object KGJPBGICHFN, ALKCBINMCPO JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x583C6D0", Offset = "0x583B6D0", VA = "0x18583C6D0")]
	public bool EBFGJLCCCPL(object KGJPBGICHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x583C780", Offset = "0x583B780", VA = "0x18583C780")]
	private bool NNJHGPKLPEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x583C8F0", Offset = "0x583B8F0", VA = "0x18583C8F0")]
	public EJNIEJCGJBD()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class EJDCELNBKPC
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] LJMFDKKPNGA;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int EGAGCALIJCE;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int AMPJBPFCKBN;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger PJENGKNDPGI;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EJDCELNBKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x583C070", Offset = "0x583B070", VA = "0x18583C070")]
	private static string HACCFPOCPGB(byte[] GMPKOOIGMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x583C170", Offset = "0x583B170", VA = "0x18583C170")]
	public static string NOKDDKHJKOE(byte[] FCLFFFPNPCK, bool DHIAJMPKALJ)
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

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
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
