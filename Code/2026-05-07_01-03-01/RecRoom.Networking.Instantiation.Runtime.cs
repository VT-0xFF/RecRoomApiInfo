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
		[Cpp2IlInjected.Address(RVA = "0x992CA90", Offset = "0x992B490", VA = "0x18992CA90")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, JNIVCIZIPSX creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x992CBD0", Offset = "0x992B5D0", VA = "0x18992CBD0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, JNIVCIZIPSX creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x992C8C0", Offset = "0x992B2C0", VA = "0x18992C8C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x992C2D0", Offset = "0x992ACD0", VA = "0x18992C2D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEBA9B0", Offset = "0xEB93B0", VA = "0x180EBA9B0")]
			internal Access(DYMGEEOTUCI instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x992C250", Offset = "0x992AC50", VA = "0x18992C250")]
			public void WSQREOFECOQ(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x992C1D0", Offset = "0x992ABD0", VA = "0x18992C1D0")]
			public void NXNVDHSDSNM(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x992EFE0", Offset = "0x992D9E0", VA = "0x18992EFE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x992FE20", Offset = "0x992E820", VA = "0x18992FE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static LWWFNSLLQUY SUQPFJEEJXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x992D320", Offset = "0x992BD20", VA = "0x18992D320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x992EB80", Offset = "0x992D580", VA = "0x18992EB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string SNLRDKYBUZL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x992FC90", Offset = "0x992E690", VA = "0x18992FC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> OGJELKEBEJM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x992FE90", Offset = "0x992E890", VA = "0x18992FE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool HTAVRBTTHTB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x992D1B0", Offset = "0x992BBB0", VA = "0x18992D1B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool QCMQRXBGJQY
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x992F300", Offset = "0x992DD00", VA = "0x18992F300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool XODKJJIQPOB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x992F480", Offset = "0x992DE80", VA = "0x18992F480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double FDWSQFUVLVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x992EEF0", Offset = "0x992D8F0", VA = "0x18992EEF0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int HCVIRNYRRGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x992E800", Offset = "0x992D200", VA = "0x18992E800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float HQPFACGNYVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x992D860", Offset = "0x992C260", VA = "0x18992D860")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x992F380", Offset = "0x992DD80", VA = "0x18992F380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool AUXCIJXMVYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x992EBF0", Offset = "0x992D5F0", VA = "0x18992EBF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static JNIVCIZIPSX HPFZNTESQRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9930270", Offset = "0x992EC70", VA = "0x189930270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static AWTHKFEHXLT XBEDGBSZWDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x992D6C0", Offset = "0x992C0C0", VA = "0x18992D6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static JNIVCIZIPSX JXZBVLEPNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x992F400", Offset = "0x992DE00", VA = "0x18992F400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static SYVXMVIVSMY VTIAYBVPVXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x992E980", Offset = "0x992D380", VA = "0x18992E980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int URLNDODXFES
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x992D950", Offset = "0x992C350", VA = "0x18992D950")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int VXSCVTSQSQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x992EC70", Offset = "0x992D670", VA = "0x18992EC70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int VIUXZCQAHFH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x992CDE0", Offset = "0x992B7E0", VA = "0x18992CDE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string FCRDZFKYZMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x992DBE0", Offset = "0x992C5E0", VA = "0x18992DBE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long JBCXXGEZEAI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x992E900", Offset = "0x992D300", VA = "0x18992E900")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long SGHGDBQEDHR
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x992E780", Offset = "0x992D180", VA = "0x18992E780")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool XHYYIVEOFJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x992E880", Offset = "0x992D280", VA = "0x18992E880")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x992EE00", Offset = "0x992D800", VA = "0x18992EE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string JOKXWMWWNJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9930100", Offset = "0x992EB00", VA = "0x189930100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x992D370", Offset = "0x992BD70", VA = "0x18992D370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x992DA50", Offset = "0x992C450", VA = "0x18992DA50")]
		public static Access JPUKXKRSAXT(DYMGEEOTUCI a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x992FC20", Offset = "0x992E620", VA = "0x18992FC20")]
		public static void XSETPZGZTDD(XMRYZCREGUZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x992EAA0", Offset = "0x992D4A0", VA = "0x18992EAA0")]
		public static object QSDGBBCEJAR(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x992E4B0", Offset = "0x992CEB0", VA = "0x18992E4B0")]
		public static GameObject NSVIGXTLRMI(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x992E630", Offset = "0x992D030", VA = "0x18992E630")]
		public static GameObject NSVIGXTLRMI(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x992E3B0", Offset = "0x992CDB0", VA = "0x18992E3B0")]
		public static GameObject NSVIGXTLRMI(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x992E260", Offset = "0x992CC60", VA = "0x18992E260")]
		public static GameObject NSVIGXTLRMI(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x992F030", Offset = "0x992DA30", VA = "0x18992F030")]
		public static GameObject TDURDYYELUS(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x992F180", Offset = "0x992DB80", VA = "0x18992F180")]
		public static GameObject TDURDYYELUS(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x992F500", Offset = "0x992DF00", VA = "0x18992F500")]
		public static GameObject VSSAJJZLDAL(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x992E170", Offset = "0x992CB70", VA = "0x18992E170")]
		public static GameObject NPUVTXCGDHP(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x992CC80", Offset = "0x992B680", VA = "0x18992CC80")]
		public static void ATUADLKICVK(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99301F0", Offset = "0x992EBF0", VA = "0x1899301F0")]
		public static void ZXTPYWKANEN(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x992DE10", Offset = "0x992C810", VA = "0x18992DE10")]
		public static GameObject MOEHSOPNAYC(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x992DD70", Offset = "0x992C770", VA = "0x18992DD70")]
		public static GameObject MOEHSOPNAYC(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x992DEB0", Offset = "0x992C8B0", VA = "0x18992DEB0")]
		public static GameObject MOEHSOPNAYC(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x992FD20", Offset = "0x992E720", VA = "0x18992FD20")]
		public static GameObject[] XVPDBEITEUR(IList<YMVIVYMUDJC> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x992CD00", Offset = "0x992B700", VA = "0x18992CD00")]
		public static void AYYOCMMGQCW(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x992ECF0", Offset = "0x992D6F0", VA = "0x18992ECF0")]
		public static void SAODVVLDAJL(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x992D760", Offset = "0x992C160", VA = "0x18992D760")]
		public static void GWMBWNDIUDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x992DAE0", Offset = "0x992C4E0", VA = "0x18992DAE0")]
		public static float KCLCQUXXBMW(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x992EA00", Offset = "0x992D400", VA = "0x18992EA00")]
		public static JNIVCIZIPSX QPJFGSUGGOJ(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x992DCD0", Offset = "0x992C6D0", VA = "0x18992DCD0")]
		public static JNIVCIZIPSX LFTZYTJFMLB(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x992D230", Offset = "0x992BC30", VA = "0x18992D230")]
		public static JNIVCIZIPSX ENKLWSKEEBX(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9930160", Offset = "0x992EB60", VA = "0x189930160")]
		public static IReadOnlyList<JNIVCIZIPSX> ZXOGAFLDDTP(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9930070", Offset = "0x992EA70", VA = "0x189930070")]
		public static IReadOnlyList<JNIVCIZIPSX> YENVYXZQREK(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x992D3F0", Offset = "0x992BDF0", VA = "0x18992D3F0")]
		public static void FRYZBTPERVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x992E0F0", Offset = "0x992CAF0", VA = "0x18992E0F0")]
		public static bool MTDTBHVFAVD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x992D0C0", Offset = "0x992BAC0", VA = "0x18992D0C0")]
		public static bool EKOJRVGZPFD(JNIVCIZIPSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x992F7D0", Offset = "0x992E1D0", VA = "0x18992F7D0")]
		public static bool WDVHFRRPINS(NetworkEventCode a, object b, BJJNNDTQGRE c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x992F6A0", Offset = "0x992E0A0", VA = "0x18992F6A0")]
		public static bool WDVHFRRPINS(byte a, object b, BJJNNDTQGRE c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x992D7E0", Offset = "0x992C1E0", VA = "0x18992D7E0")]
		public static void HBDIHWPLQAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x992FB20", Offset = "0x992E520", VA = "0x18992FB20")]
		public static void XQIXCNAGDPI(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x992CE60", Offset = "0x992B860", VA = "0x18992CE60")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x992F9B0", Offset = "0x992E3B0", VA = "0x18992F9B0")]
		public static int WUPATQAEFXK(VZZVUJOFUEN a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x992CF60", Offset = "0x992B960", VA = "0x18992CF60")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x992ED70", Offset = "0x992D770", VA = "0x18992ED70")]
		public static void SENIMATDESJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x992FAA0", Offset = "0x992E4A0", VA = "0x18992FAA0")]
		public static int XIGGYNIAFOY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x992D9D0", Offset = "0x992C3D0", VA = "0x18992D9D0")]
		public static void JEWGSAOJDUC(GIWROPIUCYR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x992F930", Offset = "0x992E330", VA = "0x18992F930")]
		public static void WEDANOOQEES(XUYNAJRDAPT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x992FF80", Offset = "0x992E980", VA = "0x18992FF80")]
		public static string YBSXVDTPVWO(VZZVUJOFUEN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x992D590", Offset = "0x992BF90", VA = "0x18992D590")]
		public static void GBHIYWZYOMP(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x992D470", Offset = "0x992BE70", VA = "0x18992D470")]
		public static void GBHIYWZYOMP(ViewId a, string b, JNIVCIZIPSX c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x992CFE0", Offset = "0x992B9E0", VA = "0x18992CFE0")]
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
