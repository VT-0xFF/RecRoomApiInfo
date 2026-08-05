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
		[Cpp2IlInjected.Address(RVA = "0x9953D90", Offset = "0x9952790", VA = "0x189953D90")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, PPTCRKDFMWF creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9953CE0", Offset = "0x99526E0", VA = "0x189953CE0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, PPTCRKDFMWF creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9953B10", Offset = "0x9952510", VA = "0x189953B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9953520", Offset = "0x9951F20", VA = "0x189953520")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC0C30", Offset = "0xEBF630", VA = "0x180EC0C30")]
			internal Access(LWMYSYRVXIO instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x99534A0", Offset = "0x9951EA0", VA = "0x1899534A0")]
			public void GVQMOCJVNPI(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9953420", Offset = "0x9951E20", VA = "0x189953420")]
			public void GRUEFMJXDWM(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190")]
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
			[Cpp2IlInjected.Address(RVA = "0x9954A10", Offset = "0x9953410", VA = "0x189954A10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9956340", Offset = "0x9954D40", VA = "0x189956340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static WIQAXDJXXGK WMALFDPYXWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x99550C0", Offset = "0x9953AC0", VA = "0x1899550C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x99568F0", Offset = "0x99552F0", VA = "0x1899568F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string IBQDEZGEQNF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9954560", Offset = "0x9952F60", VA = "0x189954560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> DTVYCLFXDDO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x99571E0", Offset = "0x9955BE0", VA = "0x1899571E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool OFGSALPZLFD
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x99557C0", Offset = "0x99541C0", VA = "0x1899557C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool VHNJIAREFGW
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x99556C0", Offset = "0x99540C0", VA = "0x1899556C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool WODXRQUKXKL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9956240", Offset = "0x9954C40", VA = "0x189956240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double WIMGRXCFESD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9955D20", Offset = "0x9954720", VA = "0x189955D20")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int UOLXBGAQJPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9954F60", Offset = "0x9953960", VA = "0x189954F60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float FNGEIEZWPQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9955110", Offset = "0x9953B10", VA = "0x189955110")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9954C60", Offset = "0x9953660", VA = "0x189954C60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool GZHULXBNNNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x99566F0", Offset = "0x99550F0", VA = "0x1899566F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static PPTCRKDFMWF AFGQWFDUCRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9955740", Offset = "0x9954140", VA = "0x189955740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static BWXREESIIMX YFAIFNTMAUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9953ED0", Offset = "0x99528D0", VA = "0x189953ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static PPTCRKDFMWF FCZGBNMTFVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x99543E0", Offset = "0x9952DE0", VA = "0x1899543E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static FDSUQUMMUMO FXMBMGUIXFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x99562C0", Offset = "0x9954CC0", VA = "0x1899562C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int FQPVNFOJQVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9955930", Offset = "0x9954330", VA = "0x189955930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int TZAVINYGDOH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x99573C0", Offset = "0x9955DC0", VA = "0x1899573C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int KTVAAPJWICD
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9955840", Offset = "0x9954240", VA = "0x189955840")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string CVPCHQUQPWX
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x99572D0", Offset = "0x9955CD0", VA = "0x1899572D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long XQLZUWJMVOW
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9955370", Offset = "0x9953D70", VA = "0x189955370")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long GPBTWIIPGFL
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9955F80", Offset = "0x9954980", VA = "0x189955F80")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool JSLCVACGUML
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x99561C0", Offset = "0x9954BC0", VA = "0x1899561C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9956770", Offset = "0x9955170", VA = "0x189956770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string QCUXCJJKMJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9955AC0", Offset = "0x99544C0", VA = "0x189955AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9955C20", Offset = "0x9954620", VA = "0x189955C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99559B0", Offset = "0x99543B0", VA = "0x1899559B0")]
		public static Access MMCWBVDQCZB(LWMYSYRVXIO a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x99558C0", Offset = "0x99542C0", VA = "0x1899558C0")]
		public static void MCLDIXVWUHB(HRCJYZYWVYP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9956B00", Offset = "0x9955500", VA = "0x189956B00")]
		public static object XUXZNKVJQJJ(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9956BE0", Offset = "0x99555E0", VA = "0x189956BE0")]
		public static GameObject YIVTKMXMSGK(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9956FB0", Offset = "0x99559B0", VA = "0x189956FB0")]
		public static GameObject YIVTKMXMSGK(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9956EB0", Offset = "0x99558B0", VA = "0x189956EB0")]
		public static GameObject YIVTKMXMSGK(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9956D60", Offset = "0x9955760", VA = "0x189956D60")]
		public static GameObject YIVTKMXMSGK(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99553F0", Offset = "0x9953DF0", VA = "0x1899553F0")]
		public static GameObject INMYJABWNLS(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9955540", Offset = "0x9953F40", VA = "0x189955540")]
		public static GameObject INMYJABWNLS(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9956960", Offset = "0x9955360", VA = "0x189956960")]
		public static GameObject XRIRLRACRHP(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9955280", Offset = "0x9953C80", VA = "0x189955280")]
		public static GameObject IGKCEAHMETF(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9954EE0", Offset = "0x99538E0", VA = "0x189954EE0")]
		public static void FMDGONMNQMG(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9955A40", Offset = "0x9954440", VA = "0x189955A40")]
		public static void MWSAALSBPWH(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9954060", Offset = "0x9952A60", VA = "0x189954060")]
		public static GameObject AYQMCYKGBEA(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9954100", Offset = "0x9952B00", VA = "0x189954100")]
		public static GameObject AYQMCYKGBEA(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x99541A0", Offset = "0x9952BA0", VA = "0x1899541A0")]
		public static GameObject AYQMCYKGBEA(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9957440", Offset = "0x9955E40", VA = "0x189957440")]
		public static GameObject[] ZVFAGQWFOQD(IList<LKYIPQBLRXM> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9954FE0", Offset = "0x99539E0", VA = "0x189954FE0")]
		public static void GQKKXDFBGAU(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9955E10", Offset = "0x9954810", VA = "0x189955E10")]
		public static void OCVBVPXXSNB(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9954DE0", Offset = "0x99537E0", VA = "0x189954DE0")]
		public static void EXCBQGTVUNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9954CE0", Offset = "0x99536E0", VA = "0x189954CE0")]
		public static float EOXQRWFESLK(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9956090", Offset = "0x9954A90", VA = "0x189956090")]
		public static PPTCRKDFMWF UDHMAQVFXMH(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9954880", Offset = "0x9953280", VA = "0x189954880")]
		public static PPTCRKDFMWF BWKOWLCGPSV(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9954920", Offset = "0x9953320", VA = "0x189954920")]
		public static PPTCRKDFMWF CLAFOMMVCZV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9956130", Offset = "0x9954B30", VA = "0x189956130")]
		public static IReadOnlyList<PPTCRKDFMWF> VHBHPFAGCPV(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9956000", Offset = "0x9954A00", VA = "0x189956000")]
		public static IReadOnlyList<PPTCRKDFMWF> SLELIROGWLO(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9954A60", Offset = "0x9953460", VA = "0x189954A60")]
		public static void CYCBSYPTWUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9955CA0", Offset = "0x99546A0", VA = "0x189955CA0")]
		public static bool NPHQCDBYTAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9953F70", Offset = "0x9952970", VA = "0x189953F70")]
		public static bool AUODXOGMGTN(PPTCRKDFMWF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9954720", Offset = "0x9953120", VA = "0x189954720")]
		public static bool BTXCCJZIXMC(NetworkEventCode a, object b, GTCQSIYUTCU c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x99545F0", Offset = "0x9952FF0", VA = "0x1899545F0")]
		public static bool BTXCCJZIXMC(byte a, object b, GTCQSIYUTCU c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9955B20", Offset = "0x9954520", VA = "0x189955B20")]
		public static void NMDSSYPLZCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9954460", Offset = "0x9952E60", VA = "0x189954460")]
		public static void BGVSXQNQAUM(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9954AE0", Offset = "0x99534E0", VA = "0x189954AE0")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9956600", Offset = "0x9955000", VA = "0x189956600")]
		public static int WUHZDOUCNNU(FAOJZRJMKFV a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9954BE0", Offset = "0x99535E0", VA = "0x189954BE0")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9956860", Offset = "0x9955260", VA = "0x189956860")]
		public static void XAIXXKWZTRF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9955200", Offset = "0x9953C00", VA = "0x189955200")]
		public static int IFBQVVAAVCC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9955BA0", Offset = "0x99545A0", VA = "0x189955BA0")]
		public static void NMETEELQRMA(DSNQEDELGVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9954E60", Offset = "0x9953860", VA = "0x189954E60")]
		public static void EZJEKGJQJBO(DXXMRYUFTQL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9955E90", Offset = "0x9954890", VA = "0x189955E90")]
		public static string QMDVWRDDSJW(FAOJZRJMKFV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x99564D0", Offset = "0x9954ED0", VA = "0x1899564D0")]
		public static void WROSJVVHLEZ(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x99563B0", Offset = "0x9954DB0", VA = "0x1899563B0")]
		public static void WROSJVVHLEZ(ViewId a, string b, PPTCRKDFMWF c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9957100", Offset = "0x9955B00", VA = "0x189957100")]
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
