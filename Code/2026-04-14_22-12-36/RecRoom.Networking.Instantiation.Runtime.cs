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
	public interface CMMGPHXWGYQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object AANGEPEQATD(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject DNHOCPETSBG(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject HPIGYAEHOJA(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject BQOMUKRVXZN(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject AXGQLDLEVNP(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void VYDSHFUVAKM(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QRWBTVIMCFD(GameObject a);
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
		public DDFOJMMWCEL creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9947060", Offset = "0x9945C60", VA = "0x189947060")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, DDFOJMMWCEL creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99471A0", Offset = "0x9945DA0", VA = "0x1899471A0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, DDFOJMMWCEL creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9946E90", Offset = "0x9945A90", VA = "0x189946E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9946880", Offset = "0x9945480", VA = "0x189946880")]
		public string EJMTGZTXVYA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface XJMTDZCTHZH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] SRLVMLJILOF(IList<XHNPIXFCEBC> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HQVDAZKAASI(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CUIMRRJTBAF(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FZAGUMQDXWE();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class ZYMSXBLLAXE
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CMMGPHXWGYQ instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
			internal Access(CMMGPHXWGYQ instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9946780", Offset = "0x9945380", VA = "0x189946780")]
			public void OVNODQZWABG(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9946800", Offset = "0x9945400", VA = "0x189946800")]
			public void QIMLTSYMPZU(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
			private void YXQMDBCIZZG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static DRWWZAXJWQZ<PlayerId> GKTGPJMSZWQ;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static DRWWZAXJWQZ<PlayerId> TKFPIBBOLFM;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static ZJRPIEIFVPN CGIREJRJVTH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static DRMJENJPDUH<DDFOJMMWCEL, double, object> QMPVLKKXUPJ;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static DRWWZAXJWQZ<IReadOnlyList<InstantiateParameters>> BWNZQNPBVUC;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static DRHCHGPRUIY<GameObject, bool> EKVUTPNWKLJ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static DRWWZAXJWQZ<GameObject> AJKNRYFPEBP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static DRWWZAXJWQZ<GameObject> FICQNTPHBWE;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static DRHCHGPRUIY<int, int> NQJXAMNHBXS;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static YZDETVQVLVA RJEEVARCTSJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static DSMRQVFBYZA<string, ViewId, CVWDRVYPYSK, CVWDRVYPYSK> LKQWEHHDIAT;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static CMMGPHXWGYQ SBIYFRQMLWV;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access JNDGZFNXXEG;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static XJMTDZCTHZH BOQGNDNUOZY;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static GWUEKANUWLO OKEWJZEUHVB;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static IDLXRUJKSDP ZEPEQNJDATU;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static ZSDCJODNTRP NOHBICHDSLY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GWUEKANUWLO FQPHLQCDRWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9947B70", Offset = "0x9946770", VA = "0x189947B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x99476E0", Offset = "0x99462E0", VA = "0x1899476E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static FJAIXDTJXYY USMPVWLSWVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x99484D0", Offset = "0x99470D0", VA = "0x1899484D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x994A570", Offset = "0x9949170", VA = "0x18994A570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string FBLEUZHGBSR
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x99485A0", Offset = "0x99471A0", VA = "0x1899485A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> GVTOYPAQOOO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9948260", Offset = "0x9946E60", VA = "0x189948260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool GSQBWBASRMT
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9949910", Offset = "0x9948510", VA = "0x189949910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool WBHADULSMJG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9949A10", Offset = "0x9948610", VA = "0x189949A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool TTKKFZXQVOV
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x99496A0", Offset = "0x99482A0", VA = "0x1899496A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double FJTWFODLAKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x99497A0", Offset = "0x99483A0", VA = "0x1899497A0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int SZTBRXXLFHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9947A60", Offset = "0x9946660", VA = "0x189947A60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float BYZQWBMMOXX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9948F60", Offset = "0x9947B60", VA = "0x189948F60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9948630", Offset = "0x9947230", VA = "0x189948630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool RXQOZDWSMOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9949720", Offset = "0x9948320", VA = "0x189949720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static DDFOJMMWCEL SJQDIJZJGRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x994A300", Offset = "0x9948F00", VA = "0x18994A300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static OHGZMIFYUNP XSMAXVAANWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x99493E0", Offset = "0x9947FE0", VA = "0x1899493E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static DDFOJMMWCEL BTZMFQHTJQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9949620", Offset = "0x9948220", VA = "0x189949620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static TMYXSDLHSTG LEIBVRTZQNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9948B90", Offset = "0x9947790", VA = "0x189948B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int VYQRBPMIUIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9948D10", Offset = "0x9947910", VA = "0x189948D10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int KXSRXAWRJYB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9949D10", Offset = "0x9948910", VA = "0x189949D10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int CUUWCKVTHZT
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9948C90", Offset = "0x9947890", VA = "0x189948C90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string FKWCRQQXOPT
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x99478F0", Offset = "0x99464F0", VA = "0x1899478F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long CSRBWDSDKFK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9948C10", Offset = "0x9947810", VA = "0x189948C10")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long DJJZLUQCGTR
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9949050", Offset = "0x9947C50", VA = "0x189949050")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool BNUXZSVAKQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9948750", Offset = "0x9947350", VA = "0x189948750")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x994A640", Offset = "0x9949240", VA = "0x18994A640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string UWMKAKYYDTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x994A5E0", Offset = "0x99491E0", VA = "0x18994A5E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9949890", Offset = "0x9948490", VA = "0x189949890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9947AE0", Offset = "0x99466E0", VA = "0x189947AE0")]
		public static Access CZTXPFZRHDL(CMMGPHXWGYQ a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9949B10", Offset = "0x9948710", VA = "0x189949B10")]
		public static void RIUGUVBVZWR(XJMTDZCTHZH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99472C0", Offset = "0x9945EC0", VA = "0x1899472C0")]
		public static object AANGEPEQATD(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9947F60", Offset = "0x9946B60", VA = "0x189947F60")]
		public static GameObject DNHOCPETSBG(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9947E10", Offset = "0x9946A10", VA = "0x189947E10")]
		public static GameObject DNHOCPETSBG(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9947BC0", Offset = "0x99467C0", VA = "0x189947BC0")]
		public static GameObject DNHOCPETSBG(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9947CC0", Offset = "0x99468C0", VA = "0x189947CC0")]
		public static GameObject DNHOCPETSBG(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99487D0", Offset = "0x99473D0", VA = "0x1899487D0")]
		public static GameObject HPIGYAEHOJA(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9948920", Offset = "0x9947520", VA = "0x189948920")]
		public static GameObject HPIGYAEHOJA(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9947750", Offset = "0x9946350", VA = "0x189947750")]
		public static GameObject BQOMUKRVXZN(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99475F0", Offset = "0x99461F0", VA = "0x1899475F0")]
		public static GameObject AXGQLDLEVNP(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x994A4F0", Offset = "0x99490F0", VA = "0x18994A4F0")]
		public static void VYDSHFUVAKM(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9949A90", Offset = "0x9948690", VA = "0x189949A90")]
		public static void QRWBTVIMCFD(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9949FD0", Offset = "0x9948BD0", VA = "0x189949FD0")]
		public static GameObject TKGRGMJILUK(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x994A070", Offset = "0x9948C70", VA = "0x18994A070")]
		public static GameObject TKGRGMJILUK(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9949D90", Offset = "0x9948990", VA = "0x189949D90")]
		public static GameObject TKGRGMJILUK(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9949C10", Offset = "0x9948810", VA = "0x189949C10")]
		public static GameObject[] SRLVMLJILOF(IList<XHNPIXFCEBC> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x994A380", Offset = "0x9948F80", VA = "0x18994A380")]
		public static void UPQRTKLMYGS(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99479E0", Offset = "0x99465E0", VA = "0x1899479E0")]
		public static void CUIMRRJTBAF(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9948350", Offset = "0x9946F50", VA = "0x189948350")]
		public static void FZAGUMQDXWE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9949520", Offset = "0x9948120", VA = "0x189949520")]
		public static float NZAZITBSOOS(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9949480", Offset = "0x9948080", VA = "0x189949480")]
		public static DDFOJMMWCEL NVRBKRBHARX(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x99486B0", Offset = "0x99472B0", VA = "0x1899486B0")]
		public static DDFOJMMWCEL HJROMWQQMHF(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9948AA0", Offset = "0x99476A0", VA = "0x189948AA0")]
		public static DDFOJMMWCEL IIBLULRPXTT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x994A8A0", Offset = "0x99494A0", VA = "0x18994A8A0")]
		public static IReadOnlyList<DDFOJMMWCEL> XRUBPDIOBYZ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9949B80", Offset = "0x9948780", VA = "0x189949B80")]
		public static IReadOnlyList<DDFOJMMWCEL> RJMAAMOFRUW(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9949990", Offset = "0x9948590", VA = "0x189949990")]
		public static void QATIHROFFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x994A280", Offset = "0x9948E80", VA = "0x18994A280")]
		public static bool TVXUEBNDIIZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x994A7B0", Offset = "0x99493B0", VA = "0x18994A7B0")]
		public static bool XAYFZNDMPKV(DDFOJMMWCEL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9949280", Offset = "0x9947E80", VA = "0x189949280")]
		public static bool MNLYZBGQWWU(NetworkEventCode a, object b, SVLVGVMSMLM c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9949150", Offset = "0x9947D50", VA = "0x189949150")]
		public static bool MNLYZBGQWWU(byte a, object b, SVLVGVMSMLM c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x994A730", Offset = "0x9949330", VA = "0x18994A730")]
		public static void WLCCVUQBECS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x99483D0", Offset = "0x9946FD0", VA = "0x1899483D0")]
		public static void GHRXOLGFAHI(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x99480E0", Offset = "0x9946CE0", VA = "0x1899480E0")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9948E70", Offset = "0x9947A70", VA = "0x189948E70")]
		public static int LKLUPJTVVPG(VZMXLASXEMR a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x99481E0", Offset = "0x9946DE0", VA = "0x1899481E0")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x994A460", Offset = "0x9949060", VA = "0x18994A460")]
		public static void UWOMOYEFAIJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9948520", Offset = "0x9947120", VA = "0x189948520")]
		public static int GSWHCWZIZRG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99490D0", Offset = "0x9947CD0", VA = "0x1899490D0")]
		public static void LXKDEQLOHDQ(IDLXRUJKSDP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x994A110", Offset = "0x9948D10", VA = "0x18994A110")]
		public static void TLLITJKMHBA(ZSDCJODNTRP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x994A190", Offset = "0x9948D90", VA = "0x18994A190")]
		public static string TVXKJNMIXSK(VZMXLASXEMR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x99474C0", Offset = "0x99460C0", VA = "0x1899474C0")]
		public static void ARTCSILUAKP(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x99473A0", Offset = "0x9945FA0", VA = "0x1899473A0")]
		public static void ARTCSILUAKP(ViewId a, string b, DDFOJMMWCEL c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9948D90", Offset = "0x9947990", VA = "0x189948D90")]
		public static void KSOJYXHPFRP(ViewId a)
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
