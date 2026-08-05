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
	public interface HCUBXREVREG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object HWBPJUDAXQX(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject GSLMICJJWDI(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject KIMZMDLFILW(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject TDSJLKREDXP(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject HAFDTLWQNKT(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XOJZLHKFEKC(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZRDTBLZDYIH(GameObject a);
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
		public JCSDFORPEFX creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83753E0", Offset = "0x83747E0", VA = "0x1883753E0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, JCSDFORPEFX creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8375330", Offset = "0x8374730", VA = "0x188375330")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, JCSDFORPEFX creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8375160", Offset = "0x8374560", VA = "0x188375160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8374B80", Offset = "0x8373F80", VA = "0x188374B80")]
		public string PJOYWCFQAGC()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface XQZDSUXMIXF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] IZDZQVVNTQX(IList<ZEHIHZUMJHM> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DRJLZKIURDY(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void XFLXKHBRAGH(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EBZRXGYTAFI();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class PIANMMCSQOE
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly HCUBXREVREG instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
			internal Access(HCUBXREVREG instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8374A80", Offset = "0x8373E80", VA = "0x188374A80")]
			public void ESYETVXYIUK(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8374B00", Offset = "0x8373F00", VA = "0x188374B00")]
			public void LGBWAGEXHYA(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
			private void MRSJCMKZLXI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static KBLPOZGJAAH<PlayerId> LTLKTKQGHBM;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static KBLPOZGJAAH<PlayerId> QBMKNTCBZVG;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static CALGTGVEOGB DKHHOJRBOMT;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static KBWDJMUDSWZ<JCSDFORPEFX, double, object> MPGDPBSDXVP;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static KBLPOZGJAAH<IReadOnlyList<InstantiateParameters>> LVTGBYCDEIM;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static KBQWMGAGJLQ<GameObject, bool> GHCHDJWWMSJ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static KBLPOZGJAAH<GameObject> IFQCYRMMOHR;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static KBLPOZGJAAH<GameObject> MRJZSGZYHSO;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static KBQWMGAGJLQ<int, int> TPRQSSTFKOW;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static NHBLQESUHLS RFRRCWMBHXJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static KBLPOZGJAAH<string> LGYIMOBGJHX;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static HCUBXREVREG XVZALEVPGTF;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access FQNLLAHFULS;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static XQZDSUXMIXF RKHVTQMVIDG;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static ONYDUELVRUG MCRMDDPRPQF;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static HFLLGBMWIHF UGOVYLDDXNG;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static PYESNTUUZNB HVNLXEQCCQU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static ONYDUELVRUG AEYAHUMWSZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8375520", Offset = "0x8374920", VA = "0x188375520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8378440", Offset = "0x8377840", VA = "0x188378440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static HDUADJJBHEG BOVKUHFLZKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8377890", Offset = "0x8376C90", VA = "0x188377890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8376290", Offset = "0x8375690", VA = "0x188376290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string YNADGOKJOIP
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x83775A0", Offset = "0x83769A0", VA = "0x1883775A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> GJGXGVUBWLK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8376A20", Offset = "0x8375E20", VA = "0x188376A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool JMORIRTNXBT
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x83758C0", Offset = "0x8374CC0", VA = "0x1883758C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool ZZIASLAHIEO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8377720", Offset = "0x8376B20", VA = "0x188377720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool OHMMNRCDRVV
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8377960", Offset = "0x8376D60", VA = "0x188377960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double DLFQJUKJJJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8376E90", Offset = "0x8376290", VA = "0x188376E90")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int BGTIJWDZDZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8375750", Offset = "0x8374B50", VA = "0x188375750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float WYOSAUQGGQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x83757D0", Offset = "0x8374BD0", VA = "0x1883757D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool ZCQMDRLXERN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8378040", Offset = "0x8377440", VA = "0x188378040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool ONWUNJMGJPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x83783C0", Offset = "0x83777C0", VA = "0x1883783C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static JCSDFORPEFX NYHENYQESVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8376C80", Offset = "0x8376080", VA = "0x188376C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static ZPFBQSWCPET NWPGHNHRIAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8376300", Offset = "0x8375700", VA = "0x188376300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static JCSDFORPEFX PQXGPXPTXLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x83768B0", Offset = "0x8375CB0", VA = "0x1883768B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static ARVWTXZMNAK YUCPQMFGHHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8377F40", Offset = "0x8377340", VA = "0x188377F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int UDBZSSXKPRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8377B90", Offset = "0x8376F90", VA = "0x188377B90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int WJFUMRPIWHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8376B10", Offset = "0x8375F10", VA = "0x188376B10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int QRYUFTFUHNB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8378340", Offset = "0x8377740", VA = "0x188378340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string SNNFXQPUAJN
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x83777A0", Offset = "0x8376BA0", VA = "0x1883777A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long GXPZYTBXPXU
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8376040", Offset = "0x8375440", VA = "0x188376040")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long QECJIEKLOND
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x83787A0", Offset = "0x8377BA0", VA = "0x1883787A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool ENIHPCWSDHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8378720", Offset = "0x8377B20", VA = "0x188378720")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x83761A0", Offset = "0x83755A0", VA = "0x1883761A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string JWIIKENUQZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8377B40", Offset = "0x8376F40", VA = "0x188377B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8376D00", Offset = "0x8376100", VA = "0x188376D00")]
		public static Access IPVZKAOPDTJ(HCUBXREVREG a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83786B0", Offset = "0x8377AB0", VA = "0x1883786B0")]
		public static void YOHXUFULVOH(XQZDSUXMIXF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8376B90", Offset = "0x8375F90", VA = "0x188376B90")]
		public static object HWBPJUDAXQX(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83764E0", Offset = "0x83758E0", VA = "0x1883764E0")]
		public static GameObject GSLMICJJWDI(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8376660", Offset = "0x8375A60", VA = "0x188376660")]
		public static GameObject GSLMICJJWDI(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83767B0", Offset = "0x8375BB0", VA = "0x1883767B0")]
		public static GameObject GSLMICJJWDI(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83763A0", Offset = "0x83757A0", VA = "0x1883763A0")]
		public static GameObject GSLMICJJWDI(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8377350", Offset = "0x8376750", VA = "0x188377350")]
		public static GameObject KIMZMDLFILW(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83771D0", Offset = "0x83765D0", VA = "0x1883771D0")]
		public static GameObject KIMZMDLFILW(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83781B0", Offset = "0x83775B0", VA = "0x1883781B0")]
		public static GameObject TDSJLKREDXP(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8376930", Offset = "0x8375D30", VA = "0x188376930")]
		public static GameObject HAFDTLWQNKT(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8378630", Offset = "0x8377A30", VA = "0x188378630")]
		public static void XOJZLHKFEKC(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8378890", Offset = "0x8377C90", VA = "0x188378890")]
		public static void ZRDTBLZDYIH(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8375FA0", Offset = "0x83753A0", VA = "0x188375FA0")]
		public static GameObject EIJGJLIWLPS(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8375F00", Offset = "0x8375300", VA = "0x188375F00")]
		public static GameObject EIJGJLIWLPS(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8375CC0", Offset = "0x83750C0", VA = "0x188375CC0")]
		public static GameObject EIJGJLIWLPS(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8376D80", Offset = "0x8376180", VA = "0x188376D80")]
		public static GameObject[] IZDZQVVNTQX(IList<ZEHIHZUMJHM> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83760C0", Offset = "0x83754C0", VA = "0x1883760C0")]
		public static void FFCCVTKLBTS(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8378540", Offset = "0x8377940", VA = "0x188378540")]
		public static void XFLXKHBRAGH(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8375C40", Offset = "0x8375040", VA = "0x188375C40")]
		public static void EBZRXGYTAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8377620", Offset = "0x8376A20", VA = "0x188377620")]
		public static float LMVCLTGAJRK(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83784B0", Offset = "0x83778B0", VA = "0x1883784B0")]
		public static JCSDFORPEFX VQEGFVAHVPZ(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8377D80", Offset = "0x8377180", VA = "0x188377D80")]
		public static JCSDFORPEFX RVWUFLTWTDT(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8375570", Offset = "0x8374970", VA = "0x188375570")]
		public static JCSDFORPEFX BIKNLKOXTOH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8377520", Offset = "0x8376920", VA = "0x188377520")]
		public static IReadOnlyList<JCSDFORPEFX> LANSCTINBBF(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8377FC0", Offset = "0x83773C0", VA = "0x188377FC0")]
		public static IReadOnlyList<JCSDFORPEFX> SLDKIXECHYQ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8377D00", Offset = "0x8377100", VA = "0x188377D00")]
		public static void RQAGPEKYIRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8377AC0", Offset = "0x8376EC0", VA = "0x188377AC0")]
		public static bool PNVHEKUVZRR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8377C10", Offset = "0x8377010", VA = "0x188377C10")]
		public static bool QYBADYZNXZN(JCSDFORPEFX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8377E10", Offset = "0x8377210", VA = "0x188377E10")]
		public static bool RaiseEvent(byte eventCode, object eventContent, FRDJWLZNOWA raiseEventOptions, RRNetworkDelivery sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83774A0", Offset = "0x83768A0", VA = "0x1883774A0")]
		public static void KLJJDTVZMDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8375940", Offset = "0x8374D40", VA = "0x188375940")]
		public static void CQVTSUWTJSM(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8375AC0", Offset = "0x8374EC0", VA = "0x188375AC0")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x83780C0", Offset = "0x83774C0", VA = "0x1883780C0")]
		public static int TCSLSNADBIG(PTKTLSUVJWP a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8375BC0", Offset = "0x8374FC0", VA = "0x188375BC0")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83778E0", Offset = "0x8376CE0", VA = "0x1883778E0")]
		public static void OJJNJISBRRF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8375A40", Offset = "0x8374E40", VA = "0x188375A40")]
		public static int DIEKMYBPXDQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8378820", Offset = "0x8377C20", VA = "0x188378820")]
		public static void ZFGDPPZRWAE(HFLLGBMWIHF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83785C0", Offset = "0x83779C0", VA = "0x1883785C0")]
		public static void XIFSZNWHZYY(PYESNTUUZNB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8375660", Offset = "0x8374A60", VA = "0x188375660")]
		public static string BOKCMDWOWWE(PTKTLSUVJWP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83770A0", Offset = "0x83764A0", VA = "0x1883770A0")]
		public static void KHTEEVPSPPL(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8376F80", Offset = "0x8376380", VA = "0x188376F80")]
		public static void KHTEEVPSPPL(ViewId a, string b, JCSDFORPEFX c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83779E0", Offset = "0x8376DE0", VA = "0x1883779E0")]
		public static void PKGFWDHVDMH(ViewId a)
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
