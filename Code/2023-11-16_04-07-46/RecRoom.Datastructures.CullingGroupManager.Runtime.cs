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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, EFMLGEBBGBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class EGGMJIFDEDJ<T> : AOOGPKKGOEO, ECIIEJBLKLC<T>, KKDEOGMNLDN where T : class, NAMDOKCHCKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x30FD2C0", Offset = "0x30FC2C0", VA = "0x1830FD2C0")]
			internal EGGMJIFDEDJ(int ICFGHLEIHCN, float[] DDNCBKLLGGF, IONBMLHIDMF JEFKNEDBGEH = IONBMLHIDMF.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x30FD270", Offset = "0x30FC270", VA = "0x1830FD270", Slot = "10")]
			public void GPDFOMDKBKK(T GPCHHCACPPJ, float PEBOEKHAPLP, NGEMNFJFDIP BDJMBIMNFFC = NGEMNFJFDIP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x30FD240", Offset = "0x30FC240", VA = "0x1830FD240", Slot = "11")]
			public void GPDFOMDKBKK(T GPCHHCACPPJ, Transform LHPJHLKKKIL, float PEBOEKHAPLP, NGEMNFJFDIP BDJMBIMNFFC = NGEMNFJFDIP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x30FD2A0", Offset = "0x30FC2A0", VA = "0x1830FD2A0", Slot = "12")]
			public void MOJJDBCCFOB(T KKIIDHJMKJP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class AOOGPKKGOEO : IDisposable, KKDEOGMNLDN
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum IONBMLHIDMF : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class GECAIFHCGJF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public NAMDOKCHCKG BLDHKNMDLIJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public NGEMNFJFDIP OALNADMKDHM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action CANPAALDPJE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool CMIFNMJCNKP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int KLNGLNIFDLJ;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
				public GECAIFHCGJF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class OGFPFOIOPJL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public AOOGPKKGOEO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public GECAIFHCGJF trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
				public OGFPFOIOPJL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5DC0F50", Offset = "0x5DBFF50", VA = "0x185DC0F50")]
				internal void KILPKCAJIHI()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int OGIDOAKMAJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int ICFGHLEIHCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int ADIBGMBDGNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool EDDFAKMICOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup OJBADPMOFHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] HACKPCBKGMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] KGCFIKLBKFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly OKBHFCKKMHP ICCKKADELMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<NAMDOKCHCKG, int> JBLGKOIEBPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, GECAIFHCGJF> MEFLEMBCBLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly IONBMLHIDMF JEFKNEDBGEH;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool FJAHPKGBODK
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x1A7B390", Offset = "0x1A7A390", VA = "0x181A7B390")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3CF9ED0", Offset = "0x3CF8ED0", VA = "0x183CF9ED0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5DBF8E0", Offset = "0x5DBE8E0", VA = "0x185DBF8E0")]
			internal AOOGPKKGOEO(int ICFGHLEIHCN, float[] DDNCBKLLGGF, IONBMLHIDMF JEFKNEDBGEH = IONBMLHIDMF.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5DBE3B0", Offset = "0x5DBD3B0", VA = "0x185DBE3B0")]
			public void GEABHMAOMGJ(bool HAHCBMKKOPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5DBEA80", Offset = "0x5DBDA80", VA = "0x185DBEA80", Slot = "6")]
			public void GPDFOMDKBKK(NAMDOKCHCKG GPCHHCACPPJ, float PEBOEKHAPLP, NGEMNFJFDIP BDJMBIMNFFC = NGEMNFJFDIP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5DBE690", Offset = "0x5DBD690", VA = "0x185DBE690", Slot = "9")]
			public void GPDFOMDKBKK(NAMDOKCHCKG GPCHHCACPPJ, Transform LHPJHLKKKIL, float PEBOEKHAPLP, NGEMNFJFDIP BDJMBIMNFFC = NGEMNFJFDIP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5DBEF60", Offset = "0x5DBDF60", VA = "0x185DBEF60")]
			public void KOAMFCMFJDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5DBF7B0", Offset = "0x5DBE7B0", VA = "0x185DBF7B0")]
			private void NGMEHGHCOKB(int NFJIPMHILEL, [Optional] float? PEBOEKHAPLP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5DBF3D0", Offset = "0x5DBE3D0", VA = "0x185DBF3D0", Slot = "7")]
			public void MOJJDBCCFOB(NAMDOKCHCKG KKIIDHJMKJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5DBE2C0", Offset = "0x5DBD2C0", VA = "0x185DBE2C0", Slot = "8")]
			public void GDMJJPJHLJO(NAMDOKCHCKG GPCHHCACPPJ, NGEMNFJFDIP HPIAFEKJCNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5DBDEC0", Offset = "0x5DBCEC0", VA = "0x185DBDEC0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5DBEB10", Offset = "0x5DBDB10", VA = "0x185DBEB10")]
			private void HDILCAEHFOK(GECAIFHCGJF IJBNJJGKCHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5DBE3F0", Offset = "0x5DBD3F0", VA = "0x185DBE3F0")]
			private void GGIOKHGEPLB(GECAIFHCGJF IJBNJJGKCHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5DBEEA0", Offset = "0x5DBDEA0", VA = "0x185DBEEA0")]
			private void HIDPPPGGMJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5DBEF00", Offset = "0x5DBDF00", VA = "0x185DBEF00")]
			private void IPJECHCNPMI(float BLKKNAAPMIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5DBE180", Offset = "0x5DBD180", VA = "0x185DBE180")]
			private void GDCKHFDHOJD(GECAIFHCGJF IJBNJJGKCHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5DBDEB0", Offset = "0x5DBCEB0", VA = "0x185DBDEB0")]
			private void CAOMBLPAGNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5DBE3E0", Offset = "0x5DBD3E0", VA = "0x185DBE3E0")]
			private void GEFOHMHCCDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5DBF0B0", Offset = "0x5DBE0B0", VA = "0x185DBF0B0")]
			private void MIHFIDGPOKO(CullingGroupEvent EMFLOMNOLKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5DBDD40", Offset = "0x5DBCD40", VA = "0x185DBDD40")]
			private void AEMLDACNMGK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct NLGEBIPGHFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort AKMOKDGKKMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type JDKGEHNKAIG;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float MOOCEMCADPJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float NNGPHKIMIHJ = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float LAGPPLCKGPF = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float AHJALGCCFJJ = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float JOICKMPBICL = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float INAHDMNNDHE = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float BKPACABLLAI = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<NLGEBIPGHFA, AOOGPKKGOEO> JFFKHHNDOJG;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable BHFJMEFGOGO;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable AOPGJGILFJB;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static DNHICBJBOMM LBDPMDBKBDP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static DNHICBJBOMM MBNKCONDEDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly DNHICBJBOMM IPEGLOJDFHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DNHICBJBOMM AIAKLHAOOII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DNHICBJBOMM KBPPPNICAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GPGMPFEJBGM CDFIOGBIOOO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool HAHCBMKKOPH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DNHICBJBOMM HIFKLKGJFPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public DNHICBJBOMM LADDEHDKPMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DNHICBJBOMM KMMEFDFOGJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x76F1C0", Offset = "0x76E1C0", VA = "0x18076F1C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JLCHMIBMFHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBE0A70", Offset = "0xBDFA70", VA = "0x180BE0A70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IELIEDANBEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7BEB30", Offset = "0x7BDB30", VA = "0x1807BEB30", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7BEB10", Offset = "0x7BDB10", VA = "0x1807BEB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5DBFCD0", Offset = "0x5DBECD0", VA = "0x185DBFCD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0780", Offset = "0x5DBF780", VA = "0x185DC0780")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0760", Offset = "0x5DBF760", VA = "0x185DC0760")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5DBFD90", Offset = "0x5DBED90", VA = "0x185DBFD90")]
		private void BDMAIICOEEE(Scene HFIHMDOKDEI, LoadSceneMode PMFIIBOFEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0680", Offset = "0x5DBF680", VA = "0x185DC0680", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DC09E0", Offset = "0x5DBF9E0", VA = "0x185DC09E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DC04D0", Offset = "0x5DBF4D0", VA = "0x185DC04D0")]
		private void HLICMDLKFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DC07A0", Offset = "0x5DBF7A0", VA = "0x185DC07A0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBFFD0", Offset = "0x5DBEFD0", VA = "0x185DBFFD0")]
		private void EOGOLKLBPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5DC02B0", Offset = "0x5DBF2B0", VA = "0x185DC02B0")]
		public KKDEOGMNLDN GetOrCreateCullingGroup(Type BDEDIMKFDJN, int NJHGCOBLCBJ, ushort JGJLMAAOJBC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x234FBC0", Offset = "0x234EBC0", VA = "0x18234FBC0")]
		public ECIIEJBLKLC<T> GetOrCreateCullingGroup<T>(int NJHGCOBLCBJ, ushort JGJLMAAOJBC = 0) where T : class, NAMDOKCHCKG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DBFDF0", Offset = "0x5DBEDF0", VA = "0x185DBFDF0")]
		private KKDEOGMNLDN DFCOMAEMJBL(Type BDEDIMKFDJN, int NJHGCOBLCBJ, float[] DDNCBKLLGGF, ushort JGJLMAAOJBC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x234F950", Offset = "0x234E950", VA = "0x18234F950")]
		private ECIIEJBLKLC<T> DFCOMAEMJBL<T>(int NJHGCOBLCBJ, float[] DDNCBKLLGGF, ushort JGJLMAAOJBC = 0) where T : class, NAMDOKCHCKG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0150", Offset = "0x5DBF150", VA = "0x185DC0150")]
		public static FDHMLINJMLJ FindClosestDefaultUpdateLod(float DJCNCKHMDKE)
		{
			return default(FDHMLINJMLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x79DFF0", Offset = "0x79CFF0", VA = "0x18079DFF0")]
		public static FDHMLINJMLJ MinUpdateLod(FDHMLINJMLJ EJCIICLPCFK, FDHMLINJMLJ DPEPOLGKJJE)
		{
			return default(FDHMLINJMLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0670", Offset = "0x5DBF670", VA = "0x185DC0670")]
		public static FDHMLINJMLJ MaxUpdateLod(FDHMLINJMLJ EJCIICLPCFK, FDHMLINJMLJ DPEPOLGKJJE)
		{
			return default(FDHMLINJMLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0E50", Offset = "0x5DBFE50", VA = "0x185DC0E50")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OKBHFCKKMHP
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LPHGFCLDIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera MENAFBACMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DNHICBJBOMM PKCOJGFPMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JNBHHLIMHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DNHICBJBOMM MOIEAFFKJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform ECHJHKMJOAK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KKDEOGMNLDN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool FJAHPKGBODK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPDFOMDKBKK(NAMDOKCHCKG GPCHHCACPPJ, float PEBOEKHAPLP, NGEMNFJFDIP BDJMBIMNFFC = NGEMNFJFDIP.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MOJJDBCCFOB(NAMDOKCHCKG KKIIDHJMKJP);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GDMJJPJHLJO(NAMDOKCHCKG GPCHHCACPPJ, NGEMNFJFDIP KELKBAKPJKP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ECIIEJBLKLC<T> : KKDEOGMNLDN where T : class, NAMDOKCHCKG
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPDFOMDKBKK(T GPCHHCACPPJ, float PEBOEKHAPLP, NGEMNFJFDIP BDJMBIMNFFC = NGEMNFJFDIP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPDFOMDKBKK(T GPCHHCACPPJ, Transform LHPJHLKKKIL, float PEBOEKHAPLP, NGEMNFJFDIP BDJMBIMNFFC = NGEMNFJFDIP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MOJJDBCCFOB(T KKIIDHJMKJP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NAMDOKCHCKG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform PIMEBPKGKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(FDHMLINJMLJ JHHHBJMAAKM, FDHMLINJMLJ NMBEDMIFDIA);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool NKBJCONEJKF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum NGEMNFJFDIP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FDHMLINJMLJ
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
