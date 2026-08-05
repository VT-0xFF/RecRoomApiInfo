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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, EFPOEJEGKBK
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class HFKGGDBHCKF<T> : GHDGCIBKDPH, JEDJDEBCGIE<T>, MDBMGIHPLDP where T : class, BOOAFKKBFKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3533580", Offset = "0x3531D80", VA = "0x183533580")]
			internal HFKGGDBHCKF(int EKJKPLFCODL, float[] JGJDEBJDMDC, LONMHGEJNMK BBPOBJGENEM = LONMHGEJNMK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3533500", Offset = "0x3531D00", VA = "0x183533500", Slot = "10")]
			public void EIGFNHEIDIC(T ELOCHLKHPBP, float KPOEIGEKNFE, KLLOFFMIICJ MPKKHIFLCPE = KLLOFFMIICJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3533530", Offset = "0x3531D30", VA = "0x183533530", Slot = "11")]
			public void EIGFNHEIDIC(T ELOCHLKHPBP, Transform KKKFHKHIBLD, float KPOEIGEKNFE, KLLOFFMIICJ MPKKHIFLCPE = KLLOFFMIICJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3533560", Offset = "0x3531D60", VA = "0x183533560", Slot = "12")]
			public void OICBJJIPNIH(T KDPGKIIPJPM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class GHDGCIBKDPH : IDisposable, MDBMGIHPLDP
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum LONMHGEJNMK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class FEDKEOOFPDO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public BOOAFKKBFKL HAMOKPMJNAN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public KLLOFFMIICJ NEILHCNMODK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action HANGMECONGE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool JPEFJLANEJK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int DIEGBKIOLGK;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
				public FEDKEOOFPDO()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class JLBGLLAHHAK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public GHDGCIBKDPH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public FEDKEOOFPDO trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
				public JLBGLLAHHAK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5C705A0", Offset = "0x5C6EDA0", VA = "0x185C705A0")]
				internal void DHLMBOOEHBP()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int LBNPGKBGLGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int EKJKPLFCODL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int OACGDGBGKMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool PMNGKOBCMDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup FJJKGLPDHLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] MINPHGOFOLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] EGKMPEOBCAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly BLJIMEOEGNM PEPBPPBDPDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<BOOAFKKBFKL, int> CCGPIHFJBKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, FEDKEOOFPDO> DCCOAPFEDCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly LONMHGEJNMK BBPOBJGENEM;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool PDPGJLKKMBJ
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x3C85DF0", Offset = "0x3C845F0", VA = "0x183C85DF0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3C85DD0", Offset = "0x3C845D0", VA = "0x183C85DD0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5C701B0", Offset = "0x5C6E9B0", VA = "0x185C701B0")]
			internal GHDGCIBKDPH(int EKJKPLFCODL, float[] JGJDEBJDMDC, LONMHGEJNMK BBPOBJGENEM = LONMHGEJNMK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5C70030", Offset = "0x5C6E830", VA = "0x185C70030")]
			public void PBIGPDHKEDH(bool BDKPNCADKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5C6EF30", Offset = "0x5C6D730", VA = "0x185C6EF30", Slot = "6")]
			public void EIGFNHEIDIC(BOOAFKKBFKL ELOCHLKHPBP, float KPOEIGEKNFE, KLLOFFMIICJ MPKKHIFLCPE = KLLOFFMIICJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5C6EB40", Offset = "0x5C6D340", VA = "0x185C6EB40", Slot = "9")]
			public void EIGFNHEIDIC(BOOAFKKBFKL ELOCHLKHPBP, Transform KKKFHKHIBLD, float KPOEIGEKNFE, KLLOFFMIICJ MPKKHIFLCPE = KLLOFFMIICJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5C70060", Offset = "0x5C6E860", VA = "0x185C70060")]
			public void PMNLNDPALMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5C6FAB0", Offset = "0x5C6E2B0", VA = "0x185C6FAB0")]
			private void NAKACCPEBOJ(int ADMJKDLHPCI, [Optional] float? KPOEIGEKNFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5C6FBF0", Offset = "0x5C6E3F0", VA = "0x185C6FBF0", Slot = "7")]
			public void OICBJJIPNIH(BOOAFKKBFKL KDPGKIIPJPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5C6E610", Offset = "0x5C6CE10", VA = "0x185C6E610", Slot = "8")]
			public void BALKMEHLPEG(BOOAFKKBFKL ELOCHLKHPBP, KLLOFFMIICJ FFODBEMHEAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5C6E880", Offset = "0x5C6D080", VA = "0x185C6E880", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5C6F720", Offset = "0x5C6DF20", VA = "0x185C6F720")]
			private void KACOGMABFCB(FEDKEOOFPDO BANJDNFAHEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5C6F020", Offset = "0x5C6D820", VA = "0x185C6F020")]
			private void FIEIKEPPOHE(FEDKEOOFPDO BANJDNFAHEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5C6FFD0", Offset = "0x5C6E7D0", VA = "0x185C6FFD0")]
			private void OMPFAAIHKIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5C6EFC0", Offset = "0x5C6D7C0", VA = "0x185C6EFC0")]
			private void EJFCMIBBJMN(float DBACBIFMKHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5C6F5E0", Offset = "0x5C6DDE0", VA = "0x185C6F5E0")]
			private void HMMBNOANOJB(FEDKEOOFPDO BANJDNFAHEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5C6FBE0", Offset = "0x5C6E3E0", VA = "0x185C6FBE0")]
			private void NMABLBIBKGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5C6E870", Offset = "0x5C6D070", VA = "0x185C6E870")]
			private void DKGANNHGGAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5C6F2C0", Offset = "0x5C6DAC0", VA = "0x185C6F2C0")]
			private void GGKHMCEGJEK(CullingGroupEvent JDCIECGCCAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5C6E700", Offset = "0x5C6CF00", VA = "0x185C6E700")]
			private void DGEDEPGLGFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct INGFEBFINBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort BLOPEGBKHOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type AEGNPHOMPGI;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float IGBDMKKGLHC = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float MGGLFBOMKHI = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float PDBKIFKIPNB = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float BHMCMMOECEL = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float CMALAGPDNOM = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float OBFMOILKCAN = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float EILGPBMOGEJ = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<INGFEBFINBB, GHDGCIBKDPH> OMDJOKNLDNF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable JMCGOBJFJDD;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable GEDEHMCDPEG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static CAPEMHJDAJL NEFFINFJDGK;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static CAPEMHJDAJL EODPMKEDADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CAPEMHJDAJL KIEICICONLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly CAPEMHJDAJL FBAICNIOIPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly CAPEMHJDAJL CNNCFGMNONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CEKHBJPKCPE KMCNHIFJFEL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool BDKPNCADKBE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CAPEMHJDAJL ADNKEBNLDMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public CAPEMHJDAJL AABOPHLIOKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CAPEMHJDAJL JCJENJICLGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x762AE0", Offset = "0x7612E0", VA = "0x180762AE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MGKCHKIDAJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBC6C50", Offset = "0xBC5450", VA = "0x180BC6C50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NNNGHBDDMPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B6CB0", Offset = "0x7B54B0", VA = "0x1807B6CB0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7B6890", Offset = "0x7B5090", VA = "0x1807B6890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5C6D390", Offset = "0x5C6BB90", VA = "0x185C6D390", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C6DE40", Offset = "0x5C6C640", VA = "0x185C6DE40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5C6DE20", Offset = "0x5C6C620", VA = "0x185C6DE20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5C6DCD0", Offset = "0x5C6C4D0", VA = "0x185C6DCD0")]
		private void LIEIGACJLOP(Scene NJBFIEAFGFF, LoadSceneMode CHDCFCNHAFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C6DD40", Offset = "0x5C6C540", VA = "0x185C6DD40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C6E0A0", Offset = "0x5C6C8A0", VA = "0x185C6E0A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C6D450", Offset = "0x5C6BC50", VA = "0x185C6D450")]
		private void EOHNLJGELBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5C6DE60", Offset = "0x5C6C660", VA = "0x185C6DE60")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C6D5F0", Offset = "0x5C6BDF0", VA = "0x185C6D5F0")]
		private void FIEANOLFHCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5C6D8D0", Offset = "0x5C6C0D0", VA = "0x185C6D8D0")]
		public MDBMGIHPLDP GetOrCreateCullingGroup(Type INAKFIDLELN, int EBKPDPBKMMM, ushort FPMLFMNLAKP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2227440", Offset = "0x2225C40", VA = "0x182227440")]
		public JEDJDEBCGIE<T> GetOrCreateCullingGroup<T>(int EBKPDPBKMMM, ushort FPMLFMNLAKP = 0) where T : class, BOOAFKKBFKL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5C6DAF0", Offset = "0x5C6C2F0", VA = "0x185C6DAF0")]
		private MDBMGIHPLDP KEFPJCCBAEK(Type INAKFIDLELN, int EBKPDPBKMMM, float[] JGJDEBJDMDC, ushort FPMLFMNLAKP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x22274E0", Offset = "0x2225CE0", VA = "0x1822274E0")]
		private JEDJDEBCGIE<T> KEFPJCCBAEK<T>(int EBKPDPBKMMM, float[] JGJDEBJDMDC, ushort FPMLFMNLAKP = 0) where T : class, BOOAFKKBFKL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5C6D770", Offset = "0x5C6BF70", VA = "0x185C6D770")]
		public static AKBICHGFHAJ FindClosestDefaultUpdateLod(float PHKIABMPBCK)
		{
			return default(AKBICHGFHAJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x78EFF0", Offset = "0x78D7F0", VA = "0x18078EFF0")]
		public static AKBICHGFHAJ MinUpdateLod(AKBICHGFHAJ LBLEEKMKHJH, AKBICHGFHAJ LKANKIACJPF)
		{
			return default(AKBICHGFHAJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5C6DD30", Offset = "0x5C6C530", VA = "0x185C6DD30")]
		public static AKBICHGFHAJ MaxUpdateLod(AKBICHGFHAJ LBLEEKMKHJH, AKBICHGFHAJ LKANKIACJPF)
		{
			return default(AKBICHGFHAJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5C6E510", Offset = "0x5C6CD10", VA = "0x185C6E510")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BLJIMEOEGNM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool PBLOINHBIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera BKJCIFDCBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	CAPEMHJDAJL JPPKMOBOMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IGJPJEEFKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	CAPEMHJDAJL DOLBKIMLJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform CHNFFPNKFED
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MDBMGIHPLDP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool PDPGJLKKMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIGFNHEIDIC(BOOAFKKBFKL ELOCHLKHPBP, float KPOEIGEKNFE, KLLOFFMIICJ MPKKHIFLCPE = KLLOFFMIICJ.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OICBJJIPNIH(BOOAFKKBFKL KDPGKIIPJPM);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BALKMEHLPEG(BOOAFKKBFKL ELOCHLKHPBP, KLLOFFMIICJ OJEEKJBHKKH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JEDJDEBCGIE<T> : MDBMGIHPLDP where T : class, BOOAFKKBFKL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIGFNHEIDIC(T ELOCHLKHPBP, float KPOEIGEKNFE, KLLOFFMIICJ MPKKHIFLCPE = KLLOFFMIICJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIGFNHEIDIC(T ELOCHLKHPBP, Transform KKKFHKHIBLD, float KPOEIGEKNFE, KLLOFFMIICJ MPKKHIFLCPE = KLLOFFMIICJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OICBJJIPNIH(T KDPGKIIPJPM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BOOAFKKBFKL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform KHFCFAPNPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(AKBICHGFHAJ CAKBDEGHLHG, AKBICHGFHAJ EKIOMDGDLDO);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool OLPCKAGOJCG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum KLLOFFMIICJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum AKBICHGFHAJ
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
