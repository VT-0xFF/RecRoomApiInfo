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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, LGBHPLMPINJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class IMCEIGFCFHC : IDisposable, PLJKPBCOMIN
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int MHFJDLDBPOF
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int DMJGHMLLCGG
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
			public abstract void LHGEFFCPGCJ(bool BELIFHMFHDO);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
			protected IMCEIGFCFHC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class AJLCJJJDCMA<T> : IMCEIGFCFHC, global::BCOODAIFBML<T>, PLJKPBCOMIN where T : ADPNNBJGAGB
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum PLIHOJKFAKB : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class BIIAOINNKOL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T BKHGLCCKFCB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public IPBNBEDCLEO BPLKBAKLFFI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action PNEEFMJEFFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool PNBPIHHCPOC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int AGIDOAOJPID;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
				public BIIAOINNKOL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class DCPOGIMJBHJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public AJLCJJJDCMA<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public BIIAOINNKOL trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
				public DCPOGIMJBHJ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int HFFHAMGLAEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int OJJCHLBPMEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int CMPIFOPNAJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool BJOLDLCEHDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup IMAKIKABFJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] OELPNOFBMND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] ANMDJEMGBPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly EPDNLIPCBIG FJHGBCNEILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> HOAILNLKACA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, BIIAOINNKOL> NGCGCJBMKJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly PLIHOJKFAKB PGOMFIHJHGD;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int MHFJDLDBPOF
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x570F90", Offset = "0x570190", VA = "0x180570F90", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int DMJGHMLLCGG
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x5FD680", Offset = "0x5FC880", VA = "0x1805FD680", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x17B65E0", Offset = "0x17B57E0", VA = "0x1817B65E0")]
			internal AJLCJJJDCMA(int OJJCHLBPMEG, float[] NCKHFBIPEKL, PLIHOJKFAKB PGOMFIHJHGD = PLIHOJKFAKB.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x17B5DA0", Offset = "0x17B4FA0", VA = "0x1817B5DA0", Slot = "10")]
			public override void LHGEFFCPGCJ(bool BELIFHMFHDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x17B5BF0", Offset = "0x17B4DF0", VA = "0x1817B5BF0", Slot = "11")]
			public CBCGNJEHDIB JNHGPMNOIJK(float IBIELCEMDFH)
			{
				return default(CBCGNJEHDIB);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x17B56D0", Offset = "0x17B48D0", VA = "0x1817B56D0", Slot = "12")]
			public void INLOBDHPAIC(T CEEAMODAEEL, float IFBMFNFMKOO, IPBNBEDCLEO OJFIGFGICNN = IPBNBEDCLEO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x17B5770", Offset = "0x17B4970", VA = "0x1817B5770", Slot = "13")]
			public void INLOBDHPAIC(T CEEAMODAEEL, Transform JHONCFKDBAH, float IFBMFNFMKOO, IPBNBEDCLEO OJFIGFGICNN = IPBNBEDCLEO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x17B6560", Offset = "0x17B5760", VA = "0x1817B6560", Slot = "14")]
			public void PCMMCIKCGKL(T CEEAMODAEEL, [Optional] float? IFBMFNFMKOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x17B6050", Offset = "0x17B5250", VA = "0x1817B6050")]
			private void MMPDKMOACLA(int PPMIPKENDBN, [Optional] float? IFBMFNFMKOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x17B61C0", Offset = "0x17B53C0", VA = "0x1817B61C0", Slot = "15")]
			public void MNIDDOJOCKH(T LNGCJIBNFCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x17B4860", Offset = "0x17B3A60", VA = "0x1817B4860", Slot = "16")]
			public CBCGNJEHDIB APKDLACJNLD(T CEEAMODAEEL)
			{
				return default(CBCGNJEHDIB);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x17B49F0", Offset = "0x17B3BF0", VA = "0x1817B49F0", Slot = "17")]
			public bool DDMLEKMBKFB(T CEEAMODAEEL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x17B5C90", Offset = "0x17B4E90", VA = "0x1817B5C90", Slot = "18")]
			public void LHFEGIMHANP(T CEEAMODAEEL, IPBNBEDCLEO GJHFKEGHOFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x17B4AF0", Offset = "0x17B3CF0", VA = "0x1817B4AF0", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x17B5050", Offset = "0x17B4250", VA = "0x1817B5050")]
			private void FGIHFIIAHJM(BIIAOINNKOL NODJDKLOKEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x17B5DD0", Offset = "0x17B4FD0", VA = "0x1817B5DD0")]
			private void LINLLMCBOMO(BIIAOINNKOL NODJDKLOKEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x17B4980", Offset = "0x17B3B80", VA = "0x1817B4980")]
			private void CHAEDIKMFJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x17B4FE0", Offset = "0x17B41E0", VA = "0x1817B4FE0")]
			private void FDANOBPBHCC(float DNCPDHGOELF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x17B5C50", Offset = "0x17B4E50", VA = "0x1817B5C50")]
			private void KJMMDFLMFEK(BIIAOINNKOL NODJDKLOKEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x17B56B0", Offset = "0x17B48B0", VA = "0x1817B56B0")]
			private void GCKKDAOADHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x17B4830", Offset = "0x17B3A30", VA = "0x1817B4830")]
			private void AMAJBMDGKNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x17B5400", Offset = "0x17B4600", VA = "0x1817B5400")]
			private void FIBOBHDHHBA(CullingGroupEvent AOOKBKEIKKB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x17B4E70", Offset = "0x17B4070", VA = "0x1817B4E70")]
			private void EBFFBELOILN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct ONOIKFNIDCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort KCNAMNBNOLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type MJPDHFNBDPN;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float NPDDJHNJHLN = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float OMFFOJIOAAN = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float MLIGDMCEOHC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float FPMOCNOOPMJ = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float MFGFOLDIKGO = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float OHCAAFBBJHM = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float LCCOHCOIKOJ = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<ONOIKFNIDCO, IMCEIGFCFHC> EPFHCBBNIPB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable PMCHHMGKBLE;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable DBFHIBMOEMN;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static AIBLIBIGGML AALIIILGOFJ;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static AIBLIBIGGML MCBJMJANJMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly AIBLIBIGGML MIJIBIDBFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly AIBLIBIGGML OPAGDDGMLAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly AIBLIBIGGML CLEIFLBCCLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IIPPEJEOHNP GEKJOBLJNNM;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool BELIFHMFHDO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AIBLIBIGGML FIGOPAAALEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public AIBLIBIGGML FLFEPGIDENA
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x574070", VA = "0x180574E70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public AIBLIBIGGML PPMNCOGPIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5749E0", Offset = "0x573BE0", VA = "0x1805749E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CLJEODNPKKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1084130", Offset = "0x1083330", VA = "0x181084130", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NIOPPFEMMBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x62BE80", Offset = "0x62B080", VA = "0x18062BE80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x62BF00", Offset = "0x62B100", VA = "0x18062BF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4FD85C0", Offset = "0x4FD77C0", VA = "0x184FD85C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x936CA0", Offset = "0x935EA0", VA = "0x180936CA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4FD8D20", Offset = "0x4FD7F20", VA = "0x184FD8D20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4FD87C0", Offset = "0x4FD79C0", VA = "0x184FD87C0")]
		private void BNMIABLEFPI(Scene OCGCBAEOKLF, LoadSceneMode GNPBHEELLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4FD8C70", Offset = "0x4FD7E70", VA = "0x184FD8C70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4FD8820", Offset = "0x4FD7A20", VA = "0x184FD8820")]
		private void CHJMKFADMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4FD8D40", Offset = "0x4FD7F40", VA = "0x184FD8D40")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4FD8660", Offset = "0x4FD7860", VA = "0x184FD8660")]
		private void BEBGMLEEFAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x21B3680", Offset = "0x21B2880", VA = "0x1821B3680")]
		public global::BCOODAIFBML<T> GetOrCreateCullingGroup<T>(int OKMEEKNHBDI, ushort LDFINKHMIJK = 0) where T : ADPNNBJGAGB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x21B3470", Offset = "0x21B2670", VA = "0x1821B3470")]
		private global::BCOODAIFBML<T> EDICLCDFPME<T>(int OKMEEKNHBDI, float[] NCKHFBIPEKL, ushort LDFINKHMIJK = 0) where T : ADPNNBJGAGB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4FD89C0", Offset = "0x4FD7BC0", VA = "0x184FD89C0")]
		public static CBCGNJEHDIB FindClosestDefaultUpdateLod(float LKLPCILJJLI)
		{
			return default(CBCGNJEHDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4FD8C10", Offset = "0x4FD7E10", VA = "0x184FD8C10")]
		public static CBCGNJEHDIB MinUpdateLod(CBCGNJEHDIB DBACGPFPLEG, CBCGNJEHDIB LCLPBOENPNJ)
		{
			return default(CBCGNJEHDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4FD8BB0", Offset = "0x4FD7DB0", VA = "0x184FD8BB0")]
		public static CBCGNJEHDIB MaxUpdateLod(CBCGNJEHDIB DBACGPFPLEG, CBCGNJEHDIB LCLPBOENPNJ)
		{
			return default(CBCGNJEHDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4FD90D0", Offset = "0x4FD82D0", VA = "0x184FD90D0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EPDNLIPCBIG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CEMMPBJIPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera JMPJHCBIGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AIBLIBIGGML HCIGBGCFKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NBKKNIHMCOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	AIBLIBIGGML KOFBOONEEGB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform GIPAPCFOHEH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PLJKPBCOMIN
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int MHFJDLDBPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int DMJGHMLLCGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BCOODAIFBML<T> : PLJKPBCOMIN where T : ADPNNBJGAGB
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBCGNJEHDIB JNHGPMNOIJK(float IBIELCEMDFH);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INLOBDHPAIC(T CEEAMODAEEL, float IFBMFNFMKOO, IPBNBEDCLEO OJFIGFGICNN = IPBNBEDCLEO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void INLOBDHPAIC(T CEEAMODAEEL, Transform JHONCFKDBAH, float IFBMFNFMKOO, IPBNBEDCLEO OJFIGFGICNN = IPBNBEDCLEO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PCMMCIKCGKL(T CEEAMODAEEL, [Optional] float? IFBMFNFMKOO);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MNIDDOJOCKH(T LNGCJIBNFCC);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CBCGNJEHDIB APKDLACJNLD(T CEEAMODAEEL);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DDMLEKMBKFB(T CEEAMODAEEL);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LHFEGIMHANP(T CEEAMODAEEL, IPBNBEDCLEO CBNHHDJLGPA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ADPNNBJGAGB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform BKKCPMLGDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(CBCGNJEHDIB PGONAOGAJGP, CBCGNJEHDIB ONBDGGKHIJH);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool PJPFDBEPFCH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum IPBNBEDCLEO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum CBCGNJEHDIB
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
public class KIOBPDMOCGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private CBCGNJEHDIB JICFKFFBMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private CBCGNJEHDIB KDCMKKCANAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, CBCGNJEHDIB> NBDGPLFOMEB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool CLDDECKOCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4FD9820", Offset = "0x4FD8A20", VA = "0x184FD9820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public CBCGNJEHDIB BJLCCAOKDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x570F90", Offset = "0x570190", VA = "0x180570F90")]
		get
		{
			return default(CBCGNJEHDIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public CBCGNJEHDIB CKDOJKLIPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5FD680", Offset = "0x5FC880", VA = "0x1805FD680")]
		get
		{
			return default(CBCGNJEHDIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4FD97B0", Offset = "0x4FD89B0", VA = "0x184FD97B0")]
	public bool NKBPPDODNBD(object OFCAAIDMNPE, CBCGNJEHDIB PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4FD99E0", Offset = "0x4FD8BE0", VA = "0x184FD99E0")]
	public bool OPJDMPHKCAN(object OFCAAIDMNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4FD9870", Offset = "0x4FD8A70", VA = "0x184FD9870")]
	private bool OIAELIAGBOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4FD9A40", Offset = "0x4FD8C40", VA = "0x184FD9A40")]
	public KIOBPDMOCGK()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FNGEDJFFIEL
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] JKCEPOEAODE;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int HMIFPHDBAAL;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int JLNLCKONFPG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger EBGIPPCOABB;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FNGEDJFFIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4FD91C0", Offset = "0x4FD83C0", VA = "0x184FD91C0")]
	private static string CHCKGNJAKBF(byte[] CJCOEBBKILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4FD92C0", Offset = "0x4FD84C0", VA = "0x184FD92C0")]
	public static string PEFJMDOFNMG(byte[] PKBLLNJJAGK, bool HCHELKBPHNG)
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
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
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
