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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, GECCANDAKGE
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class DDGEGJPLLAC<T> : NCGKBOPBEGK, JAOEHJMFDHA<T>, PKLEFBNKEMB where T : class, ENGGMMDIFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x4CD3740", Offset = "0x4CD2540", VA = "0x184CD3740")]
			internal DDGEGJPLLAC(int AAFALKOKIGC, float[] HEPEEJCPLND, BMFIIFLNHGH JPEFABCICKB = BMFIIFLNHGH.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x4CD36F0", Offset = "0x4CD24F0", VA = "0x184CD36F0", Slot = "10")]
			public void AAFNAGDLNDC(T HBDENJGMDDF, float OMKKAIJAKIM, FFJHIGAGFEP OJMMFLAFEKG = FFJHIGAGFEP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x4CD36C0", Offset = "0x4CD24C0", VA = "0x184CD36C0", Slot = "11")]
			public void AAFNAGDLNDC(T HBDENJGMDDF, Transform OOPIKHJKMCO, float OMKKAIJAKIM, FFJHIGAGFEP OJMMFLAFEKG = FFJHIGAGFEP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4CD3720", Offset = "0x4CD2520", VA = "0x184CD3720", Slot = "12")]
			public void ILBKIBAINPM(T JHMEMEHPALH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class NCGKBOPBEGK : IDisposable, PKLEFBNKEMB
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum BMFIIFLNHGH : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class COFJFKFBELC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public ENGGMMDIFLJ AFJJMLHIBKG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public FFJHIGAGFEP GIHAHJFIGAI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action PLLMGNAEHDP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool CBANCOIANLK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int CPCFHDJMLHI;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
				public COFJFKFBELC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class FBMNNMMNPJK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public NCGKBOPBEGK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public COFJFKFBELC trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
				public FBMNNMMNPJK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5CA6290", Offset = "0x5CA5090", VA = "0x185CA6290")]
				internal void BODGKJOBGHB()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int DIKKKOOEGBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int AAFALKOKIGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int FIHAMENAGBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool FABLEFHCLJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup DNGIBJFBPLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] CGDAEIPMMKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] FNLEOIHPEPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly NBJKBKAEDCO EILPDJCOMNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<ENGGMMDIFLJ, int> GPHBEEGNKPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, COFJFKFBELC> FPIFPGALJBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly BMFIIFLNHGH JPEFABCICKB;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool IHMHOBBLNKO
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x3BB31A0", Offset = "0x3BB1FA0", VA = "0x183BB31A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x33EFEC0", Offset = "0x33EECC0", VA = "0x1833EFEC0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7F80", Offset = "0x5CA6D80", VA = "0x185CA7F80")]
			internal NCGKBOPBEGK(int AAFALKOKIGC, float[] HEPEEJCPLND, BMFIIFLNHGH JPEFABCICKB = BMFIIFLNHGH.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5CA6870", Offset = "0x5CA5670", VA = "0x185CA6870")]
			public void CELLNFPGAGB(bool DDKNJMGKMPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5CA67D0", Offset = "0x5CA55D0", VA = "0x185CA67D0", Slot = "6")]
			public void AAFNAGDLNDC(ENGGMMDIFLJ HBDENJGMDDF, float OMKKAIJAKIM, FFJHIGAGFEP OJMMFLAFEKG = FFJHIGAGFEP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5CA63E0", Offset = "0x5CA51E0", VA = "0x185CA63E0", Slot = "9")]
			public void AAFNAGDLNDC(ENGGMMDIFLJ HBDENJGMDDF, Transform OOPIKHJKMCO, float OMKKAIJAKIM, FFJHIGAGFEP OJMMFLAFEKG = FFJHIGAGFEP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5CA6E10", Offset = "0x5CA5C10", VA = "0x185CA6E10")]
			public void FHCNJKBIFGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7BA0", Offset = "0x5CA69A0", VA = "0x185CA7BA0")]
			private void ODEOJAHJFIK(int DOJILIOCHKM, [Optional] float? OMKKAIJAKIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7050", Offset = "0x5CA5E50", VA = "0x185CA7050", Slot = "7")]
			public void ILBKIBAINPM(ENGGMMDIFLJ JHMEMEHPALH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5CA6F60", Offset = "0x5CA5D60", VA = "0x185CA6F60", Slot = "8")]
			public void GCPNIPGAOMM(ENGGMMDIFLJ HBDENJGMDDF, FFJHIGAGFEP CFHBJAKBPPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5CA68A0", Offset = "0x5CA56A0", VA = "0x185CA68A0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7750", Offset = "0x5CA6550", VA = "0x185CA7750")]
			private void JKFMIFKPNPG(COFJFKFBELC FOFOLKICEFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5CA6B60", Offset = "0x5CA5960", VA = "0x185CA6B60")]
			private void EPGDHCFDKOB(COFJFKFBELC FOFOLKICEFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7AE0", Offset = "0x5CA68E0", VA = "0x185CA7AE0")]
			private void KPGAHKBIAPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7B40", Offset = "0x5CA6940", VA = "0x185CA7B40")]
			private void MCIEECPDJPM(float MJMBAPAEFJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7E40", Offset = "0x5CA6C40", VA = "0x185CA7E40")]
			private void PNJKJOKLKIM(COFJFKFBELC FOFOLKICEFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5CA6860", Offset = "0x5CA5660", VA = "0x185CA6860")]
			private void APFOKAOJCCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5CA6E00", Offset = "0x5CA5C00", VA = "0x185CA6E00")]
			private void FHCACIBCDOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7430", Offset = "0x5CA6230", VA = "0x185CA7430")]
			private void IPDANMCONAH(CullingGroupEvent GEMHBDKPNPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5CA7CD0", Offset = "0x5CA6AD0", VA = "0x185CA7CD0")]
			private void PMDCFOBNKPC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct PAEJHDCOLAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort LBAEGFIPDAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type PJLKPLINKHJ;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float NPELGFDELIF = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float JLOHFEJCMJP = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float IMKFDIDMGFA = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float LOFLMCJKAFH = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float FDNOGBDDMPL = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float PEGOHEAOOJL = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float NMPMAMMDFJH = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<PAEJHDCOLAM, NCGKBOPBEGK> PBBJEONMGGF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable IFBKFHCHHJH;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable LDKDGECJNAE;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static ECJBBEDPNJE JDPBDEMPHLE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static ECJBBEDPNJE POKECEBPLFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly ECJBBEDPNJE GGLBOJJDAPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly ECJBBEDPNJE BPDAONMJMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly ECJBBEDPNJE OLKMGBBENBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private FFHNDEGIGAM ANAMEACHPNA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool DDKNJMGKMPM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ECJBBEDPNJE LGKFJCKBNHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ECJBBEDPNJE BMEPOOOJHHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ECJBBEDPNJE EHPEKEDFCEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x768580", Offset = "0x767380", VA = "0x180768580", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JMCKOBPKAOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBB1440", Offset = "0xBB0240", VA = "0x180BB1440", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ABJHONMDMMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B04D0", Offset = "0x7AF2D0", VA = "0x1807B04D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7B0AE0", Offset = "0x7AF8E0", VA = "0x1807B0AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5010", Offset = "0x5CA3E10", VA = "0x185CA5010", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5CA58E0", Offset = "0x5CA46E0", VA = "0x185CA58E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CA58C0", Offset = "0x5CA46C0", VA = "0x185CA58C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CA50D0", Offset = "0x5CA3ED0", VA = "0x185CA50D0")]
		private void DPCMHKLDJJB(Scene PIOKEHOJBEJ, LoadSceneMode CPGOEPLHNCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA57E0", Offset = "0x5CA45E0", VA = "0x185CA57E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5D20", Offset = "0x5CA4B20", VA = "0x185CA5D20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5130", Offset = "0x5CA3F30", VA = "0x185CA5130")]
		private void EJOMLEEOKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5AE0", Offset = "0x5CA48E0", VA = "0x185CA5AE0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5650", Offset = "0x5CA4450", VA = "0x185CA5650")]
		private void JNJLGEFJOMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5430", Offset = "0x5CA4230", VA = "0x185CA5430")]
		public PKLEFBNKEMB GetOrCreateCullingGroup(Type LKANAPJMFOF, int CGIOMBIICFF, ushort IKBOCFFALNM = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x21ED370", Offset = "0x21EC170", VA = "0x1821ED370")]
		public JAOEHJMFDHA<T> GetOrCreateCullingGroup<T>(int CGIOMBIICFF, ushort IKBOCFFALNM = 0) where T : class, ENGGMMDIFLJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5CA5900", Offset = "0x5CA4700", VA = "0x185CA5900")]
		private PKLEFBNKEMB PGNIJJIHFOB(Type LKANAPJMFOF, int CGIOMBIICFF, float[] HEPEEJCPLND, ushort IKBOCFFALNM = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x21ED410", Offset = "0x21EC210", VA = "0x1821ED410")]
		private JAOEHJMFDHA<T> PGNIJJIHFOB<T>(int CGIOMBIICFF, float[] HEPEEJCPLND, ushort IKBOCFFALNM = 0) where T : class, ENGGMMDIFLJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CA52D0", Offset = "0x5CA40D0", VA = "0x185CA52D0")]
		public static KFCLLDKJIGN FindClosestDefaultUpdateLod(float HHGGEPMEJEF)
		{
			return default(KFCLLDKJIGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x78FFF0", Offset = "0x78EDF0", VA = "0x18078FFF0")]
		public static KFCLLDKJIGN MinUpdateLod(KFCLLDKJIGN AEHKBHNMJOK, KFCLLDKJIGN DOECMALKDDF)
		{
			return default(KFCLLDKJIGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CA57D0", Offset = "0x5CA45D0", VA = "0x185CA57D0")]
		public static KFCLLDKJIGN MaxUpdateLod(KFCLLDKJIGN AEHKBHNMJOK, KFCLLDKJIGN DOECMALKDDF)
		{
			return default(KFCLLDKJIGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CA6190", Offset = "0x5CA4F90", VA = "0x185CA6190")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NBJKBKAEDCO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LJAOMPLOMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera ENDLNGGOOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ECJBBEDPNJE LGDPMLHMMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MLACFDDDJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ECJBBEDPNJE EELCNBGALCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform LPOGFDJLKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PKLEFBNKEMB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool IHMHOBBLNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAFNAGDLNDC(ENGGMMDIFLJ HBDENJGMDDF, float OMKKAIJAKIM, FFJHIGAGFEP OJMMFLAFEKG = FFJHIGAGFEP.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILBKIBAINPM(ENGGMMDIFLJ JHMEMEHPALH);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GCPNIPGAOMM(ENGGMMDIFLJ HBDENJGMDDF, FFJHIGAGFEP EHGBFFACGBE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JAOEHJMFDHA<T> : PKLEFBNKEMB where T : class, ENGGMMDIFLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAFNAGDLNDC(T HBDENJGMDDF, float OMKKAIJAKIM, FFJHIGAGFEP OJMMFLAFEKG = FFJHIGAGFEP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAFNAGDLNDC(T HBDENJGMDDF, Transform OOPIKHJKMCO, float OMKKAIJAKIM, FFJHIGAGFEP OJMMFLAFEKG = FFJHIGAGFEP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILBKIBAINPM(T JHMEMEHPALH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ENGGMMDIFLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform GNLAIPIBJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(KFCLLDKJIGN JGIAMHBKIBA, KFCLLDKJIGN AFKIDGEHLLD);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool FMEPODNLOHF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum FFJHIGAGFEP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum KFCLLDKJIGN
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
