using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Networking.DataTypes;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface ESDDCQNFWIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object TJSMBDDXAMK(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject WBOZGMFZHSH(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject OOYRFCOXKGL(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject XPBZTHYAWMK(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject OBKSKFBDQPO(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RTVIFYGQPAV(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void TGVEFKEQALC(GameObject a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct InstantiateParameters
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int[] viewIDs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte objLevelPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public object[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public byte group;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Vector3 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public string prefabName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public GUPOFWBVNMS creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9AB4AA0", Offset = "0x9AB34A0", VA = "0x189AB4AA0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, GUPOFWBVNMS creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9AB4BE0", Offset = "0x9AB35E0", VA = "0x189AB4BE0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, GUPOFWBVNMS creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9AB48D0", Offset = "0x9AB32D0", VA = "0x189AB48D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9AB42C0", Offset = "0x9AB2CC0", VA = "0x189AB42C0")]
		public string NXDUMVEDFQD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface YJNLRHPFYDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] HCXIQWWVQQG(IList<VTRNOXHLFIB> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QBKQUNPABGZ(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GLHZKOZFRUA(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IAKPRARYORB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class ILVDIGVOVSR
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly ESDDCQNFWIN instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xEF90A0", Offset = "0xEF7AA0", VA = "0x180EF90A0")]
			internal Access(ESDDCQNFWIN instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0670", Offset = "0x9AAF070", VA = "0x189AB0670")]
			public void LMMUVSQEAHN(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9AB06F0", Offset = "0x9AAF0F0", VA = "0x189AB06F0")]
			public void UCDZSNWSVVR(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
			private void MUPBGJJVQOL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static ASNKAFBFVVA<PlayerId> YFQHDBYPSPF;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static ASNKAFBFVVA<PlayerId> JWDAVJPUALR;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static UTTDOXTMXQW UTISZCHWWAI;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static ASCWFRNLCYI<GUPOFWBVNMS, double, object> DQOIXBPXETE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static ASNKAFBFVVA<IReadOnlyList<InstantiateParameters>> PVTSQHGQHNN;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static ASIDCYHIMJR<GameObject, bool> XDASIQFZWPA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static ASNKAFBFVVA<GameObject> YQMPSLSOGBS;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static ASNKAFBFVVA<GameObject> UKGBUFFAAYV;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static ASIDCYHIMJR<int, int> ZPILCZHMXWF;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static DYNHRMPGIXT YWGYAULDUFI;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static ATNSMMWSQZT<string, ViewId, ZHBFLYLVHWX, ZHBFLYLVHWX> UPDJHRMWFPG;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static ESDDCQNFWIN POFKGVLHAVU;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access NTIIPVJWEVV;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static YJNLRHPFYDO LYJVLSWXLZP;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static QNGOUPLXGFN NHDIESGWXKG;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static WHWIROLHRQO LMVVDSZGPPF;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static UZVLDSEDVVI WHUEZBWJQZR;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static QNGOUPLXGFN ACVUSILGGTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0E20", Offset = "0x9AAF820", VA = "0x189AB0E20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9AB36E0", Offset = "0x9AB20E0", VA = "0x189AB36E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static DVMYKJKBIQX XICAMVJLVES
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9AB2620", Offset = "0x9AB1020", VA = "0x189AB2620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9AB2540", Offset = "0x9AB0F40", VA = "0x189AB2540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string YUCKBXTRNQW
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9AB3750", Offset = "0x9AB2150", VA = "0x189AB3750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> ZULLOQDMMHX
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9AB1270", Offset = "0x9AAFC70", VA = "0x189AB1270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool QFWQYRJTORK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0B00", Offset = "0x9AAF500", VA = "0x189AB0B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool BMGZGIWJJNZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9AB16D0", Offset = "0x9AB00D0", VA = "0x189AB16D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool HSYGFXFVUKS
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9AB2000", Offset = "0x9AB0A00", VA = "0x189AB2000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double ICDAYHQMCMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9AB30C0", Offset = "0x9AB1AC0", VA = "0x189AB30C0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int ZNRYLBDDSUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9AB24C0", Offset = "0x9AB0EC0", VA = "0x189AB24C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float GRPXCNWJYFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9AB23D0", Offset = "0x9AB0DD0", VA = "0x189AB23D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool OKAKVETJBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9AB18F0", Offset = "0x9AB02F0", VA = "0x189AB18F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool RLAZWSISEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9AB3040", Offset = "0x9AB1A40", VA = "0x189AB3040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static GUPOFWBVNMS JEGPTVEDGKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0C10", Offset = "0x9AAF610", VA = "0x189AB0C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static JYTIDKYVVQE RVCQAXCUSLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9AB11D0", Offset = "0x9AAFBD0", VA = "0x189AB11D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static GUPOFWBVNMS YKBSWBFDOBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9AB26F0", Offset = "0x9AB10F0", VA = "0x189AB26F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static CDPRAJEFKDH GUKFHWXZOBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9AB3DE0", Offset = "0x9AB27E0", VA = "0x189AB3DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int QMTEWVPMKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9AB2350", Offset = "0x9AB0D50", VA = "0x189AB2350")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int RHHVPGDIADU
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9AB2670", Offset = "0x9AB1070", VA = "0x189AB2670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int BRUKMPCKKXM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9AB13E0", Offset = "0x9AAFDE0", VA = "0x189AB13E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string ZEKLDYQHFRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0770", Offset = "0x9AAF170", VA = "0x189AB0770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long VGIKHEWIEAX
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9AB37E0", Offset = "0x9AB21E0", VA = "0x189AB37E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long WLDUOCHRCAG
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9AB3940", Offset = "0x9AB2340", VA = "0x189AB3940")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool HHCFARZRIKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9AB2960", Offset = "0x9AB1360", VA = "0x189AB2960")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9AB15E0", Offset = "0x9AAFFE0", VA = "0x189AB15E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string XALXVZWLSKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0E70", Offset = "0x9AAF870", VA = "0x189AB0E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9AB19F0", Offset = "0x9AB03F0", VA = "0x189AB19F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9AB3C50", Offset = "0x9AB2650", VA = "0x189AB3C50")]
		public static Access ZDTPPFOXDNG(ESDDCQNFWIN a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9AB25B0", Offset = "0x9AB0FB0", VA = "0x189AB25B0")]
		public static void QAEXMPHIGVS(YJNLRHPFYDO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9AB2870", Offset = "0x9AB1270", VA = "0x189AB2870")]
		public static object TJSMBDDXAMK(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9AB31B0", Offset = "0x9AB1BB0", VA = "0x189AB31B0")]
		public static GameObject WBOZGMFZHSH(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9AB3590", Offset = "0x9AB1F90", VA = "0x189AB3590")]
		public static GameObject WBOZGMFZHSH(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9AB3490", Offset = "0x9AB1E90", VA = "0x189AB3490")]
		public static GameObject WBOZGMFZHSH(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9AB3340", Offset = "0x9AB1D40", VA = "0x189AB3340")]
		public static GameObject WBOZGMFZHSH(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9AB2200", Offset = "0x9AB0C00", VA = "0x189AB2200")]
		public static GameObject OOYRFCOXKGL(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9AB2080", Offset = "0x9AB0A80", VA = "0x189AB2080")]
		public static GameObject OOYRFCOXKGL(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9AB39C0", Offset = "0x9AB23C0", VA = "0x189AB39C0")]
		public static GameObject XPBZTHYAWMK(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1D90", Offset = "0x9AB0790", VA = "0x189AB1D90")]
		public static GameObject OBKSKFBDQPO(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9AB2770", Offset = "0x9AB1170", VA = "0x189AB2770")]
		public static void RTVIFYGQPAV(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9AB27F0", Offset = "0x9AB11F0", VA = "0x189AB27F0")]
		public static void TGVEFKEQALC(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9AB2A80", Offset = "0x9AB1480", VA = "0x189AB2A80")]
		public static GameObject VFKNADAVPTV(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9AB29E0", Offset = "0x9AB13E0", VA = "0x189AB29E0")]
		public static GameObject VFKNADAVPTV(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9AB2B20", Offset = "0x9AB1520", VA = "0x189AB2B20")]
		public static GameObject VFKNADAVPTV(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9AB14E0", Offset = "0x9AAFEE0", VA = "0x189AB14E0")]
		public static GameObject[] HCXIQWWVQQG(IList<VTRNOXHLFIB> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9AB3860", Offset = "0x9AB2260", VA = "0x189AB3860")]
		public static void XJZEQWDVBZD(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1460", Offset = "0x9AAFE60", VA = "0x189AB1460")]
		public static void GLHZKOZFRUA(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1750", Offset = "0x9AB0150", VA = "0x189AB1750")]
		public static void IAKPRARYORB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1A70", Offset = "0x9AB0470", VA = "0x189AB1A70")]
		public static float LMJDTWQHJHN(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1B70", Offset = "0x9AB0570", VA = "0x189AB1B70")]
		public static GUPOFWBVNMS LSYTJXSXUGW(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9AB17D0", Offset = "0x9AB01D0", VA = "0x189AB17D0")]
		public static GUPOFWBVNMS IFSVABANWGE(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1F00", Offset = "0x9AB0900", VA = "0x189AB1F00")]
		public static GUPOFWBVNMS OCUQFXFYTLM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9AB2FB0", Offset = "0x9AB19B0", VA = "0x189AB2FB0")]
		public static IReadOnlyList<GUPOFWBVNMS> VPMZNBEILYK(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0B80", Offset = "0x9AAF580", VA = "0x189AB0B80")]
		public static IReadOnlyList<GUPOFWBVNMS> BDEFTIGHDGF(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1360", Offset = "0x9AAFD60", VA = "0x189AB1360")]
		public static void FRKPJZZZTFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1870", Offset = "0x9AB0270", VA = "0x189AB1870")]
		public static bool IMSIVTFVUSC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0D20", Offset = "0x9AAF720", VA = "0x189AB0D20")]
		public static bool BXNPAQDLKRE(GUPOFWBVNMS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9AB09A0", Offset = "0x9AAF3A0", VA = "0x189AB09A0")]
		public static bool AMOVTMMCLWN(NetworkEventCode a, object b, OGEXSFQHDBH c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0860", Offset = "0x9AAF260", VA = "0x189AB0860")]
		public static bool AMOVTMMCLWN(byte a, object b, OGEXSFQHDBH c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1970", Offset = "0x9AB0370", VA = "0x189AB1970")]
		public static void JUDXTFCKDSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1C10", Offset = "0x9AB0610", VA = "0x189AB1C10")]
		public static void NYKTBLQYXAJ(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0FD0", Offset = "0x9AAF9D0", VA = "0x189AB0FD0")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0ED0", Offset = "0x9AAF8D0", VA = "0x189AB0ED0")]
		public static int COPIOQMYBAN(XHRZBUOCUVQ a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9AB10D0", Offset = "0x9AAFAD0", VA = "0x189AB10D0")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0C90", Offset = "0x9AAF690", VA = "0x189AB0C90")]
		public static void BNZSPXUUBJG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1D10", Offset = "0x9AB0710", VA = "0x189AB1D10")]
		public static int NYXPOAUPOMH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1E80", Offset = "0x9AB0880", VA = "0x189AB1E80")]
		public static void OCQUTQLOZBT(WHWIROLHRQO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1150", Offset = "0x9AAFB50", VA = "0x189AB1150")]
		public static void EFWTTJIZICN(UZVLDSEDVVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9AB3CE0", Offset = "0x9AB26E0", VA = "0x189AB3CE0")]
		public static string ZRFMQLPFQVB(XHRZBUOCUVQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9AB2E80", Offset = "0x9AB1880", VA = "0x189AB2E80")]
		public static void VJAJIYGWGXS(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9AB2D60", Offset = "0x9AB1760", VA = "0x189AB2D60")]
		public static void VJAJIYGWGXS(ViewId a, string b, GUPOFWBVNMS c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9AB3B60", Offset = "0x9AB2560", VA = "0x189AB3B60")]
		public static void XUAFPWBGJQM(ViewId a)
		{
		}
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
