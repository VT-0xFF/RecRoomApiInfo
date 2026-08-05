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
	public interface SQDKBXAMFUD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object SJZFGKRMVXS(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject MYWTBZEQNWN(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject OMDOZHRUPRL(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject QADAWGWRIEY(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject WJXELRSILTY(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CIEQOSCEICL(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DIMXXQPVGIK(GameObject a);
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
		public OVSEBXDBUJS creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8584B10", Offset = "0x8583B10", VA = "0x188584B10")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, OVSEBXDBUJS creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8584C50", Offset = "0x8583C50", VA = "0x188584C50")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, OVSEBXDBUJS creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8584940", Offset = "0x8583940", VA = "0x188584940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8584360", Offset = "0x8583360", VA = "0x188584360")]
		public string SQLORRTMRBT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface VOXNUUPKVVU
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] HALCYCPJDLS(IList<QXJDRMKUGNF> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WZUAHGOWNOP(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LZSXTYRSNTU(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TVMULYCLITD();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class MOGRIDONAQH
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly SQDKBXAMFUD instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xC41C50", Offset = "0xC40C50", VA = "0x180C41C50")]
			internal Access(SQDKBXAMFUD instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x85842E0", Offset = "0x85832E0", VA = "0x1885842E0")]
			public void VBURSAUXVJP(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8584260", Offset = "0x8583260", VA = "0x188584260")]
			public void ACPKZBFXXKB(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
			private void UTPJEPAXDHT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static KIWXAPDLTBO<PlayerId> BUTZXWZFCJL;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static KIWXAPDLTBO<PlayerId> GZXOCXCUAQZ;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static JVZNGNWULOY BGTDFOJJXSK;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static KJHKVCRGLYG<OVSEBXDBUJS, double, object> BCTNYEONHCI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static KIWXAPDLTBO<IReadOnlyList<InstantiateParameters>> UXTKXINWOAB;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static KJMRSJLDVJP<GameObject, bool> QYBWBGJGVJO;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static KIWXAPDLTBO<GameObject> WNMIMLLYUGO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static KIWXAPDLTBO<GameObject> EBVJGQIVBAD;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static KJMRSJLDVJP<int, int> UCPHPAURLAX;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static ZUUFDARDSJN VVAEHYRJQJC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static KIHCIUVTQTN<string, ViewId, KQXBXWSKSDT, KQXBXWSKSDT> JHSAAGHMDVQ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static SQDKBXAMFUD JSLKSZHYDAI;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access TVMNYDAWFBH;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static VOXNUUPKVVU GUHLBGPBNBJ;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static FECFGTCYCGZ EOVAFPBJGXC;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static ANKBABAEPJK KHSTRZZHITT;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static UUDCUIBOXPO IBDOMDKMDKR;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static FECFGTCYCGZ JBPEVRWRMKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8584D80", Offset = "0x8583D80", VA = "0x188584D80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8585C20", Offset = "0x8584C20", VA = "0x188585C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static WIXJJXNIBCV GVXORHHSYUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8587E00", Offset = "0x8586E00", VA = "0x188587E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8587B00", Offset = "0x8586B00", VA = "0x188587B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string CTAYVZZKIVO
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x85880C0", Offset = "0x85870C0", VA = "0x1885880C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> OWVFWQOPIRR
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8587A10", Offset = "0x8586A10", VA = "0x188587A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool GQXMPAUZOJM
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8587F40", Offset = "0x8586F40", VA = "0x188587F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool HEZZJNKLAHP
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x85871C0", Offset = "0x85861C0", VA = "0x1885871C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool DEUYJSMWYQM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8584D00", Offset = "0x8583D00", VA = "0x188584D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double STXIKPNXGPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x85863F0", Offset = "0x85853F0", VA = "0x1885863F0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int TGOVDZFMICI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8585E90", Offset = "0x8584E90", VA = "0x188585E90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float XSPRLQBSEZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8586EC0", Offset = "0x8585EC0", VA = "0x188586EC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool GJCZRRWYTMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x85859B0", Offset = "0x85849B0", VA = "0x1885859B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool RIAZAHEERGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8586560", Offset = "0x8585560", VA = "0x188586560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static OVSEBXDBUJS UOTHWZKTJRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8585580", Offset = "0x8584580", VA = "0x188585580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static HUZGCNRKFDE VZKZLTXHEIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8585910", Offset = "0x8584910", VA = "0x188585910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static OVSEBXDBUJS DTKXNFDZXTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8586370", Offset = "0x8585370", VA = "0x188586370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static SPAZCZEVTZZ DBIGOYZGKTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8585210", Offset = "0x8584210", VA = "0x188585210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int FCEDIEEZHWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8586100", Offset = "0x8585100", VA = "0x188586100")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int IZZEEJDARDC
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8585890", Offset = "0x8584890", VA = "0x188585890")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int JFRVZULTLSY
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8586E40", Offset = "0x8585E40", VA = "0x188586E40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string VNWQOOXCHCM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8586200", Offset = "0x8585200", VA = "0x188586200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long AHCAVPLKRJT
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8585FF0", Offset = "0x8584FF0", VA = "0x188585FF0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long APLHIFGAZMY
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8584DD0", Offset = "0x8583DD0", VA = "0x188584DD0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool BTBZQKOQLUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8584E50", Offset = "0x8583E50", VA = "0x188584E50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x85877B0", Offset = "0x85867B0", VA = "0x1885877B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string IXIFNMWIRJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8587D40", Offset = "0x8586D40", VA = "0x188587D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x85851A0", Offset = "0x85841A0", VA = "0x1885851A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85862F0", Offset = "0x85852F0", VA = "0x1885862F0")]
		public static Access LQFRNVWPHPY(SQDKBXAMFUD a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8587D90", Offset = "0x8586D90", VA = "0x188587D90")]
		public static void VHSPLUNAEES(VOXNUUPKVVU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8587920", Offset = "0x8586920", VA = "0x188587920")]
		public static object SJZFGKRMVXS(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85866E0", Offset = "0x85856E0", VA = "0x1885866E0")]
		public static GameObject MYWTBZEQNWN(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8586860", Offset = "0x8585860", VA = "0x188586860")]
		public static GameObject MYWTBZEQNWN(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85865E0", Offset = "0x85855E0", VA = "0x1885865E0")]
		public static GameObject MYWTBZEQNWN(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85869B0", Offset = "0x85859B0", VA = "0x1885869B0")]
		public static GameObject MYWTBZEQNWN(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8586CF0", Offset = "0x8585CF0", VA = "0x188586CF0")]
		public static GameObject OMDOZHRUPRL(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8586B70", Offset = "0x8585B70", VA = "0x188586B70")]
		public static GameObject OMDOZHRUPRL(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8586FB0", Offset = "0x8585FB0", VA = "0x188586FB0")]
		public static GameObject QADAWGWRIEY(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8587E50", Offset = "0x8586E50", VA = "0x188587E50")]
		public static GameObject WJXELRSILTY(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8584ED0", Offset = "0x8583ED0", VA = "0x188584ED0")]
		public static void CIEQOSCEICL(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8585290", Offset = "0x8584290", VA = "0x188585290")]
		public static void DIMXXQPVGIK(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8587430", Offset = "0x8586430", VA = "0x188587430")]
		public static GameObject RGJKNOCPAHX(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85874D0", Offset = "0x85864D0", VA = "0x1885874D0")]
		public static GameObject RGJKNOCPAHX(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8587570", Offset = "0x8586570", VA = "0x188587570")]
		public static GameObject RGJKNOCPAHX(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8585C90", Offset = "0x8584C90", VA = "0x188585C90")]
		public static GameObject[] HALCYCPJDLS(IList<QXJDRMKUGNF> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8585F10", Offset = "0x8584F10", VA = "0x188585F10")]
		public static void JDICJEBWYDJ(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85864E0", Offset = "0x85854E0", VA = "0x1885864E0")]
		public static void LZSXTYRSNTU(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8587CC0", Offset = "0x8586CC0", VA = "0x188587CC0")]
		public static void TVMULYCLITD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8585B20", Offset = "0x8584B20", VA = "0x188585B20")]
		public static float GPUBAWWKPHH(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8586070", Offset = "0x8585070", VA = "0x188586070")]
		public static OVSEBXDBUJS JOMXKKCXRYA(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8588140", Offset = "0x8587140", VA = "0x188588140")]
		public static OVSEBXDBUJS YQLFXQKIPQG(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8585A30", Offset = "0x8584A30", VA = "0x188585A30")]
		public static OVSEBXDBUJS FSHTGKEZGLC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8586AF0", Offset = "0x8585AF0", VA = "0x188586AF0")]
		public static IReadOnlyList<OVSEBXDBUJS> OELOYDYOJSM(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85878A0", Offset = "0x85868A0", VA = "0x1885878A0")]
		public static IReadOnlyList<OVSEBXDBUJS> RYJXHVRUZAL(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8586180", Offset = "0x8585180", VA = "0x188586180")]
		public static void KSOBUHMPDPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85873B0", Offset = "0x85863B0", VA = "0x1885873B0")]
		public static bool QVOJGLTSTMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8585310", Offset = "0x8584310", VA = "0x188585310")]
		public static bool DXNYDFRAPJW(OVSEBXDBUJS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8585600", Offset = "0x8584600", VA = "0x188585600")]
		public static bool EFSZTLMNQBJ(NetworkEventCode a, object b, XSNAFSFANWP c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8585760", Offset = "0x8584760", VA = "0x188585760")]
		public static bool EFSZTLMNQBJ(byte a, object b, XSNAFSFANWP c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8587330", Offset = "0x8586330", VA = "0x188587330")]
		public static void QSTXGBCTXRV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8587FC0", Offset = "0x8586FC0", VA = "0x188587FC0")]
		public static void XRHSQBYDVHR(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8585400", Offset = "0x8584400", VA = "0x188585400")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8587240", Offset = "0x8586240", VA = "0x188587240")]
		public static int QRQKMVLOPZN(VASLQQLLDVS a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8585500", Offset = "0x8584500", VA = "0x188585500")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8587140", Offset = "0x8586140", VA = "0x188587140")]
		public static void QBDRGJDKPSW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8588240", Offset = "0x8587240", VA = "0x188588240")]
		public static int YTJXEOZTVTL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85881D0", Offset = "0x85871D0", VA = "0x1885881D0")]
		public static void YQRPQCLZNXR(ANKBABAEPJK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8587B70", Offset = "0x8586B70", VA = "0x188587B70")]
		public static void TEKSGNZWIDR(UUDCUIBOXPO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8585DA0", Offset = "0x8584DA0", VA = "0x188585DA0")]
		public static string HVJTRJXXWPL(VASLQQLLDVS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8585070", Offset = "0x8584070", VA = "0x188585070")]
		public static void CSWAUNIXGNY(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8584F50", Offset = "0x8583F50", VA = "0x188584F50")]
		public static void CSWAUNIXGNY(ViewId a, string b, OVSEBXDBUJS c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8587BE0", Offset = "0x8586BE0", VA = "0x188587BE0")]
		public static void TQJOIYYWNSG(ViewId a)
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
