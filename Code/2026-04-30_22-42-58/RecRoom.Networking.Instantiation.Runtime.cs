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
	public interface LWMYSYRVXIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object XUXZNKVJQJJ(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject YIVTKMXMSGK(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject INMYJABWNLS(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject XRIRLRACRHP(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject IGKCEAHMETF(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FMDGONMNQMG(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MWSAALSBPWH(GameObject a);
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
		public PPTCRKDFMWF creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9888480", Offset = "0x9887880", VA = "0x189888480")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, PPTCRKDFMWF creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x98883D0", Offset = "0x98877D0", VA = "0x1898883D0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, PPTCRKDFMWF creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9888200", Offset = "0x9887600", VA = "0x189888200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9887C20", Offset = "0x9887020", VA = "0x189887C20")]
		public string FZRTKWBSNOG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface HRCJYZYWVYP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] ZVFAGQWFOQD(IList<LKYIPQBLRXM> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WGRKSQVSHOK(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OCVBVPXXSNB(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EXCBQGTVUNA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class TRGZLOIYXTO
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly LWMYSYRVXIO instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
			internal Access(LWMYSYRVXIO instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9887BA0", Offset = "0x9886FA0", VA = "0x189887BA0")]
			public void GVQMOCJVNPI(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9887B20", Offset = "0x9886F20", VA = "0x189887B20")]
			public void GRUEFMJXDWM(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
			private void YZZWGBBIQVY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static PCNXPJVUXFJ<PlayerId> JCISHTUWUKG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static PCNXPJVUXFJ<PlayerId> KIFCVCFJGHG;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static QBVKJZPJHHT XAJMBAEMFZF;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static PCYLJXJPQCB<PPTCRKDFMWF, double, object> IKTGVCMMGDH;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static PCNXPJVUXFJ<IReadOnlyList<InstantiateParameters>> RHEJNQCNBBW;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static PCTEMQPSGQS<GameObject, bool> STCCRCAISGB;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static PCNXPJVUXFJ<GameObject> EMBQKDPIVZZ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static PCNXPJVUXFJ<GameObject> XNPRKKTQHKG;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static PCTEMQPSGQS<int, int> IBJAWEUMDVM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static PZVGSBFXRHS YWDSSVDFODN;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static PBNPDCAICAQ<string, ViewId, RLCLHHZLKYQ, RLCLHHZLKYQ> WZBINYOOGOV;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static LWMYSYRVXIO AYERNGIXXFV;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access IRGRYTNBIJO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static HRCJYZYWVYP FSIZFBYFPYA;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static VTTAZILRZBM GAJQDIFWUNP;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static DSNQEDELGVB ZCECRWPMVYQ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static DXXMRYUFTQL QKIHEHIDOLG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static VTTAZILRZBM CFXYDRHFVTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x98890E0", Offset = "0x98884E0", VA = "0x1898890E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x988A990", Offset = "0x9889D90", VA = "0x18988A990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static WIQAXDJXXGK WMALFDPYXWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9889780", Offset = "0x9888B80", VA = "0x189889780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x988AF30", Offset = "0x988A330", VA = "0x18988AF30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string IBQDEZGEQNF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9888C50", Offset = "0x9888050", VA = "0x189888C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> DTVYCLFXDDO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x988B820", Offset = "0x988AC20", VA = "0x18988B820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool OFGSALPZLFD
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9889E80", Offset = "0x9889280", VA = "0x189889E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool VHNJIAREFGW
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9889D80", Offset = "0x9889180", VA = "0x189889D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool WODXRQUKXKL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x988A890", Offset = "0x9889C90", VA = "0x18988A890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double WIMGRXCFESD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x988A3A0", Offset = "0x98897A0", VA = "0x18988A3A0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int UOLXBGAQJPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9889620", Offset = "0x9888A20", VA = "0x189889620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float FNGEIEZWPQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x98897D0", Offset = "0x9888BD0", VA = "0x1898897D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9889330", Offset = "0x9888730", VA = "0x189889330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool GZHULXBNNNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x988AD40", Offset = "0x988A140", VA = "0x18988AD40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static PPTCRKDFMWF AFGQWFDUCRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9889E00", Offset = "0x9889200", VA = "0x189889E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static BWXREESIIMX YFAIFNTMAUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x98885C0", Offset = "0x98879C0", VA = "0x1898885C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static PPTCRKDFMWF FCZGBNMTFVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9888AD0", Offset = "0x9887ED0", VA = "0x189888AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static FDSUQUMMUMO FXMBMGUIXFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x988A910", Offset = "0x9889D10", VA = "0x18988A910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int FQPVNFOJQVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9889FF0", Offset = "0x98893F0", VA = "0x189889FF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int TZAVINYGDOH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x988BA00", Offset = "0x988AE00", VA = "0x18988BA00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int KTVAAPJWICD
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9889F00", Offset = "0x9889300", VA = "0x189889F00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string CVPCHQUQPWX
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x988B910", Offset = "0x988AD10", VA = "0x18988B910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long XQLZUWJMVOW
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9889A30", Offset = "0x9888E30", VA = "0x189889A30")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long GPBTWIIPGFL
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x988A600", Offset = "0x9889A00", VA = "0x18988A600")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool JSLCVACGUML
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x988A810", Offset = "0x9889C10", VA = "0x18988A810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x988ADC0", Offset = "0x988A1C0", VA = "0x18988ADC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string QCUXCJJKMJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x988A170", Offset = "0x9889570", VA = "0x18988A170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x988A2B0", Offset = "0x98896B0", VA = "0x18988A2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x988A070", Offset = "0x9889470", VA = "0x18988A070")]
		public static Access MMCWBVDQCZB(LWMYSYRVXIO a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9889F80", Offset = "0x9889380", VA = "0x189889F80")]
		public static void MCLDIXVWUHB(HRCJYZYWVYP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x988B140", Offset = "0x988A540", VA = "0x18988B140")]
		public static object XUXZNKVJQJJ(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x988B230", Offset = "0x988A630", VA = "0x18988B230")]
		public static GameObject YIVTKMXMSGK(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x988B5F0", Offset = "0x988A9F0", VA = "0x18988B5F0")]
		public static GameObject YIVTKMXMSGK(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x988B4F0", Offset = "0x988A8F0", VA = "0x18988B4F0")]
		public static GameObject YIVTKMXMSGK(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x988B3B0", Offset = "0x988A7B0", VA = "0x18988B3B0")]
		public static GameObject YIVTKMXMSGK(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9889AB0", Offset = "0x9888EB0", VA = "0x189889AB0")]
		public static GameObject INMYJABWNLS(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9889C00", Offset = "0x9889000", VA = "0x189889C00")]
		public static GameObject INMYJABWNLS(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x988AFA0", Offset = "0x988A3A0", VA = "0x18988AFA0")]
		public static GameObject XRIRLRACRHP(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9889940", Offset = "0x9888D40", VA = "0x189889940")]
		public static GameObject IGKCEAHMETF(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x98895A0", Offset = "0x98889A0", VA = "0x1898895A0")]
		public static void FMDGONMNQMG(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x988A0F0", Offset = "0x98894F0", VA = "0x18988A0F0")]
		public static void MWSAALSBPWH(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9888750", Offset = "0x9887B50", VA = "0x189888750")]
		public static GameObject AYQMCYKGBEA(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98887F0", Offset = "0x9887BF0", VA = "0x1898887F0")]
		public static GameObject AYQMCYKGBEA(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9888890", Offset = "0x9887C90", VA = "0x189888890")]
		public static GameObject AYQMCYKGBEA(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x988BA80", Offset = "0x988AE80", VA = "0x18988BA80")]
		public static GameObject[] ZVFAGQWFOQD(IList<LKYIPQBLRXM> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x98896A0", Offset = "0x9888AA0", VA = "0x1898896A0")]
		public static void GQKKXDFBGAU(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x988A490", Offset = "0x9889890", VA = "0x18988A490")]
		public static void OCVBVPXXSNB(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x98894B0", Offset = "0x98888B0", VA = "0x1898894B0")]
		public static void EXCBQGTVUNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x98893B0", Offset = "0x98887B0", VA = "0x1898893B0")]
		public static float EOXQRWFESLK(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x988A700", Offset = "0x9889B00", VA = "0x18988A700")]
		public static PPTCRKDFMWF UDHMAQVFXMH(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9888F60", Offset = "0x9888360", VA = "0x189888F60")]
		public static PPTCRKDFMWF BWKOWLCGPSV(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9888FF0", Offset = "0x98883F0", VA = "0x189888FF0")]
		public static PPTCRKDFMWF CLAFOMMVCZV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x988A790", Offset = "0x9889B90", VA = "0x18988A790")]
		public static IReadOnlyList<PPTCRKDFMWF> VHBHPFAGCPV(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x988A680", Offset = "0x9889A80", VA = "0x18988A680")]
		public static IReadOnlyList<PPTCRKDFMWF> SLELIROGWLO(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9889130", Offset = "0x9888530", VA = "0x189889130")]
		public static void CYCBSYPTWUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x988A320", Offset = "0x9889720", VA = "0x18988A320")]
		public static bool NPHQCDBYTAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9888660", Offset = "0x9887A60", VA = "0x189888660")]
		public static bool AUODXOGMGTN(PPTCRKDFMWF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9888E00", Offset = "0x9888200", VA = "0x189888E00")]
		public static bool BTXCCJZIXMC(NetworkEventCode a, object b, GTCQSIYUTCU c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9888CD0", Offset = "0x98880D0", VA = "0x189888CD0")]
		public static bool BTXCCJZIXMC(byte a, object b, GTCQSIYUTCU c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x988A1C0", Offset = "0x98895C0", VA = "0x18988A1C0")]
		public static void NMDSSYPLZCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9888B50", Offset = "0x9887F50", VA = "0x189888B50")]
		public static void BGVSXQNQAUM(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x98891B0", Offset = "0x98885B0", VA = "0x1898891B0")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x988AC50", Offset = "0x988A050", VA = "0x18988AC50")]
		public static int WUHZDOUCNNU(FAOJZRJMKFV a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x98892B0", Offset = "0x98886B0", VA = "0x1898892B0")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x988AEB0", Offset = "0x988A2B0", VA = "0x18988AEB0")]
		public static void XAIXXKWZTRF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x98898C0", Offset = "0x9888CC0", VA = "0x1898898C0")]
		public static int IFBQVVAAVCC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x988A240", Offset = "0x9889640", VA = "0x18988A240")]
		public static void NMETEELQRMA(DSNQEDELGVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9889530", Offset = "0x9888930", VA = "0x189889530")]
		public static void EZJEKGJQJBO(DXXMRYUFTQL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x988A510", Offset = "0x9889910", VA = "0x18988A510")]
		public static string QMDVWRDDSJW(FAOJZRJMKFV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x988AB20", Offset = "0x9889F20", VA = "0x18988AB20")]
		public static void WROSJVVHLEZ(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x988AA00", Offset = "0x9889E00", VA = "0x18988AA00")]
		public static void WROSJVVHLEZ(ViewId a, string b, PPTCRKDFMWF c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x988B740", Offset = "0x988AB40", VA = "0x18988B740")]
		public static void YNWNIOTCMVZ(ViewId a)
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
