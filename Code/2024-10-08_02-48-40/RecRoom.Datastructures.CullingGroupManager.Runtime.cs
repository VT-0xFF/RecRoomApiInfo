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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, FDAOEAPNMNA
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class KJACPKCOKOF<T> : DNKMHHEICBB, KLLJEKBPNDF<T>, PGCEDDPBELO where T : class, ANHAMHJNODK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x44A5820", Offset = "0x44A4A20", VA = "0x1844A5820")]
			internal KJACPKCOKOF(int JILEJPOKCGI, float[] OOMICLOHLPA, MALBAGLPFLC GODPCCFJFJG = MALBAGLPFLC.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x44A57A0", Offset = "0x44A49A0", VA = "0x1844A57A0", Slot = "10")]
			public void JIJNOIKPNBF(T JMJAOKJJFGJ, float DLNPAPKJAEH, KFABMCIICMN OMAJKAMGHID = KFABMCIICMN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x44A57D0", Offset = "0x44A49D0", VA = "0x1844A57D0", Slot = "11")]
			public void JIJNOIKPNBF(T JMJAOKJJFGJ, Transform OMMADNFEPMD, float DLNPAPKJAEH, KFABMCIICMN OMAJKAMGHID = KFABMCIICMN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x44A5800", Offset = "0x44A4A00", VA = "0x1844A5800", Slot = "12")]
			public void LOGGCHCCBFB(T KHDHJBNPPDB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class DNKMHHEICBB : IDisposable, PGCEDDPBELO
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum MALBAGLPFLC : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class BFJIEIEMKDD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public ANHAMHJNODK OGKDBBDOMJO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public KFABMCIICMN FOBAEGENKBD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action FDNJECGGJMB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool CFGLAAEIMCF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int NLHHONDOFEE;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
				public BFJIEIEMKDD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class LBECDGMJGDH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public DNKMHHEICBB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public BFJIEIEMKDD trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
				public LBECDGMJGDH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x6C2F6E0", Offset = "0x6C2E8E0", VA = "0x186C2F6E0")]
				internal void NOPOCMHMEHE()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int FFKJONPHFJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int JILEJPOKCGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int OAEHNBCMBMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool JBMLAGGIALE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup HDIOLJCJKIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] NNFDBMCLMDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] DDJPPDABLAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly CLEGEAMLJCA PAHMCFCAIMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<ANHAMHJNODK, int> KFNJGCECBJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, BFJIEIEMKDD> AKOHDADBKLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly MALBAGLPFLC GODPCCFJFJG;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool HCINEJNADKM
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xB32570", Offset = "0xB31770", VA = "0x180B32570")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x4807940", Offset = "0x4806B40", VA = "0x184807940", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6C2F2D0", Offset = "0x6C2E4D0", VA = "0x186C2F2D0")]
			internal DNKMHHEICBB(int JILEJPOKCGI, float[] OOMICLOHLPA, MALBAGLPFLC GODPCCFJFJG = MALBAGLPFLC.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6C2F1E0", Offset = "0x6C2E3E0", VA = "0x186C2F1E0")]
			public void PFGHJKCLONL(bool JNEGBLMCNNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6C2E3E0", Offset = "0x6C2D5E0", VA = "0x186C2E3E0", Slot = "6")]
			public void JIJNOIKPNBF(ANHAMHJNODK JMJAOKJJFGJ, float DLNPAPKJAEH, KFABMCIICMN OMAJKAMGHID = KFABMCIICMN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6C2DFF0", Offset = "0x6C2D1F0", VA = "0x186C2DFF0", Slot = "9")]
			public void JIJNOIKPNBF(ANHAMHJNODK JMJAOKJJFGJ, Transform OMMADNFEPMD, float DLNPAPKJAEH, KFABMCIICMN OMAJKAMGHID = KFABMCIICMN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6C2F090", Offset = "0x6C2E290", VA = "0x186C2F090")]
			public void PCGBENKMBOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6C2E900", Offset = "0x6C2DB00", VA = "0x186C2E900")]
			private void LBIJCHGEMJK(int KINMHNEMPOD, [Optional] float? DLNPAPKJAEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6C2EA30", Offset = "0x6C2DC30", VA = "0x186C2EA30", Slot = "7")]
			public void LOGGCHCCBFB(ANHAMHJNODK KHDHJBNPPDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6C2DAF0", Offset = "0x6C2CCF0", VA = "0x186C2DAF0", Slot = "8")]
			public void BIBPILMKMBB(ANHAMHJNODK JMJAOKJJFGJ, KFABMCIICMN DKPMNHCLHOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6C2DBE0", Offset = "0x6C2CDE0", VA = "0x186C2DBE0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6C2D790", Offset = "0x6C2C990", VA = "0x186C2D790")]
			private void AGGLAAFIMIA(BFJIEIEMKDD DCNKNLLIFJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6C2EE20", Offset = "0x6C2E020", VA = "0x186C2EE20")]
			private void PBILKODFLIG(BFJIEIEMKDD DCNKNLLIFJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6C2F210", Offset = "0x6C2E410", VA = "0x186C2F210")]
			private void PKKGMFNKHGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6C2F270", Offset = "0x6C2E470", VA = "0x186C2F270")]
			private void PNDDIDLPFHP(float GCFLAEHGPCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6C2DEB0", Offset = "0x6C2D0B0", VA = "0x186C2DEB0")]
			private void JGBCKGDKMBO(BFJIEIEMKDD DCNKNLLIFJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6C2EE10", Offset = "0x6C2E010", VA = "0x186C2EE10")]
			private void PAHAEIKBCAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6C2DEA0", Offset = "0x6C2D0A0", VA = "0x186C2DEA0")]
			private void IPGBODGNOJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6C2E5E0", Offset = "0x6C2D7E0", VA = "0x186C2E5E0")]
			private void JODBHNJFOEK(CullingGroupEvent DLGOCCDAFHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6C2E470", Offset = "0x6C2D670", VA = "0x186C2E470")]
			private void JNBGHOOGNFG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct EKHIPOIJMBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort CJPJFDJHJGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type KPAILKPBMHJ;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float GPONFNLEIFA = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float LBMEJLIKDJH = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float GBJPIHBALOI = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float FABECBIOPDB = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float NHFDJOGJEEP = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float FOOGIKIGKIN = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float OALGLAEJKOD = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<EKHIPOIJMBI, DNKMHHEICBB> PGAKPIFOCDO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable DLOJCDLHEEM;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable HNOCIEECFJN;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static OAACCCGABIO AOHOMAGMDMD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static OAACCCGABIO ELHPFKAOGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly OAACCCGABIO DKHLJLFDADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly OAACCCGABIO OIFMEFCKHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OAACCCGABIO PJIMCNFEDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GMLIOGMHHKE HBAKIOHDNBF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool JNEGBLMCNNC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public OAACCCGABIO JIMMPLGKEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OAACCCGABIO JOPEPMIBJCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public OAACCCGABIO CGAIIGILGNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool GAOLDGFKNMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9197D0", Offset = "0x9189D0", VA = "0x1809197D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool MLEACFKHBFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xC93170", Offset = "0xC92370", VA = "0x180C93170", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD92370", Offset = "0xD91570", VA = "0x180D92370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C2C550", Offset = "0x6C2B750", VA = "0x186C2C550", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C2CFF0", Offset = "0x6C2C1F0", VA = "0x186C2CFF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6C2CFD0", Offset = "0x6C2C1D0", VA = "0x186C2CFD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C2CE80", Offset = "0x6C2C080", VA = "0x186C2CE80")]
		private void LPOFOMDCFLK(Scene HKCJCHLCDOF, LoadSceneMode MEOGGEENDMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2CEF0", Offset = "0x6C2C0F0", VA = "0x186C2CEF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D240", Offset = "0x6C2C440", VA = "0x186C2D240")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2C610", Offset = "0x6C2B810", VA = "0x186C2C610")]
		private void CJKECFCGBHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D010", Offset = "0x6C2C210", VA = "0x186C2D010")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2CD10", Offset = "0x6C2BF10", VA = "0x186C2CD10")]
		private void KDAFFHCCCDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C2CAF0", Offset = "0x6C2BCF0", VA = "0x186C2CAF0")]
		public PGCEDDPBELO GetOrCreateCullingGroup(Type BEMOGKKBOMN, int PPJJNHCOOHC, ushort FMMPBBENODA = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2C5F890", Offset = "0x2C5EA90", VA = "0x182C5F890")]
		public KLLJEKBPNDF<T> GetOrCreateCullingGroup<T>(int PPJJNHCOOHC, ushort FMMPBBENODA = 0) where T : class, ANHAMHJNODK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C2C7B0", Offset = "0x6C2B9B0", VA = "0x186C2C7B0")]
		private PGCEDDPBELO EBJDGOECMMA(Type BEMOGKKBOMN, int PPJJNHCOOHC, float[] OOMICLOHLPA, ushort FMMPBBENODA = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2C5F600", Offset = "0x2C5E800", VA = "0x182C5F600")]
		private KLLJEKBPNDF<T> EBJDGOECMMA<T>(int PPJJNHCOOHC, float[] OOMICLOHLPA, ushort FMMPBBENODA = 0) where T : class, ANHAMHJNODK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C2C990", Offset = "0x6C2BB90", VA = "0x186C2C990")]
		public static KOEAFBADJNF FindClosestDefaultUpdateLod(float ENLDLLJJIHC)
		{
			return default(KOEAFBADJNF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8C31C0", Offset = "0x8C23C0", VA = "0x1808C31C0")]
		public static KOEAFBADJNF MinUpdateLod(KOEAFBADJNF KDJEFMDFDDG, KOEAFBADJNF FEACIBBNIII)
		{
			return default(KOEAFBADJNF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C2CEE0", Offset = "0x6C2C0E0", VA = "0x186C2CEE0")]
		public static KOEAFBADJNF MaxUpdateLod(KOEAFBADJNF KDJEFMDFDDG, KOEAFBADJNF FEACIBBNIII)
		{
			return default(KOEAFBADJNF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D690", Offset = "0x6C2C890", VA = "0x186C2D690")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CLEGEAMLJCA
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FBBGPKDMMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera NPOJFBCNALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	OAACCCGABIO NFEPPDJPKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LNMJJMOLNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OAACCCGABIO ANOIJCMAHGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform LAOKKOJJMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PGCEDDPBELO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool HCINEJNADKM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIJNOIKPNBF(ANHAMHJNODK JMJAOKJJFGJ, float DLNPAPKJAEH, KFABMCIICMN OMAJKAMGHID = KFABMCIICMN.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOGGCHCCBFB(ANHAMHJNODK KHDHJBNPPDB);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BIBPILMKMBB(ANHAMHJNODK JMJAOKJJFGJ, KFABMCIICMN PHKFLFHMBKK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KLLJEKBPNDF<T> : PGCEDDPBELO where T : class, ANHAMHJNODK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIJNOIKPNBF(T JMJAOKJJFGJ, float DLNPAPKJAEH, KFABMCIICMN OMAJKAMGHID = KFABMCIICMN.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIJNOIKPNBF(T JMJAOKJJFGJ, Transform OMMADNFEPMD, float DLNPAPKJAEH, KFABMCIICMN OMAJKAMGHID = KFABMCIICMN.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOGGCHCCBFB(T KHDHJBNPPDB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ANHAMHJNODK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform PKBNMONECNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(KOEAFBADJNF KOFGFGGCFFA, KOEAFBADJNF KHEIGACICLJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool JAENBFHFAKF);
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
