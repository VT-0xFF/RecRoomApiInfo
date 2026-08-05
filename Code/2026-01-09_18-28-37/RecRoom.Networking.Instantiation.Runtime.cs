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
	public interface FWTQFOILGZM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object HEHPBGVRCBN(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject VXTPEUYWEZY(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject GADGCWIMAZO(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject RGWTUPBOITX(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject RXVMAPPLRBR(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YGZWQAPIGOW(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VGDCPDBFQLV(GameObject a);
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
		public JDMCEZTJJPL creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82FDC10", Offset = "0x82FD010", VA = "0x1882FDC10")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, JDMCEZTJJPL creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82FDD50", Offset = "0x82FD150", VA = "0x1882FDD50")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, JDMCEZTJJPL creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82FD440", Offset = "0x82FC840", VA = "0x1882FD440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82FD610", Offset = "0x82FCA10", VA = "0x1882FD610")]
		public string XYHJAHMDEOW()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface HEFHPDCQXLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] UYBGEZTVJTF(IList<XHCLQKPGUUK> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BRZQZAKPLGW(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PEVSKVLMZUL(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HKVDEQAWIXA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class LFQHFZSIJVO
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly FWTQFOILGZM instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
			internal Access(FWTQFOILGZM instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x82FD3C0", Offset = "0x82FC7C0", VA = "0x1882FD3C0")]
			public void OZFAWIMPWKC(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x82FD340", Offset = "0x82FC740", VA = "0x1882FD340")]
			public void FIQLWNRRKKE(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			private void TSVKWXHKQFE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static JQSJODDDNWT<PlayerId> VHYMICAOHGO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static JQSJODDDNWT<PlayerId> MIXVNGMVYCM;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static CZHRKLOONYV GIVLEVMQLMD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static JRCXIQQYGTL<JDMCEZTJJPL, double, object> BQJSNFTKYJX;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static JQSJODDDNWT<IReadOnlyList<InstantiateParameters>> OTLHNJXXQUA;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static JQXQLJXAXIC<GameObject, bool> VWPSIIMKRWR;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static JQSJODDDNWT<GameObject> FZTNWFKLWVZ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static JQSJODDDNWT<GameObject> JGMEIWPSNBU;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static JQXQLJXAXIC<int, int> ZGKSLCIUWZE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static OAGBKHNZSHS EGOSZPJQVSP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static JQSJODDDNWT<string> FUBVXYJLTPL;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static FWTQFOILGZM PFCQAQYYUBN;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access LPELPVUXGXO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static HEFHPDCQXLF KLUUUWZEUWU;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static FJBTJQJTDMS KXHAWPMIEYV;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static RXXIMXLCZOP THXJFJHLCRO;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static VDKRNXNUNIH LAAZSOUINVC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static FJBTJQJTDMS HFZUWBQPBMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8300F80", Offset = "0x8300380", VA = "0x188300F80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x82FF080", Offset = "0x82FE480", VA = "0x1882FF080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static SVKRPIPTYHQ PXLLWXTEXQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x82FF760", Offset = "0x82FEB60", VA = "0x1882FF760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x82FF280", Offset = "0x82FE680", VA = "0x1882FF280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string BUBWNBKLBDZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x83004F0", Offset = "0x82FF8F0", VA = "0x1883004F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> DELRXHQSZWE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x82FF8B0", Offset = "0x82FECB0", VA = "0x1882FF8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool YVKUPGIHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x82FFA20", Offset = "0x82FEE20", VA = "0x1882FFA20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool KUKFFKPNXHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x82FF830", Offset = "0x82FEC30", VA = "0x1882FF830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool NXESLNJEKWD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x82FE770", Offset = "0x82FDB70", VA = "0x1882FE770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double PWJOZWENEPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x82FFB90", Offset = "0x82FEF90", VA = "0x1882FFB90")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int PYECVYCRKRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x82FE260", Offset = "0x82FD660", VA = "0x1882FE260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float NCOWJQSVQBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x82FEF90", Offset = "0x82FE390", VA = "0x1882FEF90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool NNHLGBZZREX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8301050", Offset = "0x8300450", VA = "0x188301050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool TNUEXNIXSIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x82FDE00", Offset = "0x82FD200", VA = "0x1882FDE00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static JDMCEZTJJPL ATXPJDRAYLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8300700", Offset = "0x82FFB00", VA = "0x188300700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static KKQZYLYABIX UECZEWVYIJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x82FF470", Offset = "0x82FE870", VA = "0x1882FF470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static JDMCEZTJJPL WAADNJMXZVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8300E80", Offset = "0x8300280", VA = "0x188300E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static SGADDYGXITE UDNHRLEJSIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x82FF7B0", Offset = "0x82FEBB0", VA = "0x1882FF7B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int EBFFPTPFDWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x83011C0", Offset = "0x83005C0", VA = "0x1883011C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int CLHHXEZZWFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x82FF0F0", Offset = "0x82FE4F0", VA = "0x1882FF0F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int XICOJONBSOH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x82FFC80", Offset = "0x82FF080", VA = "0x1882FFC80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string CPMAYLUDGOX
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x82FE680", Offset = "0x82FDA80", VA = "0x1882FE680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long WVLAIOEFBRM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8300F00", Offset = "0x8300300", VA = "0x188300F00")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long WEGDHIHMXXP
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x82FF3F0", Offset = "0x82FE7F0", VA = "0x1882FF3F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool QQHOUZQFUEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x82FFD00", Offset = "0x82FF100", VA = "0x1882FFD00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8300380", Offset = "0x82FF780", VA = "0x188300380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string UBXVARBQNLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x82FE630", Offset = "0x82FDA30", VA = "0x1882FE630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x82FED60", Offset = "0x82FE160", VA = "0x1882FED60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8300570", Offset = "0x82FF970", VA = "0x188300570")]
		public static Access TPKVCAESQYH(FWTQFOILGZM a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8300800", Offset = "0x82FFC00", VA = "0x188300800")]
		public static void VGSDJEBWZDZ(HEFHPDCQXLF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82FE870", Offset = "0x82FDC70", VA = "0x1882FE870")]
		public static object HEHPBGVRCBN(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83008F0", Offset = "0x82FFCF0", VA = "0x1883008F0")]
		public static GameObject VXTPEUYWEZY(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8300A70", Offset = "0x82FFE70", VA = "0x188300A70")]
		public static GameObject VXTPEUYWEZY(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8300BC0", Offset = "0x82FFFC0", VA = "0x188300BC0")]
		public static GameObject VXTPEUYWEZY(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8300CC0", Offset = "0x83000C0", VA = "0x188300CC0")]
		public static GameObject VXTPEUYWEZY(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82FE4E0", Offset = "0x82FD8E0", VA = "0x1882FE4E0")]
		public static GameObject GADGCWIMAZO(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82FE360", Offset = "0x82FD760", VA = "0x1882FE360")]
		public static GameObject GADGCWIMAZO(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82FFD80", Offset = "0x82FF180", VA = "0x1882FFD80")]
		public static GameObject RGWTUPBOITX(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83001A0", Offset = "0x82FF5A0", VA = "0x1883001A0")]
		public static GameObject RXVMAPPLRBR(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8300FD0", Offset = "0x83003D0", VA = "0x188300FD0")]
		public static void YGZWQAPIGOW(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8300780", Offset = "0x82FFB80", VA = "0x188300780")]
		public static void VGDCPDBFQLV(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82FECC0", Offset = "0x82FE0C0", VA = "0x1882FECC0")]
		public static GameObject HWWLZSXUWVW(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82FEC20", Offset = "0x82FE020", VA = "0x1882FEC20")]
		public static GameObject HWWLZSXUWVW(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82FE9E0", Offset = "0x82FDDE0", VA = "0x1882FE9E0")]
		public static GameObject HWWLZSXUWVW(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83005F0", Offset = "0x82FF9F0", VA = "0x1883005F0")]
		public static GameObject[] UYBGEZTVJTF(IList<XHCLQKPGUUK> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x82FEEB0", Offset = "0x82FE2B0", VA = "0x1882FEEB0")]
		public static void IJPRIUXRAGE(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x82FF9A0", Offset = "0x82FEDA0", VA = "0x1882FF9A0")]
		public static void PEVSKVLMZUL(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82FE960", Offset = "0x82FDD60", VA = "0x1882FE960")]
		public static void HKVDEQAWIXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x83012C0", Offset = "0x83006C0", VA = "0x1883012C0")]
		public static float ZMJEKUPBOCY(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82FDEF0", Offset = "0x82FD2F0", VA = "0x1882FDEF0")]
		public static JDMCEZTJJPL AXKECTMWIPJ(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82FF170", Offset = "0x82FE570", VA = "0x1882FF170")]
		public static JDMCEZTJJPL KUEAEYKQWYB(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82FDFF0", Offset = "0x82FD3F0", VA = "0x1882FDFF0")]
		public static JDMCEZTJJPL BWJVQKHOOPV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82FF200", Offset = "0x82FE600", VA = "0x1882FF200")]
		public static IReadOnlyList<JDMCEZTJJPL> LHUDOEWVJML(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82FE2E0", Offset = "0x82FD6E0", VA = "0x1882FE2E0")]
		public static IReadOnlyList<JDMCEZTJJPL> FOWULWAMWJG(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8300870", Offset = "0x82FFC70", VA = "0x188300870")]
		public static void VKBPCVPZFDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8300470", Offset = "0x82FF870", VA = "0x188300470")]
		public static bool SWLDCUCEBTR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83010D0", Offset = "0x83004D0", VA = "0x1883010D0")]
		public static bool YTOMNAYGQHJ(JDMCEZTJJPL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8300040", Offset = "0x82FF440", VA = "0x188300040")]
		public static bool RMUNMYUOKTM(NetworkEventCode a, object b, YTJXGECMSCM c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x82FFF10", Offset = "0x82FF310", VA = "0x1882FFF10")]
		public static bool RMUNMYUOKTM(byte a, object b, YTJXGECMSCM c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8301240", Offset = "0x8300640", VA = "0x188301240")]
		public static void ZGQUGHVETQI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x82FF2F0", Offset = "0x82FE6F0", VA = "0x1882FF2F0")]
		public static void MFMKHXDBDDO(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x82FE0E0", Offset = "0x82FD4E0", VA = "0x1882FE0E0")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8300290", Offset = "0x82FF690", VA = "0x188300290")]
		public static int SKHAHUUEXGW(LEKSKUSYOLN a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x82FE1E0", Offset = "0x82FD5E0", VA = "0x1882FE1E0")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8300E00", Offset = "0x8300200", VA = "0x188300E00")]
		public static void WKIPQRQFQVV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x82FE7F0", Offset = "0x82FDBF0", VA = "0x1882FE7F0")]
		public static int HDUKFLTPEPY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x82FDF80", Offset = "0x82FD380", VA = "0x1882FDF80")]
		public static void BDEZOABABJK(RXXIMXLCZOP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x82FDE80", Offset = "0x82FD280", VA = "0x1882FDE80")]
		public static void AXJKMDFPVUE(VDKRNXNUNIH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x82FFAA0", Offset = "0x82FEEA0", VA = "0x1882FFAA0")]
		public static string PSIFCWHALQI(LEKSKUSYOLN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x82FF630", Offset = "0x82FEA30", VA = "0x1882FF630")]
		public static void NOXIPLYUNFT(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x82FF510", Offset = "0x82FE910", VA = "0x1882FF510")]
		public static void NOXIPLYUNFT(ViewId a, string b, JDMCEZTJJPL c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x82FEDD0", Offset = "0x82FE1D0", VA = "0x1882FEDD0")]
		public static void IHGGUYMASUX(ViewId a)
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
