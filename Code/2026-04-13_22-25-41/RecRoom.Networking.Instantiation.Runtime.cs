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
		[Cpp2IlInjected.Address(RVA = "0x99455B0", Offset = "0x9943FB0", VA = "0x1899455B0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, DDFOJMMWCEL creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99456F0", Offset = "0x99440F0", VA = "0x1899456F0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, DDFOJMMWCEL creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99453E0", Offset = "0x9943DE0", VA = "0x1899453E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9944DD0", Offset = "0x99437D0", VA = "0x189944DD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6AB0", VA = "0x180EC80B0")]
			internal Access(CMMGPHXWGYQ instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9944CD0", Offset = "0x99436D0", VA = "0x189944CD0")]
			public void OVNODQZWABG(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9944D50", Offset = "0x9943750", VA = "0x189944D50")]
			public void QIMLTSYMPZU(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
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
			[Cpp2IlInjected.Address(RVA = "0x99460C0", Offset = "0x9944AC0", VA = "0x1899460C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9945C30", Offset = "0x9944630", VA = "0x189945C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static FJAIXDTJXYY USMPVWLSWVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9946A20", Offset = "0x9945420", VA = "0x189946A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9948AC0", Offset = "0x99474C0", VA = "0x189948AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string FBLEUZHGBSR
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9946AF0", Offset = "0x99454F0", VA = "0x189946AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> GVTOYPAQOOO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x99467B0", Offset = "0x99451B0", VA = "0x1899467B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool GSQBWBASRMT
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9947E60", Offset = "0x9946860", VA = "0x189947E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool WBHADULSMJG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9947F60", Offset = "0x9946960", VA = "0x189947F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool TTKKFZXQVOV
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9947BF0", Offset = "0x99465F0", VA = "0x189947BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double FJTWFODLAKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9947CF0", Offset = "0x99466F0", VA = "0x189947CF0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int SZTBRXXLFHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9945FB0", Offset = "0x99449B0", VA = "0x189945FB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float BYZQWBMMOXX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x99474B0", Offset = "0x9945EB0", VA = "0x1899474B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9946B80", Offset = "0x9945580", VA = "0x189946B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool RXQOZDWSMOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9947C70", Offset = "0x9946670", VA = "0x189947C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static DDFOJMMWCEL SJQDIJZJGRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9948850", Offset = "0x9947250", VA = "0x189948850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static OHGZMIFYUNP XSMAXVAANWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9947930", Offset = "0x9946330", VA = "0x189947930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static DDFOJMMWCEL BTZMFQHTJQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9947B70", Offset = "0x9946570", VA = "0x189947B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static TMYXSDLHSTG LEIBVRTZQNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x99470E0", Offset = "0x9945AE0", VA = "0x1899470E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int VYQRBPMIUIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9947260", Offset = "0x9945C60", VA = "0x189947260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int KXSRXAWRJYB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9948260", Offset = "0x9946C60", VA = "0x189948260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int CUUWCKVTHZT
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x99471E0", Offset = "0x9945BE0", VA = "0x1899471E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string FKWCRQQXOPT
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9945E40", Offset = "0x9944840", VA = "0x189945E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long CSRBWDSDKFK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9947160", Offset = "0x9945B60", VA = "0x189947160")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long DJJZLUQCGTR
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x99475A0", Offset = "0x9945FA0", VA = "0x1899475A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool BNUXZSVAKQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9946CA0", Offset = "0x99456A0", VA = "0x189946CA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9948B90", Offset = "0x9947590", VA = "0x189948B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string UWMKAKYYDTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9948B30", Offset = "0x9947530", VA = "0x189948B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9947DE0", Offset = "0x99467E0", VA = "0x189947DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9946030", Offset = "0x9944A30", VA = "0x189946030")]
		public static Access CZTXPFZRHDL(CMMGPHXWGYQ a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9948060", Offset = "0x9946A60", VA = "0x189948060")]
		public static void RIUGUVBVZWR(XJMTDZCTHZH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9945810", Offset = "0x9944210", VA = "0x189945810")]
		public static object AANGEPEQATD(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99464B0", Offset = "0x9944EB0", VA = "0x1899464B0")]
		public static GameObject DNHOCPETSBG(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9946360", Offset = "0x9944D60", VA = "0x189946360")]
		public static GameObject DNHOCPETSBG(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9946110", Offset = "0x9944B10", VA = "0x189946110")]
		public static GameObject DNHOCPETSBG(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9946210", Offset = "0x9944C10", VA = "0x189946210")]
		public static GameObject DNHOCPETSBG(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9946D20", Offset = "0x9945720", VA = "0x189946D20")]
		public static GameObject HPIGYAEHOJA(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9946E70", Offset = "0x9945870", VA = "0x189946E70")]
		public static GameObject HPIGYAEHOJA(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9945CA0", Offset = "0x99446A0", VA = "0x189945CA0")]
		public static GameObject BQOMUKRVXZN(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9945B40", Offset = "0x9944540", VA = "0x189945B40")]
		public static GameObject AXGQLDLEVNP(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9948A40", Offset = "0x9947440", VA = "0x189948A40")]
		public static void VYDSHFUVAKM(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9947FE0", Offset = "0x99469E0", VA = "0x189947FE0")]
		public static void QRWBTVIMCFD(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9948520", Offset = "0x9946F20", VA = "0x189948520")]
		public static GameObject TKGRGMJILUK(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99485C0", Offset = "0x9946FC0", VA = "0x1899485C0")]
		public static GameObject TKGRGMJILUK(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x99482E0", Offset = "0x9946CE0", VA = "0x1899482E0")]
		public static GameObject TKGRGMJILUK(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9948160", Offset = "0x9946B60", VA = "0x189948160")]
		public static GameObject[] SRLVMLJILOF(IList<XHNPIXFCEBC> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99488D0", Offset = "0x99472D0", VA = "0x1899488D0")]
		public static void UPQRTKLMYGS(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9945F30", Offset = "0x9944930", VA = "0x189945F30")]
		public static void CUIMRRJTBAF(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99468A0", Offset = "0x99452A0", VA = "0x1899468A0")]
		public static void FZAGUMQDXWE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9947A70", Offset = "0x9946470", VA = "0x189947A70")]
		public static float NZAZITBSOOS(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x99479D0", Offset = "0x99463D0", VA = "0x1899479D0")]
		public static DDFOJMMWCEL NVRBKRBHARX(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9946C00", Offset = "0x9945600", VA = "0x189946C00")]
		public static DDFOJMMWCEL HJROMWQQMHF(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9946FF0", Offset = "0x99459F0", VA = "0x189946FF0")]
		public static DDFOJMMWCEL IIBLULRPXTT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9948DF0", Offset = "0x99477F0", VA = "0x189948DF0")]
		public static IReadOnlyList<DDFOJMMWCEL> XRUBPDIOBYZ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x99480D0", Offset = "0x9946AD0", VA = "0x1899480D0")]
		public static IReadOnlyList<DDFOJMMWCEL> RJMAAMOFRUW(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9947EE0", Offset = "0x99468E0", VA = "0x189947EE0")]
		public static void QATIHROFFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x99487D0", Offset = "0x99471D0", VA = "0x1899487D0")]
		public static bool TVXUEBNDIIZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9948D00", Offset = "0x9947700", VA = "0x189948D00")]
		public static bool XAYFZNDMPKV(DDFOJMMWCEL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x99477D0", Offset = "0x99461D0", VA = "0x1899477D0")]
		public static bool MNLYZBGQWWU(NetworkEventCode a, object b, SVLVGVMSMLM c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x99476A0", Offset = "0x99460A0", VA = "0x1899476A0")]
		public static bool MNLYZBGQWWU(byte a, object b, SVLVGVMSMLM c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9948C80", Offset = "0x9947680", VA = "0x189948C80")]
		public static void WLCCVUQBECS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9946920", Offset = "0x9945320", VA = "0x189946920")]
		public static void GHRXOLGFAHI(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9946630", Offset = "0x9945030", VA = "0x189946630")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x99473C0", Offset = "0x9945DC0", VA = "0x1899473C0")]
		public static int LKLUPJTVVPG(VZMXLASXEMR a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9946730", Offset = "0x9945130", VA = "0x189946730")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99489B0", Offset = "0x99473B0", VA = "0x1899489B0")]
		public static void UWOMOYEFAIJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9946A70", Offset = "0x9945470", VA = "0x189946A70")]
		public static int GSWHCWZIZRG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9947620", Offset = "0x9946020", VA = "0x189947620")]
		public static void LXKDEQLOHDQ(IDLXRUJKSDP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9948660", Offset = "0x9947060", VA = "0x189948660")]
		public static void TLLITJKMHBA(ZSDCJODNTRP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99486E0", Offset = "0x99470E0", VA = "0x1899486E0")]
		public static string TVXKJNMIXSK(VZMXLASXEMR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9945A10", Offset = "0x9944410", VA = "0x189945A10")]
		public static void ARTCSILUAKP(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x99458F0", Offset = "0x99442F0", VA = "0x1899458F0")]
		public static void ARTCSILUAKP(ViewId a, string b, DDFOJMMWCEL c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x99472E0", Offset = "0x9945CE0", VA = "0x1899472E0")]
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
