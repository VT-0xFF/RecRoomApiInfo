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
		[Cpp2IlInjected.Address(RVA = "0x9931A10", Offset = "0x9930810", VA = "0x189931A10")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, GUPOFWBVNMS creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9931B50", Offset = "0x9930950", VA = "0x189931B50")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, GUPOFWBVNMS creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9931840", Offset = "0x9930640", VA = "0x189931840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9931230", Offset = "0x9930030", VA = "0x189931230")]
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
			[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
			internal Access(ESDDCQNFWIN instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x992D660", Offset = "0x992C460", VA = "0x18992D660")]
			public void LMMUVSQEAHN(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x992D6E0", Offset = "0x992C4E0", VA = "0x18992D6E0")]
			public void UCDZSNWSVVR(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
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
			[Cpp2IlInjected.Address(RVA = "0x992DDF0", Offset = "0x992CBF0", VA = "0x18992DDF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9930670", Offset = "0x992F470", VA = "0x189930670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static DVMYKJKBIQX XICAMVJLVES
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x992F5D0", Offset = "0x992E3D0", VA = "0x18992F5D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x992F4F0", Offset = "0x992E2F0", VA = "0x18992F4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string YUCKBXTRNQW
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x99306E0", Offset = "0x992F4E0", VA = "0x1899306E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> ZULLOQDMMHX
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x992E230", Offset = "0x992D030", VA = "0x18992E230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool QFWQYRJTORK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x992DAE0", Offset = "0x992C8E0", VA = "0x18992DAE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool BMGZGIWJJNZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x992E690", Offset = "0x992D490", VA = "0x18992E690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool HSYGFXFVUKS
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x992EFB0", Offset = "0x992DDB0", VA = "0x18992EFB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double ICDAYHQMCMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9930060", Offset = "0x992EE60", VA = "0x189930060")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int ZNRYLBDDSUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x992F470", Offset = "0x992E270", VA = "0x18992F470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float GRPXCNWJYFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x992F380", Offset = "0x992E180", VA = "0x18992F380")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool OKAKVETJBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x992E8B0", Offset = "0x992D6B0", VA = "0x18992E8B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool RLAZWSISEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x992FFE0", Offset = "0x992EDE0", VA = "0x18992FFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static GUPOFWBVNMS JEGPTVEDGKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x992DBF0", Offset = "0x992C9F0", VA = "0x18992DBF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static JYTIDKYVVQE RVCQAXCUSLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x992E190", Offset = "0x992CF90", VA = "0x18992E190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static GUPOFWBVNMS YKBSWBFDOBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x992F6A0", Offset = "0x992E4A0", VA = "0x18992F6A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static CDPRAJEFKDH GUKFHWXZOBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9930D50", Offset = "0x992FB50", VA = "0x189930D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int QMTEWVPMKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x992F300", Offset = "0x992E100", VA = "0x18992F300")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int RHHVPGDIADU
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x992F620", Offset = "0x992E420", VA = "0x18992F620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int BRUKMPCKKXM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x992E3A0", Offset = "0x992D1A0", VA = "0x18992E3A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string ZEKLDYQHFRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x992D760", Offset = "0x992C560", VA = "0x18992D760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long VGIKHEWIEAX
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9930770", Offset = "0x992F570", VA = "0x189930770")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long WLDUOCHRCAG
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x99308D0", Offset = "0x992F6D0", VA = "0x1899308D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool HHCFARZRIKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x992F900", Offset = "0x992E700", VA = "0x18992F900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x992E5A0", Offset = "0x992D3A0", VA = "0x18992E5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string XALXVZWLSKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x992DE40", Offset = "0x992CC40", VA = "0x18992DE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x992E9B0", Offset = "0x992D7B0", VA = "0x18992E9B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9930BD0", Offset = "0x992F9D0", VA = "0x189930BD0")]
		public static Access ZDTPPFOXDNG(ESDDCQNFWIN a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x992F560", Offset = "0x992E360", VA = "0x18992F560")]
		public static void QAEXMPHIGVS(YJNLRHPFYDO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x992F820", Offset = "0x992E620", VA = "0x18992F820")]
		public static object TJSMBDDXAMK(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9930150", Offset = "0x992EF50", VA = "0x189930150")]
		public static GameObject WBOZGMFZHSH(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9930520", Offset = "0x992F320", VA = "0x189930520")]
		public static GameObject WBOZGMFZHSH(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9930420", Offset = "0x992F220", VA = "0x189930420")]
		public static GameObject WBOZGMFZHSH(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99302D0", Offset = "0x992F0D0", VA = "0x1899302D0")]
		public static GameObject WBOZGMFZHSH(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x992F1B0", Offset = "0x992DFB0", VA = "0x18992F1B0")]
		public static GameObject OOYRFCOXKGL(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x992F030", Offset = "0x992DE30", VA = "0x18992F030")]
		public static GameObject OOYRFCOXKGL(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9930950", Offset = "0x992F750", VA = "0x189930950")]
		public static GameObject XPBZTHYAWMK(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x992ED50", Offset = "0x992DB50", VA = "0x18992ED50")]
		public static GameObject OBKSKFBDQPO(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x992F720", Offset = "0x992E520", VA = "0x18992F720")]
		public static void RTVIFYGQPAV(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x992F7A0", Offset = "0x992E5A0", VA = "0x18992F7A0")]
		public static void TGVEFKEQALC(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x992FA20", Offset = "0x992E820", VA = "0x18992FA20")]
		public static GameObject VFKNADAVPTV(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x992F980", Offset = "0x992E780", VA = "0x18992F980")]
		public static GameObject VFKNADAVPTV(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x992FAC0", Offset = "0x992E8C0", VA = "0x18992FAC0")]
		public static GameObject VFKNADAVPTV(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x992E4A0", Offset = "0x992D2A0", VA = "0x18992E4A0")]
		public static GameObject[] HCXIQWWVQQG(IList<VTRNOXHLFIB> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99307F0", Offset = "0x992F5F0", VA = "0x1899307F0")]
		public static void XJZEQWDVBZD(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x992E420", Offset = "0x992D220", VA = "0x18992E420")]
		public static void GLHZKOZFRUA(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x992E710", Offset = "0x992D510", VA = "0x18992E710")]
		public static void IAKPRARYORB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x992EA30", Offset = "0x992D830", VA = "0x18992EA30")]
		public static float LMJDTWQHJHN(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x992EB30", Offset = "0x992D930", VA = "0x18992EB30")]
		public static GUPOFWBVNMS LSYTJXSXUGW(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x992E790", Offset = "0x992D590", VA = "0x18992E790")]
		public static GUPOFWBVNMS IFSVABANWGE(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x992EEC0", Offset = "0x992DCC0", VA = "0x18992EEC0")]
		public static GUPOFWBVNMS OCUQFXFYTLM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x992FF50", Offset = "0x992ED50", VA = "0x18992FF50")]
		public static IReadOnlyList<GUPOFWBVNMS> VPMZNBEILYK(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x992DB60", Offset = "0x992C960", VA = "0x18992DB60")]
		public static IReadOnlyList<GUPOFWBVNMS> BDEFTIGHDGF(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x992E320", Offset = "0x992D120", VA = "0x18992E320")]
		public static void FRKPJZZZTFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x992E830", Offset = "0x992D630", VA = "0x18992E830")]
		public static bool IMSIVTFVUSC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x992DD00", Offset = "0x992CB00", VA = "0x18992DD00")]
		public static bool BXNPAQDLKRE(GUPOFWBVNMS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x992D980", Offset = "0x992C780", VA = "0x18992D980")]
		public static bool AMOVTMMCLWN(NetworkEventCode a, object b, OGEXSFQHDBH c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x992D850", Offset = "0x992C650", VA = "0x18992D850")]
		public static bool AMOVTMMCLWN(byte a, object b, OGEXSFQHDBH c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x992E930", Offset = "0x992D730", VA = "0x18992E930")]
		public static void JUDXTFCKDSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x992EBD0", Offset = "0x992D9D0", VA = "0x18992EBD0")]
		public static void NYKTBLQYXAJ(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x992DF90", Offset = "0x992CD90", VA = "0x18992DF90")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x992DEA0", Offset = "0x992CCA0", VA = "0x18992DEA0")]
		public static int COPIOQMYBAN(XHRZBUOCUVQ a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x992E090", Offset = "0x992CE90", VA = "0x18992E090")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x992DC70", Offset = "0x992CA70", VA = "0x18992DC70")]
		public static void BNZSPXUUBJG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x992ECD0", Offset = "0x992DAD0", VA = "0x18992ECD0")]
		public static int NYXPOAUPOMH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x992EE40", Offset = "0x992DC40", VA = "0x18992EE40")]
		public static void OCQUTQLOZBT(WHWIROLHRQO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x992E110", Offset = "0x992CF10", VA = "0x18992E110")]
		public static void EFWTTJIZICN(UZVLDSEDVVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9930C60", Offset = "0x992FA60", VA = "0x189930C60")]
		public static string ZRFMQLPFQVB(XHRZBUOCUVQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x992FE20", Offset = "0x992EC20", VA = "0x18992FE20")]
		public static void VJAJIYGWGXS(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x992FD00", Offset = "0x992EB00", VA = "0x18992FD00")]
		public static void VJAJIYGWGXS(ViewId a, string b, GUPOFWBVNMS c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9930AF0", Offset = "0x992F8F0", VA = "0x189930AF0")]
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
