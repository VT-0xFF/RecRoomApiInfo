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
	public interface GIHGPTEQAFT
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object GUWNHIJHTHY(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject LMNAOJNMCPZ(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject BGSDNOIQTCP(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject WYEFHKLVHWS(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject RUXPHIVWALW(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZAZHXEGYWMZ(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void XGUYNCUCOEI(GameObject a);
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
		public XLYBIIWOHJI creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8813BB0", Offset = "0x8812BB0", VA = "0x188813BB0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, XLYBIIWOHJI creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8813B00", Offset = "0x8812B00", VA = "0x188813B00")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, XLYBIIWOHJI creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8813320", Offset = "0x8812320", VA = "0x188813320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x88134F0", Offset = "0x88124F0", VA = "0x1888134F0")]
		public string YMUEOHLHJPF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface YUJVIAXAESI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] KXNYSIWRNBQ(IList<VODJLYBZHVP> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZBJXORAPSLD(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void QILDFKFMMGA(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MKAOXDKLXTJ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class HJBNGTPSSDL
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly GIHGPTEQAFT instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xF99620", Offset = "0xF98620", VA = "0x180F99620")]
			internal Access(GIHGPTEQAFT instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x880F980", Offset = "0x880E980", VA = "0x18880F980")]
			public void WJCHDQFGCOX(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x880F900", Offset = "0x880E900", VA = "0x18880F900")]
			public void DXMJWNODEFV(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
			private void CDDKPZAATSX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static BJQWATGADFY<PlayerId> XRXXVDRVCDF;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static BJQWATGADFY<PlayerId> GRBWJIDQXMD;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static MEENLXPKGFQ TCRTFYPTVOQ;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static BJGIGFSFKJG<XLYBIIWOHJI, double, object> QNKYJNSKGBA;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static BJQWATGADFY<IReadOnlyList<InstantiateParameters>> SBWKIUAXXQP;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static BJLPDMMCTUP<GameObject, bool> VBJEWBMZZXM;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static BJQWATGADFY<GameObject> FNWTMHTSIFK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static BJQWATGADFY<GameObject> QWTFRBTUPJX;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static BJLPDMMCTUP<int, int> GBHYDJBJPHL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static JICXVMFHZKR WGFKFPHLSUC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static BJQWATGADFY<string> TBYPBOJOQXC;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static GIHGPTEQAFT MAKLNMPBYFM;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access RLDWYBPLEPR;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static YUJVIAXAESI IRKOBWWDZSV;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static ZQAJGWPIFJJ MZYXDMAYUKK;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static CGXCTBBTSQC XATNJPLCUAP;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static ZHAXCTAVNZI CDHCITDYSML;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static ZQAJGWPIFJJ JZTKFWFJCEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8812460", Offset = "0x8811460", VA = "0x188812460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8812100", Offset = "0x8811100", VA = "0x188812100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static AKWEZBJRAWD NFLWMTEBEEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8810720", Offset = "0x880F720", VA = "0x188810720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8811530", Offset = "0x8810530", VA = "0x188811530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string TLRYNVZSXGS
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x880FA60", Offset = "0x880EA60", VA = "0x18880FA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> NDZAZBDCUZL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x88115A0", Offset = "0x88105A0", VA = "0x1888115A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool KJLCIXMLVOE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x88108A0", Offset = "0x880F8A0", VA = "0x1888108A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool KNZHBNDJNZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8810190", Offset = "0x880F190", VA = "0x188810190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool TEOQECAIQFU
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8810420", Offset = "0x880F420", VA = "0x188810420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double OEVGLSWOLPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8812870", Offset = "0x8811870", VA = "0x188812870")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int HYQXOGNVQSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8810020", Offset = "0x880F020", VA = "0x188810020")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float RKQNZAHTKOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8811690", Offset = "0x8810690", VA = "0x188811690")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool WKTDGOKMBTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x88114B0", Offset = "0x88104B0", VA = "0x1888114B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool SOBNMWWJMDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8810C40", Offset = "0x880FC40", VA = "0x188810C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static XLYBIIWOHJI QQRSSROVZZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x880FFA0", Offset = "0x880EFA0", VA = "0x18880FFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static CZDNIEYZLHO EEQLIWIEIZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x88107F0", Offset = "0x880F7F0", VA = "0x1888107F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static XLYBIIWOHJI TKJWERWLKBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8812BB0", Offset = "0x8811BB0", VA = "0x188812BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static FPWIGKGWIZD JAUGMLTBROC
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8812170", Offset = "0x8811170", VA = "0x188812170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int CETPIROQCHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x88121F0", Offset = "0x88111F0", VA = "0x1888121F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int QGLQUCOJRKK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8812D40", Offset = "0x8811D40", VA = "0x188812D40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int WTDGNVDQTLI
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8812DC0", Offset = "0x8811DC0", VA = "0x188812DC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string XFHHPZFZKVM
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x880FEB0", Offset = "0x880EEB0", VA = "0x18880FEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long BZPHAFFJTSX
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x88125D0", Offset = "0x88115D0", VA = "0x1888125D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long SKANEPNGVHE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8811350", Offset = "0x8810350", VA = "0x188811350")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool EPBDWUTUHGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x88106A0", Offset = "0x880F6A0", VA = "0x1888106A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8812370", Offset = "0x8811370", VA = "0x188812370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string RHNMBGGRHWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x880FA00", Offset = "0x880EA00", VA = "0x18880FA00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88118E0", Offset = "0x88108E0", VA = "0x1888118E0")]
		public static Access PLFSEMLZOMM(GIHGPTEQAFT a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8810920", Offset = "0x880F920", VA = "0x188810920")]
		public static void KTJLQJUNAFK(YUJVIAXAESI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x88105B0", Offset = "0x880F5B0", VA = "0x1888105B0")]
		public static object GUWNHIJHTHY(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8810F10", Offset = "0x880FF10", VA = "0x188810F10")]
		public static GameObject LMNAOJNMCPZ(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8810DC0", Offset = "0x880FDC0", VA = "0x188810DC0")]
		public static GameObject LMNAOJNMCPZ(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8810CC0", Offset = "0x880FCC0", VA = "0x188810CC0")]
		public static GameObject LMNAOJNMCPZ(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8811090", Offset = "0x8810090", VA = "0x188811090")]
		public static GameObject LMNAOJNMCPZ(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x880FD60", Offset = "0x880ED60", VA = "0x18880FD60")]
		public static GameObject BGSDNOIQTCP(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x880FBE0", Offset = "0x880EBE0", VA = "0x18880FBE0")]
		public static GameObject BGSDNOIQTCP(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8812650", Offset = "0x8811650", VA = "0x188812650")]
		public static GameObject WYEFHKLVHWS(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8811E60", Offset = "0x8810E60", VA = "0x188811E60")]
		public static GameObject RUXPHIVWALW(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8812CC0", Offset = "0x8811CC0", VA = "0x188812CC0")]
		public static void ZAZHXEGYWMZ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88127F0", Offset = "0x88117F0", VA = "0x1888127F0")]
		public static void XGUYNCUCOEI(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8811AE0", Offset = "0x8810AE0", VA = "0x188811AE0")]
		public static GameObject ROWICQMTWXZ(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8811B80", Offset = "0x8810B80", VA = "0x188811B80")]
		public static GameObject ROWICQMTWXZ(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8811C20", Offset = "0x8810C20", VA = "0x188811C20")]
		public static GameObject ROWICQMTWXZ(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8810990", Offset = "0x880F990", VA = "0x188810990")]
		public static GameObject[] KXNYSIWRNBQ(IList<VODJLYBZHVP> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8811780", Offset = "0x8810780", VA = "0x188811780")]
		public static void OZFUXCQGMRH(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8811A60", Offset = "0x8810A60", VA = "0x188811A60")]
		public static void QILDFKFMMGA(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88112D0", Offset = "0x88102D0", VA = "0x1888112D0")]
		public static void MKAOXDKLXTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8812270", Offset = "0x8811270", VA = "0x188812270")]
		public static float UBHQDKWVUOD(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8810BA0", Offset = "0x880FBA0", VA = "0x188810BA0")]
		public static XLYBIIWOHJI LEMBBTVWNLA(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88124B0", Offset = "0x88114B0", VA = "0x1888124B0")]
		public static XLYBIIWOHJI VQNPZEVIQPC(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x880FAF0", Offset = "0x880EAF0", VA = "0x18880FAF0")]
		public static XLYBIIWOHJI AUCYOFKVKIO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88104A0", Offset = "0x880F4A0", VA = "0x1888104A0")]
		public static IReadOnlyList<XLYBIIWOHJI> FHUYTCBNJYS(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8812C30", Offset = "0x8811C30", VA = "0x188812C30")]
		public static IReadOnlyList<XLYBIIWOHJI> YVWGDVBGZAZ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8811F50", Offset = "0x8810F50", VA = "0x188811F50")]
		public static void RXKMGINXGEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8812550", Offset = "0x8811550", VA = "0x188812550")]
		public static bool WELLUUGMSFM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8811970", Offset = "0x8810970", VA = "0x188811970")]
		public static bool PLZTENPDGPA(XLYBIIWOHJI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8811FD0", Offset = "0x8810FD0", VA = "0x188811FD0")]
		public static bool RaiseEvent(byte eventCode, object eventContent, GWGBIKXISIV raiseEventOptions, RRNetworkDelivery sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8810530", Offset = "0x880F530", VA = "0x188810530")]
		public static void FPGSPELLUUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8810AA0", Offset = "0x880FAA0", VA = "0x188810AA0")]
		public static void LDGVYQLXUAF(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x88102A0", Offset = "0x880F2A0", VA = "0x1888102A0")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x88111E0", Offset = "0x88101E0", VA = "0x1888111E0")]
		public static int LQGOVBWDTJL(IRRSNCQWIPE a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x88103A0", Offset = "0x880F3A0", VA = "0x1888103A0")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8810210", Offset = "0x880F210", VA = "0x188810210")]
		public static void DLNHXIJUZYI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8810770", Offset = "0x880F770", VA = "0x188810770")]
		public static int IYRBYAOIUAX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8812E40", Offset = "0x8811E40", VA = "0x188812E40")]
		public static void ZUGRDFSWEVX(CGXCTBBTSQC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8811860", Offset = "0x8810860", VA = "0x188811860")]
		public static void OZVZHDGHPHH(ZHAXCTAVNZI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x88100A0", Offset = "0x880F0A0", VA = "0x1888100A0")]
		public static string CKOAXYGUWZR(IRRSNCQWIPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8812A80", Offset = "0x8811A80", VA = "0x188812A80")]
		public static void XZHBXEHRLGI(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8812960", Offset = "0x8811960", VA = "0x188812960")]
		public static void XZHBXEHRLGI(ViewId a, string b, XLYBIIWOHJI c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x88113D0", Offset = "0x88103D0", VA = "0x1888113D0")]
		public static void NXQVMWYMAVG(ViewId a)
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
