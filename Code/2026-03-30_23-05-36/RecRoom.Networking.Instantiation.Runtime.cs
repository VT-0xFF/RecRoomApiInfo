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
	public interface NBZWTRIOJCY
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object QGLOSNKWLWR(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject ZTSJAYUMRWI(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject WZSREOSJGCO(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject IBKIFCCNDEX(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject ZSKVPXJXVNP(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XCQEFRADGDS(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MOWIBDGNWNT(GameObject a);
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
		public VPDKWOIWOKH creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x860F900", Offset = "0x860E700", VA = "0x18860F900")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, VPDKWOIWOKH creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x860FA40", Offset = "0x860E840", VA = "0x18860FA40")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, VPDKWOIWOKH creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x860F730", Offset = "0x860E530", VA = "0x18860F730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x860F140", Offset = "0x860DF40", VA = "0x18860F140")]
		public string ONHSGHZHGZK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface EBKUUXIAFON
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] TKGKZRXLWCR(IList<NREMRRGPTYQ> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QKLDBTDFSLW(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KMZXWOIDZWR(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LYVHXJISEKY();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class OOYJLNUGIIK
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly NBZWTRIOJCY instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xC9F870", Offset = "0xC9E670", VA = "0x180C9F870")]
			internal Access(NBZWTRIOJCY instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x860F0C0", Offset = "0x860DEC0", VA = "0x18860F0C0")]
			public void OEENHAKQKLC(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x860F040", Offset = "0x860DE40", VA = "0x18860F040")]
			public void LRUCJYLWVZE(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			private void JGXJMZWUSAU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static OPVLFDQAAOV<PlayerId> VNCIBQBQLLO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static OPVLFDQAAOV<PlayerId> PUKSEJKYVAO;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static XLEOHGCTFCX AXWNTMOWDGB;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static OPKXKQCFHSD<VPDKWOIWOKH, double, object> EEYTDWOSUDB;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static OPVLFDQAAOV<IReadOnlyList<InstantiateParameters>> KCXVDOMBEMO;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static OPFQNJIHYGU<GameObject, bool> WWWUUADZUBF;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static OPVLFDQAAOV<GameObject> PFJISCKHDCB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static OPVLFDQAAOV<GameObject> DXBVUKQRDZG;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static OPFQNJIHYGU<int, int> NUUHTIZCVKE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static KMRHHFCXZOG BEJWGKFVSLD;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static OQLFWXXSCWW<string, ViewId, RLYALOWBZTU, RLYALOWBZTU> CZGPFDOCMRJ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static NBZWTRIOJCY HVHHXPRKGCZ;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access UOFIZYUUVKC;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static EBKUUXIAFON NGVMTASCSRA;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static UEDVAHKWDQA MHJBCAAMUIH;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static OLPMYWFCPDT XFCAIILTWOW;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static EEZZQHVLTFP MIRBIJWOPTE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static UEDVAHKWDQA IIYZRMEAYCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8612890", Offset = "0x8611690", VA = "0x188612890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8610600", Offset = "0x860F400", VA = "0x188610600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static JRYRPDDDIRS LPAZFBWKSEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8611920", Offset = "0x8610720", VA = "0x188611920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8610200", Offset = "0x860F000", VA = "0x188610200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string VIGTCHTUOMR
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8610F60", Offset = "0x860FD60", VA = "0x188610F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> ZESILIZXVHY
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x86107F0", Offset = "0x860F5F0", VA = "0x1886107F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool FGMRXODRKSD
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8610EE0", Offset = "0x860FCE0", VA = "0x188610EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool KVOUUGVQXBS
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x86120C0", Offset = "0x8610EC0", VA = "0x1886120C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool JBSWEGEPCHH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8612040", Offset = "0x8610E40", VA = "0x188612040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double GHQGUQBAJXX
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8610D70", Offset = "0x860FB70", VA = "0x188610D70")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int PKBGQGHWHZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x860FD10", Offset = "0x860EB10", VA = "0x18860FD10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float HFQUATRYBVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x86128E0", Offset = "0x86116E0", VA = "0x1886128E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool RNZDFTPHIPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8610670", Offset = "0x860F470", VA = "0x188610670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool ZXAOFJZIORO
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x860FAF0", Offset = "0x860E8F0", VA = "0x18860FAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static VPDKWOIWOKH FPSVGSDUQWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8611560", Offset = "0x8610360", VA = "0x188611560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static KGEHLOHZDIF MXGWLWGZCTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8610CD0", Offset = "0x860FAD0", VA = "0x188610CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static VPDKWOIWOKH XJNTGLSKVAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x86114E0", Offset = "0x86102E0", VA = "0x1886114E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static NMWOLULISIU CAVGFSGAPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8610360", Offset = "0x860F160", VA = "0x188610360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int FVMYAJFTKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8610100", Offset = "0x860EF00", VA = "0x188610100")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int OHVMEOMTZFH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x86129D0", Offset = "0x86117D0", VA = "0x1886129D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int CZTWRHSAPAN
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x86124C0", Offset = "0x86112C0", VA = "0x1886124C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string OBLVSIZHUAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x86123D0", Offset = "0x86111D0", VA = "0x1886123D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long SBOEJWJVIHG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8610580", Offset = "0x860F380", VA = "0x188610580")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long NFZYKYPTHHV
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8610770", Offset = "0x860F570", VA = "0x188610770")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool KLLVSIWGTUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8611A00", Offset = "0x8610800", VA = "0x188611A00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8611CD0", Offset = "0x8610AD0", VA = "0x188611CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string OHVOTISXPZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8611E50", Offset = "0x8610C50", VA = "0x188611E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x860FE80", Offset = "0x860EC80", VA = "0x18860FE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8611970", Offset = "0x8610770", VA = "0x188611970")]
		public static Access RJQALGSVKSB(NBZWTRIOJCY a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8611070", Offset = "0x860FE70", VA = "0x188611070")]
		public static void MVYKNNJWUVP(EBKUUXIAFON a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8611670", Offset = "0x8610470", VA = "0x188611670")]
		public static object QGLOSNKWLWR(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8612FE0", Offset = "0x8611DE0", VA = "0x188612FE0")]
		public static GameObject ZTSJAYUMRWI(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8612D90", Offset = "0x8611B90", VA = "0x188612D90")]
		public static GameObject ZTSJAYUMRWI(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8612EE0", Offset = "0x8611CE0", VA = "0x188612EE0")]
		public static GameObject ZTSJAYUMRWI(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8612C40", Offset = "0x8611A40", VA = "0x188612C40")]
		public static GameObject ZTSJAYUMRWI(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86126C0", Offset = "0x86114C0", VA = "0x1886126C0")]
		public static GameObject WZSREOSJGCO(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8612540", Offset = "0x8611340", VA = "0x188612540")]
		public static GameObject WZSREOSJGCO(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x86103E0", Offset = "0x860F1E0", VA = "0x1886103E0")]
		public static GameObject IBKIFCCNDEX(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8612B50", Offset = "0x8611950", VA = "0x188612B50")]
		public static GameObject ZSKVPXJXVNP(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8612810", Offset = "0x8611610", VA = "0x188612810")]
		public static void XCQEFRADGDS(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8610FF0", Offset = "0x860FDF0", VA = "0x188610FF0")]
		public static void MOWIBDGNWNT(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86113C0", Offset = "0x86101C0", VA = "0x1886113C0")]
		public static GameObject NDYPEJRJWSC(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86110E0", Offset = "0x860FEE0", VA = "0x1886110E0")]
		public static GameObject NDYPEJRJWSC(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8611180", Offset = "0x860FF80", VA = "0x188611180")]
		public static GameObject NDYPEJRJWSC(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8611F40", Offset = "0x8610D40", VA = "0x188611F40")]
		public static GameObject[] TKGKZRXLWCR(IList<NREMRRGPTYQ> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8611750", Offset = "0x8610550", VA = "0x188611750")]
		public static void QJUPFLRBIRE(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86109C0", Offset = "0x860F7C0", VA = "0x1886109C0")]
		public static void KMZXWOIDZWR(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8610E60", Offset = "0x860FC60", VA = "0x188610E60")]
		public static void LYVHXJISEKY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8610BD0", Offset = "0x860F9D0", VA = "0x188610BD0")]
		public static float LRGJOQXKJBA(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x860FBF0", Offset = "0x860E9F0", VA = "0x18860FBF0")]
		public static VPDKWOIWOKH BFGOGTNAATT(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8610B30", Offset = "0x860F930", VA = "0x188610B30")]
		public static VPDKWOIWOKH LENIFIEQFVN(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8611830", Offset = "0x8610630", VA = "0x188611830")]
		public static VPDKWOIWOKH QPDZYZVUJCF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8611EB0", Offset = "0x8610CB0", VA = "0x188611EB0")]
		public static IReadOnlyList<VPDKWOIWOKH> TCQTZIVDCKB(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8611DC0", Offset = "0x8610BC0", VA = "0x188611DC0")]
		public static IReadOnlyList<VPDKWOIWOKH> SLXIJYMWBGS(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x860FC90", Offset = "0x860EA90", VA = "0x18860FC90")]
		public static void BIFNCNESWEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8610080", Offset = "0x860EE80", VA = "0x188610080")]
		public static bool EQFSPYQIINX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8610270", Offset = "0x860F070", VA = "0x188610270")]
		public static bool HKYKTRWNBPL(VPDKWOIWOKH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8612140", Offset = "0x8610F40", VA = "0x188612140")]
		public static bool VJXINGPMQSM(NetworkEventCode a, object b, BFNGJDNRMXE c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86122A0", Offset = "0x86110A0", VA = "0x1886122A0")]
		public static bool VJXINGPMQSM(byte a, object b, BFNGJDNRMXE c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8610180", Offset = "0x860EF80", VA = "0x188610180")]
		public static void FWJKRSTFZWO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8612A50", Offset = "0x8611850", VA = "0x188612A50")]
		public static void ZLPVCWRAQLQ(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x860FF00", Offset = "0x860ED00", VA = "0x18860FF00")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8610A40", Offset = "0x860F840", VA = "0x188610A40")]
		public static int KQLKIVAPQVG(XQAWTLZFHQF a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8610000", Offset = "0x860EE00", VA = "0x188610000")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x86115E0", Offset = "0x86103E0", VA = "0x1886115E0")]
		public static void QCVLGNILOCV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86106F0", Offset = "0x860F4F0", VA = "0x1886106F0")]
		public static int JQNIPVFSGWY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x860FB70", Offset = "0x860E970", VA = "0x18860FB70")]
		public static void BCDNYYQTXDA(OLPMYWFCPDT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8611460", Offset = "0x8610260", VA = "0x188611460")]
		public static void OPCXSNIIVLM(EEZZQHVLTFP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x860FD90", Offset = "0x860EB90", VA = "0x18860FD90")]
		public static string DTOXIPWGHWK(XQAWTLZFHQF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8611BA0", Offset = "0x86109A0", VA = "0x188611BA0")]
		public static void RXGFVRGONIH(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8611A80", Offset = "0x8610880", VA = "0x188611A80")]
		public static void RXGFVRGONIH(ViewId a, string b, VPDKWOIWOKH c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x86108E0", Offset = "0x860F6E0", VA = "0x1886108E0")]
		public static void KHQYWNYJRQR(ViewId a)
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
