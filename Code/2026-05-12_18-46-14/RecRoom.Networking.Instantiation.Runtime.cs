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
	public interface DYMGEEOTUCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object QSDGBBCEJAR(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject NSVIGXTLRMI(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject TDURDYYELUS(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject VSSAJJZLDAL(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject NPUVTXCGDHP(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ATUADLKICVK(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZXTPYWKANEN(GameObject a);
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
		public JNIVCIZIPSX creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A8FC80", Offset = "0x9A8E680", VA = "0x189A8FC80")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, JNIVCIZIPSX creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A8FDC0", Offset = "0x9A8E7C0", VA = "0x189A8FDC0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, JNIVCIZIPSX creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A8FAB0", Offset = "0x9A8E4B0", VA = "0x189A8FAB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9A8F4D0", Offset = "0x9A8DED0", VA = "0x189A8F4D0")]
		public string KUNAITKLNHW()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface XMRYZCREGUZ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] XVPDBEITEUR(IList<YMVIVYMUDJC> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XQQHCVRXATC(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SAODVVLDAJL(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GWMBWNDIUDK();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class PEJBWBFHLBI
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly DYMGEEOTUCI instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xEF0480", Offset = "0xEEEE80", VA = "0x180EF0480")]
			internal Access(DYMGEEOTUCI instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9A8F450", Offset = "0x9A8DE50", VA = "0x189A8F450")]
			public void WSQREOFECOQ(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9A8F3D0", Offset = "0x9A8DDD0", VA = "0x189A8F3D0")]
			public void NXNVDHSDSNM(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
			private void RJZDJDFUTZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static DQCNOGDGYBL<PlayerId> VQUCMLMHCAE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static DQCNOGDGYBL<PlayerId> HAPPKPLVLUC;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static QOLRJJUHWXN TPTWEBAKSQF;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static DPRZTSPMFET<JNIVCIZIPSX, double, object> OVXUGYPTHZF;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static DQCNOGDGYBL<IReadOnlyList<InstantiateParameters>> DCBTQLYHBVU;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static DPMSWLVOVTK<GameObject, bool> TMADJKYSMSP;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static DQCNOGDGYBL<GameObject> DKLJJFTMIOB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static DQCNOGDGYBL<GameObject> RUFFHRXKQYQ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static DPMSWLVOVTK<int, int> XNRNHCOANNC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static BQUYOYJDJCS RETRFXLDHUR;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static DPCFBYHUCWS<string, ViewId, MSJSHKZSHXI, MSJSHKZSHXI> LPTFUJFVALJ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static DYMGEEOTUCI RZJDANIFHGB;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access BEECJNERPNI;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static XMRYZCREGUZ VBMYCSYUZGO;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static GJMXBPHDGRO NIOPXDXWCFR;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static GIWROPIUCYR VJTLLTIAEEO;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static XUYNAJRDAPT CANAESWJSLE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GJMXBPHDGRO QLLAUSYQAJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9A92170", Offset = "0x9A90B70", VA = "0x189A92170")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9A92F90", Offset = "0x9A91990", VA = "0x189A92F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static LWWFNSLLQUY SUQPFJEEJXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9A90510", Offset = "0x9A8EF10", VA = "0x189A90510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9A91D20", Offset = "0x9A90720", VA = "0x189A91D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string SNLRDKYBUZL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9A92E00", Offset = "0x9A91800", VA = "0x189A92E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> OGJELKEBEJM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9A93000", Offset = "0x9A91A00", VA = "0x189A93000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool HTAVRBTTHTB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9A903A0", Offset = "0x9A8EDA0", VA = "0x189A903A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool QCMQRXBGJQY
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9A92490", Offset = "0x9A90E90", VA = "0x189A92490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool XODKJJIQPOB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9A92610", Offset = "0x9A91010", VA = "0x189A92610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double FDWSQFUVLVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9A92080", Offset = "0x9A90A80", VA = "0x189A92080")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int HCVIRNYRRGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9A919A0", Offset = "0x9A903A0", VA = "0x189A919A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float HQPFACGNYVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9A90A40", Offset = "0x9A8F440", VA = "0x189A90A40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9A92510", Offset = "0x9A90F10", VA = "0x189A92510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool AUXCIJXMVYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9A91D90", Offset = "0x9A90790", VA = "0x189A91D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static JNIVCIZIPSX HPFZNTESQRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9A933B0", Offset = "0x9A91DB0", VA = "0x189A933B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static AWTHKFEHXLT XBEDGBSZWDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9A908A0", Offset = "0x9A8F2A0", VA = "0x189A908A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static JNIVCIZIPSX JXZBVLEPNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9A92590", Offset = "0x9A90F90", VA = "0x189A92590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static SYVXMVIVSMY VTIAYBVPVXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9A91B20", Offset = "0x9A90520", VA = "0x189A91B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int URLNDODXFES
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9A90B30", Offset = "0x9A8F530", VA = "0x189A90B30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int VXSCVTSQSQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9A91E10", Offset = "0x9A90810", VA = "0x189A91E10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int VIUXZCQAHFH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9A8FFD0", Offset = "0x9A8E9D0", VA = "0x189A8FFD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string FCRDZFKYZMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9A90DA0", Offset = "0x9A8F7A0", VA = "0x189A90DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long JBCXXGEZEAI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9A91AA0", Offset = "0x9A904A0", VA = "0x189A91AA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long SGHGDBQEDHR
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9A91920", Offset = "0x9A90320", VA = "0x189A91920")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool XHYYIVEOFJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9A91A20", Offset = "0x9A90420", VA = "0x189A91A20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9A91F90", Offset = "0x9A90990", VA = "0x189A91F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string JOKXWMWWNJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9A93260", Offset = "0x9A91C60", VA = "0x189A93260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9A90560", Offset = "0x9A8EF60", VA = "0x189A90560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9A90C20", Offset = "0x9A8F620", VA = "0x189A90C20")]
		public static Access JPUKXKRSAXT(DYMGEEOTUCI a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9A92D90", Offset = "0x9A91790", VA = "0x189A92D90")]
		public static void XSETPZGZTDD(XMRYZCREGUZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C30", Offset = "0x9A90630", VA = "0x189A91C30")]
		public static object QSDGBBCEJAR(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A91650", Offset = "0x9A90050", VA = "0x189A91650")]
		public static GameObject NSVIGXTLRMI(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A917D0", Offset = "0x9A901D0", VA = "0x189A917D0")]
		public static GameObject NSVIGXTLRMI(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9A91550", Offset = "0x9A8FF50", VA = "0x189A91550")]
		public static GameObject NSVIGXTLRMI(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9A91410", Offset = "0x9A8FE10", VA = "0x189A91410")]
		public static GameObject NSVIGXTLRMI(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9A921C0", Offset = "0x9A90BC0", VA = "0x189A921C0")]
		public static GameObject TDURDYYELUS(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A92310", Offset = "0x9A90D10", VA = "0x189A92310")]
		public static GameObject TDURDYYELUS(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9A92690", Offset = "0x9A91090", VA = "0x189A92690")]
		public static GameObject VSSAJJZLDAL(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A91320", Offset = "0x9A8FD20", VA = "0x189A91320")]
		public static GameObject NPUVTXCGDHP(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A8FE70", Offset = "0x9A8E870", VA = "0x189A8FE70")]
		public static void ATUADLKICVK(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A93330", Offset = "0x9A91D30", VA = "0x189A93330")]
		public static void ZXTPYWKANEN(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9A90FC0", Offset = "0x9A8F9C0", VA = "0x189A90FC0")]
		public static GameObject MOEHSOPNAYC(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9A90F20", Offset = "0x9A8F920", VA = "0x189A90F20")]
		public static GameObject MOEHSOPNAYC(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A91060", Offset = "0x9A8FA60", VA = "0x189A91060")]
		public static GameObject MOEHSOPNAYC(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9A92E80", Offset = "0x9A91880", VA = "0x189A92E80")]
		public static GameObject[] XVPDBEITEUR(IList<YMVIVYMUDJC> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A8FEF0", Offset = "0x9A8E8F0", VA = "0x189A8FEF0")]
		public static void AYYOCMMGQCW(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9A91E90", Offset = "0x9A90890", VA = "0x189A91E90")]
		public static void SAODVVLDAJL(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9A90940", Offset = "0x9A8F340", VA = "0x189A90940")]
		public static void GWMBWNDIUDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9A90CA0", Offset = "0x9A8F6A0", VA = "0x189A90CA0")]
		public static float KCLCQUXXBMW(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9A91BA0", Offset = "0x9A905A0", VA = "0x189A91BA0")]
		public static JNIVCIZIPSX QPJFGSUGGOJ(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9A90E90", Offset = "0x9A8F890", VA = "0x189A90E90")]
		public static JNIVCIZIPSX LFTZYTJFMLB(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9A90420", Offset = "0x9A8EE20", VA = "0x189A90420")]
		public static JNIVCIZIPSX ENKLWSKEEBX(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9A932B0", Offset = "0x9A91CB0", VA = "0x189A932B0")]
		public static IReadOnlyList<JNIVCIZIPSX> ZXOGAFLDDTP(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9A931E0", Offset = "0x9A91BE0", VA = "0x189A931E0")]
		public static IReadOnlyList<JNIVCIZIPSX> YENVYXZQREK(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9A905D0", Offset = "0x9A8EFD0", VA = "0x189A905D0")]
		public static void FRYZBTPERVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9A912A0", Offset = "0x9A8FCA0", VA = "0x189A912A0")]
		public static bool MTDTBHVFAVD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9A902B0", Offset = "0x9A8ECB0", VA = "0x189A902B0")]
		public static bool EKOJRVGZPFD(JNIVCIZIPSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9A92950", Offset = "0x9A91350", VA = "0x189A92950")]
		public static bool WDVHFRRPINS(NetworkEventCode a, object b, BJJNNDTQGRE c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9A92820", Offset = "0x9A91220", VA = "0x189A92820")]
		public static bool WDVHFRRPINS(byte a, object b, BJJNNDTQGRE c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9A909C0", Offset = "0x9A8F3C0", VA = "0x189A909C0")]
		public static void HBDIHWPLQAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9A92C90", Offset = "0x9A91690", VA = "0x189A92C90")]
		public static void XQIXCNAGDPI(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9A90050", Offset = "0x9A8EA50", VA = "0x189A90050")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9A92B20", Offset = "0x9A91520", VA = "0x189A92B20")]
		public static int WUPATQAEFXK(VZZVUJOFUEN a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9A90150", Offset = "0x9A8EB50", VA = "0x189A90150")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9A91F10", Offset = "0x9A90910", VA = "0x189A91F10")]
		public static void SENIMATDESJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9A92C10", Offset = "0x9A91610", VA = "0x189A92C10")]
		public static int XIGGYNIAFOY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9A90BB0", Offset = "0x9A8F5B0", VA = "0x189A90BB0")]
		public static void JEWGSAOJDUC(GIWROPIUCYR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9A92AB0", Offset = "0x9A914B0", VA = "0x189A92AB0")]
		public static void WEDANOOQEES(XUYNAJRDAPT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9A930F0", Offset = "0x9A91AF0", VA = "0x189A930F0")]
		public static string YBSXVDTPVWO(VZZVUJOFUEN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9A90770", Offset = "0x9A8F170", VA = "0x189A90770")]
		public static void GBHIYWZYOMP(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9A90650", Offset = "0x9A8F050", VA = "0x189A90650")]
		public static void GBHIYWZYOMP(ViewId a, string b, JNIVCIZIPSX c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9A901D0", Offset = "0x9A8EBD0", VA = "0x189A901D0")]
		public static void EGYYWDTTVPH(ViewId a)
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
