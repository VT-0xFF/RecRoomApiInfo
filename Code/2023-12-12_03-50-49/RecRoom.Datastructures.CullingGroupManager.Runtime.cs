using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, DJDABJADMBM
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class KOOJOEPLHBL<T> : JDLFKMNBLLE, PJNEDBFKJNO<T>, KDNKFCKOHOL where T : class, EGPBCNGHIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3978B40", Offset = "0x3977340", VA = "0x183978B40")]
			internal KOOJOEPLHBL(int HMGBAFLHHGM, float[] JMKJCPOHMOO, PJGAHLBHLJB AKHDLCOAEAM = PJGAHLBHLJB.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3978B10", Offset = "0x3977310", VA = "0x183978B10", Slot = "10")]
			public void INCGBOEKEGG(T BEKFGDCEJDH, float EHFGJJPBLJP, IMFCFGHBGGD HGKDMLHHMDO = IMFCFGHBGGD.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3978AE0", Offset = "0x39772E0", VA = "0x183978AE0", Slot = "11")]
			public void INCGBOEKEGG(T BEKFGDCEJDH, Transform FCJAJEGAFOM, float EHFGJJPBLJP, IMFCFGHBGGD HGKDMLHHMDO = IMFCFGHBGGD.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3978AC0", Offset = "0x39772C0", VA = "0x183978AC0", Slot = "12")]
			public void FMCALLKJEMI(T NGLJANFODCJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class JDLFKMNBLLE : IDisposable, KDNKFCKOHOL
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum PJGAHLBHLJB : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class GJGABFEPEAH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public EGPBCNGHIJJ CDMLGHFIAIH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public IMFCFGHBGGD GCGFBILPFFD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action OPGPAGCGLFK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool PDBAHJDDIMB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int EGOJHBDPODL;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
				public GJGABFEPEAH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class CNJEEOMACDO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public JDLFKMNBLLE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public GJGABFEPEAH trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
				public CNJEEOMACDO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5DDA700", Offset = "0x5DD8F00", VA = "0x185DDA700")]
				internal void DPLCHIDEGLM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int KLMBBOKNKLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int HMGBAFLHHGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int CHMJMGJFABD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool INDDNGMBDBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup IHFGNENKDDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] GPCBKLGIPGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] GMEFGBJEKLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly LGCJHHKDGGE NFMOFHCEAPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<EGPBCNGHIJJ, int> CGOKMHCGDHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, GJGABFEPEAH> ILDPKHNPEBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly PJGAHLBHLJB AKHDLCOAEAM;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool IFKAEMDNMDK
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x1AC1E80", Offset = "0x1AC0680", VA = "0x181AC1E80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3CEB080", Offset = "0x3CE9880", VA = "0x183CEB080", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD670", Offset = "0x5DDBE70", VA = "0x185DDD670")]
			internal JDLFKMNBLLE(int HMGBAFLHHGM, float[] JMKJCPOHMOO, PJGAHLBHLJB AKHDLCOAEAM = PJGAHLBHLJB.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5DDC6A0", Offset = "0x5DDAEA0", VA = "0x185DDC6A0")]
			public void GEDEABEFOID(bool MLFCCKHAIIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5DDCDE0", Offset = "0x5DDB5E0", VA = "0x185DDCDE0", Slot = "6")]
			public void INCGBOEKEGG(EGPBCNGHIJJ BEKFGDCEJDH, float EHFGJJPBLJP, IMFCFGHBGGD HGKDMLHHMDO = IMFCFGHBGGD.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5DDC9F0", Offset = "0x5DDB1F0", VA = "0x185DDC9F0", Slot = "9")]
			public void INCGBOEKEGG(EGPBCNGHIJJ BEKFGDCEJDH, Transform FCJAJEGAFOM, float EHFGJJPBLJP, IMFCFGHBGGD HGKDMLHHMDO = IMFCFGHBGGD.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD520", Offset = "0x5DDBD20", VA = "0x185DDD520")]
			public void POFFNIIHPEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5DDBAD0", Offset = "0x5DDA2D0", VA = "0x185DDBAD0")]
			private void ANGEJAMMPEB(int EAHCFBMNNCF, [Optional] float? EHFGJJPBLJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5DDBF30", Offset = "0x5DDA730", VA = "0x185DDBF30", Slot = "7")]
			public void FMCALLKJEMI(EGPBCNGHIJJ NGLJANFODCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD110", Offset = "0x5DDB910", VA = "0x185DDD110", Slot = "8")]
			public void NIIKIEIKAGO(EGPBCNGHIJJ BEKFGDCEJDH, IMFCFGHBGGD PAGAGCKNHCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5DDBC70", Offset = "0x5DDA470", VA = "0x185DDBC70", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5DDC310", Offset = "0x5DDAB10", VA = "0x185DDC310")]
			private void GDEAMJOMLKE(GJGABFEPEAH EJKBJPIFCDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5DDCE70", Offset = "0x5DDB670", VA = "0x185DDCE70")]
			private void KNAAHLGFMFC(GJGABFEPEAH EJKBJPIFCDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5DDBC00", Offset = "0x5DDA400", VA = "0x185DDBC00")]
			private void BIANNIHHOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD210", Offset = "0x5DDBA10", VA = "0x185DDD210")]
			private void OHNMGLJDMDN(float GAJHKHCCEMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD270", Offset = "0x5DDBA70", VA = "0x185DDD270")]
			private void OIMHDELAJFM(GJGABFEPEAH EJKBJPIFCDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5DDBC60", Offset = "0x5DDA460", VA = "0x185DDBC60")]
			private void DGMCOEJGBCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD200", Offset = "0x5DDBA00", VA = "0x185DDD200")]
			private void OBKKDJGGGJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5DDC6D0", Offset = "0x5DDAED0", VA = "0x185DDC6D0")]
			private void IIHJGDIMCKA(CullingGroupEvent FHOMNGJBHCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD3B0", Offset = "0x5DDBBB0", VA = "0x185DDD3B0")]
			private void OOBEBHGLHBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct CAMMEPANIOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort JLDHLPCGNHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type NAPKIPAEEAE;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float BADLKIALNHA = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float AIEGPFBPJAM = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float BGNFNOMAELP = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float LLMLPHALGMB = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float FBEBOIEBMNJ = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float EDFCHAMCCIE = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float CPGBLCEFIJK = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<CAMMEPANIOP, JDLFKMNBLLE> DBBMONGDCKE;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable EKCIGHKLDLM;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable NCIFDPOBNEH;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static LJECGABKDKN KHOIHPODOBA;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static LJECGABKDKN DGMGNJCMDGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly LJECGABKDKN GPMNHCMEFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly LJECGABKDKN AJPBCJBCDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LJECGABKDKN FNFIGBJMLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private LKIMHCEDPCI CBGMCALNJBE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool MLFCCKHAIIN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LJECGABKDKN NHNKIDEAALO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LJECGABKDKN DGJHHBJPOEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public LJECGABKDKN BOELEDECCJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7790D0", Offset = "0x7778D0", VA = "0x1807790D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool AKBOIJDHGGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBFB0F0", Offset = "0xBF98F0", VA = "0x180BFB0F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool OOABPHLLLIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7C8D60", Offset = "0x7C7560", VA = "0x1807C8D60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7C8BD0", Offset = "0x7C73D0", VA = "0x1807C8BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA850", Offset = "0x5DD9050", VA = "0x185DDA850", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB300", Offset = "0x5DD9B00", VA = "0x185DDB300")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB2E0", Offset = "0x5DD9AE0", VA = "0x185DDB2E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB190", Offset = "0x5DD9990", VA = "0x185DDB190")]
		private void MDPIBIOEBCJ(Scene PECGJPLCLGD, LoadSceneMode JECPNLKEDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB200", Offset = "0x5DD9A00", VA = "0x185DDB200", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB560", Offset = "0x5DD9D60", VA = "0x185DDB560")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DDAFF0", Offset = "0x5DD97F0", VA = "0x185DDAFF0")]
		private void KJKCIIDKEIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB320", Offset = "0x5DD9B20", VA = "0x185DDB320")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA910", Offset = "0x5DD9110", VA = "0x185DDA910")]
		private void DDCKIMOALJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5DDABF0", Offset = "0x5DD93F0", VA = "0x185DDABF0")]
		public KDNKFCKOHOL GetOrCreateCullingGroup(Type JGLFMLLLLKL, int NBIFCFMBCND, ushort KJJCPNJKMJA = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2354240", Offset = "0x2352A40", VA = "0x182354240")]
		public PJNEDBFKJNO<T> GetOrCreateCullingGroup<T>(int NBIFCFMBCND, ushort KJJCPNJKMJA = 0) where T : class, EGPBCNGHIJJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DDAE10", Offset = "0x5DD9610", VA = "0x185DDAE10")]
		private KDNKFCKOHOL HGDFJAOCPMA(Type JGLFMLLLLKL, int NBIFCFMBCND, float[] JMKJCPOHMOO, ushort KJJCPNJKMJA = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x23542E0", Offset = "0x2352AE0", VA = "0x1823542E0")]
		private PJNEDBFKJNO<T> HGDFJAOCPMA<T>(int NBIFCFMBCND, float[] JMKJCPOHMOO, ushort KJJCPNJKMJA = 0) where T : class, EGPBCNGHIJJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5DDAA90", Offset = "0x5DD9290", VA = "0x185DDAA90")]
		public static CNMEGLEHJFK FindClosestDefaultUpdateLod(float NCBCIFLJPIG)
		{
			return default(CNMEGLEHJFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7A0000", Offset = "0x79E800", VA = "0x1807A0000")]
		public static CNMEGLEHJFK MinUpdateLod(CNMEGLEHJFK ABJJOOCHODA, CNMEGLEHJFK MGBFOJJHMMD)
		{
			return default(CNMEGLEHJFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB1F0", Offset = "0x5DD99F0", VA = "0x185DDB1F0")]
		public static CNMEGLEHJFK MaxUpdateLod(CNMEGLEHJFK ABJJOOCHODA, CNMEGLEHJFK MGBFOJJHMMD)
		{
			return default(CNMEGLEHJFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB9D0", Offset = "0x5DDA1D0", VA = "0x185DDB9D0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LGCJHHKDGGE
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FILMMJHJKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera MCFKFLKGKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LJECGABKDKN BCOCEEHBLLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool OGJPKFEDFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LJECGABKDKN ALOIOJKNDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform GCKCMMNIKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KDNKFCKOHOL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool IFKAEMDNMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INCGBOEKEGG(EGPBCNGHIJJ BEKFGDCEJDH, float EHFGJJPBLJP, IMFCFGHBGGD HGKDMLHHMDO = IMFCFGHBGGD.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMCALLKJEMI(EGPBCNGHIJJ NGLJANFODCJ);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NIIKIEIKAGO(EGPBCNGHIJJ BEKFGDCEJDH, IMFCFGHBGGD DDIHMFBPDKP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PJNEDBFKJNO<T> : KDNKFCKOHOL where T : class, EGPBCNGHIJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INCGBOEKEGG(T BEKFGDCEJDH, float EHFGJJPBLJP, IMFCFGHBGGD HGKDMLHHMDO = IMFCFGHBGGD.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INCGBOEKEGG(T BEKFGDCEJDH, Transform FCJAJEGAFOM, float EHFGJJPBLJP, IMFCFGHBGGD HGKDMLHHMDO = IMFCFGHBGGD.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMCALLKJEMI(T NGLJANFODCJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EGPBCNGHIJJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform MIODEBPOBDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(CNMEGLEHJFK PHOGCBLPLDJ, CNMEGLEHJFK EPMBKIEBGGH);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool POJIHNGDPFP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum IMFCFGHBGGD : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum CNMEGLEHJFK
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Invalid = -1
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
