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
	public interface CNTHVMZBCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object OESLTFRNGVG(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject OMZDXOLOKMR(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject BYIMWJMKMSR(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject HVFLYDJDGRK(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject TGBMEVFUOLQ(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RFVZPLGLMBB(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void STOGHCIVDZQ(GameObject a);
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
		public RHIZVYSCBOY creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8430A90", Offset = "0x842F490", VA = "0x188430A90")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, RHIZVYSCBOY creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8430BD0", Offset = "0x842F5D0", VA = "0x188430BD0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, RHIZVYSCBOY creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84308C0", Offset = "0x842F2C0", VA = "0x1884308C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84302E0", Offset = "0x842ECE0", VA = "0x1884302E0")]
		public string EYKCNAQIQXP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface OQNXQJTKCPY
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] KQMOPPPQLKA(IList<MOFTTNXWVKL> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IMNKTNEZVMP(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FXNLMHIJMYS(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PHEBUFUYYQV();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class ROZEASBTKLN
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CNTHVMZBCLF instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xC00D90", Offset = "0xBFF790", VA = "0x180C00D90")]
			internal Access(CNTHVMZBCLF instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x84301E0", Offset = "0x842EBE0", VA = "0x1884301E0")]
			public void LDCDMCJDERP(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8430260", Offset = "0x842EC60", VA = "0x188430260")]
			public void VMFTMDOUMDH(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970")]
			private void SWWOLIUDYGF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static IXZHGEZUADS<PlayerId> BOCTLOMOIJX;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static IXZHGEZUADS<PlayerId> OACQALZKAWZ;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static RBZQPKLBXFW CURWTPTDQAO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static IYJVASNOTAK<RHIZVYSCBOY, double, object> XUPBDHMZPJW;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static IXZHGEZUADS<IReadOnlyList<InstantiateParameters>> ZZSCXICQZYZ;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static IYPBXZHMCLT<GameObject, bool> NNGABAMJSAI;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static IXZHGEZUADS<GameObject> SZBKCPPWLTU;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static IXZHGEZUADS<GameObject> KNWRXDPNXNV;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static IYPBXZHMCLT<int, int> VBOSKPJWJBZ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static MWKYWAOJZRV UNNVRDAPPCI;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static IXZHGEZUADS<string> FOZAJLPWEMC;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static CNTHVMZBCLF TUCNGOAVLEE;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access ECDGFGTEYTL;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static OQNXQJTKCPY MRHELUKULPJ;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static EYTSKUMVSDL AIRXWPASPIA;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static UHDZTADWSSQ KUVVNLSMPEZ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static DWTGDEAVLNW XRTOUONJFDL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static EYTSKUMVSDL REISKKLLDEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x84339A0", Offset = "0x84323A0", VA = "0x1884339A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8432690", Offset = "0x8431090", VA = "0x188432690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static QSDPZTMJSZX ERREOYPCBMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x84323D0", Offset = "0x8430DD0", VA = "0x1884323D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8432DE0", Offset = "0x84317E0", VA = "0x188432DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string JYZHJSYXDZO
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8433520", Offset = "0x8431F20", VA = "0x188433520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> QOIGNJGQKDR
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x84331B0", Offset = "0x8431BB0", VA = "0x1884331B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool XJAIGZZAGJA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8433AE0", Offset = "0x84324E0", VA = "0x188433AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool WPWIFVHTNVT
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8432590", Offset = "0x8430F90", VA = "0x188432590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool PYZZDBFOUFW
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x84318D0", Offset = "0x84302D0", VA = "0x1884318D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double IHVIPGGUYKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8432700", Offset = "0x8431100", VA = "0x188432700")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int MTVAKIARPWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8430C80", Offset = "0x842F680", VA = "0x188430C80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float JWAXPOVQAMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x84317E0", Offset = "0x84301E0", VA = "0x1884317E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool WMZXLLLZHRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8430D00", Offset = "0x842F700", VA = "0x188430D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool FOFSXANJMUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8431760", Offset = "0x8430160", VA = "0x188431760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static RHIZVYSCBOY PMVKNQAWXFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8433390", Offset = "0x8431D90", VA = "0x188433390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static ISFWAKUZEPE ELITNUVFCVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8433E20", Offset = "0x8432820", VA = "0x188433E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static RHIZVYSCBOY GLCDPYRUWEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8431950", Offset = "0x8430350", VA = "0x188431950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static EBJGVBBHQIT QCQONLGKDKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8433410", Offset = "0x8431E10", VA = "0x188433410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int VCXAFZVGVTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8432200", Offset = "0x8430C00", VA = "0x188432200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int RBQZXMROVWA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8431F90", Offset = "0x8430990", VA = "0x188431F90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int DVQYQLQZLVG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84310D0", Offset = "0x842FAD0", VA = "0x1884310D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string AGCQAPKCYIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x84330C0", Offset = "0x8431AC0", VA = "0x1884330C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long DHHEZMWIWLX
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8432110", Offset = "0x8430B10", VA = "0x188432110")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long IGIEFPDQMUA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8431F10", Offset = "0x8430910", VA = "0x188431F10")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool UWANCMYDEGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8433EC0", Offset = "0x84328C0", VA = "0x188433EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x84324A0", Offset = "0x8430EA0", VA = "0x1884324A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string BVZEAQMQXMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8432380", Offset = "0x8430D80", VA = "0x188432380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8433320", Offset = "0x8431D20", VA = "0x188433320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84313D0", Offset = "0x842FDD0", VA = "0x1884313D0")]
		public static Access EUDXRAFFCPQ(CNTHVMZBCLF a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8434040", Offset = "0x8432A40", VA = "0x188434040")]
		public static void YHVUEIZZGOC(OQNXQJTKCPY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84327F0", Offset = "0x84311F0", VA = "0x1884327F0")]
		public static object OESLTFRNGVG(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8432B60", Offset = "0x8431560", VA = "0x188432B60")]
		public static GameObject OMZDXOLOKMR(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84328D0", Offset = "0x84312D0", VA = "0x1884328D0")]
		public static GameObject OMZDXOLOKMR(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8432CE0", Offset = "0x84316E0", VA = "0x188432CE0")]
		public static GameObject OMZDXOLOKMR(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8432A20", Offset = "0x8431420", VA = "0x188432A20")]
		public static GameObject OMZDXOLOKMR(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8430F80", Offset = "0x842F980", VA = "0x188430F80")]
		public static GameObject BYIMWJMKMSR(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8430E00", Offset = "0x842F800", VA = "0x188430E00")]
		public static GameObject BYIMWJMKMSR(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84319D0", Offset = "0x84303D0", VA = "0x1884319D0")]
		public static GameObject HVFLYDJDGRK(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8433B60", Offset = "0x8432560", VA = "0x188433B60")]
		public static GameObject TGBMEVFUOLQ(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84332A0", Offset = "0x8431CA0", VA = "0x1884332A0")]
		public static void RFVZPLGLMBB(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84335A0", Offset = "0x8431FA0", VA = "0x1884335A0")]
		public static void STOGHCIVDZQ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8433620", Offset = "0x8432020", VA = "0x188433620")]
		public static GameObject SVFHTZEAPKZ(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84336C0", Offset = "0x84320C0", VA = "0x1884336C0")]
		public static GameObject SVFHTZEAPKZ(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8433760", Offset = "0x8432160", VA = "0x188433760")]
		public static GameObject SVFHTZEAPKZ(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8432280", Offset = "0x8430C80", VA = "0x188432280")]
		public static GameObject[] KQMOPPPQLKA(IList<MOFTTNXWVKL> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8433C50", Offset = "0x8432650", VA = "0x188433C50")]
		public static void TPJUWFOOYPV(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84316E0", Offset = "0x84300E0", VA = "0x1884316E0")]
		public static void FXNLMHIJMYS(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8432F40", Offset = "0x8431940", VA = "0x188432F40")]
		public static void PHEBUFUYYQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8432FC0", Offset = "0x84319C0", VA = "0x188432FC0")]
		public static float PPMKBMQROAF(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8433490", Offset = "0x8431E90", VA = "0x188433490")]
		public static RHIZVYSCBOY SJIUPOGEBBK(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84341A0", Offset = "0x8432BA0", VA = "0x1884341A0")]
		public static RHIZVYSCBOY ZTLORCAMYJM(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8432E50", Offset = "0x8431850", VA = "0x188432E50")]
		public static RHIZVYSCBOY PEMHOOUJDWE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8433F40", Offset = "0x8432940", VA = "0x188433F40")]
		public static IReadOnlyList<RHIZVYSCBOY> WUGFUOUENCY(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8431350", Offset = "0x842FD50", VA = "0x188431350")]
		public static IReadOnlyList<RHIZVYSCBOY> EPWFEXXLCCP(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8433FC0", Offset = "0x84329C0", VA = "0x188433FC0")]
		public static void XSTMLNTBPLW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8432610", Offset = "0x8431010", VA = "0x188432610")]
		public static bool NMTESVKHEGE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84340B0", Offset = "0x8432AB0", VA = "0x1884340B0")]
		public static bool ZAFBIAEQUBO(RHIZVYSCBOY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8431580", Offset = "0x842FF80", VA = "0x188431580")]
		public static bool FMAEVNMOLAL(NetworkEventCode a, object b, TGLBYERUDJN c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8431450", Offset = "0x842FE50", VA = "0x188431450")]
		public static bool FMAEVNMOLAL(byte a, object b, TGLBYERUDJN c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8430D80", Offset = "0x842F780", VA = "0x188430D80")]
		public static void BWQHZFSPLEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8432010", Offset = "0x8430A10", VA = "0x188432010")]
		public static void JVPEYACKYLR(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x84311D0", Offset = "0x842FBD0", VA = "0x1884311D0")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84339F0", Offset = "0x84323F0", VA = "0x1884339F0")]
		public static int SZOLNZKQAFV(LWCFHEHHVPK a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84312D0", Offset = "0x842FCD0", VA = "0x1884312D0")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8431150", Offset = "0x842FB50", VA = "0x188431150")]
		public static void DOVHMIIOFOC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8432420", Offset = "0x8430E20", VA = "0x188432420")]
		public static int NIWZMDLUCGN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8431EA0", Offset = "0x84308A0", VA = "0x188431EA0")]
		public static void ISWSEBBVBDF(UHDZTADWSSQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8432190", Offset = "0x8430B90", VA = "0x188432190")]
		public static void JZYJCUFZJHZ(DWTGDEAVLNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8433D30", Offset = "0x8432730", VA = "0x188433D30")]
		public static string TTHLELOONQR(LWCFHEHHVPK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8431C90", Offset = "0x8430690", VA = "0x188431C90")]
		public static void HYADYLYDQOK(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8431B70", Offset = "0x8430570", VA = "0x188431B70")]
		public static void HYADYLYDQOK(ViewId a, string b, RHIZVYSCBOY c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8431DC0", Offset = "0x84307C0", VA = "0x188431DC0")]
		public static void IINMLGXJFGC(ViewId a)
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
