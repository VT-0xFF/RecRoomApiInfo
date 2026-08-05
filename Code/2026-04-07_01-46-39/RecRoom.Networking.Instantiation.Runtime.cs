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
	public interface TDCHMMXAEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object JWZQGMGSIRJ(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject MRWPUQWMDLM(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject SBWQJTLMQQM(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject HKMQHACNOYB(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject IZEHYHGEZOL(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AGJMMPUFJGG(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JHKWOLEPZJJ(GameObject a);
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
		public QCTMRFTYWMB creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9AA8540", Offset = "0x9AA7540", VA = "0x189AA8540")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, QCTMRFTYWMB creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9AA8680", Offset = "0x9AA7680", VA = "0x189AA8680")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, QCTMRFTYWMB creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7D60", Offset = "0x9AA6D60", VA = "0x189AA7D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7F30", Offset = "0x9AA6F30", VA = "0x189AA7F30")]
		public string UKZJDPNUYFM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface QXIAHLXVXIX
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] ZBUHWNQSTZF(IList<FBYVQEPOTAK> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QCDSJPGHJXI(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AYSDNCUEYFJ(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FTTRMULHQJA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class GDNDOJFCHLW
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly TDCHMMXAEAK instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
			internal Access(TDCHMMXAEAK instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4190", Offset = "0x9AA3190", VA = "0x189AA4190")]
			public void SVACPBRBKIC(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4210", Offset = "0x9AA3210", VA = "0x189AA4210")]
			public void VPXTUXTONCM(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
			private void FIWATNDFQFI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static BQFVKUSIMFN<PlayerId> TFIYDLNCLYG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static BQFVKUSIMFN<PlayerId> RXTTRCNNEBC;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static SOEJOTFBVHT SNFDUGULNWD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static BQQJFIGDFCF<QCTMRFTYWMB, double, object> EAMTASZYAMN;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static BQFVKUSIMFN<IReadOnlyList<InstantiateParameters>> MZNKAELOKEE;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static BQLCIBMFVQW<GameObject, bool> JSBDHXVKRNX;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static BQFVKUSIMFN<GameObject> FUXSGRDPRDV;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static BQFVKUSIMFN<GameObject> RJVHDBDBNOG;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static BQLCIBMFVQW<int, int> ZIVNJNRDLTQ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static FYRDCSIKYKI POLDTEVZHMH;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static BPFMYMWVRAU<string, ViewId, SMBOLORBDSA, SMBOLORBDSA> ZMASXSDYAYB;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static TDCHMMXAEAK POEUUXEHQLN;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access QVUNMLVWOVO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static QXIAHLXVXIX ONIBBVHRPDK;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static HTJYADKPZIO GIXBVPZEMBP;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static VTBHZBONJTB UOLRISREJII;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static BPUMKMZRCBN VBWCYGAOEOQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static HTJYADKPZIO VNRZBPXJSAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9AA5170", Offset = "0x9AA4170", VA = "0x189AA5170")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6930", Offset = "0x9AA5930", VA = "0x189AA6930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static ECJSWXZFQRA MPKHANPYTWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9AA51C0", Offset = "0x9AA41C0", VA = "0x189AA51C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9AA5B70", Offset = "0x9AA4B70", VA = "0x189AA5B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string OCQUBLJNPBB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6DE0", Offset = "0x9AA5DE0", VA = "0x189AA6DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> PDEDWOOYZWY
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4AB0", Offset = "0x9AA3AB0", VA = "0x189AA4AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool WUGYAMPLMXD
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6820", Offset = "0x9AA5820", VA = "0x189AA6820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool CASXLHDKDYC
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6E70", Offset = "0x9AA5E70", VA = "0x189AA6E70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool QSHEVNXINNN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4310", Offset = "0x9AA3310", VA = "0x189AA4310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double XUGUCERVHKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9AA5910", Offset = "0x9AA4910", VA = "0x189AA5910")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int OFLKXJLVGZN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6200", Offset = "0x9AA5200", VA = "0x189AA6200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float NMQNGGQOBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4E80", Offset = "0x9AA3E80", VA = "0x189AA4E80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool DVVCXGHSQVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6D60", Offset = "0x9AA5D60", VA = "0x189AA6D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool CBXBNDHBZZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4F70", Offset = "0x9AA3F70", VA = "0x189AA4F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static QCTMRFTYWMB BZISNAJGEBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9AA67A0", Offset = "0x9AA57A0", VA = "0x189AA67A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static JNIFYRYESKL OSLOXOYULWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9AA5530", Offset = "0x9AA4530", VA = "0x189AA5530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static QCTMRFTYWMB LERYWHOBAMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4600", Offset = "0x9AA3600", VA = "0x189AA4600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static RBRIQVJRNNA OPNMTYWCXMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6690", Offset = "0x9AA5690", VA = "0x189AA6690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int MPZTSRIXLCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4FF0", Offset = "0x9AA3FF0", VA = "0x189AA4FF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int IEWCABQVDNB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9AA7380", Offset = "0x9AA6380", VA = "0x189AA7380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int ZHNVWTSOVZB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9AA53B0", Offset = "0x9AA43B0", VA = "0x189AA53B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string VYJSHSWXBJR
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6280", Offset = "0x9AA5280", VA = "0x189AA6280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long BKDJBWQALJI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4910", Offset = "0x9AA3910", VA = "0x189AA4910")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long FKWROGGQLPD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4BA0", Offset = "0x9AA3BA0", VA = "0x189AA4BA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool YIMSHLABBZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4990", Offset = "0x9AA3990", VA = "0x189AA4990")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4780", Offset = "0x9AA3780", VA = "0x189AA4780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string CHYHKZNZCMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6630", Offset = "0x9AA5630", VA = "0x189AA6630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9AA50F0", Offset = "0x9AA40F0", VA = "0x189AA50F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9AA72F0", Offset = "0x9AA62F0", VA = "0x189AA72F0")]
		public static Access WUBIJWZVQAT(TDCHMMXAEAK a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6370", Offset = "0x9AA5370", VA = "0x189AA6370")]
		public static void NHCWQDNXNUL(QXIAHLXVXIX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5740", Offset = "0x9AA4740", VA = "0x189AA5740")]
		public static object JWZQGMGSIRJ(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5C60", Offset = "0x9AA4C60", VA = "0x189AA5C60")]
		public static GameObject MRWPUQWMDLM(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6030", Offset = "0x9AA5030", VA = "0x189AA6030")]
		public static GameObject MRWPUQWMDLM(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5DE0", Offset = "0x9AA4DE0", VA = "0x189AA5DE0")]
		public static GameObject MRWPUQWMDLM(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5EE0", Offset = "0x9AA4EE0", VA = "0x189AA5EE0")]
		public static GameObject MRWPUQWMDLM(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA69A0", Offset = "0x9AA59A0", VA = "0x189AA69A0")]
		public static GameObject SBWQJTLMQQM(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6AF0", Offset = "0x9AA5AF0", VA = "0x189AA6AF0")]
		public static GameObject SBWQJTLMQQM(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5210", Offset = "0x9AA4210", VA = "0x189AA5210")]
		public static GameObject HKMQHACNOYB(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9AA55D0", Offset = "0x9AA45D0", VA = "0x189AA55D0")]
		public static GameObject IZEHYHGEZOL(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4290", Offset = "0x9AA3290", VA = "0x189AA4290")]
		public static void AGJMMPUFJGG(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9AA56C0", Offset = "0x9AA46C0", VA = "0x189AA56C0")]
		public static void JHKWOLEPZJJ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9AA71D0", Offset = "0x9AA61D0", VA = "0x189AA71D0")]
		public static GameObject VDGMRESEZSM(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7130", Offset = "0x9AA6130", VA = "0x189AA7130")]
		public static GameObject VDGMRESEZSM(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6EF0", Offset = "0x9AA5EF0", VA = "0x189AA6EF0")]
		public static GameObject VDGMRESEZSM(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7570", Offset = "0x9AA6570", VA = "0x189AA7570")]
		public static GameObject[] ZBUHWNQSTZF(IList<FBYVQEPOTAK> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4DA0", Offset = "0x9AA3DA0", VA = "0x189AA4DA0")]
		public static void EGMENCGEESI(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4420", Offset = "0x9AA3420", VA = "0x189AA4420")]
		public static void AYSDNCUEYFJ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5070", Offset = "0x9AA4070", VA = "0x189AA5070")]
		public static void FTTRMULHQJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5430", Offset = "0x9AA4430", VA = "0x189AA5430")]
		public static float IPGVAAGBOEQ(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4A10", Offset = "0x9AA3A10", VA = "0x189AA4A10")]
		public static QCTMRFTYWMB DOSIYYYTFMX(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4870", Offset = "0x9AA3870", VA = "0x189AA4870")]
		public static QCTMRFTYWMB DEVHBWDOJSF(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7400", Offset = "0x9AA6400", VA = "0x189AA7400")]
		public static QCTMRFTYWMB XCFOZJMINOH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4390", Offset = "0x9AA3390", VA = "0x189AA4390")]
		public static IReadOnlyList<QCTMRFTYWMB> ALTKBHTYVUP(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6710", Offset = "0x9AA5710", VA = "0x189AA6710")]
		public static IReadOnlyList<QCTMRFTYWMB> QKTYMEZZGOA(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7270", Offset = "0x9AA6270", VA = "0x189AA7270")]
		public static void WKCPVNOITUD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5A00", Offset = "0x9AA4A00", VA = "0x189AA5A00")]
		public static bool KQCVZKRFVIL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5820", Offset = "0x9AA4820", VA = "0x189AA5820")]
		public static bool KFOAQEJMPPJ(QCTMRFTYWMB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7670", Offset = "0x9AA6670", VA = "0x189AA7670")]
		public static bool ZKAFYNRYOQW(NetworkEventCode a, object b, GWNNVAAQPXK c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9AA77D0", Offset = "0x9AA67D0", VA = "0x189AA77D0")]
		public static bool ZKAFYNRYOQW(byte a, object b, GWNNVAAQPXK c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9AA44A0", Offset = "0x9AA34A0", VA = "0x189AA44A0")]
		public static void AZDULUIDTAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4680", Offset = "0x9AA3680", VA = "0x189AA4680")]
		public static void BIDIANLANQI(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4C20", Offset = "0x9AA3C20", VA = "0x189AA4C20")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6C70", Offset = "0x9AA5C70", VA = "0x189AA6C70")]
		public static int SDBOPHCHTSK(PKEJZTAIXED a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D20", Offset = "0x9AA3D20", VA = "0x189AA4D20")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA68A0", Offset = "0x9AA58A0", VA = "0x189AA68A0")]
		public static void RTKJDKUWSXN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5BE0", Offset = "0x9AA4BE0", VA = "0x189AA5BE0")]
		public static int MMCQUIJKMDU()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6180", Offset = "0x9AA5180", VA = "0x189AA6180")]
		public static void MSWHIKDLCZK(VTBHZBONJTB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9AA74F0", Offset = "0x9AA64F0", VA = "0x189AA74F0")]
		public static void YEULCBBEOOA(BPUMKMZRCBN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5A80", Offset = "0x9AA4A80", VA = "0x189AA5A80")]
		public static string KUGKHQMMPOQ(PKEJZTAIXED a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6500", Offset = "0x9AA5500", VA = "0x189AA6500")]
		public static void OGVTRJXPDIZ(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9AA63E0", Offset = "0x9AA53E0", VA = "0x189AA63E0")]
		public static void OGVTRJXPDIZ(ViewId a, string b, QCTMRFTYWMB c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4520", Offset = "0x9AA3520", VA = "0x189AA4520")]
		public static void BAMBNRYZJAH(ViewId a)
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
