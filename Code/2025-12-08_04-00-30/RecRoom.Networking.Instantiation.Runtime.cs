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
		[Cpp2IlInjected.Address(RVA = "0x832D840", Offset = "0x832C040", VA = "0x18832D840")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, RHIZVYSCBOY creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x832D980", Offset = "0x832C180", VA = "0x18832D980")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, RHIZVYSCBOY creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x832D670", Offset = "0x832BE70", VA = "0x18832D670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x832D070", Offset = "0x832B870", VA = "0x18832D070")]
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
			[Cpp2IlInjected.Address(RVA = "0xBE9BA0", Offset = "0xBE83A0", VA = "0x180BE9BA0")]
			internal Access(CNTHVMZBCLF instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x832CF70", Offset = "0x832B770", VA = "0x18832CF70")]
			public void LDCDMCJDERP(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x832CFF0", Offset = "0x832B7F0", VA = "0x18832CFF0")]
			public void VMFTMDOUMDH(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
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
			[Cpp2IlInjected.Address(RVA = "0x8330730", Offset = "0x832EF30", VA = "0x188330730")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x832F430", Offset = "0x832DC30", VA = "0x18832F430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static QSDPZTMJSZX ERREOYPCBMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x832F170", Offset = "0x832D970", VA = "0x18832F170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x832FB80", Offset = "0x832E380", VA = "0x18832FB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string JYZHJSYXDZO
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x83302B0", Offset = "0x832EAB0", VA = "0x1883302B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> QOIGNJGQKDR
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x832FF50", Offset = "0x832E750", VA = "0x18832FF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool XJAIGZZAGJA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8330870", Offset = "0x832F070", VA = "0x188330870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool WPWIFVHTNVT
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x832F330", Offset = "0x832DB30", VA = "0x18832F330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool PYZZDBFOUFW
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x832E680", Offset = "0x832CE80", VA = "0x18832E680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double IHVIPGGUYKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x832F4A0", Offset = "0x832DCA0", VA = "0x18832F4A0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int MTVAKIARPWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x832DA30", Offset = "0x832C230", VA = "0x18832DA30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float JWAXPOVQAMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x832E590", Offset = "0x832CD90", VA = "0x18832E590")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool WMZXLLLZHRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x832DAB0", Offset = "0x832C2B0", VA = "0x18832DAB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool FOFSXANJMUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x832E510", Offset = "0x832CD10", VA = "0x18832E510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static RHIZVYSCBOY PMVKNQAWXFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8330120", Offset = "0x832E920", VA = "0x188330120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static ISFWAKUZEPE ELITNUVFCVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8330BB0", Offset = "0x832F3B0", VA = "0x188330BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static RHIZVYSCBOY GLCDPYRUWEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x832E700", Offset = "0x832CF00", VA = "0x18832E700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static EBJGVBBHQIT QCQONLGKDKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x83301A0", Offset = "0x832E9A0", VA = "0x1883301A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int VCXAFZVGVTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x832EFA0", Offset = "0x832D7A0", VA = "0x18832EFA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int RBQZXMROVWA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x832ED30", Offset = "0x832D530", VA = "0x18832ED30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int DVQYQLQZLVG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x832DE80", Offset = "0x832C680", VA = "0x18832DE80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string AGCQAPKCYIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x832FE60", Offset = "0x832E660", VA = "0x18832FE60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long DHHEZMWIWLX
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x832EEB0", Offset = "0x832D6B0", VA = "0x18832EEB0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long IGIEFPDQMUA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x832ECB0", Offset = "0x832D4B0", VA = "0x18832ECB0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool UWANCMYDEGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8330C50", Offset = "0x832F450", VA = "0x188330C50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x832F240", Offset = "0x832DA40", VA = "0x18832F240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string BVZEAQMQXMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x832F120", Offset = "0x832D920", VA = "0x18832F120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x83300B0", Offset = "0x832E8B0", VA = "0x1883300B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x832E180", Offset = "0x832C980", VA = "0x18832E180")]
		public static Access EUDXRAFFCPQ(CNTHVMZBCLF a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8330DD0", Offset = "0x832F5D0", VA = "0x188330DD0")]
		public static void YHVUEIZZGOC(OQNXQJTKCPY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x832F590", Offset = "0x832DD90", VA = "0x18832F590")]
		public static object OESLTFRNGVG(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x832F900", Offset = "0x832E100", VA = "0x18832F900")]
		public static GameObject OMZDXOLOKMR(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x832F670", Offset = "0x832DE70", VA = "0x18832F670")]
		public static GameObject OMZDXOLOKMR(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x832FA80", Offset = "0x832E280", VA = "0x18832FA80")]
		public static GameObject OMZDXOLOKMR(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x832F7C0", Offset = "0x832DFC0", VA = "0x18832F7C0")]
		public static GameObject OMZDXOLOKMR(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x832DD30", Offset = "0x832C530", VA = "0x18832DD30")]
		public static GameObject BYIMWJMKMSR(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x832DBB0", Offset = "0x832C3B0", VA = "0x18832DBB0")]
		public static GameObject BYIMWJMKMSR(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x832E780", Offset = "0x832CF80", VA = "0x18832E780")]
		public static GameObject HVFLYDJDGRK(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83308F0", Offset = "0x832F0F0", VA = "0x1883308F0")]
		public static GameObject TGBMEVFUOLQ(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8330030", Offset = "0x832E830", VA = "0x188330030")]
		public static void RFVZPLGLMBB(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8330330", Offset = "0x832EB30", VA = "0x188330330")]
		public static void STOGHCIVDZQ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83303B0", Offset = "0x832EBB0", VA = "0x1883303B0")]
		public static GameObject SVFHTZEAPKZ(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8330450", Offset = "0x832EC50", VA = "0x188330450")]
		public static GameObject SVFHTZEAPKZ(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83304F0", Offset = "0x832ECF0", VA = "0x1883304F0")]
		public static GameObject SVFHTZEAPKZ(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x832F020", Offset = "0x832D820", VA = "0x18832F020")]
		public static GameObject[] KQMOPPPQLKA(IList<MOFTTNXWVKL> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83309E0", Offset = "0x832F1E0", VA = "0x1883309E0")]
		public static void TPJUWFOOYPV(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x832E490", Offset = "0x832CC90", VA = "0x18832E490")]
		public static void FXNLMHIJMYS(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x832FCE0", Offset = "0x832E4E0", VA = "0x18832FCE0")]
		public static void PHEBUFUYYQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x832FD60", Offset = "0x832E560", VA = "0x18832FD60")]
		public static float PPMKBMQROAF(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8330220", Offset = "0x832EA20", VA = "0x188330220")]
		public static RHIZVYSCBOY SJIUPOGEBBK(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8330F30", Offset = "0x832F730", VA = "0x188330F30")]
		public static RHIZVYSCBOY ZTLORCAMYJM(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x832FBF0", Offset = "0x832E3F0", VA = "0x18832FBF0")]
		public static RHIZVYSCBOY PEMHOOUJDWE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8330CD0", Offset = "0x832F4D0", VA = "0x188330CD0")]
		public static IReadOnlyList<RHIZVYSCBOY> WUGFUOUENCY(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x832E100", Offset = "0x832C900", VA = "0x18832E100")]
		public static IReadOnlyList<RHIZVYSCBOY> EPWFEXXLCCP(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8330D50", Offset = "0x832F550", VA = "0x188330D50")]
		public static void XSTMLNTBPLW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x832F3B0", Offset = "0x832DBB0", VA = "0x18832F3B0")]
		public static bool NMTESVKHEGE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8330E40", Offset = "0x832F640", VA = "0x188330E40")]
		public static bool ZAFBIAEQUBO(RHIZVYSCBOY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x832E330", Offset = "0x832CB30", VA = "0x18832E330")]
		public static bool FMAEVNMOLAL(NetworkEventCode a, object b, TGLBYERUDJN c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x832E200", Offset = "0x832CA00", VA = "0x18832E200")]
		public static bool FMAEVNMOLAL(byte a, object b, TGLBYERUDJN c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x832DB30", Offset = "0x832C330", VA = "0x18832DB30")]
		public static void BWQHZFSPLEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x832EDB0", Offset = "0x832D5B0", VA = "0x18832EDB0")]
		public static void JVPEYACKYLR(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x832DF80", Offset = "0x832C780", VA = "0x18832DF80")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8330780", Offset = "0x832EF80", VA = "0x188330780")]
		public static int SZOLNZKQAFV(LWCFHEHHVPK a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x832E080", Offset = "0x832C880", VA = "0x18832E080")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x832DF00", Offset = "0x832C700", VA = "0x18832DF00")]
		public static void DOVHMIIOFOC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x832F1C0", Offset = "0x832D9C0", VA = "0x18832F1C0")]
		public static int NIWZMDLUCGN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x832EC40", Offset = "0x832D440", VA = "0x18832EC40")]
		public static void ISWSEBBVBDF(UHDZTADWSSQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x832EF30", Offset = "0x832D730", VA = "0x18832EF30")]
		public static void JZYJCUFZJHZ(DWTGDEAVLNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8330AC0", Offset = "0x832F2C0", VA = "0x188330AC0")]
		public static string TTHLELOONQR(LWCFHEHHVPK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x832EA30", Offset = "0x832D230", VA = "0x18832EA30")]
		public static void HYADYLYDQOK(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x832E910", Offset = "0x832D110", VA = "0x18832E910")]
		public static void HYADYLYDQOK(ViewId a, string b, RHIZVYSCBOY c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x832EB60", Offset = "0x832D360", VA = "0x18832EB60")]
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
