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
	public interface RTCHFENFVEY
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object HNUUIGQYERD(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject ZRFXNVFLMBC(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject CWRTBWTRYHA(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject DMKKNGZJIMX(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject SYBEFZPYCIR(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RHDTYIMSNRO(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GJLWFQZSRTP(GameObject a);
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
		public HJIMNRPSBJR creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x851E0A0", Offset = "0x851D2A0", VA = "0x18851E0A0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, HJIMNRPSBJR creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x851DFF0", Offset = "0x851D1F0", VA = "0x18851DFF0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, HJIMNRPSBJR creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x851DE20", Offset = "0x851D020", VA = "0x18851DE20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x851D840", Offset = "0x851CA40", VA = "0x18851D840")]
		public string EUDWAZOZDZC()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface AXFXGSJELZL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] WWVRXUVJCSF(IList<BNMTUOAYRPG> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SRZESLKBIGM(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KYQKNOFCQFT(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void USAGUHYGSUA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class AHKTCXQSTFA
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly RTCHFENFVEY instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
			internal Access(RTCHFENFVEY instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x851D7C0", Offset = "0x851C9C0", VA = "0x18851D7C0")]
			public void ZTAPPGKCAEE(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x851D740", Offset = "0x851C940", VA = "0x18851D740")]
			public void TIYBTDKKUYW(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
			private void HGTSVKNFXZS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static KIWRGVAWRAJ<PlayerId> GFOJGAKMRCU;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static KIWRGVAWRAJ<PlayerId> UQGYQXVKMTY;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static UYADTWTQRTZ WAEXHSIGTTL;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static KIMDMHNBYDR<HJIMNRPSBJR, double, object> FJXPWAVRFOT;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static KIWRGVAWRAJ<IReadOnlyList<InstantiateParameters>> YDLNNETRLVU;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static KIGWPATEOSI<GameObject, bool> XFNKCNHGVST;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static KIWRGVAWRAJ<GameObject> XBWYKYNLIZD;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static KIWRGVAWRAJ<GameObject> JXYQWVMQMUA;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static KIGWPATEOSI<int, int> OPYOOYAHVAE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static CVEDYLCEYBQ AVIFYBRKMAF;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static KHWIUNFJVVQ<string, ViewId, XCEGECUYYPM, XCEGECUYYPM> FQLSBQNBDRJ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static RTCHFENFVEY CXIMYLWCEAJ;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access CZWDAWSVDWW;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static AXFXGSJELZL NXWAOFHOKJE;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static WZHVTUWPQXC XWLYFUAIADV;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static JXLRYILWFBT ZFWRMIZGFXU;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static BPARIIBOKTD DTVCIXWKVCS;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static WZHVTUWPQXC VUQWLQGJXHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x851B240", Offset = "0x851A440", VA = "0x18851B240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x851C190", Offset = "0x851B390", VA = "0x18851C190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IQPQPFYWWXC LXRINVDVRUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x851C040", Offset = "0x851B240", VA = "0x18851C040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x851C660", Offset = "0x851B860", VA = "0x18851C660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string WWZUTIZNWKB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x851C5E0", Offset = "0x851B7E0", VA = "0x18851C5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> BFMFFZLJPUK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x851AC90", Offset = "0x8519E90", VA = "0x18851AC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool WJUBLSTZTWL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x851BD70", Offset = "0x851AF70", VA = "0x18851BD70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool CIWOUSIJXFO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x851C110", Offset = "0x851B310", VA = "0x18851C110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool MVDGEOMSBSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x851AC10", Offset = "0x8519E10", VA = "0x18851AC10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double QRFLHNBEWRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x851D1C0", Offset = "0x851C3C0", VA = "0x18851D1C0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int BTHYZDSCHAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x851CBB0", Offset = "0x851BDB0", VA = "0x18851CBB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float TBMTOSDKWTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x851B390", Offset = "0x851A590", VA = "0x18851B390")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool HGHFTNKEEPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x851BFC0", Offset = "0x851B1C0", VA = "0x18851BFC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool EBMDIHEHQPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x851B310", Offset = "0x851A510", VA = "0x18851B310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static HJIMNRPSBJR KWHQLHEEHBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x851C280", Offset = "0x851B480", VA = "0x18851C280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static TSGUKOIFCBT GJMYCKTJNSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x851ADF0", Offset = "0x8519FF0", VA = "0x18851ADF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static HJIMNRPSBJR EUZHPHSIVZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x851C200", Offset = "0x851B400", VA = "0x18851C200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static AUYEDWZYXUE KEUUCWRLKOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8519E20", Offset = "0x8519020", VA = "0x188519E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int MTPGDMQDRFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x851BE70", Offset = "0x851B070", VA = "0x18851BE70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int VYJUIEUFPMN
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x851C3F0", Offset = "0x851B5F0", VA = "0x18851C3F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int HIEYOAHGMRD
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x851C6D0", Offset = "0x851B8D0", VA = "0x18851C6D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string PYOXVPTNFCN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x851A270", Offset = "0x8519470", VA = "0x18851A270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long HOXRNYLJWZO
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8519DA0", Offset = "0x8518FA0", VA = "0x188519DA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long CWZNNZAOYWP
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x851A360", Offset = "0x8519560", VA = "0x18851A360")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool LEVVYKGXURX
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8519F10", Offset = "0x8519110", VA = "0x188519F10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x851B500", Offset = "0x851A700", VA = "0x18851B500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string CZTIAIALYDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x851BF70", Offset = "0x851B170", VA = "0x18851BF70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x851B1D0", Offset = "0x851A3D0", VA = "0x18851B1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x851BCF0", Offset = "0x851AEF0", VA = "0x18851BCF0")]
		public static Access MUACYXUOXLX(RTCHFENFVEY a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x851CB40", Offset = "0x851BD40", VA = "0x18851CB40")]
		public static void XXPNGTYHBJX(AXFXGSJELZL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x851AE90", Offset = "0x851A090", VA = "0x18851AE90")]
		public static object HNUUIGQYERD(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x851D040", Offset = "0x851C240", VA = "0x18851D040")]
		public static GameObject ZRFXNVFLMBC(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x851CCB0", Offset = "0x851BEB0", VA = "0x18851CCB0")]
		public static GameObject ZRFXNVFLMBC(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x851CF40", Offset = "0x851C140", VA = "0x18851CF40")]
		public static GameObject ZRFXNVFLMBC(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x851CE00", Offset = "0x851C000", VA = "0x18851CE00")]
		public static GameObject ZRFXNVFLMBC(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x851A3E0", Offset = "0x85195E0", VA = "0x18851A3E0")]
		public static GameObject CWRTBWTRYHA(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x851A530", Offset = "0x8519730", VA = "0x18851A530")]
		public static GameObject CWRTBWTRYHA(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x851A6B0", Offset = "0x85198B0", VA = "0x18851A6B0")]
		public static GameObject DMKKNGZJIMX(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x851C300", Offset = "0x851B500", VA = "0x18851C300")]
		public static GameObject SYBEFZPYCIR(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x851C090", Offset = "0x851B290", VA = "0x18851C090")]
		public static void RHDTYIMSNRO(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x851AD70", Offset = "0x8519F70", VA = "0x18851AD70")]
		public static void GJLWFQZSRTP(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x851B690", Offset = "0x851A890", VA = "0x18851B690")]
		public static GameObject MKPUQYPTEGO(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x851B5F0", Offset = "0x851A7F0", VA = "0x18851B5F0")]
		public static GameObject MKPUQYPTEGO(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x851B730", Offset = "0x851A930", VA = "0x18851B730")]
		public static GameObject MKPUQYPTEGO(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x851C850", Offset = "0x851BA50", VA = "0x18851C850")]
		public static GameObject[] WWVRXUVJCSF(IList<BNMTUOAYRPG> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x851CA60", Offset = "0x851BC60", VA = "0x18851CA60")]
		public static void XXHBYNLKPJM(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x851B290", Offset = "0x851A490", VA = "0x18851B290")]
		public static void KYQKNOFCQFT(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x851C560", Offset = "0x851B760", VA = "0x18851C560")]
		public static void USAGUHYGSUA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x851C750", Offset = "0x851B950", VA = "0x18851C750")]
		public static float WUGDTZVLESW(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x851C9D0", Offset = "0x851BBD0", VA = "0x18851C9D0")]
		public static HJIMNRPSBJR XEDOMBRQBYR(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x851A1E0", Offset = "0x85193E0", VA = "0x18851A1E0")]
		public static HJIMNRPSBJR BZLPAQTJHNZ(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x851C470", Offset = "0x851B670", VA = "0x18851C470")]
		public static HJIMNRPSBJR TOLRNTJWGLT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x851CC30", Offset = "0x851BE30", VA = "0x18851CC30")]
		public static IReadOnlyList<HJIMNRPSBJR> YQRMGYUJKUR(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x851BDF0", Offset = "0x851AFF0", VA = "0x18851BDF0")]
		public static IReadOnlyList<HJIMNRPSBJR> NJAQJDXQLLE(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x851D2B0", Offset = "0x851C4B0", VA = "0x18851D2B0")]
		public static void ZVZZRMWAGLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x851BEF0", Offset = "0x851B0F0", VA = "0x18851BEF0")]
		public static bool PAPVNPYTOOZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x851B970", Offset = "0x851AB70", VA = "0x18851B970")]
		public static bool MRZBWQKIAWF(HJIMNRPSBJR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x851BB90", Offset = "0x851AD90", VA = "0x18851BB90")]
		public static bool MTJMVGQAXXC(NetworkEventCode a, object b, QWRWUXWOZZA c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x851BA60", Offset = "0x851AC60", VA = "0x18851BA60")]
		public static bool MTJMVGQAXXC(byte a, object b, QWRWUXWOZZA c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x851C950", Offset = "0x851BB50", VA = "0x18851C950")]
		public static void WZVOOIMNXHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x851B0D0", Offset = "0x851A2D0", VA = "0x18851B0D0")]
		public static void JNXWDCMOQDE(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x851A8C0", Offset = "0x8519AC0", VA = "0x18851A8C0")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x851AF70", Offset = "0x851A170", VA = "0x18851AF70")]
		public static int HTSMJERMLZW(QVRCDNFGMQF a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x851A9C0", Offset = "0x8519BC0", VA = "0x18851A9C0")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x851B480", Offset = "0x851A680", VA = "0x18851B480")]
		public static void MARINIMNRSN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x851A840", Offset = "0x8519A40", VA = "0x18851A840")]
		public static int DUQMWMUHGZW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x851B060", Offset = "0x851A260", VA = "0x18851B060")]
		public static void IDHWLIYRGQG(JXLRYILWFBT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8519EA0", Offset = "0x85190A0", VA = "0x188519EA0")]
		public static void BLNPPNLENXY(BPARIIBOKTD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x851AB20", Offset = "0x8519D20", VA = "0x18851AB20")]
		public static string ERYJCZXMBBQ(QVRCDNFGMQF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8519F90", Offset = "0x8519190", VA = "0x188519F90")]
		public static void BREYJYYOULJ(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x851A0C0", Offset = "0x85192C0", VA = "0x18851A0C0")]
		public static void BREYJYYOULJ(ViewId a, string b, HJIMNRPSBJR c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x851AA40", Offset = "0x8519C40", VA = "0x18851AA40")]
		public static void EOYUMPRMFNL(ViewId a)
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
