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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, MBIAOLNAIOO
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class JGHNLFANHKE<T> : ECMKPFLHMLI, KHNHBKMJJGH<T>, IIHHOFKBIHF where T : class, ILIICCDHOOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x394DF60", Offset = "0x394CD60", VA = "0x18394DF60")]
			internal JGHNLFANHKE(int HAFKOIHFJCP, float[] JGOEKCAMIKE, ABIJHBIHMPF NNNIOCLBDKL = ABIJHBIHMPF.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x394DF30", Offset = "0x394CD30", VA = "0x18394DF30", Slot = "10")]
			public void JHPNFEHLKNP(T KANAGAAAGHJ, float CMBCKFHIOMK, NPEDCJCPBDB BHFANCNODPC = NPEDCJCPBDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x394DF00", Offset = "0x394CD00", VA = "0x18394DF00", Slot = "11")]
			public void JHPNFEHLKNP(T KANAGAAAGHJ, Transform NFCPNIBENBG, float CMBCKFHIOMK, NPEDCJCPBDB BHFANCNODPC = NPEDCJCPBDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x394DEE0", Offset = "0x394CCE0", VA = "0x18394DEE0", Slot = "12")]
			public void BFKGBCINJJC(T APAFGEPKOPJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class ECMKPFLHMLI : IDisposable, IIHHOFKBIHF
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum ABIJHBIHMPF : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class IFKEOKAABNG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public ILIICCDHOOB JHCPJMDHLDD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public NPEDCJCPBDB DIPPHFKMEBK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action DACKNMFDDAL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool GKDJECHPECK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int FNPAHLCJLFK;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
				public IFKEOKAABNG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class BKNEHFIFLMD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public ECMKPFLHMLI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public IFKEOKAABNG trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
				public BKNEHFIFLMD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5DB7210", Offset = "0x5DB6010", VA = "0x185DB7210")]
				internal void BOPICDCPJAL()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int ELIMMODJGGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int HAFKOIHFJCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int MJMIPMMGNCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool AOBNNKEMCKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup PKFODFABGDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] MAEGFLLFPIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] GCINIKLHNNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly LAPADJPJJJD GPBKPNHGBGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<ILIICCDHOOB, int> GMKFDEGEBLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, IFKEOKAABNG> FHPOBJDCDKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly ABIJHBIHMPF NNNIOCLBDKL;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool IIBHEOCJPLM
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x1A7B190", Offset = "0x1A79F90", VA = "0x181A7B190")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3CF75C0", Offset = "0x3CF63C0", VA = "0x183CF75C0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5DBA180", Offset = "0x5DB8F80", VA = "0x185DBA180")]
			internal ECMKPFLHMLI(int HAFKOIHFJCP, float[] JGOEKCAMIKE, ABIJHBIHMPF NNNIOCLBDKL = ABIJHBIHMPF.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5DB85E0", Offset = "0x5DB73E0", VA = "0x185DB85E0")]
			public void BBMKCEEGJGG(bool EJKGNPFBCGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5DB98E0", Offset = "0x5DB86E0", VA = "0x185DB98E0", Slot = "6")]
			public void JHPNFEHLKNP(ILIICCDHOOB KANAGAAAGHJ, float CMBCKFHIOMK, NPEDCJCPBDB BHFANCNODPC = NPEDCJCPBDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5DB94F0", Offset = "0x5DB82F0", VA = "0x185DB94F0", Slot = "9")]
			public void JHPNFEHLKNP(ILIICCDHOOB KANAGAAAGHJ, Transform NFCPNIBENBG, float CMBCKFHIOMK, NPEDCJCPBDB BHFANCNODPC = NPEDCJCPBDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5DB93A0", Offset = "0x5DB81A0", VA = "0x185DB93A0")]
			public void JHHDKIAPDNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5DB90C0", Offset = "0x5DB7EC0", VA = "0x185DB90C0")]
			private void FAEJNDMOKIK(int NGIPPLLBEKC, [Optional] float? CMBCKFHIOMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5DB8610", Offset = "0x5DB7410", VA = "0x185DB8610", Slot = "7")]
			public void BFKGBCINJJC(ILIICCDHOOB APAFGEPKOPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5DBA080", Offset = "0x5DB8E80", VA = "0x185DBA080", Slot = "8")]
			public void NBFNBEHHOND(ILIICCDHOOB KANAGAAAGHJ, NPEDCJCPBDB FHPDJGKPJJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5DB89F0", Offset = "0x5DB77F0", VA = "0x185DB89F0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5DB9970", Offset = "0x5DB8770", VA = "0x185DB9970")]
			private void KHDGEIINENN(IFKEOKAABNG MODKBLLABIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5DB8CB0", Offset = "0x5DB7AB0", VA = "0x185DB8CB0")]
			private void EDNLAJNBGAK(IFKEOKAABNG MODKBLLABIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5DB9340", Offset = "0x5DB8140", VA = "0x185DB9340")]
			private void IMAHHFFJAAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5DB9D00", Offset = "0x5DB8B00", VA = "0x185DB9D00")]
			private void KNMGNIHMEJI(float JCDLMCEAGGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5DB91F0", Offset = "0x5DB7FF0", VA = "0x185DB91F0")]
			private void GFCCHGDEKJN(IFKEOKAABNG MODKBLLABIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5DBA170", Offset = "0x5DB8F70", VA = "0x185DBA170")]
			private void PGNFDBFOJKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5DB9330", Offset = "0x5DB8130", VA = "0x185DB9330")]
			private void IHNIECPPEOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5DB9D60", Offset = "0x5DB8B60", VA = "0x185DB9D60")]
			private void MOJANCNJKHF(CullingGroupEvent LNDIKMHBOOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5DB8F50", Offset = "0x5DB7D50", VA = "0x185DB8F50")]
			private void EJGICOLBABC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct EGNJBIJDMAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort BNGEBJIOCFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type ICEGFCLBLPJ;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float LMKPAKEDHAA = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float BEBOHPEIDKG = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float NFLNDKOLBLF = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float HBPDCEOOLJB = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float KANMEANBCHL = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float EEMNCDADPIO = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float JGJAMKGCJKN = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<EGNJBIJDMAL, ECMKPFLHMLI> NKPKMLLPOJH;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable AFEIGEDEPKN;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable DKJCICFJGBH;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static INNFNKFCEKE GJFMGAGPKNE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static INNFNKFCEKE OBLPDDMLNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly INNFNKFCEKE DPIOENLFEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly INNFNKFCEKE EMJHGPLFBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly INNFNKFCEKE BCILMOAEEPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private BOFKFADGKMI DHHIFJLHNNL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool EJKGNPFBCGJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public INNFNKFCEKE NFOABHHAFDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public INNFNKFCEKE BDEJADLEFHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public INNFNKFCEKE IPCJMMBNMDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x772C10", Offset = "0x771A10", VA = "0x180772C10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KHGDPAKEMEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBDFB30", Offset = "0xBDE930", VA = "0x180BDFB30", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LIOMAIDOJFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7BD4B0", Offset = "0x7BC2B0", VA = "0x1807BD4B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7BD680", Offset = "0x7BC480", VA = "0x1807BD680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7360", Offset = "0x5DB6160", VA = "0x185DB7360", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7E10", Offset = "0x5DB6C10", VA = "0x185DB7E10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7DF0", Offset = "0x5DB6BF0", VA = "0x185DB7DF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7420", Offset = "0x5DB6220", VA = "0x185DB7420")]
		private void CEKHHECKAJL(Scene KKEBFIJFGOA, LoadSceneMode JCEEBKDBNOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7D10", Offset = "0x5DB6B10", VA = "0x185DB7D10", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8070", Offset = "0x5DB6E70", VA = "0x185DB8070")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB77C0", Offset = "0x5DB65C0", VA = "0x185DB77C0")]
		private void GINFJMPFLPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7E30", Offset = "0x5DB6C30", VA = "0x185DB7E30")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7B90", Offset = "0x5DB6990", VA = "0x185DB7B90")]
		private void NGOOHBMDLGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7960", Offset = "0x5DB6760", VA = "0x185DB7960")]
		public IIHHOFKBIHF GetOrCreateCullingGroup(Type PKACHAPNPLC, int ANCGKDBIPMG, ushort AILKPFCCJMP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2350330", Offset = "0x234F130", VA = "0x182350330")]
		public KHNHBKMJJGH<T> GetOrCreateCullingGroup<T>(int ANCGKDBIPMG, ushort AILKPFCCJMP = 0) where T : class, ILIICCDHOOB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DB75E0", Offset = "0x5DB63E0", VA = "0x185DB75E0")]
		private IIHHOFKBIHF GBIGMMBDGEL(Type PKACHAPNPLC, int ANCGKDBIPMG, float[] JGOEKCAMIKE, ushort AILKPFCCJMP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x23500C0", Offset = "0x234EEC0", VA = "0x1823500C0")]
		private KHNHBKMJJGH<T> GBIGMMBDGEL<T>(int ANCGKDBIPMG, float[] JGOEKCAMIKE, ushort AILKPFCCJMP = 0) where T : class, ILIICCDHOOB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7480", Offset = "0x5DB6280", VA = "0x185DB7480")]
		public static MNEBJHJFDEB FindClosestDefaultUpdateLod(float DOBMLIAJDBN)
		{
			return default(MNEBJHJFDEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x79D000", Offset = "0x79BE00", VA = "0x18079D000")]
		public static MNEBJHJFDEB MinUpdateLod(MNEBJHJFDEB ANJDDOILKAP, MNEBJHJFDEB PHKJBCECBPO)
		{
			return default(MNEBJHJFDEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7B80", Offset = "0x5DB6980", VA = "0x185DB7B80")]
		public static MNEBJHJFDEB MaxUpdateLod(MNEBJHJFDEB ANJDDOILKAP, MNEBJHJFDEB PHKJBCECBPO)
		{
			return default(MNEBJHJFDEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DB84E0", Offset = "0x5DB72E0", VA = "0x185DB84E0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LAPADJPJJJD
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FCILALCFADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera PAOFMFKKBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	INNFNKFCEKE HMKNLJLHLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CHDGHMLGHGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	INNFNKFCEKE OFIFONOILMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform IDBCFAOBPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IIHHOFKBIHF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool IIBHEOCJPLM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHPNFEHLKNP(ILIICCDHOOB KANAGAAAGHJ, float CMBCKFHIOMK, NPEDCJCPBDB BHFANCNODPC = NPEDCJCPBDB.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BFKGBCINJJC(ILIICCDHOOB APAFGEPKOPJ);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NBFNBEHHOND(ILIICCDHOOB KANAGAAAGHJ, NPEDCJCPBDB PIOLNHKGACF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KHNHBKMJJGH<T> : IIHHOFKBIHF where T : class, ILIICCDHOOB
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHPNFEHLKNP(T KANAGAAAGHJ, float CMBCKFHIOMK, NPEDCJCPBDB BHFANCNODPC = NPEDCJCPBDB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHPNFEHLKNP(T KANAGAAAGHJ, Transform NFCPNIBENBG, float CMBCKFHIOMK, NPEDCJCPBDB BHFANCNODPC = NPEDCJCPBDB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BFKGBCINJJC(T APAFGEPKOPJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ILIICCDHOOB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform AGLGKAHAKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(MNEBJHJFDEB IAKOAOAPBED, MNEBJHJFDEB CDKBIKKBPNK);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool BACAADICNFH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum NPEDCJCPBDB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MNEBJHJFDEB
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
