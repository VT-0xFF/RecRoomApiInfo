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
		[Cpp2IlInjected.Address(RVA = "0x9AE82E0", Offset = "0x9AE72E0", VA = "0x189AE82E0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, DDFOJMMWCEL creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8420", Offset = "0x9AE7420", VA = "0x189AE8420")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, DDFOJMMWCEL creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8110", Offset = "0x9AE7110", VA = "0x189AE8110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9AE7B00", Offset = "0x9AE6B00", VA = "0x189AE7B00")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
			internal Access(CMMGPHXWGYQ instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7A00", Offset = "0x9AE6A00", VA = "0x189AE7A00")]
			public void OVNODQZWABG(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7A80", Offset = "0x9AE6A80", VA = "0x189AE7A80")]
			public void QIMLTSYMPZU(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AE8DF0", Offset = "0x9AE7DF0", VA = "0x189AE8DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9AE8960", Offset = "0x9AE7960", VA = "0x189AE8960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static FJAIXDTJXYY USMPVWLSWVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9AE9750", Offset = "0x9AE8750", VA = "0x189AE9750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9AEB7F0", Offset = "0x9AEA7F0", VA = "0x189AEB7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string FBLEUZHGBSR
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9AE9820", Offset = "0x9AE8820", VA = "0x189AE9820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> GVTOYPAQOOO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9AE94E0", Offset = "0x9AE84E0", VA = "0x189AE94E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool GSQBWBASRMT
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9AEAB90", Offset = "0x9AE9B90", VA = "0x189AEAB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool WBHADULSMJG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9AEAC90", Offset = "0x9AE9C90", VA = "0x189AEAC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool TTKKFZXQVOV
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9AEA920", Offset = "0x9AE9920", VA = "0x189AEA920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double FJTWFODLAKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9AEAA20", Offset = "0x9AE9A20", VA = "0x189AEAA20")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int SZTBRXXLFHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9AE8CE0", Offset = "0x9AE7CE0", VA = "0x189AE8CE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float BYZQWBMMOXX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9AEA1E0", Offset = "0x9AE91E0", VA = "0x189AEA1E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9AE98B0", Offset = "0x9AE88B0", VA = "0x189AE98B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool RXQOZDWSMOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9AEA9A0", Offset = "0x9AE99A0", VA = "0x189AEA9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static DDFOJMMWCEL SJQDIJZJGRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9AEB580", Offset = "0x9AEA580", VA = "0x189AEB580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static OHGZMIFYUNP XSMAXVAANWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9AEA660", Offset = "0x9AE9660", VA = "0x189AEA660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static DDFOJMMWCEL BTZMFQHTJQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9AEA8A0", Offset = "0x9AE98A0", VA = "0x189AEA8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static TMYXSDLHSTG LEIBVRTZQNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9AE9E10", Offset = "0x9AE8E10", VA = "0x189AE9E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int VYQRBPMIUIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9AE9F90", Offset = "0x9AE8F90", VA = "0x189AE9F90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int KXSRXAWRJYB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9AEAF90", Offset = "0x9AE9F90", VA = "0x189AEAF90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int CUUWCKVTHZT
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9AE9F10", Offset = "0x9AE8F10", VA = "0x189AE9F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string FKWCRQQXOPT
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9AE8B70", Offset = "0x9AE7B70", VA = "0x189AE8B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long CSRBWDSDKFK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9AE9E90", Offset = "0x9AE8E90", VA = "0x189AE9E90")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long DJJZLUQCGTR
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9AEA2D0", Offset = "0x9AE92D0", VA = "0x189AEA2D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool BNUXZSVAKQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9AE99D0", Offset = "0x9AE89D0", VA = "0x189AE99D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9AEB8C0", Offset = "0x9AEA8C0", VA = "0x189AEB8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string UWMKAKYYDTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9AEB860", Offset = "0x9AEA860", VA = "0x189AEB860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9AEAB10", Offset = "0x9AE9B10", VA = "0x189AEAB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8D60", Offset = "0x9AE7D60", VA = "0x189AE8D60")]
		public static Access CZTXPFZRHDL(CMMGPHXWGYQ a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAD90", Offset = "0x9AE9D90", VA = "0x189AEAD90")]
		public static void RIUGUVBVZWR(XJMTDZCTHZH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8540", Offset = "0x9AE7540", VA = "0x189AE8540")]
		public static object AANGEPEQATD(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9AE91E0", Offset = "0x9AE81E0", VA = "0x189AE91E0")]
		public static GameObject DNHOCPETSBG(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9090", Offset = "0x9AE8090", VA = "0x189AE9090")]
		public static GameObject DNHOCPETSBG(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8E40", Offset = "0x9AE7E40", VA = "0x189AE8E40")]
		public static GameObject DNHOCPETSBG(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8F40", Offset = "0x9AE7F40", VA = "0x189AE8F40")]
		public static GameObject DNHOCPETSBG(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9A50", Offset = "0x9AE8A50", VA = "0x189AE9A50")]
		public static GameObject HPIGYAEHOJA(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9BA0", Offset = "0x9AE8BA0", VA = "0x189AE9BA0")]
		public static GameObject HPIGYAEHOJA(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE89D0", Offset = "0x9AE79D0", VA = "0x189AE89D0")]
		public static GameObject BQOMUKRVXZN(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8870", Offset = "0x9AE7870", VA = "0x189AE8870")]
		public static GameObject AXGQLDLEVNP(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB770", Offset = "0x9AEA770", VA = "0x189AEB770")]
		public static void VYDSHFUVAKM(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAD10", Offset = "0x9AE9D10", VA = "0x189AEAD10")]
		public static void QRWBTVIMCFD(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB250", Offset = "0x9AEA250", VA = "0x189AEB250")]
		public static GameObject TKGRGMJILUK(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB2F0", Offset = "0x9AEA2F0", VA = "0x189AEB2F0")]
		public static GameObject TKGRGMJILUK(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB010", Offset = "0x9AEA010", VA = "0x189AEB010")]
		public static GameObject TKGRGMJILUK(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAE90", Offset = "0x9AE9E90", VA = "0x189AEAE90")]
		public static GameObject[] SRLVMLJILOF(IList<XHNPIXFCEBC> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB600", Offset = "0x9AEA600", VA = "0x189AEB600")]
		public static void UPQRTKLMYGS(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8C60", Offset = "0x9AE7C60", VA = "0x189AE8C60")]
		public static void CUIMRRJTBAF(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9AE95D0", Offset = "0x9AE85D0", VA = "0x189AE95D0")]
		public static void FZAGUMQDXWE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA7A0", Offset = "0x9AE97A0", VA = "0x189AEA7A0")]
		public static float NZAZITBSOOS(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA700", Offset = "0x9AE9700", VA = "0x189AEA700")]
		public static DDFOJMMWCEL NVRBKRBHARX(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9930", Offset = "0x9AE8930", VA = "0x189AE9930")]
		public static DDFOJMMWCEL HJROMWQQMHF(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9D20", Offset = "0x9AE8D20", VA = "0x189AE9D20")]
		public static DDFOJMMWCEL IIBLULRPXTT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9AEBB20", Offset = "0x9AEAB20", VA = "0x189AEBB20")]
		public static IReadOnlyList<DDFOJMMWCEL> XRUBPDIOBYZ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAE00", Offset = "0x9AE9E00", VA = "0x189AEAE00")]
		public static IReadOnlyList<DDFOJMMWCEL> RJMAAMOFRUW(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAC10", Offset = "0x9AE9C10", VA = "0x189AEAC10")]
		public static void QATIHROFFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB500", Offset = "0x9AEA500", VA = "0x189AEB500")]
		public static bool TVXUEBNDIIZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9AEBA30", Offset = "0x9AEAA30", VA = "0x189AEBA30")]
		public static bool XAYFZNDMPKV(DDFOJMMWCEL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA500", Offset = "0x9AE9500", VA = "0x189AEA500")]
		public static bool MNLYZBGQWWU(NetworkEventCode a, object b, SVLVGVMSMLM c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA3D0", Offset = "0x9AE93D0", VA = "0x189AEA3D0")]
		public static bool MNLYZBGQWWU(byte a, object b, SVLVGVMSMLM c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB9B0", Offset = "0x9AEA9B0", VA = "0x189AEB9B0")]
		public static void WLCCVUQBECS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9650", Offset = "0x9AE8650", VA = "0x189AE9650")]
		public static void GHRXOLGFAHI(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9360", Offset = "0x9AE8360", VA = "0x189AE9360")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA0F0", Offset = "0x9AE90F0", VA = "0x189AEA0F0")]
		public static int LKLUPJTVVPG(VZMXLASXEMR a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9460", Offset = "0x9AE8460", VA = "0x189AE9460")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB6E0", Offset = "0x9AEA6E0", VA = "0x189AEB6E0")]
		public static void UWOMOYEFAIJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9AE97A0", Offset = "0x9AE87A0", VA = "0x189AE97A0")]
		public static int GSWHCWZIZRG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA350", Offset = "0x9AE9350", VA = "0x189AEA350")]
		public static void LXKDEQLOHDQ(IDLXRUJKSDP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB390", Offset = "0x9AEA390", VA = "0x189AEB390")]
		public static void TLLITJKMHBA(ZSDCJODNTRP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB410", Offset = "0x9AEA410", VA = "0x189AEB410")]
		public static string TVXKJNMIXSK(VZMXLASXEMR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8740", Offset = "0x9AE7740", VA = "0x189AE8740")]
		public static void ARTCSILUAKP(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8620", Offset = "0x9AE7620", VA = "0x189AE8620")]
		public static void ARTCSILUAKP(ViewId a, string b, DDFOJMMWCEL c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA010", Offset = "0x9AE9010", VA = "0x189AEA010")]
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
